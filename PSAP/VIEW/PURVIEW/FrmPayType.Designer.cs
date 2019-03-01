namespace PSAP.VIEW.BSVIEW
{
    partial class FrmPayType
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
            this.btnPayTypeList = new DevExpress.XtraEditors.SimpleButton();
            this.pnlEdit = new DevExpress.XtraEditors.PanelControl();
            this.textPayTypeNoText = new DevExpress.XtraEditors.TextEdit();
            this.bSPayType = new System.Windows.Forms.BindingSource(this.components);
            this.dSPayType = new System.Data.DataSet();
            this.TablePayType = new System.Data.DataTable();
            this.dataColAutoId = new System.Data.DataColumn();
            this.dataColPayTypeNo = new System.Data.DataColumn();
            this.dataColPayTypeNoText = new System.Data.DataColumn();
            this.textPayTypeNo = new DevExpress.XtraEditors.TextEdit();
            this.labPayTypeNoText = new DevExpress.XtraEditors.LabelControl();
            this.labPayTypeNo = new DevExpress.XtraEditors.LabelControl();
            this.pnlGrid = new DevExpress.XtraEditors.PanelControl();
            this.gridCrlPayType = new DevExpress.XtraGrid.GridControl();
            this.gridViewPayType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPayTypeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPayTypeNoText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiFkbfbd = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).BeginInit();
            this.pnlToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).BeginInit();
            this.pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textPayTypeNoText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSPayType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPayType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablePayType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPayTypeNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlPayType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPayType)).BeginInit();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlToolBar
            // 
            this.pnlToolBar.Controls.Add(this.btnPayTypeList);
            this.pnlToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolBar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolBar.Name = "pnlToolBar";
            this.pnlToolBar.Size = new System.Drawing.Size(584, 40);
            this.pnlToolBar.TabIndex = 3;
            // 
            // btnPayTypeList
            // 
            this.btnPayTypeList.Location = new System.Drawing.Point(496, 9);
            this.btnPayTypeList.Name = "btnPayTypeList";
            this.btnPayTypeList.Size = new System.Drawing.Size(75, 23);
            this.btnPayTypeList.TabIndex = 1;
            this.btnPayTypeList.TabStop = false;
            this.btnPayTypeList.Text = "付款信息";
            this.btnPayTypeList.Click += new System.EventHandler(this.btnPayTypeList_Click);
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.textPayTypeNoText);
            this.pnlEdit.Controls.Add(this.textPayTypeNo);
            this.pnlEdit.Controls.Add(this.labPayTypeNoText);
            this.pnlEdit.Controls.Add(this.labPayTypeNo);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEdit.Location = new System.Drawing.Point(0, 40);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(584, 68);
            this.pnlEdit.TabIndex = 7;
            // 
            // textPayTypeNoText
            // 
            this.textPayTypeNoText.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSPayType, "PayTypeNoText", true));
            this.textPayTypeNoText.Location = new System.Drawing.Point(346, 21);
            this.textPayTypeNoText.Name = "textPayTypeNoText";
            this.textPayTypeNoText.Size = new System.Drawing.Size(160, 20);
            this.textPayTypeNoText.TabIndex = 1;
            // 
            // bSPayType
            // 
            this.bSPayType.DataMember = "PayType";
            this.bSPayType.DataSource = this.dSPayType;
            // 
            // dSPayType
            // 
            this.dSPayType.DataSetName = "NewDataSet";
            this.dSPayType.Tables.AddRange(new System.Data.DataTable[] {
            this.TablePayType});
            // 
            // TablePayType
            // 
            this.TablePayType.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColAutoId,
            this.dataColPayTypeNo,
            this.dataColPayTypeNoText});
            this.TablePayType.TableName = "PayType";
            // 
            // dataColAutoId
            // 
            this.dataColAutoId.ColumnName = "AutoId";
            this.dataColAutoId.DataType = typeof(int);
            // 
            // dataColPayTypeNo
            // 
            this.dataColPayTypeNo.Caption = "付款类型";
            this.dataColPayTypeNo.ColumnName = "PayTypeNo";
            // 
            // dataColPayTypeNoText
            // 
            this.dataColPayTypeNoText.Caption = "付款说明";
            this.dataColPayTypeNoText.ColumnName = "PayTypeNoText";
            // 
            // textPayTypeNo
            // 
            this.textPayTypeNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSPayType, "PayTypeNo", true));
            this.textPayTypeNo.EnterMoveNextControl = true;
            this.textPayTypeNo.Location = new System.Drawing.Point(101, 21);
            this.textPayTypeNo.Name = "textPayTypeNo";
            this.textPayTypeNo.Size = new System.Drawing.Size(160, 20);
            this.textPayTypeNo.TabIndex = 0;
            // 
            // labPayTypeNoText
            // 
            this.labPayTypeNoText.Location = new System.Drawing.Point(282, 24);
            this.labPayTypeNoText.Name = "labPayTypeNoText";
            this.labPayTypeNoText.Size = new System.Drawing.Size(48, 14);
            this.labPayTypeNoText.TabIndex = 15;
            this.labPayTypeNoText.Text = "付款说明";
            // 
            // labPayTypeNo
            // 
            this.labPayTypeNo.Location = new System.Drawing.Point(36, 24);
            this.labPayTypeNo.Name = "labPayTypeNo";
            this.labPayTypeNo.Size = new System.Drawing.Size(48, 14);
            this.labPayTypeNo.TabIndex = 12;
            this.labPayTypeNo.Text = "付款类型";
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.gridCrlPayType);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 108);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(584, 253);
            this.pnlGrid.TabIndex = 8;
            // 
            // gridCrlPayType
            // 
            this.gridCrlPayType.DataSource = this.bSPayType;
            this.gridCrlPayType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCrlPayType.Location = new System.Drawing.Point(2, 2);
            this.gridCrlPayType.MainView = this.gridViewPayType;
            this.gridCrlPayType.Name = "gridCrlPayType";
            this.gridCrlPayType.Size = new System.Drawing.Size(580, 249);
            this.gridCrlPayType.TabIndex = 0;
            this.gridCrlPayType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPayType});
            // 
            // gridViewPayType
            // 
            this.gridViewPayType.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId,
            this.colPayTypeNo,
            this.colPayTypeNoText});
            this.gridViewPayType.GridControl = this.gridCrlPayType;
            this.gridViewPayType.IndicatorWidth = 40;
            this.gridViewPayType.Name = "gridViewPayType";
            this.gridViewPayType.OptionsBehavior.Editable = false;
            this.gridViewPayType.OptionsFilter.AllowFilterEditor = false;
            this.gridViewPayType.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewPayType.OptionsView.ColumnAutoWidth = false;
            this.gridViewPayType.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewPayType.OptionsView.ShowFooter = true;
            this.gridViewPayType.OptionsView.ShowGroupPanel = false;
            this.gridViewPayType.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewPayType_CustomDrawRowIndicator);
            // 
            // colAutoId
            // 
            this.colAutoId.FieldName = "AutoId";
            this.colAutoId.Name = "colAutoId";
            // 
            // colPayTypeNo
            // 
            this.colPayTypeNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colPayTypeNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPayTypeNo.FieldName = "PayTypeNo";
            this.colPayTypeNo.Name = "colPayTypeNo";
            this.colPayTypeNo.Visible = true;
            this.colPayTypeNo.VisibleIndex = 0;
            this.colPayTypeNo.Width = 160;
            // 
            // colPayTypeNoText
            // 
            this.colPayTypeNoText.AppearanceHeader.Options.UseTextOptions = true;
            this.colPayTypeNoText.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPayTypeNoText.FieldName = "PayTypeNoText";
            this.colPayTypeNoText.Name = "colPayTypeNoText";
            this.colPayTypeNoText.Visible = true;
            this.colPayTypeNoText.VisibleIndex = 1;
            this.colPayTypeNoText.Width = 160;
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFkbfbd});
            this.cms.Name = "cmsCommonHandler";
            this.cms.Size = new System.Drawing.Size(362, 48);
            // 
            // tsmiFkbfbd
            // 
            this.tsmiFkbfbd.Name = "tsmiFkbfbd";
            this.tsmiFkbfbd.Size = new System.Drawing.Size(361, 22);
            this.tsmiFkbfbd.Text = "付款百分比的合计必须是100，请刷新后再重新操作。";
            // 
            // FrmPayType
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.pnlToolBar);
            this.Name = "FrmPayType";
            this.TabText = "付款类型";
            this.Text = "付款类型";
            this.Load += new System.EventHandler(this.FrmPayType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).EndInit();
            this.pnlToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textPayTypeNoText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSPayType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPayType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablePayType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPayTypeNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlPayType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPayType)).EndInit();
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlToolBar;
        private DevExpress.XtraEditors.PanelControl pnlEdit;
        private DevExpress.XtraEditors.LabelControl labPayTypeNoText;
        private DevExpress.XtraEditors.LabelControl labPayTypeNo;
        private DevExpress.XtraEditors.TextEdit textPayTypeNoText;
        private DevExpress.XtraEditors.TextEdit textPayTypeNo;
        private System.Windows.Forms.BindingSource bSPayType;
        private System.Data.DataSet dSPayType;
        private System.Data.DataTable TablePayType;
        private System.Data.DataColumn dataColAutoId;
        private System.Data.DataColumn dataColPayTypeNo;
        private System.Data.DataColumn dataColPayTypeNoText;
        private DevExpress.XtraEditors.PanelControl pnlGrid;
        private DevExpress.XtraGrid.GridControl gridCrlPayType;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPayType;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colPayTypeNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPayTypeNoText;
        private DevExpress.XtraEditors.SimpleButton btnPayTypeList;
        internal System.Windows.Forms.ContextMenuStrip cms;
        internal System.Windows.Forms.ToolStripMenuItem tsmiFkbfbd;
    }
}