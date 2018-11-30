using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSAP.DAO.BSDAO
{
    class FrmBussinessInfoDAO
    {
        public static ArrayList strSqlLlist = new ArrayList();//存储SQL语句
        public static ArrayList strTablesName = new ArrayList();//存储返回表名


        public static DataSet InitDataSet()
        {
            strSqlLlist.Clear();
            string strSql = "select * from BS_BussinessBaseInfo ";
            strSqlLlist.Add(strSql);
            strSql = "BS_BussinessBaseInfo";
            strTablesName.Add(strSql);

            strSql = "select * from BS_BussinessDetailInfo";
            strSqlLlist.Add(strSql);
            strSql = "BS_BussinessDetailInfo";
            strTablesName.Add(strSql);

            strSql = "select * from BS_BussinessFinancialInfo";
            strSqlLlist.Add(strSql);
            strSql = "BS_BussinessFinancialInfo";
            strTablesName.Add(strSql);
            DataSet ds = new DataSet();
            ds=BSDAO.BaseSQL.GetDataSetBySql(strSqlLlist,strTablesName);
            return ds;
        }
    }
}
