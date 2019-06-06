using PSAP.DAO.BSDAO;
using PSAP.PSAPCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace PSAP.DAO.SADAO
{
    class FrmStnModuleDAO
    {
        /// <summary>
        /// 查询功能模块信息
        /// </summary>
        public void QueryStnModule(DataTable queryDataTable, string beginDateStr, string endDateStr, string preparedStr, string commonStr)
        {
            string sqlStr = QueryStnModule_SQL(beginDateStr, endDateStr, preparedStr, commonStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 查询功能模块信息的SQL
        /// </summary>
        public string QueryStnModule_SQL(string beginDateStr, string endDateStr, string preparedStr, string commonStr)
        {
            string sqlStr = " 1=1";
            if (beginDateStr != "")
            {
                sqlStr += string.Format(" and GetTime between '{0}' and '{1}'", beginDateStr, endDateStr);
            }
            if (preparedStr != "")
            {
                sqlStr += string.Format(" and Prepared='{0}'", preparedStr);
            }
            if (commonStr != "")
            {
                sqlStr += string.Format(" and (SMNo like '%{0}%' or FunctionDesc like '%{0}%' or FunctionDetail like '%{0}%')", commonStr);
            }

            sqlStr = string.Format("select * from SA_StnModule where {0} order by AutoId", sqlStr);
            return sqlStr;
        }

        /// <summary>
        /// 查询供货明细信息
        /// </summary>
        public void QueryDeliveryDetail(DataTable queryDataTable, string smNoStr)
        {
            string sqlStr = string.Format("select * from SA_DeliveryDetail where SMNo = '{0}' order by AutoId", smNoStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 按照供货明细的供货元器件信息
        /// </summary>
        public void QueryMaterialDetail(DataTable queryDataTable, string smNoStr)
        {
            string sqlStr = string.Format("select * from SA_MaterialDetail where DeliveryDetailNO in (select AutoId from SA_DeliveryDetail where SMNo = '{0}')", smNoStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 保存功能模块信息
        /// </summary>
        public int SaveStnModule(DataRow headRow,string copySMNoStr)
        {
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);

                        DateTime nowTime = BaseSQL.GetServerDateTime();
                        if (headRow.RowState == DataRowState.Added)//新增
                        {
                            headRow["SMNo"] = BaseSQL.GetMaxCodeNo(cmd, "SM");
                            headRow["PreparedIp"] = SystemInfo.HostIpAddress;
                            headRow["GetTime"] = nowTime;
                        }
                        else//修改
                        {

                        }

                        //保存日志到日志表中
                        string logStr = LogHandler.RecordLog_DataRow(cmd, "功能模块信息", headRow, "SMNo");

                        cmd.CommandText = "select * from SA_StnModule where 1=2";
                        SqlDataAdapter adapterHead = new SqlDataAdapter(cmd);
                        DataTable tmpHeadTable = new DataTable();
                        adapterHead.Fill(tmpHeadTable);
                        BaseSQL.UpdateDataTable(adapterHead, headRow.Table);

                        if(copySMNoStr!="")
                        {
                            int resultInt = 0;
                            string errorText = "";

                            string smNoStr = DataTypeConvert.GetString(headRow["SMNo"]);

                            SqlCommand cmd_proc = new SqlCommand("", conn, trans);
                            SqlParameter p1 = new SqlParameter("@CopySMNo", SqlDbType.VarChar);
                            p1.Value = copySMNoStr;
                            SqlParameter p2 = new SqlParameter("@NewSMNo", SqlDbType.VarChar);
                            p2.Value = smNoStr;
                            SqlParameter p3 = new SqlParameter("@Prepared", SqlDbType.VarChar);
                            p3.Value = SystemInfo.user.EmpName;
                            SqlParameter p4 = new SqlParameter("@PreparedIp", SqlDbType.VarChar);
                            p4.Value = SystemInfo.HostIpAddress;
                            IDataParameter[] parameters = new IDataParameter[] { p1, p2, p3, p4};
                            BaseSQL.RunProcedure(cmd_proc, "P_DeliveryDetail_Copy", parameters, out resultInt, out errorText);
                            if (resultInt != 1)
                            {
                                trans.Rollback();
                                MessageHandler.ShowMessageBox("复制供货明细信息错误--" + errorText);
                                return -1;
                            }
                        }

                        trans.Commit();

                        return 1;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        headRow.Table.RejectChanges();
                        throw ex;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        /// <summary>
        /// 删除功能模块信息
        /// </summary>
        public bool DeleteStnModule(string smNoStr)
        {
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);

                        cmd.CommandText = string.Format("select * from SA_StnModule where SMNo = '{0}'", smNoStr);
                        DataTable tmpTable = new DataTable();
                        SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                        adpt.Fill(tmpTable);

                        if (CheckStnModule_IsDeliveryDetail(cmd, smNoStr))
                        {
                            MessageHandler.ShowMessageBox("当前的功能模块还包含供货明细，不可以删除。");
                            return false;
                        }

                        if(CheckStnModule_IsStnSummary(cmd,smNoStr))
                        {
                            MessageHandler.ShowMessageBox("当前的功能模块已经在工位信息中登记，不可以删除。");
                            return false;
                        }

                        if (tmpTable.Rows.Count > 0)
                        {
                            //保存日志到日志表中
                            string logStr = LogHandler.RecordLog_DeleteRow(cmd, "功能模块信息", tmpTable.Rows[0], "SMNo");
                        }

                        cmd.CommandText = string.Format("Delete from SA_StnModule where SMNo = '{0}'", smNoStr);
                        cmd.ExecuteNonQuery();

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

        /// <summary>
        /// 检查功能模块是否有供货明细
        /// </summary>
        public bool CheckStnModule_IsDeliveryDetail(SqlCommand cmd, string smNoStr)
        {
            int count = 0;
            string sqlStr = string.Format("select Count(*) from SA_DeliveryDetail where SMNo = '{0}'", smNoStr);
            if (cmd == null)
                count = DataTypeConvert.GetInt(BaseSQL.GetSingle(sqlStr));
            else
            {
                cmd.CommandText = sqlStr;
                count = DataTypeConvert.GetInt(cmd.ExecuteScalar());
            }
            if (count > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 检查功能模块是否在工位里面使用
        /// </summary>
        public bool CheckStnModule_IsStnSummary(SqlCommand cmd, string smNoStr)
        {
            int count = 0;
            string sqlStr= string.Format("select Count(*) from SA_StnSummaryListModule where StnModuleId = '{0}'", smNoStr);
            if (cmd == null)
                count = DataTypeConvert.GetInt(BaseSQL.GetSingle(sqlStr));
            else
            {
                cmd.CommandText = sqlStr;
                count = DataTypeConvert.GetInt(cmd.ExecuteScalar());
            }
            if (count > 0)
                return true;
            else
                return false;
        }
    }
}
