﻿using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using PSAP.DAO.PURDAO;
using PSAP.DAO.BSDAO;
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
    public partial class FrmOrder_Drag : DockContent
    {
        #region 私有变量

        FrmOrderDAO orderDAO = new FrmOrderDAO();
        FrmCommonDAO commonDAO = new FrmCommonDAO();
        FrmPrReqApplyDAO applyDAO = new FrmPrReqApplyDAO();

        /// <summary>
        /// 主表聚焦的行号
        /// </summary>
        int headFocusedLineNo = 0;

        /// <summary>
        /// 查询的采购单号
        /// </summary>
        public static string queryOrderHeadNo = "";

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

        static PSAP.VIEW.BSVIEW.FrmLanguageText f = new VIEW.BSVIEW.FrmLanguageText();

        #endregion

        #region 构造方法

        public FrmOrder_Drag()
        {
            InitializeComponent();
            PSAP.BLL.BSBLL.BSBLL.language(f);
            PSAP.BLL.BSBLL.BSBLL.language(this);
        }

        #endregion

        #region 窗体事件

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmOrder_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime nowDate = BaseSQL.GetServerDateTime();
                dateOrderDateBegin.DateTime = nowDate.Date.AddDays(-SystemInfo.OrderQueryDate_DefaultDays);
                dateOrderDateEnd.DateTime = nowDate.Date;
                datePlanDateBegin.DateTime = nowDate.Date;
                datePlanDateEnd.DateTime = nowDate.Date.AddDays(SystemInfo.OrderQueryDate_DefaultDays);
                checkPlanDate.Checked = false;

                lookUpReqDep.Properties.DataSource = commonDAO.QueryDepartment(true);
                lookUpReqDep.ItemIndex = 0;
                lookUpPurCategory.Properties.DataSource = commonDAO.QueryPurCategory(true);
                lookUpPurCategory.ItemIndex = 0;
                comboBoxReqState.SelectedIndex = 0;
                lookUpPrepared.Properties.DataSource = commonDAO.QueryUserInfo(true);
                lookUpPrepared.EditValue = SystemInfo.user.EmpName;
                searchLookUpBussinessBaseNo.Properties.DataSource = commonDAO.QueryBussinessBaseInfo(true);
                searchLookUpBussinessBaseNo.Text = "全部";
                lookUpApprover.Properties.DataSource = commonDAO.QueryUserInfo(true);
                lookUpApprover.ItemIndex = -1;

                repLookUpReqDep.DataSource = commonDAO.QueryDepartment(false);
                repLookUpPurCategory.DataSource = commonDAO.QueryPurCategory(false);
                repSearchProjectNo.DataSource = commonDAO.QueryProjectList(false);
                repSearchBussinessBaseNo.DataSource = commonDAO.QueryBussinessBaseInfo(false);
                repLookUpApprovalType.DataSource = commonDAO.QueryApprovalType(false);
                repLookUpPayTypeNo.DataSource = commonDAO.QueryPayType(false);

                repSearchCodeFileName.DataSource = commonDAO.QueryPartsCode(false);

                dateReqDateBegin.DateTime = dateOrderDateBegin.DateTime;
                dateReqDateEnd.DateTime = dateOrderDateEnd.DateTime;
                searchLookUpProjectNo.Properties.DataSource = commonDAO.QueryProjectList(true);
                searchLookUpProjectNo.Text = "全部";

                repLookUpPrReqReqDep.DataSource = commonDAO.QueryDepartment(false);
                repLookUpPrReqPurCategory.DataSource = commonDAO.QueryPurCategory(false);
                repSearchPrReqProjectNo.DataSource = commonDAO.QueryProjectList(false);

                if (textCommon.Text == "")
                {
                    orderDAO.QueryOrderHead(dataSet_Order.Tables[0], "", "", "", "", "", "", "", 0, "", -1, "", true);
                    orderDAO.QueryOrderList(dataSet_Order.Tables[1], "", true);
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiCtjzsjcw.Text, ex);
            }
        }

        /// <summary>
        /// 窗体激活事件
        /// </summary>
        private void FrmOrder_Activated(object sender, EventArgs e)
        {
            try
            {
                if (queryOrderHeadNo != "")
                {
                    textCommon.Text = queryOrderHeadNo;
                    queryOrderHeadNo = "";
                    lookUpReqDep.ItemIndex = 0;
                    lookUpPurCategory.ItemIndex = 0;
                    searchLookUpBussinessBaseNo.Text = "全部";
                    comboBoxReqState.SelectedIndex = 0;
                    lookUpPrepared.ItemIndex = 0;
                    lookUpApprover.ItemIndex = -1;
                    checkPlanDate.Checked = false;

                    dataSet_Order.Tables[0].Clear();
                    headFocusedLineNo = 0;
                    orderDAO.QueryOrderHead(dataSet_Order.Tables[0], "", "", "", "", "", "", "", 0, "", -1, textCommon.Text, false);
                    SetButtonAndColumnState(false);

                    if (dataSet_Order.Tables[0].Rows.Count > 0)
                    {
                        dateOrderDateBegin.DateTime = DataTypeConvert.GetDateTime(dataSet_Order.Tables[0].Rows[0]["OrderHeadDate"]).Date;
                        dateOrderDateEnd.DateTime = dateOrderDateBegin.DateTime.AddDays(7);
                    }
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--窗体激活事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiCtjhsjcw.Text, ex);
            }
        }

        /// <summary>
        /// 窗体显示事件
        /// </summary>
        private void FrmOrder_Shown(object sender, EventArgs e)
        {
            pnlMiddle.Height = (this.Height - pnltop.Height) / 2;
            pnlLeftMiddle.Height = gridControlOrderHead.Height + 2;

            dockPnlLeft.Width = SystemInfo.DragForm_LeftDock_Width;
        }

        #endregion

        #region 右侧采购订单模块的相关事件和方法

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
                if (dateOrderDateBegin.EditValue == null || dateOrderDateEnd.EditValue == null)
                {
                    MessageHandler.ShowMessageBox(tsmiDgrqbnwk.Text);// ("订购日期不能为空，请设置后重新进行查询。");
                    if (dateOrderDateBegin.EditValue == null)
                        dateOrderDateBegin.Focus();
                    else
                        dateOrderDateEnd.Focus();
                    return;
                }
                string orderDateBeginStr = dateOrderDateBegin.DateTime.ToString("yyyy-MM-dd");
                string orderDateEndStr = dateOrderDateEnd.DateTime.AddDays(1).ToString("yyyy-MM-dd");
                string planDateBeginStr = "";
                string planDateEndStr = "";
                if (checkPlanDate.Checked)
                {
                    if (datePlanDateBegin.EditValue == null || datePlanDateEnd.EditValue == null)
                    {
                        MessageHandler.ShowMessageBox(tsmiJhdhribnwk.Text);// ("计划到货日期不能为空，请设置后重新进行查询。");
                        if (datePlanDateBegin.EditValue == null)
                            datePlanDateBegin.Focus();
                        else
                            datePlanDateEnd.Focus();
                        return;
                    }
                    planDateBeginStr = datePlanDateBegin.DateTime.ToString("yyyy-MM-dd");
                    planDateEndStr = datePlanDateEnd.DateTime.AddDays(1).ToString("yyyy-MM-dd");
                }

                string reqDepStr = lookUpReqDep.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpReqDep.EditValue) : "";
                string purCategoryStr = lookUpPurCategory.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpPurCategory.EditValue) : "";
                string bussinessBaseNoStr = DataTypeConvert.GetString(searchLookUpBussinessBaseNo.EditValue) != "全部" ? DataTypeConvert.GetString(searchLookUpBussinessBaseNo.EditValue) : "";
                int reqStateInt = CommonHandler.Get_OrderState_No(comboBoxReqState.Text); 
                string empNameStr = lookUpPrepared.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpPrepared.EditValue) : "";
                int approverInt = -1;
                if (lookUpApprover.ItemIndex == 0)
                    approverInt = 0;
                else if (lookUpApprover.ItemIndex > 0)
                    approverInt = DataTypeConvert.GetInt(lookUpApprover.EditValue);
                string commonStr = textCommon.Text.Trim();
                dataSet_Order.Tables[0].Clear();
                dataSet_Order.Tables[1].Clear();
                headFocusedLineNo = 0;
                orderDAO.QueryOrderHead(dataSet_Order.Tables[0], orderDateBeginStr, orderDateEndStr, planDateBeginStr, planDateEndStr, reqDepStr, purCategoryStr, bussinessBaseNoStr, reqStateInt, empNameStr, approverInt, commonStr, false);

                SetButtonAndColumnState(false);
                checkAll.Checked = false;
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--查询按钮事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiCxansjcw.Text, ex);
            }
        }

        /// <summary>
        /// 主表聚焦行改变事件
        /// </summary>
        private void gridViewOrderHead_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            try
            {
                if (gridViewOrderHead.GetFocusedDataRow() != null)
                {
                    if (onlySelectColChangeRowState)
                    {
                        dataSet_Order.Tables[0].AcceptChanges();
                        onlySelectColChangeRowState = false;
                    }
                    else
                    {
                        if (headFocusedLineNo < gridViewOrderHead.DataRowCount && gridViewOrderHead.FocusedRowHandle != headFocusedLineNo && gridViewOrderHead.GetDataRow(headFocusedLineNo).RowState != DataRowState.Unchanged)
                        {
                            MessageHandler.ShowMessageBox(tsmiDqcgdyjxg.Text);// ("当前采购单已经修改，请保存后再进行换行。");
                            gridViewOrderHead.FocusedRowHandle = headFocusedLineNo;
                        }
                        else if (headFocusedLineNo == gridViewOrderHead.DataRowCount)
                        {

                        }
                        else
                        {
                            if (gridViewOrderHead.FocusedRowHandle != headFocusedLineNo && gridViewOrderHead.GetDataRow(headFocusedLineNo).RowState != DataRowState.Unchanged)
                                btnCancel_Click(null, null);
                            else if (gridViewOrderHead.GetDataRow(headFocusedLineNo).RowState == DataRowState.Unchanged)
                                btnCancel_Click(null, null);
                        }
                    }

                    if (DataTypeConvert.GetString(gridViewOrderHead.GetFocusedDataRow()["OrderHeadNo"]) != "")
                    {
                        dataSet_Order.Tables[1].Clear();
                        orderDAO.QueryOrderList(dataSet_Order.Tables[1], DataTypeConvert.GetString(gridViewOrderHead.GetFocusedDataRow()["OrderHeadNo"]), false);
                        if (queryListAutoId > 0)
                        {
                            for (int i = 0; i < gridViewOrderList.DataRowCount; i++)
                            {
                                if (DataTypeConvert.GetInt(gridViewOrderList.GetDataRow(i)["AutoId"]) == queryListAutoId)
                                {
                                    gridViewOrderList.FocusedRowHandle = i;
                                    queryListAutoId = 0;
                                    break;
                                }
                            }
                        }
                    }

                    if (gridViewOrderHead.FocusedRowHandle >= 0)
                    {
                        headFocusedLineNo = gridViewOrderHead.FocusedRowHandle;
                    }
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--主表聚焦行改变事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiZbjjhgb.Text, ex);
            }
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewOrderHead_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewOrderList_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
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
        private void gridViewOrderHead_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "ReqState")
            {
                e.DisplayText = CommonHandler.Get_OrderState_Desc(e.Value.ToString());
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
                gridViewOrderHead.AddNewRow();
                FocusedHeadView("PurCategory");

                dataSet_Order.Tables[1].Clear();
                gridViewOrderList.AddNewRow();
                FocusedListView(false, "CodeFileName", gridViewOrderList.GetFocusedDataSourceRowIndex());
                gridViewOrderList.RefreshData();

                SetButtonAndColumnState(true);
                headFocusedLineNo = gridViewOrderHead.DataRowCount;
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--新增按钮事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiXzansj.Text, ex);
            }
        }

        /// <summary>
        /// 保存按钮事件
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridViewOrderHead.GetFocusedDataRow() == null)
                    return;

                if (!CheckReqState())
                    return;

                if (btnSave.Tag.ToString() != "保存")
                {
                    ClearHeadGridAllSelect();

                    SetButtonAndColumnState(true);
                    FocusedHeadView("PurCategory");
                    BingStnListComboBox();
                }
                else
                {
                    DataRow headRow = gridViewOrderHead.GetFocusedDataRow();
                    if (DataTypeConvert.GetString(headRow["PurCategory"]) == "")
                    {
                        MessageHandler.ShowMessageBox(tsmiCglxbnwkbc.Text);// ("采购类型不能为空，请填写后再进行保存。");
                        FocusedHeadView("PurCategory");
                        return;
                    }
                    if (DataTypeConvert.GetString(headRow["BussinessBaseNo"]) == "")
                    {
                        MessageHandler.ShowMessageBox(tsmiWlfbnwk.Text);// ("往来方不能为空，请填写后再进行保存。");
                        FocusedHeadView("BussinessBaseNo");
                        return;
                    }
                    if (DataTypeConvert.GetString(headRow["ReqDep"]) == "")
                    {
                        MessageHandler.ShowMessageBox(tsmiSqbmbnwkbc.Text);// ("申请部门不能为空，请填写后再进行保存。");
                        FocusedHeadView("ReqDep");
                        return;
                    }
                    if (DataTypeConvert.GetString(headRow["ProjectNo"]) == "")
                    {
                        MessageHandler.ShowMessageBox(tsmiXmhbnwkbc.Text);// ("项目号不能为空，请填写后再进行保存。");
                        FocusedHeadView("ProjectNo");
                        return;
                    }
                    if (DataTypeConvert.GetString(headRow["StnNo"]) == "")
                    {
                        MessageHandler.ShowMessageBox(tsmiZhbnwkbc.Text);// ("站号不能为空，请填写后再进行保存。");
                        FocusedHeadView("StnNo");
                        return;
                    }
                    if (DataTypeConvert.GetString(headRow["ApprovalType"]) == "")
                    {
                        MessageHandler.ShowMessageBox(tsmiSplx.Text);// ("审批类型不能为空，请填写后再进行保存。");
                        FocusedHeadView("ApprovalType");
                        return;
                    }
                    if (DataTypeConvert.GetString(headRow["PayTypeNo"]) == "")
                    {
                        MessageHandler.ShowMessageBox(tsmiFklxbnwkbc.Text);// ("付款类型不能为空，请填写后再进行保存。");
                        FocusedHeadView("PayTypeNo");
                        return;
                    }
                    if (DataTypeConvert.GetString(headRow["Tax"]) == "")
                    {
                        MessageHandler.ShowMessageBox(tsmiSlbnwk.Text);// ("税率不能为空，请填写后再进行保存。");
                        FocusedHeadView("Tax");
                        return;
                    }

                    if (!commonDAO.StnNoIsContainProjectNo(DataTypeConvert.GetString(headRow["ProjectNo"]), DataTypeConvert.GetString(headRow["StnNo"])))
                    {
                        MessageHandler.ShowMessageBox(tsmiSrdzhbsyxmh.Text);// ("输入的站号不属于项目号，请重新填写后再进行保存。");
                        FocusedHeadView("StnNo");
                        return;
                    }

                    for (int i = gridViewOrderList.DataRowCount - 1; i >= 0; i--)
                    {
                        DataRow listRow = gridViewOrderList.GetDataRow(i);
                        if (DataTypeConvert.GetString(listRow["CodeFileName"]) == "")
                        {
                            gridViewOrderList.DeleteRow(i);
                            continue;
                        }
                        if (DataTypeConvert.GetString(listRow["Qty"]) == "")
                        {
                            MessageHandler.ShowMessageBox(tsmiSlbnwk.Text);// ("数量不能为空，请填写后再进行保存。");
                            FocusedListView(true, "Qty", i);
                            return;
                        }
                        if (DataTypeConvert.GetString(listRow["Unit"]) == "")
                        {
                            MessageHandler.ShowMessageBox(tsmiDjbnwk.Text);// ("单价不能为空，请填写后再进行保存。");
                            FocusedListView(true, "Unit", i);
                            return;
                        }
                    }

                    int ret = orderDAO.SaveOrder(gridViewOrderHead.GetFocusedDataRow(), dataSet_Order.Tables[1]);
                    switch (ret)
                    {
                        case -1:
                            btnQuery_Click(null, null);
                            break;
                        case 1:
                            dataSet_Order.Tables[1].Clear();
                            orderDAO.QueryOrderList(dataSet_Order.Tables[1], DataTypeConvert.GetString(gridViewOrderHead.GetFocusedDataRow()["OrderHeadNo"]), false);
                            break;
                        case 0:
                            return;
                    }

                    SetButtonAndColumnState(false);
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--保存按钮事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiBcan.Text, ex);
            }
        }

        /// <summary>
        /// 取消按钮事件
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridViewOrderHead.GetDataRow(headFocusedLineNo).RowState != DataRowState.Unchanged)
                {
                    if (DataTypeConvert.GetString(gridViewOrderHead.GetDataRow(headFocusedLineNo)["OrderHeadNo"]) == "")
                    {
                        gridViewOrderHead.DeleteRow(headFocusedLineNo);
                    }
                    else
                    {
                        gridViewOrderHead.GetFocusedDataRow().RejectChanges();
                    }
                }

                SetButtonAndColumnState(false);

                dataSet_Order.Tables[1].Clear();
                if (gridViewOrderHead.GetFocusedDataRow() != null)
                    orderDAO.QueryOrderList(dataSet_Order.Tables[1], DataTypeConvert.GetString(gridViewOrderHead.GetFocusedDataRow()["OrderHeadNo"]), false);

                gridViewPrReqHead_FocusedRowChanged(sender, null);
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--取消按钮事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiQxansj.Text, ex);
            }
        }

        /// <summary>
        /// 删除按钮事件
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int count = dataSet_Order.Tables[0].Select("select=1").Length;
                if (count == 0)
                {
                    MessageHandler.ShowMessageBox(tsmiQzycz.Text);// ("请在要操作的记录前面选中。");
                    return;
                }

                if (!CheckReqState_Multi(false, true, true, true))
                    return;

                //if (MessageHandler.ShowMessageBox_YesNo(string.Format("确定要删除当前选中的{0}条记录吗？", count)) != DialogResult.Yes)
                if (MessageHandler.ShowMessageBox_YesNo(string.Format(tsmiQdysc.Text + "{0}" + tsmiTjlm.Text, count)) != DialogResult.Yes)
                {
                    return;
                }
                if (!orderDAO.DeleteOrder_Multi(dataSet_Order.Tables[0]))
                    btnQuery_Click(null, null);

                btnQuery_Click(null, null);
                ClearHeadGridAllSelect();
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--删除按钮事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiScansj.Text, ex);
            }
        }

        /// <summary>
        /// 审批按钮事件
        /// </summary>
        private void btnApprove_Click(object sender, EventArgs e)
        {
            try
            {
                int count = dataSet_Order.Tables[0].Select("select=1").Length;
                if (count == 0)
                {
                    MessageHandler.ShowMessageBox(f.tsmiQzyczdjlq.Text);// ("请在要操作的记录前面选中。");
                    return;
                }

                if (!CheckReqState_Multi(false, true, true, false))
                    return;

                if (count == 1)
                {
                    //弹出审批页面
                    FrmOrderApproval frmOrder = new FrmOrderApproval(DataTypeConvert.GetString(dataSet_Order.Tables[0].Select("select=1")[0]["OrderHeadNo"]));
                    if (frmOrder.ShowDialog() == DialogResult.OK)
                        btnQuery_Click(null, null);
                }
                else
                {
                    //if (MessageHandler.ShowMessageBox_YesNo(string.Format("确定要审批当前选中的{0}条记录吗？", count)) != DialogResult.Yes)
                    if (MessageHandler.ShowMessageBox_YesNo(string.Format(tsmiQdyspd.Text + "{0}" + tsmiTjlm.Text, count)) != DialogResult.Yes)
                    {
                        return;
                    }

                    int successCountInt = 0;
                    //直接审批，不再谈页面
                    if (!orderDAO.OrderApprovalInfo_Multi(dataSet_Order.Tables[0], ref successCountInt))
                        btnQuery_Click(null, null);
                    else
                    {
                        //MessageHandler.ShowMessageBox(string.Format("成功审批了{0}条记录。", successCountInt));
                        MessageHandler.ShowMessageBox(string.Format(tsmiCgspl.Text + "{0}" + tsmiTjl.Text, successCountInt));
                    }

                }

                ClearHeadGridAllSelect();
                //if (!orderDAO.ApproveOrder_Multi(dataSet_Order.Tables[0]))
                //    btnQuery_Click(null, null);
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--审批按钮事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiSpansj.Text, ex);
            }
        }

        /// <summary>
        /// 取消审批按钮事件
        /// </summary>
        private void btnCancelApprove_Click(object sender, EventArgs e)
        {
            try
            {
                int count = dataSet_Order.Tables[0].Select("select=1").Length;
                if (count == 0)
                {
                    MessageHandler.ShowMessageBox(tsmiQzycz.Text);// ("请在要操作的记录前面选中。");
                    return;
                }

                if (!CheckReqState_Multi(true, false, true, false))
                    return;

                //if (MessageHandler.ShowMessageBox_YesNo(string.Format("确定要取消审批当前选中的{0}条记录吗？", count)) != DialogResult.Yes)
                if (MessageHandler.ShowMessageBox_YesNo(string.Format(tsmiQdyqx.Text + "{0}" + tsmiTjl.Text, count)) != DialogResult.Yes)
                {
                    return;
                }

                if (!orderDAO.CancalOrderApprovalInfo_Multi(dataSet_Order.Tables[0]))
                    btnQuery_Click(null, null);
                else
                {
                    //MessageHandler.ShowMessageBox(string.Format("成功取消审批了{0}条记录。", count));
                    MessageHandler.ShowMessageBox(string.Format(tsmiCgqxsp.Text + "{0}" + tsmiTjl.Text, count));
                }
                ClearHeadGridAllSelect();
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--取消审批按钮事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiQxspansj.Text, ex);
            }
        }

        /// <summary>
        /// 关闭按钮事件
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                int count = dataSet_Order.Tables[0].Select("select=1").Length;
                if (count == 0)
                {
                    MessageHandler.ShowMessageBox(tsmiQzycz.Text);// ("请在要操作的记录前面选中。");
                    return;
                }

                if (!CheckReqState_Multi(false, false, true, false))
                    return;

                //if (MessageHandler.ShowMessageBox_YesNo(string.Format("确定要关闭当前选中的{0}条记录吗？", count)) != DialogResult.Yes)
                if (MessageHandler.ShowMessageBox_YesNo(string.Format(tsmiQdygddqxzd.Text + "{0}" + tsmiTjlm.Text, count)) != DialogResult.Yes)
                {
                    return;
                }
                if (!orderDAO.CloseOrder_Multi(dataSet_Order.Tables[0]))
                    btnQuery_Click(null, null);
                ClearHeadGridAllSelect();
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--关闭按钮事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiGbansj.Text, ex);
            }
        }

        /// <summary>
        /// 取消关闭按钮事件
        /// </summary>
        private void btnCancelClose_Click(object sender, EventArgs e)
        {
            try
            {
                int count = dataSet_Order.Tables[0].Select("select=1").Length;
                if (count == 0)
                {
                    MessageHandler.ShowMessageBox(f.tsmiQzyczdjlq.Text);// ("请在要操作的记录前面选中。");
                    return;
                }

                if (!CheckReqState_Multi(true, true, false, true))
                    return;

                //if (MessageHandler.ShowMessageBox_YesNo(string.Format("确定要取消关闭当前选中的{0}条记录吗？", count)) != DialogResult.Yes)
                if (MessageHandler.ShowMessageBox_YesNo(string.Format(f.tsmiQdyqxgbdqxzd.Text + "{0}" + tsmiTjlm.Text, count)) != DialogResult.Yes)
                {
                    return;
                }
                if (!orderDAO.CancelCloseOrder_Multi(dataSet_Order.Tables[0]))
                    btnQuery_Click(null, null);
                ClearHeadGridAllSelect();
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--取消关闭按钮事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiQxgbansj.Text, ex);
            }
        }

        /// <summary>
        /// 请购适用按钮事件
        /// </summary>
        private void btnPrReqApply_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPrReqApply prReqApplyForm = new FrmPrReqApply();
                if (prReqApplyForm.ShowDialog() == DialogResult.OK)
                {
                    PRToPO_Order(prReqApplyForm.gridViewPrReqHead.GetFocusedDataRow(), prReqApplyForm.dataSet_PrReq.Tables[1]);
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--请购适用按钮事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiQgsyansjcw.Text, ex);
            }
        }

        /// <summary>
        /// 打印预览按钮事件
        /// </summary>
        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                string orderHeadNoStr = "";
                if (gridViewOrderHead.GetFocusedDataRow() != null)
                    orderHeadNoStr = DataTypeConvert.GetString(gridViewOrderHead.GetFocusedDataRow()["OrderHeadNo"]);
                orderDAO.PrintHandle(orderHeadNoStr, 1);
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--打印预览按钮事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiDyylansjcw.Text, ex);
            }
        }

        ///// <summary>
        ///// 打印设计
        ///// </summary>
        //private void btnDesigner_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string orderHeadNoStr = "";
        //        if (gridViewOrderHead.GetFocusedDataRow() != null)
        //            orderHeadNoStr = DataTypeConvert.GetString(gridViewOrderHead.GetFocusedDataRow()["OrderHeadNo"]);
        //        orderDAO.PrintHandle(orderHeadNoStr, 3);
        //    }
        //    catch (Exception ex)
        //    {
        //        ExceptionHandler.HandleException(this.Text + "--打印设计操作错误。", ex);
        //    }
        //}

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
            foreach (DataRow dr in dataSet_Order.Tables[0].Rows)
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
                //ExceptionHandler.HandleException(this.Text + "--子表新增一行事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiZbxzyhsjcw.Text, ex);
            }
        }

        /// <summary>
        /// 主表设定默认值
        /// </summary>
        private void gridViewOrderHead_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            try
            {
                DateTime nowDate = BaseSQL.GetServerDateTime();
                gridViewOrderHead.SetFocusedRowCellValue("OrderHeadDate", nowDate);
                gridViewOrderHead.SetFocusedRowCellValue("ReqDep", SystemInfo.user.DepartmentNo);
                gridViewOrderHead.SetFocusedRowCellValue("PurCategory", DataTypeConvert.GetString(((DataTable)lookUpPurCategory.Properties.DataSource).Rows[1]["PurCategory"]));
                gridViewOrderHead.SetFocusedRowCellValue("ReqState", 1);
                gridViewOrderHead.SetFocusedRowCellValue("Prepared", SystemInfo.user.EmpName);
                gridViewOrderHead.SetFocusedRowCellValue("Tax", SystemInfo.OrderList_DefaultTax);
                gridViewOrderHead.SetFocusedRowCellValue("PlanDate", nowDate.Date.AddDays(7));
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--主表设定默认值错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiZbsdmrzcw.Text, ex);
            }
        }

        /// <summary>
        /// 子表设定默认值
        /// </summary>
        private void gridViewOrderList_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            try
            {
                gridViewOrderList.SetFocusedRowCellValue("OrderHeadNo", DataTypeConvert.GetString(gridViewOrderHead.GetFocusedDataRow()["OrderHeadNo"]));
                double d = DataTypeConvert.GetDouble(gridViewOrderHead.GetFocusedDataRow()["Tax"]);
                gridViewOrderList.SetFocusedRowCellValue("Tax", DataTypeConvert.GetDouble(gridViewOrderHead.GetFocusedDataRow()["Tax"]));
                gridViewOrderList.SetFocusedRowCellValue("PlanDate", DataTypeConvert.GetDateTime(gridViewOrderHead.GetFocusedDataRow()["PlanDate"]));
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--子表设定默认值错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiZbsdmrzcw.Text, ex);
            }
        }

        /// <summary>
        /// 子表按键事件
        /// </summary>
        private void gridViewOrderList_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (!colRemark.OptionsColumn.AllowEdit)
                        return;

                    if (gridViewOrderList.GetFocusedDataSourceRowIndex() >= gridViewOrderList.DataRowCount - 1 && gridViewOrderList.FocusedColumn.Name == "colRemark")
                    {
                        ListNewRow();
                    }
                    else if (gridViewOrderList.FocusedColumn.Name == "colRemark")
                    {
                        gridViewOrderList.FocusedRowHandle = gridViewOrderList.FocusedRowHandle + 1;
                        FocusedListView(true, "CodeFileName", gridViewOrderList.GetFocusedDataSourceRowIndex());
                    }
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--子表按键事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiZbajsjcw.Text, ex);
            }
        }

        /// <summary>
        /// 删除子表中的一行
        /// </summary>
        private void repbtnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                int prListAutoIdInt = 0;
                if (gridViewOrderList.GetFocusedDataRow() != null)
                    prListAutoIdInt = DataTypeConvert.GetInt(gridViewOrderList.GetFocusedDataRow()["PrListAutoId"]);
                gridViewOrderList.DeleteRow(gridViewOrderList.FocusedRowHandle);
                if (prListAutoIdInt > 0)
                    gridViewPrReqHead_FocusedRowChanged(sender, null);
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--删除子表中的一行错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiSczbzyhcw.Text, ex);
            }
        }

        /// <summary>
        /// 主表单元格值变化进行的操作
        /// </summary>
        private void gridViewOrderHead_CellValueChanged(object sender, CellValueChangedEventArgs e)
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
                //ExceptionHandler.HandleException(this.Text + "--主表单元格值变化进行的操作错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiZbdygzbhjxdczcw.Text, ex);
            }
        }

        /// <summary>
        /// 子表单元格值变化进行的操作
        /// </summary>
        private void gridViewOrderList_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            try
            {
                switch (e.Column.FieldName)
                {
                    case "CodeFileName":
                        string tmpStr = DataTypeConvert.GetString(gridViewOrderList.GetDataRow(e.RowHandle)["CodeFileName"]);
                        if (tmpStr == "")
                            gridViewOrderList.SetRowCellValue(e.RowHandle, "CodeName", "");
                        else
                        {
                            DataTable temp = (DataTable)repSearchCodeFileName.DataSource;
                            DataRow[] drs = temp.Select(string.Format("CodeFileName='{0}'", tmpStr));
                            if (drs.Length > 0)
                            {
                                gridViewOrderList.SetRowCellValue(e.RowHandle, "CodeName", DataTypeConvert.GetString(drs[0]["CodeName"]));
                            }
                        }
                        if (DataTypeConvert.GetString(gridViewOrderList.GetDataRow(e.RowHandle)["PrReqNo"]) != "")
                        {
                            gridViewOrderList.SetRowCellValue(e.RowHandle, "PrReqNo", "");
                            gridViewOrderList.SetRowCellValue(e.RowHandle, "PrListAutoId", 0);
                        }
                        break;
                    case "Qty":
                    case "Unit":
                    case "Tax":
                        double qtyDouble = DataTypeConvert.GetDouble(gridViewOrderList.GetDataRow(e.RowHandle)["Qty"]);
                        double unitDouble = DataTypeConvert.GetDouble(gridViewOrderList.GetDataRow(e.RowHandle)["Unit"]);
                        double amountDouble = Math.Round(qtyDouble * unitDouble, 2, MidpointRounding.AwayFromZero);
                        double taxDouble = DataTypeConvert.GetDouble(gridViewOrderList.GetDataRow(e.RowHandle)["Tax"]);
                        double taxAmountDouble = Math.Round(amountDouble * taxDouble, 2, MidpointRounding.AwayFromZero);
                        double sumAmountDouble = amountDouble + taxAmountDouble;
                        gridViewOrderList.SetRowCellValue(e.RowHandle, "Amount", amountDouble);
                        gridViewOrderList.SetRowCellValue(e.RowHandle, "TaxAmount", taxAmountDouble);
                        gridViewOrderList.SetRowCellValue(e.RowHandle, "SumAmount", sumAmountDouble);
                        break;
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--子表单元格值变化进行的操作错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiZbdygzbhjxdczcw.Text, ex);
            }
        }

        /// <summary>
        /// 设定当前行选择
        /// </summary>
        private void repCheckSelect_EditValueChanged(object sender, EventArgs e)
        {
            if (DataTypeConvert.GetBoolean(gridViewOrderHead.GetFocusedDataRow()["Select"]))
                gridViewOrderHead.GetFocusedDataRow()["Select"] = false;
            else
                gridViewOrderHead.GetFocusedDataRow()["Select"] = true;
            onlySelectColChangeRowState = true;
        }

        /// <summary>
        /// 鼠标操作明细行事件
        /// </summary>
        private void gridViewOrderList_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (btnNew.Enabled)
                {
                    if (e.Clicks == 2 && e.Button == MouseButtons.Left)
                    {
                        barButtonUp_ItemClick(null, null);
                    }
                    else if (e.Button == MouseButtons.Right)
                    {
                        popupMenuList.ShowPopup(Control.MousePosition);
                    }
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--鼠标操作明细行事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiSbczmxhsj.Text, ex);
            }
        }

        /// <summary>
        /// 查询明细的上一级请购单
        /// </summary>
        private void barButtonUp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (gridViewOrderList.GetFocusedDataRow() != null)
                {
                    string prReqNoStr = DataTypeConvert.GetString(gridViewOrderList.GetFocusedDataRow()["PrReqNo"]);
                    int prListAutoId = DataTypeConvert.GetInt(gridViewOrderList.GetFocusedDataRow()["PrListAutoId"]);
                    if (prReqNoStr == "" || prListAutoId == 0)
                        return;
                    FrmPrReq.queryPrReqNo = prReqNoStr;
                    FrmPrReq.queryListAutoId = prListAutoId;
                    ViewHandler.ShowRightWindow("FrmPrReq");
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--查询明细的上一级请购单错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiCxmxdsyjqgdcw.Text, ex);
            }
        }

        /// <summary>
        /// 查询明细的下一级入库单
        /// </summary>
        private void barButtonDown_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (gridViewOrderList.GetFocusedDataRow() != null)
                {
                    int autoIdInt = DataTypeConvert.GetInt(gridViewOrderList.GetFocusedDataRow()["AutoId"]);
                    FrmWarehouseWarrantQuery.orderListAutoId = autoIdInt;
                    ViewHandler.ShowRightWindow("FrmWarehouseWarrantQuery");
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--查询明细的下一级入库单错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiCxmxdxyjrkdcw.Text, ex);
            }
        }

        /// <summary>
        /// 检查是否有未填写字段
        /// </summary>
        private bool IsHaveBlankLine()
        {
            gridViewOrderList.FocusedRowHandle = 0;
            for (int i = 0; i < gridViewOrderList.DataRowCount; i++)
            {
                if (DataTypeConvert.GetString(gridViewOrderList.GetDataRow(i)["CodeFileName"]) == "")
                {
                    gridViewOrderList.Focus();
                    gridViewOrderList.FocusedColumn = colCodeFileName;
                    gridViewOrderList.FocusedRowHandle = i;
                    return true;
                }
                if (DataTypeConvert.GetString(gridViewOrderList.GetDataRow(i)["Qty"]) == "")
                {
                    gridViewOrderList.Focus();
                    gridViewOrderList.FocusedColumn = colQty;
                    gridViewOrderList.FocusedRowHandle = i;
                    return true;
                }
                if (DataTypeConvert.GetString(gridViewOrderList.GetDataRow(i)["Unit"]) == "")
                {
                    gridViewOrderList.Focus();
                    gridViewOrderList.FocusedColumn = colUnit;
                    gridViewOrderList.FocusedRowHandle = i;
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
            gridViewOrderList.AddNewRow();
            FocusedListView(true, "CodeFileName", gridViewOrderList.GetFocusedDataSourceRowIndex());
            //gridViewOrderList.RefreshData();
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
                btnSave.Tag = "保存";
                btnSave.Text = f.tsmiBc.Text;
                btnCancel.Enabled = true;
                btnDelete.Enabled = false;
            }
            else
            {
                btnNew.Enabled = true;
                btnSave.Tag = "修改";
                btnSave.Text = f.tsmiXg.Text;
                btnCancel.Enabled = false;
                btnDelete.Enabled = true;
            }
            btnApprove.Enabled = !ret;
            btnCancelApprove.Enabled = !ret;
            btnClose.Enabled = !ret;
            btnCancelClose.Enabled = !ret;
            btnPrReqApply.Enabled = !ret;
            btnPreview.Enabled = !ret;

            btnListAdd.Enabled = ret;

            colPurCategory.OptionsColumn.AllowEdit = ret;
            colBussinessBaseNo.OptionsColumn.AllowEdit = ret;
            colReqDep.OptionsColumn.AllowEdit = ret;
            colTax.OptionsColumn.AllowEdit = ret;
            colProjectNo.OptionsColumn.AllowEdit = ret;
            colStnNo.OptionsColumn.AllowEdit = ret;
            colApprovalType.OptionsColumn.AllowEdit = ret;
            colPayTypeNo.OptionsColumn.AllowEdit = ret;
            colPlanDate.OptionsColumn.AllowEdit = ret;
            colPrReqRemark.OptionsColumn.AllowEdit = ret;

            colCodeFileName.OptionsColumn.AllowEdit = ret;
            colUnit.OptionsColumn.AllowEdit = ret;
            colQty.OptionsColumn.AllowEdit = ret;
            colTax1.OptionsColumn.AllowEdit = ret;
            colPlanDate1.OptionsColumn.AllowEdit = ret;
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
        /// 检测请购单状态是否可以操作
        /// </summary>
        private bool CheckReqState()
        {
            if (gridViewOrderHead.GetFocusedDataRow() == null)
                return false;
            int reqState = DataTypeConvert.GetInt(gridViewOrderHead.GetFocusedDataRow()["ReqState"]);
            switch (reqState)
            {
                case 2:
                    //MessageHandler.ShowMessageBox(string.Format("采购订单[{0}]已经审批，不可以操作。", DataTypeConvert.GetString(gridViewOrderHead.GetFocusedDataRow()["OrderHeadNo"]))); 
                    MessageHandler.ShowMessageBox(string.Format(tsmiCgdd.Text +"[{0}]"+tsmiYjsp.Text +tsmiBkycz.Text , DataTypeConvert.GetString(gridViewOrderHead.GetFocusedDataRow()["OrderHeadNo"])));
                    return false;
                case 3:
                    //MessageHandler.ShowMessageBox(string.Format("采购订单[{0}]已经关闭，不可以操作。", DataTypeConvert.GetString(gridViewOrderHead.GetFocusedDataRow()["OrderHeadNo"])));
                    MessageHandler.ShowMessageBox(string.Format(tsmiCgdd.Text+"[{0}]"+tsmiYjgbbk.Text , DataTypeConvert.GetString(gridViewOrderHead.GetFocusedDataRow()["OrderHeadNo"])));
                    return false;
                case 4:
                    //MessageHandler.ShowMessageBox(string.Format("采购订单[{0}]已经审批中，不可以操作。", DataTypeConvert.GetString(gridViewOrderHead.GetFocusedDataRow()["OrderHeadNo"])));
                    MessageHandler.ShowMessageBox(string.Format(tsmiCgdd.Text+"[{0}]"+tsmiYjspzbk.Text, DataTypeConvert.GetString(gridViewOrderHead.GetFocusedDataRow()["OrderHeadNo"])));
                    return false;
            }
            return true;
        }

        /// <summary>
        /// 检测当前选中的请购单状态是否可以操作
        /// </summary>
        private bool CheckReqState_Multi(bool checkNoApprover, bool checkApprover, bool checkClosed, bool checkApproverBetween)
        {
            for (int i = 0; i < gridViewOrderHead.DataRowCount; i++)
            {
                if (DataTypeConvert.GetBoolean(gridViewOrderHead.GetDataRow(i)["Select"]))
                {
                    int reqState = DataTypeConvert.GetInt(gridViewOrderHead.GetDataRow(i)["ReqState"]);
                    switch (reqState)
                    {
                        case 1:
                            if (checkNoApprover)
                            {
                                //MessageHandler.ShowMessageBox(string.Format("采购订单[{0}]未审批，不可以操作。", DataTypeConvert.GetString(gridViewOrderHead.GetDataRow(i)["OrderHeadNo"])));
                                MessageHandler.ShowMessageBox(string.Format(tsmiCgdd.Text +"[{0}]"+tsmiWspbk.Text, DataTypeConvert.GetString(gridViewOrderHead.GetDataRow(i)["OrderHeadNo"])));
                                gridViewOrderHead.FocusedRowHandle = i;
                                return false;
                            }
                            break;
                        case 2:
                            if (checkApprover)
                            {
                                //MessageHandler.ShowMessageBox(string.Format("采购订单[{0}]已经审批，不可以操作。", DataTypeConvert.GetString(gridViewOrderHead.GetDataRow(i)["OrderHeadNo"])));
                                MessageHandler.ShowMessageBox(string.Format(tsmiCgdd.Text +"[{0}]"+tsmiYjspbk.Text , DataTypeConvert.GetString(gridViewOrderHead.GetDataRow(i)["OrderHeadNo"])));

                                gridViewOrderHead.FocusedRowHandle = i;
                                return false;
                            }
                            break;
                        case 3:
                            if (checkClosed)
                            {
                                //MessageHandler.ShowMessageBox(string.Format("采购订单[{0}]已经关闭，不可以操作。", DataTypeConvert.GetString(gridViewOrderHead.GetDataRow(i)["OrderHeadNo"])));
                                MessageHandler.ShowMessageBox(string.Format(tsmiCgdd.Text +"[{0}]"+tsmiYjgbbk.Text , DataTypeConvert.GetString(gridViewOrderHead.GetDataRow(i)["OrderHeadNo"])));
                                gridViewOrderHead.FocusedRowHandle = i;
                                return false;
                            }
                            break;
                        case 4:
                            if (checkApproverBetween)
                            {
                                //MessageHandler.ShowMessageBox(string.Format("采购订单[{0}]已经审批中，不可以操作。", DataTypeConvert.GetString(gridViewOrderHead.GetDataRow(i)["OrderHeadNo"])));
                                MessageHandler.ShowMessageBox(string.Format(tsmiCgdd.Text +"[{0}]"+tsmiYjspzbk.Text, DataTypeConvert.GetString(gridViewOrderHead.GetDataRow(i)["OrderHeadNo"])));
                                gridViewOrderHead.FocusedRowHandle = i;
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
            gridControlOrderHead.Focus();
            ColumnView headView = (ColumnView)gridControlOrderHead.FocusedView;
            headView.FocusedColumn = headView.Columns[colName];
            gridViewOrderHead.FocusedRowHandle = headView.FocusedRowHandle;
        }

        /// <summary>
        /// 聚焦子表当前行的列
        /// </summary>
        private void FocusedListView(bool isFocusedControl, string colName, int lineNo)
        {
            if (isFocusedControl)
                gridControlOrderList.Focus();
            ColumnView listView = (ColumnView)gridControlOrderList.FocusedView;
            listView.FocusedColumn = listView.Columns[colName];
            gridViewOrderList.FocusedRowHandle = lineNo;
        }

        /// <summary>
        /// 绑定站号的ComboBox控件
        /// </summary>
        private void BingStnListComboBox()
        {
            string tmpStr = DataTypeConvert.GetString(gridViewOrderHead.GetFocusedDataRow()["ProjectNo"]);
            DataTable stnListTable = commonDAO.QueryStnList(tmpStr);
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
            for (int i = 0; i < dataSet_Order.Tables[0].Rows.Count; i++)
            {
                dataSet_Order.Tables[0].Rows[i]["Select"] = false;
            }
            dataSet_Order.Tables[0].AcceptChanges();
            onlySelectColChangeRowState = false;
        }

        /// <summary>
        /// 请购单转成采购单
        /// </summary>
        /// <param name="prReqHeadRow"></param>
        /// <param name="prReqListTable"></param>
        private void PRToPO_Order(DataRow prReqHeadRow, DataTable prReqListTable)
        {
            ClearHeadGridAllSelect();
            gridViewOrderHead.AddNewRow();
            FocusedHeadView("BussinessBaseNo");

            gridViewOrderHead.SetFocusedRowCellValue("PurCategory", prReqHeadRow["PurCategory"]);
            gridViewOrderHead.SetFocusedRowCellValue("ReqDep", prReqHeadRow["ReqDep"]);
            //gridViewPrReqHead.SetFocusedRowCellValue("BussinessBaseNo", orderDAO.GetBussinessBaseNo_ProjectNo(prReqHeadRow["ProjectNo"].ToString()));
            gridViewOrderHead.SetFocusedRowCellValue("ProjectNo", prReqHeadRow["ProjectNo"]);
            gridViewOrderHead.SetFocusedRowCellValue("StnNo", prReqHeadRow["StnNo"]);

            dataSet_Order.Tables[1].Clear();
            foreach (DataRow dr in prReqListTable.Rows)
            {
                if (DataTypeConvert.GetBoolean(dr["ListSelect"]))
                {
                    gridViewOrderList.AddNewRow();
                    gridViewOrderList.SetFocusedRowCellValue("CodeFileName", dr["CodeFileName"]);
                    gridViewOrderList.SetFocusedRowCellValue("CodeName", dr["CodeName"]);
                    gridViewOrderList.SetFocusedRowCellValue("Qty", DataTypeConvert.GetDouble(dr["Overplus"]));
                    gridViewOrderList.SetFocusedRowCellValue("PrReqNo", dr["PrReqNo"]);
                    gridViewOrderList.SetFocusedRowCellValue("PrListAutoId", dr["AutoId"]);
                }
            }
            gridViewOrderList.RefreshData();
            FocusedListView(false, "Unit", gridViewOrderList.GetFocusedDataSourceRowIndex());

            SetButtonAndColumnState(true);
            headFocusedLineNo = gridViewOrderHead.DataRowCount;
        }

        #endregion

        #region 左侧请购单模块的相关事件和方法

        /// <summary>
        /// 查询请购单事件
        /// </summary>
        private void btnPrReqQuery_Click(object sender, EventArgs e)
        {
            try
            {
                if (dateReqDateBegin.EditValue == null || dateReqDateEnd.EditValue == null)
                {
                    MessageHandler.ShowMessageBox(tsmiQgrqbnwkcx.Text );// ("请购日期不能为空，请设置后重新进行查询。");
                    if (dateReqDateBegin.EditValue == null)
                        dateReqDateBegin.Focus();
                    else
                        dateReqDateEnd.Focus();
                    return;
                }
                string prReqNoStr = textPrReqNo.Text.Trim();
                string orderDateBeginStr = dateReqDateBegin.DateTime.ToString("yyyy-MM-dd");
                string orderDateEndStr = dateReqDateEnd.DateTime.AddDays(1).ToString("yyyy-MM-dd");
                string projectNoStr = searchLookUpProjectNo.Text != "全部" ? DataTypeConvert.GetString(searchLookUpProjectNo.EditValue) : "";

                dataSet_PrReq.Tables[0].Clear();
                dataSet_PrReq.Tables[1].Clear();
                applyDAO.QueryPrReqHead(dataSet_PrReq.Tables[0], prReqNoStr, orderDateBeginStr, orderDateEndStr, "", "", "", projectNoStr, "");
                //if (prReqNoStr != "" && dataSet_PrReq.Tables[0].Rows.Count > 0)
                //    textPrReqNo.Text = "";
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--查询请购单事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+tsmiCxqgdsjcw.Text , ex);
            }
        }

        /// <summary>
        /// 聚焦查询请购单明细事件
        /// </summary>
        private void gridViewPrReqHead_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            try
            {
                if (gridViewPrReqHead.GetFocusedDataRow() != null && sender != null)
                {
                    dataSet_PrReq.Tables[1].Clear();
                    applyDAO.QueryPrReqList(dataSet_PrReq.Tables[1], DataTypeConvert.GetString(gridViewPrReqHead.GetFocusedDataRow()["PrReqNo"]));
                    ClearAlreadyDragPrReqList();
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--聚焦查询请购单明细事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+tsmiJjcxqgdmxsjcw.Text , ex);
            }
        }

        #region 拖出

        /// <summary>
        /// 在GridView中按下鼠标事件
        /// </summary>
        private void gridViewPrReqList_MouseDown(object sender, MouseEventArgs e)
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
                //ExceptionHandler.HandleException(this.Text + "--在GridView中按下鼠标事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+f.tsmiZgridviewzaxsbsjcw.Text , ex);
            }
        }

        /// <summary>
        /// 在GridView中移动鼠标事件
        /// </summary>
        private void gridViewPrReqList_MouseMove(object sender, MouseEventArgs e)
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
                //ExceptionHandler.HandleException(this.Text + "--在GridView中按下鼠标事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+f.tsmiZgridviewzaxsbsjcw.Text , ex);
            }
        }

        #endregion

        #region 拖入

        /// <summary>
        /// 拖拽在GridControl上面
        /// </summary>
        private void gridControlOrderList_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<DataRow>)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        /// <summary>
        /// 拖拽进入到GridControl控件
        /// </summary>
        private void gridControlOrderList_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        /// <summary>
        /// 实现拖拽请购单事件
        /// </summary>
        private void gridControlOrderList_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                List<DataRow> drs = e.Data.GetData(typeof(List<DataRow>)) as List<DataRow>;
                if (drs != null)
                {
                    PRToPO_DragOrder(sender, drs);
                    ClearAlreadyDragPrReqList();
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--"+tsmiSxtzqgdsjcw.Text , ex);
            }
        }

        /// <summary>
        /// 拖拽请购单转成采购订单 
        /// </summary>
        private void PRToPO_DragOrder(object sender, List<DataRow> drs)
        {
            DataRow headRow = gridViewPrReqHead.GetFocusedDataRow();

            if (btnApprove.Enabled)
            {
                ClearHeadGridAllSelect();
                gridViewOrderHead.AddNewRow();
                FocusedHeadView("BussinessBaseNo");

                gridViewOrderHead.SetFocusedRowCellValue("PurCategory", headRow["PurCategory"]);
                gridViewOrderHead.SetFocusedRowCellValue("ReqDep", headRow["ReqDep"]);
                //gridViewPrReqHead.SetFocusedRowCellValue("BussinessBaseNo", orderDAO.GetBussinessBaseNo_ProjectNo(prReqHeadRow["ProjectNo"].ToString()));
                gridViewOrderHead.SetFocusedRowCellValue("ProjectNo", headRow["ProjectNo"]);
                gridViewOrderHead.SetFocusedRowCellValue("StnNo", headRow["StnNo"]);

                dataSet_Order.Tables[1].Clear();
                foreach (DataRow dr in drs)
                {
                    gridViewOrderList.AddNewRow();
                    gridViewOrderList.SetFocusedRowCellValue("CodeFileName", dr["CodeFileName"]);
                    gridViewOrderList.SetFocusedRowCellValue("CodeName", dr["CodeName"]);
                    gridViewOrderList.SetFocusedRowCellValue("Qty", DataTypeConvert.GetDouble(dr["Overplus"]));
                    gridViewOrderList.SetFocusedRowCellValue("PrReqNo", dr["PrReqNo"]);
                    gridViewOrderList.SetFocusedRowCellValue("PrListAutoId", dr["AutoId"]);
                }
                gridViewOrderList.RefreshData();
                FocusedListView(false, "Unit", gridViewOrderList.GetFocusedDataSourceRowIndex());

                SetButtonAndColumnState(true);
                headFocusedLineNo = gridViewOrderHead.DataRowCount;
            }
            else
            {
                if (dataSet_Order.Tables[1].Rows.Count > 0)
                {
                    if (DataTypeConvert.GetString(gridViewOrderHead.GetFocusedDataRow()["ProjectNo"]) != DataTypeConvert.GetString(headRow["ProjectNo"]))
                    {
                        MessageHandler.ShowMessageBox(tsmiYzcgddzrxxmdxmh.Text );// ("一张采购订单只允许相同的项目号进行登记。");
                        return;
                    }
                }

                foreach (DataRow dr in drs)
                {
                    if (dataSet_Order.Tables[1].Select(string.Format("PrListAutoId={0}", DataTypeConvert.GetString(dr["AutoId"]))).Length > 0)
                        continue;
                    gridViewOrderList.AddNewRow();
                    gridViewOrderList.SetFocusedRowCellValue("CodeFileName", dr["CodeFileName"]);
                    gridViewOrderList.SetFocusedRowCellValue("CodeName", dr["CodeName"]);
                    gridViewOrderList.SetFocusedRowCellValue("Qty", DataTypeConvert.GetDouble(dr["Overplus"]));
                    gridViewOrderList.SetFocusedRowCellValue("PrReqNo", dr["PrReqNo"]);
                    gridViewOrderList.SetFocusedRowCellValue("PrListAutoId", dr["AutoId"]);
                }

                gridViewOrderList.FocusedRowHandle = gridViewOrderList.DataRowCount;
                FocusedListView(false, "Unit", gridViewOrderList.GetFocusedDataSourceRowIndex());
                gridViewOrderList.RefreshData();
            }
        }

        #endregion

        /// <summary>
        /// 清空已经拖拽的请购单明细
        /// </summary>
        private void ClearAlreadyDragPrReqList()
        {
            for (int i = dataSet_PrReq.Tables[1].Rows.Count - 1; i >= 0; i--)
            {
                if (dataSet_Order.Tables[1].Select(string.Format("PrListAutoId={0}", DataTypeConvert.GetString(dataSet_PrReq.Tables[1].Rows[i]["AutoId"]))).Length > 0)
                    dataSet_PrReq.Tables[1].Rows.RemoveAt(i);
            }
        }

        #endregion

    }
}
