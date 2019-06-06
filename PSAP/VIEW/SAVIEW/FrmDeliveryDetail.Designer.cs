namespace PSAP.VIEW.BSVIEW
{
    partial class FrmDeliveryDetail
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
            this.dataSet_DeliveryDetail = new System.Data.DataSet();
            this.TableDeliveryDetail = new System.Data.DataTable();
            this.dataColuAutoId = new System.Data.DataColumn();
            this.dataColuSMNo = new System.Data.DataColumn();
            this.dataColuDeliveryText = new System.Data.DataColumn();
            this.dataColuFunctionDesc = new System.Data.DataColumn();
            this.dataColuDeliveryQty = new System.Data.DataColumn();
            this.dataColuUnit = new System.Data.DataColumn();
            this.dataColuAmount = new System.Data.DataColumn();
            this.dataColuPrepared = new System.Data.DataColumn();
            this.dataColuPreparedIp = new System.Data.DataColumn();
            this.dataColuGetTime = new System.Data.DataColumn();
            this.TableMaterialDetail = new System.Data.DataTable();
            this.dcAutoId = new System.Data.DataColumn();
            this.dcDeliveryDetailNO = new System.Data.DataColumn();
            this.dcMaterialName = new System.Data.DataColumn();
            this.dcMaterialBrand = new System.Data.DataColumn();
            this.dcMaterialDesc = new System.Data.DataColumn();
            this.dcMaterialQty = new System.Data.DataColumn();
            this.dcMaterialCate = new System.Data.DataColumn();
            this.dcUnit = new System.Data.DataColumn();
            this.dcAmount = new System.Data.DataColumn();
            this.dcPrepared = new System.Data.DataColumn();
            this.dcPreparedIp = new System.Data.DataColumn();
            this.dcGetTime = new System.Data.DataColumn();
            this.bindingSource_DeliveryDetail = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource_MaterialDetail = new System.Windows.Forms.BindingSource(this.components);
            this.pnlRight = new DevExpress.XtraEditors.PanelControl();
            this.pnlBottom = new DevExpress.XtraEditors.PanelControl();
            this.btnListAdd = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlMaterialDetail = new DevExpress.XtraGrid.GridControl();
            this.gridViewMaterialDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeliveryDetailNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterialName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterialBrand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterialDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterialQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSpinQty = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colMaterialCate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSpinEditAmount = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrepared = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repbtnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repLookUpCurrencyCate = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repDateQuotationDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.pnlEdit = new DevExpress.XtraEditors.PanelControl();
            this.textDeliveryText = new DevExpress.XtraEditors.TextEdit();
            this.spinAmount = new DevExpress.XtraEditors.SpinEdit();
            this.labAmount = new DevExpress.XtraEditors.LabelControl();
            this.spinDeliveryQty = new DevExpress.XtraEditors.SpinEdit();
            this.spinUnit = new DevExpress.XtraEditors.SpinEdit();
            this.textPrepared = new DevExpress.XtraEditors.TextEdit();
            this.dateGetTime = new DevExpress.XtraEditors.DateEdit();
            this.labGetTime = new DevExpress.XtraEditors.LabelControl();
            this.labPrepared = new DevExpress.XtraEditors.LabelControl();
            this.textFunctionDesc = new DevExpress.XtraEditors.TextEdit();
            this.labFunctionDesc = new DevExpress.XtraEditors.LabelControl();
            this.labDeliveryText = new DevExpress.XtraEditors.LabelControl();
            this.labDeliveryQty = new DevExpress.XtraEditors.LabelControl();
            this.labUnit = new DevExpress.XtraEditors.LabelControl();
            this.textSMNo = new DevExpress.XtraEditors.TextEdit();
            this.labSMNo = new DevExpress.XtraEditors.LabelControl();
            this.pnlToolBar = new DevExpress.XtraEditors.PanelControl();
            this.btnDown = new DevExpress.XtraEditors.SimpleButton();
            this.btnUp = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_DeliveryDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableDeliveryDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableMaterialDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_DeliveryDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_MaterialDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).BeginInit();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).BeginInit();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMaterialDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMaterialDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinEditAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repbtnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpCurrencyCate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateQuotationDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateQuotationDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).BeginInit();
            this.pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textDeliveryText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinDeliveryQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPrepared.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGetTime.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGetTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textFunctionDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSMNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).BeginInit();
            this.pnlToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet_DeliveryDetail
            // 
            this.dataSet_DeliveryDetail.DataSetName = "NewDataSet";
            this.dataSet_DeliveryDetail.Tables.AddRange(new System.Data.DataTable[] {
            this.TableDeliveryDetail,
            this.TableMaterialDetail});
            // 
            // TableDeliveryDetail
            // 
            this.TableDeliveryDetail.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColuAutoId,
            this.dataColuSMNo,
            this.dataColuDeliveryText,
            this.dataColuFunctionDesc,
            this.dataColuDeliveryQty,
            this.dataColuUnit,
            this.dataColuAmount,
            this.dataColuPrepared,
            this.dataColuPreparedIp,
            this.dataColuGetTime});
            this.TableDeliveryDetail.TableName = "DeliveryDetail";
            this.TableDeliveryDetail.TableNewRow += new System.Data.DataTableNewRowEventHandler(this.TableDeliveryDetail_TableNewRow);
            // 
            // dataColuAutoId
            // 
            this.dataColuAutoId.ColumnName = "AutoId";
            this.dataColuAutoId.DataType = typeof(int);
            // 
            // dataColuSMNo
            // 
            this.dataColuSMNo.Caption = "模块序号";
            this.dataColuSMNo.ColumnName = "SMNo";
            // 
            // dataColuDeliveryText
            // 
            this.dataColuDeliveryText.Caption = "供货明细内容";
            this.dataColuDeliveryText.ColumnName = "DeliveryText";
            // 
            // dataColuFunctionDesc
            // 
            this.dataColuFunctionDesc.Caption = "功能详细";
            this.dataColuFunctionDesc.ColumnName = "FunctionDesc";
            // 
            // dataColuDeliveryQty
            // 
            this.dataColuDeliveryQty.Caption = "供货数量";
            this.dataColuDeliveryQty.ColumnName = "DeliveryQty";
            this.dataColuDeliveryQty.DataType = typeof(double);
            // 
            // dataColuUnit
            // 
            this.dataColuUnit.Caption = "单价";
            this.dataColuUnit.ColumnName = "Unit";
            this.dataColuUnit.DataType = typeof(double);
            // 
            // dataColuAmount
            // 
            this.dataColuAmount.Caption = "金额";
            this.dataColuAmount.ColumnName = "Amount";
            this.dataColuAmount.DataType = typeof(double);
            // 
            // dataColuPrepared
            // 
            this.dataColuPrepared.Caption = "制单人";
            this.dataColuPrepared.ColumnName = "Prepared";
            // 
            // dataColuPreparedIp
            // 
            this.dataColuPreparedIp.Caption = "制单人IP";
            this.dataColuPreparedIp.ColumnName = "PreparedIp";
            // 
            // dataColuGetTime
            // 
            this.dataColuGetTime.Caption = "登记时间";
            this.dataColuGetTime.ColumnName = "GetTime";
            this.dataColuGetTime.DataType = typeof(System.DateTime);
            // 
            // TableMaterialDetail
            // 
            this.TableMaterialDetail.Columns.AddRange(new System.Data.DataColumn[] {
            this.dcAutoId,
            this.dcDeliveryDetailNO,
            this.dcMaterialName,
            this.dcMaterialBrand,
            this.dcMaterialDesc,
            this.dcMaterialQty,
            this.dcMaterialCate,
            this.dcUnit,
            this.dcAmount,
            this.dcPrepared,
            this.dcPreparedIp,
            this.dcGetTime});
            this.TableMaterialDetail.TableName = "MaterialDetail";
            this.TableMaterialDetail.TableNewRow += new System.Data.DataTableNewRowEventHandler(this.TableMaterialDetail_TableNewRow);
            // 
            // dcAutoId
            // 
            this.dcAutoId.Caption = "AutoId";
            this.dcAutoId.ColumnName = "AutoId";
            this.dcAutoId.DataType = typeof(int);
            // 
            // dcDeliveryDetailNO
            // 
            this.dcDeliveryDetailNO.Caption = "DeliveryDetailNO";
            this.dcDeliveryDetailNO.ColumnName = "DeliveryDetailNO";
            this.dcDeliveryDetailNO.DataType = typeof(int);
            // 
            // dcMaterialName
            // 
            this.dcMaterialName.Caption = "名称";
            this.dcMaterialName.ColumnName = "MaterialName";
            // 
            // dcMaterialBrand
            // 
            this.dcMaterialBrand.Caption = "品牌";
            this.dcMaterialBrand.ColumnName = "MaterialBrand";
            // 
            // dcMaterialDesc
            // 
            this.dcMaterialDesc.Caption = "功能描述";
            this.dcMaterialDesc.ColumnName = "MaterialDesc";
            // 
            // dcMaterialQty
            // 
            this.dcMaterialQty.Caption = "数量";
            this.dcMaterialQty.ColumnName = "MaterialQty";
            this.dcMaterialQty.DataType = typeof(decimal);
            // 
            // dcMaterialCate
            // 
            this.dcMaterialCate.Caption = "类别";
            this.dcMaterialCate.ColumnName = "MaterialCate";
            // 
            // dcUnit
            // 
            this.dcUnit.Caption = "单价";
            this.dcUnit.ColumnName = "Unit";
            this.dcUnit.DataType = typeof(double);
            // 
            // dcAmount
            // 
            this.dcAmount.Caption = "金额";
            this.dcAmount.ColumnName = "Amount";
            this.dcAmount.DataType = typeof(double);
            // 
            // dcPrepared
            // 
            this.dcPrepared.Caption = "制单人";
            this.dcPrepared.ColumnName = "Prepared";
            // 
            // dcPreparedIp
            // 
            this.dcPreparedIp.Caption = "制单人IP";
            this.dcPreparedIp.ColumnName = "PreparedIp";
            // 
            // dcGetTime
            // 
            this.dcGetTime.Caption = "登记时间";
            this.dcGetTime.ColumnName = "GetTime";
            this.dcGetTime.DataType = typeof(System.DateTime);
            // 
            // bindingSource_DeliveryDetail
            // 
            this.bindingSource_DeliveryDetail.DataMember = "DeliveryDetail";
            this.bindingSource_DeliveryDetail.DataSource = this.dataSet_DeliveryDetail;
            // 
            // bindingSource_MaterialDetail
            // 
            this.bindingSource_MaterialDetail.DataMember = "MaterialDetail";
            this.bindingSource_MaterialDetail.DataSource = this.dataSet_DeliveryDetail;
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
            this.pnlRight.Size = new System.Drawing.Size(1008, 729);
            this.pnlRight.TabIndex = 0;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnListAdd);
            this.pnlBottom.Controls.Add(this.gridControlMaterialDetail);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(0, 205);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1008, 524);
            this.pnlBottom.TabIndex = 9;
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
            // gridControlMaterialDetail
            // 
            this.gridControlMaterialDetail.DataSource = this.bindingSource_MaterialDetail;
            this.gridControlMaterialDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMaterialDetail.Location = new System.Drawing.Point(2, 2);
            this.gridControlMaterialDetail.MainView = this.gridViewMaterialDetail;
            this.gridControlMaterialDetail.Name = "gridControlMaterialDetail";
            this.gridControlMaterialDetail.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repSpinQty,
            this.repbtnDelete,
            this.repLookUpCurrencyCate,
            this.repDateQuotationDate,
            this.repSpinEditAmount});
            this.gridControlMaterialDetail.Size = new System.Drawing.Size(1004, 520);
            this.gridControlMaterialDetail.TabIndex = 3;
            this.gridControlMaterialDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMaterialDetail});
            // 
            // gridViewMaterialDetail
            // 
            this.gridViewMaterialDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColAutoId,
            this.colDeliveryDetailNO,
            this.colMaterialName,
            this.colMaterialBrand,
            this.colMaterialDesc,
            this.colMaterialQty,
            this.colMaterialCate,
            this.colUnit,
            this.colAmount,
            this.colPrepared,
            this.colDelete});
            this.gridViewMaterialDetail.GridControl = this.gridControlMaterialDetail;
            this.gridViewMaterialDetail.IndicatorWidth = 40;
            this.gridViewMaterialDetail.Name = "gridViewMaterialDetail";
            this.gridViewMaterialDetail.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewMaterialDetail.OptionsBehavior.Editable = false;
            this.gridViewMaterialDetail.OptionsMenu.EnableColumnMenu = false;
            this.gridViewMaterialDetail.OptionsMenu.EnableFooterMenu = false;
            this.gridViewMaterialDetail.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewMaterialDetail.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewMaterialDetail.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewMaterialDetail.OptionsView.ColumnAutoWidth = false;
            this.gridViewMaterialDetail.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewMaterialDetail.OptionsView.ShowFooter = true;
            this.gridViewMaterialDetail.OptionsView.ShowGroupPanel = false;
            this.gridViewMaterialDetail.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewMaterialDetail_CustomDrawRowIndicator);
            this.gridViewMaterialDetail.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewMaterialDetail_CellValueChanged);
            this.gridViewMaterialDetail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewMaterialDetail_KeyDown);
            // 
            // gridColAutoId
            // 
            this.gridColAutoId.FieldName = "AutoId";
            this.gridColAutoId.Name = "gridColAutoId";
            // 
            // colDeliveryDetailNO
            // 
            this.colDeliveryDetailNO.FieldName = "DeliveryDetailNO";
            this.colDeliveryDetailNO.Name = "colDeliveryDetailNO";
            // 
            // colMaterialName
            // 
            this.colMaterialName.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaterialName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaterialName.FieldName = "MaterialName";
            this.colMaterialName.Name = "colMaterialName";
            this.colMaterialName.Visible = true;
            this.colMaterialName.VisibleIndex = 0;
            this.colMaterialName.Width = 100;
            // 
            // colMaterialBrand
            // 
            this.colMaterialBrand.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaterialBrand.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaterialBrand.FieldName = "MaterialBrand";
            this.colMaterialBrand.Name = "colMaterialBrand";
            this.colMaterialBrand.Visible = true;
            this.colMaterialBrand.VisibleIndex = 1;
            this.colMaterialBrand.Width = 100;
            // 
            // colMaterialDesc
            // 
            this.colMaterialDesc.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaterialDesc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaterialDesc.FieldName = "MaterialDesc";
            this.colMaterialDesc.Name = "colMaterialDesc";
            this.colMaterialDesc.Visible = true;
            this.colMaterialDesc.VisibleIndex = 2;
            this.colMaterialDesc.Width = 350;
            // 
            // colMaterialQty
            // 
            this.colMaterialQty.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaterialQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaterialQty.ColumnEdit = this.repSpinQty;
            this.colMaterialQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMaterialQty.FieldName = "MaterialQty";
            this.colMaterialQty.Name = "colMaterialQty";
            this.colMaterialQty.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MaterialQty", "{0:0.##}")});
            this.colMaterialQty.Visible = true;
            this.colMaterialQty.VisibleIndex = 4;
            this.colMaterialQty.Width = 80;
            // 
            // repSpinQty
            // 
            this.repSpinQty.AutoHeight = false;
            this.repSpinQty.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repSpinQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repSpinQty.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repSpinQty.MaxValue = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.repSpinQty.Name = "repSpinQty";
            // 
            // colMaterialCate
            // 
            this.colMaterialCate.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaterialCate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaterialCate.FieldName = "MaterialCate";
            this.colMaterialCate.Name = "colMaterialCate";
            this.colMaterialCate.Visible = true;
            this.colMaterialCate.VisibleIndex = 3;
            this.colMaterialCate.Width = 100;
            // 
            // colUnit
            // 
            this.colUnit.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnit.ColumnEdit = this.repSpinEditAmount;
            this.colUnit.DisplayFormat.FormatString = "N2";
            this.colUnit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.Visible = true;
            this.colUnit.VisibleIndex = 5;
            this.colUnit.Width = 100;
            // 
            // repSpinEditAmount
            // 
            this.repSpinEditAmount.AutoHeight = false;
            this.repSpinEditAmount.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repSpinEditAmount.DisplayFormat.FormatString = "N2";
            this.repSpinEditAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repSpinEditAmount.EditFormat.FormatString = "N2";
            this.repSpinEditAmount.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repSpinEditAmount.Mask.EditMask = "N2";
            this.repSpinEditAmount.MaxValue = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.repSpinEditAmount.Name = "repSpinEditAmount";
            // 
            // colAmount
            // 
            this.colAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAmount.ColumnEdit = this.repSpinEditAmount;
            this.colAmount.DisplayFormat.FormatString = "N2";
            this.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.OptionsColumn.AllowEdit = false;
            this.colAmount.OptionsColumn.TabStop = false;
            this.colAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "{0:N2}")});
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 6;
            this.colAmount.Width = 100;
            // 
            // colPrepared
            // 
            this.colPrepared.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrepared.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrepared.FieldName = "Prepared";
            this.colPrepared.Name = "colPrepared";
            this.colPrepared.Width = 60;
            // 
            // colDelete
            // 
            this.colDelete.ColumnEdit = this.repbtnDelete;
            this.colDelete.Name = "colDelete";
            this.colDelete.OptionsColumn.TabStop = false;
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
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.textDeliveryText);
            this.pnlEdit.Controls.Add(this.spinAmount);
            this.pnlEdit.Controls.Add(this.labAmount);
            this.pnlEdit.Controls.Add(this.spinDeliveryQty);
            this.pnlEdit.Controls.Add(this.spinUnit);
            this.pnlEdit.Controls.Add(this.textPrepared);
            this.pnlEdit.Controls.Add(this.dateGetTime);
            this.pnlEdit.Controls.Add(this.labGetTime);
            this.pnlEdit.Controls.Add(this.labPrepared);
            this.pnlEdit.Controls.Add(this.textFunctionDesc);
            this.pnlEdit.Controls.Add(this.labFunctionDesc);
            this.pnlEdit.Controls.Add(this.labDeliveryText);
            this.pnlEdit.Controls.Add(this.labDeliveryQty);
            this.pnlEdit.Controls.Add(this.labUnit);
            this.pnlEdit.Controls.Add(this.textSMNo);
            this.pnlEdit.Controls.Add(this.labSMNo);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEdit.Location = new System.Drawing.Point(0, 40);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(1008, 165);
            this.pnlEdit.TabIndex = 8;
            // 
            // textDeliveryText
            // 
            this.textDeliveryText.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_DeliveryDetail, "DeliveryText", true));
            this.textDeliveryText.EnterMoveNextControl = true;
            this.textDeliveryText.Location = new System.Drawing.Point(112, 55);
            this.textDeliveryText.Name = "textDeliveryText";
            this.textDeliveryText.Properties.MaxLength = 500;
            this.textDeliveryText.Size = new System.Drawing.Size(833, 20);
            this.textDeliveryText.TabIndex = 4;
            // 
            // spinAmount
            // 
            this.spinAmount.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_DeliveryDetail, "Amount", true));
            this.spinAmount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinAmount.EnterMoveNextControl = true;
            this.spinAmount.Location = new System.Drawing.Point(795, 21);
            this.spinAmount.Name = "spinAmount";
            this.spinAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinAmount.Properties.DisplayFormat.FormatString = "N2";
            this.spinAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinAmount.Properties.EditFormat.FormatString = "N2";
            this.spinAmount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinAmount.Properties.Mask.EditMask = "N2";
            this.spinAmount.Properties.MaxValue = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.spinAmount.Size = new System.Drawing.Size(150, 20);
            this.spinAmount.TabIndex = 3;
            // 
            // labAmount
            // 
            this.labAmount.Location = new System.Drawing.Point(747, 24);
            this.labAmount.Name = "labAmount";
            this.labAmount.Size = new System.Drawing.Size(24, 14);
            this.labAmount.TabIndex = 20;
            this.labAmount.Text = "金额";
            // 
            // spinDeliveryQty
            // 
            this.spinDeliveryQty.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_DeliveryDetail, "DeliveryQty", true));
            this.spinDeliveryQty.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinDeliveryQty.EnterMoveNextControl = true;
            this.spinDeliveryQty.Location = new System.Drawing.Point(354, 21);
            this.spinDeliveryQty.Name = "spinDeliveryQty";
            this.spinDeliveryQty.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinDeliveryQty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinDeliveryQty.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinDeliveryQty.Properties.MaxValue = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.spinDeliveryQty.Size = new System.Drawing.Size(150, 20);
            this.spinDeliveryQty.TabIndex = 1;
            this.spinDeliveryQty.EditValueChanged += new System.EventHandler(this.spinDeliveryQty_EditValueChanged);
            // 
            // spinUnit
            // 
            this.spinUnit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_DeliveryDetail, "Unit", true));
            this.spinUnit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinUnit.EnterMoveNextControl = true;
            this.spinUnit.Location = new System.Drawing.Point(572, 21);
            this.spinUnit.Name = "spinUnit";
            this.spinUnit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinUnit.Properties.DisplayFormat.FormatString = "N2";
            this.spinUnit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinUnit.Properties.EditFormat.FormatString = "N2";
            this.spinUnit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinUnit.Properties.Mask.EditMask = "N2";
            this.spinUnit.Properties.MaxValue = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.spinUnit.Size = new System.Drawing.Size(150, 20);
            this.spinUnit.TabIndex = 2;
            this.spinUnit.EditValueChanged += new System.EventHandler(this.spinUnit_EditValueChanged);
            // 
            // textPrepared
            // 
            this.textPrepared.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_DeliveryDetail, "Prepared", true));
            this.textPrepared.EnterMoveNextControl = true;
            this.textPrepared.Location = new System.Drawing.Point(112, 123);
            this.textPrepared.Name = "textPrepared";
            this.textPrepared.Properties.ReadOnly = true;
            this.textPrepared.Size = new System.Drawing.Size(150, 20);
            this.textPrepared.TabIndex = 6;
            this.textPrepared.TabStop = false;
            // 
            // dateGetTime
            // 
            this.dateGetTime.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_DeliveryDetail, "GetTime", true));
            this.dateGetTime.EditValue = null;
            this.dateGetTime.EnterMoveNextControl = true;
            this.dateGetTime.Location = new System.Drawing.Point(353, 123);
            this.dateGetTime.Name = "dateGetTime";
            this.dateGetTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateGetTime.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateGetTime.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dateGetTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateGetTime.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dateGetTime.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateGetTime.Properties.Mask.EditMask = "G";
            this.dateGetTime.Properties.ReadOnly = true;
            this.dateGetTime.Size = new System.Drawing.Size(150, 20);
            this.dateGetTime.TabIndex = 8;
            this.dateGetTime.TabStop = false;
            // 
            // labGetTime
            // 
            this.labGetTime.Location = new System.Drawing.Point(281, 126);
            this.labGetTime.Name = "labGetTime";
            this.labGetTime.Size = new System.Drawing.Size(48, 14);
            this.labGetTime.TabIndex = 17;
            this.labGetTime.Text = "登记时间";
            // 
            // labPrepared
            // 
            this.labPrepared.Location = new System.Drawing.Point(36, 126);
            this.labPrepared.Name = "labPrepared";
            this.labPrepared.Size = new System.Drawing.Size(36, 14);
            this.labPrepared.TabIndex = 14;
            this.labPrepared.Text = "制单人";
            // 
            // textFunctionDesc
            // 
            this.textFunctionDesc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_DeliveryDetail, "FunctionDesc", true));
            this.textFunctionDesc.EnterMoveNextControl = true;
            this.textFunctionDesc.Location = new System.Drawing.Point(112, 89);
            this.textFunctionDesc.Name = "textFunctionDesc";
            this.textFunctionDesc.Properties.MaxLength = 500;
            this.textFunctionDesc.Size = new System.Drawing.Size(833, 20);
            this.textFunctionDesc.TabIndex = 5;
            // 
            // labFunctionDesc
            // 
            this.labFunctionDesc.Location = new System.Drawing.Point(36, 92);
            this.labFunctionDesc.Name = "labFunctionDesc";
            this.labFunctionDesc.Size = new System.Drawing.Size(48, 14);
            this.labFunctionDesc.TabIndex = 10;
            this.labFunctionDesc.Text = "详细功能";
            // 
            // labDeliveryText
            // 
            this.labDeliveryText.Location = new System.Drawing.Point(36, 58);
            this.labDeliveryText.Name = "labDeliveryText";
            this.labDeliveryText.Size = new System.Drawing.Size(48, 14);
            this.labDeliveryText.TabIndex = 7;
            this.labDeliveryText.Text = "供货明细";
            // 
            // labDeliveryQty
            // 
            this.labDeliveryQty.Location = new System.Drawing.Point(281, 24);
            this.labDeliveryQty.Name = "labDeliveryQty";
            this.labDeliveryQty.Size = new System.Drawing.Size(48, 14);
            this.labDeliveryQty.TabIndex = 6;
            this.labDeliveryQty.Text = "供货数量";
            // 
            // labUnit
            // 
            this.labUnit.Location = new System.Drawing.Point(525, 24);
            this.labUnit.Name = "labUnit";
            this.labUnit.Size = new System.Drawing.Size(24, 14);
            this.labUnit.TabIndex = 2;
            this.labUnit.Text = "单价";
            // 
            // textSMNo
            // 
            this.textSMNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource_DeliveryDetail, "SMNo", true));
            this.textSMNo.EnterMoveNextControl = true;
            this.textSMNo.Location = new System.Drawing.Point(112, 21);
            this.textSMNo.Name = "textSMNo";
            this.textSMNo.Properties.ReadOnly = true;
            this.textSMNo.Size = new System.Drawing.Size(150, 20);
            this.textSMNo.TabIndex = 0;
            this.textSMNo.TabStop = false;
            // 
            // labSMNo
            // 
            this.labSMNo.Location = new System.Drawing.Point(36, 24);
            this.labSMNo.Name = "labSMNo";
            this.labSMNo.Size = new System.Drawing.Size(60, 14);
            this.labSMNo.TabIndex = 0;
            this.labSMNo.Text = "功能模块号";
            // 
            // pnlToolBar
            // 
            this.pnlToolBar.Controls.Add(this.btnDown);
            this.pnlToolBar.Controls.Add(this.btnUp);
            this.pnlToolBar.Controls.Add(this.btnRefresh);
            this.pnlToolBar.Controls.Add(this.btnDelete);
            this.pnlToolBar.Controls.Add(this.btnCancel);
            this.pnlToolBar.Controls.Add(this.btnSave);
            this.pnlToolBar.Controls.Add(this.btnNew);
            this.pnlToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolBar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolBar.Name = "pnlToolBar";
            this.pnlToolBar.Size = new System.Drawing.Size(1008, 40);
            this.pnlToolBar.TabIndex = 7;
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(496, 9);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 20;
            this.btnDown.TabStop = false;
            this.btnDown.Text = "下一条";
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(415, 9);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 23);
            this.btnUp.TabIndex = 19;
            this.btnUp.TabStop = false;
            this.btnUp.Text = "上一条";
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
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
            // FrmDeliveryDetail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.pnlRight);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "FrmDeliveryDetail";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabText = "供货明细登记";
            this.Text = "供货明细登记";
            this.Activated += new System.EventHandler(this.FrmDeliveryDetail_Activated);
            this.Load += new System.EventHandler(this.FrmDeliveryDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_DeliveryDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableDeliveryDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableMaterialDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_DeliveryDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_MaterialDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).EndInit();
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMaterialDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMaterialDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinEditAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repbtnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpCurrencyCate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateQuotationDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateQuotationDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textDeliveryText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinDeliveryQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPrepared.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGetTime.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGetTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textFunctionDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSMNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).EndInit();
            this.pnlToolBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dataSet_DeliveryDetail;
        private System.Data.DataTable TableDeliveryDetail;
        private System.Data.DataColumn dataColuAutoId;
        private System.Data.DataColumn dataColuSMNo;
        private System.Data.DataColumn dataColuDeliveryText;
        private System.Data.DataColumn dataColuFunctionDesc;
        private System.Data.DataColumn dataColuDeliveryQty;
        private System.Data.DataColumn dataColuUnit;
        private System.Data.DataColumn dataColuAmount;
        private System.Data.DataColumn dataColuPrepared;
        private System.Data.DataColumn dataColuPreparedIp;
        private System.Data.DataColumn dataColuGetTime;
        private System.Data.DataTable TableMaterialDetail;
        private System.Data.DataColumn dcAutoId;
        private System.Data.DataColumn dcDeliveryDetailNO;
        private System.Data.DataColumn dcMaterialName;
        private System.Data.DataColumn dcMaterialBrand;
        private System.Data.DataColumn dcMaterialDesc;
        private System.Data.DataColumn dcMaterialQty;
        private System.Data.DataColumn dcMaterialCate;
        private System.Data.DataColumn dcUnit;
        private System.Data.DataColumn dcAmount;
        private System.Data.DataColumn dcPrepared;
        private System.Data.DataColumn dcPreparedIp;
        private System.Data.DataColumn dcGetTime;
        private System.Windows.Forms.BindingSource bindingSource_DeliveryDetail;
        private System.Windows.Forms.BindingSource bindingSource_MaterialDetail;
        private DevExpress.XtraEditors.PanelControl pnlRight;
        private DevExpress.XtraEditors.PanelControl pnlToolBar;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.PanelControl pnlEdit;
        private DevExpress.XtraEditors.SpinEdit spinAmount;
        private DevExpress.XtraEditors.LabelControl labAmount;
        private DevExpress.XtraEditors.SpinEdit spinDeliveryQty;
        private DevExpress.XtraEditors.SpinEdit spinUnit;
        private DevExpress.XtraEditors.TextEdit textPrepared;
        private DevExpress.XtraEditors.DateEdit dateGetTime;
        private DevExpress.XtraEditors.LabelControl labGetTime;
        private DevExpress.XtraEditors.LabelControl labPrepared;
        private DevExpress.XtraEditors.TextEdit textFunctionDesc;
        private DevExpress.XtraEditors.LabelControl labFunctionDesc;
        private DevExpress.XtraEditors.LabelControl labDeliveryText;
        private DevExpress.XtraEditors.LabelControl labDeliveryQty;
        private DevExpress.XtraEditors.LabelControl labUnit;
        private DevExpress.XtraEditors.TextEdit textSMNo;
        private DevExpress.XtraEditors.LabelControl labSMNo;
        private DevExpress.XtraEditors.TextEdit textDeliveryText;
        private DevExpress.XtraEditors.PanelControl pnlBottom;
        private DevExpress.XtraEditors.SimpleButton btnListAdd;
        private DevExpress.XtraGrid.GridControl gridControlMaterialDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMaterialDetail;
        private DevExpress.XtraGrid.Columns.GridColumn gridColAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialName;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialBrand;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpCurrencyCate;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repSpinQty;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repSpinEditAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialQty;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialDesc;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repDateQuotationDate;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialCate;
        private DevExpress.XtraGrid.Columns.GridColumn colPrepared;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repbtnDelete;
        private DevExpress.XtraEditors.SimpleButton btnDown;
        private DevExpress.XtraEditors.SimpleButton btnUp;
        private DevExpress.XtraGrid.Columns.GridColumn colDeliveryDetailNO;
    }
}