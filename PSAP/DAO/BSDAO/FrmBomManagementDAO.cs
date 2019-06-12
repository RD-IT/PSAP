using PSAP.PSAPCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace PSAP.DAO.BSDAO
{
    class FrmBomManagementDAO
    {
        static PSAP.VIEW.BSVIEW.FrmLanguageBSDAO f = new VIEW.BSVIEW.FrmLanguageBSDAO();
        public FrmBomManagementDAO()
        {
            PSAP.BLL.BSBLL.BSBLL.language(f);
        }

        /// <summary>
        /// 查询和当前零件编号相同的Bom信息数量
        /// </summary>
        public int QueryBom_CodeFileNameCount(string codeFileNameStr)
        {
            string sqlStr = string.Format("select Count(*) from BS_BomManagement where MaterielNo = '{0}'", codeFileNameStr);
            return DataTypeConvert.GetInt(BaseSQL.GetSingle(sqlStr));
        }

        /// <summary>
        /// 查询BOM物料状态表
        /// </summary>
        public DataTable QueryBomMaterieState(bool addAllItem)
        {
            string sqlStr = "select AutoId, MaterieStateId, MaterieStateText from BS_BomMaterieState order by AutoId";
            if (addAllItem)
            {
                sqlStr = "select 0 as AutoId, 0 as MaterieStateId, '全部' as MaterieStateText union " + sqlStr;
            }
            return BaseSQL.GetTableBySql(sqlStr);
        }

        /// <summary>
        /// 查询Bom主表单条信息
        /// </summary>
        public void QueryBomManagement_Single(DataTable queryDataTable, string materielNoStr)
        {
            string sqlStr = " 1=1";
            //if (materielNoStr != "")
            {
                sqlStr += string.Format(" and MaterielNo = '{0}'", materielNoStr);
            }
            sqlStr = string.Format("select BS_BomManagement.*, SW_PartsCode.CodeName from BS_BomManagement left join SW_PartsCode on BS_BomManagement.MaterielNo = SW_PartsCode.CodeFileName where {0} order by BS_BomManagement.AutoId", sqlStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 查询Bom子表信息
        /// </summary>
        public void QueryBomMateriel(DataTable queryDataTable, string materielNoStr)
        {
            string sqlStr = " 1=1";
            //if (materielNoStr != "")
            {
                sqlStr += string.Format(" and MaterielNo = '{0}'", materielNoStr);
            }
            sqlStr = string.Format("select bom.*, SW_PartsCode.CodeName as LevelMaterielName from BS_BomMateriel as bom left join SW_PartsCode on bom.LevelMaterielNo = SW_PartsCode.CodeFileName where {0} order by AutoId", sqlStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 查询Bom的树形基本信息
        /// </summary>
        public DataTable QueryBomTreeList_BaseInfo(string materielNoStr)
        {
            string sqlStr = string.Format("select bom.*, SW_PartsCode.CodeName, SW_PartsCode.AutoId as PCAutoId from F_BomMateriel_TreeRelation('{0}') as bom left join SW_PartsCode on bom.CodeFileName = SW_PartsCode.CodeFileName Order by CodeFileName", materielNoStr);
            return BaseSQL.Query(sqlStr).Tables[0];
        }

        /// <summary>
        /// 查询Bom的树形更多信息
        /// </summary>
        public DataTable QueryBomTreeList_MoreInfo(string materielNoStr)
        {
            string sqlStr = string.Format("select bom.*, SW_PartsCode.CodeName, SW_PartsCode.AutoId as PCAutoId, SW_PartsCode.FilePath, SW_PartsCode.Brand, SW_PartsCode.CatgName, SW_PartsCode.CodeSpec, SW_PartsCode.Unit, BS_BomMaterieState.MaterieStateText from F_BomMateriel_TreeRelation('{0}') as bom left join SW_PartsCode on bom.CodeFileName = SW_PartsCode.CodeFileName left join BS_BomManagement on bom.CodeFileName = BS_BomManagement.MaterielNo left join BS_BomMaterieState on BS_BomMaterieState.MaterieStateId = BS_BomManagement.MaterieStateId Order by CodeFileName", materielNoStr);
            return BaseSQL.Query(sqlStr).Tables[0];
        }

        /// <summary>
        /// 查询Bom的反展开树形更多信息
        /// </summary>
        public DataTable QueryBomTreeList_Negative_MoreInfo(string materielNoStr)
        {
            string sqlStr = string.Format("select '' as ReParent, bom.*, SW_PartsCode.CodeName, SW_PartsCode.AutoId as PCAutoId, SW_PartsCode.FilePath, SW_PartsCode.Brand, SW_PartsCode.CatgName, SW_PartsCode.CodeSpec, SW_PartsCode.Unit, BS_BomMaterieState.MaterieStateText from F_BomMateriel_ParentRelation('{0}') as bom left join SW_PartsCode on bom.CodeFileName = SW_PartsCode.CodeFileName left join BS_BomManagement on bom.CodeFileName = BS_BomManagement.MaterielNo left join BS_BomMaterieState on BS_BomMaterieState.MaterieStateId = BS_BomManagement.MaterieStateId Order by CodeFileName", materielNoStr);
            DataTable parentRelationTable = BaseSQL.GetTableBySql(sqlStr);
            DataTable queryTable = parentRelationTable.Clone();
            List<string> rootCodeFileNameList = new List<string>();
            if (parentRelationTable.Rows.Count > 0)
            {
                for (int i = 0; i < parentRelationTable.Rows.Count; i++)
                {
                    string parentCFNStr = DataTypeConvert.GetString(parentRelationTable.Rows[i]["ParentCodeFileName"]);
                    if (parentRelationTable.Select(string.Format("CodeFileName='{0}'", parentCFNStr)).Length == 0)
                    {
                        if (rootCodeFileNameList.IndexOf(parentCFNStr) < 0)
                            rootCodeFileNameList.Add(parentCFNStr);
                    }
                }
            }
            else
                rootCodeFileNameList.Add(materielNoStr);

            foreach (string rootCFN in rootCodeFileNameList)
            {
                sqlStr = string.Format("select ('/' + Cast(PC.AutoId as varchar(max)) + '/') as ReID, '' as ReParent, PC.AutoId, CodeFileName, 0 as ParentAutoId, '' as ParentCodeFileName, 1 as Qty, CodeName, PC.AutoId as PCAutoId, FilePath, Brand, CatgName, CodeSpec, Unit, BS_BomMaterieState.MaterieStateText from SW_PartsCode as PC left join BS_BomManagement as BomM on BomM.MaterielNo = PC.CodeFileName left join BS_BomMaterieState on BS_BomMaterieState.MaterieStateId = BomM.MaterieStateId where CodeFileName = '{0}'", rootCFN);
                DataTable rootTable = BaseSQL.GetTableBySql(sqlStr);
                if (rootTable.Rows.Count == 0)
                    continue;
                queryTable.ImportRow(rootTable.Rows[0]);

                RecursionTreeList(rootTable.Rows[0], parentRelationTable, queryTable);
            }

            return queryTable;
        }

        /// <summary>
        /// 递归创建树的数据表  
        /// </summary>
        private void RecursionTreeList(DataRow parentRow, DataTable sourceTable, DataTable targetTable)
        {
            string cfnStr = DataTypeConvert.GetString(parentRow["CodeFileName"]);
            DataRow[] drs = sourceTable.Select(string.Format("ParentCodeFileName='{0}'", cfnStr));
            foreach(DataRow dr in drs)
            {
                dr["ReID"] = parentRow["ReID"] + DataTypeConvert.GetString(dr["AutoId"]) + "/";
                dr["ReParent"] = parentRow["ReID"];
                targetTable.ImportRow(dr);
                RecursionTreeList(dr, sourceTable, targetTable);
            }
        }

        /// <summary>
        /// 保存Bom登记信息
        /// </summary>
        public int SaveBomManagement(DataRow bomHeadRow, DataTable bomListTable)
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
                        if (bomHeadRow.RowState == DataRowState.Added)//新增
                        {
                            cmd.CommandText = string.Format("select COUNT(*) from BS_BomManagement where MaterielNo = '{0}'", DataTypeConvert.GetString(bomHeadRow["MaterielNo"]));
                            if (DataTypeConvert.GetInt(cmd.ExecuteScalar()) > 0)
                            {
                                //MessageHandler.ShowMessageBox("当前选择的零件名称已经存在Bom信息，不能重复设定，请重新输入。");
                                MessageHandler.ShowMessageBox(f.tsmiDqxzdl.Text);

                                trans.Rollback();
                                return 0;
                            }

                            bomHeadRow["GetTime"] = nowTime;
                            for (int i = 0; i < bomListTable.Rows.Count; i++)
                            {
                                bomListTable.Rows[i]["MaterielNo"] = bomHeadRow["MaterielNo"];
                                bomListTable.Rows[i]["GetTime"] = nowTime;
                            }
                        }
                        else//修改
                        {
                            for (int i = 0; i < bomListTable.Rows.Count; i++)
                            {
                                if (bomListTable.Rows[i].RowState == DataRowState.Deleted)
                                    continue;
                                else if (bomListTable.Rows[i].RowState == DataRowState.Added)
                                {
                                    bomListTable.Rows[i]["MaterielNo"] = bomHeadRow["MaterielNo"];
                                    bomListTable.Rows[i]["GetTime"] = nowTime;
                                }
                            }
                        }

                        //保存日志到日志表中
                        //string logStr = LogHandler.RecordLog_DataRow(cmd, "Bom登记信息", bomHeadRow, "MaterielNo");
                        string logStr = LogHandler.RecordLog_DataRow(cmd, f.tsmiBomdjx.Text, bomHeadRow, "MaterielNo");

                        cmd.CommandText = "select * from BS_BomManagement where 1=2";
                        SqlDataAdapter adapterHead = new SqlDataAdapter(cmd);
                        DataTable tmpHeadTable = new DataTable();
                        adapterHead.Fill(tmpHeadTable);
                        BaseSQL.UpdateDataTable(adapterHead, bomHeadRow.Table);

                        cmd.CommandText = "select * from BS_BomMateriel where 1=2";
                        SqlDataAdapter adapterList = new SqlDataAdapter(cmd);
                        DataTable tmpListTable = new DataTable();
                        adapterList.Fill(tmpListTable);
                        BaseSQL.UpdateDataTable(adapterList, bomListTable);

                        trans.Commit();

                        return 1;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        bomHeadRow.Table.RejectChanges();
                        bomListTable.RejectChanges();
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
        /// 删除Bom登记信息
        /// </summary>
        public bool DeleteBomManagement(DataRow bomHeadRow)
        {
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);
                        string materielNoStr = DataTypeConvert.GetString(bomHeadRow["MaterielNo"]);

                        //保存日志到日志表中
                        //string logStr = LogHandler.RecordLog_DeleteRow(cmd, "Bom登记信息", bomHeadRow, "MaterielNo");
                        string logStr = LogHandler.RecordLog_DeleteRow(cmd, f.tsmiBomdjx.Text, bomHeadRow, "MaterielNo");
                        
                        cmd.CommandText = string.Format("Delete from BS_BomMateriel where MaterielNo in ('{0}')", materielNoStr);
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = string.Format("Delete from BS_BomManagement where MaterielNo in ('{0}')", materielNoStr);
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
        /// 保存导入的Bom信息
        /// </summary>
        public void SaveImportBom(DataTable bomTable)
        {
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);
                        DateTime nowDate = BaseSQL.GetServerDateTime();
                        string nowLongDate = nowDate.ToString("yyyy-MM-dd HH:mm:ss");

                        //var query = from g in bomTable.AsEnumerable()
                        //            group g by new { t1 = g.Field<string>("MotherCodeFileName") } into cfnList
                        //            select new { MotherCodeFileName = cfnList.Key.t1, StallInfo = cfnList };
                        //foreach (var cfnInfo in query)
                        //{
                        //    string codeFileNameStr = cfnInfo.MotherCodeFileName;

                        DataView dv = new DataView(bomTable);
                        DataTable rootTable = dv.ToTable(true, "MotherCodeFileName");
                        foreach (DataRow rootDR in rootTable.Rows)
                        {
                            string codeFileNameStr = DataTypeConvert.GetString(rootDR["MotherCodeFileName"]);

                            cmd.CommandText = string.Format("Insert into BS_BomManagement(MaterielNo, PartsCodeId, GetTime) select CodeFileName, AutoId, '{1}' from SW_PartsCode where CodeFileName = '{0}'", codeFileNameStr, nowLongDate);
                            cmd.ExecuteNonQuery();

                            DataRow[] drs = bomTable.Select(string.Format("MotherCodeFileName='{0}'", codeFileNameStr));
                            foreach (DataRow dr in drs)
                            {
                                cmd.CommandText = string.Format("Insert into BS_BomMateriel(MaterielNo, LevelMaterielNo, Qty, GetTime) values ('{0}', '{1}', {2}, '{3}')", codeFileNameStr, DataTypeConvert.GetString(dr["SubCodeFileName"]), DataTypeConvert.GetInt(dr["Qty"]), nowLongDate);
                                cmd.ExecuteNonQuery();
                            }
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
    }
}
