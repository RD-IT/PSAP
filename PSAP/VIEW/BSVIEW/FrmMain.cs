using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PSAP.BLL.BSBLL;
using WeifenLuo.WinFormsUI.Docking;
using UtilityLibrary.WinControls;
using PSAP.DAO.BSDAO;
using System.Data.SqlClient;
using System.Reflection;
using PSAP.BLL;

namespace PSAP.VIEW.BSVIEW
{
    public partial class FrmMain : Form

    {
        #region 属性字段 
        #endregion
        public static FrmMain frmMain;
        public static MenuStrip mnsMain = new MenuStrip();//主菜单

        public FrmMain()
        {
            frmMain = this;
            InitializeComponent();
            toolStripContainer1.TopToolStripPanel.Controls.Add(mnsMain);
            //PSAP.BLL.BSBLL.BSBLL.InitUserMenus(this);//初始化主菜单用户权限(不用了这是以前设置实例菜单的)

            FrmMainBLL.InitMenuItem(mnsMain);//初始化菜单
            FrmMainBLL.SetMenuItemByRole(mnsMain, BSCheckUser.user.RoleNo);//初始化用户"角色"权限
            FrmMainBLL.SetMenuItemByPersonal(mnsMain, BSCheckUser.user.AutoId.ToString());//初始化用户"个人"权限
            FrmMainTool frmMainTool = new FrmMainTool(mnsMain);//menuStrip1(实例菜单)
            //frmMainTool.HideOnClose = true;//使用就无法触发窗口关闭事件了
            frmMainTool.Show(this.dockPanel1, DockState.DockLeft);
        }

        //用于dock
        private DockContent FindDocument(string text)
        {
            if (dockPanel1.DocumentStyle == DocumentStyle.SystemMdi)
            {
                foreach (Form form in MdiChildren)
                {
                    if (form.Text == text)
                    {
                        return form as DockContent;
                    }
                }

                return null;
            }
            else
            {
                foreach (DockContent content in dockPanel1.Documents)
                {
                    if (content.DockHandler.TabText == text)
                    {
                        return content;
                    }
                }
                return null;
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Text = "天津容大机电有限公司   [" + BSCheckUser.user.DepartmentName + " - " + BSCheckUser.user.EmpName + "]";

        }


        //用于dock
        public DockContent ShowContent(string caption, Type formType)
        {
            DockContent frm = FindDocument(caption);
            if (frm == null)
            {
                frm = Activator.CreateInstance(formType) as DockContent;
                frm.DockHandler.TabText = caption;
                frm.Show(dockPanel1);
            }
            frm.Show(dockPanel1, DockState.Document);
            frm.BringToFront();
            return frm;
        }

        /// <summary>
        /// 关闭当前窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            IDockContent[] documents = dockPanel1.DocumentsToArray();

            foreach (IDockContent content in documents)
            {
                if (content.Equals(dockPanel1.ActiveContent))
                {
                    content.DockHandler.Close();
                    return;
                }
            }

        }

        /// <summary>
        ///除此之外全部关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            IDockContent[] documents = dockPanel1.DocumentsToArray();

            foreach (IDockContent content in documents)
            {
                if (!content.Equals(dockPanel1.ActiveContent))

                {
                    content.DockHandler.Close();
                }
            }
        }
        /// <summary>
        /// 关闭全部打开的窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            IDockContent[] documents = dockPanel1.DocumentsToArray();

            foreach (IDockContent content in documents)
            {
                content.DockHandler.Close();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (FrmMainTool.frmOpenFlag == 0)
            {
                FrmMainTool frmMainTool = new FrmMainTool(mnsMain);//menuStrip1(实例菜单)
                frmMainTool.Show(this.dockPanel1, DockState.DockLeft);
            }
        }

        /// <summary>
        /// 打开指定窗口，如果已打开就激活窗口
        /// </summary>
        /// <param name="dc"></param>
        public void showRight(DockContent dc)
        {
            if (dc != null)
            {
                IDockContent[] documents = dockPanel1.DocumentsToArray();
                foreach (IDockContent content in documents)
                {
                    if (content.DockHandler.TabText.Equals(dc.DockHandler.TabText))
                    {
                        content.DockHandler.Activate();
                        return;
                    }
                }

                dc.Show(this.dockPanel1);//用于从功能导航窗口调用此窗口
                BSBLL.SetFormRight(dc);//设置窗口中按钮的权限
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 单击系统图标时，更改系统主窗口状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                if (this.TopLevel == true)
                {
                    this.WindowState = FormWindowState.Minimized;
                }
                else
                {
                    this.WindowState = FormWindowState.Minimized;
                    this.WindowState = FormWindowState.Maximized;
                }
            }
        }

