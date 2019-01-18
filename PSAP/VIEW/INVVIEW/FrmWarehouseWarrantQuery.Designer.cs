namespace PSAP.VIEW.BSVIEW
{
    partial class FrmWarehouseWarrantQuery
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
            this.lookUpReqDep = new DevExpress.XtraEditors.LookUpEdit();
            this.comboBoxWarehouseState = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lookUpWarehouseWarrantTypeNo = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpRepertoryNo = new DevExpress.XtraEditors.LookUpEdit();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.textCommon = new DevExpress.XtraEditors.TextEdit();
            this.lookUpPrepared = new DevExpress.XtraEditors.LookUpEdit();
            this.searchLookUpBussinessBaseNo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpBussinessBaseNoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnBussinessBaseNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBussinessBaseText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBussinessCategoryText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateWWDateEnd = new DevExpress.XtraEditors.DateEdit();
            this.dateWWDateBegin = new DevExpress.XtraEditors.DateEdit();
            this.labReqDep = new DevExpress.XtraEditors.LabelControl();
            this.labWarehouseState = new DevExpress.XtraEditors.LabelControl();
            this.labWarehouseWarrantTypeNo = new DevExpress.XtraEditors.LabelControl();
            this.labRepertoryNo = new DevExpress.XtraEditors.LabelControl();
            this.labCommon = new DevExpress.XtraEditors.LabelControl();
            this.labPrepared = new DevExpress.XtraEditors.LabelControl();
            this.labBussinessBaseNo = new DevExpress.XtraEditors.LabelControl();
            this.lab1 = new DevExpress.XtraEditors.LabelControl();
            this.labWWDate = new DevExpress.XtraEditors.LabelControl();
            this.dataSet_WW = new System.Data.DataSet();
            this.dataTableWWHead = new System.Data.DataTable();
            this.dataColAutoId = new System.Data.DataColumn();
            this.dataColWarehouseWarrant = new System.Data.DataColumn();
            this.dataColWarehouseWarrantDate = new System.Data.DataColumn();
            this.dataColBussinessBaseNo = new System.Data.DataColumn();
            this.dataColRepertoryNo = new System.Data.DataColumn();
            this.dataColWarehouseWarrantTypeNo = new System.Data.DataColumn();
            this.dataColPrepared = new System.Data.DataColumn();
            this.dataColPreparedIp = new System.Data.DataColumn();
            this.dataColumnRemark = new System.Data.DataColumn();
            this.dataColApprovalType = new System.Data.DataColumn();
            this.dataColModifier = new System.Data.DataColumn();
            this.dataColModifierIp = new System.Data.DataColumn();
            this.dataColModifierTime = new System.Data.DataColumn();
            this.dataColWarehouseState = new System.Data.DataColumn();
            this.dataColReqDep = new System.Data.DataColumn();
            this.bindingSource_WWHead = new System.Windows.Forms.BindingSource(this.components);
            this.pnlMiddle = new DevExpress.XtraEditors.PanelControl();
            this.gridControlWWHead = new DevExpress.XtraGrid.GridControl();
            this.gridViewWWHead = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWarehouseWarrant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWarehouseState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReqDep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpReqDep = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colWarehouseWarrantDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBussinessBaseNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSearchBussinessBaseNo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridCBussinessBaseNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCBussinessBaseText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCBussinessCategoryText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRepertoryNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpRepertoryNo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colWarehouseWarrantTypeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpWWTypeNo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colApprovalType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpApprovalType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colRemark1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrepared = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCheckSelect = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.pnlBottom = new DevExpress.XtraEditors.PanelControl();
            this.gridBottomOrderHead = new PSAP.VIEW.BSVIEW.GridBottom();
            this.spinorderListAutoId = new DevExpress.XtraEditors.SpinEdit();
            this.checkorderListAutoId = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pnltop)).BeginInit();
            this.pnltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpReqDep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxWarehouseState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpWarehouseWarrantTypeNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpRepertoryNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCommon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPrepared.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpBussinessBaseNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpBussinessBaseNoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateWWDateEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateWWDateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateWWDateBegin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateWWDateBegin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_WW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableWWHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_WWHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddle)).BeginInit();
            this.pnlMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlWWHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWWHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpReqDep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchBussinessBaseNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpRepertoryNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpWWTypeNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpApprovalType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).BeginInit();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinorderListAutoId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkorderListAutoId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnltop
            // 
            this.pnltop.Controls.Add(this.spinorderListAutoId);
            this.pnltop.Controls.Add(this.checkorderListAutoId);
            this.pnltop.Controls.Add(this.btnSaveExcel);
            this.pnltop.Controls.Add(this.lookUpReqDep);
            this.pnltop.Controls.Add(this.comboBoxWarehouseState);
            this.pnltop.Controls.Add(this.lookUpWarehouseWarrantTypeNo);
            this.pnltop.Controls.Add(this.lookUpRepertoryNo);
            this.pnltop.Controls.Add(this.btnQuery);
            this.pnltop.Controls.Add(this.textCommon);
            this.pnltop.Controls.Add(this.lookUpPrepared);
            this.pnltop.Controls.Add(this.searchLookUpBussinessBaseNo);
            this.pnltop.Controls.Add(this.dateWWDateEnd);
            this.pnltop.Controls.Add(this.dateWWDateBegin);
            this.pnltop.Controls.Add(this.labReqDep);
            this.pnltop.Controls.Add(this.labWarehouseState);
            this.pnltop.Controls.Add(this.labWarehouseWarrantTypeNo);
            this.pnltop.Controls.Add(this.labRepertoryNo);
            this.pnltop.Controls.Add(this.labCommon);
            this.pnltop.Controls.Add(this.labPrepared);
            this.pnltop.Controls.Add(this.labBussinessBaseNo);
            this.pnltop.Controls.Add(this.lab1);
            this.pnltop.Controls.Add(this.labWWDate);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(1039, 78);
            this.pnltop.TabIndex = 1;
            // 
            // btnSaveExcel
            // 
            this.btnSaveExcel.Location = new System.Drawing.Point(885, 43);
            this.btnSaveExcel.Name = "btnSaveExcel";
            this.btnSaveExcel.Size = new System.Drawing.Size(75, 23);
            this.btnSaveExcel.TabIndex = 33;
            this.btnSaveExcel.Text = "存为Excel";
            this.btnSaveExcel.Click += new System.EventHandler(this.btnSaveExcel_Click);
            // 
            // lookUpReqDep
            // 
            this.lookUpReqDep.EnterMoveNextControl = true;
            this.lookUpReqDep.Location = new System.Drawing.Point(913, 14);
            this.lookUpReqDep.Name = "lookUpReqDep";
            this.lookUpReqDep.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpReqDep.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentNo", "部门编号", 95, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentName", "部门名称", 111, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpReqDep.Properties.DisplayMember = "DepartmentName";
            this.lookUpReqDep.Properties.NullText = "";
            this.lookUpReqDep.Properties.ValueMember = "DepartmentNo";
            this.lookUpReqDep.Size = new System.Drawing.Size(100, 20);
            this.lookUpReqDep.TabIndex = 5;
            // 
            // comboBoxWarehouseState
            // 
            this.comboBoxWarehouseState.EnterMoveNextControl = true;
            this.comboBoxWarehouseState.Location = new System.Drawing.Point(86, 44);
            this.comboBoxWarehouseState.Name = "comboBoxWarehouseState";
            this.comboBoxWarehouseState.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxWarehouseState.Properties.Items.AddRange(new object[] {
            "全部",
            "待审批",
            "审批",
            "已结账",
            "审批中"});
            this.comboBoxWarehouseState.Size = new System.Drawing.Size(100, 20);
            this.comboBoxWarehouseState.TabIndex = 6;
            // 
            // lookUpWarehouseWarrantTypeNo
            // 
            this.lookUpWarehouseWarrantTypeNo.EnterMoveNextControl = true;
            this.lookUpWarehouseWarrantTypeNo.Location = new System.Drawing.Point(731, 14);
            this.lookUpWarehouseWarrantTypeNo.Name = "lookUpWarehouseWarrantTypeNo";
            this.lookUpWarehouseWarrantTypeNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpWarehouseWarrantTypeNo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AutoId", "AutoId", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("WarehouseWarrantTypeNo", "类别编号"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("WarehouseWarrantTypeName", "类别名称")});
            this.lookUpWarehouseWarrantTypeNo.Properties.DisplayMember = "WarehouseWarrantTypeName";
            this.lookUpWarehouseWarrantTypeNo.Properties.NullText = "";
            this.lookUpWarehouseWarrantTypeNo.Properties.ValueMember = "WarehouseWarrantTypeNo";
            this.lookUpWarehouseWarrantTypeNo.Size = new System.Drawing.Size(100, 20);
            this.lookUpWarehouseWarrantTypeNo.TabIndex = 4;
            // 
            // lookUpRepertoryNo
            // 
            this.lookUpRepertoryNo.EnterMoveNextControl = true;
            this.lookUpRepertoryNo.Location = new System.Drawing.Point(550, 14);
            this.lookUpRepertoryNo.Name = "lookUpRepertoryNo";
            this.lookUpRepertoryNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpRepertoryNo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AutoId", "AutoId", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RepertoryNo", "仓库编号"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RepertoryName", "仓库名称"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RepertoryTypeText", "仓库类型")});
            this.lookUpRepertoryNo.Properties.DisplayMember = "RepertoryName";
            this.lookUpRepertoryNo.Properties.NullText = "";
            this.lookUpRepertoryNo.Properties.ValueMember = "RepertoryNo";
            this.lookUpRepertoryNo.Size = new System.Drawing.Size(100, 20);
            this.lookUpRepertoryNo.TabIndex = 3;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(793, 43);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 10;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // textCommon
            // 
            this.textCommon.EnterMoveNextControl = true;
            this.textCommon.Location = new System.Drawing.Point(438, 44);
            this.textCommon.Name = "textCommon";
            this.textCommon.Size = new System.Drawing.Size(150, 20);
            this.textCommon.TabIndex = 9;
            // 
            // lookUpPrepared
            // 
            this.lookUpPrepared.EnterMoveNextControl = true;
            this.lookUpPrepared.Location = new System.Drawing.Point(256, 44);
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
            this.lookUpPrepared.Size = new System.Drawing.Size(100, 20);
            this.lookUpPrepared.TabIndex = 7;
            // 
            // searchLookUpBussinessBaseNo
            // 
            this.searchLookUpBussinessBaseNo.EnterMoveNextControl = true;
            this.searchLookUpBussinessBaseNo.Location = new System.Drawing.Point(369, 14);
            this.searchLookUpBussinessBaseNo.Name = "searchLookUpBussinessBaseNo";
            this.searchLookUpBussinessBaseNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpBussinessBaseNo.Properties.DisplayMember = "BussinessBaseText";
            this.searchLookUpBussinessBaseNo.Properties.NullText = "";
            this.searchLookUpBussinessBaseNo.Properties.ValueMember = "BussinessBaseNo";
            this.searchLookUpBussinessBaseNo.Properties.View = this.searchLookUpBussinessBaseNoView;
            this.searchLookUpBussinessBaseNo.Size = new System.Drawing.Size(100, 20);
            this.searchLookUpBussinessBaseNo.TabIndex = 2;
            // 
            // searchLookUpBussinessBaseNoView
            // 
            this.searchLookUpBussinessBaseNoView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnBussinessBaseNo,
            this.gridColumnBussinessBaseText,
            this.gridColumnBussinessCategoryText,
            this.gridColumnAutoId});
            this.searchLookUpBussinessBaseNoView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpBussinessBaseNoView.IndicatorWidth = 60;
            this.searchLookUpBussinessBaseNoView.Name = "searchLookUpBussinessBaseNoView";
            this.searchLookUpBussinessBaseNoView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpBussinessBaseNoView.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnBussinessBaseNo
            // 
            this.gridColumnBussinessBaseNo.Caption = "往来方编号";
            this.gridColumnBussinessBaseNo.FieldName = "BussinessBaseNo";
            this.gridColumnBussinessBaseNo.Name = "gridColumnBussinessBaseNo";
            this.gridColumnBussinessBaseNo.Visible = true;
            this.gridColumnBussinessBaseNo.VisibleIndex = 0;
            // 
            // gridColumnBussinessBaseText
            // 
            this.gridColumnBussinessBaseText.Caption = "往来方名称";
            this.gridColumnBussinessBaseText.FieldName = "BussinessBaseText";
            this.gridColumnBussinessBaseText.Name = "gridColumnBussinessBaseText";
            this.gridColumnBussinessBaseText.Visible = true;
            this.gridColumnBussinessBaseText.VisibleIndex = 1;
            // 
            // gridColumnBussinessCategoryText
            // 
            this.gridColumnBussinessCategoryText.Caption = "往来方分类";
            this.gridColumnBussinessCategoryText.FieldName = "BussinessCategoryText";
            this.gridColumnBussinessCategoryText.Name = "gridColumnBussinessCategoryText";
            this.gridColumnBussinessCategoryText.Visible = true;
            this.gridColumnBussinessCategoryText.VisibleIndex = 2;
            // 
            // gridColumnAutoId
            // 
            this.gridColumnAutoId.Caption = "gridColumnAutoId";
            this.gridColumnAutoId.Name = "gridColumnAutoId";
            // 
            // dateWWDateEnd
            // 
            this.dateWWDateEnd.EditValue = null;
            this.dateWWDateEnd.EnterMoveNextControl = true;
            this.dateWWDateEnd.Location = new System.Drawing.Point(202, 14);
            this.dateWWDateEnd.Name = "dateWWDateEnd";
            this.dateWWDateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateWWDateEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateWWDateEnd.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dateWWDateEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateWWDateEnd.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateWWDateEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateWWDateEnd.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateWWDateEnd.Size = new System.Drawing.Size(100, 20);
            this.dateWWDateEnd.TabIndex = 1;
            // 
            // dateWWDateBegin
            // 
            this.dateWWDateBegin.EditValue = null;
            this.dateWWDateBegin.EnterMoveNextControl = true;
            this.dateWWDateBegin.Location = new System.Drawing.Point(86, 14);
            this.dateWWDateBegin.Name = "dateWWDateBegin";
            this.dateWWDateBegin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateWWDateBegin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateWWDateBegin.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dateWWDateBegin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateWWDateBegin.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateWWDateBegin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateWWDateBegin.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateWWDateBegin.Size = new System.Drawing.Size(100, 20);
            this.dateWWDateBegin.TabIndex = 0;
            // 
            // labReqDep
            // 
            this.labReqDep.Location = new System.Drawing.Point(847, 17);
            this.labReqDep.Name = "labReqDep";
            this.labReqDep.Size = new System.Drawing.Size(60, 14);
            this.labReqDep.TabIndex = 32;
            this.labReqDep.Text = "入库部门：";
            // 
            // labWarehouseState
            // 
            this.labWarehouseState.Location = new System.Drawing.Point(20, 47);
            this.labWarehouseState.Name = "labWarehouseState";
            this.labWarehouseState.Size = new System.Drawing.Size(60, 14);
            this.labWarehouseState.TabIndex = 30;
            this.labWarehouseState.Text = "单据状态：";
            // 
            // labWarehouseWarrantTypeNo
            // 
            this.labWarehouseWarrantTypeNo.Location = new System.Drawing.Point(665, 17);
            this.labWarehouseWarrantTypeNo.Name = "labWarehouseWarrantTypeNo";
            this.labWarehouseWarrantTypeNo.Size = new System.Drawing.Size(60, 14);
            this.labWarehouseWarrantTypeNo.TabIndex = 28;
            this.labWarehouseWarrantTypeNo.Text = "入库类别：";
            // 
            // labRepertoryNo
            // 
            this.labRepertoryNo.Location = new System.Drawing.Point(484, 17);
            this.labRepertoryNo.Name = "labRepertoryNo";
            this.labRepertoryNo.Size = new System.Drawing.Size(60, 14);
            this.labRepertoryNo.TabIndex = 26;
            this.labRepertoryNo.Text = "入库仓库：";
            // 
            // labCommon
            // 
            this.labCommon.Location = new System.Drawing.Point(372, 47);
            this.labCommon.Name = "labCommon";
            this.labCommon.Size = new System.Drawing.Size(60, 14);
            this.labCommon.TabIndex = 22;
            this.labCommon.Text = "通用查询：";
            // 
            // labPrepared
            // 
            this.labPrepared.Location = new System.Drawing.Point(202, 47);
            this.labPrepared.Name = "labPrepared";
            this.labPrepared.Size = new System.Drawing.Size(48, 14);
            this.labPrepared.TabIndex = 20;
            this.labPrepared.Text = "制单人：";
            // 
            // labBussinessBaseNo
            // 
            this.labBussinessBaseNo.Location = new System.Drawing.Point(315, 17);
            this.labBussinessBaseNo.Name = "labBussinessBaseNo";
            this.labBussinessBaseNo.Size = new System.Drawing.Size(48, 14);
            this.labBussinessBaseNo.TabIndex = 18;
            this.labBussinessBaseNo.Text = "供应商：";
            // 
            // lab1
            // 
            this.lab1.Location = new System.Drawing.Point(192, 17);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(4, 14);
            this.lab1.TabIndex = 6;
            this.lab1.Text = "-";
            // 
            // labWWDate
            // 
            this.labWWDate.Location = new System.Drawing.Point(20, 17);
            this.labWWDate.Name = "labWWDate";
            this.labWWDate.Size = new System.Drawing.Size(60, 14);
            this.labWWDate.TabIndex = 5;
            this.labWWDate.Text = "入库日期：";
            // 
            // dataSet_WW
            // 
            this.dataSet_WW.DataSetName = "NewDataSet";
            this.dataSet_WW.EnforceConstraints = false;
            this.dataSet_WW.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTableWWHead});
            // 
            // dataTableWWHead
            // 
            this.dataTableWWHead.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColAutoId,
            this.dataColWarehouseWarrant,
            this.dataColWarehouseWarrantDate,
            this.dataColBussinessBaseNo,
            this.dataColRepertoryNo,
            this.dataColWarehouseWarrantTypeNo,
            this.dataColPrepared,
            this.dataColPreparedIp,
            this.dataColumnRemark,
            this.dataColApprovalType,
            this.dataColModifier,
            this.dataColModifierIp,
            this.dataColModifierTime,
            this.dataColWarehouseState,
            this.dataColReqDep});
            this.dataTableWWHead.TableName = "WWHead";
            // 
            // dataColAutoId
            // 
            this.dataColAutoId.ColumnName = "AutoId";
            this.dataColAutoId.DataType = typeof(int);
            // 
            // dataColWarehouseWarrant
            // 
            this.dataColWarehouseWarrant.Caption = "入库单号";
            this.dataColWarehouseWarrant.ColumnName = "WarehouseWarrant";
            // 
            // dataColWarehouseWarrantDate
            // 
            this.dataColWarehouseWarrantDate.Caption = "入库日期";
            this.dataColWarehouseWarrantDate.ColumnName = "WarehouseWarrantDate";
            this.dataColWarehouseWarrantDate.DataType = typeof(System.DateTime);
            // 
            // dataColBussinessBaseNo
            // 
            this.dataColBussinessBaseNo.Caption = "供应商";
            this.dataColBussinessBaseNo.ColumnName = "BussinessBaseNo";
            // 
            // dataColRepertoryNo
            // 
            this.dataColRepertoryNo.Caption = "入库仓库";
            this.dataColRepertoryNo.ColumnName = "RepertoryNo";
            // 
            // dataColWarehouseWarrantTypeNo
            // 
            this.dataColWarehouseWarrantTypeNo.Caption = "入库类别";
            this.dataColWarehouseWarrantTypeNo.ColumnName = "WarehouseWarrantTypeNo";
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
            // dataColumnRemark
            // 
            this.dataColumnRemark.Caption = "备注";
            this.dataColumnRemark.ColumnName = "Remark";
            // 
            // dataColApprovalType
            // 
            this.dataColApprovalType.Caption = "审核类型";
            this.dataColApprovalType.ColumnName = "ApprovalType";
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
            // dataColWarehouseState
            // 
            this.dataColWarehouseState.Caption = "状态";
            this.dataColWarehouseState.ColumnName = "WarehouseState";
            this.dataColWarehouseState.DataType = typeof(int);
            // 
            // dataColReqDep
            // 
            this.dataColReqDep.Caption = "入库部门";
            this.dataColReqDep.ColumnName = "ReqDep";
            // 
            // bindingSource_WWHead
            // 
            this.bindingSource_WWHead.DataMember = "WWHead";
            this.bindingSource_WWHead.DataSource = this.dataSet_WW;
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.Controls.Add(this.gridControlWWHead);
            this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMiddle.Location = new System.Drawing.Point(0, 78);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(1039, 311);
            this.pnlMiddle.TabIndex = 6;
            // 
            // gridControlWWHead
            // 
            this.gridControlWWHead.DataSource = this.bindingSource_WWHead;
            this.gridControlWWHead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlWWHead.Location = new System.Drawing.Point(2, 2);
            this.gridControlWWHead.MainView = this.gridViewWWHead;
            this.gridControlWWHead.Name = "gridControlWWHead";
            this.gridControlWWHead.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repLookUpRepertoryNo,
            this.repLookUpWWTypeNo,
            this.repSearchBussinessBaseNo,
            this.repCheckSelect,
            this.repLookUpApprovalType,
            this.repLookUpReqDep});
            this.gridControlWWHead.Size = new System.Drawing.Size(1035, 307);
            this.gridControlWWHead.TabIndex = 4;
            this.gridControlWWHead.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewWWHead});
            // 
            // gridViewWWHead
            // 
            this.gridViewWWHead.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId,
            this.colWarehouseWarrant,
            this.colWarehouseState,
            this.colReqDep,
            this.colWarehouseWarrantDate,
            this.colBussinessBaseNo,
            this.colRepertoryNo,
            this.colWarehouseWarrantTypeNo,
            this.colApprovalType,
            this.colRemark1,
            this.colPrepared,
            this.colModifier});
            this.gridViewWWHead.GridControl = this.gridControlWWHead;
            this.gridViewWWHead.IndicatorWidth = 40;
            this.gridViewWWHead.Name = "gridViewWWHead";
            this.gridViewWWHead.OptionsBehavior.Editable = false;
            this.gridViewWWHead.OptionsBehavior.ReadOnly = true;
            this.gridViewWWHead.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewWWHead.OptionsView.ColumnAutoWidth = false;
            this.gridViewWWHead.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewWWHead.OptionsView.ShowFooter = true;
            this.gridViewWWHead.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewWWHead_RowClick);
            this.gridViewWWHead.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewWWHead_CustomDrawRowIndicator);
            this.gridViewWWHead.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridViewWWHead_CustomColumnDisplayText);
            // 
            // colAutoId
            // 
            this.colAutoId.FieldName = "AutoId";
            this.colAutoId.Name = "colAutoId";
            // 
            // colWarehouseWarrant
            // 
            this.colWarehouseWarrant.AppearanceHeader.Options.UseTextOptions = true;
            this.colWarehouseWarrant.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWarehouseWarrant.FieldName = "WarehouseWarrant";
            this.colWarehouseWarrant.Name = "colWarehouseWarrant";
            this.colWarehouseWarrant.OptionsColumn.AllowEdit = false;
            this.colWarehouseWarrant.OptionsColumn.AllowFocus = false;
            this.colWarehouseWarrant.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "WarehouseWarrant", "共计{0}条")});
            this.colWarehouseWarrant.Visible = true;
            this.colWarehouseWarrant.VisibleIndex = 0;
            this.colWarehouseWarrant.Width = 110;
            // 
            // colWarehouseState
            // 
            this.colWarehouseState.AppearanceHeader.Options.UseTextOptions = true;
            this.colWarehouseState.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWarehouseState.FieldName = "WarehouseState";
            this.colWarehouseState.Name = "colWarehouseState";
            this.colWarehouseState.OptionsColumn.AllowEdit = false;
            this.colWarehouseState.OptionsColumn.AllowFocus = false;
            this.colWarehouseState.Visible = true;
            this.colWarehouseState.VisibleIndex = 1;
            this.colWarehouseState.Width = 60;
            // 
            // colReqDep
            // 
            this.colReqDep.AppearanceHeader.Options.UseTextOptions = true;
            this.colReqDep.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colReqDep.ColumnEdit = this.repLookUpReqDep;
            this.colReqDep.FieldName = "ReqDep";
            this.colReqDep.Name = "colReqDep";
            this.colReqDep.OptionsColumn.AllowEdit = false;
            this.colReqDep.OptionsColumn.AllowFocus = false;
            this.colReqDep.Visible = true;
            this.colReqDep.VisibleIndex = 7;
            this.colReqDep.Width = 110;
            // 
            // repLookUpReqDep
            // 
            this.repLookUpReqDep.AutoHeight = false;
            this.repLookUpReqDep.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpReqDep.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AutoId", "AutoId", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentNo", "部门编号"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentName", "部门名称")});
            this.repLookUpReqDep.DisplayMember = "DepartmentName";
            this.repLookUpReqDep.Name = "repLookUpReqDep";
            this.repLookUpReqDep.NullText = "";
            this.repLookUpReqDep.ValueMember = "DepartmentNo";
            // 
            // colWarehouseWarrantDate
            // 
            this.colWarehouseWarrantDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colWarehouseWarrantDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWarehouseWarrantDate.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.colWarehouseWarrantDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colWarehouseWarrantDate.FieldName = "WarehouseWarrantDate";
            this.colWarehouseWarrantDate.Name = "colWarehouseWarrantDate";
            this.colWarehouseWarrantDate.OptionsColumn.AllowEdit = false;
            this.colWarehouseWarrantDate.OptionsColumn.AllowFocus = false;
            this.colWarehouseWarrantDate.Visible = true;
            this.colWarehouseWarrantDate.VisibleIndex = 3;
            this.colWarehouseWarrantDate.Width = 90;
            // 
            // colBussinessBaseNo
            // 
            this.colBussinessBaseNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colBussinessBaseNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBussinessBaseNo.ColumnEdit = this.repSearchBussinessBaseNo;
            this.colBussinessBaseNo.FieldName = "BussinessBaseNo";
            this.colBussinessBaseNo.Name = "colBussinessBaseNo";
            this.colBussinessBaseNo.OptionsColumn.AllowEdit = false;
            this.colBussinessBaseNo.OptionsColumn.AllowFocus = false;
            this.colBussinessBaseNo.Visible = true;
            this.colBussinessBaseNo.VisibleIndex = 2;
            this.colBussinessBaseNo.Width = 100;
            // 
            // repSearchBussinessBaseNo
            // 
            this.repSearchBussinessBaseNo.AutoHeight = false;
            this.repSearchBussinessBaseNo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repSearchBussinessBaseNo.DisplayMember = "BussinessBaseText";
            this.repSearchBussinessBaseNo.Name = "repSearchBussinessBaseNo";
            this.repSearchBussinessBaseNo.NullText = "";
            this.repSearchBussinessBaseNo.ValueMember = "BussinessBaseNo";
            this.repSearchBussinessBaseNo.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridCBussinessBaseNo,
            this.gridCBussinessBaseText,
            this.gridCBussinessCategoryText,
            this.gridCAutoId});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.IndicatorWidth = 60;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridCBussinessBaseNo
            // 
            this.gridCBussinessBaseNo.Caption = "往来方编号";
            this.gridCBussinessBaseNo.FieldName = "BussinessBaseNo";
            this.gridCBussinessBaseNo.Name = "gridCBussinessBaseNo";
            this.gridCBussinessBaseNo.Visible = true;
            this.gridCBussinessBaseNo.VisibleIndex = 0;
            // 
            // gridCBussinessBaseText
            // 
            this.gridCBussinessBaseText.Caption = "往来方名称";
            this.gridCBussinessBaseText.FieldName = "BussinessBaseText";
            this.gridCBussinessBaseText.Name = "gridCBussinessBaseText";
            this.gridCBussinessBaseText.Visible = true;
            this.gridCBussinessBaseText.VisibleIndex = 1;
            // 
            // gridCBussinessCategoryText
            // 
            this.gridCBussinessCategoryText.Caption = "往来方分类";
            this.gridCBussinessCategoryText.FieldName = "BussinessCategoryText";
            this.gridCBussinessCategoryText.Name = "gridCBussinessCategoryText";
            this.gridCBussinessCategoryText.Visible = true;
            this.gridCBussinessCategoryText.VisibleIndex = 2;
            // 
            // gridCAutoId
            // 
            this.gridCAutoId.Caption = "AutoId";
            this.gridCAutoId.FieldName = "AutoId";
            this.gridCAutoId.Name = "gridCAutoId";
            // 
            // colRepertoryNo
            // 
            this.colRepertoryNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colRepertoryNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRepertoryNo.ColumnEdit = this.repLookUpRepertoryNo;
            this.colRepertoryNo.FieldName = "RepertoryNo";
            this.colRepertoryNo.Name = "colRepertoryNo";
            this.colRepertoryNo.OptionsColumn.AllowEdit = false;
            this.colRepertoryNo.Visible = true;
            this.colRepertoryNo.VisibleIndex = 4;
            this.colRepertoryNo.Width = 100;
            // 
            // repLookUpRepertoryNo
            // 
            this.repLookUpRepertoryNo.AutoHeight = false;
            this.repLookUpRepertoryNo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpRepertoryNo.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RepertoryNo", "仓库编号"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RepertoryName", "仓库名称"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RepertoryTypeText", "仓库类型")});
            this.repLookUpRepertoryNo.DisplayMember = "RepertoryName";
            this.repLookUpRepertoryNo.Name = "repLookUpRepertoryNo";
            this.repLookUpRepertoryNo.NullText = "";
            this.repLookUpRepertoryNo.ValueMember = "RepertoryNo";
            // 
            // colWarehouseWarrantTypeNo
            // 
            this.colWarehouseWarrantTypeNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colWarehouseWarrantTypeNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWarehouseWarrantTypeNo.ColumnEdit = this.repLookUpWWTypeNo;
            this.colWarehouseWarrantTypeNo.FieldName = "WarehouseWarrantTypeNo";
            this.colWarehouseWarrantTypeNo.Name = "colWarehouseWarrantTypeNo";
            this.colWarehouseWarrantTypeNo.OptionsColumn.AllowEdit = false;
            this.colWarehouseWarrantTypeNo.Visible = true;
            this.colWarehouseWarrantTypeNo.VisibleIndex = 5;
            this.colWarehouseWarrantTypeNo.Width = 100;
            // 
            // repLookUpWWTypeNo
            // 
            this.repLookUpWWTypeNo.AutoHeight = false;
            this.repLookUpWWTypeNo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpWWTypeNo.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("WarehouseWarrantTypeNo", "类别编号", 81, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("WarehouseWarrantTypeName", "类别名称", 111, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repLookUpWWTypeNo.DisplayMember = "WarehouseWarrantTypeName";
            this.repLookUpWWTypeNo.Name = "repLookUpWWTypeNo";
            this.repLookUpWWTypeNo.NullText = "";
            this.repLookUpWWTypeNo.ValueMember = "WarehouseWarrantTypeNo";
            // 
            // colApprovalType
            // 
            this.colApprovalType.AppearanceHeader.Options.UseTextOptions = true;
            this.colApprovalType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colApprovalType.ColumnEdit = this.repLookUpApprovalType;
            this.colApprovalType.FieldName = "ApprovalType";
            this.colApprovalType.Name = "colApprovalType";
            this.colApprovalType.OptionsColumn.AllowEdit = false;
            this.colApprovalType.Visible = true;
            this.colApprovalType.VisibleIndex = 6;
            this.colApprovalType.Width = 100;
            // 
            // repLookUpApprovalType
            // 
            this.repLookUpApprovalType.AutoHeight = false;
            this.repLookUpApprovalType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpApprovalType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AutoId", "AutoId", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TypeNo", "审批类型"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TypeNoText", "审批名称"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ApprovalText", "审批方式")});
            this.repLookUpApprovalType.DisplayMember = "TypeNoText";
            this.repLookUpApprovalType.Name = "repLookUpApprovalType";
            this.repLookUpApprovalType.NullText = "";
            this.repLookUpApprovalType.ValueMember = "TypeNo";
            // 
            // colRemark1
            // 
            this.colRemark1.AppearanceHeader.Options.UseTextOptions = true;
            this.colRemark1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRemark1.FieldName = "Remark";
            this.colRemark1.Name = "colRemark1";
            this.colRemark1.OptionsColumn.AllowEdit = false;
            this.colRemark1.Visible = true;
            this.colRemark1.VisibleIndex = 8;
            this.colRemark1.Width = 100;
            // 
            // colPrepared
            // 
            this.colPrepared.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrepared.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrepared.FieldName = "Prepared";
            this.colPrepared.Name = "colPrepared";
            this.colPrepared.OptionsColumn.AllowEdit = false;
            this.colPrepared.OptionsColumn.AllowFocus = false;
            this.colPrepared.Visible = true;
            this.colPrepared.VisibleIndex = 9;
            this.colPrepared.Width = 70;
            // 
            // colModifier
            // 
            this.colModifier.AppearanceHeader.Options.UseTextOptions = true;
            this.colModifier.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colModifier.FieldName = "Modifier";
            this.colModifier.Name = "colModifier";
            this.colModifier.OptionsColumn.AllowEdit = false;
            this.colModifier.OptionsColumn.AllowFocus = false;
            this.colModifier.Visible = true;
            this.colModifier.VisibleIndex = 10;
            this.colModifier.Width = 70;
            // 
            // repCheckSelect
            // 
            this.repCheckSelect.AutoHeight = false;
            this.repCheckSelect.Name = "repCheckSelect";
            this.repCheckSelect.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repCheckSelect.ValueGrayed = false;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.gridBottomOrderHead);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 389);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1039, 58);
            this.pnlBottom.TabIndex = 5;
            // 
            // gridBottomOrderHead
            // 
            this.gridBottomOrderHead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBottomOrderHead.Location = new System.Drawing.Point(2, 2);
            this.gridBottomOrderHead.MasterDataSet = this.dataSet_WW;
            this.gridBottomOrderHead.Name = "gridBottomOrderHead";
            this.gridBottomOrderHead.pageRowCount = 5;
            this.gridBottomOrderHead.Size = new System.Drawing.Size(1035, 54);
            this.gridBottomOrderHead.TabIndex = 0;
            // 
            // spinorderListAutoId
            // 
            this.spinorderListAutoId.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinorderListAutoId.Enabled = false;
            this.spinorderListAutoId.EnterMoveNextControl = true;
            this.spinorderListAutoId.Location = new System.Drawing.Point(709, 44);
            this.spinorderListAutoId.Name = "spinorderListAutoId";
            this.spinorderListAutoId.Properties.Mask.EditMask = "d";
            this.spinorderListAutoId.Size = new System.Drawing.Size(66, 20);
            this.spinorderListAutoId.TabIndex = 35;
            this.spinorderListAutoId.TabStop = false;
            // 
            // checkorderListAutoId
            // 
            this.checkorderListAutoId.EnterMoveNextControl = true;
            this.checkorderListAutoId.Location = new System.Drawing.Point(603, 44);
            this.checkorderListAutoId.Name = "checkorderListAutoId";
            this.checkorderListAutoId.Properties.Caption = "采购单明细ID";
            this.checkorderListAutoId.Size = new System.Drawing.Size(100, 19);
            this.checkorderListAutoId.TabIndex = 34;
            this.checkorderListAutoId.TabStop = false;
            this.checkorderListAutoId.CheckedChanged += new System.EventHandler(this.checkorderListAutoId_CheckedChanged);
            // 
            // FrmWarehouseWarrantQuery
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1039, 447);
            this.Controls.Add(this.pnlMiddle);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnltop);
            this.Name = "FrmWarehouseWarrantQuery";
            this.TabText = "入库单查询";
            this.Text = "入库单查询";
            this.Activated += new System.EventHandler(this.FrmWarehouseWarrantQuery_Activated);
            this.Load += new System.EventHandler(this.FrmWarehouseWarrantQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnltop)).EndInit();
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpReqDep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxWarehouseState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpWarehouseWarrantTypeNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpRepertoryNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCommon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPrepared.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpBussinessBaseNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpBussinessBaseNoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateWWDateEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateWWDateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateWWDateBegin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateWWDateBegin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_WW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableWWHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_WWHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddle)).EndInit();
            this.pnlMiddle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlWWHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWWHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpReqDep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchBussinessBaseNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpRepertoryNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpWWTypeNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpApprovalType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spinorderListAutoId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkorderListAutoId.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnltop;
        private DevExpress.XtraEditors.LookUpEdit lookUpReqDep;
        private DevExpress.XtraEditors.LabelControl labReqDep;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxWarehouseState;
        private DevExpress.XtraEditors.LabelControl labWarehouseState;
        private DevExpress.XtraEditors.LookUpEdit lookUpWarehouseWarrantTypeNo;
        private DevExpress.XtraEditors.LabelControl labWarehouseWarrantTypeNo;
        private DevExpress.XtraEditors.LookUpEdit lookUpRepertoryNo;
        private DevExpress.XtraEditors.LabelControl labRepertoryNo;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.TextEdit textCommon;
        private DevExpress.XtraEditors.LabelControl labCommon;
        private DevExpress.XtraEditors.LabelControl labPrepared;
        private DevExpress.XtraEditors.LookUpEdit lookUpPrepared;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpBussinessBaseNo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpBussinessBaseNoView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBussinessBaseNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBussinessBaseText;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBussinessCategoryText;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnAutoId;
        private DevExpress.XtraEditors.LabelControl labBussinessBaseNo;
        private DevExpress.XtraEditors.DateEdit dateWWDateEnd;
        private DevExpress.XtraEditors.LabelControl lab1;
        private DevExpress.XtraEditors.LabelControl labWWDate;
        private DevExpress.XtraEditors.DateEdit dateWWDateBegin;
        private System.Data.DataSet dataSet_WW;
        private System.Data.DataTable dataTableWWHead;
        private System.Data.DataColumn dataColAutoId;
        private System.Data.DataColumn dataColWarehouseWarrant;
        private System.Data.DataColumn dataColWarehouseWarrantDate;
        private System.Data.DataColumn dataColBussinessBaseNo;
        private System.Data.DataColumn dataColRepertoryNo;
        private System.Data.DataColumn dataColWarehouseWarrantTypeNo;
        private System.Data.DataColumn dataColPrepared;
        private System.Data.DataColumn dataColPreparedIp;
        private System.Data.DataColumn dataColumnRemark;
        private System.Data.DataColumn dataColApprovalType;
        private System.Data.DataColumn dataColModifier;
        private System.Data.DataColumn dataColModifierIp;
        private System.Data.DataColumn dataColModifierTime;
        private System.Data.DataColumn dataColWarehouseState;
        private System.Data.DataColumn dataColReqDep;
        private System.Windows.Forms.BindingSource bindingSource_WWHead;
        private DevExpress.XtraEditors.PanelControl pnlMiddle;
        private DevExpress.XtraGrid.GridControl gridControlWWHead;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewWWHead;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheckSelect;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouseWarrant;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouseState;
        private DevExpress.XtraGrid.Columns.GridColumn colReqDep;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpReqDep;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouseWarrantDate;
        private DevExpress.XtraGrid.Columns.GridColumn colBussinessBaseNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repSearchBussinessBaseNo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridCBussinessBaseNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridCBussinessBaseText;
        private DevExpress.XtraGrid.Columns.GridColumn gridCBussinessCategoryText;
        private DevExpress.XtraGrid.Columns.GridColumn gridCAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colRepertoryNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpRepertoryNo;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouseWarrantTypeNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpWWTypeNo;
        private DevExpress.XtraGrid.Columns.GridColumn colApprovalType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpApprovalType;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark1;
        private DevExpress.XtraGrid.Columns.GridColumn colPrepared;
        private DevExpress.XtraGrid.Columns.GridColumn colModifier;
        private DevExpress.XtraEditors.SimpleButton btnSaveExcel;
        private DevExpress.XtraEditors.PanelControl pnlBottom;
        private GridBottom gridBottomOrderHead;
        private DevExpress.XtraEditors.SpinEdit spinorderListAutoId;
        private DevExpress.XtraEditors.CheckEdit checkorderListAutoId;
    }
}