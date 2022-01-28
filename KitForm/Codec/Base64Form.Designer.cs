
namespace niushuai233Kit.KitForm.Codec
{
    partial class Base64Form
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
            this.base64_button_decode = new System.Windows.Forms.Button();
            this.base64_button_encode = new System.Windows.Forms.Button();
            this.base64_groupBox_encoded = new System.Windows.Forms.GroupBox();
            this.base64_textBox_encoded = new System.Windows.Forms.TextBox();
            this.base64_groupBox_decoded = new System.Windows.Forms.GroupBox();
            this.base64_textBox_decoded = new System.Windows.Forms.TextBox();
            this.base64_groupBox_encoded.SuspendLayout();
            this.base64_groupBox_decoded.SuspendLayout();
            this.SuspendLayout();
            // 
            // base64_button_decode
            // 
            this.base64_button_decode.Location = new System.Drawing.Point(382, 197);
            this.base64_button_decode.Name = "base64_button_decode";
            this.base64_button_decode.Size = new System.Drawing.Size(75, 23);
            this.base64_button_decode.TabIndex = 7;
            this.base64_button_decode.Text = "︽ 解码 ︽";
            this.base64_button_decode.UseVisualStyleBackColor = true;
            this.base64_button_decode.Click += new System.EventHandler(this.base64_button_decode_Click);
            // 
            // base64_button_encode
            // 
            this.base64_button_encode.Location = new System.Drawing.Point(130, 197);
            this.base64_button_encode.Name = "base64_button_encode";
            this.base64_button_encode.Size = new System.Drawing.Size(75, 23);
            this.base64_button_encode.TabIndex = 6;
            this.base64_button_encode.Text = "︾ 编码 ︾";
            this.base64_button_encode.UseVisualStyleBackColor = true;
            this.base64_button_encode.Click += new System.EventHandler(this.base64_button_encode_Click);
            // 
            // base64_groupBox_encoded
            // 
            this.base64_groupBox_encoded.Controls.Add(this.base64_textBox_encoded);
            this.base64_groupBox_encoded.Location = new System.Drawing.Point(12, 213);
            this.base64_groupBox_encoded.Name = "base64_groupBox_encoded";
            this.base64_groupBox_encoded.Size = new System.Drawing.Size(570, 185);
            this.base64_groupBox_encoded.TabIndex = 5;
            this.base64_groupBox_encoded.TabStop = false;
            this.base64_groupBox_encoded.Text = "编码区";
            // 
            // base64_textBox_encoded
            // 
            this.base64_textBox_encoded.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.base64_textBox_encoded.Location = new System.Drawing.Point(7, 20);
            this.base64_textBox_encoded.Multiline = true;
            this.base64_textBox_encoded.Name = "base64_textBox_encoded";
            this.base64_textBox_encoded.Size = new System.Drawing.Size(557, 158);
            this.base64_textBox_encoded.TabIndex = 0;
            // 
            // base64_groupBox_decoded
            // 
            this.base64_groupBox_decoded.Controls.Add(this.base64_textBox_decoded);
            this.base64_groupBox_decoded.Location = new System.Drawing.Point(12, 12);
            this.base64_groupBox_decoded.Name = "base64_groupBox_decoded";
            this.base64_groupBox_decoded.Size = new System.Drawing.Size(570, 185);
            this.base64_groupBox_decoded.TabIndex = 4;
            this.base64_groupBox_decoded.TabStop = false;
            this.base64_groupBox_decoded.Text = "解码区";
            // 
            // base64_textBox_decoded
            // 
            this.base64_textBox_decoded.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.base64_textBox_decoded.Location = new System.Drawing.Point(7, 20);
            this.base64_textBox_decoded.Multiline = true;
            this.base64_textBox_decoded.Name = "base64_textBox_decoded";
            this.base64_textBox_decoded.Size = new System.Drawing.Size(557, 158);
            this.base64_textBox_decoded.TabIndex = 0;
            // 
            // Base64Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 411);
            this.Controls.Add(this.base64_button_decode);
            this.Controls.Add(this.base64_button_encode);
            this.Controls.Add(this.base64_groupBox_encoded);
            this.Controls.Add(this.base64_groupBox_decoded);
            this.Name = "Base64Form";
            this.Text = "Base64编解码";
            this.base64_groupBox_encoded.ResumeLayout(false);
            this.base64_groupBox_encoded.PerformLayout();
            this.base64_groupBox_decoded.ResumeLayout(false);
            this.base64_groupBox_decoded.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button base64_button_decode;
        private System.Windows.Forms.Button base64_button_encode;
        private System.Windows.Forms.GroupBox base64_groupBox_encoded;
        private System.Windows.Forms.TextBox base64_textBox_encoded;
        private System.Windows.Forms.GroupBox base64_groupBox_decoded;
        private System.Windows.Forms.TextBox base64_textBox_decoded;
    }
}