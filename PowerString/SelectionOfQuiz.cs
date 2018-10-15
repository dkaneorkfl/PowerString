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
    public partial class SelectionOfQuiz : Form
    {
        public SelectionOfQuiz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainTitleReturnButton_Click(object sender, EventArgs e)
        {
            MainTitle mt = new MainTitle(); //뒤로가기 버튼을 누르게 되면 최초의 화면이 나오게 됨.
            mt.Show();
            this.Hide();
        }

        private void MultiGameButton_Click(object sender, EventArgs e)
        {

        }
    }
}
