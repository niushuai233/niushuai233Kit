using niushuai233Kit.Entity.Enums;
using niushuai233Kit.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace niushuai233Kit.KitForm.Strings
{
    public partial class WordCountForm : Form
    {
        public WordCountForm(KitApplication kitApplication)
        {
            InitializeComponent();
        }

        private void contentTextChange_Click(object sender, EventArgs e)
        {
            resetVal();
            count();
        }

        private void resetVal()
        {
            // 重置值
            this.label_chinese_count.Text = "0";
            this.label_chinese_symbol_count.Text = "0";
            this.label_english_count.Text = "0";
            this.label_english_symbol_count.Text = "0";
            this.label_number_count.Text = "0";
            this.label_total_count.Text = "0";
        }

        /// <summary>
        /// 统计字数
        /// </summary>
        private void count()
        {
            string content = this.textBox_content.Text.Trim();
            this.label_total_count.Text = content.Length + "";
            // 字符串转换为字符数组  依次比较
            char[] chars = content.ToCharArray();

            foreach (var item in chars)
            {
                CharType charType = GetCharType(item);
                Console.WriteLine("char = {0}, type = {1}", item, charType);
                switch(charType)
                {
                    case CharType.Chinese:
                        // 中文
                        this.label_chinese_count.Text = (int.Parse(this.label_chinese_count.Text.ToString()) + 1).ToString();
                        break;
                    case CharType.Chinese_Symbol:
                        // 中文字符
                        this.label_chinese_symbol_count.Text = (int.Parse(this.label_chinese_symbol_count.Text.ToString()) + 1).ToString();
                        break;
                    case CharType.English:
                        // 英文
                        this.label_english_count.Text = (int.Parse(this.label_english_count.Text.ToString()) + 1).ToString();
                        break;
                    case CharType.English_Symbol:
                        // 英文字符
                        this.label_english_symbol_count.Text = (int.Parse(this.label_english_symbol_count.Text.ToString()) + 1).ToString();
                        break;
                    case CharType.Number:
                        // 数字
                        this.label_number_count.Text = (int.Parse(this.label_number_count.Text.ToString()) + 1).ToString();
                        break;
                    case CharType.Default:
                        Console.WriteLine("未知字符: " + item);
                        break;
                }
            }
        }

        private CharType GetCharType(char item)
        {

            // 是否为中文
            if (StringUtil.IsChinese(item))
            {
                return CharType.Chinese;
            }
            // 是否为字母
            if (StringUtil.IsEnglish(item))
            {
                return CharType.English;
            }
            // 是否为数字
            if (NumberUtil.IsNumber(item))
            {
                return CharType.Number;
            }
            // 是否为中文字符
            if (StringUtil.IsSymbolOfChinese(item))
            {
                return CharType.Chinese_Symbol;
            }
            // 是否为英文字符
            if (StringUtil.IsSymbolOfEnglish(item))
            {
                return CharType.English_Symbol;
            }

            return CharType.Default;
        }
    }
}
