using BookModels;
using BookStoreDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreBLL
{
    public class GetUserInfoManager
    {
        GetUserInfoService guis = new GetUserInfoService();

        /// <summary>
        /// 根据id获取用户信息
        /// </summary>
        /// <param name="use"></param>
        /// <returns></returns>
        public Users GetInfoByLoginId(Users use)
        {
            return guis.GetInfoByLoginId(use);
        }

        /// <summary>
        /// 更新用户资料
        /// </summary>
        /// <param name="use"></param>
        /// <returns></returns>
        public int UpdateUserInfo(Users use)
        {
            return guis.UpdateUserInfo(use);
        }
    }
}
