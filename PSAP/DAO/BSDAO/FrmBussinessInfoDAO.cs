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

        /// <summary>
        /// 初始化数据集
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// 删除相关数据
        /// </summary>
        /// <param name="strBussinessBaseNo"></param>
        public static void DeleteBussinessCorrelationData(string strBussinessBaseNo)
        {
            strSqlLlist.Clear();
            string strSql = @"delete from BS_BussinessDetailInfo where BussinessBaseNo like '" + strBussinessBaseNo + "'";
            strSqlLlist.Add(strSql);

            strSql = @"delete from BS_BussinessFinancialInfo where BussinessBaseNo like '" + strBussinessBaseNo + "'";
            strSqlLlist.Add(strSql);

            strSql = @"delete from BS_BussinessBaseInfo where BussinessBaseNo like '" + strBussinessBaseNo + "'";
            strSqlLlist.Add(strSql);
            BaseSQL.ExecuteSqlTran(strSqlLlist);
        }
    }
}
