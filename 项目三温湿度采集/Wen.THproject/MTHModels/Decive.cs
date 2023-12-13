using System;
using System.Collections.Generic;

namespace MTHModels
{
    /// <summary>
    /// 通信设备类
    /// </summary>
    public class Decive
    {
        //声明Group的List集合
        //创建设备IP，端口，从站地址等属性
        //ip地址ipaddress
        //端口号

        /// <summary>
        /// 通信组Group集合
        /// </summary>
        public List<Group> GroupList { get; set; }   

        /// <summary>
        /// ip地址
        /// </summary>
        public string IPAddRess { get; set; }

        /// <summary>
        /// 端口号
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// 通信状态标志位
        /// </summary>
        public bool IsConnected { get; set; } = false;

        /// <summary>
        ///当前配方名
        /// </summary>
        public string CurrentRecipeInfo { get; set; }

        /// <summary>
        /// 延时连接的时间
        /// </summary>
        public int DelayedTime { get; set; } = 5000;

        /// <summary>
        /// 是否是第一次连接 标志位
        /// </summary>
        public bool ReConnectSign { get; set; } = false;

        //获取当前配方（每当配方应用之后）


        /// <summary>
        /// 所有变量的键值对,键是变量的名称，值是是实际的值
        /// </summary>
        public Dictionary<string,object>  CurrentVariable =new Dictionary<string,object>();

        //当触发报警之后，通过事件来，定义一个报警触发和消除的事件
        /// <summary>
        /// 定义报警触发事件
        /// </summary>
        public event Action<bool, Variable> AlarmTrigEvent;


        //编写一个对于字典的维护，也就是更新数据，和添加新的变量数据，当数据更新时
        /// <summary>
        /// 更新数据，就是将数据写入到Variable对象中
        /// </summary>
        /// <param name="variable"></param>
        public void UpdateVariable(Variable variable)
        {
            if (CurrentVariable.ContainsKey(variable.VarName))
            {
                CurrentVariable[variable.VarName] = variable.VarValue;
            }
            else
            {
                CurrentVariable.Add(variable.VarName, variable.VarValue);
            }
            CheckAralm(variable);
        }

        //判断是否产生了下降沿和上升沿的报警检测
        //先判断上升沿检测，会存在一个缓冲值，做到一个作比较的作用，来判断是否产生了上升沿，比如从0-1
        //之后值为1，只有当值又变为0之后，又从0-1，才叫上升沿报警，每次判断完之后，都需要将最新的值
        //传递给上升沿报警的缓冲器
        /// <summary>
        /// 判断变量是否触发报警
        /// </summary>
        /// <param name="var"></param>
        public void CheckAralm(Variable var)
        {
            //判断是启动上升沿还是下降报警
            if (var.PosAlarm)
            {
                bool currentValue = string.Equals(var.VarValue.ToString(), "True",StringComparison.OrdinalIgnoreCase);
                if (var.PosCacheValue==false&&currentValue==true)
                {
                    //触发报警
                    AlarmTrigEvent?.Invoke(true,var);
                }
                if(var.PosCacheValue==true&&currentValue==false)
                {
                    //解除报警
                    AlarmTrigEvent?.Invoke(false, var);
                }
                var.PosCacheValue= currentValue;    
            }
            if (var.NegAlarm)
            {
                bool currentValue = string.Equals(var.VarValue.ToString(),"false",StringComparison.OrdinalIgnoreCase);
                if (var.PosCacheValue==true&&currentValue==false)
                {
                    //触发报警
                    AlarmTrigEvent?.Invoke(true, var);
                }
                if (var.PosCacheValue==false&&currentValue==true)
                {
                    //解除报警
                    AlarmTrigEvent?.Invoke(false, var);
                }
                var.NegCacheValue= currentValue;
            }
        }

        //编写一个索引器，通过这个Decive加上索引器，搜索当前的值,不存在就返回null
        /// <summary>
        /// 编写一个搜索变量值的索引器
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public object this[string key]
        {
            get 
            {
                if (key!=null&&key.Trim().Length!=0)
                {
                    if (CurrentVariable.ContainsKey(key))
                    {
                        return CurrentVariable[key];
                    }
                    else
                    {
                        return null;
                    }
                }
                else { return null; }
            }
        }

    }
}
