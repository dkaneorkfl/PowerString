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
    public partial class ResultForm : Form
    {
        private TypingTestForm _typingTestForm;
        private Tester _tester;
        private decimal _time;//테스트에서 받아온 시간
        private bool _perfect;//테스트에서 받아온 완전 정답 여부
        private decimal _score;//테스트에서 받아온 점수
        private string _line;//결과 텍스트를 위한 string

        private ResultForm()
        {
            InitializeComponent();
        }

        public ResultForm(TypingTestForm typingTestform, Tester tester, decimal time, bool perfect, decimal score) : this()
        {
            _typingTestForm = typingTestform;
            _tester = tester;
            _time = time;
            _perfect = perfect;
            _score = score;
        }


        // 메인메뉴로 돌아가기 버튼
        private void MoveToMainMenu_Click(object sender, EventArgs e)
        {
            MoveEvent.MoveToForm(new MainMenuForm(_tester));
            this.Close();
            _typingTestForm.CloseForm();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    private void ResultForm_Load(object sender, EventArgs e)
        {
            ResultImg.Image.Dispose();
            if (!_perfect)
            {
                ChangeLineAndImage(1);
            }
            else
            {
                if (_score < 100)
                {
                    ChangeLineAndImage(0);
                }
                else
                {
                    ChangeLineAndImage(2);
                }
            }
            String tName = _tester.TesterName;
            TextGroup.Text = $"{tName}님은";
            ResultLine.Text = $"{_time}초 동안 코드를 작성하셨습니다.{Environment.NewLine}" +
                              $"{Environment.NewLine}" +
                              $"{_score}점을 획득하셨습니다.{Environment.NewLine}" +
                              $"{Environment.NewLine}" +
                              $"{_line}";
            //엔딩 문장
        }

        private void ChangeLineAndImage(int i)
        {
            switch (i)
            {
                case 0:
                {
                    ResultImg.Image = ClearImgList.Images[0]; //거북이 사진으로 교체
                    _line = "성의있는 코딩도 좋지만 조금 더 빠르게 치시면 좋겠어요.";
                    //다 정답이지만 시간이 부족한 경우, 좀 더 노력합시다,
                    break;
                }
                case 1:
                {
                    ResultImg.Image = ClearImgList.Images[1]; //나무늘보 사진으로 교체
                    _line = "부지런하게 연습해봅시다."; //퍼펙트가 아니면 부지런히 코디합시다.
                    break;
                }
                case 2:
                {
                    ResultImg.Image = ClearImgList.Images[2]; //참 잘했어요!
                    _line = "빠르면서도 완벽한 코딩이었습니다!"; //다 정답이고 빨리 쳤습니다!
                    break;
                }
                    default:
                break;
            }
            
        }
    }
}
