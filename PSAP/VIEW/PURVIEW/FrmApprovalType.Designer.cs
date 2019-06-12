namespace PSAP.VIEW.BSVIEW
{
    partial class FrmApprovalType
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
            this.btnApprovalList = new DevExpress.XtraEditors.SimpleButton();
            this.dSApprovalType = new System.Data.DataSet();
            this.TableApprovalType = new System.Data.DataTable();
            this.dataColAutoId = new System.Data.DataColumn();
            this.dataColTypeNo = new System.Data.DataColumn();
            this.dataColTypeNoText = new System.Data.DataColumn();
            this.dataColApprovalCat = new System.Data.DataColumn();
            this.bSApprovalType = new System.Windows.Forms.BindingSource(this.components);
            this.pnlEdit = new DevExpress.XtraEditors.PanelControl();
            this.labApprovalCatDesc = new DevExpress.XtraEditors.LabelControl();
            this.radioApprovalCat = new DevExpress.XtraEditors.RadioGroup();
            this.textTypeNoText = new DevExpress.XtraEditors.TextEdit();
            this.textTypeNo = new DevExpress.XtraEditors.TextEdit();
            this.labApprovalCat = new DevExpress.XtraEditors.LabelControl();
            this.labTypeNoText = new DevExpress.XtraEditors.LabelControl();
            this.labTypeNo = new DevExpress.XtraEditors.LabelControl();
            this.gridCrlApprovalType = new DevExpress.XtraGrid.GridControl();
            this.gridViewApprovalType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypeNoText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApprovalCat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlGrid = new DevExpress.XtraEditors.PanelControl();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSplxbxxz = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSplxmcbnwk = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSplxbmbnwk = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).BeginInit();
            this.pnlToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSApprovalType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableApprovalType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSApprovalType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).BeginInit();
            this.pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioApprovalCat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTypeNoText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTypeNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlApprovalType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewApprovalType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlToolBar
            // 
            this.pnlToolBar.Controls.Add(this.btnApprovalList);
            this.pnlToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolBar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolBar.Name = "pnlToolBar";
            this.pnlToolBar.Size = new System.Drawing.Size(811, 40);
            this.pnlToolBar.TabIndex = 3;
            // 
            // btnApprovalList
            // 
            this.btnApprovalList.Location = new System.Drawing.Point(496, 9);
            this.btnApprovalList.Name = "btnApprovalList";
            this.btnApprovalList.Size = new System.Drawing.Size(75, 23);
            this.btnApprovalList.TabIndex = 0;
            this.btnApprovalList.TabStop = false;
            this.btnApprovalList.Text = "审批信息";
            this.btnApprovalList.Click += new System.EventHandler(this.btnApprovalList_Click);
            // 
            // dSApprovalType
            // 
            this.dSApprovalType.DataSetName = "NewDataSet";
            this.dSApprovalType.Tables.AddRange(new System.Data.DataTable[] {
            this.TableApprovalType});
            // 
            // TableApprovalType
            // 
            this.TableApprovalType.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColAutoId,
            this.dataColTypeNo,
            this.dataColTypeNoText,
            this.dataColApprovalCat});
            this.TableApprovalType.TableName = "ApprovalType";
            this.TableApprovalType.TableNewRow += new System.Data.DataTableNewRowEventHandler(this.TableApprovalType_TableNewRow);
            // 
            // dataColAutoId
            // 
            this.dataColAutoId.ColumnName = "AutoId";
            this.dataColAutoId.DataType = typeof(int);
            // 
            // dataColTypeNo
            // 
            this.dataColTypeNo.Caption = "类型编码";
            this.dataColTypeNo.ColumnName = "TypeNo";
            // 
            // dataColTypeNoText
            // 
            this.dataColTypeNoText.Caption = "审批名称";
            this.dataColTypeNoText.ColumnName = "TypeNoText";
            // 
            // dataColApprovalCat
            // 
            this.dataColApprovalCat.Caption = "审批类型";
            this.dataColApprovalCat.ColumnName = "ApprovalCat";
            this.dataColApprovalCat.DataType = typeof(int);
            // 
            // bSApprovalType
            // 
            this.bSApprovalType.DataMember = "ApprovalType";
            this.bSApprovalType.DataSource = this.dSApprovalType;
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.labApprovalCatDesc);
            this.pnlEdit.Controls.Add(this.radioApprovalCat);
            this.pnlEdit.Controls.Add(this.textTypeNoText);
            this.pnlEdit.Controls.Add(this.textTypeNo);
            this.pnlEdit.Controls.Add(this.labApprovalCat);
            this.pnlEdit.Controls.Add(this.labTypeNoText);
            this.pnlEdit.Controls.Add(this.labTypeNo);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEdit.Location = new System.Drawing.Point(0, 40);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(811, 121);
            this.pnlEdit.TabIndex = 7;
            // 
            // labApprovalCatDesc
            // 
            this.labApprovalCatDesc.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labApprovalCatDesc.Location = new System.Drawing.Point(36, 60);
            this.labApprovalCatDesc.Name = "labApprovalCatDesc";
            this.labApprovalCatDesc.Size = new System.Drawing.Size(576, 42);
            this.labApprovalCatDesc.TabIndex = 17;
            this.labApprovalCatDesc.Tag = "      多选一审批是指在审批信息中的任意审批人通过，则订单修改审批状态。";
            this.labApprovalCatDesc.Text = "注：串行审批是指必须按照审批信息中的顺序，审批人进行逐一审批，全部审批人通过后订单修改审批状态；\r\n      并行审批是指无须按照审批信息中的顺序，审批人直接进" +
    "行审批，全部审批人通过后订单修改审批状态；\r\n\r\n";
            // 
            // radioApprovalCat
            // 
            this.radioApprovalCat.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSApprovalType, "ApprovalCat", true));
            this.radioApprovalCat.Location = new System.Drawing.Point(592, 20);
            this.radioApprovalCat.Name = "radioApprovalCat";
            this.radioApprovalCat.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioApprovalCat.Properties.Appearance.Options.UseBackColor = true;
            this.radioApprovalCat.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioApprovalCat.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "串行审批"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "并行审批")});
            this.radioApprovalCat.Size = new System.Drawing.Size(198, 22);
            this.radioApprovalCat.TabIndex = 2;
            // 
            // textTypeNoText
            // 
            this.textTypeNoText.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSApprovalType, "TypeNoText", true));
            this.textTypeNoText.EnterMoveNextControl = true;
            this.textTypeNoText.Location = new System.Drawing.Point(344, 21);
            this.textTypeNoText.Name = "textTypeNoText";
            this.textTypeNoText.Size = new System.Drawing.Size(160, 20);
            this.textTypeNoText.TabIndex = 1;
            // 
            // textTypeNo
            // 
            this.textTypeNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSApprovalType, "TypeNo", true));
            this.textTypeNo.EnterMoveNextControl = true;
            this.textTypeNo.Location = new System.Drawing.Point(101, 21);
            this.textTypeNo.Name = "textTypeNo";
            this.textTypeNo.Size = new System.Drawing.Size(160, 20);
            this.textTypeNo.TabIndex = 0;
            // 
            // labApprovalCat
            // 
            this.labApprovalCat.Location = new System.Drawing.Point(526, 24);
            this.labApprovalCat.Name = "labApprovalCat";
            this.labApprovalCat.Size = new System.Drawing.Size(48, 14);
            this.labApprovalCat.TabIndex = 16;
            this.labApprovalCat.Text = "审批方式";
            // 
            // labTypeNoText
            // 
            this.labTypeNoText.Location = new System.Drawing.Point(280, 24);
            this.labTypeNoText.Name = "labTypeNoText";
            this.labTypeNoText.Size = new System.Drawing.Size(48, 14);
            this.labTypeNoText.TabIndex = 15;
            this.labTypeNoText.Text = "审批名称";
            // 
            // labTypeNo
            // 
            this.labTypeNo.Location = new System.Drawing.Point(36, 24);
            this.labTypeNo.Name = "labTypeNo";
            this.labTypeNo.Size = new System.Drawing.Size(48, 14);
            this.labTypeNo.TabIndex = 12;
            this.labTypeNo.Text = "类型编码";
            // 
            // gridCrlApprovalType
            // 
            this.gridCrlApprovalType.DataSource = this.bSApprovalType;
            this.gridCrlApprovalType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCrlApprovalType.Location = new System.Drawing.Point(2, 2);
            this.gridCrlApprovalType.MainView = this.gridViewApprovalType;
            this.gridCrlApprovalType.Name = "gridCrlApprovalType";
            this.gridCrlApprovalType.Size = new System.Drawing.Size(807, 196);
            this.gridCrlApprovalType.TabIndex = 8;
            this.gridCrlApprovalType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewApprovalType});
            // 
            // gridViewApprovalType
            // 
            this.gridViewApprovalType.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId,
            this.colTypeNo,
            this.colTypeNoText,
            this.colApprovalCat});
            this.gridViewApprovalType.GridControl = this.gridCrlApprovalType;
            this.gridViewApprovalType.IndicatorWidth = 40;
            this.gridViewApprovalType.Name = "gridViewApprovalType";
            this.gridViewApprovalType.OptionsBehavior.Editable = false;
            this.gridViewApprovalType.OptionsFilter.AllowFilterEditor = false;
            this.gridViewApprovalType.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewApprovalType.OptionsView.ColumnAutoWidth = false;
            this.gridViewApprovalType.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewApprovalType.OptionsView.ShowFooter = true;
            this.gridViewApprovalType.OptionsView.ShowGroupPanel = false;
            this.gridViewApprovalType.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridViewApprovalType_CustomColumnDisplayText);
            // 
            // colAutoId
            // 
            this.colAutoId.FieldName = "AutoId";
            this.colAutoId.Name = "colAutoId";
            // 
            // colTypeNo
            // 
            this.colTypeNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colTypeNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTypeNo.FieldName = "TypeNo";
            this.colTypeNo.Name = "colTypeNo";
            this.colTypeNo.Visible = true;
            this.colTypeNo.VisibleIndex = 0;
            this.colTypeNo.Width = 160;
            // 
            // colTypeNoText
            // 
            this.colTypeNoText.AppearanceHeader.Options.UseTextOptions = true;
            this.colTypeNoText.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTypeNoText.FieldName = "TypeNoText";
            this.colTypeNoText.Name = "colTypeNoText";
            this.colTypeNoText.Visible = true;
            this.colTypeNoText.VisibleIndex = 1;
            this.colTypeNoText.Width = 160;
            // 
            // colApprovalCat
            // 
            this.colApprovalCat.AppearanceHeader.Options.UseTextOptions = true;
            this.colApprovalCat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colApprovalCat.FieldName = "ApprovalCat";
            this.colApprovalCat.Name = "colApprovalCat";
            this.colApprovalCat.Visible = true;
            this.colApprovalCat.VisibleIndex = 2;
            this.colApprovalCat.Width = 120;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.gridCrlApprovalType);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 161);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(811, 200);
            this.pnlGrid.TabIndex = 9;
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSplxbmbnwk,
            this.tsmiSplxmcbnwk,
            this.tsmiSplxbxxz});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(281, 92);
            // 
            // tsmiSplxbxxz
            // 
            this.tsmiSplxbxxz.Name = "tsmiSplxbxxz";
            this.tsmiSplxbxxz.Size = new System.Drawing.Size(280, 22);
            this.tsmiSplxbxxz.Text = "审批类型必须选择，请重新操作。";
            // 
            // tsmiSplxmcbnwk
            // 
            this.tsmiSplxmcbnwk.Name = "tsmiSplxmcbnwk";
            this.tsmiSplxmcbnwk.Size = new System.Drawing.Size(280, 22);
            this.tsmiSplxmcbnwk.Text = "审批类型名称不能为空，请重新操作。";
            // 
            // tsmiSplxbmbnwk
            // 
            this.tsmiSplxbmbnwk.Name = "tsmiSplxbmbnwk";
            this.tsmiSplxbmbnwk.Size = new System.Drawing.Size(280, 22);
            this.tsmiSplxbmbnwk.Text = "审批类型编码不能为空，请重新操作。";
            // 
            // FrmApprovalType
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(811, 361);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.pnlToolBar);
            this.Name = "FrmApprovalType";
            this.TabText = "审批设置";
            this.Text = "审批设置";
            this.Load += new System.EventHandler(this.FrmApprovalType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).EndInit();
            this.pnlToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dSApprovalType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableApprovalType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSApprovalType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioApprovalCat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTypeNoText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTypeNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlApprovalType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewApprovalType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlToolBar;
        private System.Data.DataSet dSApprovalType;
        private System.Data.DataTable TableApprovalType;
        private System.Data.DataColumn dataColAutoId;
        private System.Data.DataColumn dataColTypeNo;
        private System.Data.DataColumn dataColTypeNoText;
        private System.Data.DataColumn dataColApprovalCat;
        private System.Windows.Forms.BindingSource bSApprovalType;
        private DevExpress.XtraEditors.PanelControl pnlEdit;
        private DevExpress.XtraEditors.LabelControl labTypeNoText;
        private DevExpress.XtraEditors.LabelControl labTypeNo;
        private DevExpress.XtraEditors.TextEdit textTypeNoText;
        private DevExpress.XtraEditors.TextEdit textTypeNo;
        private DevExpress.XtraEditors.RadioGroup radioApprovalCat;
        private DevExpress.XtraGrid.GridControl gridCrlApprovalType;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewApprovalType;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeNoText;
        private DevExpress.XtraGrid.Columns.GridColumn colApprovalCat;
        private DevExpress.XtraEditors.LabelControl labApprovalCat;
        private DevExpress.XtraEditors.SimpleButton btnApprovalList;
        private DevExpress.XtraEditors.PanelControl pnlGrid;
        private DevExpress.XtraEditors.LabelControl labApprovalCatDesc;
        internal System.Windows.Forms.ContextMenuStrip cms;
        internal System.Windows.Forms.ToolStripMenuItem tsmiSplxbmbnwk;
        internal System.Windows.Forms.ToolStripMenuItem tsmiSplxmcbnwk;
        internal System.Windows.Forms.ToolStripMenuItem tsmiSplxbxxz;
    }
}