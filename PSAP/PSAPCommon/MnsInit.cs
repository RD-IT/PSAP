using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PSAP
{
    class MnsInit
    {

        #region 初始化菜单
        /// <summary>
        /// 初始化主菜单 
        /// </summary>
        public static void InitMenuItem(MenuStrip mnsTmp)
        {
            string sql = "select * from BS_Menu where ParentMenuName is null order by MenuOrder"; //一级菜单，其父菜单id为0
            DataTable dt = PSAP.DAO.BSDAO.BaseSQL.GetTableBySql(sql);
            foreach (DataRow dr in dt.Rows)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Name = dr["MenuName"].ToString();
                item.Text = dr["MenuText"].ToString();
                mnsTmp.Items.Add(item);
                //mnsMain.Items[item.Name].Enabled = true;// false;
                InitSubMenuItem(mnsTmp.Items[item.Name]);
            }
        }

        /// <summary>
        ///初始化主菜单的所有子菜单 
        /// </summary>
        /// <param name="item"></param>
        private static void InitSubMenuItem(ToolStripItem item)
        {
            string mname = item.Name;
            ToolStripMenuItem pItem = (ToolStripMenuItem)item;
            //根据父菜单项加载子菜单
            string sql = "select * from BS_Menu where ParentMenuName ='" + mname + "'";
            DataTable dt = PSAP.DAO.BSDAO.BaseSQL.GetTableBySql(sql);
            if (dt.Rows.Count != 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    ToolStripMenuItem subItem = new ToolStripMenuItem();
                    subItem.Name = dr["MenuName"].ToString();
                    subItem.Text = dr["MenuText"].ToString();
                    //*****************
                    subItem.Tag = dr["FormName"].ToString();
                    //给菜单项加事件。
                    subItem.Click += new EventHandler(subItem_Click);
                    //*****************
                    pItem.DropDownItems.Add(subItem);
                    try
                    {
                        pItem.DropDownItems[subItem.Name].Enabled = false;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
            }
        }
        #endregion

        #region 菜单单击事件
        /// <summary>
        /// 菜单单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void subItem_Click(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly(); // 获取当前程序集 
            System.Windows.Forms.ToolStripMenuItem subItemTmp = (System.Windows.Forms.ToolStripMenuItem)sender;
            string strFrm = "PSAP.VIEW.BSVIEW." + subItemTmp.Tag.ToString();
            object obj = assembly.CreateInstance(strFrm); //类的完全限定名（即包括命名空间）
            PSAP.VIEW.BSVIEW.FrmMain.frmMain.showRight((DockContent)obj);
        }
        #endregion

        #region 根据用户在用户权限表中的权限动态的设置能使用的菜单项。  
        /// <summary>
        /// 对主菜单进行权限设置
        /// </summary>
        public static void SetMenuItemByRole(MenuStrip mnsTmp,string strRoleNo)
        {
            string sql = "select * from BS_Menu where ParentMenuName is null order by MenuOrder";//需修改
            DataTable dt = PSAP.DAO.BSDAO.BaseSQL.GetTableBySql(sql);
            foreach (DataRow dr in dt.Rows)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Name = dr["MenuName"].ToString();//一级菜单的menuname
                mnsTmp.Items[item.Name].Enabled = true;//各一级菜单是主菜单menuStrip1集合的项
                SetSubMenuItemByRole(mnsTmp.Items[item.Name],strRoleNo);//将一级菜单对应主菜单menuStrip1集合的项传给子菜单设置函数
            }
        }

        /// <summary>
        ///对主菜单的所有子菜单enable进行设置 
        /// </summary>
        /// <param name="item"></param>
        private static void SetSubMenuItemByRole(ToolStripItem item,string strRoleNo)
        {
            string mname = item.Name;
            ToolStripMenuItem pItem = (ToolStripMenuItem)item;
            //根据父菜单项加载子菜单
            string sql = "select * from BS_Menu " +
                "where ParentMenuName ='" + mname + "'" +
                "and MenuName in (select MenuName from BS_RoleMenu where convert(varchar(20),RoleNo)='" +strRoleNo.Trim() + "')";
            DataTable dt = PSAP.DAO.BSDAO.BaseSQL.GetTableBySql(sql);
            if (dt.Rows.Count != 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    ToolStripMenuItem subItem = new ToolStripMenuItem();
                    subItem.Name = dr["MenuName"].ToString();
                    try
                    {
                        pItem.DropDownItems[subItem.Name].Enabled = true;

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
            }
        }
        #endregion
    }
}
