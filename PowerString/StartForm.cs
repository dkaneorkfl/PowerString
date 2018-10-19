using System;
using System.Collections.Generic;
using System.Data;
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
        #region 호출 목록
        private TextController _controller = new TextController();

        private bool _isExit = true; 
        private string _idHint = "사용자명";
        private string _pwdHint = "비밀번호";
        private string _stringEmpty = string.Empty;
        #endregion

        public StartForm()
        {
            InitializeComponent();
        }

        // 확인 버튼
        private void SignInBtn_Click(object sender, EventArgs e)
        {
            CheckSignIn();
        }

        // 새로운 사용자 등록 버튼
        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            MoveEvent.ShowModalForm(new SignUpForm());
        }

        #region Hint Message
        // 커서가 있는 경우 ID 입력 힌트(Watermark) 사라짐
        private void IdInputBox_Enter(object sender, EventArgs e)
        {
          _controller.ChangeTextColor(IdInputBox, _idHint, _stringEmpty,Color.Black);
        }

        // 커서 사라지면 ID 입력 힌트(Watermark) 표시
        private void IdInputBox_Leave(object sender, EventArgs e)
        {
            _controller.ChangeTextColor(IdInputBox, _stringEmpty, _idHint, Color.Silver);
        }

        // 커서가 있는 경우 비밀번호 입력 힌트(Watermark) 사라짐
        private void PwInputBox_Enter(object sender, EventArgs e)
        {
            _controller.ChangeTextColor(PwInputBox, _pwdHint, _stringEmpty, Color.Black);
        }

        // 커서가 사라지면 비밀번호 입력 힌트(Watermark) 표시
        private void PwInputBox_Leave(object sender, EventArgs e)
        {
            _controller.ChangeTextColor(PwInputBox, _stringEmpty, _pwdHint, Color.Silver);
        }
        #endregion

        // 로그인창에서 입력받은 아이디 패스워드 확인
        public void CheckSignIn()
        {
            string userName = IdInputBox.Text;
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

            // bool 이름과 비밀번호가 비어있는지 판단
            bool isNameOrPwEmpty = userName == _stringEmpty || userPw == _stringEmpty;
            bool isNameOrPwHintText = userName == _idHint || userPw == _pwdHint;

            //  3. ID나 PW : 일치하지 않는 경우 에러메시지
            if (isNameOrPwHintText || isNameOrPwEmpty)
                MessageBox.Show("아이디 또는 비밀번호를 입력해주세요.");

            //  4. ID가 없으면 가입 문구
            else if (!nameList.Contains(userName) || !pwList.Contains(userPw))
                MessageBox.Show("아이디가 없거나 비밀번호가 일치하지 않습니다. \n계정 생성 후 이용해주세요.");

            //  5. ID와 PW 일치하면 로그인 후 메인메뉴Form 이동
            if (nameList.Contains(userName) && pwList.Contains(userPw))
            {
                Tester tester = DataRepository.Tester.SelectByName(userName);

                MoveEvent.MoveToForm(new MainMenuForm(tester));

                CloseForm();
            }
        }
        //private List<string> 

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

        // Enter 단축키 설정
        private void PwInputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SignInBtn_Click(sender, e);
        }

        // 비밀번호 * 표시
        private void PwInputBox_TextChanged(object sender, EventArgs e)
        {
            _controller.TextPwChar(PwInputBox);
        }

    }
}
