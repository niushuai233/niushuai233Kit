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
    public partial class Base64Form : Form
    {
        public Base64Form(KitApplication kitApplication)
        {
            InitializeComponent();
        }

        private void base64_button_encode_Click(object sender, EventArgs e)
        {
            EncoderRun();

        }

        private void EncoderRun()
        {
            string text = this.base64_textBox_decoded.Text;
            if (StringUtil.IsNotEmpty(text))
            {
                this.base64_textBox_encoded.Text = EncrypyUtil.Base64Encode(text);
            }
        }

        private void base64_button_decode_Click(object sender, EventArgs e)
        {
            DecodeRun();
        }

        private void DecodeRun()
        {
            string text = this.base64_textBox_encoded.Text;
            if (StringUtil.IsNotEmpty(text))
            {
                this.base64_textBox_decoded.Text = EncrypyUtil.Base64Decode(text);
            }
        }
    }
}
