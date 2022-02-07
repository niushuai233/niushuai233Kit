
using System.Windows.Forms;

namespace niushuai233Kit.KitForm.Encrypt
{
    partial class SHAForm : Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_512 = new System.Windows.Forms.RadioButton();
            this.radioButton_384 = new System.Windows.Forms.RadioButton();
            this.radioButton_256 = new System.Windows.Forms.RadioButton();
            this.radioButton_sha1 = new System.Windows.Forms.RadioButton();
            this.textBox_source = new System.Windows.Forms.TextBox();
            this.checkBox_autorun = new System.Windows.Forms.CheckBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_encrypt = new System.Windows.Forms.Button();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_style_upper = new System.Windows.Forms.RadioButton();
            this.radioButton_style_lower = new System.Windows.Forms.RadioButton();
            this.radioButton_224 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_224);
            this.groupBox1.Controls.Add(this.radioButton_512);
            this.groupBox1.Controls.Add(this.radioButton_384);
            this.groupBox1.Controls.Add(this.radioButton_256);
            this.groupBox1.Controls.Add(this.radioButton_sha1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "哈希算法 - 可能是指SHA2, 而不是SHA3";
            // 
            // radioButton_512
            // 
            this.radioButton_512.AutoSize = true;
            this.radioButton_512.Location = new System.Drawing.Point(584, 25);
            this.radioButton_512.Name = "radioButton_512";
            this.radioButton_512.Size = new System.Drawing.Size(82, 20);
            this.radioButton_512.TabIndex = 4;
            this.radioButton_512.Text = "SHA-512";
            this.radioButton_512.UseVisualStyleBackColor = true;
            this.radioButton_512.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton_384
            // 
            this.radioButton_384.AutoSize = true;
            this.radioButton_384.Location = new System.Drawing.Point(436, 25);
            this.radioButton_384.Name = "radioButton_384";
            this.radioButton_384.Size = new System.Drawing.Size(82, 20);
            this.radioButton_384.TabIndex = 3;
            this.radioButton_384.Text = "SHA-384";
            this.radioButton_384.UseVisualStyleBackColor = true;
            this.radioButton_384.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton_256
            // 
            this.radioButton_256.AutoSize = true;
            this.radioButton_256.Location = new System.Drawing.Point(288, 25);
            this.radioButton_256.Name = "radioButton_256";
            this.radioButton_256.Size = new System.Drawing.Size(82, 20);
            this.radioButton_256.TabIndex = 2;
            this.radioButton_256.Text = "SHA-256";
            this.radioButton_256.UseVisualStyleBackColor = true;
            this.radioButton_256.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton_sha1
            // 
            this.radioButton_sha1.AutoSize = true;
            this.radioButton_sha1.Checked = true;
            this.radioButton_sha1.Location = new System.Drawing.Point(8, 25);
            this.radioButton_sha1.Name = "radioButton_sha1";
            this.radioButton_sha1.Size = new System.Drawing.Size(66, 20);
            this.radioButton_sha1.TabIndex = 0;
            this.radioButton_sha1.TabStop = true;
            this.radioButton_sha1.Text = "SHA-1";
            this.radioButton_sha1.UseVisualStyleBackColor = true;
            this.radioButton_sha1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // textBox_source
            // 
            this.textBox_source.Location = new System.Drawing.Point(12, 73);
            this.textBox_source.Multiline = true;
            this.textBox_source.Name = "textBox_source";
            this.textBox_source.Size = new System.Drawing.Size(750, 165);
            this.textBox_source.TabIndex = 1;
            this.textBox_source.TextChanged += new System.EventHandler(this.textBox_source_textChange);
            // 
            // checkBox_autorun
            // 
            this.checkBox_autorun.AutoSize = true;
            this.checkBox_autorun.Checked = true;
            this.checkBox_autorun.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_autorun.Location = new System.Drawing.Point(687, 320);
            this.checkBox_autorun.Name = "checkBox_autorun";
            this.checkBox_autorun.Size = new System.Drawing.Size(91, 20);
            this.checkBox_autorun.TabIndex = 9;
            this.checkBox_autorun.Text = "自动操作";
            this.checkBox_autorun.UseVisualStyleBackColor = true;
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(687, 286);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 23);
            this.button_clear.TabIndex = 8;
            this.button_clear.Text = "清空";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_encrypt
            // 
            this.button_encrypt.Location = new System.Drawing.Point(687, 252);
            this.button_encrypt.Name = "button_encrypt";
            this.button_encrypt.Size = new System.Drawing.Size(75, 23);
            this.button_encrypt.TabIndex = 7;
            this.button_encrypt.Text = "加密";
            this.button_encrypt.UseVisualStyleBackColor = true;
            this.button_encrypt.Click += new System.EventHandler(this.button_encrypt_Click);
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(13, 349);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(750, 165);
            this.textBox_result.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_style_upper);
            this.groupBox2.Controls.Add(this.radioButton_style_lower);
            this.groupBox2.Location = new System.Drawing.Point(20, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(133, 89);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "大小写";
            // 
            // radioButton_style_upper
            // 
            this.radioButton_style_upper.AutoSize = true;
            this.radioButton_style_upper.Location = new System.Drawing.Point(7, 58);
            this.radioButton_style_upper.Name = "radioButton_style_upper";
            this.radioButton_style_upper.Size = new System.Drawing.Size(58, 20);
            this.radioButton_style_upper.TabIndex = 1;
            this.radioButton_style_upper.Text = "大写";
            this.radioButton_style_upper.UseVisualStyleBackColor = true;
            this.radioButton_style_upper.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton_style_lower
            // 
            this.radioButton_style_lower.AutoSize = true;
            this.radioButton_style_lower.Checked = true;
            this.radioButton_style_lower.Location = new System.Drawing.Point(7, 26);
            this.radioButton_style_lower.Name = "radioButton_style_lower";
            this.radioButton_style_lower.Size = new System.Drawing.Size(58, 20);
            this.radioButton_style_lower.TabIndex = 0;
            this.radioButton_style_lower.TabStop = true;
            this.radioButton_style_lower.Text = "小写";
            this.radioButton_style_lower.UseVisualStyleBackColor = true;
            this.radioButton_style_lower.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton_224
            // 
            this.radioButton_224.AutoSize = true;
            this.radioButton_224.Location = new System.Drawing.Point(140, 25);
            this.radioButton_224.Name = "radioButton_224";
            this.radioButton_224.Size = new System.Drawing.Size(82, 20);
            this.radioButton_224.TabIndex = 5;
            this.radioButton_224.TabStop = true;
            this.radioButton_224.Text = "SHA-224";
            this.radioButton_224.UseVisualStyleBackColor = true;
            this.radioButton_224.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // SHAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 526);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.checkBox_autorun);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_encrypt);
            this.Controls.Add(this.textBox_source);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SHAForm";
            this.Text = "SHAForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_512;
        private System.Windows.Forms.RadioButton radioButton_384;
        private System.Windows.Forms.RadioButton radioButton_256;
        private System.Windows.Forms.RadioButton radioButton_sha1;
        private System.Windows.Forms.TextBox textBox_source;
        private System.Windows.Forms.CheckBox checkBox_autorun;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_encrypt;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_style_upper;
        private System.Windows.Forms.RadioButton radioButton_style_lower;
        private RadioButton radioButton_224;
    }
}