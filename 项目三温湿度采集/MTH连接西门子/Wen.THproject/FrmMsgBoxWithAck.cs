using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wen.THproject
{
    /// <summary>
    /// 有取消确认的弹窗
    /// </summary>
    public partial class FrmMsgBoxWithAck : Form
    {
        public FrmMsgBoxWithAck(string text,string title)
        {
            InitializeComponent();

            //设为顶层窗体
            this.TopMost = true;

            this.lbl_Title.Text=title;
            this.lbl_Text.Text=text;
        }

        /// <summary>
        /// 关闭窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Close_Click(object sender, EventArgs e)
        {
           this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// 确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.OK;
        }

        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_No_Click(object sender, EventArgs e)
        {
            btn_Close_Click(null,null);
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
            point=new Point(e.X,e.Y);
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
    }
}
