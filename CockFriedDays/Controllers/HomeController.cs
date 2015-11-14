using Common;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

using System.Web.Mvc;
namespace CockFriedDays.Controllers
{
  

    public class HomeController:Controller
    {
       
        public HomeController()
        {
    
        }

        public ActionResult Index()
        {
            LogHelp.Debug("Debug");
            LogHelp.Info("Info");
            LogHelp.Error("Error");
            return View();
        }
    }
}