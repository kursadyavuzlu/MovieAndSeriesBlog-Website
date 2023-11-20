using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MovieAndSeriesBlog_Website.Entity;

namespace MovieAndSeriesBlog_Website
{
    public partial class BlogDetail : System.Web.UI.Page
    {
        Dbo_BlogSeriesEntities db = new Dbo_BlogSeriesEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["BlogID"]);
            var blog = db.Tbl_Blog.Where(x => x.BlogID == id).ToList();
            Repeater1.DataSource = blog;
            Repeater1.DataBind();

            var comments = db.Tbl_Comment.Where(x => x.CommentBlog == id).ToList();
            Repeater2.DataSource = comments;
            Repeater2.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["BlogID"]);
            Tbl_Comment t = new Tbl_Comment();
            t.Username = TextBox1.Text;
            t.Mail = TextBox2.Text;
            t.CommentContent = TextBox3.Text;
            t.CommentBlog = id;
            db.Tbl_Comment.Add(t);
            db.SaveChanges();
            Response.Redirect("BlogDetail.Aspx?BlogID=" + id);
        }
    }
}