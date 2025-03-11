using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LloydsPharmacy
{
    public partial class frmPrescriptions : Form
    {
        SqlDataAdapter daPatients, daPrescriptions, daPresDetails, daStock, daNames;
        SqlConnection conn;
        DataSet dsLloydsPharmacy = new DataSet();
        SqlCommand cmdPatients, cmdPrescriptions, cmdPresDetails, cmdStock;
        SqlCommandBuilder cmdBStock;
        DataRow drPatients;
        String connStr, sqlPatients, sqlPrescriptions, sqlPresDetails, sqlStock, sqlNames;

        Button[] btns = new Button[26];

        Color darkGreen = new Color();
        Color lightGreen = new Color();

        public frmPrescriptions()
        {
            InitializeComponent();
        }

        private void frmPrescriptions_Load(object sender, EventArgs e)
        {
            int no;

            connStr = @"Data Source = REDTOPS\SQLEXPRESS; Initial Catalog = LloydsPharmacy; Integrated Security = true";
            //connStr = @"Data Source = .; Initial Catalog = LloydsPharmacy; Integrated Security = true";
            conn = new SqlConnection(connStr);

            // Set up dataAdapter for patient names for listbox
            sqlNames = @"Select PatientSurname from Patient order by PatientSurname";
            daNames = new SqlDataAdapter(sqlNames, connStr);
            daNames.Fill(dsLloydsPharmacy, "Names");

            // Set up dataAdapter for patient details for the listbox
            sqlPatients = @"Select PatientID, PatientForename, PatientSurname, PatientSurname + ', ' + PatientForename as PatientName from Patient where PatientSurname LIKE @Letter order by PatientSurname, PatientForename";
            cmdPatients = new SqlCommand(sqlPatients, conn);
            cmdPatients.Parameters.Add("@Letter", SqlDbType.VarChar);
            daPatients = new SqlDataAdapter(cmdPatients);
            daPatients.FillSchema(dsLloydsPharmacy, SchemaType.Source, "Patient");

            // Set up dataAapter for prescriptions listbox and listview
            sqlPrescriptions = @"Select PrescriptionID, PrescriptionDate from Prescriptions join Patient on Prescriptions.PatientID = Patient.PatientID where PatientSurname = (select PatientSurname from Patient where PatientID = @PresID)";
            cmdPrescriptions = new SqlCommand(sqlPrescriptions, conn);
            cmdPrescriptions.Parameters.Add("@PresID", SqlDbType.VarChar);
            daPrescriptions = new SqlDataAdapter(cmdPrescriptions);
            daPrescriptions.FillSchema(dsLloydsPharmacy, SchemaType.Source, "Prescriptions");

            // Set up dataAapter for prescription details listview
            sqlPresDetails = @"Select * from PrescriptionDetails Where PrescriptionID = @PresID";
            cmdPresDetails = new SqlCommand(sqlPresDetails, conn);
            cmdPresDetails.Parameters.Add("@PresID", SqlDbType.VarChar);
            daPresDetails = new SqlDataAdapter(cmdPresDetails);
            daPresDetails.FillSchema(dsLloydsPharmacy, SchemaType.Source, "PrescriptionDetails");

            // Set up dataAdapter for stock ID for the combobox
            sqlStock = @"Select * from Stock";
            cmdStock = new SqlCommand(sqlStock, conn);
            cmdStock.Parameters.Add("@PresID", SqlDbType.VarChar);
            cmdBStock = new SqlCommandBuilder(daStock);
            daStock = new SqlDataAdapter(sqlStock, connStr);
            daStock.FillSchema(dsLloydsPharmacy, SchemaType.Source, "Stock");
            daStock.Fill(dsLloydsPharmacy, "Stock");

            cmbCurrentStockID.DataSource = dsLloydsPharmacy.Tables["Stock"];
            cmbCurrentStockID.ValueMember = "StockID";
            cmbCurrentStockID.DisplayMember = "StockID";

            // Set up for loop for navigation buttons
            for (int i = 0; i < 26; i++)
            {
                btns[i] = (Button)pnlButtons.Controls[i];
                btns[i].Text = "" + (char)(65 + i);
                btns[i].Enabled = false;
                btns[i].Click += new EventHandler(buttonLetters_Click);
                btns[i].BackColor = darkGreen;
                btns[i].ForeColor = lightGreen;
            }

            // Have patient appear whose surname's first letter starts with clicked letter button
            foreach (DataRow dr in dsLloydsPharmacy.Tables["Names"].Rows)
            {
                no = (int)dr["PatientSurname"].ToString()[0] - 65;
                btns[no].Enabled = true;
                btns[no].BackColor = Color.FromArgb(32, 115, 60);
                btns[no].ForeColor = Color.FromArgb(165, 203, 82);
            }

            // Set colours for buttons
            darkGreen = Color.FromArgb(32, 115, 60);
            lightGreen = Color.FromArgb(165, 203, 82);

            // Assign colours to buttons
            btnAddItem.ForeColor = darkGreen;
            btnAddItem.BackColor = lightGreen;
            btnUpdateItem.ForeColor = darkGreen;
            btnUpdateItem.BackColor = lightGreen;
            btnDeleteItem.ForeColor = darkGreen;
            btnDeleteItem.BackColor = lightGreen;

            pnlDelivRec.Enabled = false;
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            // Takes user back to Menu form
            frmMenu frmmenu = new frmMenu();
            frmmenu.Show();
            this.Hide();
        }

        private void lvwPresDetails_MouseClick(object sender, MouseEventArgs e)
        {
            // Shows details in comboboxes based on clicked row in PresDetails listview
            String stockID = lvwPresDetails.SelectedItems[0].SubItems[0].Text;
            String delivery = lvwPresDetails.SelectedItems[0].SubItems[1].Text;
            String recurringPres = lvwPresDetails.SelectedItems[0].SubItems[2].Text;

            pnlDelivRec.Enabled = true;

            cmbCurrentStockID.Text = stockID;
            cmbDelivery.Text = delivery;
            cmbRecPres.Text = recurringPres;
        }

        private void buttonLetters_Click(object sender, EventArgs e)
        {
            // Shows Patients in patient listbox based on letter clicked
            Button b = (Button)sender;
            // Get patient details for listbox - use selected button letter for parameter 
            String str = b.Text;

            // Empty dataset table Patients
            dsLloydsPharmacy.Tables["Patient"].Clear();

            fillListboxPatients(str);

            // Clear any previously selected Prescriptions by emptying the dataset tables
            dsLloydsPharmacy.Tables["Prescriptions"].Clear();

            ClearPatients();
            pnlDelivRec.Enabled = false;
        }

        private void fillListboxPatients(String str)
        {
            // Get all patients details for listbox - use wildcard for parameter 
            cmdPatients.Parameters["@Letter"].Value = str + "%";
            daPatients.Fill(dsLloydsPharmacy, "Patient");

            // Fill patients listbox
            lstPatients.DataSource = dsLloydsPharmacy.Tables["Patient"];
            lstPatients.DisplayMember = "PatientName";
            lstPatients.ValueMember = "PatientID";
        }

        private void fillListboxPrescriptions(String str)
        {
            // Get all prescription details for listbox - use wildcard for parameter 
            cmdPrescriptions.Parameters["@PresDetails"].Value = str + "%";
            daPrescriptions.Fill(dsLloydsPharmacy, "Prescriptions");

            // Fill prescriptions listbox
            lstPrescriptions.DataSource = dsLloydsPharmacy.Tables["Prescriptions"];
            lstPrescriptions.DisplayMember = "PrescriptionID";
            lstPrescriptions.ValueMember = "PrescriptionID";
        }

        private void ClearPatients()
        {
            // Clears Prescription details
            lstPatients.SelectedIndex = -1;
            cmbCurrentStockID.SelectedIndex = -1;
            cmbDelivery.SelectedIndex = -1;
            cmbRecPres.SelectedIndex = -1;
        }

        private void lstPatients_Click(object sender, EventArgs e)
        {
            // Shows Prescription IDs in Prescriptions listbox
            dsLloydsPharmacy.Tables["Prescriptions"].Clear();

            cmdPrescriptions.Parameters["@PresID"].Value = lstPatients.SelectedValue;

            daPrescriptions.Fill(dsLloydsPharmacy, "Prescriptions");

            lstPrescriptions.DataSource = dsLloydsPharmacy.Tables["Prescriptions"];
            lstPrescriptions.DisplayMember = "PrescriptionID";
            lstPrescriptions.ValueMember = "PrescriptionID";

            lstPrescriptions.SelectedIndex = -1;

            drPatients = dsLloydsPharmacy.Tables["Patient"].Rows.Find(lstPatients.SelectedValue);
        }

        private void lstPrescriptions_Click(object sender, EventArgs e)
        {
            // Gets prescription details linked to clicked prescription ID in listbox
            if (lstPrescriptions.Items.Count != 0)
            {
                lstPrescriptions.DataSource = dsLloydsPharmacy.Tables["Prescriptions"];

                cmdPresDetails.Parameters["@PresID"].Value = lstPrescriptions.SelectedValue;

                daPresDetails.Fill(dsLloydsPharmacy, "PrescriptionDetails");
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            // Adds Prescription table details to listview box
            bool ok = true;
            bool exits = false;

            if (lstPatients.SelectedIndex == -1)
                MessageBox.Show("Please select a Patient", "Patient");
            else if (lstPrescriptions.SelectedIndex == -1)
                MessageBox.Show("Please select a Prescription", "Prescription");
            else
            {
                foreach (ListViewItem item in lvwPrescriptions.Items)
                {
                    if (item.SubItems[2].Text == lstPrescriptions.Text)
                    {
                        MessageBox.Show("Stock ID already selected for this listview.", "Add Item");
                        exits = true;
                        break;
                    }
                }

                if (!exits)
                {
                    if (ok)
                    {
                        // fill listviews
                        foreach (DataRow dr in dsLloydsPharmacy.Tables["Prescriptions"].Rows)
                        {
                            if (dr["PrescriptionID"].ToString() == lstPrescriptions.Text)
                            {
                                ListViewItem item = new ListViewItem(dr["PrescriptionID"].ToString());

                                item.SubItems.Add(drPatients["PatientID"].ToString());
                                item.SubItems.Add(dr["PrescriptionDate"].ToString());
                                lvwPrescriptions.Items.Add(item);
                                break;
                            }
                        }
                        foreach (DataRow dr in dsLloydsPharmacy.Tables["PrescriptionDetails"].Rows)
                        {
                            if (dr["PrescriptionID"].ToString() == lstPrescriptions.Text)
                            {
                                ListViewItem item = new ListViewItem(dr["StockID"].ToString());

                                item.SubItems.Add(dr["Delivery"].ToString());
                                item.SubItems.Add(dr["RecurringPrescription"].ToString());
                                lvwPresDetails.Items.Add(item);
                                break;
                            }
                        }
                        foreach (ListViewItem item in lvwPrescriptions.Items)
                        {
                            if (item.SubItems[2].Text == lstPrescriptions.Text)
                            {
                                MessageBox.Show("Prescription ID already selected.", "Prescription");
                                break;
                            }
                        }
                        MessageBox.Show("Item has been inserted", "Add Item");
                    }
                }
            }
        }
        private void btnAddItem_MouseEnter(object sender, EventArgs e)
        {
            btnAddItem.ForeColor = lightGreen;
            btnAddItem.BackColor = darkGreen;
            btnAddItem.Text = "";
            btnAddItem.ImageIndex = 0;
        }
        private void btnAddItem_MouseLeave(object sender, EventArgs e)
        {
            btnAddItem.ForeColor = darkGreen;
            btnAddItem.BackColor = lightGreen;
            btnAddItem.Text = "Add Item";
            btnAddItem.ImageIndex = -1;
        }

        //Edits clicked details in Listview with new choices
        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            if (lvwPresDetails.SelectedItems.Count != 0)
            {
                var item = lvwPresDetails.SelectedItems[0];

                item.SubItems[0].Text = cmbCurrentStockID.SelectedItem.ToString();
                item.SubItems[1].Text = cmbDelivery.SelectedItem.ToString();
                item.SubItems[2].Text = cmbRecPres.SelectedItem.ToString();

                MessageBox.Show("Item has been Updated", "Update Item");
            }
            else
            {
                MessageBox.Show("Select a Stock ID from the listview", "Update Item");
            }
        }
        private void btnUpdateItem_MouseEnter(object sender, EventArgs e)
        {
            btnUpdateItem.ForeColor = lightGreen;
            btnUpdateItem.BackColor = darkGreen;
            btnUpdateItem.Text = "";
            btnUpdateItem.ImageIndex = 1;
        }
        private void btnUpdateItem_MouseLeave(object sender, EventArgs e)
        {
            btnUpdateItem.ForeColor = darkGreen;
            btnUpdateItem.BackColor = lightGreen;
            btnUpdateItem.Text = "Update Item";
            btnUpdateItem.ImageIndex = -1;
        }

        //Deletes clicked details from listview
        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this item?", "Delete Item", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (lvwPresDetails.SelectedItems.Count != 0)
                {
                    var item = lvwPresDetails.SelectedItems[0];
                    lvwPresDetails.Items.Remove(item);
                    MessageBox.Show("Item has been Deleted", "Delete Item");
                }
                else
                {
                    MessageBox.Show("Select a Stock ID from the listview", "Delete Item");
                }
            }
        }
        private void btnDeleteItem_MouseEnter(object sender, EventArgs e)
        {
            btnDeleteItem.ForeColor = lightGreen;
            btnDeleteItem.BackColor = darkGreen;
            btnDeleteItem.Text = "";
            btnDeleteItem.ImageIndex = 2;
        }
        private void btnDeleteItem_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteItem.ForeColor = darkGreen;
            btnDeleteItem.BackColor = lightGreen;
            btnDeleteItem.Text = "Delete Item";
            btnDeleteItem.ImageIndex = -1;
        }
    }
}
