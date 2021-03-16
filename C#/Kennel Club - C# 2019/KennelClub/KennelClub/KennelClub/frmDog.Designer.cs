namespace KennelClub
{
    partial class frmDog
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
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabDog = new System.Windows.Forms.TabControl();
            this.tabdisplay = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbldisplayexit = new System.Windows.Forms.Label();
            this.lbldisplaydelete = new System.Windows.Forms.Label();
            this.lbldisplayedit = new System.Windows.Forms.Label();
            this.lbldisplayadd = new System.Windows.Forms.Label();
            this.btndisplayexit = new System.Windows.Forms.Button();
            this.btndisplaydelete = new System.Windows.Forms.Button();
            this.btndisplayedit = new System.Windows.Forms.Button();
            this.btndisplayadd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvDog = new System.Windows.Forms.DataGridView();
            this.tabadd = new System.Windows.Forms.TabPage();
            this.cmbAddGender = new System.Windows.Forms.ComboBox();
            this.dtpAddDOB = new System.Windows.Forms.DateTimePicker();
            this.cmbAddCustomerNo = new System.Windows.Forms.ComboBox();
            this.cmbAddBreedNo = new System.Windows.Forms.ComboBox();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.lbladdDogNo = new System.Windows.Forms.Label();
            this.btnaddAdd = new System.Windows.Forms.Button();
            this.txtAddColour = new System.Windows.Forms.TextBox();
            this.lbladdcustno = new System.Windows.Forms.Label();
            this.lbladdcolour = new System.Windows.Forms.Label();
            this.lbladdgender = new System.Windows.Forms.Label();
            this.lbladddob = new System.Windows.Forms.Label();
            this.lbladdbreedno = new System.Windows.Forms.Label();
            this.lbladdname = new System.Windows.Forms.Label();
            this.lbladdDNo = new System.Windows.Forms.Label();
            this.lbladdcancel = new System.Windows.Forms.Label();
            this.btnaddCancel = new System.Windows.Forms.Button();
            this.lbladdadd = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabedit = new System.Windows.Forms.TabPage();
            this.cmbEditGender = new System.Windows.Forms.ComboBox();
            this.dtpEditDOB = new System.Windows.Forms.DateTimePicker();
            this.cmbEditCustomerNo = new System.Windows.Forms.ComboBox();
            this.cmbEditBreedNo = new System.Windows.Forms.ComboBox();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.lblEditDNo = new System.Windows.Forms.Label();
            this.txtEditColour = new System.Windows.Forms.TextBox();
            this.lblEditCustomerNo = new System.Windows.Forms.Label();
            this.lblEditColour = new System.Windows.Forms.Label();
            this.lblEditGender = new System.Windows.Forms.Label();
            this.lblEditDOB = new System.Windows.Forms.Label();
            this.lblEditBreedNo = new System.Windows.Forms.Label();
            this.lblEditName = new System.Windows.Forms.Label();
            this.lblEditDogNo = new System.Windows.Forms.Label();
            this.btneditEdit = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbleditcancel = new System.Windows.Forms.Label();
            this.btneditCancel = new System.Windows.Forms.Button();
            this.lbleditedit = new System.Windows.Forms.Label();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tabDog.SuspendLayout();
            this.tabdisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDog)).BeginInit();
            this.tabadd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabedit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::KennelClub.Properties.Resources._5;
            this.pictureBox4.Location = new System.Drawing.Point(361, 13);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(106, 78);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 78);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kennel Club";
            // 
            // tabDog
            // 
            this.tabDog.Controls.Add(this.tabdisplay);
            this.tabDog.Controls.Add(this.tabadd);
            this.tabDog.Controls.Add(this.tabedit);
            this.tabDog.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDog.Location = new System.Drawing.Point(29, 91);
            this.tabDog.Name = "tabDog";
            this.tabDog.SelectedIndex = 0;
            this.tabDog.Size = new System.Drawing.Size(878, 511);
            this.tabDog.TabIndex = 3;
            this.tabDog.SelectedIndexChanged += new System.EventHandler(this.tabDog_SelectedIndexChanged);
            // 
            // tabdisplay
            // 
            this.tabdisplay.BackColor = System.Drawing.Color.Green;
            this.tabdisplay.Controls.Add(this.label2);
            this.tabdisplay.Controls.Add(this.label3);
            this.tabdisplay.Controls.Add(this.label4);
            this.tabdisplay.Controls.Add(this.label5);
            this.tabdisplay.Controls.Add(this.lbldisplayexit);
            this.tabdisplay.Controls.Add(this.lbldisplaydelete);
            this.tabdisplay.Controls.Add(this.lbldisplayedit);
            this.tabdisplay.Controls.Add(this.lbldisplayadd);
            this.tabdisplay.Controls.Add(this.btndisplayexit);
            this.tabdisplay.Controls.Add(this.btndisplaydelete);
            this.tabdisplay.Controls.Add(this.btndisplayedit);
            this.tabdisplay.Controls.Add(this.btndisplayadd);
            this.tabdisplay.Controls.Add(this.pictureBox1);
            this.tabdisplay.Controls.Add(this.dgvDog);
            this.tabdisplay.Location = new System.Drawing.Point(4, 28);
            this.tabdisplay.Name = "tabdisplay";
            this.tabdisplay.Padding = new System.Windows.Forms.Padding(3);
            this.tabdisplay.Size = new System.Drawing.Size(870, 479);
            this.tabdisplay.TabIndex = 0;
            this.tabdisplay.Text = "Display";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(624, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Exit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(624, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Delete";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(624, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Edit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(624, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Add";
            // 
            // lbldisplayexit
            // 
            this.lbldisplayexit.AutoSize = true;
            this.lbldisplayexit.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldisplayexit.Location = new System.Drawing.Point(622, 168);
            this.lbldisplayexit.Name = "lbldisplayexit";
            this.lbldisplayexit.Size = new System.Drawing.Size(0, 23);
            this.lbldisplayexit.TabIndex = 9;
            // 
            // lbldisplaydelete
            // 
            this.lbldisplaydelete.AutoSize = true;
            this.lbldisplaydelete.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldisplaydelete.Location = new System.Drawing.Point(622, 125);
            this.lbldisplaydelete.Name = "lbldisplaydelete";
            this.lbldisplaydelete.Size = new System.Drawing.Size(0, 23);
            this.lbldisplaydelete.TabIndex = 8;
            // 
            // lbldisplayedit
            // 
            this.lbldisplayedit.AutoSize = true;
            this.lbldisplayedit.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldisplayedit.Location = new System.Drawing.Point(622, 86);
            this.lbldisplayedit.Name = "lbldisplayedit";
            this.lbldisplayedit.Size = new System.Drawing.Size(0, 23);
            this.lbldisplayedit.TabIndex = 7;
            // 
            // lbldisplayadd
            // 
            this.lbldisplayadd.AutoSize = true;
            this.lbldisplayadd.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldisplayadd.Location = new System.Drawing.Point(622, 46);
            this.lbldisplayadd.Name = "lbldisplayadd";
            this.lbldisplayadd.Size = new System.Drawing.Size(0, 23);
            this.lbldisplayadd.TabIndex = 6;
            // 
            // btndisplayexit
            // 
            this.btndisplayexit.Location = new System.Drawing.Point(590, 167);
            this.btndisplayexit.Name = "btndisplayexit";
            this.btndisplayexit.Size = new System.Drawing.Size(26, 24);
            this.btndisplayexit.TabIndex = 5;
            this.btndisplayexit.UseVisualStyleBackColor = true;
            // 
            // btndisplaydelete
            // 
            this.btndisplaydelete.Location = new System.Drawing.Point(590, 125);
            this.btndisplaydelete.Name = "btndisplaydelete";
            this.btndisplaydelete.Size = new System.Drawing.Size(26, 24);
            this.btndisplaydelete.TabIndex = 4;
            this.btndisplaydelete.UseVisualStyleBackColor = true;
            this.btndisplaydelete.Click += new System.EventHandler(this.btndisplaydelete_Click);
            // 
            // btndisplayedit
            // 
            this.btndisplayedit.Location = new System.Drawing.Point(590, 85);
            this.btndisplayedit.Name = "btndisplayedit";
            this.btndisplayedit.Size = new System.Drawing.Size(26, 24);
            this.btndisplayedit.TabIndex = 3;
            this.btndisplayedit.UseVisualStyleBackColor = true;
            this.btndisplayedit.Click += new System.EventHandler(this.btndisplayedit_Click);
            // 
            // btndisplayadd
            // 
            this.btndisplayadd.Location = new System.Drawing.Point(590, 46);
            this.btndisplayadd.Name = "btndisplayadd";
            this.btndisplayadd.Size = new System.Drawing.Size(26, 24);
            this.btndisplayadd.TabIndex = 2;
            this.btndisplayadd.UseVisualStyleBackColor = true;
            this.btndisplayadd.Click += new System.EventHandler(this.btndisplayadd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KennelClub.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(607, 239);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dgvDog
            // 
            this.dgvDog.AllowUserToAddRows = false;
            this.dgvDog.AllowUserToDeleteRows = false;
            this.dgvDog.BackgroundColor = System.Drawing.Color.Green;
            this.dgvDog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDog.Location = new System.Drawing.Point(15, 28);
            this.dgvDog.Name = "dgvDog";
            this.dgvDog.ReadOnly = true;
            this.dgvDog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDog.Size = new System.Drawing.Size(520, 413);
            this.dgvDog.TabIndex = 0;
            // 
            // tabadd
            // 
            this.tabadd.BackColor = System.Drawing.Color.Green;
            this.tabadd.Controls.Add(this.cmbAddGender);
            this.tabadd.Controls.Add(this.dtpAddDOB);
            this.tabadd.Controls.Add(this.cmbAddCustomerNo);
            this.tabadd.Controls.Add(this.cmbAddBreedNo);
            this.tabadd.Controls.Add(this.txtAddName);
            this.tabadd.Controls.Add(this.lbladdDogNo);
            this.tabadd.Controls.Add(this.btnaddAdd);
            this.tabadd.Controls.Add(this.txtAddColour);
            this.tabadd.Controls.Add(this.lbladdcustno);
            this.tabadd.Controls.Add(this.lbladdcolour);
            this.tabadd.Controls.Add(this.lbladdgender);
            this.tabadd.Controls.Add(this.lbladddob);
            this.tabadd.Controls.Add(this.lbladdbreedno);
            this.tabadd.Controls.Add(this.lbladdname);
            this.tabadd.Controls.Add(this.lbladdDNo);
            this.tabadd.Controls.Add(this.lbladdcancel);
            this.tabadd.Controls.Add(this.btnaddCancel);
            this.tabadd.Controls.Add(this.lbladdadd);
            this.tabadd.Controls.Add(this.pictureBox2);
            this.tabadd.Location = new System.Drawing.Point(4, 28);
            this.tabadd.Name = "tabadd";
            this.tabadd.Padding = new System.Windows.Forms.Padding(3);
            this.tabadd.Size = new System.Drawing.Size(870, 479);
            this.tabadd.TabIndex = 1;
            this.tabadd.Text = "Add ";
            // 
            // cmbAddGender
            // 
            this.cmbAddGender.FormattingEnabled = true;
            this.cmbAddGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbAddGender.Location = new System.Drawing.Point(136, 277);
            this.cmbAddGender.Name = "cmbAddGender";
            this.cmbAddGender.Size = new System.Drawing.Size(416, 27);
            this.cmbAddGender.TabIndex = 72;
            // 
            // dtpAddDOB
            // 
            this.dtpAddDOB.Location = new System.Drawing.Point(136, 229);
            this.dtpAddDOB.Name = "dtpAddDOB";
            this.dtpAddDOB.Size = new System.Drawing.Size(416, 27);
            this.dtpAddDOB.TabIndex = 37;
            // 
            // cmbAddCustomerNo
            // 
            this.cmbAddCustomerNo.FormattingEnabled = true;
            this.cmbAddCustomerNo.Items.AddRange(new object[] {
            "Mr",
            "Mrs",
            "Ms",
            "Professor",
            "Master",
            "Doctor"});
            this.cmbAddCustomerNo.Location = new System.Drawing.Point(136, 322);
            this.cmbAddCustomerNo.Name = "cmbAddCustomerNo";
            this.cmbAddCustomerNo.Size = new System.Drawing.Size(416, 27);
            this.cmbAddCustomerNo.TabIndex = 36;
            this.cmbAddCustomerNo.SelectedIndexChanged += new System.EventHandler(this.cmbAddCustomerNo_SelectedIndexChanged);
            // 
            // cmbAddBreedNo
            // 
            this.cmbAddBreedNo.FormattingEnabled = true;
            this.cmbAddBreedNo.Items.AddRange(new object[] {
            "Mr",
            "Mrs",
            "Ms",
            "Professor",
            "Master",
            "Doctor"});
            this.cmbAddBreedNo.Location = new System.Drawing.Point(136, 142);
            this.cmbAddBreedNo.Name = "cmbAddBreedNo";
            this.cmbAddBreedNo.Size = new System.Drawing.Size(416, 27);
            this.cmbAddBreedNo.TabIndex = 35;
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(136, 97);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(416, 27);
            this.txtAddName.TabIndex = 32;
            // 
            // lbladdDogNo
            // 
            this.lbladdDogNo.AutoSize = true;
            this.lbladdDogNo.Location = new System.Drawing.Point(16, 55);
            this.lbladdDogNo.Name = "lbladdDogNo";
            this.lbladdDogNo.Size = new System.Drawing.Size(67, 19);
            this.lbladdDogNo.TabIndex = 31;
            this.lbladdDogNo.Text = "Dog No.";
            // 
            // btnaddAdd
            // 
            this.btnaddAdd.Location = new System.Drawing.Point(714, 40);
            this.btnaddAdd.Name = "btnaddAdd";
            this.btnaddAdd.Size = new System.Drawing.Size(26, 24);
            this.btnaddAdd.TabIndex = 30;
            this.btnaddAdd.UseVisualStyleBackColor = true;
            this.btnaddAdd.Click += new System.EventHandler(this.btnaddAdd_Click);
            // 
            // txtAddColour
            // 
            this.txtAddColour.Location = new System.Drawing.Point(136, 187);
            this.txtAddColour.Name = "txtAddColour";
            this.txtAddColour.Size = new System.Drawing.Size(416, 27);
            this.txtAddColour.TabIndex = 24;
            // 
            // lbladdcustno
            // 
            this.lbladdcustno.AutoSize = true;
            this.lbladdcustno.Location = new System.Drawing.Point(16, 325);
            this.lbladdcustno.Name = "lbladdcustno";
            this.lbladdcustno.Size = new System.Drawing.Size(106, 19);
            this.lbladdcustno.TabIndex = 17;
            this.lbladdcustno.Text = "Customer No.";
            // 
            // lbladdcolour
            // 
            this.lbladdcolour.AutoSize = true;
            this.lbladdcolour.Location = new System.Drawing.Point(16, 190);
            this.lbladdcolour.Name = "lbladdcolour";
            this.lbladdcolour.Size = new System.Drawing.Size(55, 19);
            this.lbladdcolour.TabIndex = 16;
            this.lbladdcolour.Text = "Colour";
            // 
            // lbladdgender
            // 
            this.lbladdgender.AutoSize = true;
            this.lbladdgender.Location = new System.Drawing.Point(16, 280);
            this.lbladdgender.Name = "lbladdgender";
            this.lbladdgender.Size = new System.Drawing.Size(60, 19);
            this.lbladdgender.TabIndex = 15;
            this.lbladdgender.Text = "Gender";
            // 
            // lbladddob
            // 
            this.lbladddob.AutoSize = true;
            this.lbladddob.Location = new System.Drawing.Point(16, 235);
            this.lbladddob.Name = "lbladddob";
            this.lbladddob.Size = new System.Drawing.Size(99, 19);
            this.lbladddob.TabIndex = 14;
            this.lbladddob.Text = "Date Of Birth";
            // 
            // lbladdbreedno
            // 
            this.lbladdbreedno.AutoSize = true;
            this.lbladdbreedno.Location = new System.Drawing.Point(16, 145);
            this.lbladdbreedno.Name = "lbladdbreedno";
            this.lbladdbreedno.Size = new System.Drawing.Size(79, 19);
            this.lbladdbreedno.TabIndex = 13;
            this.lbladdbreedno.Text = "Breed No.";
            // 
            // lbladdname
            // 
            this.lbladdname.AutoSize = true;
            this.lbladdname.Location = new System.Drawing.Point(16, 100);
            this.lbladdname.Name = "lbladdname";
            this.lbladdname.Size = new System.Drawing.Size(51, 19);
            this.lbladdname.TabIndex = 12;
            this.lbladdname.Text = "Name";
            // 
            // lbladdDNo
            // 
            this.lbladdDNo.AutoSize = true;
            this.lbladdDNo.Location = new System.Drawing.Point(132, 55);
            this.lbladdDNo.Name = "lbladdDNo";
            this.lbladdDNo.Size = new System.Drawing.Size(0, 19);
            this.lbladdDNo.TabIndex = 11;
            // 
            // lbladdcancel
            // 
            this.lbladdcancel.AutoSize = true;
            this.lbladdcancel.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdcancel.Location = new System.Drawing.Point(746, 71);
            this.lbladdcancel.Name = "lbladdcancel";
            this.lbladdcancel.Size = new System.Drawing.Size(65, 23);
            this.lbladdcancel.TabIndex = 10;
            this.lbladdcancel.Text = "Cancel";
            // 
            // btnaddCancel
            // 
            this.btnaddCancel.Location = new System.Drawing.Point(714, 71);
            this.btnaddCancel.Name = "btnaddCancel";
            this.btnaddCancel.Size = new System.Drawing.Size(26, 24);
            this.btnaddCancel.TabIndex = 9;
            this.btnaddCancel.UseVisualStyleBackColor = true;
            this.btnaddCancel.Click += new System.EventHandler(this.btnaddCancel_Click);
            // 
            // lbladdadd
            // 
            this.lbladdadd.AutoSize = true;
            this.lbladdadd.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdadd.Location = new System.Drawing.Point(746, 41);
            this.lbladdadd.Name = "lbladdadd";
            this.lbladdadd.Size = new System.Drawing.Size(44, 23);
            this.lbladdadd.TabIndex = 8;
            this.lbladdadd.Text = "Add";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::KennelClub.Properties.Resources._2;
            this.pictureBox2.Location = new System.Drawing.Point(588, 139);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(261, 303);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // tabedit
            // 
            this.tabedit.BackColor = System.Drawing.Color.Green;
            this.tabedit.Controls.Add(this.cmbEditGender);
            this.tabedit.Controls.Add(this.dtpEditDOB);
            this.tabedit.Controls.Add(this.cmbEditCustomerNo);
            this.tabedit.Controls.Add(this.cmbEditBreedNo);
            this.tabedit.Controls.Add(this.txtEditName);
            this.tabedit.Controls.Add(this.lblEditDNo);
            this.tabedit.Controls.Add(this.txtEditColour);
            this.tabedit.Controls.Add(this.lblEditCustomerNo);
            this.tabedit.Controls.Add(this.lblEditColour);
            this.tabedit.Controls.Add(this.lblEditGender);
            this.tabedit.Controls.Add(this.lblEditDOB);
            this.tabedit.Controls.Add(this.lblEditBreedNo);
            this.tabedit.Controls.Add(this.lblEditName);
            this.tabedit.Controls.Add(this.lblEditDogNo);
            this.tabedit.Controls.Add(this.btneditEdit);
            this.tabedit.Controls.Add(this.pictureBox3);
            this.tabedit.Controls.Add(this.lbleditcancel);
            this.tabedit.Controls.Add(this.btneditCancel);
            this.tabedit.Controls.Add(this.lbleditedit);
            this.tabedit.Location = new System.Drawing.Point(4, 28);
            this.tabedit.Name = "tabedit";
            this.tabedit.Padding = new System.Windows.Forms.Padding(3);
            this.tabedit.Size = new System.Drawing.Size(870, 479);
            this.tabedit.TabIndex = 2;
            this.tabedit.Text = "Edit";
            // 
            // cmbEditGender
            // 
            this.cmbEditGender.FormattingEnabled = true;
            this.cmbEditGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbEditGender.Location = new System.Drawing.Point(136, 277);
            this.cmbEditGender.Name = "cmbEditGender";
            this.cmbEditGender.Size = new System.Drawing.Size(416, 27);
            this.cmbEditGender.TabIndex = 71;
            // 
            // dtpEditDOB
            // 
            this.dtpEditDOB.Location = new System.Drawing.Point(136, 229);
            this.dtpEditDOB.Name = "dtpEditDOB";
            this.dtpEditDOB.Size = new System.Drawing.Size(416, 27);
            this.dtpEditDOB.TabIndex = 70;
            // 
            // cmbEditCustomerNo
            // 
            this.cmbEditCustomerNo.FormattingEnabled = true;
            this.cmbEditCustomerNo.Location = new System.Drawing.Point(136, 322);
            this.cmbEditCustomerNo.Name = "cmbEditCustomerNo";
            this.cmbEditCustomerNo.Size = new System.Drawing.Size(416, 27);
            this.cmbEditCustomerNo.TabIndex = 69;
            this.cmbEditCustomerNo.SelectedIndexChanged += new System.EventHandler(this.cmbEditCustomerNo_SelectedIndexChanged);
            // 
            // cmbEditBreedNo
            // 
            this.cmbEditBreedNo.FormattingEnabled = true;
            this.cmbEditBreedNo.Location = new System.Drawing.Point(136, 142);
            this.cmbEditBreedNo.Name = "cmbEditBreedNo";
            this.cmbEditBreedNo.Size = new System.Drawing.Size(416, 27);
            this.cmbEditBreedNo.TabIndex = 68;
            // 
            // txtEditName
            // 
            this.txtEditName.Location = new System.Drawing.Point(136, 97);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(416, 27);
            this.txtEditName.TabIndex = 67;
            // 
            // lblEditDNo
            // 
            this.lblEditDNo.AutoSize = true;
            this.lblEditDNo.Location = new System.Drawing.Point(16, 55);
            this.lblEditDNo.Name = "lblEditDNo";
            this.lblEditDNo.Size = new System.Drawing.Size(67, 19);
            this.lblEditDNo.TabIndex = 66;
            this.lblEditDNo.Text = "Dog No.";
            // 
            // txtEditColour
            // 
            this.txtEditColour.Location = new System.Drawing.Point(136, 187);
            this.txtEditColour.Name = "txtEditColour";
            this.txtEditColour.Size = new System.Drawing.Size(416, 27);
            this.txtEditColour.TabIndex = 64;
            // 
            // lblEditCustomerNo
            // 
            this.lblEditCustomerNo.AutoSize = true;
            this.lblEditCustomerNo.Location = new System.Drawing.Point(16, 325);
            this.lblEditCustomerNo.Name = "lblEditCustomerNo";
            this.lblEditCustomerNo.Size = new System.Drawing.Size(106, 19);
            this.lblEditCustomerNo.TabIndex = 60;
            this.lblEditCustomerNo.Text = "Customer No.";
            // 
            // lblEditColour
            // 
            this.lblEditColour.AutoSize = true;
            this.lblEditColour.Location = new System.Drawing.Point(16, 190);
            this.lblEditColour.Name = "lblEditColour";
            this.lblEditColour.Size = new System.Drawing.Size(55, 19);
            this.lblEditColour.TabIndex = 59;
            this.lblEditColour.Text = "Colour";
            // 
            // lblEditGender
            // 
            this.lblEditGender.AutoSize = true;
            this.lblEditGender.Location = new System.Drawing.Point(16, 280);
            this.lblEditGender.Name = "lblEditGender";
            this.lblEditGender.Size = new System.Drawing.Size(60, 19);
            this.lblEditGender.TabIndex = 58;
            this.lblEditGender.Text = "Gender";
            // 
            // lblEditDOB
            // 
            this.lblEditDOB.AutoSize = true;
            this.lblEditDOB.Location = new System.Drawing.Point(16, 235);
            this.lblEditDOB.Name = "lblEditDOB";
            this.lblEditDOB.Size = new System.Drawing.Size(99, 19);
            this.lblEditDOB.TabIndex = 57;
            this.lblEditDOB.Text = "Date Of Birth";
            // 
            // lblEditBreedNo
            // 
            this.lblEditBreedNo.AutoSize = true;
            this.lblEditBreedNo.Location = new System.Drawing.Point(16, 145);
            this.lblEditBreedNo.Name = "lblEditBreedNo";
            this.lblEditBreedNo.Size = new System.Drawing.Size(79, 19);
            this.lblEditBreedNo.TabIndex = 56;
            this.lblEditBreedNo.Text = "Breed No.";
            // 
            // lblEditName
            // 
            this.lblEditName.AutoSize = true;
            this.lblEditName.Location = new System.Drawing.Point(16, 100);
            this.lblEditName.Name = "lblEditName";
            this.lblEditName.Size = new System.Drawing.Size(51, 19);
            this.lblEditName.TabIndex = 55;
            this.lblEditName.Text = "Name";
            // 
            // lblEditDogNo
            // 
            this.lblEditDogNo.AutoSize = true;
            this.lblEditDogNo.Location = new System.Drawing.Point(132, 55);
            this.lblEditDogNo.Name = "lblEditDogNo";
            this.lblEditDogNo.Size = new System.Drawing.Size(0, 19);
            this.lblEditDogNo.TabIndex = 54;
            // 
            // btneditEdit
            // 
            this.btneditEdit.Location = new System.Drawing.Point(714, 40);
            this.btneditEdit.Name = "btneditEdit";
            this.btneditEdit.Size = new System.Drawing.Size(26, 24);
            this.btneditEdit.TabIndex = 53;
            this.btneditEdit.UseVisualStyleBackColor = true;
            this.btneditEdit.Click += new System.EventHandler(this.btneditEdit_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::KennelClub.Properties.Resources._3;
            this.pictureBox3.Location = new System.Drawing.Point(588, 185);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(261, 257);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 52;
            this.pictureBox3.TabStop = false;
            // 
            // lbleditcancel
            // 
            this.lbleditcancel.AutoSize = true;
            this.lbleditcancel.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleditcancel.Location = new System.Drawing.Point(746, 71);
            this.lbleditcancel.Name = "lbleditcancel";
            this.lbleditcancel.Size = new System.Drawing.Size(65, 23);
            this.lbleditcancel.TabIndex = 33;
            this.lbleditcancel.Text = "Cancel";
            // 
            // btneditCancel
            // 
            this.btneditCancel.Location = new System.Drawing.Point(714, 71);
            this.btneditCancel.Name = "btneditCancel";
            this.btneditCancel.Size = new System.Drawing.Size(26, 24);
            this.btneditCancel.TabIndex = 32;
            this.btneditCancel.UseVisualStyleBackColor = true;
            this.btneditCancel.Click += new System.EventHandler(this.btneditCancel_Click);
            // 
            // lbleditedit
            // 
            this.lbleditedit.AutoSize = true;
            this.lbleditedit.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleditedit.Location = new System.Drawing.Point(746, 41);
            this.lbleditedit.Name = "lbleditedit";
            this.lbleditedit.Size = new System.Drawing.Size(44, 23);
            this.lbleditedit.TabIndex = 31;
            this.lbleditedit.Text = "Edit";
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // frmDog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 613);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabDog);
            this.Name = "frmDog";
            this.Text = "frmDog";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tabDog.ResumeLayout(false);
            this.tabdisplay.ResumeLayout(false);
            this.tabdisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDog)).EndInit();
            this.tabadd.ResumeLayout(false);
            this.tabadd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabedit.ResumeLayout(false);
            this.tabedit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabDog;
        private System.Windows.Forms.TabPage tabadd;
        private System.Windows.Forms.Label lbladdDogNo;
        private System.Windows.Forms.Button btnaddAdd;
        private System.Windows.Forms.TextBox txtAddColour;
        private System.Windows.Forms.Label lbladdcustno;
        private System.Windows.Forms.Label lbladdcolour;
        private System.Windows.Forms.Label lbladdgender;
        private System.Windows.Forms.Label lbladddob;
        private System.Windows.Forms.Label lbladdbreedno;
        private System.Windows.Forms.Label lbladdname;
        private System.Windows.Forms.Label lbladdDNo;
        private System.Windows.Forms.Label lbladdcancel;
        private System.Windows.Forms.Button btnaddCancel;
        private System.Windows.Forms.Label lbladdadd;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage tabedit;
        private System.Windows.Forms.Button btneditEdit;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbleditcancel;
        private System.Windows.Forms.Button btneditCancel;
        private System.Windows.Forms.Label lbleditedit;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.Label lblEditDNo;
        private System.Windows.Forms.TextBox txtEditColour;
        private System.Windows.Forms.Label lblEditCustomerNo;
        private System.Windows.Forms.Label lblEditColour;
        private System.Windows.Forms.Label lblEditGender;
        private System.Windows.Forms.Label lblEditDOB;
        private System.Windows.Forms.Label lblEditBreedNo;
        private System.Windows.Forms.Label lblEditName;
        private System.Windows.Forms.Label lblEditDogNo;
        private System.Windows.Forms.ErrorProvider errP;
        private System.Windows.Forms.ComboBox cmbAddCustomerNo;
        private System.Windows.Forms.ComboBox cmbAddBreedNo;
        private System.Windows.Forms.ComboBox cmbEditCustomerNo;
        private System.Windows.Forms.ComboBox cmbEditBreedNo;
        private System.Windows.Forms.DateTimePicker dtpAddDOB;
        private System.Windows.Forms.DateTimePicker dtpEditDOB;
        private System.Windows.Forms.ComboBox cmbAddGender;
        private System.Windows.Forms.ComboBox cmbEditGender;
        private System.Windows.Forms.TabPage tabdisplay;
        private System.Windows.Forms.Label lbldisplayexit;
        private System.Windows.Forms.Label lbldisplaydelete;
        private System.Windows.Forms.Label lbldisplayedit;
        private System.Windows.Forms.Label lbldisplayadd;
        private System.Windows.Forms.Button btndisplayexit;
        private System.Windows.Forms.Button btndisplaydelete;
        private System.Windows.Forms.Button btndisplayedit;
        private System.Windows.Forms.Button btndisplayadd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvDog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}