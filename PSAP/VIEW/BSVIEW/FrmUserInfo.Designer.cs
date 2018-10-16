namespace PSAP.VIEW.BSVIEW
{
    partial class FrmUserInfo
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
            System.Windows.Forms.Label bfree1Label;
            System.Windows.Forms.Label bfree2Label;
            System.Windows.Forms.Label createDateLabel;
            System.Windows.Forms.Label bfree3Label;
            System.Windows.Forms.Label empNameLabel;
            System.Windows.Forms.Label bfree4Label;
            System.Windows.Forms.Label founderLabel;
            System.Windows.Forms.Label bfree5Label;
            System.Windows.Forms.Label departmentNoLabel;
            System.Windows.Forms.Label loginPwdLabel;
            System.Windows.Forms.Label loginIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserInfo));
            this.dsPSAP = new PSAP.dsPSAP();
            this.bS_UserInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bS_UserInfoTableAdapter = new PSAP.dsPSAPTableAdapters.BS_UserInfoTableAdapter();
            this.tableAdapterManager = new PSAP.dsPSAPTableAdapters.TableAdapterManager();
            this.miniToolStrip = new System.Windows.Forms.BindingNavigator(this.components);
            this.bSDepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bS_DepartmentTableAdapter = new PSAP.dsPSAPTableAdapters.BS_DepartmentTableAdapter();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.createDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bfree1TextBox = new System.Windows.Forms.TextBox();
            this.bfree2TextBox = new System.Windows.Forms.TextBox();
            this.bfree3TextBox = new System.Windows.Forms.TextBox();
            this.founderTextBox = new System.Windows.Forms.TextBox();
            this.empNameTextBox = new System.Windows.Forms.TextBox();
            this.bfree4TextBox = new System.Windows.Forms.TextBox();
            this.bfree5TextBox = new System.Windows.Forms.TextBox();
            this.loginPwdTextBox = new System.Windows.Forms.TextBox();
            this.loginIdTextBox = new System.Windows.Forms.TextBox();
            this.bS_UserInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tsControl = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            this.tsbQuery = new System.Windows.Forms.ToolStripButton();
            this.tsbDGViewExportToCSV = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.bS_UserInfoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bdnCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bdnMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bdnMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bdnPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bdnMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bdnMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            bfree1Label = new System.Windows.Forms.Label();
            bfree2Label = new System.Windows.Forms.Label();
            createDateLabel = new System.Windows.Forms.Label();
            bfree3Label = new System.Windows.Forms.Label();
            empNameLabel = new System.Windows.Forms.Label();
            bfree4Label = new System.Windows.Forms.Label();
            founderLabel = new System.Windows.Forms.Label();
            bfree5Label = new System.Windows.Forms.Label();
            departmentNoLabel = new System.Windows.Forms.Label();
            loginPwdLabel = new System.Windows.Forms.Label();
            loginIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsPSAP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bS_UserInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniToolStrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSDepartmentBindingSource)).BeginInit();
            this.pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bS_UserInfoDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.tsControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bS_UserInfoBindingNavigator)).BeginInit();
            this.bS_UserInfoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // bfree1Label
            // 
            bfree1Label.AutoSize = true;
            bfree1Label.Location = new System.Drawing.Point(352, 21);
            bfree1Label.Name = "bfree1Label";
            bfree1Label.Size = new System.Drawing.Size(47, 12);
            bfree1Label.TabIndex = 15;
            bfree1Label.Text = "Bfree1:";
            bfree1Label.Visible = false;
            // 
            // bfree2Label
            // 
            bfree2Label.AutoSize = true;
            bfree2Label.Location = new System.Drawing.Point(352, 48);
            bfree2Label.Name = "bfree2Label";
            bfree2Label.Size = new System.Drawing.Size(47, 12);
            bfree2Label.TabIndex = 17;
            bfree2Label.Text = "Bfree2:";
            bfree2Label.Visible = false;
            // 
            // createDateLabel
            // 
            createDateLabel.AutoSize = true;
            createDateLabel.Location = new System.Drawing.Point(3, 154);
            createDateLabel.Name = "createDateLabel";
            createDateLabel.Size = new System.Drawing.Size(53, 12);
            createDateLabel.TabIndex = 13;
            createDateLabel.Text = "录入日期";
            // 
            // bfree3Label
            // 
            bfree3Label.AutoSize = true;
            bfree3Label.Location = new System.Drawing.Point(352, 75);
            bfree3Label.Name = "bfree3Label";
            bfree3Label.Size = new System.Drawing.Size(47, 12);
            bfree3Label.TabIndex = 19;
            bfree3Label.Text = "Bfree3:";
            bfree3Label.Visible = false;
            // 
            // empNameLabel
            // 
            empNameLabel.AutoSize = true;
            empNameLabel.Location = new System.Drawing.Point(3, 45);
            empNameLabel.Name = "empNameLabel";
            empNameLabel.Size = new System.Drawing.Size(53, 12);
            empNameLabel.TabIndex = 3;
            empNameLabel.Text = "用户姓名";
            // 
            // bfree4Label
            // 
            bfree4Label.AutoSize = true;
            bfree4Label.Location = new System.Drawing.Point(352, 102);
            bfree4Label.Name = "bfree4Label";
            bfree4Label.Size = new System.Drawing.Size(47, 12);
            bfree4Label.TabIndex = 21;
            bfree4Label.Text = "Bfree4:";
            bfree4Label.Visible = false;
            // 
            // founderLabel
            // 
            founderLabel.AutoSize = true;
            founderLabel.Location = new System.Drawing.Point(3, 126);
            founderLabel.Name = "founderLabel";
            founderLabel.Size = new System.Drawing.Size(41, 12);
            founderLabel.TabIndex = 11;
            founderLabel.Text = "录入人";
            // 
            // bfree5Label
            // 
            bfree5Label.AutoSize = true;
            bfree5Label.Location = new System.Drawing.Point(352, 129);
            bfree5Label.Name = "bfree5Label";
            bfree5Label.Size = new System.Drawing.Size(47, 12);
            bfree5Label.TabIndex = 23;
            bfree5Label.Text = "Bfree5:";
            bfree5Label.Visible = false;
            // 
            // departmentNoLabel
            // 
            departmentNoLabel.AutoSize = true;
            departmentNoLabel.Location = new System.Drawing.Point(3, 72);
            departmentNoLabel.Name = "departmentNoLabel";
            departmentNoLabel.Size = new System.Drawing.Size(53, 12);
            departmentNoLabel.TabIndex = 5;
            departmentNoLabel.Text = "部门名称";
            // 
            // loginPwdLabel
            // 
            loginPwdLabel.AutoSize = true;
            loginPwdLabel.Location = new System.Drawing.Point(3, 99);
            loginPwdLabel.Name = "loginPwdLabel";
            loginPwdLabel.Size = new System.Drawing.Size(53, 12);
            loginPwdLabel.TabIndex = 9;
            loginPwdLabel.Text = "登录密码";
            // 
            // loginIdLabel
            // 
            loginIdLabel.AutoSize = true;
            loginIdLabel.Location = new System.Drawing.Point(3, 18);
            loginIdLabel.Name = "loginIdLabel";
            loginIdLabel.Size = new System.Drawing.Size(41, 12);
            loginIdLabel.TabIndex = 7;
            loginIdLabel.Text = "用户ID";
            // 
            // dsPSAP
            // 
            this.dsPSAP.DataSetName = "dsPSAP";
            this.dsPSAP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bS_UserInfoBindingSource
            // 
            this.bS_UserInfoBindingSource.DataMember = "BS_UserInfo";
            this.bS_UserInfoBindingSource.DataSource = this.dsPSAP;
            // 
            // bS_UserInfoTableAdapter
            // 
            this.bS_UserInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BS_DepartmentTableAdapter = null;
            this.tableAdapterManager.BS_MenuTableAdapter = null;
            this.tableAdapterManager.BS_RoleTableAdapter = null;
            this.tableAdapterManager.BS_UserInfoTableAdapter = this.bS_UserInfoTableAdapter;
            this.tableAdapterManager.BS_UserRightTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PSAP.dsPSAPTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AddNewItem = null;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.CanOverflow = false;
            this.miniToolStrip.CountItem = null;
            this.miniToolStrip.DeleteItem = null;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.miniToolStrip.Location = new System.Drawing.Point(203, 3);
            this.miniToolStrip.MoveFirstItem = null;
            this.miniToolStrip.MoveLastItem = null;
            this.miniToolStrip.MoveNextItem = null;
            this.miniToolStrip.MovePreviousItem = null;
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.PositionItem = null;
            this.miniToolStrip.Size = new System.Drawing.Size(206, 25);
            this.miniToolStrip.TabIndex = 0;
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
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.comboBox1);
            this.pnlEdit.Controls.Add(bfree1Label);
            this.pnlEdit.Controls.Add(this.createDateDateTimePicker);
            this.pnlEdit.Controls.Add(this.bfree1TextBox);
            this.pnlEdit.Controls.Add(bfree2Label);
            this.pnlEdit.Controls.Add(this.bfree2TextBox);
            this.pnlEdit.Controls.Add(createDateLabel);
            this.pnlEdit.Controls.Add(bfree3Label);
            this.pnlEdit.Controls.Add(empNameLabel);
            this.pnlEdit.Controls.Add(this.bfree3TextBox);
            this.pnlEdit.Controls.Add(this.founderTextBox);
            this.pnlEdit.Controls.Add(bfree4Label);
            this.pnlEdit.Controls.Add(this.empNameTextBox);
            this.pnlEdit.Controls.Add(this.bfree4TextBox);
            this.pnlEdit.Controls.Add(founderLabel);
            this.pnlEdit.Controls.Add(bfree5Label);
            this.pnlEdit.Controls.Add(departmentNoLabel);
            this.pnlEdit.Controls.Add(this.bfree5TextBox);
            this.pnlEdit.Controls.Add(this.loginPwdTextBox);
            this.pnlEdit.Controls.Add(loginPwdLabel);
            this.pnlEdit.Controls.Add(loginIdLabel);
            this.pnlEdit.Controls.Add(this.loginIdTextBox);
            this.pnlEdit.Enabled = false;
            this.pnlEdit.Location = new System.Drawing.Point(0, 90);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(778, 179);
            this.pnlEdit.TabIndex = 38;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bS_UserInfoBindingSource, "DepartmentNo", true));
            this.comboBox1.DataSource = this.bSDepartmentBindingSource;
            this.comboBox1.DisplayMember = "DepartmentName";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(98, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 20);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "DepartmentNo";
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // createDateDateTimePicker
            // 
            this.createDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bS_UserInfoBindingSource, "CreateDate", true));
            this.createDateDateTimePicker.Enabled = false;
            this.createDateDateTimePicker.Location = new System.Drawing.Point(98, 150);
            this.createDateDateTimePicker.Name = "createDateDateTimePicker";
            this.createDateDateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.createDateDateTimePicker.TabIndex = 14;
            // 
            // bfree1TextBox
            // 
            this.bfree1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_UserInfoBindingSource, "Bfree1", true));
            this.bfree1TextBox.Location = new System.Drawing.Point(447, 18);
            this.bfree1TextBox.Name = "bfree1TextBox";
            this.bfree1TextBox.Size = new System.Drawing.Size(200, 21);
            this.bfree1TextBox.TabIndex = 16;
            this.bfree1TextBox.Visible = false;
            // 
            // bfree2TextBox
            // 
            this.bfree2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_UserInfoBindingSource, "Bfree2", true));
            this.bfree2TextBox.Location = new System.Drawing.Point(447, 45);
            this.bfree2TextBox.Name = "bfree2TextBox";
            this.bfree2TextBox.Size = new System.Drawing.Size(200, 21);
            this.bfree2TextBox.TabIndex = 18;
            this.bfree2TextBox.Visible = false;
            // 
            // bfree3TextBox
            // 
            this.bfree3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_UserInfoBindingSource, "Bfree3", true));
            this.bfree3TextBox.Location = new System.Drawing.Point(447, 72);
            this.bfree3TextBox.Name = "bfree3TextBox";
            this.bfree3TextBox.Size = new System.Drawing.Size(200, 21);
            this.bfree3TextBox.TabIndex = 20;
            this.bfree3TextBox.Visible = false;
            // 
            // founderTextBox
            // 
            this.founderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_UserInfoBindingSource, "Founder", true));
            this.founderTextBox.Enabled = false;
            this.founderTextBox.Location = new System.Drawing.Point(98, 123);
            this.founderTextBox.Name = "founderTextBox";
            this.founderTextBox.Size = new System.Drawing.Size(200, 21);
            this.founderTextBox.TabIndex = 12;
            // 
            // empNameTextBox
            // 
            this.empNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_UserInfoBindingSource, "EmpName", true));
            this.empNameTextBox.Location = new System.Drawing.Point(98, 42);
            this.empNameTextBox.Name = "empNameTextBox";
            this.empNameTextBox.Size = new System.Drawing.Size(200, 21);
            this.empNameTextBox.TabIndex = 6;
            this.empNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.empNameTextBox_KeyPress);
            // 
            // bfree4TextBox
            // 
            this.bfree4TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_UserInfoBindingSource, "Bfree4", true));
            this.bfree4TextBox.Location = new System.Drawing.Point(447, 99);
            this.bfree4TextBox.Name = "bfree4TextBox";
            this.bfree4TextBox.Size = new System.Drawing.Size(200, 21);
            this.bfree4TextBox.TabIndex = 22;
            this.bfree4TextBox.Visible = false;
            // 
            // bfree5TextBox
            // 
            this.bfree5TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_UserInfoBindingSource, "Bfree5", true));
            this.bfree5TextBox.Location = new System.Drawing.Point(447, 126);
            this.bfree5TextBox.Name = "bfree5TextBox";
            this.bfree5TextBox.Size = new System.Drawing.Size(200, 21);
            this.bfree5TextBox.TabIndex = 24;
            this.bfree5TextBox.Visible = false;
            // 
            // loginPwdTextBox
            // 
            this.loginPwdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_UserInfoBindingSource, "LoginPwd", true));
            this.loginPwdTextBox.Enabled = false;
            this.loginPwdTextBox.Location = new System.Drawing.Point(98, 96);
            this.loginPwdTextBox.Name = "loginPwdTextBox";
            this.loginPwdTextBox.PasswordChar = '*';
            this.loginPwdTextBox.Size = new System.Drawing.Size(200, 21);
            this.loginPwdTextBox.TabIndex = 10;
            // 
            // loginIdTextBox
            // 
            this.loginIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_UserInfoBindingSource, "LoginId", true));
            this.loginIdTextBox.Location = new System.Drawing.Point(98, 15);
            this.loginIdTextBox.Name = "loginIdTextBox";
            this.loginIdTextBox.Size = new System.Drawing.Size(200, 21);
            this.loginIdTextBox.TabIndex = 5;
            this.loginIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loginIdTextBox_KeyPress);
            // 
            // bS_UserInfoDataGridView
            // 
            this.bS_UserInfoDataGridView.AutoGenerateColumns = false;
            this.bS_UserInfoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.bS_UserInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bS_UserInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.bS_UserInfoDataGridView.DataSource = this.bS_UserInfoBindingSource;
            this.bS_UserInfoDataGridView.Location = new System.Drawing.Point(0, 285);
            this.bS_UserInfoDataGridView.Name = "bS_UserInfoDataGridView";
            this.bS_UserInfoDataGridView.ReadOnly = true;
            this.bS_UserInfoDataGridView.RowTemplate.Height = 23;
            this.bS_UserInfoDataGridView.Size = new System.Drawing.Size(830, 185);
            this.bS_UserInfoDataGridView.TabIndex = 39;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AutoId";
            this.dataGridViewTextBoxColumn1.HeaderText = "编号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 54;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "LoginId";
            this.dataGridViewTextBoxColumn4.HeaderText = "用户ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 66;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EmpName";
            this.dataGridViewTextBoxColumn2.HeaderText = "用户姓名";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 78;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DepartmentNo";
            this.dataGridViewTextBoxColumn3.HeaderText = "部门编号";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 78;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Founder";
            this.dataGridViewTextBoxColumn6.HeaderText = "录入人";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 66;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CreateDate";
            this.dataGridViewTextBoxColumn7.HeaderText = "录入日期";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 78;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tsControl);
            this.panel1.Controls.Add(this.bS_UserInfoBindingNavigator);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 58);
            this.panel1.TabIndex = 40;
            // 
            // tsControl
            // 
            this.tsControl.AutoSize = false;
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
            this.tsControl.Size = new System.Drawing.Size(495, 25);
            this.tsControl.TabIndex = 28;
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
            // bS_UserInfoBindingNavigator
            // 
            this.bS_UserInfoBindingNavigator.AddNewItem = null;
            this.bS_UserInfoBindingNavigator.AutoSize = false;
            this.bS_UserInfoBindingNavigator.BindingSource = this.bS_UserInfoBindingSource;
            this.bS_UserInfoBindingNavigator.CountItem = this.bdnCountItem;
            this.bS_UserInfoBindingNavigator.DeleteItem = null;
            this.bS_UserInfoBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.bS_UserInfoBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bS_UserInfoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bdnMoveFirstItem,
            this.bdnMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bdnPositionItem,
            this.bdnCountItem,
            this.bindingNavigatorSeparator1,
            this.bdnMoveNextItem,
            this.bdnMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bS_UserInfoBindingNavigator.Location = new System.Drawing.Point(0, 25);
            this.bS_UserInfoBindingNavigator.MoveFirstItem = this.bdnMoveFirstItem;
            this.bS_UserInfoBindingNavigator.MoveLastItem = this.bdnMoveLastItem;
            this.bS_UserInfoBindingNavigator.MoveNextItem = this.bdnMoveNextItem;
            this.bS_UserInfoBindingNavigator.MovePreviousItem = this.bdnMovePreviousItem;
            this.bS_UserInfoBindingNavigator.Name = "bS_UserInfoBindingNavigator";
            this.bS_UserInfoBindingNavigator.PositionItem = this.bdnPositionItem;
            this.bS_UserInfoBindingNavigator.Size = new System.Drawing.Size(249, 25);
            this.bS_UserInfoBindingNavigator.TabIndex = 1;
            this.bS_UserInfoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bdnCountItem
            // 
            this.bdnCountItem.Name = "bdnCountItem";
            this.bdnCountItem.Size = new System.Drawing.Size(32, 22);
            this.bdnCountItem.Text = "/ {0}";
            this.bdnCountItem.ToolTipText = "总项数";
            // 
            // bdnMoveFirstItem
            // 
            this.bdnMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
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
            this.bdnPositionItem.Size = new System.Drawing.Size(50, 23);
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
            // FrmUserInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(842, 482);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bS_UserInfoDataGridView);
            this.Controls.Add(this.pnlEdit);
            this.Font = new System.Drawing.Font("宋体", 9F);
            this.HideOnClose = true;
            this.Name = "FrmUserInfo";
            this.TabText = "用户信息";
            this.Text = "用户信息";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmUserInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPSAP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bS_UserInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniToolStrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSDepartmentBindingSource)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bS_UserInfoDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tsControl.ResumeLayout(false);
            this.tsControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bS_UserInfoBindingNavigator)).EndInit();
            this.bS_UserInfoBindingNavigator.ResumeLayout(false);
            this.bS_UserInfoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private dsPSAP dsPSAP;
        private System.Windows.Forms.BindingSource bS_UserInfoBindingSource;
        private dsPSAPTableAdapters.BS_UserInfoTableAdapter bS_UserInfoTableAdapter;
        private dsPSAPTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator miniToolStrip;
        private System.Windows.Forms.BindingSource bSDepartmentBindingSource;
        private dsPSAPTableAdapters.BS_DepartmentTableAdapter bS_DepartmentTableAdapter;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker createDateDateTimePicker;
        private System.Windows.Forms.TextBox bfree1TextBox;
        private System.Windows.Forms.TextBox bfree2TextBox;
        private System.Windows.Forms.TextBox bfree3TextBox;
        private System.Windows.Forms.TextBox founderTextBox;
        private System.Windows.Forms.TextBox empNameTextBox;
        private System.Windows.Forms.TextBox bfree4TextBox;
        private System.Windows.Forms.TextBox bfree5TextBox;
        private System.Windows.Forms.TextBox loginPwdTextBox;
        private System.Windows.Forms.TextBox loginIdTextBox;
        private System.Windows.Forms.DataGridView bS_UserInfoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingNavigator bS_UserInfoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbCancel;
        private System.Windows.Forms.ToolStripButton tsbQuery;
        private System.Windows.Forms.ToolStripButton tsbDGViewExportToCSV;
        private System.Windows.Forms.ToolStripButton tsbClose;
    }
}