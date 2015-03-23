using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.IO;

namespace WebApplication1.manage
{
    public partial class fetch : System.Web.UI.Page
    {
        string tx1 = "";
        string entry="";
        string encodedEntryURI = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            tx1 = TextBox1.Text;
            tx1=setting.Bs64(tx1);
            entry ="liuhanlin-work:fetch.jpg";
            encodedEntryURI = setting.Bs64(entry);
            https.fetch_Get(tx1, encodedEntryURI);

        }
    }
}