using BookModels;
using BookStoreBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.WebPages.ashx
{
    /// <summary>
    /// AddUserASHX 的摘要说明
    /// </summary>
    public class AddUserASHX : IHttpHandler
    {
        AddUserInfoManager aui = new AddUserInfoManager();

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            Users nuse = new Users();
            nuse.LoginId = context.Request["loginid"];
            nuse.LoginPwd = context.Request["loginpwd"];
            nuse.Name = context.Request["name"];
            nuse.Address = context.Request["address"];
            nuse.Phone = context.Request["phone"];
            nuse.Mail = context.Request["mail"];
           int count =  aui.AddUser(nuse);
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