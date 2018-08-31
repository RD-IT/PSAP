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
            System.Windows.Forms.Label createDateLabel;
            System.Windows.Forms.Label founderLabel;
            System.Windows.Forms.Label bfree1Label1;
            System.Windows.Forms.Label bfree2Label1;
            System.Windows.Forms.Label bfree3Label1;
            System.Windows.Forms.Label bfree4Label1;
            System.Windows.Forms.Label bfree5Label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepartment));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.departmentNoTextBox1 = new System.Windows.Forms.TextBox();
            this.bS_DepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPSAP = new PSAP.dsPSAP();
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
            this.bS_DepartmentTableAdapter = new PSAP.dsPSAPTableAdapters.BS_DepartmentTableAdapter();
            this.tableAdapterManager = new PSAP.dsPSAPTableAdapters.TableAdapterManager();
            this.bS_DepartmentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bS_DepartmentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            departmentNoLabel1 = new System.Windows.Forms.Label();
            departmentNameLabel1 = new System.Windows.Forms.Label();
            parentDepartmentNoLabel1 = new System.Windows.Forms.Label();
            createDateLabel = new System.Windows.Forms.Label();
            founderLabel = new System.Windows.Forms.Label();
            bfree1Label1 = new System.Windows.Forms.Label();
            bfree2Label1 = new System.Windows.Forms.Label();
            bfree3Label1 = new System.Windows.Forms.Label();
            bfree4Label1 = new System.Windows.Forms.Label();
            bfree5Label1 = new System.Windows.Forms.Label();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bS_DepartmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPSAP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bS_DepartmentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bS_DepartmentBindingNavigator)).BeginInit();
            this.bS_DepartmentBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // departmentNoLabel1
            // 
            departmentNoLabel1.AutoSize = true;
            departmentNoLabel1.Location = new System.Drawing.Point(55, 41);
            departmentNoLabel1.Name = "departmentNoLabel1";
            departmentNoLabel1.Size = new System.Drawing.Size(53, 12);
            departmentNoLabel1.TabIndex = 23;
            departmentNoLabel1.Text = "部门编号";
            // 
            // departmentNameLabel1
            // 
            departmentNameLabel1.AutoSize = true;
            departmentNameLabel1.Location = new System.Drawing.Point(55, 68);
            departmentNameLabel1.Name = "departmentNameLabel1";
            departmentNameLabel1.Size = new System.Drawing.Size(53, 12);
            departmentNameLabel1.TabIndex = 25;
            departmentNameLabel1.Text = "部门名称";
            // 
            // parentDepartmentNoLabel1
            // 
            parentDepartmentNoLabel1.AutoSize = true;
            parentDepartmentNoLabel1.Location = new System.Drawing.Point(55, 95);
            parentDepartmentNoLabel1.Name = "parentDepartmentNoLabel1";
            parentDepartmentNoLabel1.Size = new System.Drawing.Size(77, 12);
            parentDepartmentNoLabel1.TabIndex = 27;
            parentDepartmentNoLabel1.Text = "上级部门编号";
            // 
            // createDateLabel
            // 
            createDateLabel.AutoSize = true;
            createDateLabel.Location = new System.Drawing.Point(448, 135);
            createDateLabel.Name = "createDateLabel";
            createDateLabel.Size = new System.Drawing.Size(77, 12);
            createDateLabel.TabIndex = 29;
            createDateLabel.Text = "Create Date:";
            createDateLabel.Visible = false;
            // 
            // founderLabel
            // 
            founderLabel.AutoSize = true;
            founderLabel.Location = new System.Drawing.Point(448, 161);
            founderLabel.Name = "founderLabel";
            founderLabel.Size = new System.Drawing.Size(53, 12);
            founderLabel.TabIndex = 31;
            founderLabel.Text = "Founder:";
            founderLabel.Visible = false;
            // 
            // bfree1Label1
            // 
            bfree1Label1.AutoSize = true;
            bfree1Label1.Location = new System.Drawing.Point(55, 121);
            bfree1Label1.Name = "bfree1Label1";
            bfree1Label1.Size = new System.Drawing.Size(35, 12);
            bfree1Label1.TabIndex = 33;
            bfree1Label1.Text = "预留1";
            // 
            // bfree2Label1
            // 
            bfree2Label1.AutoSize = true;
            bfree2Label1.Location = new System.Drawing.Point(55, 148);
            bfree2Label1.Name = "bfree2Label1";
            bfree2Label1.Size = new System.Drawing.Size(35, 12);
            bfree2Label1.TabIndex = 35;
            bfree2Label1.Text = "预留2";
            // 
            // bfree3Label1
            // 
            bfree3Label1.AutoSize = true;
            bfree3Label1.Location = new System.Drawing.Point(55, 175);
            bfree3Label1.Name = "bfree3Label1";
            bfree3Label1.Size = new System.Drawing.Size(35, 12);
            bfree3Label1.TabIndex = 37;
            bfree3Label1.Text = "预留3";
            // 
            // bfree4Label1
            // 
            bfree4Label1.AutoSize = true;
            bfree4Label1.Location = new System.Drawing.Point(55, 202);
            bfree4Label1.Name = "bfree4Label1";
            bfree4Label1.Size = new System.Drawing.Size(35, 12);
            bfree4Label1.TabIndex = 39;
            bfree4Label1.Text = "预留4";
            // 
            // bfree5Label1
            // 
            bfree5Label1.AutoSize = true;
            bfree5Label1.Location = new System.Drawing.Point(55, 229);
            bfree5Label1.Name = "bfree5Label1";
            bfree5Label1.Size = new System.Drawing.Size(35, 12);
            bfree5Label1.TabIndex = 41;
            bfree5Label1.Text = "预留5";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.AutoScrollMinSize = new System.Drawing.Size(0, 260);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1MinSize = 260;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.bS_DepartmentDataGridView);
            this.splitContainer1.Panel2MinSize = 20;
            this.splitContainer1.Size = new System.Drawing.Size(980, 536);
            this.splitContainer1.SplitterDistance = 260;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(departmentNoLabel1);
            this.panel1.Controls.Add(this.departmentNoTextBox1);
            this.panel1.Controls.Add(departmentNameLabel1);
            this.panel1.Controls.Add(this.departmentNameTextBox1);
            this.panel1.Controls.Add(parentDepartmentNoLabel1);
            this.panel1.Controls.Add(this.parentDepartmentNoTextBox1);
            this.panel1.Controls.Add(createDateLabel);
            this.panel1.Controls.Add(this.createDateDateTimePicker);
            this.panel1.Controls.Add(founderLabel);
            this.panel1.Controls.Add(this.founderTextBox);
            this.panel1.Controls.Add(bfree1Label1);
            this.panel1.Controls.Add(this.bfree1TextBox1);
            this.panel1.Controls.Add(bfree2Label1);
            this.panel1.Controls.Add(this.bfree2TextBox1);
            this.panel1.Controls.Add(bfree3Label1);
            this.panel1.Controls.Add(this.bfree3TextBox1);
            this.panel1.Controls.Add(bfree4Label1);
            this.panel1.Controls.Add(this.bfree4TextBox1);
            this.panel1.Controls.Add(bfree5Label1);
            this.panel1.Controls.Add(this.bfree5TextBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 260);
            this.panel1.TabIndex = 0;
            // 
            // departmentNoTextBox1
            // 
            this.departmentNoTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.departmentNoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_DepartmentBindingSource, "DepartmentNo", true));
            this.departmentNoTextBox1.Location = new System.Drawing.Point(192, 38);
            this.departmentNoTextBox1.Name = "departmentNoTextBox1";
            this.departmentNoTextBox1.Size = new System.Drawing.Size(200, 21);
            this.departmentNoTextBox1.TabIndex = 24;
            this.departmentNoTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.departmentNoTextBox1_KeyPress);
            this.departmentNoTextBox1.Leave += new System.EventHandler(this.departmentNoTextBox1_Leave);
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
            // departmentNameTextBox1
            // 
            this.departmentNameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_DepartmentBindingSource, "DepartmentName", true));
            this.departmentNameTextBox1.Location = new System.Drawing.Point(192, 65);
            this.departmentNameTextBox1.Name = "departmentNameTextBox1";
            this.departmentNameTextBox1.Size = new System.Drawing.Size(200, 21);
            this.departmentNameTextBox1.TabIndex = 26;
            this.departmentNameTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.departmentNameTextBox1_KeyPress);
            this.departmentNameTextBox1.Leave += new System.EventHandler(this.departmentNameTextBox1_Leave);
            // 
            // parentDepartmentNoTextBox1
            // 
            this.parentDepartmentNoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_DepartmentBindingSource, "ParentDepartmentNo", true));
            this.parentDepartmentNoTextBox1.Location = new System.Drawing.Point(192, 92);
            this.parentDepartmentNoTextBox1.Name = "parentDepartmentNoTextBox1";
            this.parentDepartmentNoTextBox1.Size = new System.Drawing.Size(200, 21);
            this.parentDepartmentNoTextBox1.TabIndex = 28;
            this.parentDepartmentNoTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.parentDepartmentNoTextBox1_KeyPress);
            // 
            // createDateDateTimePicker
            // 
            this.createDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bS_DepartmentBindingSource, "CreateDate", true));
            this.createDateDateTimePicker.Location = new System.Drawing.Point(530, 131);
            this.createDateDateTimePicker.Name = "createDateDateTimePicker";
            this.createDateDateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.createDateDateTimePicker.TabIndex = 30;
            this.createDateDateTimePicker.TabStop = false;
            this.createDateDateTimePicker.Visible = false;
            // 
            // founderTextBox
            // 
            this.founderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_DepartmentBindingSource, "Founder", true));
            this.founderTextBox.Location = new System.Drawing.Point(530, 158);
            this.founderTextBox.Name = "founderTextBox";
            this.founderTextBox.Size = new System.Drawing.Size(200, 21);
            this.founderTextBox.TabIndex = 32;
            this.founderTextBox.TabStop = false;
            this.founderTextBox.Visible = false;
            // 
            // bfree1TextBox1
            // 
            this.bfree1TextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_DepartmentBindingSource, "Bfree1", true));
            this.bfree1TextBox1.Location = new System.Drawing.Point(192, 118);
            this.bfree1TextBox1.Name = "bfree1TextBox1";
            this.bfree1TextBox1.Size = new System.Drawing.Size(200, 21);
            this.bfree1TextBox1.TabIndex = 34;
            this.bfree1TextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bfree1TextBox1_KeyPress);
            // 
            // bfree2TextBox1
            // 
            this.bfree2TextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_DepartmentBindingSource, "Bfree2", true));
            this.bfree2TextBox1.Location = new System.Drawing.Point(192, 145);
            this.bfree2TextBox1.Name = "bfree2TextBox1";
            this.bfree2TextBox1.Size = new System.Drawing.Size(200, 21);
            this.bfree2TextBox1.TabIndex = 36;
            this.bfree2TextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bfree2TextBox1_KeyPress);
            // 
            // bfree3TextBox1
            // 
            this.bfree3TextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_DepartmentBindingSource, "Bfree3", true));
            this.bfree3TextBox1.Location = new System.Drawing.Point(192, 172);
            this.bfree3TextBox1.Name = "bfree3TextBox1";
            this.bfree3TextBox1.Size = new System.Drawing.Size(200, 21);
            this.bfree3TextBox1.TabIndex = 38;
            this.bfree3TextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bfree3TextBox1_KeyPress);
            // 
            // bfree4TextBox1
            // 
            this.bfree4TextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_DepartmentBindingSource, "Bfree4", true));
            this.bfree4TextBox1.Location = new System.Drawing.Point(192, 199);
            this.bfree4TextBox1.Name = "bfree4TextBox1";
            this.bfree4TextBox1.Size = new System.Drawing.Size(200, 21);
            this.bfree4TextBox1.TabIndex = 40;
            this.bfree4TextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bfree4TextBox1_KeyPress);
            // 
            // bfree5TextBox1
            // 
            this.bfree5TextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_DepartmentBindingSource, "Bfree5", true));
            this.bfree5TextBox1.Location = new System.Drawing.Point(192, 226);
            this.bfree5TextBox1.Name = "bfree5TextBox1";
            this.bfree5TextBox1.Size = new System.Drawing.Size(200, 21);
            this.bfree5TextBox1.TabIndex = 42;
            this.bfree5TextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bfree5TextBox1_KeyPress);
            // 
            // bS_DepartmentDataGridView
            // 
            this.bS_DepartmentDataGridView.AllowUserToAddRows = false;
            this.bS_DepartmentDataGridView.AllowUserToDeleteRows = false;
            this.bS_DepartmentDataGridView.AutoGenerateColumns = false;
            this.bS_DepartmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bS_DepartmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.bS_DepartmentDataGridView.DataSource = this.bS_DepartmentBindingSource;
            this.bS_DepartmentDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bS_DepartmentDataGridView.Location = new System.Drawing.Point(0, 0);
            this.bS_DepartmentDataGridView.Name = "bS_DepartmentDataGridView";
            this.bS_DepartmentDataGridView.ReadOnly = true;
            this.bS_DepartmentDataGridView.RowTemplate.Height = 23;
            this.bS_DepartmentDataGridView.ShowEditingIcon = false;
            this.bS_DepartmentDataGridView.Size = new System.Drawing.Size(980, 272);
            this.bS_DepartmentDataGridView.TabIndex = 0;
            // 
            // bS_DepartmentTableAdapter
            // 
            this.bS_DepartmentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BS_DepartmentTableAdapter = this.bS_DepartmentTableAdapter;
            this.tableAdapterManager.UpdateOrder = PSAP.dsPSAPTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bS_DepartmentBindingNavigator
            // 
            this.bS_DepartmentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bS_DepartmentBindingNavigator.BindingSource = this.bS_DepartmentBindingSource;
            this.bS_DepartmentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bS_DepartmentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bS_DepartmentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bS_DepartmentBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.bS_DepartmentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bS_DepartmentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bS_DepartmentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bS_DepartmentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bS_DepartmentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bS_DepartmentBindingNavigator.Name = "bS_DepartmentBindingNavigator";
            this.bS_DepartmentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bS_DepartmentBindingNavigator.Size = new System.Drawing.Size(980, 25);
            this.bS_DepartmentBindingNavigator.TabIndex = 1;
            this.bS_DepartmentBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(52, 22);
            this.bindingNavigatorAddNewItem.Text = "新添";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(52, 22);
            this.bindingNavigatorDeleteItem.Text = "删除";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bS_DepartmentBindingNavigatorSaveItem
            // 
            this.bS_DepartmentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bS_DepartmentBindingNavigatorSaveItem.Image")));
            this.bS_DepartmentBindingNavigatorSaveItem.Name = "bS_DepartmentBindingNavigatorSaveItem";
            this.bS_DepartmentBindingNavigatorSaveItem.Size = new System.Drawing.Size(76, 22);
            this.bS_DepartmentBindingNavigatorSaveItem.Text = "保存数据";
            this.bS_DepartmentBindingNavigatorSaveItem.Click += new System.EventHandler(this.bS_DepartmentBindingNavigatorSaveItem_Click_1);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton1.Text = "导出";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AutoId";
            this.dataGridViewTextBoxColumn1.HeaderText = "序号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DepartmentNo";
            this.dataGridViewTextBoxColumn2.HeaderText = "部门编号";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 95;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DepartmentName";
            this.dataGridViewTextBoxColumn3.HeaderText = "部门名称";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 95;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ParentDepartmentNo";
            this.dataGridViewTextBoxColumn4.HeaderText = "上级部门编号";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CreateDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "录入日期";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Founder";
            this.dataGridViewTextBoxColumn6.HeaderText = "录入人";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 70;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Bfree1";
            this.dataGridViewTextBoxColumn7.HeaderText = "预留1";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 96;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Bfree2";
            this.dataGridViewTextBoxColumn8.HeaderText = "预留2";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 95;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Bfree3";
            this.dataGridViewTextBoxColumn9.HeaderText = "预留3";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 95;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Bfree4";
            this.dataGridViewTextBoxColumn10.HeaderText = "预留4";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 96;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Bfree5";
            this.dataGridViewTextBoxColumn11.HeaderText = "预留5";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 95;
            // 
            // FrmDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 536);
            this.Controls.Add(this.bS_DepartmentBindingNavigator);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(430, 420);
            this.Name = "FrmDepartment";
            this.Text = "部门信息";
            this.Load += new System.EventHandler(this.FrmDepartment_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bS_DepartmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPSAP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bS_DepartmentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bS_DepartmentBindingNavigator)).EndInit();
            this.bS_DepartmentBindingNavigator.ResumeLayout(false);
            this.bS_DepartmentBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private dsPSAP dsPSAP;
        private System.Windows.Forms.BindingSource bS_DepartmentBindingSource;
        private dsPSAPTableAdapters.BS_DepartmentTableAdapter bS_DepartmentTableAdapter;
        private dsPSAPTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bS_DepartmentBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bS_DepartmentBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView bS_DepartmentDataGridView;
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
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}