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
    class FrmInventoryMoveDAO
    {
        /// <summary>
        /// 查询库存移动单表头表
        /// </summary>
        /// <param name="queryDataTable">要查询填充的数据表</param>
        /// <param name="beginDateStr">开始日期字符串</param>
        /// <param name="endDateStr">结束日期字符串</param>
        /// <param name="inRepertoryNoStr">入库仓库</param>
        /// <param name="outRepertoryNoStr">出库仓库</param>
        /// <param name="reqDepStr">部门</param>
        /// <param name="preparedStr">制单人</param>
        /// <param name="commonStr">通用查询条件</param>
        /// <param name="nullTable">是否查询空表</param>
        public void QueryInventoryMoveHead(DataTable queryDataTable, string beginDateStr, string endDateStr, string inRepertoryNoStr, string outRepertoryNoStr, string reqDepStr, string preparedStr, string commonStr, bool nullTable)
        {
            BaseSQL.Query(QueryInventoryMoveHead_SQL(beginDateStr, endDateStr, inRepertoryNoStr, outRepertoryNoStr, reqDepStr, preparedStr, commonStr, nullTable), queryDataTable);
        }

        /// <summary>
        /// 查询库存移动单表头表的SQL
        /// </summary>
        public string QueryInventoryMoveHead_SQL(string beginDateStr, string endDateStr, string inRepertoryNoStr, string outRepertoryNoStr, string reqDepStr, string preparedStr, string commonStr, bool nullTable)
        {
            string sqlStr = " 1=1";
            if (beginDateStr != "")
            {
                sqlStr += string.Format(" and InventoryMoveDate between '{0}' and '{1}'", beginDateStr, endDateStr);
            }
            if (inRepertoryNoStr != "")
            {
                sqlStr += string.Format(" and InRepertoryNo='{0}'", inRepertoryNoStr);
            }
            if (outRepertoryNoStr != "")
            {
                sqlStr += string.Format(" and OutRepertoryNo='{0}'", outRepertoryNoStr);
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
                sqlStr += string.Format(" and (InventoryMoveNo like '%{0}%' or Remark like '%{0}%')", commonStr);
            }
            if (nullTable)
            {
                sqlStr += " and 1=2";
            }
            sqlStr = string.Format("select * from INV_InventoryMoveHead where {0} order by AutoId", sqlStr);
            return sqlStr;
        }

        /// <summary>
        /// 查询库存移动单明细表
        /// </summary>
        /// <param name="queryDataTable">要查询填充的数据表</param>
        /// <param name="inventoryMoveNoStr">移动单号</param>
        public void QueryInventoryMoveList(DataTable queryDataTable, string inventoryMoveNoStr,bool nullTable)
        {
            string sqlStr = string.Format(" and InventoryMoveNo='{0}'", inventoryMoveNoStr);
            if (nullTable)
            {
                sqlStr += " and 1=2";
            }
            sqlStr = string.Format("select INV_InventoryMoveList.*, SW_PartsCode.CodeName from INV_InventoryMoveList left join SW_PartsCode on INV_InventoryMoveList.CodeFileName = SW_PartsCode.CodeFileName where 1=1 {0} order by AutoId", sqlStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 保存库存移动单
        /// </summary>
        /// <param name="IMHeadRow">库存移动单表头数据表</param>
        /// <param name="IMListTable">库存移动单明细数据表</param>
        public int SaveInventoryMove(DataRow IMHeadRow, DataTable IMListTable)
        {
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);

                        //检查当前库存数是否满足
                        if (!CheckWarehouseNowInfoBeyondCount(cmd, IMHeadRow["InventoryMoveNo"].ToString(), IMListTable))
                        {
                            return 0;
                        }

                        if (IMHeadRow["InventoryMoveNo"].ToString() == "")//新增
                        {
                            string imNo = BaseSQL.GetMaxCodeNo(cmd, "IM");
                            IMHeadRow["InventoryMoveNo"] = imNo;
                            IMHeadRow["PreparedIp"] = SystemInfo.HostIpAddress;

                            for (int i = 0; i < IMListTable.Rows.Count; i++)
                            {
                                IMListTable.Rows[i]["InventoryMoveNo"] = imNo;
                                IMListTable.Rows[i]["InventoryMoveDate"] = IMHeadRow["InventoryMoveDate"];
                                IMListTable.Rows[i]["InRepertoryNo"] = IMHeadRow["InRepertoryNo"];
                                IMListTable.Rows[i]["OutRepertoryNo"] = IMHeadRow["OutRepertoryNo"];
                            }
                        }
                        else//修改
                        {
                            //if (!CheckWarehouseState(IMHeadRow.Table, IMListTable, string.Format("'{0}'", DataTypeConvert.GetString(IMHeadRow["SettlementNo"])), false, true, true, true))
                            //    return -1;

                            IMHeadRow["Modifier"] = SystemInfo.user.EmpName;
                            IMHeadRow["ModifierIp"] = SystemInfo.HostIpAddress;
                            IMHeadRow["ModifierTime"] = BaseSQL.GetServerDateTime();

                            for (int i = 0; i < IMListTable.Rows.Count; i++)
                            {
                                if (IMListTable.Rows[i].RowState == DataRowState.Deleted)
                                    continue;
                                IMListTable.Rows[i]["InventoryMoveDate"] = IMHeadRow["InventoryMoveDate"];
                                IMListTable.Rows[i]["InRepertoryNo"] = IMHeadRow["InRepertoryNo"];
                                IMListTable.Rows[i]["OutRepertoryNo"] = IMHeadRow["OutRepertoryNo"];
                            }
                        }

                        //保存日志到日志表中
                        string logStr = LogHandler.RecordLog_DataRow(cmd, "库存移动单", IMHeadRow, "InventoryMoveNo");

                        cmd.CommandText = "select * from INV_InventoryMoveHead where 1=2";
                        SqlDataAdapter adapterHead = new SqlDataAdapter(cmd);
                        DataTable tmpHeadTable = new DataTable();
                        adapterHead.Fill(tmpHeadTable);
                        BaseSQL.UpdateDataTable(adapterHead, IMHeadRow.Table);

                        cmd.CommandText = "select * from INV_InventoryMoveList where 1=2";
                        SqlDataAdapter adapterList = new SqlDataAdapter(cmd);
                        DataTable tmpListTable = new DataTable();
                        adapterList.Fill(tmpListTable);
                        BaseSQL.UpdateDataTable(adapterList, IMListTable);

                        //Set_WWHead_End(cmd, IMListTable);

                        trans.Commit();

                        return 1;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        IMHeadRow.Table.RejectChanges();
                        IMListTable.RejectChanges();
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
        /// 检查当前库存的数量是否满足库存移动的数量
        /// </summary>
        private bool CheckWarehouseNowInfoBeyondCount(SqlCommand cmd, string inventoryMoveNoStr, DataTable imListTable)
        {
            foreach (DataRow lrow in imListTable.Rows)
            {
                if (lrow.RowState == DataRowState.Deleted)
                    continue;
                string codeFileNameStr = DataTypeConvert.GetString(lrow["CodeFileName"]);
                string outRepertoryNoStr = DataTypeConvert.GetString(lrow["OutRepertoryNo"]);
                string outProjectNameStr = DataTypeConvert.GetString(lrow["OutProjectName"]);
                string outShelfNoStr = DataTypeConvert.GetString(lrow["OutShelfNo"]);
                cmd.CommandText = string.Format("select Qty from INV_WarehouseNowInfo where CodeFileName = '{0}' and RepertoryNo = '{1}' and ProjectName = '{2}' and ShelfNo = '{3}'", codeFileNameStr, outRepertoryNoStr, outProjectNameStr, outShelfNoStr);
                double nowQty = DataTypeConvert.GetDouble(cmd.ExecuteScalar());
                string sqlStr = string.Format("CodeFileName = '{0}' and OutRepertoryNo = '{1}' and OutProjectName = '{2}' and OutShelfNo = '{3}'", codeFileNameStr, outRepertoryNoStr, outProjectNameStr, outShelfNoStr);
                double qtySum = DataTypeConvert.GetDouble(imListTable.Compute("Sum(Qty)", sqlStr));
                if (qtySum > nowQty)
                {
                    MessageHandler.ShowMessageBox(string.Format("库存移动单中明细[{0}]的数量[{1}]超过当前的库存数量[{2}]，不可以保存。", codeFileNameStr, qtySum, nowQty));
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 根据选择删除多条库存移动单
        /// </summary>
        public bool DeleteInventoryMove_Multi(DataTable imHeadTable)
        {
            string imHeadNoListStr = "";
            for (int i = 0; i < imHeadTable.Rows.Count; i++)
            {
                if (DataTypeConvert.GetBoolean(imHeadTable.Rows[i]["Select"]))
                {
                    imHeadNoListStr += string.Format("'{0}',", DataTypeConvert.GetString(imHeadTable.Rows[i]["InventoryMoveNo"]));
                }
            }
            imHeadNoListStr = imHeadNoListStr.Substring(0, imHeadNoListStr.Length - 1);
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
                        //cmd.CommandText = string.Format("select * from INV_InventoryMoveList where InventoryMoveNo in ({0})", imHeadNoListStr);
                        //DataTable tmpTable = new DataTable();
                        //SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                        //adpt.Fill(tmpTable);

                        //保存日志到日志表中
                        DataRow[] headRows = imHeadTable.Select("select=1");
                        for (int i = 0; i < headRows.Length; i++)
                        {
                            string logStr = LogHandler.RecordLog_DeleteRow(cmd, "库存移动单", headRows[i], "InventoryMoveNo");
                        }

                        cmd.CommandText = string.Format("Delete from INV_InventoryMoveList where InventoryMoveNo in ({0})", imHeadNoListStr);
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = string.Format("Delete from INV_InventoryMoveHead where InventoryMoveNo in ({0})", imHeadNoListStr);
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
        /// <param name="imHeadNoStr">库存移动单号</param>
        /// <param name="handleTypeInt">打印处理类型：1 预览 2 打印 3 设计</param>
        public void PrintHandle(string imHeadNoStr, int handleTypeInt)
        {
            DataSet ds = new DataSet();
            DataTable headTable = BaseSQL.GetTableBySql(string.Format("select * from V_Prn_INV_InventoryMoveHead where InventoryMoveNo = '{0}' order by AutoId", imHeadNoStr));
            headTable.TableName = "InventoryMoveHead";
            for (int i = 0; i < headTable.Columns.Count; i++)
            {
                #region 设定主表显示的标题

                switch (headTable.Columns[i].ColumnName)
                {
                    case "InventoryMoveNo":
                        headTable.Columns[i].Caption = "移动单号";
                        break;
                    case "InventoryMoveDate":
                        headTable.Columns[i].Caption = "移动日期";
                        break;
                    case "DepartmentNo":
                        headTable.Columns[i].Caption = "部门编号";
                        break;
                    case "DepartmentName":
                        headTable.Columns[i].Caption = "部门名称";
                        break;
                    case "InRepertoryNo":
                        headTable.Columns[i].Caption = "入库仓库编号";
                        break;
                    case "InRepertoryName":
                        headTable.Columns[i].Caption = "入库仓库名称";
                        break;
                    case "OutRepertoryNo":
                        headTable.Columns[i].Caption = "出库仓库编号";
                        break;
                    case "OutRepertoryName":
                        headTable.Columns[i].Caption = "出库仓库名称";
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
                }

                #endregion
            }
            ds.Tables.Add(headTable);

            DataTable listTable = BaseSQL.GetTableBySql(string.Format("select *, ROW_NUMBER() over (order by AutoId) as RowNum from V_Prn_INV_InventoryMoveList where InventoryMoveNo = '{0}' order by AutoId", imHeadNoStr));
            listTable.TableName = "InventoryMoveList";
            for (int i = 0; i < listTable.Columns.Count; i++)
            {
                #region 设定子表显示的标题

                switch (listTable.Columns[i].ColumnName)
                {
                    case "RowNum":
                        listTable.Columns[i].Caption = "行号";
                        break;
                    case "InventoryMoveNo":
                        listTable.Columns[i].Caption = "移动单号";
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
                        listTable.Columns[i].Caption = "移动数量";
                        break;
                    case "InProjectNo":
                        listTable.Columns[i].Caption = "入库项目号";
                        break;
                    case "InProjectName":
                        listTable.Columns[i].Caption = "入库项目名称";
                        break;
                    case "InShelfId":
                        listTable.Columns[i].Caption = "入库货架ID";
                        break;
                    case "InShelfNo":
                        listTable.Columns[i].Caption = "入库货架号";
                        break;
                    case "InShelfLocation":
                        listTable.Columns[i].Caption = "入库货架位置";
                        break;
                    case "OutProjectNo":
                        listTable.Columns[i].Caption = "出库项目号";
                        break;
                    case "OutProjectName":
                        listTable.Columns[i].Caption = "出库项目名称";
                        break;
                    case "OutShelfId":
                        listTable.Columns[i].Caption = "出库货架ID";
                        break;
                    case "OutShelfNo":
                        listTable.Columns[i].Caption = "出库货架号";
                        break;
                    case "OutShelfLocation":
                        listTable.Columns[i].Caption = "出库货架位置";
                        break;
                    case "Remark":
                        listTable.Columns[i].Caption = "备注";
                        break;                    
                }

                #endregion
            }
            ds.Tables.Add(listTable);

            List<DevExpress.XtraReports.Parameters.Parameter> paralist = ReportHandler.GetSystemInfo_ParamList();

            ReportHandler.XtraReport_Handle("INV_InventoryMoveHead", ds, paralist, handleTypeInt);
        }
    }
}
