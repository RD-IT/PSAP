using PSAP.BLL.BSBLL;
using PSAP.DAO.BSDAO;
using PSAP.PSAPCommon;
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
    public partial class FrmOrganizationStru : DockContent
    {
        public FrmOrganizationStru()
        {
            InitializeComponent();

        }

        private void FrmOrganizationStru_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dsPSAP.BS_Department”中。您可以根据需要移动或删除它。
            this.bS_DepartmentTableAdapter.Fill(this.dsPSAP.BS_Department);
            FrmOrganizationStruBLL.tvwDepartmentGetNode(tvwOrganizationStru);
            tvwOrganizationStru.ExpandAll();
            InitEnableState();//初始化控件Enable状态

        }

        /// <summary>
        /// 初始化控件Enable状态
        /// </summary>
        private void InitEnableState()
        {
            departmentNoTextBox1.Enabled = false;
            tsbSave.Enabled = false;
            tsbCancel.Enabled = false;
        }
        //同级菜单
        private void insertTreeNode_Click(object sender, EventArgs e)
        {
            try
            {
                string nName;
                nName = tvwOrganizationStru.SelectedNode.Name;
                tvwOrganizationStru.SelectedNode.Parent.Nodes.Insert(tvwOrganizationStru.SelectedNode.Index, "插入同级部门");
                tvwOrganizationStru.SelectedNode.Expand();
                tvwOrganizationStru.SelectedNode = tvwOrganizationStru.SelectedNode.PrevNode;
                string nodeId = FrmRightBLL.getNewNodeId();
                tvwOrganizationStru.SelectedNode.Name = nodeId;
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
                tvwOrganizationStru.SelectedNode.Nodes.Add("新建子部门");
                tvwOrganizationStru.SelectedNode.Expand();
                tvwOrganizationStru.SelectedNode = tvwOrganizationStru.SelectedNode.LastNode;
                string nodeId = FrmRightBLL.getNewNodeId();
                tvwOrganizationStru.SelectedNode.Name = nodeId;
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
            bS_DepartmentBindingSource.AddNew();
            bS_DepartmentDataGridView.CurrentRow.Cells[1].Value = tvwOrganizationStru.SelectedNode.Name;
            bS_DepartmentDataGridView.CurrentRow.Cells[2].Value = tvwOrganizationStru.SelectedNode.Text;
            if (tvwOrganizationStru.SelectedNode.Parent != null)
            {
                bS_DepartmentDataGridView.CurrentRow.Cells[3].Value = tvwOrganizationStru.SelectedNode.Parent.Name;
            }
            bS_DepartmentDataGridView.CurrentRow.Cells[4].Value = DateTime.Now;
            bS_DepartmentDataGridView.CurrentRow.Cells[5].Value = FrmLoginDAO.user.EmpName;
            this.Validate();
            this.bS_DepartmentBindingSource.EndEdit();
            this.bS_DepartmentTableAdapter.Update(dsPSAP.BS_Department);
        }

        private void addRootTreeNode_Click(object sender, EventArgs e)
        {
            try
            {
                tvwOrganizationStru.Nodes.Add("新建根部门");
                tvwOrganizationStru.SelectedNode.Expand();
                //选定新建节点
                tvwOrganizationStru.SelectedNode = tvwOrganizationStru.Nodes[tvwOrganizationStru.Nodes.Count - 1];
                string nodeId = FrmRightBLL.getNewNodeId();
                tvwOrganizationStru.SelectedNode.Name = nodeId;
                saveNodeToTable();//将新建节点同步到数据库
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
                if (tvwOrganizationStru.Nodes.Count > 1 || tvwOrganizationStru.SelectedNode.Parent != null)
                {
                    if (tvwOrganizationStru.SelectedNode.Nodes.Count > 0)
                    {
                        MessageBox.Show("包含子部门，不能直接删除，请从最低层部门开始删！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("真的要删除吗？", "删除确认", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            //先删除对此数据有依赖关系的相关数数
                            // FrmRightDAO.DeleteMenuCorrelationData(tvwOrganizationStru.SelectedNode.Name);//删除与菜单相关数据

                            //删除部门表数据
                            bS_DepartmentBindingSource.RemoveCurrent();
                            Validate();
                            bS_DepartmentBindingSource.EndEdit();
                            bS_DepartmentTableAdapter.Update(dsPSAP.BS_Department);
                            tvwOrganizationStru.SelectedNode.Remove();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("不能删除最后一个部门！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("当前部门已经被其它数据使用，不能删除！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void tvwOrganizationStru_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tvwOrganizationStru.SelectedNode = e.Node;
        }

        private void tvwOrganizationStru_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int index = bS_DepartmentBindingSource.Find("DepartmentNo", tvwOrganizationStru.SelectedNode.Name);
            if (index != -1)
            {
                bS_DepartmentBindingSource.Position = index;//定位BindingSource
            }
        }

        private void tvwOrganizationStru_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Label))
            {
                bS_DepartmentDataGridView.CurrentRow.Cells[2].Value = e.Label;
            }
            Validate();
            bS_DepartmentBindingSource.EndEdit();
            bS_DepartmentTableAdapter.Update(dsPSAP.BS_Department);
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            ChangeEnabledState();//更改控件状态
            departmentNoTextBox1.Focus();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            //createDateDateTimePicker.Value = DateTime.Now;//建立日期设定为保存时间
            //founderTextBox.Text = FrmLoginDAO.user.EmpName;//获取当前登录用户姓名

            if (string.IsNullOrEmpty(departmentNoTextBox1.Text))
            {
                MessageBox.Show("【部门编码】为必填项！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                departmentNoTextBox1.Focus();
                return;
            }

            //if (string.IsNullOrEmpty(departmentNameTextBox1.Text))
            //{
            //    MessageBox.Show("【部门名称】为必填项！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    departmentNameTextBox1.Focus();
            //    return;
            //}

            try
            {
                //先更新相关数据
                FrmOrganizationStruDAO.UpdateDeptmentNoCorrelationData(bS_DepartmentDataGridView.CurrentRow.Cells[1].Value.ToString() ,departmentNoTextBox1.Text);
                //更新部门编码
                this.Validate();
                this.bS_DepartmentBindingSource.EndEdit();
                this.bS_DepartmentTableAdapter.Update(this.dsPSAP);
                ChangeEnabledState();//保存后更新控件状态

                //使sql更改同步到DataGridView
                this.bS_DepartmentTableAdapter.Fill(this.dsPSAP.BS_Department);
                bS_DepartmentDataGridView.DataSource = bS_DepartmentBindingSource;

            }
            catch (System.Data.ConstraintException)//关键字字段值重复
            {
                MessageBox.Show("此部门编码已经存在！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                departmentNoTextBox1.Focus();
            }
            bS_DepartmentDataGridView.Enabled = true;//保存后数据表控件可用

        }

        //private void tsbQuery_Click(object sender, EventArgs e)
        //{
        //    string[,] strsQueryTmp = new string[3, 2];
        //    DataTable[] dt = new DataTable[strsQueryTmp.GetLongLength(0)];
        //    strsQueryTmp[0, 0] = "部门编号";
        //    strsQueryTmp[1, 0] = "部门名称";
        //    strsQueryTmp[2, 0] = "上级部门编号";
        //    strsQueryTmp[0, 1] = "txt";
        //    strsQueryTmp[1, 1] = "cbo";
        //    strsQueryTmp[2, 1] = "txt";
        //    dt[1] = BSCommon.getDepartmentList();//下标代表行号
        //    FrmQueryCondition f = new FrmQueryCondition(strsQueryTmp, dt);
        //    f.ShowDialog();

        //    string strFilter;
        //    strFilter = "DepartmentNo like '*" + strsQueryTmp[0, 1] + "*' " +
        //        "and DepartmentNo like '*" + strsQueryTmp[1, 1] + "*' " +
        //        "and ParentDepartmentNo like '*" + strsQueryTmp[2, 1] + "*'";
        //    this.bS_DepartmentBindingSource.Filter = strFilter;

        //}

        private void tsbCancel_Click(object sender, EventArgs e)
        {
            bS_DepartmentDataGridView.Enabled = true;
            ChangeEnabledState();
            this.bS_DepartmentBindingSource.CancelEdit();
        }

        private void tsbDGViewExportToCSV_Click(object sender, EventArgs e)
        {
            psapCommon.DataGridViewExportToCSV(bS_DepartmentDataGridView, psapCommon.GetDateNumber("部门信息"));

        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        /// <summary>
        /// panel（pnlEdit）的Enabled属性设置为“False”，表示最开始panel里面的控件都设置为不可编辑状态
        /// 保存了、取消初始Enable为"False"
        /// 将数据导航条、GroupBox、新增、修改、删除、保存、取消的Enabled状态取反
        /// </summary>
        private void ChangeEnabledState()
        {
            bS_DepartmentBindingNavigator.Enabled = !bS_DepartmentBindingNavigator.Enabled;
            departmentNoTextBox1.Enabled = !departmentNoTextBox1.Enabled;
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
    }
}
