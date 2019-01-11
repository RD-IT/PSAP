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
        /// 查询请购单表
        /// </summary>
        /// <param name="queryDataTable">要查询填充的数据表</param>
        /// <param name="prReqNoStr">请购单号</param>
        public void QueryPrReqHead(DataTable queryDataTable, string prReqNoStr,string reqDateBeginStr,string reqDateEndStr, string reqDepStr, string purCategoryStr, string applicantStr, string projectNoStr, string commonStr)
        {
            string sqlStr = " ReqState in (2) and IsNull(isEnd, 0)=0 ";
            if (prReqNoStr != "")
            {
                sqlStr += string.Format(" and PrReqNo like '%{0}%'", prReqNoStr);
            }
            if (reqDateBeginStr != "")
            {
                sqlStr += string.Format(" and ReqDate between '{0}' and '{1}'", reqDateBeginStr, reqDateEndStr);
            }
            if (reqDepStr != "")
            {
                sqlStr += string.Format(" and ReqDep='{0}'", reqDepStr);
            }
            if (purCategoryStr != "")
            {
                sqlStr += string.Format(" and PurCategory='{0}'", purCategoryStr);
            }
            if (applicantStr != "")
            {
                sqlStr += string.Format(" and Applicant='{0}'", applicantStr);
            }
            if(projectNoStr!="")
            {
                sqlStr += string.Format(" and ProjectNo='{0}'", projectNoStr);
            }
            if (commonStr != "")
            {
                sqlStr += string.Format(" and (PrReqNo like '%{0}%' or ProjectNo like '%{0}%' or StnNo like '%{0}%' or PrReqRemark like '%{0}%')", commonStr);
            }
            sqlStr = string.Format("select * from PUR_PrReqHead where {0} order by AutoId", sqlStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 查询请购单明细表
        /// </summary>
        /// <param name="queryDataTable">要查询填充的数据表</param>
        /// <param name="prReqNoStr">请购单号</param>
        public void QueryPrReqList(DataTable queryDataTable, string prReqNoStr)
        {
            string sqlStr = "";
            if (prReqNoStr != "")
            {
                sqlStr += string.Format(" and PrReqNo='{0}'", prReqNoStr);
            }
            sqlStr = string.Format("select PrReq.*, Parts.CodeName, PrReq.Qty-PrReq.OrderCount as Overplus from V_PUR_PrReqList_Order as PrReq left join SW_PartsCode as Parts on PrReq.CodeFileName = Parts.CodeFileName where PrReq.Qty>PrReq.OrderCount {0} order by PrReq.AutoId", sqlStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }
    }
}
