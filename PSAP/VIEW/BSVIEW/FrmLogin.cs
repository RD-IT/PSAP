﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PSAP.DAO.BSDAO;
using PSAP.BLL.BSBLL;
using PSAP.VIEW.BSVIEW;
using PSAP.PSAPCommon;

namespace PSAP
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            //txtUserID.Text = "ADMIN";//测试用
            //txtPassword.Text = "ADMIN";//测试用
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                //this.Close();
                Application.ExitThread();
                //System.Environment.Exit(0);
            }
            catch
            {

            }
        }
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {                
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
                EncryptMD5 en = new EncryptMD5(txtPassword.Text);//实例化EncryptMD5, 加密后值引用en.str2
                if (FrmLoginBLL.CheckUser(txtUserID.Text, en.str2, cboLanguage))// en.str2为加密后密码
                {
                    new SystemHandler().InitializationSystemInfo(txtPassword.Text);

                    if (SystemInfo.IsCheckServer)//启动服务端检测
                    {
                        SocketHandler socket = new SocketHandler();
                        string messageStr = "";
                        if (!socket.ConnectServer(ref messageStr))
                        {
                            MessageHandler.ShowMessageBox(messageStr);
                            return;
                        }
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    txtPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--用户登录错误。", ex);
            }
        }

        //private void txtUserID_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    psapCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件

        //}

        //private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    psapCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件
        //}

        private void btnChangePassword_Click(object sender, EventArgs e)
        {            
            FrmChangePassword f = new FrmChangePassword(txtUserID.Text.Trim());
            f.ShowDialog();
            txtUserID.Focus();

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                FrmLoginBLL.InitCboLanguage(cboLanguage);
                string iniPath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase.TrimEnd('\\') + "\\Config.ini";
                txtUserID.Text = new FileHandler().IniReadValue(iniPath, "System", "LastLoginID");
                if (SystemInfo.LoginSavePwd)
                {
                    string pwdStr = new FileHandler().IniReadValue(iniPath, "System", "LastLoginPwd");
                    if (pwdStr != "")
                        txtPassword.Text = pwdStr;
                }
            }
            catch
            {
                MessageBox.Show(string.Format("数据库连接错误，请检查服务器连接情况！"), "用户登录", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
