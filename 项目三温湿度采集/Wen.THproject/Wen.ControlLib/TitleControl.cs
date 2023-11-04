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
    public partial class TitleControl : UserControl
    {
        /// <summary>
        /// Title控件
        /// </summary>
        public TitleControl()
        {
            InitializeComponent();
            //设定控件样式
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.Selectable, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        private string titLeName;
        [Browsable(true)]
        [Category("自定义")]
        [Description("设定或获取Title")]
        public string TitleName
        {
            get { return titLeName; }
            set { titLeName = value;
                this.lbl_Title.Text=titLeName;
            }
        }

    }
}
