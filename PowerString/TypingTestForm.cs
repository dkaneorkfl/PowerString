﻿using System;
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
    public partial class TypingTestForm : Form
    {
        private const int MAX_TIME = 2 * 60;
        private int count = 0;

        private bool _isExit = true;
        private TestMode _testMode = TestMode.None;
        private CategoryInfo _categoryInfo;
        private int _idx = 0;
        private List<string> _exampleList;

        private TypingTestForm()
        {
            InitializeComponent();
        }

        public TypingTestForm(TestMode testMode, CategoryInfo categoryInfo) : this()
        {
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
            MoveEvent.MoveToForm(new MainMenuForm(new Tester()));
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


            TestRecord testRecord = new TestRecord();
            //testRecord.TestRecordId = 1;
            testRecord.TesterId = 1;
            testRecord.CodeId = 0;
            testRecord.TestRecordDate = DateTime.Now;

            if (exampleCode.Equals(answer))
            {
                testRecord.TestRecordIsCorrect = true;
                testRecord.TestRecordTime = (decimal)(pgbTimer.Maximum - pgbTimer.Value) / 2;
                MessageBox.Show(testRecord.TestRecordTime.ToString());
                //MessageBox.Show("정답!");
            }
            else
            {
                testRecord.TestRecordIsCorrect = false;
                MessageBox.Show("오답..ㅠㅠ");
            }

            //DataRepository.TestRecord.Insert(testRecord);
            


            GoToNextExample();
        }


        private void GoToNextExample()
        {
            pgbTimer.Value = pgbTimer.Maximum;

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
            //결과제공창으로 감
            MoveEvent.MoveToForm(new ResultForm());
            _isExit = false;
            this.Close();
        }
        

        private void TypingTestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(_isExit)
                Application.Exit();//다른 폼이 종료하게 되면 그 메인폼도 같이 종료하게됨.
        }


        //500ms마다 한 번 Tick이 발생
        private void timer_Tick(object sender, EventArgs e)
        {
            if (pgbTimer.Value == 0)
            {
                return;
            }

            pgbTimer.Value -= 1;
            count++;
            lbl.Text = count.ToString();

            //클립보드 금지
        }

        //타이머 측정을 같은 스레드에서 하면서 delay가 발생

    }
}
