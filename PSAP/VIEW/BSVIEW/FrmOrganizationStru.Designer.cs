namespace PSAP.VIEW.BSVIEW
{
    partial class FrmOrganizationStru
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
            System.Windows.Forms.Label departmentNoLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrganizationStru));
            this.bS_DepartmentDataGridView = new System.Windows.Forms.DataGridView();
            this.autoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentDepartmentNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.founderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bfree1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bfree2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bfree3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bfree4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bfree5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bS_DepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPSAP = new PSAP.dsPSAP();
            this.bS_DepartmentTableAdapter = new PSAP.dsPSAPTableAdapters.BS_DepartmentTableAdapter();
            this.tvwOrganizationStru = new System.Windows.Forms.TreeView();
            this.cmnsOrganizationStruTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.insertTreeNode = new System.Windows.Forms.ToolStripMenuItem();
            this.addChildTreeNode = new System.Windows.Forms.ToolStripMenuItem();
            this.addRootTreeNode = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteTreeNode = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bS_DepartmentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bdnCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bdnMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bdnMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bdnPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bdnMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bdnMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsControl = new System.Windows.Forms.ToolStrip();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            this.tsbDGViewExportToCSV = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.departmentNoTextBox1 = new System.Windows.Forms.TextBox();
            departmentNoLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bS_DepartmentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bS_DepartmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPSAP)).BeginInit();
            this.cmnsOrganizationStruTree.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bS_DepartmentBindingNavigator)).BeginInit();
            this.bS_DepartmentBindingNavigator.SuspendLayout();
            this.tsControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // departmentNoLabel1
            // 
            departmentNoLabel1.AutoSize = true;
            departmentNoLabel1.Font = new System.Drawing.Font("宋体", 9F);
            departmentNoLabel1.Location = new System.Drawing.Point(422, 80);
            departmentNoLabel1.Name = "departmentNoLabel1";
            departmentNoLabel1.Size = new System.Drawing.Size(53, 12);
            departmentNoLabel1.TabIndex = 25;
            departmentNoLabel1.Text = "部门编号";
            // 
            // bS_DepartmentDataGridView
            // 
            this.bS_DepartmentDataGridView.AllowUserToAddRows = false;
            this.bS_DepartmentDataGridView.AllowUserToDeleteRows = false;
            this.bS_DepartmentDataGridView.AutoGenerateColumns = false;
            this.bS_DepartmentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.bS_DepartmentDataGridView.ColumnHeadersHeight = 28;
            this.bS_DepartmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.autoIdDataGridViewTextBoxColumn,
            this.departmentNoDataGridViewTextBoxColumn,
            this.departmentNameDataGridViewTextBoxColumn,
            this.parentDepartmentNoDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.founderDataGridViewTextBoxColumn,
            this.bfree1DataGridViewTextBoxColumn,
            this.bfree2DataGridViewTextBoxColumn,
            this.bfree3DataGridViewTextBoxColumn,
            this.bfree4DataGridViewTextBoxColumn,
            this.bfree5DataGridViewTextBoxColumn});
            this.bS_DepartmentDataGridView.DataSource = this.bS_DepartmentBindingSource;
            this.bS_DepartmentDataGridView.Location = new System.Drawing.Point(365, 102);
            this.bS_DepartmentDataGridView.Name = "bS_DepartmentDataGridView";
            this.bS_DepartmentDataGridView.ReadOnly = true;
            this.bS_DepartmentDataGridView.RowTemplate.Height = 23;
            this.bS_DepartmentDataGridView.ShowEditingIcon = false;
            this.bS_DepartmentDataGridView.Size = new System.Drawing.Size(413, 420);
            this.bS_DepartmentDataGridView.TabIndex = 6;
            this.bS_DepartmentDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.bS_DepartmentDataGridView_RowPostPaint);
            // 
            // autoIdDataGridViewTextBoxColumn
            // 
            this.autoIdDataGridViewTextBoxColumn.DataPropertyName = "AutoId";
            this.autoIdDataGridViewTextBoxColumn.HeaderText = "AutoId";
            this.autoIdDataGridViewTextBoxColumn.Name = "autoIdDataGridViewTextBoxColumn";
            this.autoIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.autoIdDataGridViewTextBoxColumn.Visible = false;
            this.autoIdDataGridViewTextBoxColumn.Width = 66;
            // 
            // departmentNoDataGridViewTextBoxColumn
            // 
            this.departmentNoDataGridViewTextBoxColumn.DataPropertyName = "DepartmentNo";
            this.departmentNoDataGridViewTextBoxColumn.HeaderText = "部门编号";
            this.departmentNoDataGridViewTextBoxColumn.Name = "departmentNoDataGridViewTextBoxColumn";
            this.departmentNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.departmentNoDataGridViewTextBoxColumn.Width = 78;
            // 
            // departmentNameDataGridViewTextBoxColumn
            // 
            this.departmentNameDataGridViewTextBoxColumn.DataPropertyName = "DepartmentName";
            this.departmentNameDataGridViewTextBoxColumn.HeaderText = "部门名称";
            this.departmentNameDataGridViewTextBoxColumn.Name = "departmentNameDataGridViewTextBoxColumn";
            this.departmentNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.departmentNameDataGridViewTextBoxColumn.Width = 78;
            // 
            // parentDepartmentNoDataGridViewTextBoxColumn
            // 
            this.parentDepartmentNoDataGridViewTextBoxColumn.DataPropertyName = "ParentDepartmentNo";
            this.parentDepartmentNoDataGridViewTextBoxColumn.HeaderText = "上级部门编号";
            this.parentDepartmentNoDataGridViewTextBoxColumn.Name = "parentDepartmentNoDataGridViewTextBoxColumn";
            this.parentDepartmentNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.parentDepartmentNoDataGridViewTextBoxColumn.Width = 102;
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            this.createDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.createDateDataGridViewTextBoxColumn.Visible = false;
            this.createDateDataGridViewTextBoxColumn.Width = 90;
            // 
            // founderDataGridViewTextBoxColumn
            // 
            this.founderDataGridViewTextBoxColumn.DataPropertyName = "Founder";
            this.founderDataGridViewTextBoxColumn.HeaderText = "Founder";
            this.founderDataGridViewTextBoxColumn.Name = "founderDataGridViewTextBoxColumn";
            this.founderDataGridViewTextBoxColumn.ReadOnly = true;
            this.founderDataGridViewTextBoxColumn.Visible = false;
            this.founderDataGridViewTextBoxColumn.Width = 72;
            // 
            // bfree1DataGridViewTextBoxColumn
            // 
            this.bfree1DataGridViewTextBoxColumn.DataPropertyName = "Bfree1";
            this.bfree1DataGridViewTextBoxColumn.HeaderText = "Bfree1";
            this.bfree1DataGridViewTextBoxColumn.Name = "bfree1DataGridViewTextBoxColumn";
            this.bfree1DataGridViewTextBoxColumn.ReadOnly = true;
            this.bfree1DataGridViewTextBoxColumn.Visible = false;
            this.bfree1DataGridViewTextBoxColumn.Width = 66;
            // 
            // bfree2DataGridViewTextBoxColumn
            // 
            this.bfree2DataGridViewTextBoxColumn.DataPropertyName = "Bfree2";
            this.bfree2DataGridViewTextBoxColumn.HeaderText = "Bfree2";
            this.bfree2DataGridViewTextBoxColumn.Name = "bfree2DataGridViewTextBoxColumn";
            this.bfree2DataGridViewTextBoxColumn.ReadOnly = true;
            this.bfree2DataGridViewTextBoxColumn.Visible = false;
            this.bfree2DataGridViewTextBoxColumn.Width = 66;
            // 
            // bfree3DataGridViewTextBoxColumn
            // 
            this.bfree3DataGridViewTextBoxColumn.DataPropertyName = "Bfree3";
            this.bfree3DataGridViewTextBoxColumn.HeaderText = "Bfree3";
            this.bfree3DataGridViewTextBoxColumn.Name = "bfree3DataGridViewTextBoxColumn";
            this.bfree3DataGridViewTextBoxColumn.ReadOnly = true;
            this.bfree3DataGridViewTextBoxColumn.Visible = false;
            this.bfree3DataGridViewTextBoxColumn.Width = 66;
            // 
            // bfree4DataGridViewTextBoxColumn
            // 
            this.bfree4DataGridViewTextBoxColumn.DataPropertyName = "Bfree4";
            this.bfree4DataGridViewTextBoxColumn.HeaderText = "Bfree4";
            this.bfree4DataGridViewTextBoxColumn.Name = "bfree4DataGridViewTextBoxColumn";
            this.bfree4DataGridViewTextBoxColumn.ReadOnly = true;
            this.bfree4DataGridViewTextBoxColumn.Visible = false;
            this.bfree4DataGridViewTextBoxColumn.Width = 66;
            // 
            // bfree5DataGridViewTextBoxColumn
            // 
            this.bfree5DataGridViewTextBoxColumn.DataPropertyName = "Bfree5";
            this.bfree5DataGridViewTextBoxColumn.HeaderText = "Bfree5";
            this.bfree5DataGridViewTextBoxColumn.Name = "bfree5DataGridViewTextBoxColumn";
            this.bfree5DataGridViewTextBoxColumn.ReadOnly = true;
            this.bfree5DataGridViewTextBoxColumn.Visible = false;
            this.bfree5DataGridViewTextBoxColumn.Width = 66;
            // 
            // bS_DepartmentBindingSource
            // 
            this.bS_DepartmentBindingSource.DataMember = "BS_Department";
            this.bS_DepartmentBindingSource.DataSource = this.dsPSAP;
            // 
            // dsPSAP
            // 
            this.dsPSAP.DataSetName = "dsPSAP";
            this.dsPSAP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bS_DepartmentTableAdapter
            // 
            this.bS_DepartmentTableAdapter.ClearBeforeFill = true;
            // 
            // tvwOrganizationStru
            // 
            this.tvwOrganizationStru.ContextMenuStrip = this.cmnsOrganizationStruTree;
            this.tvwOrganizationStru.FullRowSelect = true;
            this.tvwOrganizationStru.HotTracking = true;
            this.tvwOrganizationStru.ItemHeight = 20;
            this.tvwOrganizationStru.LabelEdit = true;
            this.tvwOrganizationStru.Location = new System.Drawing.Point(0, 0);
            this.tvwOrganizationStru.Name = "tvwOrganizationStru";
            this.tvwOrganizationStru.ShowNodeToolTips = true;
            this.tvwOrganizationStru.ShowRootLines = false;
            this.tvwOrganizationStru.Size = new System.Drawing.Size(359, 522);
            this.tvwOrganizationStru.TabIndex = 7;
            this.tvwOrganizationStru.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.tvwOrganizationStru_AfterLabelEdit);
            this.tvwOrganizationStru.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwOrganizationStru_AfterSelect);
            this.tvwOrganizationStru.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvwOrganizationStru_NodeMouseClick);
            // 
            // cmnsOrganizationStruTree
            // 
            this.cmnsOrganizationStruTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertTreeNode,
            this.addChildTreeNode,
            this.addRootTreeNode,
            this.toolStripSeparator1,
            this.deleteTreeNode});
            this.cmnsOrganizationStruTree.Name = "contextMenuStrip1";
            this.cmnsOrganizationStruTree.Size = new System.Drawing.Size(149, 98);
            // 
            // insertTreeNode
            // 
            this.insertTreeNode.Name = "insertTreeNode";
            this.insertTreeNode.Size = new System.Drawing.Size(148, 22);
            this.insertTreeNode.Text = "插入同级部门";
            this.insertTreeNode.Click += new System.EventHandler(this.insertTreeNode_Click);
            // 
            // addChildTreeNode
            // 
            this.addChildTreeNode.Name = "addChildTreeNode";
            this.addChildTreeNode.Size = new System.Drawing.Size(148, 22);
            this.addChildTreeNode.Text = "新建子部门";
            this.addChildTreeNode.Click += new System.EventHandler(this.addChildTreeNode_Click);
            // 
            // addRootTreeNode
            // 
            this.addRootTreeNode.Name = "addRootTreeNode";
            this.addRootTreeNode.Size = new System.Drawing.Size(148, 22);
            this.addRootTreeNode.Text = "新建根部门";
            this.addRootTreeNode.Click += new System.EventHandler(this.addRootTreeNode_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // deleteTreeNode
            // 
            this.deleteTreeNode.Name = "deleteTreeNode";
            this.deleteTreeNode.Size = new System.Drawing.Size(148, 22);
            this.deleteTreeNode.Text = "删除部门";
            this.deleteTreeNode.Click += new System.EventHandler(this.deleteTreeNode_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bS_DepartmentBindingNavigator);
            this.panel1.Controls.Add(this.tsControl);
            this.panel1.Location = new System.Drawing.Point(365, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 59);
            this.panel1.TabIndex = 8;
            // 
            // bS_DepartmentBindingNavigator
            // 
            this.bS_DepartmentBindingNavigator.AddNewItem = null;
            this.bS_DepartmentBindingNavigator.BindingSource = this.bS_DepartmentBindingSource;
            this.bS_DepartmentBindingNavigator.CountItem = this.bdnCountItem;
            this.bS_DepartmentBindingNavigator.DeleteItem = null;
            this.bS_DepartmentBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.bS_DepartmentBindingNavigator.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bS_DepartmentBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bS_DepartmentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bdnMoveFirstItem,
            this.bdnMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bdnPositionItem,
            this.bdnCountItem,
            this.bindingNavigatorSeparator1,
            this.bdnMoveNextItem,
            this.bdnMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bS_DepartmentBindingNavigator.Location = new System.Drawing.Point(0, 25);
            this.bS_DepartmentBindingNavigator.MoveFirstItem = this.bdnMoveFirstItem;
            this.bS_DepartmentBindingNavigator.MoveLastItem = this.bdnMoveLastItem;
            this.bS_DepartmentBindingNavigator.MoveNextItem = this.bdnMoveNextItem;
            this.bS_DepartmentBindingNavigator.MovePreviousItem = this.bdnMovePreviousItem;
            this.bS_DepartmentBindingNavigator.Name = "bS_DepartmentBindingNavigator";
            this.bS_DepartmentBindingNavigator.PositionItem = this.bdnPositionItem;
            this.bS_DepartmentBindingNavigator.Size = new System.Drawing.Size(197, 25);
            this.bS_DepartmentBindingNavigator.TabIndex = 3;
            this.bS_DepartmentBindingNavigator.Text = "bindingNavigator1";
            // 
            // bdnCountItem
            // 
            this.bdnCountItem.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.bdnCountItem.Name = "bdnCountItem";
            this.bdnCountItem.Size = new System.Drawing.Size(32, 22);
            this.bdnCountItem.Text = "/ {0}";
            this.bdnCountItem.ToolTipText = "总项数";
            // 
            // bdnMoveFirstItem
            // 
            this.bdnMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bdnMoveFirstItem.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.bdnMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bdnMoveFirstItem.Image")));
            this.bdnMoveFirstItem.Name = "bdnMoveFirstItem";
            this.bdnMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bdnMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bdnMoveFirstItem.Text = "移到第一条记录";
            // 
            // bdnMovePreviousItem
            // 
            this.bdnMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bdnMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bdnMovePreviousItem.Image")));
            this.bdnMovePreviousItem.Name = "bdnMovePreviousItem";
            this.bdnMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bdnMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bdnMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bdnPositionItem
            // 
            this.bdnPositionItem.AccessibleName = "位置";
            this.bdnPositionItem.Name = "bdnPositionItem";
            this.bdnPositionItem.Size = new System.Drawing.Size(50, 25);
            this.bdnPositionItem.Text = "0";
            this.bdnPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bdnMoveNextItem
            // 
            this.bdnMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bdnMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bdnMoveNextItem.Image")));
            this.bdnMoveNextItem.Name = "bdnMoveNextItem";
            this.bdnMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bdnMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bdnMoveNextItem.Text = "移到下一条记录";
            // 
            // bdnMoveLastItem
            // 
            this.bdnMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bdnMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bdnMoveLastItem.Image")));
            this.bdnMoveLastItem.Name = "bdnMoveLastItem";
            this.bdnMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bdnMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bdnMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsControl
            // 
            this.tsControl.Dock = System.Windows.Forms.DockStyle.None;
            this.tsControl.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbEdit,
            this.tsbSave,
            this.tsbCancel,
            this.tsbDGViewExportToCSV,
            this.tsbClose});
            this.tsControl.Location = new System.Drawing.Point(0, 0);
            this.tsControl.Name = "tsControl";
            this.tsControl.Size = new System.Drawing.Size(207, 25);
            this.tsControl.TabIndex = 4;
            this.tsControl.Text = "toolStrip1";
            // 
            // tsbEdit
            // 
            this.tsbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbEdit.Image")));
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(36, 22);
            this.tsbEdit.Text = "编辑";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(36, 22);
            this.tsbSave.Text = "保存";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbCancel
            // 
            this.tsbCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancel.Image")));
            this.tsbCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancel.Name = "tsbCancel";
            this.tsbCancel.Size = new System.Drawing.Size(36, 22);
            this.tsbCancel.Text = "取消";
            this.tsbCancel.Click += new System.EventHandler(this.tsbCancel_Click);
            // 
            // tsbDGViewExportToCSV
            // 
            this.tsbDGViewExportToCSV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbDGViewExportToCSV.Image = ((System.Drawing.Image)(resources.GetObject("tsbDGViewExportToCSV.Image")));
            this.tsbDGViewExportToCSV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDGViewExportToCSV.Name = "tsbDGViewExportToCSV";
            this.tsbDGViewExportToCSV.Size = new System.Drawing.Size(60, 22);
            this.tsbDGViewExportToCSV.Text = "导出数据";
            this.tsbDGViewExportToCSV.Click += new System.EventHandler(this.tsbDGViewExportToCSV_Click);
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(36, 22);
            this.tsbClose.Text = "退出";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // departmentNoTextBox1
            // 
            this.departmentNoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_DepartmentBindingSource, "DepartmentNo", true));
            this.departmentNoTextBox1.Font = new System.Drawing.Font("宋体", 9F);
            this.departmentNoTextBox1.Location = new System.Drawing.Point(481, 75);
            this.departmentNoTextBox1.Name = "departmentNoTextBox1";
            this.departmentNoTextBox1.Size = new System.Drawing.Size(200, 21);
            this.departmentNoTextBox1.TabIndex = 26;
            // 
            // FrmOrganizationStru
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1006, 628);
            this.Controls.Add(departmentNoLabel1);
            this.Controls.Add(this.departmentNoTextBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tvwOrganizationStru);
            this.Controls.Add(this.bS_DepartmentDataGridView);
            this.Font = new System.Drawing.Font("宋体", 9F);
            this.Name = "FrmOrganizationStru";
            this.TabText = "组织结构";
            this.Text = "组织结构";
            this.Load += new System.EventHandler(this.FrmOrganizationStru_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bS_DepartmentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bS_DepartmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPSAP)).EndInit();
            this.cmnsOrganizationStruTree.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bS_DepartmentBindingNavigator)).EndInit();
            this.bS_DepartmentBindingNavigator.ResumeLayout(false);
            this.bS_DepartmentBindingNavigator.PerformLayout();
            this.tsControl.ResumeLayout(false);
            this.tsControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bS_DepartmentDataGridView;
        private dsPSAP dsPSAP;
        private System.Windows.Forms.BindingSource bS_DepartmentBindingSource;
        private dsPSAPTableAdapters.BS_DepartmentTableAdapter bS_DepartmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentDepartmentNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn founderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bfree1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bfree2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bfree3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bfree4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bfree5DataGridViewTextBoxColumn;
        private System.Windows.Forms.TreeView tvwOrganizationStru;
        private System.Windows.Forms.ContextMenuStrip cmnsOrganizationStruTree;
        private System.Windows.Forms.ToolStripMenuItem insertTreeNode;
        private System.Windows.Forms.ToolStripMenuItem addChildTreeNode;
        private System.Windows.Forms.ToolStripMenuItem addRootTreeNode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteTreeNode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingNavigator bS_DepartmentBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bdnCountItem;
        private System.Windows.Forms.ToolStripButton bdnMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bdnMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bdnPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bdnMoveNextItem;
        private System.Windows.Forms.ToolStripButton bdnMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStrip tsControl;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbDGViewExportToCSV;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.TextBox departmentNoTextBox1;
        private System.Windows.Forms.ToolStripButton tsbCancel;
    }
}