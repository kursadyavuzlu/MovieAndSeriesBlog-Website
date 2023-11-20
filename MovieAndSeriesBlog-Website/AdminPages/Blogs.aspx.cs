using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MovieAndSeriesBlog_Website.Entity;

namespace MovieAndSeriesBlog_Website.AdminPages
{
    public partial class Blogs : System.Web.UI.Page
    {
        Dbo_BlogSeriesEntities db = new Dbo_BlogSeriesEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write(Session["Username"].ToString());
            if (Session["Username"] == null)
            {
                Response.Redirect("~/Login.Aspx");
            }
            else
            {
                Response.Write("WELCOME: " + Session["Username".ToString()]);
            }
            Repeater1.DataSource = db.Tbl_Blog.ToList();
            Repeater1.DataBind();
        }
    }
}