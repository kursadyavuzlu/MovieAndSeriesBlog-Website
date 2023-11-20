using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MovieAndSeriesBlog_Website.Entity;

namespace MovieAndSeriesBlog_Website
{
    public partial class Default : System.Web.UI.Page
    {
        Dbo_BlogSeriesEntities db = new Dbo_BlogSeriesEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var blogs = db.Tbl_Blog.ToList();
            Repeater1.DataSource = blogs;
            Repeater1.DataBind();

            var blogs2 = db.Tbl_Category.ToList();
            Repeater2.DataSource = blogs2;
            Repeater2.DataBind();

            var blogs3 = db.Tbl_Blog.OrderByDescending(c => c.BlogID).Take(5).ToList();
            Repeater3.DataSource = blogs3;
            Repeater3.DataBind();

            var blogs4 = db.Tbl_Comment.OrderByDescending(c => c.CommentID).Take(3).ToList();
            Repeater4.DataSource = blogs4;
            Repeater4.DataBind();
        }
    }
}