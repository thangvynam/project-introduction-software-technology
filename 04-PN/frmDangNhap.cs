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
    public partial class frmDangNhap : Form
    {
        Dictionary<string, string> account = new Dictionary<string, string>();
        
        public frmDangNhap()
        {
            InitializeComponent();
            
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            
           // ở đây cần phải kiểm tra xem màn hình cần vào trong là màn hình của ai 
            if(txtName.Text.ToString()!="" && txtPassword.Text.ToString() !="")
            {

                if(txtName.Text.ToString().Equals("quanlygiai") && txtPassword.Text.ToString().Equals("12345678"))
                {

                    frmTuyChonQuanLy frmTuyChon = new frmTuyChonQuanLy();
                    if (frmTuyChon.ShowDialog() == DialogResult.OK)
                    {

                    }
                   
                }
                else
                {
                    bool _check = false;
                   
                    StreamReader sr = new StreamReader(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\account.txt");
                    while (sr.Peek() >= 0)
                    {
                        string s = sr.ReadLine();
                        string[] arr = s.Split(' ');
                        if (txtName.Text.ToString().Equals(arr[0]) && txtPassword.Text.ToString().Equals(arr[1]))
                            _check = true;
                    }
                    sr.Close();
                    if(_check)
                    {
                        frmGiaoDienNguoiDung frm = new frmGiaoDienNguoiDung();
                        if (frm.ShowDialog() == DialogResult.OK)
                        {

                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng kiểm tra lại tài khoản ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra tài khoản nhập", "Quản lý giải bóng rổ ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            frmTaoTaiKhoan frmTao = new frmTaoTaiKhoan();
            if(frmTao.ShowDialog() ==DialogResult.OK)
            {

            }
        
        }

        

       
    }
}
