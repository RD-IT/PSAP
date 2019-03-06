using PSAP.PSAPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PSAP.VIEW.BSVIEW
{
    public partial class FrmRight_New : DockContent
    {
        public FrmRight_New()
        {
            InitializeComponent();
            PSAP.BLL.BSBLL.BSBLL.language(this);
        }

        FrmRight_UserMenuButton userForm;
        FrmRight_MenuManagement menuForm;
        FrmRight_Role roleForm;
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmRight_New_Load(object sender, EventArgs e)
        {
            try
            {
                userForm = new FrmRight_UserMenuButton();
                userForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                userForm.TopLevel = false;
                userForm.Dock = DockStyle.Fill;
                //userForm.WindowState = FormWindowState.Maximized;
                PageUserMenuButton.Controls.Add(userForm);
                userForm.Show();

                menuForm = new FrmRight_MenuManagement();
                menuForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                menuForm.TopLevel = false;
                menuForm.Dock = DockStyle.Fill;
                //menuForm.WindowState = FormWindowState.Maximized;
                PageMenuManagement.Controls.Add(menuForm);
                menuForm.Show();

                roleForm = new FrmRight_Role();
                roleForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                roleForm.TopLevel = false;
                roleForm.Dock = DockStyle.Fill;
                //roleForm.WindowState = FormWindowState.Maximized;
                PageRole.Controls.Add(roleForm);
                roleForm.Show();

                TabControlUserPower.SelectedTabPageIndex = 0;
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
            }
        }

        /// <summary>
        /// 选择当前查看的用户权限页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabControlUserPower_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            try
            {
                if (e.Page == PageRole)
                {
                    roleForm.QueryMenuTreeList();
                    roleForm.gridViewRole_FocusedRowChanged(null, null);
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--选择当前查看的用户权限页错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiXz.Text, ex);
            }
        }
    }
}
