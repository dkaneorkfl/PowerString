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

        // 사용자명 입력 테스트 박스 힌트(Watermark)
        private void IdInputBox_Enter(object sender, EventArgs e)
        {
            if (IdInputBox.Text == "사용자명은 30자까지")
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
                IdInputBox.Text = "사용자명은 30자까지";

                IdInputBox.ForeColor = Color.Silver;
            }
        }

        // 비밀번호 입력 테스트 박스 힌트(Watermark)
        private void PswInputBox_Enter(object sender, EventArgs e)
        {
            if (PswInputBox.Text == "비밀번호는 4자까지")
            {
                PswInputBox.Text = "";

                PswInputBox.ForeColor = Color.Black;
            }
        }

        // 비밀번호 입력 테스트 박스 힌트(Watermark)
        private void PwInputBox_Leave(object sender, EventArgs e)
        {
            if (PswInputBox.Text == "")
            {
                PswInputBox.Text = "비밀번호는 4자까지";

                PswInputBox.ForeColor = Color.Silver;
            }
        }
        private void PswInputAgainBox_Enter(object sender, EventArgs e)
        {
            if (PswInputAgainBox.Text == "비밀번호를 입력하세요")
            {
                PswInputAgainBox.Text = "";

                PswInputAgainBox.ForeColor = Color.Black;
            }
        }

        // 비밀번호 입력 테스트 박스 힌트(Watermark)
        private void PswInputAgainBox_Leave(object sender, EventArgs e)
        {
            if (PswInputAgainBox.Text == "")
            {
                PswInputAgainBox.Text = "비밀번호를 입력하세요";

                PswInputAgainBox.ForeColor = Color.Silver;
            }
        }
    }
}
