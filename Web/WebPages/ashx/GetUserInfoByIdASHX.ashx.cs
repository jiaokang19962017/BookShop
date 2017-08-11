using BookModels;
using BookStoreBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.WebPages.ashx
{
    /// <summary>
    /// GetUserInfoByIdASHX 的摘要说明
    /// </summary>
    public class GetUserInfoByIdASHX : IHttpHandler
    {
        GetUserInfoManager guim = new GetUserInfoManager();
        Users use = new Users();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

          use.LoginId = context.Request["id"];
            use = guim.GetInfoByLoginId(use);
            string str = use.Name + "," + use.Phone + "," + use.Address + "," + use.Mail;
            context.Response.Write(str);
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