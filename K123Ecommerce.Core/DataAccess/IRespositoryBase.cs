using System;
using System.Linq.Expressions;
using K123Ecommerce.Core.Entities.Abstract;

namespace K123Ecommerce.Core.DataAccess
{
    public interface IRespositoryBase<TEntity>
        where TEntity : IEntity
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        TEntity Get(Expression<Func<TEntity, bool>> filter);
        List<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null);
    }
}

