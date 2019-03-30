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
    public partial class FrmManufactureInfo : DockContent
    {
        FrmBaseEdit editForm = null;
        static PSAP.VIEW.BSVIEW.FrmLanguageText f = new VIEW.BSVIEW.FrmLanguageText();

        public FrmManufactureInfo()
        {
            InitializeComponent();
            PSAP.BLL.BSBLL.BSBLL.language(f);
            PSAP.BLL.BSBLL.BSBLL.language(this);
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmManufactureInfo_Load(object sender, EventArgs e)
        {
            try
            {
                if (editForm == null)
                {
                    editForm = new FrmBaseEdit();
                    editForm.FormBorderStyle = FormBorderStyle.None;
                    editForm.TopLevel = false;
                    editForm.TableName = "BS_ManufactureInfo";
                    editForm.TableCaption = "制造工程信息";
                    editForm.Sql = "select * from BS_ManufactureInfo Order by AutoId";
                    editForm.PrimaryKeyColumn = "ManufactureNo";
                    editForm.MasterDataSet = dSManufactureInfo;
                    editForm.MasterBindingSource = bSManufactureInfo;
                    editForm.MasterEditPanel = pnlEdit;
                    editForm.PrimaryKeyControl = textManufactureNo;
                    editForm.BrowseXtraGridView = gridViewManufactureInfo;
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
            if (textManufactureNo.Text.Trim() == "")
            {
                MessageHandler.ShowMessageBox(tsmiGcbh.Text);// ("工程编号不能为空，请重新操作。");
                textManufactureNo.Focus();
                return false;
            }
            if (textManufactureName.Text.Trim() == "")
            {
                MessageHandler.ShowMessageBox(tsmiGcmc.Text);// ("工程名称不能为空，请重新操作。");
                textManufactureName.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewManufactureInfo_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        /// <summary>
        /// 设定列表显示信息
        /// </summary>
        private void gridViewManufactureInfo_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "ManufactureType")
            {
                e.DisplayText = CommonHandler.Get_ManufactureType_Desc(e.Value.ToString());
            }
        }

        /// <summary>
        /// 设定默认值
        /// </summary>
        private void TableManufactureInfo_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            e.Row["ManufactureType"] = 1;
        }
    }
}
