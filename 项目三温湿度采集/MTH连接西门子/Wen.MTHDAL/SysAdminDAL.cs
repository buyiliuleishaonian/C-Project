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
    /// 用户的数据访问层
    /// </summary>
    public class SysAdminDAL
    {
        /// <summary>
        /// 通过用户名和密码查询用户
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        public   SysAdminModel SelectAdmin(string  name,string password)
        {
            string sql = "select * from SysAdmin where LoginName=@AdminName and  LoginPwd=@AdminPwd";
            //创建参数数组，将参数初始化传递给SQLHelper
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@AdminName",name),
                new SqlParameter("@AdminPwd",password)
            };
            DataRow row= SQLHelper.GetDataRow(sql,sqlParameters);
            SysAdminModel sysAdminModel = new SysAdminModel();
            if (row!=null)
            {
                sysAdminModel.LoginId = Convert.ToInt32(row["LoginId"]);
                sysAdminModel.LoginName = row["LoginName"].ToString();
                sysAdminModel.LoginPwd = row["LoginPwd"].ToString();
                sysAdminModel.ParamSet = Convert.ToBoolean(row["ParamSet"]);
                sysAdminModel.Recipe = Convert.ToBoolean(row["Recipe"]);
                sysAdminModel.HistoryLog = Convert.ToBoolean(row["HistoryLog"]);
                sysAdminModel.HistoryTrend = Convert.ToBoolean(row["HistoryTrend"]);
                sysAdminModel.UserMange = Convert.ToBoolean(row["UserMange"]);
                return sysAdminModel;
            }
            return null;
        }

        //需要添加，添加用户，修改用户，删除用户，查询用户的Sql的方法
        //需要insert into  ，Update  where，delete  where  ，select * from  where  的SQL语句

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="sysAdmin">用户对象</param>
        /// <returns></returns>
        public int AddSysAdmin(SysAdminModel sysAdmin)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("insert into SysAdmin(LoginName,LoginPwd,ParamSet,Recipe,HistoryLog,HistoryTrend,UserMange)");
            sqlBuilder.Append(" values(@LoginName,@LoginPwd,@ParamSet,@Recipe,@HistoryLog,@HistoryTrend,@UserMange)");

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@LoginName",sysAdmin.LoginName),
                new SqlParameter("@LoginPwd",sysAdmin.LoginPwd),
                new SqlParameter("@ParamSet",sysAdmin.ParamSet),
                new SqlParameter("@Recipe",sysAdmin.Recipe),
                new SqlParameter("@HistoryLog",sysAdmin.HistoryLog),
                new SqlParameter("@HistoryTrend",sysAdmin.HistoryTrend),
                new SqlParameter("@UserMange",sysAdmin.UserMange)
            };
            return SQLHelper.GetExecuteNonQuery(sqlBuilder.ToString(),sqlParameters);   
        }

        /// <summary>
        /// 通过主键删除
        /// </summary>
        /// <param name="loginID">主键用户ID</param>
        /// <returns></returns>
        public int DeleteSysAdmin(int loginID)
        {
            StringBuilder stringBuilder= new StringBuilder();   
            stringBuilder.Append("delete from SysAdmin where LoginId=@LoginId");
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@LoginId",loginID)
            };
            return SQLHelper.GetExecuteNonQuery(stringBuilder.ToString(),sqlParameters);
        }   

        /// <summary>
        /// 通过主键修改
        /// </summary>
        /// <param name="sysAdmin">用户对象</param>
        /// <returns></returns>
        public int UpdateSysAdmin(SysAdminModel sysAdmin)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append(" Update SysAdmin");
            sqlBuilder.Append(" Set LoginName=@LoginName,LoginPwd=@LoginPwd");
            sqlBuilder.Append(" ,ParamSet=@ParamSet,Recipe=@Recipe,");
            sqlBuilder.Append(" HistoryLog=@HistoryLog,HistoryTrend=@HistroyTrend,");
            sqlBuilder.Append(" UserMange=@UserMange where LoginID=@LoginID");
            SqlParameter[] sqlparams = new SqlParameter[]
            {
                new SqlParameter("@LoginName",sysAdmin.LoginName),
                new SqlParameter("@LoginPwd",sysAdmin.LoginPwd),
                new SqlParameter("@ParamSet",sysAdmin.ParamSet),
                new SqlParameter("@Recipe",sysAdmin.Recipe),
                new SqlParameter("@HistoryLog",sysAdmin.HistoryLog),
                new SqlParameter("@HistroyTrend",sysAdmin.HistoryTrend),
                new SqlParameter("@UserMange",sysAdmin.UserMange),
                new SqlParameter("@LoginID",sysAdmin.LoginId)
            };
            return SQLHelper.GetExecuteNonQuery(sqlBuilder.ToString(),sqlparams);
        }

        /// <summary>
        /// 查询所有的用户信息
        /// </summary>
        /// <returns></returns>
        public List<SysAdminModel> SelectSysAdmin()
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("Select * from SysAdmin");
            DataTable dataTable = SQLHelper.GetDataTable(sqlBuilder.ToString());
            List<SysAdminModel> sysAdminModels = new List<SysAdminModel>();
            foreach (DataRow item in dataTable.Rows)
            {
                sysAdminModels.Add(new SysAdminModel() 
                {
                    LoginId = Convert.ToInt32(item["LoginId"]),
                    LoginName = item["LoginName"].ToString(),
                    LoginPwd = item["LoginPwd"].ToString(),
                    ParamSet = Convert.ToBoolean(item["ParamSet"]),
                    Recipe = Convert.ToBoolean(item["Recipe"]),
                    HistoryLog = Convert.ToBoolean(item["HistoryLog"]),
                    HistoryTrend = Convert.ToBoolean(item["HistoryTrend"]),
                    UserMange = Convert.ToBoolean(item["UserMange"])
                });
            }
            return sysAdminModels;
        }
    }
}
