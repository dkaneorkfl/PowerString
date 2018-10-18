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
    public partial class TypingTestForm : Form
    {
        private MainMenuForm _ts;

        public TypingTestForm(MainMenuForm testForm)
        {
            _ts = testForm;
            InitializeComponent();
            TestTime.Start();
        }

        private void BackToSelectionSelectionBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            _ts.Visible = true;
            _ts.Location = new Point(100, 100);
            this.Visible = false;

        }

        private void TypingTestScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Application.Exit();//다른 폼이 종료하게 되면 그 메인폼도 같이 종료하게됨.
        }

        private void TestTime_Tick(object sender, EventArgs e)
        {

            this.TimeProgress.PerformStep();
            if (TimeProgress.Value == 0)
            {
                //시험 시간이 끝나면 결과를 출력시킵니다.
            }
        }
    }
}
