namespace LloydsPharmacy
{
    partial class frmStaffCourse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabTimetable = new System.Windows.Forms.TabControl();
            this.tabDisplay = new System.Windows.Forms.TabPage();
            this.btnEditCourseInstance = new System.Windows.Forms.Button();
            this.dtpCourseTime = new System.Windows.Forms.DateTimePicker();
            this.dgvTimetable = new System.Windows.Forms.DataGridView();
            this.colMonday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFriday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaturday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.cmbStaff = new System.Windows.Forms.ComboBox();
            this.lblStaff = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.cmbCourses = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnRemovePatients = new System.Windows.Forms.Button();
            this.lblAddCourseInstanceDetails = new System.Windows.Forms.Label();
            this.cmbCourseInstance = new System.Windows.Forms.ComboBox();
            this.lvwCourseInstanceDetails = new System.Windows.Forms.ListView();
            this.colCourseInstanceID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPatientID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddInstanceDetails = new System.Windows.Forms.Button();
            this.lstPatients = new System.Windows.Forms.ListBox();
            this.lblCourseType = new System.Windows.Forms.Label();
            this.cmbCourseType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddInstance = new System.Windows.Forms.Button();
            this.lblCourseHeader = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblCourseStartTime = new System.Windows.Forms.Label();
            this.txtAddStartTime = new System.Windows.Forms.TextBox();
            this.lblCourse5 = new System.Windows.Forms.Label();
            this.dtpCourseStartDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCourse4 = new System.Windows.Forms.Label();
            this.lblCourseStartDate = new System.Windows.Forms.Label();
            this.lblCourse0 = new System.Windows.Forms.Label();
            this.lblCourse3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCourse2 = new System.Windows.Forms.Label();
            this.lblCourse1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCourseInstanceID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.tabTimetable.SuspendLayout();
            this.tabDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetable)).BeginInit();
            this.tabAdd.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabTimetable
            // 
            this.tabTimetable.Controls.Add(this.tabDisplay);
            this.tabTimetable.Controls.Add(this.tabAdd);
            this.tabTimetable.Location = new System.Drawing.Point(84, 159);
            this.tabTimetable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabTimetable.Name = "tabTimetable";
            this.tabTimetable.SelectedIndex = 0;
            this.tabTimetable.Size = new System.Drawing.Size(1536, 767);
            this.tabTimetable.TabIndex = 59;
            this.tabTimetable.SelectedIndexChanged += new System.EventHandler(this.tabTimetable_SelectedIndexChanged);
            // 
            // tabDisplay
            // 
            this.tabDisplay.Controls.Add(this.btnEditCourseInstance);
            this.tabDisplay.Controls.Add(this.dtpCourseTime);
            this.tabDisplay.Controls.Add(this.dgvTimetable);
            this.tabDisplay.Location = new System.Drawing.Point(4, 25);
            this.tabDisplay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabDisplay.Name = "tabDisplay";
            this.tabDisplay.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabDisplay.Size = new System.Drawing.Size(1528, 738);
            this.tabDisplay.TabIndex = 0;
            this.tabDisplay.Text = "Display";
            this.tabDisplay.UseVisualStyleBackColor = true;
            // 
            // btnEditCourseInstance
            // 
            this.btnEditCourseInstance.Location = new System.Drawing.Point(836, 10);
            this.btnEditCourseInstance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditCourseInstance.Name = "btnEditCourseInstance";
            this.btnEditCourseInstance.Size = new System.Drawing.Size(173, 25);
            this.btnEditCourseInstance.TabIndex = 57;
            this.btnEditCourseInstance.Text = "Edit Course Instance";
            this.btnEditCourseInstance.UseVisualStyleBackColor = true;
            this.btnEditCourseInstance.Click += new System.EventHandler(this.btnEditCourseInstance_Click);
            // 
            // dtpCourseTime
            // 
            this.dtpCourseTime.Location = new System.Drawing.Point(1036, 10);
            this.dtpCourseTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpCourseTime.Name = "dtpCourseTime";
            this.dtpCourseTime.Size = new System.Drawing.Size(245, 22);
            this.dtpCourseTime.TabIndex = 57;
            this.dtpCourseTime.ValueChanged += new System.EventHandler(this.dtpCourseTime_ValueChanged);
            // 
            // dgvTimetable
            // 
            this.dgvTimetable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimetable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMonday,
            this.colTuesday,
            this.colWednesday,
            this.colThursday,
            this.colFriday,
            this.colSaturday});
            this.dgvTimetable.Location = new System.Drawing.Point(8, 42);
            this.dgvTimetable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTimetable.Name = "dgvTimetable";
            this.dgvTimetable.ReadOnly = true;
            this.dgvTimetable.RowHeadersWidth = 71;
            this.dgvTimetable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTimetable.Size = new System.Drawing.Size(1477, 598);
            this.dgvTimetable.TabIndex = 57;
            // 
            // colMonday
            // 
            this.colMonday.HeaderText = "Monday";
            this.colMonday.MinimumWidth = 6;
            this.colMonday.Name = "colMonday";
            this.colMonday.ReadOnly = true;
            this.colMonday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colTuesday
            // 
            this.colTuesday.HeaderText = "Tuesday";
            this.colTuesday.MinimumWidth = 6;
            this.colTuesday.Name = "colTuesday";
            this.colTuesday.ReadOnly = true;
            this.colTuesday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colWednesday
            // 
            this.colWednesday.HeaderText = "Wednesday";
            this.colWednesday.MinimumWidth = 6;
            this.colWednesday.Name = "colWednesday";
            this.colWednesday.ReadOnly = true;
            this.colWednesday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colThursday
            // 
            this.colThursday.HeaderText = "Thursday";
            this.colThursday.MinimumWidth = 6;
            this.colThursday.Name = "colThursday";
            this.colThursday.ReadOnly = true;
            this.colThursday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colFriday
            // 
            this.colFriday.HeaderText = "Friday";
            this.colFriday.MinimumWidth = 6;
            this.colFriday.Name = "colFriday";
            this.colFriday.ReadOnly = true;
            this.colFriday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colSaturday
            // 
            this.colSaturday.HeaderText = "Saturday";
            this.colSaturday.MinimumWidth = 6;
            this.colSaturday.Name = "colSaturday";
            this.colSaturday.ReadOnly = true;
            this.colSaturday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tabAdd
            // 
            this.tabAdd.Controls.Add(this.cmbStaff);
            this.tabAdd.Controls.Add(this.lblStaff);
            this.tabAdd.Controls.Add(this.lblCourse);
            this.tabAdd.Controls.Add(this.cmbCourses);
            this.tabAdd.Controls.Add(this.panel6);
            this.tabAdd.Controls.Add(this.lblCourseType);
            this.tabAdd.Controls.Add(this.cmbCourseType);
            this.tabAdd.Controls.Add(this.panel1);
            this.tabAdd.Location = new System.Drawing.Point(4, 25);
            this.tabAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAdd.Size = new System.Drawing.Size(1528, 738);
            this.tabAdd.TabIndex = 1;
            this.tabAdd.Text = "Enrolment";
            this.tabAdd.UseVisualStyleBackColor = true;
            // 
            // cmbStaff
            // 
            this.cmbStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStaff.FormattingEnabled = true;
            this.cmbStaff.Location = new System.Drawing.Point(903, 32);
            this.cmbStaff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbStaff.Name = "cmbStaff";
            this.cmbStaff.Size = new System.Drawing.Size(160, 24);
            this.cmbStaff.TabIndex = 9;
            this.cmbStaff.SelectedIndexChanged += new System.EventHandler(this.cmbStaff_SelectedIndexChanged);
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Location = new System.Drawing.Point(816, 37);
            this.lblStaff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(37, 17);
            this.lblStaff.TabIndex = 8;
            this.lblStaff.Text = "Staff";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(400, 37);
            this.lblCourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(53, 17);
            this.lblCourse.TabIndex = 7;
            this.lblCourse.Text = "Course";
            // 
            // cmbCourses
            // 
            this.cmbCourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourses.FormattingEnabled = true;
            this.cmbCourses.Location = new System.Drawing.Point(487, 33);
            this.cmbCourses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCourses.Name = "cmbCourses";
            this.cmbCourses.Size = new System.Drawing.Size(279, 24);
            this.cmbCourses.TabIndex = 6;
            this.cmbCourses.SelectedIndexChanged += new System.EventHandler(this.cmbCourses_SelectedIndexChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gainsboro;
            this.panel6.Controls.Add(this.btnRemovePatients);
            this.panel6.Controls.Add(this.lblAddCourseInstanceDetails);
            this.panel6.Controls.Add(this.cmbCourseInstance);
            this.panel6.Controls.Add(this.lvwCourseInstanceDetails);
            this.panel6.Controls.Add(this.btnAddInstanceDetails);
            this.panel6.Controls.Add(this.lstPatients);
            this.panel6.Location = new System.Drawing.Point(40, 415);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1409, 298);
            this.panel6.TabIndex = 5;
            // 
            // btnRemovePatients
            // 
            this.btnRemovePatients.Location = new System.Drawing.Point(1095, 57);
            this.btnRemovePatients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemovePatients.Name = "btnRemovePatients";
            this.btnRemovePatients.Size = new System.Drawing.Size(163, 28);
            this.btnRemovePatients.TabIndex = 11;
            this.btnRemovePatients.Text = "Remove Patients";
            this.btnRemovePatients.UseVisualStyleBackColor = true;
            this.btnRemovePatients.Click += new System.EventHandler(this.btnRemovePatients_Click);
            // 
            // lblAddCourseInstanceDetails
            // 
            this.lblAddCourseInstanceDetails.AutoSize = true;
            this.lblAddCourseInstanceDetails.Location = new System.Drawing.Point(327, 28);
            this.lblAddCourseInstanceDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddCourseInstanceDetails.Name = "lblAddCourseInstanceDetails";
            this.lblAddCourseInstanceDetails.Size = new System.Drawing.Size(110, 17);
            this.lblAddCourseInstanceDetails.TabIndex = 10;
            this.lblAddCourseInstanceDetails.Text = "Course Instance";
            // 
            // cmbCourseInstance
            // 
            this.cmbCourseInstance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourseInstance.FormattingEnabled = true;
            this.cmbCourseInstance.Location = new System.Drawing.Point(319, 59);
            this.cmbCourseInstance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCourseInstance.Name = "cmbCourseInstance";
            this.cmbCourseInstance.Size = new System.Drawing.Size(160, 24);
            this.cmbCourseInstance.TabIndex = 7;
            // 
            // lvwCourseInstanceDetails
            // 
            this.lvwCourseInstanceDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCourseInstanceID,
            this.colPatientID});
            this.lvwCourseInstanceDetails.FullRowSelect = true;
            this.lvwCourseInstanceDetails.HideSelection = false;
            this.lvwCourseInstanceDetails.Location = new System.Drawing.Point(705, 28);
            this.lvwCourseInstanceDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvwCourseInstanceDetails.Name = "lvwCourseInstanceDetails";
            this.lvwCourseInstanceDetails.Size = new System.Drawing.Size(349, 244);
            this.lvwCourseInstanceDetails.TabIndex = 4;
            this.lvwCourseInstanceDetails.UseCompatibleStateImageBehavior = false;
            this.lvwCourseInstanceDetails.View = System.Windows.Forms.View.Details;
            // 
            // colCourseInstanceID
            // 
            this.colCourseInstanceID.DisplayIndex = 1;
            this.colCourseInstanceID.Text = "Course Instance ID";
            this.colCourseInstanceID.Width = 160;
            // 
            // colPatientID
            // 
            this.colPatientID.DisplayIndex = 0;
            this.colPatientID.Text = "Patient ID";
            this.colPatientID.Width = 160;
            // 
            // btnAddInstanceDetails
            // 
            this.btnAddInstanceDetails.Location = new System.Drawing.Point(319, 110);
            this.btnAddInstanceDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddInstanceDetails.Name = "btnAddInstanceDetails";
            this.btnAddInstanceDetails.Size = new System.Drawing.Size(176, 46);
            this.btnAddInstanceDetails.TabIndex = 6;
            this.btnAddInstanceDetails.Text = "Add Instance Details";
            this.btnAddInstanceDetails.UseVisualStyleBackColor = true;
            this.btnAddInstanceDetails.Click += new System.EventHandler(this.btnAddInstanceDetails_Click);
            // 
            // lstPatients
            // 
            this.lstPatients.FormattingEnabled = true;
            this.lstPatients.ItemHeight = 16;
            this.lstPatients.Location = new System.Drawing.Point(59, 28);
            this.lstPatients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstPatients.Name = "lstPatients";
            this.lstPatients.Size = new System.Drawing.Size(223, 244);
            this.lstPatients.TabIndex = 0;
            this.lstPatients.SelectedIndexChanged += new System.EventHandler(this.lstPatients_SelectedIndexChanged);
            // 
            // lblCourseType
            // 
            this.lblCourseType.AutoSize = true;
            this.lblCourseType.Location = new System.Drawing.Point(65, 37);
            this.lblCourseType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourseType.Name = "lblCourseType";
            this.lblCourseType.Size = new System.Drawing.Size(89, 17);
            this.lblCourseType.TabIndex = 3;
            this.lblCourseType.Text = "Course Type";
            // 
            // cmbCourseType
            // 
            this.cmbCourseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourseType.FormattingEnabled = true;
            this.cmbCourseType.Location = new System.Drawing.Point(177, 33);
            this.cmbCourseType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCourseType.Name = "cmbCourseType";
            this.cmbCourseType.Size = new System.Drawing.Size(160, 24);
            this.cmbCourseType.TabIndex = 2;
            this.cmbCourseType.SelectedIndexChanged += new System.EventHandler(this.cmbCourseType_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAddInstance);
            this.panel1.Controls.Add(this.lblCourseHeader);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(40, 73);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1408, 320);
            this.panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(647, 134);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 28);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel Edit";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(647, 75);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(135, 28);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit Instance";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddInstance
            // 
            this.btnAddInstance.Location = new System.Drawing.Point(647, 36);
            this.btnAddInstance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddInstance.Name = "btnAddInstance";
            this.btnAddInstance.Size = new System.Drawing.Size(135, 28);
            this.btnAddInstance.TabIndex = 5;
            this.btnAddInstance.Text = "Add Instance";
            this.btnAddInstance.UseVisualStyleBackColor = true;
            this.btnAddInstance.Click += new System.EventHandler(this.btnAddInstance_Click);
            // 
            // lblCourseHeader
            // 
            this.lblCourseHeader.AutoSize = true;
            this.lblCourseHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseHeader.Location = new System.Drawing.Point(24, 5);
            this.lblCourseHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourseHeader.Name = "lblCourseHeader";
            this.lblCourseHeader.Size = new System.Drawing.Size(82, 25);
            this.lblCourseHeader.TabIndex = 2;
            this.lblCourseHeader.Text = "Course";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblCourseStartTime);
            this.panel5.Controls.Add(this.txtAddStartTime);
            this.panel5.Controls.Add(this.lblCourse5);
            this.panel5.Controls.Add(this.dtpCourseStartDate);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.lblCourse4);
            this.panel5.Controls.Add(this.lblCourseStartDate);
            this.panel5.Controls.Add(this.lblCourse0);
            this.panel5.Controls.Add(this.lblCourse3);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.lblCourse2);
            this.panel5.Controls.Add(this.lblCourse1);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.lblCourseInstanceID);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(29, 33);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(527, 268);
            this.panel5.TabIndex = 2;
            // 
            // lblCourseStartTime
            // 
            this.lblCourseStartTime.AutoSize = true;
            this.lblCourseStartTime.Location = new System.Drawing.Point(4, 220);
            this.lblCourseStartTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourseStartTime.Name = "lblCourseStartTime";
            this.lblCourseStartTime.Size = new System.Drawing.Size(73, 17);
            this.lblCourseStartTime.TabIndex = 4;
            this.lblCourseStartTime.Text = "Start Time";
            // 
            // txtAddStartTime
            // 
            this.txtAddStartTime.Location = new System.Drawing.Point(227, 220);
            this.txtAddStartTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddStartTime.Name = "txtAddStartTime";
            this.txtAddStartTime.Size = new System.Drawing.Size(265, 22);
            this.txtAddStartTime.TabIndex = 6;
            // 
            // lblCourse5
            // 
            this.lblCourse5.AutoSize = true;
            this.lblCourse5.Location = new System.Drawing.Point(228, 161);
            this.lblCourse5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourse5.Name = "lblCourse5";
            this.lblCourse5.Size = new System.Drawing.Size(16, 17);
            this.lblCourse5.TabIndex = 7;
            this.lblCourse5.Text = "0";
            // 
            // dtpCourseStartDate
            // 
            this.dtpCourseStartDate.Location = new System.Drawing.Point(227, 185);
            this.dtpCourseStartDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpCourseStartDate.Name = "dtpCourseStartDate";
            this.dtpCourseStartDate.Size = new System.Drawing.Size(265, 22);
            this.dtpCourseStartDate.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 161);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "No Patients";
            // 
            // lblCourse4
            // 
            this.lblCourse4.AutoSize = true;
            this.lblCourse4.Location = new System.Drawing.Point(228, 128);
            this.lblCourse4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourse4.Name = "lblCourse4";
            this.lblCourse4.Size = new System.Drawing.Size(28, 17);
            this.lblCourse4.TabIndex = 6;
            this.lblCourse4.Text = "0.0";
            // 
            // lblCourseStartDate
            // 
            this.lblCourseStartDate.AutoSize = true;
            this.lblCourseStartDate.Location = new System.Drawing.Point(4, 192);
            this.lblCourseStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourseStartDate.Name = "lblCourseStartDate";
            this.lblCourseStartDate.Size = new System.Drawing.Size(72, 17);
            this.lblCourseStartDate.TabIndex = 3;
            this.lblCourseStartDate.Text = "Start Date";
            // 
            // lblCourse0
            // 
            this.lblCourse0.AutoSize = true;
            this.lblCourse0.Location = new System.Drawing.Point(4, 39);
            this.lblCourse0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourse0.Name = "lblCourse0";
            this.lblCourse0.Size = new System.Drawing.Size(21, 17);
            this.lblCourse0.TabIndex = 2;
            this.lblCourse0.Text = "ID";
            // 
            // lblCourse3
            // 
            this.lblCourse3.AutoSize = true;
            this.lblCourse3.Location = new System.Drawing.Point(228, 100);
            this.lblCourse3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourse3.Name = "lblCourse3";
            this.lblCourse3.Size = new System.Drawing.Size(16, 17);
            this.lblCourse3.TabIndex = 5;
            this.lblCourse3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Course Price";
            // 
            // lblCourse2
            // 
            this.lblCourse2.AutoSize = true;
            this.lblCourse2.Location = new System.Drawing.Point(228, 73);
            this.lblCourse2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourse2.Name = "lblCourse2";
            this.lblCourse2.Size = new System.Drawing.Size(16, 17);
            this.lblCourse2.TabIndex = 4;
            this.lblCourse2.Text = "0";
            // 
            // lblCourse1
            // 
            this.lblCourse1.AutoSize = true;
            this.lblCourse1.Location = new System.Drawing.Point(228, 41);
            this.lblCourse1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourse1.Name = "lblCourse1";
            this.lblCourse1.Size = new System.Drawing.Size(53, 17);
            this.lblCourse1.TabIndex = 3;
            this.lblCourse1.Text = "Course";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hours Per Day";
            // 
            // lblCourseInstanceID
            // 
            this.lblCourseInstanceID.AutoSize = true;
            this.lblCourseInstanceID.Location = new System.Drawing.Point(228, 14);
            this.lblCourseInstanceID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourseInstanceID.Name = "lblCourseInstanceID";
            this.lblCourseInstanceID.Size = new System.Drawing.Size(33, 17);
            this.lblCourseInstanceID.TabIndex = 9;
            this.lblCourseInstanceID.Text = "CIID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "NoDays";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 14);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Course Instance ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(617, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 54);
            this.label1.TabIndex = 58;
            this.label1.Text = "Course Timetable";
            // 
            // pbLogo
            // 
            this.pbLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogo.Image = global::LloydsPharmacy.Properties.Resources.logo;
            this.pbLogo.Location = new System.Drawing.Point(64, 27);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(545, 94);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 57;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // frmStaffCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1683, 953);
            this.Controls.Add(this.tabTimetable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbLogo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmStaffCourse";
            this.Text = "frmStaffCourse";
            this.Load += new System.EventHandler(this.frmStaffCourse_Load);
            this.Click += new System.EventHandler(this.pbLogo_Click);
            this.tabTimetable.ResumeLayout(false);
            this.tabDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetable)).EndInit();
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabTimetable;
        private System.Windows.Forms.TabPage tabDisplay;
        private System.Windows.Forms.Button btnEditCourseInstance;
        private System.Windows.Forms.DateTimePicker dtpCourseTime;
        private System.Windows.Forms.DataGridView dgvTimetable;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonday;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWednesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThursday;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFriday;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaturday;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.ComboBox cmbStaff;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.ComboBox cmbCourses;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnRemovePatients;
        private System.Windows.Forms.Label lblAddCourseInstanceDetails;
        private System.Windows.Forms.ComboBox cmbCourseInstance;
        private System.Windows.Forms.ListView lvwCourseInstanceDetails;
        private System.Windows.Forms.ColumnHeader colCourseInstanceID;
        private System.Windows.Forms.ColumnHeader colPatientID;
        private System.Windows.Forms.Button btnAddInstanceDetails;
        private System.Windows.Forms.ListBox lstPatients;
        private System.Windows.Forms.Label lblCourseType;
        private System.Windows.Forms.ComboBox cmbCourseType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddInstance;
        private System.Windows.Forms.Label lblCourseHeader;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblCourseStartTime;
        private System.Windows.Forms.TextBox txtAddStartTime;
        private System.Windows.Forms.Label lblCourse5;
        private System.Windows.Forms.DateTimePicker dtpCourseStartDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCourse4;
        private System.Windows.Forms.Label lblCourseStartDate;
        private System.Windows.Forms.Label lblCourse0;
        private System.Windows.Forms.Label lblCourse3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCourse2;
        private System.Windows.Forms.Label lblCourse1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCourseInstanceID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}