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
using thinger.DataConvertLib;
using Wen.Common;

namespace Wen.THproject
{
    /// <summary>
    /// 变量详细，修改窗体
    /// </summary>
    public partial class FrmVariableConfig : Form
    {
        //用于添加Group组的集合
        public List<Group> TotalGroup = new List<Group>();
        //用于添加Variable的集合
        public List<Variable> TotalVariable = new List<Variable>();

        public FrmVariableConfig()
        {
            InitializeComponent();
            //不按得到的数据自动生成列
            this.dgv_Main.AutoGenerateColumns=false;
            //从Excel文件中先得到已存在的Variable
            if (GetAllVariable()!=null)
            {
                this.TotalVariable= GetAllVariable();
            }

            //让ComboBox得到索引更改发生的事件
            this.cmb_GroupName.SelectedValueChanged+=Cmb_GroupName_SelectedValueChanged;

            //不能按得到datasource自动生成，没有定义的列
            this.cmb_DataType.DataSource=Enum.GetNames(typeof(DataType));
            this.cmb_DataType.SelectedIndex=0;
            //刷新视图
            //先读取Excel中的数据,因为
            if (GetAllGroups()!=null)
            {
                this.TotalGroup= GetAllGroups();
                foreach (Group group in TotalGroup)
                {
                    this.cmb_GroupName.Items.Add(group.GroupName);
                    this.cmb_GroupName.SelectedIndex=-1;
                }
            }
        }

        private void Cmb_GroupName_SelectedValueChanged(object sender, EventArgs e)
        {
            //刷新DataGridView
            NewDataGridView();
        }

        /// <summary>
        /// 当cmb_GroupName的索引更改就执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void Cmb_GroupName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //刷新DataGridView
            NewDataGridView();
        }

        //因为需要得到Group组的名字，因为一个Group组中存在多个变量
        string groupPath = Application.StartupPath+@"\Group\group.xlsx";
        //再创建一个用于存储Variable
        string varPath = Application.StartupPath+@"\Variable\variable.xlsx";

        #region 添加变量

        /// <summary>
        /// 添加变量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            //先要判断 变量，要求的属性，不能为空，不能无法转为正确属性的类型
            //MiniExcel，将变量全部插入到Excel表格种
            if (!ISGroup()) return;

