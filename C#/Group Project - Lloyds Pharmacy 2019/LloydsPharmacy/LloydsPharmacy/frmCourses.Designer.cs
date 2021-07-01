namespace LloydsPharmacy
{
    partial class frmCourses
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCourses));
            this.ILCourses = new System.Windows.Forms.ImageList(this.components);
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            this.PBIcon = new System.Windows.Forms.PictureBox();
            this.lblCourses = new System.Windows.Forms.Label();
            this.tabCourse = new System.Windows.Forms.TabControl();
            this.tabDisplay = new System.Windows.Forms.TabPage();
            this.btnHomeDelete = new System.Windows.Forms.Button();
            this.lblDisplayCourses = new System.Windows.Forms.Label();
            this.lblSearchCourseDesc = new System.Windows.Forms.Label();
            this.txtSearchCourseDesc = new System.Windows.Forms.TextBox();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.txtAddHoursPerDay = new System.Windows.Forms.TextBox();
            this.lblAddHoursPerDay = new System.Windows.Forms.Label();
            this.cmbAddCourseTypeID = new System.Windows.Forms.ComboBox();
            this.lblAddCCourseTypeID = new System.Windows.Forms.Label();
            this.lblAddAddCourseID = new System.Windows.Forms.Label();
            this.lblAddCourseID = new System.Windows.Forms.Label();
            this.btnCAddCancel = new System.Windows.Forms.Button();
            this.btnCAddAdd = new System.Windows.Forms.Button();
            this.txtAddCCourseNoPatients = new System.Windows.Forms.TextBox();
            this.txtAddCCoursePrice = new System.Windows.Forms.TextBox();
            this.txtAddCNoDays = new System.Windows.Forms.TextBox();
            this.txtAddCCourseDesc = new System.Windows.Forms.TextBox();
            this.lblAddCCourseNoPatients = new System.Windows.Forms.Label();
            this.lblAddCCoursePrice = new System.Windows.Forms.Label();
            this.lblAddCCourseNoDays = new System.Windows.Forms.Label();
            this.lblAddCCourseDesc = new System.Windows.Forms.Label();
            this.lblAddHeader = new System.Windows.Forms.Label();
            this.tabEdit = new System.Windows.Forms.TabPage();
            this.txtEditHoursPerDay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEditCourseType = new System.Windows.Forms.ComboBox();
            this.lblEditHeader = new System.Windows.Forms.Label();
            this.lblEditCCourseTypeID = new System.Windows.Forms.Label();
            this.lblEditEditCourseID = new System.Windows.Forms.Label();
            this.lblCEditCourseID = new System.Windows.Forms.Label();
            this.txtEditCCourseNoPatients = new System.Windows.Forms.TextBox();
            this.txtEditCCoursePrice = new System.Windows.Forms.TextBox();
            this.txtEditCNoDays = new System.Windows.Forms.TextBox();
            this.txtCEditCourseDesc = new System.Windows.Forms.TextBox();
            this.lblEditCCourseNoPatients = new System.Windows.Forms.Label();
            this.lblEditCCoursePrice = new System.Windows.Forms.Label();
            this.lblEditCNoDays = new System.Windows.Forms.Label();
            this.lblEditCCourseDesc = new System.Windows.Forms.Label();
            this.btnCEditCancel = new System.Windows.Forms.Button();
            this.btnCEditEdit = new System.Windows.Forms.Button();
            this.btnGenerateCourseReport = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.tabPatientCourse = new System.Windows.Forms.TabPage();
            //this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPatientCourse = new System.Windows.Forms.TextBox();
            this.btnSubmitReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBIcon)).BeginInit();
            this.tabCourse.SuspendLayout();
            this.tabDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.tabAdd.SuspendLayout();
            this.tabEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.tabPatientCourse.SuspendLayout();
            this.SuspendLayout();
            // 
            // ILCourses
            // 
            this.ILCourses.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ILCourses.ImageStream")));
            this.ILCourses.TransparentColor = System.Drawing.Color.Transparent;
            this.ILCourses.Images.SetKeyName(0, "courses.png");
            this.ILCourses.Images.SetKeyName(1, "online-course.png");
            this.ILCourses.Images.SetKeyName(2, "add course.png");
            this.ILCourses.Images.SetKeyName(3, "edit course.png");
            this.ILCourses.Images.SetKeyName(4, "display course.png");
            this.ILCourses.Images.SetKeyName(5, "cancel.png");
            this.ILCourses.Images.SetKeyName(6, "trash.png");
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // PBIcon
            // 
            this.PBIcon.Image = global::LloydsPharmacy.Properties.Resources.courses;
            this.PBIcon.Location = new System.Drawing.Point(603, 43);
            this.PBIcon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PBIcon.Name = "PBIcon";
            this.PBIcon.Size = new System.Drawing.Size(86, 76);
            this.PBIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBIcon.TabIndex = 53;
            this.PBIcon.TabStop = false;
            // 
            // lblCourses
            // 
            this.lblCourses.AutoSize = true;
            this.lblCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourses.Location = new System.Drawing.Point(434, 77);
            this.lblCourses.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourses.Name = "lblCourses";
            this.lblCourses.Size = new System.Drawing.Size(165, 42);
            this.lblCourses.TabIndex = 52;
            this.lblCourses.Text = "Courses";
            // 
            // tabCourse
            // 
            this.tabCourse.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabCourse.Controls.Add(this.tabDisplay);
            this.tabCourse.Controls.Add(this.tabAdd);
            this.tabCourse.Controls.Add(this.tabEdit);
            this.tabCourse.Controls.Add(this.tabPatientCourse);
            this.tabCourse.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.tabCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCourse.ImageList = this.ILCourses;
            this.tabCourse.ItemSize = new System.Drawing.Size(25, 50);
            this.tabCourse.Location = new System.Drawing.Point(20, 165);
            this.tabCourse.Multiline = true;
            this.tabCourse.Name = "tabCourse";
            this.tabCourse.Padding = new System.Drawing.Point(6, 5);
            this.tabCourse.SelectedIndex = 0;
            this.tabCourse.Size = new System.Drawing.Size(1228, 569);
            this.tabCourse.TabIndex = 54;
            this.tabCourse.UseWaitCursor = true;
            this.tabCourse.SelectedIndexChanged += new System.EventHandler(this.tabCourse_SelectedIndexChanged);
            // 
            // tabDisplay
            // 
            this.tabDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabDisplay.Controls.Add(this.btnHomeDelete);
            this.tabDisplay.Controls.Add(this.lblDisplayCourses);
            this.tabDisplay.Controls.Add(this.lblSearchCourseDesc);
            this.tabDisplay.Controls.Add(this.txtSearchCourseDesc);
            this.tabDisplay.Controls.Add(this.dgvCourses);
            this.tabDisplay.ImageIndex = 1;
            this.tabDisplay.Location = new System.Drawing.Point(54, 4);
            this.tabDisplay.Name = "tabDisplay";
            this.tabDisplay.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabDisplay.Size = new System.Drawing.Size(1170, 561);
            this.tabDisplay.TabIndex = 0;
            this.tabDisplay.UseVisualStyleBackColor = true;
            this.tabDisplay.UseWaitCursor = true;
            // 
            // btnHomeDelete
            // 
            this.btnHomeDelete.ImageList = this.ILCourses;
            this.btnHomeDelete.Location = new System.Drawing.Point(539, 43);
            this.btnHomeDelete.Name = "btnHomeDelete";
            this.btnHomeDelete.Size = new System.Drawing.Size(160, 50);
            this.btnHomeDelete.TabIndex = 76;
            this.btnHomeDelete.Text = "Delete";
            this.btnHomeDelete.UseVisualStyleBackColor = true;
            this.btnHomeDelete.UseWaitCursor = true;
            this.btnHomeDelete.Click += new System.EventHandler(this.btnHomeDelete_Click);
            this.btnHomeDelete.MouseEnter += new System.EventHandler(this.btnHomeDelete_MouseEnter);
            this.btnHomeDelete.MouseLeave += new System.EventHandler(this.btnHomeDelete_MouseLeave);
            // 
            // lblDisplayCourses
            // 
            this.lblDisplayCourses.AutoSize = true;
            this.lblDisplayCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayCourses.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDisplayCourses.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDisplayCourses.ImageIndex = 0;
            this.lblDisplayCourses.ImageList = this.ILCourses;
            this.lblDisplayCourses.Location = new System.Drawing.Point(16, 15);
            this.lblDisplayCourses.Name = "lblDisplayCourses";
            this.lblDisplayCourses.Size = new System.Drawing.Size(260, 31);
            this.lblDisplayCourses.TabIndex = 75;
            this.lblDisplayCourses.Text = "Display Courses    ";
            this.lblDisplayCourses.UseWaitCursor = true;
            // 
            // lblSearchCourseDesc
            // 
            this.lblSearchCourseDesc.AutoSize = true;
            this.lblSearchCourseDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchCourseDesc.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSearchCourseDesc.Location = new System.Drawing.Point(22, 67);
            this.lblSearchCourseDesc.Name = "lblSearchCourseDesc";
            this.lblSearchCourseDesc.Size = new System.Drawing.Size(189, 24);
            this.lblSearchCourseDesc.TabIndex = 74;
            this.lblSearchCourseDesc.Text = "Search Course Desc:";
            this.lblSearchCourseDesc.UseWaitCursor = true;
            // 
            // txtSearchCourseDesc
            // 
            this.txtSearchCourseDesc.Location = new System.Drawing.Point(227, 64);
            this.txtSearchCourseDesc.Name = "txtSearchCourseDesc";
            this.txtSearchCourseDesc.Size = new System.Drawing.Size(190, 29);
            this.txtSearchCourseDesc.TabIndex = 73;
            this.txtSearchCourseDesc.UseWaitCursor = true;
            this.txtSearchCourseDesc.TextChanged += new System.EventHandler(this.txtSearchStockID_TextChanged);
            // 
            // dgvCourses
            // 
            this.dgvCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Location = new System.Drawing.Point(22, 102);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.RowHeadersWidth = 51;
            this.dgvCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourses.Size = new System.Drawing.Size(979, 450);
            this.dgvCourses.TabIndex = 0;
            this.dgvCourses.UseWaitCursor = true;
            // 
            // tabAdd
            // 
            this.tabAdd.BackColor = System.Drawing.Color.Transparent;
            this.tabAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabAdd.Controls.Add(this.txtAddHoursPerDay);
            this.tabAdd.Controls.Add(this.lblAddHoursPerDay);
            this.tabAdd.Controls.Add(this.cmbAddCourseTypeID);
            this.tabAdd.Controls.Add(this.lblAddCCourseTypeID);
            this.tabAdd.Controls.Add(this.lblAddAddCourseID);
            this.tabAdd.Controls.Add(this.lblAddCourseID);
            this.tabAdd.Controls.Add(this.btnCAddCancel);
            this.tabAdd.Controls.Add(this.btnCAddAdd);
            this.tabAdd.Controls.Add(this.txtAddCCourseNoPatients);
            this.tabAdd.Controls.Add(this.txtAddCCoursePrice);
            this.tabAdd.Controls.Add(this.txtAddCNoDays);
            this.tabAdd.Controls.Add(this.txtAddCCourseDesc);
            this.tabAdd.Controls.Add(this.lblAddCCourseNoPatients);
            this.tabAdd.Controls.Add(this.lblAddCCoursePrice);
            this.tabAdd.Controls.Add(this.lblAddCCourseNoDays);
            this.tabAdd.Controls.Add(this.lblAddCCourseDesc);
            this.tabAdd.Controls.Add(this.lblAddHeader);
            this.tabAdd.ImageIndex = 2;
            this.tabAdd.Location = new System.Drawing.Point(54, 4);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabAdd.Size = new System.Drawing.Size(1170, 561);
            this.tabAdd.TabIndex = 1;
            this.tabAdd.UseWaitCursor = true;
            // 
            // txtAddHoursPerDay
            // 
            this.txtAddHoursPerDay.Location = new System.Drawing.Point(263, 259);
            this.txtAddHoursPerDay.Name = "txtAddHoursPerDay";
            this.txtAddHoursPerDay.Size = new System.Drawing.Size(47, 29);
            this.txtAddHoursPerDay.TabIndex = 20;
            this.txtAddHoursPerDay.UseWaitCursor = true;
            // 
            // lblAddHoursPerDay
            // 
            this.lblAddHoursPerDay.AutoSize = true;
            this.lblAddHoursPerDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblAddHoursPerDay.Location = new System.Drawing.Point(26, 262);
            this.lblAddHoursPerDay.Name = "lblAddHoursPerDay";
            this.lblAddHoursPerDay.Size = new System.Drawing.Size(155, 26);
            this.lblAddHoursPerDay.TabIndex = 19;
            this.lblAddHoursPerDay.Text = "Hours Per Day";
            this.lblAddHoursPerDay.UseWaitCursor = true;
            // 
            // cmbAddCourseTypeID
            // 
            this.cmbAddCourseTypeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddCourseTypeID.FormattingEnabled = true;
            this.cmbAddCourseTypeID.Items.AddRange(new object[] {
            "CT1",
            "CT2"});
            this.cmbAddCourseTypeID.Location = new System.Drawing.Point(263, 415);
            this.cmbAddCourseTypeID.Name = "cmbAddCourseTypeID";
            this.cmbAddCourseTypeID.Size = new System.Drawing.Size(121, 32);
            this.cmbAddCourseTypeID.TabIndex = 18;
            this.cmbAddCourseTypeID.UseWaitCursor = true;
            // 
            // lblAddCCourseTypeID
            // 
            this.lblAddCCourseTypeID.AutoSize = true;
            this.lblAddCCourseTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblAddCCourseTypeID.Location = new System.Drawing.Point(23, 419);
            this.lblAddCCourseTypeID.Name = "lblAddCCourseTypeID";
            this.lblAddCCourseTypeID.Size = new System.Drawing.Size(163, 26);
            this.lblAddCCourseTypeID.TabIndex = 17;
            this.lblAddCCourseTypeID.Text = "Course Type ID";
            this.lblAddCCourseTypeID.UseWaitCursor = true;
            // 
            // lblAddAddCourseID
            // 
            this.lblAddAddCourseID.AutoSize = true;
            this.lblAddAddCourseID.Location = new System.Drawing.Point(262, 99);
            this.lblAddAddCourseID.Name = "lblAddAddCourseID";
            this.lblAddAddCourseID.Size = new System.Drawing.Size(16, 24);
            this.lblAddAddCourseID.TabIndex = 16;
            this.lblAddAddCourseID.Text = "-";
            this.lblAddAddCourseID.UseWaitCursor = true;
            // 
            // lblAddCourseID
            // 
            this.lblAddCourseID.AutoSize = true;
            this.lblAddCourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblAddCourseID.Location = new System.Drawing.Point(26, 99);
            this.lblAddCourseID.Name = "lblAddCourseID";
            this.lblAddCourseID.Size = new System.Drawing.Size(110, 26);
            this.lblAddCourseID.TabIndex = 15;
            this.lblAddCourseID.Text = "Course ID";
            this.lblAddCourseID.UseWaitCursor = true;
            // 
            // btnCAddCancel
            // 
            this.btnCAddCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCAddCancel.ImageList = this.ILCourses;
            this.btnCAddCancel.Location = new System.Drawing.Point(866, 248);
            this.btnCAddCancel.Name = "btnCAddCancel";
            this.btnCAddCancel.Size = new System.Drawing.Size(101, 55);
            this.btnCAddCancel.TabIndex = 12;
            this.btnCAddCancel.Text = "Cancel";
            this.btnCAddCancel.UseVisualStyleBackColor = true;
            this.btnCAddCancel.UseWaitCursor = true;
            this.btnCAddCancel.Click += new System.EventHandler(this.btnCAddCancel_Click);
            this.btnCAddCancel.MouseEnter += new System.EventHandler(this.btnCAddCancel_MouseEnter);
            this.btnCAddCancel.MouseLeave += new System.EventHandler(this.btnCAddCancel_MouseLeave);
            // 
            // btnCAddAdd
            // 
            this.btnCAddAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCAddAdd.ImageList = this.ILCourses;
            this.btnCAddAdd.Location = new System.Drawing.Point(866, 158);
            this.btnCAddAdd.Name = "btnCAddAdd";
            this.btnCAddAdd.Size = new System.Drawing.Size(101, 60);
            this.btnCAddAdd.TabIndex = 11;
            this.btnCAddAdd.Text = "Add";
            this.btnCAddAdd.UseVisualStyleBackColor = true;
            this.btnCAddAdd.UseWaitCursor = true;
            this.btnCAddAdd.Click += new System.EventHandler(this.btnCAddAdd_Click);
            this.btnCAddAdd.MouseEnter += new System.EventHandler(this.btnCAddAdd_MouseEnter);
            this.btnCAddAdd.MouseLeave += new System.EventHandler(this.btnCAddAdd_MouseLeave);
            // 
            // txtAddCCourseNoPatients
            // 
            this.txtAddCCourseNoPatients.Location = new System.Drawing.Point(263, 359);
            this.txtAddCCourseNoPatients.Name = "txtAddCCourseNoPatients";
            this.txtAddCCourseNoPatients.Size = new System.Drawing.Size(47, 29);
            this.txtAddCCourseNoPatients.TabIndex = 9;
            this.txtAddCCourseNoPatients.UseWaitCursor = true;
            // 
            // txtAddCCoursePrice
            // 
            this.txtAddCCoursePrice.Location = new System.Drawing.Point(263, 309);
            this.txtAddCCoursePrice.Name = "txtAddCCoursePrice";
            this.txtAddCCoursePrice.Size = new System.Drawing.Size(102, 29);
            this.txtAddCCoursePrice.TabIndex = 8;
            this.txtAddCCoursePrice.UseWaitCursor = true;
            // 
            // txtAddCNoDays
            // 
            this.txtAddCNoDays.Location = new System.Drawing.Point(263, 210);
            this.txtAddCNoDays.Name = "txtAddCNoDays";
            this.txtAddCNoDays.Size = new System.Drawing.Size(47, 29);
            this.txtAddCNoDays.TabIndex = 7;
            this.txtAddCNoDays.UseWaitCursor = true;
            // 
            // txtAddCCourseDesc
            // 
            this.txtAddCCourseDesc.Location = new System.Drawing.Point(263, 154);
            this.txtAddCCourseDesc.Name = "txtAddCCourseDesc";
            this.txtAddCCourseDesc.Size = new System.Drawing.Size(292, 29);
            this.txtAddCCourseDesc.TabIndex = 6;
            this.txtAddCCourseDesc.UseWaitCursor = true;
            // 
            // lblAddCCourseNoPatients
            // 
            this.lblAddCCourseNoPatients.AutoSize = true;
            this.lblAddCCourseNoPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblAddCCourseNoPatients.Location = new System.Drawing.Point(23, 363);
            this.lblAddCCourseNoPatients.Name = "lblAddCCourseNoPatients";
            this.lblAddCCourseNoPatients.Size = new System.Drawing.Size(125, 26);
            this.lblAddCCourseNoPatients.TabIndex = 4;
            this.lblAddCCourseNoPatients.Text = "No Patients";
            this.lblAddCCourseNoPatients.UseWaitCursor = true;
            // 
            // lblAddCCoursePrice
            // 
            this.lblAddCCoursePrice.AutoSize = true;
            this.lblAddCCoursePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblAddCCoursePrice.Location = new System.Drawing.Point(24, 311);
            this.lblAddCCoursePrice.Name = "lblAddCCoursePrice";
            this.lblAddCCoursePrice.Size = new System.Drawing.Size(138, 26);
            this.lblAddCCoursePrice.TabIndex = 3;
            this.lblAddCCoursePrice.Text = "Course Price";
            this.lblAddCCoursePrice.UseWaitCursor = true;
            // 
            // lblAddCCourseNoDays
            // 
            this.lblAddCCourseNoDays.AutoSize = true;
            this.lblAddCCourseNoDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblAddCCourseNoDays.Location = new System.Drawing.Point(25, 214);
            this.lblAddCCourseNoDays.Name = "lblAddCCourseNoDays";
            this.lblAddCCourseNoDays.Size = new System.Drawing.Size(125, 26);
            this.lblAddCCourseNoDays.TabIndex = 2;
            this.lblAddCCourseNoDays.Text = "No Of Days";
            this.lblAddCCourseNoDays.UseWaitCursor = true;
            // 
            // lblAddCCourseDesc
            // 
            this.lblAddCCourseDesc.AutoSize = true;
            this.lblAddCCourseDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblAddCCourseDesc.Location = new System.Drawing.Point(25, 158);
            this.lblAddCCourseDesc.Name = "lblAddCCourseDesc";
            this.lblAddCCourseDesc.Size = new System.Drawing.Size(138, 26);
            this.lblAddCCourseDesc.TabIndex = 1;
            this.lblAddCCourseDesc.Text = "Course Desc";
            this.lblAddCCourseDesc.UseWaitCursor = true;
            // 
            // lblAddHeader
            // 
            this.lblAddHeader.AutoSize = true;
            this.lblAddHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAddHeader.ImageIndex = 2;
            this.lblAddHeader.ImageList = this.ILCourses;
            this.lblAddHeader.Location = new System.Drawing.Point(24, 16);
            this.lblAddHeader.Name = "lblAddHeader";
            this.lblAddHeader.Size = new System.Drawing.Size(207, 31);
            this.lblAddHeader.TabIndex = 0;
            this.lblAddHeader.Text = "Add Course     ";
            this.lblAddHeader.UseWaitCursor = true;
            // 
            // tabEdit
            // 
            this.tabEdit.BackColor = System.Drawing.Color.Transparent;
            this.tabEdit.Controls.Add(this.txtEditHoursPerDay);
            this.tabEdit.Controls.Add(this.label1);
            this.tabEdit.Controls.Add(this.cmbEditCourseType);
            this.tabEdit.Controls.Add(this.lblEditHeader);
            this.tabEdit.Controls.Add(this.lblEditCCourseTypeID);
            this.tabEdit.Controls.Add(this.lblEditEditCourseID);
            this.tabEdit.Controls.Add(this.lblCEditCourseID);
            this.tabEdit.Controls.Add(this.txtEditCCourseNoPatients);
            this.tabEdit.Controls.Add(this.txtEditCCoursePrice);
            this.tabEdit.Controls.Add(this.txtEditCNoDays);
            this.tabEdit.Controls.Add(this.txtCEditCourseDesc);
            this.tabEdit.Controls.Add(this.lblEditCCourseNoPatients);
            this.tabEdit.Controls.Add(this.lblEditCCoursePrice);
            this.tabEdit.Controls.Add(this.lblEditCNoDays);
            this.tabEdit.Controls.Add(this.lblEditCCourseDesc);
            this.tabEdit.Controls.Add(this.btnCEditCancel);
            this.tabEdit.Controls.Add(this.btnCEditEdit);
            this.tabEdit.ImageIndex = 3;
            this.tabEdit.Location = new System.Drawing.Point(54, 4);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabEdit.Size = new System.Drawing.Size(1170, 561);
            this.tabEdit.TabIndex = 2;
            this.tabEdit.UseWaitCursor = true;
            // 
            // txtEditHoursPerDay
            // 
            this.txtEditHoursPerDay.Enabled = false;
            this.txtEditHoursPerDay.Location = new System.Drawing.Point(263, 262);
            this.txtEditHoursPerDay.Name = "txtEditHoursPerDay";
            this.txtEditHoursPerDay.Size = new System.Drawing.Size(102, 29);
            this.txtEditHoursPerDay.TabIndex = 45;
            this.txtEditHoursPerDay.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(26, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 26);
            this.label1.TabIndex = 44;
            this.label1.Text = "Hours Per Day";
            this.label1.UseWaitCursor = true;
            // 
            // cmbEditCourseType
            // 
            this.cmbEditCourseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditCourseType.Enabled = false;
            this.cmbEditCourseType.FormattingEnabled = true;
            this.cmbEditCourseType.Items.AddRange(new object[] {
            "CT1",
            "CT2"});
            this.cmbEditCourseType.Location = new System.Drawing.Point(263, 406);
            this.cmbEditCourseType.Name = "cmbEditCourseType";
            this.cmbEditCourseType.Size = new System.Drawing.Size(121, 32);
            this.cmbEditCourseType.TabIndex = 43;
            this.cmbEditCourseType.UseWaitCursor = true;
            // 
            // lblEditHeader
            // 
            this.lblEditHeader.AutoSize = true;
            this.lblEditHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEditHeader.ImageIndex = 3;
            this.lblEditHeader.ImageList = this.ILCourses;
            this.lblEditHeader.Location = new System.Drawing.Point(24, 16);
            this.lblEditHeader.Name = "lblEditHeader";
            this.lblEditHeader.Size = new System.Drawing.Size(215, 31);
            this.lblEditHeader.TabIndex = 42;
            this.lblEditHeader.Text = "Edit Course      ";
            this.lblEditHeader.UseWaitCursor = true;
            // 
            // lblEditCCourseTypeID
            // 
            this.lblEditCCourseTypeID.AutoSize = true;
            this.lblEditCCourseTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblEditCCourseTypeID.Location = new System.Drawing.Point(26, 410);
            this.lblEditCCourseTypeID.Name = "lblEditCCourseTypeID";
            this.lblEditCCourseTypeID.Size = new System.Drawing.Size(163, 26);
            this.lblEditCCourseTypeID.TabIndex = 40;
            this.lblEditCCourseTypeID.Text = "Course Type ID";
            this.lblEditCCourseTypeID.UseWaitCursor = true;
            // 
            // lblEditEditCourseID
            // 
            this.lblEditEditCourseID.AutoSize = true;
            this.lblEditEditCourseID.Location = new System.Drawing.Point(262, 99);
            this.lblEditEditCourseID.Name = "lblEditEditCourseID";
            this.lblEditEditCourseID.Size = new System.Drawing.Size(16, 24);
            this.lblEditEditCourseID.TabIndex = 39;
            this.lblEditEditCourseID.Text = "-";
            this.lblEditEditCourseID.UseWaitCursor = true;
            // 
            // lblCEditCourseID
            // 
            this.lblCEditCourseID.AutoSize = true;
            this.lblCEditCourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblCEditCourseID.Location = new System.Drawing.Point(26, 99);
            this.lblCEditCourseID.Name = "lblCEditCourseID";
            this.lblCEditCourseID.Size = new System.Drawing.Size(110, 26);
            this.lblCEditCourseID.TabIndex = 38;
            this.lblCEditCourseID.Text = "Course ID";
            this.lblCEditCourseID.UseWaitCursor = true;
            // 
            // txtEditCCourseNoPatients
            // 
            this.txtEditCCourseNoPatients.Enabled = false;
            this.txtEditCCourseNoPatients.Location = new System.Drawing.Point(263, 355);
            this.txtEditCCourseNoPatients.Name = "txtEditCCourseNoPatients";
            this.txtEditCCourseNoPatients.Size = new System.Drawing.Size(47, 29);
            this.txtEditCCourseNoPatients.TabIndex = 37;
            this.txtEditCCourseNoPatients.UseWaitCursor = true;
            // 
            // txtEditCCoursePrice
            // 
            this.txtEditCCoursePrice.Enabled = false;
            this.txtEditCCoursePrice.Location = new System.Drawing.Point(263, 309);
            this.txtEditCCoursePrice.Name = "txtEditCCoursePrice";
            this.txtEditCCoursePrice.Size = new System.Drawing.Size(102, 29);
            this.txtEditCCoursePrice.TabIndex = 36;
            this.txtEditCCoursePrice.UseWaitCursor = true;
            // 
            // txtEditCNoDays
            // 
            this.txtEditCNoDays.Enabled = false;
            this.txtEditCNoDays.Location = new System.Drawing.Point(263, 210);
            this.txtEditCNoDays.Name = "txtEditCNoDays";
            this.txtEditCNoDays.Size = new System.Drawing.Size(47, 29);
            this.txtEditCNoDays.TabIndex = 35;
            this.txtEditCNoDays.UseWaitCursor = true;
            // 
            // txtCEditCourseDesc
            // 
            this.txtCEditCourseDesc.Enabled = false;
            this.txtCEditCourseDesc.Location = new System.Drawing.Point(263, 154);
            this.txtCEditCourseDesc.Name = "txtCEditCourseDesc";
            this.txtCEditCourseDesc.Size = new System.Drawing.Size(292, 29);
            this.txtCEditCourseDesc.TabIndex = 34;
            this.txtCEditCourseDesc.UseWaitCursor = true;
            // 
            // lblEditCCourseNoPatients
            // 
            this.lblEditCCourseNoPatients.AutoSize = true;
            this.lblEditCCourseNoPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblEditCCourseNoPatients.Location = new System.Drawing.Point(26, 360);
            this.lblEditCCourseNoPatients.Name = "lblEditCCourseNoPatients";
            this.lblEditCCourseNoPatients.Size = new System.Drawing.Size(201, 26);
            this.lblEditCCourseNoPatients.TabIndex = 33;
            this.lblEditCCourseNoPatients.Text = "Course No Patients";
            this.lblEditCCourseNoPatients.UseWaitCursor = true;
            // 
            // lblEditCCoursePrice
            // 
            this.lblEditCCoursePrice.AutoSize = true;
            this.lblEditCCoursePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblEditCCoursePrice.Location = new System.Drawing.Point(26, 313);
            this.lblEditCCoursePrice.Name = "lblEditCCoursePrice";
            this.lblEditCCoursePrice.Size = new System.Drawing.Size(138, 26);
            this.lblEditCCoursePrice.TabIndex = 32;
            this.lblEditCCoursePrice.Text = "Course Price";
            this.lblEditCCoursePrice.UseWaitCursor = true;
            // 
            // lblEditCNoDays
            // 
            this.lblEditCNoDays.AutoSize = true;
            this.lblEditCNoDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblEditCNoDays.Location = new System.Drawing.Point(26, 215);
            this.lblEditCNoDays.Name = "lblEditCNoDays";
            this.lblEditCNoDays.Size = new System.Drawing.Size(125, 26);
            this.lblEditCNoDays.TabIndex = 31;
            this.lblEditCNoDays.Text = "No Of Days";
            this.lblEditCNoDays.UseWaitCursor = true;
            // 
            // lblEditCCourseDesc
            // 
            this.lblEditCCourseDesc.AutoSize = true;
            this.lblEditCCourseDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblEditCCourseDesc.Location = new System.Drawing.Point(26, 159);
            this.lblEditCCourseDesc.Name = "lblEditCCourseDesc";
            this.lblEditCCourseDesc.Size = new System.Drawing.Size(138, 26);
            this.lblEditCCourseDesc.TabIndex = 30;
            this.lblEditCCourseDesc.Text = "Course Desc";
            this.lblEditCCourseDesc.UseWaitCursor = true;
            // 
            // btnCEditCancel
            // 
            this.btnCEditCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCEditCancel.ImageList = this.ILCourses;
            this.btnCEditCancel.Location = new System.Drawing.Point(866, 239);
            this.btnCEditCancel.Name = "btnCEditCancel";
            this.btnCEditCancel.Size = new System.Drawing.Size(113, 53);
            this.btnCEditCancel.TabIndex = 27;
            this.btnCEditCancel.Text = "Cancel";
            this.btnCEditCancel.UseVisualStyleBackColor = true;
            this.btnCEditCancel.UseWaitCursor = true;
            this.btnCEditCancel.MouseEnter += new System.EventHandler(this.btnCEditCancel_MouseEnter);
            this.btnCEditCancel.MouseLeave += new System.EventHandler(this.btnCEditCancel_MouseLeave);
            // 
            // btnCEditEdit
            // 
            this.btnCEditEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCEditEdit.Location = new System.Drawing.Point(866, 172);
            this.btnCEditEdit.Name = "btnCEditEdit";
            this.btnCEditEdit.Size = new System.Drawing.Size(113, 46);
            this.btnCEditEdit.TabIndex = 26;
            this.btnCEditEdit.Text = "Edit";
            this.btnCEditEdit.UseVisualStyleBackColor = true;
            this.btnCEditEdit.UseWaitCursor = true;
            this.btnCEditEdit.Click += new System.EventHandler(this.btnCEditEdit_Click);
            // 
            // btnGenerateCourseReport
            // 
            this.btnGenerateCourseReport.Location = new System.Drawing.Point(0, 0);
            this.btnGenerateCourseReport.Name = "btnGenerateCourseReport";
            this.btnGenerateCourseReport.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateCourseReport.TabIndex = 0;
            this.btnGenerateCourseReport.UseWaitCursor = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(15, 71);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(88, 24);
            this.label.TabIndex = 2;
            this.label.Text = "Patient ID";
            this.label.UseWaitCursor = true;
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(19, 115);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(150, 20);
            this.txtPatientID.TabIndex = 1;
            this.txtPatientID.UseWaitCursor = true;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::LloydsPharmacy.Properties.Resources.logo;
            this.pbLogo.Location = new System.Drawing.Point(20, 43);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(409, 76);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 51;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // tabPatientCourse
            // 
            this.tabPatientCourse.Controls.Add(this.btnSubmitReport);
            this.tabPatientCourse.Controls.Add(this.txtPatientCourse);
            this.tabPatientCourse.Controls.Add(this.label2);
           // this.tabPatientCourse.Controls.Add(this.crystalReportViewer2);
            this.tabPatientCourse.ImageIndex = 4;
            this.tabPatientCourse.Location = new System.Drawing.Point(54, 4);
            this.tabPatientCourse.Name = "tabPatientCourse";
            this.tabPatientCourse.Padding = new System.Windows.Forms.Padding(3);
            this.tabPatientCourse.Size = new System.Drawing.Size(1170, 561);
            this.tabPatientCourse.TabIndex = 3;
            this.tabPatientCourse.UseVisualStyleBackColor = true;
            // 
            // crystalReportViewer2
            // 
            /*this.crystalReportViewer2.ActiveViewIndex = -1;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer2.Location = new System.Drawing.Point(3, 3);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.Size = new System.Drawing.Size(1164, 555);
            this.crystalReportViewer2.TabIndex = 0;*/
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 55;
            this.label2.Text = "PatientID";
            // 
            // txtPatientCourse
            // 
            this.txtPatientCourse.Location = new System.Drawing.Point(42, 127);
            this.txtPatientCourse.Name = "txtPatientCourse";
            this.txtPatientCourse.Size = new System.Drawing.Size(100, 29);
            this.txtPatientCourse.TabIndex = 55;
            // 
            // btnSubmitReport
            // 
            this.btnSubmitReport.Location = new System.Drawing.Point(42, 188);
            this.btnSubmitReport.Name = "btnSubmitReport";
            this.btnSubmitReport.Size = new System.Drawing.Size(101, 40);
            this.btnSubmitReport.TabIndex = 55;
            this.btnSubmitReport.Text = "Submit";
            this.btnSubmitReport.UseVisualStyleBackColor = true;
            this.btnSubmitReport.Click += new System.EventHandler(this.btnSubmitReport_Click);
            // 
            // frmCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1268, 776);
            this.Controls.Add(this.PBIcon);
            this.Controls.Add(this.lblCourses);
            this.Controls.Add(this.tabCourse);
            this.Controls.Add(this.pbLogo);
            this.Name = "frmCourses";
            this.Text = "frmCourses";
            this.Load += new System.EventHandler(this.frmCourses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBIcon)).EndInit();
            this.tabCourse.ResumeLayout(false);
            this.tabDisplay.ResumeLayout(false);
            this.tabDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            this.tabEdit.ResumeLayout(false);
            this.tabEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.tabPatientCourse.ResumeLayout(false);
            this.tabPatientCourse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList ILCourses;
        private System.Windows.Forms.ErrorProvider errP;
        private System.Windows.Forms.PictureBox PBIcon;
        private System.Windows.Forms.Label lblCourses;
        private System.Windows.Forms.TabControl tabCourse;
        private System.Windows.Forms.TabPage tabDisplay;
        private System.Windows.Forms.Button btnHomeDelete;
        private System.Windows.Forms.Label lblDisplayCourses;
        private System.Windows.Forms.Label lblSearchCourseDesc;
        private System.Windows.Forms.TextBox txtSearchCourseDesc;
        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.TextBox txtAddHoursPerDay;
        private System.Windows.Forms.Label lblAddHoursPerDay;
        private System.Windows.Forms.ComboBox cmbAddCourseTypeID;
        private System.Windows.Forms.Label lblAddCCourseTypeID;
        private System.Windows.Forms.Label lblAddAddCourseID;
        private System.Windows.Forms.Label lblAddCourseID;
        private System.Windows.Forms.Button btnCAddCancel;
        private System.Windows.Forms.Button btnCAddAdd;
        private System.Windows.Forms.TextBox txtAddCCourseNoPatients;
        private System.Windows.Forms.TextBox txtAddCCoursePrice;
        private System.Windows.Forms.TextBox txtAddCNoDays;
        private System.Windows.Forms.TextBox txtAddCCourseDesc;
        private System.Windows.Forms.Label lblAddCCourseNoPatients;
        private System.Windows.Forms.Label lblAddCCoursePrice;
        private System.Windows.Forms.Label lblAddCCourseNoDays;
        private System.Windows.Forms.Label lblAddCCourseDesc;
        private System.Windows.Forms.Label lblAddHeader;
        private System.Windows.Forms.TabPage tabEdit;
        private System.Windows.Forms.TextBox txtEditHoursPerDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEditCourseType;
        private System.Windows.Forms.Label lblEditHeader;
        private System.Windows.Forms.Label lblEditCCourseTypeID;
        private System.Windows.Forms.Label lblEditEditCourseID;
        private System.Windows.Forms.Label lblCEditCourseID;
        private System.Windows.Forms.TextBox txtEditCCourseNoPatients;
        private System.Windows.Forms.TextBox txtEditCCoursePrice;
        private System.Windows.Forms.TextBox txtEditCNoDays;
        private System.Windows.Forms.TextBox txtCEditCourseDesc;
        private System.Windows.Forms.Label lblEditCCourseNoPatients;
        private System.Windows.Forms.Label lblEditCCoursePrice;
        private System.Windows.Forms.Label lblEditCNoDays;
        private System.Windows.Forms.Label lblEditCCourseDesc;
        private System.Windows.Forms.Button btnCEditCancel;
        private System.Windows.Forms.Button btnCEditEdit;
        private System.Windows.Forms.TabPage tabReport;
        private System.Windows.Forms.Button btnGenerateCourseReport;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtPatientID;
       // private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TabPage tabPatientCourse;
        private System.Windows.Forms.TextBox txtPatientCourse;
        private System.Windows.Forms.Label label2;
        //private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private System.Windows.Forms.Button btnSubmitReport;
    }
}