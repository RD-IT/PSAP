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
    public partial class FrmRole : DockContent
    {
        public FrmRole()
        {
            InitializeComponent();
        }

        private void bS_RoleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bS_RoleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsPSAP);

        }

        private void FrmRole_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dsPSAP.BS_Role”中。您可以根据需要移动或删除它。
            this.bS_RoleTableAdapter.Fill(this.dsPSAP.BS_Role);
            InitEnableState();//初始化控件按钮状态
        }

        private void roleNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PSAPCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件
        }

        private void roleNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PSAPCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件
        }
        private void tsbDGViewExportToCSV_Click(object sender, EventArgs e)
        {
            PSAPCommon.DataGridViewExportToCSV(bS_RoleDataGridView, PSAPCommon.GetDateNumber("角色"));
        }

        private void tsbCancel_Click(object sender, EventArgs e)
        {
            ChangeEnabledState();
            this.bS_RoleBindingSource.CancelEdit();
        }

        /// <summary>
        /// 初始化控件Enable状态
        /// </summary>
        private void InitEnableState()
        {
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
            bS_RoleBindingNavigator.Enabled = !bS_RoleBindingNavigator.Enabled;
            pnlEdit.Enabled = !pnlEdit.Enabled;
            foreach (ToolStripButton b in tsControl.Items)
            {
                b.Enabled = !b.Enabled;
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

            try
            {
                this.Validate();
                this.bS_RoleBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dsPSAP);
                ChangeEnabledState();//保存后更新控件状态
            }
            catch (System.Data.NoNullAllowedException)//字段为空
            {

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
                }
            }
            catch (System.Data.ConstraintException)//关键字字段值重复
            {
                MessageBox.Show("此部门编码已经存在！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                roleNoTextBox.Focus();
            }
            bS_RoleDataGridView.Enabled = true;//保存后数据表控件可用

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
                if (MessageBox.Show("确实要删除吗?", "确认", MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bS_RoleBindingSource.RemoveCurrent();
                    this.tableAdapterManager.UpdateAll(dsPSAP);//更新数据集
                }
            }
            bS_RoleDataGridView.Enabled = true;//删除后数据表控件可用
        }

        /// <summary>
        /// 新增一条记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbAdd_Click(object sender, EventArgs e)
        {
            //新增时数据表控件不可用
            bS_RoleDataGridView.Enabled = false;
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

    }
}
