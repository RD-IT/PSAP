using PSAP.VIEW.BSVIEW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSAP.PSAPCommon
{
    public class CommonHandler
    {
        static FrmLanguageText f = new FrmLanguageText();
        public CommonHandler()
        {
            PSAP.BLL.BSBLL.BSBLL.language(f);//刷新窗口语言
        }

        /// <summary>
        /// 根据订单状态编号得到订单状态描述
        /// </summary>
        public static string Get_OrderState_Desc(string reqStateStr)
        {
            string stateDescStr = "";
            switch (reqStateStr)
            {
                case "1":
                    //stateDescStr = "待审批";
                    stateDescStr = f.tsmiDsp.Text;
                    break;
                case "2":
                    //stateDescStr = "审批";
                    stateDescStr = f.tsmiSp.Text;
                    break;
                case "3":
                    //stateDescStr = "关闭";
                    stateDescStr = f.tsmiGb.Text;
                    break;
                case "4":
                    //stateDescStr = "审批中";
                    stateDescStr = f.tsmiSpz.Text;
                    break;
            }
            return stateDescStr;
        }

        /// <summary>
        /// 根据入库单状态编号得到入库单状态描述
        /// </summary>
        public static string Get_WarehouseState_Desc(string wStateStr)
        {
            string stateDescStr = "";
            switch (wStateStr)
            {
                case "1":
                    //stateDescStr = "待审批";
                    stateDescStr = f.tsmiDsp.Text;
                    break;
                case "2":
                    //stateDescStr = "审批";
                    stateDescStr = f.tsmiSp.Text;
                    break;
                case "3":
                    //stateDescStr = "已结账";
                    stateDescStr = f.tsmiYjz.Text;
                    break;
                case "4":
                    //stateDescStr = "审批中";
                    stateDescStr = f.tsmiSpz.Text;
                    break;
            }
            return stateDescStr;
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
                    //approvalCatDescStr = "串行审批";
                    approvalCatDescStr = f.tsmiCxsp.Text;
                    break;
                case "1":
                    //approvalCatDescStr = "并行审批";
                    approvalCatDescStr = f.tsmiBxsp.Text;
                    break;
                case "2":
                    //approvalCatDescStr = "多选一审核";
                    approvalCatDescStr = f.tsmiDxysh.Text;
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
                    //repertoryTypeDescStr = "正常";
                    repertoryTypeDescStr = f.tsmiZc.Text;
                    break;
                case "2":
                    //repertoryTypeDescStr = "虚拟";
                    repertoryTypeDescStr = f.tsmiXn.Text;
                    break;
            }
            return repertoryTypeDescStr;
        }

        /// <summary>
        /// 根据工程类型编号得到工程类型描述
        /// </summary>
        public static string Get_ManufactureType_Desc(string manufactureTypeStr)
        {
            string manufactureTypeDescStr = "";
            switch (manufactureTypeStr)
            {
                case "1":
                    //manufactureTypeDescStr = "正常";
                    manufactureTypeDescStr = f.tsmiZc.Text;
                                        break;
                case "2":
                    //manufactureTypeDescStr = "虚拟";
                    manufactureTypeDescStr = f.tsmiXn.Text;
                                        break;
            }
            return manufactureTypeDescStr;
        }
    }
}
