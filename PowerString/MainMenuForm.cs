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
    public partial class MainMenuForm : Form
    {
        private StartForm _mt;
        private ComboBox comboBox;


        public MainMenuForm(StartForm mainForm)
        {
            _mt = mainForm;
            InitializeComponent();
        }

        
        private void BackToMainTitleBtn_Click(object sender, EventArgs e)
        {
            //MainTitle mt = new MainTitle(); //뒤로가기 버튼을 누르게 되면 최초의 화면이 나오게 됨.
            this.Visible = false;
            //mt.Visible = true;
            _mt.Visible = true;
            _mt.Location = new Point(100, 100);
            this.Visible = false;
            
        }

        private void SingleGameBtn_Click(object sender, EventArgs e)
        {
            TypingTestForm tts = new TypingTestForm(this);
            tts.Show();
            this.Hide();
        }

        private void MultiGameBtn_Click(object sender, EventArgs e)
        {
            TypingTestForm tts = new TypingTestForm(this);
            tts.Show();
            //_mt.Show();
            this.Hide();
        }

        private void UserInfoBtn_Click(object sender, EventArgs e)
        {
            UserInfoForm userInfo = new UserInfoForm();
            userInfo.Show();
        }

        private void SelectCategoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] data = {"사과", "포도", "바나나"};

            comboBox.Items.Add("item1");
            comboBox.Items.AddRange(data);

        }

        private void TestSelection_Load(object sender, EventArgs e)
        {
            
        }

        private void TestSelection_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();//다른 폼이 종료하게 되면 그 메인폼도 같이 종료하게됨.
        }
    }
}
