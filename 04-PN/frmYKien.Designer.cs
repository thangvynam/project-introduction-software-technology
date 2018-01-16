namespace _04_PN
{
    partial class frmYKien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYKien));
            this.lstYKien = new System.Windows.Forms.ListView();
            this.column1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSmiling = new System.Windows.Forms.Label();
            this.lbSad = new System.Windows.Forms.Label();
            this.txtNoiDung = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbYeuThich = new System.Windows.Forms.Label();
            this.lbTerrible = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstYKien
            // 
            this.lstYKien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column1,
            this.column2});
            this.lstYKien.Location = new System.Drawing.Point(-1, -2);
            this.lstYKien.Name = "lstYKien";
            this.lstYKien.Size = new System.Drawing.Size(352, 361);
            this.lstYKien.TabIndex = 0;
            this.lstYKien.UseCompatibleStateImageBehavior = false;
            this.lstYKien.View = System.Windows.Forms.View.Details;
            this.lstYKien.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstYKien_MouseClick);
            // 
            // column1
            // 
            this.column1.Text = "Nội dung";
            this.column1.Width = 200;
            // 
            // column2
            // 
            this.column2.Text = "Trạng thái";
            this.column2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column2.Width = 150;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số người hài lòng";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số người không hài lòng";
            // 
            // lbSmiling
            // 
            this.lbSmiling.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSmiling.ForeColor = System.Drawing.Color.Coral;
            this.lbSmiling.Location = new System.Drawing.Point(541, 89);
            this.lbSmiling.Name = "lbSmiling";
            this.lbSmiling.Size = new System.Drawing.Size(64, 32);
            this.lbSmiling.TabIndex = 3;
            this.lbSmiling.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSad
            // 
            this.lbSad.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSad.ForeColor = System.Drawing.Color.Coral;
            this.lbSad.Location = new System.Drawing.Point(541, 130);
            this.lbSad.Name = "lbSad";
            this.lbSad.Size = new System.Drawing.Size(64, 32);
            this.lbSad.TabIndex = 4;
            this.lbSad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDung.Location = new System.Drawing.Point(6, 17);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(259, 138);
            this.txtNoiDung.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNoiDung);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(357, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 167);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ý kiến người dùng";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(363, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số người yêu thích";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(363, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số người chọn kém";
            // 
            // lbYeuThich
            // 
            this.lbYeuThich.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYeuThich.ForeColor = System.Drawing.Color.Coral;
            this.lbYeuThich.Location = new System.Drawing.Point(541, -2);
            this.lbYeuThich.Name = "lbYeuThich";
            this.lbYeuThich.Size = new System.Drawing.Size(64, 32);
            this.lbYeuThich.TabIndex = 9;
            this.lbYeuThich.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTerrible
            // 
            this.lbTerrible.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTerrible.ForeColor = System.Drawing.Color.Coral;
            this.lbTerrible.Location = new System.Drawing.Point(541, 39);
            this.lbTerrible.Name = "lbTerrible";
            this.lbTerrible.Size = new System.Drawing.Size(64, 32);
            this.lbTerrible.TabIndex = 10;
            this.lbTerrible.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmYKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(636, 357);
            this.Controls.Add(this.lbTerrible);
            this.Controls.Add(this.lbYeuThich);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbSad);
            this.Controls.Add(this.lbSmiling);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstYKien);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmYKien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phản hồi người dùng";
            this.Load += new System.EventHandler(this.frmYKien_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstYKien;
        private System.Windows.Forms.ColumnHeader column1;
        private System.Windows.Forms.ColumnHeader column2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSmiling;
        private System.Windows.Forms.Label lbSad;
        private System.Windows.Forms.Label txtNoiDung;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbYeuThich;
        private System.Windows.Forms.Label lbTerrible;

    }
}