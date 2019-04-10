using PSAP.DAO.BSDAO;
using PSAP.DAO.INVDAO;
using PSAP.PSAPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeifenLuo.WinFormsUI.Docking;

namespace PSAP.VIEW.BSVIEW
{
    public partial class FrmSpecialWarehouseReceiptQuery : DockContent
    {
        FrmCommonDAO commonDAO = new FrmCommonDAO();
        FrmSpecialWarehouseReceiptDAO swrDAO = new FrmSpecialWarehouseReceiptDAO();

        /// <summary>
        /// 最后一次查询的SQL
        /// </summary>
        string lastQuerySqlStr = "";

        public FrmSpecialWarehouseReceiptQuery()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmSpecialWarehouseReceiptQuery_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime nowDate = BaseSQL.GetServerDateTime();
                dateSWRDateBegin.DateTime = nowDate.Date.AddDays(-SystemInfo.OrderQueryDate_DefaultDays);
                dateSWRDateEnd.DateTime = nowDate.Date;

                lookUpReqDep.Properties.DataSource = commonDAO.QueryDepartment(true);
                lookUpReqDep.ItemIndex = 0;
                lookUpRepertoryNo.Properties.DataSource = commonDAO.QueryRepertoryInfo(true);
                lookUpRepertoryNo.ItemIndex = 0;
                comboBoxWarehouseState.SelectedIndex = 0;
                lookUpPrepared.Properties.DataSource = commonDAO.QueryUserInfo(true);
                lookUpPrepared.EditValue = SystemInfo.user.EmpName;

                repLookUpReqDep.DataSource = commonDAO.QueryDepartment(false);
                repLookUpRepertoryNo.DataSource = commonDAO.QueryRepertoryInfo(false);
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
        /// 设定列表显示信息
        /// </summary>
        private void gridViewSWRHead_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "WarehouseState")
            {
                e.DisplayText = CommonHandler.Get_WarehouseState_Desc(e.Value.ToString());
            }
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewSWRHead_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            ControlHandler.GridView_CustomDrawRowIndicator(e);
        }

        /// <summary>
        /// 获取单元格显示的信息
        /// </summary>
        private void gridViewSWRHead_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
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
        /// 查询按钮事件
        /// </summary>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                if (dateSWRDateBegin.EditValue == null || dateSWRDateEnd.EditValue == null)
                {
                    MessageHandler.ShowMessageBox("预算外出库日期不能为空，请设置后重新进行查询。");
                    if (dateSWRDateBegin.EditValue == null)
                        dateSWRDateBegin.Focus();
                    else
                        dateSWRDateEnd.Focus();
                    return;
                }
                string swrDateBeginStr = dateSWRDateBegin.DateTime.ToString("yyyy-MM-dd");
                string swrDateEndStr = dateSWRDateEnd.DateTime.AddDays(1).ToString("yyyy-MM-dd");

                string reqDepStr = lookUpReqDep.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpReqDep.EditValue) : "";
                string repertoryNoStr = lookUpRepertoryNo.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpRepertoryNo.EditValue) : "";

                int warehouseStateInt = CommonHandler.Get_WarehouseState_No(comboBoxWarehouseState.Text);
                string empNameStr = lookUpPrepared.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpPrepared.EditValue) : "";
                string commonStr = textCommon.Text.Trim();

                dataSet_SWR.Tables[0].Rows.Clear();
                string querySqlStr = swrDAO.QuerySpecialWarehouseReceiptHead_SQL(swrDateBeginStr, swrDateEndStr, reqDepStr, repertoryNoStr, warehouseStateInt, empNameStr, -1, commonStr, false);
                lastQuerySqlStr = querySqlStr;
                string countSqlStr = commonDAO.QuerySqlTranTotalCountSql(querySqlStr);

                gridBottomOrderHead.QueryGridData(ref dataSet_SWR, "SWRHead", querySqlStr, countSqlStr, true);
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
                //FileHandler.SaveDevGridControlExportToExcel(gridViewSWRHead);
                if (gridBottomOrderHead.pageCount <= 1)
                    FileHandler.SaveDevGridControlExportToExcel(gridViewSWRHead);
                else
                    commonDAO.SaveExcel_QueryAllData(dataSet_SWR.Tables[0], lastQuerySqlStr, gridViewSWRHead);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--查询结果存为Excel错误。", ex);
            }
        }

        /// <summary>
        /// 双击查询明细
        /// </summary>
        private void gridViewSWRHead_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (e.Clicks == 2)
                {
                    string swrHeadNoStr = DataTypeConvert.GetString(gridViewSWRHead.GetFocusedDataRow()["SpecialWarehouseReceipt"]);
                    FrmSpecialWarehouseReceipt.querySWRHeadNo = swrHeadNoStr;
                    //FrmWarehouseReceipt_Drag.queryListAutoId = 0;
                    ViewHandler.ShowRightWindow("FrmSpecialWarehouseReceipt");
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--双击查询明细错误。", ex);
            }
        }
    }
}
