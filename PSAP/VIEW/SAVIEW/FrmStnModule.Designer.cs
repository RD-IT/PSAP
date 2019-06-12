namespace PSAP.VIEW.BSVIEW
{
    partial class FrmStnModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStnModule));
            this.dataSet_StnModule = new System.Data.DataSet();
            this.TableStnModule = new System.Data.DataTable();
            this.dataColAutoId = new System.Data.DataColumn();
            this.dataColSMNo = new System.Data.DataColumn();
            this.dataColFunctionDesc = new System.Data.DataColumn();
            this.dataColFunctionDetail = new System.Data.DataColumn();
            this.dataColPrepared = new System.Data.DataColumn();
            this.dataColPreparedIp = new System.Data.DataColumn();
            this.dataColGetTime = new System.Data.DataColumn();
            this.dockManagerLeft = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPnlLeft = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.pnlLeftGrid = new DevExpress.XtraEditors.PanelControl();
            this.gridControlStnModule = new DevExpress.XtraGrid.GridControl();
            this.bindingSource_StnModule = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewStnModule = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSMNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFunctionDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFunctionDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrepared = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPreparedIp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGetTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlLeftTop = new DevExpress.XtraEditors.PanelControl();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.textCommon = new DevExpress.XtraEditors.TextEdit();
            this.labCommon = new DevExpress.XtraEditors.LabelControl();
            this.dateGetTimeEnd = new DevExpress.XtraEditors.DateEdit();
            this.dateGetTimeBegin = new DevExpress.XtraEditors.DateEdit();
            this.lab1 = new DevExpress.XtraEditors.LabelControl();
            this.labelGetTime = new DevExpress.XtraEditors.LabelControl();
            this.pnlRight = new DevExpress.XtraEditors.PanelControl();
            this.xtraTabBottom = new DevExpress.XtraTab.XtraTabControl();
            this.PageDeliveryDetail = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlDeliveryDetail = new DevExpress.XtraGrid.GridControl();
            this.bindingSource_DeliveryDetail = new System.Windows.Forms.BindingSource(this.components);
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
            this.dataColuAutoId = new System.Data.DataColumn();
            this.dataColuUnit = new System.Data.DataColumn();
            this.dataColuAmount = new System.Data.DataColumn();
            this.dataColuDeliveryQty = new System.Data.DataColumn();
            this.dataColuPrepared = new System.Data.DataColumn();
            this.gridViewDeliveryDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSMNo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeliveryText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repMemoDeliveryText = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colFunctionDesc1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeliveryQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrepared1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterialName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterialBrand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterialCate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterialDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAutoId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlBottomToolBar = new DevExpress.XtraEditors.PanelControl();
            this.btnSaveExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnDDDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnDDSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnDDNew = new DevExpress.XtraEditors.SimpleButton();
            this.pnlEdit = new DevExpress.XtraEditors.PanelControl();
            this.textPrepared = new DevExpress.XtraEditors.TextEdit();
            this.dateGetTime = new DevExpress.XtraEditors.DateEdit();
            this.labGetTime = new DevExpress.XtraEditors.LabelControl();
            this.labPrepared = new DevExpress.XtraEditors.LabelControl();
            this.memoFunctionDetail = new DevExpress.XtraEditors.MemoEdit();
            this.labFunctionDetail = new DevExpress.XtraEditors.LabelControl();
            this.textFunctionDesc = new DevExpress.XtraEditors.TextEdit();
            this.labFunctionDesc = new DevExpress.XtraEditors.LabelControl();
            this.textSMNo = new DevExpress.XtraEditors.TextEdit();
            this.labSMNo = new DevExpress.XtraEditors.LabelControl();
            this.pnlToolBar = new DevExpress.XtraEditors.PanelControl();
            this.btnCopy = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_StnModule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableStnModule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManagerLeft)).BeginInit();
            this.dockPnlLeft.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeftGrid)).BeginInit();
            this.pnlLeftGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStnModule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_StnModule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStnModule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeftTop)).BeginInit();
            this.pnlLeftTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textCommon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGetTimeEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGetTimeEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGetTimeBegin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGetTimeBegin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).BeginInit();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabBottom)).BeginInit();
            this.xtraTabBottom.SuspendLayout();
            this.PageDeliveryDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDeliveryDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_DeliveryDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_DeliveryDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableDeliveryDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDeliveryDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repMemoDeliveryText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottomToolBar)).BeginInit();
            this.pnlBottomToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).BeginInit();
            this.pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textPrepared.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGetTime.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGetTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoFunctionDetail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textFunctionDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSMNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).BeginInit();
            this.pnlToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet_StnModule
            // 
            this.dataSet_StnModule.DataSetName = "NewDataSet";
            this.dataSet_StnModule.Tables.AddRange(new System.Data.DataTable[] {
            this.TableStnModule});
            // 
            // TableStnModule
            // 
            this.TableStnModule.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColAutoId,
            this.dataColSMNo,
            this.dataColFunctionDesc,
            this.dataColFunctionDetail,
            this.dataColPrepared,
            this.dataColPreparedIp,
            this.dataColGetTime});
            this.TableStnModule.TableName = "StnModule";
            this.TableStnModule.TableNewRow += new System.Data.DataTableNewRowEventHandler(this.TableStnModule_TableNewRow);
            // 
            // dataColAutoId
            // 
            this.dataColAutoId.ColumnName = "AutoId";
            this.dataColAutoId.DataType = typeof(int);
            // 
            // dataColSMNo
            // 
            this.dataColSMNo.Caption = "模块序号";
            this.dataColSMNo.ColumnName = "SMNo";
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
            // dockManagerLeft
            // 
            this.dockManagerLeft.Form = this;
            this.dockManagerLeft.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPnlLeft});
            this.dockManagerLeft.TopZIndexControls.AddRange(new string[] {
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
            // dockPnlLeft
            // 
            this.dockPnlLeft.Controls.Add(this.dockPanel1_Container);
            this.dockPnlLeft.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPnlLeft.ID = new System.Guid("9d0e73d2-08d3-4b8e-bdad-e6e2e00cd259");
            this.dockPnlLeft.Image = ((System.Drawing.Image)(resources.GetObject("dockPnlLeft.Image")));
            this.dockPnlLeft.Location = new System.Drawing.Point(0, 0);
            this.dockPnlLeft.Name = "dockPnlLeft";
            this.dockPnlLeft.Options.AllowDockAsTabbedDocument = false;
            this.dockPnlLeft.Options.AllowDockBottom = false;
            this.dockPnlLeft.Options.AllowDockFill = false;
            this.dockPnlLeft.Options.AllowDockRight = false;
            this.dockPnlLeft.Options.AllowDockTop = false;
            this.dockPnlLeft.Options.AllowFloating = false;
            this.dockPnlLeft.Options.FloatOnDblClick = false;
            this.dockPnlLeft.Options.ShowCloseButton = false;
            this.dockPnlLeft.Options.ShowMaximizeButton = false;
            this.dockPnlLeft.OriginalSize = new System.Drawing.Size(350, 200);
            this.dockPnlLeft.Size = new System.Drawing.Size(350, 729);
            this.dockPnlLeft.Text = "功能模块列表";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.pnlLeftGrid);
            this.dockPanel1_Container.Controls.Add(this.pnlLeftTop);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(342, 702);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // pnlLeftGrid
            // 
            this.pnlLeftGrid.Controls.Add(this.gridControlStnModule);
            this.pnlLeftGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeftGrid.Location = new System.Drawing.Point(0, 76);
            this.pnlLeftGrid.Name = "pnlLeftGrid";
            this.pnlLeftGrid.Size = new System.Drawing.Size(342, 626);
            this.pnlLeftGrid.TabIndex = 7;
            // 
            // gridControlStnModule
            // 
            this.gridControlStnModule.DataSource = this.bindingSource_StnModule;
            this.gridControlStnModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlStnModule.Location = new System.Drawing.Point(2, 2);
            this.gridControlStnModule.MainView = this.gridViewStnModule;
            this.gridControlStnModule.Name = "gridControlStnModule";
            this.gridControlStnModule.Size = new System.Drawing.Size(338, 622);
            this.gridControlStnModule.TabIndex = 6;
            this.gridControlStnModule.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewStnModule});
            // 
            // bindingSource_StnModule
            // 
            this.bindingSource_StnModule.DataMember = "StnModule";
            this.bindingSource_StnModule.DataSource = this.dataSet_StnModule;
            // 
            // gridViewStnModule
            // 
            this.gridViewStnModule.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId,
            this.colSMNo,
            this.colFunctionDesc,
            this.colFunctionDetail,
            this.colPrepared,
            this.colPreparedIp,
            this.colGetTime});
            this.gridViewStnModule.GridControl = this.gridControlStnModule;
            this.gridViewStnModule.IndicatorWidth = 40;
            this.gridViewStnModule.Name = "gridViewStnModule";
            this.gridViewStnModule.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewStnModule.OptionsBehavior.Editable = false;
            this.gridViewStnModule.OptionsBehavior.ReadOnly = true;
            this.gridViewStnModule.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewStnModule.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewStnModule.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewStnModule.OptionsSelection.MultiSelect = true;
            this.gridViewStnModule.OptionsView.ColumnAutoWidth = false;
            this.gridViewStnModule.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewStnModule.OptionsView.ShowFooter = true;
            this.gridViewStnModule.OptionsView.ShowGroupPanel = false;
            this.gridViewStnModule.OptionsView.ShowIndicator = false;
            this.gridViewStnModule.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewStnModule_FocusedRowChanged);
            this.gridViewStnModule.BeforeLeaveRow += new DevExpress.XtraGrid.Views.Base.RowAllowEventHandler(this.gridViewStnModule_BeforeLeaveRow);
            // 
            // colAutoId
            // 
            this.colAutoId.FieldName = "AutoId";
            this.colAutoId.Name = "colAutoId";
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
            this.colFunctionDesc.Width = 160;
            // 
            // colFunctionDetail
            // 
            this.colFunctionDetail.FieldName = "FunctionDetail";
            this.colFunctionDetail.Name = "colFunctionDetail";
            // 
            // colPrepared
            // 
            this.colPrepared.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrepared.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrepared.FieldName = "Prepared";
            this.colPrepared.Name = "colPrepared";
            this.colPrepared.Visible = true;
            this.colPrepared.VisibleIndex = 2;
            this.colPrepared.Width = 60;
            // 
            // colPreparedIp
            // 
            this.colPreparedIp.FieldName = "PreparedIp";
            this.colPreparedIp.Name = "colPreparedIp";
            // 
            // colGetTime
            // 
            this.colGetTime.FieldName = "GetTime";
            this.colGetTime.Name = "colGetTime";
            // 
            // pnlLeftTop
            // 
            this.pnlLeftTop.Controls.Add(this.btnQuery);
            this.pnlLeftTop.Controls.Add(this.textCommon);
            this.pnlLeftTop.Controls.Add(this.labCommon);
            this.pnlLeftTop.Controls.Add(this.dateGetTimeEnd);
            this.pnlLeftTop.Controls.Add(this.dateGetTimeBegin);
            this.pnlLeftTop.Controls.Add(this.lab1);
            this.pnlLeftTop.Controls.Add(this.labelGetTime);
            this.pnlLeftTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeftTop.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftTop.Name = "pnlLeftTop";
            this.pnlLeftTop.Size = new System.Drawing.Size(342, 76);
            this.pnlLeftTop.TabIndex = 0;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(252, 43);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 104;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
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
            // pnlRight
            // 
            this.pnlRight.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlRight.Controls.Add(this.xtraTabBottom);
            this.pnlRight.Controls.Add(this.pnlEdit);
            this.pnlRight.Controls.Add(this.pnlToolBar);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(350, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(658, 729);
            this.pnlRight.TabIndex = 1;
            // 
            // xtraTabBottom
            // 
            this.xtraTabBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabBottom.Location = new System.Drawing.Point(0, 230);
            this.xtraTabBottom.Name = "xtraTabBottom";
            this.xtraTabBottom.SelectedTabPage = this.PageDeliveryDetail;
            this.xtraTabBottom.Size = new System.Drawing.Size(658, 499);
            this.xtraTabBottom.TabIndex = 9;
            this.xtraTabBottom.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.PageDeliveryDetail});
            // 
            // PageDeliveryDetail
            // 
            this.PageDeliveryDetail.Controls.Add(this.gridControlDeliveryDetail);
            this.PageDeliveryDetail.Controls.Add(this.pnlBottomToolBar);
            this.PageDeliveryDetail.Name = "PageDeliveryDetail";
            this.PageDeliveryDetail.Size = new System.Drawing.Size(652, 470);
            this.PageDeliveryDetail.Text = "供货明细列表";
            // 
            // gridControlDeliveryDetail
            // 
            this.gridControlDeliveryDetail.DataSource = this.bindingSource_DeliveryDetail;
            this.gridControlDeliveryDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDeliveryDetail.Location = new System.Drawing.Point(0, 40);
            this.gridControlDeliveryDetail.MainView = this.gridViewDeliveryDetail;
            this.gridControlDeliveryDetail.Name = "gridControlDeliveryDetail";
            this.gridControlDeliveryDetail.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repMemoDeliveryText});
            this.gridControlDeliveryDetail.Size = new System.Drawing.Size(652, 430);
            this.gridControlDeliveryDetail.TabIndex = 7;
            this.gridControlDeliveryDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDeliveryDetail});
            // 
            // bindingSource_DeliveryDetail
            // 
            this.bindingSource_DeliveryDetail.DataMember = "DeliveryDetail";
            this.bindingSource_DeliveryDetail.DataSource = this.dataSet_DeliveryDetail;
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
            this.dataColumn4,
            this.dataColuAutoId,
            this.dataColuUnit,
            this.dataColuAmount,
            this.dataColuDeliveryQty,
            this.dataColuPrepared});
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
            // dataColuAutoId
            // 
            this.dataColuAutoId.ColumnName = "AutoId";
            this.dataColuAutoId.DataType = typeof(int);
            // 
            // dataColuUnit
            // 
            this.dataColuUnit.Caption = "供货单价";
            this.dataColuUnit.ColumnName = "Unit";
            this.dataColuUnit.DataType = typeof(double);
            // 
            // dataColuAmount
            // 
            this.dataColuAmount.Caption = "供货金额";
            this.dataColuAmount.ColumnName = "Amount";
            this.dataColuAmount.DataType = typeof(double);
            // 
            // dataColuDeliveryQty
            // 
            this.dataColuDeliveryQty.Caption = "供货数量";
            this.dataColuDeliveryQty.ColumnName = "DeliveryQty";
            this.dataColuDeliveryQty.DataType = typeof(double);
            // 
            // dataColuPrepared
            // 
            this.dataColuPrepared.Caption = "制单人";
            this.dataColuPrepared.ColumnName = "Prepared";
            // 
            // gridViewDeliveryDetail
            // 
            this.gridViewDeliveryDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSMNo1,
            this.colDeliveryText,
            this.colFunctionDesc1,
            this.colUnit,
            this.colDeliveryQty,
            this.colAmount,
            this.colPrepared1,
            this.colMaterialName,
            this.colMaterialBrand,
            this.colMaterialCate,
            this.colMatUnit,
            this.colMatQty,
            this.colMatAmount,
            this.colMaterialDesc,
            this.colAutoId1});
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
            this.gridViewDeliveryDetail.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewDeliveryDetail_RowClick);
            this.gridViewDeliveryDetail.CellMerge += new DevExpress.XtraGrid.Views.Grid.CellMergeEventHandler(this.gridViewDeliveryDetail_CellMerge);
            this.gridViewDeliveryDetail.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewDeliveryDetail_CustomDrawRowIndicator);
            this.gridViewDeliveryDetail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewDeliveryDetail_KeyDown);
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
            this.colFunctionDesc1.AppearanceCell.Options.UseTextOptions = true;
            this.colFunctionDesc1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colFunctionDesc1.AppearanceHeader.Options.UseTextOptions = true;
            this.colFunctionDesc1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFunctionDesc1.ColumnEdit = this.repMemoDeliveryText;
            this.colFunctionDesc1.FieldName = "FunctionDesc";
            this.colFunctionDesc1.Name = "colFunctionDesc1";
            this.colFunctionDesc1.Visible = true;
            this.colFunctionDesc1.VisibleIndex = 1;
            this.colFunctionDesc1.Width = 120;
            // 
            // colUnit
            // 
            this.colUnit.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnit.DisplayFormat.FormatString = "N2";
            this.colUnit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Unit", "{0:N2}")});
            this.colUnit.Visible = true;
            this.colUnit.VisibleIndex = 2;
            this.colUnit.Width = 80;
            // 
            // colDeliveryQty
            // 
            this.colDeliveryQty.AppearanceHeader.Options.UseTextOptions = true;
            this.colDeliveryQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDeliveryQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDeliveryQty.FieldName = "DeliveryQty";
            this.colDeliveryQty.Name = "colDeliveryQty";
            this.colDeliveryQty.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DeliveryQty", "{0:0.##}")});
            this.colDeliveryQty.Visible = true;
            this.colDeliveryQty.VisibleIndex = 3;
            this.colDeliveryQty.Width = 70;
            // 
            // colAmount
            // 
            this.colAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAmount.DisplayFormat.FormatString = "N2";
            this.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "{0:N2}")});
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 4;
            this.colAmount.Width = 90;
            // 
            // colPrepared1
            // 
            this.colPrepared1.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrepared1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrepared1.FieldName = "Prepared";
            this.colPrepared1.Name = "colPrepared1";
            this.colPrepared1.Visible = true;
            this.colPrepared1.VisibleIndex = 5;
            this.colPrepared1.Width = 60;
            // 
            // colMaterialName
            // 
            this.colMaterialName.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaterialName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaterialName.FieldName = "MaterialName";
            this.colMaterialName.Name = "colMaterialName";
            this.colMaterialName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colMaterialName.Visible = true;
            this.colMaterialName.VisibleIndex = 6;
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
            this.colMaterialBrand.VisibleIndex = 7;
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
            this.colMaterialCate.VisibleIndex = 8;
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
            this.colMatUnit.VisibleIndex = 9;
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
            this.colMatQty.VisibleIndex = 10;
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
            this.colMatAmount.VisibleIndex = 11;
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
            this.colMaterialDesc.VisibleIndex = 12;
            this.colMaterialDesc.Width = 200;
            // 
            // colAutoId1
            // 
            this.colAutoId1.FieldName = "AutoId";
            this.colAutoId1.Name = "colAutoId1";
            // 
            // pnlBottomToolBar
            // 
            this.pnlBottomToolBar.Controls.Add(this.btnSaveExcel);
            this.pnlBottomToolBar.Controls.Add(this.btnDDDelete);
            this.pnlBottomToolBar.Controls.Add(this.btnDDSave);
            this.pnlBottomToolBar.Controls.Add(this.btnDDNew);
            this.pnlBottomToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBottomToolBar.Location = new System.Drawing.Point(0, 0);
            this.pnlBottomToolBar.Name = "pnlBottomToolBar";
            this.pnlBottomToolBar.Size = new System.Drawing.Size(652, 40);
            this.pnlBottomToolBar.TabIndex = 0;
            // 
            // btnSaveExcel
            // 
            this.btnSaveExcel.Location = new System.Drawing.Point(252, 9);
            this.btnSaveExcel.Name = "btnSaveExcel";
            this.btnSaveExcel.Size = new System.Drawing.Size(75, 23);
            this.btnSaveExcel.TabIndex = 204;
            this.btnSaveExcel.TabStop = false;
            this.btnSaveExcel.Text = "存为Excel";
            this.btnSaveExcel.Click += new System.EventHandler(this.btnSaveExcel_Click);
            // 
            // btnDDDelete
            // 
            this.btnDDDelete.Location = new System.Drawing.Point(171, 9);
            this.btnDDDelete.Name = "btnDDDelete";
            this.btnDDDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDDDelete.TabIndex = 203;
            this.btnDDDelete.TabStop = false;
            this.btnDDDelete.Text = "删除";
            this.btnDDDelete.Click += new System.EventHandler(this.btnDDDelete_Click);
            // 
            // btnDDSave
            // 
            this.btnDDSave.Location = new System.Drawing.Point(90, 9);
            this.btnDDSave.Name = "btnDDSave";
            this.btnDDSave.Size = new System.Drawing.Size(75, 23);
            this.btnDDSave.TabIndex = 202;
            this.btnDDSave.TabStop = false;
            this.btnDDSave.Text = "修改";
            this.btnDDSave.Click += new System.EventHandler(this.btnDDSave_Click);
            // 
            // btnDDNew
            // 
            this.btnDDNew.Location = new System.Drawing.Point(10, 9);
            this.btnDDNew.Name = "btnDDNew";
            this.btnDDNew.Size = new System.Drawing.Size(75, 23);
            this.btnDDNew.TabIndex = 201;
            this.btnDDNew.TabStop = false;
            this.btnDDNew.Text = "新增";
            this.btnDDNew.Click += new System.EventHandler(this.btnDDNew_Click);
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.textPrepared);
            this.pnlEdit.Controls.Add(this.dateGetTime);
            this.pnlEdit.Controls.Add(this.labGetTime);
            this.pnlEdit.Controls.Add(this.labPrepared);
            this.pnlEdit.Controls.Add(this.memoFunctionDetail);
            this.pnlEdit.Controls.Add(this.labFunctionDetail);
            this.pnlEdit.Controls.Add(this.textFunctionDesc);
            this.pnlEdit.Controls.Add(this.labFunctionDesc);
            this.pnlEdit.Controls.Add(this.textSMNo);
            this.pnlEdit.Controls.Add(this.labSMNo);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEdit.Location = new System.Drawing.Point(0, 40);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(658, 190);
            this.pnlEdit.TabIndex = 8;
            // 
            // textPrepared
            // 
            this.textPrepared.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_StnModule, "Prepared", true));
            this.textPrepared.EnterMoveNextControl = true;
            this.textPrepared.Location = new System.Drawing.Point(334, 21);
            this.textPrepared.Name = "textPrepared";
            this.textPrepared.Properties.ReadOnly = true;
            this.textPrepared.Size = new System.Drawing.Size(150, 20);
            this.textPrepared.TabIndex = 1;
            this.textPrepared.TabStop = false;
            // 
            // dateGetTime
            // 
            this.dateGetTime.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_StnModule, "GetTime", true));
            this.dateGetTime.EditValue = null;
            this.dateGetTime.EnterMoveNextControl = true;
            this.dateGetTime.Location = new System.Drawing.Point(562, 21);
            this.dateGetTime.Name = "dateGetTime";
            this.dateGetTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateGetTime.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateGetTime.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dateGetTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateGetTime.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dateGetTime.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateGetTime.Properties.Mask.EditMask = "G";
            this.dateGetTime.Properties.ReadOnly = true;
            this.dateGetTime.Size = new System.Drawing.Size(150, 20);
            this.dateGetTime.TabIndex = 2;
            this.dateGetTime.TabStop = false;
            // 
            // labGetTime
            // 
            this.labGetTime.Location = new System.Drawing.Point(499, 24);
            this.labGetTime.Name = "labGetTime";
            this.labGetTime.Size = new System.Drawing.Size(48, 14);
            this.labGetTime.TabIndex = 21;
            this.labGetTime.Text = "登记时间";
            // 
            // labPrepared
            // 
            this.labPrepared.Location = new System.Drawing.Point(281, 24);
            this.labPrepared.Name = "labPrepared";
            this.labPrepared.Size = new System.Drawing.Size(36, 14);
            this.labPrepared.TabIndex = 20;
            this.labPrepared.Text = "制单人";
            // 
            // memoFunctionDetail
            // 
            this.memoFunctionDetail.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_StnModule, "FunctionDetail", true));
            this.memoFunctionDetail.Location = new System.Drawing.Point(112, 89);
            this.memoFunctionDetail.Name = "memoFunctionDetail";
            this.memoFunctionDetail.Properties.MaxLength = 1000;
            this.memoFunctionDetail.Size = new System.Drawing.Size(600, 80);
            this.memoFunctionDetail.TabIndex = 4;
            // 
            // labFunctionDetail
            // 
            this.labFunctionDetail.Location = new System.Drawing.Point(36, 92);
            this.labFunctionDetail.Name = "labFunctionDetail";
            this.labFunctionDetail.Size = new System.Drawing.Size(48, 14);
            this.labFunctionDetail.TabIndex = 13;
            this.labFunctionDetail.Text = "详细功能";
            // 
            // textFunctionDesc
            // 
            this.textFunctionDesc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_StnModule, "FunctionDesc", true));
            this.textFunctionDesc.EnterMoveNextControl = true;
            this.textFunctionDesc.Location = new System.Drawing.Point(112, 55);
            this.textFunctionDesc.Name = "textFunctionDesc";
            this.textFunctionDesc.Properties.MaxLength = 50;
            this.textFunctionDesc.Size = new System.Drawing.Size(600, 20);
            this.textFunctionDesc.TabIndex = 3;
            // 
            // labFunctionDesc
            // 
            this.labFunctionDesc.Location = new System.Drawing.Point(36, 58);
            this.labFunctionDesc.Name = "labFunctionDesc";
            this.labFunctionDesc.Size = new System.Drawing.Size(48, 14);
            this.labFunctionDesc.TabIndex = 12;
            this.labFunctionDesc.Text = "功能简述";
            // 
            // textSMNo
            // 
            this.textSMNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_StnModule, "SMNo", true));
            this.textSMNo.EnterMoveNextControl = true;
            this.textSMNo.Location = new System.Drawing.Point(112, 21);
            this.textSMNo.Name = "textSMNo";
            this.textSMNo.Properties.ReadOnly = true;
            this.textSMNo.Size = new System.Drawing.Size(150, 20);
            this.textSMNo.TabIndex = 0;
            this.textSMNo.TabStop = false;
            // 
            // labSMNo
            // 
            this.labSMNo.Location = new System.Drawing.Point(36, 24);
            this.labSMNo.Name = "labSMNo";
            this.labSMNo.Size = new System.Drawing.Size(60, 14);
            this.labSMNo.TabIndex = 2;
            this.labSMNo.Text = "功能模块号";
            // 
            // pnlToolBar
            // 
            this.pnlToolBar.Controls.Add(this.btnCopy);
            this.pnlToolBar.Controls.Add(this.btnDelete);
            this.pnlToolBar.Controls.Add(this.btnCancel);
            this.pnlToolBar.Controls.Add(this.btnSave);
            this.pnlToolBar.Controls.Add(this.btnNew);
            this.pnlToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolBar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolBar.Name = "pnlToolBar";
            this.pnlToolBar.Size = new System.Drawing.Size(658, 40);
            this.pnlToolBar.TabIndex = 7;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(334, 9);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 24;
            this.btnCopy.TabStop = false;
            this.btnCopy.Text = "复制";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(253, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(172, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(91, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "修改";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(10, 9);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 20;
            this.btnNew.TabStop = false;
            this.btnNew.Text = "新增";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // FrmStnModule
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.dockPnlLeft);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStnModule";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabText = "功能模块登记";
            this.Text = "功能模块登记";
            this.Activated += new System.EventHandler(this.FrmStnModule_Activated);
            this.Load += new System.EventHandler(this.FrmStnModule_Load);
            this.Shown += new System.EventHandler(this.FrmStnModule_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_StnModule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableStnModule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManagerLeft)).EndInit();
            this.dockPnlLeft.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeftGrid)).EndInit();
            this.pnlLeftGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStnModule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_StnModule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStnModule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeftTop)).EndInit();
            this.pnlLeftTop.ResumeLayout(false);
            this.pnlLeftTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textCommon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGetTimeEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGetTimeEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGetTimeBegin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGetTimeBegin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).EndInit();
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabBottom)).EndInit();
            this.xtraTabBottom.ResumeLayout(false);
            this.PageDeliveryDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDeliveryDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_DeliveryDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_DeliveryDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableDeliveryDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDeliveryDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repMemoDeliveryText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottomToolBar)).EndInit();
            this.pnlBottomToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textPrepared.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGetTime.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGetTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoFunctionDetail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textFunctionDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSMNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).EndInit();
            this.pnlToolBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dataSet_StnModule;
        private System.Data.DataTable TableStnModule;
        private System.Data.DataColumn dataColAutoId;
        private System.Data.DataColumn dataColSMNo;
        private System.Data.DataColumn dataColFunctionDesc;
        private System.Data.DataColumn dataColFunctionDetail;
        private System.Data.DataColumn dataColPrepared;
        private System.Data.DataColumn dataColPreparedIp;
        private System.Data.DataColumn dataColGetTime;
        private DevExpress.XtraBars.Docking.DockManager dockManagerLeft;
        private DevExpress.XtraBars.Docking.DockPanel dockPnlLeft;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraEditors.PanelControl pnlRight;
        private DevExpress.XtraEditors.PanelControl pnlToolBar;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.PanelControl pnlEdit;
        private DevExpress.XtraTab.XtraTabControl xtraTabBottom;
        private DevExpress.XtraTab.XtraTabPage PageDeliveryDetail;
        private DevExpress.XtraEditors.PanelControl pnlBottomToolBar;
        private DevExpress.XtraEditors.SimpleButton btnDDDelete;
        private DevExpress.XtraEditors.SimpleButton btnDDSave;
        private DevExpress.XtraEditors.SimpleButton btnDDNew;
        private DevExpress.XtraEditors.SimpleButton btnCopy;
        private DevExpress.XtraEditors.PanelControl pnlLeftTop;
        private DevExpress.XtraGrid.GridControl gridControlStnModule;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewStnModule;
        private DevExpress.XtraEditors.PanelControl pnlLeftGrid;
        private System.Windows.Forms.BindingSource bindingSource_StnModule;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colSMNo;
        private DevExpress.XtraGrid.Columns.GridColumn colFunctionDesc;
        private DevExpress.XtraGrid.Columns.GridColumn colFunctionDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colPrepared;
        private DevExpress.XtraGrid.Columns.GridColumn colPreparedIp;
        private DevExpress.XtraGrid.Columns.GridColumn colGetTime;
        private DevExpress.XtraEditors.TextEdit textSMNo;
        private DevExpress.XtraEditors.LabelControl labSMNo;
        private DevExpress.XtraEditors.TextEdit textFunctionDesc;
        private DevExpress.XtraEditors.LabelControl labFunctionDesc;
        private DevExpress.XtraEditors.LabelControl labFunctionDetail;
        private DevExpress.XtraEditors.MemoEdit memoFunctionDetail;
        private DevExpress.XtraEditors.TextEdit textPrepared;
        private DevExpress.XtraEditors.DateEdit dateGetTime;
        private DevExpress.XtraEditors.LabelControl labGetTime;
        private DevExpress.XtraEditors.LabelControl labPrepared;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.TextEdit textCommon;
        private DevExpress.XtraEditors.LabelControl labCommon;
        private DevExpress.XtraEditors.DateEdit dateGetTimeEnd;
        private DevExpress.XtraEditors.DateEdit dateGetTimeBegin;
        private DevExpress.XtraEditors.LabelControl lab1;
        private DevExpress.XtraEditors.LabelControl labelGetTime;
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
        private System.Windows.Forms.BindingSource bindingSource_DeliveryDetail;
        private DevExpress.XtraGrid.GridControl gridControlDeliveryDetail;
        private System.Data.DataColumn dataColuAutoId;
        private System.Data.DataColumn dataColuUnit;
        private System.Data.DataColumn dataColuAmount;
        private System.Data.DataColumn dataColuDeliveryQty;
        private System.Data.DataColumn dataColuPrepared;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDeliveryDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colSMNo1;
        private DevExpress.XtraGrid.Columns.GridColumn colDeliveryText;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repMemoDeliveryText;
        private DevExpress.XtraGrid.Columns.GridColumn colFunctionDesc1;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colDeliveryQty;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colPrepared1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialName;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialBrand;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialCate;
        private DevExpress.XtraGrid.Columns.GridColumn colMatUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colMatQty;
        private DevExpress.XtraGrid.Columns.GridColumn colMatAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialDesc;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId1;
        private DevExpress.XtraEditors.SimpleButton btnSaveExcel;
    }
}