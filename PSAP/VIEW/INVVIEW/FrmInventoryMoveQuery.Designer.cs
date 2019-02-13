namespace PSAP.VIEW.BSVIEW
{
    partial class FrmInventoryMoveQuery
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
            this.lookUpOutRpertoryNo = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpReqDep = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpInRepertoryNo = new DevExpress.XtraEditors.LookUpEdit();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.textCommon = new DevExpress.XtraEditors.TextEdit();
            this.lookUpPrepared = new DevExpress.XtraEditors.LookUpEdit();
            this.dateIMDateEnd = new DevExpress.XtraEditors.DateEdit();
            this.lab1 = new DevExpress.XtraEditors.LabelControl();
            this.dateIMDateBegin = new DevExpress.XtraEditors.DateEdit();
            this.labReqDep = new DevExpress.XtraEditors.LabelControl();
            this.labOutRepertoryNo = new DevExpress.XtraEditors.LabelControl();
            this.labInRepertoryNo = new DevExpress.XtraEditors.LabelControl();
            this.labCommon = new DevExpress.XtraEditors.LabelControl();
            this.labPrepared = new DevExpress.XtraEditors.LabelControl();
            this.labIMDate = new DevExpress.XtraEditors.LabelControl();
            this.dataSet_IM = new System.Data.DataSet();
            this.dataTableIMHead = new System.Data.DataTable();
            this.dataColAutoId = new System.Data.DataColumn();
            this.dataColInventoryMoveNo = new System.Data.DataColumn();
            this.dataColInventoryMoveDate = new System.Data.DataColumn();
            this.dataColInRepertoryNo = new System.Data.DataColumn();
            this.dataColOutRepertoryNo = new System.Data.DataColumn();
            this.dataColPrepared = new System.Data.DataColumn();
            this.dataColPreparedIp = new System.Data.DataColumn();
            this.dataColumnRemark = new System.Data.DataColumn();
            this.dataColModifier = new System.Data.DataColumn();
            this.dataColModifierIp = new System.Data.DataColumn();
            this.dataColModifierTime = new System.Data.DataColumn();
            this.dataColReqDep = new System.Data.DataColumn();
            this.bindingSource_IMHead = new System.Windows.Forms.BindingSource(this.components);
            this.pnlBottom = new DevExpress.XtraEditors.PanelControl();
            this.gridBottomIM = new PSAP.VIEW.BSVIEW.GridBottom();
            this.pnlMiddle = new DevExpress.XtraEditors.PanelControl();
            this.gridControlIMHead = new DevExpress.XtraGrid.GridControl();
            this.gridViewIMHead = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInventoryMoveNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderHeadDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInRepertoryNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpInRepertoryNo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colOutRepertoryNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReqDep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpReqDep = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colPRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrepared = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifier = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pnltop)).BeginInit();
            this.pnltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpOutRpertoryNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpReqDep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpInRepertoryNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCommon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPrepared.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateIMDateEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateIMDateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateIMDateBegin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateIMDateBegin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_IM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableIMHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_IMHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).BeginInit();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddle)).BeginInit();
            this.pnlMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlIMHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewIMHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpInRepertoryNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpReqDep)).BeginInit();
            this.SuspendLayout();
            // 
            // pnltop
            // 
            this.pnltop.Controls.Add(this.btnSaveExcel);
            this.pnltop.Controls.Add(this.lookUpOutRpertoryNo);
            this.pnltop.Controls.Add(this.lookUpReqDep);
            this.pnltop.Controls.Add(this.lookUpInRepertoryNo);
            this.pnltop.Controls.Add(this.btnQuery);
            this.pnltop.Controls.Add(this.textCommon);
            this.pnltop.Controls.Add(this.lookUpPrepared);
            this.pnltop.Controls.Add(this.dateIMDateEnd);
            this.pnltop.Controls.Add(this.lab1);
            this.pnltop.Controls.Add(this.dateIMDateBegin);
            this.pnltop.Controls.Add(this.labReqDep);
            this.pnltop.Controls.Add(this.labOutRepertoryNo);
            this.pnltop.Controls.Add(this.labInRepertoryNo);
            this.pnltop.Controls.Add(this.labCommon);
            this.pnltop.Controls.Add(this.labPrepared);
            this.pnltop.Controls.Add(this.labIMDate);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Margin = new System.Windows.Forms.Padding(4);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(1159, 78);
            this.pnltop.TabIndex = 2;
            // 
            // btnSaveExcel
            // 
            this.btnSaveExcel.Location = new System.Drawing.Point(547, 43);
            this.btnSaveExcel.Name = "btnSaveExcel";
            this.btnSaveExcel.Size = new System.Drawing.Size(75, 23);
            this.btnSaveExcel.TabIndex = 34;
            this.btnSaveExcel.Text = "存为Excel";
            this.btnSaveExcel.Click += new System.EventHandler(this.btnSaveExcel_Click);
            // 
            // lookUpOutRpertoryNo
            // 
            this.lookUpOutRpertoryNo.EnterMoveNextControl = true;
            this.lookUpOutRpertoryNo.Location = new System.Drawing.Point(591, 14);
            this.lookUpOutRpertoryNo.Margin = new System.Windows.Forms.Padding(4);
            this.lookUpOutRpertoryNo.Name = "lookUpOutRpertoryNo";
            this.lookUpOutRpertoryNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpOutRpertoryNo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AutoId", "AutoId", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RepertoryNo", "仓库编号"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RepertoryName", "仓库名称"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RepertoryTypeText", "仓库类型")});
            this.lookUpOutRpertoryNo.Properties.DisplayMember = "RepertoryName";
            this.lookUpOutRpertoryNo.Properties.NullText = "";
            this.lookUpOutRpertoryNo.Properties.ValueMember = "RepertoryNo";
            this.lookUpOutRpertoryNo.Size = new System.Drawing.Size(120, 20);
            this.lookUpOutRpertoryNo.TabIndex = 33;
            // 
            // lookUpReqDep
            // 
            this.lookUpReqDep.EnterMoveNextControl = true;
            this.lookUpReqDep.Location = new System.Drawing.Point(772, 14);
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
            this.lookUpReqDep.TabIndex = 4;
            // 
            // lookUpInRepertoryNo
            // 
            this.lookUpInRepertoryNo.EnterMoveNextControl = true;
            this.lookUpInRepertoryNo.Location = new System.Drawing.Point(387, 14);
            this.lookUpInRepertoryNo.Margin = new System.Windows.Forms.Padding(4);
            this.lookUpInRepertoryNo.Name = "lookUpInRepertoryNo";
            this.lookUpInRepertoryNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpInRepertoryNo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AutoId", "AutoId", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RepertoryNo", "仓库编号"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RepertoryName", "仓库名称"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RepertoryTypeText", "仓库类型")});
            this.lookUpInRepertoryNo.Properties.DisplayMember = "RepertoryName";
            this.lookUpInRepertoryNo.Properties.NullText = "";
            this.lookUpInRepertoryNo.Properties.ValueMember = "RepertoryNo";
            this.lookUpInRepertoryNo.Size = new System.Drawing.Size(120, 20);
            this.lookUpInRepertoryNo.TabIndex = 2;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(455, 43);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 7;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // textCommon
            // 
            this.textCommon.EnterMoveNextControl = true;
            this.textCommon.Location = new System.Drawing.Point(280, 44);
            this.textCommon.Margin = new System.Windows.Forms.Padding(4);
            this.textCommon.Name = "textCommon";
            this.textCommon.Size = new System.Drawing.Size(150, 20);
            this.textCommon.TabIndex = 6;
            // 
            // lookUpPrepared
            // 
            this.lookUpPrepared.EnterMoveNextControl = true;
            this.lookUpPrepared.Location = new System.Drawing.Point(76, 44);
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
            this.lookUpPrepared.TabIndex = 5;
            // 
            // dateIMDateEnd
            // 
            this.dateIMDateEnd.EditValue = null;
            this.dateIMDateEnd.EnterMoveNextControl = true;
            this.dateIMDateEnd.Location = new System.Drawing.Point(202, 14);
            this.dateIMDateEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dateIMDateEnd.Name = "dateIMDateEnd";
            this.dateIMDateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateIMDateEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateIMDateEnd.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dateIMDateEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateIMDateEnd.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateIMDateEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateIMDateEnd.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateIMDateEnd.Size = new System.Drawing.Size(100, 20);
            this.dateIMDateEnd.TabIndex = 1;
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
            // dateIMDateBegin
            // 
            this.dateIMDateBegin.EditValue = null;
            this.dateIMDateBegin.EnterMoveNextControl = true;
            this.dateIMDateBegin.Location = new System.Drawing.Point(86, 14);
            this.dateIMDateBegin.Margin = new System.Windows.Forms.Padding(4);
            this.dateIMDateBegin.Name = "dateIMDateBegin";
            this.dateIMDateBegin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateIMDateBegin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateIMDateBegin.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dateIMDateBegin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateIMDateBegin.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateIMDateBegin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateIMDateBegin.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateIMDateBegin.Size = new System.Drawing.Size(100, 20);
            this.dateIMDateBegin.TabIndex = 0;
            // 
            // labReqDep
            // 
            this.labReqDep.Location = new System.Drawing.Point(728, 17);
            this.labReqDep.Margin = new System.Windows.Forms.Padding(4);
            this.labReqDep.Name = "labReqDep";
            this.labReqDep.Size = new System.Drawing.Size(36, 14);
            this.labReqDep.TabIndex = 32;
            this.labReqDep.Text = "部门：";
            // 
            // labOutRepertoryNo
            // 
            this.labOutRepertoryNo.Location = new System.Drawing.Point(523, 17);
            this.labOutRepertoryNo.Margin = new System.Windows.Forms.Padding(4);
            this.labOutRepertoryNo.Name = "labOutRepertoryNo";
            this.labOutRepertoryNo.Size = new System.Drawing.Size(60, 14);
            this.labOutRepertoryNo.TabIndex = 28;
            this.labOutRepertoryNo.Text = "出库仓库：";
            // 
            // labInRepertoryNo
            // 
            this.labInRepertoryNo.Location = new System.Drawing.Point(319, 17);
            this.labInRepertoryNo.Margin = new System.Windows.Forms.Padding(4);
            this.labInRepertoryNo.Name = "labInRepertoryNo";
            this.labInRepertoryNo.Size = new System.Drawing.Size(60, 14);
            this.labInRepertoryNo.TabIndex = 26;
            this.labInRepertoryNo.Text = "入库仓库：";
            // 
            // labCommon
            // 
            this.labCommon.Location = new System.Drawing.Point(212, 47);
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
            // labIMDate
            // 
            this.labIMDate.Location = new System.Drawing.Point(20, 17);
            this.labIMDate.Margin = new System.Windows.Forms.Padding(4);
            this.labIMDate.Name = "labIMDate";
            this.labIMDate.Size = new System.Drawing.Size(60, 14);
            this.labIMDate.TabIndex = 5;
            this.labIMDate.Text = "移动日期：";
            // 
            // dataSet_IM
            // 
            this.dataSet_IM.DataSetName = "NewDataSet";
            this.dataSet_IM.EnforceConstraints = false;
            this.dataSet_IM.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTableIMHead});
            // 
            // dataTableIMHead
            // 
            this.dataTableIMHead.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColAutoId,
            this.dataColInventoryMoveNo,
            this.dataColInventoryMoveDate,
            this.dataColInRepertoryNo,
            this.dataColOutRepertoryNo,
            this.dataColPrepared,
            this.dataColPreparedIp,
            this.dataColumnRemark,
            this.dataColModifier,
            this.dataColModifierIp,
            this.dataColModifierTime,
            this.dataColReqDep});
            this.dataTableIMHead.TableName = "IMHead";
            // 
            // dataColAutoId
            // 
            this.dataColAutoId.ColumnName = "AutoId";
            this.dataColAutoId.DataType = typeof(int);
            // 
            // dataColInventoryMoveNo
            // 
            this.dataColInventoryMoveNo.Caption = "移动单号";
            this.dataColInventoryMoveNo.ColumnName = "InventoryMoveNo";
            // 
            // dataColInventoryMoveDate
            // 
            this.dataColInventoryMoveDate.Caption = "移动日期";
            this.dataColInventoryMoveDate.ColumnName = "InventoryMoveDate";
            this.dataColInventoryMoveDate.DataType = typeof(System.DateTime);
            // 
            // dataColInRepertoryNo
            // 
            this.dataColInRepertoryNo.Caption = "入库仓库";
            this.dataColInRepertoryNo.ColumnName = "InRepertoryNo";
            // 
            // dataColOutRepertoryNo
            // 
            this.dataColOutRepertoryNo.Caption = "出库仓库";
            this.dataColOutRepertoryNo.ColumnName = "OutRepertoryNo";
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
            // dataColReqDep
            // 
            this.dataColReqDep.Caption = "部门";
            this.dataColReqDep.ColumnName = "ReqDep";
            // 
            // bindingSource_IMHead
            // 
            this.bindingSource_IMHead.DataMember = "IMHead";
            this.bindingSource_IMHead.DataSource = this.dataSet_IM;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.gridBottomIM);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 557);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1159, 58);
            this.pnlBottom.TabIndex = 4;
            // 
            // gridBottomIM
            // 
            this.gridBottomIM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBottomIM.Location = new System.Drawing.Point(2, 2);
            this.gridBottomIM.MasterDataSet = this.dataSet_IM;
            this.gridBottomIM.Name = "gridBottomIM";
            this.gridBottomIM.pageRowCount = 5;
            this.gridBottomIM.Size = new System.Drawing.Size(1155, 54);
            this.gridBottomIM.TabIndex = 0;
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.Controls.Add(this.gridControlIMHead);
            this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMiddle.Location = new System.Drawing.Point(0, 78);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(1159, 479);
            this.pnlMiddle.TabIndex = 5;
            // 
            // gridControlIMHead
            // 
            this.gridControlIMHead.DataSource = this.bindingSource_IMHead;
            this.gridControlIMHead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlIMHead.Location = new System.Drawing.Point(2, 2);
            this.gridControlIMHead.MainView = this.gridViewIMHead;
            this.gridControlIMHead.Name = "gridControlIMHead";
            this.gridControlIMHead.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repLookUpReqDep,
            this.repLookUpInRepertoryNo});
            this.gridControlIMHead.Size = new System.Drawing.Size(1155, 475);
            this.gridControlIMHead.TabIndex = 4;
            this.gridControlIMHead.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewIMHead});
            // 
            // gridViewIMHead
            // 
            this.gridViewIMHead.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId,
            this.colInventoryMoveNo,
            this.colOrderHeadDate,
            this.colInRepertoryNo,
            this.colOutRepertoryNo,
            this.colReqDep,
            this.colPRemark,
            this.colPrepared,
            this.colModifier});
            this.gridViewIMHead.GridControl = this.gridControlIMHead;
            this.gridViewIMHead.IndicatorWidth = 40;
            this.gridViewIMHead.Name = "gridViewIMHead";
            this.gridViewIMHead.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewIMHead.OptionsBehavior.Editable = false;
            this.gridViewIMHead.OptionsBehavior.ReadOnly = true;
            this.gridViewIMHead.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewIMHead.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewIMHead.OptionsView.ColumnAutoWidth = false;
            this.gridViewIMHead.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewIMHead.OptionsView.ShowFooter = true;
            this.gridViewIMHead.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewIMHead_RowClick);
            this.gridViewIMHead.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewIMHead_CustomDrawRowIndicator);
            // 
            // colAutoId
            // 
            this.colAutoId.FieldName = "AutoId";
            this.colAutoId.Name = "colAutoId";
            // 
            // colInventoryMoveNo
            // 
            this.colInventoryMoveNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colInventoryMoveNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInventoryMoveNo.FieldName = "InventoryMoveNo";
            this.colInventoryMoveNo.Name = "colInventoryMoveNo";
            this.colInventoryMoveNo.OptionsColumn.AllowEdit = false;
            this.colInventoryMoveNo.OptionsColumn.AllowFocus = false;
            this.colInventoryMoveNo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "InventoryMoveNo", "共计{0}条")});
            this.colInventoryMoveNo.Visible = true;
            this.colInventoryMoveNo.VisibleIndex = 0;
            this.colInventoryMoveNo.Width = 110;
            // 
            // colOrderHeadDate
            // 
            this.colOrderHeadDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colOrderHeadDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOrderHeadDate.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.colOrderHeadDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colOrderHeadDate.FieldName = "InventoryMoveDate";
            this.colOrderHeadDate.Name = "colOrderHeadDate";
            this.colOrderHeadDate.OptionsColumn.AllowEdit = false;
            this.colOrderHeadDate.OptionsColumn.AllowFocus = false;
            this.colOrderHeadDate.Visible = true;
            this.colOrderHeadDate.VisibleIndex = 1;
            this.colOrderHeadDate.Width = 90;
            // 
            // colInRepertoryNo
            // 
            this.colInRepertoryNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colInRepertoryNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInRepertoryNo.ColumnEdit = this.repLookUpInRepertoryNo;
            this.colInRepertoryNo.FieldName = "InRepertoryNo";
            this.colInRepertoryNo.Name = "colInRepertoryNo";
            this.colInRepertoryNo.OptionsColumn.AllowEdit = false;
            this.colInRepertoryNo.Visible = true;
            this.colInRepertoryNo.VisibleIndex = 3;
            this.colInRepertoryNo.Width = 100;
            // 
            // repLookUpInRepertoryNo
            // 
            this.repLookUpInRepertoryNo.AutoHeight = false;
            this.repLookUpInRepertoryNo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpInRepertoryNo.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AutoId", "AutoId", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RepertoryNo", "仓库编号"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RepertoryName", "仓库名称"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RepertoryTypeText", "仓库类型")});
            this.repLookUpInRepertoryNo.DisplayMember = "RepertoryName";
            this.repLookUpInRepertoryNo.Name = "repLookUpInRepertoryNo";
            this.repLookUpInRepertoryNo.NullText = "";
            this.repLookUpInRepertoryNo.ValueMember = "RepertoryNo";
            // 
            // colOutRepertoryNo
            // 
            this.colOutRepertoryNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colOutRepertoryNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOutRepertoryNo.ColumnEdit = this.repLookUpInRepertoryNo;
            this.colOutRepertoryNo.FieldName = "OutRepertoryNo";
            this.colOutRepertoryNo.Name = "colOutRepertoryNo";
            this.colOutRepertoryNo.OptionsColumn.AllowEdit = false;
            this.colOutRepertoryNo.Visible = true;
            this.colOutRepertoryNo.VisibleIndex = 2;
            this.colOutRepertoryNo.Width = 100;
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
            this.colReqDep.VisibleIndex = 4;
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
            // colPRemark
            // 
            this.colPRemark.AppearanceHeader.Options.UseTextOptions = true;
            this.colPRemark.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPRemark.FieldName = "Remark";
            this.colPRemark.Name = "colPRemark";
            this.colPRemark.OptionsColumn.AllowEdit = false;
            this.colPRemark.Visible = true;
            this.colPRemark.VisibleIndex = 5;
            this.colPRemark.Width = 140;
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
            this.colPrepared.VisibleIndex = 6;
            this.colPrepared.Width = 80;
            // 
            // colModifier
            // 
            this.colModifier.AppearanceHeader.Options.UseTextOptions = true;
            this.colModifier.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colModifier.FieldName = "Modifier";
            this.colModifier.Name = "colModifier";
            this.colModifier.Visible = true;
            this.colModifier.VisibleIndex = 7;
            this.colModifier.Width = 80;
            // 
            // FrmInventoryMoveQuery
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1159, 615);
            this.Controls.Add(this.pnlMiddle);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnltop);
            this.Name = "FrmInventoryMoveQuery";
            this.TabText = "库存移动查询";
            this.Text = "库存移动查询";
            this.Load += new System.EventHandler(this.FrmInventoryMoveQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnltop)).EndInit();
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpOutRpertoryNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpReqDep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpInRepertoryNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCommon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPrepared.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateIMDateEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateIMDateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateIMDateBegin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateIMDateBegin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_IM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableIMHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_IMHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddle)).EndInit();
            this.pnlMiddle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlIMHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewIMHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpInRepertoryNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpReqDep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnltop;
        private DevExpress.XtraEditors.LookUpEdit lookUpOutRpertoryNo;
        private DevExpress.XtraEditors.LookUpEdit lookUpReqDep;
        private DevExpress.XtraEditors.LookUpEdit lookUpInRepertoryNo;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.TextEdit textCommon;
        private DevExpress.XtraEditors.LookUpEdit lookUpPrepared;
        private DevExpress.XtraEditors.DateEdit dateIMDateEnd;
        private DevExpress.XtraEditors.LabelControl lab1;
        private DevExpress.XtraEditors.DateEdit dateIMDateBegin;
        private DevExpress.XtraEditors.LabelControl labReqDep;
        private DevExpress.XtraEditors.LabelControl labOutRepertoryNo;
        private DevExpress.XtraEditors.LabelControl labInRepertoryNo;
        private DevExpress.XtraEditors.LabelControl labCommon;
        private DevExpress.XtraEditors.LabelControl labPrepared;
        private DevExpress.XtraEditors.LabelControl labIMDate;
        private DevExpress.XtraEditors.SimpleButton btnSaveExcel;
        private System.Data.DataSet dataSet_IM;
        private System.Data.DataTable dataTableIMHead;
        private System.Data.DataColumn dataColAutoId;
        private System.Data.DataColumn dataColInventoryMoveNo;
        private System.Data.DataColumn dataColInventoryMoveDate;
        private System.Data.DataColumn dataColInRepertoryNo;
        private System.Data.DataColumn dataColOutRepertoryNo;
        private System.Data.DataColumn dataColPrepared;
        private System.Data.DataColumn dataColPreparedIp;
        private System.Data.DataColumn dataColumnRemark;
        private System.Data.DataColumn dataColModifier;
        private System.Data.DataColumn dataColModifierIp;
        private System.Data.DataColumn dataColModifierTime;
        private System.Data.DataColumn dataColReqDep;
        private System.Windows.Forms.BindingSource bindingSource_IMHead;
        private DevExpress.XtraEditors.PanelControl pnlBottom;
        private GridBottom gridBottomIM;
        private DevExpress.XtraEditors.PanelControl pnlMiddle;
        private DevExpress.XtraGrid.GridControl gridControlIMHead;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewIMHead;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colInventoryMoveNo;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderHeadDate;
        private DevExpress.XtraGrid.Columns.GridColumn colInRepertoryNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpInRepertoryNo;
        private DevExpress.XtraGrid.Columns.GridColumn colOutRepertoryNo;
        private DevExpress.XtraGrid.Columns.GridColumn colReqDep;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpReqDep;
        private DevExpress.XtraGrid.Columns.GridColumn colPRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colPrepared;
        private DevExpress.XtraGrid.Columns.GridColumn colModifier;
    }
}