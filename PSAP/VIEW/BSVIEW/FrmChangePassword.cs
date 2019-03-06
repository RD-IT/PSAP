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
            PSAP.BLL.BSBLL.BSBLL.language(this);
        }

        public FrmChangePassword(string loginID)
        {
            InitializeComponent();
            PSAP.BLL.BSBLL.BSBLL.language(this);
            txtUserID.Text = loginID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            EncryptMD5 en = new EncryptMD5(txtPassword.Text);//实例化EncryptMD5, 加密后值引用en.str2

            if (txtUserID.Text == string.Empty)
            {
                //MessageBox.Show(string.Format("用户ID不能为空。"), "用户登录", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(string.Format(tsmiYhidbnwk.Text), tsmiYhdl.Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtUserID.Focus();
                return;
            }

            if (txtPassword.Text == string.Empty)
            {
                //MessageBox.Show(string.Format("密码不能为空。"), "用户登录", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(string.Format(tsmiMm.Text), tsmiYhdl.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Focus();
                return;
            }

            if (txtPasswordNew.Text == string.Empty)
            {
                //MessageBox.Show(string.Format("新密码不能为空。"), "用户登录", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(string.Format(tsmiXmm.Text), tsmiYhdl.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPasswordNew.Focus();
                return;
            }

            if (txtPasswordNewV.Text == string.Empty)
            {
                //MessageBox.Show(string.Format("验证密码不能为空。"), "用户登录", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(string.Format(tsmiYzmm.Text), tsmiYhdl.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPasswordNewV.Focus();
                return;
            }

            if (txtPasswordNew.Text != txtPasswordNewV.Text)
            {
                //MessageBox.Show(string.Format("新密码和验证密码必须一致。"), "用户登录", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(string.Format(tsmiXmmhyz.Text), tsmiYhdl.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPasswordNew.Focus();
                return;
            }
            FrmLoginBLL.CheckUserChangePassword(txtUserID.Text, en.str2, txtPasswordNew.Text);// en.str2为加密后密码
        }
    }
}
