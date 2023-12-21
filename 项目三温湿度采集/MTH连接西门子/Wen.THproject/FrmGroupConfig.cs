using MiniExcelLibs;
using MTHModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wen.Common;

namespace Wen.THproject
{
    /// <summary>
    /// 通信组详细，修改窗体
    /// </summary>
    public partial class FrmGroupConfig : Form
    {
        //用于添加Group组
        public  List<Group> TotalGroup=new List<Group>();

        public FrmGroupConfig()
        {
            InitializeComponent();
            this.dgv_Main.AutoGenerateColumns=false;

            //不能按得到datasource自动生成，没有定义的列
            this.cmb_StoreAsea.DataSource=new string[] { "输入线圈","输出线圈","输入寄存器","输出寄存器"};
            this.cmb_StoreAsea.SelectedIndex=0;
            //刷新视图
            //先读取Excel中的数据,因为
            if (GetAllGroups()!=null)
            {
                TotalGroup= GetAllGroups();
            }
            NewDataGridView();
        }
        //将Group的集合存储到Excel文件的相对路径
       private  string groupPath = Application.StartupPath+@"\Group\group.xlsx";

        #region 添加通信组

        /// <summary>
        /// 添加通信组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            //先要判断 通信组，要求的属性，不能为空，不能无法转为正确属性的类型
            //MiniExcel，将通信组全部插入到Excel表格种
            if (!ISGroup()) return;
            
            if (IsGroupNameExits(this.txt_GroupName.Text.Trim()))
            {
                new FrmMsgBoxWithoutAck("通信组名重复", "操作通信组").ShowDialog();
                return;
            }
            TotalGroup.Add(new Group()
            {
                GroupName = this.txt_GroupName.Text,
                Start=Convert.ToUInt16(this.nud_Start.Value),
                Length=Convert.ToUInt16(this.nud_Length.Value),
                StoreArea=this.cmb_StoreAsea.Text.ToString(),
                Remark=this.txt_Remark.Text
            }) ;
            //保存到指定的文件夹下
            try
            {
                MiniExcel.SaveAs(groupPath, TotalGroup, overwriteFile: true);
                new FrmMsgBoxWithoutAck("添加通信组成功", "添加通信组").ShowDialog();
                //刷新数据
                NewDataGridView();
            }
            //失败原因
            catch (Exception ex) 
            {
                new FrmMsgBoxWithoutAck("添加通信组失败"+ex.Message, "添加通信组").ShowDialog();
            }
        }

        #endregion

