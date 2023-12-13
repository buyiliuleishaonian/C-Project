using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTHModels
{
    public class SysLogModel
    {
        /// <summary>
        /// 插入时间
        /// </summary>
        public string InsertTime { get; set; }

        /// <summary>
        /// 日志信息内容
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// 报警类型
        /// </summary>
        public string AlarmType { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        public string Operator { get; set; }

        /// <summary>
        /// 对应的变量名
        /// </summary>
        public string VarName{get;set;}
    }
}
