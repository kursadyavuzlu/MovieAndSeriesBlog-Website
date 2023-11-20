using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MovieAndSeriesBlog_Website.Entity;

namespace MovieAndSeriesBlog_Website
{
    public partial class CategoryDetail : System.Web.UI.Page
    {
        Dbo_BlogSeriesEntities db = new Dbo_BlogSeriesEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["CategoryID"]);

            var blogs = db.Tbl_Blog.Where(x => x.BlogCategory == id).ToList();
            Repeater1.DataSource = blogs;
            Repeater1.DataBind();

            var blogs2 = db.Tbl_Category.ToList();
            Repeater2.DataSource = blogs2;
            Repeater2.DataBind();

            var blogs3 = db.Tbl_Blog.ToList();
            Repeater3.DataSource = blogs3;
            Repeater3.DataBind();
        }
    }
}