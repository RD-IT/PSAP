using PSAP.DAO.BSDAO;
using PSAP.DAO.PURDAO;
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
    public partial class FrmApprovalList : DockContent
    {
        FrmBaseEdit editForm = null;
        /// <summary>
        /// 审批类型编码
        /// </summary>
        string TypeNoStr = "";

        FrmApprovalDAO approvalDAO = new FrmApprovalDAO();
        static PSAP.VIEW.BSVIEW.FrmLanguageText f = new VIEW.BSVIEW.FrmLanguageText();

        public FrmApprovalList()
        {
            InitializeComponent();
            PSAP.BLL.BSBLL.BSBLL.language(f);
            PSAP.BLL.BSBLL.BSBLL.language(this);
        }

        public FrmApprovalList(string typeNo, string typeNoText)
        {
            InitializeComponent();
            TypeNoStr = typeNo;
            //this.Text = string.Format("审批类型【{0}】的信息设置", typeNoText);
            this.Text = string.Format(tsmiSplx.Text + "【{0}】" + tsmiDxxsz.Text, typeNoText);
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmApprovalList_Load(object sender, EventArgs e)
        {
            try
            {
                FrmCommonDAO commonDAO = new FrmCommonDAO();
                repItemLookUpTypeNo.DataSource = commonDAO.QueryApprovalType(false);
                repItemLookUpApprover.DataSource = commonDAO.QueryUserInfo(false);

                if (editForm == null)
                {
                    editForm = new FrmBaseEdit();
                    editForm.FormBorderStyle = FormBorderStyle.None;
                    editForm.TopLevel = false;
                    editForm.TableName = "PUR_ApprovalList";
                    editForm.TableCaption = "审批信息设置";
                    editForm.Sql = string.Format("select * from PUR_ApprovalList where typeNo='{0}' Order by AppSequence", TypeNoStr);
                    editForm.PrimaryKeyColumn = "AutoId";
                    editForm.MasterDataSet = dSApprovalList;
                    editForm.MasterBindingSource = bSApprovalList;
                    //editForm.MasterEditPanel = pnlEdit;
                    editForm.BrowseXtraGridView = gridViewApprovalList;
                    editForm.CheckControl += CheckControl;
                    editForm.SaveRowBefore += SaveRowBefore;
                    editForm.DeleteRowBefore += DeleteRowBefore;
                    editForm.ButtonList.Add(btnUp);
                    editForm.ButtonList.Add(btnDown);
                    editForm.DeleteAfterRefresh = true;
                    //editForm.btnSaveExcel.Visible = false;
                    editForm.VisibleSearchContrl = false;
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
            DataRow dr = gridViewApprovalList.GetFocusedDataRow();
            if (DataTypeConvert.GetString(dr["Approver"]) == "")
            {
                MessageHandler.ShowMessageBox(tsmiSprbnwkqcxcz.Text);// ("审批人不能为空，请重新操作。");
                gridCrlApprovalList.Focus();
                gridViewApprovalList.FocusedColumn = colApprover;
                return false;
            }

            DataRow[] drs = TableApprovalList.Select(string.Format("Approver={0}", DataTypeConvert.GetString(dr["Approver"])));
            if (drs.Length > 1)
            {
                MessageHandler.ShowMessageBox(tsmiBnszxmdsprqcxcz.Text);// ("不能设置相同的审批人，请重新操作。");
                gridCrlApprovalList.Focus();
                gridViewApprovalList.FocusedColumn = colApprover;
                return false;
            }
            return true;
        }

        /// <summary>
        /// 保存之前设定数据库的顺序
        /// </summary>
        public bool SaveRowBefore(DataRow dr, SqlCommand cmd)
        {
            if (dr.RowState == DataRowState.Added)
            {
                dr["AppSequence"] = approvalDAO.QueryApprovalList_MaxSequence(cmd, TypeNoStr);
            }
            if (approvalDAO.ApprovalList_SameApproverUser(cmd, TypeNoStr, DataTypeConvert.GetInt(dr["Approver"])))
            {
                MessageHandler.ShowMessageBox(tsmiBnszxmdsprqcxcz.Text);// ("不能设置相同的审批人，请重新操作。");
                gridCrlApprovalList.Focus();
                gridViewApprovalList.FocusedColumn = colApprover;
                return false;
            }

            return true;
        }

        /// <summary>
        /// 删除之后改变其他记录顺序
        /// </summary>
        public bool DeleteRowBefore(DataRow dr, SqlCommand cmd)
        {
            int seqInt = DataTypeConvert.GetInt(dr["AppSequence", DataRowVersion.Original]);
            approvalDAO.DeleteApprovalList_AddSequence(cmd, TypeNoStr, seqInt);
            return true;
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewApprovalList_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        /// <summary>
        /// 设定默认值
        /// </summary>
        private void TableApprovalList_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            try
            {
                e.Row["TypeNo"] = TypeNoStr;
                int seqInt = DataTypeConvert.GetInt(TableApprovalList.Compute("Max(AppSequence)", ""));
                e.Row["AppSequence"] = seqInt + 1;
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--设定默认值事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiSdmrzsjcw.Text, ex);
            }
        }

        /// <summary>
        /// 上移审批信息
        /// </summary>
        private void btnUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (!editForm.EditState)
                {
                    DataRow dr = gridViewApprovalList.GetFocusedDataRow();
                    if (dr != null)
                    {
                        int appSeqInt = DataTypeConvert.GetInt(dr["AppSequence"]);
                        if (appSeqInt == 1)
                            return;
                        approvalDAO.ApprovalList_UpSequence(TypeNoStr, appSeqInt);
                        int autoIdInt = DataTypeConvert.GetInt(dr["AutoId"]);
                        editForm.btnRefresh_Click(null, null);
                        for (int i = 0; i < gridViewApprovalList.DataRowCount; i++)
                        {
                            if (autoIdInt == DataTypeConvert.GetInt(gridViewApprovalList.GetDataRow(i)["AutoId"]))
                            {
                                gridViewApprovalList.FocusedRowHandle = i;
                            }
                        }
                    }
                }
                else
                {
                    MessageHandler.ShowMessageBox(f.tsmiQxbchzjx.Text);// ("请先保存后再进行其他操作。");
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--上移审批信息事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiSyspxxsjcw.Text, ex);
            }
        }

        /// <summary>
        /// 下移审批信息
        /// </summary>
        private void btnDown_Click(object sender, EventArgs e)
        {
            try
            {
                if (!editForm.EditState)
                {
                    DataRow dr = gridViewApprovalList.GetFocusedDataRow();
                    if (dr != null)
                    {
                        int appSeqInt = DataTypeConvert.GetInt(dr["AppSequence"]);
                        if (appSeqInt == gridViewApprovalList.DataRowCount)
                            return;

                        approvalDAO.ApprovalList_DownSequence(TypeNoStr, appSeqInt);
                        int autoIdInt = DataTypeConvert.GetInt(dr["AutoId"]);
                        editForm.btnRefresh_Click(null, null);
                        for (int i = 0; i < gridViewApprovalList.DataRowCount; i++)
                        {
                            if (autoIdInt == DataTypeConvert.GetInt(gridViewApprovalList.GetDataRow(i)["AutoId"]))
                            {
                                gridViewApprovalList.FocusedRowHandle = i;
                            }
                        }
                    }
                }
                else
                {
                    MessageHandler.ShowMessageBox(f.tsmiQxbchzjx.Text);// ("请先保存后再进行其他操作。");
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--下移审批信息事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiXyspxxsjcw.Text, ex);
            }
        }
    }
}
