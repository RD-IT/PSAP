using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PSAP.VIEW.BSVIEW
{
    public partial class FrmDepartment : Form
    {
        public FrmDepartment()
        {
            InitializeComponent();
        }

        private void bS_DepartmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bS_DepartmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsPSAP);

        }

        private void FrmDepartment_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dsPSAP.BS_Department”中。您可以根据需要移动或删除它。
            this.bS_DepartmentTableAdapter.Fill(this.dsPSAP.BS_Department);
            // TODO: 这行代码将数据加载到表“dsPSAP.BS_Department”中。您可以根据需要移动或删除它。
            this.bS_DepartmentTableAdapter.Fill(this.dsPSAP.BS_Department);
            // TODO: 这行代码将数据加载到表“dsPSAP.BS_Department”中。您可以根据需要移动或删除它。
            this.bS_DepartmentTableAdapter.Fill(this.dsPSAP.BS_Department);

        }

        private void bS_DepartmentBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            createDateDateTimePicker.Value = DateTime.Now;//建立日期设定为保存时间
            founderTextBox.Text =PSAPCommon.LoginInfo["EmpName"].ToString();
            this.Validate();
            this.bS_DepartmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsPSAP);
            bS_DepartmentDataGridView.Enabled =true;


        }

         private void departmentNoTextBox1_Leave(object sender, EventArgs e)
        {
            PSAPCommon.InputVerifyNotNull(departmentNoTextBox1, panel1);
        }

        private void departmentNameTextBox1_Leave(object sender, EventArgs e)
        {
            PSAPCommon.InputVerifyNotNull(departmentNameTextBox1, panel1);
        }

       //public static Label LblInfo = new Label();
       //public static void InputVerifyNull(TextBox TargetControl,Panel TargetContainer)
       // {
       //     if (string.IsNullOrEmpty(TargetControl.Text))
       //     {
       //         LblInfo.AutoSize = true;
       //         LblInfo.Text = "不能为空！";
       //         LblInfo.BackColor = Color.Yellow;
       //         LblInfo.Location = new Point(TargetControl.Left + TargetControl.Width + 10, TargetControl.Top);
       //         LblInfo.Font = new Font(LblInfo.Font.Name, 14.25f);
       //         TargetContainer.Controls.Add(LblInfo);
       //         LblInfo.Visible = true;
       //         TargetControl.Focus();
       //     }
       //     else
       //     {
       //         LblInfo.Visible = false;

       //     }
       // }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bS_DepartmentDataGridView.Enabled = false;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            bS_DepartmentDataGridView.Enabled = true;
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           PSAPCommon.DataGridViewExportToCSV(bS_DepartmentDataGridView,PSAPCommon.GetDateNumber("部门信息"));
        }
    }
}
