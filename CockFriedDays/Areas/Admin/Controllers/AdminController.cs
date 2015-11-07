using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using IBLL;
namespace CockFriedDays.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        public IBLL.IUsersBLL UsersBLL { get; set; }

        #region Methords
        public AdminController(IBLL.IUsersBLL _UsersBLL)
        {
            UsersBLL = _UsersBLL;
        }

        // GET: Admin/Admin
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
        #endregion
    }
}