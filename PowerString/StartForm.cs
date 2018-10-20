using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PowerString.Data;

namespace PowerString
{
    public partial class StartForm : Form
    {
        private bool _isExit = true; 
        private string _idHint = "사용자명";
        private string _pwdHint = "비밀번호";

        public StartForm()
        {
            InitializeComponent();
        }

        // 확인 버튼
        private void SignInBtn_Click(object sender, EventArgs e)
        {
            #region etc
            //selectionOfQuiz.Location = new Point(100, 100);
            /*Controls.Add(selectionOfQuiz);//유저컨트롤 추가하는부분
            Controls.Remove(selectionOfQuiz);//유저컨트롤 제거하는 부분.*/
            #endregion

            CheckSignIn();
        }

        // 새로운 사용자 등록 버튼
        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            MoveEvent.ShowModalForm(new SignUpForm());
        }

        // 커서가 있는 경우 ID 입력 힌트(Watermark) 사라짐
        private void IdInputBox_Enter(object sender, EventArgs e)
        {
            if (IdInputBox.Text == _idHint)
            {
                IdInputBox.ForeColor = Color.Black;
                IdInputBox.Text = string.Empty;
            }
        }

        // 커서 사라지면 ID 입력 힌트(Watermark) 표시
        private void IdInputBox_Leave(object sender, EventArgs e)
        {
            if (IdInputBox.Text == string.Empty)
            {
                IdInputBox.Text = _idHint;
                IdInputBox.ForeColor = Color.Silver;
            }
        }

        // 커서가 있는 경우 비밀번호 입력 힌트(Watermark) 사라짐
        private void PwInputBox_Enter(object sender, EventArgs e)
        {
            if (PwInputBox.Text == _pwdHint)
            {
                PwInputBox.Text = string.Empty;
                PwInputBox.ForeColor = Color.Black;
            }
        }

        // 커서가 사라지면 비밀번호 입력 힌트(Watermark) 표시
        private void PwInputBox_Leave(object sender, EventArgs e)
        {
            if (PwInputBox.Text == string.Empty)
            {
                PwInputBox.Text = _pwdHint;
                PwInputBox.ForeColor = Color.Silver;
            }
        }

        // 로그인창에서 입력받은 아이디 패스워드 확인
        public void CheckSignIn()
        {
            string userName = IdInputBox.Text;      // IdInputBox에서 Text를 가져와서 userName에 넣어라.
            string userPw = PwInputBox.Text;

            #region First, OrDefault
            //  데이터베이스의 Tester정보와 일치하는지 확인한다.
            //var t = DataRepository.Tester.Select().FirstOrDefault(x => x.TesterName.Equals(IdInputBox.Text));
            //var testerSelectPW = DataRepository.Tester.Select().First(x => x.TesterPassword.Equals(PwInputBox.Text));
            //string userSelectName = DataRepository.Tester.Select().First(x => x.TesterName.Equals(IdInputBox.Text)).TesterName;   // First를 사용할 경우 값이 없으면 에러 발생
            #endregion

            // Tester 테이블의 Name 리스트
            List<string> nameList = (from x in DataRepository.Tester.Select()
                                        select x.TesterName).ToList();  
            // Tester 테이블의 Password 리스트
            List<string> pwList = (from x in DataRepository.Tester.Select()
                                    select x.TesterPassword).ToList();  

            //  3. ID나 PW : 일치하지 않는 경우 에러메시지
            if (userName == string.Empty && userPw == string.Empty)
                MessageBox.Show("아이디와 비밀번호를 입력해주세요.");
            else if((userName == _idHint && userPw == _pwdHint)
                || (userName == string.Empty && userPw == string.Empty))
                MessageBox.Show("아이디 또는 비밀번호를 입력해주세요.");

            // 아래 코드는 차후 SignUpForm 코드와 병합예정 // 현재는 메시지박스만 나타냄.
            //  4. ID 없으면 가입하라고 새로운 계정등록 화면으로 넘겨줌. 
            else if (!nameList.Contains(userName) || !pwList.Contains(userPw))
                MessageBox.Show("아이디가 없거나 비밀번호가 일치하지 않습니다.");
            

            //  5. ID와 PW 일치하면 로그인 후 메인메뉴Form 이동
            if (nameList.Contains(userName) && pwList.Contains(userPw))
            {
                Tester tester = DataRepository.Tester.SelectByName(userName);
                MoveEvent.MoveToForm(new MainMenuForm(tester));
                CloseForm();
            }
             
        }

        private void StartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(_isExit)
                Application.Exit();
        }

        public void CloseForm()
        {
            _isExit = false;
            this.Close();
        }

        private void PwInputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SignInBtn_Click(sender, e);
        }
    }
}
