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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace niushuai233Kit.KitForm.Other
{
    public partial class TranslationForm : Form
    {
        /// <summary>
        /// 自动翻译计时器
        /// </summary>
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private int mills = 1000;
        private string lastSource = "";

        private Thread translateThread;

        public TranslationForm(KitApplication kitApplication)
        {
            InitializeComponent();

            Init();

            InitTimer();
        }

        private void InitTimer()
        {

            this.timer.Interval = mills;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Write Line");
            string currSource = this.textBox_source.Text;
            if (!currSource.Equals(lastSource))
            {
                // 如果记录的上次翻译时内容与当前不同时, 再翻译一次
                Translate_Before();
                lastSource = currSource;
            } else
            {
                // 相等时停止触发timer
                this.timer.Stop();
            }
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

            // 切换后自动翻译一次
            Translate_Before();
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
            Translate_Before();
        }

        private void Translate_Before()
        {
            translateThread = new Thread(new ThreadStart(Translate));
            translateThread.Start();
        }

        private void Translate()
        {

            // 加个状态 表示在翻译中了
            this.button_translate.Text = "翻译中";
            this.button_translate.ForeColor = Color.Red;

            TranslationResponse response = null;

            if (this.comboBox_translation_engine.SelectedIndex == 0)
            {
                // Google
                response = TranslationUtil.GoogleTranslate(this.textBox_source.Text, Languages.MatchGoogle(this.comboBox_language_result.Text), Languages.MatchGoogle(this.comboBox_language_source.Text));
            }
            else
            {
                // Baidu
                response = TranslationUtil.BaiduTranslate(this.textBox_source.Text, Languages.MatchBaidu(this.comboBox_language_result.Text), Languages.MatchBaidu(this.comboBox_language_source.Text));
            }

            // 未成功
            if (response == null || !response.Success)
            {
                MessageBox.Show("失败: " + response == null ? "无响应体" : response.ErrorMessage);
                return;
            }

            // 成功
            this.textBox_result.Text = response.TranslatedText;

            this.button_translate.Text = "翻译";
            this.button_translate.ForeColor = Color.Black;

            // 停止线程
            translateThread.Abort();
        }

        /// <summary>
        /// 记住上次选择的翻译语言
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_translation_engine_SelectedIndexChanged(object sender, EventArgs e)
        {
            TranslationUtil.settings.UsingTranslationEngine = this.comboBox_translation_engine.SelectedIndex;
            XmlUtil.Obj2Xml(CommonUtil.TranslationSettingsLocation(), TranslationUtil.settings);
        }
        
        private void textBox_source_TextChanged(object sender, EventArgs e)
        {
            if (this.checkBox_auto_translate.Checked && !this.timer.Enabled)
            {
                this.timer.Start();
            }
        }
    }
}
