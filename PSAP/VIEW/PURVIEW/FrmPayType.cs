using DevExpress.XtraEditors;
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
    public partial class FrmPayType : DockContent
    {
        FrmBaseEdit editForm = null;

        public FrmPayType()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmPayType_Load(object sender, EventArgs e)
        {
            try
            {
                if (editForm == null)
                {
                    editForm = new FrmBaseEdit();
                    editForm.FormBorderStyle = FormBorderStyle.None;
                    editForm.TopLevel = false;
                    editForm.TableName = "PUR_PayType";
                    editForm.TableCaption = "付款类型";
                    editForm.Sql = "select * from PUR_PayType Order by AutoId";
                    editForm.PrimaryKeyColumn = "PayTypeNo";
                    editForm.MasterDataSet = dSPayType;
                    editForm.MasterBindingSource = bSPayType;
                    editForm.MasterEditPanel = pnlEdit;
                    editForm.PrimaryKeyControl = textPayTypeNo;
                    editForm.BrowseXtraGridView = gridViewPayType;
                    editForm.CheckControl += CheckControl;
                    this.pnlToolBar.Controls.Add(editForm);
                    editForm.Dock = DockStyle.Fill;
                    editForm.Show();
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
            if (textPayTypeNo.Text.Trim() == "")
            {
                MessageHandler.ShowMessageBox("付款类型不能为空，请重新操作。");
                textPayTypeNo.Focus();
                return false;
            }
            if (textPayTypeNoText.Text.Trim() == "")
            {
                MessageHandler.ShowMessageBox("付款说明不能为空，请重新操作。");
                textPayTypeNoText.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewPayType_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        /// <summary>
        /// 设定付款类型信息
        /// </summary>
        private void btnPayTypeList_Click(object sender, EventArgs e)
        {
            if (!editForm.EditState)
            {
                DataRow dr = gridViewPayType.GetFocusedDataRow();
                FrmPayTypeList ptList = new FrmPayTypeList(DataTypeConvert.GetString(dr["PayTypeNo"]), DataTypeConvert.GetString(dr["PayTypeNoText"]));
                ptList.ShowDialog();
            }
            else
            {
                MessageHandler.ShowMessageBox("请先保存后再进行其他操作。");
            }
        }
    }
}
