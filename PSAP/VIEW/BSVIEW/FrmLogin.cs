using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PSAP.DAO.BSDAO;
using PSAP.BLL.BSBLL;
using PSAP.VIEW.BSVIEW;
using PSAP.PSAPCommon;
using System.Configuration;

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
                    //MessageBox.Show(string.Format("用户ID不能为空。"), "用户登录", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(string.Format(tsmiYhidbnwk.Text), tsmiYhdl.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUserID.Focus();
                    return;
                }

                if (txtPassword.Text == string.Empty)
                {
                    //MessageBox.Show(string.Format("密码不能为空。"), "用户登录", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(string.Format(tsmiMmbnwk.Text), tsmiYhdl.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                    string iniPath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase.TrimEnd('\\') + "\\Config.ini";
                    new FileHandler().IniWriteValue(iniPath, "System", "LastLanguage", cboLanguage.SelectedValue.ToString());

                    //Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    // cfa.AppSettings.Settings["last"].Value = "111";
                    //            cfa.Save();

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
                //ExceptionHandler.HandleException(this.Text + "--用户登录错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiYhdlcw.Text, ex);
            }
        }

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
                PSAP.BLL.BSBLL.BSBLL.language(this);
                string iniPath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase.TrimEnd('\\') + "\\Config.ini";
                //txtUserID.Text = new FileHandler().IniReadValue(iniPath, "System", "LastLoginID");
                txtUserID.Text = new GetLangusgeSet().IniReadValue1(iniPath, "System", "LastLoginID");

                //cboLanguage.SelectedValue = new FileHandler().IniReadValue(iniPath, "System", "LastLanguage");
                cboLanguage.SelectedValue = new GetLangusgeSet().IniReadValue1(iniPath, "System", "LastLanguage");

                if (SystemInfo.LoginSavePwd)
                {
                    //string pwdStr = new FileHandler().IniReadValue(iniPath, "System", "LastLoginPwd");
                    string pwdStr = new GetLangusgeSet().IniReadValue1(iniPath, "System", "LastLoginPwd");

                    if (pwdStr != "")
                        txtPassword.Text = pwdStr;
                }
            }
            catch (Exception f)
            {
                //MessageBox.Show(f.Message, "用户登录", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(f.Message, tsmiYhdl.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}
