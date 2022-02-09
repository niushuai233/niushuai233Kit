
using niushuai233Kit.KitForm.Codec;
using niushuai233Kit.KitForm.Encrypt;
using niushuai233Kit.KitForm.Menus;
using niushuai233Kit.KitForm.Other;
using niushuai233Kit.KitForm.Strings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace niushuai233Kit
{
    public partial class KitApplication : Form
    {


        //////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// 
        /// 文本 Forms
        /// 
        /// </summary>
        //////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// 字数统计
        /// </summary>
        private static WordCountForm wordCountForm;


        /// <summary>
        /// 大小写转换
        /// </summary>
        private static WordConvertForm wordConvertForm;

        /// <summary>
        /// 增加序号
        /// </summary>
        private static TextNumberForm textNumberForm;

        /// <summary>
        /// UUID/GUID
        /// </summary>
        private static UUIDForm uuidForm;

        //////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// 
        /// 编码转换 Forms
        /// 
        /// </summary>
        //////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Url
        /// </summary>
        private static UrlCodecForm urlCodecForm;

        /// <summary>
        /// Base64
        /// </summary>
        private static Base64Form base64Form;

        /// <summary>
        /// Escape
        /// </summary>
        private static EscapeForm escapeForm;

        //////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// 
        /// 加密解密 Forms
        /// 
        /// </summary>
        //////////////////////////////////////////////////////////////////////////////


        /// <summary>
        /// MD5
        /// </summary>
        private static MD5Form md5Form;

        /// <summary>
        /// MD5
        /// </summary>
        private static SHAForm shaForm;

        /// <summary>
        /// AES
        /// </summary>
        private static AESForm aesForm;


        //////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// 
        /// 时间转换 Forms
        /// 
        /// </summary>
        //////////////////////////////////////////////////////////////////////////////


        //////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// 
        /// 其他 Forms
        /// 
        /// </summary>
        //////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// ASCII查询
        /// </summary>
        private static AsciiForm asciiForm;

        /// <summary>
        /// 倒计时
        /// </summary>
        private static CountDownForm countDownForm;


        //////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// 
        /// 以上内容为各个 form 实例集合
        /// 
        /// </summary>
        //////////////////////////////////////////////////////////////////////////////

        public KitApplication()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 设置Form的显示内容
        /// </summary>
        /// <param name="groupBox"></param>
        /// <param name="form"></param>
        private void FormReset(GroupBox groupBox, Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            // 清空面板
            groupBox.Controls.Clear();
            // 添加新的面板
            groupBox.Controls.Add(form);

            form.Show();
        }

        /// <summary>
        /// 字数统计 form表单
        /// </summary>
        /// <param name="sender">触发</param>
        /// <param name="e">参数</param>
        private void string_button_wordCount_Click(object sender, EventArgs e)
        {
            if (wordCountForm == null)
            {
                wordCountForm = new WordCountForm(this);

            }
            FormReset(this.string_groupBox_result, wordCountForm);
        }

        private void other_button_keycode_Click(object sender, EventArgs e)
        {
            if (asciiForm == null)
            {
                asciiForm = new AsciiForm(this);
            }
            FormReset(this.other_groupBox_result, asciiForm);
        }

        private void encrypt_button_urlCodec_Click(object sender, EventArgs e)
        {
            if (urlCodecForm == null)
            {
                urlCodecForm = new UrlCodecForm(this);
            }
            FormReset(this.codec_groupBox_result, urlCodecForm);
        }

        private void encrypt_button_base64_Click(object sender, EventArgs e)
        {
            if (base64Form == null)
            {
                base64Form = new Base64Form(this);
            }
            FormReset(this.codec_groupBox_result, base64Form);
        }

        private void encrypted_button_escape_Click(object sender, EventArgs e)
        {
            if (escapeForm == null)
            {
                escapeForm = new EscapeForm(this);
            }
            FormReset(this.codec_groupBox_result, escapeForm);
        }

        /// <summary>
        /// 大小写转换点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void string_button_wordConvert_Click(object sender, EventArgs e)
        {
            if (wordConvertForm == null)
            {
                wordConvertForm = new WordConvertForm(this);
            }
            FormReset(this.string_groupBox_result, wordConvertForm);
        }

        private void string_button_textNumber_Click(object sender, EventArgs e)
        {
            if (textNumberForm == null)
            {
                textNumberForm = new TextNumberForm(this);
            }
            FormReset(this.string_groupBox_result, textNumberForm);
        }

        private void encrypt_button_md5_Click(object sender, EventArgs e)
        {
            if (md5Form == null)
            {
                md5Form = new MD5Form(this);
            }
            FormReset(this.encrypt_groupBox_result, md5Form);
        }

        private void encrypt_button_sha_Click(object sender, EventArgs e)
        {
            if (shaForm == null)
            {
                shaForm = new SHAForm(this);
            }
            FormReset(this.encrypt_groupBox_result, shaForm);
        }

        private void button_encrypt_aes_Click(object sender, EventArgs e)
        {
            if (aesForm == null)
            {
                aesForm = new AESForm(this);
            }
            FormReset(this.encrypt_groupBox_result, aesForm);
        }


        private void button_other_countdown_Click(object sender, EventArgs e)
        {
            if (countDownForm == null)
            {
                countDownForm = new CountDownForm(this);
            }
            FormReset(this.other_groupBox_result, countDownForm);
        }

        private void button_string_uuid_Click(object sender, EventArgs e)
        {
            if (uuidForm == null)
            {
                uuidForm = new UUIDForm(this);
            }
            FormReset(this.string_groupBox_result, uuidForm);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 释放托盘图标
            this.notifyIcon.Dispose();
            Environment.Exit(0);
        }

        private void KitApplication_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.notifyIcon.Visible = true;
            this.ShowInTaskbar = false;
            this.Hide();
            e.Cancel = true;
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.notifyIcon.Visible = false;
                this.ShowInTaskbar = true;
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog(this);
        }
    }
}
