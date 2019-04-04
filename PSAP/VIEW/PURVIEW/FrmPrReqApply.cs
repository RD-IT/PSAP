using DevExpress.XtraGrid.Views.Base;
using PSAP.DAO.BSDAO;
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
        FrmCommonDAO commonDAO = new FrmCommonDAO();

        public FrmPrReqApply()
        {
            InitializeComponent();
            PSAP.BLL.BSBLL.BSBLL.language(this);

        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmPrReqApply_Load(object sender, EventArgs e)
        {
            try
            {
                ControlHandler.DevExpressStyle_ChangeControlLocation(checkAll.LookAndFeel.ActiveSkinName, new List<Control> { checkAll });

                DateTime nowDate = BaseSQL.GetServerDateTime();
                dateReqDateBegin.DateTime = nowDate.Date.AddDays(-SystemInfo.OrderQueryDate_DefaultDays);
                dateReqDateEnd.DateTime = nowDate.Date;
                checkReqDate.Checked = false;

                lookUpReqDep.Properties.DataSource = commonDAO.QueryDepartment(true);
                lookUpReqDep.ItemIndex = 0;
                lookUpPurCategory.Properties.DataSource = commonDAO.QueryPurCategory(true);
                lookUpPurCategory.ItemIndex = 0;
                lookUpApplicant.Properties.DataSource = commonDAO.QueryUserInfo(true);
                lookUpApplicant.ItemIndex = 0;
                searchLookUpProjectNo.Properties.DataSource = commonDAO.QueryProjectList(true);
                searchLookUpProjectNo.Text = "全部";

                repLookUpReqDep.DataSource = commonDAO.QueryDepartment(false);
                repLookUpPurCategory.DataSource = commonDAO.QueryPurCategory(false);
                repSearchProjectNo.DataSource = commonDAO.QueryProjectList(false);
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiCt.Text, ex);
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
                string reqDateBeginStr = "";
                string reqDateEndStr = "";
                if (checkReqDate.Checked)
                {
                    if (dateReqDateBegin.EditValue == null || dateReqDateEnd.EditValue == null)
                    {
                        MessageHandler.ShowMessageBox(tsmiQgrq.Text);// ("请购日期不能为空，请设置后重新进行查询。");
                        if (dateReqDateBegin.EditValue == null)
                            dateReqDateBegin.Focus();
                        else
                            dateReqDateEnd.Focus();
                        return;
                    }
                    reqDateBeginStr = dateReqDateBegin.DateTime.ToString("yyyy-MM-dd");
                    reqDateEndStr = dateReqDateEnd.DateTime.AddDays(1).ToString("yyyy-MM-dd");
                }
                string reqDepStr = lookUpReqDep.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpReqDep.EditValue) : "";
                string purCategoryStr = lookUpPurCategory.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpPurCategory.EditValue) : "";
                string empNameStr = lookUpApplicant.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpApplicant.EditValue) : "";
                string projectNoStr = searchLookUpProjectNo.Text != "全部" ? DataTypeConvert.GetString(searchLookUpProjectNo.EditValue) : "";
                string commonStr = textCommon.Text.Trim();

                dataSet_PrReq.Tables[0].Clear();
                dataSet_PrReq.Tables[1].Clear();
                applyDAO.QueryPrReqHead(dataSet_PrReq.Tables[0], prReqNoStr, reqDateBeginStr, reqDateEndStr, reqDepStr, purCategoryStr, empNameStr, projectNoStr, commonStr);
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--查询按钮事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiCxan.Text, ex);
            }
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewPrReqHead_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            ControlHandler.GridView_CustomDrawRowIndicator(e);
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void searchLookUpProjectNoView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            ControlHandler.GridView_CustomDrawRowIndicator(e);
        }

        /// <summary>
        /// 获取单元格显示的信息
        /// </summary>
        private void gridViewPrReqHead_KeyDown(object sender, KeyEventArgs e)
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
        /// 设定列表显示信息
        /// </summary>
        private void gridViewPrReqHead_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "ReqState")
            {
                e.DisplayText = CommonHandler.Get_OrderState_Desc(e.Value.ToString());
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
                //ExceptionHandler.HandleException(this.Text + "--主表聚焦行改变事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiZbjjh.Text, ex);
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
                //ExceptionHandler.HandleException(this.Text + "--设定子表当前行选择事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiSdzbdqh.Text, ex);
            }
        }

        /// <summary>
        /// 全部选中
        /// </summary>
        private void checkAll_CheckedChanged(object sender, EventArgs e)
        {
            bool value = false;
            if (checkAll.Checked)
            {
                value = true;
            }
            foreach (DataRow dr in dataSet_PrReq.Tables[1].Rows)
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

        /// <summary>
        /// 确认按钮事件
        /// </summary>
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridViewPrReqHead.GetFocusedDataRow() == null)
                {
                    MessageHandler.ShowMessageBox(tsmiQxzysydyg.Text);// ("请选择要适用的一个请购单，请重新操作。");
                    textPrReqNo.Focus();
                    return;
                }
                int count = dataSet_PrReq.Tables[1].Select("ListSelect=1").Length;
                if (count == 0)
                {
                    MessageHandler.ShowMessageBox(tsmiQxzysydqg.Text);// ("请选择要适用的请购单明细记录，请重新操作。");
                    gridViewPrReqList.Focus();
                    return;
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--确认按钮事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiQransj.Text, ex);
            }
        }

        /// <summary>
        /// 双击选中
        /// </summary>
        private void gridViewPrReqList_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (e.Clicks == 2)
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
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--双击选中错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiSjxzcw.Text, ex);
            }
        }

    }
}
