using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.IO;

namespace WebApplication1
{
    public partial class callbackFetchKey : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
     
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            NameValueCollection formData=new NameValueCollection();
            tokenning token = new tokenning();
            string to = token.getToken_for_fetchkey();
            token.getToken_for_fetchkey();
            formData.Add("token",to);
            formData.Add("key", "123456789.jpg");
            formData.Add("accept", "");
            formData.Add("fileName", "123456789.jpg");
            string s= multipart.MultiPost("http://upload.qiniu.com", formData, "A:\\buty-picture\\123456789.jpg");
            TextBox1.Text= ProcessRequest();

		}



        
        public string ProcessRequest()
        {
            
            try
            {
                System.IO.Stream s = Request.InputStream;
                int count = 0;
                byte[] buffer = new byte[1024];
                StringBuilder builder = new StringBuilder();
                while ((count = s.Read(buffer, 0, 1024)) > 0)
                {
                    builder.Append(Encoding.UTF8.GetString(buffer, 0, count));
                }
                s.Flush();
                s.Close();
                s.Dispose();
                return builder.ToString();
            }
            catch (Exception ex)
            { throw ex; }

        }


        
    }
}