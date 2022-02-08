
namespace niushuai233Kit.KitForm.Other
{
    partial class CountDownForm
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label_left_time = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.numericUpDown_hour = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_minute = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_second = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_minute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_second)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label_left_time
            // 
            this.label_left_time.AutoSize = true;
            this.label_left_time.Font = new System.Drawing.Font("Times New Roman", 63.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_left_time.ForeColor = System.Drawing.Color.Red;
            this.label_left_time.Location = new System.Drawing.Point(138, 72);
            this.label_left_time.Name = "label_left_time";
            this.label_left_time.Size = new System.Drawing.Size(501, 97);
            this.label_left_time.TabIndex = 0;
            this.label_left_time.Text = "00:01:30:000";
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("宋体", 16F);
            this.button_start.Location = new System.Drawing.Point(221, 383);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(100, 35);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "开始";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_stop
            // 
            this.button_stop.Font = new System.Drawing.Font("宋体", 16F);
            this.button_stop.Location = new System.Drawing.Point(475, 383);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(100, 35);
            this.button_stop.TabIndex = 2;
            this.button_stop.Text = "停止";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // button_reset
            // 
            this.button_reset.Font = new System.Drawing.Font("宋体", 16F);
            this.button_reset.Location = new System.Drawing.Point(345, 383);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(100, 35);
            this.button_reset.TabIndex = 3;
            this.button_reset.Text = "重置";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // numericUpDown_hour
            // 
            this.numericUpDown_hour.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_hour.Location = new System.Drawing.Point(140, 250);
            this.numericUpDown_hour.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDown_hour.Name = "numericUpDown_hour";
            this.numericUpDown_hour.Size = new System.Drawing.Size(120, 44);
            this.numericUpDown_hour.TabIndex = 4;
            // 
            // numericUpDown_minute
            // 
            this.numericUpDown_minute.Font = new System.Drawing.Font("宋体", 24F);
            this.numericUpDown_minute.Location = new System.Drawing.Point(327, 250);
            this.numericUpDown_minute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown_minute.Name = "numericUpDown_minute";
            this.numericUpDown_minute.Size = new System.Drawing.Size(120, 44);
            this.numericUpDown_minute.TabIndex = 5;
            this.numericUpDown_minute.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_second
            // 
            this.numericUpDown_second.Font = new System.Drawing.Font("宋体", 24F);
            this.numericUpDown_second.Location = new System.Drawing.Point(515, 250);
            this.numericUpDown_second.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown_second.Name = "numericUpDown_second";
            this.numericUpDown_second.Size = new System.Drawing.Size(120, 44);
            this.numericUpDown_second.TabIndex = 6;
            this.numericUpDown_second.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 24F);
            this.label1.Location = new System.Drawing.Point(260, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "h :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 24F);
            this.label2.Location = new System.Drawing.Point(447, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 33);
            this.label2.TabIndex = 8;
            this.label2.Text = "m :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 24F);
            this.label3.Location = new System.Drawing.Point(635, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 33);
            this.label3.TabIndex = 9;
            this.label3.Text = "s";
            // 
            // CountDownForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 516);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_second);
            this.Controls.Add(this.numericUpDown_minute);
            this.Controls.Add(this.numericUpDown_hour);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.label_left_time);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CountDownForm";
            this.Text = "CountDownForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_minute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_second)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label_left_time;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.NumericUpDown numericUpDown_hour;
        private System.Windows.Forms.NumericUpDown numericUpDown_minute;
        private System.Windows.Forms.NumericUpDown numericUpDown_second;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}