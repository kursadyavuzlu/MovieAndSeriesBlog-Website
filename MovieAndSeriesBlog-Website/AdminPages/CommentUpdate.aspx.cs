using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MovieAndSeriesBlog_Website.Entity;

namespace MovieAndSeriesBlog_Website.AdminPages
{
    public partial class CommentUpdate : System.Web.UI.Page
    {
        Dbo_BlogSeriesEntities db = new Dbo_BlogSeriesEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int y = int.Parse(Request.QueryString["CommentID"]);

            if (Page.IsPostBack == false)
            {
                var value = db.Tbl_Comment.Find(y);
                TextBox1.Text = value.Tbl_Blog.BlogTitle;
                TextBox2.Text = value.Username;
                TextBox4.Text = value.CommentContent;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int y = int.Parse(Request.QueryString["CommentID"]);
            var comment = db.Tbl_Comment.Find(y);
            comment.Tbl_Blog.BlogTitle = TextBox1.Text;
            comment.Username = TextBox2.Text;
            comment.CommentContent = TextBox4.Text;
            db.SaveChanges();
            Response.Redirect("Comments.Aspx");
        }
    }
    }
