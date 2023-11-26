using MiniExcelLibs.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTHModels
{
    /// <summary>
    /// 通信组类（存储区）
    /// </summary>
    public class Group
    {
        /// <summary>
        /// 声明变量集合
        /// </summary>
        [ExcelIgnore]//不用添加到Excel中
        public List<Variable> VarList { get; set; }
        //通信组名称 GroupName
        /// <summary>
        /// 通信组名
        /// </summary>
        public string GroupName { get; set; }
        //读取的起始地址
        /// <summary>
        /// 通信组起始地址
        /// </summary>
        public ushort Start { get; set; }
        //读取的长度
        /// <summary>
        /// 通信组的长度
        /// </summary>
        public ushort Length { get; set; }
        //存储区名称
        /// <summary>
        /// 通信组的存储区
        /// </summary>
        public string StoreArea { get; set; }
        /// <summary>
        /// 通信组备注
        /// </summary>
        //备注说明信息 Remark
        public string Remark { get; set; }  

    }
}
