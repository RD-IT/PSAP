using PSAP.BLL.BSBLL;
using PSAP.PSAPCommon;
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
            psapCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            psapCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件

        }

        private void txtPasswordNew_KeyPress(object sender, KeyPressEventArgs e)
        {
            psapCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件

        }

        private void txtPasswordNewV_KeyPress(object sender, KeyPressEventArgs e)
        {
            psapCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            EncryptMD5 en = new EncryptMD5(txtPassword.Text);//实例化EncryptMD5, 加密后值引用en.str2
            ///en.str2 = "666";

            if (txtUserID.Text == string.Empty)
            {
                MessageBox.Show(string.Format("用户ID不能为空！"), "用户登录", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserID.Focus();
                return;
            }

            if (txtPassword.Text == string.Empty)
            {
                MessageBox.Show(string.Format("密码不能为空！"), "用户登录", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Focus();
                return;
            }

            if (txtPasswordNew.Text == string.Empty)
            {
                MessageBox.Show(string.Format("新密码不能为空！"), "用户登录", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPasswordNew.Focus();
                return;
            }

            if (txtPasswordNewV.Text == string.Empty)
            {
                MessageBox.Show(string.Format("验证密码不能为空！"), "用户登录", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPasswordNewV.Focus();
                return;
            }

            if (txtPasswordNew.Text != txtPasswordNewV.Text)
            {
                MessageBox.Show(string.Format("新密码和验证密码必须一致！"), "用户登录", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPasswordNew.Focus();
                return;
            }
            FrmLoginBLL.CheckUser(txtUserID.Text, en.str2,txtPasswordNew.Text);// en.str2为加密后密码
        }
    }
}
