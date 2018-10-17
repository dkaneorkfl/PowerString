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
        private Tester newUser = new Tester();
        private bool CloseCheck = false;

        void CreateUser()
        {
            string IdInputText = IdInputBox.Text;
            string PswInputText = PswInputBox.Text;
            string PswInputAgainText = PswInputAgainBox.Text;

            if (PswInputText != PswInputAgainText)
            {
                MessageBox.Show("비밀번호가 틀렷습니다. 다시 입력해주세요");
            }
            else
            {
                MessageBox.Show("가입을 축하합니다.");
                this.Visible = false;
                _mt.Visible = true;
                _mt.Location = new Point(100, 100);
                this.Visible = false;
                CloseCheck = true;
                newUser.TesterName = IdInputText;
                newUser.TesterPassword = PswInputText;
                DataRepository.Tester.Insert(newUser);
            }
        }
        private StartForm _mt;

        public SignUpForm(StartForm mainForm)
        {
            _mt = mainForm;
            InitializeComponent();
            this.Location = new Point(100, 100);
        }

        private void NewAccountCreateBtn_Click(object sender, EventArgs e)
        {
            CreateUser();
            //Insert();

            string IdInputText = IdInputBox.Text;
            //context.Testers.Add(IdInputText);

        }


        private void IdInputBox_TextChanged(object sender, EventArgs e)
        {

        }

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
            CloseCheck = false;
            Application.Exit();
        }
        #endregion
    }
}
