namespace PSAP.VIEW.BSVIEW
{
    partial class FrmOrderApply
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
            this.pnlTop = new DevExpress.XtraEditors.PanelControl();
            this.searchLookUpBussinessBaseNo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpBussinessBaseNoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnBussinessBaseNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBussinessBaseText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBussinessCategoryText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.searchLookUpProjectNo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpProjectNoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColProjectNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColProjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.checkOrderDate = new DevExpress.XtraEditors.CheckEdit();
            this.textCommon = new DevExpress.XtraEditors.TextEdit();
            this.lookUpPrepared = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpPurCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpReqDep = new DevExpress.XtraEditors.LookUpEdit();
            this.dateOrderDateEnd = new DevExpress.XtraEditors.DateEdit();
            this.lab = new DevExpress.XtraEditors.LabelControl();
            this.dateOrderDateBegin = new DevExpress.XtraEditors.DateEdit();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.textOrderHeadNo = new DevExpress.XtraEditors.TextEdit();
            this.labBussinessBaseNo = new DevExpress.XtraEditors.LabelControl();
            this.labProjectNo = new DevExpress.XtraEditors.LabelControl();
            this.labCommon = new DevExpress.XtraEditors.LabelControl();
            this.labPrepared = new DevExpress.XtraEditors.LabelControl();
            this.labPurCategory = new DevExpress.XtraEditors.LabelControl();
            this.labReqDep = new DevExpress.XtraEditors.LabelControl();
            this.labOrderDate = new DevExpress.XtraEditors.LabelControl();
            this.labOrderHeadNo = new DevExpress.XtraEditors.LabelControl();
            this.pnlMiddle = new DevExpress.XtraEditors.PanelControl();
            this.pnlMiddleBottom = new DevExpress.XtraEditors.PanelControl();
            this.checkAll = new DevExpress.XtraEditors.CheckEdit();
            this.gridControlOrderList = new DevExpress.XtraGrid.GridControl();
            this.bindingSource_OrderList = new System.Windows.Forms.BindingSource();
            this.dataSet_Order = new System.Data.DataSet();
            this.dataTableOrderHead = new System.Data.DataTable();
            this.dataColAutoId = new System.Data.DataColumn();
            this.dataColOrderHeadNo = new System.Data.DataColumn();
            this.dataColOrderHeadDate = new System.Data.DataColumn();
            this.dataColPurCategory = new System.Data.DataColumn();
            this.dataColBussinessBaseNo = new System.Data.DataColumn();
            this.dataColTax = new System.Data.DataColumn();
            this.dataColReqDep = new System.Data.DataColumn();
            this.dataColPrepared = new System.Data.DataColumn();
            this.dataColPreparedIp = new System.Data.DataColumn();
            this.dataColProjectNo = new System.Data.DataColumn();
            this.dataColStnNo = new System.Data.DataColumn();
            this.dataColPlanDate = new System.Data.DataColumn();
            this.dataColApprover = new System.Data.DataColumn();
            this.dataColApproverIp = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColModifier = new System.Data.DataColumn();
            this.dataColModifierIp = new System.Data.DataColumn();
            this.dataColModifierTime = new System.Data.DataColumn();
            this.dataColReqState = new System.Data.DataColumn();
            this.dataColPrReqRemark = new System.Data.DataColumn();
            this.dataColClosed = new System.Data.DataColumn();
            this.dataColClosedIp = new System.Data.DataColumn();
            this.dataColClosedTime = new System.Data.DataColumn();
            this.dataColSelect = new System.Data.DataColumn();
            this.dataColApprovalType = new System.Data.DataColumn();
            this.dataColPayTypeNo = new System.Data.DataColumn();
            this.dataColProjectName = new System.Data.DataColumn();
            this.dataTableOrderList = new System.Data.DataTable();
            this.dataColumnAutoId = new System.Data.DataColumn();
            this.dataColumnOrderHeadNo = new System.Data.DataColumn();
            this.dataColCodeFileName = new System.Data.DataColumn();
            this.dataColQty = new System.Data.DataColumn();
            this.dataColUnit = new System.Data.DataColumn();
            this.dataColAmount = new System.Data.DataColumn();
            this.dataColumnTax = new System.Data.DataColumn();
            this.dataColTaxAmount = new System.Data.DataColumn();
            this.dataColSumAmount = new System.Data.DataColumn();
            this.dataColumnPlanDate = new System.Data.DataColumn();
            this.dataColRemark = new System.Data.DataColumn();
            this.dataColCodeName = new System.Data.DataColumn();
            this.dataColListSelect = new System.Data.DataColumn();
            this.dataColWarehouseWarrentCount = new System.Data.DataColumn();
            this.dataColOverplus = new System.Data.DataColumn();
            this.gridViewOrderList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colListSelect = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCheckListSelect = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colOrderHeadNo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodeFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSpinQty = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colWarehouseWarrentCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOverplus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSpinUnit = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTax1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSpinTax1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colTaxAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSumAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlanDate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrReqNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrListAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSearchCodeFileName = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCodeFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCodeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlMiddleTop = new DevExpress.XtraEditors.PanelControl();
            this.gridControlOrderHead = new DevExpress.XtraGrid.GridControl();
            this.bindingSource_OrderHead = new System.Windows.Forms.BindingSource();
            this.gridViewOrderHead = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelect = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCheckSelect = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colOrderHeadNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReqState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderHeadDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpPurCategory = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colBussinessBaseNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSearchBussinessBaseNo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridCBussinessBaseNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCBussinessBaseText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCBussinessCategoryText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReqDep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpReqDep = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colTax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStnNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApprovalType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpApprovalType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colPayTypeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpPayTypeNo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colPlanDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrReqRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrepared = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClosed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlBottom = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.BtnConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.cms = new System.Windows.Forms.ContextMenuStrip();
            this.tsmiQxzysydygcgd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQxzysydcgddmxjl = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpBussinessBaseNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpBussinessBaseNoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpProjectNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpProjectNoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkOrderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCommon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPrepared.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPurCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpReqDep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDateEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDateBegin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDateBegin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textOrderHeadNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddle)).BeginInit();
            this.pnlMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddleBottom)).BeginInit();
            this.pnlMiddleBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_OrderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableOrderHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableOrderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckListSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinTax1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchCodeFileName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddleTop)).BeginInit();
            this.pnlMiddleTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrderHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_OrderHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrderHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpPurCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchBussinessBaseNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpReqDep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpApprovalType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpPayTypeNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.searchLookUpBussinessBaseNo);
            this.pnlTop.Controls.Add(this.searchLookUpProjectNo);
            this.pnlTop.Controls.Add(this.checkOrderDate);
            this.pnlTop.Controls.Add(this.textCommon);
            this.pnlTop.Controls.Add(this.lookUpPrepared);
            this.pnlTop.Controls.Add(this.lookUpPurCategory);
            this.pnlTop.Controls.Add(this.lookUpReqDep);
            this.pnlTop.Controls.Add(this.dateOrderDateEnd);
            this.pnlTop.Controls.Add(this.lab);
            this.pnlTop.Controls.Add(this.dateOrderDateBegin);
            this.pnlTop.Controls.Add(this.btnQuery);
            this.pnlTop.Controls.Add(this.textOrderHeadNo);
            this.pnlTop.Controls.Add(this.labBussinessBaseNo);
            this.pnlTop.Controls.Add(this.labProjectNo);
            this.pnlTop.Controls.Add(this.labCommon);
            this.pnlTop.Controls.Add(this.labPrepared);
            this.pnlTop.Controls.Add(this.labPurCategory);
            this.pnlTop.Controls.Add(this.labReqDep);
            this.pnlTop.Controls.Add(this.labOrderDate);
            this.pnlTop.Controls.Add(this.labOrderHeadNo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1008, 112);
            this.pnlTop.TabIndex = 0;
            // 
            // searchLookUpBussinessBaseNo
            // 
            this.searchLookUpBussinessBaseNo.EnterMoveNextControl = true;
            this.searchLookUpBussinessBaseNo.Location = new System.Drawing.Point(472, 74);
            this.searchLookUpBussinessBaseNo.Name = "searchLookUpBussinessBaseNo";
            this.searchLookUpBussinessBaseNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpBussinessBaseNo.Properties.DisplayMember = "BussinessBaseText";
            this.searchLookUpBussinessBaseNo.Properties.NullText = "";
            this.searchLookUpBussinessBaseNo.Properties.ValueMember = "BussinessBaseNo";
            this.searchLookUpBussinessBaseNo.Properties.View = this.searchLookUpBussinessBaseNoView;
            this.searchLookUpBussinessBaseNo.Size = new System.Drawing.Size(150, 20);
            this.searchLookUpBussinessBaseNo.TabIndex = 8;
            // 
            // searchLookUpBussinessBaseNoView
            // 
            this.searchLookUpBussinessBaseNoView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnBussinessBaseNo,
            this.gridColumnBussinessBaseText,
            this.gridColumnBussinessCategoryText,
            this.gridColumn1});
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
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumnAutoId";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // searchLookUpProjectNo
            // 
            this.searchLookUpProjectNo.EnterMoveNextControl = true;
            this.searchLookUpProjectNo.Location = new System.Drawing.Point(279, 74);
            this.searchLookUpProjectNo.Name = "searchLookUpProjectNo";
            this.searchLookUpProjectNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpProjectNo.Properties.DisplayMember = "ProjectName";
            this.searchLookUpProjectNo.Properties.NullText = "";
            this.searchLookUpProjectNo.Properties.ValueMember = "ProjectNo";
            this.searchLookUpProjectNo.Properties.View = this.searchLookUpProjectNoView;
            this.searchLookUpProjectNo.Size = new System.Drawing.Size(120, 20);
            this.searchLookUpProjectNo.TabIndex = 7;
            this.searchLookUpProjectNo.TabStop = false;
            // 
            // searchLookUpProjectNoView
            // 
            this.searchLookUpProjectNoView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColProjectNo,
            this.gridColProjectName,
            this.gridColRemark});
            this.searchLookUpProjectNoView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpProjectNoView.IndicatorWidth = 60;
            this.searchLookUpProjectNoView.Name = "searchLookUpProjectNoView";
            this.searchLookUpProjectNoView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpProjectNoView.OptionsView.ShowGroupPanel = false;
            // 
            // gridColProjectNo
            // 
            this.gridColProjectNo.Caption = "项目号";
            this.gridColProjectNo.FieldName = "ProjectNo";
            this.gridColProjectNo.Name = "gridColProjectNo";
            this.gridColProjectNo.Visible = true;
            this.gridColProjectNo.VisibleIndex = 0;
            // 
            // gridColProjectName
            // 
            this.gridColProjectName.Caption = "项目名称";
            this.gridColProjectName.FieldName = "ProjectName";
            this.gridColProjectName.Name = "gridColProjectName";
            this.gridColProjectName.Visible = true;
            this.gridColProjectName.VisibleIndex = 1;
            // 
            // gridColRemark
            // 
            this.gridColRemark.Caption = "备注";
            this.gridColRemark.FieldName = "Remark";
            this.gridColRemark.Name = "gridColRemark";
            this.gridColRemark.Visible = true;
            this.gridColRemark.VisibleIndex = 2;
            // 
            // checkOrderDate
            // 
            this.checkOrderDate.Location = new System.Drawing.Point(86, 44);
            this.checkOrderDate.Name = "checkOrderDate";
            this.checkOrderDate.Properties.Caption = "";
            this.checkOrderDate.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.checkOrderDate.Properties.ValueGrayed = false;
            this.checkOrderDate.Size = new System.Drawing.Size(19, 19);
            this.checkOrderDate.TabIndex = 33;
            this.checkOrderDate.TabStop = false;
            this.checkOrderDate.CheckedChanged += new System.EventHandler(this.checkOrderDate_CheckedChanged);
            // 
            // textCommon
            // 
            this.textCommon.EnterMoveNextControl = true;
            this.textCommon.Location = new System.Drawing.Point(707, 74);
            this.textCommon.Name = "textCommon";
            this.textCommon.Size = new System.Drawing.Size(150, 20);
            this.textCommon.TabIndex = 9;
            this.textCommon.TabStop = false;
            // 
            // lookUpPrepared
            // 
            this.lookUpPrepared.EnterMoveNextControl = true;
            this.lookUpPrepared.Location = new System.Drawing.Point(86, 74);
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
            this.lookUpPrepared.TabIndex = 6;
            this.lookUpPrepared.TabStop = false;
            // 
            // lookUpPurCategory
            // 
            this.lookUpPurCategory.EnterMoveNextControl = true;
            this.lookUpPurCategory.Location = new System.Drawing.Point(613, 44);
            this.lookUpPurCategory.Name = "lookUpPurCategory";
            this.lookUpPurCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpPurCategory.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PurCategory", "编号", 81, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PurCategoryText", "名称", 111, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpPurCategory.Properties.DisplayMember = "PurCategoryText";
            this.lookUpPurCategory.Properties.NullText = "";
            this.lookUpPurCategory.Properties.ValueMember = "PurCategory";
            this.lookUpPurCategory.Size = new System.Drawing.Size(120, 20);
            this.lookUpPurCategory.TabIndex = 5;
            this.lookUpPurCategory.TabStop = false;
            // 
            // lookUpReqDep
            // 
            this.lookUpReqDep.EnterMoveNextControl = true;
            this.lookUpReqDep.Location = new System.Drawing.Point(409, 44);
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
            this.lookUpReqDep.TabStop = false;
            // 
            // dateOrderDateEnd
            // 
            this.dateOrderDateEnd.EditValue = null;
            this.dateOrderDateEnd.Enabled = false;
            this.dateOrderDateEnd.EnterMoveNextControl = true;
            this.dateOrderDateEnd.Location = new System.Drawing.Point(223, 44);
            this.dateOrderDateEnd.Name = "dateOrderDateEnd";
            this.dateOrderDateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateOrderDateEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateOrderDateEnd.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dateOrderDateEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateOrderDateEnd.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateOrderDateEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateOrderDateEnd.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateOrderDateEnd.Size = new System.Drawing.Size(100, 20);
            this.dateOrderDateEnd.TabIndex = 3;
            this.dateOrderDateEnd.TabStop = false;
            // 
            // lab
            // 
            this.lab.Location = new System.Drawing.Point(213, 47);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(4, 14);
            this.lab.TabIndex = 44;
            this.lab.Text = "-";
            // 
            // dateOrderDateBegin
            // 
            this.dateOrderDateBegin.EditValue = null;
            this.dateOrderDateBegin.Enabled = false;
            this.dateOrderDateBegin.EnterMoveNextControl = true;
            this.dateOrderDateBegin.Location = new System.Drawing.Point(107, 44);
            this.dateOrderDateBegin.Name = "dateOrderDateBegin";
            this.dateOrderDateBegin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateOrderDateBegin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateOrderDateBegin.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dateOrderDateBegin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateOrderDateBegin.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateOrderDateBegin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateOrderDateBegin.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateOrderDateBegin.Size = new System.Drawing.Size(100, 20);
            this.dateOrderDateBegin.TabIndex = 2;
            this.dateOrderDateBegin.TabStop = false;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(261, 13);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 10;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // textOrderHeadNo
            // 
            this.textOrderHeadNo.EnterMoveNextControl = true;
            this.textOrderHeadNo.Location = new System.Drawing.Point(86, 14);
            this.textOrderHeadNo.Name = "textOrderHeadNo";
            this.textOrderHeadNo.Size = new System.Drawing.Size(150, 20);
            this.textOrderHeadNo.TabIndex = 0;
            // 
            // labBussinessBaseNo
            // 
            this.labBussinessBaseNo.Location = new System.Drawing.Point(418, 77);
            this.labBussinessBaseNo.Name = "labBussinessBaseNo";
            this.labBussinessBaseNo.Size = new System.Drawing.Size(48, 14);
            this.labBussinessBaseNo.TabIndex = 35;
            this.labBussinessBaseNo.Text = "往来方：";
            // 
            // labProjectNo
            // 
            this.labProjectNo.Location = new System.Drawing.Point(223, 77);
            this.labProjectNo.Name = "labProjectNo";
            this.labProjectNo.Size = new System.Drawing.Size(48, 14);
            this.labProjectNo.TabIndex = 49;
            this.labProjectNo.Text = "项目号：";
            // 
            // labCommon
            // 
            this.labCommon.Location = new System.Drawing.Point(641, 77);
            this.labCommon.Name = "labCommon";
            this.labCommon.Size = new System.Drawing.Size(60, 14);
            this.labCommon.TabIndex = 48;
            this.labCommon.Text = "通用查询：";
            // 
            // labPrepared
            // 
            this.labPrepared.Location = new System.Drawing.Point(20, 77);
            this.labPrepared.Name = "labPrepared";
            this.labPrepared.Size = new System.Drawing.Size(48, 14);
            this.labPrepared.TabIndex = 47;
            this.labPrepared.Text = "制单人：";
            // 
            // labPurCategory
            // 
            this.labPurCategory.Location = new System.Drawing.Point(547, 47);
            this.labPurCategory.Name = "labPurCategory";
            this.labPurCategory.Size = new System.Drawing.Size(60, 14);
            this.labPurCategory.TabIndex = 46;
            this.labPurCategory.Text = "采购类型：";
            // 
            // labReqDep
            // 
            this.labReqDep.Location = new System.Drawing.Point(343, 47);
            this.labReqDep.Name = "labReqDep";
            this.labReqDep.Size = new System.Drawing.Size(60, 14);
            this.labReqDep.TabIndex = 45;
            this.labReqDep.Text = "申请部门：";
            // 
            // labOrderDate
            // 
            this.labOrderDate.Location = new System.Drawing.Point(20, 47);
            this.labOrderDate.Name = "labOrderDate";
            this.labOrderDate.Size = new System.Drawing.Size(60, 14);
            this.labOrderDate.TabIndex = 43;
            this.labOrderDate.Text = "订购日期：";
            // 
            // labOrderHeadNo
            // 
            this.labOrderHeadNo.Location = new System.Drawing.Point(20, 17);
            this.labOrderHeadNo.Name = "labOrderHeadNo";
            this.labOrderHeadNo.Size = new System.Drawing.Size(60, 14);
            this.labOrderHeadNo.TabIndex = 42;
            this.labOrderHeadNo.Text = "采购单号：";
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.Controls.Add(this.pnlMiddleBottom);
            this.pnlMiddle.Controls.Add(this.pnlMiddleTop);
            this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMiddle.Location = new System.Drawing.Point(0, 112);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(1008, 413);
            this.pnlMiddle.TabIndex = 1;
            // 
            // pnlMiddleBottom
            // 
            this.pnlMiddleBottom.Controls.Add(this.checkAll);
            this.pnlMiddleBottom.Controls.Add(this.gridControlOrderList);
            this.pnlMiddleBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMiddleBottom.Location = new System.Drawing.Point(2, 157);
            this.pnlMiddleBottom.Name = "pnlMiddleBottom";
            this.pnlMiddleBottom.Size = new System.Drawing.Size(1004, 254);
            this.pnlMiddleBottom.TabIndex = 2;
            // 
            // checkAll
            // 
            this.checkAll.Location = new System.Drawing.Point(53, 4);
            this.checkAll.Name = "checkAll";
            this.checkAll.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.checkAll.Properties.Appearance.Options.UseBackColor = true;
            this.checkAll.Properties.Caption = "";
            this.checkAll.Size = new System.Drawing.Size(20, 19);
            this.checkAll.TabIndex = 18;
            this.checkAll.TabStop = false;
            this.checkAll.CheckedChanged += new System.EventHandler(this.checkAll_CheckedChanged);
            // 
            // gridControlOrderList
            // 
            this.gridControlOrderList.DataSource = this.bindingSource_OrderList;
            this.gridControlOrderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlOrderList.Location = new System.Drawing.Point(2, 2);
            this.gridControlOrderList.MainView = this.gridViewOrderList;
            this.gridControlOrderList.Name = "gridControlOrderList";
            this.gridControlOrderList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repSpinQty,
            this.repSearchCodeFileName,
            this.repSpinUnit,
            this.repSpinTax1,
            this.repCheckListSelect});
            this.gridControlOrderList.Size = new System.Drawing.Size(1000, 250);
            this.gridControlOrderList.TabIndex = 3;
            this.gridControlOrderList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOrderList});
            // 
            // bindingSource_OrderList
            // 
            this.bindingSource_OrderList.DataMember = "OrderList";
            this.bindingSource_OrderList.DataSource = this.dataSet_Order;
            // 
            // dataSet_Order
            // 
            this.dataSet_Order.DataSetName = "NewDataSet";
            this.dataSet_Order.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTableOrderHead,
            this.dataTableOrderList});
            // 
            // dataTableOrderHead
            // 
            this.dataTableOrderHead.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColAutoId,
            this.dataColOrderHeadNo,
            this.dataColOrderHeadDate,
            this.dataColPurCategory,
            this.dataColBussinessBaseNo,
            this.dataColTax,
            this.dataColReqDep,
            this.dataColPrepared,
            this.dataColPreparedIp,
            this.dataColProjectNo,
            this.dataColStnNo,
            this.dataColPlanDate,
            this.dataColApprover,
            this.dataColApproverIp,
            this.dataColumn1,
            this.dataColModifier,
            this.dataColModifierIp,
            this.dataColModifierTime,
            this.dataColReqState,
            this.dataColPrReqRemark,
            this.dataColClosed,
            this.dataColClosedIp,
            this.dataColClosedTime,
            this.dataColSelect,
            this.dataColApprovalType,
            this.dataColPayTypeNo,
            this.dataColProjectName});
            this.dataTableOrderHead.TableName = "OrderHead";
            // 
            // dataColAutoId
            // 
            this.dataColAutoId.ColumnName = "AutoId";
            this.dataColAutoId.DataType = typeof(int);
            // 
            // dataColOrderHeadNo
            // 
            this.dataColOrderHeadNo.Caption = "采购单号";
            this.dataColOrderHeadNo.ColumnName = "OrderHeadNo";
            // 
            // dataColOrderHeadDate
            // 
            this.dataColOrderHeadDate.Caption = "订购日期";
            this.dataColOrderHeadDate.ColumnName = "OrderHeadDate";
            this.dataColOrderHeadDate.DataType = typeof(System.DateTime);
            // 
            // dataColPurCategory
            // 
            this.dataColPurCategory.Caption = "采购类型";
            this.dataColPurCategory.ColumnName = "PurCategory";
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
            // dataColReqDep
            // 
            this.dataColReqDep.Caption = "申请部门";
            this.dataColReqDep.ColumnName = "ReqDep";
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
            // dataColPlanDate
            // 
            this.dataColPlanDate.Caption = "计划到货日期";
            this.dataColPlanDate.ColumnName = "PlanDate";
            this.dataColPlanDate.DataType = typeof(System.DateTime);
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
            // dataColumn1
            // 
            this.dataColumn1.Caption = "审批时间";
            this.dataColumn1.ColumnName = "ApproverTime";
            this.dataColumn1.DataType = typeof(System.DateTime);
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
            // dataColReqState
            // 
            this.dataColReqState.Caption = "状态";
            this.dataColReqState.ColumnName = "ReqState";
            this.dataColReqState.DataType = typeof(int);
            // 
            // dataColPrReqRemark
            // 
            this.dataColPrReqRemark.Caption = "备注";
            this.dataColPrReqRemark.ColumnName = "PrReqRemark";
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
            // dataColSelect
            // 
            this.dataColSelect.Caption = "";
            this.dataColSelect.ColumnName = "Select";
            this.dataColSelect.DataType = typeof(bool);
            // 
            // dataColApprovalType
            // 
            this.dataColApprovalType.Caption = "审批类型";
            this.dataColApprovalType.ColumnName = "ApprovalType";
            // 
            // dataColPayTypeNo
            // 
            this.dataColPayTypeNo.Caption = "付款类型";
            this.dataColPayTypeNo.ColumnName = "PayTypeNo";
            // 
            // dataColProjectName
            // 
            this.dataColProjectName.Caption = "项目号";
            this.dataColProjectName.ColumnName = "ProjectName";
            // 
            // dataTableOrderList
            // 
            this.dataTableOrderList.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumnAutoId,
            this.dataColumnOrderHeadNo,
            this.dataColCodeFileName,
            this.dataColQty,
            this.dataColUnit,
            this.dataColAmount,
            this.dataColumnTax,
            this.dataColTaxAmount,
            this.dataColSumAmount,
            this.dataColumnPlanDate,
            this.dataColRemark,
            this.dataColCodeName,
            this.dataColListSelect,
            this.dataColWarehouseWarrentCount,
            this.dataColOverplus});
            this.dataTableOrderList.TableName = "OrderList";
            // 
            // dataColumnAutoId
            // 
            this.dataColumnAutoId.ColumnName = "AutoId";
            // 
            // dataColumnOrderHeadNo
            // 
            this.dataColumnOrderHeadNo.Caption = "采购单号";
            this.dataColumnOrderHeadNo.ColumnName = "OrderHeadNo";
            // 
            // dataColCodeFileName
            // 
            this.dataColCodeFileName.Caption = "零件编号";
            this.dataColCodeFileName.ColumnName = "CodeFileName";
            // 
            // dataColQty
            // 
            this.dataColQty.Caption = "数量";
            this.dataColQty.ColumnName = "Qty";
            this.dataColQty.DataType = typeof(double);
            // 
            // dataColUnit
            // 
            this.dataColUnit.Caption = "单价";
            this.dataColUnit.ColumnName = "Unit";
            this.dataColUnit.DataType = typeof(double);
            // 
            // dataColAmount
            // 
            this.dataColAmount.Caption = "金额";
            this.dataColAmount.ColumnName = "Amount";
            this.dataColAmount.DataType = typeof(double);
            // 
            // dataColumnTax
            // 
            this.dataColumnTax.Caption = "税率";
            this.dataColumnTax.ColumnName = "Tax";
            this.dataColumnTax.DataType = typeof(double);
            // 
            // dataColTaxAmount
            // 
            this.dataColTaxAmount.Caption = "税额";
            this.dataColTaxAmount.ColumnName = "TaxAmount";
            this.dataColTaxAmount.DataType = typeof(double);
            // 
            // dataColSumAmount
            // 
            this.dataColSumAmount.Caption = "价税合计";
            this.dataColSumAmount.ColumnName = "SumAmount";
            this.dataColSumAmount.DataType = typeof(double);
            // 
            // dataColumnPlanDate
            // 
            this.dataColumnPlanDate.Caption = "计划到货日期";
            this.dataColumnPlanDate.ColumnName = "PlanDate";
            this.dataColumnPlanDate.DataType = typeof(System.DateTime);
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
            // dataColListSelect
            // 
            this.dataColListSelect.Caption = "";
            this.dataColListSelect.ColumnName = "ListSelect";
            this.dataColListSelect.DataType = typeof(bool);
            // 
            // dataColWarehouseWarrentCount
            // 
            this.dataColWarehouseWarrentCount.Caption = "已入库数";
            this.dataColWarehouseWarrentCount.ColumnName = "WarehouseWarrentCount";
            this.dataColWarehouseWarrentCount.DataType = typeof(double);
            // 
            // dataColOverplus
            // 
            this.dataColOverplus.Caption = "剩余数量";
            this.dataColOverplus.ColumnName = "Overplus";
            this.dataColOverplus.DataType = typeof(double);
            // 
            // gridViewOrderList
            // 
            this.gridViewOrderList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId1,
            this.colListSelect,
            this.colOrderHeadNo1,
            this.colCodeFileName,
            this.colCodeName,
            this.colQty,
            this.colWarehouseWarrentCount,
            this.colOverplus,
            this.colUnit,
            this.colAmount,
            this.colTax1,
            this.colTaxAmount,
            this.colSumAmount,
            this.colPlanDate1,
            this.colRemark,
            this.colPrReqNo,
            this.colPrListAutoId});
            this.gridViewOrderList.GridControl = this.gridControlOrderList;
            this.gridViewOrderList.IndicatorWidth = 40;
            this.gridViewOrderList.Name = "gridViewOrderList";
            this.gridViewOrderList.OptionsBehavior.Editable = false;
            this.gridViewOrderList.OptionsBehavior.ReadOnly = true;
            this.gridViewOrderList.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewOrderList.OptionsView.ColumnAutoWidth = false;
            this.gridViewOrderList.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewOrderList.OptionsView.ShowFooter = true;
            this.gridViewOrderList.OptionsView.ShowGroupPanel = false;
            this.gridViewOrderList.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewOrderList_RowClick);
            this.gridViewOrderList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewOrderHead_CustomDrawRowIndicator);
            // 
            // colAutoId1
            // 
            this.colAutoId1.FieldName = "AutoId";
            this.colAutoId1.Name = "colAutoId1";
            // 
            // colListSelect
            // 
            this.colListSelect.ColumnEdit = this.repCheckListSelect;
            this.colListSelect.FieldName = "ListSelect";
            this.colListSelect.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
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
            // colOrderHeadNo1
            // 
            this.colOrderHeadNo1.AppearanceHeader.Options.UseTextOptions = true;
            this.colOrderHeadNo1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOrderHeadNo1.FieldName = "OrderHeadNo";
            this.colOrderHeadNo1.Name = "colOrderHeadNo1";
            this.colOrderHeadNo1.OptionsColumn.AllowEdit = false;
            this.colOrderHeadNo1.OptionsColumn.ReadOnly = true;
            this.colOrderHeadNo1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "PrReqNo", "共计{0}条")});
            this.colOrderHeadNo1.Visible = true;
            this.colOrderHeadNo1.VisibleIndex = 1;
            this.colOrderHeadNo1.Width = 110;
            // 
            // colCodeFileName
            // 
            this.colCodeFileName.AppearanceHeader.Options.UseTextOptions = true;
            this.colCodeFileName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCodeFileName.FieldName = "CodeFileName";
            this.colCodeFileName.Name = "colCodeFileName";
            this.colCodeFileName.OptionsColumn.AllowEdit = false;
            this.colCodeFileName.Visible = true;
            this.colCodeFileName.VisibleIndex = 2;
            this.colCodeFileName.Width = 110;
            // 
            // colCodeName
            // 
            this.colCodeName.AppearanceHeader.Options.UseTextOptions = true;
            this.colCodeName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCodeName.FieldName = "CodeName";
            this.colCodeName.Name = "colCodeName";
            this.colCodeName.OptionsColumn.AllowEdit = false;
            this.colCodeName.Visible = true;
            this.colCodeName.VisibleIndex = 3;
            this.colCodeName.Width = 110;
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
            // colWarehouseWarrentCount
            // 
            this.colWarehouseWarrentCount.AppearanceHeader.Options.UseTextOptions = true;
            this.colWarehouseWarrentCount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWarehouseWarrentCount.FieldName = "WarehouseWarrentCount";
            this.colWarehouseWarrentCount.Name = "colWarehouseWarrentCount";
            this.colWarehouseWarrentCount.OptionsColumn.AllowEdit = false;
            this.colWarehouseWarrentCount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "WarehouseWarrentCount", "{0:0.##}")});
            this.colWarehouseWarrentCount.Visible = true;
            this.colWarehouseWarrentCount.VisibleIndex = 5;
            this.colWarehouseWarrentCount.Width = 80;
            // 
            // colOverplus
            // 
            this.colOverplus.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.colOverplus.AppearanceCell.Options.UseForeColor = true;
            this.colOverplus.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.colOverplus.AppearanceHeader.Options.UseForeColor = true;
            this.colOverplus.AppearanceHeader.Options.UseTextOptions = true;
            this.colOverplus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOverplus.FieldName = "Overplus";
            this.colOverplus.Name = "colOverplus";
            this.colOverplus.OptionsColumn.AllowEdit = false;
            this.colOverplus.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Overplus", "{0:0.##}")});
            this.colOverplus.Visible = true;
            this.colOverplus.VisibleIndex = 6;
            this.colOverplus.Width = 80;
            // 
            // colUnit
            // 
            this.colUnit.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnit.ColumnEdit = this.repSpinUnit;
            this.colUnit.DisplayFormat.FormatString = "N4";
            this.colUnit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.OptionsColumn.AllowEdit = false;
            this.colUnit.Visible = true;
            this.colUnit.VisibleIndex = 7;
            this.colUnit.Width = 100;
            // 
            // repSpinUnit
            // 
            this.repSpinUnit.AutoHeight = false;
            this.repSpinUnit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repSpinUnit.Mask.EditMask = "\\d+(\\R.\\d{0,4})?";
            this.repSpinUnit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repSpinUnit.MaxValue = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.repSpinUnit.Name = "repSpinUnit";
            // 
            // colAmount
            // 
            this.colAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAmount.DisplayFormat.FormatString = "N2";
            this.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.OptionsColumn.AllowEdit = false;
            this.colAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "{0:N2}")});
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 8;
            this.colAmount.Width = 80;
            // 
            // colTax1
            // 
            this.colTax1.AppearanceHeader.Options.UseTextOptions = true;
            this.colTax1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTax1.ColumnEdit = this.repSpinTax1;
            this.colTax1.DisplayFormat.FormatString = "P0";
            this.colTax1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTax1.FieldName = "Tax";
            this.colTax1.Name = "colTax1";
            this.colTax1.OptionsColumn.AllowEdit = false;
            this.colTax1.Visible = true;
            this.colTax1.VisibleIndex = 9;
            this.colTax1.Width = 60;
            // 
            // repSpinTax1
            // 
            this.repSpinTax1.AutoHeight = false;
            this.repSpinTax1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repSpinTax1.DisplayFormat.FormatString = "p0";
            this.repSpinTax1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repSpinTax1.EditFormat.FormatString = "p0";
            this.repSpinTax1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repSpinTax1.Mask.EditMask = "p0";
            this.repSpinTax1.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repSpinTax1.Name = "repSpinTax1";
            // 
            // colTaxAmount
            // 
            this.colTaxAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colTaxAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTaxAmount.DisplayFormat.FormatString = "N2";
            this.colTaxAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTaxAmount.FieldName = "TaxAmount";
            this.colTaxAmount.Name = "colTaxAmount";
            this.colTaxAmount.OptionsColumn.AllowEdit = false;
            this.colTaxAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TaxAmount", "{0:N2}")});
            this.colTaxAmount.Visible = true;
            this.colTaxAmount.VisibleIndex = 10;
            this.colTaxAmount.Width = 80;
            // 
            // colSumAmount
            // 
            this.colSumAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colSumAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSumAmount.DisplayFormat.FormatString = "N2";
            this.colSumAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSumAmount.FieldName = "SumAmount";
            this.colSumAmount.Name = "colSumAmount";
            this.colSumAmount.OptionsColumn.AllowEdit = false;
            this.colSumAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SumAmount", "{0:N2}")});
            this.colSumAmount.Visible = true;
            this.colSumAmount.VisibleIndex = 11;
            this.colSumAmount.Width = 80;
            // 
            // colPlanDate1
            // 
            this.colPlanDate1.AppearanceHeader.Options.UseTextOptions = true;
            this.colPlanDate1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPlanDate1.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.colPlanDate1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colPlanDate1.FieldName = "PlanDate";
            this.colPlanDate1.Name = "colPlanDate1";
            this.colPlanDate1.OptionsColumn.AllowEdit = false;
            this.colPlanDate1.Visible = true;
            this.colPlanDate1.VisibleIndex = 12;
            this.colPlanDate1.Width = 90;
            // 
            // colRemark
            // 
            this.colRemark.AppearanceHeader.Options.UseTextOptions = true;
            this.colRemark.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.OptionsColumn.AllowEdit = false;
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 13;
            this.colRemark.Width = 140;
            // 
            // colPrReqNo
            // 
            this.colPrReqNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrReqNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrReqNo.FieldName = "PrReqNo";
            this.colPrReqNo.Name = "colPrReqNo";
            this.colPrReqNo.OptionsColumn.AllowEdit = false;
            this.colPrReqNo.Width = 110;
            // 
            // colPrListAutoId
            // 
            this.colPrListAutoId.FieldName = "PrListAutoId";
            this.colPrListAutoId.Name = "colPrListAutoId";
            this.colPrListAutoId.OptionsColumn.AllowEdit = false;
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
            this.repSearchCodeFileName.View = this.gridView3;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumnCodeFileName,
            this.gridColumnCodeName});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.IndicatorWidth = 60;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "AutoId";
            this.gridColumn2.Name = "gridColumn2";
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
            // pnlMiddleTop
            // 
            this.pnlMiddleTop.Controls.Add(this.gridControlOrderHead);
            this.pnlMiddleTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMiddleTop.Location = new System.Drawing.Point(2, 2);
            this.pnlMiddleTop.Name = "pnlMiddleTop";
            this.pnlMiddleTop.Size = new System.Drawing.Size(1004, 155);
            this.pnlMiddleTop.TabIndex = 1;
            // 
            // gridControlOrderHead
            // 
            this.gridControlOrderHead.DataSource = this.bindingSource_OrderHead;
            this.gridControlOrderHead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlOrderHead.Location = new System.Drawing.Point(2, 2);
            this.gridControlOrderHead.MainView = this.gridViewOrderHead;
            this.gridControlOrderHead.Name = "gridControlOrderHead";
            this.gridControlOrderHead.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repLookUpReqDep,
            this.repLookUpPurCategory,
            this.repSearchBussinessBaseNo,
            this.repCheckSelect,
            this.repLookUpApprovalType,
            this.repLookUpPayTypeNo});
            this.gridControlOrderHead.Size = new System.Drawing.Size(1000, 151);
            this.gridControlOrderHead.TabIndex = 4;
            this.gridControlOrderHead.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOrderHead});
            // 
            // bindingSource_OrderHead
            // 
            this.bindingSource_OrderHead.DataMember = "OrderHead";
            this.bindingSource_OrderHead.DataSource = this.dataSet_Order;
            // 
            // gridViewOrderHead
            // 
            this.gridViewOrderHead.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId,
            this.colSelect,
            this.colOrderHeadNo,
            this.colReqState,
            this.colOrderHeadDate,
            this.colPurCategory,
            this.colBussinessBaseNo,
            this.colReqDep,
            this.colTax,
            this.colProjectName,
            this.colStnNo,
            this.colApprovalType,
            this.colPayTypeNo,
            this.colPlanDate,
            this.colPrReqRemark,
            this.colPrepared,
            this.colClosed});
            this.gridViewOrderHead.GridControl = this.gridControlOrderHead;
            this.gridViewOrderHead.IndicatorWidth = 40;
            this.gridViewOrderHead.Name = "gridViewOrderHead";
            this.gridViewOrderHead.OptionsBehavior.Editable = false;
            this.gridViewOrderHead.OptionsBehavior.ReadOnly = true;
            this.gridViewOrderHead.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewOrderHead.OptionsView.ColumnAutoWidth = false;
            this.gridViewOrderHead.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewOrderHead.OptionsView.ShowGroupPanel = false;
            this.gridViewOrderHead.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewOrderHead_CustomDrawRowIndicator);
            this.gridViewOrderHead.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewOrderHead_FocusedRowChanged);
            this.gridViewOrderHead.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridViewOrderHead_CustomColumnDisplayText);
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
            this.colSelect.Width = 35;
            // 
            // repCheckSelect
            // 
            this.repCheckSelect.AutoHeight = false;
            this.repCheckSelect.Name = "repCheckSelect";
            this.repCheckSelect.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repCheckSelect.ValueGrayed = false;
            // 
            // colOrderHeadNo
            // 
            this.colOrderHeadNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colOrderHeadNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOrderHeadNo.FieldName = "OrderHeadNo";
            this.colOrderHeadNo.Name = "colOrderHeadNo";
            this.colOrderHeadNo.OptionsColumn.AllowEdit = false;
            this.colOrderHeadNo.OptionsColumn.AllowFocus = false;
            this.colOrderHeadNo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "PrReqNo", "共计{0}条")});
            this.colOrderHeadNo.Visible = true;
            this.colOrderHeadNo.VisibleIndex = 0;
            this.colOrderHeadNo.Width = 110;
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
            this.colReqState.VisibleIndex = 1;
            this.colReqState.Width = 60;
            // 
            // colOrderHeadDate
            // 
            this.colOrderHeadDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colOrderHeadDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOrderHeadDate.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.colOrderHeadDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colOrderHeadDate.FieldName = "OrderHeadDate";
            this.colOrderHeadDate.Name = "colOrderHeadDate";
            this.colOrderHeadDate.OptionsColumn.AllowEdit = false;
            this.colOrderHeadDate.OptionsColumn.AllowFocus = false;
            this.colOrderHeadDate.Visible = true;
            this.colOrderHeadDate.VisibleIndex = 2;
            this.colOrderHeadDate.Width = 90;
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
            this.colPurCategory.VisibleIndex = 3;
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
            // colTax
            // 
            this.colTax.AppearanceHeader.Options.UseTextOptions = true;
            this.colTax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTax.FieldName = "Tax";
            this.colTax.Name = "colTax";
            this.colTax.OptionsColumn.AllowEdit = false;
            this.colTax.Visible = true;
            this.colTax.VisibleIndex = 6;
            this.colTax.Width = 60;
            // 
            // colProjectName
            // 
            this.colProjectName.AppearanceHeader.Options.UseTextOptions = true;
            this.colProjectName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProjectName.FieldName = "ProjectName";
            this.colProjectName.Name = "colProjectName";
            this.colProjectName.OptionsColumn.AllowEdit = false;
            this.colProjectName.Visible = true;
            this.colProjectName.VisibleIndex = 7;
            this.colProjectName.Width = 100;
            // 
            // colStnNo
            // 
            this.colStnNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colStnNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStnNo.FieldName = "StnNo";
            this.colStnNo.Name = "colStnNo";
            this.colStnNo.OptionsColumn.AllowEdit = false;
            this.colStnNo.Visible = true;
            this.colStnNo.VisibleIndex = 8;
            this.colStnNo.Width = 100;
            // 
            // colApprovalType
            // 
            this.colApprovalType.AppearanceHeader.Options.UseTextOptions = true;
            this.colApprovalType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colApprovalType.ColumnEdit = this.repLookUpApprovalType;
            this.colApprovalType.FieldName = "ApprovalType";
            this.colApprovalType.Name = "colApprovalType";
            this.colApprovalType.OptionsColumn.AllowEdit = false;
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
            // colPayTypeNo
            // 
            this.colPayTypeNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colPayTypeNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPayTypeNo.ColumnEdit = this.repLookUpPayTypeNo;
            this.colPayTypeNo.FieldName = "PayTypeNo";
            this.colPayTypeNo.Name = "colPayTypeNo";
            this.colPayTypeNo.OptionsColumn.AllowEdit = false;
            this.colPayTypeNo.Width = 100;
            // 
            // repLookUpPayTypeNo
            // 
            this.repLookUpPayTypeNo.AutoHeight = false;
            this.repLookUpPayTypeNo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpPayTypeNo.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AutoId", "AutoId", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PayTypeNo", "付款类型"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PayTypeNoText", "付款说明")});
            this.repLookUpPayTypeNo.DisplayMember = "PayTypeNoText";
            this.repLookUpPayTypeNo.Name = "repLookUpPayTypeNo";
            this.repLookUpPayTypeNo.NullText = "";
            this.repLookUpPayTypeNo.ValueMember = "PayTypeNo";
            // 
            // colPlanDate
            // 
            this.colPlanDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colPlanDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPlanDate.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.colPlanDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colPlanDate.FieldName = "PlanDate";
            this.colPlanDate.Name = "colPlanDate";
            this.colPlanDate.OptionsColumn.AllowEdit = false;
            this.colPlanDate.Width = 90;
            // 
            // colPrReqRemark
            // 
            this.colPrReqRemark.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrReqRemark.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrReqRemark.FieldName = "PrReqRemark";
            this.colPrReqRemark.Name = "colPrReqRemark";
            this.colPrReqRemark.OptionsColumn.AllowEdit = false;
            this.colPrReqRemark.Visible = true;
            this.colPrReqRemark.VisibleIndex = 9;
            this.colPrReqRemark.Width = 140;
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
            this.colPrepared.VisibleIndex = 10;
            this.colPrepared.Width = 70;
            // 
            // colClosed
            // 
            this.colClosed.AppearanceHeader.Options.UseTextOptions = true;
            this.colClosed.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colClosed.FieldName = "Closed";
            this.colClosed.Name = "colClosed";
            this.colClosed.OptionsColumn.AllowEdit = false;
            this.colClosed.OptionsColumn.AllowFocus = false;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnCancel);
            this.pnlBottom.Controls.Add(this.BtnConfirm);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 525);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1008, 36);
            this.pnlBottom.TabIndex = 2;
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
            this.BtnConfirm.Location = new System.Drawing.Point(838, 7);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(75, 23);
            this.BtnConfirm.TabIndex = 0;
            this.BtnConfirm.Text = "确定";
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiQxzysydygcgd,
            this.tsmiQxzysydcgddmxjl});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(341, 48);
            // 
            // tsmiQxzysydygcgd
            // 
            this.tsmiQxzysydygcgd.Name = "tsmiQxzysydygcgd";
            this.tsmiQxzysydygcgd.Size = new System.Drawing.Size(340, 22);
            this.tsmiQxzysydygcgd.Text = "请选择要适用的一个采购单，请重新操作。";
            // 
            // tsmiQxzysydcgddmxjl
            // 
            this.tsmiQxzysydcgddmxjl.Name = "tsmiQxzysydcgddmxjl";
            this.tsmiQxzysydcgddmxjl.Size = new System.Drawing.Size(340, 22);
            this.tsmiQxzysydcgddmxjl.Text = "请选择要适用的采购订单明细记录，请重新操作。";
            // 
            // FrmOrderApply
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.pnlMiddle);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlBottom);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOrderApply";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabText = "订单适用";
            this.Text = "订单适用";
            this.Load += new System.EventHandler(this.FrmOrderApply_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpBussinessBaseNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpBussinessBaseNoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpProjectNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpProjectNoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkOrderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCommon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPrepared.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPurCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpReqDep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDateEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDateBegin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDateBegin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textOrderHeadNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddle)).EndInit();
            this.pnlMiddle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddleBottom)).EndInit();
            this.pnlMiddleBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_OrderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableOrderHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableOrderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckListSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinTax1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchCodeFileName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddleTop)).EndInit();
            this.pnlMiddleTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrderHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_OrderHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrderHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpPurCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchBussinessBaseNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpReqDep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpApprovalType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpPayTypeNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlTop;
        private DevExpress.XtraEditors.PanelControl pnlMiddle;
        private DevExpress.XtraEditors.PanelControl pnlMiddleTop;
        private DevExpress.XtraEditors.PanelControl pnlMiddleBottom;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpProjectNo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpProjectNoView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColProjectNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColProjectName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColRemark;
        private DevExpress.XtraEditors.LabelControl labProjectNo;
        private DevExpress.XtraEditors.CheckEdit checkOrderDate;
        private DevExpress.XtraEditors.TextEdit textCommon;
        private DevExpress.XtraEditors.LabelControl labCommon;
        private DevExpress.XtraEditors.LabelControl labPrepared;
        private DevExpress.XtraEditors.LookUpEdit lookUpPrepared;
        private DevExpress.XtraEditors.LookUpEdit lookUpPurCategory;
        private DevExpress.XtraEditors.LabelControl labPurCategory;
        private DevExpress.XtraEditors.LookUpEdit lookUpReqDep;
        private DevExpress.XtraEditors.LabelControl labReqDep;
        private DevExpress.XtraEditors.DateEdit dateOrderDateEnd;
        private DevExpress.XtraEditors.LabelControl lab;
        private DevExpress.XtraEditors.LabelControl labOrderDate;
        private DevExpress.XtraEditors.DateEdit dateOrderDateBegin;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.TextEdit textOrderHeadNo;
        private DevExpress.XtraEditors.LabelControl labOrderHeadNo;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpBussinessBaseNo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpBussinessBaseNoView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBussinessBaseNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBussinessBaseText;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBussinessCategoryText;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.LabelControl labBussinessBaseNo;
        private System.Data.DataTable dataTableOrderHead;
        private System.Data.DataColumn dataColAutoId;
        private System.Data.DataColumn dataColOrderHeadNo;
        private System.Data.DataColumn dataColOrderHeadDate;
        private System.Data.DataColumn dataColPurCategory;
        private System.Data.DataColumn dataColBussinessBaseNo;
        private System.Data.DataColumn dataColTax;
        private System.Data.DataColumn dataColReqDep;
        private System.Data.DataColumn dataColPrepared;
        private System.Data.DataColumn dataColPreparedIp;
        private System.Data.DataColumn dataColProjectNo;
        private System.Data.DataColumn dataColStnNo;
        private System.Data.DataColumn dataColPlanDate;
        private System.Data.DataColumn dataColApprover;
        private System.Data.DataColumn dataColApproverIp;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColModifier;
        private System.Data.DataColumn dataColModifierIp;
        private System.Data.DataColumn dataColModifierTime;
        private System.Data.DataColumn dataColReqState;
        private System.Data.DataColumn dataColPrReqRemark;
        private System.Data.DataColumn dataColClosed;
        private System.Data.DataColumn dataColClosedIp;
        private System.Data.DataColumn dataColClosedTime;
        private System.Data.DataColumn dataColSelect;
        private System.Data.DataColumn dataColApprovalType;
        private System.Data.DataColumn dataColPayTypeNo;
        private System.Data.DataTable dataTableOrderList;
        private System.Data.DataColumn dataColumnAutoId;
        private System.Data.DataColumn dataColumnOrderHeadNo;
        private System.Data.DataColumn dataColCodeFileName;
        private System.Data.DataColumn dataColQty;
        private System.Data.DataColumn dataColUnit;
        private System.Data.DataColumn dataColAmount;
        private System.Data.DataColumn dataColumnTax;
        private System.Data.DataColumn dataColTaxAmount;
        private System.Data.DataColumn dataColSumAmount;
        private System.Data.DataColumn dataColumnPlanDate;
        private System.Data.DataColumn dataColRemark;
        private System.Data.DataColumn dataColCodeName;
        private System.Windows.Forms.BindingSource bindingSource_OrderHead;
        private System.Windows.Forms.BindingSource bindingSource_OrderList;
        private DevExpress.XtraGrid.GridControl gridControlOrderHead;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colSelect;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheckSelect;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderHeadNo;
        private DevExpress.XtraGrid.Columns.GridColumn colReqState;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderHeadDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPurCategory;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpPurCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colBussinessBaseNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repSearchBussinessBaseNo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridCBussinessBaseNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridCBussinessBaseText;
        private DevExpress.XtraGrid.Columns.GridColumn gridCBussinessCategoryText;
        private DevExpress.XtraGrid.Columns.GridColumn gridCAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colReqDep;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpReqDep;
        private DevExpress.XtraGrid.Columns.GridColumn colTax;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectName;
        private DevExpress.XtraGrid.Columns.GridColumn colStnNo;
        private DevExpress.XtraGrid.Columns.GridColumn colApprovalType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpApprovalType;
        private DevExpress.XtraGrid.Columns.GridColumn colPayTypeNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpPayTypeNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPlanDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPrReqRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colPrepared;
        private DevExpress.XtraGrid.Columns.GridColumn colClosed;
        private DevExpress.XtraGrid.GridControl gridControlOrderList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewOrderList;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId1;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderHeadNo1;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeFileName;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repSearchCodeFileName;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCodeFileName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCodeName;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeName;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repSpinUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colQty;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repSpinQty;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colTax1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repSpinTax1;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colSumAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colPlanDate1;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colPrReqNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPrListAutoId;
        private System.Data.DataColumn dataColListSelect;
        private System.Data.DataColumn dataColWarehouseWarrentCount;
        private System.Data.DataColumn dataColOverplus;
        private DevExpress.XtraGrid.Columns.GridColumn colListSelect;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouseWarrentCount;
        private DevExpress.XtraGrid.Columns.GridColumn colOverplus;
        private DevExpress.XtraEditors.PanelControl pnlBottom;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton BtnConfirm;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheckListSelect;
        private DevExpress.XtraEditors.CheckEdit checkAll;
        public System.Data.DataSet dataSet_Order;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewOrderHead;
        private System.Data.DataColumn dataColProjectName;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem tsmiQxzysydygcgd;
        private System.Windows.Forms.ToolStripMenuItem tsmiQxzysydcgddmxjl;
    }
}