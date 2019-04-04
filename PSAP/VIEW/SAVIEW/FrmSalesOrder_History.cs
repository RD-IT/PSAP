using DevExpress.XtraGrid.Views.Base;
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
    public partial class FrmSalesOrder_History : DockContent
    {
        #region 私有变量

        FrmCommonDAO commonDAO = new FrmCommonDAO();
        FrmSalesOrderDAO soDAO = new FrmSalesOrderDAO();
        FrmQuotationInfoDAO quoDAO = new FrmQuotationInfoDAO();

        /// <summary>
        /// 要查询的销售订单号
        /// </summary>
        public static string queryAutoSalesOrderNoStr = "";

        #endregion

        #region 构造方法

        public FrmSalesOrder_History()
        {
            InitializeComponent();
        }

        #endregion

        #region 窗体事件

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmSalesOrder_History_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable bussBaseTable = commonDAO.QueryBussinessBaseInfo(false);

                searchProjectName.Properties.DataSource = commonDAO.QueryProjectList(false);
                searchBussinessBaseNo.Properties.DataSource = bussBaseTable;
                lookUpCollectionTypeNo.Properties.DataSource = commonDAO.QueryCollectionType(false);
                lookUpCurrencyCate.Properties.DataSource = commonDAO.QueryCurrencyCate(false);

                DateTime nowDate = BaseSQL.GetServerDateTime();

                repSearchBussinessBaseNo.DataSource = bussBaseTable;

                dateSalesOrderDateBegin.DateTime = nowDate.Date.AddDays(-SystemInfo.OrderQueryDate_DefaultDays);
                dateSalesOrderDateEnd.DateTime = nowDate.Date;

                searchLookUpBussinessBaseNo.Properties.DataSource = commonDAO.QueryBussinessBaseInfo(true);
                searchLookUpBussinessBaseNo.Text = "全部";

                repSearchLookUpBussinessBaseNo.DataSource = bussBaseTable;

                Set_ButtonEditGrid_State(true);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
            }
        }

        /// <summary>
        /// 窗体激活事件
        /// </summary>
        private void FrmSalesOrder_History_Activated(object sender, EventArgs e)
        {
            try
            {
                if (queryAutoSalesOrderNoStr != "")
                {
                    textCommon.Text = queryAutoSalesOrderNoStr;
                    queryAutoSalesOrderNoStr = "";

                    searchLookUpBussinessBaseNo.Text = "全部";

                    dataSet_SalesOrder.Tables[0].Clear();
                    soDAO.QuerySalesOrder(dataSet_SalesOrder.Tables[0], "", "", "", "", "", textCommon.Text);
                    Set_ButtonEditGrid_State(true);

                    if (dataSet_SalesOrder.Tables[0].Rows.Count > 0)
                    {
                        dateSalesOrderDateBegin.DateTime = DataTypeConvert.GetDateTime(dataSet_SalesOrder.Tables[0].Rows[0]["SalesOrderDate"]).Date;
                        dateSalesOrderDateEnd.DateTime = dateSalesOrderDateBegin.DateTime.AddDays(7);
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--窗体激活事件错误。", ex);
            }
        }

        /// <summary>
        /// 窗体显示事件
        /// </summary>
        private void FrmSalesOrder_History_Shown(object sender, EventArgs e)
        {
            dockPnlLeft.Width = SystemInfo.DragForm_LeftDock_Width;
        }

        #endregion

        #region 右侧销售订单模块的相关事件和方法

        /// <summary>
        /// 选择适用报价单
        /// </summary>
        private void btnEditAutoQuotationNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                FrmQuotationApply quoApply = new FrmQuotationApply();
                if (quoApply.ShowDialog() == DialogResult.OK)
                {
                    DataRow dr = gridViewSalesOrder.GetFocusedDataRow();

                    DataRow selectBaseRow = quoApply.gridViewQuotationBaseInfo.GetFocusedDataRow();
                    DataRow selectPriceRow = quoApply.gridViewQuotationPriceInfo.GetFocusedDataRow();
                    string oldAutoQuotationNoStr = DataTypeConvert.GetString(dr["AutoQuotationNo"]);
                    string oldVersionsStr = DataTypeConvert.GetString(dr["QuotationVersions"]);
                    string autoQuotationNoStr = DataTypeConvert.GetString(selectBaseRow["AutoQuotationNo"]);
                    string VersionsStr = DataTypeConvert.GetString(selectPriceRow["Versions"]);
                    if (oldAutoQuotationNoStr != autoQuotationNoStr || oldVersionsStr != VersionsStr)
                    {
                        dataSet_Quotation.Tables[0].Rows.Clear();
                        quoDAO.QueryQuotationBaseInfo(dataSet_Quotation.Tables[0], "", "", "", "", autoQuotationNoStr);

                        string BussinessBaseNo = DataTypeConvert.GetString(selectBaseRow["BussinessBaseNo"]);

                        dr["AutoQuotationNo"] = autoQuotationNoStr;
                        btnEditAutoQuotationNo.Text = autoQuotationNoStr;
                        dr["BussinessBaseNo"] = BussinessBaseNo;
                        searchBussinessBaseNo.EditValue = BussinessBaseNo;
                        dr["QuotationVersions"] = VersionsStr;
                        lookUpQuotationVersions.EditValue = VersionsStr;

                        string ParentAutoSalesOrderNo = DataTypeConvert.GetString(selectBaseRow["ParentAutoSalesOrderNo"]);
                        if (ParentAutoSalesOrderNo != "")
                        {
                            string ParentProjectNo = DataTypeConvert.GetString(selectBaseRow["ParentProjectNo"]);

                            textParentAutoSalesOrderNo.Text = ParentAutoSalesOrderNo;
                            dr["ParentAutoSalesOrderNo"] = ParentAutoSalesOrderNo;
                            textParentProjectNo.Text = ParentProjectNo;
                            dr["ParentProjectNo"] = ParentProjectNo;

                            labParentAutoSalesOrderNo.Visible = true;
                            textParentAutoSalesOrderNo.Visible = true;
                            labParentProjectNo.Visible = true;
                            textParentProjectNo.Visible = true;
                        }
                        else
                        {
                            textParentAutoSalesOrderNo.Text = "";
                            dr["ParentAutoSalesOrderNo"] = "";
                            textParentProjectNo.Text = "";
                            dr["ParentProjectNo"] = "";
                            labParentAutoSalesOrderNo.Visible = false;
                            textParentAutoSalesOrderNo.Visible = false;
                            labParentProjectNo.Visible = false;
                            textParentProjectNo.Visible = false;
                        }

                        if (oldVersionsStr == VersionsStr)
                            lookUpQuotationVersions_EditValueChanged(null, null);

                        searchProjectName.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--选择适用报价单错误。", ex);
            }
        }

        /// <summary>
        /// 改变当前销售订单的报价单号事件
        /// </summary>
        private void btnEditAutoQuotationNo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (bindingSource_SalesOrder.Current != null)
                {
                    DataRow dr = ((DataRowView)bindingSource_SalesOrder.Current).Row;
                    string autoQuotationNoStr = btnEditAutoQuotationNo.Text.Trim();
                    lookUpQuotationVersions.Properties.DataSource = quoDAO.Query_QuotationPriceInfo_Versions(autoQuotationNoStr);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--改变当前销售订单的报价单号事件错误。", ex);
            }
        }

        /// <summary>
        /// 选择报价单版本事件
        /// </summary>
        private void lookUpQuotationVersions_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (bindingSource_SalesOrder.Current != null && lookUpQuotationVersions.ItemIndex > -1)
                {
                    DataRow dr = gridViewSalesOrder.GetFocusedDataRow();
                    //bindingSource_SalesOrder.EndEdit();
                    //if (dr.RowState == DataRowState.Added || dr.RowState == DataRowState.Modified)
                    if (!btnNew.Enabled)
                    {
                        string autoQuotationNoStr = btnEditAutoQuotationNo.Text.Trim();
                        string versionStr = lookUpQuotationVersions.Text.Trim();
                        DataTable priceTable = quoDAO.Query_Version_PriceInfo(autoQuotationNoStr, versionStr);
                        if (priceTable.Rows.Count > 0)
                        {
                            gridViewSalesOrder.SetFocusedRowCellValue("Amount", DataTypeConvert.GetDecimal(priceTable.Rows[0]["Amount"]));
                            gridViewSalesOrder.SetFocusedRowCellValue("Tax", DataTypeConvert.GetDecimal(priceTable.Rows[0]["Tax"]));
                            spinAmount.Value = DataTypeConvert.GetDecimal(priceTable.Rows[0]["Amount"]);
                            spinTax.Value = DataTypeConvert.GetDecimal(priceTable.Rows[0]["Tax"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--选择报价单版本事件错误。", ex);
            }
        }

        /// <summary>
        /// 计算税额和价税合计
        /// </summary>
        private void spinAmount_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (!btnNew.Enabled)
                {
                    double amountDouble = DataTypeConvert.GetDouble(spinAmount.EditValue);
                    double taxDouble = DataTypeConvert.GetDouble(spinTax.EditValue);
                    double taxAmountDouble = Math.Round(amountDouble * taxDouble, 2, MidpointRounding.AwayFromZero);
                    double sumAmountDouble = amountDouble + taxAmountDouble;
                    gridViewSalesOrder.SetFocusedRowCellValue("TaxAmount", taxAmountDouble);
                    gridViewSalesOrder.SetFocusedRowCellValue("SumAmount", sumAmountDouble);
                    spinTaxAmount.EditValue = taxAmountDouble;
                    spinSumAmount.EditValue = sumAmountDouble;
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--计算税额和价税合计错误。", ex);
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
        private void gridViewSalesOrder_KeyDown(object sender, KeyEventArgs e)
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
        /// 双击查询明细
        /// </summary>
        private void gridViewQuotationBaseInfo_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (e.Clicks == 2)
                {
                    string autoQuotationNoStr = DataTypeConvert.GetString(gridViewQuotationBaseInfo.GetFocusedDataRow()["AutoQuotationNo"]);
                    FrmQuotationInfo.queryAutoQuotationNoStr = autoQuotationNoStr;
                    //FrmWarehouseWarrant_Drag.queryListAutoId = 0;
                    ViewHandler.ShowRightWindow("FrmQuotationInfo");
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--双击查询明细错误。", ex);
            }
        }

        /// <summary>
        /// 新增按钮事件
        /// </summary>
        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow newRow = TableSalesOrder.NewRow();
                TableSalesOrder.Rows.Add(newRow);
                bindingSource_SalesOrder.MoveLast();

                ColumnView headView = (ColumnView)gridControlSalesOrder.FocusedView;
                gridViewSalesOrder.FocusedRowHandle = headView.FocusedRowHandle;

                Set_ButtonEditGrid_State(false);

                btnEditAutoQuotationNo.Focus();
                TableQuotationBaseInfo.Rows.Clear();
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--新增按钮事件错误。", ex);
            }
        }

        /// <summary>
        /// 保存按钮事件
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (TableSalesOrder.Rows.Count == 0 || bindingSource_SalesOrder.Current == null)
                    return;

                if (btnSave.Text != "保存")
                {
                    DataRow headRow = ((DataRowView)bindingSource_SalesOrder.Current).Row;
                    string autoSalesOrderNoStr = DataTypeConvert.GetString(headRow["AutoSalesOrderNo"]);
                    if (soDAO.CheckSalesOrder_IsSettleAccounts(null, autoSalesOrderNoStr))
                        return;

                    Set_ButtonEditGrid_State(false);
                    btnEditAutoQuotationNo.Focus();
                }
                else
                {
                    bindingSource_SalesOrder.EndEdit();
                    DataRow headRow = ((DataRowView)bindingSource_SalesOrder.Current).Row;

                    if (btnEditAutoQuotationNo.Text.Trim() == "")
                    {
                        MessageHandler.ShowMessageBox("报价单号不能为空，请重新操作。");
                        btnEditAutoQuotationNo.Focus();
                        return;
                    }
                    if (lookUpQuotationVersions.Text.Trim() == "")
                    {
                        MessageHandler.ShowMessageBox("报价单版本不能为空，请重新操作。");
                        lookUpQuotationVersions.Focus();
                        return;
                    }
                    if (searchProjectName.Text.Trim() == "")
                    {
                        MessageHandler.ShowMessageBox("项目名称不能为空，请重新操作。");
                        searchProjectName.Focus();
                        return;
                    }
                    if (searchBussinessBaseNo.Text.Trim() == "")
                    {
                        MessageHandler.ShowMessageBox("客户不能为空，请重新操作。");
                        searchBussinessBaseNo.Focus();
                        return;
                    }
                    if (lookUpCollectionTypeNo.Text.Trim() == "")
                    {
                        MessageHandler.ShowMessageBox("收款方式不能为空，请重新操作。");
                        lookUpCollectionTypeNo.Focus();
                        return;
                    }
                    if (lookUpCurrencyCate.Text.Trim() == "")
                    {
                        MessageHandler.ShowMessageBox("币种不能为空，请重新操作。");
                        lookUpCurrencyCate.Focus();
                        return;
                    }

                    if (DataTypeConvert.GetString(headRow["ProjectName"]) != searchProjectName.Text)
                        headRow["ProjectName"] = searchProjectName.Text;

                    int ret = soDAO.SaveSalesOrder(headRow);
                    switch (ret)
                    {
                        case -1:

                            break;
                        case 1:

                            break;
                        case 0:
                            return;
                    }

                    //currentAutoSalesOrderNoStr = DataTypeConvert.GetString(headRow["AutoSalesOrderNo"]);
                    Set_ButtonEditGrid_State(true);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--保存按钮事件错误。", ex);
            }
        }

        /// <summary>
        /// 取消按钮事件
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (bindingSource_SalesOrder.Current != null)
                {
                    bindingSource_SalesOrder.CancelEdit();
                    ((DataRowView)bindingSource_SalesOrder.Current).Row.RejectChanges();
                    if (gridViewSalesOrder.GetFocusedDataRow() != null)
                        gridViewSalesOrder.GetFocusedDataRow().RejectChanges();
                    Set_ButtonEditGrid_State(true);
                }

                //if (gridViewSalesOrder.GetDataRow(headFocusedLineNo).RowState != DataRowState.Unchanged)
                //{
                //    if (DataTypeConvert.GetString(gridViewSalesOrder.GetDataRow(headFocusedLineNo)["AutoSalesOrderNo"]) == "")
                //    {
                //        gridViewSalesOrder.DeleteRow(headFocusedLineNo);
                //    }
                //    else
                //    {
                //        gridViewSalesOrder.GetFocusedDataRow().RejectChanges();
                //    }
                //}
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--取消按钮事件错误。", ex);
            }
        }

        /// <summary>
        /// 删除按钮事件
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (TableSalesOrder.Rows.Count == 0 || bindingSource_SalesOrder.Current == null)
                {
                    MessageHandler.ShowMessageBox("当前没有销售订单记录，不能进行删除。");
                    return;
                }

                DataRow headRow = ((DataRowView)bindingSource_SalesOrder.Current).Row;
                string autoSalesOrderNoStr = DataTypeConvert.GetString(headRow["AutoSalesOrderNo"]);
                if (soDAO.CheckSalesOrder_IsSettleAccounts(null, autoSalesOrderNoStr))
                    return;

                if (MessageHandler.ShowMessageBox_YesNo("确定要删除当前选中的记录吗？") != DialogResult.Yes)
                {
                    return;
                }
                //int autoIdInt = DataTypeConvert.GetInt(headRow["AutoId"]);
                if (soDAO.DeleteSalesOrder(DataTypeConvert.GetString(headRow["AutoSalesOrderNo"])))
                {
                    //TableSalesOrder.Rows.Clear();
                    //currentAutoSalesOrderNoStr = "";
                    //soDAO.QuerySalesOrder_UpOne(TableSalesOrder, autoIdInt);
                    //if (TableSalesOrder.Rows.Count > 0)
                    //{
                    //    currentAutoSalesOrderNoStr = DataTypeConvert.GetString(TableSalesOrder.Rows[0]["AutoSalesOrderNo"]);
                    //    RefreshQuotationBaseInfo();
                    //}
                    //else
                    //{
                    //    soDAO.QuerySalesOrder_DownOne(TableSalesOrder, autoIdInt);
                    //    if (TableSalesOrder.Rows.Count > 0)
                    //    {
                    //        currentAutoSalesOrderNoStr = DataTypeConvert.GetString(TableSalesOrder.Rows[0]["AutoSalesOrderNo"]);
                    //        RefreshQuotationBaseInfo();
                    //    }
                    //}
                }
                //else
                //{
                //    currentAutoSalesOrderNoStr = DataTypeConvert.GetString(headRow["AutoSalesOrderNo"]);
                //    btnRefresh_Click(null, null);
                //}
                btnQuery_Click(null, null);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--删除按钮事件错误。", ex);
            }
        }

        ///// <summary>
        ///// 刷新按钮事件
        ///// </summary>
        //private void btnRefresh_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        TableSalesOrder.Rows.Clear();
        //        if (currentAutoSalesOrderNoStr != "")
        //        {
        //            soDAO.QuerySalesOrder(TableSalesOrder, currentAutoSalesOrderNoStr);
        //            RefreshQuotationBaseInfo();
        //        }
        //        else
        //        {
        //            soDAO.QuerySalesOrder_LastOne(TableSalesOrder);
        //            if (TableSalesOrder.Rows.Count > 0)
        //            {
        //                currentAutoSalesOrderNoStr = DataTypeConvert.GetString(TableSalesOrder.Rows[0]["AutoSalesOrderNo"]);
        //                RefreshQuotationBaseInfo();
        //            }
        //        }

        //        Set_ButtonEditGrid_State(true);
        //    }
        //    catch (Exception ex)
        //    {
        //        ExceptionHandler.HandleException(this.Text + "--刷新按钮事件错误。", ex);
        //    }
        //}

        /// <summary>
        /// 预览按钮事件
        /// </summary>
        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                string autoSalesOrderNoStr = "";
                if (bindingSource_SalesOrder.Current != null)
                    autoSalesOrderNoStr = DataTypeConvert.GetString(((DataRowView)bindingSource_SalesOrder.Current).Row["AutoSalesOrderNo"]);
                soDAO.PrintHandle(autoSalesOrderNoStr, 1);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--预览按钮事件错误。", ex);
            }
        }

        /// <summary>
        /// COR生成新的报价单
        /// </summary>
        private void BtnCOR_Click(object sender, EventArgs e)
        {
            try
            {
                if (TableSalesOrder.Rows.Count == 0 || bindingSource_SalesOrder.Current == null)
                {
                    MessageHandler.ShowMessageBox("请选择要生成COR的销售订单。");
                    return;
                }
                DataRow headRow = ((DataRowView)bindingSource_SalesOrder.Current).Row;
                string parentAutoSalesOrderNoStr = DataTypeConvert.GetString(headRow["ParentAutoSalesOrderNo"]);
                if (parentAutoSalesOrderNoStr != "")
                {
                    MessageHandler.ShowMessageBox("当前销售订单就是COR订单，不能再生成COR报价单。");
                    return;
                }

                FrmQuotationInfo.newParentAutoQuotationNoStr = DataTypeConvert.GetString(headRow["AutoQuotationNo"]);
                FrmQuotationInfo.newParentAutoSalesOrderNoStr = DataTypeConvert.GetString(headRow["AutoSalesOrderNo"]);
                FrmQuotationInfo.newParentProjectNoStr = DataTypeConvert.GetString(headRow["ProjectNo"]);
                ViewHandler.ShowRightWindow("FrmQuotationInfo");
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--COR生成新的报价单错误。", ex);
            }
        }

        /// <summary>
        /// 设定主表的默认值
        /// </summary>
        private void TableSalesOrder_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            try
            {
                e.Row["SalesOrderDate"] = BaseSQL.GetServerDateTime();
                e.Row["Amount"] = 0;
                e.Row["Tax"] = SystemInfo.SalesOrder_DefaultTax;
                e.Row["IsEnd"] = 0;
                e.Row["Prepared"] = SystemInfo.user.EmpName;
                e.Row["SalesOrderState"] = 1;

                DataTable tmpTable = ((DataTable)lookUpCurrencyCate.Properties.DataSource);
                if (tmpTable.Rows.Count > 0)
                    e.Row["CurrencyCate"] = tmpTable.Rows[0]["AutoId"];
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--设定主表的默认值错误。", ex);
            }
        }

        /// <summary>
        /// 设定按钮编辑区列表区的状态
        /// </summary>
        private void Set_ButtonEditGrid_State(bool state)
        {
            btnNew.Enabled = state;
            if (state)
            {
                btnSave.Text = "修改";
            }
            else
            {
                btnSave.Text = "保存";
            }
            btnCancel.Enabled = !state;
            btnDelete.Enabled = state;
            btnPreview.Enabled = state;

            btnEditAutoQuotationNo.Properties.Buttons[0].Enabled = !state;
            lookUpQuotationVersions.ReadOnly = state;
            searchProjectName.ReadOnly = state;
            textCustomerPoNo.ReadOnly = state;
            lookUpCollectionTypeNo.ReadOnly = state;
            lookUpCurrencyCate.ReadOnly = state;
            spinAmount.ReadOnly = state;
            spinTax.ReadOnly = state;
            textProjectLeader.ReadOnly = state;
            textRemark.ReadOnly = state;

            if (bindingSource_SalesOrder.Current != null)
            {
                DataRow headRow = ((DataRowView)bindingSource_SalesOrder.Current).Row;
                string ParentAutoSalesOrderNo = DataTypeConvert.GetString(headRow["ParentAutoSalesOrderNo"]);
                bool isVisible = ParentAutoSalesOrderNo != "";
                labParentAutoSalesOrderNo.Visible = isVisible;
                textParentAutoSalesOrderNo.Visible = isVisible;
                labParentProjectNo.Visible = isVisible;
                textParentProjectNo.Visible = isVisible;

                BtnCOR.Enabled = ParentAutoSalesOrderNo == "" && state;
            }
            else
            {
                labParentAutoSalesOrderNo.Visible = false;
                textParentAutoSalesOrderNo.Visible = false;
                labParentProjectNo.Visible = false;
                textParentProjectNo.Visible = false;

                BtnCOR.Enabled = false;
            }

            if (this.Controls.ContainsKey("lblEditFlag"))
            {
                //检测窗口状态：新增、编辑="EDIT"，保存、取消=""
                if (state)
                {
                    ((Label)this.Controls["lblEditFlag"]).Text = "";
                }
                else
                {
                    ((Label)this.Controls["lblEditFlag"]).Text = "EDIT";
                }
            }
        }

        #endregion

        #region 左侧历史销售订单的相关事件和方法

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
                string commonStr = textCommon.Text.Trim();

                dataSet_SalesOrder.Tables[0].Rows.Clear();

                soDAO.QuerySalesOrder(dataSet_SalesOrder.Tables[0], recordDateBeginStr, recordDateEndStr, bussinessBaseNoStr, "", "", commonStr);

                Set_ButtonEditGrid_State(true);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--查询按钮事件错误。", ex);
            }
        }

        /// <summary>
        /// 换行触发事件
        /// </summary>
        private void gridViewSalesOrder_BeforeLeaveRow(object sender, RowAllowEventArgs e)
        {
            try
            {
                if (gridViewSalesOrder.GetFocusedDataRow() != null)
                {
                    DataRow dr = gridViewSalesOrder.GetFocusedDataRow();
                    if (dr.RowState != DataRowState.Unchanged)
                    {
                        MessageHandler.ShowMessageBox("当前销售订单正在编辑，请保存后再进行换行。");
                        e.Allow = false;
                    }
                    else
                    {
                        Set_ButtonEditGrid_State(true);
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--换行触发事件错误。", ex);
            }
        }

        /// <summary>
        /// 刷新销售订单的报价信息
        /// </summary>
        private void gridViewSalesOrder_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            try
            {
                if (gridViewSalesOrder.GetFocusedDataRow() != null)
                {
                    string autoQuotationNoStr = DataTypeConvert.GetString(gridViewSalesOrder.GetFocusedDataRow()["AutoQuotationNo"]);
                    if (autoQuotationNoStr != "")
                        RefreshQuotationBaseInfo(autoQuotationNoStr);

                    Set_ButtonEditGrid_State(true);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--刷新销售订单的报价信息错误。", ex);
            }
        }

        /// <summary>
        /// 刷新报价单信息
        /// </summary>
        private void RefreshQuotationBaseInfo(string autoQuotationNoStr)
        {
            dataSet_Quotation.Tables[0].Rows.Clear();
            quoDAO.QueryQuotationBaseInfo(dataSet_Quotation.Tables[0], "", "", "", "", autoQuotationNoStr);
        }

        #endregion

    }
}
