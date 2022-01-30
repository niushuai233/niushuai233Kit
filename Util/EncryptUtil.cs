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

            string md5Str = string.Empty;

            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] byData = Encoding.Default.GetBytes(source);
            byte[] result = md5.ComputeHash(byData);

            if (bit == 16)
            {
                md5Str = BitConverter.ToString(result, 4, 8);
            }
            else if (bit == 32)
            {
                md5Str = BitConverter.ToString(result);
            }
            md5Str = md5Str.Replace("-", "");

            if (upperCase)
            {
                return md5Str.ToUpper();
            }
            else
            {
                return md5Str.ToLower();
            }
        }

    }
}
