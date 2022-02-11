
namespace niushuai233Kit.KitForm.Other
{
    partial class TranslationForm
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
            this.button_settings = new System.Windows.Forms.Button();
            this.textBox_source = new System.Windows.Forms.TextBox();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.button_translate = new System.Windows.Forms.Button();
            this.comboBox_language_source = new System.Windows.Forms.ComboBox();
            this.comboBox_language_result = new System.Windows.Forms.ComboBox();
            this.checkBox_auto_translate = new System.Windows.Forms.CheckBox();
            this.pictureBox_content_exchange = new System.Windows.Forms.PictureBox();
            this.pictureBox_language_exchange = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_content_exchange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_language_exchange)).BeginInit();
            this.SuspendLayout();
            // 
            // button_settings
            // 
            this.button_settings.Font = new System.Drawing.Font("宋体", 11F);
            this.button_settings.Location = new System.Drawing.Point(697, 10);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(75, 23);
            this.button_settings.TabIndex = 0;
            this.button_settings.Text = "设置";
            this.button_settings.UseVisualStyleBackColor = true;
            this.button_settings.Click += new System.EventHandler(this.button_settings_Click);
            // 
            // textBox_source
            // 
            this.textBox_source.Location = new System.Drawing.Point(12, 45);
            this.textBox_source.Multiline = true;
            this.textBox_source.Name = "textBox_source";
            this.textBox_source.Size = new System.Drawing.Size(760, 200);
            this.textBox_source.TabIndex = 1;
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(12, 304);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(760, 200);
            this.textBox_result.TabIndex = 2;
            // 
            // button_translate
            // 
            this.button_translate.Font = new System.Drawing.Font("宋体", 11F);
            this.button_translate.Location = new System.Drawing.Point(480, 263);
            this.button_translate.Name = "button_translate";
            this.button_translate.Size = new System.Drawing.Size(75, 23);
            this.button_translate.TabIndex = 3;
            this.button_translate.Text = "翻译";
            this.button_translate.UseVisualStyleBackColor = true;
            this.button_translate.Click += new System.EventHandler(this.button_translate_Click);
            // 
            // comboBox_language_source
            // 
            this.comboBox_language_source.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_language_source.FormattingEnabled = true;
            this.comboBox_language_source.Location = new System.Drawing.Point(13, 263);
            this.comboBox_language_source.Name = "comboBox_language_source";
            this.comboBox_language_source.Size = new System.Drawing.Size(121, 24);
            this.comboBox_language_source.TabIndex = 4;
            // 
            // comboBox_language_result
            // 
            this.comboBox_language_result.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_language_result.FormattingEnabled = true;
            this.comboBox_language_result.Location = new System.Drawing.Point(210, 263);
            this.comboBox_language_result.Name = "comboBox_language_result";
            this.comboBox_language_result.Size = new System.Drawing.Size(121, 24);
            this.comboBox_language_result.TabIndex = 5;
            // 
            // checkBox_auto_translate
            // 
            this.checkBox_auto_translate.AutoSize = true;
            this.checkBox_auto_translate.Checked = true;
            this.checkBox_auto_translate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_auto_translate.Location = new System.Drawing.Point(677, 265);
            this.checkBox_auto_translate.Name = "checkBox_auto_translate";
            this.checkBox_auto_translate.Size = new System.Drawing.Size(91, 20);
            this.checkBox_auto_translate.TabIndex = 7;
            this.checkBox_auto_translate.Text = "自动翻译";
            this.checkBox_auto_translate.UseVisualStyleBackColor = true;
            // 
            // pictureBox_content_exchange
            // 
            this.pictureBox_content_exchange.Location = new System.Drawing.Point(421, 259);
            this.pictureBox_content_exchange.Name = "pictureBox_content_exchange";
            this.pictureBox_content_exchange.Size = new System.Drawing.Size(32, 32);
            this.pictureBox_content_exchange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_content_exchange.TabIndex = 10;
            this.pictureBox_content_exchange.TabStop = false;
            this.pictureBox_content_exchange.Click += new System.EventHandler(this.pictureBox_content_exchange_Click);
            this.pictureBox_content_exchange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_exchange_MouseDown);
            this.pictureBox_content_exchange.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_exchange_MouseUp);
            // 
            // pictureBox_language_exchange
            // 
            this.pictureBox_language_exchange.Location = new System.Drawing.Point(156, 259);
            this.pictureBox_language_exchange.Name = "pictureBox_language_exchange";
            this.pictureBox_language_exchange.Size = new System.Drawing.Size(32, 32);
            this.pictureBox_language_exchange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_language_exchange.TabIndex = 9;
            this.pictureBox_language_exchange.TabStop = false;
            this.pictureBox_language_exchange.Click += new System.EventHandler(this.pictureBox_language_exchange_Click);
            this.pictureBox_language_exchange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_exchange_MouseDown);
            this.pictureBox_language_exchange.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_exchange_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "翻译引擎：";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Google翻译",
            "百度翻译"});
            this.comboBox1.Location = new System.Drawing.Point(96, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 12;
            // 
            // TranslationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 516);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_content_exchange);
            this.Controls.Add(this.pictureBox_language_exchange);
            this.Controls.Add(this.checkBox_auto_translate);
            this.Controls.Add(this.comboBox_language_result);
            this.Controls.Add(this.comboBox_language_source);
            this.Controls.Add(this.button_translate);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.textBox_source);
            this.Controls.Add(this.button_settings);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TranslationForm";
            this.Text = "TranslationForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_content_exchange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_language_exchange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_settings;
        private System.Windows.Forms.TextBox textBox_source;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Button button_translate;
        private System.Windows.Forms.ComboBox comboBox_language_source;
        private System.Windows.Forms.ComboBox comboBox_language_result;
        private System.Windows.Forms.CheckBox checkBox_auto_translate;
        private System.Windows.Forms.PictureBox pictureBox_language_exchange;
        private System.Windows.Forms.PictureBox pictureBox_content_exchange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}