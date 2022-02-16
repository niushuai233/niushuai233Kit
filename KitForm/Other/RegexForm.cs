using niushuai233Kit.Entity.Regex;
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

namespace niushuai233Kit.KitForm.Other
{
    public partial class RegexForm : Form
    {
        private static RegexPool regexPool = new RegexPool();
        public RegexForm(KitApplication kitApplication)
        {
            InitializeComponent();
        }

        private void button_match_Click(object sender, EventArgs e)
        {
            Do();
        }

        private void Do()
        {
            if (StringUtil.IsEmpty(this.textBox_source.Text) || StringUtil.IsEmpty(this.textBox_pattern.Text))
            {
                return;
            }
            // 清空
            this.textBox_result.Clear();
            this.label_tips.Text = "";

            string source = this.textBox_source.Text;
            string pattern = this.textBox_pattern.Text;
            if (this.checkBox_allMatch.Checked)
            {
                pattern = @"^" + @pattern + @"$";
            }
            // Console.WriteLine("source = {0}, pattern = {1}", source, pattern);
            // 匹配
            MatchCollection matchCollection = Regex.Matches(source, @pattern);

            for (int i = 0; i < matchCollection.Count; i++)
            {
                Match item = matchCollection[i];
                // 循环添加匹配项
                this.textBox_result.AppendText(item.Value);
                if (i != matchCollection.Count - 1)
                {
                    this.textBox_result.AppendText("\r\n");
                }
            }


            string tips = "";
            Color color = Color.Black;
            if (StringUtil.IsEmpty(this.textBox_result.Text))
            {
                tips = "未匹配";
                color = Color.Red;

            }
            else if (this.textBox_result.Text.Equals(this.textBox_source.Text))
            {
                tips = "完全匹配";
                color = Color.Green;
            }
            else
            {
                tips = "部分匹配";
                color = Color.Blue;
            }
            this.label_tips.Text = tips;
            this.label_tips.ForeColor = color;
        }

        private void radioButton_pattern_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton button = (RadioButton)sender;

            string tag = button.Tag.ToString();

            System.Reflection.FieldInfo[] fieldInfos = ReflectUtil.GetAllField<RegexPool>();

            foreach (var item in fieldInfos)
            {
                if (item.Name.Equals(tag))
                {
                    this.textBox_pattern.Text = (string)item.GetValue(regexPool);
                    return;
                }
            }


        }

        private void textBox_auto_TextChanged(object sender, EventArgs e)
        {
            Do();
        }
    }
}
