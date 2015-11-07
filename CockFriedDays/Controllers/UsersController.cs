using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Common;
namespace CockFriedDays.Controllers
{
    public class UsersController : Controller
    {
        public IBLL.IUsersBLL UsersBLL { get; set; }
        public UsersController(IBLL.IUsersBLL _UsersBLL)
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
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection form)
        {
            if (string.IsNullOrEmpty(form["userName"]) || string.IsNullOrEmpty(form["passWord"]))
            {
                return Content("-1");//用户名或密码为空
            }
            Users user = new Users();
            user.LoginCode = form["userName"];
            user.PassWord = Uitls.Encrypt(form["passWord"]);
            IQueryable<Users> uList = UsersBLL.GetEntityList(u => u.LoginCode == user.LoginCode && u.PassWord == user.PassWord);
            if(uList.Count()<=0)
            {
                return Content("0");//用户名或密码错误
            }
            HttpCookie cook = new HttpCookie();
            
            return View();
        }
    }
}