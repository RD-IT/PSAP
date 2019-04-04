namespace PSAP.VIEW.BSVIEW
{
    partial class FrmQuotationInfo_History
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
            this.dataSet_Quotation = new System.Data.DataSet();
            this.TableQuotationBaseInfo = new System.Data.DataTable();
            this.dataColAutoId = new System.Data.DataColumn();
            this.dataColAutoQuotationNo = new System.Data.DataColumn();
            this.dataColRFQNO = new System.Data.DataColumn();
            this.dataColProjectName = new System.Data.DataColumn();
            this.dataColBussinessBaseNo = new System.Data.DataColumn();
            this.dataColRequester = new System.Data.DataColumn();
            this.dataColRecordDate = new System.Data.DataColumn();
            this.dataColRemark = new System.Data.DataColumn();
            this.dataColParentAutoQuotationNo = new System.Data.DataColumn();
            this.dataColParentAutoSalesOrderNo = new System.Data.DataColumn();
            this.dataColParentProjectNo = new System.Data.DataColumn();
            this.dataColPrepared = new System.Data.DataColumn();
            this.dataColPreparedIp = new System.Data.DataColumn();
            this.dataColModifier = new System.Data.DataColumn();
            this.dataColModifierIp = new System.Data.DataColumn();
            this.dataColModifierTime = new System.Data.DataColumn();
            this.TableQuotationPriceInfo = new System.Data.DataTable();
            this.dataColuAutoId = new System.Data.DataColumn();
            this.dataColuAutoQuotationNo = new System.Data.DataColumn();
            this.dataColuCurrencyCate = new System.Data.DataColumn();
            this.dataColuAmount = new System.Data.DataColumn();
            this.dataColuOfferer = new System.Data.DataColumn();
            this.dataColuQuotationDate = new System.Data.DataColumn();
            this.dataColuVersions = new System.Data.DataColumn();
            this.dataColuQuotationState = new System.Data.DataColumn();
            this.dataColuRemark = new System.Data.DataColumn();
            this.dataColuTax = new System.Data.DataColumn();
            this.dataColuTaxAmount = new System.Data.DataColumn();
            this.dataColuSumAmount = new System.Data.DataColumn();
            this.pnlRight = new DevExpress.XtraEditors.PanelControl();
            this.pnlBottom = new DevExpress.XtraEditors.PanelControl();
            this.btnListAdd = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlQuotationPriceInfo = new DevExpress.XtraGrid.GridControl();
            this.bindingSource_PriceInfo = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewQuotationPriceInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAutoQuotationNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrencyCate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpCurrencyCate = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSpinQty = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colTax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSpinEditTax = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colTaxAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSumAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOfferer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuotationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repDateQuotationDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colVersions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repbtnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colQuotationState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlEdit = new DevExpress.XtraEditors.PanelControl();
            this.textParentProjectNo = new DevExpress.XtraEditors.TextEdit();
            this.bindingSource_BaseInfo = new System.Windows.Forms.BindingSource(this.components);
            this.labParentProjectNo = new DevExpress.XtraEditors.LabelControl();
            this.textParentAutoSalesOrderNo = new DevExpress.XtraEditors.TextEdit();
            this.labParentAutoSalesOrderNo = new DevExpress.XtraEditors.LabelControl();
            this.textParentAutoQuotationNo = new DevExpress.XtraEditors.TextEdit();
            this.labParentAutoQuotationNo = new DevExpress.XtraEditors.LabelControl();
            this.textProjectName = new DevExpress.XtraEditors.TextEdit();
            this.textModifier = new DevExpress.XtraEditors.TextEdit();
            this.textPrepared = new DevExpress.XtraEditors.TextEdit();
            this.dateModifierTime = new DevExpress.XtraEditors.DateEdit();
            this.labModifierTime = new DevExpress.XtraEditors.LabelControl();
            this.labModifier = new DevExpress.XtraEditors.LabelControl();
            this.labPrepared = new DevExpress.XtraEditors.LabelControl();
            this.labRecordDate = new DevExpress.XtraEditors.LabelControl();
            this.dateRecordDate = new DevExpress.XtraEditors.DateEdit();
            this.textRemark = new DevExpress.XtraEditors.TextEdit();
            this.labRemark = new DevExpress.XtraEditors.LabelControl();
            this.textRequester = new DevExpress.XtraEditors.TextEdit();
            this.labRequester = new DevExpress.XtraEditors.LabelControl();
            this.labBussinessBaseNo = new DevExpress.XtraEditors.LabelControl();
            this.labProjectName = new DevExpress.XtraEditors.LabelControl();
            this.searchBussinessBaseNo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchBussinessBaseNoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnBussinessBaseNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBussinessBaseText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBussinessCategoryText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textRFQNO = new DevExpress.XtraEditors.TextEdit();
            this.labRFQNO = new DevExpress.XtraEditors.LabelControl();
            this.textAutoQuotationNo = new DevExpress.XtraEditors.TextEdit();
            this.labAutoQuotationNo = new DevExpress.XtraEditors.LabelControl();
            this.pnlToolBar = new DevExpress.XtraEditors.PanelControl();
            this.btnPreview = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.dockManagerLeft = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPnlLeft = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.pnlLeftGrid = new DevExpress.XtraEditors.PanelControl();
            this.gridControlQuotation = new DevExpress.XtraGrid.GridControl();
            this.gridViewQuotation = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAutoQuotationNo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBussinessBaseNo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSearchLookUpBussinessBaseNo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecordDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRFQNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRequester = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParentAutoQuotationNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrepared1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPreparedIp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifier1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifierIp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifierTime1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParentAutoSalesOrderNo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParentProjectNo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlLeftTop = new DevExpress.XtraEditors.PanelControl();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.searchLookUpBussinessBaseNo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpBussinessBaseNoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelBussinessBaseNo = new DevExpress.XtraEditors.LabelControl();
            this.textCommon = new DevExpress.XtraEditors.TextEdit();
            this.labCommon = new DevExpress.XtraEditors.LabelControl();
            this.dateRecordDateEnd = new DevExpress.XtraEditors.DateEdit();
            this.dateRecordDateBegin = new DevExpress.XtraEditors.DateEdit();
            this.lab1 = new DevExpress.XtraEditors.LabelControl();
            this.labelRecordDate = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Quotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableQuotationBaseInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableQuotationPriceInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).BeginInit();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).BeginInit();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlQuotationPriceInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_PriceInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewQuotationPriceInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpCurrencyCate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinEditTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateQuotationDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateQuotationDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repbtnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).BeginInit();
            this.pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textParentProjectNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_BaseInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textParentAutoSalesOrderNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textParentAutoQuotationNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textProjectName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textModifier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPrepared.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateModifierTime.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateModifierTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRecordDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRecordDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRequester.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBussinessBaseNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBussinessBaseNoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRFQNO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAutoQuotationNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).BeginInit();
            this.pnlToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dockManagerLeft)).BeginInit();
            this.dockPnlLeft.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeftGrid)).BeginInit();
            this.pnlLeftGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlQuotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewQuotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchLookUpBussinessBaseNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeftTop)).BeginInit();
            this.pnlLeftTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpBussinessBaseNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpBussinessBaseNoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCommon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRecordDateEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRecordDateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRecordDateBegin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRecordDateBegin.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet_Quotation
            // 
            this.dataSet_Quotation.DataSetName = "NewDataSet";
            this.dataSet_Quotation.Tables.AddRange(new System.Data.DataTable[] {
            this.TableQuotationBaseInfo,
            this.TableQuotationPriceInfo});
            // 
            // TableQuotationBaseInfo
            // 
            this.TableQuotationBaseInfo.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColAutoId,
            this.dataColAutoQuotationNo,
            this.dataColRFQNO,
            this.dataColProjectName,
            this.dataColBussinessBaseNo,
            this.dataColRequester,
            this.dataColRecordDate,
            this.dataColRemark,
            this.dataColParentAutoQuotationNo,
            this.dataColParentAutoSalesOrderNo,
            this.dataColParentProjectNo,
            this.dataColPrepared,
            this.dataColPreparedIp,
            this.dataColModifier,
            this.dataColModifierIp,
            this.dataColModifierTime});
            this.TableQuotationBaseInfo.TableName = "QuotationBaseInfo";
            this.TableQuotationBaseInfo.TableNewRow += new System.Data.DataTableNewRowEventHandler(this.TableQuotationBaseInfo_TableNewRow);
            // 
            // dataColAutoId
            // 
            this.dataColAutoId.ColumnName = "AutoId";
            this.dataColAutoId.DataType = typeof(int);
            // 
            // dataColAutoQuotationNo
            // 
            this.dataColAutoQuotationNo.Caption = "报价单号";
            this.dataColAutoQuotationNo.ColumnName = "AutoQuotationNo";
            // 
            // dataColRFQNO
            // 
            this.dataColRFQNO.Caption = "手动单号";
            this.dataColRFQNO.ColumnName = "RFQNO";
            // 
            // dataColProjectName
            // 
            this.dataColProjectName.Caption = "项目名称";
            this.dataColProjectName.ColumnName = "ProjectName";
            // 
            // dataColBussinessBaseNo
            // 
            this.dataColBussinessBaseNo.Caption = "客户";
            this.dataColBussinessBaseNo.ColumnName = "BussinessBaseNo";
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
            // dataColRemark
            // 
            this.dataColRemark.Caption = "备注";
            this.dataColRemark.ColumnName = "Remark";
            // 
            // dataColParentAutoQuotationNo
            // 
            this.dataColParentAutoQuotationNo.Caption = "父级报价单号";
            this.dataColParentAutoQuotationNo.ColumnName = "ParentAutoQuotationNo";
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
            // TableQuotationPriceInfo
            // 
            this.TableQuotationPriceInfo.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColuAutoId,
            this.dataColuAutoQuotationNo,
            this.dataColuCurrencyCate,
            this.dataColuAmount,
            this.dataColuOfferer,
            this.dataColuQuotationDate,
            this.dataColuVersions,
            this.dataColuQuotationState,
            this.dataColuRemark,
            this.dataColuTax,
            this.dataColuTaxAmount,
            this.dataColuSumAmount});
            this.TableQuotationPriceInfo.TableName = "QuotationPriceInfo";
            this.TableQuotationPriceInfo.TableNewRow += new System.Data.DataTableNewRowEventHandler(this.TableQuotationPriceInfo_TableNewRow);
            // 
            // dataColuAutoId
            // 
            this.dataColuAutoId.ColumnName = "AutoId";
            this.dataColuAutoId.DataType = typeof(int);
            // 
            // dataColuAutoQuotationNo
            // 
            this.dataColuAutoQuotationNo.Caption = "报价单号";
            this.dataColuAutoQuotationNo.ColumnName = "AutoQuotationNo";
            // 
            // dataColuCurrencyCate
            // 
            this.dataColuCurrencyCate.Caption = "币种";
            this.dataColuCurrencyCate.ColumnName = "CurrencyCate";
            this.dataColuCurrencyCate.DataType = typeof(int);
            // 
            // dataColuAmount
            // 
            this.dataColuAmount.Caption = "金额";
            this.dataColuAmount.ColumnName = "Amount";
            this.dataColuAmount.DataType = typeof(decimal);
            // 
            // dataColuOfferer
            // 
            this.dataColuOfferer.Caption = "报价人";
            this.dataColuOfferer.ColumnName = "Offerer";
            // 
            // dataColuQuotationDate
            // 
            this.dataColuQuotationDate.Caption = "报价日期";
            this.dataColuQuotationDate.ColumnName = "QuotationDate";
            this.dataColuQuotationDate.DataType = typeof(System.DateTime);
            // 
            // dataColuVersions
            // 
            this.dataColuVersions.Caption = "版本";
            this.dataColuVersions.ColumnName = "Versions";
            // 
            // dataColuQuotationState
            // 
            this.dataColuQuotationState.Caption = "单据状态";
            this.dataColuQuotationState.ColumnName = "QuotationState";
            this.dataColuQuotationState.DataType = typeof(int);
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
            // pnlRight
            // 
            this.pnlRight.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlRight.Controls.Add(this.pnlBottom);
            this.pnlRight.Controls.Add(this.pnlEdit);
            this.pnlRight.Controls.Add(this.pnlToolBar);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(350, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(781, 542);
            this.pnlRight.TabIndex = 0;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnListAdd);
            this.pnlBottom.Controls.Add(this.gridControlQuotationPriceInfo);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(0, 205);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(781, 337);
            this.pnlBottom.TabIndex = 8;
            // 
            // btnListAdd
            // 
            this.btnListAdd.Enabled = false;
            this.btnListAdd.Location = new System.Drawing.Point(2, 2);
            this.btnListAdd.Name = "btnListAdd";
            this.btnListAdd.Size = new System.Drawing.Size(40, 21);
            this.btnListAdd.TabIndex = 6;
            this.btnListAdd.Text = "+";
            this.btnListAdd.Click += new System.EventHandler(this.btnListAdd_Click);
            // 
            // gridControlQuotationPriceInfo
            // 
            this.gridControlQuotationPriceInfo.DataSource = this.bindingSource_PriceInfo;
            this.gridControlQuotationPriceInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlQuotationPriceInfo.Location = new System.Drawing.Point(2, 2);
            this.gridControlQuotationPriceInfo.MainView = this.gridViewQuotationPriceInfo;
            this.gridControlQuotationPriceInfo.Name = "gridControlQuotationPriceInfo";
            this.gridControlQuotationPriceInfo.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repSpinQty,
            this.repbtnDelete,
            this.repLookUpCurrencyCate,
            this.repDateQuotationDate,
            this.repSpinEditTax});
            this.gridControlQuotationPriceInfo.Size = new System.Drawing.Size(777, 333);
            this.gridControlQuotationPriceInfo.TabIndex = 3;
            this.gridControlQuotationPriceInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewQuotationPriceInfo});
            // 
            // bindingSource_PriceInfo
            // 
            this.bindingSource_PriceInfo.DataMember = "QuotationPriceInfo";
            this.bindingSource_PriceInfo.DataSource = this.dataSet_Quotation;
            // 
            // gridViewQuotationPriceInfo
            // 
            this.gridViewQuotationPriceInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.colAutoQuotationNo,
            this.colCurrencyCate,
            this.colAmount,
            this.colTax,
            this.colTaxAmount,
            this.colSumAmount,
            this.colOfferer,
            this.colQuotationDate,
            this.colVersions,
            this.colRemark,
            this.colDelete,
            this.colQuotationState});
            this.gridViewQuotationPriceInfo.GridControl = this.gridControlQuotationPriceInfo;
            this.gridViewQuotationPriceInfo.IndicatorWidth = 40;
            this.gridViewQuotationPriceInfo.Name = "gridViewQuotationPriceInfo";
            this.gridViewQuotationPriceInfo.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewQuotationPriceInfo.OptionsBehavior.Editable = false;
            this.gridViewQuotationPriceInfo.OptionsMenu.EnableColumnMenu = false;
            this.gridViewQuotationPriceInfo.OptionsMenu.EnableFooterMenu = false;
            this.gridViewQuotationPriceInfo.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewQuotationPriceInfo.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewQuotationPriceInfo.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewQuotationPriceInfo.OptionsView.ColumnAutoWidth = false;
            this.gridViewQuotationPriceInfo.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewQuotationPriceInfo.OptionsView.ShowFooter = true;
            this.gridViewQuotationPriceInfo.OptionsView.ShowGroupPanel = false;
            this.gridViewQuotationPriceInfo.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewQuotationPriceInfo_CustomDrawRowIndicator);
            this.gridViewQuotationPriceInfo.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewQuotationPriceInfo_CellValueChanged);
            this.gridViewQuotationPriceInfo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewQuotationPriceInfo_KeyDown);
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "AutoId";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // colAutoQuotationNo
            // 
            this.colAutoQuotationNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colAutoQuotationNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAutoQuotationNo.FieldName = "AutoQuotationNo";
            this.colAutoQuotationNo.Name = "colAutoQuotationNo";
            this.colAutoQuotationNo.OptionsColumn.AllowEdit = false;
            this.colAutoQuotationNo.Width = 100;
            // 
            // colCurrencyCate
            // 
            this.colCurrencyCate.AppearanceHeader.Options.UseTextOptions = true;
            this.colCurrencyCate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCurrencyCate.ColumnEdit = this.repLookUpCurrencyCate;
            this.colCurrencyCate.FieldName = "CurrencyCate";
            this.colCurrencyCate.Name = "colCurrencyCate";
            this.colCurrencyCate.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "CurrencyCate", "共计{0}条")});
            this.colCurrencyCate.Visible = true;
            this.colCurrencyCate.VisibleIndex = 0;
            this.colCurrencyCate.Width = 120;
            // 
            // repLookUpCurrencyCate
            // 
            this.repLookUpCurrencyCate.AutoHeight = false;
            this.repLookUpCurrencyCate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpCurrencyCate.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AutoId", "AutoId", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CurrencyCateAbb", "币种缩写"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CurrencyCateName", "币种名称"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ExchangeRate", "汇率")});
            this.repLookUpCurrencyCate.DisplayMember = "CurrencyCateName";
            this.repLookUpCurrencyCate.Name = "repLookUpCurrencyCate";
            this.repLookUpCurrencyCate.NullText = "";
            this.repLookUpCurrencyCate.ValueMember = "AutoId";
            // 
            // colAmount
            // 
            this.colAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAmount.ColumnEdit = this.repSpinQty;
            this.colAmount.DisplayFormat.FormatString = "N2";
            this.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "{0:N2}")});
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 1;
            this.colAmount.Width = 100;
            // 
            // repSpinQty
            // 
            this.repSpinQty.AutoHeight = false;
            this.repSpinQty.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repSpinQty.DisplayFormat.FormatString = "N2";
            this.repSpinQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repSpinQty.EditFormat.FormatString = "N2";
            this.repSpinQty.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repSpinQty.MaxValue = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.repSpinQty.Name = "repSpinQty";
            // 
            // colTax
            // 
            this.colTax.AppearanceHeader.Options.UseTextOptions = true;
            this.colTax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTax.ColumnEdit = this.repSpinEditTax;
            this.colTax.DisplayFormat.FormatString = "p0";
            this.colTax.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTax.FieldName = "Tax";
            this.colTax.Name = "colTax";
            this.colTax.Visible = true;
            this.colTax.VisibleIndex = 2;
            this.colTax.Width = 100;
            // 
            // repSpinEditTax
            // 
            this.repSpinEditTax.AutoHeight = false;
            this.repSpinEditTax.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repSpinEditTax.DisplayFormat.FormatString = "p0";
            this.repSpinEditTax.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repSpinEditTax.EditFormat.FormatString = "p0";
            this.repSpinEditTax.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repSpinEditTax.Mask.EditMask = "p0";
            this.repSpinEditTax.Name = "repSpinEditTax";
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
            this.colTaxAmount.OptionsColumn.TabStop = false;
            this.colTaxAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TaxAmount", "{0:N2}")});
            this.colTaxAmount.Visible = true;
            this.colTaxAmount.VisibleIndex = 3;
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
            this.colSumAmount.OptionsColumn.TabStop = false;
            this.colSumAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SumAmount", "{0:N2}")});
            this.colSumAmount.Visible = true;
            this.colSumAmount.VisibleIndex = 4;
            this.colSumAmount.Width = 100;
            // 
            // colOfferer
            // 
            this.colOfferer.AppearanceHeader.Options.UseTextOptions = true;
            this.colOfferer.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOfferer.FieldName = "Offerer";
            this.colOfferer.Name = "colOfferer";
            this.colOfferer.OptionsColumn.TabStop = false;
            this.colOfferer.Visible = true;
            this.colOfferer.VisibleIndex = 7;
            this.colOfferer.Width = 100;
            // 
            // colQuotationDate
            // 
            this.colQuotationDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colQuotationDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQuotationDate.ColumnEdit = this.repDateQuotationDate;
            this.colQuotationDate.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.colQuotationDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colQuotationDate.FieldName = "QuotationDate";
            this.colQuotationDate.Name = "colQuotationDate";
            this.colQuotationDate.OptionsColumn.TabStop = false;
            this.colQuotationDate.Visible = true;
            this.colQuotationDate.VisibleIndex = 8;
            this.colQuotationDate.Width = 150;
            // 
            // repDateQuotationDate
            // 
            this.repDateQuotationDate.AutoHeight = false;
            this.repDateQuotationDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repDateQuotationDate.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repDateQuotationDate.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.repDateQuotationDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repDateQuotationDate.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.repDateQuotationDate.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repDateQuotationDate.Mask.EditMask = "G";
            this.repDateQuotationDate.Name = "repDateQuotationDate";
            // 
            // colVersions
            // 
            this.colVersions.AppearanceHeader.Options.UseTextOptions = true;
            this.colVersions.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colVersions.FieldName = "Versions";
            this.colVersions.Name = "colVersions";
            this.colVersions.Visible = true;
            this.colVersions.VisibleIndex = 5;
            this.colVersions.Width = 80;
            // 
            // colRemark
            // 
            this.colRemark.AppearanceHeader.Options.UseTextOptions = true;
            this.colRemark.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 6;
            this.colRemark.Width = 180;
            // 
            // colDelete
            // 
            this.colDelete.ColumnEdit = this.repbtnDelete;
            this.colDelete.Name = "colDelete";
            this.colDelete.OptionsColumn.TabStop = false;
            this.colDelete.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 9;
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
            // colQuotationState
            // 
            this.colQuotationState.FieldName = "QuotationState";
            this.colQuotationState.Name = "colQuotationState";
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.textParentProjectNo);
            this.pnlEdit.Controls.Add(this.labParentProjectNo);
            this.pnlEdit.Controls.Add(this.textParentAutoSalesOrderNo);
            this.pnlEdit.Controls.Add(this.labParentAutoSalesOrderNo);
            this.pnlEdit.Controls.Add(this.textParentAutoQuotationNo);
            this.pnlEdit.Controls.Add(this.labParentAutoQuotationNo);
            this.pnlEdit.Controls.Add(this.textProjectName);
            this.pnlEdit.Controls.Add(this.textModifier);
            this.pnlEdit.Controls.Add(this.textPrepared);
            this.pnlEdit.Controls.Add(this.dateModifierTime);
            this.pnlEdit.Controls.Add(this.labModifierTime);
            this.pnlEdit.Controls.Add(this.labModifier);
            this.pnlEdit.Controls.Add(this.labPrepared);
            this.pnlEdit.Controls.Add(this.labRecordDate);
            this.pnlEdit.Controls.Add(this.dateRecordDate);
            this.pnlEdit.Controls.Add(this.textRemark);
            this.pnlEdit.Controls.Add(this.labRemark);
            this.pnlEdit.Controls.Add(this.textRequester);
            this.pnlEdit.Controls.Add(this.labRequester);
            this.pnlEdit.Controls.Add(this.labBussinessBaseNo);
            this.pnlEdit.Controls.Add(this.labProjectName);
            this.pnlEdit.Controls.Add(this.searchBussinessBaseNo);
            this.pnlEdit.Controls.Add(this.textRFQNO);
            this.pnlEdit.Controls.Add(this.labRFQNO);
            this.pnlEdit.Controls.Add(this.textAutoQuotationNo);
            this.pnlEdit.Controls.Add(this.labAutoQuotationNo);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEdit.Location = new System.Drawing.Point(0, 40);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(781, 165);
            this.pnlEdit.TabIndex = 7;
            // 
            // textParentProjectNo
            // 
            this.textParentProjectNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_BaseInfo, "ParentProjectNo", true));
            this.textParentProjectNo.EnterMoveNextControl = true;
            this.textParentProjectNo.Location = new System.Drawing.Point(863, 89);
            this.textParentProjectNo.Name = "textParentProjectNo";
            this.textParentProjectNo.Properties.ReadOnly = true;
            this.textParentProjectNo.Size = new System.Drawing.Size(150, 20);
            this.textParentProjectNo.TabIndex = 12;
            this.textParentProjectNo.TabStop = false;
            this.textParentProjectNo.Visible = false;
            // 
            // bindingSource_BaseInfo
            // 
            this.bindingSource_BaseInfo.DataMember = "QuotationBaseInfo";
            this.bindingSource_BaseInfo.DataSource = this.dataSet_Quotation;
            // 
            // labParentProjectNo
            // 
            this.labParentProjectNo.Location = new System.Drawing.Point(768, 92);
            this.labParentProjectNo.Name = "labParentProjectNo";
            this.labParentProjectNo.Size = new System.Drawing.Size(60, 14);
            this.labParentProjectNo.TabIndex = 27;
            this.labParentProjectNo.Text = "父级项目号";
            this.labParentProjectNo.Visible = false;
            // 
            // textParentAutoSalesOrderNo
            // 
            this.textParentAutoSalesOrderNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_BaseInfo, "ParentAutoSalesOrderNo", true));
            this.textParentAutoSalesOrderNo.EnterMoveNextControl = true;
            this.textParentAutoSalesOrderNo.Location = new System.Drawing.Point(863, 55);
            this.textParentAutoSalesOrderNo.Name = "textParentAutoSalesOrderNo";
            this.textParentAutoSalesOrderNo.Properties.ReadOnly = true;
            this.textParentAutoSalesOrderNo.Size = new System.Drawing.Size(150, 20);
            this.textParentAutoSalesOrderNo.TabIndex = 11;
            this.textParentAutoSalesOrderNo.TabStop = false;
            this.textParentAutoSalesOrderNo.Visible = false;
            // 
            // labParentAutoSalesOrderNo
            // 
            this.labParentAutoSalesOrderNo.Location = new System.Drawing.Point(768, 58);
            this.labParentAutoSalesOrderNo.Name = "labParentAutoSalesOrderNo";
            this.labParentAutoSalesOrderNo.Size = new System.Drawing.Size(84, 14);
            this.labParentAutoSalesOrderNo.TabIndex = 25;
            this.labParentAutoSalesOrderNo.Text = "父级销售订单号";
            this.labParentAutoSalesOrderNo.Visible = false;
            // 
            // textParentAutoQuotationNo
            // 
            this.textParentAutoQuotationNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_BaseInfo, "ParentAutoQuotationNo", true));
            this.textParentAutoQuotationNo.EnterMoveNextControl = true;
            this.textParentAutoQuotationNo.Location = new System.Drawing.Point(863, 21);
            this.textParentAutoQuotationNo.Name = "textParentAutoQuotationNo";
            this.textParentAutoQuotationNo.Properties.ReadOnly = true;
            this.textParentAutoQuotationNo.Size = new System.Drawing.Size(150, 20);
            this.textParentAutoQuotationNo.TabIndex = 10;
            this.textParentAutoQuotationNo.TabStop = false;
            this.textParentAutoQuotationNo.Visible = false;
            // 
            // labParentAutoQuotationNo
            // 
            this.labParentAutoQuotationNo.Location = new System.Drawing.Point(768, 24);
            this.labParentAutoQuotationNo.Name = "labParentAutoQuotationNo";
            this.labParentAutoQuotationNo.Size = new System.Drawing.Size(72, 14);
            this.labParentAutoQuotationNo.TabIndex = 23;
            this.labParentAutoQuotationNo.Text = "父级报价单号";
            this.labParentAutoQuotationNo.Visible = false;
            // 
            // textProjectName
            // 
            this.textProjectName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_BaseInfo, "ProjectName", true));
            this.textProjectName.EnterMoveNextControl = true;
            this.textProjectName.Location = new System.Drawing.Point(597, 21);
            this.textProjectName.Name = "textProjectName";
            this.textProjectName.Size = new System.Drawing.Size(150, 20);
            this.textProjectName.TabIndex = 2;
            // 
            // textModifier
            // 
            this.textModifier.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_BaseInfo, "Modifier", true));
            this.textModifier.EnterMoveNextControl = true;
            this.textModifier.Location = new System.Drawing.Point(354, 123);
            this.textModifier.Name = "textModifier";
            this.textModifier.Properties.ReadOnly = true;
            this.textModifier.Size = new System.Drawing.Size(150, 20);
            this.textModifier.TabIndex = 8;
            this.textModifier.TabStop = false;
            // 
            // textPrepared
            // 
            this.textPrepared.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_BaseInfo, "Prepared", true));
            this.textPrepared.EnterMoveNextControl = true;
            this.textPrepared.Location = new System.Drawing.Point(112, 123);
            this.textPrepared.Name = "textPrepared";
            this.textPrepared.Properties.ReadOnly = true;
            this.textPrepared.Size = new System.Drawing.Size(150, 20);
            this.textPrepared.TabIndex = 7;
            this.textPrepared.TabStop = false;
            // 
            // dateModifierTime
            // 
            this.dateModifierTime.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_BaseInfo, "ModifierTime", true));
            this.dateModifierTime.EditValue = null;
            this.dateModifierTime.EnterMoveNextControl = true;
            this.dateModifierTime.Location = new System.Drawing.Point(597, 123);
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
            this.dateModifierTime.TabIndex = 9;
            this.dateModifierTime.TabStop = false;
            // 
            // labModifierTime
            // 
            this.labModifierTime.Location = new System.Drawing.Point(525, 126);
            this.labModifierTime.Name = "labModifierTime";
            this.labModifierTime.Size = new System.Drawing.Size(48, 14);
            this.labModifierTime.TabIndex = 17;
            this.labModifierTime.Text = "修改时间";
            // 
            // labModifier
            // 
            this.labModifier.Location = new System.Drawing.Point(281, 126);
            this.labModifier.Name = "labModifier";
            this.labModifier.Size = new System.Drawing.Size(36, 14);
            this.labModifier.TabIndex = 16;
            this.labModifier.Text = "修改人";
            // 
            // labPrepared
            // 
            this.labPrepared.Location = new System.Drawing.Point(36, 126);
            this.labPrepared.Name = "labPrepared";
            this.labPrepared.Size = new System.Drawing.Size(36, 14);
            this.labPrepared.TabIndex = 14;
            this.labPrepared.Text = "制单人";
            // 
            // labRecordDate
            // 
            this.labRecordDate.Location = new System.Drawing.Point(525, 58);
            this.labRecordDate.Name = "labRecordDate";
            this.labRecordDate.Size = new System.Drawing.Size(48, 14);
            this.labRecordDate.TabIndex = 13;
            this.labRecordDate.Text = "登记日期";
            // 
            // dateRecordDate
            // 
            this.dateRecordDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_BaseInfo, "RecordDate", true));
            this.dateRecordDate.EditValue = null;
            this.dateRecordDate.EnterMoveNextControl = true;
            this.dateRecordDate.Location = new System.Drawing.Point(597, 55);
            this.dateRecordDate.Name = "dateRecordDate";
            this.dateRecordDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateRecordDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateRecordDate.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dateRecordDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateRecordDate.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dateRecordDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateRecordDate.Properties.Mask.EditMask = "G";
            this.dateRecordDate.Properties.ReadOnly = true;
            this.dateRecordDate.Size = new System.Drawing.Size(150, 20);
            this.dateRecordDate.TabIndex = 5;
            this.dateRecordDate.TabStop = false;
            // 
            // textRemark
            // 
            this.textRemark.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_BaseInfo, "Remark", true));
            this.textRemark.EnterMoveNextControl = true;
            this.textRemark.Location = new System.Drawing.Point(112, 89);
            this.textRemark.Name = "textRemark";
            this.textRemark.Size = new System.Drawing.Size(635, 20);
            this.textRemark.TabIndex = 6;
            // 
            // labRemark
            // 
            this.labRemark.Location = new System.Drawing.Point(36, 92);
            this.labRemark.Name = "labRemark";
            this.labRemark.Size = new System.Drawing.Size(24, 14);
            this.labRemark.TabIndex = 10;
            this.labRemark.Text = "备注";
            // 
            // textRequester
            // 
            this.textRequester.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_BaseInfo, "Requester", true));
            this.textRequester.EnterMoveNextControl = true;
            this.textRequester.Location = new System.Drawing.Point(354, 55);
            this.textRequester.Name = "textRequester";
            this.textRequester.Size = new System.Drawing.Size(150, 20);
            this.textRequester.TabIndex = 4;
            // 
            // labRequester
            // 
            this.labRequester.Location = new System.Drawing.Point(281, 58);
            this.labRequester.Name = "labRequester";
            this.labRequester.Size = new System.Drawing.Size(60, 14);
            this.labRequester.TabIndex = 8;
            this.labRequester.Text = "客户需求人";
            // 
            // labBussinessBaseNo
            // 
            this.labBussinessBaseNo.Location = new System.Drawing.Point(36, 58);
            this.labBussinessBaseNo.Name = "labBussinessBaseNo";
            this.labBussinessBaseNo.Size = new System.Drawing.Size(24, 14);
            this.labBussinessBaseNo.TabIndex = 7;
            this.labBussinessBaseNo.Text = "客户";
            // 
            // labProjectName
            // 
            this.labProjectName.Location = new System.Drawing.Point(525, 24);
            this.labProjectName.Name = "labProjectName";
            this.labProjectName.Size = new System.Drawing.Size(48, 14);
            this.labProjectName.TabIndex = 6;
            this.labProjectName.Text = "项目名称";
            // 
            // searchBussinessBaseNo
            // 
            this.searchBussinessBaseNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_BaseInfo, "BussinessBaseNo", true));
            this.searchBussinessBaseNo.EnterMoveNextControl = true;
            this.searchBussinessBaseNo.Location = new System.Drawing.Point(112, 55);
            this.searchBussinessBaseNo.Name = "searchBussinessBaseNo";
            this.searchBussinessBaseNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchBussinessBaseNo.Properties.DisplayMember = "BussinessBaseText";
            this.searchBussinessBaseNo.Properties.NullText = "";
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
            this.searchBussinessBaseNoView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewQuotationPriceInfo_CustomDrawRowIndicator);
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
            // textRFQNO
            // 
            this.textRFQNO.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_BaseInfo, "RFQNO", true));
            this.textRFQNO.EnterMoveNextControl = true;
            this.textRFQNO.Location = new System.Drawing.Point(354, 21);
            this.textRFQNO.Name = "textRFQNO";
            this.textRFQNO.Size = new System.Drawing.Size(150, 20);
            this.textRFQNO.TabIndex = 1;
            // 
            // labRFQNO
            // 
            this.labRFQNO.Location = new System.Drawing.Point(281, 24);
            this.labRFQNO.Name = "labRFQNO";
            this.labRFQNO.Size = new System.Drawing.Size(48, 14);
            this.labRFQNO.TabIndex = 2;
            this.labRFQNO.Text = "手工单号";
            // 
            // textAutoQuotationNo
            // 
            this.textAutoQuotationNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_BaseInfo, "AutoQuotationNo", true));
            this.textAutoQuotationNo.EnterMoveNextControl = true;
            this.textAutoQuotationNo.Location = new System.Drawing.Point(112, 21);
            this.textAutoQuotationNo.Name = "textAutoQuotationNo";
            this.textAutoQuotationNo.Properties.ReadOnly = true;
            this.textAutoQuotationNo.Size = new System.Drawing.Size(150, 20);
            this.textAutoQuotationNo.TabIndex = 0;
            this.textAutoQuotationNo.TabStop = false;
            // 
            // labAutoQuotationNo
            // 
            this.labAutoQuotationNo.Location = new System.Drawing.Point(36, 24);
            this.labAutoQuotationNo.Name = "labAutoQuotationNo";
            this.labAutoQuotationNo.Size = new System.Drawing.Size(48, 14);
            this.labAutoQuotationNo.TabIndex = 0;
            this.labAutoQuotationNo.Text = "报价单号";
            // 
            // pnlToolBar
            // 
            this.pnlToolBar.Controls.Add(this.btnPreview);
            this.pnlToolBar.Controls.Add(this.btnDelete);
            this.pnlToolBar.Controls.Add(this.btnCancel);
            this.pnlToolBar.Controls.Add(this.btnSave);
            this.pnlToolBar.Controls.Add(this.btnNew);
            this.pnlToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolBar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolBar.Name = "pnlToolBar";
            this.pnlToolBar.Size = new System.Drawing.Size(781, 40);
            this.pnlToolBar.TabIndex = 6;
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
            this.dockPnlLeft.ID = new System.Guid("f8ab1b51-ed8d-4640-b32d-4d03b1f73c6c");
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
            this.dockPnlLeft.Size = new System.Drawing.Size(350, 542);
            this.dockPnlLeft.Text = "历史报价单";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.pnlLeftGrid);
            this.dockPanel1_Container.Controls.Add(this.pnlLeftTop);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(342, 515);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // pnlLeftGrid
            // 
            this.pnlLeftGrid.Controls.Add(this.gridControlQuotation);
            this.pnlLeftGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeftGrid.Location = new System.Drawing.Point(0, 110);
            this.pnlLeftGrid.Name = "pnlLeftGrid";
            this.pnlLeftGrid.Size = new System.Drawing.Size(342, 405);
            this.pnlLeftGrid.TabIndex = 5;
            // 
            // gridControlQuotation
            // 
            this.gridControlQuotation.AllowDrop = true;
            this.gridControlQuotation.DataSource = this.bindingSource_BaseInfo;
            this.gridControlQuotation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlQuotation.Location = new System.Drawing.Point(2, 2);
            this.gridControlQuotation.MainView = this.gridViewQuotation;
            this.gridControlQuotation.Name = "gridControlQuotation";
            this.gridControlQuotation.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repSearchLookUpBussinessBaseNo});
            this.gridControlQuotation.Size = new System.Drawing.Size(338, 401);
            this.gridControlQuotation.TabIndex = 5;
            this.gridControlQuotation.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewQuotation});
            // 
            // gridViewQuotation
            // 
            this.gridViewQuotation.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId1,
            this.colAutoQuotationNo1,
            this.colBussinessBaseNo1,
            this.colRecordDate,
            this.colProjectName,
            this.colRFQNO,
            this.colRequester,
            this.colParentAutoQuotationNo,
            this.colPrepared1,
            this.colPreparedIp,
            this.colModifier1,
            this.colModifierIp,
            this.colModifierTime1,
            this.colRemark1,
            this.colParentAutoSalesOrderNo1,
            this.colParentProjectNo1});
            this.gridViewQuotation.GridControl = this.gridControlQuotation;
            this.gridViewQuotation.IndicatorWidth = 40;
            this.gridViewQuotation.Name = "gridViewQuotation";
            this.gridViewQuotation.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewQuotation.OptionsBehavior.Editable = false;
            this.gridViewQuotation.OptionsBehavior.ReadOnly = true;
            this.gridViewQuotation.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewQuotation.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewQuotation.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewQuotation.OptionsSelection.MultiSelect = true;
            this.gridViewQuotation.OptionsView.ColumnAutoWidth = false;
            this.gridViewQuotation.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewQuotation.OptionsView.ShowFooter = true;
            this.gridViewQuotation.OptionsView.ShowGroupPanel = false;
            this.gridViewQuotation.OptionsView.ShowIndicator = false;
            this.gridViewQuotation.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewQuotation_FocusedRowChanged);
            this.gridViewQuotation.BeforeLeaveRow += new DevExpress.XtraGrid.Views.Base.RowAllowEventHandler(this.gridViewQuotation_BeforeLeaveRow);
            this.gridViewQuotation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewQuotationPriceInfo_KeyDown);
            // 
            // colAutoId1
            // 
            this.colAutoId1.FieldName = "AutoId";
            this.colAutoId1.Name = "colAutoId1";
            // 
            // colAutoQuotationNo1
            // 
            this.colAutoQuotationNo1.AppearanceHeader.Options.UseTextOptions = true;
            this.colAutoQuotationNo1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAutoQuotationNo1.FieldName = "AutoQuotationNo";
            this.colAutoQuotationNo1.Name = "colAutoQuotationNo1";
            this.colAutoQuotationNo1.Visible = true;
            this.colAutoQuotationNo1.VisibleIndex = 0;
            this.colAutoQuotationNo1.Width = 110;
            // 
            // colBussinessBaseNo1
            // 
            this.colBussinessBaseNo1.AppearanceHeader.Options.UseTextOptions = true;
            this.colBussinessBaseNo1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBussinessBaseNo1.ColumnEdit = this.repSearchLookUpBussinessBaseNo;
            this.colBussinessBaseNo1.FieldName = "BussinessBaseNo";
            this.colBussinessBaseNo1.Name = "colBussinessBaseNo1";
            this.colBussinessBaseNo1.Visible = true;
            this.colBussinessBaseNo1.VisibleIndex = 1;
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
            this.repSearchLookUpBussinessBaseNo.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.IndicatorWidth = 60;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            // colRecordDate
            // 
            this.colRecordDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colRecordDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRecordDate.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.colRecordDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colRecordDate.FieldName = "RecordDate";
            this.colRecordDate.Name = "colRecordDate";
            this.colRecordDate.Visible = true;
            this.colRecordDate.VisibleIndex = 3;
            this.colRecordDate.Width = 80;
            // 
            // colProjectName
            // 
            this.colProjectName.AppearanceHeader.Options.UseTextOptions = true;
            this.colProjectName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProjectName.FieldName = "ProjectName";
            this.colProjectName.Name = "colProjectName";
            this.colProjectName.Visible = true;
            this.colProjectName.VisibleIndex = 2;
            this.colProjectName.Width = 90;
            // 
            // colRFQNO
            // 
            this.colRFQNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colRFQNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRFQNO.FieldName = "RFQNO";
            this.colRFQNO.Name = "colRFQNO";
            this.colRFQNO.Visible = true;
            this.colRFQNO.VisibleIndex = 4;
            this.colRFQNO.Width = 100;
            // 
            // colRequester
            // 
            this.colRequester.AppearanceHeader.Options.UseTextOptions = true;
            this.colRequester.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRequester.FieldName = "Requester";
            this.colRequester.Name = "colRequester";
            this.colRequester.Visible = true;
            this.colRequester.VisibleIndex = 5;
            this.colRequester.Width = 80;
            // 
            // colParentAutoQuotationNo
            // 
            this.colParentAutoQuotationNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colParentAutoQuotationNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colParentAutoQuotationNo.FieldName = "ParentAutoQuotationNo";
            this.colParentAutoQuotationNo.Name = "colParentAutoQuotationNo";
            this.colParentAutoQuotationNo.Visible = true;
            this.colParentAutoQuotationNo.VisibleIndex = 6;
            this.colParentAutoQuotationNo.Width = 110;
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
            // pnlLeftTop
            // 
            this.pnlLeftTop.Controls.Add(this.btnQuery);
            this.pnlLeftTop.Controls.Add(this.searchLookUpBussinessBaseNo);
            this.pnlLeftTop.Controls.Add(this.labelBussinessBaseNo);
            this.pnlLeftTop.Controls.Add(this.textCommon);
            this.pnlLeftTop.Controls.Add(this.labCommon);
            this.pnlLeftTop.Controls.Add(this.dateRecordDateEnd);
            this.pnlLeftTop.Controls.Add(this.dateRecordDateBegin);
            this.pnlLeftTop.Controls.Add(this.lab1);
            this.pnlLeftTop.Controls.Add(this.labelRecordDate);
            this.pnlLeftTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeftTop.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftTop.Name = "pnlLeftTop";
            this.pnlLeftTop.Size = new System.Drawing.Size(342, 110);
            this.pnlLeftTop.TabIndex = 1;
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
            this.gridColumn5});
            this.searchLookUpBussinessBaseNoView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpBussinessBaseNoView.IndicatorWidth = 60;
            this.searchLookUpBussinessBaseNoView.Name = "searchLookUpBussinessBaseNoView";
            this.searchLookUpBussinessBaseNoView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpBussinessBaseNoView.OptionsView.ShowGroupPanel = false;
            this.searchLookUpBussinessBaseNoView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewQuotationPriceInfo_CustomDrawRowIndicator);
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
            // gridColumn5
            // 
            this.gridColumn5.Caption = "gridColumnAutoId";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // labelBussinessBaseNo
            // 
            this.labelBussinessBaseNo.Location = new System.Drawing.Point(20, 47);
            this.labelBussinessBaseNo.Name = "labelBussinessBaseNo";
            this.labelBussinessBaseNo.Size = new System.Drawing.Size(48, 14);
            this.labelBussinessBaseNo.TabIndex = 26;
            this.labelBussinessBaseNo.Text = "往来方：";
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
            // dateRecordDateEnd
            // 
            this.dateRecordDateEnd.EditValue = null;
            this.dateRecordDateEnd.EnterMoveNextControl = true;
            this.dateRecordDateEnd.Location = new System.Drawing.Point(202, 14);
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
            this.dateRecordDateEnd.TabIndex = 102;
            // 
            // dateRecordDateBegin
            // 
            this.dateRecordDateBegin.EditValue = null;
            this.dateRecordDateBegin.EnterMoveNextControl = true;
            this.dateRecordDateBegin.Location = new System.Drawing.Point(86, 14);
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
            this.dateRecordDateBegin.TabIndex = 101;
            // 
            // lab1
            // 
            this.lab1.Location = new System.Drawing.Point(192, 17);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(4, 14);
            this.lab1.TabIndex = 10;
            this.lab1.Text = "-";
            // 
            // labelRecordDate
            // 
            this.labelRecordDate.Location = new System.Drawing.Point(20, 17);
            this.labelRecordDate.Name = "labelRecordDate";
            this.labelRecordDate.Size = new System.Drawing.Size(60, 14);
            this.labelRecordDate.TabIndex = 9;
            this.labelRecordDate.Text = "登记日期：";
            // 
            // FrmQuotationInfo_History
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1131, 542);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.dockPnlLeft);
            this.Name = "FrmQuotationInfo_History";
            this.TabText = "报价单";
            this.Text = "报价单";
            this.Activated += new System.EventHandler(this.FrmQuotationInfo_History_Activated);
            this.Load += new System.EventHandler(this.FrmQuotationInfo_History_Load);
            this.Shown += new System.EventHandler(this.FrmQuotationInfo_History_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Quotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableQuotationBaseInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableQuotationPriceInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).EndInit();
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlQuotationPriceInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_PriceInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewQuotationPriceInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpCurrencyCate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinEditTax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateQuotationDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateQuotationDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repbtnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textParentProjectNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_BaseInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textParentAutoSalesOrderNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textParentAutoQuotationNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textProjectName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textModifier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPrepared.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateModifierTime.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateModifierTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRecordDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRecordDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRequester.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBussinessBaseNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBussinessBaseNoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRFQNO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAutoQuotationNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).EndInit();
            this.pnlToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dockManagerLeft)).EndInit();
            this.dockPnlLeft.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeftGrid)).EndInit();
            this.pnlLeftGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlQuotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewQuotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchLookUpBussinessBaseNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeftTop)).EndInit();
            this.pnlLeftTop.ResumeLayout(false);
            this.pnlLeftTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpBussinessBaseNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpBussinessBaseNoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCommon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRecordDateEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRecordDateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRecordDateBegin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRecordDateBegin.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dataSet_Quotation;
        private System.Data.DataTable TableQuotationBaseInfo;
        private System.Data.DataColumn dataColAutoId;
        private System.Data.DataColumn dataColAutoQuotationNo;
        private System.Data.DataColumn dataColRFQNO;
        private System.Data.DataColumn dataColProjectName;
        private System.Data.DataColumn dataColBussinessBaseNo;
        private System.Data.DataColumn dataColRequester;
        private System.Data.DataColumn dataColRecordDate;
        private System.Data.DataColumn dataColRemark;
        private System.Data.DataTable TableQuotationPriceInfo;
        private System.Data.DataColumn dataColuAutoId;
        private System.Data.DataColumn dataColuAutoQuotationNo;
        private System.Data.DataColumn dataColuCurrencyCate;
        private System.Data.DataColumn dataColuAmount;
        private System.Data.DataColumn dataColuOfferer;
        private System.Data.DataColumn dataColuQuotationDate;
        private System.Data.DataColumn dataColuVersions;
        private System.Data.DataColumn dataColuQuotationState;
        private System.Data.DataColumn dataColuRemark;
        private DevExpress.XtraEditors.PanelControl pnlRight;
        private DevExpress.XtraEditors.PanelControl pnlToolBar;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.PanelControl pnlEdit;
        private DevExpress.XtraEditors.PanelControl pnlBottom;
        private System.Windows.Forms.BindingSource bindingSource_BaseInfo;
        private System.Windows.Forms.BindingSource bindingSource_PriceInfo;
        private DevExpress.XtraEditors.TextEdit textAutoQuotationNo;
        private DevExpress.XtraEditors.LabelControl labAutoQuotationNo;
        private DevExpress.XtraEditors.TextEdit textRFQNO;
        private DevExpress.XtraEditors.LabelControl labRFQNO;
        private DevExpress.XtraEditors.LabelControl labBussinessBaseNo;
        private DevExpress.XtraEditors.LabelControl labProjectName;
        private DevExpress.XtraEditors.SearchLookUpEdit searchBussinessBaseNo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchBussinessBaseNoView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBussinessBaseNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBussinessBaseText;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBussinessCategoryText;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnAutoId;
        private DevExpress.XtraEditors.LabelControl labRecordDate;
        private DevExpress.XtraEditors.DateEdit dateRecordDate;
        private DevExpress.XtraEditors.TextEdit textRemark;
        private DevExpress.XtraEditors.LabelControl labRemark;
        private DevExpress.XtraEditors.TextEdit textRequester;
        private DevExpress.XtraEditors.LabelControl labRequester;
        private DevExpress.XtraGrid.GridControl gridControlQuotationPriceInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewQuotationPriceInfo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoQuotationNo;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyCate;
        private DevExpress.XtraGrid.Columns.GridColumn colOfferer;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repSpinQty;
        private DevExpress.XtraGrid.Columns.GridColumn colQuotationDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repbtnDelete;
        private DevExpress.XtraEditors.SimpleButton btnListAdd;
        private DevExpress.XtraGrid.Columns.GridColumn colQuotationState;
        private DevExpress.XtraGrid.Columns.GridColumn colVersions;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpCurrencyCate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repDateQuotationDate;
        private DevExpress.XtraEditors.SimpleButton btnPreview;
        private System.Data.DataColumn dataColuTax;
        private System.Data.DataColumn dataColuTaxAmount;
        private System.Data.DataColumn dataColuSumAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colTax;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colSumAmount;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repSpinEditTax;
        private System.Data.DataColumn dataColParentAutoQuotationNo;
        private System.Data.DataColumn dataColParentAutoSalesOrderNo;
        private System.Data.DataColumn dataColParentProjectNo;
        private System.Data.DataColumn dataColPrepared;
        private System.Data.DataColumn dataColPreparedIp;
        private System.Data.DataColumn dataColModifier;
        private System.Data.DataColumn dataColModifierIp;
        private System.Data.DataColumn dataColModifierTime;
        private DevExpress.XtraEditors.LabelControl labModifierTime;
        private DevExpress.XtraEditors.LabelControl labModifier;
        private DevExpress.XtraEditors.LabelControl labPrepared;
        private DevExpress.XtraEditors.TextEdit textModifier;
        private DevExpress.XtraEditors.TextEdit textPrepared;
        private DevExpress.XtraEditors.DateEdit dateModifierTime;
        private DevExpress.XtraEditors.TextEdit textProjectName;
        private DevExpress.XtraEditors.TextEdit textParentProjectNo;
        private DevExpress.XtraEditors.LabelControl labParentProjectNo;
        private DevExpress.XtraEditors.TextEdit textParentAutoSalesOrderNo;
        private DevExpress.XtraEditors.LabelControl labParentAutoSalesOrderNo;
        private DevExpress.XtraEditors.TextEdit textParentAutoQuotationNo;
        private DevExpress.XtraEditors.LabelControl labParentAutoQuotationNo;
        private DevExpress.XtraBars.Docking.DockManager dockManagerLeft;
        private DevExpress.XtraBars.Docking.DockPanel dockPnlLeft;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraEditors.PanelControl pnlLeftTop;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpBussinessBaseNo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpBussinessBaseNoView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.LabelControl labelBussinessBaseNo;
        private DevExpress.XtraEditors.TextEdit textCommon;
        private DevExpress.XtraEditors.LabelControl labCommon;
        private DevExpress.XtraEditors.DateEdit dateRecordDateEnd;
        private DevExpress.XtraEditors.DateEdit dateRecordDateBegin;
        private DevExpress.XtraEditors.LabelControl lab1;
        private DevExpress.XtraEditors.LabelControl labelRecordDate;
        private DevExpress.XtraEditors.PanelControl pnlLeftGrid;
        private DevExpress.XtraGrid.GridControl gridControlQuotation;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewQuotation;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId1;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoQuotationNo1;
        private DevExpress.XtraGrid.Columns.GridColumn colBussinessBaseNo1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repSearchLookUpBussinessBaseNo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn colRecordDate;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectName;
        private DevExpress.XtraGrid.Columns.GridColumn colRFQNO;
        private DevExpress.XtraGrid.Columns.GridColumn colRequester;
        private DevExpress.XtraGrid.Columns.GridColumn colParentAutoQuotationNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPrepared1;
        private DevExpress.XtraGrid.Columns.GridColumn colPreparedIp;
        private DevExpress.XtraGrid.Columns.GridColumn colModifier1;
        private DevExpress.XtraGrid.Columns.GridColumn colModifierIp;
        private DevExpress.XtraGrid.Columns.GridColumn colModifierTime1;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark1;
        private DevExpress.XtraGrid.Columns.GridColumn colParentAutoSalesOrderNo1;
        private DevExpress.XtraGrid.Columns.GridColumn colParentProjectNo1;
    }
}