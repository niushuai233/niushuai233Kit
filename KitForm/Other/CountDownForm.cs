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
    public partial class CountDownForm : Form
    {

        public delegate void TextUpdated(string text);
        public event TextUpdated CustomTextUpdated;

        static bool started = false;
        static DateTime endDateTime;
        string defaultDisplayText = "00:01:30:000", displayText, endDisplayText = "----------------";
        static CountDownMiniForm mini;
        public CountDownForm(KitApplication kitApplication)
        {
            InitializeComponent();
            started = false;
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            long ms = DateUtil.HMS2Millisecond(
                (int)this.numericUpDown_hour.Value,
                (int)this.numericUpDown_minute.Value,
                (int)this.numericUpDown_second.Value);

            endDateTime = DateTime.Now.AddMilliseconds(ms);

            this.timer.Start();
            started = true;
            this.button_start.Enabled = false;
            this.button_stop.Enabled = true;
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            this.timer.Stop();
            started = false;
            this.button_start.Enabled = true;
            this.button_stop.Enabled = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            if (DateUtil.After(DateTime.Now, endDateTime) || DateUtil.Equals(DateTime.Now, endDateTime))
            {
                displayText = endDisplayText;
                this.timer.Stop();
                started = false;
                this.button_start.Enabled = true;
                this.button_stop.Enabled = false;
            }
            else
            {
                displayText = format();
            }

            UpdateDisplayText(displayText);
        }


        private void button_reset_Click(object sender, EventArgs e)
        {
            if (!started)
            {
                this.numericUpDown_hour.Value = 0;
                this.numericUpDown_minute.Value = 1;
                this.numericUpDown_second.Value = 30;
                this.displayText = defaultDisplayText;
                UpdateDisplayText(displayText);
            }
        }

        private void button_mini_Click(object sender, EventArgs e)
        {
            if (mini == null)
            {
                //创建一个新窗体
                mini = new CountDownMiniForm(this);

                //设置窗体无边框
                mini.FormBorderStyle = FormBorderStyle.None;
                //让窗体透明
                mini.BackColor = Color.White;
                mini.TransparencyKey = mini.BackColor;
                // 最上层显示
                mini.ShowInTaskbar = false;
                mini.TopLevel = true;
                mini.TopMost = true;

                mini.Show();

                this.button_mini.Text = "关闭精简";
            } else
            {
                mini.Close();
                mini = null;
                this.button_mini.Text = "打开精简";
            }
        }

        /// <summary>
        /// 负责更新展示的文本
        /// </summary>
        /// <param name="displayText">待更新文本</param>
        private void UpdateDisplayText(string displayText)
        {
            this.label_left_time.Text = displayText;
            if (mini != null)
            {
                // 精简窗口显示时才更新
                CustomTextUpdated(displayText);
            }
        }

        private string format()
        {
            TimeSpan ts = DateUtil.Diff(endDateTime, DateTime.Now);

            string hour = "";
            if (ts.Hours != 0)
            {
                hour = (ts.Days * 24 + ts.Hours).ToString().PadLeft(2, '0') + ":";
            }

            string dateDiff = hour + ts.Minutes.ToString().PadLeft(2, '0') + ":" + ts.Seconds.ToString().PadLeft(2, '0') + ":" + ts.Milliseconds.ToString().PadLeft(3, '0');

            return dateDiff;
        }
    }
}
