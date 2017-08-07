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
    }
}
