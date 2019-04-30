using PSAP.DAO.BSDAO;
using PSAP.DAO.PBDAO;
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
    public partial class FrmPBBomManagement : DockContent
    {
        FrmCommonDAO commonDAO = new FrmCommonDAO();
        FrmPBBomManagementDAO bomDAO = new FrmPBBomManagementDAO();

        public FrmPBBomManagement(string salesOrderNo)
        {
            InitializeComponent();
            textAutoSalesOrderNo.Text = salesOrderNo;
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmPBBomManagement_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable salesOrderTable = bomDAO.QuerySalesOrder(textAutoSalesOrderNo.Text);
                if(salesOrderTable.Rows.Count==0)
                {
                    MessageHandler.ShowMessageBox(string.Format("未查询到销售订单[{0}]，请重新操作。", textAutoSalesOrderNo.Text));
                    this.Close();
                }
                textProjectNo.Text = DataTypeConvert.GetString(salesOrderTable.Rows[0]["ProjectNo"]);
                textProjectName.Text = DataTypeConvert.GetString(salesOrderTable.Rows[0]["ProjectName"]);

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
            ControlHandler.GridView_CustomDrawRowIndicator(e);
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
        /// 获取单元格显示的信息
        /// </summary>
        private void gridViewPartsCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                ControlHandler.GridView_GetFocusedCellDisplayText_KeyDown(sender, e);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--获取单元格显示的信息错误。", ex);
            }
        }

        /// <summary>
        /// 查询零件信息
        /// </summary>
        private void QueryPartsCodeInfo()
        {
            bomDAO.QueryPartsCode(dSPartsCode.Tables[0]);
        }

        /// <summary>
        /// 查询BOM信息
        /// </summary>
        private void QueryBOMInfo()
        {
            string codeFileNameStr = DataTypeConvert.GetString(searchCodeFileName.EditValue);
            treeListBom.DataSource = bomDAO.QueryBomInfo(codeFileNameStr);
            treeListBom.ExpandAll();
        }

        /// <summary>
        /// 查询零件信息和BOM信息
        /// </summary>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                QueryPartsCodeInfo();
                QueryBOMInfo();
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--查询零件信息和BOM信息错误。", ex);
            }
        }
    }
}
