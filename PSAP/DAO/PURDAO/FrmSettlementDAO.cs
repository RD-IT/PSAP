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
    class FrmSettlementDAO
    {
        /// <summary>
        /// 查询采购结账单表头表
        /// </summary>
        /// <param name="queryDataTable">要查询填充的数据表</param>
        /// <param name="beginDateStr">开始日期字符串</param>
        /// <param name="endDateStr">结束日期字符串</param>
        /// <param name="reqDepStr">部门编号</param>
        /// <param name="bussinessBaseNoStr">往来方编号</param>
        /// <param name="reqStateInt">状态</param>
        /// <param name="preparedStr">申请人</param>
        /// <param name="commonStr">通用查询条件</param>
        /// <param name="nullTable">是否查询空表</param>
        public void QuerySettlementHead(DataTable queryDataTable, string beginDateStr, string endDateStr, string beginPayDateStr, string endPayDateStr, string reqDepStr, string bussinessBaseNoStr, int reqStateInt, string preparedStr, int approverInt, string commonStr, bool nullTable)
        {
            BaseSQL.Query(QuerySettlementHead_SQL(beginDateStr, endDateStr, beginPayDateStr, endPayDateStr, reqDepStr, bussinessBaseNoStr, reqStateInt, preparedStr, approverInt, commonStr, 0, nullTable), queryDataTable);
        }

        /// <summary>
        /// 查询采购结账单表头表的SQL
        /// </summary>
        public string QuerySettlementHead_SQL(string beginDateStr, string endDateStr, string beginPayDateStr, string endPayDateStr, string reqDepStr, string bussinessBaseNoStr, int reqStateInt, string preparedStr, int approverInt, string commonStr, int wwListAutoIdInt, bool nullTable)
        {
            string sqlStr = " 1=1";
            if (beginDateStr != "")
            {
                sqlStr += string.Format(" and SettlementDate between '{0}' and '{1}'", beginDateStr, endDateStr);
            }
            if (beginPayDateStr != "")
            {
                sqlStr += string.Format(" and PayDate between '{0}' and '{1}'", beginPayDateStr, endPayDateStr);
            }
            if (reqDepStr != "")
            {
                sqlStr += string.Format(" and ReqDep='{0}'", reqDepStr);
            }
            if (bussinessBaseNoStr != "")
            {
                sqlStr += string.Format(" and BussinessBaseNo='{0}'", bussinessBaseNoStr);
            }
            if (reqStateInt != 0)
            {
                sqlStr += string.Format(" and WarehouseState={0}", reqStateInt);
            }
            if (preparedStr != "")
            {
                sqlStr += string.Format(" and Prepared='{0}'", preparedStr);
            }
            if (commonStr != "")
            {
                sqlStr += string.Format(" and (SettlementNo like '%{0}%' or InvoiceNo like '%{0}%' or Remark like '%{0}%' or PUR_SettlementHead.ApprovalType like '%{0}%')", commonStr);
            }
            if (wwListAutoIdInt > 0)
            {
                sqlStr += string.Format(" and SettlementNo in (select SettlementNo from PUR_SettlementList where WarehouseWarrantListAutoId = {0})", wwListAutoIdInt);
            }
            if (approverInt >= 0)
            {
                if (approverInt == 0)
                    sqlStr += string.Format(" and WarehouseState in (1,4)");
                else
                {
                    sqlStr = string.Format("select PUR_SettlementHead.* from PUR_SettlementHead left join PUR_ApprovalType on PUR_SettlementHead.ApprovalType = PUR_ApprovalType.TypeNo where {0} and PUR_SettlementHead.WarehouseState in (1, 4) and( (PUR_ApprovalType.ApprovalCat = 0 and exists (select * from (select top 1 * from F_SettlementNoApprovalList(PUR_SettlementHead.SettlementNo, PUR_SettlementHead.ApprovalType) Order by AppSequence) as minlist where Approver = {1})) or (PUR_ApprovalType.ApprovalCat = 1 and exists (select * from F_SettlementNoApprovalList(PUR_SettlementHead.SettlementNo, PUR_SettlementHead.ApprovalType) where Approver = {1}))) order by AutoId", sqlStr, approverInt);
                    return sqlStr;
                }
            }
            if (nullTable)
            {
                sqlStr += " and 1=2";
            }
            sqlStr = string.Format("select * from PUR_SettlementHead where {0} order by AutoId", sqlStr);
            return sqlStr;
        }

        /// <summary>
        /// 查询采购结账单明细表
        /// </summary>
        /// <param name="queryDataTable">要查询填充的数据表</param>
        /// <param name="settlementNoStr">结账单号</param>
        public void QuerySettlementList(DataTable queryDataTable, string settlementNoStr, bool nullTable)
        {
            string sqlStr = string.Format(" and SettlementNo='{0}'", settlementNoStr);
            if (nullTable)
            {
                sqlStr += " and 1=2";
            }
            sqlStr = string.Format("select PUR_SettlementList.*, SW_PartsCode.CodeName from PUR_SettlementList left join SW_PartsCode on PUR_SettlementList.CodeFileName = SW_PartsCode.CodeFileName where 1=1 {0} order by AutoId", sqlStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 保存采购结账单
        /// </summary>
        /// <param name="SettlementHeadRow">结账单表头数据表</param>
        /// <param name="SettlementListTable">结账单明细数据表</param>
        public int SaveSettlement(DataRow SettlementHeadRow, DataTable SettlementListTable)
        {
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);

                        if (!CheckWarehouseWarrantApplyBeyondCount(cmd, SettlementHeadRow["SettlementNo"].ToString(), SettlementListTable))
                        {
                            return 0;
                        }

                        if (SettlementHeadRow["SettlementNo"].ToString() == "")//新增
                        {
                            string psNo = BaseSQL.GetMaxCodeNo(cmd, "PS");
                            SettlementHeadRow["SettlementNo"] = psNo;
                            SettlementHeadRow["PreparedIp"] = SystemInfo.HostIpAddress;

                            for (int i = 0; i < SettlementListTable.Rows.Count; i++)
                            {
                                SettlementListTable.Rows[i]["SettlementNo"] = psNo;
                            }
                        }
                        else//修改
                        {
                            if (!CheckWarehouseState(SettlementHeadRow.Table, SettlementListTable, string.Format("'{0}'", DataTypeConvert.GetString(SettlementHeadRow["SettlementNo"])), false, true, true, true))
                                return -1;

                            SettlementHeadRow["Modifier"] = SystemInfo.user.EmpName;
                            SettlementHeadRow["ModifierIp"] = SystemInfo.HostIpAddress;
                            SettlementHeadRow["ModifierTime"] = BaseSQL.GetServerDateTime();
                        }

                        //保存日志到日志表中
                        string logStr = LogHandler.RecordLog_DataRow(cmd, "采购结账单", SettlementHeadRow, "SettlementNo");

                        cmd.CommandText = "select * from PUR_SettlementHead where 1=2";
                        SqlDataAdapter adapterHead = new SqlDataAdapter(cmd);
                        DataTable tmpHeadTable = new DataTable();
                        adapterHead.Fill(tmpHeadTable);
                        BaseSQL.UpdateDataTable(adapterHead, SettlementHeadRow.Table);

                        cmd.CommandText = "select * from PUR_SettlementList where 1=2";
                        SqlDataAdapter adapterList = new SqlDataAdapter(cmd);
                        DataTable tmpListTable = new DataTable();
                        adapterList.Fill(tmpListTable);
                        BaseSQL.UpdateDataTable(adapterList, SettlementListTable);

                        Set_WWHead_End(cmd, SettlementListTable);

                        trans.Commit();

                        return 1;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        SettlementHeadRow.Table.RejectChanges();
                        SettlementListTable.RejectChanges();
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
        /// 检测数据库中采购结账单状态是否可以操作
        /// </summary>
        public bool CheckWarehouseState(DataTable SettlementHeadTable, DataTable SettlementListTable, string SettlementNoListStr, bool checkNoApprover, bool checkApprover, bool checkSettle, bool checkApproverBetween)
        {
            string sqlStr = string.Format("select SettlementNo, WarehouseState from PUR_SettlementHead where SettlementNo in ({0})", SettlementNoListStr);
            DataTable tmpTable = BaseSQL.Query(sqlStr).Tables[0];
            for (int i = 0; i < tmpTable.Rows.Count; i++)
            {
                int wState = DataTypeConvert.GetInt(tmpTable.Rows[i]["WarehouseState"]);
                switch (wState)
                {
                    case 1:
                        if (checkNoApprover)
                        {
                            MessageHandler.ShowMessageBox(string.Format("采购结账单[{0}]未审批，不可以操作。", DataTypeConvert.GetString(tmpTable.Rows[i]["SettlementNo"])));
                            SettlementHeadTable.RejectChanges();
                            if (SettlementListTable != null)
                                SettlementListTable.RejectChanges();
                            return false;
                        }
                        break;
                    case 2:
                        if (checkApprover)
                        {
                            MessageHandler.ShowMessageBox(string.Format("采购结账单[{0}]已经审批，不可以操作。", DataTypeConvert.GetString(tmpTable.Rows[i]["SettlementNo"])));
                            SettlementHeadTable.RejectChanges();
                            if (SettlementListTable != null)
                                SettlementListTable.RejectChanges();
                            return false;
                        }
                        break;
                    case 3:
                        if (checkSettle)
                        {
                            MessageHandler.ShowMessageBox(string.Format("采购结账单[{0}]已经结账，不可以操作。", DataTypeConvert.GetString(tmpTable.Rows[i]["SettlementNo"])));
                            SettlementHeadTable.RejectChanges();
                            if (SettlementListTable != null)
                                SettlementListTable.RejectChanges();
                            return false;
                        }
                        break;
                    case 4:
                        if (checkApproverBetween)
                        {
                            MessageHandler.ShowMessageBox(string.Format("采购结账单[{0}]已经审批中，不可以操作。", DataTypeConvert.GetString(tmpTable.Rows[i]["SettlementNo"])));
                            SettlementHeadTable.RejectChanges();
                            if (SettlementListTable != null)
                                SettlementListTable.RejectChanges();
                            return false;
                        }
                        break;
                }
            }

            return true;
        }

        /// <summary>
        /// 检查订单明细的数量是否超过入库单明细的数量
        /// </summary>
        private bool CheckWarehouseWarrantApplyBeyondCount(SqlCommand cmd, string settlementNoStr, DataTable settlementListTable)
        {
            if (SystemInfo.WarehouseWarrantApplyBeyondCountIsSave)
                return true;

            foreach (DataRow lrow in settlementListTable.Rows)
            {
                if (lrow.RowState == DataRowState.Deleted)
                    continue;

                string codeFileNameStr = DataTypeConvert.GetString(lrow["CodeFileName"]);
                int wwListAutoId = DataTypeConvert.GetInt(lrow["WarehouseWarrantListAutoId"]);
                string sqlStr = string.Format("WarehouseWarrantListAutoId = {0}", wwListAutoId);
                double qtySum = DataTypeConvert.GetDouble(settlementListTable.Compute("Sum(Qty)", sqlStr));
                cmd.CommandText = string.Format("select Sum(List.Qty) from PUR_SettlementList as List where List.WarehouseWarrantListAutoId = {0} and List.SettlementNo != '{1}'", wwListAutoId, settlementNoStr);
                double otherSettlementQtySum = DataTypeConvert.GetDouble(cmd.ExecuteScalar());
                cmd.CommandText = string.Format("select Qty from INV_WarehouseWarrantList where AutoId = {0}", wwListAutoId);
                double wwQtySum = DataTypeConvert.GetDouble(cmd.ExecuteScalar());
                if (qtySum + otherSettlementQtySum > wwQtySum)
                {
                    MessageHandler.ShowMessageBox(string.Format("采购结账单中明细[{0}]的数量[{1}]超过入库单的数量[{2}]，不可以保存。", codeFileNameStr, qtySum + otherSettlementQtySum, wwQtySum));
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 设定入库单完结标志
        /// </summary>
        public void Set_WWHead_End(SqlCommand cmd, DataTable settlementListTable)
        {
            string wwHeadNoStr = "";
            IEnumerable<IGrouping<string, DataRow>> result = settlementListTable.Rows.Cast<DataRow>().GroupBy<DataRow, string>(dr => dr["WarehouseWarrant"].ToString());//按WarehouseWarrant分组
            foreach (IGrouping<string, DataRow> ig in result)
            {
                if (ig.Key != "")
                {
                    wwHeadNoStr = ig.Key;
                    cmd.CommandText = string.Format("select Count(*) from V_INV_WarehouseWarrentList_Settlement where WarehouseWarrant = '{0}' and Qty>SettlementCount", wwHeadNoStr);
                    int count = DataTypeConvert.GetInt(cmd.ExecuteScalar());
                    int isEnd = 0;
                    if (count == 0)
                        isEnd = 1;
                    cmd.CommandText = string.Format("Update INV_WarehouseWarrantHead set IsEnd={1} where WarehouseWarrant='{0}'", wwHeadNoStr, isEnd);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// 根据选择删除多条采购结账单
        /// </summary>
        public bool DeleteSettlement_Multi(DataTable SettlementHeadTable)
        {
            string SettlementNoListStr = "";
            for (int i = 0; i < SettlementHeadTable.Rows.Count; i++)
            {
                if (DataTypeConvert.GetBoolean(SettlementHeadTable.Rows[i]["Select"]))
                {
                    SettlementNoListStr += string.Format("'{0}',", DataTypeConvert.GetString(SettlementHeadTable.Rows[i]["SettlementNo"]));
                }
            }
            SettlementNoListStr = SettlementNoListStr.Substring(0, SettlementNoListStr.Length - 1);
            if (!CheckWarehouseState(SettlementHeadTable, null, SettlementNoListStr, false, true, true, true))
                return false;
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);
                        cmd.CommandText = string.Format("select * from PUR_SettlementList where SettlementNo in ({0})", SettlementNoListStr);
                        DataTable tmpTable = new DataTable();
                        SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                        adpt.Fill(tmpTable);

                        //保存日志到日志表中
                        DataRow[] headRows = SettlementHeadTable.Select("select=1");
                        for (int i = 0; i < headRows.Length; i++)
                        {
                            string logStr = LogHandler.RecordLog_DeleteRow(cmd, "采购结账单", headRows[i], "SettlementNo");
                        }

                        cmd.CommandText = string.Format("Delete from PUR_SettlementList where SettlementNo in ({0})", SettlementNoListStr);
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = string.Format("Delete from PUR_SettlementHead where SettlementNo in ({0})", SettlementNoListStr);
                        cmd.ExecuteNonQuery();

                        Set_WWHead_End(cmd, tmpTable);

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
        /// 审批选中的多条采购结账单
        /// </summary>
        public bool SettlementApprovalInfo_Multi(DataTable settlementHeadTable, ref int successCountInt)
        {
            string SettlementNoListStr = "";
            for (int i = 0; i < settlementHeadTable.Rows.Count; i++)
            {
                if (DataTypeConvert.GetBoolean(settlementHeadTable.Rows[i]["Select"]))
                {
                    SettlementNoListStr += string.Format("'{0}',", DataTypeConvert.GetString(settlementHeadTable.Rows[i]["SettlementNo"]));
                }
            }

            SettlementNoListStr = SettlementNoListStr.Substring(0, SettlementNoListStr.Length - 1);
            if (!CheckWarehouseState(settlementHeadTable, null, SettlementNoListStr, false, true, true, false))
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
                        for (int i = 0; i < settlementHeadTable.Rows.Count; i++)
                        {
                            if (DataTypeConvert.GetBoolean(settlementHeadTable.Rows[i]["Select"]))
                            {
                                DataRow setRow = settlementHeadTable.Rows[i];
                                string settlementNoStr = DataTypeConvert.GetString(setRow["SettlementNo"]);

                                cmd.CommandText = string.Format("select PUR_SettlementHead.SettlementNo, PUR_SettlementHead.ApprovalType, PUR_ApprovalType.ApprovalCat from PUR_SettlementHead left join PUR_ApprovalType on PUR_SettlementHead.ApprovalType = PUR_ApprovalType.TypeNo where SettlementNo = '{0}'", settlementNoStr);
                                DataTable tmpTable = new DataTable();
                                SqlDataAdapter orderadpt = new SqlDataAdapter(cmd);
                                orderadpt.Fill(tmpTable);
                                if (tmpTable.Rows.Count == 0)
                                {
                                    trans.Rollback();
                                    MessageHandler.ShowMessageBox("未查询到要操作的采购结账单，请刷新后再进行操作。");
                                    return false;
                                }

                                //审核检查采购结账单明细数量是否超过入库单明细数量
                                DataTable orderListTable = new DataTable();
                                QuerySettlementList(orderListTable, settlementNoStr, false);
                                if (!CheckWarehouseWarrantApplyBeyondCount(cmd, settlementNoStr, orderListTable))
                                {
                                    trans.Rollback();
                                    return false;
                                }

                                Set_WWHead_End(cmd, orderListTable);

                                string approvalTypeStr = DataTypeConvert.GetString(tmpTable.Rows[0]["ApprovalType"]);
                                cmd.CommandText = string.Format("select * from F_SettlementNoApprovalList('{0}','{1}') Order by AppSequence", settlementNoStr, approvalTypeStr);
                                DataTable listTable = new DataTable();
                                SqlDataAdapter listadpt = new SqlDataAdapter(cmd);
                                listadpt.Fill(listTable);
                                if (listTable.Rows.Count == 0)
                                {
                                    cmd.CommandText = string.Format("Update PUR_SettlementHead set WarehouseState = 2 where SettlementNo='{0}'", settlementNoStr);
                                    cmd.ExecuteNonQuery();
                                    settlementHeadTable.Rows[i]["WarehouseState"] = 2;
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

                                cmd.CommandText = string.Format("Insert into PUR_SettlementApprovalInfo(SettlementNo, Approver, ApproverTime) values ('{0}', {1}, '{2}')", settlementNoStr, SystemInfo.user.AutoId, serverTime.ToString("yyyy-MM-dd HH:mm:ss"));
                                cmd.ExecuteNonQuery();

                                if (listTable.Rows.Count == 1 || approvalCatInt == 2)
                                {
                                    cmd.CommandText = string.Format("Update PUR_SettlementHead set WarehouseState=2 where SettlementNo='{0}'", settlementNoStr);
                                    cmd.ExecuteNonQuery();
                                    settlementHeadTable.Rows[i]["WarehouseState"] = 2;
                                }
                                else
                                {
                                    cmd.CommandText = string.Format("Update PUR_SettlementHead set WarehouseState=4 where SettlementNo='{0}'", settlementNoStr);
                                    cmd.ExecuteNonQuery();
                                    settlementHeadTable.Rows[i]["WarehouseState"] = 4;
                                }

                                //保存日志到日志表中
                                string logStr = LogHandler.RecordLog_OperateRow(cmd, "采购结账单", settlementHeadTable.Rows[i], "SettlementNo", "审批", SystemInfo.user.EmpName, serverTime.ToString("yyyy-MM-dd HH:mm:ss"));
                                successCountInt++;
                            }
                        }

                        trans.Commit();
                        settlementHeadTable.AcceptChanges();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        settlementHeadTable.RejectChanges();
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
        /// 取消审批选中的多条入库单
        /// </summary>
        public bool CancalSettlementApprovalInfo_Multi(DataTable settlementHeadTable)
        {
            string SettlementNoListStr = "";
            for (int i = 0; i < settlementHeadTable.Rows.Count; i++)
            {
                if (DataTypeConvert.GetBoolean(settlementHeadTable.Rows[i]["Select"]))
                {
                    SettlementNoListStr += string.Format("'{0}',", DataTypeConvert.GetString(settlementHeadTable.Rows[i]["SettlementNo"]));
                    settlementHeadTable.Rows[i]["WarehouseState"] = 1;
                }
            }

            SettlementNoListStr = SettlementNoListStr.Substring(0, SettlementNoListStr.Length - 1);
            if (!CheckWarehouseState(settlementHeadTable, null, SettlementNoListStr, true, false, true, false))
                return false;

            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);
                        cmd.CommandText = string.Format("Delete from PUR_SettlementApprovalInfo where SettlementNo in ({0})", SettlementNoListStr);
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = string.Format("Update PUR_SettlementHead set WarehouseState=1 where SettlementNo in ({0})", SettlementNoListStr);
                        cmd.ExecuteNonQuery();

                        //保存日志到日志表中
                        DataRow[] headRows = settlementHeadTable.Select("select=1");
                        for (int i = 0; i < headRows.Length; i++)
                        {
                            ////检查是否有下级的主单
                            //if (CheckApplyWarehouseWarrant(cmd, DataTypeConvert.GetString(orderHeadRows[i]["OrderHeadNo"])))
                            //{
                            //    trans.Rollback();
                            //    wwHeadTable.RejectChanges();
                            //    MessageHandler.ShowMessageBox("采购订单已经有适用的入库单记录，不可以操作。");
                            //    return false;
                            //}

                            string logStr = LogHandler.RecordLog_OperateRow(cmd, "采购结账单", headRows[i], "SettlementNo", "取消审批", SystemInfo.user.EmpName, BaseSQL.GetServerDateTime().ToString("yyyy-MM-dd HH:mm:ss"));
                        }

                        trans.Commit();
                        settlementHeadTable.AcceptChanges();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        settlementHeadTable.RejectChanges();
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
        /// 打印处理
        /// </summary>
        /// <param name="settlementNoStr">结账单号</param>
        /// <param name="handleTypeInt">打印处理类型：1 预览 2 打印 3 设计</param>
        public void PrintHandle(string settlementNoStr, int handleTypeInt)
        {
            DataSet ds = new DataSet();
            DataTable headTable = DAO.BSDAO.BaseSQL.GetTableBySql(string.Format("select * from V_Prn_PUR_SettlementHead where SettlementNo = '{0}' order by AutoId", settlementNoStr));
            headTable.TableName = "SettlementHead";
            for (int i = 0; i < headTable.Columns.Count; i++)
            {
                #region 设定主表显示的标题

                switch (headTable.Columns[i].ColumnName)
                {
                    case "SettlementNo":
                        headTable.Columns[i].Caption = "结账单号";
                        break;
                    case "InvoiceNo":
                        headTable.Columns[i].Caption = "发票号";
                        break;
                    case "SettlementDate":
                        headTable.Columns[i].Caption = "结账日期";
                        break;
                    case "DepartmentNo":
                        headTable.Columns[i].Caption = "部门编号";
                        break;
                    case "DepartmentName":
                        headTable.Columns[i].Caption = "部门名称";
                        break;
                    case "BussinessBaseNo":
                        headTable.Columns[i].Caption = "往来方编号";
                        break;
                    case "BussinessBaseText":
                        headTable.Columns[i].Caption = "往来方名称";
                        break;
                    case "BussAddress":
                        headTable.Columns[i].Caption = "往来方公司地址";
                        break;
                    case "BussPhoneNo":
                        headTable.Columns[i].Caption = "往来方电话";
                        break;
                    case "BussFaxNo":
                        headTable.Columns[i].Caption = "往来方传真";
                        break;
                    case "BussContact":
                        headTable.Columns[i].Caption = "往来方联系人";
                        break;
                    case "Tax":
                        headTable.Columns[i].Caption = "税率";
                        break;
                    case "PayDate":
                        headTable.Columns[i].Caption = "付款日期";
                        break;
                    case "IsVoucher":
                        headTable.Columns[i].Caption = "是否已生成凭证";
                        break;
                    case "Prepared":
                        headTable.Columns[i].Caption = "制单人";
                        break;
                    case "PreparedIp":
                        headTable.Columns[i].Caption = "制单人IP";
                        break;
                    case "Modifier":
                        headTable.Columns[i].Caption = "修改人";
                        break;
                    case "ModifierIp":
                        headTable.Columns[i].Caption = "修改人IP";
                        break;
                    case "ModifierTime":
                        headTable.Columns[i].Caption = "修改时间";
                        break;
                    case "Remark":
                        headTable.Columns[i].Caption = "备注";
                        break;
                    case "WarehouseState":
                        headTable.Columns[i].Caption = "单据状态";
                        break;
                    case "WarehouseStateDesc":
                        headTable.Columns[i].Caption = "单据状态描述";
                        break;
                    case "ApprovalTypeNo":
                        headTable.Columns[i].Caption = "审批类型编码";
                        break;
                    case "ApprovalTypeNoText":
                        headTable.Columns[i].Caption = "审批类型名称";
                        break;
                }

                #endregion
            }
            ds.Tables.Add(headTable);

            DataTable listTable = BaseSQL.GetTableBySql(string.Format("select *, ROW_NUMBER() over (order by AutoId) as RowNum from V_Prn_PUR_SettlementList where SettlementNo = '{0}' order by AutoId", settlementNoStr));
            listTable.TableName = "SettlementList";
            for (int i = 0; i < listTable.Columns.Count; i++)
            {
                #region 设定子表显示的标题

                switch (listTable.Columns[i].ColumnName)
                {
                    case "RowNum":
                        listTable.Columns[i].Caption = "行号";
                        break;
                    case "SettlementNo":
                        listTable.Columns[i].Caption = "结账单号";
                        break;
                    case "CodeNo":
                        listTable.Columns[i].Caption = "物料编号";
                        break;
                    case "CodeFileName":
                        listTable.Columns[i].Caption = "文件名称";
                        break;
                    case "CodeName":
                        listTable.Columns[i].Caption = "零件名称";
                        break;
                    case "CatgName":
                        listTable.Columns[i].Caption = "分类名称";
                        break;
                    case "CatgDescription":
                        listTable.Columns[i].Caption = "分类说明";
                        break;
                    case "CodeSpec":
                        listTable.Columns[i].Caption = "规格型号";
                        break;
                    case "CodeWeight":
                        listTable.Columns[i].Caption = "重量";
                        break;
                    case "MaterialVersion":
                        listTable.Columns[i].Caption = "物料版本";
                        break;
                    case "LibName":
                        listTable.Columns[i].Caption = "Level 1";
                        break;
                    case "MaterialCategory":
                        listTable.Columns[i].Caption = "Level 2";
                        break;
                    case "MaterialName":
                        listTable.Columns[i].Caption = "Level 3";
                        break;
                    case "Brand":
                        listTable.Columns[i].Caption = "品牌";
                        break;
                    case "FinishCatg":
                        listTable.Columns[i].Caption = "表面处理";
                        break;
                    case "LevelCatg":
                        listTable.Columns[i].Caption = "加工等级";
                        break;
                    case "Unit":
                        listTable.Columns[i].Caption = "单位";
                        break;
                    case "Qty":
                        listTable.Columns[i].Caption = "数量";
                        break;
                    case "Price":
                        listTable.Columns[i].Caption = "单价";
                        break;
                    case "Amount":
                        listTable.Columns[i].Caption = "金额";
                        break;
                    case "Tax":
                        listTable.Columns[i].Caption = "税率";
                        break;
                    case "TaxAmount":
                        listTable.Columns[i].Caption = "税额";
                        break;
                    case "SumAmount":
                        listTable.Columns[i].Caption = "价税合计";
                        break;                    
                    case "Remark":
                        listTable.Columns[i].Caption = "备注";
                        break;
                    case "WarehouseWarrant":
                        listTable.Columns[i].Caption = "入库单号";
                        break;
                }

                #endregion
            }
            ds.Tables.Add(listTable);

            List<DevExpress.XtraReports.Parameters.Parameter> paralist = ReportHandler.GetSystemInfo_ParamList();

            ReportHandler.XtraReport_Handle("PUR_SettlementHead", ds, paralist, handleTypeInt);
        }

    }
}
