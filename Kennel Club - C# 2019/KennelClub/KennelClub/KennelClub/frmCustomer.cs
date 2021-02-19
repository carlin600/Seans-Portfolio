using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KennelClub
{
    public partial class frmCustomer : Form
    {

        SqlDataAdapter daCustomer;
        DataSet dsInTheDogHouse = new DataSet();
        SqlCommandBuilder cmdBCustomer;
        DataRow drCustomer;
        String connStr, sqlCustomer;
        int selectedTab = 0;
        bool custSelected = false;
        int custNoSelected = 0;


        public frmCustomer()
        {

            InitializeComponent();
        }


        //Teresa, did you say we had to type all this out for the form class in a specific order? Or did you mean the order of the booklets we numbered


        //does the name of our kennel form matter or does it have to be the same as the database name
        //e.g inthedoghouse is the datbase whereas my form is kennelclub
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            connStr = @"Data source = .; Initial Catalog = InTheDogHouse; Integrated Security = true";
            sqlCustomer = @"select * from Customer";
            daCustomer = new SqlDataAdapter(sqlCustomer, connStr);
            cmdBCustomer = new SqlCommandBuilder(daCustomer);
            daCustomer.FillSchema(dsInTheDogHouse, SchemaType.Source, "Customer");
            daCustomer.Fill(dsInTheDogHouse, "Customer");
            dgvCustomers.DataSource = dsInTheDogHouse.Tables["Customer"];

            //resize the DataGridView columns to fit the newly loaded content. - Huh?

            dgvCustomers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            tabcustomer.SelectedIndex = 1;
            tabcustomer.SelectedIndex = 0;
        }

        //display tab
        private void btndisplaydelete_Click(object sender, EventArgs e)
        {
            //if (1stCustomers.SelectedIndices.Count == 0)
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer from the list.", "Select Customer");
            }
            else
            {
                drCustomer = dsInTheDogHouse.Tables["Customer"].Rows.Find(dgvCustomers.SelectedRows[0].Cells[0].Value);

                string tempName = drCustomer["Forename"].ToString() + " " + drCustomer["Surname"].ToString() + "\' s";

                if (MessageBox.Show("Are you sure you want to delete " + tempName + "details?", "Add Customer", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    drCustomer.Delete();
                    daCustomer.Update(dsInTheDogHouse, "Customer");
                }
            }
        }

        private void btndisplayadd_Click(object sender, EventArgs e)
        {
            tabcustomer.SelectedIndex = 1;
        }

        private void btndisplayedit_MouseEnter(object sender, EventArgs e)
        {
            lbldisplayedit.ForeColor = Color.Blue;
        }

        private void btndisplayedit_Click(object sender, EventArgs e)
        {
            tabcustomer.SelectedIndex = 2;
        }



        //add tab
        private void btnaddAdd_Click(object sender, EventArgs e)
        {
            MyCustomer myCustomer = new MyCustomer();
            bool ok = true;
            errP.Clear();

            try
            {
                myCustomer.CustomerNo = Convert.ToInt32(lbladdCustNo.Text.Trim()); // passed to Customer class to check
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(lbladdCustNo, MyEx.toString());

            }

            try
            {
                myCustomer.Title = cmbaddTitle.Text.Trim(); //passed to customer class to check
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(cmbaddTitle, MyEx.toString());
            }

            try
            {
                myCustomer.Surname = txtaddSurname.Text.Trim(); //passed to customer class to check
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtaddSurname, MyEx.toString());
            }

            try
            {
                myCustomer.Forename = txtaddForename.Text.Trim(); //passed to customer class to check
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtaddForename, MyEx.toString());
            }

            try
            {
                myCustomer.Street = txtaddStreet.Text.Trim(); //passed to customer class to check
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtaddStreet, MyEx.toString());
            }

            try
            {
                myCustomer.Town = txtaddTown.Text.Trim(); //passed to customer class to check
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtaddTown, MyEx.toString());
            }

            try
            {
                myCustomer.County = txtaddCounty.Text.Trim(); //passed to customer class to check
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtaddCounty, MyEx.toString());
            }

            try
            {
                myCustomer.Postcode = txtaddPostcode.Text.Trim(); //passed to customer class to check
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtaddPostcode, MyEx.toString());
            }

            try
            {
                myCustomer.TelNo = txtaddTelNo.Text.Trim(); //passed to customer class to check
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtaddTelNo, MyEx.toString());
            }

            try
            {
                if (ok)
                {
                    drCustomer = dsInTheDogHouse.Tables["Customer"].NewRow();
                    drCustomer["CustomerNo"] = myCustomer.CustomerNo;
                    drCustomer["Title"] = myCustomer.Title;
                    drCustomer["Forename"] = myCustomer.Forename;
                    drCustomer["Surname"] = myCustomer.Surname;
                    drCustomer["Street"] = myCustomer.Street;
                    drCustomer["Town"] = myCustomer.Town;
                    drCustomer["County"] = myCustomer.County;
                    drCustomer["Postcode"] = myCustomer.Postcode;
                    drCustomer["TelNo"] = myCustomer.TelNo;

                    dsInTheDogHouse.Tables["Customer"].Rows.Add(drCustomer);
                    daCustomer.Update(dsInTheDogHouse, "Customer");

                    MessageBox.Show("Customer Added");

                    if (MessageBox.Show("Do you wish to add another customer?", "Add Customer", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        clearAddForm();

                        getNumber(dsInTheDogHouse.Tables["Customer"].Rows.Count);
                    }
                    else
                    {
                        tabcustomer.SelectedIndex = 0;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!", MessageBoxButtons.AbortRetryIgnore,
                    MessageBoxIcon.Error);
            }
        }

        private void txtAddSurname_TextChanged(object sender, EventArgs e)
        {
            if (txtaddSurname.Text.Length >= 2 && txtaddSurname.Text.Length <= 15)
            {
                txtaddSurname.BackColor = Color.White;
            }
            else
            {
                txtaddSurname.BackColor = Color.LightCoral;
            }
        }

        private void btnaddcancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel the addition of Customer No: " + lbladdCustNo.Text + "?", "Add Customer", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                tabcustomer.SelectedIndex = 0;
            }
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            // btnAdd.BorderStyle = BorderStyle.FixedSingle;
        }

        void AddTabValidate(object sender, CancelEventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                custSelected = false;
                custNoSelected = 0;
            }
            else if (dgvCustomers.SelectedRows.Count == 1)
            {
                custSelected = true;
                custNoSelected = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells[0].Value);
            }
        }


        //edit tab
        private void btneditedit_Click(object sender, EventArgs e)
        {
            //why wont this work
            if (lbleditedit.Text == "Edit")
            {
                cmbeditTitle.Enabled = true;
                txteditForename.Enabled = true;
                txteditSurname.Enabled = true;
                txteditStreet.Enabled = true;
                txteditTown.Enabled = true;
                txteditCounty.Enabled = true;
                txteditPostcode.Enabled = true;
                txteditTelNo.Enabled = true;

                lbleditedit.Text = "Save";
            }
            else
            {
                MyCustomer myCustomer = new MyCustomer();
                bool ok = true;
                errP.Clear();

                try
                {
                    myCustomer.CustomerNo = Convert.ToInt32(lbleditCustNo.Text.Trim()); //passed to customer class to check
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(lbleditCustNo, MyEx.toString());
                }

                try
                {
                    myCustomer.Title = cmbeditTitle.Text.Trim(); //passed to customer class to check
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(cmbeditTitle, MyEx.toString());
                }

                try
                {
                    myCustomer.Surname = txteditSurname.Text.Trim(); //passed to customer class to check
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txteditSurname, MyEx.toString());
                }

                try
                {
                    myCustomer.Forename = txteditForename.Text.Trim(); //passed to customer class to check
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txteditForename, MyEx.toString());
                }

                try
                {
                    myCustomer.Street = txteditStreet.Text.Trim(); //passed to customer class to check
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txteditStreet, MyEx.toString());
                }

                try
                {
                    myCustomer.Town = txteditTown.Text.Trim(); //passed to customer class to check
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txteditTown, MyEx.toString());
                }

                try
                {
                    myCustomer.County = txteditCounty.Text.Trim(); //passed to customer class to check
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txteditCounty, MyEx.toString());
                }
                try
                {
                    myCustomer.Postcode = txteditPostcode.Text.Trim(); //passed to customer class to check
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txteditPostcode, MyEx.toString());
                }

                try
                {
                    myCustomer.TelNo = txteditTelNo.Text.Trim(); //passed to customer class to check
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txteditTelNo, MyEx.toString());
                }

                try
                {
                    if (ok)
                    {
                        drCustomer.BeginEdit();
                        drCustomer["CustomerNo"] = myCustomer.CustomerNo;
                        drCustomer["Title"] = myCustomer.Title;
                        drCustomer["Forename"] = myCustomer.Forename;
                        drCustomer["Surname"] = myCustomer.Surname;
                        drCustomer["Street"] = myCustomer.Street;
                        drCustomer["Town"] = myCustomer.Town;
                        drCustomer["County"] = myCustomer.County;
                        drCustomer["Postcode"] = myCustomer.Postcode;
                        drCustomer["TelNo"] = myCustomer.TelNo;

                        drCustomer.EndEdit();
                        daCustomer.Update(dsInTheDogHouse, "Customer");

                        MessageBox.Show("Customer Details Updated", "Customer");

                        cmbeditTitle.Enabled = false;
                        txteditForename.Enabled = false;
                        txteditSurname.Enabled = false;
                        txteditStreet.Enabled = false;
                        txteditTown.Enabled = false;
                        txteditCounty.Enabled = false;
                        txteditPostcode.Enabled = false;
                        txteditTelNo.Enabled = false;

                        lbldisplayedit.Text = "Edit";
                        tabcustomer.SelectedIndex = 0;


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!", MessageBoxButtons.AbortRetryIgnore,
                        MessageBoxIcon.Error);
                }

            }
        }

        private void btneditCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel the edit of Customer No: " + lbleditCustNo.Text + "?", "Edit Customer", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                tabcustomer.SelectedIndex = 0;
            }
        }

        void EditTabValidate(object sender, CancelEventArgs e)
        {
            if (custSelected == false && custNoSelected == 0)
            {
                //have to do this bit here, reset tab to display and put out message to select a customer
                custSelected = false;
                custNoSelected = 0;
            }
            else if (dgvCustomers.SelectedRows.Count == 1)
            {
                custSelected = true;
                custNoSelected = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells[0].Value);

            }
        }

        private void tabCustDisplay_MouseEnter(object sender, EventArgs e)
        {
            //  btnAdd.BorderStyle = BorderStyle.None;
            lbleditcancel.ForeColor = Color.Gray;
        }




        //unsure about these

        //tried double clicking didnt work
        private void tabCustomer_SelctectedIndexChanged(object sender, EventArgs e)
        {
            selectedTab = tabcustomer.SelectedIndex;

            tabcustomer.TabPages[tabcustomer.SelectedIndex].Focus();

            tabcustomer.TabPages[tabcustomer.SelectedIndex].CausesValidation = true;

            //whats all this for?-----------------------------------
            //if (dgvCustomers.SelectedRows.Count == 0 && tabCustomers.SelectedIndex == 2)
            //tabCustomers.TabPages[tabCustomers.SelectedIndex].CausesValidation = true;
            //else
            //{

            switch (tabcustomer.SelectedIndex)
            {
                case 0: // display tab selected
                    {
                        dsInTheDogHouse.Tables["Customer"].Clear();
                        daCustomer.Fill(dsInTheDogHouse, "Customer");

                        break;
                    }

                case 1: //add tab selected
                    {
                        int noRows = dsInTheDogHouse.Tables["Customer"].Rows.Count;

                        if (noRows == 0)
                        {
                            lbladdCustNo.Text = "1000";

                        }
                        else
                        {
                            getNumber(noRows);
                        }
                        errP.Clear();
                        clearAddForm();
                        break;
                    }

                case 2: // edit tab selected
                    {
                        if (custNoSelected == 0)
                        {
                            tabcustomer.SelectedIndex = 0;
                            break;
                        }
                        else
                        {
                            lbleditCustNo.Text = custNoSelected.ToString();
                            drCustomer = dsInTheDogHouse.Tables["Customer"].Rows.Find(lbleditCustNo.Text);
                            if (drCustomer["Title"].ToString() == "Mr")
                                cmbeditTitle.SelectedIndex = 0;
                            if (drCustomer["Title"].ToString() == "Mrs")
                                cmbeditTitle.SelectedIndex = 1;
                            if (drCustomer["Title"].ToString() == "Miss")
                                cmbeditTitle.SelectedIndex = 2;
                            if (drCustomer["Title"].ToString() == "Ms")
                                cmbeditTitle.SelectedIndex = 3;

                            txteditForename.Text = drCustomer["Forename"].ToString();
                            txteditSurname.Text = drCustomer["Surname"].ToString();
                            txteditStreet.Text = drCustomer["Street"].ToString();
                            txteditTown.Text = drCustomer["Town"].ToString();
                            txteditCounty.Text = drCustomer["County"].ToString();
                            txteditPostcode.Text = drCustomer["Postcode"].ToString();
                            txteditTelNo.Text = drCustomer["TelNo"].ToString();

                            break;

                        }
                    }

            }
        }

        private void frmCustomer_Shown(object sender, EventArgs e)
        {
            tabcustomer.TabPages[0].CausesValidation = true;
            tabcustomer.TabPages[0].Validating += new CancelEventHandler(AddTabValidate);

            tabcustomer.TabPages[2].CausesValidation = true;
            tabcustomer.TabPages[2].Validating += new CancelEventHandler(EditTabValidate);// where is this tab?

        }

        //
        void clearAddForm()
        {
            cmbaddTitle.SelectedIndex = -1;
            txtaddForename.Clear();
            txtaddSurname.Clear();
            txtaddStreet.Clear();
            txtaddTown.Clear();
            txtaddCounty.Clear();
            txtaddPostcode.Clear();
            txtaddTelNo.Clear();
        }

        private void getNumber(int noRows)
        {
            drCustomer = dsInTheDogHouse.Tables["Customer"].Rows[noRows - 1];
            lbladdCustNo.Text = (int.Parse(drCustomer["CustomerNo"].ToString()) + 1).ToString();
        }



   



















    }
}
