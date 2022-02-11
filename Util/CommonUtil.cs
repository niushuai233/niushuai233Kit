using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace niushuai233Kit.Util
{
    public class CommonUtil
    {
        /// <summary>
        /// 配置文件位置
        /// </summary>
        /// <returns>配置文件全路径</returns>
        public static string GetConfigLocationPrefix()
        {
            return CommonConstant.USER_PROFILE_DIRECTORY + "/" + CommonConstant.USER_PROFILE_PROJECT_DIRECTORY + "/" + CommonConstant.PROJECT_NAME + "/";
        }

        /// <summary>
        /// 获取翻译设置文件绝对路径名称
        /// </summary>
        /// <returns></returns>
        public static string TranslationSettingsLocation()
        {
            return GetConfigLocationPrefix() + CommonConstant.Translation;
        }

        /// <summary>
        /// 建立前置配置文件夹
        /// </summary>
        private static void CreateProjectFolder()
        {
            System.IO.Directory.CreateDirectory(GetConfigLocationPrefix());
        }

        public static T LoadConfig<T>(string path)
        {
            object config = Activator.CreateInstance(typeof(T), true);
            if (!File.Exists(path))
            {
                Console.WriteLine("配置文件不存在, 新建. | " + path);
                CreateProjectFolder();
                XmlUtil.Obj2Xml<T>(path, (T)config);
                return (T)config;
            }

            config = XmlUtil.Xml2Obj<T>(path);
            return (T)config;
        }

    }
}
