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
                dateReqDateBegin.DateTime = DateTime.Now.Date.AddDays(-7);
                dateReqDateEnd.DateTime = DateTime.Now.Date;
                checkReqDate.Checked = false;

                lookUpReqDep.Properties.DataSource = prReqDAO.QueryDepartment(true);
                lookUpReqDep.ItemIndex = 0;
                lookUpPurCategory.Properties.DataSource = prReqDAO.QueryPurCategory(true);
                lookUpPurCategory.ItemIndex = 0;
                lookUpApplicant.Properties.DataSource = prReqDAO.QueryUserInfo();
                lookUpApplicant.ItemIndex = 0;
                searchLookUpProjectNo.Properties.DataSource = prReqDAO.QueryProjectList(true);
                searchLookUpProjectNo.Text = "全部";

                repLookUpReqDep.DataSource = prReqDAO.QueryDepartment(false);
                repLookUpPurCategory.DataSource = prReqDAO.QueryPurCategory(false);
                repSearchProjectNo.DataSource = prReqDAO.QueryProjectList(false);
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
                string prReqNoStr = textPrReqNo.Text.Trim();
                string orderDateBeginStr = "";
                string orderDateEndStr = "";
                if (checkReqDate.Checked)
                {
                    orderDateBeginStr = dateReqDateBegin.DateTime.ToString("yyyy-MM-dd");
                    orderDateEndStr = dateReqDateEnd.DateTime.ToString("yyyy-MM-dd");
                }
                string reqDepStr = lookUpReqDep.ItemIndex > 0 ? lookUpReqDep.EditValue.ToString() : "";
                string purCategoryStr = lookUpPurCategory.ItemIndex > 0 ? lookUpPurCategory.EditValue.ToString() : "";
                string empNameStr = lookUpApplicant.ItemIndex > 0 ? lookUpApplicant.EditValue.ToString() : "";
                string projectNoStr = searchLookUpProjectNo.Text != "全部" ? searchLookUpProjectNo.EditValue.ToString() : "";
                string commonStr = textCommon.Text.Trim();

                dataSet_PrReq.Tables[0].Clear();
                dataSet_PrReq.Tables[1].Clear();
                applyDAO.QueryPrReqHead(dataSet_PrReq.Tables[0], prReqNoStr, orderDateBeginStr, orderDateEndStr, reqDepStr, purCategoryStr, empNameStr, projectNoStr, commonStr);
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
        /// 确定行号
        /// </summary>
        private void searchLookUpProjectNoView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0 && e.Info.IsRowIndicator)
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
                        applyDAO.QueryPrReqList(dataSet_PrReq.Tables[1], DataTypeConvert.GetString(gridViewPrReqHead.GetFocusedDataRow()["PrReqNo"]));                        
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--主表聚焦行改变事件错误。", ex);
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
                }
                else
                {
                    gridViewPrReqList.GetFocusedDataRow()["ListSelect"] = true;
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--设定子表当前行选择事件错误。", ex);
            }
        }

        /// <summary>
        /// 确认按钮事件
        /// </summary>
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridViewPrReqHead.GetFocusedDataRow()==null)
                {
                    MessageHandler.ShowMessageBox("请选择要适用的一个请购单，请重新操作。");
                    textPrReqNo.Focus();
                    return;
                }
                int count = dataSet_PrReq.Tables[1].Select("ListSelect=1").Length;
                if (count == 0)
                {
                    MessageHandler.ShowMessageBox("请选择要适用的请购单明细记录，请重新操作。");
                    gridViewPrReqList.Focus();
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

        /// <summary>
        /// 全部选中
        /// </summary>
        private void checkAll_CheckedChanged(object sender, EventArgs e)
        {
            bool value = false;
            if(checkAll.Checked)
            {
                value = true;
            }
            foreach(DataRow dr in dataSet_PrReq.Tables[1].Rows)
            {
                dr["ListSelect"] = value;
            }
        }

        /// <summary>
        /// 选择请购日期
        /// </summary>
        private void checkReqDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkReqDate.Checked)
            {
                dateReqDateBegin.Enabled = true;
                dateReqDateEnd.Enabled = true;
            }
            else
            {
                dateReqDateBegin.Enabled = false;
                dateReqDateEnd.Enabled = false;
            }
        }


    }
}
