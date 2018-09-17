using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogUtility;

namespace WinFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //记录一般信息
            LogHelper.Info("info");
            //记录调试信息
            LogHelper.Debug("debug");
            //记录警告信息
            LogHelper.Warn("warn");

            //记录错误日志
            LogHelper.Error("error", new Exception("发生了一个异常"));
            //记录严重错误
            LogHelper.Fatal("fatal", new Exception("发生了一个致命错误"));

             MessageBox.Show("日志记录完毕。");
        }
    }
}
