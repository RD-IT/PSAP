using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class FrmWarehouseWarrant_Drag : DockContent
    {
        #region 私有变量

        FrmWarehouseWarrantDAO wwDAO = new FrmWarehouseWarrantDAO();
        FrmCommonDAO commonDAO = new FrmCommonDAO();
        FrmOrderApplyDAO applyDAO = new FrmOrderApplyDAO();

        /// <summary>
        /// 主表聚焦的行号
        /// </summary>
        int headFocusedLineNo = 0;

        /// <summary>
        /// 查询的入库单号
        /// </summary>
        public static string queryWWHeadNo = "";

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

        public FrmWarehouseWarrant_Drag()
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
        private void FrmWarehouseWarrantHead_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime nowDate = BaseSQL.GetServerDateTime();
                dateWWDateBegin.DateTime = nowDate.Date.AddDays(-SystemInfo.OrderQueryDate_DefaultDays);
                dateWWDateEnd.DateTime = nowDate.Date;

                lookUpReqDep.Properties.DataSource = commonDAO.QueryDepartment(true);
                lookUpReqDep.ItemIndex = 0;
                searchLookUpBussinessBaseNo.Properties.DataSource = commonDAO.QueryBussinessBaseInfo(true);
                searchLookUpBussinessBaseNo.Text = "全部";
                lookUpRepertoryNo.Properties.DataSource = commonDAO.QueryRepertoryInfo(true);
                lookUpRepertoryNo.ItemIndex = 0;
                lookUpWarehouseWarrantTypeNo.Properties.DataSource = wwDAO.QueryWarehouseWarrantType(true);
                lookUpWarehouseWarrantTypeNo.ItemIndex = 0;
                comboBoxWarehouseState.SelectedIndex = 0;
                lookUpPrepared.Properties.DataSource = commonDAO.QueryUserInfo(true);
                lookUpPrepared.EditValue = SystemInfo.user.EmpName;
                lookUpApprover.Properties.DataSource = commonDAO.QueryUserInfo(true);
                lookUpApprover.ItemIndex = -1;

                repLookUpReqDep.DataSource = commonDAO.QueryDepartment(false);
                repLookUpRepertoryNo.DataSource = commonDAO.QueryRepertoryInfo(false);
                repLookUpWWTypeNo.DataSource = wwDAO.QueryWarehouseWarrantType(false);
                repSearchBussinessBaseNo.DataSource = commonDAO.QueryBussinessBaseInfo(false);
                repLookUpApprovalType.DataSource = commonDAO.QueryApprovalType(false);

                repSearchCodeFileName.DataSource = commonDAO.QueryPartsCode(false);
                repSearchShelfId.DataSource = commonDAO.QueryShelfInfo(false);

                dateOrderDateBegin.DateTime = dateWWDateBegin.DateTime;
                dateOrderDateEnd.DateTime = dateWWDateEnd.DateTime;
                searchLookUpProjectNo.Properties.DataSource = commonDAO.QueryProjectList(true);
                searchLookUpProjectNo.Text = "全部";

                repLookUpOrderReqDep.DataSource = commonDAO.QueryDepartment(false);
                repLookUpOrderPurCategory.DataSource = commonDAO.QueryPurCategory(false);
                repSearchOrderBussinessBaseNo.DataSource = commonDAO.QueryBussinessBaseInfo(false);
                repLookUpOrderApprovalType.DataSource = commonDAO.QueryApprovalType(false);
                repLookUpOrderPayTypeNo.DataSource = commonDAO.QueryPayType(false);

                if (textCommon.Text == "")
                {
                    wwDAO.QueryWarehouseWarrantHead(dataSet_WW.Tables[0], "", "", "", "", "", "", 0, "", -1, "", true);
                    wwDAO.QueryWarehouseWarrantList(dataSet_WW.Tables[1], "", true);
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
        private void FrmWarehouseWarrantHead_Activated(object sender, EventArgs e)
        {
            try
            {
                if (queryWWHeadNo != "")
                {
                    textCommon.Text = queryWWHeadNo;
                    queryWWHeadNo = "";

                    lookUpReqDep.ItemIndex = 0;
                    searchLookUpBussinessBaseNo.Text = "全部";
                    lookUpRepertoryNo.ItemIndex = 0;
                    lookUpWarehouseWarrantTypeNo.ItemIndex = 0;
                    comboBoxWarehouseState.SelectedIndex = 0;
                    lookUpPrepared.ItemIndex = 0;
                    lookUpApprover.ItemIndex = -1;

                    dataSet_WW.Tables[0].Clear();
                    headFocusedLineNo = 0;
                    wwDAO.QueryWarehouseWarrantHead(dataSet_WW.Tables[0], "", "", "", "", "", "", 0, "", -1, textCommon.Text, false);
                    SetButtonAndColumnState(false);

                    if (dataSet_WW.Tables[0].Rows.Count > 0)
                    {
                        dateWWDateBegin.DateTime = DataTypeConvert.GetDateTime(dataSet_WW.Tables[0].Rows[0]["WarehouseWarrantDate"]).Date;
                        dateWWDateEnd.DateTime = dateWWDateBegin.DateTime.AddDays(7);
                    }
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--窗体激活事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiCtjzsjcw.Text, ex);
            }
        }

        /// <summary>
        /// 窗体显示事件
        /// </summary>
        private void FrmWarehouseWarrantHead_Shown(object sender, EventArgs e)
        {
            pnlMiddle.Height = (this.Height - pnltop.Height) / 2;
            pnlLeftMiddle.Height = gridControlWWHead.Height + 2;

            dockPnlLeft.Width = SystemInfo.DragForm_LeftDock_Width;
        }

        #endregion

        #region 右侧入库单模块的相关事件和方法

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
                if (dateWWDateBegin.EditValue == null || dateWWDateEnd.EditValue == null)
                {
                    MessageHandler.ShowMessageBox(tsmiRkrqbnwkcx.Text);// ("入库日期不能为空，请设置后重新进行查询。");
                    if (dateWWDateBegin.EditValue == null)
                        dateWWDateBegin.Focus();
                    else
                        dateWWDateEnd.Focus();
                    return;
                }
                string wwDateBeginStr = dateWWDateBegin.DateTime.ToString("yyyy-MM-dd");
                string wwDateEndStr = dateWWDateEnd.DateTime.AddDays(1).ToString("yyyy-MM-dd");

                string reqDepStr = lookUpReqDep.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpReqDep.EditValue) : "";
                string bussinessBaseNoStr = DataTypeConvert.GetString(searchLookUpBussinessBaseNo.EditValue) != "全部" ? DataTypeConvert.GetString(searchLookUpBussinessBaseNo.EditValue) : "";
                string repertoryNoStr = lookUpRepertoryNo.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpRepertoryNo.EditValue) : "";
                string wwTypeNoStr = lookUpWarehouseWarrantTypeNo.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpWarehouseWarrantTypeNo.EditValue) : "";

                int warehouseStateInt = comboBoxWarehouseState.SelectedIndex > 0 ? comboBoxWarehouseState.SelectedIndex : 0;
                string empNameStr = lookUpPrepared.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpPrepared.EditValue) : "";
                int approverInt = -1;
                if (lookUpApprover.ItemIndex == 0)
                    approverInt = 0;
                else if (lookUpApprover.ItemIndex > 0)
                    approverInt = DataTypeConvert.GetInt(lookUpApprover.EditValue);
                string commonStr = textCommon.Text.Trim();

                dataSet_WW.Tables[0].Rows.Clear();
                dataSet_WW.Tables[1].Rows.Clear();
                headFocusedLineNo = 0;
                wwDAO.QueryWarehouseWarrantHead(dataSet_WW.Tables[0], wwDateBeginStr, wwDateEndStr, reqDepStr, bussinessBaseNoStr, repertoryNoStr, wwTypeNoStr, warehouseStateInt, empNameStr, approverInt, commonStr, false);

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
        private void gridViewWWHead_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            try
            {
                if (gridViewWWHead.GetFocusedDataRow() != null)
                {
                    if (onlySelectColChangeRowState)
                    {
                        dataSet_WW.Tables[0].AcceptChanges();
                        onlySelectColChangeRowState = false;
                    }
                    else
                    {
                        if (headFocusedLineNo < gridViewWWHead.DataRowCount && gridViewWWHead.FocusedRowHandle != headFocusedLineNo && gridViewWWHead.GetDataRow(headFocusedLineNo).RowState != DataRowState.Unchanged)
                        {
                            MessageHandler.ShowMessageBox(tsmiDqrkdyjxghh.Text);// ("当前入库单已经修改，请保存后再进行换行。");
                            gridViewWWHead.FocusedRowHandle = headFocusedLineNo;
                        }
                        else if (headFocusedLineNo == gridViewWWHead.DataRowCount)
                        {

                        }
                        else
                        {
                            if (gridViewWWHead.FocusedRowHandle != headFocusedLineNo && gridViewWWHead.GetDataRow(headFocusedLineNo).RowState != DataRowState.Unchanged)
                                btnCancel_Click(null, null);
                            else if (gridViewWWHead.GetDataRow(headFocusedLineNo).RowState == DataRowState.Unchanged)
                                btnCancel_Click(null, null);
                        }
                    }

                    if (DataTypeConvert.GetString(gridViewWWHead.GetFocusedDataRow()["WarehouseWarrant"]) != "")
                    {
                        dataSet_WW.Tables[1].Clear();
                        wwDAO.QueryWarehouseWarrantList(dataSet_WW.Tables[1], DataTypeConvert.GetString(gridViewWWHead.GetFocusedDataRow()["WarehouseWarrant"]), false);
                        if (queryListAutoId > 0)
                        {
                            for (int i = 0; i < gridViewWWList.DataRowCount; i++)
                            {
                                if (DataTypeConvert.GetInt(gridViewWWList.GetDataRow(i)["AutoId"]) == queryListAutoId)
                                {
                                    gridViewWWList.FocusedRowHandle = i;
                                    queryListAutoId = 0;
                                    break;
                                }
                            }
                        }
                    }

                    if (gridViewWWHead.FocusedRowHandle >= 0)
                    {
                        headFocusedLineNo = gridViewWWHead.FocusedRowHandle;
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
        private void gridViewWWHead_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
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
        private void gridViewWWHead_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "WarehouseState")
            {
                e.DisplayText = CommonHandler.Get_WarehouseState_Desc(e.Value.ToString());
            }
        }

        /// <summary>
        /// 订单适用按钮事件
        /// </summary>
        private void btnOrderApply_Click(object sender, EventArgs e)
        {
            try
            {
                FrmOrderApply orderApplyForm = new FrmOrderApply();
                if (orderApplyForm.ShowDialog() == DialogResult.OK)
                {
                    POToWW_Order(orderApplyForm.gridViewOrderHead.GetFocusedDataRow(), orderApplyForm.dataSet_Order.Tables[1]);
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--请购适用按钮事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiQgsyansjcw.Text, ex);
            }
        }

        /// <summary>
        /// 保存按钮事件
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridViewWWHead.GetFocusedDataRow() == null)
                    return;

                if (!CheckWarehouseState())
                    return;

                if (btnSave.Tag.ToString() != "保存")
                {
                    ClearHeadGridAllSelect();

                    SetButtonAndColumnState(true);
                    FocusedHeadView("RepertoryNo");
                }
                else
                {
                    DataRow headRow = gridViewWWHead.GetFocusedDataRow();
                    if (DataTypeConvert.GetString(headRow["BussinessBaseNo"]) == "")
                    {
                        MessageHandler.ShowMessageBox("供应商不能为空，请填写后再进行保存。");
                        FocusedHeadView("BussinessBaseNo");
                        return;
                    }
                    if (DataTypeConvert.GetString(headRow["ReqDep"]) == "")
                    {
                        MessageHandler.ShowMessageBox(tsmiRkbmbnwkbc.Text);// ("入库部门不能为空，请填写后再进行保存。");
                        FocusedHeadView("ReqDep");
                        return;
                    }
                    if (DataTypeConvert.GetString(headRow["RepertoryNo"]) == "")
                    {
                        MessageHandler.ShowMessageBox(tsmiRkckbnwkbc.Text);// ("入库仓库不能为空，请填写后再进行保存。");
                        FocusedHeadView("RepertoryNo");
                        return;
                    }
                    if (DataTypeConvert.GetString(headRow["WarehouseWarrantTypeNo"]) == "")
                    {
                        MessageHandler.ShowMessageBox(tsmiRklbbnwkbc.Text);// ("入库类别不能为空，请填写后再进行保存。");
                        FocusedHeadView("WarehouseWarrantTypeNo");
                        return;
                    }
                    if (DataTypeConvert.GetString(headRow["ApprovalType"]) == "")
                    {
                        MessageHandler.ShowMessageBox(tsmiSplxbnwkbc.Text);// ("审批类型不能为空，请填写后再进行保存。");
                        FocusedHeadView("ApprovalType");
                        return;
                    }
                    if (gridViewWWList.DataRowCount == 0)
                    {
                        MessageHandler.ShowMessageBox(tsmiRkdmxbnwkbc.Text);// ("入库单明细不能为空，请重新订单适用后再进行保存。");
                        btnOrderApply.Focus();
                        return;
                    }

                    for (int i = gridViewWWList.DataRowCount - 1; i >= 0; i--)
                    {
                        DataRow listRow = gridViewWWList.GetDataRow(i);
                        if (DataTypeConvert.GetString(listRow["Qty"]) == "" || DataTypeConvert.GetDouble(listRow["Qty"]) == 0)
                        {
                            MessageHandler.ShowMessageBox(tsmiSlbnwkbc.Text);// ("数量不能为空，请填写后再进行保存。");
                            FocusedListView(true, "Qty", i);
                            return;
                        }
                        if (DataTypeConvert.GetString(listRow["ShelfId"]) == "")
                        {
                            MessageHandler.ShowMessageBox(tsmiHjbhbnwkbc.Text);// ("货架编号不能为空，请填写后再进行保存。");
                            FocusedListView(true, "ShelfId", i);
                            return;
                        }
                    }

                    int ret = wwDAO.SaveWarehouseWarrant(gridViewWWHead.GetFocusedDataRow(), dataSet_WW.Tables[1]);
                    switch (ret)
                    {
                        case -1:
                            btnQuery_Click(null, null);
                            break;
                        case 1:
                            dataSet_WW.Tables[1].Clear();
                            wwDAO.QueryWarehouseWarrantList(dataSet_WW.Tables[1], DataTypeConvert.GetString(gridViewWWHead.GetFocusedDataRow()["WarehouseWarrant"]), false);
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
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiBcansj.Text, ex);
            }
        }

        /// <summary>
        /// 取消按钮事件
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridViewWWHead.GetDataRow(headFocusedLineNo).RowState != DataRowState.Unchanged)
                {
                    if (DataTypeConvert.GetString(gridViewWWHead.GetDataRow(headFocusedLineNo)["WarehouseWarrant"]) == "")
                    {
                        gridViewWWHead.DeleteRow(headFocusedLineNo);
                    }
                    else
                    {
                        gridViewWWHead.GetFocusedDataRow().RejectChanges();
                    }
                }

                SetButtonAndColumnState(false);

                dataSet_WW.Tables[1].Clear();
                if (gridViewWWHead.GetFocusedDataRow() != null)
                    wwDAO.QueryWarehouseWarrantList(dataSet_WW.Tables[1], DataTypeConvert.GetString(gridViewWWHead.GetFocusedDataRow()["WarehouseWarrant"]), false);

                gridViewOrderHead_FocusedRowChanged(sender, null);
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--取消按钮事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiQxspansj.Text, ex);
            }
        }

        /// <summary>
        /// 删除按钮事件
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int count = dataSet_WW.Tables[0].Select("select=1").Length;
                if (count == 0)
                {
                    MessageHandler.ShowMessageBox(f.tsmiQzyczdjlq.Text);// ("请在要操作的记录前面选中。");
                    return;
                }

                if (!CheckWarehouseState_Multi(false, true, true, true))
                    return;

                //if (MessageHandler.ShowMessageBox_YesNo(string.Format("确定要删除当前选中的{0}条记录吗？", count)) != DialogResult.Yes)
                if (MessageHandler.ShowMessageBox_YesNo(string.Format(f.tsmiQdyscdqxzd.Text + "{0}" + f.tsmiTjlm.Text, count)) != DialogResult.Yes)
                {
                    return;
                }
                if (!wwDAO.DeleteWW_Multi(dataSet_WW.Tables[0]))
                    btnQuery_Click(null, null);

                btnQuery_Click(null, null);
                ClearHeadGridAllSelect();
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--删除按钮事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiScansj.Text, ex);
            }
        }

        /// <summary>
        /// 审批按钮事件
        /// </summary>
        private void btnApprove_Click(object sender, EventArgs e)
        {
            try
            {
                int count = dataSet_WW.Tables[0].Select("select=1").Length;
                if (count == 0)
                {
                    MessageHandler.ShowMessageBox(f.tsmiQzyczdjlq.Text);// ("请在要操作的记录前面选中。");
                    return;
                }

                if (!CheckWarehouseState_Multi(false, true, true, false))
                    return;

                if (count == 1)
                {
                    //弹出审批页面
                    FrmWarehouseWarrantApproval frmWW = new FrmWarehouseWarrantApproval(DataTypeConvert.GetString(dataSet_WW.Tables[0].Select("select=1")[0]["WarehouseWarrant"]));
                    if (frmWW.ShowDialog() == DialogResult.OK)
                        btnQuery_Click(null, null);
                }
                else
                {
                    //if (MessageHandler.ShowMessageBox_YesNo(string.Format("确定要审批当前选中的{0}条记录吗？", count)) != DialogResult.Yes)
                    if (MessageHandler.ShowMessageBox_YesNo(string.Format(f.tsmiQdyspxzd + "{0}" + f.tsmiTjlm.Text, count)) != DialogResult.Yes)
                    {
                        return;
                    }

                    int successCountInt = 0;
                    //直接审批，不再谈页面
                    if (!wwDAO.WWApprovalInfo_Multi(dataSet_WW.Tables[0], ref successCountInt))
                        btnQuery_Click(null, null);
                    else
                    {
                        //MessageHandler.ShowMessageBox(string.Format("成功审批了{0}条记录。", successCountInt));
                        MessageHandler.ShowMessageBox(string.Format(f.tsmiCgspl.Text + "{0}" + f.tsmiTjl.Text, successCountInt));
                    }
                }
                ClearHeadGridAllSelect();
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
                int count = dataSet_WW.Tables[0].Select("select=1").Length;
                if (count == 0)
                {
                    MessageHandler.ShowMessageBox(f.tsmiQzyczdjlq.Text);// ("请在要操作的记录前面选中。");
                    return;
                }

                if (!CheckWarehouseState_Multi(true, false, true, false))
                    return;

                //if (MessageHandler.ShowMessageBox_YesNo(string.Format("确定要取消审批当前选中的{0}条记录吗？", count)) != DialogResult.Yes)
                if (MessageHandler.ShowMessageBox_YesNo(string.Format(f.tsmiQdyqxspdq.Text + "{0}" + f.tsmiTjlm.Text, count)) != DialogResult.Yes)
                {
                    return;
                }

                if (!wwDAO.CancalWWApprovalInfo_Multi(dataSet_WW.Tables[0]))
                    btnQuery_Click(null, null);
                else
                {
                    //MessageHandler.ShowMessageBox(string.Format("成功取消审批了{0}条记录。", count));
                    MessageHandler.ShowMessageBox(string.Format(f.tsmiCgqxspl.Text + "{0}" + f.tsmiTjl.Text, count));
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
        /// 预览按钮事件
        /// </summary>
        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                string wwHeadNoStr = "";
                if (gridViewWWHead.GetFocusedDataRow() != null)
                    wwHeadNoStr = DataTypeConvert.GetString(gridViewWWHead.GetFocusedDataRow()["WarehouseWarrant"]);
                wwDAO.PrintHandle(wwHeadNoStr, 1);
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--预览按钮事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiYlansjcw.Text, ex);
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
            foreach (DataRow dr in dataSet_WW.Tables[0].Rows)
            {
                dr["Select"] = value;
            }
            onlySelectColChangeRowState = true;
        }

        /// <summary>
        /// 删除子表中的一行
        /// </summary>
        private void repbtnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                int poListAutoIdInt = 0;
                if (gridViewWWList.GetFocusedDataRow() != null)
                    poListAutoIdInt = DataTypeConvert.GetInt(gridViewWWList.GetFocusedDataRow()["PoListAutoId"]);
                gridViewWWList.DeleteRow(gridViewWWList.FocusedRowHandle);
                if (poListAutoIdInt > 0)
                    gridViewOrderHead_FocusedRowChanged(sender, null);
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--删除子表中的一行错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiSczbzyhcw.Text, ex);
            }
        }

        /// <summary>
        /// 子表单元格值变化进行的操作
        /// </summary>
        private void gridViewWWList_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            try
            {
                switch (e.Column.FieldName)
                {
                    case "CodeFileName":
                        string tmpStr = DataTypeConvert.GetString(gridViewWWList.GetDataRow(e.RowHandle)["CodeFileName"]);
                        if (tmpStr == "")
                            gridViewWWList.SetRowCellValue(e.RowHandle, "CodeName", "");
                        else
                        {
                            DataTable temp = (DataTable)repSearchCodeFileName.DataSource;
                            DataRow[] drs = temp.Select(string.Format("CodeFileName='{0}'", tmpStr));
                            if (drs.Length > 0)
                            {
                                gridViewWWList.SetRowCellValue(e.RowHandle, "CodeName", DataTypeConvert.GetString(drs[0]["CodeName"]));
                            }
                        }
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
            if (DataTypeConvert.GetBoolean(gridViewWWHead.GetFocusedDataRow()["Select"]))
                gridViewWWHead.GetFocusedDataRow()["Select"] = false;
            else
                gridViewWWHead.GetFocusedDataRow()["Select"] = true;
            onlySelectColChangeRowState = true;
        }

        /// <summary>
        /// 鼠标操作明细行事件
        /// </summary>
        private void gridViewWWList_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (btnOrderApply.Enabled)
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
        /// 查询明细的上一级采购单
        /// </summary>
        private void barButtonUp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (gridViewWWList.GetFocusedDataRow() != null)
                {
                    string orderHeadNoStr = DataTypeConvert.GetString(gridViewWWList.GetFocusedDataRow()["OrderHeadNo"]);
                    int poListAutoId = DataTypeConvert.GetInt(gridViewWWList.GetFocusedDataRow()["PoListAutoId"]);
                    if (orderHeadNoStr == "" || poListAutoId == 0)
                        return;
                    FrmOrder.queryOrderHeadNo = orderHeadNoStr;
                    FrmOrder.queryListAutoId = poListAutoId;
                    ViewHandler.ShowRightWindow("FrmOrder");
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--查询明细的上一级采购单错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiCxmxdsyjcgdcw.Text, ex);
            }
        }

        /// <summary>
        /// 查询明细的下一级采购结账单
        /// </summary>
        private void barButtonDown_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (gridViewWWList.GetFocusedDataRow() != null)
                {
                    int autoIdInt = DataTypeConvert.GetInt(gridViewWWList.GetFocusedDataRow()["AutoId"]);
                    FrmSettlementQuery.wwListAutoId = autoIdInt;
                    ViewHandler.ShowRightWindow("FrmSettlementQuery");
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--查询明细的下一级采购结账单错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiCxmxdxyjcgjzdcw.Text, ex);
            }
        }

        /// <summary>
        /// 检查是否有未填写字段
        /// </summary>
        private bool IsHaveBlankLine()
        {
            gridViewWWList.FocusedRowHandle = 0;
            for (int i = 0; i < gridViewWWList.DataRowCount; i++)
            {
                if (DataTypeConvert.GetString(gridViewWWList.GetDataRow(i)["CodeFileName"]) == "")
                {
                    gridViewWWList.Focus();
                    gridViewWWList.FocusedColumn = colCodeFileName;
                    gridViewWWList.FocusedRowHandle = i;
                    return true;
                }
                if (DataTypeConvert.GetString(gridViewWWList.GetDataRow(i)["Qty"]) == "")
                {
                    gridViewWWList.Focus();
                    gridViewWWList.FocusedColumn = colQty;
                    gridViewWWList.FocusedRowHandle = i;
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
                btnOrderApply.Enabled = false;
                btnSave.Tag = "保存";
                btnSave.Text = f.tsmiBc.Text;
                btnCancel.Enabled = true;
                btnDelete.Enabled = false;
            }
            else
            {
                btnOrderApply.Enabled = true;
                btnSave.Tag = "修改";
                btnSave.Text = f.tsmiXg.Text;
                btnCancel.Enabled = false;
                btnDelete.Enabled = true;
            }
            btnApprove.Enabled = !ret;
            btnCancelApprove.Enabled = !ret;
            btnPreview.Enabled = !ret;

            if (SystemInfo.WarehouseWarrantIsAlterDate)
            {
                colWarehouseWarrantDate.OptionsColumn.AllowEdit = ret;
                colWarehouseWarrantDate.OptionsColumn.AllowFocus = ret;
            }

            colRepertoryNo.OptionsColumn.AllowEdit = ret;
            colWarehouseWarrantTypeNo.OptionsColumn.AllowEdit = ret;
            colApprovalType.OptionsColumn.AllowEdit = ret;
            colRemark1.OptionsColumn.AllowEdit = ret;

            colQty.OptionsColumn.AllowEdit = ret;
            colPrReqListRemark.OptionsColumn.AllowEdit = ret;
            colShelfId.OptionsColumn.AllowEdit = ret;

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
        /// 检测入库单状态是否可以操作
        /// </summary>
        private bool CheckWarehouseState()
        {
            if (gridViewWWHead.GetFocusedDataRow() == null)
                return false;
            int reqState = DataTypeConvert.GetInt(gridViewWWHead.GetFocusedDataRow()["WarehouseState"]);
            switch (reqState)
            {
                case 2:
                    //MessageHandler.ShowMessageBox(string.Format("入库单[{0}]已经审批，不可以操作。", DataTypeConvert.GetString(gridViewWWHead.GetFocusedDataRow()["WarehouseWarrant"])));
                    MessageHandler.ShowMessageBox(string.Format(f.tsmiRkd.Text + "[{0}]" + f.tsmiYjspbkycz.Text, DataTypeConvert.GetString(gridViewWWHead.GetFocusedDataRow()["WarehouseWarrant"])));
                    return false;
                case 3:
                    //MessageHandler.ShowMessageBox(string.Format("入库单[{0}]已经结账，不可以操作。", DataTypeConvert.GetString(gridViewWWHead.GetFocusedDataRow()["WarehouseWarrant"])));
                    MessageHandler.ShowMessageBox(string.Format(f.tsmiRkd.Text + "[{0}]" + f.tsmiYjjzbkycz.Text, DataTypeConvert.GetString(gridViewWWHead.GetFocusedDataRow()["WarehouseWarrant"])));
                    return false;
                case 4:
                    //MessageHandler.ShowMessageBox(string.Format("入库单[{0}]已经审批中，不可以操作。", DataTypeConvert.GetString(gridViewWWHead.GetFocusedDataRow()["WarehouseWarrant"])));
                    MessageHandler.ShowMessageBox(string.Format(f.tsmiRkd.Text + "[{0}]" + f.tsmiYjspzbkycz.Text, DataTypeConvert.GetString(gridViewWWHead.GetFocusedDataRow()["WarehouseWarrant"])));
                    return false;
            }
            return true;
        }

        /// <summary>
        /// 检测当前选中的入库单状态是否可以操作
        /// </summary>
        private bool CheckWarehouseState_Multi(bool checkNoApprover, bool checkApprover, bool checkSettle, bool checkApproverBetween)
        {
            for (int i = 0; i < gridViewWWHead.DataRowCount; i++)
            {
                if (DataTypeConvert.GetBoolean(gridViewWWHead.GetDataRow(i)["Select"]))
                {
                    int reqState = DataTypeConvert.GetInt(gridViewWWHead.GetDataRow(i)["WarehouseState"]);
                    switch (reqState)
                    {
                        case 1:
                            if (checkNoApprover)
                            {
                                //MessageHandler.ShowMessageBox(string.Format("入库单[{0}]未审批，不可以操作。", DataTypeConvert.GetString(gridViewWWHead.GetDataRow(i)["WarehouseWarrant"])));
                                MessageHandler.ShowMessageBox(string.Format(f.tsmiRkd.Text + "[{0}]" + f.tsmiWspbkycz.Text, DataTypeConvert.GetString(gridViewWWHead.GetDataRow(i)["WarehouseWarrant"])));

                                gridViewWWHead.FocusedRowHandle = i;
                                return false;
                            }
                            break;
                        case 2:
                            if (checkApprover)
                            {
                                //MessageHandler.ShowMessageBox(string.Format("入库单[{0}]已经审批，不可以操作。", DataTypeConvert.GetString(gridViewWWHead.GetDataRow(i)["WarehouseWarrant"])));
                                MessageHandler.ShowMessageBox(string.Format(f.tsmiRkd.Text + "[{0}]" + f.tsmiYjspbkycz.Text, DataTypeConvert.GetString(gridViewWWHead.GetDataRow(i)["WarehouseWarrant"])));
                                gridViewWWHead.FocusedRowHandle = i;
                                return false;
                            }
                            break;
                        case 3:
                            if (checkSettle)
                            {
                                //MessageHandler.ShowMessageBox(string.Format("入库单[{0}]已经结账，不可以操作。", DataTypeConvert.GetString(gridViewWWHead.GetDataRow(i)["WarehouseWarrant"])));
                                MessageHandler.ShowMessageBox(string.Format(f.tsmiRkd.Text + "[{0}]" + f.tsmiYjjzbkycz.Text, DataTypeConvert.GetString(gridViewWWHead.GetDataRow(i)["WarehouseWarrant"])));
                                gridViewWWHead.FocusedRowHandle = i;
                                return false;
                            }
                            break;
                        case 4:
                            if (checkApproverBetween)
                            {
                                //MessageHandler.ShowMessageBox(string.Format("入库单[{0}]已经审批中，不可以操作。", DataTypeConvert.GetString(gridViewWWHead.GetDataRow(i)["WarehouseWarrant"])));
                                MessageHandler.ShowMessageBox(string.Format(f.tsmiRkd.Text + "[{0}]" + f.tsmiYjspzbkycz.Text, DataTypeConvert.GetString(gridViewWWHead.GetDataRow(i)["WarehouseWarrant"])));
                                gridViewWWHead.FocusedRowHandle = i;
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
            gridControlWWHead.Focus();
            ColumnView headView = (ColumnView)gridControlWWHead.FocusedView;
            headView.FocusedColumn = headView.Columns[colName];
            gridViewWWHead.FocusedRowHandle = headView.FocusedRowHandle;
        }

        /// <summary>
        /// 聚焦子表当前行的列
        /// </summary>
        private void FocusedListView(bool isFocusedControl, string colName, int lineNo)
        {
            if (isFocusedControl)
                gridControlWWList.Focus();
            ColumnView listView = (ColumnView)gridControlWWList.FocusedView;
            listView.FocusedColumn = listView.Columns[colName];
            gridViewWWList.FocusedRowHandle = lineNo;
        }

        /// <summary>
        /// 清楚当前的所有选择
        /// </summary>
        private void ClearHeadGridAllSelect()
        {
            checkAll.Checked = false;
            for (int i = 0; i < dataSet_WW.Tables[0].Rows.Count; i++)
            {
                dataSet_WW.Tables[0].Rows[i]["Select"] = false;
            }
            dataSet_WW.Tables[0].AcceptChanges();
            onlySelectColChangeRowState = false;
        }

        /// <summary>
        /// 采购订单转成入库单
        /// </summary>
        /// <param name="orderHeadRow"></param>
        /// <param name="orderListTable"></param>
        private void POToWW_Order(DataRow orderHeadRow, DataTable orderListTable)
        {
            ClearHeadGridAllSelect();
            gridViewWWHead.AddNewRow();
            FocusedHeadView("RepertoryNo");

            gridViewWWHead.SetFocusedRowCellValue("WarehouseWarrantDate", BaseSQL.GetServerDateTime());
            gridViewWWHead.SetFocusedRowCellValue("BussinessBaseNo", orderHeadRow["BussinessBaseNo"]);
            gridViewWWHead.SetFocusedRowCellValue("ReqDep", SystemInfo.user.DepartmentNo);
            gridViewWWHead.SetFocusedRowCellValue("WarehouseWarrantTypeNo", wwDAO.Get_WarehouseType_TypeNo("BS_WarehouseWarrantType", "WarehouseWarrantTypeNo"));
            gridViewWWHead.SetFocusedRowCellValue("Prepared", SystemInfo.user.EmpName);
            gridViewWWHead.SetFocusedRowCellValue("WarehouseState", 1);

            dataSet_WW.Tables[1].Clear();
            foreach (DataRow dr in orderListTable.Rows)
            {
                if (DataTypeConvert.GetBoolean(dr["ListSelect"]))
                {
                    gridViewWWList.AddNewRow();
                    gridViewWWList.SetFocusedRowCellValue("WarehouseWarrant", gridViewWWHead.GetFocusedDataRow()["WarehouseWarrant"]);
                    gridViewWWList.SetFocusedRowCellValue("CodeFileName", dr["CodeFileName"]);
                    gridViewWWList.SetFocusedRowCellValue("CodeName", dr["CodeName"]);
                    gridViewWWList.SetFocusedRowCellValue("Qty", DataTypeConvert.GetDouble(dr["Overplus"]));
                    gridViewWWList.SetFocusedRowCellValue("ProjectName", orderHeadRow["ProjectName"]);
                    gridViewWWList.SetFocusedRowCellValue("StnNo", orderHeadRow["StnNo"]);
                    gridViewWWList.SetFocusedRowCellValue("PoListAutoId", dr["AutoId"]);
                    gridViewWWList.SetFocusedRowCellValue("OrderHeadNo", orderHeadRow["OrderHeadNo"]);
                }
            }
            FocusedListView(false, "Qty", gridViewWWList.GetFocusedDataSourceRowIndex());
            gridViewWWList.RefreshData();

            SetButtonAndColumnState(true);
            headFocusedLineNo = gridViewWWHead.DataRowCount;
        }

        #endregion

        #region 左侧采购订单模块的相关事件和方法

        /// <summary>
        /// 查询采购订单事件
        /// </summary>
        private void btnOrderQuery_Click(object sender, EventArgs e)
        {
            try
            {
                if (dateOrderDateBegin.EditValue == null || dateOrderDateEnd.EditValue == null)
                {
                    MessageHandler.ShowMessageBox(tsmiDgrqbnwkcx.Text);// ("订购日期不能为空，请设置后重新进行查询。");
                    if (dateOrderDateBegin.EditValue == null)
                        dateOrderDateBegin.Focus();
                    else
                        dateOrderDateEnd.Focus();
                    return;
                }
                string orderHeadNoStr = textOrderHeadNo.Text.Trim();
                string orderDateBeginStr = dateOrderDateBegin.DateTime.ToString("yyyy-MM-dd");
                string orderDateEndStr = dateOrderDateEnd.DateTime.AddDays(1).ToString("yyyy-MM-dd");
                string projectNoStr = searchLookUpProjectNo.Text != "全部" ? DataTypeConvert.GetString(searchLookUpProjectNo.EditValue) : "";

                dataSet_Order.Tables[0].Clear();
                dataSet_Order.Tables[1].Clear();
                applyDAO.QueryOrderHead(dataSet_Order.Tables[0], orderHeadNoStr, orderDateBeginStr, orderDateEndStr, "", "", "", projectNoStr, "", "");
                //if (orderHeadNoStr != "" && dataSet_Order.Tables[0].Rows.Count > 0)
                //    textOrderHeadNo.Text = "";
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--查询采购订单事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiCxcgddsjcw.Text, ex);
            }
        }

        /// <summary>
        /// 聚焦查询采购订单明细事件
        /// </summary>
        private void gridViewOrderHead_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            try
            {
                if (gridViewOrderHead.GetFocusedDataRow() != null && sender != null)
                {
                    dataSet_Order.Tables[1].Clear();
                    applyDAO.QueryOrderList(dataSet_Order.Tables[1], DataTypeConvert.GetString(gridViewOrderHead.GetFocusedDataRow()["OrderHeadNo"]));
                    ClearAlreadyDragOrderList();
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--聚焦查询采购订单明细事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiJjcxcgddmxsjcw.Text, ex);
            }
        }

        #region 拖出

        /// <summary>
        /// 在GridView中按下鼠标事件
        /// </summary>
        private void gridViewOrderList_MouseDown(object sender, MouseEventArgs e)
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
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiZgridviewzaxsbsjcw.Text, ex);
            }
        }

        /// <summary>
        /// 在GridView中移动鼠标事件
        /// </summary>
        private void gridViewOrderList_MouseMove(object sender, MouseEventArgs e)
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
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiZgridviewzaxsbsjcw.Text, ex);
            }
        }

        #endregion

        #region 拖入

        /// <summary>
        /// 拖拽在GridControl上面
        /// </summary>
        private void gridControlWWList_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<DataRow>)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        /// <summary>
        /// 拖拽进入到GridControl控件
        /// </summary>
        private void gridControlWWList_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        /// <summary>
        /// 实现拖拽采购订单事件
        /// </summary>
        private void gridControlWWList_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                List<DataRow> drs = e.Data.GetData(typeof(List<DataRow>)) as List<DataRow>;
                if (drs != null)
                {
                    POToWW_DragOrder(sender, drs);
                    ClearAlreadyDragOrderList();
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--实现拖拽采购订单事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiSxtzcgddsjcw.Text, ex);
            }
        }

        /// <summary>
        /// 拖拽采购订单转成入库单 
        /// </summary>
        private void POToWW_DragOrder(object sender, List<DataRow> drs)
        {
            DataRow headRow = gridViewOrderHead.GetFocusedDataRow();

            if (btnApprove.Enabled)
            {
                ClearHeadGridAllSelect();
                gridViewWWHead.AddNewRow();
                FocusedHeadView("RepertoryNo");

                gridViewWWHead.SetFocusedRowCellValue("WarehouseWarrantDate", BaseSQL.GetServerDateTime());
                gridViewWWHead.SetFocusedRowCellValue("ReqDep", SystemInfo.user.DepartmentNo);
                gridViewWWHead.SetFocusedRowCellValue("WarehouseWarrantTypeNo", wwDAO.Get_WarehouseType_TypeNo("BS_WarehouseWarrantType", "WarehouseWarrantTypeNo"));
                gridViewWWHead.SetFocusedRowCellValue("Prepared", SystemInfo.user.EmpName);
                gridViewWWHead.SetFocusedRowCellValue("WarehouseState", 1);

                gridViewWWHead.SetFocusedRowCellValue("BussinessBaseNo", headRow["BussinessBaseNo"]);

                dataSet_WW.Tables[1].Clear();
                foreach (DataRow dr in drs)
                {
                    gridViewWWList.AddNewRow();
                    gridViewWWList.SetFocusedRowCellValue("WarehouseWarrant", gridViewWWHead.GetFocusedDataRow()["WarehouseWarrant"]);
                    gridViewWWList.SetFocusedRowCellValue("CodeFileName", dr["CodeFileName"]);
                    gridViewWWList.SetFocusedRowCellValue("CodeName", dr["CodeName"]);
                    gridViewWWList.SetFocusedRowCellValue("Qty", DataTypeConvert.GetDouble(dr["Overplus"]));
                    gridViewWWList.SetFocusedRowCellValue("ProjectName", headRow["ProjectName"]);
                    gridViewWWList.SetFocusedRowCellValue("StnNo", headRow["StnNo"]);
                    gridViewWWList.SetFocusedRowCellValue("PoListAutoId", dr["AutoId"]);
                    gridViewWWList.SetFocusedRowCellValue("OrderHeadNo", headRow["OrderHeadNo"]);
                }
                FocusedListView(false, "Qty", gridViewWWList.GetFocusedDataSourceRowIndex());
                gridViewWWList.RefreshData();

                SetButtonAndColumnState(true);
                headFocusedLineNo = gridViewWWHead.DataRowCount;
            }
            else
            {
                if (dataSet_WW.Tables[1].Rows.Count > 0)
                {
                    if (DataTypeConvert.GetString(dataSet_WW.Tables[1].Rows[0]["ProjectName"]) != DataTypeConvert.GetString(headRow["ProjectName"]))
                    {
                        MessageHandler.ShowMessageBox(tsmiYzrkdzrxxtdxmhjxdj.Text);// ("一张入库单只允许相同的项目号进行登记。");
                        return;
                    }
                }
                if (DataTypeConvert.GetString(gridViewWWHead.GetFocusedDataRow()["BussinessBaseNo"]) != DataTypeConvert.GetString(headRow["BussinessBaseNo"]))
                {
                    MessageHandler.ShowMessageBox(tsmiYzrkdzrxxtdgysjxdj.Text);// ("一张入库单只允许相同的供应商进行登记。");
                    return;
                }

                foreach (DataRow dr in drs)
                {
                    if (dataSet_WW.Tables[1].Select(string.Format("PoListAutoId={0}", DataTypeConvert.GetString(dr["AutoId"]))).Length > 0)
                        continue;
                    gridViewWWList.AddNewRow();
                    gridViewWWList.SetFocusedRowCellValue("WarehouseWarrant", gridViewWWHead.GetFocusedDataRow()["WarehouseWarrant"]);
                    gridViewWWList.SetFocusedRowCellValue("CodeFileName", dr["CodeFileName"]);
                    gridViewWWList.SetFocusedRowCellValue("CodeName", dr["CodeName"]);
                    gridViewWWList.SetFocusedRowCellValue("Qty", DataTypeConvert.GetDouble(dr["Overplus"]));
                    gridViewWWList.SetFocusedRowCellValue("ProjectName", headRow["ProjectName"]);
                    gridViewWWList.SetFocusedRowCellValue("StnNo", headRow["StnNo"]);
                    gridViewWWList.SetFocusedRowCellValue("PoListAutoId", dr["AutoId"]);
                    gridViewWWList.SetFocusedRowCellValue("OrderHeadNo", headRow["OrderHeadNo"]);
                }

                gridViewWWList.FocusedRowHandle = gridViewWWList.DataRowCount;
                FocusedListView(false, "Qty", gridViewWWList.GetFocusedDataSourceRowIndex());
                gridViewWWList.RefreshData();
            }
        }

        #endregion

        /// <summary>
        /// 清空已经拖拽的采购订单明细
        /// </summary>
        private void ClearAlreadyDragOrderList()
        {
            for (int i = dataSet_Order.Tables[1].Rows.Count - 1; i >= 0; i--)
            {
                if (dataSet_WW.Tables[1].Select(string.Format("PoListAutoId={0}", DataTypeConvert.GetString(dataSet_Order.Tables[1].Rows[i]["AutoId"]))).Length > 0)
                    dataSet_Order.Tables[1].Rows.RemoveAt(i);
            }
        }

        #endregion


    }
}
