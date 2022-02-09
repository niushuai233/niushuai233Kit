using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace niushuai233Kit.KitForm.Menus
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            // 初始化图片
            this.pictureBox1.Image = Properties.Resources.niushuai233Kit;
        }

        private void button_about_confirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
