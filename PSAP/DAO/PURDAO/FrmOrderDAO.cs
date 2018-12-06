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
        public void QueryOrderHead(DataTable queryDataTable, string beginDateStr, string endDateStr, string reqDepStr, string purCategoryStr, string bussinessBaseNoStr, int reqStateInt, string preparedStr, string commonStr, bool nullTable)
        {
            BaseSQL.Query(QueryOrderHead_SQL(beginDateStr, endDateStr, reqDepStr, purCategoryStr, bussinessBaseNoStr, reqStateInt, preparedStr, commonStr, nullTable), queryDataTable);
        }
        /// <summary>
        /// 查询采购单表头表的SQL
        /// </summary>
        public string QueryOrderHead_SQL(string beginDateStr, string endDateStr, string reqDepStr, string purCategoryStr, string bussinessBaseNoStr, int reqStateInt, string preparedStr, string commonStr, bool nullTable)
        {
            string sqlStr = " 1=1";
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
            if(bussinessBaseNoStr!="")
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
                sqlStr += string.Format(" and (OrderHeadNo like '%{0}%' or ProjectNo like '%{0}%' or StnNo like '%{0}%' or PrReqRemark like '%{0}%')", commonStr);
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
        /// 根据采购单号删除采购订单
        /// </summary>
        /// <param name="orderHeadNoStr">采购单号</param>
        public bool DeleteOrder(DataRow orderHeadRow)
        {
            if (!CheckOrderState(orderHeadRow.Table, null, string.Format("'{0}'", DataTypeConvert.GetString(orderHeadRow["OrderHeadNo"])), true, true))
                return false;

            System.Collections.ArrayList sqlList = new System.Collections.ArrayList();
            sqlList.Add(string.Format("Delete from PUR_OrderHead where OrderHeadNo='{0}'", DataTypeConvert.GetString(orderHeadRow["OrderHeadNo"])));
            sqlList.Add(string.Format("Delete from PUR_OrderList where OrderHeadNo='{0}'", DataTypeConvert.GetString(orderHeadRow["OrderHeadNo"])));

            BaseSQL.ExecuteSqlTran(sqlList);
            return true;
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
            if (!CheckOrderState(orderHeadTable, null, orderNoListStr, true, true))
                return false;
            System.Collections.ArrayList sqlList = new System.Collections.ArrayList();
            sqlList.Add(string.Format("Delete from PUR_OrderList where OrderHeadNo in ({0})", orderNoListStr));
            sqlList.Add(string.Format("Delete from PUR_OrderHead where OrderHeadNo in ({0})", orderNoListStr));

            BaseSQL.ExecuteSqlTran(sqlList);
            return true;
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
                            if (!CheckOrderState(orderHeadRow.Table, orderListTable, string.Format("'{0}'", DataTypeConvert.GetString(orderHeadRow["OrderHeadNo"])), true, true))
                                return false;

                            orderHeadRow["Modifier"] = SystemInfo.user.EmpName;
                            orderHeadRow["ModifierIp"] = SystemInfo.HostIpAddress;
                            orderHeadRow["ModifierTime"] = BaseSQL.GetServerDateTime();
                        }

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
                }
            }
        }

        /// <summary>
        /// 审批采购单
        /// </summary>
        /// <param name="orderHeadRow">采购单表头数据行</param>
        public bool ApproveOrder(DataRow orderHeadRow)
        {
            if (!CheckOrderState(orderHeadRow.Table, null, string.Format("'{0}'", DataTypeConvert.GetString(orderHeadRow["OrderHeadNo"])), true, true))
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
            if (!CheckOrderState(orderHeadTable, null, orderHeadNoListStr, true, true))
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
                }
            }
        }

        /// <summary>
        /// 关闭请购单
        /// </summary>
        /// <param name="orderHeadRow">采购请购单表头数据行</param>
        public bool CloseOrder(DataRow orderHeadRow)
        {
            if (!CheckOrderState(orderHeadRow.Table, null, string.Format("'{0}'", DataTypeConvert.GetString(orderHeadRow["OrderHeadNo"])), false, true))
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
            if (!CheckOrderState(orderHeadTable, null, orderHeadNoListStr, false, true))
                return false;

            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);
                        cmd.CommandText = string.Format("Update PUR_OrderHead set ReqState={1}, Approver='{2}', ApproverIp='{3}', ApproverTime='{4}' where OrderHeadNo in ({0})", orderHeadNoListStr, 3, SystemInfo.user.EmpName, SystemInfo.HostIpAddress, serverTime.ToString("yyyy-MM-dd HH:mm:ss"));
                        cmd.ExecuteNonQuery();
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
                }
            }
        }

        /// <summary>
        /// 检测数据库中请购单状态是否可以操作
        /// </summary>
        public bool CheckOrderState(DataTable orderHeadTable, DataTable orderListTable, string orderHeadNoListStr, bool checkApprover, bool checkClosed)
        {
            string sqlStr = string.Format("select OrderHeadNo, ReqState from PUR_OrderHead where OrderHeadNo in ({0})", orderHeadNoListStr);
            DataTable tmpTable = BaseSQL.Query(sqlStr).Tables[0];
            for (int i = 0; i < tmpTable.Rows.Count; i++)
            {
                int reqState = DataTypeConvert.GetInt(tmpTable.Rows[i]["ReqState"]);
                switch (reqState)
                {
                    case 2:
                        if (checkApprover)
                        {
                            MessageHandler.ShowMessageBox("采购单已经审核，不可以操作。");
                            orderHeadTable.RejectChanges();
                            if (orderListTable != null)
                                orderListTable.RejectChanges();
                            return false;
                        }
                        break;
                    case 3:
                        if (checkClosed)
                        {
                            MessageHandler.ShowMessageBox("采购单已经关闭，不可以操作。");
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
    }
}
