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
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PSAP.VIEW.BSVIEW
{
    public partial class FrmWarehouseNowInfo : DockContent
    {
        FrmCommonDAO commonDAO = new FrmCommonDAO();
        FrmWarehouseNowInfoDAO wNowInfoDAO = new FrmWarehouseNowInfoDAO();
        static PSAP.VIEW.BSVIEW.FrmLanguageText f = new VIEW.BSVIEW.FrmLanguageText();

        /// <summary>
        /// 最后一次查询的SQL
        /// </summary>
        string lastQuerySqlStr = "";

        public FrmWarehouseNowInfo()
        {
            InitializeComponent();
            PSAP.BLL.BSBLL.BSBLL.language(f);
            PSAP.BLL.BSBLL.BSBLL.language(this);
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmWarehouseNowInfo_Load(object sender, EventArgs e)
        {
            try
            {
                lookUpRepertoryNo.Properties.DataSource = commonDAO.QueryRepertoryInfo(true);
                lookUpRepertoryNo.ItemIndex = 0;
                searchLookUpProjectNo.Properties.DataSource = commonDAO.QueryProjectList(true);
                searchLookUpProjectNo.Text = "全部";
                searchLookUpCodeFileName.Properties.DataSource = commonDAO.QueryPartsCode(true);
                searchLookUpCodeFileName.Text = "全部";
                searchLookUpShelf.Properties.DataSource = commonDAO.QueryShelfInfo(true);
                searchLookUpShelf.EditValue = 0;

                gridBottomWNowInfo.pageRowCount = SystemInfo.OrderQueryGrid_PageRowCount;

                repLookUpRepertoryNo.DataSource = commonDAO.QueryRepertoryInfo(false);
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+f.tsmiCtjzsjcw.Text , ex);
            }
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewPrReqList_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            ControlHandler.GridView_CustomDrawRowIndicator(e);
        }

        /// <summary>
        /// 获取单元格显示的信息
        /// </summary>
        private void gridViewWNowInfo_KeyDown(object sender, KeyEventArgs e)
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
                string repertoryNoStr = lookUpRepertoryNo.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpRepertoryNo.EditValue) : "";
                string codeFileNameStr = searchLookUpCodeFileName.Text != "全部" ? DataTypeConvert.GetString(searchLookUpCodeFileName.EditValue) : "";
                string projectNameStr = searchLookUpProjectNo.Text != "全部" ? searchLookUpProjectNo.Text : "";                
                string shelfNoStr = searchLookUpShelf.Text != "全部" ? searchLookUpShelf.Text : "";
                string commonStr = textCommon.Text.Trim();

                string querySqlStr = wNowInfoDAO.QueryWarehouseNowInfo_SQL(codeFileNameStr, repertoryNoStr, projectNameStr, shelfNoStr, commonStr, !checkZero.Checked);
                lastQuerySqlStr = querySqlStr;
                string countSqlStr = commonDAO.QuerySqlTranTotalCountSql(querySqlStr);
                gridBottomWNowInfo.QueryGridData(ref dataSet_WNowInfo, "WNowInfo", querySqlStr, countSqlStr, true);
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--查询按钮事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+f.tsmiCxansjcw.Text , ex);
            }
        }

        /// <summary>
        /// 查询结果存为Excel
        /// </summary>
        private void btnSaveExcel_Click(object sender, EventArgs e)
        {
            try
            {
                //FileHandler.SaveDevGridControlExportToExcel(gridViewWNowInfo);
                if (gridBottomWNowInfo.pageCount <= 1)
                    FileHandler.SaveDevGridControlExportToExcel(gridViewWNowInfo);
                else
                    commonDAO.SaveExcel_QueryAllData(dataSet_WNowInfo.Tables[0], lastQuerySqlStr, gridViewWNowInfo);
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--查询结果存为Excel错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+f.tsmiCxjgcwexcelcw.Text , ex);
            }
        }

        /// <summary>
        /// 设置Grid单元格合并
        /// </summary>
        private void gridViewWNowInfo_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
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
                //ExceptionHandler.HandleException(this.Text + "--设置Grid单元格合并错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+f.tsmiSzgriddyghbcw.Text , ex);
            }
        }
    }
}
