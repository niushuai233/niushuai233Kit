using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace niushuai233Kit.Util
{
    public class CollectionUtil
    {

        public static bool IsEmpty(object[] source)
        {
            return null == source || source.Length == 0;
        }

        public static bool IsNotEmpty(object[] source)
        {
            return !IsEmpty(source);
        }

        public static bool IsEmpty<T>(List<T> source)
        {
            return null == source || source.Count == 0;
        }

        public static bool IsNotEmpty<T>(List<T> source)
        {
            return !IsEmpty<T>(source);
        }
    }
}
