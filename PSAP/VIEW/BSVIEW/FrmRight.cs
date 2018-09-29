
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using WeifenLuo.WinFormsUI.Docking;
using PSAP.BLL;
namespace PSAP.VIEW.BSVIEW
{
    public partial class FrmRight : DockContent
    {
        public static MenuStrip mnsRight = new MenuStrip();//权限管理用户主菜单
        public static MenuStrip mnsMainMenu = new MenuStrip();//主菜单管理
                                                              //public static MenuStrip mnuSP1 = new MenuStrip();
        public FrmRight()
        {
            InitializeComponent();
            //this.Controls.Add(mnsRight);使用此行代码会造成无法重复打开窗口
            tvwUserRigth.CheckBoxes = true;

        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            PSAP.TreeSelectOptimize tr = new TreeSelectOptimize();
            tr.SelectChildAndlParent(e);//选择节点，自动选择所有父节点和子节点
        }

        DataTable dtblTmp = new DataTable();
        DataTable dbtlTmp1 = new DataTable();
        private void FrmUserRight_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dsPSAP.BS_Menu”中。您可以根据需要移动或删除它。
            this.bS_MenuTableAdapter.Fill(this.dsPSAP.BS_Menu);
            // TODO: 这行代码将数据加载到表“dsPSAP.BS_Role”中。您可以根据需要移动或删除它。
            this.bS_RoleTableAdapter.Fill(this.dsPSAP.BS_Role);
            // TODO: 这行代码将数据加载到表“dsPSAP.BS_Department”中。您可以根据需要移动或删除它。
            this.bS_DepartmentTableAdapter.Fill(this.dsPSAP.BS_Department);

            dtblTmp = DAO.BSDAO.GetUserInfoList.getUserInfoList("", "", "", "");
            dgvUserList.DataSource = dtblTmp;
            dgvUserList.ColumnHeadersHeight = 32;
            dgvUserList.Columns[0].Width = 40;
            dgvUserList.Columns[1].Width = 60;
            dgvUserList.Columns[2].Width = 60;
            dgvUserList.Columns[3].Width = 60;
            dgvUserList.Columns[0].DataPropertyName = dtblTmp.Columns["AutoId"].ToString();
            dgvUserList.Columns[1].DataPropertyName = dtblTmp.Columns["LoginID"].ToString();
            dgvUserList.Columns[2].DataPropertyName = dtblTmp.Columns["EmpName"].ToString();
            dgvUserList.Columns[3].DataPropertyName = dtblTmp.Columns["DepartmentName"].ToString();
            dgvUserList.Columns[0].HeaderText = "员工编号";
            dgvUserList.Columns[1].HeaderText = "用户编号";
            dgvUserList.Columns[2].HeaderText = "用户姓名";
            dgvUserList.Columns[3].HeaderText = "部门";

            dbtlTmp1 = DAO.BSDAO.GetDepartmentList.getDepartmentList();
            cboDepartmentName.DataSource = dbtlTmp1;
            cboDepartmentName.DisplayMember = "DepartmentName";

            //初始化菜单管理页
            mnsMainMenu.Items.Clear();
            PSAP.MnsInit.InitMenuItem(mnsMainMenu);//初始化主菜单
            FrmRightBLL.TreeGetNodeForMns(tvwMainMenu, mnsMainMenu);
            tvwMainMenu.ExpandAll();
            FrmRightBLL.InitDataGridViewComboFormName(dataGridViewComboFormName);
        }

        private void btnStretch_Click(object sender, EventArgs e)
        {

            dtblTmp = DAO.BSDAO.GetUserInfoList.getUserInfoList(txtUserID.Text, txtLoginID.Text, txtUserName.Text, cboDepartmentName.Text.Trim());
            dgvUserList.DataSource = dtblTmp;

        }

        private void dgvUserList_SelectionChanged(object sender, EventArgs e)
        {
            mnsRight.Items.Clear();
            PSAP.MnsInit.InitMenuItem(mnsRight);//初始化权限菜单
            PSAP.MnsInit.SetMenuItemByRole(mnsRight, dgvUserList.CurrentRow.Cells[5].Value.ToString());//初始化用户权限
            PSAP.MnsInit.SetMenuItemByPersonal(mnsRight, dgvUserList.CurrentRow.Cells[0].Value.ToString());//初始化用户"个人"权限

            //初始化treeView1
            tvwUserRigth.Nodes.Clear();
            FrmRightBLL.TreeGetNodeForMns(tvwUserRigth, mnsRight);

            tvwUserRigth.ExpandAll();

        }
        //同级菜单
        private void insertTreeNode_Click(object sender, EventArgs e)
        {
            try
            {
                string nName;
                nName = tvwMainMenu.SelectedNode.Name;
                tvwMainMenu.SelectedNode.Parent.Nodes.Insert(tvwMainMenu.SelectedNode.Index, "插入同级菜单");
                tvwMainMenu.SelectedNode.Expand();
                tvwMainMenu.SelectedNode = tvwMainMenu.SelectedNode.PrevNode;
                string nodeId = FrmRightBLL.getNewNodeId();
                tvwMainMenu.SelectedNode.Name = nodeId;
                saveNodeToTable();//将新建节点同步到数据库
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }

        }

