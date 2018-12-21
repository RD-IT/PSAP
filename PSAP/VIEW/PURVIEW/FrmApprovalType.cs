using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
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
    public partial class FrmApprovalType : DockContent
    {
        FrmBaseEdit editForm = null;

        public FrmApprovalType()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmApprovalType_Load(object sender, EventArgs e)
        {
            try
            {
                if (editForm == null)
                {
                    editForm = new FrmBaseEdit();
                    editForm.FormBorderStyle = FormBorderStyle.None;
                    editForm.TopLevel = false;
                    editForm.TableName = "PUR_ApprovalType";
                    editForm.TableCaption = "审批类型";
                    editForm.Sql = "select * from PUR_ApprovalType Order by AutoId";
                    editForm.PrimaryKeyColumn = "TypeNo";
                    editForm.MasterDataSet = dSApprovalType;
                    editForm.MasterBindingSource = bSApprovalType;
                    editForm.MasterEditPanel = pnlEdit;
                    editForm.BrowseXtraGridView = gridViewApprovalType;
                    editForm.CheckControl += CheckControl;
                    this.pnlToolBar.Controls.Add(editForm);
                    editForm.Dock = DockStyle.Fill;
                    editForm.Show();
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
            }
        }

        /// <summary>
        /// 保存之前的回调方法
        /// </summary>
        public bool CheckControl()
        {
            if (textTypeNo.Text.Trim() == "")
            {
                MessageHandler.ShowMessageBox("审批类型编码不能为空，请重新操作。");
                textTypeNo.Focus();
                return false;
            }
            if (textTypeNoText.Text.Trim() == "")
            {
                MessageHandler.ShowMessageBox("审批类型名称不能为空，请重新操作。");
                textTypeNoText.Focus();
                return false;
            }
            if(radioApprovalCat.SelectedIndex<0)
            {
                MessageHandler.ShowMessageBox("审批类型必须选择，请重新操作。");
                radioApprovalCat.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewApprovalType_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        /// <summary>
        /// 设定列表显示信息
        /// </summary>
        private void gridViewApprovalType_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "ApprovalCat")
            {
                switch (e.Value.ToString())
                {
                    case "0":
                        e.DisplayText = "串行审批";
                        break;
                    case "1":
                        e.DisplayText = "并行审批";
                        break;
                    case "2":
                        e.DisplayText = "多选一审核";
                        break;
                }
            }
        }

        /// <summary>
        /// 设定默认值
        /// </summary>
        private void TableApprovalType_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            e.Row["ApprovalCat"] = 0;
        }


        /// <summary>
        /// 设定审批信息
        /// </summary>
        private void btnApprovalList_Click(object sender, EventArgs e)
        {
            if (!editForm.EditState)
            {
                DataRow dr = gridViewApprovalType.GetFocusedDataRow();
                FrmApprovalList appList = new FrmApprovalList(DataTypeConvert.GetString(dr["TypeNo"]), DataTypeConvert.GetString(dr["TypeNoText"]));
                appList.ShowDialog();
            }
            else
            {
                MessageHandler.ShowMessageBox("请先保存后再进行其他操作。");
            }
        }
    }
}
