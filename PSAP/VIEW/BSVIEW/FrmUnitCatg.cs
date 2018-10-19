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
    public partial class FrmUnitCatg :DockContent 
    {
        public FrmUnitCatg()
        {
            InitializeComponent();
            InitEnableState();//初始化控件Enable状态

        }

        private void FrmUnitCatg_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dsPSAP.BS_UnitCatg”中。您可以根据需要移动或删除它。
            this.bS_UnitCatgTableAdapter.Fill(this.dsPSAP.BS_UnitCatg);

        }

        private void unitNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            psapCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件

        }

        private void unitNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            psapCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件

        }

        private void unitDescriptionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            psapCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件

        }

        private void tsbDGViewExportToCSV_Click(object sender, EventArgs e)
        {
            psapCommon.DataGridViewExportToCSV(bS_UnitCatgDataGridView, psapCommon.GetDateNumber("计量单位"));

        }

        private void tsbCancel_Click(object sender, EventArgs e)
        {
            bS_UnitCatgDataGridView.Enabled = true;
            ChangeEnabledState();
            this.bS_UnitCatgBindingSource.CancelEdit();

        }
        /// <summary>
        /// 初始化控件Enable状态
        /// </summary>
        private void InitEnableState()
        {
            bS_UnitCatgDataGridView.Enabled = true;
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

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            //createDateDateTimePicker.Value = DateTime.Now;//建立日期设定为保存时间
            //founderTextBox.Text = BSCheckUser.user.EmpName;//获取当前登录用户姓名
            if (string.IsNullOrEmpty(unitNoTextBox.Text))
            {
                MessageBox.Show("【单位编码】为必填项！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                unitNoTextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(unitNameTextBox.Text))
            {
                MessageBox.Show("【单位名称】为必填项！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                unitNameTextBox.Focus();
                return;
            }

            try
            {
                this.Validate();
                this.bS_UnitCatgBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dsPSAP);
                ChangeEnabledState();//保存后更新控件状态
            }
            catch (System.Data.ConstraintException)//关键字字段值重复
            {
                MessageBox.Show("此单位编码已经存在！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                unitNoTextBox.Focus();
            }
            bS_UnitCatgDataGridView.Enabled = true;//保存后数据表控件可用
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (bS_UnitCatgBindingSource.Current != null)//当前是否有数据
            {
                if (MessageBox.Show("确实要删除吗?", "确认", MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bS_UnitCatgBindingSource.RemoveCurrent();
                    this.tableAdapterManager.UpdateAll(dsPSAP);//更新数据集
                }
            }
            bS_UnitCatgDataGridView.Enabled = true;//删除后数据表控件可用
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            //新增时数据表控件不可用
            bS_UnitCatgDataGridView.Enabled = false;
            ChangeEnabledState();//更改控件状态
            bS_UnitCatgBindingSource.AddNew();
            unitNoTextBox.Focus();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            ChangeEnabledState();//更改控件状态
            unitNoTextBox.Focus();

        }

        private void tsbQuery_Click(object sender, EventArgs e)
        {
            string[,] strsQueryTmp = new string[2, 2];
            DataTable[] dt = new DataTable[strsQueryTmp.GetLongLength(0)];
            strsQueryTmp[0, 0] = "单位编号";
            strsQueryTmp[1, 0] = "单位名称";
            strsQueryTmp[0, 1] = "txt";
            strsQueryTmp[1, 1] = "txt";
            FrmQueryCondition f = new FrmQueryCondition(strsQueryTmp, dt);
            f.ShowDialog();

            string strFilter;
            strFilter = "UnitNo like '*" + strsQueryTmp[0, 1] + "*' " +
                "and UnitName like '*" + strsQueryTmp[1, 1] + "*'";
            this.bS_UnitCatgBindingSource.Filter = strFilter;

        }
    }
}
