using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CockFriedDays.Controllers
{
    public class UsersController : Controller
    {
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
    }
}