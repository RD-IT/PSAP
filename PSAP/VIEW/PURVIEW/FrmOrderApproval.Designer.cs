namespace PSAP.VIEW.BSVIEW
{
    partial class FrmOrderApproval
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
            this.labApprovalCat = new DevExpress.XtraEditors.LabelControl();
            this.lookUpApprovalType = new DevExpress.XtraEditors.LookUpEdit();
            this.bsOrderHead = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Order = new System.Data.DataSet();
            this.TableOrderHead = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
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
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColApproverIp = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
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
            this.dataColApprovalCat = new System.Data.DataColumn();
            this.TableOrderApprovalInfo = new System.Data.DataTable();
            this.dataColAutoId = new System.Data.DataColumn();
            this.dataColTypeNo = new System.Data.DataColumn();
            this.dataColTypeNoText = new System.Data.DataColumn();
            this.dataColAppSequence = new System.Data.DataColumn();
            this.dataColApprover = new System.Data.DataColumn();
            this.dataColEmpName = new System.Data.DataColumn();
            this.dataColLoginId = new System.Data.DataColumn();
            this.dataColOrderHeadNo = new System.Data.DataColumn();
            this.dataColApproverTime = new System.Data.DataColumn();
            this.textApprovalCat = new DevExpress.XtraEditors.TextEdit();
            this.labApprovalType = new DevExpress.XtraEditors.LabelControl();
            this.textReqState = new DevExpress.XtraEditors.TextEdit();
            this.labReqState = new DevExpress.XtraEditors.LabelControl();
            this.textOrderHeadNo = new DevExpress.XtraEditors.TextEdit();
            this.labOrderHeadNo = new DevExpress.XtraEditors.LabelControl();
            this.pnlMiddle = new DevExpress.XtraEditors.PanelControl();
            this.gridCrlOrderAppInfo = new DevExpress.XtraGrid.GridControl();
            this.bsOrderApprovalInfo = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewOrderAppInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypeNoText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAppSequence = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApprover = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoginId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderHeadNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApproverTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlBottom = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnApproval = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpApprovalType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrderHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableOrderHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableOrderApprovalInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textApprovalCat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textReqState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textOrderHeadNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddle)).BeginInit();
            this.pnlMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlOrderAppInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrderApprovalInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrderAppInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lookUpApprovalType);
            this.pnlTop.Controls.Add(this.textApprovalCat);
            this.pnlTop.Controls.Add(this.textReqState);
            this.pnlTop.Controls.Add(this.textOrderHeadNo);
            this.pnlTop.Controls.Add(this.labApprovalCat);
            this.pnlTop.Controls.Add(this.labApprovalType);
            this.pnlTop.Controls.Add(this.labReqState);
            this.pnlTop.Controls.Add(this.labOrderHeadNo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(584, 89);
            this.pnlTop.TabIndex = 4;
            // 
            // labApprovalCat
            // 
            this.labApprovalCat.Location = new System.Drawing.Point(239, 56);
            this.labApprovalCat.Name = "labApprovalCat";
            this.labApprovalCat.Size = new System.Drawing.Size(48, 14);
            this.labApprovalCat.TabIndex = 7;
            this.labApprovalCat.Text = "审批方式";
            // 
            // lookUpApprovalType
            // 
            this.lookUpApprovalType.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsOrderHead, "ApprovalType", true));
            this.lookUpApprovalType.EnterMoveNextControl = true;
            this.lookUpApprovalType.Location = new System.Drawing.Point(95, 53);
            this.lookUpApprovalType.Name = "lookUpApprovalType";
            this.lookUpApprovalType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpApprovalType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AutoId", "AutoId", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TypeNo", "TypeNo"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TypeNoText", "TypeNoText")});
            this.lookUpApprovalType.Properties.DisplayMember = "TypeNoText";
            this.lookUpApprovalType.Properties.NullText = "";
            this.lookUpApprovalType.Properties.ReadOnly = true;
            this.lookUpApprovalType.Properties.ValueMember = "TypeNo";
            this.lookUpApprovalType.Size = new System.Drawing.Size(120, 20);
            this.lookUpApprovalType.TabIndex = 2;
            // 
            // bsOrderHead
            // 
            this.bsOrderHead.DataMember = "OrderHead";
            this.bsOrderHead.DataSource = this.dataSet_Order;
            // 
            // dataSet_Order
            // 
            this.dataSet_Order.DataSetName = "NewDataSet";
            this.dataSet_Order.Tables.AddRange(new System.Data.DataTable[] {
            this.TableOrderHead,
            this.TableOrderApprovalInfo});
            // 
            // TableOrderHead
            // 
            this.TableOrderHead.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
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
            this.dataColumn3,
            this.dataColApproverIp,
            this.dataColumn4,
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
            this.dataColApprovalCat});
            this.TableOrderHead.TableName = "OrderHead";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "AutoId";
            this.dataColumn1.DataType = typeof(int);
            // 
            // dataColumn2
            // 
            this.dataColumn2.Caption = "采购单号";
            this.dataColumn2.ColumnName = "OrderHeadNo";
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
            // dataColumn3
            // 
            this.dataColumn3.Caption = "审批人";
            this.dataColumn3.ColumnName = "Approver";
            // 
            // dataColApproverIp
            // 
            this.dataColApproverIp.Caption = "审批人IP";
            this.dataColApproverIp.ColumnName = "ApproverIp";
            // 
            // dataColumn4
            // 
            this.dataColumn4.Caption = "审批时间";
            this.dataColumn4.ColumnName = "ApproverTime";
            this.dataColumn4.DataType = typeof(System.DateTime);
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
            // dataColApprovalCat
            // 
            this.dataColApprovalCat.Caption = "审批方式";
            this.dataColApprovalCat.ColumnName = "ApprovalCat";
            this.dataColApprovalCat.DataType = typeof(int);
            // 
            // TableOrderApprovalInfo
            // 
            this.TableOrderApprovalInfo.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColAutoId,
            this.dataColTypeNo,
            this.dataColTypeNoText,
            this.dataColAppSequence,
            this.dataColApprover,
            this.dataColEmpName,
            this.dataColLoginId,
            this.dataColOrderHeadNo,
            this.dataColApproverTime});
            this.TableOrderApprovalInfo.TableName = "OrderApprovalInfo";
            // 
            // dataColAutoId
            // 
            this.dataColAutoId.ColumnName = "AutoId";
            this.dataColAutoId.DataType = typeof(int);
            // 
            // dataColTypeNo
            // 
            this.dataColTypeNo.Caption = "类型编码";
            this.dataColTypeNo.ColumnName = "TypeNo";
            // 
            // dataColTypeNoText
            // 
            this.dataColTypeNoText.Caption = "审批名称";
            this.dataColTypeNoText.ColumnName = "TypeNoText";
            // 
            // dataColAppSequence
            // 
            this.dataColAppSequence.Caption = "审批顺序";
            this.dataColAppSequence.ColumnName = "AppSequence";
            this.dataColAppSequence.DataType = typeof(int);
            // 
            // dataColApprover
            // 
            this.dataColApprover.Caption = "审批用户AutoId";
            this.dataColApprover.ColumnName = "Approver";
            this.dataColApprover.DataType = typeof(int);
            // 
            // dataColEmpName
            // 
            this.dataColEmpName.Caption = "员工名字";
            this.dataColEmpName.ColumnName = "EmpName";
            // 
            // dataColLoginId
            // 
            this.dataColLoginId.Caption = "用户名";
            this.dataColLoginId.ColumnName = "LoginId";
            // 
            // dataColOrderHeadNo
            // 
            this.dataColOrderHeadNo.Caption = "订购单号";
            this.dataColOrderHeadNo.ColumnName = "OrderHeadNo";
            // 
            // dataColApproverTime
            // 
            this.dataColApproverTime.Caption = "审批时间";
            this.dataColApproverTime.ColumnName = "ApproverTime";
            this.dataColApproverTime.DataType = typeof(System.DateTime);
            // 
            // textApprovalCat
            // 
            this.textApprovalCat.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsOrderHead, "ApprovalCat", true));
            this.textApprovalCat.Location = new System.Drawing.Point(312, 53);
            this.textApprovalCat.Name = "textApprovalCat";
            this.textApprovalCat.Properties.AllowFocused = false;
            this.textApprovalCat.Properties.ReadOnly = true;
            this.textApprovalCat.Size = new System.Drawing.Size(120, 20);
            this.textApprovalCat.TabIndex = 3;
            this.textApprovalCat.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.textApprovalCat_CustomDisplayText);
            // 
            // labApprovalType
            // 
            this.labApprovalType.Location = new System.Drawing.Point(28, 56);
            this.labApprovalType.Name = "labApprovalType";
            this.labApprovalType.Size = new System.Drawing.Size(48, 14);
            this.labApprovalType.TabIndex = 4;
            this.labApprovalType.Text = "审批类型";
            // 
            // textReqState
            // 
            this.textReqState.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsOrderHead, "ReqState", true));
            this.textReqState.Location = new System.Drawing.Point(312, 23);
            this.textReqState.Name = "textReqState";
            this.textReqState.Properties.AllowFocused = false;
            this.textReqState.Properties.ReadOnly = true;
            this.textReqState.Size = new System.Drawing.Size(120, 20);
            this.textReqState.TabIndex = 1;
            this.textReqState.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.textReqState_CustomDisplayText);
            // 
            // labReqState
            // 
            this.labReqState.Location = new System.Drawing.Point(239, 26);
            this.labReqState.Name = "labReqState";
            this.labReqState.Size = new System.Drawing.Size(48, 14);
            this.labReqState.TabIndex = 2;
            this.labReqState.Text = "单据状态";
            // 
            // textOrderHeadNo
            // 
            this.textOrderHeadNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsOrderHead, "OrderHeadNo", true));
            this.textOrderHeadNo.Location = new System.Drawing.Point(95, 23);
            this.textOrderHeadNo.Name = "textOrderHeadNo";
            this.textOrderHeadNo.Properties.ReadOnly = true;
            this.textOrderHeadNo.Size = new System.Drawing.Size(120, 20);
            this.textOrderHeadNo.TabIndex = 0;
            // 
            // labOrderHeadNo
            // 
            this.labOrderHeadNo.Location = new System.Drawing.Point(28, 26);
            this.labOrderHeadNo.Name = "labOrderHeadNo";
            this.labOrderHeadNo.Size = new System.Drawing.Size(48, 14);
            this.labOrderHeadNo.TabIndex = 0;
            this.labOrderHeadNo.Text = "采购单号";
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.Controls.Add(this.gridCrlOrderAppInfo);
            this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMiddle.Location = new System.Drawing.Point(0, 89);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(584, 232);
            this.pnlMiddle.TabIndex = 5;
            // 
            // gridCrlOrderAppInfo
            // 
            this.gridCrlOrderAppInfo.DataSource = this.bsOrderApprovalInfo;
            this.gridCrlOrderAppInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCrlOrderAppInfo.Location = new System.Drawing.Point(2, 2);
            this.gridCrlOrderAppInfo.MainView = this.gridViewOrderAppInfo;
            this.gridCrlOrderAppInfo.Name = "gridCrlOrderAppInfo";
            this.gridCrlOrderAppInfo.Size = new System.Drawing.Size(580, 228);
            this.gridCrlOrderAppInfo.TabIndex = 9;
            this.gridCrlOrderAppInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOrderAppInfo});
            // 
            // bsOrderApprovalInfo
            // 
            this.bsOrderApprovalInfo.DataMember = "OrderApprovalInfo";
            this.bsOrderApprovalInfo.DataSource = this.dataSet_Order;
            // 
            // gridViewOrderAppInfo
            // 
            this.gridViewOrderAppInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId,
            this.colTypeNo,
            this.colTypeNoText,
            this.colAppSequence,
            this.colApprover,
            this.colEmpName,
            this.colLoginId,
            this.colOrderHeadNo,
            this.colApproverTime});
            this.gridViewOrderAppInfo.GridControl = this.gridCrlOrderAppInfo;
            this.gridViewOrderAppInfo.IndicatorWidth = 40;
            this.gridViewOrderAppInfo.Name = "gridViewOrderAppInfo";
            this.gridViewOrderAppInfo.OptionsBehavior.Editable = false;
            this.gridViewOrderAppInfo.OptionsFilter.AllowFilterEditor = false;
            this.gridViewOrderAppInfo.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewOrderAppInfo.OptionsView.ColumnAutoWidth = false;
            this.gridViewOrderAppInfo.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewOrderAppInfo.OptionsView.ShowGroupPanel = false;
            this.gridViewOrderAppInfo.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewOrderAppInfo_CustomDrawRowIndicator);
            // 
            // colAutoId
            // 
            this.colAutoId.AppearanceHeader.Options.UseTextOptions = true;
            this.colAutoId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAutoId.FieldName = "AutoId";
            this.colAutoId.Name = "colAutoId";
            // 
            // colTypeNo
            // 
            this.colTypeNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colTypeNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTypeNo.FieldName = "TypeNo";
            this.colTypeNo.Name = "colTypeNo";
            this.colTypeNo.Visible = true;
            this.colTypeNo.VisibleIndex = 1;
            this.colTypeNo.Width = 80;
            // 
            // colTypeNoText
            // 
            this.colTypeNoText.AppearanceHeader.Options.UseTextOptions = true;
            this.colTypeNoText.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTypeNoText.FieldName = "TypeNoText";
            this.colTypeNoText.Name = "colTypeNoText";
            this.colTypeNoText.Visible = true;
            this.colTypeNoText.VisibleIndex = 2;
            this.colTypeNoText.Width = 100;
            // 
            // colAppSequence
            // 
            this.colAppSequence.AppearanceHeader.Options.UseTextOptions = true;
            this.colAppSequence.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAppSequence.FieldName = "AppSequence";
            this.colAppSequence.Name = "colAppSequence";
            this.colAppSequence.Visible = true;
            this.colAppSequence.VisibleIndex = 0;
            this.colAppSequence.Width = 60;
            // 
            // colApprover
            // 
            this.colApprover.AppearanceHeader.Options.UseTextOptions = true;
            this.colApprover.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colApprover.FieldName = "Approver";
            this.colApprover.Name = "colApprover";
            // 
            // colEmpName
            // 
            this.colEmpName.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmpName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmpName.FieldName = "EmpName";
            this.colEmpName.Name = "colEmpName";
            this.colEmpName.Visible = true;
            this.colEmpName.VisibleIndex = 3;
            this.colEmpName.Width = 80;
            // 
            // colLoginId
            // 
            this.colLoginId.AppearanceHeader.Options.UseTextOptions = true;
            this.colLoginId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLoginId.FieldName = "LoginId";
            this.colLoginId.Name = "colLoginId";
            this.colLoginId.Visible = true;
            this.colLoginId.VisibleIndex = 4;
            this.colLoginId.Width = 80;
            // 
            // colOrderHeadNo
            // 
            this.colOrderHeadNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colOrderHeadNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOrderHeadNo.FieldName = "OrderHeadNo";
            this.colOrderHeadNo.Name = "colOrderHeadNo";
            // 
            // colApproverTime
            // 
            this.colApproverTime.AppearanceHeader.Options.UseTextOptions = true;
            this.colApproverTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colApproverTime.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.colApproverTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colApproverTime.FieldName = "ApproverTime";
            this.colApproverTime.Name = "colApproverTime";
            this.colApproverTime.Visible = true;
            this.colApproverTime.VisibleIndex = 5;
            this.colApproverTime.Width = 135;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnCancel);
            this.pnlBottom.Controls.Add(this.btnApproval);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 321);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(584, 40);
            this.pnlBottom.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(497, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApproval
            // 
            this.btnApproval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApproval.Location = new System.Drawing.Point(416, 8);
            this.btnApproval.Name = "btnApproval";
            this.btnApproval.Size = new System.Drawing.Size(75, 23);
            this.btnApproval.TabIndex = 1;
            this.btnApproval.TabStop = false;
            this.btnApproval.Text = "审批";
            this.btnApproval.Click += new System.EventHandler(this.btnApproval_Click);
            // 
            // FrmOrderApproval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.pnlMiddle);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlBottom);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOrderApproval";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabText = "审批信息";
            this.Text = "审批信息";
            this.Load += new System.EventHandler(this.FrmApprovalOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpApprovalType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrderHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableOrderHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableOrderApprovalInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textApprovalCat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textReqState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textOrderHeadNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddle)).EndInit();
            this.pnlMiddle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlOrderAppInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrderApprovalInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrderAppInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlTop;
        private DevExpress.XtraEditors.PanelControl pnlMiddle;
        private DevExpress.XtraEditors.PanelControl pnlBottom;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnApproval;
        private System.Data.DataTable TableOrderApprovalInfo;
        private System.Data.DataColumn dataColAutoId;
        private System.Data.DataColumn dataColTypeNo;
        private System.Data.DataColumn dataColTypeNoText;
        private System.Data.DataColumn dataColAppSequence;
        private System.Data.DataColumn dataColApprover;
        private System.Data.DataColumn dataColEmpName;
        private System.Data.DataColumn dataColLoginId;
        private System.Data.DataColumn dataColOrderHeadNo;
        private System.Data.DataColumn dataColApproverTime;
        private System.Windows.Forms.BindingSource bsOrderApprovalInfo;
        private DevExpress.XtraGrid.GridControl gridCrlOrderAppInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewOrderAppInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeNoText;
        private DevExpress.XtraGrid.Columns.GridColumn colAppSequence;
        private DevExpress.XtraGrid.Columns.GridColumn colApprover;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpName;
        private DevExpress.XtraGrid.Columns.GridColumn colLoginId;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderHeadNo;
        private DevExpress.XtraGrid.Columns.GridColumn colApproverTime;
        private DevExpress.XtraEditors.TextEdit textApprovalCat;
        private DevExpress.XtraEditors.LabelControl labApprovalType;
        private DevExpress.XtraEditors.TextEdit textReqState;
        private DevExpress.XtraEditors.LabelControl labReqState;
        private DevExpress.XtraEditors.TextEdit textOrderHeadNo;
        private DevExpress.XtraEditors.LabelControl labOrderHeadNo;
        private System.Data.DataSet dataSet_Order;
        private System.Data.DataTable TableOrderHead;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
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
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColApproverIp;
        private System.Data.DataColumn dataColumn4;
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
        private System.Windows.Forms.BindingSource bsOrderHead;
        private DevExpress.XtraEditors.LabelControl labApprovalCat;
        private DevExpress.XtraEditors.LookUpEdit lookUpApprovalType;
        private System.Data.DataColumn dataColApprovalCat;
    }
}