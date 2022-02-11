using Google.Cloud.Translation.V2;
using niushuai233Kit.KitForm.Other.Settings;
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
        }

        private void pictureBox_language_exchange_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_content_exchange_Click(object sender, EventArgs e)
        {
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
            string apiKey = "AIzaSyAoRh9wFe9BN8r8EJPI9HOWJK3sMv2J9nc";
            TranslationClient client = TranslationClient.CreateFromApiKey(apiKey);
            TranslationResult result = client.TranslateText("It is raining.", LanguageCodes.ChineseSimplified);
            Console.WriteLine($"Result: {result.TranslatedText}; detected language {result.DetectedSourceLanguage}");
        }
    }
}
