using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MovieAndSeriesBlog_Website.Entity;

namespace MovieAndSeriesBlog_Website
{
    public partial class Contact : System.Web.UI.Page
    {
        Dbo_BlogSeriesEntities db = new Dbo_BlogSeriesEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Tbl_Contact c = new Tbl_Contact();
            c.Name = TextBox1.Text;
            c.Mail = TextBox2.Text;
            c.Phone = TextBox3.Text;
            c.Topic = TextBox4.Text;
            c.Message = TextBox5.Text;
            db.Tbl_Contact.Add(c);
            db.SaveChanges();
        }
    }
}