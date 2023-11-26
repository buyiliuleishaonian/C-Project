using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wen.ControlLib
{
    /// <summary>
    /// Panel加强版，窗体空间很多，有一定的闪烁，
    /// 在窗体下，用panel加强版当作底层来解决整个问题,也就是将一个panel加强版控件当作背景图片
    /// </summary>
    public partial class PanelEnhanced : Panel
    {
        public PanelEnhanced()
        {
            InitializeComponent();
        }


        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //重载基类的背景擦除方法

            //解决窗体刷新，放大和闪烁
            
            return;
        }


        /// <summary>
        /// 在控件上自定义绘制
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            //使用双缓冲
            this.DoubleBuffered= true;
            //如果容器控件 含有的绘制不为null
            //1、保证绘制抗锯齿形
            //2、将绘制一个矩形，在容器控件的范围内
            if (this.BackgroundImage!=null)
            {
                e.Graphics.SmoothingMode=System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                e.Graphics.DrawImage(this.BackgroundImage,new Rectangle(0,0,this.Width,this.Height)
                    ,0,0,this.BackgroundImage.Width,this.BackgroundImage.Height,GraphicsUnit.Pixel);
            }
            base.OnPaint(e);

        }
    }
}
