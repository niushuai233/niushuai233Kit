
namespace niushuai233Kit.KitForm.Other
{
    partial class RegexForm
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
            this.radioButton_pattern_qq = new System.Windows.Forms.RadioButton();
            this.radioButton_pattern_ipv4 = new System.Windows.Forms.RadioButton();
            this.radioButton_pattern_idcard = new System.Windows.Forms.RadioButton();
            this.radioButton_pattern_postcode = new System.Windows.Forms.RadioButton();
            this.radioButton_pattern_mobile = new System.Windows.Forms.RadioButton();
            this.radioButton_pattern_phone = new System.Windows.Forms.RadioButton();
            this.radioButton_pattern_email = new System.Windows.Forms.RadioButton();
            this.radioButton_pattern_number = new System.Windows.Forms.RadioButton();
            this.radioButton_pattern_english = new System.Windows.Forms.RadioButton();
            this.radioButton_pattern_chinese = new System.Windows.Forms.RadioButton();
            this.textBox_pattern = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_tips = new System.Windows.Forms.Label();
            this.checkBox_allMatch = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_source
            // 
            this.textBox_source.Location = new System.Drawing.Point(15, 13);
            this.textBox_source.Multiline = true;
            this.textBox_source.Name = "textBox_source";
            this.textBox_source.Size = new System.Drawing.Size(755, 200);
            this.textBox_source.TabIndex = 0;
            this.textBox_source.TextChanged += new System.EventHandler(this.textBox_auto_TextChanged);
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(15, 304);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(755, 200);
            this.textBox_result.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_allMatch);
            this.groupBox1.Controls.Add(this.label_tips);
            this.groupBox1.Controls.Add(this.radioButton_pattern_qq);
            this.groupBox1.Controls.Add(this.radioButton_pattern_ipv4);
            this.groupBox1.Controls.Add(this.radioButton_pattern_idcard);
            this.groupBox1.Controls.Add(this.radioButton_pattern_postcode);
            this.groupBox1.Controls.Add(this.radioButton_pattern_mobile);
            this.groupBox1.Controls.Add(this.radioButton_pattern_phone);
            this.groupBox1.Controls.Add(this.radioButton_pattern_email);
            this.groupBox1.Controls.Add(this.radioButton_pattern_number);
            this.groupBox1.Controls.Add(this.radioButton_pattern_english);
            this.groupBox1.Controls.Add(this.radioButton_pattern_chinese);
            this.groupBox1.Controls.Add(this.textBox_pattern);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 86);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // radioButton_pattern_qq
            // 
            this.radioButton_pattern_qq.AutoSize = true;
            this.radioButton_pattern_qq.Location = new System.Drawing.Point(647, 53);
            this.radioButton_pattern_qq.Name = "radioButton_pattern_qq";
            this.radioButton_pattern_qq.Size = new System.Drawing.Size(42, 20);
            this.radioButton_pattern_qq.TabIndex = 3;
            this.radioButton_pattern_qq.TabStop = true;
            this.radioButton_pattern_qq.Tag = "QQ";
            this.radioButton_pattern_qq.Text = "QQ";
            this.radioButton_pattern_qq.UseVisualStyleBackColor = true;
            this.radioButton_pattern_qq.CheckedChanged += new System.EventHandler(this.radioButton_pattern_CheckedChanged);
            // 
            // radioButton_pattern_ipv4
            // 
            this.radioButton_pattern_ipv4.AutoSize = true;
            this.radioButton_pattern_ipv4.Location = new System.Drawing.Point(583, 53);
            this.radioButton_pattern_ipv4.Name = "radioButton_pattern_ipv4";
            this.radioButton_pattern_ipv4.Size = new System.Drawing.Size(58, 20);
            this.radioButton_pattern_ipv4.TabIndex = 3;
            this.radioButton_pattern_ipv4.TabStop = true;
            this.radioButton_pattern_ipv4.Tag = "IPV4";
            this.radioButton_pattern_ipv4.Text = "IPV4";
            this.radioButton_pattern_ipv4.UseVisualStyleBackColor = true;
            this.radioButton_pattern_ipv4.CheckedChanged += new System.EventHandler(this.radioButton_pattern_CheckedChanged);
            // 
            // radioButton_pattern_idcard
            // 
            this.radioButton_pattern_idcard.AutoSize = true;
            this.radioButton_pattern_idcard.Location = new System.Drawing.Point(487, 53);
            this.radioButton_pattern_idcard.Name = "radioButton_pattern_idcard";
            this.radioButton_pattern_idcard.Size = new System.Drawing.Size(90, 20);
            this.radioButton_pattern_idcard.TabIndex = 3;
            this.radioButton_pattern_idcard.TabStop = true;
            this.radioButton_pattern_idcard.Tag = "IDCard";
            this.radioButton_pattern_idcard.Text = "身份证号";
            this.radioButton_pattern_idcard.UseVisualStyleBackColor = true;
            this.radioButton_pattern_idcard.CheckedChanged += new System.EventHandler(this.radioButton_pattern_CheckedChanged);
            // 
            // radioButton_pattern_postcode
            // 
            this.radioButton_pattern_postcode.AutoSize = true;
            this.radioButton_pattern_postcode.Location = new System.Drawing.Point(423, 53);
            this.radioButton_pattern_postcode.Name = "radioButton_pattern_postcode";
            this.radioButton_pattern_postcode.Size = new System.Drawing.Size(58, 20);
            this.radioButton_pattern_postcode.TabIndex = 3;
            this.radioButton_pattern_postcode.TabStop = true;
            this.radioButton_pattern_postcode.Tag = "PostCode";
            this.radioButton_pattern_postcode.Text = "邮编";
            this.radioButton_pattern_postcode.UseVisualStyleBackColor = true;
            this.radioButton_pattern_postcode.CheckedChanged += new System.EventHandler(this.radioButton_pattern_CheckedChanged);
            // 
            // radioButton_pattern_mobile
            // 
            this.radioButton_pattern_mobile.AutoSize = true;
            this.radioButton_pattern_mobile.Location = new System.Drawing.Point(343, 53);
            this.radioButton_pattern_mobile.Name = "radioButton_pattern_mobile";
            this.radioButton_pattern_mobile.Size = new System.Drawing.Size(74, 20);
            this.radioButton_pattern_mobile.TabIndex = 3;
            this.radioButton_pattern_mobile.TabStop = true;
            this.radioButton_pattern_mobile.Tag = "Mobile";
            this.radioButton_pattern_mobile.Text = "手机号";
            this.radioButton_pattern_mobile.UseVisualStyleBackColor = true;
            this.radioButton_pattern_mobile.CheckedChanged += new System.EventHandler(this.radioButton_pattern_CheckedChanged);
            // 
            // radioButton_pattern_phone
            // 
            this.radioButton_pattern_phone.AutoSize = true;
            this.radioButton_pattern_phone.Location = new System.Drawing.Point(279, 53);
            this.radioButton_pattern_phone.Name = "radioButton_pattern_phone";
            this.radioButton_pattern_phone.Size = new System.Drawing.Size(58, 20);
            this.radioButton_pattern_phone.TabIndex = 3;
            this.radioButton_pattern_phone.TabStop = true;
            this.radioButton_pattern_phone.Tag = "Phone";
            this.radioButton_pattern_phone.Text = "座机";
            this.radioButton_pattern_phone.UseVisualStyleBackColor = true;
            this.radioButton_pattern_phone.CheckedChanged += new System.EventHandler(this.radioButton_pattern_CheckedChanged);
            // 
            // radioButton_pattern_email
            // 
            this.radioButton_pattern_email.AutoSize = true;
            this.radioButton_pattern_email.Location = new System.Drawing.Point(207, 53);
            this.radioButton_pattern_email.Name = "radioButton_pattern_email";
            this.radioButton_pattern_email.Size = new System.Drawing.Size(66, 20);
            this.radioButton_pattern_email.TabIndex = 3;
            this.radioButton_pattern_email.TabStop = true;
            this.radioButton_pattern_email.Tag = "Email";
            this.radioButton_pattern_email.Text = "Email";
            this.radioButton_pattern_email.UseVisualStyleBackColor = true;
            this.radioButton_pattern_email.CheckedChanged += new System.EventHandler(this.radioButton_pattern_CheckedChanged);
            // 
            // radioButton_pattern_number
            // 
            this.radioButton_pattern_number.AutoSize = true;
            this.radioButton_pattern_number.Location = new System.Drawing.Point(143, 53);
            this.radioButton_pattern_number.Name = "radioButton_pattern_number";
            this.radioButton_pattern_number.Size = new System.Drawing.Size(58, 20);
            this.radioButton_pattern_number.TabIndex = 3;
            this.radioButton_pattern_number.TabStop = true;
            this.radioButton_pattern_number.Tag = "NumberOnly";
            this.radioButton_pattern_number.Text = "数字";
            this.radioButton_pattern_number.UseVisualStyleBackColor = true;
            this.radioButton_pattern_number.CheckedChanged += new System.EventHandler(this.radioButton_pattern_CheckedChanged);
            // 
            // radioButton_pattern_english
            // 
            this.radioButton_pattern_english.AutoSize = true;
            this.radioButton_pattern_english.Location = new System.Drawing.Point(79, 53);
            this.radioButton_pattern_english.Name = "radioButton_pattern_english";
            this.radioButton_pattern_english.Size = new System.Drawing.Size(58, 20);
            this.radioButton_pattern_english.TabIndex = 3;
            this.radioButton_pattern_english.TabStop = true;
            this.radioButton_pattern_english.Tag = "EnglishOnly";
            this.radioButton_pattern_english.Text = "英文";
            this.radioButton_pattern_english.UseVisualStyleBackColor = true;
            this.radioButton_pattern_english.CheckedChanged += new System.EventHandler(this.radioButton_pattern_CheckedChanged);
            // 
            // radioButton_pattern_chinese
            // 
            this.radioButton_pattern_chinese.AutoSize = true;
            this.radioButton_pattern_chinese.Location = new System.Drawing.Point(15, 53);
            this.radioButton_pattern_chinese.Name = "radioButton_pattern_chinese";
            this.radioButton_pattern_chinese.Size = new System.Drawing.Size(58, 20);
            this.radioButton_pattern_chinese.TabIndex = 3;
            this.radioButton_pattern_chinese.TabStop = true;
            this.radioButton_pattern_chinese.Tag = "ChineseOnly";
            this.radioButton_pattern_chinese.Text = "中文";
            this.radioButton_pattern_chinese.UseVisualStyleBackColor = true;
            this.radioButton_pattern_chinese.CheckedChanged += new System.EventHandler(this.radioButton_pattern_CheckedChanged);
            // 
            // textBox_pattern
            // 
            this.textBox_pattern.Location = new System.Drawing.Point(106, 15);
            this.textBox_pattern.Name = "textBox_pattern";
            this.textBox_pattern.Size = new System.Drawing.Size(535, 26);
            this.textBox_pattern.TabIndex = 1;
            this.textBox_pattern.TextChanged += new System.EventHandler(this.textBox_auto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "正则表达式:";
            // 
            // label_tips
            // 
            this.label_tips.AutoSize = true;
            this.label_tips.Location = new System.Drawing.Point(688, 55);
            this.label_tips.Name = "label_tips";
            this.label_tips.Size = new System.Drawing.Size(16, 16);
            this.label_tips.TabIndex = 4;
            this.label_tips.Text = " ";
            // 
            // checkBox_allMatch
            // 
            this.checkBox_allMatch.AutoSize = true;
            this.checkBox_allMatch.Location = new System.Drawing.Point(647, 17);
            this.checkBox_allMatch.Name = "checkBox_allMatch";
            this.checkBox_allMatch.Size = new System.Drawing.Size(91, 20);
            this.checkBox_allMatch.TabIndex = 5;
            this.checkBox_allMatch.Text = "完全匹配";
            this.checkBox_allMatch.UseVisualStyleBackColor = true;
            this.checkBox_allMatch.CheckedChanged += new System.EventHandler(this.textBox_auto_TextChanged);
            // 
            // RegexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 516);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.textBox_source);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegexForm";
            this.Text = "RegexForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_source;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_pattern;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_pattern_chinese;
        private System.Windows.Forms.RadioButton radioButton_pattern_idcard;
        private System.Windows.Forms.RadioButton radioButton_pattern_postcode;
        private System.Windows.Forms.RadioButton radioButton_pattern_mobile;
        private System.Windows.Forms.RadioButton radioButton_pattern_phone;
        private System.Windows.Forms.RadioButton radioButton_pattern_email;
        private System.Windows.Forms.RadioButton radioButton_pattern_number;
        private System.Windows.Forms.RadioButton radioButton_pattern_english;
        private System.Windows.Forms.RadioButton radioButton_pattern_qq;
        private System.Windows.Forms.RadioButton radioButton_pattern_ipv4;
        private System.Windows.Forms.Label label_tips;
        private System.Windows.Forms.CheckBox checkBox_allMatch;
    }
}