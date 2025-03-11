namespace LloydsPharmacy
{
    partial class frmPatients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatients));
            this.ILPatients = new System.Windows.Forms.ImageList(this.components);
            this.errProPatients = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblBacktoMenu = new System.Windows.Forms.Label();
            this.lblPatients = new System.Windows.Forms.Label();
            this.tabPatients = new System.Windows.Forms.TabControl();
            this.tabDisplay = new System.Windows.Forms.TabPage();
            this.lblDisplayPatients = new System.Windows.Forms.Label();
            this.lblSearchPatient = new System.Windows.Forms.Label();
            this.txtSearchPatient = new System.Windows.Forms.TextBox();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.lblAddPatID = new System.Windows.Forms.Label();
            this.lblAddPatientID = new System.Windows.Forms.Label();
            this.txtAddPostcode = new System.Windows.Forms.TextBox();
            this.lblAddPPostcode = new System.Windows.Forms.Label();
            this.txtAddEmail = new System.Windows.Forms.TextBox();
            this.lblAddPEmail = new System.Windows.Forms.Label();
            this.txtAddTelNo = new System.Windows.Forms.TextBox();
            this.lblAddPTelNo = new System.Windows.Forms.Label();
            this.btnCancelAddPat = new System.Windows.Forms.Button();
            this.btnAddPat = new System.Windows.Forms.Button();
            this.txtAddCounty = new System.Windows.Forms.TextBox();
            this.txtAddStreet = new System.Windows.Forms.TextBox();
            this.txtAddTown = new System.Windows.Forms.TextBox();
            this.txtAddSurname = new System.Windows.Forms.TextBox();
            this.txtAddForename = new System.Windows.Forms.TextBox();
            this.lblAddPCounty = new System.Windows.Forms.Label();
            this.lblAddPStreet = new System.Windows.Forms.Label();
            this.lblAddPTown = new System.Windows.Forms.Label();
            this.lblAddPSurname = new System.Windows.Forms.Label();
            this.lblAddPForename = new System.Windows.Forms.Label();
            this.lblAddPatients = new System.Windows.Forms.Label();
            this.tabEdit = new System.Windows.Forms.TabPage();
            this.btnDelPat = new System.Windows.Forms.Button();
            this.lblEditPatID = new System.Windows.Forms.Label();
            this.lblEditID = new System.Windows.Forms.Label();
            this.txtEditPostcode = new System.Windows.Forms.TextBox();
            this.lblEditPostcode = new System.Windows.Forms.Label();
            this.txtEditEmail = new System.Windows.Forms.TextBox();
            this.lblEditEmail = new System.Windows.Forms.Label();
            this.txtEditTelNo = new System.Windows.Forms.TextBox();
            this.lblEditTelNo = new System.Windows.Forms.Label();
            this.btnCancelEditPat = new System.Windows.Forms.Button();
            this.btnEditPat = new System.Windows.Forms.Button();
            this.txtEditCounty = new System.Windows.Forms.TextBox();
            this.txtEditStreet = new System.Windows.Forms.TextBox();
            this.txtEditTown = new System.Windows.Forms.TextBox();
            this.txtEditSurname = new System.Windows.Forms.TextBox();
            this.txtEditForename = new System.Windows.Forms.TextBox();
            this.lblEditCounty = new System.Windows.Forms.Label();
            this.lblEditStreet = new System.Windows.Forms.Label();
            this.lblEditTown = new System.Windows.Forms.Label();
            this.lblEditSurname = new System.Windows.Forms.Label();
            this.lblEditForename = new System.Windows.Forms.Label();
            this.lblEditPatients = new System.Windows.Forms.Label();
            this.tabReport = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.picArrow = new System.Windows.Forms.PictureBox();
            this.PBIcon = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errProPatients)).BeginInit();
            this.tabPatients.SuspendLayout();
            this.tabDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.tabAdd.SuspendLayout();
            this.tabEdit.SuspendLayout();
            this.tabReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // ILPatients
            // 
            this.ILPatients.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ILPatients.ImageStream")));
            this.ILPatients.TransparentColor = System.Drawing.Color.Transparent;
            this.ILPatients.Images.SetKeyName(0, "patient.png");
            this.ILPatients.Images.SetKeyName(1, "display paitent.png");
            this.ILPatients.Images.SetKeyName(2, "add patient.png");
            this.ILPatients.Images.SetKeyName(3, "edit patient.png");
            this.ILPatients.Images.SetKeyName(4, "report.png");
            this.ILPatients.Images.SetKeyName(5, "up-arrow.png");
            this.ILPatients.Images.SetKeyName(6, "plus.png");
            this.ILPatients.Images.SetKeyName(7, "pencil.png");
            this.ILPatients.Images.SetKeyName(8, "trash.png");
            this.ILPatients.Images.SetKeyName(9, "cancel.png");
            // 
            // errProPatients
            // 
            this.errProPatients.ContainerControl = this;
            // 
            // lblBacktoMenu
            // 
            this.lblBacktoMenu.AutoSize = true;
            this.lblBacktoMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBacktoMenu.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblBacktoMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblBacktoMenu.ImageList = this.ILPatients;
            this.lblBacktoMenu.Location = new System.Drawing.Point(122, 115);
            this.lblBacktoMenu.Name = "lblBacktoMenu";
            this.lblBacktoMenu.Size = new System.Drawing.Size(144, 25);
            this.lblBacktoMenu.TabIndex = 62;
            this.lblBacktoMenu.Text = "Back to Menu";
            // 
            // lblPatients
            // 
            this.lblPatients.AutoSize = true;
            this.lblPatients.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatients.Location = new System.Drawing.Point(426, 9);
            this.lblPatients.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPatients.Name = "lblPatients";
            this.lblPatients.Size = new System.Drawing.Size(282, 75);
            this.lblPatients.TabIndex = 60;
            this.lblPatients.Text = "Patients";
            // 
            // tabPatients
            // 
            this.tabPatients.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabPatients.Controls.Add(this.tabDisplay);
            this.tabPatients.Controls.Add(this.tabAdd);
            this.tabPatients.Controls.Add(this.tabEdit);
            this.tabPatients.Controls.Add(this.tabReport);
            this.tabPatients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPatients.ImageList = this.ILPatients;
            this.tabPatients.ItemSize = new System.Drawing.Size(25, 50);
            this.tabPatients.Location = new System.Drawing.Point(12, 156);
            this.tabPatients.Multiline = true;
            this.tabPatients.Name = "tabPatients";
            this.tabPatients.Padding = new System.Drawing.Point(6, 5);
            this.tabPatients.SelectedIndex = 0;
            this.tabPatients.Size = new System.Drawing.Size(1202, 588);
            this.tabPatients.TabIndex = 58;
            this.tabPatients.SelectedIndexChanged += new System.EventHandler(this.tabPatients_SelectedIndexChanged);
            // 
            // tabDisplay
            // 
            this.tabDisplay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabDisplay.Controls.Add(this.lblDisplayPatients);
            this.tabDisplay.Controls.Add(this.lblSearchPatient);
            this.tabDisplay.Controls.Add(this.txtSearchPatient);
            this.tabDisplay.Controls.Add(this.dgvPatients);
            this.tabDisplay.ImageIndex = 1;
            this.tabDisplay.Location = new System.Drawing.Point(54, 4);
            this.tabDisplay.Name = "tabDisplay";
            this.tabDisplay.Padding = new System.Windows.Forms.Padding(3);
            this.tabDisplay.Size = new System.Drawing.Size(1144, 580);
            this.tabDisplay.TabIndex = 0;
            // 
            // lblDisplayPatients
            // 
            this.lblDisplayPatients.AutoSize = true;
            this.lblDisplayPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayPatients.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDisplayPatients.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDisplayPatients.ImageIndex = 1;
            this.lblDisplayPatients.ImageList = this.ILPatients;
            this.lblDisplayPatients.Location = new System.Drawing.Point(44, 24);
            this.lblDisplayPatients.Name = "lblDisplayPatients";
            this.lblDisplayPatients.Size = new System.Drawing.Size(274, 31);
            this.lblDisplayPatients.TabIndex = 73;
            this.lblDisplayPatients.Text = "Display Patients      ";
            // 
            // lblSearchPatient
            // 
            this.lblSearchPatient.AutoSize = true;
            this.lblSearchPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchPatient.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSearchPatient.Location = new System.Drawing.Point(46, 75);
            this.lblSearchPatient.Name = "lblSearchPatient";
            this.lblSearchPatient.Size = new System.Drawing.Size(192, 24);
            this.lblSearchPatient.TabIndex = 46;
            this.lblSearchPatient.Text = "Search Patient Name:";
            // 
            // txtSearchPatient
            // 
            this.txtSearchPatient.Location = new System.Drawing.Point(244, 72);
            this.txtSearchPatient.Name = "txtSearchPatient";
            this.txtSearchPatient.Size = new System.Drawing.Size(190, 29);
            this.txtSearchPatient.TabIndex = 2;
            this.txtSearchPatient.TextChanged += new System.EventHandler(this.txtSearchPatient_TextChanged);
            // 
            // dgvPatients
            // 
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.Location = new System.Drawing.Point(6, 112);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.RowHeadersWidth = 51;
            this.dgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatients.Size = new System.Drawing.Size(1132, 453);
            this.dgvPatients.TabIndex = 3;
            // 
            // tabAdd
            // 
            this.tabAdd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabAdd.Controls.Add(this.lblAddPatID);
            this.tabAdd.Controls.Add(this.lblAddPatientID);
            this.tabAdd.Controls.Add(this.txtAddPostcode);
            this.tabAdd.Controls.Add(this.lblAddPPostcode);
            this.tabAdd.Controls.Add(this.txtAddEmail);
            this.tabAdd.Controls.Add(this.lblAddPEmail);
            this.tabAdd.Controls.Add(this.txtAddTelNo);
            this.tabAdd.Controls.Add(this.lblAddPTelNo);
            this.tabAdd.Controls.Add(this.btnCancelAddPat);
            this.tabAdd.Controls.Add(this.btnAddPat);
            this.tabAdd.Controls.Add(this.txtAddCounty);
            this.tabAdd.Controls.Add(this.txtAddStreet);
            this.tabAdd.Controls.Add(this.txtAddTown);
            this.tabAdd.Controls.Add(this.txtAddSurname);
            this.tabAdd.Controls.Add(this.txtAddForename);
            this.tabAdd.Controls.Add(this.lblAddPCounty);
            this.tabAdd.Controls.Add(this.lblAddPStreet);
            this.tabAdd.Controls.Add(this.lblAddPTown);
            this.tabAdd.Controls.Add(this.lblAddPSurname);
            this.tabAdd.Controls.Add(this.lblAddPForename);
            this.tabAdd.Controls.Add(this.lblAddPatients);
            this.tabAdd.ImageIndex = 2;
            this.tabAdd.Location = new System.Drawing.Point(54, 4);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(977, 580);
            this.tabAdd.TabIndex = 1;
            // 
            // lblAddPatID
            // 
            this.lblAddPatID.AutoSize = true;
            this.lblAddPatID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPatID.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblAddPatID.Location = new System.Drawing.Point(224, 83);
            this.lblAddPatID.Name = "lblAddPatID";
            this.lblAddPatID.Size = new System.Drawing.Size(17, 24);
            this.lblAddPatID.TabIndex = 45;
            this.lblAddPatID.Text = "-";
            // 
            // lblAddPatientID
            // 
            this.lblAddPatientID.AutoSize = true;
            this.lblAddPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPatientID.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblAddPatientID.Location = new System.Drawing.Point(46, 83);
            this.lblAddPatientID.Name = "lblAddPatientID";
            this.lblAddPatientID.Size = new System.Drawing.Size(88, 24);
            this.lblAddPatientID.TabIndex = 44;
            this.lblAddPatientID.Text = "Patient ID";
            // 
            // txtAddPostcode
            // 
            this.txtAddPostcode.Location = new System.Drawing.Point(228, 480);
            this.txtAddPostcode.Name = "txtAddPostcode";
            this.txtAddPostcode.Size = new System.Drawing.Size(259, 29);
            this.txtAddPostcode.TabIndex = 11;
            // 
            // lblAddPPostcode
            // 
            this.lblAddPPostcode.AutoSize = true;
            this.lblAddPPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPPostcode.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblAddPPostcode.Location = new System.Drawing.Point(46, 483);
            this.lblAddPPostcode.Name = "lblAddPPostcode";
            this.lblAddPPostcode.Size = new System.Drawing.Size(89, 24);
            this.lblAddPPostcode.TabIndex = 42;
            this.lblAddPPostcode.Text = "Postcode";
            // 
            // txtAddEmail
            // 
            this.txtAddEmail.Location = new System.Drawing.Point(228, 280);
            this.txtAddEmail.Name = "txtAddEmail";
            this.txtAddEmail.Size = new System.Drawing.Size(259, 29);
            this.txtAddEmail.TabIndex = 7;
            // 
            // lblAddPEmail
            // 
            this.lblAddPEmail.AutoSize = true;
            this.lblAddPEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPEmail.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblAddPEmail.Location = new System.Drawing.Point(46, 283);
            this.lblAddPEmail.Name = "lblAddPEmail";
            this.lblAddPEmail.Size = new System.Drawing.Size(57, 24);
            this.lblAddPEmail.TabIndex = 40;
            this.lblAddPEmail.Text = "Email";
            // 
            // txtAddTelNo
            // 
            this.txtAddTelNo.Location = new System.Drawing.Point(228, 230);
            this.txtAddTelNo.Name = "txtAddTelNo";
            this.txtAddTelNo.Size = new System.Drawing.Size(259, 29);
            this.txtAddTelNo.TabIndex = 6;
            // 
            // lblAddPTelNo
            // 
            this.lblAddPTelNo.AutoSize = true;
            this.lblAddPTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPTelNo.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblAddPTelNo.Location = new System.Drawing.Point(46, 233);
            this.lblAddPTelNo.Name = "lblAddPTelNo";
            this.lblAddPTelNo.Size = new System.Drawing.Size(72, 24);
            this.lblAddPTelNo.TabIndex = 38;
            this.lblAddPTelNo.Text = "Tel. No";
            // 
            // btnCancelAddPat
            // 
            this.btnCancelAddPat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAddPat.ImageList = this.ILPatients;
            this.btnCancelAddPat.Location = new System.Drawing.Point(780, 310);
            this.btnCancelAddPat.Name = "btnCancelAddPat";
            this.btnCancelAddPat.Size = new System.Drawing.Size(90, 53);
            this.btnCancelAddPat.TabIndex = 13;
            this.btnCancelAddPat.Text = "Cancel";
            this.btnCancelAddPat.UseVisualStyleBackColor = true;
            this.btnCancelAddPat.Click += new System.EventHandler(this.btnCancelAddPat_Click);
            this.btnCancelAddPat.MouseEnter += new System.EventHandler(this.btnCancelAddPat_MouseEnter);
            this.btnCancelAddPat.MouseLeave += new System.EventHandler(this.btnCancelAddPat_MouseLeave);
            // 
            // btnAddPat
            // 
            this.btnAddPat.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddPat.ImageList = this.ILPatients;
            this.btnAddPat.Location = new System.Drawing.Point(780, 230);
            this.btnAddPat.Name = "btnAddPat";
            this.btnAddPat.Size = new System.Drawing.Size(90, 53);
            this.btnAddPat.TabIndex = 12;
            this.btnAddPat.Text = "Add";
            this.btnAddPat.UseVisualStyleBackColor = false;
            this.btnAddPat.Click += new System.EventHandler(this.btnAddPat_Click);
            this.btnAddPat.MouseEnter += new System.EventHandler(this.btnAddPat_MouseEnter);
            this.btnAddPat.MouseLeave += new System.EventHandler(this.btnCancelAddPat_MouseLeave);
            // 
            // txtAddCounty
            // 
            this.txtAddCounty.Location = new System.Drawing.Point(228, 430);
            this.txtAddCounty.Name = "txtAddCounty";
            this.txtAddCounty.Size = new System.Drawing.Size(259, 29);
            this.txtAddCounty.TabIndex = 10;
            // 
            // txtAddStreet
            // 
            this.txtAddStreet.Location = new System.Drawing.Point(228, 330);
            this.txtAddStreet.Name = "txtAddStreet";
            this.txtAddStreet.Size = new System.Drawing.Size(259, 29);
            this.txtAddStreet.TabIndex = 8;
            // 
            // txtAddTown
            // 
            this.txtAddTown.Location = new System.Drawing.Point(228, 380);
            this.txtAddTown.Name = "txtAddTown";
            this.txtAddTown.Size = new System.Drawing.Size(259, 29);
            this.txtAddTown.TabIndex = 9;
            // 
            // txtAddSurname
            // 
            this.txtAddSurname.Location = new System.Drawing.Point(228, 180);
            this.txtAddSurname.Name = "txtAddSurname";
            this.txtAddSurname.Size = new System.Drawing.Size(259, 29);
            this.txtAddSurname.TabIndex = 5;
            // 
            // txtAddForename
            // 
            this.txtAddForename.Location = new System.Drawing.Point(228, 130);
            this.txtAddForename.Name = "txtAddForename";
            this.txtAddForename.Size = new System.Drawing.Size(259, 29);
            this.txtAddForename.TabIndex = 4;
            // 
            // lblAddPCounty
            // 
            this.lblAddPCounty.AutoSize = true;
            this.lblAddPCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPCounty.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblAddPCounty.Location = new System.Drawing.Point(46, 433);
            this.lblAddPCounty.Name = "lblAddPCounty";
            this.lblAddPCounty.Size = new System.Drawing.Size(69, 24);
            this.lblAddPCounty.TabIndex = 28;
            this.lblAddPCounty.Text = "County";
            // 
            // lblAddPStreet
            // 
            this.lblAddPStreet.AutoSize = true;
            this.lblAddPStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPStreet.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblAddPStreet.Location = new System.Drawing.Point(46, 333);
            this.lblAddPStreet.Name = "lblAddPStreet";
            this.lblAddPStreet.Size = new System.Drawing.Size(58, 24);
            this.lblAddPStreet.TabIndex = 27;
            this.lblAddPStreet.Text = "Street";
            // 
            // lblAddPTown
            // 
            this.lblAddPTown.AutoSize = true;
            this.lblAddPTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPTown.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblAddPTown.Location = new System.Drawing.Point(46, 383);
            this.lblAddPTown.Name = "lblAddPTown";
            this.lblAddPTown.Size = new System.Drawing.Size(58, 24);
            this.lblAddPTown.TabIndex = 26;
            this.lblAddPTown.Text = "Town";
            // 
            // lblAddPSurname
            // 
            this.lblAddPSurname.AutoSize = true;
            this.lblAddPSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPSurname.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblAddPSurname.Location = new System.Drawing.Point(46, 183);
            this.lblAddPSurname.Name = "lblAddPSurname";
            this.lblAddPSurname.Size = new System.Drawing.Size(87, 24);
            this.lblAddPSurname.TabIndex = 25;
            this.lblAddPSurname.Text = "Surname";
            // 
            // lblAddPForename
            // 
            this.lblAddPForename.AutoSize = true;
            this.lblAddPForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPForename.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblAddPForename.Location = new System.Drawing.Point(46, 133);
            this.lblAddPForename.Name = "lblAddPForename";
            this.lblAddPForename.Size = new System.Drawing.Size(98, 24);
            this.lblAddPForename.TabIndex = 24;
            this.lblAddPForename.Text = "Forename";
            // 
            // lblAddPatients
            // 
            this.lblAddPatients.AutoSize = true;
            this.lblAddPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPatients.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblAddPatients.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAddPatients.ImageIndex = 2;
            this.lblAddPatients.ImageList = this.ILPatients;
            this.lblAddPatients.Location = new System.Drawing.Point(44, 24);
            this.lblAddPatients.Name = "lblAddPatients";
            this.lblAddPatients.Size = new System.Drawing.Size(294, 31);
            this.lblAddPatients.TabIndex = 23;
            this.lblAddPatients.Text = "Add New Patients      ";
            // 
            // tabEdit
            // 
            this.tabEdit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabEdit.Controls.Add(this.btnDelPat);
            this.tabEdit.Controls.Add(this.lblEditPatID);
            this.tabEdit.Controls.Add(this.lblEditID);
            this.tabEdit.Controls.Add(this.txtEditPostcode);
            this.tabEdit.Controls.Add(this.lblEditPostcode);
            this.tabEdit.Controls.Add(this.txtEditEmail);
            this.tabEdit.Controls.Add(this.lblEditEmail);
            this.tabEdit.Controls.Add(this.txtEditTelNo);
            this.tabEdit.Controls.Add(this.lblEditTelNo);
            this.tabEdit.Controls.Add(this.btnCancelEditPat);
            this.tabEdit.Controls.Add(this.btnEditPat);
            this.tabEdit.Controls.Add(this.txtEditCounty);
            this.tabEdit.Controls.Add(this.txtEditStreet);
            this.tabEdit.Controls.Add(this.txtEditTown);
            this.tabEdit.Controls.Add(this.txtEditSurname);
            this.tabEdit.Controls.Add(this.txtEditForename);
            this.tabEdit.Controls.Add(this.lblEditCounty);
            this.tabEdit.Controls.Add(this.lblEditStreet);
            this.tabEdit.Controls.Add(this.lblEditTown);
            this.tabEdit.Controls.Add(this.lblEditSurname);
            this.tabEdit.Controls.Add(this.lblEditForename);
            this.tabEdit.Controls.Add(this.lblEditPatients);
            this.tabEdit.ImageIndex = 3;
            this.tabEdit.Location = new System.Drawing.Point(54, 4);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabEdit.Size = new System.Drawing.Size(977, 580);
            this.tabEdit.TabIndex = 2;
            // 
            // btnDelPat
            // 
            this.btnDelPat.BackColor = System.Drawing.Color.Transparent;
            this.btnDelPat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelPat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelPat.ImageList = this.ILPatients;
            this.btnDelPat.Location = new System.Drawing.Point(780, 270);
            this.btnDelPat.Name = "btnDelPat";
            this.btnDelPat.Size = new System.Drawing.Size(90, 53);
            this.btnDelPat.TabIndex = 23;
            this.btnDelPat.Text = "Delete";
            this.btnDelPat.UseVisualStyleBackColor = false;
            this.btnDelPat.Click += new System.EventHandler(this.btnDelPat_Click);
            this.btnDelPat.MouseEnter += new System.EventHandler(this.btnDelPat_MouseEnter);
            this.btnDelPat.MouseLeave += new System.EventHandler(this.btnDelPat_MouseLeave);
            // 
            // lblEditPatID
            // 
            this.lblEditPatID.AutoSize = true;
            this.lblEditPatID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditPatID.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblEditPatID.Location = new System.Drawing.Point(224, 83);
            this.lblEditPatID.Name = "lblEditPatID";
            this.lblEditPatID.Size = new System.Drawing.Size(17, 24);
            this.lblEditPatID.TabIndex = 68;
            this.lblEditPatID.Text = "-";
            // 
            // lblEditID
            // 
            this.lblEditID.AutoSize = true;
            this.lblEditID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditID.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblEditID.Location = new System.Drawing.Point(46, 83);
            this.lblEditID.Name = "lblEditID";
            this.lblEditID.Size = new System.Drawing.Size(88, 24);
            this.lblEditID.TabIndex = 67;
            this.lblEditID.Text = "Patient ID";
            // 
            // txtEditPostcode
            // 
            this.txtEditPostcode.Location = new System.Drawing.Point(228, 480);
            this.txtEditPostcode.Name = "txtEditPostcode";
            this.txtEditPostcode.Size = new System.Drawing.Size(259, 29);
            this.txtEditPostcode.TabIndex = 21;
            // 
            // lblEditPostcode
            // 
            this.lblEditPostcode.AutoSize = true;
            this.lblEditPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditPostcode.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblEditPostcode.Location = new System.Drawing.Point(46, 483);
            this.lblEditPostcode.Name = "lblEditPostcode";
            this.lblEditPostcode.Size = new System.Drawing.Size(89, 24);
            this.lblEditPostcode.TabIndex = 65;
            this.lblEditPostcode.Text = "Postcode";
            // 
            // txtEditEmail
            // 
            this.txtEditEmail.Location = new System.Drawing.Point(228, 280);
            this.txtEditEmail.Name = "txtEditEmail";
            this.txtEditEmail.Size = new System.Drawing.Size(259, 29);
            this.txtEditEmail.TabIndex = 17;
            // 
            // lblEditEmail
            // 
            this.lblEditEmail.AutoSize = true;
            this.lblEditEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditEmail.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblEditEmail.Location = new System.Drawing.Point(46, 283);
            this.lblEditEmail.Name = "lblEditEmail";
            this.lblEditEmail.Size = new System.Drawing.Size(57, 24);
            this.lblEditEmail.TabIndex = 63;
            this.lblEditEmail.Text = "Email";
            // 
            // txtEditTelNo
            // 
            this.txtEditTelNo.Location = new System.Drawing.Point(228, 230);
            this.txtEditTelNo.Name = "txtEditTelNo";
            this.txtEditTelNo.Size = new System.Drawing.Size(259, 29);
            this.txtEditTelNo.TabIndex = 16;
            // 
            // lblEditTelNo
            // 
            this.lblEditTelNo.AutoSize = true;
            this.lblEditTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditTelNo.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblEditTelNo.Location = new System.Drawing.Point(46, 233);
            this.lblEditTelNo.Name = "lblEditTelNo";
            this.lblEditTelNo.Size = new System.Drawing.Size(72, 24);
            this.lblEditTelNo.TabIndex = 61;
            this.lblEditTelNo.Text = "Tel. No";
            // 
            // btnCancelEditPat
            // 
            this.btnCancelEditPat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEditPat.ImageList = this.ILPatients;
            this.btnCancelEditPat.Location = new System.Drawing.Point(780, 350);
            this.btnCancelEditPat.Name = "btnCancelEditPat";
            this.btnCancelEditPat.Size = new System.Drawing.Size(90, 53);
            this.btnCancelEditPat.TabIndex = 24;
            this.btnCancelEditPat.Text = "Cancel";
            this.btnCancelEditPat.UseVisualStyleBackColor = true;
            this.btnCancelEditPat.Click += new System.EventHandler(this.btnCancelEditPat_Click);
            this.btnCancelEditPat.MouseEnter += new System.EventHandler(this.btnCancelEditPat_MouseEnter);
            this.btnCancelEditPat.MouseLeave += new System.EventHandler(this.btnCancelEditPat_MouseLeave);
            // 
            // btnEditPat
            // 
            this.btnEditPat.BackColor = System.Drawing.Color.Transparent;
            this.btnEditPat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditPat.ImageList = this.ILPatients;
            this.btnEditPat.Location = new System.Drawing.Point(780, 190);
            this.btnEditPat.Name = "btnEditPat";
            this.btnEditPat.Size = new System.Drawing.Size(90, 53);
            this.btnEditPat.TabIndex = 22;
            this.btnEditPat.Text = "Edit";
            this.btnEditPat.UseVisualStyleBackColor = false;
            this.btnEditPat.Click += new System.EventHandler(this.btnEditPat_Click);
            this.btnEditPat.MouseEnter += new System.EventHandler(this.btnEditPat_MouseEnter);
            this.btnEditPat.MouseLeave += new System.EventHandler(this.btnEditPat_MouseLeave);
            // 
            // txtEditCounty
            // 
            this.txtEditCounty.Location = new System.Drawing.Point(228, 430);
            this.txtEditCounty.Name = "txtEditCounty";
            this.txtEditCounty.Size = new System.Drawing.Size(259, 29);
            this.txtEditCounty.TabIndex = 20;
            // 
            // txtEditStreet
            // 
            this.txtEditStreet.Location = new System.Drawing.Point(228, 330);
            this.txtEditStreet.Name = "txtEditStreet";
            this.txtEditStreet.Size = new System.Drawing.Size(259, 29);
            this.txtEditStreet.TabIndex = 18;
            // 
            // txtEditTown
            // 
            this.txtEditTown.Location = new System.Drawing.Point(228, 380);
            this.txtEditTown.Name = "txtEditTown";
            this.txtEditTown.Size = new System.Drawing.Size(259, 29);
            this.txtEditTown.TabIndex = 19;
            // 
            // txtEditSurname
            // 
            this.txtEditSurname.Location = new System.Drawing.Point(228, 180);
            this.txtEditSurname.Name = "txtEditSurname";
            this.txtEditSurname.Size = new System.Drawing.Size(259, 29);
            this.txtEditSurname.TabIndex = 15;
            // 
            // txtEditForename
            // 
            this.txtEditForename.Location = new System.Drawing.Point(228, 130);
            this.txtEditForename.Name = "txtEditForename";
            this.txtEditForename.Size = new System.Drawing.Size(259, 29);
            this.txtEditForename.TabIndex = 14;
            // 
            // lblEditCounty
            // 
            this.lblEditCounty.AutoSize = true;
            this.lblEditCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCounty.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblEditCounty.Location = new System.Drawing.Point(46, 433);
            this.lblEditCounty.Name = "lblEditCounty";
            this.lblEditCounty.Size = new System.Drawing.Size(69, 24);
            this.lblEditCounty.TabIndex = 51;
            this.lblEditCounty.Text = "County";
            // 
            // lblEditStreet
            // 
            this.lblEditStreet.AutoSize = true;
            this.lblEditStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditStreet.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblEditStreet.Location = new System.Drawing.Point(46, 333);
            this.lblEditStreet.Name = "lblEditStreet";
            this.lblEditStreet.Size = new System.Drawing.Size(58, 24);
            this.lblEditStreet.TabIndex = 50;
            this.lblEditStreet.Text = "Street";
            // 
            // lblEditTown
            // 
            this.lblEditTown.AutoSize = true;
            this.lblEditTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditTown.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblEditTown.Location = new System.Drawing.Point(46, 383);
            this.lblEditTown.Name = "lblEditTown";
            this.lblEditTown.Size = new System.Drawing.Size(58, 24);
            this.lblEditTown.TabIndex = 49;
            this.lblEditTown.Text = "Town";
            // 
            // lblEditSurname
            // 
            this.lblEditSurname.AutoSize = true;
            this.lblEditSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditSurname.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblEditSurname.Location = new System.Drawing.Point(46, 183);
            this.lblEditSurname.Name = "lblEditSurname";
            this.lblEditSurname.Size = new System.Drawing.Size(87, 24);
            this.lblEditSurname.TabIndex = 48;
            this.lblEditSurname.Text = "Surname";
            // 
            // lblEditForename
            // 
            this.lblEditForename.AutoSize = true;
            this.lblEditForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditForename.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblEditForename.Location = new System.Drawing.Point(46, 133);
            this.lblEditForename.Name = "lblEditForename";
            this.lblEditForename.Size = new System.Drawing.Size(98, 24);
            this.lblEditForename.TabIndex = 47;
            this.lblEditForename.Text = "Forename";
            // 
            // lblEditPatients
            // 
            this.lblEditPatients.AutoSize = true;
            this.lblEditPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditPatients.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblEditPatients.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEditPatients.ImageIndex = 3;
            this.lblEditPatients.ImageList = this.ILPatients;
            this.lblEditPatients.Location = new System.Drawing.Point(44, 24);
            this.lblEditPatients.Name = "lblEditPatients";
            this.lblEditPatients.Size = new System.Drawing.Size(331, 31);
            this.lblEditPatients.TabIndex = 46;
            this.lblEditPatients.Text = "Edit Existing Patients     ";
            // 
            // tabReport
            // 
            this.tabReport.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabReport.Controls.Add(this.label1);
            this.tabReport.ImageIndex = 4;
            this.tabReport.Location = new System.Drawing.Point(54, 4);
            this.tabReport.Name = "tabReport";
            this.tabReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabReport.Size = new System.Drawing.Size(977, 580);
            this.tabReport.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.ImageIndex = 4;
            this.label1.ImageList = this.ILPatients;
            this.label1.Location = new System.Drawing.Point(44, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 31);
            this.label1.TabIndex = 47;
            this.label1.Text = "Patient Report    ";
            // 
            // picArrow
            // 
            this.picArrow.Image = global::LloydsPharmacy.Properties.Resources.menu;
            this.picArrow.Location = new System.Drawing.Point(272, 104);
            this.picArrow.Name = "picArrow";
            this.picArrow.Size = new System.Drawing.Size(48, 46);
            this.picArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picArrow.TabIndex = 63;
            this.picArrow.TabStop = false;
            // 
            // PBIcon
            // 
            this.PBIcon.Image = global::LloydsPharmacy.Properties.Resources.patient;
            this.PBIcon.Location = new System.Drawing.Point(700, 3);
            this.PBIcon.Margin = new System.Windows.Forms.Padding(2);
            this.PBIcon.Name = "PBIcon";
            this.PBIcon.Size = new System.Drawing.Size(90, 81);
            this.PBIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBIcon.TabIndex = 61;
            this.PBIcon.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogo.Image = global::LloydsPharmacy.Properties.Resources.logo;
            this.pbLogo.Location = new System.Drawing.Point(12, 9);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(409, 76);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 59;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // frmPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 774);
            this.Controls.Add(this.picArrow);
            this.Controls.Add(this.lblBacktoMenu);
            this.Controls.Add(this.PBIcon);
            this.Controls.Add(this.lblPatients);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.tabPatients);
            this.Name = "frmPatients";
            this.Text = "frmPatients";
            this.Load += new System.EventHandler(this.frmPatients_Load);
            this.Shown += new System.EventHandler(this.frmPatients_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.errProPatients)).EndInit();
            this.tabPatients.ResumeLayout(false);
            this.tabDisplay.ResumeLayout(false);
            this.tabDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            this.tabEdit.ResumeLayout(false);
            this.tabEdit.PerformLayout();
            this.tabReport.ResumeLayout(false);
            this.tabReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList ILPatients;
        private System.Windows.Forms.ErrorProvider errProPatients;
        private System.Windows.Forms.PictureBox picArrow;
        private System.Windows.Forms.Label lblBacktoMenu;
        private System.Windows.Forms.PictureBox PBIcon;
        private System.Windows.Forms.Label lblPatients;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TabControl tabPatients;
        private System.Windows.Forms.TabPage tabDisplay;
        private System.Windows.Forms.Label lblDisplayPatients;
        private System.Windows.Forms.Label lblSearchPatient;
        private System.Windows.Forms.TextBox txtSearchPatient;
        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.Label lblAddPatID;
        private System.Windows.Forms.Label lblAddPatientID;
        private System.Windows.Forms.TextBox txtAddPostcode;
        private System.Windows.Forms.Label lblAddPPostcode;
        private System.Windows.Forms.TextBox txtAddEmail;
        private System.Windows.Forms.Label lblAddPEmail;
        private System.Windows.Forms.TextBox txtAddTelNo;
        private System.Windows.Forms.Label lblAddPTelNo;
        private System.Windows.Forms.Button btnCancelAddPat;
        private System.Windows.Forms.Button btnAddPat;
        private System.Windows.Forms.TextBox txtAddCounty;
        private System.Windows.Forms.TextBox txtAddStreet;
        private System.Windows.Forms.TextBox txtAddTown;
        private System.Windows.Forms.TextBox txtAddSurname;
        private System.Windows.Forms.TextBox txtAddForename;
        private System.Windows.Forms.Label lblAddPCounty;
        private System.Windows.Forms.Label lblAddPStreet;
        private System.Windows.Forms.Label lblAddPTown;
        private System.Windows.Forms.Label lblAddPSurname;
        private System.Windows.Forms.Label lblAddPForename;
        private System.Windows.Forms.Label lblAddPatients;
        private System.Windows.Forms.TabPage tabEdit;
        private System.Windows.Forms.Button btnDelPat;
        private System.Windows.Forms.Label lblEditPatID;
        private System.Windows.Forms.Label lblEditID;
        private System.Windows.Forms.TextBox txtEditPostcode;
        private System.Windows.Forms.Label lblEditPostcode;
        private System.Windows.Forms.TextBox txtEditEmail;
        private System.Windows.Forms.Label lblEditEmail;
        private System.Windows.Forms.TextBox txtEditTelNo;
        private System.Windows.Forms.Label lblEditTelNo;
        private System.Windows.Forms.Button btnCancelEditPat;
        private System.Windows.Forms.Button btnEditPat;
        private System.Windows.Forms.TextBox txtEditCounty;
        private System.Windows.Forms.TextBox txtEditStreet;
        private System.Windows.Forms.TextBox txtEditTown;
        private System.Windows.Forms.TextBox txtEditSurname;
        private System.Windows.Forms.TextBox txtEditForename;
        private System.Windows.Forms.Label lblEditCounty;
        private System.Windows.Forms.Label lblEditStreet;
        private System.Windows.Forms.Label lblEditTown;
        private System.Windows.Forms.Label lblEditSurname;
        private System.Windows.Forms.Label lblEditForename;
        private System.Windows.Forms.Label lblEditPatients;
        private System.Windows.Forms.TabPage tabReport;
        private System.Windows.Forms.Label label1;
      // private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        //private Patients Patients1;
    }
}