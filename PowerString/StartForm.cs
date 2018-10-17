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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            this.Location = new Point(100, 100);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {

            
            //selectionOfQuiz.Location = new Point(100, 100);
            /*Controls.Add(selectionOfQuiz);//유저컨트롤 추가하는부분
            Controls.Remove(selectionOfQuiz);//유저컨트롤 제거하는 부분.*/

            MainMenuForm quizSelection = new MainMenuForm();
            quizSelection.Show();//model
            quizSelection.Location = new Point(100, 100);
            this.Hide();
            
        }

       

        private void GoToNewAccountCreateBtn_Click(object sender, EventArgs e)
        {
            SignUpForm newAccountCreate = new SignUpForm(this);
            newAccountCreate.Show();//model
            newAccountCreate.Location = new Point(100, 100);
            this.Hide();
        }


        private void IdInputBox_TextChanged(object sender, EventArgs e)
        {

        }

        // 사용자명 입력 테스트 박스 힌트(Watermark)
        private void IdInputBox_Enter(object sender, EventArgs e)
        {
            if (IdInputBox.Text == "사용자명")
            {
                IdInputBox.Text = "";

                IdInputBox.ForeColor = Color.Black;
            }
        }

        // 사용자명 입력 테스트 박스 힌트(Watermark)
        private void IdInputBox_Leave(object sender, EventArgs e)
        {
            if (IdInputBox.Text == "")
            {
                IdInputBox.Text = "사용자명";

                IdInputBox.ForeColor = Color.Silver;
            }
        }

        // 비밀번호 입력 테스트 박스 힌트(Watermark)
        private void PwInputBox_Enter(object sender, EventArgs e)
        {
            if (PwInputBox.Text == "비밀번호")
            {
                PwInputBox.Text = "";

                PwInputBox.ForeColor = Color.Black;
            }
        }

        // 비밀번호 입력 테스트 박스 힌트(Watermark)
        private void PwInputBox_Leave(object sender, EventArgs e)
        {
            if (PwInputBox.Text == "")
            {
                PwInputBox.Text = "비밀번호";

                PwInputBox.ForeColor = Color.Silver;
            }
        }
    }
}
