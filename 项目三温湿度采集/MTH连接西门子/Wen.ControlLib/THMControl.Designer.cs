namespace Wen.ControlLib
{
    partial class THMControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl_Temp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Humidity = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dialPlate1 = new Wen.ControlLib.DialPlate();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(186)))), ((int)(((byte)(196)))));
            this.lbl_Title.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Title.Location = new System.Drawing.Point(3, 1);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(95, 32);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "1#号站点";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.lbl1.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            this.lbl1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl1.Location = new System.Drawing.Point(2, 205);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(66, 25);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "温度：";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Temp
            // 
            this.lbl_Temp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.lbl_Temp.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            this.lbl_Temp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(186)))), ((int)(((byte)(196)))));
            this.lbl_Temp.Location = new System.Drawing.Point(64, 205);
            this.lbl_Temp.Name = "lbl_Temp";
            this.lbl_Temp.Size = new System.Drawing.Size(66, 25);
            this.lbl_Temp.TabIndex = 3;
            this.lbl_Temp.Text = "0.0";
            this.lbl_Temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.label1.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(186)))), ((int)(((byte)(196)))));
            this.label1.Location = new System.Drawing.Point(146, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "℃";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.label2.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(186)))), ((int)(((byte)(196)))));
            this.label2.Location = new System.Drawing.Point(342, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "%";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Humidity
            // 
            this.lbl_Humidity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.lbl_Humidity.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            this.lbl_Humidity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(186)))), ((int)(((byte)(196)))));
            this.lbl_Humidity.Location = new System.Drawing.Point(260, 205);
            this.lbl_Humidity.Name = "lbl_Humidity";
            this.lbl_Humidity.Size = new System.Drawing.Size(66, 25);
            this.lbl_Humidity.TabIndex = 6;
            this.lbl_Humidity.Text = "0.0";
            this.lbl_Humidity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.label4.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(198, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "湿度:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dialPlate1
            // 
            this.dialPlate1.AlarmAngel = 120F;
            this.dialPlate1.AlarmColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(184)))), ((int)(((byte)(196)))));
            this.dialPlate1.BackColor = System.Drawing.Color.Transparent;
            this.dialPlate1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dialPlate1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dialPlate1.HumidityColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(184)))), ((int)(((byte)(196)))));
            this.dialPlate1.HumidityScale = 0.35F;
            this.dialPlate1.HumidityValue = 0F;
            this.dialPlate1.InThickness = 16;
            this.dialPlate1.Location = new System.Drawing.Point(42, 38);
            this.dialPlate1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dialPlate1.Name = "dialPlate1";
            this.dialPlate1.OutThickness = 8;
            this.dialPlate1.RangeMax = 90F;
            this.dialPlate1.RangeMin = 0F;
            this.dialPlate1.RingColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.dialPlate1.Size = new System.Drawing.Size(291, 162);
            this.dialPlate1.TabIndex = 0;
            this.dialPlate1.TempColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(184)))), ((int)(((byte)(196)))));
            this.dialPlate1.TempScale = 0.6F;
            this.dialPlate1.TempValue = 0F;
            this.dialPlate1.TextScale = 0.85F;
            // 
            // THMControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Humidity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Temp);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.dialPlate1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "THMControl";
            this.Size = new System.Drawing.Size(384, 250);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DialPlate dialPlate1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl_Temp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Humidity;
        private System.Windows.Forms.Label label4;
    }
}
