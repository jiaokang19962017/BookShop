using BookModels;
using BookStoreDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreBLL
{
   public class AddUserInfoManager
    {
        AddUserInfo aui = new AddUserInfo();
        public int AddUser(Users use)
        {
            return aui.AddUser(use);
        }

        /// <summary>
        /// 获取全部用户id
        /// </summary>
        /// <returns></returns>
        public List<Users> GetLoginId(string id)
        {
            return aui.GetLoginId(id);
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="use"></param>
        /// <returns></returns>
        public int UserLoad(Users use)
        {
            return aui.UserLoad(use);
        }
    }
}
