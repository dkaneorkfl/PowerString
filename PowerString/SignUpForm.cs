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
    public partial class SignUpForm : Form
    {
        #region 호출 목록
        private TextController _controller = new TextController();
        private Tester _newUser = new Tester();

        private bool _isDoubleChecked = false;
        private string _stringEmpty = string.Empty;

        // PW, ID 제한 수
        private int _pwOverLength = 5;
        private int _idOverLength = 31;

        // ID PW 판별용 string
        private string _idLimit = "사용자명은 30자까지";
        private string _pwLimit = "비밀번호는 4자까지";
        private string _inputPw = "비밀번호를 입력하세요";
        #endregion

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void CreateUser()
        {
                string _IdInputText = IdInputBox.Text;               //아이디,name을 저장합니다.
                string _PswInputText = PswInputBox.Text;             //비밀번호를 저장합니다.
                string PswInputAgainText = PswInputAgainBox.Text;   //재입력한 비밀번호를 저장합니다.
            
            if (_IdInputText == _idLimit && !_isDoubleChecked)
                MessageBox.Show("아이디를 입력해주세요.");

            else if (_IdInputText != _stringEmpty || !_isDoubleChecked)
                MessageBox.Show("중복확인을 눌러주세요.");

            if (_isDoubleChecked)
            {
                if (_PswInputText != PswInputAgainText)
                    MessageBox.Show("비밀번호가 틀렸습니다. 다시 입력해주세요");

                else
                {
                    //비밀번호의 글자 수가 4보다 크면 아래의 메시지박스가 실행됩니다.
                    if (_pwOverLength < _PswInputText.Length)
                        MessageBox.Show("비밀번호는 4글자 이하로 입력해주세요"); 

                    else if (_idOverLength < _IdInputText.Length)
                        MessageBox.Show("이름은 30자 이하로 입력해주세요");

                    //글자 수가 4자이하이고 비밀번호와 비밀번호확인이 같은 경우
                    else if ((_PswInputText == PswInputAgainText) && (_PswInputText.Length <= _pwOverLength) && (_idOverLength > _IdInputText.Length))
                    {
                        MessageBox.Show("가입을 축하합니다."); //가입을 축하하는 멘트를 보냅니다.
                        
                        int ScoreClear = 0; // 점수는 0점으로 초기화 시켜줍니다.

                        _newUser.TesterName = _IdInputText; // 이름을 데이터베이스에 저장합니다.
                        _newUser.TesterPassword = _PswInputText; //비밀번호를 데이터베이스에 저장합니다.

                        //TODO: Score는 Default 0 으로 지정되어 있으므로 삭제예정.
                        _newUser.TesterScore = ScoreClear; //최초의 점수 0 점을 저장합니다.
                        DataRepository.Tester.Insert(_newUser); // 이름, 비밀번호, 점수를 Tester DB에 Insert.

                        this.Close();

                        #region 민진이의 주석
                        //_mt.Visible = true;  //시작화면을 보여주게 됩니다.
                        //_mt.Location = new Point(100, 100); // 시작화면이 보여주는 위치를 지정해 줍니다
                        //this.Visible = false; //현재의 회원가입화면을 숨기게 됩니다.
                        //_CloseCheck = true; //회원가입 폼을 강제종료하게될경우 메인폼이 종료되게끔 실행하는 폼 입니다.
                        #endregion
                    }
                } 
            }
        }
        private void NewAccountCreateBtn_Click(object sender, EventArgs e)
        {
            CreateUser();
        }

        private void NewAcountBackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //아이디 중복 체크
        private void DuplicateConfirmationBtn_Click(object sender, EventArgs e)
        {
            string IdInputText = IdInputBox.Text;

            //  테이블: Tester 컬럼: TesterName   // List
            var SameName = (from x in DataRepository.Tester.Select()
                            select x.TesterName).ToList();

            if (SameName.Contains(IdInputText))
                MessageBox.Show("같은 아이디가 존재합니다.");

            else if (_idOverLength < IdInputText.Length)
                MessageBox.Show("이름은 30자 이하로 써주세요");

            else if (!SameName.Contains(IdInputText) && (_idLimit != IdInputBox.Text))
            {
                _isDoubleChecked = true;
                MessageBox.Show("사용 가능한 아이디입니다.");
            }
            else if (IdInputText == _idLimit)
                MessageBox.Show("아이디를 입력해주세요.");
        }

        //textbox의 hint를 담당하는 항목입니다.
        #region HintMessage 
        private void IdInputBox_Enter_1(object sender, EventArgs e)
        {
            _controller.ChangeTextColor(IdInputBox,_idLimit, _stringEmpty, Color.Black);
        }

        private void IdInputBox_Leave_1(object sender, EventArgs e)
        {
            _controller.ChangeTextColor(IdInputBox, _stringEmpty, _idLimit, Color.Silver);
        }

        private void PswInputBox_Enter_1(object sender, EventArgs e)
        {
            _controller.ChangeTextColor(PswInputBox, _pwLimit, _stringEmpty, Color.Black);
        }

        private void PswInputBox_Leave(object sender, EventArgs e)
        {
            _controller.ChangeTextColor(PswInputBox, _stringEmpty, _pwLimit, Color.Silver);
        }

        private void PswInputAgainBox_Enter_1(object sender, EventArgs e)
        {
            _controller.ChangeTextColor(PswInputAgainBox, _inputPw, _stringEmpty, Color.Black);
        }

        private void PswInputAgainBox_Leave_1(object sender, EventArgs e)
        {
            _controller.ChangeTextColor(PswInputAgainBox, _stringEmpty, _inputPw, Color.Silver);
        }
        #endregion

        // Esc 키를 누르면 창 닫힘.
        private void SignUpForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
