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
    public partial class MainTitle : Form
    {
        public MainTitle()
        {
            InitializeComponent();
                this.Location = new Point(100, 100);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void PracticeProblem_Click(object sender, EventArgs e)
        {

            
            //selectionOfQuiz.Location = new Point(100, 100);
            /*Controls.Add(selectionOfQuiz);//유저컨트롤 추가하는부분
            Controls.Remove(selectionOfQuiz);//유저컨트롤 제거하는 부분.*/

            QuizSelection quizSelection = new QuizSelection(this); //버튼을 클릭하면 3번화면이 나오게됨.
            quizSelection.Show();//model
            quizSelection.Location = new Point(100, 100);
            this.Hide();
            
        }

       

        private void Signbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
