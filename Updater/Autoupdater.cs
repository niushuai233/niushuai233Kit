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
            Releases newestReleases = new Releases();
            newestReleases.published_at = DateUtil.ParseDate("1970-01-01");

            JArray arr = HttpUtil.Get<JArray>(REPOS_INFO_URL);

            if (null == arr || arr.Count == 0)
            {
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
                // 存在更新
                AutoupdaterForm autoupdaterForm = new AutoupdaterForm(newestReleases);

                parent.Invoke((MethodInvoker)delegate () {
                    autoupdaterForm.Show();
                });
            }
        }
    }
}
