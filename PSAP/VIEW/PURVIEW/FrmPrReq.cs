using DevExpress.XtraGrid.Views.Base;
using PSAP.BLL.BSBLL;
using PSAP.DAO.BSDAO;
using PSAP.DAO.PURDAO;
using PSAP.PSAPCommon;
using PsapUserControlLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PSAP.VIEW.BSVIEW
{
    public partial class FrmPrReq : DockContent
    {
        FrmPrReqDAO prReqDAO = new FrmPrReqDAO();
        int headFocusedLineNo = 0;

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
                lookUpReqDep.Properties.DataSource = prReqDAO.QueryDepartment(true);
                lookUpReqDep.ItemIndex = 0;
                lookUpPurCategory.Properties.DataSource = prReqDAO.QueryPurCategory(true);
                lookUpPurCategory.ItemIndex = 0;
                comboBoxReqState.SelectedIndex = 0;
                lookUpApplicant.Properties.DataSource = prReqDAO.QueryUserInfo();
                lookUpApplicant.EditValue = SystemInfo.user.EmpName;
                repositoryItemLookUpEdit1.DataSource = prReqDAO.QueryDepartment(false);
                repositoryItemLookUpEdit2.DataSource = prReqDAO.QueryPurCategory(false);

                repositoryItemSearchLookUpEdit1.DataSource = prReqDAO.QueryPartsCode();

                dateReqDateBegin.DateTime = DateTime.Now.Date.AddDays(-7);
                dateReqDateEnd.DateTime = DateTime.Now.Date;

                prReqDAO.QueryPrReqHead(dataSet_PrReq.Tables[0], dateReqDateBegin.DateTime, dateReqDateEnd.DateTime, "", "", 0, "", true);

            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
            }
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
                dataSet_PrReq.Tables[0].Clear();
                dataSet_PrReq.Tables[1].Clear();
                prReqDAO.QueryPrReqHead(dataSet_PrReq.Tables[0], dateReqDateBegin.DateTime, dateReqDateEnd.DateTime, reqDepStr, purCategoryStr, reqStateInt, empNameStr, false);

                SetButtonAndColumnState(false);
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
                    if (headFocusedLineNo < gridViewPrReqHead.DataRowCount && gridViewPrReqHead.FocusedRowHandle != headFocusedLineNo && gridViewPrReqHead.GetDataRow(headFocusedLineNo).RowState != DataRowState.Unchanged)
                    {
                        MessageHandler.ShowMessageBox("当前请购单已经修改，请保存后再进行换行。");
                        gridViewPrReqHead.FocusedRowHandle = headFocusedLineNo;
                    }
                    else
                    {
                        if (gridViewPrReqHead.FocusedRowHandle != headFocusedLineNo) btnCancel_Click(null, null);
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
        private void repositoryItemSearchLookUpEdit1View_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
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
                    SetButtonAndColumnState(true);
                    FocusedHeadView("ReqDate");
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

                    prReqDAO.SavePrReq(gridViewPrReqHead.GetFocusedDataRow(), dataSet_PrReq.Tables[1]);

                    SetButtonAndColumnState(false);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--保存按钮事件错误。", ex);
            }
        }

        /// <summary>
        /// 删除按钮事件
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckReqState())
                    return;

                if (MessageHandler.ShowMessageBox_YesNo("确定要删除吗？") != DialogResult.Yes)
                {
                    return;
                }
                prReqDAO.DeletePrReq(DataTypeConvert.GetString(gridViewPrReqHead.GetFocusedDataRow()["PrReqNo"]));
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
                if (!CheckReqState())
                    return;

                prReqDAO.ApprovePrReq(gridViewPrReqHead.GetFocusedDataRow());
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--审批按钮事件错误。", ex);
            }
        }

        /// <summary>
        /// 主表设定默认值
        /// </summary>
        private void gridViewPrReqHead_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            try
            {
                gridViewPrReqHead.SetFocusedRowCellValue("ReqDate", DateTime.Now);
                //gridViewPrReqHead.SetFocusedRowCellValue("ReqDep", DataTypeConvert.GetString(((DataTable) lookUpReqDep.Properties.DataSource).Rows[1]["DepartmentNo"]));
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
        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
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
        /// 子表单元格值变化进行的操作
        /// </summary>
        private void gridViewPrReqList_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "CodeFileName")
                {
                    string tmpStr = DataTypeConvert.GetString(gridViewPrReqList.GetDataRow(e.RowHandle)["CodeFileName"]);
                    if (tmpStr == "")
                        gridViewPrReqList.SetRowCellValue(e.RowHandle, "CodeName", "");
                    else
                    {
                        DataTable temp = (DataTable)repositoryItemSearchLookUpEdit1.DataSource;
                        DataRow[] drs = temp.Select(string.Format("CodeFileName='{0}'", tmpStr));
                        if (drs.Length > 0)
                        {
                            gridViewPrReqList.SetRowCellValue(e.RowHandle, "CodeName", DataTypeConvert.GetString(drs[0]["CodeName"]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--子表单元格值变化进行的操作错误。", ex);
            }
        }

        /// <summary>
        /// 检查是否有未填写字段
        /// </summary>
        /// <returns></returns>
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
        /// <param name="ret"></param>
        private void SetButtonAndColumnState(bool ret)
        {
            if (ret)
            {
                btnNew.Enabled = false;
                btnSave.Text = "保存";
                btnCancel.Enabled = true;
                btnDelete.Enabled = false;
                btnApprove.Enabled = false;
            }
            else
            {
                btnNew.Enabled = true;
                btnSave.Text = "修改";
                btnCancel.Enabled = false;
                btnDelete.Enabled = true;
                btnApprove.Enabled = true;
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

            repositoryItemButtonEdit1.Buttons[0].Enabled = ret;
        }

        /// <summary>
        /// 检测请购单状态
        /// </summary>
        /// <returns></returns>
        private bool CheckReqState()
        {
            int reqState = DataTypeConvert.GetInt(gridViewPrReqHead.GetFocusedDataRow()["ReqState"]);
            switch (reqState)
            {
                case 2:
                    MessageHandler.ShowMessageBox("采购请购单已经审核，不可以操作。");
                    return false;
                case 3:
                    MessageHandler.ShowMessageBox("采购请购单已经关闭，不可以操作。");
                    return false;
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


    }
}
