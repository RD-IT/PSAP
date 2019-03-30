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
    public partial class FrmUnitCatg_New : DockContent
    {
        FrmBaseEdit editForm = null;
        static PSAP.VIEW.BSVIEW.FrmLanguageText f = new VIEW.BSVIEW.FrmLanguageText();

        public FrmUnitCatg_New()
        {
            InitializeComponent();
            PSAP.BLL.BSBLL.BSBLL.language(f);
            PSAP.BLL.BSBLL.BSBLL.language(this);

        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmUnitCatg_New_Load(object sender, EventArgs e)
        {
            try
            {
                if (editForm == null)
                {
                    editForm = new FrmBaseEdit();
                    editForm.FormBorderStyle = FormBorderStyle.None;
                    editForm.TopLevel = false;
                    editForm.TableName = "BS_UnitCatg";
                    editForm.TableCaption = "计量单位";
                    editForm.Sql = "select * from BS_UnitCatg order by AutoId";
                    editForm.PrimaryKeyColumn = "UnitNo";
                    editForm.MasterDataSet = dSUnitCatg;
                    editForm.MasterBindingSource = bSUnitCatg;
                    editForm.MasterEditPanel = pnlEdit;
                    editForm.PrimaryKeyControl = textUnitNo;
                    editForm.BrowseXtraGridView = gridViewUnitCatg;
                    editForm.CheckControl += CheckControl;
                    this.pnlToolBar.Controls.Add(editForm);
                    editForm.Dock = DockStyle.Fill;
                    editForm.Show();
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiCtjzsjcw.Text, ex);
            }
        }

        /// <summary>
        /// 保存之前的回调方法
        /// </summary>
        public bool CheckControl()
        {
            if (textUnitNo.Text.Trim() == "")
            {
                MessageHandler.ShowMessageBox(tsmiDwbhbnwk.Text);// ("单位编号不能为空，请重新操作。");
                textUnitNo.Focus();
                return false;
            }
            if (textUnitName.Text.Trim() == "")
            {
                MessageHandler.ShowMessageBox(tsmiDwmcbnwk.Text);// ("单位名称不能为空，请重新操作。");
                textUnitName.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewUnitCatg_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }
    }
}
