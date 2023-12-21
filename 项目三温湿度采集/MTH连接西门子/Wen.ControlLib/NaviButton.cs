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
    /// 此处就是单击控件默认生成一个Click事件
    /// </summary>
    [DefaultEvent("DoubleClick")]
    public partial class NaviButton : UserControl
    {

        public NaviButton()
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

        //添加两个属性,用propfull快捷指令
        private bool _isSelected=false;
        [Browsable(true)]
        [Category("自定义")]
        [Description("设置或显示控件是否被选中")]

        public bool IsSelected
        {
            get { return _isSelected; }
            set { _isSelected = value;
                UpdateImage();
            }
        }

        private bool _IsLeft=true;
        [Browsable(true)]
        [Category("自定义")]
        [Description("设置或显示导航按钮是否为左边")]

        public bool IsLeft
        {
            get { return _IsLeft; }
            set { _IsLeft= value;
                UpdateImage();
            }
        }

        private string  _titleName="导航按钮";
        [Browsable(true)]
        [Category("自定义")]
        [Description("显示按钮文本内容")]
        /// <summary>
        /// 设定导航按钮文本内容
        /// </summary>
        public string  TitleName
        {
            get { return _titleName; }
            set { 
                _titleName = value;
                this.lbl_Title.Text=_titleName;
            }
        }



        /// <summary>
        /// 统一更新背景
        /// </summary>
        private void UpdateImage()
        {
            //通过判断IsLeft，来判断是否选中了左边，并且将背景图片修改为相对应的图片
            //判断是否被选中，左边还是右边
            //如果是左边，判断控件是否被选中，修改对应背景图片BackGroundImage
            if (this.IsLeft)
            {
                this.BackgroundImage=IsSelected ? Properties.Resources.LeftSelected : Properties.Resources.LeftUnSelected;
            }
            else
            {
                this.BackgroundImage=IsSelected? Properties.Resources.RightSelected:Properties.Resources.RightUnSelected;
            }
        }

        //添加一个事件，保证单击此控件，触发控件的Text更改，以及BackGroundImage
        public new EventHandler Click;
        [Browsable(true)]
        [Category("自定义单击事件")]
        [Description("设置或显示导航按钮文本内容")]

        /// <summary>
        /// 单击控件中的Label，判断是否已经创建了一个单击事件，创建了，就调用该事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbl_Title_Click(object sender, EventArgs e)
        {
            this.Click?.Invoke(this, e);
        }
    }
}
