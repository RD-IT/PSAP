namespace PSAP.VIEW.BSVIEW
{
    partial class FrmStnSummary
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.dataSet_DeliveryDetail = new System.Data.DataSet();
            this.TableDeliveryDetail = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColuSMNo = new System.Data.DataColumn();
            this.dataColuDeliveryText = new System.Data.DataColumn();
            this.dataColuFunctionDesc = new System.Data.DataColumn();
            this.dataColuMatQty = new System.Data.DataColumn();
            this.dataColuMatUnit = new System.Data.DataColumn();
            this.dataColuMatAmount = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.btnEditAutoQuotationNo = new DevExpress.XtraEditors.ButtonEdit();
            this.pnlLeft = new DevExpress.XtraEditors.PanelControl();
            this.pnlDeliveryDetail = new DevExpress.XtraEditors.PanelControl();
            this.TabControlDeliveryDetail = new DevExpress.XtraTab.XtraTabControl();
            this.PageDeliveryDetail = new DevExpress.XtraTab.XtraTabPage();
            this.pnlDeliveryDetailGrid = new DevExpress.XtraEditors.PanelControl();
            this.gridControlDeliveryDetail = new DevExpress.XtraGrid.GridControl();
            this.bindingSource_DeliveryDetail = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewDeliveryDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSMNo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeliveryText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repMemoDeliveryText = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colFunctionDesc1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterialName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterialBrand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterialCate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterialDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlDeliveryDetailToolBar = new DevExpress.XtraEditors.PanelControl();
            this.splitterRight = new DevExpress.XtraEditors.SplitterControl();
            this.pnlModuleList = new DevExpress.XtraEditors.PanelControl();
            this.xtraTabModuleList = new DevExpress.XtraTab.XtraTabControl();
            this.PageModuleList = new DevExpress.XtraTab.XtraTabPage();
            this.pnlModuleListGrid = new DevExpress.XtraEditors.PanelControl();
            this.gridControlModuleList = new DevExpress.XtraGrid.GridControl();
            this.bindingSource_StnListModule = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_StnSummary = new System.Data.DataSet();
            this.TableStnSummary = new System.Data.DataTable();
            this.dataColuAutoId = new System.Data.DataColumn();
            this.dataColuSSNo = new System.Data.DataColumn();
            this.dataColuAutoQuotationNo = new System.Data.DataColumn();
            this.dataColuPrepared = new System.Data.DataColumn();
            this.dataColuPreparedIp = new System.Data.DataColumn();
            this.dataColuGetTime = new System.Data.DataColumn();
            this.TableStnList = new System.Data.DataTable();
            this.dcAutoId = new System.Data.DataColumn();
            this.dcSSNoNO = new System.Data.DataColumn();
            this.dcStnNo = new System.Data.DataColumn();
            this.dcStnDesc = new System.Data.DataColumn();
            this.dcPrepared = new System.Data.DataColumn();
            this.dcPreparedIp = new System.Data.DataColumn();
            this.dcGetTime = new System.Data.DataColumn();
            this.TableStnListModule = new System.Data.DataTable();
            this.dataColumnAutoId = new System.Data.DataColumn();
            this.dataColumnStnSummaryListId = new System.Data.DataColumn();
            this.dataColumnSMNo = new System.Data.DataColumn();
            this.dataColFunctionDesc = new System.Data.DataColumn();
            this.dataColFunctionDetail = new System.Data.DataColumn();
            this.gridViewModuleList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStnSummaryListId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSMNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFunctionDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFunctionDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlModuleListToolBar = new DevExpress.XtraEditors.PanelControl();
            this.btnModuleCopy = new DevExpress.XtraEditors.SimpleButton();
            this.btnModuleSelect = new DevExpress.XtraEditors.SimpleButton();
            this.btnModuleNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnModuleDelete = new DevExpress.XtraEditors.SimpleButton();
            this.splitterLeft = new DevExpress.XtraEditors.SplitterControl();
            this.pnlStnList = new DevExpress.XtraEditors.PanelControl();
            this.xtraTabStnList = new DevExpress.XtraTab.XtraTabControl();
            this.PageStnList = new DevExpress.XtraTab.XtraTabPage();
            this.pnlStnListGrid = new DevExpress.XtraEditors.PanelControl();
            this.gridControlStnList = new DevExpress.XtraGrid.GridControl();
            this.bindingSource_StnList = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewStnList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSSNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStnNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStnDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrepared = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPreparedIp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGetTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlStnListEdit = new DevExpress.XtraEditors.PanelControl();
            this.textEditStnDesc = new DevExpress.XtraEditors.TextEdit();
            this.labStnDesc = new DevExpress.XtraEditors.LabelControl();
            this.textEditStnNo = new DevExpress.XtraEditors.TextEdit();
            this.labStnNo = new DevExpress.XtraEditors.LabelControl();
            this.pnlStnListToolBar = new DevExpress.XtraEditors.PanelControl();
            this.btnStnListCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnStnListDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnStnListSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnStnListNew = new DevExpress.XtraEditors.SimpleButton();
            this.pnlTop = new DevExpress.XtraEditors.PanelControl();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.textGetTime = new DevExpress.XtraEditors.TextEdit();
            this.labGetTime = new DevExpress.XtraEditors.LabelControl();
            this.labPrepared = new DevExpress.XtraEditors.LabelControl();
            this.textPrepared = new DevExpress.XtraEditors.TextEdit();
            this.labSSNo = new DevExpress.XtraEditors.LabelControl();
            this.btnEditSSNo = new DevExpress.XtraEditors.ButtonEdit();
            this.labAutoQuotationNo = new DevExpress.XtraEditors.LabelControl();
            this.dockManagerRight = new DevExpress.XtraBars.Docking.DockManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_DeliveryDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableDeliveryDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditAutoQuotationNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeft)).BeginInit();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDeliveryDetail)).BeginInit();
            this.pnlDeliveryDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabControlDeliveryDetail)).BeginInit();
            this.TabControlDeliveryDetail.SuspendLayout();
            this.PageDeliveryDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDeliveryDetailGrid)).BeginInit();
            this.pnlDeliveryDetailGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDeliveryDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_DeliveryDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDeliveryDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repMemoDeliveryText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDeliveryDetailToolBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlModuleList)).BeginInit();
            this.pnlModuleList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabModuleList)).BeginInit();
            this.xtraTabModuleList.SuspendLayout();
            this.PageModuleList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlModuleListGrid)).BeginInit();
            this.pnlModuleListGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlModuleList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_StnListModule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_StnSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableStnSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableStnList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableStnListModule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewModuleList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlModuleListToolBar)).BeginInit();
            this.pnlModuleListToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlStnList)).BeginInit();
            this.pnlStnList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabStnList)).BeginInit();
            this.xtraTabStnList.SuspendLayout();
            this.PageStnList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlStnListGrid)).BeginInit();
            this.pnlStnListGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStnList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_StnList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStnList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlStnListEdit)).BeginInit();
            this.pnlStnListEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditStnDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditStnNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlStnListToolBar)).BeginInit();
            this.pnlStnListToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textGetTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPrepared.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditSSNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManagerRight)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet_DeliveryDetail
            // 
            this.dataSet_DeliveryDetail.DataSetName = "NewDataSet";
            this.dataSet_DeliveryDetail.Tables.AddRange(new System.Data.DataTable[] {
            this.TableDeliveryDetail});
            // 
            // TableDeliveryDetail
            // 
            this.TableDeliveryDetail.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColuSMNo,
            this.dataColuDeliveryText,
            this.dataColuFunctionDesc,
            this.dataColuMatQty,
            this.dataColuMatUnit,
            this.dataColuMatAmount,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4});
            this.TableDeliveryDetail.TableName = "DeliveryDetail";
            // 
            // dataColumn1
            // 
            this.dataColumn1.Caption = "类别";
            this.dataColumn1.ColumnName = "MaterialCate";
            // 
            // dataColuSMNo
            // 
            this.dataColuSMNo.Caption = "模块序号";
            this.dataColuSMNo.ColumnName = "SMNo";
            // 
            // dataColuDeliveryText
            // 
            this.dataColuDeliveryText.Caption = "供货明细内容";
            this.dataColuDeliveryText.ColumnName = "DeliveryText";
            // 
            // dataColuFunctionDesc
            // 
            this.dataColuFunctionDesc.Caption = "详细功能";
            this.dataColuFunctionDesc.ColumnName = "FunctionDesc";
            // 
            // dataColuMatQty
            // 
            this.dataColuMatQty.Caption = "数量";
            this.dataColuMatQty.ColumnName = "MatQty";
            this.dataColuMatQty.DataType = typeof(double);
            // 
            // dataColuMatUnit
            // 
            this.dataColuMatUnit.Caption = "单价";
            this.dataColuMatUnit.ColumnName = "MatUnit";
            this.dataColuMatUnit.DataType = typeof(double);
            // 
            // dataColuMatAmount
            // 
            this.dataColuMatAmount.Caption = "金额";
            this.dataColuMatAmount.ColumnName = "MatAmount";
            this.dataColuMatAmount.DataType = typeof(double);
            // 
            // dataColumn2
            // 
            this.dataColumn2.Caption = "元器件名称";
            this.dataColumn2.ColumnName = "MaterialName";
            // 
            // dataColumn3
            // 
            this.dataColumn3.Caption = "元器件品牌";
            this.dataColumn3.ColumnName = "MaterialBrand";
            // 
            // dataColumn4
            // 
            this.dataColumn4.Caption = "功能描述";
            this.dataColumn4.ColumnName = "MaterialDesc";
            // 
            // btnEditAutoQuotationNo
            // 
            this.btnEditAutoQuotationNo.Location = new System.Drawing.Point(99, 21);
            this.btnEditAutoQuotationNo.Name = "btnEditAutoQuotationNo";
            this.btnEditAutoQuotationNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "查询", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnEditAutoQuotationNo.Properties.ReadOnly = true;
            this.btnEditAutoQuotationNo.Size = new System.Drawing.Size(150, 21);
            this.btnEditAutoQuotationNo.TabIndex = 0;
            this.btnEditAutoQuotationNo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnEditAutoQuotationNo_ButtonClick);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlLeft.Controls.Add(this.pnlDeliveryDetail);
            this.pnlLeft.Controls.Add(this.splitterRight);
            this.pnlLeft.Controls.Add(this.pnlModuleList);
            this.pnlLeft.Controls.Add(this.splitterLeft);
            this.pnlLeft.Controls.Add(this.pnlStnList);
            this.pnlLeft.Controls.Add(this.pnlTop);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(1264, 729);
            this.pnlLeft.TabIndex = 1;
            // 
            // pnlDeliveryDetail
            // 
            this.pnlDeliveryDetail.Controls.Add(this.TabControlDeliveryDetail);
            this.pnlDeliveryDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDeliveryDetail.Location = new System.Drawing.Point(900, 68);
            this.pnlDeliveryDetail.Name = "pnlDeliveryDetail";
            this.pnlDeliveryDetail.Size = new System.Drawing.Size(364, 661);
            this.pnlDeliveryDetail.TabIndex = 21;
            // 
            // TabControlDeliveryDetail
            // 
            this.TabControlDeliveryDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlDeliveryDetail.Location = new System.Drawing.Point(2, 2);
            this.TabControlDeliveryDetail.Name = "TabControlDeliveryDetail";
            this.TabControlDeliveryDetail.SelectedTabPage = this.PageDeliveryDetail;
            this.TabControlDeliveryDetail.Size = new System.Drawing.Size(360, 657);
            this.TabControlDeliveryDetail.TabIndex = 23;
            this.TabControlDeliveryDetail.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.PageDeliveryDetail});
            // 
            // PageDeliveryDetail
            // 
            this.PageDeliveryDetail.Controls.Add(this.pnlDeliveryDetailGrid);
            this.PageDeliveryDetail.Controls.Add(this.pnlDeliveryDetailToolBar);
            this.PageDeliveryDetail.Name = "PageDeliveryDetail";
            this.PageDeliveryDetail.Size = new System.Drawing.Size(354, 628);
            this.PageDeliveryDetail.Text = "供货明细列表";
            // 
            // pnlDeliveryDetailGrid
            // 
            this.pnlDeliveryDetailGrid.Controls.Add(this.gridControlDeliveryDetail);
            this.pnlDeliveryDetailGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDeliveryDetailGrid.Location = new System.Drawing.Point(0, 40);
            this.pnlDeliveryDetailGrid.Name = "pnlDeliveryDetailGrid";
            this.pnlDeliveryDetailGrid.Size = new System.Drawing.Size(354, 588);
            this.pnlDeliveryDetailGrid.TabIndex = 24;
            // 
            // gridControlDeliveryDetail
            // 
            this.gridControlDeliveryDetail.DataSource = this.bindingSource_DeliveryDetail;
            this.gridControlDeliveryDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDeliveryDetail.Location = new System.Drawing.Point(2, 2);
            this.gridControlDeliveryDetail.MainView = this.gridViewDeliveryDetail;
            this.gridControlDeliveryDetail.Name = "gridControlDeliveryDetail";
            this.gridControlDeliveryDetail.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repMemoDeliveryText});
            this.gridControlDeliveryDetail.Size = new System.Drawing.Size(350, 584);
            this.gridControlDeliveryDetail.TabIndex = 6;
            this.gridControlDeliveryDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDeliveryDetail});
            // 
            // bindingSource_DeliveryDetail
            // 
            this.bindingSource_DeliveryDetail.DataMember = "DeliveryDetail";
            this.bindingSource_DeliveryDetail.DataSource = this.dataSet_DeliveryDetail;
            // 
            // gridViewDeliveryDetail
            // 
            this.gridViewDeliveryDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSMNo1,
            this.colDeliveryText,
            this.colFunctionDesc1,
            this.colMaterialName,
            this.colMaterialBrand,
            this.colMaterialCate,
            this.colMatUnit,
            this.colMatQty,
            this.colMatAmount,
            this.colMaterialDesc});
            this.gridViewDeliveryDetail.GridControl = this.gridControlDeliveryDetail;
            this.gridViewDeliveryDetail.IndicatorWidth = 40;
            this.gridViewDeliveryDetail.Name = "gridViewDeliveryDetail";
            this.gridViewDeliveryDetail.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewDeliveryDetail.OptionsBehavior.Editable = false;
            this.gridViewDeliveryDetail.OptionsBehavior.ReadOnly = true;
            this.gridViewDeliveryDetail.OptionsMenu.EnableColumnMenu = false;
            this.gridViewDeliveryDetail.OptionsMenu.EnableFooterMenu = false;
            this.gridViewDeliveryDetail.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewDeliveryDetail.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewDeliveryDetail.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewDeliveryDetail.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewDeliveryDetail.OptionsView.AllowCellMerge = true;
            this.gridViewDeliveryDetail.OptionsView.ColumnAutoWidth = false;
            this.gridViewDeliveryDetail.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewDeliveryDetail.OptionsView.ShowFooter = true;
            this.gridViewDeliveryDetail.OptionsView.ShowGroupPanel = false;
            this.gridViewDeliveryDetail.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewStnList_CustomDrawRowIndicator);
            this.gridViewDeliveryDetail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewStnList_KeyDown);
            // 
            // colSMNo1
            // 
            this.colSMNo1.AppearanceHeader.Options.UseTextOptions = true;
            this.colSMNo1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSMNo1.FieldName = "SMNo";
            this.colSMNo1.Name = "colSMNo1";
            // 
            // colDeliveryText
            // 
            this.colDeliveryText.AppearanceCell.Options.UseTextOptions = true;
            this.colDeliveryText.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDeliveryText.AppearanceHeader.Options.UseTextOptions = true;
            this.colDeliveryText.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDeliveryText.ColumnEdit = this.repMemoDeliveryText;
            this.colDeliveryText.FieldName = "DeliveryText";
            this.colDeliveryText.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colDeliveryText.Name = "colDeliveryText";
            this.colDeliveryText.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "DeliveryText", "共计{0}条")});
            this.colDeliveryText.Visible = true;
            this.colDeliveryText.VisibleIndex = 0;
            this.colDeliveryText.Width = 120;
            // 
            // repMemoDeliveryText
            // 
            this.repMemoDeliveryText.Name = "repMemoDeliveryText";
            // 
            // colFunctionDesc1
            // 
            this.colFunctionDesc1.AppearanceHeader.Options.UseTextOptions = true;
            this.colFunctionDesc1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFunctionDesc1.FieldName = "FunctionDesc";
            this.colFunctionDesc1.Name = "colFunctionDesc1";
            // 
            // colMaterialName
            // 
            this.colMaterialName.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaterialName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaterialName.FieldName = "MaterialName";
            this.colMaterialName.Name = "colMaterialName";
            this.colMaterialName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colMaterialName.Visible = true;
            this.colMaterialName.VisibleIndex = 1;
            this.colMaterialName.Width = 100;
            // 
            // colMaterialBrand
            // 
            this.colMaterialBrand.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaterialBrand.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaterialBrand.FieldName = "MaterialBrand";
            this.colMaterialBrand.Name = "colMaterialBrand";
            this.colMaterialBrand.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colMaterialBrand.Visible = true;
            this.colMaterialBrand.VisibleIndex = 2;
            this.colMaterialBrand.Width = 80;
            // 
            // colMaterialCate
            // 
            this.colMaterialCate.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaterialCate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaterialCate.FieldName = "MaterialCate";
            this.colMaterialCate.Name = "colMaterialCate";
            this.colMaterialCate.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colMaterialCate.Visible = true;
            this.colMaterialCate.VisibleIndex = 3;
            this.colMaterialCate.Width = 60;
            // 
            // colMatUnit
            // 
            this.colMatUnit.AppearanceHeader.Options.UseTextOptions = true;
            this.colMatUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMatUnit.DisplayFormat.FormatString = "N2";
            this.colMatUnit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMatUnit.FieldName = "MatUnit";
            this.colMatUnit.Name = "colMatUnit";
            this.colMatUnit.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colMatUnit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MatUnit", "{0:N2}")});
            this.colMatUnit.Visible = true;
            this.colMatUnit.VisibleIndex = 4;
            this.colMatUnit.Width = 80;
            // 
            // colMatQty
            // 
            this.colMatQty.AppearanceHeader.Options.UseTextOptions = true;
            this.colMatQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMatQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMatQty.FieldName = "MatQty";
            this.colMatQty.Name = "colMatQty";
            this.colMatQty.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colMatQty.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MatQty", "{0:0.##}")});
            this.colMatQty.Visible = true;
            this.colMatQty.VisibleIndex = 5;
            this.colMatQty.Width = 70;
            // 
            // colMatAmount
            // 
            this.colMatAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colMatAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMatAmount.DisplayFormat.FormatString = "N2";
            this.colMatAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMatAmount.FieldName = "MatAmount";
            this.colMatAmount.Name = "colMatAmount";
            this.colMatAmount.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colMatAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MatAmount", "{0:N2}")});
            this.colMatAmount.Visible = true;
            this.colMatAmount.VisibleIndex = 6;
            this.colMatAmount.Width = 90;
            // 
            // colMaterialDesc
            // 
            this.colMaterialDesc.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaterialDesc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaterialDesc.FieldName = "MaterialDesc";
            this.colMaterialDesc.Name = "colMaterialDesc";
            this.colMaterialDesc.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colMaterialDesc.Visible = true;
            this.colMaterialDesc.VisibleIndex = 7;
            this.colMaterialDesc.Width = 200;
            // 
            // pnlDeliveryDetailToolBar
            // 
            this.pnlDeliveryDetailToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDeliveryDetailToolBar.Location = new System.Drawing.Point(0, 0);
            this.pnlDeliveryDetailToolBar.Name = "pnlDeliveryDetailToolBar";
            this.pnlDeliveryDetailToolBar.Size = new System.Drawing.Size(354, 40);
            this.pnlDeliveryDetailToolBar.TabIndex = 23;
            // 
            // splitterRight
            // 
            this.splitterRight.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.splitterRight.Location = new System.Drawing.Point(895, 68);
            this.splitterRight.Name = "splitterRight";
            this.splitterRight.Size = new System.Drawing.Size(5, 661);
            this.splitterRight.TabIndex = 20;
            this.splitterRight.TabStop = false;
            // 
            // pnlModuleList
            // 
            this.pnlModuleList.Controls.Add(this.xtraTabModuleList);
            this.pnlModuleList.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlModuleList.Location = new System.Drawing.Point(475, 68);
            this.pnlModuleList.Name = "pnlModuleList";
            this.pnlModuleList.Size = new System.Drawing.Size(420, 661);
            this.pnlModuleList.TabIndex = 4;
            // 
            // xtraTabModuleList
            // 
            this.xtraTabModuleList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabModuleList.Location = new System.Drawing.Point(2, 2);
            this.xtraTabModuleList.Name = "xtraTabModuleList";
            this.xtraTabModuleList.SelectedTabPage = this.PageModuleList;
            this.xtraTabModuleList.Size = new System.Drawing.Size(416, 657);
            this.xtraTabModuleList.TabIndex = 3;
            this.xtraTabModuleList.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.PageModuleList});
            // 
            // PageModuleList
            // 
            this.PageModuleList.Controls.Add(this.pnlModuleListGrid);
            this.PageModuleList.Controls.Add(this.pnlModuleListToolBar);
            this.PageModuleList.Name = "PageModuleList";
            this.PageModuleList.Size = new System.Drawing.Size(410, 628);
            this.PageModuleList.Text = "工位功能模块列表";
            // 
            // pnlModuleListGrid
            // 
            this.pnlModuleListGrid.Controls.Add(this.gridControlModuleList);
            this.pnlModuleListGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlModuleListGrid.Location = new System.Drawing.Point(0, 40);
            this.pnlModuleListGrid.Name = "pnlModuleListGrid";
            this.pnlModuleListGrid.Size = new System.Drawing.Size(410, 588);
            this.pnlModuleListGrid.TabIndex = 1;
            // 
            // gridControlModuleList
            // 
            this.gridControlModuleList.DataSource = this.bindingSource_StnListModule;
            this.gridControlModuleList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlModuleList.Location = new System.Drawing.Point(2, 2);
            this.gridControlModuleList.MainView = this.gridViewModuleList;
            this.gridControlModuleList.Name = "gridControlModuleList";
            this.gridControlModuleList.Size = new System.Drawing.Size(406, 584);
            this.gridControlModuleList.TabIndex = 5;
            this.gridControlModuleList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewModuleList});
            // 
            // bindingSource_StnListModule
            // 
            this.bindingSource_StnListModule.DataMember = "StnListModule";
            this.bindingSource_StnListModule.DataSource = this.dataSet_StnSummary;
            // 
            // dataSet_StnSummary
            // 
            this.dataSet_StnSummary.DataSetName = "NewDataSet";
            this.dataSet_StnSummary.Tables.AddRange(new System.Data.DataTable[] {
            this.TableStnSummary,
            this.TableStnList,
            this.TableStnListModule});
            // 
            // TableStnSummary
            // 
            this.TableStnSummary.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColuAutoId,
            this.dataColuSSNo,
            this.dataColuAutoQuotationNo,
            this.dataColuPrepared,
            this.dataColuPreparedIp,
            this.dataColuGetTime});
            this.TableStnSummary.TableName = "StnSummary";
            // 
            // dataColuAutoId
            // 
            this.dataColuAutoId.ColumnName = "AutoId";
            this.dataColuAutoId.DataType = typeof(int);
            // 
            // dataColuSSNo
            // 
            this.dataColuSSNo.Caption = "工位序号";
            this.dataColuSSNo.ColumnName = "SSNo";
            // 
            // dataColuAutoQuotationNo
            // 
            this.dataColuAutoQuotationNo.Caption = "报价单号";
            this.dataColuAutoQuotationNo.ColumnName = "AutoQuotationNo";
            // 
            // dataColuPrepared
            // 
            this.dataColuPrepared.Caption = "制单人";
            this.dataColuPrepared.ColumnName = "Prepared";
            // 
            // dataColuPreparedIp
            // 
            this.dataColuPreparedIp.Caption = "制单人IP";
            this.dataColuPreparedIp.ColumnName = "PreparedIp";
            // 
            // dataColuGetTime
            // 
            this.dataColuGetTime.Caption = "登记时间";
            this.dataColuGetTime.ColumnName = "GetTime";
            this.dataColuGetTime.DataType = typeof(System.DateTime);
            // 
            // TableStnList
            // 
            this.TableStnList.Columns.AddRange(new System.Data.DataColumn[] {
            this.dcAutoId,
            this.dcSSNoNO,
            this.dcStnNo,
            this.dcStnDesc,
            this.dcPrepared,
            this.dcPreparedIp,
            this.dcGetTime});
            this.TableStnList.TableName = "StnList";
            this.TableStnList.TableNewRow += new System.Data.DataTableNewRowEventHandler(this.TableStnList_TableNewRow);
            // 
            // dcAutoId
            // 
            this.dcAutoId.Caption = "AutoId";
            this.dcAutoId.ColumnName = "AutoId";
            this.dcAutoId.DataType = typeof(int);
            // 
            // dcSSNoNO
            // 
            this.dcSSNoNO.Caption = "工位序号";
            this.dcSSNoNO.ColumnName = "SSNo";
            // 
            // dcStnNo
            // 
            this.dcStnNo.Caption = "站号";
            this.dcStnNo.ColumnName = "StnNo";
            // 
            // dcStnDesc
            // 
            this.dcStnDesc.Caption = "站号描述";
            this.dcStnDesc.ColumnName = "StnDesc";
            // 
            // dcPrepared
            // 
            this.dcPrepared.Caption = "制单人";
            this.dcPrepared.ColumnName = "Prepared";
            // 
            // dcPreparedIp
            // 
            this.dcPreparedIp.Caption = "制单人IP";
            this.dcPreparedIp.ColumnName = "PreparedIp";
            // 
            // dcGetTime
            // 
            this.dcGetTime.Caption = "登记时间";
            this.dcGetTime.ColumnName = "GetTime";
            this.dcGetTime.DataType = typeof(System.DateTime);
            // 
            // TableStnListModule
            // 
            this.TableStnListModule.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumnAutoId,
            this.dataColumnStnSummaryListId,
            this.dataColumnSMNo,
            this.dataColFunctionDesc,
            this.dataColFunctionDetail});
            this.TableStnListModule.TableName = "StnListModule";
            // 
            // dataColumnAutoId
            // 
            this.dataColumnAutoId.ColumnName = "AutoId";
            this.dataColumnAutoId.DataType = typeof(int);
            // 
            // dataColumnStnSummaryListId
            // 
            this.dataColumnStnSummaryListId.ColumnName = "StnSummaryListId";
            this.dataColumnStnSummaryListId.DataType = typeof(int);
            // 
            // dataColumnSMNo
            // 
            this.dataColumnSMNo.Caption = "功能模块号";
            this.dataColumnSMNo.ColumnName = "SMNo";
            // 
            // dataColFunctionDesc
            // 
            this.dataColFunctionDesc.Caption = "功能简述";
            this.dataColFunctionDesc.ColumnName = "FunctionDesc";
            // 
            // dataColFunctionDetail
            // 
            this.dataColFunctionDetail.Caption = "功能详细";
            this.dataColFunctionDetail.ColumnName = "FunctionDetail";
            // 
            // gridViewModuleList
            // 
            this.gridViewModuleList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId1,
            this.colStnSummaryListId,
            this.colSMNo,
            this.colFunctionDesc,
            this.colFunctionDetail});
            this.gridViewModuleList.GridControl = this.gridControlModuleList;
            this.gridViewModuleList.IndicatorWidth = 40;
            this.gridViewModuleList.Name = "gridViewModuleList";
            this.gridViewModuleList.OptionsBehavior.Editable = false;
            this.gridViewModuleList.OptionsBehavior.ReadOnly = true;
            this.gridViewModuleList.OptionsMenu.EnableColumnMenu = false;
            this.gridViewModuleList.OptionsMenu.EnableFooterMenu = false;
            this.gridViewModuleList.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewModuleList.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewModuleList.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewModuleList.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewModuleList.OptionsSelection.MultiSelect = true;
            this.gridViewModuleList.OptionsView.ColumnAutoWidth = false;
            this.gridViewModuleList.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewModuleList.OptionsView.ShowFooter = true;
            this.gridViewModuleList.OptionsView.ShowGroupPanel = false;
            this.gridViewModuleList.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewModuleList_RowClick);
            this.gridViewModuleList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewStnList_CustomDrawRowIndicator);
            this.gridViewModuleList.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewModuleList_FocusedRowChanged);
            this.gridViewModuleList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewStnList_KeyDown);
            // 
            // colAutoId1
            // 
            this.colAutoId1.FieldName = "AutoId";
            this.colAutoId1.Name = "colAutoId1";
            // 
            // colStnSummaryListId
            // 
            this.colStnSummaryListId.FieldName = "StnSummaryListId";
            this.colStnSummaryListId.Name = "colStnSummaryListId";
            // 
            // colSMNo
            // 
            this.colSMNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colSMNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSMNo.FieldName = "SMNo";
            this.colSMNo.Name = "colSMNo";
            this.colSMNo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "SMNo", "共计{0}条")});
            this.colSMNo.Visible = true;
            this.colSMNo.VisibleIndex = 0;
            this.colSMNo.Width = 110;
            // 
            // colFunctionDesc
            // 
            this.colFunctionDesc.AppearanceHeader.Options.UseTextOptions = true;
            this.colFunctionDesc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFunctionDesc.FieldName = "FunctionDesc";
            this.colFunctionDesc.Name = "colFunctionDesc";
            this.colFunctionDesc.Visible = true;
            this.colFunctionDesc.VisibleIndex = 1;
            this.colFunctionDesc.Width = 130;
            // 
            // colFunctionDetail
            // 
            this.colFunctionDetail.AppearanceHeader.Options.UseTextOptions = true;
            this.colFunctionDetail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFunctionDetail.FieldName = "FunctionDetail";
            this.colFunctionDetail.Name = "colFunctionDetail";
            this.colFunctionDetail.Visible = true;
            this.colFunctionDetail.VisibleIndex = 2;
            this.colFunctionDetail.Width = 250;
            // 
            // pnlModuleListToolBar
            // 
            this.pnlModuleListToolBar.Controls.Add(this.btnModuleCopy);
            this.pnlModuleListToolBar.Controls.Add(this.btnModuleSelect);
            this.pnlModuleListToolBar.Controls.Add(this.btnModuleNew);
            this.pnlModuleListToolBar.Controls.Add(this.btnModuleDelete);
            this.pnlModuleListToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlModuleListToolBar.Location = new System.Drawing.Point(0, 0);
            this.pnlModuleListToolBar.Name = "pnlModuleListToolBar";
            this.pnlModuleListToolBar.Size = new System.Drawing.Size(410, 40);
            this.pnlModuleListToolBar.TabIndex = 0;
            // 
            // btnModuleCopy
            // 
            this.btnModuleCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModuleCopy.Location = new System.Drawing.Point(324, 9);
            this.btnModuleCopy.Name = "btnModuleCopy";
            this.btnModuleCopy.Size = new System.Drawing.Size(75, 23);
            this.btnModuleCopy.TabIndex = 106;
            this.btnModuleCopy.TabStop = false;
            this.btnModuleCopy.Text = "复制";
            this.btnModuleCopy.Click += new System.EventHandler(this.btnModuleCopy_Click);
            // 
            // btnModuleSelect
            // 
            this.btnModuleSelect.Location = new System.Drawing.Point(10, 9);
            this.btnModuleSelect.Name = "btnModuleSelect";
            this.btnModuleSelect.Size = new System.Drawing.Size(75, 23);
            this.btnModuleSelect.TabIndex = 52;
            this.btnModuleSelect.Text = "选择";
            this.btnModuleSelect.Click += new System.EventHandler(this.btnModuleSelect_Click);
            // 
            // btnModuleNew
            // 
            this.btnModuleNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModuleNew.Location = new System.Drawing.Point(243, 9);
            this.btnModuleNew.Name = "btnModuleNew";
            this.btnModuleNew.Size = new System.Drawing.Size(75, 23);
            this.btnModuleNew.TabIndex = 105;
            this.btnModuleNew.TabStop = false;
            this.btnModuleNew.Text = "新增";
            this.btnModuleNew.Click += new System.EventHandler(this.btnModuleNew_Click);
            // 
            // btnModuleDelete
            // 
            this.btnModuleDelete.Location = new System.Drawing.Point(91, 9);
            this.btnModuleDelete.Name = "btnModuleDelete";
            this.btnModuleDelete.Size = new System.Drawing.Size(75, 23);
            this.btnModuleDelete.TabIndex = 51;
            this.btnModuleDelete.Text = "删除";
            this.btnModuleDelete.Click += new System.EventHandler(this.btnModuleDelete_Click);
            // 
            // splitterLeft
            // 
            this.splitterLeft.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.splitterLeft.Location = new System.Drawing.Point(470, 68);
            this.splitterLeft.Name = "splitterLeft";
            this.splitterLeft.Size = new System.Drawing.Size(5, 661);
            this.splitterLeft.TabIndex = 19;
            this.splitterLeft.TabStop = false;
            // 
            // pnlStnList
            // 
            this.pnlStnList.Controls.Add(this.xtraTabStnList);
            this.pnlStnList.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlStnList.Location = new System.Drawing.Point(0, 68);
            this.pnlStnList.Name = "pnlStnList";
            this.pnlStnList.Size = new System.Drawing.Size(470, 661);
            this.pnlStnList.TabIndex = 3;
            // 
            // xtraTabStnList
            // 
            this.xtraTabStnList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabStnList.Location = new System.Drawing.Point(2, 2);
            this.xtraTabStnList.Name = "xtraTabStnList";
            this.xtraTabStnList.SelectedTabPage = this.PageStnList;
            this.xtraTabStnList.Size = new System.Drawing.Size(466, 657);
            this.xtraTabStnList.TabIndex = 2;
            this.xtraTabStnList.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.PageStnList});
            // 
            // PageStnList
            // 
            this.PageStnList.Controls.Add(this.pnlStnListGrid);
            this.PageStnList.Controls.Add(this.pnlStnListEdit);
            this.PageStnList.Controls.Add(this.pnlStnListToolBar);
            this.PageStnList.Name = "PageStnList";
            this.PageStnList.Size = new System.Drawing.Size(460, 628);
            this.PageStnList.Text = "工位信息列表";
            // 
            // pnlStnListGrid
            // 
            this.pnlStnListGrid.Controls.Add(this.gridControlStnList);
            this.pnlStnListGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStnListGrid.Location = new System.Drawing.Point(0, 86);
            this.pnlStnListGrid.Name = "pnlStnListGrid";
            this.pnlStnListGrid.Size = new System.Drawing.Size(460, 542);
            this.pnlStnListGrid.TabIndex = 2;
            // 
            // gridControlStnList
            // 
            this.gridControlStnList.DataSource = this.bindingSource_StnList;
            this.gridControlStnList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlStnList.Location = new System.Drawing.Point(2, 2);
            this.gridControlStnList.MainView = this.gridViewStnList;
            this.gridControlStnList.Name = "gridControlStnList";
            this.gridControlStnList.Size = new System.Drawing.Size(456, 538);
            this.gridControlStnList.TabIndex = 4;
            this.gridControlStnList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewStnList});
            // 
            // bindingSource_StnList
            // 
            this.bindingSource_StnList.DataMember = "StnList";
            this.bindingSource_StnList.DataSource = this.dataSet_StnSummary;
            // 
            // gridViewStnList
            // 
            this.gridViewStnList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId,
            this.colSSNo,
            this.colStnNo,
            this.colStnDesc,
            this.colPrepared,
            this.colPreparedIp,
            this.colGetTime});
            this.gridViewStnList.GridControl = this.gridControlStnList;
            this.gridViewStnList.IndicatorWidth = 40;
            this.gridViewStnList.Name = "gridViewStnList";
            this.gridViewStnList.OptionsBehavior.Editable = false;
            this.gridViewStnList.OptionsBehavior.ReadOnly = true;
            this.gridViewStnList.OptionsMenu.EnableColumnMenu = false;
            this.gridViewStnList.OptionsMenu.EnableFooterMenu = false;
            this.gridViewStnList.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewStnList.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewStnList.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewStnList.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewStnList.OptionsView.ColumnAutoWidth = false;
            this.gridViewStnList.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewStnList.OptionsView.ShowFooter = true;
            this.gridViewStnList.OptionsView.ShowGroupPanel = false;
            this.gridViewStnList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewStnList_CustomDrawRowIndicator);
            this.gridViewStnList.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewStnList_FocusedRowChanged);
            this.gridViewStnList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewStnList_KeyDown);
            // 
            // colAutoId
            // 
            this.colAutoId.FieldName = "AutoId";
            this.colAutoId.Name = "colAutoId";
            // 
            // colSSNo
            // 
            this.colSSNo.FieldName = "SSNo";
            this.colSSNo.Name = "colSSNo";
            // 
            // colStnNo
            // 
            this.colStnNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colStnNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStnNo.FieldName = "StnNo";
            this.colStnNo.Name = "colStnNo";
            this.colStnNo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "StnNo", "共计{0}条")});
            this.colStnNo.Visible = true;
            this.colStnNo.VisibleIndex = 0;
            this.colStnNo.Width = 100;
            // 
            // colStnDesc
            // 
            this.colStnDesc.AppearanceHeader.Options.UseTextOptions = true;
            this.colStnDesc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStnDesc.FieldName = "StnDesc";
            this.colStnDesc.Name = "colStnDesc";
            this.colStnDesc.Visible = true;
            this.colStnDesc.VisibleIndex = 1;
            this.colStnDesc.Width = 120;
            // 
            // colPrepared
            // 
            this.colPrepared.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrepared.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrepared.FieldName = "Prepared";
            this.colPrepared.Name = "colPrepared";
            this.colPrepared.Visible = true;
            this.colPrepared.VisibleIndex = 2;
            this.colPrepared.Width = 50;
            // 
            // colPreparedIp
            // 
            this.colPreparedIp.FieldName = "PreparedIp";
            this.colPreparedIp.Name = "colPreparedIp";
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
            this.colGetTime.VisibleIndex = 3;
            this.colGetTime.Width = 130;
            // 
            // pnlStnListEdit
            // 
            this.pnlStnListEdit.Controls.Add(this.textEditStnDesc);
            this.pnlStnListEdit.Controls.Add(this.labStnDesc);
            this.pnlStnListEdit.Controls.Add(this.textEditStnNo);
            this.pnlStnListEdit.Controls.Add(this.labStnNo);
            this.pnlStnListEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStnListEdit.Location = new System.Drawing.Point(0, 40);
            this.pnlStnListEdit.Name = "pnlStnListEdit";
            this.pnlStnListEdit.Size = new System.Drawing.Size(460, 46);
            this.pnlStnListEdit.TabIndex = 1;
            // 
            // textEditStnDesc
            // 
            this.textEditStnDesc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_StnList, "StnDesc", true));
            this.textEditStnDesc.Location = new System.Drawing.Point(266, 12);
            this.textEditStnDesc.Name = "textEditStnDesc";
            this.textEditStnDesc.Properties.MaxLength = 200;
            this.textEditStnDesc.Size = new System.Drawing.Size(180, 20);
            this.textEditStnDesc.TabIndex = 11;
            // 
            // labStnDesc
            // 
            this.labStnDesc.Location = new System.Drawing.Point(198, 15);
            this.labStnDesc.Name = "labStnDesc";
            this.labStnDesc.Size = new System.Drawing.Size(48, 14);
            this.labStnDesc.TabIndex = 8;
            this.labStnDesc.Text = "站号描述";
            // 
            // textEditStnNo
            // 
            this.textEditStnNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_StnList, "StnNo", true));
            this.textEditStnNo.EnterMoveNextControl = true;
            this.textEditStnNo.Location = new System.Drawing.Point(62, 12);
            this.textEditStnNo.Name = "textEditStnNo";
            this.textEditStnNo.Properties.MaxLength = 20;
            this.textEditStnNo.Size = new System.Drawing.Size(120, 20);
            this.textEditStnNo.TabIndex = 10;
            // 
            // labStnNo
            // 
            this.labStnNo.Location = new System.Drawing.Point(19, 15);
            this.labStnNo.Name = "labStnNo";
            this.labStnNo.Size = new System.Drawing.Size(24, 14);
            this.labStnNo.TabIndex = 6;
            this.labStnNo.Text = "站号";
            // 
            // pnlStnListToolBar
            // 
            this.pnlStnListToolBar.Controls.Add(this.btnStnListCancel);
            this.pnlStnListToolBar.Controls.Add(this.btnStnListDelete);
            this.pnlStnListToolBar.Controls.Add(this.btnStnListSave);
            this.pnlStnListToolBar.Controls.Add(this.btnStnListNew);
            this.pnlStnListToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStnListToolBar.Location = new System.Drawing.Point(0, 0);
            this.pnlStnListToolBar.Name = "pnlStnListToolBar";
            this.pnlStnListToolBar.Size = new System.Drawing.Size(460, 40);
            this.pnlStnListToolBar.TabIndex = 0;
            // 
            // btnStnListCancel
            // 
            this.btnStnListCancel.Location = new System.Drawing.Point(172, 9);
            this.btnStnListCancel.Name = "btnStnListCancel";
            this.btnStnListCancel.Size = new System.Drawing.Size(75, 23);
            this.btnStnListCancel.TabIndex = 2;
            this.btnStnListCancel.Text = "取消";
            this.btnStnListCancel.Click += new System.EventHandler(this.btnStnListCancel_Click);
            // 
            // btnStnListDelete
            // 
            this.btnStnListDelete.Location = new System.Drawing.Point(253, 9);
            this.btnStnListDelete.Name = "btnStnListDelete";
            this.btnStnListDelete.Size = new System.Drawing.Size(75, 23);
            this.btnStnListDelete.TabIndex = 3;
            this.btnStnListDelete.Text = "删除";
            this.btnStnListDelete.Click += new System.EventHandler(this.btnStnListDelete_Click);
            // 
            // btnStnListSave
            // 
            this.btnStnListSave.Location = new System.Drawing.Point(91, 9);
            this.btnStnListSave.Name = "btnStnListSave";
            this.btnStnListSave.Size = new System.Drawing.Size(75, 23);
            this.btnStnListSave.TabIndex = 1;
            this.btnStnListSave.Text = "修改";
            this.btnStnListSave.Click += new System.EventHandler(this.btnStnListSave_Click);
            // 
            // btnStnListNew
            // 
            this.btnStnListNew.Location = new System.Drawing.Point(10, 9);
            this.btnStnListNew.Name = "btnStnListNew";
            this.btnStnListNew.Size = new System.Drawing.Size(75, 23);
            this.btnStnListNew.TabIndex = 0;
            this.btnStnListNew.Text = "新增";
            this.btnStnListNew.Click += new System.EventHandler(this.btnStnListNew_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnRefresh);
            this.pnlTop.Controls.Add(this.textGetTime);
            this.pnlTop.Controls.Add(this.labGetTime);
            this.pnlTop.Controls.Add(this.labPrepared);
            this.pnlTop.Controls.Add(this.textPrepared);
            this.pnlTop.Controls.Add(this.labSSNo);
            this.pnlTop.Controls.Add(this.btnEditSSNo);
            this.pnlTop.Controls.Add(this.labAutoQuotationNo);
            this.pnlTop.Controls.Add(this.btnEditAutoQuotationNo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1264, 68);
            this.pnlTop.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(905, 20);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // textGetTime
            // 
            this.textGetTime.Location = new System.Drawing.Point(749, 21);
            this.textGetTime.Name = "textGetTime";
            this.textGetTime.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.textGetTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.textGetTime.Properties.ReadOnly = true;
            this.textGetTime.Size = new System.Drawing.Size(140, 20);
            this.textGetTime.TabIndex = 3;
            // 
            // labGetTime
            // 
            this.labGetTime.Location = new System.Drawing.Point(684, 24);
            this.labGetTime.Name = "labGetTime";
            this.labGetTime.Size = new System.Drawing.Size(48, 14);
            this.labGetTime.TabIndex = 6;
            this.labGetTime.Text = "登记时间";
            // 
            // labPrepared
            // 
            this.labPrepared.Location = new System.Drawing.Point(509, 24);
            this.labPrepared.Name = "labPrepared";
            this.labPrepared.Size = new System.Drawing.Size(36, 14);
            this.labPrepared.TabIndex = 5;
            this.labPrepared.Text = "制单人";
            // 
            // textPrepared
            // 
            this.textPrepared.Location = new System.Drawing.Point(561, 21);
            this.textPrepared.Name = "textPrepared";
            this.textPrepared.Properties.ReadOnly = true;
            this.textPrepared.Size = new System.Drawing.Size(100, 20);
            this.textPrepared.TabIndex = 2;
            // 
            // labSSNo
            // 
            this.labSSNo.Location = new System.Drawing.Point(269, 24);
            this.labSSNo.Name = "labSSNo";
            this.labSSNo.Size = new System.Drawing.Size(48, 14);
            this.labSSNo.TabIndex = 3;
            this.labSSNo.Text = "工位序号";
            // 
            // btnEditSSNo
            // 
            this.btnEditSSNo.Location = new System.Drawing.Point(333, 21);
            this.btnEditSSNo.Name = "btnEditSSNo";
            this.btnEditSSNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "查询", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.btnEditSSNo.Properties.ReadOnly = true;
            this.btnEditSSNo.Size = new System.Drawing.Size(150, 21);
            this.btnEditSSNo.TabIndex = 1;
            this.btnEditSSNo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnEditSSNo_ButtonClick);
            // 
            // labAutoQuotationNo
            // 
            this.labAutoQuotationNo.Location = new System.Drawing.Point(36, 24);
            this.labAutoQuotationNo.Name = "labAutoQuotationNo";
            this.labAutoQuotationNo.Size = new System.Drawing.Size(48, 14);
            this.labAutoQuotationNo.TabIndex = 1;
            this.labAutoQuotationNo.Text = "报价单号";
            // 
            // dockManagerRight
            // 
            this.dockManagerRight.Form = this;
            this.dockManagerRight.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane"});
            // 
            // FrmStnSummary
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.pnlLeft);
            this.Name = "FrmStnSummary";
            this.TabText = "工位信息登记";
            this.Text = "工位信息登记";
            this.Activated += new System.EventHandler(this.FrmStnSummary_Activated);
            this.Load += new System.EventHandler(this.FrmStnSummary_Load);
            this.Shown += new System.EventHandler(this.FrmStnSummary_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_DeliveryDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableDeliveryDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditAutoQuotationNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeft)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlDeliveryDetail)).EndInit();
            this.pnlDeliveryDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabControlDeliveryDetail)).EndInit();
            this.TabControlDeliveryDetail.ResumeLayout(false);
            this.PageDeliveryDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlDeliveryDetailGrid)).EndInit();
            this.pnlDeliveryDetailGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDeliveryDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_DeliveryDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDeliveryDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repMemoDeliveryText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDeliveryDetailToolBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlModuleList)).EndInit();
            this.pnlModuleList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabModuleList)).EndInit();
            this.xtraTabModuleList.ResumeLayout(false);
            this.PageModuleList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlModuleListGrid)).EndInit();
            this.pnlModuleListGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlModuleList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_StnListModule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_StnSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableStnSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableStnList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableStnListModule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewModuleList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlModuleListToolBar)).EndInit();
            this.pnlModuleListToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlStnList)).EndInit();
            this.pnlStnList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabStnList)).EndInit();
            this.xtraTabStnList.ResumeLayout(false);
            this.PageStnList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlStnListGrid)).EndInit();
            this.pnlStnListGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStnList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_StnList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStnList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlStnListEdit)).EndInit();
            this.pnlStnListEdit.ResumeLayout(false);
            this.pnlStnListEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditStnDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditStnNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlStnListToolBar)).EndInit();
            this.pnlStnListToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textGetTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPrepared.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditSSNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManagerRight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ButtonEdit btnEditAutoQuotationNo;
        private DevExpress.XtraEditors.PanelControl pnlLeft;
        private DevExpress.XtraEditors.PanelControl pnlTop;
        private DevExpress.XtraEditors.TextEdit textGetTime;
        private DevExpress.XtraEditors.LabelControl labGetTime;
        private DevExpress.XtraEditors.LabelControl labPrepared;
        private DevExpress.XtraEditors.TextEdit textPrepared;
        private DevExpress.XtraEditors.LabelControl labSSNo;
        private DevExpress.XtraEditors.ButtonEdit btnEditSSNo;
        private DevExpress.XtraEditors.LabelControl labAutoQuotationNo;
        private DevExpress.XtraEditors.PanelControl pnlModuleList;
        private DevExpress.XtraTab.XtraTabControl xtraTabModuleList;
        private DevExpress.XtraTab.XtraTabPage PageModuleList;
        private DevExpress.XtraEditors.PanelControl pnlStnList;
        private DevExpress.XtraTab.XtraTabControl xtraTabStnList;
        private DevExpress.XtraTab.XtraTabPage PageStnList;
        private DevExpress.XtraEditors.PanelControl pnlStnListToolBar;
        private DevExpress.XtraEditors.SimpleButton btnStnListNew;
        private DevExpress.XtraEditors.PanelControl pnlStnListGrid;
        private DevExpress.XtraEditors.PanelControl pnlStnListEdit;
        private DevExpress.XtraEditors.TextEdit textEditStnDesc;
        private DevExpress.XtraEditors.LabelControl labStnDesc;
        private DevExpress.XtraEditors.TextEdit textEditStnNo;
        private DevExpress.XtraEditors.LabelControl labStnNo;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnStnListCancel;
        private DevExpress.XtraEditors.SimpleButton btnStnListDelete;
        private DevExpress.XtraEditors.SimpleButton btnStnListSave;
        private System.Data.DataSet dataSet_StnSummary;
        private System.Data.DataTable TableStnSummary;
        private System.Data.DataColumn dataColuAutoId;
        private System.Data.DataColumn dataColuSSNo;
        private System.Data.DataColumn dataColuAutoQuotationNo;
        private System.Data.DataColumn dataColuPrepared;
        private System.Data.DataColumn dataColuPreparedIp;
        private System.Data.DataColumn dataColuGetTime;
        private System.Data.DataTable TableStnList;
        private System.Data.DataColumn dcAutoId;
        private System.Data.DataColumn dcSSNoNO;
        private System.Data.DataColumn dcStnNo;
        private System.Data.DataColumn dcStnDesc;
        private System.Data.DataColumn dcPrepared;
        private System.Data.DataColumn dcPreparedIp;
        private System.Data.DataColumn dcGetTime;
        private System.Windows.Forms.BindingSource bindingSource_StnList;
        private DevExpress.XtraGrid.GridControl gridControlStnList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewStnList;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colSSNo;
        private DevExpress.XtraGrid.Columns.GridColumn colStnNo;
        private DevExpress.XtraGrid.Columns.GridColumn colStnDesc;
        private DevExpress.XtraGrid.Columns.GridColumn colPrepared;
        private DevExpress.XtraGrid.Columns.GridColumn colPreparedIp;
        private DevExpress.XtraGrid.Columns.GridColumn colGetTime;
        private DevExpress.XtraEditors.SplitterControl splitterLeft;
        private DevExpress.XtraEditors.PanelControl pnlModuleListGrid;
        private DevExpress.XtraGrid.GridControl gridControlModuleList;
        private System.Windows.Forms.BindingSource bindingSource_StnListModule;
        private System.Data.DataTable TableStnListModule;
        private System.Data.DataColumn dataColumnAutoId;
        private System.Data.DataColumn dataColumnStnSummaryListId;
        private System.Data.DataColumn dataColumnSMNo;
        private System.Data.DataColumn dataColFunctionDesc;
        private System.Data.DataColumn dataColFunctionDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewModuleList;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId1;
        private DevExpress.XtraGrid.Columns.GridColumn colStnSummaryListId;
        private DevExpress.XtraGrid.Columns.GridColumn colSMNo;
        private DevExpress.XtraGrid.Columns.GridColumn colFunctionDesc;
        private DevExpress.XtraGrid.Columns.GridColumn colFunctionDetail;
        private DevExpress.XtraEditors.PanelControl pnlModuleListToolBar;
        private DevExpress.XtraBars.Docking.DockManager dockManagerRight;
        private DevExpress.XtraEditors.SimpleButton btnModuleDelete;
        private DevExpress.XtraEditors.SimpleButton btnModuleNew;
        private DevExpress.XtraEditors.SimpleButton btnModuleCopy;
        private DevExpress.XtraEditors.SimpleButton btnModuleSelect;
        private DevExpress.XtraEditors.PanelControl pnlDeliveryDetail;
        private DevExpress.XtraEditors.SplitterControl splitterRight;
        private DevExpress.XtraTab.XtraTabControl TabControlDeliveryDetail;
        private DevExpress.XtraTab.XtraTabPage PageDeliveryDetail;
        private System.Data.DataSet dataSet_DeliveryDetail;
        private System.Data.DataTable TableDeliveryDetail;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColuSMNo;
        private System.Data.DataColumn dataColuDeliveryText;
        private System.Data.DataColumn dataColuFunctionDesc;
        private System.Data.DataColumn dataColuMatQty;
        private System.Data.DataColumn dataColuMatUnit;
        private System.Data.DataColumn dataColuMatAmount;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private DevExpress.XtraEditors.PanelControl pnlDeliveryDetailGrid;
        private DevExpress.XtraEditors.PanelControl pnlDeliveryDetailToolBar;
        private System.Windows.Forms.BindingSource bindingSource_DeliveryDetail;
        private DevExpress.XtraGrid.GridControl gridControlDeliveryDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDeliveryDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colSMNo1;
        private DevExpress.XtraGrid.Columns.GridColumn colDeliveryText;
        private DevExpress.XtraGrid.Columns.GridColumn colFunctionDesc1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialName;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialBrand;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialCate;
        private DevExpress.XtraGrid.Columns.GridColumn colMatUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colMatQty;
        private DevExpress.XtraGrid.Columns.GridColumn colMatAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialDesc;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repMemoDeliveryText;
    }
}