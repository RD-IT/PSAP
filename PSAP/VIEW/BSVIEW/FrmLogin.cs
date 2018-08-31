using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PSAP.DAO.BSDAO;
using PSAP.BLL.BSBLL;

namespace PSAP
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            txtUserID.Text = "18";//测试用
            txtPassword.Text = "1";//测试用
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //this.Close();
            System.Environment.Exit(0);
        }
        /// <summary>
        /// 用户登陆
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            BSBLL.CheckUser(txtUserID, txtPassword);

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            PSAPCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            PSAPCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件
        }
    }
}
