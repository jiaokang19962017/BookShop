using BookModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBookStoreDAL
{
   public interface IGetUserInfo
    {
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="use"></param>
        /// <returns></returns>
        Users GetInfoByLoginId(Users use);

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="use"></param>
        /// <returns></returns>
        int UpdateUserInfo(Users use);

    }
}
