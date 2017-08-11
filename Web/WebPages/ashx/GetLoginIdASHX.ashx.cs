using BookModels;
using BookStoreBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Web.WebPages.ashx
{
    /// <summary>
    /// GetLoginIdASHX 的摘要说明
    /// </summary>
    public class GetLoginIdASHX : IHttpHandler
    {
        AddUserInfoManager aui = new AddUserInfoManager();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string userid = context.Request["userid"];
            context.Response.Write(GetTableRow(userid));

        }

        public string GetTableRow(string loginid)
        {
            StringBuilder sbHtml = new StringBuilder();
            List<Users> list = aui.GetLoginId(loginid);
            foreach (Users use in list)
            {
                sbHtml.Append(use.LoginId);
            }
            return sbHtml.ToString();
        }


        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}