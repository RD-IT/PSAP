
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
using PSAP.BLL.BSBLL;
using PSAP;
using PSAP.DAO.BSDAO;
using System.Data.SqlClient;
using PSAP.PSAPCommon;

namespace PSAP.VIEW.BSVIEW
{
    public partial class FrmRight : DockContent
    {
        public static MenuStrip mnsRight = new MenuStrip();//权限管理用户主菜单
        public static MenuStrip mnsMainMenu = new MenuStrip();//主菜单管理

        public FrmRight()
        {
            InitializeComponent();
            tvwUserRight.CheckBoxes = true;
            tvwRoleRight.CheckBoxes = true;
        }

        private void tvwUserRight_AfterCheck(object sender, TreeViewEventArgs e)
        {
            TreeSelectOptimize tr = new TreeSelectOptimize();
            tr.SelectChildAndlParent(e);//选择节点，自动选择所有父节点和子节点
        }

        DataTable dtblTmp = new DataTable();
        DataTable dtblTmp1 = new DataTable();
        private void FrmUserRight_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dsPSAP.BS_Menu”中。您可以根据需要移动或删除它。
            this.bS_MenuTableAdapter.Fill(this.dsPSAP.BS_Menu);
            // TODO: 这行代码将数据加载到表“dsPSAP.BS_Role”中。您可以根据需要移动或删除它。
            this.bS_RoleTableAdapter.Fill(this.dsPSAP.BS_Role);
            // TODO: 这行代码将数据加载到表“dsPSAP.BS_Department”中。您可以根据需要移动或删除它。
            this.bS_DepartmentTableAdapter.Fill(this.dsPSAP.BS_Department);

            dtblTmp = BSCommon.getUserInfoList("", "", "", "");
            dgvUserList.DataSource = dtblTmp;
            dgvUserList.ColumnHeadersHeight = 32;
            dgvUserList.Columns[0].Width = 40;
            dgvUserList.Columns[1].Width = 60;
            dgvUserList.Columns[2].Width = 60;
            dgvUserList.Columns[3].Width = 90;
            dgvUserList.Columns[4].Width = 90;
            dgvUserList.Columns[5].Width = 60;
            dgvUserList.Columns[0].DataPropertyName = dtblTmp.Columns["AutoId"].ToString();
            dgvUserList.Columns[1].DataPropertyName = dtblTmp.Columns["LoginID"].ToString();
            dgvUserList.Columns[2].DataPropertyName = dtblTmp.Columns["EmpName"].ToString();
            dgvUserList.Columns[3].DataPropertyName = dtblTmp.Columns["DepartmentName"].ToString();
            dgvUserList.Columns[4].DataPropertyName = dtblTmp.Columns["RoleName"].ToString();
            dgvUserList.Columns[5].DataPropertyName = dtblTmp.Columns["RoleNo"].ToString();
            dgvUserList.Columns[0].HeaderText = "员工编号";
            dgvUserList.Columns[1].HeaderText = "用户编号";
            dgvUserList.Columns[2].HeaderText = "用户姓名";
            dgvUserList.Columns[3].HeaderText = "部门";
            dgvUserList.Columns[4].HeaderText = "角色";
            dgvUserList.Columns[5].HeaderText = "角色编号";
            dgvUserList.Columns[0].Visible = false;
            dgvUserList.Columns[5].Visible = false;

            dtblTmp1 = BSCommon.getDepartmentList();
            cboDepartmentName.DataSource = dtblTmp1;
            cboDepartmentName.DisplayMember = "DepartmentName";

            //角色combo
            dtblTmp1 = BSCommon.getRoleList();
            cboRoleName.DataSource = dtblTmp1;
            cboRoleName.DisplayMember = "RoleName";
            cboRoleName.ValueMember = "RoleNo";

