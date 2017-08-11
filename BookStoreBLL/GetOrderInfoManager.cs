using BookModels;
using BookStoreDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreBLL
{
   public class GetOrderInfoManager
    {
        GetOrderInfoService gois = new GetOrderInfoService();
        /// <summary>
        /// 获取订单信息
        /// </summary>
        /// <param name="loginid"></param>
        /// <returns></returns>
        public List<Orders> GetOrder(string loginid)
        {
            return gois.GetOrder(loginid);
        }
    }
}
