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
            txtUserID.Text = "ADMIN";//测试用
            txtPassword.Text = "ADMIN";//测试用
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //this.Close();
            System.Environment.Exit(0);
        }
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            PSAP.EncryptMD5 en = new PSAP.EncryptMD5(txtPassword.Text);//实例化EncryptMD5, 加密后值引用en.str2
            if (txtUserID.Text == string.Empty || txtPassword.Text == string.Empty)
            {
                MessageBox.Show(string.Format("用户ID和密码不能为空！"), "用户登录", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                BSBLL.CheckUser(txtUserID.Text, en.str2);// en.str2为加密后密码

            }
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
