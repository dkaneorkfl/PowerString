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
    public enum TestMode
    {
        None,
        Single,
        Multi,
    }

    public partial class MainMenuForm : Form
    {
        private Tester _tester;
        private bool _isExit = true;


        private MainMenuForm()
        {
            InitializeComponent();
        }

        public MainMenuForm(Tester tester) : this()
        {
            _tester = tester;
        }


        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            var query = (from x in DataRepository.Category.Select()
                select x.CategoryName).ToList();
            
            cbxCategorySelect.DataSource = query;
        }


        private void cbxCategorySelect_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedCat = cbxCategorySelect.SelectedItem as string;

            CategoryInfo cat = GetCategoryInfo();

            if (cat is null)
                return;

            lblExampleCount.Text = cat.ExampleCount.ToString();
        }
        

        private void BackToMainTitleBtn_Click(object sender, EventArgs e)
        {
            //Start Form으로 이동
            MoveEvent.MoveToForm(new StartForm());
            CloseForm();
        }
        

        
        private void SingleGameBtn_Click(object sender, EventArgs e)
        {
            CategoryInfo categoryInfo = GetCategoryInfo();

            //MessageBox.Show(categoryInfo.ExampleCount.ToString());

            if (categoryInfo is null)
                return;

            //싱글버전 테스트 Form으로 이동
            MoveEvent.MoveToForm(new TypingTestForm(_tester, TestMode.Single, categoryInfo));
            CloseForm();
        }

        private void MultiGameBtn_Click(object sender, EventArgs e)
        {
            CategoryInfo categoryInfo = GetCategoryInfo();

            //MessageBox.Show(categoryInfo.ExampleCount.ToString());

            if (categoryInfo is null)
                return;

            //멀티버전 테스트 Form으로 이동
            MoveEvent.MoveToForm(new TypingTestForm(_tester, TestMode.Multi, categoryInfo));
            CloseForm();
        }

        
        private void UserInfoBtn_Click(object sender, EventArgs e)
        {
            MoveEvent.ShowModalForm(new UserInfoForm(this, _tester));
        }

        
        //x 버튼을 누르거나 다른 Form으로 이동 시 발생하는 이벤트 함수
        private void TestSelection_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(_isExit)
                Application.Exit();
        }


        private CategoryInfo GetCategoryInfo()
        {
            string selectedCat = cbxCategorySelect.SelectedItem as string;

            if (selectedCat is null)
            {
                MessageBox.Show("잘못된 선택입니다.");
                return null;
            }

            var query = from x in DataRepository.Code.Select()
                        group x by x.CategoryId
                            into g
                        select new CategoryInfo()
                        {
                            CategoryId = g.Key,
                            CategoryName = (DataRepository.Category.SelectById(g.Key).CategoryName),
                            ExampleCount = g.Count(),
                        };

            var cat = query.First(x => x.CategoryName.Equals(selectedCat));
            return cat;
        }

        public void CloseForm()
        {
            _isExit = false;
            this.Close();
        }
    }
}
