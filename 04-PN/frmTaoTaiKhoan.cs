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
    
    public partial class frmTaoTaiKhoan : Form
    {
        
        public frmTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tenDangKy = txtTenDangKy.Text;
            string matKhau = txtMatKhauDangKy.Text;
            string maKhauXacNhan = txtMauKhauXacNhan.Text;
            if(!tenDangKy.Equals("") && !matKhau.Equals("") && !maKhauXacNhan.Equals("") )
            {
                bool temp = tenDangKy.All(char.IsLetter);
                if (temp && matKhau.Equals(maKhauXacNhan) && matKhau.Count() >= 8 && !tenDangKy.Contains(' ') && !matKhau.Contains(' '))
                {
                    MessageBox.Show("Bạn đã đăng ký thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    StreamWriter sw = new StreamWriter(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\account.txt", true);
                    sw.WriteLine(tenDangKy + ' ' + matKhau);
                    sw.Close();
                    Close();
                }
                else
                    MessageBox.Show("Vui lòng kiểm tra lại  ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Vui lòng kiểm tra lại  ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
        }

        

   

  
    }
}
