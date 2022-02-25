
namespace niushuai233Kit.KitForm.Other
{
    partial class ClipboardForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_max_history = new System.Windows.Forms.NumericUpDown();
            this.listView_main = new System.Windows.Forms.ListView();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_keyword = new System.Windows.Forms.TextBox();
            this.button_start = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_max_history)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_stop);
            this.groupBox1.Controls.Add(this.button_start);
            this.groupBox1.Controls.Add(this.textBox_keyword);
            this.groupBox1.Controls.Add(this.button_search);
            this.groupBox1.Controls.Add(this.numericUpDown_max_history);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "最大历史记录数：";
            // 
            // numericUpDown_max_history
            // 
            this.numericUpDown_max_history.Location = new System.Drawing.Point(136, 20);
            this.numericUpDown_max_history.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDown_max_history.Name = "numericUpDown_max_history";
            this.numericUpDown_max_history.Size = new System.Drawing.Size(96, 26);
            this.numericUpDown_max_history.TabIndex = 1;
            this.numericUpDown_max_history.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // listView_main
            // 
            this.listView_main.HideSelection = false;
            this.listView_main.Location = new System.Drawing.Point(13, 149);
            this.listView_main.Name = "listView_main";
            this.listView_main.Size = new System.Drawing.Size(759, 355);
            this.listView_main.TabIndex = 1;
            this.listView_main.UseCompatibleStateImageBehavior = false;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(647, 62);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(100, 32);
            this.button_search.TabIndex = 2;
            this.button_search.Text = "搜索";
            this.button_search.UseVisualStyleBackColor = true;
            // 
            // textBox_keyword
            // 
            this.textBox_keyword.Location = new System.Drawing.Point(6, 66);
            this.textBox_keyword.Name = "textBox_keyword";
            this.textBox_keyword.Size = new System.Drawing.Size(625, 26);
            this.textBox_keyword.TabIndex = 5;
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(530, 17);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(100, 32);
            this.button_start.TabIndex = 6;
            this.button_start.Text = "开始记录";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(647, 17);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(100, 32);
            this.button_stop.TabIndex = 7;
            this.button_stop.Text = "停止记录";
            this.button_stop.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(555, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tips: 双击选中即可复制到剪贴板";
            // 
            // ClipboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 516);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView_main);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClipboardForm";
            this.Text = "ClipboardForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_max_history)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown_max_history;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_keyword;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.ListView listView_main;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label2;
    }
}