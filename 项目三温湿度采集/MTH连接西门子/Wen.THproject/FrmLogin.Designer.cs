namespace Wen.THproject
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_PassWord = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Cenel = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.panelEnhanced1 = new Wen.ControlLib.PanelEnhanced();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(58, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "登录";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(58, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户名:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(50, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "密码:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "多温湿度采集登录系统";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(178, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(358, 1);
            this.label5.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(178, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(358, 1);
            this.label6.TabIndex = 5;
            // 
            // txt_UserName
            // 
            this.txt_UserName.BackColor = System.Drawing.Color.SkyBlue;
            this.txt_UserName.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold);
            this.txt_UserName.Location = new System.Drawing.Point(184, 152);
            this.txt_UserName.Multiline = true;
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(352, 32);
            this.txt_UserName.TabIndex = 6;
            this.txt_UserName.Text = "Admin";
            this.txt_UserName.DoubleClick += new System.EventHandler(this.txtCommon_DoubuleClick);
            this.txt_UserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_UserName_KeyDown);
            // 
            // txt_PassWord
            // 
            this.txt_PassWord.BackColor = System.Drawing.Color.SkyBlue;
            this.txt_PassWord.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold);
            this.txt_PassWord.Location = new System.Drawing.Point(184, 267);
            this.txt_PassWord.Multiline = true;
            this.txt_PassWord.Name = "txt_PassWord";
            this.txt_PassWord.PasswordChar = '*';
            this.txt_PassWord.Size = new System.Drawing.Size(352, 32);
            this.txt_PassWord.TabIndex = 7;
            this.txt_PassWord.Text = "123";
            this.txt_PassWord.DoubleClick += new System.EventHandler(this.txtCommon_DoubuleClick);
            this.txt_PassWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_UserName_KeyDown);
            // 
            // btn_Login
            // 
            this.btn_Login.AutoSize = true;
            this.btn_Login.BackColor = System.Drawing.Color.Transparent;
            this.btn_Login.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold);
            this.btn_Login.Image = global::Wen.THproject.Properties.Resources.LoginButton;
            this.btn_Login.Location = new System.Drawing.Point(148, 326);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(92, 38);
            this.btn_Login.TabIndex = 8;
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Cenel
            // 
            this.btn_Cenel.AutoSize = true;
            this.btn_Cenel.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cenel.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold);
            this.btn_Cenel.Image = global::Wen.THproject.Properties.Resources.ExitButton;
            this.btn_Cenel.Location = new System.Drawing.Point(313, 326);
            this.btn_Cenel.Name = "btn_Cenel";
            this.btn_Cenel.Size = new System.Drawing.Size(92, 38);
            this.btn_Cenel.TabIndex = 9;
            this.btn_Cenel.UseVisualStyleBackColor = false;
            this.btn_Cenel.Click += new System.EventHandler(this.btn_Cenel_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.btn_Close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Close.Location = new System.Drawing.Point(552, 4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(43, 41);
            this.btn_Close.TabIndex = 10;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // panelEnhanced1
            // 
            this.panelEnhanced1.BackColor = System.Drawing.Color.Transparent;
            this.panelEnhanced1.BackgroundImage = global::Wen.THproject.Properties.Resources.BackGround;
            this.panelEnhanced1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEnhanced1.ForeColor = System.Drawing.Color.Transparent;
            this.panelEnhanced1.Location = new System.Drawing.Point(0, 0);
            this.panelEnhanced1.Name = "panelEnhanced1";
            this.panelEnhanced1.Size = new System.Drawing.Size(607, 389);
            this.panelEnhanced1.TabIndex = 11;
            this.panelEnhanced1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.panelEnhanced1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Wen.THproject.Properties.Resources.BackGround;
            this.ClientSize = new System.Drawing.Size(607, 389);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Cenel);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_PassWord);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelEnhanced1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmLogin";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_PassWord;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Cenel;
        private System.Windows.Forms.Button btn_Close;
        private ControlLib.PanelEnhanced panelEnhanced1;
    }
}