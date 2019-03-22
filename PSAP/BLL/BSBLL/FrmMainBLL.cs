using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PSAP.VIEW.BSVIEW;
using System.Data;
using System.Windows.Forms;
using System.Reflection;
using WeifenLuo.WinFormsUI.Docking;
using PSAP.DAO.BSDAO;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using PSAP.PSAPCommon;

namespace PSAP.BLL.BSBLL
{
    class FrmMainBLL
    {
        #region 初始化菜单
        /// <summary>
        /// 初始化主菜单 
        /// </summary>
        public static void InitMenuItem(MenuStrip mnsTmp)
        {
            DataTable dt = FrmMainDAO.GetTopMenuData();//获取一级菜单数据
            foreach (DataRow dr in dt.Rows)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Name = dr["MenuName"].ToString();
                item.Text = dr["MenuText"].ToString();
                item.Tag = "";
                mnsTmp.Items.Add(item);
                //mnsMain.Items[item.Name].Enabled = true;// false;
                InitSubMenuItem(mnsTmp.Items[item.Name]);
            }
        }

        public void InitTreeList(TreeList treeList)
        {
            DataTable dt = FrmMainDAO.GetTopMenuData();//获取一级菜单数据
            foreach (DataRow dr in dt.Rows)
            {
                TreeListNode node = treeList.Nodes.Add(new object[] { dr["MenuName"], dr["MenuText"] });
                node.Checked = true;
                node.Tag = "";
                InitSubTreeListNode(node);
            }
        }

