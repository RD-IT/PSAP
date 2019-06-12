using DevExpress.XtraGrid.Views.Base;
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
    public partial class FrmApprovalType : DockContent
    {
        FrmBaseEdit editForm = null;
        static PSAP.VIEW.BSVIEW.FrmLanguageText f = new VIEW.BSVIEW.FrmLanguageText();

        public FrmApprovalType()
        {
            InitializeComponent();
            PSAP.BLL.BSBLL.BSBLL.language(f);
            PSAP.BLL.BSBLL.BSBLL.language(this);
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmApprovalType_Load(object sender, EventArgs e)
        {
            try
            {
                if (editForm == null)
                {
                    editForm = new FrmBaseEdit();
                    editForm.FormBorderStyle = FormBorderStyle.None;
                    editForm.TopLevel = false;
                    editForm.TableName = "PUR_ApprovalType";
                    editForm.TableCaption = "审批类型";
                    editForm.Sql = "select * from PUR_ApprovalType Order by AutoId";
                    editForm.PrimaryKeyColumn = "TypeNo";
                    editForm.MasterDataSet = dSApprovalType;
                    editForm.MasterBindingSource = bSApprovalType;
                    editForm.MasterEditPanel = pnlEdit;
                    editForm.PrimaryKeyControl = textTypeNo;
                    editForm.BrowseXtraGridView = gridViewApprovalType;
                    editForm.CheckControl += CheckControl;
                    editForm.ButtonList.Add(btnApprovalList);
                    this.pnlToolBar.Controls.Add(editForm);
                    editForm.Dock = DockStyle.Fill;
                    editForm.Show();
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiCtjzsjcw.Text, ex);
            }
        }

        /// <summary>
        /// 保存之前的回调方法
        /// </summary>
        public bool CheckControl()
        {
            if (textTypeNo.Text.Trim() == "")
            {
                MessageHandler.ShowMessageBox(tsmiSplxbmbnwk.Text);// ("审批类型编码不能为空，请重新操作。");
                textTypeNo.Focus();
                return false;
            }
            if (textTypeNoText.Text.Trim() == "")
            {
                MessageHandler.ShowMessageBox(tsmiSplxmcbnwk.Text);// ("审批类型名称不能为空，请重新操作。");
                textTypeNoText.Focus();
                return false;
            }
            if (radioApprovalCat.SelectedIndex < 0)
            {
                MessageHandler.ShowMessageBox(tsmiSplxbxxz.Text);// ("审批类型必须选择，请重新操作。");
                radioApprovalCat.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// 设定列表显示信息
        /// </summary>
        private void gridViewApprovalType_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "ApprovalCat")
            {
                e.DisplayText = CommonHandler.Get_ApprovalCat_Desc(e.Value.ToString());
            }
        }

        /// <summary>
        /// 设定默认值
        /// </summary>
        private void TableApprovalType_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            e.Row["ApprovalCat"] = 0;
        }


        /// <summary>
        /// 设定审批信息
        /// </summary>
        private void btnApprovalList_Click(object sender, EventArgs e)
        {
            try
            {
                if (!editForm.EditState)
                {
                    DataRow dr = gridViewApprovalType.GetFocusedDataRow();
                    if (dr != null)
                    {
                        FrmApprovalList appList = new FrmApprovalList(DataTypeConvert.GetString(dr["TypeNo"]), DataTypeConvert.GetString(dr["TypeNoText"]));
                        appList.ShowDialog();
                    }
                }
                else
                {
                    MessageHandler.ShowMessageBox(f.tsmiQxbchzjx.Text);// ("请先保存后再进行其他操作。");
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--设定审批信息错误。", ex);
            }
        }
    }
}
