using PSAP.DAO.BSDAO;
using PSAP.PSAPCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace PSAP.DAO.PBDAO
{
    class FrmPBBomManagementDAO
    {
        /// <summary>
        /// 查询销售订单信息
        /// </summary>
        public DataTable QuerySalesOrder(string salesOrderNoStr)
        {
            string sqlStr = string.Format("select AutoSalesOrderNo, ProjectNo, ProjectName from SA_SalesOrder where AutoSalesOrderNo = '{0}'", salesOrderNoStr);
            return BaseSQL.Query(sqlStr).Tables[0];
        }

        /// <summary>
        /// 查询零件信息
        /// </summary>
        public void QueryPartsCode(DataTable queryDataTable)
        {
            string sqlStr = " 1=1";

            sqlStr = string.Format("select * from SW_PartsCode where {0} order by AutoId", sqlStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 查询Bom的树形更多信息
        /// </summary>
        public DataTable QueryBomInfo(string materielNoStr)
        {
            string sqlStr = string.Format("select bom.*, SW_PartsCode.CodeName, SW_PartsCode.AutoId as PCAutoId, SW_PartsCode.FilePath, SW_PartsCode.Brand, SW_PartsCode.CatgName, SW_PartsCode.CodeSpec, SW_PartsCode.Unit, BS_BomMaterieState.MaterieStateText from F_BomMateriel_TreeRelation('{0}') as bom left join SW_PartsCode on bom.CodeFileName = SW_PartsCode.CodeFileName left join BS_BomManagement on bom.CodeFileName = BS_BomManagement.MaterielNo left join BS_BomMaterieState on BS_BomMaterieState.MaterieStateId = BS_BomManagement.MaterieStateId Order by CodeFileName", materielNoStr);
            return BaseSQL.Query(sqlStr).Tables[0];
        }

        /// <summary>
        /// 查询生产BOM信息
        /// </summary>
        public void QueryPBBomManagement(DataTable queryDataTable, string salesOrderNoStr)
        {
            string sqlStr = " 1=1";
            //if (salesOrderNoStr != "")
            {
                sqlStr += string.Format(" and SalesOrderNo = '{0}'", salesOrderNoStr);
            }
            sqlStr = string.Format("select PB_BomManagement.*, SW_PartsCode.CodeName from PB_BomManagement left join SW_PartsCode on PB_BomManagement.MaterielNo = SW_PartsCode.CodeFileName where {0} order by PB_BomManagement.AutoId", sqlStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 保存生产BOM信息
        /// </summary>
        public int SavePBBomManagement(string salesOrderNoStr, DataTable bomListTable)
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

                        //foreach(DataRow dr in drs)
                        //{
                        //    cmd.CommandText = string.Format("Insert into PB_BomManagement(SalesOrderNo, MaterielNo, LevelMaterielNo, Qty, IsUse, Prepared, PreparedIp, GetTime)")
                        //}

                        for (int i = 0; i < bomListTable.Rows.Count; i++)
                        {
                            if (bomListTable.Rows[i].RowState == DataRowState.Added)
                            {
                                bomListTable.Rows[i]["IsUse"] = 1;
                                bomListTable.Rows[i]["Prepared"] = SystemInfo.user.EmpName;
                                bomListTable.Rows[i]["PreparedIp"] = SystemInfo.HostIpAddress;
                                bomListTable.Rows[i]["GetTime"] = nowTime;
                            }
                        }

                        //保存日志到日志表中
                        //string logStr = LogHandler.RecordLog_DataRow(cmd, "Bom登记信息", bomHeadRow, "MaterielNo");

                        cmd.CommandText = "select * from PB_BomManagement where 1=2";
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
        /// 全部删除生产BOM信息
        /// </summary>
        public bool ClearPBBomManagement(string salesOrderNoStr)
        {
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);

                        //保存日志到日志表中
                        LogHandler.RecordLog(cmd, string.Format("全部删除销售订单[{0}]的生产BOM信息",salesOrderNoStr));

                        cmd.CommandText = string.Format("Delete from PB_BomManagement where SalesOrderNo = '{0}'", salesOrderNoStr);
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
        /// 删除生产BOM中的BOM信息
        /// </summary>
        public bool DeletePBBomManagement(string salesOrderNoStr,string bomMaterielNoStr)
        {
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);



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
