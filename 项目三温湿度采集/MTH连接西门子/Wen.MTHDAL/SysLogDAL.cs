using MTHModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wen.Common;

namespace Wen.MTHDAL
{
    /// <summary>
    /// 日志信息数据访问层
    /// </summary>
    public class SysLogDAL
    {
        /// <summary>
        /// 根据日志对象添加日志信息
        /// </summary>
        /// <param name="sysLogModel">日志对象</param>
        /// <returns></returns>
        public int AddLog(SysLogModel sysLogModel)
        {
            string sqlStr = "insert into SysLog(inserttime,note,alarmtype,operator,varname) " +
                " values(@inserttime,@note,@alarmtype,@operator,@varname)";
            SqlParameter[] sqlparams = new SqlParameter[]
            {
                new SqlParameter("@inserttime",sysLogModel.InsertTime),
                new SqlParameter("@note",sysLogModel.Note),
                new SqlParameter("@alarmtype",sysLogModel.AlarmType),
                new SqlParameter("@operator",sysLogModel.Operator),
                new SqlParameter("@varname",sysLogModel.VarName)
            };
            int result = SQLHelper.GetExecuteNonQuery(sqlStr, sqlparams);
            return result;
        }

        /// <summary>
        /// 通过时间和报警类型来查询报警信息
        /// </summary>
        /// <param name="insertTime">时间</param>
        /// <param name="alarmType">报警类型</param>
        /// <returns></returns>
        public DataTable SelectAlarm(string start,string end, string alarmType)
        {
            string sqlStr = "select inserttime,note,alarmtype,operator,varname " +
                " from SysLog where inserttime>@start and inserttime<@end ";
            //string sqlStr = "select inserttime,note,alarmtype,operator,varname from SysLog"+
            // " where inserttime between @strat and @end and alarmtype=@alarmtype";
            //集合的长度可以改变，数组的长度无法改变
            //SqlParameter[] sqlparams = new SqlParameter[]
            //{
            //    new SqlParameter("@start",start),
            //    new SqlParameter("@end",end),
            //};
            List<SqlParameter> sqlparams = new List<SqlParameter>();
            sqlparams.Add(new SqlParameter("@start",start));
            sqlparams.Add(new SqlParameter("@end", end) );
            //判断是否添加报警类型来筛选日志信息
            if (alarmType.Trim().Length>0)
            {
                sqlStr+=" and alarmtype=@alarmtype";
                sqlparams.Add(new SqlParameter("@alarmtype",alarmType));
            }
            DataTable dt = SQLHelper.GetDataTable(sqlStr,sqlparams.ToArray());
            if (dt.Rows.Count>0)
            {
                return dt;
            }
            else
            {
                return null;
            }
        }
    }
}
