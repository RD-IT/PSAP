using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSAP.PSAPCommon
{
    public class CommonHandler
    {
        /// <summary>
        /// 根据订单状态编号得到订单状态描述
        /// </summary>
        public static string Get_OrderState_Desc(string reqStateStr)
        {
            string StateDescStr = "";
            switch (reqStateStr)
            {
                case "1":
                    StateDescStr = "待审批";
                    break;
                case "2":
                    StateDescStr = "审批";
                    break;
                case "3":
                    StateDescStr = "关闭";
                    break;
                case "4":
                    StateDescStr = "审批中";
                    break;
            }
            return StateDescStr;
        }

        /// <summary>
        /// 根据入库单状态编号得到入库单状态描述
        /// </summary>
        public static string Get_WarehouseState_Desc(string wStateStr)
        {
            string StateDescStr = "";
            switch (wStateStr)
            {
                case "1":
                    StateDescStr = "待审批";
                    break;
                case "2":
                    StateDescStr = "审批";
                    break;
                case "3":
                    StateDescStr = "已结账";
                    break;
                case "4":
                    StateDescStr = "审批中";
                    break;
            }
            return StateDescStr;
        }

        /// <summary>
        /// 根据审批类型编号得到审批类型描述
        /// </summary>
        public static string Get_ApprovalCat_Desc(string approvalCatStr)
        {
            string approvalCatDescStr = "";
            switch (approvalCatStr)
            {
                case "0":
                    approvalCatDescStr = "串行审批";
                    break;
                case "1":
                    approvalCatDescStr = "并行审批";
                    break;
                case "2":
                    approvalCatDescStr = "多选一审核";
                    break;
            }
            return approvalCatDescStr;
        }

        /// <summary>
        /// 根据仓库类型编号得到仓库类型描述
        /// </summary>
        public static string Get_RepertoryType_Desc(string repertoryTypeStr)
        {
            string repertoryTypeDescStr = "";
            switch (repertoryTypeStr)
            {
                case "1":
                    repertoryTypeDescStr = "正常";
                    break;
                case "2":
                    repertoryTypeDescStr = "虚拟";
                    break;
            }
            return repertoryTypeDescStr;
        }
    }
}
