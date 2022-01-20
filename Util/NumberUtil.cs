using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace niushuai233Kit.Util
{
    class NumberUtil
    {
        /// <summary>
        /// 字符是否为英文
        /// </summary>
        /// <param name="_char">待判断的字符</param>
        /// <returns></returns>
        public static bool IsNumber(char _char)
        {
            return IsNumber(_char.ToString());
        }

        /// <summary>
        /// 字符串是否为数字
        /// </summary>
        /// <param name="str">待判断的字符串</param>
        /// <returns></returns>
        public static bool IsNumber(string str)
        {
            if (int.TryParse(str, out _))
            {
                return true;
            }
            return false;
        }

    }
}
