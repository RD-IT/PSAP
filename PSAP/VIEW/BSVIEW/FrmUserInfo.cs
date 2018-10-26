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
using PSAP.PSAPCommon;

namespace PSAP.VIEW.BSVIEW
{
    public partial class FrmUserInfo : DockContent
    {
        public FrmUserInfo()
        {
            InitializeComponent();
            InitEnableState();//初始化控件Enable状态
        }

        private void bS_UserInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bS_UserInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsPSAP);

        }

        private void FrmUserInfo_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dsPSAP.BS_Department”中。您可以根据需要移动或删除它。
            this.bS_DepartmentTableAdapter.Fill(this.dsPSAP.BS_Department);
            // TODO: 这行代码将数据加载到表“dsPSAP.BS_UserInfo”中。您可以根据需要移动或删除它。
            this.bS_UserInfoTableAdapter.Fill(this.dsPSAP.BS_UserInfo);
        }


        //保存更改
        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(loginPwdTextBox.Text))//初始密码与用户ID相同
            {
                EncryptMD5 en = new EncryptMD5(loginIdTextBox.Text);//实例化EncryptMD5
                loginPwdTextBox.Text = en.str2;//加密后的数值
            }
            else
            {
                EncryptMD5 en = new EncryptMD5(loginPwdTextBox.Text);//实例化EncryptMD5
                loginPwdTextBox.Text = en.str2;//加密后的数值
            }
            createDateDateTimePicker.Value = DateTime.Now;//建立日期设定为保存时间
            founderTextBox.Text = FrmLoginDAO.user.EmpName;//获取当前登录用户姓名

            if (string.IsNullOrEmpty(loginIdTextBox.Text))
            {
                MessageBox.Show("【用户ID】为必填项！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loginIdTextBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(empNameTextBox.Text))
            {
                MessageBox.Show("【用户姓名】为必填项！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                empNameTextBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("【部门名称】为必填项！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox1.Focus();
                return;
            }

            try
            {
                this.Validate();
                this.bS_UserInfoBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dsPSAP);
                ChangeEnabledState();//保存后更新控件状态
            }
            catch (System.Data.ConstraintException)//关键字字段值重复
            {
                MessageBox.Show("此用户编码已经存在！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loginIdTextBox.Focus();
            }
            bS_UserInfoDataGridView.Enabled = true;//保存后数据表控件可用
        }

        private void loginIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            psapCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件

        }

        private void empNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            psapCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            psapCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件

        }

        private void tsbDGViewExportToCSV_Click(object sender, EventArgs e)
        {
            psapCommon.DataGridViewExportToCSV(bS_UserInfoDataGridView, psapCommon.GetDateNumber("用户信息"));
        }

        //取消编辑
        private void tsbCancel_Click(object sender, EventArgs e)
        {
            bS_UserInfoDataGridView.Enabled = true;
            ChangeEnabledState();
            this.bS_UserInfoBindingSource.CancelEdit();
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
            bS_UserInfoBindingNavigator.Enabled = !bS_UserInfoBindingNavigator.Enabled;
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

        //关闭窗口
        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //删除当前行
        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (bS_UserInfoBindingSource.Current != null)//当前是否有数据
            {
                if (MessageBox.Show("确实要删除吗，与此用户的权限数据将一起被删除？", "确认", MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FrmUserInfoDAO.DeleteUserInfoCorrelationData((int)bS_UserInfoDataGridView.CurrentRow.Cells[0].Value);
                    bS_UserInfoBindingSource.RemoveCurrent();
                    this.tableAdapterManager.UpdateAll(dsPSAP);//更新数据集
                }
            }
            bS_UserInfoDataGridView.Enabled = true;//删除后数据表控件可用
        }

        //新增一条记录
        private void tsbInsert_Click(object sender, EventArgs e)
        {
            //新增时数据表控件不可用
            bS_UserInfoDataGridView.Enabled = false;
            ChangeEnabledState();//更改控件状态
            bS_UserInfoBindingSource.AddNew();
            loginIdTextBox.Focus();
        }

        //编辑
        private void tsbEdit_Click(object sender, EventArgs e)
        {
            ChangeEnabledState();//更改控件状态
            loginIdTextBox.Focus();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        /// <summary>
        ///  筛选绑定数据源中的数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbQuery_Click(object sender, EventArgs e)
        {
            string[,] strsQueryTmp = new string[3, 2];
            DataTable[] dt = new DataTable[strsQueryTmp.GetLongLength(0)];
            strsQueryTmp[0, 0] = "用户ID";
            strsQueryTmp[1, 0] = "用户姓名";
            strsQueryTmp[2, 0] = "部门名称";
            strsQueryTmp[0, 1] = "txt";
            strsQueryTmp[1, 1] = "txt";
            strsQueryTmp[2, 1] = "cbo";
            dt[2] = BSCommon.getDepartmentList();
            FrmQueryCondition f = new FrmQueryCondition(strsQueryTmp, dt);
            f.ShowDialog();

            string strFilter;
            strFilter = "LoginId like '*" + strsQueryTmp[0, 1] + "*' " +
                "and EmpName like '*" + strsQueryTmp[1, 1] + "*' " +
                "and departmentNo like '*" + strsQueryTmp[2, 1] + "*'";
            this.bS_UserInfoBindingSource.Filter = strFilter;
        }
    }
}
