using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PowerString.Data;

namespace PowerString
{
    public partial class UserInfoForm : Form
    {
        private MainMenuForm _mainMenuForm;
        private Tester _tester;
        private Tester _selectedTester;

        #region 생성자
        private UserInfoForm()
        {
            InitializeComponent();
        }

        public UserInfoForm(MainMenuForm mainMenuForm, Tester tester) : this()
        {
            _mainMenuForm = mainMenuForm;
            _tester = tester;
            _selectedTester = _tester;
        }
        #endregion


        #region 이벤트 함수
        //Form Load
        public void UserInfoForm_Load(object sender, EventArgs e)
        {
            MyInfo.Text = GetUserInfoToText(_tester);
            
            MakeBigCat();

            MakeUserList();
        }


        //닫기 버튼 클릭

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //계정 삭제 버튼 클릭

        private void UserDeleteBtn_Click(object sender, EventArgs e)
        {
            MoveEvent.ShowModalForm(new DeleteConfirmForm(_mainMenuForm, this, _tester));
        }


        // 계정 삭제 버튼에 포커스가 있을 때 ESC로 UserInfoForm 닫기 동작
        private void UserDeleteBtn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                CloseBtn_Click(sender, e);
            }
        }


        //계정 리스트에서 다른 계정 선택

        private void UserListLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeSelectedTester();
        }


        // 계정 리스트에서 ESC키로 뒤로 가기 가능.

        private void UserListLB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                CloseBtn_Click(sender, e);
        }


        //대분류 선택 시

        private void SelectByBigCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var q2 = (from x in DataRepository.TestRecord.Select()
            //    select x.TestRecordDate).ToList();
            //var q4 = (from x in DataRepository.TestRecord.Select()
            //          select x.???????).ToList();

            List<string> list = new List<string>();

            switch (SelectByBigCat.SelectedItem as string)
            {
                case "날짜":
                    list = GetDateSmallCat();
                    break;

                case "내가 푼 문제":
                    list = GetCategorySmallCat();
                    break;

                case "오타율":
                    //var q3 = (from x in DataRepository.TestRecord.Select()
                    //    select x.TestRecordIsCorrect).ToList();
                    //SelectBySmallCat.DataSource = q3;
                    break;

                case "점수":
                    //SelectBySmallCat.Items.Clear();
                    //SelectBySmallCat.DataSource = q4;
                    //SelectBySmallCat.Visible = true;
                    break;

                default:
                    break;
            }

            SelectBySmallCat.DataSource = list;
        }


        //소분류 선택 시

        private void SelectBySmallCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<TestRecord> testRecords = new List<TestRecord>();

            switch (SelectByBigCat.SelectedItem as string)
            {
                case "날짜":
                    //선택한 날짜에 따라 테스터 데이터를 가져옴
                    testRecords = GetDataByDate();
                    break;


                case "내가 푼 문제":
                    //선택한 카테고리에 따라 테스터 데이터를 가져옴
                    testRecords = GetDataByCategory();
                    break;

                case "오타율":
                    //var q3 = (from x in DataRepository.TestRecord.Select()
                    //    select x.TestRecordIsCorrect).ToList();
                    //SelectBySmallCat.DataSource = q3;
                    break;

                case "점수":
                    //SelectBySmallCat.Items.Clear();
                    //SelectBySmallCat.DataSource = q4;
                    //SelectBySmallCat.Visible = true;
                    break;

                default:
                    break;
            }

            InputDataToGridView(testRecords);
        }

        #endregion


        #region 기타메소드

        //UserInfo class를 Text로 표현

        public string GetUserInfoToText(Tester tester)
        {
            string tName = tester.TesterName;
            return $"아이디: {tName}";

            //string tScore = $"{tester.TesterScore}";
            //{ Environment.NewLine} 점수: { tScore}
        }


        //UserList에 모든 Tester를 표시

        private void MakeUserList()
        {
            List<string> testers = (from x in DataRepository.Tester.Select()
                                    select x.TesterName).ToList();
            UserListLB.DataSource = testers;

            UserListLB.SelectedIndexChanged += SelectByBigCat_SelectedIndexChanged;
        }


        //대분류 종류를 combobox에 표시

        private void MakeBigCat()
        {
            string[] ItemsOfBigCat = { "날짜", "내가 푼 문제" };
            SelectByBigCat.DataSource = ItemsOfBigCat;
        }


        //기록을 보여줄 계정을 변경

        private void ChangeSelectedTester()
        {
            string selectedTesterName = UserListLB.SelectedItem.ToString();
            _selectedTester = DataRepository.Tester.Select().First(x => x.TesterName == selectedTesterName);
        }


        //날짜 대분류의 소분류 표시

        private List<string> GetDateSmallCat()
        {
            return (from x in DataRepository.TestRecord.Select()
                    where x.TesterId == _selectedTester.TesterId
                    group x by String.Format("{0:yyyy/M/d}", x.TestRecordDate) into g
                    select g.Key).ToList();
        }


        //내가 푼 문제 대분류의 소분류 표시

        private List<string> GetCategorySmallCat()
        {
            var q1 = (from x in DataRepository.TestRecord.Select()
                      where x.TesterId == _selectedTester.TesterId
                      select x.CodeId).ToList();

            var q2 = (from x in DataRepository.Code.Select()
                      where q1.Contains(x.CodeId)
                      select x.CategoryId).ToList();

            return (from x in DataRepository.Category.Select()
                    where q2.Contains(x.CategoryId)
                    select x.CategoryName).ToList();
        }

        /// <summary>
        /// 날짜 대분류에서 선택한 소분류에 따라 DB에서 데이터를 가져옴
        /// </summary>
        /// <returns> 선택한 유저의 해당 소분류에 대해 기록된 TestRecord 리스트 </returns>
        private List<TestRecord> GetDataByDate()
        {
            return (from x in DataRepository.TestRecord.Select()
                    where x.TesterId == _selectedTester.TesterId &&
                        String.Format("{0:yyyy/M/d}", x.TestRecordDate) == SelectBySmallCat.SelectedItem as string
                    select x).ToList();
        }


        /// <summary>
        /// 문제 카테고리 소분류에서 선택한 아이템에 따라 DB에서 데이터를 가져옴
        /// </summary>
        /// <returns> 선택한 유저의 해당 아이템에 대해 기록된 TestRecord 리스트 </returns>
        private List<TestRecord> GetDataByCategory()
        {
            int categoryId = (DataRepository.Category.Select()).First(x =>
                x.CategoryName == SelectBySmallCat.SelectedItem as string).CategoryId;

            var query = (from x in DataRepository.Code.Select()
                         where x.CategoryId == categoryId
                         select x.CodeId).ToList();

            return (from x in DataRepository.TestRecord.Select()
                    where x.TesterId == _selectedTester.TesterId && query.Contains(x.CodeId)
                    select x).ToList();
        }


        /// <summary>
        /// DB에서 가져온 데이터를 테이블에 표시하기 알맞은 형태로 변환 후 테이블에 대이터 표시
        /// </summary>
        /// <param name="testRecords"> DB에서 가져온 TestRecord 데이터들 </param>
        private void InputDataToGridView(List<TestRecord> testRecords)
        {
            List<TestRecordSource> list = new List<TestRecordSource>();

            foreach (TestRecord t in testRecords)
            {
                string datetime = t.TestRecordDate.ToString("t", CultureInfo.CreateSpecificCulture("en-US"));
                TestRecordSource source = new TestRecordSource(t.CodeId, datetime, t.TestRecordIsCorrect, t.TestRecordTime);
                list.Add(source);
            }

            dataView.DataSource = list;
        }

        #endregion

        
    }
}
