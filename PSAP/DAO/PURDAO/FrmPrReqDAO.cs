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
        /// <returns></returns>
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
        /// <returns></returns>
        public DataTable QueryPurCategory(bool addAllItem)
        {
            string sqlStr = "select AutoId, PurCategory, PurCategoryText from PUR_PurCategory order by AutoId";
            if(addAllItem)
            {
                sqlStr = "select 0 as AutoId, '' as PurCategory, '全部' as PurCategoryText union " + sqlStr;
            }
            return BaseSQL.GetTableBySql(sqlStr);
        }

        /// <summary>
        /// 查询操作员信息
        /// </summary>
        /// <returns></returns>
        public DataTable QueryUserInfo()
        {
            string sqlStr = "select 0 as AutoId, '全部' as LoginId, '全部' as EmpName union select AutoId, LoginId, EmpName from BS_UserInfo order by AutoId";
            return BaseSQL.GetTableBySql(sqlStr);
        }

        /// <summary>
        /// 查询物料信息表
        /// </summary>
        /// <returns></returns>
        public DataTable QueryPartsCode()
        {
            string sqlStr = "select AutoId, CodeNo, CodeFileName, CodeName from SW_PartsCode order by AutoId";
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
        /// <param name="queryDataTable"></param>
        /// <param name="beginDate"></param>
        /// <param name="endDate"></param>
        /// <param name="reqDepStr"></param>
        /// <param name="purCategoryStr"></param>
        public void QueryPrReqHead(DataTable queryDataTable, DateTime beginDate, DateTime endDate, string reqDepStr, string purCategoryStr, int reqStateInt,string applicantStr,string commonStr, bool nullTable)
        {
            string sqlStr = string.Format(" ReqDate between '{0}' and '{1}'", beginDate.ToString("yyyy-MM-dd"), endDate.AddDays(1).ToString("yyyy-MM-dd"));
            if (reqDepStr != "")
            {
                sqlStr += string.Format(" and ReqDep='{0}'", reqDepStr);
                //sqlStr += string.Format(" and {0}", GetDepartmentNoSQL_AllChild("ReqDep", reqDepStr));
            }
            if (purCategoryStr != "")
            {
                sqlStr += string.Format(" and PurCategory='{0}'", purCategoryStr);
            }
            if(reqStateInt!=0)
            {
                sqlStr += string.Format(" and ReqState={0}", reqStateInt);
            }
            if(applicantStr!="")
            {
                sqlStr += string.Format(" and Applicant='{0}'", applicantStr);
            }
            if(commonStr!="")
            {
                sqlStr += string.Format(" and (PrReqNo like '%{0}%' or ProjectNo like '%{0}%' or StnNo like '%{0}%' or PrReqRemark like '%{0}%')", commonStr);
            }
            if (nullTable)
            {
                sqlStr += " and 1=2";
            }
            sqlStr = string.Format("select * from PUR_PrReqHead where {0} order by AutoId", sqlStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 查询采购请购单明细表
        /// </summary>
        /// <param name="queryDataTable"></param>
        /// <param name="prReqNoStr"></param>
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
        /// <param name="prReqNoStr"></param>
        public void DeletePrReq(string prReqNoStr)
        {
            System.Collections.ArrayList sqlList = new System.Collections.ArrayList();
            sqlList.Add(string.Format("Delete from PUR_PrReqList where PrReqNo='{0}'", prReqNoStr));
            sqlList.Add(string.Format("Delete from PUR_PrReqHead where PrReqNo='{0}'", prReqNoStr));            

            BaseSQL.ExecuteSqlTran(sqlList);
        }

        /// <summary>
        /// 保存请购单
        /// </summary>
        /// <param name="prReqHeadRow"></param>
        /// <param name="prReqListTable"></param>
        public void SavePrReq(DataRow prReqHeadRow,DataTable prReqListTable)
        {
            if(prReqHeadRow["PrReqNo"].ToString()=="")//新增
            {
                string prReqNo = GetMaxOrderNo("PUR_PrReqHead", "PrReqNo", "PR", 11);
                prReqHeadRow["PrReqNo"] = prReqNo;                
                prReqHeadRow["ApplicantIp"] = SystemInfo.HostIpAddress;
                prReqHeadRow["ApplicantTime"] = BaseSQL.GetServerDateTime();

                # region 直接使用Update更新表，不要Sql更新 暂时注释

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

                for (int i=0;i< prReqListTable.Rows.Count;i++)
                {
                    prReqListTable.Rows[i]["PrReqNo"] = prReqNo;
                }
            }
            else//修改
            {
                prReqHeadRow["Modifier"] = SystemInfo.user.EmpName;
                prReqHeadRow["ModifierIp"] = SystemInfo.HostIpAddress;
                prReqHeadRow["ModifierTime"] = BaseSQL.GetServerDateTime();
            }

            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        //RecordLog_DataTable("采购请购单",prReqHeadRow.Table, "PrReqNo");

                        SqlCommand cmd = new SqlCommand("",conn, trans);
                        cmd.CommandText= "select * from PUR_PrReqHead where 1=2";
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
                    }
                    catch(Exception ex)
                    {
                        trans.Rollback();
                        prReqHeadRow.Table.RejectChanges();
                        prReqListTable.RejectChanges();
                        throw ex;
                    }
                }
            }
        }

        /// <summary>
        /// 审批请购单
        /// </summary>
        /// <param name="prReqHeadRow"></param>
        public void ApprovePrReq(DataRow prReqHeadRow)
        {
            prReqHeadRow["Approver"] = SystemInfo.user.EmpName;
            prReqHeadRow["ApproverIp"] = SystemInfo.HostIpAddress;
            prReqHeadRow["ApproverTime"] = BaseSQL.GetServerDateTime();
            prReqHeadRow["ReqState"] = 2;

            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);
                        cmd.CommandText = "select * from PUR_PrReqHead where 1=2";
                        SqlDataAdapter adapterHead = new SqlDataAdapter(cmd);
                        DataTable tmpHeadTable = new DataTable();
                        adapterHead.Fill(tmpHeadTable);
                        BaseSQL.UpdateDataTable(adapterHead, prReqHeadRow.Table);
                        
                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        prReqHeadRow.Table.RejectChanges();
                        throw ex;
                    }
                }
            }
        }

        /// <summary>
        /// 得到订单最大的编号
        /// </summary>
        /// <param name="tableName">数据表名</param>
        /// <param name="columnName">数据列名</param>
        /// <param name="headCharacter">头字母</param>
        /// <param name="numberLong">后数字的长度</param>
        /// <returns></returns>
        public string GetMaxOrderNo(string tableName, string columnName, string headCharacter, int numberLong)
        {
            string sqlStr = string.Format("select max({1}) from {0}", tableName, columnName);
            string maxNo = DataTypeConvert.GetString(BaseSQL.GetSingle(sqlStr));
            if (string.IsNullOrEmpty(maxNo))
            {
                maxNo = headCharacter + "1".PadLeft(numberLong, '0');
                return maxNo;
            }
            else
            {
                int number = DataTypeConvert.GetInt(maxNo.Replace(headCharacter, ""));
                maxNo = headCharacter + (number + 1).ToString().PadLeft(numberLong, '0');
                return maxNo;
            }
        }

        /// <summary>
        /// 记录绑定的DataTable里面变化的数据的日志
        /// </summary>
        /// <param name="tableCaption"></param>
        /// <param name="dataTable_NoHandle"></param>
        /// <param name="primaryKeyColumn"></param>
        public void RecordLog_DataTable(string tableCaption, DataTable dataTable_NoHandle,string primaryKeyColumn)
        {
            string logStr = "";
            string typeStr = "";
            string pkCaption = "";
            string pkValue = "";
            for (int i = 0; i < dataTable_NoHandle.Rows.Count; i++)
            {
                DataRow dr = dataTable_NoHandle.Rows[i];
                if (dr.RowState == DataRowState.Added)
                {
                    for (int j = 0; j < dataTable_NoHandle.Columns.Count; j++)
                    {
                        if(dataTable_NoHandle.Columns[j].ColumnName==primaryKeyColumn)
                        {
                            pkCaption = dataTable_NoHandle.Columns[j].Caption;
                            pkValue= DataTypeConvert.GetString(dr[j]);
                            continue;
                        }
                        string tmpValue = DataTypeConvert.GetString(dr[j]);
                        if (tmpValue != "")
                            logStr += string.Format("{0}的值为[{1}]，", dataTable_NoHandle.Columns[j].Caption, tmpValue);
                    }
                    typeStr = "新增";
                }
                else if (dr.RowState == DataRowState.Modified)
                {
                    for (int j = 0; j < dataTable_NoHandle.Columns.Count; j++)
                    {
                        if (dataTable_NoHandle.Columns[j].ColumnName == primaryKeyColumn)
                        {
                            pkCaption = dataTable_NoHandle.Columns[j].Caption;
                            pkValue = DataTypeConvert.GetString(dr[j]);
                            continue;
                        }

                        string oldValue = DataTypeConvert.GetString(dr[j, DataRowVersion.Original]);
                        string newValue = DataTypeConvert.GetString(dr[j, DataRowVersion.Current]);
                        if (oldValue != newValue)
                            logStr += string.Format("{0}的值由[{1}]变为[{2}]，", dataTable_NoHandle.Columns[j].Caption, oldValue, newValue);
                    }
                    typeStr = "修改";
                }
                else if (dr.RowState == DataRowState.Deleted)
                {
                    for (int j = 0; j < dataTable_NoHandle.Columns.Count; j++)
                    {
                        if (dataTable_NoHandle.Columns[j].ColumnName == primaryKeyColumn)
                        {
                            pkCaption = dataTable_NoHandle.Columns[j].Caption;
                            pkValue = DataTypeConvert.GetString(dr[j]);
                            continue;
                        }

                        string tmpValue = DataTypeConvert.GetString(dr[j]);
                        if (tmpValue != "")
                            logStr += string.Format("{0}的原值为[{1}]，", dataTable_NoHandle.Columns[j].Caption, tmpValue);
                    }
                    typeStr = "删除";
                }
            }
            MessageHandler.ShowMessageBox(string.Format("对[{0}]表进行{1}操作：主键[{2}]的值为[{3}]，{4}", tableCaption, typeStr, pkCaption,pkValue, logStr));
        }


    }
}
