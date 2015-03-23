using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.IO;

namespace WebApplication1.pfop
{
    public partial class pfop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            string bucket = "liuhanlin-work";
            string key = "xiangeiailisi.mp3";
            signning si = new signning();
            string savekey = "saveas/" + si.getEncode(bucket, "amr.amr");
            string fops = "avthumb/amr" + "|" + savekey;
            //string notifyURL = "https://3193fe3ceb.b.passageway.io/notifyURL.ashx";
            string notifyURL = "http://baidu.com";
            object[] str =new object[6];

            str[0] = HttpUtility.UrlEncode(bucket);
            str[1] = HttpUtility.UrlEncode(key);
            str[2] = HttpUtility.UrlEncode(fops);
            str[3] = HttpUtility.UrlEncode(notifyURL);
            
            
            TextBox1.Text
             = "bucket=@&key=@&fops=<urlEncodedFops>&notifyURL=&force=1&pipeline=xiaoliu";
            TextBox1.Text = string.Format("bucket={0}&key={1}&fops={2}&notifyURL={3}&force=1&pipeline=xiaoliu", str[0], str[1], str[2], str[3]);

            TextBox2.Text = https.http_pfop(TextBox1.Text);  

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string bucket = "liuhanlin-work";
            string key = "haohaode.svg";
            string savekey = "";
            signning si=new signning();
            savekey = "saveas/" + si.getEncode(bucket, "huaihuaide.jpg");
            
            string fops = "imageMogr2/format/jpg"+"|"+savekey;
            string notifyURL = "https://1f553e2b58f9.a.passageway.io/notifyURL.ashx";
            //string notifyURL = "http://baidu.com";
            object[] str = new object[6];

            str[0] = HttpUtility.UrlEncode(bucket);
            str[1] = HttpUtility.UrlEncode(key);
            str[2] = HttpUtility.UrlEncode(fops);
            str[3] = HttpUtility.UrlEncode(notifyURL);

            TextBox3.Text = string.Format("bucket={0}&key={1}&fops={2}&notifyURL={3}&force=1&pipeline=xiaoliu", str[0], str[1], str[2], str[3]);

            TextBox4.Text = https.http_pfop(TextBox3.Text);  
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            
            string bucket = "liuhanlin-work";
            string key = "0161774b-c421-416d-b8e5-8bd9eaabed0a";
            string savekey = "";
            signning si=new signning();
            savekey = "saveas/" + si.getEncode(bucket, "xiaoshidai.mp4");

            string fops = "avthumb/mp4/s/50x50" + "|" + savekey;
            string notifyURL = "https://33984617651e.a.passageway.io/notifyURL.ashx";
            //string notifyURL = "http://baidu.com";
            object[] str = new object[6];

            str[0] = HttpUtility.UrlEncode(bucket);
            str[1] = HttpUtility.UrlEncode(key);
            str[2] = HttpUtility.UrlEncode(fops);
            str[3] = HttpUtility.UrlEncode(notifyURL);

            TextBox5.Text = string.Format("bucket={0}&key={1}&fops={2}&notifyURL={3}&force=1&pipeline=xiaoliu", str[0], str[1], str[2], str[3]);

            TextBox6.Text = https.http_pfop(TextBox5.Text);  
        
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string s = "http://api.qiniu.com/status/get/prefop?id=" + TextBox7.Text;
            TextBox8.Text=https.GetRequestData(s);

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string bucket = "liuhanlin-work";
            string key = "xiaoxiao.mp4";
            string savekey = "";
            signning si = new signning();
            savekey = "saveas/" + si.getEncode(bucket, "dada.mp4");

            string fops = "avthumb/flv/ar/44100/an/1" + "|" + savekey;
            string notifyURL = "https://33984617651e.a.passageway.io/notifyURL.ashx";
            //string notifyURL = "http://baidu.com";
            object[] str = new object[6];

            str[0] = HttpUtility.UrlEncode(bucket);
            str[1] = HttpUtility.UrlEncode(key);
            str[2] = HttpUtility.UrlEncode(fops);
            str[3] = HttpUtility.UrlEncode(notifyURL);

