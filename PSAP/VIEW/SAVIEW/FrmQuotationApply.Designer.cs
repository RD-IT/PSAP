namespace PSAP.VIEW.BSVIEW
{
    partial class FrmQuotationApply
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
            this.lookUpPrepared = new DevExpress.XtraEditors.LookUpEdit();
            this.labPrepared = new DevExpress.XtraEditors.LabelControl();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.textCommon = new DevExpress.XtraEditors.TextEdit();
            this.searchLookUpBussinessBaseNo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpBussinessBaseNoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnBussinessBaseNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBussinessBaseText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBussinessCategoryText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateRecordDateEnd = new DevExpress.XtraEditors.DateEdit();
            this.dateRecordDateBegin = new DevExpress.XtraEditors.DateEdit();
            this.labCommon = new DevExpress.XtraEditors.LabelControl();
            this.labBussinessBaseNo = new DevExpress.XtraEditors.LabelControl();
            this.lab1 = new DevExpress.XtraEditors.LabelControl();
            this.labRecordDate = new DevExpress.XtraEditors.LabelControl();
            this.pnlBottom = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.BtnConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.bindingSource_BaseInfo = new System.Windows.Forms.BindingSource(this.components);
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
            this.pnlGrid = new DevExpress.XtraEditors.PanelControl();
            this.gridControlQuotationPriceInfo = new DevExpress.XtraGrid.GridControl();
            this.bindingSource_PriceInfo = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewQuotationPriceInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repbtnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colQuotationState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlQuotationBaseInfo = new DevExpress.XtraGrid.GridControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.pnltop)).BeginInit();
            this.pnltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPrepared.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCommon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpBussinessBaseNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpBussinessBaseNoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRecordDateEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRecordDateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRecordDateBegin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRecordDateBegin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).BeginInit();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_BaseInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Quotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableQuotationBaseInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableQuotationPriceInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlQuotationPriceInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_PriceInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewQuotationPriceInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpCurrencyCate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinEditTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateQuotationDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateQuotationDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repbtnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlQuotationBaseInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewQuotationBaseInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchBussinessBaseNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // pnltop
            // 
            this.pnltop.Controls.Add(this.lookUpPrepared);
            this.pnltop.Controls.Add(this.labPrepared);
            this.pnltop.Controls.Add(this.btnQuery);
            this.pnltop.Controls.Add(this.textCommon);
            this.pnltop.Controls.Add(this.searchLookUpBussinessBaseNo);
            this.pnltop.Controls.Add(this.dateRecordDateEnd);
            this.pnltop.Controls.Add(this.dateRecordDateBegin);
            this.pnltop.Controls.Add(this.labCommon);
            this.pnltop.Controls.Add(this.labBussinessBaseNo);
            this.pnltop.Controls.Add(this.lab1);
            this.pnltop.Controls.Add(this.labRecordDate);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(1008, 78);
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
            this.lookUpPrepared.TabIndex = 3;
            // 
            // labPrepared
            // 
            this.labPrepared.Location = new System.Drawing.Point(20, 47);
            this.labPrepared.Margin = new System.Windows.Forms.Padding(4);
            this.labPrepared.Name = "labPrepared";
            this.labPrepared.Size = new System.Drawing.Size(48, 14);
            this.labPrepared.TabIndex = 24;
            this.labPrepared.Text = "制单人：";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(483, 43);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 5;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // textCommon
            // 
            this.textCommon.EnterMoveNextControl = true;
            this.textCommon.Location = new System.Drawing.Point(293, 44);
            this.textCommon.Name = "textCommon";
            this.textCommon.Size = new System.Drawing.Size(150, 20);
            this.textCommon.TabIndex = 4;
            // 
            // searchLookUpBussinessBaseNo
            // 
            this.searchLookUpBussinessBaseNo.EnterMoveNextControl = true;
            this.searchLookUpBussinessBaseNo.Location = new System.Drawing.Point(368, 14);
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
            this.searchLookUpBussinessBaseNoView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewQuotationBaseInfo_CustomDrawRowIndicator);
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
            this.dateRecordDateEnd.TabIndex = 1;
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
            this.dateRecordDateBegin.TabIndex = 0;
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
            this.labBussinessBaseNo.Size = new System.Drawing.Size(36, 14);
            this.labBussinessBaseNo.TabIndex = 18;
            this.labBussinessBaseNo.Text = "客户：";
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
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnCancel);
            this.pnlBottom.Controls.Add(this.BtnConfirm);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 525);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1008, 36);
            this.pnlBottom.TabIndex = 9;
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
            // bindingSource_BaseInfo
            // 
            this.bindingSource_BaseInfo.DataMember = "QuotationBaseInfo";
            this.bindingSource_BaseInfo.DataSource = this.dataSet_Quotation;
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
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.gridControlQuotationPriceInfo);
            this.pnlGrid.Controls.Add(this.gridControlQuotationBaseInfo);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 78);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1008, 447);
            this.pnlGrid.TabIndex = 10;
            // 
            // gridControlQuotationPriceInfo
            // 
            this.gridControlQuotationPriceInfo.DataSource = this.bindingSource_PriceInfo;
            this.gridControlQuotationPriceInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlQuotationPriceInfo.Location = new System.Drawing.Point(2, 202);
            this.gridControlQuotationPriceInfo.MainView = this.gridViewQuotationPriceInfo;
            this.gridControlQuotationPriceInfo.Name = "gridControlQuotationPriceInfo";
            this.gridControlQuotationPriceInfo.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repSpinQty,
            this.repbtnDelete,
            this.repLookUpCurrencyCate,
            this.repDateQuotationDate,
            this.repSpinEditTax});
            this.gridControlQuotationPriceInfo.Size = new System.Drawing.Size(1004, 243);
            this.gridControlQuotationPriceInfo.TabIndex = 7;
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
            this.gridColumn1,
            this.colCurrencyCate,
            this.colAmount,
            this.colTax,
            this.colTaxAmount,
            this.colSumAmount,
            this.colOfferer,
            this.colQuotationDate,
            this.colVersions,
            this.gridColumn2,
            this.colDelete,
            this.colQuotationState});
            this.gridViewQuotationPriceInfo.GridControl = this.gridControlQuotationPriceInfo;
            this.gridViewQuotationPriceInfo.IndicatorWidth = 40;
            this.gridViewQuotationPriceInfo.Name = "gridViewQuotationPriceInfo";
            this.gridViewQuotationPriceInfo.OptionsBehavior.Editable = false;
            this.gridViewQuotationPriceInfo.OptionsBehavior.ReadOnly = true;
            this.gridViewQuotationPriceInfo.OptionsMenu.EnableColumnMenu = false;
            this.gridViewQuotationPriceInfo.OptionsMenu.EnableFooterMenu = false;
            this.gridViewQuotationPriceInfo.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewQuotationPriceInfo.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewQuotationPriceInfo.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewQuotationPriceInfo.OptionsView.ColumnAutoWidth = false;
            this.gridViewQuotationPriceInfo.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewQuotationPriceInfo.OptionsView.ShowFooter = true;
            this.gridViewQuotationPriceInfo.OptionsView.ShowGroupPanel = false;
            this.gridViewQuotationPriceInfo.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewQuotationBaseInfo_RowClick);
            this.gridViewQuotationPriceInfo.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewQuotationBaseInfo_CustomDrawRowIndicator);
            this.gridViewQuotationPriceInfo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewQuotationBaseInfo_KeyDown);
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "AutoId";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.FieldName = "AutoQuotationNo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 100;
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
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.FieldName = "Remark";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 6;
            this.gridColumn2.Width = 180;
            // 
            // colDelete
            // 
            this.colDelete.ColumnEdit = this.repbtnDelete;
            this.colDelete.Name = "colDelete";
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
            // 
            // colQuotationState
            // 
            this.colQuotationState.FieldName = "QuotationState";
            this.colQuotationState.Name = "colQuotationState";
            // 
            // gridControlQuotationBaseInfo
            // 
            this.gridControlQuotationBaseInfo.DataSource = this.bindingSource_BaseInfo;
            this.gridControlQuotationBaseInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlQuotationBaseInfo.Location = new System.Drawing.Point(2, 2);
            this.gridControlQuotationBaseInfo.MainView = this.gridViewQuotationBaseInfo;
            this.gridControlQuotationBaseInfo.Name = "gridControlQuotationBaseInfo";
            this.gridControlQuotationBaseInfo.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repSearchBussinessBaseNo,
            this.repCheckSelect});
            this.gridControlQuotationBaseInfo.Size = new System.Drawing.Size(1004, 200);
            this.gridControlQuotationBaseInfo.TabIndex = 6;
            this.gridControlQuotationBaseInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewQuotationBaseInfo});
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
            this.gridViewQuotationBaseInfo.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewQuotationBaseInfo_CustomDrawRowIndicator);
            this.gridViewQuotationBaseInfo.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewQuotationBaseInfo_FocusedRowChanged);
            this.gridViewQuotationBaseInfo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewQuotationBaseInfo_KeyDown);
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
            // FrmQuotationApply
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnltop);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmQuotationApply";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabText = "报价单适用";
            this.Text = "报价单适用";
            this.Load += new System.EventHandler(this.FrmQuotationApply_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnltop)).EndInit();
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPrepared.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCommon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpBussinessBaseNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpBussinessBaseNoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRecordDateEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRecordDateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRecordDateBegin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRecordDateBegin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_BaseInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Quotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableQuotationBaseInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableQuotationPriceInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlQuotationPriceInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_PriceInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewQuotationPriceInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpCurrencyCate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinEditTax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateQuotationDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateQuotationDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repbtnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlQuotationBaseInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewQuotationBaseInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchBussinessBaseNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckSelect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnltop;
        private DevExpress.XtraEditors.LookUpEdit lookUpPrepared;
        private DevExpress.XtraEditors.LabelControl labPrepared;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.TextEdit textCommon;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpBussinessBaseNo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpBussinessBaseNoView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBussinessBaseNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBussinessBaseText;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBussinessCategoryText;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnAutoId;
        private DevExpress.XtraEditors.DateEdit dateRecordDateEnd;
        private DevExpress.XtraEditors.DateEdit dateRecordDateBegin;
        private DevExpress.XtraEditors.LabelControl labCommon;
        private DevExpress.XtraEditors.LabelControl labBussinessBaseNo;
        private DevExpress.XtraEditors.LabelControl lab1;
        private DevExpress.XtraEditors.LabelControl labRecordDate;
        private DevExpress.XtraEditors.PanelControl pnlBottom;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton BtnConfirm;
        private System.Windows.Forms.BindingSource bindingSource_BaseInfo;
        private DevExpress.XtraEditors.PanelControl pnlGrid;
        private DevExpress.XtraGrid.GridControl gridControlQuotationBaseInfo;
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
        private System.Data.DataColumn dataColParentAutoQuotationNo;
        private System.Data.DataColumn dataColParentAutoSalesOrderNo;
        private System.Data.DataColumn dataColParentProjectNo;
        private System.Data.DataColumn dataColPrepared;
        private System.Data.DataColumn dataColPreparedIp;
        private System.Data.DataColumn dataColModifier;
        private System.Data.DataColumn dataColModifierIp;
        private System.Data.DataColumn dataColModifierTime;
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
        private System.Data.DataColumn dataColuTax;
        private System.Data.DataColumn dataColuTaxAmount;
        private System.Data.DataColumn dataColuSumAmount;
        private System.Windows.Forms.BindingSource bindingSource_PriceInfo;
        private DevExpress.XtraGrid.GridControl gridControlQuotationPriceInfo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyCate;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpCurrencyCate;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repSpinQty;
        private DevExpress.XtraGrid.Columns.GridColumn colTax;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repSpinEditTax;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colSumAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colOfferer;
        private DevExpress.XtraGrid.Columns.GridColumn colQuotationDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repDateQuotationDate;
        private DevExpress.XtraGrid.Columns.GridColumn colVersions;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repbtnDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colQuotationState;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewQuotationBaseInfo;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewQuotationPriceInfo;
    }
}