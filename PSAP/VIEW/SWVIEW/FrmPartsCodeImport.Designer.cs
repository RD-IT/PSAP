namespace PSAP.VIEW.BSVIEW
{
    partial class FrmPartsCodeImport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdateDB = new DevExpress.XtraEditors.SimpleButton();
            this.spinValue = new DevExpress.XtraEditors.SpinEdit();
            this.btnUpdateGrid = new DevExpress.XtraEditors.SimpleButton();
            this.labtext = new DevExpress.XtraEditors.LabelControl();
            this.dateValue = new DevExpress.XtraEditors.DateEdit();
            this.checkNull = new DevExpress.XtraEditors.CheckEdit();
            this.checkValue = new DevExpress.XtraEditors.CheckEdit();
            this.lookUpValue = new DevExpress.XtraEditors.LookUpEdit();
            this.textValue = new DevExpress.XtraEditors.TextEdit();
            this.labColumnName = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxColumn = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnExcel2007 = new DevExpress.XtraEditors.SimpleButton();
            this.dSPartsCode = new System.Data.DataSet();
            this.TablePartsCode = new System.Data.DataTable();
            this.dataColAutoId = new System.Data.DataColumn();
            this.dataColCodeFileName = new System.Data.DataColumn();
            this.dataColCodeNo = new System.Data.DataColumn();
            this.dataColCodeName = new System.Data.DataColumn();
            this.dataColFilePath = new System.Data.DataColumn();
            this.dataColCatgName = new System.Data.DataColumn();
            this.dataColCodeSpec = new System.Data.DataColumn();
            this.dataColCodeWeight = new System.Data.DataColumn();
            this.dataColMaterialVersion = new System.Data.DataColumn();
            this.dataColMaterial = new System.Data.DataColumn();
            this.dataColBrand = new System.Data.DataColumn();
            this.dataColFinish = new System.Data.DataColumn();
            this.dataColMachiningLevel = new System.Data.DataColumn();
            this.dataColUnit = new System.Data.DataColumn();
            this.dataColIsPreferred = new System.Data.DataColumn();
            this.dataColIsLongPeriod = new System.Data.DataColumn();
            this.dataColIsPrecious = new System.Data.DataColumn();
            this.dataColIsPreprocessing = new System.Data.DataColumn();
            this.dataColDesigner = new System.Data.DataColumn();
            this.dataColTel = new System.Data.DataColumn();
            this.dataColGetTime = new System.Data.DataColumn();
            this.dataColBfree1 = new System.Data.DataColumn();
            this.dataColBfree2 = new System.Data.DataColumn();
            this.dataColBfree3 = new System.Data.DataColumn();
            this.bSPartsCode = new System.Windows.Forms.BindingSource(this.components);
            this.gridCrlPartsCode = new DevExpress.XtraGrid.GridControl();
            this.gridViewPartsCode = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodeFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFilePath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCatgName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpCatgName = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colCodeSpec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodeWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSpinCodeWeight = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colMaterialVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSearchLookUpMaterial = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repSearchLookUpMaterialView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColuAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColuLibName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColuMaterialCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColuMaterialName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpBrand = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colFinish = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpFinish = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colMachiningLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpMachiningLevel = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpUnit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colIsPreferred = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCheckPreferred = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colIsLongPeriod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsPrecious = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsPreprocessing = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesigner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGetTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBfree1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBfree2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBfree3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupTop = new DevExpress.XtraEditors.GroupControl();
            this.btnModuleDownload = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.spinValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateValue.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkNull.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxColumn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPartsCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablePartsCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSPartsCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlPartsCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPartsCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpCatgName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinCodeWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchLookUpMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchLookUpMaterialView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpBrand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpFinish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpMachiningLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckPreferred)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupTop)).BeginInit();
            this.groupTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(725, 81);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "删除行";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdateDB
            // 
            this.btnUpdateDB.Location = new System.Drawing.Point(452, 40);
            this.btnUpdateDB.Name = "btnUpdateDB";
            this.btnUpdateDB.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateDB.TabIndex = 3;
            this.btnUpdateDB.Text = "更新数据库";
            this.btnUpdateDB.Click += new System.EventHandler(this.btnUpdateDB_Click);
            // 
            // spinValue
            // 
            this.spinValue.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinValue.Location = new System.Drawing.Point(848, 119);
            this.spinValue.Name = "spinValue";
            this.spinValue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinValue.Size = new System.Drawing.Size(160, 20);
            this.spinValue.TabIndex = 14;
            this.spinValue.Visible = false;
            // 
            // btnUpdateGrid
            // 
            this.btnUpdateGrid.Location = new System.Drawing.Point(631, 81);
            this.btnUpdateGrid.Name = "btnUpdateGrid";
            this.btnUpdateGrid.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateGrid.TabIndex = 7;
            this.btnUpdateGrid.Text = "修改";
            this.btnUpdateGrid.Click += new System.EventHandler(this.btnUpdateGrid_Click);
            // 
            // labtext
            // 
            this.labtext.Location = new System.Drawing.Point(327, 85);
            this.labtext.Name = "labtext";
            this.labtext.Size = new System.Drawing.Size(24, 14);
            this.labtext.TabIndex = 9;
            this.labtext.Text = "列值";
            // 
            // dateValue
            // 
            this.dateValue.EditValue = null;
            this.dateValue.Location = new System.Drawing.Point(644, 119);
            this.dateValue.Name = "dateValue";
            this.dateValue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateValue.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateValue.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dateValue.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateValue.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dateValue.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateValue.Size = new System.Drawing.Size(160, 20);
            this.dateValue.TabIndex = 8;
            this.dateValue.Visible = false;
            // 
            // checkNull
            // 
            this.checkNull.EditValue = true;
            this.checkNull.Location = new System.Drawing.Point(219, 82);
            this.checkNull.Name = "checkNull";
            this.checkNull.Properties.Caption = "为空设定";
            this.checkNull.Size = new System.Drawing.Size(79, 19);
            this.checkNull.TabIndex = 5;
            // 
            // checkValue
            // 
            this.checkValue.Location = new System.Drawing.Point(521, 119);
            this.checkValue.Name = "checkValue";
            this.checkValue.Properties.Caption = "";
            this.checkValue.Size = new System.Drawing.Size(24, 19);
            this.checkValue.TabIndex = 6;
            this.checkValue.Visible = false;
            // 
            // lookUpValue
            // 
            this.lookUpValue.Location = new System.Drawing.Point(317, 119);
            this.lookUpValue.Name = "lookUpValue";
            this.lookUpValue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpValue.Properties.NullText = "";
            this.lookUpValue.Size = new System.Drawing.Size(160, 20);
            this.lookUpValue.TabIndex = 5;
            this.lookUpValue.Visible = false;
            // 
            // textValue
            // 
            this.textValue.Location = new System.Drawing.Point(380, 82);
            this.textValue.Name = "textValue";
            this.textValue.Size = new System.Drawing.Size(160, 20);
            this.textValue.TabIndex = 6;
            this.textValue.Visible = false;
            // 
            // labColumnName
            // 
            this.labColumnName.Location = new System.Drawing.Point(35, 85);
            this.labColumnName.Name = "labColumnName";
            this.labColumnName.Size = new System.Drawing.Size(24, 14);
            this.labColumnName.TabIndex = 3;
            this.labColumnName.Text = "列名";
            // 
            // comboBoxColumn
            // 
            this.comboBoxColumn.Location = new System.Drawing.Point(85, 82);
            this.comboBoxColumn.Name = "comboBoxColumn";
            this.comboBoxColumn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxColumn.Size = new System.Drawing.Size(100, 20);
            this.comboBoxColumn.TabIndex = 4;
            this.comboBoxColumn.SelectedIndexChanged += new System.EventHandler(this.comboBoxColumn_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(358, 40);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "清空数据";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExcel2007
            // 
            this.btnExcel2007.Location = new System.Drawing.Point(35, 40);
            this.btnExcel2007.Name = "btnExcel2007";
            this.btnExcel2007.Size = new System.Drawing.Size(100, 23);
            this.btnExcel2007.TabIndex = 0;
            this.btnExcel2007.Text = "导入Excel 数据";
            this.btnExcel2007.Click += new System.EventHandler(this.btnExcel2007_Click);
            // 
            // dSPartsCode
            // 
            this.dSPartsCode.DataSetName = "NewDataSet";
            this.dSPartsCode.Tables.AddRange(new System.Data.DataTable[] {
            this.TablePartsCode});
            // 
            // TablePartsCode
            // 
            this.TablePartsCode.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColAutoId,
            this.dataColCodeFileName,
            this.dataColCodeNo,
            this.dataColCodeName,
            this.dataColFilePath,
            this.dataColCatgName,
            this.dataColCodeSpec,
            this.dataColCodeWeight,
            this.dataColMaterialVersion,
            this.dataColMaterial,
            this.dataColBrand,
            this.dataColFinish,
            this.dataColMachiningLevel,
            this.dataColUnit,
            this.dataColIsPreferred,
            this.dataColIsLongPeriod,
            this.dataColIsPrecious,
            this.dataColIsPreprocessing,
            this.dataColDesigner,
            this.dataColTel,
            this.dataColGetTime,
            this.dataColBfree1,
            this.dataColBfree2,
            this.dataColBfree3});
            this.TablePartsCode.TableName = "PartsCode";
            // 
            // dataColAutoId
            // 
            this.dataColAutoId.ColumnName = "AutoId";
            this.dataColAutoId.DataType = typeof(int);
            // 
            // dataColCodeFileName
            // 
            this.dataColCodeFileName.Caption = "零件编号(CodeFileName)";
            this.dataColCodeFileName.ColumnName = "CodeFileName";
            // 
            // dataColCodeNo
            // 
            this.dataColCodeNo.Caption = "物料编号(CodeNo)";
            this.dataColCodeNo.ColumnName = "CodeNo";
            // 
            // dataColCodeName
            // 
            this.dataColCodeName.Caption = "零件名称(CodeName)";
            this.dataColCodeName.ColumnName = "CodeName";
            // 
            // dataColFilePath
            // 
            this.dataColFilePath.Caption = "文件路径(FilePath)";
            this.dataColFilePath.ColumnName = "FilePath";
            // 
            // dataColCatgName
            // 
            this.dataColCatgName.Caption = "分类名称(CatgName)";
            this.dataColCatgName.ColumnName = "CatgName";
            // 
            // dataColCodeSpec
            // 
            this.dataColCodeSpec.Caption = "规格型号(CodeSpec)";
            this.dataColCodeSpec.ColumnName = "CodeSpec";
            // 
            // dataColCodeWeight
            // 
            this.dataColCodeWeight.Caption = "重量(CodeWeight)";
            this.dataColCodeWeight.ColumnName = "CodeWeight";
            this.dataColCodeWeight.DataType = typeof(double);
            // 
            // dataColMaterialVersion
            // 
            this.dataColMaterialVersion.Caption = "物料版本(MaterialVersion)";
            this.dataColMaterialVersion.ColumnName = "MaterialVersion";
            // 
            // dataColMaterial
            // 
            this.dataColMaterial.Caption = "材料(Material)";
            this.dataColMaterial.ColumnName = "Material";
            this.dataColMaterial.DataType = typeof(int);
            // 
            // dataColBrand
            // 
            this.dataColBrand.Caption = "品牌(Brand)";
            this.dataColBrand.ColumnName = "Brand";
            // 
            // dataColFinish
            // 
            this.dataColFinish.Caption = "表面处理(Finish)";
            this.dataColFinish.ColumnName = "Finish";
            this.dataColFinish.DataType = typeof(int);
            // 
            // dataColMachiningLevel
            // 
            this.dataColMachiningLevel.Caption = "加工等级(MachiningLevel)";
            this.dataColMachiningLevel.ColumnName = "MachiningLevel";
            this.dataColMachiningLevel.DataType = typeof(int);
            // 
            // dataColUnit
            // 
            this.dataColUnit.Caption = "单位(Unit)";
            this.dataColUnit.ColumnName = "Unit";
            // 
            // dataColIsPreferred
            // 
            this.dataColIsPreferred.Caption = "优选(IsPreferred)";
            this.dataColIsPreferred.ColumnName = "IsPreferred";
            this.dataColIsPreferred.DataType = typeof(bool);
            // 
            // dataColIsLongPeriod
            // 
            this.dataColIsLongPeriod.Caption = "长周期(IsLongPeriod)";
            this.dataColIsLongPeriod.ColumnName = "IsLongPeriod";
            this.dataColIsLongPeriod.DataType = typeof(bool);
            // 
            // dataColIsPrecious
            // 
            this.dataColIsPrecious.Caption = "贵重(IsPrecious)";
            this.dataColIsPrecious.ColumnName = "IsPrecious";
            this.dataColIsPrecious.DataType = typeof(bool);
            // 
            // dataColIsPreprocessing
            // 
            this.dataColIsPreprocessing.Caption = "预处理(IsPreprocessing)";
            this.dataColIsPreprocessing.ColumnName = "IsPreprocessing";
            this.dataColIsPreprocessing.DataType = typeof(bool);
            // 
            // dataColDesigner
            // 
            this.dataColDesigner.Caption = "设计者(Designer)";
            this.dataColDesigner.ColumnName = "Designer";
            // 
            // dataColTel
            // 
            this.dataColTel.Caption = "电话(Tel)";
            this.dataColTel.ColumnName = "Tel";
            // 
            // dataColGetTime
            // 
            this.dataColGetTime.Caption = "登记时间(GetTime)";
            this.dataColGetTime.ColumnName = "GetTime";
            this.dataColGetTime.DataType = typeof(System.DateTime);
            // 
            // dataColBfree1
            // 
            this.dataColBfree1.Caption = "备用(Bfree1)";
            this.dataColBfree1.ColumnName = "Bfree1";
            // 
            // dataColBfree2
            // 
            this.dataColBfree2.Caption = "备用(Bfree2)";
            this.dataColBfree2.ColumnName = "Bfree2";
            // 
            // dataColBfree3
            // 
            this.dataColBfree3.Caption = "备用(Bfree3)";
            this.dataColBfree3.ColumnName = "Bfree3";
            // 
            // bSPartsCode
            // 
            this.bSPartsCode.DataMember = "PartsCode";
            this.bSPartsCode.DataSource = this.dSPartsCode;
            // 
            // gridCrlPartsCode
            // 
            this.gridCrlPartsCode.DataSource = this.bSPartsCode;
            this.gridCrlPartsCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCrlPartsCode.Location = new System.Drawing.Point(0, 126);
            this.gridCrlPartsCode.MainView = this.gridViewPartsCode;
            this.gridCrlPartsCode.Name = "gridCrlPartsCode";
            this.gridCrlPartsCode.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repLookUpCatgName,
            this.repLookUpBrand,
            this.repLookUpFinish,
            this.repLookUpMachiningLevel,
            this.repLookUpUnit,
            this.repSearchLookUpMaterial,
            this.repSpinCodeWeight,
            this.repCheckPreferred});
            this.gridCrlPartsCode.Size = new System.Drawing.Size(1318, 365);
            this.gridCrlPartsCode.TabIndex = 1;
            this.gridCrlPartsCode.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPartsCode});
            // 
            // gridViewPartsCode
            // 
            this.gridViewPartsCode.ColumnPanelRowHeight = 35;
            this.gridViewPartsCode.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId,
            this.colCodeFileName,
            this.colCodeNo,
            this.colCodeName,
            this.colFilePath,
            this.colCatgName,
            this.colCodeSpec,
            this.colCodeWeight,
            this.colMaterialVersion,
            this.colMaterial,
            this.colBrand,
            this.colFinish,
            this.colMachiningLevel,
            this.colUnit,
            this.colIsPreferred,
            this.colIsLongPeriod,
            this.colIsPrecious,
            this.colIsPreprocessing,
            this.colDesigner,
            this.colTel,
            this.colGetTime,
            this.colBfree1,
            this.colBfree2,
            this.colBfree3});
            this.gridViewPartsCode.GridControl = this.gridCrlPartsCode;
            this.gridViewPartsCode.IndicatorWidth = 50;
            this.gridViewPartsCode.Name = "gridViewPartsCode";
            this.gridViewPartsCode.OptionsSelection.MultiSelect = true;
            this.gridViewPartsCode.OptionsView.ColumnAutoWidth = false;
            this.gridViewPartsCode.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewPartsCode.OptionsView.ShowFooter = true;
            this.gridViewPartsCode.OptionsView.ShowGroupPanel = false;
            this.gridViewPartsCode.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewPartsCode_CustomDrawRowIndicator);
            this.gridViewPartsCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewPartsCode_KeyDown);
            // 
            // colAutoId
            // 
            this.colAutoId.FieldName = "AutoId";
            this.colAutoId.Name = "colAutoId";
            // 
            // colCodeFileName
            // 
            this.colCodeFileName.AppearanceHeader.Options.UseTextOptions = true;
            this.colCodeFileName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCodeFileName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colCodeFileName.FieldName = "CodeFileName";
            this.colCodeFileName.Name = "colCodeFileName";
            this.colCodeFileName.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "CodeFileName", "共计{0}条")});
            this.colCodeFileName.Visible = true;
            this.colCodeFileName.VisibleIndex = 0;
            this.colCodeFileName.Width = 120;
            // 
            // colCodeNo
            // 
            this.colCodeNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colCodeNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCodeNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colCodeNo.FieldName = "CodeNo";
            this.colCodeNo.Name = "colCodeNo";
            this.colCodeNo.Visible = true;
            this.colCodeNo.VisibleIndex = 1;
            this.colCodeNo.Width = 120;
            // 
            // colCodeName
            // 
            this.colCodeName.AppearanceHeader.Options.UseTextOptions = true;
            this.colCodeName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCodeName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colCodeName.FieldName = "CodeName";
            this.colCodeName.Name = "colCodeName";
            this.colCodeName.Visible = true;
            this.colCodeName.VisibleIndex = 2;
            this.colCodeName.Width = 120;
            // 
            // colFilePath
            // 
            this.colFilePath.AppearanceHeader.Options.UseTextOptions = true;
            this.colFilePath.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFilePath.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colFilePath.FieldName = "FilePath";
            this.colFilePath.Name = "colFilePath";
            this.colFilePath.Visible = true;
            this.colFilePath.VisibleIndex = 3;
            this.colFilePath.Width = 200;
            // 
            // colCatgName
            // 
            this.colCatgName.AppearanceHeader.Options.UseTextOptions = true;
            this.colCatgName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCatgName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colCatgName.ColumnEdit = this.repLookUpCatgName;
            this.colCatgName.FieldName = "CatgName";
            this.colCatgName.Name = "colCatgName";
            this.colCatgName.Visible = true;
            this.colCatgName.VisibleIndex = 4;
            // 
            // repLookUpCatgName
            // 
            this.repLookUpCatgName.AutoHeight = false;
            this.repLookUpCatgName.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpCatgName.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AutoId", "AutoId", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CatgName", "分类名称"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CatgDescription", "分类说明")});
            this.repLookUpCatgName.DisplayMember = "CatgName";
            this.repLookUpCatgName.Name = "repLookUpCatgName";
            this.repLookUpCatgName.NullText = "";
            this.repLookUpCatgName.ValueMember = "CatgName";
            // 
            // colCodeSpec
            // 
            this.colCodeSpec.AppearanceHeader.Options.UseTextOptions = true;
            this.colCodeSpec.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCodeSpec.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colCodeSpec.FieldName = "CodeSpec";
            this.colCodeSpec.Name = "colCodeSpec";
            this.colCodeSpec.Visible = true;
            this.colCodeSpec.VisibleIndex = 5;
            this.colCodeSpec.Width = 130;
            // 
            // colCodeWeight
            // 
            this.colCodeWeight.AppearanceHeader.Options.UseTextOptions = true;
            this.colCodeWeight.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCodeWeight.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colCodeWeight.ColumnEdit = this.repSpinCodeWeight;
            this.colCodeWeight.FieldName = "CodeWeight";
            this.colCodeWeight.Name = "colCodeWeight";
            this.colCodeWeight.Visible = true;
            this.colCodeWeight.VisibleIndex = 6;
            this.colCodeWeight.Width = 130;
            // 
            // repSpinCodeWeight
            // 
            this.repSpinCodeWeight.AutoHeight = false;
            this.repSpinCodeWeight.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repSpinCodeWeight.Name = "repSpinCodeWeight";
            // 
            // colMaterialVersion
            // 
            this.colMaterialVersion.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaterialVersion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaterialVersion.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colMaterialVersion.FieldName = "MaterialVersion";
            this.colMaterialVersion.Name = "colMaterialVersion";
            this.colMaterialVersion.Visible = true;
            this.colMaterialVersion.VisibleIndex = 7;
            this.colMaterialVersion.Width = 100;
            // 
            // colMaterial
            // 
            this.colMaterial.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaterial.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaterial.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colMaterial.ColumnEdit = this.repSearchLookUpMaterial;
            this.colMaterial.FieldName = "Material";
            this.colMaterial.Name = "colMaterial";
            this.colMaterial.Visible = true;
            this.colMaterial.VisibleIndex = 8;
            // 
            // repSearchLookUpMaterial
            // 
            this.repSearchLookUpMaterial.AutoHeight = false;
            this.repSearchLookUpMaterial.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repSearchLookUpMaterial.DisplayMember = "MaterialName";
            this.repSearchLookUpMaterial.Name = "repSearchLookUpMaterial";
            this.repSearchLookUpMaterial.NullText = "";
            this.repSearchLookUpMaterial.ValueMember = "AutoId";
            this.repSearchLookUpMaterial.View = this.repSearchLookUpMaterialView;
            // 
            // repSearchLookUpMaterialView
            // 
            this.repSearchLookUpMaterialView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColuAutoId,
            this.gridColuLibName,
            this.gridColuMaterialCategory,
            this.gridColuMaterialName});
            this.repSearchLookUpMaterialView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repSearchLookUpMaterialView.IndicatorWidth = 40;
            this.repSearchLookUpMaterialView.Name = "repSearchLookUpMaterialView";
            this.repSearchLookUpMaterialView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repSearchLookUpMaterialView.OptionsView.ShowGroupPanel = false;
            this.repSearchLookUpMaterialView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewPartsCode_CustomDrawRowIndicator);
            // 
            // gridColuAutoId
            // 
            this.gridColuAutoId.Caption = "AutoId";
            this.gridColuAutoId.FieldName = "AutoId";
            this.gridColuAutoId.Name = "gridColuAutoId";
            // 
            // gridColuLibName
            // 
            this.gridColuLibName.Caption = "LibName";
            this.gridColuLibName.FieldName = "LibName";
            this.gridColuLibName.Name = "gridColuLibName";
            this.gridColuLibName.Visible = true;
            this.gridColuLibName.VisibleIndex = 0;
            // 
            // gridColuMaterialCategory
            // 
            this.gridColuMaterialCategory.Caption = "材料类别";
            this.gridColuMaterialCategory.FieldName = "MaterialCategory";
            this.gridColuMaterialCategory.Name = "gridColuMaterialCategory";
            this.gridColuMaterialCategory.Visible = true;
            this.gridColuMaterialCategory.VisibleIndex = 1;
            // 
            // gridColuMaterialName
            // 
            this.gridColuMaterialName.Caption = "材料名称";
            this.gridColuMaterialName.FieldName = "MaterialName";
            this.gridColuMaterialName.Name = "gridColuMaterialName";
            this.gridColuMaterialName.Visible = true;
            this.gridColuMaterialName.VisibleIndex = 2;
            // 
            // colBrand
            // 
            this.colBrand.AppearanceHeader.Options.UseTextOptions = true;
            this.colBrand.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBrand.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colBrand.ColumnEdit = this.repLookUpBrand;
            this.colBrand.FieldName = "Brand";
            this.colBrand.Name = "colBrand";
            this.colBrand.Visible = true;
            this.colBrand.VisibleIndex = 9;
            this.colBrand.Width = 90;
            // 
            // repLookUpBrand
            // 
            this.repLookUpBrand.AutoHeight = false;
            this.repLookUpBrand.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpBrand.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AutoId", "AutoId", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BrandNo", "品牌编号"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BrandName", "品牌名称")});
            this.repLookUpBrand.DisplayMember = "BrandName";
            this.repLookUpBrand.Name = "repLookUpBrand";
            this.repLookUpBrand.NullText = "";
            this.repLookUpBrand.ValueMember = "BrandName";
            // 
            // colFinish
            // 
            this.colFinish.AppearanceHeader.Options.UseTextOptions = true;
            this.colFinish.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFinish.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colFinish.ColumnEdit = this.repLookUpFinish;
            this.colFinish.FieldName = "Finish";
            this.colFinish.Name = "colFinish";
            this.colFinish.Visible = true;
            this.colFinish.VisibleIndex = 10;
            // 
            // repLookUpFinish
            // 
            this.repLookUpFinish.AutoHeight = false;
            this.repLookUpFinish.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpFinish.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AutoId", "AutoId", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FinishCatg", "表面处理"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FinishOrder", "排序")});
            this.repLookUpFinish.DisplayMember = "FinishCatg";
            this.repLookUpFinish.Name = "repLookUpFinish";
            this.repLookUpFinish.NullText = "";
            this.repLookUpFinish.ValueMember = "AutoId";
            // 
            // colMachiningLevel
            // 
            this.colMachiningLevel.AppearanceHeader.Options.UseTextOptions = true;
            this.colMachiningLevel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMachiningLevel.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colMachiningLevel.ColumnEdit = this.repLookUpMachiningLevel;
            this.colMachiningLevel.FieldName = "MachiningLevel";
            this.colMachiningLevel.Name = "colMachiningLevel";
            this.colMachiningLevel.Visible = true;
            this.colMachiningLevel.VisibleIndex = 11;
            this.colMachiningLevel.Width = 100;
            // 
            // repLookUpMachiningLevel
            // 
            this.repLookUpMachiningLevel.AutoHeight = false;
            this.repLookUpMachiningLevel.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpMachiningLevel.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AutoId", "AutoId", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LevelCatg", "加工等级"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CatgOrder", "排序")});
            this.repLookUpMachiningLevel.DisplayMember = "LevelCatg";
            this.repLookUpMachiningLevel.Name = "repLookUpMachiningLevel";
            this.repLookUpMachiningLevel.NullText = "";
            this.repLookUpMachiningLevel.ValueMember = "AutoId";
            // 
            // colUnit
            // 
            this.colUnit.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnit.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colUnit.ColumnEdit = this.repLookUpUnit;
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.Visible = true;
            this.colUnit.VisibleIndex = 12;
            // 
            // repLookUpUnit
            // 
            this.repLookUpUnit.AutoHeight = false;
            this.repLookUpUnit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpUnit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AutoId", "AutoId", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UnitNo", "单位编码"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UnitName", "单位名称")});
            this.repLookUpUnit.DisplayMember = "UnitName";
            this.repLookUpUnit.Name = "repLookUpUnit";
            this.repLookUpUnit.NullText = "";
            this.repLookUpUnit.ValueMember = "UnitName";
            // 
            // colIsPreferred
            // 
            this.colIsPreferred.AppearanceHeader.Options.UseTextOptions = true;
            this.colIsPreferred.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIsPreferred.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colIsPreferred.ColumnEdit = this.repCheckPreferred;
            this.colIsPreferred.FieldName = "IsPreferred";
            this.colIsPreferred.Name = "colIsPreferred";
            this.colIsPreferred.Visible = true;
            this.colIsPreferred.VisibleIndex = 13;
            this.colIsPreferred.Width = 85;
            // 
            // repCheckPreferred
            // 
            this.repCheckPreferred.AutoHeight = false;
            this.repCheckPreferred.Name = "repCheckPreferred";
            this.repCheckPreferred.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repCheckPreferred.ValueGrayed = false;
            // 
            // colIsLongPeriod
            // 
            this.colIsLongPeriod.AppearanceHeader.Options.UseTextOptions = true;
            this.colIsLongPeriod.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIsLongPeriod.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colIsLongPeriod.ColumnEdit = this.repCheckPreferred;
            this.colIsLongPeriod.FieldName = "IsLongPeriod";
            this.colIsLongPeriod.Name = "colIsLongPeriod";
            this.colIsLongPeriod.Visible = true;
            this.colIsLongPeriod.VisibleIndex = 14;
            this.colIsLongPeriod.Width = 90;
            // 
            // colIsPrecious
            // 
            this.colIsPrecious.AppearanceHeader.Options.UseTextOptions = true;
            this.colIsPrecious.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIsPrecious.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colIsPrecious.ColumnEdit = this.repCheckPreferred;
            this.colIsPrecious.FieldName = "IsPrecious";
            this.colIsPrecious.Name = "colIsPrecious";
            this.colIsPrecious.Visible = true;
            this.colIsPrecious.VisibleIndex = 15;
            this.colIsPrecious.Width = 85;
            // 
            // colIsPreprocessing
            // 
            this.colIsPreprocessing.AppearanceHeader.Options.UseTextOptions = true;
            this.colIsPreprocessing.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIsPreprocessing.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colIsPreprocessing.ColumnEdit = this.repCheckPreferred;
            this.colIsPreprocessing.FieldName = "IsPreprocessing";
            this.colIsPreprocessing.Name = "colIsPreprocessing";
            this.colIsPreprocessing.Visible = true;
            this.colIsPreprocessing.VisibleIndex = 16;
            this.colIsPreprocessing.Width = 105;
            // 
            // colDesigner
            // 
            this.colDesigner.AppearanceHeader.Options.UseTextOptions = true;
            this.colDesigner.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDesigner.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colDesigner.FieldName = "Designer";
            this.colDesigner.Name = "colDesigner";
            this.colDesigner.Visible = true;
            this.colDesigner.VisibleIndex = 17;
            this.colDesigner.Width = 100;
            // 
            // colTel
            // 
            this.colTel.AppearanceHeader.Options.UseTextOptions = true;
            this.colTel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTel.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colTel.FieldName = "Tel";
            this.colTel.Name = "colTel";
            this.colTel.Visible = true;
            this.colTel.VisibleIndex = 18;
            this.colTel.Width = 120;
            // 
            // colGetTime
            // 
            this.colGetTime.AppearanceHeader.Options.UseTextOptions = true;
            this.colGetTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGetTime.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colGetTime.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.colGetTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colGetTime.FieldName = "GetTime";
            this.colGetTime.Name = "colGetTime";
            this.colGetTime.Visible = true;
            this.colGetTime.VisibleIndex = 19;
            this.colGetTime.Width = 130;
            // 
            // colBfree1
            // 
            this.colBfree1.FieldName = "Bfree1";
            this.colBfree1.Name = "colBfree1";
            this.colBfree1.Visible = true;
            this.colBfree1.VisibleIndex = 20;
            // 
            // colBfree2
            // 
            this.colBfree2.FieldName = "Bfree2";
            this.colBfree2.Name = "colBfree2";
            this.colBfree2.Visible = true;
            this.colBfree2.VisibleIndex = 21;
            // 
            // colBfree3
            // 
            this.colBfree3.FieldName = "Bfree3";
            this.colBfree3.Name = "colBfree3";
            this.colBfree3.Visible = true;
            this.colBfree3.VisibleIndex = 22;
            // 
            // groupTop
            // 
            this.groupTop.Controls.Add(this.btnModuleDownload);
            this.groupTop.Controls.Add(this.btnDelete);
            this.groupTop.Controls.Add(this.btnExcel2007);
            this.groupTop.Controls.Add(this.btnUpdateDB);
            this.groupTop.Controls.Add(this.btnClear);
            this.groupTop.Controls.Add(this.spinValue);
            this.groupTop.Controls.Add(this.comboBoxColumn);
            this.groupTop.Controls.Add(this.btnUpdateGrid);
            this.groupTop.Controls.Add(this.labColumnName);
            this.groupTop.Controls.Add(this.labtext);
            this.groupTop.Controls.Add(this.textValue);
            this.groupTop.Controls.Add(this.dateValue);
            this.groupTop.Controls.Add(this.lookUpValue);
            this.groupTop.Controls.Add(this.checkNull);
            this.groupTop.Controls.Add(this.checkValue);
            this.groupTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupTop.Location = new System.Drawing.Point(0, 0);
            this.groupTop.Name = "groupTop";
            this.groupTop.Size = new System.Drawing.Size(1318, 126);
            this.groupTop.TabIndex = 19;
            this.groupTop.Text = "物料信息导入设定";
            // 
            // btnModuleDownload
            // 
            this.btnModuleDownload.Location = new System.Drawing.Point(157, 40);
            this.btnModuleDownload.Name = "btnModuleDownload";
            this.btnModuleDownload.Size = new System.Drawing.Size(75, 23);
            this.btnModuleDownload.TabIndex = 1;
            this.btnModuleDownload.Text = "模板下载";
            this.btnModuleDownload.Click += new System.EventHandler(this.btnModuleDownload_Click);
            // 
            // FrmPartsCodeImport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1318, 491);
            this.Controls.Add(this.gridCrlPartsCode);
            this.Controls.Add(this.groupTop);
            this.Name = "FrmPartsCodeImport";
            this.TabText = "导入物料信息";
            this.Text = "导入物料信息";
            this.Load += new System.EventHandler(this.FrmPartsCodeImport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spinValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateValue.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkNull.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxColumn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPartsCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablePartsCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSPartsCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlPartsCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPartsCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpCatgName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinCodeWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchLookUpMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchLookUpMaterialView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpBrand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpFinish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpMachiningLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckPreferred)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupTop)).EndInit();
            this.groupTop.ResumeLayout(false);
            this.groupTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnExcel2007;
        private System.Data.DataSet dSPartsCode;
        private System.Data.DataTable TablePartsCode;
        private System.Data.DataColumn dataColAutoId;
        private System.Data.DataColumn dataColCodeFileName;
        private System.Data.DataColumn dataColCodeNo;
        private System.Data.DataColumn dataColCodeName;
        private System.Data.DataColumn dataColFilePath;
        private System.Data.DataColumn dataColCatgName;
        private System.Data.DataColumn dataColCodeSpec;
        private System.Data.DataColumn dataColCodeWeight;
        private System.Data.DataColumn dataColMaterialVersion;
        private System.Data.DataColumn dataColMaterial;
        private System.Data.DataColumn dataColBrand;
        private System.Data.DataColumn dataColFinish;
        private System.Data.DataColumn dataColMachiningLevel;
        private System.Data.DataColumn dataColUnit;
        private System.Data.DataColumn dataColIsPreferred;
        private System.Data.DataColumn dataColIsLongPeriod;
        private System.Data.DataColumn dataColIsPrecious;
        private System.Data.DataColumn dataColIsPreprocessing;
        private System.Data.DataColumn dataColDesigner;
        private System.Data.DataColumn dataColTel;
        private System.Data.DataColumn dataColGetTime;
        private System.Data.DataColumn dataColBfree1;
        private System.Data.DataColumn dataColBfree2;
        private System.Data.DataColumn dataColBfree3;
        private System.Windows.Forms.BindingSource bSPartsCode;
        private DevExpress.XtraGrid.GridControl gridCrlPartsCode;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPartsCode;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeFileName;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeNo;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeName;
        private DevExpress.XtraGrid.Columns.GridColumn colFilePath;
        private DevExpress.XtraGrid.Columns.GridColumn colCatgName;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeSpec;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeWeight;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterial;
        private DevExpress.XtraGrid.Columns.GridColumn colBrand;
        private DevExpress.XtraGrid.Columns.GridColumn colFinish;
        private DevExpress.XtraGrid.Columns.GridColumn colMachiningLevel;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colIsPreferred;
        private DevExpress.XtraGrid.Columns.GridColumn colIsLongPeriod;
        private DevExpress.XtraGrid.Columns.GridColumn colIsPrecious;
        private DevExpress.XtraGrid.Columns.GridColumn colIsPreprocessing;
        private DevExpress.XtraGrid.Columns.GridColumn colDesigner;
        private DevExpress.XtraGrid.Columns.GridColumn colTel;
        private DevExpress.XtraGrid.Columns.GridColumn colGetTime;
        private DevExpress.XtraGrid.Columns.GridColumn colBfree1;
        private DevExpress.XtraGrid.Columns.GridColumn colBfree2;
        private DevExpress.XtraGrid.Columns.GridColumn colBfree3;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpCatgName;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpBrand;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpFinish;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpMachiningLevel;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpUnit;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repSearchLookUpMaterial;
        private DevExpress.XtraGrid.Views.Grid.GridView repSearchLookUpMaterialView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColuAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColuLibName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColuMaterialCategory;
        private DevExpress.XtraGrid.Columns.GridColumn gridColuMaterialName;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repSpinCodeWeight;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheckPreferred;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.LabelControl labColumnName;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxColumn;
        private DevExpress.XtraEditors.CheckEdit checkNull;
        private DevExpress.XtraEditors.CheckEdit checkValue;
        private DevExpress.XtraEditors.LookUpEdit lookUpValue;
        private DevExpress.XtraEditors.TextEdit textValue;
        private DevExpress.XtraEditors.SimpleButton btnUpdateGrid;
        private DevExpress.XtraEditors.LabelControl labtext;
        private DevExpress.XtraEditors.DateEdit dateValue;
        private DevExpress.XtraEditors.SpinEdit spinValue;
        private DevExpress.XtraEditors.SimpleButton btnUpdateDB;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.GroupControl groupTop;
        private DevExpress.XtraEditors.SimpleButton btnModuleDownload;
    }
}