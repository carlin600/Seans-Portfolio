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
    public partial class frmStaff : Form
    {
        SqlDataAdapter daStaff;
        DataSet dsLloydsPharmacy = new DataSet();
        SqlCommandBuilder cmdBStaff;
        DataRow drStaff;
        String connStr, sqlStaff;
        int selectedTab = 0;
        bool staffSelected = false;
        int staffNoSelected = 0;

        public frmStaff()
        {
            InitializeComponent();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            frmMenu frmmenu = new frmMenu();
            frmmenu.Show();
            this.Hide();
        }

        private void getNumber(int noRows)
        {
            drStaff = dsLloydsPharmacy.Tables["Staff"].Rows[noRows - 1];
            String lastId = drStaff["StaffID"].ToString();

            int lastNum = Int32.Parse(lastId.Substring(1, lastId.Length - 1));
            lastNum++;
            //     lblAddAddStaffID.Text= 
            //     (int.Parse(drStaff["StaffID"].ToString()) + 1).ToString();           
            lblAddAddStaffID.Text = "S" + lastNum;

        }

        private void btnSAddAdd_Click(object sender, EventArgs e)
        {
            MyStaff myStaff = new MyStaff();
            bool ok = true;
            errP.Clear();

            try
            {
                myStaff.StaffNo = lblAddAddStaffID.Text.Trim();
                //   Convert.ToInt32(lblAddAddStaffID.Text.Trim()); // pass to staff class to check
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(lblAddAddStaffID, MyEx.toString());
            }
            try
            {
                myStaff.StaffTitle = cmbAddStaffTitle.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(cmbAddStaffTitle, MyEx.toString());
            }
            try
            {
                myStaff.StaffForename = txtAddSForename.Text.Trim();
            }

            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddSForename, MyEx.toString());
            }
            try
            {
                myStaff.StaffSurname = txtAddSSurname.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddSSurname, MyEx.toString());
            }
            try
            {
                myStaff.StaffTown = txtAddSTown.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddSTown, MyEx.toString());
            }
            try
            {
                myStaff.StaffStreet = txtAddStreet.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddStreet, MyEx.toString());
            }
            try
            {
                myStaff.StaffPostcode = txtAddSPostcode.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddSPostcode, MyEx.toString());
            }
            try
            {
                myStaff.StaffTelephoneNo = txtAddSTeleNo.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddSTeleNo, MyEx.toString());
            }
            try
            {
                myStaff.StaffMobileNo = txtAddSMobileNo.Text.Trim();

            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddSMobileNo, MyEx.toString());
            }
            try
            {
                myStaff.StaffEmail = txtAddSEmail.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddSEmail, "Invalid Email");
            }

            try
            {
                if (ok)
                {
                    drStaff = dsLloydsPharmacy.Tables["Staff"].NewRow();
                    drStaff["StaffID"] = myStaff.StaffNo;
                    drStaff["Title"] = myStaff.StaffTitle;
                    drStaff["Forename"] = myStaff.StaffForename;
                    drStaff["Surname"] = myStaff.StaffSurname;
                    drStaff["Town"] = myStaff.StaffTown;
                    drStaff["Street"] = myStaff.StaffStreet;
                    drStaff["Postcode"] = myStaff.StaffPostcode;
                    drStaff["TelephoneNo"] = myStaff.StaffTelephoneNo;
                    drStaff["MobileNo"] = myStaff.StaffMobileNo;
                    drStaff["Email"] = myStaff.StaffEmail;

                    dsLloydsPharmacy.Tables["Staff"].Rows.Add(drStaff);
                    daStaff.Update(dsLloydsPharmacy, "Staff"); // updates to sql
                    MessageBox.Show("Staff Member Added");

                    if (MessageBox.Show("Do you wish to add another staff member", "Add Staff", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        clearAddForm();
                        getNumber(dsLloydsPharmacy.Tables["Staff"].Rows.Count);
                    }
                    else
                        tabStaff.SelectedIndex = 0;

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error",
                MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }

        }

        void clearAddForm()
        {
            cmbAddStaffTitle.SelectedIndex = 0;
            txtAddSForename.Clear();
            txtAddSSurname.Clear();
            txtAddSTown.Clear();
            txtAddStreet.Clear();
            txtAddSTeleNo.Clear();
            txtAddSMobileNo.Clear();
            txtAddSPostcode.Clear();
            txtAddSEmail.Clear();

        }

        private void tabStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTab = tabStaff.SelectedIndex;
            tabStaff.TabPages[tabStaff.SelectedIndex].Focus();
            //      tabStaff.TabPages[tabStaff.SelectedIndex.CausesValidation = true;

            if (dgvStaff.SelectedRows.Count == 0 && tabStaff.SelectedIndex == 2)
            {
                tabStaff.TabPages[tabStaff.SelectedIndex].CausesValidation = true;

            }
            else
            {

                switch (tabStaff.SelectedIndex)
                {
                    case 0: // display selected
                        {
                            dsLloydsPharmacy.Tables["Staff"].Clear();
                            daStaff.Fill(dsLloydsPharmacy, "Staff");

                            break;
                        }
                    case 1: // add tab 
                        {
                            int noRows = dsLloydsPharmacy.Tables["Staff"].Rows.Count;
                            if (noRows == 0)
                                lblAddAddStaffID.Text = "100";
                            else
                            {
                                getNumber(noRows);
                            }
                            errP.Clear();
                            clearAddForm();
                            break;
                        }
                    case 2: //edit tab
                        {
                            staffNoSelected = dgvStaff.SelectedRows[0].Index + 100;
                            if (staffNoSelected == 0)
                            {
                                tabStaff.SelectedIndex = 0;
                                break;
                            }
                            else
                            {
                                lblSEditEditStaffID.Text = "S" + staffNoSelected.ToString();

                                drStaff = dsLloydsPharmacy.Tables["Staff"].Rows.Find(lblSEditEditStaffID.Text);
                                if (drStaff["Title"].ToString() == "Mr")
                                    cmbEditStaffTitle.SelectedIndex = 0;
                                if (drStaff["Title"].ToString() == "Mrs")
                                    cmbEditStaffTitle.SelectedIndex = 1;
                                if (drStaff["Title"].ToString() == "Miss")
                                    cmbEditStaffTitle.SelectedIndex = 2;
                                if (drStaff["Title"].ToString() == "Ms")
                                    cmbEditStaffTitle.SelectedIndex = 3;

                                txtSEditForename.Text =
                                drStaff["Forename"].ToString();
                                txtSEditSurname.Text =
                                drStaff["Surname"].ToString();
                                txtSEditTown.Text =
                                drStaff["Town"].ToString();
                                txtEditStreet.Text =
                                drStaff["Street"].ToString();
                                txtEditSPostcode.Text =
                                drStaff["Postcode"].ToString();
                                txtEditSTeleNo.Text =
                                drStaff["TelephoneNo"].ToString();
                                txtEditSMobileNo.Text =
                                drStaff["MobileNo"].ToString();
                                txtEditSEmail.Text =
                                drStaff["Email"].ToString();
                                break;

                            }
                        }
                    case 3: // Report 1
                        {
                            break;
                        }
                    case 4: // Report 2
                        {


                            break;
                        }
                }
            }
        }

        void AddTabValidation(object sender, CancelEventArgs e)
        {
            if (dgvStaff.SelectedRows.Count == 0)
            {
                staffSelected = false;
                staffNoSelected = 0;
            }
            else if (dgvStaff.SelectedRows.Count == 1)
            {
                staffSelected = true;
                staffNoSelected =
                Convert.ToInt32(dgvStaff.SelectedRows[0].Cells[0].Value);
            }
        }
        void EditTabValidation(object sender, CancelEventArgs e)
        {
            if (dgvStaff.SelectedRows.Count == 0)
            {
                staffSelected = false;
                staffNoSelected = 0;
            }
            else if (dgvStaff.SelectedRows.Count == 1)
            {
                staffSelected = true;
                staffNoSelected =
                Convert.ToInt32(dgvStaff.SelectedRows[0].Cells[0].Value);
            }
        }

        private void btnSEditEdit_Click(object sender, EventArgs e)
        {
            if (btnSEditEdit.Text == "Edit")
            {
                cmbEditStaffTitle.Enabled = true;
                txtSEditForename.Enabled = true;
                txtSEditSurname.Enabled = true;
                txtSEditTown.Enabled = true;
                txtEditStreet.Enabled = true;
                txtEditSPostcode.Enabled = true;
                txtEditSTeleNo.Enabled = true;
                txtEditSMobileNo.Enabled = true;
                txtEditSEmail.Enabled = true;

                btnSEditEdit.Text = "Save";
            }

            else
            {
                MyStaff myStaff = new MyStaff();
                bool ok = true;
                errP.Clear();

                try
                {
                    myStaff.StaffNo =
                //  Convert.ToInt32(lblSEditEditStaffID.Text.Trim()); // pass to staff class to check
                lblSEditEditStaffID.Text.Trim();

                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(lblSEditEditStaffID, MyEx.toString());
                }

                try
                {
                    myStaff.StaffTitle = cmbEditStaffTitle.Text.Trim();

                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(cmbEditStaffTitle, MyEx.toString());
                }
                try
                {
                    myStaff.StaffForename = txtSEditForename.Text.Trim();
                }

                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtSEditForename, MyEx.toString());
                }
                try
                {
                    myStaff.StaffSurname = txtSEditSurname.Text.Trim();

                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtSEditSurname, MyEx.toString());
                }
                try
                {
                    myStaff.StaffTown = txtSEditTown.Text.Trim();

                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtSEditTown, MyEx.toString());
                }
                try
                {
                    myStaff.StaffStreet = txtEditStreet.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditStreet, MyEx.toString());
                }
                try
                {
                    myStaff.StaffPostcode = txtEditSPostcode.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditSPostcode, MyEx.toString());
                }
                try
                {
                    myStaff.StaffTelephoneNo = txtEditSTeleNo.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditSTeleNo, MyEx.toString());
                }
                try
                {
                    myStaff.StaffMobileNo = txtEditSMobileNo.Text.Trim();

                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditSMobileNo, MyEx.toString());
                }
                try
                {
                    myStaff.StaffEmail = txtEditSEmail.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditSEmail, "Invalid Email");
                }

                try
                {
                    if (ok)
                    {
                        drStaff.BeginEdit();
                        //   drStaff = dsLloydsPharmacy.Tables["Staff"].NewRow();
                        drStaff["StaffID"] = myStaff.StaffNo;
                        drStaff["Title"] = myStaff.StaffTitle;
                        drStaff["Forename"] = myStaff.StaffForename;
                        drStaff["Surname"] = myStaff.StaffSurname;
                        drStaff["Town"] = myStaff.StaffTown;
                        drStaff["Street"] = myStaff.StaffStreet;
                        drStaff["Postcode"] = myStaff.StaffPostcode;
                        drStaff["TelephoneNo"] = myStaff.StaffTelephoneNo;
                        drStaff["MobileNo"] = myStaff.StaffMobileNo;
                        drStaff["Email"] = myStaff.StaffEmail;

                        drStaff.EndEdit();
                        daStaff.Update(dsLloydsPharmacy, "Staff");
                        MessageBox.Show("Staff Details Updated", "Staff");

                        cmbEditStaffTitle.Enabled = false;
                        txtSEditForename.Enabled = false;
                        txtSEditSurname.Enabled = false;
                        txtSEditTown.Enabled = false;
                        txtEditStreet.Enabled = false;
                        txtEditSPostcode.Enabled = false;
                        txtEditSTeleNo.Enabled = false;
                        txtEditSMobileNo.Enabled = false;
                        txtEditSEmail.Enabled = false;

                        btnSEditEdit.Text = "Edit";
                        tabStaff.SelectedIndex = 0;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!", MessageBoxButtons.AbortRetryIgnore,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btnSDelete_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a staff member from the list", "Select Staff");
            }
            else
            {
                drStaff = dsLloydsPharmacy.Tables["Staff"].Rows.Find(dgvStaff.SelectedRows[0].Cells[0].Value);
                string tempName = drStaff["Forename"].ToString() + " " + drStaff["Surname"].ToString() + "\'s";

                if (MessageBox.Show("Are you sure you want to delete " + tempName + " details?", "Add Staff", MessageBoxButtons.YesNo) ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    drStaff.Delete();
                    daStaff.Update(dsLloydsPharmacy, "Staff");
                }
            }
        }
        private void searchStaff(string txt)
        {

            txt = ("Select * from staff where Forename like'" + txtSearchStaffForename.Text.Trim() + "%'  ORDER BY CAST(SUBSTRING (StaffID, 2, len(StaffID)-1) as int)");
            daStaff = new SqlDataAdapter(txt, connStr);
            cmdBStaff = new SqlCommandBuilder(daStaff);
            dsLloydsPharmacy.Tables["Staff"].Clear();
            daStaff.FillSchema(dsLloydsPharmacy, SchemaType.Source, "Staff");
            daStaff.Fill(dsLloydsPharmacy, "Staff");
            dgvStaff.DataSource = dsLloydsPharmacy.Tables["Staff"];


        }

        private void btnSAddCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel the addition of Staff No: " + lblAddAddStaffID.Text + "?",
                "Add Staff", MessageBoxButtons.YesNo)
               == System.Windows.Forms.DialogResult.Yes) tabStaff.SelectedIndex = 0;
        }

        private void btnSEditCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel the edit of Staff No: " + lblSEditEditStaffID.Text + "?",
              "Add Staff", MessageBoxButtons.YesNo)
             == System.Windows.Forms.DialogResult.Yes)
                tabStaff.SelectedIndex = 0;
        }

        void EditTabValidate(object sender, CancelEventArgs e)
        {
            if (staffSelected == false && staffNoSelected == 0)
            {
                staffSelected = false;
                staffNoSelected = 0;
            }
            else if (dgvStaff.SelectedRows.Count == 1)
            {
                staffSelected = true;
                staffNoSelected =
                Convert.ToInt32(dgvStaff.SelectedRows[0].Cells[0].Value);
            }
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            //connStr = @"Data Source = .; Initial Catalog = LloydsPharmacy; Integrated Security = true;";
            //CONNECTION STRING DECLARATION
            connStr = @"Data Source = REDTOPS\SQLEXPRESS; Initial Catalog = LloydsPharmacy; Integrated Security = true";

            sqlStaff = @"Select StaffID,Title,Forename,Surname,Town,Street,Postcode,TelephoneNo,MobileNo,Email
                        FROM Staff
                        ORDER BY CAST(SUBSTRING (StaffID, 2, len(StaffID)-1) as int)";
            daStaff = new SqlDataAdapter(sqlStaff, connStr);
            cmdBStaff = new SqlCommandBuilder(daStaff);
            daStaff.FillSchema(dsLloydsPharmacy, SchemaType.Source, "Staff");
            daStaff.Fill(dsLloydsPharmacy, "Staff");
            dgvStaff.DataSource = dsLloydsPharmacy.Tables["Staff"];

            //Resize DGV
            dgvStaff.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            tabStaff.SelectedIndex = 1;
            tabStaff.SelectedIndex = 0;
        }

        private void btnHomeEdit_Click(object sender, EventArgs e)
        {
            tabStaff.SelectedIndex = 2;
        }

        private void btnHomeAdd_Click(object sender, EventArgs e)
        {
            tabStaff.SelectedIndex = 1;
        }

        private void dgvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearchStaffForename_TextChanged(object sender, EventArgs e)
        {
            searchStaff(txtSearchStaffForename.Text.Trim());
        }

        private void btnSAddAdd_MouseEnter(object sender, EventArgs e)
        {
            btnSAddAdd.Text = "";
            btnSAddAdd.ImageIndex = 1;
        }

        private void btnHomeAdd_MouseEnter(object sender, EventArgs e)
        {
            btnHomeAdd.Text = "";
            btnHomeAdd.ImageIndex = 1;
        }

        private void btnHomeAdd_MouseLeave(object sender, EventArgs e)
        {
            btnHomeAdd.Text = "Add";
            btnHomeAdd.ImageIndex = -1;
        }

        private void btnSAddAdd_MouseLeave(object sender, EventArgs e)
        {
            btnSAddAdd.Text = "Add";
            btnSAddAdd.ImageIndex = -1;
        }

        private void btnHomeEdit_MouseEnter(object sender, EventArgs e)
        {
            btnHomeEdit.Text = "";
            btnHomeEdit.ImageIndex = 2;
        }

        private void btnHomeEdit_MouseLeave(object sender, EventArgs e)
        {
            btnHomeEdit.Text = "Edit";
            btnHomeEdit.ImageIndex = -1;
        }

        //private void btnGenerateReport_Click(object sender, EventArgs e)
        //{
        //    if (txtCourseName.Text.Length > 0 && txtCourseType.Text.Length > 0)
        //    {
        //        StaffCourseFilter rpt = new StaffCourseFilter();
        //        rpt.SetParameterValue("CDesc", txtCourseName.Text);
        //        rpt.SetParameterValue("CType", txtCourseType.Text);
        //        crystalReportViewer4.ReportSource = rpt;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please enter data into the fields");
        //    }
        //}

        private void btnSDelete_MouseEnter(object sender, EventArgs e)
        {
            btnSDelete.Text = "";
            btnSDelete.ImageIndex = 7;
        }

        private void btnSDelete_MouseLeave(object sender, EventArgs e)
        {
            btnSDelete.Text = "Delete";
            btnSDelete.ImageIndex = -1;
        }

        private void btnSAddCancel_MouseEnter(object sender, EventArgs e)
        {
            btnSAddCancel.Text = "";
            btnSAddCancel.ImageIndex = 6;
        }

        private void btnSAddCancel_MouseLeave(object sender, EventArgs e)
        {
            btnSAddCancel.Text = "Cancel";
            btnSAddCancel.ImageIndex = -1;
        }

        private void btnSEditCancel_MouseEnter(object sender, EventArgs e)
        {
            btnSEditCancel.Text = "";
            btnSEditCancel.ImageIndex = 6;
        }

        private void btnSEditCancel_MouseLeave(object sender, EventArgs e)
        {
            btnSEditCancel.Text = "Cancel";
            btnSEditCancel.ImageIndex = -1;
        }

        private void btnSubmitReport_Click(object sender, EventArgs e)
        {
            if (txtCourseDesc.Text.Length > 0 && txtCourseT.Text.Length > 0)
            {
                StaffCourseFilter rpt = new StaffCourseFilter();
                rpt.SetParameterValue("CDesc", txtCourseDesc.Text);
                rpt.SetParameterValue("CType", txtCourseT.Text);
                crystalReportViewer4.ReportSource = rpt;
            }
            else
            {
                MessageBox.Show("Please enter data into the fields");
            }
        }

        private void frmStaff_Shown(object sender, EventArgs e)
        {
            tabStaff.TabPages[0].CausesValidation = true;
            tabStaff.TabPages[0].Validating += new CancelEventHandler(AddTabValidation);

            tabStaff.TabPages[2].CausesValidation = true;
            tabStaff.TabPages[2].Validating += new CancelEventHandler(EditTabValidation);
        }



    }
}
