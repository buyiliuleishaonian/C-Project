using IniHelperDemo;
using MTHModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thinger.DataConvertLib;
using Wem.Common;

namespace Wen.THproject
{
    /// <summary>
    /// 配方管理窗体
    /// </summary>
    public partial class FrmRecipe : Form
    {
        public FrmRecipe(string path)
        {
            InitializeComponent();
            //初始化读取所有的配方
            this.txt_RecipeInfoName.Text = CommonModel.Decive.CurrentRecipeInfo;
            this.lbl_CurrentRecipeInfo.Text = CommonModel.Decive.CurrentRecipeInfo;
            RefreshRecipe();
            //获取总Decipe的文件路径
            this.decPath=path;
        }

        //创建一个文件夹路径
        private string basePath = Application.StartupPath + @"\Recipe";
        //创建一个ecipeInfo对象集合
        private List<RecipeInfo> recipeInfoList = new List<RecipeInfo>();

        private string decPath = string.Empty;

        /// <summary>
        /// 添加配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            //排除一些验证，无法是配方名不为空
            //任何一个RecipeParam不能为空
            if (this.txt_RecipeInfoName.Text.ToString().Trim().Length==0||this.txt_RecipeInfoName.Text==null)
            {
                //配方名不能为空
                new FrmMsgBoxWithoutAck("配方名不能为空", "配方设置").ShowDialog();
                return;
            }
            //配方名不能重复
            if (this.recipeInfoList.Where(c => c.RecipeInfoName==this.txt_RecipeInfoName.Text.Trim()).Count()>0)
            {
                new FrmMsgBoxWithoutAck("配方名重复", "配方设置").ShowDialog();
                return;
            }
            //得到ReicpeInfo对象
            var recipeInfo = GetRecipeInfo();
            //然后创建文件，将其添加到文件下
            if (AddRecipe(recipeInfo))
            {
                CommonModel.AddLog(0, "配方添加成功");
                new FrmMsgBoxWithoutAck("添加配方成功", "配方设置").ShowDialog();
                RefreshRecipe();
            }
            else
            {
                CommonModel.AddLog(1, "配方添加失败");
                new FrmMsgBoxWithoutAck("添加配方失败", "配方设置").ShowDialog();
            }
        }

        /// <summary>
        /// 修改配方
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Update_Click(object sender, EventArgs e)
        {
            //排除一些验证，无法是配方名不为空
            //任何一个RecipeParam不能为空
            if (this.txt_RecipeInfoName.Text.ToString().Trim().Length==0||this.txt_RecipeInfoName.Text==null)
            {
                //配方名不能为空
                new FrmMsgBoxWithoutAck("配方名不能为空", "配方设置").ShowDialog();
                return;
            }
            //配方名不能重复
            if (this.recipeInfoList.Where(c => c.RecipeInfoName==this.txt_RecipeInfoName.Text.Trim()).Count()<0)
            {
                new FrmMsgBoxWithoutAck("配方名不存在", "配方设置").ShowDialog();
                return;
            }
            //得到ReicpeInfo对象
            var recipeInfo = GetRecipeInfo();
            //然后创建文件，将其添加到文件下
            if (AddRecipe(recipeInfo))
            {
                CommonModel.AddLog(0, "修改成功");
                new FrmMsgBoxWithoutAck("修改成功", "配方设置").ShowDialog();
                RefreshRecipe();
            }
            else
            {
                CommonModel.AddLog(1, "配方修改失败");
                new FrmMsgBoxWithoutAck("修改配方失败", "配方设置").ShowDialog();
            }
        }

