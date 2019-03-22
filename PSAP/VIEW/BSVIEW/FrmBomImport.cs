using PSAP.DAO.BSDAO;
using PSAP.PSAPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.Linq;

namespace PSAP.VIEW.BSVIEW
{
    public partial class FrmBomImport : DockContent
    {
        FrmCommonDAO commonDAO = new FrmCommonDAO();
        FrmBomManagementDAO bomDAO = new FrmBomManagementDAO();

        public FrmBomImport()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmBomImport_Load(object sender, EventArgs e)
        {
            try
            {
                repSearchCodeFileName.DataSource = commonDAO.QueryPartsCode(false);


            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
            }
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewBom_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        /// <summary>
        /// 导入Excel文件
        /// </summary>
        private void btnExcel2007_Click(object sender, EventArgs e)
        {
            try
            {
                //TableBom.Clear();

                //string sqlStr = "select MaterielNo as MotherCodeFileName, mpc.CodeName as MotherCodeName, LevelMaterielNo as SubCodeFileName, spc.CodeName as SubCodeName, Qty from BS_BomMateriel left join SW_PartsCode as mpc on BS_BomMateriel.MaterielNo = mpc.CodeFileName left join SW_PartsCode as spc on BS_BomMateriel.LevelMaterielNo = spc.CodeFileName";
                //BaseSQL.Query(sqlStr, TableBom);

                OpenFileDialog fileDlg = new OpenFileDialog();
                fileDlg.Filter = "Microsoft Excel files(*.xlsx)|*.xlsx";
                fileDlg.Title = "打开Excel文件";
                string path = "";
                fileDlg.InitialDirectory = "D:\\";
                fileDlg.FilterIndex = 1;
                if (fileDlg.ShowDialog() == DialogResult.OK)
                {
                    path = fileDlg.FileName;

                    TableBom.Clear();
                    new FileHandler().ExcelToDataTable(TableBom, path);

                    MessageHandler.ShowMessageBox(string.Format("Excel文件中查询到{0}条记录。", TableBom.Rows.Count));
                }

                SetComboBoxItems();
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--导入Excel文件错误。", ex);
            }
        }

        /// <summary>
        /// 导入Excel的Bom信息的模板下载
        /// </summary>
        private void btnModuleDownload_Click(object sender, EventArgs e)
        {
            try
            {
                string sourceFilePath = Application.StartupPath + "\\Report\\BomModule.xlsx";
                if (File.Exists(sourceFilePath))
                {

                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "Microsoft Excel files(*.xlsx)|*.xlsx";
                    sfd.Title = "Bom信息模板文件保存到";
                    sfd.FilterIndex = 1;
                    sfd.FileName = "BomModule";
                    sfd.InitialDirectory = "D:\\";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        string targetFilePath = sfd.FileName.ToString();

                        File.Copy(sourceFilePath, targetFilePath, true);
                        MessageHandler.ShowMessageBox("Bom信息模板文件下载成功。");

                    }
                }
                else
                    MessageHandler.ShowMessageBox("找不到源Bom信息模板文件，请联系软件的供应商。");
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--导入Excel的Bom信息的模板下载错误。", ex);
            }
        }

        /// <summary>
        /// 清除显示的数据
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            dSBom.Tables[0].Rows.Clear();
        }

