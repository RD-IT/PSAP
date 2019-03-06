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
    public partial class FrmRepertoryInfo : DockContent
    {
        FrmBaseEdit editForm = null;
        static PSAP.VIEW.BSVIEW.FrmLanguageText f = new VIEW.BSVIEW.FrmLanguageText();

        public FrmRepertoryInfo()
        {
            InitializeComponent();
            PSAP.BLL.BSBLL.BSBLL.language(f);
            PSAP.BLL.BSBLL.BSBLL.language(this);
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmRepertoryInfo_Load(object sender, EventArgs e)
        {
            try
            {
                if (editForm == null)
                {
                    editForm = new FrmBaseEdit();
                    editForm.FormBorderStyle = FormBorderStyle.None;
                    editForm.TopLevel = false;
                    editForm.TableName = "BS_RepertoryInfo";
                    editForm.TableCaption = "仓库信息";
                    editForm.Sql = "select * from BS_RepertoryInfo Order by AutoId";
                    editForm.PrimaryKeyColumn = "RepertoryNo";
                    editForm.MasterDataSet = dSRepertoryInfo;
                    editForm.MasterBindingSource = bSRepertoryInfo;
                    editForm.MasterEditPanel = pnlEdit;
                    editForm.PrimaryKeyControl = textRepertoryNo;
                    editForm.BrowseXtraGridView = gridViewRepertoryInfo;
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
            if (textRepertoryNo.Text.Trim() == "")
            {
                MessageHandler.ShowMessageBox(tsmiCkbhbnwk.Text);// ("仓库编号不能为空，请重新操作。");
                textRepertoryNo.Focus();
                return false;
            }
            if (textRepertoryName.Text.Trim() == "")
            {
                MessageHandler.ShowMessageBox(tsmiCkmcbnwk.Text);// ("仓库名称不能为空，请重新操作。");
                textRepertoryName.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewRepertoryInfo_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        /// <summary>
        /// 设定列表显示信息
        /// </summary>
        private void gridViewRepertoryInfo_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "RepertoryType")
            {
                e.DisplayText = CommonHandler.Get_RepertoryType_Desc(e.Value.ToString());
            }
        }

        /// <summary>
        /// 设定默认值
        /// </summary>
        private void TableRepertoryInfo_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            e.Row["RepertoryType"] = 1;
        }

    }
}
