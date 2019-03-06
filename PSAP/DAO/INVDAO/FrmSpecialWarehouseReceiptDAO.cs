using PSAP.DAO.BSDAO;
using PSAP.PSAPCommon;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSAP.DAO.INVDAO
{
    public class FrmSpecialWarehouseReceiptDAO
    {
        /// <summary>
        /// 查询预算外出库单表头
        /// </summary>
        /// <param name="queryDataTable">要查询填充的数据表</param>
        /// <param name="beginDateStr">开始日期字符串</param>
        /// <param name="endDateStr">结束日期字符串</param>
        /// <param name="repertoryNoStr">出库仓库编号</param>
        /// <param name="preparedStr">制单人</param>
        /// <param name="commonStr">通用查询条件</param>
        /// <param name="nullTable">是否查询空表</param>
        public void QuerySpecialWarehouseReceiptHeadHead(DataTable queryDataTable, string beginDateStr, string endDateStr, string reqDepStr, string repertoryNoStr, int warehouseStateInt, string preparedStr, int approverInt, string commonStr, bool nullTable)
        {
            BaseSQL.Query(QuerySpecialWarehouseReceiptHeadHead_SQL(beginDateStr, endDateStr, reqDepStr, repertoryNoStr, warehouseStateInt, preparedStr, approverInt, commonStr, nullTable), queryDataTable);
        }

        /// <summary>
        /// 查询预算外出库单表头的SQL
        /// </summary>
        public string QuerySpecialWarehouseReceiptHeadHead_SQL(string beginDateStr, string endDateStr, string reqDepStr, string repertoryNoStr, int warehouseStateInt, string preparedStr, int approverInt, string commonStr, bool nullTable)
        {
            string sqlStr = " 1=1";
            if (beginDateStr != "")
            {
                sqlStr += string.Format(" and SpecialWarehouseReceiptDate between '{0}' and '{1}'", beginDateStr, endDateStr);
            }
            if (reqDepStr != "")
            {
                sqlStr += string.Format(" and ReqDep='{0}'", reqDepStr);
            }
            if (repertoryNoStr != "")
            {
                sqlStr += string.Format(" and RepertoryNo='{0}'", repertoryNoStr);
            }
            if (warehouseStateInt != 0)
            {
                sqlStr += string.Format(" and WarehouseState={0}", warehouseStateInt);
            }
            if (preparedStr != "")
            {
                sqlStr += string.Format(" and Prepared='{0}'", preparedStr);
            }
            if (commonStr != "")
            {
                sqlStr += string.Format(" and (SpecialWarehouseReceipt like '%{0}%' or Remark like '%{0}%')", commonStr);
            }
            if (approverInt >= 0)
            {
                if (approverInt == 0)
                    sqlStr += string.Format(" and WarehouseState in (1,4)");
                else
                {
                    sqlStr = string.Format("select INV_SpecialWarehouseReceiptHead.* from INV_SpecialWarehouseReceiptHead left join PUR_ApprovalType on INV_SpecialWarehouseReceiptHead.ApprovalType = PUR_ApprovalType.TypeNo where {0} and INV_SpecialWarehouseReceiptHead.WarehouseState in (1, 4) and ((PUR_ApprovalType.ApprovalCat = 0 and exists (select * from(select top 1 * from F_OrderNoApprovalList(INV_SpecialWarehouseReceiptHead.SpecialWarehouseReceipt, INV_SpecialWarehouseReceiptHead.ApprovalType) Order by AppSequence) as minlist where Approver = {1})) or(PUR_ApprovalType.ApprovalCat = 1 and exists(select * from F_OrderNoApprovalList(INV_SpecialWarehouseReceiptHead.SpecialWarehouseReceipt, INV_SpecialWarehouseReceiptHead.ApprovalType) where Approver = {1}))) order by AutoId", sqlStr, approverInt);
                    return sqlStr;
                }
            }
            if (nullTable)
            {
                sqlStr += " and 1=2";
            }
            sqlStr = string.Format("select * from INV_SpecialWarehouseReceiptHead where {0} order by AutoId", sqlStr);
            return sqlStr;
        }

        /// <summary>
        /// 查询预算外出库单明细表
        /// </summary>
        /// <param name="queryDataTable">要查询填充的数据表</param>
        /// <param name="specialWarehouseReceiptStr">预算外出库单号</param>
        public void QuerySpecialWarehouseReceiptList(DataTable queryDataTable, string specialWarehouseReceiptStr, bool nullTable)
        {
            string sqlStr = string.Format(" and SpecialWarehouseReceipt='{0}'", specialWarehouseReceiptStr);
            if (nullTable)
            {
                sqlStr += " and 1=2";
            }
            sqlStr = string.Format("select INV_SpecialWarehouseReceiptList.*, SW_PartsCode.CodeName, BS_ProjectList.ProjectNo from INV_SpecialWarehouseReceiptList left join SW_PartsCode on INV_SpecialWarehouseReceiptList.CodeFileName = SW_PartsCode.CodeFileName left join BS_ProjectList on INV_SpecialWarehouseReceiptList.ProjectName = BS_ProjectList.ProjectName where 1=1 {0} order by AutoId", sqlStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }


        /// <summary>
        /// 保存预算外出库单
        /// </summary>
        /// <param name="swwHeadRow">预算外出库单表头数据表</param>
        /// <param name="swwListTable">预算外出库单明细数据表</param>
        public int SaveSpecialWarehouseReceipt(DataRow swwHeadRow, DataTable swwListTable)
        {
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);

                        //if (!CheckOrderApplyBeyondCount(cmd, wwHeadRow["WarehouseReceipt"].ToString(), wwListTable))
                        //{
                        //    return 0;
                        //}

                        if (swwHeadRow["SpecialWarehouseReceipt"].ToString() == "")//新增
                        {
                            string swwNo = BaseSQL.GetMaxCodeNo(cmd, "SR");
                            swwHeadRow["SpecialWarehouseReceipt"] = swwNo;
                            swwHeadRow["PreparedIp"] = SystemInfo.HostIpAddress;

                            for (int i = 0; i < swwListTable.Rows.Count; i++)
                            {
                                swwListTable.Rows[i]["SpecialWarehouseReceipt"] = swwNo;
                            }
                        }
                        else//修改
                        {
                            if (!CheckWarehouseState(swwHeadRow.Table, swwListTable, string.Format("'{0}'", DataTypeConvert.GetString(swwHeadRow["SpecialWarehouseReceipt"])), false, true, true, true))
                                return -1;

                            swwHeadRow["Modifier"] = SystemInfo.user.EmpName;
                            swwHeadRow["ModifierIp"] = SystemInfo.HostIpAddress;
                            swwHeadRow["ModifierTime"] = BaseSQL.GetServerDateTime();
                        }

                        //保存日志到日志表中
                        string logStr = LogHandler.RecordLog_DataRow(cmd, "预算外出库单", swwHeadRow, "SpecialWarehouseReceipt");

                        cmd.CommandText = "select * from INV_SpecialWarehouseReceiptHead where 1=2";
                        SqlDataAdapter adapterHead = new SqlDataAdapter(cmd);
                        DataTable tmpHeadTable = new DataTable();
                        adapterHead.Fill(tmpHeadTable);
                        BaseSQL.UpdateDataTable(adapterHead, swwHeadRow.Table);

                        cmd.CommandText = "select * from INV_SpecialWarehouseReceiptList where 1=2";
                        SqlDataAdapter adapterList = new SqlDataAdapter(cmd);
                        DataTable tmpListTable = new DataTable();
                        adapterList.Fill(tmpListTable);
                        BaseSQL.UpdateDataTable(adapterList, swwListTable);

                        //Set_OrderHead_End(cmd, swwListTable);

                        trans.Commit();

                        return 1;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        swwHeadRow.Table.RejectChanges();
                        swwListTable.RejectChanges();
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
        /// 检测数据库中预算外出库单状态是否可以操作
        /// </summary>
        public bool CheckWarehouseState(DataTable swwHeadTable, DataTable swwListTable, string specialWarehouseReceiptListStr, bool checkNoApprover, bool checkApprover, bool checkSettle, bool checkApproverBetween)
        {
            string sqlStr = string.Format("select SpecialWarehouseReceipt, WarehouseState from INV_SpecialWarehouseReceiptHead where SpecialWarehouseReceipt in ({0})", specialWarehouseReceiptListStr);
            DataTable tmpTable = BaseSQL.Query(sqlStr).Tables[0];
            for (int i = 0; i < tmpTable.Rows.Count; i++)
            {
                int wState = DataTypeConvert.GetInt(tmpTable.Rows[i]["WarehouseState"]);
                switch (wState)
                {
                    case 1:
                        if (checkNoApprover)
                        {
                            MessageHandler.ShowMessageBox(string.Format("预算外出库单[{0}]未审批，不可以操作。", DataTypeConvert.GetString(tmpTable.Rows[i]["SpecialWarehouseReceipt"])));
                            swwHeadTable.RejectChanges();
                            if (swwListTable != null)
                                swwListTable.RejectChanges();
                            return false;
                        }
                        break;
                    case 2:
                        if (checkApprover)
                        {
                            MessageHandler.ShowMessageBox(string.Format("预算外出库单[{0}]已经审批，不可以操作。", DataTypeConvert.GetString(tmpTable.Rows[i]["SpecialWarehouseReceipt"])));
                            swwHeadTable.RejectChanges();
                            if (swwListTable != null)
                                swwListTable.RejectChanges();
                            return false;
                        }
                        break;
                    //case 3:
                    //    if (checkSettle)
                    //    {
                    //        MessageHandler.ShowMessageBox(string.Format("预算外出库单[{0}]已经结账，不可以操作。", DataTypeConvert.GetString(tmpTable.Rows[i]["SpecialWarehouseReceipt"])));
                    //        swwHeadTable.RejectChanges();
                    //        if (swwListTable != null)
                    //            swwListTable.RejectChanges();
                    //        return false;
                    //    }
                    //    break;
                    case 4:
                        if (checkApproverBetween)
                        {
                            MessageHandler.ShowMessageBox(string.Format("预算外出库单[{0}]已经审批中，不可以操作。", DataTypeConvert.GetString(tmpTable.Rows[i]["SpecialWarehouseReceipt"])));
                            swwHeadTable.RejectChanges();
                            if (swwListTable != null)
                                swwListTable.RejectChanges();
                            return false;
                        }
                        break;
                }
            }

            return true;
        }


        /// <summary>
        /// 根据选择删除多条预算外出库单
        /// </summary>
        public bool DeleteSWR_Multi(DataTable swwHeadTable)
        {
            string swwHeadNoListStr = "";
            for (int i = 0; i < swwHeadTable.Rows.Count; i++)
            {
                if (DataTypeConvert.GetBoolean(swwHeadTable.Rows[i]["Select"]))
                {
                    swwHeadNoListStr += string.Format("'{0}',", DataTypeConvert.GetString(swwHeadTable.Rows[i]["SpecialWarehouseReceipt"]));
                }
            }
            swwHeadNoListStr = swwHeadNoListStr.Substring(0, swwHeadNoListStr.Length - 1);
            if (!CheckWarehouseState(swwHeadTable, null, swwHeadNoListStr, false, true, true, true))
                return false;
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);
                        cmd.CommandText = string.Format("select * from INV_SpecialWarehouseReceiptList where SpecialWarehouseReceipt in ({0})", swwHeadNoListStr);
                        DataTable tmpTable = new DataTable();
                        SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                        adpt.Fill(tmpTable);

                        //保存日志到日志表中
                        DataRow[] swwHeadRows = swwHeadTable.Select("select=1");
                        for (int i = 0; i < swwHeadRows.Length; i++)
                        {
                            string logStr = LogHandler.RecordLog_DeleteRow(cmd, "预算外出库单", swwHeadRows[i], "SpecialWarehouseReceipt");
                        }

                        cmd.CommandText = string.Format("Delete from INV_SpecialWarehouseReceiptList where SpecialWarehouseReceipt in ({0})", swwHeadNoListStr);
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = string.Format("Delete from INV_SpecialWarehouseReceiptHead where SpecialWarehouseReceipt in ({0})", swwHeadNoListStr);
                        cmd.ExecuteNonQuery();

                        //Set_OrderHead_End(cmd, tmpTable);

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
        /// 审批选中的多条预算外出库单
        /// </summary>
        public bool SWRApprovalInfo_Multi(DataTable swwHeadTable, ref int successCountInt)
        {
            string swwHeadNoListStr = "";
            for (int i = 0; i < swwHeadTable.Rows.Count; i++)
            {
                if (DataTypeConvert.GetBoolean(swwHeadTable.Rows[i]["Select"]))
                {
                    swwHeadNoListStr += string.Format("'{0}',", DataTypeConvert.GetString(swwHeadTable.Rows[i]["SpecialWarehouseReceipt"]));
                }
            }

            swwHeadNoListStr = swwHeadNoListStr.Substring(0, swwHeadNoListStr.Length - 1);
            if (!CheckWarehouseState(swwHeadTable, null, swwHeadNoListStr, false, true, true, false))
                return false;
            successCountInt = 0;
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);
                        DateTime serverTime = BaseSQL.GetServerDateTime();
                        for (int i = 0; i < swwHeadTable.Rows.Count; i++)
                        {
                            if (DataTypeConvert.GetBoolean(swwHeadTable.Rows[i]["Select"]))
                            {
                                DataRow swwRow = swwHeadTable.Rows[i];
                                string swwHeadNoStr = DataTypeConvert.GetString(swwRow["SpecialWarehouseReceipt"]);

                                cmd.CommandText = string.Format("select INV_SpecialWarehouseReceiptHead.SpecialWarehouseReceipt, INV_SpecialWarehouseReceiptHead.ApprovalType, PUR_ApprovalType.ApprovalCat from INV_SpecialWarehouseReceiptHead left join PUR_ApprovalType on INV_SpecialWarehouseReceiptHead.ApprovalType = PUR_ApprovalType.TypeNo where SpecialWarehouseReceipt = '{0}'", swwHeadNoStr);
                                DataTable tmpTable = new DataTable();
                                SqlDataAdapter orderadpt = new SqlDataAdapter(cmd);
                                orderadpt.Fill(tmpTable);
                                if (tmpTable.Rows.Count == 0)
                                {
                                    trans.Rollback();
                                    MessageHandler.ShowMessageBox("未查询到要操作的预算外出库单，请刷新后再进行操作。");
                                    return false;
                                }

                                ////审核检查出库明细数量是否超过采购订单明细数量
                                //DataTable orderListTable = new DataTable();
                                //QueryWarehouseReceiptList(orderListTable, swwHeadNoStr, false);
                                //if (!CheckOrderApplyBeyondCount(cmd, swwHeadNoStr, orderListTable))
                                //{
                                //    trans.Rollback();
                                //    return false;
                                //}

                                //Set_OrderHead_End(cmd, orderListTable);

                                string approvalTypeStr = DataTypeConvert.GetString(tmpTable.Rows[0]["ApprovalType"]);
                                cmd.CommandText = string.Format("select * from F_OrderNoApprovalList('{0}','{1}') Order by AppSequence", swwHeadNoStr, approvalTypeStr);
                                DataTable listTable = new DataTable();
                                SqlDataAdapter listadpt = new SqlDataAdapter(cmd);
                                listadpt.Fill(listTable);
                                if (listTable.Rows.Count == 0)
                                {
                                    cmd.CommandText = string.Format("Update INV_SpecialWarehouseReceiptHead set WarehouseState = 2 where SpecialWarehouseReceipt='{0}'", swwHeadNoStr);
                                    cmd.ExecuteNonQuery();
                                    swwHeadTable.Rows[i]["WarehouseState"] = 2;
                                    continue;
                                }
                                int approvalCatInt = DataTypeConvert.GetInt(tmpTable.Rows[0]["ApprovalCat"]);
                                switch (approvalCatInt)
                                {
                                    case 0:
                                        if (DataTypeConvert.GetInt(listTable.Rows[0]["Approver"]) != SystemInfo.user.AutoId)
                                            continue;
                                        break;
                                    case 1:
                                    case 2:
                                        if (listTable.Select(string.Format("Approver={0}", SystemInfo.user.AutoId)).Length == 0)
                                            continue;
                                        break;
                                }

                                cmd.CommandText = string.Format("Insert into PUR_OrderApprovalInfo(OrderHeadNo, Approver, ApproverTime) values ('{0}', {1}, '{2}')", swwHeadNoStr, SystemInfo.user.AutoId, serverTime.ToString("yyyy-MM-dd HH:mm:ss"));
                                cmd.ExecuteNonQuery();

                                if (listTable.Rows.Count == 1 || approvalCatInt == 2)
                                {
                                    cmd.CommandText = string.Format("Update INV_SpecialWarehouseReceiptHead set WarehouseState=2 where SpecialWarehouseReceipt='{0}'", swwHeadNoStr);
                                    cmd.ExecuteNonQuery();
                                    swwHeadTable.Rows[i]["WarehouseState"] = 2;
                                }
                                else
                                {
                                    cmd.CommandText = string.Format("Update INV_SpecialWarehouseReceiptHead set WarehouseState=4 where SpecialWarehouseReceipt='{0}'", swwHeadNoStr);
                                    cmd.ExecuteNonQuery();
                                    swwHeadTable.Rows[i]["WarehouseState"] = 4;
                                }

                                //保存日志到日志表中
                                string logStr = LogHandler.RecordLog_OperateRow(cmd, "预算外出库单", swwHeadTable.Rows[i], "SpecialWarehouseReceipt", "审批", SystemInfo.user.EmpName, serverTime.ToString("yyyy-MM-dd HH:mm:ss"));

                                if (DataTypeConvert.GetInt(swwHeadTable.Rows[i]["WarehouseState"]) == 2)//全部审核通过进行下一步操作
                                {
                                    ////更新采购单明细已经进行采购结账的明细的出库单号和出库单明细的AutoId        什么时候采购结账单明细加采购单明细的AutoId什么时候启用
                                    //cmd.CommandText = string.Format("update PUR_SettlementList set PUR_SettlementList.WarehouseWarrant = INV_WarehouseWarrantList.WarehouseWarrant, PUR_SettlementList.WarehouseWarrantListAutoId = INV_WarehouseWarrantList.AutoId from INV_WarehouseWarrantList where INV_WarehouseWarrantList.PoListAutoId = PUR_SettlementList.PoListAutoId and INV_WarehouseWarrantList.OrderHeadNo = PUR_SettlementList.OrderHeadNo and INV_WarehouseWarrantList.WarehouseWarrant = '{0}'", wwHeadNoStr);
                                    //cmd.ExecuteNonQuery();

                                    SqlCommand cmd_proc = new SqlCommand("", conn, trans);
                                    string errorText = "";
                                    if (!new FrmWarehouseNowInfoDAO().Update_WarehouseNowInfo(cmd_proc, swwHeadNoStr, 1, out errorText))
                                    {
                                        trans.Rollback();
                                        MessageHandler.ShowMessageBox("预算外出库单审核出库错误--" + errorText);
                                        return false;
                                    }
                                }

                                successCountInt++;
                            }
                        }

                        trans.Commit();
                        swwHeadTable.AcceptChanges();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        swwHeadTable.RejectChanges();
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
        /// 取消审批选中的多条预算外出库单
        /// </summary>
        public bool CancalSWRApprovalInfo_Multi(DataTable swwHeadTable)
        {
            string swwHeadNoListStr = "";
            for (int i = 0; i < swwHeadTable.Rows.Count; i++)
            {
                if (DataTypeConvert.GetBoolean(swwHeadTable.Rows[i]["Select"]))
                {
                    swwHeadNoListStr += string.Format("'{0}',", DataTypeConvert.GetString(swwHeadTable.Rows[i]["SpecialWarehouseReceipt"]));
                    swwHeadTable.Rows[i]["WarehouseState"] = 1;
                }
            }

            swwHeadNoListStr = swwHeadNoListStr.Substring(0, swwHeadNoListStr.Length - 1);
            if (!CheckWarehouseState(swwHeadTable, null, swwHeadNoListStr, true, false, true, false))
                return false;

            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);

                        cmd.CommandText = string.Format("select SpecialWarehouseReceipt from INV_SpecialWarehouseReceiptHead where WarehouseState = 2 and SpecialWarehouseReceipt in ({0})", swwHeadNoListStr);
                        DataTable approcalSWWTable = new DataTable();
                        SqlDataAdapter appradpt = new SqlDataAdapter(cmd);
                        appradpt.Fill(approcalSWWTable);

                        cmd.CommandText = string.Format("Delete from PUR_OrderApprovalInfo where OrderHeadNo in ({0})", swwHeadNoListStr);
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = string.Format("Update INV_SpecialWarehouseReceiptHead set WarehouseState=1 where SpecialWarehouseReceipt in ({0})", swwHeadNoListStr);
                        cmd.ExecuteNonQuery();

                        //保存日志到日志表中
                        DataRow[] orderHeadRows = swwHeadTable.Select("select=1");
                        for (int i = 0; i < orderHeadRows.Length; i++)
                        {
                            ////检查是否有下级的主单
                            //if (CheckApplySettlement(cmd, DataTypeConvert.GetString(orderHeadRows[i]["WarehouseReceipt"])))
                            //{
                            //    trans.Rollback();
                            //    swwHeadTable.RejectChanges();
                            //    MessageHandler.ShowMessageBox("出库单已经有适用的采购结账单记录，不可以操作。");
                            //    return false;
                            //}

                            string logStr = LogHandler.RecordLog_OperateRow(cmd, "预算外出库单", orderHeadRows[i], "SpecialWarehouseReceipt", "取消审批", SystemInfo.user.EmpName, BaseSQL.GetServerDateTime().ToString("yyyy-MM-dd HH:mm:ss"));
                        }

                        for (int i = 0; i < approcalSWWTable.Rows.Count; i++)
                        {
                            SqlCommand cmd_proc = new SqlCommand("", conn, trans);
                            string errorText = "";
                            if (!new FrmWarehouseNowInfoDAO().Update_WarehouseNowInfo(cmd_proc, DataTypeConvert.GetString(approcalSWWTable.Rows[i]["SpecialWarehouseReceipt"]), 2, out errorText))
                            {
                                trans.Rollback();
                                MessageHandler.ShowMessageBox("预算外出库单取消审核出库错误--" + errorText);
                                return false;
                            }
                        }

                        trans.Commit();
                        swwHeadTable.AcceptChanges();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        swwHeadTable.RejectChanges();
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
