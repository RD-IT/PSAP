using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using PSAP.DAO.INVDAO;
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
    public partial class FrmWarehouseWarrantType : DockContent
    {
        FrmBaseEdit editForm = null;
        FrmWarehouseWarrantDAO wwDAO = new FrmWarehouseWarrantDAO();
            static PSAP.VIEW.BSVIEW.FrmLanguageText f = new VIEW.BSVIEW.FrmLanguageText();

        public FrmWarehouseWarrantType()
        {
            InitializeComponent();
            PSAP.BLL.BSBLL.BSBLL.language(f);
            PSAP.BLL.BSBLL.BSBLL.language(this);
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmWarehouseWarrantType_Load(object sender, EventArgs e)
        {
            try
            {
                if (editForm == null)
                {
                    editForm = new FrmBaseEdit();
                    editForm.FormBorderStyle = FormBorderStyle.None;
                    editForm.TopLevel = false;
                    editForm.TableName = "BS_WarehouseWarrantType";
                    editForm.TableCaption = "入库类别";
                    editForm.Sql = "select * from BS_WarehouseWarrantType Order by AutoId";
                    editForm.PrimaryKeyColumn = "WarehouseWarrantTypeNo";
                    editForm.MasterDataSet = dSWarehouseWarrantType;
                    editForm.MasterBindingSource = bSWarehouseWarrantType;
                    editForm.MasterEditPanel = pnlEdit;
                    editForm.PrimaryKeyControl = textWarehouseWarrantTypeNo;
                    editForm.BrowseXtraGridView = gridViewWarehouseWarrantType;
                    editForm.CheckControl += CheckControl;
                    editForm.SaveRowBefore += SaveRowBefore_Handle;
                    editForm.ButtonList.Add(btnSetDefault);
                    this.pnlToolBar.Controls.Add(editForm);
                    editForm.Dock = DockStyle.Fill;
                    editForm.Show();
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+f.tsmiCtjzsjcw.Text , ex);
            }
        }

        /// <summary>
        /// 保存之前的回调方法
        /// </summary>
        public bool CheckControl()
        {
            if (textWarehouseWarrantTypeNo.Text.Trim() == "")
            {
                MessageHandler.ShowMessageBox(tsmiRklbbhbnwkqcxcz.Text );// ("入库类别编号不能为空，请重新操作。");
                textWarehouseWarrantTypeNo.Focus();
                return false;
            }
            if (textWarehouseWarrantTypeName.Text.Trim() == "")
            {
                MessageHandler.ShowMessageBox(tsmiRklbmcbnwkqcxcz.Text );// ("入库类别名称不能为空，请重新操作。");
                textWarehouseWarrantTypeName.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// 保存之前进行的判断
        /// </summary>
        public bool SaveRowBefore_Handle(DataRow dr, SqlCommand cmd)
        {
            int count = wwDAO.Get_WarehouseType_DefaultCount(cmd, "BS_WarehouseWarrantType");
            if (count == 0)
                dr["IsDefault"] = true;
            return true;
        }

        /// <summary>
        /// 设定默认值
        /// </summary>
        private void TableWarehouseWarrantType_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            e.Row["IsDefault"] = false;
        }

        /// <summary>
        /// 设定默认类型
        /// </summary>
        private void btnSetDefault_Click(object sender, EventArgs e)
        {
            try
            {
                if (!editForm.EditState)
                {
                    DataRow dr = gridViewWarehouseWarrantType.GetFocusedDataRow();
                    if (dr != null)
                    {
                        if (wwDAO.Update_WarehouseType_Default(DataTypeConvert.GetString(dr["WarehouseWarrantTypeNo"]), "BS_WarehouseWarrantType", "WarehouseWarrantTypeNo", "入库类别"))
                        {
                            MessageHandler.ShowMessageBox(tsmiSdmrrklbcg.Text );// ("设定默认入库类别成功。");
                            editForm.btnRefresh_Click(null, null);
                        }
                    }
                }
                else
                {
                    MessageHandler.ShowMessageBox(f.tsmiQxbchzjx.Text );// ("请先保存后再进行其他操作。");
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--设定默认类型事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+f.tsmiSdmrlxsjcw.Text , ex);
            }
        }
    }
}
