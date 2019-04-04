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
    public partial class FrmBrandCatg : DockContent
    {
        FrmBaseEdit editForm = null;

        public FrmBrandCatg()
        {
            InitializeComponent();
            PSAP.BLL.BSBLL.BSBLL.language(this);
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmBrandCatg_Load(object sender, EventArgs e)
        {
            try
            {
                if (editForm == null)
                {
                    editForm = new FrmBaseEdit();
                    editForm.FormBorderStyle = FormBorderStyle.None;
                    editForm.TopLevel = false;
                    editForm.TableName = "SW_BrandCatg";
                    editForm.TableCaption = "品牌信息";
                    editForm.Sql = "select * from SW_BrandCatg order by AutoId";
                    editForm.PrimaryKeyColumn = "BrandNo";
                    editForm.MasterDataSet = dSBrandCatg;
                    editForm.MasterBindingSource = bSBrandCatg;
                    editForm.MasterEditPanel = pnlEdit;
                    editForm.PrimaryKeyControl = textBrandNo;
                    editForm.BrowseXtraGridView = gridViewBrandCatg;
                    editForm.CheckControl += CheckControl;
                    this.pnlToolBar.Controls.Add(editForm);
                    editForm.Dock = DockStyle.Fill;
                    editForm.Show();
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiCtjz.Text, ex);
            }
        }

        /// <summary>
        /// 保存之前的回调方法
        /// </summary>
        public bool CheckControl()
        {
            if (textBrandNo.Text.Trim() == "")
            {
                //MessageHandler.ShowMessageBox("品牌编号不能为空，请重新操作。");
                MessageHandler.ShowMessageBox(tsmiPpbh.Text);
                textBrandNo.Focus();
                return false;
            }
            if (textBrandName.Text.Trim() == "")
            {
                //MessageHandler.ShowMessageBox("品牌名称不能为空，请重新操作。");
                MessageHandler.ShowMessageBox(tsmiPpmc.Text);
                textBrandName.Focus();
                return false;
            }

            return true;
        }
    }
}
