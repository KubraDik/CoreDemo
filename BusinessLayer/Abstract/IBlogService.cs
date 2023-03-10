using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService
    {
        void BlogAdd(Blog blog);
        void BlogDelete(Blog blog);
        void BlogUpdate(Blog blog);
        List<Blog> GetList();//category listelemek için
        Blog GetById(int id);//idye göre getirme

        List<Blog> GetBlogListWithCategory();//(3)

        List<Writer> GetBlogListWithWriter(int id);
    }
}
