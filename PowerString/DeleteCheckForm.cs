using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PowerString.Data;

namespace PowerString
{
    public partial class DeleteCheckForm : Form
    {
        private Tester tester;

        public DeleteCheckForm()
        {
            InitializeComponent();
            this.Location = new Point(950, 500);
        }

        public DeleteCheckForm(Tester tester)
        {
            this.tester = tester;
        }



        private void DeleteCheckOK_Click(object sender, EventArgs e)
        {
            // 계정 정보 삭제.

            DataRepository.Tester.Delete(this.tester);
        }

        private void DeleteCheckNO_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
