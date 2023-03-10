using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
   public interface IGenericDal<T> where T:class
    {
        //metotları tanımlarız
        void Insert(T t);
        void Update(T t);
        void Delete(T t);
        List<T> GetListAll();
        T GetById(int id);//idye göre getir yani silme,güncelleme gibi işlemler yapacağımız zaman bu kategoriyi id ile ilgili alana taşımak için
        List<T> GetListAll(Expression<Func<T, bool>> filter);
    }
}
