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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tvwUserRigth = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabUserPower = new System.Windows.Forms.TabPage();
            this.cklFormButton = new System.Windows.Forms.CheckedListBox();
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
            this.bS_RoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bSDepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bS_DepartmentTableAdapter = new PSAP.dsPSAPTableAdapters.BS_DepartmentTableAdapter();
            this.bS_RoleTableAdapter = new PSAP.dsPSAPTableAdapters.BS_RoleTableAdapter();
            this.tableAdapterManager = new PSAP.dsPSAPTableAdapters.TableAdapterManager();
            this.bS_MenuTableAdapter = new PSAP.dsPSAPTableAdapters.BS_MenuTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabUserPower.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).BeginInit();
            this.tabMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bS_MenuDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bS_MenuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPSAP)).BeginInit();
            this.cmnsMainMeunTree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bS_RoleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSDepartmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tvwUserRigth
            // 
            this.tvwUserRigth.ItemHeight = 20;
            this.tvwUserRigth.Location = new System.Drawing.Point(261, 36);
            this.tvwUserRigth.Name = "tvwUserRigth";
            this.tvwUserRigth.Size = new System.Drawing.Size(294, 531);
            this.tvwUserRigth.TabIndex = 0;
            this.tvwUserRigth.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            this.tvwUserRigth.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwUserRigth_AfterSelect);
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
            this.tabUserPower.Controls.Add(this.cklFormButton);
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
            this.tabUserPower.Controls.Add(this.tvwUserRigth);
            this.tabUserPower.Location = new System.Drawing.Point(4, 22);
            this.tabUserPower.Name = "tabUserPower";
            this.tabUserPower.Padding = new System.Windows.Forms.Padding(3);
            this.tabUserPower.Size = new System.Drawing.Size(998, 602);
            this.tabUserPower.TabIndex = 0;
            this.tabUserPower.Text = "用户权限管理";
            this.tabUserPower.UseVisualStyleBackColor = true;
            // 
            // cklFormButton
            // 
            this.cklFormButton.FormattingEnabled = true;
            this.cklFormButton.Location = new System.Drawing.Point(564, 36);
            this.cklFormButton.Name = "cklFormButton";
            this.cklFormButton.Size = new System.Drawing.Size(174, 532);
            this.cklFormButton.TabIndex = 15;
            // 
            // btnSaveRight
            // 
            this.btnSaveRight.Location = new System.Drawing.Point(526, 8);
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
            this.label5.Location = new System.Drawing.Point(269, 13);
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
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MenuName";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn2.HeaderText = "菜单ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MenuText";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn3.HeaderText = "菜单名称";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ParentMenuName";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle3;
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
            this.tvwMainMenu.ItemHeight = 20;
            this.tvwMainMenu.LabelEdit = true;
            this.tvwMainMenu.Location = new System.Drawing.Point(3, 6);
            this.tvwMainMenu.Name = "tvwMainMenu";
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
            this.tabRole.Location = new System.Drawing.Point(4, 22);
            this.tabRole.Name = "tabRole";
            this.tabRole.Size = new System.Drawing.Size(998, 602);
            this.tabRole.TabIndex = 2;
            this.tabRole.Text = "角色权限管理";
            this.tabRole.UseVisualStyleBackColor = true;
            // 
            // bS_RoleBindingSource
            // 
            this.bS_RoleBindingSource.DataMember = "BS_Role";
            this.bS_RoleBindingSource.DataSource = this.dsPSAP;
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
            ((System.ComponentModel.ISupportInitialize)(this.bS_RoleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSDepartmentBindingSource)).EndInit();
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
        private System.Windows.Forms.CheckedListBox cklFormButton;
    }
}