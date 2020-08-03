using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Business.Abstract
{
   public interface IGenericService<T>
    {
        T GetById(int id);

        List<T> GetAll();

        void Create(T entity);

        void Delete(T entity);

        void Update(T entity);
    }
}
