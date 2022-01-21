using System;
using System.Text;
using System.Web;

namespace niushuai233Kit.Util
{
    public class EncrypyUtil
    {

        /// <summary>
        /// 解码
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string Base64Decode(string text)
        {
            if (StringUtil.IsNotEmpty(text))
            {
                byte[] bytes = Convert.FromBase64String(text);
                return Encoding.UTF8.GetString(bytes);
            }
            return "";
        }

        /// <summary>
        /// 转码
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string Base64Encode(string text)
        {
            if (StringUtil.IsNotEmpty(text)) {
                byte[] bytes = Encoding.UTF8.GetBytes(text);
                return Convert.ToBase64String(bytes);
            }
            return "";
        }

        /// <summary>
        /// url encode
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string UrlEncode(string text)
        {
            if (StringUtil.IsNotEmpty(text))
            {
                return HttpUtility.UrlEncode(text);
            }
            return "";
        }

        /// <summary>
        /// url decode
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string UrlDecode(string text)
        {
            if (StringUtil.IsNotEmpty(text))
            {
                return HttpUtility.UrlDecode(text);
            }
            return "";
        }

        public static string EscapeEncode(string text)
        {
            if (StringUtil.IsNotEmpty(text))
            {
                return Microsoft.JScript.GlobalObject.escape(text);
            }
            return "";
        }

        public static string EscapeDecode(string text)
        {
            if (StringUtil.IsNotEmpty(text))
            {
                return Microsoft.JScript.GlobalObject.unescape(text);
            }
            return "";
        }
    }
}
