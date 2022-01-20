
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
        public KitApplication()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 字数统计 form表单
        /// </summary>
        /// <param name="sender">触发</param>
        /// <param name="e">参数</param>
        private void string_button_wordCount_Click(object sender, EventArgs e)
        {
            WordCountForm form = new WordCountForm(this);

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            // 清空面板
            this.string_groupBox_result.Controls.Clear();
            // 添加新的面板
            this.string_groupBox_result.Controls.Add(form);

            form.Show();
        }
    }
}
