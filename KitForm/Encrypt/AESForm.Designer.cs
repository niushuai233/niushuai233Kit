
namespace niushuai233Kit.KitForm.Encrypt
{
    partial class AESForm
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_key = new System.Windows.Forms.TextBox();
            this.checkBox_autorun = new System.Windows.Forms.CheckBox();
            this.button_decrypt = new System.Windows.Forms.Button();
            this.button_encrypt = new System.Windows.Forms.Button();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.textBox_source = new System.Windows.Forms.TextBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_padding = new System.Windows.Forms.ComboBox();
            this.comboBox_mode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_iv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_iv_length = new System.Windows.Forms.Label();
            this.label_key_length = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_source_length = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label_result_length = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_key);
            this.groupBox3.Location = new System.Drawing.Point(12, 247);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(396, 89);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "密钥";
            // 
            // textBox_key
            // 
            this.textBox_key.Location = new System.Drawing.Point(6, 25);
            this.textBox_key.Multiline = true;
            this.textBox_key.Name = "textBox_key";
            this.textBox_key.Size = new System.Drawing.Size(378, 53);
            this.textBox_key.TabIndex = 2;
            this.textBox_key.Text = "abcdefghijklmnop";
            this.textBox_key.TextChanged += new System.EventHandler(this.textChange_TextChanged);
            // 
            // checkBox_autorun
            // 
            this.checkBox_autorun.AutoSize = true;
            this.checkBox_autorun.Checked = true;
            this.checkBox_autorun.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_autorun.Location = new System.Drawing.Point(664, 315);
            this.checkBox_autorun.Name = "checkBox_autorun";
            this.checkBox_autorun.Size = new System.Drawing.Size(91, 20);
            this.checkBox_autorun.TabIndex = 13;
            this.checkBox_autorun.Text = "自动操作";
            this.checkBox_autorun.UseVisualStyleBackColor = true;
            // 
            // button_decrypt
            // 
            this.button_decrypt.Location = new System.Drawing.Point(542, 283);
            this.button_decrypt.Name = "button_decrypt";
            this.button_decrypt.Size = new System.Drawing.Size(75, 23);
            this.button_decrypt.TabIndex = 12;
            this.button_decrypt.Text = "解密";
            this.button_decrypt.UseVisualStyleBackColor = true;
            // 
            // button_encrypt
            // 
            this.button_encrypt.Location = new System.Drawing.Point(428, 283);
            this.button_encrypt.Name = "button_encrypt";
            this.button_encrypt.Size = new System.Drawing.Size(75, 23);
            this.button_encrypt.TabIndex = 11;
            this.button_encrypt.Text = "加密";
            this.button_encrypt.UseVisualStyleBackColor = true;
            this.button_encrypt.Click += new System.EventHandler(this.button_encrypt_Click);
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(12, 342);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(750, 160);
            this.textBox_result.TabIndex = 8;
            this.textBox_result.TextChanged += new System.EventHandler(this.textChange_TextChanged);
            // 
            // textBox_source
            // 
            this.textBox_source.Location = new System.Drawing.Point(12, 83);
            this.textBox_source.Multiline = true;
            this.textBox_source.Name = "textBox_source";
            this.textBox_source.Size = new System.Drawing.Size(750, 160);
            this.textBox_source.TabIndex = 7;
            this.textBox_source.TextChanged += new System.EventHandler(this.textChange_TextChanged);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(666, 270);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 23);
            this.button_clear.TabIndex = 14;
            this.button_clear.Text = "清空";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox_iv);
            this.groupBox2.Controls.Add(this.comboBox_padding);
            this.groupBox2.Controls.Add(this.comboBox_mode);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(750, 71);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AES加密, 由于校验规则过于复杂, 尤其是参数的长度问题, 因此自己校验（原谅我的lazy）";
            // 
            // comboBox_padding
            // 
            this.comboBox_padding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_padding.FormattingEnabled = true;
            this.comboBox_padding.Items.AddRange(new object[] {
            "None",
            "PKCS7",
            "Zeros",
            "ANSIX923",
            "ISO10126"});
            this.comboBox_padding.Location = new System.Drawing.Point(320, 39);
            this.comboBox_padding.Name = "comboBox_padding";
            this.comboBox_padding.Size = new System.Drawing.Size(121, 24);
            this.comboBox_padding.TabIndex = 3;
            this.comboBox_padding.SelectedValueChanged += new System.EventHandler(this.comboBox_padding_SelectedValueChanged);
            // 
            // comboBox_mode
            // 
            this.comboBox_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_mode.FormattingEnabled = true;
            this.comboBox_mode.Items.AddRange(new object[] {
            "CBC",
            "ECB",
            "OFB",
            "CFB",
            "CTS"});
            this.comboBox_mode.Location = new System.Drawing.Point(57, 39);
            this.comboBox_mode.Name = "comboBox_mode";
            this.comboBox_mode.Size = new System.Drawing.Size(121, 24);
            this.comboBox_mode.TabIndex = 2;
            this.comboBox_mode.SelectedIndexChanged += new System.EventHandler(this.comboBox_mode_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "补码方式：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "模式：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(551, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "︽︽︽";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "︾︾︾";
            // 
            // textBox_iv
            // 
            this.textBox_iv.Location = new System.Drawing.Point(556, 38);
            this.textBox_iv.Name = "textBox_iv";
            this.textBox_iv.Size = new System.Drawing.Size(157, 26);
            this.textBox_iv.TabIndex = 10;
            this.textBox_iv.Text = "1234567812345678";
            this.textBox_iv.TextChanged += new System.EventHandler(this.textChange_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(501, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "向量：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 509);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "向量长：";
            // 
            // label_iv_length
            // 
            this.label_iv_length.AutoSize = true;
            this.label_iv_length.ForeColor = System.Drawing.Color.Red;
            this.label_iv_length.Location = new System.Drawing.Point(89, 509);
            this.label_iv_length.Name = "label_iv_length";
            this.label_iv_length.Size = new System.Drawing.Size(16, 16);
            this.label_iv_length.TabIndex = 19;
            this.label_iv_length.Text = " ";
            // 
            // label_key_length
            // 
            this.label_key_length.AutoSize = true;
            this.label_key_length.ForeColor = System.Drawing.Color.Red;
            this.label_key_length.Location = new System.Drawing.Point(275, 509);
            this.label_key_length.Name = "label_key_length";
            this.label_key_length.Size = new System.Drawing.Size(16, 16);
            this.label_key_length.TabIndex = 21;
            this.label_key_length.Text = " ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(208, 509);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "秘钥长：";
            // 
            // label_source_length
            // 
            this.label_source_length.AutoSize = true;
            this.label_source_length.ForeColor = System.Drawing.Color.Red;
            this.label_source_length.Location = new System.Drawing.Point(461, 509);
            this.label_source_length.Name = "label_source_length";
            this.label_source_length.Size = new System.Drawing.Size(16, 16);
            this.label_source_length.TabIndex = 23;
            this.label_source_length.Text = " ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(394, 509);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "源串长：";
            // 
            // label_result_length
            // 
            this.label_result_length.AutoSize = true;
            this.label_result_length.ForeColor = System.Drawing.Color.Red;
            this.label_result_length.Location = new System.Drawing.Point(655, 509);
            this.label_result_length.Name = "label_result_length";
            this.label_result_length.Size = new System.Drawing.Size(16, 16);
            this.label_result_length.TabIndex = 25;
            this.label_result_length.Text = " ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(588, 509);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 16);
            this.label13.TabIndex = 24;
            this.label13.Text = "密文长：";
            // 
            // AESForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 526);
            this.Controls.Add(this.label_result_length);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label_source_length);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label_key_length);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label_iv_length);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.checkBox_autorun);
            this.Controls.Add(this.button_decrypt);
            this.Controls.Add(this.button_encrypt);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.textBox_source);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AESForm";
            this.Text = "AESForm";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_key;
        private System.Windows.Forms.CheckBox checkBox_autorun;
        private System.Windows.Forms.Button button_decrypt;
        private System.Windows.Forms.Button button_encrypt;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.TextBox textBox_source;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_padding;
        private System.Windows.Forms.ComboBox comboBox_mode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_iv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_iv_length;
        private System.Windows.Forms.Label label_key_length;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_source_length;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_result_length;
        private System.Windows.Forms.Label label13;
    }
}