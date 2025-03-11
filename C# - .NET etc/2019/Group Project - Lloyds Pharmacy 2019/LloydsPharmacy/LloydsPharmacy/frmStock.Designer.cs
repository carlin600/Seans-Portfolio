namespace LloydsPharmacy
{
    partial class frmStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStock));
            this.ILStock = new System.Windows.Forms.ImageList(this.components);
            this.tabStock = new System.Windows.Forms.TabControl();
            this.tabDisplay = new System.Windows.Forms.TabPage();
            this.pnlStockInfo = new System.Windows.Forms.Panel();
            this.txtDisStockDescData = new System.Windows.Forms.TextBox();
            this.lblDisStockPriceData = new System.Windows.Forms.Label();
            this.lblDisQTYInStockData = new System.Windows.Forms.Label();
            this.lblSDistockTypeIDData = new System.Windows.Forms.Label();
            this.lblDisStockIDData = new System.Windows.Forms.Label();
            this.lblDisStockPrice = new System.Windows.Forms.Label();
            this.lblDisQTYIS = new System.Windows.Forms.Label();
            this.lblDisSTID = new System.Windows.Forms.Label();
            this.lblDisStockDesc = new System.Windows.Forms.Label();
            this.lblDisStockID = new System.Windows.Forms.Label();
            this.lblDisStockByType = new System.Windows.Forms.Label();
            this.cmbStockType = new System.Windows.Forms.ComboBox();
            this.btnDisEdit = new System.Windows.Forms.Button();
            this.btnDisAdd = new System.Windows.Forms.Button();
            this.btnDisDel = new System.Windows.Forms.Button();
            this.btnDisExit = new System.Windows.Forms.Button();
            this.lblDisplayStock = new System.Windows.Forms.Label();
            this.lblSearchStockID = new System.Windows.Forms.Label();
            this.txtSearchStockName = new System.Windows.Forms.TextBox();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.cmbAddSuppID = new System.Windows.Forms.ComboBox();
            this.cmbAddStockTypeID = new System.Windows.Forms.ComboBox();
            this.lblAddSuppID = new System.Windows.Forms.Label();
            this.btnAddCancelStock = new System.Windows.Forms.Button();
            this.btnAddDis = new System.Windows.Forms.Button();
            this.btnAddEditStock = new System.Windows.Forms.Button();
            this.btnAddDelStock = new System.Windows.Forms.Button();
            this.btnAddAddStock = new System.Windows.Forms.Button();
            this.txtAddStockPrice = new System.Windows.Forms.TextBox();
            this.txtAddQTY = new System.Windows.Forms.TextBox();
            this.txtAddStockDesc = new System.Windows.Forms.TextBox();
            this.txtAddStockID = new System.Windows.Forms.TextBox();
            this.lblAddStockPrice = new System.Windows.Forms.Label();
            this.lblAddStockQTY = new System.Windows.Forms.Label();
            this.lblAddStockTypeID = new System.Windows.Forms.Label();
            this.lblAddStockDesc = new System.Windows.Forms.Label();
            this.lblAddStockID = new System.Windows.Forms.Label();
            this.lblAddStock = new System.Windows.Forms.Label();
            this.tabEdit = new System.Windows.Forms.TabPage();
            this.btnEditUpdateStock = new System.Windows.Forms.Button();
            this.cmbEditSuppID = new System.Windows.Forms.ComboBox();
            this.cmbEditStockTypeID = new System.Windows.Forms.ComboBox();
            this.lblEditSuppID = new System.Windows.Forms.Label();
            this.btnEditCancelStock = new System.Windows.Forms.Button();
            this.btnEditAddStock = new System.Windows.Forms.Button();
            this.btnEditDisplay = new System.Windows.Forms.Button();
            this.lblEditStock = new System.Windows.Forms.Label();
            this.btnEditDelStock = new System.Windows.Forms.Button();
            this.btnEditEditStock = new System.Windows.Forms.Button();
            this.txtEditStockPrice = new System.Windows.Forms.TextBox();
            this.txtEditQTY = new System.Windows.Forms.TextBox();
            this.txtEditStockDesc = new System.Windows.Forms.TextBox();
            this.txtEditStockID = new System.Windows.Forms.TextBox();
            this.lblStockPrice = new System.Windows.Forms.Label();
            this.lblQTYInStock = new System.Windows.Forms.Label();
            this.lblStockTypeID = new System.Windows.Forms.Label();
            this.lblStockDesc = new System.Windows.Forms.Label();
            this.lblEditStockID = new System.Windows.Forms.Label();
            this.tabReport = new System.Windows.Forms.TabPage();
            this.lblDisByStockType = new System.Windows.Forms.Label();
            this.cmbDisByStockType = new System.Windows.Forms.ComboBox();
            this.btnViewAllData = new System.Windows.Forms.Button();
            this.lblReportSupplier = new System.Windows.Forms.Label();
            this.cmbReportSupplier = new System.Windows.Forms.ComboBox();
         //   this.crvReports = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
         //   this.lblStock = new System.Windows.Forms.Label();
            this.PBIcon = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
