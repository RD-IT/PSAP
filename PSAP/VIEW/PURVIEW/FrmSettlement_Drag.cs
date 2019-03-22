using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using PSAP.DAO.BSDAO;
using PSAP.DAO.INVDAO;
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
    public partial class FrmSettlement_Drag : DockContent
    {
        #region 私有变量

        FrmSettlementDAO setDAO = new FrmSettlementDAO();
        FrmCommonDAO commonDAO = new FrmCommonDAO();
        FrmWarehouseWarrantApplyDAO applyDAO = new FrmWarehouseWarrantApplyDAO();

        /// <summary>
        /// 主表聚焦的行号
        /// </summary>
        int headFocusedLineNo = 0;

        /// <summary>
        /// 查询的结账单号
        /// </summary>
        public static string querySettlementNo = "";

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

        public FrmSettlement_Drag()
        {
            InitializeComponent();
            PSAP.BLL.BSBLL.BSBLL.language(this);
        }

        #endregion

        #region 窗体事件

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmSettlement_Drag_Load(object sender, EventArgs e)
        {
            try
            {
                ControlHandler.DevExpressStyle_ChangeControlLocation(checkAll.LookAndFeel.ActiveSkinName, new List<Control> { checkAll });

                DateTime nowDate = BaseSQL.GetServerDateTime();
                dateSettlementDateBegin.DateTime = nowDate.Date.AddDays(-SystemInfo.OrderQueryDate_DefaultDays);
                dateSettlementDateEnd.DateTime = nowDate.Date;
                datePayDateBegin.DateTime = nowDate.Date;
                datePayDateEnd.DateTime = nowDate.Date.AddDays(SystemInfo.OrderQueryDate_DefaultDays);
                checkPayDate.Checked = false;

                searchLookUpBussinessBaseNo.Properties.DataSource = commonDAO.QueryBussinessBaseInfo(true);
                searchLookUpBussinessBaseNo.Text = "全部";
                lookUpReqDep.Properties.DataSource = commonDAO.QueryDepartment(true);
                lookUpReqDep.ItemIndex = 0;
                comboBoxWarehouseState.SelectedIndex = 0;
                lookUpPrepared.Properties.DataSource = commonDAO.QueryUserInfo(true);
                lookUpPrepared.EditValue = SystemInfo.user.EmpName;
                
                lookUpApprover.Properties.DataSource = commonDAO.QueryUserInfo(true);
                lookUpApprover.ItemIndex = -1;

                repSearchBussinessBaseNo.DataSource = commonDAO.QueryBussinessBaseInfo(false);
                repLookUpReqDep.DataSource = commonDAO.QueryDepartment(false);               
                repLookUpApprovalType.DataSource = commonDAO.QueryApprovalType(false);

                repSearchCodeFileName.DataSource = commonDAO.QueryPartsCode(false);

                dateWWDateBegin.DateTime = dateSettlementDateBegin.DateTime;
                dateWWDateEnd.DateTime = dateSettlementDateEnd.DateTime;
                searchLookUpProjectNo.Properties.DataSource = commonDAO.QueryProjectList(true);
                searchLookUpProjectNo.Text = "全部";

                repLookUpWWReqDep.DataSource = commonDAO.QueryDepartment(false);
                repLookUpWWRepertoryNo.DataSource = commonDAO.QueryRepertoryInfo(false);
                repLookUpWWTypeNo.DataSource = new FrmWarehouseWarrantDAO().QueryWarehouseWarrantType(false);
                repSearchWWBussinessBaseNo.DataSource = commonDAO.QueryBussinessBaseInfo(false);

                repSearchShelfId.DataSource = commonDAO.QueryShelfInfo(false);

                if (textCommon.Text == "")
                {
                    setDAO.QuerySettlementHead(dataSet_Settlement.Tables[0], "", "", "", "", "", "", 0, "", -1, "", true);
                    setDAO.QuerySettlementList(dataSet_Settlement.Tables[1], "", true);
                }                
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+tsmiCtjzsj.Text , ex);

            }
        }

        /// <summary>
        /// 窗体激活事件
        /// </summary>
        private void FrmSettlement_Drag_Activated(object sender, EventArgs e)
        {
            try
            {
                if (querySettlementNo != "")
                {
                    textCommon.Text = querySettlementNo;
                    querySettlementNo = "";
                    lookUpReqDep.ItemIndex = 0;
                    searchLookUpBussinessBaseNo.Text = "全部";
                    comboBoxWarehouseState.SelectedIndex = 0;
                    lookUpPrepared.ItemIndex = 0;
                    lookUpApprover.ItemIndex = -1;
                    checkPayDate.Checked = false;

                    dataSet_Settlement.Tables[0].Clear();
                    headFocusedLineNo = 0;
                    setDAO.QuerySettlementHead(dataSet_Settlement.Tables[0], "", "", "", "", "", "", 0, "", -1, textCommon.Text, false);
                    SetButtonAndColumnState(false);

                    if (dataSet_Settlement.Tables[0].Rows.Count > 0)
                    {
                        dateSettlementDateBegin.DateTime = DataTypeConvert.GetDateTime(dataSet_Settlement.Tables[0].Rows[0]["SettlementDate"]).Date;
                        dateSettlementDateEnd.DateTime = dateSettlementDateBegin.DateTime.AddDays(7);
                    }
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--窗体激活事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+tsmiCtjh.Text , ex);
            }
        }

        /// <summary>
        /// 窗体显示事件
        /// </summary>
        private void FrmSettlement_Drag_Shown(object sender, EventArgs e)
        {
            pnlMiddle.Height = (this.Height - pnltop.Height) / 2;
            pnlLeftMiddle.Height = gridControlSettlementHead.Height + 2;

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
                if (dateSettlementDateBegin.EditValue == null || dateSettlementDateEnd.EditValue == null)
                {
                    //MessageHandler.ShowMessageBox("结账日期不能为空，请设置后重新进行查询。");
                    MessageHandler.ShowMessageBox(tsmiJzribn.Text);
                    if (dateSettlementDateBegin.EditValue == null)
                        dateSettlementDateBegin.Focus();
                    else
                        dateSettlementDateEnd.Focus();
                    return;
                }
                string orderDateBeginStr = dateSettlementDateBegin.DateTime.ToString("yyyy-MM-dd");
                string orderDateEndStr = dateSettlementDateEnd.DateTime.AddDays(1).ToString("yyyy-MM-dd");
                string payDateBeginStr = "";
                string payDateEndStr = "";
                if (checkPayDate.Checked)
                {
                    if (datePayDateBegin.EditValue == null || datePayDateEnd.EditValue == null)
                    {
                        //MessageHandler.ShowMessageBox("付款日期不能为空，请设置后重新进行查询。");
                        MessageHandler.ShowMessageBox(tsmiFkrqbn.Text );
                        if (datePayDateBegin.EditValue == null)
                            datePayDateBegin.Focus();
                        else
                            datePayDateEnd.Focus();
                        return;
                    }
                    payDateBeginStr = datePayDateBegin.DateTime.ToString("yyyy-MM-dd");
                    payDateEndStr = datePayDateEnd.DateTime.AddDays(1).ToString("yyyy-MM-dd");
                }

                string bussinessBaseNoStr = DataTypeConvert.GetString(searchLookUpBussinessBaseNo.EditValue) != "全部" ? DataTypeConvert.GetString(searchLookUpBussinessBaseNo.EditValue) : "";
                string reqDepStr = lookUpReqDep.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpReqDep.EditValue) : "";
                int wStateInt = CommonHandler.Get_WarehouseState_No(comboBoxWarehouseState.Text); 
                string empNameStr = lookUpPrepared.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpPrepared.EditValue) : "";
                int approverInt = -1;
                if (lookUpApprover.ItemIndex == 0)
                    approverInt = 0;
                else if (lookUpApprover.ItemIndex > 0)
                    approverInt = DataTypeConvert.GetInt(lookUpApprover.EditValue);
                string commonStr = textCommon.Text.Trim();
                dataSet_Settlement.Tables[0].Clear();
                dataSet_Settlement.Tables[1].Clear();
                headFocusedLineNo = 0;
                setDAO.QuerySettlementHead(dataSet_Settlement.Tables[0], orderDateBeginStr, orderDateEndStr, payDateBeginStr, payDateEndStr, reqDepStr, bussinessBaseNoStr, wStateInt, empNameStr, approverInt, commonStr, false);

                SetButtonAndColumnState(false);
                checkAll.Checked = false;
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--查询按钮事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+tsmiCxansj.Text, ex);
            }
        }

        /// <summary>
        /// 主表聚焦行改变事件
        /// </summary>
        private void gridViewSettlementHead_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            try
            {
                if (gridViewSettlementHead.GetFocusedDataRow() != null)
                {
                    if (onlySelectColChangeRowState)
                    {
                        dataSet_Settlement.Tables[0].AcceptChanges();
                        onlySelectColChangeRowState = false;
                    }
                    else
                    {
                        if (headFocusedLineNo < gridViewSettlementHead.DataRowCount && gridViewSettlementHead.FocusedRowHandle != headFocusedLineNo && gridViewSettlementHead.GetDataRow(headFocusedLineNo).RowState != DataRowState.Unchanged)
                        {
                            //MessageHandler.ShowMessageBox("当前采购结账单已经修改，请保存后再进行换行。");
                            MessageHandler.ShowMessageBox(tsmiDqcgjzd.Text );
                            gridViewSettlementHead.FocusedRowHandle = headFocusedLineNo;
                        }
                        else if (headFocusedLineNo == gridViewSettlementHead.DataRowCount)
                        {

                        }
                        else
                        {
                            if (gridViewSettlementHead.FocusedRowHandle != headFocusedLineNo && gridViewSettlementHead.GetDataRow(headFocusedLineNo).RowState != DataRowState.Unchanged)
                                btnCancel_Click(null, null);
                            else if (gridViewSettlementHead.GetDataRow(headFocusedLineNo).RowState == DataRowState.Unchanged)
                                btnCancel_Click(null, null);
                        }
                    }

                    if (DataTypeConvert.GetString(gridViewSettlementHead.GetFocusedDataRow()["SettlementNo"]) != "")
                    {
                        dataSet_Settlement.Tables[1].Clear();
                        setDAO.QuerySettlementList(dataSet_Settlement.Tables[1], DataTypeConvert.GetString(gridViewSettlementHead.GetFocusedDataRow()["SettlementNo"]), false);
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

                    if (gridViewSettlementHead.FocusedRowHandle >= 0)
                    {
                        headFocusedLineNo = gridViewSettlementHead.FocusedRowHandle;
                    }
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--主表聚焦行改变事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+tsmiZbjjhg.Text , ex);
            }
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewSettlementHead_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
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
        private void gridViewSettlementHead_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "WarehouseState")
            {
                e.DisplayText = CommonHandler.Get_WarehouseState_Desc(e.Value.ToString());
            }
        }

        /// <summary>
        /// 选择付款日期
        /// </summary>
        private void checkPayDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPayDate.Checked)
            {
                datePayDateBegin.Enabled = true;
                datePayDateEnd.Enabled = true;
            }
            else
            {
                datePayDateBegin.Enabled = false;
                datePayDateEnd.Enabled = false;
            }
        }
        /// <summary>
        /// 保存按钮事件
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridViewSettlementHead.GetFocusedDataRow() == null)
                    return;

                if (!CheckWarehouseState())
                    return;

                if (btnSave.Tag.ToString() != "保存")
                {
                    ClearHeadGridAllSelect();

                    SetButtonAndColumnState(true);
                    FocusedHeadView("InvoiceNo");
                }
                else
                {
                    DataRow headRow = gridViewSettlementHead.GetFocusedDataRow();
                    if (DataTypeConvert.GetString(headRow["BussinessBaseNo"]) == "")
                    {
                        MessageHandler.ShowMessageBox(tsmiWlfbnwk.Text );//("往来方不能为空，请填写后再进行保存。");
                        FocusedHeadView("BussinessBaseNo");
                        return;
                    }
                    if (DataTypeConvert.GetString(headRow["ReqDep"]) == "")
                    {
                        MessageHandler.ShowMessageBox(tsmiRkbm.Text ); // ("入库部门不能为空，请填写后再进行保存。");
                        FocusedHeadView("ReqDep");
                        return;
                    }
                    if (DataTypeConvert.GetString(headRow["ApprovalType"]) == "")
                    {
                        MessageHandler.ShowMessageBox(tsmiSplx.Text );// ("审批类型不能为空，请填写后再进行保存。");
                        FocusedHeadView("ApprovalType");
                        return;
                    }
                    if (DataTypeConvert.GetString(headRow["Tax"]) == "")
                    {
                        MessageHandler.ShowMessageBox(tsmiSlbn.Text );// ("税率不能为空，请填写后再进行保存。");
                        FocusedHeadView("Tax");
                        return;
                    }

                    if (DataTypeConvert.GetString(headRow["PayDate"]) == "")
                    {
                        MessageHandler.ShowMessageBox(tsmiFkrq.Text );// ("付款日期不能为空，请填写后再进行保存。");
                        FocusedHeadView("PayDate");
                        return;
                    }

                    for (int i = gridViewSettlementList.DataRowCount - 1; i >= 0; i--)
                    {
                        DataRow listRow = gridViewSettlementList.GetDataRow(i);
                        if (DataTypeConvert.GetString(listRow["Qty"]) == "" || DataTypeConvert.GetDouble(listRow["Qty"]) == 0)
                        {
                            MessageHandler.ShowMessageBox(tsmiSlbnwk.Text );// ("数量不能为空，请填写后再进行保存。");
                            FocusedListView(true, "Qty", i);
                            return;
                        }
                        if (DataTypeConvert.GetString(listRow["Unit"]) == "")
                        {
                            MessageHandler.ShowMessageBox(tsmiDjbnwk.Text );// ("单价不能为空，请填写后再进行保存。");
                            FocusedListView(true, "Unit", i);
                            return;
                        }
                        if (DataTypeConvert.GetString(listRow["Tax"]) == "")
                        {
                            MessageHandler.ShowMessageBox(tsmiSlbn.Text );// ("税率不能为空，请填写后再进行保存。");
                            FocusedListView(true, "Tax", i);
                            return;
                        }
                    }

                    int ret = setDAO.SaveSettlement(gridViewSettlementHead.GetFocusedDataRow(), dataSet_Settlement.Tables[1]);
                    switch (ret)
                    {
                        case -1:
                            btnQuery_Click(null, null);
                            break;
                        case 1:
                            dataSet_Settlement.Tables[1].Clear();
                            setDAO.QuerySettlementList(dataSet_Settlement.Tables[1], DataTypeConvert.GetString(gridViewSettlementHead.GetFocusedDataRow()["SettlementNo"]), false);
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
                ExceptionHandler.HandleException(this.Text + "--"+tsmiBcan.Text , ex);
            }
        }

        /// <summary>
        /// 取消按钮事件
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridViewSettlementHead.GetDataRow(headFocusedLineNo).RowState != DataRowState.Unchanged)
                {
                    if (DataTypeConvert.GetString(gridViewSettlementHead.GetDataRow(headFocusedLineNo)["SettlementNo"]) == "")
                    {
                        gridViewSettlementHead.DeleteRow(headFocusedLineNo);
                    }
                    else
                    {
                        gridViewSettlementHead.GetFocusedDataRow().RejectChanges();
                    }
                }

                SetButtonAndColumnState(false);

                dataSet_Settlement.Tables[1].Clear();
                if (gridViewSettlementHead.GetFocusedDataRow() != null)
                    setDAO.QuerySettlementList(dataSet_Settlement.Tables[1], DataTypeConvert.GetString(gridViewSettlementHead.GetFocusedDataRow()["SettlementNo"]), false);

                gridViewWWHead_FocusedRowChanged(sender, null);
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--取消按钮事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+tsmiQxan.Text , ex);
            }
        }

        /// <summary>
        /// 删除按钮事件
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int count = dataSet_Settlement.Tables[0].Select("select=1").Length;
                if (count == 0)
                {
                    MessageHandler.ShowMessageBox(tsmiQzycz.Text );// ("请在要操作的记录前面选中。");
                    return;
                }

                if (!CheckWarehouseState_Multi(false, true, true, true))
                    return;

                //if (MessageHandler.ShowMessageBox_YesNo(string.Format("确定要删除当前选中的{0}条记录吗？", count)) != DialogResult.Yes)
                if (MessageHandler.ShowMessageBox_YesNo(string.Format(tsmiQdysc.Text +"{0}"+tsmiTjlm.Text +"？", count)) != DialogResult.Yes)
                {
                    return;
                }
                if (!setDAO.DeleteSettlement_Multi(dataSet_Settlement.Tables[0]))
                    btnQuery_Click(null, null);

                btnQuery_Click(null, null);
                ClearHeadGridAllSelect();
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--删除按钮事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+tsmiScansj.Text , ex);
            }
        }

        /// <summary>
        /// 审批按钮事件
        /// </summary>
        private void btnApprove_Click(object sender, EventArgs e)
        {
            try
            {
                int count = dataSet_Settlement.Tables[0].Select("select=1").Length;
                if (count == 0)
                {
                    MessageHandler.ShowMessageBox(tsmiQzycz.Text );// ("请在要操作的记录前面选中。");
                    return;
                }

                if (!CheckWarehouseState_Multi(false, true, true, false))
                    return;

                if (count == 1)
                {
                    //弹出审批页面
                    FrmSettlementApproval frmSet = new FrmSettlementApproval(DataTypeConvert.GetString(dataSet_Settlement.Tables[0].Select("select=1")[0]["SettlementNo"]));
                    if (frmSet.ShowDialog() == DialogResult.OK)
                        btnQuery_Click(null, null);
                }
                else
                {
                    //if (MessageHandler.ShowMessageBox_YesNo(string.Format("确定要审批当前选中的{0}条记录吗？", count)) != DialogResult.Yes)
                    if (MessageHandler.ShowMessageBox_YesNo(string.Format(tsmiQdyspd.Text +"{0}"+tsmiTjlm.Text +"？", count)) != DialogResult.Yes)
                    {
                        return;
                    }

                    int successCountInt = 0;
                    //直接审批，不再谈页面
                    if (!setDAO.SettlementApprovalInfo_Multi(dataSet_Settlement.Tables[0], ref successCountInt))
                        btnQuery_Click(null, null);
                    else
                    {
                        //MessageHandler.ShowMessageBox(string.Format("成功审批了{0}条记录。", successCountInt));
                        MessageHandler.ShowMessageBox(string.Format(tsmiCgspl.Text +"{0}"+tsmiTjl.Text, successCountInt));
                    }
                }
                ClearHeadGridAllSelect();
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--审批按钮事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+tsmiSpansj.Text, ex);

            }
        }

        /// <summary>
        /// 取消审批按钮事件
        /// </summary>
        private void btnCancelApprove_Click(object sender, EventArgs e)
        {
            try
            {
                int count = dataSet_Settlement.Tables[0].Select("select=1").Length;
                if (count == 0)
                {
                    MessageHandler.ShowMessageBox(tsmiQzycz.Text );// ("请在要操作的记录前面选中。");
                    return;
                }

                if (!CheckWarehouseState_Multi(true, false, true, false))
                    return;

                //if (MessageHandler.ShowMessageBox_YesNo(string.Format("确定要取消审批当前选中的{0}条记录吗？", count)) != DialogResult.Yes)
                if (MessageHandler.ShowMessageBox_YesNo(string.Format(tsmiQdyqx.Text +"{0}"+tsmiTjlm.Text +"？", count)) != DialogResult.Yes)
                {
                    return;
                }

                if (!setDAO.CancalSettlementApprovalInfo_Multi(dataSet_Settlement.Tables[0]))
                    btnQuery_Click(null, null);
                else
                {
                    //MessageHandler.ShowMessageBox(string.Format("成功取消审批了{0}条记录。", count));
                    MessageHandler.ShowMessageBox(string.Format(tsmiCgqxsp.Text +"{0}"+tsmiTjl.Text , count));
                }
                ClearHeadGridAllSelect();
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--取消审批按钮事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+tsmiQxspan.Text , ex);
            }
        }

        /// <summary>
        /// 打印预览按钮事件
        /// </summary>
        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                string settlementNoStr = "";
                if (gridViewSettlementHead.GetFocusedDataRow() != null)
                    settlementNoStr = DataTypeConvert.GetString(gridViewSettlementHead.GetFocusedDataRow()["SettlementNo"]);
                setDAO.PrintHandle(settlementNoStr, 1);
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--打印预览按钮事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+tsmiDyyl.Text , ex);
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
            foreach (DataRow dr in dataSet_Settlement.Tables[0].Rows)
            {
                dr["Select"] = value;
            }
            onlySelectColChangeRowState = true;
        }

        /// <summary>
        /// 主表设定默认值
        /// </summary>
        private void gridViewSettlementHead_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            try
            {
                DateTime nowDate = BaseSQL.GetServerDateTime();
                gridViewSettlementHead.SetFocusedRowCellValue("WarehouseState", 1);
                gridViewSettlementHead.SetFocusedRowCellValue("SettlementDate", nowDate);
                gridViewSettlementHead.SetFocusedRowCellValue("PayDate", nowDate.Date.AddDays(7));
                gridViewSettlementHead.SetFocusedRowCellValue("ReqDep", SystemInfo.user.DepartmentNo);
                gridViewSettlementHead.SetFocusedRowCellValue("Tax", SystemInfo.Settlement_DefaultTax);

                gridViewSettlementHead.SetFocusedRowCellValue("Prepared", SystemInfo.user.EmpName);
                gridViewSettlementHead.SetFocusedRowCellValue("IsVoucher", 0);
                
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--主表设定默认值错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+tsmiZbsd.Text , ex);
            }
        }

        /// <summary>
        /// 删除子表中的一行
        /// </summary>
        private void repbtnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                int wwListAutoId = 0;
                if (gridViewSettlementList.GetFocusedDataRow() != null)
                    wwListAutoId = DataTypeConvert.GetInt(gridViewSettlementList.GetFocusedDataRow()["WarehouseWarrantListAutoId"]);
                gridViewSettlementList.DeleteRow(gridViewSettlementList.FocusedRowHandle);
                if (wwListAutoId > 0)
                    gridViewWWHead_FocusedRowChanged(sender, null);
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--删除子表中的一行错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+tsmiSczbz.Text , ex);
            }
        }

        /// <summary>
        /// 子表单元格值变化进行的操作
        /// </summary>
        private void gridViewSettlementList_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            try
            {
                switch (e.Column.FieldName)
                {
                    case "CodeFileName":
                        string tmpStr = DataTypeConvert.GetString(gridViewSettlementList.GetDataRow(e.RowHandle)["CodeFileName"]);
                        if (tmpStr == "")
                            gridViewSettlementList.SetRowCellValue(e.RowHandle, "CodeName", "");
                        else
                        {
                            DataTable temp = (DataTable)repSearchCodeFileName.DataSource;
                            DataRow[] drs = temp.Select(string.Format("CodeFileName='{0}'", tmpStr));
                            if (drs.Length > 0)
                            {
                                gridViewSettlementList.SetRowCellValue(e.RowHandle, "CodeName", DataTypeConvert.GetString(drs[0]["CodeName"]));
                            }
                        }
                        break;
                    case "Qty":
                    case "Unit":
                    case "Tax":
                        double qtyDouble = DataTypeConvert.GetDouble(gridViewSettlementList.GetDataRow(e.RowHandle)["Qty"]);
                        double unitDouble = DataTypeConvert.GetDouble(gridViewSettlementList.GetDataRow(e.RowHandle)["Unit"]);
                        double amountDouble = Math.Round(qtyDouble * unitDouble, 2, MidpointRounding.AwayFromZero);
                        double taxDouble = DataTypeConvert.GetDouble(gridViewSettlementList.GetDataRow(e.RowHandle)["Tax"]);
                        double taxAmountDouble = Math.Round(amountDouble * taxDouble, 2, MidpointRounding.AwayFromZero);
                        double sumAmountDouble = amountDouble + taxAmountDouble;
                        gridViewSettlementList.SetRowCellValue(e.RowHandle, "Amount", amountDouble);
                        gridViewSettlementList.SetRowCellValue(e.RowHandle, "TaxAmount", taxAmountDouble);
                        gridViewSettlementList.SetRowCellValue(e.RowHandle, "SumAmount", sumAmountDouble);
                        break;
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--子表单元格值变化进行的操作错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+tsmiZbdyg.Text, ex);
            }
        }

        /// <summary>
        /// 设定当前行选择
        /// </summary>
        private void repCheckSelect_EditValueChanged(object sender, EventArgs e)
        {
            if (DataTypeConvert.GetBoolean(gridViewSettlementHead.GetFocusedDataRow()["Select"]))
                gridViewSettlementHead.GetFocusedDataRow()["Select"] = false;
            else
                gridViewSettlementHead.GetFocusedDataRow()["Select"] = true;
            onlySelectColChangeRowState = true;
        }

        /// <summary>
        /// 鼠标操作明细行事件
        /// </summary>
        private void gridViewSettlementList_RowClick(object sender, RowClickEventArgs e)
        {
            try
            {
                if (btnApprove.Enabled)
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
                ExceptionHandler.HandleException(this.Text + "--"+tsmiSbczmx.Text , ex);
            }
        }

        /// <summary>
        /// 查询明细的上一级入库单
        /// </summary>
        private void barButtonUp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (gridViewSettlementList.GetFocusedDataRow() != null)
                {
                    string wwHeadNoStr = DataTypeConvert.GetString(gridViewSettlementList.GetFocusedDataRow()["WarehouseWarrant"]);
                    int wwListAutoId = DataTypeConvert.GetInt(gridViewSettlementList.GetFocusedDataRow()["WarehouseWarrantListAutoId"]);
                    if (wwHeadNoStr == "" || wwListAutoId == 0)
                        return;
                    FrmWarehouseWarrant_Drag.queryWWHeadNo = wwHeadNoStr;
                    FrmWarehouseWarrant_Drag.queryListAutoId = wwListAutoId;
                    ViewHandler.ShowRightWindow("FrmWarehouseWarrant_Drag");
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--查询明细的上一级入库单错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+tsmiCxmxd.Text , ex);
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
                btnSave.Tag = "保存";
                btnSave.Text = tsmiBc.Text;
                btnCancel.Enabled = true;
                btnDelete.Enabled = false;
            }
            else
            {
                //btnNew.Enabled = true;
                btnSave.Tag = "修改";
                btnSave.Text = tsmiXg.Text;
                btnCancel.Enabled = false;
                btnDelete.Enabled = true;
            }
            btnApprove.Enabled = !ret;
            btnCancelApprove.Enabled = !ret;
            btnPreview.Enabled = !ret;

            colInvoiceNo.OptionsColumn.AllowEdit = ret;
            colBussinessBaseNo.OptionsColumn.AllowEdit = ret;
            colReqDep.OptionsColumn.AllowEdit = ret;
            colTax.OptionsColumn.AllowEdit = ret;
            colPayDate.OptionsColumn.AllowEdit = ret;
            colApprovalType.OptionsColumn.AllowEdit = ret;
            colRemark.OptionsColumn.AllowEdit = ret;

            colUnit.OptionsColumn.AllowEdit = ret;
            colQty.OptionsColumn.AllowEdit = ret;
            colTax1.OptionsColumn.AllowEdit = ret;
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
        /// 检测采购结账单状态是否可以操作
        /// </summary>
        private bool CheckWarehouseState()
        {
            if (gridViewSettlementHead.GetFocusedDataRow() == null)
                return false;
            int wState = DataTypeConvert.GetInt(gridViewSettlementHead.GetFocusedDataRow()["WarehouseState"]);
            switch (wState)
            {
                case 2:
                    //MessageHandler.ShowMessageBox(string.Format("采购结账单[{0}]已经审批，不可以操作。", DataTypeConvert.GetString(gridViewSettlementHead.GetFocusedDataRow()["SettlementNo"])));
                    MessageHandler.ShowMessageBox(string.Format(tsmiCgjzd.Text+ "[{0}]"+tsmiYjsp.Text +tsmiBkycz.Text , DataTypeConvert.GetString(gridViewSettlementHead.GetFocusedDataRow()["SettlementNo"])));
                    return false;
                case 3:
                    //MessageHandler.ShowMessageBox(string.Format("采购结账单[{0}]已经结账，不可以操作。", DataTypeConvert.GetString(gridViewSettlementHead.GetFocusedDataRow()["SettlementNo"])));
                    MessageHandler.ShowMessageBox(string.Format(tsmiCgjzd.Text +"[{0}]"+tsmiYjjz.Text +tsmiBkycz.Text , DataTypeConvert.GetString(gridViewSettlementHead.GetFocusedDataRow()["SettlementNo"])));
                    return false;
                case 4:
                    //MessageHandler.ShowMessageBox(string.Format("采购结账单[{0}]已经审批中，不可以操作。", DataTypeConvert.GetString(gridViewSettlementHead.GetFocusedDataRow()["SettlementNo"])));
                    MessageHandler.ShowMessageBox(string.Format(tsmiCgjzd.Text +"[{0}]"+tsmiYjspz.Text +tsmiBkycz.Text , DataTypeConvert.GetString(gridViewSettlementHead.GetFocusedDataRow()["SettlementNo"])));
                    return false;
            }
            return true;
        }

        /// <summary>
        /// 检测当前选中的采购结账单状态是否可以操作
        /// </summary>
        private bool CheckWarehouseState_Multi(bool checkNoApprover, bool checkApprover, bool checkClosed, bool checkApproverBetween)
        {
            for (int i = 0; i < gridViewSettlementHead.DataRowCount; i++)
            {
                if (DataTypeConvert.GetBoolean(gridViewSettlementHead.GetDataRow(i)["Select"]))
                {
                    int wState = DataTypeConvert.GetInt(gridViewSettlementHead.GetDataRow(i)["WarehouseState"]);
                    switch (wState)
                    {
                        case 1:
                            if (checkNoApprover)
                            {
                                //MessageHandler.ShowMessageBox(string.Format("采购结账单[{0}]未审批，不可以操作。", DataTypeConvert.GetString(gridViewSettlementHead.GetDataRow(i)["SettlementNo"])));
                                MessageHandler.ShowMessageBox(string.Format(tsmiCgjzd.Text+ "[{0}]"+tsmiWsp.Text +tsmiBkycz.Text , DataTypeConvert.GetString(gridViewSettlementHead.GetDataRow(i)["SettlementNo"])));
                                gridViewSettlementHead.FocusedRowHandle = i;
                                return false;
                            }
                            break;
                        case 2:
                            if (checkApprover)
                            {
                                //MessageHandler.ShowMessageBox(string.Format("采购结账单[{0}]已经审批，不可以操作。", DataTypeConvert.GetString(gridViewSettlementHead.GetDataRow(i)["SettlementNo"])));
                                MessageHandler.ShowMessageBox(string.Format(tsmiCgjzd.Text +"[{0}]"+tsmiYjsp.Text +tsmiBkycz.Text , DataTypeConvert.GetString(gridViewSettlementHead.GetDataRow(i)["SettlementNo"])));
                                gridViewSettlementHead.FocusedRowHandle = i;
                                return false;
                            }
                            break;
                        case 3:
                            if (checkClosed)
                            {
                                //MessageHandler.ShowMessageBox(string.Format("采购结账单[{0}]已经关闭，不可以操作。", DataTypeConvert.GetString(gridViewSettlementHead.GetDataRow(i)["SettlementNo"])));
                                MessageHandler.ShowMessageBox(string.Format(tsmiCgjzd.Text +"[{0}]"+tsmiYjgbbk.Text , DataTypeConvert.GetString(gridViewSettlementHead.GetDataRow(i)["SettlementNo"])));
                                gridViewSettlementHead.FocusedRowHandle = i;
                                return false;
                            }
                            break;
                        case 4:
                            if (checkApproverBetween)
                            {
                                //MessageHandler.ShowMessageBox(string.Format("采购结账单[{0}]已经审批中，不可以操作。", DataTypeConvert.GetString(gridViewSettlementHead.GetDataRow(i)["SettlementNo"])));
                                MessageHandler.ShowMessageBox(string.Format(tsmiCgjzd.Text +"[{0}]"+tsmiYjspzbk.Text , DataTypeConvert.GetString(gridViewSettlementHead.GetDataRow(i)["SettlementNo"])));
                                gridViewSettlementHead.FocusedRowHandle = i;
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
            gridControlSettlementHead.Focus();
            ColumnView headView = (ColumnView)gridControlSettlementHead.FocusedView;
            headView.FocusedColumn = headView.Columns[colName];
            gridViewSettlementHead.FocusedRowHandle = headView.FocusedRowHandle;
        }

        /// <summary>
        /// 聚焦子表当前行的列
        /// </summary>
        private void FocusedListView(bool isFocusedControl, string colName, int lineNo)
        {
            if (isFocusedControl)
                gridControlSettlementList.Focus();
            ColumnView listView = (ColumnView)gridControlSettlementList.FocusedView;
            listView.FocusedColumn = listView.Columns[colName];
            gridViewSettlementList.FocusedRowHandle = lineNo;
        }

        /// <summary>
        /// 清楚当前的所有选择
        /// </summary>
        private void ClearHeadGridAllSelect()
        {
            checkAll.Checked = false;
            for (int i = 0; i < dataSet_Settlement.Tables[0].Rows.Count; i++)
            {
                dataSet_Settlement.Tables[0].Rows[i]["Select"] = false;
            }
            dataSet_Settlement.Tables[0].AcceptChanges();
            onlySelectColChangeRowState = false;
        }

        #endregion

        #region 左侧入库单模块的相关事件和方法

        /// <summary>
        /// 查询入库单事件
        /// </summary>
        private void btnPrReqQuery_Click(object sender, EventArgs e)
        {
            try
            {
                if (dateWWDateBegin.EditValue == null || dateWWDateEnd.EditValue == null)
                {
                    MessageHandler.ShowMessageBox(tsmiRkrqbn.Text );// ("入库日期不能为空，请设置后重新进行查询。");
                    if (dateWWDateBegin.EditValue == null)
                        dateWWDateBegin.Focus();
                    else
                        dateWWDateEnd.Focus();
                    return;
                }
                string wwHeadNoStr = textWarehouseWarrant.Text.Trim();
                string wwDateBeginStr = dateWWDateBegin.DateTime.ToString("yyyy-MM-dd");
                string wwDateEndStr = dateWWDateEnd.DateTime.AddDays(1).ToString("yyyy-MM-dd");
                string projectNameStr = searchLookUpProjectNo.Text != "全部" ? DataTypeConvert.GetString(searchLookUpProjectNo.Text) : "";

                dataSet_WW.Tables[0].Clear();
                dataSet_WW.Tables[1].Clear();
                applyDAO.QueryWWHead(dataSet_WW.Tables[0], wwHeadNoStr, wwDateBeginStr, wwDateEndStr, projectNameStr, "");
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--查询入库单事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+tsmiCxrk.Text , ex);
            }
        }

        /// <summary>
        /// 聚焦查询入库单明细事件
        /// </summary>
        private void gridViewWWHead_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            try
            {
                if (gridViewWWHead.GetFocusedDataRow() != null && sender != null)
                {
                    dataSet_WW.Tables[1].Clear();
                    applyDAO.QueryWWList(dataSet_WW.Tables[1], DataTypeConvert.GetString(gridViewWWHead.GetFocusedDataRow()["WarehouseWarrant"]));
                    ClearAlreadyDragOrderList();
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--聚焦查询入库单明细事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+tsmiJjcxrk.Text , ex);
            }
        }

        #region 拖出

        /// <summary>
        /// 在GridView中按下鼠标事件
        /// </summary>
        private void gridViewWWList_MouseDown(object sender, MouseEventArgs e)
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
                ExceptionHandler.HandleException(this.Text + "--"+tsmiZgrid.Text , ex);
            }
        }

        /// <summary>
        /// 在GridView中移动鼠标事件
        /// </summary>
        private void gridViewWWList_MouseMove(object sender, MouseEventArgs e)
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
                ExceptionHandler.HandleException(this.Text + "--"+tsmiZgrid.Text , ex);
            }
        }

        #endregion

        #region 拖入

        /// <summary>
        /// 拖拽在GridControl上面
        /// </summary>
        private void gridControlSettlementList_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<DataRow>)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        /// <summary>
        /// 拖拽进入到GridControl控件
        /// </summary>
        private void gridControlSettlementList_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        /// <summary>
        /// 实现拖拽入库单事件
        /// </summary>
        private void gridControlSettlementList_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                List<DataRow> drs = e.Data.GetData(typeof(List<DataRow>)) as List<DataRow>;
                if (drs != null)
                {
                    WWToSettle_DragOrder(sender, drs);
                    ClearAlreadyDragOrderList();
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--实现拖拽入库单事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+tsmiSxtzrk.Text , ex);
            }
        }

        /// <summary>
        /// 拖拽采购订单转成入库单
        /// </summary>
        private void WWToSettle_DragOrder(object sender, List<DataRow> drs)
        {
            DataRow headRow = gridViewWWHead.GetFocusedDataRow();

            if (btnApprove.Enabled)
            {
                ClearHeadGridAllSelect();
                gridViewSettlementHead.AddNewRow();
                FocusedHeadView("InvoiceNo");

                DateTime nowDate = BaseSQL.GetServerDateTime();

                gridViewSettlementHead.SetFocusedRowCellValue("BussinessBaseNo", headRow["BussinessBaseNo"]);

                dataSet_Settlement.Tables[1].Clear();
                foreach (DataRow dr in drs)
                {
                    gridViewSettlementList.AddNewRow();
                    gridViewSettlementList.SetFocusedRowCellValue("SettlementNo", gridViewSettlementHead.GetFocusedDataRow()["SettlementNo"]);
                    gridViewSettlementList.SetFocusedRowCellValue("WarehouseWarrantListAutoId", dr["AutoId"]);
                    gridViewSettlementList.SetFocusedRowCellValue("WarehouseWarrant", headRow["WarehouseWarrant"]);
                    gridViewSettlementList.SetFocusedRowCellValue("CodeFileName", dr["CodeFileName"]);
                    gridViewSettlementList.SetFocusedRowCellValue("CodeName", dr["CodeName"]);

                    double qtyDouble = DataTypeConvert.GetDouble(dr["Overplus"]);
                    double unitDouble = DataTypeConvert.GetDouble(dr["Unit"]);
                    double amountDouble = Math.Round(qtyDouble * unitDouble, 2, MidpointRounding.AwayFromZero);
                    double taxDouble = DataTypeConvert.GetDouble(dr["Tax"]);
                    double taxAmountDouble = Math.Round(amountDouble * taxDouble, 2, MidpointRounding.AwayFromZero);
                    double sumAmountDouble = amountDouble + taxAmountDouble;
                    gridViewSettlementList.SetFocusedRowCellValue("Qty", qtyDouble);
                    gridViewSettlementList.SetFocusedRowCellValue("Unit", unitDouble);
                    gridViewSettlementList.SetFocusedRowCellValue("Tax", taxDouble);
                    gridViewSettlementList.SetFocusedRowCellValue("Amount", amountDouble);
                    gridViewSettlementList.SetFocusedRowCellValue("TaxAmount", taxAmountDouble);
                    gridViewSettlementList.SetFocusedRowCellValue("SumAmount", sumAmountDouble);
                }
                FocusedListView(false, "Unit", gridViewSettlementList.GetFocusedDataSourceRowIndex());
                gridViewSettlementList.RefreshData();

                SetButtonAndColumnState(true);
                headFocusedLineNo = gridViewSettlementList.DataRowCount;
            }
            else
            {
                if (DataTypeConvert.GetString(gridViewSettlementHead.GetFocusedDataRow()["BussinessBaseNo"]) != DataTypeConvert.GetString(headRow["BussinessBaseNo"]))
                {
                    MessageHandler.ShowMessageBox(tsmiYzcgjz.Text);// ("一张采购结账单只允许相同的往来方进行登记。");
                    return;
                }

                foreach (DataRow dr in drs)
                {
                    if (dataSet_Settlement.Tables[1].Select(string.Format("WarehouseWarrantListAutoId={0}", DataTypeConvert.GetString(dr["AutoId"]))).Length > 0)
                        continue;
                    gridViewSettlementList.AddNewRow();
                    gridViewSettlementList.SetFocusedRowCellValue("SettlementNo", gridViewSettlementHead.GetFocusedDataRow()["SettlementNo"]);
                    gridViewSettlementList.SetFocusedRowCellValue("WarehouseWarrantListAutoId", dr["AutoId"]);
                    gridViewSettlementList.SetFocusedRowCellValue("WarehouseWarrant", headRow["WarehouseWarrant"]);
                    gridViewSettlementList.SetFocusedRowCellValue("CodeFileName", dr["CodeFileName"]);
                    gridViewSettlementList.SetFocusedRowCellValue("CodeName", dr["CodeName"]);

                    double qtyDouble = DataTypeConvert.GetDouble(dr["Overplus"]);
                    double unitDouble = DataTypeConvert.GetDouble(dr["Unit"]);
                    double amountDouble = Math.Round(qtyDouble * unitDouble, 2, MidpointRounding.AwayFromZero);
                    double taxDouble = DataTypeConvert.GetDouble(dr["Tax"]);
                    double taxAmountDouble = Math.Round(amountDouble * taxDouble, 2, MidpointRounding.AwayFromZero);
                    double sumAmountDouble = amountDouble + taxAmountDouble;
                    gridViewSettlementList.SetFocusedRowCellValue("Qty", qtyDouble);
                    gridViewSettlementList.SetFocusedRowCellValue("Unit", unitDouble);
                    gridViewSettlementList.SetFocusedRowCellValue("Tax", taxDouble);
                    gridViewSettlementList.SetFocusedRowCellValue("Amount", amountDouble);
                    gridViewSettlementList.SetFocusedRowCellValue("TaxAmount", taxAmountDouble);
                    gridViewSettlementList.SetFocusedRowCellValue("SumAmount", sumAmountDouble);
                }

                gridViewSettlementList.FocusedRowHandle = gridViewSettlementList.DataRowCount;
                FocusedListView(false, "Unit", gridViewSettlementList.GetFocusedDataSourceRowIndex());
                gridViewSettlementList.RefreshData();
            }
        }

        #endregion

        /// <summary>
        /// 清空已经拖拽的采购订单明细
        /// </summary>
        private void ClearAlreadyDragOrderList()
        {
            for (int i = dataSet_WW.Tables[1].Rows.Count - 1; i >= 0; i--)
            {
                if (dataSet_Settlement.Tables[1].Select(string.Format("WarehouseWarrantListAutoId={0}", DataTypeConvert.GetString(dataSet_WW.Tables[1].Rows[i]["AutoId"]))).Length > 0)
                    dataSet_WW.Tables[1].Rows.RemoveAt(i);
            }
        }

        private void SetLeftOrder(bool isWarehouseWarrant)
        {
            if(isWarehouseWarrant)
            {
                btnLeftType.Text = "采购订单";
                dockPnlLeft.Text = "入库单";
                labWarehouseWarrant.Text = "入库单号";
                labWWDate.Text = "入库日期";

                gridColumn5.Caption = "入库单号";
                colWarehouseWarrantDate.Caption = "入库日期";
                gridColumn7.Caption = "入库部门";
            }
            else
            {
                btnLeftType.Text = "入库单";
                dockPnlLeft.Text = "采购订单";
                labWarehouseWarrant.Text = "采购单号";
                labWWDate.Text = "订购日期";

                gridColumn5.Caption = "采购单号";
                colWarehouseWarrantDate.Caption = "订购日期";
                gridColumn7.Caption = "申请部门";
            }
        }

        private void btnLeftType_CheckedChanged(object sender, EventArgs e)
        {
            SetLeftOrder(!btnLeftType.Checked);
        }

        #endregion


    }
}
