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
    public partial class FrmSelectQuotationInfo : DockContent
    {
        FrmCommonDAO commonDAO = new FrmCommonDAO();
        FrmStnSummaryDAO ssDAO = new FrmStnSummaryDAO();

        public FrmSelectQuotationInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmSelectQuotationInfo_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime nowDate = BaseSQL.GetServerDateTime();
                dateSalesOrderDateBegin.DateTime = nowDate.Date.AddDays(-SystemInfo.OrderQueryDate_DefaultDays);
                dateSalesOrderDateEnd.DateTime = nowDate.Date;

                searchLookUpBussinessBaseNo.Properties.DataSource = commonDAO.QueryBussinessBaseInfo(true);
                searchLookUpBussinessBaseNo.Text = "全部";
                lookUpPrepared.Properties.DataSource = commonDAO.QueryUserInfo(true);
                lookUpPrepared.EditValue = SystemInfo.user.EmpName;

                repSearchLookUpBussinessBaseNo.DataSource = commonDAO.QueryBussinessBaseInfo(false);
                repLookUpQState.DataSource = CommonHandler.GetQuotationInfoStateTable(false);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
            }
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewQuotation_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            ControlHandler.GridView_CustomDrawRowIndicator(e);
        }

        /// <summary>
        /// 获取单元格显示的信息
        /// </summary>
        private void gridViewQuotation_KeyDown(object sender, KeyEventArgs e)
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
                if (dateSalesOrderDateBegin.EditValue == null || dateSalesOrderDateEnd.EditValue == null)
                {
                    MessageHandler.ShowMessageBox("登记日期不能为空，请设置后重新进行查询。");
                    if (dateSalesOrderDateBegin.EditValue == null)
                        dateSalesOrderDateBegin.Focus();
                    else
                        dateSalesOrderDateEnd.Focus();
                    return;
                }

                string recordDateBeginStr = dateSalesOrderDateBegin.DateTime.ToString("yyyy-MM-dd");
                string recordDateEndStr = dateSalesOrderDateEnd.DateTime.AddDays(1).ToString("yyyy-MM-dd");

                string bussinessBaseNoStr = DataTypeConvert.GetString(searchLookUpBussinessBaseNo.EditValue) != "全部" ? DataTypeConvert.GetString(searchLookUpBussinessBaseNo.EditValue) : "";
                string empNameStr = lookUpPrepared.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpPrepared.EditValue) : "";
                string commonStr = textCommon.Text.Trim();

                dataSet_Quotation.Tables[0].Rows.Clear();
                ssDAO.QueryQuotationBaseInfo(dataSet_Quotation.Tables[0], recordDateBeginStr, recordDateEndStr, bussinessBaseNoStr, empNameStr, commonStr);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--查询按钮事件错误。", ex);
            }
        }

        /// <summary>
        /// 双击行确定
        /// </summary>
        private void gridViewQuotation_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (e.Clicks == 2 && e.Button == MouseButtons.Left)
                {
                    BtnConfirm_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--双击行确定错误。", ex);
            }
        }

        /// <summary>
        /// 确认按钮事件
        /// </summary>
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridViewQuotation.GetFocusedDataRow() == null)
                {
                    MessageHandler.ShowMessageBox("请选择要操作的报价单。");
                    return;
                }
                if(DataTypeConvert.GetInt(gridViewQuotation.GetFocusedDataRow()["QuotationState"]) == 1)
                {
                    MessageHandler.ShowMessageBox("报价单已经关闭，不可以再进行操作。");
                    return;
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--确认按钮事件错误。", ex);
            }
        }

    }
}
