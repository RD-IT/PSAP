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
    public partial class FrmChangePassword : Form
    {
        public FrmChangePassword()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            PSAPCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            PSAPCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件

        }

        private void txtPasswordNew_KeyPress(object sender, KeyPressEventArgs e)
        {
            PSAPCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件

        }

        private void txtPasswordNewV_KeyPress(object sender, KeyPressEventArgs e)
        {
            PSAPCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }
    }
}
