namespace PSAP.VIEW.BSVIEW
{
    partial class FrmPBBomManagement
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
            this.pnlLeft = new DevExpress.XtraEditors.PanelControl();
            this.pnlBomManagement = new DevExpress.XtraEditors.PanelControl();
            this.pnlSalesOrder = new DevExpress.XtraEditors.PanelControl();
            this.textProjectName = new DevExpress.XtraEditors.TextEdit();
            this.textProjectNo = new DevExpress.XtraEditors.TextEdit();
            this.labProjectNo = new DevExpress.XtraEditors.LabelControl();
            this.labProjectName = new DevExpress.XtraEditors.LabelControl();
            this.textAutoSalesOrderNo = new DevExpress.XtraEditors.TextEdit();
            this.labAutoSalesOrderNo = new DevExpress.XtraEditors.LabelControl();
            this.pnlRight = new DevExpress.XtraEditors.PanelControl();
            this.pnlBottom = new DevExpress.XtraEditors.PanelControl();
            this.TabControlBaseInfo = new DevExpress.XtraTab.XtraTabControl();
            this.PageBomInfo = new DevExpress.XtraTab.XtraTabPage();
            this.treeListBom = new DevExpress.XtraTreeList.TreeList();
            this.CCodeFileName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.CCodeName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.CQty = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.CParentCodeFileName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.CPCAutoId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.CReID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.CReParent = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.CMaterieStateText = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.CCodeSpec = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.CBrand = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.CUnit = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.CCatgName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.CFilePath = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.PagePartsCodeInfo = new DevExpress.XtraTab.XtraTabPage();
            this.gridCrlPartsCode = new DevExpress.XtraGrid.GridControl();
            this.bSPartsCode = new System.Windows.Forms.BindingSource(this.components);
            this.dSPartsCode = new System.Data.DataSet();
            this.TablePartsCode = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
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
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColBfree1 = new System.Data.DataColumn();
            this.dataColBfree2 = new System.Data.DataColumn();
            this.dataColBfree3 = new System.Data.DataColumn();
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
            this.pnlTop = new DevExpress.XtraEditors.PanelControl();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.labPartsCodeId = new DevExpress.XtraEditors.LabelControl();
            this.searchCodeFileName = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchPartsCodeIdView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitterMiddle = new DevExpress.XtraEditors.SplitterControl();
            this.dataSet_PBBom = new System.Data.DataSet();
            this.dataTablePBBomManagement = new System.Data.DataTable();
            this.dataTablePBBomList = new System.Data.DataTable();
            this.dataColAutoId = new System.Data.DataColumn();
            this.dataColSalesOrderNo = new System.Data.DataColumn();
            this.dataColMaterielNo = new System.Data.DataColumn();
            this.dataColLevelMaterielNo = new System.Data.DataColumn();
            this.dataColQty = new System.Data.DataColumn();
            this.dataColIsUse = new System.Data.DataColumn();
            this.dataColPrepared = new System.Data.DataColumn();
            this.dataColPreparedIp = new System.Data.DataColumn();
            this.dataColGetTime = new System.Data.DataColumn();
            this.bindingSource_PBBom = new System.Windows.Forms.BindingSource(this.components);
            this.dataColPbBomNo = new System.Data.DataColumn();
            this.dataColuAutoId = new System.Data.DataColumn();
            this.dataColuSalesOrderNo = new System.Data.DataColumn();
            this.dataColuPbBomNo = new System.Data.DataColumn();
            this.dataColuParentNo = new System.Data.DataColumn();
            this.dataColuLevelNo = new System.Data.DataColumn();
            this.dataColuGetTime = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeft)).BeginInit();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBomManagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSalesOrder)).BeginInit();
            this.pnlSalesOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textProjectName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textProjectNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAutoSalesOrderNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).BeginInit();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).BeginInit();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabControlBaseInfo)).BeginInit();
            this.TabControlBaseInfo.SuspendLayout();
            this.PageBomInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListBom)).BeginInit();
            this.PagePartsCodeInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlPartsCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSPartsCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPartsCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablePartsCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPartsCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchCodeFileName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPartsCodeIdView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_PBBom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablePBBomManagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablePBBomList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_PBBom)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlLeft.Controls.Add(this.pnlBomManagement);
            this.pnlLeft.Controls.Add(this.pnlSalesOrder);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(296, 590);
            this.pnlLeft.TabIndex = 0;
            // 
            // pnlBomManagement
            // 
            this.pnlBomManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBomManagement.Location = new System.Drawing.Point(0, 112);
            this.pnlBomManagement.Name = "pnlBomManagement";
            this.pnlBomManagement.Size = new System.Drawing.Size(296, 478);
            this.pnlBomManagement.TabIndex = 1;
            // 
            // pnlSalesOrder
            // 
            this.pnlSalesOrder.Controls.Add(this.textProjectName);
            this.pnlSalesOrder.Controls.Add(this.textProjectNo);
            this.pnlSalesOrder.Controls.Add(this.labProjectNo);
            this.pnlSalesOrder.Controls.Add(this.labProjectName);
            this.pnlSalesOrder.Controls.Add(this.textAutoSalesOrderNo);
            this.pnlSalesOrder.Controls.Add(this.labAutoSalesOrderNo);
            this.pnlSalesOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSalesOrder.Location = new System.Drawing.Point(0, 0);
            this.pnlSalesOrder.Name = "pnlSalesOrder";
            this.pnlSalesOrder.Size = new System.Drawing.Size(296, 112);
            this.pnlSalesOrder.TabIndex = 0;
            // 
            // textProjectName
            // 
            this.textProjectName.EnterMoveNextControl = true;
            this.textProjectName.Location = new System.Drawing.Point(86, 74);
            this.textProjectName.Name = "textProjectName";
            this.textProjectName.Properties.ReadOnly = true;
            this.textProjectName.Size = new System.Drawing.Size(180, 20);
            this.textProjectName.TabIndex = 11;
            this.textProjectName.TabStop = false;
            // 
            // textProjectNo
            // 
            this.textProjectNo.EnterMoveNextControl = true;
            this.textProjectNo.Location = new System.Drawing.Point(86, 44);
            this.textProjectNo.Name = "textProjectNo";
            this.textProjectNo.Properties.ReadOnly = true;
            this.textProjectNo.Size = new System.Drawing.Size(180, 20);
            this.textProjectNo.TabIndex = 10;
            this.textProjectNo.TabStop = false;
            // 
            // labProjectNo
            // 
            this.labProjectNo.Location = new System.Drawing.Point(20, 47);
            this.labProjectNo.Name = "labProjectNo";
            this.labProjectNo.Size = new System.Drawing.Size(48, 14);
            this.labProjectNo.TabIndex = 9;
            this.labProjectNo.Text = "项目号：";
            // 
            // labProjectName
            // 
            this.labProjectName.Location = new System.Drawing.Point(20, 77);
            this.labProjectName.Name = "labProjectName";
            this.labProjectName.Size = new System.Drawing.Size(60, 14);
            this.labProjectName.TabIndex = 8;
            this.labProjectName.Text = "项目名称：";
            // 
            // textAutoSalesOrderNo
            // 
            this.textAutoSalesOrderNo.EnterMoveNextControl = true;
            this.textAutoSalesOrderNo.Location = new System.Drawing.Point(86, 14);
            this.textAutoSalesOrderNo.Name = "textAutoSalesOrderNo";
            this.textAutoSalesOrderNo.Properties.ReadOnly = true;
            this.textAutoSalesOrderNo.Size = new System.Drawing.Size(180, 20);
            this.textAutoSalesOrderNo.TabIndex = 1;
            this.textAutoSalesOrderNo.TabStop = false;
            // 
            // labAutoSalesOrderNo
            // 
            this.labAutoSalesOrderNo.Location = new System.Drawing.Point(20, 17);
            this.labAutoSalesOrderNo.Name = "labAutoSalesOrderNo";
            this.labAutoSalesOrderNo.Size = new System.Drawing.Size(60, 14);
            this.labAutoSalesOrderNo.TabIndex = 2;
            this.labAutoSalesOrderNo.Text = "销售单号：";
            // 
            // pnlRight
            // 
            this.pnlRight.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlRight.Controls.Add(this.pnlBottom);
            this.pnlRight.Controls.Add(this.pnlTop);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(301, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(1483, 590);
            this.pnlRight.TabIndex = 1;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.TabControlBaseInfo);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(0, 112);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1483, 478);
            this.pnlBottom.TabIndex = 2;
            // 
            // TabControlBaseInfo
            // 
            this.TabControlBaseInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlBaseInfo.Location = new System.Drawing.Point(2, 2);
            this.TabControlBaseInfo.Name = "TabControlBaseInfo";
            this.TabControlBaseInfo.SelectedTabPage = this.PageBomInfo;
            this.TabControlBaseInfo.Size = new System.Drawing.Size(1479, 474);
            this.TabControlBaseInfo.TabIndex = 0;
            this.TabControlBaseInfo.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.PageBomInfo,
            this.PagePartsCodeInfo});
            // 
            // PageBomInfo
            // 
            this.PageBomInfo.Controls.Add(this.treeListBom);
            this.PageBomInfo.Name = "PageBomInfo";
            this.PageBomInfo.Size = new System.Drawing.Size(1473, 445);
            this.PageBomInfo.Text = "Bom信息";
            // 
            // treeListBom
            // 
            this.treeListBom.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.CCodeFileName,
            this.CCodeName,
            this.CQty,
            this.CParentCodeFileName,
            this.CPCAutoId,
            this.CReID,
            this.CReParent,
            this.CMaterieStateText,
            this.CCodeSpec,
            this.CBrand,
            this.CUnit,
            this.CCatgName,
            this.CFilePath});
            this.treeListBom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListBom.KeyFieldName = "ReID";
            this.treeListBom.Location = new System.Drawing.Point(0, 0);
            this.treeListBom.Name = "treeListBom";
            this.treeListBom.OptionsBehavior.Editable = false;
            this.treeListBom.OptionsBehavior.EnableFiltering = true;
            this.treeListBom.OptionsBehavior.ReadOnly = true;
            this.treeListBom.OptionsClipboard.AllowCopy = DevExpress.Utils.DefaultBoolean.True;
            this.treeListBom.OptionsClipboard.CopyNodeHierarchy = DevExpress.Utils.DefaultBoolean.True;
            this.treeListBom.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.treeListBom.OptionsView.AutoWidth = false;
            this.treeListBom.OptionsView.EnableAppearanceEvenRow = true;
            this.treeListBom.OptionsView.EnableAppearanceOddRow = true;
            this.treeListBom.OptionsView.ShowHorzLines = false;
            this.treeListBom.OptionsView.ShowIndicator = false;
            this.treeListBom.OptionsView.ShowVertLines = false;
            this.treeListBom.ParentFieldName = "ReParent";
            this.treeListBom.Size = new System.Drawing.Size(1473, 445);
            this.treeListBom.TabIndex = 3;
            this.treeListBom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeListBom_KeyDown);
            // 
            // CCodeFileName
            // 
            this.CCodeFileName.AppearanceHeader.Options.UseTextOptions = true;
            this.CCodeFileName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CCodeFileName.Caption = "零件编号";
            this.CCodeFileName.FieldName = "CodeFileName";
            this.CCodeFileName.Name = "CCodeFileName";
            this.CCodeFileName.Visible = true;
            this.CCodeFileName.VisibleIndex = 0;
            this.CCodeFileName.Width = 350;
            // 
            // CCodeName
            // 
            this.CCodeName.AppearanceHeader.Options.UseTextOptions = true;
            this.CCodeName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CCodeName.Caption = "零件名称";
            this.CCodeName.FieldName = "CodeName";
            this.CCodeName.Name = "CCodeName";
            this.CCodeName.Visible = true;
            this.CCodeName.VisibleIndex = 1;
            this.CCodeName.Width = 150;
            // 
            // CQty
            // 
            this.CQty.AppearanceHeader.Options.UseTextOptions = true;
            this.CQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CQty.Caption = "数量";
            this.CQty.FieldName = "Qty";
            this.CQty.Name = "CQty";
            this.CQty.Visible = true;
            this.CQty.VisibleIndex = 2;
            this.CQty.Width = 60;
            // 
            // CParentCodeFileName
            // 
            this.CParentCodeFileName.Caption = "ParentCodeFileName";
            this.CParentCodeFileName.FieldName = "ParentCodeFileName";
            this.CParentCodeFileName.Name = "CParentCodeFileName";
            // 
            // CPCAutoId
            // 
            this.CPCAutoId.Caption = "PCAutoId";
            this.CPCAutoId.FieldName = "PCAutoId";
            this.CPCAutoId.Name = "CPCAutoId";
            // 
            // CReID
            // 
            this.CReID.Caption = "ReID";
            this.CReID.FieldName = "ReID";
            this.CReID.Name = "CReID";
            // 
            // CReParent
            // 
            this.CReParent.Caption = "ReParent";
            this.CReParent.FieldName = "ReParent";
            this.CReParent.Name = "CReParent";
            // 
            // CMaterieStateText
            // 
            this.CMaterieStateText.AppearanceHeader.Options.UseTextOptions = true;
            this.CMaterieStateText.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CMaterieStateText.Caption = "物料状态";
            this.CMaterieStateText.FieldName = "MaterieStateText";
            this.CMaterieStateText.Name = "CMaterieStateText";
            this.CMaterieStateText.Visible = true;
            this.CMaterieStateText.VisibleIndex = 3;
            this.CMaterieStateText.Width = 100;
            // 
            // CCodeSpec
            // 
            this.CCodeSpec.AppearanceHeader.Options.UseTextOptions = true;
            this.CCodeSpec.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CCodeSpec.Caption = "规格型号";
            this.CCodeSpec.FieldName = "CodeSpec";
            this.CCodeSpec.Name = "CCodeSpec";
            this.CCodeSpec.Visible = true;
            this.CCodeSpec.VisibleIndex = 4;
            this.CCodeSpec.Width = 120;
            // 
            // CBrand
            // 
            this.CBrand.AppearanceHeader.Options.UseTextOptions = true;
            this.CBrand.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CBrand.Caption = "品牌";
            this.CBrand.FieldName = "Brand";
            this.CBrand.Name = "CBrand";
            this.CBrand.Visible = true;
            this.CBrand.VisibleIndex = 5;
            this.CBrand.Width = 80;
            // 
            // CUnit
            // 
            this.CUnit.AppearanceHeader.Options.UseTextOptions = true;
            this.CUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CUnit.Caption = "单位";
            this.CUnit.FieldName = "Unit";
            this.CUnit.Name = "CUnit";
            this.CUnit.Visible = true;
            this.CUnit.VisibleIndex = 6;
            this.CUnit.Width = 80;
            // 
            // CCatgName
            // 
            this.CCatgName.AppearanceHeader.Options.UseTextOptions = true;
            this.CCatgName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CCatgName.Caption = "分类";
            this.CCatgName.FieldName = "CatgName";
            this.CCatgName.Name = "CCatgName";
            this.CCatgName.Visible = true;
            this.CCatgName.VisibleIndex = 7;
            this.CCatgName.Width = 80;
            // 
            // CFilePath
            // 
            this.CFilePath.AppearanceHeader.Options.UseTextOptions = true;
            this.CFilePath.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CFilePath.Caption = "文件路径";
            this.CFilePath.FieldName = "FilePath";
            this.CFilePath.Name = "CFilePath";
            this.CFilePath.Visible = true;
            this.CFilePath.VisibleIndex = 8;
            this.CFilePath.Width = 400;
            // 
            // PagePartsCodeInfo
            // 
            this.PagePartsCodeInfo.Controls.Add(this.gridCrlPartsCode);
            this.PagePartsCodeInfo.Name = "PagePartsCodeInfo";
            this.PagePartsCodeInfo.Size = new System.Drawing.Size(1473, 445);
            this.PagePartsCodeInfo.Text = "物料信息";
            // 
            // gridCrlPartsCode
            // 
            this.gridCrlPartsCode.DataSource = this.bSPartsCode;
            this.gridCrlPartsCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCrlPartsCode.Location = new System.Drawing.Point(0, 0);
            this.gridCrlPartsCode.MainView = this.gridViewPartsCode;
            this.gridCrlPartsCode.Name = "gridCrlPartsCode";
            this.gridCrlPartsCode.Size = new System.Drawing.Size(1473, 445);
            this.gridCrlPartsCode.TabIndex = 1;
            this.gridCrlPartsCode.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPartsCode});
            // 
            // bSPartsCode
            // 
            this.bSPartsCode.DataMember = "PartsCode";
            this.bSPartsCode.DataSource = this.dSPartsCode;
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
            this.dataColumn1,
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
            this.dataColumn2,
            this.dataColBfree1,
            this.dataColBfree2,
            this.dataColBfree3});
            this.TablePartsCode.TableName = "PartsCode";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "AutoId";
            this.dataColumn1.DataType = typeof(int);
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
            // dataColumn2
            // 
            this.dataColumn2.Caption = "登记时间";
            this.dataColumn2.ColumnName = "GetTime";
            this.dataColumn2.DataType = typeof(System.DateTime);
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
            this.gridViewPartsCode.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewBomMateriel_CustomDrawRowIndicator);
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
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnQuery);
            this.pnlTop.Controls.Add(this.labPartsCodeId);
            this.pnlTop.Controls.Add(this.searchCodeFileName);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1483, 112);
            this.pnlTop.TabIndex = 1;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(386, 51);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 16;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // labPartsCodeId
            // 
            this.labPartsCodeId.Location = new System.Drawing.Point(42, 47);
            this.labPartsCodeId.Name = "labPartsCodeId";
            this.labPartsCodeId.Size = new System.Drawing.Size(48, 14);
            this.labPartsCodeId.TabIndex = 15;
            this.labPartsCodeId.Text = "零件编号";
            // 
            // searchCodeFileName
            // 
            this.searchCodeFileName.EnterMoveNextControl = true;
            this.searchCodeFileName.Location = new System.Drawing.Point(118, 44);
            this.searchCodeFileName.Name = "searchCodeFileName";
            this.searchCodeFileName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchCodeFileName.Properties.DisplayMember = "CodeFileName";
            this.searchCodeFileName.Properties.NullText = "";
            this.searchCodeFileName.Properties.ValueMember = "CodeFileName";
            this.searchCodeFileName.Properties.View = this.searchPartsCodeIdView;
            this.searchCodeFileName.Size = new System.Drawing.Size(150, 20);
            this.searchCodeFileName.TabIndex = 14;
            // 
            // searchPartsCodeIdView
            // 
            this.searchPartsCodeIdView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn2});
            this.searchPartsCodeIdView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchPartsCodeIdView.IndicatorWidth = 60;
            this.searchPartsCodeIdView.Name = "searchPartsCodeIdView";
            this.searchPartsCodeIdView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchPartsCodeIdView.OptionsView.ShowGroupPanel = false;
            this.searchPartsCodeIdView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewBomMateriel_CustomDrawRowIndicator);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "零件编号";
            this.gridColumn1.FieldName = "CodeFileName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "零件名称";
            this.gridColumn3.FieldName = "CodeName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "AutoId";
            this.gridColumn2.FieldName = "AutoId";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // splitterMiddle
            // 
            this.splitterMiddle.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.splitterMiddle.Location = new System.Drawing.Point(296, 0);
            this.splitterMiddle.Name = "splitterMiddle";
            this.splitterMiddle.Size = new System.Drawing.Size(5, 590);
            this.splitterMiddle.TabIndex = 14;
            this.splitterMiddle.TabStop = false;
            // 
            // dataSet_PBBom
            // 
            this.dataSet_PBBom.DataSetName = "NewDataSet";
            this.dataSet_PBBom.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTablePBBomManagement,
            this.dataTablePBBomList});
            // 
            // dataTablePBBomManagement
            // 
            this.dataTablePBBomManagement.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColuAutoId,
            this.dataColuSalesOrderNo,
            this.dataColuPbBomNo,
            this.dataColuParentNo,
            this.dataColuLevelNo,
            this.dataColuGetTime});
            this.dataTablePBBomManagement.TableName = "PBBomManagement";
            // 
            // dataTablePBBomList
            // 
            this.dataTablePBBomList.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColAutoId,
            this.dataColSalesOrderNo,
            this.dataColMaterielNo,
            this.dataColLevelMaterielNo,
            this.dataColQty,
            this.dataColIsUse,
            this.dataColPrepared,
            this.dataColPreparedIp,
            this.dataColGetTime,
            this.dataColPbBomNo});
            this.dataTablePBBomList.TableName = "PBBomList";
            // 
            // dataColAutoId
            // 
            this.dataColAutoId.ColumnName = "AutoId";
            this.dataColAutoId.DataType = typeof(int);
            // 
            // dataColSalesOrderNo
            // 
            this.dataColSalesOrderNo.Caption = "销售单号";
            this.dataColSalesOrderNo.ColumnName = "SalesOrderNo";
            // 
            // dataColMaterielNo
            // 
            this.dataColMaterielNo.Caption = "母物料";
            this.dataColMaterielNo.ColumnName = "MaterielNo";
            // 
            // dataColLevelMaterielNo
            // 
            this.dataColLevelMaterielNo.Caption = "子物料";
            this.dataColLevelMaterielNo.ColumnName = "LevelMaterielNo";
            // 
            // dataColQty
            // 
            this.dataColQty.Caption = "数量";
            this.dataColQty.ColumnName = "Qty";
            this.dataColQty.DataType = typeof(int);
            // 
            // dataColIsUse
            // 
            this.dataColIsUse.Caption = "是否使用";
            this.dataColIsUse.ColumnName = "IsUse";
            this.dataColIsUse.DataType = typeof(short);
            // 
            // dataColPrepared
            // 
            this.dataColPrepared.Caption = "制单人";
            this.dataColPrepared.ColumnName = "Prepared";
            // 
            // dataColPreparedIp
            // 
            this.dataColPreparedIp.Caption = "制单人IP";
            this.dataColPreparedIp.ColumnName = "PreparedIp";
            // 
            // dataColGetTime
            // 
            this.dataColGetTime.Caption = "登记时间";
            this.dataColGetTime.ColumnName = "GetTime";
            this.dataColGetTime.DataType = typeof(System.DateTime);
            // 
            // bindingSource_PBBom
            // 
            this.bindingSource_PBBom.DataMember = "PBBomManagement";
            this.bindingSource_PBBom.DataSource = this.dataSet_PBBom;
            // 
            // dataColPbBomNo
            // 
            this.dataColPbBomNo.Caption = "BOM编号";
            this.dataColPbBomNo.ColumnName = "PbBomNo";
            // 
            // dataColuAutoId
            // 
            this.dataColuAutoId.ColumnName = "AutoId";
            this.dataColuAutoId.DataType = typeof(int);
            // 
            // dataColuSalesOrderNo
            // 
            this.dataColuSalesOrderNo.Caption = "销售单号";
            this.dataColuSalesOrderNo.ColumnName = "SalesOrderNo";
            // 
            // dataColuPbBomNo
            // 
            this.dataColuPbBomNo.Caption = "BOM编号";
            this.dataColuPbBomNo.ColumnName = "PbBomNo";
            // 
            // dataColuParentNo
            // 
            this.dataColuParentNo.Caption = "母物料";
            this.dataColuParentNo.ColumnName = "ParentNo";
            // 
            // dataColuLevelNo
            // 
            this.dataColuLevelNo.Caption = "子物料";
            this.dataColuLevelNo.ColumnName = "LevelNo";
            // 
            // dataColuGetTime
            // 
            this.dataColuGetTime.Caption = "登记时间";
            this.dataColuGetTime.ColumnName = "GetTime";
            this.dataColuGetTime.DataType = typeof(System.DateTime);
            // 
            // FrmPBBomManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1784, 590);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.splitterMiddle);
            this.Controls.Add(this.pnlLeft);
            this.Name = "FrmPBBomManagement";
            this.TabText = "生产Bom登记";
            this.Text = "生产Bom登记";
            this.Load += new System.EventHandler(this.FrmPBBomManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeft)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlBomManagement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSalesOrder)).EndInit();
            this.pnlSalesOrder.ResumeLayout(false);
            this.pnlSalesOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textProjectName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textProjectNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAutoSalesOrderNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).EndInit();
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabControlBaseInfo)).EndInit();
            this.TabControlBaseInfo.ResumeLayout(false);
            this.PageBomInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListBom)).EndInit();
            this.PagePartsCodeInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlPartsCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSPartsCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPartsCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablePartsCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPartsCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchCodeFileName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPartsCodeIdView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_PBBom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablePBBomManagement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablePBBomList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_PBBom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlLeft;
        private DevExpress.XtraEditors.PanelControl pnlRight;
        private DevExpress.XtraEditors.PanelControl pnlBomManagement;
        private DevExpress.XtraEditors.PanelControl pnlSalesOrder;
        private DevExpress.XtraEditors.PanelControl pnlBottom;
        private DevExpress.XtraEditors.PanelControl pnlTop;
        private DevExpress.XtraEditors.SplitterControl splitterMiddle;
        public System.Data.DataSet dataSet_PBBom;
        private System.Data.DataTable dataTablePBBomManagement;
        private System.Data.DataColumn dataColAutoId;
        private System.Data.DataColumn dataColSalesOrderNo;
        private System.Data.DataColumn dataColMaterielNo;
        private System.Data.DataColumn dataColLevelMaterielNo;
        private System.Data.DataColumn dataColQty;
        private System.Data.DataColumn dataColIsUse;
        private System.Data.DataColumn dataColPrepared;
        private System.Data.DataColumn dataColPreparedIp;
        private System.Data.DataColumn dataColGetTime;
        private System.Windows.Forms.BindingSource bindingSource_PBBom;
        private DevExpress.XtraEditors.TextEdit textAutoSalesOrderNo;
        private DevExpress.XtraEditors.LabelControl labAutoSalesOrderNo;
        private DevExpress.XtraEditors.LabelControl labProjectName;
        private DevExpress.XtraEditors.TextEdit textProjectName;
        private DevExpress.XtraEditors.TextEdit textProjectNo;
        private DevExpress.XtraEditors.LabelControl labProjectNo;
        private DevExpress.XtraTab.XtraTabControl TabControlBaseInfo;
        private DevExpress.XtraTab.XtraTabPage PageBomInfo;
        private DevExpress.XtraTab.XtraTabPage PagePartsCodeInfo;
        private System.Data.DataSet dSPartsCode;
        private System.Data.DataTable TablePartsCode;
        private System.Data.DataColumn dataColumn1;
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
        private System.Data.DataColumn dataColumn2;
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
        private DevExpress.XtraTreeList.TreeList treeListBom;
        private DevExpress.XtraTreeList.Columns.TreeListColumn CCodeFileName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn CCodeName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn CQty;
        private DevExpress.XtraTreeList.Columns.TreeListColumn CParentCodeFileName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn CPCAutoId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn CReID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn CReParent;
        private DevExpress.XtraTreeList.Columns.TreeListColumn CMaterieStateText;
        private DevExpress.XtraTreeList.Columns.TreeListColumn CCodeSpec;
        private DevExpress.XtraTreeList.Columns.TreeListColumn CBrand;
        private DevExpress.XtraTreeList.Columns.TreeListColumn CUnit;
        private DevExpress.XtraTreeList.Columns.TreeListColumn CCatgName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn CFilePath;
        private DevExpress.XtraEditors.LabelControl labPartsCodeId;
        private DevExpress.XtraEditors.SearchLookUpEdit searchCodeFileName;
        private DevExpress.XtraGrid.Views.Grid.GridView searchPartsCodeIdView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private System.Data.DataTable dataTablePBBomList;
        private System.Data.DataColumn dataColuAutoId;
        private System.Data.DataColumn dataColuSalesOrderNo;
        private System.Data.DataColumn dataColuPbBomNo;
        private System.Data.DataColumn dataColuParentNo;
        private System.Data.DataColumn dataColuLevelNo;
        private System.Data.DataColumn dataColuGetTime;
        private System.Data.DataColumn dataColPbBomNo;
    }
}