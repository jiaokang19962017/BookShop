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
    }
}
