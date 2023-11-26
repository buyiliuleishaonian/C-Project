namespace Wen.THproject
{
    partial class FrmRecipe
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
            MTHModels.RecipeParam recipeParam1 = new MTHModels.RecipeParam();
            MTHModels.RecipeParam recipeParam2 = new MTHModels.RecipeParam();
            MTHModels.RecipeParam recipeParam3 = new MTHModels.RecipeParam();
            MTHModels.RecipeParam recipeParam4 = new MTHModels.RecipeParam();
            MTHModels.RecipeParam recipeParam5 = new MTHModels.RecipeParam();
            MTHModels.RecipeParam recipeParam6 = new MTHModels.RecipeParam();
            this.panelEnhanced1 = new Wen.ControlLib.PanelEnhanced();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_RecipeInfoName = new System.Windows.Forms.TextBox();
            this.lbl_CurrentRecipeInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Main = new System.Windows.Forms.DataGridView();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除配方ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.应用配方ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recipeControl6 = new Wen.ControlLib.RecipeControl();
            this.recipeControl5 = new Wen.ControlLib.RecipeControl();
            this.recipeControl4 = new Wen.ControlLib.RecipeControl();
            this.recipeControl3 = new Wen.ControlLib.RecipeControl();
            this.recipeControl2 = new Wen.ControlLib.RecipeControl();
            this.recipeControl1 = new Wen.ControlLib.RecipeControl();
            this.panelEnhanced1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Main)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEnhanced1
            // 
            this.panelEnhanced1.BackgroundImage = global::Wen.THproject.Properties.Resources.BackGround;
            this.panelEnhanced1.Controls.Add(this.splitContainer1);
            this.panelEnhanced1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEnhanced1.Location = new System.Drawing.Point(0, 0);
            this.panelEnhanced1.Name = "panelEnhanced1";
            this.panelEnhanced1.Size = new System.Drawing.Size(1420, 720);
            this.panelEnhanced1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_Apply);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Delete);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Update);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Add);
            this.splitContainer1.Panel1.Controls.Add(this.txt_RecipeInfoName);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_CurrentRecipeInfo);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.dgv_Main);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.recipeControl6);
            this.splitContainer1.Panel2.Controls.Add(this.recipeControl5);
            this.splitContainer1.Panel2.Controls.Add(this.recipeControl4);
            this.splitContainer1.Panel2.Controls.Add(this.recipeControl3);
            this.splitContainer1.Panel2.Controls.Add(this.recipeControl2);
            this.splitContainer1.Panel2.Controls.Add(this.recipeControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1420, 720);
            this.splitContainer1.SplitterDistance = 327;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_Apply
            // 
            this.btn_Apply.BackColor = System.Drawing.Color.Transparent;
            this.btn_Apply.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Apply.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.btn_Apply.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Apply.Location = new System.Drawing.Point(184, 672);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(120, 36);
            this.btn_Apply.TabIndex = 29;
            this.btn_Apply.Text = "应用配方";
            this.btn_Apply.UseVisualStyleBackColor = false;
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_Delete.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Delete.Location = new System.Drawing.Point(38, 672);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(120, 36);
            this.btn_Delete.TabIndex = 28;
            this.btn_Delete.Text = "删除配方";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Transparent;
            this.btn_Update.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.btn_Update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Update.Location = new System.Drawing.Point(184, 603);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(120, 36);
            this.btn_Update.TabIndex = 27;
            this.btn_Update.Text = "修改配方";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Transparent;
            this.btn_Add.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Add.Location = new System.Drawing.Point(38, 603);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(120, 36);
            this.btn_Add.TabIndex = 26;
            this.btn_Add.Text = "添加配方";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_RecipeInfoName
            // 
            this.txt_RecipeInfoName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.txt_RecipeInfoName.Location = new System.Drawing.Point(141, 542);
            this.txt_RecipeInfoName.Name = "txt_RecipeInfoName";
            this.txt_RecipeInfoName.Size = new System.Drawing.Size(127, 29);
            this.txt_RecipeInfoName.TabIndex = 25;
            this.txt_RecipeInfoName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_CurrentRecipeInfo
            // 
            this.lbl_CurrentRecipeInfo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CurrentRecipeInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_CurrentRecipeInfo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_CurrentRecipeInfo.ForeColor = System.Drawing.Color.White;
            this.lbl_CurrentRecipeInfo.Location = new System.Drawing.Point(141, 471);
            this.lbl_CurrentRecipeInfo.Name = "lbl_CurrentRecipeInfo";
            this.lbl_CurrentRecipeInfo.Size = new System.Drawing.Size(127, 40);
            this.lbl_CurrentRecipeInfo.TabIndex = 24;
            this.lbl_CurrentRecipeInfo.Text = "HUAP";
            this.lbl_CurrentRecipeInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 549);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "配方名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 480);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "当前配方：";
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Main.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Main.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupName,
            this.Start});
            this.dgv_Main.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_Main.EnableHeadersVisualStyles = false;
            this.dgv_Main.GridColor = System.Drawing.Color.White;
            this.dgv_Main.Location = new System.Drawing.Point(29, 12);
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
            this.dgv_Main.RowHeadersVisible = false;
            this.dgv_Main.RowHeadersWidth = 50;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Main.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Main.RowTemplate.Height = 40;
            this.dgv_Main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Main.Size = new System.Drawing.Size(275, 445);
            this.dgv_Main.TabIndex = 20;
            this.dgv_Main.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Main_CellClick);
            // 
            // GroupName
            // 
            this.GroupName.DataPropertyName = "GroupName";
            this.GroupName.FillWeight = 98.47716F;
            this.GroupName.HeaderText = "序号";
            this.GroupName.Name = "GroupName";
            this.GroupName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Start
            // 
            this.Start.DataPropertyName = "Start";
            this.Start.FillWeight = 101.5228F;
            this.Start.HeaderText = "配方名称";
            this.Start.Name = "Start";
            this.Start.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除配方ToolStripMenuItem,
            this.应用配方ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 48);
            // 
            // 删除配方ToolStripMenuItem
            // 
            this.删除配方ToolStripMenuItem.Name = "删除配方ToolStripMenuItem";
            this.删除配方ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除配方ToolStripMenuItem.Text = "删除配方";
            this.删除配方ToolStripMenuItem.Click += new System.EventHandler(this.删除配方ToolStripMenuItem_Click);
            // 
            // 应用配方ToolStripMenuItem
            // 
            this.应用配方ToolStripMenuItem.Name = "应用配方ToolStripMenuItem";
            this.应用配方ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.应用配方ToolStripMenuItem.Text = "应用配方";
            // 
            // recipeControl6
            // 
            this.recipeControl6.BackColor = System.Drawing.Color.Transparent;
            this.recipeControl6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.recipeControl6.Location = new System.Drawing.Point(738, 368);
            this.recipeControl6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.recipeControl6.Name = "recipeControl6";
            recipeParam1.HumidityEnalbe = false;
            recipeParam1.HumidityHight = 0F;
            recipeParam1.HumidityLow = 0F;
            recipeParam1.TempAlarmEnalbe = false;
            recipeParam1.TempHight = 0F;
            recipeParam1.TempLow = 0F;
            this.recipeControl6.RecipeParam = recipeParam1;
            this.recipeControl6.Size = new System.Drawing.Size(347, 320);
            this.recipeControl6.TabIndex = 5;
            this.recipeControl6.Title = "6#站点";
            // 
            // recipeControl5
            // 
            this.recipeControl5.BackColor = System.Drawing.Color.Transparent;
            this.recipeControl5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.recipeControl5.Location = new System.Drawing.Point(375, 368);
            this.recipeControl5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.recipeControl5.Name = "recipeControl5";
            recipeParam2.HumidityEnalbe = false;
            recipeParam2.HumidityHight = 0F;
            recipeParam2.HumidityLow = 0F;
            recipeParam2.TempAlarmEnalbe = false;
            recipeParam2.TempHight = 0F;
            recipeParam2.TempLow = 0F;
            this.recipeControl5.RecipeParam = recipeParam2;
            this.recipeControl5.Size = new System.Drawing.Size(347, 320);
            this.recipeControl5.TabIndex = 4;
            this.recipeControl5.Title = "5#站点";
            // 
            // recipeControl4
            // 
            this.recipeControl4.BackColor = System.Drawing.Color.Transparent;
            this.recipeControl4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.recipeControl4.Location = new System.Drawing.Point(12, 368);
            this.recipeControl4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.recipeControl4.Name = "recipeControl4";
            recipeParam3.HumidityEnalbe = false;
            recipeParam3.HumidityHight = 0F;
            recipeParam3.HumidityLow = 0F;
            recipeParam3.TempAlarmEnalbe = false;
            recipeParam3.TempHight = 0F;
            recipeParam3.TempLow = 0F;
            this.recipeControl4.RecipeParam = recipeParam3;
            this.recipeControl4.Size = new System.Drawing.Size(347, 320);
            this.recipeControl4.TabIndex = 3;
            this.recipeControl4.Title = "4#站点";
            // 
            // recipeControl3
            // 
            this.recipeControl3.BackColor = System.Drawing.Color.Transparent;
            this.recipeControl3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.recipeControl3.Location = new System.Drawing.Point(738, 26);
            this.recipeControl3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.recipeControl3.Name = "recipeControl3";
            recipeParam4.HumidityEnalbe = false;
            recipeParam4.HumidityHight = 0F;
            recipeParam4.HumidityLow = 0F;
            recipeParam4.TempAlarmEnalbe = false;
            recipeParam4.TempHight = 0F;
            recipeParam4.TempLow = 0F;
            this.recipeControl3.RecipeParam = recipeParam4;
            this.recipeControl3.Size = new System.Drawing.Size(347, 320);
            this.recipeControl3.TabIndex = 2;
            this.recipeControl3.Title = "3#站点";
            // 
            // recipeControl2
            // 
            this.recipeControl2.BackColor = System.Drawing.Color.Transparent;
            this.recipeControl2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.recipeControl2.Location = new System.Drawing.Point(375, 26);
            this.recipeControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.recipeControl2.Name = "recipeControl2";
            recipeParam5.HumidityEnalbe = false;
            recipeParam5.HumidityHight = 0F;
            recipeParam5.HumidityLow = 0F;
            recipeParam5.TempAlarmEnalbe = false;
            recipeParam5.TempHight = 0F;
            recipeParam5.TempLow = 0F;
            this.recipeControl2.RecipeParam = recipeParam5;
            this.recipeControl2.Size = new System.Drawing.Size(347, 320);
            this.recipeControl2.TabIndex = 1;
            this.recipeControl2.Title = "2#站点";
            // 
            // recipeControl1
            // 
            this.recipeControl1.BackColor = System.Drawing.Color.Transparent;
            this.recipeControl1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.recipeControl1.Location = new System.Drawing.Point(12, 26);
            this.recipeControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.recipeControl1.Name = "recipeControl1";
            recipeParam6.HumidityEnalbe = false;
            recipeParam6.HumidityHight = 0F;
            recipeParam6.HumidityLow = 0F;
            recipeParam6.TempAlarmEnalbe = false;
            recipeParam6.TempHight = 0F;
            recipeParam6.TempLow = 0F;
            this.recipeControl1.RecipeParam = recipeParam6;
            this.recipeControl1.Size = new System.Drawing.Size(347, 320);
            this.recipeControl1.TabIndex = 0;
            this.recipeControl1.Title = "1#站点";
            // 
            // FrmRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 720);
            this.Controls.Add(this.panelEnhanced1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmRecipe";
            this.Text = "配方管理";
            this.panelEnhanced1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Main)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlLib.PanelEnhanced panelEnhanced1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgv_Main;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start;
        private System.Windows.Forms.TextBox txt_RecipeInfoName;
        private System.Windows.Forms.Label lbl_CurrentRecipeInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.Button btn_Delete;
        private ControlLib.RecipeControl recipeControl6;
        private ControlLib.RecipeControl recipeControl5;
        private ControlLib.RecipeControl recipeControl4;
        private ControlLib.RecipeControl recipeControl3;
        private ControlLib.RecipeControl recipeControl2;
        private ControlLib.RecipeControl recipeControl1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除配方ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 应用配方ToolStripMenuItem;
    }
}