using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


namespace PSAP.DAO.BSDAO
{
    class GetDepartmentList
    {
        public static DataTable getDepartmentList()
        {
            string sqlString = "select distinct a.DepartmentName " +
            "from BS_Department a " +
            "union " +
            "select '' from BS_Department b ";
            DataTable dtblTmp = new DataTable();
            dtblTmp = BaseSQL.GetTableBySql(sqlString);
            return dtblTmp;
        }
    }
}
