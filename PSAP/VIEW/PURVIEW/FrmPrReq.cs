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
                // TODO: 这行代码将数据加载到表“dS_PUR.PUR_PurCategory”中。您可以根据需要移动或删除它。
                this.pUR_PurCategoryTableAdapter.Fill(this.dS_PUR.PUR_PurCategory);
                // TODO: 这行代码将数据加载到表“dsPSAP.BS_Department”中。您可以根据需要移动或删除它。
                this.bS_DepartmentTableAdapter.Fill(this.dsPSAP.BS_Department);

                lookUpReqDep.Properties.DataSource = prReqDAO.QueryDepartment();
                lookUpReqDep.ItemIndex = 0;
                lookUpPurCategory.Properties.DataSource = prReqDAO.QueryPurCategory();
                lookUpPurCategory.ItemIndex = 0;

                dateReqDateBegin.DateTime = DateTime.Now.Date.AddDays(-7);
                dateReqDateEnd.DateTime = DateTime.Now.Date;

                prReqDAO.QueryPrReqHead(dataSet_PrReq.Tables[0], dateReqDateBegin.DateTime, dateReqDateEnd.DateTime, "", "", true);
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
                dataSet_PrReq.Tables[0].Clear();
                dataSet_PrReq.Tables[1].Clear();
                prReqDAO.QueryPrReqHead(dataSet_PrReq.Tables[0], dateReqDateBegin.DateTime, dateReqDateEnd.DateTime, reqDepStr, purCategoryStr, false);

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
                FocusedListView("CodeFileName");

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
        /// 主表设定默认值
        /// </summary>
        private void gridViewPrReqHead_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            try
            {
                gridViewPrReqHead.SetFocusedRowCellValue("ReqDate", DateTime.Now);
                gridViewPrReqHead.SetFocusedRowCellValue("ReqDep", DataTypeConvert.GetString(dsPSAP.BS_Department.Rows[0]["DepartmentNo"]));
                gridViewPrReqHead.SetFocusedRowCellValue("PurCategory", DataTypeConvert.GetString(dS_PUR.PUR_PurCategory.Rows[0]["PurCategory"]));
                gridViewPrReqHead.SetFocusedRowCellValue("ReqState", 1);
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
                    if (gridViewPrReqList.GetFocusedDataSourceRowIndex() >= gridViewPrReqList.DataRowCount - 1 && gridViewPrReqList.FocusedColumn.Name == "colPrReqListRemark")
                    {
                        if (IsHaveBlankLine())
                            return;

                        //gridViewPrReqList.PostEditor();
                        gridViewPrReqList.AddNewRow();
                        FocusedListView("CodeFileName");
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--子表按键事件错误。", ex);
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
            }
            else
            {
                btnNew.Enabled = true;
                btnSave.Text = "修改";
                btnCancel.Enabled = false;
                btnDelete.Enabled = true;
            }

            colReqDate.OptionsColumn.AllowEdit = ret;
            colReqDep.OptionsColumn.AllowEdit = ret;
            colProjectNo.OptionsColumn.AllowEdit = ret;
            colStnNo.OptionsColumn.AllowEdit = ret;
            colPurCategory.OptionsColumn.AllowEdit = ret;

            colCodeFileName.OptionsColumn.AllowEdit = ret;
            colQty.OptionsColumn.AllowEdit = ret;
            colRequirementDate.OptionsColumn.AllowEdit = ret;
            colPrReqListRemark.OptionsColumn.AllowEdit = ret;
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
                    MessageHandler.ShowMessageBox("采购请购单已经审核，不可以修改。");
                    return false;
                case 3:
                    MessageHandler.ShowMessageBox("采购请购单已经关闭，不可以修改。");
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
        private void FocusedListView(string colName)
        {
            ColumnView listView = (ColumnView)gridControlPrReqList.FocusedView;
            listView.FocusedColumn = listView.Columns[colName];
            gridViewPrReqList.FocusedRowHandle = listView.FocusedRowHandle;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(new SystemHandler().GetIpAddress());
        }
    }
}
