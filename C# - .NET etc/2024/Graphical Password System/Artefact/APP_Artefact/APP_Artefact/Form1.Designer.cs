namespace APP_Artefact
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbPanel = new System.Windows.Forms.TabControl();
            this.tbMain = new System.Windows.Forms.TabPage();
            this.tbRegister = new System.Windows.Forms.TabPage();
            this.btnRegBack = new System.Windows.Forms.Button();
            this.tbLogin = new System.Windows.Forms.TabPage();
            this.btnLoginBack = new System.Windows.Forms.Button();
            this.tblButtonGroup = new System.Windows.Forms.TableLayoutPanel();
            this.btn9 = new System.Windows.Forms.Button();
            this.ilNature = new System.Windows.Forms.ImageList(this.components);
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.ilSports = new System.Windows.Forms.ImageList(this.components);
            this.ilNumbers = new System.Windows.Forms.ImageList(this.components);
            this.lblAmountSelected = new System.Windows.Forms.Label();
            this.txtAmountSelected = new System.Windows.Forms.TextBox();
            this.cmbSelectTheme = new System.Windows.Forms.ComboBox();
            this.lblSelectTheme = new System.Windows.Forms.Label();
            this.tbPanel.SuspendLayout();
            this.tbMain.SuspendLayout();
            this.tbRegister.SuspendLayout();
            this.tbLogin.SuspendLayout();
            this.tblButtonGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(34, 663);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(1412, 69);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit Application";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(27, 444);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(429, 106);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(27, 332);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(429, 106);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbPanel
            // 
            this.tbPanel.Controls.Add(this.tbMain);
            this.tbPanel.Controls.Add(this.tbRegister);
            this.tbPanel.Controls.Add(this.tbLogin);
            this.tbPanel.Location = new System.Drawing.Point(12, 59);
            this.tbPanel.Name = "tbPanel";
            this.tbPanel.SelectedIndex = 0;
            this.tbPanel.Size = new System.Drawing.Size(491, 589);
            this.tbPanel.TabIndex = 3;
            // 
            // tbMain
            // 
            this.tbMain.Controls.Add(this.btnRegister);
            this.tbMain.Controls.Add(this.btnLogin);
            this.tbMain.Location = new System.Drawing.Point(4, 29);
            this.tbMain.Name = "tbMain";
            this.tbMain.Padding = new System.Windows.Forms.Padding(3);
            this.tbMain.Size = new System.Drawing.Size(483, 556);
            this.tbMain.TabIndex = 0;
            this.tbMain.Text = "Main";
            this.tbMain.UseVisualStyleBackColor = true;
            // 
            // tbRegister
            // 
            this.tbRegister.Controls.Add(this.btnRegBack);
            this.tbRegister.Location = new System.Drawing.Point(4, 29);
            this.tbRegister.Name = "tbRegister";
            this.tbRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tbRegister.Size = new System.Drawing.Size(483, 556);
            this.tbRegister.TabIndex = 1;
            this.tbRegister.Text = "Register";
            this.tbRegister.UseVisualStyleBackColor = true;
            // 
            // btnRegBack
            // 
            this.btnRegBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegBack.Location = new System.Drawing.Point(18, 430);
            this.btnRegBack.Name = "btnRegBack";
            this.btnRegBack.Size = new System.Drawing.Size(429, 106);
            this.btnRegBack.TabIndex = 3;
            this.btnRegBack.Text = "Back";
            this.btnRegBack.UseVisualStyleBackColor = true;
            this.btnRegBack.Click += new System.EventHandler(this.btnRegBack_Click);
            // 
            // tbLogin
            // 
            this.tbLogin.Controls.Add(this.btnLoginBack);
            this.tbLogin.Location = new System.Drawing.Point(4, 29);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(483, 556);
            this.tbLogin.TabIndex = 2;
            this.tbLogin.Text = "Login";
            this.tbLogin.UseVisualStyleBackColor = true;
            // 
            // btnLoginBack
            // 
            this.btnLoginBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginBack.Location = new System.Drawing.Point(18, 434);
            this.btnLoginBack.Name = "btnLoginBack";
            this.btnLoginBack.Size = new System.Drawing.Size(429, 106);
            this.btnLoginBack.TabIndex = 4;
            this.btnLoginBack.Text = "Back";
            this.btnLoginBack.UseVisualStyleBackColor = true;
            this.btnLoginBack.Click += new System.EventHandler(this.btnLoginBack_Click);
            // 
            // tblButtonGroup
            // 
            this.tblButtonGroup.ColumnCount = 3;
            this.tblButtonGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblButtonGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblButtonGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblButtonGroup.Controls.Add(this.btn9, 2, 2);
            this.tblButtonGroup.Controls.Add(this.btn8, 1, 2);
            this.tblButtonGroup.Controls.Add(this.btn7, 0, 2);
            this.tblButtonGroup.Controls.Add(this.btn6, 2, 1);
            this.tblButtonGroup.Controls.Add(this.btn5, 1, 1);
            this.tblButtonGroup.Controls.Add(this.btn4, 0, 1);
            this.tblButtonGroup.Controls.Add(this.btn3, 2, 0);
            this.tblButtonGroup.Controls.Add(this.btn2, 1, 0);
            this.tblButtonGroup.Controls.Add(this.btn1, 0, 0);
            this.tblButtonGroup.Location = new System.Drawing.Point(509, 59);
            this.tblButtonGroup.Name = "tblButtonGroup";
            this.tblButtonGroup.RowCount = 3;
            this.tblButtonGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblButtonGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblButtonGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblButtonGroup.Size = new System.Drawing.Size(937, 589);
            this.tblButtonGroup.TabIndex = 0;
            // 
            // btn9
            // 
            this.btn9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn9.ForeColor = System.Drawing.Color.Transparent;
            this.btn9.ImageIndex = 8;
            this.btn9.ImageList = this.ilNature;
            this.btn9.Location = new System.Drawing.Point(627, 395);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(307, 191);
            this.btn9.TabIndex = 9;
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.Button_Click);
            // 
            // ilNature
            // 
            this.ilNature.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilNature.ImageStream")));
            this.ilNature.TransparentColor = System.Drawing.Color.Transparent;
            this.ilNature.Images.SetKeyName(0, "acorn.png");
            this.ilNature.Images.SetKeyName(1, "bee.png");
            this.ilNature.Images.SetKeyName(2, "fish.png");
            this.ilNature.Images.SetKeyName(3, "ladybug.png");
            this.ilNature.Images.SetKeyName(4, "mushroom.png");
            this.ilNature.Images.SetKeyName(5, "rain.png");
            this.ilNature.Images.SetKeyName(6, "sun.png");
            this.ilNature.Images.SetKeyName(7, "sunflower.png");
            this.ilNature.Images.SetKeyName(8, "water.png");
            // 
            // btn8
            // 
            this.btn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn8.ForeColor = System.Drawing.Color.Transparent;
            this.btn8.ImageIndex = 7;
            this.btn8.ImageList = this.ilNature;
            this.btn8.Location = new System.Drawing.Point(315, 395);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(306, 191);
            this.btn8.TabIndex = 8;
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn7
            // 
            this.btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn7.ForeColor = System.Drawing.Color.Transparent;
            this.btn7.ImageIndex = 6;
            this.btn7.ImageList = this.ilNature;
            this.btn7.Location = new System.Drawing.Point(3, 395);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(306, 191);
            this.btn7.TabIndex = 7;
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn6
            // 
            this.btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn6.ForeColor = System.Drawing.Color.Transparent;
            this.btn6.ImageIndex = 5;
            this.btn6.ImageList = this.ilNature;
            this.btn6.Location = new System.Drawing.Point(627, 199);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(307, 190);
            this.btn6.TabIndex = 6;
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn5
            // 
            this.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn5.ForeColor = System.Drawing.Color.Transparent;
            this.btn5.ImageIndex = 4;
            this.btn5.ImageList = this.ilNature;
            this.btn5.Location = new System.Drawing.Point(315, 199);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(306, 190);
            this.btn5.TabIndex = 5;
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn4
            // 
            this.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn4.ForeColor = System.Drawing.Color.Transparent;
            this.btn4.ImageIndex = 3;
            this.btn4.ImageList = this.ilNature;
            this.btn4.Location = new System.Drawing.Point(3, 199);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(306, 190);
            this.btn4.TabIndex = 4;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn3
            // 
            this.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn3.ForeColor = System.Drawing.Color.Transparent;
            this.btn3.ImageIndex = 2;
            this.btn3.ImageList = this.ilNature;
            this.btn3.Location = new System.Drawing.Point(627, 3);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(307, 190);
            this.btn3.TabIndex = 3;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn2
            // 
            this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn2.ForeColor = System.Drawing.Color.Transparent;
            this.btn2.ImageIndex = 1;
            this.btn2.ImageList = this.ilNature;
            this.btn2.Location = new System.Drawing.Point(315, 3);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(306, 190);
            this.btn2.TabIndex = 2;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn1
            // 
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn1.ForeColor = System.Drawing.Color.Transparent;
            this.btn1.ImageIndex = 0;
            this.btn1.ImageList = this.ilNature;
            this.btn1.Location = new System.Drawing.Point(3, 3);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(306, 190);
            this.btn1.TabIndex = 1;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Button_Click);
            // 
            // ilSports
            // 
            this.ilSports.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilSports.ImageStream")));
            this.ilSports.TransparentColor = System.Drawing.Color.Transparent;
            this.ilSports.Images.SetKeyName(0, "basketball.png");
            this.ilSports.Images.SetKeyName(1, "catch.png");
            this.ilSports.Images.SetKeyName(2, "gaming.png");
            this.ilSports.Images.SetKeyName(3, "painting.png");
            this.ilSports.Images.SetKeyName(4, "ping-pong.png");
            this.ilSports.Images.SetKeyName(5, "roller-skate.png");
            this.ilSports.Images.SetKeyName(6, "skateboarding.png");
            this.ilSports.Images.SetKeyName(7, "soccer.png");
            this.ilSports.Images.SetKeyName(8, "xylophone.png");
            // 
            // ilNumbers
            // 
            this.ilNumbers.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilNumbers.ImageStream")));
            this.ilNumbers.TransparentColor = System.Drawing.Color.Transparent;
            this.ilNumbers.Images.SetKeyName(0, "1.png");
            this.ilNumbers.Images.SetKeyName(1, "2.png");
            this.ilNumbers.Images.SetKeyName(2, "3.png");
            this.ilNumbers.Images.SetKeyName(3, "4.png");
            this.ilNumbers.Images.SetKeyName(4, "5.png");
            this.ilNumbers.Images.SetKeyName(5, "6.png");
            this.ilNumbers.Images.SetKeyName(6, "7.png");
            this.ilNumbers.Images.SetKeyName(7, "8.png");
            this.ilNumbers.Images.SetKeyName(8, "9.png");
            // 
            // lblAmountSelected
            // 
            this.lblAmountSelected.AutoSize = true;
            this.lblAmountSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountSelected.Location = new System.Drawing.Point(1146, 25);
            this.lblAmountSelected.Name = "lblAmountSelected";
            this.lblAmountSelected.Size = new System.Drawing.Size(218, 29);
            this.lblAmountSelected.TabIndex = 4;
            this.lblAmountSelected.Text = "Amount Selected:";
            // 
            // txtAmountSelected
            // 
            this.txtAmountSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountSelected.Location = new System.Drawing.Point(1370, 21);
            this.txtAmountSelected.Name = "txtAmountSelected";
            this.txtAmountSelected.ReadOnly = true;
            this.txtAmountSelected.Size = new System.Drawing.Size(73, 35);
            this.txtAmountSelected.TabIndex = 5;
            // 
            // cmbSelectTheme
            // 
            this.cmbSelectTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectTheme.FormattingEnabled = true;
            this.cmbSelectTheme.Items.AddRange(new object[] {
            "Sports",
            "Nature",
            "Numbers"});
            this.cmbSelectTheme.Location = new System.Drawing.Point(201, 22);
            this.cmbSelectTheme.Name = "cmbSelectTheme";
            this.cmbSelectTheme.Size = new System.Drawing.Size(295, 37);
            this.cmbSelectTheme.TabIndex = 6;
            this.cmbSelectTheme.SelectedIndexChanged += new System.EventHandler(this.cmbSelectTheme_SelectedIndexChanged);
            // 
            // lblSelectTheme
            // 
            this.lblSelectTheme.AutoSize = true;
            this.lblSelectTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectTheme.Location = new System.Drawing.Point(11, 25);
            this.lblSelectTheme.Name = "lblSelectTheme";
            this.lblSelectTheme.Size = new System.Drawing.Size(183, 29);
            this.lblSelectTheme.TabIndex = 7;
            this.lblSelectTheme.Text = "Select Theme:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 744);
            this.Controls.Add(this.lblSelectTheme);
            this.Controls.Add(this.cmbSelectTheme);
            this.Controls.Add(this.txtAmountSelected);
            this.Controls.Add(this.lblAmountSelected);
            this.Controls.Add(this.tblButtonGroup);
            this.Controls.Add(this.tbPanel);
            this.Controls.Add(this.btnExit);
            this.Name = "frmMain";
            this.Text = "Graphical Password System";
            this.tbPanel.ResumeLayout(false);
            this.tbMain.ResumeLayout(false);
            this.tbRegister.ResumeLayout(false);
            this.tbLogin.ResumeLayout(false);
            this.tblButtonGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TabControl tbPanel;
        private System.Windows.Forms.TabPage tbMain;
        private System.Windows.Forms.TabPage tbRegister;
        private System.Windows.Forms.TabPage tbLogin;
        private System.Windows.Forms.TableLayoutPanel tblButtonGroup;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.ImageList ilNature;
        private System.Windows.Forms.ImageList ilSports;
        private System.Windows.Forms.ImageList ilNumbers;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label lblAmountSelected;
        private System.Windows.Forms.TextBox txtAmountSelected;
        private System.Windows.Forms.ComboBox cmbSelectTheme;
        private System.Windows.Forms.Label lblSelectTheme;
        private System.Windows.Forms.Button btnRegBack;
        private System.Windows.Forms.Button btnLoginBack;
    }
}

