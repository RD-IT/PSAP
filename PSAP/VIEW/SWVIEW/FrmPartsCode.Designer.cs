namespace PSAP.VIEW.BSVIEW
{
    partial class FrmPartsCode
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
            this.pnlToolBar = new DevExpress.XtraEditors.PanelControl();
            this.pnlEdit = new DevExpress.XtraEditors.PanelControl();
            this.labUnit = new DevExpress.XtraEditors.LabelControl();
            this.lookUpUnit = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpMachiningLevel = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpFinish = new DevExpress.XtraEditors.LookUpEdit();
            this.labMachiningLevel = new DevExpress.XtraEditors.LabelControl();
            this.labFinish = new DevExpress.XtraEditors.LabelControl();
            this.labBrand = new DevExpress.XtraEditors.LabelControl();
            this.lookUpBrand = new DevExpress.XtraEditors.LookUpEdit();
            this.labCatgName = new DevExpress.XtraEditors.LabelControl();
            this.lookUpCatgName = new DevExpress.XtraEditors.LookUpEdit();
            this.labMaterial = new DevExpress.XtraEditors.LabelControl();
            this.searchLookUpMaterial = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpMaterialView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColuAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColuLibName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColuMaterialCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColuMaterialName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textMaterialVersion = new DevExpress.XtraEditors.TextEdit();
            this.labMaterialVersion = new DevExpress.XtraEditors.LabelControl();
            this.textTel = new DevExpress.XtraEditors.TextEdit();
            this.labTel = new DevExpress.XtraEditors.LabelControl();
            this.textDesigner = new DevExpress.XtraEditors.TextEdit();
            this.labDesigner = new DevExpress.XtraEditors.LabelControl();
            this.checkIsPreprocessing = new DevExpress.XtraEditors.CheckEdit();
            this.checkIsPrecious = new DevExpress.XtraEditors.CheckEdit();
            this.checkIsLongPeriod = new DevExpress.XtraEditors.CheckEdit();
            this.checkIsPreferred = new DevExpress.XtraEditors.CheckEdit();
            this.spinCodeWeight = new DevExpress.XtraEditors.SpinEdit();
            this.labCodeWeight = new DevExpress.XtraEditors.LabelControl();
            this.textCodeSpec = new DevExpress.XtraEditors.TextEdit();
            this.labCodeSpec = new DevExpress.XtraEditors.LabelControl();
            this.textFilePath = new DevExpress.XtraEditors.TextEdit();
            this.labFilePath = new DevExpress.XtraEditors.LabelControl();
            this.textCodeName = new DevExpress.XtraEditors.TextEdit();
            this.labCodeName = new DevExpress.XtraEditors.LabelControl();
            this.textCodeNo = new DevExpress.XtraEditors.TextEdit();
            this.textCodeFileName = new DevExpress.XtraEditors.TextEdit();
            this.labCodeNo = new DevExpress.XtraEditors.LabelControl();
            this.labCodeFileName = new DevExpress.XtraEditors.LabelControl();
            this.pnlGrid = new DevExpress.XtraEditors.PanelControl();
            this.gridCrlPartsCode = new DevExpress.XtraGrid.GridControl();
            this.gridViewPartsCode = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodeFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFilePath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCatgName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodeSpec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodeWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterialVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFinish = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMachiningLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsPreferred = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsLongPeriod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsPrecious = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsPreprocessing = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesigner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGetTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBfree1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBfree2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBfree3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCtjzsj = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLjbh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWlbh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLjmc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLjfl = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWjlj = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGgxh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWlbb = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDw = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dSPartsCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablePartsCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSPartsCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).BeginInit();
            this.pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpMachiningLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpFinish.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpBrand.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCatgName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpMaterial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpMaterialView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMaterialVersion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDesigner.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkIsPreprocessing.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkIsPrecious.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkIsLongPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkIsPreferred.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinCodeWeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCodeSpec.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textFilePath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCodeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCodeNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCodeFileName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlPartsCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPartsCode)).BeginInit();
            this.cms.SuspendLayout();
            this.SuspendLayout();
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
            this.TablePartsCode.TableNewRow += new System.Data.DataTableNewRowEventHandler(this.TablePartsCode_TableNewRow);
            // 
            // dataColAutoId
            // 
            this.dataColAutoId.ColumnName = "AutoId";
            this.dataColAutoId.DataType = typeof(int);
            // 
            // dataColCodeFileName
            // 
            this.dataColCodeFileName.Caption = "零件编号";
            this.dataColCodeFileName.ColumnName = "CodeFileName";
            // 
            // dataColCodeNo
            // 
            this.dataColCodeNo.Caption = "物料编号";
            this.dataColCodeNo.ColumnName = "CodeNo";
            // 
            // dataColCodeName
            // 
            this.dataColCodeName.Caption = "零件名称";
            this.dataColCodeName.ColumnName = "CodeName";
            // 
            // dataColFilePath
            // 
            this.dataColFilePath.Caption = "文件路径";
            this.dataColFilePath.ColumnName = "FilePath";
            // 
            // dataColCatgName
            // 
            this.dataColCatgName.Caption = "分类名称";
            this.dataColCatgName.ColumnName = "CatgName";
            // 
            // dataColCodeSpec
            // 
            this.dataColCodeSpec.Caption = "规格型号";
            this.dataColCodeSpec.ColumnName = "CodeSpec";
            // 
            // dataColCodeWeight
            // 
            this.dataColCodeWeight.Caption = "重量";
            this.dataColCodeWeight.ColumnName = "CodeWeight";
            this.dataColCodeWeight.DataType = typeof(double);
            // 
            // dataColMaterialVersion
            // 
            this.dataColMaterialVersion.Caption = "物料版本";
            this.dataColMaterialVersion.ColumnName = "MaterialVersion";
            // 
            // dataColMaterial
            // 
            this.dataColMaterial.Caption = "材料";
            this.dataColMaterial.ColumnName = "Material";
            this.dataColMaterial.DataType = typeof(int);
            // 
            // dataColBrand
            // 
            this.dataColBrand.Caption = "品牌 ";
            this.dataColBrand.ColumnName = "Brand";
            // 
            // dataColFinish
            // 
            this.dataColFinish.Caption = "表面处理";
            this.dataColFinish.ColumnName = "Finish";
            this.dataColFinish.DataType = typeof(int);
            // 
            // dataColMachiningLevel
            // 
            this.dataColMachiningLevel.Caption = "加工等级";
            this.dataColMachiningLevel.ColumnName = "MachiningLevel";
            this.dataColMachiningLevel.DataType = typeof(int);
            // 
            // dataColUnit
            // 
            this.dataColUnit.Caption = "单位";
            this.dataColUnit.ColumnName = "Unit";
            // 
            // dataColIsPreferred
            // 
            this.dataColIsPreferred.Caption = "优选";
            this.dataColIsPreferred.ColumnName = "IsPreferred";
            this.dataColIsPreferred.DataType = typeof(bool);
            // 
            // dataColIsLongPeriod
            // 
            this.dataColIsLongPeriod.Caption = "长周期";
            this.dataColIsLongPeriod.ColumnName = "IsLongPeriod";
            this.dataColIsLongPeriod.DataType = typeof(bool);
            // 
            // dataColIsPrecious
            // 
            this.dataColIsPrecious.Caption = "贵重";
            this.dataColIsPrecious.ColumnName = "IsPrecious";
            this.dataColIsPrecious.DataType = typeof(bool);
            // 
            // dataColIsPreprocessing
            // 
            this.dataColIsPreprocessing.Caption = "预处理";
            this.dataColIsPreprocessing.ColumnName = "IsPreprocessing";
            this.dataColIsPreprocessing.DataType = typeof(bool);
            // 
            // dataColDesigner
            // 
            this.dataColDesigner.Caption = "设计者";
            this.dataColDesigner.ColumnName = "Designer";
            // 
            // dataColTel
            // 
            this.dataColTel.Caption = "电话";
            this.dataColTel.ColumnName = "Tel";
            // 
            // dataColGetTime
            // 
            this.dataColGetTime.Caption = "登记时间";
            this.dataColGetTime.ColumnName = "GetTime";
            this.dataColGetTime.DataType = typeof(System.DateTime);
            // 
            // dataColBfree1
            // 
            this.dataColBfree1.ColumnName = "Bfree1";
            // 
            // dataColBfree2
            // 
            this.dataColBfree2.ColumnName = "Bfree2";
            // 
            // dataColBfree3
            // 
            this.dataColBfree3.ColumnName = "Bfree3";
            // 
            // bSPartsCode
            // 
            this.bSPartsCode.DataMember = "PartsCode";
            this.bSPartsCode.DataSource = this.dSPartsCode;
            // 
            // pnlToolBar
            // 
            this.pnlToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolBar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolBar.Name = "pnlToolBar";
            this.pnlToolBar.Size = new System.Drawing.Size(1370, 40);
            this.pnlToolBar.TabIndex = 3;
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.labUnit);
            this.pnlEdit.Controls.Add(this.lookUpUnit);
            this.pnlEdit.Controls.Add(this.lookUpMachiningLevel);
            this.pnlEdit.Controls.Add(this.lookUpFinish);
            this.pnlEdit.Controls.Add(this.labMachiningLevel);
            this.pnlEdit.Controls.Add(this.labFinish);
            this.pnlEdit.Controls.Add(this.labBrand);
            this.pnlEdit.Controls.Add(this.lookUpBrand);
            this.pnlEdit.Controls.Add(this.labCatgName);
            this.pnlEdit.Controls.Add(this.lookUpCatgName);
            this.pnlEdit.Controls.Add(this.labMaterial);
            this.pnlEdit.Controls.Add(this.searchLookUpMaterial);
            this.pnlEdit.Controls.Add(this.textMaterialVersion);
            this.pnlEdit.Controls.Add(this.labMaterialVersion);
            this.pnlEdit.Controls.Add(this.textTel);
            this.pnlEdit.Controls.Add(this.labTel);
            this.pnlEdit.Controls.Add(this.textDesigner);
            this.pnlEdit.Controls.Add(this.labDesigner);
            this.pnlEdit.Controls.Add(this.checkIsPreprocessing);
            this.pnlEdit.Controls.Add(this.checkIsPrecious);
            this.pnlEdit.Controls.Add(this.checkIsLongPeriod);
            this.pnlEdit.Controls.Add(this.checkIsPreferred);
            this.pnlEdit.Controls.Add(this.spinCodeWeight);
            this.pnlEdit.Controls.Add(this.labCodeWeight);
            this.pnlEdit.Controls.Add(this.textCodeSpec);
            this.pnlEdit.Controls.Add(this.labCodeSpec);
            this.pnlEdit.Controls.Add(this.textFilePath);
            this.pnlEdit.Controls.Add(this.labFilePath);
            this.pnlEdit.Controls.Add(this.textCodeName);
            this.pnlEdit.Controls.Add(this.labCodeName);
            this.pnlEdit.Controls.Add(this.textCodeNo);
            this.pnlEdit.Controls.Add(this.textCodeFileName);
            this.pnlEdit.Controls.Add(this.labCodeNo);
            this.pnlEdit.Controls.Add(this.labCodeFileName);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEdit.Location = new System.Drawing.Point(0, 40);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(1370, 209);
            this.pnlEdit.TabIndex = 7;
            // 
            // labUnit
            // 
            this.labUnit.Location = new System.Drawing.Point(36, 126);
            this.labUnit.Name = "labUnit";
            this.labUnit.Size = new System.Drawing.Size(24, 14);
            this.labUnit.TabIndex = 46;
            this.labUnit.Text = "单位";
            // 
            // lookUpUnit
            // 
            this.lookUpUnit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSPartsCode, "Unit", true));
            this.lookUpUnit.EnterMoveNextControl = true;
            this.lookUpUnit.Location = new System.Drawing.Point(103, 123);
            this.lookUpUnit.Name = "lookUpUnit";
            this.lookUpUnit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpUnit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UnitNo", "单位编号"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UnitName", "单位名称")});
            this.lookUpUnit.Properties.DisplayMember = "UnitName";
            this.lookUpUnit.Properties.NullText = "";
            this.lookUpUnit.Properties.ValueMember = "UnitName";
            this.lookUpUnit.Size = new System.Drawing.Size(160, 20);
            this.lookUpUnit.TabIndex = 10;
            // 
            // lookUpMachiningLevel
            // 
            this.lookUpMachiningLevel.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSPartsCode, "MachiningLevel", true));
            this.lookUpMachiningLevel.EnterMoveNextControl = true;
            this.lookUpMachiningLevel.Location = new System.Drawing.Point(356, 123);
            this.lookUpMachiningLevel.Name = "lookUpMachiningLevel";
            this.lookUpMachiningLevel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpMachiningLevel.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AutoId", "AutoId", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LevelCatg", "加工等级"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CatgOrder", "排序")});
            this.lookUpMachiningLevel.Properties.DisplayMember = "LevelCatg";
            this.lookUpMachiningLevel.Properties.NullText = "";
            this.lookUpMachiningLevel.Properties.ValueMember = "AutoId";
            this.lookUpMachiningLevel.Size = new System.Drawing.Size(160, 20);
            this.lookUpMachiningLevel.TabIndex = 11;
            // 
            // lookUpFinish
            // 
            this.lookUpFinish.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSPartsCode, "Finish", true));
            this.lookUpFinish.EnterMoveNextControl = true;
            this.lookUpFinish.Location = new System.Drawing.Point(615, 123);
            this.lookUpFinish.Name = "lookUpFinish";
            this.lookUpFinish.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpFinish.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AutoId", "AutoId", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FinishCatg", "表面处理"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FinishOrder", "排序")});
            this.lookUpFinish.Properties.DisplayMember = "FinishCatg";
            this.lookUpFinish.Properties.NullText = "";
            this.lookUpFinish.Properties.ValueMember = "AutoId";
            this.lookUpFinish.Size = new System.Drawing.Size(160, 20);
            this.lookUpFinish.TabIndex = 12;
            // 
            // labMachiningLevel
            // 
            this.labMachiningLevel.Location = new System.Drawing.Point(286, 126);
            this.labMachiningLevel.Name = "labMachiningLevel";
            this.labMachiningLevel.Size = new System.Drawing.Size(48, 14);
            this.labMachiningLevel.TabIndex = 42;
            this.labMachiningLevel.Text = "加工等级";
            // 
            // labFinish
            // 
            this.labFinish.Location = new System.Drawing.Point(545, 126);
            this.labFinish.Name = "labFinish";
            this.labFinish.Size = new System.Drawing.Size(48, 14);
            this.labFinish.TabIndex = 40;
            this.labFinish.Text = "表面处理";
            // 
            // labBrand
            // 
            this.labBrand.Location = new System.Drawing.Point(805, 92);
            this.labBrand.Name = "labBrand";
            this.labBrand.Size = new System.Drawing.Size(24, 14);
            this.labBrand.TabIndex = 38;
            this.labBrand.Text = "品牌";
            // 
            // lookUpBrand
            // 
            this.lookUpBrand.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSPartsCode, "Brand", true));
            this.lookUpBrand.EnterMoveNextControl = true;
            this.lookUpBrand.Location = new System.Drawing.Point(872, 89);
            this.lookUpBrand.Name = "lookUpBrand";
            this.lookUpBrand.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpBrand.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BrandNo", "品牌编号"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BrandName", "品牌名称")});
            this.lookUpBrand.Properties.DisplayMember = "BrandName";
            this.lookUpBrand.Properties.NullText = "";
            this.lookUpBrand.Properties.ValueMember = "BrandName";
            this.lookUpBrand.Size = new System.Drawing.Size(160, 20);
            this.lookUpBrand.TabIndex = 9;
            // 
            // labCatgName
            // 
            this.labCatgName.Location = new System.Drawing.Point(805, 24);
            this.labCatgName.Name = "labCatgName";
            this.labCatgName.Size = new System.Drawing.Size(48, 14);
            this.labCatgName.TabIndex = 36;
            this.labCatgName.Text = "零件分类";
            // 
            // lookUpCatgName
            // 
            this.lookUpCatgName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSPartsCode, "CatgName", true));
            this.lookUpCatgName.EnterMoveNextControl = true;
            this.lookUpCatgName.Location = new System.Drawing.Point(872, 21);
            this.lookUpCatgName.Name = "lookUpCatgName";
            this.lookUpCatgName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpCatgName.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CatgName", "分类名称"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CatgDescription", "分类说明")});
            this.lookUpCatgName.Properties.DisplayMember = "CatgName";
            this.lookUpCatgName.Properties.NullText = "";
            this.lookUpCatgName.Properties.ValueMember = "CatgName";
            this.lookUpCatgName.Size = new System.Drawing.Size(160, 20);
            this.lookUpCatgName.TabIndex = 3;
            // 
            // labMaterial
            // 
            this.labMaterial.Location = new System.Drawing.Point(545, 92);
            this.labMaterial.Name = "labMaterial";
            this.labMaterial.Size = new System.Drawing.Size(24, 14);
            this.labMaterial.TabIndex = 34;
            this.labMaterial.Text = "材料";
            // 
            // searchLookUpMaterial
            // 
            this.searchLookUpMaterial.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSPartsCode, "Material", true));
            this.searchLookUpMaterial.EditValue = "";
            this.searchLookUpMaterial.EnterMoveNextControl = true;
            this.searchLookUpMaterial.Location = new System.Drawing.Point(615, 89);
            this.searchLookUpMaterial.Name = "searchLookUpMaterial";
            this.searchLookUpMaterial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpMaterial.Properties.DisplayMember = "MaterialName";
            this.searchLookUpMaterial.Properties.NullText = "";
            this.searchLookUpMaterial.Properties.ValueMember = "AutoId";
            this.searchLookUpMaterial.Properties.View = this.searchLookUpMaterialView;
            this.searchLookUpMaterial.Size = new System.Drawing.Size(160, 20);
            this.searchLookUpMaterial.TabIndex = 8;
            // 
            // searchLookUpMaterialView
            // 
            this.searchLookUpMaterialView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColuAutoId,
            this.gridColuLibName,
            this.gridColuMaterialCategory,
            this.gridColuMaterialName});
            this.searchLookUpMaterialView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpMaterialView.IndicatorWidth = 40;
            this.searchLookUpMaterialView.Name = "searchLookUpMaterialView";
            this.searchLookUpMaterialView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpMaterialView.OptionsView.ShowGroupPanel = false;
            this.searchLookUpMaterialView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.searchLookUpMaterialView_CustomDrawRowIndicator);
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
            // textMaterialVersion
            // 
            this.textMaterialVersion.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSPartsCode, "MaterialVersion", true));
            this.textMaterialVersion.EnterMoveNextControl = true;
            this.textMaterialVersion.Location = new System.Drawing.Point(356, 89);
            this.textMaterialVersion.Name = "textMaterialVersion";
            this.textMaterialVersion.Size = new System.Drawing.Size(160, 20);
            this.textMaterialVersion.TabIndex = 7;
            // 
            // labMaterialVersion
            // 
            this.labMaterialVersion.Location = new System.Drawing.Point(286, 92);
            this.labMaterialVersion.Name = "labMaterialVersion";
            this.labMaterialVersion.Size = new System.Drawing.Size(48, 14);
            this.labMaterialVersion.TabIndex = 32;
            this.labMaterialVersion.Text = "物料版本";
            // 
            // textTel
            // 
            this.textTel.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSPartsCode, "Tel", true));
            this.textTel.EnterMoveNextControl = true;
            this.textTel.Location = new System.Drawing.Point(872, 160);
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(160, 20);
            this.textTel.TabIndex = 18;
            // 
            // labTel
            // 
            this.labTel.Location = new System.Drawing.Point(805, 163);
            this.labTel.Name = "labTel";
            this.labTel.Size = new System.Drawing.Size(24, 14);
            this.labTel.TabIndex = 30;
            this.labTel.Text = "电话";
            // 
            // textDesigner
            // 
            this.textDesigner.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSPartsCode, "Designer", true));
            this.textDesigner.EnterMoveNextControl = true;
            this.textDesigner.Location = new System.Drawing.Point(615, 160);
            this.textDesigner.Name = "textDesigner";
            this.textDesigner.Size = new System.Drawing.Size(160, 20);
            this.textDesigner.TabIndex = 17;
            // 
            // labDesigner
            // 
            this.labDesigner.Location = new System.Drawing.Point(545, 163);
            this.labDesigner.Name = "labDesigner";
            this.labDesigner.Size = new System.Drawing.Size(36, 14);
            this.labDesigner.TabIndex = 28;
            this.labDesigner.Text = "设计者";
            // 
            // checkIsPreprocessing
            // 
            this.checkIsPreprocessing.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSPartsCode, "IsPreprocessing", true));
            this.checkIsPreprocessing.EnterMoveNextControl = true;
            this.checkIsPreprocessing.Location = new System.Drawing.Point(332, 160);
            this.checkIsPreprocessing.Name = "checkIsPreprocessing";
            this.checkIsPreprocessing.Properties.Caption = "预处理";
            this.checkIsPreprocessing.Size = new System.Drawing.Size(97, 19);
            this.checkIsPreprocessing.TabIndex = 16;
            // 
            // checkIsPrecious
            // 
            this.checkIsPrecious.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSPartsCode, "IsPrecious", true));
            this.checkIsPrecious.EnterMoveNextControl = true;
            this.checkIsPrecious.Location = new System.Drawing.Point(242, 160);
            this.checkIsPrecious.Name = "checkIsPrecious";
            this.checkIsPrecious.Properties.Caption = "贵重";
            this.checkIsPrecious.Size = new System.Drawing.Size(97, 19);
            this.checkIsPrecious.TabIndex = 15;
            // 
            // checkIsLongPeriod
            // 
            this.checkIsLongPeriod.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSPartsCode, "IsLongPeriod", true));
            this.checkIsLongPeriod.EnterMoveNextControl = true;
            this.checkIsLongPeriod.Location = new System.Drawing.Point(139, 160);
            this.checkIsLongPeriod.Name = "checkIsLongPeriod";
            this.checkIsLongPeriod.Properties.Caption = "长周期";
            this.checkIsLongPeriod.Size = new System.Drawing.Size(97, 19);
            this.checkIsLongPeriod.TabIndex = 14;
            // 
            // checkIsPreferred
            // 
            this.checkIsPreferred.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSPartsCode, "IsPreferred", true));
            this.checkIsPreferred.EnterMoveNextControl = true;
            this.checkIsPreferred.Location = new System.Drawing.Point(36, 160);
            this.checkIsPreferred.Name = "checkIsPreferred";
            this.checkIsPreferred.Properties.Caption = "优选";
            this.checkIsPreferred.Size = new System.Drawing.Size(97, 19);
            this.checkIsPreferred.TabIndex = 13;
            // 
            // spinCodeWeight
            // 
            this.spinCodeWeight.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSPartsCode, "CodeWeight", true));
            this.spinCodeWeight.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinCodeWeight.EnterMoveNextControl = true;
            this.spinCodeWeight.Location = new System.Drawing.Point(103, 89);
            this.spinCodeWeight.Name = "spinCodeWeight";
            this.spinCodeWeight.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinCodeWeight.Size = new System.Drawing.Size(160, 20);
            this.spinCodeWeight.TabIndex = 6;
            // 
            // labCodeWeight
            // 
            this.labCodeWeight.Location = new System.Drawing.Point(36, 92);
            this.labCodeWeight.Name = "labCodeWeight";
            this.labCodeWeight.Size = new System.Drawing.Size(24, 14);
            this.labCodeWeight.TabIndex = 21;
            this.labCodeWeight.Text = "重量";
            // 
            // textCodeSpec
            // 
            this.textCodeSpec.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSPartsCode, "CodeSpec", true));
            this.textCodeSpec.EnterMoveNextControl = true;
            this.textCodeSpec.Location = new System.Drawing.Point(872, 55);
            this.textCodeSpec.Name = "textCodeSpec";
            this.textCodeSpec.Size = new System.Drawing.Size(160, 20);
            this.textCodeSpec.TabIndex = 5;
            // 
            // labCodeSpec
            // 
            this.labCodeSpec.Location = new System.Drawing.Point(805, 58);
            this.labCodeSpec.Name = "labCodeSpec";
            this.labCodeSpec.Size = new System.Drawing.Size(48, 14);
            this.labCodeSpec.TabIndex = 20;
            this.labCodeSpec.Text = "规格型号";
            // 
            // textFilePath
            // 
            this.textFilePath.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSPartsCode, "FilePath", true));
            this.textFilePath.EnterMoveNextControl = true;
            this.textFilePath.Location = new System.Drawing.Point(103, 55);
            this.textFilePath.Name = "textFilePath";
            this.textFilePath.Size = new System.Drawing.Size(672, 20);
            this.textFilePath.TabIndex = 4;
            // 
            // labFilePath
            // 
            this.labFilePath.Location = new System.Drawing.Point(36, 58);
            this.labFilePath.Name = "labFilePath";
            this.labFilePath.Size = new System.Drawing.Size(48, 14);
            this.labFilePath.TabIndex = 18;
            this.labFilePath.Text = "文件路径";
            // 
            // textCodeName
            // 
            this.textCodeName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSPartsCode, "CodeName", true));
            this.textCodeName.EnterMoveNextControl = true;
            this.textCodeName.Location = new System.Drawing.Point(615, 21);
            this.textCodeName.Name = "textCodeName";
            this.textCodeName.Size = new System.Drawing.Size(160, 20);
            this.textCodeName.TabIndex = 2;
            // 
            // labCodeName
            // 
            this.labCodeName.Location = new System.Drawing.Point(545, 24);
            this.labCodeName.Name = "labCodeName";
            this.labCodeName.Size = new System.Drawing.Size(48, 14);
            this.labCodeName.TabIndex = 15;
            this.labCodeName.Text = "零件名称";
            // 
            // textCodeNo
            // 
            this.textCodeNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSPartsCode, "CodeNo", true));
            this.textCodeNo.EnterMoveNextControl = true;
            this.textCodeNo.Location = new System.Drawing.Point(356, 21);
            this.textCodeNo.Name = "textCodeNo";
            this.textCodeNo.Size = new System.Drawing.Size(160, 20);
            this.textCodeNo.TabIndex = 1;
            // 
            // textCodeFileName
            // 
            this.textCodeFileName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSPartsCode, "CodeFileName", true));
            this.textCodeFileName.EnterMoveNextControl = true;
            this.textCodeFileName.Location = new System.Drawing.Point(103, 21);
            this.textCodeFileName.Name = "textCodeFileName";
            this.textCodeFileName.Size = new System.Drawing.Size(160, 20);
            this.textCodeFileName.TabIndex = 0;
            this.textCodeFileName.EditValueChanged += new System.EventHandler(this.textCodeFileName_EditValueChanged);
            // 
            // labCodeNo
            // 
            this.labCodeNo.Location = new System.Drawing.Point(288, 24);
            this.labCodeNo.Name = "labCodeNo";
            this.labCodeNo.Size = new System.Drawing.Size(48, 14);
            this.labCodeNo.TabIndex = 14;
            this.labCodeNo.Text = "物料编号";
            // 
            // labCodeFileName
            // 
            this.labCodeFileName.Location = new System.Drawing.Point(36, 24);
            this.labCodeFileName.Name = "labCodeFileName";
            this.labCodeFileName.Size = new System.Drawing.Size(48, 14);
            this.labCodeFileName.TabIndex = 12;
            this.labCodeFileName.Text = "零件编号";
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.gridCrlPartsCode);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 249);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1370, 416);
            this.pnlGrid.TabIndex = 8;
            // 
            // gridCrlPartsCode
            // 
            this.gridCrlPartsCode.DataSource = this.bSPartsCode;
            this.gridCrlPartsCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCrlPartsCode.Location = new System.Drawing.Point(2, 2);
            this.gridCrlPartsCode.MainView = this.gridViewPartsCode;
            this.gridCrlPartsCode.Name = "gridCrlPartsCode";
            this.gridCrlPartsCode.Size = new System.Drawing.Size(1366, 412);
            this.gridCrlPartsCode.TabIndex = 0;
            this.gridCrlPartsCode.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPartsCode});
            // 
            // gridViewPartsCode
            // 
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
            this.gridViewPartsCode.OptionsBehavior.Editable = false;
            this.gridViewPartsCode.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewPartsCode.OptionsView.ColumnAutoWidth = false;
            this.gridViewPartsCode.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewPartsCode.OptionsView.ShowFooter = true;
            this.gridViewPartsCode.OptionsView.ShowGroupPanel = false;
            this.gridViewPartsCode.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.searchLookUpMaterialView_CustomDrawRowIndicator);
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
            this.colFilePath.FieldName = "FilePath";
            this.colFilePath.Name = "colFilePath";
            this.colFilePath.Visible = true;
            this.colFilePath.VisibleIndex = 3;
            this.colFilePath.Width = 250;
            // 
            // colCatgName
            // 
            this.colCatgName.AppearanceHeader.Options.UseTextOptions = true;
            this.colCatgName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCatgName.FieldName = "CatgName";
            this.colCatgName.Name = "colCatgName";
            this.colCatgName.Visible = true;
            this.colCatgName.VisibleIndex = 4;
            // 
            // colCodeSpec
            // 
            this.colCodeSpec.AppearanceHeader.Options.UseTextOptions = true;
            this.colCodeSpec.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
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
            this.colCodeWeight.FieldName = "CodeWeight";
            this.colCodeWeight.Name = "colCodeWeight";
            this.colCodeWeight.Visible = true;
            this.colCodeWeight.VisibleIndex = 6;
            this.colCodeWeight.Width = 130;
            // 
            // colMaterialVersion
            // 
            this.colMaterialVersion.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaterialVersion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaterialVersion.FieldName = "MaterialVersion";
            this.colMaterialVersion.Name = "colMaterialVersion";
            this.colMaterialVersion.Visible = true;
            this.colMaterialVersion.VisibleIndex = 7;
            // 
            // colMaterial
            // 
            this.colMaterial.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaterial.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaterial.FieldName = "Material";
            this.colMaterial.Name = "colMaterial";
            this.colMaterial.Visible = true;
            this.colMaterial.VisibleIndex = 8;
            // 
            // colBrand
            // 
            this.colBrand.AppearanceHeader.Options.UseTextOptions = true;
            this.colBrand.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBrand.FieldName = "Brand";
            this.colBrand.Name = "colBrand";
            this.colBrand.Visible = true;
            this.colBrand.VisibleIndex = 9;
            this.colBrand.Width = 90;
            // 
            // colFinish
            // 
            this.colFinish.AppearanceHeader.Options.UseTextOptions = true;
            this.colFinish.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFinish.FieldName = "Finish";
            this.colFinish.Name = "colFinish";
            this.colFinish.Visible = true;
            this.colFinish.VisibleIndex = 10;
            // 
            // colMachiningLevel
            // 
            this.colMachiningLevel.AppearanceHeader.Options.UseTextOptions = true;
            this.colMachiningLevel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMachiningLevel.FieldName = "MachiningLevel";
            this.colMachiningLevel.Name = "colMachiningLevel";
            this.colMachiningLevel.Visible = true;
            this.colMachiningLevel.VisibleIndex = 11;
            // 
            // colUnit
            // 
            this.colUnit.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.Visible = true;
            this.colUnit.VisibleIndex = 12;
            // 
            // colIsPreferred
            // 
            this.colIsPreferred.AppearanceHeader.Options.UseTextOptions = true;
            this.colIsPreferred.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIsPreferred.FieldName = "IsPreferred";
            this.colIsPreferred.Name = "colIsPreferred";
            this.colIsPreferred.Visible = true;
            this.colIsPreferred.VisibleIndex = 13;
            this.colIsPreferred.Width = 60;
            // 
            // colIsLongPeriod
            // 
            this.colIsLongPeriod.AppearanceHeader.Options.UseTextOptions = true;
            this.colIsLongPeriod.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIsLongPeriod.FieldName = "IsLongPeriod";
            this.colIsLongPeriod.Name = "colIsLongPeriod";
            this.colIsLongPeriod.Visible = true;
            this.colIsLongPeriod.VisibleIndex = 14;
            this.colIsLongPeriod.Width = 60;
            // 
            // colIsPrecious
            // 
            this.colIsPrecious.AppearanceHeader.Options.UseTextOptions = true;
            this.colIsPrecious.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIsPrecious.FieldName = "IsPrecious";
            this.colIsPrecious.Name = "colIsPrecious";
            this.colIsPrecious.Visible = true;
            this.colIsPrecious.VisibleIndex = 15;
            this.colIsPrecious.Width = 60;
            // 
            // colIsPreprocessing
            // 
            this.colIsPreprocessing.AppearanceHeader.Options.UseTextOptions = true;
            this.colIsPreprocessing.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIsPreprocessing.FieldName = "IsPreprocessing";
            this.colIsPreprocessing.Name = "colIsPreprocessing";
            this.colIsPreprocessing.Visible = true;
            this.colIsPreprocessing.VisibleIndex = 16;
            this.colIsPreprocessing.Width = 60;
            // 
            // colDesigner
            // 
            this.colDesigner.AppearanceHeader.Options.UseTextOptions = true;
            this.colDesigner.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
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
            // 
            // colBfree2
            // 
            this.colBfree2.FieldName = "Bfree2";
            this.colBfree2.Name = "colBfree2";
            // 
            // colBfree3
            // 
            this.colBfree3.FieldName = "Bfree3";
            this.colBfree3.Name = "colBfree3";
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCtjzsj,
            this.tsmiLjbh,
            this.tsmiWlbh,
            this.tsmiLjmc,
            this.tsmiLjfl,
            this.tsmiWjlj,
            this.tsmiGgxh,
            this.tsmiWlbb,
            this.tsmiDw});
            this.cms.Name = "cmsCommonHandler";
            this.cms.Size = new System.Drawing.Size(257, 202);
            // 
            // tsmiCtjzsj
            // 
            this.tsmiCtjzsj.Name = "tsmiCtjzsj";
            this.tsmiCtjzsj.Size = new System.Drawing.Size(256, 22);
            this.tsmiCtjzsj.Text = "窗体加载事件错误。";
            // 
            // tsmiLjbh
            // 
            this.tsmiLjbh.Name = "tsmiLjbh";
            this.tsmiLjbh.Size = new System.Drawing.Size(256, 22);
            this.tsmiLjbh.Text = "零件编号不能为空，请重新操作。";
            // 
            // tsmiWlbh
            // 
            this.tsmiWlbh.Name = "tsmiWlbh";
            this.tsmiWlbh.Size = new System.Drawing.Size(256, 22);
            this.tsmiWlbh.Text = "物料编号不能为空，请重新操作。";
            // 
            // tsmiLjmc
            // 
            this.tsmiLjmc.Name = "tsmiLjmc";
            this.tsmiLjmc.Size = new System.Drawing.Size(256, 22);
            this.tsmiLjmc.Text = "零件名称不能为空，请重新操作。";
            // 
            // tsmiLjfl
            // 
            this.tsmiLjfl.Name = "tsmiLjfl";
            this.tsmiLjfl.Size = new System.Drawing.Size(256, 22);
            this.tsmiLjfl.Text = "零件分类不能为空，请重新操作。";
            // 
            // tsmiWjlj
            // 
            this.tsmiWjlj.Name = "tsmiWjlj";
            this.tsmiWjlj.Size = new System.Drawing.Size(256, 22);
            this.tsmiWjlj.Text = "文件路径不能为空，请重新操作。";
            // 
            // tsmiGgxh
            // 
            this.tsmiGgxh.Name = "tsmiGgxh";
            this.tsmiGgxh.Size = new System.Drawing.Size(256, 22);
            this.tsmiGgxh.Text = "规格型号不能为空，请重新操作。";
            // 
            // tsmiWlbb
            // 
            this.tsmiWlbb.Name = "tsmiWlbb";
            this.tsmiWlbb.Size = new System.Drawing.Size(256, 22);
            this.tsmiWlbb.Text = "物料版本不能为空，请重新操作。";
            // 
            // tsmiDw
            // 
            this.tsmiDw.Name = "tsmiDw";
            this.tsmiDw.Size = new System.Drawing.Size(256, 22);
            this.tsmiDw.Text = "单位不能为空，请重新操作。";
            // 
            // FrmPartsCode
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1370, 665);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.pnlToolBar);
            this.Name = "FrmPartsCode";
            this.TabText = "物料信息";
            this.Text = "物料信息";
            this.Load += new System.EventHandler(this.FrmPartsCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSPartsCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablePartsCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSPartsCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpMachiningLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpFinish.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpBrand.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCatgName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpMaterial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpMaterialView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMaterialVersion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDesigner.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkIsPreprocessing.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkIsPrecious.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkIsLongPeriod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkIsPreferred.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinCodeWeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCodeSpec.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textFilePath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCodeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCodeNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCodeFileName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlPartsCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPartsCode)).EndInit();
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

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
        private DevExpress.XtraEditors.PanelControl pnlToolBar;
        private DevExpress.XtraEditors.PanelControl pnlEdit;
        private DevExpress.XtraEditors.TextEdit textCodeNo;
        private DevExpress.XtraEditors.TextEdit textCodeFileName;
        private DevExpress.XtraEditors.LabelControl labCodeNo;
        private DevExpress.XtraEditors.LabelControl labCodeFileName;
        private DevExpress.XtraEditors.PanelControl pnlGrid;
        private DevExpress.XtraGrid.GridControl gridCrlPartsCode;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPartsCode;
        private DevExpress.XtraEditors.TextEdit textCodeName;
        private DevExpress.XtraEditors.LabelControl labCodeName;
        private DevExpress.XtraEditors.SpinEdit spinCodeWeight;
        private DevExpress.XtraEditors.LabelControl labCodeWeight;
        private DevExpress.XtraEditors.TextEdit textCodeSpec;
        private DevExpress.XtraEditors.LabelControl labCodeSpec;
        private DevExpress.XtraEditors.TextEdit textFilePath;
        private DevExpress.XtraEditors.LabelControl labFilePath;
        private DevExpress.XtraEditors.CheckEdit checkIsPreprocessing;
        private DevExpress.XtraEditors.CheckEdit checkIsPrecious;
        private DevExpress.XtraEditors.CheckEdit checkIsLongPeriod;
        private DevExpress.XtraEditors.CheckEdit checkIsPreferred;
        private DevExpress.XtraEditors.TextEdit textTel;
        private DevExpress.XtraEditors.LabelControl labTel;
        private DevExpress.XtraEditors.TextEdit textDesigner;
        private DevExpress.XtraEditors.LabelControl labDesigner;
        private DevExpress.XtraEditors.LabelControl labMaterial;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpMaterial;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpMaterialView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColuAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColuLibName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColuMaterialCategory;
        private DevExpress.XtraGrid.Columns.GridColumn gridColuMaterialName;
        private DevExpress.XtraEditors.TextEdit textMaterialVersion;
        private DevExpress.XtraEditors.LabelControl labMaterialVersion;
        private DevExpress.XtraEditors.LabelControl labBrand;
        private DevExpress.XtraEditors.LookUpEdit lookUpBrand;
        private DevExpress.XtraEditors.LabelControl labCatgName;
        private DevExpress.XtraEditors.LookUpEdit lookUpCatgName;
        private DevExpress.XtraEditors.LookUpEdit lookUpMachiningLevel;
        private DevExpress.XtraEditors.LookUpEdit lookUpFinish;
        private DevExpress.XtraEditors.LabelControl labMachiningLevel;
        private DevExpress.XtraEditors.LabelControl labFinish;
        private DevExpress.XtraEditors.LabelControl labUnit;
        private DevExpress.XtraEditors.LookUpEdit lookUpUnit;
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
        internal System.Windows.Forms.ContextMenuStrip cms;
        internal System.Windows.Forms.ToolStripMenuItem tsmiCtjzsj;
        internal System.Windows.Forms.ToolStripMenuItem tsmiLjbh;
        internal System.Windows.Forms.ToolStripMenuItem tsmiWlbh;
        internal System.Windows.Forms.ToolStripMenuItem tsmiLjmc;
        internal System.Windows.Forms.ToolStripMenuItem tsmiLjfl;
        internal System.Windows.Forms.ToolStripMenuItem tsmiWjlj;
        internal System.Windows.Forms.ToolStripMenuItem tsmiGgxh;
        internal System.Windows.Forms.ToolStripMenuItem tsmiWlbb;
        internal System.Windows.Forms.ToolStripMenuItem tsmiDw;
    }
}