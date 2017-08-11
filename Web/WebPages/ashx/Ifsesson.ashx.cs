using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
namespace Web.WebPages.ashx
{
    /// <summary>
    /// Ifsesson 的摘要说明
    /// </summary>
    public class Ifsesson : IHttpHandler,IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            if (context.Session == null)
            {
                context.Response.Redirect("../index.html");
            }
            else {
                string username = (string)context.Session["id"];
                context.Response.Write(username);
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