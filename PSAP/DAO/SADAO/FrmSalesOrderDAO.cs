using PSAP.DAO.BSDAO;
using PSAP.PSAPCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace PSAP.DAO.SADAO
{
    class FrmSalesOrderDAO
    {
        /// <summary>
        /// 按照销售订单号查询销售订单
        /// </summary>
        public void QuerySalesOrder(DataTable queryDataTable, string autoSalesOrderNoStr)
        {
            string sqlStr = string.Format("select top 1 * from SA_SalesOrder where AutoSalesOrderNo = '{0}'", autoSalesOrderNoStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 查找数据库中最后一条销售订单
        /// </summary>
        public void QuerySalesOrder_LastOne(DataTable queryDataTable)
        {
            string sqlStr = string.Format("select top 1 * from SA_SalesOrder order by AutoId desc");
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 查询当前的前一条销售订单
        /// </summary>
        public void QuerySalesOrder_UpOne(DataTable queryDataTable, int autoIdInt)
        {
            string sqlStr = string.Format("select top 1 * from SA_SalesOrder where AutoId < {0} order by AutoId desc", autoIdInt);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 查询当前的后一条销售订单
        /// </summary>
        public void QuerySalesOrder_DownOne(DataTable queryDataTable, int autoIdInt)
        {
            string sqlStr = string.Format("select top 1 * from SA_SalesOrder where AutoId > {0} order by AutoId", autoIdInt);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 查询当前的销售订单
        /// </summary>
        public void QuerySalesOrder_One(DataTable queryDataTable, int autoIdInt)
        {
            string sqlStr = string.Format("select top 1 * from SA_SalesOrder where AutoId = {0}", autoIdInt);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 保存销售订单
        /// </summary>
        public int SaveSalesOrder(DataRow headRow)
        {
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);

                        string autoQuotationNoStr = DataTypeConvert.GetString(headRow["AutoQuotationNo"]);
                        cmd.CommandText = string.Format("select Count(*) from SA_QuotationBaseInfo where AutoQuotationNo = '{0}'", autoQuotationNoStr);
                        if (DataTypeConvert.GetInt(cmd.ExecuteScalar()) < 1)
                        {
                            MessageHandler.ShowMessageBox(string.Format("报价单[{0}]未查询到，请查询后重新操作。", autoQuotationNoStr));
                            return 0;
                        }

                        //判断当前报价单版本的金额是否被多张销售订单的合计金额超过
                        string versionsStr = DataTypeConvert.GetString(headRow["QuotationVersions"]);
                        cmd.CommandText = string.Format("select Amount from SA_QuotationPriceInfo where AutoQuotationNo = '{0}' and Versions = '{1}'", autoQuotationNoStr, versionsStr);
                        decimal versionAmount = DataTypeConvert.GetDecimal(cmd.ExecuteScalar());
                        cmd.CommandText = string.Format("select IsNull(Sum(Amount), 0) from SA_SalesOrder where AutoQuotationNo = '{0}' and AutoSalesOrderNo != '{1}' and QuotationVersions = '{2}'", autoQuotationNoStr, DataTypeConvert.GetString(headRow["AutoSalesOrderNo"]), versionsStr);
                        decimal otherSOAmount = DataTypeConvert.GetDecimal(cmd.ExecuteScalar());
                        decimal soAmount = DataTypeConvert.GetDecimal(headRow["Amount"]);
                        if (versionAmount < soAmount + otherSOAmount)
                        {
                            MessageHandler.ShowMessageBox(string.Format("多张销售订单的合计金额[{0}]大于报价单版本的金额[{1}]，请重新操作。", soAmount + otherSOAmount, versionAmount));
                            return 0;
                        }


                        //DateTime nowTime = BaseSQL.GetServerDateTime();
                        if (headRow.RowState == DataRowState.Added)//新增
                        {
                            headRow["AutoSalesOrderNo"] = BaseSQL.GetMaxCodeNo(cmd, "SO");
                            headRow["PreparedIp"] = SystemInfo.HostIpAddress;
                        }
                        else//修改
                        {
                            string autoSalesOrderNoStr = DataTypeConvert.GetString(headRow["AutoSalesOrderNo"]);
                            if (CheckSalesOrder_IsSettleAccounts(cmd, autoSalesOrderNoStr))
                            {
                                headRow.Table.RejectChanges();
                                return 1;
                            }

                            headRow["Modifier"] = SystemInfo.user.EmpName;
                            headRow["ModifierIp"] = SystemInfo.HostIpAddress;
                            headRow["ModifierTime"] = BaseSQL.GetServerDateTime();
                        }

                        //保存日志到日志表中
                        string logStr = LogHandler.RecordLog_DataRow(cmd, "销售订单信息", headRow, "AutoSalesOrderNo");

                        cmd.CommandText = "select * from SA_SalesOrder where 1=2";
                        SqlDataAdapter adapterHead = new SqlDataAdapter(cmd);
                        DataTable tmpHeadTable = new DataTable();
                        adapterHead.Fill(tmpHeadTable);
                        BaseSQL.UpdateDataTable(adapterHead, headRow.Table);

                        trans.Commit();

                        return 1;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        headRow.Table.RejectChanges();
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
        /// 删除销售订单
        /// </summary>
        public bool DeleteSalesOrder(string autoSalesOrderNoStr)
        {
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);

                        if (CheckSalesOrder_IsSettleAccounts(cmd, autoSalesOrderNoStr))
                        {
                            return false;
                        }

                        cmd.CommandText = string.Format("select * from SA_SalesOrder where AutoSalesOrderNo = '{0}'", autoSalesOrderNoStr);
                        DataTable tmpTable = new DataTable();
                        SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                        adpt.Fill(tmpTable);

                        if (tmpTable.Rows.Count > 0)
                        {
                            //保存日志到日志表中
                            string logStr = LogHandler.RecordLog_DeleteRow(cmd, "销售订单", tmpTable.Rows[0], "AutoSalesOrderNo");
                        }

                        cmd.CommandText = string.Format("Delete from SA_SalesOrder where AutoQuotationNo = '{0}'", autoSalesOrderNoStr);
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
        /// <param name="autoSalesOrderNoStr">报价单号</param>
        /// <param name="handleTypeInt">打印处理类型：1 预览 2 打印 3 设计</param>
        public void PrintHandle(string autoSalesOrderNoStr, int handleTypeInt)
        {
            DataSet ds = new DataSet();
            DataTable headTable = BaseSQL.GetTableBySql(string.Format("select * from V_Prn_SA_SalesOrder where AutoSalesOrderNo = '{0}' order by AutoId", autoSalesOrderNoStr));
            headTable.TableName = "SalesOrder";
            for (int i = 0; i < headTable.Columns.Count; i++)
            {
                #region 设定主表显示的标题

                switch (headTable.Columns[i].ColumnName)
                {
                    case "AutoSalesOrderNo":
                        headTable.Columns[i].Caption = "销售订单号";
                        break;
                    case "SalesOrderDate":
                        headTable.Columns[i].Caption = "登记日期";
                        break;
                    case "ProjectNo":
                        headTable.Columns[i].Caption = "项目号";
                        break;
                    case "ProjectName":
                        headTable.Columns[i].Caption = "项目名称";
                        break;
                    case "ParentAutoSalesOrderNo":
                        headTable.Columns[i].Caption = "父级销售订单号";
                        break;
                    case "ParentProjectNo":
                        headTable.Columns[i].Caption = "父级项目号";
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
                    case "CustomerPoNo":
                        headTable.Columns[i].Caption = "客户PO号";
                        break;
                    case "CollectionTypeNo":
                        headTable.Columns[i].Caption = "收款方式编号";
                        break;
                    case "CollectionTypeNoText":
                        headTable.Columns[i].Caption = "收款方式名称";
                        break;
                    case "Amount":
                        headTable.Columns[i].Caption = "金额";
                        break;
                    case "Tax":
                        headTable.Columns[i].Caption = "税率";
                        break;
                    case "TaxAmount":
                        headTable.Columns[i].Caption = "税额";
                        break;
                    case "SumAmount":
                        headTable.Columns[i].Caption = "价税合计";
                        break;
                    case "ProjectLeader":
                        headTable.Columns[i].Caption = "项目负责人";
                        break;
                    case "IsEnd":
                        headTable.Columns[i].Caption = "结账完毕";
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
                    case "AutoQuotationNo":
                        headTable.Columns[i].Caption = "报价单号";
                        break;
                    case "QuotationVersions":
                        headTable.Columns[i].Caption = "报价单版本";
                        break;
                }

                #endregion
            }
            ds.Tables.Add(headTable);            

            ReportHandler rptHandler = new ReportHandler();
            List<DevExpress.XtraReports.Parameters.Parameter> paralist = rptHandler.GetSystemInfo_ParamList();
            rptHandler.XtraReport_Handle("SA_SalesOrder", ds, paralist, handleTypeInt);
        }

        /// <summary>
        /// 查询未结账得销售订单
        /// </summary>
        public void QuerySalesOrder_NoIsEnd(DataTable queryDataTable, string soDateBeginStr, string soDateEndStr, string bussinessBaseNoStr, string commonStr)
        {
            //string sqlStr = " IsNull(IsEnd, 0)=0";
            //if (autoSalesOrderNoStr != "")
            //{
            //    sqlStr += string.Format(" and AutoSalesOrderNo like '%{0}%'", autoSalesOrderNoStr);
            //}
            //if (soDateBeginStr != "")
            //{
            //    sqlStr += string.Format(" and SalesOrderDate between '{0}' and '{1}'", soDateBeginStr, soDateEndStr);
            //}
            //if (bussinessBaseNoStr != "")
            //{
            //    sqlStr += string.Format(" and BussinessBaseNo = '{0}'", bussinessBaseNoStr);
            //}
            //sqlStr = string.Format("select *, (Select IsNull(Sum(Amount), 0) from SA_SettleAccountsList where SA_SettleAccountsList.AutoSalesOrderNo = SA_SalesOrder.AutoSalesOrderNo) as SettleAmount, Amount - (Select IsNull(Sum(Amount), 0) from SA_SettleAccountsList where SA_SettleAccountsList.AutoSalesOrderNo = SA_SalesOrder.AutoSalesOrderNo) as NoSettleAmount from SA_SalesOrder where {0} order by AutoId", sqlStr);
            string sqlStr = QuerySalesOrder_NoSettle_SQL(soDateBeginStr, soDateEndStr, bussinessBaseNoStr, "", "", commonStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 查询销售订单SQL
        /// </summary>
        public string QuerySalesOrder_SQL(string soDateBeginStr, string soDateEndStr, string bussinessBaseNoStr, string projectNoStr, string preparedStr, string commonStr)
        {
            string sqlStr = " 1=1";
            if (soDateBeginStr != "")
            {
                sqlStr += string.Format(" and SalesOrderDate between '{0}' and '{1}'", soDateBeginStr, soDateEndStr);
            }
            if (bussinessBaseNoStr != "")
            {
                sqlStr += string.Format(" and BussinessBaseNo = '{0}'", bussinessBaseNoStr);
            }
            if (projectNoStr != "")
            {
                sqlStr += string.Format(" and ProjectNo = '{0}'", projectNoStr);
            }
            if (preparedStr != "")
            {
                sqlStr += string.Format(" and Prepared = '{0}'", preparedStr);
            }
            if (commonStr != "")
            {
                sqlStr += string.Format(" and (AutoSalesOrderNo like '%{0}%' or ProjectName like '%{0}%' or AutoQuotationNo like '%{0}%' or CustomerPoNo like '%{0}%' or CollectionTypeNo like '%{0}%' or ProjectLeader like '%{0}%' or Remark like '%{0}%')", commonStr);
            }

            sqlStr = string.Format("select * from SA_SalesOrder where {0} order by AutoId", sqlStr);
            return sqlStr;
        }

        public void QuerySalesOrder(DataTable queryDataTable, string soDateBeginStr, string soDateEndStr, string bussinessBaseNoStr, string projectNoStr, string preparedStr, string commonStr)
        {
            string sqlStr = QuerySalesOrder_SQL(soDateBeginStr, soDateEndStr, bussinessBaseNoStr, projectNoStr, preparedStr, commonStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 检查报价单是否有生成销售订单
        /// </summary>
        public bool CheckSalesOrder_IsSettleAccounts(SqlCommand cmd, string autoSalesOrderNoStr)
        {
            string sqlStr = string.Format("select Count(*) from SA_SettleAccountsList where AutoSalesOrderNo = '{0}'", autoSalesOrderNoStr);
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
                MessageHandler.ShowMessageBox(string.Format("销售订单[{0}]已经生成销售结账单，不可以再进行修改或者删除。", autoSalesOrderNoStr));
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// 查询未结账完的销售订单
        /// </summary>
        public string QuerySalesOrder_NoSettle_SQL(string soDateBeginStr, string soDateEndStr, string bussinessBaseNoStr, string projectNoStr, string preparedStr, string commonStr)
        {
            string sqlStr = " 1=1";
            if (soDateBeginStr != "")
            {
                sqlStr += string.Format(" and SalesOrderDate between '{0}' and '{1}'", soDateBeginStr, soDateEndStr);
            }
            if (bussinessBaseNoStr != "")
            {
                sqlStr += string.Format(" and BussinessBaseNo = '{0}'", bussinessBaseNoStr);
            }
            if (projectNoStr != "")
            {
                sqlStr += string.Format(" and ProjectNo = '{0}'", projectNoStr);
            }
            if (preparedStr != "")
            {
                sqlStr += string.Format(" and Prepared = '{0}'", preparedStr);
            }
            if (commonStr != "")
            {
                sqlStr += string.Format(" and (AutoSalesOrderNo like '%{0}%' or ProjectName like '%{0}%' or AutoQuotationNo like '%{0}%' or CustomerPoNo like '%{0}%' or CollectionTypeNo like '%{0}%' or ProjectLeader like '%{0}%' or Remark like '%{0}%')", commonStr);
            }

            sqlStr = string.Format("select *, (Amount - SettleAmount) as NoSettleAmount from V_SA_SalesOrder_NoSettle where {0} order by AutoId", sqlStr);
            return sqlStr;
        }
    }
}
