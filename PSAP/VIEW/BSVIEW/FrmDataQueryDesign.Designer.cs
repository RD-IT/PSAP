namespace PSAP.VIEW.BSVIEW
{
    partial class FrmDataQueryDesign
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
            System.Windows.Forms.Label autoIdLabel;
            System.Windows.Forms.Label parentIdLabel;
            System.Windows.Forms.Label queryTextLabel;
            System.Windows.Forms.Label itemOrderLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDataQueryDesign));
            this.querySqlLabel = new System.Windows.Forms.Label();
            this.remarksLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bS_QuerySqlBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tsbQuery = new System.Windows.Forms.ToolStripButton();
            this.tsbDGViewExportToCSV = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.dgveQueryItemList = new PsapUserControlLibrary.DataGridViewEx();
            this.autoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queryTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.querySqlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reamrksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bS_QuerySqlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPSAP = new PSAP.dsPSAP();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.parentIdTextBox = new System.Windows.Forms.TextBox();
            this.queryTextTextBox = new System.Windows.Forms.TextBox();
            this.autoIdTextBox = new System.Windows.Forms.TextBox();
            this.reamrksTextBox = new System.Windows.Forms.TextBox();
            this.itemOrderTextBox = new System.Windows.Forms.TextBox();
            this.querySqlTextBox = new System.Windows.Forms.TextBox();
            this.dgveParaList = new PsapUserControlLibrary.DataGridViewEx();
            this.autoIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.querySqlIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parametersTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parametersNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parametersCatgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bS_QuerySqlParameterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tvtbQueryList = new PsapUserControlLibrary.TreeViewToolBoxEx();
            this.cmnsQueryItemTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.insertTreeNode = new System.Windows.Forms.ToolStripMenuItem();
            this.addChildTreeNode = new System.Windows.Forms.ToolStripMenuItem();
            this.addRootTreeNode = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteTreeNode = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.bS_QuerySqlTableAdapter = new PSAP.dsPSAPTableAdapters.BS_QuerySqlTableAdapter();
            this.tableAdapterManager = new PSAP.dsPSAPTableAdapters.TableAdapterManager();
            this.bS_QuerySqlParameterTableAdapter = new PSAP.dsPSAPTableAdapters.BS_QuerySqlParameterTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tvtbQueryList_User = new PsapUserControlLibrary.TreeViewToolBoxEx();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlQueryCondition = new System.Windows.Forms.Panel();
            this.tableLayoutpnlQueryCondition = new System.Windows.Forms.TableLayoutPanel();
            this.btnQuery = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cmnsColumnHeader = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.insertColumnHeader = new System.Windows.Forms.ToolStripMenuItem();
            this.insertChildColumnHeader = new System.Windows.Forms.ToolStripMenuItem();
            this.createRootColumnHeader = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteColumnHeader = new System.Windows.Forms.ToolStripMenuItem();
            autoIdLabel = new System.Windows.Forms.Label();
            parentIdLabel = new System.Windows.Forms.Label();
            queryTextLabel = new System.Windows.Forms.Label();
            itemOrderLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bS_QuerySqlBindingNavigator)).BeginInit();
            this.bS_QuerySqlBindingNavigator.SuspendLayout();
            this.tsControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgveQueryItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bS_QuerySqlBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPSAP)).BeginInit();
            this.pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgveParaList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bS_QuerySqlParameterBindingSource)).BeginInit();
            this.cmnsQueryItemTree.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlQueryCondition.SuspendLayout();
            this.tableLayoutpnlQueryCondition.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.cmnsColumnHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // autoIdLabel
            // 
            autoIdLabel.AutoSize = true;
            autoIdLabel.Location = new System.Drawing.Point(455, 49);
            autoIdLabel.Name = "autoIdLabel";
            autoIdLabel.Size = new System.Drawing.Size(53, 12);
            autoIdLabel.TabIndex = 2;
            autoIdLabel.Text = "Auto Id:";
            autoIdLabel.Visible = false;
            // 
            // parentIdLabel
            // 
            parentIdLabel.AutoSize = true;
            parentIdLabel.Location = new System.Drawing.Point(455, 5);
            parentIdLabel.Name = "parentIdLabel";
            parentIdLabel.Size = new System.Drawing.Size(65, 12);
            parentIdLabel.TabIndex = 4;
            parentIdLabel.Text = "Parent Id:";
            parentIdLabel.Visible = false;
            // 
            // queryTextLabel
            // 
            queryTextLabel.AutoSize = true;
            queryTextLabel.Location = new System.Drawing.Point(437, 30);
            queryTextLabel.Name = "queryTextLabel";
            queryTextLabel.Size = new System.Drawing.Size(71, 12);
            queryTextLabel.TabIndex = 6;
            queryTextLabel.Text = "Query Text:";
            queryTextLabel.Visible = false;
            // 
            // itemOrderLabel
            // 
            itemOrderLabel.AutoSize = true;
            itemOrderLabel.Location = new System.Drawing.Point(4, 6);
            itemOrderLabel.Name = "itemOrderLabel";
            itemOrderLabel.Size = new System.Drawing.Size(53, 12);
            itemOrderLabel.TabIndex = 10;
            itemOrderLabel.Text = "显示顺序";
            // 
            // querySqlLabel
            // 
            this.querySqlLabel.Location = new System.Drawing.Point(1, 91);
            this.querySqlLabel.Name = "querySqlLabel";
            this.querySqlLabel.Size = new System.Drawing.Size(19, 101);
            this.querySqlLabel.TabIndex = 8;
            this.querySqlLabel.Text = "S Q L查询语句";
            this.querySqlLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // remarksLabel
            // 
            this.remarksLabel.Location = new System.Drawing.Point(1, 30);
            this.remarksLabel.Name = "remarksLabel";
            this.remarksLabel.Size = new System.Drawing.Size(19, 56);
            this.remarksLabel.TabIndex = 12;
            this.remarksLabel.Text = "报表说明";
            this.remarksLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 560F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgveParaList, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tvtbQueryList, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(859, 547);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgveQueryItemList);
            this.panel1.Controls.Add(this.pnlEdit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(181, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 482);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bS_QuerySqlBindingNavigator);
            this.panel2.Controls.Add(this.tsControl);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(544, 53);
            this.panel2.TabIndex = 14;
            // 
            // bS_QuerySqlBindingNavigator
            // 
            this.bS_QuerySqlBindingNavigator.AddNewItem = null;
            this.bS_QuerySqlBindingNavigator.CountItem = this.bdnCountItem;
            this.bS_QuerySqlBindingNavigator.DeleteItem = null;
            this.bS_QuerySqlBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.bS_QuerySqlBindingNavigator.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bS_QuerySqlBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bS_QuerySqlBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bdnMoveFirstItem,
            this.bdnMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bdnPositionItem,
            this.bdnCountItem,
            this.bindingNavigatorSeparator1,
            this.bdnMoveNextItem,
            this.bdnMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bS_QuerySqlBindingNavigator.Location = new System.Drawing.Point(0, 25);
            this.bS_QuerySqlBindingNavigator.MoveFirstItem = this.bdnMoveFirstItem;
            this.bS_QuerySqlBindingNavigator.MoveLastItem = this.bdnMoveLastItem;
            this.bS_QuerySqlBindingNavigator.MoveNextItem = this.bdnMoveNextItem;
            this.bS_QuerySqlBindingNavigator.MovePreviousItem = this.bdnMovePreviousItem;
            this.bS_QuerySqlBindingNavigator.Name = "bS_QuerySqlBindingNavigator";
            this.bS_QuerySqlBindingNavigator.PositionItem = this.bdnPositionItem;
            this.bS_QuerySqlBindingNavigator.Size = new System.Drawing.Size(197, 25);
            this.bS_QuerySqlBindingNavigator.TabIndex = 3;
            this.bS_QuerySqlBindingNavigator.Text = "bindingNavigator1";
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
            this.bdnPositionItem.AutoSize = false;
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
            this.tsbQuery,
            this.tsbDGViewExportToCSV,
            this.tsbClose});
            this.tsControl.Location = new System.Drawing.Point(0, 0);
            this.tsControl.Name = "tsControl";
            this.tsControl.Size = new System.Drawing.Size(339, 25);
            this.tsControl.TabIndex = 4;
            this.tsControl.Text = "toolStrip1";
            // 
            // tsbEdit
            // 
            this.tsbEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbEdit.Image")));
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(52, 22);
            this.tsbEdit.Text = "编辑";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(52, 22);
            this.tsbSave.Text = "保存";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbCancel
            // 
            this.tsbCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancel.Image")));
            this.tsbCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancel.Name = "tsbCancel";
            this.tsbCancel.Size = new System.Drawing.Size(52, 22);
            this.tsbCancel.Text = "取消";
            this.tsbCancel.Click += new System.EventHandler(this.tsbCancel_Click);
            // 
            // tsbQuery
            // 
            this.tsbQuery.Image = ((System.Drawing.Image)(resources.GetObject("tsbQuery.Image")));
            this.tsbQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQuery.Name = "tsbQuery";
            this.tsbQuery.Size = new System.Drawing.Size(52, 22);
            this.tsbQuery.Text = "查询";
            // 
            // tsbDGViewExportToCSV
            // 
            this.tsbDGViewExportToCSV.Image = ((System.Drawing.Image)(resources.GetObject("tsbDGViewExportToCSV.Image")));
            this.tsbDGViewExportToCSV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDGViewExportToCSV.Name = "tsbDGViewExportToCSV";
            this.tsbDGViewExportToCSV.Size = new System.Drawing.Size(76, 22);
            this.tsbDGViewExportToCSV.Text = "导出数据";
            this.tsbDGViewExportToCSV.Click += new System.EventHandler(this.tsbDGViewExportToCSV_Click);
            // 
            // tsbClose
            // 
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(52, 22);
            this.tsbClose.Text = "退出";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // dgveQueryItemList
            // 
            this.dgveQueryItemList.AutoGenerateColumns = false;
            this.dgveQueryItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgveQueryItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.autoIdDataGridViewTextBoxColumn,
            this.parentIdDataGridViewTextBoxColumn,
            this.queryTextDataGridViewTextBoxColumn,
            this.querySqlDataGridViewTextBoxColumn,
            this.itemOrderDataGridViewTextBoxColumn,
            this.reamrksDataGridViewTextBoxColumn});
            this.dgveQueryItemList.DataSource = this.bS_QuerySqlBindingSource;
            this.dgveQueryItemList.Location = new System.Drawing.Point(0, 260);
            this.dgveQueryItemList.myColHeaderTreeView = null;
            this.dgveQueryItemList.Name = "dgveQueryItemList";
            this.dgveQueryItemList.RowTemplate.Height = 23;
            this.dgveQueryItemList.Size = new System.Drawing.Size(554, 215);
            this.dgveQueryItemList.TabIndex = 1;
            this.dgveQueryItemList.CurrentCellChanged += new System.EventHandler(this.dgveQueryItemList_CurrentCellChanged);
            this.dgveQueryItemList.SelectionChanged += new System.EventHandler(this.dgveQueryItemList_SelectionChanged);
            // 
            // autoIdDataGridViewTextBoxColumn
            // 
            this.autoIdDataGridViewTextBoxColumn.DataPropertyName = "AutoId";
            this.autoIdDataGridViewTextBoxColumn.HeaderText = "AutoId";
            this.autoIdDataGridViewTextBoxColumn.Name = "autoIdDataGridViewTextBoxColumn";
            this.autoIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.autoIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // parentIdDataGridViewTextBoxColumn
            // 
            this.parentIdDataGridViewTextBoxColumn.DataPropertyName = "ParentId";
            this.parentIdDataGridViewTextBoxColumn.HeaderText = "ParentId";
            this.parentIdDataGridViewTextBoxColumn.Name = "parentIdDataGridViewTextBoxColumn";
            this.parentIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // queryTextDataGridViewTextBoxColumn
            // 
            this.queryTextDataGridViewTextBoxColumn.DataPropertyName = "QueryText";
            this.queryTextDataGridViewTextBoxColumn.HeaderText = "项目名称";
            this.queryTextDataGridViewTextBoxColumn.Name = "queryTextDataGridViewTextBoxColumn";
            // 
            // querySqlDataGridViewTextBoxColumn
            // 
            this.querySqlDataGridViewTextBoxColumn.DataPropertyName = "QuerySql";
            this.querySqlDataGridViewTextBoxColumn.HeaderText = "Sql查询语句";
            this.querySqlDataGridViewTextBoxColumn.Name = "querySqlDataGridViewTextBoxColumn";
            // 
            // itemOrderDataGridViewTextBoxColumn
            // 
            this.itemOrderDataGridViewTextBoxColumn.DataPropertyName = "ItemOrder";
            this.itemOrderDataGridViewTextBoxColumn.HeaderText = "显示顺序";
            this.itemOrderDataGridViewTextBoxColumn.Name = "itemOrderDataGridViewTextBoxColumn";
            // 
            // reamrksDataGridViewTextBoxColumn
            // 
            this.reamrksDataGridViewTextBoxColumn.DataPropertyName = "Reamrks";
            this.reamrksDataGridViewTextBoxColumn.HeaderText = "说明";
            this.reamrksDataGridViewTextBoxColumn.Name = "reamrksDataGridViewTextBoxColumn";
            // 
            // bS_QuerySqlBindingSource
            // 
            this.bS_QuerySqlBindingSource.DataMember = "BS_QuerySql";
            this.bS_QuerySqlBindingSource.DataSource = this.dsPSAP;
            // 
            // dsPSAP
            // 
            this.dsPSAP.DataSetName = "dsPSAP";
            this.dsPSAP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(queryTextLabel);
            this.pnlEdit.Controls.Add(this.parentIdTextBox);
            this.pnlEdit.Controls.Add(this.queryTextTextBox);
            this.pnlEdit.Controls.Add(this.autoIdTextBox);
            this.pnlEdit.Controls.Add(autoIdLabel);
            this.pnlEdit.Controls.Add(parentIdLabel);
            this.pnlEdit.Controls.Add(this.reamrksTextBox);
            this.pnlEdit.Controls.Add(this.remarksLabel);
            this.pnlEdit.Controls.Add(this.itemOrderTextBox);
            this.pnlEdit.Controls.Add(itemOrderLabel);
            this.pnlEdit.Controls.Add(this.querySqlTextBox);
            this.pnlEdit.Controls.Add(this.querySqlLabel);
            this.pnlEdit.Enabled = false;
            this.pnlEdit.Location = new System.Drawing.Point(0, 62);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(554, 202);
            this.pnlEdit.TabIndex = 15;
            // 
            // parentIdTextBox
            // 
            this.parentIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_QuerySqlBindingSource, "ParentId", true));
            this.parentIdTextBox.Location = new System.Drawing.Point(508, 2);
            this.parentIdTextBox.Name = "parentIdTextBox";
            this.parentIdTextBox.Size = new System.Drawing.Size(28, 21);
            this.parentIdTextBox.TabIndex = 5;
            this.parentIdTextBox.Visible = false;
            // 
            // queryTextTextBox
            // 
            this.queryTextTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_QuerySqlBindingSource, "QueryText", true));
            this.queryTextTextBox.Location = new System.Drawing.Point(508, 21);
            this.queryTextTextBox.Name = "queryTextTextBox";
            this.queryTextTextBox.Size = new System.Drawing.Size(28, 21);
            this.queryTextTextBox.TabIndex = 7;
            this.queryTextTextBox.Visible = false;
            // 
            // autoIdTextBox
            // 
            this.autoIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_QuerySqlBindingSource, "AutoId", true));
            this.autoIdTextBox.Location = new System.Drawing.Point(508, 40);
            this.autoIdTextBox.Name = "autoIdTextBox";
            this.autoIdTextBox.Size = new System.Drawing.Size(28, 21);
            this.autoIdTextBox.TabIndex = 3;
            this.autoIdTextBox.Visible = false;
            // 
            // reamrksTextBox
            // 
            this.reamrksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_QuerySqlBindingSource, "Reamrks", true));
            this.reamrksTextBox.Location = new System.Drawing.Point(19, 30);
            this.reamrksTextBox.MaxLength = 500;
            this.reamrksTextBox.Multiline = true;
            this.reamrksTextBox.Name = "reamrksTextBox";
            this.reamrksTextBox.Size = new System.Drawing.Size(535, 53);
            this.reamrksTextBox.TabIndex = 12;
            this.reamrksTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.reamrksTextBox_KeyPress);
            // 
            // itemOrderTextBox
            // 
            this.itemOrderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_QuerySqlBindingSource, "ItemOrder", true));
            this.itemOrderTextBox.Location = new System.Drawing.Point(60, 2);
            this.itemOrderTextBox.Name = "itemOrderTextBox";
            this.itemOrderTextBox.Size = new System.Drawing.Size(73, 21);
            this.itemOrderTextBox.TabIndex = 11;
            this.itemOrderTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.itemOrderTextBox_KeyPress);
            // 
            // querySqlTextBox
            // 
            this.querySqlTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_QuerySqlBindingSource, "QuerySql", true));
            this.querySqlTextBox.Location = new System.Drawing.Point(19, 89);
            this.querySqlTextBox.Multiline = true;
            this.querySqlTextBox.Name = "querySqlTextBox";
            this.querySqlTextBox.Size = new System.Drawing.Size(535, 103);
            this.querySqlTextBox.TabIndex = 13;
            this.querySqlTextBox.Leave += new System.EventHandler(this.querySqlTextBox_Leave);
            // 
            // dgveParaList
            // 
            this.dgveParaList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgveParaList.AutoGenerateColumns = false;
            this.dgveParaList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgveParaList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.autoIdDataGridViewTextBoxColumn1,
            this.querySqlIdDataGridViewTextBoxColumn,
            this.parametersTextDataGridViewTextBoxColumn,
            this.parametersNameDataGridViewTextBoxColumn,
            this.parametersCatgDataGridViewTextBoxColumn});
            this.dgveParaList.DataSource = this.bS_QuerySqlParameterBindingSource;
            this.dgveParaList.Location = new System.Drawing.Point(741, 3);
            this.dgveParaList.myColHeaderTreeView = null;
            this.dgveParaList.Name = "dgveParaList";
            this.dgveParaList.RowHeadersVisible = false;
            this.dgveParaList.RowTemplate.Height = 23;
            this.dgveParaList.Size = new System.Drawing.Size(115, 475);
            this.dgveParaList.TabIndex = 2;
            this.dgveParaList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgveParaList_CellEndEdit);
            // 
            // autoIdDataGridViewTextBoxColumn1
            // 
            this.autoIdDataGridViewTextBoxColumn1.DataPropertyName = "AutoId";
            this.autoIdDataGridViewTextBoxColumn1.HeaderText = "AutoId";
            this.autoIdDataGridViewTextBoxColumn1.Name = "autoIdDataGridViewTextBoxColumn1";
            this.autoIdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.autoIdDataGridViewTextBoxColumn1.Visible = false;
            // 
            // querySqlIdDataGridViewTextBoxColumn
            // 
            this.querySqlIdDataGridViewTextBoxColumn.DataPropertyName = "QuerySqlId";
            this.querySqlIdDataGridViewTextBoxColumn.HeaderText = "QuerySqlId";
            this.querySqlIdDataGridViewTextBoxColumn.Name = "querySqlIdDataGridViewTextBoxColumn";
            this.querySqlIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // parametersTextDataGridViewTextBoxColumn
            // 
            this.parametersTextDataGridViewTextBoxColumn.DataPropertyName = "ParametersText";
            this.parametersTextDataGridViewTextBoxColumn.HeaderText = "参数标题";
            this.parametersTextDataGridViewTextBoxColumn.Name = "parametersTextDataGridViewTextBoxColumn";
            // 
            // parametersNameDataGridViewTextBoxColumn
            // 
            this.parametersNameDataGridViewTextBoxColumn.DataPropertyName = "ParametersName";
            this.parametersNameDataGridViewTextBoxColumn.HeaderText = "参数名";
            this.parametersNameDataGridViewTextBoxColumn.Name = "parametersNameDataGridViewTextBoxColumn";
            this.parametersNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // parametersCatgDataGridViewTextBoxColumn
            // 
            this.parametersCatgDataGridViewTextBoxColumn.DataPropertyName = "ParametersCatg";
            this.parametersCatgDataGridViewTextBoxColumn.HeaderText = "参数类型";
            this.parametersCatgDataGridViewTextBoxColumn.Name = "parametersCatgDataGridViewTextBoxColumn";
            this.parametersCatgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bS_QuerySqlParameterBindingSource
            // 
            this.bS_QuerySqlParameterBindingSource.DataMember = "FK__BS_QueryS__Query__53C2623D";
            this.bS_QuerySqlParameterBindingSource.DataSource = this.bS_QuerySqlBindingSource;
            // 
            // tvtbQueryList
            // 
            this.tvtbQueryList.BoundColoseImageName = null;
            this.tvtbQueryList.BoundOpenImageName = null;
            this.tvtbQueryList.ContextMenuStrip = this.cmnsQueryItemTree;
            this.tvtbQueryList.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.tvtbQueryList.FullRowSelect = true;
            this.tvtbQueryList.HideSelection = false;
            this.tvtbQueryList.HotTracking = true;
            this.tvtbQueryList.ItemHeight = 20;
            this.tvtbQueryList.LabelEdit = true;
            this.tvtbQueryList.Location = new System.Drawing.Point(3, 3);
            this.tvtbQueryList.Name = "tvtbQueryList";
            this.tvtbQueryList.ShowLines = false;
            this.tvtbQueryList.ShowPlusMinus = false;
            this.tvtbQueryList.ShowRootLines = false;
            this.tvtbQueryList.Size = new System.Drawing.Size(172, 475);
            this.tvtbQueryList.TabIndex = 1;
            this.tvtbQueryList.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.tvtbQueryList_AfterLabelEdit);
            this.tvtbQueryList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvtbQueryList_AfterSelect);
            this.tvtbQueryList.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvtbQueryList_NodeMouseClick);
            // 
            // cmnsQueryItemTree
            // 
            this.cmnsQueryItemTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertTreeNode,
            this.addChildTreeNode,
            this.addRootTreeNode,
            this.toolStripSeparator1,
            this.deleteTreeNode});
            this.cmnsQueryItemTree.Name = "contextMenuStrip1";
            this.cmnsQueryItemTree.Size = new System.Drawing.Size(137, 98);
            this.cmnsQueryItemTree.Opening += new System.ComponentModel.CancelEventHandler(this.cmnsQueryItemTree_Opening);
            // 
            // insertTreeNode
            // 
            this.insertTreeNode.Name = "insertTreeNode";
            this.insertTreeNode.Size = new System.Drawing.Size(136, 22);
            this.insertTreeNode.Text = "插入查询";
            this.insertTreeNode.Click += new System.EventHandler(this.insertTreeNode_Click);
            // 
            // addChildTreeNode
            // 
            this.addChildTreeNode.Name = "addChildTreeNode";
            this.addChildTreeNode.Size = new System.Drawing.Size(136, 22);
            this.addChildTreeNode.Text = "新建查询";
            this.addChildTreeNode.Click += new System.EventHandler(this.addChildTreeNode_Click);
            // 
            // addRootTreeNode
            // 
            this.addRootTreeNode.Name = "addRootTreeNode";
            this.addRootTreeNode.Size = new System.Drawing.Size(136, 22);
            this.addRootTreeNode.Text = "新建文件夹";
            this.addRootTreeNode.Click += new System.EventHandler(this.addRootTreeNode_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(133, 6);
            // 
            // deleteTreeNode
            // 
            this.deleteTreeNode.Name = "deleteTreeNode";
            this.deleteTreeNode.Size = new System.Drawing.Size(136, 22);
            this.deleteTreeNode.Text = "删除当前项";
            this.deleteTreeNode.Click += new System.EventHandler(this.deleteTreeNode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(741, 488);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "注：【参数文本】列可直接修改";
            // 
            // bS_QuerySqlTableAdapter
            // 
            this.bS_QuerySqlTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BS_DepartmentTableAdapter = null;
            this.tableAdapterManager.BS_MenuTableAdapter = null;
            this.tableAdapterManager.BS_QuerySqlParameterTableAdapter = this.bS_QuerySqlParameterTableAdapter;
            this.tableAdapterManager.BS_QuerySqlTableAdapter = this.bS_QuerySqlTableAdapter;
            this.tableAdapterManager.BS_RoleTableAdapter = null;
            this.tableAdapterManager.BS_UnitCatgTableAdapter = null;
            this.tableAdapterManager.BS_UserInfoTableAdapter = null;
            this.tableAdapterManager.BS_UserRightTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PSAP.dsPSAPTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bS_QuerySqlParameterTableAdapter
            // 
            this.bS_QuerySqlParameterTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(859, 547);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(851, 521);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "数据查询设计";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(851, 521);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "客户端设计";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 181F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tvtbQueryList_User, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tabControl2, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(842, 482);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tvtbQueryList_User
            // 
            this.tvtbQueryList_User.BoundColoseImageName = null;
            this.tvtbQueryList_User.BoundOpenImageName = null;
            this.tvtbQueryList_User.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.tvtbQueryList_User.FullRowSelect = true;
            this.tvtbQueryList_User.HideSelection = false;
            this.tvtbQueryList_User.HotTracking = true;
            this.tvtbQueryList_User.ItemHeight = 20;
            this.tvtbQueryList_User.LabelEdit = true;
            this.tvtbQueryList_User.Location = new System.Drawing.Point(3, 3);
            this.tvtbQueryList_User.Name = "tvtbQueryList_User";
            this.tvtbQueryList_User.ShowLines = false;
            this.tvtbQueryList_User.ShowPlusMinus = false;
            this.tvtbQueryList_User.ShowRootLines = false;
            this.tvtbQueryList_User.Size = new System.Drawing.Size(148, 475);
            this.tvtbQueryList_User.TabIndex = 2;
            this.tvtbQueryList_User.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvtbQueryList_User_AfterSelect);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.pnlQueryCondition);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(157, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(175, 476);
            this.panel3.TabIndex = 0;
            // 
            // pnlQueryCondition
            // 
            this.pnlQueryCondition.AutoSize = true;
            this.pnlQueryCondition.Controls.Add(this.tableLayoutpnlQueryCondition);
            this.pnlQueryCondition.Location = new System.Drawing.Point(3, 0);
            this.pnlQueryCondition.Name = "pnlQueryCondition";
            this.pnlQueryCondition.Size = new System.Drawing.Size(171, 42);
            this.pnlQueryCondition.TabIndex = 5;
            // 
            // tableLayoutpnlQueryCondition
            // 
            this.tableLayoutpnlQueryCondition.ColumnCount = 2;
            this.tableLayoutpnlQueryCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutpnlQueryCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutpnlQueryCondition.Controls.Add(this.btnQuery, 1, 0);
            this.tableLayoutpnlQueryCondition.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutpnlQueryCondition.Location = new System.Drawing.Point(0, 14);
            this.tableLayoutpnlQueryCondition.Name = "tableLayoutpnlQueryCondition";
            this.tableLayoutpnlQueryCondition.RowCount = 1;
            this.tableLayoutpnlQueryCondition.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutpnlQueryCondition.Size = new System.Drawing.Size(171, 28);
            this.tableLayoutpnlQueryCondition.TabIndex = 4;
            this.tableLayoutpnlQueryCondition.Visible = false;
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.Location = new System.Drawing.Point(88, 3);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(3, 3, 16, 3);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(67, 23);
            this.btnQuery.TabIndex = 0;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(338, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(501, 476);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(493, 450);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "查询结果";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cmnsColumnHeader
            // 
            this.cmnsColumnHeader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertColumnHeader,
            this.insertChildColumnHeader,
            this.createRootColumnHeader,
            this.toolStripSeparator2,
            this.deleteColumnHeader});
            this.cmnsColumnHeader.Name = "contextMenuStrip1";
            this.cmnsColumnHeader.Size = new System.Drawing.Size(153, 120);
            // 
            // insertColumnHeader
            // 
            this.insertColumnHeader.Name = "insertColumnHeader";
            this.insertColumnHeader.Size = new System.Drawing.Size(152, 22);
            this.insertColumnHeader.Text = "插入列标题";
            this.insertColumnHeader.Click += new System.EventHandler(this.insertColumnHeader_Click);
            // 
            // insertChildColumnHeader
            // 
            this.insertChildColumnHeader.Name = "insertChildColumnHeader";
            this.insertChildColumnHeader.Size = new System.Drawing.Size(152, 22);
            this.insertChildColumnHeader.Text = "新建子列标题";
            this.insertChildColumnHeader.Click += new System.EventHandler(this.insertChildColumnHeader_Click);
            // 
            // createRootColumnHeader
            // 
            this.createRootColumnHeader.Name = "createRootColumnHeader";
            this.createRootColumnHeader.Size = new System.Drawing.Size(152, 22);
            this.createRootColumnHeader.Text = "新建根列标题";
            this.createRootColumnHeader.Click += new System.EventHandler(this.createRootColumnHeader_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // deleteColumnHeader
            // 
            this.deleteColumnHeader.Name = "deleteColumnHeader";
            this.deleteColumnHeader.Size = new System.Drawing.Size(152, 22);
            this.deleteColumnHeader.Text = "删除列标题";
            this.deleteColumnHeader.Click += new System.EventHandler(this.deleteRootColumnHeader_Click);
            // 
            // FrmDataQueryDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 547);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("宋体", 9F);
            this.Name = "FrmDataQueryDesign";
            this.TabText = "数据查询设计";
            this.Text = "数据查询设计";
            this.Load += new System.EventHandler(this.FrmDataQueryDesign_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bS_QuerySqlBindingNavigator)).EndInit();
            this.bS_QuerySqlBindingNavigator.ResumeLayout(false);
            this.bS_QuerySqlBindingNavigator.PerformLayout();
            this.tsControl.ResumeLayout(false);
            this.tsControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgveQueryItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bS_QuerySqlBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPSAP)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgveParaList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bS_QuerySqlParameterBindingSource)).EndInit();
            this.cmnsQueryItemTree.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlQueryCondition.ResumeLayout(false);
            this.tableLayoutpnlQueryCondition.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.cmnsColumnHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private PsapUserControlLibrary.TreeViewToolBoxEx tvtbQueryList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip cmnsQueryItemTree;
        private System.Windows.Forms.ToolStripMenuItem insertTreeNode;
        private System.Windows.Forms.ToolStripMenuItem addChildTreeNode;
        private System.Windows.Forms.ToolStripMenuItem addRootTreeNode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteTreeNode;
        private dsPSAP dsPSAP;
        private System.Windows.Forms.BindingSource bS_QuerySqlBindingSource;
        private dsPSAPTableAdapters.BS_QuerySqlTableAdapter bS_QuerySqlTableAdapter;
        private dsPSAPTableAdapters.TableAdapterManager tableAdapterManager;
        private PsapUserControlLibrary.DataGridViewEx dgveQueryItemList;
        private System.Windows.Forms.TextBox autoIdTextBox;
        private System.Windows.Forms.TextBox parentIdTextBox;
        private System.Windows.Forms.TextBox queryTextTextBox;
        private System.Windows.Forms.TextBox querySqlTextBox;
        private System.Windows.Forms.TextBox itemOrderTextBox;
        private System.Windows.Forms.TextBox reamrksTextBox;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingNavigator bS_QuerySqlBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbCancel;
        private System.Windows.Forms.ToolStripButton tsbQuery;
        private System.Windows.Forms.ToolStripButton tsbDGViewExportToCSV;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private PsapUserControlLibrary.DataGridViewEx dgveParaList;
        private dsPSAPTableAdapters.BS_QuerySqlParameterTableAdapter bS_QuerySqlParameterTableAdapter;
        private System.Windows.Forms.BindingSource bS_QuerySqlParameterBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn queryTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn querySqlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reamrksDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label querySqlLabel;
        private System.Windows.Forms.Label remarksLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn querySqlIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parametersTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parametersNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parametersCatgDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlQueryCondition;
        private System.Windows.Forms.TableLayoutPanel tableLayoutpnlQueryCondition;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private PsapUserControlLibrary.TreeViewToolBoxEx tvtbQueryList_User;
        private System.Windows.Forms.ContextMenuStrip cmnsColumnHeader;
        private System.Windows.Forms.ToolStripMenuItem insertColumnHeader;
        private System.Windows.Forms.ToolStripMenuItem insertChildColumnHeader;
        private System.Windows.Forms.ToolStripMenuItem createRootColumnHeader;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem deleteColumnHeader;
    }
}