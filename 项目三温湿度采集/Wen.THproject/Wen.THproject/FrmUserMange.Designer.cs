namespace Wen.THproject
{
    partial class FrmUserMange
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserMange));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_AddUser = new Wen.ControlLib.PanelEnhanced();
            this.dgv_UserManger = new System.Windows.Forms.DataGridView();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_DeleteUser = new System.Windows.Forms.Button();
            this.btn_UpdateUser = new System.Windows.Forms.Button();
            this.btn_AddSysAdmin = new System.Windows.Forms.Button();
            this.btn_SelectAll = new System.Windows.Forms.Button();
            this.chk_UserMange = new Wen.ControlLib.CheckBoxEX();
            this.chk_HistoryTrend = new Wen.ControlLib.CheckBoxEX();
            this.chk_HistoryLog = new Wen.ControlLib.CheckBoxEX();
            this.chk_Recipe = new Wen.ControlLib.CheckBoxEX();
            this.chk_ParamSet = new Wen.ControlLib.CheckBoxEX();
            this.txt_LoginPwd2 = new System.Windows.Forms.TextBox();
            this.txt_LoginPwd = new System.Windows.Forms.TextBox();
            this.txt_LoginName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.titleControl3 = new Wen.ControlLib.TitleControl();
            this.titleControl2 = new Wen.ControlLib.TitleControl();
            this.titleControl1 = new Wen.ControlLib.TitleControl();
            this.LoginID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginPwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParamSet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recipe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HisToryLog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HistoryTrend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserMange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_AddUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserManger)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.BackgroundImage = global::Wen.THproject.Properties.Resources.BackGround;
            this.btn_AddUser.Controls.Add(this.dgv_UserManger);
            this.btn_AddUser.Controls.Add(this.btn_Clear);
            this.btn_AddUser.Controls.Add(this.btn_DeleteUser);
            this.btn_AddUser.Controls.Add(this.btn_UpdateUser);
            this.btn_AddUser.Controls.Add(this.btn_AddSysAdmin);
            this.btn_AddUser.Controls.Add(this.btn_SelectAll);
            this.btn_AddUser.Controls.Add(this.chk_UserMange);
            this.btn_AddUser.Controls.Add(this.chk_HistoryTrend);
            this.btn_AddUser.Controls.Add(this.chk_HistoryLog);
            this.btn_AddUser.Controls.Add(this.chk_Recipe);
            this.btn_AddUser.Controls.Add(this.chk_ParamSet);
            this.btn_AddUser.Controls.Add(this.txt_LoginPwd2);
            this.btn_AddUser.Controls.Add(this.txt_LoginPwd);
            this.btn_AddUser.Controls.Add(this.txt_LoginName);
            this.btn_AddUser.Controls.Add(this.label3);
            this.btn_AddUser.Controls.Add(this.label2);
            this.btn_AddUser.Controls.Add(this.label1);
            this.btn_AddUser.Controls.Add(this.titleControl3);
            this.btn_AddUser.Controls.Add(this.titleControl2);
            this.btn_AddUser.Controls.Add(this.titleControl1);
            this.btn_AddUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_AddUser.Location = new System.Drawing.Point(0, 0);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(1420, 720);
            this.btn_AddUser.TabIndex = 0;
            // 
            // dgv_UserManger
            // 
            this.dgv_UserManger.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_UserManger.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_UserManger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UserManger.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoginID,
            this.LoginName,
            this.LoginPwd,
            this.ParamSet,
            this.Recipe,
            this.HisToryLog,
            this.HistoryTrend,
            this.UserMange});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_UserManger.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_UserManger.EnableHeadersVisualStyles = false;
            this.dgv_UserManger.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_UserManger.Location = new System.Drawing.Point(349, 30);
            this.dgv_UserManger.Name = "dgv_UserManger";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_UserManger.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.dgv_UserManger.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_UserManger.RowTemplate.Height = 23;
            this.dgv_UserManger.Size = new System.Drawing.Size(1033, 661);
            this.dgv_UserManger.TabIndex = 19;
            this.dgv_UserManger.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_UserManger_CellClick);
            this.dgv_UserManger.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_UserManger_CellFormatting);
            this.dgv_UserManger.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgv_UserManger_RowPostPaint);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(178, 657);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(103, 34);
            this.btn_Clear.TabIndex = 18;
            this.btn_Clear.Text = "清空信息";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_DeleteUser
            // 
            this.btn_DeleteUser.BackColor = System.Drawing.Color.Transparent;
            this.btn_DeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteUser.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.btn_DeleteUser.ForeColor = System.Drawing.Color.White;
            this.btn_DeleteUser.Location = new System.Drawing.Point(32, 657);
            this.btn_DeleteUser.Name = "btn_DeleteUser";
            this.btn_DeleteUser.Size = new System.Drawing.Size(103, 34);
            this.btn_DeleteUser.TabIndex = 17;
            this.btn_DeleteUser.Text = "删除用户";
            this.btn_DeleteUser.UseVisualStyleBackColor = false;
            this.btn_DeleteUser.Click += new System.EventHandler(this.btn_DeleteUser_Click);
            // 
            // btn_UpdateUser
            // 
            this.btn_UpdateUser.BackColor = System.Drawing.Color.Transparent;
            this.btn_UpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateUser.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.btn_UpdateUser.ForeColor = System.Drawing.Color.White;
            this.btn_UpdateUser.Location = new System.Drawing.Point(178, 581);
            this.btn_UpdateUser.Name = "btn_UpdateUser";
            this.btn_UpdateUser.Size = new System.Drawing.Size(103, 34);
            this.btn_UpdateUser.TabIndex = 16;
            this.btn_UpdateUser.Text = "修改用户";
            this.btn_UpdateUser.UseVisualStyleBackColor = false;
            this.btn_UpdateUser.Click += new System.EventHandler(this.btn_UpdateUser_Click);
            // 
            // btn_AddSysAdmin
            // 
            this.btn_AddSysAdmin.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddSysAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddSysAdmin.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.btn_AddSysAdmin.ForeColor = System.Drawing.Color.White;
            this.btn_AddSysAdmin.Location = new System.Drawing.Point(32, 581);
            this.btn_AddSysAdmin.Name = "btn_AddSysAdmin";
            this.btn_AddSysAdmin.Size = new System.Drawing.Size(103, 34);
            this.btn_AddSysAdmin.TabIndex = 15;
            this.btn_AddSysAdmin.Text = "添加用户";
            this.btn_AddSysAdmin.UseVisualStyleBackColor = false;
            this.btn_AddSysAdmin.Click += new System.EventHandler(this.btn_AddSysAdmin_Click);
            // 
            // btn_SelectAll
            // 
            this.btn_SelectAll.BackColor = System.Drawing.Color.Transparent;
            this.btn_SelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SelectAll.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.btn_SelectAll.ForeColor = System.Drawing.Color.White;
            this.btn_SelectAll.Location = new System.Drawing.Point(178, 462);
            this.btn_SelectAll.Name = "btn_SelectAll";
            this.btn_SelectAll.Size = new System.Drawing.Size(103, 34);
            this.btn_SelectAll.TabIndex = 14;
            this.btn_SelectAll.Text = "全选/不选";
            this.btn_SelectAll.UseVisualStyleBackColor = false;
            this.btn_SelectAll.Click += new System.EventHandler(this.btn_SelectAll_Click);
            // 
            // chk_UserMange
            // 
            this.chk_UserMange.BackColor = System.Drawing.Color.Transparent;
            this.chk_UserMange.CheckBoxColor = System.Drawing.Color.White;
            this.chk_UserMange.DoubleCheckBoxWidth = 30;
            this.chk_UserMange.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.chk_UserMange.ForeColor = System.Drawing.Color.White;
            this.chk_UserMange.Location = new System.Drawing.Point(32, 458);
            this.chk_UserMange.Name = "chk_UserMange";
            this.chk_UserMange.Size = new System.Drawing.Size(116, 38);
            this.chk_UserMange.TabIndex = 13;
            this.chk_UserMange.Text = "用户管理";
            this.chk_UserMange.TextCheckBox = "复选框文本";
            this.chk_UserMange.UseVisualStyleBackColor = false;
            // 
            // chk_HistoryTrend
            // 
            this.chk_HistoryTrend.BackColor = System.Drawing.Color.Transparent;
            this.chk_HistoryTrend.CheckBoxColor = System.Drawing.Color.White;
            this.chk_HistoryTrend.DoubleCheckBoxWidth = 30;
            this.chk_HistoryTrend.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.chk_HistoryTrend.ForeColor = System.Drawing.Color.White;
            this.chk_HistoryTrend.Location = new System.Drawing.Point(178, 404);
            this.chk_HistoryTrend.Name = "chk_HistoryTrend";
            this.chk_HistoryTrend.Size = new System.Drawing.Size(116, 38);
            this.chk_HistoryTrend.TabIndex = 12;
            this.chk_HistoryTrend.Text = "历史趋势";
            this.chk_HistoryTrend.TextCheckBox = "复选框文本";
            this.chk_HistoryTrend.UseVisualStyleBackColor = false;
            // 
            // chk_HistoryLog
            // 
            this.chk_HistoryLog.BackColor = System.Drawing.Color.Transparent;
            this.chk_HistoryLog.CheckBoxColor = System.Drawing.Color.White;
            this.chk_HistoryLog.DoubleCheckBoxWidth = 30;
            this.chk_HistoryLog.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.chk_HistoryLog.ForeColor = System.Drawing.Color.White;
            this.chk_HistoryLog.Location = new System.Drawing.Point(32, 404);
            this.chk_HistoryLog.Name = "chk_HistoryLog";
            this.chk_HistoryLog.Size = new System.Drawing.Size(116, 38);
            this.chk_HistoryLog.TabIndex = 11;
            this.chk_HistoryLog.Text = "报警追溯";
            this.chk_HistoryLog.TextCheckBox = "复选框文本";
            this.chk_HistoryLog.UseVisualStyleBackColor = false;
            // 
            // chk_Recipe
            // 
            this.chk_Recipe.BackColor = System.Drawing.Color.Transparent;
            this.chk_Recipe.CheckBoxColor = System.Drawing.Color.White;
            this.chk_Recipe.DoubleCheckBoxWidth = 30;
            this.chk_Recipe.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.chk_Recipe.ForeColor = System.Drawing.Color.White;
            this.chk_Recipe.Location = new System.Drawing.Point(178, 342);
            this.chk_Recipe.Name = "chk_Recipe";
            this.chk_Recipe.Size = new System.Drawing.Size(116, 38);
            this.chk_Recipe.TabIndex = 10;
            this.chk_Recipe.Text = "配方管理";
            this.chk_Recipe.TextCheckBox = "复选框文本";
            this.chk_Recipe.UseVisualStyleBackColor = false;
            // 
            // chk_ParamSet
            // 
            this.chk_ParamSet.BackColor = System.Drawing.Color.Transparent;
            this.chk_ParamSet.CheckBoxColor = System.Drawing.Color.White;
            this.chk_ParamSet.DoubleCheckBoxWidth = 30;
            this.chk_ParamSet.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.chk_ParamSet.ForeColor = System.Drawing.Color.White;
            this.chk_ParamSet.Location = new System.Drawing.Point(32, 342);
            this.chk_ParamSet.Name = "chk_ParamSet";
            this.chk_ParamSet.Size = new System.Drawing.Size(116, 38);
            this.chk_ParamSet.TabIndex = 9;
            this.chk_ParamSet.Text = "参数设置";
            this.chk_ParamSet.TextCheckBox = "复选框文本";
            this.chk_ParamSet.UseVisualStyleBackColor = false;
            // 
            // txt_LoginPwd2
            // 
            this.txt_LoginPwd2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.txt_LoginPwd2.Location = new System.Drawing.Point(144, 225);
            this.txt_LoginPwd2.Name = "txt_LoginPwd2";
            this.txt_LoginPwd2.PasswordChar = '*';
            this.txt_LoginPwd2.Size = new System.Drawing.Size(150, 34);
            this.txt_LoginPwd2.TabIndex = 8;
            this.txt_LoginPwd2.Text = "123";
            // 
            // txt_LoginPwd
            // 
            this.txt_LoginPwd.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.txt_LoginPwd.Location = new System.Drawing.Point(144, 163);
            this.txt_LoginPwd.Name = "txt_LoginPwd";
            this.txt_LoginPwd.PasswordChar = '*';
            this.txt_LoginPwd.Size = new System.Drawing.Size(150, 34);
            this.txt_LoginPwd.TabIndex = 7;
            this.txt_LoginPwd.Text = "123";
            // 
            // txt_LoginName
            // 
            this.txt_LoginName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.txt_LoginName.Location = new System.Drawing.Point(144, 106);
            this.txt_LoginName.Name = "txt_LoginName";
            this.txt_LoginName.Size = new System.Drawing.Size(150, 29);
            this.txt_LoginName.TabIndex = 6;
            this.txt_LoginName.Text = "Admin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(47, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "用户密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "用户密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "用户名称";
            // 
            // titleControl3
            // 
            this.titleControl3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.titleControl3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("titleControl3.BackgroundImage")));
            this.titleControl3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.titleControl3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.titleControl3.Location = new System.Drawing.Point(32, 513);
            this.titleControl3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.titleControl3.Name = "titleControl3";
            this.titleControl3.Size = new System.Drawing.Size(109, 31);
            this.titleControl3.TabIndex = 2;
            this.titleControl3.TitleName = "用户操作";
            // 
            // titleControl2
            // 
            this.titleControl2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.titleControl2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("titleControl2.BackgroundImage")));
            this.titleControl2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.titleControl2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.titleControl2.Location = new System.Drawing.Point(39, 280);
            this.titleControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.titleControl2.Name = "titleControl2";
            this.titleControl2.Size = new System.Drawing.Size(109, 31);
            this.titleControl2.TabIndex = 1;
            this.titleControl2.TitleName = "权限配置";
            // 
            // titleControl1
            // 
            this.titleControl1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.titleControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("titleControl1.BackgroundImage")));
            this.titleControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.titleControl1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.titleControl1.Location = new System.Drawing.Point(39, 30);
            this.titleControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.titleControl1.Name = "titleControl1";
            this.titleControl1.Size = new System.Drawing.Size(109, 31);
            this.titleControl1.TabIndex = 0;
            this.titleControl1.TitleName = "用户信息";
            // 
            // LoginID
            // 
            this.LoginID.DataPropertyName = "loginid";
            this.LoginID.HeaderText = "用户ID";
            this.LoginID.Name = "LoginID";
            this.LoginID.Visible = false;
            // 
            // LoginName
            // 
            this.LoginName.DataPropertyName = "LoginName";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.LoginName.DefaultCellStyle = dataGridViewCellStyle2;
            this.LoginName.HeaderText = "用户名";
            this.LoginName.Name = "LoginName";
            // 
            // LoginPwd
            // 
            this.LoginPwd.DataPropertyName = "loginPwd";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.LoginPwd.DefaultCellStyle = dataGridViewCellStyle3;
            this.LoginPwd.HeaderText = "用户密码";
            this.LoginPwd.Name = "LoginPwd";
            this.LoginPwd.Width = 150;
            // 
            // ParamSet
            // 
            this.ParamSet.DataPropertyName = "ParamSet";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.ParamSet.DefaultCellStyle = dataGridViewCellStyle4;
            this.ParamSet.HeaderText = "参数设置";
            this.ParamSet.Name = "ParamSet";
            this.ParamSet.Width = 150;
            // 
            // Recipe
            // 
            this.Recipe.DataPropertyName = "Recipe";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.Recipe.DefaultCellStyle = dataGridViewCellStyle5;
            this.Recipe.HeaderText = "配置设置";
            this.Recipe.Name = "Recipe";
            this.Recipe.Width = 150;
            // 
            // HisToryLog
            // 
            this.HisToryLog.DataPropertyName = "HistoryLog";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.HisToryLog.DefaultCellStyle = dataGridViewCellStyle6;
            this.HisToryLog.HeaderText = "报警追溯";
            this.HisToryLog.Name = "HisToryLog";
            this.HisToryLog.Width = 150;
            // 
            // HistoryTrend
            // 
            this.HistoryTrend.DataPropertyName = "HistoryTrend";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.HistoryTrend.DefaultCellStyle = dataGridViewCellStyle7;
            this.HistoryTrend.HeaderText = "历史趋势";
            this.HistoryTrend.Name = "HistoryTrend";
            this.HistoryTrend.Width = 150;
            // 
            // UserMange
            // 
            this.UserMange.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserMange.DataPropertyName = "UserMange";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.UserMange.DefaultCellStyle = dataGridViewCellStyle8;
            this.UserMange.HeaderText = "用户管理";
            this.UserMange.Name = "UserMange";
            // 
            // FrmUserMange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 720);
            this.Controls.Add(this.btn_AddUser);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmUserMange";
            this.Text = "用户管理";
            this.btn_AddUser.ResumeLayout(false);
            this.btn_AddUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserManger)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ControlLib.PanelEnhanced btn_AddUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ControlLib.TitleControl titleControl3;
        private ControlLib.TitleControl titleControl2;
        private ControlLib.TitleControl titleControl1;
        private System.Windows.Forms.Button btn_SelectAll;
        private ControlLib.CheckBoxEX chk_UserMange;
        private ControlLib.CheckBoxEX chk_HistoryTrend;
        private ControlLib.CheckBoxEX chk_HistoryLog;
        private ControlLib.CheckBoxEX chk_Recipe;
        private ControlLib.CheckBoxEX chk_ParamSet;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_DeleteUser;
        private System.Windows.Forms.Button btn_UpdateUser;
        private System.Windows.Forms.Button btn_AddSysAdmin;
        private System.Windows.Forms.DataGridView dgv_UserManger;
        private System.Windows.Forms.TextBox txt_LoginPwd2;
        private System.Windows.Forms.TextBox txt_LoginPwd;
        private System.Windows.Forms.TextBox txt_LoginName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginPwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParamSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recipe;
        private System.Windows.Forms.DataGridViewTextBoxColumn HisToryLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn HistoryTrend;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserMange;
    }
}