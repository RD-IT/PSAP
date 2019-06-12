using PSAP.DAO.BSDAO;
using PSAP.PSAPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PSAP.VIEW.BSVIEW
{
    public partial class FrmSystemSet : DockContent
    {
        FrmCommonDAO commonDAO = new FrmCommonDAO();

        public FrmSystemSet()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件 
        /// </summary>
        private void FrmSystemSet_Load(object sender, EventArgs e)
        {
            try
            {
                textBackupPath.Text = SystemInfo.DataBaseBackupPath;
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
            }
        }

        /// <summary>
        /// 备份服务器的数据库
        /// </summary>
        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBackupPath.Text.Trim() == "")
                {
                    MessageHandler.ShowMessageBox("数据库备份路径不能为空，请重新操作。");
                    return;
                }

                DateTime nowTime = BaseSQL.GetServerDateTime();
                string fileNameStr = string.Format("{0}-{1}.bak", SystemInfo.ServerDataBaseName, nowTime.ToString("yyyyMMddHHmmss"));
                string filePathNameStr = string.Format("{0}\\{1}", textBackupPath.Text.Trim(), fileNameStr);
                //if (BaseSQL.BackupDataBase(SystemInfo.ServerDataBaseName, filePathNameStr))//数据库SQL备份，没有进度条
                //{
                //    MessageHandler.ShowMessageBox(string.Format("备份数据库成功，文件名为[{0}]。", fileNameStr));
                //}

                if (BackupDataBase(SystemInfo.ServerDataBaseName, filePathNameStr, progressBarBackup))//引用SQLDMO类备份，有进度条
                {
                    MessageHandler.ShowMessageBox(string.Format("备份数据库成功，文件名为[{0}]。", fileNameStr));
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowMessageBox(string.Format("备份数据库失败--{0}。", ex.Message));
            }
        }

        /// <summary>
        /// 备份数据库
        /// </summary>
        public bool BackupDataBase(string strDbName, string strFileName, ProgressBar proBar)
        {
            SQLDMO.SQLServer sqlServer = new SQLDMO.SQLServer();
            try
            {
                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["PSAP.Properties.Settings.PSAPConnectionString"].ConnectionString;
                string tmpStr = "Data Source=";
                string DataSource = connectionString.Substring(connectionString.IndexOf(tmpStr) + tmpStr.Length);
                DataSource = DataSource.Substring(0, DataSource.IndexOf(";"));

                tmpStr = "User ID=";
                string UserID = connectionString.Substring(connectionString.IndexOf(tmpStr) + tmpStr.Length);
                if (UserID.IndexOf(";") == -1)
                    UserID = UserID.Substring(0);
                else
                    UserID = UserID.Substring(0, UserID.IndexOf(";"));

                tmpStr = "Password=";
                string Password = connectionString.Substring(connectionString.IndexOf(tmpStr) + tmpStr.Length);
                if (Password.IndexOf(";") == -1)
                    Password = Password.Substring(0);
                else
                    Password = Password.Substring(0, Password.IndexOf(";"));

                sqlServer.Connect(DataSource, UserID, Password);
                SQLDMO.Backup backup = new SQLDMO.Backup();
                proBar.Value = 0;
                backup.Action = SQLDMO.SQLDMO_BACKUP_TYPE.SQLDMOBackup_Database;
                backup.Initialize = true;
                backup.PercentComplete += new SQLDMO.BackupSink_PercentCompleteEventHandler(Backup_PercentComplete);
                backup.Files = strFileName;
                backup.Database = strDbName;
                backup.PercentCompleteNotification = 1;
                backup.SQLBackup(sqlServer);
                proBar.Value = 100;
                backup.PercentComplete -= new SQLDMO.BackupSink_PercentCompleteEventHandler(Backup_PercentComplete);
                backup = null;
                return true;
            }
            catch (Exception err)
            {
                throw (new Exception("备份数据库失败" + err.Message));
            }
            finally
            {
                sqlServer.DisConnect();
            }
        }

        /// <summary>
        /// 实时刷新进度条的方法
        /// </summary>
        private void Backup_PercentComplete(string message, int percent)
        {
            char[] a = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            int startPos = message.IndexOfAny(a);
            int endPos = message.LastIndexOfAny(a);
            int value = DataTypeConvert.GetInt(message.Substring(startPos, endPos - startPos + 1));
            progressBarBackup.Value = value;
            Application.DoEvents();
        }
    }
}
