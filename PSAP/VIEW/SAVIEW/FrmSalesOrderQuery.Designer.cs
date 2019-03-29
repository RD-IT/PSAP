namespace PSAP.VIEW.BSVIEW
{
    partial class FrmSalesOrderQuery
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
            this.bindingSource_SalesOrder = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_SalesOrder = new System.Data.DataSet();
            this.TableSalesOrder = new System.Data.DataTable();
            this.dataColAutoId = new System.Data.DataColumn();
            this.dataColAutoSalesOrderNo = new System.Data.DataColumn();
            this.dataColSalesOrderDate = new System.Data.DataColumn();
            this.dataColProjectNo = new System.Data.DataColumn();
            this.dataColProjectName = new System.Data.DataColumn();
            this.dataColBussinessBaseNo = new System.Data.DataColumn();
            this.dataColAutoQuotationNo = new System.Data.DataColumn();
            this.dataColQuotationVersions = new System.Data.DataColumn();
            this.dataColCustomerPoNo = new System.Data.DataColumn();
            this.dataColCollectionTypeNo = new System.Data.DataColumn();
            this.dataColAmount = new System.Data.DataColumn();
            this.dataColTax = new System.Data.DataColumn();
            this.dataColTaxAmount = new System.Data.DataColumn();
            this.dataColSumAmount = new System.Data.DataColumn();
            this.dataColProjectLeader = new System.Data.DataColumn();
            this.dataColIsEnd = new System.Data.DataColumn();
            this.dataColPrepared = new System.Data.DataColumn();
            this.dataColPreparedIp = new System.Data.DataColumn();
            this.dataColModifier = new System.Data.DataColumn();
            this.dataColModifierIp = new System.Data.DataColumn();
            this.dataColModifierTime = new System.Data.DataColumn();
            this.dataColRemark = new System.Data.DataColumn();
            this.dataColParentAutoSalesOrderNo = new System.Data.DataColumn();
            this.dataColParentProjectNo = new System.Data.DataColumn();
            this.dataColSalesOrderState = new System.Data.DataColumn();
            this.pnltop = new DevExpress.XtraEditors.PanelControl();
            this.lookUpPrepared = new DevExpress.XtraEditors.LookUpEdit();
            this.labPrepared = new DevExpress.XtraEditors.LabelControl();
            this.searchProjectNo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchAdjustmentsProjectNoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColProjectNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColProjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labProjectNo = new DevExpress.XtraEditors.LabelControl();
            this.btnSaveExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.textCommon = new DevExpress.XtraEditors.TextEdit();
            this.searchLookUpBussinessBaseNo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpBussinessBaseNoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnBussinessBaseNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBussinessBaseText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBussinessCategoryText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateSalesOrderDateEnd = new DevExpress.XtraEditors.DateEdit();
            this.dateSalesOrderDateBegin = new DevExpress.XtraEditors.DateEdit();
            this.labCommon = new DevExpress.XtraEditors.LabelControl();
            this.labBussinessBaseNo = new DevExpress.XtraEditors.LabelControl();
            this.lab1 = new DevExpress.XtraEditors.LabelControl();
            this.labRecordDate = new DevExpress.XtraEditors.LabelControl();
            this.pnlMiddle = new DevExpress.XtraEditors.PanelControl();
            this.gridControlSalesOrder = new DevExpress.XtraGrid.GridControl();
            this.gridViewSalesOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAutoSalesOrderNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAutoQuotationNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBussinessBaseNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSearchBussinessBaseNo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridCBussinessBaseNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCBussinessBaseText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCBussinessCategoryText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuotationVersions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSumAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCollectionTypeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpCollectionTypeNo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colCustomerPoNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjectLeader = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsEnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCheckIsEnd = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrepared = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifierTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParentAutoSalesOrderNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParentProjectNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCheckSelect = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.pnlBottom = new DevExpress.XtraEditors.PanelControl();
            this.gridBottomOrderHead = new PSAP.VIEW.BSVIEW.GridBottom();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_SalesOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_SalesOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableSalesOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnltop)).BeginInit();
            this.pnltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPrepared.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchProjectNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchAdjustmentsProjectNoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCommon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpBussinessBaseNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpBussinessBaseNoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSalesOrderDateEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSalesOrderDateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSalesOrderDateBegin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSalesOrderDateBegin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddle)).BeginInit();
            this.pnlMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSalesOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSalesOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchBussinessBaseNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpCollectionTypeNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckIsEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingSource_SalesOrder
            // 
            this.bindingSource_SalesOrder.DataMember = "SalesOrder";
            this.bindingSource_SalesOrder.DataSource = this.dataSet_SalesOrder;
            // 
            // dataSet_SalesOrder
            // 
            this.dataSet_SalesOrder.DataSetName = "NewDataSet";
            this.dataSet_SalesOrder.EnforceConstraints = false;
            this.dataSet_SalesOrder.Tables.AddRange(new System.Data.DataTable[] {
            this.TableSalesOrder});
            // 
            // TableSalesOrder
            // 
            this.TableSalesOrder.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColAutoId,
            this.dataColAutoSalesOrderNo,
            this.dataColSalesOrderDate,
            this.dataColProjectNo,
            this.dataColProjectName,
            this.dataColBussinessBaseNo,
            this.dataColAutoQuotationNo,
            this.dataColQuotationVersions,
            this.dataColCustomerPoNo,
            this.dataColCollectionTypeNo,
            this.dataColAmount,
            this.dataColTax,
            this.dataColTaxAmount,
            this.dataColSumAmount,
            this.dataColProjectLeader,
            this.dataColIsEnd,
            this.dataColPrepared,
            this.dataColPreparedIp,
            this.dataColModifier,
            this.dataColModifierIp,
            this.dataColModifierTime,
            this.dataColRemark,
            this.dataColParentAutoSalesOrderNo,
            this.dataColParentProjectNo,
            this.dataColSalesOrderState});
            this.TableSalesOrder.TableName = "SalesOrder";
            // 
            // dataColAutoId
            // 
            this.dataColAutoId.ColumnName = "AutoId";
            this.dataColAutoId.DataType = typeof(int);
            // 
            // dataColAutoSalesOrderNo
            // 
            this.dataColAutoSalesOrderNo.Caption = "销售订单号";
            this.dataColAutoSalesOrderNo.ColumnName = "AutoSalesOrderNo";
            // 
            // dataColSalesOrderDate
            // 
            this.dataColSalesOrderDate.Caption = "登记日期";
            this.dataColSalesOrderDate.ColumnName = "SalesOrderDate";
            this.dataColSalesOrderDate.DataType = typeof(System.DateTime);
            // 
            // dataColProjectNo
            // 
            this.dataColProjectNo.Caption = "项目号";
            this.dataColProjectNo.ColumnName = "ProjectNo";
            // 
            // dataColProjectName
            // 
            this.dataColProjectName.Caption = "项目名称";
            this.dataColProjectName.ColumnName = "ProjectName";
            // 
            // dataColBussinessBaseNo
            // 
            this.dataColBussinessBaseNo.Caption = "往来方";
            this.dataColBussinessBaseNo.ColumnName = "BussinessBaseNo";
            // 
            // dataColAutoQuotationNo
            // 
            this.dataColAutoQuotationNo.Caption = "报价单号";
            this.dataColAutoQuotationNo.ColumnName = "AutoQuotationNo";
            // 
            // dataColQuotationVersions
            // 
            this.dataColQuotationVersions.Caption = "报价版本";
            this.dataColQuotationVersions.ColumnName = "QuotationVersions";
            // 
            // dataColCustomerPoNo
            // 
            this.dataColCustomerPoNo.Caption = "客户PO号";
            this.dataColCustomerPoNo.ColumnName = "CustomerPoNo";
            // 
            // dataColCollectionTypeNo
            // 
            this.dataColCollectionTypeNo.Caption = "收款方式";
            this.dataColCollectionTypeNo.ColumnName = "CollectionTypeNo";
            // 
            // dataColAmount
            // 
            this.dataColAmount.Caption = "金额";
            this.dataColAmount.ColumnName = "Amount";
            this.dataColAmount.DataType = typeof(decimal);
            // 
            // dataColTax
            // 
            this.dataColTax.Caption = "税率";
            this.dataColTax.ColumnName = "Tax";
            this.dataColTax.DataType = typeof(double);
            // 
            // dataColTaxAmount
            // 
            this.dataColTaxAmount.Caption = "税额";
            this.dataColTaxAmount.ColumnName = "TaxAmount";
            this.dataColTaxAmount.DataType = typeof(decimal);
            // 
            // dataColSumAmount
            // 
            this.dataColSumAmount.Caption = "价税合计";
            this.dataColSumAmount.ColumnName = "SumAmount";
            this.dataColSumAmount.DataType = typeof(decimal);
            // 
            // dataColProjectLeader
            // 
            this.dataColProjectLeader.Caption = "项目负责人";
            this.dataColProjectLeader.ColumnName = "ProjectLeader";
            // 
            // dataColIsEnd
            // 
            this.dataColIsEnd.Caption = "结账完毕";
            this.dataColIsEnd.ColumnName = "IsEnd";
            this.dataColIsEnd.DataType = typeof(int);
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
            // dataColRemark
            // 
            this.dataColRemark.Caption = "备注";
            this.dataColRemark.ColumnName = "Remark";
            // 
            // dataColParentAutoSalesOrderNo
            // 
            this.dataColParentAutoSalesOrderNo.Caption = "父级销售订单号";
            this.dataColParentAutoSalesOrderNo.ColumnName = "ParentAutoSalesOrderNo";
            // 
            // dataColParentProjectNo
            // 
            this.dataColParentProjectNo.Caption = "父级项目号";
            this.dataColParentProjectNo.ColumnName = "ParentProjectNo";
            // 
            // dataColSalesOrderState
            // 
            this.dataColSalesOrderState.Caption = "单据状态";
            this.dataColSalesOrderState.ColumnName = "SalesOrderState";
            this.dataColSalesOrderState.DataType = typeof(int);
            // 
            // pnltop
            // 
            this.pnltop.Controls.Add(this.lookUpPrepared);
            this.pnltop.Controls.Add(this.labPrepared);
            this.pnltop.Controls.Add(this.searchProjectNo);
            this.pnltop.Controls.Add(this.labProjectNo);
            this.pnltop.Controls.Add(this.btnSaveExcel);
            this.pnltop.Controls.Add(this.btnQuery);
            this.pnltop.Controls.Add(this.textCommon);
            this.pnltop.Controls.Add(this.searchLookUpBussinessBaseNo);
            this.pnltop.Controls.Add(this.dateSalesOrderDateEnd);
            this.pnltop.Controls.Add(this.dateSalesOrderDateBegin);
            this.pnltop.Controls.Add(this.labCommon);
            this.pnltop.Controls.Add(this.labBussinessBaseNo);
            this.pnltop.Controls.Add(this.lab1);
            this.pnltop.Controls.Add(this.labRecordDate);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(1905, 78);
            this.pnltop.TabIndex = 8;
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
            this.labPrepared.TabIndex = 32;
            this.labPrepared.Text = "制单人：";
            // 
            // searchProjectNo
            // 
            this.searchProjectNo.EnterMoveNextControl = true;
            this.searchProjectNo.Location = new System.Drawing.Point(624, 14);
            this.searchProjectNo.Margin = new System.Windows.Forms.Padding(4);
            this.searchProjectNo.Name = "searchProjectNo";
            this.searchProjectNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchProjectNo.Properties.DisplayMember = "ProjectName";
            this.searchProjectNo.Properties.NullText = "";
            this.searchProjectNo.Properties.ValueMember = "ProjectNo";
            this.searchProjectNo.Properties.View = this.searchAdjustmentsProjectNoView;
            this.searchProjectNo.Size = new System.Drawing.Size(120, 20);
            this.searchProjectNo.TabIndex = 3;
            // 
            // searchAdjustmentsProjectNoView
            // 
            this.searchAdjustmentsProjectNoView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColProjectNo,
            this.gridColProjectName,
            this.gridColRemark});
            this.searchAdjustmentsProjectNoView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchAdjustmentsProjectNoView.IndicatorWidth = 60;
            this.searchAdjustmentsProjectNoView.Name = "searchAdjustmentsProjectNoView";
            this.searchAdjustmentsProjectNoView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchAdjustmentsProjectNoView.OptionsView.ShowGroupPanel = false;
            this.searchAdjustmentsProjectNoView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewSalesOrder_CustomDrawRowIndicator);
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
            // labProjectNo
            // 
            this.labProjectNo.Location = new System.Drawing.Point(556, 17);
            this.labProjectNo.Margin = new System.Windows.Forms.Padding(4);
            this.labProjectNo.Name = "labProjectNo";
            this.labProjectNo.Size = new System.Drawing.Size(60, 14);
            this.labProjectNo.TabIndex = 30;
            this.labProjectNo.Text = "项目名称：";
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
            // searchLookUpBussinessBaseNo
            // 
            this.searchLookUpBussinessBaseNo.EnterMoveNextControl = true;
            this.searchLookUpBussinessBaseNo.Location = new System.Drawing.Point(380, 14);
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
            this.searchLookUpBussinessBaseNoView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewSalesOrder_CustomDrawRowIndicator);
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
            // dateSalesOrderDateEnd
            // 
            this.dateSalesOrderDateEnd.EditValue = null;
            this.dateSalesOrderDateEnd.EnterMoveNextControl = true;
            this.dateSalesOrderDateEnd.Location = new System.Drawing.Point(202, 14);
            this.dateSalesOrderDateEnd.Name = "dateSalesOrderDateEnd";
            this.dateSalesOrderDateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSalesOrderDateEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSalesOrderDateEnd.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dateSalesOrderDateEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateSalesOrderDateEnd.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateSalesOrderDateEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateSalesOrderDateEnd.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateSalesOrderDateEnd.Size = new System.Drawing.Size(100, 20);
            this.dateSalesOrderDateEnd.TabIndex = 1;
            // 
            // dateSalesOrderDateBegin
            // 
            this.dateSalesOrderDateBegin.EditValue = null;
            this.dateSalesOrderDateBegin.EnterMoveNextControl = true;
            this.dateSalesOrderDateBegin.Location = new System.Drawing.Point(86, 14);
            this.dateSalesOrderDateBegin.Name = "dateSalesOrderDateBegin";
            this.dateSalesOrderDateBegin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSalesOrderDateBegin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSalesOrderDateBegin.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dateSalesOrderDateBegin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateSalesOrderDateBegin.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateSalesOrderDateBegin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateSalesOrderDateBegin.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateSalesOrderDateBegin.Size = new System.Drawing.Size(100, 20);
            this.dateSalesOrderDateBegin.TabIndex = 0;
            // 
            // labCommon
            // 
            this.labCommon.Location = new System.Drawing.Point(227, 47);
            this.labCommon.Name = "labCommon";
            this.labCommon.Size = new System.Drawing.Size(60, 14);
            this.labCommon.TabIndex = 22;
            this.labCommon.Text = "通用查询：";
            // 
            // labBussinessBaseNo
            // 
            this.labBussinessBaseNo.Location = new System.Drawing.Point(326, 17);
            this.labBussinessBaseNo.Name = "labBussinessBaseNo";
            this.labBussinessBaseNo.Size = new System.Drawing.Size(48, 14);
            this.labBussinessBaseNo.TabIndex = 18;
            this.labBussinessBaseNo.Text = "往来方：";
            // 
            // lab1
            // 
            this.lab1.Location = new System.Drawing.Point(192, 17);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(4, 14);
            this.lab1.TabIndex = 6;
            this.lab1.Text = "-";
            // 
            // labRecordDate
            // 
            this.labRecordDate.Location = new System.Drawing.Point(20, 17);
            this.labRecordDate.Name = "labRecordDate";
            this.labRecordDate.Size = new System.Drawing.Size(60, 14);
            this.labRecordDate.TabIndex = 5;
            this.labRecordDate.Text = "登记日期：";
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.Controls.Add(this.gridControlSalesOrder);
            this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMiddle.Location = new System.Drawing.Point(0, 78);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(1905, 419);
            this.pnlMiddle.TabIndex = 9;
            // 
            // gridControlSalesOrder
            // 
            this.gridControlSalesOrder.DataSource = this.bindingSource_SalesOrder;
            this.gridControlSalesOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSalesOrder.Location = new System.Drawing.Point(2, 2);
            this.gridControlSalesOrder.MainView = this.gridViewSalesOrder;
            this.gridControlSalesOrder.Name = "gridControlSalesOrder";
            this.gridControlSalesOrder.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repSearchBussinessBaseNo,
            this.repCheckSelect,
            this.repLookUpCollectionTypeNo,
            this.repCheckIsEnd});
            this.gridControlSalesOrder.Size = new System.Drawing.Size(1901, 415);
            this.gridControlSalesOrder.TabIndex = 4;
            this.gridControlSalesOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSalesOrder});
            // 
            // gridViewSalesOrder
            // 
            this.gridViewSalesOrder.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId,
            this.colAutoSalesOrderNo,
            this.colSalesOrderDate,
            this.colAutoQuotationNo,
            this.colBussinessBaseNo,
            this.colProjectName,
            this.colQuotationVersions,
            this.colAmount,
            this.colTax,
            this.colTaxAmount,
            this.colSumAmount,
            this.colCollectionTypeNo,
            this.colCustomerPoNo,
            this.colProjectLeader,
            this.colIsEnd,
            this.colRemark,
            this.colPrepared,
            this.colModifier,
            this.colModifierTime,
            this.colParentAutoSalesOrderNo,
            this.colParentProjectNo});
            this.gridViewSalesOrder.GridControl = this.gridControlSalesOrder;
            this.gridViewSalesOrder.IndicatorWidth = 40;
            this.gridViewSalesOrder.Name = "gridViewSalesOrder";
            this.gridViewSalesOrder.OptionsBehavior.Editable = false;
            this.gridViewSalesOrder.OptionsBehavior.ReadOnly = true;
            this.gridViewSalesOrder.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewSalesOrder.OptionsView.ColumnAutoWidth = false;
            this.gridViewSalesOrder.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewSalesOrder.OptionsView.ShowFooter = true;
            this.gridViewSalesOrder.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewSalesOrder_RowClick);
            this.gridViewSalesOrder.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewSalesOrder_CustomDrawRowIndicator);
            // 
            // colAutoId
            // 
            this.colAutoId.FieldName = "AutoId";
            this.colAutoId.Name = "colAutoId";
            // 
            // colAutoSalesOrderNo
            // 
            this.colAutoSalesOrderNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colAutoSalesOrderNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAutoSalesOrderNo.FieldName = "AutoSalesOrderNo";
            this.colAutoSalesOrderNo.Name = "colAutoSalesOrderNo";
            this.colAutoSalesOrderNo.OptionsColumn.AllowEdit = false;
            this.colAutoSalesOrderNo.OptionsColumn.AllowFocus = false;
            this.colAutoSalesOrderNo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "WarehouseWarrant", "共计{0}条")});
            this.colAutoSalesOrderNo.Visible = true;
            this.colAutoSalesOrderNo.VisibleIndex = 0;
            this.colAutoSalesOrderNo.Width = 120;
            // 
            // colSalesOrderDate
            // 
            this.colSalesOrderDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colSalesOrderDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSalesOrderDate.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.colSalesOrderDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colSalesOrderDate.FieldName = "SalesOrderDate";
            this.colSalesOrderDate.Name = "colSalesOrderDate";
            this.colSalesOrderDate.OptionsColumn.AllowEdit = false;
            this.colSalesOrderDate.OptionsColumn.AllowFocus = false;
            this.colSalesOrderDate.Visible = true;
            this.colSalesOrderDate.VisibleIndex = 1;
            this.colSalesOrderDate.Width = 130;
            // 
            // colAutoQuotationNo
            // 
            this.colAutoQuotationNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colAutoQuotationNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAutoQuotationNo.FieldName = "AutoQuotationNo";
            this.colAutoQuotationNo.Name = "colAutoQuotationNo";
            this.colAutoQuotationNo.Visible = true;
            this.colAutoQuotationNo.VisibleIndex = 2;
            this.colAutoQuotationNo.Width = 120;
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
            this.colBussinessBaseNo.VisibleIndex = 3;
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
            // colProjectName
            // 
            this.colProjectName.AppearanceHeader.Options.UseTextOptions = true;
            this.colProjectName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProjectName.FieldName = "ProjectName";
            this.colProjectName.Name = "colProjectName";
            this.colProjectName.OptionsColumn.AllowEdit = false;
            this.colProjectName.Visible = true;
            this.colProjectName.VisibleIndex = 4;
            this.colProjectName.Width = 100;
            // 
            // colQuotationVersions
            // 
            this.colQuotationVersions.AppearanceHeader.Options.UseTextOptions = true;
            this.colQuotationVersions.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQuotationVersions.FieldName = "QuotationVersions";
            this.colQuotationVersions.Name = "colQuotationVersions";
            this.colQuotationVersions.Visible = true;
            this.colQuotationVersions.VisibleIndex = 5;
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
            this.colAmount.VisibleIndex = 6;
            this.colAmount.Width = 80;
            // 
            // colTax
            // 
            this.colTax.AppearanceHeader.Options.UseTextOptions = true;
            this.colTax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTax.DisplayFormat.FormatString = "p0";
            this.colTax.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTax.FieldName = "Tax";
            this.colTax.Name = "colTax";
            this.colTax.OptionsColumn.AllowEdit = false;
            this.colTax.OptionsColumn.AllowFocus = false;
            this.colTax.Visible = true;
            this.colTax.VisibleIndex = 7;
            this.colTax.Width = 80;
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
            this.colTaxAmount.OptionsColumn.AllowFocus = false;
            this.colTaxAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TaxAmount", "{0:N2}")});
            this.colTaxAmount.Visible = true;
            this.colTaxAmount.VisibleIndex = 8;
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
            this.colSumAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SumAmount", "{0:N2}")});
            this.colSumAmount.Visible = true;
            this.colSumAmount.VisibleIndex = 9;
            this.colSumAmount.Width = 90;
            // 
            // colCollectionTypeNo
            // 
            this.colCollectionTypeNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colCollectionTypeNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCollectionTypeNo.ColumnEdit = this.repLookUpCollectionTypeNo;
            this.colCollectionTypeNo.FieldName = "CollectionTypeNo";
            this.colCollectionTypeNo.Name = "colCollectionTypeNo";
            this.colCollectionTypeNo.Visible = true;
            this.colCollectionTypeNo.VisibleIndex = 10;
            this.colCollectionTypeNo.Width = 90;
            // 
            // repLookUpCollectionTypeNo
            // 
            this.repLookUpCollectionTypeNo.AutoHeight = false;
            this.repLookUpCollectionTypeNo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpCollectionTypeNo.DisplayMember = "CollectionTypeNoText";
            this.repLookUpCollectionTypeNo.Name = "repLookUpCollectionTypeNo";
            this.repLookUpCollectionTypeNo.NullText = "";
            this.repLookUpCollectionTypeNo.ValueMember = "CollectionTypeNo";
            // 
            // colCustomerPoNo
            // 
            this.colCustomerPoNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colCustomerPoNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomerPoNo.FieldName = "CustomerPoNo";
            this.colCustomerPoNo.Name = "colCustomerPoNo";
            this.colCustomerPoNo.Visible = true;
            this.colCustomerPoNo.VisibleIndex = 11;
            this.colCustomerPoNo.Width = 120;
            // 
            // colProjectLeader
            // 
            this.colProjectLeader.AppearanceHeader.Options.UseTextOptions = true;
            this.colProjectLeader.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProjectLeader.FieldName = "ProjectLeader";
            this.colProjectLeader.Name = "colProjectLeader";
            this.colProjectLeader.Visible = true;
            this.colProjectLeader.VisibleIndex = 12;
            this.colProjectLeader.Width = 80;
            // 
            // colIsEnd
            // 
            this.colIsEnd.AppearanceHeader.Options.UseTextOptions = true;
            this.colIsEnd.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIsEnd.ColumnEdit = this.repCheckIsEnd;
            this.colIsEnd.FieldName = "IsEnd";
            this.colIsEnd.Name = "colIsEnd";
            this.colIsEnd.Visible = true;
            this.colIsEnd.VisibleIndex = 13;
            // 
            // repCheckIsEnd
            // 
            this.repCheckIsEnd.AutoHeight = false;
            this.repCheckIsEnd.Name = "repCheckIsEnd";
            this.repCheckIsEnd.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repCheckIsEnd.ValueChecked = 1;
            this.repCheckIsEnd.ValueGrayed = 0;
            this.repCheckIsEnd.ValueUnchecked = 0;
            // 
            // colRemark
            // 
            this.colRemark.AppearanceHeader.Options.UseTextOptions = true;
            this.colRemark.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 14;
            this.colRemark.Width = 120;
            // 
            // colPrepared
            // 
            this.colPrepared.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrepared.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrepared.FieldName = "Prepared";
            this.colPrepared.Name = "colPrepared";
            this.colPrepared.Visible = true;
            this.colPrepared.VisibleIndex = 15;
            this.colPrepared.Width = 80;
            // 
            // colModifier
            // 
            this.colModifier.AppearanceHeader.Options.UseTextOptions = true;
            this.colModifier.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colModifier.FieldName = "Modifier";
            this.colModifier.Name = "colModifier";
            this.colModifier.Visible = true;
            this.colModifier.VisibleIndex = 16;
            this.colModifier.Width = 80;
            // 
            // colModifierTime
            // 
            this.colModifierTime.AppearanceHeader.Options.UseTextOptions = true;
            this.colModifierTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colModifierTime.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.colModifierTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colModifierTime.FieldName = "ModifierTime";
            this.colModifierTime.Name = "colModifierTime";
            this.colModifierTime.Visible = true;
            this.colModifierTime.VisibleIndex = 17;
            this.colModifierTime.Width = 130;
            // 
            // colParentAutoSalesOrderNo
            // 
            this.colParentAutoSalesOrderNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colParentAutoSalesOrderNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colParentAutoSalesOrderNo.FieldName = "ParentAutoSalesOrderNo";
            this.colParentAutoSalesOrderNo.Name = "colParentAutoSalesOrderNo";
            this.colParentAutoSalesOrderNo.Visible = true;
            this.colParentAutoSalesOrderNo.VisibleIndex = 18;
            this.colParentAutoSalesOrderNo.Width = 120;
            // 
            // colParentProjectNo
            // 
            this.colParentProjectNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colParentProjectNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colParentProjectNo.FieldName = "ParentProjectNo";
            this.colParentProjectNo.Name = "colParentProjectNo";
            this.colParentProjectNo.Visible = true;
            this.colParentProjectNo.VisibleIndex = 19;
            this.colParentProjectNo.Width = 120;
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
            this.pnlBottom.Location = new System.Drawing.Point(0, 497);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1905, 58);
            this.pnlBottom.TabIndex = 10;
            // 
            // gridBottomOrderHead
            // 
            this.gridBottomOrderHead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBottomOrderHead.Location = new System.Drawing.Point(2, 2);
            this.gridBottomOrderHead.MasterDataSet = this.dataSet_SalesOrder;
            this.gridBottomOrderHead.Name = "gridBottomOrderHead";
            this.gridBottomOrderHead.pageRowCount = 5;
            this.gridBottomOrderHead.Size = new System.Drawing.Size(1901, 54);
            this.gridBottomOrderHead.TabIndex = 0;
            // 
            // FrmSalesOrderQuery
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1905, 555);
            this.Controls.Add(this.pnlMiddle);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnltop);
            this.Name = "FrmSalesOrderQuery";
            this.TabText = "销售订单查询";
            this.Text = "销售订单查询";
            this.Load += new System.EventHandler(this.FrmSalesOrderQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_SalesOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_SalesOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableSalesOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnltop)).EndInit();
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPrepared.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchProjectNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchAdjustmentsProjectNoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCommon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpBussinessBaseNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpBussinessBaseNoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSalesOrderDateEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSalesOrderDateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSalesOrderDateBegin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSalesOrderDateBegin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddle)).EndInit();
            this.pnlMiddle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSalesOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSalesOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchBussinessBaseNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpCollectionTypeNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckIsEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource_SalesOrder;
        private System.Data.DataSet dataSet_SalesOrder;
        private System.Data.DataTable TableSalesOrder;
        private System.Data.DataColumn dataColAutoId;
        private System.Data.DataColumn dataColAutoSalesOrderNo;
        private System.Data.DataColumn dataColSalesOrderDate;
        private System.Data.DataColumn dataColProjectNo;
        private System.Data.DataColumn dataColProjectName;
        private System.Data.DataColumn dataColBussinessBaseNo;
        private System.Data.DataColumn dataColAutoQuotationNo;
        private System.Data.DataColumn dataColQuotationVersions;
        private System.Data.DataColumn dataColCustomerPoNo;
        private System.Data.DataColumn dataColCollectionTypeNo;
        private System.Data.DataColumn dataColAmount;
        private System.Data.DataColumn dataColTax;
        private System.Data.DataColumn dataColTaxAmount;
        private System.Data.DataColumn dataColSumAmount;
        private System.Data.DataColumn dataColProjectLeader;
        private System.Data.DataColumn dataColIsEnd;
        private System.Data.DataColumn dataColPrepared;
        private System.Data.DataColumn dataColPreparedIp;
        private System.Data.DataColumn dataColModifier;
        private System.Data.DataColumn dataColModifierIp;
        private System.Data.DataColumn dataColModifierTime;
        private System.Data.DataColumn dataColRemark;
        private System.Data.DataColumn dataColParentAutoSalesOrderNo;
        private System.Data.DataColumn dataColParentProjectNo;
        private System.Data.DataColumn dataColSalesOrderState;
        private DevExpress.XtraEditors.PanelControl pnltop;
        private DevExpress.XtraEditors.SimpleButton btnSaveExcel;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.TextEdit textCommon;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpBussinessBaseNo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpBussinessBaseNoView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBussinessBaseNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBussinessBaseText;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBussinessCategoryText;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnAutoId;
        private DevExpress.XtraEditors.DateEdit dateSalesOrderDateEnd;
        private DevExpress.XtraEditors.DateEdit dateSalesOrderDateBegin;
        private DevExpress.XtraEditors.LabelControl labCommon;
        private DevExpress.XtraEditors.LabelControl labBussinessBaseNo;
        private DevExpress.XtraEditors.LabelControl lab1;
        private DevExpress.XtraEditors.LabelControl labRecordDate;
        private DevExpress.XtraEditors.SearchLookUpEdit searchProjectNo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchAdjustmentsProjectNoView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColProjectNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColProjectName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColRemark;
        private DevExpress.XtraEditors.LabelControl labProjectNo;
        private DevExpress.XtraEditors.PanelControl pnlMiddle;
        private DevExpress.XtraGrid.GridControl gridControlSalesOrder;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSalesOrder;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoSalesOrderNo;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn colBussinessBaseNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repSearchBussinessBaseNo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridCBussinessBaseNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridCBussinessBaseText;
        private DevExpress.XtraGrid.Columns.GridColumn gridCBussinessCategoryText;
        private DevExpress.XtraGrid.Columns.GridColumn gridCAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectName;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colTax;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colPrepared;
        private DevExpress.XtraGrid.Columns.GridColumn colModifier;
        private DevExpress.XtraGrid.Columns.GridColumn colModifierTime;
        private DevExpress.XtraGrid.Columns.GridColumn colParentAutoSalesOrderNo;
        private DevExpress.XtraGrid.Columns.GridColumn colParentProjectNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheckSelect;
        private DevExpress.XtraEditors.PanelControl pnlBottom;
        private GridBottom gridBottomOrderHead;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoQuotationNo;
        private DevExpress.XtraGrid.Columns.GridColumn colQuotationVersions;
        private DevExpress.XtraGrid.Columns.GridColumn colSumAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colCollectionTypeNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpCollectionTypeNo;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerPoNo;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectLeader;
        private DevExpress.XtraGrid.Columns.GridColumn colIsEnd;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheckIsEnd;
        private DevExpress.XtraEditors.LookUpEdit lookUpPrepared;
        private DevExpress.XtraEditors.LabelControl labPrepared;
    }
}