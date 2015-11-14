using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CockFriedDays.Models
{
    public class BaseController:Controller
    {
        public int State { get; set; }
        public string Message { get; set; }
        public JsonResult JsonMessage()
        {
            return Json(new { message=Message,state=State},JsonRequestBehavior.AllowGet);
        }
    }
}