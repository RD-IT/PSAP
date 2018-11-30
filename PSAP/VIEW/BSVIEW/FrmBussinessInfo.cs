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

        private BindingSource bsBase;
        private BindingSource bsDetail;
        private BindingSource bsFina;
        /// <summary>
        /// 绑定数据源建立关联关系
        /// </summary>
        public void BindingDatatSource()
        {
            dataSet1 = FrmBussinessInfoDAO.InitDataSet();
            /*
            DataColumn ParentBussinessBaseNo = dataSet1.Tables["BS_BussinessBaseInfo"].Columns["BussinessBaseNo"];
            DataColumn Child1BussinessBaseNo = dataSet1.Tables["BS_BussinessDetailInfo"].Columns["BussinessBaseNo"];
            DataColumn Child2BussinessBaseNo = dataSet1.Tables["BS_BussinessFinancialInfo"].Columns["BussinessBaseNo"];
            DataRelation relation1 =
                new DataRelation("FK_Base_Detail", ParentBussinessBaseNo, Child1BussinessBaseNo);
            dataSet1.Relations.Add(relation1);
            DataRelation relation2 =
                new DataRelation("FK_Base_Fina", ParentBussinessBaseNo, Child2BussinessBaseNo);
            dataSet1.Relations.Add(relation2);
            */
            bsBase = new BindingSource();
            bsDetail = new BindingSource();
            bsFina = new BindingSource();
            bsBase.DataSource = dataSet1;
            bsBase.DataMember = "BS_BussinessBaseInfo";
            bsDetail.DataSource = dataSet1;
            bsDetail.DataMember = "BS_BussinessDetailInfo";
            bsFina.DataSource = dataSet1;
            bsFina.DataMember = "BS_BussinessFinancialInfo";
            /*
            bsDetail.DataSource = bsBase;
            bsDetail.DataMember = "FK_Base_Detail";
            bsFina.DataSource = bsBase;
            bsFina.DataMember = "FK_Base_Fina";
            */
            //grid
            gdBussinessBaseInfo.DataSource = bsBase;
            //BS_BussinessDetailInfo
            bussinessBaseNoTextBox.DataBindings.Add("Text", bsDetail, "BussinessBaseNo");
            companyLRTextBox.DataBindings.Add("Text", bsDetail, "CompanyLR");
            companyAddressTextBox.DataBindings.Add("Text", bsDetail, "CompanyAddress");
            zipCodeTextBox.DataBindings.Add("Text", bsDetail, "zipCode");
            phoneNoTextBox.DataBindings.Add("Text", bsDetail, "phoneNo");
            faxNoTextBox.DataBindings.Add("Text", bsDetail, "faxNo");
            e_mailTextBox.DataBindings.Add("Text", bsDetail, "e_mail");
            webSiteTextBox.DataBindings.Add("Text", bsDetail, "webSite");
            cboCountryCode.DataBindings.Add("Text", bsDetail, "CountryCode");
            //BS_BussinessFinancialInfo
            bussinessBaseNoTextBox1.DataBindings.Add("Text", bsFina, "bussinessBaseNo");
            bussinessLicenseTextBox.DataBindings.Add("Text", bsFina, "bussinessLicense");
            bankAccoutTextBox.DataBindings.Add("Text", bsFina, "bankAccout");
            bankAddressTextBox.DataBindings.Add("Text", bsFina, "bankAddress");


        }

        /// <summary>
        /// 初始化控件Enable状态
        /// </summary>
        private void InitEnableState()
        {
            pnlEdit.Enabled = false;
            pnlEdit1.Enabled = false;
            gdvBussinessBaseInfo.OptionsBehavior.Editable = false;//
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
            gdvBussinessBaseInfo.OptionsBehavior.Editable = !gdvBussinessBaseInfo.OptionsBehavior.Editable;//
            foreach (ToolStripButton b in tsControl.Items)
            {
                b.Enabled = !b.Enabled;
            }

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
            // TODO: 这行代码将数据加载到表“dsPSAP.BS_CountryCodeManagement”中。您可以根据需要移动或删除它。
            this.bS_CountryCodeManagementTableAdapter.Fill(this.dsPSAP.BS_CountryCodeManagement);
            // TODO: 这行代码将数据加载到表“dsPSAP.BS_BussinessCategory”中。您可以根据需要移动或删除它。
            this.bS_BussinessCategoryTableAdapter.Fill(this.dsPSAP.BS_BussinessCategory);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEditOrBrowse_Click(object sender, EventArgs e)
        {
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

        }

        private void gdBussinessBaseInfo_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
        }

        private void bussinessBaseNoTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void bS_BussinessBaseInfoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private int editFlag = 0; //1:新增
        private void tsbAdd_Click(object sender, EventArgs e)
        {
            ChangeEnabledState();//更改控件状态
            bsBase.AddNew();
            bsDetail.AddNew();
            bsFina.AddNew();
            gdBussinessBaseInfo.Focus();
            editFlag = 1;
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            ChangeEnabledState();//更改控件状态
            gdBussinessBaseInfo.Focus();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (bsBase.Current != null)//当前是否有数据
            {
                if (MessageBox.Show("确实要删除吗，与此【角色】相关的权限将一起被删除?", "确认", MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //删除相关数据
                    FrmBussinessInfoDAO.DeleteBussinessCorrelationData(gdvBussinessBaseInfo.GetRowCellValue(gdvBussinessBaseInfo.GetSelectedRows()[0], "BussinessBaseNo").ToString());//删除相关数据
                                                                                                                                                                                      //this.tableAdapterManager.UpdateAll(dsPSAP);//更新数据集
                   // dataSet1 = FrmBussinessInfoDAO.InitDataSet();

                }
            }

        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(roleNoTextBox.Text))
            //{
            //    MessageBox.Show("【角色编码】为必填项！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    gdBussinessBaseInfo.Focus();
            //    return;
            //}
            // if (string.IsNullOrEmpty(roleNameTextBox.Text))
            //{
            //     MessageBox.Show("【角色名称】为必填项！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //     gdBussinessBaseInfo.Focus();
            //     return;
            //}
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {

                if (editFlag == 1
                    && !string.IsNullOrEmpty(gdvBussinessBaseInfo.GetRowCellValue(gdvBussinessBaseInfo.GetSelectedRows()[0], "BussinessBaseNo").ToString())
                    && !string.IsNullOrEmpty(gdvBussinessBaseInfo.GetRowCellValue(gdvBussinessBaseInfo.GetSelectedRows()[0], "BussinessBaseText").ToString()))
                {
                    bussinessBaseNoTextBox.Text = gdvBussinessBaseInfo.GetRowCellValue(gdvBussinessBaseInfo.GetSelectedRows()[0], "BussinessBaseNo").ToString();
                    bussinessBaseNoTextBox1.Text = gdvBussinessBaseInfo.GetRowCellValue(gdvBussinessBaseInfo.GetSelectedRows()[0], "BussinessBaseNo").ToString();
                }
                Validate();
                bsBase.EndEdit();
                bsDetail.EndEdit();
                bsFina.EndEdit();
                conn.Open();
                // using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn);
                        cmd.CommandText = "select Top 0 * from BS_BussinessBaseInfo ";
                        SqlDataAdapter adp = new SqlDataAdapter(cmd);
                        //   adp.SelectCommand.Transaction = trans;
                        DataTable dt = new DataTable();
                        adp.Fill(dt);
                        UpdateDataTable(adp, dataSet1.Tables["BS_BussinessBaseInfo"]);

                        cmd.CommandText = "select Top 0 * from BS_BussinessDetailInfo ";
                        SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
                        //  adp1.SelectCommand.Transaction = trans;
                        dt = new DataTable();
                        adp1.Fill(dt);
                        UpdateDataTable(adp1, dataSet1.Tables["BS_BussinessDetailInfo"]);

                        cmd.CommandText = "select Top 0 * from BS_BussinessFinancialInfo ";
                        SqlDataAdapter adp2 = new SqlDataAdapter(cmd);
                        // adp2.SelectCommand.Transaction = trans;
                        dt = new DataTable();
                        adp2.Fill(dt);
                        UpdateDataTable(adp2, dataSet1.Tables["BS_BussinessFinancialInfo"]);
                        // trans.Commit();

                        ChangeEnabledState();//保存后更新控件状态
                        editFlag = 0;
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

        private void gdvBussinessBaseInfo_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
        }

        private void gdvBussinessBaseInfo_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            int index = bsDetail.Find("BussinessBaseNo", gdvBussinessBaseInfo.GetRowCellValue(gdvBussinessBaseInfo.GetSelectedRows()[0], "BussinessBaseNo").ToString());
            if (index != -1)
            {
                bsDetail.Position = index;//定位BindingSource
                                          // bsFina.Position = index;//定位BindingSource

            }

            index = bsFina.Find("BussinessBaseNo", gdvBussinessBaseInfo.GetRowCellValue(gdvBussinessBaseInfo.GetSelectedRows()[0], "BussinessBaseNo").ToString());
            if (index != -1)
            {
                bsFina.Position = index;//定位BindingSource

            }

            //if (editFlag == 1)
            //{
            //    bsBase.CancelEdit();
            //    bsDetail.CancelEdit();
            //    bsFina.CancelEdit();
            //    ChangeEnabledState();
            //    editFlag = 0;
            //}



        }

        private void tsbCancel_Click(object sender, EventArgs e)
        {
            bsBase.CancelEdit();
            bsDetail.CancelEdit();
            bsFina.CancelEdit();
            ChangeEnabledState();
            editFlag = 0;
        }
    }
}

