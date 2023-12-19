
namespace WAP.DATAACCESS.Abstract.Base
{
    #region usings
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using WAP.DATAACCESS.Models.Abstract;

    #endregion
    public interface IEntityRepositoryBase<T> where T : class, IEntity, new()
    {
        IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null);
        T GetById(Expression<Func<T, bool>> filter);

    }
}
