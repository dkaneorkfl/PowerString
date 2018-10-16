using System.Linq;

namespace PowerString.Data
{
    public class TestRecordData : EntityData<TestRecord>
    {
        public TestRecord SelectById(int testRecordId)
        {
            using (var context = CreateContext())
            {
                return context.TestRecords.First(x => x.TestRecordId == testRecordId);
            }
        }
    }
}