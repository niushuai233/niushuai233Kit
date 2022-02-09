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
        public static FileInfo[] ListDirectory(string path, string pattern = "")
        {

            if (path == null)
            {
                return null;
            }
            string dirPath = @path;
            DirectoryInfo root = new DirectoryInfo(dirPath);
            FileInfo[] files = root.GetFiles();

            if (CollectionUtil.IsEmpty(files))
            {
                return null;
            }

            List<FileInfo> list = new List<FileInfo>();
            foreach (FileInfo item in files)
            {
                if (item.Name.EndsWith(pattern))
                {
                    list.Add(item);
                }
            }

            return list.ToArray<FileInfo>();
        }
    }
}
