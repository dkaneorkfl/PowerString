using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerString.Data
{
    public partial class BackForm : Form
    {
        public BackForm()
        {
            InitializeComponent();
        }

        private void BackForm_Load(object sender, EventArgs e)
        {
            BackForm bf = new BackForm();
            bf.Show();
        }

        private void BackForm_Shown(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
