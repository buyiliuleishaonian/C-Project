using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wen.ControlLib
{
    public partial class DialPlate : UserControl
    {
        public DialPlate()
        {
            InitializeComponent();
            //表明控件只有需要时，重绘
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            ////表明控件双重绘制减少，闪烁，绘制完成直接呈现
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            ////表明控件在调整大小之后重绘
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        //重要代码，就是改变属性之后，马上进行控件重绘 this.Invalidate(),用于自定义控件的类

        #region 外环设计
        //设定 报警颜色alarmColor（36,184,196），圆环整体颜色ringColor(187,187,187)，报警角度alarmAngel
        //外环的宽度outThinckness int=8，
        private Color alarmColor = Color.FromArgb(36, 184, 196);
        [Browsable(true)]
        [Category("自定义")]
        [Description("设定或获取报警颜色")]
        public Color AlarmColor
        {
            get { return alarmColor; }
            set
            {
                alarmColor  = value;
                this.Invalidate();
            }
        }

        private Color ringColor = Color.FromArgb(187, 187, 187);
        [Browsable(true)]
        [Category("自定义")]
        [Description("设定或获取外环颜色")]
        public Color RingColor
        {
            get { return ringColor; }
            set
            {
                ringColor = value;
                this.Invalidate();
            }
        }

        private float alarmAngel = 120f;
        [Browsable(true)]
        [Category("自定义")]
        [Description("设定或获取报警角度")]
        public float AlarmAngel
        {
            get { return alarmAngel; }
            set
            {
                alarmAngel = value;
                this.Invalidate();
            }
        }

        private int outThickness = 8;
        [Browsable(true)]
        [Category("自定义")]
        [Description("设定或获取外环宽度")]
        public int OutThickness
        {
            get { return outThickness; }
            set
            {
                outThickness = value;
                this.Invalidate();
            }
        }
        #endregion

        #region  内环设计，比例scale，默认0.8f,低于1.0f，颜色，宽度,温度temperature，湿度humidity
        private float tempScale = 0.8f;
        [Browsable(true)]
        [Category("自定义")]
        [Description("设定或获取温度内环比例")]
        public float TempScale
        {
            get { return tempScale; }
            set
            {
                if (value>1.0f) return;
                tempScale = value;
                this.Invalidate();
            }
        }

        private Color tempColor = Color.FromArgb(36, 184, 196);
        [Browsable(true)]
        [Category("自定义")]
        [Description("设定或获取温度内环颜色")]
        public Color TempColor
        {
            get { return tempColor; }
            set
            {
                tempColor = value;
                this.Invalidate();
            }
        }


        private float humidithScale = 0.8f;
        [Browsable(true)]
        [Category("自定义")]
        [Description("设定或获取湿度内环比例")]
        public float HumidityScale
        {
            get { return tempScale; }
            set
            {
                if (value>1.0f) return;
                tempScale = value;
                this.Invalidate();
            }
        }

        private Color humidityColor = Color.FromArgb(36, 184, 196);
        [Browsable(true)]
        [Category("自定义")]
        [Description("设定或获取湿度内环颜色")]
        public Color HumidityColor
        {
            get { return humidityColor; }
            set
            {
                humidityColor = value;
                this.Invalidate();
            }
        }

        private int inThickness = 16;
        [Browsable(true)]
        [Category("自定义")]
        [Description("设定或获取内环宽度")]
        public int InThickness
        {
            get { return inThickness; }
            set { inThickness = value; }
        }

        #endregion

        #region  刻度环设计 比列，刻度环的上下极限
        private float textScale = 0.85f;
        [Browsable(true)]
        [Category("自定义")]
        [Description("设定或获取湿度内环比例")]
        public float TextScale
        {
            get { return textScale; }
            set
            {
                if (value>1.0f) return;
                textScale = value;
                this.Invalidate();
            }
        }

        private float ringMin = 0.0f;
        [Browsable(true)]
        [Category("自定义")]
        [Description("设定或获取刻度低限")]
        public float RingMin
        {
            get { return ringMin; }
            set
            {
                if (value>RingMax) return;
                ringMin = value;
                this.Invalidate();
            }
        }

        private float ringMax = 90.0f;
        [Browsable(true)]
        [Category("自定义")]
        [Description("设定或获取刻度高限")]
        public float RingMax
        {
            get { return ringMax; }
            set
            {
                if (value< this.RingMin) return;
                ringMax = value;
                this.Invalidate();
            }
        }
        #endregion

        #region 实时读取温湿度值
        private float tempValue = 10.0f;
        [Browsable(true)]
        [Category("自定义")]
        [Description("读取实时温度值")]
        public float TempValue
        {
            get
            {
                return tempValue;
            }
            set
            {
                if (value<this.RingMin)
                {
                    value=this.RingMin;
                }
                tempValue = value;
                if (tempValue>this.RingMax)
                {
                    tempValue = this.RingMax;
                }
                this.Invalidate();
            }
        }

        private float humidityValue = 10.0f;
        [Browsable(true)]
        [Category("自定义")]
        [Description("读取实时湿度值")]
        public float HumidityValue
        {
            get
            {
                return humidityValue;
            }
            set
            {
                if (value<this.RingMin)
                {
                    value= this.RingMin;
                }
                if (humidityValue>this.RingMax)
                {
                    humidityValue = this.RingMax;
                }
                humidityValue = value;
                this.Invalidate();
            }
        }
        #endregion


        //继承UserControl类的，绘制事件
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            //构建绘画对象，笔，颜色，绘制的图形（创建对应图形所需要的东西）
            Graphics graphics = e.Graphics;
            //表明绘制的直线，曲线，出现抗拒尺的形状，这意味着在绘制图形时，使用抗锯齿技术来平滑处理边缘，
            //以减少锯齿状的边缘，使图形看起来更加平滑和清晰。抗锯齿技术是为了改善图形的视觉质量。
            graphics.SmoothingMode=System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //这指定了在绘制文本时要使用 ClearType 技术以更好地渲染文本。
            //ClearType 是一种亚像素抗锯齿技术，用于改善文本的清晰度和可读性。
            graphics.TextRenderingHint=System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            //规定this.width<=20&&this.higth<=20，无效
            //高度小于宽度的一半，无效
            if (this.Width<=20||this.Height<=20) return;
            if (this.Height<this.Width*0.5) return;
            //先画外环，外环报警（按照顺时针为角度），绘制圆弧，需要提供一个矩形的起始坐标位置10，10
            //以此在矩形内画内切圆，所以长宽相等
            //绘画刻度线：转移坐标系，TranslateTranform()；旋转坐标系RotateTranSform();还需要判断角度，是在报警还是外圆
            Pen pen = new Pen(AlarmColor, OutThickness);
            //绘制报警
            graphics.DrawArc(pen, new Rectangle(10, 10, this.Width-20, this.Width-20), 180, AlarmAngel);
            //绘制外环
            pen=new Pen(RingColor, OutThickness);
            graphics.DrawArc(pen, new Rectangle(10, 10, this.Width-20, this.Width-20), 180+AlarmAngel, 180-AlarmAngel);

            //平移坐标系(一般坐标系以控件左上角为原点，向右为x正，向下为y正)
            graphics.TranslateTransform(this.Width/2, this.Width/2);
            //旋转坐标系
            graphics.RotateTransform(-90);
            //需要设定刻度线的背景颜色，毕竟，整个外环，包含报警和外环
            SolidBrush brush = null;
            //循环画出刻度线
            for (int i = 0; i < 7; i++)
            {
                if (i*30.0f<=alarmAngel) { brush= new SolidBrush(AlarmColor); }
                else { brush=new SolidBrush(RingColor); }
                float width = 6.0f;
                float hegiht = outThickness+4;
                float x = -3.0f;
                float y = (this.Width/2-10+hegiht/2)*(-1.0f);
                //填充一个矩形
                graphics.FillRectangle(brush, new RectangleF(x, y, width, hegiht));
                graphics.RotateTransform(30);
            }
            //在画内环，

            //显示刻度值
            //显示实时的温湿度值
        }
    }
}
