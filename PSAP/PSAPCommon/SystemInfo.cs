using PSAP.ENTITY.BSENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSAP.PSAPCommon
{
    class SystemInfo
    {
        /// <summary>
        /// 当前操作员信息类
        /// </summary>
        public static UserInfo user;

        /// <summary>
        /// 当前主机的IP地址
        /// </summary>
        public static string HostIpAddress;

        /// <summary>
        /// 各种登记单查询的列表每页显示行数
        /// </summary>
        public static int OrderQueryGrid_PageRowCount = 50;

        /// <summary>
        /// 订单明细里面的默认税率值
        /// </summary>
        public static double OrderList_DefaultTax = 0.16;

        /// <summary>
        /// 默认打印机名称
        /// </summary>
        public static string DefaultPrinterName = "";
    }
}
