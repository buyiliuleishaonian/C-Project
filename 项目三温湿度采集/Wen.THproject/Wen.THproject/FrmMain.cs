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
using System.Windows.Forms;
using thinger.DataConvertLib;
using Wen.Common;
using Wen.ControlLib;

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
            actualAlarmList.CollectionChanged+=ActualAlarmList_CollectionChanged;
        }

        #region 配置文件
        //创建Decive文件路径
        private string decPath = Application.StartupPath+@"\Decive\decive.ini";
        //创建Group文件路径
        private string groupPath = Application.StartupPath+@"\Group\group.xlsx";
        //创建Excel文件路径
        private string variablePath = Application.StartupPath+@"\Variable\variable.xlsx";
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
                CommonModel.AddLog(1,"设备文件不存在");
                return null;
            }
            //解析通信组和通信变量
            //判断通信组和通信变量是存在
            List<Group> groupList = LoadGroup(groupPath,variablePath);
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

        #region 多线程的取消源，以及手动停止对象,以及Modbus通信对象
        private CancellationTokenSource cts= new CancellationTokenSource();

        private ManualResetEvent manualResetEvent = new ManualResetEvent(true);

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
                                    DataType dataType =(DataType) Enum.Parse(typeof(DataType), var.DataType, true);
                                    int start = var.Start-item.Start;
                                    switch (dataType)
                                    {
                                        case DataType.Bool:
                                                var.VarValue=BitLib.GetBitFromByteArray(data,start,var.OffsetORLength);
                                                break;
                                            default : break;
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
                                    DataType dataType = (DataType)Enum.Parse(typeof(DataType),var.DataType,true);
                                    int start=var.Start-item.Start;
                                    start=start*2;
                                    switch (dataType)
                                    {
                                        case DataType.Bool:
                                            var.VarValue=BitLib.GetBitFrom2BytesArray(data,start,var.OffsetORLength,(CommonModel.dataFormat==DataFormat.DCBA||CommonModel.dataFormat==DataFormat.BADC));
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
                                            var.VarValue=StringLib.GetStringFromByteArrayByEncoding(data,start,var.OffsetORLength,Encoding.ASCII);
                                            break;
                                        case DataType.ByteArray:
                                            var.VarValue=ByteArrayLib.GetByteArrayFromByteArray(data,start,var.OffsetORLength);
                                            break;
                                        case DataType.HexString:
                                            var.VarValue=StringLib.GetHexStringFromByteArray(data,start,var.OffsetORLength);
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
                        CommonModel.AddLog(decive.IsConnected ? 0 : 1, decive.IsConnected ? "控制器初次连接成功" : "控制器初次连接失败");
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
                    FormNames frm = (FormNames)Enum.Parse(typeof(FormNames), navi.TitleName, true);
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
            //打开对应的窗体
            CommonNaviButton_Click(this.naviButton1, null);
            //初始化得到Decive的初始化信息
            CommonModel.Decive=LoadDevice(decPath,groupPath,variablePath);
            //判断信息是否为空
            if (CommonModel.Decive!=null)
            {
                //判断配置的Decive是否存在，之后再加载日志
                CommonModel.AddLog(0, "登入程序");
                //添加CommonModel.Decive中的报警事件
                CommonModel.Decive.AlarmTrigEvent+=Decive_AlarmTrigEvent;
                //执行多线程连接硬件，执行读取数据
                Task.Run(new Action(()=>
                {
                    DeciveCommunication(CommonModel.Decive);
                }),cts.Token);
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
        /// <param name="arg2"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void Decive_AlarmTrigEvent(bool arg1, Variable arg2)
        {
            //true,触发报警
            if (arg1)
            {
                CommonModel.AddLog(1,"触发"+arg2.Remark);
                if (!this.actualAlarmList.Contains(arg2.Remark))
                {
                    actualAlarmList.Add(arg2.Remark);
                }
            }
            else 
            {
                CommonModel.AddLog(0,"消除"+arg2.Remark);
                if (this.actualAlarmList.Contains(arg2.Remark))
                {
                    actualAlarmList.Remove(arg2.Remark);
                }
            }
        }

        //可以监视的集合,动态可监视的集合，可以在项目，添加，删除或刷新整个列表的提供通知，
        private ObservableCollection<string> actualAlarmList=new ObservableCollection<string>();

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
                        this.scrollingAlarm.Text=string.Join("   ",actualAlarmList);
                        break;
                }
            }));
        }
    }
}
