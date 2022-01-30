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

namespace niushuai233Kit.KitForm.Codec
{
    public partial class EscapeForm : Form
    {
        public EscapeForm(KitApplication kitApplication)
        {
            InitializeComponent();
        }

        private void escape_button_encode_Click(object sender, EventArgs e)
        {
            EncoderRun();
        }
        private void EncoderRun()
        {
            string text = this.escape_textBox_decoded.Text;
            if (StringUtil.IsNotEmpty(text))
            {
                this.escape_textBox_encoded.Text = CodecUtil.EscapeEncode(text);
            }
        }

        private void escape_button_decode_Click(object sender, EventArgs e)
        {
            DecodeRun();
        }

        private void DecodeRun()
        {
            string text = this.escape_textBox_encoded.Text;
            if (StringUtil.IsNotEmpty(text))
            {
                this.escape_textBox_decoded.Text = CodecUtil.EscapeDecode(text);
            }
        }
    }
}
