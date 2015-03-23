using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace WebApplication1.IO
{
    public static class multipart
    {

        public static string RandomBoundary()
        {
            return String.Format("----------{0:N}", Guid.NewGuid());
        }

        public static string FormDataContentType(string boundary)
        {
            return "multipart/form-data; boundary=" + boundary;
        }

        private static Stream GetPostStream(Stream putStream, string fileName, NameValueCollection formData, string boundary)
        {
            Stream postDataStream = new System.IO.MemoryStream();

            //adding form data

            string formDataHeaderTemplate = Environment.NewLine + "--" + boundary + Environment.NewLine +
                "Content-Disposition: form-data; name=\"{0}\";" + Environment.NewLine + Environment.NewLine + "{1}";

            foreach (string key in formData.Keys)
            {
                byte[] formItemBytes = System.Text.Encoding.UTF8.GetBytes(string.Format(formDataHeaderTemplate,
                                                                                                    key, formData[key]));
                postDataStream.Write(formItemBytes, 0, formItemBytes.Length);
            }

            //adding file,Stream data
            #region adding file data

            string fileHeaderTemplate = Environment.NewLine + "--" + boundary + Environment.NewLine +
                "Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"" +
                Environment.NewLine + "Content-Type: application/octet-stream" + Environment.NewLine + Environment.NewLine;
            byte[] fileHeaderBytes = System.Text.Encoding.UTF8.GetBytes(string.Format(fileHeaderTemplate,
                                                                                               "file", fileName));
            postDataStream.Write(fileHeaderBytes, 0, fileHeaderBytes.Length);

            byte[] buffer = new byte[1024];
            int bytesRead = 0;
            while ((bytesRead = putStream.Read(buffer, 0, buffer.Length)) != 0)
            {
                postDataStream.Write(buffer, 0, bytesRead);
            }
            putStream.Close();
            #endregion

            #region adding end
            byte[] endBoundaryBytes = System.Text.Encoding.UTF8.GetBytes(Environment.NewLine + "--" + boundary + "--" + Environment.NewLine);
            postDataStream.Write(endBoundaryBytes, 0, endBoundaryBytes.Length);
            #endregion

            return postDataStream;

        }

        public static string  MultiPost(string url, NameValueCollection formData, string fileName)
        {
            string boundary = RandomBoundary();
            System.Net.WebRequest webRequest = System.Net.WebRequest.Create(url);

            webRequest.Method = "POST";
            webRequest.ContentType = "multipart/form-data; boundary=" + boundary;
            FileInfo fileInfo = new FileInfo(fileName);

            using (FileStream fileStream = fileInfo.OpenRead())
            {

                Stream postDataStream = GetPostStream(fileStream, fileName, formData, boundary);
                webRequest.ContentLength = postDataStream.Length;
                Stream reqStream = webRequest.GetRequestStream();
                postDataStream.Position = 0;

                byte[] buffer = new byte[1024];
                int bytesRead = 0;

                while ((bytesRead = postDataStream.Read(buffer, 0, buffer.Length)) != 0)
                {
                    reqStream.Write(buffer, 0, bytesRead);
                }
                postDataStream.Close();
                reqStream.Close();
            }
            try
            {
                using (HttpWebResponse response = webRequest.GetResponse() as HttpWebResponse)
                {

                    System.IO.Stream s = response.GetResponseStream();
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
                string str = builder.ToString();
               System.Console.WriteLine(str);
               return str;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return e.ToString();
            }
        }
    }
}