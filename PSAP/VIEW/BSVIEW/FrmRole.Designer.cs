namespace PSAP.VIEW.BSVIEW
{
    partial class FrmRole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRole));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bS_RoleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bS_RoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPSAP = new PSAP.dsPSAP();
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
            this.bS_RoleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tsControl = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            this.tsbQuery = new System.Windows.Forms.ToolStripButton();
            this.tsbDGViewExportToCSV = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.roleNameTextBox = new System.Windows.Forms.TextBox();
            this.roleNoTextBox = new System.Windows.Forms.TextBox();
            this.autoIdTextBox = new System.Windows.Forms.TextBox();
            this.bS_RoleDataGridView = new System.Windows.Forms.DataGridView();
            this.autoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bS_RoleTableAdapter = new PSAP.dsPSAPTableAdapters.BS_RoleTableAdapter();
            this.tableAdapterManager = new PSAP.dsPSAPTableAdapters.TableAdapterManager();
            autoIdLabel = new System.Windows.Forms.Label();
            roleNoLabel = new System.Windows.Forms.Label();
            roleNameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bS_RoleBindingNavigator)).BeginInit();
            this.bS_RoleBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bS_RoleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPSAP)).BeginInit();
            this.tsControl.SuspendLayout();
            this.pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bS_RoleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // autoIdLabel
            // 
            autoIdLabel.AutoSize = true;
            autoIdLabel.Location = new System.Drawing.Point(306, 38);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.bS_RoleBindingNavigator);
            this.panel1.Controls.Add(this.tsControl);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 72);
            this.panel1.TabIndex = 5;
            // 
            // bS_RoleBindingNavigator
            // 
            this.bS_RoleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bS_RoleBindingNavigator.BindingSource = this.bS_RoleBindingSource;
            this.bS_RoleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bS_RoleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bS_RoleBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.bS_RoleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bS_RoleBindingNavigatorSaveItem});
            this.bS_RoleBindingNavigator.Location = new System.Drawing.Point(0, 25);
            this.bS_RoleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bS_RoleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bS_RoleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bS_RoleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bS_RoleBindingNavigator.Name = "bS_RoleBindingNavigator";
            this.bS_RoleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bS_RoleBindingNavigator.Size = new System.Drawing.Size(276, 25);
            this.bS_RoleBindingNavigator.TabIndex = 8;
            this.bS_RoleBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新添";
            // 
            // bS_RoleBindingSource
            // 
            this.bS_RoleBindingSource.DataMember = "BS_Role";
            this.bS_RoleBindingSource.DataSource = this.dsPSAP;
            // 
            // dsPSAP
            // 
            this.dsPSAP.DataSetName = "dsPSAP";
            this.dsPSAP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "删除";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
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
            // bS_RoleBindingNavigatorSaveItem
            // 
            this.bS_RoleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bS_RoleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bS_RoleBindingNavigatorSaveItem.Image")));
            this.bS_RoleBindingNavigatorSaveItem.Name = "bS_RoleBindingNavigatorSaveItem";
            this.bS_RoleBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.bS_RoleBindingNavigatorSaveItem.Text = "保存数据";
            this.bS_RoleBindingNavigatorSaveItem.Click += new System.EventHandler(this.bS_RoleBindingNavigatorSaveItem_Click);
            // 
            // tsControl
            // 
            this.tsControl.Dock = System.Windows.Forms.DockStyle.None;
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
            this.tsControl.Size = new System.Drawing.Size(457, 25);
            this.tsControl.TabIndex = 4;
            this.tsControl.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(49, 22);
            this.tsbAdd.Text = "新增";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbEdit.Image")));
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(49, 22);
            this.tsbEdit.Text = "编辑";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(49, 22);
            this.tsbDelete.Text = "删除";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(49, 22);
            this.tsbSave.Text = "保存";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbCancel
            // 
            this.tsbCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancel.Image")));
            this.tsbCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancel.Name = "tsbCancel";
            this.tsbCancel.Size = new System.Drawing.Size(49, 22);
            this.tsbCancel.Text = "取消";
            this.tsbCancel.Click += new System.EventHandler(this.tsbCancel_Click);
            // 
            // tsbQuery
            // 
            this.tsbQuery.Image = ((System.Drawing.Image)(resources.GetObject("tsbQuery.Image")));
            this.tsbQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQuery.Name = "tsbQuery";
            this.tsbQuery.Size = new System.Drawing.Size(49, 22);
            this.tsbQuery.Text = "查询";
            // 
            // tsbDGViewExportToCSV
            // 
            this.tsbDGViewExportToCSV.Image = ((System.Drawing.Image)(resources.GetObject("tsbDGViewExportToCSV.Image")));
            this.tsbDGViewExportToCSV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDGViewExportToCSV.Name = "tsbDGViewExportToCSV";
            this.tsbDGViewExportToCSV.Size = new System.Drawing.Size(73, 22);
            this.tsbDGViewExportToCSV.Text = "导出数据";
            this.tsbDGViewExportToCSV.Click += new System.EventHandler(this.tsbDGViewExportToCSV_Click);
            // 
            // tsbClose
            // 
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(49, 22);
            this.tsbClose.Text = "退出";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
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
            this.pnlEdit.Location = new System.Drawing.Point(2, 81);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(606, 70);
            this.pnlEdit.TabIndex = 6;
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
            this.autoIdTextBox.Location = new System.Drawing.Point(341, 35);
            this.autoIdTextBox.Name = "autoIdTextBox";
            this.autoIdTextBox.Size = new System.Drawing.Size(100, 21);
            this.autoIdTextBox.TabIndex = 9;
            this.autoIdTextBox.Visible = false;
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
            this.bS_RoleDataGridView.Location = new System.Drawing.Point(2, 166);
            this.bS_RoleDataGridView.Name = "bS_RoleDataGridView";
            this.bS_RoleDataGridView.ReadOnly = true;
            this.bS_RoleDataGridView.RowTemplate.Height = 23;
            this.bS_RoleDataGridView.ShowEditingIcon = false;
            this.bS_RoleDataGridView.Size = new System.Drawing.Size(824, 304);
            this.bS_RoleDataGridView.TabIndex = 7;
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
            // bS_RoleTableAdapter
            // 
            this.bS_RoleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BS_DepartmentTableAdapter = null;
            this.tableAdapterManager.BS_MenuTableAdapter = null;
            this.tableAdapterManager.BS_RoleTableAdapter = this.bS_RoleTableAdapter;
            this.tableAdapterManager.BS_UserInfoTableAdapter = null;
            this.tableAdapterManager.BS_UserRightTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PSAP.dsPSAPTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FrmRole
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(846, 490);
            this.Controls.Add(this.bS_RoleDataGridView);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("宋体", 9F);
            this.Name = "FrmRole";
            this.TabText = "角色信息";
            this.Text = "角色信息";
            this.Load += new System.EventHandler(this.FrmRole_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bS_RoleBindingNavigator)).EndInit();
            this.bS_RoleBindingNavigator.ResumeLayout(false);
            this.bS_RoleBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bS_RoleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPSAP)).EndInit();
            this.tsControl.ResumeLayout(false);
            this.tsControl.PerformLayout();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bS_RoleDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.DataGridView bS_RoleDataGridView;
        private dsPSAP dsPSAP;
        private System.Windows.Forms.BindingSource bS_RoleBindingSource;
        private dsPSAPTableAdapters.BS_RoleTableAdapter bS_RoleTableAdapter;
        private dsPSAPTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bS_RoleBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton bS_RoleBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox roleNameTextBox;
        private System.Windows.Forms.TextBox roleNoTextBox;
        private System.Windows.Forms.TextBox autoIdTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleNameDataGridViewTextBoxColumn;
    }
}