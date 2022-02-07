using HashLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace niushuai233Kit.Util
{
    public class EncryptUtil
    {

        public static string MD5(string source, int bit, bool upperCase)
        {

            HashResult result = HashFactory.Crypto.CreateMD5().ComputeString(source, System.Text.Encoding.UTF8);

            return UpperCase(result.ToString(), upperCase);
        }

        /// <summary>
        /// SHA1
        /// </summary>
        /// <param name="source">源串</param>
        /// <param name="upperCase">是否大写</param>
        /// <returns>经过SHA1处理过的字符串</returns>
        public static string SHA1(string source, bool upperCase)
        {
            HashResult result = HashFactory.Crypto.CreateSHA1().ComputeString(source, System.Text.Encoding.UTF8);

            return UpperCase(result.ToString(), upperCase);
        }

        /// <summary>
        /// SHA224
        /// </summary>
        /// <param name="source">源串</param>
        /// <param name="upperCase">是否大写</param>
        /// <returns>经过SHA224处理过的字符串</returns>
        public static string SHA224(string source, bool upperCase)
        {
            HashResult result = HashFactory.Crypto.CreateSHA224().ComputeString(source, System.Text.Encoding.UTF8);

            return UpperCase(result.ToString(), upperCase);
        }


        /// <summary>
        /// SHA256
        /// </summary>
        /// <param name="source">源串</param>
        /// <param name="upperCase">是否大写</param>
        /// <returns>经过SHA256处理过的字符串</returns>
        public static string SHA256(string source, bool upperCase)
        {
            HashResult result = HashFactory.Crypto.CreateSHA256().ComputeString(source, System.Text.Encoding.UTF8);

            return UpperCase(result.ToString(), upperCase);
        }


        /// <summary>
        /// SHA384
        /// </summary>
        /// <param name="source">源串</param>
        /// <param name="upperCase">是否大写</param>
        /// <returns>经过SHA384处理过的字符串</returns>
        public static string SHA384(string source, bool upperCase)
        {

            HashResult result = HashFactory.Crypto.CreateSHA384().ComputeString(source, System.Text.Encoding.UTF8);

            return UpperCase(result.ToString(), upperCase);
        }


        /// <summary>
        /// SHA512
        /// </summary>
        /// <param name="source">源串</param>
        /// <param name="upperCase">是否大写</param>
        /// <returns>经过SHA512处理过的字符串</returns>
        public static string SHA512(string source, bool upperCase)
        {

            HashResult result = HashFactory.Crypto.CreateSHA512().ComputeString(source, System.Text.Encoding.UTF8);

            return UpperCase(result.ToString(), upperCase);
        }


        /// <summary>
        /// 是否转为大写返回
        /// </summary>
        /// <param name="source">源串</param>
        /// <param name="upperCase">大写字母</param>
        /// <returns></returns>
        public static string UpperCase(string source, bool upperCase)
        {
            if (upperCase)
            {
                return source.ToUpper();
            }
            else
            {
                return source.ToLower();
            }
        }

    }
}
