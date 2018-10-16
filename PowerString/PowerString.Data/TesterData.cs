using System.Linq;

namespace PowerString.Data
{
    public class TesterData : EntityData<Tester>
    {
        public Tester SelectById(int testerId)
        {
            using (var context = CreateContext())
            {
                return context.Testers.First(x=> x.TesterId == testerId);
            }
        }
    }
}