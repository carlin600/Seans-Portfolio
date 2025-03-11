namespace LloydsPharmacy
{
    partial class frmOrderAilments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderAilments));
            this.label2 = new System.Windows.Forms.Label();
            this.lvwOrders = new System.Windows.Forms.ListView();
            this.stockID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.minAilmentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.patientID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stockQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnUpdateItem = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btnH = new System.Windows.Forms.Button();
            this.btnI = new System.Windows.Forms.Button();
            this.btnJ = new System.Windows.Forms.Button();
            this.btnK = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.btnO = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnQ = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btn0S = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnV = new System.Windows.Forms.Button();
            this.btnW = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.btnZ = new System.Windows.Forms.Button();
            this.pnlDates = new System.Windows.Forms.Panel();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.pnlPatientDetails = new System.Windows.Forms.Panel();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCurrentPatID = new System.Windows.Forms.Label();
            this.lblPatID = new System.Windows.Forms.Label();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.lvwStockQty = new System.Windows.Forms.ListView();
            this.StockD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlLists = new System.Windows.Forms.Panel();
            this.lblStock = new System.Windows.Forms.Label();
            this.lstStock = new System.Windows.Forms.ListBox();
            this.lblMinAilments = new System.Windows.Forms.Label();
            this.lstMinAilments = new System.Windows.Forms.ListBox();
            this.lblPatients = new System.Windows.Forms.Label();
            this.lstPatients = new System.Windows.Forms.ListBox();
            this.cmbQty = new System.Windows.Forms.ComboBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblBacktoMenu = new System.Windows.Forms.Label();
            this.lblOrderAilments = new System.Windows.Forms.Label();
            this.errProCustMinAil = new System.Windows.Forms.ErrorProvider(this.components);
            this.ILOrdAilments = new System.Windows.Forms.ImageList(this.components);
            this.picArrow = new System.Windows.Forms.PictureBox();
            this.PBIcon = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlButtons.SuspendLayout();
            this.pnlDates.SuspendLayout();
            this.pnlPatientDetails.SuspendLayout();
            this.pnlLists.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProCustMinAil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(622, 537);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 101;
            this.label2.Text = "Orders:";
            this.label2.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // lvwOrders
            // 
            this.lvwOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stockID,
            this.minAilmentID,
            this.patientID,
            this.stockQty,
            this.orderDate});
            this.lvwOrders.FullRowSelect = true;
            this.lvwOrders.Location = new System.Drawing.Point(626, 564);
            this.lvwOrders.Name = "lvwOrders";
            this.lvwOrders.Size = new System.Drawing.Size(410, 141);
            this.lvwOrders.TabIndex = 100;
            this.lvwOrders.UseCompatibleStateImageBehavior = false;
            this.lvwOrders.View = System.Windows.Forms.View.Details;
            // 
            // stockID
            // 
            this.stockID.Text = "Stock ID";
            this.stockID.Width = 85;
            // 
            // minAilmentID
            // 
            this.minAilmentID.Text = "Minor Ail ID";
            this.minAilmentID.Width = 90;
            // 
            // patientID
            // 
            this.patientID.Text = "Patient";
            this.patientID.Width = 83;
            // 
            // stockQty
            // 
            this.stockQty.Text = "Qty";
            this.stockQty.Width = 40;
            // 
            // orderDate
            // 
            this.orderDate.Text = "Order Date";
            this.orderDate.Width = 90;
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdateItem.Location = new System.Drawing.Point(1095, 318);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.Size = new System.Drawing.Size(112, 53);
            this.btnUpdateItem.TabIndex = 99;
            this.btnUpdateItem.Text = "Update Item";
            this.btnUpdateItem.UseVisualStyleBackColor = false;
            this.btnUpdateItem.Click += new System.EventHandler(this.btnUpdateItem_Click);
            this.btnUpdateItem.MouseEnter += new System.EventHandler(this.btnUpdateItem_MouseEnter);
            this.btnUpdateItem.MouseLeave += new System.EventHandler(this.btnUpdateItem_MouseLeave);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteOrder.Location = new System.Drawing.Point(1095, 645);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(112, 53);
            this.btnDeleteOrder.TabIndex = 98;
            this.btnDeleteOrder.Text = "Delete Order";
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            this.btnDeleteOrder.MouseEnter += new System.EventHandler(this.btnDeleteOrder_MouseEnter);
            this.btnDeleteOrder.MouseLeave += new System.EventHandler(this.btnDeleteOrder_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(57, 537);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 97;
            this.label1.Text = "Stock and Qty:";
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlButtons.Controls.Add(this.btnA);
            this.pnlButtons.Controls.Add(this.btnB);
            this.pnlButtons.Controls.Add(this.btnC);
            this.pnlButtons.Controls.Add(this.btnD);
            this.pnlButtons.Controls.Add(this.btnE);
            this.pnlButtons.Controls.Add(this.btnF);
            this.pnlButtons.Controls.Add(this.btnG);
            this.pnlButtons.Controls.Add(this.btnH);
            this.pnlButtons.Controls.Add(this.btnI);
            this.pnlButtons.Controls.Add(this.btnJ);
            this.pnlButtons.Controls.Add(this.btnK);
            this.pnlButtons.Controls.Add(this.btnL);
            this.pnlButtons.Controls.Add(this.btnM);
            this.pnlButtons.Controls.Add(this.btnN);
            this.pnlButtons.Controls.Add(this.btnO);
            this.pnlButtons.Controls.Add(this.btnP);
            this.pnlButtons.Controls.Add(this.btnQ);
            this.pnlButtons.Controls.Add(this.btnR);
            this.pnlButtons.Controls.Add(this.btn0S);
            this.pnlButtons.Controls.Add(this.btnT);
            this.pnlButtons.Controls.Add(this.btnU);
            this.pnlButtons.Controls.Add(this.btnV);
            this.pnlButtons.Controls.Add(this.btnW);
            this.pnlButtons.Controls.Add(this.btnX);
            this.pnlButtons.Controls.Add(this.btnY);
            this.pnlButtons.Controls.Add(this.btnZ);
            this.pnlButtons.Location = new System.Drawing.Point(57, 194);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1055, 35);
            this.pnlButtons.TabIndex = 96;
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.SystemColors.Control;
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.ForeColor = System.Drawing.Color.Green;
            this.btnA.Location = new System.Drawing.Point(12, 4);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(32, 28);
            this.btnA.TabIndex = 39;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = false;
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.SystemColors.Control;
            this.btnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.ForeColor = System.Drawing.Color.Green;
            this.btnB.Location = new System.Drawing.Point(52, 4);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(32, 28);
            this.btnB.TabIndex = 38;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = false;
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.SystemColors.Control;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.ForeColor = System.Drawing.Color.Green;
            this.btnC.Location = new System.Drawing.Point(92, 4);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(32, 28);
            this.btnC.TabIndex = 23;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.SystemColors.Control;
            this.btnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.ForeColor = System.Drawing.Color.Green;
            this.btnD.Location = new System.Drawing.Point(132, 4);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(32, 28);
            this.btnD.TabIndex = 37;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = false;
            // 
            // btnE
            // 
            this.btnE.BackColor = System.Drawing.SystemColors.Control;
            this.btnE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnE.ForeColor = System.Drawing.Color.Green;
            this.btnE.Location = new System.Drawing.Point(172, 4);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(32, 28);
            this.btnE.TabIndex = 0;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = false;
            // 
            // btnF
            // 
            this.btnF.BackColor = System.Drawing.SystemColors.Control;
            this.btnF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF.ForeColor = System.Drawing.Color.Green;
            this.btnF.Location = new System.Drawing.Point(212, 4);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(32, 28);
            this.btnF.TabIndex = 36;
            this.btnF.Text = "F";
            this.btnF.UseVisualStyleBackColor = false;
            // 
            // btnG
            // 
            this.btnG.BackColor = System.Drawing.SystemColors.Control;
            this.btnG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnG.ForeColor = System.Drawing.Color.Green;
            this.btnG.Location = new System.Drawing.Point(252, 4);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(32, 28);
            this.btnG.TabIndex = 22;
            this.btnG.Text = "G";
            this.btnG.UseVisualStyleBackColor = false;
            // 
            // btnH
            // 
            this.btnH.BackColor = System.Drawing.SystemColors.Control;
            this.btnH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnH.ForeColor = System.Drawing.Color.Green;
            this.btnH.Location = new System.Drawing.Point(292, 4);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(32, 28);
            this.btnH.TabIndex = 35;
            this.btnH.Text = "H";
            this.btnH.UseVisualStyleBackColor = false;
            // 
            // btnI
            // 
            this.btnI.BackColor = System.Drawing.SystemColors.Control;
            this.btnI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnI.ForeColor = System.Drawing.Color.Green;
            this.btnI.Location = new System.Drawing.Point(332, 4);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(32, 28);
            this.btnI.TabIndex = 19;
            this.btnI.Text = "I";
            this.btnI.UseVisualStyleBackColor = false;
            // 
            // btnJ
            // 
            this.btnJ.BackColor = System.Drawing.SystemColors.Control;
            this.btnJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJ.ForeColor = System.Drawing.Color.Green;
            this.btnJ.Location = new System.Drawing.Point(372, 4);
            this.btnJ.Name = "btnJ";
            this.btnJ.Size = new System.Drawing.Size(32, 28);
            this.btnJ.TabIndex = 34;
            this.btnJ.Text = "J";
            this.btnJ.UseVisualStyleBackColor = false;
            // 
            // btnK
            // 
            this.btnK.BackColor = System.Drawing.SystemColors.Control;
            this.btnK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnK.ForeColor = System.Drawing.Color.Green;
            this.btnK.Location = new System.Drawing.Point(412, 4);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(32, 28);
            this.btnK.TabIndex = 21;
            this.btnK.Text = "K";
            this.btnK.UseVisualStyleBackColor = false;
            // 
            // btnL
            // 
            this.btnL.BackColor = System.Drawing.SystemColors.Control;
            this.btnL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL.ForeColor = System.Drawing.Color.Green;
            this.btnL.Location = new System.Drawing.Point(452, 4);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(32, 28);
            this.btnL.TabIndex = 33;
            this.btnL.Text = "L";
            this.btnL.UseVisualStyleBackColor = false;
            // 
            // btnM
            // 
            this.btnM.BackColor = System.Drawing.SystemColors.Control;
            this.btnM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnM.ForeColor = System.Drawing.Color.Green;
            this.btnM.Location = new System.Drawing.Point(492, 4);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(32, 28);
            this.btnM.TabIndex = 20;
            this.btnM.Text = "M";
            this.btnM.UseVisualStyleBackColor = false;
            // 
            // btnN
            // 
            this.btnN.BackColor = System.Drawing.SystemColors.Control;
            this.btnN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN.ForeColor = System.Drawing.Color.Green;
            this.btnN.Location = new System.Drawing.Point(532, 4);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(32, 28);
            this.btnN.TabIndex = 32;
            this.btnN.Text = "N";
            this.btnN.UseVisualStyleBackColor = false;
            // 
            // btnO
            // 
            this.btnO.BackColor = System.Drawing.SystemColors.Control;
            this.btnO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnO.ForeColor = System.Drawing.Color.Green;
            this.btnO.Location = new System.Drawing.Point(572, 4);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(32, 28);
            this.btnO.TabIndex = 19;
            this.btnO.Text = "O";
            this.btnO.UseVisualStyleBackColor = false;
            // 
            // btnP
            // 
            this.btnP.BackColor = System.Drawing.SystemColors.Control;
            this.btnP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP.ForeColor = System.Drawing.Color.Green;
            this.btnP.Location = new System.Drawing.Point(612, 4);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(32, 28);
            this.btnP.TabIndex = 20;
            this.btnP.Text = "P";
            this.btnP.UseVisualStyleBackColor = false;
            // 
            // btnQ
            // 
            this.btnQ.BackColor = System.Drawing.SystemColors.Control;
            this.btnQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ.ForeColor = System.Drawing.Color.Green;
            this.btnQ.Location = new System.Drawing.Point(652, 4);
            this.btnQ.Name = "btnQ";
            this.btnQ.Size = new System.Drawing.Size(32, 28);
            this.btnQ.TabIndex = 30;
            this.btnQ.Text = "Q";
            this.btnQ.UseVisualStyleBackColor = false;
            // 
            // btnR
            // 
            this.btnR.BackColor = System.Drawing.SystemColors.Control;
            this.btnR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnR.ForeColor = System.Drawing.Color.Green;
            this.btnR.Location = new System.Drawing.Point(692, 4);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(32, 28);
            this.btnR.TabIndex = 21;
            this.btnR.Text = "R";
            this.btnR.UseVisualStyleBackColor = false;
            // 
            // btn0S
            // 
            this.btn0S.BackColor = System.Drawing.SystemColors.Control;
            this.btn0S.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0S.ForeColor = System.Drawing.Color.Green;
            this.btn0S.Location = new System.Drawing.Point(732, 4);
            this.btn0S.Name = "btn0S";
            this.btn0S.Size = new System.Drawing.Size(32, 28);
            this.btn0S.TabIndex = 29;
            this.btn0S.Text = "S";
            this.btn0S.UseVisualStyleBackColor = false;
            // 
            // btnT
            // 
            this.btnT.BackColor = System.Drawing.SystemColors.Control;
            this.btnT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnT.ForeColor = System.Drawing.Color.Green;
            this.btnT.Location = new System.Drawing.Point(772, 4);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(32, 28);
            this.btnT.TabIndex = 22;
            this.btnT.Text = "T";
            this.btnT.UseVisualStyleBackColor = false;
            // 
            // btnU
            // 
            this.btnU.BackColor = System.Drawing.SystemColors.Control;
            this.btnU.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnU.ForeColor = System.Drawing.Color.Green;
            this.btnU.Location = new System.Drawing.Point(812, 4);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(32, 28);
            this.btnU.TabIndex = 28;
            this.btnU.Text = "U";
            this.btnU.UseVisualStyleBackColor = false;
            // 
            // btnV
            // 
            this.btnV.BackColor = System.Drawing.SystemColors.Control;
            this.btnV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnV.ForeColor = System.Drawing.Color.Green;
            this.btnV.Location = new System.Drawing.Point(852, 4);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(32, 28);
            this.btnV.TabIndex = 23;
            this.btnV.Text = "V";
            this.btnV.UseVisualStyleBackColor = false;
            // 
            // btnW
            // 
            this.btnW.BackColor = System.Drawing.SystemColors.Control;
            this.btnW.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnW.ForeColor = System.Drawing.Color.Green;
            this.btnW.Location = new System.Drawing.Point(892, 4);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(32, 28);
            this.btnW.TabIndex = 27;
            this.btnW.Text = "W";
            this.btnW.UseVisualStyleBackColor = false;
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.SystemColors.Control;
            this.btnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.Color.Green;
            this.btnX.Location = new System.Drawing.Point(932, 4);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(32, 28);
            this.btnX.TabIndex = 24;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            // 
            // btnY
            // 
            this.btnY.BackColor = System.Drawing.SystemColors.Control;
            this.btnY.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnY.ForeColor = System.Drawing.Color.Green;
            this.btnY.Location = new System.Drawing.Point(972, 4);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(32, 28);
            this.btnY.TabIndex = 26;
            this.btnY.Text = "Y";
            this.btnY.UseVisualStyleBackColor = false;
            // 
            // btnZ
            // 
            this.btnZ.BackColor = System.Drawing.SystemColors.Control;
            this.btnZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZ.ForeColor = System.Drawing.Color.Green;
            this.btnZ.Location = new System.Drawing.Point(1012, 4);
            this.btnZ.Name = "btnZ";
            this.btnZ.Size = new System.Drawing.Size(32, 28);
            this.btnZ.TabIndex = 25;
            this.btnZ.Text = "Z";
            this.btnZ.UseVisualStyleBackColor = false;
            // 
            // pnlDates
            // 
            this.pnlDates.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlDates.Controls.Add(this.lblOrderDate);
            this.pnlDates.Controls.Add(this.dtpOrderDate);
            this.pnlDates.Location = new System.Drawing.Point(284, 564);
            this.pnlDates.Name = "pnlDates";
            this.pnlDates.Size = new System.Drawing.Size(286, 50);
            this.pnlDates.TabIndex = 95;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDate.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblOrderDate.Location = new System.Drawing.Point(15, 12);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(107, 24);
            this.lblOrderDate.TabIndex = 67;
            this.lblOrderDate.Text = "Order Date:";
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Location = new System.Drawing.Point(124, 16);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(134, 20);
            this.dtpOrderDate.TabIndex = 76;
            // 
            // pnlPatientDetails
            // 
            this.pnlPatientDetails.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlPatientDetails.Controls.Add(this.lblPostcode);
            this.pnlPatientDetails.Controls.Add(this.lblAddress);
            this.pnlPatientDetails.Controls.Add(this.lblEmail);
            this.pnlPatientDetails.Controls.Add(this.lblTelNo);
            this.pnlPatientDetails.Controls.Add(this.lblName);
            this.pnlPatientDetails.Controls.Add(this.lblCurrentPatID);
            this.pnlPatientDetails.Controls.Add(this.lblPatID);
            this.pnlPatientDetails.Location = new System.Drawing.Point(626, 248);
            this.pnlPatientDetails.Name = "pnlPatientDetails";
            this.pnlPatientDetails.Size = new System.Drawing.Size(410, 246);
            this.pnlPatientDetails.TabIndex = 94;
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostcode.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblPostcode.Location = new System.Drawing.Point(18, 205);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(14, 20);
            this.lblPostcode.TabIndex = 82;
            this.lblPostcode.Text = "-";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblAddress.Location = new System.Drawing.Point(18, 165);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(14, 20);
            this.lblAddress.TabIndex = 79;
            this.lblAddress.Text = "-";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblEmail.Location = new System.Drawing.Point(18, 125);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(14, 20);
            this.lblEmail.TabIndex = 78;
            this.lblEmail.Text = "-";
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelNo.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTelNo.Location = new System.Drawing.Point(18, 85);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(14, 20);
            this.lblTelNo.TabIndex = 77;
            this.lblTelNo.Text = "-";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblName.Location = new System.Drawing.Point(18, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(14, 20);
            this.lblName.TabIndex = 76;
            this.lblName.Text = "-";
            // 
            // lblCurrentPatID
            // 
            this.lblCurrentPatID.AutoSize = true;
            this.lblCurrentPatID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPatID.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCurrentPatID.Location = new System.Drawing.Point(117, 9);
            this.lblCurrentPatID.Name = "lblCurrentPatID";
            this.lblCurrentPatID.Size = new System.Drawing.Size(16, 24);
            this.lblCurrentPatID.TabIndex = 75;
            this.lblCurrentPatID.Text = "-";
            // 
            // lblPatID
            // 
            this.lblPatID.AutoSize = true;
            this.lblPatID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatID.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblPatID.Location = new System.Drawing.Point(18, 9);
            this.lblPatID.Name = "lblPatID";
            this.lblPatID.Size = new System.Drawing.Size(93, 24);
            this.lblPatID.TabIndex = 74;
            this.lblPatID.Text = "Patient ID:";
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddOrder.Location = new System.Drawing.Point(1095, 577);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(112, 53);
            this.btnAddOrder.TabIndex = 93;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            this.btnAddOrder.MouseEnter += new System.EventHandler(this.btnAddOrder_MouseEnter);
            this.btnAddOrder.MouseLeave += new System.EventHandler(this.btnAddOrder_MouseLeave);
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.Transparent;
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddItem.Location = new System.Drawing.Point(1095, 248);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(112, 53);
            this.btnAddItem.TabIndex = 92;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            this.btnAddItem.MouseEnter += new System.EventHandler(this.btnAddItem_MouseEnter);
            this.btnAddItem.MouseLeave += new System.EventHandler(this.btnAddItem_MouseLeave);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteItem.Location = new System.Drawing.Point(1095, 388);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(112, 53);
            this.btnDeleteItem.TabIndex = 91;
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.UseVisualStyleBackColor = false;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            this.btnDeleteItem.MouseEnter += new System.EventHandler(this.btnDeleteItem_MouseEnter);
            this.btnDeleteItem.MouseLeave += new System.EventHandler(this.btnDeleteItem_MouseLeave);
            // 
            // lvwStockQty
            // 
            this.lvwStockQty.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StockD,
            this.Qty});
            this.lvwStockQty.FullRowSelect = true;
            this.lvwStockQty.Location = new System.Drawing.Point(57, 564);
            this.lvwStockQty.Name = "lvwStockQty";
            this.lvwStockQty.Size = new System.Drawing.Size(189, 141);
            this.lvwStockQty.TabIndex = 90;
            this.lvwStockQty.UseCompatibleStateImageBehavior = false;
            this.lvwStockQty.View = System.Windows.Forms.View.Details;
            // 
            // StockD
            // 
            this.StockD.Text = "Stock ID";
            this.StockD.Width = 112;
            // 
            // Qty
            // 
            this.Qty.Text = "Qty";
            this.Qty.Width = 72;
            // 
            // pnlLists
            // 
            this.pnlLists.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlLists.Controls.Add(this.lblStock);
            this.pnlLists.Controls.Add(this.lstStock);
            this.pnlLists.Controls.Add(this.lblMinAilments);
            this.pnlLists.Controls.Add(this.lstMinAilments);
            this.pnlLists.Controls.Add(this.lblPatients);
            this.pnlLists.Controls.Add(this.lstPatients);
            this.pnlLists.Controls.Add(this.cmbQty);
            this.pnlLists.Controls.Add(this.lblQty);
            this.pnlLists.Location = new System.Drawing.Point(57, 248);
            this.pnlLists.Name = "pnlLists";
            this.pnlLists.Size = new System.Drawing.Size(536, 269);
            this.pnlLists.TabIndex = 89;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblStock.Location = new System.Drawing.Point(371, 16);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(55, 20);
            this.lblStock.TabIndex = 70;
            this.lblStock.Text = "Stock";
            // 
            // lstStock
            // 
            this.lstStock.FormattingEnabled = true;
            this.lstStock.Location = new System.Drawing.Point(375, 39);
            this.lstStock.Name = "lstStock";
            this.lstStock.Size = new System.Drawing.Size(147, 186);
            this.lstStock.TabIndex = 69;
            this.lstStock.Click += new System.EventHandler(this.lstStock_Click);
            // 
            // lblMinAilments
            // 
            this.lblMinAilments.AutoSize = true;
            this.lblMinAilments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinAilments.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblMinAilments.Location = new System.Drawing.Point(191, 16);
            this.lblMinAilments.Name = "lblMinAilments";
            this.lblMinAilments.Size = new System.Drawing.Size(127, 20);
            this.lblMinAilments.TabIndex = 68;
            this.lblMinAilments.Text = "Minor Ailments";
            // 
            // lstMinAilments
            // 
            this.lstMinAilments.FormattingEnabled = true;
            this.lstMinAilments.Location = new System.Drawing.Point(195, 39);
            this.lstMinAilments.Name = "lstMinAilments";
            this.lstMinAilments.Size = new System.Drawing.Size(147, 186);
            this.lstMinAilments.TabIndex = 67;
            this.lstMinAilments.Click += new System.EventHandler(this.lstMinAilments_Click);
            // 
            // lblPatients
            // 
            this.lblPatients.AutoSize = true;
            this.lblPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatients.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblPatients.Location = new System.Drawing.Point(11, 16);
            this.lblPatients.Name = "lblPatients";
            this.lblPatients.Size = new System.Drawing.Size(75, 20);
            this.lblPatients.TabIndex = 66;
            this.lblPatients.Text = "Patients";
            // 
            // lstPatients
            // 
            this.lstPatients.FormattingEnabled = true;
            this.lstPatients.Location = new System.Drawing.Point(15, 39);
            this.lstPatients.Name = "lstPatients";
            this.lstPatients.Size = new System.Drawing.Size(147, 186);
            this.lstPatients.TabIndex = 64;
            this.lstPatients.Click += new System.EventHandler(this.lstPatients_Click);
            // 
            // cmbQty
            // 
            this.cmbQty.FormattingEnabled = true;
            this.cmbQty.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbQty.Location = new System.Drawing.Point(425, 239);
            this.cmbQty.Name = "cmbQty";
            this.cmbQty.Size = new System.Drawing.Size(88, 21);
            this.cmbQty.TabIndex = 68;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblQty.Location = new System.Drawing.Point(376, 236);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(43, 24);
            this.lblQty.TabIndex = 67;
            this.lblQty.Text = "Qty:";
            // 
            // lblBacktoMenu
            // 
            this.lblBacktoMenu.AutoSize = true;
            this.lblBacktoMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBacktoMenu.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblBacktoMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblBacktoMenu.Location = new System.Drawing.Point(110, 155);
            this.lblBacktoMenu.Name = "lblBacktoMenu";
            this.lblBacktoMenu.Size = new System.Drawing.Size(198, 25);
            this.lblBacktoMenu.TabIndex = 87;
            this.lblBacktoMenu.Text = "Minor Ailment Form";
            // 
            // lblOrderAilments
            // 
            this.lblOrderAilments.AutoSize = true;
            this.lblOrderAilments.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderAilments.Location = new System.Drawing.Point(469, 49);
            this.lblOrderAilments.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderAilments.Name = "lblOrderAilments";
            this.lblOrderAilments.Size = new System.Drawing.Size(493, 75);
            this.lblOrderAilments.TabIndex = 85;
            this.lblOrderAilments.Text = "Order Ailments";
            // 
            // errProCustMinAil
            // 
            this.errProCustMinAil.ContainerControl = this;
            // 
            // ILOrdAilments
            // 
            this.ILOrdAilments.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ILOrdAilments.ImageStream")));
            this.ILOrdAilments.TransparentColor = System.Drawing.Color.Transparent;
            this.ILOrdAilments.Images.SetKeyName(0, "plus.png");
            this.ILOrdAilments.Images.SetKeyName(1, "pencil.png");
            this.ILOrdAilments.Images.SetKeyName(2, "trash.png");
            this.ILOrdAilments.Images.SetKeyName(3, "cancel.png");
            // 
            // picArrow
            // 
            this.picArrow.Location = new System.Drawing.Point(303, 127);
            this.picArrow.Name = "picArrow";
            this.picArrow.Size = new System.Drawing.Size(48, 46);
            this.picArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picArrow.TabIndex = 88;
            this.picArrow.TabStop = false;
            // 
            // PBIcon
            // 
            this.PBIcon.Image = global::LloydsPharmacy.Properties.Resources.ailments;
            this.PBIcon.Location = new System.Drawing.Point(949, 44);
            this.PBIcon.Margin = new System.Windows.Forms.Padding(2);
            this.PBIcon.Name = "PBIcon";
            this.PBIcon.Size = new System.Drawing.Size(90, 81);
            this.PBIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBIcon.TabIndex = 86;
            this.PBIcon.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogo.Image = global::LloydsPharmacy.Properties.Resources.logo;
            this.pbLogo.Location = new System.Drawing.Point(55, 49);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(409, 76);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 84;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // frmOrderAilments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 749);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvwOrders);
            this.Controls.Add(this.btnUpdateItem);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlDates);
            this.Controls.Add(this.pnlPatientDetails);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.lvwStockQty);
            this.Controls.Add(this.pnlLists);
            this.Controls.Add(this.picArrow);
            this.Controls.Add(this.lblBacktoMenu);
            this.Controls.Add(this.PBIcon);
            this.Controls.Add(this.lblOrderAilments);
            this.Controls.Add(this.pbLogo);
            this.Name = "frmOrderAilments";
            this.Text = "frmOrderAilments";
            this.Load += new System.EventHandler(this.frmCustMinAilments_Load);
            this.pnlButtons.ResumeLayout(false);
            this.pnlDates.ResumeLayout(false);
            this.pnlDates.PerformLayout();
            this.pnlPatientDetails.ResumeLayout(false);
            this.pnlPatientDetails.PerformLayout();
            this.pnlLists.ResumeLayout(false);
            this.pnlLists.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProCustMinAil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvwOrders;
        private System.Windows.Forms.ColumnHeader stockID;
        private System.Windows.Forms.ColumnHeader minAilmentID;
        private System.Windows.Forms.ColumnHeader patientID;
        private System.Windows.Forms.ColumnHeader stockQty;
        private System.Windows.Forms.ColumnHeader orderDate;
        private System.Windows.Forms.Button btnUpdateItem;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.Button btnH;
        private System.Windows.Forms.Button btnI;
        private System.Windows.Forms.Button btnJ;
        private System.Windows.Forms.Button btnK;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnO;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnQ;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btn0S;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Button btnV;
        private System.Windows.Forms.Button btnW;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnY;
        private System.Windows.Forms.Button btnZ;
        private System.Windows.Forms.Panel pnlDates;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Panel pnlPatientDetails;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCurrentPatID;
        private System.Windows.Forms.Label lblPatID;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.ListView lvwStockQty;
        private System.Windows.Forms.ColumnHeader StockD;
        private System.Windows.Forms.ColumnHeader Qty;
        private System.Windows.Forms.Panel pnlLists;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.ListBox lstStock;
        private System.Windows.Forms.Label lblMinAilments;
        private System.Windows.Forms.ListBox lstMinAilments;
        private System.Windows.Forms.Label lblPatients;
        private System.Windows.Forms.ListBox lstPatients;
        private System.Windows.Forms.ComboBox cmbQty;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.PictureBox picArrow;
        private System.Windows.Forms.Label lblBacktoMenu;
        private System.Windows.Forms.PictureBox PBIcon;
        private System.Windows.Forms.Label lblOrderAilments;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.ErrorProvider errProCustMinAil;
        private System.Windows.Forms.ImageList ILOrdAilments;
    }
}