namespace PSAP.VIEW.BSVIEW
{
    partial class FrmRight_UserMenuButton
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
            this.pnlLeft = new DevExpress.XtraEditors.PanelControl();
            this.pnlLeftGrid = new DevExpress.XtraEditors.PanelControl();
            this.gridControlUserList = new DevExpress.XtraGrid.GridControl();
            this.dgvUserList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pnlLeftTop = new DevExpress.XtraEditors.PanelControl();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtLoginID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labReqDep = new DevExpress.XtraEditors.LabelControl();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpReqDep = new DevExpress.XtraEditors.LookUpEdit();
            this.pnlRight = new DevExpress.XtraEditors.PanelControl();
            this.pnlRightTree = new DevExpress.XtraEditors.PanelControl();
            this.tvwUserRight = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.pnlRightTop = new DevExpress.XtraEditors.PanelControl();
            this.cboRoleName = new DevExpress.XtraEditors.LookUpEdit();
            this.btnSaveRight = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cms = new System.Windows.Forms.ContextMenuStrip();
            this.tsmiCxyhqxxxcw = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCxyhdqxsjcw = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiYhqxycgbc = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeft)).BeginInit();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeftGrid)).BeginInit();
            this.pnlLeftGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeftTop)).BeginInit();
            this.pnlLeftTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoginID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpReqDep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).BeginInit();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRightTree)).BeginInit();
            this.pnlRightTree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tvwUserRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRightTop)).BeginInit();
            this.pnlRightTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboRoleName.Properties)).BeginInit();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlLeft.Controls.Add(this.pnlLeftGrid);
            this.pnlLeft.Controls.Add(this.pnlLeftTop);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(460, 577);
            this.pnlLeft.TabIndex = 0;
            // 
            // pnlLeftGrid
            // 
            this.pnlLeftGrid.Controls.Add(this.gridControlUserList);
            this.pnlLeftGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeftGrid.Location = new System.Drawing.Point(2, 90);
            this.pnlLeftGrid.Name = "pnlLeftGrid";
            this.pnlLeftGrid.Size = new System.Drawing.Size(456, 485);
            this.pnlLeftGrid.TabIndex = 38;
            // 
            // gridControlUserList
            // 
            this.gridControlUserList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlUserList.Location = new System.Drawing.Point(2, 2);
            this.gridControlUserList.MainView = this.dgvUserList;
            this.gridControlUserList.Name = "gridControlUserList";
            this.gridControlUserList.Size = new System.Drawing.Size(452, 481);
            this.gridControlUserList.TabIndex = 0;
            this.gridControlUserList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvUserList});
            // 
            // dgvUserList
            // 
            this.dgvUserList.GridControl = this.gridControlUserList;
            this.dgvUserList.IndicatorWidth = 40;
            this.dgvUserList.Name = "dgvUserList";
            this.dgvUserList.OptionsBehavior.Editable = false;
            this.dgvUserList.OptionsBehavior.ReadOnly = true;
            this.dgvUserList.OptionsView.ColumnAutoWidth = false;
            this.dgvUserList.OptionsView.EnableAppearanceOddRow = true;
            this.dgvUserList.OptionsView.ShowGroupPanel = false;
            this.dgvUserList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.dgvUserList_CustomDrawRowIndicator);
            this.dgvUserList.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dgvUserList_FocusedRowChanged);
            // 
            // pnlLeftTop
            // 
            this.pnlLeftTop.Controls.Add(this.txtUserName);
            this.pnlLeftTop.Controls.Add(this.labelControl4);
            this.pnlLeftTop.Controls.Add(this.txtLoginID);
            this.pnlLeftTop.Controls.Add(this.labelControl3);
            this.pnlLeftTop.Controls.Add(this.labReqDep);
            this.pnlLeftTop.Controls.Add(this.btnQuery);
            this.pnlLeftTop.Controls.Add(this.lookUpReqDep);
            this.pnlLeftTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeftTop.Location = new System.Drawing.Point(2, 2);
            this.pnlLeftTop.Name = "pnlLeftTop";
            this.pnlLeftTop.Size = new System.Drawing.Size(456, 88);
            this.pnlLeftTop.TabIndex = 37;
            // 
            // txtUserName
            // 
            this.txtUserName.EnterMoveNextControl = true;
            this.txtUserName.Location = new System.Drawing.Point(290, 17);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(120, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(224, 20);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 14);
            this.labelControl4.TabIndex = 40;
            this.labelControl4.Text = "用户姓名：";
            // 
            // txtLoginID
            // 
            this.txtLoginID.EnterMoveNextControl = true;
            this.txtLoginID.Location = new System.Drawing.Point(84, 17);
            this.txtLoginID.Name = "txtLoginID";
            this.txtLoginID.Size = new System.Drawing.Size(120, 20);
            this.txtLoginID.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(18, 20);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 14);
            this.labelControl3.TabIndex = 38;
            this.labelControl3.Text = "用户编号：";
            // 
            // labReqDep
            // 
            this.labReqDep.Location = new System.Drawing.Point(18, 52);
            this.labReqDep.Name = "labReqDep";
            this.labReqDep.Size = new System.Drawing.Size(60, 14);
            this.labReqDep.TabIndex = 33;
            this.labReqDep.Text = "入库部门：";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(233, 48);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 3;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // lookUpReqDep
            // 
            this.lookUpReqDep.EnterMoveNextControl = true;
            this.lookUpReqDep.Location = new System.Drawing.Point(84, 49);
            this.lookUpReqDep.Name = "lookUpReqDep";
            this.lookUpReqDep.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpReqDep.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentNo", "部门编号", 95, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentName", "部门名称", 111, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpReqDep.Properties.DisplayMember = "DepartmentName";
            this.lookUpReqDep.Properties.NullText = "";
            this.lookUpReqDep.Properties.ValueMember = "DepartmentNo";
            this.lookUpReqDep.Size = new System.Drawing.Size(120, 20);
            this.lookUpReqDep.TabIndex = 2;
            // 
            // pnlRight
            // 
            this.pnlRight.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlRight.Controls.Add(this.pnlRightTree);
            this.pnlRight.Controls.Add(this.pnlRightTop);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(460, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(573, 577);
            this.pnlRight.TabIndex = 1;
            // 
            // pnlRightTree
            // 
            this.pnlRightTree.Controls.Add(this.tvwUserRight);
            this.pnlRightTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightTree.Location = new System.Drawing.Point(2, 90);
            this.pnlRightTree.Name = "pnlRightTree";
            this.pnlRightTree.Size = new System.Drawing.Size(569, 485);
            this.pnlRightTree.TabIndex = 1;
            // 
            // tvwUserRight
            // 
            this.tvwUserRight.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2});
            this.tvwUserRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwUserRight.Location = new System.Drawing.Point(2, 2);
            this.tvwUserRight.Name = "tvwUserRight";
            this.tvwUserRight.OptionsClipboard.AllowCopy = DevExpress.Utils.DefaultBoolean.True;
            this.tvwUserRight.OptionsClipboard.CopyNodeHierarchy = DevExpress.Utils.DefaultBoolean.True;
            this.tvwUserRight.OptionsView.EnableAppearanceEvenRow = true;
            this.tvwUserRight.OptionsView.EnableAppearanceOddRow = true;
            this.tvwUserRight.OptionsView.ShowCheckBoxes = true;
            this.tvwUserRight.OptionsView.ShowHorzLines = false;
            this.tvwUserRight.OptionsView.ShowIndicator = false;
            this.tvwUserRight.OptionsView.ShowVertLines = false;
            this.tvwUserRight.Size = new System.Drawing.Size(565, 481);
            this.tvwUserRight.TabIndex = 0;
            this.tvwUserRight.BeforeCheckNode += new DevExpress.XtraTreeList.CheckNodeEventHandler(this.treeListRole_BeforeCheckNode);
            this.tvwUserRight.AfterCheckNode += new DevExpress.XtraTreeList.NodeEventHandler(this.treeListRole_AfterCheckNode);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "MenuName";
            this.treeListColumn1.FieldName = "MenuName";
            this.treeListColumn1.Name = "treeListColumn1";
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "权限菜单按钮";
            this.treeListColumn2.FieldName = "权限菜单按钮";
            this.treeListColumn2.MinWidth = 32;
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.OptionsColumn.AllowEdit = false;
            this.treeListColumn2.OptionsColumn.ReadOnly = true;
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 0;
            this.treeListColumn2.Width = 281;
            // 
            // pnlRightTop
            // 
            this.pnlRightTop.Controls.Add(this.cboRoleName);
            this.pnlRightTop.Controls.Add(this.btnSaveRight);
            this.pnlRightTop.Controls.Add(this.labelControl2);
            this.pnlRightTop.Controls.Add(this.labelControl1);
            this.pnlRightTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRightTop.Location = new System.Drawing.Point(2, 2);
            this.pnlRightTop.Name = "pnlRightTop";
            this.pnlRightTop.Size = new System.Drawing.Size(569, 88);
            this.pnlRightTop.TabIndex = 0;
            // 
            // cboRoleName
            // 
            this.cboRoleName.EnterMoveNextControl = true;
            this.cboRoleName.Location = new System.Drawing.Point(136, 49);
            this.cboRoleName.Name = "cboRoleName";
            this.cboRoleName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboRoleName.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RoleNo", "角色编号", 95, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RoleName", "角色名称", 111, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cboRoleName.Properties.DisplayMember = "RoleName";
            this.cboRoleName.Properties.NullText = "";
            this.cboRoleName.Properties.ValueMember = "RoleNo";
            this.cboRoleName.Size = new System.Drawing.Size(120, 20);
            this.cboRoleName.TabIndex = 20;
            // 
            // btnSaveRight
            // 
            this.btnSaveRight.Location = new System.Drawing.Point(300, 16);
            this.btnSaveRight.Name = "btnSaveRight";
            this.btnSaveRight.Size = new System.Drawing.Size(75, 23);
            this.btnSaveRight.TabIndex = 21;
            this.btnSaveRight.Text = "保存权限";
            this.btnSaveRight.Click += new System.EventHandler(this.btnSaveRight_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(36, 20);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(230, 14);
            this.labelControl2.TabIndex = 37;
            this.labelControl2.Text = "说明 ：斜体字为“角色”权限，此处修改无效";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(36, 52);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 14);
            this.labelControl1.TabIndex = 36;
            this.labelControl1.Text = "用户角色设定：";
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCxyhqxxxcw,
            this.tsmiCxyhdqxsjcw,
            this.tsmiYhqxycgbc});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(221, 70);
            // 
            // tsmiCxyhqxxxcw
            // 
            this.tsmiCxyhqxxxcw.Name = "tsmiCxyhqxxxcw";
            this.tsmiCxyhqxxxcw.Size = new System.Drawing.Size(220, 22);
            this.tsmiCxyhqxxxcw.Text = "查询用户权限信息错误。";
            // 
            // tsmiCxyhdqxsjcw
            // 
            this.tsmiCxyhdqxsjcw.Name = "tsmiCxyhdqxsjcw";
            this.tsmiCxyhdqxsjcw.Size = new System.Drawing.Size(220, 22);
            this.tsmiCxyhdqxsjcw.Text = "查询用户的权限事件错误。";
            // 
            // tsmiYhqxycgbc
            // 
            this.tsmiYhqxycgbc.Name = "tsmiYhqxycgbc";
            this.tsmiYhqxycgbc.Size = new System.Drawing.Size(220, 22);
            this.tsmiYhqxycgbc.Text = "【用户权限】已成功保存。";
            // 
            // FrmRight_UserMenuButton
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1033, 577);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Name = "FrmRight_UserMenuButton";
            this.TabText = "用户权限管理";
            this.Text = "用户权限管理";
            this.Load += new System.EventHandler(this.FrmRight_UserMenuButton_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeft)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeftGrid)).EndInit();
            this.pnlLeftGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeftTop)).EndInit();
            this.pnlLeftTop.ResumeLayout(false);
            this.pnlLeftTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoginID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpReqDep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).EndInit();
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlRightTree)).EndInit();
            this.pnlRightTree.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tvwUserRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRightTop)).EndInit();
            this.pnlRightTop.ResumeLayout(false);
            this.pnlRightTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboRoleName.Properties)).EndInit();
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlLeft;
        private DevExpress.XtraEditors.PanelControl pnlRight;
        private DevExpress.XtraEditors.LookUpEdit lookUpReqDep;
        private DevExpress.XtraEditors.LabelControl labReqDep;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.PanelControl pnlLeftGrid;
        private DevExpress.XtraGrid.GridControl gridControlUserList;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvUserList;
        private DevExpress.XtraEditors.PanelControl pnlLeftTop;
        private DevExpress.XtraEditors.PanelControl pnlRightTree;
        private DevExpress.XtraEditors.PanelControl pnlRightTop;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnSaveRight;
        private DevExpress.XtraEditors.LookUpEdit cboRoleName;
        private DevExpress.XtraTreeList.TreeList tvwUserRight;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtLoginID;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem tsmiCxyhqxxxcw;
        private System.Windows.Forms.ToolStripMenuItem tsmiCxyhdqxsjcw;
        private System.Windows.Forms.ToolStripMenuItem tsmiYhqxycgbc;
    }
}