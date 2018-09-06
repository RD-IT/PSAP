using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PSAP.BLL.BSBLL;
using PSAP;

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
            Application.Run(new FrmLogin());
            if (PSAPCommon.LoginInfo != null)
            {
                FrmMain frmMain = new FrmMain();
                frmMain.WindowState = FormWindowState.Maximized;
                Application.Run(frmMain);
            }
        }
    }
}
