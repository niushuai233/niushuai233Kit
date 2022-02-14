using Google.Cloud.Translation.V2;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using niushuai233Kit.Entity.Settings;
using niushuai233Kit.Entity.Translation;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace niushuai233Kit.Util
{
    public class TranslationUtil
    {
        public static TranslationSettings settings = new TranslationSettings();

        /// <summary>
        /// Google 翻译
        /// </summary>
        /// <param name="source">待翻译文本</param>
        /// <param name="specifiedSourceLanguage">源语言</param>
        /// <param name="targetLanguage">目标语言</param>
        /// <returns>封装好的翻译结果</returns>
        public static TranslationResponse GoogleTranslate(string source, string targetLanguage, string specifiedSourceLanguage = null)
        {
            TranslationResponse response;

            if (settings == null || StringUtil.IsEmpty(settings.GoogleApiKey))
            {
                return response = new TranslationResponse()
                {
                    Success = false,
                    ErrorMessage = "请先设置 Google ApiKey"
                };
            }

            try
            {
                TranslationClient client = TranslationClient.CreateFromApiKey(settings.GoogleApiKey);
                TranslationResult result = client.TranslateText(source, targetLanguage, specifiedSourceLanguage);

                return response = new TranslationResponse()
                {
                    Success = true,
                    OriginalText = source,
                    TranslatedText = result.TranslatedText,
                    DetectedSourceLanguage = result.DetectedSourceLanguage,
                    SpecifiedSourceLanguage = result.SpecifiedSourceLanguage,
                    TargetLanguage = result.TargetLanguage
                };
            }
            catch (Exception e)
            {
                return response = new TranslationResponse()
                {

                    Success = false,
                    ErrorMessage = e.Message
                };
            }
        }

        public static TranslationResponse BaiduTranslate(string source, string targetLanguage, string specifiedSourceLanguage = null)
        {

            // 改成您的APP ID
            string appId = settings.BaiduAppId;
            Random rd = new Random();
            string salt = rd.Next(100000).ToString();
            // 改成您的密钥
            string secretKey = settings.BaiduAppSecretKey;
            string sign = EncryptString(appId + source + salt + secretKey);
            string url = "http://api.fanyi.baidu.com/api/trans/vip/translate?";
            url += "q=" + HttpUtility.UrlEncode(source);
            url += "&from=" + specifiedSourceLanguage;
            url += "&to=" + targetLanguage;
            url += "&appid=" + appId;
            url += "&salt=" + salt;
            url += "&sign=" + sign;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";
            request.UserAgent = null;
            request.Timeout = 6000;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();
            Console.WriteLine(retString);
            return Transform(retString);
        }

        private static TranslationResponse Transform(string source)
        {
            try
            {


                Dictionary<string, object> dict = JsonConvert.DeserializeObject<Dictionary<string, object>>(source);

                if (dict.ContainsKey("error_code"))
                {
                    // 翻译失败
                    return new TranslationResponse()
                    {
                        Success = false,
                        ErrorMessage = dict["error_code"].ToString() + ": " + dict["error_msg"].ToString()
                    };
                }

                JArray transResult = (JArray)dict["trans_result"];

                //transResultDict["src"];
                //transResultDict["dst"];

                return new TranslationResponse()
                {
                    Success = true,
                    OriginalText = source,
                    TranslatedText = (string)(transResult[0]["dst"]),
                    DetectedSourceLanguage = (string)dict["to"],
                    SpecifiedSourceLanguage = (string)dict["from"],
                    TargetLanguage = (string)dict["to"]
                };
            }
            catch (Exception e)
            {
                return new TranslationResponse()
                {
                    Success = false,
                    ErrorMessage = e.Message
                };
            }
        }

        /// <summary>
        /// 计算MD5值
        /// </summary>
        public static string EncryptString(string str)
        {
            MD5 md5 = MD5.Create();
            // 将字符串转换成字节数组
            byte[] byteOld = Encoding.UTF8.GetBytes(str);
            // 调用加密方法
            byte[] byteNew = md5.ComputeHash(byteOld);
            // 将加密结果转换为字符串
            StringBuilder sb = new StringBuilder();
            foreach (byte b in byteNew)
            {
                // 将字节转换成16进制表示的字符串，
                sb.Append(b.ToString("x2"));
            }
            // 返回加密的字符串
            return sb.ToString();
        }
    }
}
