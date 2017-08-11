using IBookStoreDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookModels;
using System.Data.SqlClient;
using BookStoreCommon;
using System.Data;
namespace BookStoreDAL
{
  public  class GetOrderInfoService : IGetOrderInfo
    {
        /// <summary>
        /// 获取订单信息
        /// </summary>
        /// <param name="ord"></param>
        /// <returns></returns>
        public List<Orders> GetOrder(string loginid)
        {
            string sql = string.Format("SELECT * FROM orders WHERE userid =(SELECT id FROM users WHERE loginid='{0}')",loginid);
            List<Orders> list = new List<Orders>();
            SqlDataReader dr = SqlHelper.GetDataReader(CommandType.Text, sql, null);
            while (dr.Read())
            {
                Orders ord = new Orders();
                ord.Id = Convert.ToInt32(dr["id"]);
                ord.OrderDate = Convert.ToDateTime(dr["OrderDate"]);
                ord.TotalPrice = Convert.ToDecimal(dr["TotalPrice"]);
                list.Add(ord);
            }
            return list;
        }
    }
}
