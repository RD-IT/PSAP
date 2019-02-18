namespace PSAP.VIEW.BSVIEW
{
    partial class FrmDeliveryLocation
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
            this.dSDeliveryLocation = new System.Data.DataSet();
            this.TableDeliveryLocation = new System.Data.DataTable();
            this.dataColAutoId = new System.Data.DataColumn();
            this.dataColLocationNo = new System.Data.DataColumn();
            this.dataColLocationName = new System.Data.DataColumn();
            this.dataColLocationDescription = new System.Data.DataColumn();
            this.bSDeliveryLocation = new System.Windows.Forms.BindingSource(this.components);
            this.pnlToolBar = new DevExpress.XtraEditors.PanelControl();
            this.pnlEdit = new DevExpress.XtraEditors.PanelControl();
            this.textLocationDescription = new DevExpress.XtraEditors.TextEdit();
            this.labLocationDescription = new DevExpress.XtraEditors.LabelControl();
            this.textLocationName = new DevExpress.XtraEditors.TextEdit();
            this.textLocationNo = new DevExpress.XtraEditors.TextEdit();
            this.labLocationName = new DevExpress.XtraEditors.LabelControl();
            this.labLocationNo = new DevExpress.XtraEditors.LabelControl();
            this.pnlGrid = new DevExpress.XtraEditors.PanelControl();
            this.gridCrlDeliveryLocation = new DevExpress.XtraGrid.GridControl();
            this.gridViewDeliveryLocation = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dSDeliveryLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableDeliveryLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSDeliveryLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).BeginInit();
            this.pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textLocationDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textLocationName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textLocationNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlDeliveryLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDeliveryLocation)).BeginInit();
            this.SuspendLayout();
            // 
            // dSDeliveryLocation
            // 
            this.dSDeliveryLocation.DataSetName = "NewDataSet";
            this.dSDeliveryLocation.Tables.AddRange(new System.Data.DataTable[] {
            this.TableDeliveryLocation});
            // 
            // TableDeliveryLocation
            // 
            this.TableDeliveryLocation.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColAutoId,
            this.dataColLocationNo,
            this.dataColLocationName,
            this.dataColLocationDescription});
            this.TableDeliveryLocation.TableName = "DeliveryLocation";
            // 
            // dataColAutoId
            // 
            this.dataColAutoId.ColumnName = "AutoId";
            this.dataColAutoId.DataType = typeof(int);
            // 
            // dataColLocationNo
            // 
            this.dataColLocationNo.Caption = "交货处编号";
            this.dataColLocationNo.ColumnName = "LocationNo";
            // 
            // dataColLocationName
            // 
            this.dataColLocationName.Caption = "交货处名称";
            this.dataColLocationName.ColumnName = "LocationName";
            // 
            // dataColLocationDescription
            // 
            this.dataColLocationDescription.Caption = "交货处说明";
            this.dataColLocationDescription.ColumnName = "LocationDescription";
            // 
            // bSDeliveryLocation
            // 
            this.bSDeliveryLocation.DataMember = "DeliveryLocation";
            this.bSDeliveryLocation.DataSource = this.dSDeliveryLocation;
            // 
            // pnlToolBar
            // 
            this.pnlToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolBar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolBar.Name = "pnlToolBar";
            this.pnlToolBar.Size = new System.Drawing.Size(942, 40);
            this.pnlToolBar.TabIndex = 4;
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.textLocationDescription);
            this.pnlEdit.Controls.Add(this.labLocationDescription);
            this.pnlEdit.Controls.Add(this.textLocationName);
            this.pnlEdit.Controls.Add(this.textLocationNo);
            this.pnlEdit.Controls.Add(this.labLocationName);
            this.pnlEdit.Controls.Add(this.labLocationNo);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEdit.Location = new System.Drawing.Point(0, 40);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(942, 68);
            this.pnlEdit.TabIndex = 8;
            // 
            // textLocationDescription
            // 
            this.textLocationDescription.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSDeliveryLocation, "LocationDescription", true));
            this.textLocationDescription.EnterMoveNextControl = true;
            this.textLocationDescription.Location = new System.Drawing.Point(638, 21);
            this.textLocationDescription.Name = "textLocationDescription";
            this.textLocationDescription.Size = new System.Drawing.Size(180, 20);
            this.textLocationDescription.TabIndex = 2;
            // 
            // labLocationDescription
            // 
            this.labLocationDescription.Location = new System.Drawing.Point(559, 24);
            this.labLocationDescription.Name = "labLocationDescription";
            this.labLocationDescription.Size = new System.Drawing.Size(60, 14);
            this.labLocationDescription.TabIndex = 16;
            this.labLocationDescription.Text = "交货处说明";
            // 
            // textLocationName
            // 
            this.textLocationName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSDeliveryLocation, "LocationName", true));
            this.textLocationName.EnterMoveNextControl = true;
            this.textLocationName.Location = new System.Drawing.Point(375, 21);
            this.textLocationName.Name = "textLocationName";
            this.textLocationName.Size = new System.Drawing.Size(150, 20);
            this.textLocationName.TabIndex = 1;
            // 
            // textLocationNo
            // 
            this.textLocationNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSDeliveryLocation, "LocationNo", true));
            this.textLocationNo.EnterMoveNextControl = true;
            this.textLocationNo.Location = new System.Drawing.Point(114, 21);
            this.textLocationNo.Name = "textLocationNo";
            this.textLocationNo.Size = new System.Drawing.Size(150, 20);
            this.textLocationNo.TabIndex = 0;
            // 
            // labLocationName
            // 
            this.labLocationName.Location = new System.Drawing.Point(297, 24);
            this.labLocationName.Name = "labLocationName";
            this.labLocationName.Size = new System.Drawing.Size(60, 14);
            this.labLocationName.TabIndex = 14;
            this.labLocationName.Text = "交货处名称";
            // 
            // labLocationNo
            // 
            this.labLocationNo.Location = new System.Drawing.Point(36, 24);
            this.labLocationNo.Name = "labLocationNo";
            this.labLocationNo.Size = new System.Drawing.Size(60, 14);
            this.labLocationNo.TabIndex = 12;
            this.labLocationNo.Text = "交货处编号";
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.gridCrlDeliveryLocation);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 108);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(942, 414);
            this.pnlGrid.TabIndex = 9;
            // 
            // gridCrlDeliveryLocation
            // 
            this.gridCrlDeliveryLocation.DataSource = this.bSDeliveryLocation;
            this.gridCrlDeliveryLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCrlDeliveryLocation.Location = new System.Drawing.Point(2, 2);
            this.gridCrlDeliveryLocation.MainView = this.gridViewDeliveryLocation;
            this.gridCrlDeliveryLocation.Name = "gridCrlDeliveryLocation";
            this.gridCrlDeliveryLocation.Size = new System.Drawing.Size(938, 410);
            this.gridCrlDeliveryLocation.TabIndex = 0;
            this.gridCrlDeliveryLocation.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDeliveryLocation});
            // 
            // gridViewDeliveryLocation
            // 
            this.gridViewDeliveryLocation.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId,
            this.colUnitNo,
            this.colUnitName,
            this.colUnitDescription});
            this.gridViewDeliveryLocation.GridControl = this.gridCrlDeliveryLocation;
            this.gridViewDeliveryLocation.IndicatorWidth = 40;
            this.gridViewDeliveryLocation.Name = "gridViewDeliveryLocation";
            this.gridViewDeliveryLocation.OptionsBehavior.Editable = false;
            this.gridViewDeliveryLocation.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewDeliveryLocation.OptionsView.ColumnAutoWidth = false;
            this.gridViewDeliveryLocation.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewDeliveryLocation.OptionsView.ShowFooter = true;
            this.gridViewDeliveryLocation.OptionsView.ShowGroupPanel = false;
            this.gridViewDeliveryLocation.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewDeliveryLocation_CustomDrawRowIndicator);
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
            this.colUnitNo.FieldName = "LocationNo";
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
            this.colUnitName.FieldName = "LocationName";
            this.colUnitName.Name = "colUnitName";
            this.colUnitName.Visible = true;
            this.colUnitName.VisibleIndex = 1;
            this.colUnitName.Width = 150;
            // 
            // colUnitDescription
            // 
            this.colUnitDescription.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnitDescription.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnitDescription.FieldName = "LocationDescription";
            this.colUnitDescription.Name = "colUnitDescription";
            this.colUnitDescription.Visible = true;
            this.colUnitDescription.VisibleIndex = 2;
            this.colUnitDescription.Width = 180;
            // 
            // FrmDeliveryLocation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(942, 522);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.pnlToolBar);
            this.Name = "FrmDeliveryLocation";
            this.TabText = "交货处";
            this.Text = "交货处";
            this.Load += new System.EventHandler(this.FrmDeliveryLocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSDeliveryLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableDeliveryLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSDeliveryLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textLocationDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textLocationName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textLocationNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlDeliveryLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDeliveryLocation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dSDeliveryLocation;
        private System.Data.DataTable TableDeliveryLocation;
        private System.Data.DataColumn dataColAutoId;
        private System.Data.DataColumn dataColLocationNo;
        private System.Data.DataColumn dataColLocationName;
        private System.Data.DataColumn dataColLocationDescription;
        private System.Windows.Forms.BindingSource bSDeliveryLocation;
        private DevExpress.XtraEditors.PanelControl pnlToolBar;
        private DevExpress.XtraEditors.PanelControl pnlEdit;
        private DevExpress.XtraEditors.TextEdit textLocationDescription;
        private DevExpress.XtraEditors.LabelControl labLocationDescription;
        private DevExpress.XtraEditors.TextEdit textLocationName;
        private DevExpress.XtraEditors.TextEdit textLocationNo;
        private DevExpress.XtraEditors.LabelControl labLocationName;
        private DevExpress.XtraEditors.LabelControl labLocationNo;
        private DevExpress.XtraEditors.PanelControl pnlGrid;
        private DevExpress.XtraGrid.GridControl gridCrlDeliveryLocation;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDeliveryLocation;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitNo;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitName;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitDescription;
    }
}