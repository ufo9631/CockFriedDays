using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 商品类别表
    /// </summary>
    [Table("Category")]
    public class Category : BaseModel
    {
        /// <summary>
        /// 类别名称
        /// </summary>
        public string CategoryName { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string CategoryRemarks { get; set; }
        /// <summary>
        /// 类别级别
        /// </summary>
        public int CategoryLevel { get; set; }
    }
}
