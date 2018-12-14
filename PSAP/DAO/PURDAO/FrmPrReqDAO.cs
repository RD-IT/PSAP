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
        /// <summary>
        /// 查询部门信息（增加一个全部选项）
        /// </summary>
        public DataTable QueryDepartment(bool addAllItem)
        {
            //string sqlStr = "select 0 as AutoId, '' as DepartmentNo, '全部' as DepartmentName union select AutoId, DepartmentNo, DepartmentName from BS_Department";
            string sqlStr = "select AutoId, DepartmentNo, DepartmentName from BS_Department where DepartmentNo not in (select IsNull(ParentDepartmentNo,'') from BS_Department) order by AutoId";
            if (addAllItem)
            {
                sqlStr = "select 0 as AutoId, '' as DepartmentNo, '全部' as DepartmentName union " + sqlStr;
            }
            return BaseSQL.GetTableBySql(sqlStr);
        }

        /// <summary>
        /// 查询采购类型（增加一个全部选项）
        /// </summary>
        public DataTable QueryPurCategory(bool addAllItem)
        {
            string sqlStr = "select AutoId, PurCategory, PurCategoryText from PUR_PurCategory order by AutoId";
            if (addAllItem)
            {
                sqlStr = "select 0 as AutoId, '' as PurCategory, '全部' as PurCategoryText union " + sqlStr;
            }
            return BaseSQL.GetTableBySql(sqlStr);
        }

        /// <summary>
        /// 查询操作员信息
        /// </summary>
        public DataTable QueryUserInfo()
        {
            string sqlStr = "select 0 as AutoId, '全部' as LoginId, '全部' as EmpName union select AutoId, LoginId, EmpName from BS_UserInfo order by AutoId";
            return BaseSQL.GetTableBySql(sqlStr);
        }

        /// <summary>
        /// 查询物料信息表
        /// </summary>
        public DataTable QueryPartsCode(bool addAllItem)
        {
            string sqlStr = "select AutoId, CodeFileName, CodeName from SW_PartsCode order by AutoId";
            if (addAllItem)
            {
                sqlStr = "select 0 as AutoId, '全部' as CodeFileName, '全部' as CodeName union " + sqlStr;
            }
            return BaseSQL.GetTableBySql(sqlStr);
        }

        /// <summary>
        /// 查询项目号列表
        /// </summary>
        public DataTable QueryProjectList(bool addAllItem)
        {
            string sqlStr = "select AutoId, ProjectNo, ProjectName, Remark from BS_ProjectList order by AutoId";
            if (addAllItem)
            {
                sqlStr = "select 0 as AutoId, '全部' as ProjectNo, '全部' as ProjectName, '全部' as Remark union " + sqlStr;
            }
            return BaseSQL.GetTableBySql(sqlStr);
        }

        /// <summary>
        /// 查询站号详细表
        /// </summary>
        /// <param name="projectNoStr">项目号</param>
        public DataTable QueryStnList(string projectNoStr)
        {
            string sqlStr = string.Format("select StnNo, ProjectNo, Remark from BS_StnList {0} order by AutoId", projectNoStr == "" ? " where 1=2" : (string.Format(" where ProjectNo='{0}'", projectNoStr)));
            return BaseSQL.GetTableBySql(sqlStr);
        }

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
        /// 查询采购请购单表头表
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
        public void QueryPrReqHead(DataTable queryDataTable, string beginDateStr, string endDateStr, string reqDepStr, string purCategoryStr, int reqStateInt, string applicantStr, string commonStr, bool nullTable)
        {
            BaseSQL.Query(QueryPrReqHead_SQL(beginDateStr, endDateStr, reqDepStr, purCategoryStr, reqStateInt, applicantStr, commonStr, nullTable), queryDataTable);
        }
        /// <summary>
        /// 查询采购请购单表头表的SQL
        /// </summary>
        public string QueryPrReqHead_SQL(string beginDateStr, string endDateStr, string reqDepStr, string purCategoryStr, int reqStateInt, string applicantStr, string commonStr, bool nullTable)
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
            if (nullTable)
            {
                sqlStr += " and 1=2";
            }
            sqlStr = string.Format("select * from PUR_PrReqHead where {0} order by AutoId", sqlStr);
            return sqlStr;
        }

        /// <summary>
        /// 统计要查询的SQL的数据的行数的SQL
        /// </summary>
        /// <param name="sqlStr">要查询的SQL</param>
        public string QuerySqlTranTotalCountSql(string sqlStr)
        {
            return string.Format("select Count(*) from ({0}) as tmpTable", sqlStr.Replace("order by AutoId", ""));
        }

        /// <summary>
        /// 查询采购请购单明细表
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
            if (!CheckReqState(prReqHeadRow.Table, null, string.Format("'{0}'", DataTypeConvert.GetString(prReqHeadRow["PrReqNo"])), true, true, false))
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
                        string logStr = LogHandler.RecordLog_DeleteRow(cmd, "采购请购单", prReqHeadRow, "PrReqNo");

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
            if (!CheckReqState(prReqHeadTable, null, prReqNoListStr, true, true, false))
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
                            string logStr = LogHandler.RecordLog_DeleteRow(cmd, "采购请购单", prReqHeadRows[i], "PrReqNo");
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
        /// <param name="prReqHeadRow">采购请购单表头数据表</param>
        /// <param name="prReqListTable">采购请购单明细数据表</param>
        public bool SavePrReq(DataRow prReqHeadRow, DataTable prReqListTable)
        {
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        //RecordLog_DataTable("采购请购单",prReqHeadRow.Table, "PrReqNo");
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
                            if (!CheckReqState(prReqHeadRow.Table, prReqListTable, string.Format("'{0}'", DataTypeConvert.GetString(prReqHeadRow["PrReqNo"])), true, true, false))
                                return false;

                            prReqHeadRow["Modifier"] = SystemInfo.user.EmpName;
                            prReqHeadRow["ModifierIp"] = SystemInfo.HostIpAddress;
                            prReqHeadRow["ModifierTime"] = BaseSQL.GetServerDateTime();
                        }

                        //保存日志到日志表中
                        string logStr = LogHandler.RecordLog_DataRow(cmd, "采购请购单", prReqHeadRow, "PrReqNo");

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
                        return true;
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
        /// <param name="prReqHeadRow">采购请购单表头数据行</param>
        public bool ApprovePrReq(DataRow prReqHeadRow)
        {
            if (!CheckReqState(prReqHeadRow.Table, null, string.Format("'{0}'", DataTypeConvert.GetString(prReqHeadRow["PrReqNo"])), true, true, false))
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
                        string logStr = LogHandler.RecordLog_OperateRow(cmd, "采购请购单", prReqHeadRow, "PrReqNo", "审批", SystemInfo.user.EmpName, serverTime.ToString("yyyy-MM-dd HH:mm:ss"));

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
            if (!CheckReqState(prReqHeadTable, null, prReqNoListStr, true, true, false))
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
                            string logStr = LogHandler.RecordLog_OperateRow(cmd, "采购请购单", prReqHeadRows[i], "PrReqNo", "审批", SystemInfo.user.EmpName, serverTime.ToString("yyyy-MM-dd HH:mm:ss"));
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
        /// <param name="prReqHeadRow">采购请购单表头数据行</param>
        public bool CancelApprovePrReq(DataRow prReqHeadRow)
        {
            if (!CheckReqState(prReqHeadRow.Table, null, string.Format("'{0}'", DataTypeConvert.GetString(prReqHeadRow["PrReqNo"])), false, true, true))
                return false;

            //检查是否有下级的采购订单
            if (!CheckApplyOrder(string.Format("'{0}'", DataTypeConvert.GetString(prReqHeadRow["PrReqNo"]))))
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
                        cmd.CommandText = string.Format("Update PUR_PrReqHead set ReqState={1}, Approver='{2}', ApproverIp='{3}', ApproverTime='{4}' where PrReqNo='{0}'", DataTypeConvert.GetString(prReqHeadRow["PrReqNo"]), 1, "", "", "");
                        cmd.ExecuteNonQuery();

                        //保存日志到日志表中
                        string logStr = LogHandler.RecordLog_OperateRow(cmd, "采购请购单", prReqHeadRow, "PrReqNo", "取消审批", SystemInfo.user.EmpName, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

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
            if (!CheckReqState(prReqHeadTable, null, prReqNoListStr, false, true, true))
                return false;

            if (!CheckApplyOrder(prReqNoListStr))//检查是否有下级的采购订单
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
                            string logStr = LogHandler.RecordLog_OperateRow(cmd, "采购请购单", prReqHeadRows[i], "PrReqNo", "取消审批", SystemInfo.user.EmpName, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
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
        /// <param name="prReqHeadRow">采购请购单表头数据行</param>
        public bool ClosePrReq(DataRow prReqHeadRow)
        {
            if (!CheckReqState(prReqHeadRow.Table, null, string.Format("'{0}'", DataTypeConvert.GetString(prReqHeadRow["PrReqNo"])), false, true, false))
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
                        string logStr = LogHandler.RecordLog_OperateRow(cmd, "采购请购单", prReqHeadRow, "PrReqNo", "关闭", SystemInfo.user.EmpName, serverTime.ToString("yyyy-MM-dd HH:mm:ss"));

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
            if (!CheckReqState(prReqHeadTable, null, prReqNoListStr, false, true, false))
                return false;

            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);
                        cmd.CommandText = string.Format("Update PUR_PrReqHead set ReqState={1}, Approver='{2}', ApproverIp='{3}', ApproverTime='{4}' where PrReqNo in ({0})", prReqNoListStr, 3, SystemInfo.user.EmpName, SystemInfo.HostIpAddress, serverTime.ToString("yyyy-MM-dd HH:mm:ss"));
                        cmd.ExecuteNonQuery();

                        //保存日志到日志表中
                        DataRow[] prReqHeadRows = prReqHeadTable.Select("select=1");
                        for (int i = 0; i < prReqHeadRows.Length; i++)
                        {
                            string logStr = LogHandler.RecordLog_OperateRow(cmd, "采购请购单", prReqHeadRows[i], "PrReqNo", "关闭", SystemInfo.user.EmpName, serverTime.ToString("yyyy-MM-dd HH:mm:ss"));
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
        public bool CheckReqState(DataTable prReqHeadTable, DataTable prReqListTable, string prReqNoListStr, bool checkApprover, bool checkClosed, bool checkNoApprover)
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
                            MessageHandler.ShowMessageBox(string.Format("采购请购单[{0}]未审核，不可以操作。",DataTypeConvert.GetString(tmpTable.Rows[i]["PrReqNo"])));
                            prReqHeadTable.RejectChanges();
                            if (prReqListTable != null)
                                prReqListTable.RejectChanges();
                            return false;
                        }
                        break;
                    case 2:
                        if (checkApprover)
                        {
                            MessageHandler.ShowMessageBox(string.Format("采购请购单[{0}]已经审核，不可以操作。", DataTypeConvert.GetString(tmpTable.Rows[i]["PrReqNo"])));
                            prReqHeadTable.RejectChanges();
                            if (prReqListTable != null)
                                prReqListTable.RejectChanges();
                            return false;
                        }
                        break;
                    case 3:
                        if (checkClosed)
                        {
                            MessageHandler.ShowMessageBox(string.Format("采购请购单[{0}]已经关闭，不可以操作。", DataTypeConvert.GetString(tmpTable.Rows[i]["PrReqNo"])));
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
        private bool CheckApplyOrder(string prReqNoListStr)
        {
            string sqlStr = string.Format("select Count(*) from PUR_OrderList where PrReqNo in ({0})", prReqNoListStr);
            if (DataTypeConvert.GetInt(BaseSQL.GetSingle(sqlStr)) > 0)
            {
                MessageHandler.ShowMessageBox("采购请购单已经有请购适用的记录，不可以操作。");
                return false;
            }
            return true;
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

    }
}
