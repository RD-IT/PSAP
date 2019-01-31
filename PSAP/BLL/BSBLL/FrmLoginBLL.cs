using PSAP.DAO.BSDAO;
using PSAP.PSAPCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PSAP;

namespace PSAP.BLL.BSBLL
{
    class FrmLoginBLL
    {
        /// <summary>
        /// 验证用户及密码
        /// </summary>
        /// <param name="strUserID"></param>
        /// <param name="strPassword"></param>
        public static bool CheckUser(string strUserID, string strPassword,ComboBox cboLanguage)
        {
            try
            {
                if (FrmLoginDAO.CheckUser(strUserID, strPassword, cboLanguage.SelectedValue.ToString()) != null)
                {
                    return true;                    
                }
                else
                {
                    MessageBox.Show(string.Format("用ID或密码错误！"), "用户登录", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            catch
            {
                MessageBox.Show(string.Format("数据库连接错误，请检查服务器连接情况！"), "用户登录", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

        }
        /// <summary>
        /// 修改密码时，验证用户及密码
        /// </summary>
        /// <param name="strUserID"></param>
        /// <param name="strPassword"></param>
        /// <param name="strPasswordNew"></param>
        /// <param name="strPasswordNewV"></param>
        public static void CheckUserChangePassword(string strUserID, string strPassword, string strPasswordNew)
        {
            if (FrmLoginDAO.CheckUser(strUserID, strPassword,"") != null)
            {
                EncryptMD5 en = new EncryptMD5(strPasswordNew);//实例化EncryptMD5, 加密后值引用en.str2
                FrmLoginDAO.ChangePassword(en.str2, strUserID);
                FrmLogin.ActiveForm.Close();
            }
            else
            {
                MessageBox.Show(string.Format("用ID或原密码错误！"), "用户登录", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        public static void InitCboLanguage(ComboBox cbTmp)
        {
            cbTmp.DataSource = FrmLoginDAO.GegLanguageCategory();
            cbTmp.DisplayMember = "LanguageText";
            cbTmp.ValueMember = "LanguageName";
        }
    }
}
