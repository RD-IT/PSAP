namespace PSAP.VIEW.BSVIEW
{
    partial class FrmManufactureInfo
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
            this.dSManufactureInfo = new System.Data.DataSet();
            this.TableManufactureInfo = new System.Data.DataTable();
            this.dataColAutoId = new System.Data.DataColumn();
            this.dataColManufactureNo = new System.Data.DataColumn();
            this.dataColManufactureName = new System.Data.DataColumn();
            this.dataColManufactureType = new System.Data.DataColumn();
            this.bSManufactureInfo = new System.Windows.Forms.BindingSource(this.components);
            this.pnlToolBar = new DevExpress.XtraEditors.PanelControl();
            this.pnlEdit = new DevExpress.XtraEditors.PanelControl();
            this.labManufactureType = new DevExpress.XtraEditors.LabelControl();
            this.radioManufactureType = new DevExpress.XtraEditors.RadioGroup();
            this.labManufactureName = new DevExpress.XtraEditors.LabelControl();
            this.labManufactureNo = new DevExpress.XtraEditors.LabelControl();
            this.textManufactureName = new DevExpress.XtraEditors.TextEdit();
            this.textManufactureNo = new DevExpress.XtraEditors.TextEdit();
            this.pnlGrid = new DevExpress.XtraEditors.PanelControl();
            this.gridCrlManufactureInfo = new DevExpress.XtraGrid.GridControl();
            this.gridViewManufactureInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManufactureNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManufactureName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManufactureType = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dSManufactureInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableManufactureInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSManufactureInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).BeginInit();
            this.pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioManufactureType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textManufactureName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textManufactureNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlManufactureInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewManufactureInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dSManufactureInfo
            // 
            this.dSManufactureInfo.DataSetName = "NewDataSet";
            this.dSManufactureInfo.Tables.AddRange(new System.Data.DataTable[] {
            this.TableManufactureInfo});
            // 
            // TableManufactureInfo
            // 
            this.TableManufactureInfo.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColAutoId,
            this.dataColManufactureNo,
            this.dataColManufactureName,
            this.dataColManufactureType});
            this.TableManufactureInfo.TableName = "ManufactureInfo";
            this.TableManufactureInfo.TableNewRow += new System.Data.DataTableNewRowEventHandler(this.TableManufactureInfo_TableNewRow);
            // 
            // dataColAutoId
            // 
            this.dataColAutoId.ColumnName = "AutoId";
            this.dataColAutoId.DataType = typeof(int);
            // 
            // dataColManufactureNo
            // 
            this.dataColManufactureNo.Caption = "工程编号";
            this.dataColManufactureNo.ColumnName = "ManufactureNo";
            // 
            // dataColManufactureName
            // 
            this.dataColManufactureName.Caption = "工程名称";
            this.dataColManufactureName.ColumnName = "ManufactureName";
            // 
            // dataColManufactureType
            // 
            this.dataColManufactureType.Caption = "工程类型";
            this.dataColManufactureType.ColumnName = "ManufactureType";
            this.dataColManufactureType.DataType = typeof(int);
            // 
            // bSManufactureInfo
            // 
            this.bSManufactureInfo.DataMember = "ManufactureInfo";
            this.bSManufactureInfo.DataSource = this.dSManufactureInfo;
            // 
            // pnlToolBar
            // 
            this.pnlToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolBar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolBar.Name = "pnlToolBar";
            this.pnlToolBar.Size = new System.Drawing.Size(917, 40);
            this.pnlToolBar.TabIndex = 4;
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.labManufactureType);
            this.pnlEdit.Controls.Add(this.radioManufactureType);
            this.pnlEdit.Controls.Add(this.labManufactureName);
            this.pnlEdit.Controls.Add(this.labManufactureNo);
            this.pnlEdit.Controls.Add(this.textManufactureName);
            this.pnlEdit.Controls.Add(this.textManufactureNo);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEdit.Location = new System.Drawing.Point(0, 40);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(917, 68);
            this.pnlEdit.TabIndex = 8;
            // 
            // labManufactureType
            // 
            this.labManufactureType.Location = new System.Drawing.Point(467, 24);
            this.labManufactureType.Name = "labManufactureType";
            this.labManufactureType.Size = new System.Drawing.Size(48, 14);
            this.labManufactureType.TabIndex = 18;
            this.labManufactureType.Text = "工程类型";
            // 
            // radioManufactureType
            // 
            this.radioManufactureType.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSManufactureInfo, "ManufactureType", true));
            this.radioManufactureType.Location = new System.Drawing.Point(533, 20);
            this.radioManufactureType.Name = "radioManufactureType";
            this.radioManufactureType.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioManufactureType.Properties.Appearance.Options.UseBackColor = true;
            this.radioManufactureType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioManufactureType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "正常"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "虚拟")});
            this.radioManufactureType.Size = new System.Drawing.Size(133, 22);
            this.radioManufactureType.TabIndex = 2;
            // 
            // labManufactureName
            // 
            this.labManufactureName.Location = new System.Drawing.Point(249, 24);
            this.labManufactureName.Name = "labManufactureName";
            this.labManufactureName.Size = new System.Drawing.Size(48, 14);
            this.labManufactureName.TabIndex = 15;
            this.labManufactureName.Text = "工程名称";
            // 
            // labManufactureNo
            // 
            this.labManufactureNo.Location = new System.Drawing.Point(36, 24);
            this.labManufactureNo.Name = "labManufactureNo";
            this.labManufactureNo.Size = new System.Drawing.Size(48, 14);
            this.labManufactureNo.TabIndex = 12;
            this.labManufactureNo.Text = "工程编号";
            // 
            // textManufactureName
            // 
            this.textManufactureName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSManufactureInfo, "ManufactureName", true));
            this.textManufactureName.Location = new System.Drawing.Point(318, 21);
            this.textManufactureName.Name = "textManufactureName";
            this.textManufactureName.Size = new System.Drawing.Size(120, 20);
            this.textManufactureName.TabIndex = 1;
            // 
            // textManufactureNo
            // 
            this.textManufactureNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSManufactureInfo, "ManufactureNo", true));
            this.textManufactureNo.EnterMoveNextControl = true;
            this.textManufactureNo.Location = new System.Drawing.Point(104, 21);
            this.textManufactureNo.Name = "textManufactureNo";
            this.textManufactureNo.Size = new System.Drawing.Size(120, 20);
            this.textManufactureNo.TabIndex = 0;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.gridCrlManufactureInfo);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 108);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(917, 434);
            this.pnlGrid.TabIndex = 9;
            // 
            // gridCrlManufactureInfo
            // 
            this.gridCrlManufactureInfo.DataSource = this.bSManufactureInfo;
            this.gridCrlManufactureInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCrlManufactureInfo.Location = new System.Drawing.Point(2, 2);
            this.gridCrlManufactureInfo.MainView = this.gridViewManufactureInfo;
            this.gridCrlManufactureInfo.Name = "gridCrlManufactureInfo";
            this.gridCrlManufactureInfo.Size = new System.Drawing.Size(913, 430);
            this.gridCrlManufactureInfo.TabIndex = 0;
            this.gridCrlManufactureInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewManufactureInfo});
            // 
            // gridViewManufactureInfo
            // 
            this.gridViewManufactureInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId,
            this.colManufactureNo,
            this.colManufactureName,
            this.colManufactureType});
            this.gridViewManufactureInfo.GridControl = this.gridCrlManufactureInfo;
            this.gridViewManufactureInfo.IndicatorWidth = 40;
            this.gridViewManufactureInfo.Name = "gridViewManufactureInfo";
            this.gridViewManufactureInfo.OptionsBehavior.Editable = false;
            this.gridViewManufactureInfo.OptionsFilter.AllowFilterEditor = false;
            this.gridViewManufactureInfo.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewManufactureInfo.OptionsView.ColumnAutoWidth = false;
            this.gridViewManufactureInfo.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewManufactureInfo.OptionsView.ShowFooter = true;
            this.gridViewManufactureInfo.OptionsView.ShowGroupPanel = false;
            this.gridViewManufactureInfo.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewManufactureInfo_CustomDrawRowIndicator);
            this.gridViewManufactureInfo.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridViewManufactureInfo_CustomColumnDisplayText);
            // 
            // colAutoId
            // 
            this.colAutoId.AppearanceHeader.Options.UseTextOptions = true;
            this.colAutoId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAutoId.FieldName = "AutoId";
            this.colAutoId.Name = "colAutoId";
            // 
            // colManufactureNo
            // 
            this.colManufactureNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colManufactureNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colManufactureNo.FieldName = "ManufactureNo";
            this.colManufactureNo.Name = "colManufactureNo";
            this.colManufactureNo.Visible = true;
            this.colManufactureNo.VisibleIndex = 0;
            this.colManufactureNo.Width = 120;
            // 
            // colManufactureName
            // 
            this.colManufactureName.AppearanceHeader.Options.UseTextOptions = true;
            this.colManufactureName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colManufactureName.FieldName = "ManufactureName";
            this.colManufactureName.Name = "colManufactureName";
            this.colManufactureName.Visible = true;
            this.colManufactureName.VisibleIndex = 1;
            this.colManufactureName.Width = 120;
            // 
            // colManufactureType
            // 
            this.colManufactureType.AppearanceHeader.Options.UseTextOptions = true;
            this.colManufactureType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colManufactureType.FieldName = "ManufactureType";
            this.colManufactureType.Name = "colManufactureType";
            this.colManufactureType.Visible = true;
            this.colManufactureType.VisibleIndex = 2;
            this.colManufactureType.Width = 120;
            // 
            // FrmManufactureInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(917, 542);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.pnlToolBar);
            this.Name = "FrmManufactureInfo";
            this.TabText = "制造工程信息";
            this.Text = "制造工程信息";
            this.Load += new System.EventHandler(this.FrmManufactureInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSManufactureInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableManufactureInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSManufactureInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioManufactureType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textManufactureName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textManufactureNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlManufactureInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewManufactureInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dSManufactureInfo;
        private System.Data.DataTable TableManufactureInfo;
        private System.Data.DataColumn dataColAutoId;
        private System.Data.DataColumn dataColManufactureNo;
        private System.Data.DataColumn dataColManufactureName;
        private System.Data.DataColumn dataColManufactureType;
        private System.Windows.Forms.BindingSource bSManufactureInfo;
        private DevExpress.XtraEditors.PanelControl pnlToolBar;
        private DevExpress.XtraEditors.PanelControl pnlEdit;
        private DevExpress.XtraEditors.LabelControl labManufactureType;
        private DevExpress.XtraEditors.RadioGroup radioManufactureType;
        private DevExpress.XtraEditors.LabelControl labManufactureName;
        private DevExpress.XtraEditors.LabelControl labManufactureNo;
        private DevExpress.XtraEditors.TextEdit textManufactureName;
        private DevExpress.XtraEditors.TextEdit textManufactureNo;
        private DevExpress.XtraEditors.PanelControl pnlGrid;
        private DevExpress.XtraGrid.GridControl gridCrlManufactureInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewManufactureInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colManufactureNo;
        private DevExpress.XtraGrid.Columns.GridColumn colManufactureName;
        private DevExpress.XtraGrid.Columns.GridColumn colManufactureType;
    }
}