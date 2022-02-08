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
        static bool started = false;
        static DateTime endDateTime;
        string defaultDisplayText = "00:01:30:000", displayText, endDisplayText = "00:00:00:000";
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

        /// <summary>
        /// 负责更新展示的文本
        /// </summary>
        /// <param name="displayText">待更新文本</param>
        private void UpdateDisplayText(string displayText)
        {
            this.label_left_time.Text = displayText;
        }

        private string format()
        {
            TimeSpan ts = DateUtil.Diff(endDateTime, DateTime.Now);

            int hour = ts.Days * 24 + ts.Hours;
            
            string dateDiff = hour.ToString().PadLeft(2, '0') + ":" + ts.Minutes.ToString().PadLeft(2, '0') + ":" + ts.Seconds.ToString().PadLeft(2, '0') + ":" + ts.Milliseconds;

            return dateDiff;
        }
    }
}
