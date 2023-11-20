using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MovieAndSeriesBlog_Website.Entity;

namespace MovieAndSeriesBlog_Website.AdminPages
{
    public partial class NewBlog : System.Web.UI.Page
    {
        Dbo_BlogSeriesEntities db = new Dbo_BlogSeriesEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
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
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Tbl_Blog t = new Tbl_Blog();
            t.BlogTitle = TextBox1.Text;
            t.BlogImage = TextBox3.Text;
            t.BlogContent = TextBox4.Text;
            t.BlogDate = DateTime.Parse(TextBox2.Text);
            t.BlogType = byte.Parse(DropDownList1.SelectedValue);
            t.BlogCategory = byte.Parse(DropDownList2.SelectedValue);
            db.Tbl_Blog.Add(t);
            db.SaveChanges();
            Response.Redirect("Blogs.Aspx");
        }
    }
}