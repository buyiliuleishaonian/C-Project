using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wen.ControlZoom
{
    public struct ControlParams
    {
        public float Width;
        public float Height;
        public float Left;
        public float Top;
        public float Size;
    }
    public class ControlZooms
    {

        /// <summary>
        /// 通过结构类型设定控件的，距离容器上下左右距离以及坐标
        /// </summary>
       
        //设定两个属性来接收窗体的  长宽
        public float FWidth { get; set; }
        public float FHeight { get; set; }

        public Dictionary<string, ControlParams> dic = new Dictionary<string, ControlParams>();

        /// <summary>
        /// 将窗体中控件的数据取出
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
                if(item.Controls.Count>0) AddControlParams(item);
            }
        }

        /// <summary>
        /// 遍历容器中的控件，按照窗体
        /// </summary>
        /// <param name="ctl"></param>
        /// <param name="widthRatio"></param>
        /// <param name="heightRatio"></param>
        public void SetControlParams(Control ctl,float widthRatio,float heightRatio) 
        {
            foreach (Control item in ctl.Controls)
            {
                if (dic.ContainsKey(item.Name))
                {
                    item.Width=(int)(dic[item.Name].Width*widthRatio);
                    item.Height=(int)(dic[item.Name].Height*heightRatio);
                    item.Left=(int)(dic[item.Name].Left*widthRatio);
                    item.Top=(int)(dic[item.Name].Top*heightRatio);
                    item.Font= new System.Drawing.Font(item.Font.Name,dic[item.Name].Size*heightRatio);
                }
                if (item.Controls.Count>0) SetControlParams(item,widthRatio,heightRatio);
            }
        }
    }
}
