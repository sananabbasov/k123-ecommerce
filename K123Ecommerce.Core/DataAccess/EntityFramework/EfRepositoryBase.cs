using System;
using System.Linq.Expressions;
using K123Ecommerce.Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore;

namespace K123Ecommerce.Core.DataAccess.EntityFramework
{
    public class EfRepositoryBase<TEntity, TContext> : IRespositoryBase<TEntity>
        where TEntity : class, IEntity
        where TContext: DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using TContext context = new();
            var addEntity = context.Entry(entity);
            addEntity.State = EntityState.Added;
            context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            using TContext context = new();
            var deleteEntity = context.Entry(entity);
            deleteEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using TContext context = new();
            return context.Set<TEntity>().SingleOrDefault(filter);
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null)
        {
            using TContext context = new();
            return filter == null
                ? context.Set<TEntity>().ToList()
                : context.Set<TEntity>().Where(filter).ToList();
        }

        public void Update(TEntity entity)
        {
            using TContext context = new();
            var updateEntity = context.Entry(entity);
            updateEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}

