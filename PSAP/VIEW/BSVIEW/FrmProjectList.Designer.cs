namespace PSAP.VIEW.BSVIEW
{
    partial class FrmProjectList
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
            this.dSProjectList = new System.Data.DataSet();
            this.TableProjectList = new System.Data.DataTable();
            this.dataColAutoId = new System.Data.DataColumn();
            this.dataColProjectNo = new System.Data.DataColumn();
            this.dataColBussinessBaseNo = new System.Data.DataColumn();
            this.dataColProjectName = new System.Data.DataColumn();
            this.dataColRemark = new System.Data.DataColumn();
            this.dataColBussinessBaseText = new System.Data.DataColumn();
            this.bSProjectList = new System.Windows.Forms.BindingSource(this.components);
            this.pnlGrid = new DevExpress.XtraEditors.PanelControl();
            this.gridCrlProjectList = new DevExpress.XtraGrid.GridControl();
            this.gridViewProjectList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjectNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBussinessBaseNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBussinessBaseText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlToolBar = new DevExpress.XtraEditors.PanelControl();
            this.btnStnList = new DevExpress.XtraEditors.SimpleButton();
            this.pnlEdit = new DevExpress.XtraEditors.PanelControl();
            this.textRemark = new DevExpress.XtraEditors.TextEdit();
            this.textProjectName = new DevExpress.XtraEditors.TextEdit();
            this.searchLookUpBussinessBaseNo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpBussinessBaseNoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnBussinessBaseNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBussinessBaseText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBussinessCategoryText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textProjectNo = new DevExpress.XtraEditors.TextEdit();
            this.labRemark = new DevExpress.XtraEditors.LabelControl();
            this.labProjectName = new DevExpress.XtraEditors.LabelControl();
            this.labBussinessBaseNo = new DevExpress.XtraEditors.LabelControl();
            this.labProjectNo = new DevExpress.XtraEditors.LabelControl();
            this.dockManagerStn = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.hideContainerRight = new DevExpress.XtraBars.Docking.AutoHideContainer();
            this.dockPanelStn = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanelStn_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiXmbh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKhbnwk = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiXmmcbnwk = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dSProjectList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableProjectList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSProjectList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlProjectList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProjectList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).BeginInit();
            this.pnlToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).BeginInit();
            this.pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textProjectName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpBussinessBaseNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpBussinessBaseNoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textProjectNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManagerStn)).BeginInit();
            this.hideContainerRight.SuspendLayout();
            this.dockPanelStn.SuspendLayout();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // dSProjectList
            // 
            this.dSProjectList.DataSetName = "NewDataSet";
            this.dSProjectList.Tables.AddRange(new System.Data.DataTable[] {
            this.TableProjectList});
            // 
            // TableProjectList
            // 
            this.TableProjectList.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColAutoId,
            this.dataColProjectNo,
            this.dataColBussinessBaseNo,
            this.dataColProjectName,
            this.dataColRemark,
            this.dataColBussinessBaseText});
            this.TableProjectList.TableName = "ProjectList";
            // 
            // dataColAutoId
            // 
            this.dataColAutoId.ColumnName = "AutoId";
            this.dataColAutoId.DataType = typeof(int);
            // 
            // dataColProjectNo
            // 
            this.dataColProjectNo.Caption = "项目号";
            this.dataColProjectNo.ColumnName = "ProjectNo";
            // 
            // dataColBussinessBaseNo
            // 
            this.dataColBussinessBaseNo.Caption = "客户编号";
            this.dataColBussinessBaseNo.ColumnName = "BussinessBaseNo";
            // 
            // dataColProjectName
            // 
            this.dataColProjectName.Caption = "项目名称";
            this.dataColProjectName.ColumnName = "ProjectName";
            // 
            // dataColRemark
            // 
            this.dataColRemark.Caption = "备注";
            this.dataColRemark.ColumnName = "Remark";
            // 
            // dataColBussinessBaseText
            // 
            this.dataColBussinessBaseText.Caption = "客户名称";
            this.dataColBussinessBaseText.ColumnName = "BussinessBaseText";
            // 
            // bSProjectList
            // 
            this.bSProjectList.DataMember = "ProjectList";
            this.bSProjectList.DataSource = this.dSProjectList;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.gridCrlProjectList);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 137);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1104, 497);
            this.pnlGrid.TabIndex = 3;
            // 
            // gridCrlProjectList
            // 
            this.gridCrlProjectList.DataSource = this.bSProjectList;
            this.gridCrlProjectList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCrlProjectList.Location = new System.Drawing.Point(2, 2);
            this.gridCrlProjectList.MainView = this.gridViewProjectList;
            this.gridCrlProjectList.Name = "gridCrlProjectList";
            this.gridCrlProjectList.Size = new System.Drawing.Size(1100, 493);
            this.gridCrlProjectList.TabIndex = 0;
            this.gridCrlProjectList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProjectList});
            // 
            // gridViewProjectList
            // 
            this.gridViewProjectList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId,
            this.colProjectNo,
            this.colBussinessBaseNo,
            this.colBussinessBaseText,
            this.colProjectName,
            this.colRemark});
            this.gridViewProjectList.GridControl = this.gridCrlProjectList;
            this.gridViewProjectList.IndicatorWidth = 40;
            this.gridViewProjectList.Name = "gridViewProjectList";
            this.gridViewProjectList.OptionsBehavior.Editable = false;
            this.gridViewProjectList.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewProjectList.OptionsView.ColumnAutoWidth = false;
            this.gridViewProjectList.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewProjectList.OptionsView.ShowFooter = true;
            this.gridViewProjectList.OptionsView.ShowGroupPanel = false;
            this.gridViewProjectList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewProjectList_CustomDrawRowIndicator);
            this.gridViewProjectList.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewProjectList_FocusedRowChanged);
            // 
            // colAutoId
            // 
            this.colAutoId.FieldName = "AutoId";
            this.colAutoId.Name = "colAutoId";
            // 
            // colProjectNo
            // 
            this.colProjectNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colProjectNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProjectNo.FieldName = "ProjectNo";
            this.colProjectNo.Name = "colProjectNo";
            this.colProjectNo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "ProjectNo", "共计{0}条")});
            this.colProjectNo.Visible = true;
            this.colProjectNo.VisibleIndex = 0;
            this.colProjectNo.Width = 160;
            // 
            // colBussinessBaseNo
            // 
            this.colBussinessBaseNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colBussinessBaseNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBussinessBaseNo.FieldName = "BussinessBaseNo";
            this.colBussinessBaseNo.Name = "colBussinessBaseNo";
            this.colBussinessBaseNo.Visible = true;
            this.colBussinessBaseNo.VisibleIndex = 1;
            this.colBussinessBaseNo.Width = 120;
            // 
            // colBussinessBaseText
            // 
            this.colBussinessBaseText.AppearanceHeader.Options.UseTextOptions = true;
            this.colBussinessBaseText.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBussinessBaseText.FieldName = "BussinessBaseText";
            this.colBussinessBaseText.Name = "colBussinessBaseText";
            this.colBussinessBaseText.Visible = true;
            this.colBussinessBaseText.VisibleIndex = 2;
            this.colBussinessBaseText.Width = 160;
            // 
            // colProjectName
            // 
            this.colProjectName.AppearanceHeader.Options.UseTextOptions = true;
            this.colProjectName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProjectName.FieldName = "ProjectName";
            this.colProjectName.Name = "colProjectName";
            this.colProjectName.Visible = true;
            this.colProjectName.VisibleIndex = 3;
            this.colProjectName.Width = 160;
            // 
            // colRemark
            // 
            this.colRemark.AppearanceHeader.Options.UseTextOptions = true;
            this.colRemark.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 4;
            this.colRemark.Width = 200;
            // 
            // pnlToolBar
            // 
            this.pnlToolBar.Controls.Add(this.btnStnList);
            this.pnlToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolBar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolBar.Name = "pnlToolBar";
            this.pnlToolBar.Size = new System.Drawing.Size(1104, 40);
            this.pnlToolBar.TabIndex = 0;
            // 
            // btnStnList
            // 
            this.btnStnList.Location = new System.Drawing.Point(496, 9);
            this.btnStnList.Name = "btnStnList";
            this.btnStnList.Size = new System.Drawing.Size(75, 23);
            this.btnStnList.TabIndex = 16;
            this.btnStnList.TabStop = false;
            this.btnStnList.Text = "站号";
            this.btnStnList.Click += new System.EventHandler(this.btnStnList_Click);
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.textRemark);
            this.pnlEdit.Controls.Add(this.textProjectName);
            this.pnlEdit.Controls.Add(this.searchLookUpBussinessBaseNo);
            this.pnlEdit.Controls.Add(this.textProjectNo);
            this.pnlEdit.Controls.Add(this.labRemark);
            this.pnlEdit.Controls.Add(this.labProjectName);
            this.pnlEdit.Controls.Add(this.labBussinessBaseNo);
            this.pnlEdit.Controls.Add(this.labProjectNo);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEdit.Location = new System.Drawing.Point(0, 40);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(1104, 97);
            this.pnlEdit.TabIndex = 4;
            // 
            // textRemark
            // 
            this.textRemark.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSProjectList, "Remark", true));
            this.textRemark.Location = new System.Drawing.Point(94, 55);
            this.textRemark.Name = "textRemark";
            this.textRemark.Size = new System.Drawing.Size(643, 20);
            this.textRemark.TabIndex = 3;
            // 
            // textProjectName
            // 
            this.textProjectName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSProjectList, "ProjectName", true));
            this.textProjectName.EnterMoveNextControl = true;
            this.textProjectName.Location = new System.Drawing.Point(577, 21);
            this.textProjectName.Name = "textProjectName";
            this.textProjectName.Size = new System.Drawing.Size(160, 20);
            this.textProjectName.TabIndex = 2;
            // 
            // searchLookUpBussinessBaseNo
            // 
            this.searchLookUpBussinessBaseNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSProjectList, "BussinessBaseNo", true));
            this.searchLookUpBussinessBaseNo.EnterMoveNextControl = true;
            this.searchLookUpBussinessBaseNo.Location = new System.Drawing.Point(321, 21);
            this.searchLookUpBussinessBaseNo.Name = "searchLookUpBussinessBaseNo";
            this.searchLookUpBussinessBaseNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpBussinessBaseNo.Properties.DisplayMember = "BussinessBaseText";
            this.searchLookUpBussinessBaseNo.Properties.NullText = "";
            this.searchLookUpBussinessBaseNo.Properties.ValueMember = "BussinessBaseNo";
            this.searchLookUpBussinessBaseNo.Properties.View = this.searchLookUpBussinessBaseNoView;
            this.searchLookUpBussinessBaseNo.Size = new System.Drawing.Size(160, 20);
            this.searchLookUpBussinessBaseNo.TabIndex = 1;
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
            // textProjectNo
            // 
            this.textProjectNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSProjectList, "ProjectNo", true));
            this.textProjectNo.EnterMoveNextControl = true;
            this.textProjectNo.Location = new System.Drawing.Point(94, 21);
            this.textProjectNo.Name = "textProjectNo";
            this.textProjectNo.Size = new System.Drawing.Size(160, 20);
            this.textProjectNo.TabIndex = 0;
            // 
            // labRemark
            // 
            this.labRemark.Location = new System.Drawing.Point(36, 58);
            this.labRemark.Name = "labRemark";
            this.labRemark.Size = new System.Drawing.Size(24, 14);
            this.labRemark.TabIndex = 15;
            this.labRemark.Text = "备注";
            // 
            // labProjectName
            // 
            this.labProjectName.Location = new System.Drawing.Point(506, 24);
            this.labProjectName.Name = "labProjectName";
            this.labProjectName.Size = new System.Drawing.Size(48, 14);
            this.labProjectName.TabIndex = 14;
            this.labProjectName.Text = "项目名称";
            // 
            // labBussinessBaseNo
            // 
            this.labBussinessBaseNo.Location = new System.Drawing.Point(274, 24);
            this.labBussinessBaseNo.Name = "labBussinessBaseNo";
            this.labBussinessBaseNo.Size = new System.Drawing.Size(24, 14);
            this.labBussinessBaseNo.TabIndex = 13;
            this.labBussinessBaseNo.Text = "客户";
            // 
            // labProjectNo
            // 
            this.labProjectNo.Location = new System.Drawing.Point(36, 24);
            this.labProjectNo.Name = "labProjectNo";
            this.labProjectNo.Size = new System.Drawing.Size(36, 14);
            this.labProjectNo.TabIndex = 12;
            this.labProjectNo.Text = "项目号";
            // 
            // dockManagerStn
            // 
            this.dockManagerStn.AutoHideContainers.AddRange(new DevExpress.XtraBars.Docking.AutoHideContainer[] {
            this.hideContainerRight});
            this.dockManagerStn.Form = this;
            this.dockManagerStn.TopZIndexControls.AddRange(new string[] {
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
            // hideContainerRight
            // 
            this.hideContainerRight.BackColor = System.Drawing.SystemColors.Control;
            this.hideContainerRight.Controls.Add(this.dockPanelStn);
            this.hideContainerRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.hideContainerRight.Location = new System.Drawing.Point(1104, 0);
            this.hideContainerRight.Name = "hideContainerRight";
            this.hideContainerRight.Size = new System.Drawing.Size(20, 634);
            // 
            // dockPanelStn
            // 
            this.dockPanelStn.Controls.Add(this.dockPanelStn_Container);
            this.dockPanelStn.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.dockPanelStn.ID = new System.Guid("ef356686-17f4-4e8c-9635-be178ed8a430");
            this.dockPanelStn.Location = new System.Drawing.Point(0, 0);
            this.dockPanelStn.Name = "dockPanelStn";
            this.dockPanelStn.Options.AllowDockAsTabbedDocument = false;
            this.dockPanelStn.Options.AllowDockBottom = false;
            this.dockPanelStn.Options.AllowDockFill = false;
            this.dockPanelStn.Options.AllowDockLeft = false;
            this.dockPanelStn.Options.AllowDockTop = false;
            this.dockPanelStn.Options.AllowFloating = false;
            this.dockPanelStn.Options.FloatOnDblClick = false;
            this.dockPanelStn.Options.ShowCloseButton = false;
            this.dockPanelStn.Options.ShowMaximizeButton = false;
            this.dockPanelStn.OriginalSize = new System.Drawing.Size(800, 200);
            this.dockPanelStn.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.dockPanelStn.SavedIndex = 0;
            this.dockPanelStn.Size = new System.Drawing.Size(800, 634);
            this.dockPanelStn.Text = "站号";
            this.dockPanelStn.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
            // 
            // dockPanelStn_Container
            // 
            this.dockPanelStn_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanelStn_Container.Name = "dockPanelStn_Container";
            this.dockPanelStn_Container.Size = new System.Drawing.Size(792, 607);
            this.dockPanelStn_Container.TabIndex = 0;
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiXmbh,
            this.tsmiKhbnwk,
            this.tsmiXmmcbnwk});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(269, 92);
            // 
            // tsmiXmbh
            // 
            this.tsmiXmbh.Name = "tsmiXmbh";
            this.tsmiXmbh.Size = new System.Drawing.Size(268, 22);
            this.tsmiXmbh.Text = "项目号编号不能为空，请重新操作。";
            // 
            // tsmiKhbnwk
            // 
            this.tsmiKhbnwk.Name = "tsmiKhbnwk";
            this.tsmiKhbnwk.Size = new System.Drawing.Size(268, 22);
            this.tsmiKhbnwk.Text = "客户不能为空，请重新操作。";
            // 
            // tsmiXmmcbnwk
            // 
            this.tsmiXmmcbnwk.Name = "tsmiXmmcbnwk";
            this.tsmiXmmcbnwk.Size = new System.Drawing.Size(268, 22);
            this.tsmiXmmcbnwk.Text = "项目名称不能为空，请重新操作。";
            // 
            // FrmProjectList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1124, 634);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.pnlToolBar);
            this.Controls.Add(this.hideContainerRight);
            this.Name = "FrmProjectList";
            this.TabText = "项目信息";
            this.Text = "项目信息";
            this.Load += new System.EventHandler(this.FrmProjectList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSProjectList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableProjectList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSProjectList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlProjectList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProjectList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).EndInit();
            this.pnlToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textProjectName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpBussinessBaseNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpBussinessBaseNoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textProjectNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManagerStn)).EndInit();
            this.hideContainerRight.ResumeLayout(false);
            this.dockPanelStn.ResumeLayout(false);
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Data.DataSet dSProjectList;
        private System.Data.DataTable TableProjectList;
        private System.Data.DataColumn dataColAutoId;
        private System.Data.DataColumn dataColProjectNo;
        private System.Data.DataColumn dataColBussinessBaseNo;
        private System.Data.DataColumn dataColProjectName;
        private System.Data.DataColumn dataColRemark;
        private System.Data.DataColumn dataColBussinessBaseText;
        private System.Windows.Forms.BindingSource bSProjectList;
        private DevExpress.XtraEditors.PanelControl pnlGrid;
        private DevExpress.XtraGrid.GridControl gridCrlProjectList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProjectList;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectNo;
        private DevExpress.XtraGrid.Columns.GridColumn colBussinessBaseNo;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectName;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colBussinessBaseText;
        private DevExpress.XtraEditors.PanelControl pnlToolBar;
        private DevExpress.XtraEditors.PanelControl pnlEdit;
        private DevExpress.XtraEditors.TextEdit textRemark;
        private DevExpress.XtraEditors.TextEdit textProjectName;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpBussinessBaseNo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpBussinessBaseNoView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBussinessBaseNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBussinessBaseText;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBussinessCategoryText;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnAutoId;
        private DevExpress.XtraEditors.TextEdit textProjectNo;
        private DevExpress.XtraEditors.LabelControl labRemark;
        private DevExpress.XtraEditors.LabelControl labProjectName;
        private DevExpress.XtraEditors.LabelControl labBussinessBaseNo;
        private DevExpress.XtraEditors.LabelControl labProjectNo;
        private DevExpress.XtraEditors.SimpleButton btnStnList;
        private DevExpress.XtraBars.Docking.DockManager dockManagerStn;
        private DevExpress.XtraBars.Docking.DockPanel dockPanelStn;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanelStn_Container;
        private DevExpress.XtraBars.Docking.AutoHideContainer hideContainerRight;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem tsmiXmbh;
        private System.Windows.Forms.ToolStripMenuItem tsmiKhbnwk;
        private System.Windows.Forms.ToolStripMenuItem tsmiXmmcbnwk;
    }
}