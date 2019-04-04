using PSAP.DAO.BSDAO;
using PSAP.PSAPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PSAP.VIEW.BSVIEW
{
    public partial class FrmBussinessInfo : DockContent
    {
        public FrmBussinessInfo()
        {
            InitializeComponent();
            InitEnableState();//初始化控件Enable状态
            FrmBussinessInfoDAO.InitBussinessBaseInfo(dataSet1);
            gdvBussinessBaseInfo.IndicatorWidth = 45;
        }

        /// <summary>
        /// 初始化控件Enable状态
        /// </summary>
        private void InitEnableState()
        {
            pnlEdit.Enabled = false;
            pnlEdit1.Enabled = false;
            gdvBussinessBaseInfo.OptionsBehavior.Editable = false;//
            tsbSave.Enabled = false;
            tsbCancel.Enabled = false;
        }

        /// <summary>
        /// panel（pnlEdit）的Enabled属性设置为“False”，表示最开始panel里面的控件都设置为不可编辑状态
        /// 保存了、取消初始Enable为"False"
        /// 将数据导航条、GroupBox、新增、修改、删除、保存、取消的Enabled状态取反
        /// </summary>
        private void ChangeEnabledState()
        {
            pnlEdit.Enabled = !pnlEdit.Enabled;
            pnlEdit1.Enabled = !pnlEdit1.Enabled;
            gdvBussinessBaseInfo.OptionsBehavior.Editable = !gdvBussinessBaseInfo.OptionsBehavior.Editable;//
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

        private void FrmBussinessInfo_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dsPSAP.BS_CountryCodeManagement”中。您可以根据需要移动或删除它。
            this.bS_CountryCodeManagementTableAdapter.Fill(this.dsPSAP.BS_CountryCodeManagement);
            // TODO: 这行代码将数据加载到表“dsPSAP.BS_BussinessCategory”中。您可以根据需要移动或删除它。
            this.bS_BussinessCategoryTableAdapter.Fill(this.dsPSAP.BS_BussinessCategory);

            try
            {
                lueCountryCode.Properties.DataSource = BaseSQL.Query("select * from BS_CountryCodeManagement").Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //gdvBussinessBaseInfo.Columns[1].OptionsColumn.ReadOnly = false;//列可编辑
                headFocusedLineNo = gdvBussinessBaseInfo.RowCount;//记录新增记录行号
                newRowFlag = 1;
                ChangeEnabledState();//更改控件状态
                gdvBussinessBaseInfo.AddNewRow();
                gdvBussinessBaseInfo.SetFocusedRowCellValue("BussinessIsUse", 1);
                dataSet1.Tables["BussinessDetailInfo"].Clear();
                DataRow dr = dataSet1.Tables["BussinessDetailInfo"].NewRow();
                dataSet1.Tables["BussinessDetailInfo"].Rows.Add(dr);

                dataSet1.Tables["BussinessFinancialInfo"].Clear();
                dr = dataSet1.Tables["BussinessFinancialInfo"].NewRow();
                dataSet1.Tables["BussinessFinancialInfo"].Rows.Add(dr);
                tabBussinessInfo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            //gdvBussinessBaseInfo.Columns[1].OptionsColumn.ReadOnly = true;//列只读
            newRowFlag = 2;//编辑
            headFocusedLineNo = gdvBussinessBaseInfo.FocusedRowHandle;//记录新增记录行号
            ChangeEnabledState();//更改控件状态
            gdvBussinessBaseInfo.Focus();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (bsBase.Current != null)//当前是否有数据
            {
                if (MessageBox.Show("确实要删除吗?", "确认", MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question) == DialogResult.Yes)
                //{
                //    //删除相关数据
                //    FrmBussinessInfoDAO.DeleteBussinessCorrelationData(gdvBussinessBaseInfo.GetRowCellValue
                //        (gdvBussinessBaseInfo.GetSelectedRows()[0], "BussinessBaseNo").ToString());//删除相关数据
                //    int index = bsDetail.Find("BussinessBaseNo", gdvBussinessBaseInfo.GetRowCellValue(gdvBussinessBaseInfo.GetSelectedRows()[0], "BussinessBaseNo").ToString());
                //    if (index != -1)
                //    {
                //        bsDetail.Position = index;//定位BindingSource
                //        bsDetail.RemoveCurrent();
                //    }

                //    index = bsFina.Find("BussinessBaseNo", gdvBussinessBaseInfo.GetRowCellValue(gdvBussinessBaseInfo.GetSelectedRows()[0], "BussinessBaseNo").ToString());
                //    if (index != -1)
                //    {
                //        bsFina.Position = index;//定位BindingSource
                //        bsFina.RemoveCurrent();
                //    }
                //    bsBase.RemoveCurrent();//
                //}
                {
                    //删除相关数据
                    if (FrmBussinessInfoDAO.DeleteBussinessCorrelationData(gdvBussinessBaseInfo.GetRowCellValue
                         (gdvBussinessBaseInfo.GetSelectedRows()[0], "BussinessBaseNo").ToString(),dataSet1)) //删除相关数据
                    {
                        int index = bsDetail.Find("BussinessBaseNo", gdvBussinessBaseInfo.GetRowCellValue(gdvBussinessBaseInfo.GetSelectedRows()[0], "BussinessBaseNo").ToString());
                        if (index != -1)
                        {
                            bsDetail.Position = index;//定位BindingSource
                            bsDetail.RemoveCurrent();
                        }

                        index = bsFina.Find("BussinessBaseNo", gdvBussinessBaseInfo.GetRowCellValue(gdvBussinessBaseInfo.GetSelectedRows()[0], "BussinessBaseNo").ToString());
                        if (index != -1)
                        {
                            bsFina.Position = index;//定位BindingSource
                            bsFina.RemoveCurrent();
                        }
                        //bsBase.RemoveCurrent();//
                        gdvBussinessBaseInfo.DeleteSelectedRows();
                    }
                }

            }
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            //gdvBussinessBaseInfo;
            //Validate();
            if (string.IsNullOrEmpty(gdvBussinessBaseInfo.GetFocusedDataRow()["BussinessBaseNo"].ToString()))
            {
                MessageBox.Show("【往来方编号】为必填项！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(gdvBussinessBaseInfo.GetFocusedDataRow()["BussinessBaseText"].ToString()))
            {
                MessageBox.Show("【往来方名称】为必填项！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (newRowFlag == 1 && FrmBussinessInfoDAO.ExistsBussinessBaseInfoNo(gdvBussinessBaseInfo))
            {
                MessageBox.Show("此【往来方编号】已经存在！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Validate();
            bsBase.EndEdit();
            bsDetail.EndEdit();
            bsFina.EndEdit();
            FrmBussinessInfoDAO.SaveBussinessBaseInfo(dataSet1);
            ChangeEnabledState();//保存后更新控件状态
            newRowFlag = 0;
        }

        private void gdvBussinessBaseInfo_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
        }

        /// <summary>
        /// 主表聚焦的行号
        /// </summary>        
        int headFocusedLineNo = 0;
        int newRowFlag = 0;

        /// <summary>
        /// 禁止在编辑状态时换行 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gdvBussinessBaseInfo_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRowState st = gdvBussinessBaseInfo.GetFocusedDataRow().RowState;

            if ((newRowFlag == 1 || newRowFlag == 2) && gdvBussinessBaseInfo.GetFocusedDataRow().RowState != DataRowState.Added && gdvBussinessBaseInfo.GetFocusedDataRow().RowState != DataRowState.Detached)
            {
                gdvBussinessBaseInfo.FocusedRowHandle = headFocusedLineNo;
                FrmMain.frmMain.tsrLblCurrentStatusText = "请在【保存】或【取消】当前编辑后再进行换行操作！";
                return;
            }
            else
            {
                FrmMain.frmMain.tsrLblCurrentStatusText = "";
            }

            if (gdvBussinessBaseInfo.GetFocusedDataRow() != null)
            {
                //新建换行控制
                if (newRowFlag != 1 && newRowFlag != 2 && gdvBussinessBaseInfo.GetFocusedDataRow().RowState != DataRowState.Added)
                {
                    FrmBussinessInfoDAO.GetChildTableData(dataSet1, gdvBussinessBaseInfo);
                }
            }
        }

        private void tsbCancel_Click(object sender, EventArgs e)
        {
            if (newRowFlag == 1)
            {
                gdvBussinessBaseInfo.DeleteSelectedRows();
            }
            ChangeEnabledState();
            gdvBussinessBaseInfo.CancelUpdateCurrentRow();
            bsDetail.CancelEdit();
            bsFina.CancelEdit();
            newRowFlag = 0;
        }

        /// <summary>
        /// 行号
        /// </summary>
        private void gdvBussinessBaseInfo_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            ControlHandler.GridView_CustomDrawRowIndicator(e);
        }

        private void gdvBussinessBaseInfo_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (newRowFlag == 1)
                {
                    if (e.Column.FieldName == "BussinessBaseNo")
                    {
                        dataSet1.Tables["BussinessDetailInfo"].Rows[0]["BussinessBaseNo"] = gdvBussinessBaseInfo.GetFocusedDataRow()["BussinessBaseNo"].ToString();
                        dataSet1.Tables["BussinessFinancialInfo"].Rows[0]["BussinessBaseNo"] = gdvBussinessBaseInfo.GetFocusedDataRow()["BussinessBaseNo"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pnlEdit_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gdvBussinessBaseInfo_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

