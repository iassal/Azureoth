using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Azureoth.Database.Repositories
{
    public interface IRepository<TEntity>
    {
        #region Create
        void Create(TEntity item);
        #endregion Create

        #region Read
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
        #endregion Read

        #region Update
        void Update(TEntity item);
        #endregion Update

        #region Delete
        void Delete(int id);
        #endregion Delete
    }
}
