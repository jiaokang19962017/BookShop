using BookModels;
using BookStoreBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.WebPages.ashx
{
    /// <summary>
    /// UpdateUserInfoASHX 的摘要说明
    /// </summary>
    public class UpdateUserInfoASHX : IHttpHandler
    {
        GetUserInfoManager guim = new GetUserInfoManager();
        Users use = new Users();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            use.LoginId = context.Request["loginid"];
            use.Name = context.Request["name"];
            use.Phone = context.Request["phone"];
            use.Mail = context.Request["mail"];
            use.Address = context.Request["address"];
            int count = guim.UpdateUserInfo(use);
            context.Response.Write(count);
            
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