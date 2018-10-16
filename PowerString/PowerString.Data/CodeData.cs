using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerString.Data
{
    public class CodeData : EntityData<Code>
    {
        public Code SelectById(int codeId)
        {
            using (var context = CreateContext())
            {
                return context.Codes.First(x => x.CodeId == codeId);
            }
        }
    }
}
