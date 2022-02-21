using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using niushuai233Kit.Entity.Github;
using niushuai233Kit.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.IO;

namespace niushuai233Kit.Updater
{
    public class Autoupdater
    {
        /// <summary>
        /// 仓库版本信息地址
        /// </summary>
        private const string REPOS_INFO_URL = "https://api.github.com/repos/niushuai233/niushuai233Kit/releases";

        private static Autoupdater autoupdater = new Autoupdater();

        private KitApplication parent;

        private Autoupdater() { }

        public static Autoupdater Instance()
        {
            return autoupdater;
        }

        public void CheckUpdate(KitApplication kitApplication)
        {
            parent = kitApplication;

            Thread checkThread = new Thread(new ThreadStart(DoWork));
            checkThread.SetApartmentState(ApartmentState.STA);
            checkThread.IsBackground = true;
            checkThread.Start();
        }

        private void DoWork()
        {
            Console.WriteLine("检测新版本");
            Releases newestReleases = new Releases();
            newestReleases.published_at = DateUtil.ParseDate("1970-01-01");

            JArray arr = HttpUtil.Get<JArray>(REPOS_INFO_URL);

            if (null == arr || arr.Count == 0)
            {
                Console.WriteLine("版本不存在");
                return;
            }

            foreach (JObject item in arr)
            {
                Releases releases = JsonConvert.DeserializeObject<Releases>(item.ToString());
                if (1 == DateUtil.Compare(releases.published_at, newestReleases.published_at))
                {
                    newestReleases = releases;
                }
            }

            if (1 == DateUtil.Compare(newestReleases.published_at, DateUtil.ParseDateTime(Properties.Resources.Release_Date)))
            {
                Console.WriteLine("存在新版本");
                // 存在更新

                // 弹窗跳转
                DialogResult dialogResult = MessageBox.Show("是否更新", "检测到新版本", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("https://github.com/niushuai233/niushuai233kit/releases");
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }


                //AutoupdaterForm autoupdaterForm = new AutoupdaterForm(newestReleases);

                //parent.Invoke((MethodInvoker)delegate () {
                //    autoupdaterForm.Show();
                //});
            } else
            {
                Console.WriteLine("当前已是最新版本");
            }
            Console.WriteLine("退出检测程序");
        }

        public static void DealDownload(string source)
        {
            if (StringUtil.IsEmpty(source))
            {
                MessageBox.Show("更新文件不存在");
                return;
            }

            string path = CommonUtil.GetCurrentProcessFileName();
            Console.WriteLine(path);

            CommonUtil.Instance.Close();

            // 无法删除自身 用户自己下载吧
            // File.Delete(path);
            // File.Copy(source, path);
        }
    }
}
