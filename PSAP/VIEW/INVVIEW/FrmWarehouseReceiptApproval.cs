using PSAP.DAO.INVDAO;
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
    public partial class FrmWarehouseReceiptApproval : DockContent
    {
        /// <summary>
        /// 出库单号
        /// </summary>
        string wrHeadNoStr = "";

        FrmApprovalDAO approvalDAO = new FrmApprovalDAO();
        FrmWarehouseReceiptDAO wrDAO = new FrmWarehouseReceiptDAO();
        static PSAP.VIEW.BSVIEW.FrmLanguageText f = new VIEW.BSVIEW.FrmLanguageText();

        public FrmWarehouseReceiptApproval()
        {
            InitializeComponent();
            PSAP.BLL.BSBLL.BSBLL.language(f);
            PSAP.BLL.BSBLL.BSBLL.language(this);
        }

        public FrmWarehouseReceiptApproval(string wrHeadNo)
        {
            InitializeComponent();
            this.wrHeadNoStr = wrHeadNo;
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmWarehouseReceiptApproval_Load(object sender, EventArgs e)
        {
            try
            {
                lookUpApprovalType.Properties.DataSource = new DAO.BSDAO.FrmCommonDAO().QueryApprovalType(false);

                approvalDAO.QueryWarehouseReceiptHead(dataSet_WR.Tables[0], wrHeadNoStr);
                if (dataSet_WR.Tables[0].Rows.Count == 0)
                {
                    MessageHandler.ShowMessageBox(tsmiCxckdxxcwqcxcz.Text);// ("查询出库单信息错误，请重新操作。");
                    return;
                }
                string typeNoStr = DataTypeConvert.GetString(dataSet_WR.Tables[0].Rows[0]["ApprovalType"]);
                int approvalCatInt = DataTypeConvert.GetInt(dataSet_WR.Tables[0].Rows[0]["ApprovalCat"]);
                approvalDAO.QueryWarehouseReceiptApprovalInfo(dataSet_WR.Tables[1], wrHeadNoStr, typeNoStr);

                if (approvalCatInt == 0)
                {
                    for (int i = 0; i < dataSet_WR.Tables[1].Rows.Count; i++)
                    {
                        if (DataTypeConvert.GetString(dataSet_WR.Tables[1].Rows[i]["WarehouseReceipt"]) == "")
                        {
                            if (DataTypeConvert.GetInt(dataSet_WR.Tables[1].Rows[i]["Approver"]) != SystemInfo.user.AutoId)
                                btnApproval.Enabled = false;
                            else
                                btnApproval.Enabled = true;
                            return;
                        }
                    }
                }
                else if (approvalCatInt == 1 || approvalCatInt == 2)
                {
                    if (dataSet_WR.Tables[1].Select(string.Format("IsNull(WarehouseReceipt,'')='' and Approver={0}", SystemInfo.user.AutoId)).Length == 0)
                    {
                        btnApproval.Enabled = false;
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiCtjzsjcw.Text, ex);
            }
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewWRAppInfo_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            ControlHandler.GridView_CustomDrawRowIndicator(e);
        }

        /// <summary>
        /// 获取单元格显示的信息
        /// </summary>
        private void gridViewWRAppInfo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                ControlHandler.GridView_GetFocusedCellDisplayText_KeyDown(sender, e);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--获取单元格显示的信息错误。", ex);
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
                dataSet_WR.Tables[0].Rows[0]["Select"] = true;
                int successCountInt = 0;
                if (!wrDAO.WRApprovalInfo_Multi(dataSet_WR.Tables[0], ref successCountInt))
                {

                }
                if (successCountInt > 0)
                {
                    MessageHandler.ShowMessageBox(f.tsmiSpcg.Text);// ("审批成功。");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--审批按钮事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiSpansj.Text, ex);
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
