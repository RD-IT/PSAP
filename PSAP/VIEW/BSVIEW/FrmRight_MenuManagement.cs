﻿using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
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
    public partial class FrmRight_MenuManagement : DockContent
    {
        FrmBaseEdit editForm = null;
        FrmCommonDAO commonDAO = new FrmCommonDAO();

        /// <summary>
        /// 父节点菜单编号
        /// </summary>
        private string parentMenuNameStr = "";

        /// <summary>
        /// 父节点菜单名称
        /// </summary>
        private string parentMenuTextStr = "";

        public FrmRight_MenuManagement()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmRight_MenuManagement_Load(object sender, EventArgs e)
        {
            try
            {
                if (editForm == null)
                {
                    editForm = new FrmBaseEdit();
                    editForm.FormBorderStyle = FormBorderStyle.None;
                    editForm.TopLevel = false;
                    editForm.TableName = "BS_Menu";
                    editForm.TableCaption = "主菜单管理";
                    editForm.Sql = "select BS_Menu.*, menu.MenuText as ParentMenuText from BS_Menu left join BS_Menu as menu on BS_Menu.ParentMenuName = menu.MenuName order by BS_Menu.MenuOrder, BS_Menu.AutoId";
                    editForm.PrimaryKeyColumn = "MenuName";
                    editForm.MasterDataSet = dSMenu;
                    editForm.MasterBindingSource = bSMenu;
                    editForm.MasterEditPanel = pnlEdit;
                    editForm.PrimaryKeyControl = textMenuText;
                    editForm.BrowseXtraGridView = gridViewMenu;
                    editForm.CheckControl += CheckControl;
                    editForm.QueryDataAfter += QueryDataAfter;
                    this.pnlToolBar.Controls.Add(editForm);
                    editForm.Dock = DockStyle.Fill;
                    editForm.Show();

                    lookUpFormName.Properties.DataSource = FrmRightBLL.InitFormNameDataTable();
                    lookUpParentMenuName.Properties.DataSource = FrmRightDAO.QueryMenuList();
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
            if (textMenuText.Text.Trim() == "")
            {
                MessageHandler.ShowMessageBox("菜单名称不能为空，请重新操作。");
                textMenuText.Focus();
                return false;
            }
            if(DataTypeConvert.GetString(gridViewMenu.GetFocusedDataRow()["MenuName"])== DataTypeConvert.GetString(gridViewMenu.GetFocusedDataRow()["ParentMenuName"]))
            {
                MessageHandler.ShowMessageBox("上级菜单不能和当前菜单相同，请重新操作。");
                lookUpParentMenuName.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// 查询数据之后的回调方法
        /// </summary>
        public void QueryDataAfter()
        {
            treeListMenu.ExpandAll();
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewMenu_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        /// <summary>
        /// 设定默认值
        /// </summary>
        private void TableMenu_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            e.Row["MenuName"] = FrmRightBLL.getNewNodeId();
            e.Row["FormName"] = "";
            e.Row["FormText"] = "";
            if (parentMenuNameStr != "")
            {
                e.Row["ParentMenuName"] = parentMenuNameStr;
                e.Row["ParentMenuText"] = parentMenuTextStr;
                parentMenuNameStr = "";
                parentMenuTextStr = "";
            }
        }

        /// <summary>
        /// 右击弹出菜单
        /// </summary>
        private void treeListMenu_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    treeListMenu.ContextMenuStrip = null;

                    TreeListHitInfo hInfo = treeListMenu.CalcHitInfo(new Point(e.X, e.Y));
                    TreeListNode node = hInfo.Node;
                    treeListMenu.FocusedNode = node;
                    if (node != null)
                    {
                        popupMenuList.ShowPopup(Control.MousePosition);
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--右击弹出菜单错误。", ex);
            }
        }

        /// <summary>
        /// 新增同级菜单
        /// </summary>
        private void barBtnSame_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (treeListMenu.FocusedNode != null)
                {
                    parentMenuNameStr = DataTypeConvert.GetString(treeListMenu.FocusedNode["ParentMenuName"]);
                    parentMenuTextStr = DataTypeConvert.GetString(treeListMenu.FocusedNode["ParentMenuText"]);
                    editForm.btnNew_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--新增同级菜单错误。", ex);
                parentMenuNameStr = "";
                parentMenuTextStr = "";
            }
        }

        /// <summary>
        /// 新增下级菜单
        /// </summary>
        private void barBtnDown_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (treeListMenu.FocusedNode != null)
                {
                    parentMenuNameStr = DataTypeConvert.GetString(treeListMenu.FocusedNode["MenuName"]);
                    parentMenuTextStr = DataTypeConvert.GetString(treeListMenu.FocusedNode["MenuText"]);
                    editForm.btnNew_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--新增下级菜单错误。", ex);
                parentMenuNameStr = "";
                parentMenuTextStr = "";
            }
        }

        /// <summary>
        /// 菜单上移事件
        /// </summary>
        private void barBtnMoveUp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (treeListMenu.FocusedNode != null)
                {
                    string menuNameStr = DataTypeConvert.GetString(treeListMenu.FocusedNode["MenuName"]);
                    string parentMenuNameStr = DataTypeConvert.GetString(treeListMenu.FocusedNode["ParentMenuName"]);
                    FrmRightDAO.MenuUpMove(menuNameStr, parentMenuNameStr);
                    editForm.btnRefresh_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--菜单上移事件错误。", ex);
            }
        }

        /// <summary>
        /// 菜单下移事件
        /// </summary>
        private void barBtnMoveDown_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (treeListMenu.FocusedNode != null)
                {
                    string menuNameStr = DataTypeConvert.GetString(treeListMenu.FocusedNode["MenuName"]);
                    string parentMenuNameStr = DataTypeConvert.GetString(treeListMenu.FocusedNode["ParentMenuName"]);
                    FrmRightDAO.MenuDownMove(menuNameStr, parentMenuNameStr);
                    editForm.btnRefresh_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--菜单下移事件错误。", ex);
            }
        }
    }
}
