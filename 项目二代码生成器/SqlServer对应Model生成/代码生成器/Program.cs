using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 代码生成器
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmMain form = new FrmMain();
            Icon ico = ConvertPngToIcon("wallhaven-x1xy9l_1920x1080.png");
            form.Icon = ico;    
            Application.Run(form);
        }
        static Icon ConvertPngToIcon(string pngFilePath)
        {
            // 加载 .png 图片
            Image image = Image.FromFile(pngFilePath);

            // 创建一个 Bitmap 对象
            Bitmap bitmap = new Bitmap(image);

            // 释放原始图片资源
            image.Dispose();

            // 转换为 .ico 图标
            Icon icon = Icon.FromHandle(bitmap.GetHicon());

            // 释放 Bitmap 资源
            bitmap.Dispose();

            return icon;
        }
    }
}
