using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class FrmPrReqListAndOrderList : DockContent
    {
        FrmPrReqDAO prReqDAO = new FrmPrReqDAO();
        FrmCommonDAO commonDAO = new FrmCommonDAO();

        /// <summary>
        /// 最后一次查询的SQL
        /// </summary>
        string lastQuerySqlStr = "";

        public FrmPrReqListAndOrderList()
        {
            InitializeComponent();
            PSAP.BLL.BSBLL.BSBLL.language(this);

        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmPrReqListAndOrderList_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime nowDate = BaseSQL.GetServerDateTime();
                dateReqDateBegin.DateTime = nowDate.Date.AddDays(-SystemInfo.OrderQueryDate_DefaultDays);
                dateReqDateEnd.DateTime = nowDate.Date;

                lookUpReqDep.Properties.DataSource = commonDAO.QueryDepartment(true);
                lookUpReqDep.ItemIndex = 0;
                lookUpPurCategory.Properties.DataSource = commonDAO.QueryPurCategory(true);
                lookUpPurCategory.ItemIndex = 0;
                searchLookUpProjectNo.Properties.DataSource = commonDAO.QueryProjectList(true);
                searchLookUpProjectNo.Text = "全部";
                searchLookUpCodeFileName.Properties.DataSource = commonDAO.QueryPartsCode(true);
                searchLookUpCodeFileName.Text = "全部";
                comboBoxReqState.SelectedIndex = 0;

                repLookUpReqDep.DataSource = commonDAO.QueryDepartment(false);
                repLookUpPurCategory.DataSource = commonDAO.QueryPurCategory(false);
                repLookUpProjectNo.DataSource = commonDAO.QueryProjectList(false);

                gridBottomPrReq.pageRowCount = SystemInfo.OrderQueryGrid_PageRowCount;

                btnQuery_Click(null, null);
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiCt.Text, ex);
            }
        }

        /// <summary>
        /// 设定列表显示信息
        /// </summary>
        private void gridViewPrReqList_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "ReqState" || e.Column.FieldName == "OrderState")
            {
                e.DisplayText = CommonHandler.Get_OrderState_Desc(e.Value.ToString());
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
        private void gridViewPrReqList_KeyDown(object sender, KeyEventArgs e)
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
                if (dateReqDateBegin.EditValue == null || dateReqDateEnd.EditValue == null)
                {
                    MessageHandler.ShowMessageBox(tsmiQgrq.Text);// ("请购日期不能为空，请设置后重新进行查询。");
                    if (dateReqDateBegin.EditValue == null)
                        dateReqDateBegin.Focus();
                    else
                        dateReqDateEnd.Focus();
                    return;
                }
                string reqDateBeginStr = dateReqDateBegin.DateTime.ToString("yyyy-MM-dd");
                string reqDateEndStr = dateReqDateEnd.DateTime.AddDays(1).ToString("yyyy-MM-dd");
                string reqDepStr = lookUpReqDep.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpReqDep.EditValue) : "";
                string purCategoryStr = lookUpPurCategory.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpPurCategory.EditValue) : "";
                string projectNoStr = searchLookUpProjectNo.Text != "全部" ? DataTypeConvert.GetString(searchLookUpProjectNo.EditValue) : "";
                int reqStateInt = CommonHandler.Get_OrderState_No(comboBoxReqState.Text); 
                string codeFileNameStr = searchLookUpCodeFileName.Text != "全部" ? DataTypeConvert.GetString(searchLookUpCodeFileName.EditValue) : "";
                string commonStr = textCommon.Text.Trim();
                dataSet_PrReq.Tables[0].Clear();

                string querySqlStr = prReqDAO.Query_PrReqListAndOrderList(reqDateBeginStr, reqDateEndStr, reqDepStr, purCategoryStr, projectNoStr, reqStateInt, codeFileNameStr, commonStr);
                lastQuerySqlStr = querySqlStr;
                string countSqlStr = commonDAO.QuerySqlTranTotalCountSql(querySqlStr);
                gridBottomPrReq.QueryGridData(ref dataSet_PrReq, "PrReqList", querySqlStr, countSqlStr, true);
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--查询按钮事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiCxan.Text, ex);
            }
        }

        /// <summary>
        /// 查询结果存为Excel
        /// </summary>
        private void btnSaveExcel_Click(object sender, EventArgs e)
        {
            try
            {
                //FileHandler.SaveDevGridControlExportToExcel(gridViewPrReqList);
                if (gridBottomPrReq.pageCount <= 1)
                    FileHandler.SaveDevGridControlExportToExcel(gridViewPrReqList);
                else
                    commonDAO.SaveExcel_QueryAllData(dataSet_PrReq.Tables[0], lastQuerySqlStr, gridViewPrReqList);
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--查询结果存为Excel错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiCxjgc.Text, ex);
            }
        }

        /// <summary>
        /// 双击查询明细
        /// </summary>
        private void gridViewPrReqList_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (e.Clicks == 2)
                {
                    string prReqNoStr = DataTypeConvert.GetString(gridViewPrReqList.GetFocusedDataRow()["PrReqNo"]);
                    int autoIdInt = DataTypeConvert.GetInt(gridViewPrReqList.GetFocusedDataRow()["AutoId"]);
                    FrmPrReq.queryPrReqNo = prReqNoStr;
                    FrmPrReq.queryListAutoId = autoIdInt;
                    ViewHandler.ShowRightWindow("FrmPrReq");
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--双击查询明细错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiSjcx.Text, ex);
            }
        }

        /// <summary>
        /// 设置Grid单元格合并
        /// </summary>
        private void gridViewPrReqList_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                string firstColumnFieldName = "AutoId";

                switch (e.Column.FieldName)
                {
                    case "PrReqNo":
                    case "ReqState":
                    case "ReqDate":
                    case "CodeFileName":
                    case "CodeName":
                    case "Qty":
                    case "ProjectNo":
                    case "StnNo":
                    case "ReqDep":
                    case "PurCategory":
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
                ExceptionHandler.HandleException(this.Text + "--" + tsmiSzgrid.Text, ex);
            }
        }

    }
}
