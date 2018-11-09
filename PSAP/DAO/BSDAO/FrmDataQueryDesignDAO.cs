using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSAP.DAO.BSDAO
{
    class FrmDataQueryDesignDAO
    {
        public static ArrayList strSqlLlist = new ArrayList();//存储生成的SQL语句

        /// <summary>
        /// 获取根部门数据
        /// </summary>
        /// <returns></returns>
        public static DataTable GetTopQuerySqlData()
        {
            string sql = "select * from BS_QuerySql where ParentId is null order by ItemOrder "; //根部门，其父部门id为null
            DataTable dt = BaseSQL.GetTableBySql(sql);
            return dt;
        }

        /// <summary>
        /// 获取子部门数据
        /// </summary>
        /// <returns></returns>
        public static DataTable GetChildQuerySqlData(string strParentId)
        {
            string sql = "select * from BS_QuerySql where convert(varchar(10),ParentId) ='" + strParentId + "' order by ItemOrder ";
            DataTable dt = BaseSQL.GetTableBySql(sql);
            return dt;
        }

        /// <summary>
        /// 获取存储过程参数列表
        /// </summary>
        /// <param name="strProcedureName"></param>
        /// <returns></returns>
        public static void CreateProcedureParaList(string strQuerySqlId, string strProcedureName)
        {
            strSqlLlist.Clear();
            string strSql =
            "delete from BS_QuerySqlParameter " +
            "where convert(varchar(10), querySqlId)='" + strQuerySqlId + "' " +
            "and parametersName + parametersCatg not in ( " +
                "select a.name + b.name " +
                "from syscolumns a " +
                "left join systypes b on a.xtype = b.xusertype " +
                "where id = (select id from sysobjects where upper(name) = '" + strProcedureName.ToUpper().Trim() + "')) ";
            strSqlLlist.Add(strSql);

            strSql =
              "insert into BS_QuerySqlParameter(QuerySqlId,ParametersText,ParametersName,ParametersCatg) " +
              "select '" + strQuerySqlId + "',a.name as paraText,a.name as paraName,b.name paraCatg " +
              "from syscolumns a " +
              "left  join systypes b on a.xtype = b.xusertype " +
              "where a.id = (select id from sysobjects where upper(name) = '" + strProcedureName.ToUpper().Trim() + "') " +
              "and '" + strQuerySqlId + "'+a.name+b.name not in ( " +
              "select convert(varchar(10), querySqlId)+parametersName+parametersCatg from BS_QuerySqlParameter) ";
            strSqlLlist.Add(strSql);

            BaseSQL.ExecuteSqlTran(strSqlLlist);
        }

        public static DataSet ExecUserProcedure(string strQuerySqlId)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt = GetUserQueryInfo(strQuerySqlId);
            if (!string.IsNullOrEmpty(dt.Rows[0].ItemArray[6].ToString().Trim()))
            {
                int intRowCount= dt.Rows.Count;
                IDataParameter[] parameters = new System.Data.IDataParameter[intRowCount];//实例化参数对象
                for (int i = 0; i < intRowCount; i++)
                {
                    parameters[i] = new SqlParameter(dt.Rows[i].ItemArray[6].ToString(), string.Empty);//参数对象赋值 
                }
                ds=BaseSQL.RunProcedure(Convert.ToString(dt.Rows[0].ItemArray[3]).Trim(), parameters,"dd");//执行存储过程
              return ds;
          }
            return null;
        }

        public static DataTable GetUserQueryInfo(string strQuerySqlId)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            string strSql =
            "select a.AutoId,a.ParentId,a.QueryText,a.QuerySql,a.Reamrks,b.ParametersText,b.ParametersName,b.ParametersCatg " +
            "from BS_QuerySql a left join BS_QuerySqlParameter b on a.AutoId=b.QuerySqlId " +
            "where a.AutoId ='" + strQuerySqlId + "'and a.ParentId is not null ";
            dt = BaseSQL.GetTableBySql(strSql);
            return dt;
        }

        public static DataTable GetUserQueryTabsInfo(string strQuerySqlId)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            string strSql =
            "select a.AutoId,a.ParentId,a.QueryText,a.QuerySql,a.Reamrks,b.TabText,b.TabRemark,b.AutoId " +
            "from BS_QuerySql a left join BS_DataSetting b on a.AutoId=b.QuerySql " +
            "where a.AutoId ='" + strQuerySqlId + "'and a.ParentId is not null ";
            dt = BaseSQL.GetTableBySql(strSql);
            return dt;
        }


    }
}
