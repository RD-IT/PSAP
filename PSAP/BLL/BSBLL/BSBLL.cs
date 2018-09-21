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
        public static void CheckUser(string txtUserID,string txtPassword)
        {
            if(BSCheckUser.CheckUser(txtUserID,txtPassword)!=null)
            {
                FrmLogin.ActiveForm.Close();
            }
            else
            {
                MessageBox.Show(string.Format("用ID或密码错误！"), "用户登录", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        /// <summary>
        /// 初始化主菜单用户权限
        /// </summary>
        /// 
        public static void InitUserMenus(MenuStrip mnuS)
        {
            ToolStripMenuItem mnuItem;
            ToolStripMenuItem refMenuItem = new ToolStripMenuItem();

            //初始设置所有菜单无效
            foreach (ToolStripMenuItem ctrl in mnuS.Items)
            {
                //ctrl.Enabled = false;//主菜单保持有效状态
                foreach (object subItem in ctrl.DropDownItems)
                {
                    if (subItem.GetType() == refMenuItem.GetType())
                    {
                        mnuItem = (ToolStripMenuItem)subItem;
                        mnuItem.Enabled = false;
                    }
                }
            }

            //取得相应用户对应的菜单项权限
            ENTITY.BSENTITY.UserInfo userInfo = new ENTITY.BSENTITY.UserInfo();
            string sqlString = "select a.MenuName from BS_UserRight a where a.LoginID like'"+userInfo.LoginID+"'";
            SqlDataAdapter adp = new SqlDataAdapter(sqlString, BaseSQL.connectionString );
            DataSet ds = new DataSet();
            adp.Fill(ds);

            //设置菜单项的可见或可用性
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                //遍历主菜单
                foreach (ToolStripMenuItem ctrl in mnuS.Items)
                {
                    //主菜单保持有效状态
                    //if (ctrl.Name.ToUpper().Trim() == dr[0].ToString().ToUpper().Trim())
                    //{
                        //ctrl.Visible = true;
                        //ctrl.Enabled = true;
                        //break;
                    //}

                    //遍历子菜单
                    foreach (object subItem in ctrl.DropDownItems)
                    {
                        if (subItem.GetType() == refMenuItem.GetType())
                        {
                            mnuItem = (ToolStripMenuItem)subItem;
                            if (mnuItem.Name.ToUpper().Trim() == dr[0].ToString().ToUpper().Trim())
                            {
                                //mnuItem.Visible = true;
                                mnuItem.Enabled = true;
                                break;
                            }
                        }
                    }
                }
            }
            
        }
    }
}
