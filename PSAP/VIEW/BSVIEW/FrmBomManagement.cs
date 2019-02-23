using PSAP.DAO.BSDAO;
using PSAP.PSAPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PSAP.VIEW.BSVIEW
{
    public partial class FrmBomManagement : DockContent
    {
        FrmCommonDAO commonDAO = new FrmCommonDAO();
        FrmBomManagementDAO bomDAO = new FrmBomManagementDAO();

        public FrmBomManagement()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmBomManagement_Load(object sender, EventArgs e)
        {
            try
            {
                searchPartsCodeId.Properties.DataSource = commonDAO.QueryPartsCode(false);
                lookUpMaterieState.Properties.DataSource = bomDAO.QueryBomMaterieState(false);

                repSearchCodeFileName.DataSource = commonDAO.QueryPartsCode(false);
                RefreshTreeList();
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
        /// 刷新Bom树形信息
        /// </summary>
        private void RefreshTreeList()
        {
            treeListBom.DataSource = bomDAO.QueryBomTreeList();
        }

        /// <summary>
        /// 刷新当前选择
        /// </summary>
        /// <param name="materielNoStr"></param>
        private void RefreshBomInfo(string materielNoStr)
        {
            dSBom.Tables[0].Rows.Clear();
            dSBom.Tables[1].Rows.Clear();
            bomDAO.QueryBomManagement_Single(dSBom.Tables[0], materielNoStr);
            bomDAO.QueryBomMateriel(dSBom.Tables[1], materielNoStr);
        }

        /// <summary>
        /// 聚焦查询当前选中Bom信息
        /// </summary>
        private void treeListBom_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            try
            {
                string materielNoStr = DataTypeConvert.GetString(treeListBom.FocusedNode["LevelMaterielNo"]);
                RefreshBomInfo(materielNoStr);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--聚焦查询当前选中Bom信息错误。", ex);
            }
        }
    }
}