            //初始化【菜单管理page】
            mnsMainMenu.Items.Clear();
            FrmMainBLL.InitMenuItem(mnsMainMenu);//初始化主菜单
            FrmRightBLL.TreeGetNodeForMns(tvwMainMenu, mnsMainMenu);
            tvwMainMenu.ExpandAll();
            FrmRightBLL.InitDataGridViewComboFormName(dataGridViewComboFormName);//初始化窗口名下拉列表
            FrmRightBLL.TraverseFormControlToTable();// 遍历所有DockContent窗口及其中控件,并将结果加至数据库表中(系统完成后可停用)

            //初始化【角色管理page】
            InitEnableState();//初始化控件按钮状态

        }

        private void btnStretch_Click(object sender, EventArgs e)
        {
            dtblTmp = BSCommon.getUserInfoList(txtUserID.Text, txtLoginID.Text, txtUserName.Text, cboDepartmentName.Text.Trim());
            dgvUserList.DataSource = dtblTmp;

        }

        private void dgvUserList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUserList.CurrentRow != null)
            {
                cboRoleName.Text = "";
                mnsRight.Items.Clear();
                FrmMainBLL.InitMenuItem(mnsRight);//初始化权限菜单
                FrmMainBLL.SetMenuItemByRole(mnsRight, dgvUserList.CurrentRow.Cells[5].Value.ToString());//初始化用户权限
                FrmMainBLL.SetMenuItemByPersonal(mnsRight, dgvUserList.CurrentRow.Cells[0].Value.ToString());//初始化用户"个人"权限

                //初始化treeView1
                tvwUserRight.Nodes.Clear();
                FrmRightBLL.TreeGetNodeForMns(tvwUserRight, mnsRight);
                tvwUserRight.ExpandAll();
                FrmRightBLL.TreeAddButtonsNode(tvwUserRight, dgvUserList.CurrentRow.Cells[0].Value.ToString());//遍历窗口中的按钮，加到指定的Tree的叶子节点上
            }
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
                FrmRightDAO.RefreshMenuButton(nodeId);

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
                FrmRightDAO.RefreshMenuButton(nodeId);
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
                FrmRightDAO.RefreshMenuButton(nodeId);
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
                    if (tvwMainMenu.SelectedNode.Nodes.Count > 0)
                    {
                        MessageBox.Show("包含子菜单项，不能直接删除，请从最低层菜单开始删！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("真的要删除吗,所有与此菜单相关的【个人】和【角色】权限将一起被删除？", "删除确认", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            //先删除对此数据有依赖关系的相关数数
                            FrmRightDAO.DeleteMenuCorrelationData(tvwMainMenu.SelectedNode.Name);//删除与菜单相关数据

                            //删除菜单表数据
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
        }

        //修改菜单名称
        private void tvwMainMenu_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Label))
            {
                bS_MenuDataGridView.CurrentRow.Cells[1].Value = e.Label;
            }
            Validate();
            bS_MenuBindingSource.EndEdit();
            bS_MenuTableAdapter.Update(dsPSAP.BS_Menu);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Validate();
            bS_MenuBindingSource.EndEdit();
            bS_MenuTableAdapter.Update(dsPSAP.BS_Menu);
            FrmMain.frmMain.tsrLblCurrentStatusText = "【主菜单】相关设定已成功保存";

        }

        private void btnSaveRight_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cboRoleName.SelectedValue.ToString()))
            {
                dgvUserList.CurrentRow.Cells[4].Value = cboRoleName.Text;
                dgvUserList.CurrentRow.Cells[5].Value = cboRoleName.SelectedValue;
                FrmRightDAO.SaveRoleUser(cboRoleName.SelectedValue.ToString(), (int)dgvUserList.CurrentRow.Cells[0].Value);
                FrmRightDAO.GiveRoleAllButtonRight();
            }
            FrmRightBLL.SaevPersonalRightFromTree(tvwUserRight, dgvUserList);//遍历树保存权限

            FrmMain.frmMain.tsrLblCurrentStatusText = "【用户权限】已成功保存";
        }

        private void roleNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            psapCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件//

        }

        private void roleNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            psapCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件

        }

        private void tsbDGViewExportToCSV_Click(object sender, EventArgs e)
        {
            FileHandler.DataGridViewExportToCSV(dgvRoleList,psapCommon.GetDateNumber("角色"));
            

        }

        private void tsbCancel_Click(object sender, EventArgs e)
        {
            dgvRoleList.Enabled = true;
            ChangeEnabledState();
            this.bS_RoleBindingSource.CancelEdit();

        }

        /// <summary>
        /// 初始化控件Enable状态
        /// </summary>
        private void InitEnableState()
        {
            tvwRoleRight.Enabled = false;
            pnlEdit.Enabled = false;
            tsbSave.Enabled = false;
            tsbCancel.Enabled = false;
        }

        /// <summary>
        /// panel（pnlEdit）的Enabled属性设置为“False”，表示最开始panel里面的控件都设置为不可编辑状态
        /// 保存了、取消初始Enable为"False"
        /// 将数据导航条、GroupBox、新增、修改、删除、保存、取消的Enabled状态取反
        /// </summary>
        private void ChangeEnabledState()
        {
            tvwRoleRight.Enabled = !tvwRoleRight.Enabled;
            bS_RoleBindingNavigator.Enabled = !bS_RoleBindingNavigator.Enabled;
            pnlEdit.Enabled = !pnlEdit.Enabled;
            foreach (ToolStripButton b in tsControl.Items)
            {
                b.Enabled = !b.Enabled;
            }

            //检测窗口状态：新增、编辑="EDIT"，保存、取消=""
            if (((Label)this.Controls["lblEditFlag"]).Text == "")
            {
                ((Label)this.Controls["lblEditFlag"]).Text = "EDIT";
            }
            else
            {
                ((Label)this.Controls["lblEditFlag"]).Text = "";
            }

        }

        /// <summary>
        /// 关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            //createDateDateTimePicker.Value = DateTime.Now;//建立日期设定为保存时间
            //founderTextBox.Text = BSCheckUser.user.EmpName;//获取当前登录用户姓名
            if (string.IsNullOrEmpty(roleNoTextBox.Text))
            {
                MessageBox.Show("【角色编码】为必填项！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                roleNoTextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(roleNameTextBox.Text))
            {
                MessageBox.Show("【角色名称】为必填项！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                roleNameTextBox.Focus();
                return;
            }

            try
            {
                this.Validate();
                this.bS_RoleBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dsPSAP);
                ChangeEnabledState();//保存后更新控件状态

                //刷新角色combo
                dtblTmp1 = BSCommon.getRoleList();
                cboRoleName.DataSource = dtblTmp1;
                cboRoleName.DisplayMember = "RoleName";
                cboRoleName.ValueMember = "RoleNo";
            }
            catch (System.Data.ConstraintException)//关键字字段值重复
            {
                MessageBox.Show("此角色【部门编码】已经存在！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                roleNoTextBox.Focus();
            }

            catch (System.Data.SqlClient.SqlException)//外键约束
            {
                MessageBox.Show("此角色【部门编码】已经被分配权限，不允许修改！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //执行一遍取消操作
            }

            FrmRightBLL.SaveRoleRightFromTree(tvwRoleRight, dgvRoleList);//遍历树保存权限
            FrmRightDAO.GiveRoleAllButtonRight();
            dgvRoleList.Enabled = true;//保存后数据表控件可用
        }

        /// <summary>
        /// 删除当前行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (bS_RoleBindingSource.Current != null)//当前是否有数据
            {
                if (MessageBox.Show("确实要删除吗，与此【角色】相关的权限将一起被删除?", "确认", MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //先删除对此数据有依赖关系的相关数数
                    FrmRightDAO.DeleteRoleCorrelationData(roleNoTextBox.Text);//删除与角色相关数据

                    bS_RoleBindingSource.RemoveCurrent();
                    this.tableAdapterManager.UpdateAll(dsPSAP);//更新数据集
                }
            }
            dgvRoleList.Enabled = true;//删除后数据表控件可用

        }

        /// <summary>
        /// 新增一条记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbAdd_Click(object sender, EventArgs e)
        {
            //新增时数据表控件不可用
            dgvRoleList.Enabled = false;
            ChangeEnabledState();//更改控件状态
            bS_RoleBindingSource.AddNew();
            roleNoTextBox.Focus();

        }

        /// <summary>
        /// 编辑当前记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbEdit_Click(object sender, EventArgs e)
        {
            ChangeEnabledState();//更改控件状态
            roleNoTextBox.Focus();
        }

        private void tvwRoleRight_AfterCheck(object sender, TreeViewEventArgs e)
        {
            TreeSelectOptimize tr = new TreeSelectOptimize();
            tr.SelectChildAndlParent(e);//选择节点，自动选择所有父节点和子节点
        }

        private void dgvRoleList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRoleList.CurrentRow!=null)
            {
                mnsRight.Items.Clear();
                FrmMainBLL.InitMenuItem(mnsRight);//初始化权限菜单
                FrmMainBLL.SetMenuItemByRole(mnsRight, dgvRoleList.CurrentRow.Cells[1].Value.ToString());//初始化角色权限
                tvwRoleRight.Nodes.Clear();
                FrmRightBLL.TreeGetNodeForMns(tvwRoleRight, mnsRight);
                tvwRoleRight.ExpandAll();
                //FrmRightBLL.TreeAddButtonsNode(tvwRoleRight, dgvUserList.CurrentRow.Cells[0].Value.ToString());//遍历窗口中的按钮，加到指定的Tree的叶子节点上
            }
        }

        private void dgvUserList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tsbQuery_Click(object sender, EventArgs e)
        {
            string[,] strsQueryTmp = new string[2, 2];
            DataTable[] dt = new DataTable[strsQueryTmp.GetLongLength(0)];//有cbo时需给此对角赋值
            strsQueryTmp[0, 0] = "角色编号";
            strsQueryTmp[1, 0] = "角色名称";
            strsQueryTmp[0, 1] = "txt";
            strsQueryTmp[1, 1] = "txt";
            FrmQueryCondition f = new FrmQueryCondition(strsQueryTmp, dt);
            f.ShowDialog();

            string strFilter;
            strFilter = "RoleNo like '*" + strsQueryTmp[0, 1] + "*' " +
                "and RoleName like '*" + strsQueryTmp[1, 1] + "*'";
            this.bS_RoleBindingSource.Filter = strFilter;

        }

        private void dgvUserList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(((DataGridView)sender).RowHeadersDefaultCellStyle.ForeColor))
            {
                int lineN = 0;
                lineN = e.RowIndex + 1;
                string strLineNo = lineN.ToString();
                e.Graphics.DrawString(strLineNo, e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 13, e.RowBounds.Location.Y + 5);
                SolidBrush B = new SolidBrush(Color.Red);
            }
        }

        private void bS_MenuDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(((DataGridView)sender).RowHeadersDefaultCellStyle.ForeColor))
            {
                int lineN = 0;
                lineN = e.RowIndex + 1;
                string strLineNo = lineN.ToString();
                e.Graphics.DrawString(strLineNo, e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 13, e.RowBounds.Location.Y + 5);
                SolidBrush B = new SolidBrush(Color.Red);
            }
        }

        private void dgvRoleList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(((DataGridView)sender).RowHeadersDefaultCellStyle.ForeColor))
            {
                int lineN = 0;
                lineN = e.RowIndex + 1;
                string strLineNo = lineN.ToString();
                e.Graphics.DrawString(strLineNo, e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 13, e.RowBounds.Location.Y + 5);
                SolidBrush B = new SolidBrush(Color.Red);
            }
        }
    }
}
