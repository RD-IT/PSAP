using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
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
    public partial class FrmStnSummary : DockContent
    {
        #region 私有变量

        FrmStnSummaryDAO ssDAO = new FrmStnSummaryDAO();
        FrmCommonDAO commonDAO = new FrmCommonDAO();

        /// <summary>
        /// 拖动Tree区域的信息
        /// </summary>
        TreeListHitInfo downHitInfo = null;

        /// <summary>
        /// 要查询的报价单号
        /// </summary>
        public static string queryAutoQuotationNoStr = "";

        /// <summary>
        /// 要查询的工位序号
        /// </summary>
        public static string querySSNoStr = "";

        /// <summary>
        /// 最后新增的ID
        /// </summary>
        private int lastNewStnListAutoId = 0;

        #endregion

        #region 构造方法

        public FrmStnSummary()
        {
            InitializeComponent();
        }

        #endregion

        #region 窗体事件

        /// <summary>
        /// 窗体加载事件 
        /// </summary>
        private void FrmStnSummary_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime nowDate = BaseSQL.GetServerDateTime();
                dateGetTimeBegin.DateTime = nowDate.Date.AddDays(-SystemInfo.OrderQueryDate_DefaultDays);
                dateGetTimeEnd.DateTime = nowDate.Date;

                btnRefresh_Click(null, null);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
            }
        }

        /// <summary>
        /// 窗体激活事件
        /// </summary>
        private void FrmStnSummary_Activated(object sender, EventArgs e)
        {
            try
            {
                if (queryAutoQuotationNoStr != "")
                {
                    btnEditAutoQuotationNo.Text = queryAutoQuotationNoStr;
                    queryAutoQuotationNoStr = "";
                    querySSNoStr = "";
                    btnRefresh_Click(null, null);
                }
                else if (querySSNoStr != "")
                {
                    btnEditSSNo.Text = querySSNoStr;
                    querySSNoStr = "";
                    btnRefresh_Click(null, null);
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
        private void FrmStnSummary_Shown(object sender, EventArgs e)
        {
            dockPnlRight.Width = SystemInfo.DragForm_LeftDock_Width;
        }

        #endregion

        #region 右侧基础功能模块列表区域的事件和方法

        /// <summary>
        /// 查询按钮事件
        /// </summary>
        private void btnModuleQuery_Click(object sender, EventArgs e)
        {
            try
            {
                string getTimeBeginStr = "";
                string getTimeEndStr = "";
                if (dateGetTimeBegin.EditValue != null && dateGetTimeEnd.EditValue != null)
                {
                    getTimeBeginStr = dateGetTimeBegin.DateTime.ToString("yyyy-MM-dd");
                    getTimeEndStr = dateGetTimeEnd.DateTime.AddDays(1).ToString("yyyy-MM-dd");
                }

                string commonStr = textCommon.Text.Trim();

                treeListStnModule.DataSource = ssDAO.QueryBaseStnModule_OnlyRoot(getTimeBeginStr, getTimeEndStr, commonStr);

                //Set_ButtonEditGrid_State(true);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--查询按钮事件错误。", ex);
            }
        }

        /// <summary>
        /// 新增基础功能模块
        /// </summary>
        private void btnModuleNew_Click(object sender, EventArgs e)
        {
            try
            {
                FrmStnModule.defaultNewState = true;
                ViewHandler.ShowRightWindow("FrmStnModule");
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--新增基础功能模块错误。", ex);
            }
        }

        /// <summary>
        /// 复制新增基础功能模块
        /// </summary>
        private void btnModuleCopy_Click(object sender, EventArgs e)
        {
            try
            {
                TreeListNode focusedNode = treeListStnModule.FocusedNode;
                if (focusedNode == null)
                {
                    MessageHandler.ShowMessageBox("请选择要进行复制的基础功能模块。");
                    return;
                }

                string smNoStr = DataTypeConvert.GetString(focusedNode["ReParent"]);
                if (smNoStr == "")
                    smNoStr = DataTypeConvert.GetString(focusedNode["ReID"]);

                FrmStnModule.copySMNoStr = smNoStr;
                ViewHandler.ShowRightWindow("FrmStnModule");
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--复制新增基础功能模块错误。", ex);
            }
        }

        /// <summary>
        /// 双击查看功能模块信息
        /// </summary>
        private void treeListStnModule_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                TreeListNode node = treeListStnModule.FocusedNode;
                if (node.Nodes.Count == 0 && DataTypeConvert.GetString(node["ReParent"]) == "")
                {
                    ssDAO.QueryBaseStnModule_OnlyLeaf((DataTable)treeListStnModule.DataSource, DataTypeConvert.GetString(node["ReID"]));

                    treeListStnModule.RefreshDataSource();

                    treeListStnModule.FocusedNode.ExpandAll();
                    treeListStnModule.FocusedNode.Expanded = false;
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--双击查看功能模块信息错误。", ex);
            }
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void treeListStnModule_CustomDrawNodeIndicator(object sender, DevExpress.XtraTreeList.CustomDrawNodeIndicatorEventArgs e)
        {
            ControlHandler.TreeList_CustomDrawNodeIndicator_RootNode(sender, e);
        }

        /// <summary>
        /// 获取单元格显示的信息
        /// </summary>
        private void treeListStnModule_KeyDown(object sender, KeyEventArgs e)
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

        #region 拖出基础功能模块列表TreeList

        /// <summary>
        /// 在TreeList中按下鼠标事件
        /// </summary>
        private void treeListStnModule_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                TreeList treelist = sender as TreeList;
                downHitInfo = null;
                TreeListHitInfo hitInfo = treelist.CalcHitInfo(new Point(e.X, e.Y));

                if (Control.ModifierKeys != Keys.None)
                    return;
                if (e.Button == MouseButtons.Left)
                {
                    downHitInfo = hitInfo;
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--在TreeList中按下鼠标事件错误。", ex);
            }
        }

        /// <summary>
        /// 在TreeList中移动鼠标事件
        /// </summary>
        private void treeListStnModule_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                TreeList treelist = sender as TreeList;
                if (e.Button == MouseButtons.Left && downHitInfo != null)
                {
                    if (treelist.Selection.Count == 0)
                        return;
                    else if (treelist.Selection.Count == 1)
                    {
                        string parentStr = DataTypeConvert.GetString(treelist.Selection[0]["ReParent"]);
                        if (parentStr != "")
                        {
                            MessageHandler.ShowMessageBox("拖拽选项只能选择主功能模块信息，不可以拖拽功能模块的明细信息。");
                            return;
                        }
                    }
                    Size dragSize = SystemInformation.DragSize;
                    Rectangle dragRect = new Rectangle(new Point(downHitInfo.MousePoint.X - dragSize.Width / 2,
                        downHitInfo.MousePoint.Y - dragSize.Height / 2), dragSize);

                    if (!dragRect.Contains(new Point(e.X, e.Y)))
                    {
                        List<TreeListNode> nodes = new List<TreeListNode>();
                        foreach (TreeListNode n in treelist.Selection)
                        {
                            if (DataTypeConvert.GetString(n["ReParent"]) == "")
                                nodes.Add(n);
                        }
                        if (nodes.Count == 0)
                        {
                            MessageHandler.ShowMessageBox("请选择要拖拽的主功能模块信息。");
                            return;
                        }
                        else
                        {
                            treelist.DoDragDrop(nodes, DragDropEffects.Move);
                            downHitInfo = null;
                            DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--在TreeList中移动鼠标事件错误。", ex);
            }
        }

        #endregion

        #endregion

        #region 左侧工位信息登记区域的事件和方法

        /// <summary>
        /// 刷新工位主表信息
        /// </summary>
        private void RefreshStnSummary(string autoQuotationNoStr, string ssNoStr)
        {
            TableStnSummary.Rows.Clear();
            ssDAO.QueryStnSummary(TableStnSummary, autoQuotationNoStr, ssNoStr);
            if (TableStnSummary.Rows.Count > 0)
            {
                btnEditAutoQuotationNo.Text = DataTypeConvert.GetString(TableStnSummary.Rows[0]["AutoQuotationNo"]);
                ssNoStr = DataTypeConvert.GetString(TableStnSummary.Rows[0]["SSNo"]);
                btnEditSSNo.Text = ssNoStr;
                textPrepared.Text = DataTypeConvert.GetString(TableStnSummary.Rows[0]["Prepared"]);
                textGetTime.Text = DataTypeConvert.GetDateTime(TableStnSummary.Rows[0]["GetTime"]).ToString("yyyy-MM-dd HH:mm:ss");

                RefreshStnSummaryList(ssNoStr);
            }
            else
            {
                btnEditAutoQuotationNo.Text = autoQuotationNoStr;
                btnEditSSNo.Text = "";
                textPrepared.Text = "";
                textGetTime.Text = "";

                TableStnList.Rows.Clear();
                TableStnListModule.Rows.Clear();
            }
        }

        /// <summary>
        /// 刷新工位的明细信息
        /// </summary>
        private void RefreshStnSummaryList(string ssNoStr)
        {
            int lastAutoIdInt = 0;
            string lastSSNoStr = "";
            if (bindingSource_StnList.Current != null)
            {
                DataRow headRow = ((DataRowView)bindingSource_StnList.Current).Row;
                lastAutoIdInt = DataTypeConvert.GetInt(headRow["AutoId"]);
                lastSSNoStr = DataTypeConvert.GetString(headRow["SSNo"]);

                if (lastNewStnListAutoId != 0)
                {
                    lastAutoIdInt = lastNewStnListAutoId;
                    lastNewStnListAutoId = 0;
                }
            }

            TableStnList.Rows.Clear();
            ssDAO.QueryStnSummaryList(TableStnList, ssNoStr);

            if (lastSSNoStr == ssNoStr && lastAutoIdInt > 0)
            {
                for (int i = 0; i < gridViewStnList.DataRowCount; i++)
                {
                    if (DataTypeConvert.GetInt(gridViewStnList.GetDataRow(i)["AutoId"]) == lastAutoIdInt)
                    {
                        gridViewStnList.FocusedRowHandle = i;
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// 刷新工位和模块关系信息
        /// </summary>
        private void RefreshStnListModule(int stnListIdInt)
        {
            TableStnListModule.Rows.Clear();
            ssDAO.QueryStnListModule(TableStnListModule, stnListIdInt);
        }

        /// <summary>
        /// 显示选择报价单号和工位序号的窗体
        /// </summary>
        private void ShowSelectQuotationInfo()
        {
            FrmSelectQuotationInfo quoForm = new FrmSelectQuotationInfo();
            if (quoForm.ShowDialog() == DialogResult.OK)
            {
                DataRow dr = quoForm.gridViewQuotation.GetFocusedDataRow();
                if (dr != null)
                {
                    string autoQuotationNoStr = DataTypeConvert.GetString(dr["AutoQuotationNo"]);
                    RefreshStnSummary(autoQuotationNoStr, "");
                }
            }
        }

        /// <summary>
        /// 选择报价单号
        /// </summary>
        private void btnEditAutoQuotationNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                ShowSelectQuotationInfo();
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--选择报价单号错误。", ex);
            }
        }

        /// <summary>
        /// 选择工位序号
        /// </summary>
        private void btnEditSSNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                ShowSelectQuotationInfo();
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--选择工位序号错误。", ex);
            }
        }

        /// <summary>
        /// 刷新当前工位的所有信息
        /// </summary>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnEditAutoQuotationNo.Text != "")
                {
                    string autoQuotationNoStr = btnEditAutoQuotationNo.Text;
                    RefreshStnSummary(autoQuotationNoStr, "");
                }
                else if (btnEditSSNo.Text != "")
                {
                    string ssNoStr = btnEditSSNo.Text;
                    RefreshStnSummary("", ssNoStr);
                }

                Set_ButtonEditGrid_State(true);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--刷新当前工位的所有信息错误。", ex);
            }
        }

        /// <summary>
        /// 刷新工位功能模块信息
        /// </summary>
        private void gridViewStnList_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (gridViewStnList.GetFocusedDataRow() != null)
                {
                    int autoIdInt = DataTypeConvert.GetInt(gridViewStnList.GetFocusedDataRow()["AutoId"]);
                    if (autoIdInt != 0)
                        RefreshStnListModule(autoIdInt);

                    //Set_ButtonEditGrid_State(true);
                }
                else
                {
                    TableStnListModule.Rows.Clear();
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--刷新工位功能模块信息错误。", ex);
            }
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewStnList_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            ControlHandler.GridView_CustomDrawRowIndicator(e);
        }

        /// <summary>
        /// 获取单元格显示的信息
        /// </summary>
        private void gridViewStnList_KeyDown(object sender, KeyEventArgs e)
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
        private void btnStnListNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnEditAutoQuotationNo.Text.Trim() == "")
                {
                    MessageHandler.ShowMessageBox("请先查询报价单号，确定要操作的报价单，再进行工位信息登记。");
                    return;
                }

                //TableStnList.Rows.Clear();
                DataRow baseRow = TableStnList.NewRow();
                TableStnList.Rows.Add(baseRow);
                bindingSource_StnList.MoveLast();

                Set_ButtonEditGrid_State(false);
                textEditStnNo.Focus();
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--新增按钮事件错误。", ex);
            }
        }

        /// <summary>
        /// 保存按钮事件
        /// </summary>
        private void btnStnListSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (TableStnList.Rows.Count == 0 || bindingSource_StnList.Current == null)
                    return;

                if (btnStnListSave.Text != "保存")
                {
                    //DataRow headRow = ((DataRowView)bindingSource_StnList.Current).Row;
                    //int autoIdInt = DataTypeConvert.GetInt(headRow["AutoId"]);
                    //if (ssDAO.CheckStnList_IsModule(null, autoIdInt))
                    //    return;

                    Set_ButtonEditGrid_State(false);
                    textEditStnNo.Focus();
                }
                else
                {
                    bindingSource_StnList.EndEdit();
                    DataRow headRow = ((DataRowView)bindingSource_StnList.Current).Row;

                    if (textEditStnNo.Text.Trim() == "")
                    {
                        MessageHandler.ShowMessageBox("站号不能为空，请重新操作。");
                        textEditStnNo.Focus();
                        return;
                    }

                    string autoQuotationNoStr = btnEditAutoQuotationNo.Text;
                    int ret = ssDAO.SaveStnSummaryList(autoQuotationNoStr, headRow, ref lastNewStnListAutoId);
                    switch (ret)
                    {
                        case -1:

                            break;
                        case 1:

                            break;
                        case 0:
                            return;
                    }

                    //currentAutoQuotationNoStr = DataTypeConvert.GetString(headRow["AutoQuotationNo"]);
                    btnRefresh_Click(null, null);
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
        private void btnStnListCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (bindingSource_StnList.Current != null)
                {
                    bindingSource_StnList.CancelEdit();
                    ((DataRowView)bindingSource_StnList.Current).Row.RejectChanges();

                    btnRefresh_Click(null, null);
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
        private void btnStnListDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (TableStnList.Rows.Count == 0 || bindingSource_StnList.Current == null)
                {
                    MessageHandler.ShowMessageBox("当前没有工位信息记录，不能进行删除。");
                    return;
                }
                DataRow headRow = ((DataRowView)bindingSource_StnList.Current).Row;
                int autoIdInt = DataTypeConvert.GetInt(headRow["AutoId"]);
                if (ssDAO.CheckStnList_IsModule(null, autoIdInt))
                    return;

                if (MessageHandler.ShowMessageBox_YesNo("确定要删除当前选中的记录吗？") != DialogResult.Yes)
                {
                    return;
                }
                if (ssDAO.DeleteStnSummaryList(autoIdInt))
                {
                    MessageHandler.ShowMessageBox("删除成功。");
                    btnRefresh_Click(null, null);
                }
                else
                {
                    btnRefresh_Click(null, null);
                }

                Set_ButtonEditGrid_State(true);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--删除按钮事件错误。", ex);
            }
        }

        /// <summary>
        /// 设定主表的默认值
        /// </summary>
        private void TableStnList_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            try
            {
                if (TableStnSummary.Rows.Count > 0)
                {
                    e.Row["SSNo"] = TableStnSummary.Rows[0]["SSNo"];
                }
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
            btnEditAutoQuotationNo.Properties.Buttons[0].Enabled = state;
            btnEditSSNo.Properties.Buttons[0].Enabled = state;

            btnStnListNew.Enabled = state;
            if (state)
            {
                btnStnListSave.Text = "修改";
            }
            else
            {
                btnStnListSave.Text = "保存";
            }
            btnStnListCancel.Enabled = !state;
            btnStnListDelete.Enabled = state;
            btnRefresh.Enabled = state;

            btnModuleDelete.Enabled = state;

            textEditStnNo.ReadOnly = state;
            textEditStnDesc.ReadOnly = state;

            repbtnDelete.Buttons[0].Enabled = !state;

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

        #endregion

        #region 左侧工位功能模块列表区域的事件和方法

        /// <summary>
        /// 删除工位功能模块
        /// </summary>
        private void btnModuleDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (TableStnListModule.Rows.Count == 0 || bindingSource_StnListModule.Current == null)
                {
                    MessageHandler.ShowMessageBox("当前没有工位功能模块记录，不能进行删除。");
                    return;
                }

                if (MessageHandler.ShowMessageBox_YesNo("确定要删除当前选中的记录吗？") != DialogResult.Yes)
                {
                    return;
                }
                DataRow headRow = ((DataRowView)bindingSource_StnListModule.Current).Row;
                int autoIdInt = DataTypeConvert.GetInt(headRow["AutoId"]);
                if (ssDAO.DeleteStnListModule(autoIdInt))
                {
                    MessageHandler.ShowMessageBox("删除成功。");
                    gridViewStnList_FocusedRowChanged(null, null);
                }
                else
                {
                    gridViewStnList_FocusedRowChanged(null, null);
                }
                //Set_ButtonEditGrid_State(true);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--删除工位功能模块错误。", ex);
            }
        }

        #region 拖入

        /// <summary>
        /// 拖拽在GridControl上面
        /// </summary>
        private void gridControlModuleList_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<TreeListNode>)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        /// <summary>
        /// 拖拽进入到GridControl控件
        /// </summary>
        private void gridControlModuleList_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        /// <summary>
        /// 实现拖拽功能模块事件
        /// </summary>
        private void gridControlModuleList_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                if (btnEditAutoQuotationNo.Text.Trim() == "")
                {
                    MessageHandler.ShowMessageBox("请先选择要操作的报价单。");
                    return;
                }

                if (TableStnList.Rows.Count == 0 || bindingSource_StnList.Current == null)
                {
                    MessageHandler.ShowMessageBox("请先选择要操作的工位信息。");
                    return;
                }
                if (!btnStnListNew.Enabled)
                {
                    MessageHandler.ShowMessageBox("工位信息正在编辑状态，请保存后再进行拖拽功能模块操作。");
                    return;
                }

                List<string> smNoStrList = new List<string>();
                List<TreeListNode> nodes = e.Data.GetData(typeof(List<TreeListNode>)) as List<TreeListNode>;
                foreach (TreeListNode node in nodes)
                {
                    smNoStrList.Add(DataTypeConvert.GetString(node["ReID"]));
                }
                DataRow headRow = ((DataRowView)bindingSource_StnList.Current).Row;
                int autoIdInt = DataTypeConvert.GetInt(headRow["AutoId"]);
                string stnNoStr = DataTypeConvert.GetString(headRow["StnNo"]);
                if (ssDAO.SaveStnListModule(autoIdInt, stnNoStr, smNoStrList))
                {
                    gridViewStnList_FocusedRowChanged(null, null);
                }

            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--实现拖拽功能模块事件错误。", ex);
            }
        }

        #endregion

        /// <summary>
        /// 双击查询明细
        /// </summary>
        private void gridViewModuleList_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (e.Clicks == 2 && e.Button == MouseButtons.Left)
                {
                    string smNoStr = DataTypeConvert.GetString(gridViewModuleList.GetFocusedDataRow()["SMNo"]);
                    FrmStnModule.querySMNoStr = smNoStr;
                    ViewHandler.ShowRightWindow("FrmStnModule");
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--双击查询明细错误。", ex);
            }
        }

        #endregion

    }
}