        //#region 初始化菜单
        ///// <summary>
        ///// 初始化主菜单 
        ///// </summary>
        //private void InitMenuItem()
        //{
        //    string sql = "select * from BS_Menu where ParentMenuName is null order by MenuOrder"; //一级菜单，其父菜单id为0
        //    DataTable dt =PSAP.DAO.BSDAO.BaseSQL.GetTableBySql(sql);
        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        ToolStripMenuItem item = new ToolStripMenuItem();
        //        item.Name =dr["MenuName"].ToString(); 
        //        item.Text = dr["MenuText"].ToString();
        //        mnsMain.Items.Add(item);
        //        //mnsMain.Items[item.Name].Enabled = true;// false;
        //        InitSubMenuItem(mnsMain.Items[item.Name]);
        //    }
        //}

        ///// <summary>
        /////初始化主菜单的所有子菜单 
        ///// </summary>
        ///// <param name="item"></param>
        //private void InitSubMenuItem(ToolStripItem item)
        //{
        //    string mname = item.Name;
        //    ToolStripMenuItem pItem = (ToolStripMenuItem)item;
        //    //根据父菜单项加载子菜单
        //    string sql = "select * from BS_Menu where ParentMenuName ='" + mname + "'";
        //    DataTable dt = PSAP.DAO.BSDAO.BaseSQL.GetTableBySql(sql); 
        //    if (dt.Rows.Count != 0)
        //    {
        //        foreach (DataRow dr in dt.Rows)
        //        {
        //            ToolStripMenuItem subItem = new ToolStripMenuItem();
        //            subItem.Name = dr["MenuName"].ToString();
        //            subItem.Text = dr["MenuText"].ToString();
        //            //*****************
        //            subItem.Tag =dr["FormName"].ToString();
        //            //给菜单项加事件。
        //            subItem.Click += new EventHandler(subItem_Click);
        //            //*****************
        //            pItem.DropDownItems.Add(subItem);
        //            try
        //            {
        //                pItem.DropDownItems[subItem.Name].Enabled =false;
        //            }
        //            catch (Exception e)
        //            {
        //                MessageBox.Show(e.Message);
        //            }
        //        }
        //    }
        //}
        //#endregion

        //#region 菜单单击事件
        ///// <summary>
        ///// 菜单单击事件
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //void subItem_Click(object sender, EventArgs e)
        //{
        //    Assembly assembly = Assembly.GetExecutingAssembly(); // 获取当前程序集 
        //    System.Windows.Forms.ToolStripMenuItem subItemTmp=(System.Windows.Forms.ToolStripMenuItem)sender;
        //    string strFrm = "PSAP.VIEW.BSVIEW." + subItemTmp.Tag.ToString();
        //    object obj = assembly.CreateInstance(strFrm); //类的完全限定名（即包括命名空间）
        //    frmMain.showRight((DockContent)obj); 
        //}
        //#endregion

        //#region 根据用户在用户权限表中的权限动态的设置能使用的菜单项。  
        ///// <summary>
        ///// 对主菜单进行权限设置
        ///// </summary>
        //private void SetMenuItemByRole()
        //{
        //    string sql = "select * from BS_Menu where ParentMenuName is null order by MenuOrder";//需修改
        //    DataTable dt= PSAP.DAO.BSDAO.BaseSQL.GetTableBySql(sql);
        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        ToolStripMenuItem item = new ToolStripMenuItem();
        //        item.Name = dr["MenuName"].ToString();//一级菜单的menuname
        //        mnsMain.Items[item.Name].Enabled = true;//各一级菜单是主菜单menuStrip1集合的项
        //        SetSubMenuItemByRole(mnsMain.Items[item.Name]);//将一级菜单对应主菜单menuStrip1集合的项传给子菜单设置函数
        //    }
        //}

        ///// <summary>
        /////对主菜单的所有子菜单enable进行设置 
        ///// </summary>
        ///// <param name="item"></param>
        //private void SetSubMenuItemByRole(ToolStripItem item)
        //{
        //    string mname = item.Name;
        //    ToolStripMenuItem pItem = (ToolStripMenuItem)item;
        //    //根据父菜单项加载子菜单
        //    string sql = "select * from BS_Menu "+
        //        "where ParentMenuName ='" + mname + "'"+
        //        "and MenuName in (select MenuName from BS_RoleMenu where RoleNo='" +BSCheckUser.user.RoleNo + "')";
        //    DataTable dt = PSAP.DAO.BSDAO.BaseSQL.GetTableBySql(sql);
        //    if (dt.Rows.Count!= 0)
        //    {
        //        foreach (DataRow dr in dt.Rows)
        //        {
        //            ToolStripMenuItem subItem = new ToolStripMenuItem();
        //            subItem.Name = dr["MenuName"].ToString();
        //            try
        //            {
        //                pItem.DropDownItems[subItem.Name].Enabled = true;

        //            }
        //            catch (Exception e)
        //            {
        //                MessageBox.Show(e.Message);
        //            }
        //        }
        //    }
        //}
        //#endregion
    }
}
