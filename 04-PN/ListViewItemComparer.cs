using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
namespace _04_PN
{
    public class ListViewItemComparer : IComparer
    {

        private int column;
        private bool numeric = false;

        public int Column
        {

            get { return column; }
            set { column = value; }
        }

        public bool Numeric
        {

            get { return numeric; }
            set { numeric = value; }
        }

        public ListViewItemComparer(int columnIndex)
        {

            Column = columnIndex;
        }

        public int Compare(object x, object y)
        {

            ListViewItem listX = (ListViewItem)x;
            ListViewItem listY = (ListViewItem)y;
            // Chuyển text thành số trước khi so sánh.
            // Nếu chuyển đổi thất bại, sử dụng giá trị 0.
            return Int32.Parse(listY.SubItems[Column].Text)-Int32.Parse(listX.SubItems[Column].Text);
            
        }
    }
}
