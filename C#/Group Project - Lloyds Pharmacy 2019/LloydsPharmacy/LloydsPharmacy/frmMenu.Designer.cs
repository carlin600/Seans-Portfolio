namespace LloydsPharmacy
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.pnlNavBar = new System.Windows.Forms.Panel();
            this.lblTimetable = new System.Windows.Forms.Label();
            this.ilNavbar = new System.Windows.Forms.ImageList(this.components);
            this.lblSales = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblStaff = new System.Windows.Forms.Label();
            this.lblSuppliers = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblMAilment = new System.Windows.Forms.Label();
            this.lblPrescriptions = new System.Windows.Forms.Label();
            this.lblPatients = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.tSlider = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pbSlider = new System.Windows.Forms.PictureBox();
            this.PBIcon = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNavBar
            // 
            this.pnlNavBar.BackColor = System.Drawing.Color.White;
            this.pnlNavBar.Controls.Add(this.lblTimetable);
            this.pnlNavBar.Controls.Add(this.lblSales);
            this.pnlNavBar.Controls.Add(this.lblCourse);
            this.pnlNavBar.Controls.Add(this.lblStaff);
            this.pnlNavBar.Controls.Add(this.lblSuppliers);
            this.pnlNavBar.Controls.Add(this.lblStock);
            this.pnlNavBar.Controls.Add(this.lblMAilment);
            this.pnlNavBar.Controls.Add(this.lblPrescriptions);
            this.pnlNavBar.Controls.Add(this.lblPatients);
            this.pnlNavBar.Location = new System.Drawing.Point(-6, 100);
            this.pnlNavBar.Name = "pnlNavBar";
            this.pnlNavBar.Size = new System.Drawing.Size(1272, 59);
            this.pnlNavBar.TabIndex = 23;
            // 
            // lblTimetable
            // 
            this.lblTimetable.BackColor = System.Drawing.Color.Transparent;
            this.lblTimetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimetable.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTimetable.ImageList = this.ilNavbar;
            this.lblTimetable.Location = new System.Drawing.Point(1123, 0);
            this.lblTimetable.Name = "lblTimetable";
            this.lblTimetable.Size = new System.Drawing.Size(150, 60);
            this.lblTimetable.TabIndex = 11;
            this.lblTimetable.Text = "Timetable";
            this.lblTimetable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTimetable.Click += new System.EventHandler(this.lblTimetable_Click);
            this.lblTimetable.MouseEnter += new System.EventHandler(this.lblTimetable_MouseEnter);
            this.lblTimetable.MouseLeave += new System.EventHandler(this.lblTimetable_MouseLeave);
            // 
            // ilNavbar
            // 
            this.ilNavbar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilNavbar.ImageStream")));
            this.ilNavbar.TransparentColor = System.Drawing.Color.Transparent;
            this.ilNavbar.Images.SetKeyName(0, "checklist.png");
            this.ilNavbar.Images.SetKeyName(1, "patient.png");
            this.ilNavbar.Images.SetKeyName(2, "medicine.png");
            this.ilNavbar.Images.SetKeyName(3, "minor ailments.png");
            this.ilNavbar.Images.SetKeyName(4, "stock 2.png");
            this.ilNavbar.Images.SetKeyName(5, "supplier .png");
            this.ilNavbar.Images.SetKeyName(6, "staff.png");
            this.ilNavbar.Images.SetKeyName(7, "courses.png");
            this.ilNavbar.Images.SetKeyName(8, "sale.png");
            this.ilNavbar.Images.SetKeyName(9, "timetable.png");
            // 
            // lblSales
            // 
            this.lblSales.BackColor = System.Drawing.Color.Transparent;
            this.lblSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSales.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSales.ImageList = this.ilNavbar;
            this.lblSales.Location = new System.Drawing.Point(973, 0);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(150, 60);
            this.lblSales.TabIndex = 10;
            this.lblSales.Text = "Sales";
            this.lblSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSales.Click += new System.EventHandler(this.lblSales_Click);
            this.lblSales.MouseEnter += new System.EventHandler(this.lblSales_MouseEnter);
            this.lblSales.MouseLeave += new System.EventHandler(this.lblSales_MouseLeave);
            // 
            // lblCourse
            // 
            this.lblCourse.BackColor = System.Drawing.Color.Transparent;
            this.lblCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCourse.ImageList = this.ilNavbar;
            this.lblCourse.Location = new System.Drawing.Point(827, 0);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(150, 60);
            this.lblCourse.TabIndex = 9;
            this.lblCourse.Text = "Courses";
            this.lblCourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCourse.Click += new System.EventHandler(this.lblCourse_Click);
            this.lblCourse.MouseEnter += new System.EventHandler(this.lblCourse_MouseEnter);
            this.lblCourse.MouseLeave += new System.EventHandler(this.lblCourse_MouseLeave);
            // 
            // lblStaff
            // 
            this.lblStaff.BackColor = System.Drawing.Color.Transparent;
            this.lblStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaff.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblStaff.ImageList = this.ilNavbar;
            this.lblStaff.Location = new System.Drawing.Point(696, 0);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(150, 60);
            this.lblStaff.TabIndex = 8;
            this.lblStaff.Text = "Staff";
            this.lblStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStaff.Click += new System.EventHandler(this.lblStaff_Click);
            this.lblStaff.MouseEnter += new System.EventHandler(this.lblStaff_MouseEnter);
            this.lblStaff.MouseLeave += new System.EventHandler(this.lblStaff_MouseLeave);
            // 
            // lblSuppliers
            // 
            this.lblSuppliers.BackColor = System.Drawing.Color.Transparent;
            this.lblSuppliers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuppliers.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSuppliers.ImageList = this.ilNavbar;
            this.lblSuppliers.Location = new System.Drawing.Point(567, 0);
            this.lblSuppliers.Name = "lblSuppliers";
            this.lblSuppliers.Size = new System.Drawing.Size(150, 60);
            this.lblSuppliers.TabIndex = 7;
            this.lblSuppliers.Text = "Suppliers";
            this.lblSuppliers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSuppliers.Click += new System.EventHandler(this.lblSuppliers_Click);
            this.lblSuppliers.MouseEnter += new System.EventHandler(this.lblSupplier_MouseEnter);
            this.lblSuppliers.MouseLeave += new System.EventHandler(this.lblSupplier_MouseLeave);
            // 
            // lblStock
            // 
            this.lblStock.BackColor = System.Drawing.Color.Transparent;
            this.lblStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblStock.ImageList = this.ilNavbar;
            this.lblStock.Location = new System.Drawing.Point(429, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(150, 60);
            this.lblStock.TabIndex = 6;
            this.lblStock.Text = "Stock";
            this.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStock.Click += new System.EventHandler(this.lblStock_Click);
            this.lblStock.MouseEnter += new System.EventHandler(this.lblStock_MouseEnter);
            this.lblStock.MouseLeave += new System.EventHandler(this.lblStock_MouseLeave);
            // 
            // lblMAilment
            // 
            this.lblMAilment.BackColor = System.Drawing.Color.Transparent;
            this.lblMAilment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMAilment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMAilment.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblMAilment.ImageList = this.ilNavbar;
            this.lblMAilment.Location = new System.Drawing.Point(296, 0);
            this.lblMAilment.Name = "lblMAilment";
            this.lblMAilment.Size = new System.Drawing.Size(150, 60);
            this.lblMAilment.TabIndex = 5;
            this.lblMAilment.Text = "Minor Ailments";
            this.lblMAilment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMAilment.Click += new System.EventHandler(this.lblMAilment_Click);
            this.lblMAilment.MouseEnter += new System.EventHandler(this.lblMAilment_MouseEnter);
            this.lblMAilment.MouseLeave += new System.EventHandler(this.lblMAilment_MouseLeave);
            // 
            // lblPrescriptions
            // 
            this.lblPrescriptions.BackColor = System.Drawing.Color.Transparent;
            this.lblPrescriptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPrescriptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrescriptions.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblPrescriptions.ImageList = this.ilNavbar;
            this.lblPrescriptions.Location = new System.Drawing.Point(147, 0);
            this.lblPrescriptions.Name = "lblPrescriptions";
            this.lblPrescriptions.Size = new System.Drawing.Size(150, 60);
            this.lblPrescriptions.TabIndex = 4;
            this.lblPrescriptions.Text = "Prescriptions";
            this.lblPrescriptions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPrescriptions.Click += new System.EventHandler(this.lblPrescriptions_Click);
            this.lblPrescriptions.MouseEnter += new System.EventHandler(this.lblPrescriptions_MouseEnter);
            this.lblPrescriptions.MouseLeave += new System.EventHandler(this.lblPrescriptions_MouseLeave);
            // 
            // lblPatients
            // 
            this.lblPatients.BackColor = System.Drawing.Color.Transparent;
            this.lblPatients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatients.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblPatients.ImageList = this.ilNavbar;
            this.lblPatients.Location = new System.Drawing.Point(-2, 0);
            this.lblPatients.Name = "lblPatients";
            this.lblPatients.Size = new System.Drawing.Size(150, 60);
            this.lblPatients.TabIndex = 3;
            this.lblPatients.Text = "Patients";
            this.lblPatients.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPatients.Click += new System.EventHandler(this.lblPatients_Click);
            this.lblPatients.MouseEnter += new System.EventHandler(this.lblPatients_MouseEnter);
            this.lblPatients.MouseLeave += new System.EventHandler(this.lblPatients_MouseLeave);
            // 
            // lblMenu
            // 
            this.lblMenu.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(424, 11);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(209, 76);
            this.lblMenu.TabIndex = 51;
            this.lblMenu.Text = "Menu";
            // 
            // tSlider
            // 
            this.tSlider.Enabled = true;
            this.tSlider.Interval = 2250;
            this.tSlider.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(2, 165);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pbSlider);
            this.splitContainer1.Size = new System.Drawing.Size(1262, 609);
            this.splitContainer1.SplitterDistance = 519;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 53;
            // 
            // pbSlider
            // 
            this.pbSlider.Image = ((System.Drawing.Image)(resources.GetObject("pbSlider.Image")));
            this.pbSlider.Location = new System.Drawing.Point(0, 0);
            this.pbSlider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbSlider.Name = "pbSlider";
            this.pbSlider.Size = new System.Drawing.Size(1259, 518);
            this.pbSlider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlider.TabIndex = 0;
            this.pbSlider.TabStop = false;
            // 
            // PBIcon
            // 
            this.PBIcon.Image = global::LloydsPharmacy.Properties.Resources.menu;
            this.PBIcon.Location = new System.Drawing.Point(654, 5);
            this.PBIcon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PBIcon.Name = "PBIcon";
            this.PBIcon.Size = new System.Drawing.Size(90, 81);
            this.PBIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBIcon.TabIndex = 52;
            this.PBIcon.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::LloydsPharmacy.Properties.Resources.logo;
            this.pbLogo.Location = new System.Drawing.Point(10, 11);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(409, 76);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 50;
            this.pbLogo.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 774);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.PBIcon);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pnlNavBar);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.pnlNavBar.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNavBar;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.Label lblSuppliers;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblMAilment;
        private System.Windows.Forms.Label lblPrescriptions;
        private System.Windows.Forms.Label lblPatients;
        private System.Windows.Forms.ImageList ilNavbar;
        private System.Windows.Forms.PictureBox PBIcon;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Timer tSlider;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pbSlider;
        private System.Windows.Forms.Label lblTimetable;
    }
}