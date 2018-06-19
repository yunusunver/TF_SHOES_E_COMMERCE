using Shoes.CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.CoreLayer.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        //Linq ile istenilen veriyi çeker.
        T Get(Expression<Func<T, bool>> filter = null);

        //Listeleme
        List<T> GetList(Expression<Func<T, bool>> filter = null);

        //Veri ekleme
        void Add(T entity);

        //Veri güncelleme
        void Update(T entity);

        //Veri silme
        void Delete(T entity);
    }
}
