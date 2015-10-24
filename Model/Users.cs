using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 用户登录信息表
    /// </summary>
    public class Users : BaseModel
    {
        /// <summary>
        /// 用户登录名
        /// </summary>
        public string LoginCode { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string PassWord { get; set; }       
        /// <summary>
        /// 最后一次登录时间
        /// </summary>
        public DateTime LastLoginTime { get; set; }
    }
}
