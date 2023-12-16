
namespace WAP.DATAACCESS.Context
{
    #region usings
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using WAP.DATAACCESS.Models;

    #endregion
    public class WAPContext : DbContext
    {
        public WAPContext() : base("WAPDB")
        {}
        DbSet<Account> ACCOUNTS { get; set; }

    }
}
