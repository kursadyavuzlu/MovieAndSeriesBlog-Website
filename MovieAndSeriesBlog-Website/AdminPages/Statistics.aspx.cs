using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MovieAndSeriesBlog_Website.Entity;

namespace MovieAndSeriesBlog_Website.AdminPages
{
    public partial class Statistics : System.Web.UI.Page
    {
        Dbo_BlogSeriesEntities db = new Dbo_BlogSeriesEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = db.Tbl_Blog.Count().ToString();
            Label2.Text = db.Tbl_Comment.Count().ToString();
            Label3.Text = db.Tbl_Blog.Where(x => x.BlogType == 2).Count().ToString();
            Label4.Text = db.Tbl_Blog.Where(x => x.BlogType == 1).Count().ToString();
            Label5.Text = db.Tbl_Blog.Where(x => x.BlogType == 3).Count().ToString();
            Label6.Text = db.Tbl_Blog.Where(y => y.BlogID == db.Tbl_Comment.GroupBy(x => x.CommentBlog).OrderByDescending(x => x.Count()).Select(z => z.Key).FirstOrDefault()).Select(k => k.BlogTitle).FirstOrDefault();
        }
    }
}