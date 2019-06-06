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
    public partial class FrmDeliveryDetail : DockContent
    {
        #region 私有变量

        FrmCommonDAO commonDAO = new FrmCommonDAO();
        FrmDeliveryDetailDAO ddDAO = new FrmDeliveryDetailDAO();

        /// <summary>
        /// 要查询的功能模块号
        /// </summary>
        public static string querySMNo = "";

        /// <summary>
        /// 要查询的供货明细ID
        /// </summary>
        public static int queryAutoIdInt = 0;

        /// <summary>
        /// 当前的供货明细ID
        /// </summary>
        private int currentAutoIdInt = 0;

        #endregion

        #region 构造方法

        public FrmDeliveryDetail()
        {
            InitializeComponent();
        }

        #endregion

        #region 窗体事件

        /// <summary>
        /// 窗体加载事件  
        /// </summary>
        private void FrmDeliveryDetail_Load(object sender, EventArgs e)
        {
            try
            {
                ControlHandler.DevExpressStyle_ChangeControlLocation(btnListAdd.LookAndFeel.ActiveSkinName, new List<Control> { btnListAdd });

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
        private void FrmDeliveryDetail_Activated(object sender, EventArgs e)
        {
            try
            {
                if (queryAutoIdInt > 0)
                {
                    currentAutoIdInt = queryAutoIdInt;
                    queryAutoIdInt = 0;
                    btnRefresh_Click(null, null);
                    btnSave_Click(null, null);
                }
                else if (queryAutoIdInt == -1)
                {
                    queryAutoIdInt = 0;
                    btnNew_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--窗体激活事件错误。", ex);
            }
        }

        /// <summary>
        /// 按Esc退出窗体
        /// </summary>
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {
            if (msg.Msg == 256 | msg.Msg == 260)
            {
                switch (keyData)
                {
                    case Keys.Escape:
                        this.Close();
                        break;
                }
            }
            return false;
        }

        #endregion

        #region 供货明细登记事件和方法

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewMaterialDetail_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
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
                TableDeliveryDetail.Rows.Clear();
                DataRow deliveryRow = TableDeliveryDetail.NewRow();
                TableDeliveryDetail.Rows.Add(deliveryRow);
                bindingSource_DeliveryDetail.MoveLast();

                TableMaterialDetail.Clear();
                //gridViewMaterialDetail.AddNewRow();
                DataRow materialRow = TableMaterialDetail.NewRow();
                TableMaterialDetail.Rows.Add(materialRow);
                FocusedListView(false, "MaterialName", gridViewMaterialDetail.GetFocusedDataSourceRowIndex());
                gridViewMaterialDetail.RefreshData();
                Set_ButtonEditGrid_State(false);
                spinDeliveryQty.Focus();
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
                if (TableDeliveryDetail.Rows.Count == 0 || bindingSource_DeliveryDetail.Current == null)
                    return;

                if (btnSave.Text != "保存")
                {
                    Set_ButtonEditGrid_State(false);
                    spinDeliveryQty.Focus();
                }
                else
                {
                    bindingSource_DeliveryDetail.EndEdit();
                    DataRow headRow = ((DataRowView)bindingSource_DeliveryDetail.Current).Row;

                    if (spinDeliveryQty.Text.Trim() == "" || spinDeliveryQty.Value <= 0)
                    {
                        MessageHandler.ShowMessageBox("供货数量不能为空或者小于等于0，请重新操作。");
                        spinDeliveryQty.Focus();
                        return;
                    }
                    if (spinUnit.Text.Trim() == "" || spinUnit.Value < 0)
                    {
                        MessageHandler.ShowMessageBox("单价不能为空或者小于0，请重新操作。");
                        spinUnit.Focus();
                        return;
                    }
                    if (spinAmount.Text.Trim() == "" || spinAmount.Value < 0)
                    {
                        MessageHandler.ShowMessageBox("金额不能为空或者小于0，请重新操作。");
                        spinUnit.Focus();
                        return;
                    }

                    for (int i = gridViewMaterialDetail.DataRowCount - 1; i >= 0; i--)
                    {
                        DataRow listRow = gridViewMaterialDetail.GetDataRow(i);
                        if (DataTypeConvert.GetString(listRow["MaterialName"]) == "")
                        {
                            gridViewMaterialDetail.DeleteRow(i);
                            continue;
                        }
                        if (DataTypeConvert.GetString(gridViewMaterialDetail.GetDataRow(i)["MaterialBrand"]) == "")
                        {
                            MessageHandler.ShowMessageBox("品牌不能为空，请填写后再进行保存。");
                            FocusedListView(true, "MaterialBrand", i);
                            return;
                        }
                        if (DataTypeConvert.GetString(gridViewMaterialDetail.GetDataRow(i)["MaterialQty"]) == "" || DataTypeConvert.GetDecimal(gridViewMaterialDetail.GetDataRow(i)["MaterialQty"]) <= 0)
                        {
                            MessageHandler.ShowMessageBox("数量不能为空或者小于等于0，请填写后再进行保存。");
                            FocusedListView(true, "MaterialQty", i);
                            return;
                        }
                        if (DataTypeConvert.GetString(gridViewMaterialDetail.GetDataRow(i)["Unit"]) == "" || DataTypeConvert.GetDecimal(gridViewMaterialDetail.GetDataRow(i)["Unit"]) < 0)
                        {
                            MessageHandler.ShowMessageBox("单价不能为空或者小于0，请填写后再进行保存。");
                            FocusedListView(true, "Unit", i);
                            return;
                        }
                        if (DataTypeConvert.GetString(gridViewMaterialDetail.GetDataRow(i)["Amount"]) == "" || DataTypeConvert.GetDecimal(gridViewMaterialDetail.GetDataRow(i)["Amount"]) < 0)
                        {
                            MessageHandler.ShowMessageBox("金额不能为空或者小于0，请填写后再进行保存。");
                            FocusedListView(true, "Amount", i);
                            return;
                        }
                    }

                    int ret = ddDAO.SaveDeliveryDetail(headRow, TableMaterialDetail);
                    switch (ret)
                    {
                        case -1:

                            break;
                        case 1:

                            break;
                        case 0:
                            return;
                    }

                    currentAutoIdInt = DataTypeConvert.GetInt(headRow["AutoId"]);
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
                if (bindingSource_DeliveryDetail.Current != null)
                {
                    bindingSource_DeliveryDetail.CancelEdit();
                    ((DataRowView)bindingSource_DeliveryDetail.Current).Row.RejectChanges();

                    btnRefresh_Click(null, null);
                }
                else
                    btnRefresh_Click(null, null);
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
                if (TableDeliveryDetail.Rows.Count == 0 || bindingSource_DeliveryDetail.Current == null)
                {
                    MessageHandler.ShowMessageBox("当前没有供货明细记录，不能进行删除。");
                    return;
                }
                DataRow headRow = ((DataRowView)bindingSource_DeliveryDetail.Current).Row;

                if (MessageHandler.ShowMessageBox_YesNo("确定要删除当前选中的记录吗？") != DialogResult.Yes)
                {
                    return;
                }
                if (ddDAO.DeleteDeliveryDetail(currentAutoIdInt))
                {
                    MessageHandler.ShowMessageBox("删除成功。");
                    TableDeliveryDetail.Rows.Clear();
                    TableMaterialDetail.Rows.Clear();
                    ddDAO.QueryDeliveryDetail_UpOne(TableDeliveryDetail, currentAutoIdInt, querySMNo);
                    if (TableDeliveryDetail.Rows.Count > 0)
                    {
                        currentAutoIdInt = DataTypeConvert.GetInt(TableDeliveryDetail.Rows[0]["AutoId"]);
                        ddDAO.QueryMaterialDetail(TableMaterialDetail, currentAutoIdInt);
                    }
                    else
                    {
                        ddDAO.QueryDeliveryDetail_DownOne(TableDeliveryDetail, currentAutoIdInt, querySMNo);
                        if (TableDeliveryDetail.Rows.Count > 0)
                        {
                            currentAutoIdInt = DataTypeConvert.GetInt(TableDeliveryDetail.Rows[0]["AutoId"]);
                            ddDAO.QueryMaterialDetail(TableMaterialDetail, currentAutoIdInt);
                        }
                    }
                }
                else
                {
                    currentAutoIdInt = DataTypeConvert.GetInt(headRow["AutoId"]);
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
                TableDeliveryDetail.Rows.Clear();
                TableMaterialDetail.Rows.Clear();
                if (currentAutoIdInt != 0)
                {
                    ddDAO.QueryDeliveryDetail(TableDeliveryDetail, currentAutoIdInt);
                    if (TableDeliveryDetail.Rows.Count > 0)
                    {
                        ddDAO.QueryMaterialDetail(TableMaterialDetail, currentAutoIdInt);
                    }
                }
                else
                {
                    ddDAO.QueryDeliveryDetail_LastOne(TableDeliveryDetail, querySMNo);
                    if (TableDeliveryDetail.Rows.Count > 0)
                    {
                        currentAutoIdInt = DataTypeConvert.GetInt(TableDeliveryDetail.Rows[0]["AutoId"]);
                        ddDAO.QueryMaterialDetail(TableMaterialDetail, currentAutoIdInt);
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
        /// 查询上一条信息事件
        /// </summary>
        private void btnUp_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tmpTable = new DataTable();
                ddDAO.QueryDeliveryDetail_UpOne(tmpTable, currentAutoIdInt, querySMNo);
                if (tmpTable.Rows.Count > 0)
                {
                    TableDeliveryDetail.Rows.Clear();
                    TableDeliveryDetail.ImportRow(tmpTable.Rows[0]);
                    currentAutoIdInt = DataTypeConvert.GetInt(tmpTable.Rows[0]["AutoId"]);
                    TableMaterialDetail.Rows.Clear();
                    ddDAO.QueryMaterialDetail(TableMaterialDetail, currentAutoIdInt);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--查询上一条信息事件错误。", ex);
            }
        }

        /// <summary>
        /// 查询下一条信息事件
        /// </summary>
        private void btnDown_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tmpTable = new DataTable();
                ddDAO.QueryDeliveryDetail_DownOne(tmpTable, currentAutoIdInt, querySMNo);
                if (tmpTable.Rows.Count > 0)
                {
                    TableDeliveryDetail.Rows.Clear();
                    TableDeliveryDetail.ImportRow(tmpTable.Rows[0]);
                    currentAutoIdInt = DataTypeConvert.GetInt(tmpTable.Rows[0]["AutoId"]);
                    TableMaterialDetail.Rows.Clear();
                    ddDAO.QueryMaterialDetail(TableMaterialDetail, currentAutoIdInt);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--查询下一条信息事件错误。", ex);
            }
        }

        /// <summary>
        /// 子表新增一行事件
        /// </summary>
        private void btnListAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!gridViewMaterialDetail.OptionsBehavior.Editable)
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
                if (gridViewMaterialDetail.GetFocusedDataRow().RowState != DataRowState.Added)
                {
                    if (MessageHandler.ShowMessageBox_YesNo("确定要删除当前选中的明细记录吗？") != DialogResult.Yes)
                    {
                        return;
                    }
                }
                gridViewMaterialDetail.DeleteRow(gridViewMaterialDetail.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--删除子表中的一行错误。", ex);
            }
        }

        /// <summary>
        /// 设定主表的默认值
        /// </summary>
        private void TableDeliveryDetail_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            try
            {
                e.Row["SMNo"] = querySMNo;
                e.Row["Prepared"] = SystemInfo.user.EmpName;
                e.Row["DeliveryQty"] = 1;
                e.Row["Unit"] = 1;
                e.Row["Amount"] = 1;
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--设定主表的默认值错误。", ex);
            }
        }

        /// <summary>
        /// 设定子表的默认值
        /// </summary>
        private void TableMaterialDetail_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            try
            {
                e.Row["DeliveryDetailNO"] = currentAutoIdInt;
                e.Row["Prepared"] = SystemInfo.user.EmpName;
                e.Row["MaterialQty"] = 1;
                e.Row["Unit"] = 1;
                e.Row["Amount"] = 1;
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--设定子表的默认值错误。", ex);
            }
        }

        /// <summary>
        /// 子表按键事件
        /// </summary>
        private void gridViewMaterialDetail_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (!gridViewMaterialDetail.OptionsBehavior.Editable)
                        return;

                    if (gridViewMaterialDetail.GetFocusedDataSourceRowIndex() >= gridViewMaterialDetail.DataRowCount - 1 && gridViewMaterialDetail.FocusedColumn.Name == "colUnit")
                    {
                        gridViewMaterialDetail.PostEditor();
                        ListNewRow();
                    }
                    else if (gridViewMaterialDetail.FocusedColumn.Name == "colUnit")
                    {
                        gridViewMaterialDetail.FocusedRowHandle = gridViewMaterialDetail.FocusedRowHandle + 1;
                        FocusedListView(true, "MaterialName", gridViewMaterialDetail.GetFocusedDataSourceRowIndex());
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
        /// 子表单元格值变化进行的操作
        /// </summary>
        private void gridViewMaterialDetail_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                switch (e.Column.FieldName)
                {
                    case "MaterialQty":
                    case "Unit":
                        double materialQtyDouble = DataTypeConvert.GetDouble(gridViewMaterialDetail.GetDataRow(e.RowHandle)["MaterialQty"]);
                        double unitDouble = DataTypeConvert.GetDouble(gridViewMaterialDetail.GetDataRow(e.RowHandle)["Unit"]);
                        double amountDouble = Math.Round(materialQtyDouble * unitDouble, 2, MidpointRounding.AwayFromZero);
                        gridViewMaterialDetail.SetRowCellValue(e.RowHandle, "Amount", amountDouble);
                        break;
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--子表单元格值变化进行的操作错误。", ex);
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
            btnUp.Enabled = state;
            btnDown.Enabled = state;

            btnListAdd.Enabled = !state;

            spinDeliveryQty.ReadOnly = state;
            spinUnit.ReadOnly = state;
            spinAmount.ReadOnly = state;
            textDeliveryText.ReadOnly = state;
            textFunctionDesc.ReadOnly = state;

            gridViewMaterialDetail.OptionsBehavior.Editable = !state;

            repbtnDelete.Buttons[0].Enabled = !state;

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
                gridControlMaterialDetail.Focus();
            ColumnView listView = (ColumnView)gridControlMaterialDetail.FocusedView;
            listView.FocusedColumn = listView.Columns[colName];
            gridViewMaterialDetail.FocusedRowHandle = lineNo;
        }

        /// <summary>
        /// 检查是否有未填写字段
        /// </summary>
        private bool IsHaveBlankLine()
        {
            gridViewMaterialDetail.FocusedRowHandle = 0;
            for (int i = 0; i < gridViewMaterialDetail.DataRowCount; i++)
            {
                if (DataTypeConvert.GetString(gridViewMaterialDetail.GetDataRow(i)["MaterialName"]) == "")
                {
                    gridViewMaterialDetail.Focus();
                    gridViewMaterialDetail.FocusedColumn = colMaterialName;
                    gridViewMaterialDetail.FocusedRowHandle = i;
                    return true;
                }
                if (DataTypeConvert.GetString(gridViewMaterialDetail.GetDataRow(i)["MaterialBrand"]) == "")
                {
                    gridViewMaterialDetail.Focus();
                    gridViewMaterialDetail.FocusedColumn = colMaterialBrand;
                    gridViewMaterialDetail.FocusedRowHandle = i;
                    return true;
                }
                if (DataTypeConvert.GetString(gridViewMaterialDetail.GetDataRow(i)["MaterialQty"]) == "" || DataTypeConvert.GetDecimal(gridViewMaterialDetail.GetDataRow(i)["MaterialQty"]) == 0)
                {
                    gridViewMaterialDetail.Focus();
                    gridViewMaterialDetail.FocusedColumn = colMaterialQty;
                    gridViewMaterialDetail.FocusedRowHandle = i;
                    return true;
                }
                if (DataTypeConvert.GetString(gridViewMaterialDetail.GetDataRow(i)["Unit"]) == "")
                {
                    gridViewMaterialDetail.Focus();
                    gridViewMaterialDetail.FocusedColumn = colUnit;
                    gridViewMaterialDetail.FocusedRowHandle = i;
                    return true;
                }
                if (DataTypeConvert.GetString(gridViewMaterialDetail.GetDataRow(i)["Amount"]) == "")
                {
                    gridViewMaterialDetail.Focus();
                    gridViewMaterialDetail.FocusedColumn = colAmount;
                    gridViewMaterialDetail.FocusedRowHandle = i;
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
            gridViewMaterialDetail.AddNewRow();
            FocusedListView(true, "MaterialName", gridViewMaterialDetail.GetFocusedDataSourceRowIndex());
            //gridViewOrderList.RefreshData();
        }

        /// <summary>
        /// 默认计算金额
        /// </summary>
        private void spinDeliveryQty_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                spinAmount.Value = spinDeliveryQty.Value * spinUnit.Value;
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--默认计算金额错误。", ex);
            }
        }

        /// <summary>
        /// 默认计算金额
        /// </summary>
        private void spinUnit_EditValueChanged(object sender, EventArgs e)
        {
            spinDeliveryQty_EditValueChanged(null, null);
        }

        #endregion
    }
}
