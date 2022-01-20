
namespace niushuai233Kit
{
    partial class KitApplication
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage_other = new System.Windows.Forms.TabPage();
            this.tabPage_number_conversion = new System.Windows.Forms.TabPage();
            this.tabPage_encrypt = new System.Windows.Forms.TabPage();
            this.tabPage_code_trans = new System.Windows.Forms.TabPage();
            this.tabPage_string = new System.Windows.Forms.TabPage();
            this.tabControl_main = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.tabControl_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(968, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(54, 25);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // tabPage_other
            // 
            this.tabPage_other.Location = new System.Drawing.Point(4, 26);
            this.tabPage_other.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_other.Name = "tabPage_other";
            this.tabPage_other.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_other.Size = new System.Drawing.Size(1027, 517);
            this.tabPage_other.TabIndex = 4;
            this.tabPage_other.Text = "其他";
            this.tabPage_other.UseVisualStyleBackColor = true;
            // 
            // tabPage_number_conversion
            // 
            this.tabPage_number_conversion.Location = new System.Drawing.Point(4, 26);
            this.tabPage_number_conversion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_number_conversion.Name = "tabPage_number_conversion";
            this.tabPage_number_conversion.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_number_conversion.Size = new System.Drawing.Size(1027, 517);
            this.tabPage_number_conversion.TabIndex = 3;
            this.tabPage_number_conversion.Text = "进制转换";
            this.tabPage_number_conversion.UseVisualStyleBackColor = true;
            // 
            // tabPage_encrypt
            // 
            this.tabPage_encrypt.Location = new System.Drawing.Point(4, 26);
            this.tabPage_encrypt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_encrypt.Name = "tabPage_encrypt";
            this.tabPage_encrypt.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_encrypt.Size = new System.Drawing.Size(1027, 517);
            this.tabPage_encrypt.TabIndex = 2;
            this.tabPage_encrypt.Text = "加密解密";
            this.tabPage_encrypt.UseVisualStyleBackColor = true;
            // 
            // tabPage_code_trans
            // 
            this.tabPage_code_trans.Location = new System.Drawing.Point(4, 26);
            this.tabPage_code_trans.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_code_trans.Name = "tabPage_code_trans";
            this.tabPage_code_trans.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_code_trans.Size = new System.Drawing.Size(1027, 517);
            this.tabPage_code_trans.TabIndex = 1;
            this.tabPage_code_trans.Text = "编码转换";
            this.tabPage_code_trans.UseVisualStyleBackColor = true;
            // 
            // tabPage_string
            // 
            this.tabPage_string.Location = new System.Drawing.Point(4, 26);
            this.tabPage_string.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_string.Name = "tabPage_string";
            this.tabPage_string.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_string.Size = new System.Drawing.Size(925, 398);
            this.tabPage_string.TabIndex = 0;
            this.tabPage_string.Text = "字符串";
            this.tabPage_string.UseVisualStyleBackColor = true;
            // 
            // tabControl_main
            // 
            this.tabControl_main.Controls.Add(this.tabPage_string);
            this.tabControl_main.Controls.Add(this.tabPage_code_trans);
            this.tabControl_main.Controls.Add(this.tabPage_encrypt);
            this.tabControl_main.Controls.Add(this.tabPage_number_conversion);
            this.tabControl_main.Controls.Add(this.tabPage_other);
            this.tabControl_main.Location = new System.Drawing.Point(16, 37);
            this.tabControl_main.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl_main.Name = "tabControl_main";
            this.tabControl_main.SelectedIndex = 0;
            this.tabControl_main.Size = new System.Drawing.Size(933, 428);
            this.tabControl_main.TabIndex = 0;
            // 
            // KitApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 480);
            this.Controls.Add(this.tabControl_main);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "KitApplication";
            this.Text = "Kit@niushuai233";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl_main.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage_other;
        private System.Windows.Forms.TabPage tabPage_number_conversion;
        private System.Windows.Forms.TabPage tabPage_encrypt;
        private System.Windows.Forms.TabPage tabPage_code_trans;
        private System.Windows.Forms.TabPage tabPage_string;
        private System.Windows.Forms.TabControl tabControl_main;
    }
}

