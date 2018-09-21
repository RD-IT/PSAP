namespace PSAP.VIEW.BSVIEW
{
    partial class FrmUserRight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserRight));
            System.Windows.Forms.Label autoIdLabel;
            System.Windows.Forms.Label roleNoLabel;
            System.Windows.Forms.Label roleNameLabel;
            this.tvwUserRigth = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabUserPower = new System.Windows.Forms.TabPage();
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
            this.tabRole = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bS_DepartmentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsControl = new System.Windows.Forms.ToolStrip();
            this.tsbInsert = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            this.tsbQuery = new System.Windows.Forms.ToolStripButton();
            this.tsbDGViewExportToCSV = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.dsPSAP = new PSAP.dsPSAP();
            this.bSDepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bS_DepartmentTableAdapter = new PSAP.dsPSAPTableAdapters.BS_DepartmentTableAdapter();
            this.bS_RoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bS_RoleTableAdapter = new PSAP.dsPSAPTableAdapters.BS_RoleTableAdapter();
            this.tableAdapterManager = new PSAP.dsPSAPTableAdapters.TableAdapterManager();
            this.autoIdTextBox = new System.Windows.Forms.TextBox();
            this.roleNoTextBox = new System.Windows.Forms.TextBox();
            this.roleNameTextBox = new System.Windows.Forms.TextBox();
            this.bS_RoleDataGridView = new System.Windows.Forms.DataGridView();
            this.autoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            autoIdLabel = new System.Windows.Forms.Label();
            roleNoLabel = new System.Windows.Forms.Label();
            roleNameLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabUserPower.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).BeginInit();
            this.tabRole.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bS_DepartmentBindingNavigator)).BeginInit();
            this.bS_DepartmentBindingNavigator.SuspendLayout();
            this.tsControl.SuspendLayout();
            this.pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPSAP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSDepartmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bS_RoleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bS_RoleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tvwUserRigth
            // 
            this.tvwUserRigth.ItemHeight = 20;
            this.tvwUserRigth.Location = new System.Drawing.Point(261, 7);
            this.tvwUserRigth.Name = "tvwUserRigth";
            this.tvwUserRigth.Size = new System.Drawing.Size(294, 560);
            this.tvwUserRigth.TabIndex = 0;
            this.tvwUserRigth.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            this.tvwUserRigth.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
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
            this.tabUserPower.Controls.Add(this.tvwUserRigth);
            this.tabUserPower.Location = new System.Drawing.Point(4, 22);
            this.tabUserPower.Name = "tabUserPower";
            this.tabUserPower.Padding = new System.Windows.Forms.Padding(3);
            this.tabUserPower.Size = new System.Drawing.Size(998, 602);
            this.tabUserPower.TabIndex = 0;
            this.tabUserPower.Text = "用户权限管理";
            this.tabUserPower.UseVisualStyleBackColor = true;
            // 
            // dgvUserList
            // 
            this.dgvUserList.AllowUserToAddRows = false;
            this.dgvUserList.AllowUserToDeleteRows = false;
            this.dgvUserList.AllowUserToResizeRows = false;
            this.dgvUserList.ColumnHeadersHeight = 32;
            this.dgvUserList.Location = new System.Drawing.Point(5, 92);
            this.dgvUserList.MultiSelect = false;
            this.dgvUserList.Name = "dgvUserList";
            this.dgvUserList.ReadOnly = true;
            this.dgvUserList.RowHeadersVisible = false;
            this.dgvUserList.RowTemplate.Height = 23;
            this.dgvUserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserList.Size = new System.Drawing.Size(250, 475);
            this.dgvUserList.TabIndex = 11;
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
            this.btnStretch.Location = new System.Drawing.Point(5, 63);
            this.btnStretch.Name = "btnStretch";
            this.btnStretch.Size = new System.Drawing.Size(85, 23);
            this.btnStretch.TabIndex = 2;
            this.btnStretch.Text = "筛选";
            this.btnStretch.UseVisualStyleBackColor = true;
            this.btnStretch.Click += new System.EventHandler(this.btnStretch_Click);
            // 
            // tabMainMenu
            // 
            this.tabMainMenu.Location = new System.Drawing.Point(4, 22);
            this.tabMainMenu.Name = "tabMainMenu";
            this.tabMainMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabMainMenu.Size = new System.Drawing.Size(998, 602);
            this.tabMainMenu.TabIndex = 1;
            this.tabMainMenu.Text = "主菜单管理";
            this.tabMainMenu.UseVisualStyleBackColor = true;
            // 
            // tabRole
            // 
            this.tabRole.Controls.Add(this.bS_RoleDataGridView);
            this.tabRole.Controls.Add(this.pnlEdit);
            this.tabRole.Controls.Add(this.panel1);
            this.tabRole.Location = new System.Drawing.Point(4, 22);
            this.tabRole.Name = "tabRole";
            this.tabRole.Size = new System.Drawing.Size(998, 602);
            this.tabRole.TabIndex = 2;
            this.tabRole.Text = "角色管理";
            this.tabRole.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bS_DepartmentBindingNavigator);
            this.panel1.Controls.Add(this.tsControl);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 72);
            this.panel1.TabIndex = 4;
            // 
            // bS_DepartmentBindingNavigator
            // 
            this.bS_DepartmentBindingNavigator.AddNewItem = null;
            this.bS_DepartmentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bS_DepartmentBindingNavigator.DeleteItem = null;
            this.bS_DepartmentBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.bS_DepartmentBindingNavigator.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bS_DepartmentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bS_DepartmentBindingNavigator.Location = new System.Drawing.Point(0, 25);
            this.bS_DepartmentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bS_DepartmentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bS_DepartmentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bS_DepartmentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bS_DepartmentBindingNavigator.Name = "bS_DepartmentBindingNavigator";
            this.bS_DepartmentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bS_DepartmentBindingNavigator.Size = new System.Drawing.Size(188, 25);
            this.bS_DepartmentBindingNavigator.TabIndex = 3;
            this.bS_DepartmentBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Font = new System.Drawing.Font("微软雅黑", 9F);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(32, 23);
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
            // tsControl
            // 
            this.tsControl.Dock = System.Windows.Forms.DockStyle.None;
            this.tsControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbInsert,
            this.tsbEdit,
            this.tsbDelete,
            this.tsbSave,
            this.tsbCancel,
            this.tsbQuery,
            this.tsbDGViewExportToCSV,
            this.tsbClose});
            this.tsControl.Location = new System.Drawing.Point(0, 0);
            this.tsControl.Name = "tsControl";
            this.tsControl.Size = new System.Drawing.Size(452, 25);
            this.tsControl.TabIndex = 4;
            this.tsControl.Text = "toolStrip1";
            // 
            // tsbInsert
            // 
            this.tsbInsert.Image = ((System.Drawing.Image)(resources.GetObject("tsbInsert.Image")));
            this.tsbInsert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInsert.Name = "tsbInsert";
            this.tsbInsert.Size = new System.Drawing.Size(52, 22);
            this.tsbInsert.Text = "新增";
            // 
            // tsbEdit
            // 
            this.tsbEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbEdit.Image")));
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(52, 22);
            this.tsbEdit.Text = "编辑";
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(52, 22);
            this.tsbDelete.Text = "删除";
            // 
            // tsbSave
            // 
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(52, 22);
            this.tsbSave.Text = "保存";
            // 
            // tsbCancel
            // 
            this.tsbCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancel.Image")));
            this.tsbCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancel.Name = "tsbCancel";
            this.tsbCancel.Size = new System.Drawing.Size(52, 22);
            this.tsbCancel.Text = "取消";
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
            // 
            // tsbClose
            // 
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(52, 22);
            this.tsbClose.Text = "退出";
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(autoIdLabel);
            this.pnlEdit.Controls.Add(roleNoLabel);
            this.pnlEdit.Controls.Add(this.autoIdTextBox);
            this.pnlEdit.Controls.Add(this.roleNameTextBox);
            this.pnlEdit.Controls.Add(roleNameLabel);
            this.pnlEdit.Controls.Add(this.roleNoTextBox);
            this.pnlEdit.Enabled = false;
            this.pnlEdit.Location = new System.Drawing.Point(3, 81);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(606, 107);
            this.pnlEdit.TabIndex = 5;
            // 
            // dsPSAP
            // 
            this.dsPSAP.DataSetName = "dsPSAP";
            this.dsPSAP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // bS_RoleBindingSource
            // 
            this.bS_RoleBindingSource.DataMember = "BS_Role";
            this.bS_RoleBindingSource.DataSource = this.dsPSAP;
            // 
            // bS_RoleTableAdapter
            // 
            this.bS_RoleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BS_DepartmentTableAdapter = this.bS_DepartmentTableAdapter;
            this.tableAdapterManager.BS_RoleTableAdapter = this.bS_RoleTableAdapter;
            this.tableAdapterManager.BS_UserInfoTableAdapter = null;
            this.tableAdapterManager.BS_UserRightTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PSAP.dsPSAPTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // autoIdLabel
            // 
            autoIdLabel.AutoSize = true;
            autoIdLabel.Location = new System.Drawing.Point(3, 11);
            autoIdLabel.Name = "autoIdLabel";
            autoIdLabel.Size = new System.Drawing.Size(29, 12);
            autoIdLabel.TabIndex = 5;
            autoIdLabel.Text = "编号";
            // 
            // autoIdTextBox
            // 
            this.autoIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_RoleBindingSource, "AutoId", true));
            this.autoIdTextBox.Location = new System.Drawing.Point(74, 8);
            this.autoIdTextBox.Name = "autoIdTextBox";
            this.autoIdTextBox.Size = new System.Drawing.Size(100, 21);
            this.autoIdTextBox.TabIndex = 6;
            // 
            // roleNoLabel
            // 
            roleNoLabel.AutoSize = true;
            roleNoLabel.Location = new System.Drawing.Point(3, 38);
            roleNoLabel.Name = "roleNoLabel";
            roleNoLabel.Size = new System.Drawing.Size(53, 12);
            roleNoLabel.TabIndex = 7;
            roleNoLabel.Text = "角色编号";
            // 
            // roleNoTextBox
            // 
            this.roleNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_RoleBindingSource, "RoleNo", true));
            this.roleNoTextBox.Location = new System.Drawing.Point(74, 35);
            this.roleNoTextBox.Name = "roleNoTextBox";
            this.roleNoTextBox.Size = new System.Drawing.Size(100, 21);
            this.roleNoTextBox.TabIndex = 8;
            // 
            // roleNameLabel
            // 
            roleNameLabel.AutoSize = true;
            roleNameLabel.Location = new System.Drawing.Point(3, 65);
            roleNameLabel.Name = "roleNameLabel";
            roleNameLabel.Size = new System.Drawing.Size(53, 12);
            roleNameLabel.TabIndex = 9;
            roleNameLabel.Text = "角色名称";
            // 
            // roleNameTextBox
            // 
            this.roleNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_RoleBindingSource, "RoleName", true));
            this.roleNameTextBox.Location = new System.Drawing.Point(74, 62);
            this.roleNameTextBox.Name = "roleNameTextBox";
            this.roleNameTextBox.Size = new System.Drawing.Size(100, 21);
            this.roleNameTextBox.TabIndex = 10;
            // 
            // bS_RoleDataGridView
            // 
            this.bS_RoleDataGridView.AllowUserToAddRows = false;
            this.bS_RoleDataGridView.AllowUserToDeleteRows = false;
            this.bS_RoleDataGridView.AutoGenerateColumns = false;
            this.bS_RoleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.bS_RoleDataGridView.ColumnHeadersHeight = 28;
            this.bS_RoleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.autoIdDataGridViewTextBoxColumn,
            this.roleNoDataGridViewTextBoxColumn,
            this.roleNameDataGridViewTextBoxColumn});
            this.bS_RoleDataGridView.DataSource = this.bS_RoleBindingSource;
            this.bS_RoleDataGridView.Location = new System.Drawing.Point(3, 194);
            this.bS_RoleDataGridView.Name = "bS_RoleDataGridView";
            this.bS_RoleDataGridView.ReadOnly = true;
            this.bS_RoleDataGridView.RowTemplate.Height = 23;
            this.bS_RoleDataGridView.ShowEditingIcon = false;
            this.bS_RoleDataGridView.Size = new System.Drawing.Size(824, 267);
            this.bS_RoleDataGridView.TabIndex = 6;
            // 
            // autoIdDataGridViewTextBoxColumn
            // 
            this.autoIdDataGridViewTextBoxColumn.DataPropertyName = "AutoId";
            this.autoIdDataGridViewTextBoxColumn.HeaderText = "编号";
            this.autoIdDataGridViewTextBoxColumn.Name = "autoIdDataGridViewTextBoxColumn";
            this.autoIdDataGridViewTextBoxColumn.ReadOnly = true;
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
            // FrmUserRight
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1006, 628);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("宋体", 9F);
            this.MinimumSize = new System.Drawing.Size(430, 420);
            this.Name = "FrmUserRight";
            this.TabText = "用户权限";
            this.Text = "用户权限";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmUserRight_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabUserPower.ResumeLayout(false);
            this.tabUserPower.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).EndInit();
            this.tabRole.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bS_DepartmentBindingNavigator)).EndInit();
            this.bS_DepartmentBindingNavigator.ResumeLayout(false);
            this.bS_DepartmentBindingNavigator.PerformLayout();
            this.tsControl.ResumeLayout(false);
            this.tsControl.PerformLayout();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPSAP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSDepartmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bS_RoleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bS_RoleDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvwUserRigth;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingNavigator bS_DepartmentBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStrip tsControl;
        private System.Windows.Forms.ToolStripButton tsbInsert;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbCancel;
        private System.Windows.Forms.ToolStripButton tsbQuery;
        private System.Windows.Forms.ToolStripButton tsbDGViewExportToCSV;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.BindingSource bS_RoleBindingSource;
        private dsPSAPTableAdapters.BS_RoleTableAdapter bS_RoleTableAdapter;
        private dsPSAPTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox autoIdTextBox;
        private System.Windows.Forms.TextBox roleNameTextBox;
        private System.Windows.Forms.TextBox roleNoTextBox;
        private System.Windows.Forms.DataGridView bS_RoleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleNameDataGridViewTextBoxColumn;
    }
}