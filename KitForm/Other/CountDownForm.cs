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
        long time = (1 * 60 + 15) * 1000;
        public CountDownForm(KitApplication kitApplication)
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            this.timer.Start();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            this.timer.Stop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time--;

            if (time == 0)
            {
                this.label_left_time.Text = "0";
                this.timer.Stop();
            }
            this.label_left_time.Text = time.ToString();
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            time = (1 * 60 + 15) * 1000;
            this.label_left_time.Text = time.ToString();
        }
    }
}
