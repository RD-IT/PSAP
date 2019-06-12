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
        static PSAP.VIEW.BSVIEW.FrmLanguageText f = new VIEW.BSVIEW.FrmLanguageText();
        
        public FrmPayType()
        {
            InitializeComponent();
            PSAP.BLL.BSBLL.BSBLL.language(f);
            PSAP.BLL.BSBLL.BSBLL.language(this);
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
                    editForm.ButtonList.Add(btnPayTypeList);
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
            if (textPayTypeNo.Text.Trim() == "")
            {
                MessageHandler.ShowMessageBox(tsmiFklxbnwk.Text );// ("付款类型不能为空，请重新操作。");
                textPayTypeNo.Focus();
                return false;
            }
            if (textPayTypeNoText.Text.Trim() == "")
            {
                MessageHandler.ShowMessageBox(tsmiFksmbnwk.Text );// ("付款说明不能为空，请重新操作。");
                textPayTypeNoText.Focus();
                return false;
            }

            return true;
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
                MessageHandler.ShowMessageBox(f.tsmiQxbchzjx.Text);// ("请先保存后再进行其他操作。");
            }
        }
    }
}
