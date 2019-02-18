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
    public partial class FrmDeliveryLocation : DockContent
    {
        FrmBaseEdit editForm = null;

        public FrmDeliveryLocation()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmDeliveryLocation_Load(object sender, EventArgs e)
        {
            try
            {
                if (editForm == null)
                {
                    editForm = new FrmBaseEdit();
                    editForm.FormBorderStyle = FormBorderStyle.None;
                    editForm.TopLevel = false;
                    editForm.TableName = "BS_DeliveryLocation";
                    editForm.TableCaption = "交货处";
                    editForm.Sql = "select * from BS_DeliveryLocation order by AutoId";
                    editForm.PrimaryKeyColumn = "AutoId";
                    editForm.MasterDataSet = dSDeliveryLocation;
                    editForm.MasterBindingSource = bSDeliveryLocation;
                    editForm.MasterEditPanel = pnlEdit;
                    editForm.PrimaryKeyControl = textLocationNo;
                    editForm.BrowseXtraGridView = gridViewDeliveryLocation;
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
            if (textLocationNo.Text.Trim() == "")
            {
                MessageHandler.ShowMessageBox("交货处编号不能为空，请重新操作。");
                textLocationNo.Focus();
                return false;
            }
            if (textLocationName.Text.Trim() == "")
            {
                MessageHandler.ShowMessageBox("交货处名称不能为空，请重新操作。");
                textLocationName.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewDeliveryLocation_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }
    }
}
