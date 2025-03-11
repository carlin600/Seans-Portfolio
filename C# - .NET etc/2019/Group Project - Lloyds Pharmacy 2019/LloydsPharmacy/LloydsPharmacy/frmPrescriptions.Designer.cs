namespace LloydsPharmacy
{
    partial class frmPrescriptions
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
            this.lblPresDetLV = new System.Windows.Forms.Label();
            this.lvwPresDetails = new System.Windows.Forms.ListView();
            this.stockID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.delivery = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.recurringPres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnUpdateItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.lblPresLV = new System.Windows.Forms.Label();
            this.lvwPrescriptions = new System.Windows.Forms.ListView();
            this.PresID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PatID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PresDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.pnlDelivRec = new System.Windows.Forms.Panel();
            this.cmbRecPres = new System.Windows.Forms.ComboBox();
            this.cmbDelivery = new System.Windows.Forms.ComboBox();
            this.cmbCurrentStockID = new System.Windows.Forms.ComboBox();
            this.lblStockID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlLists = new System.Windows.Forms.Panel();
            this.lblPatients = new System.Windows.Forms.Label();
            this.lstPatients = new System.Windows.Forms.ListBox();
            this.lblPresList = new System.Windows.Forms.Label();
            this.lstPrescriptions = new System.Windows.Forms.ListBox();
            this.lblBacktoMenu = new System.Windows.Forms.Label();
            this.lblPrescriptions = new System.Windows.Forms.Label();
            this.picArrow = new System.Windows.Forms.PictureBox();
            this.PBIcon = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlButtons.SuspendLayout();
            this.pnlDelivRec.SuspendLayout();
            this.pnlLists.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPresDetLV
            // 
            this.lblPresDetLV.AutoSize = true;
            this.lblPresDetLV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresDetLV.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblPresDetLV.Location = new System.Drawing.Point(313, 516);
            this.lblPresDetLV.Name = "lblPresDetLV";
            this.lblPresDetLV.Size = new System.Drawing.Size(174, 24);
            this.lblPresDetLV.TabIndex = 103;
            this.lblPresDetLV.Text = "Prescription Details:";
            // 
            // lvwPresDetails
            // 
            this.lvwPresDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stockID,
            this.delivery,
            this.recurringPres});
            this.lvwPresDetails.FullRowSelect = true;
            this.lvwPresDetails.Location = new System.Drawing.Point(317, 543);
            this.lvwPresDetails.Name = "lvwPresDetails";
            this.lvwPresDetails.Size = new System.Drawing.Size(195, 141);
            this.lvwPresDetails.TabIndex = 90;
            this.lvwPresDetails.UseCompatibleStateImageBehavior = false;
            this.lvwPresDetails.View = System.Windows.Forms.View.Details;
            // 
            // stockID
            // 
            this.stockID.Text = "Stock ID";
            this.stockID.Width = 70;
            // 
            // delivery
            // 
            this.delivery.Text = "Delivery";
            // 
            // recurringPres
            // 
            this.recurringPres.Text = "Rec Pres.";
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdateItem.Location = new System.Drawing.Point(912, 281);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.Size = new System.Drawing.Size(112, 53);
            this.btnUpdateItem.TabIndex = 92;
            this.btnUpdateItem.Text = "Update Item";
            this.btnUpdateItem.UseVisualStyleBackColor = false;
            this.btnUpdateItem.Click += new System.EventHandler(this.btnUpdateItem_Click);
            this.btnUpdateItem.MouseEnter += new System.EventHandler(this.btnUpdateItem_MouseEnter);
            this.btnUpdateItem.MouseLeave += new System.EventHandler(this.btnUpdateItem_MouseLeave);
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.Transparent;
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddItem.Location = new System.Drawing.Point(912, 211);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(112, 53);
            this.btnAddItem.TabIndex = 91;
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
            this.btnDeleteItem.Location = new System.Drawing.Point(912, 351);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(112, 53);
            this.btnDeleteItem.TabIndex = 93;
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.UseVisualStyleBackColor = false;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            this.btnDeleteItem.MouseEnter += new System.EventHandler(this.btnDeleteItem_MouseEnter);
            this.btnDeleteItem.MouseLeave += new System.EventHandler(this.btnDeleteItem_MouseLeave);
            // 
            // lblPresLV
            // 
            this.lblPresLV.AutoSize = true;
            this.lblPresLV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresLV.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblPresLV.Location = new System.Drawing.Point(34, 516);
            this.lblPresLV.Name = "lblPresLV";
            this.lblPresLV.Size = new System.Drawing.Size(184, 24);
            this.lblPresLV.TabIndex = 102;
            this.lblPresLV.Text = "Patient Prescriptions:";
            // 
            // lvwPrescriptions
            // 
            this.lvwPrescriptions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PresID,
            this.PatID,
            this.PresDate});
            this.lvwPrescriptions.FullRowSelect = true;
            this.lvwPrescriptions.Location = new System.Drawing.Point(38, 543);
            this.lvwPrescriptions.Name = "lvwPrescriptions";
            this.lvwPrescriptions.Size = new System.Drawing.Size(234, 141);
            this.lvwPrescriptions.TabIndex = 89;
            this.lvwPrescriptions.UseCompatibleStateImageBehavior = false;
            this.lvwPrescriptions.View = System.Windows.Forms.View.Details;
            // 
            // PresID
            // 
            this.PresID.Text = "Pres. ID";
            this.PresID.Width = 70;
            // 
            // PatID
            // 
            this.PatID.Text = "Patient ID";
            this.PatID.Width = 70;
            // 
            // PresDate
            // 
            this.PresDate.Text = "Pres. Date";
            this.PresDate.Width = 90;
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
            this.pnlButtons.Location = new System.Drawing.Point(14, 157);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1055, 35);
            this.pnlButtons.TabIndex = 101;
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.SystemColors.Control;
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.ForeColor = System.Drawing.Color.Green;
            this.btnA.Location = new System.Drawing.Point(12, 4);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(32, 28);
            this.btnA.TabIndex = 1;
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
            this.btnB.TabIndex = 2;
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
            this.btnC.TabIndex = 3;
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
            this.btnD.TabIndex = 4;
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
            this.btnE.TabIndex = 5;
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
            this.btnF.TabIndex = 6;
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
            this.btnG.TabIndex = 7;
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
            this.btnH.TabIndex = 8;
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
            this.btnI.TabIndex = 9;
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
            this.btnJ.TabIndex = 10;
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
            this.btnK.TabIndex = 11;
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
            this.btnL.TabIndex = 12;
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
            this.btnM.TabIndex = 13;
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
            this.btnN.TabIndex = 14;
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
            this.btnO.TabIndex = 15;
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
            this.btnP.TabIndex = 16;
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
            this.btnQ.TabIndex = 17;
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
            this.btnR.TabIndex = 18;
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
            this.btn0S.TabIndex = 19;
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
            this.btnT.TabIndex = 20;
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
            this.btnU.TabIndex = 21;
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
            this.btnV.TabIndex = 22;
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
            this.btnW.TabIndex = 23;
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
            this.btnY.TabIndex = 25;
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
            this.btnZ.TabIndex = 26;
            this.btnZ.Text = "Z";
            this.btnZ.UseVisualStyleBackColor = false;
            // 
            // pnlDelivRec
            // 
            this.pnlDelivRec.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlDelivRec.Controls.Add(this.cmbRecPres);
            this.pnlDelivRec.Controls.Add(this.cmbDelivery);
            this.pnlDelivRec.Controls.Add(this.cmbCurrentStockID);
            this.pnlDelivRec.Controls.Add(this.lblStockID);
            this.pnlDelivRec.Controls.Add(this.label1);
            this.pnlDelivRec.Controls.Add(this.label2);
            this.pnlDelivRec.Location = new System.Drawing.Point(546, 211);
            this.pnlDelivRec.Name = "pnlDelivRec";
            this.pnlDelivRec.Size = new System.Drawing.Size(286, 157);
            this.pnlDelivRec.TabIndex = 100;
            // 
            // cmbRecPres
            // 
            this.cmbRecPres.FormattingEnabled = true;
            this.cmbRecPres.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cmbRecPres.Location = new System.Drawing.Point(172, 120);
            this.cmbRecPres.Name = "cmbRecPres";
            this.cmbRecPres.Size = new System.Drawing.Size(92, 21);
            this.cmbRecPres.TabIndex = 33;
            // 
            // cmbDelivery
            // 
            this.cmbDelivery.FormattingEnabled = true;
            this.cmbDelivery.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cmbDelivery.Location = new System.Drawing.Point(172, 70);
            this.cmbDelivery.Name = "cmbDelivery";
            this.cmbDelivery.Size = new System.Drawing.Size(92, 21);
            this.cmbDelivery.TabIndex = 32;
            // 
            // cmbCurrentStockID
            // 
            this.cmbCurrentStockID.FormattingEnabled = true;
            this.cmbCurrentStockID.Items.AddRange(new object[] {
            "ST001",
            "ST002",
            "ST003",
            "ST004",
            "ST005",
            "ST006",
            "ST007",
            "ST008",
            "ST009",
            "ST010",
            "ST011",
            "ST012",
            "ST013",
            "ST014",
            "ST015",
            "ST016",
            "ST017",
            "ST018",
            "ST019",
            "ST020",
            "ST021",
            "ST022",
            "ST023",
            "ST024",
            "ST025",
            "ST026",
            "ST027",
            "ST028",
            "ST029",
            "ST030"});
            this.cmbCurrentStockID.Location = new System.Drawing.Point(172, 15);
            this.cmbCurrentStockID.Name = "cmbCurrentStockID";
            this.cmbCurrentStockID.Size = new System.Drawing.Size(92, 21);
            this.cmbCurrentStockID.TabIndex = 31;
            // 
            // lblStockID
            // 
            this.lblStockID.AutoSize = true;
            this.lblStockID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockID.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblStockID.Location = new System.Drawing.Point(15, 15);
            this.lblStockID.Name = "lblStockID";
            this.lblStockID.Size = new System.Drawing.Size(83, 24);
            this.lblStockID.TabIndex = 71;
            this.lblStockID.Text = "Stock ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(15, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 67;
            this.label1.Text = "Delivery:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(15, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 24);
            this.label2.TabIndex = 63;
            this.label2.Text = "Recurring Pres.:";
            // 
            // pnlLists
            // 
            this.pnlLists.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlLists.Controls.Add(this.lblPatients);
            this.pnlLists.Controls.Add(this.lstPatients);
            this.pnlLists.Controls.Add(this.lblPresList);
            this.pnlLists.Controls.Add(this.lstPrescriptions);
            this.pnlLists.Location = new System.Drawing.Point(97, 211);
            this.pnlLists.Name = "pnlLists";
            this.pnlLists.Size = new System.Drawing.Size(361, 238);
            this.pnlLists.TabIndex = 99;
            // 
            // lblPatients
            // 
            this.lblPatients.AutoSize = true;
            this.lblPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatients.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblPatients.Location = new System.Drawing.Point(11, 16);
            this.lblPatients.Name = "lblPatients";
            this.lblPatients.Size = new System.Drawing.Size(75, 20);
            this.lblPatients.TabIndex = 68;
            this.lblPatients.Text = "Patients";
            // 
            // lstPatients
            // 
            this.lstPatients.FormattingEnabled = true;
            this.lstPatients.Location = new System.Drawing.Point(15, 39);
            this.lstPatients.Name = "lstPatients";
            this.lstPatients.Size = new System.Drawing.Size(147, 186);
            this.lstPatients.TabIndex = 27;
            this.lstPatients.Click += new System.EventHandler(this.lstPatients_Click);
            // 
            // lblPresList
            // 
            this.lblPresList.AutoSize = true;
            this.lblPresList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresList.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblPresList.Location = new System.Drawing.Point(191, 16);
            this.lblPresList.Name = "lblPresList";
            this.lblPresList.Size = new System.Drawing.Size(113, 20);
            this.lblPresList.TabIndex = 66;
            this.lblPresList.Text = "Prescriptions";
            // 
            // lstPrescriptions
            // 
            this.lstPrescriptions.FormattingEnabled = true;
            this.lstPrescriptions.Location = new System.Drawing.Point(195, 39);
            this.lstPrescriptions.Name = "lstPrescriptions";
            this.lstPrescriptions.Size = new System.Drawing.Size(147, 186);
            this.lstPrescriptions.TabIndex = 28;
            this.lstPrescriptions.Click += new System.EventHandler(this.lstPrescriptions_Click);
            // 
            // lblBacktoMenu
            // 
            this.lblBacktoMenu.AutoSize = true;
            this.lblBacktoMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBacktoMenu.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblBacktoMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblBacktoMenu.Location = new System.Drawing.Point(122, 118);
            this.lblBacktoMenu.Name = "lblBacktoMenu";
            this.lblBacktoMenu.Size = new System.Drawing.Size(144, 25);
            this.lblBacktoMenu.TabIndex = 97;
            this.lblBacktoMenu.Text = "Back to Menu";
            // 
            // lblPrescriptions
            // 
            this.lblPrescriptions.AutoSize = true;
            this.lblPrescriptions.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrescriptions.Location = new System.Drawing.Point(426, 12);
            this.lblPrescriptions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrescriptions.Name = "lblPrescriptions";
            this.lblPrescriptions.Size = new System.Drawing.Size(443, 75);
            this.lblPrescriptions.TabIndex = 95;
            this.lblPrescriptions.Text = "Prescriptions";
            // 
            // picArrow
            // 
            this.picArrow.Location = new System.Drawing.Point(260, 90);
            this.picArrow.Name = "picArrow";
            this.picArrow.Size = new System.Drawing.Size(48, 46);
            this.picArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picArrow.TabIndex = 98;
            this.picArrow.TabStop = false;
            // 
            // PBIcon
            // 
            this.PBIcon.Image = global::LloydsPharmacy.Properties.Resources.medicine;
            this.PBIcon.Location = new System.Drawing.Point(856, 7);
            this.PBIcon.Margin = new System.Windows.Forms.Padding(2);
            this.PBIcon.Name = "PBIcon";
            this.PBIcon.Size = new System.Drawing.Size(90, 81);
            this.PBIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBIcon.TabIndex = 96;
            this.PBIcon.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogo.Image = global::LloydsPharmacy.Properties.Resources.logo;
            this.pbLogo.Location = new System.Drawing.Point(12, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(409, 76);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 94;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // frmPrescriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 749);
            this.Controls.Add(this.lblPresDetLV);
            this.Controls.Add(this.lvwPresDetails);
            this.Controls.Add(this.btnUpdateItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.lblPresLV);
            this.Controls.Add(this.lvwPrescriptions);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlDelivRec);
            this.Controls.Add(this.pnlLists);
            this.Controls.Add(this.picArrow);
            this.Controls.Add(this.lblBacktoMenu);
            this.Controls.Add(this.PBIcon);
            this.Controls.Add(this.lblPrescriptions);
            this.Controls.Add(this.pbLogo);
            this.Name = "frmPrescriptions";
            this.Text = "frmPrescriptions";
            this.Load += new System.EventHandler(this.frmPrescriptions_Load);
            this.pnlButtons.ResumeLayout(false);
            this.pnlDelivRec.ResumeLayout(false);
            this.pnlDelivRec.PerformLayout();
            this.pnlLists.ResumeLayout(false);
            this.pnlLists.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPresDetLV;
        private System.Windows.Forms.ListView lvwPresDetails;
        private System.Windows.Forms.ColumnHeader stockID;
        private System.Windows.Forms.ColumnHeader delivery;
        private System.Windows.Forms.ColumnHeader recurringPres;
        private System.Windows.Forms.Button btnUpdateItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Label lblPresLV;
        private System.Windows.Forms.ListView lvwPrescriptions;
        private System.Windows.Forms.ColumnHeader PresID;
        private System.Windows.Forms.ColumnHeader PatID;
        private System.Windows.Forms.ColumnHeader PresDate;
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
        private System.Windows.Forms.Panel pnlDelivRec;
        private System.Windows.Forms.ComboBox cmbRecPres;
        private System.Windows.Forms.ComboBox cmbDelivery;
        private System.Windows.Forms.ComboBox cmbCurrentStockID;
        private System.Windows.Forms.Label lblStockID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlLists;
        private System.Windows.Forms.Label lblPatients;
        private System.Windows.Forms.ListBox lstPatients;
        private System.Windows.Forms.Label lblPresList;
        private System.Windows.Forms.ListBox lstPrescriptions;
        private System.Windows.Forms.PictureBox picArrow;
        private System.Windows.Forms.Label lblBacktoMenu;
        private System.Windows.Forms.PictureBox PBIcon;
        private System.Windows.Forms.Label lblPrescriptions;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}