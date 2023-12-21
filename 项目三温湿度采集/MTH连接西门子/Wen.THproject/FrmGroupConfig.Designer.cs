namespace Wen.THproject
{
    partial class FrmGroupConfig
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGroupConfig));
            this.panelEx1 = new Wen.ControlLib.PanelEx();
            this.dgv_Main = new System.Windows.Forms.DataGridView();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除通信组ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_Remark = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_StoreAsea = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nud_Length = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nud_Start = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_GroupName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelEnhanced1 = new Wen.ControlLib.PanelEnhanced();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Main)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Start)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.BackColor = System.Drawing.Color.Transparent;
            this.panelEx1.BordColor = System.Drawing.Color.Navy;
            this.panelEx1.BordWidth = 2;
            this.panelEx1.BottomGap = 1;
            this.panelEx1.Controls.Add(this.dgv_Main);
            this.panelEx1.Controls.Add(this.btn_Update);
            this.panelEx1.Controls.Add(this.btn_Delete);
            this.panelEx1.Controls.Add(this.btn_Add);
            this.panelEx1.Controls.Add(this.txt_Remark);
            this.panelEx1.Controls.Add(this.label6);
            this.panelEx1.Controls.Add(this.cmb_StoreAsea);
            this.panelEx1.Controls.Add(this.label5);
            this.panelEx1.Controls.Add(this.nud_Length);
            this.panelEx1.Controls.Add(this.label4);
            this.panelEx1.Controls.Add(this.nud_Start);
            this.panelEx1.Controls.Add(this.label3);
            this.panelEx1.Controls.Add(this.txt_GroupName);
            this.panelEx1.Controls.Add(this.label2);
            this.panelEx1.Controls.Add(this.panelTop);
            this.panelEx1.Controls.Add(this.panelEnhanced1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.LeftGap = 1;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.RightGap = 1;
            this.panelEx1.Size = new System.Drawing.Size(792, 514);
            this.panelEx1.TabIndex = 0;
            this.panelEx1.TopGap = 1;
            this.panelEx1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.panelEx1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            // 
            // dgv_Main
            // 
            this.dgv_Main.AllowUserToAddRows = false;
            this.dgv_Main.AllowUserToDeleteRows = false;
            this.dgv_Main.AllowUserToResizeColumns = false;
            this.dgv_Main.AllowUserToResizeRows = false;
            this.dgv_Main.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Main.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.dgv_Main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Main.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Main.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Main.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupName,
            this.Start,
            this.Length,
            this.StoreArea,
            this.Remark});
            this.dgv_Main.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_Main.EnableHeadersVisualStyles = false;
            this.dgv_Main.GridColor = System.Drawing.Color.White;
            this.dgv_Main.Location = new System.Drawing.Point(26, 165);
            this.dgv_Main.Name = "dgv_Main";
            this.dgv_Main.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Main.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Main.RowHeadersWidth = 50;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Main.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Main.RowTemplate.Height = 40;
            this.dgv_Main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Main.Size = new System.Drawing.Size(737, 337);
            this.dgv_Main.TabIndex = 19;
            this.dgv_Main.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Main_CellClick);
            this.dgv_Main.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_Main_CellFormatting);
            this.dgv_Main.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgv_Main_RowPostPaint);
            // 
            // GroupName
            // 
            this.GroupName.DataPropertyName = "GroupName";
            this.GroupName.HeaderText = "通信组名称";
            this.GroupName.Name = "GroupName";
            this.GroupName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Start
            // 
            this.Start.DataPropertyName = "Start";
            this.Start.HeaderText = "起始地址";
            this.Start.Name = "Start";
            this.Start.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Length
            // 
            this.Length.DataPropertyName = "Length";
            this.Length.HeaderText = "长度";
            this.Length.Name = "Length";
            this.Length.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // StoreArea
            // 
            this.StoreArea.DataPropertyName = "StoreArea";
            this.StoreArea.HeaderText = "存储区";
            this.StoreArea.Name = "StoreArea";
            this.StoreArea.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "备注";
            this.Remark.Name = "Remark";
            this.Remark.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除通信组ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 26);
            // 
            // 删除通信组ToolStripMenuItem
            // 
            this.删除通信组ToolStripMenuItem.Name = "删除通信组ToolStripMenuItem";
            this.删除通信组ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.删除通信组ToolStripMenuItem.Text = "删除通信组";
            this.删除通信组ToolStripMenuItem.Click += new System.EventHandler(this.删除通信组ToolStripMenuItem_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Transparent;
            this.btn_Update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.btn_Update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Update.Location = new System.Drawing.Point(673, 111);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(107, 41);
            this.btn_Update.TabIndex = 18;
            this.btn_Update.Text = "修改通信组";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Delete.Location = new System.Drawing.Point(553, 111);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(107, 41);
            this.btn_Delete.TabIndex = 17;
            this.btn_Delete.Text = "删除通信组";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Transparent;
            this.btn_Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.btn_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Add.Location = new System.Drawing.Point(433, 111);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(107, 41);
            this.btn_Add.TabIndex = 7;
            this.btn_Add.Text = "新增通信组";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_Remark
            // 
            this.txt_Remark.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.txt_Remark.Location = new System.Drawing.Point(108, 119);
            this.txt_Remark.Name = "txt_Remark";
            this.txt_Remark.Size = new System.Drawing.Size(319, 28);
            this.txt_Remark.TabIndex = 16;
            this.txt_Remark.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(12, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "备注说明";
            // 
            // cmb_StoreAsea
            // 
            this.cmb_StoreAsea.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmb_StoreAsea.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.cmb_StoreAsea.FormattingEnabled = true;
            this.cmb_StoreAsea.Location = new System.Drawing.Point(637, 65);
            this.cmb_StoreAsea.Name = "cmb_StoreAsea";
            this.cmb_StoreAsea.Size = new System.Drawing.Size(114, 30);
            this.cmb_StoreAsea.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(541, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "存储区名称";
            // 
            // nud_Length
            // 
            this.nud_Length.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.nud_Length.Location = new System.Drawing.Point(462, 65);
            this.nud_Length.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nud_Length.Name = "nud_Length";
            this.nud_Length.Size = new System.Drawing.Size(64, 29);
            this.nud_Length.TabIndex = 12;
            this.nud_Length.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_Length.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(414, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "长度";
            // 
            // nud_Start
            // 
            this.nud_Start.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.nud_Start.Location = new System.Drawing.Point(333, 65);
            this.nud_Start.Name = "nud_Start";
            this.nud_Start.Size = new System.Drawing.Size(64, 29);
            this.nud_Start.TabIndex = 10;
            this.nud_Start.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(253, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "起始地址";
            // 
            // txt_GroupName
            // 
            this.txt_GroupName.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.txt_GroupName.Location = new System.Drawing.Point(108, 66);
            this.txt_GroupName.Name = "txt_GroupName";
            this.txt_GroupName.Size = new System.Drawing.Size(139, 28);
            this.txt_GroupName.TabIndex = 8;
            this.txt_GroupName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "通信组名称";
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btn_Close);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(792, 51);
            this.panelTop.TabIndex = 0;
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
            this.btn_Close.Location = new System.Drawing.Point(746, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(43, 41);
            this.btn_Close.TabIndex = 6;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "通信组设置";
            // 
            // panelEnhanced1
            // 
            this.panelEnhanced1.BackgroundImage = global::Wen.THproject.Properties.Resources.BackGround;
            this.panelEnhanced1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEnhanced1.Location = new System.Drawing.Point(0, 0);
            this.panelEnhanced1.Name = "panelEnhanced1";
            this.panelEnhanced1.Size = new System.Drawing.Size(792, 514);
            this.panelEnhanced1.TabIndex = 20;
            // 
            // FrmGroupConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Wen.THproject.Properties.Resources.BackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(792, 514);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGroupConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmGroupConfig";
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Main)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Start)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ControlLib.PanelEx panelEx1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.TextBox txt_GroupName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_StoreAsea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nud_Length;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nud_Start;
        private System.Windows.Forms.DataGridView dgv_Main;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_Remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除通信组ToolStripMenuItem;
        private ControlLib.PanelEnhanced panelEnhanced1;
    }
}