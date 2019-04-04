using DevExpress.XtraTreeList.Nodes;
using PSAP.BLL.BSBLL;
using PSAP.DAO.BSDAO;
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
    public partial class FrmRight_UserMenuButton : DockContent
    {
        FrmCommonDAO commonDAO = new FrmCommonDAO();

        //public static MenuStrip mnsRight = new MenuStrip();//权限管理用户主菜单
        //public static MenuStrip mnsMainMenu = new MenuStrip();//主菜单管理
        static PSAP.VIEW.BSVIEW.FrmLanguageText f = new VIEW.BSVIEW.FrmLanguageText();

        public FrmRight_UserMenuButton()
        {
            InitializeComponent();
            PSAP.BLL.BSBLL.BSBLL.language(this);
            PSAP.BLL.BSBLL.BSBLL.language(f);
        }

        private void InitControl()
        {
            try
            {
                lookUpReqDep.Properties.DataSource = commonDAO.QueryDepartment_AllNode(true);
                lookUpReqDep.ItemIndex = 0;

                gridControlUserList.DataSource = BSCommon.getUserInfoList("", "", "");
                //dgvUserList.Columns[0].Width = 40;
                //dgvUserList.Columns[1].Width = 60;
                //dgvUserList.Columns[2].Width = 60;
                //dgvUserList.Columns[3].Width = 90;
                //dgvUserList.Columns[4].Width = 90;
                //dgvUserList.Columns[5].Width = 60;
                //dgvUserList.Columns[0].FieldName = dtblTmp.Columns["AutoId"].ToString();
                //dgvUserList.Columns[1].FieldName = dtblTmp.Columns["LoginID"].ToString();
                //dgvUserList.Columns[2].FieldName = dtblTmp.Columns["EmpName"].ToString();
                //dgvUserList.Columns[3].FieldName = dtblTmp.Columns["DepartmentName"].ToString();
                //dgvUserList.Columns[4].FieldName = dtblTmp.Columns["RoleName"].ToString();
                //dgvUserList.Columns[5].FieldName = dtblTmp.Columns["RoleNo"].ToString();
                //dgvUserList.Columns[0].Caption = "员工编号";
                //dgvUserList.Columns[1].Caption = "用户编号";
                //dgvUserList.Columns[2].Caption = "用户姓名";
                //dgvUserList.Columns[3].Caption = "部门";
                //dgvUserList.Columns[4].Caption = "角色";
                //dgvUserList.Columns[5].Caption = "角色编号";
                //dgvUserList.Columns[0].Visible = false;
                //dgvUserList.Columns[5].Visible = false;

                //角色combo
                cboRoleName.Properties.DataSource = BSCommon.getRoleList();
                //cboRoleName.Properties.DisplayMember = "RoleName";
                //cboRoleName.Properties.ValueMember = "RoleNo";
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiCtjzsjcw.Text, ex);
            }
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmRight_UserMenuButton_Load(object sender, EventArgs e)
        {
            try
            {
                tvwUserRight.Nodes.Clear();
                new FrmMainBLL().InitTreeList(tvwUserRight);
                FrmRightBLL.TreeAddButtonsNode(tvwUserRight);

                InitControl();
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
            }
        }

        /// <summary>
        /// 查询用户权限信息
        /// </summary>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                gridControlUserList.DataSource = BSCommon.getUserInfoList(txtLoginID.Text.Trim(), txtUserName.Text.Trim(), lookUpReqDep.Text.Trim() == "全部" ? "" : lookUpReqDep.Text.Trim());
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--查询用户权限信息错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiCxyhqxxxcw.Text, ex);
            }
        }

        /// <summary>
        /// 查询用户的权限事件
        /// </summary>
        private void dgvUserList_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (dgvUserList.GetFocusedDataRow() != null)
                {
                    cboRoleName.Text = "";
                    //mnsRight.Items.Clear();
                    //FrmMainBLL.InitMenuItem(mnsRight);//初始化权限菜单
                    //FrmMainBLL.SetMenuItemByRole(mnsRight, DataTypeConvert.GetString(dgvUserList.GetFocusedDataRow()[5]));//初始化用户权限
                    //FrmMainBLL.SetMenuItemByPersonal(mnsRight, DataTypeConvert.GetString(dgvUserList.GetFocusedDataRow()[0]));//初始化用户"个人"权限                    
                    tvwUserRight.UncheckAll();
                    foreach(TreeListNode node in tvwUserRight.Nodes)
                    {
                        node.Checked = true;
                        SetSubNodeTag(node);
                    }
                    
                    new FrmMainBLL().SetTreeListByRole(1, tvwUserRight, DataTypeConvert.GetString(dgvUserList.GetFocusedDataRow()[5]));
                    new FrmMainBLL().SetTreeListByRole(2, tvwUserRight, DataTypeConvert.GetString(dgvUserList.GetFocusedDataRow()[0]));
                    //FrmRightBLL.TreeGetNodeForMns(tvwUserRight, mnsRight);
                    tvwUserRight.CollapseAll();
                    string userNoStr = DataTypeConvert.GetString(dgvUserList.GetFocusedDataRow()[0]);
                    new FrmRightBLL().SetTreeListNodeState(tvwUserRight, userNoStr);
                    tvwUserRight.Refresh();
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--查询用户的权限事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiCxyhdqxsjcw.Text, ex);
            }
        }

        private void SetSubNodeTag(TreeListNode parentNode)
        {            
            foreach (TreeListNode node in parentNode.Nodes)
            {
                node.Tag = DataTypeConvert.GetString(node.Tag).Replace(":Role", "");
                SetSubNodeTag(node);
            }
        }

        /// <summary>
        /// 根据选择节点状态更新树其他节点状态
        /// </summary>
        private void treeListRole_AfterCheckNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            try
            {
                SetCheckedChildNodes(e.Node, e.Node.CheckState);
                SetCheckedParentNodes(e.Node, e.Node.CheckState);
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--根据选择节点状态更新树其他节点状态错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiGjxzjdztgxsqtjd.Text, ex);
            }
        }

        private void treeListRole_BeforeCheckNode(object sender, DevExpress.XtraTreeList.CheckNodeEventArgs e)
        {
            e.State = (e.PrevState == CheckState.Checked ? CheckState.Unchecked : CheckState.Checked);
        }

        /// <summary>
        /// 设置子节点的状态
        /// </summary>
        private void SetCheckedChildNodes(DevExpress.XtraTreeList.Nodes.TreeListNode node, CheckState check)
        {
            for (int i = 0; i < node.Nodes.Count; i++)
            {
                node.Nodes[i].CheckState = check;
                SetCheckedChildNodes(node.Nodes[i], check);
            }
        }

        /// <summary>
        /// 设置父节点的状态
        /// </summary>
        private void SetCheckedParentNodes(DevExpress.XtraTreeList.Nodes.TreeListNode node, CheckState check)
        {
            if (node.ParentNode != null)
            {
                bool b = false;
                CheckState state;
                for (int i = 0; i < node.ParentNode.Nodes.Count; i++)
                {
                    state = (CheckState)node.ParentNode.Nodes[i].CheckState;
                    if (!check.Equals(state))
                    {
                        b = !b;
                        break;
                    }
                }
                //node.ParentNode.CheckState = b ? CheckState.Indeterminate : check;
                node.ParentNode.CheckState = b ? CheckState.Checked : check;
                SetCheckedParentNodes(node.ParentNode, check);
            }
        }

        /// <summary>
        /// 保存权限事件
        /// </summary>
        private void btnSaveRight_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(DataTypeConvert.GetString(cboRoleName.EditValue)))
                {
                    dgvUserList.SetFocusedRowCellValue(dgvUserList.Columns[4], cboRoleName.Text);
                    dgvUserList.SetFocusedRowCellValue(dgvUserList.Columns[5], cboRoleName.EditValue);
                    FrmRightDAO.SaveRoleUser(cboRoleName.EditValue.ToString(), DataTypeConvert.GetInt(dgvUserList.GetFocusedDataRow()[0]));
                    FrmRightDAO.GiveRoleAllButtonRight();
                }
                FrmRightBLL.SavePersonalRightFromTree(tvwUserRight, dgvUserList);//遍历树保存权限

                //FrmMain.frmMain.tsrLblCurrentStatusText = "【用户权限】已成功保存";
                MessageHandler.ShowMessageBox(tsmiYhqxycgbc.Text);// ("【用户权限】已成功保存。");
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--查询用户权限信息错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiCxyhqxxxcw.Text, ex);
            }
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void dgvUserList_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            ControlHandler.GridView_CustomDrawRowIndicator(e);
        }

        /// <summary>
        /// 获取单元格显示的信息
        /// </summary>
        private void dgvUserList_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                ControlHandler.GridView_GetFocusedCellDisplayText_KeyDown(sender, e);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--获取单元格显示的信息错误。", ex);
            }
        }

        /// <summary>
        /// 扩展树节点
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            tvwUserRight.ExpandAll();
        }

        /// <summary>
        /// 收缩树节点
        /// </summary>
        private void btnSub_Click(object sender, EventArgs e)
        {
            tvwUserRight.CollapseAll();
        }

        /// <summary>
        /// 设定不同节点的字体颜色
        /// </summary>
        private void tvwUserRight_CustomDrawNodeCell(object sender, DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs e)
        {
            try
            {
                string tag = DataTypeConvert.GetString(e.Node.Tag);
                if(tag.Contains(":Role"))
                {
                    e.Appearance.ForeColor = Color.DeepSkyBlue;
                    e.Appearance.Options.UseForeColor = true;
                }

            }
            catch (Exception)
            {
                
            }
            
        }

    }
}
