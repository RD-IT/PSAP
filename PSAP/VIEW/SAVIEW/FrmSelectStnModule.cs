using DevExpress.XtraGrid;
using PSAP.DAO.BSDAO;
using PSAP.DAO.SADAO;
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
    public partial class FrmSelectStnModule : DockContent
    {
        FrmCommonDAO commonDAO = new FrmCommonDAO();
        FrmStnSummaryDAO ssDAO = new FrmStnSummaryDAO();
        FrmStnModuleDAO smDAO = new FrmStnModuleDAO();

        /// <summary>
        /// 保存功能模块序号的列表
        /// </summary>
        public List<string> smNoStrList = new List<string>();

        public FrmSelectStnModule()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmSelectStnModule_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime nowDate = BaseSQL.GetServerDateTime();
                dateGetTimeBegin.DateTime = nowDate.Date.AddDays(-SystemInfo.OrderQueryDate_DefaultDays);
                dateGetTimeEnd.DateTime = nowDate.Date;

                //构建GridLevelNode并添加到LevelTree集合里面
                GridLevelNode node = new GridLevelNode();
                node.LevelTemplate = gridViewMaterialDetail;
                node.RelationName = "RelationDM";//这里对应集合的属性名称
                gridControlDeliveryDetail.LevelTree.Nodes.AddRange(new GridLevelNode[] { node });
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
            }
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewStnModule_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            ControlHandler.GridView_CustomDrawRowIndicator(e);
        }

        /// <summary>
        /// 获取单元格显示的信息
        /// </summary>
        private void gridViewStnModule_KeyDown(object sender, KeyEventArgs e)
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
        /// 查询按钮事件
        /// </summary>
        private void btnModuleQuery_Click(object sender, EventArgs e)
        {
            try
            {
                string getTimeBeginStr = "";
                string getTimeEndStr = "";
                if (dateGetTimeBegin.EditValue != null && dateGetTimeEnd.EditValue != null)
                {
                    getTimeBeginStr = dateGetTimeBegin.DateTime.ToString("yyyy-MM-dd");
                    getTimeEndStr = dateGetTimeEnd.DateTime.AddDays(1).ToString("yyyy-MM-dd");
                }

                string commonStr = textCommon.Text.Trim();

                TableStnModule.Rows.Clear();
                ssDAO.QueryStnModule(TableStnModule, getTimeBeginStr, getTimeEndStr, commonStr);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--查询按钮事件错误。", ex);
            }
        }

        /// <summary>
        /// 刷新功能模块的明细信息
        /// </summary>
        private void gridViewStnModule_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow focusedRow = gridViewStnModule.GetFocusedDataRow();
                if (focusedRow != null)
                {
                    string smNoStr = DataTypeConvert.GetString(focusedRow["SMNo"]);
                    if (smNoStr != "")
                        QueryDeliveryDetail(smNoStr);
                }
                else
                {
                    QueryDeliveryDetail("");
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--刷新功能模块的明细信息错误。", ex);
            }
        }

        /// <summary>
        /// 根据功能模块号查询相关的供货明细信息
        /// </summary>
        private void QueryDeliveryDetail(string smNoStr)
        {
            dataSet_DeliveryDetail.Tables[1].Rows.Clear();
            dataSet_DeliveryDetail.Tables[0].Rows.Clear();
            if (smNoStr != "")
            {
                smDAO.QueryDeliveryDetail(dataSet_DeliveryDetail.Tables[0], smNoStr);
                smDAO.QueryMaterialDetail(dataSet_DeliveryDetail.Tables[1], smNoStr);

                ExpandDeliveryDetail();
            }
        }

        /// <summary>
        /// 扩展所有供货明细的详细信息
        /// </summary>
        private void ExpandDeliveryDetail()
        {
            if (gridViewDeliveryDetail.DataRowCount > 0)
            {
                for (int i = 0; i < gridViewDeliveryDetail.DataRowCount; i++)
                {
                    gridViewDeliveryDetail.ExpandMasterRow(i, 0);
                }
            }
        }

        /// <summary>
        /// 双击行确定
        /// </summary>
        private void gridViewStnModule_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (e.Clicks == 2 && e.Button == MouseButtons.Left)
                {
                    BtnConfirm_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--双击行确定错误。", ex);
            }
        }

        /// <summary>
        /// 确认按钮事件
        /// </summary>
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                int[] rowint = gridViewStnModule.GetSelectedRows();
                if (rowint.Length == 0)
                {
                    if(gridViewStnModule.GetFocusedDataRow()==null)
                    {
                        MessageHandler.ShowMessageBox("请选择要操作的基础功能模块。");
                        return;
                    }
                    rowint = new int[] { gridViewStnModule.FocusedRowHandle };
                }

                foreach (int i in rowint)
                {
                    smNoStrList.Add(DataTypeConvert.GetString(gridViewStnModule.GetDataRow(i)["SMNo"]));
                }
                if (smNoStrList.Count == 0)
                {
                    MessageHandler.ShowMessageBox("请选择要操作的基础功能模块。");
                    return;
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--确认按钮事件错误。", ex);
            }
        }

    }
}
