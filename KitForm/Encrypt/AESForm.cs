using niushuai233Kit.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace niushuai233Kit.KitForm.Encrypt
{
    public partial class AESForm : Form
    {
        public static int mode = -1;
        public AESForm(KitApplication kitApplication)
        {
            InitializeComponent();
            mode = -1;
            this.comboBox_mode.SelectedIndex = 0;
            this.comboBox_padding.SelectedIndex = 1;
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            this.textBox_iv.Text = "1234567812345678";
            this.textBox_key.Text = "abcdefghijklmnop";
            this.textBox_source.Text = "";
            this.textBox_result.Text = "";
        }

        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_encrypt_Click(object sender, EventArgs e)
        {
            runEncrypt();
            calcElementLength();
        }

        private void runEncrypt()
        {
            // 置为当前操作为加密操作
            mode = 1;
            try
            {
                string text = this.textBox_source.Text;
                if (StringUtil.IsEmpty(text))
                {
                    // 非空才加密
                    return;
                }
                string key = this.textBox_key.Text;
                string iv = this.textBox_iv.Text;

                iv = RandomIV(iv);

                string result = EncryptUtil.AES_Encrypt(GetMode(), GetPadding(), text, key, iv);

                this.textBox_result.Text = result;
            }
            catch (Exception e)
            {
                MessageBox.Show("加密错误：" + e.Message);
            }
        }
        private string RandomIV(string iv)
        {
            return StringUtil.IsNotEmpty(iv) ? iv : StringUtil.GetRandomString(16);
        }


        /// <summary>
        /// 获取选择的加密模式
        /// </summary>
        /// <returns></returns>
        private CipherMode GetMode()
        {
            int index = this.comboBox_mode.SelectedIndex;

            return (CipherMode)(index + 1);
        }

        /// <summary>
        /// 获取选择的补码方式
        /// </summary>
        /// <returns></returns>
        private PaddingMode GetPadding()
        {
            int index = this.comboBox_padding.SelectedIndex;

            return (PaddingMode)(index + 1);
        }

        private void textChange_TextChanged(object sender, EventArgs e)
        {
            if ((StringUtil.IsNotEmpty(this.textBox_source.Text) || StringUtil.IsNotEmpty(this.textBox_result.Text)) && this.checkBox_autorun.Checked)
            {
                runChoose();
            }
            calcElementLength();
        }

        private void calcElementLength()
        {

            this.label_iv_length.Text = this.textBox_iv.Text.Length.ToString();
            this.label_key_length.Text = this.textBox_key.Text.Length.ToString();
            this.label_source_length.Text = this.textBox_source.Text.Length.ToString();
            this.label_result_length.Text = this.textBox_result.Text.Length.ToString();
        }

        private void comboBox_padding_SelectedValueChanged(object sender, EventArgs e)
        {
            if (((int)PaddingMode.None) == this.comboBox_padding.SelectedIndex + 1)
            {
                MessageBox.Show("补码方式为无时,尤其要注意各元素的长度问题!");
            }
            else if (((int)PaddingMode.ISO10126) == this.comboBox_padding.SelectedIndex + 1)
            {
                MessageBox.Show("补码方式为ISO10126时, 每次生成的密文都不同!");
            }

            if (StringUtil.IsNotEmpty(this.textBox_source.Text) && this.checkBox_autorun.Checked)
            {
                runChoose();
                calcElementLength();
            }
        }

        private void comboBox_mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StringUtil.IsNotEmpty(this.textBox_source.Text) && this.checkBox_autorun.Checked)
            {
                runChoose();
                calcElementLength();
            }
        }

        private void runChoose()
        {
            if (mode == -1)
            {
                return;
            }
            else if (mode == 1)
            {
                runEncrypt();
            }
            else if (mode == 2)
            {
                runDecrypt();
            }
        }

        private void sourceTextChange_TextChanged(object sender, EventArgs e)
        {
            if (mode != 2 && StringUtil.IsNotEmpty(this.textBox_source.Text) && this.checkBox_autorun.Checked)
            {
                runEncrypt();
            }
            calcElementLength();
        }

        private void resultTextChange_TextChanged(object sender, EventArgs e)
        {
            if (mode != 1 && StringUtil.IsNotEmpty(this.textBox_result.Text) && this.checkBox_autorun.Checked)
            {
                runDecrypt();
            }
            calcElementLength();
        }

        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_decrypt_Click(object sender, EventArgs e)
        {
            runDecrypt();
            calcElementLength();
        }

        private void runDecrypt()
        {
            // 置为当前操作为解密操作
            mode = 2;
            try
            {
                string text = this.textBox_result.Text;
                if (StringUtil.IsEmpty(text))
                {
                    // 非空才解密
                    return;
                }
                string key = this.textBox_key.Text;
                string iv = this.textBox_iv.Text;

                string result = EncryptUtil.AES_Decrypt(GetMode(), GetPadding(), text, key, iv);

                this.textBox_source.Text = result;
            }
            catch (Exception e)
            {
                MessageBox.Show("解密错误：" + e.Message);
            }
        }
    }
}
