using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace niushuai233Kit.Util
{
    class StringUtil
    {

        /// <summary>
        /// 字符是否为中文
        /// </summary>
        /// <param name="_char">待判断的字符</param>
        /// <returns></returns>
        public static bool IsChinese(char _char)
        {
            return IsChinese(_char.ToString());
        }

        /// <summary>
        /// 字符串是否为中文
        /// </summary>
        /// <param name="str">待判断的字符串</param>
        /// <returns></returns>
        public static bool IsChinese(string str)
        {
            return Regex.IsMatch(str, @"[\u4e00-\u9fa5]");
        }

        /// <summary>
        /// 字符是否为英文
        /// </summary>
        /// <param name="_char">待判断的字符</param>
        /// <returns></returns>
        public static bool IsEnglish(char _char)
        {
            return IsEnglish(_char.ToString());
        }

        /// <summary>
        /// 字符串是否为英文
        /// </summary>
        /// <param name="str">待判断的字符串</param>
        /// <returns></returns>
        public static bool IsEnglish(string str)
        {
            return Regex.IsMatch(str, @"^[A-Za-z]+$");
        }

        /// <summary>
        /// 是否为中文字符
        /// </summary>
        /// <param name="_char"></param>
        /// <returns></returns>
        public static bool IsSymbolOfChinese(char _char)
        {
            return 2 * _char.ToString().Length == Encoding.Default.GetByteCount(_char.ToString());
        }


        /// <summary>
        /// 是否为英文字符
        /// </summary>
        /// <param name="_char"></param>
        /// <returns></returns>
        public static bool IsSymbolOfEnglish(char _char)
        {
            return _char.ToString().Length == Encoding.Default.GetByteCount(_char.ToString());
        }
    }
}
