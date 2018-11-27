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
        }

        private void bS_BussinessBaseInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bS_BussinessBaseInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsPSAP);

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
    }
}
