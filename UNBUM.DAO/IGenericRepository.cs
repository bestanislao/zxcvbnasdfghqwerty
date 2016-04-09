using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace UNBUM.DAO
{
    public interface IGenericRepository<TEntity, TID>
    {
        List<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "");
        TEntity GetById(object id);
        TEntity GetFirstOrDefault(
            Expression<Func<TEntity, bool>> filter = null,
            params Expression<Func<TEntity, object>>[] includes);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(object id);
        IEnumerable<TEntity> GetWithRawSql(string query, params object[] parameters);
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> filter
                            , params Expression<Func<TEntity, object>>[] includeProperties);
    }
}
