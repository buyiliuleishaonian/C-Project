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
    /// 实时数据业务逻辑层
    /// </summary>
    public class ActualDataBLL
    {
        //创建ActualDataDAL对象
        //封装添加实时数据的方法
       //封装查询实时数据的方法

      public ActualDataDAL actualDataDAL = new ActualDataDAL();
        
        /// <summary>
        /// 添加实时数据
        /// </summary>
        /// <param name="actualData"></param>
        /// <returns></returns>
        public int AddActualData(ActualData actualData)
        {
            return actualDataDAL.AddActualData(actualData);
        }

        /// <summary>
        /// 通过开始和结束时间来查询实时数据
        /// </summary>
        /// <param name="start">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="columns">查询列</param>
        /// <returns></returns>
        public DataTable SelectActualData(string start,string end,List<string> columns)
        {
            return actualDataDAL.GetActualData(start,end,columns);
        }
    }
}
