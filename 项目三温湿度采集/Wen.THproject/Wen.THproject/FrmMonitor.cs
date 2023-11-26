using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wen.ControlLib;

namespace Wen.THproject
{
    /// <summary>
    /// 集中控制窗体
    /// </summary>
    public partial class FrmMonitor : Form
    {
        public FrmMonitor()
        {
            InitializeComponent();
            //初始化显示曲线
            SetChart();
            this.lst_info.Columns[1].Width=this.lst_info.Width-this.lst_info.Columns[0].Width-25;
            //在构造函数中对这个定时器，初始化
            this.updateTime1.Interval=1000;
            this.updateTime1.Tick+=UpdateTime1_Tick;
            this.updateTime1.Enabled=true;
            this.updateTime1.Start();
            //当窗体关闭前，停止计时
            this.FormClosing+=(send, e) =>
            {
                this.updateTime1.Stop();
            };

        }

        #region 更新显示模块温湿度,实时曲线
        /// <summary>
        /// 每隔1s更新数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateTime1_Tick(object sender, EventArgs e)
        {
            //首先判断连接标志位是否连接
            //遍历MainPanel控件将显示温湿度的控件
            if (CommonModel.Decive.IsConnected)
            {
                foreach (var item in this.Mainpanel.Controls.OfType<THMControl>())
                {
                    //实时显示温湿度的方法
                    UpdateTHMControl(item);                    
                }
                //构建List集合，得到显示模块的温湿度将其赋值给曲线控件 PloatSingle
                List<double> list=new   List<double>();
                for (int i = 1; i <= 6; i++)
                {
                    list.Add(Convert.ToDouble( CommonModel.Decive[$"模块{i}温度"]));
                    list.Add(Convert.ToDouble(CommonModel.Decive[$"模块{i}湿度"]));
                }
                //每次添加12个数据
                this.chart_ActualTrend.PlotSingle(list.ToArray());
            }
        }

        //封装一个修改温湿度控件显示的方法 UpdateTHMControl
        /// <summary>
        /// 通过温湿度控件的属性，显示动画
        /// </summary>
        /// <param name="thm">温湿度控件</param>
        public void UpdateTHMControl(THMControl thm)
        {
            if (CommonModel.Decive[thm.TempValueName]!=null)
            {
                thm.Temp=CommonModel.Decive[thm.TempValueName].ToString();
            }
            if (CommonModel.Decive[thm.HumidityValueName]!=null)
            {
                thm.Humidity=CommonModel.Decive[thm.HumidityValueName].ToString();
            }
            if (CommonModel.Decive[thm.StateValueName]!=null)
            {
                thm.AlarmColor=string.Equals(CommonModel.Decive[thm.StateValueName].ToString(), "True");
            }
        }


        //封装一个显示实时曲线的方法
        public void SetChart()
        {
            //首先得到曲线控件的x轴数据类型  Xdatatype
            this.chart_ActualTrend.XDataType=SeeSharpTools.JY.GUI.StripChartX.XAxisDataType.TimeStamp;
            //设置x轴时间搓的格式为HH:MM:SS  timerstampFormat
            this.chart_ActualTrend.TimeStampFormat="HH:mm:ss";
            //设置图例显示 legendVisible
            this.chart_ActualTrend.LegendVisible=true;
            //设置显示的数据点，显示多少个点 dispalypoint
            this.chart_ActualTrend.DisplayPoints=40000;
            //设置Y轴的范围最大值和最小值 Y.minimum,Y.maximum，不让Y自动显示
            this.chart_ActualTrend.AxisY.Minimum=0.0f;
            this.chart_ActualTrend.AxisY.Maximum=100.0f;
            //清空曲线，手动添加曲线,设置曲线数量
            this.chart_ActualTrend.Series.Clear();
            this.chart_ActualTrend.SeriesCount=12;
           for( int i=0;i<12;i++)
            {
                //设置曲线，设置每个曲线名称，偶数是温度，奇数是湿度
                this.chart_ActualTrend.Series[i].Name=i%2==0 ? $"{i/2+1}#站点温度" : $"{i/2+1}#站点湿度";
                //设置所有曲线不可见(当下面勾选之后显示对应的曲线)，设置曲线的粗细
                this.chart_ActualTrend.Series[i].Visible=false;
                this.chart_ActualTrend.Series[i].Width=SeeSharpTools.JY.GUI.StripChartXSeries.LineWidth.Middle;
                //设置曲线的Y轴
                this.chart_ActualTrend.Series[i].YPlotAxis=SeeSharpTools.JY.GUI.StripChartXAxis.PlotAxis.Primary;
            }
            this.check_Temp1.Checked=true;
            this.check_Humidity.Checked=true;
        }
        #endregion

        #region 实现通用日志更新的方法
        //创建一个返回操作时间的属性CurrentTime
        private string CurrenTime
        {
            get { return DateTime.Now.ToString("yyyy.MM.dd-HH:mm:ss"); }
        }

        /// <summary>
        /// 实现日志记录的通用方法
        /// </summary>
        /// <param name="level"></param>
        /// <param name="log"></param>
        public void AddLog(int level, string log)
        {
            //先要判断日志的级别，这里为0，1，2.限制到0到2
            if (level>2) level=2;
            if (level<0) level=0;
            //首先先要判断是不是多线程访问，
            //因为将这个方法，提供给了全局委托的日志添加
            //所以在其他UI层可能也会使用这个方法，修改这个ui的Lst_info的属性
            if (this.lst_info.InvokeRequired)
            {
                this.lst_info.Invoke(new Action<int, string>(AddLog), level, log);
            }
            else
            {
                ListViewItem listViewItem = new ListViewItem(CurrenTime, level);
                listViewItem.SubItems.Add(log);

                this.lst_info.Items.Add(listViewItem);

                //让最新的日志显示在最下面，并显示出来
                this.lst_info.Items[this.lst_info.Items.Count-1].EnsureVisible();
            }
        }
        #endregion


        //添加一个Windows的窗体的Timer，这个定时器可以直接操作UI层，个人建议用Timers.Timer这个需要跨线程来操作
        public Timer updateTime1 = new Timer();

        /// <summary>
        /// 当checked变化时，对应的曲线也发生变化
        /// 因为CheckBoxEX是继承CheckBox的所以当单击这个控件的时候，checked这个属性就会取反
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommonCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBoxEX checkbox)
            {
                if (checkbox.Tag!=null&&checkbox.Tag.ToString().Trim().Length>0)
                {
                    int index = Convert.ToInt32(checkbox.Tag);
                    this.chart_ActualTrend.Series[index].Visible=checkbox.Checked;
                }
            }
        }
    }
}
