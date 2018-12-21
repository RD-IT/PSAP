using PSAP.ENTITY.BSENTITY;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSAP.PSAPCommon
{
    class SystemInfo
    {
        #region 公司信息

        /// <summary>
        /// 公司名称
        /// </summary>
        public static string CompanyName = "天津容大机电科技有限公司";

        /// <summary>
        /// 公司地址
        /// </summary>
        public static string CompAddress = "天津市 华苑产业区 物华道2号 海泰火炬创业园 B座101室";
        /// <summary>
        /// 公司邮编
        /// </summary>
        public static string CompZipCode = "300384";

        /// <summary>
        /// 公司电话
        /// </summary>
        public static string CompTel = "+86-22-83717906";

        /// <summary>
        /// 公司传真
        /// </summary>
        public static string CompFax = "+86-22-83719776";

        /// <summary>
        /// 公司网址
        /// </summary>
        public static string CompWebSite = "www.rongda-tech.com";

        /// <summary>
        /// 公司商标
        /// </summary>
        public static Image CompImage = null;

        /// <summary>
        /// 工厂地址
        /// </summary>
        public static string PlantAddress = "天津市 西青学府工业区 学府西路2号 西区J4厂房 A座、B座";
        /// <summary>
        /// 工厂邮编
        /// </summary>
        public static string PlantZipCode = "300382";

        #endregion

        #region 系统信息

        /// <summary>
        /// 当前操作员信息类
        /// </summary>
        public static UserInfo user;

        /// <summary>
        /// 当前主机的IP地址
        /// </summary>
        public static string HostIpAddress;

        /// <summary>
        /// 默认打印机名称
        /// </summary>
        public static string DefaultPrinterName = "";

        #endregion

        #region 系统参数

        /// <summary>
        /// 各种登记单查询的列表每页显示行数
        /// </summary>
        public static int OrderQueryGrid_PageRowCount = 50;

        /// <summary>
        /// 订单明细里面的默认税率值
        /// </summary>
        public static double OrderList_DefaultTax = 0.16;

        #endregion
    }
}
