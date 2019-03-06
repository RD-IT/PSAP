namespace PSAP.VIEW.BSVIEW
{
    partial class FrmCollectionTypeList
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
            this.dSCollectionTypeList = new System.Data.DataSet();
            this.TableCollectionTypeList = new System.Data.DataTable();
            this.dataColAutoId = new System.Data.DataColumn();
            this.dataColCollectionTypeNo = new System.Data.DataColumn();
            this.dataColPayPercentum = new System.Data.DataColumn();
            this.dataColPayPercentumText = new System.Data.DataColumn();
            this.bSCollectionTypeList = new System.Windows.Forms.BindingSource(this.components);
            this.pnlToolBar = new DevExpress.XtraEditors.PanelControl();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.pnlGrid = new DevExpress.XtraEditors.PanelControl();
            this.gridCrlCollectionTypeList = new DevExpress.XtraGrid.GridControl();
            this.gridViewCollectionTypeList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCollectionTypeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repItemLookUpCollectionType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colCollectionPercentum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repItemSpinPayPercentum = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colCollectionPercentumText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSklx = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDxx = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSkbfbdhj = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dSCollectionTypeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableCollectionTypeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSCollectionTypeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).BeginInit();
            this.pnlToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlCollectionTypeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCollectionTypeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemLookUpCollectionType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemSpinPayPercentum)).BeginInit();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // dSCollectionTypeList
            // 
            this.dSCollectionTypeList.DataSetName = "NewDataSet";
            this.dSCollectionTypeList.Tables.AddRange(new System.Data.DataTable[] {
            this.TableCollectionTypeList});
            // 
            // TableCollectionTypeList
            // 
            this.TableCollectionTypeList.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColAutoId,
            this.dataColCollectionTypeNo,
            this.dataColPayPercentum,
            this.dataColPayPercentumText});
            this.TableCollectionTypeList.TableName = "CollectionTypeList";
            this.TableCollectionTypeList.TableNewRow += new System.Data.DataTableNewRowEventHandler(this.TableCollectionTypeList_TableNewRow);
            // 
            // dataColAutoId
            // 
            this.dataColAutoId.ColumnName = "AutoId";
            this.dataColAutoId.DataType = typeof(int);
            // 
            // dataColCollectionTypeNo
            // 
            this.dataColCollectionTypeNo.Caption = "收款类型";
            this.dataColCollectionTypeNo.ColumnName = "CollectionTypeNo";
            // 
            // dataColPayPercentum
            // 
            this.dataColPayPercentum.Caption = "收款百分比";
            this.dataColPayPercentum.ColumnName = "CollectionPercentum";
            this.dataColPayPercentum.DataType = typeof(int);
            // 
            // dataColPayPercentumText
            // 
            this.dataColPayPercentumText.Caption = "收款百分比说明";
            this.dataColPayPercentumText.ColumnName = "CollectionPercentumText";
            // 
            // bSCollectionTypeList
            // 
            this.bSCollectionTypeList.DataMember = "CollectionTypeList";
            this.bSCollectionTypeList.DataSource = this.dSCollectionTypeList;
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
            this.pnlToolBar.Size = new System.Drawing.Size(584, 40);
            this.pnlToolBar.TabIndex = 6;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(333, 9);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(252, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(171, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(90, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "修改";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(9, 9);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "新增";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.gridCrlCollectionTypeList);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 40);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(584, 322);
            this.pnlGrid.TabIndex = 12;
            // 
            // gridCrlCollectionTypeList
            // 
            this.gridCrlCollectionTypeList.DataSource = this.bSCollectionTypeList;
            this.gridCrlCollectionTypeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCrlCollectionTypeList.Location = new System.Drawing.Point(2, 2);
            this.gridCrlCollectionTypeList.MainView = this.gridViewCollectionTypeList;
            this.gridCrlCollectionTypeList.Name = "gridCrlCollectionTypeList";
            this.gridCrlCollectionTypeList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repItemLookUpCollectionType,
            this.repItemSpinPayPercentum});
            this.gridCrlCollectionTypeList.Size = new System.Drawing.Size(580, 318);
            this.gridCrlCollectionTypeList.TabIndex = 8;
            this.gridCrlCollectionTypeList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCollectionTypeList});
            // 
            // gridViewCollectionTypeList
            // 
            this.gridViewCollectionTypeList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId,
            this.colCollectionTypeNo,
            this.colCollectionPercentum,
            this.colCollectionPercentumText});
            this.gridViewCollectionTypeList.GridControl = this.gridCrlCollectionTypeList;
            this.gridViewCollectionTypeList.IndicatorWidth = 40;
            this.gridViewCollectionTypeList.Name = "gridViewCollectionTypeList";
            this.gridViewCollectionTypeList.OptionsFilter.AllowFilterEditor = false;
            this.gridViewCollectionTypeList.OptionsView.ColumnAutoWidth = false;
            this.gridViewCollectionTypeList.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewCollectionTypeList.OptionsView.ShowFooter = true;
            this.gridViewCollectionTypeList.OptionsView.ShowGroupPanel = false;
            this.gridViewCollectionTypeList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewCollectionTypeList_CustomDrawRowIndicator);
            // 
            // colAutoId
            // 
            this.colAutoId.FieldName = "AutoId";
            this.colAutoId.Name = "colAutoId";
            // 
            // colCollectionTypeNo
            // 
            this.colCollectionTypeNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colCollectionTypeNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCollectionTypeNo.ColumnEdit = this.repItemLookUpCollectionType;
            this.colCollectionTypeNo.FieldName = "CollectionTypeNo";
            this.colCollectionTypeNo.Name = "colCollectionTypeNo";
            this.colCollectionTypeNo.OptionsColumn.AllowEdit = false;
            this.colCollectionTypeNo.OptionsColumn.AllowFocus = false;
            this.colCollectionTypeNo.Visible = true;
            this.colCollectionTypeNo.VisibleIndex = 0;
            this.colCollectionTypeNo.Width = 120;
            // 
            // repItemLookUpCollectionType
            // 
            this.repItemLookUpCollectionType.AutoHeight = false;
            this.repItemLookUpCollectionType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repItemLookUpCollectionType.DisplayMember = "CollectionTypeNoText";
            this.repItemLookUpCollectionType.Name = "repItemLookUpCollectionType";
            this.repItemLookUpCollectionType.NullText = "";
            this.repItemLookUpCollectionType.ValueMember = "CollectionTypeNo";
            // 
            // colCollectionPercentum
            // 
            this.colCollectionPercentum.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.colCollectionPercentum.AppearanceHeader.Options.UseForeColor = true;
            this.colCollectionPercentum.AppearanceHeader.Options.UseTextOptions = true;
            this.colCollectionPercentum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCollectionPercentum.ColumnEdit = this.repItemSpinPayPercentum;
            this.colCollectionPercentum.FieldName = "CollectionPercentum";
            this.colCollectionPercentum.Name = "colCollectionPercentum";
            this.colCollectionPercentum.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CollectionPercentum", "{0:0.##}")});
            this.colCollectionPercentum.Visible = true;
            this.colCollectionPercentum.VisibleIndex = 1;
            this.colCollectionPercentum.Width = 120;
            // 
            // repItemSpinPayPercentum
            // 
            this.repItemSpinPayPercentum.AutoHeight = false;
            this.repItemSpinPayPercentum.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repItemSpinPayPercentum.Mask.EditMask = "d";
            this.repItemSpinPayPercentum.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.repItemSpinPayPercentum.Name = "repItemSpinPayPercentum";
            // 
            // colCollectionPercentumText
            // 
            this.colCollectionPercentumText.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.colCollectionPercentumText.AppearanceHeader.Options.UseForeColor = true;
            this.colCollectionPercentumText.AppearanceHeader.Options.UseTextOptions = true;
            this.colCollectionPercentumText.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCollectionPercentumText.FieldName = "CollectionPercentumText";
            this.colCollectionPercentumText.Name = "colCollectionPercentumText";
            this.colCollectionPercentumText.Visible = true;
            this.colCollectionPercentumText.VisibleIndex = 2;
            this.colCollectionPercentumText.Width = 150;
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSklx,
            this.tsmiDxx,
            this.tsmiSkbfbdhj});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(314, 92);
            // 
            // tsmiSklx
            // 
            this.tsmiSklx.Name = "tsmiSklx";
            this.tsmiSklx.Size = new System.Drawing.Size(313, 22);
            this.tsmiSklx.Text = "收款类型";
            // 
            // tsmiDxx
            // 
            this.tsmiDxx.Name = "tsmiDxx";
            this.tsmiDxx.Size = new System.Drawing.Size(313, 22);
            this.tsmiDxx.Text = "的信息";
            // 
            // tsmiSkbfbdhj
            // 
            this.tsmiSkbfbdhj.Name = "tsmiSkbfbdhj";
            this.tsmiSkbfbdhj.Size = new System.Drawing.Size(313, 22);
            this.tsmiSkbfbdhj.Text = "收款百分比的合计必须是100，请重新操作。";
            // 
            // FrmCollectionTypeList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlToolBar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FrmCollectionTypeList";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabText = "收款类型信息";
            this.Text = "收款类型信息";
            this.Load += new System.EventHandler(this.FrmCollectionTypeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSCollectionTypeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableCollectionTypeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSCollectionTypeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).EndInit();
            this.pnlToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlCollectionTypeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCollectionTypeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemLookUpCollectionType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemSpinPayPercentum)).EndInit();
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dSCollectionTypeList;
        private System.Data.DataTable TableCollectionTypeList;
        private System.Data.DataColumn dataColAutoId;
        private System.Data.DataColumn dataColCollectionTypeNo;
        private System.Data.DataColumn dataColPayPercentum;
        private System.Data.DataColumn dataColPayPercentumText;
        private System.Windows.Forms.BindingSource bSCollectionTypeList;
        private DevExpress.XtraEditors.PanelControl pnlToolBar;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.PanelControl pnlGrid;
        private DevExpress.XtraGrid.GridControl gridCrlCollectionTypeList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCollectionTypeList;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colCollectionTypeNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repItemLookUpCollectionType;
        private DevExpress.XtraGrid.Columns.GridColumn colCollectionPercentum;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repItemSpinPayPercentum;
        private DevExpress.XtraGrid.Columns.GridColumn colCollectionPercentumText;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem tsmiSklx;
        private System.Windows.Forms.ToolStripMenuItem tsmiDxx;
        private System.Windows.Forms.ToolStripMenuItem tsmiSkbfbdhj;
    }
}