using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSAP.DAO.BSDAO;

namespace PSAP.PSAPCommon
{
    class ExceptionHandler
    {
        /// <summary>
        /// 处理异常方法
        /// </summary>
        /// <param name="exceptionText">异常信息文本</param>
        /// <param name="exception">异常实例</param>
        public static void HandleException(string exceptionText, Exception exception)
        {
            MessageHandler.ShowMessageBox(exceptionText+" 错误信息："+exception.Message);
            new ExceptionHandler().OutputLog(exceptionText, exception);
        }

        /// <summary>
        /// 构造方法
        /// </summary>
        public ExceptionHandler() { }

        /// <summary>
        /// 捕获的异常记录本地日志
        /// </summary>
        public void OutputLog(string exceptionText, Exception exception)
        {
            try
            {
                string st = exception.StackTrace;
                if (st != null && st != "")
                {
                    string[] sts = st.Split('在');
                    string msg = "";
                    for (int i = 0; i < sts.Length; i++)
                    {
                        if (sts[i].Contains("行号"))
                        {
                            msg += sts[i];
                        }
                    }
                    RecordLocalLogText(string.Format("{0}-{1}{3}{2}", exceptionText, exception.Message, msg, Environment.NewLine));
                }
                else
                {
                    RecordLocalLogText(string.Format("{0}-{1}{2}", exceptionText, exception.Message, Environment.NewLine));
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowMessageBox("记录异常日志失败-[" + ex.Message + "][" + exceptionText + "][" + exception.Message + "]");
            }
        }

        /// <summary>
        /// 记录本地日志文件
        /// </summary>
        /// <param name="level">异常等级字符串</param>
        /// <param name="msg">异常信息</param>
        private void RecordLocalLogText(string msg)
        {
            DateTime nowDate = BaseSQL.GetServerDateTime();
            string logPath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "Log";
            string filePath = logPath + @"\logtext" + nowDate.ToString("yyyyMMdd") + ".txt";
            StreamWriter text;
            if (File.Exists(filePath))
            {
                text = File.AppendText(filePath);
            }
            else
            {
                if (!File.Exists(logPath))
                {
                    Directory.CreateDirectory(logPath);
                }
                text = File.CreateText(filePath);
            }
            text.WriteLine(string.Format("{0} | {1}", nowDate.ToString("yyyy-MM-dd HH:mm:ss"), msg));
            text.Close();
        }

    }
}
