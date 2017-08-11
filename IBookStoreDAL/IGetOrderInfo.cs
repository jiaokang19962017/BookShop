using BookModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBookStoreDAL
{
   public interface IGetOrderInfo
    {
        /// <summary>
        /// 获取订单信息
        /// </summary>
        /// <param name="ord"></param>
        /// <returns></returns>
        List<Orders> GetOrder(string loginid);
    }
}
