using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.IO;

namespace WebApplication1
{
    public partial class saveas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           signning cs = new signning();
           cs.Operation = "?imageView/2/w/200/h/200";
           Label1.Text =cs.getSign("test-persitent", "-123456.jpg");
           Label2.Text = https.GetRequestData(Label1.Text);
        }
    }
}