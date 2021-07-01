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
    public partial class frmStaffCourse : Form
    {
        DateTimePicker dtp = new DateTimePicker();
        Rectangle _Rectangle;

        SqlDataAdapter daNames, daStaff, daCourses, daCourseType, daCourseInstance, daPatient, daCourseInstanceDetails, daCourseInstance2;
        DataSet dsLloydsPharmacy = new DataSet();
        SqlConnection conn;
        SqlCommand cmdCourseInstance;
        SqlCommandBuilder cmdBStaffDetails, cmdBPatientDetails, cmdBCourseInstanceDetails, cmdBCourseInstance, cmdBCourseInstance2;
        DataRow drCourse, drCourseInstance, drCourseInstanceDetails;
        DataTable dtCourses = new DataTable();
        DataTable dtPatient = new DataTable();
        DateTime monStartDate = new DateTime();
        String sqlNames, sqlCourseDetails, sqlStaffDetails, sqlCourseType, sqlCourseInstance, sqlPatient, sqlCourseInstanceDetails, sqlCourseInstance2;
        int selectedTab = 0;
        int courseInstanceNoSelected = 0;
        bool courseInstanceSelected = false;

        string[] times = { "9", "9.3", "10", "10.3", "11", "11.3", "12", "12.3", "13", "13.3",
                            "14", "14.3", "15", "15.3", "16","16.3","17" };
        DateTime[] currentWeek = new DateTime[]
        {
              new DateTime(2020,02,24),
              new DateTime(2020,02,25),
              new DateTime(2020,02,26),
              new DateTime(2020,02,27),
              new DateTime(2020,02,28),
              new DateTime(2020,02,29)
        };


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbCourseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //setup data adapter for course details in list box
            sqlCourseDetails = @"Select * From Courses where CourseTypeID like '" + cmbCourseType.SelectedValue + "' order by CourseID";

            //cmdBCourseDetails = new SqlCommandBuilder(daCourses);
            daCourses = new SqlDataAdapter(sqlCourseDetails, @"Data Source = .; Initial Catalog = LloydsPharmacy; Integrated Security = true;");
            //daCourses.FillSchema(dsLloydsPharmacy, SchemaType.Source, "Courses");
            if (dtCourses.Rows.Count > 0)
                dtCourses.Clear();
            daCourses.Fill(dtCourses);

            //fill listbox
            cmbCourses.DataSource = dtCourses;
            cmbCourses.DisplayMember = "CourseDesc";
            cmbCourses.ValueMember = "CourseID";

        }

        //private void btnAdd_Click(object sender, EventArgs e)
        //{

        //}

        private void btnAddInstance_Click(object sender, EventArgs e)
        {

            bool ok = true;
            bool exists = false;
            if (cmbCourseType.SelectedIndex == -1)
                MessageBox.Show("Please select a Course Type", "CourseType");
            else if (cmbCourses.SelectedIndex == -1)
                MessageBox.Show("Please select a Course", "Course");
            else if (cmbStaff.SelectedIndex == -1)
                MessageBox.Show("Please select a Staff Member", "Staff");
            else
            {
                MyCourseInstance myCourseInstance = new MyCourseInstance();
                try
                {
                    myCourseInstance.CourseInstanceID = lblCourseInstanceID.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    MessageBox.Show(MyEx.ToString());
                }
                try
                {
                    myCourseInstance.CourseID = lblCourse0.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    MessageBox.Show(MyEx.toString());
                }
                try
                {
                    myCourseInstance.StaffID = cmbStaff.SelectedValue.ToString();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    MessageBox.Show(MyEx.toString());
                }
                try
                {
                    myCourseInstance.CourseStartDate = dtpCourseStartDate.Value;
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    MessageBox.Show(MyEx.toString());
                }
                try
                {
                    myCourseInstance.CourseStartTime = Convert.ToDouble(txtAddStartTime.Text.Trim());
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    MessageBox.Show(MyEx.toString());
                }
                catch (System.FormatException)
                {
                    ok = false;
                    MessageBox.Show("Invalid Data entry in the Start Time Field - Must Contain a valid Time");
                }
                try
                {
                    if (dtpCourseStartDate.Value.DayOfWeek.ToString().Equals("Sunday"))
                    {
                        ok = false;
                        MessageBox.Show("Courses cannot be run on a Sunday");
                    }
                    if (ok)
                    {
                        drCourseInstance = dsLloydsPharmacy.Tables["CourseInstance2"].NewRow();
                        drCourseInstance["CourseInstanceID"] = myCourseInstance.CourseInstanceID;
                        drCourseInstance["CourseID"] = myCourseInstance.CourseID;
                        drCourseInstance["CourseStartDate"] = myCourseInstance.CourseStartDate;
                        drCourseInstance["CourseStartTime"] = myCourseInstance.CourseStartTime;
                        drCourseInstance["StaffID"] = myCourseInstance.StaffID;

                        dsLloydsPharmacy.Tables["CourseInstance2"].Rows.Add(drCourseInstance);
                        daCourseInstance2.Update(dsLloydsPharmacy, "CourseInstance2");
                        daCourseInstance.Update(dsLloydsPharmacy, "CourseInstance");
                        MessageBox.Show("Course Instance Added");
                        //  dgvTimetable.Refresh();
                        populateGrid2(times, currentWeek, monStartDate);
                        if (MessageBox.Show("Do you wish to add another Course Instance", "Add Course Instance", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                        {
                            cmbCourseType.SelectedIndex = -1;
                            ClearCourses();
                            cmbStaff.SelectedIndex = -1;
                        }
                        else
                        {
                          // getNumber(dsLloydsPharmacy.Tables["CourseInstance2"].Rows.Count);
                            //    tabTimetable.SelectedIndex = 0;
                            cmbCourseType.SelectedIndex = -1;
                            ClearCourses();
                            cmbStaff.SelectedIndex = -1;
                        }


                    }

                }             
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error",
                    MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                }
                
            }


        }

        public frmStaffCourse()
        {
            InitializeComponent();
            dgvTimetable.Controls.Add(dtp);
            dtp.Visible = false;
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.TextChanged += new EventHandler(dtp_TextChange);
        }

        private void btnEditCourseInstance_Click(object sender, EventArgs e)
        {
            try
            {
                tabTimetable.SelectedIndex = 1;
                string courseInstanceSelected = dgvTimetable.SelectedCells[0].Value.ToString();
                lblCourseInstanceID.Text = courseInstanceSelected.ToString();

                //  getNumber(dsLloydsPharmacy.Tables["CourseInstance2"].Rows.Count);
                //  MessageBox.Show(courseInstanceSelected);
                drCourseInstance = dsLloydsPharmacy.Tables["CourseInstance2"].Rows.Find(courseInstanceSelected);
                dtpCourseStartDate.Value = Convert.ToDateTime(drCourseInstance["CourseStartDate"]);
                btnEdit.Enabled = true;
                cmbCourseInstance.Enabled = false;
                cmbCourseType.Enabled = false;
                cmbStaff.Enabled = false;
                cmbCourses.Enabled = false;
                txtAddStartTime.Enabled = false;
                btnAddInstance.Enabled = false;
                btnAddInstanceDetails.Enabled = false;
                lstPatients.Enabled = false;
                btnAddInstanceDetails.Enabled = false;
                btnRemovePatients.Enabled = false;
                btnCancel.Text = "Cancel Edit";

            }
            catch (System.ArgumentOutOfRangeException)
            {
                tabTimetable.SelectedIndex = 0;
                MessageBox.Show("This Course Instance has already occured");
                
            }
        }




        private void btnEdit_Click(object sender, EventArgs e)
        {
            MyCourseInstance myCourseInstance = new MyCourseInstance();
            bool ok = true;
            try
            {
                myCourseInstance.CourseInstanceID = lblCourseInstanceID.Text;
            }
            catch (MyException MyEx)
            {
                ok = false;
                MessageBox.Show(MyEx.toString());
            }
            try
            {
                myCourseInstance.CourseStartDate = dtpCourseStartDate.Value;
            }
            catch (MyException MyEx)
            {
                ok = false;
                MessageBox.Show(MyEx.toString());
            }
            try
            {
                if (dtpCourseStartDate.Value.DayOfWeek.ToString().Equals("Sunday"))
                {
                    ok = false;
                    MessageBox.Show("Courses cannot be run on a Sunday");
                }
                if (ok)
                {
                    drCourseInstance.BeginEdit();
                    drCourseInstance["CourseInstanceID"] = myCourseInstance.CourseInstanceID;
                    drCourseInstance["CourseStartDate"] = myCourseInstance.CourseStartDate;
                    drCourseInstance.EndEdit();
                    daCourseInstance2.Update(dsLloydsPharmacy, "CourseInstance2");
                    daCourseInstance.Update(dsLloydsPharmacy, "CourseInstance");
                    MessageBox.Show("Course Instance Updated");
                    //   dgvTimetable.Refresh();
                    populateGrid2(times, currentWeek, monStartDate);

                    btnEdit.Enabled = false;
                    cmbCourseInstance.Enabled = true;
                    cmbCourseType.Enabled = true;
                    cmbStaff.Enabled = true;
                    cmbCourses.Enabled = true;
                    txtAddStartTime.Enabled = true;
                    btnAddInstance.Enabled = true;
                    btnAddInstanceDetails.Enabled = true;
                    lstPatients.Enabled = true;
                    btnAddInstanceDetails.Enabled = true;
                    btnRemovePatients.Enabled = true;

                    btnCancel.Text = "Cancel Add";
                    tabTimetable.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!", MessageBoxButtons.AbortRetryIgnore,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (btnCancel.Text.Equals("Cancel Edit"))
            {
                if (MessageBox.Show("Cancel the edit of Course Instance: " + lblCourseInstanceID.Text + "?", "Edit Course Instance", MessageBoxButtons.YesNo) ==
                System.Windows.Forms.DialogResult.Yes)
                    tabTimetable.SelectedIndex = 0;

            }
            if (btnCancel.Text.Equals("Cancel Add"))
            {
                {
                    if (MessageBox.Show("Cancel Adding:" + lblCourseInstanceID.Text + "?", "Add Course Instance", MessageBoxButtons.YesNo) ==
                 System.Windows.Forms.DialogResult.Yes)
                        tabTimetable.SelectedIndex = 0;
                }
            }
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            frmMenu frmmenu = new frmMenu();
            frmmenu.Show();
            this.Hide();
        }


        //     MessageBox.Show("" + ciDate.ToShortDateString() + "-" + ciDate.CompareTo(startDate) + "-" + startDate.ToShortDateString());
        //        DateTime ciDate = Convert.ToDateTime(dr["CourseStartDate"].ToString());
        //        ciDate = ciDate.Date;
        //                startDate = startDate.Date;
        //                if (ciDate.CompareTo(startDate) == 0)
        //                {
        //                    //Course starts this week on Monday
        //                    timeRow = 0;
        //                }
        //    startDate = startDate.Add(TimeSpan.FromDays(1));
        //               if (ciDate.CompareTo(startDate) == 0)
        //                {
        //                    //Tuesday
        //                    timeRow = -1;
        //                }
        //startDate = startDate.Add(TimeSpan.FromDays(1));
        //                if (ciDate.CompareTo(startDate)== 0)
        //                {
        //                    // Wednsday
        //                    timeRow = -2;
        //                }
        //                startDate =startDate.Add(TimeSpan.FromDays(1));
        //                if (ciDate.CompareTo(startDate)== 0)
        //                {   // Thursday
        //                    timeRow = -3;
        //                }
        //                startDate = startDate.Add(TimeSpan.FromDays(1));
        //                if (ciDate.CompareTo(startDate)== 0)
        //                {   // Friday
        //                    timeRow = -4;
        //                }
        //                startDate =startDate.Add(TimeSpan.FromDays(1));
        //               if (ciDate.CompareTo(startDate)== 0)
        //                {
        //                    //Saturday
        //                    timeRow = -5;
        //                }




        private void dtpCourseTime_ValueChanged(object sender, EventArgs e)
        {
            DateTime startDate = new DateTime();
            DateTime d = dtpCourseTime.Value;

            if (dtpCourseTime.Value.DayOfWeek.ToString().Equals("Monday"))
            {
                startDate = d.Add(TimeSpan.FromDays(0));
                monStartDate = startDate;
                dgvTimetable.Columns["colMonday"].HeaderText = startDate.ToShortDateString();
                startDate = startDate.Add(TimeSpan.FromDays(1));
                dgvTimetable.Columns["colTuesday"].HeaderText = startDate.ToShortDateString();
                startDate = startDate.Add(TimeSpan.FromDays(1));
                dgvTimetable.Columns["colWednesday"].HeaderText = startDate.ToShortDateString();
                startDate = startDate.Add(TimeSpan.FromDays(1));
                dgvTimetable.Columns["colThursday"].HeaderText = startDate.ToShortDateString();
                startDate = startDate.Add(TimeSpan.FromDays(1));
                dgvTimetable.Columns["colFriday"].HeaderText = startDate.ToShortDateString();
                startDate = startDate.Add(TimeSpan.FromDays(1));
                dgvTimetable.Columns["colSaturday"].HeaderText = startDate.ToShortDateString();
                startDate = startDate.Add(TimeSpan.FromDays(2));
                //  MessageBox.Show("CURRENT WEEK ITEM 0 = " + currentWeek[0].Date);
            }
            else if (dtpCourseTime.Value.DayOfWeek.ToString().Equals("Tuesday"))
            {
                startDate = d.Add(TimeSpan.FromDays(-1));
                monStartDate = startDate;
                dgvTimetable.Columns["colMonday"].HeaderText = startDate.ToShortDateString();
                startDate = startDate.Add(TimeSpan.FromDays(1));
                dgvTimetable.Columns["colTuesday"].HeaderText = startDate.ToShortDateString();
                startDate = startDate.Add(TimeSpan.FromDays(1));
                dgvTimetable.Columns["colWednesday"].HeaderText = startDate.ToShortDateString();
                startDate = startDate.Add(TimeSpan.FromDays(1));
                dgvTimetable.Columns["colThursday"].HeaderText = startDate.ToShortDateString();
                startDate = startDate.Add(TimeSpan.FromDays(1));
                dgvTimetable.Columns["colFriday"].HeaderText = startDate.ToShortDateString();
                startDate = startDate.Add(TimeSpan.FromDays(1));
                dgvTimetable.Columns["colSaturday"].HeaderText = startDate.ToShortDateString();
                startDate = startDate.Add(TimeSpan.FromDays(2));
                //  MessageBox.Show("CURRENT WEEK ITEM 1 = " + currentWeek[1].Date);
            }
            else if (dtpCourseTime.Value.DayOfWeek.ToString().Equals("Wednesday"))
            {
                startDate = d.Add(TimeSpan.FromDays(-2));
                monStartDate = startDate;
                dgvTimetable.Columns["colMonday"].HeaderText = startDate.ToShortDateString();
                startDate = startDate.Add(TimeSpan.FromDays(1));
                dgvTimetable.Columns["colTuesday"].HeaderText = startDate.ToShortDateString();
                startDate = startDate.Add(TimeSpan.FromDays(1));
                dgvTimetable.Columns["colWednesday"].HeaderText = startDate.ToShortDateString();
                startDate = startDate.Add(TimeSpan.FromDays(1));
                dgvTimetable.Columns["colThursday"].HeaderText = startDate.ToShortDateString();
                startDate = startDate.Add(TimeSpan.FromDays(1));
                dgvTimetable.Columns["colFriday"].HeaderText = startDate.ToShortDateString();
                startDate = startDate.Add(TimeSpan.FromDays(1));
                dgvTimetable.Columns["colSaturday"].HeaderText = startDate.ToShortDateString();
                startDate = startDate.Add(TimeSpan.FromDays(2));
                //  MessageBox.Show("CURRENT WEEK ITEM 2 = " + currentWeek[2].Date);
            }
            else if (dtpCourseTime.Value.DayOfWeek.ToString().Equals("Thursday"))
            {
                startDate = d.Add(TimeSpan.FromDays(-3));
                monStartDate = startDate;
                dgvTimetable.Columns["colMonday"].HeaderText = startDate.ToShortDateString();
                startDate = startDate.Add(TimeSpan.FromDays(1));
                dgvTimetable.Columns["colTuesday"].HeaderText = startDate.ToShortDateString();
                startDate = startDate.Add(TimeSpan.FromDays(1));
                dgvTimetable.Columns["colWednesday"].HeaderText = startDate.ToShortDateString();
                startDate = startDate.Add(TimeSpan.FromDays(1));
                dgvTimetable.Columns["colThursday"].HeaderText = startDate.ToShortDateString();
                startDate = startDate.Add(TimeSpan.FromDays(1));
                dgvTimetable.Columns["colFriday"].HeaderText = startDate.ToShortDateString();
                startDate = startDate.Add(TimeSpan.FromDays(1));
                dgvTimetable.Columns["colSaturday"].HeaderText = startDate.ToShortDateString();
                startDate = startDate.Add(TimeSpan.FromDays(2));
                //   MessageBox.Show("CURRENT WEEK ITEM 3 = " + currentWeek[3].Date);

            }
            else if (dtpCourseTime.Value.DayOfWeek.ToString().Equals("Friday"))
            {
                startDate = d.Add(TimeSpan.FromDays(-4));
                monStartDate = startDate;
                dgvTimetable.Columns["colMonday"].HeaderText = startDate.ToShortDateString();
                startDate = startDate.Add(TimeSpan.FromDays(1));
                dgvTimetable.Columns["colTuesday"].HeaderText = startDate.ToShortDateString();
                startDate = startDate.Add(TimeSpan.FromDays(1));
                dgvTimetable.Columns["colWednesday"].HeaderText = startDate.ToShortDateString();
                startDate = startDate.Add(TimeSpan.FromDays(1));
                dgvTimetable.Columns["colThursday"].HeaderText = startDate.ToShortDateString();
                startDate = startDate.Add(TimeSpan.FromDays(1));
                dgvTimetable.Columns["colFriday"].HeaderText = startDate.ToShortDateString();
                startDate = startDate.Add(TimeSpan.FromDays(1));
                dgvTimetable.Columns["colSaturday"].HeaderText = startDate.ToShortDateString();
                startDate = startDate.Add(TimeSpan.FromDays(2));
                //   MessageBox.Show("CURRENT WEEK ITEM 4 = " + currentWeek[4].Date);

            }
            else if (dtpCourseTime.Value.DayOfWeek.ToString().Equals("Saturday"))
            {
                startDate = d.Add(TimeSpan.FromDays(-5));
                monStartDate = startDate;
                dgvTimetable.Columns["colMonday"].HeaderText = startDate.ToShortDateString();
                startDate = startDate.Add(TimeSpan.FromDays(1));
                dgvTimetable.Columns["colTuesday"].HeaderText = startDate.ToShortDateString();
                startDate = startDate.Add(TimeSpan.FromDays(1));
                dgvTimetable.Columns["colWednesday"].HeaderText = startDate.ToShortDateString();
                startDate = startDate.Add(TimeSpan.FromDays(1));
                dgvTimetable.Columns["colThursday"].HeaderText = startDate.ToShortDateString();
                startDate = startDate.Add(TimeSpan.FromDays(1));
                dgvTimetable.Columns["colFriday"].HeaderText = startDate.ToShortDateString();
                startDate = startDate.Add(TimeSpan.FromDays(1));
                dgvTimetable.Columns["colSaturday"].HeaderText = startDate.ToShortDateString();
                startDate = startDate.Add(TimeSpan.FromDays(2));
                //   MessageBox.Show("CURRENT WEEK ITEM 5 = " + currentWeek[5].Date);

            }


            //  MessageBox.Show("" + monStartDate.ToString());
            // MessageBox.Show("" + (monStartDate.AddDays(5).ToString()));


            populateGrid2(times, currentWeek, monStartDate);
        }

        private void populateGrid2(string[] times, DateTime[] currentWeek, DateTime monStartDate)
        {
            bool ok = true;
            try
            {
                if (ok)
                {
                    dsLloydsPharmacy.Tables["CourseInstance"].Clear();
                    dsLloydsPharmacy.Tables["CourseInstance2"].Clear();

                    for (int i = 0; i < 6; i++)
                    {
                        for (int j = 0; j < 16; j++)
                        {
                            dgvTimetable.Rows[j].Cells[i].Value = DBNull.Value;
                            dgvTimetable.Rows[j].Cells[i].Style.BackColor = Color.White;
                        }
                    }



                    cmdCourseInstance.Parameters["@StartDate"].Value = monStartDate.Date;
                    cmdCourseInstance.Parameters["@EndDate"].Value = monStartDate.AddDays(6).Date;
                    currentWeek[0] = monStartDate.Date;
                    currentWeek[1] = monStartDate.AddDays(1).Date;
                    currentWeek[2] = monStartDate.AddDays(2).Date;
                    currentWeek[3] = monStartDate.AddDays(3).Date;
                    currentWeek[4] = monStartDate.AddDays(4).Date;
                    currentWeek[5] = monStartDate.AddDays(5).Date;

                    daCourseInstance.Fill(dsLloydsPharmacy, "CourseInstance");
                    daCourseInstance2.Fill(dsLloydsPharmacy, "CourseInstance2");


                    //        MessageBox.Show(monStartDate.ToShortDateString());
                    foreach (DataRow dr in dsLloydsPharmacy.Tables["CourseInstance"].Rows)
                    {
                        string startTime = (dr["CourseStartTime"].ToString());

                        for (int i = 0; i < 6; i++)
                        {
                            if (Convert.ToDateTime(dr["CourseStartDate"]).ToShortDateString().Equals(currentWeek[i].ToShortDateString()))
                            {
                                for (int j = 0; j < 16; j++)
                                {
                                    if (times[j].Equals(startTime))
                                    {
                                        dgvTimetable.Rows[j].Cells[i].Style.BackColor = Color.Green;
                                        dgvTimetable.Rows[j].Cells[i].Value = dr["CourseInstanceID"].ToString();

                                        for (int k = 1; k <= Convert.ToInt32(dr["HoursPerDay"]) * 2 - 1; k++)
                                        {
                                            dgvTimetable.Rows[j + k].Cells[i].Style.BackColor = Color.LightGreen;

                                            if (k.Equals(1))
                                            {
                                                dgvTimetable.Rows[j + k].Cells[i].Value = dr["CourseID"].ToString();
                                            }
                                            else if (k.Equals(2))
                                            {
                                                dgvTimetable.Rows[j + k].Cells[i].Value = dr["CourseDesc"].ToString();
                                            }
                                            else if (k.Equals(3))
                                            {
                                                dgvTimetable.Rows[j + k].Cells[i].Value = dr["Forename"].ToString() + ' ' + dr["Surname"].ToString();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (System.Data.SqlTypes.SqlTypeException)
            {
                ok = false;
                MessageBox.Show("Courses are not run on a Sunday");

            }
        }


        private void btnRemovePatients_Click(object sender, EventArgs e)
        {
            if (lvwCourseInstanceDetails.SelectedItems.Count != 0)
            {
                var item = lvwCourseInstanceDetails.SelectedItems[0];
                lvwCourseInstanceDetails.Items.Remove(item);
            }
        }

        private void ClearCourses()
        {
            cmbCourses.SelectedIndex = -1;
            lblCourseInstanceID.Text = "CIID";
            lblCourse0.Text = "";
            lblCourse1.Text = "";
            lblCourse2.Text = "";
            lblCourse3.Text = "";
            lblCourse4.Text = "";
            lblCourse5.Text = "";
            txtAddStartTime.Text = "";
        }


        private void dgvTimetable_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lstPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtCourseInstance = new DataTable();
            if (dtCourseInstance.Rows.Count > 0)
            {
                dtCourseInstance.Clear();
            }
            try
            {
                String sqlCourseInstance = @"SELECT * From CourseInstance";
                SqlDataAdapter daPopulateCourseInstanceIDs = new SqlDataAdapter(sqlCourseInstance, conn);

                daPopulateCourseInstanceIDs.Fill(dtCourseInstance);

                //fill combobox
                cmbCourseInstance.DataSource = dtCourseInstance;
                cmbCourseInstance.DisplayMember = "CourseInstanceID";
                cmbCourseInstance.ValueMember = "CourseInstanceID";
                //  cmbCourseInstance.SelectedIndex = -1;

                drCourseInstance = dtCourseInstance.Rows[cmbCourseInstance.SelectedIndex];
                getNumber(dsLloydsPharmacy.Tables["CourseInstance2"].Rows.Count);

            }
            catch (NullReferenceException nfe)
            {

            }
        }

        private void btnAddInstanceDetails_Click(object sender, EventArgs e)
        {
            bool ok = true;
            bool exists = false;
            if (lstPatients.SelectedIndex == -1)
                MessageBox.Show("Please select a Patient");
            else if (cmbCourseInstance.SelectedIndex == -1)
                MessageBox.Show("Please select a Course Instance");
            else
            {
                MyCourseInstanceDetails myCourseInstanceDetails = new MyCourseInstanceDetails();
                try
                {
                    myCourseInstanceDetails.PatientID = lstPatients.SelectedValue.ToString();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    MessageBox.Show(MyEx.ToString());
                }
                try
                {
                    myCourseInstanceDetails.CourseInstanceID = cmbCourseInstance.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    MessageBox.Show(MyEx.toString());
                }
                try
                {
                    if (ok)
                    {
                        drCourseInstanceDetails = dsLloydsPharmacy.Tables["CourseInstanceDetails"].NewRow();
                        drCourseInstanceDetails["PatientID"] = myCourseInstanceDetails.PatientID;
                        drCourseInstanceDetails["CourseInstanceID"] = myCourseInstanceDetails.CourseInstanceID;

                        dsLloydsPharmacy.Tables["CourseInstanceDetails"].Rows.Add(drCourseInstanceDetails);
                        daCourseInstanceDetails.Update(dsLloydsPharmacy, "CourseInstanceDetails");
                        MessageBox.Show("Enrolled");


                        // ***  --- LISTVIEW CODE FOR COURSE INSTANCE DETAILS --- ***

                        ListViewItem item = new ListViewItem(drCourseInstanceDetails["CourseInstanceID"].ToString());
                        item.SubItems.Add(drCourseInstanceDetails["PatientID"].ToString());
                        item.SubItems.Add(drCourseInstanceDetails["CourseInstanceID"].ToString());

                        lvwCourseInstanceDetails.Items.Add(item);
                    }

                }
                catch (System.Data.ConstraintException ce)
                {
                    ok = false;
                    MessageBox.Show("There is already a Patient enrolled in this class");
                }
            }
        }

        private void cmbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            String courseTypeID = "";

            DataTable dtStaff = new DataTable();
            if (dtStaff.Rows.Count > 0)
            {
                dtStaff.Clear();
            }
            try
            {
                String sqlStaff = @"SELECT s.StaffID, s.Forename + ',' + s.Surname AS Name , cs.CourseID 
                                                                FROM Staff s
                                                                JOIN CourseStaff cs on s.StaffID = cs.StaffID
                                                                WHERE cs.CourseID LIKE '" + cmbCourses.SelectedValue.ToString() + "' ORDER BY CAST(SUBSTRING(s.StaffID, 2, len(s.StaffID) - 1) as int)";

                SqlDataAdapter daPopulateStaffIDs = new SqlDataAdapter(sqlStaff, conn);

                daPopulateStaffIDs.Fill(dtStaff);

                // fill combobox
                cmbStaff.DataSource = dtStaff;
                cmbStaff.DisplayMember = "Name";
                cmbStaff.ValueMember = "StaffID";

                cmbStaff.SelectedIndex = -1;

                drCourse = dtCourses.Rows[cmbCourses.SelectedIndex];

                lblCourse0.Text = drCourse["CourseID"].ToString();
                lblCourse1.Text = drCourse["CourseDesc"].ToString();
                lblCourse2.Text = drCourse["NoDays"].ToString();
                lblCourse3.Text = drCourse["HoursPerDay"].ToString();
                lblCourse4.Text = drCourse["CoursePrice"].ToString();
                lblCourse5.Text = drCourse["noPatients"].ToString();
                getNumber(dsLloydsPharmacy.Tables["CourseInstance2"].Rows.Count);
            }
            catch (NullReferenceException nfe)
            {

            }
        }

        private void cmbStaff_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabTimetable_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTab = tabTimetable.SelectedIndex;
            tabTimetable.TabPages[tabTimetable.SelectedIndex].Focus();

            switch (tabTimetable.SelectedIndex)
            {
                case 0: // display selected
                    {
                        dsLloydsPharmacy.Tables["CourseInstance2"].Clear();
                        daCourseInstance2.Fill(dsLloydsPharmacy, "CourseInstance2");

                        break;
                    }
                case 1: // enrollment tab 
                    {
                        int noRows = dsLloydsPharmacy.Tables["CourseInstance2"].Rows.Count;
                        if (noRows == 0)
                            lblCourseInstanceID.Text = "CI1";
                        else
                        {
                            getNumber(noRows);
                            btnEdit.Enabled = false;
                            cmbCourseInstance.Enabled = true;
                            cmbCourseType.Enabled = true;
                            cmbStaff.Enabled = true;
                            cmbCourses.Enabled = true;
                            txtAddStartTime.Enabled = true;
                            btnAddInstance.Enabled = true;
                            btnAddInstanceDetails.Enabled = true;
                            lstPatients.Enabled = true;
                            btnAddInstanceDetails.Enabled = true;
                            btnRemovePatients.Enabled = true;
                            btnCancel.Text = "Cancel Add";
                        }

                        ClearCourses();
                        break;
                    }

            }
        }

        private void dtp_TextChange(object sender, EventArgs e)
        {
            dgvTimetable.CurrentCell.Value = dtp.Text.ToString();
        }

        private void dataGridView1_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            // dtp.Visible = false;

        }

        private void fillListBoxCourses()
        {
            daCourses.Fill(dsLloydsPharmacy, "Courses");

            //fill combo box
            cmbCourses.DataSource = dsLloydsPharmacy.Tables["Courses"];
            cmbCourses.DisplayMember = "CourseDesc";
            cmbCourses.ValueMember = "CourseID";

        }
        private void fillListBoxStaff()
        {
            daStaff.Fill(dsLloydsPharmacy, "Staff");

            //fill combo box
            cmbStaff.DataSource = dsLloydsPharmacy.Tables["Staff"];
            cmbStaff.DisplayMember = "Forename + ',' + Surname as Name";
            cmbStaff.ValueMember = "StaffID";

        }
        private void fillListBoxPatients()
        {
            daPatient.Fill(dsLloydsPharmacy, "Patient");

            //fill combo box
            lstPatients.DataSource = dsLloydsPharmacy.Tables["Patient"];
            lstPatients.DisplayMember = "PatientForename + ',' + PatientSurname as Name";
            lstPatients.ValueMember = "PatientID";


        }



        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            dtp.Visible = false;
        }

        private void getNumber(int noRows)
        {
            drCourseInstance = dsLloydsPharmacy.Tables["CourseInstance2"].Rows[noRows - 1];
            String lastId = drCourseInstance["CourseInstanceID"].ToString();

            int lastNum = Int32.Parse(lastId.Substring(2, lastId.Length - 2));
            lastNum++;

            lblCourseInstanceID.Text = "CI" + lastNum;

        }

        private void frmStaffCourse_Load(object sender, EventArgs e)
        {
            int no;
            string str = "";

            DataTable dtStaff = new DataTable();
            String connStr, sqlStaff;

            //connStr = @"Data Source = .; Initial Catalog = LloydsPharmacy; Integrated Security = true;";
            connStr = @"Data Source = REDTOPS\SQLEXPRESS; Initial Catalog = LloydsPharmacy; Integrated Security = true";

            conn = new SqlConnection(connStr);
            sqlCourseType = @"Select CourseTypeID, CourseTypeDesc from CourseType";
            daCourseType = new SqlDataAdapter(sqlCourseType, connStr);
            daCourseType.Fill(dsLloydsPharmacy, "CourseTypes");

            cmbCourseType.DataSource = dsLloydsPharmacy.Tables["CourseTypes"];
            cmbCourseType.DisplayMember = "CourseTypeDesc";
            cmbCourseType.ValueMember = "CourseTypeID";

            sqlCourseInstance = @"Select * From CourseInstance ci JOIN Courses c on ci.CourseID = c.CourseID JOIN Staff s on ci.StaffID = s.StaffID Where CourseStartDate between @StartDate and @EndDate ORDER BY CAST (SUBSTRING(CourseInstanceID, 3,LEN(CourseInstanceID)-2) as int)"; // @StartDate and DATEADD(DAY, 5, @StartDate)";
            cmdCourseInstance = new SqlCommand(sqlCourseInstance, conn);
            cmdCourseInstance.Parameters.Add("@StartDate", SqlDbType.SmallDateTime);
            cmdCourseInstance.Parameters.Add("@EndDate", SqlDbType.SmallDateTime);
            daCourseInstance = new SqlDataAdapter(cmdCourseInstance);
            daCourseInstance.FillSchema(dsLloydsPharmacy, SchemaType.Source, "CourseInstance");

            sqlCourseInstance2 = @"Select * From CourseInstance ORDER BY CAST (SUBSTRING(CourseInstanceID, 3,LEN(CourseInstanceID)-2) as int)";
            daCourseInstance2 = new SqlDataAdapter(sqlCourseInstance2, conn);
            cmdBCourseInstance2 = new SqlCommandBuilder(daCourseInstance2);
            daCourseInstance2.FillSchema(dsLloydsPharmacy, SchemaType.Source, "CourseInstance2");
            daCourseInstance2.Fill(dsLloydsPharmacy, "CourseInstance2");

            sqlStaffDetails = @"SELECT s.StaffID, s.Forename + ',' + s.Surname AS Name , cs.CourseID 
             FROM Staff s                               
             JOIN CourseStaff cs on s.StaffID = cs.StaffID
             ORDER BY CAST(SUBSTRING (s.StaffID, 2, len(s.StaffID)-1) as int)";
            daStaff = new SqlDataAdapter(sqlStaffDetails, conn);
            cmdBStaffDetails = new SqlCommandBuilder(daStaff);
            daStaff.FillSchema(dsLloydsPharmacy, SchemaType.Source, "Staff");
            daStaff.Fill(dsLloydsPharmacy, "Staff");

            sqlPatient = @"Select PatientID, PatientForename + ',' + PatientSurname AS Name FROM Patient";
            cmdBPatientDetails = new SqlCommandBuilder(daPatient);
            daPatient = new SqlDataAdapter(sqlPatient, conn);
            daPatient.FillSchema(dsLloydsPharmacy, SchemaType.Source, "Patient");
            daPatient.Fill(dsLloydsPharmacy, "Patient");

            sqlCourseInstanceDetails = @"Select * FROM CourseInstanceDetails";
            daCourseInstanceDetails = new SqlDataAdapter(sqlCourseInstanceDetails, conn);
            cmdBCourseInstanceDetails = new SqlCommandBuilder(daCourseInstanceDetails);
            daCourseInstanceDetails.FillSchema(dsLloydsPharmacy, SchemaType.Source, "CourseInstanceDetails");
            daCourseInstanceDetails.Fill(dsLloydsPharmacy, "CourseInstanceDetails");

            fillListBoxPatients();
            dtpCourseStartDate.MinDate = DateTime.Now;

            for (int r = 0; r <= 16; r++)
            {
                dgvTimetable.Rows.Add(new object[] { "", "" });
                if (r % 2 == 0)
                {

                    dgvTimetable.Rows[r].HeaderCell.Value = (r / 2 + 9) + ".00";
                }
                else
                {
                    dgvTimetable.Rows[r].HeaderCell.Value = (r / 2 + 9) + ".30";
                }
            }
            //  dgvTimetable.Rows[0].Cells[0].Value = "test";
        }

        public void AutoNumberRowsForGridView(DataGridView dataGridView)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
