using System;
using System.Drawing;
using System.Windows.Forms;

namespace Wen.THproject
{
    public partial class FrmModify : Form
    {
        public FrmModify(string titleName,string bindVarName,string currentValue)
        {
            InitializeComponent();
            this.titleControl1.TitleName = titleName;
            this.lbl_Title.Text=bindVarName;
            this.lbl_CurrentValue.Text=currentValue;    

            //聚焦到写入、
            this.txt_SetValue.Focus();
            this.txt_SetValue.SelectAll();
        }

        /// <summary>
        /// 确定写入的标签
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (this.txt_SetValue.Text!=null&&this.txt_SetValue.Text.ToString().Trim().Length>0)
            {
                bool var = CommonModel.CommonWrite(this.lbl_Title.Text, this.txt_SetValue.Text);
                if (var)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    new FrmMsgBoxWithoutAck("参数修改失败，请检查参数","参数修改");
                }
            }
        }

        /// <summary>
        /// 取消修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_No_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.No;
        }

        /// <summary>
        /// 关闭窗体等于取消修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Close_Click(object sender, EventArgs e)
        {
            btn_No_Click(null,null);
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

        /// <summary>
        /// 按下回车键就等于按下确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_SetValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txt_SetValue.Text!=null&&this.txt_SetValue.Text.ToString().Trim().Length>0)
            {
                if (e.KeyValue==13)
                {
                    btn_OK_Click(null,null);
                }
            }
        }
    }
}
