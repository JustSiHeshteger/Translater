using System.Collections.Specialized;
using System.IO;
using System.Net;

namespace Translater.Model
{
    internal class WebRequestForTranslate
    {
        public string URL { get; set; }
        public string JSON { get; set; }
        public string Method { get; set; }
        public string Token { get; set; }
        public string GetRequest()
        {
            var header = new NameValueCollection()
            {
                { "Authorization", $"Bearer {Token}" }
            };

            //var httpWebRequest = (HttpWebRequest)WebRequest.Create(this.URL); Для .NET Core
            //httpWebRequest.Headers.Add(header);
            //httpWebRequest.Method = this.Method;
            
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(Properties.Settings.Default.URL);
            httpWebRequest.Headers.Add(header);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(this.JSON);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                return streamReader.ReadToEnd();
            }
        }
    }
}
