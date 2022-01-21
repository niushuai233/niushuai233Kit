using System;
using System.Text;
using System.Web;

namespace niushuai233Kit.Util
{
    class EncrypyUtil
    {

        /// <summary>
        /// 解码
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string Base64Decode(string value)
        {
            if (StringUtil.IsNotEmpty(value))
            {
                byte[] bytes = Convert.FromBase64String(value);
                return Encoding.UTF8.GetString(bytes);
            }
            return "";
        }

        /// <summary>
        /// 转码
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string Base64Encode(string value)
        {
            if (StringUtil.IsNotEmpty(value)) {
                byte[] bytes = Encoding.UTF8.GetBytes(value);
                return Convert.ToBase64String(bytes);
            }
            return "";
        }

        /// <summary>
        /// url encode
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        internal static string UrlEncode(string text)
        {
            return HttpUtility.UrlEncode(text);
        }

        /// <summary>
        /// url decode
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        internal static string UrlDecode(string text)
        {
            return HttpUtility.UrlDecode(text);
        }
    }
}
