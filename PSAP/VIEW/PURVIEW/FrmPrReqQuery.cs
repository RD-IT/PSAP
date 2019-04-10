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
    public partial class FrmPrReqQuery : DockContent
    {
        FrmPrReqDAO prReqDAO = new FrmPrReqDAO();
        FrmCommonDAO commonDAO = new FrmCommonDAO();

        /// <summary>
        /// 最后一次查询的SQL
        /// </summary>
        string lastQuerySqlStr = "";

        public FrmPrReqQuery()
        {
            InitializeComponent();
            PSAP.BLL.BSBLL.BSBLL.language(this);
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmPrReqQuery_Load(object sender, EventArgs e)
        {
            try
            {
                lookUpReqDep.Properties.DataSource = commonDAO.QueryDepartment(true);
                lookUpReqDep.ItemIndex = 0;
                lookUpPurCategory.Properties.DataSource = commonDAO.QueryPurCategory(true);
                lookUpPurCategory.ItemIndex = 0;
                comboBoxReqState.SelectedIndex = 0;
                lookUpApplicant.Properties.DataSource = commonDAO.QueryUserInfo(true);
                lookUpApplicant.EditValue = SystemInfo.user.EmpName;
                repositoryItemLookUpEdit1.DataSource = commonDAO.QueryDepartment(false);
                repositoryItemLookUpEdit2.DataSource = commonDAO.QueryPurCategory(false);

                DateTime nowDate = BaseSQL.GetServerDateTime();
                dateReqDateBegin.DateTime = nowDate.Date.AddDays(-SystemInfo.OrderQueryDate_DefaultDays);
                dateReqDateEnd.DateTime = nowDate.Date;

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
            ControlHandler.GridView_CustomDrawRowIndicator(e);
        }

        /// <summary>
        /// 获取单元格显示的信息
        /// </summary>
        private void gridViewPrReqHead_KeyDown(object sender, KeyEventArgs e)
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
                int reqStateInt = CommonHandler.Get_OrderState_No(comboBoxReqState.Text); 
                string empNameStr = lookUpApplicant.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpApplicant.EditValue) : "";
                string commonStr = textCommon.Text.Trim();
                dataSet_PrReq.Tables[0].Clear();
                //prReqDAO.QueryPrReqHead(dataSet_PrReq.Tables[0], dateReqDateBegin.DateTime.ToString("yyyy-MM-dd"), dateReqDateEnd.DateTime.AddDays(1).ToString("yyyy-MM-dd"), reqDepStr, purCategoryStr, reqStateInt, empNameStr, commonStr, false);

                string querySqlStr = prReqDAO.QueryPrReqHead_SQL(reqDateBeginStr, reqDateEndStr, reqDepStr, purCategoryStr, reqStateInt, empNameStr, -1, commonStr, false);
                lastQuerySqlStr = querySqlStr;
                string countSqlStr = commonDAO.QuerySqlTranTotalCountSql(querySqlStr);
                gridBottomPrReq.QueryGridData(ref dataSet_PrReq, "PrReqHead", querySqlStr, countSqlStr, true);
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
                //FileHandler.SaveDevGridControlExportToExcel(gridViewPrReqHead);
                if (gridBottomPrReq.pageCount <= 1)
                    FileHandler.SaveDevGridControlExportToExcel(gridViewPrReqHead);
                else
                    commonDAO.SaveExcel_QueryAllData(dataSet_PrReq.Tables[0], lastQuerySqlStr, gridViewPrReqHead);
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
        private void gridViewPrReqHead_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (e.Clicks == 2)
                {
                    string prReqNoStr = DataTypeConvert.GetString(gridViewPrReqHead.GetFocusedDataRow()["PrReqNo"]);
                    FrmPrReq.queryPrReqNo = prReqNoStr;
                    FrmPrReq.queryListAutoId = 0;
                    ViewHandler.ShowRightWindow("FrmPrReq");
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--双击查询明细错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiSjcx.Text, ex);
            }
        }

    }
}
