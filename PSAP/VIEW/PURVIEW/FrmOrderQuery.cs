using DevExpress.XtraGrid.Views.Base;
using PSAP.DAO.BSDAO;
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
        FrmOrderDAO orderDAO = new FrmOrderDAO();
        FrmCommonDAO commonDAO = new FrmCommonDAO();

        /// <summary>
        /// 请购单明细AutoId
        /// </summary>
        public static int prReqListAutoId = 0;

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
                lookUpReqDep.Properties.DataSource = commonDAO.QueryDepartment(true);
                lookUpReqDep.ItemIndex = 0;
                lookUpPurCategory.Properties.DataSource = commonDAO.QueryPurCategory(true);
                lookUpPurCategory.ItemIndex = 0;
                comboBoxReqState.SelectedIndex = 0;
                lookUpPrepared.Properties.DataSource = commonDAO.QueryUserInfo(true);
                lookUpPrepared.EditValue = SystemInfo.user.EmpName;
                searchLookUpBussinessBaseNo.Properties.DataSource = commonDAO.QueryBussinessBaseInfo(true);
                searchLookUpBussinessBaseNo.Text = "全部";

                repLookUpReqDep.DataSource = commonDAO.QueryDepartment(false);
                repLookUpPurCategory.DataSource = commonDAO.QueryPurCategory(false);
                repSearchProjectNo.DataSource = commonDAO.QueryProjectList(false);
                repSearchBussinessBaseNo.DataSource = commonDAO.QueryBussinessBaseInfo(false);
                repLookUpApprovalType.DataSource = commonDAO.QueryApprovalType(false);
                repLookUpPayTypeNo.DataSource = commonDAO.QueryPayType(false);

                DateTime nowDate = BaseSQL.GetServerDateTime();
                dateOrderDateBegin.DateTime = nowDate.Date.AddDays(-SystemInfo.OrderQueryDate_DefaultDays);
                dateOrderDateEnd.DateTime = nowDate.Date;
                datePlanDateBegin.DateTime = nowDate.Date;
                datePlanDateEnd.DateTime = nowDate.Date.AddDays(SystemInfo.OrderQueryDate_DefaultDays);
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
        /// 窗体激活事件
        /// </summary>
        private void FrmOrderQuery_Activated(object sender, EventArgs e)
        {
            try
            {
                if (prReqListAutoId != 0)
                {
                    spinprReqListAutoId.Value = prReqListAutoId;
                    prReqListAutoId = 0;
                    checkprReqListAutoId.Checked = true;

                    DateTime nowDate = BaseSQL.GetServerDateTime();
                    dateOrderDateBegin.DateTime = nowDate.AddMonths(-6);
                    dateOrderDateEnd.DateTime = nowDate.AddMonths(6);
                    lookUpReqDep.ItemIndex = 0;
                    lookUpPurCategory.ItemIndex = 0;
                    searchLookUpBussinessBaseNo.Text = "全部";
                    comboBoxReqState.SelectedIndex = 0;
                    lookUpPrepared.ItemIndex = 0;
                    checkPlanDate.Checked = false;
                    textCommon.Text = "";

                    btnQuery_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--窗体激活事件错误。", ex);
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
        /// 选择请购单明细ID
        /// </summary>
        private void checkprReqListAutoId_CheckedChanged(object sender, EventArgs e)
        {
            if (checkprReqListAutoId.Checked)
            {
                spinprReqListAutoId.Enabled = true;
            }
            else
            {
                spinprReqListAutoId.Enabled = false;
            }
        }

        /// <summary>
        /// 设定列表显示信息
        /// </summary>
        private void gridViewPrReqHead_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "ReqState")
            {
                e.DisplayText = CommonHandler.Get_OrderState_Desc(e.Value.ToString());
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
                    planDateEndStr = datePlanDateEnd.DateTime.AddDays(1).ToString("yyyy-MM-dd");
                }

                string reqDepStr = lookUpReqDep.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpReqDep.EditValue) : "";
                string purCategoryStr = lookUpPurCategory.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpPurCategory.EditValue) : "";
                string bussinessBaseNoStr = DataTypeConvert.GetString(searchLookUpBussinessBaseNo.EditValue) != "全部" ? DataTypeConvert.GetString(searchLookUpBussinessBaseNo.EditValue) : "";
                int reqStateInt = comboBoxReqState.SelectedIndex > 0 ? comboBoxReqState.SelectedIndex : 0;
                string empNameStr = lookUpPrepared.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpPrepared.EditValue) : "";
                string commonStr = textCommon.Text.Trim();
                int prReqListAutoIdInt = (checkprReqListAutoId.Checked && spinprReqListAutoId.Value > 0) ? DataTypeConvert.GetInt(spinprReqListAutoId.Value) : 0;
                dataSet_Order.Tables[0].Clear();

                string querySqlStr = orderDAO.QueryOrderHead_SQL(orderDateBeginStr, orderDateEndStr, planDateBeginStr, planDateEndStr, reqDepStr, purCategoryStr, bussinessBaseNoStr, reqStateInt, empNameStr, -1, commonStr, prReqListAutoIdInt, false);

                string countSqlStr = commonDAO.QuerySqlTranTotalCountSql(querySqlStr);
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
                    FrmOrder_Drag.queryOrderHeadNo = orderHeadNoStr;
                    FrmOrder_Drag.queryListAutoId = 0;
                    ViewHandler.ShowRightWindow("FrmOrder_Drag");
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--双击查询明细错误。", ex);
            }
        }


    }
}
