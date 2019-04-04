namespace PSAP.VIEW.BSVIEW
{
    partial class FrmBrandCatg
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
            this.dSBrandCatg = new System.Data.DataSet();
            this.TableBrandCatg = new System.Data.DataTable();
            this.dataColAutoId = new System.Data.DataColumn();
            this.dataColBrandNo = new System.Data.DataColumn();
            this.dataColBrandName = new System.Data.DataColumn();
            this.dataColBrandDescription = new System.Data.DataColumn();
            this.bSBrandCatg = new System.Windows.Forms.BindingSource(this.components);
            this.pnlToolBar = new DevExpress.XtraEditors.PanelControl();
            this.pnlEdit = new DevExpress.XtraEditors.PanelControl();
            this.textBrandDescription = new DevExpress.XtraEditors.TextEdit();
            this.labBrandDescription = new DevExpress.XtraEditors.LabelControl();
            this.textBrandName = new DevExpress.XtraEditors.TextEdit();
            this.textBrandNo = new DevExpress.XtraEditors.TextEdit();
            this.labBrandName = new DevExpress.XtraEditors.LabelControl();
            this.labBrandNo = new DevExpress.XtraEditors.LabelControl();
            this.pnlGrid = new DevExpress.XtraEditors.PanelControl();
            this.gridCrlBrandCatg = new DevExpress.XtraGrid.GridControl();
            this.gridViewBrandCatg = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrandNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrandName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrandDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCtjz = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPpbh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPpmc = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dSBrandCatg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableBrandCatg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSBrandCatg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).BeginInit();
            this.pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBrandDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBrandName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBrandNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlBrandCatg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBrandCatg)).BeginInit();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // dSBrandCatg
            // 
            this.dSBrandCatg.DataSetName = "NewDataSet";
            this.dSBrandCatg.Tables.AddRange(new System.Data.DataTable[] {
            this.TableBrandCatg});
            // 
            // TableBrandCatg
            // 
            this.TableBrandCatg.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColAutoId,
            this.dataColBrandNo,
            this.dataColBrandName,
            this.dataColBrandDescription});
            this.TableBrandCatg.TableName = "BrandCatg";
            // 
            // dataColAutoId
            // 
            this.dataColAutoId.ColumnName = "AutoId";
            this.dataColAutoId.DataType = typeof(int);
            // 
            // dataColBrandNo
            // 
            this.dataColBrandNo.Caption = "品牌编号";
            this.dataColBrandNo.ColumnName = "BrandNo";
            // 
            // dataColBrandName
            // 
            this.dataColBrandName.Caption = "品牌名称";
            this.dataColBrandName.ColumnName = "BrandName";
            // 
            // dataColBrandDescription
            // 
            this.dataColBrandDescription.Caption = "品牌说明";
            this.dataColBrandDescription.ColumnName = "BrandDescription";
            // 
            // bSBrandCatg
            // 
            this.bSBrandCatg.DataMember = "BrandCatg";
            this.bSBrandCatg.DataSource = this.dSBrandCatg;
            // 
            // pnlToolBar
            // 
            this.pnlToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolBar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolBar.Name = "pnlToolBar";
            this.pnlToolBar.Size = new System.Drawing.Size(909, 40);
            this.pnlToolBar.TabIndex = 4;
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.textBrandDescription);
            this.pnlEdit.Controls.Add(this.labBrandDescription);
            this.pnlEdit.Controls.Add(this.textBrandName);
            this.pnlEdit.Controls.Add(this.textBrandNo);
            this.pnlEdit.Controls.Add(this.labBrandName);
            this.pnlEdit.Controls.Add(this.labBrandNo);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEdit.Location = new System.Drawing.Point(0, 40);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(909, 68);
            this.pnlEdit.TabIndex = 8;
            // 
            // textBrandDescription
            // 
            this.textBrandDescription.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSBrandCatg, "BrandDescription", true));
            this.textBrandDescription.EnterMoveNextControl = true;
            this.textBrandDescription.Location = new System.Drawing.Point(624, 21);
            this.textBrandDescription.Name = "textBrandDescription";
            this.textBrandDescription.Size = new System.Drawing.Size(180, 20);
            this.textBrandDescription.TabIndex = 2;
            // 
            // labBrandDescription
            // 
            this.labBrandDescription.Location = new System.Drawing.Point(554, 24);
            this.labBrandDescription.Name = "labBrandDescription";
            this.labBrandDescription.Size = new System.Drawing.Size(48, 14);
            this.labBrandDescription.TabIndex = 16;
            this.labBrandDescription.Text = "品牌说明";
            // 
            // textBrandName
            // 
            this.textBrandName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSBrandCatg, "BrandName", true));
            this.textBrandName.EnterMoveNextControl = true;
            this.textBrandName.Location = new System.Drawing.Point(366, 21);
            this.textBrandName.Name = "textBrandName";
            this.textBrandName.Size = new System.Drawing.Size(150, 20);
            this.textBrandName.TabIndex = 1;
            // 
            // textBrandNo
            // 
            this.textBrandNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSBrandCatg, "BrandNo", true));
            this.textBrandNo.EnterMoveNextControl = true;
            this.textBrandNo.Location = new System.Drawing.Point(104, 21);
            this.textBrandNo.Name = "textBrandNo";
            this.textBrandNo.Size = new System.Drawing.Size(150, 20);
            this.textBrandNo.TabIndex = 0;
            // 
            // labBrandName
            // 
            this.labBrandName.Location = new System.Drawing.Point(297, 24);
            this.labBrandName.Name = "labBrandName";
            this.labBrandName.Size = new System.Drawing.Size(48, 14);
            this.labBrandName.TabIndex = 14;
            this.labBrandName.Text = "品牌名称";
            // 
            // labBrandNo
            // 
            this.labBrandNo.Location = new System.Drawing.Point(36, 24);
            this.labBrandNo.Name = "labBrandNo";
            this.labBrandNo.Size = new System.Drawing.Size(48, 14);
            this.labBrandNo.TabIndex = 12;
            this.labBrandNo.Text = "品牌编号";
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.gridCrlBrandCatg);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 108);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(909, 446);
            this.pnlGrid.TabIndex = 9;
            // 
            // gridCrlBrandCatg
            // 
            this.gridCrlBrandCatg.DataSource = this.bSBrandCatg;
            this.gridCrlBrandCatg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCrlBrandCatg.Location = new System.Drawing.Point(2, 2);
            this.gridCrlBrandCatg.MainView = this.gridViewBrandCatg;
            this.gridCrlBrandCatg.Name = "gridCrlBrandCatg";
            this.gridCrlBrandCatg.Size = new System.Drawing.Size(905, 442);
            this.gridCrlBrandCatg.TabIndex = 0;
            this.gridCrlBrandCatg.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBrandCatg});
            // 
            // gridViewBrandCatg
            // 
            this.gridViewBrandCatg.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId,
            this.colBrandNo,
            this.colBrandName,
            this.colBrandDescription});
            this.gridViewBrandCatg.GridControl = this.gridCrlBrandCatg;
            this.gridViewBrandCatg.IndicatorWidth = 40;
            this.gridViewBrandCatg.Name = "gridViewBrandCatg";
            this.gridViewBrandCatg.OptionsBehavior.Editable = false;
            this.gridViewBrandCatg.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewBrandCatg.OptionsView.ColumnAutoWidth = false;
            this.gridViewBrandCatg.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewBrandCatg.OptionsView.ShowFooter = true;
            this.gridViewBrandCatg.OptionsView.ShowGroupPanel = false;
            // 
            // colAutoId
            // 
            this.colAutoId.FieldName = "AutoId";
            this.colAutoId.Name = "colAutoId";
            // 
            // colBrandNo
            // 
            this.colBrandNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colBrandNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBrandNo.FieldName = "BrandNo";
            this.colBrandNo.Name = "colBrandNo";
            this.colBrandNo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "BrandNo", "共计{0}条")});
            this.colBrandNo.Visible = true;
            this.colBrandNo.VisibleIndex = 0;
            this.colBrandNo.Width = 150;
            // 
            // colBrandName
            // 
            this.colBrandName.AppearanceHeader.Options.UseTextOptions = true;
            this.colBrandName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBrandName.FieldName = "BrandName";
            this.colBrandName.Name = "colBrandName";
            this.colBrandName.Visible = true;
            this.colBrandName.VisibleIndex = 1;
            this.colBrandName.Width = 150;
            // 
            // colBrandDescription
            // 
            this.colBrandDescription.AppearanceHeader.Options.UseTextOptions = true;
            this.colBrandDescription.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBrandDescription.FieldName = "BrandDescription";
            this.colBrandDescription.Name = "colBrandDescription";
            this.colBrandDescription.Visible = true;
            this.colBrandDescription.VisibleIndex = 2;
            this.colBrandDescription.Width = 180;
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCtjz,
            this.tsmiPpbh,
            this.tsmiPpmc});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(257, 92);
            // 
            // tsmiCtjz
            // 
            this.tsmiCtjz.Name = "tsmiCtjz";
            this.tsmiCtjz.Size = new System.Drawing.Size(256, 22);
            this.tsmiCtjz.Text = "窗体加载事件错误。";
            // 
            // tsmiPpbh
            // 
            this.tsmiPpbh.Name = "tsmiPpbh";
            this.tsmiPpbh.Size = new System.Drawing.Size(256, 22);
            this.tsmiPpbh.Text = "品牌编号不能为空，请重新操作。";
            // 
            // tsmiPpmc
            // 
            this.tsmiPpmc.Name = "tsmiPpmc";
            this.tsmiPpmc.Size = new System.Drawing.Size(256, 22);
            this.tsmiPpmc.Text = "品牌名称不能为空，请重新操作。";
            // 
            // FrmBrandCatg
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(909, 554);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.pnlToolBar);
            this.Name = "FrmBrandCatg";
            this.TabText = "品牌信息";
            this.Text = "品牌信息";
            this.Load += new System.EventHandler(this.FrmBrandCatg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSBrandCatg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableBrandCatg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSBrandCatg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBrandDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBrandName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBrandNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlBrandCatg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBrandCatg)).EndInit();
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dSBrandCatg;
        private System.Data.DataTable TableBrandCatg;
        private System.Data.DataColumn dataColAutoId;
        private System.Data.DataColumn dataColBrandNo;
        private System.Data.DataColumn dataColBrandName;
        private System.Data.DataColumn dataColBrandDescription;
        private System.Windows.Forms.BindingSource bSBrandCatg;
        private DevExpress.XtraEditors.PanelControl pnlToolBar;
        private DevExpress.XtraEditors.PanelControl pnlEdit;
        private DevExpress.XtraEditors.TextEdit textBrandDescription;
        private DevExpress.XtraEditors.LabelControl labBrandDescription;
        private DevExpress.XtraEditors.TextEdit textBrandName;
        private DevExpress.XtraEditors.TextEdit textBrandNo;
        private DevExpress.XtraEditors.LabelControl labBrandName;
        private DevExpress.XtraEditors.LabelControl labBrandNo;
        private DevExpress.XtraEditors.PanelControl pnlGrid;
        private DevExpress.XtraGrid.GridControl gridCrlBrandCatg;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewBrandCatg;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colBrandNo;
        private DevExpress.XtraGrid.Columns.GridColumn colBrandName;
        private DevExpress.XtraGrid.Columns.GridColumn colBrandDescription;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem tsmiCtjz;
        private System.Windows.Forms.ToolStripMenuItem tsmiPpbh;
        private System.Windows.Forms.ToolStripMenuItem tsmiPpmc;
    }
}