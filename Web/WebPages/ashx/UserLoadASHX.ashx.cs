using BookModels;
using BookStoreBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
namespace Web.WebPages.ashx
{
    /// <summary>
    /// UserLoadASHX 的摘要说明
    /// </summary>
    public class UserLoadASHX : IHttpHandler,IRequiresSessionState
    {
        AddUserInfoManager aui = new AddUserInfoManager();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
          
            Users use = new Users();
            use.LoginId = context.Request["loginid"];
            use.LoginPwd = context.Request["loginpwd"];
            int result = aui.UserLoad(use);
            context.Response.Write(result);
            if (result==1)
            {
                context.Session["id"] = use.LoginId;
               // context.Response.Redirect("Ifsesson.ashx");
            }
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