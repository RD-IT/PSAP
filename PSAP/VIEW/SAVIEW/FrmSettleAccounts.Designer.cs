namespace PSAP.VIEW.BSVIEW
{
    partial class FrmSettleAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettleAccounts));
            this.dataSet_SettleAccounts = new System.Data.DataSet();
            this.TableSettleAccountsHead = new System.Data.DataTable();
            this.dataColAutoId = new System.Data.DataColumn();
            this.dataColSettleAccountNo = new System.Data.DataColumn();
            this.dataColSettleAccountDate = new System.Data.DataColumn();
            this.dataColReqDep = new System.Data.DataColumn();
            this.dataColBussinessBaseNo = new System.Data.DataColumn();
            this.dataColIsVoucher = new System.Data.DataColumn();
            this.dataColPrepared = new System.Data.DataColumn();
            this.dataColPreparedIp = new System.Data.DataColumn();
            this.dataColModifier = new System.Data.DataColumn();
            this.dataColModifierIp = new System.Data.DataColumn();
            this.dataColModifierTime = new System.Data.DataColumn();
            this.dataColRemark = new System.Data.DataColumn();
            this.dataColSettleAccountsState = new System.Data.DataColumn();
            this.dataColSelect = new System.Data.DataColumn();
            this.TableSettleAccountsList = new System.Data.DataTable();
            this.dataColuAutoId = new System.Data.DataColumn();
            this.dataColuSettleAccountNo = new System.Data.DataColumn();
            this.dataColuAutoSalesOrderNo = new System.Data.DataColumn();
            this.dataColuAmount = new System.Data.DataColumn();
            this.dataColuRemark = new System.Data.DataColumn();
            this.dataColuTax = new System.Data.DataColumn();
            this.dataColuTaxAmount = new System.Data.DataColumn();
            this.dataColuSumAmount = new System.Data.DataColumn();
            this.bindingSource_SAHead = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource_SAList = new System.Windows.Forms.BindingSource(this.components);
            this.pnlRight = new DevExpress.XtraEditors.PanelControl();
            this.pnlGrid = new DevExpress.XtraEditors.PanelControl();
            this.gridCtlSettleAccountsList = new DevExpress.XtraGrid.GridControl();
            this.gridViewSettleAccountsList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSettleAccountNo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAutoSalesOrderNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSpinAmount = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colTax1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSpinTax1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colTaxAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSumAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colListRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repbtnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.pnlMiddle = new DevExpress.XtraEditors.PanelControl();
            this.checkAll = new DevExpress.XtraEditors.CheckEdit();
            this.gridCtlSettleAccountsHead = new DevExpress.XtraGrid.GridControl();
            this.gridViewSettleAccountsHead = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWarehouseState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelect = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCheckSelect = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colSettleAccountNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSettlementDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReqDep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpReqDep = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colBussinessBaseNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSearchBussinessBaseNo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repSearchBussinessBaseNoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridCBussinessBaseNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCBussinessBaseText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCBussinessCategoryText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsVoucher = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCheckIsVoucher = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrepared = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlMiddleTop = new DevExpress.XtraEditors.PanelControl();
            this.btnPreview = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.pnltop = new DevExpress.XtraEditors.PanelControl();
            this.lookUpReqDep = new DevExpress.XtraEditors.LookUpEdit();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.textCommon = new DevExpress.XtraEditors.TextEdit();
            this.lookUpPrepared = new DevExpress.XtraEditors.LookUpEdit();
            this.searchLookUpBussinessBaseNo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpBussinessBaseNoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnBussinessBaseNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBussinessBaseText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBussinessCategoryText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateSADateEnd = new DevExpress.XtraEditors.DateEdit();
            this.lab1 = new DevExpress.XtraEditors.LabelControl();
            this.dateSADateBegin = new DevExpress.XtraEditors.DateEdit();
            this.labReqDep = new DevExpress.XtraEditors.LabelControl();
            this.labCommon = new DevExpress.XtraEditors.LabelControl();
            this.labPrepared = new DevExpress.XtraEditors.LabelControl();
            this.labBussinessBaseNo = new DevExpress.XtraEditors.LabelControl();
            this.labSADate = new DevExpress.XtraEditors.LabelControl();
            this.dockManagerLeft = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPnlLeft = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.pnlLeftGrid = new DevExpress.XtraEditors.PanelControl();
            this.gridControlSalesOrder = new DevExpress.XtraGrid.GridControl();
            this.bindingSource_SalesOrder = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_SalesOrder = new System.Data.DataSet();
            this.TableSalesOrder = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColAutoSalesOrderNo = new System.Data.DataColumn();
            this.dataColSalesOrderDate = new System.Data.DataColumn();
            this.dataColProjectNo = new System.Data.DataColumn();
            this.dataColProjectName = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
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
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColParentAutoSalesOrderNo = new System.Data.DataColumn();
            this.dataColParentProjectNo = new System.Data.DataColumn();
            this.dataColSalesOrderState = new System.Data.DataColumn();
            this.dataColSettleAmount = new System.Data.DataColumn();
            this.dataColNoSettleAmount = new System.Data.DataColumn();
            this.gridViewSalesOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAutoQuotationNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSearchLookUpBussinessBaseNo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repSearchLookUpBussinessBaseNoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuotationVersions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSettleAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCollectionTypeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpCollectionTypeNo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colCustomerPoNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjectLeader = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsEnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCheckIsEnd = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifierTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParentAutoSalesOrderNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParentProjectNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.pnlLeftTop = new DevExpress.XtraEditors.PanelControl();
            this.searchBussinessBaseNo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchBussinessBaseNoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelBussinessBaseNo = new DevExpress.XtraEditors.LabelControl();
            this.btnPrReqQuery = new DevExpress.XtraEditors.SimpleButton();
            this.dateSODateEnd = new DevExpress.XtraEditors.DateEdit();
            this.dateSODateBegin = new DevExpress.XtraEditors.DateEdit();
            this.textAutoSalesOrderNo = new DevExpress.XtraEditors.TextEdit();
            this.lab = new DevExpress.XtraEditors.LabelControl();
            this.labSalesOrderDate = new DevExpress.XtraEditors.LabelControl();
            this.labAutoSalesOrderNo = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_SettleAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableSettleAccountsHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableSettleAccountsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_SAHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_SAList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).BeginInit();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtlSettleAccountsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSettleAccountsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinTax1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repbtnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddle)).BeginInit();
            this.pnlMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtlSettleAccountsHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSettleAccountsHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpReqDep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchBussinessBaseNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchBussinessBaseNoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckIsVoucher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddleTop)).BeginInit();
            this.pnlMiddleTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnltop)).BeginInit();
            this.pnltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpReqDep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCommon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPrepared.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpBussinessBaseNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpBussinessBaseNoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSADateEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSADateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSADateBegin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSADateBegin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManagerLeft)).BeginInit();
            this.dockPnlLeft.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeftGrid)).BeginInit();
            this.pnlLeftGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSalesOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_SalesOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_SalesOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableSalesOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSalesOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchLookUpBussinessBaseNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchLookUpBussinessBaseNoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpCollectionTypeNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckIsEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeftTop)).BeginInit();
            this.pnlLeftTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchBussinessBaseNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBussinessBaseNoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSODateEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSODateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSODateBegin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSODateBegin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAutoSalesOrderNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet_SettleAccounts
            // 
            this.dataSet_SettleAccounts.DataSetName = "NewDataSet";
            this.dataSet_SettleAccounts.Tables.AddRange(new System.Data.DataTable[] {
            this.TableSettleAccountsHead,
            this.TableSettleAccountsList});
            // 
            // TableSettleAccountsHead
            // 
            this.TableSettleAccountsHead.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColAutoId,
            this.dataColSettleAccountNo,
            this.dataColSettleAccountDate,
            this.dataColReqDep,
            this.dataColBussinessBaseNo,
            this.dataColIsVoucher,
            this.dataColPrepared,
            this.dataColPreparedIp,
            this.dataColModifier,
            this.dataColModifierIp,
            this.dataColModifierTime,
            this.dataColRemark,
            this.dataColSettleAccountsState,
            this.dataColSelect});
            this.TableSettleAccountsHead.TableName = "SettleAccountsHead";
            // 
            // dataColAutoId
            // 
            this.dataColAutoId.ColumnName = "AutoId";
            this.dataColAutoId.DataType = typeof(int);
            // 
            // dataColSettleAccountNo
            // 
            this.dataColSettleAccountNo.Caption = "结账单号";
            this.dataColSettleAccountNo.ColumnName = "SettleAccountNo";
            // 
            // dataColSettleAccountDate
            // 
            this.dataColSettleAccountDate.Caption = "结账日期";
            this.dataColSettleAccountDate.ColumnName = "SettleAccountDate";
            this.dataColSettleAccountDate.DataType = typeof(System.DateTime);
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
            // dataColIsVoucher
            // 
            this.dataColIsVoucher.Caption = "生成凭证";
            this.dataColIsVoucher.ColumnName = "IsVoucher";
            this.dataColIsVoucher.DataType = typeof(bool);
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
            // dataColSettleAccountsState
            // 
            this.dataColSettleAccountsState.Caption = "单据状态";
            this.dataColSettleAccountsState.ColumnName = "SettleAccountsState";
            this.dataColSettleAccountsState.DataType = typeof(int);
            // 
            // dataColSelect
            // 
            this.dataColSelect.Caption = " ";
            this.dataColSelect.ColumnName = "Select";
            this.dataColSelect.DataType = typeof(bool);
            // 
            // TableSettleAccountsList
            // 
            this.TableSettleAccountsList.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColuAutoId,
            this.dataColuSettleAccountNo,
            this.dataColuAutoSalesOrderNo,
            this.dataColuAmount,
            this.dataColuRemark,
            this.dataColuTax,
            this.dataColuTaxAmount,
            this.dataColuSumAmount});
            this.TableSettleAccountsList.TableName = "SettleAccountsList";
            // 
            // dataColuAutoId
            // 
            this.dataColuAutoId.ColumnName = "AutoId";
            this.dataColuAutoId.DataType = typeof(int);
            // 
            // dataColuSettleAccountNo
            // 
            this.dataColuSettleAccountNo.Caption = "结账单号";
            this.dataColuSettleAccountNo.ColumnName = "SettleAccountNo";
            // 
            // dataColuAutoSalesOrderNo
            // 
            this.dataColuAutoSalesOrderNo.Caption = "销售订单号";
            this.dataColuAutoSalesOrderNo.ColumnName = "AutoSalesOrderNo";
            // 
            // dataColuAmount
            // 
            this.dataColuAmount.Caption = "金额";
            this.dataColuAmount.ColumnName = "Amount";
            this.dataColuAmount.DataType = typeof(decimal);
            // 
            // dataColuRemark
            // 
            this.dataColuRemark.Caption = "备注";
            this.dataColuRemark.ColumnName = "Remark";
            // 
            // dataColuTax
            // 
            this.dataColuTax.Caption = "税率";
            this.dataColuTax.ColumnName = "Tax";
            this.dataColuTax.DataType = typeof(double);
            // 
            // dataColuTaxAmount
            // 
            this.dataColuTaxAmount.Caption = "税额";
            this.dataColuTaxAmount.ColumnName = "TaxAmount";
            this.dataColuTaxAmount.DataType = typeof(decimal);
            // 
            // dataColuSumAmount
            // 
            this.dataColuSumAmount.Caption = "价税合计";
            this.dataColuSumAmount.ColumnName = "SumAmount";
            this.dataColuSumAmount.DataType = typeof(decimal);
            // 
            // bindingSource_SAHead
            // 
            this.bindingSource_SAHead.DataMember = "SettleAccountsHead";
            this.bindingSource_SAHead.DataSource = this.dataSet_SettleAccounts;
            // 
            // bindingSource_SAList
            // 
            this.bindingSource_SAList.DataMember = "SettleAccountsList";
            this.bindingSource_SAList.DataSource = this.dataSet_SettleAccounts;
            // 
            // pnlRight
            // 
            this.pnlRight.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlRight.Controls.Add(this.pnlGrid);
            this.pnlRight.Controls.Add(this.splitterControl1);
            this.pnlRight.Controls.Add(this.pnlMiddle);
            this.pnlRight.Controls.Add(this.pnltop);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(350, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(1045, 643);
            this.pnlRight.TabIndex = 0;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.gridCtlSettleAccountsList);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 359);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1045, 284);
            this.pnlGrid.TabIndex = 10;
            // 
            // gridCtlSettleAccountsList
            // 
            this.gridCtlSettleAccountsList.AllowDrop = true;
            this.gridCtlSettleAccountsList.DataSource = this.bindingSource_SAList;
            this.gridCtlSettleAccountsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtlSettleAccountsList.Location = new System.Drawing.Point(2, 2);
            this.gridCtlSettleAccountsList.MainView = this.gridViewSettleAccountsList;
            this.gridCtlSettleAccountsList.Name = "gridCtlSettleAccountsList";
            this.gridCtlSettleAccountsList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repbtnDelete,
            this.repSpinTax1,
            this.repSpinAmount});
            this.gridCtlSettleAccountsList.Size = new System.Drawing.Size(1041, 280);
            this.gridCtlSettleAccountsList.TabIndex = 4;
            this.gridCtlSettleAccountsList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSettleAccountsList});
            this.gridCtlSettleAccountsList.DragDrop += new System.Windows.Forms.DragEventHandler(this.gridCtlSettleAccountsList_DragDrop);
            this.gridCtlSettleAccountsList.DragEnter += new System.Windows.Forms.DragEventHandler(this.gridCtlSettleAccountsList_DragEnter);
            this.gridCtlSettleAccountsList.DragOver += new System.Windows.Forms.DragEventHandler(this.gridCtlSettleAccountsList_DragOver);
            // 
            // gridViewSettleAccountsList
            // 
            this.gridViewSettleAccountsList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId1,
            this.colSettleAccountNo1,
            this.colAutoSalesOrderNo,
            this.colAmount,
            this.colTax1,
            this.colTaxAmount,
            this.colSumAmount,
            this.colListRemark,
            this.colDelete});
            this.gridViewSettleAccountsList.GridControl = this.gridCtlSettleAccountsList;
            this.gridViewSettleAccountsList.IndicatorWidth = 40;
            this.gridViewSettleAccountsList.Name = "gridViewSettleAccountsList";
            this.gridViewSettleAccountsList.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewSettleAccountsList.OptionsMenu.EnableColumnMenu = false;
            this.gridViewSettleAccountsList.OptionsMenu.EnableFooterMenu = false;
            this.gridViewSettleAccountsList.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewSettleAccountsList.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewSettleAccountsList.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewSettleAccountsList.OptionsView.ColumnAutoWidth = false;
            this.gridViewSettleAccountsList.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewSettleAccountsList.OptionsView.ShowFooter = true;
            this.gridViewSettleAccountsList.OptionsView.ShowGroupPanel = false;
            this.gridViewSettleAccountsList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewSettleAccountsHead_CustomDrawRowIndicator);
            this.gridViewSettleAccountsList.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewSettleAccountsList_CellValueChanged);
            // 
            // colAutoId1
            // 
            this.colAutoId1.FieldName = "AutoId";
            this.colAutoId1.Name = "colAutoId1";
            // 
            // colSettleAccountNo1
            // 
            this.colSettleAccountNo1.AppearanceHeader.Options.UseTextOptions = true;
            this.colSettleAccountNo1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSettleAccountNo1.FieldName = "SettleAccountNo";
            this.colSettleAccountNo1.Name = "colSettleAccountNo1";
            this.colSettleAccountNo1.OptionsColumn.AllowEdit = false;
            this.colSettleAccountNo1.OptionsColumn.AllowFocus = false;
            this.colSettleAccountNo1.OptionsColumn.ReadOnly = true;
            this.colSettleAccountNo1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "PrReqNo", "共计{0}条")});
            this.colSettleAccountNo1.Visible = true;
            this.colSettleAccountNo1.VisibleIndex = 0;
            this.colSettleAccountNo1.Width = 110;
            // 
            // colAutoSalesOrderNo
            // 
            this.colAutoSalesOrderNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colAutoSalesOrderNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAutoSalesOrderNo.FieldName = "AutoSalesOrderNo";
            this.colAutoSalesOrderNo.Name = "colAutoSalesOrderNo";
            this.colAutoSalesOrderNo.OptionsColumn.AllowEdit = false;
            this.colAutoSalesOrderNo.OptionsColumn.AllowFocus = false;
            this.colAutoSalesOrderNo.Visible = true;
            this.colAutoSalesOrderNo.VisibleIndex = 1;
            this.colAutoSalesOrderNo.Width = 110;
            // 
            // colAmount
            // 
            this.colAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAmount.ColumnEdit = this.repSpinAmount;
            this.colAmount.DisplayFormat.FormatString = "N2";
            this.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.OptionsColumn.AllowEdit = false;
            this.colAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "{0:N2}")});
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 2;
            this.colAmount.Width = 100;
            // 
            // repSpinAmount
            // 
            this.repSpinAmount.AutoHeight = false;
            this.repSpinAmount.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repSpinAmount.DisplayFormat.FormatString = "N2";
            this.repSpinAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repSpinAmount.EditFormat.FormatString = "N2";
            this.repSpinAmount.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repSpinAmount.Mask.EditMask = "N2";
            this.repSpinAmount.Name = "repSpinAmount";
            // 
            // colTax1
            // 
            this.colTax1.AppearanceHeader.Options.UseTextOptions = true;
            this.colTax1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTax1.ColumnEdit = this.repSpinTax1;
            this.colTax1.DisplayFormat.FormatString = "p0";
            this.colTax1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTax1.FieldName = "Tax";
            this.colTax1.Name = "colTax1";
            this.colTax1.OptionsColumn.AllowEdit = false;
            this.colTax1.Visible = true;
            this.colTax1.VisibleIndex = 3;
            this.colTax1.Width = 80;
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
            this.colTaxAmount.OptionsColumn.AllowFocus = false;
            this.colTaxAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TaxAmount", "{0:N2}")});
            this.colTaxAmount.Visible = true;
            this.colTaxAmount.VisibleIndex = 4;
            this.colTaxAmount.Width = 100;
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
            this.colSumAmount.OptionsColumn.AllowFocus = false;
            this.colSumAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SumAmount", "{0:N2}")});
            this.colSumAmount.Visible = true;
            this.colSumAmount.VisibleIndex = 5;
            this.colSumAmount.Width = 100;
            // 
            // colListRemark
            // 
            this.colListRemark.AppearanceHeader.Options.UseTextOptions = true;
            this.colListRemark.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colListRemark.FieldName = "Remark";
            this.colListRemark.Name = "colListRemark";
            this.colListRemark.OptionsColumn.AllowEdit = false;
            this.colListRemark.Visible = true;
            this.colListRemark.VisibleIndex = 6;
            this.colListRemark.Width = 140;
            // 
            // colDelete
            // 
            this.colDelete.ColumnEdit = this.repbtnDelete;
            this.colDelete.Name = "colDelete";
            this.colDelete.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 7;
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
            // splitterControl1
            // 
            this.splitterControl1.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterControl1.Location = new System.Drawing.Point(0, 354);
            this.splitterControl1.Margin = new System.Windows.Forms.Padding(4);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(1045, 5);
            this.splitterControl1.TabIndex = 9;
            this.splitterControl1.TabStop = false;
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.Controls.Add(this.checkAll);
            this.pnlMiddle.Controls.Add(this.gridCtlSettleAccountsHead);
            this.pnlMiddle.Controls.Add(this.pnlMiddleTop);
            this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMiddle.Location = new System.Drawing.Point(0, 78);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(1045, 276);
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
            this.checkAll.TabIndex = 20;
            this.checkAll.TabStop = false;
            this.checkAll.CheckedChanged += new System.EventHandler(this.checkAll_CheckedChanged);
            // 
            // gridCtlSettleAccountsHead
            // 
            this.gridCtlSettleAccountsHead.DataSource = this.bindingSource_SAHead;
            this.gridCtlSettleAccountsHead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtlSettleAccountsHead.Location = new System.Drawing.Point(2, 36);
            this.gridCtlSettleAccountsHead.MainView = this.gridViewSettleAccountsHead;
            this.gridCtlSettleAccountsHead.Name = "gridCtlSettleAccountsHead";
            this.gridCtlSettleAccountsHead.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repLookUpReqDep,
            this.repSearchBussinessBaseNo,
            this.repCheckSelect,
            this.repCheckIsVoucher});
            this.gridCtlSettleAccountsHead.Size = new System.Drawing.Size(1041, 238);
            this.gridCtlSettleAccountsHead.TabIndex = 5;
            this.gridCtlSettleAccountsHead.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSettleAccountsHead});
            // 
            // gridViewSettleAccountsHead
            // 
            this.gridViewSettleAccountsHead.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId,
            this.colWarehouseState,
            this.colSelect,
            this.colSettleAccountNo,
            this.colSettlementDate,
            this.colReqDep,
            this.colBussinessBaseNo,
            this.colIsVoucher,
            this.colRemark,
            this.colPrepared,
            this.colModifier});
            this.gridViewSettleAccountsHead.GridControl = this.gridCtlSettleAccountsHead;
            this.gridViewSettleAccountsHead.IndicatorWidth = 40;
            this.gridViewSettleAccountsHead.Name = "gridViewSettleAccountsHead";
            this.gridViewSettleAccountsHead.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewSettleAccountsHead.OptionsMenu.EnableColumnMenu = false;
            this.gridViewSettleAccountsHead.OptionsMenu.EnableFooterMenu = false;
            this.gridViewSettleAccountsHead.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewSettleAccountsHead.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewSettleAccountsHead.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewSettleAccountsHead.OptionsView.ColumnAutoWidth = false;
            this.gridViewSettleAccountsHead.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewSettleAccountsHead.OptionsView.ShowFooter = true;
            this.gridViewSettleAccountsHead.OptionsView.ShowGroupPanel = false;
            this.gridViewSettleAccountsHead.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewSettleAccountsHead_CustomDrawRowIndicator);
            this.gridViewSettleAccountsHead.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridViewSettleAccountsHead_InitNewRow);
            this.gridViewSettleAccountsHead.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewSettleAccountsHead_FocusedRowChanged);
            // 
            // colAutoId
            // 
            this.colAutoId.FieldName = "AutoId";
            this.colAutoId.Name = "colAutoId";
            // 
            // colWarehouseState
            // 
            this.colWarehouseState.AppearanceHeader.Options.UseTextOptions = true;
            this.colWarehouseState.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWarehouseState.FieldName = "SettleAccountsState";
            this.colWarehouseState.Name = "colWarehouseState";
            this.colWarehouseState.OptionsColumn.AllowEdit = false;
            this.colWarehouseState.OptionsColumn.AllowFocus = false;
            this.colWarehouseState.Width = 60;
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
            // colSettleAccountNo
            // 
            this.colSettleAccountNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colSettleAccountNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSettleAccountNo.FieldName = "SettleAccountNo";
            this.colSettleAccountNo.Name = "colSettleAccountNo";
            this.colSettleAccountNo.OptionsColumn.AllowEdit = false;
            this.colSettleAccountNo.OptionsColumn.AllowFocus = false;
            this.colSettleAccountNo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "PrReqNo", "共计{0}条")});
            this.colSettleAccountNo.Visible = true;
            this.colSettleAccountNo.VisibleIndex = 1;
            this.colSettleAccountNo.Width = 110;
            // 
            // colSettlementDate
            // 
            this.colSettlementDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colSettlementDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSettlementDate.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.colSettlementDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colSettlementDate.FieldName = "SettleAccountDate";
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
            this.repSearchBussinessBaseNo.View = this.repSearchBussinessBaseNoView;
            // 
            // repSearchBussinessBaseNoView
            // 
            this.repSearchBussinessBaseNoView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridCBussinessBaseNo,
            this.gridCBussinessBaseText,
            this.gridCBussinessCategoryText,
            this.gridCAutoId});
            this.repSearchBussinessBaseNoView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repSearchBussinessBaseNoView.IndicatorWidth = 60;
            this.repSearchBussinessBaseNoView.Name = "repSearchBussinessBaseNoView";
            this.repSearchBussinessBaseNoView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repSearchBussinessBaseNoView.OptionsView.ShowGroupPanel = false;
            this.repSearchBussinessBaseNoView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewSettleAccountsHead_CustomDrawRowIndicator);
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
            this.colIsVoucher.VisibleIndex = 6;
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
            this.colRemark.VisibleIndex = 5;
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
            this.colPrepared.VisibleIndex = 7;
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
            this.colModifier.VisibleIndex = 8;
            // 
            // pnlMiddleTop
            // 
            this.pnlMiddleTop.Controls.Add(this.btnPreview);
            this.pnlMiddleTop.Controls.Add(this.btnDelete);
            this.pnlMiddleTop.Controls.Add(this.btnCancel);
            this.pnlMiddleTop.Controls.Add(this.btnSave);
            this.pnlMiddleTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMiddleTop.Location = new System.Drawing.Point(2, 2);
            this.pnlMiddleTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMiddleTop.Name = "pnlMiddleTop";
            this.pnlMiddleTop.Size = new System.Drawing.Size(1041, 34);
            this.pnlMiddleTop.TabIndex = 2;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(248, 5);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(4);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 25;
            this.btnPreview.TabStop = false;
            this.btnPreview.Text = "预览";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(167, 5);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(86, 5);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(5, 5);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "修改";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnltop
            // 
            this.pnltop.Controls.Add(this.lookUpReqDep);
            this.pnltop.Controls.Add(this.btnQuery);
            this.pnltop.Controls.Add(this.textCommon);
            this.pnltop.Controls.Add(this.lookUpPrepared);
            this.pnltop.Controls.Add(this.searchLookUpBussinessBaseNo);
            this.pnltop.Controls.Add(this.dateSADateEnd);
            this.pnltop.Controls.Add(this.lab1);
            this.pnltop.Controls.Add(this.dateSADateBegin);
            this.pnltop.Controls.Add(this.labReqDep);
            this.pnltop.Controls.Add(this.labCommon);
            this.pnltop.Controls.Add(this.labPrepared);
            this.pnltop.Controls.Add(this.labBussinessBaseNo);
            this.pnltop.Controls.Add(this.labSADate);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Margin = new System.Windows.Forms.Padding(4);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(1045, 78);
            this.pnltop.TabIndex = 2;
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
            this.lookUpReqDep.TabIndex = 3;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(470, 43);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 6;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // textCommon
            // 
            this.textCommon.EnterMoveNextControl = true;
            this.textCommon.Location = new System.Drawing.Point(295, 44);
            this.textCommon.Margin = new System.Windows.Forms.Padding(4);
            this.textCommon.Name = "textCommon";
            this.textCommon.Size = new System.Drawing.Size(150, 20);
            this.textCommon.TabIndex = 5;
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
            this.searchLookUpBussinessBaseNoView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewSettleAccountsHead_CustomDrawRowIndicator);
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
            // dateSADateEnd
            // 
            this.dateSADateEnd.EditValue = null;
            this.dateSADateEnd.EnterMoveNextControl = true;
            this.dateSADateEnd.Location = new System.Drawing.Point(202, 14);
            this.dateSADateEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dateSADateEnd.Name = "dateSADateEnd";
            this.dateSADateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSADateEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSADateEnd.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dateSADateEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateSADateEnd.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateSADateEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateSADateEnd.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateSADateEnd.Size = new System.Drawing.Size(100, 20);
            this.dateSADateEnd.TabIndex = 1;
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
            // dateSADateBegin
            // 
            this.dateSADateBegin.EditValue = null;
            this.dateSADateBegin.EnterMoveNextControl = true;
            this.dateSADateBegin.Location = new System.Drawing.Point(86, 14);
            this.dateSADateBegin.Margin = new System.Windows.Forms.Padding(4);
            this.dateSADateBegin.Name = "dateSADateBegin";
            this.dateSADateBegin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSADateBegin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSADateBegin.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dateSADateBegin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateSADateBegin.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateSADateBegin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateSADateBegin.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateSADateBegin.Size = new System.Drawing.Size(100, 20);
            this.dateSADateBegin.TabIndex = 0;
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
            // labBussinessBaseNo
            // 
            this.labBussinessBaseNo.Location = new System.Drawing.Point(315, 17);
            this.labBussinessBaseNo.Margin = new System.Windows.Forms.Padding(4);
            this.labBussinessBaseNo.Name = "labBussinessBaseNo";
            this.labBussinessBaseNo.Size = new System.Drawing.Size(48, 14);
            this.labBussinessBaseNo.TabIndex = 18;
            this.labBussinessBaseNo.Text = "往来方：";
            // 
            // labSADate
            // 
            this.labSADate.Location = new System.Drawing.Point(20, 17);
            this.labSADate.Margin = new System.Windows.Forms.Padding(4);
            this.labSADate.Name = "labSADate";
            this.labSADate.Size = new System.Drawing.Size(60, 14);
            this.labSADate.TabIndex = 5;
            this.labSADate.Text = "结账日期：";
            // 
            // dockManagerLeft
            // 
            this.dockManagerLeft.Form = this;
            this.dockManagerLeft.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPnlLeft});
            this.dockManagerLeft.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane"});
            // 
            // dockPnlLeft
            // 
            this.dockPnlLeft.Controls.Add(this.dockPanel1_Container);
            this.dockPnlLeft.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPnlLeft.ID = new System.Guid("a6395eb6-d5bf-4c21-b940-f8fd7ae2f89b");
            this.dockPnlLeft.Image = ((System.Drawing.Image)(resources.GetObject("dockPnlLeft.Image")));
            this.dockPnlLeft.Location = new System.Drawing.Point(0, 0);
            this.dockPnlLeft.Name = "dockPnlLeft";
            this.dockPnlLeft.Options.AllowDockAsTabbedDocument = false;
            this.dockPnlLeft.Options.AllowDockBottom = false;
            this.dockPnlLeft.Options.AllowDockFill = false;
            this.dockPnlLeft.Options.AllowDockRight = false;
            this.dockPnlLeft.Options.AllowDockTop = false;
            this.dockPnlLeft.Options.AllowFloating = false;
            this.dockPnlLeft.Options.FloatOnDblClick = false;
            this.dockPnlLeft.Options.ShowCloseButton = false;
            this.dockPnlLeft.Options.ShowMaximizeButton = false;
            this.dockPnlLeft.OriginalSize = new System.Drawing.Size(350, 200);
            this.dockPnlLeft.Size = new System.Drawing.Size(350, 643);
            this.dockPnlLeft.Text = "销售订单";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.pnlLeftGrid);
            this.dockPanel1_Container.Controls.Add(this.pnlLeftTop);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(342, 616);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // pnlLeftGrid
            // 
            this.pnlLeftGrid.Controls.Add(this.gridControlSalesOrder);
            this.pnlLeftGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeftGrid.Location = new System.Drawing.Point(0, 93);
            this.pnlLeftGrid.Name = "pnlLeftGrid";
            this.pnlLeftGrid.Size = new System.Drawing.Size(342, 523);
            this.pnlLeftGrid.TabIndex = 3;
            // 
            // gridControlSalesOrder
            // 
            this.gridControlSalesOrder.AllowDrop = true;
            this.gridControlSalesOrder.DataSource = this.bindingSource_SalesOrder;
            this.gridControlSalesOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSalesOrder.Location = new System.Drawing.Point(2, 2);
            this.gridControlSalesOrder.MainView = this.gridViewSalesOrder;
            this.gridControlSalesOrder.Name = "gridControlSalesOrder";
            this.gridControlSalesOrder.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repSearchLookUpBussinessBaseNo,
            this.repositoryItemCheckEdit1,
            this.repLookUpCollectionTypeNo,
            this.repCheckIsEnd});
            this.gridControlSalesOrder.Size = new System.Drawing.Size(338, 519);
            this.gridControlSalesOrder.TabIndex = 5;
            this.gridControlSalesOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSalesOrder});
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
            this.dataColumn1,
            this.dataColAutoSalesOrderNo,
            this.dataColSalesOrderDate,
            this.dataColProjectNo,
            this.dataColProjectName,
            this.dataColumn2,
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
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8,
            this.dataColParentAutoSalesOrderNo,
            this.dataColParentProjectNo,
            this.dataColSalesOrderState,
            this.dataColSettleAmount,
            this.dataColNoSettleAmount});
            this.TableSalesOrder.TableName = "SalesOrder";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "AutoId";
            this.dataColumn1.DataType = typeof(int);
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
            // dataColumn2
            // 
            this.dataColumn2.Caption = "往来方";
            this.dataColumn2.ColumnName = "BussinessBaseNo";
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
            // dataColumn3
            // 
            this.dataColumn3.Caption = "制单人";
            this.dataColumn3.ColumnName = "Prepared";
            // 
            // dataColumn4
            // 
            this.dataColumn4.Caption = "制单人IP";
            this.dataColumn4.ColumnName = "PreparedIp";
            // 
            // dataColumn5
            // 
            this.dataColumn5.Caption = "修改人";
            this.dataColumn5.ColumnName = "Modifier";
            // 
            // dataColumn6
            // 
            this.dataColumn6.Caption = "修改人IP";
            this.dataColumn6.ColumnName = "ModifierIp";
            // 
            // dataColumn7
            // 
            this.dataColumn7.Caption = "修改时间";
            this.dataColumn7.ColumnName = "ModifierTime";
            this.dataColumn7.DataType = typeof(System.DateTime);
            // 
            // dataColumn8
            // 
            this.dataColumn8.Caption = "备注";
            this.dataColumn8.ColumnName = "Remark";
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
            // dataColSettleAmount
            // 
            this.dataColSettleAmount.Caption = "已结金额";
            this.dataColSettleAmount.ColumnName = "SettleAmount";
            this.dataColSettleAmount.DataType = typeof(decimal);
            // 
            // dataColNoSettleAmount
            // 
            this.dataColNoSettleAmount.Caption = "未结金额";
            this.dataColNoSettleAmount.ColumnName = "NoSettleAmount";
            this.dataColNoSettleAmount.DataType = typeof(decimal);
            // 
            // gridViewSalesOrder
            // 
            this.gridViewSalesOrder.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn7,
            this.colSalesOrderDate,
            this.colAutoQuotationNo,
            this.gridColumn8,
            this.colProjectName,
            this.colQuotationVersions,
            this.gridColumn13,
            this.colSettleAmount,
            this.colTax,
            this.gridColumn14,
            this.gridColumn15,
            this.colCollectionTypeNo,
            this.colCustomerPoNo,
            this.colProjectLeader,
            this.colIsEnd,
            this.gridColumn16,
            this.gridColumn17,
            this.gridColumn18,
            this.colModifierTime,
            this.colParentAutoSalesOrderNo,
            this.colParentProjectNo});
            this.gridViewSalesOrder.GridControl = this.gridControlSalesOrder;
            this.gridViewSalesOrder.IndicatorWidth = 40;
            this.gridViewSalesOrder.Name = "gridViewSalesOrder";
            this.gridViewSalesOrder.OptionsBehavior.Editable = false;
            this.gridViewSalesOrder.OptionsBehavior.ReadOnly = true;
            this.gridViewSalesOrder.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewSalesOrder.OptionsSelection.MultiSelect = true;
            this.gridViewSalesOrder.OptionsView.ColumnAutoWidth = false;
            this.gridViewSalesOrder.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewSalesOrder.OptionsView.ShowGroupPanel = false;
            this.gridViewSalesOrder.OptionsView.ShowIndicator = false;
            this.gridViewSalesOrder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridViewSalesOrder_MouseDown);
            this.gridViewSalesOrder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gridViewSalesOrder_MouseMove);
            // 
            // gridColumn6
            // 
            this.gridColumn6.FieldName = "AutoId";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn7.FieldName = "AutoSalesOrderNo";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.OptionsColumn.AllowFocus = false;
            this.gridColumn7.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "WarehouseWarrant", "共计{0}条")});
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            this.gridColumn7.Width = 110;
            // 
            // colSalesOrderDate
            // 
            this.colSalesOrderDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colSalesOrderDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSalesOrderDate.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.colSalesOrderDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colSalesOrderDate.FieldName = "SalesOrderDate";
            this.colSalesOrderDate.Name = "colSalesOrderDate";
            this.colSalesOrderDate.OptionsColumn.AllowEdit = false;
            this.colSalesOrderDate.OptionsColumn.AllowFocus = false;
            this.colSalesOrderDate.Visible = true;
            this.colSalesOrderDate.VisibleIndex = 6;
            this.colSalesOrderDate.Width = 80;
            // 
            // colAutoQuotationNo
            // 
            this.colAutoQuotationNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colAutoQuotationNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAutoQuotationNo.FieldName = "AutoQuotationNo";
            this.colAutoQuotationNo.Name = "colAutoQuotationNo";
            this.colAutoQuotationNo.Visible = true;
            this.colAutoQuotationNo.VisibleIndex = 4;
            this.colAutoQuotationNo.Width = 110;
            // 
            // gridColumn8
            // 
            this.gridColumn8.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn8.ColumnEdit = this.repSearchLookUpBussinessBaseNo;
            this.gridColumn8.FieldName = "BussinessBaseNo";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.OptionsColumn.AllowFocus = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 1;
            this.gridColumn8.Width = 90;
            // 
            // repSearchLookUpBussinessBaseNo
            // 
            this.repSearchLookUpBussinessBaseNo.AutoHeight = false;
            this.repSearchLookUpBussinessBaseNo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repSearchLookUpBussinessBaseNo.DisplayMember = "BussinessBaseText";
            this.repSearchLookUpBussinessBaseNo.Name = "repSearchLookUpBussinessBaseNo";
            this.repSearchLookUpBussinessBaseNo.NullText = "";
            this.repSearchLookUpBussinessBaseNo.ValueMember = "BussinessBaseNo";
            this.repSearchLookUpBussinessBaseNo.View = this.repSearchLookUpBussinessBaseNoView;
            // 
            // repSearchLookUpBussinessBaseNoView
            // 
            this.repSearchLookUpBussinessBaseNoView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12});
            this.repSearchLookUpBussinessBaseNoView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repSearchLookUpBussinessBaseNoView.IndicatorWidth = 60;
            this.repSearchLookUpBussinessBaseNoView.Name = "repSearchLookUpBussinessBaseNoView";
            this.repSearchLookUpBussinessBaseNoView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repSearchLookUpBussinessBaseNoView.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "往来方编号";
            this.gridColumn9.FieldName = "BussinessBaseNo";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 0;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "往来方名称";
            this.gridColumn10.FieldName = "BussinessBaseText";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 1;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "往来方分类";
            this.gridColumn11.FieldName = "BussinessCategoryText";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 2;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "AutoId";
            this.gridColumn12.FieldName = "AutoId";
            this.gridColumn12.Name = "gridColumn12";
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
            this.colProjectName.Width = 80;
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
            // gridColumn13
            // 
            this.gridColumn13.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn13.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn13.DisplayFormat.FormatString = "N2";
            this.gridColumn13.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn13.FieldName = "Amount";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.OptionsColumn.AllowEdit = false;
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 2;
            this.gridColumn13.Width = 70;
            // 
            // colSettleAmount
            // 
            this.colSettleAmount.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.colSettleAmount.AppearanceCell.Options.UseForeColor = true;
            this.colSettleAmount.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.colSettleAmount.AppearanceHeader.Options.UseForeColor = true;
            this.colSettleAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colSettleAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSettleAmount.DisplayFormat.FormatString = "N2";
            this.colSettleAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSettleAmount.FieldName = "NoSettleAmount";
            this.colSettleAmount.Name = "colSettleAmount";
            this.colSettleAmount.Visible = true;
            this.colSettleAmount.VisibleIndex = 3;
            this.colSettleAmount.Width = 70;
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
            this.colTax.VisibleIndex = 8;
            this.colTax.Width = 80;
            // 
            // gridColumn14
            // 
            this.gridColumn14.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn14.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn14.DisplayFormat.FormatString = "N2";
            this.gridColumn14.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn14.FieldName = "TaxAmount";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.OptionsColumn.AllowEdit = false;
            this.gridColumn14.OptionsColumn.AllowFocus = false;
            this.gridColumn14.Width = 80;
            // 
            // gridColumn15
            // 
            this.gridColumn15.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn15.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn15.DisplayFormat.FormatString = "N2";
            this.gridColumn15.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn15.FieldName = "SumAmount";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 9;
            this.gridColumn15.Width = 70;
            // 
            // colCollectionTypeNo
            // 
            this.colCollectionTypeNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colCollectionTypeNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCollectionTypeNo.ColumnEdit = this.repLookUpCollectionTypeNo;
            this.colCollectionTypeNo.FieldName = "CollectionTypeNo";
            this.colCollectionTypeNo.Name = "colCollectionTypeNo";
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
            this.colCustomerPoNo.VisibleIndex = 10;
            this.colCustomerPoNo.Width = 110;
            // 
            // colProjectLeader
            // 
            this.colProjectLeader.AppearanceHeader.Options.UseTextOptions = true;
            this.colProjectLeader.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProjectLeader.FieldName = "ProjectLeader";
            this.colProjectLeader.Name = "colProjectLeader";
            this.colProjectLeader.Visible = true;
            this.colProjectLeader.VisibleIndex = 11;
            this.colProjectLeader.Width = 80;
            // 
            // colIsEnd
            // 
            this.colIsEnd.AppearanceHeader.Options.UseTextOptions = true;
            this.colIsEnd.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIsEnd.ColumnEdit = this.repCheckIsEnd;
            this.colIsEnd.FieldName = "IsEnd";
            this.colIsEnd.Name = "colIsEnd";
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
            // gridColumn16
            // 
            this.gridColumn16.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn16.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn16.FieldName = "Remark";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 12;
            this.gridColumn16.Width = 80;
            // 
            // gridColumn17
            // 
            this.gridColumn17.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn17.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn17.FieldName = "Prepared";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Width = 80;
            // 
            // gridColumn18
            // 
            this.gridColumn18.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn18.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn18.FieldName = "Modifier";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Width = 80;
            // 
            // colModifierTime
            // 
            this.colModifierTime.AppearanceHeader.Options.UseTextOptions = true;
            this.colModifierTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colModifierTime.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.colModifierTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colModifierTime.FieldName = "ModifierTime";
            this.colModifierTime.Name = "colModifierTime";
            this.colModifierTime.Width = 130;
            // 
            // colParentAutoSalesOrderNo
            // 
            this.colParentAutoSalesOrderNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colParentAutoSalesOrderNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colParentAutoSalesOrderNo.FieldName = "ParentAutoSalesOrderNo";
            this.colParentAutoSalesOrderNo.Name = "colParentAutoSalesOrderNo";
            this.colParentAutoSalesOrderNo.Width = 120;
            // 
            // colParentProjectNo
            // 
            this.colParentProjectNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colParentProjectNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colParentProjectNo.FieldName = "ParentProjectNo";
            this.colParentProjectNo.Name = "colParentProjectNo";
            this.colParentProjectNo.Width = 120;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repositoryItemCheckEdit1.ValueGrayed = false;
            // 
            // pnlLeftTop
            // 
            this.pnlLeftTop.Controls.Add(this.searchBussinessBaseNo);
            this.pnlLeftTop.Controls.Add(this.labelBussinessBaseNo);
            this.pnlLeftTop.Controls.Add(this.btnPrReqQuery);
            this.pnlLeftTop.Controls.Add(this.dateSODateEnd);
            this.pnlLeftTop.Controls.Add(this.dateSODateBegin);
            this.pnlLeftTop.Controls.Add(this.textAutoSalesOrderNo);
            this.pnlLeftTop.Controls.Add(this.lab);
            this.pnlLeftTop.Controls.Add(this.labSalesOrderDate);
            this.pnlLeftTop.Controls.Add(this.labAutoSalesOrderNo);
            this.pnlLeftTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeftTop.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftTop.Name = "pnlLeftTop";
            this.pnlLeftTop.Size = new System.Drawing.Size(342, 93);
            this.pnlLeftTop.TabIndex = 2;
            // 
            // searchBussinessBaseNo
            // 
            this.searchBussinessBaseNo.EnterMoveNextControl = true;
            this.searchBussinessBaseNo.Location = new System.Drawing.Point(83, 65);
            this.searchBussinessBaseNo.Margin = new System.Windows.Forms.Padding(4);
            this.searchBussinessBaseNo.Name = "searchBussinessBaseNo";
            this.searchBussinessBaseNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchBussinessBaseNo.Properties.DisplayMember = "BussinessBaseText";
            this.searchBussinessBaseNo.Properties.NullText = "";
            this.searchBussinessBaseNo.Properties.ValueMember = "BussinessBaseNo";
            this.searchBussinessBaseNo.Properties.View = this.searchBussinessBaseNoView;
            this.searchBussinessBaseNo.Size = new System.Drawing.Size(150, 20);
            this.searchBussinessBaseNo.TabIndex = 204;
            // 
            // searchBussinessBaseNoView
            // 
            this.searchBussinessBaseNoView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.searchBussinessBaseNoView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchBussinessBaseNoView.IndicatorWidth = 60;
            this.searchBussinessBaseNoView.Name = "searchBussinessBaseNoView";
            this.searchBussinessBaseNoView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchBussinessBaseNoView.OptionsView.ShowGroupPanel = false;
            this.searchBussinessBaseNoView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewSettleAccountsHead_CustomDrawRowIndicator);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "往来方编号";
            this.gridColumn1.FieldName = "BussinessBaseNo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "往来方名称";
            this.gridColumn3.FieldName = "BussinessBaseText";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "往来方分类";
            this.gridColumn4.FieldName = "BussinessCategoryText";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "gridColumnAutoId";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // labelBussinessBaseNo
            // 
            this.labelBussinessBaseNo.Location = new System.Drawing.Point(9, 68);
            this.labelBussinessBaseNo.Margin = new System.Windows.Forms.Padding(4);
            this.labelBussinessBaseNo.Name = "labelBussinessBaseNo";
            this.labelBussinessBaseNo.Size = new System.Drawing.Size(48, 14);
            this.labelBussinessBaseNo.TabIndex = 213;
            this.labelBussinessBaseNo.Text = "往来方：";
            // 
            // btnPrReqQuery
            // 
            this.btnPrReqQuery.Location = new System.Drawing.Point(240, 64);
            this.btnPrReqQuery.Name = "btnPrReqQuery";
            this.btnPrReqQuery.Size = new System.Drawing.Size(75, 23);
            this.btnPrReqQuery.TabIndex = 205;
            this.btnPrReqQuery.Text = "查询";
            this.btnPrReqQuery.Click += new System.EventHandler(this.btnPrReqQuery_Click);
            // 
            // dateSODateEnd
            // 
            this.dateSODateEnd.EditValue = null;
            this.dateSODateEnd.EnterMoveNextControl = true;
            this.dateSODateEnd.Location = new System.Drawing.Point(200, 37);
            this.dateSODateEnd.Name = "dateSODateEnd";
            this.dateSODateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSODateEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSODateEnd.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dateSODateEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateSODateEnd.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateSODateEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateSODateEnd.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateSODateEnd.Size = new System.Drawing.Size(100, 20);
            this.dateSODateEnd.TabIndex = 203;
            // 
            // dateSODateBegin
            // 
            this.dateSODateBegin.EditValue = null;
            this.dateSODateBegin.EnterMoveNextControl = true;
            this.dateSODateBegin.Location = new System.Drawing.Point(83, 37);
            this.dateSODateBegin.Name = "dateSODateBegin";
            this.dateSODateBegin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSODateBegin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSODateBegin.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dateSODateBegin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateSODateBegin.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateSODateBegin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateSODateBegin.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateSODateBegin.Size = new System.Drawing.Size(100, 20);
            this.dateSODateBegin.TabIndex = 202;
            // 
            // textAutoSalesOrderNo
            // 
            this.textAutoSalesOrderNo.EnterMoveNextControl = true;
            this.textAutoSalesOrderNo.Location = new System.Drawing.Point(83, 8);
            this.textAutoSalesOrderNo.Name = "textAutoSalesOrderNo";
            this.textAutoSalesOrderNo.Size = new System.Drawing.Size(150, 20);
            this.textAutoSalesOrderNo.TabIndex = 201;
            // 
            // lab
            // 
            this.lab.Location = new System.Drawing.Point(189, 40);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(4, 14);
            this.lab.TabIndex = 206;
            this.lab.Text = "-";
            // 
            // labSalesOrderDate
            // 
            this.labSalesOrderDate.Location = new System.Drawing.Point(9, 40);
            this.labSalesOrderDate.Name = "labSalesOrderDate";
            this.labSalesOrderDate.Size = new System.Drawing.Size(60, 14);
            this.labSalesOrderDate.TabIndex = 205;
            this.labSalesOrderDate.Text = "登记日期：";
            // 
            // labAutoSalesOrderNo
            // 
            this.labAutoSalesOrderNo.Location = new System.Drawing.Point(9, 11);
            this.labAutoSalesOrderNo.Name = "labAutoSalesOrderNo";
            this.labAutoSalesOrderNo.Size = new System.Drawing.Size(72, 14);
            this.labAutoSalesOrderNo.TabIndex = 204;
            this.labAutoSalesOrderNo.Text = "销售订单号：";
            // 
            // FrmSettleAccounts
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1395, 643);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.dockPnlLeft);
            this.Name = "FrmSettleAccounts";
            this.TabText = "销售结账单";
            this.Text = "销售结账单";
            this.Activated += new System.EventHandler(this.FrmSettleAccounts_Activated);
            this.Load += new System.EventHandler(this.FrmSettleAccounts_Load);
            this.Shown += new System.EventHandler(this.FrmSettleAccounts_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_SettleAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableSettleAccountsHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableSettleAccountsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_SAHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_SAList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).EndInit();
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtlSettleAccountsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSettleAccountsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinTax1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repbtnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddle)).EndInit();
            this.pnlMiddle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtlSettleAccountsHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSettleAccountsHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpReqDep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchBussinessBaseNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchBussinessBaseNoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckIsVoucher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddleTop)).EndInit();
            this.pnlMiddleTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnltop)).EndInit();
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpReqDep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCommon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPrepared.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpBussinessBaseNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpBussinessBaseNoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSADateEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSADateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSADateBegin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSADateBegin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManagerLeft)).EndInit();
            this.dockPnlLeft.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeftGrid)).EndInit();
            this.pnlLeftGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSalesOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_SalesOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_SalesOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableSalesOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSalesOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchLookUpBussinessBaseNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchLookUpBussinessBaseNoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpCollectionTypeNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckIsEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeftTop)).EndInit();
            this.pnlLeftTop.ResumeLayout(false);
            this.pnlLeftTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchBussinessBaseNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBussinessBaseNoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSODateEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSODateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSODateBegin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSODateBegin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAutoSalesOrderNo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dataSet_SettleAccounts;
        private System.Data.DataTable TableSettleAccountsHead;
        private System.Data.DataColumn dataColAutoId;
        private System.Data.DataColumn dataColSettleAccountNo;
        private System.Data.DataColumn dataColSettleAccountDate;
        private System.Data.DataColumn dataColReqDep;
        private System.Data.DataColumn dataColBussinessBaseNo;
        private System.Data.DataColumn dataColIsVoucher;
        private System.Data.DataColumn dataColPrepared;
        private System.Data.DataColumn dataColPreparedIp;
        private System.Data.DataColumn dataColModifier;
        private System.Data.DataColumn dataColModifierIp;
        private System.Data.DataColumn dataColModifierTime;
        private System.Data.DataColumn dataColRemark;
        private System.Data.DataTable TableSettleAccountsList;
        private System.Data.DataColumn dataColuAutoId;
        private System.Data.DataColumn dataColuSettleAccountNo;
        private System.Data.DataColumn dataColuAutoSalesOrderNo;
        private System.Data.DataColumn dataColuAmount;
        private System.Data.DataColumn dataColuRemark;
        private System.Data.DataColumn dataColuTax;
        private System.Data.DataColumn dataColuTaxAmount;
        private System.Data.DataColumn dataColuSumAmount;
        private System.Windows.Forms.BindingSource bindingSource_SAHead;
        private System.Windows.Forms.BindingSource bindingSource_SAList;
        private DevExpress.XtraEditors.PanelControl pnlRight;
        private DevExpress.XtraBars.Docking.DockManager dockManagerLeft;
        private DevExpress.XtraBars.Docking.DockPanel dockPnlLeft;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraEditors.PanelControl pnltop;
        private DevExpress.XtraEditors.LookUpEdit lookUpReqDep;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.TextEdit textCommon;
        private DevExpress.XtraEditors.LookUpEdit lookUpPrepared;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpBussinessBaseNo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpBussinessBaseNoView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBussinessBaseNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBussinessBaseText;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBussinessCategoryText;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnAutoId;
        private DevExpress.XtraEditors.DateEdit dateSADateEnd;
        private DevExpress.XtraEditors.LabelControl lab1;
        private DevExpress.XtraEditors.DateEdit dateSADateBegin;
        private DevExpress.XtraEditors.LabelControl labReqDep;
        private DevExpress.XtraEditors.LabelControl labCommon;
        private DevExpress.XtraEditors.LabelControl labPrepared;
        private DevExpress.XtraEditors.LabelControl labBussinessBaseNo;
        private DevExpress.XtraEditors.LabelControl labSADate;
        private DevExpress.XtraEditors.PanelControl pnlMiddle;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.PanelControl pnlGrid;
        private DevExpress.XtraEditors.PanelControl pnlMiddleTop;
        private DevExpress.XtraEditors.SimpleButton btnPreview;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Data.DataColumn dataColSettleAccountsState;
        private DevExpress.XtraGrid.GridControl gridCtlSettleAccountsHead;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSettleAccountsHead;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colSelect;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheckSelect;
        private DevExpress.XtraGrid.Columns.GridColumn colSettleAccountNo;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouseState;
        private DevExpress.XtraGrid.Columns.GridColumn colSettlementDate;
        private DevExpress.XtraGrid.Columns.GridColumn colReqDep;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpReqDep;
        private DevExpress.XtraGrid.Columns.GridColumn colBussinessBaseNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repSearchBussinessBaseNo;
        private DevExpress.XtraGrid.Views.Grid.GridView repSearchBussinessBaseNoView;
        private DevExpress.XtraGrid.Columns.GridColumn gridCBussinessBaseNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridCBussinessBaseText;
        private DevExpress.XtraGrid.Columns.GridColumn gridCBussinessCategoryText;
        private DevExpress.XtraGrid.Columns.GridColumn gridCAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colIsVoucher;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheckIsVoucher;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colPrepared;
        private DevExpress.XtraGrid.Columns.GridColumn colModifier;
        private DevExpress.XtraGrid.GridControl gridCtlSettleAccountsList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSettleAccountsList;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId1;
        private DevExpress.XtraGrid.Columns.GridColumn colSettleAccountNo1;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoSalesOrderNo;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colTax1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repSpinTax1;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colSumAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colListRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repbtnDelete;
        private System.Data.DataColumn dataColSelect;
        private DevExpress.XtraEditors.CheckEdit checkAll;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repSpinAmount;
        private DevExpress.XtraEditors.PanelControl pnlLeftTop;
        private DevExpress.XtraEditors.LabelControl labelBussinessBaseNo;
        private DevExpress.XtraEditors.SimpleButton btnPrReqQuery;
        private DevExpress.XtraEditors.DateEdit dateSODateEnd;
        private DevExpress.XtraEditors.DateEdit dateSODateBegin;
        private DevExpress.XtraEditors.TextEdit textAutoSalesOrderNo;
        private DevExpress.XtraEditors.LabelControl lab;
        private DevExpress.XtraEditors.LabelControl labSalesOrderDate;
        private DevExpress.XtraEditors.LabelControl labAutoSalesOrderNo;
        private System.Windows.Forms.BindingSource bindingSource_SalesOrder;
        private System.Data.DataSet dataSet_SalesOrder;
        private System.Data.DataTable TableSalesOrder;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColAutoSalesOrderNo;
        private System.Data.DataColumn dataColSalesOrderDate;
        private System.Data.DataColumn dataColProjectNo;
        private System.Data.DataColumn dataColProjectName;
        private System.Data.DataColumn dataColumn2;
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
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColParentAutoSalesOrderNo;
        private System.Data.DataColumn dataColParentProjectNo;
        private System.Data.DataColumn dataColSalesOrderState;
        private DevExpress.XtraEditors.PanelControl pnlLeftGrid;
        private System.Data.DataColumn dataColSettleAmount;
        private DevExpress.XtraEditors.SearchLookUpEdit searchBussinessBaseNo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchBussinessBaseNoView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.GridControl gridControlSalesOrder;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSalesOrder;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoQuotationNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repSearchLookUpBussinessBaseNo;
        private DevExpress.XtraGrid.Views.Grid.GridView repSearchLookUpBussinessBaseNoView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectName;
        private DevExpress.XtraGrid.Columns.GridColumn colQuotationVersions;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn colTax;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn colCollectionTypeNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpCollectionTypeNo;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerPoNo;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectLeader;
        private DevExpress.XtraGrid.Columns.GridColumn colIsEnd;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheckIsEnd;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn colModifierTime;
        private DevExpress.XtraGrid.Columns.GridColumn colParentAutoSalesOrderNo;
        private DevExpress.XtraGrid.Columns.GridColumn colParentProjectNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colSettleAmount;
        private System.Data.DataColumn dataColNoSettleAmount;
    }
}