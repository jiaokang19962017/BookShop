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
    /// GetNewBookList 的摘要说明
    /// </summary>
    public class GetNewBookList : IHttpHandler
    {
        GetIndexBookInfoManager gibim = new GetIndexBookInfoManager();
        public void ProcessRequest(HttpContext context)
        {
            
            context.Response.ContentType = "text/plain";
            context.Response.Write(GetTableRow());
        }
        public  string GetTableRow()
        {
            StringBuilder sbHtml = new StringBuilder();
            List<Books> list = gibim.GetNewBookInfo();
            int flag = 0;
            foreach (Books book in list)
            {
                if (flag%3==0)
                {
                    sbHtml.Append("<tr>");
                }
                
                sbHtml.Append("<td>");
                sbHtml.Append("<dl id = 'bookNew'>");
                sbHtml.Append("<dt>");
                sbHtml.Append("<img style ='width: 80px; height: 100px' src ='img/BookCovers/"+book.ImageName+".jpg' alt = '' />");
                sbHtml.Append("</dt>");
                sbHtml.Append("<dd>");
                sbHtml.Append("<a href ='BookDetails.html?"+book.Id+"'><span class='book_title'>"+book.Title+"</span></a>");
                sbHtml.Append("<br/>");
                sbHtml.Append("<span class='book_publish'>出版日期:"+book.PublishDate+"</span><br/> <span style='color:red;font-weight:bold'> 价格："+book.UnitPrice+"元</span>");
                sbHtml.Append("</dd>");
                sbHtml.Append("</dl>");
                sbHtml.Append("</td>");
            
                flag++;
                if (flag % 3 == 0)
                {
                    sbHtml.Append("</tr>");
                }

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