using PSAP.DAO.BSDAO;
using PSAP.PSAPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PSAP.VIEW.BSVIEW
{
    public partial class FrmPartsCodeImport : DockContent
    {
        FrmCommonDAO commonDAO = new FrmCommonDAO();
        FrmPartsCodeDAO pcDAO = new FrmPartsCodeDAO();

        public FrmPartsCodeImport()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmPartsCodeImport_Load(object sender, EventArgs e)
        {
            try
            {
                repSearchLookUpMaterial.DataSource = commonDAO.QueryMaterialSelectLib(false);

                repLookUpCatgName.DataSource = commonDAO.QueryPartNoCatg(false);
                repLookUpBrand.DataSource = commonDAO.QueryBrandCatg(false);
                repLookUpFinish.DataSource = commonDAO.QueryFinishCatg(false);
                repLookUpMachiningLevel.DataSource = commonDAO.QueryLevelCatg(false);
                repLookUpUnit.DataSource = commonDAO.QueryUnitCatg(false);

                comboBoxColumn.Properties.Items.Clear();
                for (int i = 0; i < TablePartsCode.Columns.Count; i++)
                {
                    comboBoxColumn.Properties.Items.Add(TablePartsCode.Columns[i].ColumnName);
                }

                comboBoxColumn.Properties.Items.Remove("AutoId");
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
            }
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewPartsCode_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
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
                OpenFileDialog fileDlg = new OpenFileDialog();
                fileDlg.Filter = "Microsoft Excel files(*.xlsx)|*.xlsx";
                fileDlg.Title = "打开Excel文件";
                string path = "";
                fileDlg.InitialDirectory = "D:\\";
                fileDlg.FilterIndex = 1;
                if (fileDlg.ShowDialog() == DialogResult.OK)
                {
                    path = fileDlg.FileName;

                    TablePartsCode.Clear();
                    DataTable queryDataTable = new DataTable();
                    new FileHandler().ExcelToDataTable(queryDataTable, path);
                    for (int i = 0; i < queryDataTable.Rows.Count; i++)
                    {
                        DataRow dr = TablePartsCode.NewRow();
                        for (int j = 0; j < TablePartsCode.Columns.Count; j++)
                        {
                            if (queryDataTable.Columns.Contains(TablePartsCode.Columns[j].ColumnName))
                            {
                                dr[TablePartsCode.Columns[j].ColumnName] = queryDataTable.Rows[i][TablePartsCode.Columns[j].ColumnName];
                            }
                        }

                        TablePartsCode.Rows.Add(dr);
                    }
                    MessageHandler.ShowMessageBox(string.Format("Excel文件中查询到{0}条记录。", TablePartsCode.Rows.Count));
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--导入Excel文件错误。", ex);
            }
        }

        /// <summary>
        /// 导入Excel物料信息的模板下载
        /// </summary>
        private void btnModuleDownload_Click(object sender, EventArgs e)
        {
            try
            {
                string sourceFilePath = Application.StartupPath + "\\Report\\PartsCodeModule.xlsx";
                if (File.Exists(sourceFilePath))
                {

                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "Microsoft Excel files(*.xlsx)|*.xlsx";
                    sfd.Title = "物料信息模板文件保存到";
                    sfd.FilterIndex = 1;
                    sfd.FileName = "PartsCodeModule";
                    sfd.InitialDirectory = "D:\\";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        string targetFilePath = sfd.FileName.ToString();

                        File.Copy(sourceFilePath, targetFilePath, true);
                        MessageHandler.ShowMessageBox("物料信息模板文件下载成功。");

                    }
                }
                else
                    MessageHandler.ShowMessageBox("找不到源物料信息模板文件，请联系软件的供应商。");
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--导入Excel物料信息的模板下载错误。", ex);
            }
        }

        /// <summary>
        /// 清除显示的数据
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            dSPartsCode.Tables[0].Rows.Clear();
        }

        /// <summary>
        /// 选择列名进行修改
        /// </summary>
        private void comboBoxColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                bool isLookup = false;
                string itemStr = DataTypeConvert.GetString(comboBoxColumn.SelectedItem);
                switch (itemStr)
                {
                    case "CodeWeight"://数值类型
                        textValue.Visible = false;
                        lookUpValue.Visible = false;
                        checkValue.Visible = false;
                        dateValue.Visible = false;
                        spinValue.Visible = true;

                        spinValue.Location = new Point(380, 82);
                        break;
                    case "GetTime"://日期类型
                        textValue.Visible = false; 
                        lookUpValue.Visible = false; 
                        checkValue.Visible = false; 
                        dateValue.Visible = true;
                        spinValue.Visible = false; 

                        dateValue.Location = new Point(380, 82);
                        break;
                    case "IsPreferred"://选择类型
                    case "IsLongPeriod":
                    case "IsPrecious":
                    case "IsPreprocessing":
                        textValue.Visible = false;
                        lookUpValue.Visible = false;
                        checkValue.Visible = true;
                        dateValue.Visible = false;
                        spinValue.Visible = false;

                        checkValue.Location = new Point(380, 82);
                        break;
                    case "CatgName"://选项类型
                    case "Brand":
                    case "Finish":
                    case "MachiningLevel":
                    case "Unit":
                    case "Material":
                        isLookup = true;
                        textValue.Visible = false;
                        lookUpValue.Visible = true;
                        checkValue.Visible = false;
                        dateValue.Visible = false;
                        spinValue.Visible = false;

                        lookUpValue.Location = new Point(380, 82);
                        break;
                    default://文本类型
                        textValue.Visible = true;
                        lookUpValue.Visible = false;
                        checkValue.Visible = false;
                        dateValue.Visible = false;
                        spinValue.Visible = false;

                        textValue.Location = new Point(380, 82);
                        break;
                }

                if (isLookup)//设定LookUpEdit类型控件的数据源，显示成员和值成员
                {
                    lookUpValue.Properties.Columns.Clear();
                    switch (itemStr)
                    {
                        case "CatgName":
                            lookUpValue.Properties.DataSource = commonDAO.QueryPartNoCatg(false);
                            lookUpValue.Properties.DisplayMember = "CatgName";
                            lookUpValue.Properties.ValueMember = "CatgName";
                            break;
                        case "Brand":
                            lookUpValue.Properties.DataSource = commonDAO.QueryBrandCatg(false);
                            lookUpValue.Properties.DisplayMember = "BrandName";
                            lookUpValue.Properties.ValueMember = "BrandName";
                            break;
                        case "Finish":
                            lookUpValue.Properties.DataSource = commonDAO.QueryFinishCatg(false);
                            lookUpValue.Properties.DisplayMember = "FinishCatg";
                            lookUpValue.Properties.ValueMember = "AutoId";
                            break;
                        case "MachiningLevel":
                            lookUpValue.Properties.DataSource = commonDAO.QueryLevelCatg(false);
                            lookUpValue.Properties.DisplayMember = "LevelCatg";
                            lookUpValue.Properties.ValueMember = "AutoId";
                            break;
                        case "Unit":
                            lookUpValue.Properties.DataSource = commonDAO.QueryUnitCatg(false);
                            lookUpValue.Properties.DisplayMember = "UnitName";
                            lookUpValue.Properties.ValueMember = "UnitName";
                            break;
                        case "Material":
                            lookUpValue.Properties.DataSource = commonDAO.QueryMaterialSelectLib(false);
                            lookUpValue.Properties.DisplayMember = "MaterialName";
                            lookUpValue.Properties.ValueMember = "AutoId";
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--选择列名进行修改错误。", ex);
            }
        }

        /// <summary>
        /// 更新当前显示的数据信息
        /// </summary>
        private void btnUpdateGrid_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxColumn.SelectedIndex < 0)
                    return;

                if (gridViewPartsCode.DataRowCount < 1)
                {
                    MessageHandler.ShowMessageBox("请先导入Excel数据后再进行修改。");
                    return;
                }

                string itemStr = DataTypeConvert.GetString(comboBoxColumn.SelectedItem);

                switch (itemStr)
                {
                    case "CodeWeight"://数值类型
                        for (int i = 0; i < gridViewPartsCode.DataRowCount; i++)
                        {
                            if(checkNull.Checked)
                            {
                                if(DataTypeConvert.GetString(gridViewPartsCode.GetDataRow(i)[itemStr])=="")
                                    gridViewPartsCode.GetDataRow(i)[itemStr] = spinValue.Value;
                            }
                            else
                                gridViewPartsCode.GetDataRow(i)[itemStr] = spinValue.Value;
                        }
                        break;
                    case "GetTime"://日期类型
                        for (int i = 0; i < gridViewPartsCode.DataRowCount; i++)
                        {
                            if (checkNull.Checked)
                            {
                                if (DataTypeConvert.GetString(gridViewPartsCode.GetDataRow(i)[itemStr]) == "")
                                    gridViewPartsCode.GetDataRow(i)[itemStr] = dateValue.DateTime;
                            }
                            else
                                gridViewPartsCode.GetDataRow(i)[itemStr] = dateValue.DateTime;
                        }
                        break;
                    case "IsPreferred"://选择类型
                    case "IsLongPeriod":
                    case "IsPrecious":
                    case "IsPreprocessing":
                        for (int i = 0; i < gridViewPartsCode.DataRowCount; i++)
                        {
                            if (checkNull.Checked)
                            {
                                if (DataTypeConvert.GetString(gridViewPartsCode.GetDataRow(i)[itemStr]) == "")
                                    gridViewPartsCode.GetDataRow(i)[itemStr] = checkValue.Checked;
                            }
                            else
                                gridViewPartsCode.GetDataRow(i)[itemStr] = checkValue.Checked;
                        }
                        break;
                    case "CatgName"://选项类型
                    case "Brand":
                    case "Finish":
                    case "MachiningLevel":
                    case "Unit":
                    case "Material":
                        for (int i = 0; i < gridViewPartsCode.DataRowCount; i++)
                        {
                            if (checkNull.Checked)
                            {
                                if (DataTypeConvert.GetString(gridViewPartsCode.GetDataRow(i)[itemStr]) == "")
                                    gridViewPartsCode.GetDataRow(i)[itemStr] = lookUpValue.EditValue;
                            }
                            else
                                gridViewPartsCode.GetDataRow(i)[itemStr] = lookUpValue.EditValue;
                        }
                        break;
                    default://文本类型
                        for (int i = 0; i < gridViewPartsCode.DataRowCount; i++)
                        {
                            if (checkNull.Checked)
                            {
                                if (DataTypeConvert.GetString(gridViewPartsCode.GetDataRow(i)[itemStr]) == "")
                                    gridViewPartsCode.GetDataRow(i)[itemStr] = textValue.Text;
                            }
                            else
                                gridViewPartsCode.GetDataRow(i)[itemStr] = textValue.Text;
                        }
                        break;
                }
                        
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--更新当前显示的数据信息错误。", ex);
            }
        }

        /// <summary>
        /// 检查数据的合理性
        /// </summary>
        private bool CheckData()
        {
            if (gridViewPartsCode.DataRowCount == 0)
            {
                MessageHandler.ShowMessageBox("当前显示的数据行数为0，无法检查更新数据库。");
                return false;
            }

            for (int i = 0; i < gridViewPartsCode.DataRowCount; i++)
            {
                for (int j = 0; j < gridViewPartsCode.Columns.Count; j++)
                {
                    bool isLookup = false;
                    string columnStr = gridViewPartsCode.Columns[j].FieldName;

                    #region 检测数据是否为空

                    switch (columnStr)
                    {
                        case "CodeFileName"://文本类型
                        case "CodeNo":
                        case "CodeName":
                        case "FilePath":
                        case "CodeSpec":
                        case "MaterialVersion":
                        case "Designer":
                        case "Tel":
                            if (DataTypeConvert.GetString(gridViewPartsCode.GetDataRow(i)[columnStr]) == "")
                            {
                                MessageHandler.ShowMessageBox("文本字段为空，请填写后再进行检查。");
                                gridCrlPartsCode.Focus();
                                gridViewPartsCode.FocusedRowHandle = i;
                                gridViewPartsCode.FocusedColumn = gridViewPartsCode.Columns[j];
                                return false;
                            }
                            break;
                        case "GetTime"://日期类型
                            if (DataTypeConvert.GetString(gridViewPartsCode.GetDataRow(i)[columnStr]) == "")
                            {
                                MessageHandler.ShowMessageBox("日期字段为空，请填写后再进行检查。");
                                gridCrlPartsCode.Focus();
                                gridViewPartsCode.FocusedRowHandle = i;
                                gridViewPartsCode.FocusedColumn = gridViewPartsCode.Columns[j];
                                return false;
                            }
                            break;
                        case "IsPreferred"://选择类型
                        case "IsLongPeriod":
                        case "IsPrecious":
                        case "IsPreprocessing":
                            if (DataTypeConvert.GetString(gridViewPartsCode.GetDataRow(i)[columnStr]) == "")
                            {
                                MessageHandler.ShowMessageBox("选择字段为空，请填写后再进行检查。");
                                gridCrlPartsCode.Focus();
                                gridViewPartsCode.FocusedRowHandle = i;
                                gridViewPartsCode.FocusedColumn = gridViewPartsCode.Columns[j];
                                return false;
                            }
                            break;
                        case "CodeWeight"://数值类型
                            if (DataTypeConvert.GetString(gridViewPartsCode.GetDataRow(i)[columnStr]) == "")
                            {
                                MessageHandler.ShowMessageBox("数值字段为空，请填写后再进行检查。");
                                gridCrlPartsCode.Focus();
                                gridViewPartsCode.FocusedRowHandle = i;
                                gridViewPartsCode.FocusedColumn = gridViewPartsCode.Columns[j];
                                return false;
                            }
                            break;
                        case "CatgName"://选项类型
                        case "Brand":
                        case "Finish":
                        case "MachiningLevel":
                        case "Unit":
                        case "Material":
                            if (DataTypeConvert.GetString(gridViewPartsCode.GetDataRow(i)[columnStr]) == "")
                            {
                                MessageHandler.ShowMessageBox("选项字段为空，请填写后再进行检查。");
                                gridCrlPartsCode.Focus();
                                gridViewPartsCode.FocusedRowHandle = i;
                                gridViewPartsCode.FocusedColumn = gridViewPartsCode.Columns[j];
                                return false;
                            }
                            isLookup = true;
                            break;
                    }

                    #endregion

                    #region 检测选项是否是正常选项

                    if (isLookup)
                    {
                        string lookupValue = DataTypeConvert.GetString(gridViewPartsCode.GetDataRow(i)[columnStr]);
                        bool isNoItemIndex = false;
                        switch (columnStr)
                        {
                            case "Brand":
                                if ((((DataTable)repLookUpBrand.DataSource).Select(string.Format("BrandName='{0}'", lookupValue))).Length <= 0)
                                    isNoItemIndex = true;
                                break;
                            case "CatgName":
                                if ((((DataTable)repLookUpCatgName.DataSource).Select(string.Format("CatgName='{0}'", lookupValue))).Length <= 0)
                                    isNoItemIndex = true;
                                break;
                            case "Finish":
                                if ((((DataTable)repLookUpFinish.DataSource).Select(string.Format("AutoId={0}", lookupValue))).Length <= 0)
                                    isNoItemIndex = true;
                                break;
                            case "MachiningLevel":
                                if ((((DataTable)repLookUpMachiningLevel.DataSource).Select(string.Format("AutoId={0}", lookupValue))).Length <= 0)
                                    isNoItemIndex = true;
                                break;
                            case "Unit":
                                if ((((DataTable)repLookUpUnit.DataSource).Select(string.Format("UnitName='{0}'", lookupValue))).Length <= 0)
                                    isNoItemIndex = true;
                                break;
                            case "Material":
                                if ((((DataTable)repSearchLookUpMaterial.DataSource).Select(string.Format("AutoId={0}", lookupValue))).Length <= 0)
                                    isNoItemIndex = true;
                                break;
                        }

                        if (isNoItemIndex)
                        {
                            MessageHandler.ShowMessageBox("选项是非正常选项，请重新选择后再进行检查。");
                            gridCrlPartsCode.Focus();
                            gridViewPartsCode.FocusedRowHandle = i;
                            gridViewPartsCode.FocusedColumn = gridViewPartsCode.Columns[j];
                            return false;
                        }
                    }

                    #endregion

                    #region 零件编号是否存在

                    if (columnStr == "CodeFileName")
                    {
                        string codeFileNameStr = DataTypeConvert.GetString(gridViewPartsCode.GetDataRow(i)[columnStr]);
                        if (pcDAO.QueryPartsCode_CodeFileNameCount(codeFileNameStr) > 0)
                        {
                            MessageHandler.ShowMessageBox(string.Format("零件编号[{0}]在数据库中已经存在，不可以重复添加。", codeFileNameStr));
                            gridCrlPartsCode.Focus();
                            gridViewPartsCode.FocusedRowHandle = i;
                            gridViewPartsCode.FocusedColumn = gridViewPartsCode.Columns[j];
                            return false;
                        }
                    }

                    #endregion
                }
            }

            return true;
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

                if (MessageHandler.ShowMessageBox_YesNo("确认将下面显示的物料信息更新到数据库中？") == DialogResult.Yes)
                {
                    pcDAO.SaveImportPartsCode(dSPartsCode.Tables[0]);
                    MessageHandler.ShowMessageBox("更新数据库成功。");
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--将当前导入的信息更新到数据库中错误。", ex);
            }
        }

        /// <summary>
        /// 删除当前选中的行信息
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridViewPartsCode.DataRowCount < 1)
                    return;

                if (MessageHandler.ShowMessageBox_YesNo(string.Format("确认删除当前选中的{0}行信息吗？", gridViewPartsCode.SelectedRowsCount)) == DialogResult.Yes)
                {
                    gridViewPartsCode.DeleteSelectedRows();
                    //gridViewPartsCode.DeleteRow(gridViewPartsCode.FocusedRowHandle);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--删除当前选中的行信息错误。", ex);
            }
        }       
    }
}
