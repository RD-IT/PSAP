namespace PSAP.VIEW.BSVIEW
{
    partial class FrmProductionSchedule
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
            this.pnlRight = new DevExpress.XtraEditors.PanelControl();
            this.pnlBottom = new DevExpress.XtraEditors.PanelControl();
            this.gridControlPScheduleBOM = new DevExpress.XtraGrid.GridControl();
            this.bindingSource_PScheduleBom = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_PSchedule = new System.Data.DataSet();
            this.dataTableProductionSchedule = new System.Data.DataTable();
            this.dataColAutoId = new System.Data.DataColumn();
            this.dataColPsNo = new System.Data.DataColumn();
            this.dataColCurrentDate = new System.Data.DataColumn();
            this.dataColCodeFileName = new System.Data.DataColumn();
            this.dataColPlannedQty = new System.Data.DataColumn();
            this.dataColPlannedStarttime = new System.Data.DataColumn();
            this.dataColPlannedEndtime = new System.Data.DataColumn();
            this.dataColPrepared = new System.Data.DataColumn();
            this.dataColPreparedIp = new System.Data.DataColumn();
            this.dataColModifier = new System.Data.DataColumn();
            this.dataColModifierIp = new System.Data.DataColumn();
            this.dataColModifierTime = new System.Data.DataColumn();
            this.dataColPsState = new System.Data.DataColumn();
            this.dataColGetTime = new System.Data.DataColumn();
            this.dataColSelect = new System.Data.DataColumn();
            this.dataColRemark = new System.Data.DataColumn();
            this.dataColCodeName = new System.Data.DataColumn();
            this.dataTableProductionScheduleBom = new System.Data.DataTable();
            this.dataColuAutoId = new System.Data.DataColumn();
            this.dataColuPsNo = new System.Data.DataColumn();
            this.dataColuCodeFileName = new System.Data.DataColumn();
            this.dataColuQty = new System.Data.DataColumn();
            this.dataColuTotalQty = new System.Data.DataColumn();
            this.dataColuCodeName = new System.Data.DataColumn();
            this.gridViewPScheduleBOM = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnPsNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSpinQty = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colTotalQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repbtnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemSearchLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.pnlMiddle = new DevExpress.XtraEditors.PanelControl();
            this.checkAll = new DevExpress.XtraEditors.CheckEdit();
            this.gridControlPSchedule = new DevExpress.XtraGrid.GridControl();
            this.bindingSource_PSchedule = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewPSchedule = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelect = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCheckSelect = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colPsNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPsState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrentDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodeFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSearchCodeFileName = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repSearchCodeFileNameView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCodeFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCodeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlannedQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSpinPlannedQty = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colPlannedStarttime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlannedEndtime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrepared = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlMiddleTop = new DevExpress.XtraEditors.PanelControl();
            this.btnPreview = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelApprove = new DevExpress.XtraEditors.SimpleButton();
            this.btnApprove = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.pnltop = new DevExpress.XtraEditors.PanelControl();
            this.searchLookUpCodeFileName = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpCodeFileNameView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labCodeFileName = new DevExpress.XtraEditors.LabelControl();
            this.checkPlanDate = new DevExpress.XtraEditors.CheckEdit();
            this.datePlanDateEnd = new DevExpress.XtraEditors.DateEdit();
            this.datePlanDateBegin = new DevExpress.XtraEditors.DateEdit();
            this.textCommon = new DevExpress.XtraEditors.TextEdit();
            this.comboBoxReqState = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lookUpPrepared = new DevExpress.XtraEditors.LookUpEdit();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.dateCurrentDateEnd = new DevExpress.XtraEditors.DateEdit();
            this.dateCurrentDateBegin = new DevExpress.XtraEditors.DateEdit();
            this.labPlanDate = new DevExpress.XtraEditors.LabelControl();
            this.lab2 = new DevExpress.XtraEditors.LabelControl();
            this.labCommon = new DevExpress.XtraEditors.LabelControl();
            this.labPrepared = new DevExpress.XtraEditors.LabelControl();
            this.labReqState = new DevExpress.XtraEditors.LabelControl();
            this.lab1 = new DevExpress.XtraEditors.LabelControl();
            this.labCurrentDate = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).BeginInit();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).BeginInit();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPScheduleBOM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_PScheduleBom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_PSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableProductionSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableProductionScheduleBom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPScheduleBOM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repbtnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddle)).BeginInit();
            this.pnlMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_PSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchCodeFileName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchCodeFileNameView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinPlannedQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddleTop)).BeginInit();
            this.pnlMiddleTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnltop)).BeginInit();
            this.pnltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpCodeFileName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpCodeFileNameView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkPlanDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePlanDateEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePlanDateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePlanDateBegin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePlanDateBegin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCommon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxReqState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPrepared.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCurrentDateEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCurrentDateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCurrentDateBegin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCurrentDateBegin.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRight
            // 
            this.pnlRight.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlRight.Controls.Add(this.pnlBottom);
            this.pnlRight.Controls.Add(this.splitterControl1);
            this.pnlRight.Controls.Add(this.pnlMiddle);
            this.pnlRight.Controls.Add(this.pnltop);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(0, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(1267, 615);
            this.pnlRight.TabIndex = 0;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.gridControlPScheduleBOM);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(0, 269);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1267, 346);
            this.pnlBottom.TabIndex = 7;
            // 
            // gridControlPScheduleBOM
            // 
            this.gridControlPScheduleBOM.AllowDrop = true;
            this.gridControlPScheduleBOM.DataSource = this.bindingSource_PScheduleBom;
            this.gridControlPScheduleBOM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPScheduleBOM.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlPScheduleBOM.Location = new System.Drawing.Point(2, 2);
            this.gridControlPScheduleBOM.MainView = this.gridViewPScheduleBOM;
            this.gridControlPScheduleBOM.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlPScheduleBOM.Name = "gridControlPScheduleBOM";
            this.gridControlPScheduleBOM.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repSpinQty,
            this.repositoryItemSearchLookUpEdit1,
            this.repbtnDelete});
            this.gridControlPScheduleBOM.Size = new System.Drawing.Size(1263, 342);
            this.gridControlPScheduleBOM.TabIndex = 4;
            this.gridControlPScheduleBOM.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPScheduleBOM});
            // 
            // bindingSource_PScheduleBom
            // 
            this.bindingSource_PScheduleBom.DataMember = "ProductionScheduleBom";
            this.bindingSource_PScheduleBom.DataSource = this.dataSet_PSchedule;
            // 
            // dataSet_PSchedule
            // 
            this.dataSet_PSchedule.DataSetName = "NewDataSet";
            this.dataSet_PSchedule.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTableProductionSchedule,
            this.dataTableProductionScheduleBom});
            // 
            // dataTableProductionSchedule
            // 
            this.dataTableProductionSchedule.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColAutoId,
            this.dataColPsNo,
            this.dataColCurrentDate,
            this.dataColCodeFileName,
            this.dataColPlannedQty,
            this.dataColPlannedStarttime,
            this.dataColPlannedEndtime,
            this.dataColPrepared,
            this.dataColPreparedIp,
            this.dataColModifier,
            this.dataColModifierIp,
            this.dataColModifierTime,
            this.dataColPsState,
            this.dataColGetTime,
            this.dataColSelect,
            this.dataColRemark,
            this.dataColCodeName});
            this.dataTableProductionSchedule.TableName = "ProductionSchedule";
            // 
            // dataColAutoId
            // 
            this.dataColAutoId.ColumnName = "AutoId";
            this.dataColAutoId.DataType = typeof(int);
            // 
            // dataColPsNo
            // 
            this.dataColPsNo.Caption = "生产计划单号";
            this.dataColPsNo.ColumnName = "PsNo";
            // 
            // dataColCurrentDate
            // 
            this.dataColCurrentDate.Caption = "单据日期";
            this.dataColCurrentDate.ColumnName = "CurrentDate";
            this.dataColCurrentDate.DataType = typeof(System.DateTime);
            // 
            // dataColCodeFileName
            // 
            this.dataColCodeFileName.Caption = "零件编号";
            this.dataColCodeFileName.ColumnName = "CodeFileName";
            // 
            // dataColPlannedQty
            // 
            this.dataColPlannedQty.Caption = "数量";
            this.dataColPlannedQty.ColumnName = "PlannedQty";
            this.dataColPlannedQty.DataType = typeof(int);
            // 
            // dataColPlannedStarttime
            // 
            this.dataColPlannedStarttime.Caption = "计划开始日期";
            this.dataColPlannedStarttime.ColumnName = "PlannedStarttime";
            this.dataColPlannedStarttime.DataType = typeof(System.DateTime);
            // 
            // dataColPlannedEndtime
            // 
            this.dataColPlannedEndtime.Caption = "计划完成日期";
            this.dataColPlannedEndtime.ColumnName = "PlannedEndtime";
            this.dataColPlannedEndtime.DataType = typeof(System.DateTime);
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
            // dataColModifier
            // 
            this.dataColModifier.Caption = "修改人";
            this.dataColModifier.ColumnName = "Modifier";
            // 
            // dataColModifierIp
            // 
            this.dataColModifierIp.Caption = "修改人IP";
            this.dataColModifierIp.ColumnName = "ModifierIp";
            // 
            // dataColModifierTime
            // 
            this.dataColModifierTime.Caption = "修改时间";
            this.dataColModifierTime.ColumnName = "ModifierTime";
            this.dataColModifierTime.DataType = typeof(System.DateTime);
            // 
            // dataColPsState
            // 
            this.dataColPsState.Caption = "状态";
            this.dataColPsState.ColumnName = "PsState";
            this.dataColPsState.DataType = typeof(int);
            // 
            // dataColGetTime
            // 
            this.dataColGetTime.Caption = "登记时间";
            this.dataColGetTime.ColumnName = "GetTime";
            this.dataColGetTime.DataType = typeof(System.DateTime);
            // 
            // dataColSelect
            // 
            this.dataColSelect.Caption = "";
            this.dataColSelect.ColumnName = "Select";
            this.dataColSelect.DataType = typeof(bool);
            // 
            // dataColRemark
            // 
            this.dataColRemark.Caption = "备注";
            this.dataColRemark.ColumnName = "Remark";
            // 
            // dataColCodeName
            // 
            this.dataColCodeName.Caption = "零件名称";
            this.dataColCodeName.ColumnName = "CodeName";
            // 
            // dataTableProductionScheduleBom
            // 
            this.dataTableProductionScheduleBom.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColuAutoId,
            this.dataColuPsNo,
            this.dataColuCodeFileName,
            this.dataColuQty,
            this.dataColuTotalQty,
            this.dataColuCodeName});
            this.dataTableProductionScheduleBom.TableName = "ProductionScheduleBom";
            // 
            // dataColuAutoId
            // 
            this.dataColuAutoId.ColumnName = "AutoId";
            this.dataColuAutoId.DataType = typeof(int);
            // 
            // dataColuPsNo
            // 
            this.dataColuPsNo.Caption = "生产计划单号";
            this.dataColuPsNo.ColumnName = "PsNo";
            // 
            // dataColuCodeFileName
            // 
            this.dataColuCodeFileName.Caption = "零件编号";
            this.dataColuCodeFileName.ColumnName = "CodeFileName";
            // 
            // dataColuQty
            // 
            this.dataColuQty.Caption = "需求数量";
            this.dataColuQty.ColumnName = "Qty";
            this.dataColuQty.DataType = typeof(int);
            // 
            // dataColuTotalQty
            // 
            this.dataColuTotalQty.Caption = "实际使用数量";
            this.dataColuTotalQty.ColumnName = "TotalQty";
            this.dataColuTotalQty.DataType = typeof(int);
            // 
            // dataColuCodeName
            // 
            this.dataColuCodeName.Caption = "零件名称";
            this.dataColuCodeName.ColumnName = "CodeName";
            // 
            // gridViewPScheduleBOM
            // 
            this.gridViewPScheduleBOM.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId1,
            this.columnPsNo,
            this.gridColumn2,
            this.gridColumn7,
            this.colQty,
            this.colTotalQty,
            this.colDelete});
            this.gridViewPScheduleBOM.GridControl = this.gridControlPScheduleBOM;
            this.gridViewPScheduleBOM.IndicatorWidth = 40;
            this.gridViewPScheduleBOM.Name = "gridViewPScheduleBOM";
            this.gridViewPScheduleBOM.OptionsBehavior.Editable = false;
            this.gridViewPScheduleBOM.OptionsMenu.EnableColumnMenu = false;
            this.gridViewPScheduleBOM.OptionsMenu.EnableFooterMenu = false;
            this.gridViewPScheduleBOM.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewPScheduleBOM.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewPScheduleBOM.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewPScheduleBOM.OptionsView.ColumnAutoWidth = false;
            this.gridViewPScheduleBOM.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewPScheduleBOM.OptionsView.ShowFooter = true;
            this.gridViewPScheduleBOM.OptionsView.ShowGroupPanel = false;
            this.gridViewPScheduleBOM.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewPSchedule_CustomDrawRowIndicator);
            this.gridViewPScheduleBOM.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridViewPScheduleBOM_InitNewRow);
            this.gridViewPScheduleBOM.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewPScheduleBOM_CellValueChanged);
            this.gridViewPScheduleBOM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewPScheduleBOM_KeyDown);
            // 
            // colAutoId1
            // 
            this.colAutoId1.FieldName = "AutoId";
            this.colAutoId1.Name = "colAutoId1";
            // 
            // columnPsNo
            // 
            this.columnPsNo.AppearanceHeader.Options.UseTextOptions = true;
            this.columnPsNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.columnPsNo.FieldName = "PsNo";
            this.columnPsNo.Name = "columnPsNo";
            this.columnPsNo.OptionsColumn.AllowEdit = false;
            this.columnPsNo.OptionsColumn.TabStop = false;
            this.columnPsNo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "WarehouseWarrant", "共计{0}条")});
            this.columnPsNo.Visible = true;
            this.columnPsNo.VisibleIndex = 0;
            this.columnPsNo.Width = 110;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.FieldName = "CodeFileName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.TabStop = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 130;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn7.FieldName = "CodeName";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.OptionsColumn.TabStop = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 2;
            this.gridColumn7.Width = 130;
            // 
            // colQty
            // 
            this.colQty.AppearanceHeader.Options.UseTextOptions = true;
            this.colQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQty.ColumnEdit = this.repSpinQty;
            this.colQty.FieldName = "Qty";
            this.colQty.Name = "colQty";
            this.colQty.OptionsColumn.AllowEdit = false;
            this.colQty.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qty", "{0:d}")});
            this.colQty.Visible = true;
            this.colQty.VisibleIndex = 3;
            this.colQty.Width = 100;
            // 
            // repSpinQty
            // 
            this.repSpinQty.AutoHeight = false;
            this.repSpinQty.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repSpinQty.DisplayFormat.FormatString = "d";
            this.repSpinQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repSpinQty.EditFormat.FormatString = "d";
            this.repSpinQty.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repSpinQty.IsFloatValue = false;
            this.repSpinQty.Mask.EditMask = "N00";
            this.repSpinQty.MaxValue = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.repSpinQty.Name = "repSpinQty";
            // 
            // colTotalQty
            // 
            this.colTotalQty.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotalQty.ColumnEdit = this.repSpinQty;
            this.colTotalQty.FieldName = "TotalQty";
            this.colTotalQty.Name = "colTotalQty";
            this.colTotalQty.OptionsColumn.AllowEdit = false;
            this.colTotalQty.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalQty", "{0:d}")});
            this.colTotalQty.Visible = true;
            this.colTotalQty.VisibleIndex = 4;
            this.colTotalQty.Width = 100;
            // 
            // colDelete
            // 
            this.colDelete.ColumnEdit = this.repbtnDelete;
            this.colDelete.Name = "colDelete";
            this.colDelete.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.colDelete.Width = 27;
            // 
            // repbtnDelete
            // 
            this.repbtnDelete.AutoHeight = false;
            this.repbtnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.repbtnDelete.Name = "repbtnDelete";
            this.repbtnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repbtnDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repbtnDelete_ButtonClick);
            // 
            // repositoryItemSearchLookUpEdit1
            // 
            this.repositoryItemSearchLookUpEdit1.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit1.DisplayMember = "CodeFileName";
            this.repositoryItemSearchLookUpEdit1.Name = "repositoryItemSearchLookUpEdit1";
            this.repositoryItemSearchLookUpEdit1.NullText = "";
            this.repositoryItemSearchLookUpEdit1.ValueMember = "CodeFileName";
            this.repositoryItemSearchLookUpEdit1.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.IndicatorWidth = 60;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "AutoId";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.Caption = "零件编号";
            this.gridColumn5.FieldName = "CodeFileName";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            this.gridColumn5.Width = 130;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.Caption = "零件名称";
            this.gridColumn6.FieldName = "CodeName";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            this.gridColumn6.Width = 130;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterControl1.Location = new System.Drawing.Point(0, 264);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(1267, 5);
            this.splitterControl1.TabIndex = 6;
            this.splitterControl1.TabStop = false;
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.Controls.Add(this.checkAll);
            this.pnlMiddle.Controls.Add(this.gridControlPSchedule);
            this.pnlMiddle.Controls.Add(this.pnlMiddleTop);
            this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMiddle.Location = new System.Drawing.Point(0, 78);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(1267, 186);
            this.pnlMiddle.TabIndex = 3;
            // 
            // checkAll
            // 
            this.checkAll.Location = new System.Drawing.Point(53, 38);
            this.checkAll.Name = "checkAll";
            this.checkAll.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.checkAll.Properties.Appearance.Options.UseBackColor = true;
            this.checkAll.Properties.Caption = "";
            this.checkAll.Size = new System.Drawing.Size(20, 19);
            this.checkAll.TabIndex = 18;
            this.checkAll.TabStop = false;
            this.checkAll.CheckedChanged += new System.EventHandler(this.checkAll_CheckedChanged);
            // 
            // gridControlPSchedule
            // 
            this.gridControlPSchedule.AllowDrop = true;
            this.gridControlPSchedule.DataSource = this.bindingSource_PSchedule;
            this.gridControlPSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPSchedule.Location = new System.Drawing.Point(2, 36);
            this.gridControlPSchedule.MainView = this.gridViewPSchedule;
            this.gridControlPSchedule.Name = "gridControlPSchedule";
            this.gridControlPSchedule.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repCheckSelect,
            this.repSearchCodeFileName,
            this.repSpinPlannedQty});
            this.gridControlPSchedule.Size = new System.Drawing.Size(1263, 148);
            this.gridControlPSchedule.TabIndex = 3;
            this.gridControlPSchedule.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPSchedule});
            // 
            // bindingSource_PSchedule
            // 
            this.bindingSource_PSchedule.DataMember = "ProductionSchedule";
            this.bindingSource_PSchedule.DataSource = this.dataSet_PSchedule;
            // 
            // gridViewPSchedule
            // 
            this.gridViewPSchedule.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId,
            this.colSelect,
            this.colPsNo,
            this.colPsState,
            this.colCurrentDate,
            this.colCodeFileName,
            this.colCodeName,
            this.colPlannedQty,
            this.colPlannedStarttime,
            this.colPlannedEndtime,
            this.colRemark,
            this.colPrepared});
            this.gridViewPSchedule.GridControl = this.gridControlPSchedule;
            this.gridViewPSchedule.IndicatorWidth = 40;
            this.gridViewPSchedule.Name = "gridViewPSchedule";
            this.gridViewPSchedule.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewPSchedule.OptionsMenu.EnableColumnMenu = false;
            this.gridViewPSchedule.OptionsMenu.EnableFooterMenu = false;
            this.gridViewPSchedule.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewPSchedule.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewPSchedule.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewPSchedule.OptionsView.ColumnAutoWidth = false;
            this.gridViewPSchedule.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewPSchedule.OptionsView.ShowFooter = true;
            this.gridViewPSchedule.OptionsView.ShowGroupPanel = false;
            this.gridViewPSchedule.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewPSchedule_CustomDrawRowIndicator);
            this.gridViewPSchedule.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridViewPSchedule_InitNewRow);
            this.gridViewPSchedule.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewPSchedule_FocusedRowChanged);
            this.gridViewPSchedule.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewPSchedule_CellValueChanged);
            this.gridViewPSchedule.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridViewPSchedule_CustomColumnDisplayText);
            this.gridViewPSchedule.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewPSchedule_KeyDown);
            // 
            // colAutoId
            // 
            this.colAutoId.FieldName = "AutoId";
            this.colAutoId.Name = "colAutoId";
            // 
            // colSelect
            // 
            this.colSelect.ColumnEdit = this.repCheckSelect;
            this.colSelect.FieldName = "Select";
            this.colSelect.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colSelect.Name = "colSelect";
            this.colSelect.Visible = true;
            this.colSelect.VisibleIndex = 0;
            this.colSelect.Width = 35;
            // 
            // repCheckSelect
            // 
            this.repCheckSelect.AutoHeight = false;
            this.repCheckSelect.Name = "repCheckSelect";
            this.repCheckSelect.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repCheckSelect.ValueGrayed = false;
            this.repCheckSelect.EditValueChanged += new System.EventHandler(this.repCheckSelect_EditValueChanged);
            // 
            // colPsNo
            // 
            this.colPsNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colPsNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPsNo.FieldName = "PsNo";
            this.colPsNo.Name = "colPsNo";
            this.colPsNo.OptionsColumn.AllowEdit = false;
            this.colPsNo.OptionsColumn.TabStop = false;
            this.colPsNo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "PrReqNo", "共计{0}条")});
            this.colPsNo.Visible = true;
            this.colPsNo.VisibleIndex = 1;
            this.colPsNo.Width = 110;
            // 
            // colPsState
            // 
            this.colPsState.AppearanceHeader.Options.UseTextOptions = true;
            this.colPsState.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPsState.FieldName = "PsState";
            this.colPsState.Name = "colPsState";
            this.colPsState.OptionsColumn.AllowEdit = false;
            this.colPsState.OptionsColumn.TabStop = false;
            this.colPsState.Visible = true;
            this.colPsState.VisibleIndex = 2;
            this.colPsState.Width = 60;
            // 
            // colCurrentDate
            // 
            this.colCurrentDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colCurrentDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCurrentDate.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.colCurrentDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colCurrentDate.FieldName = "CurrentDate";
            this.colCurrentDate.Name = "colCurrentDate";
            this.colCurrentDate.OptionsColumn.AllowEdit = false;
            this.colCurrentDate.OptionsColumn.TabStop = false;
            this.colCurrentDate.Visible = true;
            this.colCurrentDate.VisibleIndex = 3;
            this.colCurrentDate.Width = 90;
            // 
            // colCodeFileName
            // 
            this.colCodeFileName.AppearanceHeader.Options.UseTextOptions = true;
            this.colCodeFileName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCodeFileName.ColumnEdit = this.repSearchCodeFileName;
            this.colCodeFileName.FieldName = "CodeFileName";
            this.colCodeFileName.Name = "colCodeFileName";
            this.colCodeFileName.OptionsColumn.AllowEdit = false;
            this.colCodeFileName.Visible = true;
            this.colCodeFileName.VisibleIndex = 4;
            this.colCodeFileName.Width = 130;
            // 
            // repSearchCodeFileName
            // 
            this.repSearchCodeFileName.AutoHeight = false;
            this.repSearchCodeFileName.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repSearchCodeFileName.DisplayMember = "CodeFileName";
            this.repSearchCodeFileName.Name = "repSearchCodeFileName";
            this.repSearchCodeFileName.NullText = "";
            this.repSearchCodeFileName.ValueMember = "CodeFileName";
            this.repSearchCodeFileName.View = this.repSearchCodeFileNameView;
            // 
            // repSearchCodeFileNameView
            // 
            this.repSearchCodeFileNameView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnAutoId,
            this.gridColumnCodeFileName,
            this.gridColumnCodeName});
            this.repSearchCodeFileNameView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repSearchCodeFileNameView.IndicatorWidth = 60;
            this.repSearchCodeFileNameView.Name = "repSearchCodeFileNameView";
            this.repSearchCodeFileNameView.OptionsBehavior.Editable = false;
            this.repSearchCodeFileNameView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repSearchCodeFileNameView.OptionsView.ShowGroupPanel = false;
            this.repSearchCodeFileNameView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewPSchedule_CustomDrawRowIndicator);
            // 
            // gridColumnAutoId
            // 
            this.gridColumnAutoId.Caption = "AutoId";
            this.gridColumnAutoId.FieldName = "AutoId";
            this.gridColumnAutoId.Name = "gridColumnAutoId";
            // 
            // gridColumnCodeFileName
            // 
            this.gridColumnCodeFileName.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnCodeFileName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnCodeFileName.Caption = "零件编号";
            this.gridColumnCodeFileName.FieldName = "CodeFileName";
            this.gridColumnCodeFileName.Name = "gridColumnCodeFileName";
            this.gridColumnCodeFileName.Visible = true;
            this.gridColumnCodeFileName.VisibleIndex = 0;
            this.gridColumnCodeFileName.Width = 130;
            // 
            // gridColumnCodeName
            // 
            this.gridColumnCodeName.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnCodeName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnCodeName.Caption = "零件名称";
            this.gridColumnCodeName.FieldName = "CodeName";
            this.gridColumnCodeName.Name = "gridColumnCodeName";
            this.gridColumnCodeName.Visible = true;
            this.gridColumnCodeName.VisibleIndex = 1;
            this.gridColumnCodeName.Width = 130;
            // 
            // colCodeName
            // 
            this.colCodeName.AppearanceHeader.Options.UseTextOptions = true;
            this.colCodeName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCodeName.FieldName = "CodeName";
            this.colCodeName.Name = "colCodeName";
            this.colCodeName.OptionsColumn.AllowEdit = false;
            this.colCodeName.OptionsColumn.TabStop = false;
            this.colCodeName.Visible = true;
            this.colCodeName.VisibleIndex = 5;
            this.colCodeName.Width = 130;
            // 
            // colPlannedQty
            // 
            this.colPlannedQty.AppearanceHeader.Options.UseTextOptions = true;
            this.colPlannedQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPlannedQty.ColumnEdit = this.repSpinPlannedQty;
            this.colPlannedQty.DisplayFormat.FormatString = "d";
            this.colPlannedQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPlannedQty.FieldName = "PlannedQty";
            this.colPlannedQty.Name = "colPlannedQty";
            this.colPlannedQty.OptionsColumn.AllowEdit = false;
            this.colPlannedQty.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PlannedQty", "{0:d}")});
            this.colPlannedQty.Visible = true;
            this.colPlannedQty.VisibleIndex = 6;
            this.colPlannedQty.Width = 80;
            // 
            // repSpinPlannedQty
            // 
            this.repSpinPlannedQty.AutoHeight = false;
            this.repSpinPlannedQty.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repSpinPlannedQty.DisplayFormat.FormatString = "d";
            this.repSpinPlannedQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repSpinPlannedQty.EditFormat.FormatString = "d";
            this.repSpinPlannedQty.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repSpinPlannedQty.IsFloatValue = false;
            this.repSpinPlannedQty.Mask.EditMask = "d";
            this.repSpinPlannedQty.MaxValue = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.repSpinPlannedQty.Name = "repSpinPlannedQty";
            // 
            // colPlannedStarttime
            // 
            this.colPlannedStarttime.AppearanceHeader.Options.UseTextOptions = true;
            this.colPlannedStarttime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPlannedStarttime.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.colPlannedStarttime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colPlannedStarttime.FieldName = "PlannedStarttime";
            this.colPlannedStarttime.Name = "colPlannedStarttime";
            this.colPlannedStarttime.OptionsColumn.AllowEdit = false;
            this.colPlannedStarttime.Visible = true;
            this.colPlannedStarttime.VisibleIndex = 7;
            this.colPlannedStarttime.Width = 100;
            // 
            // colPlannedEndtime
            // 
            this.colPlannedEndtime.AppearanceHeader.Options.UseTextOptions = true;
            this.colPlannedEndtime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPlannedEndtime.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.colPlannedEndtime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colPlannedEndtime.FieldName = "PlannedEndtime";
            this.colPlannedEndtime.Name = "colPlannedEndtime";
            this.colPlannedEndtime.OptionsColumn.AllowEdit = false;
            this.colPlannedEndtime.Visible = true;
            this.colPlannedEndtime.VisibleIndex = 8;
            this.colPlannedEndtime.Width = 90;
            // 
            // colRemark
            // 
            this.colRemark.AppearanceHeader.Options.UseTextOptions = true;
            this.colRemark.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.OptionsColumn.AllowEdit = false;
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 9;
            this.colRemark.Width = 140;
            // 
            // colPrepared
            // 
            this.colPrepared.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrepared.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrepared.FieldName = "Prepared";
            this.colPrepared.Name = "colPrepared";
            this.colPrepared.OptionsColumn.AllowEdit = false;
            this.colPrepared.OptionsColumn.TabStop = false;
            this.colPrepared.Visible = true;
            this.colPrepared.VisibleIndex = 10;
            this.colPrepared.Width = 70;
            // 
            // pnlMiddleTop
            // 
            this.pnlMiddleTop.Controls.Add(this.btnPreview);
            this.pnlMiddleTop.Controls.Add(this.btnCancelApprove);
            this.pnlMiddleTop.Controls.Add(this.btnApprove);
            this.pnlMiddleTop.Controls.Add(this.btnDelete);
            this.pnlMiddleTop.Controls.Add(this.btnCancel);
            this.pnlMiddleTop.Controls.Add(this.btnSave);
            this.pnlMiddleTop.Controls.Add(this.btnNew);
            this.pnlMiddleTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMiddleTop.Location = new System.Drawing.Point(2, 2);
            this.pnlMiddleTop.Name = "pnlMiddleTop";
            this.pnlMiddleTop.Size = new System.Drawing.Size(1263, 34);
            this.pnlMiddleTop.TabIndex = 2;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(491, 5);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 24;
            this.btnPreview.TabStop = false;
            this.btnPreview.Text = "预览";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnCancelApprove
            // 
            this.btnCancelApprove.Location = new System.Drawing.Point(410, 5);
            this.btnCancelApprove.Name = "btnCancelApprove";
            this.btnCancelApprove.Size = new System.Drawing.Size(75, 23);
            this.btnCancelApprove.TabIndex = 18;
            this.btnCancelApprove.TabStop = false;
            this.btnCancelApprove.Text = "取消审批";
            this.btnCancelApprove.Click += new System.EventHandler(this.btnCancelApprove_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(329, 5);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(75, 23);
            this.btnApprove.TabIndex = 14;
            this.btnApprove.TabStop = false;
            this.btnApprove.Text = "审批";
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(248, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(167, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(86, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "修改";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(5, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 10;
            this.btnNew.TabStop = false;
            this.btnNew.Text = "新增";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // pnltop
            // 
            this.pnltop.Controls.Add(this.searchLookUpCodeFileName);
            this.pnltop.Controls.Add(this.labCodeFileName);
            this.pnltop.Controls.Add(this.checkPlanDate);
            this.pnltop.Controls.Add(this.datePlanDateEnd);
            this.pnltop.Controls.Add(this.datePlanDateBegin);
            this.pnltop.Controls.Add(this.textCommon);
            this.pnltop.Controls.Add(this.comboBoxReqState);
            this.pnltop.Controls.Add(this.lookUpPrepared);
            this.pnltop.Controls.Add(this.btnQuery);
            this.pnltop.Controls.Add(this.dateCurrentDateEnd);
            this.pnltop.Controls.Add(this.dateCurrentDateBegin);
            this.pnltop.Controls.Add(this.labPlanDate);
            this.pnltop.Controls.Add(this.lab2);
            this.pnltop.Controls.Add(this.labCommon);
            this.pnltop.Controls.Add(this.labPrepared);
            this.pnltop.Controls.Add(this.labReqState);
            this.pnltop.Controls.Add(this.lab1);
            this.pnltop.Controls.Add(this.labCurrentDate);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(1267, 78);
            this.pnltop.TabIndex = 2;
            // 
            // searchLookUpCodeFileName
            // 
            this.searchLookUpCodeFileName.EnterMoveNextControl = true;
            this.searchLookUpCodeFileName.Location = new System.Drawing.Point(386, 14);
            this.searchLookUpCodeFileName.Name = "searchLookUpCodeFileName";
            this.searchLookUpCodeFileName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpCodeFileName.Properties.DisplayMember = "CodeName";
            this.searchLookUpCodeFileName.Properties.NullText = "";
            this.searchLookUpCodeFileName.Properties.ValueMember = "CodeFileName";
            this.searchLookUpCodeFileName.Properties.View = this.searchLookUpCodeFileNameView;
            this.searchLookUpCodeFileName.Size = new System.Drawing.Size(150, 20);
            this.searchLookUpCodeFileName.TabIndex = 40;
            // 
            // searchLookUpCodeFileNameView
            // 
            this.searchLookUpCodeFileNameView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn3});
            this.searchLookUpCodeFileNameView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpCodeFileNameView.IndicatorWidth = 60;
            this.searchLookUpCodeFileNameView.Name = "searchLookUpCodeFileNameView";
            this.searchLookUpCodeFileNameView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpCodeFileNameView.OptionsView.ShowGroupPanel = false;
            this.searchLookUpCodeFileNameView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewPSchedule_CustomDrawRowIndicator);
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
            // labCodeFileName
            // 
            this.labCodeFileName.Location = new System.Drawing.Point(320, 17);
            this.labCodeFileName.Name = "labCodeFileName";
            this.labCodeFileName.Size = new System.Drawing.Size(60, 14);
            this.labCodeFileName.TabIndex = 41;
            this.labCodeFileName.Text = "物料名称：";
            // 
            // checkPlanDate
            // 
            this.checkPlanDate.Location = new System.Drawing.Point(82, 44);
            this.checkPlanDate.Name = "checkPlanDate";
            this.checkPlanDate.Properties.Caption = "";
            this.checkPlanDate.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.checkPlanDate.Properties.ValueGrayed = false;
            this.checkPlanDate.Size = new System.Drawing.Size(19, 19);
            this.checkPlanDate.TabIndex = 6;
            this.checkPlanDate.TabStop = false;
            this.checkPlanDate.CheckedChanged += new System.EventHandler(this.checkPlanDate_CheckedChanged);
            // 
            // datePlanDateEnd
            // 
            this.datePlanDateEnd.EditValue = null;
            this.datePlanDateEnd.Enabled = false;
            this.datePlanDateEnd.EnterMoveNextControl = true;
            this.datePlanDateEnd.Location = new System.Drawing.Point(221, 44);
            this.datePlanDateEnd.Name = "datePlanDateEnd";
            this.datePlanDateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datePlanDateEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datePlanDateEnd.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.datePlanDateEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.datePlanDateEnd.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.datePlanDateEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.datePlanDateEnd.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.datePlanDateEnd.Size = new System.Drawing.Size(100, 20);
            this.datePlanDateEnd.TabIndex = 8;
            // 
            // datePlanDateBegin
            // 
            this.datePlanDateBegin.EditValue = null;
            this.datePlanDateBegin.Enabled = false;
            this.datePlanDateBegin.EnterMoveNextControl = true;
            this.datePlanDateBegin.Location = new System.Drawing.Point(105, 44);
            this.datePlanDateBegin.Name = "datePlanDateBegin";
            this.datePlanDateBegin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datePlanDateBegin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datePlanDateBegin.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.datePlanDateBegin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.datePlanDateBegin.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.datePlanDateBegin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.datePlanDateBegin.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.datePlanDateBegin.Size = new System.Drawing.Size(100, 20);
            this.datePlanDateBegin.TabIndex = 7;
            // 
            // textCommon
            // 
            this.textCommon.EnterMoveNextControl = true;
            this.textCommon.Location = new System.Drawing.Point(404, 44);
            this.textCommon.Name = "textCommon";
            this.textCommon.Size = new System.Drawing.Size(150, 20);
            this.textCommon.TabIndex = 11;
            // 
            // comboBoxReqState
            // 
            this.comboBoxReqState.EnterMoveNextControl = true;
            this.comboBoxReqState.Location = new System.Drawing.Point(808, 14);
            this.comboBoxReqState.Name = "comboBoxReqState";
            this.comboBoxReqState.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxReqState.Properties.Items.AddRange(new object[] {
            "全部",
            "待审批",
            "审批"});
            this.comboBoxReqState.Size = new System.Drawing.Size(120, 20);
            this.comboBoxReqState.TabIndex = 5;
            // 
            // lookUpPrepared
            // 
            this.lookUpPrepared.EnterMoveNextControl = true;
            this.lookUpPrepared.Location = new System.Drawing.Point(604, 14);
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
            this.lookUpPrepared.TabIndex = 9;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(569, 43);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 12;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dateCurrentDateEnd
            // 
            this.dateCurrentDateEnd.EditValue = null;
            this.dateCurrentDateEnd.EnterMoveNextControl = true;
            this.dateCurrentDateEnd.Location = new System.Drawing.Point(202, 14);
            this.dateCurrentDateEnd.Name = "dateCurrentDateEnd";
            this.dateCurrentDateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateCurrentDateEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateCurrentDateEnd.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dateCurrentDateEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateCurrentDateEnd.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateCurrentDateEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateCurrentDateEnd.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateCurrentDateEnd.Size = new System.Drawing.Size(100, 20);
            this.dateCurrentDateEnd.TabIndex = 1;
            // 
            // dateCurrentDateBegin
            // 
            this.dateCurrentDateBegin.EditValue = null;
            this.dateCurrentDateBegin.EnterMoveNextControl = true;
            this.dateCurrentDateBegin.Location = new System.Drawing.Point(86, 14);
            this.dateCurrentDateBegin.Name = "dateCurrentDateBegin";
            this.dateCurrentDateBegin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateCurrentDateBegin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateCurrentDateBegin.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dateCurrentDateBegin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateCurrentDateBegin.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateCurrentDateBegin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateCurrentDateBegin.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateCurrentDateBegin.Size = new System.Drawing.Size(100, 20);
            this.dateCurrentDateBegin.TabIndex = 0;
            // 
            // labPlanDate
            // 
            this.labPlanDate.Location = new System.Drawing.Point(20, 47);
            this.labPlanDate.Name = "labPlanDate";
            this.labPlanDate.Size = new System.Drawing.Size(60, 14);
            this.labPlanDate.TabIndex = 20;
            this.labPlanDate.Text = "计划日期：";
            // 
            // lab2
            // 
            this.lab2.Location = new System.Drawing.Point(211, 47);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(4, 14);
            this.lab2.TabIndex = 19;
            this.lab2.Text = "-";
            // 
            // labCommon
            // 
            this.labCommon.Location = new System.Drawing.Point(338, 47);
            this.labCommon.Name = "labCommon";
            this.labCommon.Size = new System.Drawing.Size(60, 14);
            this.labCommon.TabIndex = 14;
            this.labCommon.Text = "通用查询：";
            // 
            // labPrepared
            // 
            this.labPrepared.Location = new System.Drawing.Point(556, 17);
            this.labPrepared.Name = "labPrepared";
            this.labPrepared.Size = new System.Drawing.Size(48, 14);
            this.labPrepared.TabIndex = 11;
            this.labPrepared.Text = "制单人：";
            // 
            // labReqState
            // 
            this.labReqState.Location = new System.Drawing.Point(742, 17);
            this.labReqState.Name = "labReqState";
            this.labReqState.Size = new System.Drawing.Size(60, 14);
            this.labReqState.TabIndex = 9;
            this.labReqState.Text = "单据状态：";
            // 
            // lab1
            // 
            this.lab1.Location = new System.Drawing.Point(192, 17);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(4, 14);
            this.lab1.TabIndex = 2;
            this.lab1.Text = "-";
            // 
            // labCurrentDate
            // 
            this.labCurrentDate.Location = new System.Drawing.Point(20, 17);
            this.labCurrentDate.Name = "labCurrentDate";
            this.labCurrentDate.Size = new System.Drawing.Size(60, 14);
            this.labCurrentDate.TabIndex = 1;
            this.labCurrentDate.Text = "单据日期：";
            // 
            // FrmProductionSchedule
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1267, 615);
            this.Controls.Add(this.pnlRight);
            this.Name = "FrmProductionSchedule";
            this.TabText = "生产计划单";
            this.Text = "生产计划单";
            this.Activated += new System.EventHandler(this.FrmProductionSchedule_Activated);
            this.Load += new System.EventHandler(this.FrmProductionSchedule_Load);
            this.Shown += new System.EventHandler(this.FrmProductionSchedule_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).EndInit();
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPScheduleBOM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_PScheduleBom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_PSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableProductionSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableProductionScheduleBom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPScheduleBOM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repbtnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddle)).EndInit();
            this.pnlMiddle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_PSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchCodeFileName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchCodeFileNameView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinPlannedQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddleTop)).EndInit();
            this.pnlMiddleTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnltop)).EndInit();
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpCodeFileName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpCodeFileNameView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkPlanDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePlanDateEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePlanDateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePlanDateBegin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePlanDateBegin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCommon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxReqState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPrepared.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCurrentDateEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCurrentDateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCurrentDateBegin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCurrentDateBegin.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlRight;
        private System.Data.DataSet dataSet_PSchedule;
        private System.Data.DataTable dataTableProductionSchedule;
        private System.Data.DataColumn dataColAutoId;
        private System.Data.DataColumn dataColPsNo;
        private System.Data.DataColumn dataColCurrentDate;
        private System.Data.DataColumn dataColCodeFileName;
        private System.Data.DataColumn dataColPlannedQty;
        private System.Data.DataColumn dataColPlannedStarttime;
        private System.Data.DataColumn dataColPlannedEndtime;
        private System.Data.DataColumn dataColPrepared;
        private System.Data.DataColumn dataColPreparedIp;
        private System.Data.DataColumn dataColModifier;
        private System.Data.DataColumn dataColModifierIp;
        private System.Data.DataColumn dataColModifierTime;
        private System.Data.DataColumn dataColPsState;
        private System.Data.DataColumn dataColGetTime;
        private System.Data.DataColumn dataColSelect;
        private System.Data.DataColumn dataColRemark;
        private System.Data.DataTable dataTableProductionScheduleBom;
        private System.Data.DataColumn dataColuAutoId;
        private System.Data.DataColumn dataColuPsNo;
        private System.Data.DataColumn dataColuCodeFileName;
        private System.Data.DataColumn dataColuQty;
        private System.Data.DataColumn dataColuTotalQty;
        private System.Windows.Forms.BindingSource bindingSource_PSchedule;
        private System.Windows.Forms.BindingSource bindingSource_PScheduleBom;
        private DevExpress.XtraEditors.PanelControl pnltop;
        private DevExpress.XtraEditors.CheckEdit checkPlanDate;
        private DevExpress.XtraEditors.DateEdit datePlanDateEnd;
        private DevExpress.XtraEditors.DateEdit datePlanDateBegin;
        private DevExpress.XtraEditors.TextEdit textCommon;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxReqState;
        private DevExpress.XtraEditors.LookUpEdit lookUpPrepared;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.DateEdit dateCurrentDateEnd;
        private DevExpress.XtraEditors.DateEdit dateCurrentDateBegin;
        private DevExpress.XtraEditors.LabelControl labPlanDate;
        private DevExpress.XtraEditors.LabelControl lab2;
        private DevExpress.XtraEditors.LabelControl labCommon;
        private DevExpress.XtraEditors.LabelControl labPrepared;
        private DevExpress.XtraEditors.LabelControl labReqState;
        private DevExpress.XtraEditors.LabelControl lab1;
        private DevExpress.XtraEditors.LabelControl labCurrentDate;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpCodeFileName;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpCodeFileNameView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.LabelControl labCodeFileName;
        private DevExpress.XtraEditors.PanelControl pnlMiddle;
        private DevExpress.XtraEditors.CheckEdit checkAll;
        private DevExpress.XtraGrid.GridControl gridControlPSchedule;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPSchedule;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colSelect;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheckSelect;
        private DevExpress.XtraGrid.Columns.GridColumn colPsNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPsState;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrentDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeFileName;
        private DevExpress.XtraGrid.Columns.GridColumn colPlannedQty;
        private DevExpress.XtraGrid.Columns.GridColumn colPlannedStarttime;
        private DevExpress.XtraGrid.Columns.GridColumn colPlannedEndtime;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colPrepared;
        private DevExpress.XtraEditors.PanelControl pnlMiddleTop;
        private DevExpress.XtraEditors.SimpleButton btnPreview;
        private DevExpress.XtraEditors.SimpleButton btnCancelApprove;
        private DevExpress.XtraEditors.SimpleButton btnApprove;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.PanelControl pnlBottom;
        private System.Data.DataColumn dataColCodeName;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeName;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repSearchCodeFileName;
        private DevExpress.XtraGrid.Views.Grid.GridView repSearchCodeFileNameView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCodeFileName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCodeName;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repSpinPlannedQty;
        private System.Data.DataColumn dataColuCodeName;
        private DevExpress.XtraGrid.GridControl gridControlPScheduleBOM;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPScheduleBOM;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId1;
        private DevExpress.XtraGrid.Columns.GridColumn columnPsNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn colQty;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repSpinQty;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalQty;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repbtnDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
    }
}