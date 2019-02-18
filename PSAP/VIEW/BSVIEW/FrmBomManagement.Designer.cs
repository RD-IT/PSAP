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
            this.pnlRight = new DevExpress.XtraEditors.PanelControl();
            this.splitterMiddle = new DevExpress.XtraEditors.SplitterControl();
            this.treeListBom = new DevExpress.XtraTreeList.TreeList();
            this.CAutoId1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.CMaterielNo = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.pnlToolBar = new DevExpress.XtraEditors.PanelControl();
            this.dSBom = new System.Data.DataSet();
            this.TableBomManagement = new System.Data.DataTable();
            this.dataColAutoId = new System.Data.DataColumn();
            this.dataColPartsCodeId = new System.Data.DataColumn();
            this.dataColMaterielNo = new System.Data.DataColumn();
            this.dataColMaterieStateId = new System.Data.DataColumn();
            this.dataColMaterieStateText = new System.Data.DataColumn();
            this.bSBomManagement = new System.Windows.Forms.BindingSource(this.components);
            this.dataColGetTime = new System.Data.DataColumn();
            this.dataColCodeFileName = new System.Data.DataColumn();
            this.dataColCodeName = new System.Data.DataColumn();
            this.TableBomMateriel = new System.Data.DataTable();
            this.dataColuAutoId = new System.Data.DataColumn();
            this.dataColuMaterielNo = new System.Data.DataColumn();
            this.dataColuLevelMaterielNo = new System.Data.DataColumn();
            this.dataColuQty = new System.Data.DataColumn();
            this.dataColuGetTime = new System.Data.DataColumn();
            this.bSBomMateriel = new System.Windows.Forms.BindingSource(this.components);
            this.pnlEdit = new DevExpress.XtraEditors.PanelControl();
            this.labMaterieState = new DevExpress.XtraEditors.LabelControl();
            this.lookUpMaterieState = new DevExpress.XtraEditors.LookUpEdit();
            this.textMaterielNo = new DevExpress.XtraEditors.TextEdit();
            this.labMaterielNo = new DevExpress.XtraEditors.LabelControl();
            this.labPartsCodeId = new DevExpress.XtraEditors.LabelControl();
            this.searchPartsCodeId = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpPartsCodeIdView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.pnlBottom = new DevExpress.XtraEditors.PanelControl();
            this.btnListAdd = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlBomMateriel = new DevExpress.XtraGrid.GridControl();
            this.gridViewBomMateriel = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSearchCodeFileName = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCodeFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCodeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSpinQty = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repbtnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colGetTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLevelMaterielNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterielNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dataColuLevelMaterielName = new System.Data.DataColumn();
            this.colLevelMaterielName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CCodeFileName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.CCodeName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.CQty = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.CPartsCodeId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.CParentPartsCodeId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.CParentCodeFileName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeft)).BeginInit();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).BeginInit();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListBom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).BeginInit();
            this.pnlToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSBom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableBomManagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSBomManagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableBomMateriel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSBomMateriel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).BeginInit();
            this.pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpMaterieState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMaterielNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPartsCodeId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpPartsCodeIdView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).BeginInit();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBomMateriel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBomMateriel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchCodeFileName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repbtnDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.treeListBom);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(376, 625);
            this.pnlLeft.TabIndex = 0;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.pnlBottom);
            this.pnlRight.Controls.Add(this.pnlEdit);
            this.pnlRight.Controls.Add(this.pnlToolBar);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(381, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(833, 625);
            this.pnlRight.TabIndex = 1;
            // 
            // splitterMiddle
            // 
            this.splitterMiddle.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.splitterMiddle.Location = new System.Drawing.Point(376, 0);
            this.splitterMiddle.Name = "splitterMiddle";
            this.splitterMiddle.Size = new System.Drawing.Size(5, 625);
            this.splitterMiddle.TabIndex = 13;
            this.splitterMiddle.TabStop = false;
            // 
            // treeListBom
            // 
            this.treeListBom.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.CAutoId1,
            this.CMaterielNo,
            this.CCodeFileName,
            this.CCodeName,
            this.CQty,
            this.CPartsCodeId,
            this.CParentPartsCodeId,
            this.CParentCodeFileName});
            this.treeListBom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListBom.KeyFieldName = "PartsCodeId";
            this.treeListBom.Location = new System.Drawing.Point(2, 2);
            this.treeListBom.Name = "treeListBom";
            this.treeListBom.OptionsBehavior.Editable = false;
            this.treeListBom.OptionsBehavior.ReadOnly = true;
            this.treeListBom.OptionsClipboard.AllowCopy = DevExpress.Utils.DefaultBoolean.True;
            this.treeListBom.OptionsClipboard.CopyNodeHierarchy = DevExpress.Utils.DefaultBoolean.True;
            this.treeListBom.OptionsView.EnableAppearanceEvenRow = true;
            this.treeListBom.OptionsView.EnableAppearanceOddRow = true;
            this.treeListBom.OptionsView.ShowHorzLines = false;
            this.treeListBom.OptionsView.ShowIndicator = false;
            this.treeListBom.OptionsView.ShowVertLines = false;
            this.treeListBom.ParentFieldName = "ParentPartsCodeId";
            this.treeListBom.Size = new System.Drawing.Size(372, 621);
            this.treeListBom.TabIndex = 1;
            this.treeListBom.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeListBom_FocusedNodeChanged);
            // 
            // CAutoId1
            // 
            this.CAutoId1.FieldName = "AutoId";
            this.CAutoId1.Name = "CAutoId1";
            this.CAutoId1.Width = 20;
            // 
            // CMaterielNo
            // 
            this.CMaterielNo.AppearanceHeader.Options.UseTextOptions = true;
            this.CMaterielNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CMaterielNo.Caption = "Bom编号";
            this.CMaterielNo.FieldName = "MaterielNo";
            this.CMaterielNo.Name = "CMaterielNo";
            this.CMaterielNo.Visible = true;
            this.CMaterielNo.VisibleIndex = 0;
            // 
            // pnlToolBar
            // 
            this.pnlToolBar.Controls.Add(this.btnDelete);
            this.pnlToolBar.Controls.Add(this.btnCancel);
            this.pnlToolBar.Controls.Add(this.btnSave);
            this.pnlToolBar.Controls.Add(this.btnNew);
            this.pnlToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolBar.Location = new System.Drawing.Point(2, 2);
            this.pnlToolBar.Name = "pnlToolBar";
            this.pnlToolBar.Size = new System.Drawing.Size(829, 34);
            this.pnlToolBar.TabIndex = 5;
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
            this.dataColMaterieStateText,
            this.dataColGetTime,
            this.dataColCodeFileName,
            this.dataColCodeName});
            this.TableBomManagement.TableName = "BomManagement";
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
            // dataColMaterieStateText
            // 
            this.dataColMaterieStateText.Caption = "物料状态";
            this.dataColMaterieStateText.ColumnName = "MaterieStateText";
            // 
            // bSBomManagement
            // 
            this.bSBomManagement.DataMember = "BomManagement";
            this.bSBomManagement.DataSource = this.dSBom;
            // 
            // dataColGetTime
            // 
            this.dataColGetTime.Caption = "登记时间";
            this.dataColGetTime.ColumnName = "GetTime";
            this.dataColGetTime.DataType = typeof(System.DateTime);
            // 
            // dataColCodeFileName
            // 
            this.dataColCodeFileName.Caption = "零件编号";
            this.dataColCodeFileName.ColumnName = "CodeFileName";
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
            this.dataColuLevelMaterielNo.Caption = "子物料编号";
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
            // bSBomMateriel
            // 
            this.bSBomMateriel.DataMember = "BomMateriel";
            this.bSBomMateriel.DataSource = this.dSBom;
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.searchPartsCodeId);
            this.pnlEdit.Controls.Add(this.labMaterieState);
            this.pnlEdit.Controls.Add(this.lookUpMaterieState);
            this.pnlEdit.Controls.Add(this.textMaterielNo);
            this.pnlEdit.Controls.Add(this.labMaterielNo);
            this.pnlEdit.Controls.Add(this.labPartsCodeId);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEdit.Location = new System.Drawing.Point(2, 36);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(829, 68);
            this.pnlEdit.TabIndex = 9;
            // 
            // labMaterieState
            // 
            this.labMaterieState.Location = new System.Drawing.Point(565, 24);
            this.labMaterieState.Name = "labMaterieState";
            this.labMaterieState.Size = new System.Drawing.Size(48, 14);
            this.labMaterieState.TabIndex = 19;
            this.labMaterieState.Text = "物料状态";
            // 
            // lookUpMaterieState
            // 
            this.lookUpMaterieState.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSBomManagement, "MaterieStateId", true));
            this.lookUpMaterieState.EnterMoveNextControl = true;
            this.lookUpMaterieState.Location = new System.Drawing.Point(638, 21);
            this.lookUpMaterieState.Name = "lookUpMaterieState";
            this.lookUpMaterieState.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpMaterieState.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaterieStateId", "状态编号", 95, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaterieStateText", "状态名称", 111, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpMaterieState.Properties.DisplayMember = "MaterieStateText";
            this.lookUpMaterieState.Properties.NullText = "";
            this.lookUpMaterieState.Properties.ValueMember = "MaterieStateId";
            this.lookUpMaterieState.Size = new System.Drawing.Size(150, 20);
            this.lookUpMaterieState.TabIndex = 2;
            // 
            // textMaterielNo
            // 
            this.textMaterielNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSBomManagement, "MaterielNo", true));
            this.textMaterielNo.EnterMoveNextControl = true;
            this.textMaterielNo.Location = new System.Drawing.Point(366, 21);
            this.textMaterielNo.Name = "textMaterielNo";
            this.textMaterielNo.Size = new System.Drawing.Size(150, 20);
            this.textMaterielNo.TabIndex = 1;
            // 
            // labMaterielNo
            // 
            this.labMaterielNo.Location = new System.Drawing.Point(297, 24);
            this.labMaterielNo.Name = "labMaterielNo";
            this.labMaterielNo.Size = new System.Drawing.Size(52, 14);
            this.labMaterielNo.TabIndex = 14;
            this.labMaterielNo.Text = "Bom 编码";
            // 
            // labPartsCodeId
            // 
            this.labPartsCodeId.Location = new System.Drawing.Point(36, 24);
            this.labPartsCodeId.Name = "labPartsCodeId";
            this.labPartsCodeId.Size = new System.Drawing.Size(48, 14);
            this.labPartsCodeId.TabIndex = 12;
            this.labPartsCodeId.Text = "零件名称";
            // 
            // searchPartsCodeId
            // 
            this.searchPartsCodeId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSBomManagement, "PartsCodeId", true));
            this.searchPartsCodeId.EnterMoveNextControl = true;
            this.searchPartsCodeId.Location = new System.Drawing.Point(105, 21);
            this.searchPartsCodeId.Name = "searchPartsCodeId";
            this.searchPartsCodeId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchPartsCodeId.Properties.DisplayMember = "CodeName";
            this.searchPartsCodeId.Properties.NullText = "";
            this.searchPartsCodeId.Properties.ValueMember = "AutoId";
            this.searchPartsCodeId.Properties.View = this.searchLookUpPartsCodeIdView;
            this.searchPartsCodeId.Size = new System.Drawing.Size(150, 20);
            this.searchPartsCodeId.TabIndex = 0;
            // 
            // searchLookUpPartsCodeIdView
            // 
            this.searchLookUpPartsCodeIdView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn2});
            this.searchLookUpPartsCodeIdView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpPartsCodeIdView.IndicatorWidth = 60;
            this.searchLookUpPartsCodeIdView.Name = "searchLookUpPartsCodeIdView";
            this.searchLookUpPartsCodeIdView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpPartsCodeIdView.OptionsView.ShowGroupPanel = false;
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
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(248, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "删除";
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(167, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "取消";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(86, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "修改";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(5, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 14;
            this.btnNew.TabStop = false;
            this.btnNew.Text = "新增";
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnListAdd);
            this.pnlBottom.Controls.Add(this.gridControlBomMateriel);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(2, 104);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(829, 519);
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
            this.gridControlBomMateriel.Size = new System.Drawing.Size(825, 515);
            this.gridControlBomMateriel.TabIndex = 2;
            this.gridControlBomMateriel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBomMateriel});
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
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "AutoId";
            this.gridColumn4.Name = "gridColumn4";
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
            this.repSearchCodeFileName.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumnCodeFileName,
            this.gridColumnCodeName});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.IndicatorWidth = 60;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            // colDelete
            // 
            this.colDelete.ColumnEdit = this.repbtnDelete;
            this.colDelete.Name = "colDelete";
            this.colDelete.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 5;
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
            // colGetTime
            // 
            this.colGetTime.AppearanceHeader.Options.UseTextOptions = true;
            this.colGetTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGetTime.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.colGetTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colGetTime.FieldName = "GetTime";
            this.colGetTime.Name = "colGetTime";
            this.colGetTime.OptionsColumn.AllowEdit = false;
            this.colGetTime.Visible = true;
            this.colGetTime.VisibleIndex = 4;
            this.colGetTime.Width = 130;
            // 
            // colLevelMaterielNo
            // 
            this.colLevelMaterielNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colLevelMaterielNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLevelMaterielNo.ColumnEdit = this.repSearchCodeFileName;
            this.colLevelMaterielNo.FieldName = "LevelMaterielNo";
            this.colLevelMaterielNo.Name = "colLevelMaterielNo";
            this.colLevelMaterielNo.OptionsColumn.AllowEdit = false;
            this.colLevelMaterielNo.Visible = true;
            this.colLevelMaterielNo.VisibleIndex = 1;
            this.colLevelMaterielNo.Width = 120;
            // 
            // colMaterielNo
            // 
            this.colMaterielNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaterielNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaterielNo.FieldName = "MaterielNo";
            this.colMaterielNo.Name = "colMaterielNo";
            this.colMaterielNo.OptionsColumn.AllowEdit = false;
            this.colMaterielNo.Visible = true;
            this.colMaterielNo.VisibleIndex = 0;
            this.colMaterielNo.Width = 100;
            // 
            // dataColuLevelMaterielName
            // 
            this.dataColuLevelMaterielName.Caption = "子物料名称";
            this.dataColuLevelMaterielName.ColumnName = "LevelMaterielName";
            // 
            // colLevelMaterielName
            // 
            this.colLevelMaterielName.AppearanceHeader.Options.UseTextOptions = true;
            this.colLevelMaterielName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLevelMaterielName.FieldName = "LevelMaterielName";
            this.colLevelMaterielName.Name = "colLevelMaterielName";
            this.colLevelMaterielName.OptionsColumn.AllowEdit = false;
            this.colLevelMaterielName.Visible = true;
            this.colLevelMaterielName.VisibleIndex = 2;
            this.colLevelMaterielName.Width = 120;
            // 
            // CCodeFileName
            // 
            this.CCodeFileName.AppearanceHeader.Options.UseTextOptions = true;
            this.CCodeFileName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CCodeFileName.Caption = "零件编号";
            this.CCodeFileName.FieldName = "CodeFileName";
            this.CCodeFileName.Name = "CCodeFileName";
            this.CCodeFileName.Visible = true;
            this.CCodeFileName.VisibleIndex = 1;
            // 
            // CCodeName
            // 
            this.CCodeName.AppearanceHeader.Options.UseTextOptions = true;
            this.CCodeName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CCodeName.Caption = "零件名称";
            this.CCodeName.FieldName = "CodeName";
            this.CCodeName.Name = "CCodeName";
            this.CCodeName.Visible = true;
            this.CCodeName.VisibleIndex = 2;
            // 
            // CQty
            // 
            this.CQty.AppearanceHeader.Options.UseTextOptions = true;
            this.CQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CQty.Caption = "数量";
            this.CQty.FieldName = "Qty";
            this.CQty.Name = "CQty";
            this.CQty.Visible = true;
            this.CQty.VisibleIndex = 3;
            // 
            // CPartsCodeId
            // 
            this.CPartsCodeId.Caption = "PartsCodeId";
            this.CPartsCodeId.FieldName = "PartsCodeId";
            this.CPartsCodeId.Name = "CPartsCodeId";
            // 
            // CParentPartsCodeId
            // 
            this.CParentPartsCodeId.Caption = "ParentPartsCodeId";
            this.CParentPartsCodeId.FieldName = "ParentPartsCodeId";
            this.CParentPartsCodeId.Name = "CParentPartsCodeId";
            // 
            // CParentCodeFileName
            // 
            this.CParentCodeFileName.Caption = "ParentCodeFileName";
            this.CParentCodeFileName.FieldName = "ParentCodeFileName";
            this.CParentCodeFileName.Name = "CParentCodeFileName";
            // 
            // FrmBomManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1214, 625);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.splitterMiddle);
            this.Controls.Add(this.pnlLeft);
            this.Name = "FrmBomManagement";
            this.TabText = "BOM登记";
            this.Text = "BOM登记";
            this.Load += new System.EventHandler(this.FrmBomManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeft)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).EndInit();
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListBom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).EndInit();
            this.pnlToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dSBom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableBomManagement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSBomManagement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableBomMateriel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSBomMateriel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpMaterieState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMaterielNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPartsCodeId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpPartsCodeIdView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBomMateriel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBomMateriel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchCodeFileName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repbtnDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlLeft;
        private DevExpress.XtraEditors.PanelControl pnlRight;
        private DevExpress.XtraEditors.SplitterControl splitterMiddle;
        private DevExpress.XtraTreeList.TreeList treeListBom;
        private DevExpress.XtraTreeList.Columns.TreeListColumn CAutoId1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn CMaterielNo;
        private DevExpress.XtraEditors.PanelControl pnlToolBar;
        private System.Data.DataSet dSBom;
        private System.Data.DataTable TableBomManagement;
        private System.Data.DataColumn dataColAutoId;
        private System.Data.DataColumn dataColPartsCodeId;
        private System.Data.DataColumn dataColMaterielNo;
        private System.Data.DataColumn dataColMaterieStateId;
        private System.Data.DataColumn dataColMaterieStateText;
        private System.Data.DataColumn dataColGetTime;
        private System.Data.DataColumn dataColCodeFileName;
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
        private DevExpress.XtraEditors.TextEdit textMaterielNo;
        private DevExpress.XtraEditors.LabelControl labMaterielNo;
        private DevExpress.XtraEditors.LabelControl labPartsCodeId;
        private DevExpress.XtraEditors.SearchLookUpEdit searchPartsCodeId;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpPartsCodeIdView;
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
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
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
        private DevExpress.XtraTreeList.Columns.TreeListColumn CPartsCodeId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn CParentPartsCodeId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn CParentCodeFileName;
    }
}