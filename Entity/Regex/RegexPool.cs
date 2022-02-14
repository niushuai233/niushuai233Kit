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
        public const string Email = @"";

        /// <summary>
        /// 座机号码
        /// </summary>
        public const string Phone = @"";

        /// <summary>
        /// 手机号
        /// </summary>
        public const string Mobile = @"";

        /// <summary>
        /// 邮编
        /// </summary>
        public const string PostCode = @"";

        /// <summary>
        /// 身份证号码
        /// </summary>
        public const string IDCard = @"";

        /// <summary>
        /// IPV4
        /// </summary>
        public const string IPV4 = @"";

        /// <summary>
        /// IPV6
        /// </summary>
        public const string IPV6 = @"";

        /// <summary>
        /// QQ
        /// </summary>
        public const string QQ = @"";
    }
}
