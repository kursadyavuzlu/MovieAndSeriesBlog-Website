using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MovieAndSeriesBlog_Website.Entity;

namespace MovieAndSeriesBlog_Website.AdminPages
{
    public partial class CommentDelete : System.Web.UI.Page
    {
        Dbo_BlogSeriesEntities db = new Dbo_BlogSeriesEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["BlogID"]);
            var comment = db.Tbl_Comment.Find(x);
            db.Tbl_Comment.Remove(comment);
            db.SaveChanges();
            Response.Redirect("Comments.Aspx");
        }
    }
}