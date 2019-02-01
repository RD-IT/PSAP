namespace PSAP.VIEW.BSVIEW
{
    partial class FrmInventoryMove_Drag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventoryMove_Drag));
            this.dataSet_IM = new System.Data.DataSet();
            this.dataTableIMHead = new System.Data.DataTable();
            this.dataColAutoId = new System.Data.DataColumn();
            this.dataColInventoryMoveNo = new System.Data.DataColumn();
            this.dataColInventoryMoveDate = new System.Data.DataColumn();
            this.dataColInRepertoryNo = new System.Data.DataColumn();
            this.dataColOutRepertoryNo = new System.Data.DataColumn();
            this.dataColPrepared = new System.Data.DataColumn();
            this.dataColPreparedIp = new System.Data.DataColumn();
            this.dataColumnRemark = new System.Data.DataColumn();
            this.dataColModifier = new System.Data.DataColumn();
            this.dataColModifierIp = new System.Data.DataColumn();
            this.dataColModifierTime = new System.Data.DataColumn();
            this.dataColSelect = new System.Data.DataColumn();
            this.dataColReqDep = new System.Data.DataColumn();
            this.dataTableIMList = new System.Data.DataTable();
            this.dataColumnAutoId = new System.Data.DataColumn();
            this.dataColumnInventoryMoveNo = new System.Data.DataColumn();
            this.dataColCodeFileName = new System.Data.DataColumn();
            this.dataColQty = new System.Data.DataColumn();
            this.dataColInProjectNo = new System.Data.DataColumn();
            this.dataColInShelfNo = new System.Data.DataColumn();
            this.dataColRemark = new System.Data.DataColumn();
            this.dataColOutProjectNo = new System.Data.DataColumn();
            this.dataColOutShelfNo = new System.Data.DataColumn();
            this.dataColumnInventoryMoveDate = new System.Data.DataColumn();
            this.dataColumnInRepertoryNo = new System.Data.DataColumn();
            this.dataColumnOutRepertoryNo = new System.Data.DataColumn();
            this.dataColCodeName = new System.Data.DataColumn();
            this.dataColInProjectName = new System.Data.DataColumn();
            this.dataColOutProjectName = new System.Data.DataColumn();
            this.bindingSource_IMHead = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource_IMList = new System.Windows.Forms.BindingSource(this.components);
            this.dockManagerLeft = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPnlLeft = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.pnlLeftMiddle = new DevExpress.XtraEditors.PanelControl();
            this.gridControlWNowInfo = new DevExpress.XtraGrid.GridControl();
            this.bindingSource_WNowInfo = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_WNowInfo = new System.Data.DataSet();
            this.TableWNowInfo = new System.Data.DataTable();
            this.dataAutoId = new System.Data.DataColumn();
            this.dataCodeFileName = new System.Data.DataColumn();
            this.dataCodeName = new System.Data.DataColumn();
            this.dataProjectNo = new System.Data.DataColumn();
            this.dataProjectName = new System.Data.DataColumn();
            this.dataRepertoryNo = new System.Data.DataColumn();
            this.dataShelfNo = new System.Data.DataColumn();
            this.dataQty = new System.Data.DataColumn();
            this.gridViewWNowInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRepertoryNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpRepertoryNo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colShelfNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjectNo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlLeftTop = new DevExpress.XtraEditors.PanelControl();
            this.checkZero = new DevExpress.XtraEditors.CheckEdit();
            this.lookUpRepertoryNo = new DevExpress.XtraEditors.LookUpEdit();
            this.searchLookUpCodeFileName = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpCodeFileNameView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labCodeFileName = new DevExpress.XtraEditors.LabelControl();
            this.searchLookUpProjectNo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpProjectNoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColProjectNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColProjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnWNowInfoQuery = new DevExpress.XtraEditors.SimpleButton();
            this.labProjectNo = new DevExpress.XtraEditors.LabelControl();
            this.labPrReqNo = new DevExpress.XtraEditors.LabelControl();
            this.pnlRight = new DevExpress.XtraEditors.PanelControl();
            this.pnlBottom = new DevExpress.XtraEditors.PanelControl();
            this.btnListAdd = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlIMList = new DevExpress.XtraGrid.GridControl();
            this.gridViewIMList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnInventoryMoveNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodeFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSearchCodeFileName = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repSearchCodeFileNameView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCodeFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCodeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSpinQty = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repbtnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colOutProjectNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSearchOutProjectNo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repSearchOutProjectNoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOutShelfNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSearchOutShelfNo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repSearchOutShelfNoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInProjectNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInShelfNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInventoryMoveDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOutRepertoryNo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInRepertoryNo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOutProjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInProjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.pnlMiddle = new DevExpress.XtraEditors.PanelControl();
            this.checkAll = new DevExpress.XtraEditors.CheckEdit();
            this.gridControlIMHead = new DevExpress.XtraGrid.GridControl();
            this.gridViewIMHead = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelect = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCheckSelect = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colInventoryMoveNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderHeadDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInRepertoryNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpInRepertoryNo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colOutRepertoryNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReqDep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpReqDep = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colPRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrepared = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlMiddleTop = new DevExpress.XtraEditors.PanelControl();
            this.btnPreview = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.pnltop = new DevExpress.XtraEditors.PanelControl();
            this.lookUpOutRpertoryNo = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpReqDep = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpInRepertoryNo = new DevExpress.XtraEditors.LookUpEdit();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.textCommon = new DevExpress.XtraEditors.TextEdit();
            this.lookUpPrepared = new DevExpress.XtraEditors.LookUpEdit();
            this.dateIMDateEnd = new DevExpress.XtraEditors.DateEdit();
            this.lab1 = new DevExpress.XtraEditors.LabelControl();
            this.dateIMDateBegin = new DevExpress.XtraEditors.DateEdit();
            this.labReqDep = new DevExpress.XtraEditors.LabelControl();
            this.labOutRepertoryNo = new DevExpress.XtraEditors.LabelControl();
            this.labInRepertoryNo = new DevExpress.XtraEditors.LabelControl();
            this.labCommon = new DevExpress.XtraEditors.LabelControl();
            this.labPrepared = new DevExpress.XtraEditors.LabelControl();
            this.labIMDate = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_IM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableIMHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableIMList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_IMHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_IMList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManagerLeft)).BeginInit();
            this.dockPnlLeft.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeftMiddle)).BeginInit();
            this.pnlLeftMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlWNowInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_WNowInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_WNowInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableWNowInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWNowInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpRepertoryNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeftTop)).BeginInit();
            this.pnlLeftTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkZero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpRepertoryNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpCodeFileName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpCodeFileNameView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpProjectNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpProjectNoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).BeginInit();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).BeginInit();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlIMList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewIMList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchCodeFileName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchCodeFileNameView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repbtnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchOutProjectNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchOutProjectNoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchOutShelfNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchOutShelfNoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddle)).BeginInit();
            this.pnlMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlIMHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewIMHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpInRepertoryNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpReqDep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddleTop)).BeginInit();
            this.pnlMiddleTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnltop)).BeginInit();
            this.pnltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpOutRpertoryNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpReqDep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpInRepertoryNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCommon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPrepared.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateIMDateEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateIMDateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateIMDateBegin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateIMDateBegin.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet_IM
            // 
            this.dataSet_IM.DataSetName = "NewDataSet";
            this.dataSet_IM.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTableIMHead,
            this.dataTableIMList});
            // 
            // dataTableIMHead
            // 
            this.dataTableIMHead.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColAutoId,
            this.dataColInventoryMoveNo,
            this.dataColInventoryMoveDate,
            this.dataColInRepertoryNo,
            this.dataColOutRepertoryNo,
            this.dataColPrepared,
            this.dataColPreparedIp,
            this.dataColumnRemark,
            this.dataColModifier,
            this.dataColModifierIp,
            this.dataColModifierTime,
            this.dataColSelect,
            this.dataColReqDep});
            this.dataTableIMHead.TableName = "IMHead";
            // 
            // dataColAutoId
            // 
            this.dataColAutoId.ColumnName = "AutoId";
            this.dataColAutoId.DataType = typeof(int);
            // 
            // dataColInventoryMoveNo
            // 
            this.dataColInventoryMoveNo.Caption = "移动单号";
            this.dataColInventoryMoveNo.ColumnName = "InventoryMoveNo";
            // 
            // dataColInventoryMoveDate
            // 
            this.dataColInventoryMoveDate.Caption = "移动日期";
            this.dataColInventoryMoveDate.ColumnName = "InventoryMoveDate";
            this.dataColInventoryMoveDate.DataType = typeof(System.DateTime);
            // 
            // dataColInRepertoryNo
            // 
            this.dataColInRepertoryNo.Caption = "入库仓库";
            this.dataColInRepertoryNo.ColumnName = "InRepertoryNo";
            // 
            // dataColOutRepertoryNo
            // 
            this.dataColOutRepertoryNo.Caption = "出库仓库";
            this.dataColOutRepertoryNo.ColumnName = "OutRepertoryNo";
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
            // dataColumnRemark
            // 
            this.dataColumnRemark.Caption = "备注";
            this.dataColumnRemark.ColumnName = "Remark";
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
            // dataColSelect
            // 
            this.dataColSelect.Caption = "";
            this.dataColSelect.ColumnName = "Select";
            this.dataColSelect.DataType = typeof(bool);
            // 
            // dataColReqDep
            // 
            this.dataColReqDep.Caption = "部门";
            this.dataColReqDep.ColumnName = "ReqDep";
            // 
            // dataTableIMList
            // 
            this.dataTableIMList.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumnAutoId,
            this.dataColumnInventoryMoveNo,
            this.dataColCodeFileName,
            this.dataColQty,
            this.dataColInProjectNo,
            this.dataColInShelfNo,
            this.dataColRemark,
            this.dataColOutProjectNo,
            this.dataColOutShelfNo,
            this.dataColumnInventoryMoveDate,
            this.dataColumnInRepertoryNo,
            this.dataColumnOutRepertoryNo,
            this.dataColCodeName,
            this.dataColInProjectName,
            this.dataColOutProjectName});
            this.dataTableIMList.TableName = "IMList";
            // 
            // dataColumnAutoId
            // 
            this.dataColumnAutoId.ColumnName = "AutoId";
            this.dataColumnAutoId.DataType = typeof(int);
            // 
            // dataColumnInventoryMoveNo
            // 
            this.dataColumnInventoryMoveNo.Caption = "移动单号";
            this.dataColumnInventoryMoveNo.ColumnName = "InventoryMoveNo";
            // 
            // dataColCodeFileName
            // 
            this.dataColCodeFileName.Caption = "零件编号";
            this.dataColCodeFileName.ColumnName = "CodeFileName";
            // 
            // dataColQty
            // 
            this.dataColQty.Caption = "移动数量";
            this.dataColQty.ColumnName = "Qty";
            this.dataColQty.DataType = typeof(double);
            // 
            // dataColInProjectNo
            // 
            this.dataColInProjectNo.Caption = "入库项目号";
            this.dataColInProjectNo.ColumnName = "InProjectNo";
            // 
            // dataColInShelfNo
            // 
            this.dataColInShelfNo.Caption = "入库货架号";
            this.dataColInShelfNo.ColumnName = "InShelfNo";
            // 
            // dataColRemark
            // 
            this.dataColRemark.Caption = "备注";
            this.dataColRemark.ColumnName = "Remark";
            // 
            // dataColOutProjectNo
            // 
            this.dataColOutProjectNo.Caption = "出库项目号";
            this.dataColOutProjectNo.ColumnName = "OutProjectNo";
            // 
            // dataColOutShelfNo
            // 
            this.dataColOutShelfNo.Caption = "出库货架号";
            this.dataColOutShelfNo.ColumnName = "OutShelfNo";
            // 
            // dataColumnInventoryMoveDate
            // 
            this.dataColumnInventoryMoveDate.Caption = "移动日期";
            this.dataColumnInventoryMoveDate.ColumnName = "InventoryMoveDate";
            this.dataColumnInventoryMoveDate.DataType = typeof(System.DateTime);
            // 
            // dataColumnInRepertoryNo
            // 
            this.dataColumnInRepertoryNo.Caption = "入库仓库";
            this.dataColumnInRepertoryNo.ColumnName = "InRepertoryNo";
            // 
            // dataColumnOutRepertoryNo
            // 
            this.dataColumnOutRepertoryNo.Caption = "出库仓库";
            this.dataColumnOutRepertoryNo.ColumnName = "OutRepertoryNo";
            // 
            // dataColCodeName
            // 
            this.dataColCodeName.Caption = "零件名称";
            this.dataColCodeName.ColumnName = "CodeName";
            // 
            // dataColInProjectName
            // 
            this.dataColInProjectName.Caption = "入库项目名称";
            this.dataColInProjectName.ColumnName = "InProjectName";
            // 
            // dataColOutProjectName
            // 
            this.dataColOutProjectName.Caption = "出库项目名称";
            this.dataColOutProjectName.ColumnName = "OutProjectName";
            // 
            // bindingSource_IMHead
            // 
            this.bindingSource_IMHead.DataMember = "IMHead";
            this.bindingSource_IMHead.DataSource = this.dataSet_IM;
            // 
            // bindingSource_IMList
            // 
            this.bindingSource_IMList.DataMember = "IMList";
            this.bindingSource_IMList.DataSource = this.dataSet_IM;
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
            this.dockPnlLeft.ID = new System.Guid("b4bf55cd-2af8-430c-bdda-dcc8c365bf19");
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
            this.dockPnlLeft.Size = new System.Drawing.Size(350, 681);
            this.dockPnlLeft.Text = "当前库存";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.pnlLeftMiddle);
            this.dockPanel1_Container.Controls.Add(this.pnlLeftTop);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(342, 654);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // pnlLeftMiddle
            // 
            this.pnlLeftMiddle.Controls.Add(this.gridControlWNowInfo);
            this.pnlLeftMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeftMiddle.Location = new System.Drawing.Point(0, 93);
            this.pnlLeftMiddle.Name = "pnlLeftMiddle";
            this.pnlLeftMiddle.Size = new System.Drawing.Size(342, 561);
            this.pnlLeftMiddle.TabIndex = 2;
            // 
            // gridControlWNowInfo
            // 
            this.gridControlWNowInfo.AllowDrop = true;
            this.gridControlWNowInfo.DataSource = this.bindingSource_WNowInfo;
            this.gridControlWNowInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlWNowInfo.Location = new System.Drawing.Point(2, 2);
            this.gridControlWNowInfo.MainView = this.gridViewWNowInfo;
            this.gridControlWNowInfo.Name = "gridControlWNowInfo";
            this.gridControlWNowInfo.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repLookUpRepertoryNo});
            this.gridControlWNowInfo.Size = new System.Drawing.Size(338, 557);
            this.gridControlWNowInfo.TabIndex = 4;
            this.gridControlWNowInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewWNowInfo});
            // 
            // bindingSource_WNowInfo
            // 
            this.bindingSource_WNowInfo.DataMember = "WNowInfo";
            this.bindingSource_WNowInfo.DataSource = this.dataSet_WNowInfo;
            // 
            // dataSet_WNowInfo
            // 
            this.dataSet_WNowInfo.DataSetName = "NewDataSet";
            this.dataSet_WNowInfo.Tables.AddRange(new System.Data.DataTable[] {
            this.TableWNowInfo});
            // 
            // TableWNowInfo
            // 
            this.TableWNowInfo.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataAutoId,
            this.dataCodeFileName,
            this.dataCodeName,
            this.dataProjectNo,
            this.dataProjectName,
            this.dataRepertoryNo,
            this.dataShelfNo,
            this.dataQty});
            this.TableWNowInfo.TableName = "WNowInfo";
            // 
            // dataAutoId
            // 
            this.dataAutoId.ColumnName = "AutoId";
            this.dataAutoId.DataType = typeof(int);
            // 
            // dataCodeFileName
            // 
            this.dataCodeFileName.Caption = "零件编号";
            this.dataCodeFileName.ColumnName = "CodeFileName";
            // 
            // dataCodeName
            // 
            this.dataCodeName.Caption = "零件名称";
            this.dataCodeName.ColumnName = "CodeName";
            // 
            // dataProjectNo
            // 
            this.dataProjectNo.Caption = "项目号";
            this.dataProjectNo.ColumnName = "ProjectNo";
            // 
            // dataProjectName
            // 
            this.dataProjectName.Caption = "项目号";
            this.dataProjectName.ColumnName = "ProjectName";
            // 
            // dataRepertoryNo
            // 
            this.dataRepertoryNo.Caption = "仓库";
            this.dataRepertoryNo.ColumnName = "RepertoryNo";
            // 
            // dataShelfNo
            // 
            this.dataShelfNo.Caption = "货架号";
            this.dataShelfNo.ColumnName = "ShelfNo";
            // 
            // dataQty
            // 
            this.dataQty.Caption = "数量";
            this.dataQty.ColumnName = "Qty";
            this.dataQty.DataType = typeof(double);
            // 
            // gridViewWNowInfo
            // 
            this.gridViewWNowInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn18,
            this.gridColumn19,
            this.colProjectName,
            this.colRepertoryNo,
            this.colShelfNo,
            this.colProjectNo1});
            this.gridViewWNowInfo.GridControl = this.gridControlWNowInfo;
            this.gridViewWNowInfo.IndicatorWidth = 40;
            this.gridViewWNowInfo.Name = "gridViewWNowInfo";
            this.gridViewWNowInfo.OptionsBehavior.Editable = false;
            this.gridViewWNowInfo.OptionsBehavior.ReadOnly = true;
            this.gridViewWNowInfo.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewWNowInfo.OptionsSelection.MultiSelect = true;
            this.gridViewWNowInfo.OptionsView.ColumnAutoWidth = false;
            this.gridViewWNowInfo.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewWNowInfo.OptionsView.ShowGroupPanel = false;
            this.gridViewWNowInfo.OptionsView.ShowIndicator = false;
            this.gridViewWNowInfo.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewIMHead_CustomDrawRowIndicator);
            this.gridViewWNowInfo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridViewWNowInfo_MouseDown);
            this.gridViewWNowInfo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gridViewWNowInfo_MouseMove);
            // 
            // gridColumn13
            // 
            this.gridColumn13.FieldName = "AutoId";
            this.gridColumn13.Name = "gridColumn13";
            // 
            // gridColumn14
            // 
            this.gridColumn14.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn14.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn14.FieldName = "CodeFileName";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.OptionsColumn.AllowEdit = false;
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 2;
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
            this.gridColumn18.VisibleIndex = 5;
            this.gridColumn18.Width = 110;
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
            this.gridColumn19.VisibleIndex = 3;
            this.gridColumn19.Width = 60;
            // 
            // colProjectName
            // 
            this.colProjectName.AppearanceHeader.Options.UseTextOptions = true;
            this.colProjectName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProjectName.FieldName = "ProjectName";
            this.colProjectName.Name = "colProjectName";
            this.colProjectName.OptionsColumn.AllowEdit = false;
            this.colProjectName.Visible = true;
            this.colProjectName.VisibleIndex = 1;
            this.colProjectName.Width = 80;
            // 
            // colRepertoryNo
            // 
            this.colRepertoryNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colRepertoryNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRepertoryNo.ColumnEdit = this.repLookUpRepertoryNo;
            this.colRepertoryNo.FieldName = "RepertoryNo";
            this.colRepertoryNo.Name = "colRepertoryNo";
            this.colRepertoryNo.OptionsColumn.AllowEdit = false;
            this.colRepertoryNo.Visible = true;
            this.colRepertoryNo.VisibleIndex = 0;
            this.colRepertoryNo.Width = 80;
            // 
            // repLookUpRepertoryNo
            // 
            this.repLookUpRepertoryNo.AutoHeight = false;
            this.repLookUpRepertoryNo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpRepertoryNo.DisplayMember = "RepertoryName";
            this.repLookUpRepertoryNo.Name = "repLookUpRepertoryNo";
            this.repLookUpRepertoryNo.NullText = "";
            this.repLookUpRepertoryNo.ValueMember = "RepertoryNo";
            // 
            // colShelfNo
            // 
            this.colShelfNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colShelfNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colShelfNo.FieldName = "ShelfNo";
            this.colShelfNo.Name = "colShelfNo";
            this.colShelfNo.OptionsColumn.AllowEdit = false;
            this.colShelfNo.Visible = true;
            this.colShelfNo.VisibleIndex = 4;
            this.colShelfNo.Width = 80;
            // 
            // colProjectNo1
            // 
            this.colProjectNo1.FieldName = "ProjectNo";
            this.colProjectNo1.Name = "colProjectNo1";
            // 
            // pnlLeftTop
            // 
            this.pnlLeftTop.Controls.Add(this.checkZero);
            this.pnlLeftTop.Controls.Add(this.lookUpRepertoryNo);
            this.pnlLeftTop.Controls.Add(this.searchLookUpCodeFileName);
            this.pnlLeftTop.Controls.Add(this.labCodeFileName);
            this.pnlLeftTop.Controls.Add(this.searchLookUpProjectNo);
            this.pnlLeftTop.Controls.Add(this.btnWNowInfoQuery);
            this.pnlLeftTop.Controls.Add(this.labProjectNo);
            this.pnlLeftTop.Controls.Add(this.labPrReqNo);
            this.pnlLeftTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeftTop.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftTop.Name = "pnlLeftTop";
            this.pnlLeftTop.Size = new System.Drawing.Size(342, 93);
            this.pnlLeftTop.TabIndex = 1;
            // 
            // checkZero
            // 
            this.checkZero.EditValue = true;
            this.checkZero.Location = new System.Drawing.Point(215, 8);
            this.checkZero.Name = "checkZero";
            this.checkZero.Properties.Caption = "库存数大于0";
            this.checkZero.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.checkZero.Properties.ValueGrayed = false;
            this.checkZero.Size = new System.Drawing.Size(111, 19);
            this.checkZero.TabIndex = 208;
            // 
            // lookUpRepertoryNo
            // 
            this.lookUpRepertoryNo.EnterMoveNextControl = true;
            this.lookUpRepertoryNo.Location = new System.Drawing.Point(75, 8);
            this.lookUpRepertoryNo.Margin = new System.Windows.Forms.Padding(4);
            this.lookUpRepertoryNo.Name = "lookUpRepertoryNo";
            this.lookUpRepertoryNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpRepertoryNo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AutoId", "AutoId", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RepertoryNo", "仓库编号"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RepertoryName", "仓库名称"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RepertoryTypeText", "仓库类型")});
            this.lookUpRepertoryNo.Properties.DisplayMember = "RepertoryName";
            this.lookUpRepertoryNo.Properties.NullText = "";
            this.lookUpRepertoryNo.Properties.ValueMember = "RepertoryNo";
            this.lookUpRepertoryNo.Size = new System.Drawing.Size(120, 20);
            this.lookUpRepertoryNo.TabIndex = 201;
            // 
            // searchLookUpCodeFileName
            // 
            this.searchLookUpCodeFileName.EnterMoveNextControl = true;
            this.searchLookUpCodeFileName.Location = new System.Drawing.Point(75, 65);
            this.searchLookUpCodeFileName.Name = "searchLookUpCodeFileName";
            this.searchLookUpCodeFileName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpCodeFileName.Properties.DisplayMember = "CodeName";
            this.searchLookUpCodeFileName.Properties.NullText = "";
            this.searchLookUpCodeFileName.Properties.ValueMember = "CodeFileName";
            this.searchLookUpCodeFileName.Properties.View = this.searchLookUpCodeFileNameView;
            this.searchLookUpCodeFileName.Size = new System.Drawing.Size(150, 20);
            this.searchLookUpCodeFileName.TabIndex = 203;
            // 
            // searchLookUpCodeFileNameView
            // 
            this.searchLookUpCodeFileNameView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn3});
            this.searchLookUpCodeFileNameView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpCodeFileNameView.IndicatorWidth = 60;
            this.searchLookUpCodeFileNameView.Name = "searchLookUpCodeFileNameView";
            this.searchLookUpCodeFileNameView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpCodeFileNameView.OptionsView.ShowGroupPanel = false;
            this.searchLookUpCodeFileNameView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.repSearchCodeFileNameView_CustomDrawRowIndicator);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "零件编号";
            this.gridColumn1.FieldName = "CodeFileName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "零件名称";
            this.gridColumn3.FieldName = "CodeName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // labCodeFileName
            // 
            this.labCodeFileName.Location = new System.Drawing.Point(9, 68);
            this.labCodeFileName.Name = "labCodeFileName";
            this.labCodeFileName.Size = new System.Drawing.Size(60, 14);
            this.labCodeFileName.TabIndex = 207;
            this.labCodeFileName.Text = "物料名称：";
            // 
            // searchLookUpProjectNo
            // 
            this.searchLookUpProjectNo.EnterMoveNextControl = true;
            this.searchLookUpProjectNo.Location = new System.Drawing.Point(75, 37);
            this.searchLookUpProjectNo.Name = "searchLookUpProjectNo";
            this.searchLookUpProjectNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpProjectNo.Properties.DisplayMember = "ProjectName";
            this.searchLookUpProjectNo.Properties.NullText = "";
            this.searchLookUpProjectNo.Properties.ValueMember = "ProjectNo";
            this.searchLookUpProjectNo.Properties.View = this.searchLookUpProjectNoView;
            this.searchLookUpProjectNo.Size = new System.Drawing.Size(120, 20);
            this.searchLookUpProjectNo.TabIndex = 202;
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
            this.searchLookUpProjectNoView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.repSearchCodeFileNameView_CustomDrawRowIndicator);
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
            // btnWNowInfoQuery
            // 
            this.btnWNowInfoQuery.Location = new System.Drawing.Point(231, 64);
            this.btnWNowInfoQuery.Name = "btnWNowInfoQuery";
            this.btnWNowInfoQuery.Size = new System.Drawing.Size(75, 23);
            this.btnWNowInfoQuery.TabIndex = 204;
            this.btnWNowInfoQuery.Text = "查询";
            this.btnWNowInfoQuery.Click += new System.EventHandler(this.btnWNowInfoQuery_Click);
            // 
            // labProjectNo
            // 
            this.labProjectNo.Location = new System.Drawing.Point(9, 40);
            this.labProjectNo.Name = "labProjectNo";
            this.labProjectNo.Size = new System.Drawing.Size(48, 14);
            this.labProjectNo.TabIndex = 114;
            this.labProjectNo.Text = "项目号：";
            // 
            // labPrReqNo
            // 
            this.labPrReqNo.Location = new System.Drawing.Point(9, 11);
            this.labPrReqNo.Name = "labPrReqNo";
            this.labPrReqNo.Size = new System.Drawing.Size(36, 14);
            this.labPrReqNo.TabIndex = 108;
            this.labPrReqNo.Text = "仓库：";
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
            this.pnlRight.Size = new System.Drawing.Size(1054, 681);
            this.pnlRight.TabIndex = 2;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnListAdd);
            this.pnlBottom.Controls.Add(this.gridControlIMList);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(2, 271);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1050, 408);
            this.pnlBottom.TabIndex = 7;
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
            // gridControlIMList
            // 
            this.gridControlIMList.AllowDrop = true;
            this.gridControlIMList.DataSource = this.bindingSource_IMList;
            this.gridControlIMList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlIMList.Location = new System.Drawing.Point(2, 2);
            this.gridControlIMList.MainView = this.gridViewIMList;
            this.gridControlIMList.Name = "gridControlIMList";
            this.gridControlIMList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repSpinQty,
            this.repSearchCodeFileName,
            this.repbtnDelete,
            this.repSearchOutProjectNo,
            this.repSearchOutShelfNo});
            this.gridControlIMList.Size = new System.Drawing.Size(1046, 404);
            this.gridControlIMList.TabIndex = 2;
            this.gridControlIMList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewIMList});
            this.gridControlIMList.DragDrop += new System.Windows.Forms.DragEventHandler(this.gridControlIMList_DragDrop);
            this.gridControlIMList.DragEnter += new System.Windows.Forms.DragEventHandler(this.gridControlIMList_DragEnter);
            this.gridControlIMList.DragOver += new System.Windows.Forms.DragEventHandler(this.gridControlIMList_DragOver);
            // 
            // gridViewIMList
            // 
            this.gridViewIMList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId1,
            this.columnInventoryMoveNo,
            this.colCodeFileName,
            this.colCodeName,
            this.colQty,
            this.colRemark,
            this.colDelete,
            this.colOutProjectNo,
            this.colOutShelfNo,
            this.colInProjectNo,
            this.colInShelfNo,
            this.colInventoryMoveDate,
            this.colOutRepertoryNo1,
            this.colInRepertoryNo1,
            this.colOutProjectName,
            this.colInProjectName});
            this.gridViewIMList.GridControl = this.gridControlIMList;
            this.gridViewIMList.IndicatorWidth = 40;
            this.gridViewIMList.Name = "gridViewIMList";
            this.gridViewIMList.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewIMList.OptionsMenu.EnableColumnMenu = false;
            this.gridViewIMList.OptionsMenu.EnableFooterMenu = false;
            this.gridViewIMList.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewIMList.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewIMList.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewIMList.OptionsView.ColumnAutoWidth = false;
            this.gridViewIMList.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewIMList.OptionsView.ShowFooter = true;
            this.gridViewIMList.OptionsView.ShowGroupPanel = false;
            this.gridViewIMList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewIMHead_CustomDrawRowIndicator);
            this.gridViewIMList.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridViewIMList_InitNewRow);
            this.gridViewIMList.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewIMList_CellValueChanged);
            this.gridViewIMList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewIMList_KeyDown);
            // 
            // colAutoId1
            // 
            this.colAutoId1.FieldName = "AutoId";
            this.colAutoId1.Name = "colAutoId1";
            // 
            // columnInventoryMoveNo
            // 
            this.columnInventoryMoveNo.AppearanceHeader.Options.UseTextOptions = true;
            this.columnInventoryMoveNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.columnInventoryMoveNo.FieldName = "InventoryMoveNo";
            this.columnInventoryMoveNo.Name = "columnInventoryMoveNo";
            this.columnInventoryMoveNo.OptionsColumn.AllowEdit = false;
            this.columnInventoryMoveNo.OptionsColumn.AllowFocus = false;
            this.columnInventoryMoveNo.OptionsColumn.ReadOnly = true;
            this.columnInventoryMoveNo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "PrReqNo", "共计{0}条")});
            this.columnInventoryMoveNo.Visible = true;
            this.columnInventoryMoveNo.VisibleIndex = 0;
            this.columnInventoryMoveNo.Width = 110;
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
            this.gridColumn2,
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
            // gridColumn2
            // 
            this.gridColumn2.Caption = "AutoId";
            this.gridColumn2.Name = "gridColumn2";
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
            this.colQty.VisibleIndex = 3;
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
            // colRemark
            // 
            this.colRemark.AppearanceHeader.Options.UseTextOptions = true;
            this.colRemark.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.OptionsColumn.AllowEdit = false;
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 8;
            this.colRemark.Width = 140;
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
            this.repbtnDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repbtnDelete_ButtonClick);
            // 
            // colOutProjectNo
            // 
            this.colOutProjectNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colOutProjectNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOutProjectNo.ColumnEdit = this.repSearchOutProjectNo;
            this.colOutProjectNo.FieldName = "OutProjectNo";
            this.colOutProjectNo.Name = "colOutProjectNo";
            this.colOutProjectNo.OptionsColumn.AllowEdit = false;
            this.colOutProjectNo.Visible = true;
            this.colOutProjectNo.VisibleIndex = 4;
            this.colOutProjectNo.Width = 100;
            // 
            // repSearchOutProjectNo
            // 
            this.repSearchOutProjectNo.AutoHeight = false;
            this.repSearchOutProjectNo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repSearchOutProjectNo.DisplayMember = "ProjectName";
            this.repSearchOutProjectNo.Name = "repSearchOutProjectNo";
            this.repSearchOutProjectNo.NullText = "";
            this.repSearchOutProjectNo.ValueMember = "ProjectNo";
            this.repSearchOutProjectNo.View = this.repSearchOutProjectNoView;
            // 
            // repSearchOutProjectNoView
            // 
            this.repSearchOutProjectNoView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.repSearchOutProjectNoView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repSearchOutProjectNoView.IndicatorWidth = 60;
            this.repSearchOutProjectNoView.Name = "repSearchOutProjectNoView";
            this.repSearchOutProjectNoView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repSearchOutProjectNoView.OptionsView.ShowGroupPanel = false;
            this.repSearchOutProjectNoView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.repSearchCodeFileNameView_CustomDrawRowIndicator);
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "项目号";
            this.gridColumn4.FieldName = "ProjectNo";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "项目名称";
            this.gridColumn5.FieldName = "ProjectName";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "备注";
            this.gridColumn6.FieldName = "Remark";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            // 
            // colOutShelfNo
            // 
            this.colOutShelfNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colOutShelfNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOutShelfNo.ColumnEdit = this.repSearchOutShelfNo;
            this.colOutShelfNo.FieldName = "OutShelfNo";
            this.colOutShelfNo.Name = "colOutShelfNo";
            this.colOutShelfNo.OptionsColumn.AllowEdit = false;
            this.colOutShelfNo.Visible = true;
            this.colOutShelfNo.VisibleIndex = 5;
            this.colOutShelfNo.Width = 100;
            // 
            // repSearchOutShelfNo
            // 
            this.repSearchOutShelfNo.AutoHeight = false;
            this.repSearchOutShelfNo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repSearchOutShelfNo.DisplayMember = "ShelfNo";
            this.repSearchOutShelfNo.Name = "repSearchOutShelfNo";
            this.repSearchOutShelfNo.NullText = "";
            this.repSearchOutShelfNo.ValueMember = "ShelfNo";
            this.repSearchOutShelfNo.View = this.repSearchOutShelfNoView;
            // 
            // repSearchOutShelfNoView
            // 
            this.repSearchOutShelfNoView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9});
            this.repSearchOutShelfNoView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repSearchOutShelfNoView.IndicatorWidth = 60;
            this.repSearchOutShelfNoView.Name = "repSearchOutShelfNoView";
            this.repSearchOutShelfNoView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repSearchOutShelfNoView.OptionsView.ShowGroupPanel = false;
            this.repSearchOutShelfNoView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.repSearchCodeFileNameView_CustomDrawRowIndicator);
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "货架号";
            this.gridColumn7.FieldName = "ShelfNo";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "货架位置";
            this.gridColumn8.FieldName = "ShelfLocation";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 1;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "AutoId";
            this.gridColumn9.FieldName = "AutoId";
            this.gridColumn9.Name = "gridColumn9";
            // 
            // colInProjectNo
            // 
            this.colInProjectNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colInProjectNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInProjectNo.ColumnEdit = this.repSearchOutProjectNo;
            this.colInProjectNo.FieldName = "InProjectNo";
            this.colInProjectNo.Name = "colInProjectNo";
            this.colInProjectNo.OptionsColumn.AllowEdit = false;
            this.colInProjectNo.Visible = true;
            this.colInProjectNo.VisibleIndex = 6;
            this.colInProjectNo.Width = 100;
            // 
            // colInShelfNo
            // 
            this.colInShelfNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colInShelfNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInShelfNo.ColumnEdit = this.repSearchOutShelfNo;
            this.colInShelfNo.FieldName = "InShelfNo";
            this.colInShelfNo.Name = "colInShelfNo";
            this.colInShelfNo.OptionsColumn.AllowEdit = false;
            this.colInShelfNo.Visible = true;
            this.colInShelfNo.VisibleIndex = 7;
            this.colInShelfNo.Width = 100;
            // 
            // colInventoryMoveDate
            // 
            this.colInventoryMoveDate.FieldName = "InventoryMoveDate";
            this.colInventoryMoveDate.Name = "colInventoryMoveDate";
            // 
            // colOutRepertoryNo1
            // 
            this.colOutRepertoryNo1.FieldName = "OutRepertoryNo";
            this.colOutRepertoryNo1.Name = "colOutRepertoryNo1";
            // 
            // colInRepertoryNo1
            // 
            this.colInRepertoryNo1.FieldName = "InRepertoryNo";
            this.colInRepertoryNo1.Name = "colInRepertoryNo1";
            // 
            // colOutProjectName
            // 
            this.colOutProjectName.FieldName = "OutProjectName";
            this.colOutProjectName.Name = "colOutProjectName";
            // 
            // colInProjectName
            // 
            this.colInProjectName.FieldName = "InProjectName";
            this.colInProjectName.Name = "colInProjectName";
            // 
            // splitterControl1
            // 
            this.splitterControl1.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterControl1.Location = new System.Drawing.Point(2, 266);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(1050, 5);
            this.splitterControl1.TabIndex = 6;
            this.splitterControl1.TabStop = false;
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.Controls.Add(this.checkAll);
            this.pnlMiddle.Controls.Add(this.gridControlIMHead);
            this.pnlMiddle.Controls.Add(this.pnlMiddleTop);
            this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMiddle.Location = new System.Drawing.Point(2, 80);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(1050, 186);
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
            this.checkAll.TabIndex = 18;
            this.checkAll.TabStop = false;
            this.checkAll.CheckedChanged += new System.EventHandler(this.checkAll_CheckedChanged);
            // 
            // gridControlIMHead
            // 
            this.gridControlIMHead.DataSource = this.bindingSource_IMHead;
            this.gridControlIMHead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlIMHead.Location = new System.Drawing.Point(2, 36);
            this.gridControlIMHead.MainView = this.gridViewIMHead;
            this.gridControlIMHead.Name = "gridControlIMHead";
            this.gridControlIMHead.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repLookUpReqDep,
            this.repCheckSelect,
            this.repLookUpInRepertoryNo});
            this.gridControlIMHead.Size = new System.Drawing.Size(1046, 148);
            this.gridControlIMHead.TabIndex = 3;
            this.gridControlIMHead.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewIMHead});
            // 
            // gridViewIMHead
            // 
            this.gridViewIMHead.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId,
            this.colSelect,
            this.colInventoryMoveNo,
            this.colOrderHeadDate,
            this.colInRepertoryNo,
            this.colOutRepertoryNo,
            this.colReqDep,
            this.colPRemark,
            this.colPrepared,
            this.colModifier});
            this.gridViewIMHead.GridControl = this.gridControlIMHead;
            this.gridViewIMHead.IndicatorWidth = 40;
            this.gridViewIMHead.Name = "gridViewIMHead";
            this.gridViewIMHead.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewIMHead.OptionsMenu.EnableColumnMenu = false;
            this.gridViewIMHead.OptionsMenu.EnableFooterMenu = false;
            this.gridViewIMHead.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewIMHead.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewIMHead.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewIMHead.OptionsView.ColumnAutoWidth = false;
            this.gridViewIMHead.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewIMHead.OptionsView.ShowFooter = true;
            this.gridViewIMHead.OptionsView.ShowGroupPanel = false;
            this.gridViewIMHead.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewIMHead_CustomDrawRowIndicator);
            this.gridViewIMHead.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridViewIMHead_InitNewRow);
            this.gridViewIMHead.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewIMHead_FocusedRowChanged);
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
            // colInventoryMoveNo
            // 
            this.colInventoryMoveNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colInventoryMoveNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInventoryMoveNo.FieldName = "InventoryMoveNo";
            this.colInventoryMoveNo.Name = "colInventoryMoveNo";
            this.colInventoryMoveNo.OptionsColumn.AllowEdit = false;
            this.colInventoryMoveNo.OptionsColumn.AllowFocus = false;
            this.colInventoryMoveNo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "InventoryMoveNo", "共计{0}条")});
            this.colInventoryMoveNo.Visible = true;
            this.colInventoryMoveNo.VisibleIndex = 1;
            this.colInventoryMoveNo.Width = 110;
            // 
            // colOrderHeadDate
            // 
            this.colOrderHeadDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colOrderHeadDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOrderHeadDate.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.colOrderHeadDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colOrderHeadDate.FieldName = "InventoryMoveDate";
            this.colOrderHeadDate.Name = "colOrderHeadDate";
            this.colOrderHeadDate.OptionsColumn.AllowEdit = false;
            this.colOrderHeadDate.OptionsColumn.AllowFocus = false;
            this.colOrderHeadDate.Visible = true;
            this.colOrderHeadDate.VisibleIndex = 2;
            this.colOrderHeadDate.Width = 90;
            // 
            // colInRepertoryNo
            // 
            this.colInRepertoryNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colInRepertoryNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInRepertoryNo.ColumnEdit = this.repLookUpInRepertoryNo;
            this.colInRepertoryNo.FieldName = "InRepertoryNo";
            this.colInRepertoryNo.Name = "colInRepertoryNo";
            this.colInRepertoryNo.OptionsColumn.AllowEdit = false;
            this.colInRepertoryNo.Visible = true;
            this.colInRepertoryNo.VisibleIndex = 4;
            this.colInRepertoryNo.Width = 100;
            // 
            // repLookUpInRepertoryNo
            // 
            this.repLookUpInRepertoryNo.AutoHeight = false;
            this.repLookUpInRepertoryNo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpInRepertoryNo.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AutoId", "AutoId", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RepertoryNo", "仓库编号"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RepertoryName", "仓库名称"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RepertoryTypeText", "仓库类型")});
            this.repLookUpInRepertoryNo.DisplayMember = "RepertoryName";
            this.repLookUpInRepertoryNo.Name = "repLookUpInRepertoryNo";
            this.repLookUpInRepertoryNo.NullText = "";
            this.repLookUpInRepertoryNo.ValueMember = "RepertoryNo";
            // 
            // colOutRepertoryNo
            // 
            this.colOutRepertoryNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colOutRepertoryNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOutRepertoryNo.ColumnEdit = this.repLookUpInRepertoryNo;
            this.colOutRepertoryNo.FieldName = "OutRepertoryNo";
            this.colOutRepertoryNo.Name = "colOutRepertoryNo";
            this.colOutRepertoryNo.OptionsColumn.AllowEdit = false;
            this.colOutRepertoryNo.Visible = true;
            this.colOutRepertoryNo.VisibleIndex = 3;
            this.colOutRepertoryNo.Width = 100;
            // 
            // colReqDep
            // 
            this.colReqDep.AppearanceHeader.Options.UseTextOptions = true;
            this.colReqDep.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colReqDep.ColumnEdit = this.repLookUpReqDep;
            this.colReqDep.FieldName = "ReqDep";
            this.colReqDep.Name = "colReqDep";
            this.colReqDep.OptionsColumn.AllowEdit = false;
            this.colReqDep.OptionsColumn.AllowFocus = false;
            this.colReqDep.Visible = true;
            this.colReqDep.VisibleIndex = 6;
            this.colReqDep.Width = 80;
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
            // colPRemark
            // 
            this.colPRemark.AppearanceHeader.Options.UseTextOptions = true;
            this.colPRemark.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPRemark.FieldName = "Remark";
            this.colPRemark.Name = "colPRemark";
            this.colPRemark.OptionsColumn.AllowEdit = false;
            this.colPRemark.Visible = true;
            this.colPRemark.VisibleIndex = 5;
            this.colPRemark.Width = 140;
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
            this.colPrepared.Width = 80;
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
            this.colModifier.Width = 80;
            // 
            // pnlMiddleTop
            // 
            this.pnlMiddleTop.Controls.Add(this.btnPreview);
            this.pnlMiddleTop.Controls.Add(this.btnDelete);
            this.pnlMiddleTop.Controls.Add(this.btnCancel);
            this.pnlMiddleTop.Controls.Add(this.btnSave);
            this.pnlMiddleTop.Controls.Add(this.btnNew);
            this.pnlMiddleTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMiddleTop.Location = new System.Drawing.Point(2, 2);
            this.pnlMiddleTop.Name = "pnlMiddleTop";
            this.pnlMiddleTop.Size = new System.Drawing.Size(1046, 34);
            this.pnlMiddleTop.TabIndex = 2;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(329, 5);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 24;
            this.btnPreview.TabStop = false;
            this.btnPreview.Text = "预览";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
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
            // pnltop
            // 
            this.pnltop.Controls.Add(this.lookUpOutRpertoryNo);
            this.pnltop.Controls.Add(this.lookUpReqDep);
            this.pnltop.Controls.Add(this.lookUpInRepertoryNo);
            this.pnltop.Controls.Add(this.btnQuery);
            this.pnltop.Controls.Add(this.textCommon);
            this.pnltop.Controls.Add(this.lookUpPrepared);
            this.pnltop.Controls.Add(this.dateIMDateEnd);
            this.pnltop.Controls.Add(this.lab1);
            this.pnltop.Controls.Add(this.dateIMDateBegin);
            this.pnltop.Controls.Add(this.labReqDep);
            this.pnltop.Controls.Add(this.labOutRepertoryNo);
            this.pnltop.Controls.Add(this.labInRepertoryNo);
            this.pnltop.Controls.Add(this.labCommon);
            this.pnltop.Controls.Add(this.labPrepared);
            this.pnltop.Controls.Add(this.labIMDate);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(2, 2);
            this.pnltop.Margin = new System.Windows.Forms.Padding(4);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(1050, 78);
            this.pnltop.TabIndex = 1;
            // 
            // lookUpOutRpertoryNo
            // 
            this.lookUpOutRpertoryNo.EnterMoveNextControl = true;
            this.lookUpOutRpertoryNo.Location = new System.Drawing.Point(591, 14);
            this.lookUpOutRpertoryNo.Margin = new System.Windows.Forms.Padding(4);
            this.lookUpOutRpertoryNo.Name = "lookUpOutRpertoryNo";
            this.lookUpOutRpertoryNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpOutRpertoryNo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AutoId", "AutoId", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RepertoryNo", "仓库编号"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RepertoryName", "仓库名称"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RepertoryTypeText", "仓库类型")});
            this.lookUpOutRpertoryNo.Properties.DisplayMember = "RepertoryName";
            this.lookUpOutRpertoryNo.Properties.NullText = "";
            this.lookUpOutRpertoryNo.Properties.ValueMember = "RepertoryNo";
            this.lookUpOutRpertoryNo.Size = new System.Drawing.Size(120, 20);
            this.lookUpOutRpertoryNo.TabIndex = 33;
            // 
            // lookUpReqDep
            // 
            this.lookUpReqDep.EnterMoveNextControl = true;
            this.lookUpReqDep.Location = new System.Drawing.Point(772, 14);
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
            this.lookUpReqDep.TabIndex = 4;
            // 
            // lookUpInRepertoryNo
            // 
            this.lookUpInRepertoryNo.EnterMoveNextControl = true;
            this.lookUpInRepertoryNo.Location = new System.Drawing.Point(387, 14);
            this.lookUpInRepertoryNo.Margin = new System.Windows.Forms.Padding(4);
            this.lookUpInRepertoryNo.Name = "lookUpInRepertoryNo";
            this.lookUpInRepertoryNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpInRepertoryNo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AutoId", "AutoId", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RepertoryNo", "仓库编号"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RepertoryName", "仓库名称"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RepertoryTypeText", "仓库类型")});
            this.lookUpInRepertoryNo.Properties.DisplayMember = "RepertoryName";
            this.lookUpInRepertoryNo.Properties.NullText = "";
            this.lookUpInRepertoryNo.Properties.ValueMember = "RepertoryNo";
            this.lookUpInRepertoryNo.Size = new System.Drawing.Size(120, 20);
            this.lookUpInRepertoryNo.TabIndex = 2;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(455, 43);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 7;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // textCommon
            // 
            this.textCommon.EnterMoveNextControl = true;
            this.textCommon.Location = new System.Drawing.Point(280, 44);
            this.textCommon.Margin = new System.Windows.Forms.Padding(4);
            this.textCommon.Name = "textCommon";
            this.textCommon.Size = new System.Drawing.Size(150, 20);
            this.textCommon.TabIndex = 6;
            // 
            // lookUpPrepared
            // 
            this.lookUpPrepared.EnterMoveNextControl = true;
            this.lookUpPrepared.Location = new System.Drawing.Point(76, 44);
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
            this.lookUpPrepared.TabIndex = 5;
            // 
            // dateIMDateEnd
            // 
            this.dateIMDateEnd.EditValue = null;
            this.dateIMDateEnd.EnterMoveNextControl = true;
            this.dateIMDateEnd.Location = new System.Drawing.Point(202, 14);
            this.dateIMDateEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dateIMDateEnd.Name = "dateIMDateEnd";
            this.dateIMDateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateIMDateEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateIMDateEnd.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dateIMDateEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateIMDateEnd.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateIMDateEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateIMDateEnd.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateIMDateEnd.Size = new System.Drawing.Size(100, 20);
            this.dateIMDateEnd.TabIndex = 1;
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
            // dateIMDateBegin
            // 
            this.dateIMDateBegin.EditValue = null;
            this.dateIMDateBegin.EnterMoveNextControl = true;
            this.dateIMDateBegin.Location = new System.Drawing.Point(86, 14);
            this.dateIMDateBegin.Margin = new System.Windows.Forms.Padding(4);
            this.dateIMDateBegin.Name = "dateIMDateBegin";
            this.dateIMDateBegin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateIMDateBegin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateIMDateBegin.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dateIMDateBegin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateIMDateBegin.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateIMDateBegin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateIMDateBegin.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateIMDateBegin.Size = new System.Drawing.Size(100, 20);
            this.dateIMDateBegin.TabIndex = 0;
            // 
            // labReqDep
            // 
            this.labReqDep.Location = new System.Drawing.Point(728, 17);
            this.labReqDep.Margin = new System.Windows.Forms.Padding(4);
            this.labReqDep.Name = "labReqDep";
            this.labReqDep.Size = new System.Drawing.Size(36, 14);
            this.labReqDep.TabIndex = 32;
            this.labReqDep.Text = "部门：";
            // 
            // labOutRepertoryNo
            // 
            this.labOutRepertoryNo.Location = new System.Drawing.Point(523, 17);
            this.labOutRepertoryNo.Margin = new System.Windows.Forms.Padding(4);
            this.labOutRepertoryNo.Name = "labOutRepertoryNo";
            this.labOutRepertoryNo.Size = new System.Drawing.Size(60, 14);
            this.labOutRepertoryNo.TabIndex = 28;
            this.labOutRepertoryNo.Text = "出库仓库：";
            // 
            // labInRepertoryNo
            // 
            this.labInRepertoryNo.Location = new System.Drawing.Point(319, 17);
            this.labInRepertoryNo.Margin = new System.Windows.Forms.Padding(4);
            this.labInRepertoryNo.Name = "labInRepertoryNo";
            this.labInRepertoryNo.Size = new System.Drawing.Size(60, 14);
            this.labInRepertoryNo.TabIndex = 26;
            this.labInRepertoryNo.Text = "入库仓库：";
            // 
            // labCommon
            // 
            this.labCommon.Location = new System.Drawing.Point(212, 47);
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
            // labIMDate
            // 
            this.labIMDate.Location = new System.Drawing.Point(20, 17);
            this.labIMDate.Margin = new System.Windows.Forms.Padding(4);
            this.labIMDate.Name = "labIMDate";
            this.labIMDate.Size = new System.Drawing.Size(60, 14);
            this.labIMDate.TabIndex = 5;
            this.labIMDate.Text = "移动日期：";
            // 
            // FrmInventoryMove_Drag
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1404, 681);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.dockPnlLeft);
            this.Name = "FrmInventoryMove_Drag";
            this.TabText = "库存移动单";
            this.Text = "库存移动单";
            this.Activated += new System.EventHandler(this.FrmInventoryMove_Activated);
            this.Load += new System.EventHandler(this.FrmInventoryMove_Load);
            this.Shown += new System.EventHandler(this.FrmInventoryMove_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_IM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableIMHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableIMList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_IMHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_IMList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManagerLeft)).EndInit();
            this.dockPnlLeft.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeftMiddle)).EndInit();
            this.pnlLeftMiddle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlWNowInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_WNowInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_WNowInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableWNowInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWNowInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpRepertoryNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeftTop)).EndInit();
            this.pnlLeftTop.ResumeLayout(false);
            this.pnlLeftTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkZero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpRepertoryNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpCodeFileName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpCodeFileNameView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpProjectNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpProjectNoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).EndInit();
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlIMList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewIMList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchCodeFileName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchCodeFileNameView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repbtnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchOutProjectNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchOutProjectNoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchOutShelfNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchOutShelfNoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddle)).EndInit();
            this.pnlMiddle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlIMHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewIMHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpInRepertoryNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpReqDep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddleTop)).EndInit();
            this.pnlMiddleTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnltop)).EndInit();
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpOutRpertoryNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpReqDep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpInRepertoryNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCommon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPrepared.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateIMDateEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateIMDateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateIMDateBegin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateIMDateBegin.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dataSet_IM;
        private System.Data.DataTable dataTableIMHead;
        private System.Data.DataColumn dataColAutoId;
        private System.Data.DataColumn dataColInventoryMoveNo;
        private System.Data.DataColumn dataColInventoryMoveDate;
        private System.Data.DataColumn dataColInRepertoryNo;
        private System.Data.DataColumn dataColOutRepertoryNo;
        private System.Data.DataColumn dataColPrepared;
        private System.Data.DataColumn dataColPreparedIp;
        private System.Data.DataColumn dataColumnRemark;
        private System.Data.DataColumn dataColModifier;
        private System.Data.DataColumn dataColModifierIp;
        private System.Data.DataColumn dataColModifierTime;
        private System.Data.DataColumn dataColSelect;
        private System.Data.DataColumn dataColReqDep;
        private System.Data.DataTable dataTableIMList;
        private System.Data.DataColumn dataColumnAutoId;
        private System.Data.DataColumn dataColumnInventoryMoveNo;
        private System.Data.DataColumn dataColCodeFileName;
        private System.Data.DataColumn dataColQty;
        private System.Data.DataColumn dataColInProjectNo;
        private System.Data.DataColumn dataColInShelfNo;
        private System.Data.DataColumn dataColRemark;
        private System.Data.DataColumn dataColOutProjectNo;
        private System.Data.DataColumn dataColOutShelfNo;
        private System.Data.DataColumn dataColumnInventoryMoveDate;
        private System.Data.DataColumn dataColumnInRepertoryNo;
        private System.Data.DataColumn dataColumnOutRepertoryNo;
        private System.Windows.Forms.BindingSource bindingSource_IMHead;
        private System.Windows.Forms.BindingSource bindingSource_IMList;
        private System.Data.DataColumn dataColCodeName;
        private DevExpress.XtraBars.Docking.DockManager dockManagerLeft;
        private DevExpress.XtraBars.Docking.DockPanel dockPnlLeft;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraEditors.PanelControl pnlRight;
        private DevExpress.XtraEditors.PanelControl pnltop;
        private DevExpress.XtraEditors.LookUpEdit lookUpReqDep;
        private DevExpress.XtraEditors.LookUpEdit lookUpInRepertoryNo;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.TextEdit textCommon;
        private DevExpress.XtraEditors.LookUpEdit lookUpPrepared;
        private DevExpress.XtraEditors.DateEdit dateIMDateEnd;
        private DevExpress.XtraEditors.LabelControl lab1;
        private DevExpress.XtraEditors.DateEdit dateIMDateBegin;
        private DevExpress.XtraEditors.LabelControl labReqDep;
        private DevExpress.XtraEditors.LabelControl labOutRepertoryNo;
        private DevExpress.XtraEditors.LabelControl labInRepertoryNo;
        private DevExpress.XtraEditors.LabelControl labCommon;
        private DevExpress.XtraEditors.LabelControl labPrepared;
        private DevExpress.XtraEditors.LabelControl labIMDate;
        private System.Data.DataColumn dataColInProjectName;
        private System.Data.DataColumn dataColOutProjectName;
        private DevExpress.XtraEditors.LookUpEdit lookUpOutRpertoryNo;
        private System.Data.DataSet dataSet_WNowInfo;
        private System.Data.DataTable TableWNowInfo;
        private System.Data.DataColumn dataAutoId;
        private System.Data.DataColumn dataCodeFileName;
        private System.Data.DataColumn dataCodeName;
        private System.Data.DataColumn dataProjectNo;
        private System.Data.DataColumn dataProjectName;
        private System.Data.DataColumn dataRepertoryNo;
        private System.Data.DataColumn dataShelfNo;
        private System.Data.DataColumn dataQty;
        private System.Windows.Forms.BindingSource bindingSource_WNowInfo;
        private DevExpress.XtraEditors.PanelControl pnlLeftTop;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpProjectNo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpProjectNoView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColProjectNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColProjectName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColRemark;
        private DevExpress.XtraEditors.SimpleButton btnWNowInfoQuery;
        private DevExpress.XtraEditors.LabelControl labProjectNo;
        private DevExpress.XtraEditors.LabelControl labPrReqNo;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpCodeFileName;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpCodeFileNameView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.LabelControl labCodeFileName;
        private DevExpress.XtraEditors.LookUpEdit lookUpRepertoryNo;
        private DevExpress.XtraEditors.PanelControl pnlLeftMiddle;
        private DevExpress.XtraEditors.PanelControl pnlMiddle;
        private DevExpress.XtraEditors.CheckEdit checkAll;
        private DevExpress.XtraGrid.GridControl gridControlIMHead;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewIMHead;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colSelect;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheckSelect;
        private DevExpress.XtraGrid.Columns.GridColumn colInventoryMoveNo;
        private DevExpress.XtraGrid.Columns.GridColumn colInRepertoryNo;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderHeadDate;
        private DevExpress.XtraGrid.Columns.GridColumn colOutRepertoryNo;
        private DevExpress.XtraGrid.Columns.GridColumn colReqDep;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpReqDep;
        private DevExpress.XtraGrid.Columns.GridColumn colPRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colPrepared;
        private DevExpress.XtraEditors.PanelControl pnlMiddleTop;
        private DevExpress.XtraEditors.SimpleButton btnPreview;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.PanelControl pnlBottom;
        private DevExpress.XtraEditors.SimpleButton btnListAdd;
        private DevExpress.XtraGrid.GridControl gridControlIMList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewIMList;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId1;
        private DevExpress.XtraGrid.Columns.GridColumn columnInventoryMoveNo;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeFileName;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repSearchCodeFileName;
        private DevExpress.XtraGrid.Views.Grid.GridView repSearchCodeFileNameView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCodeFileName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCodeName;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeName;
        private DevExpress.XtraGrid.Columns.GridColumn colQty;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repSpinQty;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repbtnDelete;
        private DevExpress.XtraGrid.GridControl gridControlWNowInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewWNowInfo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectName;
        private DevExpress.XtraGrid.Columns.GridColumn colRepertoryNo;
        private DevExpress.XtraGrid.Columns.GridColumn colShelfNo;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectNo1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpRepertoryNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpInRepertoryNo;
        private DevExpress.XtraGrid.Columns.GridColumn colInventoryMoveDate;
        private DevExpress.XtraGrid.Columns.GridColumn colInRepertoryNo1;
        private DevExpress.XtraGrid.Columns.GridColumn colOutRepertoryNo1;
        private DevExpress.XtraGrid.Columns.GridColumn colInProjectName;
        private DevExpress.XtraGrid.Columns.GridColumn colOutProjectName;
        private DevExpress.XtraGrid.Columns.GridColumn colOutProjectNo;
        private DevExpress.XtraGrid.Columns.GridColumn colOutShelfNo;
        private DevExpress.XtraGrid.Columns.GridColumn colInProjectNo;
        private DevExpress.XtraGrid.Columns.GridColumn colInShelfNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repSearchOutProjectNo;
        private DevExpress.XtraGrid.Views.Grid.GridView repSearchOutProjectNoView;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repSearchOutShelfNo;
        private DevExpress.XtraGrid.Views.Grid.GridView repSearchOutShelfNoView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn colModifier;
        private DevExpress.XtraEditors.CheckEdit checkZero;
    }
}