        /// <summary>
        /// 删除配方
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = new FrmMsgBoxWithAck("是否确定删除配方", "删除配方").ShowDialog();
            if (dialogresult==DialogResult.OK)
            {
                //排除一些验证，无法是配方名不为空
                if (this.txt_RecipeInfoName.Text.ToString().Trim().Length == 0 || this.txt_RecipeInfoName.Text == null)
                {
                    //配方名不能为空
                    new FrmMsgBoxWithoutAck("配方名不能为空", "配方设置").ShowDialog();
                    return;
                }
                //配方名不能重复
                if (this.recipeInfoList.Where(c => c.RecipeInfoName==this.txt_RecipeInfoName.Text.Trim()).Count()<0)
                {
                    new FrmMsgBoxWithoutAck("配方名不存在", "配方设置").ShowDialog();
                    return;
                }
                bool result = DeleteRecipe(this.txt_RecipeInfoName.Text.Trim());
                if (result)
                {
                    CommonModel.AddLog(0, "配方删除成功");
                    new FrmMsgBoxWithoutAck("配方删除成功", "配方设置").ShowDialog();
                    this.txt_RecipeInfoName.Text = string.Empty;
                    RefreshRecipe();
                }
                else
                {
                    CommonModel.AddLog(1, "配方删除失败");
                    new FrmMsgBoxWithoutAck("配方删除失败", "配方设置").ShowDialog();
                }
            }
        }


        /// <summary>
        /// 应用配方
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Apply_Click(object sender, EventArgs e)
        {
            //非空判断
            //是否存在判断
            //是否链接硬件判断
            //排除一些验证，无法是配方名不为空
            if (this.txt_RecipeInfoName.Text.ToString().Trim().Length==0||this.txt_RecipeInfoName.Text==null)
            {
                //配方名不能为空
                new FrmMsgBoxWithoutAck("配方名不能为空", "配方设置").ShowDialog();
                return;
            }
            //配方名不能重复
            var info = this.recipeInfoList.Where(c => c.RecipeInfoName==this.txt_RecipeInfoName.Text.Trim()).FirstOrDefault();
            if (this.recipeInfoList.Where(c => c.RecipeInfoName==this.txt_RecipeInfoName.Text.Trim()).Count()<0)
            {
                new FrmMsgBoxWithoutAck("配方名不存在", "配方设置").ShowDialog();
                return;
            }
            if (!CommonModel.Decive.IsConnected)
            {
                new FrmMsgBoxWithoutAck("没有连接硬件", "应用配置").ShowDialog();
                return;
            }
            //判断配方的索引长度是否等于6
            if (info.RecipeParamList.Count==6)
            {
                //写入数据，将配方写到PLC中
                //通过ModbusTCP写入寄存器，只需要起始地址和长度，然后将数据写入到寄存器中
                //创建数据集合，遍历recipeList，将其中的数据   
                List<short> dataList = new List<short>();
                for (int i = 0; i < info.RecipeParamList.Count; i++)
                {
                    dataList.Add(Convert.ToInt16(info.RecipeParamList[i].TempHight));
                    dataList.Add(Convert.ToInt16(info.RecipeParamList[i].TempLow ));
                    dataList.Add(Convert.ToInt16(info.RecipeParamList[i].HumidityHight ));
                    dataList.Add(Convert.ToInt16(info.RecipeParamList[i].HumidityLow));
                }
                //添加报警使能
                for (int i = 0; i < 6; i++)
                {
                    dataList.Add(info.RecipeParamList[i].TempAlarmEnalbe ? Convert.ToInt16(1) : Convert.ToInt16(0));
                    dataList.Add(info.RecipeParamList[i].HumidityEnalbe ? Convert.ToInt16(1) : Convert.ToInt16(0));
                }
                //将数据写入到寄存器中
                bool result = CommonModel.Modbus.PreSetMultiRegisters(18, ByteArrayLib.GetByteArrayFromShortArray(dataList.ToArray()));
                if (result)
                {
                    string name = this.txt_RecipeInfoName.Text.Trim();
                    //需要将设定的配方，的配方名，写成一个INI文件
                    //如果修改了配方，在这里就将Decive中的RecipeInfoName修改成当前的配方名
                    IniConfigHelper.WriteIniData("配方参数","当前配方",name,this.decPath);
                    CommonModel.Decive.CurrentRecipeInfo = name;
                    this.lbl_CurrentRecipeInfo.Text = name;
                    new FrmMsgBoxWithoutAck("配方应用成功", "配方设置").ShowDialog();
                }
                else
                {
                    new FrmMsgBoxWithoutAck("配方应用失败", "配方设置").ShowDialog();
                }
            }
            else
            {
                new FrmMsgBoxWithoutAck("配方数据不完整", "配方设置").ShowDialog();
            }
        }

        #region 封装获取配方对象
        /// <summary>
        /// 将界面上的数据，封装成一个RecipeInfo对象
        /// </summary>
        /// <returns></returns>
        private RecipeInfo GetRecipeInfo()
        {
            string name = this.txt_RecipeInfoName.Text.ToString().Trim();
            RecipeInfo recipe = new RecipeInfo();
            recipe.RecipeInfoName=name;
            recipe.RecipeParamList=new List<RecipeParam>()
            {
                this.recipeControl1.RecipeParam,
                this.recipeControl2.RecipeParam,
                this.recipeControl3.RecipeParam,
                this.recipeControl4.RecipeParam,
                this.recipeControl5.RecipeParam,
                this.recipeControl6.RecipeParam,
            };
            return recipe;
        }
        #endregion

        #region 封装添加配方文件的方法
        /// <summary>
        /// 封装添加配方文件的方法
        /// </summary>
        /// <param name="recipeInfo">配方的数据</param>
        /// <returns></returns>
        private bool AddRecipe(RecipeInfo recipeInfo)
        {
            //通过文件夹路径，加上设定的文件名+INI
            string path = basePath + @"\" + recipeInfo.RecipeInfoName + ".ini";
            //因为我的INI文件还没有写入，如果是第一次写入文件，就先创建文件夹
            //Directory.CreateDirectory(path);//通过创建对应的文件间路径
            if (!File.Exists(path))
            {
                File.CreateText(path).Close();//通过File.Create的文件流，创建之后必须关闭文件流，
            }
            //要不就会被占用，无法写入
            //通过创建对应的文件路径
            return IniConfigHelper.WriteIniData("配置", "配方数据", JsonHelper.EntityToJson(recipeInfo), path);
        }
        #endregion

        #region 更新所有配方
        /// <summary>
        /// 更新所有配方
        /// </summary>
        private void RefreshRecipe()
        {
            //获取所有配方
            this.recipeInfoList=GetAllRecipe();
            //将配方名添加到DataGridView中  
            if (this.recipeInfoList.Count>0)
            {
                this.dgv_Main.Rows.Clear();
                for (int i = 0; i < this.recipeInfoList.Count; i++)
                {
                    this.dgv_Main.Rows.Add();
                    this.dgv_Main.Rows[i].Cells[0].Value = i+1;
                    this.dgv_Main.Rows[i].Cells[1].Value=this.recipeInfoList[i].RecipeInfoName;

                    if (this.txt_RecipeInfoName.Text==this.recipeInfoList[i].RecipeInfoName)
                    {
                        this.dgv_Main.Rows[i].Selected = true;
                    }
                    else
                    {
                        this.dgv_Main.Rows[i].Selected = false;
                    }
                }
                if (this.dgv_Main.SelectedRows.Count>0)
                {
                    SetRecipeInfo(this.recipeInfoList[this.dgv_Main.SelectedRows[0].Index]);
                }
            }
        }
        #endregion

        #region 获取所有配方
        /// <summary>
        /// 获取相对文件下所有配方的文件路径，读取出来所有的配方
        /// </summary>
        /// <returns></returns>
        private List<RecipeInfo> GetAllRecipe()
        {
            //首先得到Recipe文件目录下所有的文件
            DirectoryInfo directoryInfo = new DirectoryInfo(basePath);
            //过滤只需要后缀的.INI文件
            List<FileInfo> list = directoryInfo.GetFiles("*.ini").ToList();
            //遍历文件，将其读取出来，然后反序列化成RecipeInfo对象
            List<RecipeInfo> listRecipeInfo = new List<RecipeInfo>();
            foreach (var item in list)
            {
                listRecipeInfo.Add(GetRecipeInfo(item.FullName));
            }
            return listRecipeInfo;
        }
        #endregion

        #region 反序列化文件，将RecipeInfo数据，变为RecipeInfo对象
        /// <summary>
        /// 通过文件路径，反序列化成RecipeInfo对象
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private RecipeInfo GetRecipeInfo(string path)
        {
            //通过文件路径，读取文件
            return JsonHelper.JsonToEntity<RecipeInfo>(IniConfigHelper.ReadIniData("配置", "配方数据", "", path));
            //然后反序列化成RecipeInfo对象
        }
        #endregion

        #region 封装删除配方
        /// <summary>
        /// 通过文件名删除配方
        /// </summary>
        /// <param name="name">文件名</param>
        /// <returns></returns>
        private bool DeleteRecipe(string name)
        {
            try
            {

                //通过文件夹路径，加上设定的文件名+INI
                string path = basePath + @"\" + name + ".ini";
                //删除文件
                File.Delete(path);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        #endregion

        #region 显示当前配方
        private void SetRecipeInfo(RecipeInfo recipeinfo)
        {
            this.txt_RecipeInfoName.Text=recipeinfo.RecipeInfoName;
            if (recipeinfo.RecipeParamList.Count==6)
            {
                this.recipeControl1.RecipeParam = recipeinfo.RecipeParamList[0];
                this.recipeControl2.RecipeParam = recipeinfo.RecipeParamList[1];
                this.recipeControl3.RecipeParam = recipeinfo.RecipeParamList[2];
                this.recipeControl4.RecipeParam = recipeinfo.RecipeParamList[3];
                this.recipeControl5.RecipeParam = recipeinfo.RecipeParamList[4];
                this.recipeControl6.RecipeParam = recipeinfo.RecipeParamList[5];
            }
        }

        #endregion

        #region DataGridView的事件

        /// <summary>
        /// 单击选中DataGridView中的配方，然后将其显示到界面上
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_Main_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //首先判断是否有行
            if (this.dgv_Main.Rows.Count>0)
            {
                if (e.RowIndex>=0)
                {
                    //获取行中的配方名
                    string name = this.dgv_Main.Rows[e.RowIndex].Cells[1].Value.ToString();
                    //得到Recipe文件目录下所有的文件
                    DirectoryInfo directoryInfo = new DirectoryInfo(basePath);
                    List<FileInfo> fileInfoList = directoryInfo.GetFiles("*.ini").ToList();
                    //只能获取到文件名，不能获取到文件路径
                    FileInfo fileInfo = fileInfoList.Where(p => p.Name.Contains(name)).FirstOrDefault();
                    //读取第一个文件，将其反序列化成RecipeInfo对象
                    RecipeInfo recipeinfo = GetRecipeInfo(basePath+@"\"+ fileInfo.ToString());
                    //让后将其对应的对应的文件读取出来,反序列化成RecipeInfo对象
                    //将其赋值给RecipeControl控件
                    SetRecipeInfo(recipeinfo);
                }
            }
        }
        #endregion

        /// <summary>
        /// 右键选中删除配方
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除配方ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgv_Main.Rows.Count>0)
            {
                string name = this.dgv_Main.CurrentRow.Cells[1].Value.ToString();
                DialogResult dialogresult = new FrmMsgBoxWithAck("删除配方", "配方设置").ShowDialog();
                if (dialogresult==DialogResult.OK)
                {
                    bool result = DeleteRecipe(name);
                    if (result)
                    {
                        CommonModel.AddLog(0, "配方删除成功");
                        new FrmMsgBoxWithoutAck("配方删除成功", "配方设置").ShowDialog();
                        this.txt_RecipeInfoName.Text = string.Empty;
                        RefreshRecipe();
                    }
                    else
                    {
                        CommonModel.AddLog(1, "配方删除失败");
                        new FrmMsgBoxWithoutAck("配方删除失败", "配方设置").ShowDialog();
                    }
                }
            }
        }
    }
}

