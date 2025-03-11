using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KennelClub
{
    public partial class frmBooking : Form
    {
        Button[] btns = new Button[26];

        private SqlDataAdapter daNames, daCustomers, daDogs, daKennels, daBooking, daBookingDet, daBookingKennels;
        DataSet dsInTheDogHouse = new DataSet();
        private SqlConnection conn;
        private SqlCommand cmdCustomerDetails, cmdDogDetails, cmdKennelDetails;

        

        private SqlCommandBuilder cmdBBooking, cmdBBookingDet, cmdBBookedKennels;

      

        private DataRow drCustomer;

      

        private String sqlNames,
            sqlCustomerDetails,
            sqlDogDetails,
            sqlKennelDetails,
            sqlBooking,
            sqlBookingDet,
            sqlBookedKennels;

     

        private String connStr;

        public frmBooking()
        {
            InitializeComponent();
        }


        private void frmBooking_Load(object sender, EventArgs e)
        {
            int no;

            lblBookingDate.Text = DateTime.Now.ToShortDateString();
            dtpStartDate.MinDate = DateTime.Now;

            for (int i = 0; i < 26; i++)
            {
                btns[i] = (Button) pnlButtons.Controls[i];
                btns[i].Text = "" + (char) (65 + i);
                btns[i].Enabled = false;
                btns[i].Click += new EventHandler(btn1_Click);
            }

          //  connStr = @"Data Source =.; Initial Catalog = InTheDogHouse; Integrated Security = true";
            connStr = @"Data Source = REDTOPS\SQLEXPRESS; Initial Catalog = InTheDogHouse; Integrated Security = True";
            //connStr = Properties.connectionStr;
            //get surnames for alphabet buttons
          sqlNames = @"Select surname from customer order by surname";
          daNames = new SqlDataAdapter(sqlNames, connStr);
          daNames.Fill(dsInTheDogHouse, "Name");

            //enable relevant alpha buttons
            foreach (DataRow dr in dsInTheDogHouse.Tables["Name"].Rows)
            {
                no = (int) dr["Surname"].ToString()[0] - 65;
                btns[no].Enabled = true;
                btns[no].BackColor = Color.Black;
                btns[no].ForeColor = Color.White;
            }

            //set up dataAdapter for customer details for the listbox
            sqlCustomerDetails =
                @"Select customerNo, title, surname, forename, surname +','+ 
                Forename as name, street, town, county, postcode, telno from 
                customer where surname LIKE @Letter order by surname, forename";
            conn = new SqlConnection(connStr);
            cmdCustomerDetails = new SqlCommand(sqlCustomerDetails, conn);
            cmdCustomerDetails.Parameters.Add("@Letter", SqlDbType.VarChar);
            daCustomers = new SqlDataAdapter(cmdCustomerDetails);
            daCustomers.FillSchema(dsInTheDogHouse, SchemaType.Source, "Customer");

            //set up dataAdapter for dog details for the listbox
            sqlDogDetails =
                @"Select dogNo, name, breedNo, dob, gender, colour, customerNo from dog where customerNo LIKE @CustNo order by dogNo";
            cmdDogDetails = new SqlCommand(sqlDogDetails, conn);
            cmdDogDetails.Parameters.Add("@CustNo", SqlDbType.Int);
            daDogs = new SqlDataAdapter(cmdDogDetails);
            daDogs.FillSchema(dsInTheDogHouse, SchemaType.Source, "Dog");

            //set up dataAdapter for kennel detail for the listbox
            sqlKennelDetails =
                @"SELECT distinct kennelNo, sizeK, sizeNo, sizeB, dog.breedNo, chargePerDay FROM kennel join size on 
                sizeK = sizeNo join breed on sizeNo = sizeB join dog on dog.breedNo =
                breed.breedNo WHERE dog.breedNo = @BreedNo order by kennelNo";
            cmdKennelDetails = new SqlCommand(sqlKennelDetails, conn);
            cmdKennelDetails.Parameters.Add("@BreedNo", SqlDbType.Int);
            daKennels = new SqlDataAdapter(cmdKennelDetails);
            daKennels.FillSchema(dsInTheDogHouse, SchemaType.Source, "Kennel");

            //set up dataAdapter for kennels already booked details for the validation
            sqlBookedKennels =
                @"SELECT booking.bookingNo, dateStart, noDays, dogNo, kennelNo FROM booking 
                JOIN bookingDetail ON booking.bookingNo = bookingDetail.bookingNo order by bookingNo";
            daBookingKennels = new SqlDataAdapter(sqlBookedKennels, conn);
            cmdBBookedKennels = new SqlCommandBuilder(daBookingKennels);
            daBookingKennels.FillSchema(dsInTheDogHouse, SchemaType.Source, "Booked Kennels");
            daBookingKennels.Fill(dsInTheDogHouse, "Booked Kennels");


            sqlBooking = @"SELECT * from Booking";
            daBooking = new SqlDataAdapter(sqlBooking, conn);
            cmdBBooking = new SqlCommandBuilder(daBooking);
            daBooking.FillSchema(dsInTheDogHouse, SchemaType.Source, "Booking");
            daBooking.Fill(dsInTheDogHouse, "Booking");


            sqlBookingDet = @"SELECT * from BookingDetail";
            daBookingDet = new SqlDataAdapter(sqlBookingDet,conn);
            cmdBBookingDet = new SqlCommandBuilder(daBookingDet);
            daBookingDet.FillSchema(dsInTheDogHouse, SchemaType.Source, "Booking Detail");
            daBookingDet.Fill(dsInTheDogHouse, "Booking Detail");

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            //get customer details for listbox - use selected button letter for parameter
            String str = b.Text;

            //empty dataset table customer
            dsInTheDogHouse.Tables["Customer"].Clear();

            fillListboxCustomers(str);

            //clear any previously selected dogs/kennels by emptying the dataset tables
            dsInTheDogHouse.Tables["Dog"].Clear();
            dsInTheDogHouse.Tables["Kennel"].Clear();

            ClearCustomer(); // clear table its attached to
            pnlBooking.Enabled = false;


        }

        private void fillListboxCustomers(String str)
        {
            //get all customer details for listbox - use wildcard for parameter
            cmdCustomerDetails.Parameters["@Letter"].Value = str + "%";
            daCustomers.Fill(dsInTheDogHouse, "Customer");

            //fill listbox
            lstCust.DataSource = dsInTheDogHouse.Tables["Customer"];
            lstCust.DisplayMember = "name";
            lstCust.ValueMember = "CustomerNo";
        }

        private void lstKennel_Click(object sender, EventArgs e)
        {
            if(lstKennel.Items.Count != 0)
            {
                pnlBooking.Enabled = true;
            }
        }

        private void lstDog_Click(object sender, EventArgs e)
        {
            if(lstDog.Items.Count != 0)
            {
                //empty dataset table Kennel
                dsInTheDogHouse.Tables["Kennel"].Clear();

                //get all kennel details for the listbox
                cmdKennelDetails.Parameters["@BreedNo"].Value = lstDog.SelectedValue;

                daKennels.Fill(dsInTheDogHouse, "Kennel");

                //fill listbox
                lstKennel.DataSource = dsInTheDogHouse.Tables["Kennel"];
                lstKennel.DisplayMember = "KennelNo";
                lstKennel.ValueMember = "KennelNo";

                lstKennel.SelectedIndex = -1;
            }
        }

        private void lstCustomer_Click(object sender, EventArgs e)
        {
            String title = "";

            dsInTheDogHouse.Tables["Dog"].Clear();

            //get all details for the listbox
            cmdDogDetails.Parameters["@CustNo"].Value = lstCust.SelectedValue;

            daDogs.Fill(dsInTheDogHouse, "Dog");

            //fill listbox
            lstDog.DataSource = dsInTheDogHouse.Tables["Dog"];
            lstDog.DisplayMember = "name";
            lstDog.ValueMember = "breedNo";

            lstDog.SelectedIndex = -1;

            drCustomer = dsInTheDogHouse.Tables["Customer"].Rows.Find(lstCust.SelectedValue);

            if(drCustomer["Title"].ToString() == "Mr")
            {
                title = "Mr";
            }
            if (drCustomer["Title"].ToString() == "Mrs")
            {
                title = "Mrs";
            }
            if (drCustomer["Title"].ToString() == "Miss")
            {
                title = "Miss";
            }
            if (drCustomer["Title"].ToString() == "Ms")
            {
                title = "Ms";
            }

            lblCustNo.Text = drCustomer["CustomerNo"].ToString();
            lblCustName.Text = drCustomer["Forename"].ToString() + "" + drCustomer["Surname"].ToString();
            lblCustStreet.Text = drCustomer["Street"].ToString();
            lblCustTown.Text = drCustomer["Town"].ToString();
            lblCustCounty.Text = drCustomer["County"].ToString();
            lblCustPostCode.Text = drCustomer["Postcode"].ToString();



        }

        private void btnBookingAdd_Click(object sender, EventArgs e)
        {
            DataRow drBooking, drBookingDets;
            int bookingNo;

            int noRows = dsInTheDogHouse.Tables["Booking"].Rows.Count;

            drBooking = dsInTheDogHouse.Tables["Booking"].Rows[noRows - 1];
            bookingNo = (int.Parse(drBooking["BookingNo"].ToString()) + 1);

            if (lstCust.SelectedIndex == -1)
                MessageBox.Show("Please select a Customer", "Customer");
            else if (lstDog.SelectedIndex == -1)
                MessageBox.Show("Please select a Dog", "Dog");
            else if (lstKennel.SelectedIndex == -1)
                MessageBox.Show("Please select a Kennel", "Kennel");
            else if (cmbNoOfDays.SelectedIndex == -1)
            {
                MessageBox.Show("Please input number of days required", "No Of Days");
                cmbNoOfDays.Focus();
            }
            else if(lvwBooking.Items.Count == 0)
                MessageBox.Show("Please add a dog/kennel to the booking", "Booking Details");
            else
            {
                drBooking = dsInTheDogHouse.Tables["Booking"].NewRow();

                drBooking["BookingNo"] = bookingNo;
                drBooking["customerNo"] = int.Parse(lblCustNo.Text);
                drBooking["dateBooked"] = DateTime.Parse(lblBookingDate.Text.Trim());
                drBooking["dateStart"] = DateTime.Parse(dtpStartDate.Text.Trim());
                drBooking["noDays"] = int.Parse(cmbNoOfDays.Text);

                dsInTheDogHouse.Tables["Booking"].Rows.Add(drBooking);
                daBooking.Update(dsInTheDogHouse, "Booking");

                foreach(ListViewItem item in lvwBooking.Items)
                {
                    drBookingDets = dsInTheDogHouse.Tables["BookingDetail"].NewRow();
                    drBookingDets["bookingNo"] = drBooking["bookingNo"];
                    drBookingDets["dogNo"] = int.Parse(item.SubItems[0].Text);
                    drBookingDets["KennelNo"] = int.Parse(item.SubItems[2].Text);
                    dsInTheDogHouse.Tables["BookingDetail"].Rows.Add(drBookingDets);
                    daBookingDet.Update(dsInTheDogHouse, "BookingDetail");
                }

                MessageBox.Show("Booking No: " + drBooking["bookingNo"].ToString() + "added to system");

                pnlBooking.Enabled = false;

            }
        }

        private void btnBookingAddItem_Click(object sender, EventArgs e)
        {
            bool ok = true;
            bool exits = false;

            if (lstCust.SelectedIndex == -1)
                MessageBox.Show("Please select a Customer", "Customer");
            else if (lstDog.SelectedIndex == -1)
                MessageBox.Show("Please select a Dog", "Dog");
            else if (lstKennel.SelectedIndex == -1)
                MessageBox.Show("Please select a Kennel", "Kennel");
            else if(cmbNoOfDays.SelectedIndex == -1)
            {
                MessageBox.Show("Please input number of days required", "No Of Days");
                cmbNoOfDays.Focus();
            }
            else
            {
                foreach(ListViewItem item in lvwBooking.Items)
                {
                    if(item.SubItems[1].Text == lstDog.Text || item.SubItems[2].Text == lstKennel.Text)
                    {
                        MessageBox.Show("Dog or Kennel already selected for this booking.", "Booking");
                        exits = true;
                        break;
                    }
                }

                if(!exits)
                {
                    DateTime start = DateTime.Parse(dtpStartDate.Text.Trim());

                    foreach(DataRow dr in dsInTheDogHouse.Tables["Booked Kennels"].Rows)
                    {
                        DateTime bookedDate = DateTime.Parse(dr["dateStart"].ToString());

                        if(start >= bookedDate && start <= bookedDate.AddDays(int.Parse(cmbNoOfDays.Text)))
                        {
                            if((dr["dogNo"] == lstDog.SelectedValue) || (dr["kennelNo"].ToString() == lstKennel.Text))
                            {
                                MessageBox.Show("Either the selected kennel or dog is already included in a booking for this date range. Please re-select.", "Booking");
                                ok = false;
                            }
                            if (!ok)
                                break;
                        }
                    }
                    if(ok)
                    {
                        foreach(DataRow dr in dsInTheDogHouse.Tables["dog"].Rows)
                        {
                            if(dr["name"].ToString() == lstDog.Text)
                            {
                                ListViewItem item = new ListViewItem(dr["dogno"].ToString());
                                item.SubItems.Add(dr["name"].ToString());
                                item.SubItems.Add(lstKennel.Text);
                                lvwBooking.Items.Add(item);
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void BtnBookingRemoveItem_Click(object sender, EventArgs e)
        {
            if(lvwBooking.SelectedItems.Count != 0)
            {
                var item = lvwBooking.SelectedItems[0];
                lvwBooking.Items.Remove(item);
            }
        }

        private void ClearCustomer()
        {
            lstCust.SelectedIndex = -1;

            lblCustNo.Text = "";
            lblCustName.Text = "";
            lblCustStreet.Text = "";
            lblCustTown.Text = "";
            lblCustCounty.Text = "";
            lblCustPostCode.Text = "";
        }

    }
}
