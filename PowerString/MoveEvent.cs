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
        public static void MoveToForm(Form form)
        {
            Form f = MakeNewForm(form);
            f.Show();
        }

        public static void ShowModalForm(Form form)
        {
            Form f = MakeNewForm(form);
            f.ShowDialog();
        }

        private static Form MakeNewForm(Form form)
        {
            Form f = form;
            f.StartPosition = FormStartPosition.Manual;
            f.Location = new Point(100, 100);
            return f;
        }
    }
}
