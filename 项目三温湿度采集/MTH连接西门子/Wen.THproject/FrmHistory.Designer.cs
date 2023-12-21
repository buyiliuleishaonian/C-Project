namespace Wen.THproject
{
    partial class FrmHistory
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
            SeeSharpTools.JY.GUI.StripChartXSeries stripChartXSeries2 = new SeeSharpTools.JY.GUI.StripChartXSeries();
            this.panelEnhanced1 = new Wen.ControlLib.PanelEnhanced();
            this.dtp_StartTime = new System.Windows.Forms.DateTimePicker();
            this.chart_HistoryTrend = new SeeSharpTools.JY.GUI.StripChartX();
            this.panel_Params = new System.Windows.Forms.Panel();
            this.checkBoxEX1 = new Wen.ControlLib.CheckBoxEX();
            this.checkBoxEX2 = new Wen.ControlLib.CheckBoxEX();
            this.btn_ExportCSV = new System.Windows.Forms.Button();
            this.btn_SaveIMAGE = new System.Windows.Forms.Button();
            this.btn_QuickQuery = new System.Windows.Forms.Button();
            this.btn_QueryTime = new System.Windows.Forms.Button();
            this.dtp_EndTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxEX3 = new Wen.ControlLib.CheckBoxEX();
            this.checkBoxEX4 = new Wen.ControlLib.CheckBoxEX();
            this.checkBoxEX5 = new Wen.ControlLib.CheckBoxEX();
            this.checkBoxEX6 = new Wen.ControlLib.CheckBoxEX();
            this.checkBoxEX7 = new Wen.ControlLib.CheckBoxEX();
            this.checkBoxEX8 = new Wen.ControlLib.CheckBoxEX();
            this.checkBoxEX9 = new Wen.ControlLib.CheckBoxEX();
            this.checkBoxEX10 = new Wen.ControlLib.CheckBoxEX();
            this.checkBoxEX11 = new Wen.ControlLib.CheckBoxEX();
            this.checkBoxEX12 = new Wen.ControlLib.CheckBoxEX();
            this.panelEnhanced1.SuspendLayout();
            this.panel_Params.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEnhanced1
            // 
            this.panelEnhanced1.BackgroundImage = global::Wen.THproject.Properties.Resources.BackGround;
            this.panelEnhanced1.Controls.Add(this.dtp_StartTime);
            this.panelEnhanced1.Controls.Add(this.chart_HistoryTrend);
            this.panelEnhanced1.Controls.Add(this.panel_Params);
            this.panelEnhanced1.Controls.Add(this.btn_ExportCSV);
            this.panelEnhanced1.Controls.Add(this.btn_SaveIMAGE);
            this.panelEnhanced1.Controls.Add(this.btn_QuickQuery);
            this.panelEnhanced1.Controls.Add(this.btn_QueryTime);
            this.panelEnhanced1.Controls.Add(this.dtp_EndTime);
            this.panelEnhanced1.Controls.Add(this.label2);
            this.panelEnhanced1.Controls.Add(this.label1);
            this.panelEnhanced1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEnhanced1.Location = new System.Drawing.Point(0, 0);
            this.panelEnhanced1.Name = "panelEnhanced1";
            this.panelEnhanced1.Size = new System.Drawing.Size(1420, 720);
            this.panelEnhanced1.TabIndex = 0;
            // 
            // dtp_StartTime
            // 
            this.dtp_StartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtp_StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_StartTime.Location = new System.Drawing.Point(844, 74);
            this.dtp_StartTime.Name = "dtp_StartTime";
            this.dtp_StartTime.Size = new System.Drawing.Size(200, 26);
            this.dtp_StartTime.TabIndex = 23;
            // 
            // chart_HistoryTrend
            // 
            this.chart_HistoryTrend.AxisX.AutoScale = false;
            this.chart_HistoryTrend.AxisX.AutoZoomReset = false;
            this.chart_HistoryTrend.AxisX.Color = System.Drawing.Color.White;
            this.chart_HistoryTrend.AxisX.InitWithScaleView = false;
            this.chart_HistoryTrend.AxisX.IsLogarithmic = false;
            this.chart_HistoryTrend.AxisX.LabelAngle = 0;
            this.chart_HistoryTrend.AxisX.LabelEnabled = true;
            this.chart_HistoryTrend.AxisX.LabelFormat = null;
            this.chart_HistoryTrend.AxisX.MajorGridColor = System.Drawing.Color.White;
            this.chart_HistoryTrend.AxisX.MajorGridCount = 6;
            this.chart_HistoryTrend.AxisX.MajorGridEnabled = true;
            this.chart_HistoryTrend.AxisX.MajorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.Dash;
            this.chart_HistoryTrend.AxisX.Maximum = 1000D;
            this.chart_HistoryTrend.AxisX.Minimum = 0D;
            this.chart_HistoryTrend.AxisX.MinorGridColor = System.Drawing.Color.Black;
            this.chart_HistoryTrend.AxisX.MinorGridEnabled = false;
            this.chart_HistoryTrend.AxisX.MinorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.DashDot;
            this.chart_HistoryTrend.AxisX.TickWidth = 1F;
            this.chart_HistoryTrend.AxisX.Title = "";
            this.chart_HistoryTrend.AxisX.TitleOrientation = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextOrientation.Auto;
            this.chart_HistoryTrend.AxisX.TitlePosition = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextPosition.Center;
            this.chart_HistoryTrend.AxisX.ViewMaximum = 1000D;
            this.chart_HistoryTrend.AxisX.ViewMinimum = 0D;
            this.chart_HistoryTrend.AxisX2.AutoScale = false;
            this.chart_HistoryTrend.AxisX2.AutoZoomReset = false;
            this.chart_HistoryTrend.AxisX2.Color = System.Drawing.Color.Black;
            this.chart_HistoryTrend.AxisX2.InitWithScaleView = false;
            this.chart_HistoryTrend.AxisX2.IsLogarithmic = false;
            this.chart_HistoryTrend.AxisX2.LabelAngle = 0;
            this.chart_HistoryTrend.AxisX2.LabelEnabled = true;
            this.chart_HistoryTrend.AxisX2.LabelFormat = null;
            this.chart_HistoryTrend.AxisX2.MajorGridColor = System.Drawing.Color.Black;
            this.chart_HistoryTrend.AxisX2.MajorGridCount = 6;
            this.chart_HistoryTrend.AxisX2.MajorGridEnabled = true;
            this.chart_HistoryTrend.AxisX2.MajorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.Dash;
            this.chart_HistoryTrend.AxisX2.Maximum = 1000D;
            this.chart_HistoryTrend.AxisX2.Minimum = 0D;
            this.chart_HistoryTrend.AxisX2.MinorGridColor = System.Drawing.Color.Black;
            this.chart_HistoryTrend.AxisX2.MinorGridEnabled = false;
            this.chart_HistoryTrend.AxisX2.MinorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.DashDot;
            this.chart_HistoryTrend.AxisX2.TickWidth = 1F;
            this.chart_HistoryTrend.AxisX2.Title = "";
            this.chart_HistoryTrend.AxisX2.TitleOrientation = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextOrientation.Auto;
            this.chart_HistoryTrend.AxisX2.TitlePosition = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextPosition.Center;
            this.chart_HistoryTrend.AxisX2.ViewMaximum = 1000D;
            this.chart_HistoryTrend.AxisX2.ViewMinimum = 0D;
            this.chart_HistoryTrend.AxisY.AutoScale = true;
            this.chart_HistoryTrend.AxisY.AutoZoomReset = false;
            this.chart_HistoryTrend.AxisY.Color = System.Drawing.Color.White;
            this.chart_HistoryTrend.AxisY.InitWithScaleView = false;
            this.chart_HistoryTrend.AxisY.IsLogarithmic = false;
            this.chart_HistoryTrend.AxisY.LabelAngle = 0;
            this.chart_HistoryTrend.AxisY.LabelEnabled = true;
            this.chart_HistoryTrend.AxisY.LabelFormat = null;
            this.chart_HistoryTrend.AxisY.MajorGridColor = System.Drawing.Color.White;
            this.chart_HistoryTrend.AxisY.MajorGridCount = 6;
            this.chart_HistoryTrend.AxisY.MajorGridEnabled = true;
            this.chart_HistoryTrend.AxisY.MajorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.Dash;
            this.chart_HistoryTrend.AxisY.Maximum = 3.5D;
            this.chart_HistoryTrend.AxisY.Minimum = 0.5D;
            this.chart_HistoryTrend.AxisY.MinorGridColor = System.Drawing.Color.Black;
            this.chart_HistoryTrend.AxisY.MinorGridEnabled = false;
            this.chart_HistoryTrend.AxisY.MinorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.DashDot;
            this.chart_HistoryTrend.AxisY.TickWidth = 1F;
            this.chart_HistoryTrend.AxisY.Title = "";
            this.chart_HistoryTrend.AxisY.TitleOrientation = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextOrientation.Auto;
            this.chart_HistoryTrend.AxisY.TitlePosition = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextPosition.Center;
            this.chart_HistoryTrend.AxisY.ViewMaximum = 3.5D;
            this.chart_HistoryTrend.AxisY.ViewMinimum = 0.5D;
            this.chart_HistoryTrend.AxisY2.AutoScale = true;
            this.chart_HistoryTrend.AxisY2.AutoZoomReset = false;
            this.chart_HistoryTrend.AxisY2.Color = System.Drawing.Color.Black;
            this.chart_HistoryTrend.AxisY2.InitWithScaleView = false;
            this.chart_HistoryTrend.AxisY2.IsLogarithmic = false;
            this.chart_HistoryTrend.AxisY2.LabelAngle = 0;
            this.chart_HistoryTrend.AxisY2.LabelEnabled = true;
            this.chart_HistoryTrend.AxisY2.LabelFormat = null;
            this.chart_HistoryTrend.AxisY2.MajorGridColor = System.Drawing.Color.Black;
            this.chart_HistoryTrend.AxisY2.MajorGridCount = 6;
            this.chart_HistoryTrend.AxisY2.MajorGridEnabled = true;
            this.chart_HistoryTrend.AxisY2.MajorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.Dash;
            this.chart_HistoryTrend.AxisY2.Maximum = 3.5D;
            this.chart_HistoryTrend.AxisY2.Minimum = 0.5D;
            this.chart_HistoryTrend.AxisY2.MinorGridColor = System.Drawing.Color.Black;
            this.chart_HistoryTrend.AxisY2.MinorGridEnabled = false;
            this.chart_HistoryTrend.AxisY2.MinorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.DashDot;
            this.chart_HistoryTrend.AxisY2.TickWidth = 1F;
            this.chart_HistoryTrend.AxisY2.Title = "";
            this.chart_HistoryTrend.AxisY2.TitleOrientation = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextOrientation.Auto;
            this.chart_HistoryTrend.AxisY2.TitlePosition = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextPosition.Center;
            this.chart_HistoryTrend.AxisY2.ViewMaximum = 3.5D;
            this.chart_HistoryTrend.AxisY2.ViewMinimum = 0.5D;
            this.chart_HistoryTrend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.chart_HistoryTrend.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.chart_HistoryTrend.ChartAreaBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.chart_HistoryTrend.Direction = SeeSharpTools.JY.GUI.StripChartX.ScrollDirection.LeftToRight;
            this.chart_HistoryTrend.DisplayPoints = 4000;
            this.chart_HistoryTrend.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.chart_HistoryTrend.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.chart_HistoryTrend.GradientStyle = SeeSharpTools.JY.GUI.StripChartX.ChartGradientStyle.None;
            this.chart_HistoryTrend.LegendBackColor = System.Drawing.Color.Transparent;
            this.chart_HistoryTrend.LegendFont = new System.Drawing.Font("微软雅黑", 11F);
            this.chart_HistoryTrend.LegendForeColor = System.Drawing.Color.White;
            this.chart_HistoryTrend.LegendVisible = true;
            stripChartXSeries2.Color = System.Drawing.Color.Red;
            stripChartXSeries2.Marker = SeeSharpTools.JY.GUI.StripChartXSeries.MarkerType.None;
            stripChartXSeries2.Name = "1#号站点";
            stripChartXSeries2.Type = SeeSharpTools.JY.GUI.StripChartXSeries.LineType.FastLine;
            stripChartXSeries2.Visible = true;
            stripChartXSeries2.Width = SeeSharpTools.JY.GUI.StripChartXSeries.LineWidth.Thin;
            stripChartXSeries2.XPlotAxis = SeeSharpTools.JY.GUI.StripChartXAxis.PlotAxis.Primary;
            stripChartXSeries2.YPlotAxis = SeeSharpTools.JY.GUI.StripChartXAxis.PlotAxis.Primary;
            this.chart_HistoryTrend.LineSeries.Add(stripChartXSeries2);
            this.chart_HistoryTrend.Location = new System.Drawing.Point(79, 240);
            this.chart_HistoryTrend.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.chart_HistoryTrend.Miscellaneous.CheckInfinity = false;
            this.chart_HistoryTrend.Miscellaneous.CheckNaN = false;
            this.chart_HistoryTrend.Miscellaneous.CheckNegtiveOrZero = false;
            this.chart_HistoryTrend.Miscellaneous.DirectionChartCount = 3;
            this.chart_HistoryTrend.Miscellaneous.Fitting = SeeSharpTools.JY.GUI.StripChartX.FitType.Range;
            this.chart_HistoryTrend.Miscellaneous.MaxSeriesCount = 32;
            this.chart_HistoryTrend.Miscellaneous.MaxSeriesPointCount = 4000;
            this.chart_HistoryTrend.Miscellaneous.SplitLayoutColumnInterval = 0F;
            this.chart_HistoryTrend.Miscellaneous.SplitLayoutDirection = SeeSharpTools.JY.GUI.StripChartXUtility.LayoutDirection.LeftToRight;
            this.chart_HistoryTrend.Miscellaneous.SplitLayoutRowInterval = 0F;
            this.chart_HistoryTrend.Miscellaneous.SplitViewAutoLayout = true;
            this.chart_HistoryTrend.Name = "chart_HistoryTrend";
            this.chart_HistoryTrend.NextTimeStamp = new System.DateTime(((long)(0)));
            this.chart_HistoryTrend.ScrollType = SeeSharpTools.JY.GUI.StripChartX.StripScrollType.Cumulation;
            this.chart_HistoryTrend.SeriesCount = 1;
            this.chart_HistoryTrend.Size = new System.Drawing.Size(1228, 455);
            this.chart_HistoryTrend.SplitView = false;
            this.chart_HistoryTrend.StartIndex = 0;
            this.chart_HistoryTrend.TabIndex = 22;
            this.chart_HistoryTrend.TimeInterval = System.TimeSpan.Parse("00:00:00");
            this.chart_HistoryTrend.TimeStampFormat = null;
            this.chart_HistoryTrend.XCursor.AutoInterval = true;
            this.chart_HistoryTrend.XCursor.Color = System.Drawing.Color.DeepSkyBlue;
            this.chart_HistoryTrend.XCursor.Interval = 0.001D;
            this.chart_HistoryTrend.XCursor.Mode = SeeSharpTools.JY.GUI.StripChartXCursor.CursorMode.Zoom;
            this.chart_HistoryTrend.XCursor.SelectionColor = System.Drawing.Color.LightGray;
            this.chart_HistoryTrend.XCursor.Value = double.NaN;
            this.chart_HistoryTrend.XDataType = SeeSharpTools.JY.GUI.StripChartX.XAxisDataType.String;
            this.chart_HistoryTrend.YCursor.AutoInterval = true;
            this.chart_HistoryTrend.YCursor.Color = System.Drawing.Color.DeepSkyBlue;
            this.chart_HistoryTrend.YCursor.Interval = 0.001D;
            this.chart_HistoryTrend.YCursor.Mode = SeeSharpTools.JY.GUI.StripChartXCursor.CursorMode.Disabled;
            this.chart_HistoryTrend.YCursor.SelectionColor = System.Drawing.Color.LightGray;
            this.chart_HistoryTrend.YCursor.Value = double.NaN;
            // 
            // panel_Params
            // 
            this.panel_Params.BackColor = System.Drawing.Color.Transparent;
            this.panel_Params.Controls.Add(this.checkBoxEX11);
            this.panel_Params.Controls.Add(this.checkBoxEX12);
            this.panel_Params.Controls.Add(this.checkBoxEX9);
            this.panel_Params.Controls.Add(this.checkBoxEX10);
            this.panel_Params.Controls.Add(this.checkBoxEX7);
            this.panel_Params.Controls.Add(this.checkBoxEX8);
            this.panel_Params.Controls.Add(this.checkBoxEX5);
            this.panel_Params.Controls.Add(this.checkBoxEX6);
            this.panel_Params.Controls.Add(this.checkBoxEX3);
            this.panel_Params.Controls.Add(this.checkBoxEX4);
            this.panel_Params.Controls.Add(this.checkBoxEX1);
            this.panel_Params.Controls.Add(this.checkBoxEX2);
            this.panel_Params.Location = new System.Drawing.Point(3, 12);
            this.panel_Params.Name = "panel_Params";
            this.panel_Params.Size = new System.Drawing.Size(691, 220);
            this.panel_Params.TabIndex = 21;
            // 
            // checkBoxEX1
            // 
            this.checkBoxEX1.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEX1.CheckBoxColor = System.Drawing.Color.White;
            this.checkBoxEX1.DoubleCheckBoxWidth = 30;
            this.checkBoxEX1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.checkBoxEX1.ForeColor = System.Drawing.Color.White;
            this.checkBoxEX1.Location = new System.Drawing.Point(19, 29);
            this.checkBoxEX1.Name = "checkBoxEX1";
            this.checkBoxEX1.Size = new System.Drawing.Size(137, 35);
            this.checkBoxEX1.TabIndex = 0;
            this.checkBoxEX1.Tag = "Station1Temp";
            this.checkBoxEX1.Text = "1#站点温度";
            this.checkBoxEX1.TextCheckBox = "复选框文本";
            this.checkBoxEX1.UseVisualStyleBackColor = false;
            // 
            // checkBoxEX2
            // 
            this.checkBoxEX2.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEX2.CheckBoxColor = System.Drawing.Color.White;
            this.checkBoxEX2.DoubleCheckBoxWidth = 30;
            this.checkBoxEX2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.checkBoxEX2.ForeColor = System.Drawing.Color.White;
            this.checkBoxEX2.Location = new System.Drawing.Point(189, 29);
            this.checkBoxEX2.Name = "checkBoxEX2";
            this.checkBoxEX2.Size = new System.Drawing.Size(137, 35);
            this.checkBoxEX2.TabIndex = 1;
            this.checkBoxEX2.Tag = "Station1Humidity";
            this.checkBoxEX2.Text = "1#站点湿度";
            this.checkBoxEX2.TextCheckBox = "复选框文本";
            this.checkBoxEX2.UseVisualStyleBackColor = false;
            // 
            // btn_ExportCSV
            // 
            this.btn_ExportCSV.BackColor = System.Drawing.Color.Transparent;
            this.btn_ExportCSV.FlatAppearance.BorderSize = 2;
            this.btn_ExportCSV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ExportCSV.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.btn_ExportCSV.ForeColor = System.Drawing.Color.Transparent;
            this.btn_ExportCSV.Location = new System.Drawing.Point(1159, 150);
            this.btn_ExportCSV.Name = "btn_ExportCSV";
            this.btn_ExportCSV.Size = new System.Drawing.Size(124, 31);
            this.btn_ExportCSV.TabIndex = 19;
            this.btn_ExportCSV.Text = "导出CSV";
            this.btn_ExportCSV.UseVisualStyleBackColor = false;
            this.btn_ExportCSV.Click += new System.EventHandler(this.btn_ExportCSV_Click);
            // 
            // btn_SaveIMAGE
            // 
            this.btn_SaveIMAGE.BackColor = System.Drawing.Color.Transparent;
            this.btn_SaveIMAGE.FlatAppearance.BorderSize = 2;
            this.btn_SaveIMAGE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SaveIMAGE.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.btn_SaveIMAGE.ForeColor = System.Drawing.Color.Transparent;
            this.btn_SaveIMAGE.Location = new System.Drawing.Point(1010, 150);
            this.btn_SaveIMAGE.Name = "btn_SaveIMAGE";
            this.btn_SaveIMAGE.Size = new System.Drawing.Size(124, 31);
            this.btn_SaveIMAGE.TabIndex = 18;
            this.btn_SaveIMAGE.Text = "保存IMAGE";
            this.btn_SaveIMAGE.UseVisualStyleBackColor = false;
            this.btn_SaveIMAGE.Click += new System.EventHandler(this.btn_SaveIMAGE_Click);
            // 
            // btn_QuickQuery
            // 
            this.btn_QuickQuery.BackColor = System.Drawing.Color.Transparent;
            this.btn_QuickQuery.FlatAppearance.BorderSize = 2;
            this.btn_QuickQuery.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_QuickQuery.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.btn_QuickQuery.ForeColor = System.Drawing.Color.Transparent;
            this.btn_QuickQuery.Location = new System.Drawing.Point(861, 150);
            this.btn_QuickQuery.Name = "btn_QuickQuery";
            this.btn_QuickQuery.Size = new System.Drawing.Size(124, 31);
            this.btn_QuickQuery.TabIndex = 17;
            this.btn_QuickQuery.Text = "快速查询";
            this.btn_QuickQuery.UseVisualStyleBackColor = false;
            this.btn_QuickQuery.Click += new System.EventHandler(this.btn_QuickQuery_Click);
            // 
            // btn_QueryTime
            // 
            this.btn_QueryTime.BackColor = System.Drawing.Color.Transparent;
            this.btn_QueryTime.FlatAppearance.BorderSize = 2;
            this.btn_QueryTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_QueryTime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.btn_QueryTime.ForeColor = System.Drawing.Color.Transparent;
            this.btn_QueryTime.Location = new System.Drawing.Point(712, 150);
            this.btn_QueryTime.Name = "btn_QueryTime";
            this.btn_QueryTime.Size = new System.Drawing.Size(124, 31);
            this.btn_QueryTime.TabIndex = 16;
            this.btn_QueryTime.Text = "时间查询";
            this.btn_QueryTime.UseVisualStyleBackColor = false;
            this.btn_QueryTime.Click += new System.EventHandler(this.btn_QueryTime_Click);
            // 
            // dtp_EndTime
            // 
            this.dtp_EndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtp_EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_EndTime.Location = new System.Drawing.Point(1160, 74);
            this.dtp_EndTime.Name = "dtp_EndTime";
            this.dtp_EndTime.Size = new System.Drawing.Size(200, 26);
            this.dtp_EndTime.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1065, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "结束时间：";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(747, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "开始时间：";
            // 
            // checkBoxEX3
            // 
            this.checkBoxEX3.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEX3.CheckBoxColor = System.Drawing.Color.White;
            this.checkBoxEX3.DoubleCheckBoxWidth = 30;
            this.checkBoxEX3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.checkBoxEX3.ForeColor = System.Drawing.Color.White;
            this.checkBoxEX3.Location = new System.Drawing.Point(350, 29);
            this.checkBoxEX3.Name = "checkBoxEX3";
            this.checkBoxEX3.Size = new System.Drawing.Size(137, 35);
            this.checkBoxEX3.TabIndex = 2;
            this.checkBoxEX3.Tag = "Station2Temp";
            this.checkBoxEX3.Text = "2#站点温度";
            this.checkBoxEX3.TextCheckBox = "复选框文本";
            this.checkBoxEX3.UseVisualStyleBackColor = false;
            // 
            // checkBoxEX4
            // 
            this.checkBoxEX4.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEX4.CheckBoxColor = System.Drawing.Color.White;
            this.checkBoxEX4.DoubleCheckBoxWidth = 30;
            this.checkBoxEX4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.checkBoxEX4.ForeColor = System.Drawing.Color.White;
            this.checkBoxEX4.Location = new System.Drawing.Point(520, 29);
            this.checkBoxEX4.Name = "checkBoxEX4";
            this.checkBoxEX4.Size = new System.Drawing.Size(137, 35);
            this.checkBoxEX4.TabIndex = 3;
            this.checkBoxEX4.Tag = "Station2Humidity";
            this.checkBoxEX4.Text = "2#站点湿度";
            this.checkBoxEX4.TextCheckBox = "复选框文本";
            this.checkBoxEX4.UseVisualStyleBackColor = false;
            // 
            // checkBoxEX5
            // 
            this.checkBoxEX5.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEX5.CheckBoxColor = System.Drawing.Color.White;
            this.checkBoxEX5.DoubleCheckBoxWidth = 30;
            this.checkBoxEX5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.checkBoxEX5.ForeColor = System.Drawing.Color.White;
            this.checkBoxEX5.Location = new System.Drawing.Point(19, 91);
            this.checkBoxEX5.Name = "checkBoxEX5";
            this.checkBoxEX5.Size = new System.Drawing.Size(137, 35);
            this.checkBoxEX5.TabIndex = 4;
            this.checkBoxEX5.Tag = "Station3Temp";
            this.checkBoxEX5.Text = "3#站点温度";
            this.checkBoxEX5.TextCheckBox = "复选框文本";
            this.checkBoxEX5.UseVisualStyleBackColor = false;
            // 
            // checkBoxEX6
            // 
            this.checkBoxEX6.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEX6.CheckBoxColor = System.Drawing.Color.White;
            this.checkBoxEX6.DoubleCheckBoxWidth = 30;
            this.checkBoxEX6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.checkBoxEX6.ForeColor = System.Drawing.Color.White;
            this.checkBoxEX6.Location = new System.Drawing.Point(189, 91);
            this.checkBoxEX6.Name = "checkBoxEX6";
            this.checkBoxEX6.Size = new System.Drawing.Size(137, 35);
            this.checkBoxEX6.TabIndex = 5;
            this.checkBoxEX6.Tag = "Station3Humidity";
            this.checkBoxEX6.Text = "3#站点湿度";
            this.checkBoxEX6.TextCheckBox = "复选框文本";
            this.checkBoxEX6.UseVisualStyleBackColor = false;
            // 
            // checkBoxEX7
            // 
            this.checkBoxEX7.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEX7.CheckBoxColor = System.Drawing.Color.White;
            this.checkBoxEX7.DoubleCheckBoxWidth = 30;
            this.checkBoxEX7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.checkBoxEX7.ForeColor = System.Drawing.Color.White;
            this.checkBoxEX7.Location = new System.Drawing.Point(350, 91);
            this.checkBoxEX7.Name = "checkBoxEX7";
            this.checkBoxEX7.Size = new System.Drawing.Size(137, 35);
            this.checkBoxEX7.TabIndex = 6;
            this.checkBoxEX7.Tag = "Station4Temp";
            this.checkBoxEX7.Text = "4#站点温度";
            this.checkBoxEX7.TextCheckBox = "复选框文本";
            this.checkBoxEX7.UseVisualStyleBackColor = false;
            // 
            // checkBoxEX8
            // 
            this.checkBoxEX8.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEX8.CheckBoxColor = System.Drawing.Color.White;
            this.checkBoxEX8.DoubleCheckBoxWidth = 30;
            this.checkBoxEX8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.checkBoxEX8.ForeColor = System.Drawing.Color.White;
            this.checkBoxEX8.Location = new System.Drawing.Point(520, 91);
            this.checkBoxEX8.Name = "checkBoxEX8";
            this.checkBoxEX8.Size = new System.Drawing.Size(137, 35);
            this.checkBoxEX8.TabIndex = 7;
            this.checkBoxEX8.Tag = "Station4Humidity";
            this.checkBoxEX8.Text = "4#站点湿度";
            this.checkBoxEX8.TextCheckBox = "复选框文本";
            this.checkBoxEX8.UseVisualStyleBackColor = false;
            // 
            // checkBoxEX9
            // 
            this.checkBoxEX9.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEX9.CheckBoxColor = System.Drawing.Color.White;
            this.checkBoxEX9.DoubleCheckBoxWidth = 30;
            this.checkBoxEX9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.checkBoxEX9.ForeColor = System.Drawing.Color.White;
            this.checkBoxEX9.Location = new System.Drawing.Point(19, 151);
            this.checkBoxEX9.Name = "checkBoxEX9";
            this.checkBoxEX9.Size = new System.Drawing.Size(137, 35);
            this.checkBoxEX9.TabIndex = 8;
            this.checkBoxEX9.Tag = "Station5Temp";
            this.checkBoxEX9.Text = "5#站点温度";
            this.checkBoxEX9.TextCheckBox = "复选框文本";
            this.checkBoxEX9.UseVisualStyleBackColor = false;
            // 
            // checkBoxEX10
            // 
            this.checkBoxEX10.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEX10.CheckBoxColor = System.Drawing.Color.White;
            this.checkBoxEX10.DoubleCheckBoxWidth = 30;
            this.checkBoxEX10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.checkBoxEX10.ForeColor = System.Drawing.Color.White;
            this.checkBoxEX10.Location = new System.Drawing.Point(189, 151);
            this.checkBoxEX10.Name = "checkBoxEX10";
            this.checkBoxEX10.Size = new System.Drawing.Size(137, 35);
            this.checkBoxEX10.TabIndex = 9;
            this.checkBoxEX10.Tag = "Station5Humidity";
            this.checkBoxEX10.Text = "5#站点湿度";
            this.checkBoxEX10.TextCheckBox = "复选框文本";
            this.checkBoxEX10.UseVisualStyleBackColor = false;
            // 
            // checkBoxEX11
            // 
            this.checkBoxEX11.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEX11.CheckBoxColor = System.Drawing.Color.White;
            this.checkBoxEX11.DoubleCheckBoxWidth = 30;
            this.checkBoxEX11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.checkBoxEX11.ForeColor = System.Drawing.Color.White;
            this.checkBoxEX11.Location = new System.Drawing.Point(350, 151);
            this.checkBoxEX11.Name = "checkBoxEX11";
            this.checkBoxEX11.Size = new System.Drawing.Size(137, 35);
            this.checkBoxEX11.TabIndex = 10;
            this.checkBoxEX11.Tag = "Station6Temp";
            this.checkBoxEX11.Text = "6#站点温度";
            this.checkBoxEX11.TextCheckBox = "复选框文本";
            this.checkBoxEX11.UseVisualStyleBackColor = false;
            // 
            // checkBoxEX12
            // 
            this.checkBoxEX12.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEX12.CheckBoxColor = System.Drawing.Color.White;
            this.checkBoxEX12.DoubleCheckBoxWidth = 30;
            this.checkBoxEX12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.checkBoxEX12.ForeColor = System.Drawing.Color.White;
            this.checkBoxEX12.Location = new System.Drawing.Point(520, 151);
            this.checkBoxEX12.Name = "checkBoxEX12";
            this.checkBoxEX12.Size = new System.Drawing.Size(137, 35);
            this.checkBoxEX12.TabIndex = 11;
            this.checkBoxEX12.Tag = "Station6Humidity";
            this.checkBoxEX12.Text = "6#站点湿度";
            this.checkBoxEX12.TextCheckBox = "复选框文本";
            this.checkBoxEX12.UseVisualStyleBackColor = false;
            // 
            // FrmHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 720);
            this.Controls.Add(this.panelEnhanced1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmHistory";
            this.Text = "历史趋势";
            this.panelEnhanced1.ResumeLayout(false);
            this.panel_Params.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlLib.PanelEnhanced panelEnhanced1;
        private ControlLib.CheckBoxEX checkBoxEX1;
        private ControlLib.CheckBoxEX checkBoxEX2;
        private System.Windows.Forms.DateTimePicker dtp_EndTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_QueryTime;
        private System.Windows.Forms.Button btn_SaveIMAGE;
        private System.Windows.Forms.Button btn_QuickQuery;
        private System.Windows.Forms.Button btn_ExportCSV;
        private System.Windows.Forms.Panel panel_Params;
        private SeeSharpTools.JY.GUI.StripChartX chart_HistoryTrend;
        private System.Windows.Forms.DateTimePicker dtp_StartTime;
        private ControlLib.CheckBoxEX checkBoxEX11;
        private ControlLib.CheckBoxEX checkBoxEX12;
        private ControlLib.CheckBoxEX checkBoxEX9;
        private ControlLib.CheckBoxEX checkBoxEX10;
        private ControlLib.CheckBoxEX checkBoxEX7;
        private ControlLib.CheckBoxEX checkBoxEX8;
        private ControlLib.CheckBoxEX checkBoxEX5;
        private ControlLib.CheckBoxEX checkBoxEX6;
        private ControlLib.CheckBoxEX checkBoxEX3;
        private ControlLib.CheckBoxEX checkBoxEX4;
    }
}