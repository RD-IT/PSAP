using DevExpress.XtraTreeList.Nodes;
using PSAP.DAO.BSDAO;
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
    public partial class FrmRight_Role : DockContent
    {
        FrmBaseEdit editForm = null;

        public FrmRight_Role()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmRight_Role_Load(object sender, EventArgs e)
        {
            try
            {                
                if (editForm == null)
                {
                    QueryMenuTreeList();

                    editForm = new FrmBaseEdit();
                    editForm.FormBorderStyle = FormBorderStyle.None;
                    editForm.TopLevel = false;
                    editForm.TableName = "BS_Role";
                    editForm.TableCaption = "角色权限管理";
                    editForm.Sql = "select * from BS_Role Order by AutoId";
                    editForm.PrimaryKeyColumn = "RoleNo";
                    editForm.MasterDataSet = dSRole;
                    editForm.MasterBindingSource = bSRole;
                    editForm.MasterEditPanel = pnlEdit;
                    editForm.PrimaryKeyControl = textRoleNo;
                    editForm.MasterEditPanelAddControl = new List<Control>() { treeListRole };
                    editForm.BrowseXtraGridView = gridViewRole;
                    editForm.RowStateUnchangedIsSave = true;
                    editForm.CheckControl += CheckControl;
                    editForm.QueryDataAfter += QueryDataAfter;
                    editForm.CancelAfter += QueryDataAfter;
                    editForm.SaveRowAfter += SaveRowAfter;
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
            if (textRoleNo.Text.Trim() == "")
            {
                MessageHandler.ShowMessageBox("角色编号不能为空，请重新操作。");
                textRoleNo.Focus();
                return false;
            }
            if (textRoleName.Text.Trim() == "")
            {
                MessageHandler.ShowMessageBox("角色名称不能为空，请重新操作。");
                textRoleName.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// 查询数据之后的回调方法
        /// </summary>
        public void QueryDataAfter()
        {
            SetRoleMenuTreeCheck();
        }

        /// <summary>
        /// 保存之后执行的回调方法
        /// </summary>
        public bool SaveRowAfter(DataRow dr, SqlCommand cmd)
        {
            FrmRightDAO.SaveRoleMenu_TreeList(cmd, DataTypeConvert.GetString(dr["RoleNo"]), treeListRole);

            return true;
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewRole_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        /// <summary>
        /// 选中角色查看权限
        /// </summary>
        public void gridViewRole_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (gridViewRole.GetFocusedDataRow() != null)
                {
                    SetRoleMenuTreeCheck();
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--选中角色查看权限错误。", ex);
            }
        }

        /// <summary>
        /// 查询权限树的所有节点
        /// </summary>
        public void QueryMenuTreeList()
        {
            treeListRole.DataSource = FrmRightDAO.QueryMenuTree();
            treeListRole.ExpandAll();
        }

        /// <summary>
        /// 设定角色菜单树的选择状态
        /// </summary>
        private void SetRoleMenuTreeCheck()
        {
            treeListRole.UncheckAll();
            foreach (TreeListNode node in treeListRole.Nodes)
            {
                node.Checked = true;
            }
            if (gridViewRole.GetFocusedDataRow() != null)
            {
                DataTable roleMenuTable = FrmRightDAO.QueryRoleMenu(DataTypeConvert.GetString(gridViewRole.GetFocusedDataRow()["RoleNo"]));
                int cont = treeListRole.GetAllCheckedNodes().Count;

                foreach (TreeListNode node in treeListRole.GetNodeList())
                {
                    string menuNameStr = DataTypeConvert.GetString(node["MenuName"]);
                    DataRow[] drs = roleMenuTable.Select(string.Format("MenuName = '{0}'", menuNameStr));
                    if (drs.Length > 0)
                        node.Checked = true;
                }
            }
        }

        /// <summary>
        /// 根据选择节点状态更新树其他节点状态
        /// </summary>
        private void treeListRole_AfterCheckNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            try
            {
                SetCheckedChildNodes(e.Node, e.Node.CheckState);
                SetCheckedParentNodes(e.Node, e.Node.CheckState);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--根据选择节点状态更新树其他节点状态错误。", ex);
            }
        }

        private void treeListRole_BeforeCheckNode(object sender, DevExpress.XtraTreeList.CheckNodeEventArgs e)
        {
            e.State = (e.PrevState == CheckState.Checked ? CheckState.Unchecked : CheckState.Checked);
        }

        /// <summary>
        /// 设置子节点的状态
        /// </summary>
        private void SetCheckedChildNodes(DevExpress.XtraTreeList.Nodes.TreeListNode node, CheckState check)
        {
            for (int i = 0; i < node.Nodes.Count; i++)
            {
                node.Nodes[i].CheckState = check;
                SetCheckedChildNodes(node.Nodes[i], check);
            }
        }

        /// <summary>
        /// 设置父节点的状态
        /// </summary>
        private void SetCheckedParentNodes(DevExpress.XtraTreeList.Nodes.TreeListNode node, CheckState check)
        {
            if (node.ParentNode != null)
            {
                bool b = false;
                CheckState state;
                for (int i = 0; i < node.ParentNode.Nodes.Count; i++)
                {
                    state = (CheckState)node.ParentNode.Nodes[i].CheckState;
                    if (!check.Equals(state))
                    {
                        b = !b;
                        break;
                    }
                }
                //node.ParentNode.CheckState = b ? CheckState.Indeterminate : check;
                node.ParentNode.CheckState = b ? CheckState.Checked : check;
                SetCheckedParentNodes(node.ParentNode, check);
            }
        }
    }
}
