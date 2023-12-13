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
using Wen.Common;
using Wen.MTHBLL;

namespace Wen.THproject
{
    /// <summary>
    /// 用户管理窗体
    /// </summary>
    public partial class FrmUserMange : Form
    {

        //创建一个SysAdminBll对象，来现对管理员的业务逻辑操作
        public SysAdminBLL sysadminBll = new SysAdminBLL();
        //创建一个SysAdminModel对象的List集合，来显示当前程序的管理员的信息
        public List<SysAdminModel> sysadmins = new List<SysAdminModel>();

        public FrmUserMange()
        {
            InitializeComponent();
            //DataGridView取消自动生成列
            this.dgv_UserManger.AutoGenerateColumns = false;
            //更新所有管理员的信息
            UpdateSysAdmin();
        }

        #region 封装修改当前用户的账号方法
        /// <summary>
        /// 每当所有管理员,当某个管理员信息修改或者变更之后，就在窗体上显示对应的更改
        /// </summary>
        /// <returns></returns>
        private void UpdateSysAdmin()
        {
            //查询所有管理员的信息
            sysadmins=sysadminBll.GetSysAdminList();
            if (sysadmins.Count>0)
            {
                this.dgv_UserManger.DataSource=null;
                this.dgv_UserManger.DataSource=sysadmins;
            }
        }
        #endregion


        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AddSysAdmin_Click(object sender, EventArgs e)
        {
            //先要判断，用户名，密码，确认密码是否为空，是否符合规范
            //判断用户名是否存在
            //判断两次密码是否一致
            //添加用户，用户名，密码，以及权限
            //然后刷新dgv_UserManage
            //添加用户失败，就弹窗
            #region 验证信息是否正确
            if (!(this.txt_LoginPwd.Text.ToString().Trim().Length!=0))
            {
                new FrmMsgBoxWithoutAck("密码不能为空", "密码错误").ShowDialog();
                return;
            }
            if (!(this.txt_LoginName.Text.ToString().Trim().Length!=0))
            {
                new FrmMsgBoxWithoutAck("用户名不能为空", "用户名错误").ShowDialog();
                return;
            }
            if (!(this.txt_LoginPwd2.Text.ToString().Trim().Length!=0))
            {
                new FrmMsgBoxWithoutAck("确认密码不能为空", "确认密码错误").ShowDialog();
                return;
            }
            if ((this.txt_LoginPwd.Text.ToString().Trim()!=this.txt_LoginPwd2.Text.ToString().Trim()))
            {
                new FrmMsgBoxWithoutAck("两次密码不一致", "密码错误").ShowDialog();
                return;
            }
            if (this.sysadmins.Where(c => c.LoginName==this.txt_LoginName.Text.ToString().Trim()).ToList().Count!=0)
            {
                new FrmMsgBoxWithoutAck("用户名已存在", "用户名错误").ShowDialog();
                return;
            }
            #endregion

            SysAdminModel sysadmin = new SysAdminModel()
            {
                LoginName=this.txt_LoginName.Text.ToString().Trim(),
                LoginPwd=this.txt_LoginPwd.Text.ToString().Trim(),
                ParamSet=this.chk_ParamSet.Checked,
                Recipe=this.chk_Recipe.Checked,
                HistoryLog=this.chk_HistoryLog.Checked,
                HistoryTrend=this.chk_HistoryTrend.Checked,
                UserMange=this.chk_UserMange.Checked
            };
            bool result = sysadminBll.AddSysAdmin(sysadmin);
            if (result)
            {
                new FrmMsgBoxWithoutAck("添加用户成功", "添加用户").ShowDialog();
                UpdateSysAdmin();
            }
            else
            {
                new FrmMsgBoxWithoutAck("添加用户失败，检查所填写信息", "添加用户").ShowDialog();
            }
        }
        /// <summary>
        /// 修改用户权限
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_UpdateUser_Click(object sender, EventArgs e)
        {
            #region 验证信息是否正确
            if (!(this.txt_LoginPwd.Text.ToString().Trim().Length!=0))
            {
                new FrmMsgBoxWithoutAck("密码不能为空", "密码错误").ShowDialog();
                return;
            }
            if (!(this.txt_LoginName.Text.ToString().Trim().Length!=0))
            {
                new FrmMsgBoxWithoutAck("用户名不能为空", "用户名错误").ShowDialog();
                return;
            }
            if (!(this.txt_LoginPwd2.Text.ToString().Trim().Length!=0))
            {
                new FrmMsgBoxWithoutAck("确认密码不能为空", "确认密码错误").ShowDialog();
                return;
            }
            if ((this.txt_LoginPwd.Text.ToString().Trim()!=this.txt_LoginPwd2.Text.ToString().Trim()))
            {
                new FrmMsgBoxWithoutAck("两次密码不一致", "密码错误").ShowDialog();
                return;
            }
            if (this.sysadmins.Where(c => c.LoginName==this.txt_LoginName.Text.ToString().Trim()).ToList().Count==0)
            {
                new FrmMsgBoxWithoutAck("用户名不存在", "用户名错误").ShowDialog();
                return;
            }
            #endregion

            //判断TextBox显示的名称，和在DataGridView中的选中的名称是否一致
            if (!(this.txt_LoginName.Text.ToString()==this.dgv_UserManger.CurrentRow.Cells["LoginName"].Value.ToString()))
            {
                new FrmMsgBoxWithoutAck("当前用户和表格中选中的用户不一致", "修改用户").ShowDialog();
                return;
            }

            //然后在封装的新SysAdminModel对象中，修改对应的权限,此时的封装需要加上LoginID
            SysAdminModel sysadmin = new SysAdminModel()
            {
                LoginId=Convert.ToInt32(this.dgv_UserManger.CurrentRow.Cells["LoginId"].Value),
                LoginName=this.txt_LoginName.Text.ToString().Trim(),
                LoginPwd=this.txt_LoginPwd.Text.ToString().Trim(),
                ParamSet=this.chk_ParamSet.Checked,
                Recipe=this.chk_Recipe.Checked,
                HistoryLog=this.chk_HistoryLog.Checked,
                HistoryTrend=this.chk_HistoryTrend.Checked,
                UserMange=this.chk_UserMange.Checked
            };
            //判断修改是否成功,如果成功，更新用户在DataGridView中的信息
            if (sysadminBll.UpdateSysAdmin(sysadmin))
            {
                UpdateSysAdmin();
            }
            else
            {
                new FrmMsgBoxWithoutAck("修改用户失败", "修改用户").ShowDialog();
                return;
            }
        }

