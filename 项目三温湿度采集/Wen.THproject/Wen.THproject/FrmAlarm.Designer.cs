namespace Wen.THproject
{
    partial class FrmAlarm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEnhanced1 = new Wen.ControlLib.PanelEnhanced();
            this.dgv_Main = new System.Windows.Forms.DataGridView();
            this.insertTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Varnaem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_SaveExcel = new System.Windows.Forms.Button();
            this.btn_SelectTime = new System.Windows.Forms.Button();
            this.dtp_EndTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_StartTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_AlarmType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelEnhanced1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEnhanced1
            // 
            this.panelEnhanced1.BackgroundImage = global::Wen.THproject.Properties.Resources.BackGround;
            this.panelEnhanced1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelEnhanced1.Controls.Add(this.dgv_Main);
            this.panelEnhanced1.Controls.Add(this.btn_SaveExcel);
            this.panelEnhanced1.Controls.Add(this.btn_SelectTime);
            this.panelEnhanced1.Controls.Add(this.dtp_EndTime);
            this.panelEnhanced1.Controls.Add(this.label2);
            this.panelEnhanced1.Controls.Add(this.dtp_StartTime);
            this.panelEnhanced1.Controls.Add(this.label1);
            this.panelEnhanced1.Controls.Add(this.cmb_AlarmType);
            this.panelEnhanced1.Controls.Add(this.label3);
            this.panelEnhanced1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEnhanced1.Location = new System.Drawing.Point(0, 0);
            this.panelEnhanced1.Name = "panelEnhanced1";
            this.panelEnhanced1.Size = new System.Drawing.Size(1420, 720);
            this.panelEnhanced1.TabIndex = 0;
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Main.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_Main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Main.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.insertTime,
            this.alarmtype,
            this.Note,
            this.Operator,
            this.Varnaem});
            this.dgv_Main.EnableHeadersVisualStyles = false;
            this.dgv_Main.GridColor = System.Drawing.Color.White;
            this.dgv_Main.Location = new System.Drawing.Point(58, 108);
            this.dgv_Main.Name = "dgv_Main";
            this.dgv_Main.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Main.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_Main.RowHeadersWidth = 50;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Main.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgv_Main.RowTemplate.Height = 40;
            this.dgv_Main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Main.Size = new System.Drawing.Size(1253, 573);
            this.dgv_Main.TabIndex = 21;
            this.dgv_Main.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgv_Main_RowPostPaint);
            // 
            // insertTime
            // 
            this.insertTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.insertTime.DataPropertyName = "inserttime";
            this.insertTime.FillWeight = 98.47716F;
            this.insertTime.HeaderText = "时间";
            this.insertTime.Name = "insertTime";
            this.insertTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.insertTime.Width = 200;
            // 
            // alarmtype
            // 
            this.alarmtype.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.alarmtype.DataPropertyName = "alarmtype";
            this.alarmtype.FillWeight = 101.5228F;
            this.alarmtype.HeaderText = "报警类型";
            this.alarmtype.Name = "alarmtype";
            this.alarmtype.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.alarmtype.Width = 150;
            // 
            // Note
            // 
            this.Note.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Note.DataPropertyName = "note";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Note.DefaultCellStyle = dataGridViewCellStyle14;
            this.Note.HeaderText = "报警内容";
            this.Note.Name = "Note";
            this.Note.Width = 400;
            // 
            // Operator
            // 
            this.Operator.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Operator.DataPropertyName = "operator";
            this.Operator.HeaderText = "操作员";
            this.Operator.Name = "Operator";
            this.Operator.Width = 200;
            // 
            // Varnaem
            // 
            this.Varnaem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Varnaem.DataPropertyName = "varname";
            this.Varnaem.HeaderText = "变量名";
            this.Varnaem.Name = "Varnaem";
            // 
            // btn_SaveExcel
            // 
            this.btn_SaveExcel.BackColor = System.Drawing.Color.Transparent;
            this.btn_SaveExcel.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_SaveExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveExcel.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.btn_SaveExcel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_SaveExcel.Location = new System.Drawing.Point(1208, 22);
            this.btn_SaveExcel.Name = "btn_SaveExcel";
            this.btn_SaveExcel.Size = new System.Drawing.Size(120, 36);
            this.btn_SaveExcel.TabIndex = 13;
            this.btn_SaveExcel.Text = "导入Excel";
            this.btn_SaveExcel.UseVisualStyleBackColor = false;
            this.btn_SaveExcel.Click += new System.EventHandler(this.btn_SaveExcel_Click);
            // 
            // btn_SelectTime
            // 
            this.btn_SelectTime.BackColor = System.Drawing.Color.Transparent;
            this.btn_SelectTime.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_SelectTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SelectTime.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.btn_SelectTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_SelectTime.Location = new System.Drawing.Point(1032, 21);
            this.btn_SelectTime.Name = "btn_SelectTime";
            this.btn_SelectTime.Size = new System.Drawing.Size(120, 36);
            this.btn_SelectTime.TabIndex = 12;
            this.btn_SelectTime.Text = "时间查询";
            this.btn_SelectTime.UseVisualStyleBackColor = false;
            this.btn_SelectTime.Click += new System.EventHandler(this.btn_SelectTime_Click);
            // 
            // dtp_EndTime
            // 
            this.dtp_EndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtp_EndTime.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            this.dtp_EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_EndTime.Location = new System.Drawing.Point(779, 27);
            this.dtp_EndTime.Name = "dtp_EndTime";
            this.dtp_EndTime.Size = new System.Drawing.Size(220, 30);
            this.dtp_EndTime.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(689, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "结束时间";
            // 
            // dtp_StartTime
            // 
            this.dtp_StartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtp_StartTime.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            this.dtp_StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_StartTime.Location = new System.Drawing.Point(436, 27);
            this.dtp_StartTime.Name = "dtp_StartTime";
            this.dtp_StartTime.Size = new System.Drawing.Size(220, 30);
            this.dtp_StartTime.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(346, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "开始时间";
            // 
            // cmb_AlarmType
            // 
            this.cmb_AlarmType.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            this.cmb_AlarmType.FormattingEnabled = true;
            this.cmb_AlarmType.Location = new System.Drawing.Point(141, 25);
            this.cmb_AlarmType.Name = "cmb_AlarmType";
            this.cmb_AlarmType.Size = new System.Drawing.Size(135, 32);
            this.cmb_AlarmType.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(37, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "报警类型";
            // 
            // FrmAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1420, 720);
            this.Controls.Add(this.panelEnhanced1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAlarm";
            this.Text = "报警追溯";
            this.panelEnhanced1.ResumeLayout(false);
            this.panelEnhanced1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ControlLib.PanelEnhanced panelEnhanced1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_EndTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_StartTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_AlarmType;
        private System.Windows.Forms.Button btn_SaveExcel;
        private System.Windows.Forms.Button btn_SelectTime;
        private System.Windows.Forms.DataGridView dgv_Main;
        private System.Windows.Forms.DataGridViewTextBoxColumn insertTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operator;
        private System.Windows.Forms.DataGridViewTextBoxColumn Varnaem;
    }
}