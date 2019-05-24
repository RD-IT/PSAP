namespace PSAP.VIEW.BSVIEW
{
    partial class FrmProductionScheduleQuery
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
            this.bindingSource_PSchedule = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_PSchedule = new System.Data.DataSet();
            this.TableProductionSchedule = new System.Data.DataTable();
            this.dataColAutoId = new System.Data.DataColumn();
            this.dataColPsNo = new System.Data.DataColumn();
            this.dataColCurrentDate = new System.Data.DataColumn();
            this.dataColReqDate = new System.Data.DataColumn();
            this.dataColPrepared = new System.Data.DataColumn();
            this.dataColPreparedIp = new System.Data.DataColumn();
            this.dataColModifier = new System.Data.DataColumn();
            this.dataColModifierIp = new System.Data.DataColumn();
            this.dataColModifierTime = new System.Data.DataColumn();
            this.dataColPsState = new System.Data.DataColumn();
            this.dataColGetTime = new System.Data.DataColumn();
            this.dataColSelect = new System.Data.DataColumn();
            this.dataColRemark = new System.Data.DataColumn();
            this.dataColSalesOrderNo = new System.Data.DataColumn();
            this.dataColPlannedText = new System.Data.DataColumn();
            this.pnlBottom = new DevExpress.XtraEditors.PanelControl();
            this.gridBottomOrderHead = new PSAP.VIEW.BSVIEW.GridBottom();
            this.pnltop = new DevExpress.XtraEditors.PanelControl();
            this.checkReqDate = new DevExpress.XtraEditors.CheckEdit();
            this.dateReqDateEnd = new DevExpress.XtraEditors.DateEdit();
            this.dateReqDateBegin = new DevExpress.XtraEditors.DateEdit();
            this.labReqDate = new DevExpress.XtraEditors.LabelControl();
            this.lab2 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpPrepared = new DevExpress.XtraEditors.LookUpEdit();
            this.labPrepared = new DevExpress.XtraEditors.LabelControl();
            this.btnSaveExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.textCommon = new DevExpress.XtraEditors.TextEdit();
            this.dateCurrentDateEnd = new DevExpress.XtraEditors.DateEdit();
            this.dateCurrentDateBegin = new DevExpress.XtraEditors.DateEdit();
            this.labCommon = new DevExpress.XtraEditors.LabelControl();
            this.lab1 = new DevExpress.XtraEditors.LabelControl();
            this.labCurrentDate = new DevExpress.XtraEditors.LabelControl();
            this.pnlMiddle = new DevExpress.XtraEditors.PanelControl();
            this.gridControlProductionSchedule = new DevExpress.XtraGrid.GridControl();
            this.gridViewProductionSchedule = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPsNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPsState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrentDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReqDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlannedText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesOrderNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrepared = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpReqDep = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repSearchBussinessBaseNo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridCBussinessBaseNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCBussinessBaseText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCBussinessCategoryText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCheckSelect = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repSpinTax = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repLookUpApprovalType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repCheckIsVoucher = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_PSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_PSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableProductionSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).BeginInit();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnltop)).BeginInit();
            this.pnltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkReqDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateReqDateEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateReqDateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateReqDateBegin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateReqDateBegin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPrepared.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCommon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCurrentDateEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCurrentDateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCurrentDateBegin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCurrentDateBegin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddle)).BeginInit();
            this.pnlMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProductionSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductionSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpReqDep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchBussinessBaseNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpApprovalType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckIsVoucher)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource_PSchedule
            // 
            this.bindingSource_PSchedule.DataMember = "ProductionSchedule";
            this.bindingSource_PSchedule.DataSource = this.dataSet_PSchedule;
            // 
            // dataSet_PSchedule
            // 
            this.dataSet_PSchedule.DataSetName = "NewDataSet";
            this.dataSet_PSchedule.EnforceConstraints = false;
            this.dataSet_PSchedule.Tables.AddRange(new System.Data.DataTable[] {
            this.TableProductionSchedule});
            // 
            // TableProductionSchedule
            // 
            this.TableProductionSchedule.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColAutoId,
            this.dataColPsNo,
            this.dataColCurrentDate,
            this.dataColReqDate,
            this.dataColPrepared,
            this.dataColPreparedIp,
            this.dataColModifier,
            this.dataColModifierIp,
            this.dataColModifierTime,
            this.dataColPsState,
            this.dataColGetTime,
            this.dataColSelect,
            this.dataColRemark,
            this.dataColSalesOrderNo,
            this.dataColPlannedText});
            this.TableProductionSchedule.TableName = "ProductionSchedule";
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
            // dataColReqDate
            // 
            this.dataColReqDate.Caption = "需求日期";
            this.dataColReqDate.ColumnName = "ReqDate";
            this.dataColReqDate.DataType = typeof(System.DateTime);
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
            // dataColSalesOrderNo
            // 
            this.dataColSalesOrderNo.Caption = "销售单号";
            this.dataColSalesOrderNo.ColumnName = "SalesOrderNo";
            // 
            // dataColPlannedText
            // 
            this.dataColPlannedText.Caption = "计划项";
            this.dataColPlannedText.ColumnName = "PlannedText";
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.gridBottomOrderHead);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 523);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1036, 58);
            this.pnlBottom.TabIndex = 7;
            // 
            // gridBottomOrderHead
            // 
            this.gridBottomOrderHead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBottomOrderHead.Location = new System.Drawing.Point(2, 2);
            this.gridBottomOrderHead.MasterDataSet = this.dataSet_PSchedule;
            this.gridBottomOrderHead.Name = "gridBottomOrderHead";
            this.gridBottomOrderHead.pageRowCount = 5;
            this.gridBottomOrderHead.Size = new System.Drawing.Size(1032, 54);
            this.gridBottomOrderHead.TabIndex = 0;
            // 
            // pnltop
            // 
            this.pnltop.Controls.Add(this.checkReqDate);
            this.pnltop.Controls.Add(this.dateReqDateEnd);
            this.pnltop.Controls.Add(this.dateReqDateBegin);
            this.pnltop.Controls.Add(this.labReqDate);
            this.pnltop.Controls.Add(this.lab2);
            this.pnltop.Controls.Add(this.lookUpPrepared);
            this.pnltop.Controls.Add(this.labPrepared);
            this.pnltop.Controls.Add(this.btnSaveExcel);
            this.pnltop.Controls.Add(this.btnQuery);
            this.pnltop.Controls.Add(this.textCommon);
            this.pnltop.Controls.Add(this.dateCurrentDateEnd);
            this.pnltop.Controls.Add(this.dateCurrentDateBegin);
            this.pnltop.Controls.Add(this.labCommon);
            this.pnltop.Controls.Add(this.lab1);
            this.pnltop.Controls.Add(this.labCurrentDate);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(1036, 78);
            this.pnltop.TabIndex = 8;
            // 
            // checkReqDate
            // 
            this.checkReqDate.Location = new System.Drawing.Point(391, 14);
            this.checkReqDate.Name = "checkReqDate";
            this.checkReqDate.Properties.Caption = "";
            this.checkReqDate.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.checkReqDate.Properties.ValueGrayed = false;
            this.checkReqDate.Size = new System.Drawing.Size(19, 19);
            this.checkReqDate.TabIndex = 38;
            this.checkReqDate.TabStop = false;
            this.checkReqDate.CheckedChanged += new System.EventHandler(this.checkReqDate_CheckedChanged);
            // 
            // dateReqDateEnd
            // 
            this.dateReqDateEnd.EditValue = null;
            this.dateReqDateEnd.Enabled = false;
            this.dateReqDateEnd.EnterMoveNextControl = true;
            this.dateReqDateEnd.Location = new System.Drawing.Point(530, 14);
            this.dateReqDateEnd.Name = "dateReqDateEnd";
            this.dateReqDateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateReqDateEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateReqDateEnd.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dateReqDateEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateReqDateEnd.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateReqDateEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateReqDateEnd.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateReqDateEnd.Size = new System.Drawing.Size(100, 20);
            this.dateReqDateEnd.TabIndex = 40;
            // 
            // dateReqDateBegin
            // 
            this.dateReqDateBegin.EditValue = null;
            this.dateReqDateBegin.Enabled = false;
            this.dateReqDateBegin.EnterMoveNextControl = true;
            this.dateReqDateBegin.Location = new System.Drawing.Point(414, 14);
            this.dateReqDateBegin.Name = "dateReqDateBegin";
            this.dateReqDateBegin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateReqDateBegin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateReqDateBegin.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dateReqDateBegin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateReqDateBegin.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateReqDateBegin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateReqDateBegin.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateReqDateBegin.Size = new System.Drawing.Size(100, 20);
            this.dateReqDateBegin.TabIndex = 39;
            // 
            // labReqDate
            // 
            this.labReqDate.Location = new System.Drawing.Point(325, 17);
            this.labReqDate.Name = "labReqDate";
            this.labReqDate.Size = new System.Drawing.Size(60, 14);
            this.labReqDate.TabIndex = 42;
            this.labReqDate.Text = "需求日期：";
            // 
            // lab2
            // 
            this.lab2.Location = new System.Drawing.Point(520, 17);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(4, 14);
            this.lab2.TabIndex = 41;
            this.lab2.Text = "-";
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
            this.lookUpPrepared.TabIndex = 4;
            // 
            // labPrepared
            // 
            this.labPrepared.Location = new System.Drawing.Point(20, 47);
            this.labPrepared.Margin = new System.Windows.Forms.Padding(4);
            this.labPrepared.Name = "labPrepared";
            this.labPrepared.Size = new System.Drawing.Size(48, 14);
            this.labPrepared.TabIndex = 24;
            this.labPrepared.Text = "制单人：";
            // 
            // btnSaveExcel
            // 
            this.btnSaveExcel.Location = new System.Drawing.Point(575, 43);
            this.btnSaveExcel.Name = "btnSaveExcel";
            this.btnSaveExcel.Size = new System.Drawing.Size(75, 23);
            this.btnSaveExcel.TabIndex = 7;
            this.btnSaveExcel.Text = "存为Excel";
            this.btnSaveExcel.Click += new System.EventHandler(this.btnSaveExcel_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(483, 43);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 6;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // textCommon
            // 
            this.textCommon.EnterMoveNextControl = true;
            this.textCommon.Location = new System.Drawing.Point(293, 44);
            this.textCommon.Name = "textCommon";
            this.textCommon.Size = new System.Drawing.Size(150, 20);
            this.textCommon.TabIndex = 5;
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
            // labCommon
            // 
            this.labCommon.Location = new System.Drawing.Point(227, 47);
            this.labCommon.Name = "labCommon";
            this.labCommon.Size = new System.Drawing.Size(60, 14);
            this.labCommon.TabIndex = 22;
            this.labCommon.Text = "通用查询：";
            // 
            // lab1
            // 
            this.lab1.Location = new System.Drawing.Point(192, 17);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(4, 14);
            this.lab1.TabIndex = 6;
            this.lab1.Text = "-";
            // 
            // labCurrentDate
            // 
            this.labCurrentDate.Location = new System.Drawing.Point(20, 17);
            this.labCurrentDate.Name = "labCurrentDate";
            this.labCurrentDate.Size = new System.Drawing.Size(60, 14);
            this.labCurrentDate.TabIndex = 5;
            this.labCurrentDate.Text = "单据日期：";
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.Controls.Add(this.gridControlProductionSchedule);
            this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMiddle.Location = new System.Drawing.Point(0, 78);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(1036, 445);
            this.pnlMiddle.TabIndex = 9;
            // 
            // gridControlProductionSchedule
            // 
            this.gridControlProductionSchedule.DataSource = this.bindingSource_PSchedule;
            this.gridControlProductionSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProductionSchedule.Location = new System.Drawing.Point(2, 2);
            this.gridControlProductionSchedule.MainView = this.gridViewProductionSchedule;
            this.gridControlProductionSchedule.Name = "gridControlProductionSchedule";
            this.gridControlProductionSchedule.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repLookUpReqDep,
            this.repSearchBussinessBaseNo,
            this.repCheckSelect,
            this.repSpinTax,
            this.repLookUpApprovalType,
            this.repCheckIsVoucher});
            this.gridControlProductionSchedule.Size = new System.Drawing.Size(1032, 441);
            this.gridControlProductionSchedule.TabIndex = 7;
            this.gridControlProductionSchedule.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProductionSchedule});
            // 
            // gridViewProductionSchedule
            // 
            this.gridViewProductionSchedule.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId,
            this.colPsNo,
            this.colPsState,
            this.colCurrentDate,
            this.colReqDate,
            this.colPlannedText,
            this.colSalesOrderNo,
            this.colRemark,
            this.colPrepared,
            this.colModifier});
            this.gridViewProductionSchedule.GridControl = this.gridControlProductionSchedule;
            this.gridViewProductionSchedule.IndicatorWidth = 40;
            this.gridViewProductionSchedule.Name = "gridViewProductionSchedule";
            this.gridViewProductionSchedule.OptionsBehavior.Editable = false;
            this.gridViewProductionSchedule.OptionsBehavior.ReadOnly = true;
            this.gridViewProductionSchedule.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewProductionSchedule.OptionsView.ColumnAutoWidth = false;
            this.gridViewProductionSchedule.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewProductionSchedule.OptionsView.ShowFooter = true;
            this.gridViewProductionSchedule.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewProductionSchedule_RowClick);
            this.gridViewProductionSchedule.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewProductionSchedule_CustomDrawRowIndicator);
            this.gridViewProductionSchedule.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewProductionSchedule_KeyDown);
            // 
            // colAutoId
            // 
            this.colAutoId.FieldName = "AutoId";
            this.colAutoId.Name = "colAutoId";
            // 
            // colPsNo
            // 
            this.colPsNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colPsNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPsNo.FieldName = "PsNo";
            this.colPsNo.Name = "colPsNo";
            this.colPsNo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "PrReqNo", "共计{0}条")});
            this.colPsNo.Visible = true;
            this.colPsNo.VisibleIndex = 0;
            this.colPsNo.Width = 110;
            // 
            // colPsState
            // 
            this.colPsState.AppearanceHeader.Options.UseTextOptions = true;
            this.colPsState.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPsState.FieldName = "PsState";
            this.colPsState.Name = "colPsState";
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
            this.colCurrentDate.Visible = true;
            this.colCurrentDate.VisibleIndex = 1;
            this.colCurrentDate.Width = 90;
            // 
            // colReqDate
            // 
            this.colReqDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colReqDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colReqDate.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.colReqDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colReqDate.FieldName = "ReqDate";
            this.colReqDate.Name = "colReqDate";
            this.colReqDate.Visible = true;
            this.colReqDate.VisibleIndex = 4;
            this.colReqDate.Width = 90;
            // 
            // colPlannedText
            // 
            this.colPlannedText.AppearanceHeader.Options.UseTextOptions = true;
            this.colPlannedText.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPlannedText.FieldName = "PlannedText";
            this.colPlannedText.Name = "colPlannedText";
            this.colPlannedText.Visible = true;
            this.colPlannedText.VisibleIndex = 3;
            this.colPlannedText.Width = 160;
            // 
            // colSalesOrderNo
            // 
            this.colSalesOrderNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colSalesOrderNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSalesOrderNo.FieldName = "SalesOrderNo";
            this.colSalesOrderNo.Name = "colSalesOrderNo";
            this.colSalesOrderNo.Visible = true;
            this.colSalesOrderNo.VisibleIndex = 2;
            this.colSalesOrderNo.Width = 110;
            // 
            // colRemark
            // 
            this.colRemark.AppearanceHeader.Options.UseTextOptions = true;
            this.colRemark.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 5;
            this.colRemark.Width = 140;
            // 
            // colPrepared
            // 
            this.colPrepared.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrepared.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrepared.FieldName = "Prepared";
            this.colPrepared.Name = "colPrepared";
            this.colPrepared.Visible = true;
            this.colPrepared.VisibleIndex = 6;
            this.colPrepared.Width = 70;
            // 
            // colModifier
            // 
            this.colModifier.AppearanceHeader.Options.UseTextOptions = true;
            this.colModifier.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colModifier.FieldName = "Modifier";
            this.colModifier.Name = "colModifier";
            this.colModifier.Visible = true;
            this.colModifier.VisibleIndex = 7;
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
            // repCheckSelect
            // 
            this.repCheckSelect.AutoHeight = false;
            this.repCheckSelect.Name = "repCheckSelect";
            this.repCheckSelect.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repCheckSelect.ValueGrayed = false;
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
            // repCheckIsVoucher
            // 
            this.repCheckIsVoucher.AutoHeight = false;
            this.repCheckIsVoucher.Name = "repCheckIsVoucher";
            this.repCheckIsVoucher.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repCheckIsVoucher.ValueGrayed = false;
            // 
            // FrmProductionScheduleQuery
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1036, 581);
            this.Controls.Add(this.pnlMiddle);
            this.Controls.Add(this.pnltop);
            this.Controls.Add(this.pnlBottom);
            this.Name = "FrmProductionScheduleQuery";
            this.TabText = "生产计划单查询";
            this.Text = "生产计划单查询";
            this.Load += new System.EventHandler(this.FrmProductionScheduleQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_PSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_PSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableProductionSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnltop)).EndInit();
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkReqDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateReqDateEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateReqDateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateReqDateBegin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateReqDateBegin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPrepared.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCommon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCurrentDateEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCurrentDateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCurrentDateBegin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCurrentDateBegin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddle)).EndInit();
            this.pnlMiddle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProductionSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductionSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpReqDep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchBussinessBaseNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinTax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpApprovalType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckIsVoucher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource_PSchedule;
        private System.Data.DataSet dataSet_PSchedule;
        private System.Data.DataTable TableProductionSchedule;
        private System.Data.DataColumn dataColAutoId;
        private System.Data.DataColumn dataColPsNo;
        private System.Data.DataColumn dataColCurrentDate;
        private System.Data.DataColumn dataColReqDate;
        private System.Data.DataColumn dataColPrepared;
        private System.Data.DataColumn dataColPreparedIp;
        private System.Data.DataColumn dataColModifier;
        private System.Data.DataColumn dataColModifierIp;
        private System.Data.DataColumn dataColModifierTime;
        private System.Data.DataColumn dataColPsState;
        private System.Data.DataColumn dataColGetTime;
        private System.Data.DataColumn dataColSelect;
        private System.Data.DataColumn dataColRemark;
        private System.Data.DataColumn dataColSalesOrderNo;
        private System.Data.DataColumn dataColPlannedText;
        private DevExpress.XtraEditors.PanelControl pnlBottom;
        private GridBottom gridBottomOrderHead;
        private DevExpress.XtraEditors.PanelControl pnltop;
        private DevExpress.XtraEditors.LookUpEdit lookUpPrepared;
        private DevExpress.XtraEditors.LabelControl labPrepared;
        private DevExpress.XtraEditors.SimpleButton btnSaveExcel;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.TextEdit textCommon;
        private DevExpress.XtraEditors.DateEdit dateCurrentDateEnd;
        private DevExpress.XtraEditors.DateEdit dateCurrentDateBegin;
        private DevExpress.XtraEditors.LabelControl labCommon;
        private DevExpress.XtraEditors.LabelControl lab1;
        private DevExpress.XtraEditors.LabelControl labCurrentDate;
        private DevExpress.XtraEditors.CheckEdit checkReqDate;
        private DevExpress.XtraEditors.DateEdit dateReqDateEnd;
        private DevExpress.XtraEditors.DateEdit dateReqDateBegin;
        private DevExpress.XtraEditors.LabelControl labReqDate;
        private DevExpress.XtraEditors.LabelControl lab2;
        private DevExpress.XtraEditors.PanelControl pnlMiddle;
        private DevExpress.XtraGrid.GridControl gridControlProductionSchedule;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProductionSchedule;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colPsNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPsState;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrentDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPlannedText;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpReqDep;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesOrderNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repSearchBussinessBaseNo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridCBussinessBaseNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridCBussinessBaseText;
        private DevExpress.XtraGrid.Columns.GridColumn gridCBussinessCategoryText;
        private DevExpress.XtraGrid.Columns.GridColumn gridCAutoId;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repSpinTax;
        private DevExpress.XtraGrid.Columns.GridColumn colReqDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpApprovalType;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheckIsVoucher;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colPrepared;
        private DevExpress.XtraGrid.Columns.GridColumn colModifier;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheckSelect;
    }
}