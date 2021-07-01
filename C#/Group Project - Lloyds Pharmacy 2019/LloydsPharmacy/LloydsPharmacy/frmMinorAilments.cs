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
    public partial class frmMinorAilments : Form
    {
        // Sets new SQL functions to be used for Minor Ailments form
        SqlDataAdapter daMinorAilments, daMinorAilmentTypes;
        DataSet dsLloydsPharmacy = new DataSet();
        SqlCommandBuilder cmdBMinorAilments, cmdBMinorAilmentTypes;
        DataRow drMinorAilments;
        String connStr, sqlMinorAilments, sqlMinorAilmentTypes;

        int selectedTab = 0;
        bool minorAilmentSelected = false;
        String minorAilmentIDSelected = "";

        // Assigns new colours for Form
        Color darkGreen = new Color();
        Color lightGreen = new Color();

        public frmMinorAilments()
        {
            InitializeComponent();
        }

        private void frmMinorAilments_Load(object sender, EventArgs e)
        {
            // Sets new Connection String to connect to LloydsPharmacy database
            //connStr = @"Data Source = .; Initial Catalog = LloydsPharmacy; Integrated Security = true";
            connStr = @"Data Source = REDTOPS\SQLEXPRESS; Initial Catalog = LloydsPharmacy; Integrated Security = true";


            // Sets up dataAdapter for minor ailments datagridview
            sqlMinorAilments = @"select * from MinorAilments";
            cmdBMinorAilments = new SqlCommandBuilder(daMinorAilments);
            daMinorAilments = new SqlDataAdapter(sqlMinorAilments, connStr);
            daMinorAilments.FillSchema(dsLloydsPharmacy, SchemaType.Source, "MinorAilments");
            daMinorAilments.Fill(dsLloydsPharmacy, "MinorAilments");

            // Sets up dataAdapter for minorailment Types combo boxes
            sqlMinorAilmentTypes = @"select * from MinorAilmentTypes";
            cmdBMinorAilmentTypes = new SqlCommandBuilder(daMinorAilmentTypes);
            daMinorAilmentTypes = new SqlDataAdapter(sqlMinorAilmentTypes, connStr);
            daMinorAilmentTypes.FillSchema(dsLloydsPharmacy, SchemaType.Source, "MinorAilmentTypes");
            daMinorAilmentTypes.Fill(dsLloydsPharmacy, "MinorAilmentTypes");

            dgvMinAilments.DataSource = dsLloydsPharmacy.Tables["MinorAilments"];
            // Resize the DataGridView columns to fit the newly loaded content.
            dgvMinAilments.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            // Set colours for buttons
            darkGreen = Color.FromArgb(32, 115, 60);
            lightGreen = Color.FromArgb(165, 203, 82);

            tabMinorAilments.SelectedIndex = 1;
            tabMinorAilments.SelectedIndex = 0;

            // Sets Add MA Type ID combo box to take type ID from MinorAilmentTypes table
            cmbAddTypeID.DataSource = dsLloydsPharmacy.Tables["MinorAilmentTypes"];
            cmbAddTypeID.ValueMember = "MinorAilmentsTypeID";
            cmbAddTypeID.DisplayMember = "MinorAilmentsTypeDesc";
            // Sets Edit MA Type ID combo box to take type ID from MinorAilmentTypes table
            cmbEditTypeID.DataSource = dsLloydsPharmacy.Tables["MinorAilmentTypes"];
            cmbEditTypeID.ValueMember = "MinorAilmentsTypeID";
            cmbEditTypeID.DisplayMember = "MinorAilmentsTypeDesc";

            // Assign colours to buttons
            btnAddMA.ForeColor = darkGreen;
            btnAddMA.BackColor = lightGreen;
            btnCancelAddMA.ForeColor = darkGreen;
            btnCancelAddMA.BackColor = lightGreen;
            btnEditMA.ForeColor = darkGreen;
            btnEditMA.BackColor = lightGreen;
            btnDelMA.ForeColor = darkGreen;
            btnDelMA.BackColor = lightGreen;
            btnCancelEditMA.ForeColor = darkGreen;
            btnCancelEditMA.BackColor = lightGreen;
            btnOrderAilForm.ForeColor = darkGreen;
            btnOrderAilForm.BackColor = lightGreen;

            // Sets MinorAilments CrystalReport to report source in report tab
            frmMinorAilments frmMinorAilments = new frmMinorAilments();
            //crvMAilment.ReportSource = new MinorAilments();
        }

        private void frmMinorAilments_Shown(object sender, EventArgs e)
        {
            tabMinorAilments.TabPages[0].CausesValidation = true;
            tabMinorAilments.TabPages[0].Validating += new CancelEventHandler(AddTabValidate);

            tabMinorAilments.TabPages[2].CausesValidation = true;
            tabMinorAilments.TabPages[2].Validating += new CancelEventHandler(EditTabValidate);
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
            txtAddAilDesc.Clear();
            cmbAddTypeID.SelectedIndex = -1;
        }
        // Clears and disables textboxes in Edit tab
        void clearEditForm()
        {
            lblEditMinAID.Text = "-";
            txtEditAilDesc.Clear();
            cmbEditTypeID.SelectedIndex = -1;

            txtEditAilDesc.Enabled = false;
            cmbEditTypeID.Enabled = false;
            btnDelMA.Enabled = false;
            btnCancelEditMA.Enabled = false;

            btnEditMA.Text = "Edit";
        }

        // Takes most recent MinorAIlment ID and adds by 1 to make new ID
        private void getNumber(int noRows)
        {
            drMinorAilments = dsLloydsPharmacy.Tables["MinorAilments"].Rows[noRows - 1];
            lblAddMinAID.Text = "MIA" + (Convert.ToInt32(drMinorAilments["MinorAilmentID"].ToString().Substring(3, 4)) + 1).ToString();
        }

        // Allows user to navigate different tab pages in minorAilments tab control
        private void tabMinorAilments_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTab = tabMinorAilments.SelectedIndex;

            tabMinorAilments.TabPages[tabMinorAilments.SelectedIndex].Focus();
            tabMinorAilments.TabPages[tabMinorAilments.SelectedIndex].CausesValidation = true;

            if (dgvMinAilments.SelectedRows.Count == 0 && tabMinorAilments.SelectedIndex == 2)
                tabMinorAilments.TabPages[tabMinorAilments.SelectedIndex].CausesValidation = true;
            else
            {
                switch (tabMinorAilments.SelectedIndex)
                {
                    case 0: // Display tab Selected
                        {
                            dsLloydsPharmacy.Tables["MinorAilments"].Clear();
                            daMinorAilments.Fill(dsLloydsPharmacy, "MinorAilments");
                            clearEditForm();
                            break;
                        }

                    case 1: // Add tab Selected
                        {
                            int noRows = dsLloydsPharmacy.Tables["MinorAilments"].Rows.Count;
                            if (noRows == 0)
                                lblAddMinAID.Text = "MIA1000";
                            else
                            {
                                getNumber(noRows); // Goes to last row on cust table and adds 1
                            }
                            errProMinorAilments.Clear();
                            clearAddForm();
                            clearEditForm();
                            break;
                        }

                    case 2: // Edit tab Selected - Displays patient details from selected Datagrid row
                        {
                            if (minorAilmentIDSelected == "")
                            {
                                tabMinorAilments.SelectedIndex = 0;
                                break;
                            }
                            else
                            {
                                lblEditMinAID.Text = minorAilmentIDSelected.ToString();
                                drMinorAilments = dsLloydsPharmacy.Tables["MinorAilments"].Rows.Find(lblEditMinAID.Text);

                                lblEditMinAID.Text = drMinorAilments["MinorAilmentID"].ToString();
                                txtEditAilDesc.Text = drMinorAilments["MinorAilmentDesc"].ToString();
                                cmbEditTypeID.Text = drMinorAilments["MinorAilmentsTypeID"].ToString();
                                errProMinorAilments.Clear();
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
            if (dgvMinAilments.SelectedRows.Count == 0)
            {
                minorAilmentSelected = false;
                minorAilmentIDSelected = "";
            }
            else if (dgvMinAilments.SelectedRows.Count == 1)
            {
                minorAilmentSelected = true;
                minorAilmentIDSelected = dgvMinAilments.SelectedRows[0].Cells[0].Value.ToString();
            }
        }
        // Validates Edit tab
        void EditTabValidate(object sender, CancelEventArgs e)
        {
            if (minorAilmentSelected == false && dgvMinAilments.SelectedRows.Count == 0)
            {
                minorAilmentSelected = false;
                minorAilmentIDSelected = "";
            }
            else if (dgvMinAilments.SelectedRows.Count == 1)
            {
                minorAilmentSelected = true;
                minorAilmentIDSelected = dgvMinAilments.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        // MinorAilment SearchBar - Filters rows when user types in Ailment Description
        private void txtSearchAilment_TextChanged(object sender, EventArgs e)
        {
            (dgvMinAilments.DataSource as DataTable).DefaultView.RowFilter = string.Format("MinorAilmentDesc LIKE '%{0}%'", txtSearchAilment.Text);
        }

        // Add Minor Ailment Button - Adds new row to MinorAilment DataGridView
        private void btnAddMA_Click(object sender, EventArgs e)
        {
            MyMinorAilments myMinorAilments = new MyMinorAilments();
            bool ok = true;
            errProMinorAilments.Clear();
            //try passes to 'MyMinorAilments' class, catch gets the error for invalid data
            try
            {
                myMinorAilments.AilmentID = lblAddMinAID.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errProMinorAilments.SetError(lblAddMinAID, MyEx.toString());
            }
            try
            {
                myMinorAilments.AilmentDesc = txtAddAilDesc.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errProMinorAilments.SetError(txtAddAilDesc, MyEx.toString());
            }
            try
            {
                myMinorAilments.AilmentTypeID = cmbAddTypeID.SelectedValue.ToString();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errProMinorAilments.SetError(cmbAddTypeID, MyEx.toString());
            }
            //try adds new minor ailment to Datagridview, catch shows error message
            try
            {
                if (ok)
                {
                    drMinorAilments = dsLloydsPharmacy.Tables["MinorAilments"].NewRow();

                    drMinorAilments["MinorAilmentID"] = myMinorAilments.AilmentID;
                    drMinorAilments["MinorAilmentDesc"] = myMinorAilments.AilmentDesc;
                    drMinorAilments["MinorAilmentsTypeID"] = myMinorAilments.AilmentTypeID;

                    dsLloydsPharmacy.Tables["MinorAilments"].Rows.Add(drMinorAilments);
                    daMinorAilments.Update(dsLloydsPharmacy, "MinorAilments");

                    MessageBox.Show("Minor Ailment has been inserted.", "Add Ailment");

                    if (MessageBox.Show("Do you wish to add another ailment?", "Add Ailment", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        clearAddForm();
                        getNumber(dsLloydsPharmacy.Tables["MinorAilments"].Rows.Count);
                    }
                    else
                        tabMinorAilments.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }
        // Displays icon when mouse hovers over button
        private void btnAddMA_MouseEnter(object sender, EventArgs e)
        {
            btnAddMA.ForeColor = lightGreen;
            btnAddMA.BackColor = darkGreen;
            btnAddMA.Text = "";
            btnAddMA.ImageIndex = 5;
        }
        // Button shows text and icon is cleared
        private void btnAddMA_MouseLeave(object sender, EventArgs e)
        {
            btnAddMA.ForeColor = darkGreen;
            btnAddMA.BackColor = lightGreen;
            btnAddMA.Text = "Add";
            btnAddMA.ImageIndex = -1;
        }

        //Cancel Add Minor Ailment Button - Cancels new ailment addition
        private void btnCancelAddMA_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel the addition of Ailment: " + lblAddMinAID.Text + "?", "Add Ailment", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                tabMinorAilments.SelectedIndex = 0;
        }
        // Displays icon when mouse hovers over button
        private void btnCancelAddMA_MouseEnter(object sender, EventArgs e)
        {
            btnCancelAddMA.ForeColor = lightGreen;
            btnCancelAddMA.BackColor = darkGreen;
            btnCancelAddMA.Text = "";
            btnCancelAddMA.ImageIndex = 8;
        }
        // Button shows text and icon is cleared
        private void btnCancelAddMA_MouseLeave(object sender, EventArgs e)
        {
            btnCancelAddMA.ForeColor = darkGreen;
            btnCancelAddMA.BackColor = lightGreen;
            btnCancelAddMA.Text = "Cancel";
            btnCancelAddMA.ImageIndex = -1;
        }

        //Edit Minor Ailment Button - Lets user edit existing ailment details
        private void btnEditMA_Click(object sender, EventArgs e)
        {
            if (btnEditMA.Text == "Edit")
            {
                txtEditAilDesc.Enabled = true;
                cmbEditTypeID.Enabled = true;


                btnDelMA.Enabled = true;
                btnCancelEditMA.Enabled = true;

                btnEditMA.Text = "Save";
            }
            else
            {
                MyMinorAilments myMinorAilments = new MyMinorAilments();
                bool ok = true;
                errProMinorAilments.Clear();
                //try passes to 'MyMinorAilments' class and catch gets the error
                try
                {
                    myMinorAilments.AilmentID = lblEditMinAID.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errProMinorAilments.SetError(lblEditMinAID, MyEx.toString());
                }
                try
                {
                    myMinorAilments.AilmentDesc = txtEditAilDesc.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errProMinorAilments.SetError(txtEditAilDesc, MyEx.toString());
                }
                try
                {
                    myMinorAilments.AilmentTypeID = cmbEditTypeID.SelectedValue.ToString();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errProMinorAilments.SetError(cmbEditTypeID, MyEx.toString());
                }
                //try changes minor ailment in Datagridview, catch shows error message
                try
                {
                    if (ok)
                    {
                        drMinorAilments.BeginEdit();

                        drMinorAilments["MinorAilmentID"] = myMinorAilments.AilmentID;
                        drMinorAilments["MinorAilmentDesc"] = myMinorAilments.AilmentDesc;
                        drMinorAilments["MinorAilmentsTypeID"] = myMinorAilments.AilmentTypeID;

                        drMinorAilments.EndEdit();
                        daMinorAilments.Update(dsLloydsPharmacy, "MinorAilments");

                        MessageBox.Show("Minor Ailment Details have been Changed", "Edit Ailments");

                        tabMinorAilments.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                }
            }
        }
        // Displays icon when mouse hovers over button
        private void btnEditMA_MouseEnter(object sender, EventArgs e)
        {
            btnEditMA.ForeColor = lightGreen;
            btnEditMA.BackColor = darkGreen;
            btnEditMA.ImageIndex = 6;
        }
        // Button shows text and icon is cleared
        private void btnEditMA_MouseLeave(object sender, EventArgs e)
        {
            btnEditMA.ForeColor = darkGreen;
            btnEditMA.BackColor = lightGreen;
            btnEditMA.ImageIndex = -1;
        }

        //Delete Minor Ailment Button - Deletes selected ailment from datagridview
        private void btnDelMA_Click(object sender, EventArgs e)
        {
            drMinorAilments = dsLloydsPharmacy.Tables["MinorAilments"].Rows.Find(dgvMinAilments.SelectedRows[0].Cells[0].Value);

            string tempName = drMinorAilments["MinorAilmentID"].ToString();
            // Asks user if they want to delete ailment
            if (MessageBox.Show("Are you sure you want to delete details for " + tempName + "?", "Delete Ailment", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                drMinorAilments.Delete();
                daMinorAilments.Update(dsLloydsPharmacy, "MinorAilments");
                MessageBox.Show("Minor Ailment has been deleted.", "Delete Ailment");
                tabMinorAilments.SelectedIndex = 0;
            }
        }
        // Displays icon when mouse hovers over button
        private void btnDelMA_MouseEnter(object sender, EventArgs e)
        {
            btnDelMA.ForeColor = lightGreen;
            btnDelMA.BackColor = darkGreen;
            btnDelMA.Text = "";
            btnDelMA.ImageIndex = 7;
        }
        // Button shows text and icon is cleared
        private void btnDelMA_MouseLeave(object sender, EventArgs e)
        {
            btnDelMA.ForeColor = darkGreen;
            btnDelMA.BackColor = lightGreen;
            btnDelMA.Text = "Delete";
            btnDelMA.ImageIndex = -1;
        }

        //Cancel Edit Minor Ailment Button - Cancels edit for existing ailment
        private void btnCancelEditMA_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel the edit of " + lblEditMinAID.Text + "?", "Edit Ailment", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                txtEditAilDesc.Enabled = false;
                cmbEditTypeID.Enabled = false;
                btnDelMA.Enabled = false;

                btnEditMA.Text = "Edit";
                tabMinorAilments.SelectedIndex = 0;
            }
            else
            {
                tabMinorAilments.SelectedIndex = 2;
            }
        }
        // Displays icon when mouse hovers over button
        private void btnCancelEditMA_MouseEnter(object sender, EventArgs e)
        {
            btnCancelEditMA.ForeColor = lightGreen;
            btnCancelEditMA.BackColor = darkGreen;
            btnCancelEditMA.Text = "";
            btnCancelEditMA.ImageIndex = 8;
        }
        // Button shows text and icon is cleared
        private void btnCancelEditMA_MouseLeave(object sender, EventArgs e)
        {
            btnCancelEditMA.ForeColor = darkGreen;
            btnCancelEditMA.BackColor = lightGreen;
            btnCancelEditMA.Text = "Cancel";
            btnCancelEditMA.ImageIndex = -1;
        }

        // Order Ailment Button - Takes user to Order Ailments form
        private void btnOrderAilForm_Click(object sender, EventArgs e)
        {
            frmOrderAilments frmorderailments = new frmOrderAilments();
            frmorderailments.Show();
            this.Hide();
        }
        // Displays icon when mouse hovers over button
        private void btnOrderAilForm_MouseEnter(object sender, EventArgs e)
        {
            btnOrderAilForm.ForeColor = lightGreen;
            btnOrderAilForm.BackColor = darkGreen;
            btnOrderAilForm.Text = "";
            btnOrderAilForm.ImageIndex = 9;
        }
        // Button shows text and icon is cleared
        private void btnOrderAilForm_MouseLeave(object sender, EventArgs e)
        {
            btnOrderAilForm.ForeColor = darkGreen;
            btnOrderAilForm.BackColor = lightGreen;
            btnOrderAilForm.Text = "Order Ailments";
            btnOrderAilForm.ImageIndex = -1;
        }
    }
}
