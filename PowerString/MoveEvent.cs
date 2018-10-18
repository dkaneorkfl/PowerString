using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerString
{
    public class MoveEvent
    {
        public static void MoveToOtherForm(Form form)
        {
            Form f = form;
            f.Location = new Point(100, 100);
            f.Show();
        }
    }
}
