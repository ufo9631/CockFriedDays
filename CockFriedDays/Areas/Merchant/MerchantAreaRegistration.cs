using System.Web.Mvc;

namespace CockFriedDays.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Merchant";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Merchant",
                "Merchant/{controller}/{action}/{id}",
                new { action = "Login", id = UrlParameter.Optional, Controller="Admin" }
            );
        }
    }
}