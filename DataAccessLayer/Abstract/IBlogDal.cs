using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
   public interface IBlogDal:IGenericDal<Blog>
    {
        List<Blog> GetListWithCategory();
        //bu sadece bloglara ait olduğu için burada tanımladık
        List<Blog> GetListWithCategoryByWriter(int id);
    }
}
