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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStnSummary));
            this.btnEditAutoQuotationNo = new DevExpress.XtraEditors.ButtonEdit();
            this.pnlLeft = new DevExpress.XtraEditors.PanelControl();
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
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemSpinEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.pnlModuleListToolBar = new DevExpress.XtraEditors.PanelControl();
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
            this.repSpinQty = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repbtnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repLookUpCurrencyCate = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repDateQuotationDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repSpinEditAmount = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
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
            this.dockPnlRight = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.treeListStnModule = new DevExpress.XtraTreeList.TreeList();
            this.treeColFunctionDesc = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeColDetail = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.pnlRightToolBar = new DevExpress.XtraEditors.PanelControl();
            this.btnModuleCopy = new DevExpress.XtraEditors.SimpleButton();
            this.btnModuleNew = new DevExpress.XtraEditors.SimpleButton();
            this.pnlRightTop = new DevExpress.XtraEditors.PanelControl();
            this.btnModuleQuery = new DevExpress.XtraEditors.SimpleButton();
            this.textCommon = new DevExpress.XtraEditors.TextEdit();
            this.labCommon = new DevExpress.XtraEditors.LabelControl();
            this.dateGetTimeEnd = new DevExpress.XtraEditors.DateEdit();
            this.dateGetTimeBegin = new DevExpress.XtraEditors.DateEdit();
            this.lab1 = new DevExpress.XtraEditors.LabelControl();
            this.labelGetTime = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditAutoQuotationNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeft)).BeginInit();
            this.pnlLeft.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.repSpinQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repbtnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpCurrencyCate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateQuotationDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateQuotationDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinEditAmount)).BeginInit();
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
            this.dockPnlRight.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListStnModule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRightToolBar)).BeginInit();
            this.pnlRightToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRightTop)).BeginInit();
            this.pnlRightTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textCommon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGetTimeEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGetTimeEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGetTimeBegin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGetTimeBegin.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.pnlLeft.Controls.Add(this.pnlModuleList);
            this.pnlLeft.Controls.Add(this.splitterLeft);
            this.pnlLeft.Controls.Add(this.pnlStnList);
            this.pnlLeft.Controls.Add(this.pnlTop);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(973, 729);
            this.pnlLeft.TabIndex = 1;
            // 
            // pnlModuleList
            // 
            this.pnlModuleList.Controls.Add(this.xtraTabModuleList);
            this.pnlModuleList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlModuleList.Location = new System.Drawing.Point(480, 68);
            this.pnlModuleList.Name = "pnlModuleList";
            this.pnlModuleList.Size = new System.Drawing.Size(493, 661);
            this.pnlModuleList.TabIndex = 4;
            // 
            // xtraTabModuleList
            // 
            this.xtraTabModuleList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabModuleList.Location = new System.Drawing.Point(2, 2);
            this.xtraTabModuleList.Name = "xtraTabModuleList";
            this.xtraTabModuleList.SelectedTabPage = this.PageModuleList;
            this.xtraTabModuleList.Size = new System.Drawing.Size(489, 657);
            this.xtraTabModuleList.TabIndex = 3;
            this.xtraTabModuleList.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.PageModuleList});
            // 
            // PageModuleList
            // 
            this.PageModuleList.Controls.Add(this.pnlModuleListGrid);
            this.PageModuleList.Controls.Add(this.pnlModuleListToolBar);
            this.PageModuleList.Name = "PageModuleList";
            this.PageModuleList.Size = new System.Drawing.Size(483, 628);
            this.PageModuleList.Text = "工位功能模块列表";
            // 
            // pnlModuleListGrid
            // 
            this.pnlModuleListGrid.Controls.Add(this.gridControlModuleList);
            this.pnlModuleListGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlModuleListGrid.Location = new System.Drawing.Point(0, 40);
            this.pnlModuleListGrid.Name = "pnlModuleListGrid";
            this.pnlModuleListGrid.Size = new System.Drawing.Size(483, 588);
            this.pnlModuleListGrid.TabIndex = 1;
            // 
            // gridControlModuleList
            // 
            this.gridControlModuleList.AllowDrop = true;
            this.gridControlModuleList.DataSource = this.bindingSource_StnListModule;
            this.gridControlModuleList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlModuleList.Location = new System.Drawing.Point(2, 2);
            this.gridControlModuleList.MainView = this.gridViewModuleList;
            this.gridControlModuleList.Name = "gridControlModuleList";
            this.gridControlModuleList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1,
            this.repositoryItemButtonEdit1,
            this.repositoryItemLookUpEdit1,
            this.repositoryItemDateEdit1,
            this.repositoryItemSpinEdit2});
            this.gridControlModuleList.Size = new System.Drawing.Size(479, 584);
            this.gridControlModuleList.TabIndex = 5;
            this.gridControlModuleList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewModuleList});
            this.gridControlModuleList.DragDrop += new System.Windows.Forms.DragEventHandler(this.gridControlModuleList_DragDrop);
            this.gridControlModuleList.DragEnter += new System.Windows.Forms.DragEventHandler(this.gridControlModuleList_DragEnter);
            this.gridControlModuleList.DragOver += new System.Windows.Forms.DragEventHandler(this.gridControlModuleList_DragOver);
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
            this.gridViewModuleList.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewModuleList.OptionsBehavior.Editable = false;
            this.gridViewModuleList.OptionsBehavior.ReadOnly = true;
            this.gridViewModuleList.OptionsMenu.EnableColumnMenu = false;
            this.gridViewModuleList.OptionsMenu.EnableFooterMenu = false;
            this.gridViewModuleList.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewModuleList.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewModuleList.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewModuleList.OptionsView.ColumnAutoWidth = false;
            this.gridViewModuleList.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewModuleList.OptionsView.ShowFooter = true;
            this.gridViewModuleList.OptionsView.ShowGroupPanel = false;
            this.gridViewModuleList.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewModuleList_RowClick);
            this.gridViewModuleList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewStnList_CustomDrawRowIndicator);
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
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit1.MaxValue = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AutoId", "AutoId", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CurrencyCateAbb", "币种缩写"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CurrencyCateName", "币种名称"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ExchangeRate", "汇率")});
            this.repositoryItemLookUpEdit1.DisplayMember = "CurrencyCateName";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            this.repositoryItemLookUpEdit1.ValueMember = "AutoId";
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.repositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.repositoryItemDateEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.Mask.EditMask = "G";
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // repositoryItemSpinEdit2
            // 
            this.repositoryItemSpinEdit2.AutoHeight = false;
            this.repositoryItemSpinEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit2.DisplayFormat.FormatString = "N2";
            this.repositoryItemSpinEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit2.EditFormat.FormatString = "N2";
            this.repositoryItemSpinEdit2.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit2.Mask.EditMask = "N2";
            this.repositoryItemSpinEdit2.MaxValue = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2";
            // 
            // pnlModuleListToolBar
            // 
            this.pnlModuleListToolBar.Controls.Add(this.btnModuleDelete);
            this.pnlModuleListToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlModuleListToolBar.Location = new System.Drawing.Point(0, 0);
            this.pnlModuleListToolBar.Name = "pnlModuleListToolBar";
            this.pnlModuleListToolBar.Size = new System.Drawing.Size(483, 40);
            this.pnlModuleListToolBar.TabIndex = 0;
            // 
            // btnModuleDelete
            // 
            this.btnModuleDelete.Location = new System.Drawing.Point(10, 9);
            this.btnModuleDelete.Name = "btnModuleDelete";
            this.btnModuleDelete.Size = new System.Drawing.Size(75, 23);
            this.btnModuleDelete.TabIndex = 51;
            this.btnModuleDelete.Text = "删除";
            this.btnModuleDelete.Click += new System.EventHandler(this.btnModuleDelete_Click);
            // 
            // splitterLeft
            // 
            this.splitterLeft.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.splitterLeft.Location = new System.Drawing.Point(475, 68);
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
            this.pnlStnList.Size = new System.Drawing.Size(475, 661);
            this.pnlStnList.TabIndex = 3;
            // 
            // xtraTabStnList
            // 
            this.xtraTabStnList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabStnList.Location = new System.Drawing.Point(2, 2);
            this.xtraTabStnList.Name = "xtraTabStnList";
            this.xtraTabStnList.SelectedTabPage = this.PageStnList;
            this.xtraTabStnList.Size = new System.Drawing.Size(471, 657);
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
            this.PageStnList.Size = new System.Drawing.Size(465, 628);
            this.PageStnList.Text = "工位信息列表";
            // 
            // pnlStnListGrid
            // 
            this.pnlStnListGrid.Controls.Add(this.gridControlStnList);
            this.pnlStnListGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStnListGrid.Location = new System.Drawing.Point(0, 86);
            this.pnlStnListGrid.Name = "pnlStnListGrid";
            this.pnlStnListGrid.Size = new System.Drawing.Size(465, 542);
            this.pnlStnListGrid.TabIndex = 2;
            // 
            // gridControlStnList
            // 
            this.gridControlStnList.DataSource = this.bindingSource_StnList;
            this.gridControlStnList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlStnList.Location = new System.Drawing.Point(2, 2);
            this.gridControlStnList.MainView = this.gridViewStnList;
            this.gridControlStnList.Name = "gridControlStnList";
            this.gridControlStnList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repSpinQty,
            this.repbtnDelete,
            this.repLookUpCurrencyCate,
            this.repDateQuotationDate,
            this.repSpinEditAmount});
            this.gridControlStnList.Size = new System.Drawing.Size(461, 538);
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
            this.gridViewStnList.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewStnList.OptionsBehavior.Editable = false;
            this.gridViewStnList.OptionsBehavior.ReadOnly = true;
            this.gridViewStnList.OptionsMenu.EnableColumnMenu = false;
            this.gridViewStnList.OptionsMenu.EnableFooterMenu = false;
            this.gridViewStnList.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewStnList.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewStnList.OptionsNavigation.EnterMoveNextColumn = true;
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
            // repSpinQty
            // 
            this.repSpinQty.AutoHeight = false;
            this.repSpinQty.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repSpinQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repSpinQty.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repSpinQty.MaxValue = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.repSpinQty.Name = "repSpinQty";
            // 
            // repbtnDelete
            // 
            this.repbtnDelete.AutoHeight = false;
            this.repbtnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.repbtnDelete.Name = "repbtnDelete";
            this.repbtnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // repLookUpCurrencyCate
            // 
            this.repLookUpCurrencyCate.AutoHeight = false;
            this.repLookUpCurrencyCate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpCurrencyCate.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AutoId", "AutoId", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CurrencyCateAbb", "币种缩写"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CurrencyCateName", "币种名称"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ExchangeRate", "汇率")});
            this.repLookUpCurrencyCate.DisplayMember = "CurrencyCateName";
            this.repLookUpCurrencyCate.Name = "repLookUpCurrencyCate";
            this.repLookUpCurrencyCate.NullText = "";
            this.repLookUpCurrencyCate.ValueMember = "AutoId";
            // 
            // repDateQuotationDate
            // 
            this.repDateQuotationDate.AutoHeight = false;
            this.repDateQuotationDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repDateQuotationDate.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repDateQuotationDate.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.repDateQuotationDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repDateQuotationDate.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.repDateQuotationDate.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repDateQuotationDate.Mask.EditMask = "G";
            this.repDateQuotationDate.Name = "repDateQuotationDate";
            // 
            // repSpinEditAmount
            // 
            this.repSpinEditAmount.AutoHeight = false;
            this.repSpinEditAmount.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repSpinEditAmount.DisplayFormat.FormatString = "N2";
            this.repSpinEditAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repSpinEditAmount.EditFormat.FormatString = "N2";
            this.repSpinEditAmount.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repSpinEditAmount.Mask.EditMask = "N2";
            this.repSpinEditAmount.MaxValue = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.repSpinEditAmount.Name = "repSpinEditAmount";
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
            this.pnlStnListEdit.Size = new System.Drawing.Size(465, 46);
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
            this.pnlStnListToolBar.Size = new System.Drawing.Size(465, 40);
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
            this.pnlTop.Size = new System.Drawing.Size(973, 68);
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
            this.dockManagerRight.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPnlRight});
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
            // dockPnlRight
            // 
            this.dockPnlRight.Controls.Add(this.dockPanel1_Container);
            this.dockPnlRight.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.dockPnlRight.ID = new System.Guid("c120855e-ccb7-4c11-a2ad-84ddcf3588fe");
            this.dockPnlRight.Image = ((System.Drawing.Image)(resources.GetObject("dockPnlRight.Image")));
            this.dockPnlRight.Location = new System.Drawing.Point(973, 0);
            this.dockPnlRight.Name = "dockPnlRight";
            this.dockPnlRight.Options.AllowDockAsTabbedDocument = false;
            this.dockPnlRight.Options.AllowDockBottom = false;
            this.dockPnlRight.Options.AllowDockFill = false;
            this.dockPnlRight.Options.AllowDockLeft = false;
            this.dockPnlRight.Options.AllowDockTop = false;
            this.dockPnlRight.Options.AllowFloating = false;
            this.dockPnlRight.Options.FloatOnDblClick = false;
            this.dockPnlRight.Options.ShowCloseButton = false;
            this.dockPnlRight.Options.ShowMaximizeButton = false;
            this.dockPnlRight.OriginalSize = new System.Drawing.Size(400, 200);
            this.dockPnlRight.Size = new System.Drawing.Size(400, 729);
            this.dockPnlRight.Text = "基础功能模块列表";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.treeListStnModule);
            this.dockPanel1_Container.Controls.Add(this.pnlRightToolBar);
            this.dockPanel1_Container.Controls.Add(this.pnlRightTop);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(392, 702);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // treeListStnModule
            // 
            this.treeListStnModule.AllowDrop = true;
            this.treeListStnModule.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeColFunctionDesc,
            this.treeColDetail});
            this.treeListStnModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListStnModule.IndicatorWidth = 40;
            this.treeListStnModule.KeyFieldName = "ReID";
            this.treeListStnModule.Location = new System.Drawing.Point(0, 116);
            this.treeListStnModule.Name = "treeListStnModule";
            this.treeListStnModule.OptionsBehavior.Editable = false;
            this.treeListStnModule.OptionsBehavior.ReadOnly = true;
            this.treeListStnModule.OptionsClipboard.AllowCopy = DevExpress.Utils.DefaultBoolean.True;
            this.treeListStnModule.OptionsClipboard.CopyNodeHierarchy = DevExpress.Utils.DefaultBoolean.True;
            this.treeListStnModule.OptionsSelection.MultiSelect = true;
            this.treeListStnModule.OptionsSelection.UseIndicatorForSelection = true;
            this.treeListStnModule.OptionsView.AutoWidth = false;
            this.treeListStnModule.OptionsView.EnableAppearanceEvenRow = true;
            this.treeListStnModule.OptionsView.EnableAppearanceOddRow = true;
            this.treeListStnModule.ParentFieldName = "ReParent";
            this.treeListStnModule.Size = new System.Drawing.Size(392, 586);
            this.treeListStnModule.TabIndex = 2;
            this.treeListStnModule.CustomDrawNodeIndicator += new DevExpress.XtraTreeList.CustomDrawNodeIndicatorEventHandler(this.treeListStnModule_CustomDrawNodeIndicator);
            this.treeListStnModule.DoubleClick += new System.EventHandler(this.treeListStnModule_DoubleClick);
            this.treeListStnModule.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeListStnModule_KeyDown);
            this.treeListStnModule.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeListStnModule_MouseDown);
            this.treeListStnModule.MouseMove += new System.Windows.Forms.MouseEventHandler(this.treeListStnModule_MouseMove);
            // 
            // treeColFunctionDesc
            // 
            this.treeColFunctionDesc.AppearanceHeader.Options.UseTextOptions = true;
            this.treeColFunctionDesc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeColFunctionDesc.Caption = "功能模块号 - 功能简述 / 供货内容";
            this.treeColFunctionDesc.FieldName = "FunctionDesc";
            this.treeColFunctionDesc.Name = "treeColFunctionDesc";
            this.treeColFunctionDesc.Visible = true;
            this.treeColFunctionDesc.VisibleIndex = 0;
            this.treeColFunctionDesc.Width = 250;
            // 
            // treeColDetail
            // 
            this.treeColDetail.AppearanceHeader.Options.UseTextOptions = true;
            this.treeColDetail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeColDetail.Caption = "供货数量 * 单价 = 金额";
            this.treeColDetail.FieldName = "Detail";
            this.treeColDetail.Name = "treeColDetail";
            this.treeColDetail.Visible = true;
            this.treeColDetail.VisibleIndex = 1;
            this.treeColDetail.Width = 200;
            // 
            // pnlRightToolBar
            // 
            this.pnlRightToolBar.Controls.Add(this.btnModuleCopy);
            this.pnlRightToolBar.Controls.Add(this.btnModuleNew);
            this.pnlRightToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRightToolBar.Location = new System.Drawing.Point(0, 76);
            this.pnlRightToolBar.Name = "pnlRightToolBar";
            this.pnlRightToolBar.Size = new System.Drawing.Size(392, 40);
            this.pnlRightToolBar.TabIndex = 3;
            // 
            // btnModuleCopy
            // 
            this.btnModuleCopy.Location = new System.Drawing.Point(91, 9);
            this.btnModuleCopy.Name = "btnModuleCopy";
            this.btnModuleCopy.Size = new System.Drawing.Size(75, 23);
            this.btnModuleCopy.TabIndex = 106;
            this.btnModuleCopy.TabStop = false;
            this.btnModuleCopy.Text = "复制";
            this.btnModuleCopy.Click += new System.EventHandler(this.btnModuleCopy_Click);
            // 
            // btnModuleNew
            // 
            this.btnModuleNew.Location = new System.Drawing.Point(10, 9);
            this.btnModuleNew.Name = "btnModuleNew";
            this.btnModuleNew.Size = new System.Drawing.Size(75, 23);
            this.btnModuleNew.TabIndex = 105;
            this.btnModuleNew.TabStop = false;
            this.btnModuleNew.Text = "新增";
            this.btnModuleNew.Click += new System.EventHandler(this.btnModuleNew_Click);
            // 
            // pnlRightTop
            // 
            this.pnlRightTop.Controls.Add(this.btnModuleQuery);
            this.pnlRightTop.Controls.Add(this.textCommon);
            this.pnlRightTop.Controls.Add(this.labCommon);
            this.pnlRightTop.Controls.Add(this.dateGetTimeEnd);
            this.pnlRightTop.Controls.Add(this.dateGetTimeBegin);
            this.pnlRightTop.Controls.Add(this.lab1);
            this.pnlRightTop.Controls.Add(this.labelGetTime);
            this.pnlRightTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRightTop.Location = new System.Drawing.Point(0, 0);
            this.pnlRightTop.Name = "pnlRightTop";
            this.pnlRightTop.Size = new System.Drawing.Size(392, 76);
            this.pnlRightTop.TabIndex = 1;
            // 
            // btnModuleQuery
            // 
            this.btnModuleQuery.Location = new System.Drawing.Point(255, 43);
            this.btnModuleQuery.Name = "btnModuleQuery";
            this.btnModuleQuery.Size = new System.Drawing.Size(75, 23);
            this.btnModuleQuery.TabIndex = 104;
            this.btnModuleQuery.Text = "查询";
            this.btnModuleQuery.Click += new System.EventHandler(this.btnModuleQuery_Click);
            // 
            // textCommon
            // 
            this.textCommon.EnterMoveNextControl = true;
            this.textCommon.Location = new System.Drawing.Point(86, 44);
            this.textCommon.Name = "textCommon";
            this.textCommon.Size = new System.Drawing.Size(150, 20);
            this.textCommon.TabIndex = 103;
            // 
            // labCommon
            // 
            this.labCommon.Location = new System.Drawing.Point(20, 47);
            this.labCommon.Name = "labCommon";
            this.labCommon.Size = new System.Drawing.Size(60, 14);
            this.labCommon.TabIndex = 108;
            this.labCommon.Text = "通用查询：";
            // 
            // dateGetTimeEnd
            // 
            this.dateGetTimeEnd.EditValue = null;
            this.dateGetTimeEnd.EnterMoveNextControl = true;
            this.dateGetTimeEnd.Location = new System.Drawing.Point(202, 14);
            this.dateGetTimeEnd.Name = "dateGetTimeEnd";
            this.dateGetTimeEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateGetTimeEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateGetTimeEnd.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dateGetTimeEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateGetTimeEnd.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateGetTimeEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateGetTimeEnd.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateGetTimeEnd.Size = new System.Drawing.Size(100, 20);
            this.dateGetTimeEnd.TabIndex = 102;
            // 
            // dateGetTimeBegin
            // 
            this.dateGetTimeBegin.EditValue = null;
            this.dateGetTimeBegin.EnterMoveNextControl = true;
            this.dateGetTimeBegin.Location = new System.Drawing.Point(86, 14);
            this.dateGetTimeBegin.Name = "dateGetTimeBegin";
            this.dateGetTimeBegin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateGetTimeBegin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateGetTimeBegin.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dateGetTimeBegin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateGetTimeBegin.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateGetTimeBegin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateGetTimeBegin.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateGetTimeBegin.Size = new System.Drawing.Size(100, 20);
            this.dateGetTimeBegin.TabIndex = 101;
            // 
            // lab1
            // 
            this.lab1.Location = new System.Drawing.Point(192, 17);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(4, 14);
            this.lab1.TabIndex = 107;
            this.lab1.Text = "-";
            // 
            // labelGetTime
            // 
            this.labelGetTime.Location = new System.Drawing.Point(20, 17);
            this.labelGetTime.Name = "labelGetTime";
            this.labelGetTime.Size = new System.Drawing.Size(60, 14);
            this.labelGetTime.TabIndex = 106;
            this.labelGetTime.Text = "登记日期：";
            // 
            // FrmStnSummary
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1373, 729);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.dockPnlRight);
            this.Name = "FrmStnSummary";
            this.TabText = "工位信息登记";
            this.Text = "工位信息登记";
            this.Activated += new System.EventHandler(this.FrmStnSummary_Activated);
            this.Load += new System.EventHandler(this.FrmStnSummary_Load);
            this.Shown += new System.EventHandler(this.FrmStnSummary_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.btnEditAutoQuotationNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeft)).EndInit();
            this.pnlLeft.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.repSpinQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repbtnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpCurrencyCate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateQuotationDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateQuotationDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinEditAmount)).EndInit();
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
            this.dockPnlRight.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListStnModule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRightToolBar)).EndInit();
            this.pnlRightToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlRightTop)).EndInit();
            this.pnlRightTop.ResumeLayout(false);
            this.pnlRightTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textCommon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGetTimeEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGetTimeEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGetTimeBegin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGetTimeBegin.Properties)).EndInit();
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
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repSpinQty;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repbtnDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpCurrencyCate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repDateQuotationDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repSpinEditAmount;
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
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit2;
        private DevExpress.XtraEditors.PanelControl pnlModuleListToolBar;
        private DevExpress.XtraBars.Docking.DockManager dockManagerRight;
        private DevExpress.XtraBars.Docking.DockPanel dockPnlRight;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraEditors.PanelControl pnlRightTop;
        private DevExpress.XtraEditors.SimpleButton btnModuleQuery;
        private DevExpress.XtraEditors.TextEdit textCommon;
        private DevExpress.XtraEditors.LabelControl labCommon;
        private DevExpress.XtraEditors.DateEdit dateGetTimeEnd;
        private DevExpress.XtraEditors.DateEdit dateGetTimeBegin;
        private DevExpress.XtraEditors.LabelControl lab1;
        private DevExpress.XtraEditors.LabelControl labelGetTime;
        private DevExpress.XtraTreeList.TreeList treeListStnModule;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeColFunctionDesc;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeColDetail;
        private DevExpress.XtraEditors.SimpleButton btnModuleDelete;
        private DevExpress.XtraEditors.SimpleButton btnModuleNew;
        private DevExpress.XtraEditors.SimpleButton btnModuleCopy;
        private DevExpress.XtraEditors.PanelControl pnlRightToolBar;
    }
}