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
    public class FrmApprovalDAO
    {
        /// <summary>
        /// 查询审批信息的最大顺序号
        /// </summary>
        public int QueryApprovalList_MaxSequence(SqlCommand cmd, string typeNoStr)
        {
            cmd.CommandText = string.Format("Select max(AppSequence) from PUR_ApprovalList where typeNo='{0}'", typeNoStr);
            int seqInt = DataTypeConvert.GetInt(cmd.ExecuteScalar());
            return seqInt + 1;
        }

        /// <summary>
        /// 删除审批信息后更新顺序号
        /// </summary>
        public void DeleteApprovalList_AddSequence(SqlCommand cmd, string typeNoStr, int beginSeqInt)
        {
            cmd.CommandText = string.Format("Update PUR_ApprovalList set AppSequence=AppSequence-1 where typeNo='{0}' and AppSequence>{1}", typeNoStr, beginSeqInt);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// 审批信息顺序号重置
        /// </summary>
        public void ApprovalList_Reset(SqlCommand cmd, string typeNoStr)
        {
            cmd.CommandText = string.Format("select * from PUR_ApprovalList where typeNo='{0}' Order by AutoId", typeNoStr);
            DataTable listTable = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.Fill(listTable);
            for (int i = 0; i < listTable.Rows.Count; i++)
            {
                cmd.CommandText = string.Format("Update PUR_ApprovalList set AppSequence={1} where AutoId={0}", listTable.Rows[i]["AutoId"].ToString(), i + 1);
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// 审批信息上移顺序号
        /// </summary>
        public void ApprovalList_UpSequence(string typeNoStr, int opSeqInt)
        {
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);
                        cmd.CommandText = string.Format("select * from PUR_ApprovalList where typeNo='{0}' and AppSequence={1}", typeNoStr, opSeqInt);
                        DataTable listTable = new DataTable();
                        SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                        adpt.Fill(listTable);
                        if (listTable.Rows.Count == 0)
                            return;
                        if (listTable.Rows.Count == 1)
                        {
                            opSeqInt = DataTypeConvert.GetInt(listTable.Rows[0]["AppSequence"]);
                            if (opSeqInt == 1)
                                return;
                            int opAutoId = DataTypeConvert.GetInt(listTable.Rows[0]["AutoId"]);
                            int opApprover = DataTypeConvert.GetInt(listTable.Rows[0]["Approver"]);

                            listTable.Rows.Clear();
                            cmd.CommandText = string.Format("select * from PUR_ApprovalList where typeNo='{0}' and AppSequence={1}", typeNoStr, opSeqInt - 1);
                            adpt = new SqlDataAdapter(cmd);
                            adpt.Fill(listTable);
                            if (listTable.Rows.Count == 0)
                            {
                                DeleteApprovalList_AddSequence(cmd, typeNoStr, opSeqInt - 1);
                            }
                            else
                            {
                                int upAutoId = DataTypeConvert.GetInt(listTable.Rows[0]["AutoId"]);
                                cmd.CommandText = string.Format("Update PUR_ApprovalList set AppSequence={1} where AutoId={0}", opAutoId, opSeqInt - 1);
                                cmd.ExecuteNonQuery();
                                cmd.CommandText = string.Format("Update PUR_ApprovalList set AppSequence={1} where AutoId={0}", upAutoId, opSeqInt);
                                cmd.ExecuteNonQuery();
                            }

                            //保存日志到日志表中
                            string logStr = string.Format("对[审批信息]表进行[上移]操作：主键的值为[{0}]，审核类型的值为[{1}]，审核人的值为[{2}]", opAutoId, typeNoStr, opApprover);
                            LogHandler.RecordLog(cmd, logStr);
                        }
                        else
                        {
                            ApprovalList_Reset(cmd, typeNoStr);
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
        /// 审批信息下移顺序号
        /// </summary>
        public void ApprovalList_DownSequence(string typeNoStr, int opSeqInt)
        {
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);
                        cmd.CommandText = string.Format("select * from PUR_ApprovalList where typeNo='{0}' and AppSequence={1}", typeNoStr, opSeqInt);
                        DataTable listTable = new DataTable();
                        SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                        adpt.Fill(listTable);
                        if (listTable.Rows.Count == 0)
                            return;
                        if (listTable.Rows.Count == 1)
                        {
                            opSeqInt = DataTypeConvert.GetInt(listTable.Rows[0]["AppSequence"]);
                            cmd.CommandText = string.Format("select Count(*) from PUR_ApprovalList where typeNo='{0}'", typeNoStr);
                            int countInt = DataTypeConvert.GetInt(cmd.ExecuteScalar());
                            if (opSeqInt == countInt)
                                return;
                            int opAutoId = DataTypeConvert.GetInt(listTable.Rows[0]["AutoId"]);
                            int opApprover = DataTypeConvert.GetInt(listTable.Rows[0]["Approver"]);

                            listTable.Rows.Clear();
                            cmd.CommandText = string.Format("select * from PUR_ApprovalList where typeNo='{0}' and AppSequence={1}", typeNoStr, opSeqInt + 1);
                            adpt = new SqlDataAdapter(cmd);
                            adpt.Fill(listTable);
                            if (listTable.Rows.Count == 0)
                            {
                                DeleteApprovalList_AddSequence(cmd, typeNoStr, opSeqInt + 1);
                            }
                            else
                            {
                                int downAutoId = DataTypeConvert.GetInt(listTable.Rows[0]["AutoId"]);
                                cmd.CommandText = string.Format("Update PUR_ApprovalList set AppSequence={1} where AutoId={0}", opAutoId, opSeqInt + 1);
                                cmd.ExecuteNonQuery();
                                cmd.CommandText = string.Format("Update PUR_ApprovalList set AppSequence={1} where AutoId={0}", downAutoId, opSeqInt);
                                cmd.ExecuteNonQuery();
                            }

                            //保存日志到日志表中
                            string logStr = string.Format("对[审批信息]表进行[下移]操作：主键的值为[{0}]，审核类型的值为[{1}]，审核人的值为[{2}]", opAutoId, typeNoStr, opApprover);
                            LogHandler.RecordLog(cmd, logStr);
                        }
                        else
                        {
                            ApprovalList_Reset(cmd, typeNoStr);
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
        /// 审批信息判断是否有相同的审批人
        /// </summary>
        public bool ApprovalList_SameApproverUser(SqlCommand cmd, string typeNoStr, int approverInt)
        {
            cmd.CommandText = string.Format("select * from PUR_ApprovalList where TypeNo='{0}' and Approver={1}", typeNoStr, approverInt);
            int count = DataTypeConvert.GetInt(cmd.ExecuteScalar());
            if (count > 0)
                return true;
            return false;
        }


        /// <summary>
        /// 查询采购订单信息
        /// </summary>
        public void QueryOrderHead(DataTable queryDataTable, string orderHeadNoStr)
        {
            string sqlStr = string.Format("select PUR_OrderHead.*, PUR_ApprovalType.TypeNoText, PUR_ApprovalType.ApprovalCat from PUR_OrderHead left join PUR_ApprovalType on PUR_OrderHead.ApprovalType=PUR_ApprovalType.TypeNo where OrderHeadNo='{0}'", orderHeadNoStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }        

        /// <summary>
        /// 查询订单审批信息记录
        /// </summary>
        public void QueryOrderApprovalInfo(DataTable queryDataTable,string orderHeadNoStr, string typeNoStr)
        {
            string sqlStr = string.Format("select list.*, type.TypeNoText, BS_UserInfo.EmpName, BS_UserInfo.LoginId, info.OrderHeadNo, info.ApproverTime from PUR_ApprovalList as list left join PUR_ApprovalType as type on list.TypeNo = type.TypeNo left join BS_UserInfo on list.Approver = BS_UserInfo.AutoId left join PUR_OrderApprovalInfo as info on list.Approver = info.Approver and info.OrderHeadNo = '{1}' where list.TypeNo = '{0}' order by AppSequence",typeNoStr,orderHeadNoStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 查询请购订单信息
        /// </summary>
        public void QueryPrReqHead(DataTable queryDataTable, string prReqNoStr)
        {
            string sqlStr = string.Format("select PUR_PrReqHead.*, PUR_ApprovalType.TypeNoText, PUR_ApprovalType.ApprovalCat from PUR_PrReqHead left join PUR_ApprovalType on PUR_PrReqHead.ApprovalType=PUR_ApprovalType.TypeNo where PrReqNo='{0}'", prReqNoStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 查询订单审批信息记录
        /// </summary>
        public void QueryPrReqApprovalInfo(DataTable queryDataTable, string prReqNoStr, string typeNoStr)
        {
            string sqlStr = string.Format("select list.*, type.TypeNoText, BS_UserInfo.EmpName, BS_UserInfo.LoginId, info.PrReqNo , info.ApproverTime from PUR_ApprovalList as list left join PUR_ApprovalType as type on list.TypeNo = type.TypeNo left join BS_UserInfo on list.Approver = BS_UserInfo.AutoId left join PUR_PrApprovalInfo as info on list.Approver = info.Approver and info.PrReqNo = '{1}' where list.TypeNo = '{0}' order by AppSequence", typeNoStr, prReqNoStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 查询入库单信息
        /// </summary>
        public void QueryWarehouseWarrantHead(DataTable queryDataTable, string wwHeadNoStr)
        {
            string sqlStr = string.Format("select INV_WarehouseWarrantHead.*, PUR_ApprovalType.TypeNoText, PUR_ApprovalType.ApprovalCat from INV_WarehouseWarrantHead left join PUR_ApprovalType on INV_WarehouseWarrantHead.ApprovalType = PUR_ApprovalType.TypeNo where WarehouseWarrant = '{0}'", wwHeadNoStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 查询入库单审批信息记录
        /// </summary>
        public void QueryWarehouseWarrantApprovalInfo(DataTable queryDataTable,string wwHeadNoStr, string typeNoStr)
        {
            string sqlStr = string.Format("select list.*, type.TypeNoText, BS_UserInfo.EmpName, BS_UserInfo.LoginId, info.WarehouseWarrant , info.ApproverTime from PUR_ApprovalList as list left join PUR_ApprovalType as type on list.TypeNo = type.TypeNo left join BS_UserInfo on list.Approver = BS_UserInfo.AutoId left join INV_WarehouseApprovalInfo as info on list.Approver = info.Approver and info.WarehouseWarrant = '{1}' where list.TypeNo = '{0}' order by AppSequence", typeNoStr, wwHeadNoStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 查询出库单信息
        /// </summary>
        public void QueryWarehouseReceiptHead(DataTable queryDataTable,string wrHeadNoStr)
        {
            string sqlStr = string.Format("select INV_WarehouseReceiptHead.*, PUR_ApprovalType.TypeNoText, PUR_ApprovalType.ApprovalCat from INV_WarehouseReceiptHead left join PUR_ApprovalType on INV_WarehouseReceiptHead.ApprovalType = PUR_ApprovalType.TypeNo where WarehouseReceipt = '{0}'", wrHeadNoStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 查询出库单审批信息记录
        /// </summary>
        public void QueryWarehouseReceiptApprovalInfo(DataTable queryDataTable, string wrHeadNoStr, string typeNoStr)
        {
            string sqlStr = string.Format("select list.*, type.TypeNoText, BS_UserInfo.EmpName, BS_UserInfo.LoginId, info.WarehouseReceipt , info.ApproverTime from PUR_ApprovalList as list left join PUR_ApprovalType as type on list.TypeNo = type.TypeNo left join BS_UserInfo on list.Approver = BS_UserInfo.AutoId left join INV_WarehouseReceiptApprovalInfo as info on list.Approver = info.Approver and info.WarehouseReceipt = '{1}' where list.TypeNo = '{0}' order by AppSequence", typeNoStr, wrHeadNoStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 查询采购国内结账信息
        /// </summary>
        public void QuerySettlementHead(DataTable queryDataTable,string settlementNoStr)
        {
            string sqlStr = string.Format("select PUR_SettlementHead.*, PUR_ApprovalType.TypeNoText, PUR_ApprovalType.ApprovalCat from PUR_SettlementHead left join PUR_ApprovalType on PUR_SettlementHead.ApprovalType = PUR_ApprovalType.TypeNo where SettlementNo = '{0}'", settlementNoStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 查询采购国内结账审批信息记录
        /// </summary>
        public void QuerySettlementApprovalInfo(DataTable queryDataTable, string settlementNoStr, string typeNoStr)
        {
            string sqlStr = string.Format("select list.*, type.TypeNoText, BS_UserInfo.EmpName, BS_UserInfo.LoginId, info.SettlementNo , info.ApproverTime from PUR_ApprovalList as list left join PUR_ApprovalType as type on list.TypeNo = type.TypeNo left join BS_UserInfo on list.Approver = BS_UserInfo.AutoId left join PUR_SettlementApprovalInfo as info on list.Approver = info.Approver and info.SettlementNo = '{1}' where list.TypeNo = '{0}' order by AppSequence", typeNoStr, settlementNoStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 查询预算外入库单信息
        /// </summary>
        public void QuerySpecialWarehouseWarrantHead(DataTable queryDataTable, string specialWarehouseWarrantStr)
        {
            string sqlStr = string.Format("select Head.AutoId, Head.SpecialWarehouseWarrant as OrderHeadNo, Head.SpecialWarehouseWarrantDate as OrderHeadDate, Head.ReqDep, Head.WarehouseState as ReqState, Head.ApprovalType, PUR_ApprovalType.TypeNoText, PUR_ApprovalType.ApprovalCat, Head.SpecialWarehouseWarrant, Head.WarehouseState from INV_SpecialWarehouseWarrantHead as Head left join PUR_ApprovalType on Head.ApprovalType = PUR_ApprovalType.TypeNo where SpecialWarehouseWarrant = '{0}'", specialWarehouseWarrantStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }

        /// <summary>
        /// 查询预算外出库单信息
        /// </summary>
        public void QuerySpecialWarehouseReceiptHead(DataTable queryDataTable, string specialWarehouseReceiptStr)
        {
            string sqlStr = string.Format("select Head.AutoId, Head.SpecialWarehouseReceipt as OrderHeadNo, Head.SpecialWarehouseReceiptDate as OrderHeadDate, Head.ReqDep, Head.WarehouseState as ReqState, Head.ApprovalType, PUR_ApprovalType.TypeNoText, PUR_ApprovalType.ApprovalCat, Head.SpecialWarehouseReceipt, Head.WarehouseState from INV_SpecialWarehouseReceiptHead as Head left join PUR_ApprovalType on Head.ApprovalType = PUR_ApprovalType.TypeNo where SpecialWarehouseReceipt = '{0}'", specialWarehouseReceiptStr);
            BaseSQL.Query(sqlStr, queryDataTable);
        }
    }
}
