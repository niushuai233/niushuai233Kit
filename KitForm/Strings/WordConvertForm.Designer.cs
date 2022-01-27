
namespace niushuai233Kit.KitForm.Strings
{
    partial class WordConvertForm
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.upper_first_button = new System.Windows.Forms.Button();
            this.lower_button = new System.Windows.Forms.Button();
            this.upper_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(16, 16);
            this.textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(746, 384);
            this.textBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.upper_first_button);
            this.groupBox1.Controls.Add(this.lower_button);
            this.groupBox1.Controls.Add(this.upper_button);
            this.groupBox1.Location = new System.Drawing.Point(16, 414);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(747, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作区";
            // 
            // upper_first_button
            // 
            this.upper_first_button.Location = new System.Drawing.Point(288, 25);
            this.upper_first_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.upper_first_button.Name = "upper_first_button";
            this.upper_first_button.Size = new System.Drawing.Size(125, 30);
            this.upper_first_button.TabIndex = 2;
            this.upper_first_button.Text = "首字母大写";
            this.upper_first_button.UseVisualStyleBackColor = true;
            this.upper_first_button.Click += new System.EventHandler(this.upper_first_button_Click);
            // 
            // lower_button
            // 
            this.lower_button.Location = new System.Drawing.Point(148, 25);
            this.lower_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lower_button.Name = "lower_button";
            this.lower_button.Size = new System.Drawing.Size(125, 30);
            this.lower_button.TabIndex = 1;
            this.lower_button.Text = "转小写";
            this.lower_button.UseVisualStyleBackColor = true;
            this.lower_button.Click += new System.EventHandler(this.lower_button_Click);
            // 
            // upper_button
            // 
            this.upper_button.Location = new System.Drawing.Point(8, 25);
            this.upper_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.upper_button.Name = "upper_button";
            this.upper_button.Size = new System.Drawing.Size(125, 30);
            this.upper_button.TabIndex = 0;
            this.upper_button.Text = "转大写";
            this.upper_button.UseVisualStyleBackColor = true;
            this.upper_button.Click += new System.EventHandler(this.upper_button_Click);
            // 
            // WordConvertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 526);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WordConvertForm";
            this.Text = "大小写转换";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button upper_button;
        private System.Windows.Forms.Button upper_first_button;
        private System.Windows.Forms.Button lower_button;
    }
}