using DevExpress.XtraGrid.Views.Base;
using PSAP.DAO.PURDAO;
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
    public partial class FrmPrReqApply : DockContent
    {
        FrmPrReqDAO prReqDAO = new FrmPrReqDAO();
        FrmPrReqApplyDAO applyDAO = new FrmPrReqApplyDAO();

        DataTable prReqListTable = new DataTable();

        public FrmPrReqApply()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmPrReqApply_Load(object sender, EventArgs e)
        {
            try
            {
                repLookUpReqDep.DataSource = prReqDAO.QueryDepartment(false);
                repLookUpPurCategory.DataSource = prReqDAO.QueryPurCategory(false);
                repSearchProjectNo.DataSource = prReqDAO.QueryProjectList();

                prReqListTable = dataSet_PrReq.Tables[1].Clone();
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
            }
        }

        /// <summary>
        /// 查询按钮事件
        /// </summary>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                dataSet_PrReq.Tables[0].Clear();
                dataSet_PrReq.Tables[1].Clear();
                prReqDAO.QueryPrReqHead(dataSet_PrReq.Tables[0], "", "", "", "", 0, "", textPrReqNo.Text, false);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--查询按钮事件错误。", ex);
            }
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewPrReqHead_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewPrReqList_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        /// <summary>
        /// 设定列表显示信息
        /// </summary>
        private void gridViewPrReqHead_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "ReqState")
            {
                if (e.Value.ToString() == "1")
                    e.DisplayText = "待审核";
                else if (e.Value.ToString() == "2")
                    e.DisplayText = "审核";
                else
                    e.DisplayText = "关闭";
            }
        }

        /// <summary>
        /// 主表聚焦行改变事件
        /// </summary>
        private void gridViewPrReqHead_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            try
            {
                if (gridViewPrReqHead.GetFocusedDataRow() != null)
                {
                    if (DataTypeConvert.GetString(gridViewPrReqHead.GetFocusedDataRow()["PrReqNo"]) != "")
                    {
                        dataSet_PrReq.Tables[1].Clear();
                        prReqDAO.QueryPrReqList(dataSet_PrReq.Tables[1], DataTypeConvert.GetString(gridViewPrReqHead.GetFocusedDataRow()["PrReqNo"]));
                        for (int i = 0; i < dataSet_PrReq.Tables[1].Rows.Count; i++)
                        {
                            DataRow dr = dataSet_PrReq.Tables[1].Rows[i];
                            string selectStr = string.Format("AutoId={0} and PrReqNo='{1}'", DataTypeConvert.GetString(dr["AutoId"]), DataTypeConvert.GetString(dr["PrReqNo"]));
                            if (prReqListTable.Select(selectStr).Length > 0)
                            {
                                dataSet_PrReq.Tables[1].Rows[i]["ListSelect"] = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--主表聚焦行改变事件错误。", ex);
            }
        }

        /// <summary>
        /// 设定主表当前行选择事件
        /// </summary>
        private void repCheckSelect_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (DataTypeConvert.GetBoolean(gridViewPrReqHead.GetFocusedDataRow()["Select"]))
                {
                    gridViewPrReqHead.GetFocusedDataRow()["Select"] = false;


                }
                else
                {
                    gridViewPrReqHead.GetFocusedDataRow()["Select"] = true;
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--设定主表当前行选择事件错误。", ex);
            }
        }

        /// <summary>
        /// 设定子表当前行选择事件
        /// </summary>
        private void repCheckListSelect_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (DataTypeConvert.GetBoolean(gridViewPrReqList.GetFocusedDataRow()["ListSelect"]))
                {
                    gridViewPrReqList.GetFocusedDataRow()["ListSelect"] = false;
                    string selectStr = string.Format("AutoId={0} and PrReqNo='{1}'", DataTypeConvert.GetString(gridViewPrReqList.GetFocusedDataRow()["AutoId"]), DataTypeConvert.GetString(gridViewPrReqList.GetFocusedDataRow()["PrReqNo"]));
                    DataRow[] drs = prReqListTable.Select(selectStr);
                    if (drs.Length > 0)
                    {
                        prReqListTable.Rows.Remove(drs[0]);
                    }
                }
                else
                {
                    gridViewPrReqList.GetFocusedDataRow()["ListSelect"] = true;
                    prReqListTable.ImportRow(gridViewPrReqList.GetFocusedDataRow());
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--设定子表当前行选择事件错误。", ex);
            }
        }


    }
}
