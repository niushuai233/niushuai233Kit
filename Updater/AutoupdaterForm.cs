using Newtonsoft.Json;
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
        public AutoupdaterForm(Entity.Github.Releases newestReleases)
        {
            InitializeComponent();
            this.textBox1.Text = JsonConvert.SerializeObject(newestReleases, Formatting.Indented);

            while (true)
            {

            }
        }
    }
}
