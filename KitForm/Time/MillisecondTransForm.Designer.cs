
namespace niushuai233Kit.KitForm.Time
{
    partial class MillisecondTransForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_datetime_mills_source = new System.Windows.Forms.DateTimePicker();
            this.button_datetime_mills1 = new System.Windows.Forms.Button();
            this.textBox_datetime_millis_result1 = new System.Windows.Forms.TextBox();
            this.textBox_datetime_millis_result2 = new System.Windows.Forms.TextBox();
            this.button_datetime_mills2 = new System.Windows.Forms.Button();
            this.textBox_datetime_millis_source = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_millis_datetime_result = new System.Windows.Forms.TextBox();
            this.button_mills_datetime = new System.Windows.Forms.Button();
            this.textBox_mills_datetime_source = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_system_time = new System.Windows.Forms.Label();
            this.label_s = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton_unit_s = new System.Windows.Forms.RadioButton();
            this.radioButton_unit_ms = new System.Windows.Forms.RadioButton();
            this.label_millis = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 11F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前系统时间：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 11F);
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "时间戳(s)：";
            // 
            // dateTimePicker_datetime_mills_source
            // 
            this.dateTimePicker_datetime_mills_source.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker_datetime_mills_source.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_datetime_mills_source.Location = new System.Drawing.Point(82, 42);
            this.dateTimePicker_datetime_mills_source.Name = "dateTimePicker_datetime_mills_source";
            this.dateTimePicker_datetime_mills_source.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker_datetime_mills_source.TabIndex = 2;
            // 
            // button_datetime_mills1
            // 
            this.button_datetime_mills1.Location = new System.Drawing.Point(320, 42);
            this.button_datetime_mills1.Name = "button_datetime_mills1";
            this.button_datetime_mills1.Size = new System.Drawing.Size(75, 23);
            this.button_datetime_mills1.TabIndex = 3;
            this.button_datetime_mills1.Text = "转换>>";
            this.button_datetime_mills1.UseVisualStyleBackColor = true;
            this.button_datetime_mills1.Click += new System.EventHandler(this.button_datetime_mills1_Click);
            // 
            // textBox_datetime_millis_result1
            // 
            this.textBox_datetime_millis_result1.Location = new System.Drawing.Point(433, 42);
            this.textBox_datetime_millis_result1.Name = "textBox_datetime_millis_result1";
            this.textBox_datetime_millis_result1.ReadOnly = true;
            this.textBox_datetime_millis_result1.Size = new System.Drawing.Size(200, 26);
            this.textBox_datetime_millis_result1.TabIndex = 4;
            // 
            // textBox_datetime_millis_result2
            // 
            this.textBox_datetime_millis_result2.Location = new System.Drawing.Point(433, 102);
            this.textBox_datetime_millis_result2.Name = "textBox_datetime_millis_result2";
            this.textBox_datetime_millis_result2.ReadOnly = true;
            this.textBox_datetime_millis_result2.Size = new System.Drawing.Size(200, 26);
            this.textBox_datetime_millis_result2.TabIndex = 7;
            // 
            // button_datetime_mills2
            // 
            this.button_datetime_mills2.Location = new System.Drawing.Point(320, 102);
            this.button_datetime_mills2.Name = "button_datetime_mills2";
            this.button_datetime_mills2.Size = new System.Drawing.Size(75, 23);
            this.button_datetime_mills2.TabIndex = 6;
            this.button_datetime_mills2.Text = "转换>>";
            this.button_datetime_mills2.UseVisualStyleBackColor = true;
            this.button_datetime_mills2.Click += new System.EventHandler(this.button_datetime_mills2_Click);
            // 
            // textBox_datetime_millis_source
            // 
            this.textBox_datetime_millis_source.Location = new System.Drawing.Point(82, 99);
            this.textBox_datetime_millis_source.Name = "textBox_datetime_millis_source";
            this.textBox_datetime_millis_source.Size = new System.Drawing.Size(200, 26);
            this.textBox_datetime_millis_source.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_datetime_mills1);
            this.groupBox1.Controls.Add(this.dateTimePicker_datetime_mills_source);
            this.groupBox1.Controls.Add(this.textBox_datetime_millis_result1);
            this.groupBox1.Controls.Add(this.textBox_datetime_millis_source);
            this.groupBox1.Controls.Add(this.button_datetime_mills2);
            this.groupBox1.Controls.Add(this.textBox_datetime_millis_result2);
            this.groupBox1.Location = new System.Drawing.Point(15, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 156);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "时间转毫秒";
            // 
            // textBox_millis_datetime_result
            // 
            this.textBox_millis_datetime_result.Location = new System.Drawing.Point(433, 42);
            this.textBox_millis_datetime_result.Name = "textBox_millis_datetime_result";
            this.textBox_millis_datetime_result.ReadOnly = true;
            this.textBox_millis_datetime_result.Size = new System.Drawing.Size(200, 26);
            this.textBox_millis_datetime_result.TabIndex = 4;
            // 
            // button_mills_datetime
            // 
            this.button_mills_datetime.Location = new System.Drawing.Point(320, 42);
            this.button_mills_datetime.Name = "button_mills_datetime";
            this.button_mills_datetime.Size = new System.Drawing.Size(75, 23);
            this.button_mills_datetime.TabIndex = 3;
            this.button_mills_datetime.Text = "转换>>";
            this.button_mills_datetime.UseVisualStyleBackColor = true;
            this.button_mills_datetime.Click += new System.EventHandler(this.button_mills_datetime_Click);
            // 
            // textBox_mills_datetime_source
            // 
            this.textBox_mills_datetime_source.Location = new System.Drawing.Point(82, 42);
            this.textBox_mills_datetime_source.MaxLength = 13;
            this.textBox_mills_datetime_source.Name = "textBox_mills_datetime_source";
            this.textBox_mills_datetime_source.Size = new System.Drawing.Size(200, 26);
            this.textBox_mills_datetime_source.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_mills_datetime_source);
            this.groupBox2.Controls.Add(this.button_mills_datetime);
            this.groupBox2.Controls.Add(this.textBox_millis_datetime_result);
            this.groupBox2.Location = new System.Drawing.Point(15, 337);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(751, 102);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "毫秒转时间";
            // 
            // label_system_time
            // 
            this.label_system_time.AutoSize = true;
            this.label_system_time.Font = new System.Drawing.Font("宋体", 11F);
            this.label_system_time.ForeColor = System.Drawing.Color.Red;
            this.label_system_time.Location = new System.Drawing.Point(111, 9);
            this.label_system_time.Name = "label_system_time";
            this.label_system_time.Size = new System.Drawing.Size(15, 15);
            this.label_system_time.TabIndex = 13;
            this.label_system_time.Text = " ";
            this.label_system_time.Click += new System.EventHandler(this.label_system_time_Click);
            // 
            // label_s
            // 
            this.label_s.AutoSize = true;
            this.label_s.Font = new System.Drawing.Font("宋体", 11F);
            this.label_s.ForeColor = System.Drawing.Color.Red;
            this.label_s.Location = new System.Drawing.Point(91, 44);
            this.label_s.Name = "label_s";
            this.label_s.Size = new System.Drawing.Size(15, 15);
            this.label_s.TabIndex = 14;
            this.label_s.Text = " ";
            this.label_s.Click += new System.EventHandler(this.label_s_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(520, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "时间转毫秒时注意时间格式为：yyyy-MM-dd HH:mm:ss:fff  且fff可忽略";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton_unit_ms);
            this.groupBox3.Controls.Add(this.radioButton_unit_s);
            this.groupBox3.Location = new System.Drawing.Point(591, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(175, 62);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // radioButton_unit_s
            // 
            this.radioButton_unit_s.AutoSize = true;
            this.radioButton_unit_s.Font = new System.Drawing.Font("宋体", 11F);
            this.radioButton_unit_s.Location = new System.Drawing.Point(7, 25);
            this.radioButton_unit_s.Name = "radioButton_unit_s";
            this.radioButton_unit_s.Size = new System.Drawing.Size(64, 19);
            this.radioButton_unit_s.TabIndex = 0;
            this.radioButton_unit_s.Text = "秒(s)";
            this.radioButton_unit_s.UseVisualStyleBackColor = true;
            // 
            // radioButton_unit_ms
            // 
            this.radioButton_unit_ms.AutoSize = true;
            this.radioButton_unit_ms.Checked = true;
            this.radioButton_unit_ms.Font = new System.Drawing.Font("宋体", 11F);
            this.radioButton_unit_ms.Location = new System.Drawing.Point(71, 25);
            this.radioButton_unit_ms.Name = "radioButton_unit_ms";
            this.radioButton_unit_ms.Size = new System.Drawing.Size(87, 19);
            this.radioButton_unit_ms.TabIndex = 1;
            this.radioButton_unit_ms.TabStop = true;
            this.radioButton_unit_ms.Text = "毫秒(ms)";
            this.radioButton_unit_ms.UseVisualStyleBackColor = true;
            // 
            // label_millis
            // 
            this.label_millis.AutoSize = true;
            this.label_millis.Font = new System.Drawing.Font("宋体", 11F);
            this.label_millis.ForeColor = System.Drawing.Color.Red;
            this.label_millis.Location = new System.Drawing.Point(396, 44);
            this.label_millis.Name = "label_millis";
            this.label_millis.Size = new System.Drawing.Size(15, 15);
            this.label_millis.TabIndex = 18;
            this.label_millis.Text = " ";
            this.label_millis.Click += new System.EventHandler(this.label_millis_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 11F);
            this.label4.Location = new System.Drawing.Point(311, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "时间戳(ms)：";
            // 
            // MillisecondTransForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 526);
            this.Controls.Add(this.label_millis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_s);
            this.Controls.Add(this.label_system_time);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MillisecondTransForm";
            this.Text = "MillisecondTransForm";
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_datetime_mills_source;
        private System.Windows.Forms.Button button_datetime_mills1;
        private System.Windows.Forms.TextBox textBox_datetime_millis_result1;
        private System.Windows.Forms.TextBox textBox_datetime_millis_result2;
        private System.Windows.Forms.Button button_datetime_mills2;
        private System.Windows.Forms.TextBox textBox_datetime_millis_source;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_millis_datetime_result;
        private System.Windows.Forms.Button button_mills_datetime;
        private System.Windows.Forms.TextBox textBox_mills_datetime_source;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_system_time;
        private System.Windows.Forms.Label label_s;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton_unit_s;
        private System.Windows.Forms.RadioButton radioButton_unit_ms;
        private System.Windows.Forms.Label label_millis;
        private System.Windows.Forms.Label label4;
    }
}