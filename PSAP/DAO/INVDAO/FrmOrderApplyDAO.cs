using PSAP.DAO.BSDAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSAP.DAO.INVDAO
{
    class FrmOrderApplyDAO
    {
        /// <summary>
        /// 查询采购订单表
        /// </summary>
        public void QueryOrderHead(DataTable queryDataTable,string orderHeadNoStr,string orderDateBeginStr,string orderDateEndStr, string reqDepStr, string purCategoryStr, string preparedStr, string projectNoStr, string bussinessBaseNoStr, string commonStr)
        {
            string sqlStr = " Head.ReqState in (2)";
            if (orderHeadNoStr != "")
            {
                sqlStr += string.Format(" and Head.OrderHeadNo='{0}'", orderHeadNoStr);
            }
            if (orderDateBeginStr != "")
            {
                sqlStr += string.Format(" and Head.OrderHeadDate between '{0}' and '{1}'", orderDateBeginStr, orderDateEndStr);
            }
            if (reqDepStr != "")
            {
                sqlStr += string.Format(" and Head.ReqDep='{0}'", reqDepStr);
            }
            if (purCategoryStr != "")
            {
                sqlStr += string.Format(" and Head.PurCategory='{0}'", purCategoryStr);
            }
            if (preparedStr != "")
            {
                sqlStr += string.Format(" and Head.Prepared='{0}'", preparedStr);
            }
            if (projectNoStr != "")
            {
                sqlStr += string.Format(" and Head.ProjectNo='{0}'", projectNoStr);
            }
            if(bussinessBaseNoStr!="")
            {
                sqlStr += string.Format(" and Head.BussinessBaseNo='{0}'", bussinessBaseNoStr);
            }
            if (commonStr != "")
            {
                sqlStr += string.Format(" and (OrderHeadNo like '%{0}%' or Head.ProjectNo like '%{0}%' or Head.StnNo like '%{0}%' or Head.PrReqRemark like '%{0}%' or Head.ApprovalType like '%{0}%' or Head.PayTypeNo like '%{0}%')", commonStr);
            }
            sqlStr = string.Format("select Head.*, BS_ProjectList.ProjectName from PUR_OrderHead as Head join BS_ProjectList on Head.ProjectNo = BS_ProjectList.ProjectNo where {0} order by Head.AutoId", sqlStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 查询采购订单明细表
        /// </summary>
        public void QueryOrderList(DataTable queryDataTable,string orderHeadNoStr)
        {
            string sqlStr = "";
            if (orderHeadNoStr != "")
            {
                sqlStr += string.Format(" and OrderHeadNo='{0}'", orderHeadNoStr);
            }
            sqlStr = string.Format("select OList.*, Parts.CodeName, OList.Qty-OList.WarehouseWarrentCount as Overplus from V_PUR_OrderList_WarehouseWarrent as OList left join SW_PartsCode as Parts on OList.CodeFileName = Parts.CodeFileName where OList.Qty>OList.WarehouseWarrentCount {0} order by OList.AutoId", sqlStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }
    }
}
