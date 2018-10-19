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
        private int _time;
        

        private ResultForm()
        {
            InitializeComponent();
        }

        public ResultForm(TypingTestForm typingTestform, Tester tester, int time) : this()
        {
            _typingTestForm = typingTestform;
            _tester = tester;
            _time = time/2;
        }


        // 메인메뉴로 돌아가기 버튼
        private void MoveToMainMenu_Click(object sender, EventArgs e)
        {
            MoveEvent.MoveToForm(new MainMenuForm());
            this.Close();
            _typingTestForm.CloseForm();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            String tName = _tester.TesterName;
            TextGroup.Text = $"{tName}님은";
            ClearQuote.Text = $"{_time}초 동안 코드를 작성하셨습니다.";
        }
    }
}
