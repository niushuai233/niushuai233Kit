using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace niushuai233Kit.Entity.Enums
{
    public enum CharType
    {
        /// <summary>
        /// 中文
        /// </summary>
        Chinese = 1,
        /// <summary>
        /// 全角
        /// </summary>
        Chinese_Symbol = 2,
        /// <summary>
        /// 英文
        /// </summary>
        English = 3,
        /// <summary>
        /// 半角
        /// </summary>
        English_Symbol = 4,
        /// <summary>
        /// 阿拉伯数字
        /// </summary>
        Number = 5,
        /// <summary>
        /// 默认值
        /// </summary>
        Default = 0
    }
}
