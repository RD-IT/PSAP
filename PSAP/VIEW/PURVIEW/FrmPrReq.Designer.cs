namespace PSAP.VIEW.BSVIEW
{
    partial class FrmPrReq
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
            this.textCommon = new DevExpress.XtraEditors.TextEdit();
            this.labCommon = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxReqState = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labApplicant = new DevExpress.XtraEditors.LabelControl();
            this.lookUpApplicant = new DevExpress.XtraEditors.LookUpEdit();
            this.labReqState = new DevExpress.XtraEditors.LabelControl();
            this.lookUpPurCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.labPurCategory = new DevExpress.XtraEditors.LabelControl();
            this.lookUpReqDep = new DevExpress.XtraEditors.LookUpEdit();
            this.labReqDep = new DevExpress.XtraEditors.LabelControl();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.dateReqDateEnd = new DevExpress.XtraEditors.DateEdit();
            this.lab = new DevExpress.XtraEditors.LabelControl();
            this.labReqDate = new DevExpress.XtraEditors.LabelControl();
            this.dateReqDateBegin = new DevExpress.XtraEditors.DateEdit();
            this.dataSet_PrReq = new System.Data.DataSet();
            this.dataTablePrReqHead = new System.Data.DataTable();
            this.dataColAutoId = new System.Data.DataColumn();
            this.dataColPrReqNo = new System.Data.DataColumn();
            this.dataColReqDate = new System.Data.DataColumn();
            this.dataColReqDep = new System.Data.DataColumn();
            this.dataColProjectNo = new System.Data.DataColumn();
            this.dataColStnNo = new System.Data.DataColumn();
            this.dataColPurCategory = new System.Data.DataColumn();
            this.dataColReqState = new System.Data.DataColumn();
            this.dataColApplicant = new System.Data.DataColumn();
            this.dataColApplicantIp = new System.Data.DataColumn();
            this.dataColApplicantTime = new System.Data.DataColumn();
            this.dataColModifier = new System.Data.DataColumn();
            this.dataColModifierIp = new System.Data.DataColumn();
            this.dataColModifierTime = new System.Data.DataColumn();
            this.dataColApprover = new System.Data.DataColumn();
            this.dataColApproverIp = new System.Data.DataColumn();
            this.dataColApproverTime = new System.Data.DataColumn();
            this.dataColPrReqRemark = new System.Data.DataColumn();
            this.dataColSelect = new System.Data.DataColumn();
            this.dataColClosed = new System.Data.DataColumn();
            this.dataColClosedIp = new System.Data.DataColumn();
            this.dataColClosedTime = new System.Data.DataColumn();
            this.dataTablePrReqList = new System.Data.DataTable();
            this.dataColumnAutoId = new System.Data.DataColumn();
            this.dataColumnPrReqNo = new System.Data.DataColumn();
            this.dataColCodeFileName = new System.Data.DataColumn();
            this.dataColQty = new System.Data.DataColumn();
            this.dataColRequirementDate = new System.Data.DataColumn();
            this.dataColPrReqListRemark = new System.Data.DataColumn();
            this.dataColCodeName = new System.Data.DataColumn();
            this.pnlMiddle = new DevExpress.XtraEditors.PanelControl();
            this.checkAll = new DevExpress.XtraEditors.CheckEdit();
            this.gridControlPrReqHead = new DevExpress.XtraGrid.GridControl();
            this.bindingSource_PrReqHead = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewPrReqHead = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColSelect = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCheckSelect = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colPrReqNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReqState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReqDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReqDep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpReqDep = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colProjectNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSearchProjectNo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repSearchProjectNoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnProjectNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnProjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStnNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repComboBoxStnNo = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colPurCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpPurCategory = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colApplicant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrReqRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApprover = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClosed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlMiddleTop = new DevExpress.XtraEditors.PanelControl();
            this.btnCancelClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnPreview = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelApprove = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnApprove = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.pnlBottom = new DevExpress.XtraEditors.PanelControl();
            this.btnListAdd = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlPrReqList = new DevExpress.XtraGrid.GridControl();
            this.bindingSource_PrReqList = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewPrReqList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrReqNo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodeFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSearchCodeFileName = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repSearchCodeFileNameView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCodeFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCodeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSpinQty = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colRequirementDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrReqListRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repbtnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colCodeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnltop)).BeginInit();
            this.pnltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textCommon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxReqState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpApplicant.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPurCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpReqDep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateReqDateEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateReqDateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateReqDateBegin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateReqDateBegin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_PrReq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablePrReqHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablePrReqList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddle)).BeginInit();
            this.pnlMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPrReqHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_PrReqHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPrReqHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpReqDep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchProjectNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchProjectNoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repComboBoxStnNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpPurCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddleTop)).BeginInit();
            this.pnlMiddleTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).BeginInit();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPrReqList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_PrReqList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPrReqList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchCodeFileName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchCodeFileNameView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repbtnDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // pnltop
            // 
            this.pnltop.Controls.Add(this.textCommon);
            this.pnltop.Controls.Add(this.labCommon);
            this.pnltop.Controls.Add(this.comboBoxReqState);
            this.pnltop.Controls.Add(this.labApplicant);
            this.pnltop.Controls.Add(this.lookUpApplicant);
            this.pnltop.Controls.Add(this.labReqState);
            this.pnltop.Controls.Add(this.lookUpPurCategory);
            this.pnltop.Controls.Add(this.labPurCategory);
            this.pnltop.Controls.Add(this.lookUpReqDep);
            this.pnltop.Controls.Add(this.labReqDep);
            this.pnltop.Controls.Add(this.btnQuery);
            this.pnltop.Controls.Add(this.dateReqDateEnd);
            this.pnltop.Controls.Add(this.lab);
            this.pnltop.Controls.Add(this.labReqDate);
            this.pnltop.Controls.Add(this.dateReqDateBegin);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(989, 78);
            this.pnltop.TabIndex = 0;
            // 
            // textCommon
            // 
            this.textCommon.EnterMoveNextControl = true;
            this.textCommon.Location = new System.Drawing.Point(436, 44);
            this.textCommon.Name = "textCommon";
            this.textCommon.Size = new System.Drawing.Size(150, 20);
            this.textCommon.TabIndex = 13;
            // 
            // labCommon
            // 
            this.labCommon.Location = new System.Drawing.Point(370, 47);
            this.labCommon.Name = "labCommon";
            this.labCommon.Size = new System.Drawing.Size(60, 14);
            this.labCommon.TabIndex = 14;
            this.labCommon.Text = "通用查询：";
            // 
            // comboBoxReqState
            // 
            this.comboBoxReqState.EnterMoveNextControl = true;
            this.comboBoxReqState.Location = new System.Drawing.Point(86, 44);
            this.comboBoxReqState.Name = "comboBoxReqState";
            this.comboBoxReqState.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxReqState.Properties.Items.AddRange(new object[] {
            "全部",
            "待审批",
            "审批",
            "关闭"});
            this.comboBoxReqState.Size = new System.Drawing.Size(100, 20);
            this.comboBoxReqState.TabIndex = 4;
            // 
            // labApplicant
            // 
            this.labApplicant.Location = new System.Drawing.Point(202, 47);
            this.labApplicant.Name = "labApplicant";
            this.labApplicant.Size = new System.Drawing.Size(48, 14);
            this.labApplicant.TabIndex = 11;
            this.labApplicant.Text = "申请人：";
            // 
            // lookUpApplicant
            // 
            this.lookUpApplicant.EnterMoveNextControl = true;
            this.lookUpApplicant.Location = new System.Drawing.Point(254, 44);
            this.lookUpApplicant.Name = "lookUpApplicant";
            this.lookUpApplicant.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpApplicant.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AutoId", "AutoId", 80, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LoginId", "用户名", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmpName", "员工名", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpApplicant.Properties.DisplayMember = "EmpName";
            this.lookUpApplicant.Properties.NullText = "";
            this.lookUpApplicant.Properties.ValueMember = "EmpName";
            this.lookUpApplicant.Size = new System.Drawing.Size(100, 20);
            this.lookUpApplicant.TabIndex = 5;
            // 
            // labReqState
            // 
            this.labReqState.Location = new System.Drawing.Point(20, 47);
            this.labReqState.Name = "labReqState";
            this.labReqState.Size = new System.Drawing.Size(60, 14);
            this.labReqState.TabIndex = 9;
            this.labReqState.Text = "单据状态：";
            // 
            // lookUpPurCategory
            // 
            this.lookUpPurCategory.EnterMoveNextControl = true;
            this.lookUpPurCategory.Location = new System.Drawing.Point(562, 14);
            this.lookUpPurCategory.Name = "lookUpPurCategory";
            this.lookUpPurCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpPurCategory.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PurCategory", "编号", 81, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PurCategoryText", "名称", 111, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpPurCategory.Properties.DisplayMember = "PurCategoryText";
            this.lookUpPurCategory.Properties.NullText = "";
            this.lookUpPurCategory.Properties.ValueMember = "PurCategory";
            this.lookUpPurCategory.Size = new System.Drawing.Size(100, 20);
            this.lookUpPurCategory.TabIndex = 3;
            // 
            // labPurCategory
            // 
            this.labPurCategory.Location = new System.Drawing.Point(496, 17);
            this.labPurCategory.Name = "labPurCategory";
            this.labPurCategory.Size = new System.Drawing.Size(60, 14);
            this.labPurCategory.TabIndex = 7;
            this.labPurCategory.Text = "采购类型：";
            // 
            // lookUpReqDep
            // 
            this.lookUpReqDep.EnterMoveNextControl = true;
            this.lookUpReqDep.Location = new System.Drawing.Point(381, 14);
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
            this.lookUpReqDep.TabIndex = 2;
            // 
            // labReqDep
            // 
            this.labReqDep.Location = new System.Drawing.Point(315, 17);
            this.labReqDep.Name = "labReqDep";
            this.labReqDep.Size = new System.Drawing.Size(60, 14);
            this.labReqDep.TabIndex = 5;
            this.labReqDep.Text = "申请部门：";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(602, 43);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 6;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dateReqDateEnd
            // 
            this.dateReqDateEnd.EditValue = null;
            this.dateReqDateEnd.EnterMoveNextControl = true;
            this.dateReqDateEnd.Location = new System.Drawing.Point(202, 14);
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
            this.dateReqDateEnd.TabIndex = 1;
            // 
            // lab
            // 
            this.lab.Location = new System.Drawing.Point(192, 17);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(4, 14);
            this.lab.TabIndex = 2;
            this.lab.Text = "-";
            // 
            // labReqDate
            // 
            this.labReqDate.Location = new System.Drawing.Point(20, 17);
            this.labReqDate.Name = "labReqDate";
            this.labReqDate.Size = new System.Drawing.Size(60, 14);
            this.labReqDate.TabIndex = 1;
            this.labReqDate.Text = "请购日期：";
            // 
            // dateReqDateBegin
            // 
            this.dateReqDateBegin.EditValue = null;
            this.dateReqDateBegin.EnterMoveNextControl = true;
            this.dateReqDateBegin.Location = new System.Drawing.Point(86, 14);
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
            this.dateReqDateBegin.TabIndex = 0;
            // 
            // dataSet_PrReq
            // 
            this.dataSet_PrReq.DataSetName = "NewDataSet";
            this.dataSet_PrReq.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTablePrReqHead,
            this.dataTablePrReqList});
            // 
            // dataTablePrReqHead
            // 
            this.dataTablePrReqHead.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColAutoId,
            this.dataColPrReqNo,
            this.dataColReqDate,
            this.dataColReqDep,
            this.dataColProjectNo,
            this.dataColStnNo,
            this.dataColPurCategory,
            this.dataColReqState,
            this.dataColApplicant,
            this.dataColApplicantIp,
            this.dataColApplicantTime,
            this.dataColModifier,
            this.dataColModifierIp,
            this.dataColModifierTime,
            this.dataColApprover,
            this.dataColApproverIp,
            this.dataColApproverTime,
            this.dataColPrReqRemark,
            this.dataColSelect,
            this.dataColClosed,
            this.dataColClosedIp,
            this.dataColClosedTime});
            this.dataTablePrReqHead.TableName = "PrReqHead";
            // 
            // dataColAutoId
            // 
            this.dataColAutoId.ColumnName = "AutoId";
            this.dataColAutoId.DataType = typeof(int);
            // 
            // dataColPrReqNo
            // 
            this.dataColPrReqNo.Caption = "请购单号";
            this.dataColPrReqNo.ColumnName = "PrReqNo";
            // 
            // dataColReqDate
            // 
            this.dataColReqDate.Caption = "请购日期";
            this.dataColReqDate.ColumnName = "ReqDate";
            this.dataColReqDate.DataType = typeof(System.DateTime);
            // 
            // dataColReqDep
            // 
            this.dataColReqDep.Caption = "申请部门";
            this.dataColReqDep.ColumnName = "ReqDep";
            // 
            // dataColProjectNo
            // 
            this.dataColProjectNo.Caption = "项目号";
            this.dataColProjectNo.ColumnName = "ProjectNo";
            // 
            // dataColStnNo
            // 
            this.dataColStnNo.Caption = "站号";
            this.dataColStnNo.ColumnName = "StnNo";
            // 
            // dataColPurCategory
            // 
            this.dataColPurCategory.Caption = "采购类型";
            this.dataColPurCategory.ColumnName = "PurCategory";
            // 
            // dataColReqState
            // 
            this.dataColReqState.Caption = "状态";
            this.dataColReqState.ColumnName = "ReqState";
            this.dataColReqState.DataType = typeof(short);
            // 
            // dataColApplicant
            // 
            this.dataColApplicant.Caption = "申请人";
            this.dataColApplicant.ColumnName = "Applicant";
            // 
            // dataColApplicantIp
            // 
            this.dataColApplicantIp.Caption = "申请人IP";
            this.dataColApplicantIp.ColumnName = "ApplicantIp";
            // 
            // dataColApplicantTime
            // 
            this.dataColApplicantTime.Caption = "申请时间";
            this.dataColApplicantTime.ColumnName = "ApplicantTime";
            this.dataColApplicantTime.DataType = typeof(System.DateTime);
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
            // dataColApprover
            // 
            this.dataColApprover.Caption = "审批人";
            this.dataColApprover.ColumnName = "Approver";
            // 
            // dataColApproverIp
            // 
            this.dataColApproverIp.Caption = "审批人IP";
            this.dataColApproverIp.ColumnName = "ApproverIp";
            // 
            // dataColApproverTime
            // 
            this.dataColApproverTime.Caption = "审批时间";
            this.dataColApproverTime.ColumnName = "ApproverTime";
            this.dataColApproverTime.DataType = typeof(System.DateTime);
            // 
            // dataColPrReqRemark
            // 
            this.dataColPrReqRemark.Caption = "备注";
            this.dataColPrReqRemark.ColumnName = "PrReqRemark";
            // 
            // dataColSelect
            // 
            this.dataColSelect.Caption = "";
            this.dataColSelect.ColumnName = "Select";
            this.dataColSelect.DataType = typeof(bool);
            // 
            // dataColClosed
            // 
            this.dataColClosed.Caption = "关闭人";
            this.dataColClosed.ColumnName = "Closed";
            // 
            // dataColClosedIp
            // 
            this.dataColClosedIp.Caption = "关闭人IP";
            this.dataColClosedIp.ColumnName = "ClosedIp";
            // 
            // dataColClosedTime
            // 
            this.dataColClosedTime.Caption = "关闭时间";
            this.dataColClosedTime.ColumnName = "ClosedTime";
            this.dataColClosedTime.DataType = typeof(System.DateTime);
            // 
            // dataTablePrReqList
            // 
            this.dataTablePrReqList.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumnAutoId,
            this.dataColumnPrReqNo,
            this.dataColCodeFileName,
            this.dataColQty,
            this.dataColRequirementDate,
            this.dataColPrReqListRemark,
            this.dataColCodeName});
            this.dataTablePrReqList.TableName = "PrReqList";
            // 
            // dataColumnAutoId
            // 
            this.dataColumnAutoId.ColumnName = "AutoId";
            // 
            // dataColumnPrReqNo
            // 
            this.dataColumnPrReqNo.Caption = "请购单号";
            this.dataColumnPrReqNo.ColumnName = "PrReqNo";
            // 
            // dataColCodeFileName
            // 
            this.dataColCodeFileName.Caption = "文件名称";
            this.dataColCodeFileName.ColumnName = "CodeFileName";
            // 
            // dataColQty
            // 
            this.dataColQty.Caption = "数量";
            this.dataColQty.ColumnName = "Qty";
            this.dataColQty.DataType = typeof(double);
            // 
            // dataColRequirementDate
            // 
            this.dataColRequirementDate.Caption = "需求日期";
            this.dataColRequirementDate.ColumnName = "RequirementDate";
            this.dataColRequirementDate.DataType = typeof(System.DateTime);
            // 
            // dataColPrReqListRemark
            // 
            this.dataColPrReqListRemark.Caption = "备注";
            this.dataColPrReqListRemark.ColumnName = "PrReqListRemark";
            // 
            // dataColCodeName
            // 
            this.dataColCodeName.Caption = "零件名称";
            this.dataColCodeName.ColumnName = "CodeName";
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.Controls.Add(this.checkAll);
            this.pnlMiddle.Controls.Add(this.gridControlPrReqHead);
            this.pnlMiddle.Controls.Add(this.pnlMiddleTop);
            this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMiddle.Location = new System.Drawing.Point(0, 78);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(989, 212);
            this.pnlMiddle.TabIndex = 1;
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
            // gridControlPrReqHead
            // 
            this.gridControlPrReqHead.DataSource = this.bindingSource_PrReqHead;
            this.gridControlPrReqHead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPrReqHead.Location = new System.Drawing.Point(2, 36);
            this.gridControlPrReqHead.MainView = this.gridViewPrReqHead;
            this.gridControlPrReqHead.Name = "gridControlPrReqHead";
            this.gridControlPrReqHead.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repLookUpReqDep,
            this.repLookUpPurCategory,
            this.repSearchProjectNo,
            this.repComboBoxStnNo,
            this.repCheckSelect});
            this.gridControlPrReqHead.Size = new System.Drawing.Size(985, 174);
            this.gridControlPrReqHead.TabIndex = 0;
            this.gridControlPrReqHead.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPrReqHead});
            // 
            // bindingSource_PrReqHead
            // 
            this.bindingSource_PrReqHead.DataMember = "PrReqHead";
            this.bindingSource_PrReqHead.DataSource = this.dataSet_PrReq;
            // 
            // gridViewPrReqHead
            // 
            this.gridViewPrReqHead.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId,
            this.gridColSelect,
            this.colPrReqNo,
            this.colReqState,
            this.colReqDate,
            this.colReqDep,
            this.colProjectNo,
            this.colStnNo,
            this.colPurCategory,
            this.colApplicant,
            this.colPrReqRemark,
            this.colApprover,
            this.colClosed});
            this.gridViewPrReqHead.GridControl = this.gridControlPrReqHead;
            this.gridViewPrReqHead.IndicatorWidth = 40;
            this.gridViewPrReqHead.Name = "gridViewPrReqHead";
            this.gridViewPrReqHead.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewPrReqHead.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewPrReqHead.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewPrReqHead.OptionsView.ColumnAutoWidth = false;
            this.gridViewPrReqHead.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewPrReqHead.OptionsView.ShowFooter = true;
            this.gridViewPrReqHead.OptionsView.ShowGroupPanel = false;
            this.gridViewPrReqHead.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewPrReqHead_CustomDrawRowIndicator);
            this.gridViewPrReqHead.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridViewPrReqHead_InitNewRow);
            this.gridViewPrReqHead.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewPrReqHead_FocusedRowChanged);
            this.gridViewPrReqHead.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewPrReqHead_CellValueChanged);
            this.gridViewPrReqHead.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridViewPrReqHead_CustomColumnDisplayText);
            // 
            // colAutoId
            // 
            this.colAutoId.FieldName = "AutoId";
            this.colAutoId.Name = "colAutoId";
            // 
            // gridColSelect
            // 
            this.gridColSelect.ColumnEdit = this.repCheckSelect;
            this.gridColSelect.FieldName = "Select";
            this.gridColSelect.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridColSelect.Name = "gridColSelect";
            this.gridColSelect.Visible = true;
            this.gridColSelect.VisibleIndex = 0;
            this.gridColSelect.Width = 35;
            // 
            // repCheckSelect
            // 
            this.repCheckSelect.AutoHeight = false;
            this.repCheckSelect.Name = "repCheckSelect";
            this.repCheckSelect.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repCheckSelect.ValueGrayed = false;
            this.repCheckSelect.EditValueChanged += new System.EventHandler(this.repCheckSelect_EditValueChanged);
            // 
            // colPrReqNo
            // 
            this.colPrReqNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrReqNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrReqNo.FieldName = "PrReqNo";
            this.colPrReqNo.Name = "colPrReqNo";
            this.colPrReqNo.OptionsColumn.AllowEdit = false;
            this.colPrReqNo.OptionsColumn.AllowFocus = false;
            this.colPrReqNo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "PrReqNo", "共计{0}条")});
            this.colPrReqNo.Visible = true;
            this.colPrReqNo.VisibleIndex = 1;
            this.colPrReqNo.Width = 110;
            // 
            // colReqState
            // 
            this.colReqState.AppearanceHeader.Options.UseTextOptions = true;
            this.colReqState.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colReqState.FieldName = "ReqState";
            this.colReqState.Name = "colReqState";
            this.colReqState.OptionsColumn.AllowEdit = false;
            this.colReqState.OptionsColumn.AllowFocus = false;
            this.colReqState.Visible = true;
            this.colReqState.VisibleIndex = 2;
            this.colReqState.Width = 60;
            // 
            // colReqDate
            // 
            this.colReqDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colReqDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colReqDate.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.colReqDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colReqDate.FieldName = "ReqDate";
            this.colReqDate.Name = "colReqDate";
            this.colReqDate.OptionsColumn.AllowEdit = false;
            this.colReqDate.Visible = true;
            this.colReqDate.VisibleIndex = 3;
            this.colReqDate.Width = 90;
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
            this.colReqDep.VisibleIndex = 4;
            this.colReqDep.Width = 120;
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
            // colProjectNo
            // 
            this.colProjectNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colProjectNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProjectNo.ColumnEdit = this.repSearchProjectNo;
            this.colProjectNo.FieldName = "ProjectNo";
            this.colProjectNo.Name = "colProjectNo";
            this.colProjectNo.OptionsColumn.AllowEdit = false;
            this.colProjectNo.Visible = true;
            this.colProjectNo.VisibleIndex = 5;
            this.colProjectNo.Width = 100;
            // 
            // repSearchProjectNo
            // 
            this.repSearchProjectNo.AutoHeight = false;
            this.repSearchProjectNo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repSearchProjectNo.DisplayMember = "ProjectNo";
            this.repSearchProjectNo.Name = "repSearchProjectNo";
            this.repSearchProjectNo.NullText = "";
            this.repSearchProjectNo.ValueMember = "ProjectNo";
            this.repSearchProjectNo.View = this.repSearchProjectNoView;
            // 
            // repSearchProjectNoView
            // 
            this.repSearchProjectNoView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnProjectNo,
            this.gridColumnProjectName,
            this.gridColumnRemark});
            this.repSearchProjectNoView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repSearchProjectNoView.IndicatorWidth = 60;
            this.repSearchProjectNoView.Name = "repSearchProjectNoView";
            this.repSearchProjectNoView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repSearchProjectNoView.OptionsView.ShowGroupPanel = false;
            this.repSearchProjectNoView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.repSearchCodeFileNameView_CustomDrawRowIndicator);
            // 
            // gridColumnProjectNo
            // 
            this.gridColumnProjectNo.Caption = "项目号";
            this.gridColumnProjectNo.FieldName = "ProjectNo";
            this.gridColumnProjectNo.Name = "gridColumnProjectNo";
            this.gridColumnProjectNo.Visible = true;
            this.gridColumnProjectNo.VisibleIndex = 0;
            // 
            // gridColumnProjectName
            // 
            this.gridColumnProjectName.Caption = "项目名称";
            this.gridColumnProjectName.FieldName = "ProjectName";
            this.gridColumnProjectName.Name = "gridColumnProjectName";
            this.gridColumnProjectName.Visible = true;
            this.gridColumnProjectName.VisibleIndex = 1;
            // 
            // gridColumnRemark
            // 
            this.gridColumnRemark.Caption = "备注";
            this.gridColumnRemark.FieldName = "Remark";
            this.gridColumnRemark.Name = "gridColumnRemark";
            this.gridColumnRemark.Visible = true;
            this.gridColumnRemark.VisibleIndex = 2;
            // 
            // colStnNo
            // 
            this.colStnNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colStnNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStnNo.ColumnEdit = this.repComboBoxStnNo;
            this.colStnNo.FieldName = "StnNo";
            this.colStnNo.Name = "colStnNo";
            this.colStnNo.OptionsColumn.AllowEdit = false;
            this.colStnNo.Visible = true;
            this.colStnNo.VisibleIndex = 6;
            this.colStnNo.Width = 100;
            // 
            // repComboBoxStnNo
            // 
            this.repComboBoxStnNo.AutoHeight = false;
            this.repComboBoxStnNo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repComboBoxStnNo.DropDownRows = 10;
            this.repComboBoxStnNo.ImmediatePopup = true;
            this.repComboBoxStnNo.Name = "repComboBoxStnNo";
            // 
            // colPurCategory
            // 
            this.colPurCategory.AppearanceHeader.Options.UseTextOptions = true;
            this.colPurCategory.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPurCategory.ColumnEdit = this.repLookUpPurCategory;
            this.colPurCategory.FieldName = "PurCategory";
            this.colPurCategory.Name = "colPurCategory";
            this.colPurCategory.OptionsColumn.AllowEdit = false;
            this.colPurCategory.Visible = true;
            this.colPurCategory.VisibleIndex = 7;
            this.colPurCategory.Width = 80;
            // 
            // repLookUpPurCategory
            // 
            this.repLookUpPurCategory.AutoHeight = false;
            this.repLookUpPurCategory.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpPurCategory.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PurCategory", "编号", 81, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PurCategoryText", "名称", 111, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repLookUpPurCategory.DisplayMember = "PurCategoryText";
            this.repLookUpPurCategory.Name = "repLookUpPurCategory";
            this.repLookUpPurCategory.NullText = "";
            this.repLookUpPurCategory.ValueMember = "PurCategory";
            // 
            // colApplicant
            // 
            this.colApplicant.AppearanceHeader.Options.UseTextOptions = true;
            this.colApplicant.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colApplicant.FieldName = "Applicant";
            this.colApplicant.Name = "colApplicant";
            this.colApplicant.OptionsColumn.AllowEdit = false;
            this.colApplicant.OptionsColumn.AllowFocus = false;
            this.colApplicant.Visible = true;
            this.colApplicant.VisibleIndex = 9;
            this.colApplicant.Width = 70;
            // 
            // colPrReqRemark
            // 
            this.colPrReqRemark.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrReqRemark.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrReqRemark.FieldName = "PrReqRemark";
            this.colPrReqRemark.Name = "colPrReqRemark";
            this.colPrReqRemark.OptionsColumn.AllowEdit = false;
            this.colPrReqRemark.Visible = true;
            this.colPrReqRemark.VisibleIndex = 8;
            this.colPrReqRemark.Width = 140;
            // 
            // colApprover
            // 
            this.colApprover.AppearanceHeader.Options.UseTextOptions = true;
            this.colApprover.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colApprover.FieldName = "Approver";
            this.colApprover.Name = "colApprover";
            this.colApprover.OptionsColumn.AllowEdit = false;
            this.colApprover.OptionsColumn.AllowFocus = false;
            this.colApprover.Visible = true;
            this.colApprover.VisibleIndex = 10;
            this.colApprover.Width = 70;
            // 
            // colClosed
            // 
            this.colClosed.AppearanceHeader.Options.UseTextOptions = true;
            this.colClosed.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colClosed.FieldName = "Closed";
            this.colClosed.Name = "colClosed";
            this.colClosed.OptionsColumn.AllowEdit = false;
            this.colClosed.OptionsColumn.AllowFocus = false;
            this.colClosed.Visible = true;
            this.colClosed.VisibleIndex = 11;
            this.colClosed.Width = 70;
            // 
            // pnlMiddleTop
            // 
            this.pnlMiddleTop.Controls.Add(this.btnCancelClose);
            this.pnlMiddleTop.Controls.Add(this.btnPreview);
            this.pnlMiddleTop.Controls.Add(this.btnCancelApprove);
            this.pnlMiddleTop.Controls.Add(this.btnClose);
            this.pnlMiddleTop.Controls.Add(this.btnApprove);
            this.pnlMiddleTop.Controls.Add(this.btnDelete);
            this.pnlMiddleTop.Controls.Add(this.btnCancel);
            this.pnlMiddleTop.Controls.Add(this.btnSave);
            this.pnlMiddleTop.Controls.Add(this.btnNew);
            this.pnlMiddleTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMiddleTop.Location = new System.Drawing.Point(2, 2);
            this.pnlMiddleTop.Name = "pnlMiddleTop";
            this.pnlMiddleTop.Size = new System.Drawing.Size(985, 34);
            this.pnlMiddleTop.TabIndex = 1;
            // 
            // btnCancelClose
            // 
            this.btnCancelClose.Location = new System.Drawing.Point(572, 5);
            this.btnCancelClose.Name = "btnCancelClose";
            this.btnCancelClose.Size = new System.Drawing.Size(75, 23);
            this.btnCancelClose.TabIndex = 22;
            this.btnCancelClose.TabStop = false;
            this.btnCancelClose.Text = "取消关闭";
            this.btnCancelClose.Click += new System.EventHandler(this.btnCancelClose_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(653, 5);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 20;
            this.btnPreview.TabStop = false;
            this.btnPreview.Text = "预览";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnCancelApprove
            // 
            this.btnCancelApprove.Location = new System.Drawing.Point(410, 5);
            this.btnCancelApprove.Name = "btnCancelApprove";
            this.btnCancelApprove.Size = new System.Drawing.Size(75, 23);
            this.btnCancelApprove.TabIndex = 19;
            this.btnCancelApprove.TabStop = false;
            this.btnCancelApprove.Text = "取消审批";
            this.btnCancelApprove.Click += new System.EventHandler(this.btnCancelApprove_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(491, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 15;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnListAdd);
            this.pnlBottom.Controls.Add(this.gridControlPrReqList);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(0, 295);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(989, 156);
            this.pnlBottom.TabIndex = 2;
            // 
            // btnListAdd
            // 
            this.btnListAdd.Enabled = false;
            this.btnListAdd.Location = new System.Drawing.Point(2, 2);
            this.btnListAdd.Name = "btnListAdd";
            this.btnListAdd.Size = new System.Drawing.Size(40, 21);
            this.btnListAdd.TabIndex = 2;
            this.btnListAdd.Text = "+";
            this.btnListAdd.Click += new System.EventHandler(this.btnListAdd_Click);
            // 
            // gridControlPrReqList
            // 
            this.gridControlPrReqList.DataSource = this.bindingSource_PrReqList;
            this.gridControlPrReqList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPrReqList.Location = new System.Drawing.Point(2, 2);
            this.gridControlPrReqList.MainView = this.gridViewPrReqList;
            this.gridControlPrReqList.Name = "gridControlPrReqList";
            this.gridControlPrReqList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repSpinQty,
            this.repSearchCodeFileName,
            this.repbtnDelete});
            this.gridControlPrReqList.Size = new System.Drawing.Size(985, 152);
            this.gridControlPrReqList.TabIndex = 1;
            this.gridControlPrReqList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPrReqList});
            // 
            // bindingSource_PrReqList
            // 
            this.bindingSource_PrReqList.DataMember = "PrReqList";
            this.bindingSource_PrReqList.DataSource = this.dataSet_PrReq;
            // 
            // gridViewPrReqList
            // 
            this.gridViewPrReqList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId1,
            this.colPrReqNo1,
            this.colCodeFileName,
            this.colQty,
            this.colRequirementDate,
            this.colPrReqListRemark,
            this.colDelete,
            this.colCodeName});
            this.gridViewPrReqList.GridControl = this.gridControlPrReqList;
            this.gridViewPrReqList.IndicatorWidth = 40;
            this.gridViewPrReqList.Name = "gridViewPrReqList";
            this.gridViewPrReqList.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewPrReqList.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewPrReqList.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewPrReqList.OptionsView.ColumnAutoWidth = false;
            this.gridViewPrReqList.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewPrReqList.OptionsView.ShowFooter = true;
            this.gridViewPrReqList.OptionsView.ShowGroupPanel = false;
            this.gridViewPrReqList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewPrReqHead_CustomDrawRowIndicator);
            this.gridViewPrReqList.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridViewPrReqList_InitNewRow);
            this.gridViewPrReqList.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewPrReqList_CellValueChanged);
            this.gridViewPrReqList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewPrReqList_KeyDown);
            // 
            // colAutoId1
            // 
            this.colAutoId1.FieldName = "AutoId";
            this.colAutoId1.Name = "colAutoId1";
            // 
            // colPrReqNo1
            // 
            this.colPrReqNo1.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrReqNo1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrReqNo1.FieldName = "PrReqNo";
            this.colPrReqNo1.Name = "colPrReqNo1";
            this.colPrReqNo1.OptionsColumn.AllowEdit = false;
            this.colPrReqNo1.OptionsColumn.AllowFocus = false;
            this.colPrReqNo1.OptionsColumn.ReadOnly = true;
            this.colPrReqNo1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "PrReqNo", "共计{0}条")});
            this.colPrReqNo1.Visible = true;
            this.colPrReqNo1.VisibleIndex = 0;
            this.colPrReqNo1.Width = 110;
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
            this.colCodeFileName.VisibleIndex = 1;
            this.colCodeFileName.Width = 110;
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
            this.repSearchCodeFileNameView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.repSearchCodeFileNameView_CustomDrawRowIndicator);
            // 
            // gridColumnAutoId
            // 
            this.gridColumnAutoId.Caption = "AutoId";
            this.gridColumnAutoId.Name = "gridColumnAutoId";
            // 
            // gridColumnCodeFileName
            // 
            this.gridColumnCodeFileName.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnCodeFileName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnCodeFileName.Caption = "文件名称";
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
            // colQty
            // 
            this.colQty.AppearanceHeader.Options.UseTextOptions = true;
            this.colQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQty.ColumnEdit = this.repSpinQty;
            this.colQty.FieldName = "Qty";
            this.colQty.Name = "colQty";
            this.colQty.OptionsColumn.AllowEdit = false;
            this.colQty.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qty", "{0:0.##}")});
            this.colQty.Visible = true;
            this.colQty.VisibleIndex = 3;
            this.colQty.Width = 80;
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
            this.repSpinQty.MaxValue = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.repSpinQty.Name = "repSpinQty";
            // 
            // colRequirementDate
            // 
            this.colRequirementDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colRequirementDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRequirementDate.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.colRequirementDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colRequirementDate.FieldName = "RequirementDate";
            this.colRequirementDate.Name = "colRequirementDate";
            this.colRequirementDate.OptionsColumn.AllowEdit = false;
            this.colRequirementDate.Visible = true;
            this.colRequirementDate.VisibleIndex = 4;
            this.colRequirementDate.Width = 100;
            // 
            // colPrReqListRemark
            // 
            this.colPrReqListRemark.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrReqListRemark.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrReqListRemark.FieldName = "PrReqListRemark";
            this.colPrReqListRemark.Name = "colPrReqListRemark";
            this.colPrReqListRemark.OptionsColumn.AllowEdit = false;
            this.colPrReqListRemark.Visible = true;
            this.colPrReqListRemark.VisibleIndex = 5;
            this.colPrReqListRemark.Width = 180;
            // 
            // colDelete
            // 
            this.colDelete.ColumnEdit = this.repbtnDelete;
            this.colDelete.Name = "colDelete";
            this.colDelete.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 6;
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
            // colCodeName
            // 
            this.colCodeName.AppearanceHeader.Options.UseTextOptions = true;
            this.colCodeName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCodeName.FieldName = "CodeName";
            this.colCodeName.Name = "colCodeName";
            this.colCodeName.OptionsColumn.AllowEdit = false;
            this.colCodeName.OptionsColumn.AllowFocus = false;
            this.colCodeName.Visible = true;
            this.colCodeName.VisibleIndex = 2;
            this.colCodeName.Width = 110;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterControl1.Location = new System.Drawing.Point(0, 290);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(989, 5);
            this.splitterControl1.TabIndex = 3;
            this.splitterControl1.TabStop = false;
            // 
            // FrmPrReq
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(989, 451);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.pnlMiddle);
            this.Controls.Add(this.pnltop);
            this.Name = "FrmPrReq";
            this.TabText = "采购请购单";
            this.Text = "采购请购单";
            this.Activated += new System.EventHandler(this.FrmPrReq_Activated);
            this.Load += new System.EventHandler(this.FrmPrReq_Load);
            this.Shown += new System.EventHandler(this.FrmPrReq_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pnltop)).EndInit();
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textCommon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxReqState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpApplicant.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPurCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpReqDep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateReqDateEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateReqDateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateReqDateBegin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateReqDateBegin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_PrReq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablePrReqHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablePrReqList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddle)).EndInit();
            this.pnlMiddle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPrReqHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_PrReqHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPrReqHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpReqDep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchProjectNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchProjectNoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repComboBoxStnNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpPurCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddleTop)).EndInit();
            this.pnlMiddleTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPrReqList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_PrReqList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPrReqList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchCodeFileName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchCodeFileNameView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repbtnDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnltop;
        private DevExpress.XtraEditors.DateEdit dateReqDateBegin;
        private DevExpress.XtraEditors.PanelControl pnlMiddle;
        private DevExpress.XtraEditors.PanelControl pnlBottom;
        private DevExpress.XtraEditors.LabelControl labReqDate;
        private DevExpress.XtraEditors.LookUpEdit lookUpPurCategory;
        private DevExpress.XtraEditors.LabelControl labPurCategory;
        private DevExpress.XtraEditors.LookUpEdit lookUpReqDep;
        private DevExpress.XtraEditors.LabelControl labReqDep;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.DateEdit dateReqDateEnd;
        private DevExpress.XtraEditors.LabelControl lab;
        private DevExpress.XtraGrid.GridControl gridControlPrReqHead;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPrReqHead;
        private System.Windows.Forms.BindingSource bindingSource_PrReqHead;
        private System.Data.DataSet dataSet_PrReq;
        private System.Data.DataTable dataTablePrReqHead;
        private System.Data.DataColumn dataColAutoId;
        private System.Data.DataColumn dataColPrReqNo;
        private System.Data.DataColumn dataColReqDate;
        private System.Data.DataColumn dataColReqDep;
        private System.Data.DataColumn dataColProjectNo;
        private System.Data.DataColumn dataColStnNo;
        private System.Data.DataColumn dataColPurCategory;
        private System.Data.DataTable dataTablePrReqList;
        private System.Data.DataColumn dataColumnAutoId;
        private System.Data.DataColumn dataColumnPrReqNo;
        private System.Data.DataColumn dataColCodeFileName;
        private System.Data.DataColumn dataColQty;
        private System.Data.DataColumn dataColRequirementDate;
        private System.Data.DataColumn dataColPrReqListRemark;
        private System.Windows.Forms.BindingSource bindingSource_PrReqList;
        private DevExpress.XtraGrid.GridControl gridControlPrReqList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPrReqList;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId1;
        private DevExpress.XtraGrid.Columns.GridColumn colPrReqNo1;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeFileName;
        private DevExpress.XtraGrid.Columns.GridColumn colQty;
        private DevExpress.XtraGrid.Columns.GridColumn colRequirementDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPrReqListRemark;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpReqDep;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpPurCategory;
        private DevExpress.XtraEditors.PanelControl pnlMiddleTop;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private System.Data.DataColumn dataColReqState;
        private System.Data.DataColumn dataColApplicant;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colPrReqNo;
        private DevExpress.XtraGrid.Columns.GridColumn colReqDate;
        private DevExpress.XtraGrid.Columns.GridColumn colReqDep;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectNo;
        private DevExpress.XtraGrid.Columns.GridColumn colStnNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPurCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colApplicant;
        private DevExpress.XtraGrid.Columns.GridColumn colReqState;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repSpinQty;
        private System.Data.DataColumn dataColApplicantIp;
        private System.Data.DataColumn dataColApplicantTime;
        private System.Data.DataColumn dataColModifier;
        private System.Data.DataColumn dataColModifierIp;
        private System.Data.DataColumn dataColModifierTime;
        private System.Data.DataColumn dataColApprover;
        private System.Data.DataColumn dataColApproverIp;
        private System.Data.DataColumn dataColApproverTime;
        private DevExpress.XtraEditors.SimpleButton btnApprove;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxReqState;
        private DevExpress.XtraEditors.LabelControl labApplicant;
        private DevExpress.XtraEditors.LookUpEdit lookUpApplicant;
        private DevExpress.XtraEditors.LabelControl labReqState;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repSearchCodeFileName;
        private DevExpress.XtraGrid.Views.Grid.GridView repSearchCodeFileNameView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCodeFileName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCodeName;
        private System.Data.DataColumn dataColPrReqRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colPrReqRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colApprover;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repbtnDelete;
        private System.Data.DataColumn dataColCodeName;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeName;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.TextEdit textCommon;
        private DevExpress.XtraEditors.LabelControl labCommon;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repSearchProjectNo;
        private DevExpress.XtraGrid.Views.Grid.GridView repSearchProjectNoView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnProjectNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnProjectName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRemark;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repComboBoxStnNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColSelect;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheckSelect;
        private System.Data.DataColumn dataColSelect;
        private System.Data.DataColumn dataColClosed;
        private System.Data.DataColumn dataColClosedIp;
        private System.Data.DataColumn dataColClosedTime;
        private DevExpress.XtraGrid.Columns.GridColumn colClosed;
        private DevExpress.XtraEditors.SimpleButton btnCancelApprove;
        private DevExpress.XtraEditors.CheckEdit checkAll;
        private DevExpress.XtraEditors.SimpleButton btnPreview;
        private DevExpress.XtraEditors.SimpleButton btnCancelClose;
        private DevExpress.XtraEditors.SimpleButton btnListAdd;
    }
}