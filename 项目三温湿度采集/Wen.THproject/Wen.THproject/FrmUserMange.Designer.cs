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
            this.btn_UserMange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_UserMange
            // 
            this.btn_UserMange.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_UserMange.Location = new System.Drawing.Point(523, 356);
            this.btn_UserMange.Name = "btn_UserMange";
            this.btn_UserMange.Size = new System.Drawing.Size(262, 130);
            this.btn_UserMange.TabIndex = 0;
            this.btn_UserMange.Text = "用户管理";
            this.btn_UserMange.UseVisualStyleBackColor = true;
            // 
            // FrmUserMange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 720);
            this.Controls.Add(this.btn_UserMange);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmUserMange";
            this.Text = "用户管理";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_UserMange;
    }
}