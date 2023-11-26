using MTHModels;
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
    public partial class RecipeControl : UserControl
    {
        public RecipeControl()
        {
            InitializeComponent();
        }

        private string title = "1#站点";
        [Browsable(true)]
        [Category("自定义")]
        [Description("设定或获取控件的抬头")]
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                this.titleControl1.TitleName = value;
                this.textSetEX1.TitleName=title+"温度高限";
                this.textSetEX2.TitleName=title+"温度低限";
                this.textSetEX3.TitleName=title+"湿度高限";
                this.textSetEX4.TitleName=title+"湿度低限";
            }
        }

        //添加一下配方管理的类对象
        private RecipeParam recipeParam = new RecipeParam();
        [Browsable(false)]

        /// <summary>
        /// 将值更新到界面，也可以通过界面得到值
        /// 也可以通过代码得到值
        /// </summary>
        /// <returns></returns>
        public RecipeParam RecipeParam 
        {
            get {
                recipeParam=GetRecipeParam();
                return recipeParam; }
            set { recipeParam=value;    
                SetRecipeParam(recipeParam);
            }
        }

        /// <summary>
        /// 得到一个RecipeParam对象
        /// </summary>
        /// <returns></returns>
        private RecipeParam GetRecipeParam()
        {
            return new RecipeParam()
            {
                //将窗体的值返回给RecipeParam对象
                TempHight= this.textSetEX1.CurrentValue,
                TempLow=this.textSetEX2.CurrentValue,
                HumidityHight=this.textSetEX3.CurrentValue,
                HumidityLow=this.textSetEX4.CurrentValue,
                TempAlarmEnalbe=this.checkBoxEX1.Checked,
                HumidityEnalbe=this.checkBoxEX2.Checked,
            };
        }

        /// <summary>
        /// 设定一个RecipeParam对象
        /// </summary>
        /// <returns></returns>
        private void SetRecipeParam(RecipeParam rp)
        {
            //将RecipeParam对象的值赋值给窗体
            this.textSetEX1.CurrentValue = rp.TempHight;
            this.textSetEX2.CurrentValue = rp.TempLow;
            this.textSetEX3.CurrentValue=rp.HumidityHight;
            this.textSetEX4.CurrentValue=recipeParam.HumidityLow;
            this.checkBoxEX1.Checked=rp.TempAlarmEnalbe;
            this.checkBoxEX2.Checked=rp.HumidityEnalbe;
        }
    }
}
