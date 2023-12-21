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
    public partial class TextSet : UserControl
    {
        public TextSet()
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

        private string alarmVarName="模块1温度高1";
        [Browsable(true)]
        [Category("自定义")]
        [Description("设置或获取报警绑定的变量名称")]
        public string AlarmVarName
        {
            get { return alarmVarName; }
            set
            {
                alarmVarName = value;
            }
        }

        private string currentValue = "0.0";
        [Browsable(true)]
        [Category("自定义")]
        [Description("设置或获取绑定变量的当前数值")]
        public string CurrentValue
        {
            get { return currentValue; }
            set
            {
                if (currentValue!=value)
                {
                    currentValue = value;
                    this.lbl_Value.Text=value;
                }
            }
        }

        private bool isAlarm = false;
        [Browsable(true)]
        [Category("自定义")]
        [Description("设置或获取绑定模块是否报警")]
        public bool IsAlarm
        {
            get { return isAlarm; }
            set
            {
                if (isAlarm!=value)
                {
                    isAlarm = value;
                    this.led_Alarm.Value=value;
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
                if (this.titleName.Contains("温度"))
                {
                    value= "℃";
                     this.lbl_Unit.Text= "℃";
                        unit= value;
                    this.Invalidate();
                }
                else
                {
                    value="%";
                    this.lbl_Unit.Text="%";
                    unit=value;
                    this.Invalidate ();
                }
            }
        }
        #endregion

        #region 自定义事件

        public event EventHandler ControlDoubleClick;
        [Browsable(true)]
        [Category("自定义事件")]
        [Description("自定义双击事件")]
        private void lbl_Value_DoubleClick(object sender, EventArgs e)
        {
            this.ControlDoubleClick?.Invoke(this,e);
        }
        #endregion  
    }
}
