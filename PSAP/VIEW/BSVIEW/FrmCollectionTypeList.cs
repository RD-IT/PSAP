using PSAP.DAO.BSDAO;
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
    public partial class FrmCollectionTypeList : DockContent
    {
        /// <summary>
        /// 收款类型
        /// </summary>
        string collectionTypeNoStr = "";

        FrmCollectionTypeDAO collectionTypeDAO = new FrmCollectionTypeDAO();

        public FrmCollectionTypeList()
        {
            InitializeComponent();
        }

        public FrmCollectionTypeList(string ctNoStr, string ctNoTextStr)
        {
            InitializeComponent();
            collectionTypeNoStr = ctNoStr;
            this.Text = string.Format("收款类型【{0}】的信息", ctNoTextStr);
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmCollectionTypeList_Load(object sender, EventArgs e)
        {
            try
            {
                repItemLookUpCollectionType.DataSource = new FrmCommonDAO().QueryCollectionType(false);

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
        private void gridViewCollectionTypeList_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        /// <summary>
        /// 设定默认值
        /// </summary>
        private void TableCollectionTypeList_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            try
            {
                e.Row["CollectionTypeNo"] = collectionTypeNoStr;
                int sumInt = DataTypeConvert.GetInt(TableCollectionTypeList.Compute("Sum(CollectionPercentum)", ""));
                e.Row["CollectionPercentum"] = (100 - sumInt) >= 0 ? 100 - sumInt : 0;
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
                DataRow dr = dSCollectionTypeList.Tables[0].NewRow();
                dSCollectionTypeList.Tables[0].Rows.Add(dr);
                bSCollectionTypeList.MoveLast();

                Set_Button_State(false);
                Set_EditZone_ControlReadOnly(false);
                gridViewCollectionTypeList.Focus();
                gridViewCollectionTypeList.FocusedColumn = colCollectionPercentum;
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
                    gridViewCollectionTypeList.Focus();
                    gridViewCollectionTypeList.FocusedColumn = colCollectionPercentum;
                }
                catch (Exception ex)
                {
                    ExceptionHandler.HandleException(this.Text + "--修改按钮事件错误。", ex);
                    gridViewCollectionTypeList.Focus();
                    gridViewCollectionTypeList.FocusedColumn = colCollectionPercentum;
                }
            }
            else
            {
                try
                {
                    int sumInt = DataTypeConvert.GetInt(TableCollectionTypeList.Compute("Sum(CollectionPercentum)", ""));
                    if (sumInt != 100)
                    {
                        MessageHandler.ShowMessageBox("收款百分比的合计必须是100，请重新操作。");
                        gridViewCollectionTypeList.Focus();
                        gridViewCollectionTypeList.FocusedColumn = colCollectionPercentum;
                        return;
                    }

                    bSCollectionTypeList.EndEdit();

                    if (!collectionTypeDAO.SaveCollectionTypeList(dSCollectionTypeList.Tables[0], collectionTypeNoStr))
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
                    gridViewCollectionTypeList.Focus();
                    gridViewCollectionTypeList.FocusedColumn = colCollectionPercentum;
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
                DataRow dr = ((DataRowView)bSCollectionTypeList.Current).Row;
                ((DataRowView)bSCollectionTypeList.Current).Row.Delete();
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
                dSCollectionTypeList.Tables[0].Clear();
                collectionTypeDAO.QueryCollectionTypeList(dSCollectionTypeList.Tables[0], collectionTypeNoStr);
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
            gridViewCollectionTypeList.OptionsBehavior.Editable = !readOnlyState;
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
