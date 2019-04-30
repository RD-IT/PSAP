using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraTreeList.Nodes;
using PSAP.DAO.BSDAO;
using PSAP.PSAPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PSAP.VIEW.BSVIEW
{
    public partial class FrmBomManagement : DockContent
    {
        FrmCommonDAO commonDAO = new FrmCommonDAO();
        FrmBomManagementDAO bomDAO = new FrmBomManagementDAO();

        /// <summary>
        /// 历史查询记录
        /// </summary>
        List<string> historyQuery = new List<string>();

        /// <summary>
        /// 要查询的零件编号
        /// </summary>
        public static string queryCodeFileNameStr = "";

        /// <summary>
        /// 要查询的父零件编号
        /// </summary>
        public static string queryParentCodeFileNameStr = "";
        static PSAP.VIEW.BSVIEW.FrmLanguageText f = new VIEW.BSVIEW.FrmLanguageText();

        public FrmBomManagement()
        {
            InitializeComponent();
            PSAP.BLL.BSBLL.BSBLL.language(f);
            PSAP.BLL.BSBLL.BSBLL.language(this);
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmBomManagement_Load(object sender, EventArgs e)
        {
            try
            {
                ControlHandler.DevExpressStyle_ChangeControlLocation(btnListAdd.LookAndFeel.ActiveSkinName, new List<Control> { btnListAdd });

                searchPartsCodeId.Properties.DataSource = commonDAO.QueryPartsCode(false);
                lookUpMaterieState.Properties.DataSource = bomDAO.QueryBomMaterieState(false);

                repSearchCodeFileName.DataSource = commonDAO.QueryPartsCode(false);

                searchCodeFileName.Properties.DataSource = commonDAO.QueryPartsCode(false);
                //RefreshTreeList();
                Set_ButtonEditGrid_State(true, null);
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
        private void FrmBomManagement_Activated(object sender, EventArgs e)
        {
            try
            {
                if (queryCodeFileNameStr != "")
                {
                    searchCodeFileName.EditValue = queryCodeFileNameStr;
                    searchCodeFileName.Tag = queryParentCodeFileNameStr;
                    queryCodeFileNameStr = "";
                    queryParentCodeFileNameStr = "";
                    //RefreshTreeList();
                    btnQuery_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--窗体激活事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiCtjhsjcw.Text, ex);
            }
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewBomMateriel_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            ControlHandler.GridView_CustomDrawRowIndicator(e);
        }

        /// <summary>
        /// 获取单元格显示的信息
        /// </summary>
        private void treeListBom_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                ControlHandler.TreeList_GetFocusedCellDisplayText_KeyDown(sender, e);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--获取单元格显示的信息错误。", ex);
            }
        }

        /// <summary>
        /// 聚焦查询当前选中Bom信息
        /// </summary>
        private void treeListBom_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            try
            {
                if (treeListBom.FocusedNode != null)
                {
                    string materielNoStr = DataTypeConvert.GetString(treeListBom.FocusedNode["CodeFileName"]);
                    RefreshBomInfo(materielNoStr);
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--聚焦查询当前选中Bom信息错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiJjcxdqxzbomxx.Text, ex);
            }
        }

        /// <summary>
        /// 新增按钮事件
        /// </summary>
        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow drHead = dSBom.Tables[0].NewRow();
                dSBom.Tables[0].Rows.Add(drHead);
                bSBomManagement.MoveLast();

                dSBom.Tables[1].Clear();
                gridViewBomMateriel.AddNewRow();
                FocusedListView(false, "CodeFileName", gridViewBomMateriel.GetFocusedDataSourceRowIndex());
                gridViewBomMateriel.RefreshData();

                Set_ButtonEditGrid_State(false, drHead);
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
                if (dSBom.Tables[0].Rows.Count == 0 || bSBomManagement.Current == null)
                    return;

                if (btnSave.Tag.ToString() != "保存")
                {
                    Set_ButtonEditGrid_State(false, dSBom.Tables[0].Rows[0]);
                    lookUpMaterieState.Focus();
                }
                else
                {
                    bSBomManagement.EndEdit();
                    DataRow headRow = ((DataRowView)bSBomManagement.Current).Row;

                    int partsCodeIdInt = DataTypeConvert.GetInt(headRow["PartsCodeId"]);
                    if (partsCodeIdInt == 0)
                    {
                        MessageHandler.ShowMessageBox(tsmiLjmcbnwk.Text);// ("零件名称不能为空，请填写后再进行保存。");
                        searchPartsCodeId.Focus();
                        return;
                    }

                    DataTable tmpTable = (DataTable)searchPartsCodeId.Properties.DataSource;
                    DataRow[] drs = tmpTable.Select(string.Format("AutoId={0}", partsCodeIdInt));
                    if (drs.Length == 0)
                    {
                        MessageHandler.ShowMessageBox(tsmiLjmccxxxcw.Text);// ("零件名称查询信息错误，请填写后再进行保存。");
                        searchPartsCodeId.Focus();
                        return;
                    }
                    headRow["MaterielNo"] = DataTypeConvert.GetString(drs[0]["CodeFileName"]);
                    headRow["CodeName"] = searchPartsCodeId.Text;

                    for (int i = gridViewBomMateriel.DataRowCount - 1; i >= 0; i--)
                    {
                        DataRow listRow = gridViewBomMateriel.GetDataRow(i);
                        if (DataTypeConvert.GetString(listRow["LevelMaterielNo"]) == "")
                        {
                            gridViewBomMateriel.DeleteRow(i);
                            continue;
                        }
                        if (DataTypeConvert.GetString(listRow["Qty"]) == "")
                        {
                            MessageHandler.ShowMessageBox(f.tsmiSlbnwkbc.Text);// ("数量不能为空，请填写后再进行保存。");
                            FocusedListView(true, "Qty", i);
                            return;
                        }
                    }

                    int ret = bomDAO.SaveBomManagement(headRow, dSBom.Tables[1]);
                    switch (ret)
                    {
                        case -1:

                            break;
                        case 1:

                            break;
                        case 0:
                            return;
                    }
                    RefreshTreeList();
                    treeListBom_FocusedNodeChanged(null, null);
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
                //treeListBom_FocusedNodeChanged(null, null);

                if (bSBomManagement.Current != null)
                {
                    bool isNew = ((DataRowView)bSBomManagement.Current).Row.RowState == DataRowState.Added;
                    bSBomManagement.CancelEdit();
                    ((DataRowView)bSBomManagement.Current).Row.RejectChanges();

                    dSBom.Tables[0].Rows.Clear();
                    dSBom.Tables[1].Rows.Clear();
                    Set_ButtonEditGrid_State(true, null);

                    //if (!isNew)
                        treeListBom_FocusedNodeChanged(null, null);
                }
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
                if (dSBom.Tables[0].Rows.Count == 0)
                {
                    MessageHandler.ShowMessageBox(f.tsmiQzyczdjlq.Text);// ("请在要操作的记录前面选中。");
                    return;
                }

                //if (MessageHandler.ShowMessageBox_YesNo(string.Format("确定要删除当前选中的{0}条记录吗？", 1)) != DialogResult.Yes)
                if (MessageHandler.ShowMessageBox_YesNo(string.Format(f.tsmiQdyscdqxzd.Text + "{0}" + f.tsmiTjlm.Text, 1)) != DialogResult.Yes)
                {
                    return;
                }
                DataRow headRow = ((DataRowView)bSBomManagement.Current).Row;
                bomDAO.DeleteBomManagement(headRow);

                RefreshTreeList();
                treeListBom_FocusedNodeChanged(null, null);
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--删除按钮事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiScansj.Text, ex);
            }
        }

        /// <summary>
        /// 刷新按钮事件
        /// </summary>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            treeListBom_FocusedNodeChanged(null, null);
        }

        /// <summary>
        /// 子表新增一行事件
        /// </summary>
        private void btnListAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!colLevelMaterielNo.OptionsColumn.AllowEdit)
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
        /// 删除子表中的一行
        /// </summary>
        private void repbtnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (gridViewBomMateriel.GetFocusedDataRow().RowState != DataRowState.Added)
                {
                    if (MessageHandler.ShowMessageBox_YesNo("确定要删除当前选中的明细记录吗？") != DialogResult.Yes)
                    {
                        return;
                    }
                }
                //int prListAutoIdInt = 0;
                //if (gridViewIMList.GetFocusedDataRow() != null)
                //    prListAutoIdInt = DataTypeConvert.GetInt(gridViewIMList.GetFocusedDataRow()["PrListAutoId"]);
                gridViewBomMateriel.DeleteRow(gridViewBomMateriel.FocusedRowHandle);
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
        /// 设定主表的默认值
        /// </summary>
        private void TableBomManagement_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            try
            {
                if (treeListBom.FocusedNode != null && dSBom.Tables[0].Select(string.Format("PartsCodeId={0}", DataTypeConvert.GetInt(treeListBom.FocusedNode["PCAutoId"]))).Length == 0)
                {
                    e.Row["PartsCodeId"] = DataTypeConvert.GetInt(treeListBom.FocusedNode["PCAutoId"]);
                    e.Row["MaterielNo"] = DataTypeConvert.GetString(treeListBom.FocusedNode["CodeFileName"]);
                    e.Row["CodeName"] = DataTypeConvert.GetString(treeListBom.FocusedNode["CodeName"]);
                }
                e.Row["GetTime"] = BaseSQL.GetServerDateTime();
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--设定主表的默认值错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiCxbhgjzdjdcw.Text, ex);
            }
        }

        /// <summary>
        /// 设定子表的默认值
        /// </summary>
        private void TableBomMateriel_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            try
            {
                if (bSBomManagement.Current != null)
                {
                    DataRow headRow = ((DataRowView)bSBomManagement.Current).Row;
                    e.Row["MaterielNo"] = DataTypeConvert.GetString(headRow["MaterielNo"]);
                    e.Row["Qty"] = 1;
                    e.Row["GetTime"] = BaseSQL.GetServerDateTime();
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--设定子表的默认值错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiCxbhgjzdjdcw.Text, ex);
            }
        }

        /// <summary>
        /// 子表单元格值变化进行的操作
        /// </summary>
        private void gridViewBomMateriel_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            try
            {
                string tmpStr = "";
                switch (e.Column.FieldName)
                {
                    case "LevelMaterielNo":
                        tmpStr = DataTypeConvert.GetString(gridViewBomMateriel.GetDataRow(e.RowHandle)["LevelMaterielNo"]);
                        for (int i = 0; i < gridViewBomMateriel.DataRowCount; i++)
                        {
                            if (i != e.RowHandle)
                            {
                                string lineMaterNo = DataTypeConvert.GetString(gridViewBomMateriel.GetDataRow(i)["LevelMaterielNo"]);
                                if (tmpStr == lineMaterNo)
                                {
                                    MessageHandler.ShowMessageBox("当前选择的子零件编号已经重复，请在同一项设定数量。");
                                    //gridViewBomMateriel.SetRowCellValue(e.RowHandle, "LevelMaterielNo", "");
                                    //gridViewBomMateriel.SetRowCellValue(e.RowHandle, "CodeName", "");

                                    gridViewBomMateriel.DeleteRow(e.RowHandle);
                                    gridViewBomMateriel.FocusedRowHandle = i;
                                    return;
                                }
                            }
                            else
                            {

                            }
                        }

                        if (tmpStr == "")
                            gridViewBomMateriel.SetRowCellValue(e.RowHandle, "CodeName", "");
                        else
                        {
                            DataTable temp = (DataTable)repSearchCodeFileName.DataSource;
                            DataRow[] drs = temp.Select(string.Format("CodeFileName='{0}'", tmpStr));
                            if (drs.Length > 0)
                            {
                                gridViewBomMateriel.SetRowCellValue(e.RowHandle, "LevelMaterielName", DataTypeConvert.GetString(drs[0]["CodeName"]));
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
        /// 子表按键事件
        /// </summary>
        private void gridViewBomMateriel_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (!colQty.OptionsColumn.AllowEdit)
                        return;

                    if (gridViewBomMateriel.GetFocusedDataSourceRowIndex() >= gridViewBomMateriel.DataRowCount - 1 && gridViewBomMateriel.FocusedColumn.Name == "colQty")
                    {
                        gridViewBomMateriel.PostEditor();
                        ListNewRow();
                    }
                    else if (gridViewBomMateriel.FocusedColumn.Name == "colQty")
                    {
                        gridViewBomMateriel.FocusedRowHandle = gridViewBomMateriel.FocusedRowHandle + 1;
                        FocusedListView(true, "LevelMaterielNo", gridViewBomMateriel.GetFocusedDataSourceRowIndex());
                    }
                }
                else
                    ControlHandler.GridView_GetFocusedCellDisplayText_KeyDown(sender, e);
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--子表按键事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiZbajsjcw.Text, ex);
            }
        }

        /// <summary>
        /// 查询包含关键字的节点
        /// </summary>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                string codeFileNameStr = DataTypeConvert.GetString(searchCodeFileName.EditValue);
                treeListBom.DataSource = bomDAO.QueryBomTreeList_MoreInfo(codeFileNameStr);
                treeListBom.ExpandAll();
                //if (textCodeFileName.Text.Trim() != "")
                //{
                //    for (int i = 0; i < treeListBom.Nodes.Count; i++)
                //    {
                //        string parentCodeFileNameStr = "";
                //        if (DataTypeConvert.GetString(textCodeFileName.Tag) != "")
                //        {
                //            parentCodeFileNameStr = DataTypeConvert.GetString(textCodeFileName.Tag);
                //            textCodeFileName.Tag = "";
                //        }
                //        if (SearchFocusNode_CodeFileName(treeListBom.Nodes[i], textCodeFileName.Text.Trim(), parentCodeFileNameStr))
                //            break;

                //        if (i == treeListBom.Nodes.Count - 1)
                //        {
                //            historyQuery.Clear();
                //            if (treeListBom.Nodes.Count > 0)
                //                treeListBom.FocusedNode = treeListBom.Nodes[0];
                //        }
                //    }
                //}
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--查询包含关键字的节点错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiCxbhgjzdjdcw.Text, ex);
            }
        }

        /// <summary>
        /// 清空历史查询记录
        /// </summary>
        private void textCodeFileName_EditValueChanged(object sender, EventArgs e)
        {
            historyQuery.Clear();
        }

        /// <summary>
        /// 刷新Bom树形信息
        /// </summary>
        private void RefreshTreeList()
        {
            string cReIDStr = "";
            if (treeListBom.DataSource != null)
            {
                cReIDStr = DataTypeConvert.GetString(treeListBom.FocusedNode["ReID"]);
            }
            //treeListBom.DataSource = bomDAO.QueryBomTreeList_BaseInfo("");
            //treeListBom.ExpandAll();
            btnQuery_Click(null, null);

            if (cReIDStr != "")
            {
                for (int i = 0; i < treeListBom.Nodes.Count; i++)
                {
                    if (SearchFocusNode(treeListBom.Nodes[i], cReIDStr))
                        break;
                }
            }
        }

        /// <summary>
        /// 查询之前聚焦的节点
        /// </summary>
        private bool SearchFocusNode(TreeListNode node, string reIDStr)
        {
            if (DataTypeConvert.GetString(node["ReID"]) == reIDStr)
            {
                treeListBom.FocusedNode = node;
                return true;
            }
            for (int i = 0; i < node.Nodes.Count; i++)
            {
                if (SearchFocusNode(node.Nodes[i], reIDStr))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// 查询之前聚焦的节点
        /// </summary>
        private bool SearchFocusNode_CodeFileName(TreeListNode node, string codeFileNameStr, string parentCodeFileNameStr)
        {
            if (DataTypeConvert.GetString(node["CodeFileName"]).Contains(codeFileNameStr) && (parentCodeFileNameStr == "" || DataTypeConvert.GetString(node["ParentCodeFileName"]).Contains(parentCodeFileNameStr)))
            {
                string reIDStr = DataTypeConvert.GetString(node["ReID"]);
                if (!historyQuery.Contains(reIDStr))
                {
                    historyQuery.Add(reIDStr);
                    treeListBom.FocusedNode = node;
                    return true;
                }
            }
            for (int i = 0; i < node.Nodes.Count; i++)
            {
                if (SearchFocusNode_CodeFileName(node.Nodes[i], codeFileNameStr, parentCodeFileNameStr))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// 刷新当前选择
        /// </summary>
        /// <param name="materielNoStr"></param>
        private void RefreshBomInfo(string materielNoStr)
        {
            dSBom.Tables[0].Rows.Clear();
            dSBom.Tables[1].Rows.Clear();
            bomDAO.QueryBomManagement_Single(dSBom.Tables[0], materielNoStr);
            bomDAO.QueryBomMateriel(dSBom.Tables[1], materielNoStr);

            Set_ButtonEditGrid_State(true, dSBom.Tables[0].Rows.Count > 0 ? dSBom.Tables[0].Rows[0] : null);
        }

        /// <summary>
        /// 设定按钮编辑区列表区的状态
        /// </summary>
        private void Set_ButtonEditGrid_State(bool state, DataRow dr)
        {
            btnNew.Enabled = state;
            if (state)
            {
                btnSave.Tag = "修改";
                btnSave.Text = f.tsmiXg.Text;
            }
            else
            {
                btnSave.Tag = "保存";
                btnSave.Text = f.tsmiBc.Text;
            }
            btnCancel.Enabled = !state;
            btnDelete.Enabled = state;
            btnRefresh.Enabled = state;

            btnListAdd.Enabled = !state;

            ControlHandler ctlHandler = new ControlHandler();
            if (dr != null && dr.RowState == DataRowState.Added)
                ctlHandler.Set_Control_ReadOnly(searchPartsCodeId, state);
            else
                ctlHandler.Set_Control_ReadOnly(searchPartsCodeId, true);
            ctlHandler.Set_Control_ReadOnly(lookUpMaterieState, state);
            textCodeName.ReadOnly = true;

            gridViewBomMateriel.OptionsBehavior.Editable = !state;

            repbtnDelete.Buttons[0].Enabled = !state;
        }

        /// <summary>
        /// 聚焦子表当前行的列
        /// </summary>
        private void FocusedListView(bool isFocusedControl, string colName, int lineNo)
        {
            if (isFocusedControl)
                gridControlBomMateriel.Focus();
            ColumnView listView = (ColumnView)gridControlBomMateriel.FocusedView;
            listView.FocusedColumn = listView.Columns[colName];
            gridViewBomMateriel.FocusedRowHandle = lineNo;
        }

        /// <summary>
        /// 检查是否有未填写字段
        /// </summary>
        private bool IsHaveBlankLine()
        {
            gridViewBomMateriel.FocusedRowHandle = 0;
            for (int i = 0; i < gridViewBomMateriel.DataRowCount; i++)
            {
                if (DataTypeConvert.GetString(gridViewBomMateriel.GetDataRow(i)["LevelMaterielNo"]) == "")
                {
                    gridViewBomMateriel.Focus();
                    gridViewBomMateriel.FocusedColumn = colLevelMaterielNo;
                    gridViewBomMateriel.FocusedRowHandle = i;
                    return true;
                }
                if (DataTypeConvert.GetString(gridViewBomMateriel.GetDataRow(i)["Qty"]) == "")
                {
                    gridViewBomMateriel.Focus();
                    gridViewBomMateriel.FocusedColumn = colQty;
                    gridViewBomMateriel.FocusedRowHandle = i;
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
            gridViewBomMateriel.AddNewRow();
            FocusedListView(true, "LevelMaterielNo", gridViewBomMateriel.GetFocusedDataSourceRowIndex());
            //gridViewOrderList.RefreshData();
        }

        /// <summary>
        /// 根据选择显示零件名称
        /// </summary>
        private void searchPartsCodeId_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
                textCodeName.Text = DataTypeConvert.GetString(searchPartsCodeIdView.GetRowCellValue(searchPartsCodeId.Properties.GetIndexByKeyValue(e.NewValue), "CodeName"));

                string selectCodeFileName = DataTypeConvert.GetString(searchPartsCodeIdView.GetRowCellValue(searchPartsCodeId.Properties.GetIndexByKeyValue(e.NewValue), "CodeFileName"));
                DataTable tmpTable = new DataTable();
                bomDAO.QueryBomManagement_Single(tmpTable, selectCodeFileName);
                if(tmpTable.Rows.Count>0)
                {
                    MessageHandler.ShowMessageBox("当前选择的母零件编号已经设定过BOM信息，不可以重复登记。");
                    searchCodeFileName.EditValue = selectCodeFileName;
                    btnQuery_Click(null, null);
                    for (int i = 0; i < treeListBom.Nodes.Count; i++)
                    {
                        if (SearchCodeFileName(treeListBom.Nodes[i], selectCodeFileName))
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--根据选择显示零件名称错误。", ex);
            }
        }

        /// <summary>
        /// 查询之前聚焦的节点
        /// </summary>
        private bool SearchCodeFileName(TreeListNode node, string selectCodeFileName)
        {
            if (DataTypeConvert.GetString(node["CodeFileName"]) == selectCodeFileName)
            {
                treeListBom.FocusedNode = node;
                return true;
            }
            for (int i = 0; i < node.Nodes.Count; i++)
            {
                if (SearchFocusNode(node.Nodes[i], selectCodeFileName))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// 查询结果存为Excel
        /// </summary>
        private void btnSaveExcel_Click(object sender, EventArgs e)
        {
            try
            {
                FileHandler.SaveTreeListControlExportToExcel(treeListBom);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--查询结果存为Excel错误。", ex);
            }
        }
    }
}
