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
        public DataTable QueryDepartment()
        {
            string sqlStr = "select 0 as AutoId, '' as DepartmentNo, '全部' as DepartmentName union select AutoId, DepartmentNo, DepartmentName from BS_Department";
            return BaseSQL.GetTableBySql(sqlStr);
        }

        /// <summary>
        /// 查询采购类型（增加一个全部选项）
        /// </summary>
        /// <returns></returns>
        public DataTable QueryPurCategory()
        {
            string sqlStr = "select 0 as AutoId, '' as PurCategory, '全部' as PurCategoryText union select AutoId, PurCategory, PurCategoryText from PUR_PurCategory";
            return BaseSQL.GetTableBySql(sqlStr);
        }

        /// <summary>
        /// 得到部门及子部门的编号SQL
        /// </summary>
        /// <param name="colName"></param>
        /// <param name="departmentNo"></param>
        /// <returns></returns>
        public string GetDepartmentNoSQL_AllChild(string colName, string departmentNo)
        {
            string sqlStr = string.Format("with temp as ( select b.* from BS_Department b where ParentDepartmentNo = '{0}' union all select a.* from BS_Department a join temp on a.ParentDepartmentNo = temp.DepartmentNo ) select AutoID, DepartmentNo, DepartmentName from temp union all select AutoID, DepartmentNo, DepartmentName from BS_Department where DepartmentNo = '{0}' Order by AutoId", departmentNo);
            DataTable depTable = BaseSQL.GetTableBySql(sqlStr);
            string resultString = "";
            for (int i = 0; i < depTable.Rows.Count; i++)
            {
                resultString += string.Format(" '{0}',", DataTypeConvert.GetString(depTable.Rows[i]["DepartmentNo"]));
            }
            return string.Format("{0} in ({1})", colName, resultString.Substring(0, resultString.Length - 1));
        }

        /// <summary>
        /// 查询采购请购单表头表
        /// </summary>
        /// <param name="queryDataTable"></param>
        /// <param name="beginDate"></param>
        /// <param name="endDate"></param>
        /// <param name="reqDepStr"></param>
        /// <param name="purCategoryStr"></param>
        public void QueryPrReqHead(DataTable queryDataTable, DateTime beginDate, DateTime endDate, string reqDepStr, string purCategoryStr, bool nullTable)
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
            string sqlStr = "";
            sqlStr += string.Format(" and PrReqNo='{0}'", prReqNoStr);
            sqlStr = string.Format("select * from PUR_PrReqList where 1=1 {0} order by AutoId", sqlStr);
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

        public void SavePrReq(DataRow prReqHeadRow,DataTable prReqListTable)
        {
            if(prReqHeadRow["PrReqNo"].ToString()=="")//新增
            {
                string prReqNo = GetMaxOrderNo("PUR_PrReqHead", "PrReqNo", "PR", 11);
                prReqHeadRow["PrReqNo"] = prReqNo;
                prReqHeadRow["Applicant"] = FrmLoginDAO.user.RoleName;
                prReqHeadRow["ApplicantIp"] = "";
                prReqHeadRow["ApplicantTime"] = BaseSQL.GetServerDateTime();

                #region Sql更新

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
                prReqHeadRow["Modifier"] = FrmLoginDAO.user.RoleName;
                prReqHeadRow["ModifierIp"] = "";
                prReqHeadRow["ModifierTime"] = BaseSQL.GetServerDateTime();
            }

            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
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
                        prReqHeadRow.Table.AcceptChanges();
                        prReqListTable.AcceptChanges();
                    }
                    catch(Exception ex)
                    {
                        trans.Rollback();
                        throw;
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
        
    }
}
