namespace PSAP.VIEW.BSVIEW
{
    partial class FrmQuotationInfo
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
            this.dSQuotation = new System.Data.DataSet();
            this.TableQuotationBaseInfo = new System.Data.DataTable();
            this.dataColAutoId = new System.Data.DataColumn();
            this.dataColAutoQuotationNo = new System.Data.DataColumn();
            this.dataColRFQNO = new System.Data.DataColumn();
            this.dataColProjectName = new System.Data.DataColumn();
            this.dataColBussinessBaseNo = new System.Data.DataColumn();
            this.dataColRequester = new System.Data.DataColumn();
            this.dataColRecordDate = new System.Data.DataColumn();
            this.dataColRemark = new System.Data.DataColumn();
            this.TableQuotationPriceInfo = new System.Data.DataTable();
            this.dataColuAutoId = new System.Data.DataColumn();
            this.dataColuAutoQuotationNo = new System.Data.DataColumn();
            this.dataColuCurrencyCate = new System.Data.DataColumn();
            this.dataColuPrice = new System.Data.DataColumn();
            this.dataColuOfferer = new System.Data.DataColumn();
            this.dataColuQuotationDate = new System.Data.DataColumn();
            this.dataColuVersions = new System.Data.DataColumn();
            this.dataColuQuotationState = new System.Data.DataColumn();
            this.dataColuRemark = new System.Data.DataColumn();
            this.pnlRight = new DevExpress.XtraEditors.PanelControl();
            this.pnlBottom = new DevExpress.XtraEditors.PanelControl();
            this.btnListAdd = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlQuotationPriceInfo = new DevExpress.XtraGrid.GridControl();
            this.bSQuotationPriceInfo = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewQuotationPriceInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAutoQuotationNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrencyCate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpCurrencyCate = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSpinQty = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colOfferer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuotationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repDateQuotationDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colVersions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repbtnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colQuotationState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlEdit = new DevExpress.XtraEditors.PanelControl();
            this.labRecordDate = new DevExpress.XtraEditors.LabelControl();
            this.dateRecordDate = new DevExpress.XtraEditors.DateEdit();
            this.bSQuotationBaseInfo = new System.Windows.Forms.BindingSource(this.components);
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
            this.searchProjectName = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchProjectNameView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColProjectNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColProjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textRFQNO = new DevExpress.XtraEditors.TextEdit();
            this.labRFQNO = new DevExpress.XtraEditors.LabelControl();
            this.textAutoQuotationNo = new DevExpress.XtraEditors.TextEdit();
            this.labAutoQuotationNo = new DevExpress.XtraEditors.LabelControl();
            this.pnlToolBar = new DevExpress.XtraEditors.PanelControl();
            this.btnEditQueryAutoQuotationNo = new DevExpress.XtraEditors.ButtonEdit();
            this.labQueryAutoQuotationNo = new DevExpress.XtraEditors.LabelControl();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnPreview = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dSQuotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableQuotationBaseInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableQuotationPriceInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).BeginInit();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).BeginInit();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlQuotationPriceInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSQuotationPriceInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewQuotationPriceInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpCurrencyCate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateQuotationDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateQuotationDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repbtnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).BeginInit();
            this.pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateRecordDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRecordDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSQuotationBaseInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRequester.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBussinessBaseNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBussinessBaseNoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchProjectName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchProjectNameView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRFQNO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAutoQuotationNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).BeginInit();
            this.pnlToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditQueryAutoQuotationNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dSQuotation
            // 
            this.dSQuotation.DataSetName = "NewDataSet";
            this.dSQuotation.Tables.AddRange(new System.Data.DataTable[] {
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
            this.dataColRemark});
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
            // TableQuotationPriceInfo
            // 
            this.TableQuotationPriceInfo.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColuAutoId,
            this.dataColuAutoQuotationNo,
            this.dataColuCurrencyCate,
            this.dataColuPrice,
            this.dataColuOfferer,
            this.dataColuQuotationDate,
            this.dataColuVersions,
            this.dataColuQuotationState,
            this.dataColuRemark});
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
            // dataColuPrice
            // 
            this.dataColuPrice.Caption = "价格";
            this.dataColuPrice.ColumnName = "Price";
            this.dataColuPrice.DataType = typeof(decimal);
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
            // pnlRight
            // 
            this.pnlRight.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlRight.Controls.Add(this.pnlBottom);
            this.pnlRight.Controls.Add(this.pnlEdit);
            this.pnlRight.Controls.Add(this.pnlToolBar);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(0, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(1064, 461);
            this.pnlRight.TabIndex = 0;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnListAdd);
            this.pnlBottom.Controls.Add(this.gridControlQuotationPriceInfo);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(0, 137);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1064, 324);
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
            this.gridControlQuotationPriceInfo.DataSource = this.bSQuotationPriceInfo;
            this.gridControlQuotationPriceInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlQuotationPriceInfo.Location = new System.Drawing.Point(2, 2);
            this.gridControlQuotationPriceInfo.MainView = this.gridViewQuotationPriceInfo;
            this.gridControlQuotationPriceInfo.Name = "gridControlQuotationPriceInfo";
            this.gridControlQuotationPriceInfo.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repSpinQty,
            this.repbtnDelete,
            this.repLookUpCurrencyCate,
            this.repDateQuotationDate});
            this.gridControlQuotationPriceInfo.Size = new System.Drawing.Size(1060, 320);
            this.gridControlQuotationPriceInfo.TabIndex = 3;
            this.gridControlQuotationPriceInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewQuotationPriceInfo});
            // 
            // bSQuotationPriceInfo
            // 
            this.bSQuotationPriceInfo.DataMember = "QuotationPriceInfo";
            this.bSQuotationPriceInfo.DataSource = this.dSQuotation;
            // 
            // gridViewQuotationPriceInfo
            // 
            this.gridViewQuotationPriceInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.colAutoQuotationNo,
            this.colCurrencyCate,
            this.colPrice,
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
            // colPrice
            // 
            this.colPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrice.ColumnEdit = this.repSpinQty;
            this.colPrice.DisplayFormat.FormatString = "N2";
            this.colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Price", "{0:N2}")});
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 1;
            this.colPrice.Width = 120;
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
            // colOfferer
            // 
            this.colOfferer.AppearanceHeader.Options.UseTextOptions = true;
            this.colOfferer.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOfferer.FieldName = "Offerer";
            this.colOfferer.Name = "colOfferer";
            this.colOfferer.OptionsColumn.TabStop = false;
            this.colOfferer.Visible = true;
            this.colOfferer.VisibleIndex = 4;
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
            this.colQuotationDate.VisibleIndex = 5;
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
            this.colVersions.VisibleIndex = 2;
            this.colVersions.Width = 100;
            // 
            // colRemark
            // 
            this.colRemark.AppearanceHeader.Options.UseTextOptions = true;
            this.colRemark.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 3;
            this.colRemark.Width = 180;
            // 
            // colDelete
            // 
            this.colDelete.ColumnEdit = this.repbtnDelete;
            this.colDelete.Name = "colDelete";
            this.colDelete.OptionsColumn.TabStop = false;
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
            // colQuotationState
            // 
            this.colQuotationState.FieldName = "QuotationState";
            this.colQuotationState.Name = "colQuotationState";
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.labRecordDate);
            this.pnlEdit.Controls.Add(this.dateRecordDate);
            this.pnlEdit.Controls.Add(this.textRemark);
            this.pnlEdit.Controls.Add(this.labRemark);
            this.pnlEdit.Controls.Add(this.textRequester);
            this.pnlEdit.Controls.Add(this.labRequester);
            this.pnlEdit.Controls.Add(this.labBussinessBaseNo);
            this.pnlEdit.Controls.Add(this.labProjectName);
            this.pnlEdit.Controls.Add(this.searchBussinessBaseNo);
            this.pnlEdit.Controls.Add(this.searchProjectName);
            this.pnlEdit.Controls.Add(this.textRFQNO);
            this.pnlEdit.Controls.Add(this.labRFQNO);
            this.pnlEdit.Controls.Add(this.textAutoQuotationNo);
            this.pnlEdit.Controls.Add(this.labAutoQuotationNo);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEdit.Location = new System.Drawing.Point(0, 40);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(1064, 97);
            this.pnlEdit.TabIndex = 7;
            // 
            // labRecordDate
            // 
            this.labRecordDate.Location = new System.Drawing.Point(823, 24);
            this.labRecordDate.Name = "labRecordDate";
            this.labRecordDate.Size = new System.Drawing.Size(48, 14);
            this.labRecordDate.TabIndex = 13;
            this.labRecordDate.Text = "登记日期";
            // 
            // dateRecordDate
            // 
            this.dateRecordDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSQuotationBaseInfo, "RecordDate", true));
            this.dateRecordDate.EditValue = null;
            this.dateRecordDate.EnterMoveNextControl = true;
            this.dateRecordDate.Location = new System.Drawing.Point(892, 21);
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
            this.dateRecordDate.TabIndex = 3;
            this.dateRecordDate.TabStop = false;
            // 
            // bSQuotationBaseInfo
            // 
            this.bSQuotationBaseInfo.DataMember = "QuotationBaseInfo";
            this.bSQuotationBaseInfo.DataSource = this.dSQuotation;
            // 
            // textRemark
            // 
            this.textRemark.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSQuotationBaseInfo, "Remark", true));
            this.textRemark.EnterMoveNextControl = true;
            this.textRemark.Location = new System.Drawing.Point(630, 55);
            this.textRemark.Name = "textRemark";
            this.textRemark.Size = new System.Drawing.Size(412, 20);
            this.textRemark.TabIndex = 6;
            // 
            // labRemark
            // 
            this.labRemark.Location = new System.Drawing.Point(558, 58);
            this.labRemark.Name = "labRemark";
            this.labRemark.Size = new System.Drawing.Size(24, 14);
            this.labRemark.TabIndex = 10;
            this.labRemark.Text = "备注";
            // 
            // textRequester
            // 
            this.textRequester.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSQuotationBaseInfo, "Requester", true));
            this.textRequester.EnterMoveNextControl = true;
            this.textRequester.Location = new System.Drawing.Point(373, 55);
            this.textRequester.Name = "textRequester";
            this.textRequester.Size = new System.Drawing.Size(150, 20);
            this.textRequester.TabIndex = 5;
            // 
            // labRequester
            // 
            this.labRequester.Location = new System.Drawing.Point(300, 58);
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
            this.labProjectName.Location = new System.Drawing.Point(558, 24);
            this.labProjectName.Name = "labProjectName";
            this.labProjectName.Size = new System.Drawing.Size(48, 14);
            this.labProjectName.TabIndex = 6;
            this.labProjectName.Text = "项目名称";
            // 
            // searchBussinessBaseNo
            // 
            this.searchBussinessBaseNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSQuotationBaseInfo, "BussinessBaseNo", true));
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
            this.searchBussinessBaseNo.TabIndex = 4;
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
            // searchProjectName
            // 
            this.searchProjectName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSQuotationBaseInfo, "ProjectName", true));
            this.searchProjectName.EnterMoveNextControl = true;
            this.searchProjectName.Location = new System.Drawing.Point(630, 21);
            this.searchProjectName.Margin = new System.Windows.Forms.Padding(4);
            this.searchProjectName.Name = "searchProjectName";
            this.searchProjectName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchProjectName.Properties.DisplayMember = "ProjectName";
            this.searchProjectName.Properties.NullText = "";
            this.searchProjectName.Properties.ValueMember = "ProjectName";
            this.searchProjectName.Properties.View = this.searchProjectNameView;
            this.searchProjectName.Size = new System.Drawing.Size(150, 20);
            this.searchProjectName.TabIndex = 2;
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
            this.searchProjectNameView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewQuotationPriceInfo_CustomDrawRowIndicator);
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
            // textRFQNO
            // 
            this.textRFQNO.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSQuotationBaseInfo, "RFQNO", true));
            this.textRFQNO.EnterMoveNextControl = true;
            this.textRFQNO.Location = new System.Drawing.Point(373, 21);
            this.textRFQNO.Name = "textRFQNO";
            this.textRFQNO.Size = new System.Drawing.Size(150, 20);
            this.textRFQNO.TabIndex = 1;
            // 
            // labRFQNO
            // 
            this.labRFQNO.Location = new System.Drawing.Point(300, 24);
            this.labRFQNO.Name = "labRFQNO";
            this.labRFQNO.Size = new System.Drawing.Size(48, 14);
            this.labRFQNO.TabIndex = 2;
            this.labRFQNO.Text = "手工单号";
            // 
            // textAutoQuotationNo
            // 
            this.textAutoQuotationNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSQuotationBaseInfo, "AutoQuotationNo", true));
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
            this.pnlToolBar.Controls.Add(this.btnEditQueryAutoQuotationNo);
            this.pnlToolBar.Controls.Add(this.labQueryAutoQuotationNo);
            this.pnlToolBar.Controls.Add(this.btnRefresh);
            this.pnlToolBar.Controls.Add(this.btnDelete);
            this.pnlToolBar.Controls.Add(this.btnCancel);
            this.pnlToolBar.Controls.Add(this.btnSave);
            this.pnlToolBar.Controls.Add(this.btnNew);
            this.pnlToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolBar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolBar.Name = "pnlToolBar";
            this.pnlToolBar.Size = new System.Drawing.Size(1064, 40);
            this.pnlToolBar.TabIndex = 6;
            // 
            // btnEditQueryAutoQuotationNo
            // 
            this.btnEditQueryAutoQuotationNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditQueryAutoQuotationNo.Location = new System.Drawing.Point(864, 10);
            this.btnEditQueryAutoQuotationNo.Name = "btnEditQueryAutoQuotationNo";
            this.btnEditQueryAutoQuotationNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});
            this.btnEditQueryAutoQuotationNo.Size = new System.Drawing.Size(180, 20);
            this.btnEditQueryAutoQuotationNo.TabIndex = 21;
            this.btnEditQueryAutoQuotationNo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnEditQueryAutoQuotationNo_ButtonClick);
            this.btnEditQueryAutoQuotationNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnEditQueryAutoQuotationNo_KeyDown);
            // 
            // labQueryAutoQuotationNo
            // 
            this.labQueryAutoQuotationNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labQueryAutoQuotationNo.Location = new System.Drawing.Point(800, 13);
            this.labQueryAutoQuotationNo.Name = "labQueryAutoQuotationNo";
            this.labQueryAutoQuotationNo.Size = new System.Drawing.Size(48, 14);
            this.labQueryAutoQuotationNo.TabIndex = 20;
            this.labQueryAutoQuotationNo.Text = "报价单号";
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
            // FrmQuotationInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1064, 461);
            this.Controls.Add(this.pnlRight);
            this.Name = "FrmQuotationInfo";
            this.TabText = "报价单";
            this.Text = "报价单";
            this.Activated += new System.EventHandler(this.FrmQuotationInfo_Activated);
            this.Load += new System.EventHandler(this.FrmQuotationInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSQuotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableQuotationBaseInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableQuotationPriceInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).EndInit();
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlQuotationPriceInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSQuotationPriceInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewQuotationPriceInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpCurrencyCate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateQuotationDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateQuotationDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repbtnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateRecordDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRecordDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSQuotationBaseInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRequester.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBussinessBaseNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBussinessBaseNoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchProjectName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchProjectNameView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRFQNO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAutoQuotationNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).EndInit();
            this.pnlToolBar.ResumeLayout(false);
            this.pnlToolBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditQueryAutoQuotationNo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dSQuotation;
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
        private System.Data.DataColumn dataColuPrice;
        private System.Data.DataColumn dataColuOfferer;
        private System.Data.DataColumn dataColuQuotationDate;
        private System.Data.DataColumn dataColuVersions;
        private System.Data.DataColumn dataColuQuotationState;
        private System.Data.DataColumn dataColuRemark;
        private DevExpress.XtraEditors.PanelControl pnlRight;
        private DevExpress.XtraEditors.PanelControl pnlToolBar;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.ButtonEdit btnEditQueryAutoQuotationNo;
        private DevExpress.XtraEditors.LabelControl labQueryAutoQuotationNo;
        private DevExpress.XtraEditors.PanelControl pnlEdit;
        private DevExpress.XtraEditors.PanelControl pnlBottom;
        private System.Windows.Forms.BindingSource bSQuotationBaseInfo;
        private System.Windows.Forms.BindingSource bSQuotationPriceInfo;
        private DevExpress.XtraEditors.TextEdit textAutoQuotationNo;
        private DevExpress.XtraEditors.LabelControl labAutoQuotationNo;
        private DevExpress.XtraEditors.TextEdit textRFQNO;
        private DevExpress.XtraEditors.LabelControl labRFQNO;
        private DevExpress.XtraEditors.SearchLookUpEdit searchProjectName;
        private DevExpress.XtraGrid.Views.Grid.GridView searchProjectNameView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColProjectNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColProjectName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColRemark;
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
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
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
    }
}