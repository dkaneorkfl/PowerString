using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerString.Data
{
    public class EntityData<T> where T:class
    {
        public PowerStringEntities CreateContext()
        {
            PowerStringEntities context = new PowerStringEntities();
            context.Database.Log = PrintSQL;
            context.Configuration.ProxyCreationEnabled = false;

            return context;
        }
        private static void PrintSQL(string sql)
        {
            Console.WriteLine(sql);
        }


        public List<T> Select()
        {
            using (var context = CreateContext())
            {
                return context.Set<T>().ToList();
            }
        }

        public int Count()
        {
            using(var context = CreateContext())
            {
                return context.Set<T>().Count();
            }
        }
    }
}