            if (IsVariableNameExits(this.txt_VarIableName.Text.Trim()))
            {
                new FrmMsgBoxWithoutAck("变量名重复", "操作变量").ShowDialog();
                return;
            }
            TotalVariable.Add(new Variable()
            {
                VarName=this.txt_VarIableName.Text,
                DataType=this.cmb_DataType.Text,
                Start=Convert.ToUInt16(this.nud_Start.Value),
                OffsetORLength=Convert.ToUInt16(this.nud_OffsetOrLength.Value),
                GroupName=this.cmb_GroupName.Text,
                Remark=this.txt_Remark.Text,
                PosAlarm=this.cbk_PosAlarm.Checked ? true : false,
                NegAlarm=this.cbk_NegAlarm.Checked ? true : false,
                Scale=Convert.ToSingle(this.nud_Salce.Value),
                Offset=Convert.ToSingle(this.nud_Offset.Value),
            });
            //保存到指定的文件夹下
            try
            {
                MiniExcel.SaveAs(varPath, TotalVariable, overwriteFile: true);
                new FrmMsgBoxWithoutAck("添加变量成功", "添加变量").ShowDialog();
                //刷新数据
                NewDataGridView();
            }
            //失败原因
            catch (Exception ex)
            {
                new FrmMsgBoxWithoutAck("添加变量失败"+ex.Message, "添加变量").ShowDialog();
            }
        }

        #endregion

        #region 删除变量
        /// <summary>
        /// 删除变量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //判断输入的数据是否正确
            if (!ISGroup()) return;
            if (!IsVariableNameExits(this.txt_VarIableName.Text.Trim()))
            {
                new FrmMsgBoxWithoutAck("变量名不存在", "操作变量").ShowDialog();
                return;
            }
            //首先得到txt_GroupName的值，判断是否在TOtalGroup集合里面是否存在
            //从TotalGroup集合里面移除改Group组
            string varName = this.txt_VarIableName.Text;
            if (IsVariableNameExits(varName))
            {
                this.TotalVariable.RemoveAll(c => c.VarName==varName);
            }
            //从新保存到Excel中，然后刷新数据
            try
            {
                MiniExcel.SaveAs(varPath, this.TotalVariable, overwriteFile: true);
                NewDataGridView();
            }
            catch (Exception ex)
            {
                new FrmMsgBoxWithoutAck("删除变量失败原因："+ex.Message, "删除变量").ShowDialog();
            }
        }
        #endregion

        #region 修改变量
        /// <summary>
        /// 修改变量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Update_Click(object sender, EventArgs e)
        {
            //无法修改通信变量名字
            string varName = this.txt_VarIableName.Text;
            if (!ISGroup()) return;
            if (!IsVariableNameExits(varName))
            {
                new FrmMsgBoxWithoutAck("变量不存在无法修改", "修改变量").ShowDialog();
                return;
            }
            try
            {
                //这里返回的是TotalGroup集合的一个元素，而不是单独得到一个List<Group>集合
                var value = this.TotalVariable.Find(c => c.VarName==varName);
                value.DataType=this.cmb_DataType.Text;
                value.Start=Convert.ToUInt16(this.nud_Start.Value);
                value.OffsetORLength=Convert.ToUInt16(this.nud_OffsetOrLength.Value);
                value.GroupName=this.cmb_GroupName.Text;
                value.Remark=this.txt_Remark.Text;
                value.PosAlarm=this.cbk_PosAlarm.Checked ? true : false;
                value.NegAlarm=this.cbk_NegAlarm.Checked ? true : false;
                value.Scale=Convert.ToSingle(this.nud_Salce.Value);
                value.Offset=Convert.ToSingle(this.nud_Offset.Value);
                MiniExcel.SaveAs(varPath, this.TotalVariable, overwriteFile: true);
                NewDataGridView();
            }
            catch (Exception ex)
            {
                new FrmMsgBoxWithoutAck("变量修改失败原因："+ex.Message, "修改变量").ShowDialog();
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
                SetRowGroup(TotalVariable[e.RowIndex]);
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
                //这里需要将上升沿报警，下降沿报警，在DataGridView中显示为启用或禁止，列为6/7
                if (this.dgv_Main.Rows[e.RowIndex].Cells[e.ColumnIndex].Value==null||this.dgv_Main.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Trim().Length<=0)
                {
                    e.Value="----";
                }
            }
        }

        /// <summary>
        /// 显示指定的Variable变量属性
        /// </summary>
        /// <param name="group"></param>
        private void SetRowGroup(Variable var)
        {
            if (var!=null)
            {
                this.cmb_GroupName.Text=var.GroupName;
                this.txt_VarIableName.Text=var.VarName;
                this.nud_Start.Value=Convert.ToDecimal(var.Start);
                this.nud_OffsetOrLength.Value=Convert.ToDecimal(var.OffsetORLength);
                this.cmb_DataType.Text=var.DataType;
                this.cbk_PosAlarm.CheckState=var.PosAlarm ? CheckState.Checked : CheckState.Unchecked;
                this.cbk_NegAlarm.CheckState=var.NegAlarm ? CheckState.Checked : CheckState.Unchecked;
                this.nud_Salce.Value=Convert.ToDecimal(var.Scale);
                this.nud_Offset.Value=Convert.ToDecimal(var.Offset);
            }
        }

        /// <summary>
        /// 右键删除指定行的数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除变量ToolStripMenuItem_Click(object sender, EventArgs e)
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
            if (this.txt_VarIableName.Text==null||this.txt_VarIableName.Text.Trim().Length==0)
            {
                new FrmMsgBoxWithoutAck("操作变量失败：变量名不能为空", "操作变量").ShowDialog();
                return false;
            }
            if (!Int16.TryParse(this.nud_Start.Value.ToString(), out _))
            {
                new FrmMsgBoxWithoutAck("操作变量失败：变量的起始索引输入错误", "操作变量").ShowDialog();
                return false;
            }
            if (!UInt16.TryParse(this.nud_OffsetOrLength.Value.ToString(), out _))
            {
                new FrmMsgBoxWithoutAck("操作变量失败：变量的偏移量或长度输入错误", "操作变量").ShowDialog();
                return false;
            }
            if (this.cmb_DataType.Text.Trim().Length==0||this.cmb_DataType.SelectedIndex<0)
            {
                new FrmMsgBoxWithoutAck("操作变量失败：请选择数据类型", "操作变量").ShowDialog();
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
        /// 用来读取Excel中的Variable，
        /// </summary>
        /// <returns></returns>
        public List<Variable> GetAllVariable()
        {
            return MiniExcel.Query<Variable>(varPath).ToList();
        }

        /// <summary>
        /// 通过遍历寻找TotalVariable的集合，判断是否和输入的VarName相同
        /// 存在返回true，不存在返回false
        /// </summary>
        /// <param name="varName">输入的varName</param>
        /// <returns></returns>
        private bool IsVariableNameExits(string varName)
        {
            return this.TotalVariable.FindAll(c => c.VarName==varName).ToList().Count>0;
        }


        /// <summary>
        /// 刷线DataGridView的数据
        /// </summary>
        public void NewDataGridView()
        {
            //这里需要先得到我们需要进行判断的Variable集合
            var list = GetVariableByGroupName(this.cmb_GroupName.Text);
            //第一次刷新数据的时候，因为TotalGroup在Excel没有读取到数据为空
            if (list!=null&&list.Count>0)
            {
                this.dgv_Main.DataSource=null;
                this.dgv_Main.DataSource=list;
            }
            //当我们删除最后个元素时，也无法刷新DataGridView，所以我们要返回null
            else
            {
                this.dgv_Main.DataSource=null;
            }
        }

        /// <summary>
        /// 根据指定的Group组名，筛选出来所有的是满足要求通信组名的Variable变量
        /// </summary>
        /// <param name="groupName">指定的groupName</param>
        /// <returns></returns>
        public List<Variable> GetVariableByGroupName(string groupName)
        {
            if (groupName.Trim().Length==0)
            {
                return this.TotalVariable;
            }
            else
            {
                return this.TotalVariable.FindAll(c=>c.GroupName==groupName).ToList();
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


        /// <summary>
        /// 单击取反CheckBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbk_Click(object sender,EventArgs e)
        {
            //多种情况，简单来说，修改本身，直接取反，如果是上升沿警报，现在要改为下降沿警报，则取消上升沿勾选，下降沿报警勾选
        }
    }
}
