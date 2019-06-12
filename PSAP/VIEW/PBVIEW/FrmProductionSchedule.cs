using DevExpress.XtraGrid.Views.Base;
using PSAP.DAO.BSDAO;
using PSAP.DAO.PBDAO;
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
    public partial class FrmProductionSchedule : DockContent
    {
        #region 私有变量

        FrmCommonDAO commonDAO = new FrmCommonDAO();
        FrmProductionScheduleDAO psDAO = new FrmProductionScheduleDAO();

        /// <summary>
        /// 主表聚焦的行号
        /// </summary>
        int headFocusedLineNo = 0;

        /// <summary>
        /// 查询的生产计划单号
        /// </summary>
        public static string queryPsNo = "";

        ///// <summary>
        ///// 查询的明细AutoId
        ///// </summary>
        //public static int queryListAutoId = 0;

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

        public FrmProductionSchedule()
        {
            InitializeComponent();
        }

        #endregion

        #region 窗体事件

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmProductionSchedule_Load(object sender, EventArgs e)
        {
            try
            {
                ControlHandler.DevExpressStyle_ChangeControlLocation(checkAll.LookAndFeel.ActiveSkinName, new List<Control> { checkAll });

                DateTime nowDate = BaseSQL.GetServerDateTime();
                dateCurrentDateBegin.DateTime = nowDate.Date.AddDays(-SystemInfo.OrderQueryDate_DefaultDays);
                dateCurrentDateEnd.DateTime = nowDate.Date;
                datePlanDateBegin.DateTime = nowDate.Date;
                datePlanDateEnd.DateTime = nowDate.Date.AddDays(SystemInfo.OrderQueryDate_DefaultDays);
                checkPlanDate.Checked = false;

                searchLookUpCodeFileName.Properties.DataSource = commonDAO.QueryPartsCode(true);
                searchLookUpCodeFileName.Text = "全部";
                lookUpPrepared.Properties.DataSource = commonDAO.QueryUserInfo(true);
                lookUpPrepared.EditValue = SystemInfo.user.EmpName;
                comboBoxReqState.SelectedIndex = 0;

                repSearchCodeFileName.DataSource = commonDAO.QueryPartsCode(false);

                if (textCommon.Text == "")
                {
                    psDAO.QueryProductionSchedule(dataSet_PSchedule.Tables[0], "", "", "", "", "", 0, "", -1, "", true);
                    psDAO.QueryProductionScheduleBom(dataSet_PSchedule.Tables[1], "", true);
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
        private void FrmProductionSchedule_Activated(object sender, EventArgs e)
        {
            try
            {
                if (queryPsNo != "")
                {
                    textCommon.Text = queryPsNo;
                    queryPsNo = "";
                    comboBoxReqState.SelectedIndex = 0;
                    lookUpPrepared.ItemIndex = 0;
                    checkPlanDate.Checked = false;

                    dataSet_PSchedule.Tables[0].Clear();
                    headFocusedLineNo = 0;
                    psDAO.QueryProductionSchedule(dataSet_PSchedule.Tables[0], "", "", "", "", "", 0, "", -1, textCommon.Text, false);
                    SetButtonAndColumnState(false);

                    if (dataSet_PSchedule.Tables[0].Rows.Count > 0)
                    {
                        dateCurrentDateBegin.DateTime = DataTypeConvert.GetDateTime(dataSet_PSchedule.Tables[0].Rows[0]["CurrentDate"]).Date;
                        dateCurrentDateEnd.DateTime = dateCurrentDateBegin.DateTime.AddDays(7);
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
        private void FrmProductionSchedule_Shown(object sender, EventArgs e)
        {
            pnlMiddle.Height = (this.Height - pnltop.Height) / 2;
            //pnlLeftMiddle.Height = gridControlOrderHead.Height - 17;

            //dockPnlLeft.Width = SystemInfo.DragForm_LeftDock_Width;
        }

        #endregion

        /// <summary>
        /// 查询按钮事件
        /// </summary>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                if (dateCurrentDateBegin.EditValue == null || dateCurrentDateEnd.EditValue == null)
                {
                    MessageHandler.ShowMessageBox("单据日期不能为空，请设置后重新进行查询。");
                    if (dateCurrentDateBegin.EditValue == null)
                        dateCurrentDateBegin.Focus();
                    else
                        dateCurrentDateEnd.Focus();
                    return;
                }
                string orderDateBeginStr = dateCurrentDateBegin.DateTime.ToString("yyyy-MM-dd");
                string orderDateEndStr = dateCurrentDateEnd.DateTime.AddDays(1).ToString("yyyy-MM-dd");
                string planDateBeginStr = "";
                string planDateEndStr = "";
                if (checkPlanDate.Checked)
                {
                    if (datePlanDateBegin.EditValue == null || datePlanDateEnd.EditValue == null)
                    {
                        MessageHandler.ShowMessageBox("计划日期不能为空，请设置后重新进行查询。");
                        if (datePlanDateBegin.EditValue == null)
                            datePlanDateBegin.Focus();
                        else
                            datePlanDateEnd.Focus();
                        return;
                    }
                    planDateBeginStr = datePlanDateBegin.DateTime.ToString("yyyy-MM-dd");
                    planDateEndStr = datePlanDateEnd.DateTime.AddDays(1).ToString("yyyy-MM-dd");
                }

                string codeFileNameStr = searchLookUpCodeFileName.Text != "全部" ? DataTypeConvert.GetString(searchLookUpCodeFileName.EditValue) : "";
                int reqStateInt = CommonHandler.Get_OrderState_No(comboBoxReqState.Text);
                string empNameStr = lookUpPrepared.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpPrepared.EditValue) : "";
                int approverInt = -1;

                string commonStr = textCommon.Text.Trim();
                dataSet_PSchedule.Tables[0].Clear();
                dataSet_PSchedule.Tables[1].Clear();
                headFocusedLineNo = 0;
                psDAO.QueryProductionSchedule(dataSet_PSchedule.Tables[0], orderDateBeginStr, orderDateEndStr, planDateBeginStr, planDateEndStr, codeFileNameStr, reqStateInt, empNameStr, approverInt, commonStr, false);

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
        private void gridViewPSchedule_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (gridViewPSchedule.GetFocusedDataRow() != null)
                {
                    if (onlySelectColChangeRowState)
                    {
                        dataSet_PSchedule.Tables[0].AcceptChanges();
                        onlySelectColChangeRowState = false;
                    }
                    else
                    {
                        if (headFocusedLineNo < gridViewPSchedule.DataRowCount && gridViewPSchedule.FocusedRowHandle != headFocusedLineNo && gridViewPSchedule.GetDataRow(headFocusedLineNo).RowState != DataRowState.Unchanged)
                        {
                            MessageHandler.ShowMessageBox("当前生产计划单已经修改，请保存后再进行换行。");
                            gridViewPSchedule.FocusedRowHandle = headFocusedLineNo;
                        }
                        else if (headFocusedLineNo == gridViewPSchedule.DataRowCount)
                        {

                        }
                        else
                        {
                            if (gridViewPSchedule.FocusedRowHandle != headFocusedLineNo && gridViewPSchedule.GetDataRow(headFocusedLineNo).RowState != DataRowState.Unchanged)
                                btnCancel_Click(null, null);
                            else if (gridViewPSchedule.GetDataRow(headFocusedLineNo).RowState == DataRowState.Unchanged)
                                btnCancel_Click(null, null);
                        }
                    }

                    if (DataTypeConvert.GetString(gridViewPSchedule.GetFocusedDataRow()["PsNo"]) != "")
                    {
                        dataSet_PSchedule.Tables[1].Clear();
                        psDAO.QueryProductionScheduleBom(dataSet_PSchedule.Tables[1], DataTypeConvert.GetString(gridViewPSchedule.GetFocusedDataRow()["PsNo"]), false);
                        //if (queryListAutoId > 0)
                        //{
                        //    for (int i = 0; i < gridViewPScheduleBOM.DataRowCount; i++)
                        //    {
                        //        if (DataTypeConvert.GetInt(gridViewPScheduleBOM.GetDataRow(i)["AutoId"]) == queryListAutoId)
                        //        {
                        //            gridViewPScheduleBOM.FocusedRowHandle = i;
                        //            queryListAutoId = 0;
                        //            break;
                        //        }
                        //    }
                        //}
                    }

                    if (gridViewPSchedule.FocusedRowHandle >= 0)
                    {
                        headFocusedLineNo = gridViewPSchedule.FocusedRowHandle;
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
        private void gridViewPSchedule_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            ControlHandler.GridView_CustomDrawRowIndicator(e);
        }

        /// <summary>
        /// 获取单元格显示的信息
        /// </summary>
        private void gridViewPSchedule_KeyDown(object sender, KeyEventArgs e)
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
        /// 设定列表显示信息
        /// </summary>
        private void gridViewPSchedule_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "PsState")
            {
                e.DisplayText = CommonHandler.Get_OrderState_Desc(e.Value.ToString());
            }
        }

        /// <summary>
        /// 主表单元格值变化进行的操作
        /// </summary>
        private void gridViewPSchedule_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                switch (e.Column.FieldName)
                {
                    case "CodeFileName":
                        string tmpStr = DataTypeConvert.GetString(gridViewPSchedule.GetDataRow(e.RowHandle)["CodeFileName"]);
                        if (tmpStr == "")
                            gridViewPSchedule.SetRowCellValue(e.RowHandle, "CodeName", "");
                        else
                        {
                            DataTable temp = (DataTable)repSearchCodeFileName.DataSource;
                            DataRow[] drs = temp.Select(string.Format("CodeFileName='{0}'", tmpStr));
                            if (drs.Length > 0)
                            {
                                gridViewPSchedule.SetRowCellValue(e.RowHandle, "CodeName", DataTypeConvert.GetString(drs[0]["CodeName"]));
                            }
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--主表单元格值变化进行的操作错误。", ex);
            }
        }

        /// <summary>
        /// 选择计划到货日期
        /// </summary>
        private void checkPlanDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPlanDate.Checked)
            {
                datePlanDateBegin.Enabled = true;
                datePlanDateEnd.Enabled = true;
            }
            else
            {
                datePlanDateBegin.Enabled = false;
                datePlanDateEnd.Enabled = false;
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
                gridViewPSchedule.AddNewRow();
                FocusedHeadView("CodeFileName");

                dataSet_PSchedule.Tables[1].Clear();
                //gridViewPScheduleBOM.AddNewRow();
                //FocusedListView(false, "CodeFileName", gridViewPScheduleBOM.GetFocusedDataSourceRowIndex());
                //gridViewPScheduleBOM.RefreshData();

                SetButtonAndColumnState(true);
                headFocusedLineNo = gridViewPSchedule.DataRowCount;
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
                if (gridViewPSchedule.GetFocusedDataRow() == null)
                    return;

                if (!CheckReqState())
                    return;

                if (btnSave.Text != "保存")
                {
                    ClearHeadGridAllSelect();

                    SetButtonAndColumnState(true);
                    FocusedHeadView("CodeFileName");
                }
                else
                {
                    DataRow headRow = gridViewPSchedule.GetFocusedDataRow();
                    if (DataTypeConvert.GetString(headRow["CodeFileName"]) == "")
                    {
                        MessageHandler.ShowMessageBox("零件编号不能为空，请填写后再进行保存。");
                        FocusedHeadView("CodeFileName");
                        return;
                    }
                    if (DataTypeConvert.GetString(headRow["PlannedQty"]) == "")
                    {
                        MessageHandler.ShowMessageBox("数量不能为空，请填写后再进行保存。");
                        FocusedHeadView("PlannedQty");
                        return;
                    }
                    if (DataTypeConvert.GetString(headRow["PlannedStarttime"]) == "")
                    {
                        MessageHandler.ShowMessageBox("计划开始日期不能为空，请填写后再进行保存。");
                        FocusedHeadView("PlannedStarttime");
                        return;
                    }
                    if (DataTypeConvert.GetString(headRow["PlannedEndtime"]) == "")
                    {
                        MessageHandler.ShowMessageBox("计划完成日期不能为空，请填写后再进行保存。");
                        FocusedHeadView("PlannedEndtime");
                        return;
                    }
                    if (DataTypeConvert.GetString(headRow["CurrentDate"]) == "")
                    {
                        MessageHandler.ShowMessageBox("单据日期不能为空，请填写后再进行保存。");
                        FocusedHeadView("CurrentDate");
                        return;
                    }

                    for (int i = gridViewPScheduleBOM.DataRowCount - 1; i >= 0; i--)
                    {
                        DataRow listRow = gridViewPScheduleBOM.GetDataRow(i);
                        if (DataTypeConvert.GetString(listRow["CodeFileName"]) == "")
                        {
                            gridViewPScheduleBOM.DeleteRow(i);
                            continue;
                        }
                        if (DataTypeConvert.GetString(listRow["Qty"]) == "")
                        {
                            MessageHandler.ShowMessageBox("需求数量不能为空，请填写后再进行保存。");
                            FocusedListView(true, "Qty", i);
                            return;
                        }
                        if (DataTypeConvert.GetString(listRow["TotalQty"]) == "")
                        {
                            MessageHandler.ShowMessageBox("实际使用数量不能为空，请填写后再进行保存。");
                            FocusedListView(true, "TotalQty", i);
                            return;
                        }
                    }

                    int ret = psDAO.SaveProductionSchedule(gridViewPSchedule.GetFocusedDataRow());
                    switch (ret)
                    {
                        case -1:
                            btnQuery_Click(null, null);
                            break;
                        case 1:
                            //dataSet_Order.Tables[1].Clear();
                            //orderDAO.QueryOrderList(dataSet_Order.Tables[1], DataTypeConvert.GetString(gridViewOrderHead.GetFocusedDataRow()["OrderHeadNo"]), false);
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
                if (gridViewPSchedule.GetDataRow(headFocusedLineNo).RowState != DataRowState.Unchanged)
                {
                    if (DataTypeConvert.GetString(gridViewPSchedule.GetDataRow(headFocusedLineNo)["PsNo"]) == "")
                    {
                        gridViewPSchedule.DeleteRow(headFocusedLineNo);
                    }
                    else
                    {
                        gridViewPSchedule.GetFocusedDataRow().RejectChanges();
                    }
                }

                SetButtonAndColumnState(false);

                dataSet_PSchedule.Tables[1].Clear();
                if (gridViewPSchedule.GetFocusedDataRow() != null)
                    psDAO.QueryProductionScheduleBom(dataSet_PSchedule.Tables[1], DataTypeConvert.GetString(gridViewPSchedule.GetFocusedDataRow()["PsNo"]), false);

                //gridViewPrReqHead_FocusedRowChanged(sender, null);
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
                int count = dataSet_PSchedule.Tables[0].Select("select=1").Length;
                if (count == 0)
                {
                    MessageHandler.ShowMessageBox("请在要操作的记录前面选中。");
                    return;
                }

                if (!CheckReqState_Multi(false, true, true, true))
                    return;

                if (MessageHandler.ShowMessageBox_YesNo(string.Format("确定要删除当前选中的{0}条记录吗？", count)) != DialogResult.Yes)
                {
                    return;
                }
                if (!psDAO.DeleteProductionSchedule_Multi(dataSet_PSchedule.Tables[0]))
                {

                }

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
                int count = dataSet_PSchedule.Tables[0].Select("select=1").Length;
                if (count == 0)
                {
                    MessageHandler.ShowMessageBox("请在要操作的记录前面选中。");
                    return;
                }

                if (!CheckReqState_Multi(false, true, true, false))
                    return;

                if (MessageHandler.ShowMessageBox_YesNo(string.Format("确定要审批当前选中的{0}条记录吗？", count)) != DialogResult.Yes)
                {
                    return;
                }

                int type = SystemInfo.ProductionScheduleBOMType;

                if (type == 3)
                {
                    CustomXtraMessageBoxForm xtraMBForm = new CustomXtraMessageBoxForm();
                    type = xtraMBForm.ShowMessageBox("请选择生产计划单审批生成BOM信息的方式", new string[] { "BOM信息的子节点", "BOM信息的末节点", "取消" });
                    if (type == 2)
                        return;
                }

                if (!psDAO.ApproveProductionSchedule_Multi(dataSet_PSchedule.Tables[0], type + 1))
                    btnQuery_Click(null, null);
                else
                {
                    MessageHandler.ShowMessageBox(string.Format("成功审批了{0}条记录。", count));
                }

                ClearHeadGridAllSelect();

                dataSet_PSchedule.Tables[1].Clear();
                psDAO.QueryProductionScheduleBom(dataSet_PSchedule.Tables[1], DataTypeConvert.GetString(gridViewPSchedule.GetFocusedDataRow()["PsNo"]), false);

                //if (!orderDAO.ApproveOrder_Multi(dataSet_Order.Tables[0]))
                //    btnQuery_Click(null, null);
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
                int count = dataSet_PSchedule.Tables[0].Select("select=1").Length;
                if (count == 0)
                {
                    MessageHandler.ShowMessageBox("请在要操作的记录前面选中。");
                    return;
                }

                if (!CheckReqState_Multi(true, false, true, false))
                    return;

                if (MessageHandler.ShowMessageBox_YesNo(string.Format("确定要取消审批当前选中的{0}条记录吗？", count)) != DialogResult.Yes)
                {
                    return;
                }

                if (!psDAO.CancelApproveProductionSchedule_Multi(dataSet_PSchedule.Tables[0]))
                    btnQuery_Click(null, null);
                else
                {
                    MessageHandler.ShowMessageBox(string.Format("成功取消审批了{0}条记录。", count));
                }
                ClearHeadGridAllSelect();

                dataSet_PSchedule.Tables[1].Clear();
                psDAO.QueryProductionScheduleBom(dataSet_PSchedule.Tables[1], DataTypeConvert.GetString(gridViewPSchedule.GetFocusedDataRow()["PsNo"]), false);
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
                string psNoStr = "";
                if (gridViewPSchedule.GetFocusedDataRow() != null)
                    psNoStr = DataTypeConvert.GetString(gridViewPSchedule.GetFocusedDataRow()["PsNo"]);
                psDAO.PrintHandle(psNoStr, 1);
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
            foreach (DataRow dr in dataSet_PSchedule.Tables[0].Rows)
            {
                dr["Select"] = value;
            }
            onlySelectColChangeRowState = true;
        }

        /// <summary>
        /// 主表设定默认值
        /// </summary>
        private void gridViewPSchedule_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            try
            {
                DateTime nowDate = BaseSQL.GetServerDateTime();
                gridViewPSchedule.SetFocusedRowCellValue("CurrentDate", nowDate);
                gridViewPSchedule.SetFocusedRowCellValue("PlannedQty", 1);
                gridViewPSchedule.SetFocusedRowCellValue("PlannedStarttime", nowDate.Date.AddDays(1));
                gridViewPSchedule.SetFocusedRowCellValue("PlannedEndtime", nowDate.Date.AddDays(31));
                gridViewPSchedule.SetFocusedRowCellValue("PsState", 1);
                gridViewPSchedule.SetFocusedRowCellValue("Prepared", SystemInfo.user.EmpName);

            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--主表设定默认值错误。", ex);
            }
        }

        /// <summary>
        /// 子表设定默认值
        /// </summary>
        private void gridViewPScheduleBOM_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            try
            {
                gridViewPScheduleBOM.SetFocusedRowCellValue("PsNo", DataTypeConvert.GetString(gridViewPSchedule.GetFocusedDataRow()["PsNo"]));
                gridViewPScheduleBOM.SetFocusedRowCellValue("Qty", 1);
                gridViewPScheduleBOM.SetFocusedRowCellValue("TotalQty", 1);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--子表设定默认值错误。", ex);
            }
        }

        /// <summary>
        /// 子表按键事件
        /// </summary>
        private void gridViewPScheduleBOM_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                //if (e.KeyCode == Keys.Enter)
                //{
                //    if (!colRemark.OptionsColumn.AllowEdit)
                //        return;

                //    if (gridViewPScheduleBOM.GetFocusedDataSourceRowIndex() >= gridViewPScheduleBOM.DataRowCount - 1 && gridViewPScheduleBOM.FocusedColumn.Name == "colRemark")
                //    {
                //        ListNewRow();
                //    }
                //    else if (gridViewPScheduleBOM.FocusedColumn.Name == "colRemark")
                //    {
                //        gridViewPScheduleBOM.FocusedRowHandle = gridViewPScheduleBOM.FocusedRowHandle + 1;
                //        FocusedListView(true, "CodeFileName", gridViewPScheduleBOM.GetFocusedDataSourceRowIndex());
                //    }
                //}
                //else
                {
                    ControlHandler.GridView_GetFocusedCellDisplayText_KeyDown(sender, e);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--子表按键事件错误。", ex);
            }
        }

        /// <summary>
        /// 子表单元格值变化进行的操作
        /// </summary>
        private void gridViewPScheduleBOM_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            try
            {
                switch (e.Column.FieldName)
                {
                    case "CodeFileName":
                        string tmpStr = DataTypeConvert.GetString(gridViewPScheduleBOM.GetDataRow(e.RowHandle)["CodeFileName"]);
                        if (tmpStr == "")
                            gridViewPScheduleBOM.SetRowCellValue(e.RowHandle, "CodeName", "");
                        else
                        {
                            DataTable temp = (DataTable)repSearchCodeFileName.DataSource;
                            DataRow[] drs = temp.Select(string.Format("CodeFileName='{0}'", tmpStr));
                            if (drs.Length > 0)
                            {
                                gridViewPScheduleBOM.SetRowCellValue(e.RowHandle, "CodeName", DataTypeConvert.GetString(drs[0]["CodeName"]));
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
        /// 删除子表中的一行
        /// </summary>
        private void repbtnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (gridViewPScheduleBOM.GetFocusedDataRow().RowState != DataRowState.Added)
                {
                    if (MessageHandler.ShowMessageBox_YesNo("确定要删除当前选中的明细记录吗？") != DialogResult.Yes)
                    {
                        return;
                    }
                }
                //int prListAutoIdInt = 0;
                //if (gridViewPScheduleBOM.GetFocusedDataRow() != null)
                //    prListAutoIdInt = DataTypeConvert.GetInt(gridViewPScheduleBOM.GetFocusedDataRow()["PrListAutoId"]);
                gridViewPScheduleBOM.DeleteRow(gridViewPScheduleBOM.FocusedRowHandle);
                //if (prListAutoIdInt > 0)
                //    gridViewPrReqHead_FocusedRowChanged(sender, null);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--删除子表中的一行错误。", ex);
            }
        }

        /// <summary>
        /// 设定当前行选择
        /// </summary>
        private void repCheckSelect_EditValueChanged(object sender, EventArgs e)
        {
            if (DataTypeConvert.GetBoolean(gridViewPSchedule.GetFocusedDataRow()["Select"]))
                gridViewPSchedule.GetFocusedDataRow()["Select"] = false;
            else
                gridViewPSchedule.GetFocusedDataRow()["Select"] = true;
            onlySelectColChangeRowState = true;
        }

        /// <summary>
        /// 检查是否有未填写字段
        /// </summary>
        private bool IsHaveBlankLine()
        {
            gridViewPScheduleBOM.FocusedRowHandle = 0;
            for (int i = 0; i < gridViewPScheduleBOM.DataRowCount; i++)
            {
                if (DataTypeConvert.GetString(gridViewPScheduleBOM.GetDataRow(i)["CodeFileName"]) == "")
                {
                    gridViewPScheduleBOM.Focus();
                    gridViewPScheduleBOM.FocusedColumn = colCodeFileName;
                    gridViewPScheduleBOM.FocusedRowHandle = i;
                    return true;
                }
                if (DataTypeConvert.GetString(gridViewPScheduleBOM.GetDataRow(i)["Qty"]) == "")
                {
                    gridViewPScheduleBOM.Focus();
                    gridViewPScheduleBOM.FocusedColumn = colQty;
                    gridViewPScheduleBOM.FocusedRowHandle = i;
                    return true;
                }
                if (DataTypeConvert.GetString(gridViewPScheduleBOM.GetDataRow(i)["TotalQty"]) == "")
                {
                    gridViewPScheduleBOM.Focus();
                    gridViewPScheduleBOM.FocusedColumn = colTotalQty;
                    gridViewPScheduleBOM.FocusedRowHandle = i;
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
            gridViewPScheduleBOM.AddNewRow();
            FocusedListView(true, "CodeFileName", gridViewPScheduleBOM.GetFocusedDataSourceRowIndex());
            //gridViewPScheduleBOM.RefreshData();
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

            colCodeFileName.OptionsColumn.AllowEdit = ret;
            colPlannedQty.OptionsColumn.AllowEdit = ret;
            colPlannedStarttime.OptionsColumn.AllowEdit = ret;
            colPlannedEndtime.OptionsColumn.AllowEdit = ret;
            colRemark.OptionsColumn.AllowEdit = ret;

            colCodeFileName.OptionsColumn.AllowEdit = ret;
            colQty.OptionsColumn.AllowEdit = ret;
            colTotalQty.OptionsColumn.AllowEdit = ret;

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
        /// 检测生产计划单状态是否可以操作
        /// </summary>
        private bool CheckReqState()
        {
            if (gridViewPSchedule.GetFocusedDataRow() == null)
                return false;
            int reqState = DataTypeConvert.GetInt(gridViewPSchedule.GetFocusedDataRow()["PsState"]);
            switch (reqState)
            {
                case 2:
                    MessageHandler.ShowMessageBox(string.Format("生产计划单[{0}]已经审批，不可以操作。", DataTypeConvert.GetString(gridViewPSchedule.GetFocusedDataRow()["PsNo"]))); 
                    return false;
                case 3:
                    MessageHandler.ShowMessageBox(string.Format("生产计划单[{0}]已经关闭，不可以操作。", DataTypeConvert.GetString(gridViewPSchedule.GetFocusedDataRow()["PsNo"])));
                    return false;
                case 4:
                    MessageHandler.ShowMessageBox(string.Format("生产计划单[{0}]已经审批中，不可以操作。", DataTypeConvert.GetString(gridViewPSchedule.GetFocusedDataRow()["PsNo"])));
                    return false;
            }
            return true;
        }

        /// <summary>
        /// 检测当前选中的生产计划单状态是否可以操作
        /// </summary>
        private bool CheckReqState_Multi(bool checkNoApprover, bool checkApprover, bool checkClosed, bool checkApproverBetween)
        {
            for (int i = 0; i < gridViewPSchedule.DataRowCount; i++)
            {
                if (DataTypeConvert.GetBoolean(gridViewPSchedule.GetDataRow(i)["Select"]))
                {
                    int reqState = DataTypeConvert.GetInt(gridViewPSchedule.GetDataRow(i)["PsState"]);
                    switch (reqState)
                    {
                        case 1:
                            if (checkNoApprover)
                            {
                                MessageHandler.ShowMessageBox(string.Format("生产计划单[{0}]未审批，不可以操作。", DataTypeConvert.GetString(gridViewPSchedule.GetDataRow(i)["PsNo"])));
                                gridViewPSchedule.FocusedRowHandle = i;
                                return false;
                            }
                            break;
                        case 2:
                            if (checkApprover)
                            {
                                MessageHandler.ShowMessageBox(string.Format("生产计划单[{0}]已经审批，不可以操作。", DataTypeConvert.GetString(gridViewPSchedule.GetDataRow(i)["PsNo"])));
                                gridViewPSchedule.FocusedRowHandle = i;
                                return false;
                            }
                            break;
                        case 3:
                            if (checkClosed)
                            {
                                MessageHandler.ShowMessageBox(string.Format("生产计划单[{0}]已经关闭，不可以操作。", DataTypeConvert.GetString(gridViewPSchedule.GetDataRow(i)["PsNo"])));
                                gridViewPSchedule.FocusedRowHandle = i;
                                return false;
                            }
                            break;
                        case 4:
                            if (checkApproverBetween)
                            {
                                MessageHandler.ShowMessageBox(string.Format("生产计划单[{0}]已经审批中，不可以操作。", DataTypeConvert.GetString(gridViewPSchedule.GetDataRow(i)["PsNo"])));
                                gridViewPSchedule.FocusedRowHandle = i;
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
            gridControlPSchedule.Focus();
            ColumnView headView = (ColumnView)gridControlPSchedule.FocusedView;
            headView.FocusedColumn = headView.Columns[colName];
            gridViewPSchedule.FocusedRowHandle = headView.FocusedRowHandle;
        }

        /// <summary>
        /// 聚焦子表当前行的列
        /// </summary>
        private void FocusedListView(bool isFocusedControl, string colName, int lineNo)
        {
            if (isFocusedControl)
                gridControlPScheduleBOM.Focus();
            ColumnView listView = (ColumnView)gridControlPScheduleBOM.FocusedView;
            listView.FocusedColumn = listView.Columns[colName];
            gridViewPScheduleBOM.FocusedRowHandle = lineNo;
        }

        /// <summary>
        /// 清楚当前的所有选择
        /// </summary>
        private void ClearHeadGridAllSelect()
        {
            checkAll.Checked = false;
            for (int i = 0; i < dataSet_PSchedule.Tables[0].Rows.Count; i++)
            {
                dataSet_PSchedule.Tables[0].Rows[i]["Select"] = false;
            }
            dataSet_PSchedule.Tables[0].AcceptChanges();
            onlySelectColChangeRowState = false;
        }


    }
}
