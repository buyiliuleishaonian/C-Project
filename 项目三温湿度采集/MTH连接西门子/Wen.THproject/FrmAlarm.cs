using MiniExcelLibs;
using MTHModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thinger.DataConvertLib;
using Wen.Common;
using Wen.MTHBLL;

namespace Wen.THproject
{
    /// <summary>
    /// 报警追溯窗体
    /// </summary>
    public partial class FrmAlarm : Form
    {
        public SysLogBLL sysLogBLL = new SysLogBLL();
        public FrmAlarm()
        {
            InitializeComponent();
            //初始化窗体
            //1、不让DataGridView自动生成列
            //2、让ComboBox添加数据源
            //3、让ComboBox默认选中第一项
            //4、让StartTime和EndTime默认为当前时间的前两小时和当前时间
            this.dgv_Main.AutoGenerateColumns = false;
            this.cmb_AlarmType.DataSource=new string[] { "全部", "触发", "解除" };
            this.cmb_AlarmType.SelectedIndex = 0;
            this.dtp_StartTime.Text=DateTime.Now.AddHours(-2).ToString();
            this.dtp_EndTime.Text = DateTime.Now.ToString();
        }

        /// <summary>
        /// 通过时间来查询报警信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SelectTime_Click(object sender, EventArgs e)
        {
            string start = this.dtp_StartTime.Text;
            string end = this.dtp_EndTime.Text;
            string type = this.cmb_AlarmType.Text=="全部"?"":this.cmb_AlarmType.Text;
            //才用多线程查询
            //第二个多线程来更新DataGridView的数据源
            Task<OperateResult<DataTable>> task1 = Task.Run(() =>
            {
                return QueryAlarm(start, end, type);
            });
            Task task2 = task1.ContinueWith(task => 
            {
                this.Invoke(new Action(() => 
                {
                    if (task1.Result.IsSuccess)
                    {
                        this.dgv_Main.DataSource=null;
                        this.dgv_Main.DataSource=task1.Result.Content;
                    }
                    else
                    {
                        new FrmMsgBoxWithoutAck("查询报警信息失败"+task1.Result.Message, "查询报警信息");
                        return;
                    }
                }));
            });
        }

        /// <summary>
        /// 显示行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_Main_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewStyle.DgvRowPostPaint(this.dgv_Main, e);
        }

        /// <summary>
        /// 导出Excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SaveExcel_Click(object sender, EventArgs e)
        {
            //打开保存文件夹，设定其默认文件名，窗体名，查询
            //保存文件
            //通过进程process打开文件
            SaveFileDialog saveFileDialog=new SaveFileDialog();
            saveFileDialog.Filter="Excel文件|*.xlsx|所有文件|*.*";
            saveFileDialog.FileName="报警信息"+DateTime.Now.ToString("yyyyMMddhhmmss") ;
            saveFileDialog.Title="保存报警信息";
            saveFileDialog.DefaultExt="xlsx";//个人认为要不要都不重要，因为所存文件的类型设定为Excel
            saveFileDialog.AddExtension=true;
            if (saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                MiniExcel.SaveAs(saveFileDialog.FileName,this.dgv_Main.DataSource);
                //通过进程预览
                if(new FrmMsgBoxWithAck("是否打开报警记录文件？","打开文件").ShowDialog()==DialogResult.OK)
                {
                    Process.Start(saveFileDialog.FileName);
                }   
            }
        }

        //封装一个查询报警信息的方法 返回值是OperationResult<DataTable>类型
        //查询时间不能大于24小时
        /// <summary>
        /// 通过时间和报警类型来查询报警信息    
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        private OperateResult<DataTable> QueryAlarm(string start, string end, string type)
        {
            DateTime startTime = Convert.ToDateTime(start);
            DateTime endTime = Convert.ToDateTime(end);
            //先判断开始时间是否大于结束时间
            if (startTime>endTime)
            {
                return OperateResult.CreateFailResult<DataTable>("开始时间不能大于结束时间");
            }
            //判断时间是否大于24小时
           TimeSpan timeLength = startTime-endTime;
            if (timeLength.TotalDays>1)
            {
                return OperateResult.CreateFailResult<DataTable>("查询时间不能大于24小时");
            }
            DataTable dt = sysLogBLL.SelectAlarm(start, end, type);
            //判断是否查询到数据
            if (dt!=null)
            {
                return OperateResult.CreateSuccessResult<DataTable>(dt);
            }
            else
            {
                return OperateResult.CreateFailResult<DataTable>("没有查询到数据");
            }
        }
    }
}
