using BookModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBookStoreDAL
{
    /// <summary>
    /// 新用户注册接口
    /// </summary>
   public interface IAddUserInfo
    {
        /// <summary>
        /// 新用户注册
        /// </summary>
        /// <param name="use"></param>
        /// <returns></returns>
        int AddUser(Users use);

        /// <summary>
        /// 判断用户名是否重复
        /// </summary>
        /// <returns></returns>
        List<Users> GetLoginId(string id);

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="use"></param>
        /// <returns></returns>
        int UserLoad(Users use);
    }
}
