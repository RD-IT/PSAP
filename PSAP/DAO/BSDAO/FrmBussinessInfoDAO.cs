using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace PSAP.DAO.BSDAO
{
    class FrmBussinessInfoDAO
    {
        public static ArrayList strSqlLlist = new ArrayList();//存储SQL语句
        public static ArrayList strTablesName = new ArrayList();//存储返回表名

        static PSAP.VIEW.BSVIEW.FrmLanguageText f = new VIEW.BSVIEW.FrmLanguageText();
        public FrmBussinessInfoDAO()
        {
            PSAP.BLL.BSBLL.BSBLL.language(f);
        }

        /// <summary>
        /// 初始化数据集（暂时不用）
        /// </summary>
        /// <returns></returns>
        public static DataSet InitDataSet()
        {
            strSqlLlist.Clear();
            string strSql = "select * from BS_BussinessBaseInfo ";
            strSqlLlist.Add(strSql);
            strSql = "BussinessBaseInfo";
            strTablesName.Add(strSql);

            strSql = "select * from BS_BussinessDetailInfo";
            strSqlLlist.Add(strSql);
            strSql = "BussinessDetailInfo";
            strTablesName.Add(strSql);

            strSql = "select * from BS_BussinessFinancialInfo";
            strSqlLlist.Add(strSql);
            strSql = "BussinessFinancialInfo";
            strTablesName.Add(strSql);
            DataSet ds = new DataSet();
            ds = BSDAO.BaseSQL.GetDataSetBySql(strSqlLlist, strTablesName);
            return ds;
        }

        /// <summary>
        /// 删除相关数据
        /// </summary>
        /// <param name="strBussinessBaseNo"></param>
        public static bool DeleteBussinessCorrelationData(string strBussinessBaseNo, DataSet dataSet1)
        {
            strSqlLlist.Clear();
            string strSql = @"delete from BS_BussinessDetailInfo where BussinessBaseNo like '" + strBussinessBaseNo + "'";
            strSqlLlist.Add(strSql);

            strSql = @"delete from BS_BussinessFinancialInfo where BussinessBaseNo like '" + strBussinessBaseNo + "'";
            strSqlLlist.Add(strSql);

            strSql = @"delete from BS_BussinessBaseInfo where BussinessBaseNo like '" + strBussinessBaseNo + "'";
            strSqlLlist.Add(strSql);
            return ExecuteSqlTranBI(strSqlLlist, dataSet1);
        }

        /// <summary>
        /// 执行多条SQL语句，实现数据库事务(增加了对重对关键字重复的控制)
        /// </summary>
        /// <param name="SQLStringList">多条SQL语句</param>  
        public static bool ExecuteSqlTranBI(ArrayList SQLStringList, DataSet dataSet1)
        {
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                SqlTransaction tx = conn.BeginTransaction();
                cmd.Transaction = tx;
                try
                {
                    for (int n = 0; n < SQLStringList.Count; n++)
                    {
                        string strsql = SQLStringList[n].ToString();
                        if (strsql.Trim().Length > 1)
                        {
                            cmd.CommandText = strsql;
                            cmd.ExecuteNonQuery();
                        }
                    }
                    tx.Commit();
                    return true;
                }
                catch (System.Data.SqlClient.SqlException e)
                {
                    MessageBox.Show("当前往来方编码已经被使用，不能修改！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tx.Rollback();
                    return false;
                    throw new Exception(e.Message);
                }
            }
        }



        /// <summary>
        /// 初始化往来方主表
        /// </summary>
        public static void InitBussinessBaseInfo(DataSet ds)
        {
            BaseSQL.Query("select * from BS_BussinessBaseInfo", ds.Tables["BussinessBaseInfo"]);
        }

        /// <summary>
        /// 将数据保存到数据库
        /// </summary>
        /// <param name="dataSet1"></param>
        public static void SaveBussinessBaseInfo(DataSet dataSet1)
        {
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);
                        cmd.CommandText = "select Top 0 * from BS_BussinessBaseInfo ";
                        SqlDataAdapter adp = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adp.Fill(dt);
                        BaseSQL.UpdateDataTable(adp, dataSet1.Tables["BussinessBaseInfo"]);

                        cmd.CommandText = "select Top 0 * from BS_BussinessDetailInfo ";
                        SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
                        DataTable dt1 = new DataTable();
                        adp1.Fill(dt1);
                        BaseSQL.UpdateDataTable(adp1, dataSet1.Tables[1]);

                        cmd.CommandText = "select Top 0 * from BS_BussinessFinancialInfo ";
                        SqlDataAdapter adp2 = new SqlDataAdapter(cmd);
                        DataTable dt2 = new DataTable();
                        adp2.Fill(dt2);
                        BaseSQL.UpdateDataTable(adp2, dataSet1.Tables["BussinessFinancialInfo"]);
                        trans.Commit();
                    }
                    catch (System.Data.SqlClient.SqlException)
                    {
                        MessageBox.Show("当前往来方编码已经被使用，不能修改！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        trans.Rollback();
                        dataSet1.Tables["BussinessDetailInfo"].RejectChanges();
                        dataSet1.Tables["BussinessFinancialInfo"].RejectChanges();
                        dataSet1.Tables["BussinessBaseInfo"].RejectChanges();
                    }
                    catch (System.Data.DBConcurrencyException)
                    {
                        MessageBox.Show("当前往来方编码已经被使用，不能修改1111！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        trans.Rollback();
                        dataSet1.Tables["BussinessDetailInfo"].RejectChanges();
                        dataSet1.Tables["BussinessFinancialInfo"].RejectChanges();
                        dataSet1.Tables["BussinessBaseInfo"].RejectChanges();
                    }

                    catch (Exception ex)
                    {
                        trans.Rollback();
                        dataSet1.Tables["BussinessDetailInfo"].RejectChanges();
                        dataSet1.Tables["BussinessFinancialInfo"].RejectChanges();
                        dataSet1.Tables["BussinessBaseInfo"].RejectChanges();
                        throw ex;
                    }
                }
            }
        }

        /// <summary>
        /// 获得子表对应数据
        /// </summary>
        /// <param name="dataSet1">要填充的数据集</param>
        /// <param name="gdvBussinessBaseInfo">主表gridControl</param>
        public static void GetChildTableData(DataSet dataSet1, DevExpress.XtraGrid.Views.Grid.GridView gdvBussinessBaseInfo)
        {
            dataSet1.Tables[1].Clear();
            string strSql = "select * from BS_BussinessDetailInfo where BussinessBaseNo like '" + gdvBussinessBaseInfo.GetRowCellValue(gdvBussinessBaseInfo.GetSelectedRows()[0], "BussinessBaseNo").ToString() + "'";
            BaseSQL.Query(strSql, dataSet1.Tables["BussinessDetailInfo"]);
            dataSet1.Tables[2].Clear();
            strSql = "select * from BS_BussinessFinancialInfo where BussinessBaseNo like '" + gdvBussinessBaseInfo.GetRowCellValue(gdvBussinessBaseInfo.GetSelectedRows()[0], "BussinessBaseNo").ToString() + "'";
            BaseSQL.Query(strSql, dataSet1.Tables["BussinessFinancialInfo"]);
        }

        /// <summary>
        /// 判断是否已存在商业往来编号
        /// </summary>
        /// <param name="gdvBussinessBaseInfo"></param>
        /// <returns></returns>
        public static bool ExistsBussinessBaseInfoNo(DevExpress.XtraGrid.Views.Grid.GridView gdvBussinessBaseInfo)
        {
            return DAO.BSDAO.BaseSQL.Exists("select * from BS_BussinessBaseInfo where BussinessBaseNo like '" + gdvBussinessBaseInfo.GetFocusedDataRow()["BussinessBaseNo"].ToString() + "'");
        }

        /// <summary>
        /// 查询往来方类别全部表（增加一个全部选项）
        /// </summary>
        public DataTable QueryBussinessCategory(bool addAllItem)
        {
            string sqlStr = "select AutoId, BussinessCategory, BussinessCategoryText from BS_BussinessCategory order by AutoId";
            if (addAllItem)
            {
                //sqlStr = "select 0 as AutoId, '' as BussinessCategory, '全部' as BussinessCategoryText union " + sqlStr;
                sqlStr = "select 0 as AutoId, '' as BussinessCategory,'" + f.tsmiQb.Text + "' as BussinessCategoryText union " + sqlStr;

            }
            return BaseSQL.GetTableBySql(sqlStr);
        }

        /// <summary>
        /// 查询国家编码全部表（增加一个全部选项）
        /// </summary>
        public DataTable QueryCountryCode(bool addAllItem)
        {
            string sqlStr = "select CountryCode, CountryName from BS_CountryCodeManagement order by CountryCode";
            if (addAllItem)
            {
                //sqlStr = "select '全部' as CountryCode, '全部' as CountryName union " + sqlStr;
                sqlStr = "select '" + f.tsmiQb.Text + "' as CountryCode, '" + f.tsmiQb.Text + "' as CountryName union " + sqlStr;

            }
            return BaseSQL.GetTableBySql(sqlStr);
        }

        /// <summary>
        /// 查询往来方详细信息
        /// </summary>
        public void QueryBussinessDetailInfo(DataTable queryDataTable, string bussinessBaseNoStr)
        {
            string sqlStr = string.Format("select * from BS_BussinessDetailInfo where BussinessBaseNo = '{0}'", bussinessBaseNoStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 查询往来方金融信息
        /// </summary>
        public void QueryBussinessFinancialInfo(DataTable queryDataTable, string bussinessBaseNoStr)
        {
            string sqlStr = string.Format("select * from BS_BussinessFinancialInfo where BussinessBaseNo = '{0}'", bussinessBaseNoStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 更新往来方其他信息
        /// </summary>
        public void Update_BussinessOtherInfo(SqlCommand cmd, DataTable detailInfoTable, DataTable FinancialInfoTable)
        {
            DataRowState drs = detailInfoTable.Rows[0].RowState;

            cmd.CommandText = "select * from BS_BussinessDetailInfo where 1=2";
            SqlDataAdapter adapterHead = new SqlDataAdapter(cmd);
            DataTable tmpHeadTable = new DataTable();
            adapterHead.Fill(tmpHeadTable);
            BaseSQL.UpdateDataTable(adapterHead, detailInfoTable);

            cmd.CommandText = "select * from BS_BussinessFinancialInfo where 1=2";
            SqlDataAdapter adapterList = new SqlDataAdapter(cmd);
            DataTable tmpListTable = new DataTable();
            adapterList.Fill(tmpListTable);
            BaseSQL.UpdateDataTable(adapterList, FinancialInfoTable);
        }

        /// <summary>
        /// 删除往来方其他信息
        /// </summary>
        public void Delete_BussinessOtherInfo(SqlCommand cmd, string bussinessBaseNoStr)
        {
            cmd.CommandText = string.Format("delete from BS_BussinessDetailInfo where BussinessBaseNo = '{0}'", bussinessBaseNoStr);
            cmd.ExecuteNonQuery();
            cmd.CommandText = string.Format("delete from BS_BussinessFinancialInfo where BussinessBaseNo = '{0}'", bussinessBaseNoStr);
            cmd.ExecuteNonQuery();
        }
    }
}
