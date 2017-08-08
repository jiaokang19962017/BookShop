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

        /// <summary>
        /// 搜索书籍信息
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        List<Books> SelectByTitle(string title);

        /// <summary>
        /// 通过导航栏显示最新书籍信息
        /// </summary>
        /// <returns></returns>
        List<Books> GetNewBookByNav();

        /// <summary>
        /// 通过导航栏获取打折图书详细信息
        /// </summary>
        /// <returns></returns>
        List<Books> GetSaleBookByNav();

        /// <summary>
        /// 通过下拉栏查询图书分类信息
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        List<Books> GetBookInfoByDropDown(int categoryId);
    }
}
