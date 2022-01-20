
namespace niushuai233Kit.KitForm.Strings
{
    partial class WordCountForm
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox_content = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_chinese_count = new System.Windows.Forms.Label();
            this.label_chinese_symbol_count = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_english_count = new System.Windows.Forms.Label();
            this.label_english_symbol_count = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_number_count = new System.Windows.Forms.Label();
            this.label_total_count = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox_content
            // 
            this.textBox_content.Location = new System.Drawing.Point(16, 16);
            this.textBox_content.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_content.Multiline = true;
            this.textBox_content.Name = "textBox_content";
            this.textBox_content.Size = new System.Drawing.Size(746, 384);
            this.textBox_content.TabIndex = 2;
            this.textBox_content.TextChanged += new System.EventHandler(this.contentTextChange_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "中文字符总数：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "中文标点总数：";
            // 
            // label_chinese_count
            // 
            this.label_chinese_count.AutoSize = true;
            this.label_chinese_count.ForeColor = System.Drawing.Color.Red;
            this.label_chinese_count.Location = new System.Drawing.Point(141, 32);
            this.label_chinese_count.Name = "label_chinese_count";
            this.label_chinese_count.Size = new System.Drawing.Size(16, 16);
            this.label_chinese_count.TabIndex = 5;
            this.label_chinese_count.Text = "0";
            // 
            // label_chinese_symbol_count
            // 
            this.label_chinese_symbol_count.AutoSize = true;
            this.label_chinese_symbol_count.ForeColor = System.Drawing.Color.Red;
            this.label_chinese_symbol_count.Location = new System.Drawing.Point(141, 65);
            this.label_chinese_symbol_count.Name = "label_chinese_symbol_count";
            this.label_chinese_symbol_count.Size = new System.Drawing.Size(16, 16);
            this.label_chinese_symbol_count.TabIndex = 6;
            this.label_chinese_symbol_count.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "英文字符总数： ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "英文标点总数：";
            // 
            // label_english_count
            // 
            this.label_english_count.AutoSize = true;
            this.label_english_count.ForeColor = System.Drawing.Color.Red;
            this.label_english_count.Location = new System.Drawing.Point(378, 32);
            this.label_english_count.Name = "label_english_count";
            this.label_english_count.Size = new System.Drawing.Size(16, 16);
            this.label_english_count.TabIndex = 9;
            this.label_english_count.Text = "0";
            // 
            // label_english_symbol_count
            // 
            this.label_english_symbol_count.AutoSize = true;
            this.label_english_symbol_count.ForeColor = System.Drawing.Color.Red;
            this.label_english_symbol_count.Location = new System.Drawing.Point(378, 65);
            this.label_english_symbol_count.Name = "label_english_symbol_count";
            this.label_english_symbol_count.Size = new System.Drawing.Size(16, 16);
            this.label_english_symbol_count.TabIndex = 10;
            this.label_english_symbol_count.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(520, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "数字字符总数：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(552, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "总字符数：";
            // 
            // label_number_count
            // 
            this.label_number_count.AutoSize = true;
            this.label_number_count.ForeColor = System.Drawing.Color.Red;
            this.label_number_count.Location = new System.Drawing.Point(647, 32);
            this.label_number_count.Name = "label_number_count";
            this.label_number_count.Size = new System.Drawing.Size(16, 16);
            this.label_number_count.TabIndex = 13;
            this.label_number_count.Text = "0";
            // 
            // label_total_count
            // 
            this.label_total_count.AutoSize = true;
            this.label_total_count.ForeColor = System.Drawing.Color.Red;
            this.label_total_count.Location = new System.Drawing.Point(647, 65);
            this.label_total_count.Name = "label_total_count";
            this.label_total_count.Size = new System.Drawing.Size(16, 16);
            this.label_total_count.TabIndex = 14;
            this.label_total_count.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label_total_count);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label_number_count);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label_chinese_count);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label_chinese_symbol_count);
            this.groupBox1.Controls.Add(this.label_english_symbol_count);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label_english_count);
            this.groupBox1.Location = new System.Drawing.Point(16, 414);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 100);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "统计区";
            // 
            // WordCountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 526);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_content);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WordCountForm";
            this.Text = "字数统计";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox_content;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_chinese_count;
        private System.Windows.Forms.Label label_chinese_symbol_count;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_english_count;
        private System.Windows.Forms.Label label_english_symbol_count;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_number_count;
        private System.Windows.Forms.Label label_total_count;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}