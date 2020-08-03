using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ShopApp.DataAccess.Abstract
{
   public interface IGenericDal<T> where T:class,IEntity,new()
    {
        T GetById(int id);

        T GetOne(Expression<Func<T, bool>> filter);

        IEnumerable<T> GetAll(Expression<Func<T, bool>> filter);

        void Create(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
