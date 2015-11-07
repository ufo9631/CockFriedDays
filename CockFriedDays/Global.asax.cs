using CockFriedDays.Models;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CockFriedDays
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            ApplicationStart.Dependency();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            LoadLog4netConfig();

        }
        public class FilterConfig
        {
            public static void RegisterGlobalFilters(GlobalFilterCollection filters)
            {
                filters.Add(new ExectionErrorAttribute());
            }
        }
        /// <summary>
        /// 配置Log4Net
        /// </summary>
        private void LoadLog4netConfig()
        {
            string filePath = Server.MapPath("~/Config/Log4net.config");
            FileInfo fileInfo = new FileInfo(filePath);
            //DOMConfigurator已经被XmlConfigurator取代
            //log4net.Config.DOMConfigurator.Configure(fileInfo);
            XmlConfigurator.ConfigureAndWatch(fileInfo);
        }
    }
}
