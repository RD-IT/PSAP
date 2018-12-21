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
    class FrmOrderDAO
    {
        /// <summary>
        /// 查询往来方信息（增加一个全部选项）
        /// </summary>
        public DataTable QueryBussinessBaseInfo(bool addAllItem)
        {
            string sqlStr = "select Info.AutoId, Info.BussinessBaseNo, Info.BussinessBaseText, Cate.BussinessCategoryText from BS_BussinessBaseInfo as Info left join BS_BussinessCategory as Cate on Info.BussinessCategory=Cate.BussinessCategory where BussinessIsUse=1 Order by AutoId";
            if (addAllItem)
            {
                sqlStr = "select 0 as AutoId, '全部' as BussinessBaseNo, '全部' as BussinessBaseText, '全部' as BussinessCategoryText union " + sqlStr;
            }
            return BaseSQL.GetTableBySql(sqlStr);
        }

        /// <summary>
        /// 查询审批类型信息（增加一个全部选项）
        /// </summary>
        public DataTable QueryApprovalType(bool addAllItem)
        {
            string sqlStr = "select AutoId, TypeNo, TypeNoText, ApprovalCat, ApprovalText from V_PUR_ApprovalType Order by AutoId";
            if (addAllItem)
            {
                sqlStr = "select 0 as AutoId, '全部' as TypeNo, '全部' as TypeNoText, 0 as ApprovalCat, '' as ApprovalText union " + sqlStr;
            }
            return BaseSQL.GetTableBySql(sqlStr);
        }

        /// <summary>
        /// 查询付款类型信息（增加一个全部选项）
        /// </summary>
        public DataTable QueryPayType(bool addAllItem)
        {
            string sqlStr = "select AutoId, PayTypeNo, PayTypeNoText from PUR_PayType Order by AutoId";
            if (addAllItem)
            {
                sqlStr = "select 0 as AutoId, '全部' as PayTypeNo, '全部' as PayTypeNoText union " + sqlStr;
            }
            return BaseSQL.GetTableBySql(sqlStr);
        }

        /// <summary>
        /// 查询采购单表头表
        /// </summary>
        /// <param name="queryDataTable">要查询填充的数据表</param>
        /// <param name="beginDateStr">开始日期字符串</param>
        /// <param name="endDateStr">结束日期字符串</param>
        /// <param name="reqDepStr">部门编号</param>
        /// <param name="purCategoryStr">采购类型</param>
        /// <param name="bussinessBaseNoStr">往来方编号</param>
        /// <param name="reqStateInt">状态</param>
        /// <param name="preparedStr">申请人</param>
        /// <param name="commonStr">通用查询条件</param>
        /// <param name="nullTable">是否查询空表</param>
        public void QueryOrderHead(DataTable queryDataTable, string beginDateStr, string endDateStr, string beginPlanDateStr, string endPlanDateStr, string reqDepStr, string purCategoryStr, string bussinessBaseNoStr, int reqStateInt, string preparedStr, int approverInt, string commonStr, bool nullTable)
        {
            BaseSQL.Query(QueryOrderHead_SQL(beginDateStr, endDateStr, beginPlanDateStr, endPlanDateStr, reqDepStr, purCategoryStr, bussinessBaseNoStr, reqStateInt, preparedStr, approverInt, commonStr, nullTable), queryDataTable);
        }
        /// <summary>
        /// 查询采购单表头表的SQL
        /// </summary>
        public string QueryOrderHead_SQL(string beginDateStr, string endDateStr, string beginPlanDateStr, string endPlanDateStr, string reqDepStr, string purCategoryStr, string bussinessBaseNoStr, int reqStateInt, string preparedStr, int approverInt, string commonStr, bool nullTable)
        {
            string sqlStr = " 1=1";
            if (beginDateStr != "")
            {
                sqlStr += string.Format(" and OrderHeadDate between '{0}' and '{1}'", beginDateStr, endDateStr);
            }
            if (beginPlanDateStr != "")
            {
                sqlStr += string.Format(" and PlanDate between '{0}' and '{1}'", beginPlanDateStr, endPlanDateStr);
            }
            if (reqDepStr != "")
            {
                sqlStr += string.Format(" and ReqDep='{0}'", reqDepStr);
            }
            if (purCategoryStr != "")
            {
                sqlStr += string.Format(" and PurCategory='{0}'", purCategoryStr);
            }
            if (bussinessBaseNoStr != "")
            {
                sqlStr += string.Format(" and BussinessBaseNo='{0}'", bussinessBaseNoStr);
            }
            if (reqStateInt != 0)
            {
                sqlStr += string.Format(" and ReqState={0}", reqStateInt);
            }
            if (preparedStr != "")
            {
                sqlStr += string.Format(" and Prepared='{0}'", preparedStr);
            }
            if (commonStr != "")
            {
                sqlStr += string.Format(" and (OrderHeadNo like '%{0}%' or ProjectNo like '%{0}%' or StnNo like '%{0}%' or PrReqRemark like '%{0}%' or PUR_OrderHead.ApprovalType like '%{0}%' or PayTypeNo like '%{0}%')", commonStr);
            }
            if (approverInt >= 0)
            {
                if (approverInt == 0)
                    sqlStr += string.Format(" and ReqState in (1,4)");
                else
                {
                    sqlStr = string.Format("select PUR_OrderHead.* from PUR_OrderHead left join PUR_ApprovalType on PUR_OrderHead.ApprovalType = PUR_ApprovalType.TypeNo where {0} and PUR_OrderHead.ReqState in (1, 2) and( (PUR_ApprovalType.ApprovalCat = 0 and exists (select * from (select top 1 * from F_OrderNoApprovalList(PUR_OrderHead.OrderHeadNo, PUR_OrderHead.ApprovalType) Order by AppSequence) as minlist where Approver = {1})) or (PUR_ApprovalType.ApprovalCat = 1 and exists (select * from F_OrderNoApprovalList(PUR_OrderHead.OrderHeadNo, PUR_OrderHead.ApprovalType) where Approver = {1}))) order by AutoId", sqlStr, approverInt);
                    return sqlStr;
                }
            }
            if (nullTable)
            {
                sqlStr += " and 1=2";
            }
            sqlStr = string.Format("select * from PUR_OrderHead where {0} order by AutoId", sqlStr);
            return sqlStr;
        }

        /// <summary>
        /// 查询采购单明细表
        /// </summary>
        /// <param name="queryDataTable">要查询填充的数据表</param>
        /// <param name="orderHeadNoStr">采购单号</param>
        public void QueryOrderList(DataTable queryDataTable, string orderHeadNoStr, bool nullTable)
        {
            string sqlStr = string.Format(" and OrderHeadNo='{0}'", orderHeadNoStr);
            if (nullTable)
            {
                sqlStr += " and 1=2";
            }
            sqlStr = string.Format("select PUR_OrderList.*, SW_PartsCode.CodeName from PUR_OrderList left join SW_PartsCode on PUR_OrderList.CodeFileName = SW_PartsCode.CodeFileName where 1=1 {0} order by AutoId", sqlStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 查询采购单明细表关联表头表的SQL
        /// </summary>
        public string QueryOrderList_Head_SQL(string beginPlanDateStr, string endPlanDateStr, string beginDateStr, string endDateStr, string reqDepStr, string purCategoryStr, string bussinessBaseNoStr, int reqStateInt, string projectNoStr, string codeFileNameStr, string commonStr)
        {
            string sqlStr = " 1=1";
            if (beginPlanDateStr != "")
            {
                sqlStr += string.Format(" and PlanDate between '{0}' and '{1}'", beginPlanDateStr, endPlanDateStr);
            }
            if (beginDateStr != "")
            {
                sqlStr += string.Format(" and OrderHeadDate between '{0}' and '{1}'", beginDateStr, endDateStr);
            }
            if (reqDepStr != "")
            {
                sqlStr += string.Format(" and ReqDep='{0}'", reqDepStr);
            }
            if (purCategoryStr != "")
            {
                sqlStr += string.Format(" and PurCategory='{0}'", purCategoryStr);
            }
            if (bussinessBaseNoStr != "")
            {
                sqlStr += string.Format(" and BussinessBaseNo='{0}'", bussinessBaseNoStr);
            }
            if (reqStateInt != 0)
            {
                sqlStr += string.Format(" and ReqState={0}", reqStateInt);
            }
            if (projectNoStr != "")
            {
                sqlStr += string.Format(" and ProjectNo='{0}'", projectNoStr);
            }
            if (codeFileNameStr != "")
            {
                sqlStr += string.Format(" and List.CodeFileName='{0}'", codeFileNameStr);
            }
            if (commonStr != "")
            {
                sqlStr += string.Format(" and (OrderHeadNo like '%{0}%' or Prepared like '%{0}%' or StnNo like '%{0}%' or PrReqRemark like '%{0}%' and Remark like '%{0}%')", commonStr);
            }
            sqlStr = string.Format("select List.*, Parts.CodeName from V_PUR_OrderList_Head as List left join SW_PartsCode as Parts on List.CodeFileName = Parts.CodeFileName where {0} order by AutoId", sqlStr);
            return sqlStr;
        }

        /// <summary>
        /// 根据采购单号删除采购订单
        /// </summary>
        /// <param name="orderHeadNoStr">采购单号</param>
        public bool DeleteOrder(DataRow orderHeadRow)
        {
            if (!CheckOrderState(orderHeadRow.Table, null, string.Format("'{0}'", DataTypeConvert.GetString(orderHeadRow["OrderHeadNo"])), false, true, true, true))
                return false;

            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);
                        cmd.CommandText = string.Format("select * from PUR_OrderList where OrderHeadNo='{0}'", DataTypeConvert.GetString(orderHeadRow["OrderHeadNo"]));
                        DataTable tmpTable = new DataTable();
                        SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                        adpt.Fill(tmpTable);

                        //保存日志到日志表中
                        string logStr = LogHandler.RecordLog_DeleteRow(cmd, "采购订单", orderHeadRow, "OrderHeadNo");

                        cmd.CommandText = string.Format("Delete from PUR_OrderHead where OrderHeadNo='{0}'", DataTypeConvert.GetString(orderHeadRow["OrderHeadNo"]));
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = string.Format("Delete from PUR_OrderList where OrderHeadNo='{0}'", DataTypeConvert.GetString(orderHeadRow["OrderHeadNo"]));
                        cmd.ExecuteNonQuery();

                        Set_PrReqHead_End(cmd, tmpTable);

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
        /// 根据选择删除多条采购单
        /// </summary>
        public bool DeleteOrder_Multi(DataTable orderHeadTable)
        {
            string orderNoListStr = "";
            for (int i = 0; i < orderHeadTable.Rows.Count; i++)
            {
                if (DataTypeConvert.GetBoolean(orderHeadTable.Rows[i]["Select"]))
                {
                    orderNoListStr += string.Format("'{0}',", DataTypeConvert.GetString(orderHeadTable.Rows[i]["OrderHeadNo"]));
                }
            }
            orderNoListStr = orderNoListStr.Substring(0, orderNoListStr.Length - 1);
            if (!CheckOrderState(orderHeadTable, null, orderNoListStr, false, true, true, true))
                return false;
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);
                        cmd.CommandText = string.Format("select * from PUR_OrderList where OrderHeadNo in ({0})", orderNoListStr);
                        DataTable tmpTable = new DataTable();
                        SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                        adpt.Fill(tmpTable);

                        //保存日志到日志表中
                        DataRow[] orderHeadRows = orderHeadTable.Select("select=1");
                        for (int i = 0; i < orderHeadRows.Length; i++)
                        {
                            string logStr = LogHandler.RecordLog_DeleteRow(cmd, "采购订单", orderHeadRows[i], "OrderHeadNo");
                        }

                        cmd.CommandText = string.Format("Delete from PUR_OrderList where OrderHeadNo in ({0})", orderNoListStr);
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = string.Format("Delete from PUR_OrderHead where OrderHeadNo in ({0})", orderNoListStr);
                        cmd.ExecuteNonQuery();

                        Set_PrReqHead_End(cmd, tmpTable);

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
        /// 保存采购单
        /// </summary>
        /// <param name="orderHeadRow">采购单表头数据表</param>
        /// <param name="orderListTable">采购单明细数据表</param>
        public bool SaveOrder(DataRow orderHeadRow, DataTable orderListTable)
        {
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);
                        if (orderHeadRow["OrderHeadNo"].ToString() == "")//新增
                        {
                            string orderHeadNo = BaseSQL.GetMaxCodeNo(cmd, "PO");
                            orderHeadRow["OrderHeadNo"] = orderHeadNo;
                            orderHeadRow["PreparedIp"] = SystemInfo.HostIpAddress;
                            orderHeadRow["OrderHeadDate"] = BaseSQL.GetServerDateTime();

                            for (int i = 0; i < orderListTable.Rows.Count; i++)
                            {
                                orderListTable.Rows[i]["OrderHeadNo"] = orderHeadNo;
                            }
                        }
                        else//修改
                        {
                            if (!CheckOrderState(orderHeadRow.Table, orderListTable, string.Format("'{0}'", DataTypeConvert.GetString(orderHeadRow["OrderHeadNo"])), false, true, true, true))
                                return false;

                            orderHeadRow["Modifier"] = SystemInfo.user.EmpName;
                            orderHeadRow["ModifierIp"] = SystemInfo.HostIpAddress;
                            orderHeadRow["ModifierTime"] = BaseSQL.GetServerDateTime();
                        }

                        //保存日志到日志表中
                        string logStr = LogHandler.RecordLog_DataRow(cmd, "采购订单", orderHeadRow, "OrderHeadNo");

                        cmd.CommandText = "select * from PUR_OrderHead where 1=2";
                        SqlDataAdapter adapterHead = new SqlDataAdapter(cmd);
                        DataTable tmpHeadTable = new DataTable();
                        adapterHead.Fill(tmpHeadTable);
                        BaseSQL.UpdateDataTable(adapterHead, orderHeadRow.Table);

                        cmd.CommandText = "select * from PUR_OrderList where 1=2";
                        SqlDataAdapter adapterList = new SqlDataAdapter(cmd);
                        DataTable tmpListTable = new DataTable();
                        adapterList.Fill(tmpListTable);
                        BaseSQL.UpdateDataTable(adapterList, orderListTable);

                        Set_PrReqHead_End(cmd, orderListTable);

                        trans.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        orderHeadRow.Table.RejectChanges();
                        orderListTable.RejectChanges();
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
        /// 审批采购单
        /// </summary>
        /// <param name="orderHeadRow">采购单表头数据行</param>
        public bool ApproveOrder(DataRow orderHeadRow)
        {
            if (!CheckOrderState(orderHeadRow.Table, null, string.Format("'{0}'", DataTypeConvert.GetString(orderHeadRow["OrderHeadNo"])), false, true, true, false))
                return false;

            DateTime serverTime = BaseSQL.GetServerDateTime();
            orderHeadRow["Approver"] = SystemInfo.user.EmpName;
            orderHeadRow["ApproverIp"] = SystemInfo.HostIpAddress;
            orderHeadRow["ApproverTime"] = serverTime;
            orderHeadRow["ReqState"] = 2;

            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);
                        cmd.CommandText = string.Format("Update PUR_OrderHead set ReqState={1}, Approver='{2}', ApproverIp='{3}', ApproverTime='{4}' where OrderHeadNo='{0}'", DataTypeConvert.GetString(orderHeadRow["OrderHeadNo"]), 2, SystemInfo.user.EmpName, SystemInfo.HostIpAddress, serverTime.ToString("yyyy-MM-dd HH:mm:ss"));
                        cmd.ExecuteNonQuery();

                        //保存日志到日志表中
                        string logStr = LogHandler.RecordLog_OperateRow(cmd, "采购订单", orderHeadRow, "OrderHeadNo", "审批", SystemInfo.user.EmpName, serverTime.ToString("yyyy-MM-dd HH:mm:ss"));

                        trans.Commit();
                        orderHeadRow.AcceptChanges();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        orderHeadRow.Table.RejectChanges();
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
        /// 审批选中的多条请购单
        /// </summary>
        public bool ApproveOrder_Multi(DataTable orderHeadTable)
        {
            string orderHeadNoListStr = "";
            DateTime serverTime = BaseSQL.GetServerDateTime();
            for (int i = 0; i < orderHeadTable.Rows.Count; i++)
            {
                if (DataTypeConvert.GetBoolean(orderHeadTable.Rows[i]["Select"]))
                {
                    orderHeadNoListStr += string.Format("'{0}',", DataTypeConvert.GetString(orderHeadTable.Rows[i]["OrderHeadNo"]));
                    orderHeadTable.Rows[i]["Approver"] = SystemInfo.user.EmpName;
                    orderHeadTable.Rows[i]["ApproverIp"] = SystemInfo.HostIpAddress;
                    orderHeadTable.Rows[i]["ApproverTime"] = serverTime;
                    orderHeadTable.Rows[i]["ReqState"] = 2;
                }
            }

            orderHeadNoListStr = orderHeadNoListStr.Substring(0, orderHeadNoListStr.Length - 1);
            if (!CheckOrderState(orderHeadTable, null, orderHeadNoListStr, false, true, true, false))
                return false;

            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);
                        cmd.CommandText = string.Format("Update PUR_OrderHead set ReqState={1}, Approver='{2}', ApproverIp='{3}', ApproverTime='{4}' where OrderHeadNo in ({0})", orderHeadNoListStr, 2, SystemInfo.user.EmpName, SystemInfo.HostIpAddress, serverTime.ToString("yyyy-MM-dd HH:mm:ss"));
                        cmd.ExecuteNonQuery();

                        //保存日志到日志表中
                        DataRow[] orderHeadRows = orderHeadTable.Select("select=1");
                        for (int i = 0; i < orderHeadRows.Length; i++)
                        {
                            string logStr = LogHandler.RecordLog_OperateRow(cmd, "采购订单", orderHeadRows[i], "OrderHeadNo", "审批", SystemInfo.user.EmpName, serverTime.ToString("yyyy-MM-dd HH:mm:ss"));
                        }

                        trans.Commit();
                        orderHeadTable.AcceptChanges();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        orderHeadTable.RejectChanges();
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
        /// 取消审批采购单
        /// </summary>
        /// <param name="orderHeadRow">采购单表头数据行</param>
        public bool CancelApproveOrder(DataRow orderHeadRow)
        {
            if (!CheckOrderState(orderHeadRow.Table, null, string.Format("'{0}'", DataTypeConvert.GetString(orderHeadRow["OrderHeadNo"])), true, false, true, false))
                return false;

            orderHeadRow["Approver"] = "";
            orderHeadRow["ApproverIp"] = "";
            orderHeadRow["ApproverTime"] = "";
            orderHeadRow["ReqState"] = 1;

            //检查是否有下级的入库订单

            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);
                        cmd.CommandText = string.Format("Update PUR_OrderHead set ReqState={1}, Approver='{2}', ApproverIp='{3}', ApproverTime='{4}' where OrderHeadNo='{0}'", DataTypeConvert.GetString(orderHeadRow["OrderHeadNo"]), 1, "", "", "");
                        cmd.ExecuteNonQuery();

                        //保存日志到日志表中
                        string logStr = LogHandler.RecordLog_OperateRow(cmd, "采购订单", orderHeadRow, "OrderHeadNo", "取消审批", SystemInfo.user.EmpName, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                        trans.Commit();
                        orderHeadRow.AcceptChanges();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        orderHeadRow.Table.RejectChanges();
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
        /// 取消审批选中的多条请购单
        /// </summary>
        public bool CancelApproveOrder_Multi(DataTable orderHeadTable)
        {
            string orderHeadNoListStr = "";
            for (int i = 0; i < orderHeadTable.Rows.Count; i++)
            {
                if (DataTypeConvert.GetBoolean(orderHeadTable.Rows[i]["Select"]))
                {
                    orderHeadNoListStr += string.Format("'{0}',", DataTypeConvert.GetString(orderHeadTable.Rows[i]["OrderHeadNo"]));
                    orderHeadTable.Rows[i]["Approver"] = "";
                    orderHeadTable.Rows[i]["ApproverIp"] = "";
                    orderHeadTable.Rows[i]["ApproverTime"] = DBNull.Value;
                    orderHeadTable.Rows[i]["ReqState"] = 1;
                }
            }

            orderHeadNoListStr = orderHeadNoListStr.Substring(0, orderHeadNoListStr.Length - 1);
            if (!CheckOrderState(orderHeadTable, null, orderHeadNoListStr, true, false, true, false))
                return false;

            //检查是否有下级的入库订单

            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);
                        cmd.CommandText = string.Format("Update PUR_OrderHead set ReqState={1}, Approver='{2}', ApproverIp='{3}', ApproverTime=null where OrderHeadNo in ({0})", orderHeadNoListStr, 1, "", "");
                        cmd.ExecuteNonQuery();

                        //保存日志到日志表中
                        DataRow[] orderHeadRows = orderHeadTable.Select("select=1");
                        for (int i = 0; i < orderHeadRows.Length; i++)
                        {
                            string logStr = LogHandler.RecordLog_OperateRow(cmd, "采购订单", orderHeadRows[i], "OrderHeadNo", "取消审批", SystemInfo.user.EmpName, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        }

                        trans.Commit();
                        orderHeadTable.AcceptChanges();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        orderHeadTable.RejectChanges();
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
        /// 关闭请购单
        /// </summary>
        /// <param name="orderHeadRow">采购请购单表头数据行</param>
        public bool CloseOrder(DataRow orderHeadRow)
        {
            if (!CheckOrderState(orderHeadRow.Table, null, string.Format("'{0}'", DataTypeConvert.GetString(orderHeadRow["OrderHeadNo"])), false, false, true, false))
                return false;

            DateTime serverTime = BaseSQL.GetServerDateTime();
            orderHeadRow["Closed"] = SystemInfo.user.EmpName;
            orderHeadRow["ClosedIp"] = SystemInfo.HostIpAddress;
            orderHeadRow["ClosedTime"] = serverTime;
            orderHeadRow["ReqState"] = 3;

            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);
                        cmd.CommandText = string.Format("Update PUR_OrderHead set ReqState={1}, Closed='{2}', ClosedIp='{3}', ClosedTime='{4}' where OrderHeadNo='{0}'", DataTypeConvert.GetString(orderHeadRow["OrderHeadNo"]), 3, SystemInfo.user.EmpName, SystemInfo.HostIpAddress, serverTime.ToString("yyyy-MM-dd HH:mm:ss"));
                        cmd.ExecuteNonQuery();

                        //保存日志到日志表中
                        string logStr = LogHandler.RecordLog_OperateRow(cmd, "采购订单", orderHeadRow, "OrderHeadNo", "关闭", SystemInfo.user.EmpName, serverTime.ToString("yyyy-MM-dd HH:mm:ss"));

                        trans.Commit();
                        orderHeadRow.AcceptChanges();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        orderHeadRow.Table.RejectChanges();
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
        /// 关闭选中的多条请购单
        /// </summary>
        public bool CloseOrder_Multi(DataTable orderHeadTable)
        {
            string orderHeadNoListStr = "";
            DateTime serverTime = BaseSQL.GetServerDateTime();
            for (int i = 0; i < orderHeadTable.Rows.Count; i++)
            {
                if (DataTypeConvert.GetBoolean(orderHeadTable.Rows[i]["Select"]))
                {
                    orderHeadNoListStr += string.Format("'{0}',", DataTypeConvert.GetString(orderHeadTable.Rows[i]["OrderHeadNo"]));
                    orderHeadTable.Rows[i]["Closed"] = SystemInfo.user.EmpName;
                    orderHeadTable.Rows[i]["ClosedIp"] = SystemInfo.HostIpAddress;
                    orderHeadTable.Rows[i]["ClosedTime"] = serverTime;
                    orderHeadTable.Rows[i]["ReqState"] = 3;
                }
            }

            orderHeadNoListStr = orderHeadNoListStr.Substring(0, orderHeadNoListStr.Length - 1);
            if (!CheckOrderState(orderHeadTable, null, orderHeadNoListStr, false, false, true, false))
                return false;

            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);
                        cmd.CommandText = string.Format("Update PUR_OrderHead set ReqState={1}, Closed='{2}', ClosedIp='{3}', ClosedTime='{4}' where OrderHeadNo in ({0})", orderHeadNoListStr, 3, SystemInfo.user.EmpName, SystemInfo.HostIpAddress, serverTime.ToString("yyyy-MM-dd HH:mm:ss"));
                        cmd.ExecuteNonQuery();

                        //保存日志到日志表中
                        DataRow[] orderHeadRows = orderHeadTable.Select("select=1");
                        for (int i = 0; i < orderHeadRows.Length; i++)
                        {
                            string logStr = LogHandler.RecordLog_OperateRow(cmd, "采购订单", orderHeadRows[i], "OrderHeadNo", "关闭", SystemInfo.user.EmpName, serverTime.ToString("yyyy-MM-dd HH:mm:ss"));
                        }

                        trans.Commit();
                        orderHeadTable.AcceptChanges();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        orderHeadTable.RejectChanges();
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
        /// 取消关闭选中的多条请购单
        /// </summary>
        public bool CancelCloseOrder_Multi(DataTable orderHeadTable)
        {
            string orderHeadNoListStr = "";
            DateTime serverTime = BaseSQL.GetServerDateTime();
            for (int i = 0; i < orderHeadTable.Rows.Count; i++)
            {
                if (DataTypeConvert.GetBoolean(orderHeadTable.Rows[i]["Select"]))
                {
                    orderHeadNoListStr += string.Format("'{0}',", DataTypeConvert.GetString(orderHeadTable.Rows[i]["OrderHeadNo"]));
                    orderHeadTable.Rows[i]["Closed"] = "";
                    orderHeadTable.Rows[i]["ClosedIp"] = "";
                    orderHeadTable.Rows[i]["ClosedTime"] = DBNull.Value;
                }
            }

            orderHeadNoListStr = orderHeadNoListStr.Substring(0, orderHeadNoListStr.Length - 1);
            if (!CheckOrderState(orderHeadTable, null, orderHeadNoListStr, true, true, false, true))
                return false;

            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);
                        for (int i = 0; i < orderHeadTable.Rows.Count; i++)
                        {
                            if (DataTypeConvert.GetBoolean(orderHeadTable.Rows[i]["Select"]))
                            {
                                DataRow dr = orderHeadTable.Rows[i];
                                string orderHeadNoStr = DataTypeConvert.GetString(dr["OrderHeadNo"]);
                                string approvalTypeStr = DataTypeConvert.GetString(dr["ApprovalType"]);
                                cmd.CommandText = string.Format("select ApprovalCat from PUR_ApprovalType where TypeNo='{0}'", approvalTypeStr);
                                int approvalCatInt = DataTypeConvert.GetInt(cmd.ExecuteScalar());
                                cmd.CommandText = string.Format("select Count(*) from F_OrderNoApprovalList('{0}','{1}')", orderHeadNoStr, approvalTypeStr);
                                int noAppListCount = DataTypeConvert.GetInt(cmd.ExecuteScalar());
                                cmd.CommandText = string.Format("select Count(*) from PUR_ApprovalList where TypeNo='{0}'", approvalTypeStr);
                                int appListCount = DataTypeConvert.GetInt(cmd.ExecuteScalar());
                                switch(approvalCatInt)
                                {
                                    case 0:
                                    case 1:
                                        if (noAppListCount == 0)
                                            dr["ReqState"] = 2;
                                        else if (noAppListCount == appListCount)
                                            dr["ReqState"] = 1;
                                        else
                                            dr["ReqState"] = 4;
                                        break;
                                    case 2:
                                        if (noAppListCount < appListCount)
                                            dr["ReqState"] = 2;
                                        else
                                            dr["ReqState"] = 1;
                                        break;
                                }                               

                                cmd.CommandText = string.Format("Update PUR_OrderHead set ReqState={1}, Closed='{2}', ClosedIp='{3}', ClosedTime=null where OrderHeadNo = '{0}'", DataTypeConvert.GetString(dr["OrderHeadNo"]), DataTypeConvert.GetInt(dr["ReqState"]), "", "");
                                cmd.ExecuteNonQuery();

                                //保存日志到日志表中
                                string logStr = LogHandler.RecordLog_OperateRow(cmd, "采购订单", orderHeadTable.Rows[i], "OrderHeadNo", "取消关闭", SystemInfo.user.EmpName, serverTime.ToString("yyyy-MM-dd HH:mm:ss"));
                            }
                        }

                        trans.Commit();
                        orderHeadTable.AcceptChanges();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        orderHeadTable.RejectChanges();
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
        /// 检测数据库中请购单状态是否可以操作
        /// </summary>
        public bool CheckOrderState(DataTable orderHeadTable, DataTable orderListTable, string orderHeadNoListStr, bool checkNoApprover, bool checkApprover, bool checkClosed, bool checkApproverBetween)
        {
            string sqlStr = string.Format("select OrderHeadNo, ReqState from PUR_OrderHead where OrderHeadNo in ({0})", orderHeadNoListStr);
            DataTable tmpTable = BaseSQL.Query(sqlStr).Tables[0];
            for (int i = 0; i < tmpTable.Rows.Count; i++)
            {
                int reqState = DataTypeConvert.GetInt(tmpTable.Rows[i]["ReqState"]);
                switch (reqState)
                {
                    case 1:
                        if (checkNoApprover)
                        {
                            MessageHandler.ShowMessageBox(string.Format("采购订单[{0}]未审批，不可以操作。", DataTypeConvert.GetString(tmpTable.Rows[i]["OrderHeadNo"])));
                            orderHeadTable.RejectChanges();
                            if (orderListTable != null)
                                orderListTable.RejectChanges();
                            return false;
                        }
                        break;
                    case 2:
                        if (checkApprover)
                        {
                            MessageHandler.ShowMessageBox(string.Format("采购订单[{0}]已经审批，不可以操作。", DataTypeConvert.GetString(tmpTable.Rows[i]["OrderHeadNo"])));
                            orderHeadTable.RejectChanges();
                            if (orderListTable != null)
                                orderListTable.RejectChanges();
                            return false;
                        }
                        break;
                    case 3:
                        if (checkClosed)
                        {
                            MessageHandler.ShowMessageBox(string.Format("采购订单[{0}]已经关闭，不可以操作。", DataTypeConvert.GetString(tmpTable.Rows[i]["OrderHeadNo"])));
                            orderHeadTable.RejectChanges();
                            if (orderListTable != null)
                                orderListTable.RejectChanges();
                            return false;
                        }
                        break;
                    case 4:
                        if (checkApproverBetween)
                        {
                            MessageHandler.ShowMessageBox(string.Format("采购订单[{0}]已经审批中，不可以操作。", DataTypeConvert.GetString(tmpTable.Rows[i]["OrderHeadNo"])));
                            orderHeadTable.RejectChanges();
                            if (orderListTable != null)
                                orderListTable.RejectChanges();
                            return false;
                        }
                        break;
                }
            }

            return true;
        }

        ///// <summary>
        ///// 根据项目号得到往来方编号
        ///// </summary>
        ///// <param name="projectNoStr">项目号</param>
        //public string GetBussinessBaseNo_ProjectNo(string projectNoStr)
        //{
        //    string sqlStr = string.Format("select BussinessBaseNo from BS_ProjectList where ProjectNo='{0}'", projectNoStr);
        //    return DataTypeConvert.GetString(BaseSQL.GetSingle(sqlStr));
        //}

        /// <summary>
        /// 设定请购单完结标志
        /// </summary>
        public void Set_PrReqHead_End(SqlCommand cmd, DataTable prReqListTable)
        {
            string prReqNoStr = "";
            IEnumerable<IGrouping<string, DataRow>> result = prReqListTable.Rows.Cast<DataRow>().GroupBy<DataRow, string>(dr => dr["PrReqNo"].ToString());//按PrReqNo分组
            foreach (IGrouping<string, DataRow> ig in result)
            {
                if (ig.Key != "")
                {
                    prReqNoStr = ig.Key;
                    cmd.CommandText = string.Format("select Count(*) from V_PUR_PrReqList_Order where PrReqNo = '{0}' and Qty>OrderCount", prReqNoStr);
                    int count = DataTypeConvert.GetInt(cmd.ExecuteScalar());
                    int isEnd = 0;
                    if (count == 0)
                        isEnd = 1;
                    cmd.CommandText = string.Format("Update PUR_PrReqHead set IsEnd={1} where PrReqNo='{0}'", prReqNoStr, isEnd);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// 审批选中的多条请购单
        /// </summary>
        public bool OrderApprovalInfo_Multi(DataTable orderHeadTable,ref int successCountInt)
        {
            string orderHeadNoListStr = "";
            for (int i = 0; i < orderHeadTable.Rows.Count; i++)
            {
                if (DataTypeConvert.GetBoolean(orderHeadTable.Rows[i]["Select"]))
                {
                    orderHeadNoListStr += string.Format("'{0}',", DataTypeConvert.GetString(orderHeadTable.Rows[i]["OrderHeadNo"]));
                }
            }

            orderHeadNoListStr = orderHeadNoListStr.Substring(0, orderHeadNoListStr.Length - 1);
            if (!CheckOrderState(orderHeadTable, null, orderHeadNoListStr, false, true, true, false))
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
                        for (int i = 0; i < orderHeadTable.Rows.Count; i++)
                        {
                            if (DataTypeConvert.GetBoolean(orderHeadTable.Rows[i]["Select"]))
                            {
                                DataRow orderRow = orderHeadTable.Rows[i];
                                string orderHeadNoStr = DataTypeConvert.GetString(orderRow["OrderHeadNo"]);

                                cmd.CommandText = string.Format("select PUR_OrderHead.OrderHeadNo, PUR_OrderHead.ApprovalType, PUR_ApprovalType.ApprovalCat from PUR_OrderHead left join PUR_ApprovalType on PUR_OrderHead.ApprovalType = PUR_ApprovalType.TypeNo where OrderHeadNo='{0}'", orderHeadNoStr);
                                DataTable tmpTable = new DataTable();
                                SqlDataAdapter orderadpt = new SqlDataAdapter(cmd);
                                orderadpt.Fill(tmpTable);
                                if (tmpTable.Rows.Count == 0)
                                {
                                    trans.Rollback();
                                    MessageHandler.ShowMessageBox("未查询到要操作的采购订单，请刷新后再进行操作。");
                                    return false;
                                }
                                string approvalTypeStr = DataTypeConvert.GetString(tmpTable.Rows[0]["ApprovalType"]);
                                cmd.CommandText = string.Format("select * from F_OrderNoApprovalList('{0}','{1}') Order by AppSequence", orderHeadNoStr, approvalTypeStr);
                                DataTable listTable = new DataTable();
                                SqlDataAdapter listadpt = new SqlDataAdapter(cmd);
                                listadpt.Fill(listTable);
                                if (listTable.Rows.Count == 0)
                                {
                                    cmd.CommandText = string.Format("Update PUR_OrderHead set ReqState=2 where OrderHeadNo='{0}'", orderHeadNoStr);
                                    cmd.ExecuteNonQuery();
                                    orderHeadTable.Rows[i]["ReqState"] = 2;
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

                                cmd.CommandText = string.Format("Insert into PUR_OrderApprovalInfo(OrderHeadNo, Approver, ApproverTime) values ('{0}', {1}, '{2}')", orderHeadNoStr, SystemInfo.user.AutoId, serverTime.ToString("yyyy-MM-dd HH:mm:ss"));
                                cmd.ExecuteNonQuery();

                                if (listTable.Rows.Count == 1 || approvalCatInt == 2)
                                {
                                    cmd.CommandText = string.Format("Update PUR_OrderHead set ReqState=2 where OrderHeadNo='{0}'", orderHeadNoStr);
                                    cmd.ExecuteNonQuery();
                                    orderHeadTable.Rows[i]["ReqState"] = 2;
                                }
                                else
                                {
                                    cmd.CommandText = string.Format("Update PUR_OrderHead set ReqState=4 where OrderHeadNo='{0}'", orderHeadNoStr);
                                    cmd.ExecuteNonQuery();
                                    orderHeadTable.Rows[i]["ReqState"] = 4;
                                }

                                //保存日志到日志表中
                                string logStr = LogHandler.RecordLog_OperateRow(cmd, "采购订单", orderHeadTable.Rows[i], "OrderHeadNo", "审批", SystemInfo.user.EmpName, serverTime.ToString("yyyy-MM-dd HH:mm:ss"));
                                successCountInt++;
                            }
                        }

                        trans.Commit();
                        orderHeadTable.AcceptChanges();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        orderHeadTable.RejectChanges();
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
        /// 取消审批选中的多条请购单
        /// </summary>
        public bool CancalOrderApprovalInfo_Multi(DataTable orderHeadTable)
        {
            string orderHeadNoListStr = "";
            for (int i = 0; i < orderHeadTable.Rows.Count; i++)
            {
                if (DataTypeConvert.GetBoolean(orderHeadTable.Rows[i]["Select"]))
                {
                    orderHeadNoListStr += string.Format("'{0}',", DataTypeConvert.GetString(orderHeadTable.Rows[i]["OrderHeadNo"]));
                    orderHeadTable.Rows[i]["ReqState"] = 1;
                }
            }

            orderHeadNoListStr = orderHeadNoListStr.Substring(0, orderHeadNoListStr.Length - 1);
            if (!CheckOrderState(orderHeadTable, null, orderHeadNoListStr, true, false, true, false))
                return false;

            //检查是否有下级的入库订单

            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);
                        cmd.CommandText = string.Format("Delete from PUR_OrderApprovalInfo where OrderHeadNo in ({0})", orderHeadNoListStr);
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = string.Format("Update PUR_OrderHead set ReqState=1 where OrderHeadNo in ({0})", orderHeadNoListStr);
                        cmd.ExecuteNonQuery();

                        //保存日志到日志表中
                        DataRow[] orderHeadRows = orderHeadTable.Select("select=1");
                        for (int i = 0; i < orderHeadRows.Length; i++)
                        {
                            string logStr = LogHandler.RecordLog_OperateRow(cmd, "采购订单", orderHeadRows[i], "OrderHeadNo", "取消审批", SystemInfo.user.EmpName, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        }

                        trans.Commit();
                        orderHeadTable.AcceptChanges();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        orderHeadTable.RejectChanges();
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
