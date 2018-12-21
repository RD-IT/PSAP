using DevExpress.XtraGrid.Views.Base;
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
    public partial class FrmOrderQuery : DockContent
    {
        FrmPrReqDAO prReqDAO = new FrmPrReqDAO();
        FrmOrderDAO orderDAO = new FrmOrderDAO();

        public FrmOrderQuery()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件错误
        /// </summary>
        private void FrmOrderQuery_Load(object sender, EventArgs e)
        {
            try
            {
                lookUpReqDep.Properties.DataSource = prReqDAO.QueryDepartment(true);
                lookUpReqDep.ItemIndex = 0;
                lookUpPurCategory.Properties.DataSource = prReqDAO.QueryPurCategory(true);
                lookUpPurCategory.ItemIndex = 0;
                comboBoxReqState.SelectedIndex = 0;
                lookUpPrepared.Properties.DataSource = prReqDAO.QueryUserInfo(true);
                lookUpPrepared.EditValue = SystemInfo.user.EmpName;
                searchLookUpBussinessBaseNo.Properties.DataSource = orderDAO.QueryBussinessBaseInfo(true);
                searchLookUpBussinessBaseNo.Text = "全部";

                repLookUpReqDep.DataSource = prReqDAO.QueryDepartment(false);
                repLookUpPurCategory.DataSource = prReqDAO.QueryPurCategory(false);
                repSearchProjectNo.DataSource = prReqDAO.QueryProjectList(false);
                repSearchBussinessBaseNo.DataSource = orderDAO.QueryBussinessBaseInfo(false);
                repLookUpApprovalType.DataSource = orderDAO.QueryApprovalType(false);
                repLookUpPayTypeNo.DataSource = orderDAO.QueryPayType(false);

                dateOrderDateBegin.DateTime = DateTime.Now.Date.AddDays(-7);
                dateOrderDateEnd.DateTime = DateTime.Now.Date;
                datePlanDateBegin.DateTime = DateTime.Now.Date;
                datePlanDateEnd.DateTime = DateTime.Now.Date.AddDays(7);
                checkPlanDate.Checked = false;

                gridBottomOrderHead.pageRowCount = SystemInfo.OrderQueryGrid_PageRowCount;

                btnQuery_Click(null, null);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
            }
        }

        /// <summary>
        /// 选择计划到货日期
        /// </summary>
        private void checkPlanDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPlanDate.Checked)
            {
                datePlanDateBegin.Enabled = true;
                datePlanDateEnd.Enabled = true;
            }
            else
            {
                datePlanDateBegin.Enabled = false;
                datePlanDateEnd.Enabled = false;
            }
        }

        /// <summary>
        /// 设定列表显示信息
        /// </summary>
        private void gridViewPrReqHead_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "ReqState")
            {
                if (e.Value.ToString() == "1")
                    e.DisplayText = "待审批";
                else if (e.Value.ToString() == "2")
                    e.DisplayText = "审批";
                else if (e.Value.ToString() == "4")
                    e.DisplayText = "审批中";
                else
                    e.DisplayText = "关闭";
            }
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewPrReqHead_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
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
                string orderDateBeginStr = dateOrderDateBegin.DateTime.ToString("yyyy-MM-dd");
                string orderDateEndStr = dateOrderDateEnd.DateTime.AddDays(1).ToString("yyyy-MM-dd");
                string planDateBeginStr = "";
                string planDateEndStr = "";
                if (checkPlanDate.Checked)
                {
                    planDateBeginStr = datePlanDateBegin.DateTime.ToString("yyyy-MM-dd");
                    planDateEndStr = datePlanDateEnd.DateTime.ToString("yyyy-MM-dd");
                }

                string reqDepStr = lookUpReqDep.ItemIndex > 0 ? lookUpReqDep.EditValue.ToString() : "";
                string purCategoryStr = lookUpPurCategory.ItemIndex > 0 ? lookUpPurCategory.EditValue.ToString() : "";
                string bussinessBaseNoStr = searchLookUpBussinessBaseNo.EditValue.ToString() != "全部" ? searchLookUpBussinessBaseNo.EditValue.ToString() : "";
                int reqStateInt = comboBoxReqState.SelectedIndex > 0 ? comboBoxReqState.SelectedIndex : 0;
                string empNameStr = lookUpPrepared.ItemIndex > 0 ? lookUpPrepared.EditValue.ToString() : "";
                string commonStr = textCommon.Text.Trim();
                dataSet_Order.Tables[0].Clear();

                string querySqlStr = orderDAO.QueryOrderHead_SQL(orderDateBeginStr, orderDateEndStr, planDateBeginStr, planDateEndStr, reqDepStr, purCategoryStr, bussinessBaseNoStr, reqStateInt, empNameStr, -1, commonStr, false);

                string countSqlStr = prReqDAO.QuerySqlTranTotalCountSql(querySqlStr);
                gridBottomOrderHead.QueryGridData(ref dataSet_Order, "OrderHead", querySqlStr, countSqlStr, true);
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
                FileHandler.SaveDevGridControlExportToExcel(gridViewPrReqHead);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--查询结果存为Excel错误。", ex);
            }
        }

        /// <summary>
        /// 双击查询明细
        /// </summary>
        private void gridViewPrReqHead_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (e.Clicks == 2)
                {
                    string orderHeadNoStr = DataTypeConvert.GetString(gridViewPrReqHead.GetFocusedDataRow()["OrderHeadNo"]);
                    FrmOrder.queryOrderHeadNo = orderHeadNoStr;
                    ViewHandler.ShowRightWindow("FrmOrder");
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--双击查询明细错误。", ex);
            }
        }

        
    }
}
