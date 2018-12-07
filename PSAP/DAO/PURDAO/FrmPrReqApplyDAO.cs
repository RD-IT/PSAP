using PSAP.DAO.BSDAO;
using PSAP.PSAPCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSAP.DAO.PURDAO
{
    class FrmPrReqApplyDAO
    {
        /// <summary>
        /// 查询采购请购单明细表
        /// </summary>
        /// <param name="queryDataTable">要查询填充的数据表</param>
        /// <param name="prReqNoStr">请购单号</param>
        public void QueryPrReqList(DataTable queryDataTable, string prReqNoStr)
        {
            string sqlStr = "";
            if (prReqNoStr != "")
            {
                prReqNoStr += string.Format(" and PrReqNo='{0}'", prReqNoStr);
            }
            sqlStr = string.Format("select PUR_PrReqList.*, SW_PartsCode.CodeName, (select IsNull(SUM(Qty),0) from PUR_OrderList where PUR_OrderList.PrReqNo = PUR_PrReqList.PrReqNo) as OrderCount  from PUR_PrReqList left join SW_PartsCode on PUR_PrReqList.CodeFileName = SW_PartsCode.CodeFileName where 1=1 {0} order by AutoId", sqlStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }
    }
}
