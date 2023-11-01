using InfosClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace Sqlhelper
{
    public class SqlHelper
    {
        /// <summary>
        /// 将服务器中的sql数据库名称读取出来
        /// </summary>
        /// <param name="datasource"></param>
        /// <param name="uid"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static List<string> GetServerName1(string datasource, string uid, string pwd)
        {
            //Initial Cataloh数据库的初始数据库master，也可也用你知道的数据库名称代替
            //database=master
            string sqlstr = $"Data Source={datasource};Initial Catalog=master;" +
                $"User ID={uid};Password={pwd}";
            try
            {
                using (SqlConnection connection = new SqlConnection(sqlstr))
                {
                    connection.Open();
                    // 获取数据库列表
                    DataTable databases = connection.GetSchema("Databases");
                    // 打印数据库列表
                    List<string> list = new List<string>();
                    Console.WriteLine("Available databases:");
                    foreach (DataRow row in databases.Rows)
                    {
                        list.Add(row["database_name"].ToString());
                    }
                    return list;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// 用sql语句将所有的数据库名读取出来
        /// ，select name from sys.databases
        /// </summary>
        /// <param name="datasource">服务器</param>
        /// <param name="uid">用户名</param>
        /// <param name="pwd">密码</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static List<string> GetServerName2(string datasource, string uid, string pwd)
        {
            string sqlstr = $"Data Source={datasource};database=master;" +
               $"User ID={uid};Password={pwd}";
            try
            {
                using (SqlConnection con = new SqlConnection(sqlstr))
                {
                    con.Open();
                    //通过读取视图中的所有
                    SqlCommand cmd = new SqlCommand("select name from sys.databases", con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    List<string> list = new List<string>();
                    foreach (DataRow dr in dt.Rows)
                    {
                        list.Add(dr["name"].ToString());
                    }
                    return list;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// 连接数据库，将数据库中的表转为Model
        /// </summary>
        /// <param name="datasource">服务器</param>
        /// <param name="uid">用户名</param>
        /// <param name="pwd">密码</param>
        /// <param name="sqlName">数据库名称</param>
        /// <param name="path">存放文件夹的路径</param>
        /// <param name="pathName">文件夹名</param>
        /// <returns></returns>
        public static StringBuilder GetModel(string datasource, string uid, string pwd, string sqlName, string path, string pathName)
        {
            string sqlstr = $"server={datasource};uid={uid};password={pwd};database={sqlName}";
            StringBuilder modelCode = null;
            using (SqlConnection con = new SqlConnection(sqlstr))
            {
                con.Open();
                //将选中的数据库中所有表名称，表中的列和数据类型全部读取出来
                DataTable dt = con.GetSchema("Tables");
                foreach (DataRow dr in dt.Rows)
                {
                    string tableName = dr["TABLE_NAME"].ToString();
                    string modelClassName = ToTitleCase1(tableName); // 将表名转为 PascalCase

                    // 查询表的所有列信息
                    string query = $"SELECT COLUMN_NAME, DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{tableName}'";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // 创建 C# Model 的字符串
                            modelCode = new StringBuilder();
                            modelCode.AppendLine("using System;\r\nusing System.Collections.Generic;\r\nusing System.Linq;" +
                                "\r\nusing System.Text;\r\nusing System.Threading.Tasks;"
                                +"\r\n"+ $"namespace {pathName}"+"\r\n{" +"\r\n"+ "public class " + modelClassName);
                            modelCode.AppendLine("{");

                            // 遍历列信息并为每列生成属性
                            while (reader.Read())
                            {
                                string columnName = reader["COLUMN_NAME"].ToString();
                                string dataType = reader["DATA_TYPE"].ToString();

                                // 将 SQL Server 数据类型转换为 C# 数据类型
                                string csharpDataType = GetCSharpDataType(dataType);

                                // 生成属性
                                modelCode.AppendLine("public " + csharpDataType + " " + ToTitleCase2(columnName) + " { get; set; }");
                            }
                            modelCode.AppendLine("}");
                            modelCode.AppendLine("}");
                            modelCode.AppendLine();
                            // 将 C# Model 代码写入文件
                            string filePath = Path.Combine(path, modelClassName + ".cs");
                            File.WriteAllText(filePath, modelCode.ToString());
                        }
                    }
                }
                return modelCode;
            }
        }

        /// <summary>
        /// 将选择的数据库中的所有表名读取出来
        /// </summary>
        /// <param name="datasource"></param>
        /// <param name="uid"></param>
        /// <param name="pwd"></param>
        /// <param name="sqlName"></param>
        /// <returns></returns>
        public List<Infos> SelectInfosNameAndCellName(string datasource, string uid, string pwd, string sqlName)
        {
            string sqlstr = $"server={datasource};uid={uid};password={pwd};database={sqlName}";
            //首先我们需要将所选择的数据库中的所有表读取出来
            SqlConnection con = new SqlConnection(sqlstr);
            con.Open();
            SqlCommand cmd = new SqlCommand("select table_name=t.name from sys.tables t", con);
            SqlDataReader sdr = cmd.ExecuteReader();
            List<Infos> list = new List<Infos>();
            while (sdr.Read())
            {
                list.Add(new Infos{ InfosName= sdr["table_name"].ToString() }) ;
            }
            con.Close();
            return list;    
        }


        // 辅助方法：将字符串转换为 PascalCase
        static string ToTitleCase1(string str)
        {
            string[] words = str.Split(new char[] { '_', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
            }
            return string.Join("", words)+"Model";
        }
        static string ToTitleCase2(string str)
        {
            string[] words = str.Split(new char[] { '_', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
            }
            return string.Join("", words);
        }

        // 辅助方法：将 SQL Server 数据类型转换为 C# 数据类型
        static string GetCSharpDataType(string sqlDataType)
        {
            switch (sqlDataType.ToLower())
            {
                case "bigint": return "long";
                case "binary":
                case "image":
                case "varbinary": return "byte[]";
                case "bit": return "bool";
                case "char":
                case "nchar":
                case "ntext":
                case "nvarchar":
                case "text":
                case "varchar": return "string";
                case "date":
                case "datetime":
                case "datetime2":
                case "smalldatetime": return "DateTime";
                case "datetimeoffset": return "DateTimeOffset";
                case "decimal":
                case "money":
                case "numeric":
                case "smallmoney": return "decimal";
                case "float": return "double";
                case "int": return "int";
                case "real": return "float";
                case "smallint": return "short";
                case "time": return "TimeSpan";
                case "tinyint": return "byte";
                case "uniqueidentifier": return "Guid";
                default: return "object";
            }
        }
    }
}
