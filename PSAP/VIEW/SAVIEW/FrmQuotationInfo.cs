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
    public partial class FrmQuotationInfo : DockContent
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

        /// <summary>
        /// 当前的报价单号
        /// </summary>
        private string currentAutoQuotationNoStr = "";

        #endregion

        #region 构造方法

        public FrmQuotationInfo()
        {
            InitializeComponent();
        }

        #endregion

        #region 窗体事件

        /// <summary>
        /// 窗体加载事件  
        /// </summary>
        private void FrmQuotationInfo_Load(object sender, EventArgs e)
        {
            try
            {
                ControlHandler.DevExpressStyle_ChangeControlLocation(btnListAdd.LookAndFeel.ActiveSkinName, new List<Control> { btnListAdd });

                searchBussinessBaseNo.Properties.DataSource = commonDAO.QueryBussinessBaseInfo(false);

                repLookUpCurrencyCate.DataSource = commonDAO.QueryCurrencyCate(false);

                btnRefresh_Click(null, null);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
            }
        }

        /// <summary>
        /// 窗体激活事件
        /// </summary>
        private void FrmQuotationInfo_Activated(object sender, EventArgs e)
        {
            try
            {
                if (queryAutoQuotationNoStr != "")
                {
                    btnEditQueryAutoQuotationNo.Text = queryAutoQuotationNoStr;
                    queryAutoQuotationNoStr = "";
                    btnEditQueryAutoQuotationNo_ButtonClick(null, null);
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

        #endregion

        #region 报价单的相关事件和方法

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewQuotationPriceInfo_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            ControlHandler.GridView_CustomDrawRowIndicator(e);
        }

        /// <summary>
        /// 回车自动查询
        /// </summary>
        private void btnEditQueryAutoQuotationNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEditQueryAutoQuotationNo_ButtonClick(null, null);
            }
        }

        /// <summary>
        /// 按照报价单号查询报价信息
        /// </summary>
        private void btnEditQueryAutoQuotationNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (!btnEditQueryAutoQuotationNo.Properties.Buttons[0].Enabled)
                    return;

                if (btnEditQueryAutoQuotationNo.Text.Trim() != "")
                {
                    TableQuotationBaseInfo.Rows.Clear();
                    TableQuotationPriceInfo.Rows.Clear();
                    quoDAO.QueryQuotationBaseInfo(TableQuotationBaseInfo, btnEditQueryAutoQuotationNo.Text.Trim());
                    if (TableQuotationBaseInfo.Rows.Count > 0)
                    {
                        currentAutoQuotationNoStr = DataTypeConvert.GetString(TableQuotationBaseInfo.Rows[0]["AutoQuotationNo"]);
                        quoDAO.QueryQuotationPriceInfo(TableQuotationPriceInfo, currentAutoQuotationNoStr);
                    }
                    Set_ButtonEditGrid_State(true);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--按照报价单号查询报价信息错误。", ex);
            }
        }

        /// <summary>
        /// 新增按钮事件
        /// </summary>
        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                TableQuotationBaseInfo.Rows.Clear();
                DataRow baseRow = TableQuotationBaseInfo.NewRow();
                TableQuotationBaseInfo.Rows.Add(baseRow);
                bindingSource_BaseInfo.MoveLast();

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

                    currentAutoQuotationNoStr = DataTypeConvert.GetString(headRow["AutoQuotationNo"]);
                    btnRefresh_Click(null, null);
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

                    btnRefresh_Click(null, null);
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
                int autoIdInt = DataTypeConvert.GetInt(headRow["AutoId"]);
                if (quoDAO.DeleteQuotationInfo(autoQuotationNoStr))
                {
                    TableQuotationBaseInfo.Rows.Clear();
                    TableQuotationPriceInfo.Rows.Clear();
                    currentAutoQuotationNoStr = "";
                    quoDAO.QueryQuotationBaseInfo_UpOne(TableQuotationBaseInfo, autoIdInt);
                    if (TableQuotationBaseInfo.Rows.Count > 0)
                    {
                        currentAutoQuotationNoStr = DataTypeConvert.GetString(TableQuotationBaseInfo.Rows[0]["AutoQuotationNo"]);
                        quoDAO.QueryQuotationPriceInfo(TableQuotationPriceInfo, currentAutoQuotationNoStr);
                    }
                    else
                    {
                        quoDAO.QueryQuotationBaseInfo_DownOne(TableQuotationBaseInfo, autoIdInt);
                        if (TableQuotationBaseInfo.Rows.Count > 0)
                        {
                            currentAutoQuotationNoStr = DataTypeConvert.GetString(TableQuotationBaseInfo.Rows[0]["AutoQuotationNo"]);
                            quoDAO.QueryQuotationPriceInfo(TableQuotationPriceInfo, currentAutoQuotationNoStr);
                        }
                    }
                }
                else
                {
                    currentAutoQuotationNoStr = DataTypeConvert.GetString(headRow["AutoQuotationNo"]);
                    btnRefresh_Click(null, null);
                }
                Set_ButtonEditGrid_State(true);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--删除按钮事件错误。", ex);
            }
        }

        /// <summary>
        /// 刷新按钮事件
        /// </summary>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                TableQuotationBaseInfo.Rows.Clear();
                TableQuotationPriceInfo.Rows.Clear();
                if (currentAutoQuotationNoStr != "")
                {
                    quoDAO.QueryQuotationBaseInfo(TableQuotationBaseInfo, currentAutoQuotationNoStr);
                    if (TableQuotationBaseInfo.Rows.Count > 0)
                    {
                        quoDAO.QueryQuotationPriceInfo(TableQuotationPriceInfo, currentAutoQuotationNoStr);
                    }
                }
                else
                {
                    quoDAO.QueryQuotationBaseInfo_LastOne(TableQuotationBaseInfo);
                    if (TableQuotationBaseInfo.Rows.Count > 0)
                    {
                        currentAutoQuotationNoStr = DataTypeConvert.GetString(TableQuotationBaseInfo.Rows[0]["AutoQuotationNo"]);
                        quoDAO.QueryQuotationPriceInfo(TableQuotationPriceInfo, currentAutoQuotationNoStr);
                    }
                }

                Set_ButtonEditGrid_State(true);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--刷新按钮事件错误。", ex);
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
                if (gridViewQuotationPriceInfo.GetFocusedDataRow().RowState != DataRowState.Added)
                {
                    if (MessageHandler.ShowMessageBox_YesNo("确定要删除当前选中的明细记录吗？") != DialogResult.Yes)
                    {
                        return;
                    }
                }
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

                    DataTable tempTable = new DataTable();
                    quoDAO.QueryQuotationBaseInfo(tempTable, DataTypeConvert.GetString(e.Row["ParentAutoQuotationNo"]));
                    if (tempTable.Rows.Count > 0)
                    {
                        e.Row["BussinessBaseNo"] = DataTypeConvert.GetString(tempTable.Rows[0]["BussinessBaseNo"]);
                        e.Row["Requester"] = DataTypeConvert.GetString(tempTable.Rows[0]["Requester"]);
                    }
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
            btnRefresh.Enabled = state;
            btnPreview.Enabled = state;

            btnEditQueryAutoQuotationNo.Properties.Buttons[0].Enabled = state;

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

    }
}
