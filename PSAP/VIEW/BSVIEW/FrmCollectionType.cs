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
    public partial class FrmCollectionType : DockContent
    {
        FrmBaseEdit editForm = null;
        static PSAP.VIEW.BSVIEW.FrmLanguageText f = new VIEW.BSVIEW.FrmLanguageText();

        public FrmCollectionType()
        {
            InitializeComponent();
            PSAP.BLL.BSBLL.BSBLL.language(f);
            PSAP.BLL.BSBLL.BSBLL.language(this);
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmCollectionType_Load(object sender, EventArgs e)
        {
            try
            {
                if (editForm == null)
                {
                    editForm = new FrmBaseEdit();
                    editForm.FormBorderStyle = FormBorderStyle.None;
                    editForm.TopLevel = false;
                    editForm.TableName = "BS_CollectionType";
                    editForm.TableCaption = "收款类型";
                    editForm.Sql = "select * from BS_CollectionType Order by AutoId";
                    editForm.PrimaryKeyColumn = "CollectionTypeNo";
                    editForm.MasterDataSet = dSCollectionType;
                    editForm.MasterBindingSource = bSCollectionType;
                    editForm.MasterEditPanel = pnlEdit;
                    editForm.PrimaryKeyControl = textCollectionTypeNo;
                    editForm.BrowseXtraGridView = gridViewCollectionType;
                    editForm.CheckControl += CheckControl;
                    editForm.ButtonList.Add(btnCollectionTypeList);
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
            if (textCollectionTypeNo.Text.Trim() == "")
            {
                MessageHandler.ShowMessageBox(tsmiSklx.Text);// ("收款类型不能为空，请重新操作。");
                textCollectionTypeNo.Focus();
                return false;
            }
            if (textCollectionTypeNoText.Text.Trim() == "")
            {
                MessageHandler.ShowMessageBox(tsmiSksm.Text);// ("收款说明不能为空，请重新操作。");
                textCollectionTypeNoText.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewCollectionType_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        /// <summary>
        /// 设定收款类型信息
        /// </summary>
        private void btnCollectionTypeList_Click(object sender, EventArgs e)
        {
            if (!editForm.EditState)
            {
                DataRow dr = gridViewCollectionType.GetFocusedDataRow();
                FrmCollectionTypeList ctList = new FrmCollectionTypeList(DataTypeConvert.GetString(dr["CollectionTypeNo"]), DataTypeConvert.GetString(dr["CollectionTypeNoText"]));
                ctList.ShowDialog();
            }
            else
            {
                MessageHandler.ShowMessageBox(f.tsmiQxbchzjx.Text);// ("请先保存后再进行其他操作。");
            }
        }
    }
}