//this.rptAllStock1 = new LloydsPharmacy.rptAllStock();
            this.tabStock.SuspendLayout();
            this.tabDisplay.SuspendLayout();
            this.pnlStockInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.tabAdd.SuspendLayout();
            this.tabEdit.SuspendLayout();
            this.tabReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            this.SuspendLayout();
            // 
            // ILStock
            // 
            this.ILStock.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ILStock.ImageStream")));
            this.ILStock.TransparentColor = System.Drawing.Color.Transparent;
            this.ILStock.Images.SetKeyName(0, "stock.png");
            this.ILStock.Images.SetKeyName(1, "add stock.png");
            this.ILStock.Images.SetKeyName(2, "edit stock.png");
            this.ILStock.Images.SetKeyName(3, "update stock .png");
            this.ILStock.Images.SetKeyName(4, "delete stock.png");
            this.ILStock.Images.SetKeyName(5, "cancel.png");
            this.ILStock.Images.SetKeyName(6, "stock 2.png");
            this.ILStock.Images.SetKeyName(7, "exit.png");
            this.ILStock.Images.SetKeyName(8, "display.png");
            this.ILStock.Images.SetKeyName(9, "stockReport.png");
            // 
            // tabStock
            // 
            this.tabStock.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabStock.Controls.Add(this.tabDisplay);
            this.tabStock.Controls.Add(this.tabAdd);
            this.tabStock.Controls.Add(this.tabEdit);
            this.tabStock.Controls.Add(this.tabReport);
            this.tabStock.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabStock.ImageList = this.ILStock;
            this.tabStock.Location = new System.Drawing.Point(-2, 103);
            this.tabStock.Multiline = true;
            this.tabStock.Name = "tabStock";
            this.tabStock.Padding = new System.Drawing.Point(6, 5);
            this.tabStock.SelectedIndex = 0;
            this.tabStock.Size = new System.Drawing.Size(1261, 659);
            this.tabStock.TabIndex = 40;
            this.tabStock.SelectedIndexChanged += new System.EventHandler(this.tabStock_SelectedIndexChanged);
            // 
            // tabDisplay
            // 
            this.tabDisplay.Controls.Add(this.pnlStockInfo);
            this.tabDisplay.Controls.Add(this.lblDisStockByType);
            this.tabDisplay.Controls.Add(this.cmbStockType);
            this.tabDisplay.Controls.Add(this.btnDisEdit);
            this.tabDisplay.Controls.Add(this.btnDisAdd);
            this.tabDisplay.Controls.Add(this.btnDisDel);
            this.tabDisplay.Controls.Add(this.btnDisExit);
            this.tabDisplay.Controls.Add(this.lblDisplayStock);
            this.tabDisplay.Controls.Add(this.lblSearchStockID);
            this.tabDisplay.Controls.Add(this.txtSearchStockName);
            this.tabDisplay.Controls.Add(this.dgvStock);
            this.tabDisplay.ImageIndex = 0;
            this.tabDisplay.Location = new System.Drawing.Point(46, 4);
            this.tabDisplay.Name = "tabDisplay";
            this.tabDisplay.Padding = new System.Windows.Forms.Padding(3);
            this.tabDisplay.Size = new System.Drawing.Size(1211, 651);
            this.tabDisplay.TabIndex = 0;
            this.tabDisplay.UseVisualStyleBackColor = true;
            // 
            // pnlStockInfo
            // 
            this.pnlStockInfo.Controls.Add(this.txtDisStockDescData);
            this.pnlStockInfo.Controls.Add(this.lblDisStockPriceData);
            this.pnlStockInfo.Controls.Add(this.lblDisQTYInStockData);
            this.pnlStockInfo.Controls.Add(this.lblSDistockTypeIDData);
            this.pnlStockInfo.Controls.Add(this.lblDisStockIDData);
            this.pnlStockInfo.Controls.Add(this.lblDisStockPrice);
            this.pnlStockInfo.Controls.Add(this.lblDisQTYIS);
            this.pnlStockInfo.Controls.Add(this.lblDisSTID);
            this.pnlStockInfo.Controls.Add(this.lblDisStockDesc);
            this.pnlStockInfo.Controls.Add(this.lblDisStockID);
            this.pnlStockInfo.Location = new System.Drawing.Point(854, 330);
            this.pnlStockInfo.Name = "pnlStockInfo";
            this.pnlStockInfo.Size = new System.Drawing.Size(351, 315);
            this.pnlStockInfo.TabIndex = 150;
            // 
            // txtDisStockDescData
            // 
            this.txtDisStockDescData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisStockDescData.Location = new System.Drawing.Point(172, 89);
            this.txtDisStockDescData.Multiline = true;
            this.txtDisStockDescData.Name = "txtDisStockDescData";
            this.txtDisStockDescData.Size = new System.Drawing.Size(147, 46);
            this.txtDisStockDescData.TabIndex = 151;
            // 
            // lblDisStockPriceData
            // 
            this.lblDisStockPriceData.AutoSize = true;
            this.lblDisStockPriceData.Location = new System.Drawing.Point(172, 278);
            this.lblDisStockPriceData.Name = "lblDisStockPriceData";
            this.lblDisStockPriceData.Size = new System.Drawing.Size(0, 22);
            this.lblDisStockPriceData.TabIndex = 9;
            // 
            // lblDisQTYInStockData
            // 
            this.lblDisQTYInStockData.AutoSize = true;
            this.lblDisQTYInStockData.Location = new System.Drawing.Point(172, 215);
            this.lblDisQTYInStockData.Name = "lblDisQTYInStockData";
            this.lblDisQTYInStockData.Size = new System.Drawing.Size(0, 22);
            this.lblDisQTYInStockData.TabIndex = 8;
            // 
            // lblSDistockTypeIDData
            // 
            this.lblSDistockTypeIDData.AutoSize = true;
            this.lblSDistockTypeIDData.Location = new System.Drawing.Point(172, 152);
            this.lblSDistockTypeIDData.Name = "lblSDistockTypeIDData";
            this.lblSDistockTypeIDData.Size = new System.Drawing.Size(0, 22);
            this.lblSDistockTypeIDData.TabIndex = 7;
            // 
            // lblDisStockIDData
            // 
            this.lblDisStockIDData.AutoSize = true;
            this.lblDisStockIDData.Location = new System.Drawing.Point(172, 26);
            this.lblDisStockIDData.Name = "lblDisStockIDData";
            this.lblDisStockIDData.Size = new System.Drawing.Size(0, 22);
            this.lblDisStockIDData.TabIndex = 5;
            // 
            // lblDisStockPrice
            // 
            this.lblDisStockPrice.AutoSize = true;
            this.lblDisStockPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisStockPrice.Location = new System.Drawing.Point(57, 278);
            this.lblDisStockPrice.Name = "lblDisStockPrice";
            this.lblDisStockPrice.Size = new System.Drawing.Size(114, 23);
            this.lblDisStockPrice.TabIndex = 4;
            this.lblDisStockPrice.Text = "Stock Price:";
            // 
            // lblDisQTYIS
            // 
            this.lblDisQTYIS.AutoSize = true;
            this.lblDisQTYIS.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisQTYIS.Location = new System.Drawing.Point(12, 215);
            this.lblDisQTYIS.Name = "lblDisQTYIS";
            this.lblDisQTYIS.Size = new System.Drawing.Size(170, 23);
            this.lblDisQTYIS.TabIndex = 3;
            this.lblDisQTYIS.Text = "Quantity In Stock:";
            // 
            // lblDisSTID
            // 
            this.lblDisSTID.AutoSize = true;
            this.lblDisSTID.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisSTID.Location = new System.Drawing.Point(34, 152);
            this.lblDisSTID.Name = "lblDisSTID";
            this.lblDisSTID.Size = new System.Drawing.Size(138, 23);
            this.lblDisSTID.TabIndex = 2;
            this.lblDisSTID.Text = "Stock Type ID:";
            // 
            // lblDisStockDesc
            // 
            this.lblDisStockDesc.AutoSize = true;
            this.lblDisStockDesc.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisStockDesc.Location = new System.Drawing.Point(5, 89);
            this.lblDisStockDesc.Name = "lblDisStockDesc";
            this.lblDisStockDesc.Size = new System.Drawing.Size(172, 23);
            this.lblDisStockDesc.TabIndex = 1;
            this.lblDisStockDesc.Text = "Stock Description:";
            // 
            // lblDisStockID
            // 
            this.lblDisStockID.AutoSize = true;
            this.lblDisStockID.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisStockID.Location = new System.Drawing.Point(81, 26);
            this.lblDisStockID.Name = "lblDisStockID";
            this.lblDisStockID.Size = new System.Drawing.Size(90, 23);
            this.lblDisStockID.TabIndex = 0;
            this.lblDisStockID.Text = "Stock ID:";
            // 
            // lblDisStockByType
            // 
            this.lblDisStockByType.AutoSize = true;
            this.lblDisStockByType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisStockByType.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDisStockByType.Location = new System.Drawing.Point(39, 94);
            this.lblDisStockByType.Name = "lblDisStockByType";
            this.lblDisStockByType.Size = new System.Drawing.Size(149, 24);
            this.lblDisStockByType.TabIndex = 149;
            this.lblDisStockByType.Text = "Display By Type:";
            this.lblDisStockByType.Click += new System.EventHandler(this.lblDisStockByType_Click);
            // 
            // cmbStockType
            // 
            this.cmbStockType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStockType.FormattingEnabled = true;
            this.cmbStockType.Items.AddRange(new object[] {
            " "});
            this.cmbStockType.Location = new System.Drawing.Point(194, 94);
            this.cmbStockType.Name = "cmbStockType";
            this.cmbStockType.Size = new System.Drawing.Size(190, 29);
            this.cmbStockType.TabIndex = 148;
            this.cmbStockType.SelectedIndexChanged += new System.EventHandler(this.cmbStockType_SelectedIndexChanged);
            // 
            // btnDisEdit
            // 
            this.btnDisEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnDisEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDisEdit.ImageList = this.ILStock;
            this.btnDisEdit.Location = new System.Drawing.Point(1098, 60);
            this.btnDisEdit.Name = "btnDisEdit";
            this.btnDisEdit.Size = new System.Drawing.Size(90, 40);
            this.btnDisEdit.TabIndex = 146;
            this.btnDisEdit.Text = "Edit";
            this.btnDisEdit.UseVisualStyleBackColor = false;
            this.btnDisEdit.Click += new System.EventHandler(this.btnDisEdit_Click);
            this.btnDisEdit.MouseEnter += new System.EventHandler(this.btnDisEdit_MouseEnter);
            this.btnDisEdit.MouseLeave += new System.EventHandler(this.btnDisEdit_MouseLeave);
            // 
            // btnDisAdd
            // 
            this.btnDisAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnDisAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDisAdd.ImageList = this.ILStock;
            this.btnDisAdd.Location = new System.Drawing.Point(1098, 14);
            this.btnDisAdd.Name = "btnDisAdd";
            this.btnDisAdd.Size = new System.Drawing.Size(90, 40);
            this.btnDisAdd.TabIndex = 145;
            this.btnDisAdd.Text = "Add";
            this.btnDisAdd.UseVisualStyleBackColor = false;
            this.btnDisAdd.Click += new System.EventHandler(this.btnDisAdd_Click);
            this.btnDisAdd.MouseEnter += new System.EventHandler(this.btnDisAdd_MouseEnter);
            this.btnDisAdd.MouseLeave += new System.EventHandler(this.btnDisAdd_MouseLeave);
            // 
            // btnDisDel
            // 
            this.btnDisDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisDel.ImageList = this.ILStock;
            this.btnDisDel.Location = new System.Drawing.Point(1098, 106);
            this.btnDisDel.Name = "btnDisDel";
            this.btnDisDel.Size = new System.Drawing.Size(90, 40);
            this.btnDisDel.TabIndex = 144;
            this.btnDisDel.Text = "Delete";
            this.btnDisDel.UseVisualStyleBackColor = true;
            this.btnDisDel.Click += new System.EventHandler(this.btnDisDel_Click);
            this.btnDisDel.MouseEnter += new System.EventHandler(this.btnDisDel_MouseEnter);
            this.btnDisDel.MouseLeave += new System.EventHandler(this.btnDisDel_MouseLeave);
            // 
            // btnDisExit
            // 
            this.btnDisExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisExit.ImageList = this.ILStock;
            this.btnDisExit.Location = new System.Drawing.Point(1098, 152);
            this.btnDisExit.Name = "btnDisExit";
            this.btnDisExit.Size = new System.Drawing.Size(90, 40);
            this.btnDisExit.TabIndex = 143;
            this.btnDisExit.Text = "Exit";
            this.btnDisExit.UseVisualStyleBackColor = true;
            this.btnDisExit.Click += new System.EventHandler(this.btnDisExit_Click);
            this.btnDisExit.MouseEnter += new System.EventHandler(this.btnDisExit_MouseEnter);
            this.btnDisExit.MouseLeave += new System.EventHandler(this.btnDisExit_MouseLeave);
            // 
            // lblDisplayStock
            // 
            this.lblDisplayStock.AutoSize = true;
            this.lblDisplayStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayStock.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDisplayStock.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDisplayStock.ImageIndex = 0;
            this.lblDisplayStock.ImageList = this.ILStock;
            this.lblDisplayStock.Location = new System.Drawing.Point(6, 14);
            this.lblDisplayStock.Name = "lblDisplayStock";
            this.lblDisplayStock.Size = new System.Drawing.Size(241, 31);
            this.lblDisplayStock.TabIndex = 73;
            this.lblDisplayStock.Text = "Display Stock      ";
            // 
            // lblSearchStockID
            // 
            this.lblSearchStockID.AutoSize = true;
            this.lblSearchStockID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchStockID.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSearchStockID.Location = new System.Drawing.Point(6, 60);
            this.lblSearchStockID.Name = "lblSearchStockID";
            this.lblSearchStockID.Size = new System.Drawing.Size(182, 24);
            this.lblSearchStockID.TabIndex = 48;
            this.lblSearchStockID.Text = "Search Stock Name:";
            // 
            // txtSearchStockName
            // 
            this.txtSearchStockName.Location = new System.Drawing.Point(194, 59);
            this.txtSearchStockName.Name = "txtSearchStockName";
            this.txtSearchStockName.Size = new System.Drawing.Size(190, 29);
            this.txtSearchStockName.TabIndex = 47;
            this.txtSearchStockName.TextChanged += new System.EventHandler(this.txtSearchStockName_TextChanged);
            // 
            // dgvStock
            // 
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(6, 152);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.RowHeadersWidth = 51;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(842, 493);
            this.dgvStock.TabIndex = 0;
            this.dgvStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellContentClick);
            // 
            // tabAdd
            // 
            this.tabAdd.BackColor = System.Drawing.Color.White;
            this.tabAdd.Controls.Add(this.cmbAddSuppID);
            this.tabAdd.Controls.Add(this.cmbAddStockTypeID);
            this.tabAdd.Controls.Add(this.lblAddSuppID);
            this.tabAdd.Controls.Add(this.btnAddCancelStock);
            this.tabAdd.Controls.Add(this.btnAddDis);
            this.tabAdd.Controls.Add(this.btnAddEditStock);
            this.tabAdd.Controls.Add(this.btnAddDelStock);
            this.tabAdd.Controls.Add(this.btnAddAddStock);
            this.tabAdd.Controls.Add(this.txtAddStockPrice);
            this.tabAdd.Controls.Add(this.txtAddQTY);
            this.tabAdd.Controls.Add(this.txtAddStockDesc);
            this.tabAdd.Controls.Add(this.txtAddStockID);
            this.tabAdd.Controls.Add(this.lblAddStockPrice);
            this.tabAdd.Controls.Add(this.lblAddStockQTY);
            this.tabAdd.Controls.Add(this.lblAddStockTypeID);
            this.tabAdd.Controls.Add(this.lblAddStockDesc);
            this.tabAdd.Controls.Add(this.lblAddStockID);
            this.tabAdd.Controls.Add(this.lblAddStock);
            this.tabAdd.ImageIndex = 1;
            this.tabAdd.Location = new System.Drawing.Point(46, 4);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(1211, 651);
            this.tabAdd.TabIndex = 1;
            // 
            // cmbAddSuppID
            // 
            this.cmbAddSuppID.FormattingEnabled = true;
            this.cmbAddSuppID.Location = new System.Drawing.Point(267, 160);
            this.cmbAddSuppID.Name = "cmbAddSuppID";
            this.cmbAddSuppID.Size = new System.Drawing.Size(292, 29);
            this.cmbAddSuppID.TabIndex = 2;
            // 
            // cmbAddStockTypeID
            // 
            this.cmbAddStockTypeID.FormattingEnabled = true;
            this.cmbAddStockTypeID.Location = new System.Drawing.Point(267, 305);
            this.cmbAddStockTypeID.Name = "cmbAddStockTypeID";
            this.cmbAddStockTypeID.Size = new System.Drawing.Size(188, 29);
            this.cmbAddStockTypeID.TabIndex = 4;
            // 
            // lblAddSuppID
            // 
            this.lblAddSuppID.AutoSize = true;
            this.lblAddSuppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSuppID.Location = new System.Drawing.Point(52, 161);
            this.lblAddSuppID.Name = "lblAddSuppID";
            this.lblAddSuppID.Size = new System.Drawing.Size(113, 24);
            this.lblAddSuppID.TabIndex = 150;
            this.lblAddSuppID.Text = "Supplier ID -";
            // 
            // btnAddCancelStock
            // 
            this.btnAddCancelStock.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCancelStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCancelStock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddCancelStock.ImageList = this.ILStock;
            this.btnAddCancelStock.Location = new System.Drawing.Point(927, 246);
            this.btnAddCancelStock.Name = "btnAddCancelStock";
            this.btnAddCancelStock.Size = new System.Drawing.Size(90, 40);
            this.btnAddCancelStock.TabIndex = 11;
            this.btnAddCancelStock.Text = "Cancel";
            this.btnAddCancelStock.UseVisualStyleBackColor = false;
            this.btnAddCancelStock.Click += new System.EventHandler(this.btnAddCancelSupp_Click);
            this.btnAddCancelStock.MouseEnter += new System.EventHandler(this.btnAddCancelStock_MouseEnter);
            this.btnAddCancelStock.MouseLeave += new System.EventHandler(this.btnAddCancelStock_MouseLeave);
            // 
            // btnAddDis
            // 
            this.btnAddDis.BackColor = System.Drawing.Color.Transparent;
            this.btnAddDis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddDis.ImageList = this.ILStock;
            this.btnAddDis.Location = new System.Drawing.Point(927, 108);
            this.btnAddDis.Name = "btnAddDis";
            this.btnAddDis.Size = new System.Drawing.Size(90, 40);
            this.btnAddDis.TabIndex = 7;
            this.btnAddDis.Text = "Display";
            this.btnAddDis.UseVisualStyleBackColor = false;
            this.btnAddDis.Click += new System.EventHandler(this.btnAddDis_Click);
            this.btnAddDis.MouseEnter += new System.EventHandler(this.btnAddDis_MouseEnter);
            this.btnAddDis.MouseLeave += new System.EventHandler(this.btnAddDis_MouseLeave);
            // 
            // btnAddEditStock
            // 
            this.btnAddEditStock.BackColor = System.Drawing.Color.Transparent;
            this.btnAddEditStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEditStock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddEditStock.ImageList = this.ILStock;
            this.btnAddEditStock.Location = new System.Drawing.Point(927, 154);
            this.btnAddEditStock.Name = "btnAddEditStock";
            this.btnAddEditStock.Size = new System.Drawing.Size(90, 40);
            this.btnAddEditStock.TabIndex = 9;
            this.btnAddEditStock.Text = "Edit";
            this.btnAddEditStock.UseVisualStyleBackColor = false;
            this.btnAddEditStock.Click += new System.EventHandler(this.btnAddEditStock_Click);
            this.btnAddEditStock.MouseEnter += new System.EventHandler(this.btnAddEditStock_MouseEnter);
            this.btnAddEditStock.MouseLeave += new System.EventHandler(this.btnAddEditStock_MouseLeave);
            // 
            // btnAddDelStock
            // 
            this.btnAddDelStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDelStock.ImageList = this.ILStock;
            this.btnAddDelStock.Location = new System.Drawing.Point(927, 200);
            this.btnAddDelStock.Name = "btnAddDelStock";
            this.btnAddDelStock.Size = new System.Drawing.Size(90, 40);
            this.btnAddDelStock.TabIndex = 10;
            this.btnAddDelStock.Text = "Delete";
            this.btnAddDelStock.UseVisualStyleBackColor = true;
            this.btnAddDelStock.Click += new System.EventHandler(this.btnAddDelSupp_Click);
            this.btnAddDelStock.MouseEnter += new System.EventHandler(this.btnAddDelStock_MouseEnter);
            this.btnAddDelStock.MouseLeave += new System.EventHandler(this.btnAddDelStock_MouseLeave);
            // 
            // btnAddAddStock
            // 
            this.btnAddAddStock.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAddStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAddStock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddAddStock.ImageList = this.ILStock;
            this.btnAddAddStock.Location = new System.Drawing.Point(740, 161);
            this.btnAddAddStock.Name = "btnAddAddStock";
            this.btnAddAddStock.Size = new System.Drawing.Size(140, 40);
            this.btnAddAddStock.TabIndex = 8;
            this.btnAddAddStock.Text = "Add Stock";
            this.btnAddAddStock.UseVisualStyleBackColor = false;
            this.btnAddAddStock.Click += new System.EventHandler(this.btnAddAddStock_Click);
            this.btnAddAddStock.MouseEnter += new System.EventHandler(this.btnAddAddStock_MouseEnter);
            this.btnAddAddStock.MouseLeave += new System.EventHandler(this.btnAddAddStock_MouseLeave);
            // 
            // txtAddStockPrice
            // 
            this.txtAddStockPrice.Location = new System.Drawing.Point(267, 451);
            this.txtAddStockPrice.Name = "txtAddStockPrice";
            this.txtAddStockPrice.Size = new System.Drawing.Size(110, 29);
            this.txtAddStockPrice.TabIndex = 6;
            // 
            // txtAddQTY
            // 
            this.txtAddQTY.Location = new System.Drawing.Point(267, 377);
            this.txtAddQTY.Name = "txtAddQTY";
            this.txtAddQTY.Size = new System.Drawing.Size(110, 29);
            this.txtAddQTY.TabIndex = 5;
            // 
            // txtAddStockDesc
            // 
            this.txtAddStockDesc.Location = new System.Drawing.Point(267, 211);
            this.txtAddStockDesc.Multiline = true;
            this.txtAddStockDesc.Name = "txtAddStockDesc";
            this.txtAddStockDesc.Size = new System.Drawing.Size(292, 72);
            this.txtAddStockDesc.TabIndex = 3;
            // 
            // txtAddStockID
            // 
            this.txtAddStockID.Location = new System.Drawing.Point(267, 108);
            this.txtAddStockID.Name = "txtAddStockID";
            this.txtAddStockID.ReadOnly = true;
            this.txtAddStockID.Size = new System.Drawing.Size(110, 29);
            this.txtAddStockID.TabIndex = 1;
            // 
            // lblAddStockPrice
            // 
            this.lblAddStockPrice.AutoSize = true;
            this.lblAddStockPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStockPrice.Location = new System.Drawing.Point(52, 451);
            this.lblAddStockPrice.Name = "lblAddStockPrice";
            this.lblAddStockPrice.Size = new System.Drawing.Size(115, 24);
            this.lblAddStockPrice.TabIndex = 35;
            this.lblAddStockPrice.Text = "Stock Price -";
            // 
            // lblAddStockQTY
            // 
            this.lblAddStockQTY.AutoSize = true;
            this.lblAddStockQTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStockQTY.Location = new System.Drawing.Point(52, 377);
            this.lblAddStockQTY.Name = "lblAddStockQTY";
            this.lblAddStockQTY.Size = new System.Drawing.Size(165, 24);
            this.lblAddStockQTY.TabIndex = 34;
            this.lblAddStockQTY.Text = "Quantity In Stock - ";
            // 
            // lblAddStockTypeID
            // 
            this.lblAddStockTypeID.AutoSize = true;
            this.lblAddStockTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStockTypeID.Location = new System.Drawing.Point(52, 304);
            this.lblAddStockTypeID.Name = "lblAddStockTypeID";
            this.lblAddStockTypeID.Size = new System.Drawing.Size(142, 24);
            this.lblAddStockTypeID.TabIndex = 33;
            this.lblAddStockTypeID.Text = "Stock Type ID - ";
            // 
            // lblAddStockDesc
            // 
            this.lblAddStockDesc.AutoSize = true;
            this.lblAddStockDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStockDesc.Location = new System.Drawing.Point(52, 211);
            this.lblAddStockDesc.Name = "lblAddStockDesc";
            this.lblAddStockDesc.Size = new System.Drawing.Size(171, 24);
            this.lblAddStockDesc.TabIndex = 32;
            this.lblAddStockDesc.Text = "Stock Description - ";
            // 
            // lblAddStockID
            // 
            this.lblAddStockID.AutoSize = true;
            this.lblAddStockID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStockID.Location = new System.Drawing.Point(52, 108);
            this.lblAddStockID.Name = "lblAddStockID";
            this.lblAddStockID.Size = new System.Drawing.Size(89, 24);
            this.lblAddStockID.TabIndex = 31;
            this.lblAddStockID.Text = "Stock ID -";
            // 
            // lblAddStock
            // 
            this.lblAddStock.AutoSize = true;
            this.lblAddStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStock.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblAddStock.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAddStock.ImageIndex = 1;
            this.lblAddStock.ImageList = this.ILStock;
            this.lblAddStock.Location = new System.Drawing.Point(17, 22);
            this.lblAddStock.Name = "lblAddStock";
            this.lblAddStock.Size = new System.Drawing.Size(195, 31);
            this.lblAddStock.TabIndex = 73;
            this.lblAddStock.Text = "Add Stock      ";
            // 
            // tabEdit
            // 
            this.tabEdit.BackColor = System.Drawing.Color.White;
            this.tabEdit.Controls.Add(this.btnEditUpdateStock);
            this.tabEdit.Controls.Add(this.cmbEditSuppID);
            this.tabEdit.Controls.Add(this.cmbEditStockTypeID);
            this.tabEdit.Controls.Add(this.lblEditSuppID);
            this.tabEdit.Controls.Add(this.btnEditCancelStock);
            this.tabEdit.Controls.Add(this.btnEditAddStock);
            this.tabEdit.Controls.Add(this.btnEditDisplay);
            this.tabEdit.Controls.Add(this.lblEditStock);
            this.tabEdit.Controls.Add(this.btnEditDelStock);
            this.tabEdit.Controls.Add(this.btnEditEditStock);
            this.tabEdit.Controls.Add(this.txtEditStockPrice);
            this.tabEdit.Controls.Add(this.txtEditQTY);
            this.tabEdit.Controls.Add(this.txtEditStockDesc);
            this.tabEdit.Controls.Add(this.txtEditStockID);
            this.tabEdit.Controls.Add(this.lblStockPrice);
            this.tabEdit.Controls.Add(this.lblQTYInStock);
            this.tabEdit.Controls.Add(this.lblStockTypeID);
            this.tabEdit.Controls.Add(this.lblStockDesc);
            this.tabEdit.Controls.Add(this.lblEditStockID);
            this.tabEdit.ImageIndex = 2;
            this.tabEdit.Location = new System.Drawing.Point(46, 4);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabEdit.Size = new System.Drawing.Size(1211, 651);
            this.tabEdit.TabIndex = 2;
            // 
            // btnEditUpdateStock
            // 
            this.btnEditUpdateStock.BackColor = System.Drawing.Color.Transparent;
            this.btnEditUpdateStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUpdateStock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditUpdateStock.ImageList = this.ILStock;
            this.btnEditUpdateStock.Location = new System.Drawing.Point(712, 228);
            this.btnEditUpdateStock.Name = "btnEditUpdateStock";
            this.btnEditUpdateStock.Size = new System.Drawing.Size(140, 40);
            this.btnEditUpdateStock.TabIndex = 159;
            this.btnEditUpdateStock.Text = "Update Stock";
            this.btnEditUpdateStock.UseVisualStyleBackColor = false;
            this.btnEditUpdateStock.Click += new System.EventHandler(this.btnEditUpdateStock_Click);
            // 
            // cmbEditSuppID
            // 
            this.cmbEditSuppID.FormattingEnabled = true;
            this.cmbEditSuppID.Location = new System.Drawing.Point(267, 174);
            this.cmbEditSuppID.Name = "cmbEditSuppID";
            this.cmbEditSuppID.Size = new System.Drawing.Size(292, 29);
            this.cmbEditSuppID.TabIndex = 2;
            // 
            // cmbEditStockTypeID
            // 
            this.cmbEditStockTypeID.FormattingEnabled = true;
            this.cmbEditStockTypeID.Location = new System.Drawing.Point(267, 320);
            this.cmbEditStockTypeID.Name = "cmbEditStockTypeID";
            this.cmbEditStockTypeID.Size = new System.Drawing.Size(214, 29);
            this.cmbEditStockTypeID.TabIndex = 4;
            // 
            // lblEditSuppID
            // 
            this.lblEditSuppID.AutoSize = true;
            this.lblEditSuppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditSuppID.Location = new System.Drawing.Point(52, 175);
            this.lblEditSuppID.Name = "lblEditSuppID";
            this.lblEditSuppID.Size = new System.Drawing.Size(113, 24);
            this.lblEditSuppID.TabIndex = 158;
            this.lblEditSuppID.Text = "Supplier ID -";
            // 
            // btnEditCancelStock
            // 
            this.btnEditCancelStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCancelStock.ImageList = this.ILStock;
            this.btnEditCancelStock.Location = new System.Drawing.Point(905, 268);
            this.btnEditCancelStock.Name = "btnEditCancelStock";
            this.btnEditCancelStock.Size = new System.Drawing.Size(90, 40);
            this.btnEditCancelStock.TabIndex = 11;
            this.btnEditCancelStock.Text = "Cancel";
            this.btnEditCancelStock.UseVisualStyleBackColor = true;
            this.btnEditCancelStock.Click += new System.EventHandler(this.btnEditCancelStock_Click);
            this.btnEditCancelStock.MouseEnter += new System.EventHandler(this.btnEditCancelStock_MouseEnter);
            this.btnEditCancelStock.MouseLeave += new System.EventHandler(this.btnEditCancelStock_MouseLeave);
            // 
            // btnEditAddStock
            // 
            this.btnEditAddStock.BackColor = System.Drawing.Color.Transparent;
            this.btnEditAddStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAddStock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditAddStock.ImageList = this.ILStock;
            this.btnEditAddStock.Location = new System.Drawing.Point(905, 129);
            this.btnEditAddStock.Name = "btnEditAddStock";
            this.btnEditAddStock.Size = new System.Drawing.Size(90, 40);
            this.btnEditAddStock.TabIndex = 8;
            this.btnEditAddStock.Text = "Add";
            this.btnEditAddStock.UseVisualStyleBackColor = false;
            this.btnEditAddStock.Click += new System.EventHandler(this.btnEditAddStock_Click);
            this.btnEditAddStock.MouseEnter += new System.EventHandler(this.btnEditAddStock_MouseEnter);
            this.btnEditAddStock.MouseLeave += new System.EventHandler(this.btnEditAddStock_MouseLeave);
            // 
            // btnEditDisplay
            // 
            this.btnEditDisplay.BackColor = System.Drawing.Color.Transparent;
            this.btnEditDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDisplay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditDisplay.ImageList = this.ILStock;
            this.btnEditDisplay.Location = new System.Drawing.Point(905, 83);
            this.btnEditDisplay.Name = "btnEditDisplay";
            this.btnEditDisplay.Size = new System.Drawing.Size(90, 40);
            this.btnEditDisplay.TabIndex = 7;
            this.btnEditDisplay.Text = "Display";
            this.btnEditDisplay.UseVisualStyleBackColor = false;
            this.btnEditDisplay.Click += new System.EventHandler(this.btnEditDisplay_Click);
            this.btnEditDisplay.MouseEnter += new System.EventHandler(this.btnEditDisplay_MouseEnter);
            this.btnEditDisplay.MouseLeave += new System.EventHandler(this.btnEditDisplay_MouseLeave);
            // 
            // lblEditStock
            // 
            this.lblEditStock.AutoSize = true;
            this.lblEditStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditStock.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblEditStock.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEditStock.ImageIndex = 2;
            this.lblEditStock.ImageList = this.ILStock;
            this.lblEditStock.Location = new System.Drawing.Point(29, 24);
            this.lblEditStock.Name = "lblEditStock";
            this.lblEditStock.Size = new System.Drawing.Size(195, 31);
            this.lblEditStock.TabIndex = 125;
            this.lblEditStock.Text = "Edit Stock      ";
            // 
            // btnEditDelStock
            // 
            this.btnEditDelStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDelStock.ImageList = this.ILStock;
            this.btnEditDelStock.Location = new System.Drawing.Point(905, 222);
            this.btnEditDelStock.Name = "btnEditDelStock";
            this.btnEditDelStock.Size = new System.Drawing.Size(90, 40);
            this.btnEditDelStock.TabIndex = 10;
            this.btnEditDelStock.Text = "Delete";
            this.btnEditDelStock.UseVisualStyleBackColor = true;
            this.btnEditDelStock.Click += new System.EventHandler(this.btnEditDelStock_Click);
            this.btnEditDelStock.MouseEnter += new System.EventHandler(this.btnEditDelStock_MouseEnter);
            this.btnEditDelStock.MouseLeave += new System.EventHandler(this.btnEditDelStock_MouseLeave);
            // 
            // btnEditEditStock
            // 
            this.btnEditEditStock.BackColor = System.Drawing.Color.Transparent;
            this.btnEditEditStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEditStock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditEditStock.ImageList = this.ILStock;
            this.btnEditEditStock.Location = new System.Drawing.Point(905, 175);
            this.btnEditEditStock.Name = "btnEditEditStock";
            this.btnEditEditStock.Size = new System.Drawing.Size(90, 40);
            this.btnEditEditStock.TabIndex = 9;
            this.btnEditEditStock.Text = "Edit";
            this.btnEditEditStock.UseVisualStyleBackColor = false;
            this.btnEditEditStock.Click += new System.EventHandler(this.btnEditEditStock_Click);
            // 
            // txtEditStockPrice
            // 
            this.txtEditStockPrice.Location = new System.Drawing.Point(267, 468);
            this.txtEditStockPrice.Name = "txtEditStockPrice";
            this.txtEditStockPrice.Size = new System.Drawing.Size(110, 29);
            this.txtEditStockPrice.TabIndex = 6;
            // 
            // txtEditQTY
            // 
            this.txtEditQTY.Location = new System.Drawing.Point(267, 394);
            this.txtEditQTY.Name = "txtEditQTY";
            this.txtEditQTY.Size = new System.Drawing.Size(110, 29);
            this.txtEditQTY.TabIndex = 5;
            // 
            // txtEditStockDesc
            // 
            this.txtEditStockDesc.Location = new System.Drawing.Point(267, 228);
            this.txtEditStockDesc.Multiline = true;
            this.txtEditStockDesc.Name = "txtEditStockDesc";
            this.txtEditStockDesc.Size = new System.Drawing.Size(292, 72);
            this.txtEditStockDesc.TabIndex = 3;
            // 
            // txtEditStockID
            // 
            this.txtEditStockID.Location = new System.Drawing.Point(267, 108);
            this.txtEditStockID.Name = "txtEditStockID";
            this.txtEditStockID.Size = new System.Drawing.Size(110, 29);
            this.txtEditStockID.TabIndex = 1;
            // 
            // lblStockPrice
            // 
            this.lblStockPrice.AutoSize = true;
            this.lblStockPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockPrice.Location = new System.Drawing.Point(52, 468);
            this.lblStockPrice.Name = "lblStockPrice";
            this.lblStockPrice.Size = new System.Drawing.Size(115, 24);
            this.lblStockPrice.TabIndex = 20;
            this.lblStockPrice.Text = "Stock Price -";
            // 
            // lblQTYInStock
            // 
            this.lblQTYInStock.AutoSize = true;
            this.lblQTYInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQTYInStock.Location = new System.Drawing.Point(52, 394);
            this.lblQTYInStock.Name = "lblQTYInStock";
            this.lblQTYInStock.Size = new System.Drawing.Size(165, 24);
            this.lblQTYInStock.TabIndex = 19;
            this.lblQTYInStock.Text = "Quantity In Stock - ";
            // 
            // lblStockTypeID
            // 
            this.lblStockTypeID.AutoSize = true;
            this.lblStockTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockTypeID.Location = new System.Drawing.Point(52, 321);
            this.lblStockTypeID.Name = "lblStockTypeID";
            this.lblStockTypeID.Size = new System.Drawing.Size(142, 24);
            this.lblStockTypeID.TabIndex = 18;
            this.lblStockTypeID.Text = "Stock Type ID - ";
            // 
            // lblStockDesc
            // 
            this.lblStockDesc.AutoSize = true;
            this.lblStockDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockDesc.Location = new System.Drawing.Point(52, 228);
            this.lblStockDesc.Name = "lblStockDesc";
            this.lblStockDesc.Size = new System.Drawing.Size(171, 24);
            this.lblStockDesc.TabIndex = 17;
            this.lblStockDesc.Text = "Stock Description - ";
            // 
            // lblEditStockID
            // 
            this.lblEditStockID.AutoSize = true;
            this.lblEditStockID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditStockID.Location = new System.Drawing.Point(52, 108);
            this.lblEditStockID.Name = "lblEditStockID";
            this.lblEditStockID.Size = new System.Drawing.Size(89, 24);
            this.lblEditStockID.TabIndex = 16;
            this.lblEditStockID.Text = "Stock ID -";
            // 
            // tabReport
            // 
            this.tabReport.Controls.Add(this.lblDisByStockType);
            this.tabReport.Controls.Add(this.cmbDisByStockType);
            this.tabReport.Controls.Add(this.btnViewAllData);
            this.tabReport.Controls.Add(this.lblReportSupplier);
            this.tabReport.Controls.Add(this.cmbReportSupplier);
            this.tabReport.Controls.Add(this.crvReports);
            this.tabReport.ImageIndex = 9;
            this.tabReport.Location = new System.Drawing.Point(46, 4);
            this.tabReport.Name = "tabReport";
            this.tabReport.Size = new System.Drawing.Size(1211, 651);
            this.tabReport.TabIndex = 3;
            // 
            // lblDisByStockType
            // 
            this.lblDisByStockType.AutoSize = true;
            this.lblDisByStockType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisByStockType.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDisByStockType.Location = new System.Drawing.Point(743, 13);
            this.lblDisByStockType.Name = "lblDisByStockType";
            this.lblDisByStockType.Size = new System.Drawing.Size(200, 24);
            this.lblDisByStockType.TabIndex = 174;
            this.lblDisByStockType.Text = "Display By Stock Type:";
            // 
            // cmbDisByStockType
            // 
            this.cmbDisByStockType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisByStockType.FormattingEnabled = true;
            this.cmbDisByStockType.Items.AddRange(new object[] {
            " "});
            this.cmbDisByStockType.Location = new System.Drawing.Point(946, 10);
            this.cmbDisByStockType.Name = "cmbDisByStockType";
            this.cmbDisByStockType.Size = new System.Drawing.Size(251, 29);
            this.cmbDisByStockType.TabIndex = 173;
        //    this.cmbDisByStockType.SelectedIndexChanged += new System.EventHandler(this.cmbDisByStockType_SelectedIndexChanged);
            // 
            // btnViewAllData
            // 
            this.btnViewAllData.BackColor = System.Drawing.Color.Transparent;
            this.btnViewAllData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnViewAllData.Location = new System.Drawing.Point(549, 12);
            this.btnViewAllData.Name = "btnViewAllData";
            this.btnViewAllData.Size = new System.Drawing.Size(140, 30);
            this.btnViewAllData.TabIndex = 172;
            this.btnViewAllData.Text = "View All Data";
            this.btnViewAllData.UseVisualStyleBackColor = false;
     //       this.btnViewAllData.Click += new System.EventHandler(this.btnViewAllData_Click);
            // 
            // lblReportSupplier
            // 
            this.lblReportSupplier.AutoSize = true;
            this.lblReportSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportSupplier.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblReportSupplier.Location = new System.Drawing.Point(9, 15);
            this.lblReportSupplier.Name = "lblReportSupplier";
            this.lblReportSupplier.Size = new System.Drawing.Size(176, 24);
            this.lblReportSupplier.TabIndex = 171;
            this.lblReportSupplier.Text = "Display By Supplier:";
            // 
            // cmbReportSupplier
            // 
            this.cmbReportSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportSupplier.FormattingEnabled = true;
            this.cmbReportSupplier.Items.AddRange(new object[] {
            " "});
            this.cmbReportSupplier.Location = new System.Drawing.Point(186, 12);
            this.cmbReportSupplier.Name = "cmbReportSupplier";
            this.cmbReportSupplier.Size = new System.Drawing.Size(251, 29);
            this.cmbReportSupplier.TabIndex = 170;
      //      this.cmbReportSupplier.SelectedIndexChanged += new System.EventHandler(this.cmbReportSupplier_SelectedIndexChanged);
            // 
            // crvReports
            // 
         //   this.crvReports.ActiveViewIndex = 0;
         //   this.crvReports.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         //   this.crvReports.Cursor = System.Windows.Forms.Cursors.Default;
         //   this.crvReports.Location = new System.Drawing.Point(3, 75);
         //   this.crvReports.Name = "crvReports";
         ////   this.crvReports.ReportSource = this.rptAllStock1;
         //   this.crvReports.Size = new System.Drawing.Size(1194, 546);
         //   this.crvReports.TabIndex = 175;
            // 
            // lblStock
            // 
            //this.lblStock.AutoSize = true;
            //this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.lblStock.Location = new System.Drawing.Point(421, 29);
            //this.lblStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            //this.lblStock.Name = "lblStock";
            //this.lblStock.Size = new System.Drawing.Size(149, 55);
            //this.lblStock.TabIndex = 54;
            //this.lblStock.Text = "Stock";
            // 
            // PBIcon
            // 
            this.PBIcon.Image = global::LloydsPharmacy.Properties.Resources.stock_2;
            this.PBIcon.Location = new System.Drawing.Point(570, 27);
            this.PBIcon.Margin = new System.Windows.Forms.Padding(2);
            this.PBIcon.Name = "PBIcon";
            this.PBIcon.Size = new System.Drawing.Size(73, 58);
            this.PBIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBIcon.TabIndex = 55;
            this.PBIcon.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogo.Image = global::LloydsPharmacy.Properties.Resources.logo;
            this.pbLogo.Location = new System.Drawing.Point(7, 9);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(409, 76);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 53;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 774);
            this.Controls.Add(this.PBIcon);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.tabStock);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmStock";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.frmStock_Load);
            this.Shown += new System.EventHandler(this.frmStock_Shown);
            this.tabStock.ResumeLayout(false);
            this.tabDisplay.ResumeLayout(false);
            this.tabDisplay.PerformLayout();
            this.pnlStockInfo.ResumeLayout(false);
            this.pnlStockInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            this.tabEdit.ResumeLayout(false);
            this.tabEdit.PerformLayout();
            this.tabReport.ResumeLayout(false);
            this.tabReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabStock;
        private System.Windows.Forms.TabPage tabDisplay;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.TabPage tabEdit;
        private System.Windows.Forms.TextBox txtEditStockPrice;
        private System.Windows.Forms.TextBox txtEditQTY;
        private System.Windows.Forms.TextBox txtEditStockDesc;
        private System.Windows.Forms.TextBox txtEditStockID;
        private System.Windows.Forms.Label lblStockPrice;
        private System.Windows.Forms.Label lblQTYInStock;
        private System.Windows.Forms.Label lblStockTypeID;
        private System.Windows.Forms.Label lblStockDesc;
        private System.Windows.Forms.Label lblEditStockID;
        private System.Windows.Forms.ImageList ILStock;
        private System.Windows.Forms.PictureBox PBIcon;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TextBox txtAddStockPrice;
        private System.Windows.Forms.TextBox txtAddQTY;
        private System.Windows.Forms.TextBox txtAddStockDesc;
        private System.Windows.Forms.TextBox txtAddStockID;
        private System.Windows.Forms.Label lblAddStockPrice;
        private System.Windows.Forms.Label lblAddStockQTY;
        private System.Windows.Forms.Label lblAddStockTypeID;
        private System.Windows.Forms.Label lblAddStockDesc;
        private System.Windows.Forms.Label lblAddStockID;
        private System.Windows.Forms.Label lblSearchStockID;
        private System.Windows.Forms.TextBox txtSearchStockName;
        private System.Windows.Forms.Label lblDisplayStock;
        private System.Windows.Forms.Label lblAddStock;
        private System.Windows.Forms.Label lblEditStock;
        private System.Windows.Forms.Button btnEditDelStock;
        private System.Windows.Forms.Button btnEditEditStock;
        private System.Windows.Forms.Button btnAddDelStock;
        private System.Windows.Forms.Button btnAddAddStock;
        private System.Windows.Forms.ErrorProvider errP;
        private System.Windows.Forms.Button btnDisEdit;
        private System.Windows.Forms.Button btnDisAdd;
        private System.Windows.Forms.Button btnDisDel;
        private System.Windows.Forms.Button btnDisExit;
        private System.Windows.Forms.Button btnAddEditStock;
        private System.Windows.Forms.Button btnAddCancelStock;
        private System.Windows.Forms.Button btnAddDis;
        private System.Windows.Forms.Button btnEditDisplay;
        private System.Windows.Forms.Button btnEditAddStock;
        private System.Windows.Forms.Button btnEditCancelStock;
        private System.Windows.Forms.TabPage tabReport;
       // private CrystalDecisions.Windows.Forms.CrystalReportViewer rptStockView;
      //  private rptStock rptStock;
        private System.Windows.Forms.Label lblDisStockByType;
        private System.Windows.Forms.ComboBox cmbStockType;
        private System.Windows.Forms.Panel pnlStockInfo;
        private System.Windows.Forms.Label lblDisStockPriceData;
        private System.Windows.Forms.Label lblDisQTYInStockData;
        private System.Windows.Forms.Label lblSDistockTypeIDData;
        private System.Windows.Forms.Label lblDisStockIDData;
        private System.Windows.Forms.Label lblDisStockPrice;
        private System.Windows.Forms.Label lblDisQTYIS;
        private System.Windows.Forms.Label lblDisSTID;
        private System.Windows.Forms.Label lblDisStockDesc;
        private System.Windows.Forms.Label lblDisStockID;
        private System.Windows.Forms.TextBox txtDisStockDescData;
        private System.Windows.Forms.Label lblAddSuppID;
        private System.Windows.Forms.Label lblEditSuppID;
        private System.Windows.Forms.ComboBox cmbAddSuppID;
        private System.Windows.Forms.ComboBox cmbAddStockTypeID;
        private System.Windows.Forms.ComboBox cmbEditSuppID;
        private System.Windows.Forms.ComboBox cmbEditStockTypeID;
        private System.Windows.Forms.Button btnEditUpdateStock;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvReports;
        private System.Windows.Forms.Button btnViewAllData;
        private System.Windows.Forms.Label lblReportSupplier;
        private System.Windows.Forms.ComboBox cmbReportSupplier;

        private System.Windows.Forms.Label lblDisByStockType;
        private System.Windows.Forms.ComboBox cmbDisByStockType;
       // private rptAllStock rptAllStock1;
    }
}