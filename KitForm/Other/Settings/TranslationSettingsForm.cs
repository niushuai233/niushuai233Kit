using niushuai233Kit.Entity.Settings;
using niushuai233Kit.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace niushuai233Kit.KitForm.Other.Settings
{
    public partial class TranslationSettingsForm : Form
    {
        public TranslationSettingsForm()
        {
            InitializeComponent();
            this.CenterToParent();
            // 从配置文件中加载配置
            Init();
        }

        /// <summary>
        /// 初始化配置文件
        /// </summary>
        private void Init()
        {
            TranslationSettings translationSettings = CommonUtil.LoadConfig<TranslationSettings>(CommonUtil.TranslationSettingsLocation());
            this.textBox_google_apikey.Text = translationSettings.GoogleApiKey;
            this.textBox_baidu_appid.Text = translationSettings.BaiduAppId;
            this.textBox_baidu_secretKey.Text = translationSettings.BaiduAppSecretKey;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 保存设置到文件中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_confirm_Click(object sender, EventArgs e)
        {
            string googleApiKey = this.textBox_google_apikey.Text;
            string baiduAppId = this.textBox_baidu_appid.Text;
            string baiduSecretKey = this.textBox_baidu_secretKey.Text;

            TranslationSettings translationSettings = new TranslationSettings()
            {
                GoogleApiKey = googleApiKey,
                BaiduAppId = baiduAppId,
                BaiduAppSecretKey = baiduSecretKey
            };

            XmlUtil.Obj2Xml<TranslationSettings>(CommonUtil.TranslationSettingsLocation(), translationSettings);

            TranslationUtil.settings = translationSettings;
            this.Close();
        }
    }
}
