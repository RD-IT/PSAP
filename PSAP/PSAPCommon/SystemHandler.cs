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
        public void InitializationSystemInfo()
        {
            SystemInfo.HostIpAddress = GetIpAddress();
            string SourFilePath = "Images\\CompanyLogo.jpg";
            if (File.Exists(SourFilePath))
            {
                Image img = new Bitmap(SourFilePath);
                SystemInfo.CompImage = img;
            }

            #region 设置连接服务端的IP地址和端口号

            string iniPath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase.TrimEnd('\\') + "\\Config.ini";
            string sectionStr = "System";
            SocketHandler.serverIP = new SystemHandler().GetIpAddress();
            if (System.IO.File.Exists(iniPath))
            {
                string serverIpStr = FileHandler.IniReadValue(iniPath, sectionStr, "ServerIP");
                int portInt = DataTypeConvert.GetInt(FileHandler.IniReadValue(iniPath, sectionStr, "ServerPort"));
                if (serverIpStr != "")
                    SocketHandler.serverIP = serverIpStr;
                else
                    FileHandler.IniWriteValue(iniPath, sectionStr, "ServerIP", SocketHandler.serverIP);
                if (portInt > 0)
                    SocketHandler.serverPort = portInt;
                else
                    FileHandler.IniWriteValue(iniPath, sectionStr, "ServerPort", SocketHandler.serverPort.ToString());
            }
            else
            {
                SocketHandler.serverIP = new SystemHandler().GetIpAddress();
                FileHandler.IniWriteValue(iniPath, sectionStr, "ServerIP", SocketHandler.serverIP);
                FileHandler.IniWriteValue(iniPath, sectionStr, "ServerPort", SocketHandler.serverPort.ToString());
            }

            #endregion
        }
    }
}
