using IniHelperDemo;
using MiniExcelLibs;
using MTHModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using thinger.DataConvertLib;
using Wen.Common;
using Wen.ControlLib;
using Wen.MTHBLL;

namespace Wen.THproject
{
    /// <summary>
    /// 主窗体显示
    /// </summary>
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            //因为在窗体的构建中，使用了三个Panel容器控件，将整个窗体占满了，之后取消窗体的边框
            //绘制窗体之后再无法移动

            //ObservableCollection这个动态集合，包含一个集合数量发生改变会触发一个事件CollectionChanged
            this.actualAlarmList.CollectionChanged+=ActualAlarmList_CollectionChanged;


            this.Load+=FrmMain_Load;

            //初始化System.Timers.Timer对象
            this.timer.Interval=1000;
            this.timer.Elapsed+=this.Timer_Elapsed;
            this.timer.AutoReset=true;//表示是否重复计时

            //将所有的NaviButton控件添加到集合中
            this.listNaviButton.Add(this.naviButton1);
            this.listNaviButton.Add(this.naviButton2);
            this.listNaviButton.Add(this.naviButton3);
            this.listNaviButton.Add(this.naviButton4);
            this.listNaviButton.Add(this.naviButton5);
            this.listNaviButton.Add(this.naviButton6);
        }

        /// <summary>
        /// 系统定时器，每隔一秒钟，触发一次,用来将各个站点的数据写入到数据库中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            //更新当前的时间显示,通信状态
            this.Invoke(new Action(() => 
            {
                this.lbl_CurrentTime.Text=DateTime.Now.ToString("yyyy-MM-dd  HH:mm:ss dddd");
                this.led_CommState.Value=CommonModel.Decive.IsConnected;
            }));
            //判断Decive的ISconnect是否正常
            if (CommonModel.Decive.IsConnected)
            {
                bool result = CommonModel.Decive["模块1温度"]!=null;
                result &= CommonModel.Decive["模块1湿度"]!=null;
                result &=CommonModel.Decive["模块2温度"]!=null;
                result &=CommonModel.Decive["模块2湿度"]!=null;
                result &=CommonModel.Decive["模块3温度"]!=null;
                result &=CommonModel.Decive["模块3湿度"]!=null;
                result &=CommonModel.Decive["模块4温度"]!=null;
                result &=CommonModel.Decive["模块4湿度"]!=null;
                result &=CommonModel.Decive["模块5温度"]!=null;
                result &=CommonModel.Decive["模块5湿度"]!=null;
                result &=CommonModel.Decive["模块6温度"]!=null;
                result &=CommonModel.Decive["模块6湿度"]!=null;
                if (result)
                {
                    string time = CurrentTime;
                     actualDataBll.AddActualData(new ActualData()
                    {
                        InsertTime=time,
                        Station1Temp=CommonModel.Decive["模块1温度"].ToString(),
                        Station1Humidity=CommonModel.Decive["模块1湿度"].ToString(),
                        Station2Temp=CommonModel.Decive["模块2温度"].ToString(),
                        Station2Humidity=CommonModel.Decive["模块2湿度"].ToString(),
                        Station3Temp=CommonModel.Decive["模块3温度"].ToString(),
                        Station3Humidity=CommonModel.Decive["模块3湿度"].ToString(),
                        Station4Temp=CommonModel.Decive["模块4温度"].ToString(),
                        Station4Humidity=CommonModel.Decive["模块4湿度"].ToString(),
                        Station5Temp=CommonModel.Decive["模块5温度"].ToString(),
                        Station5Humidity=CommonModel.Decive["模块5湿度"].ToString(),
                        Station6Temp=CommonModel.Decive["模块6温度"].ToString(),
                        Station6Humidity=CommonModel.Decive["模块6湿度"].ToString(),
                    });
                }
            }
        }

        #region 配置文件
        //创建Decive文件路径
        private string decPath = Application.StartupPath+@"\Decive\decive.ini";
        //创建Group文件路径
        private string groupPath = Application.StartupPath+@"\Group\group.xlsx";
        //创建Excel文件路径
        private string variablePath = Application.StartupPath+@"\Variable\variable.xlsx";

        //可以监视的集合,动态可监视的集合，可以在项目，添加，删除或刷新整个列表的提供通知，
        private ObservableCollection<string> actualAlarmList = new ObservableCollection<string>();

        #endregion

        #region 加载设备信息
        //从Decive文件下，将ip地址和端口号读取出来
        //可能会报错，所以需要添加日志写入
        /// <summary>
        /// 读取文件下的配置文件
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private Decive LoadDevice(string decivePath, string groupPath, string variablePath)
        {
            //也要先判断deciveable文件是否存在
            if (!File.Exists(decivePath))
            {
                CommonModel.AddLog(1, "设备文件不存在");
                return null;
            }
            //解析通信组和通信变量
            //判断通信组和通信变量是存在
            List<Group> groupList = LoadGroup(groupPath, variablePath);
            if (groupPath!=null)
            {
                try
                {
                    return new Decive()
                    {
                        //添加在Deceive文件中的ip地址和端口号
                        IPAddRess=IniConfigHelper.ReadIniData("设备参数", "IP地址", "127.0.0.1", decivePath),
                        Port=Convert.ToInt32(IniConfigHelper.ReadIniData("设备参数", "端口号", "502", decivePath)),
                        //添加配方选项的名字
                        CurrentRecipeInfo=IniConfigHelper.ReadIniData("配方参数", "当前配方", "", decivePath),
                        GroupList = groupList
                    };
                }
                catch (Exception ex)
                {
                    //写入日志
                    CommonModel.AddLog(1, "解析配置文件失败原因："+ex.Message);
                    return null;
                }
            }
            else
            {
                return null;
            }
            //通信组和通信变量不存在
            //直接返回null
        }
        //通信组和通信变量解析
        /// <summary>
        /// 通过通信组和通信变量的路径，解析出通信组和通信变量
        /// </summary>
        /// <param name="groupPath">通信组路径</param>
        /// <param name="variablePath">通信变量路径</param>
        /// <returns></returns>
        private List<Group> LoadGroup(string groupPath, string variablePath)
        {
            //从GroupPath，VariablePath路径下读取Group，Varable的文件返回List<Group>  方法名LoadgGroup
            //判读GroupPath文件是否存在，不存在添加日志，通信组文件不存在
            //判断Variable文件是否存在，不存在添加日志，通信变量文件不存在
            if (!File.Exists(groupPath))
            {
                CommonModel.AddLog(1, "通信组文件不存在");
                return null;
            }
            if (!File.Exists(variablePath))
            {
                CommonModel.AddLog(1, "通信变量不存在");
                return null;
            }
            //先解析通信组，解析失败就失败写入日志
            //通过MiniExcel.Query
            //再解析通信变量，解析失败就写入日志
            //判断解析出来的通信组和通信变量不能为nul
            List<Group> groupList = null;
            List<Variable> variableList = null;
            try
            {
                groupList = MiniExcel.Query<Group>(groupPath).ToList();
            }
            catch (Exception ex)
            {
                CommonModel.AddLog(1, "通信组解析失败原因:"+ex.Message);
                return null;
            }
            try
            {
                variableList = MiniExcel.Query<Variable>(variablePath).ToList();
            }
            catch (Exception ex)
            {
                CommonModel.AddLog(1, "通信变量解析失败原因"+ex.Message);
                return null;
            }
            //通过Group中的VariableName对应号Variable
            if (variableList!=null&&groupList!=null)
            {
                foreach (Group item in groupList)
                {
                    item.VarList=(variableList.FindAll(c => c.GroupName==item.GroupName).ToList());
                }
                return groupList;
            }
            else
            {
                return null;
            }
        }
        #endregion

        #region 多线程的取消源，以及手动停止对象，以及SysLogBLL对象，程序启动时间，实时数据ActualDataBLL,创建一个System的Timer对象
        /// <summary>
        /// 取消读取数据库的多线程
        /// </summary>
        private CancellationTokenSource cts = new CancellationTokenSource();

        /// <summary>
        /// 手动暂停和继续多线程
        /// </summary>
        private ManualResetEvent manualResetEvent = new ManualResetEvent(true);

        /// <summary>
        /// 日志访问逻辑层对象
        /// </summary>
        private SysLogBLL sysLogBll = new SysLogBLL();

        /// <summary>
        /// 实时数据层访问对象
        /// </summary>
        private ActualDataBLL actualDataBll = new ActualDataBLL();

        /// <summary>
        ///当前窗体的页面索引
        /// </summary>
        private int CurrentFrm = 0;

        /// <summary>
        /// 需要在窗体的构造函数中初始化，窗体关闭时关闭
        /// 使用System.Timers.Timer对象，需要跨现场操作，需要使用this.Invoke(new Action(()=>{}));
        /// </summary>
        private System.Timers.Timer timer = new System.Timers.Timer();

        /// <summary>
        /// 当前NaviButton的集合 
        /// </summary>
        private List<NaviButton> listNaviButton = new List<NaviButton>();
        private string CurrentTime { get { return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); } }
        #endregion

        #region ModbusTCP通信，多线程读取数据
        public void DeciveCommunication(Decive decive)
        {
            //如果取消多线程，之后想要重新启动，重新new一个CancelltionTokenSource
            //if (this.cts.IsCancellationRequested) 
            //{
            //    this.cts=new CancellationTokenSource();
            //}
            //首先进行ModbusTcp连接，
            while (!cts.IsCancellationRequested)
            {
                //1、判断是否已经连接；没有连接则判断是否是第一次连接，是第一次连接，不延时直接连接，不是第一次连接，先先关闭连接，延时5秒连接
                if (decive.IsConnected)
                {
                    //3、连接，就开始读取信息
                    foreach (Group item in decive.GroupList)
                    {
                        //4、读取，又分为读取输入线圈，输出线圈，输出寄存器，输入寄存器，tcp通信，返回的都是字节数组，确定返回字节长度
                        //4.1、读取输入线圈和输出线圈 判断 返回的数据和字节长度 不为空且长度相等，如果上述成立，则关闭连接，跳出循环
                        byte[] data = null;
                        int length = 0;
                        if (item.StoreArea=="输入线圈"||item.StoreArea=="输出线圈")
                        {
                            //判读读取的通信类型
                            switch (item.StoreArea)
                            {
                                case "输入线圈":
                                    data=CommonModel.Modbus.ReadInPutCoils(item.Start, item.Length);
                                    length=ShortLib.GetByteLengthFromBoolLength(item.Length);
                                    break;
                                case "输出线圈":
                                    data=CommonModel.Modbus.ReadOutPutCoils(item.Start, item.Length);
                                    length=ShortLib.GetByteLengthFromBoolLength(item.Length);
                                    break;
                                default:
                                    break;
                            }
                            if (data!=null&&data.Length==length)
                            {
                                //变量解析
                                //遍历Group的variable，先通过变量的数据类型来进行
                                //只能是bool类型，对于输入输出线圈来说，这里的难点就是解析的地址
                                //这里我们需要判断ModbusTCP通信的PLC的通信地址，一般PLC的线圈地址都为0
                                //实际地址为  变量地址-通信组地址，对于线圈来说是这样的
                                //因为返回的数据的byte[]，8个位等于一个字节
                                //处理
                                foreach (Variable var in item.VarList)
                                {
                                    DataType dataType = (DataType)Enum.Parse(typeof(DataType), var.DataType, true);
                                    int start = var.Start-item.Start;
                                    switch (dataType)
                                    {
                                        case DataType.Bool:
                                            var.VarValue=BitLib.GetBitFromByteArray(data, start, var.OffsetORLength);
                                            break;
                                        default: break;
                                    }
                                    //处理，线圈，直接更新数据
                                    decive.UpdateVariable(var);
                                }
                            }
                            else
                            {
                                decive.IsConnected=false;
                                break;
                            }
                        }
                        else
                        {
                            //判读读取的通信类型
                            switch (item.StoreArea)
                            {
                                case "输入寄存器":
                                    data=CommonModel.Modbus.ReadInPutRegisters(item.Start, item.Length);
                                    //因为一个寄存器等于2个字节
                                    length=item.Length*2;
                                    break;
                                case "输出寄存器":
                                    data=CommonModel.Modbus.ReadOutPutRegisters(item.Start, item.Length);
                                    length=item.Length*2;
                                    break;
                                default:
                                    break;
                            }
                            //变量解析
                            //4.2  读取输入寄存器和输出寄存器，判断返回是否为空，长度是否等于两倍，
                            if (data!=null&&data.Length==length)
                            {
                                //变量解析
                                //一样遍历，一个寄存器等于两个字节，也就是第一个寄存器的数据是由两个字节组成
                                //0，1号字节地址--1号寄存器，之后2，3号字节地址--2号寄存器
                                //寄存器的数据类型是bool，对应的大小端是BADC,DCBA
                                //对应的数据类型是byte，也需判断是大小端，比较数据只在一个字节里面，可能是前一个字节，也可能是后一个字节
                                //（变量地址-通信组地址）*2
                                //对应short，int，为大端ABCD
                                foreach (Variable var in item.VarList)
                                {
                                    DataType dataType = (DataType)Enum.Parse(typeof(DataType), var.DataType, true);
                                    int start = var.Start-item.Start;
                                    start=start*2;
                                    switch (dataType)
                                    {
                                        case DataType.Bool:
                                            var.VarValue=BitLib.GetBitFrom2BytesArray(data, start, var.OffsetORLength, (CommonModel.dataFormat==DataFormat.DCBA||CommonModel.dataFormat==DataFormat.BADC));
                                            break;
                                        case DataType.Short:
                                            var.VarValue=ShortLib.GetShortFromByteArray(data, start, CommonModel.dataFormat);
                                            break;
                                        case DataType.UShort:
                                            var.VarValue=UShortLib.GetUShortFromByteArray(data, start, CommonModel.dataFormat);
                                            break;
                                        case DataType.Int:
                                            var.VarValue=IntLib.GetIntFromByteArray(data, start, CommonModel.dataFormat);
                                            break;
                                        case DataType.UInt:
                                            var.VarValue=IntLib.GetIntFromByteArray(data, start, CommonModel.dataFormat);
                                            break;
                                        case DataType.Float:
                                            var.VarValue=FloatLib.GetFloatFromByteArray(data, start, CommonModel.dataFormat);
                                            break;
                                        case DataType.Double:
                                            var.VarValue=DoubleLib.GetDoubleFromByteArray(data, start, CommonModel.dataFormat);
                                            break;
                                        case DataType.Long:
                                            var.VarValue=LongLib.GetLongFromByteArray(data, start, CommonModel.dataFormat);
                                            break;
                                        case DataType.ULong:
                                            var.VarValue=ULongLib.GetULongFromByteArray(data, start, CommonModel.dataFormat);
                                            break;
                                        case DataType.String:
                                            var.VarValue=StringLib.GetStringFromByteArrayByEncoding(data, start, var.OffsetORLength, Encoding.ASCII);
                                            break;
                                        case DataType.ByteArray:
                                            var.VarValue=ByteArrayLib.GetByteArrayFromByteArray(data, start, var.OffsetORLength);
                                            break;
                                        case DataType.HexString:
                                            var.VarValue=StringLib.GetHexStringFromByteArray(data, start, var.OffsetORLength);
                                            break;
                                        default:
                                            break;
                                    }
                                    //处理，需要进行线性转化，之后在更新，线性转化 MigrationLib.GetMigrationValue().Content,
                                    //通过传入当前值和salce线性值以及偏移量或长度来进行转换
                                    //在更新在Decive中字典（variable）的值
                                    var.VarValue=MigrationLib.GetMigrationValue(var.VarValue, var.Scale.ToString(), var.Offset.ToString()).Content;
                                    decive.UpdateVariable(var);
                                }
                            }
                            else
                            {
                                decive.IsConnected=false;
                                break;
                            }
                        }
                    }
                }

                else
                {
                    //判断是否是第一次连接,2、如果是第一次连接，就将第一次连接的标志位置为true，如果是不是第一次连接，就记录日志
                    //初次连接
                    if (decive.ReConnectSign)
                    {
                        CommonModel.Modbus?.DisConnect();
                        Thread.Sleep(decive.DelayedTime);
                    }
                    decive.IsConnected=CommonModel.Modbus.Connect(decive.IPAddRess, decive.Port);
                    if (decive.ReConnectSign)
                    {
                        CommonModel.AddLog(decive.IsConnected ? 0 : 1, decive.IsConnected ? "控制器重新连接成功" : "控制器重新连接失败");
                    }
                    else
                    {
                        //CommonModel.AddLog(decive.IsConnected ? 0 : 1, decive.IsConnected ? "控制器初次连接成功" : "控制器初次连接失败");
                        decive.ReConnectSign=true;
                    }
                }
            }
        }

        #endregion

        /// <summary>
        /// 关闭窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult dr = new FrmMsgBoxWithAck("确认退出程序", "结束").ShowDialog();
            if (dr==DialogResult.OK)
            {
                //关闭定时器，关闭写入数据
                this.timer.Stop();
                //将ModbusTCP通信关闭
                CommonModel.Modbus?.DisConnect();
                //关闭读取数据读取多线程的，取消信号源
                this.cts?.Cancel();
                this.Close();
            }
        }

        #region 通用窗体切换
        /// <summary>
        /// 通用切换窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommonNaviButton_Click(object sender, EventArgs e)
        {
            //判断事件的触发者是不是NaviButton控件,顺便将其转化为navi名的对象
            if (sender is NaviButton navi)
            {
                //还需要判断，其窗体自定义TitelName是不是在我们所创建的Enum枚举里面
                if (Enum.IsDefined(typeof(FormNames), navi.TitleName))
                {
                    //在里面进行窗体的切换，判断控件的自定义属性TitelName来判断，切换成什么窗体
                    FormNames frm = (FormNames)Enum.Parse(typeof(FormNames), navi.TitleName,true);

                    //将用户权限添加在这里,将设定的FormNames枚举值传递给权限管理,不需要集中监控和临时窗体
                    //在的得到窗体名，之后判断当前用户的是否有切换当前窗体的选限
                    //提示当前用户没有权限打开窗体，请切换权限
                    switch (frm)
                    {
                        case FormNames.参数设置:
                            if (!CommonModel.CurrentAdmin.ParamSet)
                            {
                                new FrmMsgBoxWithoutAck("当前用户没有权限进入参数设置界面","请切换用户").ShowDialog();
                                return;
                            }
                            break;
                        case FormNames.配方管理:
                            if (!CommonModel.CurrentAdmin.Recipe)
                            {
                                new FrmMsgBoxWithoutAck("当前用户没有权限进入配方管理界面", "请切换用户").ShowDialog();
                                return;
                            }
                            break;
                        case FormNames.报警追溯:
                            if (!CommonModel.CurrentAdmin.HistoryLog)
                            {
                                new FrmMsgBoxWithoutAck("当前用户没有权限进入报警追溯界面", "请切换用户").ShowDialog();
                                return;
                            }
                            break;
                        case FormNames.历史趋势:
                            if (!CommonModel.CurrentAdmin.HistoryTrend)
                            {
                                new FrmMsgBoxWithoutAck("当前用户没有权限进入历史趋势界面", "请切换用户").ShowDialog();
                                return;
                            }
                            break;
                        case FormNames.用户管理:
                            if (!CommonModel.CurrentAdmin.UserMange)
                            {
                                new FrmMsgBoxWithoutAck("当前用户没有权限进入用户管理界面", "请切换用户").ShowDialog();
                                return;
                            }
                            break;
                        default:
                            break;
                    }
                    //每次切换窗体，都需将其改到当前窗体的索引上去
                    this.CurrentFrm=this.listNaviButton.IndexOf(navi);

                    OpenForm(this.MainPanel, frm);
                    //设定主窗体Title，
                    SetTitel(this.lbl_Title, frm);
                    //显示控件被选中
                    SetNaviButtonSelected(this.TopPanel, navi);
                }
            }
        }

        /// <summary>
        /// 写一个嵌入窗体的方法,通用打开窗体
        /// </summary>
        /// <param name="mianPanel">窗体容器</param>
        /// <param name="frm">窗体枚举Enum名称</param>
        private void OpenForm(Panel mainPanel, FormNames formName)
        {
            //1、是得到容器内的控件数量，设定控件减少的数量值,设定bool类型判断是否存在所切换的窗体
            int count = mainPanel.Controls.Count;
            int deleteControls = 0;
            bool isFind = false;
            //2、遍历控件，判断那些是窗体控件，因为窗体控件数量是变化的，
            //有的窗体会被我们关闭，有的窗体控件会被放入临时窗体中,因为窗体的deleteControls值会变化，不能用foreach遍历
            for (int i = 0; i<count; i++)
            {
                //3、判断当前的控件是不是Form窗体，再次判断是不是我们需要操作的窗体
                //通过窗体enum参数来判断是不是需要的窗体
                Control ct = mainPanel.Controls[i-deleteControls];
                if (ct is Form frm)
                {
                    if (frm.Text==formName.ToString())
                    {
                        frm.BringToFront();//将窗体在Mainpanel容器中显示顶层，因为可能还存在其他的临时窗体
                        isFind = true;
                        break;//退出循环
                    }
                    //4、如果不是需要的窗体，判断是否是临时窗体，如果是，不做处理，如果不是则关闭，并且同时，在控件减少的数量值加1
                    else if ((FormNames)(Enum.Parse(typeof(FormNames), frm.Text, true))>FormNames.临界窗体)
                    {
                        frm.Close();
                        deleteControls++;
                    }
                }
            }

            //5、没有找到我们需要的窗体，则需要将将窗体嵌入到panel控件中，也就是说，现在MainPanel中的窗体不是
            //我要找到窗体，又不是集中显示窗体，就全部关闭
            //通过switch多定值判断，判断我们输入的enum是那个窗体
            if (isFind==false)
            {
                Form frm = null;
                switch (formName)
                {
                    case FormNames.集中控制:
                        frm=new FrmMonitor();
                        //这里将全局日志委托添加集中控制的中的方法
                        CommonModel.AddLog=((FrmMonitor)frm).AddLog;
                        break;
                    case FormNames.参数设置:
                        //将Decive的路径当作参数，传递给FrmParams对象
                        frm=new FrmParams(this.decPath);
                        break;
                    case FormNames.配方管理:
                        //将Decive的路径当作参数，传递给FrmParams对象
                        frm=new FrmRecipe(this.decPath);
                        break;
                    case FormNames.报警追溯:
                        frm=new FrmAlarm();
                        break;
                    case FormNames.历史趋势:
                        frm=new FrmHistory();
                        break;
                    case FormNames.用户管理:
                        frm=new FrmUserMange();
                        break;
                    default:
                        break;
                }
                //6、则将窗体不设定为顶级窗体
                //并且将窗体设定为无边框窗体,将窗体fill填充到容器，并且父容器为panel控件
                if (frm!=null)
                {
                    //不是所查找的窗体，不是固定窗体，而是临时窗体
                    //设定为非顶级窗体
                    frm.TopLevel=false;
                    //将窗体填充到容器
                    frm.Dock=DockStyle.Fill;
                    //将窗体设定为无边界
                    frm.FormBorderStyle=FormBorderStyle.None;
                    //将窗体的的父容器设定为Panel
                    frm.Parent=mainPanel;
                    //置前
                    frm.BringToFront();
                    //7、最后显示窗体
                    frm.Show();
                }
            }
        }

        /// <summary>
        /// 将主窗体的Titel的Label控件的Text进行更改
        /// </summary>
        /// <param name="label">标题控件</param>
        /// <param name="formNames"></param>
        private void SetTitel(Label label, FormNames formNames)
        {
            label.Text=formNames.ToString();
        }

        /// <summary>
        /// 设定导航按钮选中聚焦
        /// </summary>
        /// <param name="topPanel">导航按钮所在容器</param>
        /// <param name="nav">所选中的导航按钮</param>
        private void SetNaviButtonSelected(Panel topPanel, NaviButton nav)
        {
            //遍历panel容器中的所有NaviButton控件，将所有的IsSelected属性置为false
            foreach (Control control in topPanel.Controls)
            {
                if (control is NaviButton navi)
                {
                    navi.IsSelected=false;
                }
            }
            //只将点击NaviButton修改对应，就是将自定义的IsSelected属性修改为true，然后改变控件的BackGroundImage属性
            nav.IsSelected=true;
        }
        #endregion

        #region 减少闪烁
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |=0x2000000;
                return cp;
            }
        }




        #endregion

        /// <summary>
        /// 每次加载窗体，先得到指定路径下的Decive
        /// 再打开默认的集中控制窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //更新用户名称
            this.lbl_User.Text=CommonModel.CurrentAdmin.LoginName;

            //打开对应的窗体
            CommonNaviButton_Click(this.naviButton1, null);
            //初始化得到Decive的初始化信息
            CommonModel.Decive=LoadDevice(decPath, groupPath, variablePath);
            //判断信息是否为空
            if (CommonModel.Decive!=null)
            {
                //判断配置的Decive是否存在，之后再加载日志
                CommonModel.AddLog(0, "登入程序");
                //添加CommonModel.Decive中的报警事件
                CommonModel.Decive.AlarmTrigEvent+=Decive_AlarmTrigEvent;
                //执行多线程连接硬件，执行读取数据
                Task.Run(new Action(() =>
                {
                    DeciveCommunication(CommonModel.Decive);
                }), cts.Token);
                //执行存储数据
                this.timer.Start();
            }
        }



        //报警触发就写入日志，备注说明报警原因
        //判断动态集合里面是否包含报警原因，包含就不添加，不包含就添加进去
        //消除报警，就日志添加消除
        //报销消除的时候，就move移除调
        //这样触发本身集合数量改变的事件
        /// <summary>
        /// 报警触发事件
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="variable"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void Decive_AlarmTrigEvent(bool ackType, Variable variable)
        {
            //true,触发报警
            if (ackType)
            {
                CommonModel.AddLog(1, "触发"+variable.Remark);
                //当程序启动中，所存在的报警信息存储到数据库中
                sysLogBll.AddLog(new SysLogModel()
                {
                    InsertTime=CurrentTime,
                    Note=variable.Remark,
                    AlarmType="触发",
                    Operator=CommonModel.CurrentAdmin.LoginName,
                    VarName=variable.VarName
                });
                if (!this.actualAlarmList.Contains(variable.Remark))
                {
                    actualAlarmList.Add(variable.Remark);
                }
            }
            else
            {
                CommonModel.AddLog(0, "消除"+variable.Remark);
                sysLogBll.AddLog(new SysLogModel()
                {
                    InsertTime=CurrentTime,
                    Note=variable.Remark,
                    AlarmType="消除",
                    Operator=CommonModel.CurrentAdmin.LoginName,
                    VarName=variable.VarName
                });
                if (this.actualAlarmList.Contains(variable.Remark))
                {
                    actualAlarmList.Remove(variable.Remark);
                }
            }
        }

        //CollectionChanged这个事件
        //根据集合的数量进行处理
        //定值判断
        /// <summary>
        /// 当动态集合，数量发生变化触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void ActualAlarmList_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                switch (this.actualAlarmList.Count)
                {
                    case 0:
                        this.scrollingAlarm.Text="当前系统无报警";
                        break;
                    default:
                        this.scrollingAlarm.Text=string.Join("   ", actualAlarmList);
                        break;
                }
            }));
        }

        /// <summary>
        /// 关闭系统时钟
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.timer.Stop();
        }


        #region 移动无框窗体
        private Point point;
        /// <summary>
        /// 得到鼠标左键的坐标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            point=new Point(e.X, e.Y);
        }
        /// <summary>
        /// 移动到鼠标左键拖动的地方
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                //修改窗体的位置，得到移动
                this.Location=new Point(this.Location.X+e.X-point.X, this.Location.Y+e.Y-point.Y);
            }
        }
        #endregion

        #region 将窗体左右移位1个窗体
        /// <summary>
        /// 当前窗体向左切换一个
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Left_Click(object sender, EventArgs e)
        {
            int num = this.CurrentFrm-1;
            if (num<0)
            {
                num=5;
            }
            CommonNaviButton_Click(listNaviButton[num],null);
        }

        /// <summary>
        /// 当前窗体向右切换一个
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            int num = this.CurrentFrm+1;
            if (num>=6)
            {
                num=0;
            }
            CommonNaviButton_Click(listNaviButton[num],null);
        }
        #endregion
    }
}
