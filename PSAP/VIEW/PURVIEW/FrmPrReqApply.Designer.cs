namespace PSAP.VIEW.BSVIEW
{
    partial class FrmPrReqApply
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
            this.pnlTop = new DevExpress.XtraEditors.PanelControl();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.textPrReqNo = new DevExpress.XtraEditors.TextEdit();
            this.labPrReqNo = new DevExpress.XtraEditors.LabelControl();
            this.pnlBottom = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.BtnConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.pnlMiddle = new DevExpress.XtraEditors.PanelControl();
            this.bindingSource_PrReqList = new System.Windows.Forms.BindingSource(this.components);
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
            this.bindingSource_PrReqHead = new System.Windows.Forms.BindingSource(this.components);
            this.pnlMiddleTop = new DevExpress.XtraEditors.PanelControl();
            this.pnlMiddleBottom = new DevExpress.XtraEditors.PanelControl();
            this.gridControlPrReqHead = new DevExpress.XtraGrid.GridControl();
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.gridControlPrReqList = new DevExpress.XtraGrid.GridControl();
            this.gridViewPrReqList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrReqNo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodeFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSearchCodeFileName = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCodeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCodeFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCodeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSpinQty = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colRequirementDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrReqListRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repbtnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colCodeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dataColListSelect = new System.Data.DataColumn();
            this.colListSelect = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCheckListSelect = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textPrReqNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).BeginInit();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddle)).BeginInit();
            this.pnlMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_PrReqList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_PrReq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablePrReqHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablePrReqList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_PrReqHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddleTop)).BeginInit();
            this.pnlMiddleTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddleBottom)).BeginInit();
            this.pnlMiddleBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPrReqHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPrReqHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpReqDep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchProjectNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repComboBoxStnNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpPurCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPrReqList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPrReqList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchCodeFileName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repbtnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckListSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnQuery);
            this.pnlTop.Controls.Add(this.textPrReqNo);
            this.pnlTop.Controls.Add(this.labPrReqNo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1008, 51);
            this.pnlTop.TabIndex = 0;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(251, 13);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 17;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // textPrReqNo
            // 
            this.textPrReqNo.EnterMoveNextControl = true;
            this.textPrReqNo.Location = new System.Drawing.Point(86, 14);
            this.textPrReqNo.Name = "textPrReqNo";
            this.textPrReqNo.Size = new System.Drawing.Size(150, 20);
            this.textPrReqNo.TabIndex = 15;
            // 
            // labPrReqNo
            // 
            this.labPrReqNo.Location = new System.Drawing.Point(20, 17);
            this.labPrReqNo.Name = "labPrReqNo";
            this.labPrReqNo.Size = new System.Drawing.Size(60, 14);
            this.labPrReqNo.TabIndex = 16;
            this.labPrReqNo.Text = "请购单号：";
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnCancel);
            this.pnlBottom.Controls.Add(this.BtnConfirm);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 693);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1008, 36);
            this.pnlBottom.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(919, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnConfirm.Location = new System.Drawing.Point(838, 7);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(75, 23);
            this.BtnConfirm.TabIndex = 0;
            this.BtnConfirm.Text = "确定";
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.Controls.Add(this.pnlMiddleBottom);
            this.pnlMiddle.Controls.Add(this.pnlMiddleTop);
            this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMiddle.Location = new System.Drawing.Point(0, 51);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(1008, 642);
            this.pnlMiddle.TabIndex = 2;
            // 
            // bindingSource_PrReqList
            // 
            this.bindingSource_PrReqList.DataMember = "PrReqList";
            this.bindingSource_PrReqList.DataSource = this.dataSet_PrReq;
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
            this.dataColCodeName,
            this.dataColListSelect});
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
            // bindingSource_PrReqHead
            // 
            this.bindingSource_PrReqHead.DataMember = "PrReqHead";
            this.bindingSource_PrReqHead.DataSource = this.dataSet_PrReq;
            // 
            // pnlMiddleTop
            // 
            this.pnlMiddleTop.Controls.Add(this.gridControlPrReqHead);
            this.pnlMiddleTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMiddleTop.Location = new System.Drawing.Point(2, 2);
            this.pnlMiddleTop.Name = "pnlMiddleTop";
            this.pnlMiddleTop.Size = new System.Drawing.Size(1004, 188);
            this.pnlMiddleTop.TabIndex = 0;
            // 
            // pnlMiddleBottom
            // 
            this.pnlMiddleBottom.Controls.Add(this.gridControlPrReqList);
            this.pnlMiddleBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMiddleBottom.Location = new System.Drawing.Point(2, 190);
            this.pnlMiddleBottom.Name = "pnlMiddleBottom";
            this.pnlMiddleBottom.Size = new System.Drawing.Size(1004, 450);
            this.pnlMiddleBottom.TabIndex = 1;
            // 
            // gridControlPrReqHead
            // 
            this.gridControlPrReqHead.DataSource = this.bindingSource_PrReqHead;
            this.gridControlPrReqHead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPrReqHead.Location = new System.Drawing.Point(2, 2);
            this.gridControlPrReqHead.MainView = this.gridViewPrReqHead;
            this.gridControlPrReqHead.Name = "gridControlPrReqHead";
            this.gridControlPrReqHead.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repLookUpReqDep,
            this.repLookUpPurCategory,
            this.repSearchProjectNo,
            this.repComboBoxStnNo,
            this.repCheckSelect});
            this.gridControlPrReqHead.Size = new System.Drawing.Size(1000, 184);
            this.gridControlPrReqHead.TabIndex = 1;
            this.gridControlPrReqHead.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPrReqHead});
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
            this.colApprover});
            this.gridViewPrReqHead.GridControl = this.gridControlPrReqHead;
            this.gridViewPrReqHead.IndicatorWidth = 40;
            this.gridViewPrReqHead.Name = "gridViewPrReqHead";
            this.gridViewPrReqHead.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewPrReqHead.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewPrReqHead.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewPrReqHead.OptionsView.ColumnAutoWidth = false;
            this.gridViewPrReqHead.OptionsView.ShowFooter = true;
            this.gridViewPrReqHead.OptionsView.ShowGroupPanel = false;
            this.gridViewPrReqHead.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewPrReqHead_CustomDrawRowIndicator);
            this.gridViewPrReqHead.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewPrReqHead_FocusedRowChanged);
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
            this.repSearchProjectNo.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnProjectNo,
            this.gridColumnProjectName,
            this.gridColumnRemark});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.IndicatorWidth = 60;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            this.repbtnDelete,
            this.repCheckListSelect});
            this.gridControlPrReqList.Size = new System.Drawing.Size(1000, 446);
            this.gridControlPrReqList.TabIndex = 2;
            this.gridControlPrReqList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPrReqList});
            // 
            // gridViewPrReqList
            // 
            this.gridViewPrReqList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId1,
            this.colListSelect,
            this.colPrReqNo1,
            this.colCodeFileName,
            this.colQty,
            this.colRequirementDate,
            this.colPrReqListRemark,
            this.colCodeName});
            this.gridViewPrReqList.GridControl = this.gridControlPrReqList;
            this.gridViewPrReqList.IndicatorWidth = 40;
            this.gridViewPrReqList.Name = "gridViewPrReqList";
            this.gridViewPrReqList.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewPrReqList.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewPrReqList.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewPrReqList.OptionsView.ColumnAutoWidth = false;
            this.gridViewPrReqList.OptionsView.ShowFooter = true;
            this.gridViewPrReqList.OptionsView.ShowGroupPanel = false;
            this.gridViewPrReqList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewPrReqList_CustomDrawRowIndicator);
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
            this.colPrReqNo1.VisibleIndex = 1;
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
            this.colCodeFileName.VisibleIndex = 2;
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
            this.repSearchCodeFileName.View = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnAutoId,
            this.gridColumnCodeNo,
            this.gridColumnCodeFileName,
            this.gridColumnCodeName});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.IndicatorWidth = 60;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnAutoId
            // 
            this.gridColumnAutoId.Caption = "AutoId";
            this.gridColumnAutoId.Name = "gridColumnAutoId";
            // 
            // gridColumnCodeNo
            // 
            this.gridColumnCodeNo.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnCodeNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnCodeNo.Caption = "编号";
            this.gridColumnCodeNo.FieldName = "CodeNo";
            this.gridColumnCodeNo.Name = "gridColumnCodeNo";
            this.gridColumnCodeNo.Visible = true;
            this.gridColumnCodeNo.VisibleIndex = 0;
            this.gridColumnCodeNo.Width = 100;
            // 
            // gridColumnCodeFileName
            // 
            this.gridColumnCodeFileName.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnCodeFileName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnCodeFileName.Caption = "文件名称";
            this.gridColumnCodeFileName.FieldName = "CodeFileName";
            this.gridColumnCodeFileName.Name = "gridColumnCodeFileName";
            this.gridColumnCodeFileName.Visible = true;
            this.gridColumnCodeFileName.VisibleIndex = 1;
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
            this.gridColumnCodeName.VisibleIndex = 2;
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
            this.colQty.VisibleIndex = 4;
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
            this.colRequirementDate.VisibleIndex = 5;
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
            this.colPrReqListRemark.VisibleIndex = 6;
            this.colPrReqListRemark.Width = 180;
            // 
            // repbtnDelete
            // 
            this.repbtnDelete.AutoHeight = false;
            this.repbtnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.repbtnDelete.Name = "repbtnDelete";
            this.repbtnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
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
            this.colCodeName.VisibleIndex = 3;
            this.colCodeName.Width = 110;
            // 
            // dataColListSelect
            // 
            this.dataColListSelect.Caption = "";
            this.dataColListSelect.ColumnName = "ListSelect";
            this.dataColListSelect.DataType = typeof(bool);
            // 
            // colListSelect
            // 
            this.colListSelect.ColumnEdit = this.repCheckListSelect;
            this.colListSelect.FieldName = "ListSelect";
            this.colListSelect.Name = "colListSelect";
            this.colListSelect.Visible = true;
            this.colListSelect.VisibleIndex = 0;
            this.colListSelect.Width = 35;
            // 
            // repCheckListSelect
            // 
            this.repCheckListSelect.AutoHeight = false;
            this.repCheckListSelect.Name = "repCheckListSelect";
            this.repCheckListSelect.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repCheckListSelect.ValueGrayed = false;
            this.repCheckListSelect.EditValueChanged += new System.EventHandler(this.repCheckListSelect_EditValueChanged);
            // 
            // FrmPrReqApply
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.pnlMiddle);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlBottom);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrReqApply";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabText = "请购适用";
            this.Text = "请购适用";
            this.Load += new System.EventHandler(this.FrmPrReqApply_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textPrReqNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddle)).EndInit();
            this.pnlMiddle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_PrReqList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_PrReq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablePrReqHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablePrReqList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_PrReqHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddleTop)).EndInit();
            this.pnlMiddleTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddleBottom)).EndInit();
            this.pnlMiddleBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPrReqHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPrReqHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpReqDep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchProjectNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repComboBoxStnNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpPurCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPrReqList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPrReqList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchCodeFileName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repbtnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckListSelect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlTop;
        private DevExpress.XtraEditors.PanelControl pnlBottom;
        private DevExpress.XtraEditors.PanelControl pnlMiddle;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton BtnConfirm;
        private DevExpress.XtraEditors.TextEdit textPrReqNo;
        private DevExpress.XtraEditors.LabelControl labPrReqNo;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private System.Windows.Forms.BindingSource bindingSource_PrReqList;
        private System.Data.DataSet dataSet_PrReq;
        private System.Data.DataTable dataTablePrReqHead;
        private System.Data.DataColumn dataColAutoId;
        private System.Data.DataColumn dataColPrReqNo;
        private System.Data.DataColumn dataColReqDate;
        private System.Data.DataColumn dataColReqDep;
        private System.Data.DataColumn dataColProjectNo;
        private System.Data.DataColumn dataColStnNo;
        private System.Data.DataColumn dataColPurCategory;
        private System.Data.DataColumn dataColReqState;
        private System.Data.DataColumn dataColApplicant;
        private System.Data.DataColumn dataColApplicantIp;
        private System.Data.DataColumn dataColApplicantTime;
        private System.Data.DataColumn dataColModifier;
        private System.Data.DataColumn dataColModifierIp;
        private System.Data.DataColumn dataColModifierTime;
        private System.Data.DataColumn dataColApprover;
        private System.Data.DataColumn dataColApproverIp;
        private System.Data.DataColumn dataColApproverTime;
        private System.Data.DataColumn dataColPrReqRemark;
        private System.Data.DataColumn dataColSelect;
        private System.Data.DataColumn dataColClosed;
        private System.Data.DataColumn dataColClosedIp;
        private System.Data.DataColumn dataColClosedTime;
        private System.Data.DataTable dataTablePrReqList;
        private System.Data.DataColumn dataColumnAutoId;
        private System.Data.DataColumn dataColumnPrReqNo;
        private System.Data.DataColumn dataColCodeFileName;
        private System.Data.DataColumn dataColQty;
        private System.Data.DataColumn dataColRequirementDate;
        private System.Data.DataColumn dataColPrReqListRemark;
        private System.Data.DataColumn dataColCodeName;
        private System.Windows.Forms.BindingSource bindingSource_PrReqHead;
        private DevExpress.XtraEditors.PanelControl pnlMiddleBottom;
        private DevExpress.XtraEditors.PanelControl pnlMiddleTop;
        private DevExpress.XtraGrid.GridControl gridControlPrReqHead;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPrReqHead;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColSelect;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheckSelect;
        private DevExpress.XtraGrid.Columns.GridColumn colPrReqNo;
        private DevExpress.XtraGrid.Columns.GridColumn colReqState;
        private DevExpress.XtraGrid.Columns.GridColumn colReqDate;
        private DevExpress.XtraGrid.Columns.GridColumn colReqDep;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpReqDep;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repSearchProjectNo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnProjectNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnProjectName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colStnNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repComboBoxStnNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPurCategory;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpPurCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colApplicant;
        private DevExpress.XtraGrid.Columns.GridColumn colPrReqRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colApprover;
        private DevExpress.XtraGrid.GridControl gridControlPrReqList;
        private System.Data.DataColumn dataColListSelect;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPrReqList;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId1;
        private DevExpress.XtraGrid.Columns.GridColumn colListSelect;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheckListSelect;
        private DevExpress.XtraGrid.Columns.GridColumn colPrReqNo1;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeFileName;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repSearchCodeFileName;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCodeNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCodeFileName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCodeName;
        private DevExpress.XtraGrid.Columns.GridColumn colQty;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repSpinQty;
        private DevExpress.XtraGrid.Columns.GridColumn colRequirementDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPrReqListRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeName;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repbtnDelete;
    }
}