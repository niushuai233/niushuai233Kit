using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace niushuai233Kit.Util
{
    public class FileUtil
    {

        public static List<string> ListDirectory(string path, string pattern = "")
        {
            List<string> list = new List<string>();

            if (path == null)
            {
                return list;
            }
            string dirPath = @path;
            DirectoryInfo root = new DirectoryInfo(dirPath);
            FileInfo[] files = root.GetFiles();
            
            if (CollectionUtil.IsEmpty(files))
            {
                return list;
            }

            foreach (FileInfo item in files)
            {
                if (item.FullName.EndsWith(""))
                {
                    list.Add(item.FullName);
                }
            }

            return list;
        }
    }
}
