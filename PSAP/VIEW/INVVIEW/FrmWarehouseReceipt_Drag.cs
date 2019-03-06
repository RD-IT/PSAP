using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using PSAP.DAO.BSDAO;
using PSAP.DAO.INVDAO;
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
    public partial class FrmWarehouseReceipt_Drag : DockContent
    {
        #region 私有变量

        FrmWarehouseReceiptDAO wrDAO = new FrmWarehouseReceiptDAO();
        FrmWarehouseWarrantDAO wwDAO = new FrmWarehouseWarrantDAO();
        FrmCommonDAO commonDAO = new FrmCommonDAO();

        /// <summary>
        /// 主表聚焦的行号
        /// </summary>
        int headFocusedLineNo = 0;

        /// <summary>
        /// 查询的入库单号
        /// </summary>
        public static string queryWRHeadNo = "";

        /// <summary>
        /// 只有选择列改变行状态的时候
        /// </summary>
        bool onlySelectColChangeRowState = false;

        ///// <summary>
        ///// 拖动区域的信息
        ///// </summary>
        //GridHitInfo GriddownHitInfo = null;

        #endregion

        #region 构造方法

        public FrmWarehouseReceipt_Drag()
        {
            InitializeComponent();
        }

        #endregion

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmWarehouseReceipt_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime nowDate = BaseSQL.GetServerDateTime();
                dateWRDateBegin.DateTime = nowDate.Date.AddDays(-SystemInfo.OrderQueryDate_DefaultDays);
                dateWRDateEnd.DateTime = nowDate.Date;

                lookUpReqDep.Properties.DataSource = commonDAO.QueryDepartment(true);
                lookUpReqDep.ItemIndex = 0;
                lookUpRepertoryNo.Properties.DataSource = commonDAO.QueryRepertoryInfo(true);
                lookUpRepertoryNo.ItemIndex = 0;
                lookUpWarehouseReceiptTypeNo.Properties.DataSource = wrDAO.QueryWarehouseReceiptType(true);
                lookUpWarehouseReceiptTypeNo.ItemIndex = 0;
                comboBoxWarehouseState.SelectedIndex = 0;
                lookUpPrepared.Properties.DataSource = commonDAO.QueryUserInfo(true);
                lookUpPrepared.EditValue = SystemInfo.user.EmpName;
                lookUpApprover.Properties.DataSource = commonDAO.QueryUserInfo(true);
                lookUpApprover.ItemIndex = -1;
                lookUpManufactureNo.Properties.DataSource = wrDAO.QueryManufactureInfo(true);
                lookUpManufactureNo.ItemIndex = 0;

                repLookUpReqDep.DataSource = commonDAO.QueryDepartment(false);
                repLookUpRepertoryNo.DataSource = commonDAO.QueryRepertoryInfo(false);
                repLookUpWRTypeNo.DataSource = wrDAO.QueryWarehouseReceiptType(false);
                repLookUpApprovalType.DataSource = commonDAO.QueryApprovalType(false);
                repLookUpManufactureNo.DataSource = wrDAO.QueryManufactureInfo(false);

                repSearchCodeFileName.DataSource = commonDAO.QueryPartsCode(false);
                repSearchShelfId.DataSource = commonDAO.QueryShelfInfo(false);
                repSearchProjectNo.DataSource = commonDAO.QueryProjectList(false);

                if (textCommon.Text == "")
                {
                    wrDAO.QueryWarehouseReceiptHead(dataSet_WR.Tables[0], "", "", "", "", "", "", 0, "", -1, "", true);
                    wrDAO.QueryWarehouseReceiptList(dataSet_WR.Tables[1], "", true);
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
        private void FrmWarehouseReceipt_Activated(object sender, EventArgs e)
        {
            try
            {
                if (queryWRHeadNo != "")
                {
                    textCommon.Text = queryWRHeadNo;
                    queryWRHeadNo = "";

                    lookUpReqDep.ItemIndex = 0;
                    lookUpRepertoryNo.ItemIndex = 0;
                    lookUpWarehouseReceiptTypeNo.ItemIndex = 0;
                    comboBoxWarehouseState.SelectedIndex = 0;
                    lookUpPrepared.ItemIndex = 0;
                    lookUpApprover.ItemIndex = -1;

                    dataSet_WR.Tables[0].Clear();
                    headFocusedLineNo = 0;
                    wrDAO.QueryWarehouseReceiptHead(dataSet_WR.Tables[0], "", "", "", "", "", "", 0, "", -1, textCommon.Text, false);
                    SetButtonAndColumnState(false);

                    if (dataSet_WR.Tables[0].Rows.Count > 0)
                    {
                        dateWRDateBegin.DateTime = DataTypeConvert.GetDateTime(dataSet_WR.Tables[0].Rows[0]["WarehouseReceiptDate"]).Date;
                        dateWRDateEnd.DateTime = dateWRDateBegin.DateTime.AddDays(7);
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
        private void FrmWarehouseReceipt_Shown(object sender, EventArgs e)
        {
            pnlMiddle.Height = (this.Height - pnltop.Height) / 2;

            dockPnlLeft.Width = SystemInfo.DragForm_LeftDock_Width;
        }

        /// <summary>
        /// 删除选项
        /// </summary>
        private void lookUpApprover_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                lookUpApprover.EditValue = null;
            }
        }

        /// <summary>
        /// 查询按钮事件
        /// </summary>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                if (dateWRDateBegin.EditValue == null || dateWRDateEnd.EditValue == null)
                {
                    MessageHandler.ShowMessageBox("出库日期不能为空，请设置后重新进行查询。");
                    if (dateWRDateBegin.EditValue == null)
                        dateWRDateBegin.Focus();
                    else
                        dateWRDateEnd.Focus();
                    return;
                }
                string wrDateBeginStr = dateWRDateBegin.DateTime.ToString("yyyy-MM-dd");
                string wrDateEndStr = dateWRDateEnd.DateTime.AddDays(1).ToString("yyyy-MM-dd");

                string reqDepStr = lookUpReqDep.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpReqDep.EditValue) : "";
                string repertoryNoStr = lookUpRepertoryNo.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpRepertoryNo.EditValue) : "";
                string wrTypeNoStr = lookUpWarehouseReceiptTypeNo.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpWarehouseReceiptTypeNo.EditValue) : "";
                string manufactureNoStr = lookUpManufactureNo.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpManufactureNo.EditValue) : "";

                int warehouseStateInt = comboBoxWarehouseState.SelectedIndex > 0 ? comboBoxWarehouseState.SelectedIndex : 0;
                string empNameStr = lookUpPrepared.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpPrepared.EditValue) : "";
                int approverInt = -1;
                if (lookUpApprover.ItemIndex == 0)
                    approverInt = 0;
                else if (lookUpApprover.ItemIndex > 0)
                    approverInt = DataTypeConvert.GetInt(lookUpApprover.EditValue);
                string commonStr = textCommon.Text.Trim();

                dataSet_WR.Tables[0].Rows.Clear();
                dataSet_WR.Tables[1].Rows.Clear();
                headFocusedLineNo = 0;
                wrDAO.QueryWarehouseReceiptHead(dataSet_WR.Tables[0], wrDateBeginStr, wrDateEndStr, reqDepStr, repertoryNoStr, wrTypeNoStr, manufactureNoStr, warehouseStateInt, empNameStr, approverInt, commonStr, false);

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
        private void gridViewWRHead_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            try
            {
                if (gridViewWRHead.GetFocusedDataRow() != null)
                {
                    if (onlySelectColChangeRowState)
                    {
                        dataSet_WR.Tables[0].AcceptChanges();
                        onlySelectColChangeRowState = false;
                    }
                    else
                    {
                        if (headFocusedLineNo < gridViewWRHead.DataRowCount && gridViewWRHead.FocusedRowHandle != headFocusedLineNo && gridViewWRHead.GetDataRow(headFocusedLineNo).RowState != DataRowState.Unchanged)
                        {
                            MessageHandler.ShowMessageBox("当前出库单已经修改，请保存后再进行换行。");
                            gridViewWRHead.FocusedRowHandle = headFocusedLineNo;
                        }
                        else if (headFocusedLineNo == gridViewWRHead.DataRowCount)
                        {

                        }
                        else
                        {
                            if (gridViewWRHead.FocusedRowHandle != headFocusedLineNo && gridViewWRHead.GetDataRow(headFocusedLineNo).RowState != DataRowState.Unchanged)
                                btnCancel_Click(null, null);
                            else if (gridViewWRHead.GetDataRow(headFocusedLineNo).RowState == DataRowState.Unchanged)
                            {
                                btnCancel_Click(null, null);
                            }
                        }
                    }

                    if (DataTypeConvert.GetString(gridViewWRHead.GetFocusedDataRow()["WarehouseReceipt"]) != "")
                    {
                        dataSet_WR.Tables[1].Clear();
                        wrDAO.QueryWarehouseReceiptList(dataSet_WR.Tables[1], DataTypeConvert.GetString(gridViewWRHead.GetFocusedDataRow()["WarehouseReceipt"]), false);
                    }

                    if (gridViewWRHead.FocusedRowHandle >= 0)
                    {
                        headFocusedLineNo = gridViewWRHead.FocusedRowHandle;
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--主表聚焦行改变事件错误。", ex);
            }
        }

        /// <summary>
        /// 子表聚焦行改变事件
        /// </summary>
        private void gridViewWRList_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            try
            {
                if (gridViewWRList.GetFocusedDataRow() != null)
                {
                    string projectNoStr = DataTypeConvert.GetString(gridViewWRList.GetFocusedDataRow()["ProjectNo"]);
                    BingStnListComboBox(projectNoStr);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--子表聚焦行改变事件错误。", ex);
            }
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewWRHead_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void repSearchCodeFileNameView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        /// <summary>
        /// 设定列表显示信息
        /// </summary>
        private void gridViewWRHead_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "WarehouseState")
            {
                e.DisplayText = CommonHandler.Get_WarehouseState_Desc(e.Value.ToString());
            }
        }

        /// <summary>
        /// 新增按钮事件
        /// </summary>
        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                ClearHeadGridAllSelect();

                gridViewWRHead.AddNewRow();
                FocusedHeadView("RepertoryNo");

                dataSet_WR.Tables[1].Clear();
                gridViewWRList.AddNewRow();
                FocusedListView(false, "CodeFileName", gridViewWRList.GetFocusedDataSourceRowIndex());
                gridViewWRList.RefreshData();

                SetButtonAndColumnState(true);
                headFocusedLineNo = gridViewWRHead.DataRowCount;
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
                if (gridViewWRHead.GetFocusedDataRow() == null)
                    return;

                if (!CheckWarehouseState())
                    return;

                if (btnSave.Text != "保存")
                {
                    ClearHeadGridAllSelect();

                    SetButtonAndColumnState(true);
                    FocusedHeadView("RepertoryNo");
                }
                else
                {
                    DataRow headRow = gridViewWRHead.GetFocusedDataRow();
                    if (DataTypeConvert.GetString(headRow["ReqDep"]) == "")
                    {
                        MessageHandler.ShowMessageBox("出库部门不能为空，请填写后再进行保存。");
                        FocusedHeadView("ReqDep");
                        return;
                    }
                    if (DataTypeConvert.GetString(headRow["RepertoryNo"]) == "")
                    {
                        MessageHandler.ShowMessageBox("出库仓库不能为空，请填写后再进行保存。");
                        FocusedHeadView("RepertoryNo");
                        return;
                    }
                    if (DataTypeConvert.GetString(headRow["WarehouseReceiptTypeNo"]) == "")
                    {
                        MessageHandler.ShowMessageBox("出库类别不能为空，请填写后再进行保存。");
                        FocusedHeadView("WarehouseReceiptTypeNo");
                        return;
                    }
                    if (DataTypeConvert.GetString(headRow["ApprovalType"]) == "")
                    {
                        MessageHandler.ShowMessageBox("审批类型不能为空，请填写后再进行保存。");
                        FocusedHeadView("ApprovalType");
                        return;
                    }

                    string projectNameStr = "";
                    for (int i = gridViewWRList.DataRowCount - 1; i >= 0; i--)
                    {
                        DataRow listRow = gridViewWRList.GetDataRow(i);
                        if (DataTypeConvert.GetString(listRow["CodeFileName"]) == "")
                        {
                            gridViewWRList.DeleteRow(i);
                            continue;
                        }
                        if (DataTypeConvert.GetString(listRow["Qty"]) == "" || DataTypeConvert.GetDouble(listRow["Qty"]) == 0)
                        {
                            MessageHandler.ShowMessageBox("数量不能为空，请填写后再进行保存。");
                            FocusedListView(true, "Qty",i);
                            return;
                        }
                        if (DataTypeConvert.GetString(listRow["ShelfId"]) == "")
                        {
                            MessageHandler.ShowMessageBox("货架编号不能为空，请填写后再进行保存。");
                            FocusedListView(true, "ShelfId", i);
                            return;
                        }
                        if (DataTypeConvert.GetString(listRow["ProjectName"]) == "")
                        {
                            MessageHandler.ShowMessageBox("项目号不能为空，请填写后再进行保存。");
                            FocusedListView(true, "ProjectName", i);
                            return;
                        }
                        if (DataTypeConvert.GetString(listRow["StnNo"]) == "")
                        {
                            MessageHandler.ShowMessageBox("站号不能为空，请填写后再进行保存。");
                            FocusedListView(true, "StnNo", i);
                            return;
                        }
                        if (projectNameStr != "")
                        {
                            if(DataTypeConvert.GetString(listRow["ProjectName"])!=projectNameStr)
                            {
                                MessageHandler.ShowMessageBox("一张出库单只能选择相同的项目号进行出库，请重新填写后再进行保存。");
                                FocusedListView(true, "ProjectName", i);
                                return;
                            }
                        }
                        else
                            projectNameStr = DataTypeConvert.GetString(listRow["ProjectName"]);

                        if (!commonDAO.StnNoIsContainProjectNo(DataTypeConvert.GetString(listRow["ProjectNo"]), DataTypeConvert.GetString(listRow["StnNo"])))
                        {
                            MessageHandler.ShowMessageBox("输入的站号不属于项目号，请重新填写后再进行保存。");
                            FocusedListView(true, "StnNo", i);
                            return;
                        }
                    }

                    if (gridViewWRList.DataRowCount == 0)
                    {
                        MessageHandler.ShowMessageBox("出库单明细不能为空，请填写后再进行保存。");
                        return;
                    }

                    int ret = wrDAO.SaveWarehouseReceipt(gridViewWRHead.GetFocusedDataRow(), dataSet_WR.Tables[1]);
                    switch (ret)
                    {
                        case -1:
                            btnQuery_Click(null, null);
                            break;
                        case 1:
                            dataSet_WR.Tables[1].Clear();
                            wrDAO.QueryWarehouseReceiptList(dataSet_WR.Tables[1], DataTypeConvert.GetString(gridViewWRHead.GetFocusedDataRow()["WarehouseReceipt"]), false);
                            break;
                        case 0:
                            return;
                    }

                    SetButtonAndColumnState(false);
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
                if (gridViewWRHead.GetDataRow(headFocusedLineNo).RowState != DataRowState.Unchanged)
                {
                    if (DataTypeConvert.GetString(gridViewWRHead.GetDataRow(headFocusedLineNo)["WarehouseReceipt"]) == "")
                    {
                        gridViewWRHead.DeleteRow(headFocusedLineNo);
                    }
                    else
                    {
                        gridViewWRHead.GetFocusedDataRow().RejectChanges();
                    }
                }

                SetButtonAndColumnState(false);

                dataSet_WR.Tables[1].Clear();
                if (gridViewWRHead.GetFocusedDataRow() != null)
                    wrDAO.QueryWarehouseReceiptList(dataSet_WR.Tables[1], DataTypeConvert.GetString(gridViewWRHead.GetFocusedDataRow()["WarehouseReceipt"]), false);

                //gridViewOrderHead_FocusedRowChanged(sender, null);
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
                int count = dataSet_WR.Tables[0].Select("select=1").Length;
                if (count == 0)
                {
                    MessageHandler.ShowMessageBox("请在要操作的记录前面选中。");
                    return;
                }

                if (!CheckWarehouseState_Multi(false, true, true, true))
                    return;

                if (MessageHandler.ShowMessageBox_YesNo(string.Format("确定要删除当前选中的{0}条记录吗？", count)) != DialogResult.Yes)
                {
                    return;
                }
                if (!wrDAO.DeleteWR_Multi(dataSet_WR.Tables[0]))
                    btnQuery_Click(null, null);

                btnQuery_Click(null, null);
                ClearHeadGridAllSelect();
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--删除按钮事件错误。", ex);
            }
        }

        /// <summary>
        /// 审批按钮事件
        /// </summary>
        private void btnApprove_Click(object sender, EventArgs e)
        {
            try
            {
                int count = dataSet_WR.Tables[0].Select("select=1").Length;
                if (count == 0)
                {
                    MessageHandler.ShowMessageBox("请在要操作的记录前面选中。");
                    return;
                }

                if (!CheckWarehouseState_Multi(false, true, true, false))
                    return;

                if (count == 1)
                {
                    //弹出审批页面
                    FrmWarehouseReceiptApproval frmWR = new FrmWarehouseReceiptApproval(DataTypeConvert.GetString(dataSet_WR.Tables[0].Select("select=1")[0]["WarehouseReceipt"]));
                    if (frmWR.ShowDialog() == DialogResult.OK)
                        btnQuery_Click(null, null);
                }
                else
                {
                    if (MessageHandler.ShowMessageBox_YesNo(string.Format("确定要审批当前选中的{0}条记录吗？", count)) != DialogResult.Yes)
                    {
                        return;
                    }

                    int successCountInt = 0;
                    //直接审批，不再谈页面
                    if (!wrDAO.WRApprovalInfo_Multi(dataSet_WR.Tables[0], ref successCountInt))
                        btnQuery_Click(null, null);
                    else
                    {
                        MessageHandler.ShowMessageBox(string.Format("成功审批了{0}条记录。", successCountInt));
                    }
                }
                ClearHeadGridAllSelect();
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--审批按钮事件错误。", ex);
            }
        }

        /// <summary>
        /// 取消审批按钮事件
        /// </summary>
        private void btnCancelApprove_Click(object sender, EventArgs e)
        {
            try
            {
                int count = dataSet_WR.Tables[0].Select("select=1").Length;
                if (count == 0)
                {
                    MessageHandler.ShowMessageBox("请在要操作的记录前面选中。");
                    return;
                }

                if (!CheckWarehouseState_Multi(true, false, true, false))
                    return;

                if (MessageHandler.ShowMessageBox_YesNo(string.Format("确定要取消审批当前选中的{0}条记录吗？", count)) != DialogResult.Yes)
                {
                    return;
                }

                if (!wrDAO.CancalWRApprovalInfo_Multi(dataSet_WR.Tables[0]))
                    btnQuery_Click(null, null);
                else
                {
                    MessageHandler.ShowMessageBox(string.Format("成功取消审批了{0}条记录。", count));
                }
                ClearHeadGridAllSelect();
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--取消审批按钮事件错误。", ex);
            }
        }

        /// <summary>
        /// 打印预览按钮事件
        /// </summary>
        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                string wrHeadNoStr = "";
                if (gridViewWRHead.GetFocusedDataRow() != null)
                    wrHeadNoStr = DataTypeConvert.GetString(gridViewWRHead.GetFocusedDataRow()["WarehouseReceipt"]);
                wrDAO.PrintHandle(wrHeadNoStr, 1);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--预览按钮事件错误。", ex);
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
            foreach (DataRow dr in dataSet_WR.Tables[0].Rows)
            {
                dr["Select"] = value;
            }
            onlySelectColChangeRowState = true;
        }

        /// <summary>
        /// 子表新增一行事件
        /// </summary>
        private void btnListAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!colRemark.OptionsColumn.AllowEdit)
                    return;

                ListNewRow();
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--子表新增一行事件错误。", ex);
            }
        }

        /// <summary>
        /// 主表设定默认值
        /// </summary>
        private void gridViewWRHead_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            try
            {
                gridViewWRHead.SetFocusedRowCellValue("WarehouseReceiptDate", BaseSQL.GetServerDateTime());
                gridViewWRHead.SetFocusedRowCellValue("ReqDep", SystemInfo.user.DepartmentNo);
                gridViewWRHead.SetFocusedRowCellValue("WarehouseState", 1);
                gridViewWRHead.SetFocusedRowCellValue("Prepared", SystemInfo.user.EmpName);
                gridViewWRHead.SetFocusedRowCellValue("WarehouseReceiptTypeNo", wwDAO.Get_WarehouseType_TypeNo("BS_WarehouseReceiptType", "WarehouseReceiptTypeNo"));
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--主表设定默认值错误。", ex);
            }
        }

        /// <summary>
        /// 子表设定默认值
        /// </summary>
        private void gridViewWRList_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            try
            {
                gridViewWRList.SetFocusedRowCellValue("WarehouseReceipt", DataTypeConvert.GetString(gridViewWRHead.GetFocusedDataRow()["WarehouseReceipt"]));
                if (dataSet_WR.Tables[1].Rows.Count > 0)
                {
                    if (gridViewWRList.GetFocusedDataSourceRowIndex() == 0)
                        gridViewWRList.SetFocusedRowCellValue("ProjectName", gridViewWRList.GetDataRow(1)["ProjectName"]);
                    else
                        gridViewWRList.SetFocusedRowCellValue("ProjectName", gridViewWRList.GetDataRow(0)["ProjectName"]);

                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--子表设定默认值错误。", ex);
            }
        }

        /// <summary>
        /// 子表按键事件
        /// </summary>
        private void gridViewWRList_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (!colRemark.OptionsColumn.AllowEdit)
                        return;

                    if (gridViewWRList.GetFocusedDataSourceRowIndex() >= gridViewWRList.DataRowCount - 1 && gridViewWRList.FocusedColumn.Name == "colRemark")
                    {
                        ListNewRow();
                    }
                    else if (gridViewWRList.FocusedColumn.Name == "colRemark")
                    {
                        gridViewWRList.FocusedRowHandle = gridViewWRList.FocusedRowHandle + 1;
                        FocusedListView(true, "CodeFileName", gridViewWRList.GetFocusedDataSourceRowIndex());
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--子表按键事件错误。", ex);
            }
        }

        /// <summary>
        /// 删除子表中的一行
        /// </summary>
        private void repbtnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                gridViewWRList.DeleteRow(gridViewWRList.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--删除子表中的一行错误。", ex);
            }
        }

        /// <summary>
        /// 子表单元格值变化进行的操作
        /// </summary>
        private void gridViewWRList_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            try
            {
                switch (e.Column.FieldName)
                {
                    case "CodeFileName":
                        string tmpStr = DataTypeConvert.GetString(gridViewWRList.GetDataRow(e.RowHandle)["CodeFileName"]);
                        if (tmpStr == "")
                            gridViewWRList.SetRowCellValue(e.RowHandle, "CodeName", "");
                        else
                        {
                            DataTable temp = (DataTable)repSearchCodeFileName.DataSource;
                            DataRow[] drs = temp.Select(string.Format("CodeFileName='{0}'", tmpStr));
                            if (drs.Length > 0)
                            {
                                gridViewWRList.SetRowCellValue(e.RowHandle, "CodeName", DataTypeConvert.GetString(drs[0]["CodeName"]));
                            }
                        }
                        break;
                    case "ProjectName":
                        string projectNameStr = DataTypeConvert.GetString(gridViewWRList.GetDataRow(e.RowHandle)["ProjectName"]);
                        string projectNoStr = "";
                        if (projectNameStr == "")
                        {
                            gridViewWRList.SetRowCellValue(e.RowHandle, "ProjectNo", "");
                            gridViewWRList.SetRowCellValue(e.RowHandle, "ProjectName", "");
                            gridViewWRList.SetRowCellValue(e.RowHandle, "StnNo", "");
                        }
                        else
                        {
                            DataTable temp = (DataTable)repSearchProjectNo.DataSource;
                            DataRow[] drs = temp.Select(string.Format("ProjectName='{0}'", projectNameStr));
                            if (drs.Length > 0)
                            {
                                gridViewWRList.SetRowCellValue(e.RowHandle, "ProjectNo", DataTypeConvert.GetString(drs[0]["ProjectNo"]));
                                projectNoStr = DataTypeConvert.GetString(drs[0]["ProjectNo"]);
                            }
                            gridViewWRList.SetRowCellValue(e.RowHandle, "StnNo", "");
                        }
                        BingStnListComboBox(projectNoStr);
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
            if (DataTypeConvert.GetBoolean(gridViewWRHead.GetFocusedDataRow()["Select"]))
                gridViewWRHead.GetFocusedDataRow()["Select"] = false;
            else
                gridViewWRHead.GetFocusedDataRow()["Select"] = true;
            onlySelectColChangeRowState = true;
        }

        /// <summary>
        /// 检查是否有未填写字段
        /// </summary>
        private bool IsHaveBlankLine()
        {
            gridViewWRList.FocusedRowHandle = 0;
            for (int i = 0; i < gridViewWRList.DataRowCount; i++)
            {
                if (DataTypeConvert.GetString(gridViewWRList.GetDataRow(i)["CodeFileName"]) == "")
                {
                    gridViewWRList.Focus();
                    gridViewWRList.FocusedColumn = colCodeFileName;
                    gridViewWRList.FocusedRowHandle = i;
                    return true;
                }
                if (DataTypeConvert.GetString(gridViewWRList.GetDataRow(i)["ShelfId"]) == "")
                {
                    gridViewWRList.Focus();
                    gridViewWRList.FocusedColumn = colShelfId;
                    gridViewWRList.FocusedRowHandle = i;
                    return true;
                }
                if (DataTypeConvert.GetString(gridViewWRList.GetDataRow(i)["Qty"]) == "")
                {
                    gridViewWRList.Focus();
                    gridViewWRList.FocusedColumn = colQty;
                    gridViewWRList.FocusedRowHandle = i;
                    return true;
                }
                if (DataTypeConvert.GetString(gridViewWRList.GetDataRow(i)["ProjectName"]) == "")
                {
                    gridViewWRList.Focus();
                    gridViewWRList.FocusedColumn = colProjectName;
                    gridViewWRList.FocusedRowHandle = i;
                    return true;
                }
                if (DataTypeConvert.GetString(gridViewWRList.GetDataRow(i)["StnNo"]) == "")
                {
                    gridViewWRList.Focus();
                    gridViewWRList.FocusedColumn = colStnNo;
                    gridViewWRList.FocusedRowHandle = i;
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

            //gridViewWRList.PostEditor();
            gridViewWRList.AddNewRow();            
            FocusedListView(true, "CodeFileName", gridViewWRList.GetFocusedDataSourceRowIndex());
            //gridViewWRList.RefreshData();
        }

        /// <summary>
        /// 设定按钮和表列状态
        /// </summary>
        /// <param name="ret">状态标准</param>
        private void SetButtonAndColumnState(bool ret)
        {
            if (ret)
            {
                btnNew.Enabled = false;
                btnSave.Text = "保存";
                btnCancel.Enabled = true;
                btnDelete.Enabled = false;
            }
            else
            {
                btnNew.Enabled = true;
                btnSave.Text = "修改";
                btnCancel.Enabled = false;
                btnDelete.Enabled = true;
            }
            btnApprove.Enabled = !ret;
            btnCancelApprove.Enabled = !ret;
            btnPreview.Enabled = !ret;

            btnListAdd.Enabled = ret;

            if (SystemInfo.WarehouseReceiptIsAlterDate)
            {
                colWarehouseReceiptDate.OptionsColumn.AllowEdit = ret;
                colWarehouseReceiptDate.OptionsColumn.AllowFocus = ret;
            }

            colRepertoryNo.OptionsColumn.AllowEdit = ret;
            colWarehouseReceiptTypeNo.OptionsColumn.AllowEdit = ret;
            colApprovalType.OptionsColumn.AllowEdit = ret;
            colManufactureNo.OptionsColumn.AllowEdit = ret;
            colRemark1.OptionsColumn.AllowEdit = ret;

            colCodeFileName.OptionsColumn.AllowEdit = ret;
            colQty.OptionsColumn.AllowEdit = ret;
            colShelfId.OptionsColumn.AllowEdit = ret;
            colProjectName.OptionsColumn.AllowEdit = ret;
            colStnNo.OptionsColumn.AllowEdit = ret;
            colRemark.OptionsColumn.AllowEdit = ret;

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
        /// 检测出库单状态是否可以操作
        /// </summary>
        private bool CheckWarehouseState()
        {
            if (gridViewWRHead.GetFocusedDataRow() == null)
                return false;
            int reqState = DataTypeConvert.GetInt(gridViewWRHead.GetFocusedDataRow()["WarehouseState"]);
            switch (reqState)
            {
                case 2:
                    MessageHandler.ShowMessageBox(string.Format("出库单[{0}]已经审批，不可以操作。", DataTypeConvert.GetString(gridViewWRHead.GetFocusedDataRow()["WarehouseReceipt"])));
                    return false;
                case 3:
                    MessageHandler.ShowMessageBox(string.Format("出库单[{0}]已经结账，不可以操作。", DataTypeConvert.GetString(gridViewWRHead.GetFocusedDataRow()["WarehouseReceipt"])));
                    return false;
                case 4:
                    MessageHandler.ShowMessageBox(string.Format("出库单[{0}]已经审批中，不可以操作。", DataTypeConvert.GetString(gridViewWRHead.GetFocusedDataRow()["WarehouseReceipt"])));
                    return false;
            }
            return true;
        }

        /// <summary>
        /// 检测当前选中的出库单状态是否可以操作
        /// </summary>
        private bool CheckWarehouseState_Multi(bool checkNoApprover, bool checkApprover, bool checkSettle, bool checkApproverBetween)
        {
            for (int i = 0; i < gridViewWRHead.DataRowCount; i++)
            {
                if (DataTypeConvert.GetBoolean(gridViewWRHead.GetDataRow(i)["Select"]))
                {
                    int reqState = DataTypeConvert.GetInt(gridViewWRHead.GetDataRow(i)["WarehouseState"]);
                    switch (reqState)
                    {
                        case 1:
                            if (checkNoApprover)
                            {
                                MessageHandler.ShowMessageBox(string.Format("出库单[{0}]未审批，不可以操作。", DataTypeConvert.GetString(gridViewWRHead.GetDataRow(i)["WarehouseReceipt"])));
                                gridViewWRHead.FocusedRowHandle = i;
                                return false;
                            }
                            break;
                        case 2:
                            if (checkApprover)
                            {
                                MessageHandler.ShowMessageBox(string.Format("出库单[{0}]已经审批，不可以操作。", DataTypeConvert.GetString(gridViewWRHead.GetDataRow(i)["WarehouseReceipt"])));
                                gridViewWRHead.FocusedRowHandle = i;
                                return false;
                            }
                            break;
                        case 3:
                            if (checkSettle)
                            {
                                MessageHandler.ShowMessageBox(string.Format("出库单[{0}]已经结账，不可以操作。", DataTypeConvert.GetString(gridViewWRHead.GetDataRow(i)["WarehouseReceipt"])));
                                gridViewWRHead.FocusedRowHandle = i;
                                return false;
                            }
                            break;
                        case 4:
                            if (checkApproverBetween)
                            {
                                MessageHandler.ShowMessageBox(string.Format("出库单[{0}]已经审批中，不可以操作。", DataTypeConvert.GetString(gridViewWRHead.GetDataRow(i)["WarehouseReceipt"])));
                                gridViewWRHead.FocusedRowHandle = i;
                                return false;
                            }
                            break;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// 聚焦主表当前行的列
        /// </summary>
        private void FocusedHeadView(string colName)
        {
            gridControlWRHead.Focus();
            ColumnView headView = (ColumnView)gridControlWRHead.FocusedView;
            headView.FocusedColumn = headView.Columns[colName];
            gridViewWRHead.FocusedRowHandle = headView.FocusedRowHandle;
        }

        /// <summary>
        /// 聚焦子表当前行的列
        /// </summary>
        private void FocusedListView(bool isFocusedControl, string colName, int lineNo)
        {
            if (isFocusedControl)
                gridControlWRList.Focus();
            ColumnView listView = (ColumnView)gridControlWRList.FocusedView;
            listView.FocusedColumn = listView.Columns[colName];
            gridViewWRList.FocusedRowHandle = lineNo;
        }

        /// <summary>
        /// 绑定站号的ComboBox控件
        /// </summary>
        private void BingStnListComboBox(string projectNoStr)
        {
            DataTable stnListTable = commonDAO.QueryStnList(projectNoStr);
            repComboBoxStnNo.Items.Clear();
            for (int i = 0; i < stnListTable.Rows.Count; i++)
            {
                repComboBoxStnNo.Items.Add(DataTypeConvert.GetString(stnListTable.Rows[i]["StnNo"]));
            }
        }

        /// <summary>
        /// 清楚当前的所有选择
        /// </summary>
        private void ClearHeadGridAllSelect()
        {
            checkAll.Checked = false;
            for (int i = 0; i < dataSet_WR.Tables[0].Rows.Count; i++)
            {
                dataSet_WR.Tables[0].Rows[i]["Select"] = false;
            }
            dataSet_WR.Tables[0].AcceptChanges();
            onlySelectColChangeRowState = false;
        }

    }
}
