using PSAP.DAO.BSDAO;
using PSAP.PSAPCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace PSAP.DAO.SADAO
{
    class FrmQuotationInfoDAO
    {
        /// <summary>
        /// 查询报价单
        /// </summary>
        public void QueryQuotationBaseInfo(DataTable queryDataTable, string beginDateStr, string endDateStr, string bussinessBaseNoStr, string preparedStr, string commonStr)
        {
            string sqlStr = QueryQuotationBaseInfo_SQL(beginDateStr, endDateStr, bussinessBaseNoStr, preparedStr, commonStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 查询报价单的SQL
        /// </summary>
        public string QueryQuotationBaseInfo_SQL(string beginDateStr, string endDateStr, string bussinessBaseNoStr, string preparedStr, string commonStr)
        {
            string sqlStr = " 1=1";
            if (beginDateStr != "")
            {
                sqlStr += string.Format(" and RecordDate between '{0}' and '{1}'", beginDateStr, endDateStr);
            }
            if (bussinessBaseNoStr != "")
            {
                sqlStr += string.Format(" and BussinessBaseNo='{0}'", bussinessBaseNoStr);
            }
            if (preparedStr != "")
            {
                sqlStr += string.Format(" and Prepared='{0}'", preparedStr);
            }
            if (commonStr != "")
            {
                sqlStr += string.Format(" and (AutoQuotationNo like '%{0}%' or RFQNO like '%{0}%' or Requester like '%{0}%' or Remark like '%{0}%' or ProjectName like '%{0}%')", commonStr);
            }
            
            sqlStr = string.Format("select * from SA_QuotationBaseInfo where {0} order by AutoId", sqlStr);
            return sqlStr;
        }

        /// <summary>
        /// 查询报价单的SQL
        /// </summary>
        public string QueryQuotationBaseInfoAndCor_SQL(string beginDateStr, string endDateStr, string bussinessBaseNoStr, string preparedStr, string commonStr, int qstateInt)
        {
            string sqlStr = " 1=1";
            if (beginDateStr != "")
            {
                sqlStr += string.Format(" and RecordDate between '{0}' and '{1}'", beginDateStr, endDateStr);
            }
            if (bussinessBaseNoStr != "")
            {
                sqlStr += string.Format(" and BussinessBaseNo='{0}'", bussinessBaseNoStr);
            }
            if (preparedStr != "")
            {
                sqlStr += string.Format(" and Prepared='{0}'", preparedStr);
            }
            if (commonStr != "")
            {
                sqlStr += string.Format(" and (AutoQuotationNo like '%{0}%' or RFQNO like '%{0}%' or Requester like '%{0}%' or Remark like '%{0}%' or ProjectName like '%{0}%' or ParentAutoQuotationNo like '%{0}%')", commonStr);
            }
            if(qstateInt > -1)
            {
                sqlStr += string.Format(" and QuotationState = {0}", qstateInt);
            }
            sqlStr = string.Format("select * from SA_QuotationBaseInfo where {0} order by AutoId", sqlStr);
            return sqlStr;
        }

        /// <summary>
        /// 查询未转销售订单的报价单
        /// </summary>
        public void QueryQuotationBaseInfo_NotInSalesOrder(DataTable queryDataTable, string beginDateStr, string endDateStr, string bussinessBaseNoStr, string preparedStr, string commonStr)
        {
            string sqlStr = " AutoQuotationNo not in (select AutoQuotationNo from SA_SalesOrder) and IsNull(QuotationState, 0) = 0";
            if (beginDateStr != "")
            {
                sqlStr += string.Format(" and RecordDate between '{0}' and '{1}'", beginDateStr, endDateStr);
            }
            if (bussinessBaseNoStr != "")
            {
                sqlStr += string.Format(" and BussinessBaseNo='{0}'", bussinessBaseNoStr);
            }
            if (preparedStr != "")
            {
                sqlStr += string.Format(" and Prepared='{0}'", preparedStr);
            }
            if (commonStr != "")
            {
                sqlStr += string.Format(" and (AutoQuotationNo like '%{0}%' or RFQNO like '%{0}%' or Requester like '%{0}%' or Remark like '%{0}%' or ProjectName like '%{0}%')", commonStr);
            }

            sqlStr = string.Format("select * from SA_QuotationBaseInfo where {0} order by AutoId", sqlStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 按照报价单号查询报价基本信息
        /// </summary>
        public void QueryQuotationBaseInfo(DataTable queryDataTable, string autoQuotationNoStr)
        {
            string sqlStr = string.Format("select top 1 * from SA_QuotationBaseInfo where AutoQuotationNo = '{0}'", autoQuotationNoStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 查找数据库中最后一条报价基本信息
        /// </summary>
        public void QueryQuotationBaseInfo_LastOne(DataTable queryDataTable)
        {
            string sqlStr = string.Format("select top 1 * from SA_QuotationBaseInfo order by AutoId desc");
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 查询当前的前一条报价基本信息
        /// </summary>
        public void QueryQuotationBaseInfo_UpOne(DataTable queryDataTable, int autoIdInt)
        {
            string sqlStr = string.Format("select top 1 * from SA_QuotationBaseInfo where AutoId < {0} order by AutoId desc", autoIdInt);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 查询当前的后一条报价基本信息
        /// </summary>
        public void QueryQuotationBaseInfo_DownOne(DataTable queryDataTable, int autoIdInt)
        {
            string sqlStr = string.Format("select top 1 * from SA_QuotationBaseInfo where AutoId > {0} order by AutoId", autoIdInt);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 查询当前的报价基本信息
        /// </summary>
        public void QueryQuotationBaseInfo_One(DataTable queryDataTable, int autoIdInt)
        {
            string sqlStr = string.Format("select top 1 * from SA_QuotationBaseInfo where AutoId = {0}", autoIdInt);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 按照报价单号查询报价单价格信息
        /// </summary>
        public void QueryQuotationPriceInfo(DataTable queryDataTable, string autoQuotationNoStr)
        {
            string sqlStr = string.Format("select * from SA_QuotationPriceInfo where AutoQuotationNo = '{0}'", autoQuotationNoStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 按照报价单号查询报价单的COR信息
        /// </summary>
        public void QueryQuotationCORInfo(DataTable queryDataTable, string autoQuotationNoStr)
        {
            string sqlStr = string.Format("select * from V_SA_QuotationCORInfo where ParentAutoQuotationNo = '{0}'", autoQuotationNoStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }
        
        /// <summary>
        /// 保存报价信息
        /// </summary>
        public int SaveQuotationInfo(DataRow headRow,DataTable listTable)
        {
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);

                        //DateTime nowTime = BaseSQL.GetServerDateTime();
                        if (headRow.RowState == DataRowState.Added)//新增
                        {
                            headRow["AutoQuotationNo"]= BaseSQL.GetMaxCodeNo(cmd, "QN");
                            headRow["PreparedIp"] = SystemInfo.HostIpAddress;
                            //headRow["RecordDate"] = nowTime;
                            for (int i = 0; i < listTable.Rows.Count; i++)
                            {
                                listTable.Rows[i]["AutoQuotationNo"] = headRow["AutoQuotationNo"];
                                //listTable.Rows[i]["QuotationDate"] = nowTime;
                            }
                        }
                        else//修改
                        {
                            string autoQuotationNoStr = DataTypeConvert.GetString(headRow["AutoQuotationNo"]);

                            if (!CheckState(headRow.Table, listTable, autoQuotationNoStr, false, true))
                                return -1;

                            if (CheckQuotationInfo_IsSalesOrder(cmd, autoQuotationNoStr))
                            {
                                headRow.Table.RejectChanges();
                                listTable.RejectChanges();
                                return -1;
                            }

                            //for (int i = 0; i < listTable.Rows.Count; i++)
                            //{
                            //    if (listTable.Rows[i].RowState == DataRowState.Deleted)
                            //        continue;
                            //    else if (listTable.Rows[i].RowState == DataRowState.Added)
                            //    {
                            //        listTable.Rows[i]["AutoQuotationNo"] = headRow["AutoQuotationNo"];
                            //        listTable.Rows[i]["QuotationDate"] = nowTime;
                            //    }
                            //}
                            headRow["Modifier"] = SystemInfo.user.EmpName;
                            headRow["ModifierIp"] = SystemInfo.HostIpAddress;
                            headRow["ModifierTime"] = BaseSQL.GetServerDateTime();
                        }

                        //保存日志到日志表中
                        string logStr = LogHandler.RecordLog_DataRow(cmd, "报价信息", headRow, "AutoQuotationNo");

                        cmd.CommandText = "select * from SA_QuotationBaseInfo where 1=2";
                        SqlDataAdapter adapterHead = new SqlDataAdapter(cmd);
                        DataTable tmpHeadTable = new DataTable();
                        adapterHead.Fill(tmpHeadTable);
                        BaseSQL.UpdateDataTable(adapterHead, headRow.Table);

                        cmd.CommandText = "select * from SA_QuotationPriceInfo where 1=2";
                        SqlDataAdapter adapterList = new SqlDataAdapter(cmd);
                        DataTable tmpListTable = new DataTable();
                        adapterList.Fill(tmpListTable);
                        BaseSQL.UpdateDataTable(adapterList, listTable);

                        trans.Commit();

                        return 1;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        headRow.Table.RejectChanges();
                        listTable.RejectChanges();
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
        /// 检测数据库中报价单状态是否可以操作
        /// </summary>
        public bool CheckState(DataTable quoHeadTable, DataTable quoListTable, string autoQuotationNoStr, bool check0, bool check1)
        {
            string sqlStr = string.Format("select AutoQuotationNo, QuotationState from SA_QuotationBaseInfo where AutoQuotationNo = '{0}'", autoQuotationNoStr);
            DataTable tmpTable = BaseSQL.Query(sqlStr).Tables[0];
            for (int i = 0; i < tmpTable.Rows.Count; i++)
            {
                int reqState = DataTypeConvert.GetInt(tmpTable.Rows[i]["QuotationState"]);
                switch (reqState)
                {
                    case 0:
                        if (check0)
                        {
                            MessageHandler.ShowMessageBox(string.Format("报价单[{0}]是正常状态，不可以操作。", autoQuotationNoStr));
                            if (quoHeadTable != null)
                                quoHeadTable.RejectChanges();
                            if (quoListTable != null)
                                quoListTable.RejectChanges();
                            return false;
                        }
                        break;
                    case 2:
                        if (check1)
                        {
                            MessageHandler.ShowMessageBox(string.Format("报价单[{0}]是关闭状态，不可以操作。", autoQuotationNoStr));
                            if (quoHeadTable != null)
                                quoHeadTable.RejectChanges();
                            if (quoListTable != null)
                                quoListTable.RejectChanges();
                            return false;
                        }
                        break;
                }
            }

            return true;
        }


        /// <summary>
        /// 删除报价信息
        /// </summary>
        public bool DeleteQuotationInfo(string autoQuotationNoStr)
        {
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);

                        if (!CheckState(null, null, autoQuotationNoStr, false, true))
                            return false;

                        if (CheckQuotationInfo_IsSalesOrder(cmd, autoQuotationNoStr))
                        {
                            return false;
                        }

                        cmd.CommandText = string.Format("select * from SA_QuotationBaseInfo where AutoQuotationNo = '{0}'", autoQuotationNoStr);
                        DataTable tmpTable = new DataTable();
                        SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                        adpt.Fill(tmpTable);

                        if (tmpTable.Rows.Count > 0)
                        {
                            //保存日志到日志表中
                            string logStr = LogHandler.RecordLog_DeleteRow(cmd, "报价单", tmpTable.Rows[0], "AutoQuotationNo");
                        }

                        cmd.CommandText = string.Format("Delete from SA_QuotationPriceInfo where AutoQuotationNo = '{0}'", autoQuotationNoStr);
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = string.Format("Delete from SA_QuotationBaseInfo where AutoQuotationNo = '{0}'", autoQuotationNoStr);
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
        /// 关闭报价单
        /// </summary>
        public void CloseQuotationInfo(DataRow headRow, string autoQuotationNoStr)
        {
            headRow["QuotationState"] = 1;
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);

                        if (!CheckState(null, null, autoQuotationNoStr, false, true))
                            return;

                        if (CheckQuotationInfo_IsSalesOrder(cmd, autoQuotationNoStr))
                        {
                            return;
                        }

                        LogHandler.RecordLog(cmd, string.Format("报价单[{0}]关闭", autoQuotationNoStr));

                        cmd.CommandText = string.Format("Update SA_QuotationBaseInfo set QuotationState = 1 where AutoQuotationNo = '{0}'", autoQuotationNoStr);
                        cmd.ExecuteNonQuery();

                        trans.Commit();
                        headRow.AcceptChanges();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        headRow.RejectChanges();
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
        /// 取消关闭报价单
        /// </summary>
        public void RecoverQuotationInfo(DataRow headRow, string autoQuotationNoStr)
        {
            headRow["QuotationState"] = 0;
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);

                        if (!CheckState(null, null, autoQuotationNoStr, false, true))
                            return;

                        if (CheckQuotationInfo_IsSalesOrder(cmd, autoQuotationNoStr))
                        {
                            return;
                        }

                        LogHandler.RecordLog(cmd, string.Format("报价单[{0}]取消关闭", autoQuotationNoStr));

                        cmd.CommandText = string.Format("Update SA_QuotationBaseInfo set QuotationState = 0 where AutoQuotationNo = '{0}'", autoQuotationNoStr);
                        cmd.ExecuteNonQuery();

                        trans.Commit();
                        headRow.AcceptChanges();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        headRow.RejectChanges();
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
        /// <param name="autoQuotationNoStr">报价单号</param>
        /// <param name="handleTypeInt">打印处理类型：1 预览 2 打印 3 设计</param>
        public void PrintHandle(string autoQuotationNoStr, int handleTypeInt)
        {
            DataSet ds = new DataSet();
            DataTable headTable = BaseSQL.GetTableBySql(string.Format("select * from V_Prn_SA_QuotationBaseInfo where AutoQuotationNo = '{0}' order by AutoId", autoQuotationNoStr));
            headTable.TableName = "QuotationBaseInfo";
            for (int i = 0; i < headTable.Columns.Count; i++)
            {
                #region 设定主表显示的标题

                switch (headTable.Columns[i].ColumnName)
                {
                    case "AutoQuotationNo":
                        headTable.Columns[i].Caption = "报价单号";
                        break;
                    case "RFQNO":
                        headTable.Columns[i].Caption = "手工单号";
                        break;
                    case "RecordDate":
                        headTable.Columns[i].Caption = "登记日期";
                        break;
                    case "Requester":
                        headTable.Columns[i].Caption = "客户需求人";
                        break;
                    case "Remark":
                        headTable.Columns[i].Caption = "备注";
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
                    case "ProjectName":
                        headTable.Columns[i].Caption = "项目名称";
                        break;
                    case "ParentAutoQuotationNo":
                        headTable.Columns[i].Caption = "父级报价单号";
                        break;
                    case "ParentAutoSalesOrderNo":
                        headTable.Columns[i].Caption = "父级销售订单号";
                        break;
                    case "ParentProjectNo":
                        headTable.Columns[i].Caption = "父级项目号";
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

            DataTable listTable = BaseSQL.GetTableBySql(string.Format("select *, ROW_NUMBER() over (order by AutoId) as RowNum from V_Prn_SA_QuotationPriceInfo where AutoQuotationNo = '{0}' order by AutoId", autoQuotationNoStr));
            listTable.TableName = "QuotationPriceInfo";
            for (int i = 0; i < listTable.Columns.Count; i++)
            {
                #region 设定子表显示的标题

                switch (listTable.Columns[i].ColumnName)
                {
                    case "RowNum":
                        listTable.Columns[i].Caption = "行号";
                        break;
                    case "AutoQuotationNo":
                        listTable.Columns[i].Caption = "报价单号";
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
                    case "Offerer":
                        listTable.Columns[i].Caption = "报价人";
                        break;
                    case "QuotationDate":
                        listTable.Columns[i].Caption = "报价日期";
                        break;
                    case "Versions":
                        listTable.Columns[i].Caption = "版本";
                        break;
                    case "Remark":
                        listTable.Columns[i].Caption = "备注";
                        break;
                    case "QuotationState":
                        listTable.Columns[i].Caption = "单据状态";
                        break;
                    case "StateDesc":
                        listTable.Columns[i].Caption = "单据状态描述";
                        break;
                    case "CurrencyCateAutoId":
                        listTable.Columns[i].Caption = "币种ID";
                        break;
                    case "CurrencyCateAbb":
                        listTable.Columns[i].Caption = "币种缩写";
                        break;
                    case "CurrencyCateName":
                        listTable.Columns[i].Caption = "币种名称";
                        break;
                    case "ExchangeRate":
                        listTable.Columns[i].Caption = "汇率";
                        break;                    
                }

                #endregion
            }
            ds.Tables.Add(listTable);

            ReportHandler rptHandler = new ReportHandler();
            List<DevExpress.XtraReports.Parameters.Parameter> paralist = rptHandler.GetSystemInfo_ParamList();
            rptHandler.XtraReport_Handle("SA_QuotationBaseInfo", ds, paralist, handleTypeInt);
        }

        /// <summary>
        /// 查询报价单明细的版本号
        /// </summary>
        public DataTable Query_QuotationPriceInfo_Versions(string autoQuotationNoStr)
        {
            string sqlStr = string.Format("select Versions, Amount, QuotationDate, Offerer from SA_QuotationPriceInfo where AutoQuotationNo = '{0}'", autoQuotationNoStr);
            return BaseSQL.GetTableBySql(sqlStr);
        }

        /// <summary>
        /// 查询报价单版本的价格信息
        /// </summary>
        public DataTable Query_Version_PriceInfo(string autoQuotationNoStr, string versionStr)
        {
            string sqlStr = string.Format("select AutoQuotationNo, Versions, Amount, Tax, TaxAmount, SumAmount from SA_QuotationPriceInfo where AutoQuotationNo = '{0}' and Versions = '{1}'", autoQuotationNoStr, versionStr);
            return BaseSQL.GetTableBySql(sqlStr);
        }

        /// <summary>
        /// 检查报价单是否有生成销售订单
        /// </summary>
        /// <returns></returns>
        public bool CheckQuotationInfo_IsSalesOrder(SqlCommand cmd, string autoQuotationNoStr)
        {
            string sqlStr = string.Format("select Count(*) from SA_SalesOrder where AutoQuotationNo = '{0}'", autoQuotationNoStr);
            int count = 0;
            if (cmd != null)
            {
                cmd.CommandText = sqlStr;
                count = DataTypeConvert.GetInt(cmd.ExecuteScalar());
            }
            else
                count = DataTypeConvert.GetInt(BaseSQL.GetSingle(sqlStr));
            if (count > 0)
            {
                MessageHandler.ShowMessageBox(string.Format("报价单[{0}]已经生成销售订单，不可以再进行修改、删除和关闭等操作。", autoQuotationNoStr));
                return true;
            }
            else
                return false;
        }
    }
}
