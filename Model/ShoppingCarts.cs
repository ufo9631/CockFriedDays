using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 购物车
    /// </summary>
   [Table("ShoppingCarts")]
    public class ShoppingCarts : BaseModel
    {
        /// <summary>
        /// 商品Id
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public int Quantity { get; set; }

    }
}
