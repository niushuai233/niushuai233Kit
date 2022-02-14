using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace niushuai233Kit.Entity.Settings
{
    [XmlRootAttribute("TranslationSettings", IsNullable = false)]
    public class TranslationSettings
    {
        /// <summary>
        /// 当前翻译引擎
        /// </summary>
        public int UsingTranslationEngine { get; set; }
        /// <summary>
        /// 谷歌ApiKey
        /// </summary>
        public string GoogleApiKey { get; set; }
        /// <summary>
        /// 百度AppId
        /// </summary>
        public string BaiduAppId { get; set; }
        /// <summary>
        /// 百度App秘钥
        /// </summary>
        public string BaiduAppSecretKey { get; set; }
    }
}
