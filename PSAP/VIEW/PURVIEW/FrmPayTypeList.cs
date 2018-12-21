using DevExpress.XtraEditors;
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
    public partial class FrmPayTypeList : DockContent
    {
        /// <summary>
        /// 付款类型
        /// </summary>
        string payTypeNoStr = "";

        FrmPayTypeDAO payTypeDAO = new FrmPayTypeDAO();

        public FrmPayTypeList()
        {
            InitializeComponent();
        }

        public FrmPayTypeList(string ptNoStr, string ptNoTextStr)
        {
            InitializeComponent();
            payTypeNoStr = ptNoStr;
            this.Text = string.Format("付款类型【{0}】的信息", ptNoTextStr);
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmPayTypeList_Load(object sender, EventArgs e)
        {
            try
            {
                repItemLookUpPayType.DataSource = new DAO.PURDAO.FrmOrderDAO().QueryPayType(false);

                btnRefresh_Click(null, null);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
            }
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewPayTypeList_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        /// <summary>
        /// 设定默认值
        /// </summary>
        private void TablePayTypeList_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            try
            {
                e.Row["PayTypeNo"] = payTypeNoStr;
                int sumInt = DataTypeConvert.GetInt(TablePayTypeList.Compute("Sum(PayPercentum)", ""));
                e.Row["PayPercentum"] = (100 - sumInt) >= 0 ? 100 - sumInt : 0;
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--设定默认值事件错误。", ex);
            }
        }

        /// <summary>
        /// 新增按钮事件
        /// </summary>
        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = dSPayTypeList.Tables[0].NewRow();
                dSPayTypeList.Tables[0].Rows.Add(dr);
                bSPayTypeList.MoveLast();

                Set_Button_State(false);
                Set_EditZone_ControlReadOnly(false);
                gridViewPayTypeList.Focus();
                gridViewPayTypeList.FocusedColumn = colPayPercentum;
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
                    gridViewPayTypeList.Focus();
                    gridViewPayTypeList.FocusedColumn = colPayPercentum;
                }
                catch (Exception ex)
                {
                    ExceptionHandler.HandleException(this.Text + "--修改按钮事件错误。", ex);
                    gridViewPayTypeList.Focus();
                    gridViewPayTypeList.FocusedColumn = colPayPercentum;
                }
            }
            else
            {
                try
                {
                    int sumInt = DataTypeConvert.GetInt(TablePayTypeList.Compute("Sum(PayPercentum)", ""));
                    if (sumInt != 100)
                    {
                        MessageHandler.ShowMessageBox("付款百分比的合计必须是100，请重新操作。");
                        gridViewPayTypeList.Focus();
                        gridViewPayTypeList.FocusedColumn = colPayPercentum;
                        return;
                    }

                    bSPayTypeList.EndEdit();

                    if (!payTypeDAO.SavePayTypeList(dSPayTypeList.Tables[0], payTypeNoStr))
                    {
                        return;
                    }

                    Set_Button_State(true);
                    Set_EditZone_ControlReadOnly(true);
                    btnRefresh_Click(null, null);
                }
                catch (Exception ex)
                {
                    ExceptionHandler.HandleException(this.Text + "--保存按钮事件错误。", ex);
                    gridViewPayTypeList.Focus();
                    gridViewPayTypeList.FocusedColumn = colPayPercentum;
                }
            }
        }

        /// <summary>
        /// 取消按钮事件
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnRefresh_Click(null, null);
        }

        /// <summary>
        /// 删除按钮事件
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = ((DataRowView)bSPayTypeList.Current).Row;
                ((DataRowView)bSPayTypeList.Current).Row.Delete();
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--删除按钮事件错误。", ex);
            }
        }

        /// <summary>
        /// 刷新按钮事件
        /// </summary>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                dSPayTypeList.Tables[0].Clear();
                payTypeDAO.QueryPayTypeList(dSPayTypeList.Tables[0], payTypeNoStr);
                Set_Button_State(true);
                Set_EditZone_ControlReadOnly(true);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--刷新按钮事件错误。", ex);
            }
        }

        /// <summary>
        /// 设定编辑器控件的ReadOnly状态
        /// </summary>
        /// <param name="readOnlyState">ReadOnly状态</param>
        private void Set_EditZone_ControlReadOnly(bool readOnlyState)
        {
            gridViewPayTypeList.OptionsBehavior.Editable = !readOnlyState;
        }

        /// <summary>
        /// 设定按钮的状态
        /// </summary>
        private void Set_Button_State(bool state)
        {
            btnNew.Enabled = !state;
            if (state)
                btnSave.Text = "修改";
            else
                btnSave.Text = "保存";
            btnCancel.Enabled = !state;
            btnDelete.Enabled = !state;
            btnRefresh.Enabled = state;
        }
    }
}
