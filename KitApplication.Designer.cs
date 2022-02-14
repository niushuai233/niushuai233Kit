
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitApplication));
            this.menuStrip_main = new System.Windows.Forms.MenuStrip();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.other_tabPage = new System.Windows.Forms.TabPage();
            this.other_groupBox_result = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.button_other_regex = new System.Windows.Forms.Button();
            this.button_other_translation = new System.Windows.Forms.Button();
            this.button_other_countdown = new System.Windows.Forms.Button();
            this.other_button_keycode = new System.Windows.Forms.Button();
            this.encrypt_tabPage = new System.Windows.Forms.TabPage();
            this.encrypt_groupBox_result = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.encrypt_button_sha = new System.Windows.Forms.Button();
            this.button_encrypt_aes = new System.Windows.Forms.Button();
            this.encrypt_button_md5 = new System.Windows.Forms.Button();
            this.codec_trans_tabPage = new System.Windows.Forms.TabPage();
            this.codec_groupBox_result = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.codec_button_escape = new System.Windows.Forms.Button();
            this.codec_button_base64 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.codec_button_urlCodec = new System.Windows.Forms.Button();
            this.string_tabPage = new System.Windows.Forms.TabPage();
            this.string_groupBox_result = new System.Windows.Forms.GroupBox();
            this.string_groupbox_function = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.string_button_textNumber = new System.Windows.Forms.Button();
            this.string_button_wordConvert = new System.Windows.Forms.Button();
            this.button_string_uuid = new System.Windows.Forms.Button();
            this.string_button_wordCount = new System.Windows.Forms.Button();
            this.tabControl_main = new System.Windows.Forms.TabControl();
            this.datetime_tabPage = new System.Windows.Forms.TabPage();
            this.groupBox_time_result = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button_time_millssecond = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip_notifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NotifyIconShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NotifyIconExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip_main.SuspendLayout();
            this.other_tabPage.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.encrypt_tabPage.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.codec_trans_tabPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.string_tabPage.SuspendLayout();
            this.string_groupbox_function.SuspendLayout();
            this.tabControl_main.SuspendLayout();
            this.datetime_tabPage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip_notifyIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_main
            // 
            this.menuStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.menuStrip_main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_main.Name = "menuStrip_main";
            this.menuStrip_main.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip_main.Size = new System.Drawing.Size(1121, 31);
            this.menuStrip_main.TabIndex = 1;
            this.menuStrip_main.Text = "主菜单";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(54, 25);
            this.ExitToolStripMenuItem.Text = "退出";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(54, 25);
            this.AboutToolStripMenuItem.Text = "关于";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // other_tabPage
            // 
            this.other_tabPage.Controls.Add(this.other_groupBox_result);
            this.other_tabPage.Controls.Add(this.groupBox8);
            this.other_tabPage.Location = new System.Drawing.Point(4, 26);
            this.other_tabPage.Margin = new System.Windows.Forms.Padding(4);
            this.other_tabPage.Name = "other_tabPage";
            this.other_tabPage.Padding = new System.Windows.Forms.Padding(4);
            this.other_tabPage.Size = new System.Drawing.Size(1084, 580);
            this.other_tabPage.TabIndex = 4;
            this.other_tabPage.Text = "其他";
            this.other_tabPage.UseVisualStyleBackColor = true;
            // 
            // other_groupBox_result
            // 
            this.other_groupBox_result.Location = new System.Drawing.Point(286, 8);
            this.other_groupBox_result.Name = "other_groupBox_result";
            this.other_groupBox_result.Size = new System.Drawing.Size(791, 565);
            this.other_groupBox_result.TabIndex = 3;
            this.other_groupBox_result.TabStop = false;
            this.other_groupBox_result.Text = "显示区";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.button4);
            this.groupBox8.Controls.Add(this.button_other_regex);
            this.groupBox8.Controls.Add(this.button_other_translation);
            this.groupBox8.Controls.Add(this.button_other_countdown);
            this.groupBox8.Controls.Add(this.other_button_keycode);
            this.groupBox8.Location = new System.Drawing.Point(8, 8);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(270, 565);
            this.groupBox8.TabIndex = 2;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "功能区";
            // 
            // button_other_regex
            // 
            this.button_other_regex.Location = new System.Drawing.Point(137, 66);
            this.button_other_regex.Name = "button_other_regex";
            this.button_other_regex.Size = new System.Drawing.Size(125, 30);
            this.button_other_regex.TabIndex = 3;
            this.button_other_regex.Text = "正则表达式";
            this.button_other_regex.UseVisualStyleBackColor = true;
            this.button_other_regex.Click += new System.EventHandler(this.button_other_regex_Click);
            // 
            // button_other_translation
            // 
            this.button_other_translation.Location = new System.Drawing.Point(6, 66);
            this.button_other_translation.Name = "button_other_translation";
            this.button_other_translation.Size = new System.Drawing.Size(125, 30);
            this.button_other_translation.TabIndex = 2;
            this.button_other_translation.Text = "翻译";
            this.button_other_translation.UseVisualStyleBackColor = true;
            this.button_other_translation.Click += new System.EventHandler(this.button_other_translation_Click);
            // 
            // button_other_countdown
            // 
            this.button_other_countdown.Location = new System.Drawing.Point(137, 30);
            this.button_other_countdown.Name = "button_other_countdown";
            this.button_other_countdown.Size = new System.Drawing.Size(125, 30);
            this.button_other_countdown.TabIndex = 1;
            this.button_other_countdown.Text = "倒计时";
            this.button_other_countdown.UseVisualStyleBackColor = true;
            this.button_other_countdown.Click += new System.EventHandler(this.button_other_countdown_Click);
            // 
            // other_button_keycode
            // 
            this.other_button_keycode.Location = new System.Drawing.Point(6, 30);
            this.other_button_keycode.Name = "other_button_keycode";
            this.other_button_keycode.Size = new System.Drawing.Size(125, 30);
            this.other_button_keycode.TabIndex = 0;
            this.other_button_keycode.Text = "Ascii码查询";
            this.other_button_keycode.UseVisualStyleBackColor = true;
            this.other_button_keycode.Click += new System.EventHandler(this.other_button_keycode_Click);
            // 
            // encrypt_tabPage
            // 
            this.encrypt_tabPage.Controls.Add(this.encrypt_groupBox_result);
            this.encrypt_tabPage.Controls.Add(this.groupBox4);
            this.encrypt_tabPage.Location = new System.Drawing.Point(4, 26);
            this.encrypt_tabPage.Margin = new System.Windows.Forms.Padding(4);
            this.encrypt_tabPage.Name = "encrypt_tabPage";
            this.encrypt_tabPage.Padding = new System.Windows.Forms.Padding(4);
            this.encrypt_tabPage.Size = new System.Drawing.Size(1084, 580);
            this.encrypt_tabPage.TabIndex = 2;
            this.encrypt_tabPage.Text = "加密解密";
            this.encrypt_tabPage.UseVisualStyleBackColor = true;
            // 
            // encrypt_groupBox_result
            // 
            this.encrypt_groupBox_result.Location = new System.Drawing.Point(286, 8);
            this.encrypt_groupBox_result.Name = "encrypt_groupBox_result";
            this.encrypt_groupBox_result.Size = new System.Drawing.Size(791, 565);
            this.encrypt_groupBox_result.TabIndex = 3;
            this.encrypt_groupBox_result.TabStop = false;
            this.encrypt_groupBox_result.Text = "显示区";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.encrypt_button_sha);
            this.groupBox4.Controls.Add(this.button_encrypt_aes);
            this.groupBox4.Controls.Add(this.encrypt_button_md5);
            this.groupBox4.Location = new System.Drawing.Point(8, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(270, 565);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "功能区";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(137, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "待续...";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // encrypt_button_sha
            // 
            this.encrypt_button_sha.Location = new System.Drawing.Point(138, 30);
            this.encrypt_button_sha.Name = "encrypt_button_sha";
            this.encrypt_button_sha.Size = new System.Drawing.Size(125, 30);
            this.encrypt_button_sha.TabIndex = 2;
            this.encrypt_button_sha.Text = "SHA";
            this.encrypt_button_sha.UseVisualStyleBackColor = true;
            this.encrypt_button_sha.Click += new System.EventHandler(this.encrypt_button_sha_Click);
            // 
            // button_encrypt_aes
            // 
            this.button_encrypt_aes.Location = new System.Drawing.Point(6, 66);
            this.button_encrypt_aes.Name = "button_encrypt_aes";
            this.button_encrypt_aes.Size = new System.Drawing.Size(125, 30);
            this.button_encrypt_aes.TabIndex = 1;
            this.button_encrypt_aes.Text = "AES";
            this.button_encrypt_aes.UseVisualStyleBackColor = true;
            this.button_encrypt_aes.Click += new System.EventHandler(this.button_encrypt_aes_Click);
            // 
            // encrypt_button_md5
            // 
            this.encrypt_button_md5.Location = new System.Drawing.Point(6, 30);
            this.encrypt_button_md5.Name = "encrypt_button_md5";
            this.encrypt_button_md5.Size = new System.Drawing.Size(125, 30);
            this.encrypt_button_md5.TabIndex = 0;
            this.encrypt_button_md5.Text = "MD5";
            this.encrypt_button_md5.UseVisualStyleBackColor = true;
            this.encrypt_button_md5.Click += new System.EventHandler(this.encrypt_button_md5_Click);
            // 
            // codec_trans_tabPage
            // 
            this.codec_trans_tabPage.Controls.Add(this.codec_groupBox_result);
            this.codec_trans_tabPage.Controls.Add(this.groupBox2);
            this.codec_trans_tabPage.Location = new System.Drawing.Point(4, 26);
            this.codec_trans_tabPage.Margin = new System.Windows.Forms.Padding(4);
            this.codec_trans_tabPage.Name = "codec_trans_tabPage";
            this.codec_trans_tabPage.Padding = new System.Windows.Forms.Padding(4);
            this.codec_trans_tabPage.Size = new System.Drawing.Size(1084, 580);
            this.codec_trans_tabPage.TabIndex = 1;
            this.codec_trans_tabPage.Text = "编码转换";
            this.codec_trans_tabPage.UseVisualStyleBackColor = true;
            // 
            // codec_groupBox_result
            // 
            this.codec_groupBox_result.Location = new System.Drawing.Point(286, 8);
            this.codec_groupBox_result.Name = "codec_groupBox_result";
            this.codec_groupBox_result.Size = new System.Drawing.Size(791, 565);
            this.codec_groupBox_result.TabIndex = 3;
            this.codec_groupBox_result.TabStop = false;
            this.codec_groupBox_result.Text = "显示区";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.codec_button_escape);
            this.groupBox2.Controls.Add(this.codec_button_base64);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.codec_button_urlCodec);
            this.groupBox2.Location = new System.Drawing.Point(8, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 565);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "功能区";
            // 
            // codec_button_escape
            // 
            this.codec_button_escape.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.codec_button_escape.Location = new System.Drawing.Point(6, 66);
            this.codec_button_escape.Name = "codec_button_escape";
            this.codec_button_escape.Size = new System.Drawing.Size(125, 30);
            this.codec_button_escape.TabIndex = 3;
            this.codec_button_escape.Text = "Escape/Unicode";
            this.codec_button_escape.UseVisualStyleBackColor = true;
            this.codec_button_escape.Click += new System.EventHandler(this.encrypted_button_escape_Click);
            // 
            // codec_button_base64
            // 
            this.codec_button_base64.Location = new System.Drawing.Point(138, 30);
            this.codec_button_base64.Name = "codec_button_base64";
            this.codec_button_base64.Size = new System.Drawing.Size(125, 30);
            this.codec_button_base64.TabIndex = 2;
            this.codec_button_base64.Text = "Base64";
            this.codec_button_base64.UseVisualStyleBackColor = true;
            this.codec_button_base64.Click += new System.EventHandler(this.encrypt_button_base64_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "待续...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // codec_button_urlCodec
            // 
            this.codec_button_urlCodec.Location = new System.Drawing.Point(6, 30);
            this.codec_button_urlCodec.Name = "codec_button_urlCodec";
            this.codec_button_urlCodec.Size = new System.Drawing.Size(125, 30);
            this.codec_button_urlCodec.TabIndex = 0;
            this.codec_button_urlCodec.Text = "Url";
            this.codec_button_urlCodec.UseVisualStyleBackColor = true;
            this.codec_button_urlCodec.Click += new System.EventHandler(this.encrypt_button_urlCodec_Click);
            // 
            // string_tabPage
            // 
            this.string_tabPage.Controls.Add(this.string_groupBox_result);
            this.string_tabPage.Controls.Add(this.string_groupbox_function);
            this.string_tabPage.Location = new System.Drawing.Point(4, 26);
            this.string_tabPage.Margin = new System.Windows.Forms.Padding(4);
            this.string_tabPage.Name = "string_tabPage";
            this.string_tabPage.Padding = new System.Windows.Forms.Padding(4);
            this.string_tabPage.Size = new System.Drawing.Size(1084, 580);
            this.string_tabPage.TabIndex = 0;
            this.string_tabPage.Text = " 文本 ";
            this.string_tabPage.UseVisualStyleBackColor = true;
            // 
            // string_groupBox_result
            // 
            this.string_groupBox_result.Location = new System.Drawing.Point(286, 8);
            this.string_groupBox_result.Name = "string_groupBox_result";
            this.string_groupBox_result.Size = new System.Drawing.Size(791, 565);
            this.string_groupBox_result.TabIndex = 1;
            this.string_groupBox_result.TabStop = false;
            this.string_groupBox_result.Text = "显示区";
            // 
            // string_groupbox_function
            // 
            this.string_groupbox_function.Controls.Add(this.button5);
            this.string_groupbox_function.Controls.Add(this.string_button_textNumber);
            this.string_groupbox_function.Controls.Add(this.string_button_wordConvert);
            this.string_groupbox_function.Controls.Add(this.button_string_uuid);
            this.string_groupbox_function.Controls.Add(this.string_button_wordCount);
            this.string_groupbox_function.Location = new System.Drawing.Point(8, 8);
            this.string_groupbox_function.Name = "string_groupbox_function";
            this.string_groupbox_function.Size = new System.Drawing.Size(270, 565);
            this.string_groupbox_function.TabIndex = 0;
            this.string_groupbox_function.TabStop = false;
            this.string_groupbox_function.Text = "功能区";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 102);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 30);
            this.button5.TabIndex = 4;
            this.button5.Text = "待续...";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // string_button_textNumber
            // 
            this.string_button_textNumber.Location = new System.Drawing.Point(6, 66);
            this.string_button_textNumber.Name = "string_button_textNumber";
            this.string_button_textNumber.Size = new System.Drawing.Size(125, 30);
            this.string_button_textNumber.TabIndex = 3;
            this.string_button_textNumber.Text = "增加序号";
            this.string_button_textNumber.UseVisualStyleBackColor = true;
            this.string_button_textNumber.Click += new System.EventHandler(this.string_button_textNumber_Click);
            // 
            // string_button_wordConvert
            // 
            this.string_button_wordConvert.Location = new System.Drawing.Point(138, 30);
            this.string_button_wordConvert.Name = "string_button_wordConvert";
            this.string_button_wordConvert.Size = new System.Drawing.Size(125, 30);
            this.string_button_wordConvert.TabIndex = 2;
            this.string_button_wordConvert.Text = "大小写转换";
            this.string_button_wordConvert.UseVisualStyleBackColor = true;
            this.string_button_wordConvert.Click += new System.EventHandler(this.string_button_wordConvert_Click);
            // 
            // button_string_uuid
            // 
            this.button_string_uuid.Location = new System.Drawing.Point(138, 66);
            this.button_string_uuid.Name = "button_string_uuid";
            this.button_string_uuid.Size = new System.Drawing.Size(125, 30);
            this.button_string_uuid.TabIndex = 1;
            this.button_string_uuid.Text = "UUID/GUID";
            this.button_string_uuid.UseVisualStyleBackColor = true;
            this.button_string_uuid.Click += new System.EventHandler(this.button_string_uuid_Click);
            // 
            // string_button_wordCount
            // 
            this.string_button_wordCount.Location = new System.Drawing.Point(6, 30);
            this.string_button_wordCount.Name = "string_button_wordCount";
            this.string_button_wordCount.Size = new System.Drawing.Size(125, 30);
            this.string_button_wordCount.TabIndex = 0;
            this.string_button_wordCount.Text = "字数统计";
            this.string_button_wordCount.UseVisualStyleBackColor = true;
            this.string_button_wordCount.Click += new System.EventHandler(this.string_button_wordCount_Click);
            // 
            // tabControl_main
            // 
            this.tabControl_main.Controls.Add(this.string_tabPage);
            this.tabControl_main.Controls.Add(this.codec_trans_tabPage);
            this.tabControl_main.Controls.Add(this.encrypt_tabPage);
            this.tabControl_main.Controls.Add(this.datetime_tabPage);
            this.tabControl_main.Controls.Add(this.other_tabPage);
            this.tabControl_main.Location = new System.Drawing.Point(16, 37);
            this.tabControl_main.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl_main.Name = "tabControl_main";
            this.tabControl_main.SelectedIndex = 0;
            this.tabControl_main.Size = new System.Drawing.Size(1092, 610);
            this.tabControl_main.TabIndex = 0;
            // 
            // datetime_tabPage
            // 
            this.datetime_tabPage.Controls.Add(this.groupBox_time_result);
            this.datetime_tabPage.Controls.Add(this.groupBox3);
            this.datetime_tabPage.Location = new System.Drawing.Point(4, 26);
            this.datetime_tabPage.Name = "datetime_tabPage";
            this.datetime_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.datetime_tabPage.Size = new System.Drawing.Size(1084, 580);
            this.datetime_tabPage.TabIndex = 5;
            this.datetime_tabPage.Text = "时间相关";
            this.datetime_tabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox_time_result
            // 
            this.groupBox_time_result.Location = new System.Drawing.Point(286, 8);
            this.groupBox_time_result.Name = "groupBox_time_result";
            this.groupBox_time_result.Size = new System.Drawing.Size(791, 565);
            this.groupBox_time_result.TabIndex = 5;
            this.groupBox_time_result.TabStop = false;
            this.groupBox_time_result.Text = "显示区";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button_time_millssecond);
            this.groupBox3.Location = new System.Drawing.Point(8, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(270, 565);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "功能区";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(139, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "待续...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button_time_millssecond
            // 
            this.button_time_millssecond.Location = new System.Drawing.Point(6, 30);
            this.button_time_millssecond.Name = "button_time_millssecond";
            this.button_time_millssecond.Size = new System.Drawing.Size(125, 30);
            this.button_time_millssecond.TabIndex = 0;
            this.button_time_millssecond.Text = "时间毫秒互转";
            this.button_time_millssecond.UseVisualStyleBackColor = true;
            this.button_time_millssecond.Click += new System.EventHandler(this.button_time_millssecond_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipTitle = "niushuai233Kit";
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip_notifyIcon;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "niushuai233Kit";
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // contextMenuStrip_notifyIcon
            // 
            this.contextMenuStrip_notifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NotifyIconShowToolStripMenuItem,
            this.NotifyIconExitToolStripMenuItem});
            this.contextMenuStrip_notifyIcon.Name = "contextMenuStrip_notifyIcon";
            this.contextMenuStrip_notifyIcon.Size = new System.Drawing.Size(101, 48);
            // 
            // NotifyIconShowToolStripMenuItem
            // 
            this.NotifyIconShowToolStripMenuItem.Name = "NotifyIconShowToolStripMenuItem";
            this.NotifyIconShowToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.NotifyIconShowToolStripMenuItem.Text = "显示";
            this.NotifyIconShowToolStripMenuItem.Click += new System.EventHandler(this.NotifyIconShowToolStripMenuItem_Click);
            // 
            // NotifyIconExitToolStripMenuItem
            // 
            this.NotifyIconExitToolStripMenuItem.Name = "NotifyIconExitToolStripMenuItem";
            this.NotifyIconExitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.NotifyIconExitToolStripMenuItem.Text = "退出";
            this.NotifyIconExitToolStripMenuItem.Click += new System.EventHandler(this.NotifyIconExitToolStripMenuItem_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 102);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 30);
            this.button4.TabIndex = 4;
            this.button4.Text = "待续...";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // KitApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 660);
            this.Controls.Add(this.tabControl_main);
            this.Controls.Add(this.menuStrip_main);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_main;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "KitApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kit@niushuai233";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KitApplication_FormClosing);
            this.menuStrip_main.ResumeLayout(false);
            this.menuStrip_main.PerformLayout();
            this.other_tabPage.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.encrypt_tabPage.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.codec_trans_tabPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.string_tabPage.ResumeLayout(false);
            this.string_groupbox_function.ResumeLayout(false);
            this.tabControl_main.ResumeLayout(false);
            this.datetime_tabPage.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.contextMenuStrip_notifyIcon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip_main;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.TabPage other_tabPage;
        private System.Windows.Forms.TabPage encrypt_tabPage;
        private System.Windows.Forms.TabPage codec_trans_tabPage;
        private System.Windows.Forms.TabPage string_tabPage;
        private System.Windows.Forms.TabControl tabControl_main;
        private System.Windows.Forms.GroupBox string_groupbox_function;
        private System.Windows.Forms.GroupBox string_groupBox_result;
        private System.Windows.Forms.Button button_string_uuid;
        private System.Windows.Forms.Button string_button_wordCount;
        private System.Windows.Forms.GroupBox codec_groupBox_result;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button codec_button_urlCodec;
        private System.Windows.Forms.GroupBox encrypt_groupBox_result;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_encrypt_aes;
        private System.Windows.Forms.Button encrypt_button_md5;
        private System.Windows.Forms.GroupBox other_groupBox_result;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button button_other_countdown;
        private System.Windows.Forms.Button other_button_keycode;
        private System.Windows.Forms.TabPage datetime_tabPage;
        private System.Windows.Forms.Button codec_button_base64;
        private System.Windows.Forms.Button codec_button_escape;
        private System.Windows.Forms.Button string_button_wordConvert;
        private System.Windows.Forms.Button string_button_textNumber;
        private System.Windows.Forms.Button encrypt_button_sha;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_other_translation;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox_time_result;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_time_millssecond;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem NotifyIconShowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NotifyIconExitToolStripMenuItem;
        private System.Windows.Forms.Button button_other_regex;
        private System.Windows.Forms.Button button4;
    }
}

