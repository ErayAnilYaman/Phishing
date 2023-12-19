
namespace WAP.DATAACCESS.Concrete
{
    #region usings
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Text;
    using System.Threading.Tasks;
    using WAP.DATAACCESS.Abstract;
    using WAP.DATAACCESS.Concrete.Base;
    using WAP.DATAACCESS.Context;
    using WAP.DATAACCESS.Models;

    #endregion
    public class AccountRepository : EfEntityRepositoryBase<Account, WAPContext>, IAccountDal
    {

    }
}
