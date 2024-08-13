using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asm2juan
{
    internal class Sort
    {
        public class ListViewItemComparer : IComparer<ListViewItem>
        {
            private int column;
            private bool ascending;

            public ListViewItemComparer(int column, bool ascending)
            {
                this.column = column;
                this.ascending = ascending;
            }

            public int Compare(ListViewItem x, ListViewItem y)
            {
                int result = String.Compare(x.SubItems[column].Text, y.SubItems[column].Text);
                if (!ascending)
                {
                    result = -result;
                }
                return result;
            }
        }

    }
}
