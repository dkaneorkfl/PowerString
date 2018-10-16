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
    public partial class QuizSelection : Form
    {
        private MainTitle _mt;

        public SelectionOfQuiz(MainTitle mainForm)
        public QuizSelection()
        {
            _mt = mainForm;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            _mt.Close();
        }

        private void MainTitleReturnButton_Click(object sender, EventArgs e)
        {
            //MainTitle mt = new MainTitle(); //뒤로가기 버튼을 누르게 되면 최초의 화면이 나오게 됨.
            /*this.Visible = false;
            mt.Visible = true;*/
            _mt.Visible = true;
            _mt.Location = new Point(100, 100);
            this.Visible = false;
            MainTitle mt = new MainTitle(); //뒤로가기 버튼을 누르게 되면 최초의 화면이 나오게 됨.
            mt.Show();
        }

        private void SingleGameButton_Click(object sender, EventArgs e)
        {
            GamePlayScreen psg = new GamePlayScreen();
            psg.Show();
            mt.Show();
            this.Hide();
        }

       


        private void MultiGameButton_Click(object sender, EventArgs e)
        {

        }
    }
}
