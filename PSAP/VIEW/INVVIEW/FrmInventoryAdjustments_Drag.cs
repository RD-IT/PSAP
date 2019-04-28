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
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PSAP.VIEW.BSVIEW
{
    public partial class FrmInventoryAdjustments_Drag : DockContent
    {
        #region 私有变量

        FrmCommonDAO commonDAO = new FrmCommonDAO();
        FrmInventoryAdjustmentsDAO iaDAO = new FrmInventoryAdjustmentsDAO();
        FrmWarehouseNowInfoDAO nowInfoDAO = new FrmWarehouseNowInfoDAO();

        /// <summary>
        /// 主表聚焦的行号
        /// </summary>
        int headFocusedLineNo = 0;

        /// <summary>
        /// 查询的库存调整单号
        /// </summary>
        public static string queryIAHeadNo = "";

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

        public FrmInventoryAdjustments_Drag()
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
        private void FrmInventoryAdjustments_Load(object sender, EventArgs e)
        {
            try
            {
                ControlHandler.DevExpressStyle_ChangeControlLocation(btnListAdd.LookAndFeel.ActiveSkinName, new List<Control> { btnListAdd, checkAll });

                DateTime nowDate = BaseSQL.GetServerDateTime();
                dateIADateBegin.DateTime = nowDate.Date.AddDays(-SystemInfo.OrderQueryDate_DefaultDays);
                dateIADateEnd.DateTime = nowDate.Date;

                DataTable repertoryTable = commonDAO.QueryRepertoryInfo(false);
                DataTable repertoryAddAllTable = commonDAO.QueryRepertoryInfo(true);
                DataTable projectListAddAllTable = commonDAO.QueryProjectList(true);

                lookUpAdjustmentsRepertoryNo.Properties.DataSource = repertoryAddAllTable;
                lookUpAdjustmentsRepertoryNo.ItemIndex = 0;
                lookUpReqDep.Properties.DataSource = commonDAO.QueryDepartment(true);
                lookUpReqDep.ItemIndex = 0;
                lookUpPrepared.Properties.DataSource = commonDAO.QueryUserInfo(true);
                lookUpPrepared.EditValue = SystemInfo.user.EmpName;
                searchAdjustmentsProjectNo.Properties.DataSource = projectListAddAllTable;
                searchAdjustmentsProjectNo.Text = "全部";

                repLookUpInRepertoryNo.DataSource = repertoryTable;
                repSearchAdjustmentsProjectNo.DataSource = commonDAO.QueryProjectList(false);
                repLookUpReqDep.DataSource = commonDAO.QueryDepartment(false);
                repSearchCodeFileName.DataSource = commonDAO.QueryPartsCode(false);
                repSearchOutShelfNo.DataSource = commonDAO.QueryShelfInfo(false);

                lookUpRepertoryNo.Properties.DataSource = repertoryAddAllTable;
                lookUpRepertoryNo.ItemIndex = 0;
                searchLookUpProjectNo.Properties.DataSource = projectListAddAllTable;
                searchLookUpProjectNo.Text = "全部";
                searchLookUpCodeFileName.Properties.DataSource = commonDAO.QueryPartsCode(true);
                searchLookUpCodeFileName.Text = "全部";

                repLookUpRepertoryNo.DataSource = repertoryTable;

                if (textCommon.Text == "")
                {
                    iaDAO.QueryInventoryAdjustmentsHead(dataSet_IA.Tables[0], "", "", "", "", "", "", "", true);
                    iaDAO.QueryInventoryAdjustmentsList(dataSet_IA.Tables[1], "", true);
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+f.tsmiCtjzsjcw.Text , ex);
            }
        }

        /// <summary>
        /// 窗体激活事件
        /// </summary>
        private void FrmInventoryAdjustments_Activated(object sender, EventArgs e)
        {
            try
            {
                if (queryIAHeadNo != "")
                {
                    textCommon.Text = queryIAHeadNo;
                    queryIAHeadNo = "";
                    lookUpAdjustmentsRepertoryNo.ItemIndex = 0;
                    lookUpReqDep.ItemIndex = 0;
                    lookUpPrepared.ItemIndex = 0;
                    searchAdjustmentsProjectNo.Text = "全部";

                    dataSet_IA.Tables[0].Clear();
                    headFocusedLineNo = 0;
                    iaDAO.QueryInventoryAdjustmentsHead(dataSet_IA.Tables[0], "", "", "", "", "", "", textCommon.Text, false);
                    SetButtonAndColumnState(false);

                    if (dataSet_IA.Tables[0].Rows.Count > 0)
                    {
                        dateIADateBegin.DateTime = DataTypeConvert.GetDateTime(dataSet_IA.Tables[0].Rows[0]["InventoryAdjustmentsDate"]).Date;
                        dateIADateEnd.DateTime = dateIADateBegin.DateTime.AddDays(7);
                    }
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--窗体激活事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+f.tsmiCtjhsjcw.Text , ex);
            }
        }

        /// <summary>
        /// 窗体显示事件
        /// </summary>
        private void FrmInventoryAdjustments_Shown(object sender, EventArgs e)
        {
            pnlMiddle.Height = (this.Height - pnltop.Height) / 2;
            dockPnlLeft.Width = SystemInfo.DragForm_LeftDock_Width;
        }

        /// <summary>
        /// 查询按钮事件
        /// </summary>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                if (dateIADateBegin.EditValue == null || dateIADateEnd.EditValue == null)
                {
                    MessageHandler.ShowMessageBox(tsmiTzrqbnwkcx.Text );// ("调整日期不能为空，请设置后重新进行查询。");
                    if (dateIADateBegin.EditValue == null)
                        dateIADateBegin.Focus();
                    else
                        dateIADateEnd.Focus();
                    return;
                }
                string orderDateBeginStr = dateIADateBegin.DateTime.ToString("yyyy-MM-dd");
                string orderDateEndStr = dateIADateEnd.DateTime.AddDays(1).ToString("yyyy-MM-dd");

                string repertoryNoStr = lookUpAdjustmentsRepertoryNo.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpAdjustmentsRepertoryNo.EditValue) : "";
                string projectNoStr = searchAdjustmentsProjectNo.Text != "全部" ? DataTypeConvert.GetString(searchAdjustmentsProjectNo.EditValue) : "";
                string reqDepStr = lookUpReqDep.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpReqDep.EditValue) : "";
                string empNameStr = lookUpPrepared.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpPrepared.EditValue) : "";
                string commonStr = textCommon.Text.Trim();

                dataSet_IA.Tables[0].Clear();
                dataSet_IA.Tables[1].Clear();
                headFocusedLineNo = 0;
                iaDAO.QueryInventoryAdjustmentsHead(dataSet_IA.Tables[0], orderDateBeginStr, orderDateEndStr, repertoryNoStr, projectNoStr, reqDepStr, empNameStr, commonStr, false);

                SetButtonAndColumnState(false);
                checkAll.Checked = false;
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--查询按钮事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+f.tsmiCxansjcw.Text , ex);
            }
        }

        /// <summary>
        /// 主表聚焦行改变事件
        /// </summary>
        private void gridViewIAHead_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (gridViewIAHead.GetFocusedDataRow() != null)
                {
                    if (onlySelectColChangeRowState)
                    {
                        dataSet_IA.Tables[0].AcceptChanges();
                        onlySelectColChangeRowState = false;
                    }
                    else
                    {
                        if (headFocusedLineNo < gridViewIAHead.DataRowCount && gridViewIAHead.FocusedRowHandle != headFocusedLineNo && gridViewIAHead.GetDataRow(headFocusedLineNo).RowState != DataRowState.Unchanged)
                        {
                            MessageHandler.ShowMessageBox(tsmiDqkctzdyjxghh.Text );// ("当前库存调整单已经修改，请保存后再进行换行。");
                            gridViewIAHead.FocusedRowHandle = headFocusedLineNo;
                        }
                        else if (headFocusedLineNo == gridViewIAHead.DataRowCount)
                        {

                        }
                        else
                        {
                            if (gridViewIAHead.FocusedRowHandle != headFocusedLineNo && gridViewIAHead.GetDataRow(headFocusedLineNo).RowState != DataRowState.Unchanged)
                                btnCancel_Click(null, null);
                            else if (gridViewIAHead.GetDataRow(headFocusedLineNo).RowState == DataRowState.Unchanged)
                                btnCancel_Click(null, null);
                        }
                    }

                    if (DataTypeConvert.GetString(gridViewIAHead.GetFocusedDataRow()["InventoryAdjustmentsNo"]) != "")
                    {
                        dataSet_IA.Tables[1].Clear();
                        iaDAO.QueryInventoryAdjustmentsList(dataSet_IA.Tables[1], DataTypeConvert.GetString(gridViewIAHead.GetFocusedDataRow()["InventoryAdjustmentsNo"]), false);
                        //if (queryListAutoId > 0)
                        //{
                        //    for (int i = 0; i < gridViewIAList.DataRowCount; i++)
                        //    {
                        //        if (DataTypeConvert.GetInt(gridViewIAList.GetDataRow(i)["AutoId"]) == queryListAutoId)
                        //        {
                        //            gridViewIAList.FocusedRowHandle = i;
                        //            queryListAutoId = 0;
                        //            break;
                        //        }
                        //    }
                        //}
                    }

                    if (gridViewIAHead.FocusedRowHandle >= 0)
                    {
                        headFocusedLineNo = gridViewIAHead.FocusedRowHandle;
                    }
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--主表聚焦行改变事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+f.tsmiZbjjhgb.Text , ex);
            }
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewIAHead_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            ControlHandler.GridView_CustomDrawRowIndicator(e);
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void repSearchCodeFileNameView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            ControlHandler.GridView_CustomDrawRowIndicator(e);
        }

        /// <summary>
        /// 获取单元格显示的信息
        /// </summary>
        private void gridViewIAHead_KeyDown(object sender, KeyEventArgs e)
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
        /// 新增按钮事件
        /// </summary>
        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                ClearHeadGridAllSelect();

                //gridViewPrReqHead.PostEditor();
                gridViewIAHead.AddNewRow();
                FocusedHeadView("AdjustmentsRepertoryNo");

                dataSet_IA.Tables[1].Clear();
                gridViewIAList.AddNewRow();
                FocusedListView(false, "CodeFileName", gridViewIAList.GetFocusedDataSourceRowIndex());
                gridViewIAList.RefreshData();

                SetButtonAndColumnState(true);
                headFocusedLineNo = gridViewIAHead.DataRowCount;
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--新增按钮事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+f.tsmiXzansj.Text , ex);
            }
        }

        /// <summary>
        /// 保存按钮事件
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridViewIAHead.GetFocusedDataRow() == null)
                    return;

                //if (!CheckReqState())
                //    return;

                if (btnSave.Tag.ToString() != "保存")
                {
                    ClearHeadGridAllSelect();

                    SetButtonAndColumnState(true);
                    FocusedHeadView("AdjustmentsRepertoryNo");
                }
                else
                {
                    DataRow headRow = gridViewIAHead.GetFocusedDataRow();
                    string adjRepertoryNoStr = DataTypeConvert.GetString(headRow["AdjustmentsRepertoryNo"]);
                    string adjProjectNoStr = DataTypeConvert.GetString(headRow["AdjustmentsProjectNo"]);
                    if (adjRepertoryNoStr == "")
                    {
                        MessageHandler.ShowMessageBox(tsmiCkbnwkbc.Text );// ("仓库不能为空，请填写后再进行保存。");
                        FocusedHeadView("AdjustmentsRepertoryNo");
                        return;
                    }
                    if (adjProjectNoStr == "")
                    {
                        MessageHandler.ShowMessageBox(tsmiXmhbnwkbc.Text );// ("项目号不能为空，请填写后再进行保存。");
                        FocusedHeadView("AdjustmentsProjectNo");
                        return;
                    }
                    if (DataTypeConvert.GetString(headRow["ReqDep"]) == "")
                    {
                        MessageHandler.ShowMessageBox(tsmiSqbmbnwkbc.Text);// ("申请部门不能为空，请填写后再进行保存。");
                        FocusedHeadView("ReqDep");
                        return;
                    }

                    for (int i = gridViewIAList.DataRowCount - 1; i >= 0; i--)
                    {
                        DataRow listRow = gridViewIAList.GetDataRow(i);
                        if (DataTypeConvert.GetString(listRow["CodeFileName"]) == "")
                        {
                            gridViewIAList.DeleteRow(i);
                            continue;
                        }
                        if (DataTypeConvert.GetString(listRow["Qty"]) == "")
                        {
                            MessageHandler.ShowMessageBox(tsmiSlbnwkbc.Text );// ("数量不能为空，请填写后再进行保存。");
                            FocusedListView(true, "Qty", i);
                            return;
                        }
                        if (DataTypeConvert.GetString(listRow["AdjustmentsShelfNo"]) == "")
                        {
                            MessageHandler.ShowMessageBox(tsmiTzhjhbnwkbc.Text );// ("调整货架号不能为空，请填写后再进行保存。");
                            FocusedListView(true, "AdjustmentsShelfNo", i);
                            return;
                        }                        
                    }

                    int ret = iaDAO.SaveInventoryAdjustments(gridViewIAHead.GetFocusedDataRow(), dataSet_IA.Tables[1]);
                    switch (ret)
                    {
                        case -1:
                            btnQuery_Click(null, null);
                            break;
                        case 1:
                            dataSet_IA.Tables[1].Clear();
                            iaDAO.QueryInventoryAdjustmentsList(dataSet_IA.Tables[1], DataTypeConvert.GetString(gridViewIAHead.GetFocusedDataRow()["InventoryAdjustmentsNo"]), false);
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
                ExceptionHandler.HandleException(this.Text + "--"+f.tsmiBcansj.Text , ex);
            }
        }

        /// <summary>
        /// 取消按钮事件
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridViewIAHead.GetDataRow(headFocusedLineNo).RowState != DataRowState.Unchanged)
                {
                    if (DataTypeConvert.GetString(gridViewIAHead.GetDataRow(headFocusedLineNo)["InventoryAdjustmentsNo"]) == "")
                    {
                        gridViewIAHead.DeleteRow(headFocusedLineNo);
                    }
                    else
                    {
                        gridViewIAHead.GetFocusedDataRow().RejectChanges();
                    }
                }

                SetButtonAndColumnState(false);

                dataSet_IA.Tables[1].Clear();
                if (gridViewIAHead.GetFocusedDataRow() != null)
                    iaDAO.QueryInventoryAdjustmentsList(dataSet_IA.Tables[1], DataTypeConvert.GetString(gridViewIAHead.GetFocusedDataRow()["InventoryAdjustmentsNo"]), false);

                //gridViewPrReqHead_FocusedRowChanged(sender, null);
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--取消按钮事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+f.tsmiQxansj.Text , ex);
            }
        }

        /// <summary>
        /// 删除按钮事件
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int count = dataSet_IA.Tables[0].Select("select=1").Length;
                if (count == 0)
                {
                    MessageHandler.ShowMessageBox(f.tsmiQzyczdjlq.Text );// ("请在要操作的记录前面选中。");
                    return;
                }

                //if (!CheckReqState_Multi(false, true, true, true))
                //    return;

                //if (MessageHandler.ShowMessageBox_YesNo(string.Format("确定要删除当前选中的{0}条记录吗？", count)) != DialogResult.Yes)
                if (MessageHandler.ShowMessageBox_YesNo(string.Format(f.tsmiQdyscdqxzd.Text +"{0}"+f.tsmiTjlm.Text, count)) != DialogResult.Yes)
                {
                    return;
                }
                if (!iaDAO.DeleteInventoryAdjustments_Multi(dataSet_IA.Tables[0]))
                {

                }

                btnQuery_Click(null, null);
                ClearHeadGridAllSelect();
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--删除按钮事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+f.tsmiScansj.Text , ex);
            }
        }

        /// <summary>
        /// 预览按钮事件
        /// </summary>
        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                string iaHeadNoStr = "";
                if (gridViewIAHead.GetFocusedDataRow() != null)
                    iaHeadNoStr = DataTypeConvert.GetString(gridViewIAHead.GetFocusedDataRow()["InventoryAdjustmentsNo"]);
                iaDAO.PrintHandle(iaHeadNoStr, 1);
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--预览按钮事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+f.tsmiYlansjcw.Text , ex);
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
            foreach (DataRow dr in dataSet_IA.Tables[0].Rows)
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
                ExceptionHandler.HandleException(this.Text + "--"+f.tsmiZbxzyhsjcw.Text , ex);
            }
        }

        /// <summary>
        /// 主表设定默认值
        /// </summary>
        private void gridViewIAHead_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            try
            {
                DateTime nowDate = BaseSQL.GetServerDateTime();
                gridViewIAHead.SetFocusedRowCellValue("InventoryAdjustmentsDate", nowDate);
                gridViewIAHead.SetFocusedRowCellValue("ReqDep", SystemInfo.user.DepartmentNo);
                gridViewIAHead.SetFocusedRowCellValue("Prepared", SystemInfo.user.EmpName);
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--主表设定默认值错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+f.tsmiZbsdmrzcw.Text , ex);
            }
        }

        /// <summary>
        /// 子表设定默认值
        /// </summary>
        private void gridViewIAList_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            try
            {
                gridViewIAList.SetFocusedRowCellValue("InventoryAdjustmentsNo", DataTypeConvert.GetString(gridViewIAHead.GetFocusedDataRow()["InventoryAdjustmentsNo"]));
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--子表设定默认值错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+f.tsmiZbsdmrzcw.Text , ex);
            }
        }

        /// <summary>
        /// 子表按键事件
        /// </summary>
        private void gridViewIAList_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (!colRemark.OptionsColumn.AllowEdit)
                        return;

                    if (gridViewIAList.GetFocusedDataSourceRowIndex() >= gridViewIAList.DataRowCount - 1 && gridViewIAList.FocusedColumn.Name == "colRemark")
                    {
                        ListNewRow();
                    }
                    else if (gridViewIAList.FocusedColumn.Name == "colRemark")
                    {
                        gridViewIAList.FocusedRowHandle = gridViewIAList.FocusedRowHandle + 1;
                        FocusedListView(true, "CodeFileName", gridViewIAList.GetFocusedDataSourceRowIndex());
                    }
                }
                else
                {
                    ControlHandler.GridView_GetFocusedCellDisplayText_KeyDown(sender, e);
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--子表按键事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+f.tsmiZbajsjcw.Text , ex);
            }
        }

        /// <summary>
        /// 删除子表中的一行
        /// </summary>
        private void repbtnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (gridViewIAList.GetFocusedDataRow().RowState != DataRowState.Added)
                {
                    if (MessageHandler.ShowMessageBox_YesNo("确定要删除当前选中的明细记录吗？") != DialogResult.Yes)
                    {
                        return;
                    }
                }
                //int prListAutoIdInt = 0;
                //if (gridViewIMList.GetFocusedDataRow() != null)
                //    prListAutoIdInt = DataTypeConvert.GetInt(gridViewIMList.GetFocusedDataRow()["PrListAutoId"]);
                gridViewIAList.DeleteRow(gridViewIAList.FocusedRowHandle);
                //if (prListAutoIdInt > 0)
                //    gridViewPrReqHead_FocusedRowChanged(sender, null);
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--删除子表中的一行错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+f.tsmiSczbzyhcw.Text , ex);
            }
        }

        /// <summary>
        /// 子表单元格值变化进行的操作
        /// </summary>
        private void gridViewIAList_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                string tmpStr = "";
                switch (e.Column.FieldName)
                {
                    case "CodeFileName":
                        tmpStr = DataTypeConvert.GetString(gridViewIAList.GetDataRow(e.RowHandle)["CodeFileName"]);
                        if (tmpStr == "")
                            gridViewIAList.SetRowCellValue(e.RowHandle, "CodeName", "");
                        else
                        {
                            DataTable temp = (DataTable)repSearchCodeFileName.DataSource;
                            DataRow[] drs = temp.Select(string.Format("CodeFileName='{0}'", tmpStr));
                            if (drs.Length > 0)
                            {
                                gridViewIAList.SetRowCellValue(e.RowHandle, "CodeName", DataTypeConvert.GetString(drs[0]["CodeName"]));
                            }
                        }
                        break; 
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--子表单元格值变化进行的操作错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+f.tsmiZbdygzbhjxdczcw.Text , ex);
            }
        }

        /// <summary>
        /// 设定当前行选择
        /// </summary>
        private void repCheckSelect_EditValueChanged(object sender, EventArgs e)
        {
            if (DataTypeConvert.GetBoolean(gridViewIAHead.GetFocusedDataRow()["Select"]))
                gridViewIAHead.GetFocusedDataRow()["Select"] = false;
            else
                gridViewIAHead.GetFocusedDataRow()["Select"] = true;
            onlySelectColChangeRowState = true;
        }

        /// <summary>
        /// 检查是否有未填写字段
        /// </summary>
        private bool IsHaveBlankLine()
        {
            gridViewIAList.FocusedRowHandle = 0;
            for (int i = 0; i < gridViewIAList.DataRowCount; i++)
            {
                if (DataTypeConvert.GetString(gridViewIAList.GetDataRow(i)["CodeFileName"]) == "")
                {
                    gridViewIAList.Focus();
                    gridViewIAList.FocusedColumn = colCodeFileName;
                    gridViewIAList.FocusedRowHandle = i;
                    return true;
                }
                if (DataTypeConvert.GetString(gridViewIAList.GetDataRow(i)["Qty"]) == "")
                {
                    gridViewIAList.Focus();
                    gridViewIAList.FocusedColumn = colQty;
                    gridViewIAList.FocusedRowHandle = i;
                    return true;
                }
                if (DataTypeConvert.GetString(gridViewIAList.GetDataRow(i)["AdjustmentsShelfNo"]) == "")
                {
                    gridViewIAList.Focus();
                    gridViewIAList.FocusedColumn = colAdjustmentsShelfNo;
                    gridViewIAList.FocusedRowHandle = i;
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
            gridViewIAList.AddNewRow();
            FocusedListView(true, "CodeFileName", gridViewIAList.GetFocusedDataSourceRowIndex());
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
                btnSave.Text = f.tsmiBc.Text ;
                btnCancel.Enabled = true;
                btnDelete.Enabled = false;
            }
            else
            {
                btnNew.Enabled = true;
                btnSave.Tag = "修改";
                btnSave.Text = f.tsmiXg.Text ;
                btnCancel.Enabled = false;
                btnDelete.Enabled = true;
            }
            btnPreview.Enabled = !ret;

            btnListAdd.Enabled = ret;

            colAdjustmentsRepertoryNo.OptionsColumn.AllowEdit = ret;
            colAdjustmentsProjectNo.OptionsColumn.AllowEdit = ret;
            colPRemark.OptionsColumn.AllowEdit = ret;

            colCodeFileName.OptionsColumn.AllowEdit = ret;
            colQty.OptionsColumn.AllowEdit = ret;
            colAdjustmentsShelfNo.OptionsColumn.AllowEdit = ret;
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
        /// 聚焦主表当前行的列
        /// </summary>
        private void FocusedHeadView(string colName)
        {
            gridControlIAHead.Focus();
            ColumnView headView = (ColumnView)gridControlIAHead.FocusedView;
            headView.FocusedColumn = headView.Columns[colName];
            gridViewIAHead.FocusedRowHandle = headView.FocusedRowHandle;
        }

        /// <summary>
        /// 聚焦子表当前行的列
        /// </summary>
        private void FocusedListView(bool isFocusedControl, string colName, int lineNo)
        {
            if (isFocusedControl)
                gridControlIAList.Focus();
            ColumnView listView = (ColumnView)gridControlIAList.FocusedView;
            listView.FocusedColumn = listView.Columns[colName];
            gridViewIAList.FocusedRowHandle = lineNo;
        }

        /// <summary>
        /// 清楚当前的所有选择
        /// </summary>
        private void ClearHeadGridAllSelect()
        {
            checkAll.Checked = false;
            for (int i = 0; i < dataSet_IA.Tables[0].Rows.Count; i++)
            {
                dataSet_IA.Tables[0].Rows[i]["Select"] = false;
            }
            dataSet_IA.Tables[0].AcceptChanges();
            onlySelectColChangeRowState = false;
        }

        #endregion

        #region 左侧当前库存模块的相关事件和方法

        /// <summary>
        /// 查询当前库存事件
        /// </summary>
        private void btnWNowInfoQuery_Click(object sender, EventArgs e)
        {
            try
            {
                string repertoryNoStr = lookUpRepertoryNo.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpRepertoryNo.EditValue) : "";
                string projectNameStr = searchLookUpProjectNo.Text != "全部" ? searchLookUpProjectNo.Text.Trim() : "";
                string codeFileNameStr = searchLookUpCodeFileName.Text != "全部" ? DataTypeConvert.GetString(searchLookUpCodeFileName.EditValue) : "";

                dataSet_WNowInfo.Tables[0].Clear();
                nowInfoDAO.QueryWarehouseNowInfo(dataSet_WNowInfo.Tables[0], codeFileNameStr, repertoryNoStr, projectNameStr, !checkZero.Checked);
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--查询当前库存事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+f.tsmiCxdqkcsjcw.Text , ex);
            }
        }

        #region 拖出

        /// <summary>
        /// 在GridView中按下鼠标事件
        /// </summary>
        private void gridViewWNowInfo_MouseDown(object sender, MouseEventArgs e)
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
        private void gridViewWNowInfo_MouseMove(object sender, MouseEventArgs e)
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

                        if (rowint.Length == 0)
                            rowint = new int[] { view.FocusedRowHandle };

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
        private void gridControlIMList_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<DataRow>)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        /// <summary>
        /// 拖拽进入到GridControl控件
        /// </summary>
        private void gridControlIMList_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        /// <summary>
        /// 实现拖拽当前库存事件
        /// </summary>
        private void gridControlIMList_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                List<DataRow> drs = e.Data.GetData(typeof(List<DataRow>)) as List<DataRow>;
                if (drs != null)
                {
                    WNowInfoToInvAdjust_DragOrder(sender, drs);
                    ClearAlreadyDragWNowInfo();
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--实现拖拽当前库存事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+tsmiSxtzdqkcsjcw.Text , ex);
            }
        }

        /// <summary>
        /// 拖拽当前库存转成库存调整单 
        /// </summary>
        private void WNowInfoToInvAdjust_DragOrder(object sender, List<DataRow> drs)
        {
            string repertoryNoStr = "";
            string projectNoStr = "";
            if (drs.Count > 0)
            {
                repertoryNoStr = DataTypeConvert.GetString(drs[0]["RepertoryNo"]);
                projectNoStr = DataTypeConvert.GetString(drs[0]["ProjectNo"]);
            }
            else
                return;

            //foreach (DataRow dr in drs)
            //{
            //    if (DataTypeConvert.GetString(dr["RepertoryNo"]) != repertoryNoStr || DataTypeConvert.GetString(dr["ProjectNo"]) != projectNoStr)
            //    {
            //        MessageHandler.ShowMessageBox("一张库存调整单必须选择相同的仓库和项目号进行登记，请重新操作。");
            //        return;
            //    }
            //}

            if (btnNew.Enabled)
            {
                ClearHeadGridAllSelect();
                gridViewIAHead.AddNewRow();
                FocusedHeadView("AdjustmentsRepertoryNo");

                gridViewIAHead.SetFocusedRowCellValue("AdjustmentsRepertoryNo", repertoryNoStr);
                gridViewIAHead.SetFocusedRowCellValue("AdjustmentsProjectNo", projectNoStr);

                dataSet_IA.Tables[1].Clear();
                foreach (DataRow dr in drs)
                {
                    gridViewIAList.AddNewRow();
                    gridViewIAList.SetFocusedRowCellValue("CodeFileName", dr["CodeFileName"]);
                    gridViewIAList.SetFocusedRowCellValue("CodeName", dr["CodeName"]);
                    gridViewIAList.SetFocusedRowCellValue("Qty", DataTypeConvert.GetDouble(dr["Qty"]));
                    gridViewIAList.SetFocusedRowCellValue("AdjustmentsShelfNo", dr["ShelfNo"]);
                }
                gridViewIAList.RefreshData();
                FocusedListView(false, "Qty", gridViewIAList.GetFocusedDataSourceRowIndex());

                SetButtonAndColumnState(true);
                headFocusedLineNo = gridViewIAHead.DataRowCount;
            }
            else
            {
                string adjRepertoryNoStr = DataTypeConvert.GetString(gridViewIAHead.GetFocusedDataRow()["AdjustmentsRepertoryNo"]);
                string adjProjectNoStr = DataTypeConvert.GetString(gridViewIAHead.GetFocusedDataRow()["AdjustmentsProjectNo"]);
                if (adjRepertoryNoStr == "")
                    gridViewIAHead.GetFocusedDataRow()["AdjustmentsRepertoryNo"] = repertoryNoStr;
                if (adjProjectNoStr == "")
                    gridViewIAHead.GetFocusedDataRow()["AdjustmentsProjectNo"] = projectNoStr;
                adjRepertoryNoStr = adjRepertoryNoStr == "" ? repertoryNoStr : adjRepertoryNoStr;
                adjProjectNoStr = adjProjectNoStr == "" ? projectNoStr : adjProjectNoStr;
                //adjRepertoryNoStr = adjRepertoryNoStr == "" ? repertoryNoStr : adjRepertoryNoStr;
                //adjProjectNoStr = adjProjectNoStr == "" ? projectNoStr : adjProjectNoStr;

                //if (adjRepertoryNoStr != repertoryNoStr || adjProjectNoStr != projectNoStr)
                //{
                //    MessageHandler.ShowMessageBox("一张库存移动单必须选择相同的仓库和项目号进行登记，请重新操作。");
                //    return;
                //}

                foreach (DataRow dr in drs)
                {
                    gridViewIAList.AddNewRow();
                    gridViewIAList.SetFocusedRowCellValue("CodeFileName", dr["CodeFileName"]);
                    gridViewIAList.SetFocusedRowCellValue("CodeName", dr["CodeName"]);
                    gridViewIAList.SetFocusedRowCellValue("Qty", DataTypeConvert.GetDouble(dr["Qty"]));
                    gridViewIAList.SetFocusedRowCellValue("AdjustmentsShelfNo", dr["ShelfNo"]);
                }

                gridViewIAList.FocusedRowHandle = gridViewIAList.DataRowCount;
                FocusedListView(false, "Qty", gridViewIAList.GetFocusedDataSourceRowIndex());
                gridViewIAList.RefreshData();
            }
        }

        #endregion


        /// <summary>
        /// 清空已经拖拽的当前库存明细
        /// </summary>
        private void ClearAlreadyDragWNowInfo()
        {
            //for (int i = dataSet_WNowInfo.Tables[0].Rows.Count - 1; i >= 0; i--)
            //{
            //    if (dataSet_IM.Tables[1].Select(string.Format("CodeFileName='{0}' and ProjectName='{1}' and ShelfNo='{2}'", DataTypeConvert.GetString(dataSet_WNowInfo.Tables[0].Rows[i]["CodeFileName"]), DataTypeConvert.GetString(dataSet_WNowInfo.Tables[0].Rows[i]["ProjectName"]), DataTypeConvert.GetString(dataSet_WNowInfo.Tables[0].Rows[i]["ShelfNo"]))).Length > 0)
            //        dataSet_WNowInfo.Tables[0].Rows.RemoveAt(i);
            //}
        }

        #endregion

    }
}
