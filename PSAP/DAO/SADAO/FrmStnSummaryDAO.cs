using PSAP.DAO.BSDAO;
using PSAP.PSAPCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PSAP.DAO.SADAO
{
    class FrmStnSummaryDAO
    {
        /// <summary>
        /// 查询基础功能模块的根节点信息
        /// </summary>
        public DataTable QueryBaseStnModule_OnlyRoot(string beginDateStr, string endDateStr, string commonStr)
        {
            string sqlStr = " 1=1";
            if (beginDateStr != "")
            {
                sqlStr += string.Format(" and GetTime between '{0}' and '{1}'", beginDateStr, endDateStr);
            }
            if (commonStr != "")
            {
                sqlStr += string.Format(" and (SMNo like '%{0}%' or FunctionDesc like '%{0}%' or FunctionDetail like '%{0}%')", commonStr);
            }

            sqlStr = string.Format("select SMNo as ReID, '' as ReParent, SMNo + '-' + FunctionDesc as FunctionDesc, '' as Detail from SA_StnModule where {0} Order By SMNo", sqlStr);
            return BaseSQL.Query(sqlStr).Tables[0];
        }

        /// <summary>
        /// 查询基础功能模块的子节点信息
        /// </summary>
        public void QueryBaseStnModule_OnlyLeaf(DataTable queryDataTable, string smNoStr)
        {
            string sqlStr = string.Format("select SMNo + '-' + Cast(AutoId as varchar) as ReID, SMNo as ReParent, DeliveryText as FunctionDesc, CAST(DeliveryQty as varchar) + ' * ' + CAST(Convert(decimal(10,2), Unit) as varchar) + ' = ' + CAST(Amount as varchar) as Detail from SA_DeliveryDetail where SMNo = '{0}'", smNoStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 查询工位主表信息
        /// </summary>
        public void QueryStnSummary(DataTable queryDataTable, string autoQuotationNoStr, string ssNoStr)
        {
            string sqlStr = " 1=1";
            if (autoQuotationNoStr != "")
            {
                sqlStr += string.Format(" and AutoQuotationNo = '{0}'", autoQuotationNoStr);
            }
            if (ssNoStr != "")
            {
                sqlStr += string.Format(" and SSNo = '{0}'", ssNoStr);
            }
            sqlStr = string.Format("select * from SA_StnSummary where {0} Order By AutoId", sqlStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 查询工位子表信息
        /// </summary>
        public void QueryStnSummaryList(DataTable queryDataTable, string ssNoStr)
        {
            string sqlStr = " 1=1";
            if (ssNoStr != "")
            {
                sqlStr += string.Format(" and SSNo = '{0}'", ssNoStr);
            }
            sqlStr = string.Format("select * from SA_StnSummaryList where {0} Order By AutoId", sqlStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 查询工位和模块关系
        /// </summary>
        public void QueryStnListModule(DataTable queryDataTable, int stnSummaryListIdInt)
        {
            string sqlStr = " 1=1";
            if (stnSummaryListIdInt != 0)
            {
                sqlStr += string.Format(" and stn.StnSummaryListId = {0}", stnSummaryListIdInt);
            }
            sqlStr = string.Format("select stn.AutoId, stn.StnSummaryListId, modu.SMNo, modu.FunctionDesc, modu.FunctionDetail from SA_StnSummaryListModule as stn left join SA_StnModule as modu on stn.StnModuleId = modu.SMNo where {0} Order by stn.AutoId", sqlStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 查询报价单
        /// </summary>
        public void QueryQuotationBaseInfo(DataTable queryDataTable, string beginDateStr, string endDateStr, string bussinessBaseNoStr, string preparedStr, string commonStr)
        {
            string sqlStr = " 1=1";
            if (beginDateStr != "")
            {
                sqlStr += string.Format(" and RecordDate between '{0}' and '{1}'", beginDateStr, endDateStr);
            }
            if (bussinessBaseNoStr != "")
            {
                sqlStr += string.Format(" and BussinessBaseNo = '{0}'", bussinessBaseNoStr);
            }
            if (preparedStr != "")
            {
                sqlStr += string.Format(" and SA_QuotationBaseInfo.Prepared = '{0}'", preparedStr);
            }
            if (commonStr != "")
            {
                sqlStr += string.Format(" and (SA_QuotationBaseInfo.AutoQuotationNo like '%{0}%' or RFQNO like '%{0}%' or Requester like '%{0}%' or Remark like '%{0}%' or ProjectName like '%{0}%' or SA_StnSummary.SSNo like '%{0}%')", commonStr);
            }

            sqlStr = string.Format("select SA_QuotationBaseInfo.*, IsNull(SA_StnSummary.SSNo, '') as SSNo from SA_QuotationBaseInfo left join SA_StnSummary on SA_QuotationBaseInfo.AutoQuotationNo = SA_StnSummary.AutoQuotationNo where {0} order by AutoId", sqlStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 保存工位信息
        /// </summary>
        public int SaveStnSummaryList(string autoQuotationNoStr, DataRow headRow,ref int lastNewStnListAutoId)
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
                        bool addState = false;
                        if (headRow.RowState == DataRowState.Added)//新增
                        {
                            if (DataTypeConvert.GetString(headRow["SSNo"]) == "")
                            {
                                string ssNoStr = BaseSQL.GetMaxCodeNo(cmd, "SS");
                                cmd.CommandText = string.Format("Insert into SA_StnSummary(SSNo, AutoQuotationNo, Prepared, PreparedIp, GetTime) values ('{0}', '{1}', '{2}', '{3}', '{4}')", ssNoStr, autoQuotationNoStr, SystemInfo.user.EmpName, SystemInfo.HostIpAddress, nowTime.ToString("yyyy-MM-dd HH:mm:ss"));
                                cmd.ExecuteNonQuery();

                                headRow["SSNo"] = ssNoStr;
                            }

                            headRow["Prepared"] = SystemInfo.user.EmpName;
                            headRow["PreparedIp"] = SystemInfo.HostIpAddress;
                            headRow["GetTime"] = nowTime;
                            addState = true;
                        }
                        else//修改
                        {
                            //int autoIdInt = DataTypeConvert.GetInt(headRow["AutoId"]);
                            //if (CheckStnList_IsModule(cmd, autoIdInt))
                            //{
                            //    headRow.Table.RejectChanges();
                            //    return -1;
                            //}
                        }

                        //保存日志到日志表中
                        string logStr = LogHandler.RecordLog_DataRow(cmd, "工位明细信息", headRow, "AutoId");

                        cmd.CommandText = "select * from SA_StnSummaryList where 1=2";
                        SqlDataAdapter adapterHead = new SqlDataAdapter(cmd);
                        DataTable tmpHeadTable = new DataTable();
                        adapterHead.Fill(tmpHeadTable);
                        BaseSQL.UpdateDataTable(adapterHead, headRow.Table);

                        if (addState)
                        {
                            cmd.CommandText = "Select @@IDENTITY";
                            lastNewStnListAutoId = DataTypeConvert.GetInt(cmd.ExecuteScalar());
                        }

                        trans.Commit();
                        return 1;
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
        /// 删除工位信息
        /// </summary>
        public bool DeleteStnSummaryList(int autoIdInt)
        {
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);

                        cmd.CommandText = string.Format("select * from SA_StnSummaryList where AutoId = {0}", autoIdInt);
                        DataTable tmpTable = new DataTable();
                        SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                        adpt.Fill(tmpTable);

                        if (tmpTable.Rows.Count > 0)
                        {
                            //保存日志到日志表中
                            string logStr = LogHandler.RecordLog_DeleteRow(cmd, "工位明细信息", tmpTable.Rows[0], "AutoId");
                        }

                        cmd.CommandText = string.Format("Delete from SA_StnSummaryList where AutoId = '{0}'", autoIdInt);
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
        /// 保存工位模块关系
        /// </summary>
        public bool SaveStnListModule(int stnSummaryListIdInt, string StnNo, List<string> smNoStrList)
        {
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);


                        foreach (string smNoStr in smNoStrList)
                        {
                            //判断是否有重复的相同关系，如果重复则忽略
                            //cmd.CommandText = string.Format("Select Count(*) from SA_StnSummaryListModule where StnSummaryListId = {0} and StnModuleId = '{1}'", stnSummaryListIdInt, smNoStr);
                            //int Count = DataTypeConvert.GetInt(cmd.ExecuteScalar());
                            //if (Count > 0)
                            //    continue;

                            cmd.CommandText = string.Format("Insert into SA_StnSummaryListModule (StnSummaryListId, StnModuleId) values ({0}, '{1}')", stnSummaryListIdInt, smNoStr);
                            cmd.ExecuteNonQuery();

                            //保存日志到日志表中
                            string logStr = string.Format("保存工位模块关系：工位站号[{0}]，功能模块号[{1}]", StnNo, smNoStr);
                            LogHandler.RecordLog(cmd, logStr);
                        }

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
        /// 删除工位模块关系
        /// </summary>
        public bool DeleteStnListModule(int autoIdInt)
        {
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);

                        cmd.CommandText = string.Format("select SA_StnSummaryList.AutoId, SA_StnSummaryList.StnNo, SA_StnSummaryListModule.StnModuleId from SA_StnSummaryListModule left join SA_StnSummaryList on SA_StnSummaryListModule.StnSummaryListId = SA_StnSummaryList.AutoId where SA_StnSummaryListModule.AutoId = {0}", autoIdInt);
                        DataTable tmpTable = new DataTable();
                        SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                        adpt.Fill(tmpTable);

                        if (tmpTable.Rows.Count > 0)
                        {
                            //保存日志到日志表中
                            string logStr = string.Format("删除工位模块关系：工位站号[{0}]，功能模块号[{1}]", DataTypeConvert.GetString(tmpTable.Rows[0]["StnNo"]), DataTypeConvert.GetString(tmpTable.Rows[0]["StnModuleId"]));
                            LogHandler.RecordLog(cmd, logStr);
                        }

                        cmd.CommandText = string.Format("Delete from SA_StnSummaryListModule where AutoId = '{0}'", autoIdInt);
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
        /// 检查工位信息是否设定功能模块
        /// </summary>
        public bool CheckStnList_IsModule(SqlCommand cmd, int autoIdInt)
        {
            string sqlStr = string.Format("select Count(*) from SA_StnSummaryListModule where StnSummaryListId = {0}", autoIdInt);
            int count = 0;
            if (cmd != null)
            {
                cmd.CommandText = sqlStr;
                count = DataTypeConvert.GetInt(cmd.ExecuteScalar());
            }
            else
                count = DataTypeConvert.GetInt(BaseSQL.GetSingle(sqlStr));
            if (count > 0)
            {
                MessageHandler.ShowMessageBox("工位信息已经设定功能模块，不可以进行删除等操作。");
                return true;
            }
            else
                return false;
        }
        
    }
}
