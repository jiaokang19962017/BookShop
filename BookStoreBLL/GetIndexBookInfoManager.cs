using BookModels;
using BookStoreDAL;
using IBookStoreBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreBLL
{
   
    public class GetIndexBookInfoManager
    {
        GetIndexBookInfoService gibis = new GetIndexBookInfoService();

        /// <summary>
        /// 获取最新图书列表
        /// </summary>
        /// <returns></returns>
        public List<Books> GetNewBookInfo()
        {
            return gibis.GetNewBookInfo();
        }

        /// <summary>
        /// 获取打折图书列表
        /// </summary>
        /// <returns></returns>
        public List<Books> GetSaleBookInfo()
        {
            return gibis.GetSaleBookInfo();
        }

        /// <summary>
        /// 获取图书详细信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Books> GetBookMinute(int id)
        {
            return gibis.GetBookMinute(id);
        }

        /// <summary>
        /// 搜索图书信息
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public List<Books> SelectByTitle(string title)
        {
            return gibis.SelectByTitle(title);
        }

        /// <summary>
        /// 通过导航栏显示详细信息
        /// </summary>
        /// <returns></returns>
        public List<Books> GetNewBookByNav() {
            return gibis.GetNewBookByNav();
        }

        /// <summary>
        /// 通过导航栏获取打折图书信息
        /// </summary>
        /// <returns></returns>
        public List<Books> GetSaleBookByNav()
        {
            return gibis.GetSaleBookByNav();
        }

        /// <summary>
        /// 根据下拉栏获取书籍分类信息
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public List<Books> GetBookInfoByDropDown(int categoryId)
        {
            return gibis.GetBookInfoByDropDown(categoryId);
        }
    }
}
