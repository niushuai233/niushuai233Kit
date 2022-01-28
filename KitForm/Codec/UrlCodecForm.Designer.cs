
namespace niushuai233Kit.KitForm.Codec
{
    partial class UrlCodecForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.encrypted_groupBox_decoded = new System.Windows.Forms.GroupBox();
            this.encrypted_groupBox_encoded = new System.Windows.Forms.GroupBox();
            this.encrypt_textBox_decoded = new System.Windows.Forms.TextBox();
            this.encrypt_textBox_encoded = new System.Windows.Forms.TextBox();
            this.button_encode = new System.Windows.Forms.Button();
            this.button_decode = new System.Windows.Forms.Button();
            this.encrypted_groupBox_decoded.SuspendLayout();
            this.encrypted_groupBox_encoded.SuspendLayout();
            this.SuspendLayout();
            // 
            // encrypted_groupBox_decoded
            // 
            this.encrypted_groupBox_decoded.Controls.Add(this.encrypt_textBox_decoded);
            this.encrypted_groupBox_decoded.Location = new System.Drawing.Point(12, 12);
            this.encrypted_groupBox_decoded.Name = "encrypted_groupBox_decoded";
            this.encrypted_groupBox_decoded.Size = new System.Drawing.Size(570, 185);
            this.encrypted_groupBox_decoded.TabIndex = 0;
            this.encrypted_groupBox_decoded.TabStop = false;
            this.encrypted_groupBox_decoded.Text = "解码区";
            // 
            // encrypted_groupBox_encoded
            // 
            this.encrypted_groupBox_encoded.Controls.Add(this.encrypt_textBox_encoded);
            this.encrypted_groupBox_encoded.Location = new System.Drawing.Point(12, 213);
            this.encrypted_groupBox_encoded.Name = "encrypted_groupBox_encoded";
            this.encrypted_groupBox_encoded.Size = new System.Drawing.Size(570, 185);
            this.encrypted_groupBox_encoded.TabIndex = 1;
            this.encrypted_groupBox_encoded.TabStop = false;
            this.encrypted_groupBox_encoded.Text = "编码区";
            // 
            // encrypt_textBox_decoded
            // 
            this.encrypt_textBox_decoded.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.encrypt_textBox_decoded.Location = new System.Drawing.Point(7, 20);
            this.encrypt_textBox_decoded.Multiline = true;
            this.encrypt_textBox_decoded.Name = "encrypt_textBox_decoded";
            this.encrypt_textBox_decoded.Size = new System.Drawing.Size(557, 158);
            this.encrypt_textBox_decoded.TabIndex = 0;
            // 
            // encrypt_textBox_encoded
            // 
            this.encrypt_textBox_encoded.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.encrypt_textBox_encoded.Location = new System.Drawing.Point(7, 20);
            this.encrypt_textBox_encoded.Multiline = true;
            this.encrypt_textBox_encoded.Name = "encrypt_textBox_encoded";
            this.encrypt_textBox_encoded.Size = new System.Drawing.Size(557, 158);
            this.encrypt_textBox_encoded.TabIndex = 0;
            // 
            // button_encode
            // 
            this.button_encode.Location = new System.Drawing.Point(130, 197);
            this.button_encode.Name = "button_encode";
            this.button_encode.Size = new System.Drawing.Size(75, 23);
            this.button_encode.TabIndex = 2;
            this.button_encode.Text = "︾ 编码 ︾";
            this.button_encode.UseVisualStyleBackColor = true;
            this.button_encode.Click += new System.EventHandler(this.button_encode_Click);
            // 
            // button_decode
            // 
            this.button_decode.Location = new System.Drawing.Point(382, 197);
            this.button_decode.Name = "button_decode";
            this.button_decode.Size = new System.Drawing.Size(75, 23);
            this.button_decode.TabIndex = 3;
            this.button_decode.Text = "︽ 解码 ︽";
            this.button_decode.UseVisualStyleBackColor = true;
            this.button_decode.Click += new System.EventHandler(this.button_decode_Click);
            // 
            // UrlCodecForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 411);
            this.Controls.Add(this.button_decode);
            this.Controls.Add(this.button_encode);
            this.Controls.Add(this.encrypted_groupBox_encoded);
            this.Controls.Add(this.encrypted_groupBox_decoded);
            this.Name = "UrlCodecForm";
            this.Text = "Url编解码";
            this.encrypted_groupBox_decoded.ResumeLayout(false);
            this.encrypted_groupBox_decoded.PerformLayout();
            this.encrypted_groupBox_encoded.ResumeLayout(false);
            this.encrypted_groupBox_encoded.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox encrypted_groupBox_decoded;
        private System.Windows.Forms.GroupBox encrypted_groupBox_encoded;
        private System.Windows.Forms.TextBox encrypt_textBox_decoded;
        private System.Windows.Forms.TextBox encrypt_textBox_encoded;
        private System.Windows.Forms.Button button_encode;
        private System.Windows.Forms.Button button_decode;
    }
}