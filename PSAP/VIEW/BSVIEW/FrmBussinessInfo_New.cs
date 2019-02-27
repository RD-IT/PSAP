using PSAP.DAO.BSDAO;
using PSAP.PSAPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PSAP.VIEW.BSVIEW
{
    public partial class FrmBussinessInfo_New : DockContent
    {
        FrmBaseEdit editForm = null;
        FrmCommonDAO commonDAO = new FrmCommonDAO();
        FrmBussinessInfoDAO bussDAO = new FrmBussinessInfoDAO();

        public FrmBussinessInfo_New()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmBussinessInfo_New_Load(object sender, EventArgs e)
        {
            try
            {
                if (editForm == null)
                {
                    editForm = new FrmBaseEdit();
                    editForm.FormBorderStyle = FormBorderStyle.None;
                    editForm.TopLevel = false;
                    editForm.TableName = "BS_BussinessBaseInfo";
                    editForm.TableCaption = "往来方信息";
                    editForm.Sql = "select BS_BussinessBaseInfo.*, BS_BussinessCategory.BussinessCategoryText from BS_BussinessBaseInfo left join BS_BussinessCategory on BS_BussinessBaseInfo.BussinessCategory = BS_BussinessCategory.BussinessCategory Order by BS_BussinessBaseInfo.AutoId";
                    editForm.PrimaryKeyColumn = "BussinessBaseNo";
                    editForm.MasterDataSet = dSBussiness;
                    editForm.MasterBindingSource = bSBaseInfo;
                    editForm.MasterEditPanel = pnlEdit;
                    editForm.PrimaryKeyControl = textBussinessBaseNo;
                    editForm.BrowseXtraGridView = gridViewBaseInfo;
                    editForm.RowStateUnchangedIsSave = true;
                    editForm.MasterEditPanelAddControl = new List<Control>() { textContact, textCompanyLR, textCompanyAddress, textZipCode, textPhoneNo, textFaxNo, textE_mail, textWebSite, lookUpCountryCode, textBussinessLicense, textBankAccout, textBankAddress };
                    editForm.CheckControl += CheckControl;                    
                    editForm.NewAfter += NewAfter;
                    editForm.SaveRowAfter += SaveRowAfter;
                    editForm.CancelAfter += QueryDataAfter;
                    editForm.QueryDataAfter += QueryDataAfter;
                    editForm.DeleteRowBefore += DeleteRowBefore;
                    this.pnlToolBar.Controls.Add(editForm);
                    editForm.Dock = DockStyle.Fill;
                    editForm.Show();

                    lookUpBussinessCategory.Properties.DataSource = bussDAO.QueryBussinessCategory(false);
                    lookUpCountryCode.Properties.DataSource = bussDAO.QueryCountryCode(false);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
            }
        }

        /// <summary>
        /// 保存之前的回调方法
        /// </summary>
        public bool CheckControl()
        {
            if (textBussinessBaseNo.Text.Trim() == "")
            {
                MessageHandler.ShowMessageBox("往来方编号不能为空，请重新操作。");
                textBussinessBaseNo.Focus();
                return false;
            }
            if (textBussinessBaseText.Text.Trim() == "")
            {
                MessageHandler.ShowMessageBox("往来方名称不能为空，请重新操作。");
                textBussinessBaseText.Focus();
                return false;
            }
            if (lookUpBussinessCategory.ItemIndex < 0)
            {
                MessageHandler.ShowMessageBox("往来方分类不能为空，请重新操作。");
                textBussinessBaseText.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// 新增之后进行的操作
        /// </summary>
        public void NewAfter()
        {
            dSBussiness.Tables[1].Rows.Clear();
            DataRow detailDR = dSBussiness.Tables[1].NewRow();
            dSBussiness.Tables[1].Rows.Add(detailDR);
            bSDetailInfo.MoveLast();

            dSBussiness.Tables[2].Rows.Clear();
            DataRow financialDR = dSBussiness.Tables[2].NewRow();
            dSBussiness.Tables[2].Rows.Add(financialDR);
            bSFinancialInfo.MoveLast();
        }

        /// <summary>
        /// 保存之前进行密码检测
        /// </summary>
        public bool SaveRowAfter(DataRow dr, SqlCommand cmd)
        {
            bSDetailInfo.EndEdit();
            bSFinancialInfo.EndEdit();
            for (int i = 0; i < dSBussiness.Tables[1].Rows.Count; i++)
            {
                if (dSBussiness.Tables[1].Rows[i].RowState == DataRowState.Added)
                    dSBussiness.Tables[1].Rows[i]["BussinessBaseNo"] = dr["BussinessBaseNo"];
            }
            for (int i = 0; i < dSBussiness.Tables[2].Rows.Count; i++)
            {
                if (dSBussiness.Tables[2].Rows[i].RowState == DataRowState.Added)
                    dSBussiness.Tables[2].Rows[i]["BussinessBaseNo"] = dr["BussinessBaseNo"];
            }
            bussDAO.Update_BussinessOtherInfo(cmd, dSBussiness.Tables[1], dSBussiness.Tables[2]);
            return true;
        }
        
        /// <summary>
        /// 查询往来方其他信息
        /// </summary>
        public void QueryDataAfter()
        {
            if (bSBaseInfo.Current != null)
            {
                string bussinessBaseNoStr = textBussinessBaseNo.Text;
                dSBussiness.Tables[1].Rows.Clear();
                bussDAO.QueryBussinessDetailInfo(dSBussiness.Tables[1], bussinessBaseNoStr);
                dSBussiness.Tables[2].Rows.Clear();
                bussDAO.QueryBussinessFinancialInfo(dSBussiness.Tables[2], bussinessBaseNoStr);
            }
            else
            {
                dSBussiness.Tables[1].Rows.Clear();
                dSBussiness.Tables[2].Rows.Clear();
            }
        }

        /// <summary>
        /// 删除主表之前先删除子表
        /// </summary>
        public bool DeleteRowBefore(DataRow dr, SqlCommand cmd)
        {
            bussDAO.Delete_BussinessOtherInfo(cmd, DataTypeConvert.GetString(dr["BussinessBaseNo",DataRowVersion.Original]));

            return true;
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewBaseInfo_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        /// <summary>
        /// 查询往来方其他信息
        /// </summary>
        private void gridViewBaseInfo_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (gridViewBaseInfo.GetFocusedDataRow() != null)
                {
                    QueryDataAfter();
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--查询往来方其他信息错误。", ex);
            }
        }

        /// <summary>
        /// 设置往来方基本信息默认值
        /// </summary>
        private void TableBussinessBaseInfo_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            try
            {
                e.Row["BussinessIsUse"] = true;
                DataTable tmpTable = (DataTable)lookUpBussinessCategory.Properties.DataSource;
                if (tmpTable.Rows.Count > 0)
                    e.Row["BussinessCategory"] = tmpTable.Rows[0]["BussinessCategory"];
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--设置往来方基本信息默认值错误。", ex);
            }
        }

        /// <summary>
        /// 设置往来方详细信息默认值
        /// </summary>
        private void TableBussinessDetailInfo_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            try
            {
                DataTable tmpTable = (DataTable)lookUpCountryCode.Properties.DataSource;
                if (tmpTable.Rows.Count > 0)
                    e.Row["CountryCode"] = tmpTable.Rows[0]["CountryCode"];
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--设置往来方详细信息默认值错误。", ex);
            }
        }

        private void checkBussinessIsUse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TabControlOtherInfo.SelectedTabPage = PageDetailInfo;
                textContact.Focus();
            }
        }

        private void lookUpCountryCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TabControlOtherInfo.SelectedTabPage = PageFinancialInfo;
                textBussinessLicense.Focus();
            }
        }
    }
}
