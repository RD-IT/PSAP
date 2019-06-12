using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using PSAP.DAO.BSDAO;
using PSAP.PSAPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PSAP.VIEW.BSVIEW
{
    public partial class FrmDepartment_New : DockContent
    {
        FrmBaseEdit editForm = null;
        FrmCommonDAO commonDAO = new FrmCommonDAO();

        /// <summary>
        /// 父节点部门编号
        /// </summary>
        private string parentDepartmentNoStr = "";

        /// <summary>
        /// 父节点部门名称
        /// </summary>
        private string parentDepartmentNameStr = "";
        static PSAP.VIEW.BSVIEW.FrmLanguageText f = new VIEW.BSVIEW.FrmLanguageText();

        public FrmDepartment_New()
        {
            InitializeComponent();
            PSAP.BLL.BSBLL.BSBLL.language(f);
            PSAP.BLL.BSBLL.BSBLL.language(this);
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmDepartment_New_Load(object sender, EventArgs e)
        {
            try
            {
                if (editForm == null)
                {
                    editForm = new FrmBaseEdit();
                    editForm.FormBorderStyle = FormBorderStyle.None;
                    editForm.TopLevel = false;
                    editForm.TableName = "BS_Department";
                    editForm.TableCaption = "部门信息";
                    editForm.Sql = "select Dept.*, parent.DepartmentName as ParentDepartmentName from BS_Department as Dept left join BS_Department as parent on Dept.ParentDepartmentNo = parent.DepartmentNo order by AutoId";
                    editForm.PrimaryKeyColumn = "DepartmentNo";
                    editForm.MasterDataSet = dSDepartment;
                    editForm.MasterBindingSource = bSDepartment;
                    editForm.MasterEditPanel = pnlEdit;
                    editForm.PrimaryKeyControl = textDepartmentNo;
                    editForm.BrowseXtraGridView = gridViewDepartment;
                    editForm.CheckControl += CheckControl;
                    editForm.QueryDataAfter += QueryDataAfter;
                    this.pnlToolBar.Controls.Add(editForm);
                    editForm.Dock = DockStyle.Fill;
                    editForm.Show();

                    lookUpDept.Properties.DataSource = commonDAO.QueryDepartment_AllNode(false);
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + f.tsmiCtjzsjcw.Text, ex);
            }
        }

        /// <summary>
        /// 保存之前的回调方法
        /// </summary>
        public bool CheckControl()
        {
            if (textDepartmentNo.Text.Trim() == "")
            {
                MessageHandler.ShowMessageBox(tsmiBmbhbnwk.Text);// ("部门编号不能为空，请重新操作。");
                textDepartmentNo.Focus();
                return false;
            }
            if (textDepartmentName.Text.Trim() == "")
            {
                MessageHandler.ShowMessageBox(tsmiBmmcbnwk.Text);// ("部门名称不能为空，请重新操作。");
                textDepartmentName.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// 查询数据之后的回调方法
        /// </summary>
        public void QueryDataAfter()
        {
            treeListDept.ExpandAll();
        }

        /// <summary>
        /// 设定默认值
        /// </summary>
        private void TableDepartment_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            e.Row["Founder"] = SystemInfo.user.EmpName;
            e.Row["CreateDate"] = BaseSQL.GetServerDateTime();
            if (parentDepartmentNoStr != "")
            {
                e.Row["ParentDepartmentNo"] = parentDepartmentNoStr;
                e.Row["ParentDepartmentName"] = parentDepartmentNameStr;
                parentDepartmentNoStr = "";
                parentDepartmentNameStr = "";
            }
        }

        /// <summary>
        /// 右击弹出菜单
        /// </summary>
        private void treeListDept_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    treeListDept.ContextMenuStrip = null;

                    TreeListHitInfo hInfo = treeListDept.CalcHitInfo(new Point(e.X, e.Y));
                    TreeListNode node = hInfo.Node;
                    treeListDept.FocusedNode = node;
                    if (node != null)
                    {
                        popupMenuList.ShowPopup(Control.MousePosition);
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--右击弹出菜单错误。", ex);
            }
        }

        /// <summary>
        /// 新增同级部门
        /// </summary>
        private void barBtnSame_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (treeListDept.FocusedNode != null)
                {
                    parentDepartmentNoStr = DataTypeConvert.GetString(treeListDept.FocusedNode["ParentDepartmentNo"]);
                    parentDepartmentNameStr = DataTypeConvert.GetString(treeListDept.FocusedNode["ParentDepartmentName"]);
                    editForm.btnNew_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--新增同级部门错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiXztj.Text, ex);
                parentDepartmentNoStr = "";
                parentDepartmentNameStr = "";
            }
        }

        /// <summary>
        /// 新增下级部门
        /// </summary>
        private void barBtnDown_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (treeListDept.FocusedNode != null)
                {
                    parentDepartmentNoStr = DataTypeConvert.GetString(treeListDept.FocusedNode["DepartmentNo"]);
                    parentDepartmentNameStr = DataTypeConvert.GetString(treeListDept.FocusedNode["DepartmentName"]);
                    editForm.btnNew_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--新增下级部门错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiXzxj.Text, ex);
                parentDepartmentNoStr = "";
                parentDepartmentNameStr = "";
            }
        }

        /// <summary>
        /// 获取单元格显示的信息
        /// </summary>
        private void treeListDept_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                ControlHandler.TreeList_GetFocusedCellDisplayText_KeyDown(sender, e);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--获取单元格显示的信息错误。", ex);
            }
        }

        /// <summary>
        /// 选择节点之前设定控件状态
        /// </summary>
        private void treeListDept_BeforeFocusNode(object sender, BeforeFocusNodeEventArgs e)
        {
            try
            {
                if (bSDepartment.Current != null)
                { 
                    if (((DataRowView)bSDepartment.Current).IsEdit)
                    {
                        int oldId = e.OldNode == null ? 0 : DataTypeConvert.GetInt(e.OldNode["AutoId"]);
                        DataRow dr = ((DataRowView)bSDepartment.Current).Row;
                        if (dr.RowState == DataRowState.Added && oldId != 0)
                        {
                            return;
                        }
                        else
                        {
                            dr.RejectChanges();
                            editForm.Set_Button_State(true);
                            editForm.Set_EditZone_ControlReadOnly(true);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--选择节点之前设定控件状态错误。", ex);
            }
        }


    }
}
