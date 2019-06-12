using PSAP.BLL.BSBLL;
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
        FrmStnList stnList = null;
        static PSAP.VIEW.BSVIEW.FrmLanguageText f = new VIEW.BSVIEW.FrmLanguageText();

        public FrmProjectList()
        {
            InitializeComponent();
            PSAP.BLL.BSBLL.BSBLL.language(f);
            PSAP.BLL.BSBLL.BSBLL.language(this);
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

                    stnList = new FrmStnList("", "");
                    stnList.Show(this.dockPanelStn);
                    stnList.Dock = DockStyle.Fill;
                    stnList.TopLevel = false;
                    stnList.FormBorderStyle = FormBorderStyle.None;

                    this.dockPanelStn.Text = stnList.Text;
                    this.dockPanelStn.TabText = stnList.Text;
                    this.dockPanelStn.Controls.Add(stnList);
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
            if (textProjectNo.Text.Trim() == "")
            {
                MessageHandler.ShowMessageBox(tsmiXmbh.Text);// ("项目号编号不能为空，请重新操作。");
                textProjectNo.Focus();
                return false;
            }
            if (searchLookUpBussinessBaseNo.Text.Trim() == "")
            {
                MessageHandler.ShowMessageBox(tsmiKhbnwk.Text);// ("客户不能为空，请重新操作。");
                searchLookUpBussinessBaseNo.Focus();
                return false;
            }
            if (textProjectName.Text.Trim() == "")
            {
                MessageHandler.ShowMessageBox(tsmiXmmcbnwk.Text);// ("项目名称不能为空，请重新操作。");
                textProjectName.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void searchLookUpBussinessBaseNoView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            ControlHandler.GridView_CustomDrawRowIndicator(e);
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
                    MessageHandler.ShowMessageBox(f.tsmiQxbchzjx.Text);// ("请先保存后再进行其他操作。");
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--设定站号信息事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiSdzhxxsjcw.Text, ex);
            }
        }

        /// <summary>
        /// 当前项目号聚焦的事件
        /// </summary>
        private void gridViewProjectList_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (!editForm.EditState)
                {
                    DataRow dr = gridViewProjectList.GetFocusedDataRow();
                    if (dr != null)
                    {
                        stnList.RefreshCurrentStnInfo(DataTypeConvert.GetString(dr["ProjectNo"]), DataTypeConvert.GetString(dr["ProjectName"]));
                        this.dockPanelStn.Text = stnList.Text;
                        this.dockPanelStn.TabText = stnList.Text;
                        this.dockPanelStn.Controls.Add(stnList);
                    }
                }
                else
                {
                    MessageHandler.ShowMessageBox(f.tsmiQxbchzjx.Text);// ("请先保存后再进行其他操作。");
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--当前项目号聚焦的事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiDqxmhjjdsjcw.Text, ex);
            }
        }
    }
}
