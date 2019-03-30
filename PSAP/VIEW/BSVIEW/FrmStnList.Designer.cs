namespace PSAP.VIEW.BSVIEW
{
    partial class FrmStnList
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
            this.pnlToolBar = new DevExpress.XtraEditors.PanelControl();
            this.dSStnList = new System.Data.DataSet();
            this.TableStnList = new System.Data.DataTable();
            this.dataColAutoId = new System.Data.DataColumn();
            this.dataColProjectNo = new System.Data.DataColumn();
            this.dataColProjectName = new System.Data.DataColumn();
            this.dataColStnNo = new System.Data.DataColumn();
            this.dataColRemark = new System.Data.DataColumn();
            this.bSStnList = new System.Windows.Forms.BindingSource(this.components);
            this.pnlEdit = new DevExpress.XtraEditors.PanelControl();
            this.searchLookUpProjectNo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpProjectNoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColProjectNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColProjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textRemark = new DevExpress.XtraEditors.TextEdit();
            this.textStnNo = new DevExpress.XtraEditors.TextEdit();
            this.labRemark = new DevExpress.XtraEditors.LabelControl();
            this.labProjectNo = new DevExpress.XtraEditors.LabelControl();
            this.labStnNo = new DevExpress.XtraEditors.LabelControl();
            this.pnlGrid = new DevExpress.XtraEditors.PanelControl();
            this.gridCrlStnList = new DevExpress.XtraGrid.GridControl();
            this.gridViewStnList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjectNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStnNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiXm = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDzhxx = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiZhbnwk = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiXmhbnwk = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSStnList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableStnList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSStnList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).BeginInit();
            this.pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpProjectNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpProjectNoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textStnNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlStnList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStnList)).BeginInit();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlToolBar
            // 
            this.pnlToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolBar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolBar.Name = "pnlToolBar";
            this.pnlToolBar.Size = new System.Drawing.Size(784, 40);
            this.pnlToolBar.TabIndex = 1;
            // 
            // dSStnList
            // 
            this.dSStnList.DataSetName = "NewDataSet";
            this.dSStnList.Tables.AddRange(new System.Data.DataTable[] {
            this.TableStnList});
            // 
            // TableStnList
            // 
            this.TableStnList.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColAutoId,
            this.dataColProjectNo,
            this.dataColProjectName,
            this.dataColStnNo,
            this.dataColRemark});
            this.TableStnList.TableName = "StnList";
            this.TableStnList.TableNewRow += new System.Data.DataTableNewRowEventHandler(this.TableStnList_TableNewRow);
            // 
            // dataColAutoId
            // 
            this.dataColAutoId.ColumnName = "AutoId";
            this.dataColAutoId.DataType = typeof(int);
            // 
            // dataColProjectNo
            // 
            this.dataColProjectNo.Caption = "项目号";
            this.dataColProjectNo.ColumnName = "ProjectNo";
            // 
            // dataColProjectName
            // 
            this.dataColProjectName.Caption = "项目名称";
            this.dataColProjectName.ColumnName = "ProjectName";
            // 
            // dataColStnNo
            // 
            this.dataColStnNo.Caption = "站号";
            this.dataColStnNo.ColumnName = "StnNo";
            // 
            // dataColRemark
            // 
            this.dataColRemark.Caption = "备注";
            this.dataColRemark.ColumnName = "Remark";
            // 
            // bSStnList
            // 
            this.bSStnList.DataMember = "StnList";
            this.bSStnList.DataSource = this.dSStnList;
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.searchLookUpProjectNo);
            this.pnlEdit.Controls.Add(this.textRemark);
            this.pnlEdit.Controls.Add(this.textStnNo);
            this.pnlEdit.Controls.Add(this.labRemark);
            this.pnlEdit.Controls.Add(this.labProjectNo);
            this.pnlEdit.Controls.Add(this.labStnNo);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEdit.Location = new System.Drawing.Point(0, 40);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(784, 97);
            this.pnlEdit.TabIndex = 5;
            // 
            // searchLookUpProjectNo
            // 
            this.searchLookUpProjectNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSStnList, "ProjectNo", true));
            this.searchLookUpProjectNo.EnterMoveNextControl = true;
            this.searchLookUpProjectNo.Location = new System.Drawing.Point(339, 21);
            this.searchLookUpProjectNo.Name = "searchLookUpProjectNo";
            this.searchLookUpProjectNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpProjectNo.Properties.DisplayMember = "ProjectName";
            this.searchLookUpProjectNo.Properties.NullText = "";
            this.searchLookUpProjectNo.Properties.ValueMember = "ProjectNo";
            this.searchLookUpProjectNo.Properties.View = this.searchLookUpProjectNoView;
            this.searchLookUpProjectNo.Size = new System.Drawing.Size(160, 20);
            this.searchLookUpProjectNo.TabIndex = 1;
            // 
            // searchLookUpProjectNoView
            // 
            this.searchLookUpProjectNoView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColProjectNo,
            this.gridColProjectName,
            this.gridColRemark});
            this.searchLookUpProjectNoView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpProjectNoView.IndicatorWidth = 60;
            this.searchLookUpProjectNoView.Name = "searchLookUpProjectNoView";
            this.searchLookUpProjectNoView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpProjectNoView.OptionsView.ShowGroupPanel = false;
            this.searchLookUpProjectNoView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewStnList_CustomDrawRowIndicator);
            // 
            // gridColProjectNo
            // 
            this.gridColProjectNo.Caption = "项目号";
            this.gridColProjectNo.FieldName = "ProjectNo";
            this.gridColProjectNo.Name = "gridColProjectNo";
            this.gridColProjectNo.Visible = true;
            this.gridColProjectNo.VisibleIndex = 0;
            // 
            // gridColProjectName
            // 
            this.gridColProjectName.Caption = "项目名称";
            this.gridColProjectName.FieldName = "ProjectName";
            this.gridColProjectName.Name = "gridColProjectName";
            this.gridColProjectName.Visible = true;
            this.gridColProjectName.VisibleIndex = 1;
            // 
            // gridColRemark
            // 
            this.gridColRemark.Caption = "备注";
            this.gridColRemark.FieldName = "Remark";
            this.gridColRemark.Name = "gridColRemark";
            this.gridColRemark.Visible = true;
            this.gridColRemark.VisibleIndex = 2;
            // 
            // textRemark
            // 
            this.textRemark.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSStnList, "Remark", true));
            this.textRemark.Location = new System.Drawing.Point(94, 55);
            this.textRemark.Name = "textRemark";
            this.textRemark.Size = new System.Drawing.Size(405, 20);
            this.textRemark.TabIndex = 2;
            // 
            // textStnNo
            // 
            this.textStnNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSStnList, "StnNo", true));
            this.textStnNo.EnterMoveNextControl = true;
            this.textStnNo.Location = new System.Drawing.Point(94, 21);
            this.textStnNo.Name = "textStnNo";
            this.textStnNo.Size = new System.Drawing.Size(160, 20);
            this.textStnNo.TabIndex = 0;
            // 
            // labRemark
            // 
            this.labRemark.Location = new System.Drawing.Point(36, 58);
            this.labRemark.Name = "labRemark";
            this.labRemark.Size = new System.Drawing.Size(24, 14);
            this.labRemark.TabIndex = 15;
            this.labRemark.Text = "备注";
            // 
            // labProjectNo
            // 
            this.labProjectNo.Location = new System.Drawing.Point(277, 24);
            this.labProjectNo.Name = "labProjectNo";
            this.labProjectNo.Size = new System.Drawing.Size(36, 14);
            this.labProjectNo.TabIndex = 13;
            this.labProjectNo.Text = "项目号";
            // 
            // labStnNo
            // 
            this.labStnNo.Location = new System.Drawing.Point(36, 24);
            this.labStnNo.Name = "labStnNo";
            this.labStnNo.Size = new System.Drawing.Size(24, 14);
            this.labStnNo.TabIndex = 12;
            this.labStnNo.Text = "站号";
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.gridCrlStnList);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 137);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(784, 425);
            this.pnlGrid.TabIndex = 6;
            // 
            // gridCrlStnList
            // 
            this.gridCrlStnList.DataSource = this.bSStnList;
            this.gridCrlStnList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCrlStnList.Location = new System.Drawing.Point(2, 2);
            this.gridCrlStnList.MainView = this.gridViewStnList;
            this.gridCrlStnList.Name = "gridCrlStnList";
            this.gridCrlStnList.Size = new System.Drawing.Size(780, 421);
            this.gridCrlStnList.TabIndex = 0;
            this.gridCrlStnList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewStnList});
            // 
            // gridViewStnList
            // 
            this.gridViewStnList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId,
            this.colProjectNo,
            this.colProjectName,
            this.colStnNo,
            this.colRemark});
            this.gridViewStnList.GridControl = this.gridCrlStnList;
            this.gridViewStnList.IndicatorWidth = 40;
            this.gridViewStnList.Name = "gridViewStnList";
            this.gridViewStnList.OptionsBehavior.Editable = false;
            this.gridViewStnList.OptionsFilter.AllowFilterEditor = false;
            this.gridViewStnList.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewStnList.OptionsView.ColumnAutoWidth = false;
            this.gridViewStnList.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewStnList.OptionsView.ShowFooter = true;
            this.gridViewStnList.OptionsView.ShowGroupPanel = false;
            this.gridViewStnList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewStnList_CustomDrawRowIndicator);
            this.gridViewStnList.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridViewStnList_InitNewRow);
            // 
            // colAutoId
            // 
            this.colAutoId.FieldName = "AutoId";
            this.colAutoId.Name = "colAutoId";
            // 
            // colProjectNo
            // 
            this.colProjectNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colProjectNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProjectNo.FieldName = "ProjectNo";
            this.colProjectNo.Name = "colProjectNo";
            this.colProjectNo.Visible = true;
            this.colProjectNo.VisibleIndex = 1;
            this.colProjectNo.Width = 160;
            // 
            // colProjectName
            // 
            this.colProjectName.AppearanceHeader.Options.UseTextOptions = true;
            this.colProjectName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProjectName.FieldName = "ProjectName";
            this.colProjectName.Name = "colProjectName";
            this.colProjectName.Visible = true;
            this.colProjectName.VisibleIndex = 2;
            this.colProjectName.Width = 160;
            // 
            // colStnNo
            // 
            this.colStnNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colStnNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStnNo.FieldName = "StnNo";
            this.colStnNo.Name = "colStnNo";
            this.colStnNo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "StnNo", "共计{0}条")});
            this.colStnNo.Visible = true;
            this.colStnNo.VisibleIndex = 0;
            this.colStnNo.Width = 160;
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
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiXm,
            this.tsmiDzhxx,
            this.tsmiZhbnwk,
            this.tsmiXmhbnwk});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(245, 92);
            // 
            // tsmiXm
            // 
            this.tsmiXm.Name = "tsmiXm";
            this.tsmiXm.Size = new System.Drawing.Size(244, 22);
            this.tsmiXm.Text = "项目";
            // 
            // tsmiDzhxx
            // 
            this.tsmiDzhxx.Name = "tsmiDzhxx";
            this.tsmiDzhxx.Size = new System.Drawing.Size(244, 22);
            this.tsmiDzhxx.Text = "的站号信息";
            // 
            // tsmiZhbnwk
            // 
            this.tsmiZhbnwk.Name = "tsmiZhbnwk";
            this.tsmiZhbnwk.Size = new System.Drawing.Size(244, 22);
            this.tsmiZhbnwk.Text = "站号不能为空，请重新操作。";
            // 
            // tsmiXmhbnwk
            // 
            this.tsmiXmhbnwk.Name = "tsmiXmhbnwk";
            this.tsmiXmhbnwk.Size = new System.Drawing.Size(244, 22);
            this.tsmiXmhbnwk.Text = "项目号不能为空，请重新操作。";
            // 
            // FrmStnList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.pnlToolBar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FrmStnList";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabText = "站号";
            this.Text = "站号";
            this.Activated += new System.EventHandler(this.FrmStnList_Activated);
            this.Load += new System.EventHandler(this.FrmStnList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSStnList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableStnList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSStnList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpProjectNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpProjectNoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textStnNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlStnList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStnList)).EndInit();
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlToolBar;
        private System.Data.DataSet dSStnList;
        private System.Data.DataTable TableStnList;
        private System.Data.DataColumn dataColAutoId;
        private System.Data.DataColumn dataColProjectNo;
        private System.Data.DataColumn dataColProjectName;
        private System.Windows.Forms.BindingSource bSStnList;
        private System.Data.DataColumn dataColStnNo;
        private System.Data.DataColumn dataColRemark;
        private DevExpress.XtraEditors.PanelControl pnlEdit;
        private DevExpress.XtraEditors.LabelControl labRemark;
        private DevExpress.XtraEditors.LabelControl labProjectNo;
        private DevExpress.XtraEditors.LabelControl labStnNo;
        private DevExpress.XtraEditors.TextEdit textRemark;
        private DevExpress.XtraEditors.TextEdit textStnNo;
        private DevExpress.XtraEditors.PanelControl pnlGrid;
        private DevExpress.XtraGrid.GridControl gridCrlStnList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewStnList;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectNo;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectName;
        private DevExpress.XtraGrid.Columns.GridColumn colStnNo;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpProjectNo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpProjectNoView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColProjectNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColProjectName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColRemark;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem tsmiXm;
        private System.Windows.Forms.ToolStripMenuItem tsmiDzhxx;
        private System.Windows.Forms.ToolStripMenuItem tsmiZhbnwk;
        private System.Windows.Forms.ToolStripMenuItem tsmiXmhbnwk;
    }
}