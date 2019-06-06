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
    public partial class FrmQuotationInfoQuery : DockContent
    {
        #region 私有变量

        FrmCommonDAO commonDAO = new FrmCommonDAO();
        FrmQuotationInfoDAO quoDAO = new FrmQuotationInfoDAO();

        /// <summary>
        /// 最后一次查询的SQL
        /// </summary>
        string lastQuerySqlStr = "";

        #endregion

        #region 构造方法

        public FrmQuotationInfoQuery()
        {
            InitializeComponent();
        }

        #endregion

        #region 页面事件

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmQuotationInfoQuery_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime nowDate = BaseSQL.GetServerDateTime();
                dateRecordDateBegin.DateTime = nowDate.Date.AddDays(-SystemInfo.OrderQueryDate_DefaultDays);
                dateRecordDateEnd.DateTime = nowDate.Date;

                searchLookUpBussinessBaseNo.Properties.DataSource = commonDAO.QueryBussinessBaseInfo(true);
                searchLookUpBussinessBaseNo.Text = "全部";
                lookUpPrepared.Properties.DataSource = commonDAO.QueryUserInfo(true);
                lookUpPrepared.EditValue = SystemInfo.user.EmpName;
                lookUpQState.Properties.DataSource = CommonHandler.GetQuotationInfoStateTable(true);
                lookUpQState.ItemIndex = 0;

                repSearchBussinessBaseNo.DataSource = commonDAO.QueryBussinessBaseInfo(false);
                repLookUpQState.DataSource = CommonHandler.GetQuotationInfoStateTable(false);

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
        private void gridViewQuotationBaseInfo_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            ControlHandler.GridView_CustomDrawRowIndicator(e);
        }

        /// <summary>
        /// 获取单元格显示的信息
        /// </summary>
        private void gridViewQuotationBaseInfo_KeyDown(object sender, KeyEventArgs e)
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
                if (dateRecordDateBegin.EditValue == null || dateRecordDateEnd.EditValue == null)
                {
                    MessageHandler.ShowMessageBox("登记日期不能为空，请设置后重新进行查询。");
                    if (dateRecordDateBegin.EditValue == null)
                        dateRecordDateBegin.Focus();
                    else
                        dateRecordDateEnd.Focus();
                    return;
                }
                string recordDateBeginStr = dateRecordDateBegin.DateTime.ToString("yyyy-MM-dd");
                string recordDateEndStr = dateRecordDateEnd.DateTime.AddDays(1).ToString("yyyy-MM-dd");

                string bussinessBaseNoStr = DataTypeConvert.GetString(searchLookUpBussinessBaseNo.EditValue) != "全部" ? DataTypeConvert.GetString(searchLookUpBussinessBaseNo.EditValue) : "";
                string empNameStr = lookUpPrepared.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpPrepared.EditValue) : "";
                string commonStr = textCommon.Text.Trim();

                dataSet_Quotation.Tables[0].Rows.Clear();

                int qStateInt = -1;
                switch(lookUpQState.ItemIndex)
                {
                    case 1:
                        qStateInt = 0;
                        break;
                    case 2:
                        qStateInt = 1;
                        break;
                }

                string querySqlStr = quoDAO.QueryQuotationBaseInfoAndCor_SQL(recordDateBeginStr, recordDateEndStr, bussinessBaseNoStr, empNameStr, commonStr,qStateInt);
                lastQuerySqlStr = querySqlStr;
                string countSqlStr = commonDAO.QuerySqlTranTotalCountSql(querySqlStr);

                gridBottomOrderHead.QueryGridData(ref dataSet_Quotation, "QuotationBaseInfo", querySqlStr, countSqlStr, true);
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
                //FileHandler.SaveDevGridControlExportToExcel(gridViewQuotationBaseInfo);
                if (gridBottomOrderHead.pageCount <= 1)
                    FileHandler.SaveDevGridControlExportToExcel(gridViewQuotationBaseInfo);
                else
                    commonDAO.SaveExcel_QueryAllData(dataSet_Quotation.Tables[0], lastQuerySqlStr, gridViewQuotationBaseInfo);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--查询结果存为Excel错误。", ex);
            }
        }

        /// <summary>
        /// 双击查询明细
        /// </summary>
        private void gridViewQuotationBaseInfo_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (e.Clicks == 2 && e.Button == MouseButtons.Left)
                {
                    string autoQuotationNoStr = DataTypeConvert.GetString(gridViewQuotationBaseInfo.GetFocusedDataRow()["AutoQuotationNo"]);
                    FrmQuotationInfo_History.queryAutoQuotationNoStr = autoQuotationNoStr;
                    //FrmWarehouseWarrant_Drag.queryListAutoId = 0;
                    ViewHandler.ShowRightWindow("FrmQuotationInfo_History");
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--双击查询明细错误。", ex);
            }
        }

        #endregion
    }
}
