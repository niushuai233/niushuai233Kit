using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace niushuai233Kit.Util
{
    public class ReflectUtil
    {

        public static FieldInfo[] GetAllField<T>()
        {
            Type type = typeof(T);

            FieldInfo[] fieldInfos = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);

            return fieldInfos;
        }
    }
}
