using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PSAP.DAO.BSDAO;
using System.Data;
using System.Data.SqlClient;
using PSAP;

namespace PSAP.BLL.BSBLL
{
    public abstract class BSBLL
    {
        //public static DataRow LoginInfo;//存放当前登陆用户信息
        public static void CheckUser(TextBox txtUserID,TextBox txtPassword)
        {
            if (txtUserID.Text == string.Empty || txtPassword.Text == string.Empty)
            {
                MessageBox.Show("用户ID和密码不能为空！", "提示");
            }
            else
            {
                string sqlString = "select a.*,b.departmentName "+
                    "from BS_UserInfo a left join BS_Department b on a.departmentNo=b.departmentNo  "+
                    "where a.loginID='" + txtUserID.Text + "' and a.loginPwd='" + txtPassword.Text + "'";
                DataSet ds = new DataSet();
                ds=BaseSQL.Query(sqlString);
                //if (BaseSQL.Exists(sqlString))
                if(ds.Tables[0].Rows.Count>0)
                {
                    PSAPCommon. LoginInfo = ds.Tables[0].Rows[0];
                    FrmLogin.ActiveForm.Close();
                }
                else
                {
                    MessageBox.Show("用ID或密码错误！");
                }
            }
        }
    }
}
