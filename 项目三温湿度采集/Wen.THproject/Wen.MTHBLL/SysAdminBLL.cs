using MTHModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wen.MTHDAL;

namespace Wen.MTHBLL
{
    /// <summary>
    /// SysAdmin的业务逻辑层  
    /// </summary>
    public class SysAdminBLL
    {
        //创建数据访问层对象
        public SysAdminDAL sysAdminDAL = new SysAdminDAL();
        //创建方法，调用数据访问层的方法
        /// <summary>
        /// 登入查询管理员账号
        /// </summary>
        /// <param name="userName">管理员名</param>
        /// <param name="passWord">管理员密码</param>
        /// <returns></returns>
        public  SysAdminModel GetSysAdminModel(string userName,string passWord)
        {
            return sysAdminDAL.SelectAdmin(userName, passWord);
        }

        /// <summary>
        /// 添加管理员账号
        /// </summary>
        /// <param name="sysAdmin"></param>
        /// <returns></returns>
        public bool AddSysAdmin(SysAdminModel sysAdmin)
        {
            return sysAdminDAL.AddSysAdmin(sysAdmin)>0;
        }
        
        /// <summary>
        /// 修改管理员权限
        /// </summary>
        /// <param name="sysadmin"></param>
        /// <returns></returns>
        public bool UpdateSysAdmin(SysAdminModel sysadmin)
        {
            
            return sysAdminDAL.UpdateSysAdmin(sysadmin)>0;
        }
        
        /// <summary>
        /// 删除管理员账号
        /// </summary>
        /// <param name="loginID">主键用户ID</param>
        /// <returns></returns>
        public bool DeleteSysAdmin(int loginID)
        {
            return sysAdminDAL.DeleteSysAdmin(loginID)>0;
        }

        /// <summary>
        /// 得到数据库中所有的管理员账号
        /// </summary>
        /// <returns></returns>
        public List<SysAdminModel> GetSysAdminList()
        {
            return sysAdminDAL.SelectSysAdmin();
        }
    }
}
