using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTHModels
{
    /// <summary>
    /// 用户类
    /// </summary>
    public class SysAdminModel
    {
        /// <summary>
        /// 用户id
        /// </summary>
        public int LoginId { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public  string LoginName { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string LoginPwd { get; set; }
        /// <summary>
        /// 参数设置权限
        /// </summary>
        public bool ParamSet { get; set; }
        /// <summary>
        /// 配方设置权限
        /// </summary>
        public bool Recipe { get; set; }
        /// <summary>
        /// 历史数据权限
        /// </summary>
        public bool HistoryLog { get; set; }
        /// <summary>
        /// 历史趋势权限
        /// </summary>
        public bool HistoryTrend { get; set; }
        /// <summary>
        /// 用户管理权限
        /// </summary>
        public bool UserMange { get; set; }
    }
}
