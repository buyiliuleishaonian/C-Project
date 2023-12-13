using IniHelperDemo;
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
using Wen.ControlLib;

namespace Wen.THproject
{
    /// <summary>
    /// 配置参数窗体
    /// </summary>
    public partial class FrmParams : Form
    {
        public FrmParams(string path)
        {
            InitializeComponent();
            this.decPath=path;

            //读取FrmMain中读取的CommonModel.Decive
            InitParams();

            //设定定时器初始化
            this.updateTimer.Interval = 500;
            this.updateTimer.Enabled=true;
            this.updateTimer.Tick+=UpdateTimer_Tick;
            this.updateTimer.Start();

            this.FormClosing+=(sender, e) =>
            {
                this.updateTimer.Stop();
            };

            //让textset，checkboxEX控件绑定事件
            CommonEvent();
        }

        //创建好路径变量，接受主窗体传过来的路径
        private string decPath = string.Empty;

        //编写一个窗体启动就读取到Decive中的IP和端口号
        /// <summary>
        /// 初始化参数，获取到全局的配置CommodModel的Decive
        /// </summary>
        private void InitParams()
        {
            if (CommonModel.Decive!=null)
            {
                this.txt_IP.Text=CommonModel.Decive.IPAddRess;
                this.txt_Port.Text=CommonModel.Decive.Port.ToString();
                //第一次显示窗体也需要显示Params数据
                GetLimitParams();

                GetAlarmParams();
            }
        }

        /// <summary>
        /// 显示通信组数据窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_GroupConfig_Click(object sender, EventArgs e)
        {
            FrmGroupConfig frm = new FrmGroupConfig();
            DialogResult dr = frm.ShowDialog();
        }

        /// <summary>
        /// 显示通信组窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            FrmVariableConfig frm = new FrmVariableConfig();
            DialogResult dr = frm.ShowDialog();
        }

        /// <summary>
        /// 确认/修改IP地址或端口号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Sure_Click(object sender, EventArgs e)
        {
            //确认ip，端口号，判断通信设置参数是否成功
            bool result = IniConfigHelper.WriteIniData("设备参数", "IP地址", this.txt_IP.Text.Trim(), this.decPath);
            result&=IniConfigHelper.WriteIniData("设备参数", "端口号", this.txt_Port.Text.Trim(), this.decPath);
            if (result)
            {
                //更新之后，连接,将ip，端口号传给全局的Decive
                //因为多线程一直在循环进行，只需要让标志位为IsConnected为False就可以
                CommonModel.Decive.IPAddRess=this.txt_IP.Text.Trim();
                CommonModel.Decive.Port=Convert.ToInt32(this.txt_Port.Text.Trim());

                DialogResult dr = new FrmMsgBoxWithAck("是否重连新的IP地址", "重新").ShowDialog();
                if (dr==DialogResult.OK)
                {
                    //标志位置为false
                    CommonModel.Decive.IsConnected=false;
                }
            }
            else
            {
                new FrmMsgBoxWithoutAck("修改配置参数失败", "操作配置参数").ShowDialog();
            }
        }

        /// <summary>
        /// 还原成原来的值,就是设置的全局的Decive，直接将全局的值，返回回来
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.txt_IP.Text=CommonModel.Decive.IPAddRess;
            this.txt_Port.Text=CommonModel.Decive.Port.ToString();
        }


        #region 显示读取，各模块的温湿度极限值，以及是否报警
        public Timer updateTimer = new Timer();

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            //更新我的限制
            GetLimitParams();
        }
        //封装一个限制
        /// <summary>
        /// 实时读取限制参数
        /// </summary>
        private void GetLimitParams()
        {
            if (CommonModel.Decive.IsConnected)
            {
                //遍历mainpanel容器中所有的TextSet控件
                //判断绑定变量名不可以为空（模块的高低限变量）
                //然后通过CommonModel.Decive的来进行数值的读取
                //同理绑定（模块温湿度高），模块报警异常
                foreach (var item in PanelMain.Controls.OfType<TextSet>())
                {
                    if (item.BindVarName!=null&&item.BindVarName.ToString().Trim().Length>0)
                    {
                        item.CurrentValue=CommonModel.Decive[item.BindVarName].ToString();
                    }
                    if (item.AlarmVarName!=null&&item.AlarmVarName.ToString().Trim().Length>0)
                    {
                        item.IsAlarm=string.Equals(CommonModel.Decive[item.AlarmVarName].ToString(), "True");
                    }
                }
            }

        }
        /// <summary>
        /// 实时读取启用状态数据
        /// </summary>
        private void GetAlarmParams()
        {
            if (CommonModel.Decive.IsConnected)
            {
                //遍历mainpanel容器中所有的CheckBoxEX控件
                //判断是否启用那个报警控件
                foreach (var item in PanelMain.Controls.OfType<CheckBoxEX>())
                {
                    if (item.Tag!=null&&item.Tag.ToString().Trim().Length>0)
                    {
                        item.Checked=string.Equals(CommonModel.Decive[item.Tag.ToString()].ToString(), "1");
                    }
                }
            }
        }

        #endregion


        /// <summary>
        /// TestSet通用参数修改方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommonTextSet_ControlDoubleClick(object sender, EventArgs e)
        {
            //这里通过弹窗的方式修改
            if (sender is TextSet var)
            {
                if (var.BindVarName!=null&&var.BindVarName.ToString().Trim().Length>0)
                {
                    string titleName = var.TitleName;
                    string bindName = var.BindVarName;
                    string value = var.CurrentValue;
                    FrmModify frm = new FrmModify(titleName, bindName, value);
                    frm.ShowDialog();
                }
            }
        }

        /// <summary>
        /// CheckBoxEX通用的修改方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommonCheckBoxEX_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBoxEX check)
            {
                if (check.Tag!=null&&check.Tag.ToString().Trim().Length>0)
                {
                    bool result = CommonModel.CommonWrite(check.Tag.ToString(), check.Checked ? "1" : "0");
                    if (result==false)
                    {
                        check.CheckedChanged-=CommonCheckBoxEX_CheckedChanged;
                        check.Checked=!check.Checked;
                        check.CheckedChanged+=CommonCheckBoxEX_CheckedChanged;
                    }
                }
            }
        }

        /// <summary>
        /// 通用事件绑定的方法，通过遍历控件来绑定事件
        /// </summary>
        private void CommonEvent()
        {
            //首先绑定TextSet的事件
            //再绑定CheckBoxEX的事件
            //都需要判断是否是满足要求的控件
            foreach (var item in PanelMain.Controls.OfType<TextSet>())
            {
                if (item.BindVarName.Length>0)
                {
                    item.ControlDoubleClick+=CommonTextSet_ControlDoubleClick;
                }
            }
            foreach (var item in PanelMain.Controls.OfType<CheckBoxEX>())
            {
                if (item.Tag!=null)
                {
                    item.CheckedChanged+=CommonCheckBoxEX_CheckedChanged;
                }
            }
        }
    }
}
