using PSAP.PSAPCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            sqlStr = string.Format("select * from BS_BomManagement where {0} order by AutoId", sqlStr);
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
    }
}
