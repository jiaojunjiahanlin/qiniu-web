using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace WebApplication1.IO
{
    public class signning
    {
        String AK = "dL3iWMKzQMTap8Puxi5XcUgqzuKjCukchqkXHcIR";
        String SK = "fOW181hnBdkCOdM5Tpm7anPv0dwxDCvMuKIBVvk1";
        String domen = "liuhanlin-work.qiniudn.com/";
        String NewURL = "";
        String sign = "";
        String operation = "";
        String FinalURL = "";

        public String Operation
        {
            get { return operation; }
            set { operation = value; }
        }
    
        public String getEncode(String bucket,String key)
        {
            String EncodedEntryURI = "";
            String entry = bucket+":"+key;
            Byte[] bytes = Encoding.Default.GetBytes(entry); 
            EncodedEntryURI = Convert.ToBase64String(bytes);
            System.Console.WriteLine("EncodedEntryURI"+EncodedEntryURI);
            return EncodedEntryURI;
        }
        public String getBase64Encode( String key)
        {
            String EncodedEntryURI = "";
            String entry = key;
            Byte[] bytes = Encoding.Default.GetBytes(entry);
            EncodedEntryURI = Convert.ToBase64String(bytes);
            System.Console.WriteLine("EncodedEntryURI" + EncodedEntryURI);
            return EncodedEntryURI;
        }
        public String getSign(String bucket , String key)
        {
           NewURL = domen + key + Operation + "%7csaveas/" + getEncode(bucket, key);
           System.Text.Encoding encoding = System.Text.Encoding.UTF8;
           byte[] bytesNewURL = encoding.GetBytes(NewURL);
           byte[] bytesSK = encoding.GetBytes(SK);
           HMACSHA1 hmac = new HMACSHA1(bytesSK);
           byte[] digest = hmac.ComputeHash(bytesNewURL);
           sign =Convert.ToBase64String(digest);
           sign = sign.Replace('+', '-').Replace('/', '_');
           FinalURL = "http://"+NewURL + "/sign/" + AK + ":" + sign;
           return FinalURL;
        
        }
        public String getAccessSign(String s)
        {
           
            System.Text.Encoding encoding = System.Text.Encoding.UTF8;
            byte[] bytesNewURL = encoding.GetBytes(s);
            byte[] bytesSK = encoding.GetBytes(SK);
            HMACSHA1 hmac = new HMACSHA1(bytesSK);
            byte[] digest = hmac.ComputeHash(bytesNewURL);
            sign = Convert.ToBase64String(digest);
            sign = sign.Replace('+', '-').Replace('/', '_');
            FinalURL = AK + ":" + sign;
            return FinalURL;

        }
         

    }
}