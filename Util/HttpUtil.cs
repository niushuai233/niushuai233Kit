using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace niushuai233Kit.Util
{
    public class HttpUtil
    {
        private const string USER_AGENT = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/96.0.4664.45 Safari/537.36";

        private const string METHOD_GET = "GET";

        private const string METHOD_POST = "POST";

        public static T Get<T>(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = METHOD_GET;
            request.ContentType = "text/html;charset=UTF-8";
            request.UserAgent = USER_AGENT;
            request.Timeout = 10000;

            HttpWebResponse response = (HttpWebResponse) request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));

            string retString = myStreamReader.ReadToEnd();

            Console.WriteLine("retString = {0}", retString);

            myStreamReader.Close();
            myResponseStream.Close();

            return JsonConvert.DeserializeObject<T>(retString);
        }
    }
}

