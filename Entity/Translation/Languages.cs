using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace niushuai233Kit.Entity.Translation
{
    internal class Code
    {
        /// <summary>
        /// 国家全称代码
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// google api code
        /// </summary>
        public string GoogleCode { get; set; }

        /// <summary>
        /// baidu api code
        /// </summary>
        public string BaiduCode { get; set; }

    }
    public class Languages
    {
        /// <summary>
        /// 繁体
        /// </summary>
        internal static Code ChineseTraditional = new Code
        {
            Country = "ChineseTraditional",
            GoogleCode = "zh-TW",
            BaiduCode = "cht"
        };
    }
}
