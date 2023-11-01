namespace 代码生成器
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
            this.BtnConSQL = new System.Windows.Forms.Button();
            this.lblDataSource = new System.Windows.Forms.Label();
            this.lblUid = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUid = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.cmbServer = new System.Windows.Forms.ComboBox();
            this.btnModel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.infosname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnConSQL
            // 
            this.BtnConSQL.Location = new System.Drawing.Point(81, 497);
            this.BtnConSQL.Name = "BtnConSQL";
            this.BtnConSQL.Size = new System.Drawing.Size(118, 46);
            this.BtnConSQL.TabIndex = 0;
            this.BtnConSQL.Text = "连接数据库";
            this.BtnConSQL.UseVisualStyleBackColor = true;
            this.BtnConSQL.Click += new System.EventHandler(this.BtnConSQL_Click);
            // 
            // lblDataSource
            // 
            this.lblDataSource.AutoSize = true;
            this.lblDataSource.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDataSource.Location = new System.Drawing.Point(76, 119);
            this.lblDataSource.Name = "lblDataSource";
            this.lblDataSource.Size = new System.Drawing.Size(96, 28);
            this.lblDataSource.TabIndex = 1;
            this.lblDataSource.Text = "服务器";
            // 
            // lblUid
            // 
            this.lblUid.AutoSize = true;
            this.lblUid.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUid.Location = new System.Drawing.Point(76, 201);
            this.lblUid.Name = "lblUid";
            this.lblUid.Size = new System.Drawing.Size(96, 28);
            this.lblUid.TabIndex = 2;
            this.lblUid.Text = "用户名";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPwd.Location = new System.Drawing.Point(76, 281);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(68, 28);
            this.lblPwd.TabIndex = 3;
            this.lblPwd.Text = "密码";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(197, 119);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(246, 25);
            this.txtServer.TabIndex = 4;
            this.txtServer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtServer_KeyDown);
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(197, 281);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(246, 25);
            this.txtPwd.TabIndex = 5;
            this.txtPwd.UseSystemPasswordChar = true;
            this.txtPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPwd_KeyDown);
            // 
            // txtUid
            // 
            this.txtUid.Location = new System.Drawing.Point(197, 204);
            this.txtUid.Name = "txtUid";
            this.txtUid.Size = new System.Drawing.Size(246, 25);
            this.txtUid.TabIndex = 6;
            this.txtUid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUid_KeyDown);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl.Location = new System.Drawing.Point(76, 417);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(96, 28);
            this.lbl.TabIndex = 7;
            this.lbl.Text = "数据库";
            // 
            // cmbServer
            // 
            this.cmbServer.FormattingEnabled = true;
            this.cmbServer.Location = new System.Drawing.Point(197, 417);
            this.cmbServer.Name = "cmbServer";
            this.cmbServer.Size = new System.Drawing.Size(251, 23);
            this.cmbServer.TabIndex = 8;
            this.cmbServer.SelectedValueChanged += new System.EventHandler(this.cmbServer_SelectedValueChanged);
            this.cmbServer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbServer_KeyDown);
            // 
            // btnModel
            // 
            this.btnModel.Location = new System.Drawing.Point(347, 497);
            this.btnModel.Name = "btnModel";
            this.btnModel.Size = new System.Drawing.Size(118, 46);
            this.btnModel.TabIndex = 9;
            this.btnModel.Text = "生成Model";
            this.btnModel.UseVisualStyleBackColor = true;
            this.btnModel.Click += new System.EventHandler(this.btnModel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.infosname});
            this.dataGridView1.Location = new System.Drawing.Point(507, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(755, 307);
            this.dataGridView1.TabIndex = 10;
            // 
            // infosname
            // 
            this.infosname.DataPropertyName = "InfosName";
            this.infosname.HeaderText = "表名";
            this.infosname.MinimumWidth = 6;
            this.infosname.Name = "infosname";
            this.infosname.Width = 125;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 724);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnModel);
            this.Controls.Add(this.cmbServer);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtUid);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblUid);
            this.Controls.Add(this.lblDataSource);
            this.Controls.Add(this.BtnConSQL);
            this.Name = "FrmMain";
            this.Text = "代码生成器";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConSQL;
        private System.Windows.Forms.Label lblDataSource;
        private System.Windows.Forms.Label lblUid;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtPwd;
        public System.Windows.Forms.TextBox txtUid;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.ComboBox cmbServer;
        private System.Windows.Forms.Button btnModel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn infosname;
    }
}

