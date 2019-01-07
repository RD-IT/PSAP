using PSAP.DAO.BSDAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSAP.DAO.INVDAO
{
    class FrmWarehouseReceiptDAO
    {
        /// <summary>
        /// 查询出库类别（增加一个全部选项）
        /// </summary>
        public DataTable QueryWarehouseReceiptType(bool addAllItem)
        {
            string sqlStr = "select AutoId, WarehouseReceiptTypeNo, WarehouseReceiptTypeName, IsDefault from BS_WarehouseReceiptType Order by AutoId";
            if (addAllItem)
            {
                sqlStr = "select 0 as AutoId, '全部' as WarehouseReceiptTypeNo, '全部' as WarehouseReceiptTypeName, 0 as IsDefault union " + sqlStr;
            }
            return BaseSQL.GetTableBySql(sqlStr);
        }

    }
}
