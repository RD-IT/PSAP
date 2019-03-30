namespace PSAP.VIEW.BSVIEW
{
    partial class FrmCurrencyCate
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
            this.dSCurrencyCate = new System.Data.DataSet();
            this.TableCurrencyCate = new System.Data.DataTable();
            this.dataColAutoId = new System.Data.DataColumn();
            this.dataColCurrencyCateAbb = new System.Data.DataColumn();
            this.dataColCurrencyCateName = new System.Data.DataColumn();
            this.dataColExchangeRate = new System.Data.DataColumn();
            this.bSCurrencyCate = new System.Windows.Forms.BindingSource(this.components);
            this.dataColRemark = new System.Data.DataColumn();
            this.pnlToolBar = new DevExpress.XtraEditors.PanelControl();
            this.pnlEdit = new DevExpress.XtraEditors.PanelControl();
            this.textRemark = new DevExpress.XtraEditors.TextEdit();
            this.textCurrencyCateName = new DevExpress.XtraEditors.TextEdit();
            this.textCurrencyCateAbb = new DevExpress.XtraEditors.TextEdit();
            this.labRemark = new DevExpress.XtraEditors.LabelControl();
            this.labCurrencyCateName = new DevExpress.XtraEditors.LabelControl();
            this.labCurrencyCateAbb = new DevExpress.XtraEditors.LabelControl();
            this.pnlGrid = new DevExpress.XtraEditors.PanelControl();
            this.gridCrlCurrencyCate = new DevExpress.XtraGrid.GridControl();
            this.gridViewCurrencyCate = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labExchangeRate = new DevExpress.XtraEditors.LabelControl();
            this.spinExchangeRate = new DevExpress.XtraEditors.SpinEdit();
            this.colAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrencyCateAbb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrencyCateName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExchangeRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dSCurrencyCate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableCurrencyCate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSCurrencyCate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).BeginInit();
            this.pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCurrencyCateName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCurrencyCateAbb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlCurrencyCate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCurrencyCate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinExchangeRate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dSCurrencyCate
            // 
            this.dSCurrencyCate.DataSetName = "NewDataSet";
            this.dSCurrencyCate.Tables.AddRange(new System.Data.DataTable[] {
            this.TableCurrencyCate});
            // 
            // TableCurrencyCate
            // 
            this.TableCurrencyCate.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColAutoId,
            this.dataColCurrencyCateAbb,
            this.dataColCurrencyCateName,
            this.dataColExchangeRate,
            this.dataColRemark});
            this.TableCurrencyCate.TableName = "CurrencyCate";
            this.TableCurrencyCate.TableNewRow += new System.Data.DataTableNewRowEventHandler(this.TableCurrencyCate_TableNewRow);
            // 
            // dataColAutoId
            // 
            this.dataColAutoId.ColumnName = "AutoId";
            this.dataColAutoId.DataType = typeof(int);
            // 
            // dataColCurrencyCateAbb
            // 
            this.dataColCurrencyCateAbb.Caption = "币种缩写";
            this.dataColCurrencyCateAbb.ColumnName = "CurrencyCateAbb";
            // 
            // dataColCurrencyCateName
            // 
            this.dataColCurrencyCateName.Caption = "币种名称";
            this.dataColCurrencyCateName.ColumnName = "CurrencyCateName";
            // 
            // dataColExchangeRate
            // 
            this.dataColExchangeRate.Caption = "汇率";
            this.dataColExchangeRate.ColumnName = "ExchangeRate";
            this.dataColExchangeRate.DataType = typeof(double);
            // 
            // bSCurrencyCate
            // 
            this.bSCurrencyCate.DataMember = "CurrencyCate";
            this.bSCurrencyCate.DataSource = this.dSCurrencyCate;
            // 
            // dataColRemark
            // 
            this.dataColRemark.Caption = "备注";
            this.dataColRemark.ColumnName = "Remark";
            // 
            // pnlToolBar
            // 
            this.pnlToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolBar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolBar.Name = "pnlToolBar";
            this.pnlToolBar.Size = new System.Drawing.Size(1024, 40);
            this.pnlToolBar.TabIndex = 2;
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.spinExchangeRate);
            this.pnlEdit.Controls.Add(this.labExchangeRate);
            this.pnlEdit.Controls.Add(this.textRemark);
            this.pnlEdit.Controls.Add(this.textCurrencyCateName);
            this.pnlEdit.Controls.Add(this.textCurrencyCateAbb);
            this.pnlEdit.Controls.Add(this.labRemark);
            this.pnlEdit.Controls.Add(this.labCurrencyCateName);
            this.pnlEdit.Controls.Add(this.labCurrencyCateAbb);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEdit.Location = new System.Drawing.Point(0, 40);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(1024, 97);
            this.pnlEdit.TabIndex = 6;
            // 
            // textRemark
            // 
            this.textRemark.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSCurrencyCate, "Remark", true));
            this.textRemark.Location = new System.Drawing.Point(112, 55);
            this.textRemark.Name = "textRemark";
            this.textRemark.Size = new System.Drawing.Size(448, 20);
            this.textRemark.TabIndex = 3;
            // 
            // textCurrencyCateName
            // 
            this.textCurrencyCateName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSCurrencyCate, "CurrencyCateName", true));
            this.textCurrencyCateName.EnterMoveNextControl = true;
            this.textCurrencyCateName.Location = new System.Drawing.Point(380, 21);
            this.textCurrencyCateName.Name = "textCurrencyCateName";
            this.textCurrencyCateName.Size = new System.Drawing.Size(180, 20);
            this.textCurrencyCateName.TabIndex = 1;
            // 
            // textCurrencyCateAbb
            // 
            this.textCurrencyCateAbb.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSCurrencyCate, "CurrencyCateAbb", true));
            this.textCurrencyCateAbb.EnterMoveNextControl = true;
            this.textCurrencyCateAbb.Location = new System.Drawing.Point(112, 21);
            this.textCurrencyCateAbb.Name = "textCurrencyCateAbb";
            this.textCurrencyCateAbb.Size = new System.Drawing.Size(150, 20);
            this.textCurrencyCateAbb.TabIndex = 0;
            // 
            // labRemark
            // 
            this.labRemark.Location = new System.Drawing.Point(36, 58);
            this.labRemark.Name = "labRemark";
            this.labRemark.Size = new System.Drawing.Size(24, 14);
            this.labRemark.TabIndex = 15;
            this.labRemark.Text = "备注";
            // 
            // labCurrencyCateName
            // 
            this.labCurrencyCateName.Location = new System.Drawing.Point(300, 24);
            this.labCurrencyCateName.Name = "labCurrencyCateName";
            this.labCurrencyCateName.Size = new System.Drawing.Size(48, 14);
            this.labCurrencyCateName.TabIndex = 14;
            this.labCurrencyCateName.Text = "币种名称";
            // 
            // labCurrencyCateAbb
            // 
            this.labCurrencyCateAbb.Location = new System.Drawing.Point(36, 24);
            this.labCurrencyCateAbb.Name = "labCurrencyCateAbb";
            this.labCurrencyCateAbb.Size = new System.Drawing.Size(48, 14);
            this.labCurrencyCateAbb.TabIndex = 12;
            this.labCurrencyCateAbb.Text = "币种缩写";
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.gridCrlCurrencyCate);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 137);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1024, 474);
            this.pnlGrid.TabIndex = 7;
            // 
            // gridCrlCurrencyCate
            // 
            this.gridCrlCurrencyCate.DataSource = this.bSCurrencyCate;
            this.gridCrlCurrencyCate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCrlCurrencyCate.Location = new System.Drawing.Point(2, 2);
            this.gridCrlCurrencyCate.MainView = this.gridViewCurrencyCate;
            this.gridCrlCurrencyCate.Name = "gridCrlCurrencyCate";
            this.gridCrlCurrencyCate.Size = new System.Drawing.Size(1020, 470);
            this.gridCrlCurrencyCate.TabIndex = 0;
            this.gridCrlCurrencyCate.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCurrencyCate});
            // 
            // gridViewCurrencyCate
            // 
            this.gridViewCurrencyCate.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId,
            this.colCurrencyCateAbb,
            this.colCurrencyCateName,
            this.colExchangeRate,
            this.colRemark});
            this.gridViewCurrencyCate.GridControl = this.gridCrlCurrencyCate;
            this.gridViewCurrencyCate.IndicatorWidth = 40;
            this.gridViewCurrencyCate.Name = "gridViewCurrencyCate";
            this.gridViewCurrencyCate.OptionsBehavior.Editable = false;
            this.gridViewCurrencyCate.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewCurrencyCate.OptionsView.ColumnAutoWidth = false;
            this.gridViewCurrencyCate.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewCurrencyCate.OptionsView.ShowFooter = true;
            this.gridViewCurrencyCate.OptionsView.ShowGroupPanel = false;
            this.gridViewCurrencyCate.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewCurrencyCate_CustomDrawRowIndicator);
            // 
            // labExchangeRate
            // 
            this.labExchangeRate.Location = new System.Drawing.Point(603, 24);
            this.labExchangeRate.Name = "labExchangeRate";
            this.labExchangeRate.Size = new System.Drawing.Size(24, 14);
            this.labExchangeRate.TabIndex = 16;
            this.labExchangeRate.Text = "汇率";
            // 
            // spinExchangeRate
            // 
            this.spinExchangeRate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSCurrencyCate, "ExchangeRate", true));
            this.spinExchangeRate.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinExchangeRate.EnterMoveNextControl = true;
            this.spinExchangeRate.Location = new System.Drawing.Point(665, 21);
            this.spinExchangeRate.Name = "spinExchangeRate";
            this.spinExchangeRate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinExchangeRate.Size = new System.Drawing.Size(180, 20);
            this.spinExchangeRate.TabIndex = 2;
            // 
            // colAutoId
            // 
            this.colAutoId.FieldName = "AutoId";
            this.colAutoId.Name = "colAutoId";
            // 
            // colCurrencyCateAbb
            // 
            this.colCurrencyCateAbb.AppearanceHeader.Options.UseTextOptions = true;
            this.colCurrencyCateAbb.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCurrencyCateAbb.FieldName = "CurrencyCateAbb";
            this.colCurrencyCateAbb.Name = "colCurrencyCateAbb";
            this.colCurrencyCateAbb.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "CurrencyCateAbb", "共计{0}条")});
            this.colCurrencyCateAbb.Visible = true;
            this.colCurrencyCateAbb.VisibleIndex = 0;
            this.colCurrencyCateAbb.Width = 150;
            // 
            // colCurrencyCateName
            // 
            this.colCurrencyCateName.AppearanceHeader.Options.UseTextOptions = true;
            this.colCurrencyCateName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCurrencyCateName.FieldName = "CurrencyCateName";
            this.colCurrencyCateName.Name = "colCurrencyCateName";
            this.colCurrencyCateName.Visible = true;
            this.colCurrencyCateName.VisibleIndex = 1;
            this.colCurrencyCateName.Width = 150;
            // 
            // colExchangeRate
            // 
            this.colExchangeRate.AppearanceHeader.Options.UseTextOptions = true;
            this.colExchangeRate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colExchangeRate.FieldName = "ExchangeRate";
            this.colExchangeRate.Name = "colExchangeRate";
            this.colExchangeRate.Visible = true;
            this.colExchangeRate.VisibleIndex = 2;
            this.colExchangeRate.Width = 150;
            // 
            // colRemark
            // 
            this.colRemark.AppearanceHeader.Options.UseTextOptions = true;
            this.colRemark.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 3;
            this.colRemark.Width = 200;
            // 
            // FrmCurrencyCate
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1024, 611);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.pnlToolBar);
            this.Name = "FrmCurrencyCate";
            this.TabText = "币种信息";
            this.Text = "币种信息";
            this.Load += new System.EventHandler(this.FrmCurrencyCate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSCurrencyCate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableCurrencyCate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSCurrencyCate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCurrencyCateName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCurrencyCateAbb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlCurrencyCate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCurrencyCate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinExchangeRate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dSCurrencyCate;
        private System.Data.DataTable TableCurrencyCate;
        private System.Data.DataColumn dataColAutoId;
        private System.Data.DataColumn dataColCurrencyCateAbb;
        private System.Data.DataColumn dataColCurrencyCateName;
        private System.Data.DataColumn dataColExchangeRate;
        private System.Data.DataColumn dataColRemark;
        private System.Windows.Forms.BindingSource bSCurrencyCate;
        private DevExpress.XtraEditors.PanelControl pnlToolBar;
        private DevExpress.XtraEditors.PanelControl pnlEdit;
        private DevExpress.XtraEditors.TextEdit textRemark;
        private DevExpress.XtraEditors.TextEdit textCurrencyCateName;
        private DevExpress.XtraEditors.TextEdit textCurrencyCateAbb;
        private DevExpress.XtraEditors.LabelControl labRemark;
        private DevExpress.XtraEditors.LabelControl labCurrencyCateName;
        private DevExpress.XtraEditors.LabelControl labCurrencyCateAbb;
        private DevExpress.XtraEditors.PanelControl pnlGrid;
        private DevExpress.XtraGrid.GridControl gridCrlCurrencyCate;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCurrencyCate;
        private DevExpress.XtraEditors.SpinEdit spinExchangeRate;
        private DevExpress.XtraEditors.LabelControl labExchangeRate;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyCateAbb;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyCateName;
        private DevExpress.XtraGrid.Columns.GridColumn colExchangeRate;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
    }
}