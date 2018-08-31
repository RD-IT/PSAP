using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PSAP.BLL.BSBLL;

namespace PSAP.VIEW.BSVIEW
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Text = "天津容大机电有限公司   [" + PSAPCommon.LoginInfo["DepartmentName"]+" - "+PSAPCommon.LoginInfo["EmpName"]+"]";
            //FrmLogin frmLogin = new FrmLogin();
            //frmLogin.ShowDialog();
        }

        private void 部门信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDepartment f =new FrmDepartment();
            f.MdiParent = this.ParentForm;
            f.Show();
        }
    }
}
