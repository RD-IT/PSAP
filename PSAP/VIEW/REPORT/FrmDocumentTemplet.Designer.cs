﻿namespace PSAP.VIEW.BSVIEW
{
    partial class FrmDocumentTemplet
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.treeListDocTemp = new DevExpress.XtraTreeList.TreeList();
            this.treeColModuleName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeColTableName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeColDocFileName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeColDocPath = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeColUpload = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repItemBtnEdtUpload = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.pnlTop = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.treeListDocTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemBtnEdtUpload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeListDocTemp
            // 
            this.treeListDocTemp.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeColModuleName,
            this.treeColTableName,
            this.treeColDocFileName,
            this.treeColDocPath,
            this.treeColUpload});
            this.treeListDocTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListDocTemp.KeyFieldName = "AutoId";
            this.treeListDocTemp.Location = new System.Drawing.Point(2, 2);
            this.treeListDocTemp.Name = "treeListDocTemp";
            this.treeListDocTemp.BeginUnboundLoad();
            this.treeListDocTemp.AppendNode(new object[] {
            null,
            null,
            null,
            null,
            null}, -1);
            this.treeListDocTemp.EndUnboundLoad();
            this.treeListDocTemp.OptionsClipboard.AllowCopy = DevExpress.Utils.DefaultBoolean.True;
            this.treeListDocTemp.OptionsClipboard.CopyNodeHierarchy = DevExpress.Utils.DefaultBoolean.True;
            this.treeListDocTemp.OptionsCustomization.AllowBandMoving = false;
            this.treeListDocTemp.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.treeListDocTemp.ParentFieldName = "ParentId";
            this.treeListDocTemp.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repItemBtnEdtUpload});
            this.treeListDocTemp.Size = new System.Drawing.Size(780, 437);
            this.treeListDocTemp.TabIndex = 0;
            this.treeListDocTemp.CustomDrawNodeCell += new DevExpress.XtraTreeList.CustomDrawNodeCellEventHandler(this.treeListDocTemp_CustomDrawNodeCell);
            this.treeListDocTemp.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.treeListDocTemp_ShowingEditor);
            // 
            // treeColModuleName
            // 
            this.treeColModuleName.AppearanceHeader.Options.UseTextOptions = true;
            this.treeColModuleName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeColModuleName.Caption = "模块名称";
            this.treeColModuleName.FieldName = "ModuleName";
            this.treeColModuleName.MinWidth = 70;
            this.treeColModuleName.Name = "treeColModuleName";
            this.treeColModuleName.OptionsColumn.AllowEdit = false;
            this.treeColModuleName.Visible = true;
            this.treeColModuleName.VisibleIndex = 0;
            this.treeColModuleName.Width = 325;
            // 
            // treeColTableName
            // 
            this.treeColTableName.Caption = "表名";
            this.treeColTableName.FieldName = "TableName";
            this.treeColTableName.Name = "treeColTableName";
            this.treeColTableName.Width = 169;
            // 
            // treeColDocFileName
            // 
            this.treeColDocFileName.AppearanceHeader.Options.UseTextOptions = true;
            this.treeColDocFileName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeColDocFileName.Caption = "模板文件名";
            this.treeColDocFileName.FieldName = "DocFileName";
            this.treeColDocFileName.Name = "treeColDocFileName";
            this.treeColDocFileName.OptionsColumn.AllowEdit = false;
            this.treeColDocFileName.Visible = true;
            this.treeColDocFileName.VisibleIndex = 2;
            this.treeColDocFileName.Width = 176;
            // 
            // treeColDocPath
            // 
            this.treeColDocPath.AppearanceHeader.Options.UseTextOptions = true;
            this.treeColDocPath.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeColDocPath.Caption = "模板路径";
            this.treeColDocPath.FieldName = "DocPath";
            this.treeColDocPath.Name = "treeColDocPath";
            this.treeColDocPath.OptionsColumn.AllowEdit = false;
            this.treeColDocPath.Visible = true;
            this.treeColDocPath.VisibleIndex = 1;
            this.treeColDocPath.Width = 182;
            // 
            // treeColUpload
            // 
            this.treeColUpload.Caption = " ";
            this.treeColUpload.ColumnEdit = this.repItemBtnEdtUpload;
            this.treeColUpload.FieldName = "Upload";
            this.treeColUpload.Name = "treeColUpload";
            this.treeColUpload.Visible = true;
            this.treeColUpload.VisibleIndex = 3;
            this.treeColUpload.Width = 79;
            // 
            // repItemBtnEdtUpload
            // 
            this.repItemBtnEdtUpload.AutoHeight = false;
            this.repItemBtnEdtUpload.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "编辑", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "上传", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.repItemBtnEdtUpload.Name = "repItemBtnEdtUpload";
            this.repItemBtnEdtUpload.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repItemBtnEdtUpload.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repItemBtnEdtUpload_ButtonClick);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.treeListDocTemp);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(784, 441);
            this.pnlTop.TabIndex = 1;
            // 
            // FrmDocumentTemplet
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.pnlTop);
            this.Name = "FrmDocumentTemplet";
            this.TabText = "单据模板设计";
            this.Text = "单据模板设计";
            this.Load += new System.EventHandler(this.FrmDocumentTemplet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeListDocTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemBtnEdtUpload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeListDocTemp;
        private DevExpress.XtraEditors.PanelControl pnlTop;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeColModuleName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeColTableName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeColDocPath;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeColDocFileName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeColUpload;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repItemBtnEdtUpload;
    }
}