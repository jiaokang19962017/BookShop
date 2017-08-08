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

        public List<Books> SelectByTitle(string title)
        {
            return gibis.SelectByTitle(title);
        }
    }
}
