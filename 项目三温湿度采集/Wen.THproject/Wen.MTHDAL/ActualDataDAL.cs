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
    /// 实时数据类的DAL，数据访问层
    /// </summary>
    public class ActualDataDAL
    {
        //添加实时数据记录
        /// <summary>
        /// 添加实时数据记录
        /// </summary>
        /// <param name="actualData">实时数据记录</param>
        /// <returns></returns>
        public int AddActualData(ActualData actualData)
        {
            //因为需要添加6个站点的温湿度，所以需要添加6个变量
            //所以使用stringBuilder来拼接sql语句
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("insert into ActualData(inserttime,station1temp,station1humidity,");
            stringBuilder.Append(" station2temp,station2humidity,station3temp,station3humidity,");
            stringBuilder.Append(" station4temp,station4humidity,station5temp,station5humidity,");
            stringBuilder.Append(" station6temp,station6humidity) values(");
            stringBuilder.Append("@inserttime,@station1temp,@station1humidity,");
            stringBuilder.Append(" @station2temp,@station2humidity,@station3temp,@station3humidity,");
            stringBuilder.Append(" @station4temp,@station4humidity,@station5temp,@station5humidity,");
            stringBuilder.Append(" @station6temp,@station6humidity)");
            //创建参数数组
            SqlParameter[] sqlparams = new SqlParameter[]
                {
                    new SqlParameter("@inserttime",actualData.InsertTime),
                    new SqlParameter("@station1temp",actualData.Station1Temp),
                    new SqlParameter("@station1humidity",actualData.Station1Humidity),
                    new SqlParameter("@station2temp",actualData.Station2Temp),
                    new SqlParameter("@station2humidity",actualData.Station2Humidity),
                    new SqlParameter("@station3temp",actualData.Station3Temp),
                    new SqlParameter("@station3humidity",actualData.Station3Humidity),
                    new SqlParameter("@station4temp",actualData.Station4Temp),
                    new SqlParameter("@station4humidity",actualData.Station4Humidity),
                    new SqlParameter("@station5temp",actualData.Station5Temp),
                    new SqlParameter("@station5humidity",actualData.Station5Humidity),
                    new SqlParameter("@station6temp",actualData.Station6Temp),
                    new SqlParameter("@station6humidity",actualData.Station6Humidity)
                };
            //执行添加操作
            int result = SQLHelper.GetExecuteNonQuery(stringBuilder.ToString(), sqlparams);
            if (result>0)
            {
                return result;
            }
            return 0;
        }


        //查询实时数据记录
        /// <summary>
        /// 查询实时数据记录
        /// </summary>
        /// <param name="start">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="columns">部分列</param>
        /// <returns>返回DataTable表</returns>
        public DataTable GetActualData(string start, string end, List<string> columns)
        {
            //查询所有的实时数据记录
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("select inserttime,");
            stringBuilder.Append(string.Join(" ,", columns));
            stringBuilder.Append(" from ActualData where inserttime between @start and @end");
            //创建参数数组
            SqlParameter[] sqlparams=new SqlParameter[]
            {
                new SqlParameter("@start",start),
                new SqlParameter("@end",end)
            };
            //执行查询操作
            DataTable dt = SQLHelper.GetDataTable(stringBuilder.ToString(), sqlparams);
            if (dt.Rows.Count>0)
            {
                return dt;
            }   
            return null;
        }
    }
}
