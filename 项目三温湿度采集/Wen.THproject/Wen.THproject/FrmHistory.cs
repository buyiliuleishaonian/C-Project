using MTHModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thinger.DataConvertLib;
using Wen.ControlLib;
using Wen.MTHBLL;

namespace Wen.THproject
{
    /// <summary>
    /// 历史趋势窗体
    /// </summary>
    public partial class FrmHistory : Form
    {
        public FrmHistory()
        {
            InitializeComponent();
            //初始化窗体的时候，让开始时间低于结束时间两小时
            //让一号站点的CheckBoxEx被选中
            this.dtp_StartTime.Value = DateTime.Now.AddHours(-2.0f);
            this.dtp_EndTime.Value = DateTime.Now;

            this.checkBoxEX1.Checked = true;
            this.checkBoxEX2.Checked = true;
            //
            list.Add(this.checkBoxEX1);
            list.Add(this.checkBoxEX2);
            list.Add(this.checkBoxEX3);
            list.Add(this.checkBoxEX4);
            list.Add(this.checkBoxEX5);
            list.Add(this.checkBoxEX6);
            list.Add(this.checkBoxEX7);
            list.Add(this.checkBoxEX8);
            list.Add(this.checkBoxEX9);
            list.Add(this.checkBoxEX10);
            list.Add(this.checkBoxEX11);
            list.Add(this.checkBoxEX12);
           

            //设置Chart_ActualTreand的图像
            //1、设置x轴的类型
            //2、设置图列,就是显示对应的曲线的名字
            //3、Y轴的范围，设定Y轴不能缩放
            //4、显示多少个点位
            this.chart_HistoryTrend.XDataType= SeeSharpTools.JY.GUI.StripChartX.XAxisDataType.String;
            this.chart_HistoryTrend.LegendVisible=true;
            this.chart_HistoryTrend.DisplayPoints=100000;
            this.chart_HistoryTrend.AxisY.Maximum=100;
            this.chart_HistoryTrend.AxisY.Minimum=0;    
        }

        #region 查询历史数据的配置数据对象
        //创建ActualData对像来查询历史数据
        private ActualData actualData = new ActualData();
        //创建ActualDataDAL来查询历史数据
        private ActualDataBLL actualDataBll = new ActualDataBLL();
        //创建一个字典来存储所查询的列
        private Dictionary<string, string> dic = new Dictionary<string, string>();

        private List<CheckBoxEX> list = new List<CheckBoxEX>();  
        #endregion

        /// <summary>
        /// 时间查询，不仅有时间还有列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_QueryTime_Click(object sender, EventArgs e)
        {
            //得到需要显示的列
            //通过查询的封装方法来得到所查询的历史数据
            //因为要修改Chart_ActualTreand的属性
            //所以需要跨线程访问，需要使用Invoke方法，new Action来调用封装的方法
            string start = this.dtp_StartTime.Text.ToString();
            string end = this.dtp_EndTime.Text.ToString();
            dic = QueryColumns();
            //通过时间和查询列得到所查询的历史数据
            Task<OperateResult<DataTable>> task1 = Task.Run(() =>
            {
                return QueryProcess(start, end);
            });
            Task task2 = task1.ContinueWith(task =>
            {
                this.Invoke(new Action(() =>
                {
                    if (task.Result.IsSuccess)
                    {
                        UpdateChart(task.Result.Content);
                    }
                    else
                    {
                        new FrmMsgBoxWithoutAck("查询出错"+task.Result.Message, "查询历史数据").ShowDialog();
                    }
                }));
            });
        }

        //封装一个列表用于来查询有那些站点的数据，需要在二维图中显示出来
        //需要通过判断CheckBoxEX是否被选中,来判断需要查询的站点
        /// <summary>
        /// 根据选中情况来获取字典集合
        /// </summary>
        /// <returns>返回一个字典集合</returns>
        private Dictionary<string, string> QueryColumns()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            //遍历包含CheckBoxEx的容器，将其对应的变量名，存入到字典中
            //首先需要判断CheckBoxEx的Tag属性是否为空，如果为空，说明没有对应的变量
            //通过CheckBoxEx的Checked属性来判断是否被选中
            //如果被选中，将其对应的Tag属性对应的变量的数据类型存入到字典中
            foreach (var item in this.list)
            {
                if (item.Tag!=null&&item.Tag.ToString().Length>0)
                {
                    if (item.Checked)
                    {
                        dic.Add(item.Tag.ToString(), item.Text);
                    }
                }
            }
            //遍历容器添加的时候，CheckBoxExd的添加顺序是混乱的，所以可以在sql语句中查询的时候进行排列
            return dic;
        }

