using Newtonsoft.Json;
using niushuai233Kit.Entity.Github;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace niushuai233Kit.Updater
{
    public partial class AutoupdaterForm : Form
    {
        private Releases releases;
        public AutoupdaterForm(Entity.Github.Releases newestReleases)
        {
            releases = newestReleases;
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            this.textBox1.Text = releases.body;
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_update_Click(object sender, EventArgs e)
        {

        }
    }
}
