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
    /// 扩展Panel控件
    /// </summary>
    public partial class PanelEx : Panel
    {
        public PanelEx()
        {
            InitializeComponent();
            //设置控件样式
            //提高绘制的性能，因为只在需要时才重绘控件。
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            //双缓冲绘制可以减少闪烁和绘制的不连贯，通过在后台绘制控件，
            //然后一次性将整个绘制结果显示在屏幕上，提高了绘制的平滑性和视觉效果
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            //确保控件会在大小调整后进行重绘，以适应新的大小
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            //这一行表明控件可以被选中
            this.SetStyle(ControlStyles.Selectable, true);
            //这一行表明控件支持透明的背景色
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        //需要设定立即生效代码，然后绘制

        //添加对所处容器的上下左右距离的四个属性和字段,Top,Bottom,Left,Right
        private int _leftGap = 1;
        [Browsable(true)]
        [Category("自定义")]
        [Description("距离上边距")]
        public int LeftGap
        {
            get { return _leftGap; }
            set
            {
                _leftGap = value;
                this.InitLayout();
            }
        }

        private int _rightGap = 1;
        [Browsable(true)]
        [Category("自定义")]
        [Description("距离右边距")]

        public int RightGap
        {
            get { return _rightGap; }
            set
            {
                _rightGap= value;
                this.InitLayout();
            }
        }

        private int _topGap = 1;
        [Browsable(true)]
        [Category("自定义")]
        [Description("距离上边距")]
        public int TopGap
        {
            get { return _topGap; }
            set
            {
                _topGap = value;
                this.InitLayout();
            }
        }

        private int _bottomGap = 1;
        [Browsable(true)]
        [Category("自定义")]
        [Description("距离下边距")]
        public int BottomGap
        {
            get { return _bottomGap; }
            set
            {
                _bottomGap = value;
                this.Invalidate();
            }
        }

        //添加边框宽度bordWidth，并设定边框的颜色color
        private int _bordWidth = 2;
        [Browsable(true)]
        [Category("自定义")]
        [Description("边框宽度")]
        public int BordWidth
        {
            get { return _bordWidth; }
            set
            {
                _bordWidth= value;
                this.Invalidate();
            }
        }
        private Color _bordColor = Color.FromArgb(35, 255, 253);

        public Color BordColor
        {
            get { return _bordColor; }
            set
            {
                _bordColor = value;
                this.Invalidate();
            }
        }



        //创建一个对应Panel虚方法的方法
        /// <summary>
        /// 绘制PanelEx控件
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            //首先需要创建绘画的对象，第二创建画板，笔,然后需要确定绘画的坐标
            //需要确定矩形的虚线，需要知道长宽，并且明确知道坐标
            //创建绘画对象
            Graphics gph = e.Graphics;
            //创建图形的要求，长宽，坐标
            float x = LeftGap+BordWidth*0.5f;
            float y = TopGap+BordWidth*0.5f;
            float width = this.Width-LeftGap-RightGap-BordWidth;
            float heigth = this.Height-TopGap-BottomGap-BordWidth;
            //创建绘画的笔
            Pen p = new Pen(BordColor,BordWidth);
            //完成绘画
            gph.DrawRectangle(p, x, y, width, heigth);
        }
    }
}
