using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LogUtility;

namespace WinFormApp
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //加载日志配置文件，只需要在程序启动时加载一次
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "Log4net.config";
            LogHelper.SetConfig(filePath);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
