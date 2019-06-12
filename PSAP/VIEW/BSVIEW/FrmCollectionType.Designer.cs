namespace PSAP.VIEW.BSVIEW
{
    partial class FrmCollectionType
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
            this.bSCollectionType = new System.Windows.Forms.BindingSource(this.components);
            this.dSCollectionType = new System.Data.DataSet();
            this.TableCollectionType = new System.Data.DataTable();
            this.dataColAutoId = new System.Data.DataColumn();
            this.dataColCollectionTypeNo = new System.Data.DataColumn();
            this.dataColCollectionTypeNoText = new System.Data.DataColumn();
            this.pnlToolBar = new DevExpress.XtraEditors.PanelControl();
            this.btnCollectionTypeList = new DevExpress.XtraEditors.SimpleButton();
            this.pnlEdit = new DevExpress.XtraEditors.PanelControl();
            this.textCollectionTypeNoText = new DevExpress.XtraEditors.TextEdit();
            this.textCollectionTypeNo = new DevExpress.XtraEditors.TextEdit();
            this.labCollectionTypeNoText = new DevExpress.XtraEditors.LabelControl();
            this.labCollectionTypeNo = new DevExpress.XtraEditors.LabelControl();
            this.pnlGrid = new DevExpress.XtraEditors.PanelControl();
            this.gridCrlCollectionType = new DevExpress.XtraGrid.GridControl();
            this.gridViewCollectionType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCollectionTypeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCollectionTypeNoText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSklx = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSksm = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.bSCollectionType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCollectionType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableCollectionType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).BeginInit();
            this.pnlToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).BeginInit();
            this.pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textCollectionTypeNoText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCollectionTypeNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlCollectionType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCollectionType)).BeginInit();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // bSCollectionType
            // 
            this.bSCollectionType.DataMember = "CollectionType";
            this.bSCollectionType.DataSource = this.dSCollectionType;
            // 
            // dSCollectionType
            // 
            this.dSCollectionType.DataSetName = "NewDataSet";
            this.dSCollectionType.Tables.AddRange(new System.Data.DataTable[] {
            this.TableCollectionType});
            // 
            // TableCollectionType
            // 
            this.TableCollectionType.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColAutoId,
            this.dataColCollectionTypeNo,
            this.dataColCollectionTypeNoText});
            this.TableCollectionType.TableName = "CollectionType";
            // 
            // dataColAutoId
            // 
            this.dataColAutoId.ColumnName = "AutoId";
            this.dataColAutoId.DataType = typeof(int);
            // 
            // dataColCollectionTypeNo
            // 
            this.dataColCollectionTypeNo.Caption = "收款类型";
            this.dataColCollectionTypeNo.ColumnName = "CollectionTypeNo";
            // 
            // dataColCollectionTypeNoText
            // 
            this.dataColCollectionTypeNoText.Caption = "收款说明";
            this.dataColCollectionTypeNoText.ColumnName = "CollectionTypeNoText";
            // 
            // pnlToolBar
            // 
            this.pnlToolBar.Controls.Add(this.btnCollectionTypeList);
            this.pnlToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolBar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolBar.Name = "pnlToolBar";
            this.pnlToolBar.Size = new System.Drawing.Size(584, 40);
            this.pnlToolBar.TabIndex = 4;
            // 
            // btnCollectionTypeList
            // 
            this.btnCollectionTypeList.Location = new System.Drawing.Point(496, 9);
            this.btnCollectionTypeList.Name = "btnCollectionTypeList";
            this.btnCollectionTypeList.Size = new System.Drawing.Size(75, 23);
            this.btnCollectionTypeList.TabIndex = 1;
            this.btnCollectionTypeList.TabStop = false;
            this.btnCollectionTypeList.Text = "收款信息";
            this.btnCollectionTypeList.Click += new System.EventHandler(this.btnCollectionTypeList_Click);
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.textCollectionTypeNoText);
            this.pnlEdit.Controls.Add(this.textCollectionTypeNo);
            this.pnlEdit.Controls.Add(this.labCollectionTypeNoText);
            this.pnlEdit.Controls.Add(this.labCollectionTypeNo);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEdit.Location = new System.Drawing.Point(0, 40);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(584, 68);
            this.pnlEdit.TabIndex = 8;
            // 
            // textCollectionTypeNoText
            // 
            this.textCollectionTypeNoText.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSCollectionType, "CollectionTypeNoText", true));
            this.textCollectionTypeNoText.Location = new System.Drawing.Point(346, 21);
            this.textCollectionTypeNoText.Name = "textCollectionTypeNoText";
            this.textCollectionTypeNoText.Size = new System.Drawing.Size(160, 20);
            this.textCollectionTypeNoText.TabIndex = 1;
            // 
            // textCollectionTypeNo
            // 
            this.textCollectionTypeNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSCollectionType, "CollectionTypeNo", true));
            this.textCollectionTypeNo.EnterMoveNextControl = true;
            this.textCollectionTypeNo.Location = new System.Drawing.Point(101, 21);
            this.textCollectionTypeNo.Name = "textCollectionTypeNo";
            this.textCollectionTypeNo.Size = new System.Drawing.Size(160, 20);
            this.textCollectionTypeNo.TabIndex = 0;
            // 
            // labCollectionTypeNoText
            // 
            this.labCollectionTypeNoText.Location = new System.Drawing.Point(282, 24);
            this.labCollectionTypeNoText.Name = "labCollectionTypeNoText";
            this.labCollectionTypeNoText.Size = new System.Drawing.Size(48, 14);
            this.labCollectionTypeNoText.TabIndex = 15;
            this.labCollectionTypeNoText.Text = "收款说明";
            // 
            // labCollectionTypeNo
            // 
            this.labCollectionTypeNo.Location = new System.Drawing.Point(36, 24);
            this.labCollectionTypeNo.Name = "labCollectionTypeNo";
            this.labCollectionTypeNo.Size = new System.Drawing.Size(48, 14);
            this.labCollectionTypeNo.TabIndex = 12;
            this.labCollectionTypeNo.Text = "收款类型";
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.gridCrlCollectionType);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 108);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(584, 253);
            this.pnlGrid.TabIndex = 9;
            // 
            // gridCrlCollectionType
            // 
            this.gridCrlCollectionType.DataSource = this.bSCollectionType;
            this.gridCrlCollectionType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCrlCollectionType.Location = new System.Drawing.Point(2, 2);
            this.gridCrlCollectionType.MainView = this.gridViewCollectionType;
            this.gridCrlCollectionType.Name = "gridCrlCollectionType";
            this.gridCrlCollectionType.Size = new System.Drawing.Size(580, 249);
            this.gridCrlCollectionType.TabIndex = 0;
            this.gridCrlCollectionType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCollectionType});
            // 
            // gridViewCollectionType
            // 
            this.gridViewCollectionType.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId,
            this.colCollectionTypeNo,
            this.colCollectionTypeNoText});
            this.gridViewCollectionType.GridControl = this.gridCrlCollectionType;
            this.gridViewCollectionType.IndicatorWidth = 40;
            this.gridViewCollectionType.Name = "gridViewCollectionType";
            this.gridViewCollectionType.OptionsBehavior.Editable = false;
            this.gridViewCollectionType.OptionsFilter.AllowFilterEditor = false;
            this.gridViewCollectionType.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewCollectionType.OptionsView.ColumnAutoWidth = false;
            this.gridViewCollectionType.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewCollectionType.OptionsView.ShowFooter = true;
            this.gridViewCollectionType.OptionsView.ShowGroupPanel = false;
            // 
            // colAutoId
            // 
            this.colAutoId.FieldName = "AutoId";
            this.colAutoId.Name = "colAutoId";
            // 
            // colCollectionTypeNo
            // 
            this.colCollectionTypeNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colCollectionTypeNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCollectionTypeNo.FieldName = "CollectionTypeNo";
            this.colCollectionTypeNo.Name = "colCollectionTypeNo";
            this.colCollectionTypeNo.Visible = true;
            this.colCollectionTypeNo.VisibleIndex = 0;
            this.colCollectionTypeNo.Width = 160;
            // 
            // colCollectionTypeNoText
            // 
            this.colCollectionTypeNoText.AppearanceHeader.Options.UseTextOptions = true;
            this.colCollectionTypeNoText.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCollectionTypeNoText.FieldName = "CollectionTypeNoText";
            this.colCollectionTypeNoText.Name = "colCollectionTypeNoText";
            this.colCollectionTypeNoText.Visible = true;
            this.colCollectionTypeNoText.VisibleIndex = 1;
            this.colCollectionTypeNoText.Width = 160;
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSklx,
            this.tsmiSksm});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(257, 70);
            // 
            // tsmiSklx
            // 
            this.tsmiSklx.Name = "tsmiSklx";
            this.tsmiSklx.Size = new System.Drawing.Size(256, 22);
            this.tsmiSklx.Text = "收款类型不能为空，请重新操作。";
            // 
            // tsmiSksm
            // 
            this.tsmiSksm.Name = "tsmiSksm";
            this.tsmiSksm.Size = new System.Drawing.Size(256, 22);
            this.tsmiSksm.Text = "收款说明不能为空，请重新操作。";
            // 
            // FrmCollectionType
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.pnlToolBar);
            this.Name = "FrmCollectionType";
            this.TabText = "收款类型";
            this.Text = "收款类型";
            this.Load += new System.EventHandler(this.FrmCollectionType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bSCollectionType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCollectionType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableCollectionType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).EndInit();
            this.pnlToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textCollectionTypeNoText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCollectionTypeNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlCollectionType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCollectionType)).EndInit();
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bSCollectionType;
        private System.Data.DataSet dSCollectionType;
        private System.Data.DataTable TableCollectionType;
        private System.Data.DataColumn dataColAutoId;
        private System.Data.DataColumn dataColCollectionTypeNo;
        private System.Data.DataColumn dataColCollectionTypeNoText;
        private DevExpress.XtraEditors.PanelControl pnlToolBar;
        private DevExpress.XtraEditors.SimpleButton btnCollectionTypeList;
        private DevExpress.XtraEditors.PanelControl pnlEdit;
        private DevExpress.XtraEditors.TextEdit textCollectionTypeNoText;
        private DevExpress.XtraEditors.TextEdit textCollectionTypeNo;
        private DevExpress.XtraEditors.LabelControl labCollectionTypeNoText;
        private DevExpress.XtraEditors.LabelControl labCollectionTypeNo;
        private DevExpress.XtraEditors.PanelControl pnlGrid;
        private DevExpress.XtraGrid.GridControl gridCrlCollectionType;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCollectionType;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colCollectionTypeNo;
        private DevExpress.XtraGrid.Columns.GridColumn colCollectionTypeNoText;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem tsmiSklx;
        private System.Windows.Forms.ToolStripMenuItem tsmiSksm;
    }
}