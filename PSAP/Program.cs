using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PSAP.BLL.BSBLL;
using PSAP;
using PSAP.ENTITY.BSENTITY;
using PSAP.DAO.BSDAO;
using System.Configuration;
using PSAP.PSAPCommon;

namespace PSAP.VIEW.BSVIEW
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
                Application.EnableVisualStyles();
                ConfigurationManager.RefreshSection("PSAP.Properties.Settings.PSAPConnectionString");//重新加载新的配置文件  
                ConfigurationManager.RefreshSection("ThemeId");
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh-CN");
                Application.Run(new FrmLogin());
                //if (PSAPCommon.LoginInfo != null)
                if (SystemInfo.user != null)
                {
                    InitializationSystemInfo();

                    FrmMain frmMain = new FrmMain();
                    frmMain.WindowState = FormWindowState.Maximized;
                    Application.Run(frmMain);
                }
        }

        /// <summary>
        /// 初始化系统信息
        /// </summary>
        private static void InitializationSystemInfo()
        {
            SystemInfo.HostIpAddress = new SystemHandler().GetIpAddress();
        }
    }
}
