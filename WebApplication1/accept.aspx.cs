using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class accept : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
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
                    Label1.Text = builder.ToString();
                }
                catch (Exception ex)
               { throw ex; }
            }

        }

    }
