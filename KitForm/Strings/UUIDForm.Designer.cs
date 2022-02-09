
namespace niushuai233Kit.KitForm.Strings
{
    partial class UUIDForm
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
            this.button_generate = new System.Windows.Forms.Button();
            this.textBox_uuid = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_lower = new System.Windows.Forms.RadioButton();
            this.radioButton_upper = new System.Windows.Forms.RadioButton();
            this.numericUpDown_count = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_midline = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_count)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_midline);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDown_count);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button_generate);
            this.groupBox1.Location = new System.Drawing.Point(14, 412);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(747, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作区";
            // 
            // button_generate
            // 
            this.button_generate.Location = new System.Drawing.Point(614, 62);
            this.button_generate.Margin = new System.Windows.Forms.Padding(4);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(125, 30);
            this.button_generate.TabIndex = 0;
            this.button_generate.Text = "生成";
            this.button_generate.UseVisualStyleBackColor = true;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // textBox_uuid
            // 
            this.textBox_uuid.Font = new System.Drawing.Font("宋体", 16F);
            this.textBox_uuid.Location = new System.Drawing.Point(14, 14);
            this.textBox_uuid.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_uuid.Multiline = true;
            this.textBox_uuid.Name = "textBox_uuid";
            this.textBox_uuid.Size = new System.Drawing.Size(746, 384);
            this.textBox_uuid.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_upper);
            this.groupBox2.Controls.Add(this.radioButton_lower);
            this.groupBox2.Location = new System.Drawing.Point(8, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 65);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // radioButton_lower
            // 
            this.radioButton_lower.AutoSize = true;
            this.radioButton_lower.Checked = true;
            this.radioButton_lower.Location = new System.Drawing.Point(7, 26);
            this.radioButton_lower.Name = "radioButton_lower";
            this.radioButton_lower.Size = new System.Drawing.Size(58, 20);
            this.radioButton_lower.TabIndex = 0;
            this.radioButton_lower.TabStop = true;
            this.radioButton_lower.Text = "小写";
            this.radioButton_lower.UseVisualStyleBackColor = true;
            // 
            // radioButton_upper
            // 
            this.radioButton_upper.AutoSize = true;
            this.radioButton_upper.Location = new System.Drawing.Point(71, 26);
            this.radioButton_upper.Name = "radioButton_upper";
            this.radioButton_upper.Size = new System.Drawing.Size(58, 20);
            this.radioButton_upper.TabIndex = 1;
            this.radioButton_upper.Text = "大写";
            this.radioButton_upper.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_count
            // 
            this.numericUpDown_count.Location = new System.Drawing.Point(344, 51);
            this.numericUpDown_count.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDown_count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_count.Name = "numericUpDown_count";
            this.numericUpDown_count.Size = new System.Drawing.Size(56, 26);
            this.numericUpDown_count.TabIndex = 2;
            this.numericUpDown_count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "个数：";
            // 
            // checkBox_midline
            // 
            this.checkBox_midline.AutoSize = true;
            this.checkBox_midline.Checked = true;
            this.checkBox_midline.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_midline.Location = new System.Drawing.Point(162, 53);
            this.checkBox_midline.Name = "checkBox_midline";
            this.checkBox_midline.Size = new System.Drawing.Size(107, 20);
            this.checkBox_midline.TabIndex = 4;
            this.checkBox_midline.Text = "短横线连接";
            this.checkBox_midline.UseVisualStyleBackColor = true;
            // 
            // UUIDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 526);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_uuid);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UUIDForm";
            this.Text = "UUIDForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.TextBox textBox_uuid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_upper;
        private System.Windows.Forms.RadioButton radioButton_lower;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_count;
        private System.Windows.Forms.CheckBox checkBox_midline;
    }
}