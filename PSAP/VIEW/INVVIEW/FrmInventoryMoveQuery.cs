using PSAP.DAO.BSDAO;
using PSAP.DAO.INVDAO;
using PSAP.PSAPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PSAP.VIEW.BSVIEW
{
    public partial class FrmInventoryMoveQuery : DockContent
    {
        FrmCommonDAO commonDAO = new FrmCommonDAO();
        FrmInventoryMoveDAO imDAO = new FrmInventoryMoveDAO();
        static PSAP.VIEW.BSVIEW.FrmLanguageText f = new VIEW.BSVIEW.FrmLanguageText();

        public FrmInventoryMoveQuery()
        {
            InitializeComponent();
            PSAP.BLL.BSBLL.BSBLL.language(f);
            PSAP.BLL.BSBLL.BSBLL.language(this);
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmInventoryMoveQuery_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime nowDate = BaseSQL.GetServerDateTime();
                dateIMDateBegin.DateTime = nowDate.Date.AddDays(-SystemInfo.OrderQueryDate_DefaultDays);
                dateIMDateEnd.DateTime = nowDate.Date;

                lookUpInRepertoryNo.Properties.DataSource = commonDAO.QueryRepertoryInfo(true);
                lookUpInRepertoryNo.ItemIndex = 0;
                lookUpOutRpertoryNo.Properties.DataSource = commonDAO.QueryRepertoryInfo(true);
                lookUpOutRpertoryNo.ItemIndex = 0;
                lookUpReqDep.Properties.DataSource = commonDAO.QueryDepartment(true);
                lookUpReqDep.ItemIndex = 0;
                lookUpPrepared.Properties.DataSource = commonDAO.QueryUserInfo(true);
                lookUpPrepared.EditValue = SystemInfo.user.EmpName;

                repLookUpInRepertoryNo.DataSource = commonDAO.QueryRepertoryInfo(false);
                repLookUpReqDep.DataSource = commonDAO.QueryDepartment(false);

                gridBottomIM.pageRowCount = SystemInfo.OrderQueryGrid_PageRowCount;

                btnQuery_Click(null, null);
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiCtjzsjcw.Text, ex);
            }
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewIMHead_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        /// <summary>
        /// 查询按钮事件
        /// </summary>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                if (dateIMDateBegin.EditValue == null || dateIMDateEnd.EditValue == null)
                {
                    MessageHandler.ShowMessageBox(tsmiYdrqbnwkcx.Text);// ("移动日期不能为空，请设置后重新进行查询。");
                    if (dateIMDateBegin.EditValue == null)
                        dateIMDateBegin.Focus();
                    else
                        dateIMDateEnd.Focus();
                    return;
                }
                string orderDateBeginStr = dateIMDateBegin.DateTime.ToString("yyyy-MM-dd");
                string orderDateEndStr = dateIMDateEnd.DateTime.AddDays(1).ToString("yyyy-MM-dd");

                string inRepertoryNoStr = lookUpInRepertoryNo.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpInRepertoryNo.EditValue) : "";
                string outRepertoryNoStr = lookUpOutRpertoryNo.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpOutRpertoryNo.EditValue) : "";
                string reqDepStr = lookUpReqDep.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpReqDep.EditValue) : "";
                string empNameStr = lookUpPrepared.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpPrepared.EditValue) : "";
                string commonStr = textCommon.Text.Trim();

                dataSet_IM.Tables[0].Clear();
                string querySqlStr = imDAO.QueryInventoryMoveHead_SQL(orderDateBeginStr, orderDateEndStr, inRepertoryNoStr, outRepertoryNoStr, reqDepStr, empNameStr, commonStr, false);

                string countSqlStr = commonDAO.QuerySqlTranTotalCountSql(querySqlStr);
                gridBottomIM.QueryGridData(ref dataSet_IM, "IMHead", querySqlStr, countSqlStr, true);
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--查询按钮事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiCxansjcw.Text, ex);
            }
        }

        /// <summary>
        /// 查询结果存为Excel
        /// </summary>
        private void btnSaveExcel_Click(object sender, EventArgs e)
        {
            try
            {
                FileHandler.SaveDevGridControlExportToExcel(gridViewIMHead);
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--查询结果存为Excel错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiCxjgcwexcelcw.Text, ex);
            }
        }

        /// <summary>
        /// 双击查询明细
        /// </summary>
        private void gridViewIMHead_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (e.Clicks == 2)
                {
                    string inventoryMoveNoStr = DataTypeConvert.GetString(gridViewIMHead.GetFocusedDataRow()["InventoryMoveNo"]);
                    FrmInventoryMove_Drag.queryIMHeadNo = inventoryMoveNoStr;
                    FrmInventoryMove_Drag.queryListAutoId = 0;
                    ViewHandler.ShowRightWindow("FrmInventoryMove_Drag");
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--双击查询明细错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiSjcxmxcw.Text, ex);
            }
        }
    }
}
