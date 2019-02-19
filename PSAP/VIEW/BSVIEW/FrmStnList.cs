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
    public partial class FrmStnList : DockContent
    {
        FrmCommonDAO commonDAO = new FrmCommonDAO();
        FrmBaseEdit editForm = null;

        /// <summary>
        /// 本地存放的项目号
        /// </summary>
        public string projectNoStr = "";

        public FrmStnList()
        {
            InitializeComponent();
        }

        public FrmStnList(string pNoStr,string pNameStr)
        {
            InitializeComponent();
            projectNoStr = pNoStr;
            this.Text = string.Format("项目【{0}】的站号信息", pNameStr);
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmStnList_Load(object sender, EventArgs e)
        {
            try
            {
                searchLookUpProjectNo.Properties.DataSource = commonDAO.QueryProjectList(false);

                if (editForm == null)
                {
                    editForm = new FrmBaseEdit();
                    editForm.FormBorderStyle = FormBorderStyle.None;
                    editForm.TopLevel = false;
                    editForm.TableName = "BS_StnList";
                    editForm.TableCaption = "站号";
                    SetEditFormSQL();
                    editForm.PrimaryKeyColumn = "AutoID";
                    editForm.MasterDataSet = dSStnList;
                    editForm.MasterBindingSource = bSStnList;
                    editForm.MasterEditPanel = pnlEdit;
                    editForm.PrimaryKeyControl = textStnNo;
                    editForm.OtherNoChangeControl = new List<Control>() { searchLookUpProjectNo };
                    editForm.BrowseXtraGridView = gridViewStnList;
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
            if (textStnNo.Text.Trim() == "")
            {
                MessageHandler.ShowMessageBox("站号不能为空，请重新操作。");
                textStnNo.Focus();
                return false;
            }
            if (searchLookUpProjectNo.Text.Trim() == "")
            {
                MessageHandler.ShowMessageBox("项目号不能为空，请重新操作。");
                searchLookUpProjectNo.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewStnList_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        /// <summary>
        /// 窗体激活事件
        /// </summary>
        private void FrmStnList_Activated(object sender, EventArgs e)
        {
            //try
            //{
            //    if (projectNoStr != "")
            //    {
            //        editForm.btnRefresh_Click(null, null);

            //        string filter = string.Format("ProjectNo='{0}'", projectNoStr);
            //        gridViewStnList.ActiveFilterString = filter;
            //        pNoStr = projectNoStr;
            //        projectNoStr = "";
            //    }
            //}
            //catch (Exception ex)
            //{
            //    ExceptionHandler.HandleException(this.Text + "--窗体激活事件错误。", ex);
            //}
        }

        /// <summary>
        /// 设定工具栏的SQL
        /// </summary>
        private void SetEditFormSQL()
        {
            //if (projectNoStr == "")
            //    editForm.Sql = "select BS_StnList.*, BS_ProjectList.ProjectName from BS_StnList left join BS_ProjectList on BS_StnList.ProjectNo=BS_ProjectList.ProjectNo order by BS_StnList.AutoId";
            //else
            //    editForm.Sql = string.Format("select BS_StnList.*, BS_ProjectList.ProjectName from BS_StnList left join BS_ProjectList on BS_StnList.ProjectNo=BS_ProjectList.ProjectNo where BS_StnList.ProjectNo='{0}' order by BS_StnList.AutoId", projectNoStr);

            editForm.Sql = string.Format("select BS_StnList.*, BS_ProjectList.ProjectName from BS_StnList left join BS_ProjectList on BS_StnList.ProjectNo=BS_ProjectList.ProjectNo where BS_StnList.ProjectNo='{0}' order by BS_StnList.AutoId", projectNoStr);
        }

        /// <summary>
        /// 设定GridView的默认值
        /// </summary>
        private void gridViewStnList_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            try
            {
                //if (pNoStr != "" && gridViewStnList.ActiveFilterString != "")
                if (projectNoStr != "")
                {
                    gridViewStnList.SetFocusedRowCellValue("ProjectNo", projectNoStr);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--设定GridView的默认值错误。", ex);
            }
        }

        /// <summary>
        /// 设定Table的默认值
        /// </summary>
        private void TableStnList_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            try
            {
                //if (pNoStr != "" && gridViewStnList.ActiveFilterString != "")
                if (projectNoStr != "")
                {
                    e.Row["ProjectNo"] = projectNoStr;
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--设定Table的默认值错误。", ex);
            }
        }

        /// <summary>
        /// 刷新当前的站号信息
        /// </summary>
        public void RefreshCurrentStnInfo(string pNoStr, string pNameStr)
        {
            projectNoStr = pNoStr;
            this.Text = string.Format("项目【{0}】的站号信息", pNameStr);
            SetEditFormSQL();
            editForm.btnRefresh_Click(null, null);
        }
    }
}