        /// <summary>
        /// 删除当前选中的行信息
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridViewBom.DataRowCount < 1)
                    return;

                if (MessageHandler.ShowMessageBox_YesNo(string.Format("确认删除当前选中的{0}行信息吗？", gridViewBom.SelectedRowsCount)) == DialogResult.Yes)
                {
                    gridViewBom.DeleteSelectedRows();
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--删除当前选中的行信息错误。", ex);
            }
        }

        /// <summary>
        /// 设定母物料编号的下拉选项
        /// </summary>
        private void SetComboBoxItems()
        {
            comboBoxMother.Properties.Items.Clear();

            //if (dSBom.Tables[0].Rows.Count > 0)
            //{
            //    var query = from g in dSBom.Tables[0].AsEnumerable()
            //                group g by new { t1 = g.Field<string>("MotherCodeFileName") } into cfnList
            //                select new { MotherCodeFileName = cfnList.Key.t1, StallInfo = cfnList };
            //    foreach (var cfnInfo in query)
            //    {
            //        comboBoxMother.Properties.Items.Add(cfnInfo.MotherCodeFileName);
            //    }
            //}

            if (dSBom.Tables[0].Rows.Count > 0)
            {
                DataView dv = new DataView(dSBom.Tables[0]);
                DataTable rootTable = dv.ToTable(true, "MotherCodeFileName");
                foreach (DataRow dr in rootTable.Rows)
                {                    
                    comboBoxMother.Properties.Items.Add(DataTypeConvert.GetString(dr["MotherCodeFileName"]));
                }
            }
        }

        /// <summary>
        /// 选择删除当前选择的Bom信息
        /// </summary>
        private void btnMother_Click(object sender, EventArgs e)
        {
            try
            {
                string bomCFNStr = comboBoxMother.Text.Trim();
                DataRow[] drs = dSBom.Tables[0].Select(string.Format("MotherCodeFileName='{0}'", bomCFNStr));
                if (drs.Length > 0)
                {
                    if (MessageHandler.ShowMessageBox_YesNo(string.Format("确认删除Bom[{0}]的{1}条记录吗？", bomCFNStr, drs.Length)) == DialogResult.Yes)
                    {
                        for (int i = drs.Length - 1; i >= 0; i--)
                        {
                            dSBom.Tables[0].Rows.Remove(drs[i]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--删除当前选中的行信息错误。", ex);
            }
        }

        /// <summary>
        /// 将当前导入的信息更新到数据库中
        /// </summary>
        private void btnUpdateDB_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckData())
                    return;

                if (MessageHandler.ShowMessageBox_YesNo("确认将下面显示的Bom信息更新到数据库中？") == DialogResult.Yes)
                {
                    bomDAO.SaveImportBom(dSBom.Tables[0]);
                    MessageHandler.ShowMessageBox("更新数据库成功。");
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--将当前导入的信息更新到数据库中错误。", ex);
            }
        }

        /// <summary>
        /// 检查数据的合理性
        /// </summary>
        private bool CheckData()
        {
            if (gridViewBom.DataRowCount == 0)
            {
                MessageHandler.ShowMessageBox("当前显示的数据行数为0，无法检查更新数据库。");
                return false;
            }

            for (int i = 0; i < gridViewBom.DataRowCount; i++)
            {
                for (int j = 0; j < gridViewBom.Columns.Count; j++)
                {
                    bool isLookup = false;
                    string columnStr = gridViewBom.Columns[j].FieldName;

                    #region 检测数据是否为空

                    switch (columnStr)
                    {
                        case "Qty"://数值类型
                            if (DataTypeConvert.GetString(gridViewBom.GetDataRow(i)[columnStr]) == ""||DataTypeConvert.GetDouble(gridViewBom.GetDataRow(i)[columnStr])==0)
                            {
                                MessageHandler.ShowMessageBox("数值字段为空或者0，请填写后再进行检查。");
                                gridCrlBom.Focus();
                                gridViewBom.FocusedRowHandle = i;
                                gridViewBom.FocusedColumn = gridViewBom.Columns[j];
                                return false;
                            }
                            break;
                        case "MotherCodeFileName"://选项类型
                        case "SubCodeFileName":
                            if (DataTypeConvert.GetString(gridViewBom.GetDataRow(i)[columnStr]) == "")
                            {
                                MessageHandler.ShowMessageBox("选项字段为空，请填写后再进行检查。");
                                gridCrlBom.Focus();
                                gridViewBom.FocusedRowHandle = i;
                                gridViewBom.FocusedColumn = gridViewBom.Columns[j];
                                return false;
                            }
                            isLookup = true;
                            break;
                    }

                    #endregion

                    #region 检测选项是否是正常选项

                    if(isLookup)
                    {
                        string lookupValue = DataTypeConvert.GetString(gridViewBom.GetDataRow(i)[columnStr]);
                        if ((((DataTable)repSearchCodeFileName.DataSource).Select(string.Format("CodeFileName='{0}'", lookupValue))).Length <= 0)
                        {
                            MessageHandler.ShowMessageBox("选项是非正常选项，请重新选择后再进行检查。");
                            gridCrlBom.Focus();
                            gridViewBom.FocusedRowHandle = i;
                            gridViewBom.FocusedColumn = gridViewBom.Columns[j];
                            return false;
                        }
                    }

                    #endregion
                }
            }

            #region 检测Bom信息是否存在

            DataView dv = new DataView(dSBom.Tables[0]);
            DataTable rootTable = dv.ToTable(true, "MotherCodeFileName");
            foreach (DataRow dr in rootTable.Rows)
            {
                string mCodeFileNameStr = DataTypeConvert.GetString(dr["MotherCodeFileName"]);
                if (bomDAO.QueryBom_CodeFileNameCount(mCodeFileNameStr) > 0)
                {
                    MessageHandler.ShowMessageBox(string.Format("Bom信息[{0}]在数据库中已经存在，不可以重复添加。", mCodeFileNameStr));
                    comboBoxMother.Text = mCodeFileNameStr;
                    comboBoxMother.Focus();
                    return false;
                }
            }

            #endregion

            #region 检测母物料的记录中是否有重复的子物料信息

            for(int i = 0;i< gridViewBom.DataRowCount; i++)
            {
                string mCodeFileNameStr = DataTypeConvert.GetString(gridViewBom.GetDataRow(i)["MotherCodeFileName"]);
                string subCodeFileNameStr= DataTypeConvert.GetString(gridViewBom.GetDataRow(i)["SubCodeFileName"]);
                DataRow[] drs = dSBom.Tables[0].Select(string.Format("MotherCodeFileName='{0}' and SubCodeFileName='{1}'", mCodeFileNameStr, subCodeFileNameStr));
                if(drs.Length>1)
                {
                    MessageHandler.ShowMessageBox(string.Format("母物料编号[{0}]中得子物料编号[{1}]有重复记录，不可以更新数据库。", mCodeFileNameStr, subCodeFileNameStr));
                    gridCrlBom.Focus();
                    gridViewBom.FocusedRowHandle = i;
                    return false;
                }
            }

            #endregion

            return true;
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            try
            {
                FileHandler.SaveDevGridControlExportToExcel(gridViewBom);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--查询结果存为Excel错误。", ex);
            }
        }
    }
}