        /// <summary>
        /// 通过开始时间和结束时间查询历史数据
        /// </summary>
        /// <param name="start">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <returns>返回一个OperateResult的泛型类</returns>
        private OperateResult<DataTable> QueryProcess(string start, string end)
        {
            //因为是全局的字典，所以不需要将其作为参数传入
            //需要判断开始时间大于结束时间
            //需要判断开始时间到结束时间不能超过24小时
            //判断传回来的数据是否为空
            DateTime startTime = Convert.ToDateTime(start);
            DateTime endTime = Convert.ToDateTime(end);
            if (startTime>endTime)
            {
                return OperateResult.CreateFailResult<DataTable>("开始时间不能大于结束时间");
            }
            TimeSpan timeSpan = startTime-endTime;
            if (timeSpan.TotalDays>1)
            {
                return OperateResult.CreateFailResult<DataTable>("查询时间不能大于24小时");
            }
            DataTable dt = actualDataBll.SelectActualData(start, end, dic.Keys.ToList());
            if (dt.Rows.Count>0)
            {
                return OperateResult.CreateSuccessResult<DataTable>(dt);
            }
            else
            {
                return OperateResult.CreateFailResult<DataTable>("没有查询到数据");
            }
        }

        //封装一个修改Chart_ActualTreand的方法
        /// <summary>
        /// 通过传入的DataTable来修改Chart_ActualTreand来绘制曲线
        /// </summary>
        /// <param name="dt"></param>
        private void UpdateChart(DataTable dt)
        {
            //先获取行数和列数，行数是所需要查询的行数，列数是所需要查询的列数
            int rowCounts = dt.Rows.Count;
            int columnCounts = this.dic.Count;

            //需要设定Chart
            //1、将Chart_ActualTreand.clear清空
            //2、设定曲线总数，查询多少的列，就有多少的曲线
            //3、设定曲线的名字,和曲线的宽度
            this.chart_HistoryTrend.Clear();
            this.chart_HistoryTrend.SeriesCount = columnCounts;
            for (int i = 0; i < columnCounts; i++)
            {
                this.chart_HistoryTrend.Series[i].Name = dic.Values.ToList()[i];
                this.chart_HistoryTrend.Series[i].Width = SeeSharpTools.JY.GUI.StripChartXSeries.LineWidth.Middle;
            }

            //解析数据

            //创建二维数组，用于存储数据，x为所要查询列的个数dic.Row,y为查询的行数
            //创建一个等于行数的数组，来存储x轴的数据
            //用二维数组来存储行的数据
            //这里用到for循环嵌套，就是要完成全部曲线的数据对应
            //每完成一次曲线之后，才进入下一个曲线的数据对应
            //需要判断数据是否为空，如果为空，就不需要进行数据对应
            //数据转化失败也是返回null
            //再每次完成曲线的绘制之后，将行的数据进行赋值

            //最后将其传给Chart_HistoryTreand的Plot方法
            double[,] YData=new double[columnCounts,rowCounts];
            string[]  XData=new string[rowCounts];
            for (int i = 0; i < rowCounts; i++)
            {
                for (int j = 0; j <columnCounts; j++)
                {
                    //防止转化失败
                    try
                    {
                        if (dt.Rows[i][j+1]!=null&&dt.Rows[i][j+1].ToString().Length>0)
                        {
                            YData[j, i] = Convert.ToDouble(dt.Rows[i][j+1]);
                        }
                        else
                        {
                            YData[i, j] = 0;
                        }
                    }
                    catch (Exception)
                    {
                        YData[i, j] = 0;
                    }
                }
                XData[i]=Convert.ToDateTime(dt.Rows[i][0]).ToString("HH:mm:ss");
            }
            //先是Y轴的数据，再是X轴的数据
            this.chart_HistoryTrend.Plot(YData,XData);
        }

        
        /// <summary>
        /// 快速查询，就查询最近5个小时的数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_QuickQuery_Click(object sender, EventArgs e)
        {
            //手动设置开始时间和结束时间
            this.dtp_StartTime.Value=DateTime.Now.AddHours(-5.0f);
            this.dtp_EndTime.Value=DateTime.Now;
            //然后调用btn_QueryTime_Click方法
            btn_QueryTime_Click(null, null);
        }

        /// <summary>
        /// 保存图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SaveIMAGE_Click(object sender, EventArgs e)
        {
            //选择一个保存的文件夹
            //保存的方法，是Chart控件自己本身的方法
            //通过process打开文件
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "图片文件|*.png|所有文件|*.*";
            saveFileDialog.Title="保存历史数据图片";
            saveFileDialog.FileName="历史数据图片"+DateTime.Now.ToString("yyyyMMddhhmmss");
            saveFileDialog.DefaultExt="png";
            saveFileDialog.AddExtension=true;
            if (saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                this.chart_HistoryTrend.SaveAsImage(saveFileDialog.FileName);
                if (new FrmMsgBoxWithAck("是否打开图片？", "打开图片").ShowDialog()==DialogResult.OK)
                {
                    System.Diagnostics.Process.Start(saveFileDialog.FileName);
                }
            }
        }

        /// <summary>
        /// 保存CSV文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ExportCSV_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "图片文件|*.CSV|所有文件|*.*";
            saveFileDialog.Title="保存历史数据图片";
            saveFileDialog.FileName="历史数据图片"+DateTime.Now.ToString("yyyyMMddhhmmss");
            saveFileDialog.DefaultExt="CSV";
            saveFileDialog.AddExtension=true;
            if (saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                this.chart_HistoryTrend.SaveAsCsv(saveFileDialog.FileName);
                if (new FrmMsgBoxWithAck("是否打开图片？", "打开图片").ShowDialog()==DialogResult.OK)
                {
                    System.Diagnostics.Process.Start(saveFileDialog.FileName);
                }
            }

        }
    }
}
