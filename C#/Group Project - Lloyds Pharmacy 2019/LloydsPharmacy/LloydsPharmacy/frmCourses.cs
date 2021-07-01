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
    public partial class frmCourses : Form
    {
        SqlDataAdapter daCourses;
        DataSet dsLloydsPharmacy = new DataSet();
        SqlCommandBuilder cmdBCourses;
        DataRow drCourses;
        String connStr, sqlCourses;
        int selectedTab = 0;
        bool coursesSelected = false;
        int coursesNoSelected = 0;

        public frmCourses()
        {
            InitializeComponent();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            frmMenu frmmenu = new frmMenu();
            frmmenu.Show();
            this.Hide();
        }
        void clearAddForm()
        {
            txtAddCCourseDesc.Clear();
            txtAddCNoDays.Clear();
            txtAddHoursPerDay.Clear();
            txtAddCCoursePrice.Clear();
            txtAddCCourseNoPatients.Clear();
            cmbAddCourseTypeID.SelectedIndex = 0;
        }
        private void getNumber(int noRows)
        {
            drCourses = dsLloydsPharmacy.Tables["Courses"].Rows[noRows - 1];
            String lastId = drCourses["CourseID"].ToString();

            int lastNum = Int32.Parse(lastId.Substring(1, lastId.Length - 1));
            lastNum++;
            //     lblAddAddStaffID.Text= 
            //     (int.Parse(drStaff["StaffID"].ToString()) + 1).ToString();           
            lblAddAddCourseID.Text = "C" + lastNum;

        }


        private void btnCAddAdd_Click(object sender, EventArgs e)
        {
            MyCourse myCourse = new MyCourse();
            bool ok = true;
            errP.Clear();

            try
            {
                myCourse.CourseID =
            //    Convert.ToInt32(lblAddAddCourseID.Text.Trim());
            lblAddAddCourseID.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(lblAddAddCourseID, MyEx.toString());
            }
            try
            {
                myCourse.CourseDesc = txtAddCCourseDesc.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddCCourseDesc, MyEx.toString());
            }
            catch (System.FormatException sfe)
            {
                ok = false;
                errP.SetError(txtAddCCourseDesc, "Invalid Data");
            }
            try
            {
                myCourse.CourseNoDays = Convert.ToInt32(txtAddCNoDays.Text.Trim());

            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddCNoDays, MyEx.toString());
            }
            catch (System.FormatException sfe)
            {
                ok = false;
                errP.SetError(txtAddCNoDays, "Invalid Data");
            }
            try
            {
                myCourse.HoursPerDay = Convert.ToDouble(txtAddHoursPerDay.Text.Trim());
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddHoursPerDay, MyEx.toString());
            }
            catch (System.FormatException sfe)
            {
                ok = false;
                errP.SetError(txtAddHoursPerDay, "Invalid Data");
            }
            try
            {
                myCourse.CoursePrice = Convert.ToDouble(txtAddCCoursePrice.Text.Trim());
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddCCoursePrice, MyEx.toString());
            }
            catch (System.FormatException sfe)
            {
                ok = false;
                errP.SetError(txtAddCCoursePrice, "Invalid Data");
            }
            try
            {
                myCourse.CourseNoPatients = Convert.ToInt32(txtAddCCourseNoPatients.Text.Trim());
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddCCourseNoPatients, MyEx.toString());
            }
            catch (System.FormatException sfe)
            {
                ok = false;
                errP.SetError(txtAddCCourseNoPatients, "Invalid Data");
            }
            try
            {
                myCourse.CourseTypeID = cmbAddCourseTypeID.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(cmbAddCourseTypeID, MyEx.toString());
            }

            try
            {
                if (ok)
                {
                    drCourses = dsLloydsPharmacy.Tables["Courses"].NewRow();
                    drCourses["CourseID"] = myCourse.CourseID;
                    drCourses["CourseDesc"] = myCourse.CourseDesc;
                    drCourses["NoDays"] = myCourse.CourseNoDays;
                    drCourses["HoursPerDay"] = myCourse.HoursPerDay;
                    drCourses["CoursePrice"] = myCourse.CoursePrice;
                    drCourses["NoPatients"] = myCourse.CourseNoPatients;
                    drCourses["CourseTypeID"] = myCourse.CourseTypeID;

                    dsLloydsPharmacy.Tables["Courses"].Rows.Add(drCourses);
                    daCourses.Update(dsLloydsPharmacy, "Courses"); // updates to sql
                    MessageBox.Show("Course Added");
                    if (MessageBox.Show("Do you wish to add another Course?", "Add Course", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        clearAddForm();
                        getNumber(dsLloydsPharmacy.Tables["Courses"].Rows.Count);
                    }
                    else
                    {
                        tabCourse.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error",
                MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }

        }

        private void tabCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTab = tabCourse.SelectedIndex;
            tabCourse.TabPages[tabCourse.SelectedIndex].Focus();

            switch (tabCourse.SelectedIndex)
            {
                case 0: // display
                    {
                        dsLloydsPharmacy.Tables["Courses"].Clear();
                        daCourses.Fill(dsLloydsPharmacy, "Courses");
                        break;
                    }
                case 1: // add tab
                    {
                        int noRows = dsLloydsPharmacy.Tables["Courses"].Rows.Count;
                        if (noRows == 0)
                            lblAddAddCourseID.Text = "10";
                        else
                        {
                            getNumber(noRows);
                        }
                        errP.Clear();
                        clearAddForm();
                        break;
                    }
                case 2: // edit
                    {
                        coursesNoSelected = dgvCourses.SelectedRows[0].Index + 10;
                        if (coursesNoSelected == 0)
                        {
                            tabCourse.SelectedIndex = 0;
                            break;
                        }
                        else
                        {

                            lblEditEditCourseID.Text = "C" + coursesNoSelected.ToString();
                            drCourses =
                            dsLloydsPharmacy.Tables["Courses"].Rows.Find(lblEditEditCourseID.Text);
                            txtEditHoursPerDay.Text = drCourses["HoursPerDay"].ToString();
                            txtCEditCourseDesc.Text = drCourses["CourseDesc"].ToString();
                            txtEditCNoDays.Text = drCourses["NoDays"].ToString();

                            txtEditCCourseNoPatients.Text = drCourses["NoPatients"].ToString();
                            txtEditCCoursePrice.Text = drCourses["CoursePrice"].ToString();
                            if (drCourses["CourseTypeID"].ToString() == "CT1")
                                cmbEditCourseType.SelectedIndex = 0;
                            if (drCourses["CourseTypeID"].ToString() == "CT2")
                                cmbEditCourseType.SelectedIndex = 1;
                            break;
                        }
                    }
            }
        }

        void addTabValidation(object sender, CancelEventArgs e)
        {
            if (dgvCourses.SelectedRows.Count == 0)
            {
                coursesSelected = false;
                coursesNoSelected = 0;
            }
            else if (dgvCourses.SelectedRows.Count == 1)
            {
                coursesSelected = true;
                coursesNoSelected =
                Convert.ToInt32(dgvCourses.SelectedRows[0].Cells[0].Value);
            }
        }

        void EditTabValidation(object sender, CancelEventArgs e)
        {
            if (dgvCourses.SelectedRows.Count == 0)
            {
                coursesSelected = false;
                coursesNoSelected = 0;
            }
            else if (dgvCourses.SelectedRows.Count == 1)
            {
                coursesSelected = true;
                coursesNoSelected =
                Convert.ToInt32(dgvCourses.SelectedRows[0].Cells[0].Value);

            }
        }

        private void frmCourses_Shown(object sender, EventArgs e)
        {
            tabCourse.TabPages[0].CausesValidation = true;
            tabCourse.TabPages[0].Validating += new CancelEventHandler(addTabValidation);

            tabCourse.TabPages[2].CausesValidation = true;
            tabCourse.TabPages[2].Validating += new CancelEventHandler(EditTabValidation);

        }

        private void btnCEditEdit_Click(object sender, EventArgs e)
        {
            if (btnCEditEdit.Text == "Edit")
            {
                txtCEditCourseDesc.Enabled = true;
                txtEditCCourseNoPatients.Enabled = true;
                txtEditCCoursePrice.Enabled = true;
                txtEditCNoDays.Enabled = true;
                txtEditHoursPerDay.Enabled = true;
                cmbEditCourseType.Enabled = true;
                btnCEditEdit.Text = "Save";
            }

            else
            {
                MyCourse myCourse = new MyCourse();
                bool ok = true;
                errP.Clear();


                try
                {
                    myCourse.CourseID =
                 //   Convert.ToInt32(lblEditEditCourseID.Text.Trim()); 
                 lblEditEditCourseID.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(lblEditEditCourseID, MyEx.toString());
                }
                try
                {
                    myCourse.CourseDesc = txtCEditCourseDesc.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtCEditCourseDesc, MyEx.toString());
                }
                catch (System.FormatException sfe)
                {
                    ok = false;
                    errP.SetError(txtCEditCourseDesc, "Invalid Data");
                }
                try
                {
                    myCourse.CourseNoDays = Convert.ToInt32(txtEditCNoDays.Text.Trim());
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditCNoDays, MyEx.toString());
                }
                catch (System.FormatException sfe)
                {
                    ok = false;
                    errP.SetError(txtEditCNoDays, "Invalid Data");
                }
                try
                {
                    myCourse.HoursPerDay = Convert.ToDouble(txtEditHoursPerDay.Text.Trim());
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditHoursPerDay, MyEx.toString());
                }
                catch (System.FormatException sfe)
                {
                    ok = false;
                    errP.SetError(txtEditHoursPerDay, "Invalid Data");
                }
                try
                {
                    myCourse.CoursePrice = Convert.ToDouble(txtEditCCoursePrice.Text.Trim());
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditCCoursePrice, MyEx.toString());
                }
                catch (System.FormatException sfe)
                {
                    ok = false;
                    errP.SetError(txtEditCCoursePrice, "Invalid Data");
                }
                try
                {
                    myCourse.CourseNoPatients = Convert.ToInt32(txtEditCCourseNoPatients.Text.Trim());
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditCCourseNoPatients, MyEx.toString());
                }
                catch (System.FormatException sfe)
                {
                    ok = false;
                    errP.SetError(txtEditCCourseNoPatients, "Invalid Data");
                }
                try
                {
                    myCourse.CourseTypeID = cmbEditCourseType.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(cmbEditCourseType, MyEx.toString());
                }

                try
                {
                    if (ok)
                    {
                        drCourses.BeginEdit();
                        drCourses["CourseID"] = myCourse.CourseID;
                        drCourses["CourseDesc"] = myCourse.CourseDesc;
                        drCourses["NoDays"] = myCourse.CourseNoDays;
                        drCourses["HoursPerDay"] = myCourse.HoursPerDay;
                        drCourses["CoursePrice"] = myCourse.CoursePrice;
                        drCourses["NoPatients"] = myCourse.CourseNoPatients;
                        drCourses["CourseTypeID"] = myCourse.CourseTypeID;

                        drCourses.EndEdit();
                        daCourses.Update(dsLloydsPharmacy, "Courses");
                        MessageBox.Show("Course Details Updated", "Courses");

                        txtCEditCourseDesc.Enabled = false;
                        txtEditCNoDays.Enabled = false;
                        txtEditHoursPerDay.Enabled = false;
                        txtEditCNoDays.Enabled = false;
                        txtEditCCoursePrice.Enabled = false;
                        txtEditCCourseNoPatients.Enabled = false;
                        cmbEditCourseType.Enabled = false;

                        btnCEditEdit.Text = "Edit";
                        tabCourse.SelectedIndex = 0;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!", MessageBoxButtons.AbortRetryIgnore,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btnCAddCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel the addition of CourseNo " + lblAddAddCourseID.Text + "?", "Add Course", MessageBoxButtons.YesNo)
            == System.Windows.Forms.DialogResult.Yes) tabCourse.SelectedIndex = 0;
        }

        private void btnCEditCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel the addition of CourseNo " + lblEditEditCourseID.Text + "?", "Add Customer", MessageBoxButtons.YesNo)
            == System.Windows.Forms.DialogResult.Yes)
                tabCourse.SelectedIndex = 0;
        }

        void EditTabValidate(object sender, CancelEventArgs e)
        {
            if (coursesSelected == false && coursesNoSelected == 0)
            {
                coursesSelected = false;
                coursesNoSelected = 0;
            }
            else if (dgvCourses.SelectedRows.Count == 1)
            {
                coursesSelected = true;
                coursesNoSelected =
                Convert.ToInt32(dgvCourses.SelectedRows[0].Cells[0].Value);
            }
        }

        private void searchCourseDesc(string txt)
        {
            txt = ("Select * from Courses where CourseDesc like'" + txtSearchCourseDesc.Text.Trim() + "%' ORDER BY CAST(SUBSTRING(CourseID, 2, LEN(CourseID) - 1) as int)");
            daCourses = new SqlDataAdapter(txt, connStr);
            cmdBCourses = new SqlCommandBuilder(daCourses);
            dsLloydsPharmacy.Tables["Courses"].Clear();
            daCourses.FillSchema(dsLloydsPharmacy, SchemaType.Source, "Courses");
            daCourses.Fill(dsLloydsPharmacy, "Courses");
            dgvCourses.DataSource = dsLloydsPharmacy.Tables["Courses"];

        }


        private void btnHomeDelete_Click(object sender, EventArgs e)
        {
            bool ok = true;
            if (dgvCourses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Course from the list", "Select Course");
            }
            else
            {
                drCourses = dsLloydsPharmacy.Tables["Courses"].Rows.Find(dgvCourses.SelectedRows[0].Cells[0].Value);
                string tempName = drCourses["CourseDesc"].ToString();

                if (MessageBox.Show("Are you sure you want to delete " + tempName + "details", "Add Course", MessageBoxButtons.YesNo) ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        if (ok)
                        {
                            drCourses.Delete();
                            daCourses.Update(dsLloydsPharmacy, "Courses");
                        }
                    }
                    catch (System.Data.SqlClient.SqlException sqle)
                    {
                        ok = false;
                        MessageBox.Show("You cannot delete this course as it contains students");
                    }
                }
            }
        }


        private void txtSearchStockID_TextChanged(object sender, EventArgs e)
        {
            searchCourseDesc(txtSearchCourseDesc.Text.Trim());
        }

        private void btnCAddAdd_MouseEnter(object sender, EventArgs e)
        {
            btnCAddAdd.Text = "";
            btnCAddAdd.ImageIndex = 2;
        }

        private void btnCAddAdd_MouseLeave(object sender, EventArgs e)
        {
            btnCAddAdd.Text = "Add";
            btnCAddAdd.ImageIndex = -1;
        }

        private void btnHomeDelete_MouseEnter(object sender, EventArgs e)
        {
            btnHomeDelete.Text = "";
            btnHomeDelete.ImageIndex = 6;
        }

        private void btnHomeDelete_MouseLeave(object sender, EventArgs e)
        {
            btnHomeDelete.Text = "Delete";
            btnHomeDelete.ImageIndex = -1;
        }

        private void btnCAddCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCAddCancel.Text = "";
            btnCAddCancel.ImageIndex = 5;
        }

        private void btnCAddCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCAddCancel.Text = "Cancel";
            btnCAddCancel.ImageIndex = -1;
        }

        private void btnCEditCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCEditCancel.Text = "";
            btnCEditCancel.ImageIndex = 5;
        }

        private void btnCEditCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCEditCancel.Text = "Cancel";
            btnCEditCancel.ImageIndex = -1;
        }

        private void btnGenerateCourseReport_Click(object sender, EventArgs e)
        {
            if (txtPatientID.Text.Length > 0 && txtPatientID.Text.Length > 0)
            {
                PatientCourse rpt = new PatientCourse();
                rpt.SetParameterValue("PID", txtPatientID.Text);
                //crystalReportViewer1.ReportSource = rpt;
            }
            else
            {
                MessageBox.Show("Please enter data into the fields");
            }
        }

        private void btnSubmitReport_Click(object sender, EventArgs e)
        {
            if (txtPatientCourse.Text.Length > 0 && txtPatientCourse.Text.Length > 0)
            {
                PatientCourse rpt = new PatientCourse();
                rpt.SetParameterValue("PID", txtPatientCourse.Text);
                //crystalReportViewer2.ReportSource = rpt;
            }
            else
            {
                MessageBox.Show("Please enter data into the fields");
            }
        }

        private void frmCourses_Load(object sender, EventArgs e)
        {
            //connStr = @"Data Source = .; Initial Catalog = LloydsPharmacy; Integrated Security = true;";
            connStr = @"Data Source = REDTOPS\SQLEXPRESS; Initial Catalog = LloydsPharmacy; Integrated Security = true;";

            sqlCourses = @"Select CourseID, CourseDesc, NoDays,HoursPerDay, CoursePrice, NoPatients,CourseTypeID
                            FROM Courses
                            ORDER BY CAST (SUBSTRING(CourseID, 2,LEN(CourseID)-1) as int)";
            daCourses = new SqlDataAdapter(sqlCourses, connStr);
            cmdBCourses = new SqlCommandBuilder(daCourses);
            daCourses.FillSchema(dsLloydsPharmacy, SchemaType.Source, "Courses");
            daCourses.Fill(dsLloydsPharmacy, "Courses");
            dgvCourses.DataSource = dsLloydsPharmacy.Tables["Courses"];

            dgvCourses.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            tabCourse.SelectedIndex = 1;
            tabCourse.SelectedIndex = 0;

        }
    }
}
