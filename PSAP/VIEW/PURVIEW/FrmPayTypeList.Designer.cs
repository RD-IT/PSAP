namespace PSAP.VIEW.BSVIEW
{
    partial class FrmPayTypeList
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
            this.dSPayTypeList = new System.Data.DataSet();
            this.TablePayTypeList = new System.Data.DataTable();
            this.dataColAutoId = new System.Data.DataColumn();
            this.dataColPayTypeNo = new System.Data.DataColumn();
            this.dataColPayPercentum = new System.Data.DataColumn();
            this.dataColPayPercentumText = new System.Data.DataColumn();
            this.bSPayTypeList = new System.Windows.Forms.BindingSource(this.components);
            this.pnlToolBar = new DevExpress.XtraEditors.PanelControl();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.pnlGrid = new DevExpress.XtraEditors.PanelControl();
            this.gridCrlPayTypeList = new DevExpress.XtraGrid.GridControl();
            this.gridViewPayTypeList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPayTypeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repItemLookUpPayType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colPayPercentum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repItemSpinPayPercentum = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colPayPercentumText = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dSPayTypeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablePayTypeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSPayTypeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).BeginInit();
            this.pnlToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlPayTypeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPayTypeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemLookUpPayType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemSpinPayPercentum)).BeginInit();
            this.SuspendLayout();
            // 
            // dSPayTypeList
            // 
            this.dSPayTypeList.DataSetName = "NewDataSet";
            this.dSPayTypeList.Tables.AddRange(new System.Data.DataTable[] {
            this.TablePayTypeList});
            // 
            // TablePayTypeList
            // 
            this.TablePayTypeList.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColAutoId,
            this.dataColPayTypeNo,
            this.dataColPayPercentum,
            this.dataColPayPercentumText});
            this.TablePayTypeList.TableName = "PayTypeList";
            this.TablePayTypeList.TableNewRow += new System.Data.DataTableNewRowEventHandler(this.TablePayTypeList_TableNewRow);
            // 
            // dataColAutoId
            // 
            this.dataColAutoId.ColumnName = "AutoId";
            this.dataColAutoId.DataType = typeof(int);
            // 
            // dataColPayTypeNo
            // 
            this.dataColPayTypeNo.Caption = "审批类型编码";
            this.dataColPayTypeNo.ColumnName = "PayTypeNo";
            // 
            // dataColPayPercentum
            // 
            this.dataColPayPercentum.Caption = "付款百分比";
            this.dataColPayPercentum.ColumnName = "PayPercentum";
            this.dataColPayPercentum.DataType = typeof(int);
            // 
            // dataColPayPercentumText
            // 
            this.dataColPayPercentumText.Caption = "付款百分比说明";
            this.dataColPayPercentumText.ColumnName = "PayPercentumText";
            // 
            // bSPayTypeList
            // 
            this.bSPayTypeList.DataMember = "PayTypeList";
            this.bSPayTypeList.DataSource = this.dSPayTypeList;
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
            this.pnlToolBar.TabIndex = 5;
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
            this.pnlGrid.Controls.Add(this.gridCrlPayTypeList);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 40);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(584, 321);
            this.pnlGrid.TabIndex = 11;
            // 
            // gridCrlPayTypeList
            // 
            this.gridCrlPayTypeList.DataSource = this.bSPayTypeList;
            this.gridCrlPayTypeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCrlPayTypeList.Location = new System.Drawing.Point(2, 2);
            this.gridCrlPayTypeList.MainView = this.gridViewPayTypeList;
            this.gridCrlPayTypeList.Name = "gridCrlPayTypeList";
            this.gridCrlPayTypeList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repItemLookUpPayType,
            this.repItemSpinPayPercentum});
            this.gridCrlPayTypeList.Size = new System.Drawing.Size(580, 317);
            this.gridCrlPayTypeList.TabIndex = 8;
            this.gridCrlPayTypeList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPayTypeList});
            // 
            // gridViewPayTypeList
            // 
            this.gridViewPayTypeList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId,
            this.colPayTypeNo,
            this.colPayPercentum,
            this.colPayPercentumText});
            this.gridViewPayTypeList.GridControl = this.gridCrlPayTypeList;
            this.gridViewPayTypeList.IndicatorWidth = 40;
            this.gridViewPayTypeList.Name = "gridViewPayTypeList";
            this.gridViewPayTypeList.OptionsFilter.AllowFilterEditor = false;
            this.gridViewPayTypeList.OptionsView.ColumnAutoWidth = false;
            this.gridViewPayTypeList.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewPayTypeList.OptionsView.ShowFooter = true;
            this.gridViewPayTypeList.OptionsView.ShowGroupPanel = false;
            this.gridViewPayTypeList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewPayTypeList_CustomDrawRowIndicator);
            // 
            // colAutoId
            // 
            this.colAutoId.FieldName = "AutoId";
            this.colAutoId.Name = "colAutoId";
            // 
            // colPayTypeNo
            // 
            this.colPayTypeNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colPayTypeNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPayTypeNo.ColumnEdit = this.repItemLookUpPayType;
            this.colPayTypeNo.FieldName = "PayTypeNo";
            this.colPayTypeNo.Name = "colPayTypeNo";
            this.colPayTypeNo.OptionsColumn.AllowEdit = false;
            this.colPayTypeNo.OptionsColumn.AllowFocus = false;
            this.colPayTypeNo.Visible = true;
            this.colPayTypeNo.VisibleIndex = 0;
            this.colPayTypeNo.Width = 120;
            // 
            // repItemLookUpPayType
            // 
            this.repItemLookUpPayType.AutoHeight = false;
            this.repItemLookUpPayType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repItemLookUpPayType.DisplayMember = "PayTypeNoText";
            this.repItemLookUpPayType.Name = "repItemLookUpPayType";
            this.repItemLookUpPayType.NullText = "";
            this.repItemLookUpPayType.ValueMember = "PayTypeNo";
            // 
            // colPayPercentum
            // 
            this.colPayPercentum.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.colPayPercentum.AppearanceHeader.Options.UseForeColor = true;
            this.colPayPercentum.AppearanceHeader.Options.UseTextOptions = true;
            this.colPayPercentum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPayPercentum.ColumnEdit = this.repItemSpinPayPercentum;
            this.colPayPercentum.FieldName = "PayPercentum";
            this.colPayPercentum.Name = "colPayPercentum";
            this.colPayPercentum.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PayPercentum", "{0:0.##}")});
            this.colPayPercentum.Visible = true;
            this.colPayPercentum.VisibleIndex = 1;
            this.colPayPercentum.Width = 120;
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
            // colPayPercentumText
            // 
            this.colPayPercentumText.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.colPayPercentumText.AppearanceHeader.Options.UseForeColor = true;
            this.colPayPercentumText.AppearanceHeader.Options.UseTextOptions = true;
            this.colPayPercentumText.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPayPercentumText.FieldName = "PayPercentumText";
            this.colPayPercentumText.Name = "colPayPercentumText";
            this.colPayPercentumText.Visible = true;
            this.colPayPercentumText.VisibleIndex = 2;
            this.colPayPercentumText.Width = 150;
            // 
            // FrmPayTypeList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlToolBar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPayTypeList";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabText = "付款类型信息";
            this.Text = "付款类型信息";
            this.Load += new System.EventHandler(this.FrmPayTypeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSPayTypeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablePayTypeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSPayTypeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).EndInit();
            this.pnlToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlPayTypeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPayTypeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemLookUpPayType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemSpinPayPercentum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dSPayTypeList;
        private System.Data.DataTable TablePayTypeList;
        private System.Data.DataColumn dataColAutoId;
        private System.Data.DataColumn dataColPayTypeNo;
        private System.Data.DataColumn dataColPayPercentum;
        private System.Data.DataColumn dataColPayPercentumText;
        private System.Windows.Forms.BindingSource bSPayTypeList;
        private DevExpress.XtraEditors.PanelControl pnlToolBar;
        private DevExpress.XtraEditors.PanelControl pnlGrid;
        private DevExpress.XtraGrid.GridControl gridCrlPayTypeList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPayTypeList;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colPayTypeNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPayPercentum;
        private DevExpress.XtraGrid.Columns.GridColumn colPayPercentumText;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repItemLookUpPayType;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repItemSpinPayPercentum;
    }
}