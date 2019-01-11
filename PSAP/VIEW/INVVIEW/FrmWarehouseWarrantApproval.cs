﻿using PSAP.DAO.INVDAO;
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
    public partial class FrmWarehouseWarrantApproval : DockContent
    {
        /// <summary>
        /// 入库单号
        /// </summary>
        string wwHeadNoStr = "";

        FrmApprovalDAO approvalDAO = new FrmApprovalDAO();
        FrmWarehouseWarrantDAO wwDAO = new FrmWarehouseWarrantDAO();

        public FrmWarehouseWarrantApproval()
        {
            InitializeComponent();
        }

        public FrmWarehouseWarrantApproval(string wwHeadNo)
        {
            InitializeComponent();
            this.wwHeadNoStr = wwHeadNo;
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmApprovalWarehouseWarrant_Load(object sender, EventArgs e)
        {
            try
            {
                lookUpApprovalType.Properties.DataSource = new DAO.BSDAO.FrmCommonDAO().QueryApprovalType(false);

                approvalDAO.QueryWarehouseWarrantHead(dataSet_WW.Tables[0], wwHeadNoStr);
                if (dataSet_WW.Tables[0].Rows.Count == 0)
                {
                    MessageHandler.ShowMessageBox("查询入库单信息错误，请重新操作。");
                    return;
                }
                string typeNoStr = DataTypeConvert.GetString(dataSet_WW.Tables[0].Rows[0]["ApprovalType"]);
                int approvalCatInt = DataTypeConvert.GetInt(dataSet_WW.Tables[0].Rows[0]["ApprovalCat"]);
                approvalDAO.QueryWarehouseWarrantApprovalInfo(dataSet_WW.Tables[1], wwHeadNoStr, typeNoStr);

                if (approvalCatInt == 0)
                {
                    for (int i = 0; i < dataSet_WW.Tables[1].Rows.Count; i++)
                    {
                        if (DataTypeConvert.GetString(dataSet_WW.Tables[1].Rows[i]["WarehouseWarrant"]) == "")
                        {
                            if (DataTypeConvert.GetInt(dataSet_WW.Tables[1].Rows[i]["Approver"]) != SystemInfo.user.AutoId)
                                btnApproval.Enabled = false;
                            else
                                btnApproval.Enabled = true;
                            return;
                        }
                    }
                }
                else if (approvalCatInt == 1 || approvalCatInt == 2)
                {
                    if (dataSet_WW.Tables[1].Select(string.Format("IsNull(WarehouseWarrant,'')='' and Approver={0}", SystemInfo.user.AutoId)).Length == 0)
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
        private void gridViewWAppInfo_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
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
                dataSet_WW.Tables[0].Rows[0]["Select"] = true;
                int successCountInt = 0;
                if (!wwDAO.WWApprovalInfo_Multi(dataSet_WW.Tables[0], ref successCountInt))
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
