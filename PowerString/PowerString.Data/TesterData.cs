using System.Linq;

namespace PowerString.Data
{
    //CRUD
    public class TesterData : EntityData<Tester>
    {
        public void Insert(Tester tester)
        {
            using(var context = CreateContext())
            {
                context.Testers.Add(tester);
                context.SaveChanges();
            }
        }

        public Tester SelectById(int testerId)
        {
            using (var context = CreateContext())
            {
                return context.Testers.First(x=> x.TesterId == testerId);
            }
        }
        
        public void Update(Tester tester)
        {
            using(var context = CreateContext())
            {
                //Tester t = SelectById(tester.TesterId);
                context.Entry(tester).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Tester tester)
        {
            using (var context = CreateContext())
            {
                context.Entry(tester).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}