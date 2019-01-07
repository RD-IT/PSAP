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
    public class FrmWarehouseWarrantDAO
    {
        /// <summary>
        /// 得到仓库类别默认的个数
        /// </summary>
        public int Get_WarehouseType_DefaultCount(SqlCommand cmd, string tableNameStr)
        {
            cmd.CommandText = string.Format("Select Count(*) from {0} where IsDefault = 1", tableNameStr);
            return DataTypeConvert.GetInt(cmd.ExecuteScalar());
        }

        /// <summary>
        /// 得到仓库类别默认的类别编号
        /// </summary>
        public string Get_WarehouseType_TypeNo(string tableNameStr, string primaryKeyStr)
        {
            string sqlStr = string.Format("select {1} from {0} where IsDefault = 1", tableNameStr, primaryKeyStr);
            string typeNoStr = DataTypeConvert.GetString(BaseSQL.GetSingle(sqlStr));
            if (typeNoStr != "")
                return typeNoStr;
            else
            {
                sqlStr = string.Format("select top 1 {1} from {0}", tableNameStr, primaryKeyStr);
                return DataTypeConvert.GetString(BaseSQL.GetSingle(sqlStr));
            }
        }

        /// <summary>
        /// 查询仓库信息（增加一个全部选项）
        /// </summary>
        public DataTable QueryRepertoryInfo(bool addAllItem)
        {
            string sqlStr = "select AutoId, RepertoryNo, RepertoryName, RepertoryType, RepertoryTypeText from V_BS_RepertoryInfo Order by AutoId";
            if (addAllItem)
            {
                sqlStr = "select 0 as AutoId, '全部' as RepertoryNo, '全部' as RepertoryName, 1 as RepertoryType, '正常' as RepertoryTypeText union " + sqlStr;
            }
            return BaseSQL.GetTableBySql(sqlStr);
        }

        /// <summary>
        /// 查询入库类别（增加一个全部选项）
        /// </summary>
        public DataTable QueryWarehouseWarrantType(bool addAllItem)
        {
            string sqlStr = "select AutoId, WarehouseWarrantTypeNo, WarehouseWarrantTypeName, IsDefault from BS_WarehouseWarrantType Order by AutoId";
            if (addAllItem)
            {
                sqlStr = "select 0 as AutoId, '全部' as WarehouseWarrantTypeNo, '全部' as WarehouseWarrantTypeName, 0 as IsDefault union " + sqlStr;
            }
            return BaseSQL.GetTableBySql(sqlStr);
        }

        /// <summary>
        /// 更新仓库类别的默认选项
        /// </summary>
        public bool Update_WarehouseType_Default(string warehouseTypeNoStr, string tableNameStr, string primaryKeyStr, string tableLogNameStr)
        {
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);
                        cmd.CommandText = string.Format("Update {0} set IsDefault=0", tableNameStr);
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = string.Format("Update {1} set IsDefault=1 where {2} = '{0}'", warehouseTypeNoStr, tableNameStr, primaryKeyStr);
                        cmd.ExecuteNonQuery();

                        string logStr = string.Format("对[{1}]表进行[设定默认值]操作：主键的值为[{0}]", warehouseTypeNoStr, tableLogNameStr);
                        LogHandler.RecordLog(cmd, logStr);

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
        /// 查询入库单表头
        /// </summary>
        /// <param name="queryDataTable">要查询填充的数据表</param>
        /// <param name="beginDateStr">开始日期字符串</param>
        /// <param name="endDateStr">结束日期字符串</param>
        /// <param name="bussinessBaseNoStr">往来方编号</param>
        /// <param name="repertoryNoStr">入库仓库编号</param>
        /// <param name="wwTypeNoStr">入库类别编号</param>
        /// <param name="preparedStr">制单人</param>
        /// <param name="commonStr">通用查询条件</param>
        /// <param name="nullTable">是否查询空表</param>
        public void QueryWarehouseWarrantHead(DataTable queryDataTable, string beginDateStr, string endDateStr, string reqDepStr, string bussinessBaseNoStr, string repertoryNoStr, string wwTypeNoStr, int reqStateInt, string preparedStr, int approverInt, string commonStr, bool nullTable)
        {
            BaseSQL.Query(QueryWarehouseWarrantHead_SQL(beginDateStr, endDateStr, reqDepStr, bussinessBaseNoStr, repertoryNoStr, wwTypeNoStr, reqStateInt, preparedStr, approverInt, commonStr, nullTable), queryDataTable);
        }

        /// <summary>
        /// 查询入库单表头的SQL
        /// </summary>
        public string QueryWarehouseWarrantHead_SQL(string beginDateStr, string endDateStr, string reqDepStr, string bussinessBaseNoStr, string repertoryNoStr, string wwTypeNoStr, int reqStateInt, string preparedStr, int approverInt, string commonStr, bool nullTable)
        {
            string sqlStr = " 1=1";
            if (beginDateStr != "")
            {
                sqlStr += string.Format(" and WarehouseWarrantDate between '{0}' and '{1}'", beginDateStr, endDateStr);
            }
            if(reqDepStr!="")
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
            if (wwTypeNoStr != "")
            {
                sqlStr += string.Format(" and WarehouseWarrantTypeNo='{0}'", wwTypeNoStr);
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
                sqlStr += string.Format(" and (WarehouseWarrant like '%{0}%' or Remark like '%{0}%')", commonStr);
            }
            if (approverInt >= 0)
            {
                if (approverInt == 0)
                    sqlStr += string.Format(" and WarehouseState in (1,4)");
                else
                {
                    sqlStr = string.Format("select INV_WarehouseWarrantHead.* from INV_WarehouseWarrantHead left join PUR_ApprovalType on INV_WarehouseWarrantHead.ApprovalType = PUR_ApprovalType.TypeNo where {0} and INV_WarehouseWarrantHead.WarehouseState in (1, 4) and( (PUR_ApprovalType.ApprovalCat = 0 and exists (select * from (select top 1 * from F_WarehouseWarrantNoApprovalList(INV_WarehouseWarrantHead.WarehouseWarrant, INV_WarehouseWarrantHead.ApprovalType) Order by AppSequence) as minlist where Approver = {1})) or (PUR_ApprovalType.ApprovalCat = 1 and exists (select * from F_WarehouseWarrantNoApprovalList(INV_WarehouseWarrantHead.WarehouseWarrant, INV_WarehouseWarrantHead.ApprovalType) where Approver = {1}))) order by AutoId", sqlStr, approverInt);
                    return sqlStr;
                }
            }
            if (nullTable)
            {
                sqlStr += " and 1=2";
            }
            sqlStr = string.Format("select * from INV_WarehouseWarrantHead where {0} order by AutoId", sqlStr);
            return sqlStr;
        }

        /// <summary>
        /// 查询入库单明细表
        /// </summary>
        /// <param name="queryDataTable">要查询填充的数据表</param>
        /// <param name="warehouseWarrantStr">入库单号</param>
        public void QueryWarehouseWarrantList(DataTable queryDataTable, string warehouseWarrantStr, bool nullTable)
        {
            string sqlStr = string.Format(" and WarehouseWarrant='{0}'", warehouseWarrantStr);
            if (nullTable)
            {
                sqlStr += " and 1=2";
            }
            sqlStr = string.Format("select INV_WarehouseWarrantList.*, SW_PartsCode.CodeName from INV_WarehouseWarrantList left join SW_PartsCode on INV_WarehouseWarrantList.CodeFileName = SW_PartsCode.CodeFileName where 1=1 {0} order by AutoId", sqlStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 保存入库单
        /// </summary>
        /// <param name="wwHeadRow">入库单表头数据表</param>
        /// <param name="wwListTable">入库单明细数据表</param>
        /// <returns></returns>
        public int SaveWarehouseWarrant(DataRow wwHeadRow, DataTable wwListTable)
        {
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);

                        if (!CheckOrderApplyBeyondCount(cmd, wwHeadRow["WarehouseWarrant"].ToString(), wwListTable))
                        {
                            return 0;
                        }

                        if (wwHeadRow["WarehouseWarrant"].ToString() == "")//新增
                        {
                            string wwNo = BaseSQL.GetMaxCodeNo(cmd, "WW");
                            wwHeadRow["WarehouseWarrant"] = wwNo;
                            wwHeadRow["PreparedIp"] = SystemInfo.HostIpAddress;

                            for (int i = 0; i < wwListTable.Rows.Count; i++)
                            {
                                wwListTable.Rows[i]["WarehouseWarrant"] = wwNo;
                            }
                        }
                        else//修改
                        {
                            if (!CheckWarehouseState(wwHeadRow.Table, wwListTable, string.Format("'{0}'", DataTypeConvert.GetString(wwHeadRow["WarehouseWarrant"])), false, true, true, true))
                                return -1;

                            wwHeadRow["Modifier"] = SystemInfo.user.EmpName;
                            wwHeadRow["ModifierIp"] = SystemInfo.HostIpAddress;
                            wwHeadRow["ModifierTime"] = BaseSQL.GetServerDateTime();
                        }

                        //保存日志到日志表中
                        string logStr = LogHandler.RecordLog_DataRow(cmd, "入库单", wwHeadRow, "WarehouseWarrant");

                        cmd.CommandText = "select * from INV_WarehouseWarrantHead where 1=2";
                        SqlDataAdapter adapterHead = new SqlDataAdapter(cmd);
                        DataTable tmpHeadTable = new DataTable();
                        adapterHead.Fill(tmpHeadTable);
                        BaseSQL.UpdateDataTable(adapterHead, wwHeadRow.Table);

                        cmd.CommandText = "select * from INV_WarehouseWarrantList where 1=2";
                        SqlDataAdapter adapterList = new SqlDataAdapter(cmd);
                        DataTable tmpListTable = new DataTable();
                        adapterList.Fill(tmpListTable);
                        BaseSQL.UpdateDataTable(adapterList, wwListTable);

                        //Set_PrReqHead_End(cmd, wwListTable);

                        trans.Commit();

                        return 1;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        wwHeadRow.Table.RejectChanges();
                        wwListTable.RejectChanges();
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
        public bool CheckWarehouseState(DataTable wwHeadTable, DataTable wwListTable, string warehouseWarrantListStr, bool checkNoApprover, bool checkApprover, bool checkSettle, bool checkApproverBetween)
        {
            string sqlStr = string.Format("select WarehouseWarrant, WarehouseState from INV_WarehouseWarrantHead where WarehouseWarrant in ({0})", warehouseWarrantListStr);
            DataTable tmpTable = BaseSQL.Query(sqlStr).Tables[0];
            for (int i = 0; i < tmpTable.Rows.Count; i++)
            {
                int wState = DataTypeConvert.GetInt(tmpTable.Rows[i]["WarehouseState"]);
                switch (wState)
                {
                    case 1:
                        if (checkNoApprover)
                        {
                            MessageHandler.ShowMessageBox(string.Format("入库单[{0}]未审批，不可以操作。", DataTypeConvert.GetString(tmpTable.Rows[i]["WarehouseWarrant"])));
                            wwHeadTable.RejectChanges();
                            if (wwListTable != null)
                                wwListTable.RejectChanges();
                            return false;
                        }
                        break;
                    case 2:
                        if (checkApprover)
                        {
                            MessageHandler.ShowMessageBox(string.Format("入库单[{0}]已经审批，不可以操作。", DataTypeConvert.GetString(tmpTable.Rows[i]["WarehouseWarrant"])));
                            wwHeadTable.RejectChanges();
                            if (wwListTable != null)
                                wwListTable.RejectChanges();
                            return false;
                        }
                        break;
                    case 3:
                        if (checkSettle)
                        {
                            MessageHandler.ShowMessageBox(string.Format("入库单[{0}]已经结账，不可以操作。", DataTypeConvert.GetString(tmpTable.Rows[i]["WarehouseWarrant"])));
                            wwHeadTable.RejectChanges();
                            if (wwListTable != null)
                                wwListTable.RejectChanges();
                            return false;
                        }
                        break;
                    case 4:
                        if (checkApproverBetween)
                        {
                            MessageHandler.ShowMessageBox(string.Format("入库单[{0}]已经审批中，不可以操作。", DataTypeConvert.GetString(tmpTable.Rows[i]["WarehouseWarrant"])));
                            wwHeadTable.RejectChanges();
                            if (wwListTable != null)
                                wwListTable.RejectChanges();
                            return false;
                        }
                        break;
                }
            }

            return true;
        }

        /// <summary>
        /// 检查订单明细的数量是否超过请购单明细的数量
        /// </summary>
        private bool CheckOrderApplyBeyondCount(SqlCommand cmd, string wwHeadNoStr, DataTable wwListTable)
        {
            if (SystemInfo.OrderApplyBeyondCountIsSave)
                return true;

            foreach (DataRow lrow in wwListTable.Rows)
            {
                string codeFileNameStr = DataTypeConvert.GetString(lrow["CodeFileName"]);
                int poListAutoId = DataTypeConvert.GetInt(lrow["PoListAutoId"]);
                string sqlStr = string.Format("PoListAutoId = {0}", poListAutoId);
                double qtySum = DataTypeConvert.GetDouble(wwListTable.Compute("Sum(Qty)", sqlStr));
                cmd.CommandText = string.Format("select Sum(List.Qty) from INV_WarehouseWarrantList as List where List.PoListAutoId = {0} and List.WarehouseWarrant != '{1}'", poListAutoId, wwHeadNoStr);
                double otherWWQtySum = DataTypeConvert.GetDouble(cmd.ExecuteScalar());
                cmd.CommandText = string.Format("select Qty from PUR_OrderList where AutoId = {0}", poListAutoId);
                double orderQtySum = DataTypeConvert.GetDouble(cmd.ExecuteScalar());
                if (qtySum + otherWWQtySum > orderQtySum)
                {
                    MessageHandler.ShowMessageBox(string.Format("入库单中明细[{0}]的数量[{1}]超过请购单的数量[{2}]，不可以保存。", codeFileNameStr, qtySum + otherWWQtySum, orderQtySum));
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 根据选择删除多条入库单
        /// </summary>
        public bool DeleteWW_Multi(DataTable wwHeadTable)
        {
            string wwHeadNoListStr = "";
            for (int i = 0; i < wwHeadTable.Rows.Count; i++)
            {
                if (DataTypeConvert.GetBoolean(wwHeadTable.Rows[i]["Select"]))
                {
                    wwHeadNoListStr += string.Format("'{0}',", DataTypeConvert.GetString(wwHeadTable.Rows[i]["WarehouseWarrant"]));
                }
            }
            wwHeadNoListStr = wwHeadNoListStr.Substring(0, wwHeadNoListStr.Length - 1);
            if (!CheckWarehouseState(wwHeadTable, null, wwHeadNoListStr, false, true, true, true))
                return false;
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);
                        cmd.CommandText = string.Format("select * from INV_WarehouseWarrantList where WarehouseWarrant in ({0})", wwHeadNoListStr);
                        DataTable tmpTable = new DataTable();
                        SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                        adpt.Fill(tmpTable);

                        //保存日志到日志表中
                        DataRow[] wwHeadRows = wwHeadTable.Select("select=1");
                        for (int i = 0; i < wwHeadRows.Length; i++)
                        {
                            string logStr = LogHandler.RecordLog_DeleteRow(cmd, "入库单", wwHeadRows[i], "WarehouseWarrant");
                        }

                        cmd.CommandText = string.Format("Delete from INV_WarehouseWarrantList where WarehouseWarrant in ({0})", wwHeadNoListStr);
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = string.Format("Delete from INV_WarehouseWarrantHead where WarehouseWarrant in ({0})", wwHeadNoListStr);
                        cmd.ExecuteNonQuery();

                        //Set_PrReqHead_End(cmd, tmpTable);

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
        /// 审批选中的多条入库单
        /// </summary>
        public bool WWApprovalInfo_Multi(DataTable wwHeadTable, ref int successCountInt)
        {
            string wwHeadNoListStr = "";
            for (int i = 0; i < wwHeadTable.Rows.Count; i++)
            {
                if (DataTypeConvert.GetBoolean(wwHeadTable.Rows[i]["Select"]))
                {
                    wwHeadNoListStr += string.Format("'{0}',", DataTypeConvert.GetString(wwHeadTable.Rows[i]["WarehouseWarrant"]));
                }
            }

            wwHeadNoListStr = wwHeadNoListStr.Substring(0, wwHeadNoListStr.Length - 1);
            if (!CheckWarehouseState(wwHeadTable, null, wwHeadNoListStr, false, true, true, false))
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
                        for (int i = 0; i < wwHeadTable.Rows.Count; i++)
                        {
                            if (DataTypeConvert.GetBoolean(wwHeadTable.Rows[i]["Select"]))
                            {
                                DataRow wwRow = wwHeadTable.Rows[i];
                                string wwHeadNoStr = DataTypeConvert.GetString(wwRow["WarehouseWarrant"]);

                                cmd.CommandText = string.Format("select INV_WarehouseWarrantHead.WarehouseWarrant, INV_WarehouseWarrantHead.ApprovalType, PUR_ApprovalType.ApprovalCat from INV_WarehouseWarrantHead left join PUR_ApprovalType on INV_WarehouseWarrantHead.ApprovalType = PUR_ApprovalType.TypeNo where WarehouseWarrant = '{0}'", wwHeadNoStr);
                                DataTable tmpTable = new DataTable();
                                SqlDataAdapter orderadpt = new SqlDataAdapter(cmd);
                                orderadpt.Fill(tmpTable);
                                if (tmpTable.Rows.Count == 0)
                                {
                                    trans.Rollback();
                                    MessageHandler.ShowMessageBox("未查询到要操作的入库单，请刷新后再进行操作。");
                                    return false;
                                }

                                //审核检查入库明细数量是否超过采购订单明细数量
                                DataTable orderListTable = new DataTable();
                                QueryWarehouseWarrantList(orderListTable, wwHeadNoStr, false);
                                if (!CheckOrderApplyBeyondCount(cmd, wwHeadNoStr, orderListTable))
                                {
                                    trans.Rollback();
                                    return false;
                                }

                                //Set_PrReqHead_End(cmd, orderListTable);

                                string approvalTypeStr = DataTypeConvert.GetString(tmpTable.Rows[0]["ApprovalType"]);
                                cmd.CommandText = string.Format("select * from F_WarehouseWarrantNoApprovalList('{0}','{1}') Order by AppSequence", wwHeadNoStr, approvalTypeStr);
                                DataTable listTable = new DataTable();
                                SqlDataAdapter listadpt = new SqlDataAdapter(cmd);
                                listadpt.Fill(listTable);
                                if (listTable.Rows.Count == 0)
                                {
                                    cmd.CommandText = string.Format("Update INV_WarehouseWarrantHead set WarehouseState = 2 where WarehouseWarrant='{0}'", wwHeadNoStr);
                                    cmd.ExecuteNonQuery();
                                    wwHeadTable.Rows[i]["ReqState"] = 2;
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

                                cmd.CommandText = string.Format("Insert into INV_WarehouseApprovalInfo(WarehouseWarrant, Approver, ApproverTime) values ('{0}', {1}, '{2}')", wwHeadNoStr, SystemInfo.user.AutoId, serverTime.ToString("yyyy-MM-dd HH:mm:ss"));
                                cmd.ExecuteNonQuery();

                                if (listTable.Rows.Count == 1 || approvalCatInt == 2)
                                {
                                    cmd.CommandText = string.Format("Update INV_WarehouseWarrantHead set WarehouseState=2 where WarehouseWarrant='{0}'", wwHeadNoStr);
                                    cmd.ExecuteNonQuery();
                                    wwHeadTable.Rows[i]["WarehouseState"] = 2;
                                }
                                else
                                {
                                    cmd.CommandText = string.Format("Update INV_WarehouseWarrantHead set WarehouseState=4 where WarehouseWarrant='{0}'", wwHeadNoStr);
                                    cmd.ExecuteNonQuery();
                                    wwHeadTable.Rows[i]["WarehouseState"] = 4;
                                }

                                //保存日志到日志表中
                                string logStr = LogHandler.RecordLog_OperateRow(cmd, "入库单", wwHeadTable.Rows[i], "WarehouseWarrant", "审批", SystemInfo.user.EmpName, serverTime.ToString("yyyy-MM-dd HH:mm:ss"));
                                successCountInt++;
                            }
                        }

                        trans.Commit();
                        wwHeadTable.AcceptChanges();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        wwHeadTable.RejectChanges();
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
        /// 取消审批选中的多条采购订单
        /// </summary>
        public bool CancalWWApprovalInfo_Multi(DataTable wwHeadTable)
        {
            string wwHeadNoListStr = "";
            for (int i = 0; i < wwHeadTable.Rows.Count; i++)
            {
                if (DataTypeConvert.GetBoolean(wwHeadTable.Rows[i]["Select"]))
                {
                    wwHeadNoListStr += string.Format("'{0}',", DataTypeConvert.GetString(wwHeadTable.Rows[i]["WarehouseWarrant"]));
                    wwHeadTable.Rows[i]["WarehouseState"] = 1;
                }
            }

            wwHeadNoListStr = wwHeadNoListStr.Substring(0, wwHeadNoListStr.Length - 1);
            if (!CheckWarehouseState(wwHeadTable, null, wwHeadNoListStr, true, false, true, false))
                return false;

            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);
                        cmd.CommandText = string.Format("Delete from INV_WarehouseApprovalInfo where WarehouseWarrant in ({0})", wwHeadNoListStr);
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = string.Format("Update INV_WarehouseWarrantHead set WarehouseState=1 where WarehouseWarrant in ({0})", wwHeadNoListStr);
                        cmd.ExecuteNonQuery();

                        //保存日志到日志表中
                        DataRow[] orderHeadRows = wwHeadTable.Select("select=1");
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

                            string logStr = LogHandler.RecordLog_OperateRow(cmd, "入库单", orderHeadRows[i], "WarehouseWarrant", "取消审批", SystemInfo.user.EmpName, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        }

                        trans.Commit();
                        wwHeadTable.AcceptChanges();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        wwHeadTable.RejectChanges();
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
