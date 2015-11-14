using CockFriedDays.Models;
using log4net;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using Common;
namespace CockFriedDays.Controllers
{
    public class UsersController : BaseController
    {
        ILog rootLog = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
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

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection form)
        {
            if (string.IsNullOrEmpty(form["userName"]) || string.IsNullOrEmpty(form["passWord"]))
            {
                State = 0;
                Message = "用户名和密码不能为空";
                return JsonMessage();
            }
            Users us = new Users();
            us.LoginCode = form["userName"];
            us.PassWord = Uitls.Encrypt(form["passWord"]);
            IQueryable<Users> uList = UsersBLL.GetEntityList(u => u.LoginCode == us.LoginCode && u.PassWord == us.PassWord);
            if (uList.Count() <= 0)
            {
                State = 0;
                Message = "用户名或密码错误，请重新输入！";
                return JsonMessage();
            }
            Users user = uList.Single();
            //设置Cookies
            HttpCookie cookie = new HttpCookie("ul", user.LoginCode);
            HttpCookie utCookie = new HttpCookie("ut", ((int)us.UserType).ToString());
            Response.Cookies.Add(cookie);
            Request.Cookies.Add(utCookie);
            //记录最后一次登录时间
            user.LastLoginTime = DateTime.Now;
            UsersBLL.EditEntity(user);
            return Redirect(Url.Action("", "Index"));
        }

    }
}