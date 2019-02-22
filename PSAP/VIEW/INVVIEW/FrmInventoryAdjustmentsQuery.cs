﻿using PSAP.DAO.BSDAO;
using PSAP.DAO.INVDAO;
using PSAP.PSAPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PSAP.VIEW.BSVIEW
{
    public partial class FrmInventoryAdjustmentsQuery : DockContent
    {
        FrmCommonDAO commonDAO = new FrmCommonDAO();
        FrmInventoryAdjustmentsDAO iaDAO = new FrmInventoryAdjustmentsDAO();

        public FrmInventoryAdjustmentsQuery()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmInventoryAdjustmentsQuery_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime nowDate = BaseSQL.GetServerDateTime();
                dateIADateBegin.DateTime = nowDate.Date.AddDays(-SystemInfo.OrderQueryDate_DefaultDays);
                dateIADateEnd.DateTime = nowDate.Date;

                lookUpAdjustmentsRepertoryNo.Properties.DataSource = commonDAO.QueryRepertoryInfo(true);
                lookUpAdjustmentsRepertoryNo.ItemIndex = 0;
                lookUpReqDep.Properties.DataSource = commonDAO.QueryDepartment(true);
                lookUpReqDep.ItemIndex = 0;
                lookUpPrepared.Properties.DataSource = commonDAO.QueryUserInfo(true);
                lookUpPrepared.EditValue = SystemInfo.user.EmpName;
                searchAdjustmentsProjectNo.Properties.DataSource = commonDAO.QueryProjectList(true);
                searchAdjustmentsProjectNo.Text = "全部";

                repLookUpInRepertoryNo.DataSource = commonDAO.QueryRepertoryInfo(false);
                repSearchAdjustmentsProjectNo.DataSource = commonDAO.QueryProjectList(false);
                repLookUpReqDep.DataSource = commonDAO.QueryDepartment(false);

                gridBottomIA.pageRowCount = SystemInfo.OrderQueryGrid_PageRowCount;

                btnQuery_Click(null, null);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
            }
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewIAHead_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        /// <summary>
        /// 查询按钮事件
        /// </summary>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                if (dateIADateBegin.EditValue == null || dateIADateEnd.EditValue == null)
                {
                    MessageHandler.ShowMessageBox("调整日期不能为空，请设置后重新进行查询。");
                    if (dateIADateBegin.EditValue == null)
                        dateIADateBegin.Focus();
                    else
                        dateIADateEnd.Focus();
                    return;
                }
                string orderDateBeginStr = dateIADateBegin.DateTime.ToString("yyyy-MM-dd");
                string orderDateEndStr = dateIADateEnd.DateTime.AddDays(1).ToString("yyyy-MM-dd");

                string repertoryNoStr = lookUpAdjustmentsRepertoryNo.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpAdjustmentsRepertoryNo.EditValue) : "";
                string projectNoStr = searchAdjustmentsProjectNo.Text != "全部" ? DataTypeConvert.GetString(searchAdjustmentsProjectNo.EditValue) : "";
                string reqDepStr = lookUpReqDep.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpReqDep.EditValue) : "";
                string empNameStr = lookUpPrepared.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpPrepared.EditValue) : "";
                string commonStr = textCommon.Text.Trim();

                dataSet_IA.Tables[0].Clear();
                string querySqlStr = iaDAO.QueryInventoryAdjustmentsHead_SQL(orderDateBeginStr, orderDateEndStr, repertoryNoStr, projectNoStr, reqDepStr, empNameStr, commonStr, false);


                string countSqlStr = commonDAO.QuerySqlTranTotalCountSql(querySqlStr);
                gridBottomIA.QueryGridData(ref dataSet_IA, "IAHead", querySqlStr, countSqlStr, true);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--查询按钮事件错误。", ex);
            }
        }

        /// <summary>
        /// 查询结果存为Excel
        /// </summary>
        private void btnSaveExcel_Click(object sender, EventArgs e)
        {
            try
            {
                FileHandler.SaveDevGridControlExportToExcel(gridViewIAHead);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--查询结果存为Excel错误。", ex);
            }
        }

        /// <summary>
        /// 双击查询明细
        /// </summary>
        private void gridViewIAHead_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (e.Clicks == 2)
                {
                    string inventoryAdjustmentsNoStr = DataTypeConvert.GetString(gridViewIAHead.GetFocusedDataRow()["InventoryAdjustmentsNo"]);
                    FrmInventoryAdjustments_Drag.queryIAHeadNo = inventoryAdjustmentsNoStr;
                    FrmInventoryAdjustments_Drag.queryListAutoId = 0;
                    ViewHandler.ShowRightWindow("FrmInventoryAdjustments_Drag");
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--双击查询明细错误。", ex);
            }
        }

    }
}