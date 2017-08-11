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
    /// GetOrderInfoASHX 的摘要说明
    /// </summary>
    public class GetOrderInfoASHX : IHttpHandler
    {
        GetOrderInfoManager goim = new GetOrderInfoManager();

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string id = context.Request["id"];
            context.Response.Write(GetTableRow(id));
        }
        public string GetTableRow(string loginid)
        {
            StringBuilder sbHtml = new StringBuilder();
            List<Orders> list = goim.GetOrder(loginid);
            foreach (Orders ord in list)
            {

                sbHtml.Append("<td>");
                sbHtml.Append("<span id='ContentPlaceHolder1_gvUserOrder_lblNo_0'></span>");
                sbHtml.Append("</td><td>");
                sbHtml.Append("<span id='ContentPlaceHolder1_gvUserOrder_lblOrderID_0'>"+ord.Id+"</span>");
                sbHtml.Append("</td><td>");
                sbHtml.Append("<span id='ContentPlaceHolder1_gvUserOrder_lblPrice_0'>"+ord.TotalPrice+"</span>");
                sbHtml.Append("</td><td>");
                sbHtml.Append("<span id='ContentPlaceHolder1_gvUserOrder_lblOrderDate_0'>"+ord.OrderDate+"</span>");
                sbHtml.Append("</td><td>");
                sbHtml.Append("<a id='ContentPlaceHolder1_gvUserOrder_lbtnDetail_0' href='UserOrderDetail.html'>详细信息</a>");
                sbHtml.Append("</td><td>");
                sbHtml.Append("<a onclick='javascript:return confirm(&#39;确定删除？&#39;);' id='ContentPlaceHolder1_gvUserOrder_lbtnDelete_0' class='button border-red' href='javascript:__doPostBack(&#39;ctl00$ContentPlaceHolder1$gvUserOrder$ctl02$lbtnDelete&#39;,&#39;&#39;)'><span class='icon-trash-o'></span>删除</a>");
                sbHtml.Append("</td>");
                                              
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