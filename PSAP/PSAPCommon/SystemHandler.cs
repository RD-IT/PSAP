using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

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
    }
}
