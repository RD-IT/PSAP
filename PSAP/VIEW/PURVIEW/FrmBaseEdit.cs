using DevExpress.XtraBars.Docking;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using PSAP.DAO.BSDAO;
using PSAP.DAO.PURDAO;
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
    public partial class FrmBaseEdit : DockContent
    {
        /// <summary>
        /// form的主数据表名
        /// </summary>
        public string TableName
        {
            get;
            set;
        }

        /// <summary>
        /// 数据表中文名
        /// </summary>
        public string TableCaption
        {
            get;
            set;
        }

        /// <summary>
        /// 查询数据的sql
        /// </summary>
        public string Sql
        {
            get;
            set;
        }

        /// <summary>
        /// 主键列名 只能设定一个主键
        /// </summary>
        public string PrimaryKeyColumn
        {
            get;
            set;
        }

        /// <summary>
        /// 编辑状态
        /// </summary>
        public bool EditState
        {
            get;
            set;
        }

        /// <summary>
        /// 显示查询定位控件
        /// </summary>
        private bool visibleSearchControl = true;
        public bool VisibleSearchContrl
        {
            get { return visibleSearchControl; }
            set { visibleSearchControl = value; }
        }

        /// <summary>
        /// 删除后是否刷新
        /// </summary>
        public bool DeleteAfterRefresh = false;

        /// <summary>
        /// DataSet是主数据集
        /// </summary>
        private DataSet masterDataSet;
        public DataSet MasterDataSet
        {
            get
            {
                return masterDataSet;
            }
            set
            {
                masterDataSet = value;
                masterDataSet.EnforceConstraints = false;
            }
        }

        /// <summary>
        /// BindingSource是主绑定源
        /// </summary>
        private BindingSource masterBindingSource;
        public BindingSource MasterBindingSource
        {
            get
            {
                return masterBindingSource;
            }
            set
            {
                masterBindingSource = value;
            }
        }

        /// <summary>
        /// 主键绑定的控件
        /// </summary>
        private Control primaryKeyControl=null;
        public Control PrimaryKeyControl
        {
            get
            {
                return primaryKeyControl;
            }
            set
            {
                primaryKeyControl = value;
            }
        }

        /// <summary>
        /// 除了主键控件外其他不允许修改的控件列表
        /// </summary>
        private List<Control> otherNoChangeControl = null;
        public List<Control> OtherNoChangeControl
        {
            get
            {
                return otherNoChangeControl;
            }
            set
            {
                otherNoChangeControl = value;
            }
        }

        /// <summary>
        /// 编辑区Panel
        /// </summary>
        private PanelControl masterEditPanel;
        public PanelControl MasterEditPanel
        {
            get
            {
                return masterEditPanel;
            }
            set
            {
                masterEditPanel = value;
            }
        }

        /// <summary>
        /// DataGridView是浏览数据用的GridView
        /// </summary>
        private DevExpress.XtraGrid.Views.Grid.GridView browseXtraGridView;
        public DevExpress.XtraGrid.Views.Grid.GridView BrowseXtraGridView
        {
            get
            {
                return browseXtraGridView;
            }
            set
            {
                this.browseXtraGridView = value;
                if (this.browseXtraGridView == null)
                {
                    return;
                }
                if (this.DesignMode)
                {
                    return;
                }
                this.browseXtraGridView.BeforeLeaveRow += this.XtraGridView_BeforeLeaveRow;
                this.browseXtraGridView.ShownEditor += this.XtraGridView_ShownEditor;
            }
        }

        /// <summary>
        /// 添加的按钮列表，以便更新按钮的状态
        /// </summary>
        private List<SimpleButton> buttonList = new List<SimpleButton>();
        public List<SimpleButton> ButtonList
        {
            get
            {
                return buttonList;
            }
            set
            {
                buttonList = value;
            }
        }

        //定义委托和事件  保存之前检查编辑区控件填写问题
        public delegate bool Check_MasterEditPanel_Control();
        public event Check_MasterEditPanel_Control CheckControl;

        //定义委托和事件  保存之前执行的方法
        public delegate bool SaveRowBefore_Handle(DataRow dr, SqlCommand cmd);
        public event SaveRowBefore_Handle SaveRowBefore;

        //定义委托和事件  保存之后执行的方法
        public delegate bool SaveRowAfter_Handle(DataRow dr, SqlCommand cmd);
        public event SaveRowAfter_Handle SaveRowAfter;

        //定义委托和事件  删除之前执行的方法
        public delegate bool DeleteRowBefore_Handle(DataRow dr, SqlCommand cmd);
        public event DeleteRowBefore_Handle DeleteRowBefore;

        //定义委托和事件  删除之后执行的方法
        public delegate bool DeleteRowAfter_Handle(DataRow dr, SqlCommand cmd);
        public event DeleteRowAfter_Handle DeleteRowAfter;

        //定义委托和事件  查询数据之后执行的方法
        public delegate void QueryDataAfter_Handle();
        public event QueryDataAfter_Handle QueryDataAfter;

        ControlHandler ctlHandler = new ControlHandler();

        /// <summary>
        /// 新增状态
        /// </summary>
        bool newState = false;

        public FrmBaseEdit()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 加载窗体
        /// </summary>
        private void FrmProjectList_Load(object sender, EventArgs e)
        {
            this.Text = TableCaption;
            btnRefresh_Click(null, null);
            if(!visibleSearchControl)
            {
                labContent.Visible = false;
                textContent.Visible = false;
                btnPrevious.Visible = false;
                btnNext.Visible = false;
            }
        }

        /// <summary>
        /// 新增按钮事件
        /// </summary>
        public void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = masterDataSet.Tables[0].NewRow();
                masterDataSet.Tables[0].Rows.Add(dr);
                masterBindingSource.MoveLast();

                newState = true;
                Set_Button_State(false);
                Set_EditZone_ControlReadOnly(false);
                pnlButton.Focus();
                if (masterEditPanel != null)
                    masterEditPanel.SelectNextControl(null, true, true, true, true);
                
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--新增按钮事件错误。", ex);
            }
        }

        /// <summary>
        /// 保存按钮事件
        /// </summary>
        public void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text != "保存")//修改
            {
                try
                {
                    if (masterBindingSource.Current != null)
                    {
                        newState = false;
                        Set_Button_State(false);
                        Set_EditZone_ControlReadOnly(false);
                        pnlButton.Focus();
                        if (masterEditPanel != null)
                        {
                            masterEditPanel.SelectNextControl(null, true, true, true, true);
                            if (primaryKeyControl != null)
                            {
                                if (primaryKeyControl.BindingContext == this.ParentForm.ActiveControl.BindingContext)
                                {
                                    masterEditPanel.SelectNextControl(primaryKeyControl, true, false, false, false);
                                }
                            }
                        }
                       
                    }
                }
                catch (Exception ex)
                {
                    ExceptionHandler.HandleException(this.Text + "--修改按钮事件错误。", ex);
                    if (masterEditPanel != null)
                        masterEditPanel.SelectNextControl(null, true, true, true, true);
                }
            }
            else//保存
            {
                btnSave_Click();
                pnlButton.Focus();
            }            
        }

        /// <summary>
        /// 单击保存按钮事件
        /// </summary>
        private bool btnSave_Click()
        {
            try
            {
                masterBindingSource.EndEdit();
                DataRow dr = ((DataRowView)masterBindingSource.Current).Row;

                if (dr.RowState == DataRowState.Added && dr[PrimaryKeyColumn].ToString() != "")
                {
                    string sqlStr = string.Format("select count(*) from {0} where {1}='{2}'", TableName, PrimaryKeyColumn, dr[PrimaryKeyColumn].ToString());
                    if (DataTypeConvert.GetInt(BaseSQL.GetSingle(sqlStr)) > 0)
                    {
                        MessageHandler.ShowMessageBox(string.Format("主键列[{0}]不可以输入重复的信息，请重新输入。", masterDataSet.Tables[0].Columns[PrimaryKeyColumn].Caption));
                        if (masterEditPanel != null)
                            masterEditPanel.SelectNextControl(null, true, true, true, true);
                        return false;
                    }
                }
                else if (dr.RowState == DataRowState.Modified && dr[PrimaryKeyColumn].ToString() != "")
                {
                    string sqlStr = string.Format("select count(*) from {0} where {1}='{2}' and {1}!='{3}'", TableName, PrimaryKeyColumn, dr[PrimaryKeyColumn, DataRowVersion.Current].ToString(), dr[PrimaryKeyColumn, DataRowVersion.Original].ToString());
                    if (DataTypeConvert.GetInt(BaseSQL.GetSingle(sqlStr)) > 0)
                    {
                        MessageHandler.ShowMessageBox(string.Format("主键列[{0}]不可以输入重复的信息，请重新输入。", masterDataSet.Tables[0].Columns[PrimaryKeyColumn].Caption));
                        if (masterEditPanel != null)
                            masterEditPanel.SelectNextControl(null, true, true, true, true);
                        return false;
                    }
                }

                if (dr.RowState != DataRowState.Unchanged)
                {
                    if (DoSave(dr))
                    {
                        newState = false;
                        Set_Button_State(true);
                        Set_EditZone_ControlReadOnly(true);

                        int posInt = masterBindingSource.Position;
                        btnRefresh_Click(null, null);
                        masterBindingSource.Position = posInt;
                        return true;
                    }
                    return false;
                }
                else
                {
                    newState = false;
                    Set_Button_State(true);
                    Set_EditZone_ControlReadOnly(true);

                    int posInt = masterBindingSource.Position;
                    btnRefresh_Click(null, null);
                    masterBindingSource.Position = posInt;
                    return true;
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--保存按钮事件错误。", ex);
                if(masterEditPanel!=null)
                    masterEditPanel.SelectNextControl(null, true, true, true, true);
                return false;
            }
        }

        /// <summary>
        /// 取消按钮事件
        /// </summary>
        public void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (masterBindingSource.Current != null)
                {
                    masterBindingSource.CancelEdit();
                    ((DataRowView)masterBindingSource.Current).Row.RejectChanges();
                    newState = false;
                    Set_Button_State(true);
                    Set_EditZone_ControlReadOnly(true);
                    pnlButton.Focus();
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
        public void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageHandler.ShowMessageBox_YesNo("确定要删除当前选中的记录吗？") != DialogResult.Yes)
                {
                    return;
                }

                DataRow dr = ((DataRowView)masterBindingSource.Current).Row;
                ((DataRowView)masterBindingSource.Current).Row.Delete();
                DoDelete(dr);

                if (DeleteAfterRefresh)
                    btnRefresh_Click(null, null);

                Set_Button_State(true);
                Set_EditZone_ControlReadOnly(true);
                pnlButton.Focus();
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--删除按钮事件错误。", ex);
            }
        }

        /// <summary>
        /// 刷新按钮事件
        /// </summary>
        public void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                masterDataSet.Tables[0].Clear();
                BaseSQL.Query(Sql, masterDataSet.Tables[0]);
                if (QueryDataAfter != null)
                    QueryDataAfter();
                Set_Button_State(true);
                Set_EditZone_ControlReadOnly(true);
                pnlButton.Focus();
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--刷新按钮事件错误。", ex);
            }
        }

        /// <summary>
        /// 查询结果存为Excel
        /// </summary>
        private void btnSaveExcel_Click(object sender, EventArgs e)
        {
            try
            {
                FileHandler.SaveDevGridControlExportToExcel(browseXtraGridView);
                pnlButton.Focus();
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--存为Excel错误。", ex);
            }
        }

        /// <summary>
        /// XtraGridView在行变化时，触发此事件，在事件中调用DoSave提交行数据的修改
        /// </summary>
        private void XtraGridView_BeforeLeaveRow(object sender, RowAllowEventArgs e)
        {
            try
            {
                if (masterBindingSource.Current != null)
                {
                    DataRow dr = ((DataRowView)masterBindingSource.Current).Row;
                    if (dr == browseXtraGridView.GetDataRow(e.RowHandle))
                    {
                        if (dr.RowState != DataRowState.Unchanged)
                        {
                            if (MessageHandler.ShowMessageBox_YesNo("确认是否保存当前行信息？") == DialogResult.Yes)
                            {
                                if (!btnSave_Click())
                                    e.Allow = false;
                            }
                            else
                            {
                                dr.RejectChanges();
                                Set_Button_State(true);
                                Set_EditZone_ControlReadOnly(true);
                            }
                        }
                        else
                        {
                            Set_Button_State(true);
                            Set_EditZone_ControlReadOnly(true);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--刷新按钮事件错误。", ex);
            }
        }

        private void XtraGridView_EditValueChanged(object sender, EventArgs e)
        {
            this.browseXtraGridView.PostEditor();
        }

        private void XtraGridView_ShownEditor(object sender, EventArgs e)
        {
            (sender as GridView).ActiveEditor.EditValueChanged += XtraGridView_EditValueChanged;
        }

        /// <summary>
        /// 执行保存
        /// </summary>
        private bool DoSave(DataRow updateRow)
        {
            if (CheckControl != null)
            {
                if (!CheckControl())
                    return false;
            }

            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);

                        if (SaveRowBefore != null)
                        {
                            if (!SaveRowBefore(updateRow, cmd))
                            {
                                trans.Rollback();
                                return false;
                            }
                        }

                        //保存日志到日志表中
                        string logStr = LogHandler.RecordLog_DataRow(cmd, TableCaption, updateRow, PrimaryKeyColumn);

                        cmd.CommandText = string.Format("select * from {0} where 1=2", TableName);
                        SqlDataAdapter adapterHead = new SqlDataAdapter(cmd);
                        DataTable tmpHeadTable = new DataTable();
                        adapterHead.Fill(tmpHeadTable);
                        BaseSQL.UpdateDataTable(adapterHead, updateRow.Table);

                        if (SaveRowAfter != null)
                        {
                            if (!SaveRowAfter(updateRow, cmd))
                            {
                                trans.Rollback();
                                return false;
                            }
                        }
                        trans.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        if (updateRow.RowState != DataRowState.Added)
                            updateRow.Table.RejectChanges();
                        throw ex;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        /// <summary>
        /// 执行删除
        /// </summary>
        private bool DoDelete(DataRow updateRow)
        {
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);

                        if (DeleteRowBefore != null)
                        {
                            if (!DeleteRowBefore(updateRow, cmd))
                            {
                                trans.Rollback();
                                return false;
                            }
                        }

                        //保存日志到日志表中
                        string logStr = LogHandler.RecordLog_DataRow(cmd, TableCaption, updateRow, PrimaryKeyColumn);

                        cmd.CommandText = string.Format("select * from {0} where 1=2", TableName);
                        SqlDataAdapter adapterHead = new SqlDataAdapter(cmd);
                        DataTable tmpHeadTable = new DataTable();
                        adapterHead.Fill(tmpHeadTable);
                        BaseSQL.UpdateDataTable(adapterHead, updateRow.Table);

                        if (DeleteRowAfter != null)
                        {
                            if (!DeleteRowAfter(updateRow, cmd))
                            {
                                trans.Rollback();
                                return false;
                            }
                        }
                        trans.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        updateRow.Table.RejectChanges();
                        throw ex;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        /// <summary>
        /// 设定编辑器控件的ReadOnly状态
        /// </summary>
        /// <param name="readOnlyState">ReadOnly状态</param>
        private void Set_EditZone_ControlReadOnly(bool readOnlyState)
        {
            if (masterEditPanel != null)
            {
                if (readOnlyState)
                {
                    foreach (Control ctl in masterEditPanel.Controls)
                    {
                        ctlHandler.Set_Control_ReadOnly(ctl, readOnlyState);
                    }
                }
                else
                {
                    foreach (Control ctl in masterEditPanel.Controls)
                    {
                        if (newState)
                        {
                            if (ctl != primaryKeyControl && (otherNoChangeControl == null || otherNoChangeControl.IndexOf(ctl) < 0))
                                ctlHandler.Set_Control_ReadOnly(ctl, readOnlyState);
                            else
                                ctlHandler.Set_Control_ReadOnly(ctl, false);
                        }
                        else
                        {
                            if (ctl != primaryKeyControl && (otherNoChangeControl ==null ||otherNoChangeControl.IndexOf(ctl) < 0))
                                ctlHandler.Set_Control_ReadOnly(ctl, readOnlyState);
                        }
                    }
                }
            }
            else
            {
                browseXtraGridView.OptionsBehavior.Editable = !readOnlyState;
            }
        }

        /// <summary>
        /// 设定按钮的状态
        /// </summary>
        private void Set_Button_State(bool state)
        {
            btnNew.Enabled = state;
            if (state)
                btnSave.Text = "修改";
            else
                btnSave.Text = "保存";
            btnCancel.Enabled = !state;
            btnDelete.Enabled = state;
            btnRefresh.Enabled = state;
            btnSaveExcel.Enabled = state;
            btnPrevious.Enabled = state;
            btnNext.Enabled = state;
            EditState = !state;

            if (buttonList.Count > 0)
            {
                for (int i = 0; i < buttonList.Count; i++)
                {
                    buttonList[i].Enabled = state;
                }
            }

            if (this.ParentForm.Controls.ContainsKey("lblEditFlag"))
            {
                //检测窗口状态：新增、编辑="EDIT"，保存、取消=""
                if (state)
                {
                    ((Label)this.ParentForm.Controls["lblEditFlag"]).Text = "";
                }
                else
                {
                    ((Label)this.ParentForm.Controls["lblEditFlag"]).Text = "EDIT";
                }
            }
        }

        /// <summary>
        /// 向上查找输入的信息
        /// </summary>
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                if (textContent.Text.Trim() == "")
                    return;
                int locationRowNo = browseXtraGridView.FocusedRowHandle;
                int locationColumnNo = browseXtraGridView.FocusedColumn.AbsoluteIndex;

                textContent.Focus();
                browseXtraGridView.Focus();
                for (int i = locationRowNo; i >= 0; i--)
                {
                    for (int j = locationColumnNo - 1; j >=0; j--)
                    {
                        if (!browseXtraGridView.Columns[j].Visible)
                            continue;
                        string cellValue = DataTypeConvert.GetString(browseXtraGridView.GetRowCellValue(i, browseXtraGridView.Columns[j]));
                        if (cellValue.Contains(textContent.Text.Trim()))
                        {
                            browseXtraGridView.FocusedRowHandle = i;
                            browseXtraGridView.FocusedColumn = browseXtraGridView.Columns[j];

                            GridViewInfo vi = browseXtraGridView.GetViewInfo() as GridViewInfo;
                            GridDataRowInfo rowInfo = vi.RowsInfo.GetInfoByHandle(i) as GridDataRowInfo;
                            GridCellInfo cellInfo = rowInfo.Cells[0];
                            if (cellInfo != null)
                            {
                                cellInfo.State = GridRowCellState.FocusedCell;
                            }
                            return;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    locationColumnNo = browseXtraGridView.Columns.Count;
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--向上查找输入的信息错误。", ex);
            }
        }

        /// <summary>
        /// 向下查找输入的信息
        /// </summary>
        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (textContent.Text.Trim() == "")
                    return;
                int locationRowNo = browseXtraGridView.FocusedRowHandle;
                int locationColumnNo = browseXtraGridView.FocusedColumn.AbsoluteIndex;

                textContent.Focus();
                browseXtraGridView.Focus();
                for (int i = locationRowNo; i < browseXtraGridView.DataRowCount; i++)
                {
                    for (int j = locationColumnNo + 1; j < browseXtraGridView.Columns.Count; j++)
                    {
                        if (!browseXtraGridView.Columns[j].Visible)
                            continue;
                        string cellValue = DataTypeConvert.GetString(browseXtraGridView.GetRowCellValue(i, browseXtraGridView.Columns[j]));
                        if (cellValue.Contains(textContent.Text.Trim()))
                        {
                            browseXtraGridView.FocusedRowHandle = i;
                            browseXtraGridView.FocusedColumn = browseXtraGridView.Columns[j];

                            GridViewInfo vi = browseXtraGridView.GetViewInfo() as GridViewInfo;
                            GridDataRowInfo rowInfo = vi.RowsInfo.GetInfoByHandle(i) as GridDataRowInfo;
                            GridCellInfo cellInfo = rowInfo.Cells[0];
                            if (cellInfo != null)
                            {
                                cellInfo.State = GridRowCellState.FocusedCell;
                            }
                            return;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    locationColumnNo = -1;
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--向下查找输入的信息错误。", ex);
            }
        }
    }
}


