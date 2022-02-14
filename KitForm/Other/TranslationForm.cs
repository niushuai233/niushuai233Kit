using Google.Cloud.Translation.V2;
using niushuai233Kit.Entity.Settings;
using niushuai233Kit.Entity.Translation;
using niushuai233Kit.KitForm.Other.Settings;
using niushuai233Kit.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace niushuai233Kit.KitForm.Other
{
    public partial class TranslationForm : Form
    {
        public TranslationForm(KitApplication kitApplication)
        {
            InitializeComponent();

            Init();
            
        }


        private void Init()
        {
            // 初始化翻译语言exchange背景图片
            this.pictureBox_language_exchange.Image = Properties.Resources.Exchange;
            // 初始化内容exchange背景图片
            this.pictureBox_content_exchange.Image = Properties.Resources.Exchange_Vertical;

            // 加载初始配置
            TranslationUtil.settings = CommonUtil.LoadConfig<TranslationSettings>(CommonUtil.TranslationSettingsLocation());
            // 设置默认引擎为上次勾选
            this.comboBox_translation_engine.SelectedIndex = TranslationUtil.settings.UsingTranslationEngine;

            InitLanguageCombox();
        }


        /// <summary>
        /// 初始化翻译源语言与目标语言
        /// </summary>
        private void InitLanguageCombox()
        {
            Languages languages = new Languages();
            FieldInfo[] fieldInfos = ReflectUtil.GetAllField<Languages>();

            this.comboBox_language_source.Items.Clear();
            this.comboBox_language_result.Items.Clear();

            for (int i = 0; i < fieldInfos.Length; i++)
            {
                Code code = (Code)fieldInfos[i].GetValue(languages);
                this.comboBox_language_source.Items.Add(code.Name);
                if (i != fieldInfos.Length - 1)
                {
                    this.comboBox_language_result.Items.Add(code.Name);
                }
            }

            this.comboBox_language_source.SelectedIndex = 2;
            this.comboBox_language_result.SelectedIndex = 0;
        }


        private void button_settings_Click(object sender, EventArgs e)
        {
            TranslationSettingsForm settingsForm = new TranslationSettingsForm();
            settingsForm.ShowDialog(this);
        }

        private void pictureBox_language_exchange_Click(object sender, EventArgs e)
        {
            if (this.comboBox_language_source.SelectedIndex == 6)
            {
                return;
            }

            int tmp = this.comboBox_language_source.SelectedIndex;
            this.comboBox_language_source.SelectedIndex = this.comboBox_language_result.SelectedIndex;
            this.comboBox_language_result.SelectedIndex = tmp;

        }

        private void pictureBox_content_exchange_Click(object sender, EventArgs e)
        {
            string tmp = this.textBox_source.Text;
            this.textBox_source.Text = this.textBox_result.Text;
            this.textBox_result.Text = tmp;
        }

        private void pictureBox_exchange_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                PictureBox box = ((PictureBox)sender);
                if (box.Name == "pictureBox_language_exchange")
                {
                    box.Image = Properties.Resources.Exchange_Red;
                } 
                else if (box.Name == "pictureBox_content_exchange")
                {
                    box.Image = Properties.Resources.Exchange_Vertical_Red;
                }
            }
        }

        private void pictureBox_exchange_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                PictureBox box = ((PictureBox)sender);
                if (box.Name == "pictureBox_language_exchange")
                {
                    box.Image = Properties.Resources.Exchange;
                }
                else if (box.Name == "pictureBox_content_exchange")
                {
                    box.Image = Properties.Resources.Exchange_Vertical;
                }
            }
        }

        private void button_translate_Click(object sender, EventArgs e)
        {

            TranslationResponse response = null;

            Languages.MatchGoogle("中文简体");

            if (this.comboBox_translation_engine.SelectedIndex == 0)
            {
                ;
                // Google
                response = TranslationUtil.GoogleTranslate(this.textBox_source.Text, Languages.MatchGoogle(this.comboBox_language_result.Text), Languages.MatchGoogle(this.comboBox_language_source.Text));
            }
            else
            {
                // Baidu
                response = TranslationUtil.BaiduTranslate(this.textBox_source.Text, Languages.MatchGoogle(this.comboBox_language_result.Text), Languages.MatchGoogle(this.comboBox_language_source.Text));
            }

            // 未成功
            if (response == null || !response.Success)
            {
                MessageBox.Show("失败: " + response.ErrorMessage);
                return;
            }

            // 成功
            this.textBox_result.Text = response.TranslatedText;

        }

        private void comboBox_translation_engine_SelectedIndexChanged(object sender, EventArgs e)
        {
            TranslationUtil.settings.UsingTranslationEngine = this.comboBox_translation_engine.SelectedIndex;
            XmlUtil.Obj2Xml(CommonUtil.TranslationSettingsLocation(), TranslationUtil.settings);
        }
    }
}
