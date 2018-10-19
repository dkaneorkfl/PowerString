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
    public partial class DeleteCheckForm : Form
    {
        public DeleteCheckForm()
        {
            InitializeComponent();
        }

        private void DeleteOK_Click(object sender, EventArgs e)
        {

        }

        private void DeleteNO_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteNO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) ;
        }
    }
}