            TextBox9.Text = string.Format("bucket={0}&key={1}&fops={2}&notifyURL={3}&force=1&pipeline=xiaoliu", str[0], str[1], str[2], str[3]);

            TextBox10.Text = https.http_pfop(TextBox9.Text);  
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            string bucket = "liuhanlin-work";
            string key = "0161774b-c421-416d-b8e5-8bd9eaabed0a";
            string savekey = "";
            signning si = new signning();
            savekey = "saveas/" + si.getEncode(bucket, "jiequ.mp4");
           // string imageurl="http://liuhanlin-work.qiniudn.com/watermark.jpg";

            string imageurl = "http://liuhanlin-work.qiniudn.com/-QQ截图20140701114124.png";

            System.Text.Encoding encoding = System.Text.Encoding.UTF8;
            imageurl=  Convert.ToBase64String(encoding.GetBytes(imageurl));

            imageurl = si.getBase64Encode(imageurl);
            string fops = "avthumb/mp4/wmImage/"+imageurl+"/seekstart/10/t/5" + "|" + savekey;
            string notifyURL = "https://3b770121f945.a.passageway.io/notifyURL.ashx";
            //string notifyURL = "http://baidu.com";
            object[] str = new object[6];

            str[0] = HttpUtility.UrlEncode(bucket);
            str[1] = HttpUtility.UrlEncode(key);
            str[2] = HttpUtility.UrlEncode(fops);
            str[3] = HttpUtility.UrlEncode(notifyURL);

            TextBox11.Text = string.Format("bucket={0}&key={1}&fops={2}&notifyURL={3}&force=1&pipeline=xiaoliu", str[0], str[1], str[2], str[3]);
            TextBox12.Text = https.http_pfop(TextBox11.Text);  
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            string bucket = "liuhanlin-work";
            string key = "weiaichikuang.mp3";
            string savekey = "";
            signning si = new signning();
            savekey = "saveas/" + si.getEncode(bucket, "12345678.mp3");
            string imageurl = "http://liuhanlin-work.qiniudn.com/watermark.jpg";

            imageurl = si.getBase64Encode(imageurl);
            string fops = "avthumb/mp3/wmImage/" + imageurl  + "|" + savekey;
            string notifyURL = "https://33984617651e.a.passageway.io/notifyURL.ashx";
            //string notifyURL = "http://baidu.com";
            object[] str = new object[6];

            str[0] = HttpUtility.UrlEncode(bucket);
            str[1] = HttpUtility.UrlEncode(key);
            str[2] = HttpUtility.UrlEncode(fops);
            str[3] = HttpUtility.UrlEncode(notifyURL);

            TextBox13.Text = string.Format("bucket={0}&key={1}&fops={2}&notifyURL={3}&force=1&pipeline=xiaoliu", str[0], str[1], str[2], str[3]);
            TextBox14.Text = https.http_pfop(TextBox13.Text);  
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            string bucket = "liuhanlin-work";
            string key = "weiaichikuang.mp3";
            string savekey = "";
            signning si = new signning();
            savekey = "saveas/" + si.getEncode(bucket, "yinpinzhuanma.mp3");

            string fops = "avthumb/amr/ab/12.20k" + "|" + savekey;
            string notifyURL = "https://33984617651e.a.passageway.io/notifyURL.ashx";
            //string notifyURL = "http://baidu.com";
            object[] str = new object[6];

            str[0] = HttpUtility.UrlEncode(bucket);
            str[1] = HttpUtility.UrlEncode(key);
            str[2] = HttpUtility.UrlEncode(fops);
            str[3] = HttpUtility.UrlEncode(notifyURL);

            TextBox15.Text = string.Format("bucket={0}&key={1}&fops={2}&notifyURL={3}&force=1&pipeline=xiaoliu", str[0], str[1], str[2], str[3]);

