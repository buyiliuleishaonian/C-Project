using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTHModels
{
    /// <summary>
    /// 实时数据类
    /// </summary>
    public class ActualData
    {
        //插入时间
        //1号站点的温湿度
        //2号站点的温湿度
        //3号站点的温湿度
        //4号站点的温湿度
        //5号站点的温湿度
        //6号站点的温湿度

        /// <summary>
        /// 插入时间
        /// </summary>
        public string InsertTime { get; set; }

        /// <summary>
        /// 模块1温度
        /// </summary>
        public string Station1Temp { get; set; }
        /// <summary>
        /// 模块1湿度
        /// </summary>
        public string Station1Humidity { get; set; }
        /// <summary>
        /// 模块2温度
        /// </summary>
        public string Station2Temp { get; set; }
        /// <summary>
        /// 魔块2湿度
        /// </summary>
        public string Station2Humidity { get; set; }

        /// <summary>
        /// 模块3温度
        /// </summary>
        public string Station3Temp { get; set; }
        /// <summary>
        /// 模块3湿度
        /// </summary>
        public string Station3Humidity { get; set; }

        /// <summary>
        /// 模块4温度
        /// </summary>
        public string Station4Temp { get; set; }
        /// <summary>
        /// 模块4湿度
        /// </summary>
        public string Station4Humidity { get; set; }

        /// <summary>
        /// 模块5温度
        /// </summary>
        public string Station5Temp { get; set; }
        /// <summary>
        /// 模块5湿度
        /// </summary>
        public string Station5Humidity { get; set; }

        /// <summary>
        /// 模块6温度
        /// </summary>
        public string Station6Temp { get; set; }
        /// <summary>
        /// 模块6湿度
        /// </summary>
        public string Station6Humidity { get; set; }
    }
}
