using IBookStoreDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookModels;
using System.Data;
using System.Data.SqlClient;
using BookStoreCommon;

namespace BookStoreDAL
{
    public class GetIndexBookInfoService : IGetIndexBookInfo
    {
        /// <summary>
        /// 获取最新书籍信息
        /// </summary>
        /// <returns></returns>
        public  List<Books> GetNewBookInfo()
        {
            string sql = "SELECT Id,Title,UnitPrice FROM Books WHERE PublishDate>='2007-08-01'";
            List<Books> list = new List<Books>();
            SqlDataReader dr = SqlHelper.GetDataReader(CommandType.Text, sql, null);
            while (dr.Read())
            {
                Books book = new Books();
                book.Id = Convert.ToInt32(dr["Id"]);
                book.Title = dr["Title"].ToString();
                book.UnitPrice = Convert.ToDecimal(dr["UnitPrice"]);
                list.Add(book);
            }
            return list;
        }
    }
}
