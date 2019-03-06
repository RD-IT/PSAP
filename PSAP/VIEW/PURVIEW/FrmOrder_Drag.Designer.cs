namespace PSAP.VIEW.BSVIEW
{
    partial class FrmOrder_Drag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrder_Drag));
            this.pnltop = new DevExpress.XtraEditors.PanelControl();
            this.lookUpApprover = new DevExpress.XtraEditors.LookUpEdit();
            this.checkPlanDate = new DevExpress.XtraEditors.CheckEdit();
            this.datePlanDateEnd = new DevExpress.XtraEditors.DateEdit();
            this.datePlanDateBegin = new DevExpress.XtraEditors.DateEdit();
            this.searchLookUpBussinessBaseNo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpBussinessBaseNoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnBussinessBaseNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBussinessBaseText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBussinessCategoryText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textCommon = new DevExpress.XtraEditors.TextEdit();
            this.comboBoxReqState = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lookUpPrepared = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpPurCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpReqDep = new DevExpress.XtraEditors.LookUpEdit();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.dateOrderDateEnd = new DevExpress.XtraEditors.DateEdit();
            this.dateOrderDateBegin = new DevExpress.XtraEditors.DateEdit();
            this.labApprover = new DevExpress.XtraEditors.LabelControl();
            this.labPlanDate = new DevExpress.XtraEditors.LabelControl();
            this.lab2 = new DevExpress.XtraEditors.LabelControl();
            this.labBussinessBaseNo = new DevExpress.XtraEditors.LabelControl();
            this.labCommon = new DevExpress.XtraEditors.LabelControl();
            this.labPrepared = new DevExpress.XtraEditors.LabelControl();
            this.labReqState = new DevExpress.XtraEditors.LabelControl();
            this.labPurCategory = new DevExpress.XtraEditors.LabelControl();
            this.labReqDep = new DevExpress.XtraEditors.LabelControl();
            this.lab1 = new DevExpress.XtraEditors.LabelControl();
            this.labOrderDate = new DevExpress.XtraEditors.LabelControl();
            this.pnlMiddle = new DevExpress.XtraEditors.PanelControl();
            this.checkAll = new DevExpress.XtraEditors.CheckEdit();
            this.gridControlOrderHead = new DevExpress.XtraGrid.GridControl();
            this.bindingSource_OrderHead = new System.Windows.Forms.BindingSource(this.components);
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
            this.dataColPrReqNo = new System.Data.DataColumn();
            this.dataColPrListAutoId = new System.Data.DataColumn();
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
            this.repSearchBussinessBaseNoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridCBussinessBaseNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCBussinessBaseText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCBussinessCategoryText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReqDep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpReqDep = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colTax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSpinTax = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colProjectNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSearchProjectNo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repSearchProjectNoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnProjectNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnProjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStnNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repComboBoxStnNo = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colApprovalType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpApprovalType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colPayTypeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpPayTypeNo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colPlanDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrReqRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrepared = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClosed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlMiddleTop = new DevExpress.XtraEditors.PanelControl();
            this.btnPreview = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelApprove = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrReqApply = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnApprove = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.pnlBottom = new DevExpress.XtraEditors.PanelControl();
            this.btnListAdd = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlOrderList = new DevExpress.XtraGrid.GridControl();
            this.bindingSource_OrderList = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewOrderList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderHeadNo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodeFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSearchCodeFileName = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repSearchCodeFileNameView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCodeFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCodeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSpinUnit = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSpinQty = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTax1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSpinTax1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colTaxAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSumAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlanDate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repbtnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colPrReqNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrListAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dockManagerLeft = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPnlLeft = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.pnlLeftBottle = new DevExpress.XtraEditors.PanelControl();
            this.gridControlPrReqList = new DevExpress.XtraGrid.GridControl();
            this.bindingSource_PrReqList = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_PrReq = new System.Data.DataSet();
            this.dataTablePrReqHead = new System.Data.DataTable();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColReqDate = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColApplicant = new System.Data.DataColumn();
            this.dataColApplicantIp = new System.Data.DataColumn();
            this.dataColApplicantTime = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.dataColumn11 = new System.Data.DataColumn();
            this.dataColumn14 = new System.Data.DataColumn();
            this.dataTablePrReqList = new System.Data.DataTable();
            this.dataColumn19 = new System.Data.DataColumn();
            this.dataColumnPrReqNo = new System.Data.DataColumn();
            this.dataColumn20 = new System.Data.DataColumn();
            this.dataColumn21 = new System.Data.DataColumn();
            this.dataColRequirementDate = new System.Data.DataColumn();
            this.dataColPrReqListRemark = new System.Data.DataColumn();
            this.dataColumn22 = new System.Data.DataColumn();
            this.dataColOrderCount = new System.Data.DataColumn();
            this.dataColOverplus = new System.Data.DataColumn();
            this.gridViewPrReqList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrReqNo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOverplus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRequirementDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrReqListRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitterControl2 = new DevExpress.XtraEditors.SplitterControl();
            this.pnlLeftMiddle = new DevExpress.XtraEditors.PanelControl();
            this.gridControlPrReqHead = new DevExpress.XtraGrid.GridControl();
            this.bindingSource_PrReqHead = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewPrReqHead = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReqDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSearchPrReqProjectNo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpPrReqReqDep = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpPrReqPurCategory = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colApplicant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlLeftTop = new DevExpress.XtraEditors.PanelControl();
            this.searchLookUpProjectNo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpProjectNoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColProjectNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColProjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateReqDateEnd = new DevExpress.XtraEditors.DateEdit();
            this.dateReqDateBegin = new DevExpress.XtraEditors.DateEdit();
            this.textPrReqNo = new DevExpress.XtraEditors.TextEdit();
            this.btnPrReqQuery = new DevExpress.XtraEditors.SimpleButton();
            this.labProjectNo = new DevExpress.XtraEditors.LabelControl();
            this.lab = new DevExpress.XtraEditors.LabelControl();
            this.labReqDate = new DevExpress.XtraEditors.LabelControl();
            this.labPrReqNo = new DevExpress.XtraEditors.LabelControl();
            this.pnlRight = new DevExpress.XtraEditors.PanelControl();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.popupMenuList = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonUp = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonDown = new DevExpress.XtraBars.BarButtonItem();
            this.barManagerForm = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiJhdhribnwk = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDgrqbnwk = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDqcgdyjxg = new System.Windows.Forms.ToolStripMenuItem();
            this.cms3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCgjzd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWsp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBkycz = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiYjsp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiYjjz = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiYjspz = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCgjzdz = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDsl = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCgrkdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBkybc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWcxdyc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCzsjw = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCtjzsj = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCtjh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiJzribn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFkrqbn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCxansj = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDqcgjzd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiZbjjhg = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTjl = new System.Windows.Forms.ToolStripMenuItem();
            this.cms2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiZbsd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSczbz = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiZbdyg = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSbczmx = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCxmxd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiXg = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiYjspbk = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiYjjzbky = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiYjspzbk = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWspbk = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiYjgbbk = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRkrqbn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCxrk = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiJjcxrk = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiZgrid = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSxtzrk = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiYzcgjz = new System.Windows.Forms.ToolStripMenuItem();
            this.cms1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiWlfbnwk = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRkbm = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSplx = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSlbn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFkrq = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSlbnwk = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDjbnwk = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBcan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQxan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQzycz = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQdysc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTjlm = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiScansj = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQdyspd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCgspl = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSpansj = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQdyqx = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCgqxsp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQxspan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDyyl = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCglxbnwkbc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSqbmbnwkbc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiXmhbnwkbc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiZhbnwkbc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFklxbnwkbc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSrdzhbsyxmh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQdygddqxzd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQgsyansjcw = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCxmxdsyjqgdcw = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCxmxdxyjrkdcw = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCgdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQgrqbnwkcx = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCxqgdsjcw = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiJjcxqgdmxsjcw = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSxtzqgdsjcw = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiYzcgddzrxxmdxmh = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pnltop)).BeginInit();
            this.pnltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpApprover.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkPlanDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePlanDateEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePlanDateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePlanDateBegin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePlanDateBegin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpBussinessBaseNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpBussinessBaseNoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCommon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxReqState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPrepared.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPurCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpReqDep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDateEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDateBegin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDateBegin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddle)).BeginInit();
            this.pnlMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrderHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_OrderHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableOrderHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableOrderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrderHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpPurCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchBussinessBaseNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchBussinessBaseNoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpReqDep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchProjectNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchProjectNoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repComboBoxStnNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpApprovalType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpPayTypeNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddleTop)).BeginInit();
            this.pnlMiddleTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).BeginInit();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_OrderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchCodeFileName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchCodeFileNameView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinTax1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repbtnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManagerLeft)).BeginInit();
            this.dockPnlLeft.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeftBottle)).BeginInit();
            this.pnlLeftBottle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPrReqList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_PrReqList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_PrReq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablePrReqHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablePrReqList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPrReqList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeftMiddle)).BeginInit();
            this.pnlLeftMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPrReqHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_PrReqHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPrReqHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchPrReqProjectNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpPrReqReqDep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpPrReqPurCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeftTop)).BeginInit();
            this.pnlLeftTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpProjectNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpProjectNoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateReqDateEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateReqDateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateReqDateBegin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateReqDateBegin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPrReqNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).BeginInit();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerForm)).BeginInit();
            this.cms.SuspendLayout();
            this.cms3.SuspendLayout();
            this.cms2.SuspendLayout();
            this.cms1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnltop
            // 
            this.pnltop.Controls.Add(this.lookUpApprover);
            this.pnltop.Controls.Add(this.checkPlanDate);
            this.pnltop.Controls.Add(this.datePlanDateEnd);
            this.pnltop.Controls.Add(this.datePlanDateBegin);
            this.pnltop.Controls.Add(this.searchLookUpBussinessBaseNo);
            this.pnltop.Controls.Add(this.textCommon);
            this.pnltop.Controls.Add(this.comboBoxReqState);
            this.pnltop.Controls.Add(this.lookUpPrepared);
            this.pnltop.Controls.Add(this.lookUpPurCategory);
            this.pnltop.Controls.Add(this.lookUpReqDep);
            this.pnltop.Controls.Add(this.btnQuery);
            this.pnltop.Controls.Add(this.dateOrderDateEnd);
            this.pnltop.Controls.Add(this.dateOrderDateBegin);
            this.pnltop.Controls.Add(this.labApprover);
            this.pnltop.Controls.Add(this.labPlanDate);
            this.pnltop.Controls.Add(this.lab2);
            this.pnltop.Controls.Add(this.labBussinessBaseNo);
            this.pnltop.Controls.Add(this.labCommon);
            this.pnltop.Controls.Add(this.labPrepared);
            this.pnltop.Controls.Add(this.labReqState);
            this.pnltop.Controls.Add(this.labPurCategory);
            this.pnltop.Controls.Add(this.labReqDep);
            this.pnltop.Controls.Add(this.lab1);
            this.pnltop.Controls.Add(this.labOrderDate);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(2, 2);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(1016, 78);
            this.pnltop.TabIndex = 1;
            // 
            // lookUpApprover
            // 
            this.lookUpApprover.EnterMoveNextControl = true;
            this.lookUpApprover.Location = new System.Drawing.Point(594, 44);
            this.lookUpApprover.Name = "lookUpApprover";
            this.lookUpApprover.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lookUpApprover.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpApprover.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AutoId", "AutoId", 80, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LoginId", "用户名", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmpName", "员工名", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpApprover.Properties.DisplayMember = "EmpName";
            this.lookUpApprover.Properties.NullText = "";
            this.lookUpApprover.Properties.ValueMember = "AutoId";
            this.lookUpApprover.Size = new System.Drawing.Size(120, 20);
            this.lookUpApprover.TabIndex = 10;
            this.lookUpApprover.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lookUpApprover_KeyDown);
            // 
            // checkPlanDate
            // 
            this.checkPlanDate.Location = new System.Drawing.Point(101, 44);
            this.checkPlanDate.Name = "checkPlanDate";
            this.checkPlanDate.Properties.Caption = "";
            this.checkPlanDate.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.checkPlanDate.Properties.ValueGrayed = false;
            this.checkPlanDate.Size = new System.Drawing.Size(19, 19);
            this.checkPlanDate.TabIndex = 6;
            this.checkPlanDate.TabStop = false;
            this.checkPlanDate.CheckedChanged += new System.EventHandler(this.checkPlanDate_CheckedChanged);
            // 
            // datePlanDateEnd
            // 
            this.datePlanDateEnd.EditValue = null;
            this.datePlanDateEnd.Enabled = false;
            this.datePlanDateEnd.EnterMoveNextControl = true;
            this.datePlanDateEnd.Location = new System.Drawing.Point(240, 44);
            this.datePlanDateEnd.Name = "datePlanDateEnd";
            this.datePlanDateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datePlanDateEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datePlanDateEnd.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.datePlanDateEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.datePlanDateEnd.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.datePlanDateEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.datePlanDateEnd.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.datePlanDateEnd.Size = new System.Drawing.Size(100, 20);
            this.datePlanDateEnd.TabIndex = 8;
            // 
            // datePlanDateBegin
            // 
            this.datePlanDateBegin.EditValue = null;
            this.datePlanDateBegin.Enabled = false;
            this.datePlanDateBegin.EnterMoveNextControl = true;
            this.datePlanDateBegin.Location = new System.Drawing.Point(124, 44);
            this.datePlanDateBegin.Name = "datePlanDateBegin";
            this.datePlanDateBegin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datePlanDateBegin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datePlanDateBegin.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.datePlanDateBegin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.datePlanDateBegin.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.datePlanDateBegin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.datePlanDateBegin.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.datePlanDateBegin.Size = new System.Drawing.Size(100, 20);
            this.datePlanDateBegin.TabIndex = 7;
            // 
            // searchLookUpBussinessBaseNo
            // 
            this.searchLookUpBussinessBaseNo.EnterMoveNextControl = true;
            this.searchLookUpBussinessBaseNo.Location = new System.Drawing.Point(771, 14);
            this.searchLookUpBussinessBaseNo.Name = "searchLookUpBussinessBaseNo";
            this.searchLookUpBussinessBaseNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpBussinessBaseNo.Properties.DisplayMember = "BussinessBaseText";
            this.searchLookUpBussinessBaseNo.Properties.NullText = "";
            this.searchLookUpBussinessBaseNo.Properties.ValueMember = "BussinessBaseNo";
            this.searchLookUpBussinessBaseNo.Properties.View = this.searchLookUpBussinessBaseNoView;
            this.searchLookUpBussinessBaseNo.Size = new System.Drawing.Size(150, 20);
            this.searchLookUpBussinessBaseNo.TabIndex = 4;
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
            this.searchLookUpBussinessBaseNoView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.repSearchCodeFileNameView_CustomDrawRowIndicator);
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
            // textCommon
            // 
            this.textCommon.EnterMoveNextControl = true;
            this.textCommon.Location = new System.Drawing.Point(797, 44);
            this.textCommon.Name = "textCommon";
            this.textCommon.Size = new System.Drawing.Size(150, 20);
            this.textCommon.TabIndex = 11;
            // 
            // comboBoxReqState
            // 
            this.comboBoxReqState.EnterMoveNextControl = true;
            this.comboBoxReqState.Location = new System.Drawing.Point(1003, 14);
            this.comboBoxReqState.Name = "comboBoxReqState";
            this.comboBoxReqState.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxReqState.Properties.Items.AddRange(new object[] {
            "全部",
            "待审批",
            "审批",
            "关闭",
            "审批中"});
            this.comboBoxReqState.Size = new System.Drawing.Size(120, 20);
            this.comboBoxReqState.TabIndex = 5;
            // 
            // lookUpPrepared
            // 
            this.lookUpPrepared.EnterMoveNextControl = true;
            this.lookUpPrepared.Location = new System.Drawing.Point(406, 44);
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
            this.lookUpPrepared.TabIndex = 9;
            // 
            // lookUpPurCategory
            // 
            this.lookUpPurCategory.EnterMoveNextControl = true;
            this.lookUpPurCategory.Location = new System.Drawing.Point(582, 14);
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
            this.lookUpPurCategory.TabIndex = 3;
            // 
            // lookUpReqDep
            // 
            this.lookUpReqDep.EnterMoveNextControl = true;
            this.lookUpReqDep.Location = new System.Drawing.Point(381, 14);
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
            this.lookUpReqDep.TabIndex = 2;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(962, 43);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 12;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dateOrderDateEnd
            // 
            this.dateOrderDateEnd.EditValue = null;
            this.dateOrderDateEnd.EnterMoveNextControl = true;
            this.dateOrderDateEnd.Location = new System.Drawing.Point(202, 14);
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
            this.dateOrderDateEnd.TabIndex = 1;
            // 
            // dateOrderDateBegin
            // 
            this.dateOrderDateBegin.EditValue = null;
            this.dateOrderDateBegin.EnterMoveNextControl = true;
            this.dateOrderDateBegin.Location = new System.Drawing.Point(86, 14);
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
            this.dateOrderDateBegin.TabIndex = 0;
            // 
            // labApprover
            // 
            this.labApprover.Location = new System.Drawing.Point(546, 47);
            this.labApprover.Name = "labApprover";
            this.labApprover.Size = new System.Drawing.Size(48, 14);
            this.labApprover.TabIndex = 22;
            this.labApprover.Text = "审批人：";
            // 
            // labPlanDate
            // 
            this.labPlanDate.Location = new System.Drawing.Point(20, 47);
            this.labPlanDate.Name = "labPlanDate";
            this.labPlanDate.Size = new System.Drawing.Size(84, 14);
            this.labPlanDate.TabIndex = 20;
            this.labPlanDate.Text = "计划到货日期：";
            // 
            // lab2
            // 
            this.lab2.Location = new System.Drawing.Point(230, 47);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(4, 14);
            this.lab2.TabIndex = 19;
            this.lab2.Text = "-";
            // 
            // labBussinessBaseNo
            // 
            this.labBussinessBaseNo.Location = new System.Drawing.Point(717, 17);
            this.labBussinessBaseNo.Name = "labBussinessBaseNo";
            this.labBussinessBaseNo.Size = new System.Drawing.Size(48, 14);
            this.labBussinessBaseNo.TabIndex = 16;
            this.labBussinessBaseNo.Text = "往来方：";
            // 
            // labCommon
            // 
            this.labCommon.Location = new System.Drawing.Point(731, 47);
            this.labCommon.Name = "labCommon";
            this.labCommon.Size = new System.Drawing.Size(60, 14);
            this.labCommon.TabIndex = 14;
            this.labCommon.Text = "通用查询：";
            // 
            // labPrepared
            // 
            this.labPrepared.Location = new System.Drawing.Point(358, 47);
            this.labPrepared.Name = "labPrepared";
            this.labPrepared.Size = new System.Drawing.Size(48, 14);
            this.labPrepared.TabIndex = 11;
            this.labPrepared.Text = "制单人：";
            // 
            // labReqState
            // 
            this.labReqState.Location = new System.Drawing.Point(937, 17);
            this.labReqState.Name = "labReqState";
            this.labReqState.Size = new System.Drawing.Size(60, 14);
            this.labReqState.TabIndex = 9;
            this.labReqState.Text = "单据状态：";
            // 
            // labPurCategory
            // 
            this.labPurCategory.Location = new System.Drawing.Point(516, 17);
            this.labPurCategory.Name = "labPurCategory";
            this.labPurCategory.Size = new System.Drawing.Size(60, 14);
            this.labPurCategory.TabIndex = 7;
            this.labPurCategory.Text = "采购类型：";
            // 
            // labReqDep
            // 
            this.labReqDep.Location = new System.Drawing.Point(315, 17);
            this.labReqDep.Name = "labReqDep";
            this.labReqDep.Size = new System.Drawing.Size(60, 14);
            this.labReqDep.TabIndex = 5;
            this.labReqDep.Text = "申请部门：";
            // 
            // lab1
            // 
            this.lab1.Location = new System.Drawing.Point(192, 17);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(4, 14);
            this.lab1.TabIndex = 2;
            this.lab1.Text = "-";
            // 
            // labOrderDate
            // 
            this.labOrderDate.Location = new System.Drawing.Point(20, 17);
            this.labOrderDate.Name = "labOrderDate";
            this.labOrderDate.Size = new System.Drawing.Size(60, 14);
            this.labOrderDate.TabIndex = 1;
            this.labOrderDate.Text = "订购日期：";
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.Controls.Add(this.checkAll);
            this.pnlMiddle.Controls.Add(this.gridControlOrderHead);
            this.pnlMiddle.Controls.Add(this.pnlMiddleTop);
            this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMiddle.Location = new System.Drawing.Point(2, 80);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(1016, 186);
            this.pnlMiddle.TabIndex = 2;
            // 
            // checkAll
            // 
            this.checkAll.Location = new System.Drawing.Point(53, 38);
            this.checkAll.Name = "checkAll";
            this.checkAll.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.checkAll.Properties.Appearance.Options.UseBackColor = true;
            this.checkAll.Properties.Caption = "";
            this.checkAll.Size = new System.Drawing.Size(20, 19);
            this.checkAll.TabIndex = 18;
            this.checkAll.TabStop = false;
            this.checkAll.CheckedChanged += new System.EventHandler(this.checkAll_CheckedChanged);
            // 
            // gridControlOrderHead
            // 
            this.gridControlOrderHead.DataSource = this.bindingSource_OrderHead;
            this.gridControlOrderHead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlOrderHead.Location = new System.Drawing.Point(2, 36);
            this.gridControlOrderHead.MainView = this.gridViewOrderHead;
            this.gridControlOrderHead.Name = "gridControlOrderHead";
            this.gridControlOrderHead.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repLookUpReqDep,
            this.repLookUpPurCategory,
            this.repSearchProjectNo,
            this.repComboBoxStnNo,
            this.repSearchBussinessBaseNo,
            this.repCheckSelect,
            this.repSpinTax,
            this.repLookUpApprovalType,
            this.repLookUpPayTypeNo});
            this.gridControlOrderHead.Size = new System.Drawing.Size(1012, 148);
            this.gridControlOrderHead.TabIndex = 3;
            this.gridControlOrderHead.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOrderHead});
            // 
            // bindingSource_OrderHead
            // 
            this.bindingSource_OrderHead.DataMember = "OrderHead";
            this.bindingSource_OrderHead.DataSource = this.dataSet_Order;
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
            this.dataColPayTypeNo});
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
            this.dataColPrReqNo,
            this.dataColPrListAutoId});
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
            // dataColPrReqNo
            // 
            this.dataColPrReqNo.Caption = "请购单号";
            this.dataColPrReqNo.ColumnName = "PrReqNo";
            // 
            // dataColPrListAutoId
            // 
            this.dataColPrListAutoId.Caption = "请购单明细ID";
            this.dataColPrListAutoId.ColumnName = "PrListAutoId";
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
            this.colProjectNo,
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
            this.gridViewOrderHead.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewOrderHead.OptionsMenu.EnableColumnMenu = false;
            this.gridViewOrderHead.OptionsMenu.EnableFooterMenu = false;
            this.gridViewOrderHead.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewOrderHead.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewOrderHead.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewOrderHead.OptionsView.ColumnAutoWidth = false;
            this.gridViewOrderHead.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewOrderHead.OptionsView.ShowFooter = true;
            this.gridViewOrderHead.OptionsView.ShowGroupPanel = false;
            this.gridViewOrderHead.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewOrderHead_CustomDrawRowIndicator);
            this.gridViewOrderHead.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridViewOrderHead_InitNewRow);
            this.gridViewOrderHead.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewOrderHead_FocusedRowChanged);
            this.gridViewOrderHead.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewOrderHead_CellValueChanged);
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
            this.repCheckSelect.CheckedChanged += new System.EventHandler(this.repCheckSelect_EditValueChanged);
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
            this.colOrderHeadNo.VisibleIndex = 1;
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
            this.colReqState.VisibleIndex = 2;
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
            this.colOrderHeadDate.VisibleIndex = 3;
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
            this.colPurCategory.VisibleIndex = 4;
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
            this.colBussinessBaseNo.VisibleIndex = 5;
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
            this.repSearchBussinessBaseNoView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.repSearchCodeFileNameView_CustomDrawRowIndicator);
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
            this.colReqDep.VisibleIndex = 6;
            this.colReqDep.Width = 120;
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
            this.colTax.ColumnEdit = this.repSpinTax;
            this.colTax.FieldName = "Tax";
            this.colTax.Name = "colTax";
            this.colTax.OptionsColumn.AllowEdit = false;
            this.colTax.Visible = true;
            this.colTax.VisibleIndex = 7;
            this.colTax.Width = 60;
            // 
            // repSpinTax
            // 
            this.repSpinTax.AutoHeight = false;
            this.repSpinTax.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repSpinTax.DisplayFormat.FormatString = "p0";
            this.repSpinTax.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repSpinTax.EditFormat.FormatString = "p0";
            this.repSpinTax.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repSpinTax.Mask.EditMask = "p0";
            this.repSpinTax.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repSpinTax.Name = "repSpinTax";
            // 
            // colProjectNo
            // 
            this.colProjectNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colProjectNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProjectNo.ColumnEdit = this.repSearchProjectNo;
            this.colProjectNo.FieldName = "ProjectNo";
            this.colProjectNo.Name = "colProjectNo";
            this.colProjectNo.OptionsColumn.AllowEdit = false;
            this.colProjectNo.Visible = true;
            this.colProjectNo.VisibleIndex = 8;
            this.colProjectNo.Width = 100;
            // 
            // repSearchProjectNo
            // 
            this.repSearchProjectNo.AutoHeight = false;
            this.repSearchProjectNo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repSearchProjectNo.DisplayMember = "ProjectNo";
            this.repSearchProjectNo.Name = "repSearchProjectNo";
            this.repSearchProjectNo.NullText = "";
            this.repSearchProjectNo.ValueMember = "ProjectNo";
            this.repSearchProjectNo.View = this.repSearchProjectNoView;
            // 
            // repSearchProjectNoView
            // 
            this.repSearchProjectNoView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnProjectNo,
            this.gridColumnProjectName,
            this.gridColumnRemark});
            this.repSearchProjectNoView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repSearchProjectNoView.IndicatorWidth = 60;
            this.repSearchProjectNoView.Name = "repSearchProjectNoView";
            this.repSearchProjectNoView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repSearchProjectNoView.OptionsView.ShowGroupPanel = false;
            this.repSearchProjectNoView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.repSearchCodeFileNameView_CustomDrawRowIndicator);
            // 
            // gridColumnProjectNo
            // 
            this.gridColumnProjectNo.Caption = "项目号";
            this.gridColumnProjectNo.FieldName = "ProjectNo";
            this.gridColumnProjectNo.Name = "gridColumnProjectNo";
            this.gridColumnProjectNo.Visible = true;
            this.gridColumnProjectNo.VisibleIndex = 0;
            // 
            // gridColumnProjectName
            // 
            this.gridColumnProjectName.Caption = "项目名称";
            this.gridColumnProjectName.FieldName = "ProjectName";
            this.gridColumnProjectName.Name = "gridColumnProjectName";
            this.gridColumnProjectName.Visible = true;
            this.gridColumnProjectName.VisibleIndex = 1;
            // 
            // gridColumnRemark
            // 
            this.gridColumnRemark.Caption = "备注";
            this.gridColumnRemark.FieldName = "Remark";
            this.gridColumnRemark.Name = "gridColumnRemark";
            this.gridColumnRemark.Visible = true;
            this.gridColumnRemark.VisibleIndex = 2;
            // 
            // colStnNo
            // 
            this.colStnNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colStnNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStnNo.ColumnEdit = this.repComboBoxStnNo;
            this.colStnNo.FieldName = "StnNo";
            this.colStnNo.Name = "colStnNo";
            this.colStnNo.OptionsColumn.AllowEdit = false;
            this.colStnNo.Visible = true;
            this.colStnNo.VisibleIndex = 9;
            this.colStnNo.Width = 100;
            // 
            // repComboBoxStnNo
            // 
            this.repComboBoxStnNo.AutoHeight = false;
            this.repComboBoxStnNo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repComboBoxStnNo.DropDownRows = 10;
            this.repComboBoxStnNo.ImmediatePopup = true;
            this.repComboBoxStnNo.Name = "repComboBoxStnNo";
            // 
            // colApprovalType
            // 
            this.colApprovalType.AppearanceHeader.Options.UseTextOptions = true;
            this.colApprovalType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colApprovalType.ColumnEdit = this.repLookUpApprovalType;
            this.colApprovalType.FieldName = "ApprovalType";
            this.colApprovalType.Name = "colApprovalType";
            this.colApprovalType.OptionsColumn.AllowEdit = false;
            this.colApprovalType.Visible = true;
            this.colApprovalType.VisibleIndex = 10;
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
            this.colPayTypeNo.Visible = true;
            this.colPayTypeNo.VisibleIndex = 11;
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
            this.colPlanDate.Visible = true;
            this.colPlanDate.VisibleIndex = 12;
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
            this.colPrReqRemark.VisibleIndex = 13;
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
            this.colPrepared.VisibleIndex = 14;
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
            this.colClosed.Visible = true;
            this.colClosed.VisibleIndex = 15;
            // 
            // pnlMiddleTop
            // 
            this.pnlMiddleTop.Controls.Add(this.btnPreview);
            this.pnlMiddleTop.Controls.Add(this.btnCancelClose);
            this.pnlMiddleTop.Controls.Add(this.btnCancelApprove);
            this.pnlMiddleTop.Controls.Add(this.btnPrReqApply);
            this.pnlMiddleTop.Controls.Add(this.btnClose);
            this.pnlMiddleTop.Controls.Add(this.btnApprove);
            this.pnlMiddleTop.Controls.Add(this.btnDelete);
            this.pnlMiddleTop.Controls.Add(this.btnCancel);
            this.pnlMiddleTop.Controls.Add(this.btnSave);
            this.pnlMiddleTop.Controls.Add(this.btnNew);
            this.pnlMiddleTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMiddleTop.Location = new System.Drawing.Point(2, 2);
            this.pnlMiddleTop.Name = "pnlMiddleTop";
            this.pnlMiddleTop.Size = new System.Drawing.Size(1012, 34);
            this.pnlMiddleTop.TabIndex = 2;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(734, 5);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 24;
            this.btnPreview.TabStop = false;
            this.btnPreview.Text = "预览";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnCancelClose
            // 
            this.btnCancelClose.Location = new System.Drawing.Point(572, 5);
            this.btnCancelClose.Name = "btnCancelClose";
            this.btnCancelClose.Size = new System.Drawing.Size(75, 23);
            this.btnCancelClose.TabIndex = 23;
            this.btnCancelClose.TabStop = false;
            this.btnCancelClose.Text = "取消关闭";
            this.btnCancelClose.Click += new System.EventHandler(this.btnCancelClose_Click);
            // 
            // btnCancelApprove
            // 
            this.btnCancelApprove.Location = new System.Drawing.Point(410, 5);
            this.btnCancelApprove.Name = "btnCancelApprove";
            this.btnCancelApprove.Size = new System.Drawing.Size(75, 23);
            this.btnCancelApprove.TabIndex = 18;
            this.btnCancelApprove.TabStop = false;
            this.btnCancelApprove.Text = "取消审批";
            this.btnCancelApprove.Click += new System.EventHandler(this.btnCancelApprove_Click);
            // 
            // btnPrReqApply
            // 
            this.btnPrReqApply.Location = new System.Drawing.Point(653, 5);
            this.btnPrReqApply.Name = "btnPrReqApply";
            this.btnPrReqApply.Size = new System.Drawing.Size(75, 23);
            this.btnPrReqApply.TabIndex = 17;
            this.btnPrReqApply.TabStop = false;
            this.btnPrReqApply.Text = "请购适用";
            this.btnPrReqApply.Click += new System.EventHandler(this.btnPrReqApply_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(491, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 16;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(329, 5);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(75, 23);
            this.btnApprove.TabIndex = 14;
            this.btnApprove.TabStop = false;
            this.btnApprove.Text = "审批";
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(248, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(167, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(86, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "修改";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(5, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 10;
            this.btnNew.TabStop = false;
            this.btnNew.Text = "新增";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnListAdd);
            this.pnlBottom.Controls.Add(this.gridControlOrderList);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(2, 271);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1016, 328);
            this.pnlBottom.TabIndex = 3;
            // 
            // btnListAdd
            // 
            this.btnListAdd.Enabled = false;
            this.btnListAdd.Location = new System.Drawing.Point(2, 2);
            this.btnListAdd.Name = "btnListAdd";
            this.btnListAdd.Size = new System.Drawing.Size(40, 21);
            this.btnListAdd.TabIndex = 5;
            this.btnListAdd.Text = "+";
            this.btnListAdd.Click += new System.EventHandler(this.btnListAdd_Click);
            // 
            // gridControlOrderList
            // 
            this.gridControlOrderList.AllowDrop = true;
            this.gridControlOrderList.DataSource = this.bindingSource_OrderList;
            this.gridControlOrderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlOrderList.Location = new System.Drawing.Point(2, 2);
            this.gridControlOrderList.MainView = this.gridViewOrderList;
            this.gridControlOrderList.Name = "gridControlOrderList";
            this.gridControlOrderList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repSpinQty,
            this.repSearchCodeFileName,
            this.repbtnDelete,
            this.repSpinUnit,
            this.repSpinTax1});
            this.gridControlOrderList.Size = new System.Drawing.Size(1012, 324);
            this.gridControlOrderList.TabIndex = 2;
            this.gridControlOrderList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOrderList});
            this.gridControlOrderList.DragDrop += new System.Windows.Forms.DragEventHandler(this.gridControlOrderList_DragDrop);
            this.gridControlOrderList.DragEnter += new System.Windows.Forms.DragEventHandler(this.gridControlOrderList_DragEnter);
            this.gridControlOrderList.DragOver += new System.Windows.Forms.DragEventHandler(this.gridControlOrderList_DragOver);
            // 
            // bindingSource_OrderList
            // 
            this.bindingSource_OrderList.DataMember = "OrderList";
            this.bindingSource_OrderList.DataSource = this.dataSet_Order;
            // 
            // gridViewOrderList
            // 
            this.gridViewOrderList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId1,
            this.colOrderHeadNo1,
            this.colCodeFileName,
            this.colCodeName,
            this.colUnit,
            this.colQty,
            this.colAmount,
            this.colTax1,
            this.colTaxAmount,
            this.colSumAmount,
            this.colPlanDate1,
            this.colRemark,
            this.colDelete,
            this.colPrReqNo,
            this.colPrListAutoId});
            this.gridViewOrderList.GridControl = this.gridControlOrderList;
            this.gridViewOrderList.IndicatorWidth = 40;
            this.gridViewOrderList.Name = "gridViewOrderList";
            this.gridViewOrderList.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewOrderList.OptionsMenu.EnableColumnMenu = false;
            this.gridViewOrderList.OptionsMenu.EnableFooterMenu = false;
            this.gridViewOrderList.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewOrderList.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewOrderList.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewOrderList.OptionsView.ColumnAutoWidth = false;
            this.gridViewOrderList.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewOrderList.OptionsView.ShowFooter = true;
            this.gridViewOrderList.OptionsView.ShowGroupPanel = false;
            this.gridViewOrderList.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewOrderList_RowClick);
            this.gridViewOrderList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewOrderList_CustomDrawRowIndicator);
            this.gridViewOrderList.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridViewOrderList_InitNewRow);
            this.gridViewOrderList.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewOrderList_CellValueChanged);
            this.gridViewOrderList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewOrderList_KeyDown);
            // 
            // colAutoId1
            // 
            this.colAutoId1.FieldName = "AutoId";
            this.colAutoId1.Name = "colAutoId1";
            // 
            // colOrderHeadNo1
            // 
            this.colOrderHeadNo1.AppearanceHeader.Options.UseTextOptions = true;
            this.colOrderHeadNo1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOrderHeadNo1.FieldName = "OrderHeadNo";
            this.colOrderHeadNo1.Name = "colOrderHeadNo1";
            this.colOrderHeadNo1.OptionsColumn.AllowEdit = false;
            this.colOrderHeadNo1.OptionsColumn.AllowFocus = false;
            this.colOrderHeadNo1.OptionsColumn.ReadOnly = true;
            this.colOrderHeadNo1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "PrReqNo", "共计{0}条")});
            this.colOrderHeadNo1.Visible = true;
            this.colOrderHeadNo1.VisibleIndex = 0;
            this.colOrderHeadNo1.Width = 110;
            // 
            // colCodeFileName
            // 
            this.colCodeFileName.AppearanceHeader.Options.UseTextOptions = true;
            this.colCodeFileName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCodeFileName.ColumnEdit = this.repSearchCodeFileName;
            this.colCodeFileName.FieldName = "CodeFileName";
            this.colCodeFileName.Name = "colCodeFileName";
            this.colCodeFileName.OptionsColumn.AllowEdit = false;
            this.colCodeFileName.Visible = true;
            this.colCodeFileName.VisibleIndex = 1;
            this.colCodeFileName.Width = 110;
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
            this.repSearchCodeFileName.View = this.repSearchCodeFileNameView;
            // 
            // repSearchCodeFileNameView
            // 
            this.repSearchCodeFileNameView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumnCodeFileName,
            this.gridColumnCodeName});
            this.repSearchCodeFileNameView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repSearchCodeFileNameView.IndicatorWidth = 60;
            this.repSearchCodeFileNameView.Name = "repSearchCodeFileNameView";
            this.repSearchCodeFileNameView.OptionsBehavior.Editable = false;
            this.repSearchCodeFileNameView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repSearchCodeFileNameView.OptionsView.ShowGroupPanel = false;
            this.repSearchCodeFileNameView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.repSearchCodeFileNameView_CustomDrawRowIndicator);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "AutoId";
            this.gridColumn1.Name = "gridColumn1";
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
            // colCodeName
            // 
            this.colCodeName.AppearanceHeader.Options.UseTextOptions = true;
            this.colCodeName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCodeName.FieldName = "CodeName";
            this.colCodeName.Name = "colCodeName";
            this.colCodeName.OptionsColumn.AllowEdit = false;
            this.colCodeName.OptionsColumn.AllowFocus = false;
            this.colCodeName.Visible = true;
            this.colCodeName.VisibleIndex = 2;
            this.colCodeName.Width = 110;
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
            this.colUnit.VisibleIndex = 3;
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
            this.colAmount.VisibleIndex = 5;
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
            this.colTax1.VisibleIndex = 6;
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
            this.colTaxAmount.VisibleIndex = 7;
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
            this.colSumAmount.VisibleIndex = 8;
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
            this.colPlanDate1.VisibleIndex = 9;
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
            this.colRemark.VisibleIndex = 10;
            this.colRemark.Width = 140;
            // 
            // colDelete
            // 
            this.colDelete.ColumnEdit = this.repbtnDelete;
            this.colDelete.Name = "colDelete";
            this.colDelete.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 12;
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
            // colPrReqNo
            // 
            this.colPrReqNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrReqNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrReqNo.FieldName = "PrReqNo";
            this.colPrReqNo.Name = "colPrReqNo";
            this.colPrReqNo.OptionsColumn.AllowEdit = false;
            this.colPrReqNo.OptionsColumn.AllowFocus = false;
            this.colPrReqNo.Visible = true;
            this.colPrReqNo.VisibleIndex = 11;
            this.colPrReqNo.Width = 110;
            // 
            // colPrListAutoId
            // 
            this.colPrListAutoId.FieldName = "PrListAutoId";
            this.colPrListAutoId.Name = "colPrListAutoId";
            // 
            // dockManagerLeft
            // 
            this.dockManagerLeft.AutoHideSpeed = 5;
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
            this.dockPnlLeft.ID = new System.Guid("312f9e64-da09-4a27-a005-5906bb7c903e");
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
            this.dockPnlLeft.Size = new System.Drawing.Size(350, 601);
            this.dockPnlLeft.Text = "请购单";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.pnlLeftBottle);
            this.dockPanel1_Container.Controls.Add(this.splitterControl2);
            this.dockPanel1_Container.Controls.Add(this.pnlLeftMiddle);
            this.dockPanel1_Container.Controls.Add(this.pnlLeftTop);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(342, 574);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // pnlLeftBottle
            // 
            this.pnlLeftBottle.Controls.Add(this.gridControlPrReqList);
            this.pnlLeftBottle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeftBottle.Location = new System.Drawing.Point(0, 225);
            this.pnlLeftBottle.Name = "pnlLeftBottle";
            this.pnlLeftBottle.Size = new System.Drawing.Size(342, 349);
            this.pnlLeftBottle.TabIndex = 7;
            // 
            // gridControlPrReqList
            // 
            this.gridControlPrReqList.AllowDrop = true;
            this.gridControlPrReqList.DataSource = this.bindingSource_PrReqList;
            this.gridControlPrReqList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPrReqList.Location = new System.Drawing.Point(2, 2);
            this.gridControlPrReqList.MainView = this.gridViewPrReqList;
            this.gridControlPrReqList.Name = "gridControlPrReqList";
            this.gridControlPrReqList.Size = new System.Drawing.Size(338, 345);
            this.gridControlPrReqList.TabIndex = 3;
            this.gridControlPrReqList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPrReqList});
            // 
            // bindingSource_PrReqList
            // 
            this.bindingSource_PrReqList.DataMember = "PrReqList";
            this.bindingSource_PrReqList.DataSource = this.dataSet_PrReq;
            // 
            // dataSet_PrReq
            // 
            this.dataSet_PrReq.DataSetName = "NewDataSet";
            this.dataSet_PrReq.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTablePrReqHead,
            this.dataTablePrReqList});
            // 
            // dataTablePrReqHead
            // 
            this.dataTablePrReqHead.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn2,
            this.dataColumn3,
            this.dataColReqDate,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8,
            this.dataColApplicant,
            this.dataColApplicantIp,
            this.dataColApplicantTime,
            this.dataColumn9,
            this.dataColumn10,
            this.dataColumn11,
            this.dataColumn14});
            this.dataTablePrReqHead.TableName = "PrReqHead";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "AutoId";
            this.dataColumn2.DataType = typeof(int);
            // 
            // dataColumn3
            // 
            this.dataColumn3.Caption = "请购单号";
            this.dataColumn3.ColumnName = "PrReqNo";
            // 
            // dataColReqDate
            // 
            this.dataColReqDate.Caption = "请购日期";
            this.dataColReqDate.ColumnName = "ReqDate";
            this.dataColReqDate.DataType = typeof(System.DateTime);
            // 
            // dataColumn4
            // 
            this.dataColumn4.Caption = "申请部门";
            this.dataColumn4.ColumnName = "ReqDep";
            // 
            // dataColumn5
            // 
            this.dataColumn5.Caption = "项目号";
            this.dataColumn5.ColumnName = "ProjectNo";
            // 
            // dataColumn6
            // 
            this.dataColumn6.Caption = "站号";
            this.dataColumn6.ColumnName = "StnNo";
            // 
            // dataColumn7
            // 
            this.dataColumn7.Caption = "采购类型";
            this.dataColumn7.ColumnName = "PurCategory";
            // 
            // dataColumn8
            // 
            this.dataColumn8.Caption = "状态";
            this.dataColumn8.ColumnName = "ReqState";
            this.dataColumn8.DataType = typeof(short);
            // 
            // dataColApplicant
            // 
            this.dataColApplicant.Caption = "申请人";
            this.dataColApplicant.ColumnName = "Applicant";
            // 
            // dataColApplicantIp
            // 
            this.dataColApplicantIp.Caption = "申请人IP";
            this.dataColApplicantIp.ColumnName = "ApplicantIp";
            // 
            // dataColApplicantTime
            // 
            this.dataColApplicantTime.Caption = "申请时间";
            this.dataColApplicantTime.ColumnName = "ApplicantTime";
            this.dataColApplicantTime.DataType = typeof(System.DateTime);
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
            // dataColumn14
            // 
            this.dataColumn14.Caption = "备注";
            this.dataColumn14.ColumnName = "PrReqRemark";
            // 
            // dataTablePrReqList
            // 
            this.dataTablePrReqList.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn19,
            this.dataColumnPrReqNo,
            this.dataColumn20,
            this.dataColumn21,
            this.dataColRequirementDate,
            this.dataColPrReqListRemark,
            this.dataColumn22,
            this.dataColOrderCount,
            this.dataColOverplus});
            this.dataTablePrReqList.TableName = "PrReqList";
            // 
            // dataColumn19
            // 
            this.dataColumn19.ColumnName = "AutoId";
            // 
            // dataColumnPrReqNo
            // 
            this.dataColumnPrReqNo.Caption = "请购单号";
            this.dataColumnPrReqNo.ColumnName = "PrReqNo";
            // 
            // dataColumn20
            // 
            this.dataColumn20.Caption = "零件编号";
            this.dataColumn20.ColumnName = "CodeFileName";
            // 
            // dataColumn21
            // 
            this.dataColumn21.Caption = "请购数量";
            this.dataColumn21.ColumnName = "Qty";
            this.dataColumn21.DataType = typeof(double);
            // 
            // dataColRequirementDate
            // 
            this.dataColRequirementDate.Caption = "需求日期";
            this.dataColRequirementDate.ColumnName = "RequirementDate";
            this.dataColRequirementDate.DataType = typeof(System.DateTime);
            // 
            // dataColPrReqListRemark
            // 
            this.dataColPrReqListRemark.Caption = "备注";
            this.dataColPrReqListRemark.ColumnName = "PrReqListRemark";
            // 
            // dataColumn22
            // 
            this.dataColumn22.Caption = "零件名称";
            this.dataColumn22.ColumnName = "CodeName";
            // 
            // dataColOrderCount
            // 
            this.dataColOrderCount.Caption = "已购数量";
            this.dataColOrderCount.ColumnName = "OrderCount";
            this.dataColOrderCount.DataType = typeof(double);
            // 
            // dataColOverplus
            // 
            this.dataColOverplus.Caption = "剩余数量";
            this.dataColOverplus.ColumnName = "Overplus";
            this.dataColOverplus.DataType = typeof(double);
            // 
            // gridViewPrReqList
            // 
            this.gridViewPrReqList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn13,
            this.colPrReqNo1,
            this.gridColumn14,
            this.gridColumn18,
            this.gridColumn19,
            this.colOrderCount,
            this.colOverplus,
            this.colRequirementDate,
            this.colPrReqListRemark});
            this.gridViewPrReqList.GridControl = this.gridControlPrReqList;
            this.gridViewPrReqList.IndicatorWidth = 40;
            this.gridViewPrReqList.Name = "gridViewPrReqList";
            this.gridViewPrReqList.OptionsBehavior.Editable = false;
            this.gridViewPrReqList.OptionsBehavior.ReadOnly = true;
            this.gridViewPrReqList.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewPrReqList.OptionsSelection.MultiSelect = true;
            this.gridViewPrReqList.OptionsView.ColumnAutoWidth = false;
            this.gridViewPrReqList.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewPrReqList.OptionsView.ShowGroupPanel = false;
            this.gridViewPrReqList.OptionsView.ShowIndicator = false;
            this.gridViewPrReqList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridViewPrReqList_MouseDown);
            this.gridViewPrReqList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gridViewPrReqList_MouseMove);
            // 
            // gridColumn13
            // 
            this.gridColumn13.FieldName = "AutoId";
            this.gridColumn13.Name = "gridColumn13";
            // 
            // colPrReqNo1
            // 
            this.colPrReqNo1.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrReqNo1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrReqNo1.FieldName = "PrReqNo";
            this.colPrReqNo1.Name = "colPrReqNo1";
            this.colPrReqNo1.OptionsColumn.AllowEdit = false;
            this.colPrReqNo1.OptionsColumn.AllowFocus = false;
            this.colPrReqNo1.OptionsColumn.ReadOnly = true;
            this.colPrReqNo1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "PrReqNo", "共计{0}条")});
            this.colPrReqNo1.Width = 110;
            // 
            // gridColumn14
            // 
            this.gridColumn14.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn14.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn14.FieldName = "CodeFileName";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.OptionsColumn.AllowEdit = false;
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 0;
            this.gridColumn14.Width = 110;
            // 
            // gridColumn18
            // 
            this.gridColumn18.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn18.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn18.FieldName = "CodeName";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.OptionsColumn.AllowEdit = false;
            this.gridColumn18.OptionsColumn.AllowFocus = false;
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 4;
            this.gridColumn18.Width = 80;
            // 
            // gridColumn19
            // 
            this.gridColumn19.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn19.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn19.FieldName = "Qty";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.OptionsColumn.AllowEdit = false;
            this.gridColumn19.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qty", "{0:0.##}")});
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 1;
            this.gridColumn19.Width = 60;
            // 
            // colOrderCount
            // 
            this.colOrderCount.AppearanceHeader.Options.UseTextOptions = true;
            this.colOrderCount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOrderCount.FieldName = "OrderCount";
            this.colOrderCount.Name = "colOrderCount";
            this.colOrderCount.OptionsColumn.AllowEdit = false;
            this.colOrderCount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OrderCount", "{0:0.##}")});
            this.colOrderCount.Visible = true;
            this.colOrderCount.VisibleIndex = 2;
            this.colOrderCount.Width = 60;
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
            this.colOverplus.VisibleIndex = 3;
            this.colOverplus.Width = 60;
            // 
            // colRequirementDate
            // 
            this.colRequirementDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colRequirementDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRequirementDate.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.colRequirementDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colRequirementDate.FieldName = "RequirementDate";
            this.colRequirementDate.Name = "colRequirementDate";
            this.colRequirementDate.OptionsColumn.AllowEdit = false;
            this.colRequirementDate.Visible = true;
            this.colRequirementDate.VisibleIndex = 5;
            this.colRequirementDate.Width = 90;
            // 
            // colPrReqListRemark
            // 
            this.colPrReqListRemark.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrReqListRemark.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrReqListRemark.FieldName = "PrReqListRemark";
            this.colPrReqListRemark.Name = "colPrReqListRemark";
            this.colPrReqListRemark.OptionsColumn.AllowEdit = false;
            this.colPrReqListRemark.Visible = true;
            this.colPrReqListRemark.VisibleIndex = 6;
            this.colPrReqListRemark.Width = 100;
            // 
            // splitterControl2
            // 
            this.splitterControl2.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.splitterControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterControl2.Location = new System.Drawing.Point(0, 220);
            this.splitterControl2.Name = "splitterControl2";
            this.splitterControl2.Size = new System.Drawing.Size(342, 5);
            this.splitterControl2.TabIndex = 8;
            this.splitterControl2.TabStop = false;
            // 
            // pnlLeftMiddle
            // 
            this.pnlLeftMiddle.Controls.Add(this.gridControlPrReqHead);
            this.pnlLeftMiddle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeftMiddle.Location = new System.Drawing.Point(0, 93);
            this.pnlLeftMiddle.Name = "pnlLeftMiddle";
            this.pnlLeftMiddle.Size = new System.Drawing.Size(342, 127);
            this.pnlLeftMiddle.TabIndex = 7;
            // 
            // gridControlPrReqHead
            // 
            this.gridControlPrReqHead.DataSource = this.bindingSource_PrReqHead;
            this.gridControlPrReqHead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPrReqHead.Location = new System.Drawing.Point(2, 2);
            this.gridControlPrReqHead.MainView = this.gridViewPrReqHead;
            this.gridControlPrReqHead.Name = "gridControlPrReqHead";
            this.gridControlPrReqHead.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repLookUpPrReqReqDep,
            this.repLookUpPrReqPurCategory,
            this.repSearchPrReqProjectNo});
            this.gridControlPrReqHead.Size = new System.Drawing.Size(338, 123);
            this.gridControlPrReqHead.TabIndex = 2;
            this.gridControlPrReqHead.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPrReqHead});
            // 
            // bindingSource_PrReqHead
            // 
            this.bindingSource_PrReqHead.DataMember = "PrReqHead";
            this.bindingSource_PrReqHead.DataSource = this.dataSet_PrReq;
            // 
            // gridViewPrReqHead
            // 
            this.gridViewPrReqHead.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.colReqDate,
            this.gridColumn6,
            this.gridColumn10,
            this.gridColumn5,
            this.gridColumn11,
            this.colApplicant,
            this.gridColumn12});
            this.gridViewPrReqHead.GridControl = this.gridControlPrReqHead;
            this.gridViewPrReqHead.IndicatorWidth = 40;
            this.gridViewPrReqHead.Name = "gridViewPrReqHead";
            this.gridViewPrReqHead.OptionsBehavior.Editable = false;
            this.gridViewPrReqHead.OptionsBehavior.ReadOnly = true;
            this.gridViewPrReqHead.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewPrReqHead.OptionsView.ColumnAutoWidth = false;
            this.gridViewPrReqHead.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewPrReqHead.OptionsView.ShowGroupPanel = false;
            this.gridViewPrReqHead.OptionsView.ShowIndicator = false;
            this.gridViewPrReqHead.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewPrReqHead_FocusedRowChanged);
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "AutoId";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.FieldName = "PrReqNo";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "PrReqNo", "共计{0}条")});
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 110;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.FieldName = "ReqState";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowFocus = false;
            this.gridColumn4.Width = 60;
            // 
            // colReqDate
            // 
            this.colReqDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colReqDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colReqDate.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.colReqDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colReqDate.FieldName = "ReqDate";
            this.colReqDate.Name = "colReqDate";
            this.colReqDate.OptionsColumn.AllowEdit = false;
            this.colReqDate.Visible = true;
            this.colReqDate.VisibleIndex = 1;
            this.colReqDate.Width = 90;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.ColumnEdit = this.repSearchPrReqProjectNo;
            this.gridColumn6.FieldName = "ProjectNo";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            this.gridColumn6.Width = 100;
            // 
            // repSearchPrReqProjectNo
            // 
            this.repSearchPrReqProjectNo.AutoHeight = false;
            this.repSearchPrReqProjectNo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repSearchPrReqProjectNo.DisplayMember = "ProjectNo";
            this.repSearchPrReqProjectNo.Name = "repSearchPrReqProjectNo";
            this.repSearchPrReqProjectNo.NullText = "";
            this.repSearchPrReqProjectNo.ValueMember = "ProjectNo";
            this.repSearchPrReqProjectNo.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.IndicatorWidth = 60;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "项目号";
            this.gridColumn7.FieldName = "ProjectNo";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "项目名称";
            this.gridColumn8.FieldName = "ProjectName";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 1;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "备注";
            this.gridColumn9.FieldName = "Remark";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 2;
            // 
            // gridColumn10
            // 
            this.gridColumn10.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn10.FieldName = "StnNo";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 3;
            this.gridColumn10.Width = 80;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.ColumnEdit = this.repLookUpPrReqReqDep;
            this.gridColumn5.FieldName = "ReqDep";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 80;
            // 
            // repLookUpPrReqReqDep
            // 
            this.repLookUpPrReqReqDep.AutoHeight = false;
            this.repLookUpPrReqReqDep.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpPrReqReqDep.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentNo", "部门编号", 95, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentName", "部门名称", 111, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repLookUpPrReqReqDep.DisplayMember = "DepartmentName";
            this.repLookUpPrReqReqDep.Name = "repLookUpPrReqReqDep";
            this.repLookUpPrReqReqDep.NullText = "";
            this.repLookUpPrReqReqDep.ValueMember = "DepartmentNo";
            // 
            // gridColumn11
            // 
            this.gridColumn11.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn11.ColumnEdit = this.repLookUpPrReqPurCategory;
            this.gridColumn11.FieldName = "PurCategory";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 5;
            this.gridColumn11.Width = 80;
            // 
            // repLookUpPrReqPurCategory
            // 
            this.repLookUpPrReqPurCategory.AutoHeight = false;
            this.repLookUpPrReqPurCategory.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpPrReqPurCategory.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PurCategory", "编号", 81, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PurCategoryText", "名称", 111, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repLookUpPrReqPurCategory.DisplayMember = "PurCategoryText";
            this.repLookUpPrReqPurCategory.Name = "repLookUpPrReqPurCategory";
            this.repLookUpPrReqPurCategory.NullText = "";
            this.repLookUpPrReqPurCategory.ValueMember = "PurCategory";
            // 
            // colApplicant
            // 
            this.colApplicant.AppearanceHeader.Options.UseTextOptions = true;
            this.colApplicant.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colApplicant.FieldName = "Applicant";
            this.colApplicant.Name = "colApplicant";
            this.colApplicant.OptionsColumn.AllowEdit = false;
            this.colApplicant.OptionsColumn.AllowFocus = false;
            this.colApplicant.Visible = true;
            this.colApplicant.VisibleIndex = 7;
            this.colApplicant.Width = 70;
            // 
            // gridColumn12
            // 
            this.gridColumn12.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn12.FieldName = "PrReqRemark";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.AllowEdit = false;
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 6;
            this.gridColumn12.Width = 100;
            // 
            // pnlLeftTop
            // 
            this.pnlLeftTop.Controls.Add(this.searchLookUpProjectNo);
            this.pnlLeftTop.Controls.Add(this.dateReqDateEnd);
            this.pnlLeftTop.Controls.Add(this.dateReqDateBegin);
            this.pnlLeftTop.Controls.Add(this.textPrReqNo);
            this.pnlLeftTop.Controls.Add(this.btnPrReqQuery);
            this.pnlLeftTop.Controls.Add(this.labProjectNo);
            this.pnlLeftTop.Controls.Add(this.lab);
            this.pnlLeftTop.Controls.Add(this.labReqDate);
            this.pnlLeftTop.Controls.Add(this.labPrReqNo);
            this.pnlLeftTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeftTop.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftTop.Name = "pnlLeftTop";
            this.pnlLeftTop.Size = new System.Drawing.Size(342, 93);
            this.pnlLeftTop.TabIndex = 0;
            // 
            // searchLookUpProjectNo
            // 
            this.searchLookUpProjectNo.EnterMoveNextControl = true;
            this.searchLookUpProjectNo.Location = new System.Drawing.Point(74, 65);
            this.searchLookUpProjectNo.Name = "searchLookUpProjectNo";
            this.searchLookUpProjectNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpProjectNo.Properties.DisplayMember = "ProjectName";
            this.searchLookUpProjectNo.Properties.NullText = "";
            this.searchLookUpProjectNo.Properties.ValueMember = "ProjectNo";
            this.searchLookUpProjectNo.Properties.View = this.searchLookUpProjectNoView;
            this.searchLookUpProjectNo.Size = new System.Drawing.Size(120, 20);
            this.searchLookUpProjectNo.TabIndex = 204;
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
            this.searchLookUpProjectNoView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewOrderHead_CustomDrawRowIndicator);
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
            // dateReqDateEnd
            // 
            this.dateReqDateEnd.EditValue = null;
            this.dateReqDateEnd.EnterMoveNextControl = true;
            this.dateReqDateEnd.Location = new System.Drawing.Point(191, 37);
            this.dateReqDateEnd.Name = "dateReqDateEnd";
            this.dateReqDateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateReqDateEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateReqDateEnd.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dateReqDateEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateReqDateEnd.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateReqDateEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateReqDateEnd.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateReqDateEnd.Size = new System.Drawing.Size(100, 20);
            this.dateReqDateEnd.TabIndex = 203;
            // 
            // dateReqDateBegin
            // 
            this.dateReqDateBegin.EditValue = null;
            this.dateReqDateBegin.EnterMoveNextControl = true;
            this.dateReqDateBegin.Location = new System.Drawing.Point(74, 37);
            this.dateReqDateBegin.Name = "dateReqDateBegin";
            this.dateReqDateBegin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateReqDateBegin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateReqDateBegin.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dateReqDateBegin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateReqDateBegin.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateReqDateBegin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateReqDateBegin.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateReqDateBegin.Size = new System.Drawing.Size(100, 20);
            this.dateReqDateBegin.TabIndex = 202;
            // 
            // textPrReqNo
            // 
            this.textPrReqNo.EnterMoveNextControl = true;
            this.textPrReqNo.Location = new System.Drawing.Point(74, 8);
            this.textPrReqNo.Name = "textPrReqNo";
            this.textPrReqNo.Size = new System.Drawing.Size(150, 20);
            this.textPrReqNo.TabIndex = 201;
            // 
            // btnPrReqQuery
            // 
            this.btnPrReqQuery.Location = new System.Drawing.Point(208, 64);
            this.btnPrReqQuery.Name = "btnPrReqQuery";
            this.btnPrReqQuery.Size = new System.Drawing.Size(75, 23);
            this.btnPrReqQuery.TabIndex = 205;
            this.btnPrReqQuery.Text = "查询";
            this.btnPrReqQuery.Click += new System.EventHandler(this.btnPrReqQuery_Click);
            // 
            // labProjectNo
            // 
            this.labProjectNo.Location = new System.Drawing.Point(9, 68);
            this.labProjectNo.Name = "labProjectNo";
            this.labProjectNo.Size = new System.Drawing.Size(48, 14);
            this.labProjectNo.TabIndex = 114;
            this.labProjectNo.Text = "项目号：";
            // 
            // lab
            // 
            this.lab.Location = new System.Drawing.Point(180, 40);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(4, 14);
            this.lab.TabIndex = 112;
            this.lab.Text = "-";
            // 
            // labReqDate
            // 
            this.labReqDate.Location = new System.Drawing.Point(9, 40);
            this.labReqDate.Name = "labReqDate";
            this.labReqDate.Size = new System.Drawing.Size(60, 14);
            this.labReqDate.TabIndex = 111;
            this.labReqDate.Text = "请购日期：";
            // 
            // labPrReqNo
            // 
            this.labPrReqNo.Location = new System.Drawing.Point(9, 11);
            this.labPrReqNo.Name = "labPrReqNo";
            this.labPrReqNo.Size = new System.Drawing.Size(60, 14);
            this.labPrReqNo.TabIndex = 108;
            this.labPrReqNo.Text = "请购单号：";
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.pnlBottom);
            this.pnlRight.Controls.Add(this.splitterControl1);
            this.pnlRight.Controls.Add(this.pnlMiddle);
            this.pnlRight.Controls.Add(this.pnltop);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(350, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(1020, 601);
            this.pnlRight.TabIndex = 6;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterControl1.Location = new System.Drawing.Point(2, 266);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(1016, 5);
            this.splitterControl1.TabIndex = 5;
            this.splitterControl1.TabStop = false;
            // 
            // popupMenuList
            // 
            this.popupMenuList.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonUp),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonDown)});
            this.popupMenuList.Manager = this.barManagerForm;
            this.popupMenuList.Name = "popupMenuList";
            // 
            // barButtonUp
            // 
            this.barButtonUp.Caption = "上级-请购单";
            this.barButtonUp.Id = 2;
            this.barButtonUp.Name = "barButtonUp";
            this.barButtonUp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonUp_ItemClick);
            // 
            // barButtonDown
            // 
            this.barButtonDown.Caption = "下级-入库单";
            this.barButtonDown.Id = 3;
            this.barButtonDown.Name = "barButtonDown";
            this.barButtonDown.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonDown_ItemClick);
            // 
            // barManagerForm
            // 
            this.barManagerForm.DockControls.Add(this.barDockControlTop);
            this.barManagerForm.DockControls.Add(this.barDockControlBottom);
            this.barManagerForm.DockControls.Add(this.barDockControlLeft);
            this.barManagerForm.DockControls.Add(this.barDockControlRight);
            this.barManagerForm.Form = this;
            this.barManagerForm.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonUp,
            this.barButtonDown});
            this.barManagerForm.MaxItemId = 4;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1370, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 601);
            this.barDockControlBottom.Size = new System.Drawing.Size(1370, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 601);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1370, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 601);
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiJhdhribnwk,
            this.tsmiDgrqbnwk,
            this.tsmiDqcgdyjxg,
            this.tsmiCglxbnwkbc,
            this.tsmiSqbmbnwkbc,
            this.tsmiXmhbnwkbc,
            this.tsmiZhbnwkbc,
            this.tsmiFklxbnwkbc,
            this.tsmiSrdzhbsyxmh,
            this.tsmiQdygddqxzd,
            this.tsmiQgsyansjcw,
            this.tsmiCxmxdsyjqgdcw,
            this.tsmiCxmxdxyjrkdcw,
            this.tsmiCgdd,
            this.tsmiQgrqbnwkcx,
            this.tsmiCxqgdsjcw,
            this.tsmiJjcxqgdmxsjcw,
            this.tsmiSxtzqgdsjcw,
            this.tsmiYzcgddzrxxmdxmh});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(365, 444);
            // 
            // tsmiJhdhribnwk
            // 
            this.tsmiJhdhribnwk.Name = "tsmiJhdhribnwk";
            this.tsmiJhdhribnwk.Size = new System.Drawing.Size(364, 22);
            this.tsmiJhdhribnwk.Text = "计划到货日期不能为空，请设置后重新进行查询。";
            // 
            // tsmiDgrqbnwk
            // 
            this.tsmiDgrqbnwk.Name = "tsmiDgrqbnwk";
            this.tsmiDgrqbnwk.Size = new System.Drawing.Size(364, 22);
            this.tsmiDgrqbnwk.Text = "订购日期不能为空，请设置后重新进行查询。";
            // 
            // tsmiDqcgdyjxg
            // 
            this.tsmiDqcgdyjxg.Name = "tsmiDqcgdyjxg";
            this.tsmiDqcgdyjxg.Size = new System.Drawing.Size(364, 22);
            this.tsmiDqcgdyjxg.Text = "当前采购单已经修改，请保存后再进行换行。";
            // 
            // cms3
            // 
            this.cms3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCgjzd,
            this.tsmiWsp,
            this.tsmiBkycz,
            this.tsmiYjsp,
            this.tsmiYjjz,
            this.tsmiYjspz,
            this.tsmiCgjzdz,
            this.tsmiDsl,
            this.tsmiCgrkdd,
            this.tsmiBkybc,
            this.tsmiWcxdyc,
            this.tsmiCzsjw,
            this.tsmiCtjzsj,
            this.tsmiCtjh,
            this.tsmiJzribn,
            this.tsmiFkrqbn,
            this.tsmiCxansj,
            this.tsmiDqcgjzd,
            this.tsmiZbjjhg,
            this.tsmiBc,
            this.tsmiTjl});
            this.cms3.Name = "cmsCommonHandler";
            this.cms3.Size = new System.Drawing.Size(365, 466);
            // 
            // tsmiCgjzd
            // 
            this.tsmiCgjzd.Name = "tsmiCgjzd";
            this.tsmiCgjzd.Size = new System.Drawing.Size(364, 22);
            this.tsmiCgjzd.Text = "采购结账单";
            // 
            // tsmiWsp
            // 
            this.tsmiWsp.Name = "tsmiWsp";
            this.tsmiWsp.Size = new System.Drawing.Size(364, 22);
            this.tsmiWsp.Text = "未审批";
            // 
            // tsmiBkycz
            // 
            this.tsmiBkycz.Name = "tsmiBkycz";
            this.tsmiBkycz.Size = new System.Drawing.Size(364, 22);
            this.tsmiBkycz.Text = "，不可以操作。";
            // 
            // tsmiYjsp
            // 
            this.tsmiYjsp.Name = "tsmiYjsp";
            this.tsmiYjsp.Size = new System.Drawing.Size(364, 22);
            this.tsmiYjsp.Text = "已经审批";
            // 
            // tsmiYjjz
            // 
            this.tsmiYjjz.Name = "tsmiYjjz";
            this.tsmiYjjz.Size = new System.Drawing.Size(364, 22);
            this.tsmiYjjz.Text = "已经结账";
            // 
            // tsmiYjspz
            // 
            this.tsmiYjspz.Name = "tsmiYjspz";
            this.tsmiYjspz.Size = new System.Drawing.Size(364, 22);
            this.tsmiYjspz.Text = "已经审批中";
            // 
            // tsmiCgjzdz
            // 
            this.tsmiCgjzdz.Name = "tsmiCgjzdz";
            this.tsmiCgjzdz.Size = new System.Drawing.Size(364, 22);
            this.tsmiCgjzdz.Text = "采购结账单中明细";
            // 
            // tsmiDsl
            // 
            this.tsmiDsl.Name = "tsmiDsl";
            this.tsmiDsl.Size = new System.Drawing.Size(364, 22);
            this.tsmiDsl.Text = "的数量";
            // 
            // tsmiCgrkdd
            // 
            this.tsmiCgrkdd.Name = "tsmiCgrkdd";
            this.tsmiCgrkdd.Size = new System.Drawing.Size(364, 22);
            this.tsmiCgrkdd.Text = "超过入库单的数量";
            // 
            // tsmiBkybc
            // 
            this.tsmiBkybc.Name = "tsmiBkybc";
            this.tsmiBkybc.Size = new System.Drawing.Size(364, 22);
            this.tsmiBkybc.Text = "，不可以保存。";
            // 
            // tsmiWcxdyc
            // 
            this.tsmiWcxdyc.Name = "tsmiWcxdyc";
            this.tsmiWcxdyc.Size = new System.Drawing.Size(364, 22);
            this.tsmiWcxdyc.Text = "未查询到要操作的采购结账单，请刷新后再进行操作。";
            // 
            // tsmiCzsjw
            // 
            this.tsmiCzsjw.Name = "tsmiCzsjw";
            this.tsmiCzsjw.Size = new System.Drawing.Size(364, 22);
            this.tsmiCzsjw.Text = "操作时间为";
            // 
            // tsmiCtjzsj
            // 
            this.tsmiCtjzsj.Name = "tsmiCtjzsj";
            this.tsmiCtjzsj.Size = new System.Drawing.Size(364, 22);
            this.tsmiCtjzsj.Text = "窗体加载事件错误。";
            // 
            // tsmiCtjh
            // 
            this.tsmiCtjh.Name = "tsmiCtjh";
            this.tsmiCtjh.Size = new System.Drawing.Size(364, 22);
            this.tsmiCtjh.Text = "窗体激活事件错误。";
            // 
            // tsmiJzribn
            // 
            this.tsmiJzribn.Name = "tsmiJzribn";
            this.tsmiJzribn.Size = new System.Drawing.Size(364, 22);
            this.tsmiJzribn.Text = "结账日期不能为空，请设置后重新进行查询。";
            // 
            // tsmiFkrqbn
            // 
            this.tsmiFkrqbn.Name = "tsmiFkrqbn";
            this.tsmiFkrqbn.Size = new System.Drawing.Size(364, 22);
            this.tsmiFkrqbn.Text = "付款日期不能为空，请设置后重新进行查询。";
            // 
            // tsmiCxansj
            // 
            this.tsmiCxansj.Name = "tsmiCxansj";
            this.tsmiCxansj.Size = new System.Drawing.Size(364, 22);
            this.tsmiCxansj.Text = "查询按钮事件错误。";
            // 
            // tsmiDqcgjzd
            // 
            this.tsmiDqcgjzd.Name = "tsmiDqcgjzd";
            this.tsmiDqcgjzd.Size = new System.Drawing.Size(364, 22);
            this.tsmiDqcgjzd.Text = "当前采购结账单已经修改，请保存后再进行换行。";
            // 
            // tsmiZbjjhg
            // 
            this.tsmiZbjjhg.Name = "tsmiZbjjhg";
            this.tsmiZbjjhg.Size = new System.Drawing.Size(364, 22);
            this.tsmiZbjjhg.Text = "主表聚焦行改变事件错误。";
            // 
            // tsmiBc
            // 
            this.tsmiBc.Name = "tsmiBc";
            this.tsmiBc.Size = new System.Drawing.Size(364, 22);
            this.tsmiBc.Text = "保存";
            // 
            // tsmiTjl
            // 
            this.tsmiTjl.Name = "tsmiTjl";
            this.tsmiTjl.Size = new System.Drawing.Size(364, 22);
            this.tsmiTjl.Text = "条记录。";
            // 
            // cms2
            // 
            this.cms2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiZbsd,
            this.tsmiSczbz,
            this.tsmiZbdyg,
            this.tsmiSbczmx,
            this.tsmiCxmxd,
            this.tsmiXg,
            this.tsmiYjspbk,
            this.tsmiYjjzbky,
            this.tsmiYjspzbk,
            this.tsmiWspbk,
            this.tsmiYjgbbk,
            this.tsmiRkrqbn,
            this.tsmiCxrk,
            this.tsmiJjcxrk,
            this.tsmiZgrid,
            this.tsmiSxtzrk,
            this.tsmiYzcgjz});
            this.cms2.Name = "cmsCommonHandler";
            this.cms2.Size = new System.Drawing.Size(329, 378);
            // 
            // tsmiZbsd
            // 
            this.tsmiZbsd.Name = "tsmiZbsd";
            this.tsmiZbsd.Size = new System.Drawing.Size(328, 22);
            this.tsmiZbsd.Text = "主表设定默认值错误。";
            // 
            // tsmiSczbz
            // 
            this.tsmiSczbz.Name = "tsmiSczbz";
            this.tsmiSczbz.Size = new System.Drawing.Size(328, 22);
            this.tsmiSczbz.Text = "删除子表中的一行错误。";
            // 
            // tsmiZbdyg
            // 
            this.tsmiZbdyg.Name = "tsmiZbdyg";
            this.tsmiZbdyg.Size = new System.Drawing.Size(328, 22);
            this.tsmiZbdyg.Text = "子表单元格值变化进行的操作错误。";
            // 
            // tsmiSbczmx
            // 
            this.tsmiSbczmx.Name = "tsmiSbczmx";
            this.tsmiSbczmx.Size = new System.Drawing.Size(328, 22);
            this.tsmiSbczmx.Text = "鼠标操作明细行事件错误。";
            // 
            // tsmiCxmxd
            // 
            this.tsmiCxmxd.Name = "tsmiCxmxd";
            this.tsmiCxmxd.Size = new System.Drawing.Size(328, 22);
            this.tsmiCxmxd.Text = "查询明细的上一级入库单错误。";
            // 
            // tsmiXg
            // 
            this.tsmiXg.Name = "tsmiXg";
            this.tsmiXg.Size = new System.Drawing.Size(328, 22);
            this.tsmiXg.Text = "修改";
            // 
            // tsmiYjspbk
            // 
            this.tsmiYjspbk.Name = "tsmiYjspbk";
            this.tsmiYjspbk.Size = new System.Drawing.Size(328, 22);
            this.tsmiYjspbk.Text = "已经审批，不可以操作。";
            // 
            // tsmiYjjzbky
            // 
            this.tsmiYjjzbky.Name = "tsmiYjjzbky";
            this.tsmiYjjzbky.Size = new System.Drawing.Size(328, 22);
            this.tsmiYjjzbky.Text = "已经结账，不可以操作。";
            // 
            // tsmiYjspzbk
            // 
            this.tsmiYjspzbk.Name = "tsmiYjspzbk";
            this.tsmiYjspzbk.Size = new System.Drawing.Size(328, 22);
            this.tsmiYjspzbk.Text = "已经审批中，不可以操作。";
            // 
            // tsmiWspbk
            // 
            this.tsmiWspbk.Name = "tsmiWspbk";
            this.tsmiWspbk.Size = new System.Drawing.Size(328, 22);
            this.tsmiWspbk.Text = "未审批，不可以操作。";
            // 
            // tsmiYjgbbk
            // 
            this.tsmiYjgbbk.Name = "tsmiYjgbbk";
            this.tsmiYjgbbk.Size = new System.Drawing.Size(328, 22);
            this.tsmiYjgbbk.Text = "已经关闭，不可以操作。";
            // 
            // tsmiRkrqbn
            // 
            this.tsmiRkrqbn.Name = "tsmiRkrqbn";
            this.tsmiRkrqbn.Size = new System.Drawing.Size(328, 22);
            this.tsmiRkrqbn.Text = "入库日期不能为空，请设置后重新进行查询。";
            // 
            // tsmiCxrk
            // 
            this.tsmiCxrk.Name = "tsmiCxrk";
            this.tsmiCxrk.Size = new System.Drawing.Size(328, 22);
            this.tsmiCxrk.Text = "查询入库单事件错误。";
            // 
            // tsmiJjcxrk
            // 
            this.tsmiJjcxrk.Name = "tsmiJjcxrk";
            this.tsmiJjcxrk.Size = new System.Drawing.Size(328, 22);
            this.tsmiJjcxrk.Text = "聚焦查询入库单明细事件错误。";
            // 
            // tsmiZgrid
            // 
            this.tsmiZgrid.Name = "tsmiZgrid";
            this.tsmiZgrid.Size = new System.Drawing.Size(328, 22);
            this.tsmiZgrid.Text = "在GridView中按下鼠标事件错误。";
            // 
            // tsmiSxtzrk
            // 
            this.tsmiSxtzrk.Name = "tsmiSxtzrk";
            this.tsmiSxtzrk.Size = new System.Drawing.Size(328, 22);
            this.tsmiSxtzrk.Text = "实现拖拽入库单事件错误。";
            // 
            // tsmiYzcgjz
            // 
            this.tsmiYzcgjz.Name = "tsmiYzcgjz";
            this.tsmiYzcgjz.Size = new System.Drawing.Size(328, 22);
            this.tsmiYzcgjz.Text = "一张采购结账单只允许相同的往来方进行登记。";
            // 
            // cms1
            // 
            this.cms1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiWlfbnwk,
            this.tsmiRkbm,
            this.tsmiSplx,
            this.tsmiSlbn,
            this.tsmiFkrq,
            this.tsmiSlbnwk,
            this.tsmiDjbnwk,
            this.tsmiBcan,
            this.tsmiQxan,
            this.tsmiQzycz,
            this.tsmiQdysc,
            this.tsmiTjlm,
            this.tsmiScansj,
            this.tsmiQdyspd,
            this.tsmiCgspl,
            this.tsmiSpansj,
            this.tsmiQdyqx,
            this.tsmiCgqxsp,
            this.tsmiQxspan,
            this.tsmiDyyl});
            this.cms1.Name = "cmsCommonHandler";
            this.cms1.Size = new System.Drawing.Size(305, 444);
            // 
            // tsmiWlfbnwk
            // 
            this.tsmiWlfbnwk.Name = "tsmiWlfbnwk";
            this.tsmiWlfbnwk.Size = new System.Drawing.Size(304, 22);
            this.tsmiWlfbnwk.Text = "往来方不能为空，请填写后再进行保存。";
            // 
            // tsmiRkbm
            // 
            this.tsmiRkbm.Name = "tsmiRkbm";
            this.tsmiRkbm.Size = new System.Drawing.Size(304, 22);
            this.tsmiRkbm.Text = "入库部门不能为空，请填写后再进行保存。";
            // 
            // tsmiSplx
            // 
            this.tsmiSplx.Name = "tsmiSplx";
            this.tsmiSplx.Size = new System.Drawing.Size(304, 22);
            this.tsmiSplx.Text = "审批类型不能为空，请填写后再进行保存。";
            // 
            // tsmiSlbn
            // 
            this.tsmiSlbn.Name = "tsmiSlbn";
            this.tsmiSlbn.Size = new System.Drawing.Size(304, 22);
            this.tsmiSlbn.Text = "税率不能为空，请填写后再进行保存。";
            // 
            // tsmiFkrq
            // 
            this.tsmiFkrq.Name = "tsmiFkrq";
            this.tsmiFkrq.Size = new System.Drawing.Size(304, 22);
            this.tsmiFkrq.Text = "付款日期不能为空，请填写后再进行保存。";
            // 
            // tsmiSlbnwk
            // 
            this.tsmiSlbnwk.Name = "tsmiSlbnwk";
            this.tsmiSlbnwk.Size = new System.Drawing.Size(304, 22);
            this.tsmiSlbnwk.Text = "数量不能为空，请填写后再进行保存。";
            // 
            // tsmiDjbnwk
            // 
            this.tsmiDjbnwk.Name = "tsmiDjbnwk";
            this.tsmiDjbnwk.Size = new System.Drawing.Size(304, 22);
            this.tsmiDjbnwk.Text = "单价不能为空，请填写后再进行保存。";
            // 
            // tsmiBcan
            // 
            this.tsmiBcan.Name = "tsmiBcan";
            this.tsmiBcan.Size = new System.Drawing.Size(304, 22);
            this.tsmiBcan.Text = "保存按钮事件错误。";
            // 
            // tsmiQxan
            // 
            this.tsmiQxan.Name = "tsmiQxan";
            this.tsmiQxan.Size = new System.Drawing.Size(304, 22);
            this.tsmiQxan.Text = "取消按钮事件错误。";
            // 
            // tsmiQzycz
            // 
            this.tsmiQzycz.Name = "tsmiQzycz";
            this.tsmiQzycz.Size = new System.Drawing.Size(304, 22);
            this.tsmiQzycz.Text = "请在要操作的记录前面选中。";
            // 
            // tsmiQdysc
            // 
            this.tsmiQdysc.Name = "tsmiQdysc";
            this.tsmiQdysc.Size = new System.Drawing.Size(304, 22);
            this.tsmiQdysc.Text = "确定要删除当前选中的";
            // 
            // tsmiTjlm
            // 
            this.tsmiTjlm.Name = "tsmiTjlm";
            this.tsmiTjlm.Size = new System.Drawing.Size(304, 22);
            this.tsmiTjlm.Text = "条记录吗";
            // 
            // tsmiScansj
            // 
            this.tsmiScansj.Name = "tsmiScansj";
            this.tsmiScansj.Size = new System.Drawing.Size(304, 22);
            this.tsmiScansj.Text = "删除按钮事件错误。";
            // 
            // tsmiQdyspd
            // 
            this.tsmiQdyspd.Name = "tsmiQdyspd";
            this.tsmiQdyspd.Size = new System.Drawing.Size(304, 22);
            this.tsmiQdyspd.Text = "确定要审批当前选中的";
            // 
            // tsmiCgspl
            // 
            this.tsmiCgspl.Name = "tsmiCgspl";
            this.tsmiCgspl.Size = new System.Drawing.Size(304, 22);
            this.tsmiCgspl.Text = "成功审批了";
            // 
            // tsmiSpansj
            // 
            this.tsmiSpansj.Name = "tsmiSpansj";
            this.tsmiSpansj.Size = new System.Drawing.Size(304, 22);
            this.tsmiSpansj.Text = "审批按钮事件错误。";
            // 
            // tsmiQdyqx
            // 
            this.tsmiQdyqx.Name = "tsmiQdyqx";
            this.tsmiQdyqx.Size = new System.Drawing.Size(304, 22);
            this.tsmiQdyqx.Text = "确定要取消审批当前选中的";
            // 
            // tsmiCgqxsp
            // 
            this.tsmiCgqxsp.Name = "tsmiCgqxsp";
            this.tsmiCgqxsp.Size = new System.Drawing.Size(304, 22);
            this.tsmiCgqxsp.Text = "成功取消审批了";
            // 
            // tsmiQxspan
            // 
            this.tsmiQxspan.Name = "tsmiQxspan";
            this.tsmiQxspan.Size = new System.Drawing.Size(304, 22);
            this.tsmiQxspan.Text = "取消审批按钮事件错误。";
            // 
            // tsmiDyyl
            // 
            this.tsmiDyyl.Name = "tsmiDyyl";
            this.tsmiDyyl.Size = new System.Drawing.Size(304, 22);
            this.tsmiDyyl.Text = "打印预览按钮事件错误。";
            // 
            // tsmiCglxbnwkbc
            // 
            this.tsmiCglxbnwkbc.Name = "tsmiCglxbnwkbc";
            this.tsmiCglxbnwkbc.Size = new System.Drawing.Size(364, 22);
            this.tsmiCglxbnwkbc.Text = "采购类型不能为空，请填写后再进行保存。";
            // 
            // tsmiSqbmbnwkbc
            // 
            this.tsmiSqbmbnwkbc.Name = "tsmiSqbmbnwkbc";
            this.tsmiSqbmbnwkbc.Size = new System.Drawing.Size(364, 22);
            this.tsmiSqbmbnwkbc.Text = "申请部门不能为空，请填写后再进行保存。";
            // 
            // tsmiXmhbnwkbc
            // 
            this.tsmiXmhbnwkbc.Name = "tsmiXmhbnwkbc";
            this.tsmiXmhbnwkbc.Size = new System.Drawing.Size(364, 22);
            this.tsmiXmhbnwkbc.Text = "项目号不能为空，请填写后再进行保存。";
            // 
            // tsmiZhbnwkbc
            // 
            this.tsmiZhbnwkbc.Name = "tsmiZhbnwkbc";
            this.tsmiZhbnwkbc.Size = new System.Drawing.Size(364, 22);
            this.tsmiZhbnwkbc.Text = "站号不能为空，请填写后再进行保存。";
            // 
            // tsmiFklxbnwkbc
            // 
            this.tsmiFklxbnwkbc.Name = "tsmiFklxbnwkbc";
            this.tsmiFklxbnwkbc.Size = new System.Drawing.Size(364, 22);
            this.tsmiFklxbnwkbc.Text = "付款类型不能为空，请填写后再进行保存。";
            // 
            // tsmiSrdzhbsyxmh
            // 
            this.tsmiSrdzhbsyxmh.Name = "tsmiSrdzhbsyxmh";
            this.tsmiSrdzhbsyxmh.Size = new System.Drawing.Size(364, 22);
            this.tsmiSrdzhbsyxmh.Text = "输入的站号不属于项目号，请重新填写后再进行保存。";
            // 
            // tsmiQdygddqxzd
            // 
            this.tsmiQdygddqxzd.Name = "tsmiQdygddqxzd";
            this.tsmiQdygddqxzd.Size = new System.Drawing.Size(364, 22);
            this.tsmiQdygddqxzd.Text = "确定要关闭当前选中的";
            // 
            // tsmiQgsyansjcw
            // 
            this.tsmiQgsyansjcw.Name = "tsmiQgsyansjcw";
            this.tsmiQgsyansjcw.Size = new System.Drawing.Size(364, 22);
            this.tsmiQgsyansjcw.Text = "请购适用按钮事件错误。";
            // 
            // tsmiCxmxdsyjqgdcw
            // 
            this.tsmiCxmxdsyjqgdcw.Name = "tsmiCxmxdsyjqgdcw";
            this.tsmiCxmxdsyjqgdcw.Size = new System.Drawing.Size(364, 22);
            this.tsmiCxmxdsyjqgdcw.Text = "查询明细的上一级请购单错误。";
            // 
            // tsmiCxmxdxyjrkdcw
            // 
            this.tsmiCxmxdxyjrkdcw.Name = "tsmiCxmxdxyjrkdcw";
            this.tsmiCxmxdxyjrkdcw.Size = new System.Drawing.Size(364, 22);
            this.tsmiCxmxdxyjrkdcw.Text = "查询明细的下一级入库单错误。";
            // 
            // tsmiCgdd
            // 
            this.tsmiCgdd.Name = "tsmiCgdd";
            this.tsmiCgdd.Size = new System.Drawing.Size(364, 22);
            this.tsmiCgdd.Text = "采购订单";
            // 
            // tsmiQgrqbnwkcx
            // 
            this.tsmiQgrqbnwkcx.Name = "tsmiQgrqbnwkcx";
            this.tsmiQgrqbnwkcx.Size = new System.Drawing.Size(364, 22);
            this.tsmiQgrqbnwkcx.Text = "\"请购日期不能为空，请设置后重新进行查询。";
            // 
            // tsmiCxqgdsjcw
            // 
            this.tsmiCxqgdsjcw.Name = "tsmiCxqgdsjcw";
            this.tsmiCxqgdsjcw.Size = new System.Drawing.Size(364, 22);
            this.tsmiCxqgdsjcw.Text = "查询请购单事件错误。";
            // 
            // tsmiJjcxqgdmxsjcw
            // 
            this.tsmiJjcxqgdmxsjcw.Name = "tsmiJjcxqgdmxsjcw";
            this.tsmiJjcxqgdmxsjcw.Size = new System.Drawing.Size(364, 22);
            this.tsmiJjcxqgdmxsjcw.Text = "聚焦查询请购单明细事件错误。";
            // 
            // tsmiSxtzqgdsjcw
            // 
            this.tsmiSxtzqgdsjcw.Name = "tsmiSxtzqgdsjcw";
            this.tsmiSxtzqgdsjcw.Size = new System.Drawing.Size(364, 22);
            this.tsmiSxtzqgdsjcw.Text = "实现拖拽请购单事件错误。";
            // 
            // tsmiYzcgddzrxxmdxmh
            // 
            this.tsmiYzcgddzrxxmdxmh.Name = "tsmiYzcgddzrxxmdxmh";
            this.tsmiYzcgddzrxxmdxmh.Size = new System.Drawing.Size(364, 22);
            this.tsmiYzcgddzrxxmdxmh.Text = "一张采购订单只允许相同的项目号进行登记。";
            // 
            // FrmOrder_Drag
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1370, 601);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.dockPnlLeft);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmOrder_Drag";
            this.TabText = "采购订单";
            this.Text = "采购订单";
            this.Activated += new System.EventHandler(this.FrmOrder_Activated);
            this.Load += new System.EventHandler(this.FrmOrder_Load);
            this.Shown += new System.EventHandler(this.FrmOrder_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pnltop)).EndInit();
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpApprover.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkPlanDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePlanDateEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePlanDateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePlanDateBegin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePlanDateBegin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpBussinessBaseNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpBussinessBaseNoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCommon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxReqState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPrepared.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPurCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpReqDep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDateEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDateBegin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOrderDateBegin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddle)).EndInit();
            this.pnlMiddle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrderHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_OrderHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableOrderHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableOrderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrderHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpPurCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchBussinessBaseNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchBussinessBaseNoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpReqDep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinTax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchProjectNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchProjectNoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repComboBoxStnNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpApprovalType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpPayTypeNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddleTop)).EndInit();
            this.pnlMiddleTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_OrderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchCodeFileName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchCodeFileNameView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinTax1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repbtnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManagerLeft)).EndInit();
            this.dockPnlLeft.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeftBottle)).EndInit();
            this.pnlLeftBottle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPrReqList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_PrReqList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_PrReq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablePrReqHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablePrReqList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPrReqList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeftMiddle)).EndInit();
            this.pnlLeftMiddle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPrReqHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_PrReqHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPrReqHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchPrReqProjectNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpPrReqReqDep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpPrReqPurCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeftTop)).EndInit();
            this.pnlLeftTop.ResumeLayout(false);
            this.pnlLeftTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpProjectNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpProjectNoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateReqDateEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateReqDateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateReqDateBegin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateReqDateBegin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPrReqNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).EndInit();
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerForm)).EndInit();
            this.cms.ResumeLayout(false);
            this.cms3.ResumeLayout(false);
            this.cms2.ResumeLayout(false);
            this.cms1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnltop;
        private DevExpress.XtraEditors.TextEdit textCommon;
        private DevExpress.XtraEditors.LabelControl labCommon;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxReqState;
        private DevExpress.XtraEditors.LabelControl labPrepared;
        private DevExpress.XtraEditors.LookUpEdit lookUpPrepared;
        private DevExpress.XtraEditors.LabelControl labReqState;
        private DevExpress.XtraEditors.LookUpEdit lookUpPurCategory;
        private DevExpress.XtraEditors.LabelControl labPurCategory;
        private DevExpress.XtraEditors.LookUpEdit lookUpReqDep;
        private DevExpress.XtraEditors.LabelControl labReqDep;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.DateEdit dateOrderDateEnd;
        private DevExpress.XtraEditors.LabelControl lab1;
        private DevExpress.XtraEditors.LabelControl labOrderDate;
        private DevExpress.XtraEditors.DateEdit dateOrderDateBegin;
        private DevExpress.XtraEditors.PanelControl pnlMiddle;
        private DevExpress.XtraEditors.PanelControl pnlBottom;
        private System.Data.DataSet dataSet_Order;
        private System.Data.DataTable dataTableOrderHead;
        private System.Data.DataColumn dataColAutoId;
        private System.Data.DataColumn dataColOrderHeadNo;
        private System.Data.DataTable dataTableOrderList;
        private System.Data.DataColumn dataColumnAutoId;
        private DevExpress.XtraEditors.PanelControl pnlMiddleTop;
        private DevExpress.XtraEditors.SimpleButton btnApprove;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private System.Windows.Forms.BindingSource bindingSource_OrderHead;
        private System.Windows.Forms.BindingSource bindingSource_OrderList;
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
        private DevExpress.XtraEditors.LabelControl labBussinessBaseNo;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpBussinessBaseNo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpBussinessBaseNoView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBussinessBaseNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBussinessBaseText;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBussinessCategoryText;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnAutoId;
        private DevExpress.XtraGrid.GridControl gridControlOrderHead;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewOrderHead;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderHeadNo;
        private DevExpress.XtraGrid.Columns.GridColumn colReqState;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderHeadDate;
        private DevExpress.XtraGrid.Columns.GridColumn colReqDep;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpReqDep;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repSearchProjectNo;
        private DevExpress.XtraGrid.Views.Grid.GridView repSearchProjectNoView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnProjectNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnProjectName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colStnNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repComboBoxStnNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPurCategory;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpPurCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colPrepared;
        private DevExpress.XtraGrid.Columns.GridColumn colPrReqRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colBussinessBaseNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTax;
        private DevExpress.XtraGrid.Columns.GridColumn colPlanDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repSearchBussinessBaseNo;
        private DevExpress.XtraGrid.Views.Grid.GridView repSearchBussinessBaseNoView;
        private DevExpress.XtraGrid.Columns.GridColumn gridCBussinessBaseNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridCBussinessBaseText;
        private DevExpress.XtraGrid.Columns.GridColumn gridCBussinessCategoryText;
        private DevExpress.XtraGrid.Columns.GridColumn gridCAutoId;
        private DevExpress.XtraGrid.GridControl gridControlOrderList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewOrderList;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId1;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderHeadNo1;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeFileName;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repSearchCodeFileName;
        private DevExpress.XtraGrid.Views.Grid.GridView repSearchCodeFileNameView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCodeFileName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCodeName;
        private DevExpress.XtraGrid.Columns.GridColumn colQty;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repSpinQty;
        private DevExpress.XtraGrid.Columns.GridColumn colPlanDate1;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repbtnDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeName;
        private System.Data.DataColumn dataColCodeName;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colTax1;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colSumAmount;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Data.DataColumn dataColClosed;
        private System.Data.DataColumn dataColClosedIp;
        private System.Data.DataColumn dataColClosedTime;
        private System.Data.DataColumn dataColPrReqNo;
        private System.Data.DataColumn dataColSelect;
        private DevExpress.XtraGrid.Columns.GridColumn colSelect;
        private DevExpress.XtraGrid.Columns.GridColumn colClosed;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheckSelect;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colPrReqNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repSpinUnit;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repSpinTax;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repSpinTax1;
        private DevExpress.XtraEditors.SimpleButton btnPrReqApply;
        private DevExpress.XtraEditors.SimpleButton btnCancelApprove;
        private DevExpress.XtraEditors.CheckEdit checkAll;
        private DevExpress.XtraEditors.CheckEdit checkPlanDate;
        private DevExpress.XtraEditors.LabelControl labPlanDate;
        private DevExpress.XtraEditors.LabelControl lab2;
        private DevExpress.XtraEditors.DateEdit datePlanDateEnd;
        private DevExpress.XtraEditors.DateEdit datePlanDateBegin;
        private System.Data.DataColumn dataColApprovalType;
        private System.Data.DataColumn dataColPayTypeNo;
        private DevExpress.XtraGrid.Columns.GridColumn colApprovalType;
        private DevExpress.XtraGrid.Columns.GridColumn colPayTypeNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpApprovalType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpPayTypeNo;
        private DevExpress.XtraEditors.SimpleButton btnCancelClose;
        private DevExpress.XtraEditors.LabelControl labApprover;
        private DevExpress.XtraEditors.LookUpEdit lookUpApprover;
        private DevExpress.XtraEditors.SimpleButton btnPreview;
        private DevExpress.XtraEditors.SimpleButton btnListAdd;
        private System.Data.DataColumn dataColPrListAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colPrListAutoId;
        private DevExpress.XtraBars.Docking.DockManager dockManagerLeft;
        private DevExpress.XtraEditors.PanelControl pnlRight;
        private DevExpress.XtraBars.Docking.DockPanel dockPnlLeft;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.PanelControl pnlLeftTop;
        private DevExpress.XtraEditors.PanelControl pnlLeftBottle;
        private DevExpress.XtraEditors.PanelControl pnlLeftMiddle;
        private DevExpress.XtraEditors.SplitterControl splitterControl2;
        private DevExpress.XtraEditors.SimpleButton btnPrReqQuery;
        private DevExpress.XtraEditors.TextEdit textPrReqNo;
        private DevExpress.XtraEditors.LabelControl labPrReqNo;
        private DevExpress.XtraEditors.DateEdit dateReqDateEnd;
        private DevExpress.XtraEditors.LabelControl labReqDate;
        private DevExpress.XtraEditors.DateEdit dateReqDateBegin;
        private DevExpress.XtraEditors.LabelControl lab;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpProjectNo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpProjectNoView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColProjectNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColProjectName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColRemark;
        private DevExpress.XtraEditors.LabelControl labProjectNo;
        public System.Data.DataSet dataSet_PrReq;
        private System.Data.DataTable dataTablePrReqHead;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColReqDate;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColApplicant;
        private System.Data.DataColumn dataColApplicantIp;
        private System.Data.DataColumn dataColApplicantTime;
        private System.Data.DataColumn dataColumn9;
        private System.Data.DataColumn dataColumn10;
        private System.Data.DataColumn dataColumn11;
        private System.Data.DataColumn dataColumn14;
        private System.Data.DataTable dataTablePrReqList;
        private System.Data.DataColumn dataColumn19;
        private System.Data.DataColumn dataColumnPrReqNo;
        private System.Data.DataColumn dataColumn20;
        private System.Data.DataColumn dataColumn21;
        private System.Data.DataColumn dataColRequirementDate;
        private System.Data.DataColumn dataColPrReqListRemark;
        private System.Data.DataColumn dataColumn22;
        private System.Data.DataColumn dataColOrderCount;
        private System.Data.DataColumn dataColOverplus;
        private System.Windows.Forms.BindingSource bindingSource_PrReqHead;
        private System.Windows.Forms.BindingSource bindingSource_PrReqList;
        private DevExpress.XtraGrid.GridControl gridControlPrReqHead;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewPrReqHead;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn colReqDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpPrReqReqDep;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repSearchPrReqProjectNo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpPrReqPurCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colApplicant;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.GridControl gridControlPrReqList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPrReqList;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn colPrReqNo1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderCount;
        private DevExpress.XtraGrid.Columns.GridColumn colOverplus;
        private DevExpress.XtraGrid.Columns.GridColumn colRequirementDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPrReqListRemark;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.PopupMenu popupMenuList;
        private DevExpress.XtraBars.BarButtonItem barButtonUp;
        private DevExpress.XtraBars.BarButtonItem barButtonDown;
        private DevExpress.XtraBars.BarManager barManagerForm;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem tsmiJhdhribnwk;
        private System.Windows.Forms.ToolStripMenuItem tsmiDgrqbnwk;
        private System.Windows.Forms.ToolStripMenuItem tsmiDqcgdyjxg;
        internal System.Windows.Forms.ContextMenuStrip cms3;
        internal System.Windows.Forms.ToolStripMenuItem tsmiCgjzd;
        internal System.Windows.Forms.ToolStripMenuItem tsmiWsp;
        internal System.Windows.Forms.ToolStripMenuItem tsmiBkycz;
        internal System.Windows.Forms.ToolStripMenuItem tsmiYjsp;
        internal System.Windows.Forms.ToolStripMenuItem tsmiYjjz;
        internal System.Windows.Forms.ToolStripMenuItem tsmiYjspz;
        internal System.Windows.Forms.ToolStripMenuItem tsmiCgjzdz;
        internal System.Windows.Forms.ToolStripMenuItem tsmiDsl;
        internal System.Windows.Forms.ToolStripMenuItem tsmiCgrkdd;
        internal System.Windows.Forms.ToolStripMenuItem tsmiBkybc;
        internal System.Windows.Forms.ToolStripMenuItem tsmiWcxdyc;
        internal System.Windows.Forms.ToolStripMenuItem tsmiCzsjw;
        private System.Windows.Forms.ToolStripMenuItem tsmiCtjzsj;
        private System.Windows.Forms.ToolStripMenuItem tsmiCtjh;
        private System.Windows.Forms.ToolStripMenuItem tsmiJzribn;
        private System.Windows.Forms.ToolStripMenuItem tsmiFkrqbn;
        private System.Windows.Forms.ToolStripMenuItem tsmiCxansj;
        private System.Windows.Forms.ToolStripMenuItem tsmiDqcgjzd;
        private System.Windows.Forms.ToolStripMenuItem tsmiZbjjhg;
        private System.Windows.Forms.ToolStripMenuItem tsmiBc;
        private System.Windows.Forms.ToolStripMenuItem tsmiTjl;
        internal System.Windows.Forms.ContextMenuStrip cms2;
        private System.Windows.Forms.ToolStripMenuItem tsmiZbsd;
        private System.Windows.Forms.ToolStripMenuItem tsmiSczbz;
        private System.Windows.Forms.ToolStripMenuItem tsmiZbdyg;
        private System.Windows.Forms.ToolStripMenuItem tsmiSbczmx;
        private System.Windows.Forms.ToolStripMenuItem tsmiCxmxd;
        private System.Windows.Forms.ToolStripMenuItem tsmiXg;
        private System.Windows.Forms.ToolStripMenuItem tsmiYjspbk;
        private System.Windows.Forms.ToolStripMenuItem tsmiYjjzbky;
        private System.Windows.Forms.ToolStripMenuItem tsmiYjspzbk;
        private System.Windows.Forms.ToolStripMenuItem tsmiWspbk;
        private System.Windows.Forms.ToolStripMenuItem tsmiYjgbbk;
        private System.Windows.Forms.ToolStripMenuItem tsmiRkrqbn;
        private System.Windows.Forms.ToolStripMenuItem tsmiCxrk;
        private System.Windows.Forms.ToolStripMenuItem tsmiJjcxrk;
        private System.Windows.Forms.ToolStripMenuItem tsmiZgrid;
        private System.Windows.Forms.ToolStripMenuItem tsmiSxtzrk;
        private System.Windows.Forms.ToolStripMenuItem tsmiYzcgjz;
        internal System.Windows.Forms.ContextMenuStrip cms1;
        private System.Windows.Forms.ToolStripMenuItem tsmiWlfbnwk;
        private System.Windows.Forms.ToolStripMenuItem tsmiRkbm;
        private System.Windows.Forms.ToolStripMenuItem tsmiSplx;
        private System.Windows.Forms.ToolStripMenuItem tsmiSlbn;
        private System.Windows.Forms.ToolStripMenuItem tsmiFkrq;
        private System.Windows.Forms.ToolStripMenuItem tsmiSlbnwk;
        private System.Windows.Forms.ToolStripMenuItem tsmiDjbnwk;
        private System.Windows.Forms.ToolStripMenuItem tsmiBcan;
        private System.Windows.Forms.ToolStripMenuItem tsmiQxan;
        private System.Windows.Forms.ToolStripMenuItem tsmiQzycz;
        private System.Windows.Forms.ToolStripMenuItem tsmiQdysc;
        private System.Windows.Forms.ToolStripMenuItem tsmiTjlm;
        private System.Windows.Forms.ToolStripMenuItem tsmiScansj;
        private System.Windows.Forms.ToolStripMenuItem tsmiQdyspd;
        private System.Windows.Forms.ToolStripMenuItem tsmiCgspl;
        private System.Windows.Forms.ToolStripMenuItem tsmiSpansj;
        private System.Windows.Forms.ToolStripMenuItem tsmiQdyqx;
        private System.Windows.Forms.ToolStripMenuItem tsmiCgqxsp;
        private System.Windows.Forms.ToolStripMenuItem tsmiQxspan;
        private System.Windows.Forms.ToolStripMenuItem tsmiDyyl;
        private System.Windows.Forms.ToolStripMenuItem tsmiCglxbnwkbc;
        private System.Windows.Forms.ToolStripMenuItem tsmiSqbmbnwkbc;
        private System.Windows.Forms.ToolStripMenuItem tsmiXmhbnwkbc;
        private System.Windows.Forms.ToolStripMenuItem tsmiZhbnwkbc;
        private System.Windows.Forms.ToolStripMenuItem tsmiFklxbnwkbc;
        private System.Windows.Forms.ToolStripMenuItem tsmiSrdzhbsyxmh;
        private System.Windows.Forms.ToolStripMenuItem tsmiQdygddqxzd;
        private System.Windows.Forms.ToolStripMenuItem tsmiQgsyansjcw;
        private System.Windows.Forms.ToolStripMenuItem tsmiCxmxdsyjqgdcw;
        private System.Windows.Forms.ToolStripMenuItem tsmiCxmxdxyjrkdcw;
        private System.Windows.Forms.ToolStripMenuItem tsmiCgdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiQgrqbnwkcx;
        private System.Windows.Forms.ToolStripMenuItem tsmiCxqgdsjcw;
        private System.Windows.Forms.ToolStripMenuItem tsmiJjcxqgdmxsjcw;
        private System.Windows.Forms.ToolStripMenuItem tsmiSxtzqgdsjcw;
        private System.Windows.Forms.ToolStripMenuItem tsmiYzcgddzrxxmdxmh;
    }
}