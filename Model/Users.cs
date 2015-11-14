using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 用户登录信息表
    /// </summary>
    [Table("Users")]
    public class Users : BaseModel
    {
        /// <summary>
        /// 用户登录名
        /// </summary>
       [Required(ErrorMessage ="用户名不能为空！")]
        public string LoginCode { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        [Required(ErrorMessage ="密码不能为空！")]
        [DataType(DataType.Password)]
        public string PassWord { get; set; }       
        /// <summary>
        /// 确认密码
        /// </summary>
        [NotMapped]
        [DataType(DataType.Password)]
        [Compare("PassWord",ErrorMessage ="两次密码不一致！")]
        public string ConfirmPwd { get; set; }
        /// <summary>
        /// 用户类型
        /// </summary>
      [DefaultValue(UserType.Consumer)]
        public UserType UserType { get; set; }
        /// <summary>
        /// 最后一次登录时间
        /// </summary>
        public DateTime LastLoginTime { get; set; }
        [Required(ErrorMessage ="邮箱不能为空！")]
        [DataType(DataType.EmailAddress,ErrorMessage ="邮箱地址不正确！")]
        public string Email { get; set; }
    }
}
