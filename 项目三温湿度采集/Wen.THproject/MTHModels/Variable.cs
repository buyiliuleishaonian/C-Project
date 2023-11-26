using MiniExcelLibs.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTHModels
{
    /// <summary>
    /// 变量类
    /// </summary>
    public  class Variable
    {
        //变量名
        /// <summary>
        /// 变量名
        /// </summary>
        public string VarName { get; set; }

        /// <summary>
        /// 变量数据类型
        /// </summary>
        public  string DataType { get; set; }

        /// <summary>
        /// 变量起始地址
        /// </summary>
        public ushort Start { get; set; }
        /// <summary>
        /// 偏移量或长度（bit/string）
        /// </summary>
        public ushort OffsetORLength { get; set; }
        /// <summary>
        /// 通信组名
        /// </summary>
        public string  GroupName { get; set; }

        /// <summary>
        /// 变量备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 上升沿报警启用的标志
        /// </summary>
        public bool PosAlarm { get; set; }
        /// <summary>
        /// 下降沿报警启用的标志
        /// </summary>
        public bool NegAlarm { get; set; }



        /// <summary>
        /// 转化系数
        /// </summary>
        public float Scale { get; set; } = 1.0f;

        /// <summary>
        /// 偏移量的值
        /// </summary>
        public float Offset { get; set; } = 0.0f;

        /// <summary>
        /// 变量的值
        /// </summary>
        [ExcelIgnore]
        public object VarValue { get; set; }

        /// <summary>
        /// 上升沿报警检查的缓冲器
        /// </summary>
        [ExcelIgnore]
        public bool PosCacheValue { get; set; }=false;
        /// <summary>
        /// 下降沿报警检查的缓冲器
        /// </summary>
        [ExcelIgnore]
        public bool NegCacheValue { get; set; } = true;
    }
}
