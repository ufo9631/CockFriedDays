using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CockFriedDays.Models
{
    public class JsonMessage : JsonResult
    {
        /// <summary>
        /// 状态
        /// </summary>
        public int State { get; set; }

        public string Message
        {
            get;
            set;
        }
    }
}