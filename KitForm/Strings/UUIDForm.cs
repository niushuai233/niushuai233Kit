using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace niushuai233Kit.KitForm.Strings
{
    public partial class UUIDForm : Form
    {
        public UUIDForm(KitApplication kitApplication)
        {
            InitializeComponent();
        }

        private void button_generate_Click(object sender, EventArgs e)
        {
            int count = ((int)this.numericUpDown_count.Value);
            for (int i = 0; i < count; i++)
            {
                string guid = GetUpperCase() ? System.Guid.NewGuid().ToString().ToUpper() : System.Guid.NewGuid().ToString();
                guid = this.checkBox_midline.Checked ? guid : guid.Replace("-", "");

                this.textBox_uuid.AppendText(guid + "\r\n");
            }
        }

        private bool GetUpperCase()
        {
            if (this.radioButton_lower.Checked)
            {
                return false;
            }
            if (this.radioButton_upper.Checked)
            {
                return true;
            }
            return false;
        }
    }
}
