using PSAP.DAO.BSDAO;
using PSAP.DAO.INVDAO;
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
    public partial class FrmOrderApply : DockContent
    {
        FrmOrderApplyDAO orderApplyDAO = new FrmOrderApplyDAO();
        FrmCommonDAO commonDAO = new FrmCommonDAO();
        static PSAP.VIEW.BSVIEW.FrmLanguageText f = new VIEW.BSVIEW.FrmLanguageText();

        public FrmOrderApply()
        {
            InitializeComponent();
            PSAP.BLL.BSBLL.BSBLL.language(f);
            PSAP.BLL.BSBLL.BSBLL.language(this);

        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmOrderApply_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime nowDate = BaseSQL.GetServerDateTime();
                dateOrderDateBegin.DateTime = nowDate.Date.AddDays(-SystemInfo.OrderQueryDate_DefaultDays);
                dateOrderDateEnd.DateTime = nowDate.Date;
                checkOrderDate.Checked = false;

                lookUpReqDep.Properties.DataSource = commonDAO.QueryDepartment(true);
                lookUpReqDep.ItemIndex = 0;
                lookUpPurCategory.Properties.DataSource = commonDAO.QueryPurCategory(true);
                lookUpPurCategory.ItemIndex = 0;
                lookUpPrepared.Properties.DataSource = commonDAO.QueryUserInfo(true);
                lookUpPrepared.ItemIndex = 0;
                searchLookUpProjectNo.Properties.DataSource = commonDAO.QueryProjectList(true);
                searchLookUpProjectNo.Text = "全部";
                searchLookUpBussinessBaseNo.Properties.DataSource = commonDAO.QueryBussinessBaseInfo(true);
                searchLookUpBussinessBaseNo.Text = "全部";

                repLookUpReqDep.DataSource = commonDAO.QueryDepartment(false);
                repLookUpPurCategory.DataSource = commonDAO.QueryPurCategory(false);
                repSearchBussinessBaseNo.DataSource = commonDAO.QueryBussinessBaseInfo(false);
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiCtjzsjcw.Text, ex);
            }
        }

        /// <summary>
        /// 查询按钮事件
        /// </summary>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                string orderHeadNoStr = textOrderHeadNo.Text.Trim();
                string orderDateBeginStr = "";
                string orderDateEndStr = "";
                if (checkOrderDate.Checked)
                {
                    if (dateOrderDateBegin.EditValue == null || dateOrderDateEnd.EditValue == null)
                    {
                        MessageHandler.ShowMessageBox(f.tsmiDgrqbnwkcx.Text);// ("订购日期不能为空，请设置后重新进行查询。");
                        if (dateOrderDateBegin.EditValue == null)
                            dateOrderDateBegin.Focus();
                        else
                            dateOrderDateEnd.Focus();
                        return;
                    }
                    orderDateBeginStr = dateOrderDateBegin.DateTime.ToString("yyyy-MM-dd");
                    orderDateEndStr = dateOrderDateEnd.DateTime.AddDays(1).ToString("yyyy-MM-dd");
                }
                string reqDepStr = lookUpReqDep.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpReqDep.EditValue) : "";
                string purCategoryStr = lookUpPurCategory.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpPurCategory.EditValue) : "";
                string empNameStr = lookUpPrepared.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpPrepared.EditValue) : "";
                string projectNoStr = searchLookUpProjectNo.Text != "全部" ? DataTypeConvert.GetString(searchLookUpProjectNo.EditValue) : "";
                string bussinessBaseNoStr = DataTypeConvert.GetString(searchLookUpBussinessBaseNo.EditValue) != "全部" ? DataTypeConvert.GetString(searchLookUpBussinessBaseNo.EditValue) : "";
                string commonStr = textCommon.Text.Trim();

                dataSet_Order.Tables[0].Clear();
                dataSet_Order.Tables[1].Clear();
                orderApplyDAO.QueryOrderHead(dataSet_Order.Tables[0], orderHeadNoStr, orderDateBeginStr, orderDateEndStr, reqDepStr, purCategoryStr, empNameStr, projectNoStr, bussinessBaseNoStr, commonStr);
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--查询按钮事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiCxansjcw.Text, ex);
            }
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewOrderHead_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        /// <summary>
        /// 设定列表显示信息
        /// </summary>
        private void gridViewOrderHead_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "ReqState")
            {
                e.DisplayText = CommonHandler.Get_OrderState_Desc(e.Value.ToString());
            }
        }

        /// <summary>
        /// 主表聚焦行改变事件
        /// </summary>
        private void gridViewOrderHead_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (gridViewOrderHead.GetFocusedDataRow() != null)
                {
                    if (DataTypeConvert.GetString(gridViewOrderHead.GetFocusedDataRow()["OrderHeadNo"]) != "")
                    {
                        dataSet_Order.Tables[1].Clear();
                        orderApplyDAO.QueryOrderList(dataSet_Order.Tables[1], DataTypeConvert.GetString(gridViewOrderHead.GetFocusedDataRow()["OrderHeadNo"]));
                    }
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--主表聚焦行改变事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiZbjjhgb.Text, ex);
            }
        }

        /// <summary>
        /// 设定子表当前行选择事件
        /// </summary>
        private void repCheckListSelect_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (DataTypeConvert.GetBoolean(gridViewOrderList.GetFocusedDataRow()["ListSelect"]))
                {
                    gridViewOrderList.GetFocusedDataRow()["ListSelect"] = false;
                }
                else
                {
                    gridViewOrderList.GetFocusedDataRow()["ListSelect"] = true;
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--设定子表当前行选择事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiSdzbdqhxzsjcw.Text, ex);
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
            foreach (DataRow dr in dataSet_Order.Tables[1].Rows)
            {
                dr["ListSelect"] = value;
            }
        }

        /// <summary>
        /// 选择请购日期
        /// </summary>
        private void checkOrderDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkOrderDate.Checked)
            {
                dateOrderDateBegin.Enabled = true;
                dateOrderDateEnd.Enabled = true;
            }
            else
            {
                dateOrderDateBegin.Enabled = false;
                dateOrderDateEnd.Enabled = false;
            }
        }

        /// <summary>
        /// 确认按钮事件
        /// </summary>
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridViewOrderHead.GetFocusedDataRow() == null)
                {
                    MessageHandler.ShowMessageBox(tsmiQxzysydygcgd.Text);// ("请选择要适用的一个采购单，请重新操作。");
                    textOrderHeadNo.Focus();
                    return;
                }
                int count = dataSet_Order.Tables[1].Select("ListSelect=1").Length;
                if (count == 0)
                {
                    MessageHandler.ShowMessageBox(tsmiQxzysydcgddmxjl.Text);// ("请选择要适用的采购订单明细记录，请重新操作。");
                    gridViewOrderList.Focus();
                    return;
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--确认按钮事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiQransjcw.Text, ex);
            }
        }

        /// <summary>
        /// 双击选中
        /// </summary>
        private void gridViewOrderList_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (e.Clicks == 2)
                {
                    if (DataTypeConvert.GetBoolean(gridViewOrderList.GetFocusedDataRow()["ListSelect"]))
                    {
                        gridViewOrderList.GetFocusedDataRow()["ListSelect"] = false;
                    }
                    else
                    {
                        gridViewOrderList.GetFocusedDataRow()["ListSelect"] = true;
                    }
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--双击选中错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiSjxzcw.Text, ex);
            }
        }
    }
}
