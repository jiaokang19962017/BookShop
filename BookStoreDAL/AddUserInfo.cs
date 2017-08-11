using IBookStoreDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookModels;
using System.Data.SqlClient;
using BookStoreCommon;
using System.Data;
namespace BookStoreDAL
{

    /// <summary>
    /// 新用户注册类
    /// </summary>
    public class AddUserInfo : IAddUserInfo
    {
       /// <summary>
       /// 新用户注册方法
       /// </summary>
       /// <param name="use"></param>
       /// <returns></returns>
       public int AddUser(Users use)
        {
            string sql = "INSERT INTO Users(LoginId,LoginPwd,NAME,ADDRESS,phone,Mail,userRoleId,UserStateId) VALUES(@loginid,@loginpwd,@name,@address,@phone,@mail,1,1)";
            SqlParameter[] parm = 
                {
                new SqlParameter("@loginid",use.LoginId),
                new SqlParameter("@loginpwd",use.LoginPwd),
                new SqlParameter("@name",use.Name),
                new SqlParameter("@address",use.Address),
                new SqlParameter("@phone",use.Phone),
                new SqlParameter("@mail",use.Mail)
            };
            return SqlHelper.ExecuteNonQuery(CommandType.Text,sql,parm);
        }
        /// <summary>
        /// 获取全部用户id
        /// </summary>
        /// <returns></returns>

        public List<Users> GetLoginId(string id)
        {
            string sql =string.Format("SELECT loginid FROM users where loginid='{0}'",id);
            List<Users> list = new List<Users>();
            SqlDataReader dr = SqlHelper.GetDataReader(CommandType.Text, sql, null);
            while (dr.Read())
            {
                Users use = new Users();
                use.LoginId = dr["loginid"].ToString();
                list.Add(use);
            }
            return list;   
        }

        /// <summary>
        /// 登录验证
        /// </summary>
        /// <param name="use"></param>
        /// <returns></returns>
        public int UserLoad(Users use)
        {
            string sql = "SELECT COUNT(*) FROM users WHERE loginid=@loginid AND loginpwd=@loginpwd";
            SqlParameter[] parm = 
                {
                new SqlParameter("@loginid",use.LoginId),
                new SqlParameter("@loginpwd",use.LoginPwd)
            };
            return Convert.ToInt32(SqlHelper.ExecuteScalar(CommandType.Text, sql, parm));
        }
    }
}
