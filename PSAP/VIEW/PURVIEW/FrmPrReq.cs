using DevExpress.XtraGrid.Views.Base;
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
    public partial class FrmPrReq : DockContent
    {
        FrmPrReqDAO prReqDAO = new FrmPrReqDAO();
        /// <summary>
        /// 主表聚焦的行号
        /// </summary>
        int headFocusedLineNo = 0;

        /// <summary>
        /// 查询的请购单号
        /// </summary>
        public static string queryPrReqNo = "";

        /// <summary>
        /// 只有选择列改变行状态的时候
        /// </summary>
        bool onlySelectColChangeRowState = false;

        public FrmPrReq()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmPrReq_Load(object sender, EventArgs e)
        {
            try
            {
                dateReqDateBegin.DateTime = DateTime.Now.Date.AddDays(-7);
                dateReqDateEnd.DateTime = DateTime.Now.Date;

                lookUpReqDep.Properties.DataSource = prReqDAO.QueryDepartment(true);
                lookUpReqDep.ItemIndex = 0;
                lookUpPurCategory.Properties.DataSource = prReqDAO.QueryPurCategory(true);
                lookUpPurCategory.ItemIndex = 0;
                comboBoxReqState.SelectedIndex = 0;
                lookUpApplicant.Properties.DataSource = prReqDAO.QueryUserInfo();
                lookUpApplicant.EditValue = SystemInfo.user.EmpName;

                repLookUpReqDep.DataSource = prReqDAO.QueryDepartment(false);
                repLookUpPurCategory.DataSource = prReqDAO.QueryPurCategory(false);
                repSearchProjectNo.DataSource = prReqDAO.QueryProjectList(false);

                repSearchCodeFileName.DataSource = prReqDAO.QueryPartsCode(false);

                if (textCommon.Text == "")
                {
                    prReqDAO.QueryPrReqHead(dataSet_PrReq.Tables[0], "", "", "", "", 0, "", "", true);
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
        private void FrmPrReq_Activated(object sender, EventArgs e)
        {
            try
            {
                if (queryPrReqNo != "")
                {
                    textCommon.Text = queryPrReqNo;
                    queryPrReqNo = "";
                    lookUpReqDep.ItemIndex = 0;
                    lookUpPurCategory.ItemIndex = 0;
                    comboBoxReqState.SelectedIndex = 0;
                    lookUpApplicant.ItemIndex = 0;

                    dataSet_PrReq.Tables[0].Clear();
                    headFocusedLineNo = 0;
                    prReqDAO.QueryPrReqHead(dataSet_PrReq.Tables[0], "", "", "", "", 0, "", textCommon.Text, false);
                    SetButtonAndColumnState(false);

                    if (dataSet_PrReq.Tables[0].Rows.Count > 0)
                    {
                        dateReqDateBegin.DateTime = DataTypeConvert.GetDateTime(dataSet_PrReq.Tables[0].Rows[0]["ReqDate"]).Date;
                        dateReqDateEnd.DateTime = dateReqDateBegin.DateTime.AddDays(7);
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
        private void FrmPrReq_Shown(object sender, EventArgs e)
        {
            pnlMiddle.Height = (this.Height - pnltop.Height) / 2;
        }

        /// <summary>
        /// 查询按钮事件
        /// </summary>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                string reqDepStr = lookUpReqDep.ItemIndex > 0 ? lookUpReqDep.EditValue.ToString() : "";
                string purCategoryStr = lookUpPurCategory.ItemIndex > 0 ? lookUpPurCategory.EditValue.ToString() : "";
                int reqStateInt = comboBoxReqState.SelectedIndex > 0 ? comboBoxReqState.SelectedIndex : 0;
                string empNameStr = lookUpApplicant.ItemIndex > 0 ? lookUpApplicant.EditValue.ToString() : "";
                string commonStr = textCommon.Text.Trim();
                dataSet_PrReq.Tables[0].Clear();
                dataSet_PrReq.Tables[1].Clear();
                headFocusedLineNo = 0;
                prReqDAO.QueryPrReqHead(dataSet_PrReq.Tables[0], dateReqDateBegin.DateTime.ToString("yyyy-MM-dd"), dateReqDateEnd.DateTime.AddDays(1).ToString("yyyy-MM-dd"), reqDepStr, purCategoryStr, reqStateInt, empNameStr, commonStr, false);

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
        private void gridViewPrReqHead_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (gridViewPrReqHead.GetFocusedDataRow() != null)
                {
                    if (onlySelectColChangeRowState)
                    {
                        dataSet_PrReq.Tables[0].AcceptChanges();
                        onlySelectColChangeRowState = false;
                    }
                    else
                    {
                        if (headFocusedLineNo < gridViewPrReqHead.DataRowCount && gridViewPrReqHead.FocusedRowHandle != headFocusedLineNo && gridViewPrReqHead.GetDataRow(headFocusedLineNo).RowState != DataRowState.Unchanged)
                        {
                            MessageHandler.ShowMessageBox("当前请购单已经修改，请保存后再进行换行。");
                            gridViewPrReqHead.FocusedRowHandle = headFocusedLineNo;
                        }
                        else if (headFocusedLineNo == gridViewPrReqHead.DataRowCount)
                        {

                        }
                        else
                        {
                            if (gridViewPrReqHead.FocusedRowHandle != headFocusedLineNo && gridViewPrReqHead.GetDataRow(headFocusedLineNo).RowState != DataRowState.Unchanged)
                                btnCancel_Click(null, null);
                            else if (gridViewPrReqHead.GetDataRow(headFocusedLineNo).RowState == DataRowState.Unchanged)
                                btnCancel_Click(null, null);
                        }
                    }

                    if (DataTypeConvert.GetString(gridViewPrReqHead.GetFocusedDataRow()["PrReqNo"]) != "")
                    {
                        dataSet_PrReq.Tables[1].Clear();
                        prReqDAO.QueryPrReqList(dataSet_PrReq.Tables[1], DataTypeConvert.GetString(gridViewPrReqHead.GetFocusedDataRow()["PrReqNo"]));
                    }

                    if (gridViewPrReqHead.FocusedRowHandle >= 0)
                    {
                        headFocusedLineNo = gridViewPrReqHead.FocusedRowHandle;
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
        private void gridViewPrReqHead_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewPrReqList_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
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
            if (e.RowHandle >= 0 && e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        /// <summary>
        /// 设定列表显示信息
        /// </summary>
        private void gridViewPrReqHead_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "ReqState")
            {
                if (e.Value.ToString() == "1")
                    e.DisplayText = "待审核";
                else if (e.Value.ToString() == "2")
                    e.DisplayText = "审核";
                else
                    e.DisplayText = "关闭";
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

                //gridViewPrReqHead.PostEditor();
                gridViewPrReqHead.AddNewRow();
                FocusedHeadView("ReqDate");

                dataSet_PrReq.Tables[1].Clear();
                gridViewPrReqList.AddNewRow();
                FocusedListView(false, "CodeFileName");

                SetButtonAndColumnState(true);
                headFocusedLineNo = gridViewPrReqHead.DataRowCount;
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
                if (gridViewPrReqHead.GetFocusedDataRow() == null)
                    return;

                if (!CheckReqState())
                    return;                

                if (btnSave.Text != "保存")
                {
                    ClearHeadGridAllSelect();

                    SetButtonAndColumnState(true);
                    FocusedHeadView("ReqDate");
                    BingStnListComboBox();
                }
                else
                {
                    DataRow headRow = gridViewPrReqHead.GetFocusedDataRow();
                    if (DataTypeConvert.GetString(headRow["ReqDep"]) == "")
                    {
                        MessageHandler.ShowMessageBox("申请部门不能为空，请填写后再进行保存。");
                        FocusedHeadView("ReqDep");
                        return;
                    }
                    if (DataTypeConvert.GetString(headRow["ProjectNo"]) == "")
                    {
                        MessageHandler.ShowMessageBox("项目号不能为空，请填写后再进行保存。");
                        FocusedHeadView("ProjectNo");
                        return;
                    }
                    if (DataTypeConvert.GetString(headRow["StnNo"]) == "")
                    {
                        MessageHandler.ShowMessageBox("站号不能为空，请填写后再进行保存。");
                        FocusedHeadView("StnNo");
                        return;
                    }
                    if (DataTypeConvert.GetString(headRow["PurCategory"]) == "")
                    {
                        MessageHandler.ShowMessageBox("采购类型不能为空，请填写后再进行保存。");
                        FocusedHeadView("PurCategory");
                        return;
                    }

                    if(!prReqDAO.StnNoIsContainProjectNo(DataTypeConvert.GetString(headRow["ProjectNo"]), DataTypeConvert.GetString(headRow["StnNo"])))
                    {
                        MessageHandler.ShowMessageBox("输入的站号不属于项目号，请重新填写后再进行保存。");
                        FocusedHeadView("StnNo");
                        return;
                    }

                    for (int i = gridViewPrReqList.DataRowCount - 1; i >= 0; i--)
                    {
                        DataRow listRow = gridViewPrReqList.GetDataRow(i);
                        if (DataTypeConvert.GetString(listRow["CodeFileName"]) == "")
                        {
                            gridViewPrReqList.DeleteRow(i);
                            continue;
                        }
                        if (DataTypeConvert.GetString(listRow["Qty"]) == "")
                        {
                            MessageHandler.ShowMessageBox("数量不能为空，请填写后再进行保存。");
                            FocusedListView(true, "Qty");
                            return;
                        }
                    }

                    if (!prReqDAO.SavePrReq(gridViewPrReqHead.GetFocusedDataRow(), dataSet_PrReq.Tables[1]))
                    {
                        btnQuery_Click(null, null);
                    }
                    else
                    {
                        dataSet_PrReq.Tables[1].Clear();
                        prReqDAO.QueryPrReqList(dataSet_PrReq.Tables[1], DataTypeConvert.GetString(gridViewPrReqHead.GetFocusedDataRow()["PrReqNo"]));
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
                if (gridViewPrReqHead.GetDataRow(headFocusedLineNo).RowState != DataRowState.Unchanged)
                {
                    if (DataTypeConvert.GetString(gridViewPrReqHead.GetDataRow(headFocusedLineNo)["PrReqNo"]) == "")
                    {
                        gridViewPrReqHead.DeleteRow(headFocusedLineNo);
                    }
                    else
                    {
                        gridViewPrReqHead.GetFocusedDataRow().RejectChanges();
                    }

                }

                SetButtonAndColumnState(false);

                dataSet_PrReq.Tables[1].Clear();
                if (gridViewPrReqHead.GetFocusedDataRow() != null)
                    prReqDAO.QueryPrReqList(dataSet_PrReq.Tables[1], DataTypeConvert.GetString(gridViewPrReqHead.GetFocusedDataRow()["PrReqNo"]));
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
                int count = dataSet_PrReq.Tables[0].Select("select=1").Length;
                if (count == 0)
                {
                    MessageHandler.ShowMessageBox("请在要操作的记录前面选中。");
                    return;
                }

                if (!CheckReqState_Multi(true,true, false))
                    return;                

                if (MessageHandler.ShowMessageBox_YesNo(string.Format("确定要删除当前选中的{0}条记录吗？", count)) != DialogResult.Yes)
                {
                    return;
                }
                //prReqDAO.DeletePrReq(DataTypeConvert.GetString(gridViewPrReqHead.GetFocusedDataRow()["PrReqNo"]));
                if (!prReqDAO.DeletePrReq_Multi(dataSet_PrReq.Tables[0]))
                    btnQuery_Click(null, null);

                btnQuery_Click(null, null);
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
                int count = dataSet_PrReq.Tables[0].Select("select=1").Length;
                if (count == 0)
                {
                    MessageHandler.ShowMessageBox("请在要操作的记录前面选中。");
                    return;
                }

                if (!CheckReqState_Multi(true,true, false))
                    return;

                if (MessageHandler.ShowMessageBox_YesNo(string.Format("确定要审核当前选中的{0}条记录吗？", count)) != DialogResult.Yes)
                {
                    return;
                }

                if (!prReqDAO.ApprovePrReq_Multi(dataSet_PrReq.Tables[0]))
                    btnQuery_Click(null, null);
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
                int count = dataSet_PrReq.Tables[0].Select("select=1").Length;
                if (count == 0)
                {
                    MessageHandler.ShowMessageBox("请在要操作的记录前面选中。");
                    return;
                }

                if (!CheckReqState_Multi(false, true, true))
                    return;

                if (MessageHandler.ShowMessageBox_YesNo(string.Format("确定要审核当前选中的{0}条记录吗？", count)) != DialogResult.Yes)
                {
                    return;
                }

                if (!prReqDAO.CancelApprovePrReq_Multi(dataSet_PrReq.Tables[0]))
                    btnQuery_Click(null, null);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--取消审批按钮事件错误。", ex);
            }
        }

        /// <summary>
        /// 关闭按钮事件
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                int count = dataSet_PrReq.Tables[0].Select("select=1").Length;
                if (count == 0)
                {
                    MessageHandler.ShowMessageBox("请在要操作的记录前面选中。");
                    return;
                }

                if (!CheckReqState_Multi(false, true, false))
                    return;

                if (MessageHandler.ShowMessageBox_YesNo(string.Format("确定要关闭当前选中的{0}条记录吗？", count)) != DialogResult.Yes)
                {
                    return;
                }
                if (!prReqDAO.ClosePrReq_Multi(dataSet_PrReq.Tables[0]))
                    btnQuery_Click(null, null);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--关闭按钮事件错误。", ex);
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
            foreach (DataRow dr in dataSet_PrReq.Tables[0].Rows)
            {
                dr["Select"] = value;
            }
            onlySelectColChangeRowState = true;
        }

        /// <summary>
        /// 主表设定默认值
        /// </summary>
        private void gridViewPrReqHead_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            try
            {
                gridViewPrReqHead.SetFocusedRowCellValue("ReqDate", DateTime.Now);
                gridViewPrReqHead.SetFocusedRowCellValue("ReqDep", SystemInfo.user.DepartmentNo);
                gridViewPrReqHead.SetFocusedRowCellValue("PurCategory", DataTypeConvert.GetString(((DataTable)lookUpPurCategory.Properties.DataSource).Rows[1]["PurCategory"]));
                gridViewPrReqHead.SetFocusedRowCellValue("ReqState", 1);
                gridViewPrReqHead.SetFocusedRowCellValue("Applicant", SystemInfo.user.EmpName);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--主表设定默认值错误。", ex);
            }
        }

        /// <summary>
        /// 子表设定默认值
        /// </summary>
        private void gridViewPrReqList_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            try
            {
                gridViewPrReqList.SetFocusedRowCellValue("PrReqNo", DataTypeConvert.GetString(gridViewPrReqHead.GetFocusedDataRow()["PrReqNo"]));
                gridViewPrReqList.SetFocusedRowCellValue("RequirementDate", DataTypeConvert.GetDateTime(gridViewPrReqHead.GetFocusedDataRow()["ReqDate"]).AddDays(7));
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--子表设定默认值错误。", ex);
            }
        }

        /// <summary>
        /// 子表按键事件
        /// </summary>
        private void gridViewPrReqList_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (!colPrReqListRemark.OptionsColumn.AllowEdit)
                        return;

                    if (gridViewPrReqList.GetFocusedDataSourceRowIndex() >= gridViewPrReqList.DataRowCount - 1 && gridViewPrReqList.FocusedColumn.Name == "colPrReqListRemark")
                    {
                        if (IsHaveBlankLine())
                            return;

                        //gridViewPrReqList.PostEditor();
                        gridViewPrReqList.AddNewRow();
                        FocusedListView(true, "CodeFileName");
                    }
                    else if(gridViewPrReqList.FocusedColumn.Name == "colPrReqListRemark")
                    {
                        gridViewPrReqList.FocusedRowHandle = gridViewPrReqList.FocusedRowHandle + 1;
                        FocusedListView(true, "CodeFileName");
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
                gridViewPrReqList.DeleteRow(gridViewPrReqList.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--删除子表中的一行错误。", ex);
            }
        }

        /// <summary>
        /// 主表单元格值变化进行的操作
        /// </summary>
        private void gridViewPrReqHead_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "ProjectNo")
                {
                    BingStnListComboBox();
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--主表单元格值变化进行的操作错误。", ex);
            }
        }

        /// <summary>
        /// 子表单元格值变化进行的操作
        /// </summary>
        private void gridViewPrReqList_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            try
            {
                switch (e.Column.FieldName)
                {
                    case "CodeFileName":
                        string tmpStr = DataTypeConvert.GetString(gridViewPrReqList.GetDataRow(e.RowHandle)["CodeFileName"]);
                        if (tmpStr == "")
                            gridViewPrReqList.SetRowCellValue(e.RowHandle, "CodeName", "");
                        else
                        {
                            DataTable temp = (DataTable)repSearchCodeFileName.DataSource;
                            DataRow[] drs = temp.Select(string.Format("CodeFileName='{0}'", tmpStr));
                            if (drs.Length > 0)
                            {
                                gridViewPrReqList.SetRowCellValue(e.RowHandle, "CodeName", DataTypeConvert.GetString(drs[0]["CodeName"]));
                            }
                        }
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
            if (DataTypeConvert.GetBoolean(gridViewPrReqHead.GetFocusedDataRow()["Select"]))
                gridViewPrReqHead.GetFocusedDataRow()["Select"] = false;
            else
                gridViewPrReqHead.GetFocusedDataRow()["Select"] = true;
            onlySelectColChangeRowState = true;
        }

        /// <summary>
        /// 检查是否有未填写字段
        /// </summary>
        private bool IsHaveBlankLine()
        {
            gridViewPrReqList.FocusedRowHandle = 0;
            for (int i = 0; i < gridViewPrReqList.DataRowCount; i++)
            {
                if (DataTypeConvert.GetString(gridViewPrReqList.GetDataRow(i)["CodeFileName"]) == "")
                {
                    gridViewPrReqList.Focus();
                    gridViewPrReqList.FocusedColumn = colCodeFileName;
                    gridViewPrReqList.FocusedRowHandle = i;
                    return true;
                }
                if (DataTypeConvert.GetString(gridViewPrReqList.GetDataRow(i)["Qty"]) == "")
                {
                    gridViewPrReqList.Focus();
                    gridViewPrReqList.FocusedColumn = colQty;
                    gridViewPrReqList.FocusedRowHandle = i;
                    return true;
                }
            }
            return false;
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
                btnApprove.Enabled = false;
                btnClose.Enabled = false;
                btnCancelApprove.Enabled = false;
            }
            else
            {
                btnNew.Enabled = true;
                btnSave.Text = "修改";
                btnCancel.Enabled = false;
                btnDelete.Enabled = true;
                btnApprove.Enabled = true;
                btnClose.Enabled = true;
                btnCancelApprove.Enabled = true;
            }

            colReqDate.OptionsColumn.AllowEdit = ret;
            colReqDep.OptionsColumn.AllowEdit = ret;
            colProjectNo.OptionsColumn.AllowEdit = ret;
            colStnNo.OptionsColumn.AllowEdit = ret;
            colPurCategory.OptionsColumn.AllowEdit = ret;
            colPrReqRemark.OptionsColumn.AllowEdit = ret;

            colCodeFileName.OptionsColumn.AllowEdit = ret;
            colQty.OptionsColumn.AllowEdit = ret;
            colRequirementDate.OptionsColumn.AllowEdit = ret;
            colPrReqListRemark.OptionsColumn.AllowEdit = ret;

            repbtnDelete.Buttons[0].Enabled = ret;
            repCheckSelect.ReadOnly = ret;
        }

        /// <summary>
        /// 检测请购单状态是否可以操作
        /// </summary>
        private bool CheckReqState()
        {
            if (gridViewPrReqHead.GetFocusedDataRow() == null)
                return false;
            int reqState = DataTypeConvert.GetInt(gridViewPrReqHead.GetFocusedDataRow()["ReqState"]);
            switch (reqState)
            {
                case 2:
                    MessageHandler.ShowMessageBox(string.Format("采购请购单[{0}]已经审核，不可以操作。", DataTypeConvert.GetString(gridViewPrReqHead.GetFocusedDataRow()["PrReqNo"])));
                    return false;
                case 3:
                    MessageHandler.ShowMessageBox(string.Format("采购请购单[{0}]已经关闭，不可以操作。", DataTypeConvert.GetString(gridViewPrReqHead.GetFocusedDataRow()["PrReqNo"])));
                    return false;
            }
            return true;
        }

        /// <summary>
        /// 检测当前选中的请购单状态是否可以操作
        /// </summary>
        private bool CheckReqState_Multi(bool checkApprover, bool checkClosed,bool checkNoApprover)
        {
            for (int i = 0; i < gridViewPrReqHead.DataRowCount; i++)
            {
                if (DataTypeConvert.GetBoolean(gridViewPrReqHead.GetDataRow(i)["Select"]))
                {
                    int reqState = DataTypeConvert.GetInt(gridViewPrReqHead.GetDataRow(i)["ReqState"]);
                    switch (reqState)
                    {
                        case 1:
                            if (checkNoApprover)
                            {
                                MessageHandler.ShowMessageBox(string.Format("采购请购单[{0}]未审核，不可以操作。", DataTypeConvert.GetString(gridViewPrReqHead.GetDataRow(i)["PrReqNo"])));
                                gridViewPrReqHead.FocusedRowHandle = i;
                                return false;
                            }
                            break;
                        case 2:
                            if (checkApprover)
                            {
                                MessageHandler.ShowMessageBox(string.Format("采购请购单[{0}]已经审核，不可以操作。", DataTypeConvert.GetString(gridViewPrReqHead.GetDataRow(i)["PrReqNo"])));
                                gridViewPrReqHead.FocusedRowHandle = i;
                                return false;
                            }
                            break;
                        case 3:
                            if (checkClosed)
                            {
                                MessageHandler.ShowMessageBox(string.Format("采购请购单[{0}]已经关闭，不可以操作。", DataTypeConvert.GetString(gridViewPrReqHead.GetDataRow(i)["PrReqNo"])));
                                gridViewPrReqHead.FocusedRowHandle = i;
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
            gridControlPrReqHead.Focus();
            ColumnView headView = (ColumnView)gridControlPrReqHead.FocusedView;
            headView.FocusedColumn = headView.Columns[colName];
            gridViewPrReqHead.FocusedRowHandle = headView.FocusedRowHandle;
        }

        /// <summary>
        /// 聚焦子表当前行的列
        /// </summary>
        private void FocusedListView(bool isFocusedControl, string colName)
        {
            if (isFocusedControl)
                gridControlPrReqList.Focus();
            ColumnView listView = (ColumnView)gridControlPrReqList.FocusedView;
            listView.FocusedColumn = listView.Columns[colName];
            gridViewPrReqList.FocusedRowHandle = listView.FocusedRowHandle;
        }

        /// <summary>
        /// 绑定站号的ComboBox控件
        /// </summary>
        private void BingStnListComboBox()
        {
            string tmpStr = DataTypeConvert.GetString(gridViewPrReqHead.GetFocusedDataRow()["ProjectNo"]);
            DataTable stnListTable = prReqDAO.QueryStnList(tmpStr);
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
            for(int i=0;i<dataSet_PrReq.Tables[0].Rows.Count;i++)
            {
                dataSet_PrReq.Tables[0].Rows[i]["Select"] = false;

            }
            dataSet_PrReq.Tables[0].AcceptChanges();
        }

    }
}
