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

namespace PSAP.VIEW.BSVIEW
{
    public partial class FrmMain : Form

    {
//        FrmMainTool frmMainTool;
        #region 属性字段 
        #endregion
        public FrmMain()
        {
            InitializeComponent();
            /*为了调试暂时注释掉$
            PSAP.BLL.BSBLL.BSBLL.InitUserMenus(this);//初始化主菜单用户权限
            */
            FrmMainTool frmMainTool = new FrmMainTool(this);
            //frmMainTool = new FrmMainTool(this);这句没意义
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
            //FrmLogin frmLogin = new FrmLogin();
            //frmLogin.ShowDialog();
        }

        //private void 部门信息ToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    FrmDepartment f =new FrmDepartment();
        //    f.MdiParent = this.ParentForm;
        //    f.Show();
        //}


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
            //FrmDepartment f = new FrmDepartment();
            //f.MdiParent = this;
            //f.Show(this.dockPanel1);
            FrmDepartment.getinstance(this.dockPanel1);//打开指定窗口
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
                FrmMainTool frmMainTool = new FrmMainTool(this);
                //frmMainTool.Text = "功能导航";
                //frmMainTool.HideOnClose = true; 
                frmMainTool.Show(this.dockPanel1, DockState.DockLeft);
            }
        }

        private void 用户信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUserInfo.getinstance(this.dockPanel1);//打开指定窗口
        }

        private void 用户权限ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmUserRight.getinstance(this.dockPanel1);//打开指定窗口
        }
    }
}
