using DevExpress.XtraGrid.Views.Base;
using PSAP.DAO.BSDAO;
using PSAP.DAO.INVDAO;
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
    public partial class FrmWarehouseWarrantQuery : DockContent
    {
        FrmWarehouseWarrantDAO wwDAO = new FrmWarehouseWarrantDAO();
        FrmCommonDAO commonDAO = new FrmCommonDAO();

        /// <summary>
        /// 采购订单明细ID
        /// </summary>
        public static int orderListAutoId = 0;

        public FrmWarehouseWarrantQuery()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件错误
        /// </summary>
        private void FrmWarehouseWarrantQuery_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime nowDate = BaseSQL.GetServerDateTime();
                dateWWDateBegin.DateTime = nowDate.Date.AddDays(-SystemInfo.OrderQueryDate_DefaultDays);
                dateWWDateEnd.DateTime = nowDate.Date;

                lookUpReqDep.Properties.DataSource = commonDAO.QueryDepartment(true);
                lookUpReqDep.ItemIndex = 0;
                searchLookUpBussinessBaseNo.Properties.DataSource = commonDAO.QueryBussinessBaseInfo(true);
                searchLookUpBussinessBaseNo.Text = "全部";
                lookUpRepertoryNo.Properties.DataSource = commonDAO.QueryRepertoryInfo(true);
                lookUpRepertoryNo.ItemIndex = 0;
                lookUpWarehouseWarrantTypeNo.Properties.DataSource = wwDAO.QueryWarehouseWarrantType(true);
                lookUpWarehouseWarrantTypeNo.ItemIndex = 0;
                comboBoxWarehouseState.SelectedIndex = 0;
                lookUpPrepared.Properties.DataSource = commonDAO.QueryUserInfo(true);
                lookUpPrepared.EditValue = SystemInfo.user.EmpName;

                repLookUpReqDep.DataSource = commonDAO.QueryDepartment(false);
                repLookUpRepertoryNo.DataSource = commonDAO.QueryRepertoryInfo(false);
                repLookUpWWTypeNo.DataSource = wwDAO.QueryWarehouseWarrantType(false);
                repSearchBussinessBaseNo.DataSource = commonDAO.QueryBussinessBaseInfo(false);
                repLookUpApprovalType.DataSource = commonDAO.QueryApprovalType(false);

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
        private void FrmWarehouseWarrantQuery_Activated(object sender, EventArgs e)
        {
            try
            {
                if (orderListAutoId != 0)
                {
                    spinorderListAutoId.Value = orderListAutoId;
                    orderListAutoId = 0;
                    checkorderListAutoId.Checked = true;

                    DateTime nowDate = BaseSQL.GetServerDateTime();
                    dateWWDateBegin.DateTime = nowDate.AddMonths(-6);
                    dateWWDateEnd.DateTime = nowDate.AddMonths(6);
                    searchLookUpBussinessBaseNo.Text = "全部";
                    lookUpRepertoryNo.ItemIndex = 0;
                    lookUpReqDep.ItemIndex = 0;
                    lookUpWarehouseWarrantTypeNo.ItemIndex = 0;
                    comboBoxWarehouseState.SelectedIndex = 0;
                    lookUpPrepared.ItemIndex = 0;
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
        /// 选择采购单明细ID
        /// </summary>
        private void checkorderListAutoId_CheckedChanged(object sender, EventArgs e)
        {
            if (checkorderListAutoId.Checked)
            {
                spinorderListAutoId.Enabled = true;
            }
            else
            {
                spinorderListAutoId.Enabled = false;
            }
        }

        /// <summary>
        /// 设定列表显示信息
        /// </summary>
        private void gridViewWWHead_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "WarehouseState")
            {
                e.DisplayText = CommonHandler.Get_WarehouseState_Desc(e.Value.ToString());
            }
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewWWHead_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
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
                string orderDateBeginStr = dateWWDateBegin.DateTime.ToString("yyyy-MM-dd");
                string orderDateEndStr = dateWWDateEnd.DateTime.AddDays(1).ToString("yyyy-MM-dd");

                string reqDepStr = lookUpReqDep.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpReqDep.EditValue) : "";
                string bussinessBaseNoStr = DataTypeConvert.GetString(searchLookUpBussinessBaseNo.EditValue) != "全部" ? DataTypeConvert.GetString(searchLookUpBussinessBaseNo.EditValue) : "";
                string repertoryNoStr = lookUpRepertoryNo.ItemIndex > 0 ? lookUpRepertoryNo.EditValue.ToString() : "";
                string wwTypeNoStr = lookUpWarehouseWarrantTypeNo.ItemIndex > 0 ? lookUpWarehouseWarrantTypeNo.EditValue.ToString() : "";

                int warehouseStateInt = comboBoxWarehouseState.SelectedIndex > 0 ? comboBoxWarehouseState.SelectedIndex : 0;
                string empNameStr = lookUpPrepared.ItemIndex > 0 ? lookUpPrepared.EditValue.ToString() : "";
                string commonStr = textCommon.Text.Trim();
                int orderListAutoIdInt = (checkorderListAutoId.Checked && spinorderListAutoId.Value > 0) ? DataTypeConvert.GetInt(spinorderListAutoId.Value) : 0;

                dataSet_WW.Tables[0].Rows.Clear();
                string querySqlStr = wwDAO.QueryWarehouseWarrantHead_SQL(orderDateBeginStr, orderDateEndStr, reqDepStr, bussinessBaseNoStr, repertoryNoStr, wwTypeNoStr, warehouseStateInt, empNameStr, -1, commonStr, orderListAutoIdInt, false);

                string countSqlStr = commonDAO.QuerySqlTranTotalCountSql(querySqlStr);

                gridBottomOrderHead.QueryGridData(ref dataSet_WW, "WWHead", querySqlStr, countSqlStr, true);
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
                FileHandler.SaveDevGridControlExportToExcel(gridViewWWHead);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--查询结果存为Excel错误。", ex);
            }
        }

        /// <summary>
        /// 双击查询明细
        /// </summary>
        private void gridViewWWHead_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (e.Clicks == 2)
                {
                    string wwHeadNoStr = DataTypeConvert.GetString(gridViewWWHead.GetFocusedDataRow()["WarehouseWarrant"]);
                    FrmWarehouseWarrant_Drag.queryWWHeadNo = wwHeadNoStr;
                    //FrmWarehouseWarrant_Drag.queryListAutoId = 0;
                    ViewHandler.ShowRightWindow("FrmWarehouseWarrant_Drag");
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--双击查询明细错误。", ex);
            }
        }
    }
}
