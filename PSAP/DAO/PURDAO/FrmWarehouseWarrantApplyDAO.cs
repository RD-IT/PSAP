using PSAP.DAO.BSDAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PSAP.DAO.PURDAO
{
    class FrmWarehouseWarrantApplyDAO
    {
        /// <summary>
        /// 查询采购订单表
        /// </summary>
        public void QueryWWHead(DataTable queryDataTable, string wwHeadNoStr, string wwDateBeginStr, string wwDateEndStr, string projectNameStr, string commonStr)
        {
            string sqlStr = " Head.WarehouseState in (2) and IsNull(isEnd, 0)=0 ";
            if (wwHeadNoStr != "")
            {
                sqlStr += string.Format(" and Head.WarehouseWarrant like '%{0}%'", wwHeadNoStr);
            }
            if (wwDateBeginStr != "")
            {
                sqlStr += string.Format(" and Head.WarehouseWarrantDate between '{0}' and '{1}'", wwDateBeginStr, wwDateEndStr);
            }
            if (projectNameStr != "")
            {
                sqlStr += string.Format(" and Head.WarehouseWarrant in (select WarehouseWarrant from INV_WarehouseWarrantList where ProjectName = '{0}')", projectNameStr);
            }
            if (commonStr != "")
            {
                //sqlStr += string.Format(" and (OrderHeadNo like '%{0}%' or Head.ProjectNo like '%{0}%' or Head.StnNo like '%{0}%' or Head.PrReqRemark like '%{0}%' or Head.ApprovalType like '%{0}%' or Head.PayTypeNo like '%{0}%')", commonStr);
            }
            sqlStr = string.Format("select Head.* from INV_WarehouseWarrantHead as Head where {0} order by Head.AutoId", sqlStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 查询采购订单明细表
        /// </summary>
        public void QueryWWList(DataTable queryDataTable, string wwHeadNoStr)
        {
            string sqlStr = "";
            if (wwHeadNoStr != "")
            {
                sqlStr += string.Format(" and WarehouseWarrant='{0}'", wwHeadNoStr);
            }
            sqlStr = string.Format("select WWList.*, Parts.CodeName, WWList.Qty-WWList.SettlementCount as Overplus, Olist.Unit, Olist.Tax from V_INV_WarehouseWarrentList_Settlement as WWList left join SW_PartsCode as Parts on WWList.CodeFileName = Parts.CodeFileName left join PUR_OrderList as Olist on Olist.AutoId = WWList.PoListAutoId where WWList.Qty>WWList.SettlementCount {0} order by WWList.AutoId", sqlStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }
    }
}
