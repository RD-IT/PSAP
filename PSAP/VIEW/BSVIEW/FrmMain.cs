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

namespace PSAP.VIEW.BSVIEW
{
    public partial class FrmMain : Form

    {
//        FrmMainTool frmMainTool;
        #region 属性字段 
        #endregion

        public static FrmMain frmMain;
        public FrmMain()
        {
            frmMain = this;
            InitializeComponent();
            /*为了调试暂时注释掉$
            PSAP.BLL.BSBLL.BSBLL.InitUserMenus(this);//初始化主菜单用户权限
            */
            FrmMainTool frmMainTool = new FrmMainTool(menuStrip1);
            //FrmMainTool frmMainTool = new FrmMainTool();

            //frmMainTool.HideOnClose = true;//使用就无法触发窗口关闭事件了
            frmMainTool.Show(this.dockPanel1, DockState.DockLeft);
            //FrmDepartment f = new FrmDepartment();
            //f.Show(this.dockPanel1);
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
            //this.Text = "天津容大机电有限公司   [" + PSAPCommon.LoginInfo["DepartmentName"]+" - "+PSAPCommon.LoginInfo["EmpName"]+"]";
            this.Text = "天津容大机电有限公司   [" + BSCheckUser.user.DepartmentName + " - " + BSCheckUser.user.EmpName + "]";
            //InitMenuItem();//n
            //SetMenuItemByRole();//n
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

        public void 部门信息ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmDepartment frmDepartment = new FrmDepartment();
            FrmMain.frmMain.showRight(frmDepartment);
        }

        /// <summary>
        /// 关闭当前窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //if (dockPanel1.ActiveContent.DockHandler != null)
            //{
            //    dockPanel1.ActiveContent.DockHandler.Close();
            //}

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
            IDockContent[] documents =dockPanel1.DocumentsToArray();

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
            if (FrmMainTool.frmOpenFlag==0)
            {
                FrmMainTool frmMainTool = new FrmMainTool(menuStrip1);
                frmMainTool.Show(this.dockPanel1, DockState.DockLeft);
            }
        }

        private void 用户信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUserInfo frmUserInfo = new FrmUserInfo();
            FrmMain.frmMain.showRight(frmUserInfo);
        }

        private void 用户权限ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUserRight frmUserRight = new FrmUserRight();
            FrmMain.frmMain.showRight(frmUserRight);
        }

        /// <summary>
        /// 打开指定窗口，如果已打开就激活窗口
        /// </summary>
        /// <param name="dc"></param>
        public void showRight(DockContent dc)
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
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        //--------------------------------------------------------------------------------------
        // 初始化菜单项，全部设置为不可用。    
        //初始化一级菜单
        private void InitMenuItem()
        {
            string sql = "select * from BS_Menu where ParentMenuNo ='0'"; //一级菜单，其父菜单id为0
            DataTable dt =PSAP.DAO.BSDAO.BaseSQL.GetTableBySql(sql);
            
            foreach (DataRow dr in dt.Rows)
            {

                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Name = dr[1].ToString(); //menuname

                //menuStrip2.Items[item.Name].Enabled = true;// false;

                InitSubMenuItem(menuStrip2.Items[item.Name]);
            }


        }

        //初始化一级菜单的所有子菜单
        private void InitSubMenuItem(ToolStripItem item)
        {
            string mname = item.Name;

            ToolStripMenuItem pItem = (ToolStripMenuItem)item;

            //根据父菜单项加载子菜单
            string sql = "select * from BS_Menu where ParentMenuNo ='" + mname + "'";

            DataTable dt = PSAP.DAO.BSDAO.BaseSQL.GetTableBySql(sql); 

            if (dt.Rows.Count != 0)
            {

                foreach (DataRow dr in dt.Rows)
                {
                    ToolStripMenuItem subItem = new ToolStripMenuItem();
                    subItem.Name = dr[3].ToString();

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


        // 根据用户在用户权限表中的权限动态的设置能使用的菜单项。  

        //对一级菜单进行权限设置
        private void SetMenuItemByRole()
        {
            string sql = "select * from BS_Menu where id in" +
                      "(select menuid from BS_RoleMenu where RoleNo='IT') and ParentMenuNo = 0)";
            DataTable dt= PSAP.DAO.BSDAO.BaseSQL.GetTableBySql(sql);

            foreach (DataRow dr in dt.Rows)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Name = dr[3].ToString();//一级菜单的menuname

                menuStrip2.Items[item.Name].Enabled = true;//各一级菜单是主菜单menuStrip1集合的项

                SetSubMenuItemByRole(menuStrip2.Items[item.Name]);//将一级菜单对应主菜单menuStrip1集合的项传给子菜单设置函数

            }
        }

        //对一级菜单的所有子菜单进行设置
        private void SetSubMenuItemByRole(ToolStripItem item)
        {
            string mname = item.Name;

            ToolStripMenuItem pItem = (ToolStripMenuItem)item;

            //根据父菜单项加载子菜单
            string sql = "select * from BS_Menu where ParentMenuNo ='" + mname + "' and id in (select MenuNo from BS_RoleMenu where RoleNo='IT'";//'" + RoleNo + "')";//

            DataTable dt = PSAP.DAO.BSDAO.BaseSQL.GetTableBySql(sql);

            if (dt.Rows.Count != 0)
            {

                foreach (DataRow dr in dt.Rows)
                {
                    ToolStripMenuItem subItem = new ToolStripMenuItem();
                    subItem.Name = dr[3].ToString();

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
            else
            {

            }

        }

        //--------------------------------------------------------------------------------------
    }
}
