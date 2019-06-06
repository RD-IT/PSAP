using PSAP.PSAPCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace PSAP.DAO.BSDAO
{
    class FrmCollectionTypeDAO
    {
        static PSAP.VIEW.BSVIEW.FrmLanguageBSDAO f = new VIEW.BSVIEW.FrmLanguageBSDAO();
        public FrmCollectionTypeDAO()
        {
            PSAP.BLL.BSBLL.BSBLL.language(f);
        }

        /// <summary>
        /// 查询付款类型信息
        /// </summary>
        public void QueryCollectionTypeList(DataTable queryDataTable, string collectionTypeNoStr)
        {
            string sqlStr = string.Format("select * from BS_CollectionTypeList where CollectionTypeNo='{0}'", collectionTypeNoStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 保存付款类型信息
        /// </summary>
        public bool SaveCollectionTypeList(DataTable updateDataTable, string collectionTypeNoStr)
        {
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);

                        cmd.CommandText = "select * from BS_CollectionTypeList where 1=2";
                        SqlDataAdapter adapterHead = new SqlDataAdapter(cmd);
                        DataTable tmpHeadTable = new DataTable();
                        adapterHead.Fill(tmpHeadTable);
                        BaseSQL.UpdateDataTable(adapterHead, updateDataTable);

                        //cmd.CommandText = string.Format("select * from PUR_PayTypeList where PayTypeNo='{0}'", payTypeNoStr);
                        //adapterHead = new SqlDataAdapter(cmd);
                        //tmpHeadTable.Rows.Clear();
                        //adapterHead.Fill(tmpHeadTable);

                        cmd.CommandText = string.Format("select Sum(CollectionPercentum) from BS_CollectionTypeList where CollectionTypeNo='{0}'", collectionTypeNoStr);
                        int sumInt = DataTypeConvert.GetInt(cmd.ExecuteScalar());
                        if (sumInt != 100)
                        {
                            trans.Rollback();
                            //MessageHandler.ShowMessageBox("收款百分比的合计必须是100，请刷新后再重新操作。");
                            MessageHandler.ShowMessageBox(f.tsmiSkbfbd.Text);
                            return false;
                        }

                        //保存日志到日志表中
                        //string logStr = "对[收款类型信息]表进行[修改]操作：";
                        string logStr = f.tsmiDsklxx.Text;
                        for (int i = 0; i < updateDataTable.Rows.Count; i++)
                        {
                            //logStr += string.Format("主键的值为[{0}]百分比的值为[{1}]说明的值为[{2}]；", updateDataTable.Rows[i]["AutoId"].ToString(), updateDataTable.Rows[i]["CollectionPercentum"].ToString(), updateDataTable.Rows[i]["CollectionPercentumText"].ToString());
                            logStr += string.Format(f.tsmiZjdzw.Text + "[{0}]" + f.tsmiBfbdzw.Text + "[{1}]" + f.tsmiSmdzw.Text + "[{2}]；", updateDataTable.Rows[i]["AutoId"].ToString(), updateDataTable.Rows[i]["CollectionPercentum"].ToString(), updateDataTable.Rows[i]["CollectionPercentumText"].ToString());

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
