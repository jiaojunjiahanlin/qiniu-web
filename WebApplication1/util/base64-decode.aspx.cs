using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.util
{
    public partial class base64_decode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            byte[] outputb = Convert.FromBase64String(TextBox1.Text);
            Label1.Text = System.Text.Encoding.Default.GetString(outputb);

           

           
        }
    }
}