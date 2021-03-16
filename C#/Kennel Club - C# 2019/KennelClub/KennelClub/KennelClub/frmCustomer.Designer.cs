namespace KennelClub
{
    partial class frmCustomer
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
            this.tabcustomer = new System.Windows.Forms.TabControl();
            this.tabdisplay = new System.Windows.Forms.TabPage();
            this.lbldisplayexit = new System.Windows.Forms.Label();
            this.lbldisplaydelete = new System.Windows.Forms.Label();
            this.lbldisplayedit = new System.Windows.Forms.Label();
            this.lbldisplayadd = new System.Windows.Forms.Label();
            this.btndisplayexit = new System.Windows.Forms.Button();
            this.btndisplaydelete = new System.Windows.Forms.Button();
            this.btndisplayedit = new System.Windows.Forms.Button();
            this.btndisplayadd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.tabadd = new System.Windows.Forms.TabPage();
            this.lbladdCustomerNo = new System.Windows.Forms.Label();
            this.btnaddAdd = new System.Windows.Forms.Button();
            this.txtaddTelNo = new System.Windows.Forms.TextBox();
            this.txtaddPostcode = new System.Windows.Forms.TextBox();
            this.txtaddCounty = new System.Windows.Forms.TextBox();
            this.txtaddTown = new System.Windows.Forms.TextBox();
            this.txtaddStreet = new System.Windows.Forms.TextBox();
            this.txtaddForename = new System.Windows.Forms.TextBox();
            this.txtaddSurname = new System.Windows.Forms.TextBox();
            this.cmbaddTitle = new System.Windows.Forms.ComboBox();
            this.lbladdtelno = new System.Windows.Forms.Label();
            this.lbladdpostcode = new System.Windows.Forms.Label();
            this.lbladdcounty = new System.Windows.Forms.Label();
            this.lbladdtown = new System.Windows.Forms.Label();
            this.lbladdstreet = new System.Windows.Forms.Label();
            this.lbladdforename = new System.Windows.Forms.Label();
            this.lbladdsurname = new System.Windows.Forms.Label();
            this.lbladdtitle = new System.Windows.Forms.Label();
            this.lbladdCustNo = new System.Windows.Forms.Label();
            this.lbladdcancel = new System.Windows.Forms.Label();
            this.btnaddCancel = new System.Windows.Forms.Button();
            this.lbladdadd = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabedit = new System.Windows.Forms.TabPage();
            this.lbleditCustomerNo = new System.Windows.Forms.Label();
            this.cmbeditTitle = new System.Windows.Forms.ComboBox();
            this.btneditEdit = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txteditTelNo = new System.Windows.Forms.TextBox();
            this.txteditPostcode = new System.Windows.Forms.TextBox();
            this.txteditCounty = new System.Windows.Forms.TextBox();
            this.txteditTown = new System.Windows.Forms.TextBox();
            this.txteditStreet = new System.Windows.Forms.TextBox();
            this.txteditForename = new System.Windows.Forms.TextBox();
            this.txteditSurname = new System.Windows.Forms.TextBox();
            this.lbledittelno = new System.Windows.Forms.Label();
            this.lbleditpostcode = new System.Windows.Forms.Label();
            this.lbleditcounty = new System.Windows.Forms.Label();
            this.lbledittown = new System.Windows.Forms.Label();
            this.lbleditstreet = new System.Windows.Forms.Label();
            this.lbleditforename = new System.Windows.Forms.Label();
            this.lbleditsurname = new System.Windows.Forms.Label();
            this.lbledittitle = new System.Windows.Forms.Label();
            this.lbleditCustNo = new System.Windows.Forms.Label();
            this.lbleditcancel = new System.Windows.Forms.Label();
            this.btneditCancel = new System.Windows.Forms.Button();
            this.lbleditedit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabcustomer.SuspendLayout();
            this.tabdisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.tabadd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabedit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            this.SuspendLayout();
            // 
            // tabcustomer
            // 
            this.tabcustomer.Controls.Add(this.tabdisplay);
            this.tabcustomer.Controls.Add(this.tabadd);
            this.tabcustomer.Controls.Add(this.tabedit);
            this.tabcustomer.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabcustomer.Location = new System.Drawing.Point(28, 90);
            this.tabcustomer.Name = "tabcustomer";
            this.tabcustomer.SelectedIndex = 0;
            this.tabcustomer.Size = new System.Drawing.Size(878, 511);
            this.tabcustomer.TabIndex = 0;
            this.tabcustomer.SelectedIndexChanged += new System.EventHandler(this.tabCustomer_SelctectedIndexChanged);
            // 
            // tabdisplay
            // 
            this.tabdisplay.BackColor = System.Drawing.Color.Green;
            this.tabdisplay.Controls.Add(this.lbldisplayexit);
            this.tabdisplay.Controls.Add(this.lbldisplaydelete);
            this.tabdisplay.Controls.Add(this.lbldisplayedit);
            this.tabdisplay.Controls.Add(this.lbldisplayadd);
            this.tabdisplay.Controls.Add(this.btndisplayexit);
            this.tabdisplay.Controls.Add(this.btndisplaydelete);
            this.tabdisplay.Controls.Add(this.btndisplayedit);
            this.tabdisplay.Controls.Add(this.btndisplayadd);
            this.tabdisplay.Controls.Add(this.pictureBox1);
            this.tabdisplay.Controls.Add(this.dgvCustomers);
            this.tabdisplay.Location = new System.Drawing.Point(4, 28);
            this.tabdisplay.Name = "tabdisplay";
            this.tabdisplay.Padding = new System.Windows.Forms.Padding(3);
            this.tabdisplay.Size = new System.Drawing.Size(870, 479);
            this.tabdisplay.TabIndex = 0;
            this.tabdisplay.Text = "Display";
            // 
            // lbldisplayexit
            // 
            this.lbldisplayexit.AutoSize = true;
            this.lbldisplayexit.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldisplayexit.Location = new System.Drawing.Point(622, 168);
            this.lbldisplayexit.Name = "lbldisplayexit";
            this.lbldisplayexit.Size = new System.Drawing.Size(43, 23);
            this.lbldisplayexit.TabIndex = 9;
            this.lbldisplayexit.Text = "Exit";
            // 
            // lbldisplaydelete
            // 
            this.lbldisplaydelete.AutoSize = true;
            this.lbldisplaydelete.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldisplaydelete.Location = new System.Drawing.Point(622, 125);
            this.lbldisplaydelete.Name = "lbldisplaydelete";
            this.lbldisplaydelete.Size = new System.Drawing.Size(65, 23);
            this.lbldisplaydelete.TabIndex = 8;
            this.lbldisplaydelete.Text = "Delete";
            // 
            // lbldisplayedit
            // 
            this.lbldisplayedit.AutoSize = true;
            this.lbldisplayedit.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldisplayedit.Location = new System.Drawing.Point(622, 86);
            this.lbldisplayedit.Name = "lbldisplayedit";
            this.lbldisplayedit.Size = new System.Drawing.Size(44, 23);
            this.lbldisplayedit.TabIndex = 7;
            this.lbldisplayedit.Text = "Edit";
            // 
            // lbldisplayadd
            // 
            this.lbldisplayadd.AutoSize = true;
            this.lbldisplayadd.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldisplayadd.Location = new System.Drawing.Point(622, 46);
            this.lbldisplayadd.Name = "lbldisplayadd";
            this.lbldisplayadd.Size = new System.Drawing.Size(44, 23);
            this.lbldisplayadd.TabIndex = 6;
            this.lbldisplayadd.Text = "Add";
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
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.BackgroundColor = System.Drawing.Color.Green;
            this.dgvCustomers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(15, 28);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(520, 413);
            this.dgvCustomers.TabIndex = 0;
            // 
            // tabadd
            // 
            this.tabadd.BackColor = System.Drawing.Color.Green;
            this.tabadd.Controls.Add(this.lbladdCustomerNo);
            this.tabadd.Controls.Add(this.btnaddAdd);
            this.tabadd.Controls.Add(this.txtaddTelNo);
            this.tabadd.Controls.Add(this.txtaddPostcode);
            this.tabadd.Controls.Add(this.txtaddCounty);
            this.tabadd.Controls.Add(this.txtaddTown);
            this.tabadd.Controls.Add(this.txtaddStreet);
            this.tabadd.Controls.Add(this.txtaddForename);
            this.tabadd.Controls.Add(this.txtaddSurname);
            this.tabadd.Controls.Add(this.cmbaddTitle);
            this.tabadd.Controls.Add(this.lbladdtelno);
            this.tabadd.Controls.Add(this.lbladdpostcode);
            this.tabadd.Controls.Add(this.lbladdcounty);
            this.tabadd.Controls.Add(this.lbladdtown);
            this.tabadd.Controls.Add(this.lbladdstreet);
            this.tabadd.Controls.Add(this.lbladdforename);
            this.tabadd.Controls.Add(this.lbladdsurname);
            this.tabadd.Controls.Add(this.lbladdtitle);
            this.tabadd.Controls.Add(this.lbladdCustNo);
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
            // lbladdCustomerNo
            // 
            this.lbladdCustomerNo.AutoSize = true;
            this.lbladdCustomerNo.Location = new System.Drawing.Point(16, 55);
            this.lbladdCustomerNo.Name = "lbladdCustomerNo";
            this.lbladdCustomerNo.Size = new System.Drawing.Size(101, 19);
            this.lbladdCustomerNo.TabIndex = 31;
            this.lbladdCustomerNo.Text = "Customer No";
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
            // txtaddTelNo
            // 
            this.txtaddTelNo.Location = new System.Drawing.Point(136, 415);
            this.txtaddTelNo.Name = "txtaddTelNo";
            this.txtaddTelNo.Size = new System.Drawing.Size(416, 27);
            this.txtaddTelNo.TabIndex = 27;
            // 
            // txtaddPostcode
            // 
            this.txtaddPostcode.Location = new System.Drawing.Point(136, 369);
            this.txtaddPostcode.Name = "txtaddPostcode";
            this.txtaddPostcode.Size = new System.Drawing.Size(416, 27);
            this.txtaddPostcode.TabIndex = 26;
            // 
            // txtaddCounty
            // 
            this.txtaddCounty.Location = new System.Drawing.Point(136, 323);
            this.txtaddCounty.Name = "txtaddCounty";
            this.txtaddCounty.Size = new System.Drawing.Size(416, 27);
            this.txtaddCounty.TabIndex = 25;
            // 
            // txtaddTown
            // 
            this.txtaddTown.Location = new System.Drawing.Point(136, 277);
            this.txtaddTown.Name = "txtaddTown";
            this.txtaddTown.Size = new System.Drawing.Size(416, 27);
            this.txtaddTown.TabIndex = 24;
            // 
            // txtaddStreet
            // 
            this.txtaddStreet.Location = new System.Drawing.Point(136, 231);
            this.txtaddStreet.Name = "txtaddStreet";
            this.txtaddStreet.Size = new System.Drawing.Size(416, 27);
            this.txtaddStreet.TabIndex = 23;
            // 
            // txtaddForename
            // 
            this.txtaddForename.Location = new System.Drawing.Point(136, 185);
            this.txtaddForename.Name = "txtaddForename";
            this.txtaddForename.Size = new System.Drawing.Size(416, 27);
            this.txtaddForename.TabIndex = 22;
            // 
            // txtaddSurname
            // 
            this.txtaddSurname.Location = new System.Drawing.Point(136, 139);
            this.txtaddSurname.Name = "txtaddSurname";
            this.txtaddSurname.Size = new System.Drawing.Size(416, 27);
            this.txtaddSurname.TabIndex = 21;
            // 
            // cmbaddTitle
            // 
            this.cmbaddTitle.FormattingEnabled = true;
            this.cmbaddTitle.Items.AddRange(new object[] {
            "Mr",
            "Mrs",
            "Ms",
            "Professor",
            "Master",
            "Doctor"});
            this.cmbaddTitle.Location = new System.Drawing.Point(136, 93);
            this.cmbaddTitle.Name = "cmbaddTitle";
            this.cmbaddTitle.Size = new System.Drawing.Size(96, 27);
            this.cmbaddTitle.TabIndex = 20;
            // 
            // lbladdtelno
            // 
            this.lbladdtelno.AutoSize = true;
            this.lbladdtelno.Location = new System.Drawing.Point(16, 418);
            this.lbladdtelno.Name = "lbladdtelno";
            this.lbladdtelno.Size = new System.Drawing.Size(105, 19);
            this.lbladdtelno.TabIndex = 19;
            this.lbladdtelno.Text = "Telephone No";
            // 
            // lbladdpostcode
            // 
            this.lbladdpostcode.AutoSize = true;
            this.lbladdpostcode.Location = new System.Drawing.Point(16, 372);
            this.lbladdpostcode.Name = "lbladdpostcode";
            this.lbladdpostcode.Size = new System.Drawing.Size(73, 19);
            this.lbladdpostcode.TabIndex = 18;
            this.lbladdpostcode.Text = "Postcode";
            // 
            // lbladdcounty
            // 
            this.lbladdcounty.AutoSize = true;
            this.lbladdcounty.Location = new System.Drawing.Point(16, 326);
            this.lbladdcounty.Name = "lbladdcounty";
            this.lbladdcounty.Size = new System.Drawing.Size(59, 19);
            this.lbladdcounty.TabIndex = 17;
            this.lbladdcounty.Text = "County";
            // 
            // lbladdtown
            // 
            this.lbladdtown.AutoSize = true;
            this.lbladdtown.Location = new System.Drawing.Point(16, 280);
            this.lbladdtown.Name = "lbladdtown";
            this.lbladdtown.Size = new System.Drawing.Size(47, 19);
            this.lbladdtown.TabIndex = 16;
            this.lbladdtown.Text = "Town";
            // 
            // lbladdstreet
            // 
            this.lbladdstreet.AutoSize = true;
            this.lbladdstreet.Location = new System.Drawing.Point(16, 234);
            this.lbladdstreet.Name = "lbladdstreet";
            this.lbladdstreet.Size = new System.Drawing.Size(52, 19);
            this.lbladdstreet.TabIndex = 15;
            this.lbladdstreet.Text = "Street";
            // 
            // lbladdforename
            // 
            this.lbladdforename.AutoSize = true;
            this.lbladdforename.Location = new System.Drawing.Point(16, 188);
            this.lbladdforename.Name = "lbladdforename";
            this.lbladdforename.Size = new System.Drawing.Size(79, 19);
            this.lbladdforename.TabIndex = 14;
            this.lbladdforename.Text = "Forename";
            // 
            // lbladdsurname
            // 
            this.lbladdsurname.AutoSize = true;
            this.lbladdsurname.Location = new System.Drawing.Point(16, 142);
            this.lbladdsurname.Name = "lbladdsurname";
            this.lbladdsurname.Size = new System.Drawing.Size(72, 19);
            this.lbladdsurname.TabIndex = 13;
            this.lbladdsurname.Text = "Surname";
            // 
            // lbladdtitle
            // 
            this.lbladdtitle.AutoSize = true;
            this.lbladdtitle.Location = new System.Drawing.Point(16, 96);
            this.lbladdtitle.Name = "lbladdtitle";
            this.lbladdtitle.Size = new System.Drawing.Size(40, 19);
            this.lbladdtitle.TabIndex = 12;
            this.lbladdtitle.Text = "Title";
            // 
            // lbladdCustNo
            // 
            this.lbladdCustNo.AutoSize = true;
            this.lbladdCustNo.Location = new System.Drawing.Point(132, 55);
            this.lbladdCustNo.Name = "lbladdCustNo";
            this.lbladdCustNo.Size = new System.Drawing.Size(0, 19);
            this.lbladdCustNo.TabIndex = 11;
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
            this.btnaddCancel.Click += new System.EventHandler(this.btnaddcancel_Click);
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
            this.tabedit.Controls.Add(this.lbleditCustomerNo);
            this.tabedit.Controls.Add(this.cmbeditTitle);
            this.tabedit.Controls.Add(this.btneditEdit);
            this.tabedit.Controls.Add(this.pictureBox3);
            this.tabedit.Controls.Add(this.txteditTelNo);
            this.tabedit.Controls.Add(this.txteditPostcode);
            this.tabedit.Controls.Add(this.txteditCounty);
            this.tabedit.Controls.Add(this.txteditTown);
            this.tabedit.Controls.Add(this.txteditStreet);
            this.tabedit.Controls.Add(this.txteditForename);
            this.tabedit.Controls.Add(this.txteditSurname);
            this.tabedit.Controls.Add(this.lbledittelno);
            this.tabedit.Controls.Add(this.lbleditpostcode);
            this.tabedit.Controls.Add(this.lbleditcounty);
            this.tabedit.Controls.Add(this.lbledittown);
            this.tabedit.Controls.Add(this.lbleditstreet);
            this.tabedit.Controls.Add(this.lbleditforename);
            this.tabedit.Controls.Add(this.lbleditsurname);
            this.tabedit.Controls.Add(this.lbledittitle);
            this.tabedit.Controls.Add(this.lbleditCustNo);
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
            // lbleditCustomerNo
            // 
            this.lbleditCustomerNo.AutoSize = true;
            this.lbleditCustomerNo.Location = new System.Drawing.Point(16, 55);
            this.lbleditCustomerNo.Name = "lbleditCustomerNo";
            this.lbleditCustomerNo.Size = new System.Drawing.Size(101, 19);
            this.lbleditCustomerNo.TabIndex = 55;
            this.lbleditCustomerNo.Text = "Customer No";
            // 
            // cmbeditTitle
            // 
            this.cmbeditTitle.Enabled = false;
            this.cmbeditTitle.FormattingEnabled = true;
            this.cmbeditTitle.Items.AddRange(new object[] {
            "Mr",
            "Mrs",
            "Ms",
            "Professor",
            "Master",
            "Doctor"});
            this.cmbeditTitle.Location = new System.Drawing.Point(136, 93);
            this.cmbeditTitle.Name = "cmbeditTitle";
            this.cmbeditTitle.Size = new System.Drawing.Size(96, 27);
            this.cmbeditTitle.TabIndex = 54;
            // 
            // btneditEdit
            // 
            this.btneditEdit.Location = new System.Drawing.Point(714, 40);
            this.btneditEdit.Name = "btneditEdit";
            this.btneditEdit.Size = new System.Drawing.Size(26, 24);
            this.btneditEdit.TabIndex = 53;
            this.btneditEdit.UseVisualStyleBackColor = true;
            this.btneditEdit.Click += new System.EventHandler(this.btneditedit_Click);
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
            // txteditTelNo
            // 
            this.txteditTelNo.Enabled = false;
            this.txteditTelNo.Location = new System.Drawing.Point(136, 415);
            this.txteditTelNo.Name = "txteditTelNo";
            this.txteditTelNo.Size = new System.Drawing.Size(416, 27);
            this.txteditTelNo.TabIndex = 50;
            // 
            // txteditPostcode
            // 
            this.txteditPostcode.Enabled = false;
            this.txteditPostcode.Location = new System.Drawing.Point(136, 369);
            this.txteditPostcode.Name = "txteditPostcode";
            this.txteditPostcode.Size = new System.Drawing.Size(416, 27);
            this.txteditPostcode.TabIndex = 49;
            // 
            // txteditCounty
            // 
            this.txteditCounty.Enabled = false;
            this.txteditCounty.Location = new System.Drawing.Point(136, 323);
            this.txteditCounty.Name = "txteditCounty";
            this.txteditCounty.Size = new System.Drawing.Size(416, 27);
            this.txteditCounty.TabIndex = 48;
            // 
            // txteditTown
            // 
            this.txteditTown.Enabled = false;
            this.txteditTown.Location = new System.Drawing.Point(136, 277);
            this.txteditTown.Name = "txteditTown";
            this.txteditTown.Size = new System.Drawing.Size(416, 27);
            this.txteditTown.TabIndex = 47;
            // 
            // txteditStreet
            // 
            this.txteditStreet.Enabled = false;
            this.txteditStreet.Location = new System.Drawing.Point(136, 231);
            this.txteditStreet.Name = "txteditStreet";
            this.txteditStreet.Size = new System.Drawing.Size(416, 27);
            this.txteditStreet.TabIndex = 46;
            // 
            // txteditForename
            // 
            this.txteditForename.Enabled = false;
            this.txteditForename.Location = new System.Drawing.Point(136, 185);
            this.txteditForename.Name = "txteditForename";
            this.txteditForename.Size = new System.Drawing.Size(416, 27);
            this.txteditForename.TabIndex = 45;
            // 
            // txteditSurname
            // 
            this.txteditSurname.Enabled = false;
            this.txteditSurname.Location = new System.Drawing.Point(136, 139);
            this.txteditSurname.Name = "txteditSurname";
            this.txteditSurname.Size = new System.Drawing.Size(416, 27);
            this.txteditSurname.TabIndex = 44;
            // 
            // lbledittelno
            // 
            this.lbledittelno.AutoSize = true;
            this.lbledittelno.Location = new System.Drawing.Point(16, 418);
            this.lbledittelno.Name = "lbledittelno";
            this.lbledittelno.Size = new System.Drawing.Size(105, 19);
            this.lbledittelno.TabIndex = 42;
            this.lbledittelno.Text = "Telephone No";
            // 
            // lbleditpostcode
            // 
            this.lbleditpostcode.AutoSize = true;
            this.lbleditpostcode.Location = new System.Drawing.Point(16, 372);
            this.lbleditpostcode.Name = "lbleditpostcode";
            this.lbleditpostcode.Size = new System.Drawing.Size(73, 19);
            this.lbleditpostcode.TabIndex = 41;
            this.lbleditpostcode.Text = "Postcode";
            // 
            // lbleditcounty
            // 
            this.lbleditcounty.AutoSize = true;
            this.lbleditcounty.Location = new System.Drawing.Point(16, 326);
            this.lbleditcounty.Name = "lbleditcounty";
            this.lbleditcounty.Size = new System.Drawing.Size(59, 19);
            this.lbleditcounty.TabIndex = 40;
            this.lbleditcounty.Text = "County";
            // 
            // lbledittown
            // 
            this.lbledittown.AutoSize = true;
            this.lbledittown.Location = new System.Drawing.Point(16, 280);
            this.lbledittown.Name = "lbledittown";
            this.lbledittown.Size = new System.Drawing.Size(47, 19);
            this.lbledittown.TabIndex = 39;
            this.lbledittown.Text = "Town";
            // 
            // lbleditstreet
            // 
            this.lbleditstreet.AutoSize = true;
            this.lbleditstreet.Location = new System.Drawing.Point(16, 234);
            this.lbleditstreet.Name = "lbleditstreet";
            this.lbleditstreet.Size = new System.Drawing.Size(52, 19);
            this.lbleditstreet.TabIndex = 38;
            this.lbleditstreet.Text = "Street";
            // 
            // lbleditforename
            // 
            this.lbleditforename.AutoSize = true;
            this.lbleditforename.Location = new System.Drawing.Point(16, 188);
            this.lbleditforename.Name = "lbleditforename";
            this.lbleditforename.Size = new System.Drawing.Size(79, 19);
            this.lbleditforename.TabIndex = 37;
            this.lbleditforename.Text = "Forename";
            // 
            // lbleditsurname
            // 
            this.lbleditsurname.AutoSize = true;
            this.lbleditsurname.Location = new System.Drawing.Point(16, 142);
            this.lbleditsurname.Name = "lbleditsurname";
            this.lbleditsurname.Size = new System.Drawing.Size(72, 19);
            this.lbleditsurname.TabIndex = 36;
            this.lbleditsurname.Text = "Surname";
            // 
            // lbledittitle
            // 
            this.lbledittitle.AutoSize = true;
            this.lbledittitle.Location = new System.Drawing.Point(16, 96);
            this.lbledittitle.Name = "lbledittitle";
            this.lbledittitle.Size = new System.Drawing.Size(40, 19);
            this.lbledittitle.TabIndex = 35;
            this.lbledittitle.Text = "Title";
            // 
            // lbleditCustNo
            // 
            this.lbleditCustNo.AutoSize = true;
            this.lbleditCustNo.Location = new System.Drawing.Point(131, 55);
            this.lbleditCustNo.Name = "lbleditCustNo";
            this.lbleditCustNo.Size = new System.Drawing.Size(0, 19);
            this.lbleditCustNo.TabIndex = 34;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 78);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kennel Club";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::KennelClub.Properties.Resources._5;
            this.pictureBox4.Location = new System.Drawing.Point(360, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(106, 78);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(947, 613);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabcustomer);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmCustomer";
            this.Text = "Customer";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.Shown += new System.EventHandler(this.frmCustomer_Shown);
            this.tabcustomer.ResumeLayout(false);
            this.tabdisplay.ResumeLayout(false);
            this.tabdisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.tabadd.ResumeLayout(false);
            this.tabadd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabedit.ResumeLayout(false);
            this.tabedit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabcustomer;
        private System.Windows.Forms.TabPage tabdisplay;
        private System.Windows.Forms.TabPage tabadd;
        private System.Windows.Forms.TabPage tabedit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btndisplayexit;
        private System.Windows.Forms.Button btndisplaydelete;
        private System.Windows.Forms.Button btndisplayedit;
        private System.Windows.Forms.Button btndisplayadd;
        private System.Windows.Forms.Label lbldisplayexit;
        private System.Windows.Forms.Label lbldisplaydelete;
        private System.Windows.Forms.Label lbldisplayedit;
        private System.Windows.Forms.Label lbldisplayadd;
        private System.Windows.Forms.Label lbladdpostcode;
        private System.Windows.Forms.Label lbladdcounty;
        private System.Windows.Forms.Label lbladdtown;
        private System.Windows.Forms.Label lbladdstreet;
        private System.Windows.Forms.Label lbladdforename;
        private System.Windows.Forms.Label lbladdsurname;
        private System.Windows.Forms.Label lbladdtitle;
        private System.Windows.Forms.Label lbladdCustNo;
        private System.Windows.Forms.Label lbladdcancel;
        private System.Windows.Forms.Button btnaddCancel;
        private System.Windows.Forms.Label lbladdadd;
        private System.Windows.Forms.Label lbladdtelno;
        private System.Windows.Forms.TextBox txtaddTelNo;
        private System.Windows.Forms.TextBox txtaddPostcode;
        private System.Windows.Forms.TextBox txtaddCounty;
        private System.Windows.Forms.TextBox txtaddTown;
        private System.Windows.Forms.TextBox txtaddStreet;
        private System.Windows.Forms.TextBox txtaddForename;
        private System.Windows.Forms.TextBox txtaddSurname;
        private System.Windows.Forms.ComboBox cmbaddTitle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txteditTelNo;
        private System.Windows.Forms.TextBox txteditPostcode;
        private System.Windows.Forms.TextBox txteditCounty;
        private System.Windows.Forms.TextBox txteditTown;
        private System.Windows.Forms.TextBox txteditStreet;
        private System.Windows.Forms.TextBox txteditForename;
        private System.Windows.Forms.TextBox txteditSurname;
        private System.Windows.Forms.Label lbledittelno;
        private System.Windows.Forms.Label lbleditpostcode;
        private System.Windows.Forms.Label lbleditcounty;
        private System.Windows.Forms.Label lbledittown;
        private System.Windows.Forms.Label lbleditstreet;
        private System.Windows.Forms.Label lbleditforename;
        private System.Windows.Forms.Label lbleditsurname;
        private System.Windows.Forms.Label lbledittitle;
        private System.Windows.Forms.Label lbleditCustNo;
        private System.Windows.Forms.Label lbleditcancel;
        private System.Windows.Forms.Button btneditCancel;
        private System.Windows.Forms.Label lbleditedit;
        private System.Windows.Forms.Button btnaddAdd;
        private System.Windows.Forms.Button btneditEdit;
        private System.Windows.Forms.ComboBox cmbeditTitle;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ErrorProvider errP;
        private System.Windows.Forms.Label lbladdCustomerNo;
        private System.Windows.Forms.Label lbleditCustomerNo;
    }
}

