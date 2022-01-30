
namespace niushuai233Kit.KitForm.Encrypt
{
    partial class MD5Form
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
            this.textBox_source = new System.Windows.Forms.TextBox();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_style_upper = new System.Windows.Forms.RadioButton();
            this.radioButton_style_lower = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_bit_32 = new System.Windows.Forms.RadioButton();
            this.radioButton_bit_16 = new System.Windows.Forms.RadioButton();
            this.button_encrypt = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.checkBox_autorun = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton_salt_after = new System.Windows.Forms.RadioButton();
            this.radioButton_salt_before = new System.Windows.Forms.RadioButton();
            this.textBox_salt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_source
            // 
            this.textBox_source.Location = new System.Drawing.Point(12, 12);
            this.textBox_source.Multiline = true;
            this.textBox_source.Name = "textBox_source";
            this.textBox_source.Size = new System.Drawing.Size(750, 200);
            this.textBox_source.TabIndex = 0;
            this.textBox_source.TextChanged += new System.EventHandler(this.textBox_source_textChange);
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(12, 314);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(750, 200);
            this.textBox_result.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_style_upper);
            this.groupBox1.Controls.Add(this.radioButton_style_lower);
            this.groupBox1.Location = new System.Drawing.Point(172, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 89);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "大小写";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_bit_32);
            this.groupBox2.Controls.Add(this.radioButton_bit_16);
            this.groupBox2.Location = new System.Drawing.Point(12, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(133, 89);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "位宽";
            // 
            // radioButton_bit_32
            // 
            this.radioButton_bit_32.AutoSize = true;
            this.radioButton_bit_32.Location = new System.Drawing.Point(7, 58);
            this.radioButton_bit_32.Name = "radioButton_bit_32";
            this.radioButton_bit_32.Size = new System.Drawing.Size(42, 20);
            this.radioButton_bit_32.TabIndex = 1;
            this.radioButton_bit_32.Text = "32";
            this.radioButton_bit_32.UseVisualStyleBackColor = true;
            this.radioButton_bit_32.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton_bit_16
            // 
            this.radioButton_bit_16.AutoSize = true;
            this.radioButton_bit_16.Checked = true;
            this.radioButton_bit_16.Location = new System.Drawing.Point(7, 26);
            this.radioButton_bit_16.Name = "radioButton_bit_16";
            this.radioButton_bit_16.Size = new System.Drawing.Size(42, 20);
            this.radioButton_bit_16.TabIndex = 0;
            this.radioButton_bit_16.TabStop = true;
            this.radioButton_bit_16.Text = "16";
            this.radioButton_bit_16.UseVisualStyleBackColor = true;
            this.radioButton_bit_16.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // button_encrypt
            // 
            this.button_encrypt.Location = new System.Drawing.Point(664, 219);
            this.button_encrypt.Name = "button_encrypt";
            this.button_encrypt.Size = new System.Drawing.Size(75, 23);
            this.button_encrypt.TabIndex = 4;
            this.button_encrypt.Text = "加密";
            this.button_encrypt.UseVisualStyleBackColor = true;
            this.button_encrypt.Click += new System.EventHandler(this.button_encrypt_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(664, 253);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 23);
            this.button_clear.TabIndex = 5;
            this.button_clear.Text = "清空";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // checkBox_autorun
            // 
            this.checkBox_autorun.AutoSize = true;
            this.checkBox_autorun.Checked = true;
            this.checkBox_autorun.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_autorun.Location = new System.Drawing.Point(664, 287);
            this.checkBox_autorun.Name = "checkBox_autorun";
            this.checkBox_autorun.Size = new System.Drawing.Size(91, 20);
            this.checkBox_autorun.TabIndex = 6;
            this.checkBox_autorun.Text = "自动操作";
            this.checkBox_autorun.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_salt);
            this.groupBox3.Controls.Add(this.radioButton_salt_after);
            this.groupBox3.Controls.Add(this.radioButton_salt_before);
            this.groupBox3.Location = new System.Drawing.Point(332, 219);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(179, 89);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "盐值";
            // 
            // radioButton_salt_after
            // 
            this.radioButton_salt_after.AutoSize = true;
            this.radioButton_salt_after.Location = new System.Drawing.Point(89, 58);
            this.radioButton_salt_after.Name = "radioButton_salt_after";
            this.radioButton_salt_after.Size = new System.Drawing.Size(90, 20);
            this.radioButton_salt_after.TabIndex = 1;
            this.radioButton_salt_after.Text = "盐值在后";
            this.radioButton_salt_after.UseVisualStyleBackColor = true;
            this.radioButton_salt_after.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton_salt_before
            // 
            this.radioButton_salt_before.AutoSize = true;
            this.radioButton_salt_before.Checked = true;
            this.radioButton_salt_before.Location = new System.Drawing.Point(4, 58);
            this.radioButton_salt_before.Name = "radioButton_salt_before";
            this.radioButton_salt_before.Size = new System.Drawing.Size(90, 20);
            this.radioButton_salt_before.TabIndex = 0;
            this.radioButton_salt_before.TabStop = true;
            this.radioButton_salt_before.Text = "盐值在前";
            this.radioButton_salt_before.UseVisualStyleBackColor = true;
            this.radioButton_salt_before.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // textBox_salt
            // 
            this.textBox_salt.Location = new System.Drawing.Point(6, 25);
            this.textBox_salt.Name = "textBox_salt";
            this.textBox_salt.Size = new System.Drawing.Size(167, 26);
            this.textBox_salt.TabIndex = 2;
            // 
            // MD5Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 526);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.checkBox_autorun);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_encrypt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.textBox_source);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MD5Form";
            this.Text = "MD5Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_source;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_encrypt;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.RadioButton radioButton_style_upper;
        private System.Windows.Forms.RadioButton radioButton_style_lower;
        private System.Windows.Forms.RadioButton radioButton_bit_32;
        private System.Windows.Forms.RadioButton radioButton_bit_16;
        private System.Windows.Forms.CheckBox checkBox_autorun;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton_salt_after;
        private System.Windows.Forms.RadioButton radioButton_salt_before;
        private System.Windows.Forms.TextBox textBox_salt;
    }
}