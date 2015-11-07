using log4net;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace CockFriedDays.Controllers
{
    public class UsersController : Controller
    {
        ILog rootLog = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        public IBLL.IUsersBLL UsersBLL { get; set; }
        public UsersController(IBLL.IUsersBLL  _UsersBLL)
        {
            UsersBLL = _UsersBLL;
        } 
        // GET: Users
        public ActionResult Index()
        {
            List<Users> userList = UsersBLL.GetEntityList(p => p.Id == 1).ToList();
            return View();
        }

        public ActionResult Register()
        {
            rootLog.Debug("Hello World");
            rootLog.Info("Hello World");
            rootLog.Error("Hello wrold");
            return View();
        }
        [HttpPost]
        public ActionResult Register(Users model)
        {
            if (ModelState.IsValid)
            {

            }
            else
            {
                ModelState.AddModelError("error", "提交的不是有效的数据");
            }

            return View();
        }
    }
}