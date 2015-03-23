using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.IO
{
    public class tokenning
    {
        private static String token = "";
        private string putpolicy = "";
        private string encodedPutPolicy = "";
        private string encodedSign = "";
        string signingStr = "";

        public string Putpolicy
        {
            get { return putpolicy; }
            set { putpolicy = value; }
        }

        public static String Token
        {
            get { return tokenning.token; }
            set { tokenning.token = value; }
        }
        public String getToken()
        {

            Policy policy = new Policy("liuhanlin-work");
          //  policy.Deadline=1390528576;
          //  policy.PersistentNotifyUrl="";
           // policy.Scope = "liuhanlin-work:-123456.jpg";
           // policy.PersistentOps="avthumb/mp4";
           // policy.Scope = "liuhanlin-work";
          //  policy.SaveKey = "Chrysanthemum,c_fill,w_60,h_90.jpg";
           // policy.InsertOnly = 1;
            policy.ReturnBody = "location=$(x:hello)";
            Putpolicy = policy.ToString();
            System.Console.WriteLine(Putpolicy);
            encodedPutPolicy = setting.Bs64(Putpolicy);
            System.Console.WriteLine(encodedPutPolicy);
            encodedSign=setting.token_sign(encodedPutPolicy);
            System.Console.WriteLine(encodedSign);
            Token = setting.AK + ':'+ encodedSign + ":"+ encodedPutPolicy;
            return Token;
        }
        public String getToken_for_fetchkey()
        {

            Policy policy = new Policy("liuhanlin-work");
            //  policy.Deadline=1390528576;
           // policy.PersistentNotifyUrl = "";
            policy.CallbackUrl = "https://21d1153c5b9.a.passageway.io/Handler1.ashx";
            policy.CallbackBody = "key=$(key)&hash=$(etag)&w=$(imageInfo.width)&h=$(imageInfo.height)";
            policy.CallbackBodyType = "application/x-www-form-urlencoded";
            policy.CallbackFetchKey = 1;
            Putpolicy = policy.ToString();
            System.Console.WriteLine(Putpolicy);
            encodedPutPolicy = setting.Bs64(Putpolicy);
            System.Console.WriteLine(encodedPutPolicy);
            encodedSign = setting.token_sign(encodedPutPolicy);
            System.Console.WriteLine(encodedSign);
            Token = setting.AK + ':' + encodedSign + ":" + encodedPutPolicy;
            return Token;
        }
        public String getToken_for_download(string url)
        {
            string url1="http://jiuge.qiniudn.com/"+url+ "?e=" + ((UInt32)((DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000000 + (long)(3600))).ToString();
            url = "http://jiuge.qiniudn.com/"+url + "?imageView2/1/w/200/h/200&" + "e=" + ((UInt32)((DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000000 + (long)(3600))).ToString();
             

            encodedSign = setting.token_sign(url);
            System.Console.WriteLine(encodedSign);
            Token = setting.AK + ':' + encodedSign ;
            url = url + "&token=" + Token;
            return url;
        }
        public  static string acess_token(string s)
        {
            string signingStr = s+"\n";
            signning si = new signning();
            signingStr=si.getAccessSign(signingStr);
            return signingStr;
        }
        public static string acess_token1(string s)
        {
            string signingStr = s ;
            signning si = new signning();
            signingStr = si.getAccessSign(signingStr);
            return signingStr;
        }
        
       

    }
}