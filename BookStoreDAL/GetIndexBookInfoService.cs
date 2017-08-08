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
            string sql = "SELECT TOP 9 Id,Title,UnitPrice,imageName,publishDate FROM Books WHERE PublishDate>='2007-08-01'";
            List<Books> list = new List<Books>();
            SqlDataReader dr = SqlHelper.GetDataReader(CommandType.Text, sql, null);
            while (dr.Read())
            {
                Books book = new Books();
                book.Id = Convert.ToInt32(dr["Id"]);
                book.Title = dr["Title"].ToString();
                book.UnitPrice = Convert.ToDecimal(dr["UnitPrice"]);
                book.ImageName = dr["ImageName"].ToString();
                book.PublishDate = Convert.ToDateTime(dr["publishDate"]);
                list.Add(book);
            }
            return list;
        }

        /// <summary>
        /// 获取打折图书列表
        /// </summary>
        /// <returns></returns>
        public List<Books> GetSaleBookInfo()
        {
            string sql = "SELECT TOP 9 Id,Title,UnitPrice,imageName,publishDate FROM Books WHERE UnitPrice<20";
            List<Books> list = new List<Books>();
            SqlDataReader dr = SqlHelper.GetDataReader(CommandType.Text, sql, null);
            while (dr.Read())
            {
                Books book = new Books();
                book.Id = Convert.ToInt32(dr["Id"]);
                book.Title = dr["Title"].ToString();
                book.UnitPrice = Convert.ToDecimal(dr["UnitPrice"]);
                book.ImageName = dr["ImageName"].ToString();
                book.PublishDate = Convert.ToDateTime(dr["publishDate"]);
                list.Add(book);
            }
            return list;
        }


        /// <summary>
        /// 获取书籍详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Books> GetBookMinute(int id)
        {
            string sql = string.Format("SELECT bs.id as id,imageName,title,author,ps.name as name,publishDate,ISBN,wordsCount,clicks,unitPrice,contentDescription FROM Books bs INNER JOIN Publishers ps ON bs.publisherId=ps.Id where bs.id={0}", id);
            List<Books> list = new List<Books>();
            SqlDataReader dr = SqlHelper.GetDataReader(CommandType.Text, sql, null);
            while (dr.Read())
            {
                Books book = new Books();
                book.Id = Convert.ToInt32(dr["id"]);
                book.ImageName = dr["imageName"].ToString();
                book.Title = dr["Title"].ToString();
                book.Author = dr["author"].ToString();
                book.PublishName = dr["name"].ToString();
                book.PublishDate = Convert.ToDateTime(dr["publishDate"]);
                book.ISBN = dr["ISBN"].ToString();
                book.WordsCount = Convert.ToInt32(dr["wordsCount"]);
                book.Clicks = Convert.ToInt32(dr["clicks"]);
                book.UnitPrice = Convert.ToDecimal(dr["unitPrice"]);
                book.ContentDescription = dr["contentDescription"].ToString();
                list.Add(book);
            }
            return list;
        }

        /// <summary>
        /// 根据图书标题搜索
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public List<Books> SelectByTitle(string title)
        {
            string sql = string.Format("SELECT bs.id,imageName,title,author,ps.name,publishDate,ISBN,wordsCount,clicks,unitPrice,contentDescription FROM Books bs INNER JOIN Publishers ps ON bs.publisherId=ps.Id WHERE  title LIKE '%{0}%'", title);
            List<Books> list = new List<Books>();
            SqlDataReader dr = SqlHelper.GetDataReader(CommandType.Text, sql, null);
            while (dr.Read())
            {
                Books book = new Books();
                book.Id = Convert.ToInt32(dr["id"]);
                book.ImageName = dr["imageName"].ToString();
                book.Title = dr["Title"].ToString();
                book.Author = dr["author"].ToString();
                book.PublishName = dr["name"].ToString();
                book.PublishDate = Convert.ToDateTime(dr["publishDate"]);
                book.ISBN = dr["ISBN"].ToString();
                book.WordsCount = Convert.ToInt32(dr["wordsCount"]);
                book.Clicks = Convert.ToInt32(dr["clicks"]);
                book.UnitPrice = Convert.ToDecimal(dr["unitPrice"]);
                book.ContentDescription = dr["contentDescription"].ToString();
                list.Add(book);
            }
            return list;
        }
    }
}
