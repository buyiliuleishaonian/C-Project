using MTHModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wen.MTHDAL;

namespace Wen.MTHBLL
{
    /// <summary>
    /// 日志信息逻辑层
    /// </summary>
    public class SysLogBLL
    {
        public SysLogDAL sysLogDAL = new SysLogDAL();

        /// <summary>
        /// 通过时间和报警类型来查询报警信息
        /// </summary>
        /// <param name="start">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="alarmType">报警信息</param>
        /// <returns></returns>
        public DataTable SelectAlarm(string start, string end, string alarmType)
        {
            return sysLogDAL.SelectAlarm(start, end, alarmType);
        }

        /// <summary>
        /// 添加日志信息到数据库
        /// </summary>
        /// <param name="sysLogModel">日志信息</param>
        /// <returns></returns>
        public int AddLog(SysLogModel sysLogModel)
        {
            return sysLogDAL.AddLog(sysLogModel);
        }
    }
}
