using Google.Cloud.Translation.V2;
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
        /// 国家名称
        /// </summary>
        public string Name { get; set; }

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
        /// 自动检测
        /// </summary>
        internal static Code Auto = new Code
        {
            Name = "auto",
            GoogleCode = null,
            BaiduCode = "auto"
        };

        /// <summary>
        /// 简体
        /// </summary>
        internal static Code ChineseSimplified = new Code
        {
            Name = "中文简体",
            GoogleCode = LanguageCodes.ChineseSimplified,
            BaiduCode = "zh"
        };

        /// <summary>
        /// 繁体
        /// </summary>
        internal static Code ChineseTraditional = new Code
        {
            Name = "中文繁体",
            GoogleCode = LanguageCodes.ChineseTraditional,
            BaiduCode = "cht"
        };

        /// <summary>
        /// 英语
        /// </summary>
        internal static Code English = new Code
        {
            Name = "英语",
            GoogleCode = LanguageCodes.English,
            BaiduCode = "en"
        };
        
        /// <summary>
        /// 日语
        /// </summary>
        internal static Code Japanese = new Code
        {
            Name = "日语",
            GoogleCode = LanguageCodes.Japanese,
            BaiduCode = "jp"
        };
             
        /// <summary>
        /// 韩语
        /// </summary>
        internal static Code Korean = new Code
        {
            Name = "韩语",
            GoogleCode = LanguageCodes.Korean,
            BaiduCode = "kor"
        };

        /// <summary>
        /// 法语
        /// </summary>
        internal static Code French = new Code
        {
            Name = "法语",
            GoogleCode = LanguageCodes.French,
            BaiduCode = "fra"
        };
    }
}
