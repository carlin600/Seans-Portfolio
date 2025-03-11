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
    public partial class frmPatients : Form
    {
        // Sets new SQL functions to be used for Patients form
        SqlDataAdapter daPatient;
        DataSet dsLloydsPharmacy = new DataSet();
        SqlCommandBuilder cmdBPatient;
        DataRow drPatient;
        String connStr, sqlPatient;

        int selectedTab = 0;
        bool patientSelected = false;
        String patientIDSelected = "";

        // Assigns new colours for Form
        Color darkGreen = new Color();
        Color lightGreen = new Color();

        public frmPatients()
        {
            InitializeComponent();
        }

        private void frmPatients_Load(object sender, EventArgs e)
        {
            // Sets new Connection String to connect to LloydsPharmacy database
          //  connStr = @"Data Source = .; Initial Catalog = LloydsPharmacy; Integrated Security = true";
            connStr = @"Data Source = REDTOPS\SQLEXPRESS; Initial Catalog = LloydsPharmacy; Integrated Security = true";

            // Sets up dataAdapter for patients datagridview
            sqlPatient = @"select * from Patient";
            daPatient = new SqlDataAdapter(sqlPatient, connStr);
            cmdBPatient = new SqlCommandBuilder(daPatient);
            daPatient.FillSchema(dsLloydsPharmacy, SchemaType.Source, "Patients");
            daPatient.Fill(dsLloydsPharmacy, "Patients");

            dgvPatients.DataSource = dsLloydsPharmacy.Tables["Patients"];
            // Resize the DataGridView columns to fit the newly loaded content.
            dgvPatients.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            // Set colours for buttons
            darkGreen = Color.FromArgb(32, 115, 60);
            lightGreen = Color.FromArgb(165, 203, 82);

            tabPatients.SelectedIndex = 1;
            tabPatients.SelectedIndex = 0;

            // Assign colours to buttons
            btnAddPat.ForeColor = darkGreen;
            btnAddPat.BackColor = lightGreen;
            btnCancelAddPat.ForeColor = darkGreen;
            btnCancelAddPat.BackColor = lightGreen;
            btnEditPat.ForeColor = darkGreen;
            btnEditPat.BackColor = lightGreen;
            btnDelPat.ForeColor = darkGreen;
            btnDelPat.BackColor = lightGreen;
            btnCancelEditPat.ForeColor = darkGreen;
            btnCancelEditPat.BackColor = lightGreen;

            // Sets Patient CrystalReport to report source in report tab
            frmPatients patients = new frmPatients();
            //crystalReportViewer1.ReportSource = patient;
        }

        private void frmPatients_Shown(object sender, EventArgs e)
        {
            tabPatients.TabPages[0].CausesValidation = true;
            tabPatients.TabPages[0].Validating += new CancelEventHandler(AddTabValidate);

            tabPatients.TabPages[2].CausesValidation = true;
            tabPatients.TabPages[2].Validating += new CancelEventHandler(EditTabValidate);
        }

        // Takes user back to Menu form
        private void pbLogo_Click(object sender, EventArgs e)
        {
            frmMenu frmmenu = new frmMenu();
            frmmenu.Show();
            this.Hide();
        }
        // Clears textboxes in Add tab
        void clearAddForm()
        {
            txtAddForename.Clear();
            txtAddSurname.Clear();
            txtAddTelNo.Clear();
            txtAddEmail.Clear();
            txtAddStreet.Clear();
            txtAddTown.Clear();
            txtAddCounty.Clear();
            txtAddPostcode.Clear();
        }
        // Clears and disables textboxes in Edit tab
        void clearEditForm()
        {
            lblEditPatID.Text = "-";
            txtEditForename.Clear();
            txtEditSurname.Clear();
            txtEditTelNo.Clear();
            txtEditEmail.Clear();
            txtEditStreet.Clear();
            txtEditTown.Clear();
            txtEditCounty.Clear();
            txtEditPostcode.Clear();

            txtEditForename.Enabled = false;
            txtEditSurname.Enabled = false;
            txtEditTelNo.Enabled = false;
            txtEditEmail.Enabled = false;
            txtEditStreet.Enabled = false;
            txtEditTown.Enabled = false;
            txtEditCounty.Enabled = false;
            txtEditPostcode.Enabled = false;
            btnDelPat.Enabled = false;
            btnCancelEditPat.Enabled = false;

            btnEditPat.Text = "Edit";
        }

        // Takes most recent Patient ID and adds by 1 to make new ID
        private void getNumber(int noRows)
        {
            drPatient = dsLloydsPharmacy.Tables["Patients"].Rows[noRows - 1];
            lblAddPatID.Text = "PAT" + (Convert.ToInt32(drPatient["PatientID"].ToString().Substring(3, 4)) + 1).ToString();
        }

        // Allows user to navigate different tab pages in patients tab control
        private void tabPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTab = tabPatients.SelectedIndex;

            tabPatients.TabPages[tabPatients.SelectedIndex].Focus();
            tabPatients.TabPages[tabPatients.SelectedIndex].CausesValidation = true;

            if (dgvPatients.SelectedRows.Count == 0 && tabPatients.SelectedIndex == 2)
                tabPatients.TabPages[tabPatients.SelectedIndex].CausesValidation = true;
            else
            {
                switch (tabPatients.SelectedIndex)
                {
                    case 0: // Display tab Selected
                        {
                            dsLloydsPharmacy.Tables["Patients"].Clear();
                            daPatient.Fill(dsLloydsPharmacy, "Patients");
                            clearEditForm();
                            clearEditForm();
                            break;
                        }

                    case 1: // Add tab Selected
                        {
                            int noRows = dsLloydsPharmacy.Tables["Patients"].Rows.Count;
                            if (noRows == 0)
                                lblAddPatID.Text = "PAT1000";
                            else
                            {
                                getNumber(noRows);
                            }
                            errProPatients.Clear();
                            clearAddForm();
                            clearEditForm();
                            break;
                        }

                    case 2: // Edit tab Selected - Displays patient details from selected Datagrid row
                        {
                            if (patientIDSelected == "")
                            {
                                tabPatients.SelectedIndex = 0;
                                break;
                            }
                            else
                            {
                                lblEditPatID.Text = patientIDSelected.ToString();
                                drPatient = dsLloydsPharmacy.Tables["Patients"].Rows.Find(lblEditPatID.Text);

                                lblEditPatID.Text = drPatient["PatientID"].ToString();
                                txtEditForename.Text = drPatient["PatientForename"].ToString();
                                txtEditSurname.Text = drPatient["PatientSurname"].ToString();
                                txtEditTelNo.Text = drPatient["PatientTelNo"].ToString();
                                txtEditEmail.Text = drPatient["PatientEmail"].ToString();
                                txtEditStreet.Text = drPatient["PatientStreet"].ToString();
                                txtEditTown.Text = drPatient["PatientTown"].ToString();
                                txtEditCounty.Text = drPatient["PatientCounty"].ToString();
                                txtEditPostcode.Text = drPatient["PatientPostcode"].ToString();
                                errProPatients.Clear();
                                break;
                            }
                        }

                    case 3: // Report tab Selected
                        {
                            clearEditForm();
                            break;
                        }
                }
            }
        }

        // Validates Add tab
        void AddTabValidate(object sender, CancelEventArgs e)
        {
            if (dgvPatients.SelectedRows.Count == 0)
            {
                patientSelected = false;
                patientIDSelected = "";
            }
            else if (dgvPatients.SelectedRows.Count == 1)
            {
                patientSelected = true;
                patientIDSelected = dgvPatients.SelectedRows[0].Cells[0].Value.ToString();
            }
        }
        // Validates Edit tab
        void EditTabValidate(object sender, CancelEventArgs e)
        {
            if (patientSelected == false && dgvPatients.SelectedRows.Count == 0)
            {
                patientSelected = false;
                patientIDSelected = "";
            }
            else if (dgvPatients.SelectedRows.Count == 1)
            {
                patientSelected = true;
                patientIDSelected = dgvPatients.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        // Patient SearchBar - Filters rows when user types in Patient name
        private void txtSearchPatient_TextChanged(object sender, EventArgs e)
        {
            (dgvPatients.DataSource as DataTable).DefaultView.RowFilter = string.Format("PatientForename LIKE '%{0}%'", txtSearchPatient.Text);
        }

        // Add Patient Button - Adds new row to Patient DataGridView
        private void btnAddPat_Click(object sender, EventArgs e)
        {
            MyPatients myPatients = new MyPatients();
            bool ok = true;
            errProPatients.Clear();
            // try passes to 'MyPatient' class, catch gets the error for invalid data
            try
            {
                myPatients.PatientID = lblAddPatID.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errProPatients.SetError(lblAddPatID, MyEx.toString());
            }
            try
            {
                myPatients.Forename = txtAddForename.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errProPatients.SetError(txtAddForename, MyEx.toString());
            }
            try
            {
                myPatients.Surname = txtAddSurname.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errProPatients.SetError(txtAddSurname, MyEx.toString());
            }
            try
            {
                myPatients.TelNo = txtAddTelNo.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errProPatients.SetError(txtAddTelNo, MyEx.toString());
            }
            try
            {
                myPatients.Email = txtAddEmail.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errProPatients.SetError(txtAddEmail, MyEx.toString());
            }
            try
            {
                myPatients.Street = txtAddStreet.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errProPatients.SetError(txtAddStreet, MyEx.toString());
            }
            try
            {
                myPatients.Town = txtAddTown.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errProPatients.SetError(txtAddTown, MyEx.toString());
            }
            try
            {
                myPatients.County = txtAddCounty.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errProPatients.SetError(txtAddCounty, MyEx.toString());
            }
            try
            {
                myPatients.Postcode = txtAddPostcode.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errProPatients.SetError(txtAddPostcode, MyEx.toString());
            }
            // try adds new patient to Datagridview, catch shows error message
            try
            {
                if (ok)
                {
                    drPatient = dsLloydsPharmacy.Tables["Patients"].NewRow();

                    drPatient["PatientID"] = myPatients.PatientID;
                    drPatient["PatientForename"] = myPatients.Forename;
                    drPatient["PatientSurname"] = myPatients.Surname;
                    drPatient["PatientTelNo"] = myPatients.TelNo;
                    drPatient["PatientEmail"] = myPatients.Email;
                    drPatient["PatientStreet"] = myPatients.Street;
                    drPatient["PatientTown"] = myPatients.Town;
                    drPatient["PatientCounty"] = myPatients.County;
                    drPatient["PatientPostcode"] = myPatients.Postcode;

                    dsLloydsPharmacy.Tables["Patients"].Rows.Add(drPatient);
                    daPatient.Update(dsLloydsPharmacy, "Patients");

                    MessageBox.Show("Patient has been inserted.", "Add Patient");

                    if (MessageBox.Show("Do you wish to add another patient?", "Add Patient", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        clearAddForm();
                        getNumber(dsLloydsPharmacy.Tables["Patients"].Rows.Count);
                    }
                    else
                        tabPatients.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }
        // Displays icon when mouse hovers over button
        private void btnAddPat_MouseEnter(object sender, EventArgs e)
        {
            btnAddPat.ForeColor = lightGreen;
            btnAddPat.BackColor = darkGreen;
            btnAddPat.Text = "";
            btnAddPat.ImageIndex = 6;
        }
        // Button shows text and icon is cleared
        private void btnAddPat_MouseLeave(object sender, EventArgs e)
        {
            btnAddPat.ForeColor = darkGreen;
            btnAddPat.BackColor = lightGreen;
            btnAddPat.Text = "Add";
            btnAddPat.ImageIndex = -1;
        }

        // Cancel Add Patient Button - Cancels new patient addition
        private void btnCancelAddPat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel the addition of " + lblAddPatID.Text + "?", "Add Patient", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                tabPatients.SelectedIndex = 0;
        }
        // Displays icon when mouse hovers over button
        private void btnCancelAddPat_MouseEnter(object sender, EventArgs e)
        {
            btnCancelAddPat.ForeColor = lightGreen;
            btnCancelAddPat.BackColor = darkGreen;
            btnCancelAddPat.Text = "";
            btnCancelAddPat.ImageIndex = 9;
        }
        // Button shows text and icon is cleared
        private void btnCancelAddPat_MouseLeave(object sender, EventArgs e)
        {
            btnCancelAddPat.ForeColor = darkGreen;
            btnCancelAddPat.BackColor = lightGreen;
            btnCancelAddPat.Text = "Cancel";
            btnCancelAddPat.ImageIndex = -1;
        }

        // Edit Patient Button - Lets user edit existing patient details
        private void btnEditPat_Click(object sender, EventArgs e)
        {
            // Enables textboxes to allow editing - changes "Edit" button to "Save" button
            if (btnEditPat.Text == "Edit")
            {
                txtEditForename.Enabled = true;
                txtEditSurname.Enabled = true;
                txtEditTelNo.Enabled = true;
                txtEditEmail.Enabled = true;
                txtEditStreet.Enabled = true;
                txtEditTown.Enabled = true;
                txtEditCounty.Enabled = true;
                txtEditPostcode.Enabled = true;
                btnDelPat.Enabled = true;
                btnCancelEditPat.Enabled = true;

                btnEditPat.Text = "Save";
            }
            else
            {
                MyPatients myPatients = new MyPatients();
                bool ok = true;
                errProPatients.Clear();
                // try passes to 'MyPatient' class, catch gets the error for invalid data
                try
                {
                    myPatients.PatientID = lblEditPatID.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errProPatients.SetError(lblEditPatID, MyEx.toString());
                }
                try
                {
                    myPatients.Forename = txtEditForename.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errProPatients.SetError(txtEditForename, MyEx.toString());
                }
                try
                {
                    myPatients.Surname = txtEditSurname.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errProPatients.SetError(txtEditSurname, MyEx.toString());
                }
                try
                {
                    myPatients.TelNo = txtEditTelNo.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errProPatients.SetError(txtEditTelNo, MyEx.toString());
                }
                try
                {
                    myPatients.Email = txtEditEmail.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errProPatients.SetError(txtEditEmail, MyEx.toString());
                }
                try
                {
                    myPatients.Street = txtEditStreet.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errProPatients.SetError(txtEditStreet, MyEx.toString());
                }
                try
                {
                    myPatients.Town = txtEditTown.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errProPatients.SetError(txtEditTown, MyEx.toString());
                }
                try
                {
                    myPatients.County = txtEditCounty.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errProPatients.SetError(txtEditCounty, MyEx.toString());
                }
                try
                {
                    myPatients.Postcode = txtEditPostcode.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errProPatients.SetError(txtEditPostcode, MyEx.toString());
                }
                // try changes patient details in Datagridview, catch shows error message
                try
                {
                    if (ok)
                    {
                        drPatient.BeginEdit();

                        drPatient["PatientID"] = myPatients.PatientID;
                        drPatient["PatientForename"] = myPatients.Forename;
                        drPatient["PatientSurname"] = myPatients.Surname;
                        drPatient["PatientTelNo"] = myPatients.TelNo;
                        drPatient["PatientEmail"] = myPatients.Email;
                        drPatient["PatientStreet"] = myPatients.Street;
                        drPatient["PatientTown"] = myPatients.Town;
                        drPatient["PatientCounty"] = myPatients.County;
                        drPatient["PatientPostcode"] = myPatients.Postcode;

                        drPatient.EndEdit();
                        daPatient.Update(dsLloydsPharmacy, "Patients");

                        MessageBox.Show("Patient Details have been Changed", "Edit Patient");

                        tabPatients.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                }
            }
        }
        // Displays icon when mouse hovers over button
        private void btnEditPat_MouseEnter(object sender, EventArgs e)
        {
            btnEditPat.ForeColor = lightGreen;
            btnEditPat.BackColor = darkGreen;
            btnEditPat.ImageIndex = 7;
        }
        // Button shows text and icon is cleared
        private void btnEditPat_MouseLeave(object sender, EventArgs e)
        {
            btnEditPat.ForeColor = darkGreen;
            btnEditPat.BackColor = lightGreen;
            btnEditPat.ImageIndex = -1;
        }

        // Delete Patient Button - Deletes selected patient from datagridview
        private void btnDelPat_Click(object sender, EventArgs e)
        {
            drPatient = dsLloydsPharmacy.Tables["Patients"].Rows.Find(dgvPatients.SelectedRows[0].Cells[0].Value);

            string tempName = drPatient["PatientID"].ToString();
            // Asks user if they want to delete patient
            if (MessageBox.Show("Are you sure you want to delete details for " + tempName + "?", "Delete Patient", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                drPatient.Delete();
                daPatient.Update(dsLloydsPharmacy, "Patients");
                MessageBox.Show("Patient has been deleted.", "Delete Patient");
                tabPatients.SelectedIndex = 0;
            }
        }
        // Displays icon when mouse hovers over button
        private void btnDelPat_MouseEnter(object sender, EventArgs e)
        {
            btnDelPat.ForeColor = lightGreen;
            btnDelPat.BackColor = darkGreen;
            btnDelPat.Text = "";
            btnDelPat.ImageIndex = 8;
        }
        // Button shows text and icon is cleared
        private void btnDelPat_MouseLeave(object sender, EventArgs e)
        {
            btnDelPat.ForeColor = darkGreen;
            btnDelPat.BackColor = lightGreen;
            btnDelPat.Text = "Delete";
            btnDelPat.ImageIndex = -1;
        }

        // Cancel Edit Patient Button - Cancels edit for existing patient
        private void btnCancelEditPat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel the edit of " + lblEditPatID.Text + "?", "Edit Patient", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                txtEditForename.Enabled = false;
                txtEditSurname.Enabled = false;
                txtEditTelNo.Enabled = false;
                txtEditEmail.Enabled = false;
                txtEditStreet.Enabled = false;
                txtEditTown.Enabled = false;
                txtEditCounty.Enabled = false;
                txtEditPostcode.Enabled = false;

                btnEditPat.Text = "Edit";
                tabPatients.SelectedIndex = 0;
            }
            else
            {
                tabPatients.SelectedIndex = 2;
            }
        }
        // Displays icon when mouse hovers over button
        private void btnCancelEditPat_MouseEnter(object sender, EventArgs e)
        {
            btnCancelEditPat.ForeColor = lightGreen;
            btnCancelEditPat.BackColor = darkGreen;
            btnCancelEditPat.Text = "";
            btnCancelEditPat.ImageIndex = 9;
        }

    

        // Button shows text and icon is cleared
        private void btnCancelEditPat_MouseLeave(object sender, EventArgs e)
        {
            btnCancelEditPat.ForeColor = darkGreen;
            btnCancelEditPat.BackColor = lightGreen;
            btnCancelEditPat.Text = "Cancel";
            btnCancelEditPat.ImageIndex = -1;
        }
    }
}
