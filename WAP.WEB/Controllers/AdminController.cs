
namespace WAP.WEB.Controllers
{
    #region usings
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using WAP.DATAACCESS.Context;
    using WAP.DATAACCESS.Models;
    using PagedList;
    #endregion
    public class AdminController : Controller
    {
        //IAccountRepository repo = new IAccountRepository();
        
        public ActionResult Index(int pageNumber = 1)
        {
            using (var db = new WAPContext())
            {
                var result = db.Set<Account>().ToList().ToPagedList(pageNumber , 1);
                db.SaveChanges();
                return View(result);

            }

        }



    }
}