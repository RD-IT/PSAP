using PSAP.DAO.BSDAO;
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
    public partial class FrmProjectList : DockContent
    {
        FrmCommonDAO commonDAO = new FrmCommonDAO();
        FrmBaseEdit editForm = null;

        public FrmProjectList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmProjectList_Load(object sender, EventArgs e)
        {
            try
            {
                searchLookUpBussinessBaseNo.Properties.DataSource = commonDAO.QueryBussinessBaseInfo(false);

                if (editForm == null)
                {
                    editForm = new FrmBaseEdit();
                    editForm.FormBorderStyle = FormBorderStyle.None;
                    editForm.TopLevel = false;
                    editForm.TableName = "BS_ProjectList";
                    editForm.TableCaption = "项目号";
                    editForm.Sql = "select BS_ProjectList.*, BS_BussinessBaseInfo.BussinessBaseText from BS_ProjectList left join BS_BussinessBaseInfo on BS_ProjectList.BussinessBaseNo=BS_BussinessBaseInfo.BussinessBaseNo order by BS_ProjectList.AutoId";
                    editForm.PrimaryKeyColumn = "ProjectNo";
                    editForm.MasterDataSet = dSProjectList;
                    editForm.MasterBindingSource = bSProjectList;
                    editForm.MasterEditPanel = pnlEdit;
                    editForm.PrimaryKeyControl = textProjectNo;
                    editForm.OtherNoChangeControl = new List<Control>() { textProjectName };
                    editForm.BrowseXtraGridView = gridViewProjectList;
                    editForm.CheckControl += CheckControl;
                    editForm.ButtonList.Add(btnStnList);
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
            if (textProjectNo.Text.Trim() == "")
            {
                MessageHandler.ShowMessageBox("项目号编号不能为空，请重新操作。");
                textProjectNo.Focus();
                return false;
            }
            if (searchLookUpBussinessBaseNo.Text.Trim() == "")
            {
                MessageHandler.ShowMessageBox("客户不能为空，请重新操作。");
                searchLookUpBussinessBaseNo.Focus();
                return false;
            }
            if (textProjectName.Text.Trim() == "")
            {
                MessageHandler.ShowMessageBox("项目名称不能为空，请重新操作。");
                textProjectName.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewProjectList_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        /// <summary>
        /// 设定站号信息
        /// </summary>
        private void btnStnList_Click(object sender, EventArgs e)
        {
            try
            {
                //string projectNoStr = DataTypeConvert.GetString(gridViewProjectList.GetFocusedDataRow()["ProjectNo"]);
                //FrmStnList.projectNoStr = projectNoStr;
                //ViewHandler.ShowRightWindow("FrmStnList");
                if (!editForm.EditState)
                {
                    DataRow dr = gridViewProjectList.GetFocusedDataRow();
                    if (dr != null)
                    {
                        FrmStnList stnList = new FrmStnList(DataTypeConvert.GetString(dr["ProjectNo"]), DataTypeConvert.GetString(dr["ProjectName"]));
                        stnList.ShowDialog();
                    }
                }
                else
                {
                    MessageHandler.ShowMessageBox("请先保存后再进行其他操作。");
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--设定站号信息事件错误。", ex);
            }
        }
    }
}
