using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Drawing;

namespace PSAP.PSAPCommon
{
    class SystemHandler
    {
        /// <summary>
        /// 获取本机名
        /// </summary>
        public string GetHostName()
        {
            return Dns.GetHostName();
        }

        /// <summary>
        /// 获取本机的IP地址
        /// </summary>
        public string GetIpAddress()
        {
            string hostName = Dns.GetHostName();
            IPAddress[] ipadrlist = Dns.GetHostAddresses(hostName);
            foreach (IPAddress ipa in ipadrlist)
            {
                if (ipa.AddressFamily == AddressFamily.InterNetwork)
                    return ipa.ToString();
            }
            throw new Exception("获取本机的IP地址异常。");
        }

        /// <summary>
        /// 初始化系统信息
        /// </summary>
        public void InitializationSystemInfo(string pwdStr)
        {
            SystemInfo.HostIpAddress = GetIpAddress();
            string SourFilePath = "Images\\CompanyLogo.jpg";
            if (File.Exists(SourFilePath))
            {
                Image img = new Bitmap(SourFilePath);
                SystemInfo.CompImage = img;
            }

            FileHandler fileHandler = new FileHandler();
            string iniPath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase.TrimEnd('\\') + "\\Config.ini";
            string sectionStr = "System";
            fileHandler.IniWriteValue(iniPath, sectionStr, "LastLoginID", SystemInfo.user.LoginID);
            if(SystemInfo.LoginSavePwd)
            {
                fileHandler.IniWriteValue(iniPath, sectionStr, "LastLoginPwd", pwdStr);
            }        

            #region 设置连接服务端的IP地址和端口号
            
            SystemInfo.serverIP = new SystemHandler().GetIpAddress();

            if (File.Exists(iniPath))
            {
                string serverIpStr = fileHandler.IniReadValue(iniPath, sectionStr, "ServerIP");
                int portInt = DataTypeConvert.GetInt(fileHandler.IniReadValue(iniPath, sectionStr, "ServerPort"));
                if (serverIpStr != "")
                    SystemInfo.serverIP = serverIpStr;
                else
                    fileHandler.IniWriteValue(iniPath, sectionStr, "ServerIP", SystemInfo.serverIP);
                if (portInt > 0)
                    SystemInfo.serverPort = portInt;
                else
                    fileHandler.IniWriteValue(iniPath, sectionStr, "ServerPort", SystemInfo.serverPort.ToString());
            }
            else
            {
                fileHandler.IniWriteValue(iniPath, sectionStr, "ServerIP", SystemInfo.serverIP);
                fileHandler.IniWriteValue(iniPath, sectionStr, "ServerPort", SystemInfo.serverPort.ToString());
            }

            #endregion
        }
    }
}
