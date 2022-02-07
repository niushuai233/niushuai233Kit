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

namespace niushuai233Kit.KitForm.Encrypt
{
    public partial class SHAForm : Form
    {
        public SHAForm(KitApplication kitApplication)
        {
            InitializeComponent();
        }

        /// <summary>
        /// 清空框框内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_clear_Click(object sender, EventArgs e)
        {
            this.textBox_source.Text = "";
            this.textBox_result.Text = "";
        }

        private void button_encrypt_Click(object sender, EventArgs e)
        {
            run();
        }

        private void run()
        {
            string source = this.textBox_source.Text;
            string value = source;

            string encrypted = "";

            // 判断是使用哪种加密算法进行加密
            if (radioButton_sha1.Checked)
            {
                encrypted = EncryptUtil.SHA1(source, GetStyle());
            }
            else if (this.radioButton_224.Checked)
            {
                encrypted = EncryptUtil.SHA224(source, GetStyle());
            }
            else if (this.radioButton_256.Checked)
            {
                encrypted = EncryptUtil.SHA256(source, GetStyle());
            }
            else if (this.radioButton_384.Checked)
            {
                encrypted = EncryptUtil.SHA384(source, GetStyle());
            }
            else if (this.radioButton_512.Checked)
            {
                encrypted = EncryptUtil.SHA512(source, GetStyle());
            }

            this.textBox_result.Text = encrypted.Replace("-", "");
        }

        private bool GetStyle()
        {

            if (this.radioButton_style_lower.Checked)
            {
                return false;
            }
            else if (this.radioButton_style_upper.Checked)
            {
                return true;
            }
            //默认32
            return false;
        }

        private void textBox_source_textChange(object sender, EventArgs e)
        {
            if (StringUtil.IsNotEmpty(this.textBox_source.Text) && this.checkBox_autorun.Checked)
            {
                run();
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (StringUtil.IsNotEmpty(this.textBox_source.Text) && this.checkBox_autorun.Checked)
            {
                run();
            }
        }
    }
}
