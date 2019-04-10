using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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
    public partial class FrmSettleAccounts_Drag : DockContent
    {
        #region 私有变量

        FrmCommonDAO commonDAO = new FrmCommonDAO();
        FrmSettleAccountsDAO saDAO = new FrmSettleAccountsDAO();
        FrmSalesOrderDAO soDAO = new FrmSalesOrderDAO();

        /// <summary>
        /// 主表聚焦的行号
        /// </summary>
        int headFocusedLineNo = 0;

        /// <summary>
        /// 查询的结账单号
        /// </summary>
        public static string querySettleAccountNo = "";

        /// <summary>
        /// 查询的明细AutoId
        /// </summary>
        public static int queryListAutoId = 0;

        /// <summary>
        /// 只有选择列改变行状态的时候
        /// </summary>
        bool onlySelectColChangeRowState = false;

        /// <summary>
        /// 拖动区域的信息
        /// </summary>
        GridHitInfo GriddownHitInfo = null;

        #endregion

        #region 构造方法

        public FrmSettleAccounts_Drag()
        {
            InitializeComponent();
        }

        #endregion

        #region 窗体事件

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmSettleAccounts_Load(object sender, EventArgs e)
        {
            try
            {
                ControlHandler.DevExpressStyle_ChangeControlLocation(checkAll.LookAndFeel.ActiveSkinName, new List<Control> { checkAll });

                DateTime nowDate = BaseSQL.GetServerDateTime();
                dateSADateBegin.DateTime = nowDate.Date.AddDays(-SystemInfo.OrderQueryDate_DefaultDays);
                dateSADateEnd.DateTime = nowDate.Date;

                DataTable bussBaseTable = commonDAO.QueryBussinessBaseInfo(false);
                DataTable bussBaseAddAllTable = commonDAO.QueryBussinessBaseInfo(true);

                searchLookUpBussinessBaseNo.Properties.DataSource = bussBaseAddAllTable;
                searchLookUpBussinessBaseNo.Text = "全部";
                lookUpReqDep.Properties.DataSource = commonDAO.QueryDepartment(true);
                lookUpReqDep.ItemIndex = 0;
                lookUpPrepared.Properties.DataSource = commonDAO.QueryUserInfo(true);
                lookUpPrepared.EditValue = SystemInfo.user.EmpName;

                repSearchBussinessBaseNo.DataSource = bussBaseTable;
                repLookUpReqDep.DataSource = commonDAO.QueryDepartment(false);

                repLookUpCurrencyCate.DataSource = commonDAO.QueryCurrencyCate(false);

                dateSODateBegin.DateTime = dateSADateBegin.DateTime;
                dateSODateEnd.DateTime = dateSADateEnd.DateTime;
                searchBussinessBaseNo.Properties.DataSource = bussBaseAddAllTable;
                searchBussinessBaseNo.Text = "全部";

                repSearchLookUpBussinessBaseNo.DataSource = bussBaseTable;

                if (textCommon.Text == "")
                {
                    saDAO.QuerySettleAccountsHead(dataSet_SettleAccounts.Tables[0], "", "", "", "", "", "", true);
                    saDAO.QuerySettlementList(dataSet_SettleAccounts.Tables[1], "", true);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
            }
        }

        /// <summary>
        /// 窗体激活事件
        /// </summary>
        private void FrmSettleAccounts_Activated(object sender, EventArgs e)
        {
            try
            {
                if (querySettleAccountNo != "")
                {
                    textCommon.Text = querySettleAccountNo;
                    querySettleAccountNo = "";
                    lookUpReqDep.ItemIndex = 0;
                    searchLookUpBussinessBaseNo.Text = "全部";
                    lookUpPrepared.ItemIndex = 0;

                    dataSet_SettleAccounts.Tables[0].Clear();
                    headFocusedLineNo = 0;
                    saDAO.QuerySettleAccountsHead(dataSet_SettleAccounts.Tables[0], "", "", "", "", "", textCommon.Text, false);
                    SetButtonAndColumnState(false);

                    if (dataSet_SettleAccounts.Tables[0].Rows.Count > 0)
                    {
                        dateSADateBegin.DateTime = DataTypeConvert.GetDateTime(dataSet_SettleAccounts.Tables[0].Rows[0]["SettleAccountDate"]).Date;
                        dateSADateEnd.DateTime = dateSADateBegin.DateTime.AddDays(7);
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
        private void FrmSettleAccounts_Shown(object sender, EventArgs e)
        {
            pnlMiddle.Height = (this.Height - pnltop.Height) / 2;

            dockPnlLeft.Width = SystemInfo.DragForm_LeftDock_Width;
        }

        #endregion

        #region 右侧销售结账模块的相关事件和方法

        /// <summary>
        /// 查询按钮事件
        /// </summary>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                if (dateSADateBegin.EditValue == null || dateSADateEnd.EditValue == null)
                {
                    MessageHandler.ShowMessageBox("结账日期不能为空，请设置后重新进行查询。");
                    if (dateSADateBegin.EditValue == null)
                        dateSADateBegin.Focus();
                    else
                        dateSADateEnd.Focus();
                    return;
                }
                string saDateBeginStr = dateSADateBegin.DateTime.ToString("yyyy-MM-dd");
                string saDateEndStr = dateSADateEnd.DateTime.AddDays(1).ToString("yyyy-MM-dd");

                string bussinessBaseNoStr = DataTypeConvert.GetString(searchLookUpBussinessBaseNo.EditValue) != "全部" ? DataTypeConvert.GetString(searchLookUpBussinessBaseNo.EditValue) : "";
                string reqDepStr = lookUpReqDep.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpReqDep.EditValue) : "";
                string empNameStr = lookUpPrepared.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpPrepared.EditValue) : "";
                string commonStr = textCommon.Text.Trim();
                dataSet_SettleAccounts.Tables[0].Clear();
                dataSet_SettleAccounts.Tables[1].Clear();
                headFocusedLineNo = 0;
                saDAO.QuerySettleAccountsHead(dataSet_SettleAccounts.Tables[0], saDateBeginStr, saDateEndStr, reqDepStr, bussinessBaseNoStr, empNameStr, commonStr, false);

                SetButtonAndColumnState(false);
                checkAll.Checked = false;
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--查询按钮事件错误。", ex);
            }
        }

        /// <summary>
        /// 主表聚焦行改变事件
        /// </summary>
        private void gridViewSettleAccountsHead_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (gridViewSettleAccountsHead.GetFocusedDataRow() != null)
                {
                    if (onlySelectColChangeRowState)
                    {
                        dataSet_SettleAccounts.Tables[0].AcceptChanges();
                        onlySelectColChangeRowState = false;
                    }
                    else
                    {
                        if (headFocusedLineNo < gridViewSettleAccountsHead.DataRowCount && gridViewSettleAccountsHead.FocusedRowHandle != headFocusedLineNo && gridViewSettleAccountsHead.GetDataRow(headFocusedLineNo).RowState != DataRowState.Unchanged)
                        {
                            MessageHandler.ShowMessageBox("当前销售结账单已经修改，请保存后再进行换行。");
                            gridViewSettleAccountsHead.FocusedRowHandle = headFocusedLineNo;
                        }
                        else if (headFocusedLineNo == gridViewSettleAccountsHead.DataRowCount)
                        {

                        }
                        else
                        {
                            if (gridViewSettleAccountsHead.FocusedRowHandle != headFocusedLineNo && gridViewSettleAccountsHead.GetDataRow(headFocusedLineNo).RowState != DataRowState.Unchanged)
                                btnCancel_Click(null, null);
                            else if (gridViewSettleAccountsHead.GetDataRow(headFocusedLineNo).RowState == DataRowState.Unchanged)
                                btnCancel_Click(null, null);
                        }
                    }

                    if (DataTypeConvert.GetString(gridViewSettleAccountsHead.GetFocusedDataRow()["SettleAccountNo"]) != "")
                    {
                        dataSet_SettleAccounts.Tables[1].Clear();
                        saDAO.QuerySettlementList(dataSet_SettleAccounts.Tables[1], DataTypeConvert.GetString(gridViewSettleAccountsHead.GetFocusedDataRow()["SettleAccountNo"]), false);
                        //if (queryListAutoId > 0)
                        //{
                        //    for (int i = 0; i < gridViewSettlementList.DataRowCount; i++)
                        //    {
                        //        if (DataTypeConvert.GetInt(gridViewSettlementList.GetDataRow(i)["AutoId"]) == queryListAutoId)
                        //        {
                        //            gridViewSettlementList.FocusedRowHandle = i;
                        //            queryListAutoId = 0;
                        //            break;
                        //        }
                        //    }
                        //}
                    }

                    if (gridViewSettleAccountsHead.FocusedRowHandle >= 0)
                    {
                        headFocusedLineNo = gridViewSettleAccountsHead.FocusedRowHandle;
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--主表聚焦行改变事件错误。", ex);
            }
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewSettleAccountsHead_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            ControlHandler.GridView_CustomDrawRowIndicator(e);
        }

        /// <summary>
        /// 获取单元格显示的信息
        /// </summary>
        private void gridViewSettleAccountsList_KeyDown(object sender, KeyEventArgs e)
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
        /// 保存按钮事件
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridViewSettleAccountsHead.GetFocusedDataRow() == null)
                    return;

                if (btnSave.Text.ToString() != "保存")
                {
                    ClearHeadGridAllSelect();

                    SetButtonAndColumnState(true);
                    FocusedHeadView("ReqDep");
                }
                else
                {
                    DataRow headRow = gridViewSettleAccountsHead.GetFocusedDataRow();
                    if (DataTypeConvert.GetString(headRow["BussinessBaseNo"]) == "")
                    {
                        MessageHandler.ShowMessageBox("往来方不能为空，请填写后再进行保存。");
                        FocusedHeadView("BussinessBaseNo");
                        return;
                    }
                    if (DataTypeConvert.GetString(headRow["ReqDep"]) == "")
                    {
                        MessageHandler.ShowMessageBox("部门不能为空，请填写后再进行保存。");
                        FocusedHeadView("ReqDep");
                        return;
                    }

                    for (int i = gridViewSettleAccountsList.DataRowCount - 1; i >= 0; i--)
                    {
                        DataRow listRow = gridViewSettleAccountsList.GetDataRow(i);
                        if (DataTypeConvert.GetString(listRow["Amount"]) == "" || DataTypeConvert.GetDouble(listRow["Amount"]) == 0)
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
                        if(DataTypeConvert.GetString(listRow["CurrencyCate"]) == "")
                        {
                            MessageHandler.ShowMessageBox("币种不能为空，请填写后再进行保存。");
                            FocusedListView(true, "CurrencyCate", i);
                            return;
                        }
                    }

                    int ret = saDAO.SaveSettleAccounts(gridViewSettleAccountsHead.GetFocusedDataRow(), dataSet_SettleAccounts.Tables[1]);
                    switch (ret)
                    {
                        case -1:
                            btnQuery_Click(null, null);
                            break;
                        case 1:
                            dataSet_SettleAccounts.Tables[1].Clear();
                            saDAO.QuerySettlementList(dataSet_SettleAccounts.Tables[1], DataTypeConvert.GetString(gridViewSettleAccountsHead.GetFocusedDataRow()["SettleAccountNo"]), false);
                            break;
                        case 0:
                            return;
                    }

                    SetButtonAndColumnState(false);
                    btnPrReqQuery_Click(null, null);
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
                if (gridViewSettleAccountsHead.GetDataRow(headFocusedLineNo).RowState != DataRowState.Unchanged)
                {
                    if (DataTypeConvert.GetString(gridViewSettleAccountsHead.GetDataRow(headFocusedLineNo)["SettleAccountNo"]) == "")
                    {
                        gridViewSettleAccountsHead.DeleteRow(headFocusedLineNo);
                    }
                    else
                    {
                        gridViewSettleAccountsHead.GetFocusedDataRow().RejectChanges();
                    }
                }

                SetButtonAndColumnState(false);

                dataSet_SettleAccounts.Tables[1].Clear();
                if (gridViewSettleAccountsHead.GetFocusedDataRow() != null)
                    saDAO.QuerySettlementList(dataSet_SettleAccounts.Tables[1], DataTypeConvert.GetString(gridViewSettleAccountsHead.GetFocusedDataRow()["SettleAccountNo"]), false);

                if (sender != null)
                    btnPrReqQuery_Click(sender, null);
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
                int count = dataSet_SettleAccounts.Tables[0].Select("select=1").Length;
                if (count == 0)
                {
                    MessageHandler.ShowMessageBox("请在要操作的记录前面选中。");
                    return;
                }

                //if (!CheckWarehouseState_Multi(false, true, true, true))
                //    return;

                if (MessageHandler.ShowMessageBox_YesNo(string.Format("确定要删除当前选中的{0}条记录吗？", count)) != DialogResult.Yes)
                {
                    return;
                }
                if (!saDAO.DeleteSettleAccounts_Multi(dataSet_SettleAccounts.Tables[0]))
                {

                }

                btnQuery_Click(null, null);
                ClearHeadGridAllSelect();
                btnPrReqQuery_Click(null, null);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--删除按钮事件错误。", ex);
            }
        }

        /// <summary>
        /// 打印预览按钮事件
        /// </summary>
        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                string settleAccountNoStr = "";
                if (gridViewSettleAccountsHead.GetFocusedDataRow() != null)
                    settleAccountNoStr = DataTypeConvert.GetString(gridViewSettleAccountsHead.GetFocusedDataRow()["SettleAccountNo"]);
                saDAO.PrintHandle(settleAccountNoStr, 1);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--打印预览按钮事件错误。", ex);
            }
        }

        /// <summary>
        /// 全部选中
        /// </summary>
        private void checkAll_CheckedChanged(object sender, EventArgs e)
        {
            bool value = false;
            if (checkAll.Checked)
            {
                value = true;
            }
            foreach (DataRow dr in dataSet_SettleAccounts.Tables[0].Rows)
            {
                dr["Select"] = value;
            }
            onlySelectColChangeRowState = true;
        }

        /// <summary>
        /// 主表设定默认值
        /// </summary>
        private void gridViewSettleAccountsHead_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            try
            {
                DateTime nowDate = BaseSQL.GetServerDateTime();
                gridViewSettleAccountsHead.SetFocusedRowCellValue("SettleAccountsState", 1);
                gridViewSettleAccountsHead.SetFocusedRowCellValue("SettleAccountDate", nowDate);
                gridViewSettleAccountsHead.SetFocusedRowCellValue("ReqDep", SystemInfo.user.DepartmentNo);

                gridViewSettleAccountsHead.SetFocusedRowCellValue("Prepared", SystemInfo.user.EmpName);
                gridViewSettleAccountsHead.SetFocusedRowCellValue("IsVoucher", 0);

            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--主表设定默认值错误。", ex);
            }
        }

        /// <summary>
        /// 删除子表中的一行
        /// </summary>
        private void repbtnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                //int wwListAutoId = 0;
                //if (gridViewSettleAccountsList.GetFocusedDataRow() != null)
                //    wwListAutoId = DataTypeConvert.GetInt(gridViewSettleAccountsList.GetFocusedDataRow()["WarehouseWarrantListAutoId"]);
                gridViewSettleAccountsList.DeleteRow(gridViewSettleAccountsList.FocusedRowHandle);
                //if (wwListAutoId > 0)
                //    gridViewWWHead_FocusedRowChanged(sender, null);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--删除子表中的一行错误。", ex);
            }
        }

        /// <summary>
        /// 子表单元格值变化进行的操作
        /// </summary>
        private void gridViewSettleAccountsList_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                switch (e.Column.FieldName)
                {
                    case "Amount":
                    case "Tax":
                        double amountDouble = DataTypeConvert.GetDouble(gridViewSettleAccountsList.GetDataRow(e.RowHandle)["Amount"]);
                        double taxDouble = DataTypeConvert.GetDouble(gridViewSettleAccountsList.GetDataRow(e.RowHandle)["Tax"]);
                        double taxAmountDouble = Math.Round(amountDouble * taxDouble, 2, MidpointRounding.AwayFromZero);
                        double sumAmountDouble = amountDouble + taxAmountDouble;
                        gridViewSettleAccountsList.SetRowCellValue(e.RowHandle, "TaxAmount", taxAmountDouble);
                        gridViewSettleAccountsList.SetRowCellValue(e.RowHandle, "SumAmount", sumAmountDouble);
                        break;
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--子表单元格值变化进行的操作错误。", ex);
            }
        }

        /// <summary>
        /// 设定当前行选择
        /// </summary>
        private void repCheckSelect_EditValueChanged(object sender, EventArgs e)
        {
            if (DataTypeConvert.GetBoolean(gridViewSettleAccountsHead.GetFocusedDataRow()["Select"]))
                gridViewSettleAccountsHead.GetFocusedDataRow()["Select"] = false;
            else
                gridViewSettleAccountsHead.GetFocusedDataRow()["Select"] = true;
            onlySelectColChangeRowState = true;
        }

        /// <summary>
        /// 双击查询销售订单信息
        /// </summary>
        private void gridViewSettleAccountsList_RowClick(object sender, RowClickEventArgs e)
        {
            try
            {
                if (e.Clicks == 2)
                {
                    if (btnDelete.Enabled)
                    {
                        string autoSalesOrderNoStr = DataTypeConvert.GetString(gridViewSettleAccountsList.GetFocusedDataRow()["AutoSalesOrderNo"]);
                        FrmSalesOrder_History.queryAutoSalesOrderNoStr = autoSalesOrderNoStr;
                        //FrmWarehouseWarrant_Drag.queryListAutoId = 0;
                        ViewHandler.ShowRightWindow("FrmSalesOrder_History");
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--双击查询明细错误。", ex);
            }
        }

        /// <summary>
        /// 设定按钮和表列状态
        /// </summary>
        /// <param name="ret">状态标准</param>
        private void SetButtonAndColumnState(bool ret)
        {
            if (ret)
            {
                //btnNew.Enabled = false;
                btnSave.Text = "保存";
                btnCancel.Enabled = true;
                btnDelete.Enabled = false;
            }
            else
            {
                //btnNew.Enabled = true;
                btnSave.Text = "修改";
                btnCancel.Enabled = false;
                btnDelete.Enabled = true;
            }
            btnPreview.Enabled = !ret;

            //colBussinessBaseNo.OptionsColumn.AllowEdit = ret;
            colReqDep.OptionsColumn.AllowEdit = ret;
            colRemark.OptionsColumn.AllowEdit = ret;

            //colCurrencyCate.OptionsColumn.AllowEdit = ret;
            colAmount.OptionsColumn.AllowEdit = ret;
            colTax1.OptionsColumn.AllowEdit = ret;
            colListRemark.OptionsColumn.AllowEdit = ret;

            repbtnDelete.Buttons[0].Enabled = ret;
            repCheckSelect.ReadOnly = ret;
            checkAll.ReadOnly = ret;

            if (this.Controls.ContainsKey("lblEditFlag"))
            {
                //检测窗口状态：新增、编辑="EDIT"，保存、取消=""
                if (ret)
                {
                    ((Label)this.Controls["lblEditFlag"]).Text = "EDIT";
                }
                else
                {
                    ((Label)this.Controls["lblEditFlag"]).Text = "";
                }
            }
        }

        /// <summary>
        /// 聚焦主表当前行的列
        /// </summary>
        private void FocusedHeadView(string colName)
        {
            gridCtlSettleAccountsHead.Focus();
            ColumnView headView = (ColumnView)gridCtlSettleAccountsHead.FocusedView;
            headView.FocusedColumn = headView.Columns[colName];
            gridViewSettleAccountsHead.FocusedRowHandle = headView.FocusedRowHandle;
        }

        /// <summary>
        /// 聚焦子表当前行的列
        /// </summary>
        private void FocusedListView(bool isFocusedControl, string colName, int lineNo)
        {
            if (isFocusedControl)
                gridCtlSettleAccountsList.Focus();
            ColumnView listView = (ColumnView)gridCtlSettleAccountsList.FocusedView;
            listView.FocusedColumn = listView.Columns[colName];
            gridViewSettleAccountsList.FocusedRowHandle = lineNo;
        }

        /// <summary>
        /// 清楚当前的所有选择
        /// </summary>
        private void ClearHeadGridAllSelect()
        {
            checkAll.Checked = false;
            for (int i = 0; i < dataSet_SettleAccounts.Tables[0].Rows.Count; i++)
            {
                dataSet_SettleAccounts.Tables[0].Rows[i]["Select"] = false;
            }
            dataSet_SettleAccounts.Tables[0].AcceptChanges();
            onlySelectColChangeRowState = false;
        }

        #endregion

        #region 左侧销售订单模块的相关事件和方法

        /// <summary>
        /// 查询销售订单事件
        /// </summary>
        private void btnPrReqQuery_Click(object sender, EventArgs e)
        {
            try
            {
                if (dateSODateBegin.EditValue == null || dateSODateEnd.EditValue == null)
                {
                    MessageHandler.ShowMessageBox("登记日期不能为空，请设置后重新进行查询。");
                    if (dateSODateBegin.EditValue == null)
                        dateSODateBegin.Focus();
                    else
                        dateSODateEnd.Focus();
                    return;
                }

                string soDateBeginStr = dateSODateBegin.DateTime.ToString("yyyy-MM-dd");
                string soDateEndStr = dateSODateEnd.DateTime.AddDays(1).ToString("yyyy-MM-dd");
                string bussinessBaseNoStr = searchBussinessBaseNo.Text != "全部" ? DataTypeConvert.GetString(searchBussinessBaseNo.EditValue) : "";
                string commonStr = textEditCommon.Text.Trim();

                dataSet_SalesOrder.Tables[0].Clear();

                soDAO.QuerySalesOrder_NoIsEnd(dataSet_SalesOrder.Tables[0], soDateBeginStr, soDateEndStr, bussinessBaseNoStr, commonStr);

                ClearAlreadyDragOrderList();
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--查询销售订单事件错误。", ex);
            }
        }

        #region 拖出

        /// <summary>
        /// 在GridView中按下鼠标事件
        /// </summary>
        private void gridViewSalesOrder_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                GriddownHitInfo = null;
                GridHitInfo hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));

                if (Control.ModifierKeys != Keys.None)
                    return;
                if (e.Button == MouseButtons.Left && hitInfo.RowHandle >= 0)
                {
                    GriddownHitInfo = hitInfo;
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--在GridView中按下鼠标事件错误。", ex);
            }
        }

        /// <summary>
        /// 在GridView中移动鼠标事件
        /// </summary>
        private void gridViewSalesOrder_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                if (e.Button == MouseButtons.Left && GriddownHitInfo != null)
                {
                    Size dragSize = SystemInformation.DragSize;
                    Rectangle dragRect = new Rectangle(new Point(GriddownHitInfo.HitPoint.X - dragSize.Width / 2,
                        GriddownHitInfo.HitPoint.Y - dragSize.Height / 2), dragSize);

                    if (!dragRect.Contains(new Point(e.X, e.Y)))
                    {
                        int[] rowint = view.GetSelectedRows();
                        List<DataRow> row = new List<DataRow>();
                        foreach (int i in rowint)
                        {
                            row.Add(view.GetDataRow(i));
                        }
                        if (row != null && row.Count > 0)
                        {
                            view.GridControl.DoDragDrop(row, DragDropEffects.Move);
                            GriddownHitInfo = null;
                            DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--在GridView中按下鼠标事件错误。", ex);
            }
        }

        #endregion

        #region 拖入

        /// <summary>
        /// 拖拽在GridControl上面
        /// </summary>
        private void gridCtlSettleAccountsList_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<DataRow>)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        /// <summary>
        /// 拖拽进入到GridControl控件
        /// </summary>
        private void gridCtlSettleAccountsList_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        /// <summary>
        /// 实现拖拽销售订单事件
        /// </summary>
        private void gridCtlSettleAccountsList_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                List<DataRow> drs = e.Data.GetData(typeof(List<DataRow>)) as List<DataRow>;
                if (drs != null)
                {
                    SalesOrderToSettleAccounts_DragOrder(sender, drs);
                    ClearAlreadyDragOrderList();
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--实现拖拽销售订单事件错误。", ex);
            }
        }

        /// <summary>
        /// 拖拽销售订单转成销售结账单
        /// </summary>
        private void SalesOrderToSettleAccounts_DragOrder(object sender, List<DataRow> drs)
        {
            if (drs.Count < 1)
                return;
            string bussinessBaseNoStr = DataTypeConvert.GetString(drs[0]["BussinessBaseNo"]);
            for (int i = 1; i < drs.Count; i++)
            {
                if (DataTypeConvert.GetString(drs[i]["BussinessBaseNo"]) != bussinessBaseNoStr)
                {
                    MessageHandler.ShowMessageBox("拖拽选择的销售订单必须是相同的往来方，请重新操作。");
                    return;
                }
            }

            //DataTable tmpTable = ((DataTable)repLookUpCurrencyCate.DataSource);
            //int CurrencyCateInt = 0;
            //if (tmpTable.Rows.Count > 0)
            //    CurrencyCateInt = DataTypeConvert.GetInt(tmpTable.Rows[0]["AutoId"]);

            if (btnDelete.Enabled)
            {
                ClearHeadGridAllSelect();
                gridViewSettleAccountsHead.AddNewRow();
                FocusedHeadView("ReqDep");

                DateTime nowDate = BaseSQL.GetServerDateTime();

                gridViewSettleAccountsHead.SetFocusedRowCellValue("BussinessBaseNo", bussinessBaseNoStr);

                dataSet_SettleAccounts.Tables[1].Clear();
                foreach (DataRow dr in drs)
                {
                    gridViewSettleAccountsList.AddNewRow();
                    gridViewSettleAccountsList.SetFocusedRowCellValue("SettleAccountNo", gridViewSettleAccountsHead.GetFocusedDataRow()["SettleAccountNo"]);
                    gridViewSettleAccountsList.SetFocusedRowCellValue("AutoSalesOrderNo", dr["AutoSalesOrderNo"]);

                    double amountDouble = DataTypeConvert.GetDouble(dr["NoSettleAmount"]);
                    double taxDouble = DataTypeConvert.GetDouble(dr["Tax"]);
                    double taxAmountDouble = Math.Round(amountDouble * taxDouble, 2, MidpointRounding.AwayFromZero);
                    double sumAmountDouble = amountDouble + taxAmountDouble;
                    gridViewSettleAccountsList.SetFocusedRowCellValue("Tax", taxDouble);
                    gridViewSettleAccountsList.SetFocusedRowCellValue("Amount", amountDouble);
                    gridViewSettleAccountsList.SetFocusedRowCellValue("TaxAmount", taxAmountDouble);
                    gridViewSettleAccountsList.SetFocusedRowCellValue("SumAmount", sumAmountDouble);
                    gridViewSettleAccountsList.SetFocusedRowCellValue("CurrencyCate", dr["CurrencyCate"]);
                }
                FocusedListView(false, "Amount", gridViewSettleAccountsList.GetFocusedDataSourceRowIndex());
                gridViewSettleAccountsList.RefreshData();

                SetButtonAndColumnState(true);
                headFocusedLineNo = gridViewSettleAccountsHead.DataRowCount;
            }
            else
            {
                if (DataTypeConvert.GetString(gridViewSettleAccountsHead.GetFocusedDataRow()["BussinessBaseNo"]) != bussinessBaseNoStr)
                {
                    MessageHandler.ShowMessageBox("一张销售结账单只允许相同的往来方进行登记。");
                    return;
                }

                foreach (DataRow dr in drs)
                {
                    if (dataSet_SettleAccounts.Tables[1].Select(string.Format("AutoSalesOrderNo='{0}'", DataTypeConvert.GetString(dr["AutoSalesOrderNo"]))).Length > 0)
                        continue;
                    gridViewSettleAccountsList.AddNewRow();
                    gridViewSettleAccountsList.SetFocusedRowCellValue("SettleAccountNo", gridViewSettleAccountsHead.GetFocusedDataRow()["SettleAccountNo"]);
                    gridViewSettleAccountsList.SetFocusedRowCellValue("AutoSalesOrderNo", dr["AutoSalesOrderNo"]);

                    double amountDouble = DataTypeConvert.GetDouble(dr["NoSettleAmount"]);
                    double taxDouble = DataTypeConvert.GetDouble(dr["Tax"]);
                    double taxAmountDouble = Math.Round(amountDouble * taxDouble, 2, MidpointRounding.AwayFromZero);
                    double sumAmountDouble = amountDouble + taxAmountDouble;
                    gridViewSettleAccountsList.SetFocusedRowCellValue("Tax", taxDouble);
                    gridViewSettleAccountsList.SetFocusedRowCellValue("Amount", amountDouble);
                    gridViewSettleAccountsList.SetFocusedRowCellValue("TaxAmount", taxAmountDouble);
                    gridViewSettleAccountsList.SetFocusedRowCellValue("SumAmount", sumAmountDouble);
                    gridViewSettleAccountsList.SetFocusedRowCellValue("CurrencyCate", dr["CurrencyCate"]);
                }

                gridViewSettleAccountsList.FocusedRowHandle = gridViewSettleAccountsList.DataRowCount;
                FocusedListView(false, "Amount", gridViewSettleAccountsList.GetFocusedDataSourceRowIndex());
                gridViewSettleAccountsList.RefreshData();
            }
        }

        #endregion

        /// <summary>
        /// 清空已经拖拽的销售订单
        /// </summary>
        private void ClearAlreadyDragOrderList()
        {
            return;

            //for (int i = dataSet_SalesOrder.Tables[0].Rows.Count - 1; i >= 0; i--)
            //{
            //    if (dataSet_SettleAccounts.Tables[1].Select(string.Format("AutoSalesOrderNo='{0}'", DataTypeConvert.GetString(dataSet_SalesOrder.Tables[0].Rows[i]["AutoSalesOrderNo"]))).Length > 0)
            //        dataSet_SalesOrder.Tables[0].Rows.RemoveAt(i);
            //}
        }


        #endregion
        
    }
}