        /// <summary>
        /// 删除用户信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DeleteUser_Click(object sender, EventArgs e)
        {
            #region 验证信息是否正确
            if (!(this.txt_LoginPwd.Text.ToString().Trim().Length!=0))
            {
                new FrmMsgBoxWithoutAck("密码不能为空", "密码错误").ShowDialog();
                return;
            }
            if (!(this.txt_LoginName.Text.ToString().Trim().Length!=0))
            {
                new FrmMsgBoxWithoutAck("用户名不能为空", "用户名错误").ShowDialog();
                return;
            }
            if (!(this.txt_LoginPwd2.Text.ToString().Trim().Length!=0))
            {
                new FrmMsgBoxWithoutAck("确认密码不能为空", "确认密码错误").ShowDialog();
                return;
            }
            if ((this.txt_LoginPwd.Text.ToString().Trim()!=this.txt_LoginPwd2.Text.ToString().Trim()))
            {
                new FrmMsgBoxWithoutAck("两次密码不一致", "密码错误").ShowDialog();
                return;
            }
            if (this.sysadmins.Where(c => c.LoginName==this.txt_LoginName.Text.ToString().Trim()).ToList().Count==0)
            {
                new FrmMsgBoxWithoutAck("用户名不存在", "用户名错误").ShowDialog();
                return;
            }
            #endregion

            //根据id删除
            //也是根据当前选中的DataGridView中的LoginID来删除
            if (sysadminBll.DeleteSysAdmin(Convert.ToInt32(this.dgv_UserManger.CurrentRow.Cells["LoginId"].Value)))
            {
                UpdateSysAdmin();
            }
            else
            {
                new FrmMsgBoxWithoutAck("删除用户失败", "删除用户").ShowDialog();
            }
        }

        /// <summary>
        /// 清空信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            //也就是在UI层将所有的TextBox的Text属性设置为空，并且CheckBoxEX的Checked属性设置为false
            this.txt_LoginName.Text=string.Empty;
            this.txt_LoginPwd.Text=string.Empty;
            this.txt_LoginPwd2.Text=string.Empty;
            SetCheckBoxExChecked(false);
        }
        /// <summary>
        /// 全选或全不选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btn_SelectAll_Click(object sender, EventArgs e)
        {
            if (this.chk_ParamSet.Checked==true)
            {
                SetCheckBoxExChecked(false);
            }
            else
            {
                SetCheckBoxExChecked(true);
            }
        }

        /// <summary>
        /// 添加行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_UserManger_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewStyle.DgvRowPostPaint(this.dgv_UserManger, e);
        }

        /// <summary>
        /// 选中某行，将对应的信息显示在TextBox中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_UserManger_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                this.txt_LoginName.Text=this.dgv_UserManger.Rows[e.RowIndex].Cells["LoginName"].Value.ToString();
                this.txt_LoginPwd.Text=this.dgv_UserManger.Rows[e.RowIndex].Cells["LoginPwd"].Value.ToString();
                this.txt_LoginPwd2.Text=this.dgv_UserManger.Rows[e.RowIndex].Cells["LoginPwd"].Value.ToString();
                this.chk_ParamSet.Checked=Convert.ToBoolean(this.dgv_UserManger.Rows[e.RowIndex].Cells["ParamSet"].Value);
                this.chk_Recipe.Checked=Convert.ToBoolean(this.dgv_UserManger.Rows[e.RowIndex].Cells["Recipe"].Value);
                this.chk_HistoryLog.Checked=Convert.ToBoolean(this.dgv_UserManger.Rows[e.RowIndex].Cells["HistoryLog"].Value);
                this.chk_HistoryTrend.Checked=Convert.ToBoolean(this.dgv_UserManger.Rows[e.RowIndex].Cells["HistoryTrend"].Value.ToString());
                this.chk_UserMange.Checked=Convert.ToBoolean(this.dgv_UserManger.Rows[e.RowIndex].Cells["UserMange"].Value);
            }
        }

        //封装一个方法，将CheckBoxEx的checked属性设置为False或者True
        /// <summary>
        /// 将所有的CheckBoxEx的checked属性设置为False或者True
        /// </summary>
        /// <param name="flag"></param>
        private void SetCheckBoxExChecked(bool flag)
        {
            this.chk_ParamSet.Checked=flag;
            this.chk_Recipe.Checked=flag;
            this.chk_HistoryLog.Checked=flag;
            this.chk_HistoryTrend.Checked=flag;
            this.chk_UserMange.Checked=flag;
        }

        /// <summary>
        /// 就是将Ture和False变换为启用或禁止
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_UserManger_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //需要先判断是否Rows.Count>=0，同时，只能修改权限
            if (e.RowIndex>=0&&e.ColumnIndex>=2)
            {
                if (e.Value.ToString()=="True")
                {
                    e.Value="启用";
                }
                else if (e.Value.ToString()=="False")
                {
                    e.Value="禁止";
                }
            }
        }
    }
}