        #region 删除通信组
        /// <summary>
        /// 删除通信组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //判断输入的数据是否正确
            if (!ISGroup()) return;
            if (!IsGroupNameExits(this.txt_GroupName.Text.Trim()))
            {
                new FrmMsgBoxWithoutAck("通信组名不存在", "操作通信组").ShowDialog();
                return;
            }
            //首先得到txt_GroupName的值，判断是否在TOtalGroup集合里面是否存在
            //从TotalGroup集合里面移除改Group组
            string groupName=this.txt_GroupName.Text;
            if (IsGroupNameExits(groupName))
            {
                this.TotalGroup.RemoveAll(c=>c.GroupName==groupName);
            }
            //从新保存到Excel中，然后刷新数据
            try
            {
                MiniExcel.SaveAs(groupPath, TotalGroup, overwriteFile: true);
                NewDataGridView();
            }
            catch(Exception ex)
            {
                new FrmMsgBoxWithoutAck("删除通信组失败原因："+ex.Message,"删除通信组").ShowDialog();
            }
        }
        #endregion

        #region 修改通信组Group组
        /// <summary>
        /// 修改通信组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Update_Click(object sender, EventArgs e)
        {
            //无法修改通信通信组名字
            string groupName=this.txt_GroupName.Text;
            if (!ISGroup()) return;
            if (!IsGroupNameExits(groupName))
            {
                new FrmMsgBoxWithoutAck("通信组不存在无法修改","修改通信组").ShowDialog();
                return;
            }
            try
            {
                //这里返回的是TotalGroup集合的一个元素，而不是单独得到一个List<Group>集合
                var value = this.TotalGroup.Find(c=>c.GroupName==groupName);
                value.Start=Convert.ToUInt16( this.nud_Start.Value);
                value.Length=Convert.ToUInt16(this.nud_Length.Value);
                value.StoreArea=this.cmb_StoreAsea.Text;
                value.Remark=this.txt_Remark.Text;
                MiniExcel.SaveAs(groupPath,TotalGroup,overwriteFile:true);
                NewDataGridView();
            }
            catch(Exception ex) 
            {
                new FrmMsgBoxWithoutAck("通信组修改失败原因："+ex.Message,"修改通信组").ShowDialog();
            }
        }
        #endregion


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

        #region DataGridView的事件

        /// <summary>
        /// 添加行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_Main_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewStyle.DgvRowPostPaint(this.dgv_Main, e);
        }


        /// <summary>
        /// 点击DataGridView,中的行就整个窗体显示这一行的数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_Main_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //通过DataGridView的datasource属性的关系，可以得到对应的TotalGroup的集合中对应的元素
            if (e.RowIndex>=0)
            {
                SetRowGroup(this.TotalGroup[e.RowIndex]);
            }
        }

        /// <summary>
        /// 绘制单元格内容，判断是否有数据没有显示为---
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_Main_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //先要判断是否表格中是否有行显示
            //得到绘制单元格的内容，判断是否为空，或者长度为0
            if (e.RowIndex>=0&&e.ColumnIndex>=0)
            {
                if (this.dgv_Main.Rows[e.RowIndex].Cells[e.ColumnIndex].Value==null||this.dgv_Main.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Trim().Length==0)
                {
                    e.Value="----";
                }
            }
        }

        /// <summary>
        /// 得到指定行的数据
        /// </summary>
        /// <param name="group"></param>
        private void SetRowGroup(Group group)
        {
            if (group!=null)
            {
                this.txt_GroupName.Text = group.GroupName;
                this.nud_Start.Value=Convert.ToDecimal(group.Start);
                this.nud_Length.Value=Convert.ToDecimal(group.Length);
                this.cmb_StoreAsea.Text=group.StoreArea;
                this.txt_Remark.Text=group.Remark;
            }
        }

        /// <summary>
        /// 右键删除指定行的数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除通信组ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Delete_Click(null, null);
        }

        #endregion

        #region 方法

        /// <summary>
        /// 判断存在Group窗体上显示的数据是否是对应Group类的数据类型
        /// </summary>
        private bool ISGroup()
        {
            #region 判断输入的属性是否满足要求
            if (this.txt_GroupName.Text==null||this.txt_GroupName.Text.Trim().Length==0)
            {
                new FrmMsgBoxWithoutAck("操作通信组失败：通信组名不能为空", "操作通信组").ShowDialog();
                return false;
            }
            if (!Int16.TryParse(this.nud_Start.Value.ToString(), out _)&&this.nud_Start.Value!=0)
            {
                new FrmMsgBoxWithoutAck("操作通信组失败：通信组的起始位置输入错误", "操作通信组").ShowDialog();
                return false;
            }
            if (!UInt16.TryParse(this.nud_Length.Value.ToString(), out _))
            {
                new FrmMsgBoxWithoutAck("操作通信组失败：通信组的长度输入错误", "操作通信组").ShowDialog();
                return false;
            }
            if (this.cmb_StoreAsea.Text.Trim().Length==0||this.cmb_StoreAsea.SelectedIndex<0)
            {
                new FrmMsgBoxWithoutAck("操作通信组失败：请选择存储区", "操作通信组").ShowDialog();
                return false;
            }
            return true;
            #endregion
        }

        /// <summary>
        /// 用来读取Excel中的Group组
        /// </summary>
        /// <returns></returns>
        public List<Group> GetAllGroups()
        {
            return MiniExcel.Query<Group>(groupPath).ToList();
        }

        /// <summary>
        /// 通过遍历寻找group的List集合，判断输入的参数是否在Group集合中的元素的GroupName属性相同
        /// </summary>
        /// <param name="groupName"></param>
        /// <returns></returns>
        private bool IsGroupNameExits(string groupName)
        {
            return TotalGroup.FindAll(c => c.GroupName==groupName).ToList().Count>0;
        }


        /// <summary>
        /// 刷线DataGridView的数据
        /// </summary>
        public void NewDataGridView()
        {
            //第一次刷新数据的时候，因为TotalGroup在Excel没有读取到数据为空
            if (this.TotalGroup!=null&&this.TotalGroup.Count>0)
            {
                this.dgv_Main.DataSource=null;
                this.dgv_Main.DataSource=TotalGroup;
            }
            //当我们删除最后个元素时，也无法刷新DataGridView，所以我们要返回null
            else 
            {
                this.dgv_Main.DataSource=null;
            }
        }


        #endregion

        /// <summary>
        /// 关闭详细的Group组的窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
