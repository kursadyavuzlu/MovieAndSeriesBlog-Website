using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MovieAndSeriesBlog_Website.Entity;

namespace MovieAndSeriesBlog_Website.AdminPages
{
    public partial class BlogDelete : System.Web.UI.Page
    {
        Dbo_BlogSeriesEntities db = new Dbo_BlogSeriesEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["BlogID"]);
            var blog = db.Tbl_Blog.Find(x);
            db.Tbl_Blog.Remove(blog);
            db.SaveChanges();
            Response.Redirect("Blogs.Aspx");
        }
    }
}