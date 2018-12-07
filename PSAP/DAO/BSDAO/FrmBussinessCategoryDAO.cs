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
    class FrmBussinessCategoryDAO
    {
        public static ArrayList strSqlLlist = new ArrayList();//存储SQL语句

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="ds"></param>
        public static void InitBussinessCategory(DataSet ds)
        {
            BaseSQL.Query("select * from BS_BussinessCategory", ds.Tables["BussinessCategory"]);
        }

        /// <summary>
        /// 删除选定行数据
        /// </summary>
        /// <param name="strBussinessCategory"></param>
        public static bool DeleteBussinessCategoryData(string strBussinessCategory, DataSet dataSet1)
        {
            strSqlLlist.Clear();
            string strSql = @"delete from BS_BussinessCategory where BussinessCategory like '" + strBussinessCategory + "'";
            strSqlLlist.Add(strSql);
            return ExecuteSqlTranBC(strSqlLlist, dataSet1);
        }
        /// <summary>
        /// 执行多条SQL语句，实现数据库事务(增加了对重对关键字重复的控制)
        /// </summary>
        /// <param name="SQLStringList">多条SQL语句</param>  
        public static bool ExecuteSqlTranBC(ArrayList SQLStringList, DataSet dataSet1)
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
                    MessageBox.Show("当前往来类别编码已经被使用，不能修改！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tx.Rollback();
                    return false;
                    throw new Exception(e.Message);
                }
            }
        }


        /// <summary>
        /// 判断是否已存在类别编号
        /// </summary>
        /// <param name="gdvBussinessCategory"></param>
        /// <returns></returns>
        public static bool ExistsBussinessCategory(DevExpress.XtraGrid.Views.Grid.GridView gdvBussinessCategory)
        {
            return DAO.BSDAO.BaseSQL.Exists("select * from BS_BussinessCategory where BussinessCategory like '" + gdvBussinessCategory.GetFocusedDataRow()["BussinessCategory"].ToString() + "'");
        }

        /// <summary>
        /// 将数据保存到数据库
        /// </summary>
        /// <param name="dataSet1"></param>
        public static void SaveBussinessCategory(DataSet dataSet1)
        {
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);
                        cmd.CommandText = "select Top 0 * from BS_BussinessCategory ";
                        SqlDataAdapter adp = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adp.Fill(dt);
                        BaseSQL.UpdateDataTable(adp, dataSet1.Tables["BussinessCategory"]);
                        trans.Commit();
                    }
                    catch (System.Data.SqlClient.SqlException)
                    {
                        MessageBox.Show("当前往来类别编码已经被使用，不能修改！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        trans.Rollback();
                        dataSet1.Tables["BussinessCategory"].RejectChanges();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        dataSet1.Tables["BussinessCategory"].RejectChanges();
                        throw ex;
                    }
                }
            }
        }
    }
}
