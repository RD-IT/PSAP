using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PSAP.DAO.BSDAO;
using PSAP.PSAPCommon;


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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sqlString = "select * from BS_Department";
            if (txtUserID.Text == string.Empty || txtPassword.Text == string.Empty)
            {
                MessageBox.Show("用户ID和密码不能为空！", "提示");
            }
            else
            {
                sqlString = "select * from BS_Employee where loginID='" + txtUserID.Text + "' and loginPwd='" + txtPassword.Text + "'";
                if (BaseSQL.Exists(sqlString))
                {
                    this.Close();
                    //FrmMain frmMain = new FrmMain();
                    //frmMain.Show();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！");
                }
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUserID_KeyDown(object sender, KeyEventArgs e)
        {
            PSAPCommon.PSAPCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            PSAPCommon.PSAPCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件
        }
    }
}
