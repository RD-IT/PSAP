using PSAP.DAO.BSDAO;
using PSAP.DAO.PURDAO;
using PSAP.PSAPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PSAP.VIEW.BSVIEW
{
    public partial class FrmSettlementQuery : DockContent
    {
        FrmSettlementDAO setDAO = new FrmSettlementDAO();
        FrmCommonDAO commonDAO = new FrmCommonDAO();

        /// <summary>
        /// 入库单明细的AutoId
        /// </summary>
        public static int wwListAutoId = 0;        

        public FrmSettlementQuery()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件错误
        /// </summary>
        private void FrmSettlementQuery_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime nowDate = BaseSQL.GetServerDateTime();
                dateSettlementDateBegin.DateTime = nowDate.Date.AddDays(-SystemInfo.OrderQueryDate_DefaultDays);
                dateSettlementDateEnd.DateTime = nowDate.Date;
                datePayDateBegin.DateTime = nowDate.Date;
                datePayDateEnd.DateTime = nowDate.Date.AddDays(SystemInfo.OrderQueryDate_DefaultDays);
                checkPayDate.Checked = false;

                searchLookUpBussinessBaseNo.Properties.DataSource = commonDAO.QueryBussinessBaseInfo(true);
                searchLookUpBussinessBaseNo.Text = "全部";
                lookUpReqDep.Properties.DataSource = commonDAO.QueryDepartment(true);
                lookUpReqDep.ItemIndex = 0;
                comboBoxWarehouseState.SelectedIndex = 0;
                lookUpPrepared.Properties.DataSource = commonDAO.QueryUserInfo(true);
                lookUpPrepared.EditValue = SystemInfo.user.EmpName;

                repSearchBussinessBaseNo.DataSource = commonDAO.QueryBussinessBaseInfo(false);
                repLookUpReqDep.DataSource = commonDAO.QueryDepartment(false);
                repLookUpApprovalType.DataSource = commonDAO.QueryApprovalType(false);

                gridBottomOrderHead.pageRowCount = SystemInfo.OrderQueryGrid_PageRowCount;

                if (textCommon.Text == "")
                {
                    btnQuery_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
            }
        }

        /// <summary>
        /// 窗体激活事件
        /// </summary>
        private void FrmSettlementQuery_Activated(object sender, EventArgs e)
        {
            try
            {
                if (wwListAutoId != 0)
                {
                    spinwwListAutoId.Value = wwListAutoId;
                    wwListAutoId = 0;
                    checkwwListAutoId.Checked = true;

                    DateTime nowDate = BaseSQL.GetServerDateTime();
                    dateSettlementDateBegin.DateTime = nowDate.AddMonths(-6);
                    dateSettlementDateEnd.DateTime = nowDate.AddMonths(6);
                    searchLookUpBussinessBaseNo.Text = "全部";
                    lookUpReqDep.ItemIndex = 0;
                    comboBoxWarehouseState.SelectedIndex = 0;
                    lookUpPrepared.ItemIndex = 0;
                    checkPayDate.Checked = false;
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
        /// 选择付款日期
        /// </summary>
        private void checkPayDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPayDate.Checked)
            {
                datePayDateBegin.Enabled = true;
                datePayDateEnd.Enabled = true;
            }
            else
            {
                datePayDateBegin.Enabled = false;
                datePayDateEnd.Enabled = false;
            }
        }

        /// <summary>
        /// 选择入库单明细ID
        /// </summary>
        private void checkwwListAutoId_CheckedChanged(object sender, EventArgs e)
        {
            if (checkwwListAutoId.Checked)
            {
                spinwwListAutoId.Enabled = true;
            }
            else
            {
                spinwwListAutoId.Enabled = false;
            }
        }

        /// <summary>
        /// 设定列表显示信息
        /// </summary>
        private void gridViewSettlementHead_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "WarehouseState")
            {
                e.DisplayText = CommonHandler.Get_WarehouseState_Desc(e.Value.ToString());
            }
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewSettlementHead_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
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
                string orderDateBeginStr = dateSettlementDateBegin.DateTime.ToString("yyyy-MM-dd");
                string orderDateEndStr = dateSettlementDateEnd.DateTime.AddDays(1).ToString("yyyy-MM-dd");
                string payDateBeginStr = "";
                string payDateEndStr = "";
                if (checkPayDate.Checked)
                {
                    payDateBeginStr = datePayDateBegin.DateTime.ToString("yyyy-MM-dd");
                    payDateEndStr = datePayDateEnd.DateTime.AddDays(1).ToString("yyyy-MM-dd");
                }

                string bussinessBaseNoStr = DataTypeConvert.GetString(searchLookUpBussinessBaseNo.EditValue) != "全部" ? DataTypeConvert.GetString(searchLookUpBussinessBaseNo.EditValue) : "";
                string reqDepStr = lookUpReqDep.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpReqDep.EditValue) : "";
                int wStateInt = comboBoxWarehouseState.SelectedIndex > 0 ? comboBoxWarehouseState.SelectedIndex : 0;
                string empNameStr = lookUpPrepared.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpPrepared.EditValue) : "";
                string commonStr = textCommon.Text.Trim();
                int wwListAutoIdInt = (checkwwListAutoId.Checked && spinwwListAutoId.Value > 0) ? DataTypeConvert.GetInt(spinwwListAutoId.Value) : 0;
                dataSet_Settlement.Tables[0].Clear();

                string querySqlStr = setDAO.QuerySettlementHead_SQL(orderDateBeginStr, orderDateEndStr, payDateBeginStr, payDateEndStr, reqDepStr, bussinessBaseNoStr, wStateInt, empNameStr, -1, commonStr, wwListAutoIdInt, false);

                string countSqlStr = commonDAO.QuerySqlTranTotalCountSql(querySqlStr);

                gridBottomOrderHead.QueryGridData(ref dataSet_Settlement, "SettlementHead", querySqlStr, countSqlStr, true);
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
                FileHandler.SaveDevGridControlExportToExcel(gridViewSettlementHead);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--查询结果存为Excel错误。", ex);
            }
        }

        /// <summary>
        /// 双击查询明细
        /// </summary>
        private void gridViewSettlementHead_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (e.Clicks == 2)
                {
                    string settlementNoStr = DataTypeConvert.GetString(gridViewSettlementHead.GetFocusedDataRow()["SettlementNo"]);
                    FrmSettlement_Drag.querySettlementNo = settlementNoStr;
                    //FrmWarehouseWarrant_Drag.queryListAutoId = 0;
                    ViewHandler.ShowRightWindow("FrmSettlement_Drag");
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--双击查询明细错误。", ex);
            }
        }

        
    }
}
