using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;
namespace _04_PN
{
    public partial class frmSuaBXH : Form
    {
        Image save = _04_PN.Properties.Resources.save;
        string fullpath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\image";
        StreamWriter sw = new StreamWriter(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\lichThuDau.txt");
        public static int i = 0;
        bool begin = false;
        List<string> nameCLB = new List<string>();
        public frmSuaBXH()
        {
            InitializeComponent();
            pictureBox1.Image = save;
        }

        private void frmSuaBXH_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "  select * from CLB order by TenCLB asc";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string temp = reader.GetString(1);
                cmbCLB.Items.Add(temp);
            }
            reader.Close();
            cmbCLB.SelectedIndex = 0;
            string fullpath1 = fullpath + "//canthocatfish.png";
            pcbCLB.Image = new Bitmap(fullpath1);
        }

        private void cmbCLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCLB.DropDownStyle = ComboBoxStyle.DropDownList; // phải có nó , nó mới ra

            switch (cmbCLB.SelectedIndex)
            {

                case 0:
                    {
                        string fullpath1 = fullpath + "//canthocatfish.png";
                        pcbCLB.Image = new Bitmap(fullpath1);
                    }
                    break;
                case 1:
                    {
                        string fullpath1 = fullpath + "//danangdragon.png";
                        pcbCLB.Image = new Bitmap(fullpath1);
                        
                    }
                    break;
                case 2:
                    {
                        string fullpath1 = fullpath + "//hanoibuffaloes.png";
                        pcbCLB.Image = new Bitmap(fullpath1);
                       
                    }
                    break;
                case 3:
                    {
                        string fullpath1 = fullpath + "//hochiminhwings.png";
                        pcbCLB.Image = new Bitmap(fullpath1);
                        
                    }
                    break;
                case 4:
                    {
                        string fullpath1 = fullpath + "//saigonheat.png";
                        pcbCLB.Image = new Bitmap(fullpath1);
                        
                    }
                    break;
                case 5:
                    {
                        string fullpath1 = fullpath + "//thanglongwarriors.png";
                        pcbCLB.Image = new Bitmap(fullpath1);
                        
                    }
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            begin = true;
            int n;
            if (txtLose.Text.ToString().Equals("") || txtWin.Text.ToString().Equals("") || !int.TryParse(txtWin.Text.ToString(), out n) || !int.TryParse(txtLose.Text.ToString(), out n))
            {

                MessageBox.Show("Vui lòng nhập đầy đủ ( chỉ là ký tự số ) ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Đã lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lstKetQua.Items.Add(cmbCLB.Text.ToString() + "\tW:    " + txtWin.Text.ToString() + "\tL:    " + txtLose.Text.ToString());
                sw.WriteLine(cmbCLB.Text.ToString() + "%" + txtWin.Text.ToString() + "%" + txtLose.Text.ToString());
                txtWin.Text = "";
                txtLose.Text = "";
                if(nameCLB.Count==0)
                {
                    i++;
                    nameCLB.Add(cmbCLB.Text.ToString());
                }
                else
                {
                    bool check = true;
                    for(int k=0;k<nameCLB.Count;k++)
                    {
                        if(nameCLB.ElementAt(k).Equals(cmbCLB.Text.ToString()))
                        {
                            check = false;
                        }
                    }
                    if(check)
                    {
                        i++;
                        nameCLB.Add(cmbCLB.Text.ToString());
                    }
                }
                
            }
        }

        private void frmSuaBXH_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!begin)
            {
                sw.Close();
            }
            else
            {
                if (i == cmbCLB.Items.Count)
                    sw.Close();
                else
                {
                    MessageBox.Show("Một vài đội bóng chưa được nhập dữ liệu\nVui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }

            }
            
        }
    }
}
