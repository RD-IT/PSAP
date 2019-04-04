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
    public partial class FrmInventoryMove_Drag : DockContent
    {
        #region 私有变量

        FrmCommonDAO commonDAO = new FrmCommonDAO();
        FrmInventoryMoveDAO imDAO = new FrmInventoryMoveDAO();
        FrmWarehouseNowInfoDAO nowInfoDAO = new FrmWarehouseNowInfoDAO();

        /// <summary>
        /// 主表聚焦的行号
        /// </summary>
        int headFocusedLineNo = 0;

        /// <summary>
        /// 查询的库存移动单号
        /// </summary>
        public static string queryIMHeadNo = "";

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

        public FrmInventoryMove_Drag()
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
        private void FrmInventoryMove_Load(object sender, EventArgs e)
        {
            try
            {
                ControlHandler.DevExpressStyle_ChangeControlLocation(btnListAdd.LookAndFeel.ActiveSkinName, new List<Control> { btnListAdd, checkAll });

                DateTime nowDate = BaseSQL.GetServerDateTime();
                dateIMDateBegin.DateTime = nowDate.Date.AddDays(-SystemInfo.OrderQueryDate_DefaultDays);
                dateIMDateEnd.DateTime = nowDate.Date;

                DataTable repertoryTable = commonDAO.QueryRepertoryInfo(false);
                DataTable repertoryAddAllTable = commonDAO.QueryRepertoryInfo(true);

                lookUpInRepertoryNo.Properties.DataSource = repertoryAddAllTable;
                lookUpInRepertoryNo.ItemIndex = 0;
                lookUpOutRpertoryNo.Properties.DataSource = repertoryAddAllTable;
                lookUpOutRpertoryNo.ItemIndex = 0;
                lookUpReqDep.Properties.DataSource = commonDAO.QueryDepartment(true);
                lookUpReqDep.ItemIndex = 0;
                lookUpPrepared.Properties.DataSource = commonDAO.QueryUserInfo(true);
                lookUpPrepared.EditValue = SystemInfo.user.EmpName;

                repLookUpInRepertoryNo.DataSource = repertoryTable;
                repLookUpReqDep.DataSource = commonDAO.QueryDepartment(false);
                repSearchCodeFileName.DataSource = commonDAO.QueryPartsCode(false);
                repSearchOutProjectNo.DataSource = commonDAO.QueryProjectList(false);
                repSearchOutShelfNo.DataSource = commonDAO.QueryShelfInfo(false);

                lookUpRepertoryNo.Properties.DataSource = repertoryAddAllTable;
                lookUpRepertoryNo.ItemIndex = 0;
                searchLookUpProjectNo.Properties.DataSource = commonDAO.QueryProjectList(true);
                searchLookUpProjectNo.Text = "全部";
                searchLookUpCodeFileName.Properties.DataSource = commonDAO.QueryPartsCode(true);
                searchLookUpCodeFileName.Text = "全部";

                repLookUpRepertoryNo.DataSource = repertoryTable;

                if (textCommon.Text == "")
                {
                    imDAO.QueryInventoryMoveHead(dataSet_IM.Tables[0], "", "", "", "", "", "", "", true);
                    imDAO.QueryInventoryMoveList(dataSet_IM.Tables[1], "", true);
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
        private void FrmInventoryMove_Activated(object sender, EventArgs e)
        {
            try
            {
                if (queryIMHeadNo != "")
                {
                    textCommon.Text = queryIMHeadNo;
                    queryIMHeadNo = "";
                    lookUpInRepertoryNo.ItemIndex = 0;
                    lookUpOutRpertoryNo.ItemIndex = 0;
                    lookUpReqDep.ItemIndex = 0;
                    lookUpPrepared.ItemIndex = 0;

                    dataSet_IM.Tables[0].Clear();
                    headFocusedLineNo = 0;
                    imDAO.QueryInventoryMoveHead(dataSet_IM.Tables[0], "", "", "", "", "", "", textCommon.Text, false);
                    SetButtonAndColumnState(false);

                    if (dataSet_IM.Tables[0].Rows.Count > 0)
                    {
                        dateIMDateBegin.DateTime = DataTypeConvert.GetDateTime(dataSet_IM.Tables[0].Rows[0]["InventoryMoveDate"]).Date;
                        dateIMDateEnd.DateTime = dateIMDateBegin.DateTime.AddDays(7);
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
        private void FrmInventoryMove_Shown(object sender, EventArgs e)
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
                if (dateIMDateBegin.EditValue == null || dateIMDateEnd.EditValue == null)
                {
                    MessageHandler.ShowMessageBox(tsmiYdrqbnwkcx.Text);// ("移动日期不能为空，请设置后重新进行查询。");
                    if (dateIMDateBegin.EditValue == null)
                        dateIMDateBegin.Focus();
                    else
                        dateIMDateEnd.Focus();
                    return;
                }
                string orderDateBeginStr = dateIMDateBegin.DateTime.ToString("yyyy-MM-dd");
                string orderDateEndStr = dateIMDateEnd.DateTime.AddDays(1).ToString("yyyy-MM-dd");

                string inRepertoryNoStr = lookUpInRepertoryNo.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpInRepertoryNo.EditValue) : "";
                string outRepertoryNoStr = lookUpOutRpertoryNo.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpOutRpertoryNo.EditValue) : "";
                string reqDepStr = lookUpReqDep.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpReqDep.EditValue) : "";
                string empNameStr = lookUpPrepared.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpPrepared.EditValue) : "";
                string commonStr = textCommon.Text.Trim();

                dataSet_IM.Tables[0].Clear();
                dataSet_IM.Tables[1].Clear();
                headFocusedLineNo = 0;
                imDAO.QueryInventoryMoveHead(dataSet_IM.Tables[0], orderDateBeginStr, orderDateEndStr, inRepertoryNoStr, outRepertoryNoStr, reqDepStr, empNameStr, commonStr, false);

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
        private void gridViewIMHead_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (gridViewIMHead.GetFocusedDataRow() != null)
                {
                    if (onlySelectColChangeRowState)
                    {
                        dataSet_IM.Tables[0].AcceptChanges();
                        onlySelectColChangeRowState = false;
                    }
                    else
                    {
                        if (headFocusedLineNo < gridViewIMHead.DataRowCount && gridViewIMHead.FocusedRowHandle != headFocusedLineNo && gridViewIMHead.GetDataRow(headFocusedLineNo).RowState != DataRowState.Unchanged)
                        {
                            MessageHandler.ShowMessageBox(tsmiDqkcyddyjxghh.Text);// ("当前库存移动单已经修改，请保存后再进行换行。");
                            gridViewIMHead.FocusedRowHandle = headFocusedLineNo;
                        }
                        else if (headFocusedLineNo == gridViewIMHead.DataRowCount)
                        {

                        }
                        else
                        {
                            if (gridViewIMHead.FocusedRowHandle != headFocusedLineNo && gridViewIMHead.GetDataRow(headFocusedLineNo).RowState != DataRowState.Unchanged)
                                btnCancel_Click(null, null);
                            else if (gridViewIMHead.GetDataRow(headFocusedLineNo).RowState == DataRowState.Unchanged)
                                btnCancel_Click(null, null);
                        }
                    }

                    if (DataTypeConvert.GetString(gridViewIMHead.GetFocusedDataRow()["InventoryMoveNo"]) != "")
                    {
                        dataSet_IM.Tables[1].Clear();
                        imDAO.QueryInventoryMoveList(dataSet_IM.Tables[1], DataTypeConvert.GetString(gridViewIMHead.GetFocusedDataRow()["InventoryMoveNo"]), false);
                        //if (queryListAutoId > 0)
                        //{
                        //    for (int i = 0; i < gridViewIMList.DataRowCount; i++)
                        //    {
                        //        if (DataTypeConvert.GetInt(gridViewIMList.GetDataRow(i)["AutoId"]) == queryListAutoId)
                        //        {
                        //            gridViewIMList.FocusedRowHandle = i;
                        //            queryListAutoId = 0;
                        //            break;
                        //        }
                        //    }
                        //}
                    }

                    if (gridViewIMHead.FocusedRowHandle >= 0)
                    {
                        headFocusedLineNo = gridViewIMHead.FocusedRowHandle;
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
        private void gridViewIMHead_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
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
        private void gridViewIMHead_KeyDown(object sender, KeyEventArgs e)
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
                gridViewIMHead.AddNewRow();
                FocusedHeadView("OutRepertoryNo");

                dataSet_IM.Tables[1].Clear();
                gridViewIMList.AddNewRow();
                FocusedListView(false, "CodeFileName", gridViewIMList.GetFocusedDataSourceRowIndex());
                gridViewIMList.RefreshData();

                SetButtonAndColumnState(true);
                headFocusedLineNo = gridViewIMHead.DataRowCount;
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
                if (gridViewIMHead.GetFocusedDataRow() == null)
                    return;

                //if (!CheckReqState())
                //    return;

                if (btnSave.Tag.ToString() != f.tsmiBc.Text)
                {
                    ClearHeadGridAllSelect();

                    SetButtonAndColumnState(true);
                    FocusedHeadView("OutRepertoryNo");
                }
                else
                {
                    DataRow headRow = gridViewIMHead.GetFocusedDataRow();
                    string outRepertoryNoStr = DataTypeConvert.GetString(headRow["OutRepertoryNo"]);
                    string inRepertoryNoStr = DataTypeConvert.GetString(headRow["InRepertoryNo"]);
                    if (outRepertoryNoStr == "")
                    {
                        MessageHandler.ShowMessageBox(tsmiCkckbnwkbc.Text);// ("出库仓库不能为空，请填写后再进行保存。");
                        FocusedHeadView("OutRepertoryNo");
                        return;
                    }
                    if (inRepertoryNoStr == "")
                    {
                        MessageHandler.ShowMessageBox(tsmiRkckbnwkbc.Text);// ("入库仓库不能为空，请填写后再进行保存。");
                        FocusedHeadView("InRepertoryNo");
                        return;
                    }
                    if (DataTypeConvert.GetString(headRow["ReqDep"]) == "")
                    {
                        MessageHandler.ShowMessageBox(tsmiSqbmbnwkbc.Text);// ("申请部门不能为空，请填写后再进行保存。");
                        FocusedHeadView("ReqDep");
                        return;
                    }

                    for (int i = gridViewIMList.DataRowCount - 1; i >= 0; i--)
                    {
                        DataRow listRow = gridViewIMList.GetDataRow(i);
                        if (DataTypeConvert.GetString(listRow["CodeFileName"]) == "")
                        {
                            gridViewIMList.DeleteRow(i);
                            continue;
                        }
                        if (DataTypeConvert.GetString(listRow["Qty"]) == "")
                        {
                            MessageHandler.ShowMessageBox(tsmiSlbnwkbc.Text);// ("数量不能为空，请填写后再进行保存。");
                            FocusedListView(true, "Qty", i);
                            return;
                        }
                        string outProjectNoStr = DataTypeConvert.GetString(listRow["OutProjectNo"]);
                        string outShelfNoStr = DataTypeConvert.GetString(listRow["OutShelfNo"]);
                        string inProjectNoStr = DataTypeConvert.GetString(listRow["InProjectNo"]);
                        string inShelfNoStr = DataTypeConvert.GetString(listRow["InShelfNo"]);

                        if (outProjectNoStr == "")
                        {
                            MessageHandler.ShowMessageBox(tsmiCkxmhbnwkbc.Text);// ("出库项目号不能为空，请填写后再进行保存。");
                            FocusedListView(true, "OutProjectNo", i);
                            return;
                        }
                        if (outShelfNoStr == "")
                        {
                            MessageHandler.ShowMessageBox(tsmiCkhjhbnwkbc.Text);// ("出库货架号不能为空，请填写后再进行保存。");
                            FocusedListView(true, "OutShelfNo", i);
                            return;
                        }
                        if (inProjectNoStr == "")
                        {
                            MessageHandler.ShowMessageBox(tsmiRkxmhbnwkbc.Text);// ("入库项目号不能为空，请填写后再进行保存。");
                            FocusedListView(true, "InProjectNo", i);
                            return;
                        }
                        if (inShelfNoStr == "")
                        {
                            MessageHandler.ShowMessageBox(tsmiRkhjhbnwkbc.Text);// ("入库货架号不能为空，请填写后再进行保存。");
                            FocusedListView(true, "InShelfNo", i);
                            return;
                        }
                        if (outRepertoryNoStr == inRepertoryNoStr && outProjectNoStr == inProjectNoStr && outShelfNoStr == inShelfNoStr)
                        {
                            MessageHandler.ShowMessageBox(tsmiCkdckxmhhjhhrk.Text);// ("出库的仓库项目号货架号和入库的仓库项目号货架号完全相同，请填写后再进行保存。");
                            FocusedListView(true, "OutProjectNo", i);
                            return;
                        }
                    }

                    int ret = imDAO.SaveInventoryMove(gridViewIMHead.GetFocusedDataRow(), dataSet_IM.Tables[1]);
                    switch (ret)
                    {
                        case -1:
                            btnQuery_Click(null, null);
                            break;
                        case 1:
                            dataSet_IM.Tables[1].Clear();
                            imDAO.QueryInventoryMoveList(dataSet_IM.Tables[1], DataTypeConvert.GetString(gridViewIMHead.GetFocusedDataRow()["InventoryMoveNo"]), false);
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
                if (gridViewIMHead.GetDataRow(headFocusedLineNo).RowState != DataRowState.Unchanged)
                {
                    if (DataTypeConvert.GetString(gridViewIMHead.GetDataRow(headFocusedLineNo)["InventoryMoveNo"]) == "")
                    {
                        gridViewIMHead.DeleteRow(headFocusedLineNo);
                    }
                    else
                    {
                        gridViewIMHead.GetFocusedDataRow().RejectChanges();
                    }
                }

                SetButtonAndColumnState(false);

                dataSet_IM.Tables[1].Clear();
                if (gridViewIMHead.GetFocusedDataRow() != null)
                    imDAO.QueryInventoryMoveList(dataSet_IM.Tables[1], DataTypeConvert.GetString(gridViewIMHead.GetFocusedDataRow()["InventoryMoveNo"]), false);

                //gridViewPrReqHead_FocusedRowChanged(sender, null);
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
                int count = dataSet_IM.Tables[0].Select("select=1").Length;
                if (count == 0)
                {
                    MessageHandler.ShowMessageBox(f.tsmiQzyczdjlq.Text);// ("请在要操作的记录前面选中。");
                    return;
                }

                //if (!CheckReqState_Multi(false, true, true, true))
                //    return;

                //if (MessageHandler.ShowMessageBox_YesNo(string.Format("确定要删除当前选中的{0}条记录吗？", count)) != DialogResult.Yes)
                if (MessageHandler.ShowMessageBox_YesNo(string.Format(f.tsmiQdyscdqxzd.Text + "{0}" + f.tsmiTjlm.Text, count)) != DialogResult.Yes)
                {
                    return;
                }
                if (!imDAO.DeleteInventoryMove_Multi(dataSet_IM.Tables[0]))
                {

                }

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
        /// 预览按钮事件
        /// </summary>
        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                string imHeadNoStr = "";
                if (gridViewIMHead.GetFocusedDataRow() != null)
                    imHeadNoStr = DataTypeConvert.GetString(gridViewIMHead.GetFocusedDataRow()["InventoryMoveNo"]);
                imDAO.PrintHandle(imHeadNoStr, 1);
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
            foreach (DataRow dr in dataSet_IM.Tables[0].Rows)
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
        private void gridViewIMHead_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            try
            {
                DateTime nowDate = BaseSQL.GetServerDateTime();
                gridViewIMHead.SetFocusedRowCellValue("InventoryMoveDate", nowDate);
                gridViewIMHead.SetFocusedRowCellValue("ReqDep", SystemInfo.user.DepartmentNo);
                gridViewIMHead.SetFocusedRowCellValue("Prepared", SystemInfo.user.EmpName);
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
        private void gridViewIMList_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            try
            {
                gridViewIMList.SetFocusedRowCellValue("InventoryMoveNo", DataTypeConvert.GetString(gridViewIMHead.GetFocusedDataRow()["InventoryMoveNo"]));
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
        private void gridViewIMList_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (!colRemark.OptionsColumn.AllowEdit)
                        return;

                    if (gridViewIMList.GetFocusedDataSourceRowIndex() >= gridViewIMList.DataRowCount - 1 && gridViewIMList.FocusedColumn.Name == "colRemark")
                    {
                        ListNewRow();
                    }
                    else if (gridViewIMList.FocusedColumn.Name == "colRemark")
                    {
                        gridViewIMList.FocusedRowHandle = gridViewIMList.FocusedRowHandle + 1;
                        FocusedListView(true, "CodeFileName", gridViewIMList.GetFocusedDataSourceRowIndex());
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
                //int prListAutoIdInt = 0;
                //if (gridViewIMList.GetFocusedDataRow() != null)
                //    prListAutoIdInt = DataTypeConvert.GetInt(gridViewIMList.GetFocusedDataRow()["PrListAutoId"]);
                gridViewIMList.DeleteRow(gridViewIMList.FocusedRowHandle);
                //if (prListAutoIdInt > 0)
                //    gridViewPrReqHead_FocusedRowChanged(sender, null);
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
        private void gridViewIMList_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                string tmpStr = "";
                switch (e.Column.FieldName)
                {
                    case "CodeFileName":
                        tmpStr = DataTypeConvert.GetString(gridViewIMList.GetDataRow(e.RowHandle)["CodeFileName"]);
                        if (tmpStr == "")
                            gridViewIMList.SetRowCellValue(e.RowHandle, "CodeName", "");
                        else
                        {
                            DataTable temp = (DataTable)repSearchCodeFileName.DataSource;
                            DataRow[] drs = temp.Select(string.Format("CodeFileName='{0}'", tmpStr));
                            if (drs.Length > 0)
                            {
                                gridViewIMList.SetRowCellValue(e.RowHandle, "CodeName", DataTypeConvert.GetString(drs[0]["CodeName"]));
                            }
                        }
                        break;
                    case "OutProjectNo":
                        tmpStr = DataTypeConvert.GetString(gridViewIMList.GetDataRow(e.RowHandle)["OutProjectNo"]);
                        if (tmpStr == "")
                            gridViewIMList.SetRowCellValue(e.RowHandle, "OutProjectName", "");
                        else
                        {
                            DataTable temp = (DataTable)repSearchOutProjectNo.DataSource;
                            DataRow[] drs = temp.Select(string.Format("ProjectNo='{0}'", tmpStr));
                            if (drs.Length > 0)
                            {
                                gridViewIMList.SetRowCellValue(e.RowHandle, "OutProjectName", DataTypeConvert.GetString(drs[0]["ProjectName"]));
                            }
                        }
                        break;
                    case "InProjectNo":
                        tmpStr = DataTypeConvert.GetString(gridViewIMList.GetDataRow(e.RowHandle)["InProjectNo"]);
                        if (tmpStr == "")
                            gridViewIMList.SetRowCellValue(e.RowHandle, "InProjectName", "");
                        else
                        {
                            DataTable temp = (DataTable)repSearchOutProjectNo.DataSource;
                            DataRow[] drs = temp.Select(string.Format("ProjectNo='{0}'", tmpStr));
                            if (drs.Length > 0)
                            {
                                gridViewIMList.SetRowCellValue(e.RowHandle, "InProjectName", DataTypeConvert.GetString(drs[0]["ProjectName"]));
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
            if (DataTypeConvert.GetBoolean(gridViewIMHead.GetFocusedDataRow()["Select"]))
                gridViewIMHead.GetFocusedDataRow()["Select"] = false;
            else
                gridViewIMHead.GetFocusedDataRow()["Select"] = true;
            onlySelectColChangeRowState = true;
        }

        /// <summary>
        /// 检查是否有未填写字段
        /// </summary>
        private bool IsHaveBlankLine()
        {
            gridViewIMList.FocusedRowHandle = 0;
            for (int i = 0; i < gridViewIMList.DataRowCount; i++)
            {
                if (DataTypeConvert.GetString(gridViewIMList.GetDataRow(i)["CodeFileName"]) == "")
                {
                    gridViewIMList.Focus();
                    gridViewIMList.FocusedColumn = colCodeFileName;
                    gridViewIMList.FocusedRowHandle = i;
                    return true;
                }
                if (DataTypeConvert.GetString(gridViewIMList.GetDataRow(i)["Qty"]) == "")
                {
                    gridViewIMList.Focus();
                    gridViewIMList.FocusedColumn = colQty;
                    gridViewIMList.FocusedRowHandle = i;
                    return true;
                }
                if (DataTypeConvert.GetString(gridViewIMList.GetDataRow(i)["OutProjectNo"]) == "")
                {
                    gridViewIMList.Focus();
                    gridViewIMList.FocusedColumn = colOutProjectNo;
                    gridViewIMList.FocusedRowHandle = i;
                    return true;
                }
                if (DataTypeConvert.GetString(gridViewIMList.GetDataRow(i)["OutShelfNo"]) == "")
                {
                    gridViewIMList.Focus();
                    gridViewIMList.FocusedColumn = colOutShelfNo;
                    gridViewIMList.FocusedRowHandle = i;
                    return true;
                }
                if (DataTypeConvert.GetString(gridViewIMList.GetDataRow(i)["InProjectNo"]) == "")
                {
                    gridViewIMList.Focus();
                    gridViewIMList.FocusedColumn = colInProjectNo;
                    gridViewIMList.FocusedRowHandle = i;
                    return true;
                }
                if (DataTypeConvert.GetString(gridViewIMList.GetDataRow(i)["InShelfNo"]) == "")
                {
                    gridViewIMList.Focus();
                    gridViewIMList.FocusedColumn = colInShelfNo;
                    gridViewIMList.FocusedRowHandle = i;
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
            gridViewIMList.AddNewRow();
            FocusedListView(true, "CodeFileName", gridViewIMList.GetFocusedDataSourceRowIndex());
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
            btnPreview.Enabled = !ret;

            btnListAdd.Enabled = ret;

            colOutRepertoryNo.OptionsColumn.AllowEdit = ret;
            colInRepertoryNo.OptionsColumn.AllowEdit = ret;
            colPRemark.OptionsColumn.AllowEdit = ret;

            colCodeFileName.OptionsColumn.AllowEdit = ret;
            colQty.OptionsColumn.AllowEdit = ret;
            colOutProjectNo.OptionsColumn.AllowEdit = ret;
            colOutShelfNo.OptionsColumn.AllowEdit = ret;
            colInProjectNo.OptionsColumn.AllowEdit = ret;
            colInShelfNo.OptionsColumn.AllowEdit = ret;
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
            gridControlIMHead.Focus();
            ColumnView headView = (ColumnView)gridControlIMHead.FocusedView;
            headView.FocusedColumn = headView.Columns[colName];
            gridViewIMHead.FocusedRowHandle = headView.FocusedRowHandle;
        }

        /// <summary>
        /// 聚焦子表当前行的列
        /// </summary>
        private void FocusedListView(bool isFocusedControl, string colName, int lineNo)
        {
            if (isFocusedControl)
                gridControlIMList.Focus();
            ColumnView listView = (ColumnView)gridControlIMList.FocusedView;
            listView.FocusedColumn = listView.Columns[colName];
            gridViewIMList.FocusedRowHandle = lineNo;
        }

        /// <summary>
        /// 清楚当前的所有选择
        /// </summary>
        private void ClearHeadGridAllSelect()
        {
            checkAll.Checked = false;
            for (int i = 0; i < dataSet_IM.Tables[0].Rows.Count; i++)
            {
                dataSet_IM.Tables[0].Rows[i]["Select"] = false;
            }
            dataSet_IM.Tables[0].AcceptChanges();
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
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiCcdqkdsjcw.Text, ex);
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
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiZgridviewzaxsbsjcw.Text, ex);
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
                    WNowInfoToInvMove_DragOrder(sender, drs);
                    ClearAlreadyDragWNowInfo();
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--实现拖拽当前库存事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiSxtzcgddsjcw.Text, ex);
            }
        }

        /// <summary>
        /// 拖拽当前库存转成库存移动单 
        /// </summary>
        private void WNowInfoToInvMove_DragOrder(object sender, List<DataRow> drs)
        {
            string repertoryNoStr = "";
            if (drs.Count > 0)
                repertoryNoStr = DataTypeConvert.GetString(drs[0]["RepertoryNo"]);
            else
                return;

            foreach (DataRow dr in drs)
            {
                if (DataTypeConvert.GetString(dr["RepertoryNo"]) != repertoryNoStr)
                {
                    //MessageHandler.ShowMessageBox("一张库存移动单必须选择相同的仓库进行登记，请重新操作。");
                    MessageHandler.ShowMessageBox(tsmiYzkcyddbxxz.Text);
                    return;
                }
            }

            if (btnNew.Enabled)
            {
                ClearHeadGridAllSelect();
                gridViewIMHead.AddNewRow();
                FocusedHeadView("OutRepertoryNo");

                gridViewIMHead.SetFocusedRowCellValue("OutRepertoryNo", repertoryNoStr);

                dataSet_IM.Tables[1].Clear();
                foreach (DataRow dr in drs)
                {
                    gridViewIMList.AddNewRow();
                    gridViewIMList.SetFocusedRowCellValue("CodeFileName", dr["CodeFileName"]);
                    gridViewIMList.SetFocusedRowCellValue("CodeName", dr["CodeName"]);
                    gridViewIMList.SetFocusedRowCellValue("Qty", DataTypeConvert.GetDouble(dr["Qty"]));
                    gridViewIMList.SetFocusedRowCellValue("OutProjectNo", dr["ProjectNo"]);
                    gridViewIMList.SetFocusedRowCellValue("OutShelfNo", dr["ShelfNo"]);
                    gridViewIMList.SetFocusedRowCellValue("OutRepertoryNo", repertoryNoStr);
                }
                gridViewIMList.RefreshData();
                FocusedListView(false, "Qty", gridViewIMList.GetFocusedDataSourceRowIndex());

                SetButtonAndColumnState(true);
                headFocusedLineNo = gridViewIMHead.DataRowCount;
            }
            else
            {
                string outRepertoryNoStr = DataTypeConvert.GetString(gridViewIMHead.GetFocusedDataRow()["OutRepertoryNo"]);
                if (outRepertoryNoStr == "")
                {
                    outRepertoryNoStr = repertoryNoStr;
                    gridViewIMHead.GetFocusedDataRow()["OutRepertoryNo"] = repertoryNoStr;
                }
                else
                {
                    if (outRepertoryNoStr != repertoryNoStr)
                    {
                        //MessageHandler.ShowMessageBox("一张库存移动单必须选择相同的仓库进行登记，请重新操作。");
                        MessageHandler.ShowMessageBox(tsmiYzkcyddbxxz.Text);
                        return;
                    }
                }

                foreach (DataRow dr in drs)
                {
                    string codeFileNameStr = DataTypeConvert.GetString(dr["CodeFileName"]);
                    string projectNoStr = DataTypeConvert.GetString(dr["ProjectNo"]);
                    string shelfNoStr = DataTypeConvert.GetString(dr["ShelfNo"]);
                    if (dataSet_IM.Tables[1].Select(string.Format("CodeFileName='{0}' and OutProjectNo='{1}' and OutShelfNo='{2}'", codeFileNameStr, projectNoStr, shelfNoStr)).Length > 0)
                        continue;

                    gridViewIMList.AddNewRow();
                    gridViewIMList.SetFocusedRowCellValue("CodeFileName", codeFileNameStr);
                    gridViewIMList.SetFocusedRowCellValue("CodeName", dr["CodeName"]);
                    gridViewIMList.SetFocusedRowCellValue("Qty", DataTypeConvert.GetDouble(dr["Qty"]));
                    gridViewIMList.SetFocusedRowCellValue("OutProjectNo", projectNoStr);
                    gridViewIMList.SetFocusedRowCellValue("OutShelfNo", shelfNoStr);
                    gridViewIMList.SetFocusedRowCellValue("OutRepertoryNo", repertoryNoStr);
                }

                gridViewIMList.FocusedRowHandle = gridViewIMList.DataRowCount;
                FocusedListView(false, "Qty", gridViewIMList.GetFocusedDataSourceRowIndex());
                gridViewIMList.RefreshData();
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
