using PSAP.ENTITY.BSENTITY;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
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
        public static string CompTel = "86-22-83717906";

        /// <summary>
        /// 公司传真
        /// </summary>
        public static string CompFax = "86-22-83719776";

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
        public static int OrderQueryGrid_PageRowCount = 100;

        /// <summary>
        /// 各种登记单以下查询界面默认查询日期的时间段
        /// </summary>
        public static int OrderQueryDate_DefaultDays = 14;

        /// <summary>
        /// 采购订单里面的默认税率值
        /// </summary>
        public static double OrderList_DefaultTax = 0.16;

        /// <summary>
        /// 报价单里面的默认税率值
        /// </summary>
        public static double Quotation_DefaultTax = 0.16;

        /// <summary>
        /// 销售订单里面的默认税率值
        /// </summary>
        public static double SalesOrder_DefaultTax = 0.16;

        /// <summary>
        /// 请购单适用转换为采购订单，明细的合计总数是否可以超过原请购单的数量 
        /// </summary>
        public static bool PrReqApplyBeyondCountIsSave = false;

        /// <summary>
        /// 采购订单适用转换为入库单，明细的合计总数是否可以超过原采购订单的数量 
        /// </summary>
        public static bool OrderApplyBeyondCountIsSave = false;

        /// <summary>
        /// 入库单适用转换为采购结账单，明细的合计总数是否可以超过原入库单的数量 
        /// </summary>
        public static bool WarehouseWarrantApplyBeyondCountIsSave = false;

        /// <summary>
        /// 入库单是否可以修改入库日期
        /// </summary>
        public static bool WarehouseWarrantIsAlterDate = false;

        /// <summary>
        /// 出库单是否可以修改出库日期
        /// </summary>
        public static bool WarehouseReceiptIsAlterDate = false;

        /// <summary>
        /// 采购国内结账里面的默认税率值
        /// </summary>
        public static double Settlement_DefaultTax = 0.16;

        /// <summary>
        /// 可拖拽的窗体左侧停靠栏的默认宽度
        /// </summary>
        public static int DragForm_LeftDock_Width = 400;

        #endregion

        #region Socket设置参数

        /// <summary>
        /// 是否检查服务端程序
        /// </summary>
        public static bool IsCheckServer = false;

        /// <summary>
        /// 服务器的IP地址
        /// </summary>
        public static string serverIP = "192.168.0.146";

        /// <summary>
        /// 服务器通信的端口号
        /// </summary>
        public static int serverPort = 9988;

        /// <summary>
        /// 服务器通信协议类型
        /// </summary>
        public static ProtocolType serverProtocolType = ProtocolType.Tcp;

        /// <summary>
        /// 登陆保存密码
        /// </summary>
        public static bool LoginSavePwd = true;

        #endregion

    }
}
