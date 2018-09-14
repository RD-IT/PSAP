using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using PSAP.DAO.BSDAO;

namespace PSAP.VIEW.BSVIEW
{
    public partial class FrmDepartment : DockContent
    {
        public FrmDepartment()
        {
            InitializeComponent();
            InitEnableState();//初始化控件Enable状态
        }

           private void FrmDepartment_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dsPSAP.BS_Department”中。您可以根据需要移动或删除它。
            this.bS_DepartmentTableAdapter.Fill(this.dsPSAP.BS_Department);
            // TODO: 这行代码将数据加载到表“dsPSAP.BS_Department”中。您可以根据需要移动或删除它。
            this.bS_DepartmentTableAdapter.Fill(this.dsPSAP.BS_Department);
            // TODO: 这行代码将数据加载到表“dsPSAP.BS_Department”中。您可以根据需要移动或删除它。
            this.bS_DepartmentTableAdapter.Fill(this.dsPSAP.BS_Department);

            //FormResize();//根据窗口大小调整控件大小
        }
        #region 根据窗口大小调整控件大小
        PSAP.FormAutoSize formAutoSize = new FormAutoSize();
            /// <summary>
            ///根据窗口大小调整控件大小
            /// </summary>
            private void FormResize()
            {
                this.Resize += new EventHandler(Form_Resize);
                formAutoSize._x = this.Width;
                formAutoSize._y = this.Height;
                formAutoSize.setTag(this);
            }
            /// <summary>
            /// 根据窗口大小调整控件大小(对应事件)
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void Form_Resize(object sender, EventArgs e)
            {
                formAutoSize.form_Resize(this);
            }
        #endregion

        private void departmentNoTextBox1_Leave(object sender, EventArgs e)
        {
            PSAPCommon.InputVerifyNotNull(departmentNoTextBox1, pnlEdit);//离开当前文本框时判断是否为空
        }

        private void departmentNameTextBox1_Leave(object sender, EventArgs e)
        {
            PSAPCommon.InputVerifyNotNull(departmentNameTextBox1, pnlEdit);//离开当前文本框时判断是否为空
        }

        private void departmentNoTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            PSAPCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件
        }

        private void departmentNameTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            PSAPCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件
        }

        private void parentDepartmentNoTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            PSAPCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件
        }

        private void bfree1TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            PSAPCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件
        }

        private void bfree2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            PSAPCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件
        }

        private void bfree3TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            PSAPCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件
        }

        private void bfree4TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            PSAPCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件
        }

        private void bfree5TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            PSAPCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件
        }

        private void tsbDGViewExportToCSV_Click(object sender, EventArgs e)
        {
            PSAPCommon.DataGridViewExportToCSV(bS_DepartmentDataGridView, PSAPCommon.GetDateNumber("部门信息"));
        }

        //取消编辑
        private void tsbCancel_Click(object sender, EventArgs e)
        {
            ChangeEnabledState();
            this.bS_DepartmentBindingSource.CancelEdit();
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
            bS_DepartmentBindingNavigator.Enabled = !bS_DepartmentBindingNavigator.Enabled;
            pnlEdit.Enabled = !pnlEdit.Enabled;
            foreach (ToolStripButton b in tsControl.Items)
            {
                b.Enabled = !b.Enabled;
            }
        }

        //关闭窗口
        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //保存更改
        private void tsbSave_Click(object sender, EventArgs e)
        {
            createDateDateTimePicker.Value = DateTime.Now;//建立日期设定为保存时间
            founderTextBox.Text =BSCheckUser.user.EmpName;//获取当前登录用户姓名

            try
            {
                this.Validate();
                this.bS_DepartmentBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dsPSAP);
                ChangeEnabledState();//保存后更新控件状态
            }
            catch (System.Data.NoNullAllowedException )//字段为空
            {

                if (string.IsNullOrEmpty(departmentNoTextBox1.Text))
                {
                    MessageBox.Show("【部门编码】为必填项！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    departmentNoTextBox1.Focus();
                }
                if(string.IsNullOrEmpty(departmentNameTextBox1.Text))
                {
                    MessageBox.Show("【部门名称】为必填项！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    departmentNameTextBox1.Focus();
                }
            }
            catch (System.Data.ConstraintException )//关键字字段值重复
            {
                MessageBox.Show("此部门编码已经存在！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                departmentNoTextBox1.Focus();
            }
            bS_DepartmentDataGridView.Enabled = true;//保存后数据表控件可用
        }

        //删除当前行
        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (bS_DepartmentBindingSource.Current != null)//当前是否有数据
                {
                    if (MessageBox.Show("确实要删除吗?", "确认", MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bS_DepartmentBindingSource.RemoveCurrent();
                    this.tableAdapterManager.UpdateAll(dsPSAP);//更新数据集
                }
            }
              bS_DepartmentDataGridView.Enabled = true;//删除后数据表控件可用
      }

        //新增一条记录
        private void tsbInsert_Click(object sender, EventArgs e)
        {
            //新增时数据表控件不可用
            bS_DepartmentDataGridView.Enabled = false;
            ChangeEnabledState();//更改控件状态
            bS_DepartmentBindingSource.AddNew();
            departmentNoTextBox1.Focus();
        }

        //编辑
        private void tsbEdit_Click(object sender, EventArgs e)
        {
            ChangeEnabledState();//更改控件状态
            departmentNoTextBox1.Focus();
        }
    }
}
