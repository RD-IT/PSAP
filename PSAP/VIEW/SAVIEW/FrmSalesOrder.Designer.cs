namespace PSAP.VIEW.BSVIEW
{
    partial class FrmSalesOrder
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
            this.bindingSource_SalesOrder = new System.Windows.Forms.BindingSource(this.components);
            this.pnlRight = new DevExpress.XtraEditors.PanelControl();
            this.pnlGrid = new DevExpress.XtraEditors.PanelControl();
            this.xtraTabGrid = new DevExpress.XtraTab.XtraTabControl();
            this.PageQuotationBaseInfo = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlQuotationBaseInfo = new DevExpress.XtraGrid.GridControl();
            this.bindingSource_BaseInfo = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Quotation = new System.Data.DataSet();
            this.TableQuotationBaseInfo = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColRFQNO = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColRequester = new System.Data.DataColumn();
            this.dataColRecordDate = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColParentAutoQuotationNo = new System.Data.DataColumn();
            this.dataColuParentAutoSalesOrderNo = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.dataColumn11 = new System.Data.DataColumn();
            this.gridViewQuotationBaseInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAutoQuotationNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecordDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBussinessBaseNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSearchBussinessBaseNo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridCBussinessBaseNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCBussinessBaseText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCBussinessCategoryText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRepertoryNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRequester = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRFQNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrepared = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifierTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParentAutoQuotationNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParentAutoSalesOrderNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParentProjectNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCheckSelect = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.pnlGridTop = new DevExpress.XtraEditors.PanelControl();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.textCommon = new DevExpress.XtraEditors.TextEdit();
            this.labCommon = new DevExpress.XtraEditors.LabelControl();
            this.searchLookUpBussinessBaseNo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpBussinessBaseNoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dateRecordDateEnd = new DevExpress.XtraEditors.DateEdit();
            this.dateRecordDateBegin = new DevExpress.XtraEditors.DateEdit();
            this.lab1 = new DevExpress.XtraEditors.LabelControl();
            this.labRecordDate = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.textParentProjectNo = new DevExpress.XtraEditors.TextEdit();
            this.labParentProjectNo = new DevExpress.XtraEditors.LabelControl();
            this.textParentAutoSalesOrderNo = new DevExpress.XtraEditors.TextEdit();
            this.labParentAutoSalesOrderNo = new DevExpress.XtraEditors.LabelControl();
            this.lookUpQuotationVersions = new DevExpress.XtraEditors.LookUpEdit();
            this.labMemo = new DevExpress.XtraEditors.LabelControl();
            this.textAutoQuotationNo = new DevExpress.XtraEditors.TextEdit();
            this.labIsEnd = new DevExpress.XtraEditors.LabelControl();
            this.checkIsEnd = new DevExpress.XtraEditors.CheckEdit();
            this.labQuotationVersions = new DevExpress.XtraEditors.LabelControl();
            this.labAutoQuotationNo = new DevExpress.XtraEditors.LabelControl();
            this.labTax = new DevExpress.XtraEditors.LabelControl();
            this.spinTax = new DevExpress.XtraEditors.SpinEdit();
            this.labSumAmount = new DevExpress.XtraEditors.LabelControl();
            this.spinSumAmount = new DevExpress.XtraEditors.SpinEdit();
            this.labTaxAmount = new DevExpress.XtraEditors.LabelControl();
            this.spinTaxAmount = new DevExpress.XtraEditors.SpinEdit();
            this.labAmount = new DevExpress.XtraEditors.LabelControl();
            this.spinAmount = new DevExpress.XtraEditors.SpinEdit();
            this.labCollectionTypeNo = new DevExpress.XtraEditors.LabelControl();
            this.lookUpCollectionTypeNo = new DevExpress.XtraEditors.LookUpEdit();
            this.textModifier = new DevExpress.XtraEditors.TextEdit();
            this.textPrepared = new DevExpress.XtraEditors.TextEdit();
            this.dateModifierTime = new DevExpress.XtraEditors.DateEdit();
            this.labModifierTime = new DevExpress.XtraEditors.LabelControl();
            this.labModifier = new DevExpress.XtraEditors.LabelControl();
            this.labPrepared = new DevExpress.XtraEditors.LabelControl();
            this.labSalesOrderDate = new DevExpress.XtraEditors.LabelControl();
            this.dateSalesOrderDate = new DevExpress.XtraEditors.DateEdit();
            this.textRemark = new DevExpress.XtraEditors.TextEdit();
            this.labRemark = new DevExpress.XtraEditors.LabelControl();
            this.textProjectLeader = new DevExpress.XtraEditors.TextEdit();
            this.labProjectLeader = new DevExpress.XtraEditors.LabelControl();
            this.labBussinessBaseNo = new DevExpress.XtraEditors.LabelControl();
            this.labProjectName = new DevExpress.XtraEditors.LabelControl();
            this.searchBussinessBaseNo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchBussinessBaseNoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnBussinessBaseNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBussinessBaseText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBussinessCategoryText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.searchProjectName = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchProjectNameView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColProjectNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColProjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textCustomerPoNo = new DevExpress.XtraEditors.TextEdit();
            this.labCustomerPoNo = new DevExpress.XtraEditors.LabelControl();
            this.textAutoSalesOrderNo = new DevExpress.XtraEditors.TextEdit();
            this.labAutoSalesOrderNo = new DevExpress.XtraEditors.LabelControl();
            this.pnlToolBar = new DevExpress.XtraEditors.PanelControl();
            this.BtnCOR = new DevExpress.XtraEditors.SimpleButton();
            this.btnPreview = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditQueryAutoSalesOrderNo = new DevExpress.XtraEditors.ButtonEdit();
            this.labQueryAutoQuotationNo = new DevExpress.XtraEditors.LabelControl();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_SalesOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableSalesOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_SalesOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).BeginInit();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabGrid)).BeginInit();
            this.xtraTabGrid.SuspendLayout();
            this.PageQuotationBaseInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlQuotationBaseInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_BaseInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Quotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableQuotationBaseInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewQuotationBaseInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchBussinessBaseNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGridTop)).BeginInit();
            this.pnlGridTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textCommon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpBussinessBaseNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpBussinessBaseNoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRecordDateEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRecordDateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRecordDateBegin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRecordDateBegin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textParentProjectNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textParentAutoSalesOrderNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpQuotationVersions.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAutoQuotationNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkIsEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSumAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTaxAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCollectionTypeNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textModifier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPrepared.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateModifierTime.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateModifierTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSalesOrderDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSalesOrderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textProjectLeader.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBussinessBaseNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBussinessBaseNoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchProjectName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchProjectNameView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCustomerPoNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAutoSalesOrderNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).BeginInit();
            this.pnlToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditQueryAutoSalesOrderNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet_SalesOrder
            // 
            this.dataSet_SalesOrder.DataSetName = "NewDataSet";
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
            this.TableSalesOrder.TableNewRow += new System.Data.DataTableNewRowEventHandler(this.TableSalesOrder_TableNewRow);
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
            this.dataColIsEnd.Caption = "是否结完账";
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
            // bindingSource_SalesOrder
            // 
            this.bindingSource_SalesOrder.DataMember = "SalesOrder";
            this.bindingSource_SalesOrder.DataSource = this.dataSet_SalesOrder;
            // 
            // pnlRight
            // 
            this.pnlRight.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlRight.Controls.Add(this.pnlGrid);
            this.pnlRight.Controls.Add(this.panelControl1);
            this.pnlRight.Controls.Add(this.pnlToolBar);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(0, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(1305, 611);
            this.pnlRight.TabIndex = 3;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.xtraTabGrid);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 271);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1305, 340);
            this.pnlGrid.TabIndex = 10;
            // 
            // xtraTabGrid
            // 
            this.xtraTabGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabGrid.Location = new System.Drawing.Point(2, 2);
            this.xtraTabGrid.Name = "xtraTabGrid";
            this.xtraTabGrid.SelectedTabPage = this.PageQuotationBaseInfo;
            this.xtraTabGrid.Size = new System.Drawing.Size(1301, 336);
            this.xtraTabGrid.TabIndex = 9;
            this.xtraTabGrid.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.PageQuotationBaseInfo});
            // 
            // PageQuotationBaseInfo
            // 
            this.PageQuotationBaseInfo.Controls.Add(this.gridControlQuotationBaseInfo);
            this.PageQuotationBaseInfo.Controls.Add(this.pnlGridTop);
            this.PageQuotationBaseInfo.Name = "PageQuotationBaseInfo";
            this.PageQuotationBaseInfo.Size = new System.Drawing.Size(1295, 307);
            this.PageQuotationBaseInfo.Text = "查询报价单";
            // 
            // gridControlQuotationBaseInfo
            // 
            this.gridControlQuotationBaseInfo.DataSource = this.bindingSource_BaseInfo;
            this.gridControlQuotationBaseInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlQuotationBaseInfo.Location = new System.Drawing.Point(0, 40);
            this.gridControlQuotationBaseInfo.MainView = this.gridViewQuotationBaseInfo;
            this.gridControlQuotationBaseInfo.Name = "gridControlQuotationBaseInfo";
            this.gridControlQuotationBaseInfo.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repSearchBussinessBaseNo,
            this.repCheckSelect});
            this.gridControlQuotationBaseInfo.Size = new System.Drawing.Size(1295, 267);
            this.gridControlQuotationBaseInfo.TabIndex = 5;
            this.gridControlQuotationBaseInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewQuotationBaseInfo});
            // 
            // bindingSource_BaseInfo
            // 
            this.bindingSource_BaseInfo.DataMember = "QuotationBaseInfo";
            this.bindingSource_BaseInfo.DataSource = this.dataSet_Quotation;
            // 
            // dataSet_Quotation
            // 
            this.dataSet_Quotation.DataSetName = "NewDataSet";
            this.dataSet_Quotation.Tables.AddRange(new System.Data.DataTable[] {
            this.TableQuotationBaseInfo});
            // 
            // TableQuotationBaseInfo
            // 
            this.TableQuotationBaseInfo.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColRFQNO,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColRequester,
            this.dataColRecordDate,
            this.dataColumn5,
            this.dataColParentAutoQuotationNo,
            this.dataColuParentAutoSalesOrderNo,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8,
            this.dataColumn9,
            this.dataColumn10,
            this.dataColumn11});
            this.TableQuotationBaseInfo.TableName = "QuotationBaseInfo";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "AutoId";
            this.dataColumn1.DataType = typeof(int);
            // 
            // dataColumn2
            // 
            this.dataColumn2.Caption = "报价单号";
            this.dataColumn2.ColumnName = "AutoQuotationNo";
            // 
            // dataColRFQNO
            // 
            this.dataColRFQNO.Caption = "手动单号";
            this.dataColRFQNO.ColumnName = "RFQNO";
            // 
            // dataColumn3
            // 
            this.dataColumn3.Caption = "项目名称";
            this.dataColumn3.ColumnName = "ProjectName";
            // 
            // dataColumn4
            // 
            this.dataColumn4.Caption = "客户";
            this.dataColumn4.ColumnName = "BussinessBaseNo";
            // 
            // dataColRequester
            // 
            this.dataColRequester.Caption = "客户需求人";
            this.dataColRequester.ColumnName = "Requester";
            // 
            // dataColRecordDate
            // 
            this.dataColRecordDate.Caption = "登记日期";
            this.dataColRecordDate.ColumnName = "RecordDate";
            this.dataColRecordDate.DataType = typeof(System.DateTime);
            // 
            // dataColumn5
            // 
            this.dataColumn5.Caption = "备注";
            this.dataColumn5.ColumnName = "Remark";
            // 
            // dataColParentAutoQuotationNo
            // 
            this.dataColParentAutoQuotationNo.Caption = "父级报价单号";
            this.dataColParentAutoQuotationNo.ColumnName = "ParentAutoQuotationNo";
            // 
            // dataColuParentAutoSalesOrderNo
            // 
            this.dataColuParentAutoSalesOrderNo.Caption = "父级销售订单号";
            this.dataColuParentAutoSalesOrderNo.ColumnName = "ParentAutoSalesOrderNo";
            // 
            // dataColumn6
            // 
            this.dataColumn6.Caption = "父级项目号";
            this.dataColumn6.ColumnName = "ParentProjectNo";
            // 
            // dataColumn7
            // 
            this.dataColumn7.Caption = "制单人";
            this.dataColumn7.ColumnName = "Prepared";
            // 
            // dataColumn8
            // 
            this.dataColumn8.Caption = "制单人IP";
            this.dataColumn8.ColumnName = "PreparedIp";
            // 
            // dataColumn9
            // 
            this.dataColumn9.Caption = "修改人";
            this.dataColumn9.ColumnName = "Modifier";
            // 
            // dataColumn10
            // 
            this.dataColumn10.Caption = "修改人IP";
            this.dataColumn10.ColumnName = "ModifierIp";
            // 
            // dataColumn11
            // 
            this.dataColumn11.Caption = "修改时间";
            this.dataColumn11.ColumnName = "ModifierTime";
            this.dataColumn11.DataType = typeof(System.DateTime);
            // 
            // gridViewQuotationBaseInfo
            // 
            this.gridViewQuotationBaseInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId,
            this.colAutoQuotationNo,
            this.colRecordDate,
            this.colBussinessBaseNo,
            this.colRepertoryNo,
            this.colRequester,
            this.colRFQNO,
            this.colRemark,
            this.colPrepared,
            this.colModifier,
            this.colModifierTime,
            this.colParentAutoQuotationNo,
            this.colParentAutoSalesOrderNo,
            this.colParentProjectNo});
            this.gridViewQuotationBaseInfo.GridControl = this.gridControlQuotationBaseInfo;
            this.gridViewQuotationBaseInfo.IndicatorWidth = 40;
            this.gridViewQuotationBaseInfo.Name = "gridViewQuotationBaseInfo";
            this.gridViewQuotationBaseInfo.OptionsBehavior.Editable = false;
            this.gridViewQuotationBaseInfo.OptionsBehavior.ReadOnly = true;
            this.gridViewQuotationBaseInfo.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewQuotationBaseInfo.OptionsView.ColumnAutoWidth = false;
            this.gridViewQuotationBaseInfo.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewQuotationBaseInfo.OptionsView.ShowGroupPanel = false;
            this.gridViewQuotationBaseInfo.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewQuotationBaseInfo_RowClick);
            this.gridViewQuotationBaseInfo.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewQuotationBaseInfo_CustomDrawRowIndicator);
            // 
            // colAutoId
            // 
            this.colAutoId.FieldName = "AutoId";
            this.colAutoId.Name = "colAutoId";
            // 
            // colAutoQuotationNo
            // 
            this.colAutoQuotationNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colAutoQuotationNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAutoQuotationNo.FieldName = "AutoQuotationNo";
            this.colAutoQuotationNo.Name = "colAutoQuotationNo";
            this.colAutoQuotationNo.OptionsColumn.AllowEdit = false;
            this.colAutoQuotationNo.OptionsColumn.AllowFocus = false;
            this.colAutoQuotationNo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "WarehouseWarrant", "共计{0}条")});
            this.colAutoQuotationNo.Visible = true;
            this.colAutoQuotationNo.VisibleIndex = 0;
            this.colAutoQuotationNo.Width = 120;
            // 
            // colRecordDate
            // 
            this.colRecordDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colRecordDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRecordDate.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.colRecordDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colRecordDate.FieldName = "RecordDate";
            this.colRecordDate.Name = "colRecordDate";
            this.colRecordDate.OptionsColumn.AllowEdit = false;
            this.colRecordDate.OptionsColumn.AllowFocus = false;
            this.colRecordDate.Visible = true;
            this.colRecordDate.VisibleIndex = 5;
            this.colRecordDate.Width = 130;
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
            // colRepertoryNo
            // 
            this.colRepertoryNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colRepertoryNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRepertoryNo.FieldName = "ProjectName";
            this.colRepertoryNo.Name = "colRepertoryNo";
            this.colRepertoryNo.OptionsColumn.AllowEdit = false;
            this.colRepertoryNo.Visible = true;
            this.colRepertoryNo.VisibleIndex = 2;
            this.colRepertoryNo.Width = 100;
            // 
            // colRequester
            // 
            this.colRequester.AppearanceHeader.Options.UseTextOptions = true;
            this.colRequester.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRequester.FieldName = "Requester";
            this.colRequester.Name = "colRequester";
            this.colRequester.OptionsColumn.AllowEdit = false;
            this.colRequester.Visible = true;
            this.colRequester.VisibleIndex = 4;
            this.colRequester.Width = 80;
            // 
            // colRFQNO
            // 
            this.colRFQNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colRFQNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRFQNO.FieldName = "RFQNO";
            this.colRFQNO.Name = "colRFQNO";
            this.colRFQNO.OptionsColumn.AllowEdit = false;
            this.colRFQNO.OptionsColumn.AllowFocus = false;
            this.colRFQNO.Visible = true;
            this.colRFQNO.VisibleIndex = 1;
            this.colRFQNO.Width = 120;
            // 
            // colRemark
            // 
            this.colRemark.AppearanceHeader.Options.UseTextOptions = true;
            this.colRemark.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.OptionsColumn.AllowEdit = false;
            this.colRemark.OptionsColumn.AllowFocus = false;
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 6;
            this.colRemark.Width = 130;
            // 
            // colPrepared
            // 
            this.colPrepared.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrepared.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrepared.FieldName = "Prepared";
            this.colPrepared.Name = "colPrepared";
            this.colPrepared.Visible = true;
            this.colPrepared.VisibleIndex = 7;
            this.colPrepared.Width = 80;
            // 
            // colModifier
            // 
            this.colModifier.AppearanceHeader.Options.UseTextOptions = true;
            this.colModifier.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colModifier.FieldName = "Modifier";
            this.colModifier.Name = "colModifier";
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
            this.colModifierTime.Width = 130;
            // 
            // colParentAutoQuotationNo
            // 
            this.colParentAutoQuotationNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colParentAutoQuotationNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colParentAutoQuotationNo.FieldName = "ParentAutoQuotationNo";
            this.colParentAutoQuotationNo.Name = "colParentAutoQuotationNo";
            this.colParentAutoQuotationNo.Visible = true;
            this.colParentAutoQuotationNo.VisibleIndex = 8;
            this.colParentAutoQuotationNo.Width = 120;
            // 
            // colParentAutoSalesOrderNo
            // 
            this.colParentAutoSalesOrderNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colParentAutoSalesOrderNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colParentAutoSalesOrderNo.FieldName = "ParentAutoSalesOrderNo";
            this.colParentAutoSalesOrderNo.Name = "colParentAutoSalesOrderNo";
            this.colParentAutoSalesOrderNo.Visible = true;
            this.colParentAutoSalesOrderNo.VisibleIndex = 9;
            this.colParentAutoSalesOrderNo.Width = 120;
            // 
            // colParentProjectNo
            // 
            this.colParentProjectNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colParentProjectNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colParentProjectNo.FieldName = "ParentProjectNo";
            this.colParentProjectNo.Name = "colParentProjectNo";
            this.colParentProjectNo.Visible = true;
            this.colParentProjectNo.VisibleIndex = 10;
            this.colParentProjectNo.Width = 100;
            // 
            // repCheckSelect
            // 
            this.repCheckSelect.AutoHeight = false;
            this.repCheckSelect.Name = "repCheckSelect";
            this.repCheckSelect.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repCheckSelect.ValueGrayed = false;
            // 
            // pnlGridTop
            // 
            this.pnlGridTop.Controls.Add(this.btnQuery);
            this.pnlGridTop.Controls.Add(this.textCommon);
            this.pnlGridTop.Controls.Add(this.labCommon);
            this.pnlGridTop.Controls.Add(this.searchLookUpBussinessBaseNo);
            this.pnlGridTop.Controls.Add(this.labelControl1);
            this.pnlGridTop.Controls.Add(this.dateRecordDateEnd);
            this.pnlGridTop.Controls.Add(this.dateRecordDateBegin);
            this.pnlGridTop.Controls.Add(this.lab1);
            this.pnlGridTop.Controls.Add(this.labRecordDate);
            this.pnlGridTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGridTop.Location = new System.Drawing.Point(0, 0);
            this.pnlGridTop.Name = "pnlGridTop";
            this.pnlGridTop.Size = new System.Drawing.Size(1295, 40);
            this.pnlGridTop.TabIndex = 0;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(819, 9);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 54;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // textCommon
            // 
            this.textCommon.EnterMoveNextControl = true;
            this.textCommon.Location = new System.Drawing.Point(637, 10);
            this.textCommon.Name = "textCommon";
            this.textCommon.Size = new System.Drawing.Size(150, 20);
            this.textCommon.TabIndex = 53;
            // 
            // labCommon
            // 
            this.labCommon.Location = new System.Drawing.Point(571, 13);
            this.labCommon.Name = "labCommon";
            this.labCommon.Size = new System.Drawing.Size(60, 14);
            this.labCommon.TabIndex = 24;
            this.labCommon.Text = "通用查询：";
            // 
            // searchLookUpBussinessBaseNo
            // 
            this.searchLookUpBussinessBaseNo.EnterMoveNextControl = true;
            this.searchLookUpBussinessBaseNo.Location = new System.Drawing.Point(386, 10);
            this.searchLookUpBussinessBaseNo.Name = "searchLookUpBussinessBaseNo";
            this.searchLookUpBussinessBaseNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpBussinessBaseNo.Properties.DisplayMember = "BussinessBaseText";
            this.searchLookUpBussinessBaseNo.Properties.NullText = "";
            this.searchLookUpBussinessBaseNo.Properties.ValueMember = "BussinessBaseNo";
            this.searchLookUpBussinessBaseNo.Properties.View = this.searchLookUpBussinessBaseNoView;
            this.searchLookUpBussinessBaseNo.Size = new System.Drawing.Size(150, 20);
            this.searchLookUpBussinessBaseNo.TabIndex = 52;
            // 
            // searchLookUpBussinessBaseNoView
            // 
            this.searchLookUpBussinessBaseNoView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.searchLookUpBussinessBaseNoView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpBussinessBaseNoView.IndicatorWidth = 60;
            this.searchLookUpBussinessBaseNoView.Name = "searchLookUpBussinessBaseNoView";
            this.searchLookUpBussinessBaseNoView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpBussinessBaseNoView.OptionsView.ShowGroupPanel = false;
            this.searchLookUpBussinessBaseNoView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewQuotationBaseInfo_CustomDrawRowIndicator);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "往来方编号";
            this.gridColumn1.FieldName = "BussinessBaseNo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "往来方名称";
            this.gridColumn2.FieldName = "BussinessBaseText";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "往来方分类";
            this.gridColumn3.FieldName = "BussinessCategoryText";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "gridColumnAutoId";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(344, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 14);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "客户：";
            // 
            // dateRecordDateEnd
            // 
            this.dateRecordDateEnd.EditValue = null;
            this.dateRecordDateEnd.EnterMoveNextControl = true;
            this.dateRecordDateEnd.Location = new System.Drawing.Point(215, 10);
            this.dateRecordDateEnd.Name = "dateRecordDateEnd";
            this.dateRecordDateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateRecordDateEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateRecordDateEnd.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dateRecordDateEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateRecordDateEnd.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateRecordDateEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateRecordDateEnd.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateRecordDateEnd.Size = new System.Drawing.Size(100, 20);
            this.dateRecordDateEnd.TabIndex = 51;
            // 
            // dateRecordDateBegin
            // 
            this.dateRecordDateBegin.EditValue = null;
            this.dateRecordDateBegin.EnterMoveNextControl = true;
            this.dateRecordDateBegin.Location = new System.Drawing.Point(99, 10);
            this.dateRecordDateBegin.Name = "dateRecordDateBegin";
            this.dateRecordDateBegin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateRecordDateBegin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateRecordDateBegin.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dateRecordDateBegin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateRecordDateBegin.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateRecordDateBegin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateRecordDateBegin.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateRecordDateBegin.Size = new System.Drawing.Size(100, 20);
            this.dateRecordDateBegin.TabIndex = 50;
            // 
            // lab1
            // 
            this.lab1.Location = new System.Drawing.Point(205, 13);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(4, 14);
            this.lab1.TabIndex = 10;
            this.lab1.Text = "-";
            // 
            // labRecordDate
            // 
            this.labRecordDate.Location = new System.Drawing.Point(33, 13);
            this.labRecordDate.Name = "labRecordDate";
            this.labRecordDate.Size = new System.Drawing.Size(48, 14);
            this.labRecordDate.TabIndex = 9;
            this.labRecordDate.Text = "登记日期";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.textParentProjectNo);
            this.panelControl1.Controls.Add(this.labParentProjectNo);
            this.panelControl1.Controls.Add(this.textParentAutoSalesOrderNo);
            this.panelControl1.Controls.Add(this.labParentAutoSalesOrderNo);
            this.panelControl1.Controls.Add(this.lookUpQuotationVersions);
            this.panelControl1.Controls.Add(this.labMemo);
            this.panelControl1.Controls.Add(this.textAutoQuotationNo);
            this.panelControl1.Controls.Add(this.labIsEnd);
            this.panelControl1.Controls.Add(this.checkIsEnd);
            this.panelControl1.Controls.Add(this.labQuotationVersions);
            this.panelControl1.Controls.Add(this.labAutoQuotationNo);
            this.panelControl1.Controls.Add(this.labTax);
            this.panelControl1.Controls.Add(this.spinTax);
            this.panelControl1.Controls.Add(this.labSumAmount);
            this.panelControl1.Controls.Add(this.spinSumAmount);
            this.panelControl1.Controls.Add(this.labTaxAmount);
            this.panelControl1.Controls.Add(this.spinTaxAmount);
            this.panelControl1.Controls.Add(this.labAmount);
            this.panelControl1.Controls.Add(this.spinAmount);
            this.panelControl1.Controls.Add(this.labCollectionTypeNo);
            this.panelControl1.Controls.Add(this.lookUpCollectionTypeNo);
            this.panelControl1.Controls.Add(this.textModifier);
            this.panelControl1.Controls.Add(this.textPrepared);
            this.panelControl1.Controls.Add(this.dateModifierTime);
            this.panelControl1.Controls.Add(this.labModifierTime);
            this.panelControl1.Controls.Add(this.labModifier);
            this.panelControl1.Controls.Add(this.labPrepared);
            this.panelControl1.Controls.Add(this.labSalesOrderDate);
            this.panelControl1.Controls.Add(this.dateSalesOrderDate);
            this.panelControl1.Controls.Add(this.textRemark);
            this.panelControl1.Controls.Add(this.labRemark);
            this.panelControl1.Controls.Add(this.textProjectLeader);
            this.panelControl1.Controls.Add(this.labProjectLeader);
            this.panelControl1.Controls.Add(this.labBussinessBaseNo);
            this.panelControl1.Controls.Add(this.labProjectName);
            this.panelControl1.Controls.Add(this.searchBussinessBaseNo);
            this.panelControl1.Controls.Add(this.searchProjectName);
            this.panelControl1.Controls.Add(this.textCustomerPoNo);
            this.panelControl1.Controls.Add(this.labCustomerPoNo);
            this.panelControl1.Controls.Add(this.textAutoSalesOrderNo);
            this.panelControl1.Controls.Add(this.labAutoSalesOrderNo);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 40);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1305, 231);
            this.panelControl1.TabIndex = 8;
            // 
            // textParentProjectNo
            // 
            this.textParentProjectNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_SalesOrder, "ParentProjectNo", true));
            this.textParentProjectNo.EnterMoveNextControl = true;
            this.textParentProjectNo.Location = new System.Drawing.Point(1107, 55);
            this.textParentProjectNo.Name = "textParentProjectNo";
            this.textParentProjectNo.Properties.ReadOnly = true;
            this.textParentProjectNo.Size = new System.Drawing.Size(150, 20);
            this.textParentProjectNo.TabIndex = 19;
            this.textParentProjectNo.TabStop = false;
            this.textParentProjectNo.Visible = false;
            // 
            // labParentProjectNo
            // 
            this.labParentProjectNo.Location = new System.Drawing.Point(1012, 58);
            this.labParentProjectNo.Name = "labParentProjectNo";
            this.labParentProjectNo.Size = new System.Drawing.Size(60, 14);
            this.labParentProjectNo.TabIndex = 44;
            this.labParentProjectNo.Text = "父级项目号";
            this.labParentProjectNo.Visible = false;
            // 
            // textParentAutoSalesOrderNo
            // 
            this.textParentAutoSalesOrderNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_SalesOrder, "ParentAutoSalesOrderNo", true));
            this.textParentAutoSalesOrderNo.EnterMoveNextControl = true;
            this.textParentAutoSalesOrderNo.Location = new System.Drawing.Point(1107, 21);
            this.textParentAutoSalesOrderNo.Name = "textParentAutoSalesOrderNo";
            this.textParentAutoSalesOrderNo.Properties.ReadOnly = true;
            this.textParentAutoSalesOrderNo.Size = new System.Drawing.Size(150, 20);
            this.textParentAutoSalesOrderNo.TabIndex = 18;
            this.textParentAutoSalesOrderNo.TabStop = false;
            this.textParentAutoSalesOrderNo.Visible = false;
            // 
            // labParentAutoSalesOrderNo
            // 
            this.labParentAutoSalesOrderNo.Location = new System.Drawing.Point(1012, 24);
            this.labParentAutoSalesOrderNo.Name = "labParentAutoSalesOrderNo";
            this.labParentAutoSalesOrderNo.Size = new System.Drawing.Size(84, 14);
            this.labParentAutoSalesOrderNo.TabIndex = 43;
            this.labParentAutoSalesOrderNo.Text = "父级销售订单号";
            this.labParentAutoSalesOrderNo.Visible = false;
            // 
            // lookUpQuotationVersions
            // 
            this.lookUpQuotationVersions.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_SalesOrder, "QuotationVersions", true));
            this.lookUpQuotationVersions.EnterMoveNextControl = true;
            this.lookUpQuotationVersions.Location = new System.Drawing.Point(354, 55);
            this.lookUpQuotationVersions.Name = "lookUpQuotationVersions";
            this.lookUpQuotationVersions.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpQuotationVersions.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Versions", "版本号"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Amount", "金额"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QuotationDate", "报价日期", 20, DevExpress.Utils.FormatType.DateTime, "yyyy-MM-dd", true, DevExpress.Utils.HorzAlignment.Default)});
            this.lookUpQuotationVersions.Properties.DisplayMember = "Versions";
            this.lookUpQuotationVersions.Properties.DropDownRows = 12;
            this.lookUpQuotationVersions.Properties.NullText = "";
            this.lookUpQuotationVersions.Properties.PopupWidth = 300;
            this.lookUpQuotationVersions.Properties.ValueMember = "Versions";
            this.lookUpQuotationVersions.Size = new System.Drawing.Size(150, 20);
            this.lookUpQuotationVersions.TabIndex = 5;
            this.lookUpQuotationVersions.EditValueChanged += new System.EventHandler(this.lookUpQuotationVersions_EditValueChanged);
            // 
            // labMemo
            // 
            this.labMemo.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labMemo.Location = new System.Drawing.Point(36, 194);
            this.labMemo.Name = "labMemo";
            this.labMemo.Size = new System.Drawing.Size(300, 14);
            this.labMemo.TabIndex = 40;
            this.labMemo.Text = "（请在下方查询报价单区域中，查询后双击选择报价单）";
            // 
            // textAutoQuotationNo
            // 
            this.textAutoQuotationNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_SalesOrder, "AutoQuotationNo", true));
            this.textAutoQuotationNo.EnterMoveNextControl = true;
            this.textAutoQuotationNo.Location = new System.Drawing.Point(597, 21);
            this.textAutoQuotationNo.Name = "textAutoQuotationNo";
            this.textAutoQuotationNo.Properties.NullText = "请在下面列表中选择报价单";
            this.textAutoQuotationNo.Properties.ReadOnly = true;
            this.textAutoQuotationNo.Size = new System.Drawing.Size(150, 20);
            this.textAutoQuotationNo.TabIndex = 2;
            this.textAutoQuotationNo.EditValueChanged += new System.EventHandler(this.textAutoQuotationNo_EditValueChanged);
            // 
            // labIsEnd
            // 
            this.labIsEnd.Location = new System.Drawing.Point(770, 126);
            this.labIsEnd.Name = "labIsEnd";
            this.labIsEnd.Size = new System.Drawing.Size(48, 14);
            this.labIsEnd.TabIndex = 38;
            this.labIsEnd.Text = "结账完毕";
            // 
            // checkIsEnd
            // 
            this.checkIsEnd.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_SalesOrder, "IsEnd", true));
            this.checkIsEnd.EnterMoveNextControl = true;
            this.checkIsEnd.Location = new System.Drawing.Point(857, 123);
            this.checkIsEnd.Name = "checkIsEnd";
            this.checkIsEnd.Properties.Caption = "";
            this.checkIsEnd.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.checkIsEnd.Properties.ReadOnly = true;
            this.checkIsEnd.Properties.ValueGrayed = false;
            this.checkIsEnd.Size = new System.Drawing.Size(33, 19);
            this.checkIsEnd.TabIndex = 14;
            this.checkIsEnd.TabStop = false;
            // 
            // labQuotationVersions
            // 
            this.labQuotationVersions.Location = new System.Drawing.Point(281, 58);
            this.labQuotationVersions.Name = "labQuotationVersions";
            this.labQuotationVersions.Size = new System.Drawing.Size(60, 14);
            this.labQuotationVersions.TabIndex = 36;
            this.labQuotationVersions.Text = "报价单版本";
            // 
            // labAutoQuotationNo
            // 
            this.labAutoQuotationNo.Location = new System.Drawing.Point(525, 24);
            this.labAutoQuotationNo.Name = "labAutoQuotationNo";
            this.labAutoQuotationNo.Size = new System.Drawing.Size(48, 14);
            this.labAutoQuotationNo.TabIndex = 33;
            this.labAutoQuotationNo.Text = "报价单号";
            // 
            // labTax
            // 
            this.labTax.Location = new System.Drawing.Point(281, 92);
            this.labTax.Name = "labTax";
            this.labTax.Size = new System.Drawing.Size(24, 14);
            this.labTax.TabIndex = 32;
            this.labTax.Text = "税率";
            // 
            // spinTax
            // 
            this.spinTax.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_SalesOrder, "Tax", true));
            this.spinTax.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinTax.EnterMoveNextControl = true;
            this.spinTax.Location = new System.Drawing.Point(354, 89);
            this.spinTax.Name = "spinTax";
            this.spinTax.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinTax.Properties.DisplayFormat.FormatString = "p0";
            this.spinTax.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinTax.Properties.EditFormat.FormatString = "p0";
            this.spinTax.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinTax.Properties.Mask.EditMask = "p0";
            this.spinTax.Size = new System.Drawing.Size(150, 20);
            this.spinTax.TabIndex = 9;
            this.spinTax.EditValueChanged += new System.EventHandler(this.spinAmount_EditValueChanged);
            // 
            // labSumAmount
            // 
            this.labSumAmount.Location = new System.Drawing.Point(770, 92);
            this.labSumAmount.Name = "labSumAmount";
            this.labSumAmount.Size = new System.Drawing.Size(48, 14);
            this.labSumAmount.TabIndex = 30;
            this.labSumAmount.Text = "价税合计";
            // 
            // spinSumAmount
            // 
            this.spinSumAmount.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_SalesOrder, "SumAmount", true));
            this.spinSumAmount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinSumAmount.EnterMoveNextControl = true;
            this.spinSumAmount.Location = new System.Drawing.Point(839, 89);
            this.spinSumAmount.Name = "spinSumAmount";
            this.spinSumAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinSumAmount.Properties.DisplayFormat.FormatString = "N2";
            this.spinSumAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinSumAmount.Properties.EditFormat.FormatString = "N2";
            this.spinSumAmount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinSumAmount.Properties.Mask.EditMask = "N2";
            this.spinSumAmount.Properties.ReadOnly = true;
            this.spinSumAmount.Size = new System.Drawing.Size(150, 20);
            this.spinSumAmount.TabIndex = 11;
            this.spinSumAmount.TabStop = false;
            // 
            // labTaxAmount
            // 
            this.labTaxAmount.Location = new System.Drawing.Point(525, 92);
            this.labTaxAmount.Name = "labTaxAmount";
            this.labTaxAmount.Size = new System.Drawing.Size(24, 14);
            this.labTaxAmount.TabIndex = 28;
            this.labTaxAmount.Text = "税额";
            // 
            // spinTaxAmount
            // 
            this.spinTaxAmount.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_SalesOrder, "TaxAmount", true));
            this.spinTaxAmount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinTaxAmount.EnterMoveNextControl = true;
            this.spinTaxAmount.Location = new System.Drawing.Point(597, 89);
            this.spinTaxAmount.Name = "spinTaxAmount";
            this.spinTaxAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinTaxAmount.Properties.DisplayFormat.FormatString = "N2";
            this.spinTaxAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinTaxAmount.Properties.EditFormat.FormatString = "N2";
            this.spinTaxAmount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinTaxAmount.Properties.Mask.EditMask = "N2";
            this.spinTaxAmount.Properties.ReadOnly = true;
            this.spinTaxAmount.Size = new System.Drawing.Size(150, 20);
            this.spinTaxAmount.TabIndex = 10;
            this.spinTaxAmount.TabStop = false;
            // 
            // labAmount
            // 
            this.labAmount.Location = new System.Drawing.Point(36, 92);
            this.labAmount.Name = "labAmount";
            this.labAmount.Size = new System.Drawing.Size(24, 14);
            this.labAmount.TabIndex = 26;
            this.labAmount.Text = "金额";
            // 
            // spinAmount
            // 
            this.spinAmount.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_SalesOrder, "Amount", true));
            this.spinAmount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinAmount.EnterMoveNextControl = true;
            this.spinAmount.Location = new System.Drawing.Point(112, 89);
            this.spinAmount.Name = "spinAmount";
            this.spinAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinAmount.Properties.DisplayFormat.FormatString = "N2";
            this.spinAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinAmount.Properties.EditFormat.FormatString = "N2";
            this.spinAmount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinAmount.Properties.Mask.EditMask = "N2";
            this.spinAmount.Size = new System.Drawing.Size(150, 20);
            this.spinAmount.TabIndex = 8;
            this.spinAmount.EditValueChanged += new System.EventHandler(this.spinAmount_EditValueChanged);
            // 
            // labCollectionTypeNo
            // 
            this.labCollectionTypeNo.Location = new System.Drawing.Point(770, 58);
            this.labCollectionTypeNo.Name = "labCollectionTypeNo";
            this.labCollectionTypeNo.Size = new System.Drawing.Size(48, 14);
            this.labCollectionTypeNo.TabIndex = 24;
            this.labCollectionTypeNo.Text = "收款方式";
            // 
            // lookUpCollectionTypeNo
            // 
            this.lookUpCollectionTypeNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_SalesOrder, "CollectionTypeNo", true));
            this.lookUpCollectionTypeNo.EnterMoveNextControl = true;
            this.lookUpCollectionTypeNo.Location = new System.Drawing.Point(839, 55);
            this.lookUpCollectionTypeNo.Name = "lookUpCollectionTypeNo";
            this.lookUpCollectionTypeNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpCollectionTypeNo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AutoId", "AutoId", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CollectionTypeNo", "收款方式编号"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CollectionTypeNoText", "收款方式名称")});
            this.lookUpCollectionTypeNo.Properties.DisplayMember = "CollectionTypeNoText";
            this.lookUpCollectionTypeNo.Properties.NullText = "";
            this.lookUpCollectionTypeNo.Properties.ValueMember = "CollectionTypeNo";
            this.lookUpCollectionTypeNo.Size = new System.Drawing.Size(150, 20);
            this.lookUpCollectionTypeNo.TabIndex = 7;
            // 
            // textModifier
            // 
            this.textModifier.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_SalesOrder, "Modifier", true));
            this.textModifier.EnterMoveNextControl = true;
            this.textModifier.Location = new System.Drawing.Point(354, 157);
            this.textModifier.Name = "textModifier";
            this.textModifier.Properties.ReadOnly = true;
            this.textModifier.Size = new System.Drawing.Size(150, 20);
            this.textModifier.TabIndex = 16;
            this.textModifier.TabStop = false;
            // 
            // textPrepared
            // 
            this.textPrepared.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_SalesOrder, "Prepared", true));
            this.textPrepared.EnterMoveNextControl = true;
            this.textPrepared.Location = new System.Drawing.Point(112, 157);
            this.textPrepared.Name = "textPrepared";
            this.textPrepared.Properties.ReadOnly = true;
            this.textPrepared.Size = new System.Drawing.Size(150, 20);
            this.textPrepared.TabIndex = 15;
            this.textPrepared.TabStop = false;
            // 
            // dateModifierTime
            // 
            this.dateModifierTime.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_SalesOrder, "ModifierTime", true));
            this.dateModifierTime.EditValue = null;
            this.dateModifierTime.EnterMoveNextControl = true;
            this.dateModifierTime.Location = new System.Drawing.Point(597, 157);
            this.dateModifierTime.Name = "dateModifierTime";
            this.dateModifierTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateModifierTime.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateModifierTime.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dateModifierTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateModifierTime.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dateModifierTime.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateModifierTime.Properties.Mask.EditMask = "G";
            this.dateModifierTime.Properties.ReadOnly = true;
            this.dateModifierTime.Size = new System.Drawing.Size(150, 20);
            this.dateModifierTime.TabIndex = 17;
            this.dateModifierTime.TabStop = false;
            // 
            // labModifierTime
            // 
            this.labModifierTime.Location = new System.Drawing.Point(525, 160);
            this.labModifierTime.Name = "labModifierTime";
            this.labModifierTime.Size = new System.Drawing.Size(48, 14);
            this.labModifierTime.TabIndex = 17;
            this.labModifierTime.Text = "修改时间";
            // 
            // labModifier
            // 
            this.labModifier.Location = new System.Drawing.Point(281, 160);
            this.labModifier.Name = "labModifier";
            this.labModifier.Size = new System.Drawing.Size(36, 14);
            this.labModifier.TabIndex = 16;
            this.labModifier.Text = "修改人";
            // 
            // labPrepared
            // 
            this.labPrepared.Location = new System.Drawing.Point(36, 160);
            this.labPrepared.Name = "labPrepared";
            this.labPrepared.Size = new System.Drawing.Size(36, 14);
            this.labPrepared.TabIndex = 14;
            this.labPrepared.Text = "制单人";
            // 
            // labSalesOrderDate
            // 
            this.labSalesOrderDate.Location = new System.Drawing.Point(281, 24);
            this.labSalesOrderDate.Name = "labSalesOrderDate";
            this.labSalesOrderDate.Size = new System.Drawing.Size(48, 14);
            this.labSalesOrderDate.TabIndex = 13;
            this.labSalesOrderDate.Text = "登记日期";
            // 
            // dateSalesOrderDate
            // 
            this.dateSalesOrderDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_SalesOrder, "SalesOrderDate", true));
            this.dateSalesOrderDate.EditValue = null;
            this.dateSalesOrderDate.EnterMoveNextControl = true;
            this.dateSalesOrderDate.Location = new System.Drawing.Point(354, 21);
            this.dateSalesOrderDate.Name = "dateSalesOrderDate";
            this.dateSalesOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSalesOrderDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSalesOrderDate.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dateSalesOrderDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateSalesOrderDate.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dateSalesOrderDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateSalesOrderDate.Properties.Mask.EditMask = "G";
            this.dateSalesOrderDate.Properties.ReadOnly = true;
            this.dateSalesOrderDate.Size = new System.Drawing.Size(150, 20);
            this.dateSalesOrderDate.TabIndex = 1;
            this.dateSalesOrderDate.TabStop = false;
            // 
            // textRemark
            // 
            this.textRemark.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_SalesOrder, "Remark", true));
            this.textRemark.EnterMoveNextControl = true;
            this.textRemark.Location = new System.Drawing.Point(354, 123);
            this.textRemark.Name = "textRemark";
            this.textRemark.Size = new System.Drawing.Size(393, 20);
            this.textRemark.TabIndex = 13;
            // 
            // labRemark
            // 
            this.labRemark.Location = new System.Drawing.Point(281, 126);
            this.labRemark.Name = "labRemark";
            this.labRemark.Size = new System.Drawing.Size(24, 14);
            this.labRemark.TabIndex = 10;
            this.labRemark.Text = "备注";
            // 
            // textProjectLeader
            // 
            this.textProjectLeader.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_SalesOrder, "ProjectLeader", true));
            this.textProjectLeader.EnterMoveNextControl = true;
            this.textProjectLeader.Location = new System.Drawing.Point(112, 123);
            this.textProjectLeader.Name = "textProjectLeader";
            this.textProjectLeader.Size = new System.Drawing.Size(150, 20);
            this.textProjectLeader.TabIndex = 12;
            // 
            // labProjectLeader
            // 
            this.labProjectLeader.Location = new System.Drawing.Point(36, 126);
            this.labProjectLeader.Name = "labProjectLeader";
            this.labProjectLeader.Size = new System.Drawing.Size(60, 14);
            this.labProjectLeader.TabIndex = 8;
            this.labProjectLeader.Text = "项目负责人";
            // 
            // labBussinessBaseNo
            // 
            this.labBussinessBaseNo.Location = new System.Drawing.Point(770, 24);
            this.labBussinessBaseNo.Name = "labBussinessBaseNo";
            this.labBussinessBaseNo.Size = new System.Drawing.Size(36, 14);
            this.labBussinessBaseNo.TabIndex = 7;
            this.labBussinessBaseNo.Text = "往来方";
            // 
            // labProjectName
            // 
            this.labProjectName.Location = new System.Drawing.Point(36, 58);
            this.labProjectName.Name = "labProjectName";
            this.labProjectName.Size = new System.Drawing.Size(48, 14);
            this.labProjectName.TabIndex = 6;
            this.labProjectName.Text = "项目名称";
            // 
            // searchBussinessBaseNo
            // 
            this.searchBussinessBaseNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_SalesOrder, "BussinessBaseNo", true));
            this.searchBussinessBaseNo.EnterMoveNextControl = true;
            this.searchBussinessBaseNo.Location = new System.Drawing.Point(839, 21);
            this.searchBussinessBaseNo.Name = "searchBussinessBaseNo";
            this.searchBussinessBaseNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchBussinessBaseNo.Properties.DisplayMember = "BussinessBaseText";
            this.searchBussinessBaseNo.Properties.NullText = "";
            this.searchBussinessBaseNo.Properties.ReadOnly = true;
            this.searchBussinessBaseNo.Properties.ValueMember = "BussinessBaseNo";
            this.searchBussinessBaseNo.Properties.View = this.searchBussinessBaseNoView;
            this.searchBussinessBaseNo.Size = new System.Drawing.Size(150, 20);
            this.searchBussinessBaseNo.TabIndex = 3;
            // 
            // searchBussinessBaseNoView
            // 
            this.searchBussinessBaseNoView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnBussinessBaseNo,
            this.gridColumnBussinessBaseText,
            this.gridColumnBussinessCategoryText,
            this.gridColumnAutoId});
            this.searchBussinessBaseNoView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchBussinessBaseNoView.IndicatorWidth = 60;
            this.searchBussinessBaseNoView.Name = "searchBussinessBaseNoView";
            this.searchBussinessBaseNoView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchBussinessBaseNoView.OptionsView.ShowGroupPanel = false;
            this.searchBussinessBaseNoView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewQuotationBaseInfo_CustomDrawRowIndicator);
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
            // searchProjectName
            // 
            this.searchProjectName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_SalesOrder, "ProjectNo", true));
            this.searchProjectName.EnterMoveNextControl = true;
            this.searchProjectName.Location = new System.Drawing.Point(112, 55);
            this.searchProjectName.Margin = new System.Windows.Forms.Padding(4);
            this.searchProjectName.Name = "searchProjectName";
            this.searchProjectName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchProjectName.Properties.DisplayMember = "ProjectName";
            this.searchProjectName.Properties.NullText = "";
            this.searchProjectName.Properties.ValueMember = "ProjectNo";
            this.searchProjectName.Properties.View = this.searchProjectNameView;
            this.searchProjectName.Size = new System.Drawing.Size(150, 20);
            this.searchProjectName.TabIndex = 4;
            // 
            // searchProjectNameView
            // 
            this.searchProjectNameView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColProjectNo,
            this.gridColProjectName,
            this.gridColRemark});
            this.searchProjectNameView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchProjectNameView.IndicatorWidth = 60;
            this.searchProjectNameView.Name = "searchProjectNameView";
            this.searchProjectNameView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchProjectNameView.OptionsView.ShowGroupPanel = false;
            this.searchProjectNameView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewQuotationBaseInfo_CustomDrawRowIndicator);
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
            // textCustomerPoNo
            // 
            this.textCustomerPoNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_SalesOrder, "CustomerPoNo", true));
            this.textCustomerPoNo.EnterMoveNextControl = true;
            this.textCustomerPoNo.Location = new System.Drawing.Point(597, 55);
            this.textCustomerPoNo.Name = "textCustomerPoNo";
            this.textCustomerPoNo.Size = new System.Drawing.Size(150, 20);
            this.textCustomerPoNo.TabIndex = 6;
            // 
            // labCustomerPoNo
            // 
            this.labCustomerPoNo.Location = new System.Drawing.Point(525, 58);
            this.labCustomerPoNo.Name = "labCustomerPoNo";
            this.labCustomerPoNo.Size = new System.Drawing.Size(64, 14);
            this.labCustomerPoNo.TabIndex = 2;
            this.labCustomerPoNo.Text = "客户PO单号";
            // 
            // textAutoSalesOrderNo
            // 
            this.textAutoSalesOrderNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_SalesOrder, "AutoSalesOrderNo", true));
            this.textAutoSalesOrderNo.EnterMoveNextControl = true;
            this.textAutoSalesOrderNo.Location = new System.Drawing.Point(112, 21);
            this.textAutoSalesOrderNo.Name = "textAutoSalesOrderNo";
            this.textAutoSalesOrderNo.Properties.ReadOnly = true;
            this.textAutoSalesOrderNo.Size = new System.Drawing.Size(150, 20);
            this.textAutoSalesOrderNo.TabIndex = 0;
            this.textAutoSalesOrderNo.TabStop = false;
            // 
            // labAutoSalesOrderNo
            // 
            this.labAutoSalesOrderNo.Location = new System.Drawing.Point(36, 24);
            this.labAutoSalesOrderNo.Name = "labAutoSalesOrderNo";
            this.labAutoSalesOrderNo.Size = new System.Drawing.Size(60, 14);
            this.labAutoSalesOrderNo.TabIndex = 0;
            this.labAutoSalesOrderNo.Text = "销售订单号";
            // 
            // pnlToolBar
            // 
            this.pnlToolBar.Controls.Add(this.BtnCOR);
            this.pnlToolBar.Controls.Add(this.btnPreview);
            this.pnlToolBar.Controls.Add(this.btnEditQueryAutoSalesOrderNo);
            this.pnlToolBar.Controls.Add(this.labQueryAutoQuotationNo);
            this.pnlToolBar.Controls.Add(this.btnRefresh);
            this.pnlToolBar.Controls.Add(this.btnDelete);
            this.pnlToolBar.Controls.Add(this.btnCancel);
            this.pnlToolBar.Controls.Add(this.btnSave);
            this.pnlToolBar.Controls.Add(this.btnNew);
            this.pnlToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolBar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolBar.Name = "pnlToolBar";
            this.pnlToolBar.Size = new System.Drawing.Size(1305, 40);
            this.pnlToolBar.TabIndex = 7;
            // 
            // BtnCOR
            // 
            this.BtnCOR.Location = new System.Drawing.Point(496, 9);
            this.BtnCOR.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCOR.Name = "BtnCOR";
            this.BtnCOR.Size = new System.Drawing.Size(75, 23);
            this.BtnCOR.TabIndex = 27;
            this.BtnCOR.TabStop = false;
            this.BtnCOR.Text = "COR报价单";
            this.BtnCOR.Click += new System.EventHandler(this.BtnCOR_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(415, 9);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(4);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 26;
            this.btnPreview.TabStop = false;
            this.btnPreview.Text = "预览";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnEditQueryAutoSalesOrderNo
            // 
            this.btnEditQueryAutoSalesOrderNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditQueryAutoSalesOrderNo.Location = new System.Drawing.Point(1105, 10);
            this.btnEditQueryAutoSalesOrderNo.Name = "btnEditQueryAutoSalesOrderNo";
            this.btnEditQueryAutoSalesOrderNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});
            this.btnEditQueryAutoSalesOrderNo.Properties.NullValuePrompt = "请输入销售订单号....";
            this.btnEditQueryAutoSalesOrderNo.Properties.NullValuePromptShowForEmptyValue = true;
            this.btnEditQueryAutoSalesOrderNo.Size = new System.Drawing.Size(180, 20);
            this.btnEditQueryAutoSalesOrderNo.TabIndex = 100;
            this.btnEditQueryAutoSalesOrderNo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnEditQueryAutoSalesOrderNo_ButtonClick);
            this.btnEditQueryAutoSalesOrderNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnEditQueryAutoSalesOrderNo_KeyDown);
            // 
            // labQueryAutoQuotationNo
            // 
            this.labQueryAutoQuotationNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labQueryAutoQuotationNo.Location = new System.Drawing.Point(1030, 13);
            this.labQueryAutoQuotationNo.Name = "labQueryAutoQuotationNo";
            this.labQueryAutoQuotationNo.Size = new System.Drawing.Size(60, 14);
            this.labQueryAutoQuotationNo.TabIndex = 20;
            this.labQueryAutoQuotationNo.Text = "销售订单号";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(334, 9);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(253, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(172, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(91, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "修改";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(10, 9);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 14;
            this.btnNew.TabStop = false;
            this.btnNew.Text = "新增";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // FrmSalesOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1305, 611);
            this.Controls.Add(this.pnlRight);
            this.Name = "FrmSalesOrder";
            this.TabText = "销售订单";
            this.Text = "销售订单";
            this.Activated += new System.EventHandler(this.FrmSalesOrder_Activated);
            this.Load += new System.EventHandler(this.FrmSalesOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_SalesOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableSalesOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_SalesOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).EndInit();
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabGrid)).EndInit();
            this.xtraTabGrid.ResumeLayout(false);
            this.PageQuotationBaseInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlQuotationBaseInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_BaseInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Quotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableQuotationBaseInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewQuotationBaseInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchBussinessBaseNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGridTop)).EndInit();
            this.pnlGridTop.ResumeLayout(false);
            this.pnlGridTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textCommon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpBussinessBaseNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpBussinessBaseNoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRecordDateEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRecordDateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRecordDateBegin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRecordDateBegin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textParentProjectNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textParentAutoSalesOrderNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpQuotationVersions.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAutoQuotationNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkIsEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSumAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTaxAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCollectionTypeNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textModifier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPrepared.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateModifierTime.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateModifierTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSalesOrderDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSalesOrderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textProjectLeader.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBussinessBaseNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBussinessBaseNoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchProjectName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchProjectNameView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCustomerPoNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAutoSalesOrderNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).EndInit();
            this.pnlToolBar.ResumeLayout(false);
            this.pnlToolBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditQueryAutoSalesOrderNo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.BindingSource bindingSource_SalesOrder;
        private DevExpress.XtraEditors.PanelControl pnlRight;
        private DevExpress.XtraEditors.PanelControl pnlToolBar;
        private DevExpress.XtraEditors.SimpleButton btnPreview;
        private DevExpress.XtraEditors.ButtonEdit btnEditQueryAutoSalesOrderNo;
        private DevExpress.XtraEditors.LabelControl labQueryAutoQuotationNo;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit textModifier;
        private DevExpress.XtraEditors.TextEdit textPrepared;
        private DevExpress.XtraEditors.DateEdit dateModifierTime;
        private DevExpress.XtraEditors.LabelControl labModifierTime;
        private DevExpress.XtraEditors.LabelControl labModifier;
        private DevExpress.XtraEditors.LabelControl labPrepared;
        private DevExpress.XtraEditors.LabelControl labSalesOrderDate;
        private DevExpress.XtraEditors.DateEdit dateSalesOrderDate;
        private DevExpress.XtraEditors.TextEdit textRemark;
        private DevExpress.XtraEditors.LabelControl labRemark;
        private DevExpress.XtraEditors.TextEdit textProjectLeader;
        private DevExpress.XtraEditors.LabelControl labProjectLeader;
        private DevExpress.XtraEditors.LabelControl labBussinessBaseNo;
        private DevExpress.XtraEditors.LabelControl labProjectName;
        private DevExpress.XtraEditors.SearchLookUpEdit searchBussinessBaseNo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchBussinessBaseNoView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBussinessBaseNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBussinessBaseText;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBussinessCategoryText;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnAutoId;
        private DevExpress.XtraEditors.SearchLookUpEdit searchProjectName;
        private DevExpress.XtraGrid.Views.Grid.GridView searchProjectNameView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColProjectNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColProjectName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColRemark;
        private DevExpress.XtraEditors.TextEdit textCustomerPoNo;
        private DevExpress.XtraEditors.LabelControl labCustomerPoNo;
        private DevExpress.XtraEditors.TextEdit textAutoSalesOrderNo;
        private DevExpress.XtraEditors.LabelControl labAutoSalesOrderNo;
        private System.Data.DataColumn dataColSalesOrderState;
        private DevExpress.XtraEditors.LabelControl labCollectionTypeNo;
        private DevExpress.XtraEditors.LookUpEdit lookUpCollectionTypeNo;
        private DevExpress.XtraEditors.LabelControl labTax;
        private DevExpress.XtraEditors.SpinEdit spinTax;
        private DevExpress.XtraEditors.LabelControl labSumAmount;
        private DevExpress.XtraEditors.SpinEdit spinSumAmount;
        private DevExpress.XtraEditors.LabelControl labTaxAmount;
        private DevExpress.XtraEditors.SpinEdit spinTaxAmount;
        private DevExpress.XtraEditors.LabelControl labAmount;
        private DevExpress.XtraEditors.SpinEdit spinAmount;
        private DevExpress.XtraEditors.LabelControl labIsEnd;
        private DevExpress.XtraEditors.CheckEdit checkIsEnd;
        private DevExpress.XtraEditors.LabelControl labQuotationVersions;
        private DevExpress.XtraEditors.LabelControl labAutoQuotationNo;
        private DevExpress.XtraEditors.PanelControl pnlGrid;
        private DevExpress.XtraTab.XtraTabControl xtraTabGrid;
        private DevExpress.XtraTab.XtraTabPage PageQuotationBaseInfo;
        private DevExpress.XtraEditors.TextEdit textAutoQuotationNo;
        private DevExpress.XtraEditors.PanelControl pnlGridTop;
        private DevExpress.XtraEditors.DateEdit dateRecordDateEnd;
        private DevExpress.XtraEditors.DateEdit dateRecordDateBegin;
        private DevExpress.XtraEditors.LabelControl lab1;
        private DevExpress.XtraEditors.LabelControl labRecordDate;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpBussinessBaseNo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpBussinessBaseNoView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textCommon;
        private DevExpress.XtraEditors.LabelControl labCommon;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private System.Data.DataSet dataSet_Quotation;
        private System.Data.DataTable TableQuotationBaseInfo;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColRFQNO;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColRequester;
        private System.Data.DataColumn dataColRecordDate;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColParentAutoQuotationNo;
        private System.Data.DataColumn dataColuParentAutoSalesOrderNo;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn9;
        private System.Data.DataColumn dataColumn10;
        private System.Data.DataColumn dataColumn11;
        private System.Windows.Forms.BindingSource bindingSource_BaseInfo;
        private DevExpress.XtraGrid.GridControl gridControlQuotationBaseInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewQuotationBaseInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoQuotationNo;
        private DevExpress.XtraGrid.Columns.GridColumn colRecordDate;
        private DevExpress.XtraGrid.Columns.GridColumn colBussinessBaseNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repSearchBussinessBaseNo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridCBussinessBaseNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridCBussinessBaseText;
        private DevExpress.XtraGrid.Columns.GridColumn gridCBussinessCategoryText;
        private DevExpress.XtraGrid.Columns.GridColumn gridCAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colRepertoryNo;
        private DevExpress.XtraGrid.Columns.GridColumn colRequester;
        private DevExpress.XtraGrid.Columns.GridColumn colRFQNO;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colPrepared;
        private DevExpress.XtraGrid.Columns.GridColumn colModifier;
        private DevExpress.XtraGrid.Columns.GridColumn colModifierTime;
        private DevExpress.XtraGrid.Columns.GridColumn colParentAutoQuotationNo;
        private DevExpress.XtraGrid.Columns.GridColumn colParentAutoSalesOrderNo;
        private DevExpress.XtraGrid.Columns.GridColumn colParentProjectNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheckSelect;
        private DevExpress.XtraEditors.LabelControl labMemo;
        private DevExpress.XtraEditors.LookUpEdit lookUpQuotationVersions;
        private DevExpress.XtraEditors.SimpleButton BtnCOR;
        private DevExpress.XtraEditors.TextEdit textParentProjectNo;
        private DevExpress.XtraEditors.LabelControl labParentProjectNo;
        private DevExpress.XtraEditors.TextEdit textParentAutoSalesOrderNo;
        private DevExpress.XtraEditors.LabelControl labParentAutoSalesOrderNo;
    }
}