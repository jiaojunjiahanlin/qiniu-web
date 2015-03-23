using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.imageView
{
    public partial class imageMogr2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Image1.ImageUrl = TextBox1.Text + "?imageMogr2/auto-orient";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            Image2.ImageUrl = TextBox2.Text + "?imageMogr2/auto-orient/strip";
            TextBox2.Text = Image2.ImageUrl;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Image3.ImageUrl = TextBox3.Text + "?imageMogr2/auto-orient/strip/thumbnail/!30p";
            TextBox3.Text = Image3.ImageUrl;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Image4.ImageUrl = TextBox4.Text + "?imageMogr2/auto-orient/strip/thumbnail/!50px";
            TextBox4.Text = Image4.ImageUrl;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
           Image5.ImageUrl = TextBox5.Text + "?imageMogr2/auto-orient/strip/thumbnail/150x";
           TextBox5.Text = Image5.ImageUrl;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Image6.ImageUrl = TextBox6.Text + "?imageMogr2/auto-orient/strip/thumbnail/300x300";
            TextBox6.Text = Image6.ImageUrl;
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Image7.ImageUrl = TextBox7.Text + "?imageMogr2/auto-orient/strip/thumbnail/500x500!";
            TextBox7.Text = Image7.ImageUrl; 
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Image8.ImageUrl = TextBox8.Text + "?imageMogr2/auto-orient/strip/thumbnail/500x500!";
            TextBox8.Text = Image8.ImageUrl; 
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Image9.ImageUrl = TextBox9.Text + "?imageMogr2/auto-orient/strip/thumbnail/500x500!/gravity/North/crop/300x300";
            TextBox9.Text = Image9.ImageUrl; 
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Image10.ImageUrl = TextBox10.Text + "?imageMogr2/gravity/North/crop/300x300/auto-orient/strip/thumbnail/500x500!";
            TextBox10.Text = Image10.ImageUrl; 
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            Image11.ImageUrl = TextBox11.Text + "?imageMogr2/rotate/45";
            TextBox11.Text = Image11.ImageUrl; 
        }



    }
}