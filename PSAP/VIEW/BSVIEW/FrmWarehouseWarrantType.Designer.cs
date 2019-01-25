namespace PSAP.VIEW.BSVIEW
{
    partial class FrmWarehouseWarrantType
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
            this.dSWarehouseWarrantType = new System.Data.DataSet();
            this.TableWarehouseWarrantType = new System.Data.DataTable();
            this.dataColAutoId = new System.Data.DataColumn();
            this.dataColWarehouseWarrantTypeNo = new System.Data.DataColumn();
            this.dataColWarehouseWarrantTypeName = new System.Data.DataColumn();
            this.dataColIsDefault = new System.Data.DataColumn();
            this.bSWarehouseWarrantType = new System.Windows.Forms.BindingSource(this.components);
            this.pnlToolBar = new DevExpress.XtraEditors.PanelControl();
            this.btnSetDefault = new DevExpress.XtraEditors.SimpleButton();
            this.pnlEdit = new DevExpress.XtraEditors.PanelControl();
            this.textWarehouseWarrantTypeName = new DevExpress.XtraEditors.TextEdit();
            this.textWarehouseWarrantTypeNo = new DevExpress.XtraEditors.TextEdit();
            this.labWarehouseWarrantTypeName = new DevExpress.XtraEditors.LabelControl();
            this.labWarehouseWarrantTypeNo = new DevExpress.XtraEditors.LabelControl();
            this.pnlGrid = new DevExpress.XtraEditors.PanelControl();
            this.gridCrlWarehouseWarrantType = new DevExpress.XtraGrid.GridControl();
            this.gridViewWarehouseWarrantType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWarehouseWarrantTypeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWarehouseWarrantTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsDefault = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dSWarehouseWarrantType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableWarehouseWarrantType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSWarehouseWarrantType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).BeginInit();
            this.pnlToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).BeginInit();
            this.pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textWarehouseWarrantTypeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textWarehouseWarrantTypeNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlWarehouseWarrantType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWarehouseWarrantType)).BeginInit();
            this.SuspendLayout();
            // 
            // dSWarehouseWarrantType
            // 
            this.dSWarehouseWarrantType.DataSetName = "NewDataSet";
            this.dSWarehouseWarrantType.Tables.AddRange(new System.Data.DataTable[] {
            this.TableWarehouseWarrantType});
            // 
            // TableWarehouseWarrantType
            // 
            this.TableWarehouseWarrantType.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColAutoId,
            this.dataColWarehouseWarrantTypeNo,
            this.dataColWarehouseWarrantTypeName,
            this.dataColIsDefault});
            this.TableWarehouseWarrantType.TableName = "WarehouseWarrantType";
            this.TableWarehouseWarrantType.TableNewRow += new System.Data.DataTableNewRowEventHandler(this.TableWarehouseWarrantType_TableNewRow);
            // 
            // dataColAutoId
            // 
            this.dataColAutoId.ColumnName = "AutoId";
            this.dataColAutoId.DataType = typeof(int);
            // 
            // dataColWarehouseWarrantTypeNo
            // 
            this.dataColWarehouseWarrantTypeNo.Caption = "入库类别编号";
            this.dataColWarehouseWarrantTypeNo.ColumnName = "WarehouseWarrantTypeNo";
            // 
            // dataColWarehouseWarrantTypeName
            // 
            this.dataColWarehouseWarrantTypeName.Caption = "入库类别名称";
            this.dataColWarehouseWarrantTypeName.ColumnName = "WarehouseWarrantTypeName";
            // 
            // dataColIsDefault
            // 
            this.dataColIsDefault.Caption = "默认";
            this.dataColIsDefault.ColumnName = "IsDefault";
            this.dataColIsDefault.DataType = typeof(bool);
            // 
            // bSWarehouseWarrantType
            // 
            this.bSWarehouseWarrantType.DataMember = "WarehouseWarrantType";
            this.bSWarehouseWarrantType.DataSource = this.dSWarehouseWarrantType;
            // 
            // pnlToolBar
            // 
            this.pnlToolBar.Controls.Add(this.btnSetDefault);
            this.pnlToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolBar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolBar.Name = "pnlToolBar";
            this.pnlToolBar.Size = new System.Drawing.Size(784, 40);
            this.pnlToolBar.TabIndex = 3;
            // 
            // btnSetDefault
            // 
            this.btnSetDefault.Location = new System.Drawing.Point(496, 9);
            this.btnSetDefault.Name = "btnSetDefault";
            this.btnSetDefault.Size = new System.Drawing.Size(75, 23);
            this.btnSetDefault.TabIndex = 17;
            this.btnSetDefault.TabStop = false;
            this.btnSetDefault.Text = "设为默认";
            this.btnSetDefault.Click += new System.EventHandler(this.btnSetDefault_Click);
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.textWarehouseWarrantTypeName);
            this.pnlEdit.Controls.Add(this.textWarehouseWarrantTypeNo);
            this.pnlEdit.Controls.Add(this.labWarehouseWarrantTypeName);
            this.pnlEdit.Controls.Add(this.labWarehouseWarrantTypeNo);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEdit.Location = new System.Drawing.Point(0, 40);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(784, 68);
            this.pnlEdit.TabIndex = 7;
            // 
            // textWarehouseWarrantTypeName
            // 
            this.textWarehouseWarrantTypeName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSWarehouseWarrantType, "WarehouseWarrantTypeName", true));
            this.textWarehouseWarrantTypeName.Location = new System.Drawing.Point(384, 21);
            this.textWarehouseWarrantTypeName.Name = "textWarehouseWarrantTypeName";
            this.textWarehouseWarrantTypeName.Size = new System.Drawing.Size(120, 20);
            this.textWarehouseWarrantTypeName.TabIndex = 1;
            // 
            // textWarehouseWarrantTypeNo
            // 
            this.textWarehouseWarrantTypeNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSWarehouseWarrantType, "WarehouseWarrantTypeNo", true));
            this.textWarehouseWarrantTypeNo.EnterMoveNextControl = true;
            this.textWarehouseWarrantTypeNo.Location = new System.Drawing.Point(130, 21);
            this.textWarehouseWarrantTypeNo.Name = "textWarehouseWarrantTypeNo";
            this.textWarehouseWarrantTypeNo.Size = new System.Drawing.Size(120, 20);
            this.textWarehouseWarrantTypeNo.TabIndex = 0;
            // 
            // labWarehouseWarrantTypeName
            // 
            this.labWarehouseWarrantTypeName.Location = new System.Drawing.Point(284, 24);
            this.labWarehouseWarrantTypeName.Name = "labWarehouseWarrantTypeName";
            this.labWarehouseWarrantTypeName.Size = new System.Drawing.Size(72, 14);
            this.labWarehouseWarrantTypeName.TabIndex = 15;
            this.labWarehouseWarrantTypeName.Text = "入库类别名称";
            // 
            // labWarehouseWarrantTypeNo
            // 
            this.labWarehouseWarrantTypeNo.Location = new System.Drawing.Point(36, 24);
            this.labWarehouseWarrantTypeNo.Name = "labWarehouseWarrantTypeNo";
            this.labWarehouseWarrantTypeNo.Size = new System.Drawing.Size(72, 14);
            this.labWarehouseWarrantTypeNo.TabIndex = 12;
            this.labWarehouseWarrantTypeNo.Text = "入库类别编号";
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.gridCrlWarehouseWarrantType);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 108);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(784, 253);
            this.pnlGrid.TabIndex = 8;
            // 
            // gridCrlWarehouseWarrantType
            // 
            this.gridCrlWarehouseWarrantType.DataSource = this.bSWarehouseWarrantType;
            this.gridCrlWarehouseWarrantType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCrlWarehouseWarrantType.Location = new System.Drawing.Point(2, 2);
            this.gridCrlWarehouseWarrantType.MainView = this.gridViewWarehouseWarrantType;
            this.gridCrlWarehouseWarrantType.Name = "gridCrlWarehouseWarrantType";
            this.gridCrlWarehouseWarrantType.Size = new System.Drawing.Size(780, 249);
            this.gridCrlWarehouseWarrantType.TabIndex = 0;
            this.gridCrlWarehouseWarrantType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewWarehouseWarrantType});
            // 
            // gridViewWarehouseWarrantType
            // 
            this.gridViewWarehouseWarrantType.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId,
            this.colWarehouseWarrantTypeNo,
            this.colWarehouseWarrantTypeName,
            this.colIsDefault});
            this.gridViewWarehouseWarrantType.GridControl = this.gridCrlWarehouseWarrantType;
            this.gridViewWarehouseWarrantType.IndicatorWidth = 40;
            this.gridViewWarehouseWarrantType.Name = "gridViewWarehouseWarrantType";
            this.gridViewWarehouseWarrantType.OptionsBehavior.Editable = false;
            this.gridViewWarehouseWarrantType.OptionsFilter.AllowFilterEditor = false;
            this.gridViewWarehouseWarrantType.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewWarehouseWarrantType.OptionsView.ColumnAutoWidth = false;
            this.gridViewWarehouseWarrantType.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewWarehouseWarrantType.OptionsView.ShowFooter = true;
            this.gridViewWarehouseWarrantType.OptionsView.ShowGroupPanel = false;
            this.gridViewWarehouseWarrantType.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewWarehouseWarrantType_CustomDrawRowIndicator);
            // 
            // colAutoId
            // 
            this.colAutoId.AppearanceHeader.Options.UseTextOptions = true;
            this.colAutoId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAutoId.FieldName = "AutoId";
            this.colAutoId.Name = "colAutoId";
            // 
            // colWarehouseWarrantTypeNo
            // 
            this.colWarehouseWarrantTypeNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colWarehouseWarrantTypeNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWarehouseWarrantTypeNo.FieldName = "WarehouseWarrantTypeNo";
            this.colWarehouseWarrantTypeNo.Name = "colWarehouseWarrantTypeNo";
            this.colWarehouseWarrantTypeNo.Visible = true;
            this.colWarehouseWarrantTypeNo.VisibleIndex = 0;
            this.colWarehouseWarrantTypeNo.Width = 120;
            // 
            // colWarehouseWarrantTypeName
            // 
            this.colWarehouseWarrantTypeName.AppearanceHeader.Options.UseTextOptions = true;
            this.colWarehouseWarrantTypeName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWarehouseWarrantTypeName.FieldName = "WarehouseWarrantTypeName";
            this.colWarehouseWarrantTypeName.Name = "colWarehouseWarrantTypeName";
            this.colWarehouseWarrantTypeName.Visible = true;
            this.colWarehouseWarrantTypeName.VisibleIndex = 1;
            this.colWarehouseWarrantTypeName.Width = 120;
            // 
            // colIsDefault
            // 
            this.colIsDefault.AppearanceHeader.Options.UseTextOptions = true;
            this.colIsDefault.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIsDefault.FieldName = "IsDefault";
            this.colIsDefault.Name = "colIsDefault";
            this.colIsDefault.Visible = true;
            this.colIsDefault.VisibleIndex = 2;
            this.colIsDefault.Width = 100;
            // 
            // FrmWarehouseWarrantType
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.pnlToolBar);
            this.Name = "FrmWarehouseWarrantType";
            this.TabText = "入库类别";
            this.Text = "入库类别";
            this.Load += new System.EventHandler(this.FrmWarehouseWarrantType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSWarehouseWarrantType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableWarehouseWarrantType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSWarehouseWarrantType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).EndInit();
            this.pnlToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textWarehouseWarrantTypeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textWarehouseWarrantTypeNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlWarehouseWarrantType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWarehouseWarrantType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dSWarehouseWarrantType;
        private System.Data.DataTable TableWarehouseWarrantType;
        private System.Data.DataColumn dataColAutoId;
        private System.Data.DataColumn dataColWarehouseWarrantTypeNo;
        private System.Data.DataColumn dataColWarehouseWarrantTypeName;
        private System.Windows.Forms.BindingSource bSWarehouseWarrantType;
        private System.Data.DataColumn dataColIsDefault;
        private DevExpress.XtraEditors.PanelControl pnlToolBar;
        private DevExpress.XtraEditors.PanelControl pnlEdit;
        private DevExpress.XtraEditors.LabelControl labWarehouseWarrantTypeName;
        private DevExpress.XtraEditors.LabelControl labWarehouseWarrantTypeNo;
        private DevExpress.XtraEditors.TextEdit textWarehouseWarrantTypeName;
        private DevExpress.XtraEditors.TextEdit textWarehouseWarrantTypeNo;
        private DevExpress.XtraEditors.PanelControl pnlGrid;
        private DevExpress.XtraGrid.GridControl gridCrlWarehouseWarrantType;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewWarehouseWarrantType;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouseWarrantTypeNo;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouseWarrantTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colIsDefault;
        private DevExpress.XtraEditors.SimpleButton btnSetDefault;
    }
}