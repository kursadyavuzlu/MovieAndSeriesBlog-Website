using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MovieAndSeriesBlog_Website.Entity;

namespace MovieAndSeriesBlog_Website.AdminPages
{
    public partial class Comments : System.Web.UI.Page
    {
        Dbo_BlogSeriesEntities db = new Dbo_BlogSeriesEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var comments = (from x in db.Tbl_Comment
                            select new
                            {
                                x.CommentID,
                                x.Username,
                                x.Tbl_Blog.BlogTitle
                            }).ToList();
            Repeater1.DataSource = comments;
            Repeater1.DataBind();
        }
    }
}