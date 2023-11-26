namespace Wen.THproject
{
    partial class FrmMonitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMonitor));
            SeeSharpTools.JY.GUI.StripChartXSeries stripChartXSeries2 = new SeeSharpTools.JY.GUI.StripChartXSeries();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Mainpanel = new Wen.ControlLib.PanelEnhanced();
            this.lst_info = new System.Windows.Forms.ListView();
            this.dateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Info = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.thmControl2 = new Wen.ControlLib.THMControl();
            this.checkBoxEX13 = new Wen.ControlLib.CheckBoxEX();
            this.thmControl1 = new Wen.ControlLib.THMControl();
            this.checkBoxEX14 = new Wen.ControlLib.CheckBoxEX();
            this.thmControl3 = new Wen.ControlLib.THMControl();
            this.checkBoxEX15 = new Wen.ControlLib.CheckBoxEX();
            this.thmControl4 = new Wen.ControlLib.THMControl();
            this.checkBoxEX16 = new Wen.ControlLib.CheckBoxEX();
            this.thmControl5 = new Wen.ControlLib.THMControl();
            this.checkBoxEX5 = new Wen.ControlLib.CheckBoxEX();
            this.thmControl6 = new Wen.ControlLib.THMControl();
            this.check_box7 = new Wen.ControlLib.CheckBoxEX();
            this.titleControl1 = new Wen.ControlLib.TitleControl();
            this.checkBoxEX7 = new Wen.ControlLib.CheckBoxEX();
            this.titleControl2 = new Wen.ControlLib.TitleControl();
            this.checkBoxEX8 = new Wen.ControlLib.CheckBoxEX();
            this.chart_ActualTrend = new SeeSharpTools.JY.GUI.StripChartX();
            this.checkBoxEX3 = new Wen.ControlLib.CheckBoxEX();
            this.check_Temp1 = new Wen.ControlLib.CheckBoxEX();
            this.checkBoxEX4 = new Wen.ControlLib.CheckBoxEX();
            this.check_Humidity = new Wen.ControlLib.CheckBoxEX();
            this.Mainpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "info.png");
            this.imageList1.Images.SetKeyName(1, "warning.ico");
            this.imageList1.Images.SetKeyName(2, "error.png");
            // 
            // Mainpanel
            // 
            this.Mainpanel.BackgroundImage = global::Wen.THproject.Properties.Resources.BackGround;
            this.Mainpanel.Controls.Add(this.lst_info);
            this.Mainpanel.Controls.Add(this.thmControl2);
            this.Mainpanel.Controls.Add(this.checkBoxEX13);
            this.Mainpanel.Controls.Add(this.thmControl1);
            this.Mainpanel.Controls.Add(this.checkBoxEX14);
            this.Mainpanel.Controls.Add(this.thmControl3);
            this.Mainpanel.Controls.Add(this.checkBoxEX15);
            this.Mainpanel.Controls.Add(this.thmControl4);
            this.Mainpanel.Controls.Add(this.checkBoxEX16);
            this.Mainpanel.Controls.Add(this.thmControl5);
            this.Mainpanel.Controls.Add(this.checkBoxEX5);
            this.Mainpanel.Controls.Add(this.thmControl6);
            this.Mainpanel.Controls.Add(this.check_box7);
            this.Mainpanel.Controls.Add(this.titleControl1);
            this.Mainpanel.Controls.Add(this.checkBoxEX7);
            this.Mainpanel.Controls.Add(this.titleControl2);
            this.Mainpanel.Controls.Add(this.checkBoxEX8);
            this.Mainpanel.Controls.Add(this.chart_ActualTrend);
            this.Mainpanel.Controls.Add(this.checkBoxEX3);
            this.Mainpanel.Controls.Add(this.check_Temp1);
            this.Mainpanel.Controls.Add(this.checkBoxEX4);
            this.Mainpanel.Controls.Add(this.check_Humidity);
            this.Mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mainpanel.Location = new System.Drawing.Point(0, 0);
            this.Mainpanel.Name = "Mainpanel";
            this.Mainpanel.Size = new System.Drawing.Size(1420, 720);
            this.Mainpanel.TabIndex = 22;
            // 
            // lst_info
            // 
            this.lst_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.lst_info.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dateTime,
            this.Info});
            this.lst_info.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.lst_info.ForeColor = System.Drawing.Color.White;
            this.lst_info.FullRowSelect = true;
            this.lst_info.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lst_info.HideSelection = false;
            this.lst_info.Location = new System.Drawing.Point(764, 535);
            this.lst_info.Name = "lst_info";
            this.lst_info.ShowItemToolTips = true;
            this.lst_info.Size = new System.Drawing.Size(602, 181);
            this.lst_info.SmallImageList = this.imageList1;
            this.lst_info.TabIndex = 21;
            this.lst_info.UseCompatibleStateImageBehavior = false;
            this.lst_info.View = System.Windows.Forms.View.Details;
            // 
            // dateTime
            // 
            this.dateTime.Text = "时间";
            this.dateTime.Width = 300;
            // 
            // Info
            // 
            this.Info.Text = "日志内容";
            this.Info.Width = 400;
            // 
            // thmControl2
            // 
            this.thmControl2.AlarmColor = false;
            this.thmControl2.BackColor = System.Drawing.Color.Transparent;
            this.thmControl2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.thmControl2.Humidity = null;
            this.thmControl2.HumidityValueName = "模块2湿度";
            this.thmControl2.Location = new System.Drawing.Point(373, 0);
            this.thmControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.thmControl2.Name = "thmControl2";
            this.thmControl2.Size = new System.Drawing.Size(384, 250);
            this.thmControl2.StateValueName = "模块2异常";
            this.thmControl2.TabIndex = 1;
            this.thmControl2.Temp = null;
            this.thmControl2.TempValueName = "模块2温度";
            this.thmControl2.Title = "2";
            // 
            // checkBoxEX13
            // 
            this.checkBoxEX13.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEX13.CheckBoxColor = System.Drawing.Color.White;
            this.checkBoxEX13.DoubleCheckBoxWidth = 25;
            this.checkBoxEX13.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.checkBoxEX13.ForeColor = System.Drawing.Color.White;
            this.checkBoxEX13.Location = new System.Drawing.Point(1243, 452);
            this.checkBoxEX13.Name = "checkBoxEX13";
            this.checkBoxEX13.Size = new System.Drawing.Size(123, 37);
            this.checkBoxEX13.TabIndex = 20;
            this.checkBoxEX13.Tag = "11";
            this.checkBoxEX13.Text = "6#站地湿度";
            this.checkBoxEX13.TextCheckBox = "复选框文本";
            this.checkBoxEX13.UseVisualStyleBackColor = false;
            this.checkBoxEX13.CheckedChanged += new System.EventHandler(this.CommonCheck_CheckedChanged);
            // 
            // thmControl1
            // 
            this.thmControl1.AlarmColor = false;
            this.thmControl1.BackColor = System.Drawing.Color.Transparent;
            this.thmControl1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.thmControl1.Humidity = null;
            this.thmControl1.HumidityValueName = "模块1湿度";
            this.thmControl1.Location = new System.Drawing.Point(-2, 0);
            this.thmControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.thmControl1.Name = "thmControl1";
            this.thmControl1.Size = new System.Drawing.Size(384, 250);
            this.thmControl1.StateValueName = "模块1异常";
            this.thmControl1.TabIndex = 0;
            this.thmControl1.Temp = null;
            this.thmControl1.TempValueName = "模块1温度";
            this.thmControl1.Title = "1";
            // 
            // checkBoxEX14
            // 
            this.checkBoxEX14.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEX14.CheckBoxColor = System.Drawing.Color.White;
            this.checkBoxEX14.DoubleCheckBoxWidth = 25;
            this.checkBoxEX14.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.checkBoxEX14.ForeColor = System.Drawing.Color.White;
            this.checkBoxEX14.Location = new System.Drawing.Point(1086, 452);
            this.checkBoxEX14.Name = "checkBoxEX14";
            this.checkBoxEX14.Size = new System.Drawing.Size(123, 37);
            this.checkBoxEX14.TabIndex = 19;
            this.checkBoxEX14.Tag = "10";
            this.checkBoxEX14.Text = "6#站点温度";
            this.checkBoxEX14.TextCheckBox = "复选框文本";
            this.checkBoxEX14.UseVisualStyleBackColor = false;
            this.checkBoxEX14.CheckedChanged += new System.EventHandler(this.CommonCheck_CheckedChanged);
            // 
            // thmControl3
            // 
            this.thmControl3.AlarmColor = false;
            this.thmControl3.BackColor = System.Drawing.Color.Transparent;
            this.thmControl3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.thmControl3.Humidity = null;
            this.thmControl3.HumidityValueName = "模块3湿度";
            this.thmControl3.Location = new System.Drawing.Point(-2, 245);
            this.thmControl3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.thmControl3.Name = "thmControl3";
            this.thmControl3.Size = new System.Drawing.Size(384, 239);
            this.thmControl3.StateValueName = "模块3异常";
            this.thmControl3.TabIndex = 2;
            this.thmControl3.Temp = null;
            this.thmControl3.TempValueName = "模块3温度";
            this.thmControl3.Title = "3";
            // 
            // checkBoxEX15
            // 
            this.checkBoxEX15.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEX15.CheckBoxColor = System.Drawing.Color.White;
            this.checkBoxEX15.DoubleCheckBoxWidth = 25;
            this.checkBoxEX15.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.checkBoxEX15.ForeColor = System.Drawing.Color.White;
            this.checkBoxEX15.Location = new System.Drawing.Point(929, 452);
            this.checkBoxEX15.Name = "checkBoxEX15";
            this.checkBoxEX15.Size = new System.Drawing.Size(123, 37);
            this.checkBoxEX15.TabIndex = 18;
            this.checkBoxEX15.Tag = "9";
            this.checkBoxEX15.Text = "5#站点湿度";
            this.checkBoxEX15.TextCheckBox = "复选框文本";
            this.checkBoxEX15.UseVisualStyleBackColor = false;
            this.checkBoxEX15.CheckedChanged += new System.EventHandler(this.CommonCheck_CheckedChanged);
            // 
            // thmControl4
            // 
            this.thmControl4.AlarmColor = false;
            this.thmControl4.BackColor = System.Drawing.Color.Transparent;
            this.thmControl4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.thmControl4.Humidity = null;
            this.thmControl4.HumidityValueName = "模块4湿度";
            this.thmControl4.Location = new System.Drawing.Point(373, 245);
            this.thmControl4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.thmControl4.Name = "thmControl4";
            this.thmControl4.Size = new System.Drawing.Size(384, 250);
            this.thmControl4.StateValueName = "模块4异常";
            this.thmControl4.TabIndex = 3;
            this.thmControl4.Temp = null;
            this.thmControl4.TempValueName = "模块4温度";
            this.thmControl4.Title = "4";
            // 
            // checkBoxEX16
            // 
            this.checkBoxEX16.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEX16.CheckBoxColor = System.Drawing.Color.White;
            this.checkBoxEX16.DoubleCheckBoxWidth = 25;
            this.checkBoxEX16.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.checkBoxEX16.ForeColor = System.Drawing.Color.White;
            this.checkBoxEX16.Location = new System.Drawing.Point(772, 451);
            this.checkBoxEX16.Name = "checkBoxEX16";
            this.checkBoxEX16.Size = new System.Drawing.Size(123, 37);
            this.checkBoxEX16.TabIndex = 17;
            this.checkBoxEX16.Tag = "8";
            this.checkBoxEX16.Text = "5#站点温度";
            this.checkBoxEX16.TextCheckBox = "复选框文本";
            this.checkBoxEX16.UseVisualStyleBackColor = false;
            this.checkBoxEX16.CheckedChanged += new System.EventHandler(this.CommonCheck_CheckedChanged);
            // 
            // thmControl5
            // 
            this.thmControl5.AlarmColor = false;
            this.thmControl5.BackColor = System.Drawing.Color.Transparent;
            this.thmControl5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.thmControl5.Humidity = null;
            this.thmControl5.HumidityValueName = "模块5湿度";
            this.thmControl5.Location = new System.Drawing.Point(-2, 475);
            this.thmControl5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.thmControl5.Name = "thmControl5";
            this.thmControl5.Size = new System.Drawing.Size(384, 250);
            this.thmControl5.StateValueName = "模块5异常";
            this.thmControl5.TabIndex = 4;
            this.thmControl5.Temp = null;
            this.thmControl5.TempValueName = "模块5温度";
            this.thmControl5.Title = "5";
            // 
            // checkBoxEX5
            // 
            this.checkBoxEX5.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEX5.CheckBoxColor = System.Drawing.Color.White;
            this.checkBoxEX5.DoubleCheckBoxWidth = 25;
            this.checkBoxEX5.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.checkBoxEX5.ForeColor = System.Drawing.Color.White;
            this.checkBoxEX5.Location = new System.Drawing.Point(1243, 400);
            this.checkBoxEX5.Name = "checkBoxEX5";
            this.checkBoxEX5.Size = new System.Drawing.Size(123, 37);
            this.checkBoxEX5.TabIndex = 16;
            this.checkBoxEX5.Tag = "7";
            this.checkBoxEX5.Text = "4#站点湿度";
            this.checkBoxEX5.TextCheckBox = "复选框文本";
            this.checkBoxEX5.UseVisualStyleBackColor = false;
            this.checkBoxEX5.CheckedChanged += new System.EventHandler(this.CommonCheck_CheckedChanged);
            // 
            // thmControl6
            // 
            this.thmControl6.AlarmColor = false;
            this.thmControl6.BackColor = System.Drawing.Color.Transparent;
            this.thmControl6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.thmControl6.Humidity = null;
            this.thmControl6.HumidityValueName = "模块6湿度";
            this.thmControl6.Location = new System.Drawing.Point(373, 475);
            this.thmControl6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.thmControl6.Name = "thmControl6";
            this.thmControl6.Size = new System.Drawing.Size(384, 250);
            this.thmControl6.StateValueName = "模块6异常";
            this.thmControl6.TabIndex = 5;
            this.thmControl6.Temp = null;
            this.thmControl6.TempValueName = "模块6温度";
            this.thmControl6.Title = "6";
            // 
            // check_box7
            // 
            this.check_box7.BackColor = System.Drawing.Color.Transparent;
            this.check_box7.CheckBoxColor = System.Drawing.Color.White;
            this.check_box7.DoubleCheckBoxWidth = 25;
            this.check_box7.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.check_box7.ForeColor = System.Drawing.Color.White;
            this.check_box7.Location = new System.Drawing.Point(1086, 400);
            this.check_box7.Name = "check_box7";
            this.check_box7.Size = new System.Drawing.Size(123, 37);
            this.check_box7.TabIndex = 15;
            this.check_box7.Tag = "6";
            this.check_box7.Text = "4#站点温度";
            this.check_box7.TextCheckBox = "复选框文本";
            this.check_box7.UseVisualStyleBackColor = false;
            this.check_box7.CheckedChanged += new System.EventHandler(this.CommonCheck_CheckedChanged);
            // 
            // titleControl1
            // 
            this.titleControl1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.titleControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("titleControl1.BackgroundImage")));
            this.titleControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.titleControl1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.titleControl1.Location = new System.Drawing.Point(733, 12);
            this.titleControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.titleControl1.Name = "titleControl1";
            this.titleControl1.Size = new System.Drawing.Size(109, 31);
            this.titleControl1.TabIndex = 6;
            this.titleControl1.TitleName = "实时趋势";
            // 
            // checkBoxEX7
            // 
            this.checkBoxEX7.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEX7.CheckBoxColor = System.Drawing.Color.White;
            this.checkBoxEX7.DoubleCheckBoxWidth = 25;
            this.checkBoxEX7.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.checkBoxEX7.ForeColor = System.Drawing.Color.White;
            this.checkBoxEX7.Location = new System.Drawing.Point(929, 400);
            this.checkBoxEX7.Name = "checkBoxEX7";
            this.checkBoxEX7.Size = new System.Drawing.Size(123, 37);
            this.checkBoxEX7.TabIndex = 14;
            this.checkBoxEX7.Tag = "5";
            this.checkBoxEX7.Text = "3#站点湿度";
            this.checkBoxEX7.TextCheckBox = "复选框文本";
            this.checkBoxEX7.UseVisualStyleBackColor = false;
            this.checkBoxEX7.CheckedChanged += new System.EventHandler(this.CommonCheck_CheckedChanged);
            // 
            // titleControl2
            // 
            this.titleControl2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.titleControl2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("titleControl2.BackgroundImage")));
            this.titleControl2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.titleControl2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.titleControl2.Location = new System.Drawing.Point(733, 496);
            this.titleControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.titleControl2.Name = "titleControl2";
            this.titleControl2.Size = new System.Drawing.Size(109, 31);
            this.titleControl2.TabIndex = 7;
            this.titleControl2.TitleName = "系统日志";
            // 
            // checkBoxEX8
            // 
            this.checkBoxEX8.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEX8.CheckBoxColor = System.Drawing.Color.White;
            this.checkBoxEX8.DoubleCheckBoxWidth = 25;
            this.checkBoxEX8.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.checkBoxEX8.ForeColor = System.Drawing.Color.White;
            this.checkBoxEX8.Location = new System.Drawing.Point(772, 404);
            this.checkBoxEX8.Name = "checkBoxEX8";
            this.checkBoxEX8.Size = new System.Drawing.Size(123, 37);
            this.checkBoxEX8.TabIndex = 13;
            this.checkBoxEX8.Tag = "4";
            this.checkBoxEX8.Text = "3#站点温度";
            this.checkBoxEX8.TextCheckBox = "复选框文本";
            this.checkBoxEX8.UseVisualStyleBackColor = false;
            this.checkBoxEX8.CheckedChanged += new System.EventHandler(this.CommonCheck_CheckedChanged);
            // 
            // chart_ActualTrend
            // 
            this.chart_ActualTrend.AxisX.AutoScale = false;
            this.chart_ActualTrend.AxisX.AutoZoomReset = false;
            this.chart_ActualTrend.AxisX.Color = System.Drawing.Color.White;
            this.chart_ActualTrend.AxisX.InitWithScaleView = false;
            this.chart_ActualTrend.AxisX.IsLogarithmic = false;
            this.chart_ActualTrend.AxisX.LabelAngle = 0;
            this.chart_ActualTrend.AxisX.LabelEnabled = true;
            this.chart_ActualTrend.AxisX.LabelFormat = null;
            this.chart_ActualTrend.AxisX.MajorGridColor = System.Drawing.Color.White;
            this.chart_ActualTrend.AxisX.MajorGridCount = 6;
            this.chart_ActualTrend.AxisX.MajorGridEnabled = true;
            this.chart_ActualTrend.AxisX.MajorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.Dash;
            this.chart_ActualTrend.AxisX.Maximum = 1000D;
            this.chart_ActualTrend.AxisX.Minimum = 0D;
            this.chart_ActualTrend.AxisX.MinorGridColor = System.Drawing.Color.Black;
            this.chart_ActualTrend.AxisX.MinorGridEnabled = false;
            this.chart_ActualTrend.AxisX.MinorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.DashDot;
            this.chart_ActualTrend.AxisX.TickWidth = 1F;
            this.chart_ActualTrend.AxisX.Title = "";
            this.chart_ActualTrend.AxisX.TitleOrientation = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextOrientation.Auto;
            this.chart_ActualTrend.AxisX.TitlePosition = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextPosition.Center;
            this.chart_ActualTrend.AxisX.ViewMaximum = 1000D;
            this.chart_ActualTrend.AxisX.ViewMinimum = 0D;
            this.chart_ActualTrend.AxisX2.AutoScale = false;
            this.chart_ActualTrend.AxisX2.AutoZoomReset = false;
            this.chart_ActualTrend.AxisX2.Color = System.Drawing.Color.Black;
            this.chart_ActualTrend.AxisX2.InitWithScaleView = false;
            this.chart_ActualTrend.AxisX2.IsLogarithmic = false;
            this.chart_ActualTrend.AxisX2.LabelAngle = 0;
            this.chart_ActualTrend.AxisX2.LabelEnabled = true;
            this.chart_ActualTrend.AxisX2.LabelFormat = null;
            this.chart_ActualTrend.AxisX2.MajorGridColor = System.Drawing.Color.Black;
            this.chart_ActualTrend.AxisX2.MajorGridCount = 6;
            this.chart_ActualTrend.AxisX2.MajorGridEnabled = true;
            this.chart_ActualTrend.AxisX2.MajorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.Dash;
            this.chart_ActualTrend.AxisX2.Maximum = 1000D;
            this.chart_ActualTrend.AxisX2.Minimum = 0D;
            this.chart_ActualTrend.AxisX2.MinorGridColor = System.Drawing.Color.Black;
            this.chart_ActualTrend.AxisX2.MinorGridEnabled = false;
            this.chart_ActualTrend.AxisX2.MinorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.DashDot;
            this.chart_ActualTrend.AxisX2.TickWidth = 1F;
            this.chart_ActualTrend.AxisX2.Title = "";
            this.chart_ActualTrend.AxisX2.TitleOrientation = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextOrientation.Auto;
            this.chart_ActualTrend.AxisX2.TitlePosition = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextPosition.Center;
            this.chart_ActualTrend.AxisX2.ViewMaximum = 1000D;
            this.chart_ActualTrend.AxisX2.ViewMinimum = 0D;
            this.chart_ActualTrend.AxisY.AutoScale = true;
            this.chart_ActualTrend.AxisY.AutoZoomReset = false;
            this.chart_ActualTrend.AxisY.Color = System.Drawing.Color.White;
            this.chart_ActualTrend.AxisY.InitWithScaleView = false;
            this.chart_ActualTrend.AxisY.IsLogarithmic = false;
            this.chart_ActualTrend.AxisY.LabelAngle = 0;
            this.chart_ActualTrend.AxisY.LabelEnabled = true;
            this.chart_ActualTrend.AxisY.LabelFormat = null;
            this.chart_ActualTrend.AxisY.MajorGridColor = System.Drawing.Color.White;
            this.chart_ActualTrend.AxisY.MajorGridCount = 6;
            this.chart_ActualTrend.AxisY.MajorGridEnabled = true;
            this.chart_ActualTrend.AxisY.MajorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.Dash;
            this.chart_ActualTrend.AxisY.Maximum = 3.5D;
            this.chart_ActualTrend.AxisY.Minimum = 0.5D;
            this.chart_ActualTrend.AxisY.MinorGridColor = System.Drawing.Color.Black;
            this.chart_ActualTrend.AxisY.MinorGridEnabled = false;
            this.chart_ActualTrend.AxisY.MinorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.DashDot;
            this.chart_ActualTrend.AxisY.TickWidth = 1F;
            this.chart_ActualTrend.AxisY.Title = "";
            this.chart_ActualTrend.AxisY.TitleOrientation = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextOrientation.Auto;
            this.chart_ActualTrend.AxisY.TitlePosition = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextPosition.Center;
            this.chart_ActualTrend.AxisY.ViewMaximum = 3.5D;
            this.chart_ActualTrend.AxisY.ViewMinimum = 0.5D;
            this.chart_ActualTrend.AxisY2.AutoScale = true;
            this.chart_ActualTrend.AxisY2.AutoZoomReset = false;
            this.chart_ActualTrend.AxisY2.Color = System.Drawing.Color.Black;
            this.chart_ActualTrend.AxisY2.InitWithScaleView = false;
            this.chart_ActualTrend.AxisY2.IsLogarithmic = false;
            this.chart_ActualTrend.AxisY2.LabelAngle = 0;
            this.chart_ActualTrend.AxisY2.LabelEnabled = true;
            this.chart_ActualTrend.AxisY2.LabelFormat = null;
            this.chart_ActualTrend.AxisY2.MajorGridColor = System.Drawing.Color.Black;
            this.chart_ActualTrend.AxisY2.MajorGridCount = 6;
            this.chart_ActualTrend.AxisY2.MajorGridEnabled = true;
            this.chart_ActualTrend.AxisY2.MajorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.Dash;
            this.chart_ActualTrend.AxisY2.Maximum = 3.5D;
            this.chart_ActualTrend.AxisY2.Minimum = 0.5D;
            this.chart_ActualTrend.AxisY2.MinorGridColor = System.Drawing.Color.Black;
            this.chart_ActualTrend.AxisY2.MinorGridEnabled = false;
            this.chart_ActualTrend.AxisY2.MinorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.DashDot;
            this.chart_ActualTrend.AxisY2.TickWidth = 1F;
            this.chart_ActualTrend.AxisY2.Title = "";
            this.chart_ActualTrend.AxisY2.TitleOrientation = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextOrientation.Auto;
            this.chart_ActualTrend.AxisY2.TitlePosition = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextPosition.Center;
            this.chart_ActualTrend.AxisY2.ViewMaximum = 3.5D;
            this.chart_ActualTrend.AxisY2.ViewMinimum = 0.5D;
            this.chart_ActualTrend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.chart_ActualTrend.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.chart_ActualTrend.ChartAreaBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.chart_ActualTrend.Direction = SeeSharpTools.JY.GUI.StripChartX.ScrollDirection.LeftToRight;
            this.chart_ActualTrend.DisplayPoints = 4000;
            this.chart_ActualTrend.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.chart_ActualTrend.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.chart_ActualTrend.GradientStyle = SeeSharpTools.JY.GUI.StripChartX.ChartGradientStyle.None;
            this.chart_ActualTrend.LegendBackColor = System.Drawing.Color.Transparent;
            this.chart_ActualTrend.LegendFont = new System.Drawing.Font("微软雅黑", 11F);
            this.chart_ActualTrend.LegendForeColor = System.Drawing.Color.White;
            this.chart_ActualTrend.LegendVisible = true;
            stripChartXSeries2.Color = System.Drawing.Color.Red;
            stripChartXSeries2.Marker = SeeSharpTools.JY.GUI.StripChartXSeries.MarkerType.None;
            stripChartXSeries2.Name = "1#号站点";
            stripChartXSeries2.Type = SeeSharpTools.JY.GUI.StripChartXSeries.LineType.FastLine;
            stripChartXSeries2.Visible = true;
            stripChartXSeries2.Width = SeeSharpTools.JY.GUI.StripChartXSeries.LineWidth.Thin;
            stripChartXSeries2.XPlotAxis = SeeSharpTools.JY.GUI.StripChartXAxis.PlotAxis.Primary;
            stripChartXSeries2.YPlotAxis = SeeSharpTools.JY.GUI.StripChartXAxis.PlotAxis.Primary;
            this.chart_ActualTrend.LineSeries.Add(stripChartXSeries2);
            this.chart_ActualTrend.Location = new System.Drawing.Point(751, 53);
            this.chart_ActualTrend.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.chart_ActualTrend.Miscellaneous.CheckInfinity = false;
            this.chart_ActualTrend.Miscellaneous.CheckNaN = false;
            this.chart_ActualTrend.Miscellaneous.CheckNegtiveOrZero = false;
            this.chart_ActualTrend.Miscellaneous.DirectionChartCount = 3;
            this.chart_ActualTrend.Miscellaneous.Fitting = SeeSharpTools.JY.GUI.StripChartX.FitType.Range;
            this.chart_ActualTrend.Miscellaneous.MaxSeriesCount = 32;
            this.chart_ActualTrend.Miscellaneous.MaxSeriesPointCount = 4000;
            this.chart_ActualTrend.Miscellaneous.SplitLayoutColumnInterval = 0F;
            this.chart_ActualTrend.Miscellaneous.SplitLayoutDirection = SeeSharpTools.JY.GUI.StripChartXUtility.LayoutDirection.LeftToRight;
            this.chart_ActualTrend.Miscellaneous.SplitLayoutRowInterval = 0F;
            this.chart_ActualTrend.Miscellaneous.SplitViewAutoLayout = true;
            this.chart_ActualTrend.Name = "chart_ActualTrend";
            this.chart_ActualTrend.NextTimeStamp = new System.DateTime(((long)(0)));
            this.chart_ActualTrend.ScrollType = SeeSharpTools.JY.GUI.StripChartX.StripScrollType.Cumulation;
            this.chart_ActualTrend.SeriesCount = 1;
            this.chart_ActualTrend.Size = new System.Drawing.Size(657, 306);
            this.chart_ActualTrend.SplitView = false;
            this.chart_ActualTrend.StartIndex = 0;
            this.chart_ActualTrend.TabIndex = 8;
            this.chart_ActualTrend.TimeInterval = System.TimeSpan.Parse("00:00:00");
            this.chart_ActualTrend.TimeStampFormat = null;
            this.chart_ActualTrend.XCursor.AutoInterval = true;
            this.chart_ActualTrend.XCursor.Color = System.Drawing.Color.DeepSkyBlue;
            this.chart_ActualTrend.XCursor.Interval = 0.001D;
            this.chart_ActualTrend.XCursor.Mode = SeeSharpTools.JY.GUI.StripChartXCursor.CursorMode.Zoom;
            this.chart_ActualTrend.XCursor.SelectionColor = System.Drawing.Color.LightGray;
            this.chart_ActualTrend.XCursor.Value = double.NaN;
            this.chart_ActualTrend.XDataType = SeeSharpTools.JY.GUI.StripChartX.XAxisDataType.Index;
            this.chart_ActualTrend.YCursor.AutoInterval = true;
            this.chart_ActualTrend.YCursor.Color = System.Drawing.Color.DeepSkyBlue;
            this.chart_ActualTrend.YCursor.Interval = 0.001D;
            this.chart_ActualTrend.YCursor.Mode = SeeSharpTools.JY.GUI.StripChartXCursor.CursorMode.Disabled;
            this.chart_ActualTrend.YCursor.SelectionColor = System.Drawing.Color.LightGray;
            this.chart_ActualTrend.YCursor.Value = double.NaN;
            // 
            // checkBoxEX3
            // 
            this.checkBoxEX3.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEX3.CheckBoxColor = System.Drawing.Color.White;
            this.checkBoxEX3.DoubleCheckBoxWidth = 25;
            this.checkBoxEX3.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.checkBoxEX3.ForeColor = System.Drawing.Color.White;
            this.checkBoxEX3.Location = new System.Drawing.Point(1243, 357);
            this.checkBoxEX3.Name = "checkBoxEX3";
            this.checkBoxEX3.Size = new System.Drawing.Size(123, 37);
            this.checkBoxEX3.TabIndex = 12;
            this.checkBoxEX3.Tag = "3";
            this.checkBoxEX3.Text = "2#站点湿度";
            this.checkBoxEX3.TextCheckBox = "复选框文本";
            this.checkBoxEX3.UseVisualStyleBackColor = false;
            this.checkBoxEX3.CheckedChanged += new System.EventHandler(this.CommonCheck_CheckedChanged);
            // 
            // check_Temp1
            // 
            this.check_Temp1.BackColor = System.Drawing.Color.Transparent;
            this.check_Temp1.CheckBoxColor = System.Drawing.Color.White;
            this.check_Temp1.DoubleCheckBoxWidth = 25;
            this.check_Temp1.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.check_Temp1.ForeColor = System.Drawing.Color.White;
            this.check_Temp1.Location = new System.Drawing.Point(772, 357);
            this.check_Temp1.Name = "check_Temp1";
            this.check_Temp1.Size = new System.Drawing.Size(123, 37);
            this.check_Temp1.TabIndex = 9;
            this.check_Temp1.Tag = "0";
            this.check_Temp1.Text = "1#站点温度";
            this.check_Temp1.TextCheckBox = "复选框文本";
            this.check_Temp1.UseVisualStyleBackColor = false;
            this.check_Temp1.CheckedChanged += new System.EventHandler(this.CommonCheck_CheckedChanged);
            // 
            // checkBoxEX4
            // 
            this.checkBoxEX4.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEX4.CheckBoxColor = System.Drawing.Color.White;
            this.checkBoxEX4.DoubleCheckBoxWidth = 25;
            this.checkBoxEX4.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.checkBoxEX4.ForeColor = System.Drawing.Color.White;
            this.checkBoxEX4.Location = new System.Drawing.Point(1086, 357);
            this.checkBoxEX4.Name = "checkBoxEX4";
            this.checkBoxEX4.Size = new System.Drawing.Size(123, 37);
            this.checkBoxEX4.TabIndex = 11;
            this.checkBoxEX4.Tag = "2";
            this.checkBoxEX4.Text = "2#站点温度";
            this.checkBoxEX4.TextCheckBox = "复选框文本";
            this.checkBoxEX4.UseVisualStyleBackColor = false;
            this.checkBoxEX4.CheckedChanged += new System.EventHandler(this.CommonCheck_CheckedChanged);
            // 
            // check_Humidity
            // 
            this.check_Humidity.BackColor = System.Drawing.Color.Transparent;
            this.check_Humidity.CheckBoxColor = System.Drawing.Color.White;
            this.check_Humidity.DoubleCheckBoxWidth = 25;
            this.check_Humidity.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.check_Humidity.ForeColor = System.Drawing.Color.White;
            this.check_Humidity.Location = new System.Drawing.Point(929, 357);
            this.check_Humidity.Name = "check_Humidity";
            this.check_Humidity.Size = new System.Drawing.Size(123, 37);
            this.check_Humidity.TabIndex = 10;
            this.check_Humidity.Tag = "1";
            this.check_Humidity.Text = "1#站点湿度";
            this.check_Humidity.TextCheckBox = "复选框文本";
            this.check_Humidity.UseVisualStyleBackColor = false;
            this.check_Humidity.CheckedChanged += new System.EventHandler(this.CommonCheck_CheckedChanged);
            // 
            // FrmMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 720);
            this.Controls.Add(this.Mainpanel);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMonitor";
            this.Text = "集中控制";
            this.Mainpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlLib.THMControl thmControl1;
        private ControlLib.THMControl thmControl2;
        private ControlLib.THMControl thmControl3;
        private ControlLib.THMControl thmControl4;
        private ControlLib.THMControl thmControl5;
        private ControlLib.THMControl thmControl6;
        private ControlLib.TitleControl titleControl1;
        private ControlLib.TitleControl titleControl2;
        private SeeSharpTools.JY.GUI.StripChartX chart_ActualTrend;
        private ControlLib.CheckBoxEX check_Temp1;
        private ControlLib.CheckBoxEX check_Humidity;
        private ControlLib.CheckBoxEX checkBoxEX3;
        private ControlLib.CheckBoxEX checkBoxEX4;
        private ControlLib.CheckBoxEX checkBoxEX5;
        private ControlLib.CheckBoxEX check_box7;
        private ControlLib.CheckBoxEX checkBoxEX7;
        private ControlLib.CheckBoxEX checkBoxEX8;
        private ControlLib.CheckBoxEX checkBoxEX13;
        private ControlLib.CheckBoxEX checkBoxEX14;
        private ControlLib.CheckBoxEX checkBoxEX15;
        private ControlLib.CheckBoxEX checkBoxEX16;
        private System.Windows.Forms.ListView lst_info;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader dateTime;
        private System.Windows.Forms.ColumnHeader Info;
        private ControlLib.PanelEnhanced Mainpanel;
    }
}