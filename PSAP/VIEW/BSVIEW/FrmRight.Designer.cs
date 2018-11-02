namespace PSAP.VIEW.BSVIEW
{
    partial class FrmRight
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
            System.Windows.Forms.Label roleNoLabel;
            System.Windows.Forms.Label roleNameLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRight));
            this.tvwUserRight = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabUserPower = new System.Windows.Forms.TabPage();
            this.cboRoleName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSaveRight = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvUserList = new System.Windows.Forms.DataGridView();
            this.cboDepartmentName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtLoginID = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.btnStretch = new System.Windows.Forms.Button();
            this.tabMainMenu = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.bS_MenuDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboFormName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bS_MenuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPSAP = new PSAP.dsPSAP();
            this.tvwMainMenu = new System.Windows.Forms.TreeView();
            this.cmnsMainMeunTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.insertTreeNode = new System.Windows.Forms.ToolStripMenuItem();
            this.addChildTreeNode = new System.Windows.Forms.ToolStripMenuItem();
            this.addRootTreeNode = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteTreeNode = new System.Windows.Forms.ToolStripMenuItem();
            this.tabRole = new System.Windows.Forms.TabPage();
            this.tvwRoleRight = new System.Windows.Forms.TreeView();
            this.dgvRoleList = new System.Windows.Forms.DataGridView();
            this.autoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bS_RoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.roleNameTextBox = new System.Windows.Forms.TextBox();
            this.roleNoTextBox = new System.Windows.Forms.TextBox();
            this.autoIdTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bS_RoleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsControl = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            this.tsbQuery = new System.Windows.Forms.ToolStripButton();
            this.tsbDGViewExportToCSV = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.bSDepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bS_DepartmentTableAdapter = new PSAP.dsPSAPTableAdapters.BS_DepartmentTableAdapter();
            this.bS_RoleTableAdapter = new PSAP.dsPSAPTableAdapters.BS_RoleTableAdapter();
            this.tableAdapterManager = new PSAP.dsPSAPTableAdapters.TableAdapterManager();
            this.bS_MenuTableAdapter = new PSAP.dsPSAPTableAdapters.BS_MenuTableAdapter();
            autoIdLabel = new System.Windows.Forms.Label();
            roleNoLabel = new System.Windows.Forms.Label();
            roleNameLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabUserPower.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).BeginInit();
            this.tabMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bS_MenuDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bS_MenuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPSAP)).BeginInit();
            this.cmnsMainMeunTree.SuspendLayout();
            this.tabRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoleList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bS_RoleBindingSource)).BeginInit();
            this.pnlEdit.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bS_RoleBindingNavigator)).BeginInit();
            this.bS_RoleBindingNavigator.SuspendLayout();
            this.tsControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSDepartmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // autoIdLabel
            // 
            autoIdLabel.AutoSize = true;
            autoIdLabel.Location = new System.Drawing.Point(39, 61);
            autoIdLabel.Name = "autoIdLabel";
            autoIdLabel.Size = new System.Drawing.Size(29, 12);
            autoIdLabel.TabIndex = 5;
            autoIdLabel.Text = "编号";
            autoIdLabel.Visible = false;
            // 
            // roleNoLabel
            // 
            roleNoLabel.AutoSize = true;
            roleNoLabel.Location = new System.Drawing.Point(3, 11);
            roleNoLabel.Name = "roleNoLabel";
            roleNoLabel.Size = new System.Drawing.Size(53, 12);
            roleNoLabel.TabIndex = 7;
            roleNoLabel.Text = "角色编号";
            // 
            // roleNameLabel
            // 
            roleNameLabel.AutoSize = true;
            roleNameLabel.Location = new System.Drawing.Point(3, 38);
            roleNameLabel.Name = "roleNameLabel";
            roleNameLabel.Size = new System.Drawing.Size(53, 12);
            roleNameLabel.TabIndex = 9;
            roleNameLabel.Text = "角色名称";
            // 
            // tvwUserRight
            // 
            this.tvwUserRight.ItemHeight = 20;
            this.tvwUserRight.Location = new System.Drawing.Point(411, 63);
            this.tvwUserRight.Name = "tvwUserRight";
            this.tvwUserRight.Size = new System.Drawing.Size(375, 504);
            this.tvwUserRight.TabIndex = 0;
            this.tvwUserRight.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvwUserRight_AfterCheck);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabUserPower);
            this.tabControl1.Controls.Add(this.tabMainMenu);
            this.tabControl1.Controls.Add(this.tabRole);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1006, 628);
            this.tabControl1.TabIndex = 1;
            // 
            // tabUserPower
            // 
            this.tabUserPower.Controls.Add(this.cboRoleName);
            this.tabUserPower.Controls.Add(this.label6);
            this.tabUserPower.Controls.Add(this.btnSaveRight);
            this.tabUserPower.Controls.Add(this.label5);
            this.tabUserPower.Controls.Add(this.dgvUserList);
            this.tabUserPower.Controls.Add(this.cboDepartmentName);
            this.tabUserPower.Controls.Add(this.label4);
            this.tabUserPower.Controls.Add(this.label3);
            this.tabUserPower.Controls.Add(this.label2);
            this.tabUserPower.Controls.Add(this.label1);
            this.tabUserPower.Controls.Add(this.txtUserName);
            this.tabUserPower.Controls.Add(this.txtLoginID);
            this.tabUserPower.Controls.Add(this.txtUserID);
            this.tabUserPower.Controls.Add(this.btnStretch);
            this.tabUserPower.Controls.Add(this.tvwUserRight);
            this.tabUserPower.Location = new System.Drawing.Point(4, 22);
            this.tabUserPower.Name = "tabUserPower";
            this.tabUserPower.Padding = new System.Windows.Forms.Padding(3);
            this.tabUserPower.Size = new System.Drawing.Size(998, 602);
            this.tabUserPower.TabIndex = 0;
            this.tabUserPower.Text = "用户权限管理";
            this.tabUserPower.UseVisualStyleBackColor = true;
            // 
            // cboRoleName
            // 
            this.cboRoleName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoleName.FormattingEnabled = true;
            this.cboRoleName.Location = new System.Drawing.Point(500, 39);
            this.cboRoleName.Name = "cboRoleName";
            this.cboRoleName.Size = new System.Drawing.Size(85, 20);
            this.cboRoleName.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(417, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "用户角色设定";
            // 
            // btnSaveRight
            // 
            this.btnSaveRight.Location = new System.Drawing.Point(671, 8);
            this.btnSaveRight.Name = "btnSaveRight";
            this.btnSaveRight.Size = new System.Drawing.Size(75, 23);
            this.btnSaveRight.TabIndex = 13;
            this.btnSaveRight.Text = "保存权限";
            this.btnSaveRight.UseVisualStyleBackColor = true;
            this.btnSaveRight.Click += new System.EventHandler(this.btnSaveRight_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "说明 ：斜体字为“角色”权限，此处修改无效";
            // 
            // dgvUserList
            // 
            this.dgvUserList.AllowUserToAddRows = false;
            this.dgvUserList.AllowUserToDeleteRows = false;
            this.dgvUserList.AllowUserToResizeRows = false;
            this.dgvUserList.ColumnHeadersHeight = 32;
            this.dgvUserList.Location = new System.Drawing.Point(5, 63);
            this.dgvUserList.MultiSelect = false;
            this.dgvUserList.Name = "dgvUserList";
            this.dgvUserList.ReadOnly = true;
            this.dgvUserList.RowTemplate.Height = 23;
            this.dgvUserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserList.Size = new System.Drawing.Size(400, 504);
            this.dgvUserList.TabIndex = 11;
            this.dgvUserList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvUserList_RowPostPaint);
            this.dgvUserList.SelectionChanged += new System.EventHandler(this.dgvUserList_SelectionChanged);
            // 
            // cboDepartmentName
            // 
            this.cboDepartmentName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartmentName.FormattingEnabled = true;
            this.cboDepartmentName.Location = new System.Drawing.Point(164, 36);
            this.cboDepartmentName.Name = "cboDepartmentName";
            this.cboDepartmentName.Size = new System.Drawing.Size(85, 20);
            this.cboDepartmentName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "部门";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "员工姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "用户编号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "员工编号";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(62, 36);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(61, 21);
            this.txtUserName.TabIndex = 5;
            // 
            // txtLoginID
            // 
            this.txtLoginID.Location = new System.Drawing.Point(188, 7);
            this.txtLoginID.Name = "txtLoginID";
            this.txtLoginID.Size = new System.Drawing.Size(61, 21);
            this.txtLoginID.TabIndex = 4;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(62, 7);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(61, 21);
            this.txtUserID.TabIndex = 3;
            // 
            // btnStretch
            // 
            this.btnStretch.Location = new System.Drawing.Point(284, 34);
            this.btnStretch.Name = "btnStretch";
            this.btnStretch.Size = new System.Drawing.Size(85, 23);
            this.btnStretch.TabIndex = 2;
            this.btnStretch.Text = "筛选";
            this.btnStretch.UseVisualStyleBackColor = true;
            this.btnStretch.Click += new System.EventHandler(this.btnStretch_Click);
            // 
            // tabMainMenu
            // 
            this.tabMainMenu.AutoScroll = true;
            this.tabMainMenu.Controls.Add(this.btnSave);
            this.tabMainMenu.Controls.Add(this.bS_MenuDataGridView);
            this.tabMainMenu.Controls.Add(this.tvwMainMenu);
            this.tabMainMenu.Location = new System.Drawing.Point(4, 22);
            this.tabMainMenu.Name = "tabMainMenu";
            this.tabMainMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabMainMenu.Size = new System.Drawing.Size(998, 602);
            this.tabMainMenu.TabIndex = 1;
            this.tabMainMenu.Text = "主菜单管理";
            this.tabMainMenu.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(751, 532);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存更改";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // bS_MenuDataGridView
            // 
            this.bS_MenuDataGridView.AllowUserToAddRows = false;
            this.bS_MenuDataGridView.AllowUserToDeleteRows = false;
            this.bS_MenuDataGridView.AutoGenerateColumns = false;
            this.bS_MenuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bS_MenuDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewComboFormName,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.bS_MenuDataGridView.DataSource = this.bS_MenuBindingSource;
            this.bS_MenuDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.bS_MenuDataGridView.Location = new System.Drawing.Point(234, 6);
            this.bS_MenuDataGridView.Name = "bS_MenuDataGridView";
            this.bS_MenuDataGridView.RowTemplate.Height = 23;
            this.bS_MenuDataGridView.Size = new System.Drawing.Size(711, 510);
            this.bS_MenuDataGridView.TabIndex = 1;
            this.bS_MenuDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.bS_MenuDataGridView_RowPostPaint);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MenuName";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn2.HeaderText = "菜单ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MenuText";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn3.HeaderText = "菜单名称";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ParentMenuName";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn7.HeaderText = "父菜单ID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewComboFormName
            // 
            this.dataGridViewComboFormName.DataPropertyName = "FormName";
            this.dataGridViewComboFormName.HeaderText = "窗口ID";
            this.dataGridViewComboFormName.Name = "dataGridViewComboFormName";
            this.dataGridViewComboFormName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboFormName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FormText";
            this.dataGridViewTextBoxColumn5.HeaderText = "窗口标题";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MenuOrder";
            this.dataGridViewTextBoxColumn6.HeaderText = "显示顺序";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // bS_MenuBindingSource
            // 
            this.bS_MenuBindingSource.DataMember = "BS_Menu";
            this.bS_MenuBindingSource.DataSource = this.dsPSAP;
            // 
            // dsPSAP
            // 
            this.dsPSAP.DataSetName = "dsPSAP";
            this.dsPSAP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tvwMainMenu
            // 
            this.tvwMainMenu.ContextMenuStrip = this.cmnsMainMeunTree;
            this.tvwMainMenu.FullRowSelect = true;
            this.tvwMainMenu.HotTracking = true;
            this.tvwMainMenu.ItemHeight = 20;
            this.tvwMainMenu.LabelEdit = true;
            this.tvwMainMenu.Location = new System.Drawing.Point(3, 6);
            this.tvwMainMenu.Name = "tvwMainMenu";
            this.tvwMainMenu.ShowNodeToolTips = true;
            this.tvwMainMenu.ShowRootLines = false;
            this.tvwMainMenu.Size = new System.Drawing.Size(225, 510);
            this.tvwMainMenu.TabIndex = 0;
            this.tvwMainMenu.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.tvwMainMenu_AfterLabelEdit);
            this.tvwMainMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwMainMenu_AfterSelect);
            this.tvwMainMenu.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvwMainMenu_NodeMouseClick);
            // 
            // cmnsMainMeunTree
            // 
            this.cmnsMainMeunTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertTreeNode,
            this.addChildTreeNode,
            this.addRootTreeNode,
            this.toolStripSeparator1,
            this.deleteTreeNode});
            this.cmnsMainMeunTree.Name = "contextMenuStrip1";
            this.cmnsMainMeunTree.Size = new System.Drawing.Size(149, 98);
            // 
            // insertTreeNode
            // 
            this.insertTreeNode.Name = "insertTreeNode";
            this.insertTreeNode.Size = new System.Drawing.Size(148, 22);
            this.insertTreeNode.Text = "插入同级菜单";
            this.insertTreeNode.Click += new System.EventHandler(this.insertTreeNode_Click);
            // 
            // addChildTreeNode
            // 
            this.addChildTreeNode.Name = "addChildTreeNode";
            this.addChildTreeNode.Size = new System.Drawing.Size(148, 22);
            this.addChildTreeNode.Text = "新建子菜单";
            this.addChildTreeNode.Click += new System.EventHandler(this.addChildTreeNode_Click);
            // 
            // addRootTreeNode
            // 
            this.addRootTreeNode.Name = "addRootTreeNode";
            this.addRootTreeNode.Size = new System.Drawing.Size(148, 22);
            this.addRootTreeNode.Text = "新建主菜单";
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
            this.deleteTreeNode.Text = "删除菜单";
            this.deleteTreeNode.Click += new System.EventHandler(this.deleteTreeNode_Click);
            // 
            // tabRole
            // 
            this.tabRole.Controls.Add(this.tvwRoleRight);
            this.tabRole.Controls.Add(this.dgvRoleList);
            this.tabRole.Controls.Add(this.pnlEdit);
            this.tabRole.Controls.Add(this.panel1);
            this.tabRole.Location = new System.Drawing.Point(4, 22);
            this.tabRole.Name = "tabRole";
            this.tabRole.Size = new System.Drawing.Size(998, 602);
            this.tabRole.TabIndex = 2;
            this.tabRole.Text = "角色权限管理";
            this.tabRole.UseVisualStyleBackColor = true;
            // 
            // tvwRoleRight
            // 
            this.tvwRoleRight.ItemHeight = 20;
            this.tvwRoleRight.Location = new System.Drawing.Point(290, 57);
            this.tvwRoleRight.Name = "tvwRoleRight";
            this.tvwRoleRight.Size = new System.Drawing.Size(324, 486);
            this.tvwRoleRight.TabIndex = 11;
            this.tvwRoleRight.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvwRoleRight_AfterCheck);
            // 
            // dgvRoleList
            // 
            this.dgvRoleList.AllowUserToAddRows = false;
            this.dgvRoleList.AllowUserToDeleteRows = false;
            this.dgvRoleList.AutoGenerateColumns = false;
            this.dgvRoleList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRoleList.ColumnHeadersHeight = 28;
            this.dgvRoleList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.autoIdDataGridViewTextBoxColumn,
            this.roleNoDataGridViewTextBoxColumn,
            this.roleNameDataGridViewTextBoxColumn});
            this.dgvRoleList.DataSource = this.bS_RoleBindingSource;
            this.dgvRoleList.Location = new System.Drawing.Point(3, 166);
            this.dgvRoleList.Name = "dgvRoleList";
            this.dgvRoleList.ReadOnly = true;
            this.dgvRoleList.RowTemplate.Height = 23;
            this.dgvRoleList.ShowEditingIcon = false;
            this.dgvRoleList.Size = new System.Drawing.Size(281, 377);
            this.dgvRoleList.TabIndex = 10;
            this.dgvRoleList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvRoleList_RowPostPaint);
            this.dgvRoleList.SelectionChanged += new System.EventHandler(this.dgvRoleList_SelectionChanged);
            // 
            // autoIdDataGridViewTextBoxColumn
            // 
            this.autoIdDataGridViewTextBoxColumn.DataPropertyName = "AutoId";
            this.autoIdDataGridViewTextBoxColumn.HeaderText = "编号";
            this.autoIdDataGridViewTextBoxColumn.Name = "autoIdDataGridViewTextBoxColumn";
            this.autoIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.autoIdDataGridViewTextBoxColumn.Visible = false;
            this.autoIdDataGridViewTextBoxColumn.Width = 54;
            // 
            // roleNoDataGridViewTextBoxColumn
            // 
            this.roleNoDataGridViewTextBoxColumn.DataPropertyName = "RoleNo";
            this.roleNoDataGridViewTextBoxColumn.HeaderText = "角色编号";
            this.roleNoDataGridViewTextBoxColumn.Name = "roleNoDataGridViewTextBoxColumn";
            this.roleNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.roleNoDataGridViewTextBoxColumn.Width = 78;
            // 
            // roleNameDataGridViewTextBoxColumn
            // 
            this.roleNameDataGridViewTextBoxColumn.DataPropertyName = "RoleName";
            this.roleNameDataGridViewTextBoxColumn.HeaderText = "角色名称";
            this.roleNameDataGridViewTextBoxColumn.Name = "roleNameDataGridViewTextBoxColumn";
            this.roleNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.roleNameDataGridViewTextBoxColumn.Width = 78;
            // 
            // bS_RoleBindingSource
            // 
            this.bS_RoleBindingSource.DataMember = "BS_Role";
            this.bS_RoleBindingSource.DataSource = this.dsPSAP;
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.roleNameTextBox);
            this.pnlEdit.Controls.Add(this.roleNoTextBox);
            this.pnlEdit.Controls.Add(autoIdLabel);
            this.pnlEdit.Controls.Add(this.autoIdTextBox);
            this.pnlEdit.Controls.Add(roleNoLabel);
            this.pnlEdit.Controls.Add(roleNameLabel);
            this.pnlEdit.Enabled = false;
            this.pnlEdit.Location = new System.Drawing.Point(3, 81);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(281, 70);
            this.pnlEdit.TabIndex = 9;
            // 
            // roleNameTextBox
            // 
            this.roleNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_RoleBindingSource, "RoleName", true));
            this.roleNameTextBox.Location = new System.Drawing.Point(74, 35);
            this.roleNameTextBox.Name = "roleNameTextBox";
            this.roleNameTextBox.Size = new System.Drawing.Size(100, 21);
            this.roleNameTextBox.TabIndex = 13;
            this.roleNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.roleNameTextBox_KeyPress);
            // 
            // roleNoTextBox
            // 
            this.roleNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_RoleBindingSource, "RoleNo", true));
            this.roleNoTextBox.Location = new System.Drawing.Point(74, 8);
            this.roleNoTextBox.Name = "roleNoTextBox";
            this.roleNoTextBox.Size = new System.Drawing.Size(100, 21);
            this.roleNoTextBox.TabIndex = 11;
            this.roleNoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.roleNoTextBox_KeyPress);
            // 
            // autoIdTextBox
            // 
            this.autoIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_RoleBindingSource, "AutoId", true));
            this.autoIdTextBox.Location = new System.Drawing.Point(74, 58);
            this.autoIdTextBox.Name = "autoIdTextBox";
            this.autoIdTextBox.Size = new System.Drawing.Size(100, 21);
            this.autoIdTextBox.TabIndex = 9;
            this.autoIdTextBox.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bS_RoleBindingNavigator);
            this.panel1.Controls.Add(this.tsControl);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 72);
            this.panel1.TabIndex = 8;
            // 
            // bS_RoleBindingNavigator
            // 
            this.bS_RoleBindingNavigator.AddNewItem = null;
            this.bS_RoleBindingNavigator.BindingSource = this.bS_RoleBindingSource;
            this.bS_RoleBindingNavigator.CountItem = this.toolStripLabel1;
            this.bS_RoleBindingNavigator.DeleteItem = null;
            this.bS_RoleBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.bS_RoleBindingNavigator.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bS_RoleBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bS_RoleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator3,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator4});
            this.bS_RoleBindingNavigator.Location = new System.Drawing.Point(0, 25);
            this.bS_RoleBindingNavigator.MoveFirstItem = this.toolStripButton1;
            this.bS_RoleBindingNavigator.MoveLastItem = this.toolStripButton4;
            this.bS_RoleBindingNavigator.MoveNextItem = this.toolStripButton3;
            this.bS_RoleBindingNavigator.MovePreviousItem = this.toolStripButton2;
            this.bS_RoleBindingNavigator.Name = "bS_RoleBindingNavigator";
            this.bS_RoleBindingNavigator.PositionItem = this.toolStripTextBox1;
            this.bS_RoleBindingNavigator.Size = new System.Drawing.Size(197, 25);
            this.bS_RoleBindingNavigator.TabIndex = 9;
            this.bS_RoleBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel1.Text = "/ {0}";
            this.toolStripLabel1.ToolTipText = "总项数";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "移到第一条记录";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "移到上一条记录";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "位置";
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 25);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "当前位置";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "移到下一条记录";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "移到最后一条记录";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
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
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
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
            this.tsbQuery.Click += new System.EventHandler(this.tsbQuery_Click);
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
            // bSDepartmentBindingSource
            // 
            this.bSDepartmentBindingSource.DataMember = "BS_Department";
            this.bSDepartmentBindingSource.DataSource = this.dsPSAP;
            // 
            // bS_DepartmentTableAdapter
            // 
            this.bS_DepartmentTableAdapter.ClearBeforeFill = true;
            // 
            // bS_RoleTableAdapter
            // 
            this.bS_RoleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BS_DepartmentTableAdapter = this.bS_DepartmentTableAdapter;
            this.tableAdapterManager.BS_MenuTableAdapter = null;
            this.tableAdapterManager.BS_RoleTableAdapter = this.bS_RoleTableAdapter;
            this.tableAdapterManager.BS_UnitCatgTableAdapter = null;
            this.tableAdapterManager.BS_UserInfoTableAdapter = null;
            this.tableAdapterManager.BS_UserRightTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PSAP.dsPSAPTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bS_MenuTableAdapter
            // 
            this.bS_MenuTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRight
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1006, 628);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("宋体", 9F);
            this.MinimumSize = new System.Drawing.Size(430, 420);
            this.Name = "FrmRight";
            this.TabText = "用户权限";
            this.Text = "用户权限";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmUserRight_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabUserPower.ResumeLayout(false);
            this.tabUserPower.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).EndInit();
            this.tabMainMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bS_MenuDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bS_MenuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPSAP)).EndInit();
            this.cmnsMainMeunTree.ResumeLayout(false);
            this.tabRole.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoleList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bS_RoleBindingSource)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bS_RoleBindingNavigator)).EndInit();
            this.bS_RoleBindingNavigator.ResumeLayout(false);
            this.bS_RoleBindingNavigator.PerformLayout();
            this.tsControl.ResumeLayout(false);
            this.tsControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSDepartmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvwUserRight;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabUserPower;
        private System.Windows.Forms.TabPage tabMainMenu;
        private System.Windows.Forms.TabPage tabRole;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Button btnStretch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtLoginID;
        private System.Windows.Forms.ComboBox cboDepartmentName;
        private System.Windows.Forms.Label label4;
        private dsPSAP dsPSAP;
        private System.Windows.Forms.BindingSource bSDepartmentBindingSource;
        private dsPSAPTableAdapters.BS_DepartmentTableAdapter bS_DepartmentTableAdapter;
        private System.Windows.Forms.DataGridView dgvUserList;
        private System.Windows.Forms.BindingSource bS_RoleBindingSource;
        private dsPSAPTableAdapters.BS_RoleTableAdapter bS_RoleTableAdapter;
        private dsPSAPTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ContextMenuStrip cmnsMainMeunTree;
        private System.Windows.Forms.ToolStripMenuItem addChildTreeNode;
        private System.Windows.Forms.ToolStripMenuItem addRootTreeNode;
        private System.Windows.Forms.ToolStripMenuItem deleteTreeNode;
        private System.Windows.Forms.ToolStripMenuItem insertTreeNode;
        private System.Windows.Forms.TreeView tvwMainMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.BindingSource bS_MenuBindingSource;
        private dsPSAPTableAdapters.BS_MenuTableAdapter bS_MenuTableAdapter;
        private System.Windows.Forms.DataGridView bS_MenuDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboFormName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSaveRight;
        private System.Windows.Forms.DataGridView dgvRoleList;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.TextBox roleNameTextBox;
        private System.Windows.Forms.TextBox roleNoTextBox;
        private System.Windows.Forms.TextBox autoIdTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip tsControl;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbCancel;
        private System.Windows.Forms.ToolStripButton tsbQuery;
        private System.Windows.Forms.ToolStripButton tsbDGViewExportToCSV;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.TreeView tvwRoleRight;
        private System.Windows.Forms.ComboBox cboRoleName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingNavigator bS_RoleBindingNavigator;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}