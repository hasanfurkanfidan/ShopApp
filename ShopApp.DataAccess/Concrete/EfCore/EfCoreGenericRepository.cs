using Microsoft.EntityFrameworkCore;
using ShopApp.DataAccess.Abstract;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ShopApp.DataAccess.Concrete.EfCore
{
    public class EfCoreGenericRepository<T> : IGenericDal<T> where T : class, IEntity, new()
    {
        public void Create(T entity)
        {
            using (var context = new ShopContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (var context = new ShopContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter)
        {
            using (var context = new ShopContext())
            {
                if (filter == null)
                {
                    return context.Set<T>().ToList();
                }
                else
                {
                    return context.Set<T>().Where(filter).ToList();
                }
            }
        }

        public T GetById(int id)
        {
            using (var context = new ShopContext())
            {
                return context.Set<T>().Find(id);
            }
        }

        public T GetOne(Expression<Func<T, bool>> filter)
        {
            using var context = new ShopContext();
            return context.Set<T>().SingleOrDefault();
        }

        public void Update(T entity)
        {
            using var context = new ShopContext();
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
