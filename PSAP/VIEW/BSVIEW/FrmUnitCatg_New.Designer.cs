namespace PSAP.VIEW.BSVIEW
{
    partial class FrmUnitCatg_New
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
            this.dSUnitCatg = new System.Data.DataSet();
            this.TableUnitCatg = new System.Data.DataTable();
            this.dataColAutoId = new System.Data.DataColumn();
            this.dataColUnitNo = new System.Data.DataColumn();
            this.dataColUnitName = new System.Data.DataColumn();
            this.dataColUnitDescription = new System.Data.DataColumn();
            this.bSUnitCatg = new System.Windows.Forms.BindingSource(this.components);
            this.pnlToolBar = new DevExpress.XtraEditors.PanelControl();
            this.pnlEdit = new DevExpress.XtraEditors.PanelControl();
            this.textUnitDescription = new DevExpress.XtraEditors.TextEdit();
            this.labUnitDescription = new DevExpress.XtraEditors.LabelControl();
            this.textUnitName = new DevExpress.XtraEditors.TextEdit();
            this.textUnitNo = new DevExpress.XtraEditors.TextEdit();
            this.labUnitName = new DevExpress.XtraEditors.LabelControl();
            this.labUnitNo = new DevExpress.XtraEditors.LabelControl();
            this.pnlGrid = new DevExpress.XtraEditors.PanelControl();
            this.gridCrlUnitCatg = new DevExpress.XtraGrid.GridControl();
            this.gridViewUnitCatg = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDwbhbnwk = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDwmcbnwk = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dSUnitCatg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableUnitCatg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSUnitCatg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).BeginInit();
            this.pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textUnitDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textUnitName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textUnitNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlUnitCatg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUnitCatg)).BeginInit();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // dSUnitCatg
            // 
            this.dSUnitCatg.DataSetName = "NewDataSet";
            this.dSUnitCatg.Tables.AddRange(new System.Data.DataTable[] {
            this.TableUnitCatg});
            // 
            // TableUnitCatg
            // 
            this.TableUnitCatg.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColAutoId,
            this.dataColUnitNo,
            this.dataColUnitName,
            this.dataColUnitDescription});
            this.TableUnitCatg.TableName = "UnitCatg";
            // 
            // dataColAutoId
            // 
            this.dataColAutoId.ColumnName = "AutoId";
            this.dataColAutoId.DataType = typeof(int);
            // 
            // dataColUnitNo
            // 
            this.dataColUnitNo.Caption = "单位编号";
            this.dataColUnitNo.ColumnName = "UnitNo";
            // 
            // dataColUnitName
            // 
            this.dataColUnitName.Caption = "单位名称";
            this.dataColUnitName.ColumnName = "UnitName";
            // 
            // dataColUnitDescription
            // 
            this.dataColUnitDescription.Caption = "单位说明";
            this.dataColUnitDescription.ColumnName = "UnitDescription";
            // 
            // bSUnitCatg
            // 
            this.bSUnitCatg.DataMember = "UnitCatg";
            this.bSUnitCatg.DataSource = this.dSUnitCatg;
            // 
            // pnlToolBar
            // 
            this.pnlToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolBar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolBar.Name = "pnlToolBar";
            this.pnlToolBar.Size = new System.Drawing.Size(1001, 40);
            this.pnlToolBar.TabIndex = 3;
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.textUnitDescription);
            this.pnlEdit.Controls.Add(this.labUnitDescription);
            this.pnlEdit.Controls.Add(this.textUnitName);
            this.pnlEdit.Controls.Add(this.textUnitNo);
            this.pnlEdit.Controls.Add(this.labUnitName);
            this.pnlEdit.Controls.Add(this.labUnitNo);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEdit.Location = new System.Drawing.Point(0, 40);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(1001, 68);
            this.pnlEdit.TabIndex = 7;
            // 
            // textUnitDescription
            // 
            this.textUnitDescription.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSUnitCatg, "UnitDescription", true));
            this.textUnitDescription.EnterMoveNextControl = true;
            this.textUnitDescription.Location = new System.Drawing.Point(624, 21);
            this.textUnitDescription.Name = "textUnitDescription";
            this.textUnitDescription.Size = new System.Drawing.Size(180, 20);
            this.textUnitDescription.TabIndex = 2;
            // 
            // labUnitDescription
            // 
            this.labUnitDescription.Location = new System.Drawing.Point(554, 24);
            this.labUnitDescription.Name = "labUnitDescription";
            this.labUnitDescription.Size = new System.Drawing.Size(48, 14);
            this.labUnitDescription.TabIndex = 16;
            this.labUnitDescription.Text = "单位说明";
            // 
            // textUnitName
            // 
            this.textUnitName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSUnitCatg, "UnitName", true));
            this.textUnitName.EnterMoveNextControl = true;
            this.textUnitName.Location = new System.Drawing.Point(366, 21);
            this.textUnitName.Name = "textUnitName";
            this.textUnitName.Size = new System.Drawing.Size(150, 20);
            this.textUnitName.TabIndex = 1;
            // 
            // textUnitNo
            // 
            this.textUnitNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSUnitCatg, "UnitNo", true));
            this.textUnitNo.EnterMoveNextControl = true;
            this.textUnitNo.Location = new System.Drawing.Point(104, 21);
            this.textUnitNo.Name = "textUnitNo";
            this.textUnitNo.Size = new System.Drawing.Size(150, 20);
            this.textUnitNo.TabIndex = 0;
            // 
            // labUnitName
            // 
            this.labUnitName.Location = new System.Drawing.Point(297, 24);
            this.labUnitName.Name = "labUnitName";
            this.labUnitName.Size = new System.Drawing.Size(48, 14);
            this.labUnitName.TabIndex = 14;
            this.labUnitName.Text = "单位名称";
            // 
            // labUnitNo
            // 
            this.labUnitNo.Location = new System.Drawing.Point(36, 24);
            this.labUnitNo.Name = "labUnitNo";
            this.labUnitNo.Size = new System.Drawing.Size(48, 14);
            this.labUnitNo.TabIndex = 12;
            this.labUnitNo.Text = "单位编号";
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.gridCrlUnitCatg);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 108);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1001, 479);
            this.pnlGrid.TabIndex = 8;
            // 
            // gridCrlUnitCatg
            // 
            this.gridCrlUnitCatg.DataSource = this.bSUnitCatg;
            this.gridCrlUnitCatg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCrlUnitCatg.Location = new System.Drawing.Point(2, 2);
            this.gridCrlUnitCatg.MainView = this.gridViewUnitCatg;
            this.gridCrlUnitCatg.Name = "gridCrlUnitCatg";
            this.gridCrlUnitCatg.Size = new System.Drawing.Size(997, 475);
            this.gridCrlUnitCatg.TabIndex = 0;
            this.gridCrlUnitCatg.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUnitCatg});
            // 
            // gridViewUnitCatg
            // 
            this.gridViewUnitCatg.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId,
            this.colUnitNo,
            this.colUnitName,
            this.colUnitDescription});
            this.gridViewUnitCatg.GridControl = this.gridCrlUnitCatg;
            this.gridViewUnitCatg.IndicatorWidth = 40;
            this.gridViewUnitCatg.Name = "gridViewUnitCatg";
            this.gridViewUnitCatg.OptionsBehavior.Editable = false;
            this.gridViewUnitCatg.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewUnitCatg.OptionsView.ColumnAutoWidth = false;
            this.gridViewUnitCatg.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewUnitCatg.OptionsView.ShowFooter = true;
            this.gridViewUnitCatg.OptionsView.ShowGroupPanel = false;
            // 
            // colAutoId
            // 
            this.colAutoId.FieldName = "AutoId";
            this.colAutoId.Name = "colAutoId";
            // 
            // colUnitNo
            // 
            this.colUnitNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnitNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnitNo.FieldName = "UnitNo";
            this.colUnitNo.Name = "colUnitNo";
            this.colUnitNo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "UnitNo", "共计{0}条")});
            this.colUnitNo.Visible = true;
            this.colUnitNo.VisibleIndex = 0;
            this.colUnitNo.Width = 150;
            // 
            // colUnitName
            // 
            this.colUnitName.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnitName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnitName.FieldName = "UnitName";
            this.colUnitName.Name = "colUnitName";
            this.colUnitName.Visible = true;
            this.colUnitName.VisibleIndex = 1;
            this.colUnitName.Width = 150;
            // 
            // colUnitDescription
            // 
            this.colUnitDescription.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnitDescription.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnitDescription.FieldName = "UnitDescription";
            this.colUnitDescription.Name = "colUnitDescription";
            this.colUnitDescription.Visible = true;
            this.colUnitDescription.VisibleIndex = 2;
            this.colUnitDescription.Width = 180;
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDwbhbnwk,
            this.tsmiDwmcbnwk});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(257, 70);
            // 
            // tsmiDwbhbnwk
            // 
            this.tsmiDwbhbnwk.Name = "tsmiDwbhbnwk";
            this.tsmiDwbhbnwk.Size = new System.Drawing.Size(256, 22);
            this.tsmiDwbhbnwk.Text = "单位编号不能为空，请重新操作。";
            // 
            // tsmiDwmcbnwk
            // 
            this.tsmiDwmcbnwk.Name = "tsmiDwmcbnwk";
            this.tsmiDwmcbnwk.Size = new System.Drawing.Size(256, 22);
            this.tsmiDwmcbnwk.Text = "单位名称不能为空，请重新操作。";
            // 
            // FrmUnitCatg_New
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1001, 587);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.pnlToolBar);
            this.Name = "FrmUnitCatg_New";
            this.TabText = "计量单位";
            this.Text = "计量单位";
            this.Load += new System.EventHandler(this.FrmUnitCatg_New_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSUnitCatg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableUnitCatg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSUnitCatg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textUnitDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textUnitName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textUnitNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlUnitCatg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUnitCatg)).EndInit();
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dSUnitCatg;
        private System.Data.DataTable TableUnitCatg;
        private System.Data.DataColumn dataColAutoId;
        private System.Data.DataColumn dataColUnitNo;
        private System.Data.DataColumn dataColUnitName;
        private System.Data.DataColumn dataColUnitDescription;
        private System.Windows.Forms.BindingSource bSUnitCatg;
        private DevExpress.XtraEditors.PanelControl pnlToolBar;
        private DevExpress.XtraEditors.PanelControl pnlEdit;
        private DevExpress.XtraEditors.TextEdit textUnitName;
        private DevExpress.XtraEditors.TextEdit textUnitNo;
        private DevExpress.XtraEditors.LabelControl labUnitName;
        private DevExpress.XtraEditors.LabelControl labUnitNo;
        private DevExpress.XtraEditors.PanelControl pnlGrid;
        private DevExpress.XtraGrid.GridControl gridCrlUnitCatg;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUnitCatg;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitNo;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitName;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitDescription;
        private DevExpress.XtraEditors.TextEdit textUnitDescription;
        private DevExpress.XtraEditors.LabelControl labUnitDescription;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem tsmiDwbhbnwk;
        private System.Windows.Forms.ToolStripMenuItem tsmiDwmcbnwk;
    }
}