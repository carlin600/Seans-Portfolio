namespace KennelClub
{
    partial class frmSize
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
            this.tabsize = new System.Windows.Forms.TabControl();
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
            this.dgvSize = new System.Windows.Forms.DataGridView();
            this.tabadd = new System.Windows.Forms.TabPage();
            this.lbladdSizeNo = new System.Windows.Forms.Label();
            this.txtaddChargePD = new System.Windows.Forms.TextBox();
            this.lbladdchargepd = new System.Windows.Forms.Label();
            this.lbladdsno = new System.Windows.Forms.Label();
            this.btnaddAdd = new System.Windows.Forms.Button();
            this.lbladdcancel = new System.Windows.Forms.Label();
            this.btnaddCancel = new System.Windows.Forms.Button();
            this.lbladdadd = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabedit = new System.Windows.Forms.TabPage();
            this.lbleditSizeNo = new System.Windows.Forms.Label();
            this.txteditChargePD = new System.Windows.Forms.TextBox();
            this.lbleditchargePD = new System.Windows.Forms.Label();
            this.lbleditsno = new System.Windows.Forms.Label();
            this.btneditEdit = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbleditcancel = new System.Windows.Forms.Label();
            this.btneditCancel = new System.Windows.Forms.Button();
            this.lbleditedit = new System.Windows.Forms.Label();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tabsize.SuspendLayout();
            this.tabdisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSize)).BeginInit();
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
            this.pictureBox4.Location = new System.Drawing.Point(369, 13);
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
            this.label1.Location = new System.Drawing.Point(33, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 78);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kennel Club";
            // 
            // tabsize
            // 
            this.tabsize.Controls.Add(this.tabdisplay);
            this.tabsize.Controls.Add(this.tabadd);
            this.tabsize.Controls.Add(this.tabedit);
            this.tabsize.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabsize.Location = new System.Drawing.Point(36, 91);
            this.tabsize.Name = "tabsize";
            this.tabsize.SelectedIndex = 0;
            this.tabsize.Size = new System.Drawing.Size(878, 511);
            this.tabsize.TabIndex = 3;
            this.tabsize.SelectedIndexChanged += new System.EventHandler(this.tabSize_SelctectedIndexChanged);
            // 
            // tabdisplay
            // 
            this.tabdisplay.BackColor = System.Drawing.SystemColors.Highlight;
            this.tabdisplay.Controls.Add(this.lbldisplayexit);
            this.tabdisplay.Controls.Add(this.lbldisplaydelete);
            this.tabdisplay.Controls.Add(this.lbldisplayedit);
            this.tabdisplay.Controls.Add(this.lbldisplayadd);
            this.tabdisplay.Controls.Add(this.btndisplayexit);
            this.tabdisplay.Controls.Add(this.btndisplaydelete);
            this.tabdisplay.Controls.Add(this.btndisplayedit);
            this.tabdisplay.Controls.Add(this.btndisplayadd);
            this.tabdisplay.Controls.Add(this.pictureBox1);
            this.tabdisplay.Controls.Add(this.dgvSize);
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
            // dgvSize
            // 
            this.dgvSize.AllowUserToAddRows = false;
            this.dgvSize.AllowUserToDeleteRows = false;
            this.dgvSize.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dgvSize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSize.Location = new System.Drawing.Point(15, 28);
            this.dgvSize.Name = "dgvSize";
            this.dgvSize.ReadOnly = true;
            this.dgvSize.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSize.Size = new System.Drawing.Size(520, 413);
            this.dgvSize.TabIndex = 0;
            // 
            // tabadd
            // 
            this.tabadd.BackColor = System.Drawing.SystemColors.Highlight;
            this.tabadd.Controls.Add(this.lbladdSizeNo);
            this.tabadd.Controls.Add(this.txtaddChargePD);
            this.tabadd.Controls.Add(this.lbladdchargepd);
            this.tabadd.Controls.Add(this.lbladdsno);
            this.tabadd.Controls.Add(this.btnaddAdd);
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
            // lbladdSizeNo
            // 
            this.lbladdSizeNo.AutoSize = true;
            this.lbladdSizeNo.Location = new System.Drawing.Point(144, 44);
            this.lbladdSizeNo.Name = "lbladdSizeNo";
            this.lbladdSizeNo.Size = new System.Drawing.Size(0, 19);
            this.lbladdSizeNo.TabIndex = 42;
            // 
            // txtaddChargePD
            // 
            this.txtaddChargePD.Location = new System.Drawing.Point(148, 94);
            this.txtaddChargePD.Name = "txtaddChargePD";
            this.txtaddChargePD.Size = new System.Drawing.Size(416, 27);
            this.txtaddChargePD.TabIndex = 41;
            // 
            // lbladdchargepd
            // 
            this.lbladdchargepd.AutoSize = true;
            this.lbladdchargepd.Location = new System.Drawing.Point(28, 97);
            this.lbladdchargepd.Name = "lbladdchargepd";
            this.lbladdchargepd.Size = new System.Drawing.Size(114, 19);
            this.lbladdchargepd.TabIndex = 40;
            this.lbladdchargepd.Text = "Charge Per Day";
            // 
            // lbladdsno
            // 
            this.lbladdsno.AutoSize = true;
            this.lbladdsno.Location = new System.Drawing.Point(28, 44);
            this.lbladdsno.Name = "lbladdsno";
            this.lbladdsno.Size = new System.Drawing.Size(61, 19);
            this.lbladdsno.TabIndex = 39;
            this.lbladdsno.Text = "Size No";
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
            this.tabedit.BackColor = System.Drawing.SystemColors.Highlight;
            this.tabedit.Controls.Add(this.lbleditSizeNo);
            this.tabedit.Controls.Add(this.txteditChargePD);
            this.tabedit.Controls.Add(this.lbleditchargePD);
            this.tabedit.Controls.Add(this.lbleditsno);
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
            // lbleditSizeNo
            // 
            this.lbleditSizeNo.AutoSize = true;
            this.lbleditSizeNo.Location = new System.Drawing.Point(144, 44);
            this.lbleditSizeNo.Name = "lbleditSizeNo";
            this.lbleditSizeNo.Size = new System.Drawing.Size(0, 19);
            this.lbleditSizeNo.TabIndex = 57;
            // 
            // txteditChargePD
            // 
            this.txteditChargePD.Location = new System.Drawing.Point(148, 94);
            this.txteditChargePD.Name = "txteditChargePD";
            this.txteditChargePD.Size = new System.Drawing.Size(416, 27);
            this.txteditChargePD.TabIndex = 56;
            // 
            // lbleditchargePD
            // 
            this.lbleditchargePD.AutoSize = true;
            this.lbleditchargePD.Location = new System.Drawing.Point(28, 97);
            this.lbleditchargePD.Name = "lbleditchargePD";
            this.lbleditchargePD.Size = new System.Drawing.Size(114, 19);
            this.lbleditchargePD.TabIndex = 55;
            this.lbleditchargePD.Text = "Charge Per Day";
            // 
            // lbleditsno
            // 
            this.lbleditsno.AutoSize = true;
            this.lbleditsno.Location = new System.Drawing.Point(28, 44);
            this.lbleditsno.Name = "lbleditsno";
            this.lbleditsno.Size = new System.Drawing.Size(61, 19);
            this.lbleditsno.TabIndex = 54;
            this.lbleditsno.Text = "Size No";
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
            // frmSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 613);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabsize);
            this.Name = "frmSize";
            this.Text = "frmSize";
            this.Load += new System.EventHandler(this.frmSize_Load);
            this.Shown += new System.EventHandler(this.frmKennel_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tabsize.ResumeLayout(false);
            this.tabdisplay.ResumeLayout(false);
            this.tabdisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSize)).EndInit();
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
        private System.Windows.Forms.TabControl tabsize;
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
        private System.Windows.Forms.DataGridView dgvSize;
        private System.Windows.Forms.TabPage tabadd;
        private System.Windows.Forms.Button btnaddAdd;
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
        private System.Windows.Forms.ErrorProvider errP;
        private System.Windows.Forms.Label lbladdSizeNo;
        private System.Windows.Forms.TextBox txtaddChargePD;
        private System.Windows.Forms.Label lbladdchargepd;
        private System.Windows.Forms.Label lbladdsno;
        private System.Windows.Forms.Label lbleditSizeNo;
        private System.Windows.Forms.TextBox txteditChargePD;
        private System.Windows.Forms.Label lbleditchargePD;
        private System.Windows.Forms.Label lbleditsno;
    }
}