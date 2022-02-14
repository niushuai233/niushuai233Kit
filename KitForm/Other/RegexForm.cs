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
        public RegexForm(KitApplication kitApplication)
        {
            InitializeComponent();
        }

        private void button_match_Click(object sender, EventArgs e)
        {
            // 清空
            this.textBox_result.Clear();

            string source = this.textBox_source.Text;
            string pattern = this.textBox_pattern.Text;
            Console.WriteLine("source = {0}, pattern = {1}", source, pattern);
            // 匹配
            MatchCollection matchCollection = Regex.Matches(source, @pattern);

            foreach (Match item in matchCollection)
            {
                // 循环添加匹配项
                this.textBox_result.AppendText(item.Value + "\r\n");
            }
        }

        private void radioButton_pattern_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton button = (RadioButton)sender;
            
            
        }
    }
}
