using DevExpress.Skins;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using PSAP.DAO.BSDAO;
using PSAP.DAO.PURDAO;
using PSAP.PSAPCommon;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PSAP.VIEW.BSVIEW
{
    public partial class FrmTest_WF3 : DockContent
    {
        FrmCommonDAO commonDAO = new FrmCommonDAO();

        GridHitInfo GriddownHitInfo = null;

        DataTable dt2 = new DataTable();

        public FrmTest_WF3()
        {
            InitializeComponent();
            //设定按字体来缩放控件
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //设定字体大小为12px     
            //this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
        }

        private void FrmTest_WF3_Shown(object sender, EventArgs e)
        {
            dockPanel1.Width = this.Width / 2;
        }

        private void FrmTest_WF3_Load(object sender, EventArgs e)
        {
            try
            {
                gridControl1.DataSource = commonDAO.QueryDepartment(true);
                dt2 = commonDAO.QueryDepartment(true);
                dt2.Rows.Clear();
                gridControl2.DataSource = dt2;

            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
            }
        }

        #region 拖入

        private void gridControl2_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<DataRow>)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }


        private void gridControl2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void gridControl2_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                List<DataRow> drs = e.Data.GetData(typeof(List<DataRow>)) as List<DataRow>;
                if (drs != null)
                {
                    FillTreeData(sender, drs);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("系统提示", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void FillTreeData(object sender, List<DataRow> drs)
        {
            foreach (DataRow dr in drs)
            {
                this.gridView2.AddNewRow();
                gridView2.SetFocusedRowCellValue("AutoId", DataTypeConvert.GetInt(dr["AutoId"]));
                gridView2.SetFocusedRowCellValue("DepartmentNo", dr["DepartmentNo"].ToString());
                gridView2.SetFocusedRowCellValue("DepartmentName", dr["DepartmentName"].ToString());
            }
        }

        #endregion

        #region 拖出

        private void gridView1_MouseDown(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            GriddownHitInfo = null;
            GridHitInfo hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));

            if (Control.ModifierKeys != Keys.None)
                return;
            if (e.Button == MouseButtons.Left && hitInfo.RowHandle >= 0)
            {
                GriddownHitInfo = hitInfo;
            }
        }

        private void gridView1_MouseMove(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Button == MouseButtons.Left && GriddownHitInfo != null)
            {
                Size dragSize = SystemInformation.DragSize;
                Rectangle dragRect = new Rectangle(new Point(GriddownHitInfo.HitPoint.X - dragSize.Width / 2,
                    GriddownHitInfo.HitPoint.Y - dragSize.Height / 2), dragSize);

                if (!dragRect.Contains(new Point(e.X, e.Y)))
                {
                    int[] rowint = view.GetSelectedRows();
                    List<DataRow> row = new List<DataRow>();
                    foreach (int i in rowint)
                    {
                        row.Add(view.GetDataRow(i));
                    }
                    if (row != null && row.Count > 0)
                    {
                        view.GridControl.DoDragDrop(row, DragDropEffects.Move);
                        GriddownHitInfo = null;
                        DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                    }
                }
            }
        }

        #endregion

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            dt2.Rows.Clear();
        }

        private void barSubItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("I'm First!");
        }

        private void barSubItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("I'm Second!");
        }

        private void gridView2_RowClick(object sender, RowClickEventArgs e)
        {
            try
            {
                if (e.Button==MouseButtons.Right)
                {
                    popupMenu1.ShowPopup(Control.MousePosition);
                }

            }
            catch(Exception ex)
            {

            }
        }
    }
}
