using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTHModels
{
    /// <summary>
    /// 所有窗体的枚举，小于临界窗体为固定窗体
    /// </summary>
    public enum FormNames
    {
        //将按钮对应窗体名字例出来，临界窗体，在做窗体切换的时候，窗体不关闭
        //以前的做法是在容器中切换窗体的时候，关闭容器中所有窗体控件，只显示我需要执行的窗体控件
        集中控制,
        临界窗体,
        参数设置,
        配方管理,
        报警追溯,
        历史趋势,
        用户管理
    }
}
