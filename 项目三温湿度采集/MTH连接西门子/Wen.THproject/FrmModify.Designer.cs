namespace Wen.THproject
{
    partial class FrmModify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModify));
            this.panelEx1 = new Wen.ControlLib.PanelEx();
            this.txt_SetValue = new System.Windows.Forms.TextBox();
            this.lbl_CurrentValue = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_No = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.titleControl1 = new Wen.ControlLib.TitleControl();
            this.panelEnhanced1 = new Wen.ControlLib.PanelEnhanced();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.BackColor = System.Drawing.Color.Transparent;
            this.panelEx1.BordColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.panelEx1.BordWidth = 5;
            this.panelEx1.BottomGap = 5;
            this.panelEx1.Controls.Add(this.txt_SetValue);
            this.panelEx1.Controls.Add(this.lbl_CurrentValue);
            this.panelEx1.Controls.Add(this.lbl_Title);
            this.panelEx1.Controls.Add(this.btn_No);
            this.panelEx1.Controls.Add(this.btn_OK);
            this.panelEx1.Controls.Add(this.label3);
            this.panelEx1.Controls.Add(this.label2);
            this.panelEx1.Controls.Add(this.label1);
            this.panelEx1.Controls.Add(this.btn_Close);
            this.panelEx1.Controls.Add(this.titleControl1);
            this.panelEx1.Controls.Add(this.panelEnhanced1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.LeftGap = 5;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.RightGap = 5;
            this.panelEx1.Size = new System.Drawing.Size(335, 373);
            this.panelEx1.TabIndex = 0;
            this.panelEx1.TopGap = 3;
            this.panelEx1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.panelEx1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            // 
            // txt_SetValue
            // 
            this.txt_SetValue.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.txt_SetValue.Location = new System.Drawing.Point(124, 223);
            this.txt_SetValue.Multiline = true;
            this.txt_SetValue.Name = "txt_SetValue";
            this.txt_SetValue.Size = new System.Drawing.Size(169, 41);
            this.txt_SetValue.TabIndex = 0;
            this.txt_SetValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_SetValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_SetValue_KeyDown);
            // 
            // lbl_CurrentValue
            // 
            this.lbl_CurrentValue.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CurrentValue.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.lbl_CurrentValue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_CurrentValue.Location = new System.Drawing.Point(131, 161);
            this.lbl_CurrentValue.Name = "lbl_CurrentValue";
            this.lbl_CurrentValue.Size = new System.Drawing.Size(169, 41);
            this.lbl_CurrentValue.TabIndex = 14;
            this.lbl_CurrentValue.Text = "0.0";
            this.lbl_CurrentValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Title
            // 
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Title.Location = new System.Drawing.Point(124, 94);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(169, 41);
            this.lbl_Title.TabIndex = 13;
            this.lbl_Title.Text = "1#站点温度高限";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_No
            // 
            this.btn_No.BackColor = System.Drawing.Color.Transparent;
            this.btn_No.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.btn_No.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_No.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_No.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.btn_No.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_No.Location = new System.Drawing.Point(193, 310);
            this.btn_No.Name = "btn_No";
            this.btn_No.Size = new System.Drawing.Size(107, 41);
            this.btn_No.TabIndex = 2;
            this.btn_No.Text = "取消";
            this.btn_No.UseVisualStyleBackColor = false;
            this.btn_No.Click += new System.EventHandler(this.btn_No_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.Color.Transparent;
            this.btn_OK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.btn_OK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.btn_OK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_OK.Location = new System.Drawing.Point(40, 310);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(107, 41);
            this.btn_OK.TabIndex = 1;
            this.btn_OK.Text = "确认";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(21, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "修改值：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(21, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "当前值：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(21, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "参数名称：";
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
            this.btn_Close.Location = new System.Drawing.Point(280, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(43, 41);
            this.btn_Close.TabIndex = 7;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // titleControl1
            // 
            this.titleControl1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.titleControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("titleControl1.BackgroundImage")));
            this.titleControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.titleControl1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.titleControl1.Location = new System.Drawing.Point(13, 14);
            this.titleControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.titleControl1.Name = "titleControl1";
            this.titleControl1.Size = new System.Drawing.Size(109, 31);
            this.titleControl1.TabIndex = 0;
            this.titleControl1.TitleName = "参数修改";
            // 
            // panelEnhanced1
            // 
            this.panelEnhanced1.BackgroundImage = global::Wen.THproject.Properties.Resources.BackGround;
            this.panelEnhanced1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEnhanced1.Location = new System.Drawing.Point(0, 0);
            this.panelEnhanced1.Name = "panelEnhanced1";
            this.panelEnhanced1.Size = new System.Drawing.Size(335, 373);
            this.panelEnhanced1.TabIndex = 15;
            // 
            // FrmModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Wen.THproject.Properties.Resources.BackGround;
            this.ClientSize = new System.Drawing.Size(335, 373);
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmModify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmModify";
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ControlLib.PanelEx panelEx1;
        private ControlLib.TitleControl titleControl1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Label lbl_CurrentValue;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_No;
        private System.Windows.Forms.TextBox txt_SetValue;
        private ControlLib.PanelEnhanced panelEnhanced1;
    }
}