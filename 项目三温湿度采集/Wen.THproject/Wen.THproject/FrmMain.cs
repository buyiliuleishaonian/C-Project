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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 关闭窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确认关闭窗体", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr==DialogResult.OK)
            {
                this.Close();
            }
            {
                return;
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

            //5、没有找到我们需要的窗体，则需要将将窗体嵌入到panel控件中
            //通过switch多定值判断，判断我们输入的enum是那个窗体
            if (isFind==false)
            {
                Form frm = null;
                switch (formName)
                {
                    case FormNames.集中控制:
                        frm=new FrmMonitor();
                        break;
                    case FormNames.参数设置:
                        frm=new FrmParams();
                        break;
                    case FormNames.配方管理:
                        frm=new FrmRecipe();
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

       
    }
}
