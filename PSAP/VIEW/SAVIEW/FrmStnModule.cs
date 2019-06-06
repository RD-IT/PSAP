using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using PSAP.DAO.BSDAO;
using PSAP.DAO.SADAO;
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
    public partial class FrmStnModule : DockContent
    {
        #region 私有变量

        FrmCommonDAO commonDAO = new FrmCommonDAO();
        FrmStnModuleDAO smDAO = new FrmStnModuleDAO();

        /// <summary>
        /// 要查询的功能模块号
        /// </summary>
        public static string querySMNoStr = "";

        /// <summary>
        /// 窗体加载默认新增状态
        /// </summary>
        public static bool defaultNewState = false;

        /// <summary>
        /// 窗体加载默认复制状态
        /// </summary>
        public static string copySMNoStr = "";

        /// <summary>
        /// 复制默认行的信息
        /// </summary>
        private DataRow copyRow = null;

        #endregion

        #region 构造方法

        public FrmStnModule()
        {
            InitializeComponent();
        }

        #endregion

        #region 窗体事件

        /// <summary>
        /// 窗体加载事件  
        /// </summary>
        private void FrmStnModule_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime nowDate = BaseSQL.GetServerDateTime();
                dateGetTimeBegin.DateTime = nowDate.Date.AddDays(-SystemInfo.OrderQueryDate_DefaultDays);
                dateGetTimeEnd.DateTime = nowDate.Date;

                Set_ButtonEditGrid_State(true);


                //构建GridLevelNode并添加到LevelTree集合里面
                GridLevelNode node = new GridLevelNode();
                node.LevelTemplate = gridViewMaterialDetail;
                node.RelationName = "RelationDM";//这里对应集合的属性名称
                gridControlDeliveryDetail.LevelTree.Nodes.AddRange(new GridLevelNode[] { node });

            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
            }
        }

        /// <summary>
        /// 窗体激活事件
        /// </summary>
        private void FrmStnModule_Activated(object sender, EventArgs e)
        {
            try
            {
                if (querySMNoStr != "")
                {
                    textCommon.Text = querySMNoStr;
                    querySMNoStr = "";

                    dataSet_StnModule.Tables[0].Clear();
                    smDAO.QueryStnModule(dataSet_StnModule.Tables[0], "", "", "", textCommon.Text);
                    Set_ButtonEditGrid_State(true);

                    if (dataSet_StnModule.Tables[0].Rows.Count > 0)
                    {
                        dateGetTimeBegin.DateTime = DataTypeConvert.GetDateTime(dataSet_StnModule.Tables[0].Rows[0]["GetTime"]).Date;
                        dateGetTimeEnd.DateTime = dateGetTimeBegin.DateTime.AddDays(7);
                    }
                }
                else if (defaultNewState)
                {
                    textCommon.Text = "";
                    dataSet_StnModule.Tables[0].Clear();
                    TableDeliveryDetail.Rows.Clear();
                    TableMaterialDetail.Rows.Clear();
                    btnNew_Click(null, null);
                    defaultNewState = false;
                }
                else if (copySMNoStr != "")
                {
                    textCommon.Text = copySMNoStr;
                    copySMNoStr = "";
                    dataSet_StnModule.Tables[0].Clear();
                    smDAO.QueryStnModule(dataSet_StnModule.Tables[0], "", "", "", textCommon.Text);
                    Set_ButtonEditGrid_State(true);
                    if (dataSet_StnModule.Tables[0].Rows.Count > 0)
                    {
                        dateGetTimeBegin.DateTime = DataTypeConvert.GetDateTime(dataSet_StnModule.Tables[0].Rows[0]["GetTime"]).Date;
                        dateGetTimeEnd.DateTime = dateGetTimeBegin.DateTime.AddDays(7);
                    }

                    btnCopy_Click(null, null);
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
        private void FrmStnModule_Shown(object sender, EventArgs e)
        {
            dockPnlLeft.Width = SystemInfo.DragForm_LeftDock_Width;
        }

        #endregion

        #region 供货明细列表区域事件和方法

        /// <summary>
        /// 新增供货明细事件
        /// </summary>
        private void btnDDNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataSet_StnModule.Tables[0].Rows.Count == 0 || bindingSource_StnModule.Current == null)
                    return;

                string smNoStr = DataTypeConvert.GetString(gridViewStnModule.GetFocusedDataRow()["SMNo"]);
                FrmDeliveryDetail ddForm = new FrmDeliveryDetail();
                FrmDeliveryDetail.querySMNo = smNoStr;
                FrmDeliveryDetail.queryAutoIdInt = -1;
                ddForm.ShowDialog();
                QueryDeliveryDetail(smNoStr);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--新增供货明细事件错误。", ex);
            }
        }

        /// <summary>
        /// 修改供货明细事件
        /// </summary>
        private void btnDDSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataSet_StnModule.Tables[0].Rows.Count == 0 || bindingSource_StnModule.Current == null)
                    return;
                DataRow focusedRow = gridViewDeliveryDetail.GetFocusedDataRow();
                if (focusedRow == null)
                    return;
                string smNoStr = DataTypeConvert.GetString(gridViewStnModule.GetFocusedDataRow()["SMNo"]);
                int autoIdInt = DataTypeConvert.GetInt(focusedRow["AutoId"]);
                FrmDeliveryDetail ddForm = new FrmDeliveryDetail();
                FrmDeliveryDetail.querySMNo = smNoStr;
                FrmDeliveryDetail.queryAutoIdInt = autoIdInt;
                ddForm.ShowDialog();
                QueryDeliveryDetail(smNoStr);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--修改供货明细事件错误。", ex);
            }
        }

        /// <summary>
        /// 删除供货明细事件
        /// </summary>
        private void btnDDDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataSet_StnModule.Tables[0].Rows.Count == 0 || bindingSource_StnModule.Current == null)
                    return;
                DataRow focusedRow = gridViewDeliveryDetail.GetFocusedDataRow();
                if (focusedRow == null)
                    return;
                string smNoStr = DataTypeConvert.GetString(gridViewStnModule.GetFocusedDataRow()["SMNo"]);
                int autoIdInt = DataTypeConvert.GetInt(focusedRow["AutoId"]);
                if (MessageHandler.ShowMessageBox_YesNo("确定要删除当前选中的记录吗？") != DialogResult.Yes)
                {
                    return;
                }
                if (new FrmDeliveryDetailDAO().DeleteDeliveryDetail(autoIdInt))
                {
                    MessageHandler.ShowMessageBox("删除成功。");
                    QueryDeliveryDetail(smNoStr);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--删除供货明细事件错误。", ex);
            }
        }

        /// <summary>
        /// 扩展所有供货明细的详细信息
        /// </summary>
        private void btnExpand_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridViewDeliveryDetail.DataRowCount > 0)
                {
                    for (int i = 0; i < gridViewDeliveryDetail.DataRowCount; i++)
                    {
                        gridViewDeliveryDetail.ExpandMasterRow(i, 0);
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--扩展所有供货明细的详细信息错误。", ex);
            }
        }

        /// <summary>
        /// 收缩所有供货明细的详细信息
        /// </summary>
        private void btnCollapse_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridViewDeliveryDetail.DataRowCount > 0)
                {
                    for (int i = 0; i < gridViewDeliveryDetail.DataRowCount; i++)
                    {
                        gridViewDeliveryDetail.CollapseMasterRow(i);
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--收缩所有供货明细的详细信息错误。", ex);
            }
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewDeliveryDetail_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            ControlHandler.GridView_CustomDrawRowIndicator(e);
        }

        /// <summary>
        /// 获取单元格显示的信息
        /// </summary>
        private void gridViewDeliveryDetail_KeyDown(object sender, KeyEventArgs e)
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
        /// 双击查看明细信息
        /// </summary>
        private void gridViewDeliveryDetail_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (e.Clicks == 2 && e.Button == MouseButtons.Left)
                {
                    int focusedRowIndex = gridViewDeliveryDetail.GetFocusedDataSourceRowIndex();
                    if (gridViewDeliveryDetail.GetMasterRowExpanded(focusedRowIndex))
                        gridViewDeliveryDetail.CollapseMasterRow(focusedRowIndex);
                    else
                        gridViewDeliveryDetail.ExpandMasterRow(focusedRowIndex, 0);
                }
                else if (e.Button == MouseButtons.Right)
                {
                    int autoIdInt = DataTypeConvert.GetInt(gridViewDeliveryDetail.GetFocusedDataRow()["AutoId"]);
                    DataRow[] mdRows = dataSet_DeliveryDetail.Tables[1].Select(string.Format("DeliveryDetailNO = {0}", autoIdInt));
                    string contentStr = "";
                    for (int i = 0; i < (mdRows.Length <= SystemInfo.ToolTipDisplayMaxRowCount ? mdRows.Length : SystemInfo.ToolTipDisplayMaxRowCount); i++)
                    {
                        contentStr += string.Format("名称：{0}  数量：{1}  品牌：{2}\n", DataTypeConvert.GetString(mdRows[i]["MaterialName"]), DataTypeConvert.GetString(mdRows[i]["MaterialQty"]), DataTypeConvert.GetString(mdRows[i]["MaterialBrand"]));
                    }

                    ControlHandler.NewToolTip("", contentStr, 3000, false);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--双击查看明细信息错误。", ex);
            }
        }

        /// <summary>
        /// 根据功能模块号查询相关的供货明细信息
        /// </summary>
        private void QueryDeliveryDetail(string smNoStr)
        {
            dataSet_DeliveryDetail.Tables[1].Rows.Clear();
            dataSet_DeliveryDetail.Tables[0].Rows.Clear();
            if (smNoStr != "")
            {
                smDAO.QueryDeliveryDetail(dataSet_DeliveryDetail.Tables[0], smNoStr);
                smDAO.QueryMaterialDetail(dataSet_DeliveryDetail.Tables[1], smNoStr);
            }
        }

        #endregion

        #region 功能模块登记区域事件和方法

        /// <summary>
        /// 新增按钮事件
        /// </summary>
        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow baseRow = TableStnModule.NewRow();
                TableStnModule.Rows.Add(baseRow);
                bindingSource_StnModule.MoveLast();

                ColumnView headView = (ColumnView)gridControlStnModule.FocusedView;
                gridViewStnModule.FocusedRowHandle = headView.FocusedRowHandle;

                Set_ButtonEditGrid_State(false);
                textFunctionDesc.Focus();
                QueryDeliveryDetail("");
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
                if (TableStnModule.Rows.Count == 0 || bindingSource_StnModule.Current == null)
                    return;

                if (btnSave.Text != "保存")
                {
                    //DataRow headRow = ((DataRowView)bindingSource_StnModule.Current).Row;
                    //string autoQuotationNoStr = DataTypeConvert.GetString(headRow["AutoQuotationNo"]);
                    //if (quoDAO.CheckQuotationInfo_IsSalesOrder(null, autoQuotationNoStr))
                    //    return;

                    Set_ButtonEditGrid_State(false);
                    textFunctionDesc.Focus();
                }
                else
                {
                    bindingSource_StnModule.EndEdit();
                    DataRow headRow = ((DataRowView)bindingSource_StnModule.Current).Row;

                    if (textFunctionDesc.Text.Trim() == "")
                    {
                        MessageHandler.ShowMessageBox("功能简述不能为空，请重新操作。");
                        textFunctionDesc.Focus();
                        return;
                    }

                    string copySMNoStr = "";
                    if (copyRow != null)
                    {
                        if (MessageHandler.ShowMessageBox_YesNo("确认是否复制供货明细信息？") == DialogResult.Yes)
                            copySMNoStr = DataTypeConvert.GetString(copyRow["SMNo"]);
                    }
                    int ret = smDAO.SaveStnModule(headRow, copySMNoStr);
                    switch (ret)
                    {
                        case -1:

                            break;
                        case 1:
                            copyRow = null;
                            break;
                        case 0:
                            return;
                    }

                    //currentAutoQuotationNoStr = DataTypeConvert.GetString(headRow["AutoQuotationNo"]);
                    Set_ButtonEditGrid_State(true);

                    gridViewStnModule_FocusedRowChanged(null, null);
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
                if (bindingSource_StnModule.Current != null)
                {
                    bindingSource_StnModule.CancelEdit();
                    ((DataRowView)bindingSource_StnModule.Current).Row.RejectChanges();
                    if (gridViewStnModule.GetFocusedDataRow() != null)
                        gridViewStnModule.GetFocusedDataRow().RejectChanges();

                    if (copyRow != null)
                        copyRow = null;

                    Set_ButtonEditGrid_State(true);

                    gridViewStnModule_FocusedRowChanged(null, null);
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
                if (TableStnModule.Rows.Count == 0 || bindingSource_StnModule.Current == null)
                {
                    MessageHandler.ShowMessageBox("当前没有功能模块信息记录，不能进行删除。");
                    return;
                }

                DataRow headRow = ((DataRowView)bindingSource_StnModule.Current).Row;
                string smNoStr = DataTypeConvert.GetString(headRow["SMNo"]);
                if (smDAO.CheckStnModule_IsStnSummary(null, smNoStr))
                {
                    MessageHandler.ShowMessageBox("当前的功能模块已经在工位信息中登记，不可以删除。");
                    return;
                }

                if (MessageHandler.ShowMessageBox_YesNo("确定要删除当前选中的记录吗？") != DialogResult.Yes)
                {
                    return;
                }
                if (smDAO.DeleteStnModule(smNoStr))
                {
                    btnQuery_Click(null, null);
                    return;
                }

                btnQuery_Click(null, null);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--删除按钮事件错误。", ex);
            }
        }

        /// <summary>
        /// 复制按钮事件
        /// </summary>
        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                if (TableStnModule.Rows.Count == 0 || bindingSource_StnModule.Current == null)
                {
                    MessageHandler.ShowMessageBox("当前没有功能模块信息记录，不能进行复制。");
                    return;
                }

                DataRow headRow = ((DataRowView)bindingSource_StnModule.Current).Row;
                DataTable tmpTable = TableStnModule.Clone();
                tmpTable.ImportRow(headRow);
                copyRow = tmpTable.Rows[0];

                btnNew_Click(null, null);
                headRow = ((DataRowView)bindingSource_StnModule.Current).Row;
                headRow["FunctionDesc"] = copyRow["FunctionDesc"];
                headRow["FunctionDetail"] = copyRow["FunctionDetail"];
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--复制按钮事件错误。", ex);
            }
        }

        /// <summary>
        /// 设定主表的默认值
        /// </summary>
        private void TableStnModule_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            try
            {
                e.Row["Prepared"] = SystemInfo.user.EmpName;
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--设定主表的默认值错误。", ex);
            }
        }

        /// <summary>
        /// 设定按钮编辑区列表区的状态
        /// </summary>
        private void Set_ButtonEditGrid_State(bool state)
        {
            btnNew.Enabled = state;
            if (state)
            {
                btnSave.Text = "修改";
            }
            else
            {
                btnSave.Text = "保存";
            }
            btnCancel.Enabled = !state;
            btnDelete.Enabled = state;
            btnCopy.Enabled = state;

            textFunctionDesc.ReadOnly = state;
            memoFunctionDetail.ReadOnly = state;

            if (bindingSource_StnModule.Current != null)
            {
                DataRow headRow = ((DataRowView)bindingSource_StnModule.Current).Row;

                btnDDNew.Enabled = btnDelete.Enabled;
                btnDDSave.Enabled = btnDelete.Enabled;
                btnDDDelete.Enabled = btnDelete.Enabled;
            }
            else
            {
                btnDDNew.Enabled = false;
                btnDDSave.Enabled = false;
                btnDDDelete.Enabled = false;
            }

            if (this.Controls.ContainsKey("lblEditFlag"))
            {
                //检测窗口状态：新增、编辑="EDIT"，保存、取消=""
                if (state)
                {
                    ((Label)this.Controls["lblEditFlag"]).Text = "";
                }
                else
                {
                    ((Label)this.Controls["lblEditFlag"]).Text = "EDIT";
                }
            }
        }

        /// <summary>
        /// 查询按钮事件
        /// </summary>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                if (dateGetTimeBegin.EditValue == null || dateGetTimeEnd.EditValue == null)
                {
                    MessageHandler.ShowMessageBox("登记日期不能为空，请设置后重新进行查询。");
                    if (dateGetTimeBegin.EditValue == null)
                        dateGetTimeBegin.Focus();
                    else
                        dateGetTimeEnd.Focus();
                    return;
                }

                string getTimeBeginStr = dateGetTimeBegin.DateTime.ToString("yyyy-MM-dd");
                string getTimeEndStr = dateGetTimeEnd.DateTime.AddDays(1).ToString("yyyy-MM-dd");

                string commonStr = textCommon.Text.Trim();

                dataSet_StnModule.Tables[0].Rows.Clear();

                smDAO.QueryStnModule(dataSet_StnModule.Tables[0], getTimeBeginStr, getTimeEndStr, "", commonStr);

                Set_ButtonEditGrid_State(true);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--查询按钮事件错误。", ex);
            }
        }

        /// <summary>
        /// 换行触发事件
        /// </summary>
        private void gridViewStnModule_BeforeLeaveRow(object sender, RowAllowEventArgs e)
        {
            try
            {
                if (gridViewStnModule.GetFocusedDataRow() != null)
                {
                    DataRow dr = gridViewStnModule.GetFocusedDataRow();
                    if (dr.RowState != DataRowState.Unchanged)
                    {
                        MessageHandler.ShowMessageBox("当前功能模块正在编辑，请保存后再进行换行。");
                        e.Allow = false;
                    }
                    else
                    {
                        Set_ButtonEditGrid_State(true);
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--换行触发事件错误。", ex);
            }
        }

        /// <summary>
        /// 刷新功能模块的供货明细信息
        /// </summary>
        private void gridViewStnModule_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            try
            {
                if (gridViewStnModule.GetFocusedDataRow() != null)
                {
                    DataRow smRow = gridViewStnModule.GetFocusedDataRow();
                    string smNoStr = DataTypeConvert.GetString(smRow["SMNo"]);
                    if (smNoStr != "")
                        QueryDeliveryDetail(smNoStr);
                    if (smRow.RowState == DataRowState.Added || smRow.RowState == DataRowState.Modified)
                    { }
                    else
                        Set_ButtonEditGrid_State(true);
                }
                else
                {
                    QueryDeliveryDetail("");
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--刷新报价单的价格信息错误。", ex);
            }
        }

        #endregion
    }
}
