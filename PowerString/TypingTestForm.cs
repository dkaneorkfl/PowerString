using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using PowerString.Data;

namespace PowerString
{
    public enum TestResult
    {
        Success,
        Fail
    }

    public partial class TypingTestForm : Form
    {
        //private const int MAX_TIME = 2 * 60;
        private const int MAX_TIME = 120;
        private int count = 0;
        private decimal timeLeft = 0;//남은 시간 계산을 위한 decimal
        private decimal timeSum = 0;//시간 총합을 위한 decimal. Result에서 진행시간을 표기하기 위해 사용.
        private int correctCount = 0;//정답 갯수를 측정하기 위한 int
        private bool perfect = true;//모두 정답이면 true
        private decimal score = 0;//점수값. 현재는 progressbar의 value값을 그대로 누적시켜 사용함.
        private int exampleCountByMod = 3;//모드에 따른 문제 갯수. 멀티 기준으로 기본 3개.

        private Tester _tester;
        private TestMode _testMode = TestMode.None;
        private CategoryInfo _categoryInfo;

        private bool _isExit = true;
        private bool _isStop = false;
        private int _idx = 0;
        private List<string> _exampleList;
        
        private TypingTestForm()
        {
            InitializeComponent();
        }

        public TypingTestForm(Tester tester, TestMode testMode, CategoryInfo categoryInfo) : this()
        {
            _tester = tester;
            _testMode = testMode;
            _categoryInfo = categoryInfo;
        }


        private void TypingTestForm_Load(object sender, EventArgs e)
        {
            //Timer
            pgbTimer.Maximum = MAX_TIME;
            pgbTimer.Value = MAX_TIME;

            //싱글모드일 경우 처리
            if (_testMode == TestMode.Single || _categoryInfo.ExampleCount == 1)
            {
                btnSkip.Enabled = false;
                btnResult.Click += new EventHandler(GoToResultEvent);
                exampleCountByMod= 1;//싱글모드면 1개
            }

            //SelectExample
            _exampleList = (from x in DataRepository.Code.Select()
                                       where x.CategoryId == _categoryInfo.CategoryId
                                       select x.CodeExample).ToList();
            _exampleList = _exampleList.OrderBy(x => Guid.NewGuid()).ToList();

            tbxTestExample.Text = _exampleList[_idx++];
        }

        
        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            //메인메뉴로 이동
            MoveEvent.MoveToForm(new MainMenuForm(_tester));
            _isExit = false;
            this.Close();
        }


        private void btnSkip_Click(object sender, EventArgs e)
        {

            GoToNextExample();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            string exampleCode = tbxTestExample.Text;
            string answer = tbxUserInput.Text;

            
            if (exampleCode.Equals(answer))
            {
                _isStop = true;
                InsertTestRecord(TestResult.Success);
                MessageBox.Show("정답!");
                correctCount++;//정답 값 증가.
                score = score + pgbTimer.Value;
                _isStop = false;
            }
            else
            {
                _isStop = true;
                //InsertTestRecord(TestResult.Fail);
                MessageBox.Show("오답..ㅠㅠ");
                //정답값, 점수 증가가 없음.
                _isStop = false;
            }
            
            GoToNextExample();
           
        }

        private void InsertTestRecord(TestResult testResult)
        {
            TestRecord testRecord = new TestRecord();
            //testRecord.TestRecordId = 1;
            testRecord.TesterId = _tester.TesterId;
            Code curCode = DataRepository.Code.Select().First(x => x.CodeExample == tbxTestExample.Text);
            testRecord.CodeId = curCode.CodeId;
            testRecord.TestRecordDate = DateTime.Now;

            if (testResult == TestResult.Success)
            {
                testRecord.TestRecordIsCorrect = true;
                timeLeft = (decimal)(pgbTimer.Maximum - pgbTimer.Value) / 2;
                timeSum += timeLeft;

                _tester.TesterScore += (int?)score;
                DataRepository.Tester.Update(_tester);
            }
            else
            {
                testRecord.TestRecordIsCorrect = false;
            }

            DataRepository.TestRecord.Insert(testRecord);
        }


        private void GoToNextExample()
        {
            //timeSum = timeSum + (pgbTimer.Maximum - pgbTimer.Value);
            pgbTimer.Value = pgbTimer.Maximum;
            _isStop = false;
            tbxUserInput.Text = "";
            if (_idx != _exampleList.Count)
                tbxTestExample.Text = _exampleList[_idx++];

            if (_idx == _exampleList.Count)
            {
                btnSkip.Text = "결과 보러가기";
            }
        }

        private void btnSkip_TextChanged(object sender, EventArgs e)
        {
            btnSkip.Click -= new EventHandler(btnSkip_Click);
            btnSkip.Click += new EventHandler(GoToResultEvent);
            //btnResult.Click -= new EventHandler(btnResult_Click);
            btnResult.Click += new EventHandler(GoToResultEvent);
        }


        private void GoToResultEvent(object sender, EventArgs e)
        {
            _isStop = true;
            if (correctCount / exampleCountByMod != 1)//정답갯수/문제갯수가 1이 아니면
                perfect = false;//퍼펙트가 아니다.
            //결과제공창으로 감
            MoveEvent.ShowModalForm(new ResultForm(this, _tester, timeSum, perfect, score));
        }
        

        private void TypingTestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(_isExit)
                Application.Exit();//다른 폼이 종료하게 되면 그 메인폼도 같이 종료하게됨.
        }

        public void CloseForm()
        {
            _isExit = false;
            this.Close();
        }

        //500ms마다 한 번 Tick이 발생
        //타이머 측정을 같은 스레드에서 하면서 delay가 발생하므로 interval 간격 조정
        private void timer_Tick(object sender, EventArgs e)
        {
            if (!_isStop)
            {
                pgbTimer.Value -= 1;
                count++;
                lbl.Text = count.ToString();

                if (pgbTimer.Value == 0)
                {
                    _isStop = true;

                    //실패 판정
                    //InsertTestRecord(TestResult.Fail);
                    MessageBox.Show("시간초과입니다ㅠㅠ");
                    GoToNextExample();
                }
            }
            //클립보드 금지
        }
    }
}
