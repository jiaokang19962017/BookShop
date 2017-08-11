using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookModels
{
   public class OrdersShow
    {
        /// <summary>
        /// 订单编号
        /// </summary>
        public string Id { set; get; }
        /// <summary>
        /// 订单价格
        /// </summary>
        public string UnitPrice { set; get; }
        /// <summary>
        /// 订单时间
        /// </summary>
        public string OrderDate { set; get; }

    }
}
