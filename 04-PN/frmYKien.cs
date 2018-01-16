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
    public partial class frmYKien : Form
    {
        public frmYKien()
        {
            InitializeComponent();
        }

        

        private void frmYKien_Load(object sender, EventArgs e)
        {
            int sad = 0;
            int smiling = 0;
            int love =0;
            int terrible=0;
            StreamReader sr = new StreamReader(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\feedBack.txt");
            while(sr.Peek()>=0)
            {
                string s=sr.ReadLine();
                string[] arr = s.Split('%');
                if (arr[1].Equals("0"))
                {
                    arr[1] = "Không hài lòng";
                    sad++;
                }
                else if (arr[1].Equals("1"))
                {
                    arr[1] = "Hài lòng";
                    smiling++;
                }   
                else if (arr[1].Equals("2"))
                {
                    arr[1] = "Yêu thích";
                    love++;
                }
                else
                {
                    arr[1] = "Kém";
                    terrible++;
                }
                var listViewItem = new ListViewItem(arr);
                lstYKien.Items.Add(listViewItem);
            }
            lbSad.Text = sad.ToString();
            lbSmiling.Text = smiling.ToString();
            lbYeuThich.Text = love.ToString();
            lbTerrible.Text = terrible.ToString();
            sr.Close();


        }

        private void lstYKien_MouseClick(object sender, MouseEventArgs e)
        {
            string content = lstYKien.SelectedItems[0].SubItems[0].Text.ToString();
            txtNoiDung.Text = content;
        }

       

       

        
    }
}
