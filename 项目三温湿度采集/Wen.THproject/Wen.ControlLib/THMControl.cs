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
    /// 用来显示温湿度控件
    /// </summary>
    public partial class THMControl : UserControl
    {
        public THMControl()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint,true);
            this.SetStyle(ControlStyles.DoubleBuffer,true);
            this.SetStyle(ControlStyles.Selectable,true);
            this.SetStyle(ControlStyles.ResizeRedraw,true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor,true);
        }

        //设定属性，来更改控件的Title
        private string title;
        [Browsable(true)]
        [Category("自定义")]
        [Description("设定或获取控件开头")]
        public string  Title
        {
            get { return title; }
            set { title = value;
                this.lbl_Title.Text=value+"#号站点";
            }
        }

        //设定温湿度的属性值，不仅要显示出来，同时也要传递给DialPlate仪表盘中，绘制温湿度弧度的属性
        private string temp;
        [Browsable(true)]
        [Category("自定义")]
        [Description("设定或获取温度值")]
        public string Temp
        {
            get { return temp; }
            set { if (temp!=value)
                {
                    if (float.TryParse(value, out float val))
                    {
                        this.dialPlate1.TempValue = val;
                        this.temp=val.ToString();
                    }
                    else
                    {
                        this.temp="0.0";
                    }
                    this.lbl_Temp.Text=this.temp;
                }
            }
        }

        private string humidity;
        [Browsable(true)]
        [Category("自定义")]
        [Description("设定或获取湿度值")]
        public string Humidity  
        {
            get { return humidity; }
            set
            {
                if (humidity!=value)
                {
                    if (float.TryParse(value, out float val))
                    {
                        this.dialPlate1.HumidityValue = val;
                        this.humidity=val.ToString();
                    }
                    else
                    {
                        this.humidity="0.0";
                    }
                    this.lbl_Humidity.Text=this.humidity;
                }
            }
        }

        //设定状态背景
        private bool alarmColor;
        [Browsable(true)]
        [Category("自定义")]
        [Description("显示或获取报警休息")]
        public bool AlarmColor
        {
            get { return alarmColor; }
            set {
                alarmColor = value;
                this.lbl_Title.BackColor=alarmColor ? Color.Red:Color.FromArgb(36, 184, 196);
            }
        }

        //温度绑定的变量名称，湿度绑定的变量名称，状态绑定的变量名称
        /// <summary>
        /// w温度值绑定的变量名称
        /// </summary>
        public string TempValueName { get; set; } = string.Empty;
        /// <summary>
        /// 湿度值绑定的变量名称
        /// </summary>
        public string HumidityValueName { get; set; }=string.Empty;
        /// <summary>
        /// 报警地址绑定名称
        /// </summary>
        public string AlarmValueName { get; set; } = string.Empty;
    }
}
