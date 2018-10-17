using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerString.Data
{
    //R
    public class CategoryData : EntityData<Category>
    {
        // First로 써도 되지만 FirstOrDefault를 사용하는 것이 조금 더 안전함. 에러 대신 Default값을 내보내줌
        public Category SelectById(int categoryId)
        {
            using (var context = CreateContext())
            {
                return context.Categories.FirstOrDefault(x => x.CategoryId == categoryId);
            }
        }
    }
}
