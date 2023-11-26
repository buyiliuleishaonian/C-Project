using MTHModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using thinger.DataConvertLib;
using Wen.Common;

namespace Wen.THproject
{
    /// <summary>
    /// 整个ui层的配置对象
    /// </summary>
    public class CommonModel
    {
        /// <summary>
        /// 整个程序都需要配置的Decive，
        /// </summary>
        public static Decive Decive { get; set; }

        /// <summary>
        /// 设定全局的委托，来进行所有UI层的操作都可以添加到日志中
        /// </summary>
        public static Action<int, string> AddLog;

        /// <summary>
        /// ModbusTCP通信对象
        /// </summary>
        public static ModbusTCP Modbus { get; set; }=new ModbusTCP();

        //写一个大小端
        /// <summary>
        /// 定义为大端
        /// </summary>
        public static DataFormat dataFormat= DataFormat.ABCD;


        //封装一个通过变量的某一唯一的特性的属性，得到这个变量
        /// <summary>
        /// 通过标签名称找到对应变量
        /// </summary>
        /// <param name="varName"></param>
        /// <returns></returns>
        public static Variable FindVariable(string varName)
        {
            //遍历Decive中的GroupList，Group包含了VarList
            foreach (var item in Decive.GroupList)
            {
                var res = item.VarList.Find(c=>c.VarName==varName);
                if (res!=null)
                { 
                    return res;
                }
            }
            return null;

        }
        //通用参数修改的方法

        /// <summary>
        /// 通过标签名称修改对应变量的值
        /// </summary>
        /// <param name="varName">变量名称</param>
        /// <param name="varValue">变量值</param>
        /// <returns></returns>
        public static bool CommonWrite(string varName,string  varValue)
        {
            //找到对应变量之后，需要判断变量的数据类型
            Variable var=FindVariable(varName);
            //获取写入类型，需要通过线性转化
            DataType dataType=(DataType)Enum.Parse(typeof(DataType), var.DataType,true);
            //获得线性转化后的数据
            var result = MigrationLib.GetMigrationValue(varValue,var.Scale.ToString(),var.OffsetORLength.ToString());
            if(result.IsSuccess)
            {
                try
                {
                    switch (dataType)
                    {
                        case DataType.Bool:
                            //只可能是线圈
                            return Modbus.PreSetSingleCoil(var.Start, Convert.ToBoolean(result.Content));
                        case DataType.Short:
                            return Modbus.PreSetSingleRegister(var.Start, Convert.ToInt16(result.Content));
                        case DataType.UShort:
                            return Modbus.PreSetSingleRegister(var.Start, Convert.ToUInt16(result.Content));
                        case DataType.Int:
                            return Modbus.PreSetMultiRegisters(var.Start, ByteArrayLib.GetByteArrayFromInt(Convert.ToInt32(result.Content), dataFormat));
                        case DataType.UInt:
                            return Modbus.PreSetMultiRegisters(var.Start, ByteArrayLib.GetByteArrayFromUInt(Convert.ToUInt32(result.Content)));
                        case DataType.Float:
                            return Modbus.PreSetMultiRegisters(var.Start, ByteArrayLib.GetByteArrayFromFloat(Convert.ToSingle(result.Content)));
                        case DataType.Double:
                            return Modbus.PreSetMultiRegisters(var.Start, ByteArrayLib.GetByteArrayFromDouble(Convert.ToDouble(result.Content)));
                        case DataType.Long:
                            return Modbus.PreSetMultiRegisters(var.Start, ByteArrayLib.GetByteArrayFromLong(Convert.ToInt64(result.Content)));
                        case DataType.ULong:
                            return Modbus.PreSetMultiRegisters(var.Start, ByteArrayLib.GetByteArrayFromULong(Convert.ToUInt64(result.Content)));
                        case DataType.String:
                            return Modbus.PreSetMultiRegisters(var.Start, ByteArrayLib.GetByteArrayFromString(result.Content.ToString(), Encoding.ASCII));
                        case DataType.ByteArray:
                            return Modbus.PreSetMultiRegisters(var.Start, ByteArrayLib.GetByteArrayFromHexString(result.Content.ToString()));
                        case DataType.HexString:
                            return Modbus.PreSetMultiRegisters(var.Start, ByteArrayLib.GetByteArrayFromHexString(result.Content.ToString()));
                        default:
                            break;
                    }
                }
                catch (Exception ex) 
                {
                    AddLog(1,"写入数据错误");
                    return false;
                }
                }
            return false;
        }

    }
}
