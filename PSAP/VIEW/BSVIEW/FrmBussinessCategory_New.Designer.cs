namespace PSAP.VIEW.BSVIEW
{
    partial class FrmBussinessCategory_New
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
            this.dSBussinessCategory = new System.Data.DataSet();
            this.TableBussinessCategory = new System.Data.DataTable();
            this.dataColAutoId = new System.Data.DataColumn();
            this.dataColBussinessCategory = new System.Data.DataColumn();
            this.dataColBussinessCategoryText = new System.Data.DataColumn();
            this.bSBussinessCategory = new System.Windows.Forms.BindingSource(this.components);
            this.pnlToolBar = new DevExpress.XtraEditors.PanelControl();
            this.pnlEdit = new DevExpress.XtraEditors.PanelControl();
            this.textBussinessCategoryText = new DevExpress.XtraEditors.TextEdit();
            this.textBussinessCategory = new DevExpress.XtraEditors.TextEdit();
            this.labBussinessCategoryText = new DevExpress.XtraEditors.LabelControl();
            this.labBussinessCategory = new DevExpress.XtraEditors.LabelControl();
            this.pnlGrid = new DevExpress.XtraEditors.PanelControl();
            this.gridCrlBussinessCategory = new DevExpress.XtraGrid.GridControl();
            this.gridViewBussinessCategory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBussinessCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBussinessCategoryText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSywllbbh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSywllbmc = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dSBussinessCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableBussinessCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSBussinessCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).BeginInit();
            this.pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBussinessCategoryText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBussinessCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlBussinessCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBussinessCategory)).BeginInit();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // dSBussinessCategory
            // 
            this.dSBussinessCategory.DataSetName = "NewDataSet";
            this.dSBussinessCategory.Tables.AddRange(new System.Data.DataTable[] {
            this.TableBussinessCategory});
            // 
            // TableBussinessCategory
            // 
            this.TableBussinessCategory.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColAutoId,
            this.dataColBussinessCategory,
            this.dataColBussinessCategoryText});
            this.TableBussinessCategory.TableName = "BussinessCategory";
            // 
            // dataColAutoId
            // 
            this.dataColAutoId.ColumnName = "AutoId";
            this.dataColAutoId.DataType = typeof(int);
            // 
            // dataColBussinessCategory
            // 
            this.dataColBussinessCategory.Caption = "往来方类别编号";
            this.dataColBussinessCategory.ColumnName = "BussinessCategory";
            // 
            // dataColBussinessCategoryText
            // 
            this.dataColBussinessCategoryText.Caption = "往来方类别名称";
            this.dataColBussinessCategoryText.ColumnName = "BussinessCategoryText";
            // 
            // bSBussinessCategory
            // 
            this.bSBussinessCategory.DataMember = "BussinessCategory";
            this.bSBussinessCategory.DataSource = this.dSBussinessCategory;
            // 
            // pnlToolBar
            // 
            this.pnlToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolBar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolBar.Name = "pnlToolBar";
            this.pnlToolBar.Size = new System.Drawing.Size(859, 40);
            this.pnlToolBar.TabIndex = 2;
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.textBussinessCategoryText);
            this.pnlEdit.Controls.Add(this.textBussinessCategory);
            this.pnlEdit.Controls.Add(this.labBussinessCategoryText);
            this.pnlEdit.Controls.Add(this.labBussinessCategory);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEdit.Location = new System.Drawing.Point(0, 40);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(859, 68);
            this.pnlEdit.TabIndex = 6;
            // 
            // textBussinessCategoryText
            // 
            this.textBussinessCategoryText.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSBussinessCategory, "BussinessCategoryText", true));
            this.textBussinessCategoryText.EnterMoveNextControl = true;
            this.textBussinessCategoryText.Location = new System.Drawing.Point(439, 21);
            this.textBussinessCategoryText.Name = "textBussinessCategoryText";
            this.textBussinessCategoryText.Size = new System.Drawing.Size(180, 20);
            this.textBussinessCategoryText.TabIndex = 1;
            // 
            // textBussinessCategory
            // 
            this.textBussinessCategory.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSBussinessCategory, "BussinessCategory", true));
            this.textBussinessCategory.EnterMoveNextControl = true;
            this.textBussinessCategory.Location = new System.Drawing.Point(147, 21);
            this.textBussinessCategory.Name = "textBussinessCategory";
            this.textBussinessCategory.Size = new System.Drawing.Size(150, 20);
            this.textBussinessCategory.TabIndex = 0;
            // 
            // labBussinessCategoryText
            // 
            this.labBussinessCategoryText.Location = new System.Drawing.Point(326, 24);
            this.labBussinessCategoryText.Name = "labBussinessCategoryText";
            this.labBussinessCategoryText.Size = new System.Drawing.Size(84, 14);
            this.labBussinessCategoryText.TabIndex = 14;
            this.labBussinessCategoryText.Text = "往来方类别名称";
            // 
            // labBussinessCategory
            // 
            this.labBussinessCategory.Location = new System.Drawing.Point(36, 24);
            this.labBussinessCategory.Name = "labBussinessCategory";
            this.labBussinessCategory.Size = new System.Drawing.Size(84, 14);
            this.labBussinessCategory.TabIndex = 12;
            this.labBussinessCategory.Text = "往来方类别编号";
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.gridCrlBussinessCategory);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 108);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(859, 370);
            this.pnlGrid.TabIndex = 7;
            // 
            // gridCrlBussinessCategory
            // 
            this.gridCrlBussinessCategory.DataSource = this.bSBussinessCategory;
            this.gridCrlBussinessCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCrlBussinessCategory.Location = new System.Drawing.Point(2, 2);
            this.gridCrlBussinessCategory.MainView = this.gridViewBussinessCategory;
            this.gridCrlBussinessCategory.Name = "gridCrlBussinessCategory";
            this.gridCrlBussinessCategory.Size = new System.Drawing.Size(855, 366);
            this.gridCrlBussinessCategory.TabIndex = 0;
            this.gridCrlBussinessCategory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBussinessCategory});
            // 
            // gridViewBussinessCategory
            // 
            this.gridViewBussinessCategory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId,
            this.colBussinessCategory,
            this.colBussinessCategoryText});
            this.gridViewBussinessCategory.GridControl = this.gridCrlBussinessCategory;
            this.gridViewBussinessCategory.IndicatorWidth = 40;
            this.gridViewBussinessCategory.Name = "gridViewBussinessCategory";
            this.gridViewBussinessCategory.OptionsBehavior.Editable = false;
            this.gridViewBussinessCategory.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewBussinessCategory.OptionsView.ColumnAutoWidth = false;
            this.gridViewBussinessCategory.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewBussinessCategory.OptionsView.ShowFooter = true;
            this.gridViewBussinessCategory.OptionsView.ShowGroupPanel = false;
            // 
            // colAutoId
            // 
            this.colAutoId.FieldName = "AutoId";
            this.colAutoId.Name = "colAutoId";
            // 
            // colBussinessCategory
            // 
            this.colBussinessCategory.AppearanceHeader.Options.UseTextOptions = true;
            this.colBussinessCategory.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBussinessCategory.FieldName = "BussinessCategory";
            this.colBussinessCategory.Name = "colBussinessCategory";
            this.colBussinessCategory.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "BussinessCategory", "共计{0}条")});
            this.colBussinessCategory.Visible = true;
            this.colBussinessCategory.VisibleIndex = 0;
            this.colBussinessCategory.Width = 150;
            // 
            // colBussinessCategoryText
            // 
            this.colBussinessCategoryText.AppearanceHeader.Options.UseTextOptions = true;
            this.colBussinessCategoryText.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBussinessCategoryText.FieldName = "BussinessCategoryText";
            this.colBussinessCategoryText.Name = "colBussinessCategoryText";
            this.colBussinessCategoryText.Visible = true;
            this.colBussinessCategoryText.VisibleIndex = 1;
            this.colBussinessCategoryText.Width = 180;
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSywllbbh,
            this.tsmiSywllbmc});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(305, 70);
            // 
            // tsmiSywllbbh
            // 
            this.tsmiSywllbbh.Name = "tsmiSywllbbh";
            this.tsmiSywllbbh.Size = new System.Drawing.Size(304, 22);
            this.tsmiSywllbbh.Text = "商业往来类别编号不能为空，请重新操作。";
            // 
            // tsmiSywllbmc
            // 
            this.tsmiSywllbmc.Name = "tsmiSywllbmc";
            this.tsmiSywllbmc.Size = new System.Drawing.Size(304, 22);
            this.tsmiSywllbmc.Text = "商业往来类别名称不能为空，请重新操作。";
            // 
            // FrmBussinessCategory_New
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(859, 478);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.pnlToolBar);
            this.Name = "FrmBussinessCategory_New";
            this.TabText = "往来方类别";
            this.Text = "往来方类别";
            this.Load += new System.EventHandler(this.FrmBussinessCategory_New_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSBussinessCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableBussinessCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSBussinessCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBussinessCategoryText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBussinessCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlBussinessCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBussinessCategory)).EndInit();
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dSBussinessCategory;
        private System.Data.DataTable TableBussinessCategory;
        private System.Data.DataColumn dataColAutoId;
        private System.Data.DataColumn dataColBussinessCategory;
        private System.Data.DataColumn dataColBussinessCategoryText;
        private System.Windows.Forms.BindingSource bSBussinessCategory;
        private DevExpress.XtraEditors.PanelControl pnlToolBar;
        private DevExpress.XtraEditors.PanelControl pnlEdit;
        private DevExpress.XtraEditors.TextEdit textBussinessCategoryText;
        private DevExpress.XtraEditors.TextEdit textBussinessCategory;
        private DevExpress.XtraEditors.LabelControl labBussinessCategoryText;
        private DevExpress.XtraEditors.LabelControl labBussinessCategory;
        private DevExpress.XtraEditors.PanelControl pnlGrid;
        private DevExpress.XtraGrid.GridControl gridCrlBussinessCategory;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewBussinessCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colBussinessCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colBussinessCategoryText;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem tsmiSywllbbh;
        private System.Windows.Forms.ToolStripMenuItem tsmiSywllbmc;
    }
}