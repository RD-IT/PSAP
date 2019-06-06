using PSAP.DAO.BSDAO;
using PSAP.PSAPCommon;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace PSAP.DAO.INVDAO
{
    public class FrmReturnedGoodsReportDAO
    {
        /// <summary>
        /// 查询退货单表头
        /// </summary>
        /// <param name="queryDataTable">要查询填充的数据表</param>
        /// <param name="beginDateStr">开始日期字符串</param>
        /// <param name="endDateStr">结束日期字符串</param>
        /// <param name="reqDepStr">部门</param>
        /// <param name="bussinessBaseNoStr">供应商</param>
        /// <param name="repertoryNoStr">退货仓库</param>
        /// <param name="warehouseStateInt">订单状态</param>
        /// <param name="preparedStr">制单人</param>
        /// <param name="approverInt">审核人</param>
        /// <param name="commonStr">通用查询条件</param>
        /// <param name="nullTable">是否查询空表</param>
        public void QueryReturnedGoodsReportHead(DataTable queryDataTable, string beginDateStr, string endDateStr, string reqDepStr, string bussinessBaseNoStr, string repertoryNoStr, int warehouseStateInt, string preparedStr, int approverInt, string commonStr, bool nullTable)
        {
            BaseSQL.Query(QueryReturnedGoodsReportHead_SQL(beginDateStr, endDateStr, reqDepStr, bussinessBaseNoStr, repertoryNoStr, warehouseStateInt, preparedStr, approverInt, commonStr, nullTable), queryDataTable);
        }

        /// <summary>
        /// 查询退货单表头的SQL
        /// </summary>
        public string QueryReturnedGoodsReportHead_SQL(string beginDateStr, string endDateStr, string reqDepStr, string bussinessBaseNoStr, string repertoryNoStr, int warehouseStateInt, string preparedStr, int approverInt, string commonStr, bool nullTable)
        {
            string sqlStr = " 1=1";
            if (beginDateStr != "")
            {
                sqlStr += string.Format(" and ReturnedGoodsReportDate between '{0}' and '{1}'", beginDateStr, endDateStr);
            }
            if (reqDepStr != "")
            {
                sqlStr += string.Format(" and ReqDep='{0}'", reqDepStr);
            }
            if (bussinessBaseNoStr != "")
            {
                sqlStr += string.Format(" and BussinessBaseNo='{0}'", bussinessBaseNoStr);
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
                sqlStr += string.Format(" and (ReturnedGoodsReportNo like '%{0}%' or Remark like '%{0}%' or ReturnedGoodsReasons like '%{0}%')", commonStr);
            }
            if (approverInt >= 0)
            {
                if (approverInt == 0)
                    sqlStr += string.Format(" and WarehouseState in (1,4)");
                else
                {
                    sqlStr = string.Format("select Head.* from INV_ReturnedGoodsReportHead as Head left join PUR_ApprovalType on Head.ApprovalType = PUR_ApprovalType.TypeNo where {0} and Head.WarehouseState in (1, 4) and ((PUR_ApprovalType.ApprovalCat = 0 and exists (select * from(select top 1 * from F_OrderNoApprovalList(Head.ReturnedGoodsReportNo, Head.ApprovalType) Order by AppSequence) as minlist where Approver = {1})) or(PUR_ApprovalType.ApprovalCat = 1 and exists(select * from F_OrderNoApprovalList(Head.ReturnedGoodsReportNo, Head.ApprovalType) where Approver = {1}))) order by AutoId", sqlStr, approverInt);
                    return sqlStr;
                }
            }
            if (nullTable)
            {
                sqlStr += " and 1=2";
            }
            sqlStr = string.Format("select * from INV_ReturnedGoodsReportHead where {0} order by AutoId", sqlStr);
            return sqlStr;
        }

        /// <summary>
        /// 查询退货单明细表
        /// </summary>
        /// <param name="queryDataTable">要查询填充的数据表</param>
        /// <param name="returnedGoodsReportNoStr">退货单号</param>
        public void QueryReturnedGoodsReportList(DataTable queryDataTable, string returnedGoodsReportNoStr, bool nullTable)
        {
            string sqlStr = string.Format(" and ReturnedGoodsReportNo='{0}'", returnedGoodsReportNoStr);
            if (nullTable)
            {
                sqlStr += " and 1=2";
            }
            sqlStr = string.Format("select INV_ReturnedGoodsReportList.*, SW_PartsCode.CodeName, BS_ProjectList.ProjectNo from INV_ReturnedGoodsReportList left join SW_PartsCode on INV_ReturnedGoodsReportList.CodeFileName = SW_PartsCode.CodeFileName left join BS_ProjectList on INV_ReturnedGoodsReportList.ProjectName = BS_ProjectList.ProjectName where 1=1 {0} order by AutoId", sqlStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }


        /// <summary>
        /// 保存退货单
        /// </summary>
        /// <param name="rgrHeadRow">退货单表头数据表</param>
        /// <param name="rgrListTable">退货单明细数据表</param>
        public int SaveReturnedGoodsReport(DataRow rgrHeadRow, DataTable rgrListTable)
        {
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);

                        //if (!CheckOrderApplyBeyondCount(cmd, DataTypeConvert.GetString(wwHeadRow["WarehouseWarrant"]), wwListTable))
                        //{
                        //    return 0;
                        //}

                        if (DataTypeConvert.GetString(rgrHeadRow["ReturnedGoodsReportNo"]) == "")//新增
                        {
                            string swwNo = BaseSQL.GetMaxCodeNo(cmd, "RG");
                            rgrHeadRow["ReturnedGoodsReportNo"] = swwNo;
                            rgrHeadRow["PreparedIp"] = SystemInfo.HostIpAddress;

                            for (int i = 0; i < rgrListTable.Rows.Count; i++)
                            {
                                rgrListTable.Rows[i]["ReturnedGoodsReportNo"] = swwNo;
                            }
                        }
                        else//修改
                        {
                            if (!CheckWarehouseState(rgrHeadRow.Table, rgrListTable, string.Format("'{0}'", DataTypeConvert.GetString(rgrHeadRow["ReturnedGoodsReportNo"])), false, true, true, true))
                                return -1;

                            rgrHeadRow["Modifier"] = SystemInfo.user.EmpName;
                            rgrHeadRow["ModifierIp"] = SystemInfo.HostIpAddress;
                            rgrHeadRow["ModifierTime"] = BaseSQL.GetServerDateTime();
                        }

                        //保存日志到日志表中
                        string logStr = LogHandler.RecordLog_DataRow(cmd, "退货单", rgrHeadRow, "ReturnedGoodsReportNo");

                        cmd.CommandText = "select * from INV_ReturnedGoodsReportHead where 1=2";
                        SqlDataAdapter adapterHead = new SqlDataAdapter(cmd);
                        DataTable tmpHeadTable = new DataTable();
                        adapterHead.Fill(tmpHeadTable);
                        BaseSQL.UpdateDataTable(adapterHead, rgrHeadRow.Table);

                        cmd.CommandText = "select * from INV_ReturnedGoodsReportList where 1=2";
                        SqlDataAdapter adapterList = new SqlDataAdapter(cmd);
                        DataTable tmpListTable = new DataTable();
                        adapterList.Fill(tmpListTable);
                        BaseSQL.UpdateDataTable(adapterList, rgrListTable);

                        //Set_OrderHead_End(cmd, swwListTable);

                        trans.Commit();

                        return 1;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        rgrHeadRow.Table.RejectChanges();
                        rgrListTable.RejectChanges();
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
        /// 检测数据库中退货单状态是否可以操作
        /// </summary>
        public bool CheckWarehouseState(DataTable rgrHeadTable, DataTable rgrListTable, string returnedGoodsReportNoListStr, bool checkNoApprover, bool checkApprover, bool checkSettle, bool checkApproverBetween)
        {
            string sqlStr = string.Format("select ReturnedGoodsReportNo, WarehouseState from INV_ReturnedGoodsReportHead where ReturnedGoodsReportNo in ({0})", returnedGoodsReportNoListStr);
            DataTable tmpTable = BaseSQL.Query(sqlStr).Tables[0];
            for (int i = 0; i < tmpTable.Rows.Count; i++)
            {
                int wState = DataTypeConvert.GetInt(tmpTable.Rows[i]["WarehouseState"]);
                switch (wState)
                {
                    case 1:
                        if (checkNoApprover)
                        {
                            MessageHandler.ShowMessageBox(string.Format("退货单[{0}]未审批，不可以操作。", DataTypeConvert.GetString(tmpTable.Rows[i]["ReturnedGoodsReportNo"])));
                            rgrHeadTable.RejectChanges();
                            if (rgrListTable != null)
                                rgrListTable.RejectChanges();
                            return false;
                        }
                        break;
                    case 2:
                        if (checkApprover)
                        {
                            MessageHandler.ShowMessageBox(string.Format("退货单[{0}]已经审批，不可以操作。", DataTypeConvert.GetString(tmpTable.Rows[i]["ReturnedGoodsReportNo"])));
                            rgrHeadTable.RejectChanges();
                            if (rgrListTable != null)
                                rgrListTable.RejectChanges();
                            return false;
                        }
                        break;
                    //case 3:
                    //    if (checkSettle)
                    //    {
                    //        MessageHandler.ShowMessageBox(string.Format("退货单[{0}]已经结账，不可以操作。", DataTypeConvert.GetString(tmpTable.Rows[i]["ReturnedGoodsReportNo"])));
                    //        swwHeadTable.RejectChanges();
                    //        if (swwListTable != null)
                    //            swwListTable.RejectChanges();
                    //        return false;
                    //    }
                    //    break;
                    case 4:
                        if (checkApproverBetween)
                        {
                            MessageHandler.ShowMessageBox(string.Format("退货单[{0}]已经审批中，不可以操作。", DataTypeConvert.GetString(tmpTable.Rows[i]["ReturnedGoodsReportNo"])));
                            rgrHeadTable.RejectChanges();
                            if (rgrListTable != null)
                                rgrListTable.RejectChanges();
                            return false;
                        }
                        break;
                }
            }

            return true;
        }


        /// <summary>
        /// 根据选择删除多条预算外退货单
        /// </summary>
        public bool DeleteRGR_Multi(DataTable rgrHeadTable)
        {
            string rgrHeadNoListStr = "";
            for (int i = 0; i < rgrHeadTable.Rows.Count; i++)
            {
                if (DataTypeConvert.GetBoolean(rgrHeadTable.Rows[i]["Select"]))
                {
                    rgrHeadNoListStr += string.Format("'{0}',", DataTypeConvert.GetString(rgrHeadTable.Rows[i]["ReturnedGoodsReportNo"]));
                }
            }
            rgrHeadNoListStr = rgrHeadNoListStr.Substring(0, rgrHeadNoListStr.Length - 1);
            if (!CheckWarehouseState(rgrHeadTable, null, rgrHeadNoListStr, false, true, true, true))
                return false;
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);
                        cmd.CommandText = string.Format("select * from INV_ReturnedGoodsReportList where ReturnedGoodsReportNo in ({0})", rgrHeadNoListStr);
                        DataTable tmpTable = new DataTable();
                        SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                        adpt.Fill(tmpTable);

                        //保存日志到日志表中
                        DataRow[] rgrHeadRows = rgrHeadTable.Select("select=1");
                        for (int i = 0; i < rgrHeadRows.Length; i++)
                        {
                            string logStr = LogHandler.RecordLog_DeleteRow(cmd, "退货单", rgrHeadRows[i], "ReturnedGoodsReportNo");
                        }

                        cmd.CommandText = string.Format("Delete from INV_ReturnedGoodsReportList where ReturnedGoodsReportNo in ({0})", rgrHeadNoListStr);
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = string.Format("Delete from INV_ReturnedGoodsReportHead where ReturnedGoodsReportNo in ({0})", rgrHeadNoListStr);
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
        /// 审批选中的多条退货单
        /// </summary>
        public bool RGRApprovalInfo_Multi(DataTable rgrHeadTable, ref int successCountInt)
        {
            string rgrHeadNoListStr = "";
            for (int i = 0; i < rgrHeadTable.Rows.Count; i++)
            {
                if (DataTypeConvert.GetBoolean(rgrHeadTable.Rows[i]["Select"]))
                {
                    rgrHeadNoListStr += string.Format("'{0}',", DataTypeConvert.GetString(rgrHeadTable.Rows[i]["ReturnedGoodsReportNo"]));
                }
            }

            rgrHeadNoListStr = rgrHeadNoListStr.Substring(0, rgrHeadNoListStr.Length - 1);
            if (!CheckWarehouseState(rgrHeadTable, null, rgrHeadNoListStr, false, true, true, false))
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
                        for (int i = 0; i < rgrHeadTable.Rows.Count; i++)
                        {
                            if (DataTypeConvert.GetBoolean(rgrHeadTable.Rows[i]["Select"]))
                            {
                                DataRow rgrRow = rgrHeadTable.Rows[i];
                                string rgrHeadNoStr = DataTypeConvert.GetString(rgrRow["ReturnedGoodsReportNo"]);

                                cmd.CommandText = string.Format("select INV_ReturnedGoodsReportHead.ReturnedGoodsReportNo, INV_ReturnedGoodsReportHead.ApprovalType, PUR_ApprovalType.ApprovalCat from INV_ReturnedGoodsReportHead left join PUR_ApprovalType on INV_ReturnedGoodsReportHead.ApprovalType = PUR_ApprovalType.TypeNo where ReturnedGoodsReportNo = '{0}'", rgrHeadNoStr);
                                DataTable tmpTable = new DataTable();
                                SqlDataAdapter orderadpt = new SqlDataAdapter(cmd);
                                orderadpt.Fill(tmpTable);
                                if (tmpTable.Rows.Count == 0)
                                {
                                    trans.Rollback();
                                    MessageHandler.ShowMessageBox("未查询到要操作的退货单，请刷新后再进行操作。");
                                    return false;
                                }
                                
                                ////审核检查入库明细数量是否超过采购订单明细数量
                                //DataTable orderListTable = new DataTable();
                                //QueryWarehouseWarrantList(orderListTable, swwHeadNoStr, false);
                                //if (!CheckOrderApplyBeyondCount(cmd, swwHeadNoStr, orderListTable))
                                //{
                                //    trans.Rollback();
                                //    return false;
                                //}

                                //Set_OrderHead_End(cmd, orderListTable);

                                string approvalTypeStr = DataTypeConvert.GetString(tmpTable.Rows[0]["ApprovalType"]);
                                cmd.CommandText = string.Format("select * from F_OrderNoApprovalList('{0}','{1}') Order by AppSequence", rgrHeadNoStr, approvalTypeStr);
                                DataTable listTable = new DataTable();
                                SqlDataAdapter listadpt = new SqlDataAdapter(cmd);
                                listadpt.Fill(listTable);
                                if (listTable.Rows.Count == 0)
                                {
                                    cmd.CommandText = string.Format("Update INV_ReturnedGoodsReportHead set WarehouseState = 2 where ReturnedGoodsReportNo='{0}'", rgrHeadNoStr);
                                    cmd.ExecuteNonQuery();
                                    rgrHeadTable.Rows[i]["WarehouseState"] = 2;
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

                                cmd.CommandText = string.Format("Insert into PUR_OrderApprovalInfo(OrderHeadNo, Approver, ApproverTime) values ('{0}', {1}, '{2}')", rgrHeadNoStr, SystemInfo.user.AutoId, serverTime.ToString("yyyy-MM-dd HH:mm:ss"));
                                cmd.ExecuteNonQuery();

                                if (listTable.Rows.Count == 1 || approvalCatInt == 2)
                                {
                                    cmd.CommandText = string.Format("Update INV_ReturnedGoodsReportHead set WarehouseState=2 where ReturnedGoodsReportNo='{0}'", rgrHeadNoStr);
                                    cmd.ExecuteNonQuery();
                                    rgrHeadTable.Rows[i]["WarehouseState"] = 2;
                                }
                                else
                                {
                                    cmd.CommandText = string.Format("Update INV_ReturnedGoodsReportHead set WarehouseState=4 where ReturnedGoodsReportNo='{0}'", rgrHeadNoStr);
                                    cmd.ExecuteNonQuery();
                                    rgrHeadTable.Rows[i]["WarehouseState"] = 4;
                                }

                                //保存日志到日志表中
                                string logStr = LogHandler.RecordLog_OperateRow(cmd, "退货单", rgrHeadTable.Rows[i], "ReturnedGoodsReportNo", "审批", SystemInfo.user.EmpName, serverTime.ToString("yyyy-MM-dd HH:mm:ss"));

                                if (DataTypeConvert.GetInt(rgrHeadTable.Rows[i]["WarehouseState"]) == 2)//全部审核通过进行下一步操作
                                {
                                    SqlCommand cmd_proc = new SqlCommand("", conn, trans);
                                    string errorText = "";
                                    if (!new FrmWarehouseNowInfoDAO().Update_WarehouseNowInfo(cmd_proc, rgrHeadNoStr, 1, out errorText))
                                    {
                                        trans.Rollback();
                                        MessageHandler.ShowMessageBox("退货单审核入库错误--" + errorText);
                                        return false;
                                    }
                                }

                                successCountInt++;
                            }
                        }

                        trans.Commit();
                        rgrHeadTable.AcceptChanges();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        rgrHeadTable.RejectChanges();
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
        /// 取消审批选中的多条预算外入库单
        /// </summary>
        public bool CancalRGRApprovalInfo_Multi(DataTable rgrHeadTable)
        {
            string rgrHeadNoListStr = "";
            for (int i = 0; i < rgrHeadTable.Rows.Count; i++)
            {
                if (DataTypeConvert.GetBoolean(rgrHeadTable.Rows[i]["Select"]))
                {
                    rgrHeadNoListStr += string.Format("'{0}',", DataTypeConvert.GetString(rgrHeadTable.Rows[i]["ReturnedGoodsReportNo"]));
                    rgrHeadTable.Rows[i]["WarehouseState"] = 1;
                }
            }

            rgrHeadNoListStr = rgrHeadNoListStr.Substring(0, rgrHeadNoListStr.Length - 1);
            if (!CheckWarehouseState(rgrHeadTable, null, rgrHeadNoListStr, true, false, true, false))
                return false;

            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);
                        DateTime serverTime = BaseSQL.GetServerDateTime();
                        cmd.CommandText = string.Format("select ReturnedGoodsReportNo from INV_ReturnedGoodsReportHead where WarehouseState = 2 and ReturnedGoodsReportNo in ({0})", rgrHeadNoListStr);
                        DataTable approcalRGRTable = new DataTable();
                        SqlDataAdapter appradpt = new SqlDataAdapter(cmd);
                        appradpt.Fill(approcalRGRTable);

                        cmd.CommandText = string.Format("Delete from PUR_OrderApprovalInfo where OrderHeadNo in ({0})", rgrHeadNoListStr);
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = string.Format("Update INV_ReturnedGoodsReportHead set WarehouseState=1 where ReturnedGoodsReportNo in ({0})", rgrHeadNoListStr);
                        cmd.ExecuteNonQuery();

                        //保存日志到日志表中
                        DataRow[] rgrHeadRows = rgrHeadTable.Select("select=1");
                        for (int i = 0; i < rgrHeadRows.Length; i++)
                        {
                            ////检查是否有下级的主单
                            //if (CheckApplySettlement(cmd, DataTypeConvert.GetString(orderHeadRows[i]["WarehouseWarrant"])))
                            //{
                            //    trans.Rollback();
                            //    swwHeadTable.RejectChanges();
                            //    MessageHandler.ShowMessageBox("入库单已经有适用的采购结账单记录，不可以操作。");
                            //    return false;
                            //}

                            string logStr = LogHandler.RecordLog_OperateRow(cmd, "退货单", rgrHeadRows[i], "ReturnedGoodsReportNo", "取消审批", SystemInfo.user.EmpName, serverTime.ToString("yyyy-MM-dd HH:mm:ss"));
                        }

                        for (int i = 0; i < approcalRGRTable.Rows.Count; i++)
                        {
                            SqlCommand cmd_proc = new SqlCommand("", conn, trans);
                            string errorText = "";
                            if (!new FrmWarehouseNowInfoDAO().Update_WarehouseNowInfo(cmd_proc, DataTypeConvert.GetString(approcalRGRTable.Rows[i]["ReturnedGoodsReportNo"]), 2, out errorText))
                            {
                                trans.Rollback();
                                MessageHandler.ShowMessageBox("退货单取消审核出库错误--" + errorText);
                                return false;
                            }
                        }

                        trans.Commit();
                        rgrHeadTable.AcceptChanges();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        rgrHeadTable.RejectChanges();
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
        /// <param name="rgrHeadNoStr">退货单号</param>
        /// <param name="handleTypeInt">打印处理类型：1 预览 2 打印 3 设计</param>
        public void PrintHandle(string rgrHeadNoStr, int handleTypeInt)
        {
            DataSet ds = new DataSet();
            DataTable headTable = BaseSQL.GetTableBySql(string.Format("select * from V_Prn_INV_ReturnedGoodsReportHead where ReturnedGoodsReportNo = '{0}' order by AutoId", rgrHeadNoStr));
            headTable.TableName = "ReturnedGoodsReportHead";
            for (int i = 0; i < headTable.Columns.Count; i++)
            {
                #region 设定主表显示的标题

                switch (headTable.Columns[i].ColumnName)
                {
                    case "ReturnedGoodsReportNo":
                        headTable.Columns[i].Caption = "退货单号";
                        break;
                    case "ReturnedGoodsReportDate":
                        headTable.Columns[i].Caption = "退货日期";
                        break;
                    case "BussinessBaseNo":
                        headTable.Columns[i].Caption = "供应商编号";
                        break;
                    case "BussinessBaseText":
                        headTable.Columns[i].Caption = "供应商名称";
                        break;
                    case "BussAddress":
                        headTable.Columns[i].Caption = "供应商公司地址";
                        break;
                    case "BussPhoneNo":
                        headTable.Columns[i].Caption = "供应商电话";
                        break;
                    case "BussFaxNo":
                        headTable.Columns[i].Caption = "供应商传真";
                        break;
                    case "BussContact":
                        headTable.Columns[i].Caption = "供应商联系人";
                        break;
                    case "RepertoryNo":
                        headTable.Columns[i].Caption = "退货仓库编号";
                        break;
                    case "RepertoryName":
                        headTable.Columns[i].Caption = "退货仓库名称";
                        break;
                    case "Prepared":
                        headTable.Columns[i].Caption = "制单人";
                        break;
                    case "PreparedIp":
                        headTable.Columns[i].Caption = "制单人IP";
                        break;
                    case "Remark":
                        headTable.Columns[i].Caption = "备注";
                        break;
                    case "ApprovalTypeNo":
                        headTable.Columns[i].Caption = "审批类型编码";
                        break;
                    case "ApprovalTypeNoText":
                        headTable.Columns[i].Caption = "审批类型名称";
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
                    case "WarehouseState":
                        headTable.Columns[i].Caption = "单据状态";
                        break;
                    case "WarehouseStateDesc":
                        headTable.Columns[i].Caption = "单据状态描述";
                        break;
                    case "DepartmentNo":
                        headTable.Columns[i].Caption = "部门编号";
                        break;
                    case "DepartmentName":
                        headTable.Columns[i].Caption = "部门名称";
                        break;
                }

                #endregion
            }
            ds.Tables.Add(headTable);

            DataTable listTable = BaseSQL.GetTableBySql(string.Format("select *, ROW_NUMBER() over (order by AutoId) as RowNum from V_Prn_INV_ReturnedGoodsReportList where ReturnedGoodsReportNo = '{0}' order by AutoId", rgrHeadNoStr));
            listTable.TableName = "ReturnedGoodsReportList";
            for (int i = 0; i < listTable.Columns.Count; i++)
            {
                #region 设定子表显示的标题

                switch (listTable.Columns[i].ColumnName)
                {
                    case "RowNum":
                        listTable.Columns[i].Caption = "行号";
                        break;
                    case "ReturnedGoodsReportNo":
                        listTable.Columns[i].Caption = "退货单号";
                        break;
                    case "CodeNo":
                        listTable.Columns[i].Caption = "物料编号";
                        break;
                    case "CodeFileName":
                        listTable.Columns[i].Caption = "零件编号";
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
                        listTable.Columns[i].Caption = "退货数量";
                        break;
                    case "ProjectNo":
                        listTable.Columns[i].Caption = "项目号";
                        break;
                    case "ProjectName":
                        listTable.Columns[i].Caption = "项目名称";
                        break;
                    case "StnNo":
                        listTable.Columns[i].Caption = "站号";
                        break;
                    case "Remark":
                        listTable.Columns[i].Caption = "备注";
                        break;
                    case "ShelfId":
                        listTable.Columns[i].Caption = "货架ID";
                        break;
                    case "ShelfNo":
                        listTable.Columns[i].Caption = "货架号";
                        break;
                    case "ShelfLocation":
                        listTable.Columns[i].Caption = "货架位置";
                        break;
                }

                #endregion
            }
            ds.Tables.Add(listTable);

            ReportHandler rptHandler = new ReportHandler();
            List<DevExpress.XtraReports.Parameters.Parameter> paralist = rptHandler.GetSystemInfo_ParamList();
            rptHandler.XtraReport_Handle("INV_ReturnedGoodsReportHead", ds, paralist, handleTypeInt);
        }
    }
}
