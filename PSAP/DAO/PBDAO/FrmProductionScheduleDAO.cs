using PSAP.DAO.BSDAO;
using PSAP.PSAPCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace PSAP.DAO.PBDAO
{
    class FrmProductionScheduleDAO
    {
        /// <summary>
        /// 查询生产计划单主表
        /// </summary>
        public void QueryProductionSchedule(DataTable queryDataTable, string beginDateStr, string endDateStr, string beginPlanDateStr, string endPlanDateStr, string codeFileNameStr, int psStateInt, string preparedStr, int approverInt, string commonStr, bool nullTable)
        {
            BaseSQL.Query(QueryProductionSchedule_SQL(beginDateStr, endDateStr, beginPlanDateStr, endPlanDateStr, codeFileNameStr, psStateInt, preparedStr, approverInt, commonStr, nullTable), queryDataTable);
        }

        /// <summary>
        /// 查询生产计划单主表的SQL
        /// </summary>
        public string QueryProductionSchedule_SQL(string beginDateStr, string endDateStr, string beginPlanDateStr, string endPlanDateStr, string codeFileNameStr, int psStateInt, string preparedStr, int approverInt, string commonStr, bool nullTable)
        {
            string sqlStr = " 1=1";
            if (beginDateStr != "")
            {
                sqlStr += string.Format(" and ps.CurrentDate between '{0}' and '{1}'", beginDateStr, endDateStr);
            }
            if (beginPlanDateStr != "")
            {
                sqlStr += string.Format(" and (ps.PlannedStarttime between '{0}' and '{1}' or ps.PlannedEndtime between '{0}' and '{1}' or (ps.PlannedStarttime <= '{0}' and ps.PlannedEndtime >= '{1}'))", beginPlanDateStr, endPlanDateStr);
            }
            if (codeFileNameStr != "")
            {
                sqlStr += string.Format(" and ps.CodeFileName = '{0}'", codeFileNameStr);
            }
            if (psStateInt != 0)
            {
                sqlStr += string.Format(" and ps.PsState={0}", psStateInt);
            }
            if (preparedStr != "")
            {
                sqlStr += string.Format(" and ps.Prepared='{0}'", preparedStr);
            }
            if (commonStr != "")
            {
                sqlStr += string.Format(" and (ps.PsNo like '%{0}%' or ps.Remark like '%{0}%')", commonStr);
            }
            if (nullTable)
            {
                sqlStr += " and 1=2";
            }
            if (approverInt >= 0)
            {
                if (approverInt == 0)
                    sqlStr += string.Format(" and ps.PsState in (1,4)");
                else
                {
                    //sqlStr = string.Format("select PUR_OrderHead.* from PUR_OrderHead left join PUR_ApprovalType on PUR_OrderHead.ApprovalType = PUR_ApprovalType.TypeNo where {0} and PUR_OrderHead.ReqState in (1, 4) and( (PUR_ApprovalType.ApprovalCat = 0 and exists (select * from (select top 1 * from F_OrderNoApprovalList(PUR_OrderHead.OrderHeadNo, PUR_OrderHead.ApprovalType) Order by AppSequence) as minlist where Approver = {1})) or (PUR_ApprovalType.ApprovalCat = 1 and exists (select * from F_OrderNoApprovalList(PUR_OrderHead.OrderHeadNo, PUR_OrderHead.ApprovalType) where Approver = {1}))) order by AutoId", sqlStr, approverInt);
                    return sqlStr;
                }
            }
            sqlStr = string.Format("select ps.*, pc.CodeName from PB_ProductionSchedule as ps left join SW_PartsCode as pc on ps.CodeFileName = pc.CodeFileName where {0} order by ps.AutoId", sqlStr);
            return sqlStr;
        }

        /// <summary>
        /// 查询生产计划单BOM信息
        /// </summary>
        public void QueryProductionScheduleBom(DataTable queryDataTable, string psNoStr, bool nullTable)
        {
            string sqlStr = string.Format(" and PsNo='{0}'", psNoStr);
            if (nullTable)
            {
                sqlStr += " and 1=2";
            }
            sqlStr = string.Format("select ps.*, pc.CodeName from PB_ProductionScheduleBom as ps left join SW_PartsCode as pc on ps.CodeFileName = pc.CodeFileName where 1=1 {0} order by ps.AutoId", sqlStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 保存生产计划单
        /// </summary>
        public int SaveProductionSchedule(DataRow headRow)
        {
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);

                        //if (!CheckPrReqApplyBeyondCount(cmd, DataTypeConvert.GetString(orderHeadRow["OrderHeadNo"]), orderListTable))
                        //{
                        //    return 0;
                        //}

                        if (DataTypeConvert.GetString(headRow["PsNo"]) == "")//新增
                        {
                            string orderHeadNo = BaseSQL.GetMaxCodeNo(cmd, "PN");
                            headRow["PsNo"] = orderHeadNo;
                            headRow["PreparedIp"] = SystemInfo.HostIpAddress;
                            headRow["GetTime"] = BaseSQL.GetServerDateTime();
                        }
                        else//修改
                        {
                            if (!CheckPSState(headRow.Table, string.Format("'{0}'", DataTypeConvert.GetString(headRow["PsNo"])), false, true, true, true))
                                return -1;

                            headRow["Modifier"] = SystemInfo.user.EmpName;
                            headRow["ModifierIp"] = SystemInfo.HostIpAddress;
                            headRow["ModifierTime"] = BaseSQL.GetServerDateTime();
                        }

                        //保存日志到日志表中
                        string logStr = LogHandler.RecordLog_DataRow(cmd, "生产计划单", headRow, "PsNo");

                        cmd.CommandText = "select * from PB_ProductionSchedule where 1=2";
                        SqlDataAdapter adapterHead = new SqlDataAdapter(cmd);
                        DataTable tmpHeadTable = new DataTable();
                        adapterHead.Fill(tmpHeadTable);
                        BaseSQL.UpdateDataTable(adapterHead, headRow.Table);

                        //Set_PrReqHead_End(cmd, orderListTable);

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
        /// 检测数据库中生产计划单状态是否可以操作
        /// </summary>
        public bool CheckPSState(DataTable headTable, string psNoListStr, bool checkNoApprover, bool checkApprover, bool checkClosed, bool checkApproverBetween)
        {
            string sqlStr = string.Format("select PsNo, PsState from PB_ProductionSchedule where PsNo in ({0})", psNoListStr);
            DataTable tmpTable = BaseSQL.Query(sqlStr).Tables[0];
            for (int i = 0; i < tmpTable.Rows.Count; i++)
            {
                int reqState = DataTypeConvert.GetInt(tmpTable.Rows[i]["PsState"]);
                switch (reqState)
                {
                    case 1:
                        if (checkNoApprover)
                        {
                            MessageHandler.ShowMessageBox(string.Format("生产计划单[{0}]未审批，不可以操作。", DataTypeConvert.GetString(tmpTable.Rows[i]["PsNo"])));
                            headTable.RejectChanges();
                            return false;
                        }
                        break;
                    case 2:
                        if (checkApprover)
                        {
                            MessageHandler.ShowMessageBox(string.Format("生产计划单[{0}]已经审批，不可以操作。", DataTypeConvert.GetString(tmpTable.Rows[i]["PsNo"])));
                            headTable.RejectChanges();
                            return false;
                        }
                        break;
                    case 3:
                        if (checkClosed)
                        {
                            MessageHandler.ShowMessageBox(string.Format("生产计划单[{0}]已经关闭，不可以操作。", DataTypeConvert.GetString(tmpTable.Rows[i]["PsNo"])));
                            headTable.RejectChanges();
                            return false;
                        }
                        break;
                    case 4:
                        if (checkApproverBetween)
                        {
                            MessageHandler.ShowMessageBox(string.Format("生产计划单[{0}]已经审批中，不可以操作。", DataTypeConvert.GetString(tmpTable.Rows[i]["PsNo"])));
                            headTable.RejectChanges();
                            return false;
                        }
                        break;
                }
            }

            return true;
        }

        /// <summary>
        /// 根据选择删除多条采购单
        /// </summary>
        public bool DeleteProductionSchedule_Multi(DataTable headTable)
        {
            string psNoListStr = "";
            for (int i = 0; i < headTable.Rows.Count; i++)
            {
                if (DataTypeConvert.GetBoolean(headTable.Rows[i]["Select"]))
                {
                    psNoListStr += string.Format("'{0}',", DataTypeConvert.GetString(headTable.Rows[i]["PsNo"]));
                }
            }
            psNoListStr = psNoListStr.Substring(0, psNoListStr.Length - 1);
            if (!CheckPSState(headTable, psNoListStr, false, true, true, true))
                return false;
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);
                        cmd.CommandText = string.Format("select * from PB_ProductionSchedule where PsNo in ({0})", psNoListStr);
                        DataTable tmpTable = new DataTable();
                        SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                        adpt.Fill(tmpTable);

                        //保存日志到日志表中
                        DataRow[] psHeadRows = headTable.Select("select=1");
                        for (int i = 0; i < psHeadRows.Length; i++)
                        {
                            string logStr = LogHandler.RecordLog_DeleteRow(cmd, "生产计划单", psHeadRows[i], "PsNo");
                        }

                        cmd.CommandText = string.Format("Delete from PB_ProductionScheduleBom where PsNo in ({0})", psNoListStr);
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = string.Format("Delete from PB_ProductionSchedule where PsNo in ({0})", psNoListStr);
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
        /// 审批选中的多条生产计划单
        /// </summary>
        public bool ApproveProductionSchedule_Multi(DataTable headTable, int saveTypeInt)
        {
            string psNoListStr = "";
            DateTime serverTime = BaseSQL.GetServerDateTime();
            for (int i = 0; i < headTable.Rows.Count; i++)
            {
                if (DataTypeConvert.GetBoolean(headTable.Rows[i]["Select"]))
                {
                    psNoListStr += string.Format("'{0}',", DataTypeConvert.GetString(headTable.Rows[i]["PsNo"]));
                    headTable.Rows[i]["PsState"] = 2;
                }
            }

            psNoListStr = psNoListStr.Substring(0, psNoListStr.Length - 1);
            if (!CheckPSState(headTable, psNoListStr, false, true, true, false))
                return false;

            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);
                        cmd.CommandText = string.Format("Update PB_ProductionSchedule set PsState={1} where PsNo in ({0})", psNoListStr, 2);
                        cmd.ExecuteNonQuery();

                        //保存日志到日志表中
                        DataRow[] headRows = headTable.Select("select=1");
                        for (int i = 0; i < headRows.Length; i++)
                        {
                            string logStr = LogHandler.RecordLog_OperateRow(cmd, "生产计划单", headRows[i], "PsNo", "审批", SystemInfo.user.EmpName, serverTime.ToString("yyyy-MM-dd HH:mm:ss"));

                            string psNoStr = DataTypeConvert.GetString(headRows[i]["PsNo"]);
                            string codeFileNameStr = DataTypeConvert.GetString(headRows[i]["CodeFileName"]);
                            int qtyInt = DataTypeConvert.GetInt(headRows[i]["PlannedQty"]);
                            //根据BOM的定义生成物料明细
                            if (saveTypeInt == 1)//保存BOM的第一级节点
                            {
                                cmd.CommandText = string.Format("insert into PB_ProductionScheduleBom (PsNo, CodeFileName, Qty, TotalQty) select '{1}', LevelMaterielNo, Qty, Qty * {2} from BS_BomMateriel where MaterielNo = '{0}'", codeFileNameStr, psNoStr, qtyInt);
                                cmd.ExecuteNonQuery();
                            }
                            else//保存BOM的最末节点
                            {
                                SqlCommand cmd_proc = new SqlCommand("", conn, trans);
                                string errorText = "";
                                if (!Update_ProductionScheduleBom(cmd_proc, psNoStr, out errorText))
                                {
                                    trans.Rollback();
                                    MessageHandler.ShowMessageBox("更新生产计划单BOM信息错误--" + errorText);
                                    return false;
                                }
                            }
                        }

                        trans.Commit();
                        headTable.AcceptChanges();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        headTable.RejectChanges();
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
        /// 更新生产计划单BOM信息
        /// </summary>
        public bool Update_ProductionScheduleBom(SqlCommand cmd, string psNoStr, out string errorText)
        {
            int resultInt = 0;
            SqlParameter p1 = new SqlParameter("@PsNo", SqlDbType.VarChar);
            p1.Value = psNoStr;
            IDataParameter[] parameters = new System.Data.IDataParameter[] { p1 };
            return BaseSQL.RunProcedure(cmd, "P_Update_ProductionScheduleBom", parameters, out resultInt, out errorText);
        }

        /// <summary>
        /// 取消审批选中的多条生产计划单
        /// </summary>
        public bool CancelApproveProductionSchedule_Multi(DataTable headTable)
        {
            string psNoListStr = "";
            for (int i = 0; i < headTable.Rows.Count; i++)
            {
                if (DataTypeConvert.GetBoolean(headTable.Rows[i]["Select"]))
                {
                    psNoListStr += string.Format("'{0}',", DataTypeConvert.GetString(headTable.Rows[i]["PsNo"]));
                    headTable.Rows[i]["PsState"] = 1;
                }
            }

            psNoListStr = psNoListStr.Substring(0, psNoListStr.Length - 1);
            if (!CheckPSState(headTable, psNoListStr, true, false, true, false))
                return false;

            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);
                        cmd.CommandText = string.Format("Update PB_ProductionSchedule set PsState={1} where PsNo in ({0})", psNoListStr, 1);
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = string.Format("Delete from PB_ProductionScheduleBom where PsNo in ({0})", psNoListStr);
                        cmd.ExecuteNonQuery();

                        DateTime serverTime = BaseSQL.GetServerDateTime();

                        //保存日志到日志表中
                        DataRow[] headRows = headTable.Select("select=1");
                        for (int i = 0; i < headRows.Length; i++)
                        {
                            ////检查是否有下级的入库单
                            //if (CheckApplyWarehouseWarrant(cmd, DataTypeConvert.GetString(orderHeadRows[i]["OrderHeadNo"])))
                            //{
                            //    trans.Rollback();
                            //    headTable.RejectChanges();
                            //    //MessageHandler.ShowMessageBox("采购订单已经有适用的入库单记录，不可以操作。");
                            //    MessageHandler.ShowMessageBox(f.tsmiCgddyj.Text);
                            //    return false;
                            //}

                            string logStr = LogHandler.RecordLog_OperateRow(cmd, "生产计划单", headRows[i], "PsNo", "取消审批", SystemInfo.user.EmpName, serverTime.ToString("yyyy-MM-dd HH:mm:ss"));
                        }

                        trans.Commit();
                        headTable.AcceptChanges();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        headTable.RejectChanges();
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
        /// <param name="psNoStr">生产计划单号</param>
        /// <param name="handleTypeInt">打印处理类型：1 预览 2 打印 3 设计</param>
        public void PrintHandle(string psNoStr, int handleTypeInt)
        {
            DataSet ds = new DataSet();
            DataTable headTable = BaseSQL.GetTableBySql(string.Format("select * from V_Prn_PB_ProductionSchedule where PsNo = '{0}' order by AutoId", psNoStr));
            headTable.TableName = "ProductionScheduleHead";
            for (int i = 0; i < headTable.Columns.Count; i++)
            {
                #region 设定主表显示的标题

                switch (headTable.Columns[i].ColumnName)
                {
                    case "PsNo":
                        headTable.Columns[i].Caption = "生产计划单号";
                        break;
                    case "SalesOrderNo":
                        headTable.Columns[i].Caption = "销售单号";
                        break;
                    case "CurrentDate":
                        headTable.Columns[i].Caption = "单据日期";
                        break;
                    case "ReqDate":
                        headTable.Columns[i].Caption = "需求日期";
                        break;                    
                    case "PlannedText":
                        headTable.Columns[i].Caption = "计划项";
                        break;
                    case "PsState":
                        headTable.Columns[i].Caption = "单据状态";
                        break;
                    case "PsStateDesc":
                        headTable.Columns[i].Caption = "单据状态描述";
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
                    case "Remark":
                        headTable.Columns[i].Caption = "备注";
                        break;
                    case "GetTime":
                        headTable.Columns[i].Caption = "数据插入时间";
                        break;
                }

                #endregion
            }
            ds.Tables.Add(headTable);

            DataTable listTable = BaseSQL.GetTableBySql(string.Format("select *, ROW_NUMBER() over (order by AutoId) as RowNum from V_Prn_PB_ProductionScheduleBomManage where PsNo = '{0}' order by AutoId", psNoStr));
            listTable.TableName = "ProductionScheduleBomList";
            for (int i = 0; i < listTable.Columns.Count; i++)
            {
                #region 设定子表显示的标题

                switch (listTable.Columns[i].ColumnName)
                {
                    case "RowNum":
                        listTable.Columns[i].Caption = "行号";
                        break;
                    case "PsNo":
                        listTable.Columns[i].Caption = "生产计划单号";
                        break;
                    case "SalesOrderNo":
                        listTable.Columns[i].Caption = "销售单号";
                        break;
                    case "PbBomNo":
                        listTable.Columns[i].Caption = "设计Bom编号";
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
                    case "GetTime":
                        listTable.Columns[i].Caption = "数据插入时间";
                        break;
                    case "PurQty":
                        listTable.Columns[i].Caption = "采购数量";
                        break;
                    case "HasLevel":
                        listTable.Columns[i].Caption = "是否有子节点";
                        break;
                    case "BomTypeName":
                        listTable.Columns[i].Caption = "类型名称";
                        break;
                }

                #endregion
            }
            ds.Tables.Add(listTable);

            ReportHandler rptHandler = new ReportHandler();
            List<DevExpress.XtraReports.Parameters.Parameter> paralist = rptHandler.GetSystemInfo_ParamList();
            rptHandler.XtraReport_Handle("PB_ProductionSchedule", ds, paralist, handleTypeInt);
        }



        /// <summary>
        /// 按照生产计划单号查询生产计划单
        /// </summary>
        public void QueryProductionSchedule(DataTable queryDataTable, string psNoStr)
        {
            string sqlStr = string.Format("select top 1 * from PB_ProductionSchedule where PsNo = '{0}'", psNoStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 查找数据库中最后一条生产计划单
        /// </summary>
        public void QueryProductionSchedule_LastOne(DataTable queryDataTable)
        {
            string sqlStr = string.Format("select top 1 * from PB_ProductionSchedule order by AutoId desc");
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 查询当前的前一条生产计划单
        /// </summary>
        public void QueryProductionSchedule_UpOne(DataTable queryDataTable, int autoIdInt)
        {
            string sqlStr = string.Format("select top 1 * from PB_ProductionSchedule where AutoId < {0} order by AutoId desc", autoIdInt);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 查询当前的后一条生产计划单
        /// </summary>
        public void QueryProductionSchedule_DownOne(DataTable queryDataTable, int autoIdInt)
        {
            string sqlStr = string.Format("select top 1 * from PB_ProductionSchedule where AutoId > {0} order by AutoId", autoIdInt);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 查询生产计划单的SQL
        /// </summary>
        public string QueryProductionSchedule_SQL(string beginDateStr, string endDateStr, string beginPlanDateStr, string endPlanDateStr, string preparedStr, string commonStr, bool nullTable)
        {
            string sqlStr = " 1=1";
            if (beginDateStr != "")
            {
                sqlStr += string.Format(" and CurrentDate between '{0}' and '{1}'", beginDateStr, endDateStr);
            }
            if (beginPlanDateStr != "")
            {
                sqlStr += string.Format(" and ReqDate between '{0}' and '{1}'", beginPlanDateStr, endPlanDateStr);
            }
            if (preparedStr != "")
            {
                sqlStr += string.Format(" and Prepared='{0}'", preparedStr);
            }
            if (commonStr != "")
            {
                sqlStr += string.Format(" and (SalesOrderNo like '%{0}%' or PsNo like '%{0}%' or PlannedText like '%{0}%' or Remark like '%{0}%')", commonStr);
            }
            if (nullTable)
            {
                sqlStr += " and 1=2";
            }
            sqlStr = string.Format("select * from PB_ProductionSchedule where {0} order by AutoId", sqlStr);
            return sqlStr;
        }

        /// <summary>
        /// 按照报价单号查询报价单价格信息
        /// </summary>
        public void QueryPSBom(DataTable queryDataTable, string psNoStr)
        {
            string sqlStr = string.Format("select * from V_PB_ProductionScheduleBom_Tree where PsNo = '{0}' order by AutoId", psNoStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 查询生产计划单
        /// </summary>
        public DataTable QueryPSBomManage_PbBomNo(string psNoStr)
        {
            string sqlStr = string.Format("select PbBomNo, PurQty from PB_ProductionScheduleBomManage where PsNo = '{0}'", psNoStr);
            return BaseSQL.Query(sqlStr).Tables[0];
        }

        /// <summary>
        /// 保存报价信息
        /// </summary>
        public int SaveProductionSchedule_Drag(DataRow headRow)
        {
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);

                        DateTime nowTime = BaseSQL.GetServerDateTime();
                        if (headRow.RowState == DataRowState.Added)//新增
                        {
                            headRow["PsNo"] = BaseSQL.GetMaxCodeNo(cmd, "PN");
                            headRow["PreparedIp"] = SystemInfo.HostIpAddress;
                            headRow["CurrentDate"] = nowTime;
                            headRow["GetTime"] = nowTime;
                        }
                        else//修改
                        {
                            string psNoStr = DataTypeConvert.GetString(headRow["PsNo"]);

                            if (!CheckState(headRow.Table, psNoStr, false, true))
                                return -1;

                            //if (CheckQuotationInfo_IsSalesOrder(cmd, psNoStr))
                            //{
                            //    headRow.Table.RejectChanges();
                            //    listTable.RejectChanges();
                            //    return -1;
                            //}

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
                        string logStr = LogHandler.RecordLog_DataRow(cmd, "生产计划单", headRow, "PsNo");

                        cmd.CommandText = "select * from PB_ProductionSchedule where 1=2";
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
        /// 检测数据库中报价单状态是否可以操作
        /// </summary>
        public bool CheckState(DataTable headTable, string psNoStr, bool check0, bool check1)
        {
            string sqlStr = string.Format("select PsNo, PsState from PB_ProductionSchedule where PsNo = '{0}'", psNoStr);
            DataTable tmpTable = BaseSQL.Query(sqlStr).Tables[0];
            for (int i = 0; i < tmpTable.Rows.Count; i++)
            {
                int reqState = DataTypeConvert.GetInt(tmpTable.Rows[i]["PsState"]);
                switch (reqState)
                {
                    case 1:
                        if (check0)
                        {
                            MessageHandler.ShowMessageBox(string.Format("生产计划单[{0}]是待审核状态，不可以操作。", psNoStr));
                            if (headTable != null)
                                headTable.RejectChanges();
                            return false;
                        }
                        break;
                    case 2:
                        if (check1)
                        {
                            MessageHandler.ShowMessageBox(string.Format("生产计划单[{0}]是审核状态，不可以操作。", psNoStr));
                            if (headTable != null)
                                headTable.RejectChanges();
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
        public bool DeleteProductionSchedule(string psNoStr)
        {
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);

                        if (!CheckState(null, psNoStr, false, true))
                            return false;

                        //if (CheckQuotationInfo_IsSalesOrder(cmd, psNoStr))
                        //{
                        //    return false;
                        //}

                        cmd.CommandText = string.Format("select * from PB_ProductionSchedule where PsNo = '{0}'", psNoStr);
                        DataTable tmpTable = new DataTable();
                        SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                        adpt.Fill(tmpTable);

                        if (tmpTable.Rows.Count > 0)
                        {
                            //保存日志到日志表中
                            string logStr = LogHandler.RecordLog_DeleteRow(cmd, "生产计划单", tmpTable.Rows[0], "PsNo");
                        }

                        //删除Bom信息的主从表
                        cmd.CommandText = string.Format("Delete from PB_ProductionScheduleBom where PsNo = '{0}'", psNoStr);
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = string.Format("Delete from PB_ProductionScheduleBomManage where PsNo = '{0}'", psNoStr);
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = string.Format("Delete from PB_ProductionSchedule where PsNo = '{0}'", psNoStr);
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
        /// 生产计划新增Bom信息
        /// </summary>
        public void ProductionSchedule_InsertBom(string psNoStr, List<string> pbBomNoList, DateTime reqDate, decimal purQty)
        {
            if (pbBomNoList.Count == 0)
                return;

            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);

                        int resultInt = 0;
                        string errorText = "";
                        foreach (string pbBomNoStr in pbBomNoList)
                        {
                            SqlCommand cmd_proc = new SqlCommand("", conn, trans);
                            SqlParameter p1 = new SqlParameter("@PbBomNo", SqlDbType.VarChar);
                            p1.Value = pbBomNoStr;
                            SqlParameter p2 = new SqlParameter("@PsNo", SqlDbType.VarChar);
                            p2.Value = psNoStr;
                            SqlParameter p3 = new SqlParameter("@ReqDate", SqlDbType.DateTime);
                            p3.Value = reqDate;
                            SqlParameter p4 = new SqlParameter("@PurQty", SqlDbType.Float);
                            p4.Value = purQty;
                            IDataParameter[] updateParas = new IDataParameter[] { p1, p2, p3, p4 };
                            BaseSQL.RunProcedure(cmd_proc, "P_PSBom_Insert", updateParas, out resultInt, out errorText);
                            if (resultInt != 1)
                            {
                                trans.Rollback();
                                MessageHandler.ShowMessageBox("新增生产计划Bom信息错误--" + errorText);
                                return;
                            }

                            string logStr = string.Format("生产计划单[{0}]增加Bom零件信息[{1}]，数量为[{2}]", psNoStr, pbBomNoStr, purQty);
                            LogHandler.RecordLog(cmd, logStr);
                        }
                        trans.Commit();

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

        ///// <summary>
        ///// 生产计划更新Bom信息数量    新增和更新数量改为调用一个存储过程
        ///// </summary>
        //public void ProductionSchedule_UpdateBomQty(string psNoStr, List<string> pbBomNoList, decimal purQty)
        //{
        //    using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
        //    {
        //        conn.Open();
        //        using (SqlTransaction trans = conn.BeginTransaction())
        //        {
        //            try
        //            {
        //                SqlCommand cmd = new SqlCommand("", conn, trans);

        //                int resultInt = 0;
        //                string errorText = "";
        //                foreach (string pbBomNoStr in pbBomNoList)
        //                {
        //                    SqlCommand cmd_proc = new SqlCommand("", conn, trans);
        //                    SqlParameter p1 = new SqlParameter("@PbBomNo", SqlDbType.VarChar);
        //                    p1.Value = pbBomNoStr;
        //                    SqlParameter p2 = new SqlParameter("@PsNo", SqlDbType.VarChar);
        //                    p2.Value = psNoStr;
        //                    SqlParameter p3 = new SqlParameter("@PurQty", SqlDbType.Float);
        //                    p3.Value = purQty;
        //                    IDataParameter[] updateParas = new IDataParameter[] { p1, p2, p3 };
        //                    BaseSQL.RunProcedure(cmd_proc, "P_PSBom_UpdateQty", updateParas, out resultInt, out errorText);
        //                    if (resultInt != 1)
        //                    {
        //                        trans.Rollback();
        //                        MessageHandler.ShowMessageBox("生产计划更新Bom信息数量错误--" + errorText);
        //                        return;
        //                    }
        //                }
        //                trans.Commit();

        //            }
        //            catch (Exception ex)
        //            {
        //                trans.Rollback();
        //                throw ex;
        //            }
        //            finally
        //            {
        //                conn.Close();
        //            }
        //        }
        //    }
        //}

        /// <summary>
        /// 删除生产计划Bom信息
        /// </summary>
        public bool ProductionSchedule_Delete(string psNoStr, List<string> pbBomNoList)
        {
            if (pbBomNoList.Count == 0)
                return false;

            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);

                        int resultInt = 0;
                        string errorText = "";
                        foreach (string pbBomNoStr in pbBomNoList)
                        {
                            SqlCommand cmd_proc = new SqlCommand("", conn, trans);
                            SqlParameter p1 = new SqlParameter("@PbBomNo", SqlDbType.VarChar);
                            p1.Value = pbBomNoStr;
                            SqlParameter p2 = new SqlParameter("@PsNo", SqlDbType.VarChar);
                            p2.Value = psNoStr;
                            IDataParameter[] updateParas = new IDataParameter[] { p1, p2};
                            BaseSQL.RunProcedure(cmd_proc, "P_PSBom_Delete", updateParas, out resultInt, out errorText);
                            if (resultInt != 1)
                            {
                                trans.Rollback();
                                MessageHandler.ShowMessageBox("删除生产计划Bom信息错误--" + errorText);
                                return false;
                            }

                            string logStr = string.Format("生产计划单[{0}]删除Bom零件信息[{1}]", psNoStr, pbBomNoStr);
                            LogHandler.RecordLog(cmd, logStr);
                        }
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
        /// 更新生产计划单的Bom信息的需求日期
        /// </summary>
        public void ProductionSchedule_BomListReqDate(string psNoStr, List<int> autoIdList, DateTime reqDate)
        {
            if (autoIdList.Count == 0)
                return;

            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);

                        //方案一 只更新选中的一条记录
                        //string sqlStr = "";
                        //foreach (int autoId in autoIdList)
                        //{
                        //    sqlStr += string.Format(" {0},", autoId);
                        //}
                        //cmd.CommandText = string.Format("Update PB_ProductionScheduleBom set ReqDate = '{1}' where AutoId in ({0})", sqlStr.Substring(0, sqlStr.Length - 1), reqDate.ToString("yyyy-MM-dd"));
                        //cmd.ExecuteNonQuery();


                        //方案二 更新选中的记录和它下面的子节点
                        int resultInt = 0;
                        string errorText = "";
                        foreach (int autoIdInt in autoIdList)
                        {
                            SqlCommand cmd_proc = new SqlCommand("", conn, trans);
                            SqlParameter p1 = new SqlParameter("@AutoId", SqlDbType.Int);
                            p1.Value = autoIdInt;
                            SqlParameter p2 = new SqlParameter("@ReqDate", SqlDbType.DateTime);
                            p2.Value = reqDate;
                            IDataParameter[] updateParas = new IDataParameter[] { p1, p2 };
                            BaseSQL.RunProcedure(cmd_proc, "P_PSBom_UpdateReqDate", updateParas, out resultInt, out errorText);
                            if (resultInt != 1)
                            {
                                trans.Rollback();
                                MessageHandler.ShowMessageBox("更新生产计划单的Bom信息的需求日期错误--" + errorText);
                            }

                            string logStr = string.Format("生产计划单[{0}]更新Bom零件节点的需求日期，ID为[{1}]，需求日期为[{2}]", psNoStr, autoIdInt, reqDate.ToString("yyyy-MM-dd"));
                            LogHandler.RecordLog(cmd, logStr);
                        }
                        
                        trans.Commit();
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
        /// 根据设计Bom编号来查询生产计划单Bom信息已经登记的数量
        /// </summary>
        public decimal QueryPSBom_PurQty(string pbBomNoStr)
        {
            string sqlStr = string.Format("select IsNull(Sum(PurQty), 0) from PB_ProductionScheduleBomManage where PbBomNo = '{0}'", pbBomNoStr);
            return DataTypeConvert.GetDecimal(BaseSQL.GetSingle(sqlStr));
        }
    }
}
