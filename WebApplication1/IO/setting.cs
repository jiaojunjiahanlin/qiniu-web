using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.Text;
using System.Security.Cryptography;

namespace WebApplication1.IO
{
    public static class setting
    {
        public static String AK = "dL3iWMKzQMTap8Puxi5XcUgqzuKjCukchqkXHcIR";
        public static String SK = "fOW181hnBdkCOdM5Tpm7anPv0dwxDCvMuKIBVvk1";
        private static string token = "";

    
        public static string  setjson(object obj)
        {
            JsonSerializerSettings setting = new JsonSerializerSettings();
            setting.NullValueHandling = NullValueHandling.Ignore;
            return JsonConvert.SerializeObject(obj, setting);
        }
        public static T ToObject<T>(string value)
        {
            return JsonConvert.DeserializeObject<T>(value);
        }

        public static string Bs64(string s)
        {
            System.Text.Encoding encoding = System.Text.Encoding.UTF8;
            Byte[] bytes = encoding.GetBytes(s);
            s = Convert.ToBase64String(bytes);
            s = s.Replace('+', '-').Replace('/', '_');
            return s;
        }
        public static string  token_sign(string s)
        {
            System.Text.Encoding encoding = System.Text.Encoding.UTF8;
            byte[] bytesSK = encoding.GetBytes(SK);
            HMACSHA1 hmac = new HMACSHA1(bytesSK);
            byte[] ss = encoding.GetBytes(s);
            byte[] digest = hmac.ComputeHash(ss);
            s = Convert.ToBase64String(digest);
            s = s.Replace('+', '-').Replace('/', '_');
            return s;
        }
    }
    
}