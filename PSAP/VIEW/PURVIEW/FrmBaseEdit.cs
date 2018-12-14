using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
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

        ControlHandler ctlHandler = new ControlHandler();

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
        }

        /// <summary>
        /// 新增按钮事件
        /// </summary>
        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = masterDataSet.Tables[0].NewRow();
                masterDataSet.Tables[0].Rows.Add(dr);
                masterBindingSource.MoveLast();

                Set_Button_State(false);
                Set_EditZone_ControlReadOnly(false);
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text != "保存")
            {
                try
                {
                    Set_Button_State(false);
                    Set_EditZone_ControlReadOnly(false);
                    masterEditPanel.SelectNextControl(null, true, true, true, true);
                }
                catch (Exception ex)
                {
                    ExceptionHandler.HandleException(this.Text + "--修改按钮事件错误。", ex);
                    masterEditPanel.SelectNextControl(null, true, true, true, true);
                }
            }
            else
            {
                btnSave_Click();
            }
        }

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
                        masterEditPanel.SelectNextControl(null, true, true, true, true);
                        return false;
                    }
                }

                if (dr.RowState != DataRowState.Unchanged)
                {
                    if (DoSave(dr))
                    {
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
                masterEditPanel.SelectNextControl(null, true, true, true, true);
                return false;
            }
        }

        /// <summary>
        /// 取消按钮事件
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                masterBindingSource.CancelEdit();
                ((DataRowView)masterBindingSource.Current).Row.RejectChanges();
                Set_Button_State(true);
                Set_EditZone_ControlReadOnly(true);
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
                if (MessageHandler.ShowMessageBox_YesNo("确定要删除当前选中的记录吗？") != DialogResult.Yes)
                {
                    return;
                }

                DataRow dr = ((DataRowView)masterBindingSource.Current).Row;
                ((DataRowView)masterBindingSource.Current).Row.Delete();
                DoDelete(dr);
                Set_Button_State(true);
                Set_EditZone_ControlReadOnly(true);
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
                Set_Button_State(true);
                Set_EditZone_ControlReadOnly(true);
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
            foreach (Control ctl in masterEditPanel.Controls)
            {
                ctlHandler.Set_Control_ReadOnly(ctl, readOnlyState);
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
}