            TextBox16.Text = https.http_pfop(TextBox15.Text);  
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            string bucket = "liuhanlin-work";
            string key = "haoxianggaosuni1.mp4";
            string savekey1 = "";
            string savekey2 = "";
            signning si = new signning();
            savekey1 = "saveas/" + si.getEncode(bucket, "haoxiang.jpg");
            savekey2 = "saveas/" + si.getEncode(bucket, "jiajia.txt");

            string fops = "avthumb/m3u8/segtime/10/preset/video_16x9_440k|"+savekey2+";vframe/jpg/offset/20/w/480/h/360" + "|" + savekey1;
            string notifyURL = "https://33984617651e.a.passageway.io/notifyURL.ashx";
            //string notifyURL = "http://baidu.com";
            object[] str = new object[6];

            str[0] = HttpUtility.UrlEncode(bucket);
            str[1] = HttpUtility.UrlEncode(key);
            str[2] = HttpUtility.UrlEncode(fops);
            str[3] = HttpUtility.UrlEncode(notifyURL);

            TextBox17.Text = string.Format("bucket={0}&key={1}&fops={2}&notifyURL={3}&force=1&pipeline=xiaoliu", str[0], str[1], str[2], str[3]);

            TextBox18.Text = https.http_pfop(TextBox17.Text);  
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            string bucket = "liuhanlin-work";
            string key = "haoxianggaosuni1.mp4";
            string savekey1 = "";
            signning si = new signning();
            savekey1 = "saveas/" + si.getEncode(bucket, "video_240.txt");
            string fops = "avthumb/m3u8/segtime/20/video_240k" + "|" + savekey1;
            string notifyURL = "https://33984617651e.a.passageway.io/notifyURL.ashx";
            //string notifyURL = "http://baidu.com";
            object[] str = new object[6];
            str[0] = HttpUtility.UrlEncode(bucket);
            str[1] = HttpUtility.UrlEncode(key);
            str[2] = HttpUtility.UrlEncode(fops);
            str[3] = HttpUtility.UrlEncode(notifyURL);
            TextBox19.Text = string.Format("bucket={0}&key={1}&fops={2}&notifyURL={3}&force=1&pipeline=xiaoliu", str[0], str[1], str[2], str[3]);
            TextBox20.Text = https.http_pfop(TextBox19.Text);  
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            string bucket = "seweizhi";
            string key = "dushulang.mp4";
            string savekey1 = "";
            signning si = new signning();
            savekey1 = "saveas/" + si.getEncode(bucket, "dushulang_test01.m3u8");
            string fops = "avthumb/m3u8/segtime/20/" + "|" + savekey1;
            string notifyURL = "https://daeb3e14ab.b.passageway.io/notifyURL.ashx";
            object[] str = new object[6];
            str[0] = HttpUtility.UrlEncode(bucket);
            str[1] = HttpUtility.UrlEncode(key);
            str[2] = HttpUtility.UrlEncode(fops);
            str[3] = HttpUtility.UrlEncode(notifyURL);
            TextBox21.Text = string.Format("bucket={0}&key={1}&fops={2}&notifyURL={3}&force=1&pipeline=xiaoliu", str[0], str[1], str[2], str[3]);
            TextBox22.Text = https.http_pfop(TextBox21.Text);  
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            string bucket = "liuhanlin-work";
            string key = "woshibushigaianjingdezoukai.mp4";
            string savekey1 = "";
            signning si = new signning();
            savekey1 = "saveas/" + si.getEncode(bucket, "liuhanlin-movi");
            string fops = "avthumb/mp4/vcodec/libx264" + "|" + savekey1;
            string notifyURL = "https://3b770121f945.a.passageway.io/notifyURL.ashx";
            object[] str = new object[6];
            str[0] = HttpUtility.UrlEncode(bucket);
            str[1] = HttpUtility.UrlEncode(key);
            str[2] = HttpUtility.UrlEncode(fops);
            str[3] = HttpUtility.UrlEncode(notifyURL);
            TextBox23.Text = string.Format("bucket={0}&key={1}&fops={2}&notifyURL={3}&force=1&pipeline=xiaoliu", str[0], str[1], str[2], str[3]);
            TextBox24.Text = https.http_pfop(TextBox23.Text); 
        }

    }
}