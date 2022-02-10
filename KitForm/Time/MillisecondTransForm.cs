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

namespace niushuai233Kit.KitForm.Time
{
    public partial class MillisecondTransForm : Form
    {
        public MillisecondTransForm(KitApplication kitApplication)
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            // 初始化系统时间
            Timer timer = new Timer();
            timer.Enabled = true;
            // 毫秒, 防止跳秒
            timer.Interval = 1;
            timer.Tick += new EventHandler(SystemTimeTick);
            timer.Start();
        }


        /// <summary>
        /// 是否带ms
        /// </summary>
        /// <returns></returns>
        private bool IsMillisecondFlag()
        {
            if (this.radioButton_unit_ms.Checked)
            {
                return true;
            }

            return false;
        }


        /// <summary>
        /// 更新面板label值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SystemTimeTick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            this.label_system_time.Text = now.ToString("yyyy-MM-dd HH:mm:ss");
            this.label_s.Text = DateUtil.ToUnixTimeSeconds(now).ToString();
            this.label_millis.Text = DateUtil.ToUnixTimeMilliseconds(now).ToString();
        }

        private void label_system_time_Click(object sender, EventArgs e)
        {
            string text = this.label_system_time.Text;
            this.dateTimePicker_datetime_mills_source.Value = DateUtil.ParseDateTime(text);
            this.textBox_datetime_millis_source.Text = text;
        }

        private void label_millis_Click(object sender, EventArgs e)
        {
            this.textBox_mills_datetime_source.Text = this.label_millis.Text;
        }

        private void label_s_Click(object sender, EventArgs e)
        {
            this.textBox_mills_datetime_source.Text = this.label_s.Text;
        }

        private void button_datetime_mills1_Click(object sender, EventArgs e)
        {
            DateTime dt = this.dateTimePicker_datetime_mills_source.Value;

            if (IsMillisecondFlag())
            {
                // 毫秒
                this.textBox_datetime_millis_result1.Text = DateUtil.ToUnixTimeMilliseconds(dt).ToString();
            }
            else
            {
                // 秒
                this.textBox_datetime_millis_result1.Text = DateUtil.ToUnixTimeSeconds(dt).ToString();
            }
        }

        private void button_datetime_mills2_Click(object sender, EventArgs e)
        {
            DateTime dt;
            string text = "";
            try
            {
                text = this.textBox_datetime_millis_source.Text;
                if (StringUtil.IsEmpty(text))
                {
                    return;
                }
                dt = DateUtil.ParseDateTime(text);
            }
            catch (Exception)
            {
                try
                {
                    dt = DateUtil.ParseDateTimeWithMilliseconds(text);
                }
                catch (Exception)
                {
                    MessageBox.Show(text + "时间格式错误");
                    return;
                }
            }

            if (IsMillisecondFlag())
            {
                // 毫秒
                this.textBox_datetime_millis_result2.Text = DateUtil.ToUnixTimeMilliseconds(dt).ToString();
            }
            else
            {
                // 秒
                this.textBox_datetime_millis_result2.Text = DateUtil.ToUnixTimeSeconds(dt).ToString();
            }
        }

        private void button_mills_datetime_Click(object sender, EventArgs e)
        {
            string source = this.textBox_mills_datetime_source.Text;
            if (StringUtil.IsEmpty(source))
            {
                return;
            }

            long val = -1;
            if (long.TryParse(source, out val))
            {
                DateTime dt = DateUtil.Millisecond2DateTime(val);
                if (IsMillisecondFlag())
                {
                    // 毫秒
                    this.textBox_millis_datetime_result.Text = DateUtil.FormatDateTimeWithMillisecond(dt);
                }
                else
                {
                    // 秒
                    this.textBox_millis_datetime_result.Text = DateUtil.FormatDateTime(dt);
                }
            } else
            {
                MessageBox.Show(source + "时间格式错误");
            }

        }
    }
}
