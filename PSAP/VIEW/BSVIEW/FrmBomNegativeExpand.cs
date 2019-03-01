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
    public partial class FrmBomNegativeExpand : DockContent
    {
        FrmCommonDAO commonDAO = new FrmCommonDAO();
        FrmBomManagementDAO bomDAO = new FrmBomManagementDAO();

        public FrmBomNegativeExpand()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmBomNegativeExpand_Load(object sender, EventArgs e)
        {
            try
            {
                searchCodeFileName.Properties.DataSource = commonDAO.QueryPartsCode(false);
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
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        /// <summary>
        /// 反向查询零件的Bom信息
        /// </summary>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                //treeListBom.OptionsBehavior.EnableFiltering = true;
                //treeListBom.OptionsFilter.FilterMode = FilterMode.Smart;

                treeListBom.DataSource = bomDAO.QueryBomTreeList_MoreInfo("");
                treeListBom.ExpandAll();

                treeListBom.FilterNodes();
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--正向查询零件的Bom信息错误。", ex);
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
                string parentCodeFileNameStr= DataTypeConvert.GetString(treeListBom.FocusedNode["ParentCodeFileName"]);
                FrmBomManagement.queryCodeFileNameStr = codeFileNameStr;
                FrmBomManagement.queryParentCodeFileNameStr = parentCodeFileNameStr;
                ViewHandler.ShowRightWindow("FrmBomManagement");
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--双击查看Bom信息错误。", ex);
            }
        }

        /// <summary>
        /// 设定树的过来条件
        /// </summary>
        private void treeListBom_FilterNode(object sender, DevExpress.XtraTreeList.FilterNodeEventArgs e)
        {
            try
            {
                string nodeCFNStr = DataTypeConvert.GetString(e.Node["CodeFileName"]);
                string codeFileNameStr = DataTypeConvert.GetString(searchCodeFileName.EditValue);

                bool IsVisible = nodeCFNStr.IndexOf(codeFileNameStr) >= 0;

                if (IsVisible)
                {
                    TreeListNode Node = e.Node.ParentNode;
                    while (Node != null)
                    {
                        if (!Node.Visible)
                        {
                            Node.Visible = true;
                            Node = Node.ParentNode;
                        }
                        else
                            break;
                    }
                }

                e.Node.Visible = IsVisible;
                e.Handled = true;
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--设定树的过来条件错误。", ex);
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
    }
}
