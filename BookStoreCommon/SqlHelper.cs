using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BookStoreCommon
{
    //静态帮助类
    public static class SqlHelper
    {
        public static string strcon = ConfigurationManager.ConnectionStrings["BookStore"].ToString();
       // public static string Dbowner = ConfigurationManager.ConnectionStrings["DataBaseOwner"].ToString();
        /// <summary>
        /// 使用tDataReader查询多条数据
        /// </summary>
        /// <param name="cmdtype">命令类型</param>
        /// <param name="sql">sql语句</param>
        /// <param name="parm">传递的参数</param>
        /// <returns></returns>
        public static SqlDataReader GetDataReader(CommandType cmdtype, string sql, params SqlParameter[] parm)
        {
            //实例化连接对象
            SqlConnection sqlcon = new SqlConnection(strcon);
            try
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                cmd.CommandType = cmdtype;
                if (parm != null)
                {
                    cmd.Parameters.AddRange(parm);
                }

                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return dr;
            }
            catch (Exception ex)
            {
                sqlcon.Close();
                throw ex;
            }
        }
        /// <summary>
        /// 
        /// 查询结果集
        /// </summary>
        /// <param name="cmdtype">命令类型</param>
        /// <param name="sql">sql语句</param>
        /// <param name="parm">传递的参数</param>
        /// <returns></returns>
        public static DataSet ExecuteDataSet(CommandType cmdtype, string sql, params SqlParameter[] parm)
        {
            //初始化连接对象
            SqlConnection sqlcon = new SqlConnection(strcon);
            try
            {
                //打开连接
                sqlcon.Open();
                //创建命令对象
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                cmd.CommandType = cmdtype;
                //添加参数
                if (parm != null)
                {
                    cmd.Parameters.AddRange(parm);
                }
                //创建一个适配器
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //创建一个dataset实例，存放数据
                DataSet ds = new DataSet();
                //填充数据集
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //关闭连接
                sqlcon.Close();
            }
        }
        /// <summary>
        /// 
        /// 增删改
        /// </summary>
        /// <param name="cmdtype">命令类型</param>
        /// <param name="sql">sql语句</param>
        /// <param name="parm">传递的参数</param>
        /// <returns></returns>
        public static int ExecuteNonQuery(CommandType cmdtype, string sql, params SqlParameter[] parm)
        {
            //初始化连接对象
            SqlConnection sqlcon = new SqlConnection(strcon);
            try
            {
                //打开连接
                sqlcon.Open();
                //创建命令对象
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                cmd.CommandType = cmdtype;//设置命令类型
                //添加参数
                if (parm != null)
                {
                    cmd.Parameters.AddRange(parm);
                }
                int count = cmd.ExecuteNonQuery();
                return count;//返回受影响的行数
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //关闭连接
                sqlcon.Close();
            }
        }
        /// <summary>
        /// 
        /// DataTable查询
        /// </summary>
        /// <param name="cmdtype">命令类型</param>
        /// <param name="sql">sql语句</param>
        /// <param name="parm">传递的参数</param>
        /// <returns></returns>
        public static DataTable ExecuteDataTable(CommandType cmdtype, string sql, params SqlParameter[] parm)
        {
            DataSet ds = ExecuteDataSet(cmdtype, sql, parm);
            return ds.Tables[0];
        }
        /// <summary>
        /// 
        /// 查询首行首列的值
        /// </summary>
        /// <param name="cmdtype">命令类型</param>
        /// <param name="sql">sql语句</param>
        /// <param name="parm">传递的参数</param>
        /// <returns></returns>
        public static object ExecuteScalar(CommandType cmdtype, string sql, params SqlParameter[] parm)
        {
            SqlCommand cmd = new SqlCommand();
            using (SqlConnection sqlcon = new SqlConnection(strcon))
            {
                PrepareCommand(sqlcon, cmd, parm, sql, cmdtype);
                object var = cmd.ExecuteScalar();
                cmd.Parameters.Clear();
                return var;
            }
        }
        /// <summary>
        /// 创建一个关联Connection可以执行Command的方法
        /// </summary>
        /// <param name="con"></param>
        /// <param name="cmd"></param>
        /// <param name="paras"></param>
        /// <param name="sql"></param>
        public static void PrepareCommand(SqlConnection con, SqlCommand cmd, SqlParameter[] paras, string sql, CommandType comType)
        {

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            cmd.Connection = con;
            cmd.CommandType = comType;
            cmd.CommandText = sql;
            if (paras == null)
            {
                return;
            }
            foreach (SqlParameter p in paras)
            {
                cmd.Parameters.Add(p);
            }
        }
    }
}
