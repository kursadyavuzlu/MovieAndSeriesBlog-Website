using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MovieAndSeriesBlog_Website.Entity;

namespace MovieAndSeriesBlog_Website.AdminPages
{
    public partial class Messages : System.Web.UI.Page
    {
        Dbo_BlogSeriesEntities db = new Dbo_BlogSeriesEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var messages = (from x in db.Tbl_Contact
                            select new
                            {
                                x.MessageID,
                                x.Name,
                                x.Mail,
                                x.Phone,
                                x.Topic,
                                x.Message
                            }).ToList();
            Repeater1.DataSource = messages;
            Repeater1.DataBind();
        }
    }
}