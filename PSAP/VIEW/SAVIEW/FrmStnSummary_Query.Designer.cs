namespace PSAP.VIEW.BSVIEW
{
    partial class FrmStnSummary_Query
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
            this.pnltop = new DevExpress.XtraEditors.PanelControl();
            this.btnSaveExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.textCommon = new DevExpress.XtraEditors.TextEdit();
            this.lookUpPrepared = new DevExpress.XtraEditors.LookUpEdit();
            this.searchLookUpStnModule = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpStnModuleView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColSMNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColFunctionDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateGetTimeEnd = new DevExpress.XtraEditors.DateEdit();
            this.lab1 = new DevExpress.XtraEditors.LabelControl();
            this.dateGetTimeBegin = new DevExpress.XtraEditors.DateEdit();
            this.labCommon = new DevExpress.XtraEditors.LabelControl();
            this.labPrepared = new DevExpress.XtraEditors.LabelControl();
            this.labStnModule = new DevExpress.XtraEditors.LabelControl();
            this.labSADate = new DevExpress.XtraEditors.LabelControl();
            this.dataSet_StnSummaryList = new System.Data.DataSet();
            this.TableStnSummaryList = new System.Data.DataTable();
            this.dataColAutoId = new System.Data.DataColumn();
            this.dataColSSNo = new System.Data.DataColumn();
            this.dataColStnNo = new System.Data.DataColumn();
            this.dataColStnDesc = new System.Data.DataColumn();
            this.dataColPrepared = new System.Data.DataColumn();
            this.dataColGetTime = new System.Data.DataColumn();
            this.dataColAutoQuotationNo = new System.Data.DataColumn();
            this.dataColListModuleAutoId = new System.Data.DataColumn();
            this.dataColSMNo = new System.Data.DataColumn();
            this.dataColFunctionDesc = new System.Data.DataColumn();
            this.bindingSource_StnSummaryList = new System.Windows.Forms.BindingSource(this.components);
            this.pnlBottom = new DevExpress.XtraEditors.PanelControl();
            this.gridBottomOrderHead = new PSAP.VIEW.BSVIEW.GridBottom();
            this.pnlMiddle = new DevExpress.XtraEditors.PanelControl();
            this.gridCtlStnSummaryList = new DevExpress.XtraGrid.GridControl();
            this.gridViewStnSummaryList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSSNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStnNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStnDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repMemoStnDesc = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colPrepared = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGetTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAutoQuotationNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSMNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFunctionDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colListModuleAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dataColFunctionDetail = new System.Data.DataColumn();
            this.colFunctionDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pnltop)).BeginInit();
            this.pnltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textCommon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPrepared.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpStnModule.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpStnModuleView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGetTimeEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGetTimeEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGetTimeBegin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGetTimeBegin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_StnSummaryList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableStnSummaryList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_StnSummaryList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).BeginInit();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddle)).BeginInit();
            this.pnlMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtlStnSummaryList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStnSummaryList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repMemoStnDesc)).BeginInit();
            this.SuspendLayout();
            // 
            // pnltop
            // 
            this.pnltop.Controls.Add(this.btnSaveExcel);
            this.pnltop.Controls.Add(this.btnQuery);
            this.pnltop.Controls.Add(this.textCommon);
            this.pnltop.Controls.Add(this.lookUpPrepared);
            this.pnltop.Controls.Add(this.searchLookUpStnModule);
            this.pnltop.Controls.Add(this.dateGetTimeEnd);
            this.pnltop.Controls.Add(this.lab1);
            this.pnltop.Controls.Add(this.dateGetTimeBegin);
            this.pnltop.Controls.Add(this.labCommon);
            this.pnltop.Controls.Add(this.labPrepared);
            this.pnltop.Controls.Add(this.labStnModule);
            this.pnltop.Controls.Add(this.labSADate);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Margin = new System.Windows.Forms.Padding(4);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(1218, 78);
            this.pnltop.TabIndex = 4;
            // 
            // btnSaveExcel
            // 
            this.btnSaveExcel.Location = new System.Drawing.Point(575, 43);
            this.btnSaveExcel.Name = "btnSaveExcel";
            this.btnSaveExcel.Size = new System.Drawing.Size(75, 23);
            this.btnSaveExcel.TabIndex = 6;
            this.btnSaveExcel.Text = "存为Excel";
            this.btnSaveExcel.Click += new System.EventHandler(this.btnSaveExcel_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(483, 43);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 5;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // textCommon
            // 
            this.textCommon.EnterMoveNextControl = true;
            this.textCommon.Location = new System.Drawing.Point(293, 44);
            this.textCommon.Margin = new System.Windows.Forms.Padding(4);
            this.textCommon.Name = "textCommon";
            this.textCommon.Size = new System.Drawing.Size(150, 20);
            this.textCommon.TabIndex = 4;
            // 
            // lookUpPrepared
            // 
            this.lookUpPrepared.EnterMoveNextControl = true;
            this.lookUpPrepared.Location = new System.Drawing.Point(86, 44);
            this.lookUpPrepared.Margin = new System.Windows.Forms.Padding(4);
            this.lookUpPrepared.Name = "lookUpPrepared";
            this.lookUpPrepared.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpPrepared.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AutoId", "AutoId", 80, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LoginId", "用户名", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmpName", "员工名", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpPrepared.Properties.DisplayMember = "EmpName";
            this.lookUpPrepared.Properties.NullText = "";
            this.lookUpPrepared.Properties.ValueMember = "EmpName";
            this.lookUpPrepared.Size = new System.Drawing.Size(120, 20);
            this.lookUpPrepared.TabIndex = 3;
            // 
            // searchLookUpStnModule
            // 
            this.searchLookUpStnModule.EnterMoveNextControl = true;
            this.searchLookUpStnModule.Location = new System.Drawing.Point(394, 14);
            this.searchLookUpStnModule.Margin = new System.Windows.Forms.Padding(4);
            this.searchLookUpStnModule.Name = "searchLookUpStnModule";
            this.searchLookUpStnModule.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpStnModule.Properties.DisplayMember = "FunctionDesc";
            this.searchLookUpStnModule.Properties.NullText = "";
            this.searchLookUpStnModule.Properties.ValueMember = "SMNo";
            this.searchLookUpStnModule.Properties.View = this.searchLookUpStnModuleView;
            this.searchLookUpStnModule.Size = new System.Drawing.Size(150, 20);
            this.searchLookUpStnModule.TabIndex = 2;
            // 
            // searchLookUpStnModuleView
            // 
            this.searchLookUpStnModuleView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColAutoId,
            this.gridColSMNo,
            this.gridColFunctionDesc});
            this.searchLookUpStnModuleView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpStnModuleView.IndicatorWidth = 60;
            this.searchLookUpStnModuleView.Name = "searchLookUpStnModuleView";
            this.searchLookUpStnModuleView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpStnModuleView.OptionsView.ShowGroupPanel = false;
            this.searchLookUpStnModuleView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewStnSummaryList_CustomDrawRowIndicator);
            // 
            // gridColAutoId
            // 
            this.gridColAutoId.Caption = "gridColAutoId";
            this.gridColAutoId.FieldName = "AutoId";
            this.gridColAutoId.Name = "gridColAutoId";
            // 
            // gridColSMNo
            // 
            this.gridColSMNo.Caption = "功能模块号";
            this.gridColSMNo.FieldName = "SMNo";
            this.gridColSMNo.Name = "gridColSMNo";
            this.gridColSMNo.Visible = true;
            this.gridColSMNo.VisibleIndex = 0;
            // 
            // gridColFunctionDesc
            // 
            this.gridColFunctionDesc.Caption = "功能简述";
            this.gridColFunctionDesc.FieldName = "FunctionDesc";
            this.gridColFunctionDesc.Name = "gridColFunctionDesc";
            this.gridColFunctionDesc.Visible = true;
            this.gridColFunctionDesc.VisibleIndex = 1;
            // 
            // dateGetTimeEnd
            // 
            this.dateGetTimeEnd.EditValue = null;
            this.dateGetTimeEnd.EnterMoveNextControl = true;
            this.dateGetTimeEnd.Location = new System.Drawing.Point(202, 14);
            this.dateGetTimeEnd.Margin = new System.Windows.Forms.Padding(4);
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
            this.dateGetTimeEnd.TabIndex = 1;
            // 
            // lab1
            // 
            this.lab1.Location = new System.Drawing.Point(192, 17);
            this.lab1.Margin = new System.Windows.Forms.Padding(4);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(4, 14);
            this.lab1.TabIndex = 6;
            this.lab1.Text = "-";
            // 
            // dateGetTimeBegin
            // 
            this.dateGetTimeBegin.EditValue = null;
            this.dateGetTimeBegin.EnterMoveNextControl = true;
            this.dateGetTimeBegin.Location = new System.Drawing.Point(86, 14);
            this.dateGetTimeBegin.Margin = new System.Windows.Forms.Padding(4);
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
            this.dateGetTimeBegin.TabIndex = 0;
            // 
            // labCommon
            // 
            this.labCommon.Location = new System.Drawing.Point(227, 47);
            this.labCommon.Margin = new System.Windows.Forms.Padding(4);
            this.labCommon.Name = "labCommon";
            this.labCommon.Size = new System.Drawing.Size(60, 14);
            this.labCommon.TabIndex = 22;
            this.labCommon.Text = "通用查询：";
            // 
            // labPrepared
            // 
            this.labPrepared.Location = new System.Drawing.Point(20, 47);
            this.labPrepared.Margin = new System.Windows.Forms.Padding(4);
            this.labPrepared.Name = "labPrepared";
            this.labPrepared.Size = new System.Drawing.Size(48, 14);
            this.labPrepared.TabIndex = 20;
            this.labPrepared.Text = "制单人：";
            // 
            // labStnModule
            // 
            this.labStnModule.Location = new System.Drawing.Point(326, 17);
            this.labStnModule.Margin = new System.Windows.Forms.Padding(4);
            this.labStnModule.Name = "labStnModule";
            this.labStnModule.Size = new System.Drawing.Size(60, 14);
            this.labStnModule.TabIndex = 18;
            this.labStnModule.Text = "功能模块：";
            // 
            // labSADate
            // 
            this.labSADate.Location = new System.Drawing.Point(20, 17);
            this.labSADate.Margin = new System.Windows.Forms.Padding(4);
            this.labSADate.Name = "labSADate";
            this.labSADate.Size = new System.Drawing.Size(60, 14);
            this.labSADate.TabIndex = 5;
            this.labSADate.Text = "登记日期：";
            // 
            // dataSet_StnSummaryList
            // 
            this.dataSet_StnSummaryList.DataSetName = "NewDataSet";
            this.dataSet_StnSummaryList.EnforceConstraints = false;
            this.dataSet_StnSummaryList.Tables.AddRange(new System.Data.DataTable[] {
            this.TableStnSummaryList});
            // 
            // TableStnSummaryList
            // 
            this.TableStnSummaryList.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColAutoId,
            this.dataColSSNo,
            this.dataColStnNo,
            this.dataColStnDesc,
            this.dataColPrepared,
            this.dataColGetTime,
            this.dataColAutoQuotationNo,
            this.dataColListModuleAutoId,
            this.dataColSMNo,
            this.dataColFunctionDesc,
            this.dataColFunctionDetail});
            this.TableStnSummaryList.TableName = "StnSummaryList";
            // 
            // dataColAutoId
            // 
            this.dataColAutoId.ColumnName = "AutoId";
            this.dataColAutoId.DataType = typeof(int);
            // 
            // dataColSSNo
            // 
            this.dataColSSNo.Caption = "工位序号";
            this.dataColSSNo.ColumnName = "SSNo";
            // 
            // dataColStnNo
            // 
            this.dataColStnNo.Caption = "站号";
            this.dataColStnNo.ColumnName = "StnNo";
            // 
            // dataColStnDesc
            // 
            this.dataColStnDesc.Caption = "站号描述";
            this.dataColStnDesc.ColumnName = "StnDesc";
            // 
            // dataColPrepared
            // 
            this.dataColPrepared.Caption = "制单人";
            this.dataColPrepared.ColumnName = "Prepared";
            // 
            // dataColGetTime
            // 
            this.dataColGetTime.Caption = "登记日期";
            this.dataColGetTime.ColumnName = "GetTime";
            this.dataColGetTime.DataType = typeof(System.DateTime);
            // 
            // dataColAutoQuotationNo
            // 
            this.dataColAutoQuotationNo.Caption = "报价单号";
            this.dataColAutoQuotationNo.ColumnName = "AutoQuotationNo";
            // 
            // dataColListModuleAutoId
            // 
            this.dataColListModuleAutoId.Caption = "ListModuleAutoId";
            this.dataColListModuleAutoId.ColumnName = "ListModuleAutoId";
            this.dataColListModuleAutoId.DataType = typeof(int);
            // 
            // dataColSMNo
            // 
            this.dataColSMNo.Caption = "功能模块号";
            this.dataColSMNo.ColumnName = "SMNo";
            // 
            // dataColFunctionDesc
            // 
            this.dataColFunctionDesc.Caption = "功能简述";
            this.dataColFunctionDesc.ColumnName = "FunctionDesc";
            // 
            // bindingSource_StnSummaryList
            // 
            this.bindingSource_StnSummaryList.DataMember = "StnSummaryList";
            this.bindingSource_StnSummaryList.DataSource = this.dataSet_StnSummaryList;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.gridBottomOrderHead);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 503);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1218, 58);
            this.pnlBottom.TabIndex = 8;
            // 
            // gridBottomOrderHead
            // 
            this.gridBottomOrderHead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBottomOrderHead.Location = new System.Drawing.Point(2, 2);
            this.gridBottomOrderHead.MasterDataSet = this.dataSet_StnSummaryList;
            this.gridBottomOrderHead.Name = "gridBottomOrderHead";
            this.gridBottomOrderHead.pageRowCount = 5;
            this.gridBottomOrderHead.Size = new System.Drawing.Size(1214, 54);
            this.gridBottomOrderHead.TabIndex = 0;
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.Controls.Add(this.gridCtlStnSummaryList);
            this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMiddle.Location = new System.Drawing.Point(0, 78);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(1218, 425);
            this.pnlMiddle.TabIndex = 9;
            // 
            // gridCtlStnSummaryList
            // 
            this.gridCtlStnSummaryList.DataSource = this.bindingSource_StnSummaryList;
            this.gridCtlStnSummaryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtlStnSummaryList.Location = new System.Drawing.Point(2, 2);
            this.gridCtlStnSummaryList.MainView = this.gridViewStnSummaryList;
            this.gridCtlStnSummaryList.Name = "gridCtlStnSummaryList";
            this.gridCtlStnSummaryList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repMemoStnDesc});
            this.gridCtlStnSummaryList.Size = new System.Drawing.Size(1214, 421);
            this.gridCtlStnSummaryList.TabIndex = 5;
            this.gridCtlStnSummaryList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewStnSummaryList});
            // 
            // gridViewStnSummaryList
            // 
            this.gridViewStnSummaryList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId,
            this.colSSNo,
            this.colStnNo,
            this.colStnDesc,
            this.colPrepared,
            this.colGetTime,
            this.colAutoQuotationNo,
            this.colSMNo,
            this.colFunctionDesc,
            this.colFunctionDetail,
            this.colListModuleAutoId});
            this.gridViewStnSummaryList.GridControl = this.gridCtlStnSummaryList;
            this.gridViewStnSummaryList.IndicatorWidth = 40;
            this.gridViewStnSummaryList.Name = "gridViewStnSummaryList";
            this.gridViewStnSummaryList.OptionsBehavior.Editable = false;
            this.gridViewStnSummaryList.OptionsBehavior.ReadOnly = true;
            this.gridViewStnSummaryList.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewStnSummaryList.OptionsView.AllowCellMerge = true;
            this.gridViewStnSummaryList.OptionsView.ColumnAutoWidth = false;
            this.gridViewStnSummaryList.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewStnSummaryList.OptionsView.ShowFooter = true;
            this.gridViewStnSummaryList.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewStnSummaryList_RowClick);
            this.gridViewStnSummaryList.CellMerge += new DevExpress.XtraGrid.Views.Grid.CellMergeEventHandler(this.gridViewStnSummaryList_CellMerge);
            this.gridViewStnSummaryList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewStnSummaryList_CustomDrawRowIndicator);
            this.gridViewStnSummaryList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewStnSummaryList_KeyDown);
            // 
            // colAutoId
            // 
            this.colAutoId.FieldName = "AutoId";
            this.colAutoId.Name = "colAutoId";
            // 
            // colSSNo
            // 
            this.colSSNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colSSNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSSNo.FieldName = "SSNo";
            this.colSSNo.Name = "colSSNo";
            this.colSSNo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "SSNo", "共计{0}条")});
            this.colSSNo.Visible = true;
            this.colSSNo.VisibleIndex = 1;
            this.colSSNo.Width = 110;
            // 
            // colStnNo
            // 
            this.colStnNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colStnNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStnNo.FieldName = "StnNo";
            this.colStnNo.Name = "colStnNo";
            this.colStnNo.Visible = true;
            this.colStnNo.VisibleIndex = 2;
            this.colStnNo.Width = 120;
            // 
            // colStnDesc
            // 
            this.colStnDesc.AppearanceCell.Options.UseTextOptions = true;
            this.colStnDesc.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colStnDesc.AppearanceHeader.Options.UseTextOptions = true;
            this.colStnDesc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStnDesc.ColumnEdit = this.repMemoStnDesc;
            this.colStnDesc.FieldName = "StnDesc";
            this.colStnDesc.Name = "colStnDesc";
            this.colStnDesc.Visible = true;
            this.colStnDesc.VisibleIndex = 3;
            this.colStnDesc.Width = 200;
            // 
            // repMemoStnDesc
            // 
            this.repMemoStnDesc.Name = "repMemoStnDesc";
            // 
            // colPrepared
            // 
            this.colPrepared.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrepared.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrepared.FieldName = "Prepared";
            this.colPrepared.Name = "colPrepared";
            this.colPrepared.Visible = true;
            this.colPrepared.VisibleIndex = 5;
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
            this.colGetTime.VisibleIndex = 4;
            this.colGetTime.Width = 130;
            // 
            // colAutoQuotationNo
            // 
            this.colAutoQuotationNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colAutoQuotationNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAutoQuotationNo.FieldName = "AutoQuotationNo";
            this.colAutoQuotationNo.Name = "colAutoQuotationNo";
            this.colAutoQuotationNo.Visible = true;
            this.colAutoQuotationNo.VisibleIndex = 0;
            this.colAutoQuotationNo.Width = 110;
            // 
            // colSMNo
            // 
            this.colSMNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colSMNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSMNo.FieldName = "SMNo";
            this.colSMNo.Name = "colSMNo";
            this.colSMNo.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colSMNo.Visible = true;
            this.colSMNo.VisibleIndex = 6;
            this.colSMNo.Width = 110;
            // 
            // colFunctionDesc
            // 
            this.colFunctionDesc.AppearanceHeader.Options.UseTextOptions = true;
            this.colFunctionDesc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFunctionDesc.FieldName = "FunctionDesc";
            this.colFunctionDesc.Name = "colFunctionDesc";
            this.colFunctionDesc.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colFunctionDesc.Visible = true;
            this.colFunctionDesc.VisibleIndex = 7;
            this.colFunctionDesc.Width = 200;
            // 
            // colListModuleAutoId
            // 
            this.colListModuleAutoId.FieldName = "ListModuleAutoId";
            this.colListModuleAutoId.Name = "colListModuleAutoId";
            // 
            // dataColFunctionDetail
            // 
            this.dataColFunctionDetail.Caption = "详细功能";
            this.dataColFunctionDetail.ColumnName = "FunctionDetail";
            // 
            // colFunctionDetail
            // 
            this.colFunctionDetail.AppearanceHeader.Options.UseTextOptions = true;
            this.colFunctionDetail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFunctionDetail.FieldName = "FunctionDetail";
            this.colFunctionDetail.Name = "colFunctionDetail";
            this.colFunctionDetail.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colFunctionDetail.Visible = true;
            this.colFunctionDetail.VisibleIndex = 8;
            this.colFunctionDetail.Width = 300;
            // 
            // FrmStnSummary_Query
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1218, 561);
            this.Controls.Add(this.pnlMiddle);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnltop);
            this.Name = "FrmStnSummary_Query";
            this.TabText = "工位信息查询";
            this.Text = "工位信息查询";
            this.Load += new System.EventHandler(this.FrmStnSummary_Query_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnltop)).EndInit();
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textCommon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPrepared.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpStnModule.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpStnModuleView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGetTimeEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGetTimeEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGetTimeBegin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGetTimeBegin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_StnSummaryList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableStnSummaryList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_StnSummaryList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddle)).EndInit();
            this.pnlMiddle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtlStnSummaryList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStnSummaryList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repMemoStnDesc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnltop;
        private DevExpress.XtraEditors.SimpleButton btnSaveExcel;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.TextEdit textCommon;
        private DevExpress.XtraEditors.LookUpEdit lookUpPrepared;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpStnModule;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpStnModuleView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColSMNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColFunctionDesc;
        private DevExpress.XtraEditors.DateEdit dateGetTimeEnd;
        private DevExpress.XtraEditors.LabelControl lab1;
        private DevExpress.XtraEditors.DateEdit dateGetTimeBegin;
        private DevExpress.XtraEditors.LabelControl labCommon;
        private DevExpress.XtraEditors.LabelControl labPrepared;
        private DevExpress.XtraEditors.LabelControl labStnModule;
        private DevExpress.XtraEditors.LabelControl labSADate;
        private System.Data.DataSet dataSet_StnSummaryList;
        private System.Data.DataTable TableStnSummaryList;
        private System.Data.DataColumn dataColAutoId;
        private System.Data.DataColumn dataColSSNo;
        private System.Data.DataColumn dataColStnNo;
        private System.Data.DataColumn dataColStnDesc;
        private System.Data.DataColumn dataColPrepared;
        private System.Data.DataColumn dataColGetTime;
        private System.Data.DataColumn dataColAutoQuotationNo;
        private System.Data.DataColumn dataColListModuleAutoId;
        private System.Data.DataColumn dataColSMNo;
        private System.Windows.Forms.BindingSource bindingSource_StnSummaryList;
        private System.Data.DataColumn dataColFunctionDesc;
        private DevExpress.XtraEditors.PanelControl pnlBottom;
        private GridBottom gridBottomOrderHead;
        private DevExpress.XtraEditors.PanelControl pnlMiddle;
        private DevExpress.XtraGrid.GridControl gridCtlStnSummaryList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewStnSummaryList;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colSSNo;
        private DevExpress.XtraGrid.Columns.GridColumn colStnNo;
        private DevExpress.XtraGrid.Columns.GridColumn colStnDesc;
        private DevExpress.XtraGrid.Columns.GridColumn colPrepared;
        private DevExpress.XtraGrid.Columns.GridColumn colGetTime;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoQuotationNo;
        private DevExpress.XtraGrid.Columns.GridColumn colSMNo;
        private DevExpress.XtraGrid.Columns.GridColumn colFunctionDesc;
        private DevExpress.XtraGrid.Columns.GridColumn colListModuleAutoId;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repMemoStnDesc;
        private System.Data.DataColumn dataColFunctionDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colFunctionDetail;
    }
}