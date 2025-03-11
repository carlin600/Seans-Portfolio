namespace LloydsPharmacy
{
    partial class frmMinorAilments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMinorAilments));
            this.ILMAilments = new System.Windows.Forms.ImageList(this.components);
            this.errProMinorAilments = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnOrderAilForm = new System.Windows.Forms.Button();
            this.lblBacktoMenu = new System.Windows.Forms.Label();
            this.lblMAilment = new System.Windows.Forms.Label();
            this.tabMinorAilments = new System.Windows.Forms.TabControl();
            this.tabDisplay = new System.Windows.Forms.TabPage();
            this.lblDisplayMA = new System.Windows.Forms.Label();
            this.lblSearchMinAilment = new System.Windows.Forms.Label();
            this.txtSearchAilment = new System.Windows.Forms.TextBox();
            this.dgvMinAilments = new System.Windows.Forms.DataGridView();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.cmbAddTypeID = new System.Windows.Forms.ComboBox();
            this.lblAddMinAID = new System.Windows.Forms.Label();
            this.lblAddAilmentID = new System.Windows.Forms.Label();
            this.btnCancelAddMA = new System.Windows.Forms.Button();
            this.btnAddMA = new System.Windows.Forms.Button();
            this.txtAddAilDesc = new System.Windows.Forms.TextBox();
            this.lblAddAilmentTypeID = new System.Windows.Forms.Label();
            this.lblAddAilmentDesc = new System.Windows.Forms.Label();
            this.lblAddNewAilment = new System.Windows.Forms.Label();
            this.tabEdit = new System.Windows.Forms.TabPage();
            this.cmbEditTypeID = new System.Windows.Forms.ComboBox();
            this.btnDelMA = new System.Windows.Forms.Button();
            this.lblEditMinAID = new System.Windows.Forms.Label();
            this.lblEditMAID = new System.Windows.Forms.Label();
            this.txtEditAilDesc = new System.Windows.Forms.TextBox();
            this.lblEditMATypeID = new System.Windows.Forms.Label();
            this.lblEditMADesc = new System.Windows.Forms.Label();
            this.btnCancelEditMA = new System.Windows.Forms.Button();
            this.btnEditMA = new System.Windows.Forms.Button();
            this.lblEditMA = new System.Windows.Forms.Label();
            this.tabReport = new System.Windows.Forms.TabPage();
            //this.crvMAilment = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
           // this.MinorAilments1 = new LloydsPharmacy.MinorAilments();
            this.label1 = new System.Windows.Forms.Label();
            this.picArrow = new System.Windows.Forms.PictureBox();
            this.PBIcon = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errProMinorAilments)).BeginInit();
            this.tabMinorAilments.SuspendLayout();
            this.tabDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMinAilments)).BeginInit();
            this.tabAdd.SuspendLayout();
            this.tabEdit.SuspendLayout();
            this.tabReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // ILMAilments
            // 
            this.ILMAilments.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ILMAilments.ImageStream")));
            this.ILMAilments.TransparentColor = System.Drawing.Color.Transparent;
            this.ILMAilments.Images.SetKeyName(0, "minor ailments.png");
            this.ILMAilments.Images.SetKeyName(1, "display minor ailments.png");
            this.ILMAilments.Images.SetKeyName(2, "add minor ailment.png");
            this.ILMAilments.Images.SetKeyName(3, "edit minor ailments.png");
            this.ILMAilments.Images.SetKeyName(4, "report.png");
            this.ILMAilments.Images.SetKeyName(5, "plus.png");
            this.ILMAilments.Images.SetKeyName(6, "pencil.png");
            this.ILMAilments.Images.SetKeyName(7, "trash.png");
            this.ILMAilments.Images.SetKeyName(8, "cancel.png");
            this.ILMAilments.Images.SetKeyName(9, "delivery-truck.png");
            // 
            // errProMinorAilments
            // 
            this.errProMinorAilments.ContainerControl = this;
            // 
            // btnOrderAilForm
            // 
            this.btnOrderAilForm.BackColor = System.Drawing.Color.Transparent;
            this.btnOrderAilForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderAilForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOrderAilForm.ImageList = this.ILMAilments;
            this.btnOrderAilForm.Location = new System.Drawing.Point(1141, 375);
            this.btnOrderAilForm.Name = "btnOrderAilForm";
            this.btnOrderAilForm.Size = new System.Drawing.Size(90, 68);
            this.btnOrderAilForm.TabIndex = 67;
            this.btnOrderAilForm.Text = "Order Ailments";
            this.btnOrderAilForm.UseVisualStyleBackColor = false;
            this.btnOrderAilForm.Click += new System.EventHandler(this.btnOrderAilForm_Click);
            this.btnOrderAilForm.MouseEnter += new System.EventHandler(this.btnOrderAilForm_MouseEnter);
            this.btnOrderAilForm.MouseLeave += new System.EventHandler(this.btnOrderAilForm_MouseLeave);
            // 
            // lblBacktoMenu
            // 
            this.lblBacktoMenu.AutoSize = true;
            this.lblBacktoMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBacktoMenu.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblBacktoMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblBacktoMenu.Location = new System.Drawing.Point(143, 131);
            this.lblBacktoMenu.Name = "lblBacktoMenu";
            this.lblBacktoMenu.Size = new System.Drawing.Size(144, 25);
            this.lblBacktoMenu.TabIndex = 65;
            this.lblBacktoMenu.Text = "Back to Menu";
            // 
            // lblMAilment
            // 
            this.lblMAilment.AutoSize = true;
            this.lblMAilment.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMAilment.Location = new System.Drawing.Point(447, 25);
            this.lblMAilment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMAilment.Name = "lblMAilment";
            this.lblMAilment.Size = new System.Drawing.Size(492, 75);
            this.lblMAilment.TabIndex = 63;
            this.lblMAilment.Text = "Minor Ailments";
            // 
            // tabMinorAilments
            // 
            this.tabMinorAilments.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabMinorAilments.Controls.Add(this.tabDisplay);
            this.tabMinorAilments.Controls.Add(this.tabAdd);
            this.tabMinorAilments.Controls.Add(this.tabEdit);
            this.tabMinorAilments.Controls.Add(this.tabReport);
            this.tabMinorAilments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabMinorAilments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMinorAilments.ImageList = this.ILMAilments;
            this.tabMinorAilments.ItemSize = new System.Drawing.Size(25, 50);
            this.tabMinorAilments.Location = new System.Drawing.Point(31, 171);
            this.tabMinorAilments.Multiline = true;
            this.tabMinorAilments.Name = "tabMinorAilments";
            this.tabMinorAilments.Padding = new System.Drawing.Point(6, 5);
            this.tabMinorAilments.SelectedIndex = 0;
            this.tabMinorAilments.Size = new System.Drawing.Size(1035, 588);
            this.tabMinorAilments.TabIndex = 61;
            this.tabMinorAilments.SelectedIndexChanged += new System.EventHandler(this.tabMinorAilments_SelectedIndexChanged);
            // 
            // tabDisplay
            // 
            this.tabDisplay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabDisplay.Controls.Add(this.lblDisplayMA);
            this.tabDisplay.Controls.Add(this.lblSearchMinAilment);
            this.tabDisplay.Controls.Add(this.txtSearchAilment);
            this.tabDisplay.Controls.Add(this.dgvMinAilments);
            this.tabDisplay.ImageIndex = 1;
            this.tabDisplay.Location = new System.Drawing.Point(54, 4);
            this.tabDisplay.Name = "tabDisplay";
            this.tabDisplay.Padding = new System.Windows.Forms.Padding(3);
            this.tabDisplay.Size = new System.Drawing.Size(977, 580);
            this.tabDisplay.TabIndex = 0;
            // 
            // lblDisplayMA
            // 
            this.lblDisplayMA.AutoSize = true;
            this.lblDisplayMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayMA.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDisplayMA.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDisplayMA.ImageIndex = 1;
            this.lblDisplayMA.ImageList = this.ILMAilments;
            this.lblDisplayMA.Location = new System.Drawing.Point(44, 24);
            this.lblDisplayMA.Name = "lblDisplayMA";
            this.lblDisplayMA.Size = new System.Drawing.Size(343, 31);
            this.lblDisplayMA.TabIndex = 47;
            this.lblDisplayMA.Text = "Display Minor Ailments    ";
            // 
            // lblSearchMinAilment
            // 
            this.lblSearchMinAilment.AutoSize = true;
            this.lblSearchMinAilment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchMinAilment.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSearchMinAilment.Location = new System.Drawing.Point(46, 75);
            this.lblSearchMinAilment.Name = "lblSearchMinAilment";
            this.lblSearchMinAilment.Size = new System.Drawing.Size(191, 24);
            this.lblSearchMinAilment.TabIndex = 46;
            this.lblSearchMinAilment.Text = "Search Ailment Desc:";
            // 
            // txtSearchAilment
            // 
            this.txtSearchAilment.Location = new System.Drawing.Point(243, 72);
            this.txtSearchAilment.Name = "txtSearchAilment";
            this.txtSearchAilment.Size = new System.Drawing.Size(190, 29);
            this.txtSearchAilment.TabIndex = 2;
            this.txtSearchAilment.TextChanged += new System.EventHandler(this.txtSearchAilment_TextChanged);
            // 
            // dgvMinAilments
            // 
            this.dgvMinAilments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMinAilments.Location = new System.Drawing.Point(23, 112);
            this.dgvMinAilments.Name = "dgvMinAilments";
            this.dgvMinAilments.RowHeadersWidth = 51;
            this.dgvMinAilments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMinAilments.Size = new System.Drawing.Size(933, 453);
            this.dgvMinAilments.TabIndex = 3;
            // 
            // tabAdd
            // 
            this.tabAdd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabAdd.Controls.Add(this.cmbAddTypeID);
            this.tabAdd.Controls.Add(this.lblAddMinAID);
            this.tabAdd.Controls.Add(this.lblAddAilmentID);
            this.tabAdd.Controls.Add(this.btnCancelAddMA);
            this.tabAdd.Controls.Add(this.btnAddMA);
            this.tabAdd.Controls.Add(this.txtAddAilDesc);
            this.tabAdd.Controls.Add(this.lblAddAilmentTypeID);
            this.tabAdd.Controls.Add(this.lblAddAilmentDesc);
            this.tabAdd.Controls.Add(this.lblAddNewAilment);
            this.tabAdd.ImageIndex = 2;
            this.tabAdd.Location = new System.Drawing.Point(54, 4);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(977, 580);
            this.tabAdd.TabIndex = 1;
            // 
            // cmbAddTypeID
            // 
            this.cmbAddTypeID.FormattingEnabled = true;
            this.cmbAddTypeID.Location = new System.Drawing.Point(260, 180);
            this.cmbAddTypeID.Name = "cmbAddTypeID";
            this.cmbAddTypeID.Size = new System.Drawing.Size(133, 32);
            this.cmbAddTypeID.TabIndex = 5;
            // 
            // lblAddMinAID
            // 
            this.lblAddMinAID.AutoSize = true;
            this.lblAddMinAID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMinAID.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblAddMinAID.Location = new System.Drawing.Point(256, 83);
            this.lblAddMinAID.Name = "lblAddMinAID";
            this.lblAddMinAID.Size = new System.Drawing.Size(17, 24);
            this.lblAddMinAID.TabIndex = 24;
            this.lblAddMinAID.Text = "-";
            // 
            // lblAddAilmentID
            // 
            this.lblAddAilmentID.AutoSize = true;
            this.lblAddAilmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAilmentID.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblAddAilmentID.Location = new System.Drawing.Point(46, 83);
            this.lblAddAilmentID.Name = "lblAddAilmentID";
            this.lblAddAilmentID.Size = new System.Drawing.Size(95, 24);
            this.lblAddAilmentID.TabIndex = 23;
            this.lblAddAilmentID.Text = "Ailment ID";
            // 
            // btnCancelAddMA
            // 
            this.btnCancelAddMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAddMA.ImageList = this.ILMAilments;
            this.btnCancelAddMA.Location = new System.Drawing.Point(780, 310);
            this.btnCancelAddMA.Name = "btnCancelAddMA";
            this.btnCancelAddMA.Size = new System.Drawing.Size(90, 53);
            this.btnCancelAddMA.TabIndex = 7;
            this.btnCancelAddMA.Text = "Cancel";
            this.btnCancelAddMA.UseVisualStyleBackColor = true;
            this.btnCancelAddMA.Click += new System.EventHandler(this.btnCancelAddMA_Click);
            this.btnCancelAddMA.MouseEnter += new System.EventHandler(this.btnCancelAddMA_MouseEnter);
            this.btnCancelAddMA.MouseLeave += new System.EventHandler(this.btnCancelAddMA_MouseLeave);
            // 
            // btnAddMA
            // 
            this.btnAddMA.BackColor = System.Drawing.Color.Transparent;
            this.btnAddMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddMA.ImageList = this.ILMAilments;
            this.btnAddMA.Location = new System.Drawing.Point(780, 230);
            this.btnAddMA.Name = "btnAddMA";
            this.btnAddMA.Size = new System.Drawing.Size(90, 53);
            this.btnAddMA.TabIndex = 6;
            this.btnAddMA.Text = "Add";
            this.btnAddMA.UseVisualStyleBackColor = false;
            this.btnAddMA.Click += new System.EventHandler(this.btnAddMA_Click);
            this.btnAddMA.MouseEnter += new System.EventHandler(this.btnAddMA_MouseEnter);
            this.btnAddMA.MouseLeave += new System.EventHandler(this.btnAddMA_MouseLeave);
            // 
            // txtAddAilDesc
            // 
            this.txtAddAilDesc.Location = new System.Drawing.Point(260, 130);
            this.txtAddAilDesc.Multiline = true;
            this.txtAddAilDesc.Name = "txtAddAilDesc";
            this.txtAddAilDesc.Size = new System.Drawing.Size(259, 29);
            this.txtAddAilDesc.TabIndex = 4;
            // 
            // lblAddAilmentTypeID
            // 
            this.lblAddAilmentTypeID.AutoSize = true;
            this.lblAddAilmentTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAilmentTypeID.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblAddAilmentTypeID.Location = new System.Drawing.Point(46, 183);
            this.lblAddAilmentTypeID.Name = "lblAddAilmentTypeID";
            this.lblAddAilmentTypeID.Size = new System.Drawing.Size(121, 24);
            this.lblAddAilmentTypeID.TabIndex = 2;
            this.lblAddAilmentTypeID.Text = "Ailment Type";
            // 
            // lblAddAilmentDesc
            // 
            this.lblAddAilmentDesc.AutoSize = true;
            this.lblAddAilmentDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAilmentDesc.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblAddAilmentDesc.Location = new System.Drawing.Point(46, 133);
            this.lblAddAilmentDesc.Name = "lblAddAilmentDesc";
            this.lblAddAilmentDesc.Size = new System.Drawing.Size(172, 24);
            this.lblAddAilmentDesc.TabIndex = 1;
            this.lblAddAilmentDesc.Text = "Ailment Description";
            // 
            // lblAddNewAilment
            // 
            this.lblAddNewAilment.AutoSize = true;
            this.lblAddNewAilment.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewAilment.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblAddNewAilment.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAddNewAilment.ImageIndex = 2;
            this.lblAddNewAilment.ImageList = this.ILMAilments;
            this.lblAddNewAilment.Location = new System.Drawing.Point(44, 24);
            this.lblAddNewAilment.Name = "lblAddNewAilment";
            this.lblAddNewAilment.Size = new System.Drawing.Size(283, 31);
            this.lblAddNewAilment.TabIndex = 0;
            this.lblAddNewAilment.Text = "Add New Ailments    ";
            // 
            // tabEdit
            // 
            this.tabEdit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabEdit.Controls.Add(this.cmbEditTypeID);
            this.tabEdit.Controls.Add(this.btnDelMA);
            this.tabEdit.Controls.Add(this.lblEditMinAID);
            this.tabEdit.Controls.Add(this.lblEditMAID);
            this.tabEdit.Controls.Add(this.txtEditAilDesc);
            this.tabEdit.Controls.Add(this.lblEditMATypeID);
            this.tabEdit.Controls.Add(this.lblEditMADesc);
            this.tabEdit.Controls.Add(this.btnCancelEditMA);
            this.tabEdit.Controls.Add(this.btnEditMA);
            this.tabEdit.Controls.Add(this.lblEditMA);
            this.tabEdit.ImageIndex = 3;
            this.tabEdit.Location = new System.Drawing.Point(54, 4);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabEdit.Size = new System.Drawing.Size(977, 580);
            this.tabEdit.TabIndex = 2;
            // 
            // cmbEditTypeID
            // 
            this.cmbEditTypeID.FormattingEnabled = true;
            this.cmbEditTypeID.Items.AddRange(new object[] {
            "AITY100",
            "AITY101",
            "AITY102",
            "AITY103",
            "AITY104",
            "AITY105",
            "AITY106",
            "AITY107",
            "AITY108",
            "AITY109",
            "AITY110",
            "AITY111",
            "AITY112",
            "AITY113",
            "AITY114"});
            this.cmbEditTypeID.Location = new System.Drawing.Point(260, 180);
            this.cmbEditTypeID.Name = "cmbEditTypeID";
            this.cmbEditTypeID.Size = new System.Drawing.Size(133, 32);
            this.cmbEditTypeID.TabIndex = 9;
            // 
            // btnDelMA
            // 
            this.btnDelMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelMA.ImageList = this.ILMAilments;
            this.btnDelMA.Location = new System.Drawing.Point(780, 270);
            this.btnDelMA.Name = "btnDelMA";
            this.btnDelMA.Size = new System.Drawing.Size(90, 53);
            this.btnDelMA.TabIndex = 11;
            this.btnDelMA.Text = "Delete";
            this.btnDelMA.UseVisualStyleBackColor = true;
            this.btnDelMA.Click += new System.EventHandler(this.btnDelMA_Click);
            this.btnDelMA.MouseEnter += new System.EventHandler(this.btnDelMA_MouseEnter);
            this.btnDelMA.MouseLeave += new System.EventHandler(this.btnDelMA_MouseLeave);
            // 
            // lblEditMinAID
            // 
            this.lblEditMinAID.AutoSize = true;
            this.lblEditMinAID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditMinAID.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblEditMinAID.Location = new System.Drawing.Point(256, 83);
            this.lblEditMinAID.Name = "lblEditMinAID";
            this.lblEditMinAID.Size = new System.Drawing.Size(17, 24);
            this.lblEditMinAID.TabIndex = 43;
            this.lblEditMinAID.Text = "-";
            // 
            // lblEditMAID
            // 
            this.lblEditMAID.AutoSize = true;
            this.lblEditMAID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditMAID.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblEditMAID.Location = new System.Drawing.Point(46, 83);
            this.lblEditMAID.Name = "lblEditMAID";
            this.lblEditMAID.Size = new System.Drawing.Size(95, 24);
            this.lblEditMAID.TabIndex = 42;
            this.lblEditMAID.Text = "Ailment ID";
            // 
            // txtEditAilDesc
            // 
            this.txtEditAilDesc.Location = new System.Drawing.Point(260, 130);
            this.txtEditAilDesc.Multiline = true;
            this.txtEditAilDesc.Name = "txtEditAilDesc";
            this.txtEditAilDesc.Size = new System.Drawing.Size(259, 29);
            this.txtEditAilDesc.TabIndex = 8;
            // 
            // lblEditMATypeID
            // 
            this.lblEditMATypeID.AutoSize = true;
            this.lblEditMATypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditMATypeID.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblEditMATypeID.Location = new System.Drawing.Point(46, 183);
            this.lblEditMATypeID.Name = "lblEditMATypeID";
            this.lblEditMATypeID.Size = new System.Drawing.Size(121, 24);
            this.lblEditMATypeID.TabIndex = 31;
            this.lblEditMATypeID.Text = "Ailment Type";
            // 
            // lblEditMADesc
            // 
            this.lblEditMADesc.AutoSize = true;
            this.lblEditMADesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditMADesc.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblEditMADesc.Location = new System.Drawing.Point(46, 133);
            this.lblEditMADesc.Name = "lblEditMADesc";
            this.lblEditMADesc.Size = new System.Drawing.Size(172, 24);
            this.lblEditMADesc.TabIndex = 30;
            this.lblEditMADesc.Text = "Ailment Description";
            // 
            // btnCancelEditMA
            // 
            this.btnCancelEditMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEditMA.ImageList = this.ILMAilments;
            this.btnCancelEditMA.Location = new System.Drawing.Point(780, 350);
            this.btnCancelEditMA.Name = "btnCancelEditMA";
            this.btnCancelEditMA.Size = new System.Drawing.Size(90, 53);
            this.btnCancelEditMA.TabIndex = 12;
            this.btnCancelEditMA.Text = "Cancel";
            this.btnCancelEditMA.UseVisualStyleBackColor = true;
            this.btnCancelEditMA.Click += new System.EventHandler(this.btnCancelEditMA_Click);
            this.btnCancelEditMA.MouseEnter += new System.EventHandler(this.btnCancelEditMA_MouseEnter);
            this.btnCancelEditMA.MouseLeave += new System.EventHandler(this.btnCancelEditMA_MouseLeave);
            // 
            // btnEditMA
            // 
            this.btnEditMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMA.ImageList = this.ILMAilments;
            this.btnEditMA.Location = new System.Drawing.Point(780, 190);
            this.btnEditMA.Name = "btnEditMA";
            this.btnEditMA.Size = new System.Drawing.Size(90, 53);
            this.btnEditMA.TabIndex = 10;
            this.btnEditMA.Text = "Edit";
            this.btnEditMA.UseVisualStyleBackColor = true;
            this.btnEditMA.Click += new System.EventHandler(this.btnEditMA_Click);
            this.btnEditMA.MouseEnter += new System.EventHandler(this.btnEditMA_MouseEnter);
            this.btnEditMA.MouseLeave += new System.EventHandler(this.btnEditMA_MouseLeave);
            // 
            // lblEditMA
            // 
            this.lblEditMA.AutoSize = true;
            this.lblEditMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditMA.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblEditMA.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEditMA.ImageIndex = 3;
            this.lblEditMA.ImageList = this.ILMAilments;
            this.lblEditMA.Location = new System.Drawing.Point(44, 24);
            this.lblEditMA.Name = "lblEditMA";
            this.lblEditMA.Size = new System.Drawing.Size(344, 31);
            this.lblEditMA.TabIndex = 15;
            this.lblEditMA.Text = "Edit Existing Ailments      ";
            // 
            // tabReport
            // 
            this.tabReport.BackColor = System.Drawing.Color.WhiteSmoke;
          //  this.tabReport.Controls.Add(this.crvMAilment);
            this.tabReport.Controls.Add(this.label1);
            this.tabReport.ImageIndex = 4;
            this.tabReport.Location = new System.Drawing.Point(54, 4);
            this.tabReport.Name = "tabReport";
            this.tabReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabReport.Size = new System.Drawing.Size(977, 580);
            this.tabReport.TabIndex = 3;
            // 
            // crvMAilment
            // 
           /* this.crvMAilment.ActiveViewIndex = 0;
            this.crvMAilment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvMAilment.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvMAilment.Location = new System.Drawing.Point(6, 71);
            this.crvMAilment.Name = "crvMAilment";
            this.crvMAilment.ReportSource = this.MinorAilments1;
            this.crvMAilment.Size = new System.Drawing.Size(971, 521);
            this.crvMAilment.TabIndex = 49;*/
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.ImageIndex = 4;
            this.label1.ImageList = this.ILMAilments;
            this.label1.Location = new System.Drawing.Point(44, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 31);
            this.label1.TabIndex = 48;
            this.label1.Text = "Minor Ailments Report    ";
            // 
            // picArrow
            // 
            this.picArrow.BackColor = System.Drawing.Color.White;
            this.picArrow.Location = new System.Drawing.Point(281, 103);
            this.picArrow.Name = "picArrow";
            this.picArrow.Size = new System.Drawing.Size(48, 46);
            this.picArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picArrow.TabIndex = 66;
            this.picArrow.TabStop = false;
            this.picArrow.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // PBIcon
            // 
            this.PBIcon.Image = global::LloydsPharmacy.Properties.Resources.minor_ailments;
            this.PBIcon.Location = new System.Drawing.Point(930, 19);
            this.PBIcon.Margin = new System.Windows.Forms.Padding(2);
            this.PBIcon.Name = "PBIcon";
            this.PBIcon.Size = new System.Drawing.Size(90, 81);
            this.PBIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBIcon.TabIndex = 64;
            this.PBIcon.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.SystemColors.Control;
            this.pbLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogo.Image = global::LloydsPharmacy.Properties.Resources.logo;
            this.pbLogo.Location = new System.Drawing.Point(33, 25);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(409, 76);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 62;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // frmMinorAilments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 779);
            this.Controls.Add(this.btnOrderAilForm);
            this.Controls.Add(this.picArrow);
            this.Controls.Add(this.lblBacktoMenu);
            this.Controls.Add(this.PBIcon);
            this.Controls.Add(this.lblMAilment);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.tabMinorAilments);
            this.Name = "frmMinorAilments";
            this.Text = "frmMinorAilments";
            this.Load += new System.EventHandler(this.frmMinorAilments_Load);
            this.Shown += new System.EventHandler(this.frmMinorAilments_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.errProMinorAilments)).EndInit();
            this.tabMinorAilments.ResumeLayout(false);
            this.tabDisplay.ResumeLayout(false);
            this.tabDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMinAilments)).EndInit();
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

        private System.Windows.Forms.ImageList ILMAilments;
        private System.Windows.Forms.ErrorProvider errProMinorAilments;
        private System.Windows.Forms.Button btnOrderAilForm;
        private System.Windows.Forms.PictureBox picArrow;
        private System.Windows.Forms.Label lblBacktoMenu;
        private System.Windows.Forms.PictureBox PBIcon;
        private System.Windows.Forms.Label lblMAilment;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TabControl tabMinorAilments;
        private System.Windows.Forms.TabPage tabDisplay;
        private System.Windows.Forms.Label lblDisplayMA;
        private System.Windows.Forms.Label lblSearchMinAilment;
        private System.Windows.Forms.TextBox txtSearchAilment;
        private System.Windows.Forms.DataGridView dgvMinAilments;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.ComboBox cmbAddTypeID;
        private System.Windows.Forms.Label lblAddMinAID;
        private System.Windows.Forms.Label lblAddAilmentID;
        private System.Windows.Forms.Button btnCancelAddMA;
        private System.Windows.Forms.Button btnAddMA;
        private System.Windows.Forms.TextBox txtAddAilDesc;
        private System.Windows.Forms.Label lblAddAilmentTypeID;
        private System.Windows.Forms.Label lblAddAilmentDesc;
        private System.Windows.Forms.Label lblAddNewAilment;
        private System.Windows.Forms.TabPage tabEdit;
        private System.Windows.Forms.ComboBox cmbEditTypeID;
        private System.Windows.Forms.Button btnDelMA;
        private System.Windows.Forms.Label lblEditMinAID;
        private System.Windows.Forms.Label lblEditMAID;
        private System.Windows.Forms.TextBox txtEditAilDesc;
        private System.Windows.Forms.Label lblEditMATypeID;
        private System.Windows.Forms.Label lblEditMADesc;
        private System.Windows.Forms.Button btnCancelEditMA;
        private System.Windows.Forms.Button btnEditMA;
        private System.Windows.Forms.Label lblEditMA;
        private System.Windows.Forms.TabPage tabReport;
        private System.Windows.Forms.Label label1;
        //private CrystalDecisions.Windows.Forms.CrystalReportViewer crvMAilment;
      // private MinorAilments MinorAilments1;
        //private MinorAilments MinorAilments1;
    }
}