﻿using PSAP.DAO.PURDAO;
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
    public partial class FrmOrderApproval : DockContent
    {
        /// <summary>
        /// 采购单号
        /// </summary>
        string orderHeadNoStr = "";

        FrmOrderDAO orderDAO = new FrmOrderDAO();
        FrmApprovalDAO approvalDAO = new FrmApprovalDAO();
        static PSAP.VIEW.BSVIEW.FrmLanguageText f = new VIEW.BSVIEW.FrmLanguageText();

        public FrmOrderApproval()
        {
            InitializeComponent();
            PSAP.BLL.BSBLL.BSBLL.language(f);
            PSAP.BLL.BSBLL.BSBLL.language(this);
        }

        public FrmOrderApproval(string orderHeadNo)
        {
            InitializeComponent();
            this.orderHeadNoStr = orderHeadNo;
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmApprovalOrder_Load(object sender, EventArgs e)
        {
            try
            {
                lookUpApprovalType.Properties.DataSource = new DAO.BSDAO.FrmCommonDAO().QueryApprovalType(false);

                approvalDAO.QueryOrderHead(dataSet_Order.Tables[0], orderHeadNoStr);
                if (dataSet_Order.Tables[0].Rows.Count == 0)
                {
                    MessageHandler.ShowMessageBox(tsmiCxcgddxxcw.Text);// ("查询采购订单信息错误，请重新操作。");
                    return;
                }
                string typeNoStr = DataTypeConvert.GetString(dataSet_Order.Tables[0].Rows[0]["ApprovalType"]);
                int approvalCatInt = DataTypeConvert.GetInt(dataSet_Order.Tables[0].Rows[0]["ApprovalCat"]);
                approvalDAO.QueryOrderApprovalInfo(dataSet_Order.Tables[1], orderHeadNoStr, typeNoStr);

                if (approvalCatInt == 0)
                {
                    for (int i = 0; i < dataSet_Order.Tables[1].Rows.Count; i++)
                    {
                        if (DataTypeConvert.GetString(dataSet_Order.Tables[1].Rows[i]["OrderHeadNo"]) == "")
                        {
                            if (DataTypeConvert.GetInt(dataSet_Order.Tables[1].Rows[i]["Approver"]) != SystemInfo.user.AutoId)
                                btnApproval.Enabled = false;
                            else
                                btnApproval.Enabled = true;
                            return;
                        }
                    }
                }
                else if (approvalCatInt == 1 || approvalCatInt == 2)
                {
                    if (dataSet_Order.Tables[1].Select(string.Format("IsNull(OrderHeadNo,'')='' and Approver={0}", SystemInfo.user.AutoId)).Length == 0)
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
        private void gridViewOrderAppInfo_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
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
                e.DisplayText = CommonHandler.Get_OrderState_Desc(e.Value.ToString());
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
                dataSet_Order.Tables[0].Rows[0]["Select"] = true;
                int successCountInt = 0;
                if (!orderDAO.OrderApprovalInfo_Multi(dataSet_Order.Tables[0], ref successCountInt))
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
