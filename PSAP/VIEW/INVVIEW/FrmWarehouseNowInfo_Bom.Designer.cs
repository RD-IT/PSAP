namespace PSAP.VIEW.BSVIEW
{
    partial class FrmWarehouseNowInfo_Bom
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
            this.pnlTop = new DevExpress.XtraEditors.PanelControl();
            this.lookUpRepertoryNo = new DevExpress.XtraEditors.LookUpEdit();
            this.labRepertoryNo = new DevExpress.XtraEditors.LabelControl();
            this.textCodeName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSaveExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.labPartsCodeId = new DevExpress.XtraEditors.LabelControl();
            this.searchCodeFileName = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchPartsCodeIdView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabBom = new DevExpress.XtraTab.XtraTabControl();
            this.PageBomInfo = new DevExpress.XtraTab.XtraTabPage();
            this.treeListBom = new DevExpress.XtraTreeList.TreeList();
            this.CCodeFileName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.CCodeName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.CQty = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.CParentCodeFileName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.CPCAutoId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.CReID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.CReParent = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.CMaterieStateText = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.CCodeSpec = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.CBrand = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.CUnit = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.CCatgName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.CFilePath = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.CWarehouseQty = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.pnlPage = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpRepertoryNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCodeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchCodeFileName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPartsCodeIdView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabBom)).BeginInit();
            this.xtraTabBom.SuspendLayout();
            this.PageBomInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListBom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlPage)).BeginInit();
            this.pnlPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lookUpRepertoryNo);
            this.pnlTop.Controls.Add(this.labRepertoryNo);
            this.pnlTop.Controls.Add(this.textCodeName);
            this.pnlTop.Controls.Add(this.labelControl1);
            this.pnlTop.Controls.Add(this.btnSaveExcel);
            this.pnlTop.Controls.Add(this.btnQuery);
            this.pnlTop.Controls.Add(this.labPartsCodeId);
            this.pnlTop.Controls.Add(this.searchCodeFileName);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1099, 68);
            this.pnlTop.TabIndex = 1;
            // 
            // lookUpRepertoryNo
            // 
            this.lookUpRepertoryNo.EnterMoveNextControl = true;
            this.lookUpRepertoryNo.Location = new System.Drawing.Point(615, 23);
            this.lookUpRepertoryNo.Name = "lookUpRepertoryNo";
            this.lookUpRepertoryNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpRepertoryNo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AutoId", "AutoId", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RepertoryNo", "仓库编号"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RepertoryName", "仓库名称"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RepertoryTypeText", "仓库类型")});
            this.lookUpRepertoryNo.Properties.DisplayMember = "RepertoryName";
            this.lookUpRepertoryNo.Properties.NullText = "";
            this.lookUpRepertoryNo.Properties.ValueMember = "RepertoryNo";
            this.lookUpRepertoryNo.Size = new System.Drawing.Size(150, 20);
            this.lookUpRepertoryNo.TabIndex = 2;
            // 
            // labRepertoryNo
            // 
            this.labRepertoryNo.Location = new System.Drawing.Point(557, 26);
            this.labRepertoryNo.Name = "labRepertoryNo";
            this.labRepertoryNo.Size = new System.Drawing.Size(36, 14);
            this.labRepertoryNo.TabIndex = 108;
            this.labRepertoryNo.Text = "仓库：";
            // 
            // textCodeName
            // 
            this.textCodeName.Location = new System.Drawing.Point(379, 23);
            this.textCodeName.Name = "textCodeName";
            this.textCodeName.Properties.ReadOnly = true;
            this.textCodeName.Size = new System.Drawing.Size(150, 20);
            this.textCodeName.TabIndex = 1;
            this.textCodeName.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(299, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 105;
            this.labelControl1.Text = "零件名称";
            // 
            // btnSaveExcel
            // 
            this.btnSaveExcel.Location = new System.Drawing.Point(906, 22);
            this.btnSaveExcel.Name = "btnSaveExcel";
            this.btnSaveExcel.Size = new System.Drawing.Size(75, 23);
            this.btnSaveExcel.TabIndex = 4;
            this.btnSaveExcel.Text = "存为Excel";
            this.btnSaveExcel.Click += new System.EventHandler(this.btnSaveExcel_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(804, 22);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 3;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // labPartsCodeId
            // 
            this.labPartsCodeId.Location = new System.Drawing.Point(46, 26);
            this.labPartsCodeId.Name = "labPartsCodeId";
            this.labPartsCodeId.Size = new System.Drawing.Size(48, 14);
            this.labPartsCodeId.TabIndex = 13;
            this.labPartsCodeId.Text = "零件编号";
            // 
            // searchCodeFileName
            // 
            this.searchCodeFileName.EnterMoveNextControl = true;
            this.searchCodeFileName.Location = new System.Drawing.Point(122, 23);
            this.searchCodeFileName.Name = "searchCodeFileName";
            this.searchCodeFileName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchCodeFileName.Properties.DisplayMember = "CodeFileName";
            this.searchCodeFileName.Properties.NullText = "";
            this.searchCodeFileName.Properties.ValueMember = "CodeFileName";
            this.searchCodeFileName.Properties.View = this.searchPartsCodeIdView;
            this.searchCodeFileName.Size = new System.Drawing.Size(150, 20);
            this.searchCodeFileName.TabIndex = 0;
            this.searchCodeFileName.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.searchCodeFileName_EditValueChanging);
            // 
            // searchPartsCodeIdView
            // 
            this.searchPartsCodeIdView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn2});
            this.searchPartsCodeIdView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchPartsCodeIdView.IndicatorWidth = 60;
            this.searchPartsCodeIdView.Name = "searchPartsCodeIdView";
            this.searchPartsCodeIdView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchPartsCodeIdView.OptionsView.ShowGroupPanel = false;
            this.searchPartsCodeIdView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewBomMateriel_CustomDrawRowIndicator);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "零件编号";
            this.gridColumn1.FieldName = "CodeFileName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "零件名称";
            this.gridColumn3.FieldName = "CodeName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "AutoId";
            this.gridColumn2.FieldName = "AutoId";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // xtraTabBom
            // 
            this.xtraTabBom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabBom.Location = new System.Drawing.Point(2, 2);
            this.xtraTabBom.Name = "xtraTabBom";
            this.xtraTabBom.SelectedTabPage = this.PageBomInfo;
            this.xtraTabBom.Size = new System.Drawing.Size(1095, 553);
            this.xtraTabBom.TabIndex = 2;
            this.xtraTabBom.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.PageBomInfo});
            // 
            // PageBomInfo
            // 
            this.PageBomInfo.Controls.Add(this.treeListBom);
            this.PageBomInfo.Name = "PageBomInfo";
            this.PageBomInfo.Size = new System.Drawing.Size(1089, 524);
            this.PageBomInfo.Text = "Bom零件库存";
            // 
            // treeListBom
            // 
            this.treeListBom.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.CCodeFileName,
            this.CCodeName,
            this.CQty,
            this.CParentCodeFileName,
            this.CPCAutoId,
            this.CReID,
            this.CReParent,
            this.CMaterieStateText,
            this.CCodeSpec,
            this.CBrand,
            this.CUnit,
            this.CCatgName,
            this.CFilePath,
            this.CWarehouseQty});
            this.treeListBom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListBom.KeyFieldName = "ReID";
            this.treeListBom.Location = new System.Drawing.Point(0, 0);
            this.treeListBom.Name = "treeListBom";
            this.treeListBom.OptionsBehavior.Editable = false;
            this.treeListBom.OptionsBehavior.EnableFiltering = true;
            this.treeListBom.OptionsBehavior.ReadOnly = true;
            this.treeListBom.OptionsClipboard.AllowCopy = DevExpress.Utils.DefaultBoolean.True;
            this.treeListBom.OptionsClipboard.CopyNodeHierarchy = DevExpress.Utils.DefaultBoolean.True;
            this.treeListBom.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.treeListBom.OptionsView.AutoWidth = false;
            this.treeListBom.OptionsView.EnableAppearanceEvenRow = true;
            this.treeListBom.OptionsView.EnableAppearanceOddRow = true;
            this.treeListBom.OptionsView.ShowHorzLines = false;
            this.treeListBom.OptionsView.ShowIndicator = false;
            this.treeListBom.OptionsView.ShowVertLines = false;
            this.treeListBom.ParentFieldName = "ReParent";
            this.treeListBom.Size = new System.Drawing.Size(1089, 524);
            this.treeListBom.TabIndex = 3;
            this.treeListBom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeListBom_KeyDown);
            // 
            // CCodeFileName
            // 
            this.CCodeFileName.AppearanceHeader.Options.UseTextOptions = true;
            this.CCodeFileName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CCodeFileName.Caption = "零件编号";
            this.CCodeFileName.FieldName = "CodeFileName";
            this.CCodeFileName.Name = "CCodeFileName";
            this.CCodeFileName.Visible = true;
            this.CCodeFileName.VisibleIndex = 0;
            this.CCodeFileName.Width = 350;
            // 
            // CCodeName
            // 
            this.CCodeName.AppearanceHeader.Options.UseTextOptions = true;
            this.CCodeName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CCodeName.Caption = "零件名称";
            this.CCodeName.FieldName = "CodeName";
            this.CCodeName.Name = "CCodeName";
            this.CCodeName.Visible = true;
            this.CCodeName.VisibleIndex = 1;
            this.CCodeName.Width = 150;
            // 
            // CQty
            // 
            this.CQty.AppearanceHeader.Options.UseTextOptions = true;
            this.CQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CQty.Caption = "数量";
            this.CQty.FieldName = "Qty";
            this.CQty.Name = "CQty";
            this.CQty.Visible = true;
            this.CQty.VisibleIndex = 2;
            this.CQty.Width = 60;
            // 
            // CParentCodeFileName
            // 
            this.CParentCodeFileName.Caption = "ParentCodeFileName";
            this.CParentCodeFileName.FieldName = "ParentCodeFileName";
            this.CParentCodeFileName.Name = "CParentCodeFileName";
            // 
            // CPCAutoId
            // 
            this.CPCAutoId.Caption = "PCAutoId";
            this.CPCAutoId.FieldName = "PCAutoId";
            this.CPCAutoId.Name = "CPCAutoId";
            // 
            // CReID
            // 
            this.CReID.Caption = "ReID";
            this.CReID.FieldName = "ReID";
            this.CReID.Name = "CReID";
            // 
            // CReParent
            // 
            this.CReParent.Caption = "ReParent";
            this.CReParent.FieldName = "ReParent";
            this.CReParent.Name = "CReParent";
            // 
            // CMaterieStateText
            // 
            this.CMaterieStateText.AppearanceHeader.Options.UseTextOptions = true;
            this.CMaterieStateText.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CMaterieStateText.Caption = "物料状态";
            this.CMaterieStateText.FieldName = "MaterieStateText";
            this.CMaterieStateText.Name = "CMaterieStateText";
            this.CMaterieStateText.Visible = true;
            this.CMaterieStateText.VisibleIndex = 4;
            this.CMaterieStateText.Width = 100;
            // 
            // CCodeSpec
            // 
            this.CCodeSpec.AppearanceHeader.Options.UseTextOptions = true;
            this.CCodeSpec.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CCodeSpec.Caption = "规格型号";
            this.CCodeSpec.FieldName = "CodeSpec";
            this.CCodeSpec.Name = "CCodeSpec";
            this.CCodeSpec.Visible = true;
            this.CCodeSpec.VisibleIndex = 5;
            this.CCodeSpec.Width = 120;
            // 
            // CBrand
            // 
            this.CBrand.AppearanceHeader.Options.UseTextOptions = true;
            this.CBrand.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CBrand.Caption = "品牌";
            this.CBrand.FieldName = "Brand";
            this.CBrand.Name = "CBrand";
            this.CBrand.Visible = true;
            this.CBrand.VisibleIndex = 6;
            this.CBrand.Width = 80;
            // 
            // CUnit
            // 
            this.CUnit.AppearanceHeader.Options.UseTextOptions = true;
            this.CUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CUnit.Caption = "单位";
            this.CUnit.FieldName = "Unit";
            this.CUnit.Name = "CUnit";
            this.CUnit.Visible = true;
            this.CUnit.VisibleIndex = 7;
            this.CUnit.Width = 80;
            // 
            // CCatgName
            // 
            this.CCatgName.AppearanceHeader.Options.UseTextOptions = true;
            this.CCatgName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CCatgName.Caption = "分类";
            this.CCatgName.FieldName = "CatgName";
            this.CCatgName.Name = "CCatgName";
            this.CCatgName.Visible = true;
            this.CCatgName.VisibleIndex = 8;
            this.CCatgName.Width = 80;
            // 
            // CFilePath
            // 
            this.CFilePath.AppearanceHeader.Options.UseTextOptions = true;
            this.CFilePath.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CFilePath.Caption = "文件路径";
            this.CFilePath.FieldName = "FilePath";
            this.CFilePath.Name = "CFilePath";
            this.CFilePath.Visible = true;
            this.CFilePath.VisibleIndex = 9;
            this.CFilePath.Width = 400;
            // 
            // CWarehouseQty
            // 
            this.CWarehouseQty.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.CWarehouseQty.AppearanceCell.Options.UseForeColor = true;
            this.CWarehouseQty.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.CWarehouseQty.AppearanceHeader.Options.UseForeColor = true;
            this.CWarehouseQty.AppearanceHeader.Options.UseTextOptions = true;
            this.CWarehouseQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CWarehouseQty.Caption = "当前库存数";
            this.CWarehouseQty.FieldName = "WarehouseQty";
            this.CWarehouseQty.Name = "CWarehouseQty";
            this.CWarehouseQty.Visible = true;
            this.CWarehouseQty.VisibleIndex = 3;
            this.CWarehouseQty.Width = 90;
            // 
            // pnlPage
            // 
            this.pnlPage.Controls.Add(this.xtraTabBom);
            this.pnlPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPage.Location = new System.Drawing.Point(0, 68);
            this.pnlPage.Name = "pnlPage";
            this.pnlPage.Size = new System.Drawing.Size(1099, 557);
            this.pnlPage.TabIndex = 3;
            // 
            // FrmWarehouseNowInfo_Bom
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1099, 625);
            this.Controls.Add(this.pnlPage);
            this.Controls.Add(this.pnlTop);
            this.Name = "FrmWarehouseNowInfo_Bom";
            this.TabText = "Bom零件当前库存查询";
            this.Text = "Bom零件当前库存查询";
            this.Load += new System.EventHandler(this.FrmWarehouseNowInfo_Bom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpRepertoryNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCodeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchCodeFileName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPartsCodeIdView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabBom)).EndInit();
            this.xtraTabBom.ResumeLayout(false);
            this.PageBomInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListBom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlPage)).EndInit();
            this.pnlPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlTop;
        private DevExpress.XtraEditors.TextEdit textCodeName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSaveExcel;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.LabelControl labPartsCodeId;
        private DevExpress.XtraEditors.SearchLookUpEdit searchCodeFileName;
        private DevExpress.XtraGrid.Views.Grid.GridView searchPartsCodeIdView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraTab.XtraTabControl xtraTabBom;
        private DevExpress.XtraTab.XtraTabPage PageBomInfo;
        private DevExpress.XtraEditors.PanelControl pnlPage;
        private DevExpress.XtraTreeList.TreeList treeListBom;
        private DevExpress.XtraTreeList.Columns.TreeListColumn CCodeFileName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn CCodeName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn CQty;
        private DevExpress.XtraTreeList.Columns.TreeListColumn CParentCodeFileName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn CPCAutoId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn CReID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn CReParent;
        private DevExpress.XtraTreeList.Columns.TreeListColumn CMaterieStateText;
        private DevExpress.XtraTreeList.Columns.TreeListColumn CCodeSpec;
        private DevExpress.XtraTreeList.Columns.TreeListColumn CBrand;
        private DevExpress.XtraTreeList.Columns.TreeListColumn CUnit;
        private DevExpress.XtraTreeList.Columns.TreeListColumn CCatgName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn CFilePath;
        private DevExpress.XtraTreeList.Columns.TreeListColumn CWarehouseQty;
        private DevExpress.XtraEditors.LookUpEdit lookUpRepertoryNo;
        private DevExpress.XtraEditors.LabelControl labRepertoryNo;
    }
}