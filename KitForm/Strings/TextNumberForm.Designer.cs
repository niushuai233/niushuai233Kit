
namespace niushuai233Kit.KitForm.Strings
{
    partial class TextNumberForm
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
            this.textBox_converter_area = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_numberPrefix = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_ignoreEmptyLine = new System.Windows.Forms.CheckBox();
            this.button_run = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_converter_area
            // 
            this.textBox_converter_area.Location = new System.Drawing.Point(16, 16);
            this.textBox_converter_area.Multiline = true;
            this.textBox_converter_area.Name = "textBox_converter_area";
            this.textBox_converter_area.Size = new System.Drawing.Size(746, 384);
            this.textBox_converter_area.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_run);
            this.groupBox1.Controls.Add(this.checkBox_ignoreEmptyLine);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_numberPrefix);
            this.groupBox1.Location = new System.Drawing.Point(16, 414);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作区";
            // 
            // comboBox_numberPrefix
            // 
            this.comboBox_numberPrefix.FormattingEnabled = true;
            this.comboBox_numberPrefix.Items.AddRange(new object[] {
            "n.",
            "n,",
            "n、",
            "n-",
            "n#",
            "n)",
            "n）",
            "(n)",
            "（n）"});
            this.comboBox_numberPrefix.Location = new System.Drawing.Point(108, 23);
            this.comboBox_numberPrefix.Name = "comboBox_numberPrefix";
            this.comboBox_numberPrefix.Size = new System.Drawing.Size(88, 24);
            this.comboBox_numberPrefix.TabIndex = 0;
            this.comboBox_numberPrefix.SelectedValueChanged += new System.EventHandler(this.numberPrefix_Changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "序号格式：";
            // 
            // checkBox_ignoreEmptyLine
            // 
            this.checkBox_ignoreEmptyLine.AutoSize = true;
            this.checkBox_ignoreEmptyLine.Location = new System.Drawing.Point(209, 25);
            this.checkBox_ignoreEmptyLine.Name = "checkBox_ignoreEmptyLine";
            this.checkBox_ignoreEmptyLine.Size = new System.Drawing.Size(91, 20);
            this.checkBox_ignoreEmptyLine.TabIndex = 2;
            this.checkBox_ignoreEmptyLine.Text = "忽略空行";
            this.checkBox_ignoreEmptyLine.UseVisualStyleBackColor = true;
            // 
            // button_run
            // 
            this.button_run.Location = new System.Drawing.Point(7, 61);
            this.button_run.Name = "button_run";
            this.button_run.Size = new System.Drawing.Size(75, 23);
            this.button_run.TabIndex = 3;
            this.button_run.Text = "执行";
            this.button_run.UseVisualStyleBackColor = true;
            this.button_run.Click += new System.EventHandler(this.button_run_Click);
            // 
            // TextNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 526);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_converter_area);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TextNumberForm";
            this.Text = "TextNumberForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_converter_area;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_numberPrefix;
        private System.Windows.Forms.CheckBox checkBox_ignoreEmptyLine;
        private System.Windows.Forms.Button button_run;
    }
}