using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.IO;

namespace WebApplication1.Up
{
    public partial class show_token : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            tokenning gettoken = new tokenning();
            TextBox1.Text = gettoken.getToken();
        }
    }
}