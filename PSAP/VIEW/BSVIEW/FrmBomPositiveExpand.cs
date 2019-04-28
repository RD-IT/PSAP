using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using PSAP.DAO.BSDAO;
using PSAP.PSAPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PSAP.VIEW.BSVIEW
{
    public partial class FrmBomPositiveExpand : DockContent
    {
        FrmCommonDAO commonDAO = new FrmCommonDAO();
        FrmBomManagementDAO bomDAO = new FrmBomManagementDAO();

        public FrmBomPositiveExpand()
        {
            InitializeComponent();
            PSAP.BLL.BSBLL.BSBLL.language(this);
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmBomPositiveExpand_Load(object sender, EventArgs e)
        {
            try
            {
                searchCodeFileName.Properties.DataSource = commonDAO.QueryPartsCode(false);

            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiCtjzsj.Text, ex);
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
        /// 正向查询零件的Bom信息
        /// </summary>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                RefreshTreeList();

                //treeListBom.OptionsBehavior.EnableFiltering = true;
                //treeListBom.OptionsFilter.FilterMode = FilterMode.Smart;

                //treeListBom.DataSource = bomDAO.QueryBomTreeList_MoreInfo("");
                //treeListBom.ExpandAll();

                //treeListBom.FilterNodes();
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--正向查询零件的Bom信息错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiZxcxlj.Text, ex);
            }
        }

        /// <summary>
        /// 刷新Bom树形信息
        /// </summary>
        private void RefreshTreeList()
        {
            string codeFileNameStr = DataTypeConvert.GetString(searchCodeFileName.EditValue);
            treeListBom.DataSource = bomDAO.QueryBomTreeList_MoreInfo(codeFileNameStr);
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

        /// <summary>
        /// 双击查看Bom信息
        /// </summary>
        private void treeListBom_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string codeFileNameStr = DataTypeConvert.GetString(treeListBom.FocusedNode["CodeFileName"]);
                string parentCodeFileNameStr = DataTypeConvert.GetString(treeListBom.FocusedNode["ParentCodeFileName"]);
                FrmBomManagement.queryCodeFileNameStr = codeFileNameStr;
                FrmBomManagement.queryParentCodeFileNameStr = parentCodeFileNameStr;
                ViewHandler.ShowRightWindow("FrmBomManagement");
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--双击查看Bom信息错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiSjckbom.Text, ex);
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
                //ExceptionHandler.HandleException(this.Text + "--查询结果存为Excel错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiCxjgcw.Text, ex);
            }
        }

        ///// <summary>
        ///// 设定树的过来条件
        ///// </summary>
        //private void treeListBom_FilterNode(object sender, DevExpress.XtraTreeList.FilterNodeEventArgs e)
        //{
        //    try
        //    {
        //        string nodeCFNStr = DataTypeConvert.GetString(e.Node["CodeFileName"]);
        //        string codeFileNameStr = DataTypeConvert.GetString(searchCodeFileName.EditValue);

        //        bool IsVisible = nodeCFNStr.IndexOf(codeFileNameStr) >= 0;

        //        if (IsVisible)
        //        {
        //            TreeListNode Node = e.Node.ParentNode;
        //            while (Node != null)
        //            {
        //                if (!Node.Visible)
        //                {
        //                    Node.Visible = true;
        //                    Node = Node.ParentNode;
        //                }
        //                else
        //                    break;
        //            }
        //        }

        //        e.Node.Visible = IsVisible;
        //        e.Handled = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        ExceptionHandler.HandleException(this.Text + "--设定树的过来条件错误。", ex);
        //    }
        //}
    }
}
