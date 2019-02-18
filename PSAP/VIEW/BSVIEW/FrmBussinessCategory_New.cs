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
    public partial class FrmBussinessCategory_New : DockContent
    {
        FrmBaseEdit editForm = null;

        public FrmBussinessCategory_New()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmBussinessCategory_New_Load(object sender, EventArgs e)
        {
            try
            {
                if (editForm == null)
                {
                    editForm = new FrmBaseEdit();
                    editForm.FormBorderStyle = FormBorderStyle.None;
                    editForm.TopLevel = false;
                    editForm.TableName = "BS_BussinessCategory";
                    editForm.TableCaption = "商业往来类别";
                    editForm.Sql = "select * from BS_BussinessCategory order by AutoId";
                    editForm.PrimaryKeyColumn = "AutoId";
                    editForm.MasterDataSet = dSBussinessCategory;
                    editForm.MasterBindingSource = bSBussinessCategory;
                    editForm.MasterEditPanel = pnlEdit;
                    editForm.PrimaryKeyControl = textBussinessCategory;
                    editForm.BrowseXtraGridView = gridViewBussinessCategory;
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
            if (textBussinessCategory.Text.Trim() == "")
            {
                MessageHandler.ShowMessageBox("商业往来类别编号不能为空，请重新操作。");
                textBussinessCategory.Focus();
                return false;
            }
            if (textBussinessCategoryText.Text.Trim() == "")
            {
                MessageHandler.ShowMessageBox("商业往来类别名称不能为空，请重新操作。");
                textBussinessCategoryText.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewBussinessCategory_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }
    }
}
