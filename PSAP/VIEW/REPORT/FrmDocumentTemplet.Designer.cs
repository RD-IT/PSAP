namespace PSAP.VIEW.BSVIEW
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
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.treeListDocTemp = new DevExpress.XtraTreeList.TreeList();
            this.treeColModuleName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeColTableName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeColDocFileName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeColDocPath = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeColDocVersion = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repTextDocVersion = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.treeColUpload = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repItemBtnEdtUpload = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.pnlTop = new DevExpress.XtraEditors.PanelControl();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiWcxddq = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCxmbwj = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCtjzsjcw = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMbsjwsf = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMbqrsc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiScdjmb = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSdsddyg = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSdsdxsbj = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQrgxmk = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDdymbd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMk = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDbbhgxcg = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDbbhgxsb = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDyggb = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiJjdlbg = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiJjdhbg = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListDocTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTextDocVersion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemBtnEdtUpload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // treeListDocTemp
            // 
            this.treeListDocTemp.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeColModuleName,
            this.treeColTableName,
            this.treeColDocFileName,
            this.treeColDocPath,
            this.treeColDocVersion,
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
            null,
            null}, -1);
            this.treeListDocTemp.EndUnboundLoad();
            this.treeListDocTemp.OptionsView.EnableAppearanceOddRow = true;
            this.treeListDocTemp.ParentFieldName = "ParentId";
            this.treeListDocTemp.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repItemBtnEdtUpload,
            this.repTextDocVersion});
            this.treeListDocTemp.Size = new System.Drawing.Size(983, 437);
            this.treeListDocTemp.TabIndex = 0;
            this.treeListDocTemp.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeListDocTemp_FocusedNodeChanged);
            this.treeListDocTemp.FocusedColumnChanged += new DevExpress.XtraTreeList.FocusedColumnChangedEventHandler(this.treeListDocTemp_FocusedColumnChanged);
            this.treeListDocTemp.CustomDrawNodeCell += new DevExpress.XtraTreeList.CustomDrawNodeCellEventHandler(this.treeListDocTemp_CustomDrawNodeCell);
            this.treeListDocTemp.CellValueChanged += new DevExpress.XtraTreeList.CellValueChangedEventHandler(this.treeListDocTemp_CellValueChanged);
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
            this.treeColModuleName.Width = 300;
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
            this.treeColDocFileName.Width = 160;
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
            this.treeColDocPath.Width = 160;
            // 
            // treeColDocVersion
            // 
            this.treeColDocVersion.AppearanceHeader.Options.UseTextOptions = true;
            this.treeColDocVersion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeColDocVersion.Caption = "版本号";
            this.treeColDocVersion.ColumnEdit = this.repTextDocVersion;
            this.treeColDocVersion.FieldName = "DocVersion";
            this.treeColDocVersion.Name = "treeColDocVersion";
            this.treeColDocVersion.OptionsColumn.AllowEdit = false;
            this.treeColDocVersion.Visible = true;
            this.treeColDocVersion.VisibleIndex = 3;
            this.treeColDocVersion.Width = 100;
            // 
            // repTextDocVersion
            // 
            this.repTextDocVersion.AutoHeight = false;
            this.repTextDocVersion.Name = "repTextDocVersion";
            // 
            // treeColUpload
            // 
            this.treeColUpload.AppearanceHeader.Options.UseTextOptions = true;
            this.treeColUpload.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeColUpload.Caption = "操作";
            this.treeColUpload.ColumnEdit = this.repItemBtnEdtUpload;
            this.treeColUpload.FieldName = "Upload";
            this.treeColUpload.Name = "treeColUpload";
            this.treeColUpload.Visible = true;
            this.treeColUpload.VisibleIndex = 4;
            this.treeColUpload.Width = 90;
            // 
            // repItemBtnEdtUpload
            // 
            this.repItemBtnEdtUpload.AutoHeight = false;
            this.repItemBtnEdtUpload.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "编辑", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "上传", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "版本", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
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
            this.pnlTop.Size = new System.Drawing.Size(987, 441);
            this.pnlTop.TabIndex = 1;
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiWcxddq,
            this.tsmiCxmbwj,
            this.tsmiCtjzsjcw,
            this.tsmiMbsjwsf,
            this.tsmiMbqrsc,
            this.tsmiScdjmb,
            this.tsmiSdsddyg,
            this.tsmiSdsdxsbj,
            this.tsmiQrgxmk,
            this.tsmiDdymbd,
            this.tsmiMk,
            this.tsmiDbbhgxcg,
            this.tsmiDbbhgxsb,
            this.tsmiDyggb,
            this.tsmiJjdlbg,
            this.tsmiJjdhbg});
            this.cms.Name = "cmsCommonHandler";
            this.cms.Size = new System.Drawing.Size(521, 356);
            // 
            // tsmiWcxddq
            // 
            this.tsmiWcxddq.Name = "tsmiWcxddq";
            this.tsmiWcxddq.Size = new System.Drawing.Size(520, 22);
            this.tsmiWcxddq.Text = "未查询到当前表的模板记录，操作错误。";
            // 
            // tsmiCxmbwj
            // 
            this.tsmiCxmbwj.Name = "tsmiCxmbwj";
            this.tsmiCxmbwj.Size = new System.Drawing.Size(520, 22);
            this.tsmiCxmbwj.Text = "查询模板文件异常。";
            // 
            // tsmiCtjzsjcw
            // 
            this.tsmiCtjzsjcw.Name = "tsmiCtjzsjcw";
            this.tsmiCtjzsjcw.Size = new System.Drawing.Size(520, 22);
            this.tsmiCtjzsjcw.Text = "窗体加载事件错误。";
            // 
            // tsmiMbsjwsf
            // 
            this.tsmiMbsjwsf.Name = "tsmiMbsjwsf";
            this.tsmiMbsjwsf.Size = new System.Drawing.Size(520, 22);
            this.tsmiMbsjwsf.Text = "模板设计完是否要上传更新服务器的版本吗?";
            // 
            // tsmiMbqrsc
            // 
            this.tsmiMbqrsc.Name = "tsmiMbqrsc";
            this.tsmiMbqrsc.Size = new System.Drawing.Size(520, 22);
            this.tsmiMbqrsc.Text = "模板确认上传更新服务器的版本吗?";
            // 
            // tsmiScdjmb
            // 
            this.tsmiScdjmb.Name = "tsmiScdjmb";
            this.tsmiScdjmb.Size = new System.Drawing.Size(520, 22);
            this.tsmiScdjmb.Text = "上传单据模板事件错误。";
            // 
            // tsmiSdsddyg
            // 
            this.tsmiSdsddyg.Name = "tsmiSdsddyg";
            this.tsmiSdsddyg.Size = new System.Drawing.Size(520, 22);
            this.tsmiSdsddyg.Text = "设定树的单元格显示事件错误。";
            // 
            // tsmiSdsdxsbj
            // 
            this.tsmiSdsdxsbj.Name = "tsmiSdsdxsbj";
            this.tsmiSdsdxsbj.Size = new System.Drawing.Size(520, 22);
            this.tsmiSdsdxsbj.Text = "设定树的显示编辑事件错误。";
            // 
            // tsmiQrgxmk
            // 
            this.tsmiQrgxmk.Name = "tsmiQrgxmk";
            this.tsmiQrgxmk.Size = new System.Drawing.Size(520, 22);
            this.tsmiQrgxmk.Text = "确认更新模块";
            // 
            // tsmiDdymbd
            // 
            this.tsmiDdymbd.Name = "tsmiDdymbd";
            this.tsmiDdymbd.Size = new System.Drawing.Size(520, 22);
            this.tsmiDdymbd.Text = "的打印模板的版本号吗？（更新版本号后，所有站点将会重新下载最新的打印模板）";
            // 
            // tsmiMk
            // 
            this.tsmiMk.Name = "tsmiMk";
            this.tsmiMk.Size = new System.Drawing.Size(520, 22);
            this.tsmiMk.Text = "模块";
            // 
            // tsmiDbbhgxcg
            // 
            this.tsmiDbbhgxcg.Name = "tsmiDbbhgxcg";
            this.tsmiDbbhgxcg.Size = new System.Drawing.Size(520, 22);
            this.tsmiDbbhgxcg.Text = "的版本号更新成功。";
            // 
            // tsmiDbbhgxsb
            // 
            this.tsmiDbbhgxsb.Name = "tsmiDbbhgxsb";
            this.tsmiDbbhgxsb.Size = new System.Drawing.Size(520, 22);
            this.tsmiDbbhgxsb.Text = "的版本号更新失败。";
            // 
            // tsmiDyggb
            // 
            this.tsmiDyggb.Name = "tsmiDyggb";
            this.tsmiDyggb.Size = new System.Drawing.Size(520, 22);
            this.tsmiDyggb.Text = "单元格改变更新数据库事件错误。";
            // 
            // tsmiJjdlbg
            // 
            this.tsmiJjdlbg.Name = "tsmiJjdlbg";
            this.tsmiJjdlbg.Size = new System.Drawing.Size(520, 22);
            this.tsmiJjdlbg.Text = "聚焦的列变更事件错误。";
            // 
            // tsmiJjdhbg
            // 
            this.tsmiJjdhbg.Name = "tsmiJjdhbg";
            this.tsmiJjdhbg.Size = new System.Drawing.Size(520, 22);
            this.tsmiJjdhbg.Text = "聚焦的行变更事件错误。";
            // 
            // FrmDocumentTemplet
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(987, 441);
            this.Controls.Add(this.pnlTop);
            this.Name = "FrmDocumentTemplet";
            this.TabText = "单据模板设计";
            this.Text = "单据模板设计";
            this.Load += new System.EventHandler(this.FrmDocumentTemplet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListDocTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTextDocVersion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemBtnEdtUpload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.cms.ResumeLayout(false);
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
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeColDocVersion;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repTextDocVersion;
        internal System.Windows.Forms.ContextMenuStrip cms;
        internal System.Windows.Forms.ToolStripMenuItem tsmiWcxddq;
        internal System.Windows.Forms.ToolStripMenuItem tsmiCxmbwj;
        private System.Windows.Forms.ToolStripMenuItem tsmiCtjzsjcw;
        private System.Windows.Forms.ToolStripMenuItem tsmiMbsjwsf;
        private System.Windows.Forms.ToolStripMenuItem tsmiMbqrsc;
        private System.Windows.Forms.ToolStripMenuItem tsmiScdjmb;
        private System.Windows.Forms.ToolStripMenuItem tsmiSdsddyg;
        private System.Windows.Forms.ToolStripMenuItem tsmiSdsdxsbj;
        private System.Windows.Forms.ToolStripMenuItem tsmiQrgxmk;
        private System.Windows.Forms.ToolStripMenuItem tsmiDdymbd;
        private System.Windows.Forms.ToolStripMenuItem tsmiMk;
        private System.Windows.Forms.ToolStripMenuItem tsmiDbbhgxcg;
        private System.Windows.Forms.ToolStripMenuItem tsmiDbbhgxsb;
        private System.Windows.Forms.ToolStripMenuItem tsmiDyggb;
        private System.Windows.Forms.ToolStripMenuItem tsmiJjdlbg;
        private System.Windows.Forms.ToolStripMenuItem tsmiJjdhbg;
    }
}