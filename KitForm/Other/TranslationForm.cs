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

        private void button_settings_Click(object sender, EventArgs e)
        {
            TranslationSettingsForm settingsForm = new TranslationSettingsForm();
            settingsForm.ShowDialog(this);
        }

        private void Init()
        {
            // 初始化翻译语言exchange背景图片
            this.pictureBox_language_exchange.Image = Properties.Resources.Exchange;
            // 初始化内容exchange背景图片
            this.pictureBox_content_exchange.Image = Properties.Resources.Exchange_Vertical;

            // 设置默认引擎为Google
            this.comboBox1.SelectedIndex = 0;

            // 加载初始配置
            TranslationUtil.settings = CommonUtil.LoadConfig<TranslationSettings>(CommonUtil.TranslationSettingsLocation());
        }

        private void pictureBox_language_exchange_Click(object sender, EventArgs e)
        {

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

            if (this.comboBox1.SelectedIndex == 0)
            {
                // Google
                response = TranslationUtil.GoogleTranslate(this.textBox_source.Text, LanguageCodes.ChineseSimplified);
            }
            else
            {
                // Baidu
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
    }
}
