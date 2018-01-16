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
    public partial class frmGiaoDienNguoiDung : Form
    {
        
        
        //string strConn = @"Server=THANGVYNAM\SQLEXPRESS;Database=QLGiai;User Id=sa;pwd=namdeptrai12";
        
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);

        string fullpath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\image";
        List<int> namThanhLap = new List<int>();
        List<string> nhaThiDau = new List<string>();
        List<string> mauAo = new List<string>();
        List<string> HLV = new List<string>();
        List<string> lichSu = new List<string>();

        List<string> viTri = new List<string>();
        List<int> canNang = new List<int>();
        List<int> chieuCao = new List<int>();
        List<int> maCLB = new List<int>();
        List<string> clb = new List<string>();
        List<int> maCauThu = new List<int>();
        List<DateTime> listDateTime = new List<DateTime>();
        List<int> listMaCLB1 = new List<int>();
        List<int> listMaCLB2 = new List<int>();
        List<int> listVong = new List<int>();
        List<string> listSan = new List<string>();
        string temp;
        AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
        private int ticks;

        bool update = false;
       
        public frmGiaoDienNguoiDung()
        {
            InitializeComponent();
            
            timer1.Start();

        }


        private void frmGiaoDienNguoiDung_Load(object sender, EventArgs e)
        {
            cmbCLB.Items.Clear();
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "  select * from CLB order by TenCLB asc";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                temp = reader.GetString(1);
                namThanhLap.Add(reader.GetInt32(2));
                lichSu.Add(reader.GetString(3));
                nhaThiDau.Add(reader.GetString(4));
                mauAo.Add(reader.GetString(5));
                HLV.Add(reader.GetString(6));
                clb.Add(temp);
                cmbCLB.Items.Add(temp);
                comboBox1.Items.Add(temp);
            }
            
            reader.Close();


            SqlCommand command1 = new SqlCommand();
            command1.CommandType = CommandType.Text;
            command1.CommandText = "  select * from CauThu";
            command1.Connection = conn;
            SqlDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                collection.Add(reader1.GetString(2));
                viTri.Add(reader1.GetString(3));
                chieuCao.Add(reader1.GetInt32(5));
                canNang.Add(reader1.GetInt32(4));
                maCLB.Add(reader1.GetInt32(1));
                maCauThu.Add(reader1.GetInt32(0));

            }
            txtTenCauThu.AutoCompleteCustomSource = collection;
            reader1.Close();

            SqlCommand command2 = new SqlCommand();
            command2.CommandType = CommandType.Text;
            command2.CommandText = "  select * from LichThiDau";
            command2.Connection = conn;
            SqlDataReader reader2 = command2.ExecuteReader();

            while (reader2.Read())
            {
                DateTime datetime = reader2.GetDateTime(0);
                listDateTime.Add(datetime);
                listMaCLB1.Add(reader2.GetInt32(1));
                listMaCLB2.Add(reader2.GetInt32(2));
                listVong.Add(reader2.GetInt32(4));
                listSan.Add(reader2.GetString(5));
            }
           
            reader1.Close();

            cmbCLB.SelectedIndex = 0;
            string fullpath1 = fullpath + "\\canthocatfish.png";
            pcbCLB.Image = new Bitmap(fullpath1);
            lbCLB.Text = cmbCLB.Text.ToString();
            lbCLB.ForeColor = Color.Green;
            txtThanhLap.Text = namThanhLap[0].ToString();
            txtNhaThiDau.Text = nhaThiDau[0].ToString();
            txtMauAo.Text = mauAo[0].ToString();
            txtLichSu.Text = lichSu[0].ToString();
            txtHLV.Text = HLV[0].ToString();

            List<string> info = new List<string>();
            StreamReader sr = new StreamReader(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\test.txt");
            while (sr.Peek() >= 0)
            {
                info.Add(sr.ReadLine());
            }
            sr.Close();
            lbNhaTaiTro.Text = info.ElementAt(0).ToString();
            lbThoiGian.Text = info.ElementAt(1).ToString();
            lbGiaiThuong.Text = info.ElementAt(2).ToString();
            lbGioiThieu.Text = info.ElementAt(3).ToString();
        }
        
        private void cmbCLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCLB.DropDownStyle = ComboBoxStyle.DropDownList; // phải có nó , nó mới ra
           
            switch(cmbCLB.SelectedIndex)
            {

                case 0:
                    {
                        string fullpath1 = fullpath + "\\canthocatfish.png";
                        pcbCLB.Image = new Bitmap(fullpath1);
                        lbCLB.Text = cmbCLB.Text.ToString();
                        lbCLB.ForeColor = Color.Green;
                        txtThanhLap.Text = namThanhLap[0].ToString();
                        txtNhaThiDau.Text = nhaThiDau[0].ToString();
                        txtMauAo.Text = mauAo[0].ToString();
                        txtLichSu.Text = lichSu[0].ToString();
                        txtHLV.Text = HLV[0].ToString();
                    }
                    break;
                case 1:
                    {
                        string fullpath1 = fullpath + "\\danangdragon.png";
                        pcbCLB.Image = new Bitmap(fullpath1);
                        lbCLB.Text = cmbCLB.Text.ToString();
                        lbCLB.ForeColor = Color.Orange;
                        txtThanhLap.Text = namThanhLap[1].ToString();
                        txtNhaThiDau.Text = nhaThiDau[1].ToString();
                        txtMauAo.Text = mauAo[1].ToString();
                        txtLichSu.Text = lichSu[1].ToString();
                        txtHLV.Text = HLV[1].ToString();
                    }
                    break;
                case 2:
                    {
                        string fullpath1 = fullpath + "\\hanoibuffaloes.png";
                        pcbCLB.Image = new Bitmap(fullpath1);
                        lbCLB.Text = cmbCLB.Text.ToString();
                        lbCLB.ForeColor = Color.Blue;
                        txtThanhLap.Text = namThanhLap[2].ToString();
                        txtNhaThiDau.Text = nhaThiDau[2].ToString();
                        txtMauAo.Text = mauAo[2].ToString();
                        txtLichSu.Text = lichSu[2].ToString();
                        txtHLV.Text = HLV[2].ToString();
                    }
                    break;
                case 3:

                    {
                        string fullpath1 = fullpath + "\\hochiminhwings.png";
                        pcbCLB.Image = new Bitmap(fullpath1);
                        lbCLB.Text = cmbCLB.Text.ToString();
                        lbCLB.ForeColor = Color.Purple;
                        txtThanhLap.Text = namThanhLap[3].ToString();
                        txtNhaThiDau.Text = nhaThiDau[3].ToString();
                        txtMauAo.Text = mauAo[3].ToString();
                        txtLichSu.Text = lichSu[3].ToString();
                        txtHLV.Text = HLV[3].ToString();
                    }
                    break;
                case 4:
                    {
                        string fullpath1 = fullpath + "\\saigonheat.png";
                        pcbCLB.Image = new Bitmap(fullpath1);
                        lbCLB.Text = cmbCLB.Text.ToString();
                        lbCLB.ForeColor = Color.OrangeRed;
                        txtThanhLap.Text = namThanhLap[4].ToString();
                        txtNhaThiDau.Text = nhaThiDau[4].ToString();
                        txtMauAo.Text = mauAo[4].ToString();
                        txtLichSu.Text = lichSu[4].ToString();
                        txtHLV.Text = HLV[4].ToString();
                    }
                    break;
                case 5:
                    {
                        string fullpath1 = fullpath + "\\thanglongwarriors.png";
                        pcbCLB.Image = new Bitmap(fullpath1);
                        lbCLB.Text = cmbCLB.Text.ToString();
                        lbCLB.ForeColor = Color.Red;
                        txtThanhLap.Text = namThanhLap[5].ToString();
                        txtNhaThiDau.Text = nhaThiDau[5].ToString();
                        txtMauAo.Text = mauAo[5].ToString();
                        txtLichSu.Text = lichSu[5].ToString();
                        txtHLV.Text = HLV[5].ToString();
                    }
                    break;
            }
        }
      



        private void btnSearch_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            bool search = false;
            for (int i = 0; i < collection.Count; i++)
            {
                if (txtTenCauThu.Text.Equals(collection[i]))
                {
                    lbdoi.Visible = true;
                    lbViTri.Visible = true;
                    lbCanNang.Visible = true;
                    lbChieuCao.Visible = true;
                    txtViTri.Text = viTri[i].ToString();
                    lbTenCauThu.Text = txtTenCauThu.Text;
                    txtCanNang.Text = canNang[i].ToString() + "\tkg";
                    txtChieuCao.Text = chieuCao[i].ToString() + "\tcm";
                    txtDoi.Text = clb[maCLB[i]].ToString();
                    string ma = maCauThu[i].ToString();
                    string fullpath1 = fullpath + "\\"+ma + ".png";
                    pcCauThu.Image = new Bitmap(fullpath1);
                    search = true;
                    break;
                }
            }
            if(!search)
            {
                lbdoi.Visible = false;
                lbViTri.Visible = false;
                lbCanNang.Visible = false;
                lbChieuCao.Visible = false;
                txtViTri.Text = lbTenCauThu.Text = txtCanNang.Text = txtChieuCao.Text = txtDoi.Text = "";
                pcCauThu.Image = null;
                MessageBox.Show("Cầu thủ không nằm trong danh sách\nVui lòng kiểm tra lại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void cmbVong_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                int temp =cmbVong.SelectedIndex ;
                int t1 = temp * 3;
                int t2 = t1 + 1;
                int t3 = t2 + 1;

                
               
                txtDoi1.Text = clb.ElementAt(listMaCLB1.ElementAt(t1));
                txtDoi2.Text = clb.ElementAt(listMaCLB2.ElementAt(t1));
                txtSan12.Text = listSan.ElementAt(t1).ToString();
                string[] arr = listDateTime.ElementAt(t1).ToString().Split(' ');
                txtNgay12.Text = arr[0];

                txtDoi3.Text = clb.ElementAt(listMaCLB1.ElementAt(t2));
                txtDoi4.Text = clb.ElementAt(listMaCLB2.ElementAt(t2));
                txtSan34.Text = listSan.ElementAt(t2).ToString();
                string[] arr1 = listDateTime.ElementAt(t2).ToString().Split(' ');
                txtNgay34.Text = arr1[0];

                txtDoi5.Text = clb.ElementAt(listMaCLB1.ElementAt(t3));
                txtDoi6.Text = clb.ElementAt(listMaCLB2.ElementAt(t3));
                txtSan56.Text = listSan.ElementAt(t3).ToString();
                string[] arr2 = listDateTime.ElementAt(t3).ToString().Split(' ');
                txtNgay56.Text = arr2[0];            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            if (ticks == 1)
            {
                frmIntro intro = new frmIntro();
                if (intro.ShowDialog() == DialogResult.OK)
                {

                }
                timer1.Stop();
            }
        }

        private void tabCauThu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!update)
            {
                update = true;
                if (tabCauThu.SelectedIndex == 3)
                {
                    StreamReader sr = new StreamReader(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\lichThuDau.txt");

                    int i = 1;
                    while (sr.Peek() >= 0)
                    {
                        string s = sr.ReadLine();
                        string[] arr = s.Split('%');

                        string[] row = { i.ToString(), arr.ElementAt(0), arr.ElementAt(1), arr.ElementAt(2) };
                        i++;
                        var listViewItem = new ListViewItem(row);
                        lstBXH.Items.Add(listViewItem);
                    }
                    sr.Close();

                    List<int> remove = new List<int>();
                    for (int j = 0; j < i - 2; j++)
                    {
                        for (int u = j + 1; u < i - 1; u++)
                        {
                            if (lstBXH.Items[j].SubItems[1].Text.ToString().Equals(lstBXH.Items[u].SubItems[1].Text.ToString()))
                                remove.Add(j);
                        }
                    }
                    if (remove.Count > 0)
                    {
                        for (int h = 0; h < remove.Count; h++)
                            lstBXH.Items[h].Remove();
                    }
                    ListViewItemComparer sorter = new ListViewItemComparer(2); // sort theo dòng cột 2 là cột win
                    lstBXH.ListViewItemSorter = sorter;
                    lstBXH.Sort();

                    //cập nhật lại vị trí
                    for (int k = 0; k < 6; k++)
                    {
                        lstBXH.Items[k].SubItems[0].Text = (k + 1).ToString();
                    }

                }
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            SqlCommand command1 = new SqlCommand();
            command1.CommandType = CommandType.Text;
            command1.CommandText = "select * from CauThu where MaCLB = " + cmbCLB.SelectedIndex;
            command1.Connection = conn;
            SqlDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                comboBox2.Items.Add(reader1.GetString(2));
            }
            reader1.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbTenCauThu.Text = comboBox2.Text.ToString();
            lbdoi.Visible = true;
            lbViTri.Visible = true;
            lbCanNang.Visible = true;
            lbChieuCao.Visible = true;
            for (int i = 0; i < collection.Count; i++)
            {
                if (lbTenCauThu.Text.Equals(collection[i]))
                {
                    txtViTri.Text = viTri[i].ToString();
                    
                    txtCanNang.Text = canNang[i].ToString() + "\tkg";
                    txtChieuCao.Text = chieuCao[i].ToString() + "\tcm";
                    txtDoi.Text = clb[maCLB[i]].ToString();
                    string ma = maCauThu[i].ToString();
                    string fullpath1 = fullpath +"\\"+ ma + ".png";
                    pcCauThu.Image = new Bitmap(fullpath1);
                }
            }
        }

        

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) +"\\feedback.txt", true);
            if(radSmiling.Checked)
            {
                sw.WriteLine(txtGopY.Text.ToString() + "%1");
            }
            else if(radSad.Checked)
            {
                sw.WriteLine(txtGopY.Text.ToString() + "%0");
            }
            else if(radLove.Checked)
            {
                sw.WriteLine(txtGopY.Text.ToString() + "%2");
            }
            else
                sw.WriteLine(txtGopY.Text.ToString() + "%3");
            sw.Close();
            MessageBox.Show("Cảm ơn vì sự góp ý của bạn ", "Quản lý giải", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtGopY.Text = "";
        }
    }
}
