using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wen.ControlZoom;

namespace Wen.TestControlZoom
{
    public struct ControlParams
    {
        public float Width;
        public float Height;
        public float Left;
        public float Top;
        public float Size;
    }
    public partial class Form1 : Form
    {
        private ControlZooms controlZoom = new ControlZooms();
        //创建两个参数来得到窗体的原始值
        float FHeigth;
        float FWidth;
        private Dictionary<string, ControlParams> dic = new Dictionary<string, ControlParams>();
        public Form1()
        {
            InitializeComponent();
            FHeigth=this.Height;
            FWidth=this.Width;
            AddControlParams(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //controlZoom.FHeight=this.Height;
            //controlZoom.FWidth=this.Width;
            //controlZoom.AddControlParams(this);

        }

        /// <summary>
        /// 对接每次窗体坐标更改之后的放大缩小比例
        /// </summary>
        float widthRatio;
        float heigthRatio;
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this. widthRatio = (this.Width)/FWidth;
            this. heigthRatio = (this.Height)/FHeigth;

            //controlZoom.SetControlParams(this, widthRatio, heigthRatio);
            Task  task=new Task((new Action( () =>
            {
                SetControlParams();
            })));
            task.Start(TaskScheduler.FromCurrentSynchronizationContext());
        }

        /// <summary>
        /// 遍历窗体中所有的控件的Left，Height，Width，Top，Size，Name属性对应的参数封装
        /// </summary>
        /// <param name="ctl"></param>
        public void AddControlParams(Control ctl)
        {
            foreach (Control item in ctl.Controls)
            {
                ControlParams controlParams = new ControlParams()
                {
                    Left = item.Left,
                    Width = item.Width,
                    Height = item.Height,
                    Top = item.Top,
                    Size=item.Font.Size,
                };
                dic.Add(item.Name, controlParams);
                //使用递归，防止出现，在窗体中的容器控件里面还存在控件
                if (item.Controls.Count>0) AddControlParams(item);
            }
        }

        /// <summary>
        /// 改变窗体控件中的大小
        /// </summary>
        public void SetControlParams()
        {
            foreach (Control item in this.Controls)
            {
                if (dic.ContainsKey(item.Name))
                {
                    item.Width=(int)(dic[item.Name].Width*widthRatio);
                    item.Height=(int)(dic[item.Name].Height*heigthRatio);
                    item.Left=(int)(dic[item.Name].Left*widthRatio);
                    item.Top=(int)(dic[item.Name].Top*heigthRatio);
                    item.Font= new Font(item.Font.Name, dic[item.Name].Size*heigthRatio);
                }
                if (item.Controls.Count>0) SetControlParams();
            }
        }
    }
}
