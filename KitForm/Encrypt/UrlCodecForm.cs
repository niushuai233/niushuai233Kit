using niushuai233Kit.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace niushuai233Kit.KitForm.Encrypt
{
    public partial class UrlCodecForm : Form
    {
        public UrlCodecForm(KitApplication kitApplication)
        {
            InitializeComponent();
        }

        private void button_encode_Click(object sender, EventArgs e)
        {
            EncoderRun();
        }

        private void EncoderRun()
        {
            string text = this.encrypt_textBox_decoded.Text;
            if (StringUtil.IsNotEmpty(text))
            {
                this.encrypt_textBox_encoded.Text = HttpUtility.UrlEncode(text);
            }
        }

        private void button_decode_Click(object sender, EventArgs e)
        {
            DecodeRun();
        }

        private void DecodeRun()
        {
            string text = this.encrypt_textBox_encoded.Text;
            if (StringUtil.IsNotEmpty(text))
            {
                this.encrypt_textBox_decoded.Text = HttpUtility.UrlDecode(text);
            }
        }
    }
}
