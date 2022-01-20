using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace niushuai233Kit.KitForm.Other
{
    public partial class AsciiForm : Form
    {
        public AsciiForm(KitApplication kitApplication)
        {
            InitializeComponent();
        }

        private void keyCode_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void keyCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.textBox1.Text = " ";
            //判断按键的 Keychar
            char keyChar = e.KeyChar;
            //转成整数显示
            int ascVal = (int)(keyChar);

            this.label_keyCode.Text = ascVal.ToString();
        }
    }
}
