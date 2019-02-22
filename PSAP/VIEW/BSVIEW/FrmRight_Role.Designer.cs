namespace PSAP.VIEW.BSVIEW
{
    partial class FrmRight_Role
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
            this.dSRole = new System.Data.DataSet();
            this.TableRole = new System.Data.DataTable();
            this.dataColAutoId = new System.Data.DataColumn();
            this.dataColRoleNo = new System.Data.DataColumn();
            this.dataColRoleName = new System.Data.DataColumn();
            this.bSRole = new System.Windows.Forms.BindingSource(this.components);
            this.pnlToolBar = new DevExpress.XtraEditors.PanelControl();
            this.pnlEdit = new DevExpress.XtraEditors.PanelControl();
            this.textRoleName = new DevExpress.XtraEditors.TextEdit();
            this.textRoleNo = new DevExpress.XtraEditors.TextEdit();
            this.labRoleName = new DevExpress.XtraEditors.LabelControl();
            this.labRoleNo = new DevExpress.XtraEditors.LabelControl();
            this.pnlBottom = new DevExpress.XtraEditors.PanelControl();
            this.pnlGrid = new DevExpress.XtraEditors.PanelControl();
            this.gridCrlRole = new DevExpress.XtraGrid.GridControl();
            this.gridViewRole = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoleNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitterMiddle = new DevExpress.XtraEditors.SplitterControl();
            this.pnlTreeList = new DevExpress.XtraEditors.PanelControl();
            this.treeListRole = new DevExpress.XtraTreeList.TreeList();
            this.colAutoId1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colMenuText1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colFormName1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colFormText1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colMenuOrder1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colMenuName1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colParentMenuName1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colParentMenuText1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dSRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).BeginInit();
            this.pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textRoleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRoleNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).BeginInit();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTreeList)).BeginInit();
            this.pnlTreeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListRole)).BeginInit();
            this.SuspendLayout();
            // 
            // dSRole
            // 
            this.dSRole.DataSetName = "NewDataSet";
            this.dSRole.Tables.AddRange(new System.Data.DataTable[] {
            this.TableRole});
            // 
            // TableRole
            // 
            this.TableRole.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColAutoId,
            this.dataColRoleNo,
            this.dataColRoleName});
            this.TableRole.TableName = "Role";
            // 
            // dataColAutoId
            // 
            this.dataColAutoId.ColumnName = "AutoId";
            this.dataColAutoId.DataType = typeof(int);
            // 
            // dataColRoleNo
            // 
            this.dataColRoleNo.Caption = "角色编号";
            this.dataColRoleNo.ColumnName = "RoleNo";
            // 
            // dataColRoleName
            // 
            this.dataColRoleName.Caption = "角色名称";
            this.dataColRoleName.ColumnName = "RoleName";
            // 
            // bSRole
            // 
            this.bSRole.DataMember = "Role";
            this.bSRole.DataSource = this.dSRole;
            // 
            // pnlToolBar
            // 
            this.pnlToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolBar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolBar.Name = "pnlToolBar";
            this.pnlToolBar.Size = new System.Drawing.Size(987, 40);
            this.pnlToolBar.TabIndex = 9;
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.textRoleName);
            this.pnlEdit.Controls.Add(this.textRoleNo);
            this.pnlEdit.Controls.Add(this.labRoleName);
            this.pnlEdit.Controls.Add(this.labRoleNo);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEdit.Location = new System.Drawing.Point(0, 40);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(987, 68);
            this.pnlEdit.TabIndex = 10;
            // 
            // textRoleName
            // 
            this.textRoleName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSRole, "RoleName", true));
            this.textRoleName.Location = new System.Drawing.Point(385, 21);
            this.textRoleName.Name = "textRoleName";
            this.textRoleName.Size = new System.Drawing.Size(160, 20);
            this.textRoleName.TabIndex = 1;
            // 
            // textRoleNo
            // 
            this.textRoleNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSRole, "RoleNo", true));
            this.textRoleNo.EnterMoveNextControl = true;
            this.textRoleNo.Location = new System.Drawing.Point(106, 21);
            this.textRoleNo.Name = "textRoleNo";
            this.textRoleNo.Size = new System.Drawing.Size(160, 20);
            this.textRoleNo.TabIndex = 0;
            // 
            // labRoleName
            // 
            this.labRoleName.Location = new System.Drawing.Point(312, 24);
            this.labRoleName.Name = "labRoleName";
            this.labRoleName.Size = new System.Drawing.Size(48, 14);
            this.labRoleName.TabIndex = 15;
            this.labRoleName.Text = "角色名称";
            // 
            // labRoleNo
            // 
            this.labRoleNo.Location = new System.Drawing.Point(36, 24);
            this.labRoleNo.Name = "labRoleNo";
            this.labRoleNo.Size = new System.Drawing.Size(48, 14);
            this.labRoleNo.TabIndex = 12;
            this.labRoleNo.Text = "角色编号";
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.pnlGrid);
            this.pnlBottom.Controls.Add(this.splitterMiddle);
            this.pnlBottom.Controls.Add(this.pnlTreeList);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(0, 108);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(987, 462);
            this.pnlBottom.TabIndex = 11;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.gridCrlRole);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(2, 2);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(578, 458);
            this.pnlGrid.TabIndex = 11;
            // 
            // gridCrlRole
            // 
            this.gridCrlRole.DataSource = this.bSRole;
            this.gridCrlRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCrlRole.Location = new System.Drawing.Point(2, 2);
            this.gridCrlRole.MainView = this.gridViewRole;
            this.gridCrlRole.Name = "gridCrlRole";
            this.gridCrlRole.Size = new System.Drawing.Size(574, 454);
            this.gridCrlRole.TabIndex = 0;
            this.gridCrlRole.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRole});
            // 
            // gridViewRole
            // 
            this.gridViewRole.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId,
            this.colRoleNo,
            this.colRoleName});
            this.gridViewRole.GridControl = this.gridCrlRole;
            this.gridViewRole.IndicatorWidth = 40;
            this.gridViewRole.Name = "gridViewRole";
            this.gridViewRole.OptionsBehavior.Editable = false;
            this.gridViewRole.OptionsFilter.AllowFilterEditor = false;
            this.gridViewRole.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewRole.OptionsView.ColumnAutoWidth = false;
            this.gridViewRole.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewRole.OptionsView.ShowFooter = true;
            this.gridViewRole.OptionsView.ShowGroupPanel = false;
            this.gridViewRole.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewRole_CustomDrawRowIndicator);
            this.gridViewRole.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewRole_FocusedRowChanged);
            // 
            // colAutoId
            // 
            this.colAutoId.FieldName = "AutoId";
            this.colAutoId.Name = "colAutoId";
            // 
            // colRoleNo
            // 
            this.colRoleNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colRoleNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRoleNo.FieldName = "RoleNo";
            this.colRoleNo.Name = "colRoleNo";
            this.colRoleNo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "RoleNo", "共计{0}条")});
            this.colRoleNo.Visible = true;
            this.colRoleNo.VisibleIndex = 0;
            this.colRoleNo.Width = 150;
            // 
            // colRoleName
            // 
            this.colRoleName.AppearanceHeader.Options.UseTextOptions = true;
            this.colRoleName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRoleName.FieldName = "RoleName";
            this.colRoleName.Name = "colRoleName";
            this.colRoleName.Visible = true;
            this.colRoleName.VisibleIndex = 1;
            this.colRoleName.Width = 150;
            // 
            // splitterMiddle
            // 
            this.splitterMiddle.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.splitterMiddle.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitterMiddle.Location = new System.Drawing.Point(580, 2);
            this.splitterMiddle.Name = "splitterMiddle";
            this.splitterMiddle.Size = new System.Drawing.Size(5, 458);
            this.splitterMiddle.TabIndex = 14;
            this.splitterMiddle.TabStop = false;
            // 
            // pnlTreeList
            // 
            this.pnlTreeList.Controls.Add(this.treeListRole);
            this.pnlTreeList.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTreeList.Location = new System.Drawing.Point(585, 2);
            this.pnlTreeList.Name = "pnlTreeList";
            this.pnlTreeList.Size = new System.Drawing.Size(400, 458);
            this.pnlTreeList.TabIndex = 12;
            // 
            // treeListRole
            // 
            this.treeListRole.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colAutoId1,
            this.colMenuText1,
            this.colFormName1,
            this.colFormText1,
            this.colMenuOrder1,
            this.colMenuName1,
            this.colParentMenuName1,
            this.colParentMenuText1});
            this.treeListRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListRole.Enabled = false;
            this.treeListRole.KeyFieldName = "MenuName";
            this.treeListRole.Location = new System.Drawing.Point(2, 2);
            this.treeListRole.Name = "treeListRole";
            this.treeListRole.OptionsBehavior.Editable = false;
            this.treeListRole.OptionsBehavior.ReadOnly = true;
            this.treeListRole.OptionsClipboard.AllowCopy = DevExpress.Utils.DefaultBoolean.True;
            this.treeListRole.OptionsClipboard.CopyNodeHierarchy = DevExpress.Utils.DefaultBoolean.True;
            this.treeListRole.OptionsView.EnableAppearanceEvenRow = true;
            this.treeListRole.OptionsView.EnableAppearanceOddRow = true;
            this.treeListRole.OptionsView.ShowCheckBoxes = true;
            this.treeListRole.OptionsView.ShowColumns = false;
            this.treeListRole.OptionsView.ShowHorzLines = false;
            this.treeListRole.OptionsView.ShowIndicator = false;
            this.treeListRole.OptionsView.ShowVertLines = false;
            this.treeListRole.ParentFieldName = "ParentMenuName";
            this.treeListRole.Size = new System.Drawing.Size(396, 454);
            this.treeListRole.TabIndex = 2;
            this.treeListRole.BeforeCheckNode += new DevExpress.XtraTreeList.CheckNodeEventHandler(this.treeListRole_BeforeCheckNode);
            this.treeListRole.AfterCheckNode += new DevExpress.XtraTreeList.NodeEventHandler(this.treeListRole_AfterCheckNode);
            // 
            // colAutoId1
            // 
            this.colAutoId1.FieldName = "AutoId";
            this.colAutoId1.Name = "colAutoId1";
            this.colAutoId1.Width = 34;
            // 
            // colMenuText1
            // 
            this.colMenuText1.FieldName = "MenuText";
            this.colMenuText1.MinWidth = 32;
            this.colMenuText1.Name = "colMenuText1";
            this.colMenuText1.Visible = true;
            this.colMenuText1.VisibleIndex = 0;
            this.colMenuText1.Width = 41;
            // 
            // colFormName1
            // 
            this.colFormName1.FieldName = "FormName";
            this.colFormName1.Name = "colFormName1";
            this.colFormName1.Width = 41;
            // 
            // colFormText1
            // 
            this.colFormText1.FieldName = "FormText";
            this.colFormText1.Name = "colFormText1";
            this.colFormText1.Width = 41;
            // 
            // colMenuOrder1
            // 
            this.colMenuOrder1.FieldName = "MenuOrder";
            this.colMenuOrder1.Name = "colMenuOrder1";
            this.colMenuOrder1.Width = 40;
            // 
            // colMenuName1
            // 
            this.colMenuName1.FieldName = "MenuName";
            this.colMenuName1.Name = "colMenuName1";
            // 
            // colParentMenuName1
            // 
            this.colParentMenuName1.FieldName = "ParentMenuName";
            this.colParentMenuName1.Name = "colParentMenuName1";
            // 
            // colParentMenuText1
            // 
            this.colParentMenuText1.FieldName = "ParentMenuText";
            this.colParentMenuText1.Name = "colParentMenuText1";
            // 
            // FrmRight_Role
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(987, 570);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.pnlToolBar);
            this.Name = "FrmRight_Role";
            this.TabText = "角色权限管理";
            this.Text = "角色权限管理";
            this.Load += new System.EventHandler(this.FrmRight_Role_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textRoleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRoleNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTreeList)).EndInit();
            this.pnlTreeList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListRole)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dSRole;
        private System.Data.DataTable TableRole;
        private System.Data.DataColumn dataColAutoId;
        private System.Data.DataColumn dataColRoleNo;
        private System.Data.DataColumn dataColRoleName;
        private System.Windows.Forms.BindingSource bSRole;
        private DevExpress.XtraEditors.PanelControl pnlToolBar;
        private DevExpress.XtraEditors.PanelControl pnlEdit;
        private DevExpress.XtraEditors.TextEdit textRoleName;
        private DevExpress.XtraEditors.TextEdit textRoleNo;
        private DevExpress.XtraEditors.LabelControl labRoleName;
        private DevExpress.XtraEditors.LabelControl labRoleNo;
        private DevExpress.XtraEditors.PanelControl pnlBottom;
        private DevExpress.XtraEditors.PanelControl pnlGrid;
        private DevExpress.XtraGrid.GridControl gridCrlRole;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRole;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colRoleNo;
        private DevExpress.XtraGrid.Columns.GridColumn colRoleName;
        private DevExpress.XtraEditors.PanelControl pnlTreeList;
        private DevExpress.XtraTreeList.TreeList treeListRole;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colAutoId1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colMenuText1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colFormName1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colFormText1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colMenuOrder1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colMenuName1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colParentMenuName1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colParentMenuText1;
        private DevExpress.XtraEditors.SplitterControl splitterMiddle;
    }
}