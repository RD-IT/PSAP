namespace PSAP.VIEW.BSVIEW
{
    partial class FrmSalesOrder_History
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSalesOrder_History));
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
            this.dataColCurrencyCate = new System.Data.DataColumn();
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
            this.pnlMiddle = new DevExpress.XtraEditors.PanelControl();
            this.btnEditAutoQuotationNo = new DevExpress.XtraEditors.ButtonEdit();
            this.lookUpCurrencyCate = new DevExpress.XtraEditors.LookUpEdit();
            this.labCurrencyCate = new DevExpress.XtraEditors.LabelControl();
            this.textParentProjectNo = new DevExpress.XtraEditors.TextEdit();
            this.labParentProjectNo = new DevExpress.XtraEditors.LabelControl();
            this.textParentAutoSalesOrderNo = new DevExpress.XtraEditors.TextEdit();
            this.labParentAutoSalesOrderNo = new DevExpress.XtraEditors.LabelControl();
            this.lookUpQuotationVersions = new DevExpress.XtraEditors.LookUpEdit();
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
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.dockManagerLeft = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPnlLeft = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.pnlLeftGrid = new DevExpress.XtraEditors.PanelControl();
            this.gridControlSalesOrder = new DevExpress.XtraGrid.GridControl();
            this.gridViewSalesOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjectNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAutoSalesOrderNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAutoQuotationNo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBussinessBaseNo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSearchLookUpBussinessBaseNo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repSearchLookUpBussinessBaseNoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuotationVersions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerPoNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCollectionTypeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSumAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjectLeader = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsEnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrepared1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPreparedIp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifier1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifierIp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifierTime1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParentAutoSalesOrderNo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParentProjectNo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesOrderState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrencyCate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlLeftTop = new DevExpress.XtraEditors.PanelControl();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.searchLookUpBussinessBaseNo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpBussinessBaseNoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textCommon = new DevExpress.XtraEditors.TextEdit();
            this.labCommon = new DevExpress.XtraEditors.LabelControl();
            this.dateSalesOrderDateEnd = new DevExpress.XtraEditors.DateEdit();
            this.dateSalesOrderDateBegin = new DevExpress.XtraEditors.DateEdit();
            this.lab1 = new DevExpress.XtraEditors.LabelControl();
            this.labRecordDate = new DevExpress.XtraEditors.LabelControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddle)).BeginInit();
            this.pnlMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditAutoQuotationNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCurrencyCate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textParentProjectNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textParentAutoSalesOrderNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpQuotationVersions.Properties)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.dockManagerLeft)).BeginInit();
            this.dockPnlLeft.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeftGrid)).BeginInit();
            this.pnlLeftGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSalesOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSalesOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchLookUpBussinessBaseNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchLookUpBussinessBaseNoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeftTop)).BeginInit();
            this.pnlLeftTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpBussinessBaseNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpBussinessBaseNoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCommon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSalesOrderDateEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSalesOrderDateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSalesOrderDateBegin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSalesOrderDateBegin.Properties)).BeginInit();
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
            this.dataColSalesOrderState,
            this.dataColCurrencyCate});
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
            // dataColCurrencyCate
            // 
            this.dataColCurrencyCate.Caption = "币种";
            this.dataColCurrencyCate.ColumnName = "CurrencyCate";
            this.dataColCurrencyCate.DataType = typeof(int);
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
            this.pnlRight.Controls.Add(this.pnlMiddle);
            this.pnlRight.Controls.Add(this.pnlToolBar);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(350, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(1052, 611);
            this.pnlRight.TabIndex = 3;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.xtraTabGrid);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 313);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1052, 298);
            this.pnlGrid.TabIndex = 10;
            // 
            // xtraTabGrid
            // 
            this.xtraTabGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabGrid.Location = new System.Drawing.Point(2, 2);
            this.xtraTabGrid.Name = "xtraTabGrid";
            this.xtraTabGrid.SelectedTabPage = this.PageQuotationBaseInfo;
            this.xtraTabGrid.Size = new System.Drawing.Size(1048, 294);
            this.xtraTabGrid.TabIndex = 9;
            this.xtraTabGrid.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.PageQuotationBaseInfo});
            // 
            // PageQuotationBaseInfo
            // 
            this.PageQuotationBaseInfo.Controls.Add(this.gridControlQuotationBaseInfo);
            this.PageQuotationBaseInfo.Name = "PageQuotationBaseInfo";
            this.PageQuotationBaseInfo.Size = new System.Drawing.Size(1042, 265);
            this.PageQuotationBaseInfo.Text = "报价单信息";
            // 
            // gridControlQuotationBaseInfo
            // 
            this.gridControlQuotationBaseInfo.DataSource = this.bindingSource_BaseInfo;
            this.gridControlQuotationBaseInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlQuotationBaseInfo.Location = new System.Drawing.Point(0, 0);
            this.gridControlQuotationBaseInfo.MainView = this.gridViewQuotationBaseInfo;
            this.gridControlQuotationBaseInfo.Name = "gridControlQuotationBaseInfo";
            this.gridControlQuotationBaseInfo.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repSearchBussinessBaseNo,
            this.repCheckSelect});
            this.gridControlQuotationBaseInfo.Size = new System.Drawing.Size(1042, 265);
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
            this.gridViewQuotationBaseInfo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewSalesOrder_KeyDown);
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
            // pnlMiddle
            // 
            this.pnlMiddle.Controls.Add(this.btnEditAutoQuotationNo);
            this.pnlMiddle.Controls.Add(this.lookUpCurrencyCate);
            this.pnlMiddle.Controls.Add(this.labCurrencyCate);
            this.pnlMiddle.Controls.Add(this.textParentProjectNo);
            this.pnlMiddle.Controls.Add(this.labParentProjectNo);
            this.pnlMiddle.Controls.Add(this.textParentAutoSalesOrderNo);
            this.pnlMiddle.Controls.Add(this.labParentAutoSalesOrderNo);
            this.pnlMiddle.Controls.Add(this.lookUpQuotationVersions);
            this.pnlMiddle.Controls.Add(this.labIsEnd);
            this.pnlMiddle.Controls.Add(this.checkIsEnd);
            this.pnlMiddle.Controls.Add(this.labQuotationVersions);
            this.pnlMiddle.Controls.Add(this.labAutoQuotationNo);
            this.pnlMiddle.Controls.Add(this.labTax);
            this.pnlMiddle.Controls.Add(this.spinTax);
            this.pnlMiddle.Controls.Add(this.labSumAmount);
            this.pnlMiddle.Controls.Add(this.spinSumAmount);
            this.pnlMiddle.Controls.Add(this.labTaxAmount);
            this.pnlMiddle.Controls.Add(this.spinTaxAmount);
            this.pnlMiddle.Controls.Add(this.labAmount);
            this.pnlMiddle.Controls.Add(this.spinAmount);
            this.pnlMiddle.Controls.Add(this.labCollectionTypeNo);
            this.pnlMiddle.Controls.Add(this.lookUpCollectionTypeNo);
            this.pnlMiddle.Controls.Add(this.textModifier);
            this.pnlMiddle.Controls.Add(this.textPrepared);
            this.pnlMiddle.Controls.Add(this.dateModifierTime);
            this.pnlMiddle.Controls.Add(this.labModifierTime);
            this.pnlMiddle.Controls.Add(this.labModifier);
            this.pnlMiddle.Controls.Add(this.labPrepared);
            this.pnlMiddle.Controls.Add(this.labSalesOrderDate);
            this.pnlMiddle.Controls.Add(this.dateSalesOrderDate);
            this.pnlMiddle.Controls.Add(this.textRemark);
            this.pnlMiddle.Controls.Add(this.labRemark);
            this.pnlMiddle.Controls.Add(this.textProjectLeader);
            this.pnlMiddle.Controls.Add(this.labProjectLeader);
            this.pnlMiddle.Controls.Add(this.labBussinessBaseNo);
            this.pnlMiddle.Controls.Add(this.labProjectName);
            this.pnlMiddle.Controls.Add(this.searchBussinessBaseNo);
            this.pnlMiddle.Controls.Add(this.searchProjectName);
            this.pnlMiddle.Controls.Add(this.textCustomerPoNo);
            this.pnlMiddle.Controls.Add(this.labCustomerPoNo);
            this.pnlMiddle.Controls.Add(this.textAutoSalesOrderNo);
            this.pnlMiddle.Controls.Add(this.labAutoSalesOrderNo);
            this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMiddle.Location = new System.Drawing.Point(0, 40);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(1052, 273);
            this.pnlMiddle.TabIndex = 8;
            // 
            // btnEditAutoQuotationNo
            // 
            this.btnEditAutoQuotationNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_SalesOrder, "AutoQuotationNo", true));
            this.btnEditAutoQuotationNo.EnterMoveNextControl = true;
            this.btnEditAutoQuotationNo.Location = new System.Drawing.Point(597, 21);
            this.btnEditAutoQuotationNo.Name = "btnEditAutoQuotationNo";
            this.btnEditAutoQuotationNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "查询", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnEditAutoQuotationNo.Properties.ReadOnly = true;
            this.btnEditAutoQuotationNo.Size = new System.Drawing.Size(150, 21);
            this.btnEditAutoQuotationNo.TabIndex = 2;
            this.btnEditAutoQuotationNo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnEditAutoQuotationNo_ButtonClick);
            this.btnEditAutoQuotationNo.EditValueChanged += new System.EventHandler(this.btnEditAutoQuotationNo_EditValueChanged);
            // 
            // lookUpCurrencyCate
            // 
            this.lookUpCurrencyCate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_SalesOrder, "CurrencyCate", true));
            this.lookUpCurrencyCate.EnterMoveNextControl = true;
            this.lookUpCurrencyCate.Location = new System.Drawing.Point(354, 89);
            this.lookUpCurrencyCate.Name = "lookUpCurrencyCate";
            this.lookUpCurrencyCate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpCurrencyCate.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AutoId", "AutoId", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CurrencyCateAbb", "币种缩写"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CurrencyCateName", "币种名称"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ExchangeRate", "汇率")});
            this.lookUpCurrencyCate.Properties.DisplayMember = "CurrencyCateName";
            this.lookUpCurrencyCate.Properties.DropDownRows = 12;
            this.lookUpCurrencyCate.Properties.NullText = "";
            this.lookUpCurrencyCate.Properties.PopupWidth = 300;
            this.lookUpCurrencyCate.Properties.ValueMember = "AutoId";
            this.lookUpCurrencyCate.Size = new System.Drawing.Size(150, 20);
            this.lookUpCurrencyCate.TabIndex = 7;
            // 
            // labCurrencyCate
            // 
            this.labCurrencyCate.Location = new System.Drawing.Point(281, 92);
            this.labCurrencyCate.Name = "labCurrencyCate";
            this.labCurrencyCate.Size = new System.Drawing.Size(24, 14);
            this.labCurrencyCate.TabIndex = 45;
            this.labCurrencyCate.Text = "币种";
            // 
            // textParentProjectNo
            // 
            this.textParentProjectNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_SalesOrder, "ParentProjectNo", true));
            this.textParentProjectNo.EnterMoveNextControl = true;
            this.textParentProjectNo.Location = new System.Drawing.Point(879, 55);
            this.textParentProjectNo.Name = "textParentProjectNo";
            this.textParentProjectNo.Properties.ReadOnly = true;
            this.textParentProjectNo.Size = new System.Drawing.Size(150, 20);
            this.textParentProjectNo.TabIndex = 20;
            this.textParentProjectNo.TabStop = false;
            this.textParentProjectNo.Visible = false;
            // 
            // labParentProjectNo
            // 
            this.labParentProjectNo.Location = new System.Drawing.Point(770, 58);
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
            this.textParentAutoSalesOrderNo.Location = new System.Drawing.Point(879, 21);
            this.textParentAutoSalesOrderNo.Name = "textParentAutoSalesOrderNo";
            this.textParentAutoSalesOrderNo.Properties.ReadOnly = true;
            this.textParentAutoSalesOrderNo.Size = new System.Drawing.Size(150, 20);
            this.textParentAutoSalesOrderNo.TabIndex = 19;
            this.textParentAutoSalesOrderNo.TabStop = false;
            this.textParentAutoSalesOrderNo.Visible = false;
            // 
            // labParentAutoSalesOrderNo
            // 
            this.labParentAutoSalesOrderNo.Location = new System.Drawing.Point(770, 24);
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
            this.lookUpQuotationVersions.Location = new System.Drawing.Point(597, 55);
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
            // labIsEnd
            // 
            this.labIsEnd.Location = new System.Drawing.Point(525, 160);
            this.labIsEnd.Name = "labIsEnd";
            this.labIsEnd.Size = new System.Drawing.Size(48, 14);
            this.labIsEnd.TabIndex = 38;
            this.labIsEnd.Text = "结账完毕";
            // 
            // checkIsEnd
            // 
            this.checkIsEnd.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_SalesOrder, "IsEnd", true));
            this.checkIsEnd.EnterMoveNextControl = true;
            this.checkIsEnd.Location = new System.Drawing.Point(617, 157);
            this.checkIsEnd.Name = "checkIsEnd";
            this.checkIsEnd.Properties.Caption = "";
            this.checkIsEnd.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.checkIsEnd.Properties.ReadOnly = true;
            this.checkIsEnd.Properties.ValueChecked = 1;
            this.checkIsEnd.Properties.ValueGrayed = 0;
            this.checkIsEnd.Properties.ValueUnchecked = 0;
            this.checkIsEnd.Size = new System.Drawing.Size(33, 19);
            this.checkIsEnd.TabIndex = 14;
            this.checkIsEnd.TabStop = false;
            // 
            // labQuotationVersions
            // 
            this.labQuotationVersions.Location = new System.Drawing.Point(525, 58);
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
            this.labTax.Location = new System.Drawing.Point(525, 92);
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
            this.spinTax.Location = new System.Drawing.Point(597, 89);
            this.spinTax.Name = "spinTax";
            this.spinTax.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinTax.Properties.DisplayFormat.FormatString = "p0";
            this.spinTax.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinTax.Properties.EditFormat.FormatString = "p0";
            this.spinTax.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinTax.Properties.Mask.EditMask = "p0";
            this.spinTax.Size = new System.Drawing.Size(150, 20);
            this.spinTax.TabIndex = 8;
            this.spinTax.EditValueChanged += new System.EventHandler(this.spinAmount_EditValueChanged);
            // 
            // labSumAmount
            // 
            this.labSumAmount.Location = new System.Drawing.Point(525, 126);
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
            this.spinSumAmount.Location = new System.Drawing.Point(597, 123);
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
            this.labTaxAmount.Location = new System.Drawing.Point(281, 126);
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
            this.spinTaxAmount.Location = new System.Drawing.Point(354, 123);
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
            this.labAmount.Location = new System.Drawing.Point(36, 126);
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
            this.spinAmount.Location = new System.Drawing.Point(112, 123);
            this.spinAmount.Name = "spinAmount";
            this.spinAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinAmount.Properties.DisplayFormat.FormatString = "N2";
            this.spinAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinAmount.Properties.EditFormat.FormatString = "N2";
            this.spinAmount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinAmount.Properties.Mask.EditMask = "N2";
            this.spinAmount.Size = new System.Drawing.Size(150, 20);
            this.spinAmount.TabIndex = 9;
            this.spinAmount.EditValueChanged += new System.EventHandler(this.spinAmount_EditValueChanged);
            // 
            // labCollectionTypeNo
            // 
            this.labCollectionTypeNo.Location = new System.Drawing.Point(36, 92);
            this.labCollectionTypeNo.Name = "labCollectionTypeNo";
            this.labCollectionTypeNo.Size = new System.Drawing.Size(48, 14);
            this.labCollectionTypeNo.TabIndex = 24;
            this.labCollectionTypeNo.Text = "收款方式";
            // 
            // lookUpCollectionTypeNo
            // 
            this.lookUpCollectionTypeNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_SalesOrder, "CollectionTypeNo", true));
            this.lookUpCollectionTypeNo.EnterMoveNextControl = true;
            this.lookUpCollectionTypeNo.Location = new System.Drawing.Point(112, 89);
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
            this.lookUpCollectionTypeNo.TabIndex = 6;
            // 
            // textModifier
            // 
            this.textModifier.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_SalesOrder, "Modifier", true));
            this.textModifier.EnterMoveNextControl = true;
            this.textModifier.Location = new System.Drawing.Point(354, 225);
            this.textModifier.Name = "textModifier";
            this.textModifier.Properties.ReadOnly = true;
            this.textModifier.Size = new System.Drawing.Size(150, 20);
            this.textModifier.TabIndex = 17;
            this.textModifier.TabStop = false;
            // 
            // textPrepared
            // 
            this.textPrepared.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_SalesOrder, "Prepared", true));
            this.textPrepared.EnterMoveNextControl = true;
            this.textPrepared.Location = new System.Drawing.Point(112, 225);
            this.textPrepared.Name = "textPrepared";
            this.textPrepared.Properties.ReadOnly = true;
            this.textPrepared.Size = new System.Drawing.Size(150, 20);
            this.textPrepared.TabIndex = 16;
            this.textPrepared.TabStop = false;
            // 
            // dateModifierTime
            // 
            this.dateModifierTime.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_SalesOrder, "ModifierTime", true));
            this.dateModifierTime.EditValue = null;
            this.dateModifierTime.EnterMoveNextControl = true;
            this.dateModifierTime.Location = new System.Drawing.Point(597, 225);
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
            this.dateModifierTime.TabIndex = 18;
            this.dateModifierTime.TabStop = false;
            // 
            // labModifierTime
            // 
            this.labModifierTime.Location = new System.Drawing.Point(525, 228);
            this.labModifierTime.Name = "labModifierTime";
            this.labModifierTime.Size = new System.Drawing.Size(48, 14);
            this.labModifierTime.TabIndex = 17;
            this.labModifierTime.Text = "修改时间";
            // 
            // labModifier
            // 
            this.labModifier.Location = new System.Drawing.Point(281, 228);
            this.labModifier.Name = "labModifier";
            this.labModifier.Size = new System.Drawing.Size(36, 14);
            this.labModifier.TabIndex = 16;
            this.labModifier.Text = "修改人";
            // 
            // labPrepared
            // 
            this.labPrepared.Location = new System.Drawing.Point(36, 228);
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
            this.textRemark.Location = new System.Drawing.Point(112, 191);
            this.textRemark.Name = "textRemark";
            this.textRemark.Size = new System.Drawing.Size(635, 20);
            this.textRemark.TabIndex = 15;
            // 
            // labRemark
            // 
            this.labRemark.Location = new System.Drawing.Point(36, 194);
            this.labRemark.Name = "labRemark";
            this.labRemark.Size = new System.Drawing.Size(24, 14);
            this.labRemark.TabIndex = 10;
            this.labRemark.Text = "备注";
            // 
            // textProjectLeader
            // 
            this.textProjectLeader.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_SalesOrder, "ProjectLeader", true));
            this.textProjectLeader.EnterMoveNextControl = true;
            this.textProjectLeader.Location = new System.Drawing.Point(354, 157);
            this.textProjectLeader.Name = "textProjectLeader";
            this.textProjectLeader.Size = new System.Drawing.Size(150, 20);
            this.textProjectLeader.TabIndex = 13;
            // 
            // labProjectLeader
            // 
            this.labProjectLeader.Location = new System.Drawing.Point(281, 160);
            this.labProjectLeader.Name = "labProjectLeader";
            this.labProjectLeader.Size = new System.Drawing.Size(60, 14);
            this.labProjectLeader.TabIndex = 8;
            this.labProjectLeader.Text = "项目负责人";
            // 
            // labBussinessBaseNo
            // 
            this.labBussinessBaseNo.Location = new System.Drawing.Point(36, 58);
            this.labBussinessBaseNo.Name = "labBussinessBaseNo";
            this.labBussinessBaseNo.Size = new System.Drawing.Size(36, 14);
            this.labBussinessBaseNo.TabIndex = 7;
            this.labBussinessBaseNo.Text = "往来方";
            // 
            // labProjectName
            // 
            this.labProjectName.Location = new System.Drawing.Point(281, 58);
            this.labProjectName.Name = "labProjectName";
            this.labProjectName.Size = new System.Drawing.Size(48, 14);
            this.labProjectName.TabIndex = 6;
            this.labProjectName.Text = "项目名称";
            // 
            // searchBussinessBaseNo
            // 
            this.searchBussinessBaseNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_SalesOrder, "BussinessBaseNo", true));
            this.searchBussinessBaseNo.EnterMoveNextControl = true;
            this.searchBussinessBaseNo.Location = new System.Drawing.Point(112, 55);
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
            this.searchProjectName.Location = new System.Drawing.Point(354, 55);
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
            this.textCustomerPoNo.Location = new System.Drawing.Point(112, 157);
            this.textCustomerPoNo.Name = "textCustomerPoNo";
            this.textCustomerPoNo.Size = new System.Drawing.Size(150, 20);
            this.textCustomerPoNo.TabIndex = 12;
            // 
            // labCustomerPoNo
            // 
            this.labCustomerPoNo.Location = new System.Drawing.Point(36, 160);
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
            this.pnlToolBar.Controls.Add(this.btnDelete);
            this.pnlToolBar.Controls.Add(this.btnCancel);
            this.pnlToolBar.Controls.Add(this.btnSave);
            this.pnlToolBar.Controls.Add(this.btnNew);
            this.pnlToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolBar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolBar.Name = "pnlToolBar";
            this.pnlToolBar.Size = new System.Drawing.Size(1052, 40);
            this.pnlToolBar.TabIndex = 7;
            // 
            // BtnCOR
            // 
            this.BtnCOR.Location = new System.Drawing.Point(415, 9);
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
            this.btnPreview.Location = new System.Drawing.Point(334, 9);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(4);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 26;
            this.btnPreview.TabStop = false;
            this.btnPreview.Text = "预览";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
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
            this.dockPnlLeft.ID = new System.Guid("7670ace9-3f7a-4efe-8a4d-71e169ee2234");
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
            this.dockPnlLeft.Size = new System.Drawing.Size(350, 611);
            this.dockPnlLeft.Text = "历史销售订单";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.pnlLeftGrid);
            this.dockPanel1_Container.Controls.Add(this.pnlLeftTop);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(342, 584);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // pnlLeftGrid
            // 
            this.pnlLeftGrid.Controls.Add(this.gridControlSalesOrder);
            this.pnlLeftGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeftGrid.Location = new System.Drawing.Point(0, 110);
            this.pnlLeftGrid.Name = "pnlLeftGrid";
            this.pnlLeftGrid.Size = new System.Drawing.Size(342, 474);
            this.pnlLeftGrid.TabIndex = 4;
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
            this.repSearchLookUpBussinessBaseNo});
            this.gridControlSalesOrder.Size = new System.Drawing.Size(338, 470);
            this.gridControlSalesOrder.TabIndex = 5;
            this.gridControlSalesOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSalesOrder});
            // 
            // gridViewSalesOrder
            // 
            this.gridViewSalesOrder.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId1,
            this.colProjectNo,
            this.colAutoSalesOrderNo,
            this.colAutoQuotationNo1,
            this.colAmount,
            this.colBussinessBaseNo1,
            this.colSalesOrderDate,
            this.colProjectName,
            this.colQuotationVersions,
            this.colCustomerPoNo,
            this.colCollectionTypeNo,
            this.colTax,
            this.colTaxAmount,
            this.colSumAmount,
            this.colProjectLeader,
            this.colIsEnd,
            this.colPrepared1,
            this.colPreparedIp,
            this.colModifier1,
            this.colModifierIp,
            this.colModifierTime1,
            this.colRemark1,
            this.colParentAutoSalesOrderNo1,
            this.colParentProjectNo1,
            this.colSalesOrderState,
            this.colCurrencyCate});
            this.gridViewSalesOrder.GridControl = this.gridControlSalesOrder;
            this.gridViewSalesOrder.IndicatorWidth = 40;
            this.gridViewSalesOrder.Name = "gridViewSalesOrder";
            this.gridViewSalesOrder.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewSalesOrder.OptionsBehavior.Editable = false;
            this.gridViewSalesOrder.OptionsBehavior.ReadOnly = true;
            this.gridViewSalesOrder.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewSalesOrder.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewSalesOrder.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewSalesOrder.OptionsSelection.MultiSelect = true;
            this.gridViewSalesOrder.OptionsView.ColumnAutoWidth = false;
            this.gridViewSalesOrder.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewSalesOrder.OptionsView.ShowFooter = true;
            this.gridViewSalesOrder.OptionsView.ShowGroupPanel = false;
            this.gridViewSalesOrder.OptionsView.ShowIndicator = false;
            this.gridViewSalesOrder.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewSalesOrder_FocusedRowChanged);
            this.gridViewSalesOrder.BeforeLeaveRow += new DevExpress.XtraGrid.Views.Base.RowAllowEventHandler(this.gridViewSalesOrder_BeforeLeaveRow);
            this.gridViewSalesOrder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewSalesOrder_KeyDown);
            // 
            // colAutoId1
            // 
            this.colAutoId1.FieldName = "AutoId";
            this.colAutoId1.Name = "colAutoId1";
            // 
            // colProjectNo
            // 
            this.colProjectNo.FieldName = "ProjectNo";
            this.colProjectNo.Name = "colProjectNo";
            // 
            // colAutoSalesOrderNo
            // 
            this.colAutoSalesOrderNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colAutoSalesOrderNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAutoSalesOrderNo.FieldName = "AutoSalesOrderNo";
            this.colAutoSalesOrderNo.Name = "colAutoSalesOrderNo";
            this.colAutoSalesOrderNo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "AutoSalesOrderNo", "共计{0}条")});
            this.colAutoSalesOrderNo.Visible = true;
            this.colAutoSalesOrderNo.VisibleIndex = 0;
            this.colAutoSalesOrderNo.Width = 110;
            // 
            // colAutoQuotationNo1
            // 
            this.colAutoQuotationNo1.AppearanceHeader.Options.UseTextOptions = true;
            this.colAutoQuotationNo1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAutoQuotationNo1.FieldName = "AutoQuotationNo";
            this.colAutoQuotationNo1.Name = "colAutoQuotationNo1";
            this.colAutoQuotationNo1.Visible = true;
            this.colAutoQuotationNo1.VisibleIndex = 1;
            this.colAutoQuotationNo1.Width = 110;
            // 
            // colAmount
            // 
            this.colAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAmount.DisplayFormat.FormatString = "N2";
            this.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "{0:N2}")});
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 2;
            this.colAmount.Width = 90;
            // 
            // colBussinessBaseNo1
            // 
            this.colBussinessBaseNo1.AppearanceHeader.Options.UseTextOptions = true;
            this.colBussinessBaseNo1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBussinessBaseNo1.ColumnEdit = this.repSearchLookUpBussinessBaseNo;
            this.colBussinessBaseNo1.FieldName = "BussinessBaseNo";
            this.colBussinessBaseNo1.Name = "colBussinessBaseNo1";
            this.colBussinessBaseNo1.Visible = true;
            this.colBussinessBaseNo1.VisibleIndex = 3;
            this.colBussinessBaseNo1.Width = 100;
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
            // colSalesOrderDate
            // 
            this.colSalesOrderDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colSalesOrderDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSalesOrderDate.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.colSalesOrderDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colSalesOrderDate.FieldName = "SalesOrderDate";
            this.colSalesOrderDate.Name = "colSalesOrderDate";
            this.colSalesOrderDate.Visible = true;
            this.colSalesOrderDate.VisibleIndex = 4;
            this.colSalesOrderDate.Width = 80;
            // 
            // colProjectName
            // 
            this.colProjectName.AppearanceHeader.Options.UseTextOptions = true;
            this.colProjectName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProjectName.FieldName = "ProjectName";
            this.colProjectName.Name = "colProjectName";
            this.colProjectName.Visible = true;
            this.colProjectName.VisibleIndex = 5;
            this.colProjectName.Width = 90;
            // 
            // colQuotationVersions
            // 
            this.colQuotationVersions.AppearanceHeader.Options.UseTextOptions = true;
            this.colQuotationVersions.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQuotationVersions.FieldName = "QuotationVersions";
            this.colQuotationVersions.Name = "colQuotationVersions";
            this.colQuotationVersions.Visible = true;
            this.colQuotationVersions.VisibleIndex = 6;
            this.colQuotationVersions.Width = 60;
            // 
            // colCustomerPoNo
            // 
            this.colCustomerPoNo.FieldName = "CustomerPoNo";
            this.colCustomerPoNo.Name = "colCustomerPoNo";
            // 
            // colCollectionTypeNo
            // 
            this.colCollectionTypeNo.FieldName = "CollectionTypeNo";
            this.colCollectionTypeNo.Name = "colCollectionTypeNo";
            // 
            // colTax
            // 
            this.colTax.FieldName = "Tax";
            this.colTax.Name = "colTax";
            // 
            // colTaxAmount
            // 
            this.colTaxAmount.DisplayFormat.FormatString = "N2";
            this.colTaxAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTaxAmount.FieldName = "TaxAmount";
            this.colTaxAmount.Name = "colTaxAmount";
            this.colTaxAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TaxAmount", "{0:N2}")});
            // 
            // colSumAmount
            // 
            this.colSumAmount.DisplayFormat.FormatString = "N2";
            this.colSumAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSumAmount.FieldName = "SumAmount";
            this.colSumAmount.Name = "colSumAmount";
            this.colSumAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SumAmount", "{0:N2}")});
            // 
            // colProjectLeader
            // 
            this.colProjectLeader.FieldName = "ProjectLeader";
            this.colProjectLeader.Name = "colProjectLeader";
            // 
            // colIsEnd
            // 
            this.colIsEnd.FieldName = "IsEnd";
            this.colIsEnd.Name = "colIsEnd";
            // 
            // colPrepared1
            // 
            this.colPrepared1.FieldName = "Prepared";
            this.colPrepared1.Name = "colPrepared1";
            // 
            // colPreparedIp
            // 
            this.colPreparedIp.FieldName = "PreparedIp";
            this.colPreparedIp.Name = "colPreparedIp";
            // 
            // colModifier1
            // 
            this.colModifier1.FieldName = "Modifier";
            this.colModifier1.Name = "colModifier1";
            // 
            // colModifierIp
            // 
            this.colModifierIp.FieldName = "ModifierIp";
            this.colModifierIp.Name = "colModifierIp";
            // 
            // colModifierTime1
            // 
            this.colModifierTime1.FieldName = "ModifierTime";
            this.colModifierTime1.Name = "colModifierTime1";
            // 
            // colRemark1
            // 
            this.colRemark1.FieldName = "Remark";
            this.colRemark1.Name = "colRemark1";
            // 
            // colParentAutoSalesOrderNo1
            // 
            this.colParentAutoSalesOrderNo1.FieldName = "ParentAutoSalesOrderNo";
            this.colParentAutoSalesOrderNo1.Name = "colParentAutoSalesOrderNo1";
            // 
            // colParentProjectNo1
            // 
            this.colParentProjectNo1.FieldName = "ParentProjectNo";
            this.colParentProjectNo1.Name = "colParentProjectNo1";
            // 
            // colSalesOrderState
            // 
            this.colSalesOrderState.FieldName = "SalesOrderState";
            this.colSalesOrderState.Name = "colSalesOrderState";
            // 
            // colCurrencyCate
            // 
            this.colCurrencyCate.FieldName = "CurrencyCate";
            this.colCurrencyCate.Name = "colCurrencyCate";
            // 
            // pnlLeftTop
            // 
            this.pnlLeftTop.Controls.Add(this.btnQuery);
            this.pnlLeftTop.Controls.Add(this.searchLookUpBussinessBaseNo);
            this.pnlLeftTop.Controls.Add(this.labelControl1);
            this.pnlLeftTop.Controls.Add(this.textCommon);
            this.pnlLeftTop.Controls.Add(this.labCommon);
            this.pnlLeftTop.Controls.Add(this.dateSalesOrderDateEnd);
            this.pnlLeftTop.Controls.Add(this.dateSalesOrderDateBegin);
            this.pnlLeftTop.Controls.Add(this.lab1);
            this.pnlLeftTop.Controls.Add(this.labRecordDate);
            this.pnlLeftTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeftTop.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftTop.Name = "pnlLeftTop";
            this.pnlLeftTop.Size = new System.Drawing.Size(342, 110);
            this.pnlLeftTop.TabIndex = 0;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(245, 73);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 105;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // searchLookUpBussinessBaseNo
            // 
            this.searchLookUpBussinessBaseNo.EnterMoveNextControl = true;
            this.searchLookUpBussinessBaseNo.Location = new System.Drawing.Point(86, 44);
            this.searchLookUpBussinessBaseNo.Name = "searchLookUpBussinessBaseNo";
            this.searchLookUpBussinessBaseNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpBussinessBaseNo.Properties.DisplayMember = "BussinessBaseText";
            this.searchLookUpBussinessBaseNo.Properties.NullText = "";
            this.searchLookUpBussinessBaseNo.Properties.ValueMember = "BussinessBaseNo";
            this.searchLookUpBussinessBaseNo.Properties.View = this.searchLookUpBussinessBaseNoView;
            this.searchLookUpBussinessBaseNo.Size = new System.Drawing.Size(150, 20);
            this.searchLookUpBussinessBaseNo.TabIndex = 103;
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
            this.labelControl1.Location = new System.Drawing.Point(20, 47);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 26;
            this.labelControl1.Text = "往来方：";
            // 
            // textCommon
            // 
            this.textCommon.EnterMoveNextControl = true;
            this.textCommon.Location = new System.Drawing.Point(86, 74);
            this.textCommon.Name = "textCommon";
            this.textCommon.Size = new System.Drawing.Size(150, 20);
            this.textCommon.TabIndex = 104;
            // 
            // labCommon
            // 
            this.labCommon.Location = new System.Drawing.Point(20, 77);
            this.labCommon.Name = "labCommon";
            this.labCommon.Size = new System.Drawing.Size(60, 14);
            this.labCommon.TabIndex = 24;
            this.labCommon.Text = "通用查询：";
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
            this.dateSalesOrderDateEnd.TabIndex = 102;
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
            this.dateSalesOrderDateBegin.TabIndex = 101;
            // 
            // lab1
            // 
            this.lab1.Location = new System.Drawing.Point(192, 17);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(4, 14);
            this.lab1.TabIndex = 10;
            this.lab1.Text = "-";
            // 
            // labRecordDate
            // 
            this.labRecordDate.Location = new System.Drawing.Point(20, 17);
            this.labRecordDate.Name = "labRecordDate";
            this.labRecordDate.Size = new System.Drawing.Size(60, 14);
            this.labRecordDate.TabIndex = 9;
            this.labRecordDate.Text = "登记日期：";
            // 
            // FrmSalesOrder_History
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1402, 611);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.dockPnlLeft);
            this.Name = "FrmSalesOrder_History";
            this.TabText = "销售订单";
            this.Text = "销售订单";
            this.Activated += new System.EventHandler(this.FrmSalesOrder_History_Activated);
            this.Load += new System.EventHandler(this.FrmSalesOrder_History_Load);
            this.Shown += new System.EventHandler(this.FrmSalesOrder_History_Shown);
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
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddle)).EndInit();
            this.pnlMiddle.ResumeLayout(false);
            this.pnlMiddle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditAutoQuotationNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCurrencyCate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textParentProjectNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textParentAutoSalesOrderNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpQuotationVersions.Properties)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.dockManagerLeft)).EndInit();
            this.dockPnlLeft.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeftGrid)).EndInit();
            this.pnlLeftGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSalesOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSalesOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchLookUpBussinessBaseNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchLookUpBussinessBaseNoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeftTop)).EndInit();
            this.pnlLeftTop.ResumeLayout(false);
            this.pnlLeftTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpBussinessBaseNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpBussinessBaseNoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCommon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSalesOrderDateEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSalesOrderDateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSalesOrderDateBegin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSalesOrderDateBegin.Properties)).EndInit();
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
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.PanelControl pnlMiddle;
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
        private DevExpress.XtraEditors.LookUpEdit lookUpQuotationVersions;
        private DevExpress.XtraEditors.SimpleButton BtnCOR;
        private DevExpress.XtraEditors.TextEdit textParentProjectNo;
        private DevExpress.XtraEditors.LabelControl labParentProjectNo;
        private DevExpress.XtraEditors.TextEdit textParentAutoSalesOrderNo;
        private DevExpress.XtraEditors.LabelControl labParentAutoSalesOrderNo;
        private System.Data.DataColumn dataColCurrencyCate;
        private DevExpress.XtraEditors.LookUpEdit lookUpCurrencyCate;
        private DevExpress.XtraEditors.LabelControl labCurrencyCate;
        private DevExpress.XtraEditors.ButtonEdit btnEditAutoQuotationNo;
        private DevExpress.XtraBars.Docking.DockManager dockManagerLeft;
        private DevExpress.XtraBars.Docking.DockPanel dockPnlLeft;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraEditors.PanelControl pnlLeftTop;
        private DevExpress.XtraEditors.PanelControl pnlLeftGrid;
        private DevExpress.XtraGrid.GridControl gridControlSalesOrder;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSalesOrder;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repSearchLookUpBussinessBaseNo;
        private DevExpress.XtraGrid.Views.Grid.GridView repSearchLookUpBussinessBaseNoView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId1;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectNo;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoSalesOrderNo;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectName;
        private DevExpress.XtraGrid.Columns.GridColumn colBussinessBaseNo1;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoQuotationNo1;
        private DevExpress.XtraGrid.Columns.GridColumn colQuotationVersions;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerPoNo;
        private DevExpress.XtraGrid.Columns.GridColumn colCollectionTypeNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTax;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colSumAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectLeader;
        private DevExpress.XtraGrid.Columns.GridColumn colIsEnd;
        private DevExpress.XtraGrid.Columns.GridColumn colPrepared1;
        private DevExpress.XtraGrid.Columns.GridColumn colPreparedIp;
        private DevExpress.XtraGrid.Columns.GridColumn colModifier1;
        private DevExpress.XtraGrid.Columns.GridColumn colModifierIp;
        private DevExpress.XtraGrid.Columns.GridColumn colModifierTime1;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark1;
        private DevExpress.XtraGrid.Columns.GridColumn colParentAutoSalesOrderNo1;
        private DevExpress.XtraGrid.Columns.GridColumn colParentProjectNo1;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesOrderState;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyCate;
        private DevExpress.XtraEditors.DateEdit dateSalesOrderDateEnd;
        private DevExpress.XtraEditors.DateEdit dateSalesOrderDateBegin;
        private DevExpress.XtraEditors.LabelControl lab1;
        private DevExpress.XtraEditors.LabelControl labRecordDate;
        private DevExpress.XtraEditors.TextEdit textCommon;
        private DevExpress.XtraEditors.LabelControl labCommon;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpBussinessBaseNo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpBussinessBaseNoView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
    }
}