using DevExpress.XtraGrid.Views.Grid;
using PSAP.DAO.BSDAO;
using PSAP.DAO.SADAO;
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
    public partial class FrmStnSummary_Query : DockContent
    {
        #region 私有变量

        FrmCommonDAO commonDAO = new FrmCommonDAO();
        FrmStnSummaryDAO ssDAO = new FrmStnSummaryDAO();

        /// <summary>
        /// 最后一次查询的SQL
        /// </summary>
        string lastQuerySqlStr = "";

        #endregion

        #region 构造方法

        public FrmStnSummary_Query()
        {
            InitializeComponent();
        }

        #endregion

        #region 页面事件

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmStnSummary_Query_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime nowDate = BaseSQL.GetServerDateTime();
                dateGetTimeBegin.DateTime = nowDate.Date.AddDays(-SystemInfo.OrderQueryDate_DefaultDays);
                dateGetTimeEnd.DateTime = nowDate.Date;

                searchLookUpStnModule.Properties.DataSource = ssDAO.QueryStnModule(true);
                searchLookUpStnModule.Text = "全部";
                lookUpPrepared.Properties.DataSource = commonDAO.QueryUserInfo(true);
                lookUpPrepared.EditValue = SystemInfo.user.EmpName;

                gridBottomOrderHead.pageRowCount = SystemInfo.OrderQueryGrid_PageRowCount;

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
        private void gridViewStnSummaryList_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            ControlHandler.GridView_CustomDrawRowIndicator(e);
        }

        /// <summary>
        /// 获取单元格显示的信息
        /// </summary>
        private void gridViewStnSummaryList_KeyDown(object sender, KeyEventArgs e)
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
                if (dateGetTimeBegin.EditValue == null || dateGetTimeEnd.EditValue == null)
                {
                    MessageHandler.ShowMessageBox("登记日期不能为空，请设置后重新进行查询。");
                    if (dateGetTimeBegin.EditValue == null)
                        dateGetTimeBegin.Focus();
                    else
                        dateGetTimeEnd.Focus();
                    return;
                }
                string getDateBeginStr = dateGetTimeBegin.DateTime.ToString("yyyy-MM-dd");
                string getDateEndStr = dateGetTimeEnd.DateTime.AddDays(1).ToString("yyyy-MM-dd");

                string smNoStr = DataTypeConvert.GetString(searchLookUpStnModule.EditValue) != "全部" ? DataTypeConvert.GetString(searchLookUpStnModule.EditValue) : "";
                string empNameStr = lookUpPrepared.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpPrepared.EditValue) : "";
                string commonStr = textCommon.Text.Trim();

                dataSet_StnSummaryList.Tables[0].Clear();

                string querySqlStr = ssDAO.QueryStnSummaryList_SQL(getDateBeginStr, getDateEndStr, smNoStr, empNameStr, commonStr, false);
                lastQuerySqlStr = querySqlStr;
                string countSqlStr = commonDAO.QuerySqlTranTotalCountSql(querySqlStr);

                gridBottomOrderHead.QueryGridData(ref dataSet_StnSummaryList, "StnSummaryList", querySqlStr, countSqlStr, true);
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
                //FileHandler.SaveDevGridControlExportToExcel(gridViewStnSummaryList);
                if (gridBottomOrderHead.pageCount <= 1)
                    FileHandler.SaveDevGridControlExportToExcel(gridViewStnSummaryList);
                else
                    commonDAO.SaveExcel_QueryAllData(dataSet_StnSummaryList.Tables[0], lastQuerySqlStr, gridViewStnSummaryList);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--查询结果存为Excel错误。", ex);
            }
        }

        /// <summary>
        /// 双击查询明细
        /// </summary>
        private void gridViewStnSummaryList_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (e.Clicks == 2 && e.Button == MouseButtons.Left)
                {
                    string autoQuotationNoStr = DataTypeConvert.GetString(gridViewStnSummaryList.GetFocusedDataRow()["AutoQuotationNo"]);
                    //string ssNoStr = DataTypeConvert.GetString(gridViewStnSummaryList.GetFocusedDataRow()["SSNo"]);
                    int stnSummaryListAutoIdInt = DataTypeConvert.GetInt(gridViewStnSummaryList.GetFocusedDataRow()["AutoId"]);
                    int listModuleAutoIdInt = DataTypeConvert.GetInt(gridViewStnSummaryList.GetFocusedDataRow()["ListModuleAutoId"]);
                    FrmStnSummary.queryAutoQuotationNoStr = autoQuotationNoStr;
                    //FrmStnSummary.querySSNoStr = ssNoStr;
                    FrmStnSummary.queryStnSummaryListAutoIdInt = stnSummaryListAutoIdInt;
                    FrmStnSummary.queryListModuleAutoIdInt = listModuleAutoIdInt;
                    ViewHandler.ShowRightWindow("FrmStnSummary");
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--双击查询明细错误。", ex);
            }
        }        

        /// <summary>
        /// 设置Grid单元格合并
        /// </summary>
        private void gridViewStnSummaryList_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                string firstColumnFieldName = "AutoId";

                switch (e.Column.FieldName)
                {
                    case "StnNo":
                    case "StnDesc":
                    case "GetTime":
                    case "Prepared":
                        {
                            string valueFirstColumn1 = Convert.ToString(view.GetRowCellValue(e.RowHandle1, firstColumnFieldName));
                            string valueFirstColumn2 = Convert.ToString(view.GetRowCellValue(e.RowHandle2, firstColumnFieldName));
                            string valueOtherColumn1 = Convert.ToString(view.GetRowCellValue(e.RowHandle1, e.Column.FieldName));
                            string valueOtherColumn2 = Convert.ToString(view.GetRowCellValue(e.RowHandle2, e.Column.FieldName));
                            e.Merge = valueFirstColumn1 == valueFirstColumn2 && valueOtherColumn1 == valueOtherColumn2;
                            e.Handled = true;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--设置Grid单元格合并错误。", ex);
            }
        }

        #endregion
    }
}
