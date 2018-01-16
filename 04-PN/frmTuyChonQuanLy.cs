using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_PN
{
    public partial class frmTuyChonQuanLy : Form
    {

        Image edit = _04_PN.Properties.Resources.edit;
        Image ranking = _04_PN.Properties.Resources.ranking;
        Image feedBack = _04_PN.Properties.Resources.feedback;
        public frmTuyChonQuanLy()
        {
            InitializeComponent();
            picEdit.Image = edit;
            pictureBox2.Image = ranking;
            picFeedback.Image = feedBack;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmQuanLyGiai frmqlg = new frmQuanLyGiai();
            if (frmqlg.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            int editWidth = edit.Width + ((edit.Width * 30) / 100);
            int editHeight = edit.Height + ((edit.Height * 30) / 100);

            Bitmap edit_1 = new Bitmap(editWidth, editHeight);
            Graphics graphic = Graphics.FromImage(edit_1);
            graphic.DrawImage(edit, new Rectangle(Point.Empty, edit_1.Size));
            picEdit.Image = edit_1;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            picEdit.Image = edit;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmSuaBXH frmEdit = new frmSuaBXH();
            if (frmEdit.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            int rankingWidth = ranking.Width + ((edit.Width * 30) / 100);
            int rankingHeight = ranking.Height + ((edit.Height * 30) / 100);

            Bitmap ranking_1 = new Bitmap(rankingWidth, rankingHeight);
            Graphics graphic = Graphics.FromImage(ranking_1);
            graphic.DrawImage(ranking, new Rectangle(Point.Empty, ranking_1.Size));
            pictureBox2.Image = ranking_1;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = ranking;
        }

        private void picFeedback_Click(object sender, EventArgs e)
        {
            frmYKien frm = new frmYKien();
            if (frm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void picFeedback_MouseHover(object sender, EventArgs e)
        {
            int feedBackWidth = feedBack.Width + ((feedBack.Width * 30) / 100);
            int feedBackHeight = feedBack.Height + ((feedBack.Height * 30) / 100);

            Bitmap feedBack_1 = new Bitmap(feedBackWidth, feedBackHeight);
            Graphics graphic = Graphics.FromImage(feedBack_1);
            graphic.DrawImage(feedBack, new Rectangle(Point.Empty, feedBack_1.Size));
            picFeedback.Image = feedBack_1;
            
        }

        private void picFeedback_MouseLeave(object sender, EventArgs e)
        {
            picFeedback.Image = feedBack;
        }

       
    }
}
