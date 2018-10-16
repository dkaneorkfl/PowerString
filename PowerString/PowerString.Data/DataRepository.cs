using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerString.Data
{
    public class DataRepository
    {
        private static CategoryData _category;
        public static CategoryData Category
        {
            get
            {
                if (_category == null)
                    _category = new CategoryData();

                return _category;
            }
        }

        private static CodeData _code;
        public static CodeData Code
        {
            get
            {
                if (_code == null)
                    _code = new CodeData();

                return _code;
            }
        }

        private static TesterData _tester;
        public static TesterData Tester
        {
            get
            {
                if (_tester == null)
                    _tester = new TesterData();

                return _tester;
            }
        }

        private static TestRecordData _testRecord;
        public static TestRecordData TestRecord
        {
            get
            {
                if (_testerRecord == null)
                    _testRecord = new TestRecordData();

                return _testRecord;
            }
        }
    }
}
