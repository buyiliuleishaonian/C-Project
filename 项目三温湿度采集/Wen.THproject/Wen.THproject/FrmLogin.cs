using MTHModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wen.MTHBLL;

namespace Wen.THproject
{
    public partial class FrmLogin : Form
    {
        public SysAdminBLL sysAdminBLL = new SysAdminBLL();

        public FrmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 退出程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new FrmMsgBoxWithAck("退出程序","多路温湿度采集").ShowDialog();
            if (dialogResult==DialogResult.OK)
            {
                this.Close();
            }
        }

        /// <summary>
        /// 点击登录按钮，验证用户名和密码是否正确
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Login_Click(object sender, EventArgs e)
        {
            //首先判断用户名和密码是否为空
            if (this.txt_UserName.Text.ToString().Trim().Length<=0||this.txt_UserName.Text==null)
            {
                new FrmMsgBoxWithoutAck("用户名密码为空","多路温湿度采集").ShowDialog();
                return;
            }
            if (this.txt_PassWord.Text.ToString().Trim().Length<=0||this.txt_PassWord.Text==null)
            {
                new FrmMsgBoxWithoutAck("用户名密码为空","多路温湿度采集").ShowDialog();
                return;
            }
            //判断用户名和密码是否正确
            SysAdminModel sysadminModel= sysAdminBLL.GetSysAdminModel(this.txt_UserName.Text.ToString().Trim(), this.txt_PassWord.Text.ToString().Trim());
            if (sysadminModel!=null)
            {
                new FrmMsgBoxWithoutAck("登录成功","多路温湿度采集").ShowDialog();
                CommonModel.CurrentAdmin=sysadminModel;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                new FrmMsgBoxWithoutAck("用户名或密码错误","多路温湿度采集").ShowDialog();
                return;
            }
            this.txt_UserName.Focus();
        }

        /// <summary>
        /// 按下Enter键登录，按下Esc键退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_UserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                //首先判断用户名和密码是否为空
                if (this.txt_UserName.Text.ToString().Trim().Length<=0||this.txt_UserName.Text==null)
                {
                    new FrmMsgBoxWithoutAck("用户名密码为空", "多路温湿度采集").ShowDialog();
                    return;
                }
                if (this.txt_PassWord.Text.ToString().Trim().Length<=0||this.txt_PassWord.Text==null)
                {
                    new FrmMsgBoxWithoutAck("用户名密码为空", "多路温湿度采集").ShowDialog();
                    return;
                }
                btn_Login_Click(null, null);
            }
            if (e.KeyCode==Keys.Escape)
            {
                btn_Close_Click(null, null);
            }
        }

        public void txtCommon_DoubuleClick(object sender,EventArgs e)
        {
            StartKeyBorad();
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

        #region 启用软键盘
        private void StartKeyBorad()
        {
            //打开软键盘
            try
            {
                if (!System.IO.File.Exists(@"C:\WINDOWS\system32\osk.exe"))
                {
                    MessageBox.Show("软键盘可执行文件不存在");
                    return;
                }
               softKey = System.Diagnostics.Process.Start(Environment.SystemDirectory+@"\osk.exe");
                //上面的代码是打开软键盘，系统还没用立刻把软键盘的窗口创建出来，所以下面的代码用循环来查询窗口是否创建
                //只有创建了窗口
                //FindWindow才能找到窗口句柄，才可以移动窗口的位置和设置窗口的大小，这里是关键
                IntPtr intptr = IntPtr.Zero;
                while (IntPtr.Zero==intptr)
                {
                    System.Threading.Thread.Sleep(100);
                    intptr = FindWindow(null, "屏幕键盘");
                }
                //获取屏幕尺寸
                int iActulaWidth = Screen.PrimaryScreen.Bounds.Width;
                int iActulaHight=Screen.PrimaryScreen.Bounds.Height;
                int posX = (iActulaWidth-1000)/2;
                int posY = (iActulaHight-300);

                //设定软键盘的显示位置
                MoveWindow(intptr, posX, posY, 1000, 300, true);

                //设置软键盘到前端显示
                SetForegroundWindow(intptr);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //要申明使用的Dll和api
        [DllImport("User32.dll",EntryPoint="FindWindow")]

        public extern static IntPtr FindWindow(string IpClassName,string IpWindowName);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll",EntryPoint="MoveWindow")]

        public static extern bool MoveWindow(System.IntPtr hWnd,int x,int y,int nWidth,int nHeight,bool bRepaint);

        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        private System.Diagnostics.Process softKey;
        #endregion


        /// <summary>
        /// 退出程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cenel_Click(object sender, EventArgs e)
        {
            btn_Close_Click(null,null);
        }
    }
}
