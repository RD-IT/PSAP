using PSAP.DAO.BSDAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSAP.DAO.INVDAO
{
    class FrmWarehouseNowInfoDAO
    {
        /// <summary>
        /// 查询当前库存表
        /// </summary>
        public void QueryWarehouseNowInfo(DataTable queryDataTable, string codeFileNameStr, string repertoryNoStr, string projectNameStr, bool isIncludeZeroBool)
        {
            string sqlStr = " Qty>0";
            if(isIncludeZeroBool)
            {
                sqlStr = " 1=1";
            }
            if (codeFileNameStr != "")
            {
                sqlStr += string.Format(" and CodeFileName='{0}'", codeFileNameStr);
            }
            if (repertoryNoStr != "")
            {
                sqlStr += string.Format(" and RepertoryNo='{0}'", repertoryNoStr);
            }
            if (projectNameStr != "")
            {
                sqlStr += string.Format(" and ProjectName='{0}'", projectNameStr);
            }
            sqlStr = string.Format("select AutoId, CodeFileName, CodeName, ProjectNo, ProjectName, RepertoryNo, ShelfNo, Qty from V_INV_WarehouseNowInfo where {0} order by RepertoryNo, ProjectNo, CodeFileName, ShelfNo", sqlStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 当前库存查询的SQL
        /// </summary>
        public string QueryWarehouseNowInfo_SQL(string codeFileNameStr, string repertoryNoStr, string projectNameStr, string shelfNoStr, string commonStr, bool isIncludeZeroBool)
        {
            string sqlStr = " Qty>0";
            if (isIncludeZeroBool)
            {
                sqlStr = " 1=1";
            }
            if (codeFileNameStr != "")
            {
                sqlStr += string.Format(" and CodeFileName='{0}'", codeFileNameStr);
            }
            if (repertoryNoStr != "")
            {
                sqlStr += string.Format(" and RepertoryNo='{0}'", repertoryNoStr);
            }
            if (projectNameStr != "")
            {
                sqlStr += string.Format(" and ProjectName='{0}'", projectNameStr);
            }
            if (shelfNoStr != "")
            {
                sqlStr += string.Format(" and ShelfNo='{0}'", shelfNoStr);
            }
            if (commonStr != "")
            {
                sqlStr += string.Format(" and (CodeName like '%{0}%' or CodeSpec like '%{0}%' or Brand like '%{0}%' or CatgName like '%{0}%')", commonStr);
            }
            sqlStr = string.Format("select * from V_INV_WarehouseNowInfo where {0} order by RepertoryNo, CodeFileName, ProjectName, ShelfNo", sqlStr);
            return sqlStr;
        }

        /// <summary>
        /// 更新当前的库存数
        /// </summary>
        public bool Update_WarehouseNowInfo(SqlCommand cmd, string warehouseNoStr, int HandleType, out string errorText)
        {
            int resultInt = 0;
            SqlParameter p1 = new SqlParameter("@WarehouseNo", SqlDbType.VarChar);
            p1.Value = warehouseNoStr;
            SqlParameter p2 = new SqlParameter("@HandleType", SqlDbType.VarChar);
            p2.Value = HandleType;
            IDataParameter[] parameters = new System.Data.IDataParameter[] { p1, p2 };
            return BaseSQL.RunProcedure(cmd, "P_Update_WarehouseNowInfo", parameters, out resultInt, out errorText);
        }
    }
}
