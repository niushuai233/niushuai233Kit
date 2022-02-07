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
    public partial class MD5Form : Form
    {
        public MD5Form(KitApplication kitApplication)
        {
            InitializeComponent();
        }

        private void button_encrypt_Click(object sender, EventArgs e)
        {
            run();
        }

        private void run()
        {
            string source = this.textBox_source.Text;
            string salt = this.textBox_salt.Text;
            string value = source;
            if (StringUtil.IsNotEmpty(salt))
            {
                if (this.radioButton_salt_before.Checked)
                {
                    value = salt + source;
                }
                if (this.radioButton_salt_after.Checked)
                {
                    value = source + salt;
                }
            }

            this.textBox_result.Text = EncryptUtil.MD5(value, GetBit(), GetStyle()).Replace("-", "");
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

        private int GetBit()
        {
            if (this.radioButton_bit_16.Checked)
            {
                return 16;
            }
            else if (this.radioButton_bit_32.Checked)
            {
                return 32;
            }
            //默认32
            return 32;
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

        /// <summary>
        /// 是否自动操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (StringUtil.IsNotEmpty(this.textBox_source.Text) && this.checkBox_autorun.Checked)
            {
                run();
            }
        }

        private void textBox_source_textChange(object sender, EventArgs e)
        {
            if (StringUtil.IsNotEmpty(this.textBox_source.Text) && this.checkBox_autorun.Checked)
            {
                run();
            }
        }
    }
}
