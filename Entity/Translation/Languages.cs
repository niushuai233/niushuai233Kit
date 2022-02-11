using Google.Cloud.Translation.V2;
using niushuai233Kit.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

        private static string Match(string name = null, int matchType = 1)
        {
            Languages languages = new Languages();
            FieldInfo[] fieldInfos = ReflectUtil.GetAllField<Languages>();

            string result = null;
            for (int i = 0; i < fieldInfos.Length; i++)
            {
                Code code = (Code)fieldInfos[i].GetValue(languages);

                if (code.Name.Equals(name))
                {
                    if (matchType == 1)
                    {
                        // 匹配到的GoogleCode
                        result = code.GoogleCode;
                    } 
                    else if (matchType == 2)
                    {
                        // 匹配到的BaiduCode
                        result = code.BaiduCode;
                    }
                }
            }

            if (StringUtil.IsEmpty(result))
            {
                if (matchType == 1)
                {
                    // Google 默认为 null
                    return Auto.GoogleCode;
                }
                else if (matchType == 2)
                {
                    // Baidu 默认为 auto
                    return Auto.BaiduCode;
                }
            }

            return result;
        }

        internal static string MatchGoogle(string name)
        {
            return Match(name, 1);
        }

        internal static string MatchBaidu(string name)
        {
            return Match(name, 2);
        }

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

        /// <summary>
        /// 自动检测
        /// </summary>
        internal static Code Auto = new Code
        {
            Name = "自动检测",
            GoogleCode = null,
            BaiduCode = "auto"
        };
    }
}
