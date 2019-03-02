using PSAP.DAO.BSDAO;
using PSAP.PSAPCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSAP.DAO.INVDAO
{
    class FrmWarehouseReceiptDAO
    {
        static PSAP.VIEW.BSVIEW.FrmWarehouseReceipt_Drag f = new VIEW.BSVIEW.FrmWarehouseReceipt_Drag();
        public FrmWarehouseReceiptDAO()
        {
            PSAP.BLL.BSBLL.BSBLL.language(f);
        }

        /// <summary>
        /// 查询出库类别（增加一个全部选项）
        /// </summary>
        public DataTable QueryWarehouseReceiptType(bool addAllItem)
        {
            string sqlStr = "select AutoId, WarehouseReceiptTypeNo, WarehouseReceiptTypeName, IsDefault from BS_WarehouseReceiptType Order by AutoId";
            if (addAllItem)
            {
                //sqlStr = "select 0 as AutoId, '全部' as WarehouseReceiptTypeNo, '全部' as WarehouseReceiptTypeName, 0 as IsDefault union " + sqlStr;
                sqlStr = "select 0 as AutoId, '" + f.tsmiQb.Text + "' as WarehouseReceiptTypeNo, '" + f.tsmiQb.Text + "' as WarehouseReceiptTypeName, 0 as IsDefault union " + sqlStr;

            }
            return BaseSQL.GetTableBySql(sqlStr);
        }

        /// <summary>
        /// 查询制造工程信息（增加一个全部选项）
        /// </summary>
        public DataTable QueryManufactureInfo(bool addAllItem)
        {
            string sqlStr = "select AutoId, ManufactureNo, ManufactureName, ManufactureType, ManufactureTypeText from V_BS_ManufactureInfo Order by AutoId";
            if (addAllItem)
            {
                //sqlStr = "select 0 as AutoId, '全部' as ManufactureNo, '全部' as ManufactureName, 1 as ManufactureType, '正常' as ManufactureTypeText union " + sqlStr;
                sqlStr = "select 0 as AutoId, '" + f.tsmiQb.Text + "' as ManufactureNo, '" + f.tsmiQb.Text + "' as ManufactureName, 1 as ManufactureType, '" + f.tsmiZc.Text + "' as ManufactureTypeText union " + sqlStr;

            }
            return BaseSQL.GetTableBySql(sqlStr);
        }

        /// <summary>
        /// 查询出库单表头
        /// </summary>
        /// <param name="queryDataTable">要查询填充的数据表</param>
        /// <param name="beginDateStr">开始日期字符串</param>
        /// <param name="endDateStr">结束日期字符串</param>
        /// <param name="repertoryNoStr">入库仓库编号</param>
        /// <param name="wrTypeNoStr">出库类别编号</param>
        /// <param name="preparedStr">制单人</param>
        /// <param name="commonStr">通用查询条件</param>
        /// <param name="nullTable">是否查询空表</param>
        public void QueryWarehouseReceiptHead(DataTable queryDataTable, string beginDateStr, string endDateStr, string reqDepStr, string repertoryNoStr, string wrTypeNoStr, string manufactureNoStr, int warehouseStateInt, string preparedStr, int approverInt, string commonStr, bool nullTable)
        {
            BaseSQL.Query(QueryWarehouseReceiptHead_SQL(beginDateStr, endDateStr, reqDepStr, repertoryNoStr, wrTypeNoStr, manufactureNoStr, warehouseStateInt, preparedStr, approverInt, commonStr, nullTable), queryDataTable);
        }

        /// <summary>
        /// 查询出库单表头的SQL
        /// </summary>
        public string QueryWarehouseReceiptHead_SQL(string beginDateStr, string endDateStr, string reqDepStr, string repertoryNoStr, string wrTypeNoStr, string manufactureNoStr, int warehouseStateInt, string preparedStr, int approverInt, string commonStr, bool nullTable)
        {
            string sqlStr = " 1=1";
            if (beginDateStr != "")
            {
                sqlStr += string.Format(" and WarehouseReceiptDate between '{0}' and '{1}'", beginDateStr, endDateStr);
            }
            if (reqDepStr != "")
            {
                sqlStr += string.Format(" and ReqDep='{0}'", reqDepStr);
            }
            if (repertoryNoStr != "")
            {
                sqlStr += string.Format(" and RepertoryNo='{0}'", repertoryNoStr);
            }
            if (wrTypeNoStr != "")
            {
                sqlStr += string.Format(" and WarehouseReceiptTypeNo='{0}'", wrTypeNoStr);
            }
            if (manufactureNoStr != "")
            {
                sqlStr += string.Format(" and ManufactureNo='{0}'", manufactureNoStr);
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
                sqlStr += string.Format(" and (WarehouseReceipt like '%{0}%' or Remark like '%{0}%')", commonStr);
            }
            if (approverInt >= 0)
            {
                if (approverInt == 0)
                    sqlStr += string.Format(" and WarehouseState in (1,4)");
                else
                {
                    sqlStr = string.Format("select INV_WarehouseReceiptHead.* from INV_WarehouseReceiptHead left join PUR_ApprovalType on INV_WarehouseReceiptHead.ApprovalType = PUR_ApprovalType.TypeNo where {0} and INV_WarehouseReceiptHead.WarehouseState in (1, 4) and( (PUR_ApprovalType.ApprovalCat = 0 and exists (select * from (select top 1 * from F_WarehouseReceiptNoApprovalList(INV_WarehouseReceiptHead.WarehouseReceipt, INV_WarehouseReceiptHead.ApprovalType) Order by AppSequence) as minlist where Approver = {1})) or (PUR_ApprovalType.ApprovalCat = 1 and exists (select * from F_WarehouseReceiptNoApprovalList(INV_WarehouseReceiptHead.WarehouseReceipt, INV_WarehouseReceiptHead.ApprovalType) where Approver = {1}))) order by AutoId", sqlStr, approverInt);
                    return sqlStr;
                }
            }
            if (nullTable)
            {
                sqlStr += " and 1=2";
            }
            sqlStr = string.Format("select * from INV_WarehouseReceiptHead where {0} order by AutoId", sqlStr);
            return sqlStr;
        }


        /// <summary>
        /// 查询出库单明细表
        /// </summary>
        /// <param name="queryDataTable">要查询填充的数据表</param>
        /// <param name="warehouseReceiptStr">出库单号</param>
        public void QueryWarehouseReceiptList(DataTable queryDataTable, string warehouseReceiptStr, bool nullTable)
        {
            string sqlStr = string.Format(" and WarehouseReceipt='{0}'", warehouseReceiptStr);
            if (nullTable)
            {
                sqlStr += " and 1=2";
            }
            sqlStr = string.Format("select INV_WarehouseReceiptList.*, SW_PartsCode.CodeName, BS_ProjectList.ProjectNo from INV_WarehouseReceiptList left join SW_PartsCode on INV_WarehouseReceiptList.CodeFileName = SW_PartsCode.CodeFileName left join BS_ProjectList on INV_WarehouseReceiptList.ProjectName = BS_ProjectList.ProjectName where 1=1 {0} order by AutoId", sqlStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 保存出库单
        /// </summary>
        /// <param name="wrHeadRow">出库单表头数据表</param>
        /// <param name="wrListTable">出库单明细数据表</param>
        public int SaveWarehouseReceipt(DataRow wrHeadRow, DataTable wrListTable)
        {
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);

                        //if (!CheckOrderApplyBeyondCount(cmd, wrHeadRow["WarehouseReceipt"].ToString(), wrListTable))
                        //{
                        //    return 0;
                        //}

                        if (wrHeadRow["WarehouseReceipt"].ToString() == "")//新增
                        {
                            string wrNo = BaseSQL.GetMaxCodeNo(cmd, "WR");
                            wrHeadRow["WarehouseReceipt"] = wrNo;
                            wrHeadRow["PreparedIp"] = SystemInfo.HostIpAddress;

                            for (int i = 0; i < wrListTable.Rows.Count; i++)
                            {
                                wrListTable.Rows[i]["WarehouseReceipt"] = wrNo;
                            }
                        }
                        else//修改
                        {
                            if (!CheckWarehouseState(wrHeadRow.Table, wrListTable, string.Format("'{0}'", DataTypeConvert.GetString(wrHeadRow["WarehouseReceipt"])), false, true, true, true))
                                return -1;

                            wrHeadRow["Modifier"] = SystemInfo.user.EmpName;
                            wrHeadRow["ModifierIp"] = SystemInfo.HostIpAddress;
                            wrHeadRow["ModifierTime"] = BaseSQL.GetServerDateTime();
                        }

                        //保存日志到日志表中
                        string logStr = LogHandler.RecordLog_DataRow(cmd, "出库单", wrHeadRow, "WarehouseReceipt");

                        cmd.CommandText = "select * from INV_WarehouseReceiptHead where 1=2";
                        SqlDataAdapter adapterHead = new SqlDataAdapter(cmd);
                        DataTable tmpHeadTable = new DataTable();
                        adapterHead.Fill(tmpHeadTable);
                        BaseSQL.UpdateDataTable(adapterHead, wrHeadRow.Table);

                        cmd.CommandText = "select * from INV_WarehouseReceiptList where 1=2";
                        SqlDataAdapter adapterList = new SqlDataAdapter(cmd);
                        DataTable tmpListTable = new DataTable();
                        adapterList.Fill(tmpListTable);
                        BaseSQL.UpdateDataTable(adapterList, wrListTable);

                        //Set_PrReqHead_End(cmd, wwListTable);

                        trans.Commit();

                        return 1;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        wrHeadRow.Table.RejectChanges();
                        wrListTable.RejectChanges();
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
        /// 检测数据库中出库单状态是否可以操作
        /// </summary>
        public bool CheckWarehouseState(DataTable wrHeadTable, DataTable wrListTable, string warehouseReceiptListStr, bool checkNoApprover, bool checkApprover, bool checkSettle, bool checkApproverBetween)
        {
            string sqlStr = string.Format("select WarehouseReceipt, WarehouseState from INV_WarehouseReceiptHead where WarehouseReceipt in ({0})", warehouseReceiptListStr);
            DataTable tmpTable = BaseSQL.Query(sqlStr).Tables[0];
            for (int i = 0; i < tmpTable.Rows.Count; i++)
            {
                int wState = DataTypeConvert.GetInt(tmpTable.Rows[i]["WarehouseState"]);
                switch (wState)
                {
                    case 1:
                        if (checkNoApprover)
                        {
                            //MessageHandler.ShowMessageBox(string.Format("出库单[{0}]未审批，不可以操作。", DataTypeConvert.GetString(tmpTable.Rows[i]["WarehouseReceipt"])));
                            MessageHandler.ShowMessageBox(string.Format(f.tsmiCkd.Text + "[{0}]" + f.tsmiWsp.Text + "，" + f.tsmiBkycz.Text, DataTypeConvert.GetString(tmpTable.Rows[i]["WarehouseReceipt"])));
                            wrHeadTable.RejectChanges();
                            if (wrListTable != null)
                                wrListTable.RejectChanges();
                            return false;
                        }
                        break;
                    case 2:
                        if (checkApprover)
                        {
                            //MessageHandler.ShowMessageBox(string.Format("出库单[{0}]已经审批，不可以操作。", DataTypeConvert.GetString(tmpTable.Rows[i]["WarehouseReceipt"])));
                            MessageHandler.ShowMessageBox(string.Format(f.tsmiCkd.Text + "[{0}]" + f.tsmiYjsp.Text + "，" + f.tsmiBkycz.Text, DataTypeConvert.GetString(tmpTable.Rows[i]["WarehouseReceipt"])));
                            wrHeadTable.RejectChanges();
                            if (wrListTable != null)
                                wrListTable.RejectChanges();
                            return false;
                        }
                        break;
                    case 3:
                        if (checkSettle)
                        {
                            //MessageHandler.ShowMessageBox(string.Format("出库单[{0}]已经结账，不可以操作。", DataTypeConvert.GetString(tmpTable.Rows[i]["WarehouseReceipt"])));
                            MessageHandler.ShowMessageBox(string.Format(f.tsmiCkd.Text + "[{0}]" + f.tsmiYjjz.Text + "," + f.tsmiBkycz.Text, DataTypeConvert.GetString(tmpTable.Rows[i]["WarehouseReceipt"])));
                            wrHeadTable.RejectChanges();
                            if (wrListTable != null)
                                wrListTable.RejectChanges();
                            return false;
                        }
                        break;
                    case 4:
                        if (checkApproverBetween)
                        {
                            //MessageHandler.ShowMessageBox(string.Format("出库单[{0}]已经审批中，不可以操作。", DataTypeConvert.GetString(tmpTable.Rows[i]["WarehouseReceipt"])));
                            MessageHandler.ShowMessageBox(string.Format(f.tsmiCkd.Text + "[{0}]" + f.tsmiYjspz.Text + "，" + f.tsmiBkycz.Text, DataTypeConvert.GetString(tmpTable.Rows[i]["WarehouseReceipt"])));
                            wrHeadTable.RejectChanges();
                            if (wrListTable != null)
                                wrListTable.RejectChanges();
                            return false;
                        }
                        break;
                }
            }

            return true;
        }

        /// <summary>
        /// 根据选择删除多条出库单
        /// </summary>
        public bool DeleteWR_Multi(DataTable wrHeadTable)
        {
            string wrHeadNoListStr = "";
            for (int i = 0; i < wrHeadTable.Rows.Count; i++)
            {
                if (DataTypeConvert.GetBoolean(wrHeadTable.Rows[i]["Select"]))
                {
                    wrHeadNoListStr += string.Format("'{0}',", DataTypeConvert.GetString(wrHeadTable.Rows[i]["WarehouseReceipt"]));
                }
            }
            wrHeadNoListStr = wrHeadNoListStr.Substring(0, wrHeadNoListStr.Length - 1);
            if (!CheckWarehouseState(wrHeadTable, null, wrHeadNoListStr, false, true, true, true))
                return false;
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);
                        //cmd.CommandText = string.Format("select * from INV_WarehouseReceiptList where WarehouseReceipt in ({0})", wrHeadNoListStr);
                        //DataTable tmpTable = new DataTable();
                        //SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                        //adpt.Fill(tmpTable);

                        //保存日志到日志表中
                        DataRow[] wrHeadRows = wrHeadTable.Select("select=1");
                        for (int i = 0; i < wrHeadRows.Length; i++)
                        {
                            string logStr = LogHandler.RecordLog_DeleteRow(cmd, "出库单", wrHeadRows[i], "WarehouseReceipt");
                        }

                        cmd.CommandText = string.Format("Delete from INV_WarehouseReceiptList where WarehouseReceipt in ({0})", wrHeadNoListStr);
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = string.Format("Delete from INV_WarehouseReceiptHead where WarehouseReceipt in ({0})", wrHeadNoListStr);
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
        /// 审批选中的多条出库单
        /// </summary>
        public bool WRApprovalInfo_Multi(DataTable wrHeadTable, ref int successCountInt)
        {
            string wrHeadNoListStr = "";
            for (int i = 0; i < wrHeadTable.Rows.Count; i++)
            {
                if (DataTypeConvert.GetBoolean(wrHeadTable.Rows[i]["Select"]))
                {
                    wrHeadNoListStr += string.Format("'{0}',", DataTypeConvert.GetString(wrHeadTable.Rows[i]["WarehouseReceipt"]));
                }
            }

            wrHeadNoListStr = wrHeadNoListStr.Substring(0, wrHeadNoListStr.Length - 1);
            if (!CheckWarehouseState(wrHeadTable, null, wrHeadNoListStr, false, true, true, false))
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
                        for (int i = 0; i < wrHeadTable.Rows.Count; i++)
                        {
                            if (DataTypeConvert.GetBoolean(wrHeadTable.Rows[i]["Select"]))
                            {
                                DataRow wrRow = wrHeadTable.Rows[i];
                                string wrHeadNoStr = DataTypeConvert.GetString(wrRow["WarehouseReceipt"]);

                                cmd.CommandText = string.Format("select INV_WarehouseReceiptHead.WarehouseReceipt, INV_WarehouseReceiptHead.ApprovalType, PUR_ApprovalType.ApprovalCat from INV_WarehouseReceiptHead left join PUR_ApprovalType on INV_WarehouseReceiptHead.ApprovalType = PUR_ApprovalType.TypeNo where WarehouseReceipt = '{0}'", wrHeadNoStr);
                                DataTable tmpTable = new DataTable();
                                SqlDataAdapter orderadpt = new SqlDataAdapter(cmd);
                                orderadpt.Fill(tmpTable);
                                if (tmpTable.Rows.Count == 0)
                                {
                                    trans.Rollback();
                                    //MessageHandler.ShowMessageBox("未查询到要操作的出库单，请刷新后再进行操作。");
                                    MessageHandler.ShowMessageBox(f.tsmiWcxdyc.Text);
                                    return false;
                                }

                                ////审核检查入库明细数量是否超过采购订单明细数量
                                //DataTable orderListTable = new DataTable();
                                //QueryWarehouseWarrantList(orderListTable, wwHeadNoStr, false);
                                //if (!CheckOrderApplyBeyondCount(cmd, wwHeadNoStr, orderListTable))
                                //{
                                //    trans.Rollback();
                                //    return false;
                                //}

                                //Set_OrderHead_End(cmd, orderListTable);

                                string approvalTypeStr = DataTypeConvert.GetString(tmpTable.Rows[0]["ApprovalType"]);
                                cmd.CommandText = string.Format("select * from F_WarehouseReceiptNoApprovalList('{0}','{1}') Order by AppSequence", wrHeadNoStr, approvalTypeStr);
                                DataTable listTable = new DataTable();
                                SqlDataAdapter listadpt = new SqlDataAdapter(cmd);
                                listadpt.Fill(listTable);
                                if (listTable.Rows.Count == 0)
                                {
                                    cmd.CommandText = string.Format("Update INV_WarehouseReceiptHead set WarehouseState = 2 where WarehouseReceipt='{0}'", wrHeadNoStr);
                                    cmd.ExecuteNonQuery();
                                    wrHeadTable.Rows[i]["WarehouseState"] = 2;
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

                                cmd.CommandText = string.Format("Insert into INV_WarehouseReceiptApprovalInfo(WarehouseReceipt, Approver, ApproverTime) values ('{0}', {1}, '{2}')", wrHeadNoStr, SystemInfo.user.AutoId, serverTime.ToString("yyyy-MM-dd HH:mm:ss"));
                                cmd.ExecuteNonQuery();

                                if (listTable.Rows.Count == 1 || approvalCatInt == 2)
                                {
                                    cmd.CommandText = string.Format("Update INV_WarehouseReceiptHead set WarehouseState=2 where WarehouseReceipt='{0}'", wrHeadNoStr);
                                    cmd.ExecuteNonQuery();
                                    wrHeadTable.Rows[i]["WarehouseState"] = 2;
                                }
                                else
                                {
                                    cmd.CommandText = string.Format("Update INV_WarehouseReceiptHead set WarehouseState=4 where WarehouseReceipt='{0}'", wrHeadNoStr);
                                    cmd.ExecuteNonQuery();
                                    wrHeadTable.Rows[i]["WarehouseState"] = 4;
                                }

                                //保存日志到日志表中
                                string logStr = LogHandler.RecordLog_OperateRow(cmd, "出库单", wrHeadTable.Rows[i], "WarehouseReceipt", "审批", SystemInfo.user.EmpName, serverTime.ToString("yyyy-MM-dd HH:mm:ss"));

                                if (DataTypeConvert.GetInt(wrHeadTable.Rows[i]["WarehouseState"]) == 2)//全部审核通过进行下一步操作
                                {
                                    SqlCommand cmd_proc = new SqlCommand("", conn, trans);
                                    string errorText = "";
                                    if (!new FrmWarehouseNowInfoDAO().Update_WarehouseNowInfo(cmd_proc, wrHeadNoStr, 1, out errorText))
                                    {
                                        trans.Rollback();
                                        //MessageHandler.ShowMessageBox("出库单审核出库错误--" + errorText);
                                        MessageHandler.ShowMessageBox(f.tsmiCkshcw.Text + "--" + errorText);
                                        return false;
                                    }
                                }

                                successCountInt++;
                            }
                        }

                        trans.Commit();
                        wrHeadTable.AcceptChanges();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        wrHeadTable.RejectChanges();
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
        /// 取消审批选中的多条出库单
        /// </summary>
        public bool CancalWRApprovalInfo_Multi(DataTable wrHeadTable)
        {
            string wrHeadNoListStr = "";
            for (int i = 0; i < wrHeadTable.Rows.Count; i++)
            {
                if (DataTypeConvert.GetBoolean(wrHeadTable.Rows[i]["Select"]))
                {
                    wrHeadNoListStr += string.Format("'{0}',", DataTypeConvert.GetString(wrHeadTable.Rows[i]["WarehouseReceipt"]));
                    wrHeadTable.Rows[i]["WarehouseState"] = 1;
                }
            }

            wrHeadNoListStr = wrHeadNoListStr.Substring(0, wrHeadNoListStr.Length - 1);
            if (!CheckWarehouseState(wrHeadTable, null, wrHeadNoListStr, true, false, true, false))
                return false;

            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);

                        cmd.CommandText = string.Format("select WarehouseReceipt from INV_WarehouseReceiptHead where WarehouseState = 2 and WarehouseReceipt in ({0})", wrHeadNoListStr);
                        DataTable approcalWRTable = new DataTable();
                        SqlDataAdapter appradpt = new SqlDataAdapter(cmd);
                        appradpt.Fill(approcalWRTable);

                        cmd.CommandText = string.Format("Delete from INV_WarehouseReceiptApprovalInfo where WarehouseReceipt in ({0})", wrHeadNoListStr);
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = string.Format("Update INV_WarehouseReceiptHead set WarehouseState=1 where WarehouseReceipt in ({0})", wrHeadNoListStr);
                        cmd.ExecuteNonQuery();

                        //保存日志到日志表中
                        DataRow[] orderHeadRows = wrHeadTable.Select("select=1");
                        for (int i = 0; i < orderHeadRows.Length; i++)
                        {
                            ////检查是否有下级的主单
                            //if (CheckApplyWarehouseWarrant(cmd, DataTypeConvert.GetString(orderHeadRows[i]["OrderHeadNo"])))
                            //{
                            //    trans.Rollback();
                            //    wwHeadTable.RejectChanges();
                            //    MessageHandler.ShowMessageBox("采购订单已经有适用的入库单记录，不可以操作。");
                            //    return false;
                            //}

                            string logStr = LogHandler.RecordLog_OperateRow(cmd, "出库单", orderHeadRows[i], "WarehouseReceipt", "取消审批", SystemInfo.user.EmpName, BaseSQL.GetServerDateTime().ToString("yyyy-MM-dd HH:mm:ss"));
                        }

                        for (int i = 0; i < approcalWRTable.Rows.Count; i++)
                        {
                            SqlCommand cmd_proc = new SqlCommand("", conn, trans);
                            string errorText = "";
                            if (!new FrmWarehouseNowInfoDAO().Update_WarehouseNowInfo(cmd_proc, DataTypeConvert.GetString(approcalWRTable.Rows[i]["WarehouseReceipt"]), 2, out errorText))
                            {
                                trans.Rollback();
                                //MessageHandler.ShowMessageBox("出库单取消审核入库错误--" + errorText);
                                MessageHandler.ShowMessageBox(f.tsmiCkdqxs.Text + "--" + errorText);
                                return false;
                            }
                        }

                        trans.Commit();
                        wrHeadTable.AcceptChanges();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        wrHeadTable.RejectChanges();
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
        /// <param name="wrHeadNoStr">出库单号</param>
        /// <param name="handleTypeInt">打印处理类型：1 预览 2 打印 3 设计</param>
        public void PrintHandle(string wrHeadNoStr, int handleTypeInt)
        {
            DataSet ds = new DataSet();
            DataTable headTable = BaseSQL.GetTableBySql(string.Format("select * from V_Prn_INV_WarehouseReceiptHead where WarehouseReceipt = '{0}' order by AutoId", wrHeadNoStr));
            headTable.TableName = "WarehouseReceiptHead";
            for (int i = 0; i < headTable.Columns.Count; i++)
            {
                #region 设定主表显示的标题

                switch (headTable.Columns[i].ColumnName)
                {
                    case "WarehouseReceipt":
                        headTable.Columns[i].Caption = "出库单号";
                        break;
                    case "WarehouseReceiptDate":
                        headTable.Columns[i].Caption = "出库日期";
                        break;
                    case "DepartmentNo":
                        headTable.Columns[i].Caption = "部门编号";
                        break;
                    case "DepartmentName":
                        headTable.Columns[i].Caption = "部门名称";
                        break;
                    case "RepertoryNo":
                        headTable.Columns[i].Caption = "出库仓库编号";
                        break;
                    case "RepertoryName":
                        headTable.Columns[i].Caption = "出库仓库名称";
                        break;
                    case "WarehouseReceiptTypeNo":
                        headTable.Columns[i].Caption = "出库类别编号";
                        break;
                    case "WarehouseReceiptTypeName":
                        headTable.Columns[i].Caption = "出库类别名称";
                        break;
                    case "ApprovalTypeNo":
                        headTable.Columns[i].Caption = "审批类型编码";
                        break;
                    case "ApprovalTypeNoText":
                        headTable.Columns[i].Caption = "审批类型名称";
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
                    case "ManufactureNo":
                        headTable.Columns[i].Caption = "工程编码";
                        break;
                    case "ManufactureName":
                        headTable.Columns[i].Caption = "工程名称";
                        break;
                }

                #endregion
            }
            ds.Tables.Add(headTable);

            DataTable listTable = BaseSQL.GetTableBySql(string.Format("select *, ROW_NUMBER() over (order by AutoId) as RowNum from V_Prn_INV_WarehouseReceiptList where WarehouseReceipt = '{0}' order by AutoId", wrHeadNoStr));
            listTable.TableName = "WarehouseReceiptList";
            for (int i = 0; i < listTable.Columns.Count; i++)
            {
                #region 设定子表显示的标题

                switch (listTable.Columns[i].ColumnName)
                {
                    case "RowNum":
                        listTable.Columns[i].Caption = "行号";
                        break;
                    case "WarehouseReceipt":
                        listTable.Columns[i].Caption = "出库单号";
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
                        listTable.Columns[i].Caption = "出库数量";
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
            rptHandler.XtraReport_Handle("INV_WarehouseReceiptHead", ds, paralist, handleTypeInt);
        }
    }
}
