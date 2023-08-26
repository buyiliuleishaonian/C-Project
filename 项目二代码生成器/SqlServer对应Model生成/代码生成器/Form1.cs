using Sqlhelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 代码生成器
{
    public partial class FrmMain : Form
    {
        private List<string> list = new List<string>();

        public FrmMain()
        {
            InitializeComponent();
            //聚焦到其上
            this.txtServer.Focus();
            this.txtServer.SelectAll();
        }
        

        /// <summary>
        /// 连接数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConSQL_Click(object sender, EventArgs e)
        {
            if (this.txtPwd.Text.Trim().Length == 0 || this.txtServer.Text.Trim().Length == 0 || this.txtUid.Text.Trim().Length == 0)
            {
                MessageBox.Show("有空数据要求，无法连接", "提示信息");
            }
            //等到数据库
            this.list = null;
            this.list = SqlHelper.GetServerName1(this.txtServer.Text, this.txtUid.Text, this.txtPwd.Text);

            if (this.list != null)
            {
                MessageBox.Show("连接数据库成功，已将所有数据库名称读取", "提示信息");

                //将其放在下拉框中
                this.cmbServer.DataSource = this.list;
                this.cmbServer.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("连接失败，请检查服务器，用户名和密码","提示信息");
                return;
            }

        }

        /// <summary>
        /// 生成Model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModel_Click(object sender, EventArgs e)
        {
            //文件夹绝对路径
            string path = null;
            //文件夹的名字
            string pathName = null;
            if (this.cmbServer.Text.Trim().Length == 0 && this.cmbServer.Text == null) return;
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            // 在对话框中显示描述文本
            folderBrowserDialog.Description = "请选择文件夹路径";

            // 指定默认选中的文件夹路径
            folderBrowserDialog.SelectedPath = @"F:\";

            // 显示文件夹选择对话框
            DialogResult result = folderBrowserDialog.ShowDialog();
            // 检查用户是否点击了 "OK" 按钮
            if (result == DialogResult.OK)
            {
                // 获取所选文件夹的路径
                path = folderBrowserDialog.SelectedPath;
                int nums=path.Length;
                //文本路径最后出现"\"
                int number= path.LastIndexOf(@"\");
               pathName= path.Substring(number+1);
            }
            else
            {
                return;
            }
            StringBuilder str = SqlHelper.GetModel(this.txtServer.Text, this.txtUid.Text,
                this.txtPwd.Text, this.cmbServer.Text, path,pathName);
            MessageBox.Show("生成成功", "提示信息");
            this.txtServer.Text = null;
            this.txtPwd.Text = null;
            this.txtUid.Text = null;
            this.cmbServer.SelectedIndex = -1;
            this.txtServer.Focus();
        }

        /// <summary>
        /// 按下回车键去到用户名哪里
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtServer_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtServer.Text.Trim().Length != 0 && e.KeyValue == 13)
            {
                this.txtUid.Focus();
                return;
            }
        }

        /// <summary>
        /// 按下回车键去到密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUid_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtUid.Text.Trim().Length != 0 && e.KeyValue == 13)
            {
                this.txtPwd.Focus();
                return;
            }
        }

        /// <summary>
        /// 按下回车键去到按钮连接数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtPwd.Text.Trim().Length != 0 && e.KeyValue == 13)
            {
                this.BtnConSQL.Focus();
                return;
            }
        }

        /// <summary>
        /// 按下回车键去到按钮生成Model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbServer_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.cmbServer.Text.Trim().Length != 0 && e.KeyValue == 13)
            {
                this.btnModel.Focus();
                return;
            }
        }
    }
}
