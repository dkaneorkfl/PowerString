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
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }

        //ResultGroup의 Text값은 (사용자+님은 )란 값을 가진 스트링이 되야 합니다.
        //TypingTestForm에 있는 프로그레스 바의 MaxValue에서 TypingTestForm에서 가져온 Value값을 뺀 값을 100으로 나눈 값을 초, 나머지를 소수초로 환산해줘야 합니다. 이를 decimal TestTime이라고 합니다.
        //TimeLabel의 Text값은 (TestTime+동안 코드를 작성하셨습니다 )란 값을 가진 스트링이 되야 합니다.
        //일정한 기준을 가지고 ClearImg를 변경합니다. 참 잘했어요는 welldone.jpg, 좀 더 열심히는 more.jpg를 사용합니다.


        private void ScoreLabel_Click(object sender, EventArgs e)
        {

        }

        private void IncorrectPercentLabel_Click(object sender, EventArgs e)
        {

        }

        private void MoveToMainMenu_Click(object sender, EventArgs e)
        {
            MainMenuForm mmf = new MainMenuForm();
            TypingTestForm tts = new TypingTestForm();

            mmf.Visible = true;
            tts.Visible = false;
            this.Visible = false;
        }
    }
}
