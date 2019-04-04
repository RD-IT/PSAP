namespace PSAP.VIEW.BSVIEW
{
    partial class FrmWarehouseReceiptType
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
            this.pnlEdit = new DevExpress.XtraEditors.PanelControl();
            this.textWarehouseReceiptTypeName = new DevExpress.XtraEditors.TextEdit();
            this.bSWarehouseReceiptType = new System.Windows.Forms.BindingSource(this.components);
            this.dSWarehouseReceiptType = new System.Data.DataSet();
            this.TableWarehouseReceiptType = new System.Data.DataTable();
            this.dataColAutoId = new System.Data.DataColumn();
            this.dataColWarehouseReceiptTypeNo = new System.Data.DataColumn();
            this.dataColWarehouseReceiptTypeName = new System.Data.DataColumn();
            this.dataColIsDefault = new System.Data.DataColumn();
            this.textWarehouseReceiptTypeNo = new DevExpress.XtraEditors.TextEdit();
            this.labWarehouseReceiptTypeName = new DevExpress.XtraEditors.LabelControl();
            this.labWarehouseReceiptTypeNo = new DevExpress.XtraEditors.LabelControl();
            this.pnlToolBar = new DevExpress.XtraEditors.PanelControl();
            this.btnSetDefault = new DevExpress.XtraEditors.SimpleButton();
            this.pnlGrid = new DevExpress.XtraEditors.PanelControl();
            this.gridCrlWarehouseReceiptType = new DevExpress.XtraGrid.GridControl();
            this.gridViewWarehouseReceiptType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWarehouseReceiptTypeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWarehouseReceiptTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsDefault = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSdmrcklbcg = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCklbbhbnwkqcxcz = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCklbmcbnwkqcxcz = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).BeginInit();
            this.pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textWarehouseReceiptTypeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSWarehouseReceiptType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSWarehouseReceiptType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableWarehouseReceiptType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textWarehouseReceiptTypeNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).BeginInit();
            this.pnlToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlWarehouseReceiptType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWarehouseReceiptType)).BeginInit();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.textWarehouseReceiptTypeName);
            this.pnlEdit.Controls.Add(this.textWarehouseReceiptTypeNo);
            this.pnlEdit.Controls.Add(this.labWarehouseReceiptTypeName);
            this.pnlEdit.Controls.Add(this.labWarehouseReceiptTypeNo);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEdit.Location = new System.Drawing.Point(0, 40);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(784, 68);
            this.pnlEdit.TabIndex = 9;
            // 
            // textWarehouseReceiptTypeName
            // 
            this.textWarehouseReceiptTypeName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSWarehouseReceiptType, "WarehouseReceiptTypeName", true));
            this.textWarehouseReceiptTypeName.Location = new System.Drawing.Point(411, 21);
            this.textWarehouseReceiptTypeName.Name = "textWarehouseReceiptTypeName";
            this.textWarehouseReceiptTypeName.Size = new System.Drawing.Size(160, 20);
            this.textWarehouseReceiptTypeName.TabIndex = 1;
            // 
            // bSWarehouseReceiptType
            // 
            this.bSWarehouseReceiptType.DataMember = "WarehouseReceiptType";
            this.bSWarehouseReceiptType.DataSource = this.dSWarehouseReceiptType;
            // 
            // dSWarehouseReceiptType
            // 
            this.dSWarehouseReceiptType.DataSetName = "NewDataSet";
            this.dSWarehouseReceiptType.Tables.AddRange(new System.Data.DataTable[] {
            this.TableWarehouseReceiptType});
            // 
            // TableWarehouseReceiptType
            // 
            this.TableWarehouseReceiptType.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColAutoId,
            this.dataColWarehouseReceiptTypeNo,
            this.dataColWarehouseReceiptTypeName,
            this.dataColIsDefault});
            this.TableWarehouseReceiptType.TableName = "WarehouseReceiptType";
            this.TableWarehouseReceiptType.TableNewRow += new System.Data.DataTableNewRowEventHandler(this.TableWarehouseReceiptType_TableNewRow);
            // 
            // dataColAutoId
            // 
            this.dataColAutoId.ColumnName = "AutoId";
            this.dataColAutoId.DataType = typeof(int);
            // 
            // dataColWarehouseReceiptTypeNo
            // 
            this.dataColWarehouseReceiptTypeNo.Caption = "出库类别编号";
            this.dataColWarehouseReceiptTypeNo.ColumnName = "WarehouseReceiptTypeNo";
            // 
            // dataColWarehouseReceiptTypeName
            // 
            this.dataColWarehouseReceiptTypeName.Caption = "出库类别名称";
            this.dataColWarehouseReceiptTypeName.ColumnName = "WarehouseReceiptTypeName";
            // 
            // dataColIsDefault
            // 
            this.dataColIsDefault.Caption = "默认";
            this.dataColIsDefault.ColumnName = "IsDefault";
            this.dataColIsDefault.DataType = typeof(bool);
            // 
            // textWarehouseReceiptTypeNo
            // 
            this.textWarehouseReceiptTypeNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSWarehouseReceiptType, "WarehouseReceiptTypeNo", true));
            this.textWarehouseReceiptTypeNo.EnterMoveNextControl = true;
            this.textWarehouseReceiptTypeNo.Location = new System.Drawing.Point(131, 21);
            this.textWarehouseReceiptTypeNo.Name = "textWarehouseReceiptTypeNo";
            this.textWarehouseReceiptTypeNo.Size = new System.Drawing.Size(160, 20);
            this.textWarehouseReceiptTypeNo.TabIndex = 0;
            // 
            // labWarehouseReceiptTypeName
            // 
            this.labWarehouseReceiptTypeName.Location = new System.Drawing.Point(312, 24);
            this.labWarehouseReceiptTypeName.Name = "labWarehouseReceiptTypeName";
            this.labWarehouseReceiptTypeName.Size = new System.Drawing.Size(72, 14);
            this.labWarehouseReceiptTypeName.TabIndex = 15;
            this.labWarehouseReceiptTypeName.Text = "出库类别名称";
            // 
            // labWarehouseReceiptTypeNo
            // 
            this.labWarehouseReceiptTypeNo.Location = new System.Drawing.Point(36, 24);
            this.labWarehouseReceiptTypeNo.Name = "labWarehouseReceiptTypeNo";
            this.labWarehouseReceiptTypeNo.Size = new System.Drawing.Size(72, 14);
            this.labWarehouseReceiptTypeNo.TabIndex = 12;
            this.labWarehouseReceiptTypeNo.Text = "出库类别编号";
            // 
            // pnlToolBar
            // 
            this.pnlToolBar.Controls.Add(this.btnSetDefault);
            this.pnlToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolBar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolBar.Name = "pnlToolBar";
            this.pnlToolBar.Size = new System.Drawing.Size(784, 40);
            this.pnlToolBar.TabIndex = 8;
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
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.gridCrlWarehouseReceiptType);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 108);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(784, 253);
            this.pnlGrid.TabIndex = 10;
            // 
            // gridCrlWarehouseReceiptType
            // 
            this.gridCrlWarehouseReceiptType.DataSource = this.bSWarehouseReceiptType;
            this.gridCrlWarehouseReceiptType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCrlWarehouseReceiptType.Location = new System.Drawing.Point(2, 2);
            this.gridCrlWarehouseReceiptType.MainView = this.gridViewWarehouseReceiptType;
            this.gridCrlWarehouseReceiptType.Name = "gridCrlWarehouseReceiptType";
            this.gridCrlWarehouseReceiptType.Size = new System.Drawing.Size(780, 249);
            this.gridCrlWarehouseReceiptType.TabIndex = 0;
            this.gridCrlWarehouseReceiptType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewWarehouseReceiptType});
            // 
            // gridViewWarehouseReceiptType
            // 
            this.gridViewWarehouseReceiptType.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId,
            this.colWarehouseReceiptTypeNo,
            this.colWarehouseReceiptTypeName,
            this.colIsDefault});
            this.gridViewWarehouseReceiptType.GridControl = this.gridCrlWarehouseReceiptType;
            this.gridViewWarehouseReceiptType.IndicatorWidth = 40;
            this.gridViewWarehouseReceiptType.Name = "gridViewWarehouseReceiptType";
            this.gridViewWarehouseReceiptType.OptionsBehavior.Editable = false;
            this.gridViewWarehouseReceiptType.OptionsFilter.AllowFilterEditor = false;
            this.gridViewWarehouseReceiptType.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewWarehouseReceiptType.OptionsView.ColumnAutoWidth = false;
            this.gridViewWarehouseReceiptType.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewWarehouseReceiptType.OptionsView.ShowFooter = true;
            this.gridViewWarehouseReceiptType.OptionsView.ShowGroupPanel = false;
            // 
            // colAutoId
            // 
            this.colAutoId.AppearanceHeader.Options.UseTextOptions = true;
            this.colAutoId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAutoId.FieldName = "AutoId";
            this.colAutoId.Name = "colAutoId";
            // 
            // colWarehouseReceiptTypeNo
            // 
            this.colWarehouseReceiptTypeNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colWarehouseReceiptTypeNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWarehouseReceiptTypeNo.FieldName = "WarehouseReceiptTypeNo";
            this.colWarehouseReceiptTypeNo.Name = "colWarehouseReceiptTypeNo";
            this.colWarehouseReceiptTypeNo.Visible = true;
            this.colWarehouseReceiptTypeNo.VisibleIndex = 0;
            this.colWarehouseReceiptTypeNo.Width = 160;
            // 
            // colWarehouseReceiptTypeName
            // 
            this.colWarehouseReceiptTypeName.AppearanceHeader.Options.UseTextOptions = true;
            this.colWarehouseReceiptTypeName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWarehouseReceiptTypeName.FieldName = "WarehouseReceiptTypeName";
            this.colWarehouseReceiptTypeName.Name = "colWarehouseReceiptTypeName";
            this.colWarehouseReceiptTypeName.Visible = true;
            this.colWarehouseReceiptTypeName.VisibleIndex = 1;
            this.colWarehouseReceiptTypeName.Width = 160;
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
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSdmrcklbcg,
            this.tsmiCklbbhbnwkqcxcz,
            this.tsmiCklbmcbnwkqcxcz});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(281, 92);
            // 
            // tsmiSdmrcklbcg
            // 
            this.tsmiSdmrcklbcg.Name = "tsmiSdmrcklbcg";
            this.tsmiSdmrcklbcg.Size = new System.Drawing.Size(280, 22);
            this.tsmiSdmrcklbcg.Text = "设定默认出库类别成功。";
            // 
            // tsmiCklbbhbnwkqcxcz
            // 
            this.tsmiCklbbhbnwkqcxcz.Name = "tsmiCklbbhbnwkqcxcz";
            this.tsmiCklbbhbnwkqcxcz.Size = new System.Drawing.Size(280, 22);
            this.tsmiCklbbhbnwkqcxcz.Text = "出库类别编号不能为空，请重新操作。";
            // 
            // tsmiCklbmcbnwkqcxcz
            // 
            this.tsmiCklbmcbnwkqcxcz.Name = "tsmiCklbmcbnwkqcxcz";
            this.tsmiCklbmcbnwkqcxcz.Size = new System.Drawing.Size(280, 22);
            this.tsmiCklbmcbnwkqcxcz.Text = "出库类别名称不能为空，请重新操作。";
            // 
            // FrmWarehouseReceiptType
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.pnlToolBar);
            this.Name = "FrmWarehouseReceiptType";
            this.TabText = "出库类别";
            this.Text = "出库类别";
            this.Load += new System.EventHandler(this.FrmWarehouseReceiptType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textWarehouseReceiptTypeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSWarehouseReceiptType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSWarehouseReceiptType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableWarehouseReceiptType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textWarehouseReceiptTypeNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).EndInit();
            this.pnlToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlWarehouseReceiptType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWarehouseReceiptType)).EndInit();
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlEdit;
        private DevExpress.XtraEditors.LabelControl labWarehouseReceiptTypeName;
        private DevExpress.XtraEditors.LabelControl labWarehouseReceiptTypeNo;
        private DevExpress.XtraEditors.TextEdit textWarehouseReceiptTypeName;
        private DevExpress.XtraEditors.TextEdit textWarehouseReceiptTypeNo;
        private DevExpress.XtraEditors.PanelControl pnlToolBar;
        private DevExpress.XtraEditors.SimpleButton btnSetDefault;
        private System.Data.DataSet dSWarehouseReceiptType;
        private System.Data.DataTable TableWarehouseReceiptType;
        private System.Data.DataColumn dataColAutoId;
        private System.Data.DataColumn dataColWarehouseReceiptTypeNo;
        private System.Data.DataColumn dataColWarehouseReceiptTypeName;
        private System.Data.DataColumn dataColIsDefault;
        private System.Windows.Forms.BindingSource bSWarehouseReceiptType;
        private DevExpress.XtraEditors.PanelControl pnlGrid;
        private DevExpress.XtraGrid.GridControl gridCrlWarehouseReceiptType;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewWarehouseReceiptType;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouseReceiptTypeNo;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouseReceiptTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colIsDefault;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem tsmiSdmrcklbcg;
        private System.Windows.Forms.ToolStripMenuItem tsmiCklbbhbnwkqcxcz;
        private System.Windows.Forms.ToolStripMenuItem tsmiCklbmcbnwkqcxcz;
    }
}