namespace PSAP.VIEW.BSVIEW
{
    partial class FrmPurCategory
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
            this.dSPurCategory = new System.Data.DataSet();
            this.TablePurCategory = new System.Data.DataTable();
            this.dataColAutoId = new System.Data.DataColumn();
            this.dataColPurCategory = new System.Data.DataColumn();
            this.dataColPurCategoryText = new System.Data.DataColumn();
            this.bSPurCategory = new System.Windows.Forms.BindingSource(this.components);
            this.pnlToolBar = new DevExpress.XtraEditors.PanelControl();
            this.pnlEdit = new DevExpress.XtraEditors.PanelControl();
            this.labPurCategoryText = new DevExpress.XtraEditors.LabelControl();
            this.labPurCategory = new DevExpress.XtraEditors.LabelControl();
            this.textPurCategoryText = new DevExpress.XtraEditors.TextEdit();
            this.textPurCategory = new DevExpress.XtraEditors.TextEdit();
            this.pnlGrid = new DevExpress.XtraEditors.PanelControl();
            this.gridCrlPurCategory = new DevExpress.XtraGrid.GridControl();
            this.gridViewPurCategory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurCategoryText = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dSPurCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablePurCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSPurCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).BeginInit();
            this.pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textPurCategoryText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPurCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlPurCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPurCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // dSPurCategory
            // 
            this.dSPurCategory.DataSetName = "NewDataSet";
            this.dSPurCategory.Tables.AddRange(new System.Data.DataTable[] {
            this.TablePurCategory});
            // 
            // TablePurCategory
            // 
            this.TablePurCategory.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColAutoId,
            this.dataColPurCategory,
            this.dataColPurCategoryText});
            this.TablePurCategory.TableName = "PurCategory";
            // 
            // dataColAutoId
            // 
            this.dataColAutoId.ColumnName = "AutoId";
            this.dataColAutoId.DataType = typeof(int);
            // 
            // dataColPurCategory
            // 
            this.dataColPurCategory.Caption = "采购类型编号";
            this.dataColPurCategory.ColumnName = "PurCategory";
            // 
            // dataColPurCategoryText
            // 
            this.dataColPurCategoryText.Caption = "采购类型名称";
            this.dataColPurCategoryText.ColumnName = "PurCategoryText";
            // 
            // bSPurCategory
            // 
            this.bSPurCategory.DataMember = "PurCategory";
            this.bSPurCategory.DataSource = this.dSPurCategory;
            // 
            // pnlToolBar
            // 
            this.pnlToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolBar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolBar.Name = "pnlToolBar";
            this.pnlToolBar.Size = new System.Drawing.Size(584, 40);
            this.pnlToolBar.TabIndex = 2;
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.textPurCategoryText);
            this.pnlEdit.Controls.Add(this.textPurCategory);
            this.pnlEdit.Controls.Add(this.labPurCategoryText);
            this.pnlEdit.Controls.Add(this.labPurCategory);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEdit.Location = new System.Drawing.Point(0, 40);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(584, 68);
            this.pnlEdit.TabIndex = 6;
            // 
            // labPurCategoryText
            // 
            this.labPurCategoryText.Location = new System.Drawing.Point(266, 24);
            this.labPurCategoryText.Name = "labPurCategoryText";
            this.labPurCategoryText.Size = new System.Drawing.Size(72, 14);
            this.labPurCategoryText.TabIndex = 15;
            this.labPurCategoryText.Text = "采购类型名称";
            // 
            // labPurCategory
            // 
            this.labPurCategory.Location = new System.Drawing.Point(36, 24);
            this.labPurCategory.Name = "labPurCategory";
            this.labPurCategory.Size = new System.Drawing.Size(72, 14);
            this.labPurCategory.TabIndex = 12;
            this.labPurCategory.Text = "采购类型编号";
            // 
            // textPurCategoryText
            // 
            this.textPurCategoryText.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSPurCategory, "PurCategoryText", true));
            this.textPurCategoryText.Location = new System.Drawing.Point(353, 21);
            this.textPurCategoryText.Name = "textPurCategoryText";
            this.textPurCategoryText.Size = new System.Drawing.Size(120, 20);
            this.textPurCategoryText.TabIndex = 1;
            // 
            // textPurCategory
            // 
            this.textPurCategory.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSPurCategory, "PurCategory", true));
            this.textPurCategory.EnterMoveNextControl = true;
            this.textPurCategory.Location = new System.Drawing.Point(123, 21);
            this.textPurCategory.Name = "textPurCategory";
            this.textPurCategory.Size = new System.Drawing.Size(120, 20);
            this.textPurCategory.TabIndex = 0;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.gridCrlPurCategory);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 108);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(584, 253);
            this.pnlGrid.TabIndex = 7;
            // 
            // gridCrlPurCategory
            // 
            this.gridCrlPurCategory.DataSource = this.bSPurCategory;
            this.gridCrlPurCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCrlPurCategory.Location = new System.Drawing.Point(2, 2);
            this.gridCrlPurCategory.MainView = this.gridViewPurCategory;
            this.gridCrlPurCategory.Name = "gridCrlPurCategory";
            this.gridCrlPurCategory.Size = new System.Drawing.Size(580, 249);
            this.gridCrlPurCategory.TabIndex = 0;
            this.gridCrlPurCategory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPurCategory});
            // 
            // gridViewPurCategory
            // 
            this.gridViewPurCategory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId,
            this.colPurCategory,
            this.colPurCategoryText});
            this.gridViewPurCategory.GridControl = this.gridCrlPurCategory;
            this.gridViewPurCategory.IndicatorWidth = 40;
            this.gridViewPurCategory.Name = "gridViewPurCategory";
            this.gridViewPurCategory.OptionsBehavior.Editable = false;
            this.gridViewPurCategory.OptionsFilter.AllowFilterEditor = false;
            this.gridViewPurCategory.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewPurCategory.OptionsView.ColumnAutoWidth = false;
            this.gridViewPurCategory.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewPurCategory.OptionsView.ShowFooter = true;
            this.gridViewPurCategory.OptionsView.ShowGroupPanel = false;
            this.gridViewPurCategory.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewPurCategory_CustomDrawRowIndicator);
            // 
            // colAutoId
            // 
            this.colAutoId.FieldName = "AutoId";
            this.colAutoId.Name = "colAutoId";
            // 
            // colPurCategory
            // 
            this.colPurCategory.AppearanceHeader.Options.UseTextOptions = true;
            this.colPurCategory.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPurCategory.FieldName = "PurCategory";
            this.colPurCategory.Name = "colPurCategory";
            this.colPurCategory.Visible = true;
            this.colPurCategory.VisibleIndex = 0;
            this.colPurCategory.Width = 120;
            // 
            // colPurCategoryText
            // 
            this.colPurCategoryText.AppearanceHeader.Options.UseTextOptions = true;
            this.colPurCategoryText.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPurCategoryText.FieldName = "PurCategoryText";
            this.colPurCategoryText.Name = "colPurCategoryText";
            this.colPurCategoryText.Visible = true;
            this.colPurCategoryText.VisibleIndex = 1;
            this.colPurCategoryText.Width = 120;
            // 
            // FrmPurCategory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.pnlToolBar);
            this.Name = "FrmPurCategory";
            this.TabText = "采购类型";
            this.Text = "采购类型";
            this.Load += new System.EventHandler(this.FrmPurCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSPurCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablePurCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSPurCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textPurCategoryText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPurCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlPurCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPurCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dSPurCategory;
        private System.Data.DataTable TablePurCategory;
        private System.Data.DataColumn dataColAutoId;
        private System.Data.DataColumn dataColPurCategory;
        private System.Data.DataColumn dataColPurCategoryText;
        private System.Windows.Forms.BindingSource bSPurCategory;
        private DevExpress.XtraEditors.PanelControl pnlToolBar;
        private DevExpress.XtraEditors.PanelControl pnlEdit;
        private DevExpress.XtraEditors.LabelControl labPurCategoryText;
        private DevExpress.XtraEditors.LabelControl labPurCategory;
        private DevExpress.XtraEditors.TextEdit textPurCategoryText;
        private DevExpress.XtraEditors.TextEdit textPurCategory;
        private DevExpress.XtraEditors.PanelControl pnlGrid;
        private DevExpress.XtraGrid.GridControl gridCrlPurCategory;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPurCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colPurCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colPurCategoryText;
    }
}