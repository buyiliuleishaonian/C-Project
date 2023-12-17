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
    /// <summary>
    /// 绘制的是仪表盘控件
    /// </summary>
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
            //表明控件可以被选中
            this.SetStyle(ControlStyles.Selectable,true);
            //表明控件的透明度
            this.SetStyle(ControlStyles.SupportsTransparentBackColor,true);

            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment =StringAlignment.Center;
        }
        private StringFormat stringFormat=new   StringFormat();

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

        private float tempScale = 0.6f;
        [Browsable(true)]
        [Category("自定义")]
        [Description("设定或获取温度内环比例，相对于控件的宽度的比列，用来获取x值")]
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


        private float humidithScale = 0.35f;
        [Browsable(true)]
        [Category("自定义")]
        [Description("设定或获取湿度内环比例,相对于控件的宽度的比列，用来获取x值")]
        public float HumidityScale
        {
            get { return humidithScale; }
            set
            {
                if (value>1.0f) return;
                humidithScale = value;
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
            set { inThickness = value;
                this.Invalidate();
            }
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

        private float rangeMin = 0.0f;
        [Browsable(true)]
        [Category("自定义")]
        [Description("设定或获取刻度低限")]
        public float RangeMin
        {
            get { return rangeMin; }
            set
            {
                if (value>RangeMax) return;
                rangeMin = value;
                this.Invalidate();
            }
        }

        private float rangeMax = 90.0f;
        [Browsable(true)]
        [Category("自定义")]
        [Description("设定或获取刻度高限")]
        public float RangeMax
        {
            get { return rangeMax; }
            set
            {
                if (value< this.RangeMin) return;
                rangeMax = value;
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
                if (value<this.RangeMin)
                {
                    value=this.RangeMin;
                }
                if (value>this.RangeMax)
                {
                    value = this.RangeMax;
                }
                tempValue = value;
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
                if (value<this.RangeMin)
                {
                    value= this.RangeMin;
                }
                if (value>this.RangeMax)
                {
                    value = this.RangeMax;
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
            #region  绘制外圆环
            //规定this.width<=20&&this.higth<=20，无效
            //高度小于宽度的一半，无效
            if (this.Width<=20||this.Height<=20) return;
            if (this.Height<this.Width*0.5) return;
            //先画外环，外环报警（按照顺时针为角度），绘制圆弧，需要提供一个矩形的起始坐标位置10，10
            //以此在矩形内画内切圆，所以长宽相等
            //绘画刻度线：转移坐标系，TranslateTranform()；旋转坐标系RotateTranSform();还需要判断角度，是在报警还是外圆
            Pen pen = new Pen(AlarmColor, OutThickness);
            //绘制报警
            graphics.DrawArc(pen, new RectangleF(10, 10, this.Width-20, this.Width-20), 180, AlarmAngel);
            //绘制外环
            pen=new Pen(RingColor, OutThickness);
            graphics.DrawArc(pen, new RectangleF(10, 10, this.Width-20, this.Width-20), 180+AlarmAngel, 180-AlarmAngel);

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
            #endregion

            #region  绘制刻度线文本


            // 绘制刻度值
            // 1、首先讲坐标系转到回到平移之后的坐标系
            graphics.RotateTransform(-210);
            graphics.RotateTransform(90);
            //2、绘制刻度，每个间隔值是多少
            float rangeAvg = (RangeMax-RangeMin)%6==0 ? Convert.ToSingle(rangeMax-RangeMin)/6 :
                Convert.ToSingle(((rangeMax-rangeMin)/6).ToString("f1"));

            // 3、要循环绘制，顺时针标记，从小到大标记，从-180度的地方开始标记，这里就是依靠刻度比列（通过最大最小值除以标记总个数）
            for (int i = 0; i < 7; i++)
            {
                float slace = -180f+i*30f;
                // 首先要得到需要绘制的高度和宽度，坐标
                // 4、通过Grapics，算出文本大小
                float x = Convert.ToSingle(this.Width*this.TextScale*0.5f*Math.Cos(slace*Math.PI/180.0f));
                float y = Convert.ToSingle(this.Width*this.TextScale*0.5f*Math.Sin(slace*Math.PI/180.0f));

                string text = ((rangeAvg*i+RangeMin)).ToString();
                //存储一对有序的浮点数对，一般为矩形的高度和宽度
                SizeF size = graphics.MeasureString(text, this.Font);
                //存储一组浮点数（4个）,表示坐标，长，宽
                RectangleF rc = new RectangleF(x-size.Width*0.5f, y, size.Width, size.Height);
                graphics.DrawString(text, this.Font, new SolidBrush(this.ForeColor), rc, stringFormat);
            }
            #endregion

            //绘制温湿度的圆弧
            //1、首先得到读取到TempSlace的值，通过计算是多个刻度值来绘制,角度
            //2、创建pen,颜色，宽度
            pen=new Pen(tempColor, this.inThickness);
            float sweepAangle = (tempValue-rangeMin)/(rangeMax-RangeMin)*180.0f;

            //3、绘制圆弧的坐标，和绘制报警圆弧，是一样的
            #region  方法一，绘制温湿度 圆弧
            //温度
            graphics.DrawArc(pen, new RectangleF(this.Width*0.5f*this.TempScale*(-1.0f), this.Width*0.5f*this.TempScale*(-1f),
                (this.Width*this.TempScale), (this.Width*this.TempScale)), -180f, sweepAangle);

            //湿度
            pen=new Pen(humidityColor,InThickness);
            float humidityAangle = (humidityValue-rangeMin)/(rangeMax-rangeMin)*180.0f;
            graphics.DrawArc(pen, new RectangleF(this.Width*0.5f*this.HumidityScale*(-1.0f), this.Width*0.5f*this.HumidityScale*(-1f),
               (this.Width*this.HumidityScale), (this.Width*this.HumidityScale)), -180f, humidityAangle);
            #endregion

            //#region 方法二 将坐标系平移回去
            //graphics.TranslateTransform(-this.Width/2,-this.Width/2);
            ////绘制温度
            //graphics.DrawArc(pen, new RectangleF((this.Width-this.Width*this.TempScale)/2, (this.Width-this.Width*this.TempScale)/2, (this.Width*this.TempScale), (this.Width*this.TempScale)), -180f, sweepAangle);
            ////绘制湿度
            //graphics.DrawArc(pen,new RectangleF((this.Width-this.Width*this.HumidityScale)/2, (this.Width-this.Width*this.HumidityScale)/2,(this.Width*this.HumidityScale),(this.Width*this.HumidityScale)),-180f,humidityAangle);
            //#endregion
        }
    }
}
