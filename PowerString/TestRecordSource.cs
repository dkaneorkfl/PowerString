using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerString
{
    public class TestRecordSource
    {
        public int CodeId { get; set; }
        public String TestRecordDate { get; set; }
        public bool TestRecordIsCorrect { get; set; }
        public Nullable<decimal> TimerTaken { get; set; }

        public TestRecordSource(int codeId, string testRecordDate, bool testRecordIsCorrect, decimal? timerTaken)
        {
            CodeId = codeId;
            TestRecordDate = testRecordDate;
            TestRecordIsCorrect = testRecordIsCorrect;
            TimerTaken = timerTaken;
        }
    }
}
