using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace _04_PN
{
    public partial class frmQuanLyGiai : Form
    {
        Image check = _04_PN.Properties.Resources._checked;
        public frmQuanLyGiai()
        {
            InitializeComponent();
            pictureBox1.Image = check;
        }

 
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtGiaiThuong.Text.ToString().Equals("") || txtGioiThieu.Text.ToString().Equals("") || txtNhaTaiTro.Text.ToString().Equals(""))
            {
                MessageBox.Show("Vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(dtp1.Value.CompareTo(dtp2.Value)>=0)
                {
                    MessageBox.Show("Vui lòng kiểm tra lại thời gian", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    StreamWriter sw = new StreamWriter(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\test.txt");
                    sw.WriteLine(txtNhaTaiTro.Text.ToString());
                    sw.WriteLine(dtp1.Value.ToShortDateString() + '-' + dtp2.Value.ToShortDateString());
                    sw.WriteLine(txtGiaiThuong.Text.ToString() +' '+ cmbUnit.Text.ToString());
                    sw.WriteLine(txtGioiThieu.Text.ToString());
                    sw.Close();
                    MessageBox.Show("Đã lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            int checkWidth =check.Width+(check.Width * 60) / 100;
            int checkHeight =check.Height+ (check.Height * 60) / 100;

            Bitmap check_1 = new Bitmap(checkWidth, checkHeight);
            Graphics graphic = Graphics.FromImage(check_1);
            graphic.DrawImage(check, new Rectangle(Point.Empty, check_1.Size));
            pictureBox1.Image = check_1;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = check;
        }

       
    }
}
