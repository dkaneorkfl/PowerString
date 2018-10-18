using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PowerString.Data;

namespace PowerString
{
    public partial class SignUpForm : Form
    {
        private Tester _newUser = new Tester();
        private bool _CloseCheck = false;
        private StartForm _mt;

        void CreateUser()
        {
            string IdInputText = IdInputBox.Text; //아이디,name을 저장하는 부분입니다.
            string PswInputText = PswInputBox.Text; //비밀번호를 저장하는 부분입니다.
            string PswInputAgainText = PswInputAgainBox.Text; //비밀번호가 앞의 번호와 맞는지 확인하는 부분입니다.
            if (PswInputText != PswInputAgainText) //입력햇던 번호와 다시 입력햇던 번호가 같은지 다른지 확인합니다. 
            {
                //비밀번호가 다르다면 아래의 멘트가 나오게 됩니다.
                MessageBox.Show("비밀번호가 틀렷습니다. 다시 입력해주세요");
            }
            else
            {
                if (4 < PswInputText.Length)//비밀번호가 4자보다 크다면 아래의 메시지박스가 실행됩니다.
                {
                    MessageBox.Show("글자수는 4개 이하로 해주세요");
                }
                //글자수가 4자이하이고 비밀번호와 비밀번호확인이 같다면 아래의 코드가 실행됩니다.
                else if ((PswInputText == PswInputAgainText) && (PswInputText.Length <= 4))
                {
                    MessageBox.Show("가입을 축하합니다."); //가입을 축하하는 멘트를 보냅니다.
                    _mt.Visible = true;  //시작화면을 보여주게 됩니다.
                    _mt.Location = new Point(100, 100); // 시작화면이 보여주는 위치를 지정해 줍니다
                    this.Visible = false; //현재의 회원가입화면을 숨기게 됩니다.
                    _CloseCheck = true; //회원가입 폼을 강제종료하게될경우 메인폼이 종료되게끔 실행하는 폼 입니다.

                    int ScoreClear = 0; // 점수는 0점으로 초기화 시켜줍니다.
                    _newUser.TesterName = IdInputText; // name 을 데이터베이스에 저장하는 코드입니다.
                    _newUser.TesterPassword = PswInputText; //비밀번호를 데이터베이스에 저장하는 코드입니다.
                    _newUser.TesterScore = ScoreClear; //최초의 점수 0 점을 저장하는 코드입니다.
                    DataRepository.Tester.Insert(_newUser); // 이름과 비밀번호 점수를 저장하도록 실행시켜주는 코드입니다.
                }

            }
        }

        public SignUpForm(StartForm mainForm)
        {
            _mt = mainForm;
            InitializeComponent();
            this.Location = new Point(100, 100);
        }

        private void NewAccountCreateBtn_Click(object sender, EventArgs e)
        {
            CreateUser(); // 버튼을 누르게 되면 해당 메소드를 실행하게 됩니다.
        }


        private void IdInputBox_TextChanged(object sender, EventArgs e)
        {

        }

        //textbox의 hint를 담당하는 항목입니다.
        #region HintMessage 
        private void IdInputBox_Enter_1(object sender, EventArgs e)
        {
            if (IdInputBox.Text == "사용자명은 30자까지")
            {
                IdInputBox.Text = "";

                IdInputBox.ForeColor = Color.Black;
            }
        }

        private void IdInputBox_Leave_1(object sender, EventArgs e)
        {
            if (IdInputBox.Text == "")
            {
                IdInputBox.Text = "사용자명은 30자까지";

                IdInputBox.ForeColor = Color.Silver;
            }
        }

        private void PswInputBox_Enter_1(object sender, EventArgs e)
        {
            if (PswInputBox.Text == "비밀번호는 4자까지")
            {
                PswInputBox.Text = "";

                PswInputBox.ForeColor = Color.Black;
            }
        }

        private void PswInputBox_Leave(object sender, EventArgs e)
        {
            if (PswInputBox.Text == "")
            {
                PswInputBox.Text = "비밀번호는 4자까지";

                PswInputBox.ForeColor = Color.Silver;
            }
        }

        private void PswInputAgainBox_Enter_1(object sender, EventArgs e)
        {
            if (PswInputAgainBox.Text == "비밀번호를 입력하세요")
            {
                PswInputAgainBox.Text = "";

                PswInputAgainBox.ForeColor = Color.Black;
            }
        }

        private void PswInputAgainBox_Leave_1(object sender, EventArgs e)
        {
            if (PswInputAgainBox.Text == "")
            {
                PswInputAgainBox.Text = "비밀번호를 입력하세요";

                PswInputAgainBox.ForeColor = Color.Silver;
            }
        }

        private void PswInputBox_TextChanged(object sender, EventArgs e)
        {
            PswInputBox.PasswordChar = '*';
        }

        private void PswInputAgainBox_TextChanged(object sender, EventArgs e)
        {
            PswInputAgainBox.PasswordChar = '*';
        }

        private void SignUpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _CloseCheck = false;
            Application.Exit();
        }
        #endregion 
    }
}
