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
    public class GetUserInfoService : IGetUserInfo
    {

        /// <summary>
        /// 根据用户id获取用户信息
        /// </summary>
        /// <param name="use"></param>
        /// <returns></returns>
        public Users GetInfoByLoginId(Users use)
        {
            string sql = "SELECT name,address,phone,mail FROM users WHERE loginid=@loginid";
            
            SqlParameter[] parm = {
                new SqlParameter("@loginid",use.LoginId)
            };
            SqlDataReader dr = SqlHelper.GetDataReader(CommandType.Text, sql, parm);
            Users nuse = new Users();
            while (dr.Read())
            {
                nuse.Name = dr["name"].ToString();
                nuse.Phone = dr["phone"].ToString();
                nuse.Address = dr["address"].ToString();
                nuse.Mail = dr["mail"].ToString();
            }
            return nuse;
        }

        /// <summary>
        /// 修改用户资料
        /// </summary>
        /// <param name="use"></param>
        /// <returns></returns>
        public int UpdateUserInfo(Users use)
        {
            string sql = "UPDATE users SET name=@name,address=@address,phone=@phone,mail=@mail WHERE loginid=@loginid";
            SqlParameter[] parm = {
                new SqlParameter("@name",use.Name),
                new SqlParameter("@address",use.Address),
                new SqlParameter("@phone",use.Phone),
                new SqlParameter("@mail",use.Mail),
                new SqlParameter("@loginid",use.LoginId)
            };
            return SqlHelper.ExecuteNonQuery(CommandType.Text, sql, parm);
        }
    }
}
