using niushuai233Kit.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace niushuai233Kit.KitForm.Other
{
    public partial class CountDownForm : Form
    {

        static SoundPlayer player = new SoundPlayer();
        static bool playStatus = false;

        public delegate void TextUpdated(string text);
        public event TextUpdated CustomTextUpdated;

        static bool started = false;
        static DateTime endDateTime;
        string defaultDisplayText = "----------------", displayText, endDisplayText = "00:00:00:000";
        static CountDownMiniForm mini;

        public CountDownForm(KitApplication kitApplication)
        {
            InitializeComponent();
            started = false;
            this.button_stop.Enabled = false;
            InitWavCombox();
        }

        private void InitWavCombox()
        {
            FileInfo[] wavArray = FileUtil.ListDirectory("C:\\Windows\\Media", ".wav");

            if (null == wavArray)
            {
                wavArray = new FileInfo[] { };
            }

            int count = wavArray.Count();

            string[][] wavs = new string[2][];

            DataTable wavDataTable = new DataTable();
            wavDataTable.Columns.Add(new DataColumn("value"));
            wavDataTable.Columns.Add(new DataColumn("display"));

            for (int i = 0; i < count; i++)
            {
                FileInfo item = wavArray[i];

                DataRow row = wavDataTable.NewRow();
                row["value"] = item.FullName;
                row["display"] = item.Name;

                wavDataTable.Rows.Add(row);
            }

            this.comboBox_media.DataSource = wavDataTable;
            this.comboBox_media.ValueMember = "value";
            this.comboBox_media.DisplayMember = "display";
            // this.comboBox_media.SelectedIndex = 0;
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
                // 置于前台显示
                WinAPI.SetForegroundWindow(this.Handle);
                // 播放提示音
                PlayStart();
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
            }
            else
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


        private void button_media_preplay_Click(object sender, EventArgs e)
        {
            string path = this.comboBox_media.SelectedValue.ToString();
            player.SoundLocation = @path;

            if (playStatus)
            {
                this.button_media_preplay.Text = "试听";
                player.Stop();
                playStatus = false;
                return;
            }
            else
            {
                player.PlayLooping();
                this.button_media_preplay.Text = "停止";
                playStatus = true;
            }
        }

        /// <summary>
        /// 倒计时结束播放音效
        /// </summary>
        private void PlayStart()
        {
            string path = this.comboBox_media.SelectedValue.ToString();

            if (StringUtil.IsNotEmpty(path))
            {
                player.SoundLocation = @path;
                player.PlayLooping();
                this.button_media_preplay.Text = "停止";
                playStatus = true;
            }
        }
    }
}
