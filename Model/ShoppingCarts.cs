using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
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
