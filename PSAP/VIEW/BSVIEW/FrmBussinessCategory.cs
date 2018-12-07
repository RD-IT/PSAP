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
    public partial class FrmBussinessCategory : DockContent
    {
        int headFocusedLineNo = 0;
        int newRowFlag = 0;
        public FrmBussinessCategory()
        {
            InitializeComponent();
            InitEnableState();//初始化控件Enable状态
            FrmBussinessCategoryDAO.InitBussinessCategory(dataSet1);
            gdvBussinessCategory.IndicatorWidth = 45;

        }

        /// <summary>
        /// 初始化控件Enable状态
        /// </summary>
        private void InitEnableState()
        {
            gdvBussinessCategory.OptionsBehavior.Editable = false;
            tsbSave.Enabled = false;
            tsbCancel.Enabled = false;
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 行号
        /// </summary>
        private void gdvBussinessBaseInfo_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        /// <summary>
        /// panel（pnlEdit）的Enabled属性设置为“False”，表示最开始panel里面的控件都设置为不可编辑状态
        /// 保存了、取消初始Enable为"False"
        /// 将数据导航条、GroupBox、新增、修改、删除、保存、取消的Enabled状态取反
        /// </summary>
        private void ChangeEnabledState()
        {
            gdvBussinessCategory.OptionsBehavior.Editable = !gdvBussinessCategory.OptionsBehavior.Editable;//
            foreach (ToolStripButton b in tsControl.Items)
            {
                b.Enabled = !b.Enabled;
            }

            //检测窗口状态：编辑="EDIT"，浏览=""
            if (((Label)this.Controls["lblEditFlag"]).Text == "")
            {
                ((Label)this.Controls["lblEditFlag"]).Text = "EDIT";
            }
            else
            {
                ((Label)this.Controls["lblEditFlag"]).Text = "";
            }
        }


        private void tsbAdd_Click(object sender, EventArgs e)
        {
            try
            {
                headFocusedLineNo = gdvBussinessCategory.RowCount;//记录新增记录行号
                newRowFlag = 1;
                ChangeEnabledState();//更改控件状态
                gdvBussinessCategory.AddNewRow();
                gdvBussinessCategory.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            newRowFlag = 2;//编辑
            headFocusedLineNo = gdvBussinessCategory.FocusedRowHandle;//记录新增记录行号
            ChangeEnabledState();//更改控件状态
            gdvBussinessCategory.Focus();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (gdvBussinessCategory.GetFocusedDataRow() != null)//当前是否有数据
            {
                if (MessageBox.Show("确实要删除吗?", "确认", MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //删除相关数据
                    if (FrmBussinessCategoryDAO.DeleteBussinessCategoryData(gdvBussinessCategory.GetRowCellValue
                        (gdvBussinessCategory.GetSelectedRows()[0], "BussinessCategory").ToString(), dataSet1)) //删除相关数据
                    {
                        gdvBussinessCategory.DeleteSelectedRows();
                    }
                }
            }
        }

        private void tsbCancel_Click(object sender, EventArgs e)
        {

            if (newRowFlag == 1)
            {
                gdvBussinessCategory.DeleteSelectedRows();
            }

            ChangeEnabledState();
            gdvBussinessCategory.CancelUpdateCurrentRow();
            newRowFlag = 0;
        }

        /// <summary>
        /// 禁止在编辑状态下换行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gdvBussinessCategory_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRowState st = gdvBussinessCategory.GetFocusedDataRow().RowState;
            if ((newRowFlag == 1 || newRowFlag == 2) && gdvBussinessCategory.GetFocusedDataRow().RowState != DataRowState.Added && gdvBussinessCategory.GetFocusedDataRow().RowState != DataRowState.Detached)
            {
                gdvBussinessCategory.FocusedRowHandle = headFocusedLineNo;
                FrmMain.frmMain.tsrLblCurrentStatusText = "请在【保存】或【取消】当前编辑后再进行换行操作！";
                return;
            }
            else
            {
                FrmMain.frmMain.tsrLblCurrentStatusText = "";
            }
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gdvBussinessCategory.GetFocusedDataRow()["BussinessCategory"].ToString()))
            {
                MessageBox.Show("【往来类别编号】为必填项！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (newRowFlag == 1 && FrmBussinessCategoryDAO.ExistsBussinessCategory(gdvBussinessCategory))
            {
                MessageBox.Show("此【往来类别编号】已经存在！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Validate();
            FrmBussinessCategoryDAO.SaveBussinessCategory(dataSet1);
            ChangeEnabledState();//保存后更新控件状态
            newRowFlag = 0;

        }

        private void tsbDGViewExportToCSV_Click(object sender, EventArgs e)
        {
            //psapCommon.DataGridViewExportToCSV(gdvBussinessCategory, psapCommon.GetDateNumber("部门信息"));
        }
    }
}
