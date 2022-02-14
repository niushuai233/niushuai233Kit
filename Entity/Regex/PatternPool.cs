using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace niushuai233Kit.Entity.Regex
{
    public class PatternPool
    {
        /// <summary>
        /// 社会统一信用代码
        /// </summary>
        public const string CREDIT_CODE = @"^[0-9A-HJ-NPQRTUWXY]{2}\\d{6}[0-9A-HJ-NPQRTUWXY]{10}$";
    }
}
