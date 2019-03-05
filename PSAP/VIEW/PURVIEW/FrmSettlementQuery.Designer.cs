namespace PSAP.VIEW.BSVIEW
{
    partial class FrmSettlementQuery
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
            this.spinwwListAutoId = new DevExpress.XtraEditors.SpinEdit();
            this.checkwwListAutoId = new DevExpress.XtraEditors.CheckEdit();
            this.btnSaveExcel = new DevExpress.XtraEditors.SimpleButton();
            this.checkPayDate = new DevExpress.XtraEditors.CheckEdit();
            this.datePayDateEnd = new DevExpress.XtraEditors.DateEdit();
            this.datePayDateBegin = new DevExpress.XtraEditors.DateEdit();
            this.labPayDate = new DevExpress.XtraEditors.LabelControl();
            this.lab2 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpReqDep = new DevExpress.XtraEditors.LookUpEdit();
            this.comboBoxWarehouseState = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.textCommon = new DevExpress.XtraEditors.TextEdit();
            this.lookUpPrepared = new DevExpress.XtraEditors.LookUpEdit();
            this.searchLookUpBussinessBaseNo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpBussinessBaseNoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnBussinessBaseNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBussinessBaseText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBussinessCategoryText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateSettlementDateEnd = new DevExpress.XtraEditors.DateEdit();
            this.lab1 = new DevExpress.XtraEditors.LabelControl();
            this.dateSettlementDateBegin = new DevExpress.XtraEditors.DateEdit();
            this.labReqDep = new DevExpress.XtraEditors.LabelControl();
            this.labCommon = new DevExpress.XtraEditors.LabelControl();
            this.labPrepared = new DevExpress.XtraEditors.LabelControl();
            this.labBussinessBaseNo = new DevExpress.XtraEditors.LabelControl();
            this.labWarehouseState = new DevExpress.XtraEditors.LabelControl();
            this.labSettlementDate = new DevExpress.XtraEditors.LabelControl();
            this.dataSet_Settlement = new System.Data.DataSet();
            this.dataTableSettlementHead = new System.Data.DataTable();
            this.dataColAutoId = new System.Data.DataColumn();
            this.dataColSettlementNo = new System.Data.DataColumn();
            this.dataColInvoiceNo = new System.Data.DataColumn();
            this.dataColSettlementDate = new System.Data.DataColumn();
            this.dataColReqDep = new System.Data.DataColumn();
            this.dataColBussinessBaseNo = new System.Data.DataColumn();
            this.dataColTax = new System.Data.DataColumn();
            this.dataColPayDate = new System.Data.DataColumn();
            this.dataColIsVoucher = new System.Data.DataColumn();
            this.dataColPrepared = new System.Data.DataColumn();
            this.dataColPreparedIp = new System.Data.DataColumn();
            this.dataColModifierIp = new System.Data.DataColumn();
            this.dataColModifierTime = new System.Data.DataColumn();
            this.dataColRemark = new System.Data.DataColumn();
            this.dataColWarehouseState = new System.Data.DataColumn();
            this.dataColApprovalType = new System.Data.DataColumn();
            this.dataColModifier = new System.Data.DataColumn();
            this.bindingSource_SettlementHead = new System.Windows.Forms.BindingSource(this.components);
            this.pnlBottom = new DevExpress.XtraEditors.PanelControl();
            this.gridBottomOrderHead = new PSAP.VIEW.BSVIEW.GridBottom();
            this.gridControlSettlementHead = new DevExpress.XtraGrid.GridControl();
            this.gridViewSettlementHead = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSettlementNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWarehouseState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSettlementDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReqDep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpReqDep = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colBussinessBaseNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSearchBussinessBaseNo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridCBussinessBaseNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCBussinessBaseText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCBussinessCategoryText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSpinTax = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colPayDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApprovalType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpApprovalType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colIsVoucher = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCheckIsVoucher = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrepared = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCheckSelect = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.pnlMiddle = new DevExpress.XtraEditors.PanelControl();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCtjz = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCtjh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiJzrqbnwk = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFkrqbnwk = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCxan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCxjgcw = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSjcx = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pnltop)).BeginInit();
            this.pnltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinwwListAutoId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkwwListAutoId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkPayDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePayDateEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePayDateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePayDateBegin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePayDateBegin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpReqDep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxWarehouseState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCommon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPrepared.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpBussinessBaseNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpBussinessBaseNoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSettlementDateEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSettlementDateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSettlementDateBegin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSettlementDateBegin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Settlement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableSettlementHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_SettlementHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).BeginInit();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSettlementHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSettlementHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpReqDep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchBussinessBaseNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpApprovalType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckIsVoucher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddle)).BeginInit();
            this.pnlMiddle.SuspendLayout();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnltop
            // 
            this.pnltop.Controls.Add(this.spinwwListAutoId);
            this.pnltop.Controls.Add(this.checkwwListAutoId);
            this.pnltop.Controls.Add(this.btnSaveExcel);
            this.pnltop.Controls.Add(this.checkPayDate);
            this.pnltop.Controls.Add(this.datePayDateEnd);
            this.pnltop.Controls.Add(this.datePayDateBegin);
            this.pnltop.Controls.Add(this.labPayDate);
            this.pnltop.Controls.Add(this.lab2);
            this.pnltop.Controls.Add(this.lookUpReqDep);
            this.pnltop.Controls.Add(this.comboBoxWarehouseState);
            this.pnltop.Controls.Add(this.btnQuery);
            this.pnltop.Controls.Add(this.textCommon);
            this.pnltop.Controls.Add(this.lookUpPrepared);
            this.pnltop.Controls.Add(this.searchLookUpBussinessBaseNo);
            this.pnltop.Controls.Add(this.dateSettlementDateEnd);
            this.pnltop.Controls.Add(this.lab1);
            this.pnltop.Controls.Add(this.dateSettlementDateBegin);
            this.pnltop.Controls.Add(this.labReqDep);
            this.pnltop.Controls.Add(this.labCommon);
            this.pnltop.Controls.Add(this.labPrepared);
            this.pnltop.Controls.Add(this.labBussinessBaseNo);
            this.pnltop.Controls.Add(this.labWarehouseState);
            this.pnltop.Controls.Add(this.labSettlementDate);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Margin = new System.Windows.Forms.Padding(4);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(1144, 78);
            this.pnltop.TabIndex = 2;
            // 
            // spinwwListAutoId
            // 
            this.spinwwListAutoId.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinwwListAutoId.Enabled = false;
            this.spinwwListAutoId.EnterMoveNextControl = true;
            this.spinwwListAutoId.Location = new System.Drawing.Point(690, 44);
            this.spinwwListAutoId.Name = "spinwwListAutoId";
            this.spinwwListAutoId.Properties.Mask.EditMask = "d";
            this.spinwwListAutoId.Size = new System.Drawing.Size(80, 20);
            this.spinwwListAutoId.TabIndex = 11;
            this.spinwwListAutoId.TabStop = false;
            // 
            // checkwwListAutoId
            // 
            this.checkwwListAutoId.EnterMoveNextControl = true;
            this.checkwwListAutoId.Location = new System.Drawing.Point(584, 44);
            this.checkwwListAutoId.Name = "checkwwListAutoId";
            this.checkwwListAutoId.Properties.Caption = "入库单明细ID";
            this.checkwwListAutoId.Size = new System.Drawing.Size(100, 19);
            this.checkwwListAutoId.TabIndex = 10;
            this.checkwwListAutoId.TabStop = false;
            this.checkwwListAutoId.CheckedChanged += new System.EventHandler(this.checkwwListAutoId_CheckedChanged);
            // 
            // btnSaveExcel
            // 
            this.btnSaveExcel.Location = new System.Drawing.Point(881, 43);
            this.btnSaveExcel.Name = "btnSaveExcel";
            this.btnSaveExcel.Size = new System.Drawing.Size(75, 23);
            this.btnSaveExcel.TabIndex = 13;
            this.btnSaveExcel.TabStop = false;
            this.btnSaveExcel.Text = "存为Excel";
            this.btnSaveExcel.Click += new System.EventHandler(this.btnSaveExcel_Click);
            // 
            // checkPayDate
            // 
            this.checkPayDate.Location = new System.Drawing.Point(86, 44);
            this.checkPayDate.Name = "checkPayDate";
            this.checkPayDate.Properties.Caption = "";
            this.checkPayDate.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.checkPayDate.Properties.ValueGrayed = false;
            this.checkPayDate.Size = new System.Drawing.Size(19, 19);
            this.checkPayDate.TabIndex = 33;
            this.checkPayDate.TabStop = false;
            this.checkPayDate.CheckedChanged += new System.EventHandler(this.checkPayDate_CheckedChanged);
            // 
            // datePayDateEnd
            // 
            this.datePayDateEnd.EditValue = null;
            this.datePayDateEnd.Enabled = false;
            this.datePayDateEnd.EnterMoveNextControl = true;
            this.datePayDateEnd.Location = new System.Drawing.Point(225, 44);
            this.datePayDateEnd.Name = "datePayDateEnd";
            this.datePayDateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datePayDateEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datePayDateEnd.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.datePayDateEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.datePayDateEnd.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.datePayDateEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.datePayDateEnd.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.datePayDateEnd.Size = new System.Drawing.Size(100, 20);
            this.datePayDateEnd.TabIndex = 35;
            // 
            // datePayDateBegin
            // 
            this.datePayDateBegin.EditValue = null;
            this.datePayDateBegin.Enabled = false;
            this.datePayDateBegin.EnterMoveNextControl = true;
            this.datePayDateBegin.Location = new System.Drawing.Point(109, 44);
            this.datePayDateBegin.Name = "datePayDateBegin";
            this.datePayDateBegin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datePayDateBegin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datePayDateBegin.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.datePayDateBegin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.datePayDateBegin.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.datePayDateBegin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.datePayDateBegin.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.datePayDateBegin.Size = new System.Drawing.Size(100, 20);
            this.datePayDateBegin.TabIndex = 34;
            // 
            // labPayDate
            // 
            this.labPayDate.Location = new System.Drawing.Point(20, 47);
            this.labPayDate.Name = "labPayDate";
            this.labPayDate.Size = new System.Drawing.Size(60, 14);
            this.labPayDate.TabIndex = 37;
            this.labPayDate.Text = "付款日期：";
            // 
            // lab2
            // 
            this.lab2.Location = new System.Drawing.Point(215, 47);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(4, 14);
            this.lab2.TabIndex = 36;
            this.lab2.Text = "-";
            // 
            // lookUpReqDep
            // 
            this.lookUpReqDep.EnterMoveNextControl = true;
            this.lookUpReqDep.Location = new System.Drawing.Point(582, 14);
            this.lookUpReqDep.Margin = new System.Windows.Forms.Padding(4);
            this.lookUpReqDep.Name = "lookUpReqDep";
            this.lookUpReqDep.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpReqDep.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentNo", "部门编号", 95, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentName", "部门名称", 111, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpReqDep.Properties.DisplayMember = "DepartmentName";
            this.lookUpReqDep.Properties.NullText = "";
            this.lookUpReqDep.Properties.ValueMember = "DepartmentNo";
            this.lookUpReqDep.Size = new System.Drawing.Size(120, 20);
            this.lookUpReqDep.TabIndex = 5;
            // 
            // comboBoxWarehouseState
            // 
            this.comboBoxWarehouseState.EnterMoveNextControl = true;
            this.comboBoxWarehouseState.Location = new System.Drawing.Point(787, 14);
            this.comboBoxWarehouseState.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxWarehouseState.Name = "comboBoxWarehouseState";
            this.comboBoxWarehouseState.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxWarehouseState.Properties.Items.AddRange(new object[] {
            "全部",
            "待审批",
            "审批",
            "已结账",
            "审批中"});
            this.comboBoxWarehouseState.Size = new System.Drawing.Size(120, 20);
            this.comboBoxWarehouseState.TabIndex = 6;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(787, 43);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 12;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // textCommon
            // 
            this.textCommon.EnterMoveNextControl = true;
            this.textCommon.Location = new System.Drawing.Point(409, 44);
            this.textCommon.Margin = new System.Windows.Forms.Padding(4);
            this.textCommon.Name = "textCommon";
            this.textCommon.Size = new System.Drawing.Size(150, 20);
            this.textCommon.TabIndex = 9;
            // 
            // lookUpPrepared
            // 
            this.lookUpPrepared.EnterMoveNextControl = true;
            this.lookUpPrepared.Location = new System.Drawing.Point(980, 14);
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
            this.lookUpPrepared.TabIndex = 7;
            // 
            // searchLookUpBussinessBaseNo
            // 
            this.searchLookUpBussinessBaseNo.EnterMoveNextControl = true;
            this.searchLookUpBussinessBaseNo.Location = new System.Drawing.Point(371, 14);
            this.searchLookUpBussinessBaseNo.Margin = new System.Windows.Forms.Padding(4);
            this.searchLookUpBussinessBaseNo.Name = "searchLookUpBussinessBaseNo";
            this.searchLookUpBussinessBaseNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpBussinessBaseNo.Properties.DisplayMember = "BussinessBaseText";
            this.searchLookUpBussinessBaseNo.Properties.NullText = "";
            this.searchLookUpBussinessBaseNo.Properties.ValueMember = "BussinessBaseNo";
            this.searchLookUpBussinessBaseNo.Properties.View = this.searchLookUpBussinessBaseNoView;
            this.searchLookUpBussinessBaseNo.Size = new System.Drawing.Size(150, 20);
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
            this.searchLookUpBussinessBaseNoView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewSettlementHead_CustomDrawRowIndicator);
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
            // dateSettlementDateEnd
            // 
            this.dateSettlementDateEnd.EditValue = null;
            this.dateSettlementDateEnd.EnterMoveNextControl = true;
            this.dateSettlementDateEnd.Location = new System.Drawing.Point(202, 14);
            this.dateSettlementDateEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dateSettlementDateEnd.Name = "dateSettlementDateEnd";
            this.dateSettlementDateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSettlementDateEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSettlementDateEnd.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dateSettlementDateEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateSettlementDateEnd.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateSettlementDateEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateSettlementDateEnd.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateSettlementDateEnd.Size = new System.Drawing.Size(100, 20);
            this.dateSettlementDateEnd.TabIndex = 1;
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
            // dateSettlementDateBegin
            // 
            this.dateSettlementDateBegin.EditValue = null;
            this.dateSettlementDateBegin.EnterMoveNextControl = true;
            this.dateSettlementDateBegin.Location = new System.Drawing.Point(86, 14);
            this.dateSettlementDateBegin.Margin = new System.Windows.Forms.Padding(4);
            this.dateSettlementDateBegin.Name = "dateSettlementDateBegin";
            this.dateSettlementDateBegin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSettlementDateBegin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSettlementDateBegin.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dateSettlementDateBegin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateSettlementDateBegin.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateSettlementDateBegin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateSettlementDateBegin.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateSettlementDateBegin.Size = new System.Drawing.Size(100, 20);
            this.dateSettlementDateBegin.TabIndex = 0;
            // 
            // labReqDep
            // 
            this.labReqDep.Location = new System.Drawing.Point(538, 17);
            this.labReqDep.Margin = new System.Windows.Forms.Padding(4);
            this.labReqDep.Name = "labReqDep";
            this.labReqDep.Size = new System.Drawing.Size(36, 14);
            this.labReqDep.TabIndex = 32;
            this.labReqDep.Text = "部门：";
            // 
            // labCommon
            // 
            this.labCommon.Location = new System.Drawing.Point(341, 47);
            this.labCommon.Margin = new System.Windows.Forms.Padding(4);
            this.labCommon.Name = "labCommon";
            this.labCommon.Size = new System.Drawing.Size(60, 14);
            this.labCommon.TabIndex = 22;
            this.labCommon.Text = "通用查询：";
            // 
            // labPrepared
            // 
            this.labPrepared.Location = new System.Drawing.Point(924, 17);
            this.labPrepared.Margin = new System.Windows.Forms.Padding(4);
            this.labPrepared.Name = "labPrepared";
            this.labPrepared.Size = new System.Drawing.Size(48, 14);
            this.labPrepared.TabIndex = 20;
            this.labPrepared.Text = "制单人：";
            // 
            // labBussinessBaseNo
            // 
            this.labBussinessBaseNo.Location = new System.Drawing.Point(315, 17);
            this.labBussinessBaseNo.Margin = new System.Windows.Forms.Padding(4);
            this.labBussinessBaseNo.Name = "labBussinessBaseNo";
            this.labBussinessBaseNo.Size = new System.Drawing.Size(48, 14);
            this.labBussinessBaseNo.TabIndex = 18;
            this.labBussinessBaseNo.Text = "往来方：";
            // 
            // labWarehouseState
            // 
            this.labWarehouseState.Location = new System.Drawing.Point(721, 17);
            this.labWarehouseState.Margin = new System.Windows.Forms.Padding(4);
            this.labWarehouseState.Name = "labWarehouseState";
            this.labWarehouseState.Size = new System.Drawing.Size(60, 14);
            this.labWarehouseState.TabIndex = 30;
            this.labWarehouseState.Text = "单据状态：";
            // 
            // labSettlementDate
            // 
            this.labSettlementDate.Location = new System.Drawing.Point(20, 17);
            this.labSettlementDate.Margin = new System.Windows.Forms.Padding(4);
            this.labSettlementDate.Name = "labSettlementDate";
            this.labSettlementDate.Size = new System.Drawing.Size(60, 14);
            this.labSettlementDate.TabIndex = 5;
            this.labSettlementDate.Text = "结账日期：";
            // 
            // dataSet_Settlement
            // 
            this.dataSet_Settlement.DataSetName = "NewDataSet";
            this.dataSet_Settlement.EnforceConstraints = false;
            this.dataSet_Settlement.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTableSettlementHead});
            // 
            // dataTableSettlementHead
            // 
            this.dataTableSettlementHead.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColAutoId,
            this.dataColSettlementNo,
            this.dataColInvoiceNo,
            this.dataColSettlementDate,
            this.dataColReqDep,
            this.dataColBussinessBaseNo,
            this.dataColTax,
            this.dataColPayDate,
            this.dataColIsVoucher,
            this.dataColPrepared,
            this.dataColPreparedIp,
            this.dataColModifierIp,
            this.dataColModifierTime,
            this.dataColRemark,
            this.dataColWarehouseState,
            this.dataColApprovalType,
            this.dataColModifier});
            this.dataTableSettlementHead.TableName = "SettlementHead";
            // 
            // dataColAutoId
            // 
            this.dataColAutoId.ColumnName = "AutoId";
            this.dataColAutoId.DataType = typeof(int);
            // 
            // dataColSettlementNo
            // 
            this.dataColSettlementNo.Caption = "结账单号";
            this.dataColSettlementNo.ColumnName = "SettlementNo";
            // 
            // dataColInvoiceNo
            // 
            this.dataColInvoiceNo.Caption = "发票号";
            this.dataColInvoiceNo.ColumnName = "InvoiceNo";
            // 
            // dataColSettlementDate
            // 
            this.dataColSettlementDate.Caption = "结账日期";
            this.dataColSettlementDate.ColumnName = "SettlementDate";
            this.dataColSettlementDate.DataType = typeof(System.DateTime);
            // 
            // dataColReqDep
            // 
            this.dataColReqDep.Caption = "部门";
            this.dataColReqDep.ColumnName = "ReqDep";
            // 
            // dataColBussinessBaseNo
            // 
            this.dataColBussinessBaseNo.Caption = "往来方";
            this.dataColBussinessBaseNo.ColumnName = "BussinessBaseNo";
            // 
            // dataColTax
            // 
            this.dataColTax.Caption = "税率";
            this.dataColTax.ColumnName = "Tax";
            this.dataColTax.DataType = typeof(double);
            // 
            // dataColPayDate
            // 
            this.dataColPayDate.Caption = "付款日期";
            this.dataColPayDate.ColumnName = "PayDate";
            this.dataColPayDate.DataType = typeof(System.DateTime);
            // 
            // dataColIsVoucher
            // 
            this.dataColIsVoucher.Caption = "生成凭证";
            this.dataColIsVoucher.ColumnName = "IsVoucher";
            this.dataColIsVoucher.DataType = typeof(int);
            // 
            // dataColPrepared
            // 
            this.dataColPrepared.Caption = "申请人";
            this.dataColPrepared.ColumnName = "Prepared";
            // 
            // dataColPreparedIp
            // 
            this.dataColPreparedIp.Caption = "制单人IP";
            this.dataColPreparedIp.ColumnName = "PreparedIp";
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
            // dataColRemark
            // 
            this.dataColRemark.Caption = "备注";
            this.dataColRemark.ColumnName = "Remark";
            // 
            // dataColWarehouseState
            // 
            this.dataColWarehouseState.Caption = "状态";
            this.dataColWarehouseState.ColumnName = "WarehouseState";
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
            // bindingSource_SettlementHead
            // 
            this.bindingSource_SettlementHead.DataMember = "SettlementHead";
            this.bindingSource_SettlementHead.DataSource = this.dataSet_Settlement;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.gridBottomOrderHead);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 549);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1144, 58);
            this.pnlBottom.TabIndex = 6;
            // 
            // gridBottomOrderHead
            // 
            this.gridBottomOrderHead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBottomOrderHead.Location = new System.Drawing.Point(2, 2);
            this.gridBottomOrderHead.MasterDataSet = this.dataSet_Settlement;
            this.gridBottomOrderHead.Name = "gridBottomOrderHead";
            this.gridBottomOrderHead.pageRowCount = 5;
            this.gridBottomOrderHead.Size = new System.Drawing.Size(1140, 54);
            this.gridBottomOrderHead.TabIndex = 0;
            // 
            // gridControlSettlementHead
            // 
            this.gridControlSettlementHead.DataSource = this.bindingSource_SettlementHead;
            this.gridControlSettlementHead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSettlementHead.Location = new System.Drawing.Point(2, 2);
            this.gridControlSettlementHead.MainView = this.gridViewSettlementHead;
            this.gridControlSettlementHead.Name = "gridControlSettlementHead";
            this.gridControlSettlementHead.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repLookUpReqDep,
            this.repSearchBussinessBaseNo,
            this.repCheckSelect,
            this.repSpinTax,
            this.repLookUpApprovalType,
            this.repCheckIsVoucher});
            this.gridControlSettlementHead.Size = new System.Drawing.Size(1140, 467);
            this.gridControlSettlementHead.TabIndex = 7;
            this.gridControlSettlementHead.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSettlementHead});
            // 
            // gridViewSettlementHead
            // 
            this.gridViewSettlementHead.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId,
            this.colSettlementNo,
            this.colWarehouseState,
            this.colSettlementDate,
            this.colReqDep,
            this.colBussinessBaseNo,
            this.colTax,
            this.colPayDate,
            this.colApprovalType,
            this.colIsVoucher,
            this.colRemark,
            this.colPrepared,
            this.colModifier,
            this.colInvoiceNo});
            this.gridViewSettlementHead.GridControl = this.gridControlSettlementHead;
            this.gridViewSettlementHead.IndicatorWidth = 40;
            this.gridViewSettlementHead.Name = "gridViewSettlementHead";
            this.gridViewSettlementHead.OptionsBehavior.Editable = false;
            this.gridViewSettlementHead.OptionsBehavior.ReadOnly = true;
            this.gridViewSettlementHead.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewSettlementHead.OptionsView.ColumnAutoWidth = false;
            this.gridViewSettlementHead.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewSettlementHead.OptionsView.ShowFooter = true;
            this.gridViewSettlementHead.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewSettlementHead_RowClick);
            this.gridViewSettlementHead.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewSettlementHead_CustomDrawRowIndicator);
            this.gridViewSettlementHead.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridViewSettlementHead_CustomColumnDisplayText);
            // 
            // colAutoId
            // 
            this.colAutoId.FieldName = "AutoId";
            this.colAutoId.Name = "colAutoId";
            // 
            // colSettlementNo
            // 
            this.colSettlementNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colSettlementNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSettlementNo.FieldName = "SettlementNo";
            this.colSettlementNo.Name = "colSettlementNo";
            this.colSettlementNo.OptionsColumn.AllowEdit = false;
            this.colSettlementNo.OptionsColumn.AllowFocus = false;
            this.colSettlementNo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "PrReqNo", "共计{0}条")});
            this.colSettlementNo.Visible = true;
            this.colSettlementNo.VisibleIndex = 0;
            this.colSettlementNo.Width = 110;
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
            // colSettlementDate
            // 
            this.colSettlementDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colSettlementDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSettlementDate.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.colSettlementDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colSettlementDate.FieldName = "SettlementDate";
            this.colSettlementDate.Name = "colSettlementDate";
            this.colSettlementDate.OptionsColumn.AllowEdit = false;
            this.colSettlementDate.OptionsColumn.AllowFocus = false;
            this.colSettlementDate.Visible = true;
            this.colSettlementDate.VisibleIndex = 2;
            this.colSettlementDate.Width = 90;
            // 
            // colReqDep
            // 
            this.colReqDep.AppearanceHeader.Options.UseTextOptions = true;
            this.colReqDep.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colReqDep.ColumnEdit = this.repLookUpReqDep;
            this.colReqDep.FieldName = "ReqDep";
            this.colReqDep.Name = "colReqDep";
            this.colReqDep.OptionsColumn.AllowEdit = false;
            this.colReqDep.Visible = true;
            this.colReqDep.VisibleIndex = 5;
            this.colReqDep.Width = 100;
            // 
            // repLookUpReqDep
            // 
            this.repLookUpReqDep.AutoHeight = false;
            this.repLookUpReqDep.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpReqDep.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentNo", "部门编号", 95, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentName", "部门名称", 111, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repLookUpReqDep.DisplayMember = "DepartmentName";
            this.repLookUpReqDep.Name = "repLookUpReqDep";
            this.repLookUpReqDep.NullText = "";
            this.repLookUpReqDep.ValueMember = "DepartmentNo";
            // 
            // colBussinessBaseNo
            // 
            this.colBussinessBaseNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colBussinessBaseNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBussinessBaseNo.ColumnEdit = this.repSearchBussinessBaseNo;
            this.colBussinessBaseNo.FieldName = "BussinessBaseNo";
            this.colBussinessBaseNo.Name = "colBussinessBaseNo";
            this.colBussinessBaseNo.OptionsColumn.AllowEdit = false;
            this.colBussinessBaseNo.Visible = true;
            this.colBussinessBaseNo.VisibleIndex = 4;
            this.colBussinessBaseNo.Width = 130;
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
            // colTax
            // 
            this.colTax.AppearanceHeader.Options.UseTextOptions = true;
            this.colTax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTax.ColumnEdit = this.repSpinTax;
            this.colTax.FieldName = "Tax";
            this.colTax.Name = "colTax";
            this.colTax.OptionsColumn.AllowEdit = false;
            this.colTax.Visible = true;
            this.colTax.VisibleIndex = 6;
            this.colTax.Width = 60;
            // 
            // repSpinTax
            // 
            this.repSpinTax.AutoHeight = false;
            this.repSpinTax.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repSpinTax.DisplayFormat.FormatString = "p0";
            this.repSpinTax.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repSpinTax.EditFormat.FormatString = "p0";
            this.repSpinTax.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repSpinTax.Mask.EditMask = "p0";
            this.repSpinTax.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repSpinTax.Name = "repSpinTax";
            // 
            // colPayDate
            // 
            this.colPayDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colPayDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPayDate.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.colPayDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colPayDate.FieldName = "PayDate";
            this.colPayDate.Name = "colPayDate";
            this.colPayDate.OptionsColumn.AllowEdit = false;
            this.colPayDate.Visible = true;
            this.colPayDate.VisibleIndex = 7;
            this.colPayDate.Width = 90;
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
            this.colApprovalType.VisibleIndex = 8;
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
            // colIsVoucher
            // 
            this.colIsVoucher.AppearanceHeader.Options.UseTextOptions = true;
            this.colIsVoucher.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIsVoucher.ColumnEdit = this.repCheckIsVoucher;
            this.colIsVoucher.FieldName = "IsVoucher";
            this.colIsVoucher.Name = "colIsVoucher";
            this.colIsVoucher.OptionsColumn.AllowEdit = false;
            this.colIsVoucher.OptionsColumn.AllowFocus = false;
            this.colIsVoucher.Visible = true;
            this.colIsVoucher.VisibleIndex = 10;
            this.colIsVoucher.Width = 70;
            // 
            // repCheckIsVoucher
            // 
            this.repCheckIsVoucher.AutoHeight = false;
            this.repCheckIsVoucher.Name = "repCheckIsVoucher";
            this.repCheckIsVoucher.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repCheckIsVoucher.ValueGrayed = false;
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
            this.colPrepared.OptionsColumn.AllowFocus = false;
            this.colPrepared.Visible = true;
            this.colPrepared.VisibleIndex = 11;
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
            this.colModifier.VisibleIndex = 12;
            // 
            // colInvoiceNo
            // 
            this.colInvoiceNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colInvoiceNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInvoiceNo.FieldName = "InvoiceNo";
            this.colInvoiceNo.Name = "colInvoiceNo";
            this.colInvoiceNo.OptionsColumn.AllowEdit = false;
            this.colInvoiceNo.Visible = true;
            this.colInvoiceNo.VisibleIndex = 3;
            this.colInvoiceNo.Width = 100;
            // 
            // repCheckSelect
            // 
            this.repCheckSelect.AutoHeight = false;
            this.repCheckSelect.Name = "repCheckSelect";
            this.repCheckSelect.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repCheckSelect.ValueGrayed = false;
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.Controls.Add(this.gridControlSettlementHead);
            this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMiddle.Location = new System.Drawing.Point(0, 78);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(1144, 471);
            this.pnlMiddle.TabIndex = 8;
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCtjz,
            this.tsmiCtjh,
            this.tsmiJzrqbnwk,
            this.tsmiFkrqbnwk,
            this.tsmiCxan,
            this.tsmiCxjgcw,
            this.tsmiSjcx});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(317, 180);
            // 
            // tsmiCtjz
            // 
            this.tsmiCtjz.Name = "tsmiCtjz";
            this.tsmiCtjz.Size = new System.Drawing.Size(316, 22);
            this.tsmiCtjz.Text = "窗体加载事件错误。";
            // 
            // tsmiCtjh
            // 
            this.tsmiCtjh.Name = "tsmiCtjh";
            this.tsmiCtjh.Size = new System.Drawing.Size(316, 22);
            this.tsmiCtjh.Text = "窗体激活事件错误";
            // 
            // tsmiJzrqbnwk
            // 
            this.tsmiJzrqbnwk.Name = "tsmiJzrqbnwk";
            this.tsmiJzrqbnwk.Size = new System.Drawing.Size(316, 22);
            this.tsmiJzrqbnwk.Text = "结账日期不能为空，请设置后重新进行查询。";
            // 
            // tsmiFkrqbnwk
            // 
            this.tsmiFkrqbnwk.Name = "tsmiFkrqbnwk";
            this.tsmiFkrqbnwk.Size = new System.Drawing.Size(316, 22);
            this.tsmiFkrqbnwk.Text = "付款日期不能为空，请设置后重新进行查询。";
            // 
            // tsmiCxan
            // 
            this.tsmiCxan.Name = "tsmiCxan";
            this.tsmiCxan.Size = new System.Drawing.Size(316, 22);
            this.tsmiCxan.Text = "-查询按钮事件错误。";
            // 
            // tsmiCxjgcw
            // 
            this.tsmiCxjgcw.Name = "tsmiCxjgcw";
            this.tsmiCxjgcw.Size = new System.Drawing.Size(316, 22);
            this.tsmiCxjgcw.Text = "查询结果存为Excel错误。";
            // 
            // tsmiSjcx
            // 
            this.tsmiSjcx.Name = "tsmiSjcx";
            this.tsmiSjcx.Size = new System.Drawing.Size(316, 22);
            this.tsmiSjcx.Text = "双击查询明细错误。";
            // 
            // FrmSettlementQuery
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1144, 607);
            this.Controls.Add(this.pnlMiddle);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnltop);
            this.Name = "FrmSettlementQuery";
            this.TabText = "采购结账单查询";
            this.Text = "采购结账单查询";
            this.Activated += new System.EventHandler(this.FrmSettlementQuery_Activated);
            this.Load += new System.EventHandler(this.FrmSettlementQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnltop)).EndInit();
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinwwListAutoId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkwwListAutoId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkPayDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePayDateEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePayDateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePayDateBegin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePayDateBegin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpReqDep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxWarehouseState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCommon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPrepared.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpBussinessBaseNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpBussinessBaseNoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSettlementDateEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSettlementDateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSettlementDateBegin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSettlementDateBegin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Settlement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableSettlementHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_SettlementHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSettlementHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSettlementHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpReqDep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchBussinessBaseNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinTax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpApprovalType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckIsVoucher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddle)).EndInit();
            this.pnlMiddle.ResumeLayout(false);
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnltop;
        private DevExpress.XtraEditors.CheckEdit checkPayDate;
        private DevExpress.XtraEditors.DateEdit datePayDateEnd;
        private DevExpress.XtraEditors.DateEdit datePayDateBegin;
        private DevExpress.XtraEditors.LabelControl labPayDate;
        private DevExpress.XtraEditors.LabelControl lab2;
        private DevExpress.XtraEditors.LookUpEdit lookUpReqDep;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxWarehouseState;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.TextEdit textCommon;
        private DevExpress.XtraEditors.LookUpEdit lookUpPrepared;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpBussinessBaseNo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpBussinessBaseNoView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBussinessBaseNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBussinessBaseText;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBussinessCategoryText;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnAutoId;
        private DevExpress.XtraEditors.DateEdit dateSettlementDateEnd;
        private DevExpress.XtraEditors.LabelControl lab1;
        private DevExpress.XtraEditors.DateEdit dateSettlementDateBegin;
        private DevExpress.XtraEditors.LabelControl labReqDep;
        private DevExpress.XtraEditors.LabelControl labCommon;
        private DevExpress.XtraEditors.LabelControl labPrepared;
        private DevExpress.XtraEditors.LabelControl labBussinessBaseNo;
        private DevExpress.XtraEditors.LabelControl labWarehouseState;
        private DevExpress.XtraEditors.LabelControl labSettlementDate;
        private DevExpress.XtraEditors.SimpleButton btnSaveExcel;
        private System.Data.DataSet dataSet_Settlement;
        private System.Data.DataTable dataTableSettlementHead;
        private System.Data.DataColumn dataColAutoId;
        private System.Data.DataColumn dataColSettlementNo;
        private System.Data.DataColumn dataColInvoiceNo;
        private System.Data.DataColumn dataColSettlementDate;
        private System.Data.DataColumn dataColReqDep;
        private System.Data.DataColumn dataColBussinessBaseNo;
        private System.Data.DataColumn dataColTax;
        private System.Data.DataColumn dataColPayDate;
        private System.Data.DataColumn dataColIsVoucher;
        private System.Data.DataColumn dataColPrepared;
        private System.Data.DataColumn dataColPreparedIp;
        private System.Data.DataColumn dataColModifierIp;
        private System.Data.DataColumn dataColModifierTime;
        private System.Data.DataColumn dataColRemark;
        private System.Data.DataColumn dataColWarehouseState;
        private System.Data.DataColumn dataColApprovalType;
        private System.Data.DataColumn dataColModifier;
        private System.Windows.Forms.BindingSource bindingSource_SettlementHead;
        private DevExpress.XtraEditors.PanelControl pnlBottom;
        private GridBottom gridBottomOrderHead;
        private DevExpress.XtraGrid.GridControl gridControlSettlementHead;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSettlementHead;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colSettlementNo;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouseState;
        private DevExpress.XtraGrid.Columns.GridColumn colSettlementDate;
        private DevExpress.XtraGrid.Columns.GridColumn colReqDep;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpReqDep;
        private DevExpress.XtraGrid.Columns.GridColumn colBussinessBaseNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repSearchBussinessBaseNo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridCBussinessBaseNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridCBussinessBaseText;
        private DevExpress.XtraGrid.Columns.GridColumn gridCBussinessCategoryText;
        private DevExpress.XtraGrid.Columns.GridColumn gridCAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colTax;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repSpinTax;
        private DevExpress.XtraGrid.Columns.GridColumn colPayDate;
        private DevExpress.XtraGrid.Columns.GridColumn colApprovalType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpApprovalType;
        private DevExpress.XtraGrid.Columns.GridColumn colIsVoucher;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheckIsVoucher;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colPrepared;
        private DevExpress.XtraGrid.Columns.GridColumn colModifier;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheckSelect;
        private DevExpress.XtraEditors.PanelControl pnlMiddle;
        private DevExpress.XtraEditors.CheckEdit checkwwListAutoId;
        private DevExpress.XtraEditors.SpinEdit spinwwListAutoId;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem tsmiCtjz;
        private System.Windows.Forms.ToolStripMenuItem tsmiCtjh;
        private System.Windows.Forms.ToolStripMenuItem tsmiJzrqbnwk;
        private System.Windows.Forms.ToolStripMenuItem tsmiFkrqbnwk;
        private System.Windows.Forms.ToolStripMenuItem tsmiCxan;
        private System.Windows.Forms.ToolStripMenuItem tsmiCxjgcw;
        private System.Windows.Forms.ToolStripMenuItem tsmiSjcx;
    }
}