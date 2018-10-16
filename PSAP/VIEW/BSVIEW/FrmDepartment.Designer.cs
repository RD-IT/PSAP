namespace PSAP.VIEW.BSVIEW
{
    partial class FrmDepartment
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
            System.Windows.Forms.Label departmentNameLabel1;
            System.Windows.Forms.Label parentDepartmentNoLabel1;
            System.Windows.Forms.Label founderLabel;
            System.Windows.Forms.Label bfree1Label1;
            System.Windows.Forms.Label bfree2Label1;
            System.Windows.Forms.Label bfree3Label1;
            System.Windows.Forms.Label bfree4Label1;
            System.Windows.Forms.Label bfree5Label1;
            System.Windows.Forms.Label createDateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepartment));
            this.tsControl = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            this.tsbQuery = new System.Windows.Forms.ToolStripButton();
            this.tsbDGViewExportToCSV = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.bS_DepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPSAP = new PSAP.dsPSAP();
            this.bS_DepartmentTableAdapter = new PSAP.dsPSAPTableAdapters.BS_DepartmentTableAdapter();
            this.tableAdapterManager = new PSAP.dsPSAPTableAdapters.TableAdapterManager();
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
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.departmentNoTextBox1 = new System.Windows.Forms.TextBox();
            this.departmentNameTextBox1 = new System.Windows.Forms.TextBox();
            this.parentDepartmentNoTextBox1 = new System.Windows.Forms.TextBox();
            this.createDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.founderTextBox = new System.Windows.Forms.TextBox();
            this.bfree1TextBox1 = new System.Windows.Forms.TextBox();
            this.bfree2TextBox1 = new System.Windows.Forms.TextBox();
            this.bfree3TextBox1 = new System.Windows.Forms.TextBox();
            this.bfree4TextBox1 = new System.Windows.Forms.TextBox();
            this.bfree5TextBox1 = new System.Windows.Forms.TextBox();
            this.bS_DepartmentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            departmentNoLabel1 = new System.Windows.Forms.Label();
            departmentNameLabel1 = new System.Windows.Forms.Label();
            parentDepartmentNoLabel1 = new System.Windows.Forms.Label();
            founderLabel = new System.Windows.Forms.Label();
            bfree1Label1 = new System.Windows.Forms.Label();
            bfree2Label1 = new System.Windows.Forms.Label();
            bfree3Label1 = new System.Windows.Forms.Label();
            bfree4Label1 = new System.Windows.Forms.Label();
            bfree5Label1 = new System.Windows.Forms.Label();
            createDateLabel = new System.Windows.Forms.Label();
            this.tsControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bS_DepartmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPSAP)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bS_DepartmentBindingNavigator)).BeginInit();
            this.bS_DepartmentBindingNavigator.SuspendLayout();
            this.pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bS_DepartmentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // departmentNoLabel1
            // 
            departmentNoLabel1.AutoSize = true;
            departmentNoLabel1.Font = new System.Drawing.Font("宋体", 9F);
            departmentNoLabel1.Location = new System.Drawing.Point(13, 18);
            departmentNoLabel1.Name = "departmentNoLabel1";
            departmentNoLabel1.Size = new System.Drawing.Size(53, 12);
            departmentNoLabel1.TabIndex = 23;
            departmentNoLabel1.Text = "部门编号";
            // 
            // departmentNameLabel1
            // 
            departmentNameLabel1.AutoSize = true;
            departmentNameLabel1.Font = new System.Drawing.Font("宋体", 9F);
            departmentNameLabel1.Location = new System.Drawing.Point(13, 45);
            departmentNameLabel1.Name = "departmentNameLabel1";
            departmentNameLabel1.Size = new System.Drawing.Size(53, 12);
            departmentNameLabel1.TabIndex = 25;
            departmentNameLabel1.Text = "部门名称";
            // 
            // parentDepartmentNoLabel1
            // 
            parentDepartmentNoLabel1.AutoSize = true;
            parentDepartmentNoLabel1.Font = new System.Drawing.Font("宋体", 9F);
            parentDepartmentNoLabel1.Location = new System.Drawing.Point(13, 73);
            parentDepartmentNoLabel1.Name = "parentDepartmentNoLabel1";
            parentDepartmentNoLabel1.Size = new System.Drawing.Size(77, 12);
            parentDepartmentNoLabel1.TabIndex = 27;
            parentDepartmentNoLabel1.Text = "上级部门编号";
            // 
            // founderLabel
            // 
            founderLabel.AutoSize = true;
            founderLabel.Enabled = false;
            founderLabel.Font = new System.Drawing.Font("宋体", 9F);
            founderLabel.Location = new System.Drawing.Point(13, 102);
            founderLabel.Name = "founderLabel";
            founderLabel.Size = new System.Drawing.Size(41, 12);
            founderLabel.TabIndex = 31;
            founderLabel.Text = "录入人";
            // 
            // bfree1Label1
            // 
            bfree1Label1.AutoSize = true;
            bfree1Label1.Font = new System.Drawing.Font("宋体", 9F);
            bfree1Label1.Location = new System.Drawing.Point(332, 99);
            bfree1Label1.Name = "bfree1Label1";
            bfree1Label1.Size = new System.Drawing.Size(35, 12);
            bfree1Label1.TabIndex = 33;
            bfree1Label1.Text = "预留1";
            bfree1Label1.Visible = false;
            // 
            // bfree2Label1
            // 
            bfree2Label1.AutoSize = true;
            bfree2Label1.Font = new System.Drawing.Font("宋体", 9F);
            bfree2Label1.Location = new System.Drawing.Point(332, 126);
            bfree2Label1.Name = "bfree2Label1";
            bfree2Label1.Size = new System.Drawing.Size(35, 12);
            bfree2Label1.TabIndex = 35;
            bfree2Label1.Text = "预留2";
            bfree2Label1.Visible = false;
            // 
            // bfree3Label1
            // 
            bfree3Label1.AutoSize = true;
            bfree3Label1.Font = new System.Drawing.Font("宋体", 9F);
            bfree3Label1.Location = new System.Drawing.Point(332, 16);
            bfree3Label1.Name = "bfree3Label1";
            bfree3Label1.Size = new System.Drawing.Size(35, 12);
            bfree3Label1.TabIndex = 37;
            bfree3Label1.Text = "预留3";
            bfree3Label1.Visible = false;
            // 
            // bfree4Label1
            // 
            bfree4Label1.AutoSize = true;
            bfree4Label1.Font = new System.Drawing.Font("宋体", 9F);
            bfree4Label1.Location = new System.Drawing.Point(332, 42);
            bfree4Label1.Name = "bfree4Label1";
            bfree4Label1.Size = new System.Drawing.Size(35, 12);
            bfree4Label1.TabIndex = 39;
            bfree4Label1.Text = "预留4";
            bfree4Label1.Visible = false;
            // 
            // bfree5Label1
            // 
            bfree5Label1.AutoSize = true;
            bfree5Label1.Font = new System.Drawing.Font("宋体", 9F);
            bfree5Label1.Location = new System.Drawing.Point(332, 69);
            bfree5Label1.Name = "bfree5Label1";
            bfree5Label1.Size = new System.Drawing.Size(35, 12);
            bfree5Label1.TabIndex = 41;
            bfree5Label1.Text = "预留5";
            bfree5Label1.Visible = false;
            // 
            // createDateLabel
            // 
            createDateLabel.AutoSize = true;
            createDateLabel.Enabled = false;
            createDateLabel.Font = new System.Drawing.Font("宋体", 9F);
            createDateLabel.Location = new System.Drawing.Point(13, 131);
            createDateLabel.Name = "createDateLabel";
            createDateLabel.Size = new System.Drawing.Size(53, 12);
            createDateLabel.TabIndex = 29;
            createDateLabel.Text = "录入日期";
            // 
            // tsControl
            // 
            this.tsControl.Dock = System.Windows.Forms.DockStyle.None;
            this.tsControl.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbEdit,
            this.tsbDelete,
            this.tsbSave,
            this.tsbCancel,
            this.tsbQuery,
            this.tsbDGViewExportToCSV,
            this.tsbClose});
            this.tsControl.Location = new System.Drawing.Point(0, 0);
            this.tsControl.Name = "tsControl";
            this.tsControl.Size = new System.Drawing.Size(443, 25);
            this.tsControl.TabIndex = 4;
            this.tsControl.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(52, 22);
            this.tsbAdd.Text = "新增";
            this.tsbAdd.Click += new System.EventHandler(this.tsbInsert_Click);
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
            // tsbDelete
            // 
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(52, 22);
            this.tsbDelete.Text = "删除";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BS_DepartmentTableAdapter = this.bS_DepartmentTableAdapter;
            this.tableAdapterManager.BS_MenuTableAdapter = null;
            this.tableAdapterManager.BS_RoleTableAdapter = null;
            this.tableAdapterManager.BS_UserInfoTableAdapter = null;
            this.tableAdapterManager.BS_UserRightTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PSAP.dsPSAPTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bS_DepartmentBindingNavigator);
            this.panel1.Controls.Add(this.tsControl);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 72);
            this.panel1.TabIndex = 3;
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
            this.bS_DepartmentBindingNavigator.Size = new System.Drawing.Size(210, 25);
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
            this.bdnPositionItem.AutoSize = false;
            this.bdnPositionItem.Name = "bdnPositionItem";
            this.bdnPositionItem.Size = new System.Drawing.Size(32, 23);
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
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(departmentNoLabel1);
            this.pnlEdit.Controls.Add(this.departmentNoTextBox1);
            this.pnlEdit.Controls.Add(departmentNameLabel1);
            this.pnlEdit.Controls.Add(this.departmentNameTextBox1);
            this.pnlEdit.Controls.Add(parentDepartmentNoLabel1);
            this.pnlEdit.Controls.Add(this.parentDepartmentNoTextBox1);
            this.pnlEdit.Controls.Add(this.createDateDateTimePicker);
            this.pnlEdit.Controls.Add(founderLabel);
            this.pnlEdit.Controls.Add(this.founderTextBox);
            this.pnlEdit.Controls.Add(bfree1Label1);
            this.pnlEdit.Controls.Add(this.bfree1TextBox1);
            this.pnlEdit.Controls.Add(bfree2Label1);
            this.pnlEdit.Controls.Add(this.bfree2TextBox1);
            this.pnlEdit.Controls.Add(bfree3Label1);
            this.pnlEdit.Controls.Add(this.bfree3TextBox1);
            this.pnlEdit.Controls.Add(bfree4Label1);
            this.pnlEdit.Controls.Add(this.bfree4TextBox1);
            this.pnlEdit.Controls.Add(bfree5Label1);
            this.pnlEdit.Controls.Add(this.bfree5TextBox1);
            this.pnlEdit.Controls.Add(createDateLabel);
            this.pnlEdit.Enabled = false;
            this.pnlEdit.Location = new System.Drawing.Point(0, 90);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(606, 160);
            this.pnlEdit.TabIndex = 2;
            // 
            // departmentNoTextBox1
            // 
            this.departmentNoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_DepartmentBindingSource, "DepartmentNo", true));
            this.departmentNoTextBox1.Font = new System.Drawing.Font("宋体", 9F);
            this.departmentNoTextBox1.Location = new System.Drawing.Point(93, 16);
            this.departmentNoTextBox1.Name = "departmentNoTextBox1";
            this.departmentNoTextBox1.Size = new System.Drawing.Size(200, 21);
            this.departmentNoTextBox1.TabIndex = 24;
            // 
            // departmentNameTextBox1
            // 
            this.departmentNameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_DepartmentBindingSource, "DepartmentName", true));
            this.departmentNameTextBox1.Font = new System.Drawing.Font("宋体", 9F);
            this.departmentNameTextBox1.Location = new System.Drawing.Point(93, 42);
            this.departmentNameTextBox1.Name = "departmentNameTextBox1";
            this.departmentNameTextBox1.Size = new System.Drawing.Size(200, 21);
            this.departmentNameTextBox1.TabIndex = 26;
            // 
            // parentDepartmentNoTextBox1
            // 
            this.parentDepartmentNoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_DepartmentBindingSource, "ParentDepartmentNo", true));
            this.parentDepartmentNoTextBox1.Font = new System.Drawing.Font("宋体", 9F);
            this.parentDepartmentNoTextBox1.Location = new System.Drawing.Point(93, 69);
            this.parentDepartmentNoTextBox1.Name = "parentDepartmentNoTextBox1";
            this.parentDepartmentNoTextBox1.Size = new System.Drawing.Size(200, 21);
            this.parentDepartmentNoTextBox1.TabIndex = 28;
            // 
            // createDateDateTimePicker
            // 
            this.createDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bS_DepartmentBindingSource, "CreateDate", true));
            this.createDateDateTimePicker.Enabled = false;
            this.createDateDateTimePicker.Font = new System.Drawing.Font("宋体", 9F);
            this.createDateDateTimePicker.Location = new System.Drawing.Point(93, 127);
            this.createDateDateTimePicker.Name = "createDateDateTimePicker";
            this.createDateDateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.createDateDateTimePicker.TabIndex = 30;
            this.createDateDateTimePicker.TabStop = false;
            // 
            // founderTextBox
            // 
            this.founderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_DepartmentBindingSource, "Founder", true));
            this.founderTextBox.Enabled = false;
            this.founderTextBox.Font = new System.Drawing.Font("宋体", 9F);
            this.founderTextBox.Location = new System.Drawing.Point(93, 98);
            this.founderTextBox.Name = "founderTextBox";
            this.founderTextBox.Size = new System.Drawing.Size(200, 21);
            this.founderTextBox.TabIndex = 32;
            this.founderTextBox.TabStop = false;
            // 
            // bfree1TextBox1
            // 
            this.bfree1TextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_DepartmentBindingSource, "Bfree1", true));
            this.bfree1TextBox1.Font = new System.Drawing.Font("宋体", 9F);
            this.bfree1TextBox1.Location = new System.Drawing.Point(384, 96);
            this.bfree1TextBox1.Name = "bfree1TextBox1";
            this.bfree1TextBox1.Size = new System.Drawing.Size(200, 21);
            this.bfree1TextBox1.TabIndex = 34;
            this.bfree1TextBox1.Visible = false;
            // 
            // bfree2TextBox1
            // 
            this.bfree2TextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_DepartmentBindingSource, "Bfree2", true));
            this.bfree2TextBox1.Font = new System.Drawing.Font("宋体", 9F);
            this.bfree2TextBox1.Location = new System.Drawing.Point(384, 124);
            this.bfree2TextBox1.Name = "bfree2TextBox1";
            this.bfree2TextBox1.Size = new System.Drawing.Size(200, 21);
            this.bfree2TextBox1.TabIndex = 36;
            this.bfree2TextBox1.Visible = false;
            // 
            // bfree3TextBox1
            // 
            this.bfree3TextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_DepartmentBindingSource, "Bfree3", true));
            this.bfree3TextBox1.Font = new System.Drawing.Font("宋体", 9F);
            this.bfree3TextBox1.Location = new System.Drawing.Point(384, 16);
            this.bfree3TextBox1.Name = "bfree3TextBox1";
            this.bfree3TextBox1.Size = new System.Drawing.Size(200, 21);
            this.bfree3TextBox1.TabIndex = 38;
            this.bfree3TextBox1.Visible = false;
            // 
            // bfree4TextBox1
            // 
            this.bfree4TextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_DepartmentBindingSource, "Bfree4", true));
            this.bfree4TextBox1.Font = new System.Drawing.Font("宋体", 9F);
            this.bfree4TextBox1.Location = new System.Drawing.Point(384, 42);
            this.bfree4TextBox1.Name = "bfree4TextBox1";
            this.bfree4TextBox1.Size = new System.Drawing.Size(200, 21);
            this.bfree4TextBox1.TabIndex = 40;
            this.bfree4TextBox1.Visible = false;
            // 
            // bfree5TextBox1
            // 
            this.bfree5TextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_DepartmentBindingSource, "Bfree5", true));
            this.bfree5TextBox1.Font = new System.Drawing.Font("宋体", 9F);
            this.bfree5TextBox1.Location = new System.Drawing.Point(384, 69);
            this.bfree5TextBox1.Name = "bfree5TextBox1";
            this.bfree5TextBox1.Size = new System.Drawing.Size(200, 21);
            this.bfree5TextBox1.TabIndex = 42;
            this.bfree5TextBox1.Visible = false;
            // 
            // bS_DepartmentDataGridView
            // 
            this.bS_DepartmentDataGridView.AllowUserToAddRows = false;
            this.bS_DepartmentDataGridView.AllowUserToDeleteRows = false;
            this.bS_DepartmentDataGridView.AutoGenerateColumns = false;
            this.bS_DepartmentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.bS_DepartmentDataGridView.ColumnHeadersHeight = 28;
            this.bS_DepartmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.bS_DepartmentDataGridView.DataSource = this.bS_DepartmentBindingSource;
            this.bS_DepartmentDataGridView.Location = new System.Drawing.Point(0, 256);
            this.bS_DepartmentDataGridView.Name = "bS_DepartmentDataGridView";
            this.bS_DepartmentDataGridView.ReadOnly = true;
            this.bS_DepartmentDataGridView.RowTemplate.Height = 23;
            this.bS_DepartmentDataGridView.ShowEditingIcon = false;
            this.bS_DepartmentDataGridView.Size = new System.Drawing.Size(824, 214);
            this.bS_DepartmentDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AutoId";
            this.dataGridViewTextBoxColumn1.HeaderText = "序号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 54;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DepartmentNo";
            this.dataGridViewTextBoxColumn2.HeaderText = "部门编号";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 78;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DepartmentName";
            this.dataGridViewTextBoxColumn3.HeaderText = "部门名称";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 78;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ParentDepartmentNo";
            this.dataGridViewTextBoxColumn4.HeaderText = "上级部门编号";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 102;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CreateDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "录入日期";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 78;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Founder";
            this.dataGridViewTextBoxColumn6.HeaderText = "录入人";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 66;
            // 
            // FrmDepartment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(842, 482);
            this.Controls.Add(this.bS_DepartmentDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlEdit);
            this.Font = new System.Drawing.Font("宋体", 9F);
            this.MinimumSize = new System.Drawing.Size(430, 420);
            this.Name = "FrmDepartment";
            this.TabText = "部门信息";
            this.Text = "部门信息";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDepartment_Load);
            this.tsControl.ResumeLayout(false);
            this.tsControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bS_DepartmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPSAP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bS_DepartmentBindingNavigator)).EndInit();
            this.bS_DepartmentBindingNavigator.ResumeLayout(false);
            this.bS_DepartmentBindingNavigator.PerformLayout();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bS_DepartmentDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private dsPSAP dsPSAP;
        private System.Windows.Forms.BindingSource bS_DepartmentBindingSource;
        private dsPSAPTableAdapters.BS_DepartmentTableAdapter bS_DepartmentTableAdapter;
        private dsPSAPTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip tsControl;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbCancel;
        private System.Windows.Forms.ToolStripButton tsbQuery;
        private System.Windows.Forms.ToolStripButton tsbDGViewExportToCSV;
        private System.Windows.Forms.ToolStripButton tsbClose;
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
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.TextBox departmentNoTextBox1;
        private System.Windows.Forms.TextBox departmentNameTextBox1;
        private System.Windows.Forms.TextBox parentDepartmentNoTextBox1;
        private System.Windows.Forms.DateTimePicker createDateDateTimePicker;
        private System.Windows.Forms.TextBox founderTextBox;
        private System.Windows.Forms.TextBox bfree1TextBox1;
        private System.Windows.Forms.TextBox bfree2TextBox1;
        private System.Windows.Forms.TextBox bfree3TextBox1;
        private System.Windows.Forms.TextBox bfree4TextBox1;
        private System.Windows.Forms.TextBox bfree5TextBox1;
        private System.Windows.Forms.DataGridView bS_DepartmentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}