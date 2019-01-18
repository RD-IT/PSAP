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
    class FrmPrReqDAO
    {
        #region 部门只能设定最后一级，不用此方法的递归了，暂时注释

        ///// <summary>
        ///// 得到部门及子部门的编号SQL
        ///// </summary>
        ///// <param name="colName"></param>
        ///// <param name="departmentNo"></param>
        ///// <returns></returns>
        //public string GetDepartmentNoSQL_AllChild(string colName, string departmentNo)
        //{
        //    string sqlStr = string.Format("with temp as ( select b.* from BS_Department b where ParentDepartmentNo = '{0}' union all select a.* from BS_Department a join temp on a.ParentDepartmentNo = temp.DepartmentNo ) select AutoID, DepartmentNo, DepartmentName from temp union all select AutoID, DepartmentNo, DepartmentName from BS_Department where DepartmentNo = '{0}' Order by AutoId", departmentNo);
        //    DataTable depTable = BaseSQL.GetTableBySql(sqlStr);
        //    string resultString = "";
        //    for (int i = 0; i < depTable.Rows.Count; i++)
        //    {
        //        resultString += string.Format(" '{0}',", DataTypeConvert.GetString(depTable.Rows[i]["DepartmentNo"]));
        //    }
        //    return string.Format("{0} in ({1})", colName, resultString.Substring(0, resultString.Length - 1));
        //}

        # endregion

        /// <summary>
        /// 查询请购单表头表
        /// </summary>
        /// <param name="queryDataTable">要查询填充的数据表</param>
        /// <param name="beginDateStr">开始日期字符串</param>
        /// <param name="endDateStr">结束日期字符串</param>
        /// <param name="reqDepStr">部门编号</param>
        /// <param name="purCategoryStr">采购类型</param>
        /// <param name="reqStateInt">状态</param>
        /// <param name="applicantStr">申请人</param>
        /// <param name="commonStr">通用查询条件</param>
        /// <param name="nullTable">是否查询空表</param>
        public void QueryPrReqHead(DataTable queryDataTable, string beginDateStr, string endDateStr, string reqDepStr, string purCategoryStr, int reqStateInt, string applicantStr, int approverInt, string commonStr, bool nullTable)
        {
            BaseSQL.Query(QueryPrReqHead_SQL(beginDateStr, endDateStr, reqDepStr, purCategoryStr, reqStateInt, applicantStr, approverInt, commonStr, nullTable), queryDataTable);
        }
        /// <summary>
        /// 查询请购单表头表的SQL
        /// </summary>
        public string QueryPrReqHead_SQL(string beginDateStr, string endDateStr, string reqDepStr, string purCategoryStr, int reqStateInt, string applicantStr, int approverInt, string commonStr, bool nullTable)
        {
            string sqlStr = " 1=1";
            if (beginDateStr != "")
            {
                sqlStr += string.Format(" and ReqDate between '{0}' and '{1}'", beginDateStr, endDateStr);
            }
            if (reqDepStr != "")
            {
                sqlStr += string.Format(" and ReqDep='{0}'", reqDepStr);
                //sqlStr += string.Format(" and {0}", GetDepartmentNoSQL_AllChild("ReqDep", reqDepStr));
            }
            if (purCategoryStr != "")
            {
                sqlStr += string.Format(" and PurCategory='{0}'", purCategoryStr);
            }
            if (reqStateInt != 0)
            {
                sqlStr += string.Format(" and ReqState={0}", reqStateInt);
            }
            if (applicantStr != "")
            {
                sqlStr += string.Format(" and Applicant='{0}'", applicantStr);
            }
            if (commonStr != "")
            {
                sqlStr += string.Format(" and (PrReqNo like '%{0}%' or ProjectNo like '%{0}%' or StnNo like '%{0}%' or PrReqRemark like '%{0}%')", commonStr);
            }
            if (approverInt >= 0)
            {
                if (approverInt == 0)
                    sqlStr += string.Format(" and ReqState in (1,4)");
                else
                {
                    sqlStr = string.Format("select PUR_PrReqHead.* from PUR_PrReqHead left join PUR_ApprovalType on PUR_PrReqHead.ApprovalType = PUR_ApprovalType.TypeNo where {0} and PUR_PrReqHead.ReqState in (1, 4) and( (PUR_ApprovalType.ApprovalCat = 0 and exists (select * from (select top 1 * from F_PrReqNoApprovalList(PUR_PrReqHead.PrReqNo, PUR_PrReqHead.ApprovalType) Order by AppSequence) as minlist where Approver = {1})) or (PUR_ApprovalType.ApprovalCat = 1 and exists (select * from F_PrReqNoApprovalList(PUR_PrReqHead.PrReqNo, PUR_PrReqHead.ApprovalType) where Approver = {1}))) order by AutoId", sqlStr, approverInt);
                    return sqlStr;
                }
            }
            if (nullTable)
            {
                sqlStr += " and 1=2";
            }
            sqlStr = string.Format("select * from PUR_PrReqHead where {0} order by AutoId", sqlStr);
            return sqlStr;
        }

        /// <summary>
        /// 查询请购单明细表
        /// </summary>
        /// <param name="queryDataTable">要查询填充的数据表</param>
        /// <param name="prReqNoStr">请购单号</param>
        public void QueryPrReqList(DataTable queryDataTable, string prReqNoStr)
        {
            string sqlStr = string.Format(" and PrReqNo='{0}'", prReqNoStr);
            //sqlStr = string.Format("select * from PUR_PrReqList where 1=1 {0} order by AutoId", sqlStr);
            sqlStr = string.Format("select PUR_PrReqList.*, SW_PartsCode.CodeName from PUR_PrReqList left join SW_PartsCode on PUR_PrReqList.CodeFileName = SW_PartsCode.CodeFileName where 1=1 {0} order by AutoId", sqlStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 根据请购单号删除请购单
        /// </summary>
        /// <param name="prReqNoStr">请购单号</param>
        public bool DeletePrReq(DataRow prReqHeadRow)
        {
            if (!CheckReqState(prReqHeadRow.Table, null, string.Format("'{0}'", DataTypeConvert.GetString(prReqHeadRow["PrReqNo"])), false, true, true, true))
                return false;

            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);

                        //保存日志到日志表中
                        string logStr = LogHandler.RecordLog_DeleteRow(cmd, "请购单", prReqHeadRow, "PrReqNo");

                        cmd.CommandText = string.Format("Delete from PUR_PrReqList where PrReqNo='{0}'", DataTypeConvert.GetString(prReqHeadRow["PrReqNo"]));
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = string.Format("Delete from PUR_PrReqHead where PrReqNo='{0}'", DataTypeConvert.GetString(prReqHeadRow["PrReqNo"]));
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
        /// 根据选择删除多条请购单
        /// </summary>
        public bool DeletePrReq_Multi(DataTable prReqHeadTable)
        {
            string prReqNoListStr = "";
            for (int i = 0; i < prReqHeadTable.Rows.Count; i++)
            {
                if (DataTypeConvert.GetBoolean(prReqHeadTable.Rows[i]["Select"]))
                {
                    prReqNoListStr += string.Format("'{0}',", DataTypeConvert.GetString(prReqHeadTable.Rows[i]["PrReqNo"]));
                }
            }
            prReqNoListStr = prReqNoListStr.Substring(0, prReqNoListStr.Length - 1);
            if (!CheckReqState(prReqHeadTable, null, prReqNoListStr, false, true, true, true))
                return false;
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);

                        //保存日志到日志表中
                        DataRow[] prReqHeadRows = prReqHeadTable.Select("select=1");
                        for (int i = 0; i < prReqHeadRows.Length; i++)
                        {
                            string logStr = LogHandler.RecordLog_DeleteRow(cmd, "请购单", prReqHeadRows[i], "PrReqNo");
                        }

                        cmd.CommandText = string.Format("Delete from PUR_PrReqList where PrReqNo in ({0})", prReqNoListStr);
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = string.Format("Delete from PUR_PrReqHead where PrReqNo in ({0})", prReqNoListStr);
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
        /// 判断站号是否包含在项目号中
        /// </summary>
        /// <param name="projectNoStr">项目号</param>
        /// <param name="stnNoStr">站号</param>
        public bool StnNoIsContainProjectNo(string projectNoStr, string stnNoStr)
        {
            string sqlStr = string.Format("select Count(*) from BS_StnList where ProjectNo='{0}' and StnNo='{1}'", projectNoStr, stnNoStr);
            int count = DataTypeConvert.GetInt(BaseSQL.GetSingle(sqlStr));
            return count == 0 ? false : true;
        }

        /// <summary>
        /// 保存请购单
        /// </summary>
        /// <param name="prReqHeadRow">请购单表头数据表</param>
        /// <param name="prReqListTable">请购单明细数据表</param>
        public int SavePrReq(DataRow prReqHeadRow, DataTable prReqListTable)
        {
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        //RecordLog_DataTable("请购单",prReqHeadRow.Table, "PrReqNo");
                        SqlCommand cmd = new SqlCommand("", conn, trans);
                        if (prReqHeadRow["PrReqNo"].ToString() == "")//新增
                        {
                            string prReqNo = BaseSQL.GetMaxCodeNo(cmd, "PR");
                            prReqHeadRow["PrReqNo"] = prReqNo;
                            prReqHeadRow["ApplicantIp"] = SystemInfo.HostIpAddress;
                            prReqHeadRow["ApplicantTime"] = BaseSQL.GetServerDateTime();

                            #region 直接使用Update更新表，不要Sql更新 暂时注释

                            //System.Collections.ArrayList sqlList = new System.Collections.ArrayList();
                            //string prReqNo = GetMaxOrderNo("PUR_PrReqHead", "PrReqNo", "PR", 11);
                            //string sqlStr = string.Format("insert into PUR_PrReqHead(PrReqNo, ReqDate, ReqDep, ProjectNo, StnNo, PurCategory, ReqState, Applicant, ApplicantIp) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', {6}, '', '')", prReqNo, DataTypeHelper.GetDateTime(prReqHeadRow["ReqDate"]).ToString(), DataTypeHelper.GetString( prReqHeadRow["ReqDep"]), DataTypeHelper.GetString(prReqHeadRow["ProjectNo"]), DataTypeHelper.GetString(prReqHeadRow["StnNo"]), DataTypeHelper.GetString(prReqHeadRow["PurCategory"]), DataTypeHelper.GetInt(prReqHeadRow["ReqState"]), FrmLoginDAO.user.RoleName, "IP");
                            //sqlList.Add(sqlStr);
                            //for(int i=0;i<prReqListTable.Rows.Count;i++)
                            //{
                            //    DataRow dr = prReqListTable.Rows[i];
                            //    if (dr["CodeFileName"].ToString() != "")
                            //    {                        
                            //        sqlStr = string.Format("insert into PUR_PrReqList(PrReqNo, CodeFileName, Qty, RequirementDate, PrReqListRemark) values('{0)', '{1}', {2}, '{3}', '{4}')", prReqNo, DataTypeHelper.GetString(dr["CodeFileName"]), DataTypeHelper.GetDouble(dr["Qty"]), DataTypeHelper.GetDateTime(prReqHeadRow["RequirementDate"]).ToString(), DataTypeHelper.GetString(dr["PrReqListRemark"]));
                            //        sqlList.Add(sqlStr);
                            //    }
                            //}
                            //BaseSQL.ExecuteSqlTran(sqlList);

                            #endregion

                            for (int i = 0; i < prReqListTable.Rows.Count; i++)
                            {
                                prReqListTable.Rows[i]["PrReqNo"] = prReqNo;
                            }
                        }
                        else//修改
                        {
                            if (!CheckReqState(prReqHeadRow.Table, prReqListTable, string.Format("'{0}'", DataTypeConvert.GetString(prReqHeadRow["PrReqNo"])), false, true, true, true))
                                return -1;

                            prReqHeadRow["Modifier"] = SystemInfo.user.EmpName;
                            prReqHeadRow["ModifierIp"] = SystemInfo.HostIpAddress;
                            prReqHeadRow["ModifierTime"] = BaseSQL.GetServerDateTime();
                        }

                        //保存日志到日志表中
                        string logStr = LogHandler.RecordLog_DataRow(cmd, "请购单", prReqHeadRow, "PrReqNo");

                        cmd.CommandText = "select * from PUR_PrReqHead where 1=2";
                        SqlDataAdapter adapterHead = new SqlDataAdapter(cmd);
                        DataTable tmpHeadTable = new DataTable();
                        adapterHead.Fill(tmpHeadTable);
                        BaseSQL.UpdateDataTable(adapterHead, prReqHeadRow.Table);

                        cmd.CommandText = "select * from PUR_PrReqList where 1=2";
                        SqlDataAdapter adapterList = new SqlDataAdapter(cmd);
                        DataTable tmpListTable = new DataTable();
                        adapterList.Fill(tmpListTable);
                        BaseSQL.UpdateDataTable(adapterList, prReqListTable);

                        trans.Commit();
                        return 1;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        prReqHeadRow.Table.RejectChanges();
                        prReqListTable.RejectChanges();
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
        /// 审批请购单
        /// </summary>
        /// <param name="prReqHeadRow">请购单表头数据行</param>
        public bool ApprovePrReq(DataRow prReqHeadRow)
        {
            if (!CheckReqState(prReqHeadRow.Table, null, string.Format("'{0}'", DataTypeConvert.GetString(prReqHeadRow["PrReqNo"])), false, true, true, false))
                return false;

            DateTime serverTime = BaseSQL.GetServerDateTime();
            prReqHeadRow["Approver"] = SystemInfo.user.EmpName;
            prReqHeadRow["ApproverIp"] = SystemInfo.HostIpAddress;
            prReqHeadRow["ApproverTime"] = serverTime;
            prReqHeadRow["ReqState"] = 2;

            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);
                        //cmd.CommandText = "select * from PUR_PrReqHead where 1=2";
                        //SqlDataAdapter adapterHead = new SqlDataAdapter(cmd);
                        //DataTable tmpHeadTable = new DataTable();
                        //adapterHead.Fill(tmpHeadTable);
                        //BaseSQL.UpdateDataTable(adapterHead, prReqHeadRow.Table);
                        cmd.CommandText = string.Format("Update PUR_PrReqHead set ReqState={1}, Approver='{2}', ApproverIp='{3}', ApproverTime='{4}' where PrReqNo='{0}'", DataTypeConvert.GetString(prReqHeadRow["PrReqNo"]), 2, SystemInfo.user.EmpName, SystemInfo.HostIpAddress, serverTime.ToString("yyyy-MM-dd HH:mm:ss"));
                        cmd.ExecuteNonQuery();

                        //保存日志到日志表中
                        string logStr = LogHandler.RecordLog_OperateRow(cmd, "请购单", prReqHeadRow, "PrReqNo", "审批", SystemInfo.user.EmpName, serverTime.ToString("yyyy-MM-dd HH:mm:ss"));

                        trans.Commit();
                        prReqHeadRow.AcceptChanges();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        prReqHeadRow.Table.RejectChanges();
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
        public bool ApprovePrReq_Multi(DataTable prReqHeadTable)
        {
            string prReqNoListStr = "";
            DateTime serverTime = BaseSQL.GetServerDateTime();
            for (int i = 0; i < prReqHeadTable.Rows.Count; i++)
            {
                if (DataTypeConvert.GetBoolean(prReqHeadTable.Rows[i]["Select"]))
                {
                    prReqNoListStr += string.Format("'{0}',", DataTypeConvert.GetString(prReqHeadTable.Rows[i]["PrReqNo"]));
                    prReqHeadTable.Rows[i]["Approver"] = SystemInfo.user.EmpName;
                    prReqHeadTable.Rows[i]["ApproverIp"] = SystemInfo.HostIpAddress;
                    prReqHeadTable.Rows[i]["ApproverTime"] = serverTime;
                    prReqHeadTable.Rows[i]["ReqState"] = 2;
                }
            }

            prReqNoListStr = prReqNoListStr.Substring(0, prReqNoListStr.Length - 1);
            if (!CheckReqState(prReqHeadTable, null, prReqNoListStr, false, true, true, false))
                return false;

            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);
                        cmd.CommandText = string.Format("Update PUR_PrReqHead set ReqState={1}, Approver='{2}', ApproverIp='{3}', ApproverTime='{4}' where PrReqNo in ({0})", prReqNoListStr, 2, SystemInfo.user.EmpName, SystemInfo.HostIpAddress, serverTime.ToString("yyyy-MM-dd HH:mm:ss"));
                        cmd.ExecuteNonQuery();

                        //保存日志到日志表中
                        DataRow[] prReqHeadRows = prReqHeadTable.Select("select=1");
                        for (int i = 0; i < prReqHeadRows.Length; i++)
                        {
                            string logStr = LogHandler.RecordLog_OperateRow(cmd, "请购单", prReqHeadRows[i], "PrReqNo", "审批", SystemInfo.user.EmpName, serverTime.ToString("yyyy-MM-dd HH:mm:ss"));
                        }

                        trans.Commit();
                        prReqHeadTable.AcceptChanges();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        prReqHeadTable.RejectChanges();
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
        /// 取消审批请购单
        /// </summary>
        /// <param name="prReqHeadRow">请购单表头数据行</param>
        public bool CancelApprovePrReq(DataRow prReqHeadRow)
        {
            if (!CheckReqState(prReqHeadRow.Table, null, string.Format("'{0}'", DataTypeConvert.GetString(prReqHeadRow["PrReqNo"])), true, false, true, false))
                return false;            

            prReqHeadRow["Approver"] = "";
            prReqHeadRow["ApproverIp"] = "";
            prReqHeadRow["ApproverTime"] = "";
            prReqHeadRow["ReqState"] = 1;

            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);

                        //检查是否有下级的采购订单
                        if (CheckApplyOrder(cmd, DataTypeConvert.GetString(prReqHeadRow["PrReqNo"])))
                        {
                            trans.Rollback();
                            prReqHeadRow.Table.RejectChanges();
                            MessageHandler.ShowMessageBox("请购单已经有适用的采购订单记录，不可以操作。");
                            return false;
                        }

                        cmd.CommandText = string.Format("Update PUR_PrReqHead set ReqState={1}, Approver='{2}', ApproverIp='{3}', ApproverTime='{4}' where PrReqNo='{0}'", DataTypeConvert.GetString(prReqHeadRow["PrReqNo"]), 1, "", "", "");
                        cmd.ExecuteNonQuery();

                        //保存日志到日志表中
                        string logStr = LogHandler.RecordLog_OperateRow(cmd, "请购单", prReqHeadRow, "PrReqNo", "取消审批", SystemInfo.user.EmpName, BaseSQL.GetServerDateTime().ToString("yyyy-MM-dd HH:mm:ss"));

                        trans.Commit();
                        prReqHeadRow.AcceptChanges();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        prReqHeadRow.Table.RejectChanges();
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
        public bool CancelApprovePrReq_Multi(DataTable prReqHeadTable)
        {
            string prReqNoListStr = "";
            for (int i = 0; i < prReqHeadTable.Rows.Count; i++)
            {
                if (DataTypeConvert.GetBoolean(prReqHeadTable.Rows[i]["Select"]))
                {
                    prReqNoListStr += string.Format("'{0}',", DataTypeConvert.GetString(prReqHeadTable.Rows[i]["PrReqNo"]));
                    prReqHeadTable.Rows[i]["Approver"] = "";
                    prReqHeadTable.Rows[i]["ApproverIp"] = "";
                    prReqHeadTable.Rows[i]["ApproverTime"] = DBNull.Value;
                    prReqHeadTable.Rows[i]["ReqState"] = 1;
                }
            }

            prReqNoListStr = prReqNoListStr.Substring(0, prReqNoListStr.Length - 1);
            if (!CheckReqState(prReqHeadTable, null, prReqNoListStr, true, false, true, false))
                return false;

            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);
                        cmd.CommandText = string.Format("Update PUR_PrReqHead set ReqState={1}, Approver='{2}', ApproverIp='{3}', ApproverTime=null where PrReqNo in ({0})", prReqNoListStr, 1, "", "");
                        cmd.ExecuteNonQuery();

                        //保存日志到日志表中
                        DataRow[] prReqHeadRows = prReqHeadTable.Select("select=1");
                        for (int i = 0; i < prReqHeadRows.Length; i++)
                        {
                            //检查是否有下级的采购订单
                            if (CheckApplyOrder(cmd, DataTypeConvert.GetString(prReqHeadRows[i]["PrReqNo"])))
                            {
                                trans.Rollback();
                                prReqHeadTable.RejectChanges();
                                MessageHandler.ShowMessageBox("请购单已经有适用的采购订单记录，不可以操作。");
                                return false;
                            }

                            string logStr = LogHandler.RecordLog_OperateRow(cmd, "请购单", prReqHeadRows[i], "PrReqNo", "取消审批", SystemInfo.user.EmpName, BaseSQL.GetServerDateTime().ToString("yyyy-MM-dd HH:mm:ss"));
                        }

                        trans.Commit();
                        prReqHeadTable.AcceptChanges();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        prReqHeadTable.RejectChanges();
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
        /// <param name="prReqHeadRow">请购单表头数据行</param>
        public bool ClosePrReq(DataRow prReqHeadRow)
        {
            if (!CheckReqState(prReqHeadRow.Table, null, string.Format("'{0}'", DataTypeConvert.GetString(prReqHeadRow["PrReqNo"])), false, false, true, false))
                return false;

            DateTime serverTime = BaseSQL.GetServerDateTime();
            prReqHeadRow["Closed"] = SystemInfo.user.EmpName;
            prReqHeadRow["ClosedIp"] = SystemInfo.HostIpAddress;
            prReqHeadRow["ClosedTime"] = serverTime;
            prReqHeadRow["ReqState"] = 3;

            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);
                        cmd.CommandText = string.Format("Update PUR_PrReqHead set ReqState={1}, Closed='{2}', ClosedIp='{3}', ClosedTime='{4}' where PrReqNo='{0}'", DataTypeConvert.GetString(prReqHeadRow["PrReqNo"]), 3, SystemInfo.user.EmpName, SystemInfo.HostIpAddress, serverTime.ToString("yyyy-MM-dd HH:mm:ss"));
                        cmd.ExecuteNonQuery();

                        //保存日志到日志表中
                        string logStr = LogHandler.RecordLog_OperateRow(cmd, "请购单", prReqHeadRow, "PrReqNo", "关闭", SystemInfo.user.EmpName, serverTime.ToString("yyyy-MM-dd HH:mm:ss"));

                        trans.Commit();
                        prReqHeadRow.AcceptChanges();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        prReqHeadRow.Table.RejectChanges();
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
        public bool ClosePrReq_Multi(DataTable prReqHeadTable)
        {
            string prReqNoListStr = "";
            DateTime serverTime = BaseSQL.GetServerDateTime();
            for (int i = 0; i < prReqHeadTable.Rows.Count; i++)
            {
                if (DataTypeConvert.GetBoolean(prReqHeadTable.Rows[i]["Select"]))
                {
                    prReqNoListStr += string.Format("'{0}',", DataTypeConvert.GetString(prReqHeadTable.Rows[i]["PrReqNo"]));
                    prReqHeadTable.Rows[i]["Closed"] = SystemInfo.user.EmpName;
                    prReqHeadTable.Rows[i]["ClosedIp"] = SystemInfo.HostIpAddress;
                    prReqHeadTable.Rows[i]["ClosedTime"] = serverTime;
                    prReqHeadTable.Rows[i]["ReqState"] = 3;
                }
            }

            prReqNoListStr = prReqNoListStr.Substring(0, prReqNoListStr.Length - 1);
            if (!CheckReqState(prReqHeadTable, null, prReqNoListStr, false, false, true, false))
                return false;

            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);
                        cmd.CommandText = string.Format("Update PUR_PrReqHead set ReqState={1}, Closed='{2}', ClosedIp='{3}', ClosedTime='{4}' where PrReqNo in ({0})", prReqNoListStr, 3, SystemInfo.user.EmpName, SystemInfo.HostIpAddress, serverTime.ToString("yyyy-MM-dd HH:mm:ss"));
                        cmd.ExecuteNonQuery();

                        //保存日志到日志表中
                        DataRow[] prReqHeadRows = prReqHeadTable.Select("select=1");
                        for (int i = 0; i < prReqHeadRows.Length; i++)
                        {
                            string logStr = LogHandler.RecordLog_OperateRow(cmd, "请购单", prReqHeadRows[i], "PrReqNo", "关闭", SystemInfo.user.EmpName, serverTime.ToString("yyyy-MM-dd HH:mm:ss"));
                        }

                        trans.Commit();
                        prReqHeadTable.AcceptChanges();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        prReqHeadTable.RejectChanges();
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
        public bool CancelClosePrReq_Multi(DataTable prReqHeadTable)
        {
            string prReqNoListStr = "";
            DateTime serverTime = BaseSQL.GetServerDateTime();
            for (int i = 0; i < prReqHeadTable.Rows.Count; i++)
            {
                if (DataTypeConvert.GetBoolean(prReqHeadTable.Rows[i]["Select"]))
                {
                    prReqNoListStr += string.Format("'{0}',", DataTypeConvert.GetString(prReqHeadTable.Rows[i]["PrReqNo"]));
                    prReqHeadTable.Rows[i]["Closed"] = "";
                    prReqHeadTable.Rows[i]["ClosedIp"] = "";
                    prReqHeadTable.Rows[i]["ClosedTime"] = DBNull.Value;
                    prReqHeadTable.Rows[i]["ReqState"] = DataTypeConvert.GetString(prReqHeadTable.Rows[i]["Approver"]) == "" ? 1 : 2;
                }
            }

            prReqNoListStr = prReqNoListStr.Substring(0, prReqNoListStr.Length - 1);
            if (!CheckReqState(prReqHeadTable, null, prReqNoListStr, true, true, false, true))
                return false;

            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);


                        DataRow[] prReqHeadRows = prReqHeadTable.Select("select=1");
                        for (int i = 0; i < prReqHeadRows.Length; i++)
                        {
                            cmd.CommandText = string.Format("Update PUR_PrReqHead set ReqState={1}, Closed='{2}', ClosedIp='{3}', ClosedTime=null where PrReqNo = '{0}'", DataTypeConvert.GetString(prReqHeadRows[i]["PrReqNo"]), DataTypeConvert.GetInt(prReqHeadRows[i]["ReqState"]), "", "");
                            cmd.ExecuteNonQuery();

                            //保存日志到日志表中
                            string logStr = LogHandler.RecordLog_OperateRow(cmd, "请购单", prReqHeadRows[i], "PrReqNo", "取消关闭", SystemInfo.user.EmpName, serverTime.ToString("yyyy-MM-dd HH:mm:ss"));
                        }

                        trans.Commit();
                        prReqHeadTable.AcceptChanges();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        prReqHeadTable.RejectChanges();
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
        public bool CheckReqState(DataTable prReqHeadTable, DataTable prReqListTable, string prReqNoListStr, bool checkNoApprover, bool checkApprover, bool checkClosed, bool checkApproverBetween)
        {
            string sqlStr = string.Format("select PrReqNo, ReqState from PUR_PrReqHead where PrReqNo in ({0})", prReqNoListStr);
            DataTable tmpTable = BaseSQL.Query(sqlStr).Tables[0];
            for (int i = 0; i < tmpTable.Rows.Count; i++)
            {
                int reqState = DataTypeConvert.GetInt(tmpTable.Rows[i]["ReqState"]);
                switch (reqState)
                {
                    case 1:
                        if (checkNoApprover)
                        {
                            MessageHandler.ShowMessageBox(string.Format("请购单[{0}]未审批，不可以操作。", DataTypeConvert.GetString(tmpTable.Rows[i]["PrReqNo"])));
                            prReqHeadTable.RejectChanges();
                            if (prReqListTable != null)
                                prReqListTable.RejectChanges();
                            return false;
                        }
                        break;
                    case 2:
                        if (checkApprover)
                        {
                            MessageHandler.ShowMessageBox(string.Format("请购单[{0}]已经审批，不可以操作。", DataTypeConvert.GetString(tmpTable.Rows[i]["PrReqNo"])));
                            prReqHeadTable.RejectChanges();
                            if (prReqListTable != null)
                                prReqListTable.RejectChanges();
                            return false;
                        }
                        break;
                    case 3:
                        if (checkClosed)
                        {
                            MessageHandler.ShowMessageBox(string.Format("请购单[{0}]已经关闭，不可以操作。", DataTypeConvert.GetString(tmpTable.Rows[i]["PrReqNo"])));
                            prReqHeadTable.RejectChanges();
                            if (prReqListTable != null)
                                prReqListTable.RejectChanges();
                            return false;
                        }
                        break;
                    case 4:
                        if (checkApproverBetween)
                        {
                            MessageHandler.ShowMessageBox(string.Format("请购单[{0}]已经审批中，不可以操作。", DataTypeConvert.GetString(tmpTable.Rows[i]["PrReqNo"])));
                            prReqHeadTable.RejectChanges();
                            if (prReqListTable != null)
                                prReqListTable.RejectChanges();
                            return false;
                        }
                        break;
                }
            }
            return true;
        }

        /// <summary>
        /// 检测数据库中请购单是否有请购适用的记录
        /// </summary>
        private bool CheckApplyOrder(SqlCommand cmd, string prReqNoStr)
        {
            cmd.CommandText = string.Format("select Count(*) from PUR_OrderList where PrReqNo = '{0}'", prReqNoStr);
            return DataTypeConvert.GetInt(cmd.ExecuteScalar()) > 0;
            //if (DataTypeConvert.GetInt(BaseSQL.GetSingle(sqlStr)) > 0)
            //{
            //    MessageHandler.ShowMessageBox("请购单已经有请购适用的记录，不可以操作。");
            //    return false;
            //}
            //return true;
        }

        ///// <summary>
        ///// 得到订单最大的编号
        ///// </summary>
        ///// <param name="tableName">数据表名</param>
        ///// <param name="columnName">数据列名</param>
        ///// <param name="headCharacter">头字母</param>
        ///// <param name="numberLong">后数字的长度</param>
        //public string GetMaxOrderNo(string tableName, string columnName, string headCharacter, int numberLong)
        //{
        //    string sqlStr = string.Format("select max({1}) from {0}", tableName, columnName);
        //    string maxNo = DataTypeConvert.GetString(BaseSQL.GetSingle(sqlStr));
        //    if (string.IsNullOrEmpty(maxNo))
        //    {
        //        maxNo = headCharacter + "1".PadLeft(numberLong, '0');
        //        return maxNo;
        //    }
        //    else
        //    {
        //        int number = DataTypeConvert.GetInt(maxNo.Replace(headCharacter, ""));
        //        maxNo = headCharacter + (number + 1).ToString().PadLeft(numberLong, '0');
        //        return maxNo;
        //    }
        //}


        /// <summary>
        /// 审批选中的多条请购单
        /// </summary>
        public bool PrReqApprovalInfo_Multi(DataTable prReqHeadTable, ref int successCountInt)
        {
            string prReqNoListStr = "";
            for (int i = 0; i < prReqHeadTable.Rows.Count; i++)
            {
                if (DataTypeConvert.GetBoolean(prReqHeadTable.Rows[i]["Select"]))
                {
                    prReqNoListStr += string.Format("'{0}',", DataTypeConvert.GetString(prReqHeadTable.Rows[i]["PrReqNo"]));
                }
            }

            prReqNoListStr = prReqNoListStr.Substring(0, prReqNoListStr.Length - 1);
            if (!CheckReqState(prReqHeadTable, null, prReqNoListStr, false, true, true, false))
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
                        for (int i = 0; i < prReqHeadTable.Rows.Count; i++)
                        {
                            if (DataTypeConvert.GetBoolean(prReqHeadTable.Rows[i]["Select"]))
                            {
                                DataRow prReqRow = prReqHeadTable.Rows[i];
                                string prReqNoStr = DataTypeConvert.GetString(prReqRow["PrReqNo"]);

                                cmd.CommandText = string.Format("select PUR_PrReqHead.PrReqNo, PUR_PrReqHead.ApprovalType, PUR_ApprovalType.ApprovalCat from PUR_PrReqHead left join PUR_ApprovalType on PUR_PrReqHead.ApprovalType = PUR_ApprovalType.TypeNo where PrReqNo='{0}'", prReqNoStr);
                                DataTable tmpTable = new DataTable();
                                SqlDataAdapter prReqadpt = new SqlDataAdapter(cmd);
                                prReqadpt.Fill(tmpTable);
                                if (tmpTable.Rows.Count == 0)
                                {
                                    trans.Rollback();
                                    MessageHandler.ShowMessageBox("未查询到要操作的请购单，请刷新后再进行操作。");
                                    return false;
                                }

                                string approvalTypeStr = DataTypeConvert.GetString(tmpTable.Rows[0]["ApprovalType"]);
                                cmd.CommandText = string.Format("select * from F_PrReqNoApprovalList('{0}','{1}') Order by AppSequence", prReqNoStr, approvalTypeStr);
                                DataTable listTable = new DataTable();
                                SqlDataAdapter listadpt = new SqlDataAdapter(cmd);
                                listadpt.Fill(listTable);
                                if (listTable.Rows.Count == 0)
                                {
                                    cmd.CommandText = string.Format("Update PUR_PrReqHead set ReqState=2 where PrReqNo='{0}'", prReqNoStr);
                                    cmd.ExecuteNonQuery();
                                    prReqHeadTable.Rows[i]["ReqState"] = 2;
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

                                cmd.CommandText = string.Format("Insert into PUR_PrApprovalInfo(PrReqNo, Approver, ApproverTime) values ('{0}', {1}, '{2}')", prReqNoStr, SystemInfo.user.AutoId, serverTime.ToString("yyyy-MM-dd HH:mm:ss"));
                                cmd.ExecuteNonQuery();

                                if (listTable.Rows.Count == 1 || approvalCatInt == 2)
                                {
                                    cmd.CommandText = string.Format("Update PUR_PrReqHead set ReqState=2 where PrReqNo='{0}'", prReqNoStr);
                                    cmd.ExecuteNonQuery();
                                    prReqHeadTable.Rows[i]["ReqState"] = 2;
                                }
                                else
                                {
                                    cmd.CommandText = string.Format("Update PUR_PrReqHead set ReqState=4 where PrReqNo='{0}'", prReqNoStr);
                                    cmd.ExecuteNonQuery();
                                    prReqHeadTable.Rows[i]["ReqState"] = 4;
                                }

                                //保存日志到日志表中
                                string logStr = LogHandler.RecordLog_OperateRow(cmd, "请购单", prReqHeadTable.Rows[i], "PrReqNo", "审批", SystemInfo.user.EmpName, serverTime.ToString("yyyy-MM-dd HH:mm:ss"));
                                successCountInt++;
                            }
                        }

                        trans.Commit();
                        prReqHeadTable.AcceptChanges();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        prReqHeadTable.RejectChanges();
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
        public bool CancalPrReqApprovalInfo_Multi(DataTable prReqHeadTable)
        {
            string prReqNoListStr = "";
            for (int i = 0; i < prReqHeadTable.Rows.Count; i++)
            {
                if (DataTypeConvert.GetBoolean(prReqHeadTable.Rows[i]["Select"]))
                {
                    prReqNoListStr += string.Format("'{0}',", DataTypeConvert.GetString(prReqHeadTable.Rows[i]["PrReqNo"]));
                    prReqHeadTable.Rows[i]["ReqState"] = 1;
                }
            }

            prReqNoListStr = prReqNoListStr.Substring(0, prReqNoListStr.Length - 1);
            if (!CheckReqState(prReqHeadTable, null, prReqNoListStr, true, false, true, false))
                return false;

            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);
                        cmd.CommandText = string.Format("Delete from PUR_PrApprovalInfo where PrReqNo in ({0})", prReqNoListStr);
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = string.Format("Update PUR_PrReqHead set ReqState=1 where PrReqNo in ({0})", prReqNoListStr);
                        cmd.ExecuteNonQuery();

                        //保存日志到日志表中
                        DataRow[] prReqHeadRows = prReqHeadTable.Select("select=1");
                        for (int i = 0; i < prReqHeadRows.Length; i++)
                        {
                            //检查是否有下级的采购订单
                            if (CheckApplyOrder(cmd, DataTypeConvert.GetString(prReqHeadRows[i]["PrReqNo"])))
                            {
                                trans.Rollback();
                                prReqHeadTable.RejectChanges();
                                MessageHandler.ShowMessageBox("请购单已经有适用的采购订单记录，不可以操作。");
                                return false;
                            }

                            string logStr = LogHandler.RecordLog_OperateRow(cmd, "请购单", prReqHeadRows[i], "PrReqNo", "取消审批", SystemInfo.user.EmpName, BaseSQL.GetServerDateTime().ToString("yyyy-MM-dd HH:mm:ss"));
                        }

                        trans.Commit();
                        prReqHeadTable.AcceptChanges();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        prReqHeadTable.RejectChanges();
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
        /// <param name="prReqNoStr">请购单号</param>
        /// <param name="handleTypeInt">打印处理类型：1 预览 2 打印 3 设计</param>
        public void PrintHandle(string prReqNoStr,int handleTypeInt)
        {
            DataSet ds = new DataSet();
            DataTable headTable = BaseSQL.GetTableBySql(string.Format("select * from V_Prn_PUR_PrReqHead where PrReqNo = '{0}' order by AutoId", prReqNoStr));
            headTable.TableName = "PrReqHead";
            for (int i = 0; i < headTable.Columns.Count; i++)
            {
                #region 设定主表显示的标题

                switch (headTable.Columns[i].ColumnName)
                {
                    case "PrReqNo":
                        headTable.Columns[i].Caption = "请购单号";
                        break;
                    case "ReqDate":
                        headTable.Columns[i].Caption = "请购日期";
                        break;
                    case "DepartmentNo":
                        headTable.Columns[i].Caption = "部门编号";
                        break;
                    case "DepartmentName":
                        headTable.Columns[i].Caption = "部门名称";
                        break;
                    case "ProjectNo":
                        headTable.Columns[i].Caption = "项目号";
                        break;
                    case "ProjectName":
                        headTable.Columns[i].Caption = "项目名称";
                        break;
                    case "StnNo":
                        headTable.Columns[i].Caption = "站号";
                        break;
                    case "PurCategory":
                        headTable.Columns[i].Caption = "采购类型编号";
                        break;
                    case "PurCategoryText":
                        headTable.Columns[i].Caption = "采购类型名称";
                        break;
                    case "ReqState":
                        headTable.Columns[i].Caption = "单据状态";
                        break;
                    case "ReqStateDesc":
                        headTable.Columns[i].Caption = "单据状态描述";
                        break;
                    case "Applicant":
                        headTable.Columns[i].Caption = "申请人";
                        break;
                    case "ApplicantIp":
                        headTable.Columns[i].Caption = "申请人IP";
                        break;
                    case "ApplicantTime":
                        headTable.Columns[i].Caption = "申请时间";
                        break;
                    case "Approver":
                        headTable.Columns[i].Caption = "审批人";
                        break;
                    case "ApproverIp":
                        headTable.Columns[i].Caption = "审批人IP";
                        break;
                    case "ApproverTime":
                        headTable.Columns[i].Caption = "审批时间";
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
                    case "PrReqRemark":
                        headTable.Columns[i].Caption = "备注";
                        break;
                    case "Closed":
                        headTable.Columns[i].Caption = "关闭人";
                        break;
                    case "ClosedIp":
                        headTable.Columns[i].Caption = "关闭人IP";
                        break;
                    case "ClosedTime":
                        headTable.Columns[i].Caption = "关闭时间";
                        break;
                }

                #endregion
            }
            ds.Tables.Add(headTable);

            DataTable listTable = BaseSQL.GetTableBySql(string.Format("select *, ROW_NUMBER() over (order by AutoId) as RowNum from V_Prn_PUR_PrReqList where PrReqNo = '{0}' order by AutoId", prReqNoStr));
            listTable.TableName = "PrReqList";
            for (int i = 0; i < listTable.Columns.Count; i++)
            {
                #region 设定子表显示的标题

                switch (listTable.Columns[i].ColumnName)
                {
                    case "RowNum":
                        listTable.Columns[i].Caption = "行号";
                        break;
                    case "PrReqNo":
                        listTable.Columns[i].Caption = "请购单号";
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
                    case "RequirementDate":
                        listTable.Columns[i].Caption = "需求日期";
                        break;
                    case "PrReqListRemark":
                        listTable.Columns[i].Caption = "备注";
                        break;
                }

                #endregion
            }
            ds.Tables.Add(listTable);

            List<DevExpress.XtraReports.Parameters.Parameter> paralist = ReportHandler.GetSystemInfo_ParamList();

            ReportHandler.XtraReport_Handle(new DevExpress.XtraReports.UI.XtraReport(), "PUR_PrReqHead", ds, paralist, handleTypeInt);

        }

        /// <summary>
        /// 查询请购余量表的SQL
        /// </summary>
        public string Query_PrReqList_Overplus(string beginDateStr, string endDateStr, string reqDepStr, string purCategoryStr, string projectNoStr, int reqStateInt, string codeFileNameStr, string commonStr)
        {
            string sqlStr = " 1=1";
            if (beginDateStr != "")
            {
                sqlStr += string.Format(" and ReqDate between '{0}' and '{1}'", beginDateStr, endDateStr);
            }
            if (reqDepStr != "")
            {
                sqlStr += string.Format(" and ReqDep='{0}'", reqDepStr);
            }
            if (purCategoryStr != "")
            {
                sqlStr += string.Format(" and PurCategory='{0}'", purCategoryStr);
            }
            if(projectNoStr !="")
            {
                sqlStr += string.Format(" and ProjectNo='{0}'", projectNoStr);
            }
            if (reqStateInt != 0)
            {
                sqlStr += string.Format(" and ReqState={0}", reqStateInt);
            }
            if (codeFileNameStr != "")
            {
                sqlStr += string.Format(" and CodeFileName='{0}'", codeFileNameStr);
            }
            if (commonStr != "")
            {
                sqlStr += string.Format(" and (PrReqNo like '%{0}%' or ProjectNo like '%{0}%' or StnNo like '%{0}%' or PrReqListRemark like '%{0}%')", commonStr);
            }
            sqlStr = string.Format("select * from V_PUR_PrReqList_Overplus where {0} order by AutoId", sqlStr);
            return sqlStr;
        }

        /// <summary>
        /// 请购与采购查询的SQL
        /// </summary>
        public string Query_PrReqListAndOrderList(string beginDateStr, string endDateStr, string reqDepStr, string purCategoryStr, string projectNoStr, int reqStateInt, string codeFileNameStr, string commonStr)
        {
            string sqlStr = " 1=1";
            if (beginDateStr != "")
            {
                sqlStr += string.Format(" and ReqDate between '{0}' and '{1}'", beginDateStr, endDateStr);
            }
            if (reqDepStr != "")
            {
                sqlStr += string.Format(" and ReqDep='{0}'", reqDepStr);
            }
            if (purCategoryStr != "")
            {
                sqlStr += string.Format(" and PurCategory='{0}'", purCategoryStr);
            }
            if (projectNoStr != "")
            {
                sqlStr += string.Format(" and ProjectNo='{0}'", projectNoStr);
            }
            if (reqStateInt != 0)
            {
                sqlStr += string.Format(" and ReqState={0}", reqStateInt);
            }
            if (codeFileNameStr != "")
            {
                sqlStr += string.Format(" and CodeFileName='{0}'", codeFileNameStr);
            }
            if (commonStr != "")
            {
                sqlStr += string.Format(" and (PrReqNo like '%{0}%' or ProjectNo like '%{0}%' or StnNo like '%{0}%' or PrReqListRemark like '%{0}%')", commonStr);
            }
            sqlStr = string.Format("select * from V_PUR_PrReqListAndOrderList where {0} order by AutoId", sqlStr);
            return sqlStr;
        }
    }
}
