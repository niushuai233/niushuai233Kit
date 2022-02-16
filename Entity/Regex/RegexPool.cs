using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace niushuai233Kit.Entity.Regex
{
    public class RegexPool
    {
        /// <summary>
        /// 仅中文
        /// </summary>
        public const string ChineseOnly = @"[\u4E00-\u9FFF]+";

        /// <summary>
        /// 仅英文
        /// </summary>
        public const string EnglishOnly = @"[a-zA-Z]+";

        /// <summary>
        /// 仅数字
        /// </summary>
        public const string NumberOnly = @"[0-9]+";

        /// <summary>
        /// 邮箱
        /// </summary>
        public const string Email = @"\w[-\w.+]*@([A-Za-z0-9][-A-Za-z0-9]+\.)+[A-Za-z]{2,14}";

        /// <summary>
        /// 座机号码
        /// </summary>
        public const string Phone = @"[0-9-()（）]{7,18}";

        /// <summary>
        /// 手机号
        /// </summary>
        public const string Mobile = @"0?(13|14|15|17|18|19)[0-9]{9}";

        /// <summary>
        /// 邮编
        /// </summary>
        public const string PostCode = @"\d{6}";

        /// <summary>
        /// 身份证号码
        /// </summary>
        public const string IDCard = @"\d{17}[\d|x]|\d{15}";

        /// <summary>
        /// IPV4
        /// </summary>
        public const string IPV4 = @"(25[0-5]|2[0-4]\d|[0-1]\d{2}|[1-9]?\d)\.(25[0-5]|2[0-4]\d|[0-1]\d{2}|[1-9]?\d)\.(25[0-5]|2[0-4]\d|[0-1]\d{2}|[1-9]?\d)\.(25[0-5]|2[0-4]\d|[0-1]\d{2}|[1-9]?\d)";

        /// <summary>
        /// QQ
        /// </summary>
        public const string QQ = @"[1-9]([0-9]{5,11})";
    }
}
