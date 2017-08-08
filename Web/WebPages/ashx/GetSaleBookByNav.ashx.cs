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
    /// GetSaleBookByNav 的摘要说明
    /// </summary>
    public class GetSaleBookByNav : IHttpHandler
    {
        GetIndexBookInfoManager gibim = new GetIndexBookInfoManager();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write(GetTableRow());
        }

        public string GetTableRow()
        {
            StringBuilder sbHtml = new StringBuilder();
            List<Books> list = gibim.GetSaleBookByNav();
            foreach (Books book in list)
            {
                sbHtml.Append("<tr>");
                sbHtml.Append("<td>");
                sbHtml.Append("<div class='bookList_content_left'>");
                sbHtml.Append("<img id ='ContentPlaceHolder1_dlBookList_imgCover_0' src='img/BookCovers/" + book.ImageName + ".jpg' style='height:130px;width:100px;' />");
                sbHtml.Append("</div>");
                sbHtml.Append("<div class='bookList_content_right'>");
                sbHtml.Append("<ul>");
                sbHtml.Append("<li class='bookList_content_bookTitle'>图书名称:");
                sbHtml.Append("<a href ='BookDetails.html?" + book.Id + "' class='blue_size'>" + book.Title + "</a></li>");
                sbHtml.Append("<li>作者:" + book.Author + "</li>");
                sbHtml.Append("<li>出版社:" + book.PublishName + "</li>");
                sbHtml.Append("<li>出版时间:" + book.PublishDate + "</li>");
                sbHtml.Append("<li>图书价格:<span style ='color:red;font-weight:bold' >¥" + book.UnitPrice + "元</span></li>");
                sbHtml.Append("<li>");
                sbHtml.Append("<p>" + book.ContentDescription + "</p>");
                sbHtml.Append("</li>");
                sbHtml.Append("</ul>");
                sbHtml.Append("<dl class='bookList_content_dd'>");
                sbHtml.Append("<dd>");
                sbHtml.Append("<a style='color:white;text-decoration:none' href='BookDetails.html?" + book.Id + "'>");
                sbHtml.Append("<img id ='ContentPlaceHolder1_dlBookList_Image1_0' src='img/product_buy_01.gif' />");
                sbHtml.Append("</a>");
                sbHtml.Append("</dd>");
                sbHtml.Append("</dl>");
                sbHtml.Append("</div>");
                sbHtml.Append("<div class='bookList_content_bottom'></div>");
                sbHtml.Append("</td>");
                sbHtml.Append("</tr>");

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