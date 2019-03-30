using PSAP.DAO.BSDAO;
using PSAP.PSAPCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace PSAP.DAO.SADAO
{
    class FrmSettleAccountsDAO
    {
        /// <summary>
        /// 查询销售结账单表头表
        /// </summary>
        /// <param name="queryDataTable">要查询填充的数据表</param>
        /// <param name="beginDateStr">开始日期字符串</param>
        /// <param name="endDateStr">结束日期字符串</param>
        /// <param name="reqDepStr">部门编号</param>
        /// <param name="bussinessBaseNoStr">往来方编号</param>
        /// <param name="reqStateInt">状态</param>
        /// <param name="preparedStr">申请人</param>
        /// <param name="approverInt">审核人</param>
        /// <param name="commonStr">通用查询条件</param>
        /// <param name="nullTable">是否查询空表</param>
        public void QuerySettleAccountsHead(DataTable queryDataTable, string beginDateStr, string endDateStr, string reqDepStr, string bussinessBaseNoStr, string preparedStr, string commonStr, bool nullTable)
        {
            BaseSQL.Query(QuerySettleAccountsHead_SQL(beginDateStr, endDateStr, reqDepStr, bussinessBaseNoStr, preparedStr, commonStr, nullTable), queryDataTable);
        }

        /// <summary>
        /// 查询采购结账单表头表的SQL
        /// </summary>
        public string QuerySettleAccountsHead_SQL(string beginDateStr, string endDateStr, string reqDepStr, string bussinessBaseNoStr, string preparedStr, string commonStr, bool nullTable)
        {
            string sqlStr = " 1=1";
            if (beginDateStr != "")
            {
                sqlStr += string.Format(" and SettleAccountDate between '{0}' and '{1}'", beginDateStr, endDateStr);
            }
            if (reqDepStr != "")
            {
                sqlStr += string.Format(" and ReqDep = '{0}'", reqDepStr);
            }
            if (bussinessBaseNoStr != "")
            {
                sqlStr += string.Format(" and BussinessBaseNo = '{0}'", bussinessBaseNoStr);
            }
            if (preparedStr != "")
            {
                sqlStr += string.Format(" and Prepared = '{0}'", preparedStr);
            }
            if (commonStr != "")
            {
                sqlStr += string.Format(" and (SettleAccountNo like '%{0}%' or Remark like '%{0}%')", commonStr);
            }
            if (nullTable)
            {
                sqlStr += " and 1=2";
            }
            sqlStr = string.Format("select * from SA_SettleAccountsHead where {0} order by AutoId", sqlStr);
            return sqlStr;
        }


        /// <summary>
        /// 查询销售结账单明细表
        /// </summary>
        /// <param name="queryDataTable">要查询填充的数据表</param>
        /// <param name="settlementNoStr">结账单号</param>
        public void QuerySettlementList(DataTable queryDataTable, string settleAccountNoStr, bool nullTable)
        {
            string sqlStr = string.Format(" and SettleAccountNo = '{0}'", settleAccountNoStr);
            if (nullTable)
            {
                sqlStr += " and 1=2";
            }
            sqlStr = string.Format("select SA_SettleAccountsList.* from SA_SettleAccountsList where 1=1 {0} order by AutoId", sqlStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 保存采购结账单
        /// </summary>
        /// <param name="SettleAccountsHeadRow">销售结账单表头数据表</param>
        /// <param name="SettleAccountsListTable">销售结账单明细数据表</param>
        public int SaveSettleAccounts(DataRow SettleAccountsHeadRow, DataTable SettleAccountsListTable)
        {
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);

                        for (int i = 0; i < SettleAccountsListTable.Rows.Count; i++)
                        {
                            if (SettleAccountsListTable.Rows[i].RowState == DataRowState.Deleted)
                                continue;
                            string autoSalesOrderNoStr = DataTypeConvert.GetString(SettleAccountsListTable.Rows[i]["AutoSalesOrderNo"]);
                            cmd.CommandText = string.Format("select Count(*) from SA_SalesOrder where AutoSalesOrderNo = '{0}'", autoSalesOrderNoStr);
                            if (DataTypeConvert.GetInt(cmd.ExecuteScalar()) < 1)
                            {
                                MessageHandler.ShowMessageBox(string.Format("销售订单[{0}]未查询到，请查询后重新操作。", autoSalesOrderNoStr));
                                return 0;
                            }
                        }

                        if (!CheckSalesOrderIsEnd(cmd, DataTypeConvert.GetString(SettleAccountsHeadRow["SettleAccountNo"]), SettleAccountsListTable))
                        {
                            return 0;
                        }

                        if (DataTypeConvert.GetString(SettleAccountsHeadRow["SettleAccountNo"]) == "")//新增
                        {
                            string saNo = BaseSQL.GetMaxCodeNo(cmd, "SA");
                            SettleAccountsHeadRow["SettleAccountNo"] = saNo;
                            SettleAccountsHeadRow["PreparedIp"] = SystemInfo.HostIpAddress;

                            for (int i = 0; i < SettleAccountsListTable.Rows.Count; i++)
                            {
                                SettleAccountsListTable.Rows[i]["SettleAccountNo"] = saNo;
                            }
                        }
                        else//修改
                        {
                            SettleAccountsHeadRow["Modifier"] = SystemInfo.user.EmpName;
                            SettleAccountsHeadRow["ModifierIp"] = SystemInfo.HostIpAddress;
                            SettleAccountsHeadRow["ModifierTime"] = BaseSQL.GetServerDateTime();
                        }

                        string settleAccountNoStr = DataTypeConvert.GetString(SettleAccountsHeadRow["SettleAccountNo"]);
                        cmd.CommandText = string.Format("Update SA_SalesOrder set IsEnd = 0 where AutoSalesOrderNo in (select AutoSalesOrderNo from SA_SettleAccountsList where SettleAccountNo = '{0}')", settleAccountNoStr);
                        cmd.ExecuteNonQuery();

                        //保存日志到日志表中
                        string logStr = LogHandler.RecordLog_DataRow(cmd, "销售结账单", SettleAccountsHeadRow, "SettleAccountNo");

                        cmd.CommandText = "select * from SA_SettleAccountsHead where 1=2";
                        SqlDataAdapter adapterHead = new SqlDataAdapter(cmd);
                        DataTable tmpHeadTable = new DataTable();
                        adapterHead.Fill(tmpHeadTable);
                        BaseSQL.UpdateDataTable(adapterHead, SettleAccountsHeadRow.Table);

                        cmd.CommandText = "select * from SA_SettleAccountsList where 1=2";
                        SqlDataAdapter adapterList = new SqlDataAdapter(cmd);
                        DataTable tmpListTable = new DataTable();
                        adapterList.Fill(tmpListTable);
                        BaseSQL.UpdateDataTable(adapterList, SettleAccountsListTable);

                        Set_SalesOrder_End(cmd, settleAccountNoStr, SettleAccountsListTable);

                        trans.Commit();

                        return 1;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        SettleAccountsHeadRow.Table.RejectChanges();
                        SettleAccountsListTable.RejectChanges();
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
        /// 检查销售订单是否已经结完账
        /// </summary>
        public bool CheckSalesOrderIsEnd(SqlCommand cmd, string settleAccountNoStr, DataTable SettleAccountsListTable)
        {
            foreach (DataRow row in SettleAccountsListTable.Rows)
            {
                if (row.RowState == DataRowState.Modified || row.RowState == DataRowState.Added)
                {
                    string autoSalesOrderNoStr = DataTypeConvert.GetString(row["AutoSalesOrderNo"]);
                    cmd.CommandText = string.Format("select AutoSalesOrderNo, Amount from SA_SalesOrder where AutoSalesOrderNo = '{0}'", autoSalesOrderNoStr);
                    DataTable salesOrderTable = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(salesOrderTable);
                    if (salesOrderTable.Rows.Count == 0)
                    {
                        MessageHandler.ShowMessageBox(string.Format("未查询到销售订单[{0}]，请重新操作。", autoSalesOrderNoStr));
                        return false;
                    }
                    decimal amount = DataTypeConvert.GetDecimal(salesOrderTable.Rows[0]["Amount"]);
                    //int isEnd = DataTypeConvert.GetInt(salesOrderTable.Rows[0]["IsEnd"]);
                    //if (isEnd == 1)
                    //{
                    //    MessageHandler.ShowMessageBox(string.Format("销售订单[{0}]已经结完账，不可以重复结账。"));
                    //    return false;
                    //}
                    cmd.CommandText = string.Format("select Sum(Amount) from SA_SettleAccountsList where AutoSalesOrderNo = '{0}' and SettleAccountNo != '{1}'", autoSalesOrderNoStr, settleAccountNoStr);
                    decimal otherSettleAmount = DataTypeConvert.GetDecimal(cmd.ExecuteScalar());
                    decimal settleAmount = DataTypeConvert.GetDecimal(row["Amount"]);
                    if (amount < otherSettleAmount + settleAmount)
                    {
                        MessageHandler.ShowMessageBox(string.Format("多张销售结账单的合计金额超过销售订单[{0}]的金额，不可以销售结账。",autoSalesOrderNoStr));
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// 设定销售订单结完账标志
        /// </summary>
        public void Set_SalesOrder_End(SqlCommand cmd, string settleAccountNoStr, DataTable SettleAccountsListTable)
        {
            cmd.CommandText = string.Format("Update SA_SalesOrder set IsEnd = 1 from SA_SalesOrder where SA_SalesOrder.AutoSalesOrderNo in (select AutoSalesOrderNo from SA_SettleAccountsList where SettleAccountNo = '{0}') and SA_SalesOrder.Amount = (select Sum(Amount) from SA_SettleAccountsList where AutoSalesOrderNo = SA_SalesOrder.AutoSalesOrderNo)", settleAccountNoStr);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// 根据选择删除多条销售结账单
        /// </summary>
        public bool DeleteSettleAccounts_Multi(DataTable SettleAccountsHeadTable)
        {
            string SettleAccountNoListStr = "";
            for (int i = 0; i < SettleAccountsHeadTable.Rows.Count; i++)
            {
                if (DataTypeConvert.GetBoolean(SettleAccountsHeadTable.Rows[i]["Select"]))
                {
                    SettleAccountNoListStr += string.Format("'{0}',", DataTypeConvert.GetString(SettleAccountsHeadTable.Rows[i]["SettleAccountNo"]));
                }
            }
            SettleAccountNoListStr = SettleAccountNoListStr.Substring(0, SettleAccountNoListStr.Length - 1);
            //if (!CheckWarehouseState(SettleAccountsHeadTable, null, SettlementNoListStr, false, true, true, true))
            //    return false;
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);
                        //cmd.CommandText = string.Format("select * from SA_SettleAccountsList where SettleAccountNo in ({0})", SettleAccountNoListStr);
                        //DataTable tmpTable = new DataTable();
                        //SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                        //adpt.Fill(tmpTable);

                        //设定销售订单的未结账标志
                        cmd.CommandText = string.Format("Update SA_SalesOrder set IsEnd = 0 where AutoSalesOrderNo in (select AutoSalesOrderNo from SA_SettleAccountsList where SettleAccountNo in ({0}))", SettleAccountNoListStr);
                        cmd.ExecuteNonQuery();

                        //保存日志到日志表中
                        DataRow[] headRows = SettleAccountsHeadTable.Select("select=1");
                        for (int i = 0; i < headRows.Length; i++)
                        {
                            string logStr = LogHandler.RecordLog_DeleteRow(cmd, "销售结账单", headRows[i], "SettleAccountNo");
                        }

                        cmd.CommandText = string.Format("Delete from SA_SettleAccountsList where SettleAccountNo in ({0})", SettleAccountNoListStr);
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = string.Format("Delete from SA_SettleAccountsHead where SettleAccountNo in ({0})", SettleAccountNoListStr);
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
        /// 打印处理
        /// </summary>
        /// <param name="settleAccountNoStr">结账单号</param>
        /// <param name="handleTypeInt">打印处理类型：1 预览 2 打印 3 设计</param>
        public void PrintHandle(string settleAccountNoStr, int handleTypeInt)
        {
            DataSet ds = new DataSet();
            DataTable headTable = BaseSQL.GetTableBySql(string.Format("select * from V_Prn_SA_SettleAccountsHead where SettleAccountNo = '{0}' order by AutoId", settleAccountNoStr));
            headTable.TableName = "SettleAccountsHead";
            for (int i = 0; i < headTable.Columns.Count; i++)
            {
                #region 设定主表显示的标题

                switch (headTable.Columns[i].ColumnName)
                {
                    case "SettleAccountNo":
                        headTable.Columns[i].Caption = "结账单号";
                        break;
                    case "SettleAccountDate":
                        headTable.Columns[i].Caption = "登记日期";
                        break;
                    case "DepartmentNo":
                        headTable.Columns[i].Caption = "部门编号";
                        break;
                    case "DepartmentName":
                        headTable.Columns[i].Caption = "部门名称";
                        break;
                    case "BussinessBaseNo":
                        headTable.Columns[i].Caption = "客户编号";
                        break;
                    case "BussinessBaseText":
                        headTable.Columns[i].Caption = "客户名称";
                        break;
                    case "BussAddress":
                        headTable.Columns[i].Caption = "客户公司地址";
                        break;
                    case "BussPhoneNo":
                        headTable.Columns[i].Caption = "客户电话";
                        break;
                    case "BussFaxNo":
                        headTable.Columns[i].Caption = "客户传真";
                        break;
                    case "BussContact":
                        headTable.Columns[i].Caption = "客户联系人";
                        break;
                    case "IsVoucher":
                        headTable.Columns[i].Caption = "生成凭证";
                        break;
                    case "Remark":
                        headTable.Columns[i].Caption = "备注";
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
                }

                #endregion
            }
            ds.Tables.Add(headTable);

            DataTable listTable = BaseSQL.GetTableBySql(string.Format("select *, ROW_NUMBER() over (order by AutoId) as RowNum from V_Prn_SA_SettleAccountsList where SettleAccountNo = '{0}' order by AutoId", settleAccountNoStr));
            listTable.TableName = "SettleAccountsList";
            for (int i = 0; i < listTable.Columns.Count; i++)
            {
                #region 设定子表显示的标题

                switch (listTable.Columns[i].ColumnName)
                {
                    case "RowNum":
                        listTable.Columns[i].Caption = "行号";
                        break;
                    case "SettleAccountNo":
                        listTable.Columns[i].Caption = "结账单号";
                        break;
                    case "AutoSalesOrderNo":
                        listTable.Columns[i].Caption = "销售订单号";
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
                }

                #endregion
            }
            ds.Tables.Add(listTable);

            ReportHandler rptHandler = new ReportHandler();
            List<DevExpress.XtraReports.Parameters.Parameter> paralist = rptHandler.GetSystemInfo_ParamList();
            rptHandler.XtraReport_Handle("SA_SettleAccountsHead", ds, paralist, handleTypeInt);
        }
    }
}
