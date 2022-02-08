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

namespace niushuai233Kit.KitForm.Other
{
    public partial class CountDownMiniForm : Form
    {

        public CountDownMiniForm(CountDownForm countDownForm)
        {
            InitializeComponent();
            // 添加更新事件
            countDownForm.CustomTextUpdated += new CountDownForm.TextUpdated(this.changeText);
        }
        
        public void changeText(string text)
        {
            this.label1.Text = text;
        }


        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                WinAPI.ReleaseCapture();
                WinAPI.SendMessage(this.Handle, WinAPI.WM_NCLBUTTONDOWN, WinAPI.HT_CAPTION, 0);
            }
        }
    }
}
