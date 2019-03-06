using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using PSAP.BLL.BSBLL;
using PSAP.DAO.BSDAO;
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
            PSAP.BLL.BSBLL.BSBLL.language(this);
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
                    editForm.SaveRowBefore += SaveRowBefore;
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
                MessageHandler.ShowMessageBox(tsmiCdmcbnwk.Text );// ("菜单名称不能为空，请重新操作。");
                textMenuText.Focus();
                return false;
            }
            if(DataTypeConvert.GetString(gridViewMenu.GetFocusedDataRow()["MenuName"])== DataTypeConvert.GetString(gridViewMenu.GetFocusedDataRow()["ParentMenuName"]))
            {
                MessageHandler.ShowMessageBox(tsmiSjcdbnh.Text );// ("上级菜单不能和当前菜单相同，请重新操作。");
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
            lookUpParentMenuName.Properties.DataSource = FrmRightDAO.QueryMenuList();
        }

        /// <summary>
        /// 保存行之前的回调方法
        /// </summary>
        /// <param name="dr"></param>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public bool SaveRowBefore(DataRow dr, SqlCommand cmd)
        {
            if (dr.RowState == DataRowState.Added)
                dr["MenuOrder"] = FrmRightDAO.GetMaxMenuOrder(cmd, DataTypeConvert.GetString(dr["ParentMenuName"]));

            return true;
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

                    foreach(TreeListNode downNode in treeListMenu.Nodes)
                    {
                        if (FocusedHistoryNode(downNode, menuNameStr, parentMenuNameStr))
                            break;
                    }
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

                    foreach (TreeListNode downNode in treeListMenu.Nodes)
                    {
                        if (FocusedHistoryNode(downNode, menuNameStr, parentMenuNameStr))
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--菜单下移事件错误。", ex);
            }
        }

        /// <summary>
        /// 选择节点之前设定控件状态
        /// </summary>
        private void treeListMenu_BeforeFocusNode(object sender, BeforeFocusNodeEventArgs e)
        {
            try
            {
                //if (bSMenu.Current != null)
                //{
                //    DataRow dr = ((DataRowView)bSMenu.Current).Row;
                //    dr.RejectChanges();
                //    editForm.Set_Button_State(true);
                //    editForm.Set_EditZone_ControlReadOnly(true);
                //} 

                if (bSMenu.Current != null)
                {
                    if (((DataRowView)bSMenu.Current).IsEdit)
                    {
                        int oldId = e.OldNode == null ? 0 : DataTypeConvert.GetInt(e.OldNode["AutoId"]);
                        DataRow dr = ((DataRowView)bSMenu.Current).Row;
                        if (dr.RowState == DataRowState.Added && oldId != 0)
                        {
                            return;
                        }
                        else
                        {
                            dr.RejectChanges();
                            editForm.Set_Button_State(true);
                            editForm.Set_EditZone_ControlReadOnly(true);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--选择节点之前设定控件状态错误。", ex);
            }
        }

        /// <summary>
        /// 聚焦之前的历史节点
        /// </summary>
        private bool FocusedHistoryNode(TreeListNode upNode, string menuNameStr, string parentMenuNameStr)
        {
            foreach (TreeListNode downNode in upNode.Nodes)
            {
                string mnStr = DataTypeConvert.GetString(downNode["MenuName"]);
                string pmnStr = DataTypeConvert.GetString(downNode["ParentMenuName"]);
                if (menuNameStr == mnStr && parentMenuNameStr == pmnStr)
                {
                    treeListMenu.FocusedNode = downNode;
                    return true;
                }
                else
                    FocusedHistoryNode(downNode, menuNameStr, parentMenuNameStr);
            }

            return false;
        }
    }
}
