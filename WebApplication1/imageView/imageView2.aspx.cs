using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.IO;

namespace WebApplication1.imageView
{
    public partial class imageView2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {



            Label3.Text = TextBox1.Text + "?watermark/2/text/" + setting.Bs64(TextBox2.Text) + "/fontsize/1600" + "/fill/" + setting.Bs64("#FFFFFF")+ "/dissolve/50";


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Image1.ImageUrl = TextBox3.Text + "?imageView2/0/w/300/h/200";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Image2.ImageUrl = "http://liuhanlin-work.qiniudn.com/liuhanlin.jpg";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Image3.ImageUrl = TextBox4.Text + "?imageView2/1/w/200/h/200";
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            TextBox8.Text = TextBox8.Text + "?watermark/1/image/" + setting.Bs64(TextBox9.Text) + "|imageView2/0/w/300/h/200";
            Image7.ImageUrl = TextBox8.Text;
        }
    }
}