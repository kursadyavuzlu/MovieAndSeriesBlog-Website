using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MovieAndSeriesBlog_Website.Entity;

namespace MovieAndSeriesBlog_Website.AdminPages
{
    public partial class BlogUpdate : System.Web.UI.Page
    {
        Dbo_BlogSeriesEntities db = new Dbo_BlogSeriesEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int y = int.Parse(Request.QueryString["BlogId"]);
            if (Page.IsPostBack == false)
            {
                var types = (from x in db.Tbl_Type
                             select new
                             {
                                 x.TypeName,
                                 x.TypeID
                             }).ToList();
                DropDownList1.DataSource = types;
                DropDownList1.DataBind();

                var categories = (from x in db.Tbl_Category
                                  select new
                                  {
                                      x.CategoryName,
                                      x.CategoryID
                                  }).ToList();
                DropDownList2.DataSource = categories;
                DropDownList2.DataBind();

                var value = db.Tbl_Blog.Find(y);
                TextBox1.Text = value.BlogTitle;
                TextBox2.Text = value.BlogDate.ToString();
                TextBox3.Text = value.BlogImage;
                TextBox4.Text = value.BlogContent;
                DropDownList1.SelectedValue = value.BlogType.ToString();
                DropDownList2.SelectedValue = value.BlogCategory.ToString();
            }
        }

        

        protected void Button1_Click(object sender, EventArgs e)
        {
            int y = int.Parse(Request.QueryString["BlogID"]);
            var blog = db.Tbl_Blog.Find(y);
            blog.BlogTitle = TextBox1.Text;
            blog.BlogDate = DateTime.Parse(TextBox2.Text);
            blog.BlogImage = TextBox3.Text;
            blog.BlogContent = TextBox4.Text;
            blog.BlogType = byte.Parse(DropDownList1.SelectedValue);
            blog.BlogCategory = byte.Parse(DropDownList2.SelectedValue);
            db.SaveChanges();
            Response.Redirect("Blogs.Aspx");
        }
    }
}