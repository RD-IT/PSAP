using PSAP.DAO.BSDAO;
using PSAP.PSAPCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace PSAP.DAO.SADAO
{
    class FrmDeliveryDetailDAO
    {
        /// <summary>
        /// 查询供货明细
        /// </summary>
        public void QueryDeliveryDetail(DataTable queryDataTable, int autoIdInt)
        {
            string sqlStr = QueryDeliveryDetail_SQL(autoIdInt);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 查询供货明细的SQL
        /// </summary>
        public string QueryDeliveryDetail_SQL(int autoIdInt)
        {
            string sqlStr = string.Format("select * from SA_DeliveryDetail where AutoId = {0} order by AutoId", autoIdInt);
            return sqlStr;
        }

        /// <summary>
        /// 查询当前的前一条供货明细信息
        /// </summary>
        public void QueryDeliveryDetail_UpOne(DataTable queryDataTable, int autoIdInt, string smNoStr)
        {
            string sqlStr = string.Format("select top 1 * from SA_DeliveryDetail where SMNo = '{0}' and AutoId < {1} order by AutoId desc", smNoStr, autoIdInt);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 查询当前的后一条供货明细信息
        /// </summary>
        public void QueryDeliveryDetail_DownOne(DataTable queryDataTable, int autoIdInt, string smNoStr)
        {
            string sqlStr = string.Format("select top 1 * from SA_DeliveryDetail where SMNo = '{0}' and AutoId > {1} order by AutoId", smNoStr, autoIdInt);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 查询最后一条供货明细信息
        /// </summary>
        public void QueryDeliveryDetail_LastOne(DataTable queryDataTable, string smNoStr)
        {
            string sqlStr = string.Format("select top 1 * from SA_DeliveryDetail where SMNo = '{0}' order by AutoId Desc", smNoStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 按照供货明细ID查询供货元器件信息
        /// </summary>
        public void QueryMaterialDetail(DataTable queryDataTable, int deliveryDetailNOInt)
        {
            string sqlStr = string.Format("select * from SA_MaterialDetail where DeliveryDetailNO = {0}", deliveryDetailNOInt);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 保存供货明细信息
        /// </summary>
        public int SaveDeliveryDetail(DataRow headRow, DataTable listTable)
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
                            cmd.CommandText = string.Format("Insert into SA_DeliveryDetail (SMNo, DeliveryText, FunctionDesc, DeliveryQty, Unit, Amount, Prepared, PreparedIp, GetTime) values ('{0}', '{1}', '{2}', {6}, {7}, {8}, '{3}', '{4}', '{5}')", DataTypeConvert.GetString(headRow["SMNo"]), DataTypeConvert.GetString(headRow["DeliveryText"]), DataTypeConvert.GetString(headRow["FunctionDesc"]), SystemInfo.user.EmpName, SystemInfo.HostIpAddress, nowTime.ToString("yyyy-MM-dd HH:mm:ss"),DataTypeConvert.GetDouble(headRow["DeliveryQty"]), DataTypeConvert.GetDouble(headRow["Unit"]), DataTypeConvert.GetDouble(headRow["Amount"]));
                            int ret = cmd.ExecuteNonQuery();
                            if (ret != 1)
                            {
                                trans.Rollback();
                                headRow.Table.RejectChanges();
                                listTable.RejectChanges();
                                MessageHandler.ShowMessageBox("保存供货明细信息错误，请重新新增操作。");
                                return -1;
                            }
                            cmd.CommandText = "select @@IDENTITY";
                            ret = DataTypeConvert.GetInt(cmd.ExecuteScalar());
                            if (ret == 0)
                            {
                                trans.Rollback();
                                headRow.Table.RejectChanges();
                                listTable.RejectChanges();
                                return -1;
                            }
                            for (int i = 0; i < listTable.Rows.Count; i++)
                            {
                                listTable.Rows[i]["DeliveryDetailNO"] = ret;
                                listTable.Rows[i]["PreparedIp"] = SystemInfo.HostIpAddress;
                                listTable.Rows[i]["GetTime"] = nowTime;
                            }
                        }
                        else//修改
                        {
                            for (int i = 0; i < listTable.Rows.Count; i++)
                            {
                                if (listTable.Rows[i].RowState == DataRowState.Added)
                                {
                                    listTable.Rows[i]["PreparedIp"] = SystemInfo.HostIpAddress;
                                    listTable.Rows[i]["GetTime"] = nowTime;
                                }
                            }

                            cmd.CommandText = "select * from SA_DeliveryDetail where 1=2";
                            SqlDataAdapter adapterHead = new SqlDataAdapter(cmd);
                            DataTable tmpHeadTable = new DataTable();
                            adapterHead.Fill(tmpHeadTable);
                            BaseSQL.UpdateDataTable(adapterHead, headRow.Table);
                        }

                        //保存日志到日志表中
                        string logStr = LogHandler.RecordLog_DataRow(cmd, "供货明细信息", headRow, "AutoId");

                        cmd.CommandText = "select * from SA_MaterialDetail where 1=2";
                        SqlDataAdapter adapterList = new SqlDataAdapter(cmd);
                        DataTable tmpListTable = new DataTable();
                        adapterList.Fill(tmpListTable);
                        BaseSQL.UpdateDataTable(adapterList, listTable);

                        trans.Commit();
                        headRow.AcceptChanges();
                        listTable.AcceptChanges();

                        return 1;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        headRow.Table.RejectChanges();
                        listTable.RejectChanges();
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
        /// 删除供货明细
        /// </summary>
        public bool DeleteDeliveryDetail(int autoIdInt)
        {
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);

                        cmd.CommandText = string.Format("select * from SA_DeliveryDetail where AutoId = {0}", autoIdInt);
                        DataTable tmpTable = new DataTable();
                        SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                        adpt.Fill(tmpTable);

                        if (tmpTable.Rows.Count > 0)
                        {
                            //保存日志到日志表中
                            string logStr = LogHandler.RecordLog_DeleteRow(cmd, "供货明细", tmpTable.Rows[0], "AutoId");
                        }

                        cmd.CommandText = string.Format("Delete from SA_MaterialDetail where DeliveryDetailNO = '{0}'", autoIdInt);
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = string.Format("Delete from SA_DeliveryDetail where AutoId = '{0}'", autoIdInt);
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
    }
}
