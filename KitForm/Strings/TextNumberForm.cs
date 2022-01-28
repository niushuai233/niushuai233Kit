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

namespace niushuai233Kit.KitForm.Strings
{
    public partial class TextNumberForm : Form
    {

        private static string numberPrefix = "";

        public TextNumberForm(KitApplication kitApplication)
        {
            InitializeComponent();
            // 默认选中第一个
            this.comboBox_numberPrefix.SelectedIndex = 0;
        }

        /// <summary>
        /// 做替换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_run_Click(object sender, EventArgs e)
        {
            string[] text = this.textBox_converter_area.Lines;
            string[] newText = new string[text.Length];
            for (int i = 0; i < text.Length; i++ )
            {
                if (IsIgnoreEmptyLine() && StringUtil.IsEmpty(text[i]))
                {
                    // 忽略空行
                    continue;
                }
                newText[i] = numberPrefix.Replace("n", (i + 1) + "") + text[i];
            }

            this.textBox_converter_area.Lines = newText;

        }

        /// <summary>
        /// 格式改变时更新模板
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numberPrefix_Changed(object sender, EventArgs e)
        {
            if (comboBox_numberPrefix.SelectedIndex != -1)
            {
                numberPrefix = this.comboBox_numberPrefix.Text;
            }
        }


        private bool IsIgnoreEmptyLine()
        {
            return this.checkBox_ignoreEmptyLine.Checked;
        }

        
    }
}
