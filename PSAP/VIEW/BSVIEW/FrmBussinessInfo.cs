using PSAP.PSAPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PSAP.VIEW.BSVIEW
{
    public partial class FrmBussinessInfo : DockContent
    {
        public FrmBussinessInfo()
        {
            InitializeComponent();
            InitEnableState();//初始化控件Enable状态
        }

        /// <summary>
        /// 初始化控件Enable状态
        /// </summary>
        private void InitEnableState()
        {
            pnlEdit.Enabled = false;
            pnlEdit1.Enabled = false;
            dgveBussinessBaseInfo.ReadOnly = true;
        }

        /// <summary>
        /// panel（pnlEdit）的Enabled属性设置为“False”，表示最开始panel里面的控件都设置为不可编辑状态
        /// 保存了、取消初始Enable为"False"
        /// 将数据导航条、GroupBox、新增、修改、删除、保存、取消的Enabled状态取反
        /// </summary>
        private void ChangeEnabledState()
        {
            pnlEdit.Enabled = !pnlEdit.Enabled;
            pnlEdit1.Enabled = !pnlEdit1.Enabled;
            dgveBussinessBaseInfo.ReadOnly = false;

            //检测窗口状态：编辑="EDIT"，浏览=""
            if (((Label)this.Controls["lblEditFlag"]).Text == "")
            {
                ((Label)this.Controls["lblEditFlag"]).Text = "EDIT";
            }
            else
            {
                ((Label)this.Controls["lblEditFlag"]).Text = "";
            }

        }

        //private void bS_BussinessBaseInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.bS_BussinessBaseInfoBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.dsPSAP);

        //}

        private void FrmBussinessInfo_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dsPSAP.BS_BussinessCategory”中。您可以根据需要移动或删除它。
            this.bS_BussinessCategoryTableAdapter.Fill(this.dsPSAP.BS_BussinessCategory);
            // TODO: 这行代码将数据加载到表“dsPSAP.BS_CountryCodeManagement”中。您可以根据需要移动或删除它。
            this.bS_CountryCodeManagementTableAdapter.Fill(this.dsPSAP.BS_CountryCodeManagement);
            // TODO: 这行代码将数据加载到表“dsPSAP.BS_BussinessFinancialInfo”中。您可以根据需要移动或删除它。
            this.bS_BussinessFinancialInfoTableAdapter.Fill(this.dsPSAP.BS_BussinessFinancialInfo);
            // TODO: 这行代码将数据加载到表“dsPSAP.BS_BussinessDetailInfo”中。您可以根据需要移动或删除它。
            this.bS_BussinessDetailInfoTableAdapter.Fill(this.dsPSAP.BS_BussinessDetailInfo);
            // TODO: 这行代码将数据加载到表“dsPSAP.BS_BussinessBaseInfo”中。您可以根据需要移动或删除它。
            this.bS_BussinessBaseInfoTableAdapter.Fill(this.dsPSAP.BS_BussinessBaseInfo);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEditOrBrowse_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Tag.ToString() == "0")
            {
                ((Button)sender).Tag = 1;
            }
            else
            {
                ((Button)sender).Tag = 0;
            }

            if (((Button)sender).Tag.ToString() == "0")
            {
                ((Button)sender).Text = "进入浏览状态";
                ChangeEnabledState();
            }
            else
            {
                ((Button)sender).Text = "进入编辑状态";
                ChangeEnabledState();
            }
        }

        private void bussinessBaseNoTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            psapCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件
        }

        private void bussinessLicenseTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            psapCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件

        }

        private void bankAccoutTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            psapCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件

        }

        private void bankAddressTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            psapCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件

        }

        private void bussinessBaseNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            psapCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件

        }

        private void companyLRTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            psapCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件

        }

        private void companyAddressTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            psapCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件

        }

        private void zipCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            psapCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件

        }

        private void phoneNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            psapCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件

        }

        private void faxNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            psapCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件

        }

        private void e_mailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            psapCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件

        }

        private void webSiteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            psapCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件

        }

        private void cboCountryCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            psapCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件

        }

        private void dgveBussinessBaseInfo_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (editFlag == 1
                && !string.IsNullOrEmpty(dgveBussinessBaseInfo.CurrentRow.Cells[1].Value.ToString())
                && !string.IsNullOrEmpty(dgveBussinessBaseInfo.CurrentRow.Cells[2].Value.ToString()))
            {
               // bS_BussinessBaseInfoBindingSource.EndEdit();
               // tableAdapterManager.UpdateAll(dsPSAP);

                bS_BussinessDetailInfoBindingSource.AddNew();
                bS_BussinessFinancialInfoBindingSource.AddNew();

                bussinessBaseNoTextBox.Text = dgveBussinessBaseInfo.CurrentRow.Cells[1].Value.ToString();
                bussinessBaseNoTextBox1.Text = dgveBussinessBaseInfo.CurrentRow.Cells[1].Value.ToString();
                editFlag = 0;

                bS_BussinessDetailInfoBindingSource.EndEdit();
                //tableAdapterManager.UpdateAll(dsPSAP);


                bS_BussinessFinancialInfoBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(dsPSAP);
            }

            
        }

        private void dgveBussinessBaseInfo_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            int index = bS_BussinessDetailInfoBindingSource.Find("BussinessBaseNo", dgveBussinessBaseInfo.CurrentRow.Cells[1].Value.ToString());
            if (index != -1)
            {
                bS_BussinessDetailInfoBindingSource.Position = index;//定位BindingSource
            }


            //if (string.IsNullOrEmpty(departmentNameTextBox1.Text))
            //{
            //    MessageBox.Show("【部门名称】为必填项！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    //departmentNameTextBox1.Focus();
            //    return;
            //}

            try
            {
                this.Validate();
                //this.bS_BussinessBaseInfoBindingSource.EndEdit();
                //this.tableAdapterManager.UpdateAll(this.dsPSAP);
                //ChangeEnabledState();//保存后更新控件状态
            }

            catch (System.Data.ConstraintException)//关键字字段值重复
            {
                MessageBox.Show("此部门编码已经存在！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //departmentNoTextBox1.Focus();
            }
            //dgveBussinessBaseInfo.Enabled = true;//保存后数据表控件可用

        }
        private int editFlag=0; //1:新增
        private void dgveBussinessBaseInfo_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            editFlag = 1;

        }

        private void bussinessBaseNoTextBox_TextChanged(object sender, EventArgs e)
        {
            bS_BussinessDetailInfoBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(dsPSAP);

        }
    }
}

