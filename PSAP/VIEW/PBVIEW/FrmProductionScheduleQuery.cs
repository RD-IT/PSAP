using PSAP.DAO.BSDAO;
using PSAP.DAO.PBDAO;
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
    public partial class FrmProductionScheduleQuery : DockContent
    {
        FrmCommonDAO commonDAO = new FrmCommonDAO();
        FrmProductionScheduleDAO psDAO = new FrmProductionScheduleDAO();

        /// <summary>
        /// 最后一次查询的SQL
        /// </summary>
        string lastQuerySqlStr = "";

        public FrmProductionScheduleQuery()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmProductionScheduleQuery_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime nowDate = BaseSQL.GetServerDateTime();
                dateCurrentDateBegin.DateTime = nowDate.Date.AddDays(-SystemInfo.OrderQueryDate_DefaultDays);
                dateCurrentDateEnd.DateTime = nowDate.Date;
                dateReqDateBegin.DateTime = nowDate.Date;
                dateReqDateEnd.DateTime = nowDate.Date.AddDays(SystemInfo.OrderQueryDate_DefaultDays);
                checkReqDate.Checked = false;

                lookUpPrepared.Properties.DataSource = commonDAO.QueryUserInfo(true);
                lookUpPrepared.EditValue = SystemInfo.user.EmpName;

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
        /// 选择需求日期
        /// </summary>
        private void checkReqDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkReqDate.Checked)
            {
                dateReqDateBegin.Enabled = true;
                dateReqDateEnd.Enabled = true;
            }
            else
            {
                dateReqDateBegin.Enabled = false;
                dateReqDateEnd.Enabled = false;
            }
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewProductionSchedule_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            ControlHandler.GridView_CustomDrawRowIndicator(e);
        }

        /// <summary>
        /// 获取单元格显示的信息
        /// </summary>
        private void gridViewProductionSchedule_KeyDown(object sender, KeyEventArgs e)
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
                if (dateCurrentDateBegin.EditValue == null || dateCurrentDateEnd.EditValue == null)
                {
                    MessageHandler.ShowMessageBox("单据日期不能为空，请设置后重新进行查询。");
                    if (dateCurrentDateBegin.EditValue == null)
                        dateCurrentDateBegin.Focus();
                    else
                        dateCurrentDateEnd.Focus();
                    return;
                }
                string currentDateBeginStr = dateCurrentDateBegin.DateTime.ToString("yyyy-MM-dd");
                string currentDateEndStr = dateCurrentDateEnd.DateTime.AddDays(1).ToString("yyyy-MM-dd");
                string reqDateBeginStr = "";
                string reqDateEndStr = "";
                if (checkReqDate.Checked)
                {
                    if (dateReqDateBegin.EditValue == null || dateReqDateEnd.EditValue == null)
                    {
                        MessageHandler.ShowMessageBox("需求日期不能为空，请设置后重新进行查询。");
                        if (dateReqDateBegin.EditValue == null)
                            dateReqDateBegin.Focus();
                        else
                            dateReqDateEnd.Focus();
                        return;
                    }
                    reqDateBeginStr = dateReqDateBegin.DateTime.ToString("yyyy-MM-dd");
                    reqDateEndStr = dateReqDateEnd.DateTime.AddDays(1).ToString("yyyy-MM-dd");
                }

                string empNameStr = lookUpPrepared.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpPrepared.EditValue) : "";
                string commonStr = textCommon.Text.Trim();

                dataSet_PSchedule.Tables[0].Clear();

                string querySqlStr = psDAO.QueryProductionSchedule_SQL(currentDateBeginStr, currentDateEndStr, reqDateBeginStr, reqDateEndStr, empNameStr, commonStr, false);

                lastQuerySqlStr = querySqlStr;
                string countSqlStr = commonDAO.QuerySqlTranTotalCountSql(querySqlStr);

                gridBottomOrderHead.QueryGridData(ref dataSet_PSchedule, "ProductionSchedule", querySqlStr, countSqlStr, true);
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
                if (gridBottomOrderHead.pageCount <= 1)
                    FileHandler.SaveDevGridControlExportToExcel(gridViewProductionSchedule);
                else
                    commonDAO.SaveExcel_QueryAllData(dataSet_PSchedule.Tables[0], lastQuerySqlStr, gridViewProductionSchedule);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--查询结果存为Excel错误。", ex);
            }
        }

        /// <summary>
        /// 双击查询明细
        /// </summary>
        private void gridViewProductionSchedule_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (e.Clicks == 2)
                {
                    string psNoStr = DataTypeConvert.GetString(gridViewProductionSchedule.GetFocusedDataRow()["PsNo"]);
                    FrmProductionSchedule_Drag.queryPsNoStr = psNoStr;
                    ViewHandler.ShowRightWindow("FrmProductionSchedule_Drag");
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--双击查询明细错误。", ex);
            }
        }
    }
}
