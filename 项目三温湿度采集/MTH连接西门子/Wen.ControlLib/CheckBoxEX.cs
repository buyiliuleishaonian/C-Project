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
    public partial class CheckBoxEX : CheckBox
    {
        /// <summary>
        /// 扩展一个CheckBox控件的组件
        /// </summary>
        public CheckBoxEX()
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

            //文本在文本框内，水平居中对齐
            this.stringFormat.Alignment = StringAlignment.Center;
            this.stringFormat.LineAlignment = StringAlignment.Center;
        }
        public StringFormat stringFormat = new StringFormat();

        //需要设定勾选款宽度，颜色
        private int doubleCheckBoxWidth = 30;
        [Browsable(true)]
        [Category("自定义")]
        [Description("设定或获取勾选框宽度")]
        public int DoubleCheckBoxWidth
        {
            get { return doubleCheckBoxWidth; }
            set
            {
                doubleCheckBoxWidth = value;
                this.Invalidate();
            }
        }

        private Color checkBoxColor = Color.White;
        [Browsable(true)]
        [Category("自定义")]
        [Description("设定或获取勾选框颜色")]
        public Color CheckBoxColor
        {
            get { return checkBoxColor; }
            set
            {
                checkBoxColor = value;
                this.Invalidate();
            }
        }

        private string textCheckBox = "复选框文本";
        [Browsable(true)]
        [Category("自定义")]
        [Description("设定或获取复选框文本本")]
        public string TextCheckBox
        {
            get { return textCheckBox; }
            set
            {
                textCheckBox = value;
                this.Invalidate();
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            //重绘背景板,将原有控件上的所有绘制清空
            base.OnPaintBackground(e);
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode=System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            graphics.TextRenderingHint=System.Drawing.Text.TextRenderingHint.AntiAlias;

            //声明两个矩形对象分别是checkRec，textRec
            //绘制两个矩形的时候，先将两个矩形背景色填充为白色  FillRectangle
            //需要给勾选框的矩形构建边界，因为控件最后的背景为改为透明
            //判断复选框，是否被勾选
            #region 所教学的方法绘制勾选框和文本框
            Rectangle checkRec;
            Rectangle textRec;
            CreateRectangles(out checkRec, out textRec);
            //定义单色画笔，用于填充封闭图形
            SolidBrush solidBrush = new SolidBrush(checkBoxColor);
            graphics.FillRectangle(solidBrush, checkRec);
            //graphics.FillRectangle(solidBrush, textRec);
            Pen pen = new Pen(Color.LightGray);
            graphics.DrawRectangle(pen, checkRec);
            //这里绘制的意思，就收集是否选择该控件，选中则绘制 勾选
            if (this.CheckState==CheckState.Checked)
            {
                GraphicChecked(graphics,checkRec,Color.Black);
            }
            //绘制文本
            graphics.DrawString(this.Text,this.Font,new SolidBrush(this.ForeColor),textRec,stringFormat);
            #endregion


            #region 自己的方法绘制勾选框和文本款
            //勾选框，和文本就是相当于两个 矩形框
            //1、勾选框
            //Pen pen = new Pen(this.CheckBoxColor);
            //float x = this.Width*0.1f;
            //float y = this.Width*0.1f;
            //RectangleF checkRec = new RectangleF(x, y, this.DoubleCheckBoxWidth, this.DoubleCheckBoxWidth);
            //graphics.DrawRectangle(pen, x, y, this.DoubleCheckBoxWidth, this.DoubleCheckBoxWidth);
            //if (this.CheckState==CheckState.Checked)
            //{
            //    GraphicChecked(graphics,checkRec,Color.Red); 
            //}

            ////2、文本框
            //SizeF size = graphics.MeasureString(textCheckBox, this.Font);
            //x = this.Width*0.3f;
            //y = this.Width*0.1f;
            //RectangleF rcf = new RectangleF(x, y, size.Width, size.Height);

            //graphics.DrawString(textCheckBox, this.Font, new SolidBrush(this.ForeColor), rcf, stringFormat);
            #endregion
        }


        //在绘制CheckRec，textRec矩形的方法，参数两个可以返回的矩形对象
        //首先确定CheckRec的坐标x为3，textRec坐标x为checkRec右边点的坐标+3
        /// <summary>
        /// 生成勾选框矩形和文本矩形
        /// </summary>
        /// <param name="checkRec">勾选框矩形</param>
        /// <param name="textRec">文本矩形</param>
        private void CreateRectangles(out Rectangle checkRec, out Rectangle textRec)
        {
            checkRec=new Rectangle(3, (this.Height-this.DoubleCheckBoxWidth)/2, this.doubleCheckBoxWidth, this.doubleCheckBoxWidth);
            textRec=new Rectangle(checkRec.Right+3, 0, this.Width-checkRec.Right-3, this.Height);
        }


        //勾选方法，参数绘画对象，颜色，矩形，勾选就是画三条直线，只不过是每次控件重绘，都必须重绘两条线
        /// <summary>
        /// 绘制勾选
        /// </summary>
        /// <param name="g">绘制对象</param>
        /// <param name="checkRec">绘制矩形，提供绘制的画纸</param>
        /// <param name="color">勾选的颜色</param>
        private void GraphicChecked(Graphics g, Rectangle checkRec, Color color)
        {
            //这里的坐标还是整个控件的坐标，所以需要考虑到这点
            Point midd = new Point(checkRec.X+checkRec.Width/2, Convert.ToInt32(checkRec.Y+ checkRec.Height*0.8));
            Point left = new Point(Convert.ToInt32(checkRec.X+checkRec.Width*0.2), Convert.ToInt32(checkRec.Y+checkRec.Height/2));
            Point regiht=new Point(Convert.ToInt32(checkRec.X+checkRec.Width*0.8), Convert.ToInt32(checkRec.Y+checkRec.Height*0.2));

            //创建画纸
            //Bitmap bit = new Bitmap(checkRec.Width,checkRec.Height);
            //g= Graphics.FromImage(bit);
            //绘制勾选
            g.DrawLine(new Pen(color),left,midd);
            g.DrawLine(new Pen(color),midd,regiht);

        }
    }
}
