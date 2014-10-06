using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class ArgumentedListViewItem : ListViewItem
    {

        public int Index { get; private set; }

        public ArgumentedListViewItem()
            : base()
        {
            
        }

        public void SetIndex(int index)
        {
            this.Index = index;
        }

    }
}
