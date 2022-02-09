
using niushuai233Kit.KitForm.Codec;
using niushuai233Kit.KitForm.Encrypt;
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


        //////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// 
        /// 编码转换 Forms
        /// 
        /// </summary>
        //////////////////////////////////////////////////////////////////////////////


        //////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// 
        /// 加密解密 Forms
        /// 
        /// </summary>
        //////////////////////////////////////////////////////////////////////////////




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
            WordCountForm form = new WordCountForm(this);
            FormReset(this.string_groupBox_result, form);
        }

        private void other_button_keycode_Click(object sender, EventArgs e)
        {
            AsciiForm form = new AsciiForm(this);
            FormReset(this.other_groupBox_result, form);
        }

        private void encrypt_button_urlCodec_Click(object sender, EventArgs e)
        {
            UrlCodecForm form = new UrlCodecForm(this);
            FormReset(this.codec_groupBox_result, form);
        }

        private void encrypt_button_base64_Click(object sender, EventArgs e)
        {
            Base64Form form = new Base64Form(this);
            FormReset(this.codec_groupBox_result, form);
        }

        private void encrypted_button_escape_Click(object sender, EventArgs e)
        {
            EscapeForm form = new EscapeForm(this);
            FormReset(this.codec_groupBox_result, form);
        }

        /// <summary>
        /// 大小写转换点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void string_button_wordConvert_Click(object sender, EventArgs e)
        {
            WordConvertForm form = new WordConvertForm(this);
            FormReset(this.string_groupBox_result, form);
        }

        private void string_button_textNumber_Click(object sender, EventArgs e)
        {
            TextNumberForm form = new TextNumberForm(this);
            FormReset(this.string_groupBox_result, form);
        }

        private void encrypt_button_md5_Click(object sender, EventArgs e)
        {
            MD5Form form = new MD5Form(this);
            FormReset(this.encrypt_groupBox_result, form);
        }

        private void encrypt_button_sha_Click(object sender, EventArgs e)
        {
            SHAForm form = new SHAForm(this);
            FormReset(this.encrypt_groupBox_result, form);
        }

        private void button_encrypt_aes_Click(object sender, EventArgs e)
        {
            AESForm form = new AESForm(this);
            FormReset(this.encrypt_groupBox_result, form);
        }


        private void button_other_countdown_Click(object sender, EventArgs e)
        {
            CountDownForm form = new CountDownForm(this);
            FormReset(this.other_groupBox_result, form);
        }

        private void button_string_uuid_Click(object sender, EventArgs e)
        {
            UUIDForm form = new UUIDForm(this);
            FormReset(this.string_groupBox_result, form);
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
    }
}
