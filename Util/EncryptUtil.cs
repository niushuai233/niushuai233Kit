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

        public static string AES_Encrypt(CipherMode cipherMode, PaddingMode paddingMode, string source, string key, string iv)
        {
            Byte[] keyArray = System.Text.Encoding.UTF8.GetBytes(key);
            Byte[] toEncryptArray = System.Text.Encoding.UTF8.GetBytes(source);
            var rijndael = new System.Security.Cryptography.RijndaelManaged();
            rijndael.Key = keyArray;
            rijndael.Mode = cipherMode;
            rijndael.Padding = paddingMode;
            rijndael.IV = System.Text.Encoding.UTF8.GetBytes(iv);
            System.Security.Cryptography.ICryptoTransform cTransform = rijndael.CreateEncryptor();
            Byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        public static string AES_Decrypt(CipherMode cipherMode, PaddingMode paddingMode, string source, string key, string iv)
        {
            Byte[] keyArray = System.Text.Encoding.UTF8.GetBytes(key);
            Byte[] toEncryptArray = Convert.FromBase64String(source);
            var rijndael = new System.Security.Cryptography.RijndaelManaged();
            rijndael.Key = keyArray;
            rijndael.Mode = cipherMode;
            rijndael.Padding = paddingMode;
            rijndael.IV = System.Text.Encoding.UTF8.GetBytes(iv);
            System.Security.Cryptography.ICryptoTransform cTransform = rijndael.CreateDecryptor();
            Byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return System.Text.Encoding.UTF8.GetString(resultArray);
        }

        public static string DES_Encrypt(string source, string key, bool upperCase)
        {

            return "";
        }
        public static string DES_Decrypt(string source, string key, bool upperCase)
        {

            return "";
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
