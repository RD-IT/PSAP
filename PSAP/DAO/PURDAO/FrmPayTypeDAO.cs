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
    class FrmPayTypeDAO
    {
        /// <summary>
        /// 查询付款类型信息
        /// </summary>
        public void QueryPayTypeList(DataTable queryDataTable, string payTypeNoStr)
        {
            string sqlStr = string.Format("select * from PUR_PayTypeList where PayTypeNo='{0}'", payTypeNoStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 保存付款类型信息
        /// </summary>
        public bool SavePayTypeList(DataTable updateDataTable, string payTypeNoStr)
        {
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);

                        cmd.CommandText = "select * from PUR_PayTypeList where 1=2";
                        SqlDataAdapter adapterHead = new SqlDataAdapter(cmd);
                        DataTable tmpHeadTable = new DataTable();
                        adapterHead.Fill(tmpHeadTable);
                        BaseSQL.UpdateDataTable(adapterHead, updateDataTable);

                        //cmd.CommandText = string.Format("select * from PUR_PayTypeList where PayTypeNo='{0}'", payTypeNoStr);
                        //adapterHead = new SqlDataAdapter(cmd);
                        //tmpHeadTable.Rows.Clear();
                        //adapterHead.Fill(tmpHeadTable);

                        cmd.CommandText = string.Format("select Sum(PayPercentum) from PUR_PayTypeList where PayTypeNo='{0}'", payTypeNoStr);
                        int sumInt = DataTypeConvert.GetInt(cmd.ExecuteScalar());
                        if (sumInt != 100)
                        {
                            trans.Rollback();
                            MessageHandler.ShowMessageBox("付款百分比的合计必须是100，请刷新后再重新操作。");
                            return false;
                        }

                        //保存日志到日志表中
                        string logStr = "对[付款类型信息]表进行[修改]操作：";
                        for (int i = 0; i < updateDataTable.Rows.Count; i++)
                        {
                            logStr += string.Format("主键的值为[{0}]百分比的值为[{1}]说明的值为[{2}]；", updateDataTable.Rows[i]["AutoId"].ToString(), updateDataTable.Rows[i]["PayPercentum"].ToString(), updateDataTable.Rows[i]["PayPercentumText"].ToString());
                        }

                        LogHandler.RecordLog(cmd, logStr);

                        trans.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw ex;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }


    }
}
