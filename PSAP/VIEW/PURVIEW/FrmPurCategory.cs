using DevExpress.XtraEditors;
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
    public partial class FrmPurCategory : DockContent
    {
        FrmBaseEdit editForm = null;

        public FrmPurCategory()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmPurCategory_Load(object sender, EventArgs e)
        {
            try
            {
                if (editForm == null)
                {
                    editForm = new FrmBaseEdit();
                    editForm.FormBorderStyle = FormBorderStyle.None;
                    editForm.TopLevel = false;
                    editForm.TableName = "PUR_PurCategory";
                    editForm.TableCaption = "采购类型";
                    editForm.Sql = "select * from PUR_PurCategory Order by AutoId";
                    editForm.PrimaryKeyColumn = "PurCategory";
                    editForm.MasterDataSet = dSPurCategory;
                    editForm.MasterBindingSource = bSPurCategory;
                    editForm.MasterEditPanel = pnlEdit;
                    editForm.PrimaryKeyControl = textPurCategory;
                    editForm.BrowseXtraGridView = gridViewPurCategory;
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
            if (textPurCategory.Text.Trim() == "")
            {
                MessageHandler.ShowMessageBox("采购类型编号不能为空，请重新操作。");
                textPurCategory.Focus();
                return false;
            }
            if (textPurCategoryText.Text.Trim() == "")
            {
                MessageHandler.ShowMessageBox("采购类型名称不能为空，请重新操作。");
                textPurCategoryText.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewPurCategory_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }
    }
}
