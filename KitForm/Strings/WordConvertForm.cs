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
    public partial class WordConvertForm : Form
    {
        public WordConvertForm(KitApplication kitApplication)
        {
            InitializeComponent();
        }

        private string GetText()
        {
            return this.textBox.Text.Trim();
        }

        private void SetText(string text)
        {
            this.textBox.Text = text;
        }


        /// <summary>
        /// 转大写
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void upper_button_Click(object sender, EventArgs e)
        {
            SetText(GetText().ToUpper());
        }

        /// <summary>
        /// 转小写
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lower_button_Click(object sender, EventArgs e)
        {
            SetText(GetText().ToLower());
        }

        /// <summary>
        /// 首字母大写
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void upper_first_button_Click(object sender, EventArgs e)
        {
            string[] arr = GetText().Split(' ');
            string str = "";
            if (arr.Length == 1)
            {
                SetText(arr[0].ToUpper());
            }
            // 至少两位
            foreach (var item in arr)
            {
                str += (item.Substring(0, 1).ToUpper() + item.Substring(1) + " ");
            }

            SetText(str.Trim());
        }
    }
}
