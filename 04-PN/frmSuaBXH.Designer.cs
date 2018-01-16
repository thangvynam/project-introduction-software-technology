namespace _04_PN
{
    partial class frmSuaBXH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuaBXH));
            this.cmbCLB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWin = new System.Windows.Forms.TextBox();
            this.txtLose = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pcbCLB = new System.Windows.Forms.PictureBox();
            this.lstKetQua = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCLB)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCLB
            // 
            this.cmbCLB.DisplayMember = "(none)";
            this.cmbCLB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCLB.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCLB.ForeColor = System.Drawing.Color.Red;
            this.cmbCLB.FormattingEnabled = true;
            this.cmbCLB.Location = new System.Drawing.Point(27, 26);
            this.cmbCLB.Name = "cmbCLB";
            this.cmbCLB.Size = new System.Drawing.Size(179, 24);
            this.cmbCLB.TabIndex = 2;
            this.cmbCLB.SelectedIndexChanged += new System.EventHandler(this.cmbCLB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(257, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 53);
            this.label1.TabIndex = 4;
            this.label1.Text = "WIN";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(443, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 53);
            this.label3.TabIndex = 6;
            this.label3.Text = "LOSE";
            // 
            // txtWin
            // 
            this.txtWin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWin.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWin.Location = new System.Drawing.Point(355, 9);
            this.txtWin.Multiline = true;
            this.txtWin.Name = "txtWin";
            this.txtWin.Size = new System.Drawing.Size(80, 41);
            this.txtWin.TabIndex = 7;
            this.txtWin.Text = "0";
            this.txtWin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLose
            // 
            this.txtLose.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLose.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLose.Location = new System.Drawing.Point(580, 9);
            this.txtLose.Multiline = true;
            this.txtLose.Name = "txtLose";
            this.txtLose.Size = new System.Drawing.Size(83, 41);
            this.txtLose.TabIndex = 8;
            this.txtLose.Text = "0";
            this.txtLose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(400, 287);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 36);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pcbCLB
            // 
            this.pcbCLB.Location = new System.Drawing.Point(27, 65);
            this.pcbCLB.Name = "pcbCLB";
            this.pcbCLB.Size = new System.Drawing.Size(235, 193);
            this.pcbCLB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCLB.TabIndex = 3;
            this.pcbCLB.TabStop = false;
            // 
            // lstKetQua
            // 
            this.lstKetQua.FormattingEnabled = true;
            this.lstKetQua.ItemHeight = 14;
            this.lstKetQua.Location = new System.Drawing.Point(284, 65);
            this.lstKetQua.Name = "lstKetQua";
            this.lstKetQua.Size = new System.Drawing.Size(379, 186);
            this.lstKetQua.TabIndex = 10;
            // 
            // frmSuaBXH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(675, 335);
            this.Controls.Add(this.lstKetQua);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtLose);
            this.Controls.Add(this.txtWin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbCLB);
            this.Controls.Add(this.cmbCLB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSuaBXH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh sửa bảng xếp hạng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSuaBXH_FormClosing);
            this.Load += new System.EventHandler(this.frmSuaBXH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCLB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCLB;
        private System.Windows.Forms.PictureBox pcbCLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWin;
        private System.Windows.Forms.TextBox txtLose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lstKetQua;

    }
}