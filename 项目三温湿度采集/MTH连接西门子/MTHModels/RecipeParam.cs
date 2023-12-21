using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTHModels
{
    /// <summary>
    /// 对应配方管理的类
    /// </summary>
    public class RecipeParam
    {
        /// <summary>
        /// 温度高限
        /// </summary>
        public float TempHight { get; set; }
        /// <summary>
        /// 温度低限
        /// </summary>
        public float TempLow { get; set; }
        /// <summary>
        /// 湿度高限
        /// </summary>
        public float HumidityHight { get; set; }    
        /// <summary>
        /// 湿度低限
        /// </summary>
        public float HumidityLow { get; set; }  
        /// <summary>
        /// 温度报警启用
        /// </summary>
        public bool TempAlarmEnalbe { get; set; }
        /// <summary>
        /// 湿度报警启用
        /// </summary>
        public bool HumidityEnalbe { get; set; }
    }
}
