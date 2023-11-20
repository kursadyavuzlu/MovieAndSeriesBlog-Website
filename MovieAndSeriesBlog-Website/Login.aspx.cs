using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MovieAndSeriesBlog_Website.Entity;

namespace MovieAndSeriesBlog_Website
{
    public partial class Login : System.Web.UI.Page
    {
        Dbo_BlogSeriesEntities db = new Dbo_BlogSeriesEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var query = from x in db.Tbl_Admin where 
                        x.Username == TextBox1.Text && x.Password == TextBox2.Text
                        select x;
            if(query.Any())
            {
                Session.Add("Username", TextBox1.Text);
                Response.Redirect("/AdminPages/Blogs.Aspx");
            }
            else
            {
                Response.Write("ERROR!");
            }
        }
    }
}