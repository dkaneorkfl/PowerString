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
    public partial class UserInfoForm : Form
    {
        Tester _tester;
        
        public UserInfoForm()
        {
            InitializeComponent();
        }
        //아이디: System.Linq.Enumerable+WhereSelectEnumerableIterator`2[System.Char,System.String] 
        //점수: System.Linq.Enumerable+WhereSelectEnumerableIterator`2[System.Char, System.String]
        
        public string UserInfos(Tester tester)
        {
            //            var u1 = (from x in tester.TesterName select x).ToString();
            //
            //            string userScore = tester.TesterScore.ToString();
            //            var u2 = (from x in userScore select x).ToString();
            
            string tName = tester.TesterName;
            string tScore =  $"{tester.TesterScore}";
            
                return $"아이디: {tName} {Environment.NewLine}점수: {tScore}";
        }

        public void UserInfoForm_Load(object sender, EventArgs e)
        {
            string[] ItemsOfBigCat = {  "날짜", "오타율", "점수", "걸린시간" };
            SelectByBigCat.DataSource = ItemsOfBigCat;


            // 로그인한 아이디와 테스터의 이름을 비교해서 정보 출력해야함
            _tester = DataRepository.Tester.SelectById(14);
            MyInfo.Text = UserInfos(_tester);

            var q1 = (from x in DataRepository.Tester.Select()
                //    where x.TesterName == name
                select x.TesterName).ToList();
                UserListLB.DataSource = q1;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            UserInfoForm userInfo = new UserInfoForm();
            userInfo.Close();
            Close();
        }

        private void SelectByBigCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            var q2 = (from x in DataRepository.TestRecord.Select()
                select x.TestRecordDate).ToList();

            var q3 = (from x in DataRepository.TestRecord.Select()
                select x.TestRecordIsCorrect).ToList();

//            var q4 = (from x in DataRepository.TestRecord.Select()
//                select x.???????).ToList();

            var q5 = (from x in DataRepository.TestRecord.Select()
                select x.TestRecordTime).ToList();
            var q3435 = (from x in DataRepository.TestRecord.Select()
                         where x.TesterId == 2
                         group x by String.Format("{0:yyyy/M/d}", x.TestRecordDate) into g
                select g.Key).ToList();
            

            switch (SelectByBigCat.SelectedItem as string)
            {

                case "날짜":
//                    SelectBySmallCat.Items.Clear();
                    SelectBySmallCat.DataSource = q3435;
                    //SelectBySmallCat.Items.Add(q2);
                    SelectBySmallCat.Visible = true;
                    break;

                case "오타율":
//                    SelectBySmallCat.Items.Clear();
                    SelectBySmallCat.DataSource = q3;
                    SelectBySmallCat.Visible = true;
                    break;

//                case "점수":
//                    //SelectBySmallCat.Items.Clear();
//                    SelectBySmallCat.DataSource = q4;
//                    SelectBySmallCat.Visible = true;
//                    break;

                case "걸린 시간":
                    //SelectBySmallCat.Items.Clear();
                    SelectBySmallCat.DataSource = q5;
                    SelectBySmallCat.Visible = true;
                    break;

               default:
                    break;
            }
        }

        private void UserDeleteBtn_Click(object sender, EventArgs e)
        {
            // 내 계정 삭제 버튼 클릭시 발생할 이벤트
            //MoveEvent.MoveToForm(new DeleteCheckForm());
            //DataRepository.Tester.Delete(tester);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
