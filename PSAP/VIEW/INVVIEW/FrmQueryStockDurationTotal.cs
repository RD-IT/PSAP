using DevExpress.XtraGrid.Views.Grid;
using PSAP.DAO.BSDAO;
using PSAP.DAO.INVDAO;
using PSAP.PSAPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using WeifenLuo.WinFormsUI.Docking;

namespace PSAP.VIEW.BSVIEW
{
    public partial class FrmQueryStockDurationTotal : DockContent
    {
        FrmCommonDAO commonDAO = new FrmCommonDAO();
        FrmWarehouseNowInfoDAO wNowInfoDAO = new FrmWarehouseNowInfoDAO();

        public FrmQueryStockDurationTotal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmQueryStockDurationTotal_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime nowDate = BaseSQL.GetServerDateTime();
                dateDurBegin.DateTime = nowDate.Date.AddDays(-SystemInfo.OrderQueryDate_DefaultDays);
                dateDurEnd.DateTime = nowDate.Date;

                lookUpRepertoryNo.Properties.DataSource = commonDAO.QueryRepertoryInfo(true);
                lookUpRepertoryNo.ItemIndex = 0;
                searchLookUpProjectNo.Properties.DataSource = commonDAO.QueryProjectList(true);
                searchLookUpProjectNo.Text = "全部";
                searchLookUpCodeFileName.Properties.DataSource = commonDAO.QueryPartsCode(true);
                searchLookUpCodeFileName.Text = "全部";

                gridBottomWNowInfo.pageRowCount = SystemInfo.OrderQueryGrid_PageRowCount;

                repLookUpRepertoryNo.DataSource = commonDAO.QueryRepertoryInfo(false);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
            }
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewDurationStock_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
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
                if (dateDurBegin.EditValue == null || dateDurEnd.EditValue == null)
                {
                    MessageHandler.ShowMessageBox("期间日期不能为空，请设置后重新进行查询。");
                    if (dateDurBegin.EditValue == null)
                        dateDurBegin.Focus();
                    else
                        dateDurEnd.Focus();
                    return;
                }
                string durDateBeginStr = dateDurBegin.DateTime.ToString("yyyy-MM-dd");
                string durDateEndStr = dateDurEnd.DateTime.AddDays(1).ToString("yyyy-MM-dd");

                string repertoryNoStr = lookUpRepertoryNo.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpRepertoryNo.EditValue) : "";
                string codeFileNameStr = searchLookUpCodeFileName.Text != "全部" ? DataTypeConvert.GetString(searchLookUpCodeFileName.EditValue) : "";
                string projectNameStr = searchLookUpProjectNo.Text != "全部" ? searchLookUpProjectNo.Text : "";
                string commonStr = textCommon.Text.Trim();

                string querySqlStr = wNowInfoDAO.QueryStockDurationTotal_SQL(dateDurBegin.DateTime.Date, durDateBeginStr, durDateEndStr, repertoryNoStr, projectNameStr, codeFileNameStr, commonStr);
                string countSqlStr = commonDAO.QuerySqlTranTotalCountSql(querySqlStr);
                gridBottomWNowInfo.QueryGridData(ref dataSet_DurationStock, "DurationStock", querySqlStr, countSqlStr, true);
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
                FileHandler.SaveDevGridControlExportToExcel(gridViewDurationStock);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--查询结果存为Excel错误。", ex);
            }
        }

        /// <summary>
        /// 设置Grid单元格合并
        /// </summary>
        private void gridViewDurationStock_CellMerge(object sender, CellMergeEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                string firstColumnFieldName = "CodeFileName";

                switch (e.Column.FieldName)
                {
                    case "CodeName":
                    case "CodeNo":
                    case "CodeSpec":
                    case "Brand":
                    case "CatgName":
                    case "MaterialVersion":
                    case "CodeWeight":
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
    }
}
