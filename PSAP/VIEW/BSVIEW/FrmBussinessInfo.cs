using PSAP.DAO.BSDAO;
using PSAP.PSAPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            BindingDatatSource();
        }


        public void BindingDatatSource()
        {
            
            dataSet1=FrmBussinessInfoDAO.InitDataSet();
            gdBussinessBaseInfo.DataSource = dataSet1.Tables["BS_BussinessBaseInfo"];
            bussinessBaseNoTextBox.DataBindings.Add("Text",dataSet1.Tables["BS_BussinessDetailInfo"],"BussinessBaseNo");
            companyLRTextBox.DataBindings.Add("Text", dataSet1.Tables["BS_BussinessDetailInfo"], "CompanyLR");
            companyAddressTextBox.DataBindings.Add("Text",dataSet1.Tables["BS_BussinessDetailInfo"],"CompanyAddress");
        }

        /// <summary>
        /// 初始化控件Enable状态
        /// </summary>
        private void InitEnableState()
        {
            pnlEdit.Enabled = false;
            pnlEdit1.Enabled = false;
            gdvBussinessBaseInfo.OptionsBehavior.Editable =false;//
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
            pnlEdit.Enabled = !pnlEdit.Enabled;
            pnlEdit1.Enabled = !pnlEdit1.Enabled;
            gdvBussinessBaseInfo.OptionsBehavior.Editable  = !gdvBussinessBaseInfo.OptionsBehavior.Editable;//
            tsbSave.Enabled = !tsbSave.Enabled;
            tsbCancel.Enabled = !tsbCancel.Enabled;
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

        private void gdBussinessBaseInfo_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void gdBussinessBaseInfo_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            //int index = bS_BussinessDetailInfoBindingSource.Find("BussinessBaseNo",gdvBussinessBaseInfo.GetRowCellValue(gdvBussinessBaseInfo.GetDataRow(gdvBussinessBaseInfo.FocusedRowHandle).Field<>,"fgf"));
            //if (index != -1)
            //{
            //    bS_BussinessDetailInfoBindingSource.Position = index;//定位BindingSource
            //}

            //if (string.IsNullOrEmpty(departmentNameTextBox1.Text))
            //{
            //    MessageBox.Show("【部门名称】为必填项！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    //departmentNameTextBox1.Focus();
            //    return;
            //}

            try
            {
                //this.Validate();
                //this.bS_BussinessBaseInfoBindingSource.EndEdit();
                //this.tableAdapterManager.UpdateAll(this.dsPSAP);
                //ChangeEnabledState();//保存后更新控件状态
            }

            catch (System.Data.ConstraintException)//关键字字段值重复
            {
                MessageBox.Show("此部门编码已经存在！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //departmentNoTextBox1.Focus();
            }
            //gdBussinessBaseInfo.Enabled = true;//保存后数据表控件可用

        }
        private int editFlag = 0; //1:新增
        private void gdBussinessBaseInfo_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            editFlag = 1;

        }

        private void bussinessBaseNoTextBox_TextChanged(object sender, EventArgs e)
        {
           // bS_BussinessDetailInfoBindingSource.EndEdit();
            //tableAdapterManager.UpdateAll(dsPSAP);

        }

        private void bS_BussinessBaseInfoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            ChangeEnabledState();//更改控件状态
                                 //bS_BussinessBaseInfoBindingSource.AddNew();
                                 //bS_BussinessDetailInfoBindingSource.AddNew();
                                 // bS_BussinessFinancialInfoBindingSource.AddNew();
            dataSet1.Tables["BS_BussinessBaseInfo"].Rows.Add();

            //dataSet1.Tables["BS_BussinessDetailInfo"].Rows.Add();
            dataSet1.Tables["BS_BussinessDetailInfo"].NewRow();
            gdBussinessBaseInfo.Focus();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            ChangeEnabledState();//更改控件状态
            gdBussinessBaseInfo.Focus();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            //if (bS_RoleBindingSource.Current != null)//当前是否有数据
            //{
            //    if (MessageBox.Show("确实要删除吗，与此【角色】相关的权限将一起被删除?", "确认", MessageBoxButtons.YesNo,
            //                                MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        //先删除对此数据有依赖关系的相关数数
            //        FrmRightDAO.DeleteRoleCorrelationData(roleNoTextBox.Text);//删除与角色相关数据

            //        bS_RoleBindingSource.RemoveCurrent();
            //        this.tableAdapterManager.UpdateAll(dsPSAP);//更新数据集
            //    }
            //}
            //dgvRoleList.Enabled = true;//删除后数据表控件可用

        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(roleNoTextBox.Text))
            {
               // MessageBox.Show("【角色编码】为必填项！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
               /// gdBussinessBaseInfo.Focus();
                //return;
            }
           // if (string.IsNullOrEmpty(roleNameTextBox.Text))
            {
               // MessageBox.Show("【角色名称】为必填项！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
               // gdBussinessBaseInfo.Focus();
               // return;
            }

            try
            {
               // Validate();
                //bS_BussinessBaseInfoBindingSource.EndEdit();
               // bS_BussinessDetailInfoBindingSource.EndEdit();
               // bS_BussinessFinancialInfoBindingSource.EndEdit();
                //tableAdapterManager.UpdateAll(this.dsPSAP);


                ChangeEnabledState();//保存后更新控件状态

                using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
                {
                    conn.Open();
                    using (SqlTransaction trans = conn.BeginTransaction())
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand("", conn, trans);
                            cmd.CommandText = "select Top 0 * from BS_BussinessDetailInfo ";
                            SqlDataAdapter adp = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            adp.Fill(dt);
                            UpdateDataTable(adp, dataSet1.Tables["BS_BussinessDetailInfo"]);


                             cmd = new SqlCommand("", conn, trans);
                            cmd.CommandText = "select Top 0 * from BS_BussinessBaseInfo ";
                             adp = new SqlDataAdapter(cmd);
                             dt = new DataTable();
                            adp.Fill(dt);
                            UpdateDataTable(adp, dataSet1.Tables["BS_BussinessBaseInfo"]);


                            trans.Commit();
                           dataSet1.Tables["BS_BussinessBaseInfo"].AcceptChanges();
                           dataSet1.Tables["BS_BussinessDetailInfo"].AcceptChanges();

                        }
                        catch (Exception ex)
                        {
                            trans.Rollback();
                            throw;
                        }
                    }
                }

            }
            catch (System.Data.ConstraintException)//关键字字段值重复
            {
                MessageBox.Show("此角色【部门编码】已经存在！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gdBussinessBaseInfo.Focus();
            }

            catch (System.Data.SqlClient.SqlException)//外键约束
            {
                MessageBox.Show("此角色【部门编码】已经被分配权限，不允许修改！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //执行一遍取消操作
            }
        }

        public static void UpdateDataTable(SqlDataAdapter dataAdapter, DataTable dataTable)
        {
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            commandBuilder.ConflictOption = ConflictOption.OverwriteChanges;
            dataAdapter.UpdateCommand = commandBuilder.GetUpdateCommand(true);
            dataAdapter.InsertCommand = commandBuilder.GetInsertCommand(true);
            dataAdapter.DeleteCommand = commandBuilder.GetDeleteCommand();

            dataAdapter.Update(dataTable);
        }

        //        if (editFlag == 1
        //    && !string.IsNullOrEmpty(gdvBussinessBaseInfo.CurrentRow.Cells[1].Value.ToString())
        //    && !string.IsNullOrEmpty(gdvBussinessBaseInfo.CurrentRow.Cells[2].Value.ToString()))
        //{
        //    gdvBussinessBaseInfo.GetRowCellValue(gdvBussinessBaseInfo.row,);
        //    // bS_BussinessBaseInfoBindingSource.EndEdit();
        //    // tableAdapterManager.UpdateAll(dsPSAP);

        //    bS_BussinessDetailInfoBindingSource.AddNew();
        //    bS_BussinessFinancialInfoBindingSource.AddNew();

        //    bussinessBaseNoTextBox.Text = gdBussinessBaseInfo.CurrentRow.Cells[1].Value.ToString();
        //    bussinessBaseNoTextBox1.Text = gdBussinessBaseInfo.CurrentRow.Cells[1].Value.ToString();
        //    editFlag = 0;

        //    bS_BussinessDetailInfoBindingSource.EndEdit();
        //    //tableAdapterManager.UpdateAll(dsPSAP);


        //    bS_BussinessFinancialInfoBindingSource.EndEdit();
        //    tableAdapterManager.UpdateAll(dsPSAP);
        //}
    }
}

