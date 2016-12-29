
using System;
using System.Collections.Generic;
using Azureoth.Database.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace Azureoth.Database.Repositories
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private DbContext context;
        private DbSet<TEntity> dbSet;

        public BaseRepository(DbContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }

        #region Create
        public void Create(TEntity item)
        {
            dbSet.Add(item);
        }
        #endregion Create

        #region Read
        public TEntity Get(int id)
        {
            return dbSet.SingleOrDefault(e => ((IEntity)e).Id == id) as TEntity;
        }
        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            var query = dbSet.AsQueryable();
            if (filter != null)
            {
                query = query.Where(filter);
            }
            return query.ToList();
        }
        #endregion Read

        #region Update
        public void Update(TEntity item)
        {
            dbSet.Update(item);
        }
        #endregion Update

        #region Delete
        public void Delete(int id)
        {
            TEntity entityToRemove = Get(id);
            dbSet.Remove(entityToRemove);
        }
        #endregion Delete
    }
}
