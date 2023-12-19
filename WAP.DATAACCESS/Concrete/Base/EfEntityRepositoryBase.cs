
namespace WAP.DATAACCESS.Concrete.Base
{
    #region usings
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Runtime.Remoting.Contexts;
    using System.Text;
    using System.Threading.Tasks;
    using WAP.DATAACCESS.Abstract.Base;
    using WAP.DATAACCESS.Models.Abstract;

    #endregion
    public class EfEntityRepositoryBase<T, C> : IEntityRepositoryBase<T>
        where T : class, IEntity, new()
        where C : DbContext, new()
    {
        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            using (var db = new C())
            {
                return (filter == null) ? db.Set<T>().ToList() : db.Set<T>().Where(filter).ToList();
            }
        }

        public T GetById(Expression<Func<T, bool>> filter)
        {
            using (var db = new C())
            {
                var result = (db.Set<T>().FirstOrDefault(filter));
                return result != null ? result : null;
            }
        }
    }
}
