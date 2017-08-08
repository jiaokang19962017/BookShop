using BookModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBookStoreDAL
{
    /// <summary>
    /// 获取首页分类书籍信息
    /// </summary>
   public interface IGetIndexBookInfo
    {
        /// <summary>
        /// 获取最新书籍的接口
        /// </summary>
        /// <returns></returns>
        List<Books> GetNewBookInfo();

        /// <summary>
        /// 获取特价图书列表
        /// </summary>
        /// <returns></returns>
        List<Books> GetSaleBookInfo();

        /// <summary>
        /// 获取书籍详细信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<Books> GetBookMinute(int id);

        List<Books> SelectByTitle(string title);
    }
}
