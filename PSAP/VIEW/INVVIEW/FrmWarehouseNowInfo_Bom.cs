using PSAP.DAO.BSDAO;
using PSAP.DAO.INVDAO;
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
    public partial class FrmWarehouseNowInfo_Bom : DockContent
    {
        FrmCommonDAO commonDAO = new FrmCommonDAO();
        FrmWarehouseNowInfoDAO nowDAO = new FrmWarehouseNowInfoDAO();

        public FrmWarehouseNowInfo_Bom()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmWarehouseNowInfo_Bom_Load(object sender, EventArgs e)
        {
            try
            {
                searchCodeFileName.Properties.DataSource = commonDAO.QueryPartsCode(false);
                lookUpRepertoryNo.Properties.DataSource = commonDAO.QueryRepertoryInfo(true);
                lookUpRepertoryNo.ItemIndex = 0;
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
            }
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewBomMateriel_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            ControlHandler.GridView_CustomDrawRowIndicator(e);
        }

        /// <summary>
        /// 根据选择显示零件名称
        /// </summary>
        private void searchCodeFileName_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
                textCodeName.Text = DataTypeConvert.GetString(searchPartsCodeIdView.GetRowCellValue(searchCodeFileName.Properties.GetIndexByKeyValue(e.NewValue), "CodeName"));
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--根据选择显示零件名称错误。", ex);
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                if(DataTypeConvert.GetString(searchCodeFileName.EditValue)=="")
                {
                    MessageHandler.ShowMessageBox("请选择要查询的零件编号。");
                    searchCodeFileName.Focus();
                    return;
                }

                RefreshTreeList();
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--正向查询零件的Bom信息错误。", ex);
            }
        }

        /// <summary>
        /// 查询结果存为Excel
        /// </summary>
        private void btnSaveExcel_Click(object sender, EventArgs e)
        {
            try
            {
                FileHandler.SaveTreeListControlExportToExcel(treeListBom);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--查询结果存为Excel错误。", ex);
            }
        }

        /// <summary>
        /// 刷新Bom树形信息
        /// </summary>
        private void RefreshTreeList()
        {
            string codeFileNameStr = DataTypeConvert.GetString(searchCodeFileName.EditValue);
            string repertoryNoStr = "";
            if (lookUpRepertoryNo.ItemIndex > 0)
            {
                repertoryNoStr = DataTypeConvert.GetString(lookUpRepertoryNo.EditValue);
            }

            treeListBom.DataSource = nowDAO.QueryBomWarehouseNowInfo(codeFileNameStr, repertoryNoStr);
            treeListBom.ExpandAll();
        }

        /// <summary>
        /// 获取单元格显示的信息
        /// </summary>
        private void treeListBom_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                ControlHandler.TreeList_GetFocusedCellDisplayText_KeyDown(sender, e);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--获取单元格显示的信息错误。", ex);
            }
        }

    }
}
