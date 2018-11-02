using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PSAP.BLL.BSBLL;
using PSAP;
using PSAP.ENTITY.BSENTITY;
using PSAP.DAO.BSDAO;
using System.Configuration;

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
            Application.Run(new FrmLogin());
            //if (PSAPCommon.LoginInfo != null)
            if(FrmLoginDAO.user!=null)
            {
                FrmMain frmMain = new FrmMain();
                frmMain.WindowState = FormWindowState.Maximized;
                Application.Run(frmMain);
            }
        }
    }
}
