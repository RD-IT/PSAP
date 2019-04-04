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
    public partial class FrmCurrencyCate : DockContent
    {
        FrmBaseEdit editForm = null;

        public FrmCurrencyCate()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmCurrencyCate_Load(object sender, EventArgs e)
        {
            try
            {
                if (editForm == null)
                {
                    editForm = new FrmBaseEdit();
                    editForm.FormBorderStyle = FormBorderStyle.None;
                    editForm.TopLevel = false;
                    editForm.TableName = "BS_CurrencyCate";
                    editForm.TableCaption = "币种信息";
                    editForm.Sql = "select * from BS_CurrencyCate order by AutoId";
                    editForm.PrimaryKeyColumn = "AutoId";
                    editForm.MasterDataSet = dSCurrencyCate;
                    editForm.MasterBindingSource = bSCurrencyCate;
                    editForm.MasterEditPanel = pnlEdit;
                    //editForm.PrimaryKeyControl = textShelfNo;
                    editForm.BrowseXtraGridView = gridViewCurrencyCate;
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
            if (textCurrencyCateAbb.Text.Trim() == "")
            {
                MessageHandler.ShowMessageBox("币种缩写不能为空，请重新操作。");
                textCurrencyCateAbb.Focus();
                return false;
            }
            if (textCurrencyCateName.Text.Trim() == "")
            {
                MessageHandler.ShowMessageBox("币种名称不能为空，请重新操作。");
                textCurrencyCateName.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// 设定默认值
        /// </summary>
        private void TableCurrencyCate_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            e.Row["ExchangeRate"] = 1;
        }
    }
}
