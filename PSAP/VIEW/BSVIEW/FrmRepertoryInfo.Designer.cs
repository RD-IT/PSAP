namespace PSAP.VIEW.BSVIEW
{
    partial class FrmRepertoryInfo
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
            this.dSRepertoryInfo = new System.Data.DataSet();
            this.TableRepertoryInfo = new System.Data.DataTable();
            this.dataColAutoId = new System.Data.DataColumn();
            this.dataColRepertoryNo = new System.Data.DataColumn();
            this.dataColRepertoryName = new System.Data.DataColumn();
            this.dataColRepertoryType = new System.Data.DataColumn();
            this.bSRepertoryInfo = new System.Windows.Forms.BindingSource(this.components);
            this.pnlToolBar = new DevExpress.XtraEditors.PanelControl();
            this.pnlEdit = new DevExpress.XtraEditors.PanelControl();
            this.labRepertoryType = new DevExpress.XtraEditors.LabelControl();
            this.radioRepertoryType = new DevExpress.XtraEditors.RadioGroup();
            this.labRepertoryName = new DevExpress.XtraEditors.LabelControl();
            this.labRepertoryNo = new DevExpress.XtraEditors.LabelControl();
            this.textRepertoryName = new DevExpress.XtraEditors.TextEdit();
            this.textRepertoryNo = new DevExpress.XtraEditors.TextEdit();
            this.pnlGrid = new DevExpress.XtraEditors.PanelControl();
            this.gridCrlRepertoryInfo = new DevExpress.XtraGrid.GridControl();
            this.gridViewRepertoryInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRepertoryNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRepertoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRepertoryType = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dSRepertoryInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableRepertoryInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSRepertoryInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).BeginInit();
            this.pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioRepertoryType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRepertoryName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRepertoryNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlRepertoryInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRepertoryInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dSRepertoryInfo
            // 
            this.dSRepertoryInfo.DataSetName = "NewDataSet";
            this.dSRepertoryInfo.Tables.AddRange(new System.Data.DataTable[] {
            this.TableRepertoryInfo});
            // 
            // TableRepertoryInfo
            // 
            this.TableRepertoryInfo.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColAutoId,
            this.dataColRepertoryNo,
            this.dataColRepertoryName,
            this.dataColRepertoryType});
            this.TableRepertoryInfo.TableName = "RepertoryInfo";
            this.TableRepertoryInfo.TableNewRow += new System.Data.DataTableNewRowEventHandler(this.TableRepertoryInfo_TableNewRow);
            // 
            // dataColAutoId
            // 
            this.dataColAutoId.ColumnName = "AutoId";
            this.dataColAutoId.DataType = typeof(int);
            // 
            // dataColRepertoryNo
            // 
            this.dataColRepertoryNo.Caption = "仓库编号";
            this.dataColRepertoryNo.ColumnName = "RepertoryNo";
            // 
            // dataColRepertoryName
            // 
            this.dataColRepertoryName.Caption = "仓库名称";
            this.dataColRepertoryName.ColumnName = "RepertoryName";
            // 
            // dataColRepertoryType
            // 
            this.dataColRepertoryType.Caption = "仓库类型";
            this.dataColRepertoryType.ColumnName = "RepertoryType";
            this.dataColRepertoryType.DataType = typeof(int);
            // 
            // bSRepertoryInfo
            // 
            this.bSRepertoryInfo.DataMember = "RepertoryInfo";
            this.bSRepertoryInfo.DataSource = this.dSRepertoryInfo;
            // 
            // pnlToolBar
            // 
            this.pnlToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolBar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolBar.Name = "pnlToolBar";
            this.pnlToolBar.Size = new System.Drawing.Size(784, 40);
            this.pnlToolBar.TabIndex = 3;
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.labRepertoryType);
            this.pnlEdit.Controls.Add(this.radioRepertoryType);
            this.pnlEdit.Controls.Add(this.labRepertoryName);
            this.pnlEdit.Controls.Add(this.labRepertoryNo);
            this.pnlEdit.Controls.Add(this.textRepertoryName);
            this.pnlEdit.Controls.Add(this.textRepertoryNo);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEdit.Location = new System.Drawing.Point(0, 40);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(784, 68);
            this.pnlEdit.TabIndex = 7;
            // 
            // labRepertoryType
            // 
            this.labRepertoryType.Location = new System.Drawing.Point(467, 24);
            this.labRepertoryType.Name = "labRepertoryType";
            this.labRepertoryType.Size = new System.Drawing.Size(48, 14);
            this.labRepertoryType.TabIndex = 18;
            this.labRepertoryType.Text = "仓库类型";
            // 
            // radioRepertoryType
            // 
            this.radioRepertoryType.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSRepertoryInfo, "RepertoryType", true));
            this.radioRepertoryType.Location = new System.Drawing.Point(533, 20);
            this.radioRepertoryType.Name = "radioRepertoryType";
            this.radioRepertoryType.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioRepertoryType.Properties.Appearance.Options.UseBackColor = true;
            this.radioRepertoryType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioRepertoryType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "正常"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "虚拟")});
            this.radioRepertoryType.Size = new System.Drawing.Size(133, 22);
            this.radioRepertoryType.TabIndex = 2;
            // 
            // labRepertoryName
            // 
            this.labRepertoryName.Location = new System.Drawing.Point(249, 24);
            this.labRepertoryName.Name = "labRepertoryName";
            this.labRepertoryName.Size = new System.Drawing.Size(48, 14);
            this.labRepertoryName.TabIndex = 15;
            this.labRepertoryName.Text = "仓库名称";
            // 
            // labRepertoryNo
            // 
            this.labRepertoryNo.Location = new System.Drawing.Point(36, 24);
            this.labRepertoryNo.Name = "labRepertoryNo";
            this.labRepertoryNo.Size = new System.Drawing.Size(48, 14);
            this.labRepertoryNo.TabIndex = 12;
            this.labRepertoryNo.Text = "仓库编号";
            // 
            // textRepertoryName
            // 
            this.textRepertoryName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSRepertoryInfo, "RepertoryName", true));
            this.textRepertoryName.Location = new System.Drawing.Point(318, 21);
            this.textRepertoryName.Name = "textRepertoryName";
            this.textRepertoryName.Size = new System.Drawing.Size(120, 20);
            this.textRepertoryName.TabIndex = 1;
            // 
            // textRepertoryNo
            // 
            this.textRepertoryNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSRepertoryInfo, "RepertoryNo", true));
            this.textRepertoryNo.EnterMoveNextControl = true;
            this.textRepertoryNo.Location = new System.Drawing.Point(104, 21);
            this.textRepertoryNo.Name = "textRepertoryNo";
            this.textRepertoryNo.Size = new System.Drawing.Size(120, 20);
            this.textRepertoryNo.TabIndex = 0;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.gridCrlRepertoryInfo);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 108);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(784, 253);
            this.pnlGrid.TabIndex = 8;
            // 
            // gridCrlRepertoryInfo
            // 
            this.gridCrlRepertoryInfo.DataSource = this.bSRepertoryInfo;
            this.gridCrlRepertoryInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCrlRepertoryInfo.Location = new System.Drawing.Point(2, 2);
            this.gridCrlRepertoryInfo.MainView = this.gridViewRepertoryInfo;
            this.gridCrlRepertoryInfo.Name = "gridCrlRepertoryInfo";
            this.gridCrlRepertoryInfo.Size = new System.Drawing.Size(780, 249);
            this.gridCrlRepertoryInfo.TabIndex = 0;
            this.gridCrlRepertoryInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRepertoryInfo});
            // 
            // gridViewRepertoryInfo
            // 
            this.gridViewRepertoryInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId,
            this.colRepertoryNo,
            this.colRepertoryName,
            this.colRepertoryType});
            this.gridViewRepertoryInfo.GridControl = this.gridCrlRepertoryInfo;
            this.gridViewRepertoryInfo.IndicatorWidth = 40;
            this.gridViewRepertoryInfo.Name = "gridViewRepertoryInfo";
            this.gridViewRepertoryInfo.OptionsBehavior.Editable = false;
            this.gridViewRepertoryInfo.OptionsFilter.AllowFilterEditor = false;
            this.gridViewRepertoryInfo.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewRepertoryInfo.OptionsView.ColumnAutoWidth = false;
            this.gridViewRepertoryInfo.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewRepertoryInfo.OptionsView.ShowFooter = true;
            this.gridViewRepertoryInfo.OptionsView.ShowGroupPanel = false;
            this.gridViewRepertoryInfo.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewRepertoryInfo_CustomDrawRowIndicator);
            this.gridViewRepertoryInfo.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridViewRepertoryInfo_CustomColumnDisplayText);
            // 
            // colAutoId
            // 
            this.colAutoId.AppearanceHeader.Options.UseTextOptions = true;
            this.colAutoId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAutoId.FieldName = "AutoId";
            this.colAutoId.Name = "colAutoId";
            // 
            // colRepertoryNo
            // 
            this.colRepertoryNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colRepertoryNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRepertoryNo.FieldName = "RepertoryNo";
            this.colRepertoryNo.Name = "colRepertoryNo";
            this.colRepertoryNo.Visible = true;
            this.colRepertoryNo.VisibleIndex = 0;
            this.colRepertoryNo.Width = 120;
            // 
            // colRepertoryName
            // 
            this.colRepertoryName.AppearanceHeader.Options.UseTextOptions = true;
            this.colRepertoryName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRepertoryName.FieldName = "RepertoryName";
            this.colRepertoryName.Name = "colRepertoryName";
            this.colRepertoryName.Visible = true;
            this.colRepertoryName.VisibleIndex = 1;
            this.colRepertoryName.Width = 120;
            // 
            // colRepertoryType
            // 
            this.colRepertoryType.AppearanceHeader.Options.UseTextOptions = true;
            this.colRepertoryType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRepertoryType.FieldName = "RepertoryType";
            this.colRepertoryType.Name = "colRepertoryType";
            this.colRepertoryType.Visible = true;
            this.colRepertoryType.VisibleIndex = 2;
            this.colRepertoryType.Width = 120;
            // 
            // FrmRepertoryInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.pnlToolBar);
            this.Name = "FrmRepertoryInfo";
            this.TabText = "仓库信息";
            this.Text = "仓库信息";
            this.Load += new System.EventHandler(this.FrmRepertoryInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSRepertoryInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableRepertoryInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSRepertoryInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioRepertoryType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRepertoryName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRepertoryNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlRepertoryInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRepertoryInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dSRepertoryInfo;
        private System.Data.DataTable TableRepertoryInfo;
        private System.Data.DataColumn dataColAutoId;
        private System.Data.DataColumn dataColRepertoryNo;
        private System.Data.DataColumn dataColRepertoryName;
        private System.Windows.Forms.BindingSource bSRepertoryInfo;
        private System.Data.DataColumn dataColRepertoryType;
        private DevExpress.XtraEditors.PanelControl pnlToolBar;
        private DevExpress.XtraEditors.PanelControl pnlEdit;
        private DevExpress.XtraEditors.LabelControl labRepertoryName;
        private DevExpress.XtraEditors.LabelControl labRepertoryNo;
        private DevExpress.XtraEditors.TextEdit textRepertoryName;
        private DevExpress.XtraEditors.TextEdit textRepertoryNo;
        private DevExpress.XtraEditors.PanelControl pnlGrid;
        private DevExpress.XtraGrid.GridControl gridCrlRepertoryInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRepertoryInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colRepertoryNo;
        private DevExpress.XtraGrid.Columns.GridColumn colRepertoryName;
        private DevExpress.XtraGrid.Columns.GridColumn colRepertoryType;
        private DevExpress.XtraEditors.LabelControl labRepertoryType;
        private DevExpress.XtraEditors.RadioGroup radioRepertoryType;
    }
}