        public void InitSubTreeListNode(TreeListNode parentNode)
        {
            DataTable dt = FrmMainDAO.GetChildMenuData(DataTypeConvert.GetString(parentNode[0]));
            foreach (DataRow dr in dt.Rows)
            {
                TreeListNode node = parentNode.Nodes.Add(new object[] { dr["MenuName"], dr["MenuText"] });
                node.Checked = false;
                node.Tag = dr["FormName"].ToString();
                InitSubTreeListNode(node);
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
            DataTable dt = FrmMainDAO.GetChildMenuData(mname);//获取子菜单数据
            if (dt.Rows.Count != 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    ToolStripMenuItem subItem = new ToolStripMenuItem();
                    subItem.Name = dr["MenuName"].ToString();
                    subItem.Text = dr["MenuText"].ToString();
                    subItem.Tag = dr["FormName"].ToString();
                    subItem.Click += new EventHandler(subItem_Click); //给菜单项加事件
                    pItem.DropDownItems.Add(subItem);
                    try
                    {
                        if (PSAPCommon.SystemInfo.user.AutoId != 1)
                            pItem.DropDownItems[subItem.Name].Enabled = false;//注释此项可关闭主菜单权限设定【开发用】

                        ToolStripItem pp = (ToolStripItem)subItem;
                        InitSubMenuItem(pp); //根据父菜单项加载子菜单

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
            System.Windows.Forms.ToolStripMenuItem subItemTmp = (System.Windows.Forms.ToolStripMenuItem)sender;
            string strTag;
            strTag = subItemTmp.Tag.ToString();

            if (strTag.Contains(":Role"))
            {
                strTag = strTag.Substring(0, strTag.Length - 5);//strTag的值是“窗口”name+“:Role” 
            }
            PSAPCommon.ViewHandler.ShowRightWindow(strTag);
        }
        #endregion

        #region 根据用户所属“角色”在用角色限表中的权限动态的设置能使用的菜单项。  
        /// <summary>
        /// 对主菜单进行权限设置（角色）
        /// </summary>
        public static void SetMenuItemByRole(MenuStrip mnsTmp, string strRoleNo)
        {
            DataTable dt = FrmMainDAO.GetTopMenuData();//获取一级菜单数据
            foreach (DataRow dr in dt.Rows)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Name = dr["MenuName"].ToString();//一级菜单的menuname
                mnsTmp.Items[item.Name].Enabled = true;//各一级菜单是主菜单menuStrip1集合的项
                SetSubMenuItemByRole(mnsTmp.Items[item.Name], strRoleNo);//将一级菜单对应主菜单menuStrip1集合的项传给子菜单设置函数
            }
        }

        public void SetTreeListByRole(int typeInt, TreeList treelist,string roleNoStr)
        {
            if (typeInt == 1)
            {
                DataTable roleTable = new FrmMainDAO().QueryRoleMenu(roleNoStr);
                foreach (TreeListNode node in treelist.Nodes)
                {
                    SetSubTreeListNodeByRole(1, roleTable, node, roleNoStr);
                }
            }
            else if(typeInt ==2)
            {
                DataTable roleTable = new FrmMainDAO().QueryPersonalMenu(roleNoStr);
                foreach (TreeListNode node in treelist.Nodes)
                {
                    SetSubTreeListNodeByRole(2, roleTable, node, roleNoStr);
                }
            }
        }

        public void SetSubTreeListNodeByRole(int typeInt, DataTable roleTable, TreeListNode parentNode, string roleNoStr)
        {
            string mname = DataTypeConvert.GetString(parentNode[0]);
            //DataTable dt = FrmMainDAO.GetChildMenuRoleRightData(mname, roleNoStr);// 获取子菜单权限数据（角色）
            foreach (TreeListNode node in parentNode.Nodes)
            {
                string s = DataTypeConvert.GetString(node[0]);

                if (roleTable.Select(string.Format("MenuName = '{0}'", DataTypeConvert.GetString(node[0]))).Length > 0)
                {
                    node.Checked = true;
                    if (typeInt == 1)
                    {
                        node.Tag = DataTypeConvert.GetString(node.Tag) + ":Role";
                    }
                }
                SetSubTreeListNodeByRole(typeInt, roleTable, node, roleNoStr);
            }
        }

        /// <summary>
        ///对主菜单的所有子菜单enable进行设置 
        /// </summary>
        /// <param name="item"></param>
        private static void SetSubMenuItemByRole(ToolStripItem item, string strRoleNo)
        {
            string mname = item.Name;
            ToolStripMenuItem pItem = (ToolStripMenuItem)item;
            //根据父菜单项加载子菜单（角色）
            DataTable dt = FrmMainDAO.GetChildMenuRoleRightData(mname, strRoleNo);// 获取子菜单权限数据（角色）
            if (dt.Rows.Count != 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    ToolStripMenuItem subItem = new ToolStripMenuItem();
                    subItem.Name = dr["MenuName"].ToString();
                    try
                    {
                        pItem.DropDownItems[subItem.Name].Enabled = true;
                        pItem.DropDownItems[subItem.Name].Tag = pItem.DropDownItems[subItem.Name].Tag + ":Role";

                        SetSubMenuItemByRole(pItem.DropDownItems[subItem.Name], strRoleNo);//

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
            }
        }
        #endregion

        #region 根据“个人”在用户权限表中的权限动态的设置能使用的菜单项。  
        /// <summary>
        /// 对主菜单进行权限设置（个人）
        /// </summary>
        public static void SetMenuItemByPersonal(MenuStrip mnsTmp, string strPersonalNo)
        {
            DataTable dt = FrmMainDAO.GetTopMenuData();//获取一级菜单数据
            foreach (DataRow dr in dt.Rows)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Name = dr["MenuName"].ToString();//一级菜单的menuname
                mnsTmp.Items[item.Name].Enabled = true;//各一级菜单是主菜单menuStrip1集合的项
                SetSubMenuItemByPersonal(mnsTmp.Items[item.Name], strPersonalNo);//将一级菜单对应主菜单menuStrip1集合的项传给子菜单设置函数
            }
        }

        /// <summary>
        ///对主菜单的所有子菜单enable进行设置（个人）
        /// </summary>
        /// <param name="item"></param>
        private static void SetSubMenuItemByPersonal(ToolStripItem item, string strPersonalNo)
        {
            string mname = item.Name;
            ToolStripMenuItem pItem = (ToolStripMenuItem)item;
            //根据父菜单项加载子菜单
            DataTable dt = FrmMainDAO.GetChildMenuPersonalRightData(mname, strPersonalNo);
            if (dt.Rows.Count != 0)
            {

                foreach (DataRow dr in dt.Rows)
                {
                    ToolStripMenuItem subItem = new ToolStripMenuItem();
                    subItem.Name = dr["MenuName"].ToString();

                    try
                    {
                        pItem.DropDownItems[subItem.Name].Enabled = true;
                        SetSubMenuItemByPersonal(pItem.DropDownItems[subItem.Name], strPersonalNo);//
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
