namespace Wen.THproject
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.naviButton3 = new Wen.ControlLib.NaviButton();
            this.naviButton6 = new Wen.ControlLib.NaviButton();
            this.naviButton5 = new Wen.ControlLib.NaviButton();
            this.naviButton4 = new Wen.ControlLib.NaviButton();
            this.naviButton2 = new Wen.ControlLib.NaviButton();
            this.naviButton1 = new Wen.ControlLib.NaviButton();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_TitleName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MiddlePanel = new System.Windows.Forms.Panel();
            this.led_CommState = new SeeSharpTools.JY.GUI.LED();
            this.lbl_ConnectInfo = new System.Windows.Forms.Label();
            this.AlarmPanel = new System.Windows.Forms.Panel();
            this.scrollingAlarm = new SeeSharpTools.JY.GUI.ScrollingText();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Left = new System.Windows.Forms.Button();
            this.lbl_CurrentTime = new System.Windows.Forms.Label();
            this.lbl_User = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.corePanel = new Wen.ControlLib.PanelEx();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MiddlePanel.SuspendLayout();
            this.AlarmPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.corePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Transparent;
            this.TopPanel.CausesValidation = false;
            this.TopPanel.Controls.Add(this.naviButton3);
            this.TopPanel.Controls.Add(this.naviButton6);
            this.TopPanel.Controls.Add(this.naviButton5);
            this.TopPanel.Controls.Add(this.naviButton4);
            this.TopPanel.Controls.Add(this.naviButton2);
            this.TopPanel.Controls.Add(this.naviButton1);
            this.TopPanel.Controls.Add(this.btn_Exit);
            this.TopPanel.Controls.Add(this.lbl_TitleName);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.pictureBox1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1440, 133);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            // 
            // naviButton3
            // 
            this.naviButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("naviButton3.BackgroundImage")));
            this.naviButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.naviButton3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.naviButton3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.naviButton3.IsLeft = true;
            this.naviButton3.IsSelected = false;
            this.naviButton3.Location = new System.Drawing.Point(455, 85);
            this.naviButton3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.naviButton3.Name = "naviButton3";
            this.naviButton3.Size = new System.Drawing.Size(193, 43);
            this.naviButton3.TabIndex = 10;
            this.naviButton3.TitleName = "配方管理";
            this.naviButton3.Click += new System.EventHandler(this.CommonNaviButton_Click);
            // 
            // naviButton6
            // 
            this.naviButton6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("naviButton6.BackgroundImage")));
            this.naviButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.naviButton6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.naviButton6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.naviButton6.IsLeft = false;
            this.naviButton6.IsSelected = false;
            this.naviButton6.Location = new System.Drawing.Point(1241, 82);
            this.naviButton6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.naviButton6.Name = "naviButton6";
            this.naviButton6.Size = new System.Drawing.Size(193, 43);
            this.naviButton6.TabIndex = 9;
            this.naviButton6.TitleName = "用户管理";
            this.naviButton6.Click += new System.EventHandler(this.CommonNaviButton_Click);
            // 
            // naviButton5
            // 
            this.naviButton5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("naviButton5.BackgroundImage")));
            this.naviButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.naviButton5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.naviButton5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.naviButton5.IsLeft = false;
            this.naviButton5.IsSelected = false;
            this.naviButton5.Location = new System.Drawing.Point(1017, 82);
            this.naviButton5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.naviButton5.Name = "naviButton5";
            this.naviButton5.Size = new System.Drawing.Size(193, 43);
            this.naviButton5.TabIndex = 8;
            this.naviButton5.TitleName = "历史趋势";
            this.naviButton5.Click += new System.EventHandler(this.CommonNaviButton_Click);
            // 
            // naviButton4
            // 
            this.naviButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("naviButton4.BackgroundImage")));
            this.naviButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.naviButton4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.naviButton4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.naviButton4.IsLeft = false;
            this.naviButton4.IsSelected = false;
            this.naviButton4.Location = new System.Drawing.Point(793, 82);
            this.naviButton4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.naviButton4.Name = "naviButton4";
            this.naviButton4.Size = new System.Drawing.Size(193, 43);
            this.naviButton4.TabIndex = 7;
            this.naviButton4.TitleName = "报警追溯";
            this.naviButton4.Click += new System.EventHandler(this.CommonNaviButton_Click);
            // 
            // naviButton2
            // 
            this.naviButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("naviButton2.BackgroundImage")));
            this.naviButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.naviButton2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.naviButton2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.naviButton2.IsLeft = true;
            this.naviButton2.IsSelected = false;
            this.naviButton2.Location = new System.Drawing.Point(230, 85);
            this.naviButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.naviButton2.Name = "naviButton2";
            this.naviButton2.Size = new System.Drawing.Size(193, 43);
            this.naviButton2.TabIndex = 5;
            this.naviButton2.TitleName = "参数设置";
            this.naviButton2.Click += new System.EventHandler(this.CommonNaviButton_Click);
            // 
            // naviButton1
            // 
            this.naviButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("naviButton1.BackgroundImage")));
            this.naviButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.naviButton1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.naviButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.naviButton1.IsLeft = true;
            this.naviButton1.IsSelected = false;
            this.naviButton1.Location = new System.Drawing.Point(12, 85);
            this.naviButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.naviButton1.Name = "naviButton1";
            this.naviButton1.Size = new System.Drawing.Size(193, 43);
            this.naviButton1.TabIndex = 4;
            this.naviButton1.TitleName = "集中控制";
            this.naviButton1.Click += new System.EventHandler(this.CommonNaviButton_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.Location = new System.Drawing.Point(1337, 3);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(97, 42);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_TitleName
            // 
            this.lbl_TitleName.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_TitleName.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_TitleName.Location = new System.Drawing.Point(515, 20);
            this.lbl_TitleName.Name = "lbl_TitleName";
            this.lbl_TitleName.Size = new System.Drawing.Size(410, 53);
            this.lbl_TitleName.TabIndex = 2;
            this.lbl_TitleName.Text = "多温湿度采集监控系统";
            this.lbl_TitleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(96, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "THGER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 67);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MiddlePanel
            // 
            this.MiddlePanel.BackColor = System.Drawing.Color.Transparent;
            this.MiddlePanel.Controls.Add(this.led_CommState);
            this.MiddlePanel.Controls.Add(this.lbl_ConnectInfo);
            this.MiddlePanel.Controls.Add(this.AlarmPanel);
            this.MiddlePanel.Controls.Add(this.lbl_Title);
            this.MiddlePanel.Controls.Add(this.button1);
            this.MiddlePanel.Controls.Add(this.btn_Left);
            this.MiddlePanel.Controls.Add(this.lbl_CurrentTime);
            this.MiddlePanel.Controls.Add(this.lbl_User);
            this.MiddlePanel.Controls.Add(this.label3);
            this.MiddlePanel.Controls.Add(this.pictureBox2);
            this.MiddlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MiddlePanel.Location = new System.Drawing.Point(0, 133);
            this.MiddlePanel.Name = "MiddlePanel";
            this.MiddlePanel.Size = new System.Drawing.Size(1440, 67);
            this.MiddlePanel.TabIndex = 1;
            this.MiddlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.MiddlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            // 
            // led_CommState
            // 
            this.led_CommState.BlinkColor = System.Drawing.Color.Lime;
            this.led_CommState.BlinkInterval = 1000;
            this.led_CommState.BlinkOn = false;
            this.led_CommState.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.led_CommState.Interacton = SeeSharpTools.JY.GUI.LED.InteractionStyle.Indicator;
            this.led_CommState.Location = new System.Drawing.Point(1357, 8);
            this.led_CommState.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.led_CommState.Name = "led_CommState";
            this.led_CommState.OffColor = System.Drawing.Color.Red;
            this.led_CommState.OnColor = System.Drawing.Color.Green;
            this.led_CommState.Size = new System.Drawing.Size(46, 45);
            this.led_CommState.Style = SeeSharpTools.JY.GUI.LED.LedStyle.Circular;
            this.led_CommState.TabIndex = 12;
            this.led_CommState.Value = false;
            // 
            // lbl_ConnectInfo
            // 
            this.lbl_ConnectInfo.AutoSize = true;
            this.lbl_ConnectInfo.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.lbl_ConnectInfo.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_ConnectInfo.Location = new System.Drawing.Point(1276, 20);
            this.lbl_ConnectInfo.Name = "lbl_ConnectInfo";
            this.lbl_ConnectInfo.Size = new System.Drawing.Size(74, 22);
            this.lbl_ConnectInfo.TabIndex = 11;
            this.lbl_ConnectInfo.Text = "通信状态";
            // 
            // AlarmPanel
            // 
            this.AlarmPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AlarmPanel.BackgroundImage")));
            this.AlarmPanel.Controls.Add(this.scrollingAlarm);
            this.AlarmPanel.Location = new System.Drawing.Point(937, 12);
            this.AlarmPanel.Name = "AlarmPanel";
            this.AlarmPanel.Size = new System.Drawing.Size(285, 38);
            this.AlarmPanel.TabIndex = 10;
            // 
            // scrollingAlarm
            // 
            this.scrollingAlarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.scrollingAlarm.BorderColor = System.Drawing.Color.Transparent;
            this.scrollingAlarm.BorderVisible = true;
            this.scrollingAlarm.Cursor = System.Windows.Forms.Cursors.Default;
            this.scrollingAlarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollingAlarm.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.scrollingAlarm.ForeColor = System.Drawing.Color.White;
            this.scrollingAlarm.Location = new System.Drawing.Point(0, 0);
            this.scrollingAlarm.Name = "scrollingAlarm";
            this.scrollingAlarm.Padding = new System.Windows.Forms.Padding(3);
            this.scrollingAlarm.ScrollDirection = SeeSharpTools.JY.GUI.ScrollingText.TextDirection.RightToLeft;
            this.scrollingAlarm.ScrollSpeed = 25;
            this.scrollingAlarm.Size = new System.Drawing.Size(285, 38);
            this.scrollingAlarm.TabIndex = 0;
            this.scrollingAlarm.Text = "当前系统无报警";
            this.scrollingAlarm.VerticleAligment = SeeSharpTools.JY.GUI.ScrollingText.TextVerticalAlignment.Center;
            this.scrollingAlarm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.scrollingAlarm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            // 
            // lbl_Title
            // 
            this.lbl_Title.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_Title.Image = ((System.Drawing.Image)(resources.GetObject("lbl_Title.Image")));
            this.lbl_Title.Location = new System.Drawing.Point(631, 1);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(184, 49);
            this.lbl_Title.TabIndex = 9;
            this.lbl_Title.Text = "集中监控";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::Wen.THproject.Properties.Resources.Regith;
            this.button1.Location = new System.Drawing.Point(832, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 43);
            this.button1.TabIndex = 8;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Left
            // 
            this.btn_Left.FlatAppearance.BorderSize = 0;
            this.btn_Left.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Left.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Left.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Left.Image = ((System.Drawing.Image)(resources.GetObject("btn_Left.Image")));
            this.btn_Left.Location = new System.Drawing.Point(558, 8);
            this.btn_Left.Name = "btn_Left";
            this.btn_Left.Size = new System.Drawing.Size(57, 43);
            this.btn_Left.TabIndex = 4;
            this.btn_Left.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_Left.UseVisualStyleBackColor = true;
            this.btn_Left.Click += new System.EventHandler(this.btn_Left_Click);
            // 
            // lbl_CurrentTime
            // 
            this.lbl_CurrentTime.AutoSize = true;
            this.lbl_CurrentTime.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.lbl_CurrentTime.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_CurrentTime.Location = new System.Drawing.Point(264, 16);
            this.lbl_CurrentTime.Name = "lbl_CurrentTime";
            this.lbl_CurrentTime.Size = new System.Drawing.Size(288, 22);
            this.lbl_CurrentTime.TabIndex = 7;
            this.lbl_CurrentTime.Text = "2023年10月25日10：25：00  星期一";
            // 
            // lbl_User
            // 
            this.lbl_User.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.lbl_User.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_User.Location = new System.Drawing.Point(38, 12);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(66, 30);
            this.lbl_User.TabIndex = 6;
            this.lbl_User.Text = "管理员";
            this.lbl_User.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(117, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "登入！现在时间是：";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // corePanel
            // 
            this.corePanel.BackColor = System.Drawing.Color.Transparent;
            this.corePanel.BordColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.corePanel.BordWidth = 5;
            this.corePanel.BottomGap = 10;
            this.corePanel.Controls.Add(this.MainPanel);
            this.corePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.corePanel.LeftGap = 10;
            this.corePanel.Location = new System.Drawing.Point(0, 200);
            this.corePanel.Name = "corePanel";
            this.corePanel.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.corePanel.RightGap = 10;
            this.corePanel.Size = new System.Drawing.Size(1440, 760);
            this.corePanel.TabIndex = 2;
            this.corePanel.TopGap = 10;
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(10, 20);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1420, 720);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1440, 960);
            this.Controls.Add(this.corePanel);
            this.Controls.Add(this.MiddlePanel);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MiddlePanel.ResumeLayout(false);
            this.MiddlePanel.PerformLayout();
            this.AlarmPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.corePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel MiddlePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_TitleName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_CurrentTime;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Button btn_Left;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel AlarmPanel;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_ConnectInfo;
        private ControlLib.NaviButton naviButton1;
        private ControlLib.NaviButton naviButton2;
        private ControlLib.NaviButton naviButton6;
        private ControlLib.NaviButton naviButton5;
        private ControlLib.NaviButton naviButton4;
        private ControlLib.PanelEx corePanel;
        private System.Windows.Forms.Panel MainPanel;
        private SeeSharpTools.JY.GUI.ScrollingText scrollingAlarm;
        private SeeSharpTools.JY.GUI.LED led_CommState;
        private ControlLib.NaviButton naviButton3;
    }
}

