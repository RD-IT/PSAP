using PSAP.DAO.BSDAO;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace PSAP.DAO.BSDAO
{
    class FrmSystemDAO
    {
        /// <summary>
        /// 清空操作记录
        /// </summary>
        public void ClearOperationRecord(bool clearINVBool, bool clearPURBool)
        {
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);

                        if (clearINVBool)//库存模块
                        {
                            cmd.CommandText = "Delete From INV_WarehouseBeginingInfo"; cmd.ExecuteNonQuery();
                            cmd.CommandText = "Delete From INV_WarehouseNowInfo"; cmd.ExecuteNonQuery();

                            cmd.CommandText = "Delete From INV_InventoryAdjustmentsList"; cmd.ExecuteNonQuery();
                            cmd.CommandText = "Delete From INV_InventoryAdjustmentsHead"; cmd.ExecuteNonQuery();
                            cmd.CommandText = "Delete From INV_InventoryMoveList"; cmd.ExecuteNonQuery();
                            cmd.CommandText = "Delete From INV_InventoryMoveHead"; cmd.ExecuteNonQuery();
                            cmd.CommandText = "Delete From INV_ReturnedGoodsReportList"; cmd.ExecuteNonQuery();
                            cmd.CommandText = "Delete From INV_ReturnedGoodsReportHead"; cmd.ExecuteNonQuery();
                            cmd.CommandText = "Delete From INV_SpecialWarehouseReceiptList"; cmd.ExecuteNonQuery();
                            cmd.CommandText = "Delete From INV_SpecialWarehouseReceiptHead"; cmd.ExecuteNonQuery();
                            cmd.CommandText = "Delete From INV_SpecialWarehouseWarrantList"; cmd.ExecuteNonQuery();
                            cmd.CommandText = "Delete From INV_SpecialWarehouseWarrantHead"; cmd.ExecuteNonQuery();
                            cmd.CommandText = "Delete From INV_WarehouseReceiptApprovalInfo"; cmd.ExecuteNonQuery();
                            cmd.CommandText = "Delete From INV_WarehouseReceiptList"; cmd.ExecuteNonQuery();
                            cmd.CommandText = "Delete From INV_WarehouseReceiptHead"; cmd.ExecuteNonQuery();
                            cmd.CommandText = "Delete From INV_WarehouseApprovalInfo"; cmd.ExecuteNonQuery();
                            cmd.CommandText = "Delete From INV_WarehouseWarrantList"; cmd.ExecuteNonQuery();
                            cmd.CommandText = "Delete From INV_WarehouseWarrantHead"; cmd.ExecuteNonQuery();
                        }

                        if (clearPURBool)//采购模块
                        {
                            cmd.CommandText = "Delete From PUR_SettlementApprovalInfo"; cmd.ExecuteNonQuery();
                            cmd.CommandText = "Delete From PUR_SettlementList"; cmd.ExecuteNonQuery();
                            cmd.CommandText = "Delete From PUR_SettlementHead"; cmd.ExecuteNonQuery();
                            cmd.CommandText = "Delete From PUR_OrderApprovalInfo"; cmd.ExecuteNonQuery();
                            cmd.CommandText = "Delete From PUR_OrderList"; cmd.ExecuteNonQuery();
                            cmd.CommandText = "Delete From PUR_OrderHead"; cmd.ExecuteNonQuery();
                            cmd.CommandText = "Delete From PUR_PrApprovalInfo"; cmd.ExecuteNonQuery();
                            cmd.CommandText = "Delete From PUR_PrReqList"; cmd.ExecuteNonQuery();
                            cmd.CommandText = "Delete From PUR_PrReqHead"; cmd.ExecuteNonQuery();                            
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
        /// 清空基础资料
        /// </summary>
        public void ClearBasicData()
        {
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);

                        cmd.CommandText = "Delete From PUR_ApprovalList"; cmd.ExecuteNonQuery();
                        cmd.CommandText = "Delete From PUR_ApprovalType"; cmd.ExecuteNonQuery();
                        cmd.CommandText = "Delete From PUR_PayTypeList"; cmd.ExecuteNonQuery();
                        cmd.CommandText = "Delete From PUR_PayType"; cmd.ExecuteNonQuery();
                        cmd.CommandText = "Delete From PUR_PurCategory"; cmd.ExecuteNonQuery();

                        cmd.CommandText = "Delete From BS_BussinessFinancialInfo"; cmd.ExecuteNonQuery();
                        cmd.CommandText = "Delete From BS_BussinessDetailInfo"; cmd.ExecuteNonQuery();
                        cmd.CommandText = "Delete From BS_BussinessBaseInfo"; cmd.ExecuteNonQuery();
                        cmd.CommandText = "Delete From BS_BussinessCategory"; cmd.ExecuteNonQuery();
                        cmd.CommandText = "Delete From BS_CountryCodeManagement"; cmd.ExecuteNonQuery();

                        cmd.CommandText = "Delete From BS_CollectionTypeList"; cmd.ExecuteNonQuery();
                        cmd.CommandText = "Delete From BS_CollectionType"; cmd.ExecuteNonQuery();
                        cmd.CommandText = "Delete From BS_DeliveryLocation"; cmd.ExecuteNonQuery();
                        cmd.CommandText = "Delete From BS_ManufactureInfo"; cmd.ExecuteNonQuery();
                        cmd.CommandText = "Delete From BS_RepertoryInfo"; cmd.ExecuteNonQuery();
                        cmd.CommandText = "Delete From BS_ShelfInfo"; cmd.ExecuteNonQuery();
                        cmd.CommandText = "Delete From BS_WarehouseReceiptType"; cmd.ExecuteNonQuery();
                        cmd.CommandText = "Delete From BS_WarehouseWarrantType"; cmd.ExecuteNonQuery();
                        cmd.CommandText = "Delete From BS_StnList"; cmd.ExecuteNonQuery();
                        cmd.CommandText = "Delete From BS_ProjectList"; cmd.ExecuteNonQuery();

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
