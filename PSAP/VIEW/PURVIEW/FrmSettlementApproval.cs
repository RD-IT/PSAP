using PSAP.DAO.PURDAO;
using PSAP.PSAPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PSAP.VIEW.BSVIEW
{
    public partial class FrmSettlementApproval : DockContent
    {
        /// <summary>
        /// 结账单号
        /// </summary>
        string settlementNoStr = "";

        FrmApprovalDAO approvalDAO = new FrmApprovalDAO();
        FrmSettlementDAO setDAO = new FrmSettlementDAO();

        public FrmSettlementApproval()
        {
            InitializeComponent();
        }

        public FrmSettlementApproval(string settlementNo)
        {
            InitializeComponent();
            this.settlementNoStr = settlementNo;
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmSettlementApproval_Load(object sender, EventArgs e)
        {
            try
            {
                lookUpApprovalType.Properties.DataSource = new DAO.BSDAO.FrmCommonDAO().QueryApprovalType(false);

                approvalDAO.QuerySettlementHead(dataSet_Settlement.Tables[0], settlementNoStr);
                if (dataSet_Settlement.Tables[0].Rows.Count == 0)
                {
                    MessageHandler.ShowMessageBox("查询采购结账单信息错误，请重新操作。");
                    return;
                }
                string typeNoStr = DataTypeConvert.GetString(dataSet_Settlement.Tables[0].Rows[0]["ApprovalType"]);
                int approvalCatInt = DataTypeConvert.GetInt(dataSet_Settlement.Tables[0].Rows[0]["ApprovalCat"]);
                approvalDAO.QuerySettlementApprovalInfo(dataSet_Settlement.Tables[1], settlementNoStr, typeNoStr);

                if (approvalCatInt == 0)
                {
                    for (int i = 0; i < dataSet_Settlement.Tables[1].Rows.Count; i++)
                    {
                        if (DataTypeConvert.GetString(dataSet_Settlement.Tables[1].Rows[i]["SettlementNo"]) == "")
                        {
                            if (DataTypeConvert.GetInt(dataSet_Settlement.Tables[1].Rows[i]["Approver"]) != SystemInfo.user.AutoId)
                                btnApproval.Enabled = false;
                            else
                                btnApproval.Enabled = true;
                            return;
                        }
                    }
                }
                else if (approvalCatInt == 1 || approvalCatInt == 2)
                {
                    if (dataSet_Settlement.Tables[1].Select(string.Format("IsNull(SettlementNo,'')='' and Approver={0}", SystemInfo.user.AutoId)).Length == 0)
                    {
                        btnApproval.Enabled = false;
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
            }
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewSettleAppInfo_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        /// <summary>
        /// 设定状态显示文字
        /// </summary>
        private void textReqState_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (e.Value != null)
            {
                e.DisplayText = CommonHandler.Get_WarehouseState_Desc(e.Value.ToString());
            }
        }

        /// <summary>
        /// 设定审批方式显示文字
        /// </summary>
        private void textApprovalCat_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (e.Value != null)
            {
                e.DisplayText = CommonHandler.Get_ApprovalCat_Desc(e.Value.ToString());
            }
        }

        /// <summary>
        /// 审批按钮事件
        /// </summary>
        private void btnApproval_Click(object sender, EventArgs e)
        {
            try
            {
                dataSet_Settlement.Tables[0].Rows[0]["Select"] = true;
                int successCountInt = 0;
                if (!setDAO.SettlementApprovalInfo_Multi(dataSet_Settlement.Tables[0], ref successCountInt))
                {

                }
                if (successCountInt > 0)
                {
                    MessageHandler.ShowMessageBox("审批成功。");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--审批按钮事件错误。", ex);
            }
        }

        /// <summary>
        /// 关闭
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
