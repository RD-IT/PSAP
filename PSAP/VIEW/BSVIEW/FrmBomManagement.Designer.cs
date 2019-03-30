namespace PSAP.VIEW.BSVIEW
{
    partial class FrmBomManagement
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
            this.pnlLeft = new DevExpress.XtraEditors.PanelControl();
            this.pnlLeftTree = new DevExpress.XtraEditors.PanelControl();
            this.treeListBom = new DevExpress.XtraTreeList.TreeList();
            this.CCodeFileName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.CCodeName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.CQty = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.CParentCodeFileName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.CPCAutoId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.CReID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.CReParent = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.pnlLeftTop = new DevExpress.XtraEditors.PanelControl();
            this.searchCodeFileName = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchCodeFileNameView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSaveExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.labCodeFileName = new DevExpress.XtraEditors.LabelControl();
            this.pnlRight = new DevExpress.XtraEditors.PanelControl();
            this.pnlBottom = new DevExpress.XtraEditors.PanelControl();
            this.btnListAdd = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlBomMateriel = new DevExpress.XtraGrid.GridControl();
            this.bSBomMateriel = new System.Windows.Forms.BindingSource(this.components);
            this.dSBom = new System.Data.DataSet();
            this.TableBomManagement = new System.Data.DataTable();
            this.dataColAutoId = new System.Data.DataColumn();
            this.dataColPartsCodeId = new System.Data.DataColumn();
            this.dataColMaterielNo = new System.Data.DataColumn();
            this.dataColMaterieStateId = new System.Data.DataColumn();
            this.dataColGetTime = new System.Data.DataColumn();
            this.dataColCodeName = new System.Data.DataColumn();
            this.TableBomMateriel = new System.Data.DataTable();
            this.dataColuAutoId = new System.Data.DataColumn();
            this.dataColuMaterielNo = new System.Data.DataColumn();
            this.dataColuLevelMaterielNo = new System.Data.DataColumn();
            this.dataColuQty = new System.Data.DataColumn();
            this.dataColuGetTime = new System.Data.DataColumn();
            this.dataColuLevelMaterielName = new System.Data.DataColumn();
            this.gridViewBomMateriel = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterielNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLevelMaterielNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSearchCodeFileName = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repSearchCodeFileNameView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCodeFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCodeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLevelMaterielName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSpinQty = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colGetTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repbtnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.pnlEdit = new DevExpress.XtraEditors.PanelControl();
            this.textCodeName = new DevExpress.XtraEditors.TextEdit();
            this.bSBomManagement = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labGetTime = new DevExpress.XtraEditors.LabelControl();
            this.dateGetTime = new DevExpress.XtraEditors.DateEdit();
            this.searchPartsCodeId = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchPartsCodeIdView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labMaterieState = new DevExpress.XtraEditors.LabelControl();
            this.lookUpMaterieState = new DevExpress.XtraEditors.LookUpEdit();
            this.labPartsCodeId = new DevExpress.XtraEditors.LabelControl();
            this.pnlToolBar = new DevExpress.XtraEditors.PanelControl();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.pnlBom = new DevExpress.XtraEditors.PanelControl();
            this.splitterMiddle = new DevExpress.XtraEditors.SplitterControl();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiJjcxdqxzbomxx = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLjmcbnwk = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLjmccxxxcw = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeft)).BeginInit();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeftTree)).BeginInit();
            this.pnlLeftTree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListBom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeftTop)).BeginInit();
            this.pnlLeftTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchCodeFileName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchCodeFileNameView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).BeginInit();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).BeginInit();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBomMateriel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSBomMateriel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSBom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableBomManagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableBomMateriel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBomMateriel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchCodeFileName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchCodeFileNameView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repbtnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).BeginInit();
            this.pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textCodeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSBomManagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGetTime.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGetTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPartsCodeId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPartsCodeIdView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpMaterieState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).BeginInit();
            this.pnlToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBom)).BeginInit();
            this.pnlBom.SuspendLayout();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlLeft.Controls.Add(this.pnlLeftTree);
            this.pnlLeft.Controls.Add(this.pnlLeftTop);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(2, 2);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(500, 621);
            this.pnlLeft.TabIndex = 0;
            // 
            // pnlLeftTree
            // 
            this.pnlLeftTree.Controls.Add(this.treeListBom);
            this.pnlLeftTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeftTree.Location = new System.Drawing.Point(0, 40);
            this.pnlLeftTree.Name = "pnlLeftTree";
            this.pnlLeftTree.Size = new System.Drawing.Size(500, 581);
            this.pnlLeftTree.TabIndex = 3;
            // 
            // treeListBom
            // 
            this.treeListBom.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.CCodeFileName,
            this.CCodeName,
            this.CQty,
            this.CParentCodeFileName,
            this.CPCAutoId,
            this.CReID,
            this.CReParent});
            this.treeListBom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListBom.KeyFieldName = "ReID";
            this.treeListBom.Location = new System.Drawing.Point(2, 2);
            this.treeListBom.Name = "treeListBom";
            this.treeListBom.OptionsBehavior.Editable = false;
            this.treeListBom.OptionsBehavior.ReadOnly = true;
            this.treeListBom.OptionsClipboard.AllowCopy = DevExpress.Utils.DefaultBoolean.True;
            this.treeListBom.OptionsClipboard.CopyNodeHierarchy = DevExpress.Utils.DefaultBoolean.True;
            this.treeListBom.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.treeListBom.OptionsView.EnableAppearanceEvenRow = true;
            this.treeListBom.OptionsView.EnableAppearanceOddRow = true;
            this.treeListBom.OptionsView.ShowHorzLines = false;
            this.treeListBom.OptionsView.ShowIndicator = false;
            this.treeListBom.OptionsView.ShowVertLines = false;
            this.treeListBom.ParentFieldName = "ReParent";
            this.treeListBom.Size = new System.Drawing.Size(496, 577);
            this.treeListBom.TabIndex = 1;
            this.treeListBom.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeListBom_FocusedNodeChanged);
            // 
            // CCodeFileName
            // 
            this.CCodeFileName.AppearanceHeader.Options.UseTextOptions = true;
            this.CCodeFileName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CCodeFileName.Caption = "零件编号";
            this.CCodeFileName.FieldName = "CodeFileName";
            this.CCodeFileName.Name = "CCodeFileName";
            this.CCodeFileName.Visible = true;
            this.CCodeFileName.VisibleIndex = 0;
            this.CCodeFileName.Width = 260;
            // 
            // CCodeName
            // 
            this.CCodeName.AppearanceHeader.Options.UseTextOptions = true;
            this.CCodeName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CCodeName.Caption = "零件名称";
            this.CCodeName.FieldName = "CodeName";
            this.CCodeName.Name = "CCodeName";
            this.CCodeName.Visible = true;
            this.CCodeName.VisibleIndex = 1;
            this.CCodeName.Width = 100;
            // 
            // CQty
            // 
            this.CQty.AppearanceHeader.Options.UseTextOptions = true;
            this.CQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CQty.Caption = "数量";
            this.CQty.FieldName = "Qty";
            this.CQty.Name = "CQty";
            this.CQty.Visible = true;
            this.CQty.VisibleIndex = 2;
            this.CQty.Width = 30;
            // 
            // CParentCodeFileName
            // 
            this.CParentCodeFileName.Caption = "ParentCodeFileName";
            this.CParentCodeFileName.FieldName = "ParentCodeFileName";
            this.CParentCodeFileName.Name = "CParentCodeFileName";
            // 
            // CPCAutoId
            // 
            this.CPCAutoId.Caption = "PCAutoId";
            this.CPCAutoId.FieldName = "PCAutoId";
            this.CPCAutoId.Name = "CPCAutoId";
            // 
            // CReID
            // 
            this.CReID.Caption = "ReID";
            this.CReID.FieldName = "ReID";
            this.CReID.Name = "CReID";
            // 
            // CReParent
            // 
            this.CReParent.Caption = "ReParent";
            this.CReParent.FieldName = "ReParent";
            this.CReParent.Name = "CReParent";
            // 
            // pnlLeftTop
            // 
            this.pnlLeftTop.Controls.Add(this.searchCodeFileName);
            this.pnlLeftTop.Controls.Add(this.btnSaveExcel);
            this.pnlLeftTop.Controls.Add(this.btnQuery);
            this.pnlLeftTop.Controls.Add(this.labCodeFileName);
            this.pnlLeftTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeftTop.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftTop.Name = "pnlLeftTop";
            this.pnlLeftTop.Size = new System.Drawing.Size(500, 40);
            this.pnlLeftTop.TabIndex = 2;
            // 
            // searchCodeFileName
            // 
            this.searchCodeFileName.EnterMoveNextControl = true;
            this.searchCodeFileName.Location = new System.Drawing.Point(82, 10);
            this.searchCodeFileName.Name = "searchCodeFileName";
            this.searchCodeFileName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchCodeFileName.Properties.DisplayMember = "CodeFileName";
            this.searchCodeFileName.Properties.NullText = "";
            this.searchCodeFileName.Properties.ValueMember = "CodeFileName";
            this.searchCodeFileName.Properties.View = this.searchCodeFileNameView;
            this.searchCodeFileName.Size = new System.Drawing.Size(150, 20);
            this.searchCodeFileName.TabIndex = 101;
            // 
            // searchCodeFileNameView
            // 
            this.searchCodeFileNameView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.searchCodeFileNameView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchCodeFileNameView.IndicatorWidth = 60;
            this.searchCodeFileNameView.Name = "searchCodeFileNameView";
            this.searchCodeFileNameView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchCodeFileNameView.OptionsView.ShowGroupPanel = false;
            this.searchCodeFileNameView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewBomMateriel_CustomDrawRowIndicator);
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "零件编号";
            this.gridColumn6.FieldName = "CodeFileName";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "零件名称";
            this.gridColumn7.FieldName = "CodeName";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "AutoId";
            this.gridColumn8.FieldName = "AutoId";
            this.gridColumn8.Name = "gridColumn8";
            // 
            // btnSaveExcel
            // 
            this.btnSaveExcel.Location = new System.Drawing.Point(364, 9);
            this.btnSaveExcel.Name = "btnSaveExcel";
            this.btnSaveExcel.Size = new System.Drawing.Size(75, 23);
            this.btnSaveExcel.TabIndex = 105;
            this.btnSaveExcel.Text = "存为Excel";
            this.btnSaveExcel.Click += new System.EventHandler(this.btnSaveExcel_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(268, 9);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 102;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // labCodeFileName
            // 
            this.labCodeFileName.Location = new System.Drawing.Point(19, 13);
            this.labCodeFileName.Name = "labCodeFileName";
            this.labCodeFileName.Size = new System.Drawing.Size(48, 14);
            this.labCodeFileName.TabIndex = 13;
            this.labCodeFileName.Text = "零件编号";
            // 
            // pnlRight
            // 
            this.pnlRight.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlRight.Controls.Add(this.pnlBottom);
            this.pnlRight.Controls.Add(this.pnlEdit);
            this.pnlRight.Controls.Add(this.pnlToolBar);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(507, 2);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(1014, 621);
            this.pnlRight.TabIndex = 1;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnListAdd);
            this.pnlBottom.Controls.Add(this.gridControlBomMateriel);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(0, 108);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1014, 513);
            this.pnlBottom.TabIndex = 10;
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
            // gridControlBomMateriel
            // 
            this.gridControlBomMateriel.DataSource = this.bSBomMateriel;
            this.gridControlBomMateriel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlBomMateriel.Location = new System.Drawing.Point(2, 2);
            this.gridControlBomMateriel.MainView = this.gridViewBomMateriel;
            this.gridControlBomMateriel.Name = "gridControlBomMateriel";
            this.gridControlBomMateriel.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repSpinQty,
            this.repSearchCodeFileName,
            this.repbtnDelete});
            this.gridControlBomMateriel.Size = new System.Drawing.Size(1010, 509);
            this.gridControlBomMateriel.TabIndex = 2;
            this.gridControlBomMateriel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBomMateriel});
            // 
            // bSBomMateriel
            // 
            this.bSBomMateriel.DataMember = "BomMateriel";
            this.bSBomMateriel.DataSource = this.dSBom;
            // 
            // dSBom
            // 
            this.dSBom.DataSetName = "NewDataSet";
            this.dSBom.Tables.AddRange(new System.Data.DataTable[] {
            this.TableBomManagement,
            this.TableBomMateriel});
            // 
            // TableBomManagement
            // 
            this.TableBomManagement.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColAutoId,
            this.dataColPartsCodeId,
            this.dataColMaterielNo,
            this.dataColMaterieStateId,
            this.dataColGetTime,
            this.dataColCodeName});
            this.TableBomManagement.TableName = "BomManagement";
            this.TableBomManagement.TableNewRow += new System.Data.DataTableNewRowEventHandler(this.TableBomManagement_TableNewRow);
            // 
            // dataColAutoId
            // 
            this.dataColAutoId.ColumnName = "AutoId";
            this.dataColAutoId.DataType = typeof(int);
            // 
            // dataColPartsCodeId
            // 
            this.dataColPartsCodeId.Caption = "物料信息ID";
            this.dataColPartsCodeId.ColumnName = "PartsCodeId";
            this.dataColPartsCodeId.DataType = typeof(int);
            // 
            // dataColMaterielNo
            // 
            this.dataColMaterielNo.Caption = "Bom编码";
            this.dataColMaterielNo.ColumnName = "MaterielNo";
            // 
            // dataColMaterieStateId
            // 
            this.dataColMaterieStateId.Caption = "物料状态ID";
            this.dataColMaterieStateId.ColumnName = "MaterieStateId";
            this.dataColMaterieStateId.DataType = typeof(int);
            // 
            // dataColGetTime
            // 
            this.dataColGetTime.Caption = "登记时间";
            this.dataColGetTime.ColumnName = "GetTime";
            this.dataColGetTime.DataType = typeof(System.DateTime);
            // 
            // dataColCodeName
            // 
            this.dataColCodeName.Caption = "零件名称";
            this.dataColCodeName.ColumnName = "CodeName";
            // 
            // TableBomMateriel
            // 
            this.TableBomMateriel.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColuAutoId,
            this.dataColuMaterielNo,
            this.dataColuLevelMaterielNo,
            this.dataColuQty,
            this.dataColuGetTime,
            this.dataColuLevelMaterielName});
            this.TableBomMateriel.TableName = "BomMateriel";
            this.TableBomMateriel.TableNewRow += new System.Data.DataTableNewRowEventHandler(this.TableBomMateriel_TableNewRow);
            // 
            // dataColuAutoId
            // 
            this.dataColuAutoId.ColumnName = "AutoId";
            this.dataColuAutoId.DataType = typeof(int);
            // 
            // dataColuMaterielNo
            // 
            this.dataColuMaterielNo.Caption = "Bom编码";
            this.dataColuMaterielNo.ColumnName = "MaterielNo";
            // 
            // dataColuLevelMaterielNo
            // 
            this.dataColuLevelMaterielNo.Caption = "子零件编号";
            this.dataColuLevelMaterielNo.ColumnName = "LevelMaterielNo";
            // 
            // dataColuQty
            // 
            this.dataColuQty.Caption = "数量";
            this.dataColuQty.ColumnName = "Qty";
            this.dataColuQty.DataType = typeof(int);
            // 
            // dataColuGetTime
            // 
            this.dataColuGetTime.Caption = "登记时间";
            this.dataColuGetTime.ColumnName = "GetTime";
            this.dataColuGetTime.DataType = typeof(System.DateTime);
            // 
            // dataColuLevelMaterielName
            // 
            this.dataColuLevelMaterielName.Caption = "子零件名称";
            this.dataColuLevelMaterielName.ColumnName = "LevelMaterielName";
            // 
            // gridViewBomMateriel
            // 
            this.gridViewBomMateriel.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.colMaterielNo,
            this.colLevelMaterielNo,
            this.colLevelMaterielName,
            this.colQty,
            this.colGetTime,
            this.colDelete});
            this.gridViewBomMateriel.GridControl = this.gridControlBomMateriel;
            this.gridViewBomMateriel.IndicatorWidth = 40;
            this.gridViewBomMateriel.Name = "gridViewBomMateriel";
            this.gridViewBomMateriel.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewBomMateriel.OptionsBehavior.Editable = false;
            this.gridViewBomMateriel.OptionsMenu.EnableColumnMenu = false;
            this.gridViewBomMateriel.OptionsMenu.EnableFooterMenu = false;
            this.gridViewBomMateriel.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewBomMateriel.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewBomMateriel.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewBomMateriel.OptionsView.ColumnAutoWidth = false;
            this.gridViewBomMateriel.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewBomMateriel.OptionsView.ShowFooter = true;
            this.gridViewBomMateriel.OptionsView.ShowGroupPanel = false;
            this.gridViewBomMateriel.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewBomMateriel_CustomDrawRowIndicator);
            this.gridViewBomMateriel.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewBomMateriel_CellValueChanged);
            this.gridViewBomMateriel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewBomMateriel_KeyDown);
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "AutoId";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // colMaterielNo
            // 
            this.colMaterielNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaterielNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaterielNo.FieldName = "MaterielNo";
            this.colMaterielNo.Name = "colMaterielNo";
            this.colMaterielNo.OptionsColumn.AllowEdit = false;
            this.colMaterielNo.Width = 100;
            // 
            // colLevelMaterielNo
            // 
            this.colLevelMaterielNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colLevelMaterielNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLevelMaterielNo.ColumnEdit = this.repSearchCodeFileName;
            this.colLevelMaterielNo.FieldName = "LevelMaterielNo";
            this.colLevelMaterielNo.Name = "colLevelMaterielNo";
            this.colLevelMaterielNo.Visible = true;
            this.colLevelMaterielNo.VisibleIndex = 0;
            this.colLevelMaterielNo.Width = 120;
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
            this.gridColumn5,
            this.gridColumnCodeFileName,
            this.gridColumnCodeName});
            this.repSearchCodeFileNameView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repSearchCodeFileNameView.IndicatorWidth = 60;
            this.repSearchCodeFileNameView.Name = "repSearchCodeFileNameView";
            this.repSearchCodeFileNameView.OptionsBehavior.Editable = false;
            this.repSearchCodeFileNameView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repSearchCodeFileNameView.OptionsView.ShowGroupPanel = false;
            this.repSearchCodeFileNameView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewBomMateriel_CustomDrawRowIndicator);
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "AutoId";
            this.gridColumn5.Name = "gridColumn5";
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
            // colLevelMaterielName
            // 
            this.colLevelMaterielName.AppearanceHeader.Options.UseTextOptions = true;
            this.colLevelMaterielName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLevelMaterielName.FieldName = "LevelMaterielName";
            this.colLevelMaterielName.Name = "colLevelMaterielName";
            this.colLevelMaterielName.OptionsColumn.AllowEdit = false;
            this.colLevelMaterielName.OptionsColumn.AllowFocus = false;
            this.colLevelMaterielName.Visible = true;
            this.colLevelMaterielName.VisibleIndex = 1;
            this.colLevelMaterielName.Width = 120;
            // 
            // colQty
            // 
            this.colQty.AppearanceHeader.Options.UseTextOptions = true;
            this.colQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQty.ColumnEdit = this.repSpinQty;
            this.colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQty.FieldName = "Qty";
            this.colQty.Name = "colQty";
            this.colQty.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qty", "{0:0.##}")});
            this.colQty.Visible = true;
            this.colQty.VisibleIndex = 2;
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
            // colGetTime
            // 
            this.colGetTime.AppearanceHeader.Options.UseTextOptions = true;
            this.colGetTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGetTime.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.colGetTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colGetTime.FieldName = "GetTime";
            this.colGetTime.Name = "colGetTime";
            this.colGetTime.OptionsColumn.AllowEdit = false;
            this.colGetTime.OptionsColumn.AllowFocus = false;
            this.colGetTime.Visible = true;
            this.colGetTime.VisibleIndex = 3;
            this.colGetTime.Width = 130;
            // 
            // colDelete
            // 
            this.colDelete.ColumnEdit = this.repbtnDelete;
            this.colDelete.Name = "colDelete";
            this.colDelete.OptionsColumn.TabStop = false;
            this.colDelete.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 4;
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
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.textCodeName);
            this.pnlEdit.Controls.Add(this.labelControl1);
            this.pnlEdit.Controls.Add(this.labGetTime);
            this.pnlEdit.Controls.Add(this.dateGetTime);
            this.pnlEdit.Controls.Add(this.searchPartsCodeId);
            this.pnlEdit.Controls.Add(this.labMaterieState);
            this.pnlEdit.Controls.Add(this.lookUpMaterieState);
            this.pnlEdit.Controls.Add(this.labPartsCodeId);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEdit.Location = new System.Drawing.Point(0, 40);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(1014, 68);
            this.pnlEdit.TabIndex = 9;
            // 
            // textCodeName
            // 
            this.textCodeName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bSBomManagement, "CodeName", true));
            this.textCodeName.Location = new System.Drawing.Point(382, 21);
            this.textCodeName.Name = "textCodeName";
            this.textCodeName.Size = new System.Drawing.Size(150, 20);
            this.textCodeName.TabIndex = 23;
            this.textCodeName.TabStop = false;
            // 
            // bSBomManagement
            // 
            this.bSBomManagement.DataMember = "BomManagement";
            this.bSBomManagement.DataSource = this.dSBom;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(295, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "母零件名称";
            // 
            // labGetTime
            // 
            this.labGetTime.Location = new System.Drawing.Point(801, 24);
            this.labGetTime.Name = "labGetTime";
            this.labGetTime.Size = new System.Drawing.Size(48, 14);
            this.labGetTime.TabIndex = 21;
            this.labGetTime.Text = "登记时间";
            // 
            // dateGetTime
            // 
            this.dateGetTime.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSBomManagement, "GetTime", true));
            this.dateGetTime.EditValue = null;
            this.dateGetTime.Location = new System.Drawing.Point(871, 21);
            this.dateGetTime.Name = "dateGetTime";
            this.dateGetTime.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateGetTime.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dateGetTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateGetTime.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dateGetTime.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateGetTime.Properties.Mask.EditMask = "G";
            this.dateGetTime.Properties.ReadOnly = true;
            this.dateGetTime.Size = new System.Drawing.Size(150, 20);
            this.dateGetTime.TabIndex = 3;
            this.dateGetTime.TabStop = false;
            // 
            // searchPartsCodeId
            // 
            this.searchPartsCodeId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSBomManagement, "PartsCodeId", true));
            this.searchPartsCodeId.EnterMoveNextControl = true;
            this.searchPartsCodeId.Location = new System.Drawing.Point(122, 21);
            this.searchPartsCodeId.Name = "searchPartsCodeId";
            this.searchPartsCodeId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchPartsCodeId.Properties.DisplayMember = "CodeFileName";
            this.searchPartsCodeId.Properties.NullText = "";
            this.searchPartsCodeId.Properties.ValueMember = "AutoId";
            this.searchPartsCodeId.Properties.View = this.searchPartsCodeIdView;
            this.searchPartsCodeId.Size = new System.Drawing.Size(150, 20);
            this.searchPartsCodeId.TabIndex = 0;
            this.searchPartsCodeId.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.searchPartsCodeId_EditValueChanging);
            // 
            // searchPartsCodeIdView
            // 
            this.searchPartsCodeIdView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn2});
            this.searchPartsCodeIdView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchPartsCodeIdView.IndicatorWidth = 60;
            this.searchPartsCodeIdView.Name = "searchPartsCodeIdView";
            this.searchPartsCodeIdView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchPartsCodeIdView.OptionsView.ShowGroupPanel = false;
            this.searchPartsCodeIdView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewBomMateriel_CustomDrawRowIndicator);
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
            // gridColumn2
            // 
            this.gridColumn2.Caption = "AutoId";
            this.gridColumn2.FieldName = "AutoId";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // labMaterieState
            // 
            this.labMaterieState.Location = new System.Drawing.Point(556, 24);
            this.labMaterieState.Name = "labMaterieState";
            this.labMaterieState.Size = new System.Drawing.Size(48, 14);
            this.labMaterieState.TabIndex = 19;
            this.labMaterieState.Text = "物料状态";
            // 
            // lookUpMaterieState
            // 
            this.lookUpMaterieState.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSBomManagement, "MaterieStateId", true));
            this.lookUpMaterieState.EnterMoveNextControl = true;
            this.lookUpMaterieState.Location = new System.Drawing.Point(629, 21);
            this.lookUpMaterieState.Name = "lookUpMaterieState";
            this.lookUpMaterieState.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpMaterieState.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaterieStateId", "状态编号", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaterieStateText", "状态名称", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpMaterieState.Properties.DisplayMember = "MaterieStateText";
            this.lookUpMaterieState.Properties.NullText = "";
            this.lookUpMaterieState.Properties.ValueMember = "MaterieStateId";
            this.lookUpMaterieState.Size = new System.Drawing.Size(150, 20);
            this.lookUpMaterieState.TabIndex = 1;
            // 
            // labPartsCodeId
            // 
            this.labPartsCodeId.Location = new System.Drawing.Point(36, 24);
            this.labPartsCodeId.Name = "labPartsCodeId";
            this.labPartsCodeId.Size = new System.Drawing.Size(60, 14);
            this.labPartsCodeId.TabIndex = 12;
            this.labPartsCodeId.Text = "母零件编号";
            // 
            // pnlToolBar
            // 
            this.pnlToolBar.Controls.Add(this.btnRefresh);
            this.pnlToolBar.Controls.Add(this.btnDelete);
            this.pnlToolBar.Controls.Add(this.btnCancel);
            this.pnlToolBar.Controls.Add(this.btnSave);
            this.pnlToolBar.Controls.Add(this.btnNew);
            this.pnlToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolBar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolBar.Name = "pnlToolBar";
            this.pnlToolBar.Size = new System.Drawing.Size(1014, 40);
            this.pnlToolBar.TabIndex = 5;
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
            // pnlBom
            // 
            this.pnlBom.Controls.Add(this.pnlRight);
            this.pnlBom.Controls.Add(this.splitterMiddle);
            this.pnlBom.Controls.Add(this.pnlLeft);
            this.pnlBom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBom.Location = new System.Drawing.Point(0, 0);
            this.pnlBom.Name = "pnlBom";
            this.pnlBom.Size = new System.Drawing.Size(1523, 625);
            this.pnlBom.TabIndex = 14;
            // 
            // splitterMiddle
            // 
            this.splitterMiddle.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.splitterMiddle.Location = new System.Drawing.Point(502, 2);
            this.splitterMiddle.Name = "splitterMiddle";
            this.splitterMiddle.Size = new System.Drawing.Size(5, 621);
            this.splitterMiddle.TabIndex = 14;
            this.splitterMiddle.TabStop = false;
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiJjcxdqxzbomxx,
            this.tsmiLjmcbnwk,
            this.tsmiLjmccxxxcw});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(329, 70);
            // 
            // tsmiJjcxdqxzbomxx
            // 
            this.tsmiJjcxdqxzbomxx.Name = "tsmiJjcxdqxzbomxx";
            this.tsmiJjcxdqxzbomxx.Size = new System.Drawing.Size(328, 22);
            this.tsmiJjcxdqxzbomxx.Text = "聚焦查询当前选中Bom信息错误。";
            // 
            // tsmiLjmcbnwk
            // 
            this.tsmiLjmcbnwk.Name = "tsmiLjmcbnwk";
            this.tsmiLjmcbnwk.Size = new System.Drawing.Size(328, 22);
            this.tsmiLjmcbnwk.Text = "零件名称不能为空，请填写后再进行保存。";
            // 
            // tsmiLjmccxxxcw
            // 
            this.tsmiLjmccxxxcw.Name = "tsmiLjmccxxxcw";
            this.tsmiLjmccxxxcw.Size = new System.Drawing.Size(328, 22);
            this.tsmiLjmccxxxcw.Text = "零件名称查询信息错误，请填写后再进行保存。";
            // 
            // FrmBomManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1523, 625);
            this.Controls.Add(this.pnlBom);
            this.Name = "FrmBomManagement";
            this.TabText = "BOM登记";
            this.Text = "BOM登记";
            this.Activated += new System.EventHandler(this.FrmBomManagement_Activated);
            this.Load += new System.EventHandler(this.FrmBomManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeft)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeftTree)).EndInit();
            this.pnlLeftTree.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListBom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeftTop)).EndInit();
            this.pnlLeftTop.ResumeLayout(false);
            this.pnlLeftTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchCodeFileName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchCodeFileNameView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).EndInit();
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBomMateriel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSBomMateriel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSBom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableBomManagement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableBomMateriel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBomMateriel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchCodeFileName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchCodeFileNameView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repbtnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textCodeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSBomManagement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGetTime.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGetTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPartsCodeId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPartsCodeIdView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpMaterieState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).EndInit();
            this.pnlToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlBom)).EndInit();
            this.pnlBom.ResumeLayout(false);
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlLeft;
        private DevExpress.XtraEditors.PanelControl pnlRight;
        private DevExpress.XtraTreeList.TreeList treeListBom;
        private DevExpress.XtraEditors.PanelControl pnlToolBar;
        private System.Data.DataSet dSBom;
        private System.Data.DataTable TableBomManagement;
        private System.Data.DataColumn dataColAutoId;
        private System.Data.DataColumn dataColPartsCodeId;
        private System.Data.DataColumn dataColMaterielNo;
        private System.Data.DataColumn dataColMaterieStateId;
        private System.Data.DataColumn dataColGetTime;
        private System.Data.DataColumn dataColCodeName;
        private System.Data.DataTable TableBomMateriel;
        private System.Data.DataColumn dataColuAutoId;
        private System.Data.DataColumn dataColuMaterielNo;
        private System.Data.DataColumn dataColuLevelMaterielNo;
        private System.Data.DataColumn dataColuQty;
        private System.Data.DataColumn dataColuGetTime;
        private System.Windows.Forms.BindingSource bSBomManagement;
        private System.Windows.Forms.BindingSource bSBomMateriel;
        private DevExpress.XtraEditors.PanelControl pnlEdit;
        private DevExpress.XtraEditors.LabelControl labMaterieState;
        private DevExpress.XtraEditors.LookUpEdit lookUpMaterieState;
        private DevExpress.XtraEditors.LabelControl labPartsCodeId;
        private DevExpress.XtraEditors.SearchLookUpEdit searchPartsCodeId;
        private DevExpress.XtraGrid.Views.Grid.GridView searchPartsCodeIdView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.PanelControl pnlBottom;
        private DevExpress.XtraEditors.SimpleButton btnListAdd;
        private DevExpress.XtraGrid.GridControl gridControlBomMateriel;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewBomMateriel;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repSearchCodeFileName;
        private DevExpress.XtraGrid.Views.Grid.GridView repSearchCodeFileNameView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCodeFileName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCodeName;
        private DevExpress.XtraGrid.Columns.GridColumn colQty;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repSpinQty;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repbtnDelete;
        private System.Data.DataColumn dataColuLevelMaterielName;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterielNo;
        private DevExpress.XtraGrid.Columns.GridColumn colLevelMaterielNo;
        private DevExpress.XtraGrid.Columns.GridColumn colLevelMaterielName;
        private DevExpress.XtraGrid.Columns.GridColumn colGetTime;
        private DevExpress.XtraTreeList.Columns.TreeListColumn CCodeFileName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn CCodeName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn CQty;
        private DevExpress.XtraTreeList.Columns.TreeListColumn CParentCodeFileName;
        private DevExpress.XtraEditors.PanelControl pnlBom;
        private DevExpress.XtraEditors.SplitterControl splitterMiddle;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraTreeList.Columns.TreeListColumn CPCAutoId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn CReID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn CReParent;
        private DevExpress.XtraEditors.PanelControl pnlLeftTree;
        private DevExpress.XtraEditors.PanelControl pnlLeftTop;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.LabelControl labCodeFileName;
        private DevExpress.XtraEditors.LabelControl labGetTime;
        private DevExpress.XtraEditors.DateEdit dateGetTime;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem tsmiJjcxdqxzbomxx;
        private System.Windows.Forms.ToolStripMenuItem tsmiLjmcbnwk;
        private System.Windows.Forms.ToolStripMenuItem tsmiLjmccxxxcw;
        private DevExpress.XtraEditors.TextEdit textCodeName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSaveExcel;
        private DevExpress.XtraEditors.SearchLookUpEdit searchCodeFileName;
        private DevExpress.XtraGrid.Views.Grid.GridView searchCodeFileNameView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
    }
}