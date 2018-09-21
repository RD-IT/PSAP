
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PSAP.VIEW.BSVIEW
{
    public partial class FrmUserRight : DockContent
    {
        public static MenuStrip mnsRight = new MenuStrip();//权限管理用户主菜单
        public static MenuStrip mnuSP1 = new MenuStrip();
        public FrmUserRight()
        {         
            InitializeComponent();
            this.Controls.Add(mnsRight);
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
            // TODO: 这行代码将数据加载到表“dsPSAP.BS_Role”中。您可以根据需要移动或删除它。
            this.bS_RoleTableAdapter.Fill(this.dsPSAP.BS_Role);
            // TODO: 这行代码将数据加载到表“dsPSAP.BS_Department”中。您可以根据需要移动或删除它。
            this.bS_DepartmentTableAdapter.Fill(this.dsPSAP.BS_Department);

            dtblTmp=DAO.BSDAO.GetUserInfoList.getUserInfoList("", "", "","");
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

            dbtlTmp1= DAO.BSDAO.GetDepartmentList.getDepartmentList();
            cboDepartmentName.DataSource = dbtlTmp1;
            cboDepartmentName.DisplayMember = "DepartmentName";
        }

        private void btnStretch_Click(object sender, EventArgs e)
        {

            dtblTmp = DAO.BSDAO.GetUserInfoList.getUserInfoList(txtUserID.Text,txtLoginID.Text,txtUserName.Text,cboDepartmentName.Text.Trim());
            dgvUserList.DataSource = dtblTmp;

        }

        private void dgvUserList_SelectionChanged(object sender, EventArgs e)
        {
            mnsRight.Items.Clear();
            PSAP.MnsInit.InitMenuItem(mnsRight);//初始化菜单
            PSAP.MnsInit.SetMenuItemByRole(mnsRight, dgvUserList.CurrentRow.Cells[5].Value.ToString());//初始化用户权限

            //初始化treeView1
            tvwUserRigth.Nodes.Clear();
            PSAP.TreeGetNodeForMns.GetMenu(tvwUserRigth, mnsRight);
            tvwUserRigth.ExpandAll();
        }
    }
}
