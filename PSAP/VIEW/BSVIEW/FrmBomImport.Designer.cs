namespace PSAP.VIEW.BSVIEW
{
    partial class FrmBomImport
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
            this.groupTop = new DevExpress.XtraEditors.GroupControl();
            this.btnSaveAs = new DevExpress.XtraEditors.SimpleButton();
            this.btnMother = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxMother = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labColumnName = new DevExpress.XtraEditors.LabelControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnModuleDownload = new DevExpress.XtraEditors.SimpleButton();
            this.btnExcel2007 = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdateDB = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.bSBom = new System.Windows.Forms.BindingSource(this.components);
            this.dSBom = new System.Data.DataSet();
            this.TableBom = new System.Data.DataTable();
            this.dataColMotherCodeFileName = new System.Data.DataColumn();
            this.dataColMotherCodeName = new System.Data.DataColumn();
            this.dataColSubCodeFileName = new System.Data.DataColumn();
            this.dataColSubCodeName = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.gridCrlBom = new DevExpress.XtraGrid.GridControl();
            this.gridViewBom = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMotherCodeFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSearchCodeFileName = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repSearchCodeFileNameView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColuAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColuCodeFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColuCodeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMotherCodeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubCodeFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubCodeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSpinQty = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupTop)).BeginInit();
            this.groupTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxMother.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSBom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSBom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableBom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlBom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchCodeFileName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchCodeFileNameView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinQty)).BeginInit();
            this.SuspendLayout();
            // 
            // groupTop
            // 
            this.groupTop.Controls.Add(this.btnSaveAs);
            this.groupTop.Controls.Add(this.btnMother);
            this.groupTop.Controls.Add(this.comboBoxMother);
            this.groupTop.Controls.Add(this.labColumnName);
            this.groupTop.Controls.Add(this.btnDelete);
            this.groupTop.Controls.Add(this.btnModuleDownload);
            this.groupTop.Controls.Add(this.btnExcel2007);
            this.groupTop.Controls.Add(this.btnUpdateDB);
            this.groupTop.Controls.Add(this.btnClear);
            this.groupTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupTop.Location = new System.Drawing.Point(0, 0);
            this.groupTop.Name = "groupTop";
            this.groupTop.Size = new System.Drawing.Size(1116, 126);
            this.groupTop.TabIndex = 0;
            this.groupTop.Text = "Bom信息导入设定";
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Location = new System.Drawing.Point(621, 40);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAs.TabIndex = 13;
            this.btnSaveAs.Text = "另存为";
            this.btnSaveAs.Visible = false;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // btnMother
            // 
            this.btnMother.Location = new System.Drawing.Point(500, 81);
            this.btnMother.Name = "btnMother";
            this.btnMother.Size = new System.Drawing.Size(130, 23);
            this.btnMother.TabIndex = 12;
            this.btnMother.Text = "删除母物料Bom信息";
            this.btnMother.Click += new System.EventHandler(this.btnMother_Click);
            // 
            // comboBoxMother
            // 
            this.comboBoxMother.Location = new System.Drawing.Point(278, 82);
            this.comboBoxMother.Name = "comboBoxMother";
            this.comboBoxMother.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxMother.Size = new System.Drawing.Size(200, 20);
            this.comboBoxMother.TabIndex = 11;
            // 
            // labColumnName
            // 
            this.labColumnName.Location = new System.Drawing.Point(191, 85);
            this.labColumnName.Name = "labColumnName";
            this.labColumnName.Size = new System.Drawing.Size(60, 14);
            this.labColumnName.TabIndex = 10;
            this.labColumnName.Text = "母物料编号";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(35, 81);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "删除行";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModuleDownload
            // 
            this.btnModuleDownload.Location = new System.Drawing.Point(157, 40);
            this.btnModuleDownload.Name = "btnModuleDownload";
            this.btnModuleDownload.Size = new System.Drawing.Size(75, 23);
            this.btnModuleDownload.TabIndex = 5;
            this.btnModuleDownload.Text = "模板下载";
            this.btnModuleDownload.Click += new System.EventHandler(this.btnModuleDownload_Click);
            // 
            // btnExcel2007
            // 
            this.btnExcel2007.Location = new System.Drawing.Point(35, 40);
            this.btnExcel2007.Name = "btnExcel2007";
            this.btnExcel2007.Size = new System.Drawing.Size(100, 23);
            this.btnExcel2007.TabIndex = 4;
            this.btnExcel2007.Text = "导入Excel 数据";
            this.btnExcel2007.Click += new System.EventHandler(this.btnExcel2007_Click);
            // 
            // btnUpdateDB
            // 
            this.btnUpdateDB.Location = new System.Drawing.Point(452, 40);
            this.btnUpdateDB.Name = "btnUpdateDB";
            this.btnUpdateDB.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateDB.TabIndex = 7;
            this.btnUpdateDB.Text = "更新数据库";
            this.btnUpdateDB.Click += new System.EventHandler(this.btnUpdateDB_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(358, 40);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "清空数据";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // bSBom
            // 
            this.bSBom.DataMember = "Bom";
            this.bSBom.DataSource = this.dSBom;
            // 
            // dSBom
            // 
            this.dSBom.DataSetName = "NewDataSet";
            this.dSBom.Tables.AddRange(new System.Data.DataTable[] {
            this.TableBom});
            // 
            // TableBom
            // 
            this.TableBom.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColMotherCodeFileName,
            this.dataColMotherCodeName,
            this.dataColSubCodeFileName,
            this.dataColSubCodeName,
            this.dataColumn1});
            this.TableBom.TableName = "Bom";
            // 
            // dataColMotherCodeFileName
            // 
            this.dataColMotherCodeFileName.Caption = "母物料编号(MotherCodeFileName)";
            this.dataColMotherCodeFileName.ColumnName = "MotherCodeFileName";
            // 
            // dataColMotherCodeName
            // 
            this.dataColMotherCodeName.Caption = "母物料名称(MotherCodeName)";
            this.dataColMotherCodeName.ColumnName = "MotherCodeName";
            // 
            // dataColSubCodeFileName
            // 
            this.dataColSubCodeFileName.Caption = "子物料编号(SubCodeFileName)";
            this.dataColSubCodeFileName.ColumnName = "SubCodeFileName";
            // 
            // dataColSubCodeName
            // 
            this.dataColSubCodeName.Caption = "子物料名称(SubCodeName)";
            this.dataColSubCodeName.ColumnName = "SubCodeName";
            // 
            // dataColumn1
            // 
            this.dataColumn1.Caption = "数量(Qty)";
            this.dataColumn1.ColumnName = "Qty";
            this.dataColumn1.DataType = typeof(int);
            // 
            // gridCrlBom
            // 
            this.gridCrlBom.DataSource = this.bSBom;
            this.gridCrlBom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCrlBom.Location = new System.Drawing.Point(0, 126);
            this.gridCrlBom.MainView = this.gridViewBom;
            this.gridCrlBom.Name = "gridCrlBom";
            this.gridCrlBom.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repSearchCodeFileName,
            this.repSpinQty});
            this.gridCrlBom.Size = new System.Drawing.Size(1116, 452);
            this.gridCrlBom.TabIndex = 2;
            this.gridCrlBom.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBom});
            // 
            // gridViewBom
            // 
            this.gridViewBom.ColumnPanelRowHeight = 0;
            this.gridViewBom.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMotherCodeFileName,
            this.colMotherCodeName,
            this.colSubCodeFileName,
            this.colSubCodeName,
            this.colQty});
            this.gridViewBom.GridControl = this.gridCrlBom;
            this.gridViewBom.IndicatorWidth = 50;
            this.gridViewBom.Name = "gridViewBom";
            this.gridViewBom.OptionsSelection.MultiSelect = true;
            this.gridViewBom.OptionsView.ColumnAutoWidth = false;
            this.gridViewBom.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewBom.OptionsView.ShowFooter = true;
            this.gridViewBom.OptionsView.ShowGroupPanel = false;
            this.gridViewBom.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewBom_CustomDrawRowIndicator);
            this.gridViewBom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewBom_KeyDown);
            // 
            // colMotherCodeFileName
            // 
            this.colMotherCodeFileName.AppearanceHeader.Options.UseTextOptions = true;
            this.colMotherCodeFileName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMotherCodeFileName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colMotherCodeFileName.ColumnEdit = this.repSearchCodeFileName;
            this.colMotherCodeFileName.FieldName = "MotherCodeFileName";
            this.colMotherCodeFileName.Name = "colMotherCodeFileName";
            this.colMotherCodeFileName.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "CodeFileName", "共计{0}条")});
            this.colMotherCodeFileName.Visible = true;
            this.colMotherCodeFileName.VisibleIndex = 0;
            this.colMotherCodeFileName.Width = 220;
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
            this.gridColuAutoId,
            this.gridColuCodeFileName,
            this.gridColuCodeName});
            this.repSearchCodeFileNameView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repSearchCodeFileNameView.IndicatorWidth = 40;
            this.repSearchCodeFileNameView.Name = "repSearchCodeFileNameView";
            this.repSearchCodeFileNameView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repSearchCodeFileNameView.OptionsView.ShowGroupPanel = false;
            this.repSearchCodeFileNameView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewBom_CustomDrawRowIndicator);
            // 
            // gridColuAutoId
            // 
            this.gridColuAutoId.Caption = "AutoId";
            this.gridColuAutoId.FieldName = "AutoId";
            this.gridColuAutoId.Name = "gridColuAutoId";
            // 
            // gridColuCodeFileName
            // 
            this.gridColuCodeFileName.Caption = "零件编号";
            this.gridColuCodeFileName.FieldName = "CodeFileName";
            this.gridColuCodeFileName.Name = "gridColuCodeFileName";
            this.gridColuCodeFileName.Visible = true;
            this.gridColuCodeFileName.VisibleIndex = 0;
            // 
            // gridColuCodeName
            // 
            this.gridColuCodeName.Caption = "零件名称";
            this.gridColuCodeName.FieldName = "CodeName";
            this.gridColuCodeName.Name = "gridColuCodeName";
            this.gridColuCodeName.Visible = true;
            this.gridColuCodeName.VisibleIndex = 1;
            // 
            // colMotherCodeName
            // 
            this.colMotherCodeName.AppearanceHeader.Options.UseTextOptions = true;
            this.colMotherCodeName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMotherCodeName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colMotherCodeName.FieldName = "MotherCodeName";
            this.colMotherCodeName.Name = "colMotherCodeName";
            this.colMotherCodeName.Visible = true;
            this.colMotherCodeName.VisibleIndex = 1;
            this.colMotherCodeName.Width = 220;
            // 
            // colSubCodeFileName
            // 
            this.colSubCodeFileName.AppearanceHeader.Options.UseTextOptions = true;
            this.colSubCodeFileName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCodeFileName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colSubCodeFileName.ColumnEdit = this.repSearchCodeFileName;
            this.colSubCodeFileName.FieldName = "SubCodeFileName";
            this.colSubCodeFileName.Name = "colSubCodeFileName";
            this.colSubCodeFileName.Visible = true;
            this.colSubCodeFileName.VisibleIndex = 2;
            this.colSubCodeFileName.Width = 220;
            // 
            // colSubCodeName
            // 
            this.colSubCodeName.AppearanceHeader.Options.UseTextOptions = true;
            this.colSubCodeName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCodeName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colSubCodeName.FieldName = "SubCodeName";
            this.colSubCodeName.Name = "colSubCodeName";
            this.colSubCodeName.Visible = true;
            this.colSubCodeName.VisibleIndex = 3;
            this.colSubCodeName.Width = 220;
            // 
            // colQty
            // 
            this.colQty.AppearanceHeader.Options.UseTextOptions = true;
            this.colQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQty.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colQty.ColumnEdit = this.repSpinQty;
            this.colQty.FieldName = "Qty";
            this.colQty.Name = "colQty";
            this.colQty.Visible = true;
            this.colQty.VisibleIndex = 4;
            this.colQty.Width = 100;
            // 
            // repSpinQty
            // 
            this.repSpinQty.AutoHeight = false;
            this.repSpinQty.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repSpinQty.Name = "repSpinQty";
            // 
            // FrmBomImport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1116, 578);
            this.Controls.Add(this.gridCrlBom);
            this.Controls.Add(this.groupTop);
            this.Name = "FrmBomImport";
            this.TabText = "Bom信息导入";
            this.Text = "Bom信息导入";
            this.Load += new System.EventHandler(this.FrmBomImport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupTop)).EndInit();
            this.groupTop.ResumeLayout(false);
            this.groupTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxMother.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSBom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSBom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableBom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlBom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchCodeFileName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchCodeFileNameView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinQty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupTop;
        private System.Windows.Forms.BindingSource bSBom;
        private System.Data.DataSet dSBom;
        private System.Data.DataTable TableBom;
        private System.Data.DataColumn dataColMotherCodeFileName;
        private System.Data.DataColumn dataColMotherCodeName;
        private System.Data.DataColumn dataColSubCodeFileName;
        private System.Data.DataColumn dataColSubCodeName;
        private System.Data.DataColumn dataColumn1;
        private DevExpress.XtraGrid.GridControl gridCrlBom;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewBom;
        private DevExpress.XtraGrid.Columns.GridColumn colMotherCodeFileName;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repSearchCodeFileName;
        private DevExpress.XtraGrid.Views.Grid.GridView repSearchCodeFileNameView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColuAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColuCodeFileName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColuCodeName;
        private DevExpress.XtraGrid.Columns.GridColumn colMotherCodeName;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCodeFileName;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCodeName;
        private DevExpress.XtraGrid.Columns.GridColumn colQty;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repSpinQty;
        private DevExpress.XtraEditors.SimpleButton btnModuleDownload;
        private DevExpress.XtraEditors.SimpleButton btnExcel2007;
        private DevExpress.XtraEditors.SimpleButton btnUpdateDB;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.LabelControl labColumnName;
        private DevExpress.XtraEditors.SimpleButton btnMother;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxMother;
        private DevExpress.XtraEditors.SimpleButton btnSaveAs;
    }
}