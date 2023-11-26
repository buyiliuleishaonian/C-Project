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
    /// 双击自定义的控件会产生以一个双击事件
    /// </summary>
    [DefaultEvent("ControlDoubleClick")]
    public partial class TextSetEX : UserControl
    {
        public TextSetEX()
        {
            InitializeComponent();
            //控件样式设置
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.Selectable, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        #region 自定义控件属性
        private string titleName = "1#站点温度高限";
        [Browsable(true)]
        [Category("自定义")]
        [Description("设置或获取控件名称")]

        public string TitleName
        {
            get { return titleName; }
            set
            {
                titleName = value;
                this.lbl_Title.Text=value;
            }
        }

        private string bindVarName = "模块1温度高限";
        [Browsable(true)]
        [Category("自定义")]
        [Description("设置或获取绑定名称")]

        public string BindVarName
        {
            get { return bindVarName; }
            set
            {
                bindVarName = value;
            }
        }

        private float currentValue = 0.0f;
        [Browsable(true)]
        [Category("自定义")]
        [Description("设置或获取绑定变量的当前数值")]
        public float CurrentValue
        {
            get {
                currentValue = Convert.ToSingle(this.num_Value.Value);
                return currentValue; }
            set
            {
                if (currentValue!=value)
                {
                    currentValue = value;
                    this.num_Value.Value=Convert.ToDecimal(value);
                }
            }
        }

        private string unit = "℃";
        [Browsable(true)]
        [Category("自定义")]
        [Description("设定或显示单位")]
        public string Unit
        {
            get { return unit; }
            set
            {
                unit = value;
                this.lbl_Unit.Text=value;
            }
        }
        #endregion
    }
}
