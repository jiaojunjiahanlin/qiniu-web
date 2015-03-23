using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace WebApplication1.IO
{
    public static class https
    {

        
          public static string GetRequestData(string sUrl)
        {
            //使用HttpWebRequest类的Create方法创建一个请求到uri的对象。
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(sUrl);
            //指定请求的方式为Get方式
            request.Method = WebRequestMethods.Http.Get;
            //获取该请求所响应回来的资源，并强转为HttpWebResponse响应对象
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            //获取该响应对象的可读流
            StreamReader reader = new StreamReader(response.GetResponseStream());
            //将流文本读取完成并赋值给str
            string str = reader.ReadToEnd();
            //关闭响应
            response.Close();
            return str;
        
    }
          public static string CallbackData(string sUrl)
          {
              //使用HttpWebRequest类的Create方法创建一个请求到uri的对象。
              HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(sUrl);
              //指定请求的方式为Get方式

              request.Method = WebRequestMethods.Http.Get;	
		
              //获取该请求所响应回来的资源，并强转为HttpWebResponse响应对象
              HttpWebResponse response = (HttpWebResponse)request.GetResponse();
              //获取该响应对象的可读流
              StreamReader reader = new StreamReader(response.GetResponseStream());
              //将流文本读取完成并赋值给str
              string str = reader.ReadToEnd();
            while (str!=null) {
                return str;
		}
      
              //关闭响应
              response.Close();
              return str;

          }
        public  static void  httppost()
        {
         string strId = "guest";
            string strPassword = "123456";

            ASCIIEncoding encoding = new ASCIIEncoding();
            string postData = "userid=" + strId;
            postData += ("&password=" + strPassword);

            byte[] data = encoding.GetBytes(postData);

            // Prepare web request...
            HttpWebRequest myRequest =
            (HttpWebRequest)WebRequest.Create("http://www.here.com/login.asp");

            myRequest.Method = "POST";
            myRequest.ContentType = "application/x-www-form-urlencoded";
            myRequest.ContentLength = data.Length;
            Stream newStream = myRequest.GetRequestStream();

            // Send the data.
            newStream.Write(data, 0, data.Length);
            newStream.Close();

            // Get response
            HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
            StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.Default);
            string content = reader.ReadToEnd();
            Console.WriteLine(content); 
        }
        //模拟表单上传，发送http请求
        public static void httpUp()
        {
            string strId = "guest";
            string strPassword = "123456";

            ASCIIEncoding encoding = new ASCIIEncoding();
            string postData = "userid=" + strId;
            postData += ("&password=" + strPassword);

            byte[] data = encoding.GetBytes(postData);

            // Prepare web request...
            HttpWebRequest myRequest =
            (HttpWebRequest)WebRequest.Create("http://www.here.com/login.asp");

            myRequest.Method = "POST";
            myRequest.Host = "upload.qiniu.com";
            myRequest.ContentType = "multipart/form-data";
            myRequest.ContentLength = data.Length;
            Stream newStream = myRequest.GetRequestStream();
            // Send the data.
            newStream.Write(data, 0, data.Length);
            newStream.Close();

            // Get response
            HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
            StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.Default);
            string content = reader.ReadToEnd();
            Console.WriteLine(content);
        }
        //不完整。
        public static  void httpmkblk()
        {
         

            ASCIIEncoding encoding = new ASCIIEncoding();
            string postData = "";

            byte[] data = encoding.GetBytes(postData);

            // Prepare web request...
            HttpWebRequest myRequest =(HttpWebRequest)WebRequest.Create("http://www.here.com/login.asp");
            myRequest.Method = "POST";
            myRequest.ContentType = "application/x-www-form-urlencoded";
            myRequest.ContentLength = data.Length;
            Stream newStream = myRequest.GetRequestStream();

            // Send the data.
            newStream.Write(data, 0, data.Length);
            newStream.Close();

            // Get response
            HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
            StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.Default);
            string content = reader.ReadToEnd();
            Console.WriteLine(content);
        }
        //fetch
        public  static void http_fetch(string encodeUrl , string encodeEntryUrl)
        {

            string AccessToken = "";
            ASCIIEncoding encoding = new ASCIIEncoding();
            string postUrl = "http://" + "iovip.qbox.me" + "/fetch/" + encodeUrl + "/to/" + encodeEntryUrl;
            AccessToken = tokenning.acess_token("/fetch/" + encodeUrl + "/to/" + encodeEntryUrl);

           // byte[] data = encoding.GetBytes();

            // Prepare web request...
            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(postUrl);
            myRequest.Method = "POST";
            myRequest.Headers.Add("Authorization", "QBox "+AccessToken);
            myRequest.ContentType = "application/x-www-form-urlencoded";
           // myRequest.ContentLength = data.Length;
            Stream newStream = myRequest.GetRequestStream();

            // Send the data.
           // newStream.Write(data, 0, data.Length);
            newStream.Close();

            // Get response
            HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
            StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.Default);
            string content = reader.ReadToEnd();
            Console.WriteLine(content);
        }

        public static string fetch_Get(string encodeUrl, string encodeEntryUrl)
        {
            string AccessToken = "";
            ASCIIEncoding encoding = new ASCIIEncoding();
            string getUrl = "http://" + "iovip.qbox.me" + "/fetch/" + encodeUrl + "/to/" + encodeEntryUrl;
            //使用HttpWebRequest类的Create方法创建一个请求到uri的对象。
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(getUrl);
            //指定请求的方式为Get方式
            request.Method = WebRequestMethods.Http.Get;
            request.ContentType = "application/x-www-form-urlencoded";
            AccessToken = tokenning.acess_token("/fetch/" + encodeUrl + "/to/" + encodeEntryUrl);
            request.Headers.Add("Authorization", "QBox "+AccessToken);
          
            //获取该请求所响应回来的资源，并强转为HttpWebResponse响应对象
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            //获取该响应对象的可读流
            StreamReader reader = new StreamReader(response.GetResponseStream());
            //将流文本读取完成并赋值给str
            string str = reader.ReadToEnd();
            //关闭响应
            response.Close();
            return str;

        }
        public static string http_pfop( string postData)
        {
            Encoding encoding = System.Text.Encoding.UTF8;
            byte[] data = encoding.GetBytes(postData);
            string AccessToken = "";
            Stream outstream = null;
            string getUrl = "http://" + "api.qiniu.com" + "/pfop/";
            //使用HttpWebRequest类的Create方法创建一个请求到uri的对象。
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(getUrl);
            //指定请求的方式为Get方式
            request.Method = WebRequestMethods.Http.Post;
            request.Host = "api.qiniu.com";
            request.ContentType = "application/x-www-form-urlencoded";
            AccessToken = tokenning.acess_token1("/pfop/\n"+postData);
            request.Headers.Add("Authorization", "QBox " + AccessToken);
            request.ContentLength = data.Length;
            outstream = request.GetRequestStream();
           outstream.Write(data, 0, data.Length);
            outstream.Close();

            //获取该请求所响应回来的资源，并强转为HttpWebResponse响应对象
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            //获取该响应对象的可读流
            StreamReader reader = new StreamReader(response.GetResponseStream());
            //将流文本读取完成并赋值给str
            string str = reader.ReadToEnd();
            //关闭响应
            response.Close();
            return str;
        }
       
    }
}