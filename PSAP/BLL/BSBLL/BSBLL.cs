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
        //public static DataRow LoginInfo;//存放当前登录用户信息
        public static void CheckUser(TextBox txtUserID,TextBox txtPassword)
        {
            if (txtUserID.Text == string.Empty || txtPassword.Text == string.Empty)
            {
                MessageBox.Show(string.Format("用户ID和密码不能为空！"), "用户登录", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show(string.Format("用ID或密码错误！"), "用户登录", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        //0000000000000000000000000000000000000000000000000000000000
        /// <summary>
        /// 初始化主菜单用户权限
        /// </summary>
        public static void InitUserMenus(PSAP.VIEW.BSVIEW.FrmMain frmMain)
        {
            ToolStripMenuItem mnuItem;
            ToolStripMenuItem refMenuItem = new ToolStripMenuItem();

            //初始设置所有菜单不可见
            foreach (ToolStripMenuItem ctrl in frmMain.menuStrip1.Items)
            {
                //ctrl.Enabled = false;
                foreach (object subItem in ctrl.DropDownItems)
                {
                    if (subItem.GetType() == refMenuItem.GetType())
                    {
                        mnuItem = (ToolStripMenuItem)subItem;
                        mnuItem.Enabled = false;
                    }
                }
            }

        /*
            //取得相应用户对应的菜单项权限
            string sqlFunc = string.Format("select *** from *** ");
            SqlDataAdapter adp = new SqlDataAdapter(sqlFunc, conn);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            //设置菜单项的可见或可用性
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                //遍历主菜单
                foreach (ToolStripMenuItem ctrl in mainMenu.Items)
                {
                    if (ctrl.Name.ToUpper().Trim() == dr[0].ToString().ToUpper().Trim())
                    {
                        ctrl.Visible = true;
                        ctrl.Enabled = true;
                        break;
                    }

                    //遍历子菜单
                    foreach (object subItem in ctrl.DropDownItems)
                    {
                        if (subItem.GetType() == refMenuItem.GetType())
                        {
                            mnuItem = (ToolStripMenuItem)subItem;
                            if (mnuItem.Name.ToUpper().Trim() == dr[0].ToString().ToUpper().Trim())
                            {
                                mnuItem.Visible = true;
                                mnuItem.Enabled = true;
                                break;
                            }
                        }
                    }
                }
            }
            */
        }
    }
}
