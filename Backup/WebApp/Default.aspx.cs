using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogUtility;

namespace WebApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
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

            Response.Write("日志记录完毕。</br>");

        }
    }
}