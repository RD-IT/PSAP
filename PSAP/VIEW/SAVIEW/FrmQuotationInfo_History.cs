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
    public partial class FrmQuotationInfo_History : DockContent
    {
        #region 私有变量

        FrmCommonDAO commonDAO = new FrmCommonDAO();
        FrmQuotationInfoDAO quoDAO = new FrmQuotationInfoDAO();

        /// <summary>
        /// 要查询的报价单号
        /// </summary>
        public static string queryAutoQuotationNoStr = "";

        /// <summary>
        /// 新增COR报价单的父级报价单号
        /// </summary>
        public static string newParentAutoQuotationNoStr = "";
        /// <summary>
        /// 新增COR报价单的父级销售订单号
        /// </summary>
        public static string newParentAutoSalesOrderNoStr = "";
        /// <summary>
        /// 新增COR报价单的父级项目号
        /// </summary>
        public static string newParentProjectNoStr = "";

        #endregion

        #region 构造方法

        public FrmQuotationInfo_History()
        {
            InitializeComponent();
        }

        #endregion

        #region 窗体事件

        /// <summary>
        /// 窗体加载事件  
        /// </summary>
        private void FrmQuotationInfo_History_Load(object sender, EventArgs e)
        {
            try
            {                
                ControlHandler.DevExpressStyle_ChangeControlLocation(btnListAdd.LookAndFeel.ActiveSkinName, new List<Control> { btnListAdd });

                DataTable bussBaseTable = commonDAO.QueryBussinessBaseInfo(false);

                searchBussinessBaseNo.Properties.DataSource = bussBaseTable;

                repLookUpCurrencyCate.DataSource = commonDAO.QueryCurrencyCate(false);

                DateTime nowDate = BaseSQL.GetServerDateTime();
                dateRecordDateBegin.DateTime = nowDate.Date.AddDays(-SystemInfo.OrderQueryDate_DefaultDays);
                dateRecordDateEnd.DateTime = nowDate.Date;

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
        private void FrmQuotationInfo_History_Activated(object sender, EventArgs e)
        {
            try
            {
                if (queryAutoQuotationNoStr != "")
                {
                    textCommon.Text = queryAutoQuotationNoStr;
                    queryAutoQuotationNoStr = "";

                    searchLookUpBussinessBaseNo.Text = "全部";

                    dataSet_Quotation.Tables[0].Clear();
                    quoDAO.QueryQuotationBaseInfo(dataSet_Quotation.Tables[0], "", "", "", "", textCommon.Text);
                    Set_ButtonEditGrid_State(true);

                    if (dataSet_Quotation.Tables[0].Rows.Count > 0)
                    {
                        dateRecordDateBegin.DateTime = DataTypeConvert.GetDateTime(dataSet_Quotation.Tables[0].Rows[0]["RecordDate"]).Date;
                        dateRecordDateEnd.DateTime = dateRecordDateBegin.DateTime.AddDays(7);
                    }
                }
                else if (newParentAutoQuotationNoStr != "")
                {
                    btnNew_Click(null, null);
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
        private void FrmQuotationInfo_History_Shown(object sender, EventArgs e)
        {
            dockPnlLeft.Width = SystemInfo.DragForm_LeftDock_Width;
        }

        #endregion

        #region 右侧报价单模块的相关事件和方法

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewQuotationPriceInfo_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            ControlHandler.GridView_CustomDrawRowIndicator(e);
        }

        /// <summary>
        /// 新增按钮事件
        /// </summary>
        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow baseRow = TableQuotationBaseInfo.NewRow();
                TableQuotationBaseInfo.Rows.Add(baseRow);
                bindingSource_BaseInfo.MoveLast();

                ColumnView headView = (ColumnView)gridControlQuotation.FocusedView;
                gridViewQuotation.FocusedRowHandle = headView.FocusedRowHandle;

                TableQuotationPriceInfo.Clear();
                //gridViewQuotationPriceInfo.AddNewRow();
                DataRow priceRow = TableQuotationPriceInfo.NewRow();
                TableQuotationPriceInfo.Rows.Add(priceRow);
                FocusedListView(false, "CurrencyCate", gridViewQuotationPriceInfo.GetFocusedDataSourceRowIndex());
                gridViewQuotationPriceInfo.RefreshData();
                Set_ButtonEditGrid_State(false);
                textRFQNO.Focus();
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
                if (TableQuotationBaseInfo.Rows.Count == 0 || bindingSource_BaseInfo.Current == null)
                    return;

                if (btnSave.Text != "保存")
                {
                    DataRow headRow = ((DataRowView)bindingSource_BaseInfo.Current).Row;
                    string autoQuotationNoStr = DataTypeConvert.GetString(headRow["AutoQuotationNo"]);
                    if (quoDAO.CheckQuotationInfo_IsSalesOrder(null, autoQuotationNoStr))
                        return;

                    Set_ButtonEditGrid_State(false);
                    textRFQNO.Focus();
                }
                else
                {
                    bindingSource_BaseInfo.EndEdit();
                    DataRow headRow = ((DataRowView)bindingSource_BaseInfo.Current).Row;

                    if (textRFQNO.Text.Trim() == "")
                    {
                        MessageHandler.ShowMessageBox("手工单号不能为空，请重新操作。");
                        textRFQNO.Focus();
                        return;
                    }
                    if (textProjectName.Text.Trim() == "")
                    {
                        MessageHandler.ShowMessageBox("项目名称不能为空，请重新操作。");
                        textProjectName.Focus();
                        return;
                    }
                    if (searchBussinessBaseNo.Text.Trim() == "")
                    {
                        MessageHandler.ShowMessageBox("客户不能为空，请重新操作。");
                        searchBussinessBaseNo.Focus();
                        return;
                    }
                    if (textRequester.Text.Trim() == "")
                    {
                        MessageHandler.ShowMessageBox("客户需求人不能为空，请重新操作。");
                        textRequester.Focus();
                        return;
                    }

                    for (int i = gridViewQuotationPriceInfo.DataRowCount - 1; i >= 0; i--)
                    {
                        DataRow listRow = gridViewQuotationPriceInfo.GetDataRow(i);
                        if (DataTypeConvert.GetString(listRow["CurrencyCate"]) == "")
                        {
                            gridViewQuotationPriceInfo.DeleteRow(i);
                            continue;
                        }
                        if (DataTypeConvert.GetString(listRow["Amount"]) == "" || DataTypeConvert.GetDecimal(listRow["Amount"]) == 0)
                        {
                            MessageHandler.ShowMessageBox("金额不能为空，请填写后再进行保存。");
                            FocusedListView(true, "Amount", i);
                            return;
                        }
                        if (DataTypeConvert.GetString(listRow["Tax"]) == "")
                        {
                            MessageHandler.ShowMessageBox("税率不能为空，请填写后再进行保存。");
                            FocusedListView(true, "Tax", i);
                            return;
                        }
                        if (DataTypeConvert.GetString(listRow["Versions"]) == "")
                        {
                            MessageHandler.ShowMessageBox("版本不能为空，请填写后再进行保存。");
                            FocusedListView(true, "Versions", i);
                            return;
                        }
                        if (DataTypeConvert.GetString(listRow["Offerer"]) == "")
                        {
                            MessageHandler.ShowMessageBox("报价人不能为空，请填写后再进行保存。");
                            FocusedListView(true, "Offerer", i);
                            return;
                        }
                        if (DataTypeConvert.GetString(listRow["QuotationDate"]) == "")
                        {
                            MessageHandler.ShowMessageBox("报价日期不能为空，请填写后再进行保存。");
                            FocusedListView(true, "QuotationDate", i);
                            return;
                        }

                        string versionsStr = DataTypeConvert.GetString(listRow["Versions"]);
                        if (TableQuotationPriceInfo.Select(string.Format("Versions = '{0}'", versionsStr)).Length > 1)
                        {
                            MessageHandler.ShowMessageBox("版本号有重复，请重新填写后再进行保存。");
                            FocusedListView(true, "Versions", i);
                            return;
                        }
                    }

                    int ret = quoDAO.SaveQuotationInfo(headRow, TableQuotationPriceInfo);
                    switch (ret)
                    {
                        case -1:

                            break;
                        case 1:

                            break;
                        case 0:
                            return;
                    }

                    //currentAutoQuotationNoStr = DataTypeConvert.GetString(headRow["AutoQuotationNo"]);
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
                if (bindingSource_BaseInfo.Current != null)
                {
                    bindingSource_BaseInfo.CancelEdit();
                    ((DataRowView)bindingSource_BaseInfo.Current).Row.RejectChanges();
                    if (gridViewQuotation.GetFocusedDataRow() != null)
                        gridViewQuotation.GetFocusedDataRow().RejectChanges();
                    Set_ButtonEditGrid_State(true);
                }
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
                if (TableQuotationBaseInfo.Rows.Count == 0 || bindingSource_BaseInfo.Current == null)
                {
                    MessageHandler.ShowMessageBox("当前没有报价信息记录，不能进行删除。");
                    return;
                }

                DataRow headRow = ((DataRowView)bindingSource_BaseInfo.Current).Row;
                string autoQuotationNoStr = DataTypeConvert.GetString(headRow["AutoQuotationNo"]);
                if (quoDAO.CheckQuotationInfo_IsSalesOrder(null, autoQuotationNoStr))
                    return;

                if (MessageHandler.ShowMessageBox_YesNo("确定要删除当前选中的记录吗？") != DialogResult.Yes)
                {
                    return;
                }
                if (quoDAO.DeleteQuotationInfo(autoQuotationNoStr))
                {

                }

                btnQuery_Click(null, null);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--删除按钮事件错误。", ex);
            }
        }

        /// <summary>
        /// 预览按钮事件
        /// </summary>
        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                string autoQuotationNoStr = "";
                if (bindingSource_BaseInfo.Current != null)
                    autoQuotationNoStr = DataTypeConvert.GetString(((DataRowView)bindingSource_BaseInfo.Current).Row["AutoQuotationNo"]);
                quoDAO.PrintHandle(autoQuotationNoStr, 1);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--预览按钮事件错误。", ex);
            }
        }

        /// <summary>
        /// 子表新增一行事件
        /// </summary>
        private void btnListAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!gridViewQuotationPriceInfo.OptionsBehavior.Editable)
                    return;

                ListNewRow();
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--子表新增一行事件错误。", ex);
            }
        }

        /// <summary>
        /// 删除子表中的一行
        /// </summary>
        private void repbtnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                gridViewQuotationPriceInfo.DeleteRow(gridViewQuotationPriceInfo.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--删除子表中的一行错误。", ex);
            }
        }

        /// <summary>
        /// 设定主表的默认值
        /// </summary>
        private void TableQuotationBaseInfo_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            try
            {
                e.Row["RecordDate"] = BaseSQL.GetServerDateTime();
                e.Row["Prepared"] = SystemInfo.user.EmpName;
                if (newParentAutoQuotationNoStr != "")
                {
                    e.Row["ParentAutoQuotationNo"] = newParentAutoQuotationNoStr;
                    e.Row["ParentAutoSalesOrderNo"] = newParentAutoSalesOrderNoStr; 
                    e.Row["ParentProjectNo"] = newParentProjectNoStr;
                    newParentAutoQuotationNoStr = "";
                    newParentAutoSalesOrderNoStr = "";
                    newParentProjectNoStr = "";
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--设定主表的默认值错误。", ex);
            }
        }

        /// <summary>
        /// 设定子表的默认值
        /// </summary>
        private void TableQuotationPriceInfo_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            try
            {
                if (bindingSource_BaseInfo.Current != null)
                {
                    DataRow headRow = ((DataRowView)bindingSource_BaseInfo.Current).Row;

                    e.Row["AutoQuotationNo"] = DataTypeConvert.GetString(headRow["AutoQuotationNo"]);
                    DataTable tmpTable = ((DataTable)repLookUpCurrencyCate.DataSource);
                    if (tmpTable.Rows.Count > 0)
                        e.Row["CurrencyCate"] = tmpTable.Rows[0]["AutoId"];
                    e.Row["QuotationDate"] = BaseSQL.GetServerDateTime();
                    e.Row["QuotationState"] = 1;
                    e.Row["Offerer"] = SystemInfo.user.EmpName;
                    e.Row["Tax"] = SystemInfo.Quotation_DefaultTax;

                    string currentVersion = "";
                    if (gridViewQuotationPriceInfo.RowCount > 1)
                    {
                        currentVersion = DataTypeConvert.GetString(gridViewQuotationPriceInfo.GetDataRow(gridViewQuotationPriceInfo.RowCount - 2)["Versions"]);
                    }
                    e.Row["Versions"] = CommonHandler.GetNewVersionNo(currentVersion);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--设定子表的默认值错误。", ex);
            }
        }

        /// <summary>
        /// 子表按键事件
        /// </summary>
        private void gridViewQuotationPriceInfo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (!gridViewQuotationPriceInfo.OptionsBehavior.Editable)
                        return;

                    if (gridViewQuotationPriceInfo.GetFocusedDataSourceRowIndex() >= gridViewQuotationPriceInfo.DataRowCount - 1 && gridViewQuotationPriceInfo.FocusedColumn.Name == "colRemark")
                    {
                        gridViewQuotationPriceInfo.PostEditor();
                        ListNewRow();
                    }
                    else if (gridViewQuotationPriceInfo.FocusedColumn.Name == "colRemark")
                    {
                        gridViewQuotationPriceInfo.FocusedRowHandle = gridViewQuotationPriceInfo.FocusedRowHandle + 1;
                        FocusedListView(true, "CurrencyCate", gridViewQuotationPriceInfo.GetFocusedDataSourceRowIndex());
                    }
                }
                ControlHandler.GridView_GetFocusedCellDisplayText_KeyDown(sender, e);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--子表按键事件错误。", ex);
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

            btnListAdd.Enabled = !state;

            textRFQNO.ReadOnly = state;
            textProjectName.ReadOnly = state;
            searchBussinessBaseNo.ReadOnly = state;
            textRequester.ReadOnly = state;
            textRemark.ReadOnly = state;

            gridViewQuotationPriceInfo.OptionsBehavior.Editable = !state;

            repbtnDelete.Buttons[0].Enabled = !state;

            if (bindingSource_BaseInfo.Current != null)
            {
                DataRow headRow = ((DataRowView)bindingSource_BaseInfo.Current).Row;
                string ParentAutoQuotationNo = DataTypeConvert.GetString(headRow["ParentAutoQuotationNo"]);
                bool isVisible = ParentAutoQuotationNo != "";
                labParentAutoQuotationNo.Visible = isVisible;
                textParentAutoQuotationNo.Visible = isVisible;
                labParentAutoSalesOrderNo.Visible = isVisible;
                textParentAutoSalesOrderNo.Visible = isVisible;
                labParentProjectNo.Visible = isVisible;
                textParentProjectNo.Visible = isVisible;
            }
            else
            {
                labParentAutoQuotationNo.Visible = false;
                textParentAutoQuotationNo.Visible = false;
                labParentAutoSalesOrderNo.Visible = false;
                textParentAutoSalesOrderNo.Visible = false;
                labParentProjectNo.Visible = false;
                textParentProjectNo.Visible = false;
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

        /// <summary>
        /// 聚焦子表当前行的列
        /// </summary>
        private void FocusedListView(bool isFocusedControl, string colName, int lineNo)
        {
            if (isFocusedControl)
                gridControlQuotationPriceInfo.Focus();
            ColumnView listView = (ColumnView)gridControlQuotationPriceInfo.FocusedView;
            listView.FocusedColumn = listView.Columns[colName];
            gridViewQuotationPriceInfo.FocusedRowHandle = lineNo;
        }

        /// <summary>
        /// 检查是否有未填写字段
        /// </summary>
        private bool IsHaveBlankLine()
        {
            gridViewQuotationPriceInfo.FocusedRowHandle = 0;
            for (int i = 0; i < gridViewQuotationPriceInfo.DataRowCount; i++)
            {
                if (DataTypeConvert.GetString(gridViewQuotationPriceInfo.GetDataRow(i)["CurrencyCate"]) == "")
                {
                    gridViewQuotationPriceInfo.Focus();
                    gridViewQuotationPriceInfo.FocusedColumn = colCurrencyCate;
                    gridViewQuotationPriceInfo.FocusedRowHandle = i;
                    return true;
                }
                if (DataTypeConvert.GetString(gridViewQuotationPriceInfo.GetDataRow(i)["Amount"]) == "" || DataTypeConvert.GetDecimal(gridViewQuotationPriceInfo.GetDataRow(i)["Amount"]) == 0)
                {
                    gridViewQuotationPriceInfo.Focus();
                    gridViewQuotationPriceInfo.FocusedColumn = colAmount;
                    gridViewQuotationPriceInfo.FocusedRowHandle = i;
                    return true;
                }
                if (DataTypeConvert.GetString(gridViewQuotationPriceInfo.GetDataRow(i)["Tax"]) == "")
                {
                    gridViewQuotationPriceInfo.Focus();
                    gridViewQuotationPriceInfo.FocusedColumn = colTax;
                    gridViewQuotationPriceInfo.FocusedRowHandle = i;
                    return true;
                }
                if (DataTypeConvert.GetString(gridViewQuotationPriceInfo.GetDataRow(i)["Versions"]) == "")
                {
                    gridViewQuotationPriceInfo.Focus();
                    gridViewQuotationPriceInfo.FocusedColumn = colVersions;
                    gridViewQuotationPriceInfo.FocusedRowHandle = i;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 子表新增一行
        /// </summary>
        private void ListNewRow()
        {
            if (IsHaveBlankLine())
                return;

            //gridViewPrReqList.PostEditor();
            gridViewQuotationPriceInfo.AddNewRow();
            FocusedListView(true, "CurrencyCate", gridViewQuotationPriceInfo.GetFocusedDataSourceRowIndex());
            //gridViewOrderList.RefreshData();
        }

        /// <summary>
        /// 子表单元格值变化进行的操作
        /// </summary>
        private void gridViewQuotationPriceInfo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            try
            {
                switch (e.Column.FieldName)
                {
                    case "Amount":
                    case "Tax":
                        double amountDouble = DataTypeConvert.GetDouble(gridViewQuotationPriceInfo.GetDataRow(e.RowHandle)["Amount"]);
                        double taxDouble = DataTypeConvert.GetDouble(gridViewQuotationPriceInfo.GetDataRow(e.RowHandle)["Tax"]);
                        double taxAmountDouble = Math.Round(amountDouble * taxDouble, 2, MidpointRounding.AwayFromZero);
                        double sumAmountDouble = amountDouble + taxAmountDouble;
                        gridViewQuotationPriceInfo.SetRowCellValue(e.RowHandle, "TaxAmount", taxAmountDouble);
                        gridViewQuotationPriceInfo.SetRowCellValue(e.RowHandle, "SumAmount", sumAmountDouble);
                        break;
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--子表单元格值变化进行的操作错误。", ex);
            }
        }

        #endregion

        #region 左侧历史报价单的相关事件和方法

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
                string commonStr = textCommon.Text.Trim();

                dataSet_Quotation.Tables[0].Rows.Clear();

                quoDAO.QueryQuotationBaseInfo(dataSet_Quotation.Tables[0], recordDateBeginStr, recordDateEndStr, bussinessBaseNoStr, "", commonStr);

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
        private void gridViewQuotation_BeforeLeaveRow(object sender, RowAllowEventArgs e)
        {
            try
            {
                if (gridViewQuotation.GetFocusedDataRow() != null)
                {
                    DataRow dr = gridViewQuotation.GetFocusedDataRow();
                    if (dr.RowState != DataRowState.Unchanged)
                    {
                        MessageHandler.ShowMessageBox("当前报价单正在编辑，请保存后再进行换行。");
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
        /// 刷新报价单的价格信息
        /// </summary>
        private void gridViewQuotation_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            try
            {
                if (gridViewQuotation.GetFocusedDataRow() != null)
                {
                    string autoQuotationNoStr = DataTypeConvert.GetString(gridViewQuotation.GetFocusedDataRow()["AutoQuotationNo"]);
                    if (autoQuotationNoStr != "")
                        RefreshQuotationPriceInfo(autoQuotationNoStr);

                    Set_ButtonEditGrid_State(true);
                }
                else
                {
                    dataSet_Quotation.Tables[1].Rows.Clear();
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--刷新报价单的价格信息错误。", ex);
            }
        }

        /// <summary>
        /// 刷新报价单价格信息
        /// </summary>
        private void RefreshQuotationPriceInfo(string autoQuotationNoStr)
        {
            dataSet_Quotation.Tables[1].Rows.Clear();
            quoDAO.QueryQuotationPriceInfo(dataSet_Quotation.Tables[1], autoQuotationNoStr);
        }

        #endregion
    }
}
