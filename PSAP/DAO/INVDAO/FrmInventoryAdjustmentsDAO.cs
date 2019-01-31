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
    class FrmInventoryAdjustmentsDAO
    {
        /// <summary>
        /// 查询库存调整单表头表
        /// </summary>
        /// <param name="queryDataTable">要查询填充的数据表</param>
        /// <param name="beginDateStr">开始日期字符串</param>
        /// <param name="endDateStr">结束日期字符串</param>
        /// <param name="adjustmentsRepertoryNoStr">调整仓库</param>
        /// <param name="adjustmentsProjectNoStr">调整项目号</param>
        /// <param name="reqDepStr">部门</param>
        /// <param name="preparedStr">制单人</param>
        /// <param name="commonStr">通用查询条件</param>
        /// <param name="nullTable">是否查询空表</param>
        public void QueryInventoryAdjustmentsHead(DataTable queryDataTable, string beginDateStr, string endDateStr, string adjustmentsRepertoryNoStr, string adjustmentsProjectNoStr, string reqDepStr, string preparedStr, string commonStr, bool nullTable)
        {
            BaseSQL.Query(QueryInventoryAdjustmentsHead_SQL(beginDateStr, endDateStr, adjustmentsRepertoryNoStr, adjustmentsProjectNoStr, reqDepStr, preparedStr, commonStr, nullTable), queryDataTable);
        }

        /// <summary>
        /// 查询库存调整单表头表的SQL
        /// </summary>
        public string QueryInventoryAdjustmentsHead_SQL(string beginDateStr, string endDateStr, string adjustmentsRepertoryNoStr, string adjustmentsProjectNoStr, string reqDepStr, string preparedStr, string commonStr, bool nullTable)
        {
            string sqlStr = " 1=1";
            if (beginDateStr != "")
            {
                sqlStr += string.Format(" and InventoryAdjustmentsDate between '{0}' and '{1}'", beginDateStr, endDateStr);
            }
            if (adjustmentsRepertoryNoStr != "")
            {
                sqlStr += string.Format(" and AdjustmentsRepertoryNo='{0}'", adjustmentsRepertoryNoStr);
            }
            if (adjustmentsProjectNoStr != "")
            {
                sqlStr += string.Format(" and AdjustmentsProjectNo='{0}'", adjustmentsProjectNoStr);
            }
            if (reqDepStr != "")
            {
                sqlStr += string.Format(" and ReqDep='{0}'", reqDepStr);
            }
            if (preparedStr != "")
            {
                sqlStr += string.Format(" and Prepared='{0}'", preparedStr);
            }
            if (commonStr != "")
            {
                sqlStr += string.Format(" and (InventoryAdjustmentsNo like '%{0}%' or Remark like '%{0}%')", commonStr);
            }
            if (nullTable)
            {
                sqlStr += " and 1=2";
            }
            sqlStr = string.Format("select * from INV_InventoryAdjustmentsHead where {0} order by AutoId", sqlStr);
            return sqlStr;
        }

        /// <summary>
        /// 查询库存调整单明细表
        /// </summary>
        /// <param name="queryDataTable">要查询填充的数据表</param>
        /// <param name="inventoryMoveNoStr">调整单号</param>
        public void QueryInventoryAdjustmentsList(DataTable queryDataTable, string inventoryAdjustmentsNoStr, bool nullTable)
        {
            string sqlStr = string.Format(" and InventoryAdjustmentsNo='{0}'", inventoryAdjustmentsNoStr);
            if (nullTable)
            {
                sqlStr += " and 1=2";
            }
            sqlStr = string.Format("select INV_InventoryAdjustmentsList.*, SW_PartsCode.CodeName from INV_InventoryAdjustmentsList left join SW_PartsCode on INV_InventoryAdjustmentsList.CodeFileName = SW_PartsCode.CodeFileName where 1=1 {0} order by AutoId", sqlStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 保存库存调整单
        /// </summary>
        /// <param name="IAHeadRow">库存调整单表头数据表</param>
        /// <param name="IAListTable">库存调整单明细数据表</param>
        public int SaveInventoryAdjustments(DataRow IAHeadRow, DataTable IAListTable)
        {
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);

                        ////检查当前库存数是否满足
                        //if (!CheckWarehouseNowInfoBeyondCount(cmd, IAHeadRow["InventoryMoveNo"].ToString(), IAListTable))
                        //{
                        //    return 0;
                        //}

                        if (IAHeadRow["InventoryAdjustmentsNo"].ToString() == "")//新增
                        {
                            string iaNo = BaseSQL.GetMaxCodeNo(cmd, "IA");
                            IAHeadRow["InventoryAdjustmentsNo"] = iaNo;
                            IAHeadRow["PreparedIp"] = SystemInfo.HostIpAddress;

                            for (int i = 0; i < IAListTable.Rows.Count; i++)
                            {
                                IAListTable.Rows[i]["InventoryAdjustmentsNo"] = iaNo;
                                IAListTable.Rows[i]["InventoryAdjustmentsDate"] = IAHeadRow["InventoryAdjustmentsDate"];
                                IAListTable.Rows[i]["AdjustmentsRepertoryNo"] = IAHeadRow["AdjustmentsRepertoryNo"];
                                IAListTable.Rows[i]["AdjustmentsProjectNo"] = IAHeadRow["AdjustmentsProjectNo"];
                            }
                        }
                        else//修改
                        {
                            //if (!CheckWarehouseState(IMHeadRow.Table, IMListTable, string.Format("'{0}'", DataTypeConvert.GetString(IMHeadRow["SettlementNo"])), false, true, true, true))
                            //    return -1;

                            IAHeadRow["Modifier"] = SystemInfo.user.EmpName;
                            IAHeadRow["ModifierIp"] = SystemInfo.HostIpAddress;
                            IAHeadRow["ModifierTime"] = BaseSQL.GetServerDateTime();

                            for (int i = 0; i < IAListTable.Rows.Count; i++)
                            {
                                if (IAListTable.Rows[i].RowState == DataRowState.Deleted)
                                    continue;
                                IAListTable.Rows[i]["InventoryAdjustmentsDate"] = IAHeadRow["InventoryAdjustmentsDate"];
                                IAListTable.Rows[i]["AdjustmentsRepertoryNo"] = IAHeadRow["AdjustmentsRepertoryNo"];
                                IAListTable.Rows[i]["AdjustmentsProjectNo"] = IAHeadRow["AdjustmentsProjectNo"];
                            }
                        }

                        //保存日志到日志表中
                        string logStr = LogHandler.RecordLog_DataRow(cmd, "库存调整单", IAHeadRow, "InventoryAdjustmentsNo");

                        cmd.CommandText = "select * from INV_InventoryAdjustmentsHead where 1=2";
                        SqlDataAdapter adapterHead = new SqlDataAdapter(cmd);
                        DataTable tmpHeadTable = new DataTable();
                        adapterHead.Fill(tmpHeadTable);
                        BaseSQL.UpdateDataTable(adapterHead, IAHeadRow.Table);

                        cmd.CommandText = "select * from INV_InventoryAdjustmentsList where 1=2";
                        SqlDataAdapter adapterList = new SqlDataAdapter(cmd);
                        DataTable tmpListTable = new DataTable();
                        adapterList.Fill(tmpListTable);
                        BaseSQL.UpdateDataTable(adapterList, IAListTable);

                        //Set_WWHead_End(cmd, IMListTable);

                        trans.Commit();

                        return 1;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        IAHeadRow.Table.RejectChanges();
                        IAListTable.RejectChanges();
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
        /// 根据选择删除多条库存调整单
        /// </summary>
        public bool DeleteInventoryAdjustments_Multi(DataTable iaHeadTable)
        {
            string iaHeadNoListStr = "";
            for (int i = 0; i < iaHeadTable.Rows.Count; i++)
            {
                if (DataTypeConvert.GetBoolean(iaHeadTable.Rows[i]["Select"]))
                {
                    iaHeadNoListStr += string.Format("'{0}',", DataTypeConvert.GetString(iaHeadTable.Rows[i]["InventoryAdjustmentsNo"]));
                }
            }
            iaHeadNoListStr = iaHeadNoListStr.Substring(0, iaHeadNoListStr.Length - 1);
            //if (!CheckWarehouseState(imHeadTable, null, imHeadNoListStr, false, true, true, true))
            //    return false;
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);
                        //cmd.CommandText = string.Format("select * from INV_InventoryAdjustmentsList where InventoryAdjustmentsNo in ({0})", iaHeadNoListStr);
                        //DataTable tmpTable = new DataTable();
                        //SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                        //adpt.Fill(tmpTable);

                        //保存日志到日志表中
                        DataRow[] headRows = iaHeadTable.Select("select=1");
                        for (int i = 0; i < headRows.Length; i++)
                        {
                            string logStr = LogHandler.RecordLog_DeleteRow(cmd, "库存调整单", headRows[i], "InventoryAdjustmentsNo");
                        }

                        cmd.CommandText = string.Format("Delete from INV_InventoryAdjustmentsList where InventoryAdjustmentsNo in ({0})", iaHeadNoListStr);
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = string.Format("Delete from INV_InventoryAdjustmentsHead where InventoryAdjustmentsNo in ({0})", iaHeadNoListStr);
                        cmd.ExecuteNonQuery();

                        //Set_WWHead_End(cmd, tmpTable);

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
        /// <param name="iaHeadNoStr">库存调整单号</param>
        /// <param name="handleTypeInt">打印处理类型：1 预览 2 打印 3 设计</param>
        public void PrintHandle(string iaHeadNoStr, int handleTypeInt)
        {
            DataSet ds = new DataSet();
            DataTable headTable = BaseSQL.GetTableBySql(string.Format("select * from V_Prn_INV_InventoryAdjustmentsHead where InventoryAdjustmentsNo = '{0}' order by AutoId", iaHeadNoStr));
            headTable.TableName = "InventoryAdjustmentsHead";
            for (int i = 0; i < headTable.Columns.Count; i++)
            {
                #region 设定主表显示的标题

                switch (headTable.Columns[i].ColumnName)
                {
                    case "InventoryAdjustmentsNo":
                        headTable.Columns[i].Caption = "调整单号";
                        break;
                    case "InventoryAdjustmentsDate":
                        headTable.Columns[i].Caption = "调整日期";
                        break;
                    case "DepartmentNo":
                        headTable.Columns[i].Caption = "部门编号";
                        break;
                    case "DepartmentName":
                        headTable.Columns[i].Caption = "部门名称";
                        break;
                    case "RepertoryNo":
                        headTable.Columns[i].Caption = "仓库编号";
                        break;
                    case "RepertoryName":
                        headTable.Columns[i].Caption = "仓库名称";
                        break;
                    case "ProjectNo":
                        headTable.Columns[i].Caption = "项目号";
                        break;
                    case "ProjectName":
                        headTable.Columns[i].Caption = "项目名称";
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
                }

                #endregion
            }
            ds.Tables.Add(headTable);

            DataTable listTable = BaseSQL.GetTableBySql(string.Format("select *, ROW_NUMBER() over (order by AutoId) as RowNum from V_Prn_INV_InventoryAdjustmentsList where InventoryAdjustmentsNo = '{0}' order by AutoId", iaHeadNoStr));
            listTable.TableName = "InventoryAdjustmentsList";
            for (int i = 0; i < listTable.Columns.Count; i++)
            {
                #region 设定子表显示的标题

                switch (listTable.Columns[i].ColumnName)
                {
                    case "RowNum":
                        listTable.Columns[i].Caption = "行号";
                        break;
                    case "InventoryAdjustmentsNo":
                        listTable.Columns[i].Caption = "调整单号";
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
                        listTable.Columns[i].Caption = "调整数量";
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

            List<DevExpress.XtraReports.Parameters.Parameter> paralist = ReportHandler.GetSystemInfo_ParamList();

            ReportHandler.XtraReport_Handle("INV_InventoryAdjustmentsHead", ds, paralist, handleTypeInt);
        }
    }
}
