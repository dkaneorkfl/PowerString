using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerString
{
    public partial class SignUpForm : Form
    {
        private StartForm _mt;

        public SignUpForm(StartForm mainForm)
        {
            _mt = mainForm;
            InitializeComponent();
            this.Location = new Point(100, 100);
        }

        private void NewAccountCreateBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            _mt.Visible = true;
            _mt.Location = new Point(100, 100);
            this.Visible = false;
        }
    }
}