        private void addChildTreeNode_Click(object sender, EventArgs e)
        {
            try
            {
                tvwMainMenu.SelectedNode.Nodes.Add("新建子菜单");
                tvwMainMenu.SelectedNode.Expand();
                tvwMainMenu.SelectedNode = tvwMainMenu.SelectedNode.LastNode;
                string nodeId = FrmRightBLL.getNewNodeId();
                tvwMainMenu.SelectedNode.Name = nodeId;
                saveNodeToTable();//将新建节点同步到数据库
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
        /// <summary>
        /// 将新建节点同步到数据库
        /// </summary>
        private void saveNodeToTable()
        {
            bS_MenuBindingSource.AddNew();
            bS_MenuDataGridView.CurrentRow.Cells[0].Value = tvwMainMenu.SelectedNode.Name;
            bS_MenuDataGridView.CurrentRow.Cells[1].Value = tvwMainMenu.SelectedNode.Text;
            bS_MenuDataGridView.CurrentRow.Cells[2].Value = tvwMainMenu.SelectedNode.Parent.Name;
            bS_MenuDataGridView.CurrentRow.Cells[5].Value = tvwMainMenu.SelectedNode.Index.ToString();
            this.Validate();
            this.bS_MenuBindingSource.EndEdit();
            this.bS_MenuTableAdapter.Update(dsPSAP.BS_Menu);
        }

        private void addRootTreeNode_Click(object sender, EventArgs e)
        {
            try
            {
                tvwMainMenu.Nodes.Add("新建主菜单");
                tvwMainMenu.SelectedNode.Expand();
                //选定新建节点
                tvwMainMenu.SelectedNode = tvwMainMenu.Nodes[tvwMainMenu.Nodes.Count - 1];
                string nodeId = FrmRightBLL.getNewNodeId();
                tvwMainMenu.SelectedNode.Name = nodeId;
                //将新建节点同步到数据库
                bS_MenuBindingSource.AddNew();
                bS_MenuDataGridView.CurrentRow.Cells[0].Value = tvwMainMenu.SelectedNode.Name;
                bS_MenuDataGridView.CurrentRow.Cells[1].Value = tvwMainMenu.SelectedNode.Text;
                bS_MenuDataGridView.CurrentRow.Cells[5].Value = tvwMainMenu.SelectedNode.Index.ToString();
                this.Validate();
                this.bS_MenuBindingSource.EndEdit();
                this.bS_MenuTableAdapter.Update(dsPSAP.BS_Menu);
                //刷新下窗口，不然有重新打开打不开的情况
                //FrmRight frmUserRight = new FrmRight();
                //FrmMain.frmMain.showRight(frmUserRight);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void deleteTreeNode_Click(object sender, EventArgs e)
        {
            try
            {
                if (tvwMainMenu.Nodes.Count > 1 || tvwMainMenu.SelectedNode.Parent != null)
                {
                    //XElement selNode = xmlFindNode(tvwMainMenu.SelectedNode.Name);//在XML文件中定位节点
                    if (tvwMainMenu.SelectedNode.Nodes.Count > 0)
                    {
                        MessageBox.Show("包含子菜单项，不能直接删除，请从最低层菜单开始删！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("真的要删除吗？", "删除确认", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            bS_MenuBindingSource.RemoveCurrent();
                            Validate();
                            bS_MenuBindingSource.EndEdit();
                            bS_MenuTableAdapter.Update(dsPSAP.BS_Menu);
                            tvwMainMenu.SelectedNode.Remove();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("不能删除最后一个主菜单！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void tvwMainMenu_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tvwMainMenu.SelectedNode = e.Node;
        }

        private void tvwMainMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int index = bS_MenuBindingSource.Find("MenuName", tvwMainMenu.SelectedNode.Name);
            if (index != -1)
            {
                bS_MenuBindingSource.Position = index;//定位BindingSource
            }
            //刷新下窗口，不然有重新打开打不开的情况
            // FrmRight frmUserRight = new FrmRight();//最好放在窗口关闭时
            // FrmMain.frmMain.showRight(frmUserRight);//最好放在窗口关闭时
        }

        //修改菜单名称
        private void tvwMainMenu_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            bS_MenuDataGridView.CurrentRow.Cells[1].Value = e.Label;
            Validate();
            bS_MenuBindingSource.EndEdit();
            bS_MenuTableAdapter.Update(dsPSAP.BS_Menu);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Validate();
            bS_MenuBindingSource.EndEdit();
            bS_MenuTableAdapter.Update(dsPSAP.BS_Menu);

        }

        private void btnSaveRight_Click(object sender, EventArgs e)
        {
            //FrmRightBLL.SaveRightFromTree(tvwUserRigth);//遍历树保存权限
            FrmRightBLL.TraverseForm();//遍历窗口控件
        }

        private void tvwUserRigth_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MessageBox.Show(tvwUserRigth.SelectedNode.Tag.ToString());
        }
    }
}
