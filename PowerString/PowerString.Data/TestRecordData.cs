using System.Linq;

namespace PowerString.Data
{
    //R
    public class TestRecordData : EntityData<TestRecord>
    {
        public TestRecord SelectById(int testRecordId)
        {
            using (var context = CreateContext())
            {
                return context.TestRecords.First(x => x.TestRecordId == testRecordId);
            }
        }

        public void Insert(TestRecord testRecord)
        {
            using (var context = CreateContext())
            {
                context.TestRecords.Add(testRecord);
                context.SaveChanges();
            }
        }
    }
}