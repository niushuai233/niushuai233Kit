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
    public partial class ClipboardForm : Form
    {
        public ClipboardForm(KitApplication kitApplication)
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            if (WinAPI.WM_CLIPBOARDUPDATE == m.Msg)
            {
                WithContent();
                return;
            }
            base.WndProc(ref m);
        }

        private void WithContent()
        {
           
            IDataObject dataObject = Clipboard.GetDataObject();

            Type type = dataObject.GetType();

            string[] vs = dataObject.GetFormats();
            Console.WriteLine();

            foreach (var item in vs)
            {
                if (dataObject.GetDataPresent(item))
                {
                    object v = dataObject.GetData(item);
                    Console.WriteLine("{} - {}", item, v.ToString());
                }
            }
            

            string text = Clipboard.GetText();
            this.richTextBox1.Text = text;

        }

        private void button_start_Click(object sender, EventArgs e)
        {
            WinAPI.AddClipboardFormatListener(this.Handle);
        }


    }
}
