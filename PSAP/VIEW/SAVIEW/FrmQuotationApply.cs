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
    public partial class FrmQuotationApply : DockContent
    {
        #region 私有变量

        FrmCommonDAO commonDAO = new FrmCommonDAO();
        FrmQuotationInfoDAO quoDAO = new FrmQuotationInfoDAO();

        #endregion

        #region 构造方法

        public FrmQuotationApply()
        {
            InitializeComponent();
        }

        #endregion

        #region 页面事件

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmQuotationApply_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime nowDate = BaseSQL.GetServerDateTime();
                dateRecordDateBegin.DateTime = nowDate.Date.AddDays(-SystemInfo.OrderQueryDate_DefaultDays);
                dateRecordDateEnd.DateTime = nowDate.Date;

                searchLookUpBussinessBaseNo.Properties.DataSource = commonDAO.QueryBussinessBaseInfo(true);
                searchLookUpBussinessBaseNo.Text = "全部";
                lookUpPrepared.Properties.DataSource = commonDAO.QueryUserInfo(true);
                lookUpPrepared.EditValue = "全部";

                repSearchBussinessBaseNo.DataSource = commonDAO.QueryBussinessBaseInfo(false);

                repLookUpCurrencyCate.DataSource = commonDAO.QueryCurrencyCate(false);

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
        /// 根据报价单号查询报价信息
        /// </summary>
        private void gridViewQuotationBaseInfo_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                TableQuotationPriceInfo.Rows.Clear();
                if (gridViewQuotationBaseInfo.GetFocusedDataRow() != null)
                {
                    string autoQuotationNoStr = DataTypeConvert.GetString(gridViewQuotationBaseInfo.GetFocusedDataRow()["AutoQuotationNo"]);
                    quoDAO.QueryQuotationPriceInfo(TableQuotationPriceInfo, autoQuotationNoStr);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--根据报价单号查询报价信息错误。", ex);
            }
        }

        /// <summary>
        /// 双击确认选择
        /// </summary>
        private void gridViewQuotationBaseInfo_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Clicks == 2 && e.Button == MouseButtons.Left)
            {
                BtnConfirm_Click(null, null);
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

                quoDAO.QueryQuotationBaseInfo_NotInSalesOrder(dataSet_Quotation.Tables[0], recordDateBeginStr, recordDateEndStr, bussinessBaseNoStr, empNameStr, commonStr);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--查询按钮事件错误。", ex);
            }
        }

        /// <summary>
        /// 确定选择报价单
        /// </summary>
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataSet_Quotation.Tables[0].Rows.Count == 0 || gridViewQuotationBaseInfo.GetFocusedDataRow() == null || gridViewQuotationPriceInfo.GetFocusedDataRow() == null)
                {
                    MessageHandler.ShowMessageBox("请选择要适用的报价单版本报价信息。");
                    return;
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--确定选择报价单错误。", ex);
            }
        }

        #endregion
    }
}
